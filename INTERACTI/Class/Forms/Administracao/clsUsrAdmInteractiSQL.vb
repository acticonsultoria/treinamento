Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrAdmInteractiSQL

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sTipo As String, _
                        ByVal sDefinicao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim sQuery As String

        Try

            sQuery = "SELECT "
            sQuery &= "CAST (0 AS BIT) AS migrado,"
            sQuery &= "CASE xtype "
            sQuery &= "WHEN 'P' THEN 'STORED PROCEDURE' "
            'sQuery &= "WHEN 'V' THEN 'VIEW' "
            sQuery &= "WHEN 'FN' THEN 'SCALAR FUNCTION' "
            sQuery &= "WHEN 'TR' THEN 'TRIGGER' "
            sQuery &= "WHEN 'U' THEN 'TABLE' "
            sQuery &= "WHEN 'TF' THEN 'TABLE FUNCTION' "
            sQuery &= "END as tipo ,"
            sQuery &= "name as nome,"
            sQuery &= "CAST(crdate AS DATETIME) as data_criacao,"
            sQuery &= "objeto.id as object_id "
            sQuery &= "FROM sys.sysobjects objeto "
            sQuery &= "WHERE category <> 2 "
            sQuery &= "AND xtype IN ('P','FN','TR','U','TF') "
            If sTipo <> "" Then
                sQuery &= "and xtype = '" & sTipo & "' "
            End If
            If sDefinicao.Trim <> "" Then
                sQuery &= "and (SELECT COUNT(*) FROM sys.all_sql_modules WHERE definition like '%" & sDefinicao & "%' AND object_id = id) > 0  "
            End If
            sQuery &= "ORDER BY xtype,name  "

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, sQuery)

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

    Public Sub Executar(ByVal oGrid As GridEX, _
                        ByVal sComando As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim oColumn As GridEXColumn

        Try

            'Executando o comando
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, sComando)

            'Limpando as colunas
            oGrid.RootTable.Columns.Clear()

            'Se houver registros
            If oSqlDataReader.HasRows = True Then

                With oGrid

                    'Percorrendo todas as colunas
                    For iCont As Integer = 0 To oSqlDataReader.VisibleFieldCount - 1

                        'Adicionando o key e o caption da coluna
                        oColumn = New GridEXColumn(oSqlDataReader.GetName(iCont))
                        oColumn.Caption = oSqlDataReader.GetName(iCont)
                        'Setando para unbound
                        oColumn.BoundMode = ColumnBoundMode.Unbound

                        'Adicionado na grid
                        .RootTable.Columns.Add(oColumn)

                    Next

                    'Percorrendo os registros
                    While oSqlDataReader.Read

                        'Adicionando uma nova linha
                        .Row = .AddItem.RowIndex

                        'Percorrendo todas as colunas
                        For iCont As Integer = 0 To oSqlDataReader.VisibleFieldCount - 1

                            'Inserindo na tabela
                            oGrid.SetValue(oGrid.RootTable.Columns(iCont).Key, oSqlDataReader.Item(iCont))

                        Next

                    End While

                    'Seta Linha
                    oGrid.MoveFirst()

                End With

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Definicao(ByVal lObjectID As Long, _
                              ByVal sTipo As String, _
                              ByVal sNomeObjeto As String) As String

        'Variaveis Locais
        Dim sReturn As String = ""
        Dim sQuery As String
        Dim oSqlDataReader As SqlDataReader

        Try

            'Se for procedimentos, buscar o definition
            If sTipo <> "TABLE" Then

                sQuery = "SELECT definition FROM sys.all_sql_modules where object_id = " & lObjectID

                'Executando o comando
                Definicao = ExecuteScalar(goDatabase.sConnection, CommandType.Text, sQuery)

                'trocando para alter 
                Definicao = Replace(Definicao, "CREATE ", "ALTER ")

            Else 'Se for definição de tabela, tem que buscar de outra forma

                sQuery = "select coluna.name as nome , "
                sQuery &= "coluna.max_length as tamanho, "
                sQuery &= "coluna.precision as precisao, "
                sQuery &= "coluna.scale as escala, "
                sQuery &= "tipos.name as tipo, "
                sQuery &= "coluna.is_nullable as nulo, "
                sQuery &= "coluna.is_identity as auto_incremento "
                sQuery &= "from sys.all_columns coluna "
                sQuery &= "inner join sys.systypes tipos "
                sQuery &= "on coluna.user_type_id = tipos.xtype "
                sQuery &= "where coluna.object_id = " & lObjectID & " "
                sQuery &= "ORDER BY column_id "
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, sQuery)

                'Iniciando
                sReturn = "CREATE TABLE " & sNomeObjeto & "( "

                'Percorrendo os registros
                While oSqlDataReader.Read

                    sReturn += vbNewLine & oSqlDataReader.Item("nome") & vbTab & vbTab & vbTab

                    Select Case UCase(oSqlDataReader.Item("tipo"))

                        'Se forem campos com tamanhos informados, informar o tamanho máximo
                        Case "NVARCHAR", "CHAR", "NCHAR", "VARCHAR"
                            sReturn += oSqlDataReader.Item("tipo") & "(" & oSqlDataReader.Item("tamanho") & ") "
                        Case "NUMERIC" 'Se for numeric , informar a precisao e escala
                            sReturn += oSqlDataReader.Item("tipo") & "(" & oSqlDataReader.Item("precisao") & "," & oSqlDataReader.Item("escala") & ") "
                        Case Else 'Se não for nenhum dos dois, então não precisa informar
                            sReturn += oSqlDataReader.Item("tipo") & " "

                    End Select

                    If oSqlDataReader.Item("auto_incremento") = True Then
                        sReturn += "IDENTITY (1,1) "
                    End If

                    If oSqlDataReader.Item("nulo") = False Then
                        sReturn += "NOT NULL "
                    End If

                    sReturn += ","

                End While

                'Tirando a última vírgula
                sReturn = Mid(sReturn, 1, Len(sReturn) - 1)

                'Colocando o último parênteses
                sReturn += ")"

                'Fechando o recordset
                oSqlDataReader.Close()

                'Retorno 
                Return sReturn

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
