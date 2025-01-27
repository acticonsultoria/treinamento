Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class clsUsrCadServico

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe

    'Principal
    Private iCodigoGrupoItem As Integer
    Private sCodigoServico As String
    Private sDescricao As String
    Private bAtivo As Boolean
    Private lCodigo As Long


    'Ozone
    Private lCodigoItemManutencao As Long
    Private dPrecoVenda As Double

    'NFSe
    Private iCodigoCNAE As Integer
    Private sCodigoAtividade As String
    Private sItemServico As String
    Private dAliquotaISS As Double
    Private dPercentualAproximadoTributos As Double



#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoGrupoItem() As Integer
        Get
            Return iCodigoGrupoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoGrupoItem = value
        End Set
    End Property

    Public Property CodigoServico() As String
        Get
            Return sCodigoServico
        End Get
        Set(ByVal value As String)
            sCodigoServico = value
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

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
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

    Public Property CodigoItemManutencao() As Long
        Get
            Return lCodigoItemManutencao
        End Get
        Set(ByVal value As Long)
            lCodigoItemManutencao = value
        End Set
    End Property

    Public Property PrecoVenda() As Double
        Get
            Return dPrecoVenda
        End Get
        Set(ByVal value As Double)
            dPrecoVenda = value
        End Set
    End Property

    Public Property CodigoCNAE() As Integer
        Get
            Return iCodigoCNAE
        End Get
        Set(ByVal value As Integer)
            iCodigoCNAE = value
        End Set
    End Property

    Public Property CodigoAtividade() As String
        Get
            Return sCodigoAtividade
        End Get
        Set(ByVal value As String)
            sCodigoAtividade = value
        End Set
    End Property

    Public Property ItemServico() As String
        Get
            Return sItemServico
        End Get
        Set(ByVal value As String)
            sItemServico = value
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

    Public Property PercentualAproximadoTributos() As Double
        Get
            Return dPercentualAproximadoTributos
        End Get
        Set(ByVal value As Double)
            dPercentualAproximadoTributos = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: SERVIÇO :::"

    Public Sub InsertBOM(ByVal lCodigoServico As Long, _
                         ByVal lCodigoItem As Long, _
                         ByVal dQuantidade As Double)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoServico : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa 

            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_servico_bom", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridBOM(ByVal oGrid As GridEX, _
                           ByVal lCodigoServico As Long)

        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoServico : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_servico_bom", oSqlParameter)

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

    Public Sub DeleteBOM(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In oGrid.GetCheckedRows

                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item_filho"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_item").Value : i += 1 : ReDim Preserve oSqlParameter(i)

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item_pai"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_item_pai").Value : i += 1 : ReDim Preserve oSqlParameter(i)

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_servico_bom", oSqlParameter)

                'Exclui Linha
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
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoGrupoItem = -1, DBNull.Value, iCodigoGrupoItem) : i += 1

            'Seta Parametros - Código CNAE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cnae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCNAE = -1, DBNull.Value, iCodigoCNAE) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_atividade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoAtividade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItemServico : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_aproximado_tributos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualAproximadoTributos : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoServico : i += 1


            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.servico) : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Seta Parametros - Codigo Item Manutencao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_componente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemManutencao = -1, DBNull.Value, lCodigoItemManutencao) : i += 1

            'Seta Parametros - Preço Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1


            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_servico", oSqlParameter)

            lCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

          
            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoGrupoItem = -1, DBNull.Value, iCodigoGrupoItem) : i += 1

            'Seta Parametros - Código CNAE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cnae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCNAE = -1, DBNull.Value, iCodigoCNAE) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_atividade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoAtividade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItemServico : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_aproximado_tributos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualAproximadoTributos : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoServico : i += 1


            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.servico) : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Seta Parametros - Codigo Item Manutencao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_componente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemManutencao = -1, DBNull.Value, lCodigoItemManutencao) : i += 1

            'Seta Parametros - Preço Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_servico", oSqlParameter)

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

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_servico", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigo(ByVal lCodigo As Long, _
                                 ByVal sCodigoServico As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaCodigo = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoServico : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_servico", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCodigo = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoGrupoItem As Integer, _
                        ByVal sCodigoServico As String, _
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoServico : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.servico) : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_servico", oSqlParameter)

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

    Public Function GeraCodigoServico(ByVal iCodigoGrupoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim sReturn As String
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_gerar_codigo_servico", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
