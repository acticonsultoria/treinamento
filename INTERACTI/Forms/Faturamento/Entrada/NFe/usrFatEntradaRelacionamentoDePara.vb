Imports Microsoft.Office.Interop
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO.File
Imports INTERACTI.SQLHelper

Public Class usrFatEntradaRelacionamentoDePara

#Region "::: VARIAVEIS :::"

    Private oClsUsrFatEntradaRelacionamentoDePara As New clsUsrFatEntradaRelacionamentoDePara
    Private iFormulario As Integer

#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    'Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    '    Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + gcUserControlAjust)
    '    Me.Left = ((frmMain.tabMain.Width - Me.Width) / 2)

    'End Sub

    Private Sub usr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try

            grdListagem.DataSource = Nothing

            LoadGrid()

            ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Try

            ExportExcel(grdListagem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrFatEntradaRelacionamentoDePara.LoadGrid(grdListagem, _
                                                           IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                                           IIf(dtpDataFinalFiltro.Checked = True, dtpDataFinalFiltro.Value, ""))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            grdListagem.DataSource = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class