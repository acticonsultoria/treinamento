Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrAdmInteractiCompare

#Region "::: FUNCTION / SUB :::"

    Public Sub Comparar(ByVal oGrid As GridEX, _
                        ByVal sConnectionOrigem As String, _
                        ByVal sConnectionDestino As String, _
                        ByVal sDatabaseOrigem As String, _
                        ByVal sDatabaseDestino As String, _
                        ByVal sKeyWord As String)

        'Variável auxiliar
        Dim sColumn As String
        Dim iResult As Integer

        'Instanciando dois Data Readers. Um para a leitura das tabelas e outro para leitura dos registros
        Dim oSqlDataReaderTabela As SqlDataReader
        Dim oSqlDataReaderRegistro As SqlDataReader

        'Instanciando um data set
        Dim oDataSet As New DataSet
        'Adicionando a tabela no dataset
        oDataSet.Tables.Add("main")

        'Adicionando as colunas
        oDataSet.Tables(0).Columns.Add("tabela").DataType = "".GetType
        oDataSet.Tables(0).Columns.Add("script").DataType = "".GetType

        'Referenciando um datarow para os registros
        Dim oDataRow As DataRow


        'Agora fazer as comparações
        Try
            'Carregando todas as tabelas do tipo usuário e que contenham a "keyword"
            oSqlDataReaderTabela = ExecuteReader(sConnectionOrigem, CommandType.Text, "SELECT * FROM sys.all_objects WHERE type = 'U' and name like '" + sKeyWord + "'")

            'Percorrendo os registros
            While oSqlDataReaderTabela.Read


                'Recebe a quantidade de linhas do registro
                iResult = ExecuteScalar(sConnectionOrigem, CommandType.Text, "SELECT COUNT(*) FROM " & sDatabaseOrigem & ".dbo." & oSqlDataReaderTabela.Item("name"))

                'Try para verificar se a tabela existe no banco de destino
                Try

                    'Verifica se a quantidade de registros de origem é maior que do destino
                    If iResult > ExecuteScalar(sConnectionDestino, CommandType.Text, "SELECT COUNT(*) FROM " & sDatabaseDestino & ".dbo." & oSqlDataReaderTabela.Item("name")) Then

                        'Recebe a coluna do codigo, status, etc.
                        sColumn = ExecuteScalar(sConnectionOrigem, CommandType.Text, "SELECT name FROM sys.columns WHERE object_id = " & oSqlDataReaderTabela.Item("object_id") & " AND column_id = 1")

                        'Verificará todos os registros da tabela
                        oSqlDataReaderRegistro = ExecuteReader(sConnectionOrigem, CommandType.Text, "SELECT * FROM " & sDatabaseOrigem & ".dbo." & oSqlDataReaderTabela.Item("name"))

                        'Percorrendo os registros
                        While oSqlDataReaderRegistro.Read

                            'Verifica se existe o registro na tabela de destino
                            If ExecuteScalar(sConnectionDestino, CommandType.Text, "SELECT COUNT(*) FROM " & sDatabaseDestino & ".dbo." & oSqlDataReaderTabela.Item("name") & " WHERE " & sColumn & " = '" & oSqlDataReaderRegistro.Item(sColumn) & " '") = 0 Then

                                'Montando a query
                                Dim sQuery As String = "INSERT INTO " & sDatabaseDestino & ".dbo." & oSqlDataReaderTabela.Item("name") & " VALUES ("

                                'Percorrendo os itens para gerar o script
                                For i As Integer = 0 To oSqlDataReaderRegistro.VisibleFieldCount - 1

                                    'Concantenado os dados
                                    sQuery += "'" & oSqlDataReaderRegistro.Item(oSqlDataReaderRegistro.GetName(i)) & "',"

                                Next
                                'Tirando a última vírgula
                                sQuery = Mid(sQuery, 1, Len(sQuery) - 1)

                                'Finalizando o insert
                                sQuery += ")"

                                'Adicionando na tabela
                                oDataRow = oDataSet.Tables(0).Rows.Add

                                'Setando os valores
                                oDataRow("tabela") = oSqlDataReaderTabela("name")
                                oDataRow("script") = sQuery
                            End If

                        End While

                    End If

                Catch ex As Exception
                    oDataRow = oDataSet.Tables(0).Rows.Add
                    oDataRow("tabela") = oSqlDataReaderTabela("name")
                    oDataRow("script") = "TABELA NÃO EXISTE"
                End Try

            End While

            'Configura a grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Seta os campos para a grid
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
