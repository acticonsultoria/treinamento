Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgNumeracaoDocumento

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sTipo As String
    Private sTag As String
    Private sSigla As String
    Private iNumeroCaracteres As Integer
    Private lNumeroDocumento As Long
    Private iFormato As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Tipo() As String
        Get
            Return sTipo
        End Get
        Set(ByVal value As String)
            sTipo = value
        End Set
    End Property

    Public Property Tag() As String
        Get
            Return sTag
        End Get
        Set(ByVal value As String)
            sTag = value
        End Set
    End Property

    Public Property Sigla() As String
        Get
            Return sSigla
        End Get
        Set(ByVal value As String)
            sSigla = value
        End Set
    End Property

    Public Property NumeroCaracteres() As Integer
        Get
            Return iNumeroCaracteres
        End Get
        Set(ByVal value As Integer)
            iNumeroCaracteres = value
        End Set
    End Property

    Public Property NumeroDocumento() As Long
        Get
            Return lNumeroDocumento
        End Get
        Set(ByVal value As Long)
            lNumeroDocumento = value
        End Set
    End Property

    Public Property Formato() As Integer
        Get
            Return iFormato
        End Get
        Set(ByVal value As Integer)
            iFormato = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Save()

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Tag
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tag"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTag : i += 1

            'Seta Parametros - Sigla
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sigla"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sSigla : i += 1

            'Seta Parametros - Número de Caractéres
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_caracter"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroCaracteres : i += 1

            'Seta Parametros - Formato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iFormato : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroDocumento : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_numeracao_documento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal sTipo As String, _
                             ByVal sTag As String, _
                             ByVal txtSigla As MaskedEditBox, _
                             ByVal txtNumeroCaracter As NumericEditBox, _
                             ByVal txtNumeroDocumento As NumericEditBox, _
                             ByVal cboFormato As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Tag
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tag"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTag : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_numeracao_documento", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtSigla.Text = oSqlDataReader.Item("sigla")
                txtNumeroCaracter.Value = oSqlDataReader.Item("numero_caracter")
                txtNumeroDocumento.Value = oSqlDataReader.Item("numero_documento")
                cboFormato.SelectedValue = oSqlDataReader.Item("formato")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal sTipo As String, _
                             ByVal sTag As String, _
                             ByVal txtSigla As MaskedEditBox, _
                             ByVal txtNumeroCaracter As NumericEditBox, _
                             ByVal cboFormato As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Tag
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tag"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTag : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_numeracao_documento", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtSigla.Text = oSqlDataReader.Item("sigla")
                txtNumeroCaracter.Value = oSqlDataReader.Item("numero_caracter")                
                cboFormato.SelectedValue = oSqlDataReader.Item("formato")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
