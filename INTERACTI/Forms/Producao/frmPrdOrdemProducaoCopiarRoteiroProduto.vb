Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoCopiarRoteiroProduto

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
    Private lCodigoOrdemProducao As Long
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoOrdemProducao() As Long
        Get
            Return lCodigoOrdemProducao
        End Get
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

    Public Property Formulario() As Integer
        Get
            Return iFormulario
        End Get
        Set(ByVal value As Integer)
            iFormulario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then LoadGrid() Else Control_Enter(sender)

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            ImportarRoteiro()

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRoteiroImportacao.ColumnMoved

        Try

            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(sender As Object, e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRoteiroImportacao.SizingColumn

        Try

            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As Janus.Windows.GridEX.GroupsChangingEventArgs) Handles grdRoteiroImportacao.GroupsChanging

        Try

            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGridRoteiro_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridRoteiro.Click

        Try

            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRoteiroImportacao
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdRoteiroImportacao, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGridRoteiro_Click(sender As Object, e As EventArgs) Handles btnAgruparGridRoteiro.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRoteiroImportacao.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdRoteiroImportacao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdRoteiroImportacao.GroupByBoxVisible = True
                grdRoteiroImportacao.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelGridRoteiro_Click(sender As Object, e As EventArgs) Handles btnExcelGridRoteiro.Click

        Try

            ExportExcel(grdRoteiroImportacao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            ConfiguraGrid(grdRoteiroImportacao, iFormulario)

            txtCodigoProdutoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ImportarRoteiro()

        Try

            If grdRoteiroImportacao.GetCheckedRows.Count <= 0 Then
                MsgBox("Selecione alguma linha.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            For Each oRow As GridEXRow In grdRoteiroImportacao.GetCheckedRows

                oClsUsrPrdProducaoManual.ImportarRoteiroProduto(lCodigoOrdemProducao, _
                                                                oRow.Cells("codigo_item").Value, _
                                                                oRow.Cells("sequencia").Value)

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridImportarRoteiroProduto(grdRoteiroImportacao, _
                                                                    lCodigoOrdemProducao, _
                                                                    txtCodigoProdutoFiltro.Text.Trim)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class