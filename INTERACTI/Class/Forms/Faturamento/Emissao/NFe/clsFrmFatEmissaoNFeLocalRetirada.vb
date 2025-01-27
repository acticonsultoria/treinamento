Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls

Public Class clsFrmFatEmissaoNFeLocalRetirada

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sCNPJ As String
    Private sLogradouro As String
    Private sNumero As String
    Private sComplemento As String
    Private sBairro As String
    Private sUF As String
    Private iMunicipio As Integer
    Private lCodigoEmissaoCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CNPJ() As String
        Get
            Return sCNPJ
        End Get
        Set(ByVal value As String)
            sCNPJ = value
        End Set
    End Property

    Public Property Logradouro() As String
        Get
            Return sLogradouro
        End Get
        Set(ByVal value As String)
            sLogradouro = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return sNumero
        End Get
        Set(ByVal value As String)
            sNumero = value
        End Set
    End Property

    Public Property Complemento() As String
        Get
            Return sComplemento
        End Get
        Set(ByVal value As String)
            sComplemento = value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return sBairro
        End Get
        Set(ByVal value As String)
            sBairro = value
        End Set
    End Property

    Public Property UF() As String
        Get
            Return sUF
        End Get
        Set(ByVal value As String)
            sUF = value
        End Set
    End Property

    Public Property Municipio() As Integer
        Get
            Return iMunicipio
        End Get
        Set(ByVal value As Integer)
            iMunicipio = value
        End Set
    End Property

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Try

            'Seta Parametros - Descricao
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 20
            oSqlParameter(0).Value = IIf(sCNPJ = "", DBNull.Value, sCNPJ)

            'Seta Parametros - Logradouro
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "logradouro"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 60
            oSqlParameter(1).Value = sLogradouro

            'Seta Parametros - Número
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "numero"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 60
            oSqlParameter(2).Value = sNumero

            'Seta Parametros - Complemento
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "complemento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 60
            oSqlParameter(3).Value = IIf(sComplemento = "", DBNull.Value, sComplemento)

            'Seta Parametros - Bairro
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "bairro"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 60
            oSqlParameter(4).Value = sBairro

            'Seta Parametros - UF
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "uf"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 2
            oSqlParameter(5).Value = sUF

            'Seta Parametros - Código Município
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_municipio"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iMunicipio

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_emissao_capa"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.BigInt
            oSqlParameter(7).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_empresa"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(8).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_local_retirada", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_local_retirada", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal lCodigoEmissaoCapa As Long, _
                             ByVal txtCNPJ As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal cboMunicipio As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_local_retirada", oSqlParameter)

            While oSqlDataReader.Read

                txtCNPJ.Text = IIf(IsDBNull(oSqlDataReader.Item("cnpj")), "", oSqlDataReader.Item("cnpj"))
                txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Text = oSqlDataReader.Item("numero")
                txtComplemento.Text = IIf(IsDBNull(oSqlDataReader.Item("complemento")), "", oSqlDataReader.Item("complemento"))
                txtBairro.Text = oSqlDataReader.Item("bairro")
                cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")

            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesCNPJ(ByVal sCNPJ As String, _
                                 ByVal txtLogradouro As MaskedEditBox, _
                                 ByVal txtNumero As MaskedEditBox, _
                                 ByVal txtComplemento As MaskedEditBox, _
                                 ByVal txtBairro As MaskedEditBox, _
                                 ByVal cboUF As UIComboBox, _
                                 ByVal cboMunicipio As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - CNPJ
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "cnpj"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 20
            oSqlParameter(0).Value = sCNPJ

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_cnpj", oSqlParameter)

            While oSqlDataReader.Read

                txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Text = oSqlDataReader.Item("numero")
                txtComplemento.Text = IIf(IsDBNull(oSqlDataReader.Item("complemento")), "", oSqlDataReader.Item("complemento"))
                txtBairro.Text = oSqlDataReader.Item("bairro")
                cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")

            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
