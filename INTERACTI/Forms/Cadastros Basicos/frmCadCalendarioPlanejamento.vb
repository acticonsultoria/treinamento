Imports Janus.Windows.GridEX

Public Class frmCadCalendarioPlanejamento

#Region "::: VARIAVEIS :::"

    Private oClsFrmCadCalendarioPlanejamento As New clsFrmCadCalendarioPlanejamento

#End Region

#Region "::: CONTROLES :::"

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub frmCadCalendarioPlanejamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call ConfigurarFormulario()

    End Sub

    Private Sub ConfigurarFormulario()

        Try

            Cursor.Current = Cursors.WaitCursor
            Me.Icon = frmMain.Icon

            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            Call LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina -1," & goUsuario.iEmpresa)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            oClsFrmCadCalendarioPlanejamento.InsertPlanejamento(txtObservacao.Text.Trim, _
                                                                dtpData.Value, _
                                                                dtpTempo.Value.Hour, _
                                                                cboMaquina.SelectedValue
                                                                )

            Me.Dispose()

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

#End Region


End Class