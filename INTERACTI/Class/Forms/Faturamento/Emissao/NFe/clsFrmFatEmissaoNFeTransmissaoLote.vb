Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class clsFrmFatEmissaoNFeTransmissaoLote

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal sCodigo As String, _
                        ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_transmissao_lote", oSqlParameter)

            'Confiura os datamembers
            ConfigurarDataMemberGrid(oGrid)

            'Setando o datasource
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName
            oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal sCodigo As String, _
                        ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_transmissao_lote_produto", oSqlParameter)

            'Confiura os datamembers
            ConfigurarDataMemberGrid(oGrid)

            'Setando o datasource
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName
            oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDadosEstoque(ByVal lCodigoEmissaoCapa As Long, _
                                     ByVal iCodigoEmissaoItem As Integer, _
                                     ByVal sLocalizacao As String, _
                                     ByVal iCodigoDeposito As Integer)

        'Variaveis Locais

        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissao item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código deposito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - localizacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "localizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLocalizacao



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nfe_transmissao_lote_estoque", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidarEstoque(ByVal sCodigo As String, _
                                   ByVal bTransmissao As Boolean) As String

        'Variaveis Locais
        Dim sRetorno As String
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "transmissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTransmissao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            sRetorno = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_transmissao_lote_validar_estoque", oSqlParameter)

            Return sRetorno

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidarImposto(ByVal sCodigo As String, _
                                   ByVal bTransmissao As Boolean) As String

        'Variaveis Locais
        Dim sRetorno As String
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "transmissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTransmissao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            sRetorno = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_transmissao_lote_validar_imposto", oSqlParameter)

            Return sRetorno

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub RelatorioNovas(ByVal sCodigo As String)

        'Variaveis Locais

        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim oApplicationClass As New ApplicationClass
        Dim oWorkbook As Workbook
        Dim oWorksheet As Worksheet

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_transmissao_lote_relatorio_novas", oSqlParameter)

            If oDataSet.Tables(0).Rows.Count = 0 Then
                Exit Sub
                MsgBox("Não existes novas consultoras!", MsgBoxStyle.Information, "Relatório Novas")
            End If

            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.Sheets.Add()
            oWorksheet.Name = "Relatório Novas"

            oWorksheet.Range("A1").Value = "Código Consultora"
            oWorksheet.Range("B1").Value = "Setor"
            oWorksheet.Range("C1").Value = "Nome"

            oWorksheet.Range("A1", "C1").Font.Bold = True

            Dim iCont As Integer = 1
            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                oWorksheet.Range("A" & CStr(iCont + 1)).Value = oDataRow("codigo_consultora2")
                oWorksheet.Range("B" & CStr(iCont + 1)).Value = oDataRow("setor")
                oWorksheet.Range("C" & CStr(iCont + 1)).Value = oDataRow("razao_social")

                iCont = iCont + 1
            Next

            oWorksheet.Columns.AutoFit()
            oApplicationClass.Visible = True

        Catch SqlEx As SqlException
            oWorkbook.Close(False)
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Function GerarBoleto(ByVal sCodigo As String) As String

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigos"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_transmissao_lote_boleto", oSqlParameter)


            Dim sCodigoTituloCapa As String = ""

            While oSqlDataReader.Read

                If sCodigoTituloCapa <> "" Then sCodigoTituloCapa += ","

                sCodigoTituloCapa += oSqlDataReader.Item("codigo_titulo_capa")
            End While

            'fECHA O DATA READER
            oSqlDataReader.Close()

            Return sCodigoTituloCapa
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GerarNFe(ByVal sNossoNumero As String) As String

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nosso Numero
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNossoNumero

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_transmissao_lote_boleto_nfe", oSqlParameter)


            Dim sReturn As String = ""

            While oSqlDataReader.Read

                If sReturn <> "" Then sReturn += ","

                sReturn += oSqlDataReader.Item("codigo")
            End While

            'fECHA O DATA READER
            oSqlDataReader.Close()

            Return sReturn
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region

End Class
