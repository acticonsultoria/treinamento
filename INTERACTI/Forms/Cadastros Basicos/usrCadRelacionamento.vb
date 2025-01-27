Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadRelacionamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadRelacionamento As New clsUsrCadRelacionamento

    Private oCurrentRow As GridEXRow

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadRelacionamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Controle Pai
            If ValidaCampo(cboControlePai, lblControlePai) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Controle Filho
            If ValidaCampo(cboControleFilho, lblControleFilho) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado Algum Registro - Pai
            If IsNothing(oCurrentRow) Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

            'Verifica se foi Selecionado algum Registro na Grid
            If VerificaSelecaoRow(grdFilho) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            'Exclui Registros
            Call oClsCadRelacionamento.Delete(cboControlePai.SelectedValue, _
                                              oCurrentRow.Cells("codigo").Value)

            'Insere Registros
            Call oClsCadRelacionamento.Insert(cboControlePai.SelectedValue, _
                                              cboControleFilho.SelectedValue, _
                                              oCurrentRow.Cells("codigo").Value)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

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

    Private Sub cboControlePai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboControlePai.SelectedIndexChanged

        Try

            'Limpa Váriavel
            oCurrentRow = Nothing

            'Verifica se foi Selecionado Algum Registro
            If cboControlePai.SelectedIndex = -1 Then
                'Limpa Grid
                grdPai.DataSource = Nothing
            Else
                'Carrega Grid
                Call oClsCadRelacionamento.LoadGrid(grdPai, cboControlePai.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboControleFilho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboControleFilho.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboControlePai.SelectedIndex = -1 Or cboControleFilho.SelectedIndex = -1 Or IsNothing(oCurrentRow) Then
                'Limpa Grid
                grdFilho.DataSource = Nothing
            Else
                'Carrega Grid
                Call oClsCadRelacionamento.LoadGrid(grdFilho,
                                                    cboControlePai.SelectedValue, _
                                                    cboControleFilho.SelectedValue, _
                                                    oCurrentRow.Cells("codigo").Value)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPai_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdPai.RowCheckStateChanged

        Try

            'Verifica se tem alguma Linha Selecionada
            If e.Row.CheckState = RowCheckState.Checked Then

                'Desmarca Linha Anterior
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriavel
                oCurrentRow = e.Row

                'Carrega Grid
                Call cboControleFilho_SelectedIndexChanged(cboControleFilho, System.EventArgs.Empty)

                'Habilita Controle
                cboControleFilho.Enabled = True

            Else
                'Limpa Váriavel
                oCurrentRow = Nothing
                'Limpa Controle
                cboControleFilho.Text = ""
                cboControleFilho.Enabled = False
                grdFilho.DataSource = Nothing
            End If

            'Atualiza Grid
            grdPai.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFilho_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdFilho.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdFilho.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoRelacionamento, gcDelete)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboControlePai : oComboBox(1) = cboControleFilho
            Call LoadCombo(oComboBox, "sp_select_combo_tabelas", False)

            'Configura Grid
            Call ConfiguraGrid(grdPai, Formulario.CadastroBasicoRelacionamento)
            Call ConfiguraGrid(grdFilho, Formulario.CadastroBasicoRelacionamento)

            'Desabilita Controle
            cboControleFilho.Enabled = False

            'Seta Focu
            cboControlePai.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
