Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrEstInventario

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private bPrimeiraContagem As Boolean
    Private sNumeroInventario As String
    Private iUsuario As Integer
    Private sDataInventario As String
    Private iCodigoDeposito As Integer
    Private iCodigoUnidadeMedida As Integer
    Private lCodigo As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property PrimeiraContagem() As Boolean
        Get
            Return bPrimeiraContagem
        End Get
        Set(ByVal value As Boolean)
            bPrimeiraContagem = value
        End Set
    End Property

    Public Property NumeroInventario() As String
        Get
            Return sNumeroInventario
        End Get
        Set(ByVal value As String)
            sNumeroInventario = value
        End Set
    End Property

    Public Property Usuario() As Integer
        Get
            Return iUsuario
        End Get
        Set(ByVal value As Integer)
            iUsuario = value
        End Set
    End Property

    Public Property DataInventario() As String
        Get
            Return sDataInventario
        End Get
        Set(ByVal value As String)
            sDataInventario = value
        End Set
    End Property

    Public Property CodigoDeposito() As Integer
        Get
            Return iCodigoDeposito
        End Get
        Set(ByVal value As Integer)
            iCodigoDeposito = value
        End Set
    End Property

    Public Property CodigoUnidadeMedida() As Integer
        Get
            Return iCodigoUnidadeMedida
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedida = value
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

#Region "::: INVENTÁRIO :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeriInventario As String, _
                        ByVal iUsuario As Integer, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iCodigoDeposito As Integer, _
                        ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Numero Inventario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_inventario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeriInventario : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iUsuario : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query  
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_inventario", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_inventario_capa"))

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

    Public Sub LoadGridInventario(ByVal oGrid As GridEX, _
                                  ByVal iCodigoDeposito As Integer, _
                                  ByVal iCodigoMarca As Integer, _
                                  ByVal iStatus As Integer, _
                                  ByVal lCodigoInventarioCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Código Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMarca : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Inventário Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_inventario_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoInventarioCapa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_inventario_linha", oSqlParameter)

            'Configura DataMember Grid
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

    Public Sub SalvarCapa()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número Inventário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_inventario"
            oSqlParameter(i).Direction = ParameterDirection.InputOutput
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroInventario : i += 1

            'Seta Parametros - Contagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "contagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bPrimeiraContagem = True, 1, 0) : i += 1

            'Seta Parametros - Data Inventario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inventario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataInventario : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iUsuario : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusInventario.AguardandoAprovacao : i += 1

            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_inventario_capa", oSqlParameter)

            sNumeroInventario = oSqlParameter(0).Value
            lCodigo = oSqlParameter(8).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteInventarioLinha(ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Inventário Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_inventario_capa"
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_estoque_inventario_linha", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarLinha(ByVal oGrid As GridEX, _
                           ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                If IsNumeric(oRow.Cells("quantidade_inventario").Value) AndAlso IsNumeric(oRow.Cells("custo_medio").Value) Then

                    i = 0

                    'Seta Parametros - Código Inventário Capa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_inventario_capa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigo : i += 1

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
                    oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                    'Seta Parametros - Lote
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "lote"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 50
                    oSqlParameter(i).Value = oRow.Cells("lote").Value : i += 1

                    'Seta Parametros - Localização
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "localizacao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 50
                    oSqlParameter(i).Value = oRow.Cells("localizacao").Value : i += 1

                    'Seta Parametros - Quantidade Inventário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "quantidade_inventario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("quantidade_inventario").Value : i += 1

                    'Seta Parametros - Custo Médio
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "custo_medio"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("custo_medio").Value : i += 1

                    'Seta Parametros - Data Validade
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_validade"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(i).Value = oRow.Cells("data_validade").Value : i += 1

                    'Seta Parametros - Data Fabricação
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_fabricacao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(i).Value = oRow.Cells("data_fabricacao").Value

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_inventario_linha", oSqlParameter)

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AprovarInventario(ByVal lCodigo As Long, _
                                 ByVal sHistorico As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Histórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sHistorico : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusInventario.Aprovado : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_estoque_inventario_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadNumeroInventario() As String

        Try

            'Variaveis Locais
            Dim oSqlParameter(0) As SqlParameter
            Dim i As Integer = 0
            Dim sReturn As String

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_inventario_numero", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Public Sub UpdateConfiguracaoArquivoExcel(ByVal sColunaCodigoItem As String, _
                                              ByVal sColunaLote As String, _
                                              ByVal sColunaLocalizacao As String, _
                                              ByVal sColunaQuantidade As String, _
                                              ByVal sColunaCustoMedio As String, _
                                              ByVal sColunaDataValidade As String, _
                                              ByVal sColunaDataFabricacao As String, _
                                              ByVal iLinhaInicio As Integer)

        Dim oSqlParameter(9) As SqlParameter
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

            'Seta Parametros - Coluna Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaCodigoItem : i += 1

            'Seta Parametros - Coluna Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaLote = "", DBNull.Value, sColunaLote) : i += 1

            'Seta Parametros - Coluna Localização
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_localizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaLocalizacao = "", DBNull.Value, sColunaLocalizacao) : i += 1

            'Seta Parametros - Coluna Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sColunaQuantidade : i += 1

            'Seta Parametros - Coluna Custo Médio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_custo_medio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaCustoMedio = "", DBNull.Value, sColunaCustoMedio) : i += 1

            'Seta Parametros - Coluna Data Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaDataValidade = "", DBNull.Value, sColunaDataValidade) : i += 1

            'Seta Parametros - Coluna Data Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "coluna_data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sColunaDataFabricacao = "", DBNull.Value, sColunaDataFabricacao) : i += 1

            'Seta Parametros - Linha Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "linha_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iLinhaInicio

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importacao_estoque_inventario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadConfiguracaoArquivoExcel(ByVal cboConfiguracaoColunaCodigoItem As UIComboBox, _
                                            ByVal cboConfiguracaoColunaLote As UIComboBox, _
                                            ByVal cboConfiguracaoColunaLocalizacao As UIComboBox, _
                                            ByVal cboConfiguracaoColunaQuantidade As UIComboBox, _
                                            ByVal cboConfiguracaoColunaCustoMedio As UIComboBox, _
                                            ByVal cboConfiguracaoColunaDataValidade As UIComboBox, _
                                            ByVal cboConfiguracaoColunaDataFabricacao As UIComboBox, _
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importacao_estoque_inventario", oSqlParameter)

            While oSqlDataReader.Read

                cboConfiguracaoColunaCodigoItem.SelectedValue = oSqlDataReader.Item("coluna_codigo_item")
                cboConfiguracaoColunaLote.SelectedValue = oSqlDataReader.Item("coluna_lote")
                cboConfiguracaoColunaLocalizacao.SelectedValue = oSqlDataReader.Item("coluna_localizacao")
                cboConfiguracaoColunaQuantidade.SelectedValue = oSqlDataReader.Item("coluna_quantidade")
                cboConfiguracaoColunaCustoMedio.SelectedValue = oSqlDataReader.Item("coluna_custo_medio")
                cboConfiguracaoColunaDataValidade.SelectedValue = oSqlDataReader.Item("coluna_data_validade")
                cboConfiguracaoColunaDataFabricacao.SelectedValue = oSqlDataReader.Item("coluna_data_fabricacao")
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

End Class
