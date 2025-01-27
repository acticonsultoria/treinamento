Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Microsoft.Office.Interop

Public Class clsUsrCtrComodato

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroContrato As String
    Private iCodigoCliente As Integer
    Private iCodigoMoeda As Integer
    Private dFatorCambial As Double
    Private sDataInicio As String
    Private sDataValidade As String
    Private iCodigoCondicaoPagamento As Integer
    Private iCodigoFormaPagamento As Integer
    Private iCodigoModalidadeFrete As Integer
    Private sAdministradorContrato As String
    Private sEmailAdministradorContrato As String
    Private iCodigoEnderecoEntrega As Integer
    Private iNumeroDiasRecisao As Integer
    Private sTermoGarantia As String
    Private sCondicaoFornecimento As String
    Private sDescritivo As String
    Private sObservacao As String
    Private lCodigoContrato As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroContrato() As String
        Get
            Return sNumeroContrato
        End Get
        Set(ByVal value As String)
            sNumeroContrato = value
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

    Public Property Descritivo() As String
        Get
            Return sDescritivo
        End Get
        Set(ByVal value As String)
            sDescritivo = value
        End Set
    End Property

    Public Property AdministradorContrato() As String
        Get
            Return sAdministradorContrato
        End Get
        Set(ByVal value As String)
            sAdministradorContrato = value
        End Set
    End Property

    Public Property EmailAdministradorContrato() As String
        Get
            Return sEmailAdministradorContrato
        End Get
        Set(ByVal value As String)
            sEmailAdministradorContrato = value
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

    Public Property NumeroDiasRecisao() As Integer
        Get
            Return iNumeroDiasRecisao
        End Get
        Set(ByVal value As Integer)
            iNumeroDiasRecisao = value
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

    Public Property TermoGarantia() As String
        Get
            Return sTermoGarantia
        End Get
        Set(ByVal value As String)
            sTermoGarantia = value
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

    Public Property CodigoContrato() As Long
        Get
            Return lCodigoContrato
        End Get
        Set(ByVal value As Long)
            lCodigoContrato = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CONTRATO :::"

    Public Sub LoadGridContrato(ByVal oGrid As GridEX, _
                                ByVal sNumeroContrato As String, _
                                ByVal iRevisao As Integer, _
                                ByVal iCodigoCliente As Integer, _
                                ByVal sDescritivo As String, _
                                ByVal iCodigoCondicaoPagamento As Integer, _
                                ByVal iCodigoFormaPagamento As Integer, _
                                ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroContrato : i += 1

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

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Código Condição Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCondicaoPagamento : i += 1

            'Seta Parametros - Código Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaPagamento : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Codigo Usuário
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_contrato_comodato", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo"))

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

    Public Sub EditarContrato(ByVal lCodigo As Long, _
                              ByVal txtNumeroContrato As MaskedEditBox, _
                              ByVal txtRevisao As MaskedEditBox, _
                              ByVal cboCliente As UIComboBox, _
                              ByVal txtDescritivo As MaskedEditBox, _
                              ByVal dtpDataInicio As CalendarCombo, _
                              ByVal dtpDataValidade As CalendarCombo, _
                              ByVal cboCondicaoPagamento As UIComboBox, _
                              ByVal cboFormaPagamento As UIComboBox, _
                              ByVal cboModalidadeFrete As UIComboBox, _
                              ByVal cboMoeda As UIComboBox, _
                              ByVal txtFatorCambial As NumericEditBox, _
                              ByVal txtNumeroDiasRecisao As NumericEditBox, _
                              ByVal txtAdministradorContrato As MaskedEditBox, _
                              ByVal txtEmailAdministradorContrato As MaskedEditBox, _
                              ByVal cboEnderecoEntrega As UIComboBox, _
                              ByVal txtTermoGarantia As EditBox, _
                              ByVal txtCondicaoFornecimento As EditBox, _
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
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_contrato_comodato_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtNumeroContrato.Text = oSqlDataReader.Item("numero_contrato")
                txtRevisao.Text = oSqlDataReader.Item("revisao")
                cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")
                txtDescritivo.Text = oSqlDataReader.Item("descritivo")
                dtpDataInicio.Value = oSqlDataReader.Item("data_inicio")
                If IsDBNull(oSqlDataReader.Item("data_validade")) Then
                    dtpDataValidade.Value = Now.Date : dtpDataValidade.Checked = False
                Else
                    dtpDataValidade.Value = oSqlDataReader.Item("data_validade") : dtpDataValidade.Checked = True
                End If
                cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                txtFatorCambial.Value = oSqlDataReader.Item("fator_cambial")
                txtNumeroDiasRecisao.Value = oSqlDataReader.Item("numero_dias_recisao")
                txtAdministradorContrato.Text = oSqlDataReader.Item("administrador_contrato")
                txtEmailAdministradorContrato.Text = oSqlDataReader.Item("email_administrador_contrato")
                cboEnderecoEntrega.SelectedValue = oSqlDataReader.Item("codigo_endereco_entrega")
                txtTermoGarantia.Text = oSqlDataReader.Item("termo_garantia")
                txtCondicaoFornecimento.Text = oSqlDataReader.Item("condicao_fornecimento")
                txtObservacao.Text = oSqlDataReader.Item("observacao")

            End While

            'Feca o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertContrato()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_contrato_comodato", oSqlParameter)

            'Seta Váriaveis
            lCodigoContrato = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertContratoRevisao(ByVal lCodigoContrato As Long, _
                                     ByRef lCodigoContratoRevisao As Long)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_contrato_comodato_revisao", oSqlParameter)

            'Seta Váriaveis
            lCodigoContratoRevisao = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContrato()

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroContrato : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sDescritivo : i += 1

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

            'Seta Parametros - Administrador Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "administrador_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sAdministradorContrato = "", DBNull.Value, sAdministradorContrato) : i += 1

            'Seta Parametros - Email Administrador Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email_administrador_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sEmailAdministradorContrato = "", DBNull.Value, sEmailAdministradorContrato) : i += 1

            'Seta Parametros - Código Cliente - Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_endereco_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoEnderecoEntrega = -1, DBNull.Value, iCodigoEnderecoEntrega) : i += 1

            'Seta Parametros - Nº Dias Recisao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias_recisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroDiasRecisao : i += 1

            'Seta Parametros - Termo de Garantia
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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_contrato_comodato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContrato()

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_contrato_comodato", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaContrato(ByVal sNumeroContrato As String, _
                                   ByVal iCodigoCliente As Integer, _
                                   ByVal lCodigo As Long) As Boolean

        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Número Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroContrato

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_contrato_comodato", oSqlParameter)

            'Seta Retorno da Função
            Return IIf(iReturn = 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosContrato(ByVal lCodigo As Long, _
                                 ByRef sNumeroContrato As String, _
                                 ByRef sAnoContrato As String, _
                                 ByRef sRazaoSocialEmpresa As String, _
                                 ByRef sCNPJEmpresa As String, _
                                 ByRef sCidadeEmpresa As String, _
                                 ByRef sEstadoEmpresa As String, _
                                 ByRef sLogradouroEmpresa As String, _
                                 ByRef sNumeroEmpresa As String, _
                                 ByRef sComplementoEmpresa As String, _
                                 ByRef sBairroEmpresa As String, _
                                 ByRef sCEPEmpresa As String, _
                                 ByRef sRepresentanteEmpresa As String, _
                                 ByRef sRGRepresentante As String, _
                                 ByRef sRazaoSocialCliente As String, _
                                 ByRef sPersonalidadeCliente As String, _
                                 ByRef sCidadeCliente As String, _
                                 ByRef sEstadoCliente As String, _
                                 ByRef sRuaCliente As String, _
                                 ByRef sNumeroCliente As String, _
                                 ByRef sComplementoCliente As String, _
                                 ByRef sBairroCliente As String, _
                                 ByRef sCEPCliente As String, _
                                 ByRef sCNPJCliente As String, _
                                 ByRef sRepresentanteCliente As String, _
                                 ByRef iQuantidadeMesesVigenciaContrato As Integer, _
                                 ByRef dValorMensalComodato As Double, _
                                 ByRef sEmailCliente As String, _
                                 ByRef iNumeroDiasRescisao As Integer, _
                                 ByRef iDia As Integer, _
                                 ByRef iMes As Integer, _
                                 ByRef iAno As Integer)

        'Váriaveis Locais
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

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_contrato_comodato_dados_relatorio", oSqlParameter)

            While oSqlDataReader.Read

                'Seta Váriaveis
                sNumeroContrato = oSqlDataReader("numero_contrato")
                sAnoContrato = oSqlDataReader("ano_contrato")
                sRazaoSocialEmpresa = oSqlDataReader("razao_social_empresa")
                sCNPJEmpresa = oSqlDataReader("cnpj_empresa")
                sCidadeEmpresa = Strings.StrConv(oSqlDataReader("cidade_empresa"), VbStrConv.ProperCase)
                sEstadoEmpresa = oSqlDataReader("uf_empresa")
                sLogradouroEmpresa = Strings.StrConv(oSqlDataReader("logradouro_empresa"), VbStrConv.ProperCase)
                sNumeroEmpresa = oSqlDataReader("numero_empresa")
                sComplementoEmpresa = oSqlDataReader("complemento_empresa")
                sBairroEmpresa = Strings.StrConv(oSqlDataReader("bairro_empresa"), VbStrConv.ProperCase)
                sCEPEmpresa = oSqlDataReader("cep_empresa")
                sRepresentanteEmpresa = Strings.StrConv(oSqlDataReader("representante_empresa"), VbStrConv.ProperCase)
                sRGRepresentante = oSqlDataReader("rg_representante_empresa")
                sRazaoSocialCliente = oSqlDataReader("razao_social_cliente")
                sPersonalidadeCliente = oSqlDataReader("personalidade_cliente")
                sCidadeCliente = Strings.StrConv(oSqlDataReader("cidade_cliente"), VbStrConv.ProperCase)
                sRuaCliente = Strings.StrConv(oSqlDataReader("rua_cliente"), VbStrConv.ProperCase)
                sNumeroCliente = oSqlDataReader("numero_cliente")
                sComplementoCliente = Strings.StrConv(oSqlDataReader("complemento_cliente"), VbStrConv.ProperCase)
                sBairroCliente = Strings.StrConv(oSqlDataReader("bairro_cliente"), VbStrConv.ProperCase)
                sEstadoCliente = oSqlDataReader("uf_cliente")
                sCEPCliente = oSqlDataReader("cep_cliente")
                sCNPJCliente = oSqlDataReader("cnpj_cliente")
                sRepresentanteCliente = Strings.StrConv(oSqlDataReader("representante_cliente"), VbStrConv.ProperCase)
                iQuantidadeMesesVigenciaContrato = oSqlDataReader.Item("quantidade_meses_vigencia_contrato")
                dValorMensalComodato = oSqlDataReader.Item("valor_mensal_comodato")
                sEmailCliente = oSqlDataReader.Item("email_cliente")
                iNumeroDiasRescisao = oSqlDataReader.Item("numero_dias_recisao")
                iDia = oSqlDataReader.Item("dia")
                iMes = oSqlDataReader.Item("mes")
                iAno = oSqlDataReader.Item("ano")

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

    Public Sub DeleteProduto(ByVal lCodigoContrato As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Contrato
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoContrato : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_contrato_comodato_produto", oSqlParameter)

                'Exclui Registro
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertProduto(ByVal lCodigoContrato As Long, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal dMultiploVenda As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dPrecoTabela As Double, _
                             ByVal dDescontoPercentual As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal dValorUnitarioDesconto As Double, _
                             ByVal bICMSEmbutido As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bIPIEmbutido As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bPISCOFINSEmbutido As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dPrecoVenda As Double, _
                             ByVal sRegistroAnvisa As String)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Múltiplo de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMultiploVenda : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Preço Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoTabela : i += 1

            'Seta Parametros - Desconto Percentual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - Valor Unitário Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitarioDesconto : i += 1

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
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - PIS / COFINS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Registro Anvisa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "registro_anvisa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sRegistroAnvisa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_contrato_comodato_produto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProduto(ByVal lCodigoContrato As Long, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal dMultiploVenda As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dPrecoTabela As Double, _
                             ByVal dDescontoPercentual As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal dValorUnitarioDesconto As Double, _
                             ByVal bICMSEmbutido As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bIPIEmbutido As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bPISCOFINSEmbutido As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dPrecoVenda As Double, _
                             ByVal sRegistroAnvisa As String, _
                             ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Múltiplo de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMultiploVenda : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Preço Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoTabela : i += 1

            'Seta Parametros - Desconto Percentual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - Valor Unitário Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitarioDesconto : i += 1

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
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - PIS / COFINS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Registro Anvisa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "registro_anvisa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sRegistroAnvisa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_contrato_comodato_produto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal oGrid As GridEX, _
                               ByVal lCodigoContrato As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_contrato_comodato_produto", oSqlParameter)

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

#Region "::: COMODATO :::"

    Public Sub DeleteComodato(ByVal lCodigoContrato As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Contrato
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoContrato : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_contrato_comodato_comodato", oSqlParameter)

                'Exclui Registro
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertComodato(ByVal lCodigoContrato As Long, _
                              ByVal lCodigoItem As Long, _
                              ByVal sRegistroAnvisa As String, _
                              ByVal iCodigoUnidadeMedida As Integer, _
                              ByVal dQuantidade As Double, _
                              ByVal dValorMensal As Double)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

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

            'Seta Parametros - Registro Anvisa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "registro_anvisa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sRegistroAnvisa : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Valor Mensal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorMensal

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_contrato_comodato_comodato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateComodato(ByVal lCodigoContrato As Long, _
                              ByVal lCodigoItem As Long, _
                              ByVal sRegistroAnvisa As String, _
                              ByVal iCodigoUnidadeMedida As Integer, _
                              ByVal dQuantidade As Double, _
                              ByVal dValorMensal As Double, _
                              ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

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

            'Seta Parametros - Registro Anvisa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "registro_anvisa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sRegistroAnvisa : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Valor Mensal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorMensal : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_contrato_comodato_comodato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridComodato(ByVal oGrid As GridEX, _
                                ByVal lCodigoContrato As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_contrato_comodato_comodato", oSqlParameter)

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

#Region "::: WORD :::"

    Public Sub LoadTabelaComodato(ByVal lCodigoContrato As Long, _
                                  ByVal oDocument As Word.Document)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_contrato_comodato_comodato", oSqlParameter)

            'Substitui Documento - Tabela
            Dim iRow As Integer = 2

            'Adiciona Cabeçalho
            Dim oTable As Word.Table = oDocument.Tables.Add(oDocument.Bookmarks.Item("tabela_comodato").Range, 1, 5)
            oTable.Cell(1, 1).Range.Text = "ITEM" : oTable.Cell(1, 1).Range.Font.Bold = True
            oTable.Cell(1, 2).Range.Text = "DESCRIÇÃO" : oTable.Cell(1, 2).Range.Font.Bold = True
            oTable.Cell(1, 3).Range.Text = "REGISTRO ANVISA" : oTable.Cell(1, 3).Range.Font.Bold = True
            oTable.Cell(1, 4).Range.Text = "QUANTIDADE" : oTable.Cell(1, 4).Range.Font.Bold = True
            oTable.Cell(1, 5).Range.Text = "NF" : oTable.Cell(1, 5).Range.Font.Bold = True
            oTable.Range.ParagraphFormat.SpaceAfter = 6

            While oSqlDataReader.Read

                oTable.Rows.Add()

                oTable.Cell(iRow, 1).Range.Text = oSqlDataReader.Item("codigo_produto")
                oTable.Cell(iRow, 2).Range.Text = oSqlDataReader.Item("descricao")
                oTable.Cell(iRow, 3).Range.Text = oSqlDataReader.Item("registro_anvisa")
                oTable.Cell(iRow, 4).Range.Text = oSqlDataReader.Item("quantidade") & " - " & oSqlDataReader.Item("unidade_medida")

                'Seta Váriavel
                iRow += 1

            End While

            oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            oTable.Rows.Item(1).Range.Font.Bold = True
            oTable.Rows.Item(1).Range.Font.Italic = True
            oTable.Range.InsertParagraphBefore()


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadTabelaProduto(ByVal lCodigoContrato As Long, _
                                 ByVal oDocument As Word.Document)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato_comodato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoContrato : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_contrato_comodato_produto", oSqlParameter)

            'Substitui Documento - Tabela
            Dim iRow As Integer = 2

            'Adiciona Cabeçalho
            Dim oTable As Word.Table = oDocument.Tables.Add(oDocument.Bookmarks.Item("tabela_produto").Range, 1, 5)
            oTable.Cell(1, 1).Range.Text = "ITEM" : oTable.Cell(1, 1).Range.Font.Bold = True
            oTable.Cell(1, 2).Range.Text = "DESCRIÇÃO" : oTable.Cell(1, 2).Range.Font.Bold = True
            oTable.Cell(1, 3).Range.Text = "QUANTIDADE" : oTable.Cell(1, 4).Range.Font.Bold = True
            oTable.Cell(1, 4).Range.Text = "REGISTRO ANVISA" : oTable.Cell(1, 3).Range.Font.Bold = True
            oTable.Cell(1, 5).Range.Text = "VALOR UNITÁRIO" : oTable.Cell(1, 5).Range.Font.Bold = True
            oTable.Range.ParagraphFormat.SpaceAfter = 6

            While oSqlDataReader.Read

                oTable.Rows.Add()

                oTable.Cell(iRow, 1).Range.Text = oSqlDataReader.Item("codigo_produto")
                oTable.Cell(iRow, 2).Range.Text = oSqlDataReader.Item("descricao")
                oTable.Cell(iRow, 3).Range.Text = oSqlDataReader.Item("quantidade_minima") & " - " & oSqlDataReader.Item("unidade_medida")
                oTable.Cell(iRow, 4).Range.Text = oSqlDataReader.Item("registro_anvisa")
                oTable.Cell(iRow, 5).Range.Text = oSqlDataReader.Item("preco_venda")

                'Seta Váriavel
                iRow += 1

            End While

            oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            oTable.Rows.Item(1).Range.Font.Bold = True
            oTable.Rows.Item(1).Range.Font.Italic = True
            oTable.Range.InsertParagraphBefore()

            'Fecha o SqlDataReader
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
