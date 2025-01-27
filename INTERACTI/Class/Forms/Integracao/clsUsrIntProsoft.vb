Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrIntProsoft

#Region "::: VARIAVEIS :::"

    Private dDataInicio As Date
    Private dDataTermino As Date
    Private sArquivoNF As StreamWriter

#End Region

#Region "::: PROPERTIE ::: "

    Public Property DataInicio() As Date
        Get
            Return dDataInicio
        End Get
        Set(ByVal value As Date)
            dDataInicio = value
        End Set
    End Property

    Public Property DataTermino() As Date
        Get
            Return dDataTermino
        End Get
        Set(ByVal value As Date)
            dDataTermino = value
        End Set
    End Property

    Public Property ArquivoNF() As StreamWriter
        Get
            Return sArquivoNF
        End Get
        Set(ByVal value As StreamWriter)
            sArquivoNF = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function GerarArquivoProsoft(ByVal lCodigo() As Long, _
                                        ByVal iInformacao As Integer, _
                                        ByVal iTipo As Integer) As String

        Try

            'Váriaveis Locais
            Dim sConcatenado As String = ""

            'Percorrendo o vetor 
            For iCont = 0 To UBound(lCodigo)
                If lCodigo(iCont) <> 0 Then
                    sConcatenado &= CStr(lCodigo(iCont)) & "|"
                End If
            Next

            'Tirando o último PIPE
            sConcatenado = Mid(sConcatenado, 1, Len(sConcatenado) - 1)

            'Gerando o arquivo
            GerarArquivoProsoft = GerarArquivo(sConcatenado, iInformacao, iTipo)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GerarArquivo(ByVal sCodigosConcatenados As String, _
                                 ByVal iInformacao As Integer, _
                                 ByVal iTipo As Integer) As String

        'Variaveis Locaisn
        Dim oSqlParameter(3) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0
        Dim sLinha As New StringBuilder
        Dim iCont As Integer = 0
        Dim sCampo As String
        Dim sErro As String = ""

        Try

            'Seta Parametros - Código da Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - 
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = dDataTermino : i += 1

            'Seta Parametros - 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "data_inicio"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Date
            oSqlParameter(3).Value = dDataInicio : i += 1

            

            'Seta Parametros - Código
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigos"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt

            Dim lCodigo() As String = sCodigosConcatenados.Split("|")
            Dim sAux As String = ""
            For iLinha As Integer = 0 To UBound(lCodigo)

                'Setando o código
                oSqlParameter(1).Value = lCodigo(iLinha)

                'Executa Quety
                If iInformacao = 1 Then 'Capa
                    If iTipo = TipoDocumentoFiscal.Entrada Then
                        oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_entrada_capa", oSqlParameter)
                    Else
                        oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_emissao_capa", oSqlParameter)
                    End If
                ElseIf iInformacao = 0 Then
                    If iTipo = TipoDocumentoFiscal.Entrada Then
                        oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_entrada_item", oSqlParameter)
                    Else
                        oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_emissao_item", oSqlParameter)
                    End If
                ElseIf iInformacao = 3 Then
                    If iTipo = TipoDocumentoFiscal.Entrada Then
                        oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_entrada_cadastro_parceiro", oSqlParameter)
                    Else
                        oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_emissao_cadastro_parceiro", oSqlParameter)
                    End If

                End If


                If oSqlDataReader.HasRows = True Then
                    While oSqlDataReader.Read
                        'Zera Variavel Auxiliar
                        sLinha.Remove(0, sLinha.Length)
                        'Incrementando o contador
                        iCont += 1

                        'Carrega Dados do RecordSet
                        For i = 0 To oSqlDataReader.FieldCount - 1

                            'If oSqlDataReader.GetName(i).ToString.Contains("campo") Then

                            'Recebendo o campo e tratando
                            sCampo = IIf(IsDBNull(oSqlDataReader.Item(i)), "", oSqlDataReader.Item(i))
                            'Seta Variavel com o Valor da Linha
                            sLinha.Append(sCampo)

                            'End If
                        Next i

                        'Escreve Linha
                        sArquivoNF.WriteLine(sLinha.ToString)

                    End While
                Else
                    If iInformacao = 1 Then 'Somente escrever as entradas não exportadas

                        ''Verificando qual é o lugar a procurar os dados
                        'If iTipo = TipoDocumentoFiscal.Saida Then
                        '    sAux = SQLHelper.ExecuteScalar(goDatabase.sConnection, CommandType.Text, "select cast(nota_fiscal as varchar(100)) + ' - ' + razao_social FROM tb_fat_emissao_capa INNER JOIN tb_fat_emissao_destinatario ON tb_fat_emissao_capa.codigo = tb_fat_emissao_destinatario.codigo_emissao_capa WHERE tb_fat_emissao_capa.codigo = " & lCodigo(iLinha))
                        'Else
                        '    sAux = SQLHelper.ExecuteScalar(goDatabase.sConnection, CommandType.Text, "select cast(nota_fiscal as varchar(100)) + ' - ' + razao_social FROM tb_fat_emissao_capa INNER JOIN tb_fat_emissao_destinatario ON tb_fat_emissao_capa.codigo = tb_fat_emissao_destinatario.codigo_emissao_capa WHERE tb_fat_emissao_capa.codigo = " & lCodigo(iLinha))
                        'End If

                        'sErro += sAux & vbNewLine
                        sErro += lCodigo(iLinha) & "|"
                    End If
                End If

                'Fecha o oSqlDataReader
                oSqlDataReader.Close()

            Next

            GerarArquivo = sErro

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iCodigoTipoOperacao As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataInicio : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataTermino : i += 1

            'Seta Parametros - Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_faturamento_prosoft", oSqlParameter)

            'Configura DataMember - Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


