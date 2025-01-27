Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCmpContrato2

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroContrato As String
    Private iCodigoFornecedor As Integer
    Private iCodigoMoeda As Integer
    Private dFatorCambial As Double
    Private sDataInicio As String
    Private sDataValidade As String
    Private sAdministradorContrato As String
    Private iCodigoCondicaoPagamento As Integer
    Private iCodigoFormaPagamento As Integer
    Private iCodigoModalidadeFrete As Integer
    Private iCodigoContrato As Integer

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

    Public Property AdministradorContrato() As String
        Get
            Return sAdministradorContrato
        End Get
        Set(ByVal value As String)
            sAdministradorContrato = value
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

    Public Property Codigo() As Integer
        Get
            Return iCodigoContrato
        End Get
        Set(ByVal value As Integer)
            iCodigoContrato = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CONTRATO :::"

    Public Sub InsertContrato()

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroContrato : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int : i += 1

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

            'Seta Parametros - Administrador do Contrato - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "administrador_contrato_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sAdministradorContrato = "", DBNull.Value, AdministradorContrato) : i += 1

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
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_contrato", oSqlParameter)

            'Seta Váriaveis
            iCodigoContrato = oSqlParameter(1).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContrato()

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroContrato : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

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

            'Seta Parametros - Administrador do Contrato - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "administrador_contrato_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sAdministradorContrato = "", DBNull.Value, AdministradorContrato) : i += 1

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
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_contrato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContrato()

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_contrato", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadContrato(ByVal iCodigoContrato As Integer, _
                            ByVal txtNumeroContrato As MaskedEditBox, _
                            ByVal cboFornecedor As UIComboBox, _
                            ByVal cboMoeda As UIComboBox, _
                            ByVal txtFatorCambiasl As NumericEditBox, _
                            ByVal dtpDataInicio As CalendarCombo, _
                            ByVal dtpDataTermino As CalendarCombo, _
                            ByVal cboCondicaoPagamento As UIComboBox, _
                            ByVal cboFormaPagamento As UIComboBox, _
                            ByVal cboModalidadeFrete As UIComboBox, _
                            ByVal txtAdministradorContratoFornecedor As MaskedEditBox)

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
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_contrato_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtNumeroContrato.Text = oSqlDataReader.Item("numero_contrato")
                cboFornecedor.SelectedValue = oSqlDataReader.Item("codigo_fornecedor")
                cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                txtFatorCambiasl.Value = oSqlDataReader.Item("fator_cambial")
                dtpDataInicio.Value = oSqlDataReader.Item("data_inicio")
                If IsDBNull(oSqlDataReader.Item("data_validade")) Then
                    dtpDataTermino.Value = Now.Date : dtpDataTermino.Checked = False
                Else
                    dtpDataTermino.Value = oSqlDataReader.Item("data_validade") : dtpDataTermino.Checked = False
                End If
                If IsDBNull(oSqlDataReader.Item("codigo_condicao_pagamento")) Then
                    cboCondicaoPagamento.SelectedIndex = -1
                Else
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                End If
                If IsDBNull(oSqlDataReader.Item("codigo_forma_pagamento")) Then
                    cboFormaPagamento.SelectedIndex = -1
                Else
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                End If
                If IsDBNull(oSqlDataReader.Item("codigo_modalidade_frete")) Then
                    cboModalidadeFrete.SelectedIndex = -1
                Else
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                End If
                txtAdministradorContratoFornecedor.Text = oSqlDataReader.Item("administrador_contrato_fornecedor")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaContrato(ByVal iCodigoContrato As Integer, _
                                   ByVal sNumeroContrato As String, _
                                   ByVal iCodigoFornecedor As Integer) As Boolean

        Dim oSqlParameter(4) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

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

            'Seta Parametros - Nº Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroContrato

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_compras_contrato", oSqlParameter)

            'Seta Retorno da Função
            Return IIf(iReturn = 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGridContrato(ByVal oGrid As GridEX, _
                                ByVal sNumeroContrato As String, _
                                ByVal iCodigoFornecedor As Integer, _
                                ByVal iCodigoMoeda As Integer, _
                                ByVal sDataInicioInicio As String, _
                                ByVal sDataInicioTermino As String, _
                                ByVal sDataValidadeInicio As String, _
                                ByVal sDataValidadeTermino As String, _
                                ByVal iCodigoCondicaoPagamento As Integer, _
                                ByVal iCodigoFormaPagamento As Integer, _
                                ByVal iCodigoModalidadeFrete As Integer, _
                                ByVal sAdministradorContratoFornecedor As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(11) As SqlParameter
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

            'Seta Parametros - Administrador do Contrato - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "administrador_contrato_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sAdministradorContratoFornecedor : i += 1

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCondicaoPagamento : i += 1

            'Seta Parametros - Código Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaPagamento : i += 1

            'Seta Parametros - Código Modalidade de Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModalidadeFrete : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_contrato", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona o Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_contrato"))

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

#Region "::: ITENS :::"

    Public Sub DeleteContratoItem(ByVal iCodigoContrato As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_contrato_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertContratoItem(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Contrato
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_contrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoContrato : i += 1

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Produto Serviço
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto_servico"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("codigo_item").Value : i += 1

                'Seta Parametros - Descrição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 120
                oSqlParameter(i).Value = oRow.Cells("descricao").Value : i += 1

                'Seta Parametros - Quantidade Máxima
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "quantidade_maxima"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("quantidade_maxima").Value : i += 1

                'Seta Parametros - Preço de Compra
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "preco_compra"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("preco_compra").Value : i += 1

                'Seta Parametros - ICMS Embutido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "icms_embutido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("icms_embutido").Value : i += 1

                'Seta Parametros - Alíquota ICMS
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "aliquota_icms"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("aliquota_icms").Value : i += 1

                'Seta Parametros - IPI Embutido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "ipi_embutido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("ipi_embutido").Value : i += 1

                'Seta Parametros - Alíquota IPI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "aliquota_ipi"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("aliquota_ipi").Value : i += 1

                'Seta Parametros - Lead Time
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "lead_time"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("lead_time").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_contrato_item", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridContratoItem(ByVal oGrid As GridEX, _
                                    ByVal iCodigoContrato As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContrato : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_contrato_item", oSqlParameter)

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

#Region "::: IMPORTAÇÃO :::"

#Region "::: ARQUIVO :::"

    Public Sub UpdateConfiguracaoArquivoExcel(ByVal sColunaCodigoTipoItem As String, _
                                              ByVal sColunaCodigoItem As String, _
                                              ByVal sColunaQuantidadeMaxima As String, _
                                              ByVal sColunaPrecoCompra As String, _
                                              ByVal sColunaICMSEmbutido As String, _
                                              ByVal sColunaAliquotaICMS As String, _
                                              ByVal sColunaIPIEmbutido As String, _
                                              ByVal sColunaAliquotaIPI As String, _
                                              ByVal sColunaLeadTime As String, _
                                              ByVal iLinhaInicio As Integer)

        Dim oSqlParameter(11) As SqlParameter
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

            'Seta Parametros - Coluna Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaCodigoTipoItem : i += 1

            'Seta Parametros - Coluna Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaCodigoItem : i += 1

            'Seta Parametros - Coluna Quantidade Máxima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_quantidade_maxima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaQuantidadeMaxima : i += 1

            'Seta Parametros - Coluna Preço de Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_preco_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaPrecoCompra : i += 1

            'Seta Parametros - Coluna ICMS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_icms_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaICMSEmbutido : i += 1

            'Seta Parametros - Coluna Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaAliquotaICMS : i += 1

            'Seta Parametros - Coluna IPI Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_ipi_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaIPIEmbutido : i += 1

            'Seta Parametros - Coluna Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaAliquotaIPI : i += 1

            'Seta Parametros - Coluna Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaLeadTime : i += 1

            'Seta Parametros - Linha Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "linha_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iLinhaInicio

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importacao_compras_contrato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadConfiguracaoArquivoExcel(ByVal cboConfiguracaoColunaTipoItem As UIComboBox, _
                                            ByVal cboConfiguracaoColunaCodigoItem As UIComboBox, _
                                            ByVal cboConfiguracaoColunaQuantidadeMaxima As UIComboBox, _
                                            ByVal cboConfiguracaoColunaPrecoCompra As UIComboBox, _
                                            ByVal cboConfiguracaoColunaICMSEmbutido As UIComboBox, _
                                            ByVal cboConfiguracaoColunaAliquotaICMS As UIComboBox, _
                                            ByVal cboConfiguracaoColunaIPIEmbutido As UIComboBox, _
                                            ByVal cboConfiguracaoColunaAliquotaIPI As UIComboBox, _
                                            ByVal cboConfiguracaoColunaLeadTime As UIComboBox, _
                                            ByVal txtLinhaInicio As NumericEditBox)

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

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importacao_compras_contrato", oSqlParameter)

            While oSqlDataReader.Read

                cboConfiguracaoColunaTipoItem.SelectedValue = oSqlDataReader.Item("coluna_tipo_item")
                cboConfiguracaoColunaCodigoItem.SelectedValue = oSqlDataReader.Item("coluna_codigo_item")
                cboConfiguracaoColunaQuantidadeMaxima.SelectedValue = oSqlDataReader.Item("coluna_quantidade_maxima")
                cboConfiguracaoColunaPrecoCompra.SelectedValue = oSqlDataReader.Item("coluna_preco_compra")
                cboConfiguracaoColunaICMSEmbutido.SelectedValue = oSqlDataReader.Item("coluna_icms_embutido")
                cboConfiguracaoColunaAliquotaICMS.SelectedValue = oSqlDataReader.Item("coluna_aliquota_icms")
                cboConfiguracaoColunaIPIEmbutido.SelectedValue = oSqlDataReader.Item("coluna_ipi_embutido")
                cboConfiguracaoColunaAliquotaIPI.SelectedValue = oSqlDataReader.Item("coluna_aliquota_ipi")
                cboConfiguracaoColunaLeadTime.SelectedValue = oSqlDataReader.Item("coluna_lead_time")
                txtLinhaInicio.Value = oSqlDataReader.Item("linha_inicio")

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

#End Region

#End Region

End Class
