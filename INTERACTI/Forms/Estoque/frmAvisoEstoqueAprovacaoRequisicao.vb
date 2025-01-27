Imports System.Reflection
Imports System.Threading
Imports System.Reflection.Assembly
Public Class frmAvisoEstoqueAprovacaoRequisicao

#Region "::: VARIAVEIS :::"

    Private oClsFrmAvisoEstoqueAprovacaoRequisicao As New clsAvisoEstoqueAprovacaoRequisicao
    Private iFormulario As Integer = -1

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConfigurarUserControl()

    End Sub

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.Name,
                                    iFormulario,
                                    e.Column.Key,
                                    e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.ToString)
        End Try

    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

            LoadGrid()
            tmrAviso.Interval = 50

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: AVISOS :::"

    Private Sub LoadGrid()

        Try

            oClsFrmAvisoEstoqueAprovacaoRequisicao.LoadGrid(grdListagem)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#End Region

End Class