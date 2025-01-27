Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop.Excel

Public Class clsFrmCfgGrid

#Region "::: VÁRIAVEIS :::"

    Private sNomeFormulario As String
    Private sNomeGrid As String

#End Region

#Region "::: PROPERTY :::"

    Public Property NomeFormulario() As String
        Get
            Return sNomeFormulario
        End Get
        Set(ByVal value As String)
            sNomeFormulario = value
        End Set
    End Property

    Public Property NomeGrid() As String
        Get
            Return sNomeGrid
        End Get
        Set(ByVal value As String)
            sNomeGrid = value
        End Set
    End Property


#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal oGridExcel As GridEX, _
                        ByVal sNomeFormulario As String)

        'Variaveis Locais
        Dim sResult As String
        Dim oColumn As GridEXColumn
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            With oGrid

                For Each oColumn In oGridExcel.RootTable.Columns

                    If oColumn.Tag = "S" Or (oColumn.Tag = "A" And VerificaDireito(sNomeFormulario, gcAdministrator) = True) Then

                        'Seta Váriavel
                        i = 0

                        'Adiciona Linha
                        oGrid.Row = oGrid.AddItem().RowIndex

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

                        'Seta Parametros - Nome Formulário
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "nome_formulario"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 50
                        oSqlParameter(i).Value = sNomeFormulario : i += 1

                        'Seta Parametros - Nome Grid
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "nome_grid"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 50
                        oSqlParameter(i).Value = oGridExcel.Name : i += 1

                        'Seta Parametros - Campo
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "campo"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 50
                        oSqlParameter(i).Value = oColumn.Key

                        sResult = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_grid", oSqlParameter)

                        'Seta Valores
                        oGrid.SetValue("campo", oColumn.Caption)
                        oGrid.SetValue("key", oColumn.Key)
                        oGrid.SetValue("exibir", CBool(IIf(sResult Is Nothing, oColumn.Visible, sResult)))
                        


                        oGrid.Row = 0
                        oGrid.Refresh()

                    End If

                Next

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        Try

            Dim i As Integer = 0
            Dim oSqlParameter(3) As SqlParameter

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
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nome Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNomeFormulario : i += 1

            'Seta Parametros - Nome Grid
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_grid"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNomeGrid

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_configuracao_grid", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar(ByVal oGrid As GridEX)

        Try

            Dim oSqlParameter(5) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In oGrid.GetDataRows

                i = 0

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Nome Formulário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = sNomeFormulario : i += 1

                'Seta Parametros - Nome Grid
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nome_grid"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = sNomeGrid : i += 1

                'Seta Parametros - Campo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "campo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = oRow.Cells("key").Value : i += 1

                'Seta Parametros - Exibir
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "exibir"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("exibir").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_grid", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
