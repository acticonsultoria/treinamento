Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports SysACTi.SQLHelper

Public Class clsUsrFatProsoft

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


    Public Sub GerarArquivoProsoft(ByVal lCodigo() As Long, _
                                   ByVal iInformacao As Integer, _
                                   ByVal iTipo As Integer)
        Try


            Dim sConcatenado As String = ""

            'Percorrendo o vetor 
            For iCont = 0 To lCodigo.Length - 1

                'Concatenando os códigos
                sConcatenado &= CStr(lCodigo(iCont)) & "|"

            Next

            'Tirando o último PIPE
            sConcatenado = Mid(sConcatenado, 1, Len(sConcatenado) - 1)

            'Gerando o arquivo
            GerarArquivo(sConcatenado, iInformacao, iTipo)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GerarArquivo(ByVal sCodigosConcatenados As String, _
                                  ByVal iInformacao As Integer, _
                                  ByVal iTipo As Integer)

        'Variaveis Locaisn
        Dim oSqlParameter(3) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim sLinha As New StringBuilder
        Dim iCont As Integer = 0
        Dim sCampo As String

        Try
            'Seta Parametros - Data Início
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = dDataInicio

            'Seta Parametros - Data Termini
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = dDataTermino

            'Seta Parametros - Códigos Concatenados
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigos"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 4000
            oSqlParameter(2).Value = sCodigosConcatenados

            'Seta Parametros - Código da Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = goUsuario.iEmpresa


            'Executa Quety
            If iInformacao = 1 Then 'Capa
                If iTipo = TipoDocumentoFiscal.Entrada Then
                    oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_entrada_capa", oSqlParameter)
                Else
                    oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_emissao_capa", oSqlParameter)
                End If
            Else
                If iTipo = TipoDocumentoFiscal.Entrada Then
                    oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_entrada_item", oSqlParameter)
                Else
                    oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_emissao_item", oSqlParameter)
                End If

            End If

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

            'Fecha o oSqlDataReader
            oSqlDataReader.Close()

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Public Sub LoadGridNF(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                          ByVal sDataInicio As String, _
                          ByVal sDataTermino As String, _
                          ByVal iTipoOperacaoNF As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Data Início
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = sDataInicio

            'Seta Parametros - Data Término
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = sDataTermino

            'Seta Parametros - Tipo de Nota Fiscal
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iTipoOperacaoNF

            'Seta Parametros - Código Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_prosoft_notas", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("nota_fiscal").DataMember = "nota_fiscal"
                .RootTable.Columns.Item("data_emissao").DataMember = "data_emissao"
                .RootTable.Columns.Item("codigo").DataMember = "codigo"
                .RootTable.Columns.Item("parceiro").DataMember = "parceiro"
                .RootTable.Columns.Item("tipo").DataMember = "tipo"


                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


