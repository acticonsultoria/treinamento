Imports INTERACTI.SQLHelper
Imports System.Data.SqlClient
Imports System.Text
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System.Drawing.Imaging
Imports System.IO
Imports Janus.Windows.GridEX

Public Class clsUsrAdmMenuPerfil

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
                    Dim oMenuPai As ToolStripMenuItem
                    oMenuPai = oMenuStrip.Items.Find(oSqlDataReader.Item("codigo_menu_pai"), True)(0)
                    oMenuPai.DropDownItems.Add(oMenuItem)
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

    Public Sub Insert(ByVal oGrid As GridEX, _
                      ByVal sFormulario As String)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_perfil"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_perfil").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "formulario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sFormulario : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "s"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("s").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "i"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("i").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "u"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("u").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "d"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("d").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "p"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("p").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "a"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("a").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_administracao_menu_perfil", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sFormulario As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "formulario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFormulario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_menu_perfil", oSqlParameter)

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

End Class
