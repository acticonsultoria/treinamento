Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgOrcamento

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sCertificado As String

    Private sPastaEntrada As String
    Private sPastaSaida As String
    Private sPastaRecibo As String
    Private sPastaImpressao As String
    Private sPastaXSD As String
    Private sPastaEnvio As String

    Private bHabilitaProxy As Boolean
    Private sDominio As String
    Private sUsuario As String
    Private sSenha As String
    Private sEndereco As String
    Private iPorta As Integer

    Private iTipoAmbiente As Integer
    Private iTamanhoMaximo As Integer

    Private sURLHomologacao As String
    Private sURLProducao As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Certificado() As String
        Get
            Return sCertificado
        End Get
        Set(ByVal value As String)
            sCertificado = value
        End Set
    End Property

    Public Property PastaEntrada() As String
        Get
            Return sPastaEntrada
        End Get
        Set(ByVal value As String)
            sPastaEntrada = value
        End Set
    End Property

    Public Property PastaSaida() As String
        Get
            Return sPastaSaida
        End Get
        Set(ByVal value As String)
            sPastaSaida = value
        End Set
    End Property

    Public Property PastaRecibo() As String
        Get
            Return sPastaRecibo
        End Get
        Set(ByVal value As String)
            sPastaRecibo = value
        End Set
    End Property

    Public Property PastaImpressao() As String
        Get
            Return sPastaImpressao
        End Get
        Set(ByVal value As String)
            sPastaImpressao = value
        End Set
    End Property

    Public Property PastaXSD() As String
        Get
            Return sPastaXSD
        End Get
        Set(ByVal value As String)
            sPastaXSD = value
        End Set
    End Property

    Public Property PastaEnvio() As String
        Get
            Return sPastaEnvio
        End Get
        Set(ByVal value As String)
            sPastaEnvio = value
        End Set
    End Property

    Public Property HabilitaProxy() As Boolean
        Get
            Return bHabilitaProxy
        End Get
        Set(ByVal value As Boolean)
            bHabilitaProxy = value
        End Set
    End Property

    Public Property Dominio() As String
        Get
            Return sDominio
        End Get
        Set(ByVal value As String)
            sDominio = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return sUsuario
        End Get
        Set(ByVal value As String)
            sUsuario = value
        End Set
    End Property

    Public Property Senha() As String
        Get
            Return sSenha
        End Get
        Set(ByVal value As String)
            sSenha = value
        End Set
    End Property

    Public Property Endereco() As String
        Get
            Return sEndereco
        End Get
        Set(ByVal value As String)
            sEndereco = value
        End Set
    End Property

    Public Property Porta() As Integer
        Get
            Return iPorta
        End Get
        Set(ByVal value As Integer)
            iPorta = value
        End Set
    End Property


    Public Property TipoAmbiente() As Integer
        Get
            Return iTipoAmbiente
        End Get
        Set(ByVal value As Integer)
            iTipoAmbiente = value
        End Set
    End Property

    Public Property TamanhoMaximo() As Integer
        Get
            Return iTamanhoMaximo
        End Get
        Set(ByVal value As Integer)
            iTamanhoMaximo = value
        End Set
    End Property


    Public Property URLProducao() As String
        Get
            Return sURLProducao
        End Get
        Set(ByVal value As String)
            sURLProducao = value
        End Set
    End Property

    Public Property URLHomologacao() As String
        Get
            Return sURLHomologacao
        End Get
        Set(ByVal value As String)
            sURLHomologacao = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Update(ByVal dFaturamentoAnual As Double, _
                      ByVal dFaturamentoMensal As Double, _
                      ByVal dDespesaMensal As Double)

        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "faturamento_anual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFaturamentoAnual : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "faturamento_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFaturamentoMensal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "despesa_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDespesaMensal

            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_configuracao_orcamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal txtFaturamentoAnual As NumericEditBox, _
                         ByVal txtFaturamentoMensal As NumericEditBox, _
                         ByVal txtDespesaMensal As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_orcamento", oSqlParameter)

            While oSqlDataReader.Read

                txtFaturamentoAnual.Value = oSqlDataReader("faturamento_anual")
                txtFaturamentoMensal.Value = oSqlDataReader("faturamento_mensal")
                txtDespesaMensal.Value = oSqlDataReader("despesa_mensal")

            End While

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
