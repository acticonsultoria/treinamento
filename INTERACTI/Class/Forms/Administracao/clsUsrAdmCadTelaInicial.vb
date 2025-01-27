Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrAdmCadTelaInicial

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoFormulario As Integer
    Private iCodigoFormularioAntigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoFormulario() As Integer
        Get
            Return iCodigoFormulario
        End Get
        Set(ByVal value As Integer)
            iCodigoFormulario = value
        End Set
    End Property

    Public Property CodigoFormularioAntigo() As Integer
        Get
            Return iCodigoFormularioAntigo
        End Get
        Set(ByVal value As Integer)
            iCodigoFormularioAntigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormulario : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_administracao_tela_inicial", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormulario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Formulário Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formulario_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFormularioAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_administracao_tela_inicial", oSqlParameter)

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

                i = 0

                'Seta Parametros - Código Formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_administracao_tela_inicial", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_tela_inicial", oSqlParameter)

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

End Class
