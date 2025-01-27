Public Class usrCadBomba

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadBomba As New clsUsrCadBomba

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadBomba_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                    End Select

                Case Keys.F5
                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto))
                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadBomba_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadBomba_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoBomba
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBomba)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto))

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboCodigoProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

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
            Call TratamentoErro(ex.Message, Me.Text)
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
            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Carrega a Descrição do Produto caso o Código do Produto tenha sido Selecionado
            If cboCodigoProduto.SelectedIndex = -1 Then
                txtDescricao.Text = ""
            Else
                Call LoadDescricao(txtDescricaoProduto, "sp_select_cadastro_basico_descricao_item " & cboCodigoProduto.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
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
                                     Formulario.CadastroBasicoBomba)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoBomba, _
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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadBomba_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoBomba, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoBomba, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoBomba, gcInsert)
            btnExcel.Enabled = VerificaDireito(Formulario.CadastroBasicoBomba, gcPrint)
            'Verifica Direito - Cadastrar
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboTipoCombustivel, "sp_select_combo_static_tipo_combustivel")
            Call LoadCombo(cboTipoCombustivelFiltro, "sp_select_combo_static_tipo_combustivel")
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto))

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBomba)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
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
            If VerificaDireito(Formulario.CadastroBasicoBomba, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    Call oClsCadBomba.Editar(.Item("codigo").Value, _
                                             txtDescricao, _
                                             cboTipoCombustivel, _
                                             cboAtivo, _
                                             cboCodigoProduto)

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadBomba.Delete()

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

            'Limpa Controles
            txtDescricao.Text = ""
            cboTipoCombustivel.SelectedIndex = -1
            cboCodigoProduto.SelectedIndex = -1
            txtDescricaoProduto.Text = ""
            cboAtivo.SelectedValue = True
            btnSalvar.Tag = ""

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadBomba.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadBomba.Descricao = txtDescricao.Text
            oClsCadBomba.CodigoTipoCombustivel = cboTipoCombustivel.SelectedValue
            oClsCadBomba.CodigoItem = cboCodigoProduto.SelectedValue
            oClsCadBomba.Ativo = cboAtivo.SelectedValue

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsCadBomba.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadBomba.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
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
            oClsCadBomba.LoadGrid(grdListagem, _
                                  txtDescricaoFiltro.Text.Trim, _
                                  IIf(cboTipoCombustivelFiltro.SelectedIndex = -1, -1, cboTipoCombustivelFiltro.SelectedValue), _
                                  txtCodigoProdutoFiltro.Text.Trim, _
                                  txtProdutoFiltro.Text.Trim)

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

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Passa Parametros
            If oClsCadBomba.ValidaDescricao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                            txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Bomba: " & txtDescricao.Text & " já está associado a outro Registro.")
                txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tipo de Combustível
            If ValidaCampo(cboTipoCombustivel, lblTipoCombustivel) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código do Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
