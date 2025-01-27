Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadUnidadeMedida

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadUnidadeMedida As New clsUsrCadUnidadeMedida
    Dim iFormulario As Integer = -1

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadUnidadeMedida_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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
            If Validacao() = False Then Exit Sub

            'Salva Dados do Registro
            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

            'Seta Focu
            txtSiglaFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key
                Case "editar" : Call Editar()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     iFormulario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            txtSiglaFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem Direito de Alterar o Registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    txtSigla.Text = .Item("sigla").Value
                    txtDescricao.Text = .Item("descricao").Value
                    txtSiglaOutroIdioma.Text = .Item("sigla_outro_idioma").Value
                    txtDescricaoOutroIdioma.Text = .Item("descricao_outro_idioma").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    cboComercial.SelectedValue = IIf(.Item("comercial").Value = "NÃO", False, True)
                    btnSalvar.Tag = .Item("codigo").Value

                End With

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtSigla.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadUnidadeMedida.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
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
            txtSigla.Text = ""
            txtDescricao.Text = ""
            cboAtivo.SelectedValue = True
            txtSiglaOutroIdioma.Text = ""
            txtDescricaoOutroIdioma.Text = ""
            cboComercial.SelectedValue = True
            btnSalvar.Tag = ""

            txtSigla.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadUnidadeMedida.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadUnidadeMedida.Sigla = txtSigla.Text.Trim
            oClsCadUnidadeMedida.Descricao = txtDescricao.Text.Trim
            oClsCadUnidadeMedida.SiglaOutroIdioma = txtSiglaOutroIdioma.Text.Trim
            oClsCadUnidadeMedida.DescricaoOutroIdioma = txtDescricaoOutroIdioma.Text.Trim
            oClsCadUnidadeMedida.Ativo = cboAtivo.SelectedValue
            oClsCadUnidadeMedida.Comercial = cboComercial.SelectedValue

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsCadUnidadeMedida.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadUnidadeMedida.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
                btnSalvar.Tag = oClsCadUnidadeMedida.Codigo
            End If

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
            oClsCadUnidadeMedida.LoadGrid(grdListagem, _
                                          txtSiglaFiltro.Text.Trim, _
                                          txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Preenchido o Campo - Sigla
            If ValidaCampo(txtSigla, lblSigla, TipoCampo.texto) = False Then Return False

            'Verifica se a Sigla preenchida é válida
            If oClsCadUnidadeMedida.ValidaSigla(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                txtSigla.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblSigla, "Esta Sigla: " & txtSigla.Text & " já está associado a outro Registro.")
                txtSigla.Focus()
                Return False
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then Return False

            If ValidaCampo(cboComercial, lblComercial) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
