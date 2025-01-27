Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX

Public Class frmFindTransportadora

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadTransportadora As New clsUsrCadTransportadora
    Private oMaskedEditBox As MaskedEditBox
    Private oComboBox As UIComboBox

#End Region

#Region "::: PROPERTIE :::"

    Public Property CNPJ() As MaskedEditBox
        Get
            Return oMaskedEditBox
        End Get
        Set(ByVal value As MaskedEditBox)
            oMaskedEditBox = value
        End Set
    End Property

    Public Property ComboBox() As UIComboBox
        Get
            Return oComboBox
        End Get
        Set(ByVal value As UIComboBox)
            oComboBox = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFindTransportadora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If Not grdFind.CurrentRow Is Nothing Then
                        if isNothing(oMaskedEditBoxFind) = false then oMaskedEditBoxFind.Text = grdFind.CurrentRow.Cells("cnpj").Value
                        if isNothing(oEditBoxFind) = false then oEditBoxFind.Text = grdFind.CurrentRow.Cells("cnpj").Value
                        if isNothing(oComboBoxFind) = false then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value
                        Me.Dispose()
                    End If

                Case Keys.Escape
                    'Deleta Aba
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFindTransportadora_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFind
            oForm.NomeFormulario = Formulario.CadastroBasicoTransportadora
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoTransportadora)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFind.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdFind.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdFind.GroupByBoxVisible = True
                grdFind.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFind.RowDoubleClick

        Try

            'Carrega Controles
            if isNothing(oMaskedEditBoxFind) = false then oMaskedEditBoxFind.Text = grdFind.CurrentRow.Cells("cnpj").Value
            if isNothing(oEditBoxFind) = false then oEditBoxFind.Text = grdFind.CurrentRow.Cells("cnpj").Value
            if isNothing(oComboBoxFind) = false then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value

            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFind.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind.Name, _
                                     Formulario.CadastroBasicoTransportadora, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFind.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind, _
                                     Formulario.CadastroBasicoTransportadora)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFind.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFind.Name, _
                                          Formulario.CadastroBasicoTransportadora, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindTransportadora_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoTransportadora)

            'Configura Grid
            Call oClsCadTransportadora.LoadGridFind(grdFind)

            'Seta Focu
            grdFind.Focus()
            grdFind.CurrentColumn = grdFind.RootTable.Columns.Item("razao_social")
            System.Windows.Forms.SendKeys.Send("{UP 1}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
