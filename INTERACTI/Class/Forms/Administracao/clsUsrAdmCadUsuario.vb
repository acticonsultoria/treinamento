Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports System.IO
Imports System.Drawing.Imaging

Public Class clsUsrAdmCadUsuario

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNome As String
    Private iPerfil As Integer
    Private sUsuario As String
    Private sSenha As String
    Private sEmail As String
    Private sCelular As String
    Private sTelefone As String
    Private sRamal As String    
    Private iDepartamento As Integer
    Private bAtivo As Boolean
    Private iCodigoVendedor As Integer
    Private iCodigoFuncionario As Integer
    Private iCodigo As Integer
    Private picAssinaturaDigital As PictureBox


#End Region

#Region "::: PROPERTIE :::"

    Public Property Nome() As String
        Get
            Return sNome
        End Get
        Set(ByVal value As String)
            sNome = value
        End Set
    End Property

    Public Property Perfil() As Integer
        Get
            Return iPerfil
        End Get
        Set(ByVal value As Integer)
            iPerfil = value
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

    Public Property Email() As String
        Get
            Return sEmail
        End Get
        Set(ByVal value As String)
            sEmail = value
        End Set
    End Property

    Public Property Celular() As String
        Get
            Return sCelular
        End Get
        Set(ByVal value As String)
            sCelular = value
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

    Public Property Ramal() As String
        Get
            Return sRamal
        End Get
        Set(ByVal value As String)
            sRamal = value
        End Set
    End Property

    Public Property Departamento() As Integer
        Get
            Return iDepartamento
        End Get
        Set(ByVal value As Integer)
            iDepartamento = value
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

    Public Property CodigoVendedor() As Integer
        Get
            Return iCodigoVendedor
        End Get
        Set(ByVal value As Integer)
            iCodigoVendedor = value
        End Set
    End Property

    Public Property CodigoFuncionario() As Integer
        Get
            Return iCodigoFuncionario
        End Get
        Set(ByVal value As Integer)
            iCodigoFuncionario = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property AssinaturaDIgital() As PictureBox
        Get
            Return picAssinaturaDigital
        End Get
        Set(ByVal value As PictureBox)
            picAssinaturaDigital = value
        End Set
    End Property



#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNome : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Perfil Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_perfil_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPerfil : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "senha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sSenha : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmail : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCelular = "", DBNull.Value, sCelular) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefone = "", DBNull.Value, sTelefone) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ramal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ramal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = IIf(sRamal = "", DBNull.Value, sRamal) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Departamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_departamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iDepartamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = Ativo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Verifica se existe Foto
            If Not picAssinaturaDigital.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picAssinaturaDigital.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Logo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "assinatura_digital"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "assinatura_digital"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            End If


            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedor = -1, DBNull.Value, iCodigoVendedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFuncionario = -1, DBNull.Value, iCodigoFuncionario)


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_administracao_cadastro_usuario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNome : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Perfil Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_perfil_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPerfil : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "senha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sSenha : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmail : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCelular = "", DBNull.Value, sCelular) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefone = "", DBNull.Value, sTelefone) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ramal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ramal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = IIf(sRamal = "", DBNull.Value, sRamal) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Departamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_departamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iDepartamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = Ativo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Verifica se existe Foto
            If Not picAssinaturaDigital.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picAssinaturaDigital.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Logo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "assinatura_digital"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "assinatura_digital"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Image
                oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            End If


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedor = -1, DBNull.Value, iCodigoVendedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFuncionario = -1, DBNull.Value, iCodigoFuncionario)


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_administracao_cadastro_usuario", oSqlParameter)

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

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_administracao_cadastro_usuario", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridUsuario(ByVal oGrid As GridEX, _
                               ByVal sNome As String, _
                               ByVal iPerfil As Integer, _
                               ByVal sUsuario As String, _
                               ByVal iDepartamento As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNome : i += 1

            'Seta Parametros - Código Perfil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_perfil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPerfil : i += 1

            'Seta Parametros - Usuario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sUsuario : i += 1

            'Seta Parametros - Código Departamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_departamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iDepartamento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_cadastro_usuario", oSqlParameter)

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

    Public Sub LoadAssinaturaDigital(ByVal lCodigoUsuario As Integer, _
                                     ByVal pAssinaturaDigital As PictureBox)

        Try

            'Variaveis Locais
            Dim oSqlDataReader As SqlDataReader
            Dim oSqlParameter(1) As SqlParameter
            Dim i As Integer = 0


            'Seta Parametros - Código Perfil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_cadastro_usuario_assinatura_digital", oSqlParameter)

            'Carrega Logo
            While oSqlDataReader.Read
                Dim bytBLOBData(oSqlDataReader.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                oSqlDataReader.GetBytes(0, 0, bytBLOBData, 0, bytBLOBData.Length)
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                pAssinaturaDigital.Image = Image.FromStream(stmBLOBData)
            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaUsuario(ByVal iCodigo As Integer, _
                                  ByVal sUsuario As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaUsuario = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_administracao_cadastro_usuario", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaUsuario = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
