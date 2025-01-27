Imports Janus.Windows.GridEX

Public Class frmCadOperacaoTaxaHora

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrCadOperacao As New clsUsrCadOperacao
   
#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOperacao_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOperacao.CellUpdated
        Try
            AlterarTaxaHora()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    'Private Sub grdOperacao_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdOperacao.CellValueChanged

    'End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOperacao.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                Formulario.CadastroBasicoOperacao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOperacao.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.name, _
                                Formulario.CadastroBasicoOperacao, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOperacao.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     Formulario.CadastroBasicoOperacao, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Try

            ExportExcel(grdOperacao)

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

            'Atualiza Grid
            ConfiguraGrid(grdOperacao, Formulario.CadastroBasicoOperacao)

            oClsUsrCadOperacao.LoadGridTaxaHora(grdOperacao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub AlterarTaxaHora()
        Try

            'Atualiza 
            oClsUsrCadOperacao.UpdateTaxaHora(grdOperacao.CurrentRow)

            'Informa o usuário
            frmMain.Informacao("Taxa Hora comercial atualizada com sucesso!", Color.Blue)


            If MsgBox("Deseja atualizar a listagem?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atualização") = vbYes Then
                oClsUsrCadOperacao.LoadGridTaxaHora(grdOperacao)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class