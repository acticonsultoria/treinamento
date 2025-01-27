Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgNFSe

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

    Public Sub SaveDiretorios()

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Pasta Entrada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sPastaEntrada : i += 1

            'Seta Parametros - Pasta Saída
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_saida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sPastaSaida : i += 1

            'Seta Parametros - Pasta Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sPastaRecibo : i += 1

            'Seta Parametros - Pasta Impressão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_impressao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sPastaImpressao : i += 1

            'Seta Parametros - Pasta XSD
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_xsd"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sPastaXSD : i += 1

            'Seta Parametros - Pasta Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sPastaEnvio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_nfse_diretorios", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SaveOutros()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Habilitar Proxy
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "habilitar_proxy"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bHabilitaProxy : i += 1

            'Seta Parametros - Domínio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dominio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDominio : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = sUsuario : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "senha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = Cripitografar(sSenha) : i += 1

            'Seta Parametros - Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sEndereco : i += 1

            'Seta Parametros - Porta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iPorta = -1, DBNull.Value, iPorta) : i += 1

            'Seta Parametros - Tipo Ambiente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfse"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoAmbiente : i += 1

            'Seta Parametros - Tamanho Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tamanho_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTamanhoMaximo : i += 1

            'Seta Parametros - Certificado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "certificado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sCertificado : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_nfse_outros", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal txtPastaEntrada As MaskedEditBox, _
                         ByVal txtPastaSaida As MaskedEditBox, _
                         ByVal txtPastaRecibo As MaskedEditBox, _
                         ByVal txtPastaImpressao As MaskedEditBox, _
                         ByVal txtPastaXSD As MaskedEditBox, _
                         ByVal txtPastaEnvio As MaskedEditBox, _
                         ByVal cboHabilitaProxy As UIComboBox, _
                         ByVal txtDominio As MaskedEditBox, _
                         ByVal txtUsuario As MaskedEditBox, _
                         ByVal txtSenha As EditBox, _
                         ByVal txtEndereco As MaskedEditBox, _
                         ByVal txtPorta As MaskedEditBox, _
                         ByVal cboTipoAmbiente As UIComboBox, _
                         ByVal txtTamanhoMaximoNFe As NumericEditBox, _
                        ByVal cboCertificado As UIComboBox)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_nfse", oSqlParameter)

            While oSqlDataReader.Read

                txtPastaEntrada.Text = oSqlDataReader.Item("pasta_entrada")
                txtPastaSaida.Text = oSqlDataReader.Item("pasta_saida")
                txtPastaRecibo.Text = oSqlDataReader.Item("pasta_recibo")
                txtPastaImpressao.Text = oSqlDataReader.Item("pasta_impressao")
                txtPastaXSD.Text = oSqlDataReader.Item("pasta_xsd")
                txtPastaEnvio.Text = oSqlDataReader.Item("pasta_envio")
                cboHabilitaProxy.SelectedValue = oSqlDataReader.Item("habilitar_proxy")
                txtDominio.Text = oSqlDataReader.Item("dominio")
                txtUsuario.Text = oSqlDataReader.Item("usuario")
                txtSenha.Text = Cripitografar(oSqlDataReader.Item("senha"))
                txtEndereco.Text = oSqlDataReader.Item("endereco")
                txtPorta.Text = IIf(IsDBNull(oSqlDataReader.Item("porta")), "", oSqlDataReader.Item("porta"))
                cboTipoAmbiente.SelectedValue = oSqlDataReader.Item("codigo_tipo_ambiente_nfse")
                txtTamanhoMaximoNFe.Value = oSqlDataReader.Item("tamanho_maximo")
                cboCertificado.SelectedValue = oSqlDataReader.Item("certificado")

            End While

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
