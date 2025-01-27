Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadTipoPerfil

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadTipoPerfil As New clsUsrCadTipoPerfil
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            ExportExcel(grdListagem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub

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
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(iFormulario, gcPrint)

            LoadCombo(cboTipoCalculo, "sp_select_combo_static_tipo_calculo_peso_teorico", False)

            cboQuantidadeMedidas.Items.Add(1, 1)
            cboQuantidadeMedidas.Items.Add(2, 2)
            cboQuantidadeMedidas.Items.Add(3, 3)
            cboQuantidadeMedidas.Items.Add(4, 4)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            txtDescricaoFiltro.Focus()

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
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Novo()

                btnSalvar.Tag = grdListagem.GetValue("codigo")

                oClsUsrCadTipoPerfil.LoadDados(btnSalvar.Tag, _
                                               txtDescricao, _
                                               cboTipoCalculo, _
                                               cboAtivo, _
                                               cboQuantidadeMedidas, _
                                               txtDescricaoMedida1, _
                                               txtDescricaoMedida2, _
                                               txtDescricaoMedida3, _
                                               txtDescricaoMedida4)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                txtDescricao.Focus()

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

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrCadTipoPerfil.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
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

            LimparCamposGroupBox(grpDados)
            cboAtivo.SelectedValue = True

            btnSalvar.Tag = ""

            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadTipoPerfil.Update(btnSalvar.Tag, _
                                            txtDescricao.Text.Trim, _
                                            cboTipoCalculo.SelectedValue, _
                                            cboAtivo.SelectedValue, _
                                            cboQuantidadeMedidas.SelectedValue, _
                                            txtDescricaoMedida1.Text.Trim, _
                                            txtDescricaoMedida2.Text.Trim, _
                                            txtDescricaoMedida3.Text.Trim, _
                                            txtDescricaoMedida4.Text.Trim)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadTipoPerfil.Insert(txtDescricao.Text.Trim, _
                                            cboTipoCalculo.SelectedValue, _
                                            cboAtivo.SelectedValue, _
                                            cboQuantidadeMedidas.SelectedValue, _
                                            txtDescricaoMedida1.Text.Trim, _
                                            txtDescricaoMedida2.Text.Trim, _
                                            txtDescricaoMedida3.Text.Trim, _
                                            txtDescricaoMedida4.Text.Trim)

                frmMain.Informacao(Mensagem.RegistroInserido)
                btnSalvar.Tag = oClsUsrCadTipoPerfil.Codigo
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
            oClsUsrCadTipoPerfil.LoadGrid(grdListagem, _
                                          txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False

            'Passa Parametros
            If oClsUsrCadTipoPerfil.ValidaDescricao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                   txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição: " & txtDescricao.Text & " já está associado a outro Registro.")
                txtDescricao.Focus()
                Return False
            End If

            'COMENTADO  pq vai ter casos que não vai ter peso calculado (Solicitação Renato - CHAMADO 6323)
            'If ValidaCampo(cboTipoCalculo, lblTipoCalculo) = False Then Return False

            If ValidaCampo(cboAtivo, lblAtivo) = False Then Return False
            If ValidaCampo(cboQuantidadeMedidas, lblQuantidadeMedidas) = False Then Return False

            If txtDescricaoMedida1.Visible = True Then
                If ValidaCampo(txtDescricaoMedida1, lblDescricaoMedida1, TipoCampo.texto) = False Then Return False
            End If

            If txtDescricaoMedida2.Visible = True Then
                If ValidaCampo(txtDescricaoMedida2, lblDescricaoMedida2, TipoCampo.texto) = False Then Return False
            End If

            If txtDescricaoMedida3.Visible = True Then
                If ValidaCampo(txtDescricaoMedida3, lblDescricaoMedida3, TipoCampo.texto) = False Then Return False
            End If

            If txtDescricaoMedida4.Visible = True Then
                If ValidaCampo(txtDescricaoMedida4, lblDescricaoMedida4, TipoCampo.texto) = False Then Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Sub cboTipoCalculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCalculo.SelectedIndexChanged

        Try

            txtFormula.Text = ""

            If cboTipoCalculo.SelectedIndex = -1 Then Exit Sub

            txtFormula.Text = LoadCodigo("sp_load_tipo_calculo_peso " & cboTipoCalculo.SelectedValue)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboQuantidadeMedidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQuantidadeMedidas.SelectedIndexChanged

        Try

            txtDescricaoMedida1.Visible = False : txtDescricaoMedida1.Text = ""
            lblDescricaoMedida1.Visible = False
            txtDescricaoMedida2.Visible = False : txtDescricaoMedida2.Text = ""
            lblDescricaoMedida2.Visible = False
            txtDescricaoMedida3.Visible = False : txtDescricaoMedida3.Text = ""
            lblDescricaoMedida3.Visible = False
            txtDescricaoMedida4.Visible = False : txtDescricaoMedida4.Text = ""
            lblDescricaoMedida4.Visible = False

            If cboQuantidadeMedidas.SelectedIndex = -1 Then Exit Sub

            Select Case cboQuantidadeMedidas.SelectedValue

                Case 1
                    txtDescricaoMedida1.Visible = True
                    lblDescricaoMedida1.Visible = True
                Case 2
                    txtDescricaoMedida1.Visible = True
                    lblDescricaoMedida1.Visible = True
                    txtDescricaoMedida2.Visible = True
                    lblDescricaoMedida2.Visible = True
                Case 3
                    txtDescricaoMedida1.Visible = True
                    lblDescricaoMedida1.Visible = True
                    txtDescricaoMedida2.Visible = True
                    lblDescricaoMedida2.Visible = True
                    txtDescricaoMedida3.Visible = True
                    lblDescricaoMedida3.Visible = True
                Case 4
                    txtDescricaoMedida1.Visible = True
                    lblDescricaoMedida1.Visible = True
                    txtDescricaoMedida2.Visible = True
                    lblDescricaoMedida2.Visible = True
                    txtDescricaoMedida3.Visible = True
                    lblDescricaoMedida3.Visible = True
                    txtDescricaoMedida4.Visible = True
                    lblDescricaoMedida4.Visible = True

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

End Class
