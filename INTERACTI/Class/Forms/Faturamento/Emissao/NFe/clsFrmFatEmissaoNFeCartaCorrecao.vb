Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmFatEmissaoNFeCartaCorrecao

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoEmissaoCapa As Long
    Private sCartaCorrecao As String
    Private sDataEvento As String
    Private sNumeroProtocolo As String
    Private sXMLEvento As String
    Private sXMLRetorno As String
    Private iSequencia As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property CartaCorrecao() As String
        Get
            Return sCartaCorrecao
        End Get
        Set(ByVal value As String)
            sCartaCorrecao = value
        End Set
    End Property

    Public Property DataEvento() As String
        Get
            Return sDataEvento
        End Get
        Set(ByVal value As String)
            sDataEvento = value
        End Set
    End Property

    Public Property Sequencia() As Integer
        Get
            Return iSequencia
        End Get
        Set(ByVal value As Integer)
            iSequencia = value
        End Set
    End Property

    Public Property NumeroProtocolo() As String
        Get
            Return sNumeroProtocolo
        End Get
        Set(ByVal value As String)
            sNumeroProtocolo = value
        End Set
    End Property

    Public Property XMLEvento() As String
        Get
            Return sXMLEvento
        End Get
        Set(ByVal value As String)
            sXMLEvento = value
        End Set
    End Property

    Public Property XMLRetorno() As String
        Get
            Return sXMLRetorno
        End Get
        Set(ByVal value As String)
            sXMLRetorno = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function LoadSequencia(ByVal lCodigoEmissaoCapa As Long) As Integer

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_carta_correcao_sequencia", oSqlParameter)

            'Retorno da Função
            Return iReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Carta de Correção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "carta_correcao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = sCartaCorrecao : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Data do Evento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_evento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEvento : i += 1

            'Seta Parametros - Número do Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNumeroProtocolo : i += 1

            'Seta Parametros - XML Evento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_evento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLEvento : i += 1

            'Seta Parametros - XML Retorno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_retorno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLRetorno : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_cce", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
