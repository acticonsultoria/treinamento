Imports Janus.Windows.GridEX

Public Class usrFindPlanoContas
    
#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadPlanoContas As New clsUsrCadPlanoContas

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFindPlanoContas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    Select Case sender.Name

                        Case "trvMain"
                            If IsNothing(trvMain.SelectedNode) = False Then
                                If isNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text = trvMain.SelectedNode.Text
                                If isNothing(oEditBoxFind) = False Then oEditBoxFind.Text = trvMain.SelectedNode.Text
                                If isNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = trvMain.SelectedNode.Tag
                                'Fecha o Formulário
                                If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                            End If

                        Case "txtDescricaoFiltro" : Call btnFiltrar_Click(btnFiltrar, System.EventArgs.Empty)

                    End Select


                Case Keys.Escape
                    'Fecha o Formulário
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub frmFindPlanoContas_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Carrega TreeView
            Call oClsCadPlanoContas.LoadTreeView(trvMain, _
                                                 txtDescricaoFiltro.Text.Trim)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvMain.NodeMouseDoubleClick

        Try

            'Carrega Controles
            If isNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text = trvMain.SelectedNode.Text
            If isNothing(oEditBoxFind) = False Then oEditBoxFind.Text = trvMain.SelectedNode.Text
            If isNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = trvMain.SelectedNode.Tag

            'Fecha o Formulário
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindPlanoContas_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Carrega TreeView
            Call oClsCadPlanoContas.LoadTreeViewFind(trvMain, _
                                                     txtDescricaoFiltro.Text.Trim, _
                                                     lCodigoItemFind)

            'Seta Focu
            trvMain.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
