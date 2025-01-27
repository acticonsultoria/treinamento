Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrRHFuncionarioPonto

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Váriaveis - DataSet
            Dim sCommandText(1) As String
            Dim sTableName(1) As String

            sCommandText(0) = "sp_select_rh_ponto_funcionario" : sTableName(0) = "main"
            sCommandText(1) = "sp_select_rh_ponto_funcionario_horas" : sTableName(1) = "children"

            'Executa Query
            oDataSet = ExecuteDatasetChild(goDatabase.sConnection, CommandType.StoredProcedure, sCommandText, sTableName, oSqlParameter)

            With oGrid

                For i = 0 To oDataSet.Tables("main").Columns.Count - 1
                    .RootTable.Columns.Item(oDataSet.Tables("main").Columns(i).ColumnName).DataMember = oDataSet.Tables("main").Columns(i).ColumnName
                Next

                For i = 0 To oDataSet.Tables("children").Columns.Count - 1
                    .RootTable.ChildTables(0).Columns.Item(oDataSet.Tables("children").Columns(i).ColumnName).DataMember = oDataSet.Tables("children").Columns(i).ColumnName
                Next

                oDataSet.Relations.Add("children", oDataSet.Tables(0).Columns("codigo_funcionario"), oDataSet.Tables(1).Columns("codigo_funcionario"))

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = "main"
                .RootTable.ChildTables(0).DataMember = "children"

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub RecalcularPonto(ByVal sDataInicio As String, _
                               ByVal sDataTermino As String, _
                               ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_rh_funcionario_fechamento_ponto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadColumnsGrid(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim oColumn As GridEXColumn
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grid_tipo_hora_extra", oSqlParameter)

            While oSqlDataReader.Read

                oColumn = New GridEXColumn
                oColumn.Caption = "Hora " & StrConv(oSqlDataReader.Item("descricao").ToString, VbStrConv.ProperCase)
                oColumn.Key = oSqlDataReader.Item("codigo")
                oColumn.FormatString = "0.00"
                oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderLineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center

                'Adiciona Coluna
                oGrid.RootTable.Columns.Add(oColumn)
                'oGrid.RootTable.ChildTables(0).Columns.Add(oColumn)

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadColumnsGridChildren(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim oColumn As GridEXColumn
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_grid_tipo_hora_extra", oSqlParameter)

            While oSqlDataReader.Read

                oColumn = New GridEXColumn
                oColumn.Caption = "Hora " & StrConv(oSqlDataReader.Item("descricao").ToString, VbStrConv.ProperCase)
                oColumn.Key = oSqlDataReader.Item("codigo")
                oColumn.FormatString = "0.00"
                oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderLineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center

                'Adiciona Coluna
                oGrid.RootTable.ChildTables(0).Columns.Add(oColumn)

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

End Class
