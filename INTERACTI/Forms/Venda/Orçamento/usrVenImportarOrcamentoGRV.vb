Imports Janus.Windows.GridEX

Public Class usrVenImportarOrcamentoGRV

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                   
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try


            'Limpa Erro
            frmMain.errInfo.Clear()

            If ValidaCampo(cboRevisao, lblRevisao) = False Then Exit Sub


            If MsgBox("Deseja importar o orçamento do GRV para o interacti?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Importação") = vbNo Then Exit Sub


            ExecuteQuery("sp_grv_import_orcamento " & cboRevisao.SelectedValue)

            frmMain.Informacao("Orçamento importado com sucesso!", Color.Blue)

            txtNumeroOrcamento.Text = ""
            cboRevisao.SelectedIndex = -1

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            lblStatusINTERACTI.Text = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub txtNumeroOrcamento_LostFocus(sender As Object, e As EventArgs) Handles txtNumeroOrcamento.LostFocus
        Try

            If IsNumeric(txtNumeroOrcamento.Text) Then

                Call LoadCombo(cboRevisao, "sp_grv_combo_revisao_orcamento " & txtNumeroOrcamento.Text)

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboRevisao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRevisao.SelectedIndexChanged
        Try

            If cboRevisao.SelectedIndex = -1 Then
                lblStatusINTERACTI.Text = ""
                txtValorGRV.Value = 0
                Exit Sub
            End If

            oClsUsrVenOrcamentoLegado.LoadDadosGRV(cboRevisao.SelectedValue, _
                                                   lblStatusINTERACTI, _
                                                   txtValorGRV)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

  
End Class
