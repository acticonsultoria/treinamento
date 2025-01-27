Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrEstInsumo

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrEstInsumo As New clsUsrEstInsumo
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

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

            Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            cboCodigoProduto.Focus()

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

            LoadGrid()

            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, _
                                                                                                                       grdPagamento.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, _
                                                                                                                        grdPagamento.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging, _
                                                                                           grdPagamento.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        Try

            frmMain.errInfo.Clear()

            If ValidacaoPagar() = False Then Exit Sub

            Pagar()
            NovoProduto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirMovimentacao_Click(sender As Object, e As EventArgs) Handles btnExcluirMovimentacao.Click

        Try

            ExcluirMovimentacao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdPagamento_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdPagamento.RowDoubleClick

        Try

            'Verifica se a Linha pressionada é Válida
            If IsNothing(grdPagamento.CurrentColumn) Then Exit Sub

            Select Case grdPagamento.CurrentColumn.Key

                Case "editar" : EditarPagamento()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            txtDescricao.Text = ""
            txtSaldo.Value = 0
            grdPagamento.DataSource = Nothing

            If cboCodigoProduto.SelectedIndex = -1 Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            txtDescricao.Text = LoadCodigo("sp_load_cadastro_basico_item_descricao " & cboCodigoProduto.SelectedValue & "," & goUsuario.iEmpresa)
            AtualizaSaldo()
            LoadGridPagamento()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGridPagamento_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridPagamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPagamento
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdPagamento, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGridPagamento_Click(sender As Object, e As EventArgs) Handles btnAgruparGridPagamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPagamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPagamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPagamento.GroupByBoxVisible = True
                grdPagamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExportarGridPagamento_Click(sender As Object, e As EventArgs) Handles btnExportarGridPagamento.Click

        Try

            ExportExcel(grdPagamento)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboTipoMovimentacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimentacao.SelectedIndexChanged

        Try

            cboFuncionario.SelectedIndex = -1
            cboFuncionario.Enabled = False

            If cboTipoMovimentacao.SelectedIndex = -1 Then Exit Sub

            If cboTipoMovimentacao.SelectedValue = "E" Then
                cboFuncionario.Enabled = False
            Else
                cboFuncionario.Enabled = True
            End If

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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control " & Me.Name)

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_produto_insumo " & goUsuario.iEmpresa, False)
            LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_estoque_insumo", False)

            cboTipoMovimentacao.Items.Clear()
            cboTipoMovimentacao.Items.Add("ENTRADA", "E")
            cboTipoMovimentacao.Items.Add("SAÍDA", "S")

            'Verifica Direito
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnPagar.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirMovimentacao.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(iFormulario, gcPrint)

            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdPagamento, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            txtDescricaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Novo()

                cboCodigoProduto.SelectedValue = grdListagem.GetValue("codigo_item")

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

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

            frmMain.errInfo.Clear()

            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpPagamento)
            grdPagamento.DataSource = Nothing
            btnPagar.Tag = ""

            cboCodigoProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoProduto()

        Try

            LimparCamposGroupBox(grpPagamento)
            btnPagar.Tag = ""
            cboTipoMovimentacao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrEstInsumo.LoadGrid(grdListagem, _
                                      txtDescricaoFiltro.Text.Trim, _
                                      IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPagar() As Boolean

        Try

            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then Return False
            If ValidaCampo(cboTipoMovimentacao, lblTipoMovimentacao) = False Then Return False
            If ValidaCampo(txtQuantidade, lblQuantidade, TipoCampo.numero) = False Then Return False

            If cboTipoMovimentacao.SelectedValue = "S" Then
                If ValidaCampo(cboFuncionario, lblFuncionario) = False Then Return False

                If txtQuantidade.Value > txtSaldo.Value Then
                    If MsgBox("Você está pagando uma quantidade maior do que existe de saldo. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.No Then Return False
                End If

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Pagar()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnPagar.Tag) Then

                oClsUsrEstInsumo.UpdatePagamento(btnPagar.Tag, _
                                                 cboTipoMovimentacao.SelectedValue, _
                                                 IIf(cboFuncionario.SelectedIndex = -1, -1, cboFuncionario.SelectedValue), _
                                                 txtQuantidade.Value, _
                                                 dtpDataPagamento.Value)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrEstInsumo.InsertPagamento(cboCodigoProduto.SelectedValue, _
                                                 cboTipoMovimentacao.SelectedValue, _
                                                 IIf(cboFuncionario.SelectedIndex = -1, -1, cboFuncionario.SelectedValue), _
                                                 txtQuantidade.Value, _
                                                 dtpDataPagamento.Value)

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            AtualizaSaldo()
            LoadGridPagamento()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPagamento()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrEstInsumo.LoadGridPagamento(grdPagamento, _
                                               cboCodigoProduto.SelectedValue)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirMovimentacao()

        Try

            If VerificaSelecaoRow(grdPagamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrEstInsumo.DeletePagamento()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    AtualizaSaldo()

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

    Private Sub EditarPagamento()

        Try

            Cursor.Current = Cursors.WaitCursor

            cboTipoMovimentacao.SelectedValue = grdPagamento.GetValue("tipo")

            If IsDBNull(grdPagamento.GetValue("codigo_funcionario")) Then
                cboFuncionario.SelectedIndex = -1
            Else
                cboFuncionario.SelectedValue = grdPagamento.GetValue("codigo_funcionario")
            End If

            txtQuantidade.Value = grdPagamento.GetValue("quantidade")
            dtpDataPagamento.Value = grdPagamento.GetValue("data_pagamento")
            btnPagar.Tag = grdPagamento.GetValue("codigo")

            cboTipoMovimentacao.Focus()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaSaldo()

        Try

            txtSaldo.Value = LoadCodigo("sp_select_estoque_insumo_saldo " & cboCodigoProduto.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

End Class
