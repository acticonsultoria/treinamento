Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls

Public Class frmFindCentroGasto

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadCentroGasto As New clsUsrCadCentroGasto
    Private lCodigoItem As Long = -1

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoItem() As Long
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFindCentroGasto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    Select Case sender.Name

                        Case "trvMain"
                            If IsNothing(trvMain.SelectedNode) = False Then
                                if isNothing(oMaskedEditBoxFind) = false then oMaskedEditBoxFind.Text = trvMain.SelectedNode.Text
                                if isNothing(oEditBoxFind) = false then oEditBoxFind.Text = trvMain.SelectedNode.Text
                                If isNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = trvMain.SelectedNode.Tag
                                Me.Dispose()
                            End If

                        Case "txtDescricaoFiltro" : Call btnFiltrar_Click(btnFiltrar, System.EventArgs.Empty)

                    End Select


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

    Private Sub frmFindCentroGasto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Carrega TreeView
            Call oClsCadCentroGasto.LoadTreeView(trvMain, _
                                                 txtDescricaoFiltro.Text.Trim)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub trvMain_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvMain.NodeMouseDoubleClick

        Try

            'Seta Controles
            If isNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text = e.Node.Text
            If isNothing(oEditBoxFind) = False Then oEditBoxFind.Text = e.Node.Text
            If isNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = e.Node.Tag

            Me.Dispose()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindCentroGasto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Carrega TreeView
            Call oClsCadCentroGasto.LoadTreeView(trvMain, _
                                                 txtDescricaoFiltro.Text.Trim, _
                                                 lCodigoItem)

            'Seta Focu
            trvMain.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
