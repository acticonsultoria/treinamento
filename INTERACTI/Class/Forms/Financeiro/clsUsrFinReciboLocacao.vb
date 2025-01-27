Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.Drawing.Printing
Imports Janus.Windows.CalendarCombo

Public Class clsUsrFinReciboLocacao

#Region "::: VARIAVEIS :::"

#Region "::: VARIAVEIS - RECIBO :::"

    Private sDataEmissao As String
    Private sNumeroRecibo As String
    Private iCodigo As Integer
    Private iCodigoCliente As Integer
    Private dValorTotalEnergiaEletrica As Double
    Private dValorTotalAgua As Double
    Private dValorTotalRateio As Double
    Private dValorTotalEsgoto As Double
    Private dValorTotalOutrasCobrancas As Double
    Private dValorTotalDescontos As Double
    Private dValorTotal As Double

#End Region


#End Region

#Region "::: PROPERTIE :::"

#Region "::: PROPERTIE - RECIBO :::"

    Public Property DataEmissao() As String
        Get
            Return sDataEmissao
        End Get
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public Property NumeroRecibo() As String
        Get
            Return sNumeroRecibo
        End Get
        Set(ByVal value As String)
            sNumeroRecibo = value
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

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property ValorEnergiaEletrica() As Double
        Get
            Return dValorTotalEnergiaEletrica
        End Get
        Set(ByVal value As Double)
            dValorTotalEnergiaEletrica = value
        End Set
    End Property

    Public Property ValorAgua() As Double
        Get
            Return dValorTotalAgua
        End Get
        Set(ByVal value As Double)
            dValorTotalAgua = value
        End Set
    End Property

    Public Property ValorRateio() As Double
        Get
            Return dValorTotalRateio
        End Get
        Set(ByVal value As Double)
            dValorTotalRateio = value
        End Set
    End Property

    Public Property ValorEsgoto() As Double
        Get
            Return dValorTotalEsgoto
        End Get
        Set(ByVal value As Double)
            dValorTotalEsgoto = value
        End Set
    End Property

    Public Property ValorOutrasCobrancas() As Double
        Get
            Return dValorTotalOutrasCobrancas
        End Get
        Set(ByVal value As Double)
            dValorTotalOutrasCobrancas = value
        End Set
    End Property

    Public Property ValorDescontos() As Double
        Get
            Return dValorTotalDescontos
        End Get
        Set(ByVal value As Double)
            dValorTotalDescontos = value
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

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: RECIBO :::"

    Public Sub LoadGridListagem(ByVal oGrid As GridEX, _
                        ByVal sNumeroRecibo As String, _
                        ByVal sCliente As String, _
                        ByVal dDataEmissaoInicio As String, _
                        ByVal dDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Data de Emissão - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(dDataEmissaoInicio = "", DBNull.Value, dDataEmissaoInicio) : i += 1

            'Seta Parametros - Data de Emissão - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(dDataEmissaoTermino = "", DBNull.Value, dDataEmissaoTermino) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_capa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigoCliente As Long, _
                                        ByVal txtAreaConstruidaLocada As NumericEditBox, _
                                        ByVal txtAreaPatioLocada As NumericEditBox, _
                                        ByVal txtValorAluguel As NumericEditBox, _
                                        ByVal txtReferenciaInterna As MaskedEditBox, _
                                        ByVal dtpDataInicioVigenciaContrato As CalendarCombo, _
                                        ByVal dtpDataTerminoVigenciaContrato As CalendarCombo)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCliente : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAreaConstruidaLocada.Value = oSqlDataReader.Item("area_construida_locada")
                txtAreaPatioLocada.Value = oSqlDataReader.Item("area_patio_locada")
                txtValorAluguel.Value = oSqlDataReader.Item("valor_aluguel")
                txtReferenciaInterna.Text = IIf(IsDBNull(oSqlDataReader.Item("referencia_interna")), "", oSqlDataReader.Item("referencia_interna"))
                dtpDataInicioVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_inicio_vigencia_contrato"))
                dtpDataTerminoVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_termino_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_termino_vigencia_contrato"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadTabelaLeitura(ByVal txtAte10Agua As NumericEditBox, _
                                 ByVal txtAte20Agua As NumericEditBox, _
                                 ByVal txtAte50Agua As NumericEditBox, _
                                 ByVal txtAcima50Agua As NumericEditBox, _
                                 ByVal txtRateioAgua As NumericEditBox, _
                                 ByVal txtTaxaAnaliseAgua As NumericEditBox, _
                                 ByVal txtAte10Esgoto As NumericEditBox, _
                                 ByVal txtAte20Esgoto As NumericEditBox, _
                                 ByVal txtAte50Esgoto As NumericEditBox, _
                                 ByVal txtAcima50Esgoto As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_tabela_leitura", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAte10Agua.Value = oSqlDataReader.Item("valor_ate_10_agua")
                txtAte20Agua.Value = oSqlDataReader.Item("valor_ate_20_agua")
                txtAte50Agua.Value = oSqlDataReader.Item("valor_ate_50_agua")
                txtAcima50Agua.Value = oSqlDataReader.Item("valor_acima_50_agua")
                txtRateioAgua.Value = (oSqlDataReader.Item("taxa_analise_agua") / oSqlDataReader.Item("rateio_agua"))
                txtTaxaAnaliseAgua.Value = oSqlDataReader.Item("taxa_analise_agua")
                txtAte10Esgoto.Value = oSqlDataReader.Item("valor_ate_10_esgoto")
                txtAte20Esgoto.Value = oSqlDataReader.Item("valor_ate_20_esgoto")
                txtAte50Esgoto.Value = oSqlDataReader.Item("valor_ate_50_esgoto")
                txtAcima50Esgoto.Value = oSqlDataReader.Item("valor_acima_50_esgoto")
            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRecibo(ByRef btnSavar As UIButton)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

            'Seta Parametros - Número Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Valor Total Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalEnergiaEletrica : i += 1

            'Seta Parametros - Valor Total Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalAgua : i += 1

            'Seta Parametros - Valor Total Rateiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_rateio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalRateio : i += 1

            'Seta Parametros - Valor Total Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalEsgoto : i += 1

            'Seta Parametros - Valor Total Outras Cobranças
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalOutrasCobrancas : i += 1

            'Seta Parametros - Valor Total Descontos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalDescontos : i += 1

            'Seta Parametros - Valor Total Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Codigo Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_capa", oSqlParameter)

            'Seta Váriavel 
            btnSavar.Tag = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRecibo(ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try 'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1


            'Seta Parametros - Número Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Valor Total Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalEnergiaEletrica : i += 1

            'Seta Parametros - Valor Total Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalAgua : i += 1

            'Seta Parametros - Valor Total Rateiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_rateio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalRateio : i += 1

            'Seta Parametros - Valor Total Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalEsgoto : i += 1

            'Seta Parametros - Valor Total Outras Cobranças
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalOutrasCobrancas : i += 1

            'Seta Parametros - Valor Total Descontos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotalDescontos : i += 1

            'Seta Parametros - Valor Total Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Codigo Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRecibo()
        Try
            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_capa", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosRecibo(ByVal iCodigo As Integer, _
                               ByVal txtNumeroRecibo As MaskedEditBox, _
                               ByVal txtDataEmissao As CalendarCombo, _
                               ByVal txtCalculoValorEnergia As NumericEditBox, _
                               ByVal txtCalculoValorAgua As NumericEditBox, _
                               ByVal txtCalculoValorEsgoto As NumericEditBox, _
                               ByVal txtCalculoValorOutrasCobrancas As NumericEditBox, _
                               ByVal txtCalculoValorDescontos As NumericEditBox,
                               ByVal txtCalculoValorTotal As NumericEditBox, _
                               ByVal cboCliente As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_capa_dados", oSqlParameter)

            While oSqlDataReader.Read
                cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")
                txtDataEmissao.Text = oSqlDataReader.Item("data_emissao")
                txtNumeroRecibo.Text = oSqlDataReader.Item("numero_recibo")
               
            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DuplicarRecibo(ByVal iCodigo As Integer, _
                              ByRef iCodigoNovo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Novo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_novo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_duplicar", oSqlParameter)

            'Seta Váriavel 
            iCodigoNovo = oSqlParameter(2).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function GeraNumeroDocumento()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim sReturn As String
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_gerar_numero_documento", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosGalpao(ByVal lCodigo As Long, _
                               ByRef dRateioConsumoAgua As Double)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_galpao_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                dRateioConsumoAgua = oSqlDataReader.Item("rateio_consumo_agua")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCasa(ByVal lCodigo As Long, _
                              ByRef dRateioConsumoAgua As Double)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_casa_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                dRateioConsumoAgua = oSqlDataReader.Item("rateio_consumo_agua")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Importar(ByVal lCodigoAcordo As Long, _
                        ByRef lCodigoRecibo As Long)



        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_acordo_comercial", oSqlParameter)

            iCodigo = oSqlParameter(1).Value
            lCodigoRecibo = oSqlParameter(1).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

#Region "::: GALPÃO :::"

    Public Sub InsertGalpao(ByVal lCodigoRecibo As Long, _
                            ByVal lCodigoGalpao As Long, _
                            ByVal dAreaConstruidaLocada As Double, _
                            ByVal dAreaPatioLocada As Double, _
                            ByVal dValorAluguel As Double, _
                            ByVal dInicioVigenciaContrato As DateTime, _
                            ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_patio_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaPatioLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

           

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_galpao", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteGalpao()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_galpao", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosGalpao(ByVal lCodigo As Long, _
                               ByVal txtAreaConstruidaLocada As NumericEditBox, _
                               ByVal txtAreaPatioLocada As NumericEditBox, _
                               ByVal txtValorAluguel As NumericEditBox, _
                               ByVal dtpDataInicioVigenciaContrato As CalendarCombo, _
                               ByVal dtpDataTerminoVigenciaContrato As CalendarCombo)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_galpao_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAreaConstruidaLocada.Value = oSqlDataReader.Item("area_construida_locada")
                txtAreaPatioLocada.Value = oSqlDataReader.Item("area_patio_locada")
                txtValorAluguel.Value = oSqlDataReader.Item("valor_aluguel")
                dtpDataInicioVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_inicio_vigencia_contrato"))
                dtpDataTerminoVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_termino_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_termino_vigencia_contrato"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub UpdateGalpao(ByVal iCodigo As Integer, _
                            ByVal lCodigoRecibo As Long, _
                            ByVal lCodigoGalpao As Long, _
                            ByVal dAreaConstruidaLocada As Double, _
                            ByVal dAreaPatioLocada As Double, _
                            ByVal dValorAluguel As Double, _
                            ByVal dInicioVigenciaContrato As DateTime, _
                            ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_patio_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaPatioLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

           

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
            oSqlParameter(i).Value = iCodigo



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_galpao", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridGalpao(ByVal oGrid As GridEX, _
                                 ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_galpao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: SALA COMERCIAL :::"

    Public Sub InsertSalaComercial(ByVal lCodigoRecibo As Long, _
                           ByVal lCodigoSala As Long, _
                           ByVal dAreaConstruidaLocada As Double, _
                           ByVal dAreaTerrenoLocada As Double, _
                           ByVal dValorAluguel As Double, _
                           ByVal dInicioVigenciaContrato As DateTime, _
                           ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_sala"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoSala : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_terreno_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaTerrenoLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_sala", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteSalaComercial()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_sala", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateSalaComercial(ByVal iCodigo As Integer, _
                           ByVal lCodigoRecibo As Long, _
                           ByVal lCodigoSala As Long, _
                           ByVal dAreaConstruidaLocada As Double, _
                           ByVal dAreaTerrenoLocada As Double, _
                           ByVal dValorAluguel As Double, _
                           ByVal dInicioVigenciaContrato As DateTime, _
                           ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_sala"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoSala : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_terreno_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaTerrenoLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

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
            oSqlParameter(i).Value = iCodigo



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_sala", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridSalaComercial(ByVal oGrid As GridEX, _
                                ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_sala", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosSala(ByVal lCodigo As Long, _
                              ByVal txtAreaConstruidaLocada As NumericEditBox, _
                              ByVal txtAreaPatioLocada As NumericEditBox, _
                              ByVal txtValorAluguel As NumericEditBox, _
                              ByVal dtpDataInicioVigenciaContrato As CalendarCombo, _
                              ByVal dtpDataTerminoVigenciaContrato As CalendarCombo)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_sala_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAreaConstruidaLocada.Value = oSqlDataReader.Item("area_construida_locada")
                txtAreaPatioLocada.Value = oSqlDataReader.Item("area_terreno_locada")
                txtValorAluguel.Value = oSqlDataReader.Item("valor_aluguel")
                dtpDataInicioVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_inicio_vigencia_contrato"))
                dtpDataTerminoVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_termino_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_termino_vigencia_contrato"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: BOX :::"

    Public Sub InsertBox(ByVal lCodigoRecibo As Long, _
                         ByVal lCodigoBox As Long, _
                         ByVal dAreaConstruidaLocada As Double, _
                         ByVal dAreaTerrenoLocada As Double, _
                         ByVal dValorAluguel As Double, _
                         ByVal dInicioVigenciaContrato As DateTime, _
                         ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_box"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoBox : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_terreno_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaTerrenoLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_box", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteBox()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_box", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosBox(ByVal lCodigo As Long, _
                               ByVal txtAreaConstruidaLocada As NumericEditBox, _
                               ByVal txtAreaPatioLocada As NumericEditBox, _
                               ByVal txtValorAluguel As NumericEditBox, _
                               ByVal dtpDataInicioVigenciaContrato As CalendarCombo, _
                               ByVal dtpDataTerminoVigenciaContrato As CalendarCombo)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_box_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAreaConstruidaLocada.Value = oSqlDataReader.Item("area_construida_locada")
                txtAreaPatioLocada.Value = oSqlDataReader.Item("area_terreno_locada")
                txtValorAluguel.Value = oSqlDataReader.Item("valor_aluguel")
                dtpDataInicioVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_inicio_vigencia_contrato"))
                dtpDataTerminoVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_termino_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_termino_vigencia_contrato"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateBox(ByVal iCodigo As Integer, _
                          ByVal lCodigoRecibo As Long, _
                         ByVal lCodigoBox As Long, _
                         ByVal dAreaConstruidaLocada As Double, _
                         ByVal dAreaTerrenoLocada As Double, _
                         ByVal dValorAluguel As Double, _
                         ByVal dInicioVigenciaContrato As DateTime, _
                         ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_box"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoBox : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_terreno_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaTerrenoLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

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
            oSqlParameter(i).Value = iCodigo



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_box", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridBox(ByVal oGrid As GridEX, _
                               ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_box", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CASA :::"

    Public Sub InsertCasa(ByVal lCodigoRecibo As Long, _
                           ByVal lCodigoCasa As Long, _
                           ByVal dAreaConstruidaLocada As Double, _
                           ByVal dAreaTerrenoLocada As Double, _
                           ByVal dValorAluguel As Double, _
                           ByVal dInicioVigenciaContrato As DateTime, _
                           ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_terreno_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaTerrenoLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_casa", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCasa()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_casa", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCasa(ByVal lCodigo As Long, _
                                ByVal txtAreaConstruidaLocada As NumericEditBox, _
                                ByVal txtAreaPatioLocada As NumericEditBox, _
                                ByVal txtValorAluguel As NumericEditBox, _
                                ByVal dtpDataInicioVigenciaContrato As CalendarCombo, _
                                ByVal dtpDataTerminoVigenciaContrato As CalendarCombo)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_casa_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAreaConstruidaLocada.Value = oSqlDataReader.Item("area_construida_locada")
                txtAreaPatioLocada.Value = oSqlDataReader.Item("area_terreno_locada")
                txtValorAluguel.Value = oSqlDataReader.Item("valor_aluguel")
                dtpDataInicioVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_inicio_vigencia_contrato"))
                dtpDataTerminoVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_termino_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_termino_vigencia_contrato"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCasa(ByVal iCodigo As Integer, _
                           ByVal lCodigoRecibo As Long, _
                           ByVal lCodigoCasa As Long, _
                           ByVal dAreaConstruidaLocada As Double, _
                           ByVal dAreaTerrenoLocada As Double, _
                           ByVal dValorAluguel As Double, _
                           ByVal dInicioVigenciaContrato As DateTime, _
                           ByVal dTerminoVigenciaContrato As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1


            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_terreno_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaTerrenoLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

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
            oSqlParameter(i).Value = iCodigo



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_casa", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCasa(ByVal oGrid As GridEX, _
                              ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_casa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


#Region "::: DADOS AREA :::"

    Public Sub InsertReciboDadosArea(ByVal lCodigoRecibo As Long, _
                                     ByVal lCodigoGalpao As Long, _
                                     ByVal sNumeroRecibo As String, _
                                     ByVal dAreaConstruidaLocada As Double, _
                                     ByVal dAreaPatioLocada As Double, _
                                     ByVal dValorAluguel As Double, _
                                     ByVal sReferenciaInterna As String, _
                                     ByVal dInicioVigenciaContrato As DateTime, _
                                     ByVal dTerminoVigenciaContrato As DateTime, _
                                     ByVal sPeriodoReferencia As String, _
                                     ByVal dDataVencimento As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Número Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_patio_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaPatioLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

            'Seta Parametros - Referencia Interna
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_interna"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sReferenciaInterna : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataVencimento : i += 1

            'Seta Parametros - Periodo de Referencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "periodo_referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sPeriodoReferencia : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_dados_area", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboDadosArea(ByVal iCodigo As Integer, _
                                     ByVal lCodigoRecibo As Long, _
                                     ByVal lCodigoGalpao As Long, _
                                     ByVal sNumeroRecibo As String, _
                                     ByVal dAreaConstruidaLocada As Double, _
                                     ByVal dAreaPatioLocada As Double, _
                                     ByVal dValorAluguel As Double, _
                                     ByVal sReferenciaInterna As String, _
                                     ByVal dInicioVigenciaContrato As DateTime, _
                                     ByVal dTerminoVigenciaContrato As DateTime, _
                                     ByVal sPeriodoReferencia As String, _
                                     ByVal dDataVencimento As DateTime)



        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Número Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Data Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Data Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Area Construida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_patio_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaPatioLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

            'Seta Parametros - Referencia Interna
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_interna"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sReferenciaInterna : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataVencimento : i += 1

            'Seta Parametros - Periodo de Referencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "periodo_referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sPeriodoReferencia : i += 1

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
            oSqlParameter(i).Value = iCodigo



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_dados_area", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteReciboDadosArea()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_dados_area", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDadosArea(ByVal oGrid As GridEX, _
                                 ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_dados_area", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosArea(ByVal lCodigo As Long, _
                             ByVal txtAreaConstruidaLocada As NumericEditBox, _
                             ByVal txtAreaPatioLocada As NumericEditBox, _
                             ByVal txtValorAluguel As NumericEditBox, _
                             ByVal txtReferenciaInterna As MaskedEditBox, _
                             ByVal dtpDataInicioVigenciaContrato As CalendarCombo, _
                             ByVal dtpDataTerminoVigenciaContrato As CalendarCombo, _
                             ByVal txtPeriodoReferencia As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_galpao_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtAreaConstruidaLocada.Value = oSqlDataReader.Item("area_construida_locada")
                txtAreaPatioLocada.Value = oSqlDataReader.Item("area_patio_locada")
                txtValorAluguel.Value = oSqlDataReader.Item("valor_aluguel")
                txtReferenciaInterna.Text = IIf(IsDBNull(oSqlDataReader.Item("referencia_interna")), "", oSqlDataReader.Item("referencia_interna"))
                dtpDataInicioVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_inicio_vigencia_contrato"))
                dtpDataTerminoVigenciaContrato.Value = IIf(IsDBNull(oSqlDataReader.Item("data_termino_vigencia_contrato")), Now.Date, oSqlDataReader.Item("data_termino_vigencia_contrato"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: DADOS ENERGIA :::"

#Region "::: GALPÃO :::"
    Public Sub InsertReciboDadosEnergiaGalpao(ByVal iCodigoRecibo As Integer, _
                                         ByVal lCodigoGalpao As Long, _
                                         ByVal dDataLeituraAtual As DateTime, _
                                         ByVal dMarcacaoAtual As Double, _
                                         ByVal dDataLeituraPrecedente As DateTime, _
                                         ByVal dMarcacaoPrecedente As Double, _
                                         ByVal dConsumoEnergia As Double, _
                                         ByVal dPrecoMedioEnergia As Double, _
                                         ByVal dTotalDevidoEnergia As Double, _
                                         ByVal sReferenciaConta As String)



        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEnergia : i += 1

            'Seta Parametros - Preço Médio 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_medio_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoMedioEnergia : i += 1

            'Seta Parametros - Total Devido Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEnergia : i += 1

            'Seta Parametros - Referencia Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_conta_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sReferenciaConta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_dados_energia", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboDadosEnergiaGalpao(ByVal lCodigo As Long, _
                                        ByVal iCodigoRecibo As Integer, _
                                         ByVal lCodigoGalpao As Long, _
                                         ByVal dDataLeituraAtual As DateTime, _
                                         ByVal dMarcacaoAtual As Double, _
                                         ByVal dDataLeituraPrecedente As DateTime, _
                                         ByVal dMarcacaoPrecedente As Double, _
                                         ByVal dConsumoEnergia As Double, _
                                         ByVal dPrecoMedioEnergia As Double, _
                                         ByVal dTotalDevidoEnergia As Double, _
                                         ByVal sReferenciaConta As String)



        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEnergia : i += 1

            'Seta Parametros - Preço Médio 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_medio_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoMedioEnergia : i += 1

            'Seta Parametros - Total Devido Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEnergia : i += 1

            'Seta Parametros - Referencia Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_conta_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sReferenciaConta : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_dados_energia", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDadosEnergiaGalpao(ByVal oGrid As GridEX, _
                                    ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_dados_energia", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region
    
#Region "::: CASA :::"
    Public Sub InsertReciboDadosEnergiaCasa(ByVal iCodigoRecibo As Integer, _
                                       ByVal lCodigoCasa As Long, _
                                       ByVal dDataLeituraAtual As DateTime, _
                                       ByVal dMarcacaoAtual As Double, _
                                       ByVal dDataLeituraPrecedente As DateTime, _
                                       ByVal dMarcacaoPrecedente As Double, _
                                       ByVal dConsumoEnergia As Double, _
                                       ByVal dPrecoMedioEnergia As Double, _
                                       ByVal dTotalDevidoEnergia As Double, _
                                       ByVal sReferenciaConta As String)



        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEnergia : i += 1

            'Seta Parametros - Preço Médio 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_medio_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoMedioEnergia : i += 1

            'Seta Parametros - Total Devido Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEnergia : i += 1

            'Seta Parametros - Referencia Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_conta_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sReferenciaConta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_dados_energia_casa", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboDadosEnergiaCasa(ByVal lCodigo As Long, _
                                       ByVal iCodigoRecibo As Integer, _
                                        ByVal lCodigoCasa As Long, _
                                        ByVal dDataLeituraAtual As DateTime, _
                                        ByVal dMarcacaoAtual As Double, _
                                        ByVal dDataLeituraPrecedente As DateTime, _
                                        ByVal dMarcacaoPrecedente As Double, _
                                        ByVal dConsumoEnergia As Double, _
                                        ByVal dPrecoMedioEnergia As Double, _
                                        ByVal dTotalDevidoEnergia As Double, _
                                        ByVal sReferenciaConta As String)



        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEnergia : i += 1

            'Seta Parametros - Preço Médio 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_medio_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoMedioEnergia : i += 1

            'Seta Parametros - Total Devido Energia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEnergia : i += 1

            'Seta Parametros - Referencia Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_conta_energia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sReferenciaConta : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_dados_energia_casa", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDadosEnergiaCasa(ByVal oGrid As GridEX, _
                                     ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_dados_energia_casa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Public Sub DeleteReciboDadosEnergia()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_dados_energia", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DADOS AGUA :::"
#Region "::: GALPÃO :::"
    Public Sub InsertReciboDadosAguaGalpao(ByVal iCodigoRecibo As Integer, _
                                    ByVal lCodigoGalpao As Long, _
                                    ByVal dDataLeituraAtual As DateTime, _
                                    ByVal dMarcacaoAtual As Double, _
                                    ByVal dDataLeituraPrecedente As DateTime, _
                                    ByVal dMarcacaoPrecedente As Double, _
                                    ByVal dConsumoAgua As Double, _
                                    ByVal dTotalDevidoAgua As Double, _
                                    ByVal dValorAte10 As Double, _
                                    ByVal dValorAte20 As Double, _
                                    ByVal dValorAte50 As Double, _
                                    ByVal dValorAcima50 As Double, _
                                    ByVal dRateioAgua As Double, _
                                    ByVal dTaxaAnaliseAgua As Double)



        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoAgua : i += 1

            'Seta Parametros - Total Devido Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoAgua : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Rateio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioAgua : i += 1

            'Seta Parametros - Taxa Análise Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_analise_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaAnaliseAgua : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_dados_agua", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboDadosAguaGalpao(ByVal lCodigo As Long, _
                                    ByVal iCodigoRecibo As Integer, _
                                    ByVal lCodigoGalpao As Long, _
                                    ByVal dDataLeituraAtual As DateTime, _
                                    ByVal dMarcacaoAtual As Double, _
                                    ByVal dDataLeituraPrecedente As DateTime, _
                                    ByVal dMarcacaoPrecedente As Double, _
                                    ByVal dConsumoAgua As Double, _
                                    ByVal dTotalDevidoAgua As Double, _
                                    ByVal dValorAte10 As Double, _
                                    ByVal dValorAte20 As Double, _
                                    ByVal dValorAte50 As Double, _
                                    ByVal dValorAcima50 As Double, _
                                    ByVal dRateioAgua As Double, _
                                    ByVal dTaxaAnaliseAgua As Double)



        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoAgua : i += 1

            'Seta Parametros - Total Devido Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoAgua : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Rateio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioAgua : i += 1

            'Seta Parametros - Taxa Análise Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_analise_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaAnaliseAgua : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_dados_agua", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDadosAguaGalpao(ByVal oGrid As GridEX, _
                                 ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_dados_agua", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CASA :::"
    Public Sub InsertReciboDadosAguaCasa(ByVal iCodigoRecibo As Integer, _
                                   ByVal lCodigoCasa As Long, _
                                   ByVal dDataLeituraAtual As DateTime, _
                                   ByVal dMarcacaoAtual As Double, _
                                   ByVal dDataLeituraPrecedente As DateTime, _
                                   ByVal dMarcacaoPrecedente As Double, _
                                   ByVal dConsumoAgua As Double, _
                                   ByVal dTotalDevidoAgua As Double, _
                                   ByVal dValorAte10 As Double, _
                                   ByVal dValorAte20 As Double, _
                                   ByVal dValorAte50 As Double, _
                                   ByVal dValorAcima50 As Double, _
                                   ByVal dRateioAgua As Double, _
                                   ByVal dTaxaAnaliseAgua As Double)



        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoAgua : i += 1

            'Seta Parametros - Total Devido Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoAgua : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Rateio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioAgua : i += 1

            'Seta Parametros - Taxa Análise Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_analise_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaAnaliseAgua : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_dados_agua_casa", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboDadosAguaCasa(ByVal lCodigo As Long, _
                                    ByVal iCodigoRecibo As Integer, _
                                    ByVal lCodigoCasa As Long, _
                                    ByVal dDataLeituraAtual As DateTime, _
                                    ByVal dMarcacaoAtual As Double, _
                                    ByVal dDataLeituraPrecedente As DateTime, _
                                    ByVal dMarcacaoPrecedente As Double, _
                                    ByVal dConsumoAgua As Double, _
                                    ByVal dTotalDevidoAgua As Double, _
                                    ByVal dValorAte10 As Double, _
                                    ByVal dValorAte20 As Double, _
                                    ByVal dValorAte50 As Double, _
                                    ByVal dValorAcima50 As Double, _
                                    ByVal dRateioAgua As Double, _
                                    ByVal dTaxaAnaliseAgua As Double)



        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1

            'Seta Parametros - Data Leitura Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraAtual : i += 1

            'Seta Parametros - Marcação Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoAtual : i += 1

            'Seta Parametros - Data Leitura Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_leitura_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataLeituraPrecedente : i += 1

            'Seta Parametros - Marcação Precedente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marcacao_precedente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarcacaoPrecedente : i += 1

            'Seta Parametros - Consumo Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoAgua : i += 1

            'Seta Parametros - Total Devido Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoAgua : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Rateio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioAgua : i += 1

            'Seta Parametros - Taxa Análise Agua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_analise_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaAnaliseAgua : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_dados_agua_casa", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDadosAguaCasa(ByVal oGrid As GridEX, _
                                ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_dados_agua_casa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

    Public Sub DeleteReciboDadosAgua()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_dados_agua", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DADOS ESGOTO :::"

#Region "::: GALPÃO :::"
    Public Sub InsertReciboDadosEsgotoGalpao(ByVal iCodigoRecibo As Integer, _
                                      ByVal lCodigoGalpao As Long, _
                                      ByVal dConsumoEsgoto As Double, _
                                      ByVal dTotalDevidoEsgoto As Double, _
                                      ByVal dValorAte10 As Double, _
                                      ByVal dValorAte20 As Double, _
                                      ByVal dValorAte50 As Double, _
                                      ByVal dValorAcima50 As Double)



        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Consumo Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEsgoto : i += 1

            'Seta Parametros - Total Devido Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEsgoto : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_dados_esgoto", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboDadosEsgotoGalpao(ByVal lCodigo As Long, _
                                       ByVal iCodigoRecibo As Integer, _
                                        ByVal lCodigoGalpao As Long, _
                                        ByVal dConsumoEsgoto As Double, _
                                        ByVal dTotalDevidoEsgoto As Double, _
                                        ByVal dValorAte10 As Double, _
                                        ByVal dValorAte20 As Double, _
                                        ByVal dValorAte50 As Double, _
                                        ByVal dValorAcima50 As Double)



        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoGalpao : i += 1

            'Seta Parametros - Consumo Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEsgoto : i += 1

            'Seta Parametros - Total Devido Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEsgoto : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = lCodigo : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_dados_esgoto", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDadosEsgotoGalpao(ByVal oGrid As GridEX, _
                                 ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_dados_esgoto", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: CASA :::"
    Public Sub InsertReciboDadosEsgotoCasa(ByVal iCodigoRecibo As Integer, _
                                    ByVal lCodigoCasa As Long, _
                                    ByVal dConsumoEsgoto As Double, _
                                    ByVal dTotalDevidoEsgoto As Double, _
                                    ByVal dValorAte10 As Double, _
                                    ByVal dValorAte20 As Double, _
                                    ByVal dValorAte50 As Double, _
                                    ByVal dValorAcima50 As Double)



        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1

            'Seta Parametros - Consumo Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEsgoto : i += 1

            'Seta Parametros - Total Devido Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEsgoto : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_dados_esgoto_casa", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboDadosEsgotoCasa(ByVal lCodigo As Long, _
                                      ByVal iCodigoRecibo As Integer, _
                                       ByVal lCodigoCasa As Long, _
                                       ByVal dConsumoEsgoto As Double, _
                                       ByVal dTotalDevidoEsgoto As Double, _
                                       ByVal dValorAte10 As Double, _
                                       ByVal dValorAte20 As Double, _
                                       ByVal dValorAte50 As Double, _
                                       ByVal dValorAcima50 As Double)



        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCasa : i += 1

            'Seta Parametros - Consumo Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "consumo_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dConsumoEsgoto : i += 1

            'Seta Parametros - Total Devido Esgoto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_devido_esgoto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDevidoEsgoto : i += 1

            'Seta Parametros - Valor Até 10
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_10"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte10 : i += 1

            'Seta Parametros - Valor Até 20
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_20"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte20 : i += 1

            'Seta Parametros - Valor Até 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ate_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAte50 : i += 1

            'Seta Parametros - Valor Acima de 50
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acima_50"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAcima50 : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = lCodigo : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_dados_esgoto_casa", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDadosEsgotoCasa(ByVal oGrid As GridEX, _
                                ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_dados_esgoto_casa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

    Public Sub DeleteReciboDadosEsgoto()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_dados_esgoto", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DESCONTOS :::"

    Public Sub InsertDescontos(ByVal lCodigoRecibo As Long, _
                               ByVal lCodigoDescontos As Long, _
                               ByVal sDescricao As String, _
                               ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try


            i = 0

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = lCodigoDescontos : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_descontos", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDescontos(ByVal lCodigo As Long, _
                               ByVal lCodigoRecibo As Long, _
                               ByVal lCodigoDescontos As Long, _
                               ByVal sDescricao As String, _
                               ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_descontos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = lCodigoDescontos : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_descontos", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteDescontos()

        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_descontos", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosDescontos(ByVal oGrid As GridEX, _
                                  ByVal iCodigoRecibo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_descontos", oSqlParameter)

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

#Region "::: OUTRAS COBRANÇAS :::"

    Public Sub InsertOutrasCobrancas(ByVal lCodigoRecibo As Long, _
                                     ByVal lCodigoOutrasCobrancas As Long, _
                                     ByVal sDescricao As String, _
                                     ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try


            i = 0

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = lCodigoOutrasCobrancas : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_outras_cobrancas", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateOutrasCobrancas(ByVal lCodigo As Long, _
                                     ByVal lCodigoRecibo As Long, _
                                     ByVal lCodigoOutrasCobrancas As Long, _
                                     ByVal sDescricao As String, _
                                     ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_outras_cobrancas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = lCodigoOutrasCobrancas : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_outras_cobrancas", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteOutrasCobrancas()

        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_outras_cobrancas", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosOutrasCobrancas(ByVal oGrid As GridEX, _
                                        ByVal iCodigoRecibo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_outras_cobrancas", oSqlParameter)

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

#Region "::: VENCIMENTO :::"


    Public Sub InsertReciboVencimento(ByVal iCodigoRecibo As Integer, _
                                      ByVal sDescricao As String, _
                                      ByVal dVencimento As DateTime, _
                                      ByVal sFormula As String, _
                                      ByVal dDesconto As Double, _
                                      ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dVencimento : i += 1

            'Seta Parametros - Formula
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formula"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sFormula : i += 1

            'Seta Parametros - Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDesconto : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_recibo_locacao_vencimento", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReciboVencimento(ByVal lCodigo As Long, _
                                      ByVal iCodigoRecibo As Integer, _
                                      ByVal sDescricao As String, _
                                      ByVal dVencimento As DateTime, _
                                      ByVal sFormula As String, _
                                      ByVal dDesconto As Double, _
                                      ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRecibo : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dVencimento : i += 1

            'Seta Parametros - Formula
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formula"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sFormula : i += 1

            'Seta Parametros - Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDesconto : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

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
            oSqlParameter(i).Value = lCodigo



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_recibo_locacao_vencimento", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteReciboVencimento()
        Try
            'Variaveis Locais
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel

                i = 0
                'Seta Parametros - Código Recibo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recibo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_recibo_capa").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_recibo_locacao_vencimento", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridVencimento(ByVal oGrid As GridEX, _
                                 ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cpdigo Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_recibo_locacao_vencimento", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: INTEGRAÇÃO :::"

    Public Sub IntegracaoReciboLocacaoFinanceiro(ByVal lCodigoRecibo As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recibo Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_faturamento_recibo_locacao_financeiro", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridAcordoComercial(ByVal oGrid As GridEX, _
                                  ByVal iCodigoCliente As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = "" : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Código Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = -1 : i += 1

            'Seta Parametros - Data Início - Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Data Início - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Data Validade - Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Data Validade - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            'oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_acordo_comercial"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

#Region "::: FINANCEIRO VINCULAR :::"

    Public Sub UpdateVinculoTituloPrevisao(ByVal lCodigoRecibo As Long, _
                                           ByVal lCodigoTituloPrevisto As Long, _
                                           ByVal sNumeroDocumento As String, _
                                           ByVal iNumeroParcela As Integer, _
                                           ByVal dValorParcelaPrevisto As Double, _
                                           ByVal dDataVencimentoPrevisto As DateTime, _
                                           ByVal dValorParcelaReal As Double, _
                                           ByVal dDataVencimentoReal As DateTime)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo_locacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcelaPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataVencimentoPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela_real"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcelaReal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_real"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataVencimentoReal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_vinculo_previsao_recibo_locacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDesvincularTituloPrevisao(ByVal lCodigoRecibo As Long, _
                                               ByVal lCodigoTitulo As Long, _
                                               ByVal iNumeroParcela As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo_locacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTitulo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_desvincular_previsao_recibo_locacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub DeleteVinculoTituloPrevisao(ByVal lCodigoRecibo As Long, _
                                           ByVal lCodigoTituloPrevisto As Long, _
                                           ByVal iNumeroParcela As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try



            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recibo_locacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecibo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_previsto_revico_locacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesTituloPrevisao(ByVal lCodigo As Long, _
                                           ByVal iParcela As Integer, _
                                           ByVal txtNumeroDocumentoPrevisto As MaskedEditBox, _
                                           ByVal txtNumeroParcela As MaskedEditBox, _
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

            'Seta Parametros - Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iParcela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_previsto_dados_recibo_locacao", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtNumeroDocumentoPrevisto.Text = oSqlDataReader.Item("numero_documento")
                    txtNumeroParcela.Text = oSqlDataReader.Item("numero_parcela")
                    txtValorPrevisto.Value = oSqlDataReader.Item("valor_previsto")
                    dtpDataVencimentoPrevisto.Text = oSqlDataReader.Item("data_vencimento_previsto")


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

    Public Sub LoadDadosTituloVinculado(ByVal lCodigo As Long, _
                                        ByVal cboTituloPrevisto As UIComboBox, _
                                        ByVal txtNumeroDocumentoPrevisto As MaskedEditBox, _
                                        ByVal txtNumeroParcela As MaskedEditBox, _
                                        ByVal txtValorPrevisto As NumericEditBox, _
                                        ByVal dtpDataVencimentoPrevisto As CalendarCombo, _
                                        ByVal txtValorReal As NumericEditBox, _
                                        ByVal dtpDataVencimentoReal As CalendarCombo)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_dados_recibo_locacao", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboTituloPrevisto.SelectedValue = oSqlDataReader.Item("codigo_titulo")
                    txtNumeroDocumentoPrevisto.Text = oSqlDataReader.Item("numero_documento")
                    txtNumeroParcela.Text = oSqlDataReader.Item("numero_parcela")
                    txtValorPrevisto.Value = oSqlDataReader.Item("valor_previsto")
                    dtpDataVencimentoPrevisto.Text = oSqlDataReader.Item("data_vencimento_previsto")
                    txtValorReal.Value = oSqlDataReader.Item("valor_real")
                    dtpDataVencimentoReal.Text = oSqlDataReader.Item("data_vencimento_real")


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



#End Region

End Class
