Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls

Public Class frmFindNCMTIPI

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadNCM As New clsUsrCadNCM

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmFindNCMTIPI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    Select Case sender.Name

                        Case "trvMain"
                            If IsNothing(trvMain.SelectedNode) = False AndAlso trvMain.SelectedNode.Tag.ToString.Length = 8 Then
                                if isNothing(oMaskedEditBoxFind) = false then oMaskedEditBoxFind.Text = trvMain.SelectedNode.Text
                                if isNothing(oEditBoxFind) = false then oEditBoxFind.Text = trvMain.SelectedNode.Text
                                if isNothing(oComboBoxFind) = false then oComboBoxFind.SelectedValue = trvMain.SelectedNode.Tag                                
                                Me.Dispose()
                            End If

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

    Private Sub frmFindNCMTIPI_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulario
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: NCM :::"

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCapitulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCapitulo.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Registro
            If cboCapitulo.SelectedIndex = -1 Then

                'Limpa Controles
                cboPosicao.DataSource = Nothing : cboPosicao.Text = ""
                cboSubposicao1.DataSource = Nothing : cboSubposicao1.Text = ""
                cboSubposicao2.DataSource = Nothing : cboSubposicao2.Text = ""
                cboItem.DataSource = Nothing : cboItem.Text = ""

            Else

                'Carrega Combo
                Call LoadCombo(cboPosicao, "sp_select_combo_static_ncm 2, '" & cboCapitulo.SelectedValue & "'", False)

            End If

            'Carrega TreeView
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboPosicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPosicao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Registro
            If cboPosicao.SelectedIndex = -1 Then

                'Limpa Controles
                cboSubposicao1.DataSource = Nothing : cboSubposicao1.Text = ""
                cboSubposicao2.DataSource = Nothing : cboSubposicao2.Text = ""
                cboItem.DataSource = Nothing : cboItem.Text = ""

            Else
                
                'Carrega Combo
                Call LoadCombo(cboSubposicao1, "sp_select_combo_static_ncm 3, '" & cboPosicao.SelectedValue & "'", False)

            End If

            'Carrega TreeView
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboSubposicao1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubposicao1.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Registro
            If cboSubposicao1.SelectedIndex = -1 Then

                'Limpa Controles
                cboSubposicao2.DataSource = Nothing : cboSubposicao2.Text = ""
                cboItem.DataSource = Nothing : cboItem.Text = ""

            Else
                
                'Carrega Combo
                Call LoadCombo(cboSubposicao2, "sp_select_combo_static_ncm 4, '" & cboSubposicao1.SelectedValue & "'", False)

            End If

            'Carrega TreeView
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboSubposicao2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubposicao2.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Registro
            If cboSubposicao2.SelectedIndex = -1 Then

                'Limpa Controles
                cboItem.DataSource = Nothing : cboItem.Text = ""

            Else

                'Carrega Combo
                Call LoadCombo(cboItem, "sp_select_combo_static_ncm 5, '" & cboSubposicao2.SelectedValue & "'", False)

            End If

            'Carrega TreeView
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged

        Try

            'Carrega TreeView
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub trvMain_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs)

        Try

            'Carrega Controles
            if isNothing(oMaskedEditBoxFind) = false then oMaskedEditBoxFind.Text = trvMain.SelectedNode.Text
            if isNothing(oEditBoxFind) = false then oEditBoxFind.Text = trvMain.SelectedNode.Text
            if isNothing(oComboBoxFind) = false then oComboBoxFind.SelectedValue = trvMain.SelectedNode.Tag

            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindNCMTIPI_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboCapitulo, "sp_select_combo_static_ncm 1", False)

            'Carrega TreeView
            Call LoadTreeView()

            'Seta Focu
            cboCapitulo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: NCM :::"

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Limpa Controles
            trvMain.Visible = False

            'Seta Parametros
            Call oClsCadNCM.LoadTreeView(trvMain, _
                                         IIf(cboCapitulo.SelectedIndex = -1, "", cboCapitulo.SelectedValue), _
                                         IIf(cboPosicao.SelectedIndex = -1, "", cboPosicao.SelectedValue), _
                                         IIf(cboSubposicao1.SelectedIndex = -1, "", cboSubposicao1.SelectedValue), _
                                         IIf(cboSubposicao2.SelectedIndex = -1, "", cboSubposicao2.SelectedValue), _
                                         IIf(cboItem.SelectedIndex = -1, "", cboItem.SelectedValue))

            'Limpa Controles
            trvMain.Visible = True

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
