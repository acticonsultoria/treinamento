Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCmpAcordoComercial

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroAcordoComercial As String
    Private iCodigoFornecedor As Integer
    Private iCodigoMoeda As Integer
    Private dFatorCambial As Double
    Private sDataInicio As String
    Private sDataValidade As String
    Private sDescritivo As String
    Private sAdministradorAcordoComercial As String
    Private iCodigoCondicaoPagamento As Integer
    Private iCodigoFormaPagamento As Integer
    Private iCodigoModalidadeFrete As Integer
    Private iCodigoTransportadora As Integer
    Private iCodigoModalidadeTransporte As Integer
    Private iCodigoIncoterms As Integer
    Private iCodigoAgenteLogistico As Integer
    Private iCodigoInstrucaoEmbarque As Integer
    Private sObservacao As String
    Private lCodigo As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroAcordoComercial() As String
        Get
            Return sNumeroAcordoComercial
        End Get
        Set(ByVal value As String)
            sNumeroAcordoComercial = value
        End Set
    End Property

    Public Property CodigoFornecedor() As Integer
        Get
            Return iCodigoFornecedor
        End Get
        Set(ByVal value As Integer)
            iCodigoFornecedor = value
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

    Public Property DataInicio() As String
        Get
            Return sDataInicio
        End Get
        Set(ByVal value As String)
            sDataInicio = value
        End Set
    End Property

    Public Property DataValidade() As String
        Get
            Return sDataValidade
        End Get
        Set(ByVal value As String)
            sDataValidade = value
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

    Public Property AdministradorAcordoComercial() As String
        Get
            Return sAdministradorAcordoComercial
        End Get
        Set(ByVal value As String)
            sAdministradorAcordoComercial = value
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

    Public Property CodigoModalidadeFrete() As Integer
        Get
            Return iCodigoModalidadeFrete
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidadeFrete = value
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

    Public Property CodigoModalidadeTransporte() As Integer
        Get
            Return iCodigoModalidadeTransporte
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidadeTransporte = value
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

    Public Property CodigoAgenteLogistico() As Integer
        Get
            Return iCodigoAgenteLogistico
        End Get
        Set(ByVal value As Integer)
            iCodigoAgenteLogistico = value
        End Set
    End Property

    Public Property CodigoInstrucaoEmbarque() As Integer
        Get
            Return iCodigoInstrucaoEmbarque
        End Get
        Set(ByVal value As Integer)
            iCodigoInstrucaoEmbarque = value
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

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CONTRATO :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Empresa
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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_acordo_comercial", oSqlParameter)

            'Seta Váriaveis
            lCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRevisao(ByVal lCodigoAcordoComercial As Long)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Codigo Empresa
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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_acordo_comercial_revisao", oSqlParameter)

            'Seta Váriaveis
            lCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroAcordoComercial : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1

            'Seta Parametros - Código Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoMoeda : i += 1

            'Seta Parametros - Fator Cambial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_cambial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFatorCambial : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataInicio : i += 1

            'Seta Parametros - Data Válidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value) : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Administrador do Acordo Comercial - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "administrador_acordo_comercial_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sAdministradorAcordoComercial = "", DBNull.Value, AdministradorAcordoComercial) : i += 1

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1

            'Seta Parametros - Código Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaPagamento = -1, DBNull.Value, iCodigoFormaPagamento) : i += 1

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

            'Seta Parametros - Código Modalidade Transporte
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_transporte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoModalidadeTransporte = -1, DBNull.Value, iCodigoModalidadeTransporte) : i += 1

            'Seta Parametros - Código Incoterms
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_incoterms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoIncoterms = -1, DBNull.Value, iCodigoIncoterms) : i += 1

            'Seta Parametros - Código Agente Logístico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_agente_logistico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAgenteLogistico = -1, DBNull.Value, iCodigoAgenteLogistico) : i += 1

            'Seta Parametros - Código Instrução de Embarque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao_embarque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoInstrucaoEmbarque = -1, DBNull.Value, iCodigoInstrucaoEmbarque) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Codigo Empresa
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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_acordo_comercial", oSqlParameter)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_acordo_comercial", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Editar(ByVal iCodigoAcordoComercial As Integer, _
                      ByVal txtNumeroAcordoComercial As MaskedEditBox, _
                      ByVal txtRevisao As MaskedEditBox, _
                      ByVal cboFornecedor As UIComboBox, _
                      ByVal cboMoeda As UIComboBox, _
                      ByVal txtFatorCambiasl As NumericEditBox, _
                      ByVal dtpDataInicio As CalendarCombo, _
                      ByVal dtpDataTermino As CalendarCombo, _
                      ByVal txtDescritivo As MaskedEditBox, _
                      ByVal txtAdministradorAcordoComercialFornecedor As MaskedEditBox, _
                      ByVal cboCondicaoPagamento As UIComboBox, _
                      ByVal cboFormaPagamento As UIComboBox, _
                      ByVal cboModalidadeFrete As UIComboBox, _
                      ByVal cboTransportadora As UIComboBox, _
                      ByVal cboModalidadeTransporte As UIComboBox, _
                      ByVal cboIncoterms As UIComboBox, _
                      ByVal cboAgenteLogistico As UIComboBox, _
                      ByVal cboInstrucaoEmbarque As UIComboBox, _
                      ByVal txtObservacao As EditBox)

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
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_acordo_comercial_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtNumeroAcordoComercial.Text = oSqlDataReader.Item("numero_acordo_comercial")
                txtRevisao.Text = oSqlDataReader.Item("revisao")
                cboFornecedor.SelectedValue = oSqlDataReader.Item("codigo_fornecedor")
                cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                txtFatorCambiasl.Value = oSqlDataReader.Item("fator_cambial")
                dtpDataInicio.Value = oSqlDataReader.Item("data_inicio")
                If IsDBNull(oSqlDataReader.Item("data_validade")) = False Then dtpDataTermino.Value = oSqlDataReader.Item("data_validade") : dtpDataTermino.Checked = False
                If IsDBNull(oSqlDataReader.Item("codigo_condicao_pagamento")) = False Then cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                If IsDBNull(oSqlDataReader.Item("codigo_forma_pagamento")) = False Then cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                If IsDBNull(oSqlDataReader.Item("codigo_modalidade_frete")) = False Then cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                If IsDBNull(oSqlDataReader.Item("codigo_transportadora")) = False Then cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                If IsDBNull(oSqlDataReader.Item("codigo_modalidade_transporte")) = False Then cboModalidadeTransporte.SelectedValue = oSqlDataReader.Item("codigo_modalidade_transporte")
                If IsDBNull(oSqlDataReader.Item("codigo_incoterms")) = False Then cboIncoterms.SelectedValue = oSqlDataReader.Item("codigo_incoterms")
                If IsDBNull(oSqlDataReader.Item("codigo_agente_logistico")) = False Then cboAgenteLogistico.SelectedValue = oSqlDataReader.Item("codigo_agente_logistico")
                If IsDBNull(oSqlDataReader.Item("codigo_instrucao_embarque")) = False Then cboInstrucaoEmbarque.SelectedValue = oSqlDataReader.Item("codigo_instrucao_embarque")
                txtObservacao.Text = oSqlDataReader.Item("observacao")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroAcordoComercial As String, _
                        ByVal iRevisao As Integer, _
                        ByVal iCodigoFornecedor As Integer, _
                        ByVal iCodigoMoeda As Integer, _
                        ByVal sDataInicioInicio As String, _
                        ByVal sDataInicioTermino As String, _
                        ByVal sDataValidadeInicio As String, _
                        ByVal sDataValidadeTermino As String, _
                        ByVal sDescritivo As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroAcordoComercial : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iRevisao : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1

            'Seta Parametros - Código Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoMoeda : i += 1

            'Seta Parametros - Data Início - Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicioInicio), sDataInicioInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Início - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicioTermino), sDataInicioTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Validade - Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidadeInicio), sDataValidadeInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Validade - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidadeTermino), sDataValidadeTermino, DBNull.Value) : i += 1

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_acordo_comercial", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona o Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_acordo_comercial"))

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

    Public Function ValidaAcordoComercial(ByVal lCodigoAcordoComercial As Long, _
                                          ByVal sNumeroAcordoComercial As String, _
                                          ByVal iRevisao As Integer, _
                                          ByVal iCodigoFornecedor As Integer) As Boolean

        Dim oSqlParameter(4) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iRevisao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1

            'Seta Parametros - Nº Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroAcordoComercial

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_compras_acordo_comercial", oSqlParameter)

            'Seta Retorno da Função
            Return IIf(iReturn = 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO :::"

    Public Sub DeleteProduto(ByVal lCodigoAcordoComercial As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Acordo Comercial
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_acordo_comercial_item", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertProduto(ByVal lCodigoAcordoComercial As Long, _
                             ByVal lCodigoProduto As Long, _
                             ByVal iLeadTime As Integer, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorUnitario As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal bICMSEmbutido As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bIPIEmbutido As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bPISCOFINSEmbutido As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dPrecoCompra As Double)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iLeadTime : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Desconto Unitário Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_unitario_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - ICMS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

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

            'Seta Parametros - IPI Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIPIEmbutido : i += 1

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

            'Seta Parametros - PIS COFINS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPISCOFINSEmbutido : i += 1

            'Seta Parametros - Alíquota PIS COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPISCOFINS : i += 1

            'Seta Parametros - Valor PIS COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPISCOFINS : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Preço Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoCompra

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProduto(ByVal lCodigoAcordoComercial As Long, _
                             ByVal lCodigoProduto As Long, _
                             ByVal iLeadTime As Integer, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorUnitario As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal bICMSEmbutido As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bIPIEmbutido As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bPISCOFINSEmbutido As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dPrecoCompra As Double, _
                             ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iLeadTime : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Desconto Unitário Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_unitario_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - ICMS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

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

            'Seta Parametros - IPI Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIPIEmbutido : i += 1

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

            'Seta Parametros - PIS COFINS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPISCOFINSEmbutido : i += 1

            'Seta Parametros - Alíquota PIS COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPISCOFINS : i += 1

            'Seta Parametros - Valor PIS COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPISCOFINS : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Preço Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoCompra : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal oGrid As GridEX, _
                               ByVal lCodigoAcordoComercial As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_acordo_comercial_item", oSqlParameter)

            'Configura DataMember - Grid
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
