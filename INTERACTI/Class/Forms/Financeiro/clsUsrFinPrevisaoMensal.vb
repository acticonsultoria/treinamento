Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrFinPrevisaoMensal

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGridAnalitico As GridEX, _
                        ByVal oGridMensal As GridEX, _
                        ByVal sTipoFiltro As String, _
                        ByVal dDataInicio As Date, _
                        ByVal dDataTermino As Date, _
                        ByVal bRecebido As Boolean, _
                        ByVal bFaturado As Boolean, _
                        ByVal bPrevisao As Boolean, _
                        ByVal bForecast As Boolean, _
                        ByVal bDespesa As Boolean, _
                        ByVal bReceita As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_filtro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoFiltro : i += 1


            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataInicio : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataTermino : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "recebido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bRecebido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "faturado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFaturado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "previsao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPrevisao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "forecast"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bForecast : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bReceita : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "despesa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDespesa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_previsao_mensal", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGridAnalitico)
            Call ConfigurarDataMemberGrid(oGridMensal)

            'Carrega Grid
            oGridAnalitico.DataSource = oDataSet.DefaultViewManager
            oGridAnalitico.DataMember = oDataSet.Tables(0).TableName


            oGridMensal.DataSource = oDataSet.DefaultViewManager
            oGridMensal.DataMember = oDataSet.Tables(1).TableName

            Dim dData As Date = New Date(Year(dDataInicio), Month(dDataInicio), 1)
            dDataTermino = New Date(Year(dDataTermino), Month(dDataTermino), 1)


            Dim iCont As Integer = 0

            While iCont < 24

                If dData <= dDataTermino Then

                    oGridMensal.RootTable.Columns("mes" & CStr(iCont).PadLeft(2, "0")).Visible = True
                    oGridMensal.RootTable.Columns("mes" & CStr(iCont).PadLeft(2, "0")).Caption = Format(dData, "MMM/yy")
                    oGridMensal.RootTable.Columns("mes" & CStr(iCont).PadLeft(2, "0")).Width = 70
                Else
                    oGridMensal.RootTable.Columns("mes" & CStr(iCont).PadLeft(2, "0")).Visible = False

                End If


                'Incrementa
                iCont += 1

                'Incrmenta o contador
                dData = DateAdd(DateInterval.Month, 1, dData)
            End While




        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
