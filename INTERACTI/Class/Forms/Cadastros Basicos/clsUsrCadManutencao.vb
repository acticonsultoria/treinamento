Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports INTERACTI.SQLHelper

Public Class clsUsrCadManutencao

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe - Capa
    Private sCodigoManutencao As String
    Private sDescricao As String
    Private bAtivo As Boolean
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoManutencao() As String
        Get
            Return sCodigoManutencao
        End Get
        Set(ByVal value As String)
            sCodigoManutencao = value
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

#Region "::: MANUTENÇÃO :::"

    Public Sub InsertManutencao()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Usuário
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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_manutencao", oSqlParameter)

            'Seta Váriavel
            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateManutencao()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Manutenção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_manutencao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoManutencao : i += 1

            'Seta Parametros - Descrição
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

            'Seta Parametros - Código Usuário
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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_manutencao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteManutencao()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Usuário
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_manutencao", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridManutencao(ByVal oGrid As GridEX, _
                                  ByVal sCodigoManutencao As String, _
                                  ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Manutenção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_manutencao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoManutencao : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_manutencao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_manutencao"))
            oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(2).Columns("codigo_manutencao"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.RootTable.ChildTables(1).DataMember = oDataSet.Tables(2).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigo(ByVal iCodigo As Integer, _
                                 ByVal sCodigoManutencao As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCodigo = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Manutenção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_manutencao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoManutencao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_manutencao", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCodigo = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ATIVIDADE :::"

    Public Sub InsertAtividade(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetCheckedRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Manutenção
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_manutencao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Atividade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_atividade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_manutencao_atividade", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteAtividade()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try


            'Seta Parametros - Código Manutencao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_manutencao"
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_manutencao_atividade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridAtividade(ByVal oGrid As GridEX, _
                                 ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_manutencao"
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_manutencao_atividade", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            If Not oGrid.DataSource Is Nothing Then
                Dim oDataRow As DataRow
                For Each oRow As GridEXRow In oGrid.GetDataRows
                    oDataRow = oDataSet.Tables(0).Select("codigo = " & oRow.Cells("codigo").Value)(0)
                    oRow.CheckState = IIf(oDataRow.Item("x") = True, RowCheckState.Checked, RowCheckState.Unchecked)
                Next
            End If

            'Atualiza Grid
            oGrid.Refresh()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ÁREA :::"

    Public Sub InsertArea(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetCheckedRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Manutenção
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_manutencao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Área
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_area"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_manutencao_area", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteArea()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try


            'Seta Parametros - Código Manutencao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_manutencao"
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_manutencao_area", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridArea(ByVal oGrid As GridEX, _
                                 ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_manutencao"
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_manutencao_area", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            If Not oGrid.DataSource Is Nothing Then
                Dim oDataRow As DataRow
                For Each oRow As GridEXRow In oGrid.GetDataRows
                    oDataRow = oDataSet.Tables(0).Select("codigo = " & oRow.Cells("codigo").Value)(0)
                    oRow.CheckState = IIf(oDataRow.Item("x") = True, RowCheckState.Checked, RowCheckState.Unchecked)
                Next
            End If

            'Atualiza Grid
            oGrid.Refresh()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
