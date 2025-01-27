Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.EditControls
Imports System.IO

Public Class clsUsrFatEntradaRankFornecedor

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sFornecedor As String
                        )

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(i) As SqlParameter
        Dim oDataSet As DataSet


        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFornecedor

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nota_nf_fornecedor", oSqlParameter)



            'Configura os data members
            ConfigurarDataMemberGrid(oGrid)

            Dim oParentColumn(0) As DataColumn
            Dim oChildColumn(0) As DataColumn

            oParentColumn(0) = oDataSet.Tables(0).Columns("codigo_parceiro_negocio")
            oChildColumn(0) = oDataSet.Tables(1).Columns("parceiro_negocio")

            With oGrid

                oDataSet.Relations.Add("children", oParentColumn, oChildColumn)

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

#End Region

End Class
