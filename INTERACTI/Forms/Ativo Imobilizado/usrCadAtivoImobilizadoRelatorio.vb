Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports Janus.Windows.UI.Tab
Imports Janus.Windows.CalendarCombo
Imports System.IO
Imports System.Math

Public Class usrCadAtivoImobilizadoRelatorio

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oclsUsrCadAtivoImobilizadoRelatorio As New clsUsrCadAtivoImobilizadoRelatorio
    Private iFormulario As Integer

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

    Private Sub usr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            frmMain.errInfo.Clear()

            'Carrega Dados da Grid
            LoadGrid()

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
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

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

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

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

    Private Sub btnConfigurarGridDados_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridDados.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            ConfigureMaskEdit(oForm) : LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGridDados_Click(sender As Object, e As EventArgs) Handles btnAgruparGridDados.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelDados_Click(sender As Object, e As EventArgs) Handles btnExcelDados.Click

        Try

            ExportExcel(grdListagem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            dtpDataFiltro.Value = Today.Date

            LoadCombo(cboAtivoImobilizadoFiltro, "sp_select_combo_cadastro_basico_ativo_imobilizado " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboAtivoImobilizadoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oclsUsrCadAtivoImobilizadoRelatorio.LoadGrid(grdListagem, _
                                                         IIf(cboAtivoImobilizadoFiltro.SelectedIndex = -1, -1, cboAtivoImobilizadoFiltro.SelectedValue), _
                                                         dtpDataFiltro.Value)

            ConfiguraGrid(grdListagem, iFormulario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


