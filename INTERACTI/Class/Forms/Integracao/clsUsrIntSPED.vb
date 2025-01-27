Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrIntSPED

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sCodigoBanco As String
    Private sDescricao As String
    Private bAtivo As Boolean
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE ::: "

    'Public Property DataInicio() As Date
    '    Get
    '        Return dDataInicio
    '    End Get
    '    Set(ByVal value As Date)
    '        dDataInicio = value
    '    End Set
    'End Property

    'Public Property DataTermino() As Date
    '    Get
    '        Return dDataTermino
    '    End Get
    '    Set(ByVal value As Date)
    '        dDataTermino = value
    '    End Set
    'End Property

    'Public Property ArquivoNF() As StreamWriter
    '    Get
    '        Return sArquivoNF
    '    End Get
    '    Set(ByVal value As StreamWriter)
    '        sArquivoNF = value
    '    End Set
    'End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX,
                        ByVal sDataInicio As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "competencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_sped", oSqlParameter)

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

#End Region

End Class
