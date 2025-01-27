Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls

Public Class clsFrmFatEntradaNFeLocalEntrega

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sCNPJ As String
    Private sLogradouro As String
    Private sNumero As String
    Private sComplemento As String
    Private sBairro As String
    Private sUF As String
    Private iCodigoMunicipio As Integer
    Private lCodigoEntradaCapa As Long

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

    Public Property CodigoMunicipio() As Integer
        Get
            Return iCodigoMunicipio
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipio = value
        End Set
    End Property

    Public Property CodigoEntradaCapa() As Long
        Get
            Return lCodigoEntradaCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Salvar()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - CNPJ
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCNPJ = "", DBNull.Value, sCNPJ) : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sLogradouro = "", DBNull.Value, sLogradouro) : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sNumero = "", DBNull.Value, sNumero) : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sBairro = "", DBNull.Value, sBairro) : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUF = "", DBNull.Value, sUF) : i += 1

            'Seta Parametros - Código Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipio = -1, DBNull.Value, iCodigoMunicipio) : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_local_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal lCodigoEntradaCapa As Long, _
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
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_local_entrega", oSqlParameter)

            While oSqlDataReader.Read

                txtCNPJ.Text = oSqlDataReader.Item("cnpj")
                txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Text = oSqlDataReader.Item("numero")
                txtComplemento.Text = oSqlDataReader.Item("complemento")
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
                txtComplemento.Text = oSqlDataReader.Item("complemento")
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
