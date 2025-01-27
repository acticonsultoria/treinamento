Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO
Imports System.Drawing.Imaging

Public Class clsUsrCadEmpresa

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sCNPJ As String
    Private sRazaoSocial As String
    Private sNomeFantasia As String
    Private sCNAE As String
    Private sInscricaoEstadual As String
    Private sInscricaoEstadualST As String    
    Private iRegimeTributario As Integer
    Private sSigla As String

    Private iPais As Integer
    Private sUF As String
    Private iMunicipio As Integer
    Private sLogradouro As String
    Private sNumero As String
    Private sBairro As String
    Private sComplemento As String
    Private sCEP As String
    Private sTelefone As String
    Private sEmail As String

    Private picLogo As PictureBox

    Private sInscricaoMunicipal As String
    Private iIncentivadorCultural As Integer
    Private iCodigoRegimeEspecialTributacao As Integer

    Private iCodigo As Integer

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

    Public Property RazaoSocial() As String
        Get
            Return sRazaoSocial
        End Get
        Set(ByVal value As String)
            sRazaoSocial = value
        End Set
    End Property

    Public Property NomeFantasia() As String
        Get
            Return sNomeFantasia
        End Get
        Set(ByVal value As String)
            sNomeFantasia = value
        End Set
    End Property

    Public Property CNAE() As String
        Get
            Return sCNAE
        End Get
        Set(ByVal value As String)
            sCNAE = value
        End Set
    End Property

    Public Property InscricaoEstadual() As String
        Get
            Return sInscricaoEstadual
        End Get
        Set(ByVal value As String)
            sInscricaoEstadual = value
        End Set
    End Property

    Public Property InscricaoEstadualST() As String
        Get
            Return sInscricaoEstadualST
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualST = value
        End Set
    End Property

    Public Property RegimeTributario() As Integer
        Get
            Return iRegimeTributario
        End Get
        Set(ByVal value As Integer)
            iRegimeTributario = value
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


    Public Property Pais() As Integer
        Get
            Return iPais
        End Get
        Set(ByVal value As Integer)
            iPais = value
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

    Public Property Bairro() As String
        Get
            Return sBairro
        End Get
        Set(ByVal value As String)
            sBairro = value
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

    Public Property Cep() As String
        Get
            Return sCEP
        End Get
        Set(ByVal value As String)
            sCEP = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return sTelefone
        End Get
        Set(ByVal value As String)
            sTelefone = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return sEmail
        End Get
        Set(ByVal value As String)
            sEmail = value
        End Set
    End Property


    Public Property Logo() As PictureBox
        Get
            Return picLogo
        End Get
        Set(ByVal value As PictureBox)
            picLogo = value
        End Set
    End Property


    Public Property InscricaoMunicipal() As String
        Get
            Return sInscricaoMunicipal
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipal = value
        End Set
    End Property

    Public Property IncentivadorCultural() As Integer
        Get
            Return iIncentivadorCultural
        End Get
        Set(ByVal value As Integer)
            iIncentivadorCultural = value
        End Set
    End Property

    Public Property CodigoRegimeEspecialTributacao() As Integer
        Get
            Return iCodigoRegimeEspecialTributacao
        End Get
        Set(ByVal value As Integer)
            iCodigoRegimeEspecialTributacao = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub UpdateDespesaFixa(ByVal dFaturamentoAnual As Double, _
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

    Public Sub LoadDadosDespesaFixa(ByVal txtFaturamentoAnual As NumericEditBox, _
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

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(23) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cnpj
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJ : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            'Seta Parametros - Nome Fantasia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sNomeFantasia = "", DBNull.Value, sNomeFantasia) : i += 1

            'Seta Parametros - CNAE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 7
            oSqlParameter(i).Value = IIf(sCNAE = "", DBNull.Value, sCNAE) : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadual : i += 1

            'Seta Parametros - Inscrição Estadual ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadualST = "", DBNull.Value, sInscricaoEstadualST) : i += 1

            'Seta Parametros - Regime Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_regime_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iRegimeTributario = -1, DBNull.Value, iRegimeTributario) : i += 1

            'Seta Parametros - Sigla
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sigla"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSigla : i += 1

            'Seta Parametros - País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPais : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMunicipio : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouro : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairro : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone : i += 1

            'Seta Parametros - E-mail
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEmail = "", DBNull.Value, sEmail) : i += 1

            'Verifica se existe Foto
            If Not picLogo.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picLogo.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Logo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "logo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "logo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1

            End If

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sInscricaoMunicipal = "", DBNull.Value, sInscricaoMunicipal) : i += 1

            'Seta Parametros - Incentivador Cultural
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incentivador_cultural"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iIncentivadorCultural = -1, DBNull.Value, iIncentivadorCultural) : i += 1

            'Seta Parametros - Código Regime Especial Tributação NFSe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_regime_especial_tributacao_nfse"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoRegimeEspecialTributacao = -1, DBNull.Value, iCodigoRegimeEspecialTributacao) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Seta Controle
            goUsuario.sCNPJEmpresa = sCNPJ
            goUsuario.sEmpresa = sNomeFantasia

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_empresa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal txtCnpj As MaskedEditBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal cboCNAE As UIComboBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualST As MaskedEditBox, _
                             ByVal cboRegimeTributario As UIComboBox, _
                             ByVal txtSigla As MaskedEditBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal txtTelefone As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal picLogo As PictureBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal cboIncentivadorCultural As UIComboBox, _
                             ByVal cboRegimeEspecialTributacao As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_empresa", oSqlParameter)

            While oSqlDataReader.Read

                txtCnpj.Text = oSqlDataReader.Item("cnpj")
                txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                cboCNAE.SelectedValue = oSqlDataReader.Item("cnae")
                txtInscricaoEstadual.Text = oSqlDataReader.Item("inscricao_estadual")
                txtInscricaoEstadualST.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_st")), "", oSqlDataReader.Item("inscricao_estadual_st"))
                cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                txtSigla.Text = oSqlDataReader.Item("sigla")

                cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Text = oSqlDataReader.Item("numero")
                txtBairro.Text = oSqlDataReader.Item("bairro")
                txtComplemento.Text = oSqlDataReader.Item("complemento")
                txtCEP.Text = oSqlDataReader.Item("cep")
                txtTelefone.Text = oSqlDataReader.Item("telefone")
                txtEmail.Text = oSqlDataReader.Item("email")

                'Carrega Logo
                If IsDBNull(oSqlDataReader.Item("logo")) = False Then
                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    picLogo.Image = Image.FromStream(stmBLOBData)
                End If

                txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                cboIncentivadorCultural.SelectedValue = oSqlDataReader.Item("incentivador_cultural")
                cboRegimeEspecialTributacao.SelectedValue = oSqlDataReader.Item("codigo_regime_especial_tributacao_nfse")

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadLogo(ByVal picLogo As PictureBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_empresa", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Logo
                If IsDBNull(oSqlDataReader.Item("logo")) = False Then
                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    picLogo.Image = Image.FromStream(stmBLOBData)
                End If

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
