Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports System.IO
Imports System.Drawing.Imaging

Public Class clsUsrPrdVisaoPlanta

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadImagem(ByVal iCodigo As Integer, _
                          ByVal picFoto As PictureBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_planta_foto", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Foto
                    If IsDBNull(oSqlDataReader.Item("foto")) = False Then
                        Dim bytBLOBData(oSqlDataReader.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                        oSqlDataReader.GetBytes(0, 0, bytBLOBData, 0, bytBLOBData.Length)
                        Dim stmBLOBData As New MemoryStream(bytBLOBData)
                        picFoto.Image = Image.FromStream(stmBLOBData)
                    End If

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

    Public Sub LoadControles(ByVal picFoto As Control, _
                             ByVal oCommandManager As Janus.Windows.UI.CommandBars.UICommandManager, _
                             ByVal oContextMenu As Janus.Windows.UI.CommandBars.UIContextMenu, _
                             ByVal oJstMain As JanusSuperTip, _
                             ByVal iCodigoPlanta As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim oSuperTipSettings As New SuperTipSettings
        Dim i As Integer = 0
        Dim oButton As Button

        Try

            'Seta Parametros - Código Planta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_planta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoPlanta : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_planta_centro_trabalho", oSqlParameter)

            'Limpa Controles
            While picFoto.Controls.Count > 0
                For Each oControl As Control In picFoto.Controls
                    picFoto.Controls.Remove(oControl)
                    oControl.Dispose()
                Next
            End While

            'Carrega Controles
            While oSqlDataReader.Read

                'Carrega Controle
                oButton = New Button
                oButton.Size = New Size(20, 20)
                oButton.Name = oSqlDataReader.Item("codigo")
                oButton.Location = New Point(oSqlDataReader.Item("posicao_x"), oSqlDataReader.Item("posicao_y"))
                oCommandManager.SetContextMenu(oButton, oContextMenu)
                oSuperTipSettings.Text = oSqlDataReader.Item("descricao")
                oJstMain.SetSuperTip(oButton, oSuperTipSettings)
                oButton.FlatStyle = FlatStyle.Flat
                MakeDraggable2(oButton)
                'Adiciona Controle
                picFoto.Controls.Add(oButton)

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadInformacaoCentroTrabalho(ByVal bBotoeira As Button, _
                                            ByVal oTip As Janus.Windows.Common.JanusSuperTip)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Centro Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = bBotoeira.Name : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_planta_centro_trabalho_status", oSqlParameter)

            'Carrega Controles
            While oSqlDataReader.Read

                'Dim oSuperTipSettings As New SuperTipSettings

                'bBotoeira.BackColor = Color.FromName(oSqlDataReader.Item("cor"))
                'oSuperTipSettings.HeaderText = "MÁQUINA: " & oSqlDataReader.Item("descricao")
                'oSuperTipSettings.Text = "STATUS: " & oSqlDataReader.Item("status") & " desde: " & oSqlDataReader.Item("data")
                'oTip.SetSuperTip(bBotoeira, oSuperTipSettings)

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
