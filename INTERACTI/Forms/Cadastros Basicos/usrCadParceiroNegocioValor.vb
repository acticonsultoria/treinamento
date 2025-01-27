Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadParceiroNegocioValor

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadParceiroNegocioValor As New clsUsrCadParceiroNegocioValor

#End Region

#Region "::: CONTROLES :::"

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        Try
            Excluir()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usrCadAutotexto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadAutotexto_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub


    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

            End If

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo da Célula
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "duplicar" : Call Duplicar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub Duplicar()
        Try
            Call Editar()

            cboParceiroNegocio.SelectedIndex = -1
            cboParceiroNegocio.Enabled = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadAutotexto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadCombo(cboEmpresa, "sp_select_combo_cadastro_basico_empresa")
            Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoAutotexto, gcUpdate) = True Then

                'Carrega Controles
                cboParceiroNegocio.SelectedValue = grdListagem.CurrentRow.Cells("codigo").Value
                cboEmpresa.SelectedValue = grdListagem.CurrentRow.Cells("codigo_empresa").Value

                oClsUsrCadParceiroNegocioValor.LoadGridAtividade(grdAtividade, cboParceiroNegocio.SelectedValue, cboEmpresa.SelectedValue)
                oClsUsrCadParceiroNegocioValor.LoadGridDespesa(grdDespesa, cboParceiroNegocio.SelectedValue, cboEmpresa.SelectedValue)

                cboParceiroNegocio.Enabled = False
                cboEmpresa.Enabled = False

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboParceiroNegocio.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboParceiroNegocio.SelectedIndex = -1
            cboParceiroNegocio.Enabled = True
            cboEmpresa.Enabled = True
            oClsUsrCadParceiroNegocioValor.LoadGridAtividade(grdAtividade, -1, -1)
            oClsUsrCadParceiroNegocioValor.LoadGridDespesa(grdDespesa, -1, -1)

            'Seta Focu
            cboParceiroNegocio.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadParceiroNegocioValor.DeleteAtividade(cboParceiroNegocio.SelectedValue, cboEmpresa.SelectedValue)
            oClsUsrCadParceiroNegocioValor.DeleteDespesa(cboParceiroNegocio.SelectedValue, cboEmpresa.SelectedValue)
            oClsUsrCadParceiroNegocioValor.InsertAtividade(grdAtividade, cboParceiroNegocio.SelectedValue, cboEmpresa.SelectedValue)
            oClsUsrCadParceiroNegocioValor.InsertDespesa(grdDespesa, cboParceiroNegocio.SelectedValue, cboEmpresa.SelectedValue)

            cboParceiroNegocio.Enabled = False

            frmMain.Informacao("Registro alterado com sucesso!", Color.Blue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsUsrCadParceiroNegocioValor.LoadGrid(grdListagem, _
                                           txtParceiroNegocioFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Excluir()
        Try
            If MsgBox("Deseja excluir os registros selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir") = vbYes Then
                For Each oRow In grdListagem.GetCheckedRows
                    oClsUsrCadParceiroNegocioValor.DeleteAtividade(oRow.Cells.Item("codigo").Value, cboEmpresa.SelectedValue)
                    oClsUsrCadParceiroNegocioValor.DeleteDespesa(oRow.Cells.Item("codigo").Value, cboEmpresa.SelectedValue)
                Next
                frmMain.Informacao("Registros excluídos com sucesso!", Color.Blue)
                LoadGrid()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region




    Private Sub cboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresa.SelectedIndexChanged
        Try
            If cboEmpresa.SelectedIndex = -1 Then Exit Sub

            Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio_sga " & cboEmpresa.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
