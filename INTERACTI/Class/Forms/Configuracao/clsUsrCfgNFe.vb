Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgNFe

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
    Private iModoOperacao As Integer
    Private iFormaImpressaoDanfe As Integer
    Private sUF As String
    Private iTimeOut As Integer

    Private iQuantidadeMaximaNF As Integer
    Private iTamanhoMaximo As Integer

    Private bHorarioVerao As Boolean

    Private sURLConsultaCadastro As String
    Private sURLRecepcao As String
    Private sURLRetRecepcao As String
    Private sURLCancelamento As String
    Private sURLInutilizacao As String
    Private sURLStatusServico As String
    Private sURLConsulta As String

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

    Public Property ModoOperacao() As Integer
        Get
            Return iModoOperacao
        End Get
        Set(ByVal value As Integer)
            iModoOperacao = value
        End Set
    End Property

    Public Property FormaImpressaoDanfe() As Integer
        Get
            Return iFormaImpressaoDanfe
        End Get
        Set(ByVal value As Integer)
            iFormaImpressaoDanfe = value
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

    Public Property TimeOut() As Integer
        Get
            Return iTimeOut
        End Get
        Set(ByVal value As Integer)
            iTimeOut = value
        End Set
    End Property

    Public Property QuantidadeMaximaNF() As Integer
        Get
            Return iQuantidadeMaximaNF
        End Get
        Set(ByVal value As Integer)
            iQuantidadeMaximaNF = value
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

    Public Property HorarioVerao() As Boolean
        Get
            Return bHorarioVerao
        End Get
        Set(ByVal value As Boolean)
            bHorarioVerao = value
        End Set
    End Property

    Public Property URLConsultaCadastro() As String
        Get
            Return sURLConsultaCadastro
        End Get
        Set(ByVal value As String)
            sURLConsultaCadastro = value
        End Set
    End Property

    Public Property URLRecepcao() As String
        Get
            Return sURLRecepcao
        End Get
        Set(ByVal value As String)
            sURLRecepcao = value
        End Set
    End Property

    Public Property URLRetRecepcao() As String
        Get
            Return sURLRetRecepcao
        End Get
        Set(ByVal value As String)
            sURLRetRecepcao = value
        End Set
    End Property

    Public Property URLCancelamento() As String
        Get
            Return sURLCancelamento
        End Get
        Set(ByVal value As String)
            sURLCancelamento = value
        End Set
    End Property

    Public Property URLInutilizacao() As String
        Get
            Return sURLInutilizacao
        End Get
        Set(ByVal value As String)
            sURLInutilizacao = value
        End Set
    End Property

    Public Property URLStatusServico() As String
        Get
            Return sURLStatusServico
        End Get
        Set(ByVal value As String)
            sURLStatusServico = value
        End Set
    End Property

    Public Property URLConsulta() As String
        Get
            Return sURLConsulta
        End Get
        Set(ByVal value As String)
            sURLConsulta = value
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_nfe_diretorios", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SaveOutros()

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
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
            oSqlParameter(i).Value = sSenha : i += 1

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
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoAmbiente : i += 1

            'Seta Parametros - Modo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modo_operacao_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iModoOperacao : i += 1

            'Seta Parametros - Forma de Impressão do DANFE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_impressao_danfe_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iFormaImpressaoDanfe : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - Time Out
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_timeout_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTimeOut : i += 1

            'Seta Parametros - Quantidade Máxima NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_maxima_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iQuantidadeMaximaNF : i += 1

            'Seta Parametros - Tamanho Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tamanho_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTamanhoMaximo : i += 1

            'Seta Parametros - Horário de Verão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horario_verao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bHorarioVerao : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_nfe_outros", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SaveEmail(ByVal bEnviarEmailAutomaticamente As Boolean, _
                         ByVal sEmail As String, _
                         ByVal sUsuario As String, _
                         ByVal sSenha As String, _
                         ByVal sServidor As String, _
                         ByVal sPorta As String, _
                         ByVal bSSL As Boolean, _
                         ByVal iCodigoAutotexto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Enviar E-mail Automaticamente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "envia_email_automatico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEnviarEmailAutomaticamente : i += 1

            'Seta Parametros - E-mail
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = IIf(bEnviarEmailAutomaticamente = True, sEmail, DBNull.Value) : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario_email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = IIf(bEnviarEmailAutomaticamente = True, sUsuario, DBNull.Value) : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "senha_email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(bEnviarEmailAutomaticamente = True, Cripitografar(sSenha), DBNull.Value) : i += 1

            'Seta Parametros - Servidor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "servidor_email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = IIf(bEnviarEmailAutomaticamente = True, sServidor, DBNull.Value) : i += 1

            'Seta Parametros - Porta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porta_email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bEnviarEmailAutomaticamente = True, IIf(sPorta = -1, DBNull.Value, sPorta), DBNull.Value) : i += 1

            'Seta Parametros - SSL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ssl_email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEnviarEmailAutomaticamente = True, bSSL, DBNull.Value) : i += 1

            'Seta Parametros - Modo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_autotexto_email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bEnviarEmailAutomaticamente = True, iCodigoAutotexto, DBNull.Value) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_nfe_email", oSqlParameter)

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
                         ByVal cboModoOperacao As UIComboBox, _
                         ByVal cboFormaImpressaoDanfe As UIComboBox, _
                         ByVal cboUF As UIComboBox, _
                         ByVal cboTimeOut As UIComboBox, _
                         ByVal txtQuantidadeMaximaNFe As NumericEditBox, _
                         ByVal txtTamanhoMaximoNFe As NumericEditBox, _
                         ByVal cboHorarioVerao As UIComboBox, _
                         ByVal cboCertificado As UIComboBox, _
                         ByVal cboEnviarEmailAutomaticamente As UIComboBox, _
                         ByVal txtEmail As MaskedEditBox, _
                         ByVal txtUsuarioEmail As MaskedEditBox, _
                         ByVal txtSenhaEmail As EditBox, _
                         ByVal txtServidorEmail As MaskedEditBox, _
                         ByVal txtPortaEmail As MaskedEditBox, _
                         ByVal cboSSLEmail As UIComboBox, _
                         ByVal cboAutotextoEmail As UIComboBox)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_nfe", oSqlParameter)

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
                cboTipoAmbiente.SelectedValue = oSqlDataReader.Item("codigo_tipo_ambiente_nfe")
                cboModoOperacao.SelectedValue = oSqlDataReader.Item("codigo_modo_operacao_nfe")
                cboFormaImpressaoDanfe.SelectedValue = oSqlDataReader.Item("codigo_forma_impressao_danfe_nfe")
                cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboTimeOut.SelectedValue = oSqlDataReader.Item("codigo_timeout_nfe")
                txtQuantidadeMaximaNFe.Value = oSqlDataReader.Item("quantidade_maxima_nfe")
                txtTamanhoMaximoNFe.Value = oSqlDataReader.Item("tamanho_maximo")
                cboHorarioVerao.SelectedValue = oSqlDataReader.Item("horario_verao")
                cboCertificado.SelectedValue = oSqlDataReader.Item("certificado")
                cboEnviarEmailAutomaticamente.SelectedValue = oSqlDataReader.Item("enviar_email_automatico")
                txtEmail.Text = oSqlDataReader.Item("email")
                txtUsuarioEmail.Text = oSqlDataReader.Item("usuario_email")
                txtSenhaEmail.Text = Cripitografar(oSqlDataReader.Item("senha_email"))
                txtServidorEmail.Text = oSqlDataReader.Item("servidor_email")
                txtPortaEmail.Text = oSqlDataReader.Item("porta_email")
                cboSSLEmail.SelectedValue = oSqlDataReader.Item("ssl_email")
                cboAutotextoEmail.SelectedValue = oSqlDataReader.Item("codigo_autotexto_email")

            End While

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
