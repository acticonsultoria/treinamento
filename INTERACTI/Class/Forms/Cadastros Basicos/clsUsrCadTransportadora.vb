Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrCadTransportadora

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe    
    Private iPersonalidade As Integer
    Private sCNPJCPF As String
    Private sRazaoSocial As String
    Private sNomeFantasia As String
    Private bAtivo As Boolean
    Private sInscricaoEstadual As String
    Private sCEP As String
    Private sUF As String
    Private sMunicipio As String
    Private sEndereco As String
    Private sObservacao As String
    Private sTelefone1 As String
    Private sTelefone2 As String
    Private sTelefoneRecado As String
    Private sFax As String
    Private sEmail As String
    Private iCodigoTransportadora As Integer
    Private bMotorista As Boolean

#End Region

#Region "::: PROPERTIE :::"
    Public Property Motorista() As Boolean
        Get
            Return bMotorista
        End Get
        Set(ByVal value As Boolean)
            bMotorista = value
        End Set
    End Property

    Public Property Personalidade() As Integer
        Get
            Return iPersonalidade
        End Get
        Set(ByVal value As Integer)
            iPersonalidade = value
        End Set
    End Property

    Public Property CNPJCPF() As String
        Get
            Return sCNPJCPF
        End Get
        Set(ByVal value As String)
            sCNPJCPF = value
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

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
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

    Public Property CEP() As String
        Get
            Return sCEP
        End Get
        Set(ByVal value As String)
            sCEP = value
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

    Public Property Municipio() As String
        Get
            Return sMunicipio
        End Get
        Set(ByVal value As String)
            sMunicipio = value
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

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
        End Set
    End Property

    Public Property Telefone1() As String
        Get
            Return sTelefone1
        End Get
        Set(ByVal value As String)
            sTelefone1 = value
        End Set
    End Property

    Public Property Telefone2() As String
        Get
            Return sTelefone2
        End Get
        Set(ByVal value As String)
            sTelefone2 = value
        End Set
    End Property

    Public Property TelefoneRecado() As String
        Get
            Return sTelefoneRecado
        End Get
        Set(ByVal value As String)
            sTelefoneRecado = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return sFax
        End Get
        Set(ByVal value As String)
            sFax = value
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

    Public Property CodigoTransportadora() As Integer
        Get
            Return iCodigoTransportadora
        End Get
        Set(ByVal value As Integer)
            iCodigoTransportadora = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: TRANSPORTADORA :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iPersonalidade : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Fantasia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNomeFantasia : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sRazaoSocial : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = Ativo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cnpj/Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJCPF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadual = "", DBNull.Value, sInscricaoEstadual) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sMunicipio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEndereco : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone1 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fax
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fax"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sFax : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone Recado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_recado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefoneRecado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEmail : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "motorista"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMotorista : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_transportadora", oSqlParameter)

            'Seta Código
            iCodigoTransportadora = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iPersonalidade : i += 1

            'Seta Parametros - Nome Fantasia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNomeFantasia : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = Ativo : i += 1

            'Seta Parametros - Cnpj/Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJCPF : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadual = "", DBNull.Value, sInscricaoEstadual) : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sMunicipio : i += 1

            'Seta Parametros - Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEndereco : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Telefone 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone1 : i += 1

            'Seta Parametros - Telefone 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone2 : i += 1

            'Seta Parametros - Fax
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fax"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sFax : i += 1

            'Seta Parametros - Telefone Recado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_recado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefoneRecado : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEmail : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "motorista"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMotorista : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_transportadora", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer
        
        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_transportadora", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCnpjCpf(ByVal lCodigo As Long, _
                                  ByVal sCNPJ As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaCnpjCpf = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Cnpj / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJ : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_transportadora", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCnpjCpf = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iPersonalidade As Integer, _
                        ByVal sRazaoSocial As String, _
                        ByVal sNomeFantasia As String, _
                        ByVal sCnpjCpf As String, _
                        ByVal sUF As String, _
                        ByVal sMunicipio As String, _
                        ByVal iImportado As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iPersonalidade : i += 1

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
            oSqlParameter(i).Value = sNomeFantasia : i += 1

            'Seta Parametros - Cnpj / Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpf : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sMunicipio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "importado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iImportado = -1, DBNull.Value, iImportado) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_transportadora", oSqlParameter)

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

    Public Sub LoadGridFind(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_find_transportadora", oSqlParameter)

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

    Public Sub LoadControles(ByVal iCodigoTransportadora As Integer, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal txtEndereco As MaskedEditBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtTelefoneRecado As MaskedEditBox, _
                             ByVal txtFax As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal chkMotorista As UICheckBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_transportadora", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.Text = oSqlDataReader.Item("municipio")
                    txtEndereco.Text = oSqlDataReader.Item("endereco")
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    chkMotorista.Checked = oSqlDataReader.Item("motorista")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CONTATO :::"

    Public Sub InsertContato(ByVal sNomeContato As String, _
                             ByVal sTelefoneContato As String, _
                             ByVal sCelularContato As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmailContato As String, _
                             ByVal sComplementoContato As String, _
                             ByVal iCodigoTipoContato As Integer)


        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeContato : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContato : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCelularContato : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmailContato : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sComplementoContato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_transportadora_contato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContato(ByVal sNomeContato As String, _
                             ByVal sTelefoneContato As String, _
                             ByVal sCelularContato As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmailContato As String, _
                             ByVal sComplementoContato As String, _
                             ByVal iCodigoTipoContato As Integer, _
                             ByVal iCodigoContato As Integer)


        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoContato : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeContato : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContato : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCelularContato : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmailContato : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sComplementoContato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_transportadora_contato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContato()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código Parceiro de Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_transportadora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoTransportadora : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_transportadora_contato", oSqlParameter)

                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridContato(ByVal oGrid As GridEX, _
                               ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_transportadora_contato", oSqlParameter)

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

#Region "::: VEÍCULO :::"

    Public Sub InsertVeiculo(ByVal sDescricao As String, _
                             ByVal sPlaca As String, _
                             ByVal sUF As String, _
                             ByVal sRNTC As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sPlaca : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRNTC

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_transportadora_veiculo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateVeiculo(ByVal sDescricao As String, _
                             ByVal sPlaca As String, _
                             ByVal sUF As String, _
                             ByVal sRNTC As String, _
                             ByVal sPlacaAntigo As String, _
                             ByVal sUFAntigo As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sPlaca : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRNTC : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sPlacaAntigo : i += 1

            'Seta Parametros - UF Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_transportadora_veiculo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVeiculo()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Transportadora
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_transportadora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoTransportadora : i += 1

                'Seta Parametros - Placa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "placa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 10
                oSqlParameter(i).Value = oRow.Cells("placa").Value : i += 1

                'Seta Parametros - UF
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "uf"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 2
                oSqlParameter(i).Value = oRow.Cells("uf").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_transportadora_veiculo", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridVeiculo(ByVal oGrid As GridEX, _
                               ByVal iCodigoTransportadora As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_transportadora_veiculo", oSqlParameter)

            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    

#End Region

#Region "::: MOTORISTA :::"
    Public Sub UpdateMotorista(ByVal iCodigoTransportadora As Integer, _
                                ByVal iCodigo As Integer, _
                                ByVal sNome As String, _
                                ByVal sCPF As String, _
                                ByVal sRG As String, _
                                ByVal sPISNIT As String, _
                                ByVal sDataNascimento As String, _
                                ByVal sCEP As String, _
                                ByVal sUF As String, _
                                ByVal iCodigoMunicipio As Integer, _
                                ByVal sEndereco As String, _
                                ByVal sPlaca As String, _
                                ByVal sNumeroNTT As String, _
                                ByVal sDataVencimentoNTT As String, _
                                ByVal sNumeroCNH As String, _
                                ByVal sDataVencimentoCNH As String)

        'Variaveis Locais
        Dim oSqlParameter(70) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNome : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCPF : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRG : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_nit"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPISNIT : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataNascimento = "", DBNull.Value, sDataNascimento) : i += 1

            'Seta Parametros - UF Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCEP : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sUF = "", DBNull.Value, sUF) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipio = -1, DBNull.Value, iCodigoMunicipio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEndereco : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPlaca : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_ntt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroNTT : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_ntt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sDataVencimentoNTT = "", DBNull.Value, sDataVencimentoNTT) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroCNH : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataVencimentoCNH = "", DBNull.Value, sDataVencimentoCNH) : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_transportadora_motorista", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertMotorista(ByVal iCodigoTransportadora As Integer, _
                                ByVal sNome As String, _
                                ByVal sCPF As String, _
                                ByVal sRG As String, _
                                ByVal sPISNIT As String, _
                                ByVal sDataNascimento As String, _
                                ByVal sCEP As String, _
                                ByVal sUF As String, _
                                ByVal iCodigoMunicipio As Integer, _
                                ByVal sEndereco As String, _
                                ByVal sPlaca As String, _
                                ByVal sNumeroNTT As String, _
                                ByVal sDataVencimentoNTT As String, _
                                ByVal sNumeroCNH As String, _
                                ByVal sDataVencimentoCNH As String)

        'Variaveis Locais
        Dim oSqlParameter(50) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNome : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCPF : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRG : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_nit"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPISNIT : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataNascimento = "", DBNull.Value, sDataNascimento) : i += 1

            'Seta Parametros - UF Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCEP : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sUF = "", DBNull.Value, sUF) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipio = -1, DBNull.Value, iCodigoMunicipio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEndereco : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPlaca : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_ntt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroNTT : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_ntt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sDataVencimentoNTT = "", DBNull.Value, sDataVencimentoNTT) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroCNH : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataVencimentoCNH = "", DBNull.Value, sDataVencimentoCNH) : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_transportadora_motorista", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridMotorista(ByVal oGrid As GridEX, _
                             ByVal iCodigoTransportadora As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_transportadora_motorista", oSqlParameter)

            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteMotorista()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Transportadora
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_transportadora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_transportadora").Value : i += 1

                'Seta Parametros - Placa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_transportadora_motorista", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#End Region

End Class
