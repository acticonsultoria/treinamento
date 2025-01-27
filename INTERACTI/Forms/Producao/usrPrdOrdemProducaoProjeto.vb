Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrPrdOrdemProducaoProjeto

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdOrdemProducaoProjeto As New clsUsrPrdOrdemProducaoProjeto

    Private iFormulario As Integer = Formulario.ProducaoOrdemProducaoProjeto
#End Region

#Region "::: CONTROLES :::"


    Private Sub btnInserirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirItem.Click
        Try
            InsertItem()
            NovoItem()
            LoadGridItem()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirItem.Click
        Try
            DeleteItem()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdItem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRequisicao.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdRequisicao.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdRequisicao.CurrentColumn.Key

                Case "editar" : Call EditarItem()


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub usrCadArea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrCadArea_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadArea_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoArea
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoArea)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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
            Call NovoItem()

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
            Call NovoItem()

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
            txtOrdemProducaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
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
                                     Formulario.CadastroBasicoArea)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoArea, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"
    Private Sub EditarItem()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Carrega Controles
                cboProdutoIntermediario.SelectedValue = grdRequisicao.CurrentRow.Cells("codigo_item").Value
                txtQuantidadeProdutoIntermediario.Value = grdRequisicao.CurrentRow.Cells("quantidade").Value
                dtpDataSaida.Value = grdRequisicao.CurrentRow.Cells.Item("data_saida").Value
                btnInserirItem.Tag = grdRequisicao.CurrentRow.Cells("codigo_requisicao_item").Value
                If Not IsDBNull(grdRequisicao.CurrentRow.Cells.Item("lote").Value) Then
                    cboLote.SelectedValue = grdRequisicao.CurrentRow.Cells("lote").Value
                End If


            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadArea_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(iFormulario, gcPrint)

            dtpData.Value = Now
            dtpDataSaida.Value = Now
            dtpDataInicioFiltro.Value = Now : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now : dtpDataTerminoFiltro.Checked = False

            'Carrega os dados
            Call LoadCombo(cboProdutoAcabado, "sp_select_combo_cadastro_basico_item_estoque " & goUsuario.iEmpresa)
            Call LoadCombo(cboProdutoIntermediario, "sp_select_combo_cadastro_basico_item_estoque " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

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

                With grdListagem.CurrentRow.Cells

                    btnSalvar.Tag = .Item("codigo_ordem_producao").Value
                    txtOrdemProducao.Text = .Item("ordem_producao").Value
                    cboProdutoAcabado.SelectedValue = .Item("codigo_item").Value
                    txtQuantidadeProdutoAcabado.Value = .Item("quantidade").Value
                    dtpData.Value = .Item("data").Value

                End With
                LoadGridItem()
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtOrdemProducao.Focus()

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsPrdOrdemProducaoProjeto.Delete()

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

    Private Sub DeleteItem()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdRequisicao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsPrdOrdemProducaoProjeto.DeleteItem(btnSalvar.Tag)

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
            txtOrdemProducao.Text = ""
            txtNumeroRequisicao.Text = ""
            dtpData.Value = Now.Date
            cboProdutoAcabado.SelectedIndex = -1
            txtQuantidadeProdutoAcabado.Value = 0

            'Seta Focu
            cboProdutoAcabado.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoItem()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()
            oClsPrdOrdemProducaoProjeto.LoadGridItem(grdRequisicao, 0)


            cboProdutoIntermediario.SelectedIndex = -1
            txtQuantidadeProdutoIntermediario.Value = 0
            cboLote.Text = ""
            cboLote.SelectedIndex = -1
            btnInserirItem.Tag = ""
            dtpDataSaida.Value = Now


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim lCodigo As Long = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)

            'Insere ou atualiza a ordem de produção
            oClsPrdOrdemProducaoProjeto.Salvar(lCodigo, dtpData.Value, cboProdutoAcabado.SelectedValue, txtQuantidadeProdutoAcabado.Value)

            If btnSalvar.Tag = 0 Then
                btnSalvar.Tag = lCodigo
            End If

            'Informa ao usuário
            frmMain.Informacao(Mensagem.RegistroInserido)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertItem()

        Try
            frmMain.errInfo.Clear()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If Validacao() = False Then Exit Sub

            If ValidaCampo(cboProdutoIntermediario, lblProdutoIntermediario) = False Then Exit Sub
            If ValidaCampo(txtQuantidadeProdutoIntermediario, lblQuantidadeProdutoIntermediario, True) = False Then Exit Sub

            'Salvar a OP antes
            Call Salvar()

            If CStr(btnInserirItem.Tag) = "" Then
                oClsPrdOrdemProducaoProjeto.InsertItem(btnSalvar.Tag, _
                                                       cboProdutoIntermediario.SelectedValue, _
                                                       txtQuantidadeProdutoIntermediario.Value, _
                                                       cboLote.Text, _
                                                       dtpDataSaida.Value)
            Else
                oClsPrdOrdemProducaoProjeto.UpdateItem(btnSalvar.Tag, _
                                                       btnInserirItem.Tag, _
                                                       cboProdutoIntermediario.SelectedValue, _
                                                       txtQuantidadeProdutoIntermediario.Value, _
                                                       cboLote.Text, _
                                                       dtpDataSaida.Value)
            End If

            frmMain.Informacao(Mensagem.RegistroInserido)


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
            oClsPrdOrdemProducaoProjeto.LoadGrid(grdListagem, _
                                 txtOrdemProducaoFiltro.Text, txtProdutoAcabadoFiltro.Text, _
                                 txtProdutoAcabadoFiltro.Text, _
                                 txtProdutoIntermediarioFiltro.Text, _
                                 IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                 IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridItem()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsPrdOrdemProducaoProjeto.LoadGridItem(grdRequisicao, _
                                 btnSalvar.Tag)

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




            If ValidaCampo(cboProdutoAcabado, lblProdutoAcabado) = False Then
                Exit Function
            End If



            If ValidaCampo(txtQuantidadeProdutoAcabado, lblQuantidadeProdutoAcabado, True) = False Then
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
