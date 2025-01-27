Imports System
Imports System.Text
Imports INTERACTI.SQLHelper
Imports System.Data.SqlClient

Public Class clsFrmLogin

#Region "::: VARIAVEIS :::"

    'Variaveis do módulo
    Private sUsuario As String
    Private sSenha As String
    Private iCodigoEmpresa As Integer

#End Region
    
#Region "::: PROPERTIE :::"

    Public Property Usuario()
        Get
            Return sUsuario
        End Get
        Set(ByVal value)
            sUsuario = value
        End Set
    End Property

    Public Property Senha()
        Get
            Return sSenha
        End Get
        Set(ByVal value)
            sSenha = value
        End Set
    End Property

    Public Property Empresa()
        Get
            Return iCodigoEmpresa
        End Get
        Set(ByVal value)
            iCodigoEmpresa = value
        End Set
    End Property

#End Region

#Region "::: FUNÇÕES / SUB :::"

    Public Function Login() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sUsuario : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "senha"
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = Cripitografar(sSenha) : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "data_ultimo_acesso"
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = Criptografar16(Now.Date, gcKey & LoadDescricao("sp_select_cadastro_basico_empresa_cnpj " & iCodigoEmpresa))

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_administracao_usuario", oSqlParameter)

            If oSqlDataReader.Read() Then

                goUsuario.sUsuario = sUsuario
                goUsuario.sNome = oSqlDataReader.Item("nome")
                goUsuario.iEmpresa = oSqlDataReader.Item("codigo_empresa")
                goUsuario.iCodigoTipoEmpresa = oSqlDataReader.Item("codigo_tipo_empresa")
                goUsuario.iIdioma = oSqlDataReader.Item("codigo_idioma")
                goUsuario.iPerfil = oSqlDataReader.Item("codigo_perfil_usuario")
                goUsuario.iUsuario = oSqlDataReader.Item("codigo")
                goUsuario.sEmpresa = oSqlDataReader.Item("empresa")
                goUsuario.sCNPJEmpresa = oSqlDataReader.Item("cnpj")
                goUsuario.iDepartamento = oSqlDataReader.Item("codigo_departamento")
                goUsuario.sDataValidacao = Descriptografar16(oSqlDataReader.Item("data_validacao"), gcKey & goUsuario.sCNPJEmpresa)
                If IsDate(goUsuario.sDataValidacao) = True Then goUsuario.sDataValidade = Descriptografar16(oSqlDataReader.Item("data_validade"), gcKey & goUsuario.sCNPJEmpresa)
                If IsDate(goUsuario.sDataValidacao) = True Then goUsuario.sDataUltimoAcesso = Descriptografar16(oSqlDataReader.Item("data_ultimo_acesso"), gcKey & goUsuario.sCNPJEmpresa)
                If IsDate(goUsuario.sDataValidacao) = True Then goUsuario.iNumeroLicenca = Descriptografar16(oSqlDataReader.Item("numero_licenca"), gcKey & goUsuario.sCNPJEmpresa)
                goUsuario.sUF = oSqlDataReader.Item("uf")
                goUsuario.sCodigoIBGEMunicipio = oSqlDataReader.Item("codigo_ibge")
                goUsuario.sSiglaEmpresa = IIf(oSqlDataReader.Item("sigla_empresa") = "", " ", oSqlDataReader.Item("sigla_empresa"))
                goUsuario.bBoletoBancarioDLL = oSqlDataReader.Item("boleto_bancario_dll")

                goUsuario.bValidacaoLicencaAPI = IIf(IsDBNull(oSqlDataReader.Item("valida_licenca_api")), False, oSqlDataReader.Item("valida_licenca_api"))
                goUsuario.sDataValidacaoAPI = IIf(IsDBNull(DecryptAPI(oSqlDataReader.Item("data_validacao_api"), gcKeyAPI & RetiraPontuacaoCNPJCPF(goUsuario.sCNPJEmpresa))), "", DecryptAPI(oSqlDataReader.Item("data_validacao_api"), gcKeyAPI & RetiraPontuacaoCNPJCPF(goUsuario.sCNPJEmpresa)))
                If IsDate(goUsuario.sDataValidacaoAPI) = True Then goUsuario.sDataValidadeAPI = DecryptAPI(oSqlDataReader.Item("data_validade_api"), gcKeyAPI & RetiraPontuacaoCNPJCPF(goUsuario.sCNPJEmpresa))
                If IsDate(goUsuario.sDataValidacaoAPI) = True Then goUsuario.sDataUltimoAcessoAPI = DecryptAPI(oSqlDataReader.Item("data_ultimo_acesso_api"), gcKeyAPI & RetiraPontuacaoCNPJCPF(goUsuario.sCNPJEmpresa))
                If IsDate(goUsuario.sDataValidacaoAPI) = True Then goUsuario.iNumeroLicencaAPI = DecryptAPI(oSqlDataReader.Item("numero_licenca_api"), gcKeyAPI & RetiraPontuacaoCNPJCPF(goUsuario.sCNPJEmpresa))
                If IsDate(goUsuario.sDataValidacaoAPI) = True Then goUsuario.iToleranciaAPI = DecryptAPI(oSqlDataReader.Item("tolerancia_api"), gcKeyAPI & RetiraPontuacaoCNPJCPF(goUsuario.sCNPJEmpresa))


                'Verifica se pode ser alterado a Data de Acesso
                If IsDate(goUsuario.sDataUltimoAcesso) = True Then
                    If CDate(goUsuario.sDataUltimoAcesso) < Now.Date Then
                        Call AtualizarDataUltimoAcesso()
                    End If                    
                End If

                'Seta Retorno da Função
                Login = True

            Else

                'Seta Retorno da Função
                Login = False

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub AtualizarDataUltimoAcesso()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "data_ultimo_acesso"
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = Criptografar16(Now.Date, gcKey & goUsuario.sCNPJEmpresa)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_administracao_data_ultimo_acesso", oSqlParameter)

        Catch SqlEx As SqlException
            End
        Catch ex As Exception
            End
        End Try

    End Sub

    Private Function RetiraPontuacaoCNPJCPF(ByVal sCNPJCPF As String) As String

        Dim sResult As String = ""

        Try

            'Retira Pontuação
            sResult = Replace(Replace(Replace(sCNPJCPF, ".", ""), "-", ""), "/", "")
            'Retira Espaços em Branco
            sResult = sResult.Trim

            'Retorno Função
            Return sResult

        Catch ex As Exception
            Throw ex
        End Try

    End Function


#End Region

End Class
