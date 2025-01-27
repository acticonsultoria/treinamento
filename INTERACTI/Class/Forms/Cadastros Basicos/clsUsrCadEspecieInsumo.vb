Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCadEspecieInsumo

#Region "::: VARIAVEIS :::"

    'Variaveis da Tipo de Alça
    Private sCodigoEspecie As String
    Private sDescricao As String
    Private bAtivo As Boolean
    Private bIncideEncargosSociais As Boolean
    Private dPercentualEncargos As Double
    Private iCodigo As Integer
    Private iCodigoEspeciePai As Integer
    Private iCodigoGrupoItem As Integer
    Private bPossuiHI As Boolean

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEspecie() As String
        Get
            Return sCodigoEspecie
        End Get
        Set(ByVal value As String)
            sCodigoEspecie = value
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

    Public Property IncideEncargosSociais() As Boolean
        Get
            Return bIncideEncargosSociais
        End Get
        Set(ByVal value As Boolean)
            bIncideEncargosSociais = value
        End Set
    End Property

    Public Property PercentualEncargos() As Double
        Get
            Return dPercentualEncargos
        End Get
        Set(ByVal value As Double)
            dPercentualEncargos = value
        End Set
    End Property

    Public Property CodigoEspeciePai() As Integer
        Get
            Return iCodigoEspeciePai
        End Get
        Set(ByVal value As Integer)
            iCodigoEspeciePai = value
        End Set
    End Property

    Public Property CodigoGrupoItem() As Integer
        Get
            Return iCodigoGrupoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoGrupoItem = value
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

    Public Property PossuiHI() As Boolean
        Get
            Return bPossuiHI
        End Get
        Set(ByVal value As Boolean)
            bPossuiHI = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: ESPÉCIE :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Espécie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoEspecie : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Possui H.I.
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "possui_hi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPossuiHI : i += 1

            'Seta Parametros - Incide Encargos Sociais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incide_encargos_sociais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncideEncargosSociais : i += 1

            'Seta Parametros - Percentual Encargos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "encargos_sociais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualEncargos : i += 1

            'Seta Parametros - Codigo Espécie Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especie_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspeciePai = -1, DBNull.Value, iCodigoEspeciePai) : i += 1

            'Seta Parametros - Codigo Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoGrupoItem = -1, DBNull.Value, iCodigoGrupoItem) : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_especie_insumo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Espécie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoEspecie : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Possui H.I.
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "possui_hi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPossuiHI : i += 1

            'Seta Parametros - Incide Encargos Sociais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incide_encargos_sociais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncideEncargosSociais : i += 1

            'Seta Parametros - Percentual Encargos
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "encargos_sociais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualEncargos : i += 1

            'Seta Parametros - Codigo Espécie Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especie_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspeciePai = -1, DBNull.Value, iCodigoEspeciePai) : i += 1

            'Seta Parametros - Codigo Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoGrupoItem = -1, DBNull.Value, iCodigoGrupoItem) : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_especie_insumo", oSqlParameter)

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_especie_insumo", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigo(ByVal iCodigo As Integer, _
                                 ByVal sCodigoEspecie As String) As Boolean

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
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Espécie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoEspecie : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_especie_insumo", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCodigo = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sCodigoEspecie As String, _
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Espécie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoEspecie : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_especie_insumo", oSqlParameter)

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

#Region "::: ESPÉCIE - ENCARGOS :::"

    Public Sub InsertEncargos(ByVal iCodigoEspecieInsumo As Integer, _
                              ByVal oHashTable As Hashtable)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim oEstrutura As EncargosSociais

        Try

            For Each oEstrutura In oHashTable.Values

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Espécie Insumo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_especie_insumo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoEspecieInsumo : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Percentual Encargos
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "percentual"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oEstrutura.dPercentual : i += 1

                'Seta Parametros - Codigo Encargos Sociais
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_encargos_sociais"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oEstrutura.iCodigoEncargo

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_especie_insumo_encargos_sociais", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEncargos(ByVal iCodigoEspecieInsumo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Espécie Insumo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especie_insumo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEspecieInsumo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_especie_insumo_encargos_sociais", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
