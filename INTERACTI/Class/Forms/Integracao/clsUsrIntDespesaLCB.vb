Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports System.IO

Public Class clsUsrIntDespesaLCB

#Region "::: FUNCTION / SUB :::"

#Region "::: TÍTULO :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sSerie As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal iStatus As Integer, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iTipoTituloFinanceiro As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sParceiroNegocio : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            'Seta Parametros - Tipo Título Financeiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_titulo_financeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoTituloFinanceiro : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D" : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_despesa_lcbsistema", oSqlParameter)

            'Confiugra DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.DataSource = oDataSet.DefaultViewManager

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Integrar(ByVal sPath As String)

        'Variaveis Locais
        Dim sCodigoTituloCapa As String = ""
        Dim oSqlParameter(4) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim oStreamWriter As StreamWriter
        Dim iRevisao As Integer
        Dim i As Integer = 0
        Dim iRodada As Integer = 1

        Try

            'Carrega Código do Título Capa
            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Separador
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "separador"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = "|" : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Título Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_titulo_capa").Value : i += 1

                'Seta Parametros - Número Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("numero_parcela").Value

                If iRodada = 1 Then

                    'Executa Query - Fornecedor
                    oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_despesa_lcbsistema_fornecedor", oSqlParameter)

                    While oSqlDataReader.Read
                        'Escreve Linha
                        iRevisao = oSqlDataReader.Item("revisao")
                        If IsNothing(oStreamWriter) Then
                            oStreamWriter = New StreamWriter(sPath & "\FN" & Format(Now.Date, "yyyyMMdd") & "_" & Format(iRevisao, "00") & ".txt")
                        End If
                        oStreamWriter.WriteLine(oSqlDataReader.Item("arquivo"))
                    End While

                    'Fecha Arquivo / SQL Reader
                    If IsNothing(oStreamWriter) = False Then oStreamWriter.Close() : oStreamWriter = Nothing
                    If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

                    'Executa Query - Centro de Gasto
                    oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_despesa_lcbsistema_centro_custo", oSqlParameter)

                    While oSqlDataReader.Read
                        If IsNothing(oStreamWriter) Then
                            oStreamWriter = New StreamWriter(sPath & "\CC" & Format(Now.Date, "yyyyMMdd") & "_" & Format(iRevisao, "00") & ".txt")
                        End If
                        'Escreve Linha
                        oStreamWriter.WriteLine(oSqlDataReader.Item("arquivo"))
                    End While

                    'Fecha Arquivo / SQL Reader
                    If IsNothing(oStreamWriter) = False Then oStreamWriter.Close() : oStreamWriter = Nothing
                    If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

                End If

                'Executa Query - Despesa
                oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_despesa_lcbsistema_despesa", oSqlParameter)

                While oSqlDataReader.Read
                    If IsNothing(oStreamWriter) Then
                        oStreamWriter = New StreamWriter(sPath & "\DP" & Format(Now.Date, "yyyyMMdd") & "_" & Format(iRevisao, "00") & ".txt")
                    End If
                    'Escreve Linha
                    oStreamWriter.WriteLine(oSqlDataReader.Item("arquivo"))
                End While

                'Fecha o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Next

            'Fecha Arquivo / SQL Reader
            If IsNothing(oStreamWriter) = False Then oStreamWriter.Close() : oStreamWriter = Nothing


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
