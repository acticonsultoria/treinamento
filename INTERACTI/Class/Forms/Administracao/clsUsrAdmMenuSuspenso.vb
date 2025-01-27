Imports INTERACTI.SQLHelper
Imports System.Data.SqlClient
Imports System.Text
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System.Drawing.Imaging
Imports System.IO

Public Class clsUsrAdmMenuSuspenso

#Region "::: VÁRIAVEIS :::"

    Private sCodigoMenu As String
    Private sCodigo As String
    Private sDescricao As String
    Private sCodigoMenuPai As String
    Private sFormulario As String
    Private picImage As PictureBox

#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo() As String
        Get
            Return sCodigo
        End Get
        Set(ByVal value As String)
            sCodigo = value
        End Set
    End Property

    Public Property CodigoMenu() As String
        Get
            Return sCodigoMenu
        End Get
        Set(ByVal value As String)
            sCodigoMenu = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property CodigoMenuPai() As String
        Get
            Return sCodigoMenuPai
        End Get
        Set(ByVal value As String)
            sCodigoMenuPai = value
        End Set
    End Property

    Public Property Formulario() As String
        Get
            Return sFormulario
        End Get
        Set(ByVal value As String)
            sFormulario = value
        End Set
    End Property

    Public Property Imagem() As PictureBox
        Get
            Return picImage
        End Get
        Set(ByVal value As PictureBox)
            picImage = value
        End Set
    End Property

#End Region

#Region "::: EVENT :::"

    Public Event Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Sub MenuSuspenso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            RaiseEvent Click(sender, e)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, gAplicacao)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadMenuSuspenso(ByVal oMenuStrip As MenuStrip)

        Try

            'Variaveis Locais
            Dim oSqlDataReader As SqlDataReader
            Dim oMenuItem As ToolStripMenuItem
            Dim oSqlParameter(2) As SqlParameter
            Dim i As Integer = 0

            'Seta Parametros = Idioma
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_idioma"
            oSqlParameter(i).Value = goUsuario.iIdioma : i += 1

            'Seta Parametros = Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Value = goUsuario.iEmpresa

            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_cadastro_menu_suspenso", oSqlParameter)

            'Carrega Grupo
            While oSqlDataReader.Read()

                'Seta Valores do Grupo
                oMenuItem = New ToolStripMenuItem
                oMenuItem.Text = oSqlDataReader.Item("descricao").ToString
                oMenuItem.Tag = oSqlDataReader.Item("user_control").ToString
                oMenuItem.Name = oSqlDataReader.Item("codigo").ToString
                If IsDBNull(oSqlDataReader.Item("imagem")) = False Then
                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    oMenuItem.Image = Image.FromStream(stmBLOBData)
                End If

                'Verifica o Nível
                If oSqlDataReader.Item("nivel") > 0 Then
                    Try

                        Dim oMenuPai As ToolStripMenuItem
                        oMenuPai = oMenuStrip.Items.Find(oSqlDataReader.Item("codigo_menu_pai"), True)(0)
                        oMenuPai.DropDownItems.Add(oMenuItem)
                    Catch ex As Exception
                        oMenuStrip.Items.Add(oMenuItem)
                    End Try
                Else
                    oMenuStrip.Items.Add(oMenuItem)
                End If

                'Verifica se está associado há algum Registro
                AddHandler oMenuItem.Click, AddressOf MenuSuspenso_Click

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Menu
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_menu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sCodigoMenu : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Menu Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_menu_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sCodigoMenuPai = "", DBNull.Value, sCodigoMenuPai) : i += 1

            'Seta Parametros - Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "user_control"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sFormulario = "", DBNull.Value, sFormulario) : i += 1

            'Seta Parametros - Código Idioma
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_idioma"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iIdioma : i += 1

            'Verifica se existe Foto
            If Not picImage.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picImage.Image.Save(oMemoryStream, ImageFormat.Png)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Imagem
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "imagem"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData

            Else

                'Seta Parametros - Imagem
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "imagem"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value

            End If

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_static_menu_suspenso", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Menu
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_menu"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sCodigoMenu : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Menu Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_menu_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sCodigoMenuPai = "", DBNull.Value, sCodigoMenuPai) : i += 1

            'Seta Parametros - Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "user_control"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sFormulario = "", DBNull.Value, sFormulario) : i += 1

            'Seta Parametros - Código Idioma
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_idioma"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iIdioma : i += 1

            'Verifica se existe Foto
            If Not picImage.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picImage.Image.Save(oMemoryStream, ImageFormat.Png)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Imagem
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "imagem"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1

            Else

                'Seta Parametros - Imagem
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "imagem"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1

            End If

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_static_menu_suspenso", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete(ByVal sCodigo As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = sCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_static_menu_suspenso", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigo(ByVal sCodigo As String, _
                                 ByVal sCodigoAntigo As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCodigo = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = sCodigo : i += 1

            'Seta Parametros - Codigo Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 30
            oSqlParameter(i).Value = sCodigoAntigo

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_static_menu_suspenso", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCodigo = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
