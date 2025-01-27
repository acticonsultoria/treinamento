Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinCashFlow

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridSintetico(ByVal oGrid As GridEX, _
                                 ByVal dDataTermino As Date, _
                                 ByVal dSaldoInicial As Double, _
                                 ByVal iCodigoBancoConta As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim dSaldo As Double = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Saldo Inicial
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "saldo_inicial"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Float
            oSqlParameter(1).Value = dSaldoInicial

            'Seta Parametros - Data Término
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = dDataTermino

            'Seta Parametros - Código Conta Bancaria
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_banco_conta"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoBancoConta



            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_cash_flow", oSqlParameter)


            ConfigurarDataMemberGrid(oGrid)

            With oGrid

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(4).TableName

            End With


            'Arruma as colunas
            Dim dData As Date = New Date(Year(Now), Month(Now), 1)
            Dim dDataFormatada As String = Format(dData, "yyyy/MM")


            For i As Integer = 2 To 13
                oGrid.RootTable.Columns(i).Caption = Format(dData, "MMM/yy")
                oGrid.RootTable.Columns(i).Visible = dData <= dDataTermino

                dData = DateAdd(DateInterval.Month, 1, dData)



            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGridDespesa As GridEX, _
                        ByVal oGridReceita As GridEX, _
                        ByVal oGridResumo As GridEX, _
                        ByVal iCodigoBancoConta As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim dSaldo As Double = 0

        Try

            'Seta Parametros - Código Conta Bancaria
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_banco_conta"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigoBancoConta

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa




            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_cash_flow", oSqlParameter)


            ConfigurarDataMemberGrid(oGridDespesa)
            ConfigurarDataMemberGrid(oGridReceita)
            ConfigurarDataMemberGrid(oGridResumo)

            With oGridDespesa

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(1).TableName

            End With

            With oGridReceita

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(2).TableName

            End With

            With oGridResumo

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(3).TableName

            End With


            'Arruma as colunas
            Dim dData As Date = Now

            For i As Integer = 2 To 13
                oGridResumo.RootTable.Columns(i).Caption = Format(dData, "MMM/yy")
                dData = DateAdd(DateInterval.Month, 1, dData)
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    
#End Region

End Class
