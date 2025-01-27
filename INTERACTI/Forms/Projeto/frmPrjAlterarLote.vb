Imports Janus.Windows.GridEX

Public Class frmPrjAlterarLote

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsUsrPrjProcesso As New clsUsrPrjProcesso

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Call Salvar()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub dtpDataExecucao_CheckedChanged(sender As Object, e As EventArgs) Handles dtpDataExecucao.CheckedChanged
        Try
            If dtpDataExecucao.Checked = True Then
                chkDataExecucao.Checked = True
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub dtpDataprevisao_CheckedChanged(sender As Object, e As EventArgs) Handles dtpDataPrevisao.CheckedChanged
        Try
            If dtpDataPrevisao.Checked = True Then
                chkDataPrevisao.Checked = True
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub dtpDataresposta_CheckedChanged(sender As Object, e As EventArgs) Handles dtpDataResposta.CheckedChanged
        Try
            If dtpDataResposta.Checked = True Then
                chkDataResposta.Checked = True
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            dtpDataExecucao.Value = Now : dtpDataExecucao.Checked = False
            dtpDataPrevisao.Value = Now : dtpDataPrevisao.Checked = False
            dtpDataResposta.Value = Now : dtpDataResposta.Checked = False

            chkObservacao.Checked = False


            Call LoadCombo(cboEtapa, "sp_select_combo_static_projeto_etapa")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()
        Try

            If MsgBox("Deseja atualizar as datas da etapa dos registros selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.No Then Exit Sub

            For Each oRow In oGrid.GetCheckedRows

                oClsUsrPrjProcesso.AtualizaDataEtapaLote(oRow.Cells.Item("codigo_projeto").Value, _
                                                         cboEtapa.SelectedValue, _
                                                         chkDataExecucao.Checked, _
                                                         IIf(dtpDataExecucao.Checked = True, dtpDataExecucao.Value, ""), _
                                                         chkDataPrevisao.Checked, _
                                                         IIf(dtpDataPrevisao.Checked = True, dtpDataPrevisao.Value, ""), _
                                                         chkDataResposta.Checked, _
                                                         IIf(dtpDataResposta.Checked = True, dtpDataResposta.Value, ""), _
                                                         chkObservacao.Checked, _
                                                         txtObservacao.Text.Trim)

            Next

            'Informa o usuário
            frmMain.Informacao("Datas atualizada com sucesso!", Color.Blue)

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

 
End Class