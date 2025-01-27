Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class clsUsrAdmInteractiControleIdioma

#Region "::: FUNCTION / SUB :::"

    Public Sub DeleteIdiomaControle()

        Try

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_static_controle_idioma")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertIdiomaControle(ByVal oMainObject As Object, _
                                    ByVal sFormulario As String)

        Try

            'Váriaveis Locais
            Dim oSqlParameter(5) As SqlParameter
            Dim i As Integer = 0
            Dim sTipo As String = ""
            Dim sTexto As String = ""

            'Percorrendo o contânier na busca dos controles com label
            For Each oObj In oMainObject.Controls

                'Zerando a variável
                sTipo = ""
                i = 0

                ReDim oSqlParameter(5)

                'Verificando qual o tipo do item
                If oObj.TEXT <> "" And _
                    (oObj.GetType.Name.ToUpper = "UITAB" Or _
                    oObj.GetType.Name.ToUpper = "UITABPAGE" Or _
                    oObj.GetType.Name.ToUpper = "BUTTON" Or _
                    oObj.GetType.Name.ToUpper = "UIBUTTON" Or _
                    oObj.GetType.Name.ToUpper = "UIGROUPBOX" Or _
                    oObj.GetType.Name.ToUpper = "LABEL" Or _
                    oObj.GetType.Name.ToUpper = "UICHECKBOX" Or _
                    oObj.GetType.Name.ToUpper = "CHECKBOX") Then

                    'Seta Parametros - Formulário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "formulario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Value = sFormulario : i += 1

                    'Seta Parametros - Tipo do Controle
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "tipo"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Value = oObj.GetType.Name : i += 1

                    'Seta Parametros - Nome do Controle
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "controle"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Value = oObj.name : i += 1

                    'Seta Parametros - Texto do Controle
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "texto"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Value = oObj.text : i += 1

                    'Inserindo os dados
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_static_controle_idioma", oSqlParameter)


                    'Para as grid´s, pegar as colunas e os tool tip´s
                ElseIf oObj.GetType.Name.ToUpper = "GRIDEX" Then

                    'Seta Parametros - Formulário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "formulario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Value = sFormulario : i += 1


                    'Percorrendo as colunas da tabela "main"
                    For Each oColumn As GridEXColumn In CType(oObj, GridEX).Tables(0).Columns

                        'Somente armazenar se tiver algo escrito
                        If oColumn.Caption <> "" Then

                            'Setando o índice
                            i = 1


                            'Seta Parametros - Tipo do Controle
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "tipo"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = oObj.GetType.Name : i += 1

                            'Seta Parametros - Nome do Controle
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "controle"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = oObj.name : i += 1

                            'Seta Parametros - Nome da Coluna
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "coluna"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = oColumn.Key : i += 1

                            'Seta Parametros - Texto do Controle
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "texto"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = oColumn.Caption

                            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_static_controle_idioma", oSqlParameter)
                        End If


                        'Somente armazenar se tiver algo escrito no tooltipe (editar, imprimir, etc)
                        If oColumn.CellToolTipText <> "" Then

                            'Setando o índice
                            i = 1


                            'Seta Parametros - Tipo do Controle
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "tipo"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = "CellToolTipText" : i += 1

                            'Seta Parametros - Nome do Controle
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "controle"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = oObj.name : i += 1

                            'Seta Parametros - Nome da Coluna
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "coluna"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = oColumn.Key : i += 1

                            'Seta Parametros - Texto do Controle
                            oSqlParameter(i) = New SqlParameter
                            oSqlParameter(i).ParameterName = "texto"
                            oSqlParameter(i).Direction = ParameterDirection.Input
                            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                            oSqlParameter(i).Value = oColumn.CellToolTipText

                            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_static_controle_idioma", oSqlParameter)
                        End If

                    Next

                    'Percorrendo as children columns
                    For Each oChildTable In CType(oObj, GridEX).Tables(0).ChildTables
                        'Percorrendo as colunas da tabela
                        For Each oColumn As GridEXColumn In oChildTable.Columns

                            'Somente armazenar se tiver algo escrito
                            If oColumn.Caption <> "" Then

                                'Setando o índice
                                i = 1


                                'Seta Parametros - Tipo do Controle
                                oSqlParameter(i) = New SqlParameter
                                oSqlParameter(i).ParameterName = "tipo"
                                oSqlParameter(i).Direction = ParameterDirection.Input
                                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                                oSqlParameter(i).Value = "childrenColumn" : i += 1

                                'Seta Parametros - Nome do Controle
                                oSqlParameter(i) = New SqlParameter
                                oSqlParameter(i).ParameterName = "controle"
                                oSqlParameter(i).Direction = ParameterDirection.Input
                                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                                oSqlParameter(i).Value = oObj.name : i += 1

                                'Seta Parametros - Nome da Coluna
                                oSqlParameter(i) = New SqlParameter
                                oSqlParameter(i).ParameterName = "coluna"
                                oSqlParameter(i).Direction = ParameterDirection.Input
                                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                                oSqlParameter(i).Value = oColumn.Key : i += 1

                                'Seta Parametros - Texto do Controle
                                oSqlParameter(i) = New SqlParameter
                                oSqlParameter(i).ParameterName = "texto"
                                oSqlParameter(i).Direction = ParameterDirection.Input
                                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                                oSqlParameter(i).Value = oColumn.Caption

                                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_static_controle_idioma", oSqlParameter)

                            End If

                        Next
                    Next
                End If

                'Recurssão para salvar os filhos 
                Call InsertIdiomaControle(oObj, sFormulario)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
