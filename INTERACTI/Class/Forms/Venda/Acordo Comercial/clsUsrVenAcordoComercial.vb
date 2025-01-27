Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrVenAcordoComercial

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroAcordoComercial As String
    Private iCodigoCliente As Integer
    Private iCodigoMoeda As Integer
    Private sDataInicio As String
    Private sDataValidade As String
    Private sDescritivo As String
    Private sObservacao As String
    Private iCodigo As Integer

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

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
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

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: ACORDO COMERCIAL :::"

    Public Sub LoadGridAcordoComercial(ByVal oGrid As GridEX, _
                                  ByVal sCodigoAcordoComercial As String, _
                                  ByVal iCodigoCliente As Integer, _
                                  ByVal iCodigoMoeda As Integer, _
                                  ByVal sDataInicioInicio As String, _
                                  ByVal sDataInicioTermino As String, _
                                  ByVal sDataValidadeInicio As String, _
                                  ByVal sDataValidadeTermino As String)

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
            oSqlParameter(i).Value = sCodigoAcordoComercial : i += 1

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

    Public Sub InsertAcordoComercial(ByRef iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

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
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial", oSqlParameter)

            'Seta Váriaveis
            iCodigo = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateAcordoComercial()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20 : i += 1

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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

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
            oSqlParameter(i).Value = iCodigoMoeda : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

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
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial", oSqlParameter)

            'Seta Váriavel
            sNumeroAcordoComercial = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteAcordoComercial()

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Function ValidaAcordoComercial(ByVal iCodigoAcordoComercial As Integer, _
                                     ByVal iCodigoCliente As Integer, _
                                     ByVal sDataInicio As String, _
                                     ByVal sDataValidade As String, _
                                     ByRef sMensagem As String) As Boolean

        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value)

            'Executa Query
            sMensagem = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_venda_acordo_comercial", oSqlParameter)

            'Seta Retorno da Função
            Return IIf(sMensagem = "", True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO :::"

    Public Sub DeleteProduto(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_item", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertProduto(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal lCodigoItem As Long, _
                             ByVal iLeadTime As Integer, _
                             ByVal dPercentualComissao As Double, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal dMultiploVenda As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorUnitario As Double, _
                             ByVal dPrecoVenda As Double)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.produto : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = iLeadTime : i += 1

            'Seta Parametros - Percentual Comissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_comissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPercentualComissao <= 0, DBNull.Value, dPercentualComissao) : i += 1

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

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProduto(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal lCodigoItem As Long, _
                             ByVal iLeadTime As Integer, _
                             ByVal dPercentualComissao As Double, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal dMultiploVenda As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorUnitario As Double, _
                             ByVal dPrecoVenda As Double, _
                             ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.produto : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = iLeadTime : i += 1

            'Seta Parametros - Percentual Comissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_comissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPercentualComissao <= 0, DBNull.Value, dPercentualComissao) : i += 1

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

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal oGrid As GridEX, _
                               ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.produto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_item", oSqlParameter)

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

#Region "::: SERVIÇO :::"

    Public Sub DeleteServico(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_item", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertServico(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorUnitario As Double, _
                             ByVal bISSRetido As Boolean, _
                             ByVal dAliquotaISS As Double)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.servico : i += 1

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

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateServico(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal iCodigo As Integer, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorUnitario As Double, _
                             ByVal bISSRetido As Boolean, _
                             ByVal dAliquotaISS As Double)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.servico : i += 1

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

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridServico(ByVal oGrid As GridEX, _
                               ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.servico : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_item", oSqlParameter)

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

#Region "::: LOCAÇÃO :::"

    Public Sub DeleteLocacao(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_item", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLocacao(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal dValorUnitario As Double, _
                             ByVal bLei10833 As Boolean, _
                             ByVal dAliquotaLei10833 As Double, _
                             ByVal bINSS As Boolean, _
                             ByVal dAliquotaINSS As Double, _
                             ByVal bISSRetido As Boolean, _
                             ByVal dAliquotaISS As Double, _
                             ByVal bIR As Boolean, _
                             ByVal dAliquotaIR As Double)

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.ativo : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Lei 10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lei_10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bLei10833 : i += 1

            'Seta Parametros - Alíquota Lei 10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_lei_10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaLei10833 : i += 1

            'Seta Parametros - INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bINSS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

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

            'Seta Parametros - IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIR : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateLocacao(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal iCodigo As Integer, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidadeMinima As Double, _
                             ByVal dValorUnitario As Double, _
                             ByVal bLei10833 As Boolean, _
                             ByVal dAliquotaLei10833 As Double, _
                             ByVal bINSS As Boolean, _
                             ByVal dAliquotaINSS As Double, _
                             ByVal bISSRetido As Boolean, _
                             ByVal dAliquotaISS As Double, _
                             ByVal bIR As Boolean, _
                             ByVal dAliquotaIR As Double)

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.ativo : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Lei 10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lei_10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bLei10833 : i += 1

            'Seta Parametros - Alíquota Lei 10833
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_lei_10833"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaLei10833 : i += 1

            'Seta Parametros - INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bINSS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

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

            'Seta Parametros - IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIR : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLocacao(ByVal oGrid As GridEX, _
                               ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoItem.ativo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_item", oSqlParameter)

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

#Region "::: DESPESA :::"

    Public Sub DeleteDespesa(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_despesa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDespesa(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal iCodigoDespesa As Long, _
                             ByVal dValorUnitario As Double)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Despesa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_despesa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDespesa : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_despesa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDespesa(ByVal iCodigoAcordoComercial As Integer, _
                             ByVal iCodigo As Integer, _
                             ByVal iCodigoDespesa As Integer, _
                             ByVal dValorUnitario As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Despesa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_despesa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDespesa : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_despesa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDespesa(ByVal oGrid As GridEX, _
                               ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_despesa", oSqlParameter)

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

#Region "::: DESPESA GALPÃO :::"

    Public Sub IntegracaoFinanceiroDespesaGalpao(ByVal lCodigoAcordoComercial As Long, _
                                                 ByVal sTipo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try


            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_venda_acordo_comercial_despesa_galpao", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub IntegracaoFinanceiroReembolsoIPTU(ByVal lCodigoAcordoComercial As Long, _
                                                 ByVal lCodigoIPTU As Long, _
                                                 ByVal dValorM2IPTU As Double, _
                                                 ByVal dValorTotalIPTu As Double, _
                                                 ByVal dDescontoIPTU As Double, _
                                                 ByVal dValorReembolsoIPTU As Double, _
                                                 ByVal iNumeroParcelaIPTU As Integer, _
                                                 ByVal sTipo As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer

        Try


            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Código IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoIPTU : i += 1

            'Seta Parametros - Valor M2 IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_m2_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dValorM2IPTU : i += 1

            'Seta Parametros - Valor Total IPTu
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dValorTotalIPTu : i += 1

            'Seta Parametros - Valor Desconto IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dDescontoIPTU : i += 1

            'Seta Parametros - Valor Reembolso IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_reembolso_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dValorReembolsoIPTU : i += 1

            'Seta Parametros - Numero Parcel IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = iNumeroParcelaIPTU : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_venda_acordo_comercial_despesa_reembolso_iptu", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosIPTU(ByVal lCodigo As Long, _
                             ByVal txtValorM2IPTU As NumericEditBox, _
                             ByVal txtValorTotalIPTU As NumericEditBox)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_iptu_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtValorTotalIPTU.Value = oSqlDataReader.Item("valor_total_iptu")
                txtValorM2IPTU.Value = oSqlDataReader.Item("valor_m2")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosAcordoComercialIPTU(ByVal lCodigo As Long, _
                                            ByVal cboIPTU As UIComboBox, _
                                            ByVal txtValorM2IPTU As NumericEditBox, _
                                            ByVal txtValorTotalIPTU As NumericEditBox, _
                                            ByVal txtValorDescontoIPTU As NumericEditBox, _
                                            ByVal txtValorReembolsoIPTU As NumericEditBox, _
                                            ByVal txtNumeroParcelaIPTU As NumericEditBox)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_iptu", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                cboIPTU.SelectedValue = IIf(IsDBNull(oSqlDataReader.Item("codigo_iptu")), -1, oSqlDataReader.Item("codigo_iptu"))
                txtValorM2IPTU.Value = oSqlDataReader.Item("valor_m2_iptu")
                txtValorTotalIPTU.Value = oSqlDataReader.Item("valor_total_iptu")
                txtValorDescontoIPTU.Value = oSqlDataReader.Item("valor_desconto_iptu")
                txtValorReembolsoIPTU.Value = oSqlDataReader.Item("valor_reembolso_iptu")
                txtNumeroParcelaIPTU.Value = oSqlDataReader.Item("numero_parcela_iptu")


            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub DeleteDespesaGalpao(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_despesa_galpao", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDespesaGalpao(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigoGalpao As Long, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGalpao : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1


            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_despesa_galpao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDespesaGalpao(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigo As Integer, _
                                   ByVal iCodigoGalpao As Integer, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Galpão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_galpao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGalpao : i += 1

            'Seta Parametros - Código Despesa Galpao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_despesa_galpao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDespesaGalpao(ByVal oGrid As GridEX, _
                                     ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_despesa_galpao", oSqlParameter)

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

#End Region

#Region "::: DESPESA CASA :::"

    Public Sub IntegracaoFinanceiroDespesaCasa(ByVal lCodigoAcordoComercial As Long, _
                                                 ByVal sTipo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try


            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_venda_acordo_comercial_despesa_casa", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub IntegracaoFinanceiroReembolsoIPTUCasa(ByVal lCodigoAcordoComercial As Long, _
                                                 ByVal lCodigoIPTU As Long, _
                                                 ByVal dValorM2IPTU As Double, _
                                                 ByVal dValorTotalIPTu As Double, _
                                                 ByVal dDescontoIPTU As Double, _
                                                 ByVal dValorReembolsoIPTU As Double, _
                                                 ByVal iNumeroParcelaIPTU As Integer, _
                                                 ByVal sTipo As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer

        Try


            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Código IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoIPTU : i += 1

            'Seta Parametros - Valor M2 IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_m2_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dValorM2IPTU : i += 1

            'Seta Parametros - Valor Total IPTu
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dValorTotalIPTu : i += 1

            'Seta Parametros - Valor Desconto IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dDescontoIPTU : i += 1

            'Seta Parametros - Valor Reembolso IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_reembolso_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dValorReembolsoIPTU : i += 1

            'Seta Parametros - Numero Parcel IPTU
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_iptu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = iNumeroParcelaIPTU : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_venda_acordo_comercial_despesa_reembolso_iptu", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
     
    Public Sub LoadDadosAcordoComercialIPTUCasa(ByVal lCodigo As Long, _
                                            ByVal cboIPTU As UIComboBox, _
                                            ByVal txtValorM2IPTU As NumericEditBox, _
                                            ByVal txtValorTotalIPTU As NumericEditBox, _
                                            ByVal txtValorDescontoIPTU As NumericEditBox, _
                                            ByVal txtValorReembolsoIPTU As NumericEditBox, _
                                            ByVal txtNumeroParcelaIPTU As NumericEditBox)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_iptu", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                cboIPTU.SelectedValue = IIf(IsDBNull(oSqlDataReader.Item("codigo_iptu")), -1, oSqlDataReader.Item("codigo_iptu"))
                txtValorM2IPTU.Value = oSqlDataReader.Item("valor_m2_iptu")
                txtValorTotalIPTU.Value = oSqlDataReader.Item("valor_total_iptu")
                txtValorDescontoIPTU.Value = oSqlDataReader.Item("valor_desconto_iptu")
                txtValorReembolsoIPTU.Value = oSqlDataReader.Item("valor_reembolso_iptu")
                txtNumeroParcelaIPTU.Value = oSqlDataReader.Item("numero_parcela_iptu")


            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
     

    Public Sub DeleteDespesaCasa(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_despesa_casa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDespesaCasa(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigoCasa As Long, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Casa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCasa : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1


            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_despesa_casa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDespesaCasa(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigo As Integer, _
                                   ByVal iCodigoCasa As Integer, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Casa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_casa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCasa : i += 1

            'Seta Parametros - Código Despesa Galpao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_despesa_casa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDespesaCasa(ByVal oGrid As GridEX, _
                                     ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_despesa_casa", oSqlParameter)

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

#End Region

#Region "::: DESPESA SALA :::"

    Public Sub IntegracaoFinanceiroDespesaSala(ByVal lCodigoAcordoComercial As Long, _
                                                 ByVal sTipo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try


            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_venda_acordo_comercial_despesa_sala", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteDespesaSala(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_despesa_sala", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDespesaSala(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigoSala As Long, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Sala
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_sala"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoSala : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1


            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_despesa_sala", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDespesaSala(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigo As Integer, _
                                   ByVal iCodigoSala As Integer, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Sala
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_sala"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoSala : i += 1

            'Seta Parametros - Código Despesa Galpao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_despesa_sala", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDespesaSala(ByVal oGrid As GridEX, _
                                     ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_despesa_sala", oSqlParameter)

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

#Region "::: DESPESA BOX :::"

    Public Sub IntegracaoFinanceiroDespesaBox(ByVal lCodigoAcordoComercial As Long, _
                                                 ByVal sTipo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try


            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoAcordoComercial : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_venda_acordo_comercial_despesa_box", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteDespesaBox(ByVal iCodigoAcordoComercial As Integer)

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_acordo_comercial_despesa_box", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDespesaBox(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigoBox As Long, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Box
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_box"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBox : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1


            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_acordo_comercial_despesa_box", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDespesaBox(ByVal iCodigoAcordoComercial As Integer, _
                                   ByVal iCodigo As Integer, _
                                   ByVal iCodigoBox As Integer, _
                                   ByVal iNumeroParcelaInicial As Integer, _
                                   ByVal iNumeroParcelaFinal As Integer, _
                                   ByVal dValorParcela As Double, _
                                   ByVal dValorDesconto As Double, _
                                   ByVal dValorFinal As Double)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Box
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_box"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBox : i += 1

            'Seta Parametros - Código Despesa Galpao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Número Parcela Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaInicial : i += 1

            'Seta Parametros - Número Parcela Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaFinal : i += 1

            'Seta Parametros - Valor Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorParcela : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_acordo_comercial_despesa_box", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDespesaBox(ByVal oGrid As GridEX, _
                                     ByVal iCodigoAcordoComercial As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcordoComercial : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_acordo_comercial_despesa_box", oSqlParameter)

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

#End Region


#End Region

End Class
