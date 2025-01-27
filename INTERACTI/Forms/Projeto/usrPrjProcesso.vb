Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrPrjProcesso

#Region "::: VÁRIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrjProcesso As New clsUsrPrjProcesso
    Private oCurrentRow As GridEXRow

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

    Private Sub usr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub grdEtapa_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdEtapa.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdEtapa.CurrentColumn) Then Exit Sub

            Select Case grdEtapa.CurrentColumn.Key

                Case "cancelar" : Call Cancelar()

            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "historico" : Call Historico(grdListagem)
                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)

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
                                     Formulario.ProjetoProcesso)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ProjetoProcesso, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.ProjetoProcesso, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = True Then

                Call Salvar()

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try        '

    End Sub

    Private Sub grdEtapa_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdEtapa.CellUpdated

        Try

            Select Case e.Column.Key


                Case "data_inicio", "data_termino", "data_resposta", "observacao", "data_previsao"


                    Call oClsUsrPrjProcesso.AtualizaDataEtapa(btnSalvar.Tag, _
                                                               grdEtapa.CurrentRow)

                    Call LoadGridEtapa()

            End Select

            Call LoadGridEtapa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try



    End Sub

    Private Sub grdEtapa_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEtapa.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEtapa, _
                                     Formulario.ProjetoProcesso)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEtapa_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEtapa.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEtapa.Name, _
                                     Formulario.ProjetoProcesso, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            Call Novo()
            Call NovoProjeto()
            Call LoadGridEtapa()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(sender As Object, e As EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()
            Call NovoProjeto()
            Call LoadGridEtapa()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Foco
            cboOrdemProducao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try

            Call Delete(grdListagem)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridDados_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridDados.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ProjetoProcesso
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProjetoProcesso)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridDados_Click(sender As Object, e As EventArgs) Handles btnAgruparGridDados.Click

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelDados_Click(sender As Object, e As EventArgs) Handles btnExcelDados.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            Cursor.Current = Cursors.WaitCursor

            Select Case e.Column.Key

                Case "data_encerramento"

                    'Call oClsUsrPrjProcesso.AtualizaDataEncerramento(grdListagem.CurrentRow.Cells("codigo").Value, _
                    '                                                 IIf(IsDBNull(grdListagem.CurrentRow.Cells("data_encerramento").Value) = True, "", grdListagem.CurrentRow.Cells("data_encerramento").Value))

                    frmMain.Informacao(Mensagem.RegistroAlterado)

                    Call LoadGrid()

            End Select

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAlterarLote_Click(sender As Object, e As EventArgs) Handles btnAlterarLote.Click
        Try
            AlterarLote()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnInserirEtapa_Click(sender As Object, e As EventArgs) Handles btnInserirEtapa.Click
        Try

            oClsUsrPrjProcesso.InsertEtapa(btnSalvar.Tag,
                                           txtEtapa.Text,
                                           dtpDataPrevisao.Text,
                                           dtpDataInicio.Text,
                                           dtpDataTermino.Text,
                                           dtpDataResposta.Text,
                                           txtObservacao.Text)

            LimparCamposGroupBox(grpEtapa)

            LoadGridEtapa()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadCombo(cboOrdemProducao, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoProjeto, "sp_select_combo_static_tipo_projeto")
            Call LoadCombo(cboInternoExterno, "sp_select_combo_static_interno_externo")
            Call LoadCombo(cboProjetista, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
            Call LoadCombo(cboFase, "sp_select_combo_static_fase_projeto")
            Call LoadCombo(cboFaseFiltro, "sp_select_combo_static_fase_projeto")

            dtpDataConclusaoValidacao.Value = Now : dtpDataConclusaoValidacao.Checked = False
            dtpDataProjeto.Value = Now : dtpDataProjeto.Checked = False
            dtpDataLiberacaoCliente.Value = Now : dtpDataLiberacaoCliente.Checked = False
            dtpDataLiberacaoProducao.Value = Now : dtpDataLiberacaoProducao.Checked = False
            dtpDataEntrega.Value = Now : dtpDataEntrega.Checked = False
            dtpDataConclusaoValidacao.Value = Now : dtpDataConclusaoValidacao.Checked = False


            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.ProjetoProcesso, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.ProjetoProcesso, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.ProjetoProcesso, gcDelete)
            grdEtapa.Enabled = VerificaDireito(Formulario.ProjetoProcesso, gcUpdate)
            btnSalvar.Enabled = VerificaDireito(Formulario.ProjetoProcesso, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.ProjetoProcesso, gcUpdate)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProjetoProcesso)
            Call ConfiguraGrid(grdEtapa, Formulario.ProjetoProcesso)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focus
            btnFiltrar.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sFase As String = ""

            If cboFaseFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboFaseFiltro.CheckedValues)
                    sFase &= IIf(sFase = "", "", ",") & cboFaseFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            oClsUsrPrjProcesso.LoadGrid(grdListagem, _
                                        txtPartNumberFiltro.Text.Trim, _
                                        sFase)

            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico(ByVal oGrid As GridEX)

        Try

            'Váriaveis - Formulário
            Dim oForm As New frmPrjProcessoHistorico
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Controle
            oForm.Grid = oGrid
            oForm.CodigoPedido = oGrid.CurrentRow.Cells("codigo_pedido").Value
            oForm.CodigoPedidoItem = oGrid.CurrentRow.Cells("codigo_pedido_item").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            LimparCamposGroupBox(grpDadosPedido)
            LimparCamposGroupBox(grpEtapa)

            btnSalvar.Tag = ""

            cboOrdemProducao.Focus()

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

    Private Sub NovoProjeto()

        Try

            Cursor.Current = Cursors.WaitCursor

            Call oClsUsrPrjProcesso.Insert()

            btnSalvar.Tag = oClsUsrPrjProcesso.Codigo
            txtCodigo.Text = btnSalvar.Tag

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor


            'Atualiza
            Call oClsUsrPrjProcesso.Update(btnSalvar.Tag, _
                                        IIf(cboOrdemProducao.SelectedIndex = -1, -1, cboOrdemProducao.SelectedValue), _
                                        txtCliente.Text.Trim, _
                                        IIf(cboTipoProjeto.SelectedIndex = -1, "", cboTipoProjeto.SelectedValue), _
                                        txtPO.Text.Trim, _
                                        txtPOLinha.Text.Trim, _
                                        txtRC.Text.Trim, _
                                        txtCodigoCliente.Text.Trim, _
                                        txtPartNumber.Text.Trim, _
                                        txtNs.Text.Trim, _
                                        txtOM.Text.Trim, _
                                        txtAtivoFixo.Text.Trim, _
                                        IIf(dtpDataProjeto.Checked = True, dtpDataProjeto.Value, ""), _
                                        IIf(cboInternoExterno.SelectedIndex = -1, "", cboInternoExterno.SelectedValue), _
                                        IIf(cboProjetista.SelectedIndex = -1, -1, cboProjetista.SelectedValue), _
                                        IIf(dtpDataLiberacaoCliente.Checked = True, dtpDataLiberacaoCliente.Value, ""), _
                                        IIf(dtpDataLiberacaoProducao.Checked = True, dtpDataLiberacaoProducao.Value, ""), _
                                        IIf(dtpDataEntrega.Checked = True, dtpDataEntrega.Value, ""), _
                                        IIf(dtpDataConclusaoValidacao.Checked = True, dtpDataConclusaoValidacao.Value, ""), _
                                        chkInovacao.Checked, _
                                        IIf(cboFase.SelectedIndex = -1, "", cboFase.SelectedValue))

            'Informa o usuário
            frmMain.Informacao(Mensagem.RegistroSalvo)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridEtapa()

        Try

            Cursor.Current = Cursors.WaitCursor

            Call oClsUsrPrjProcesso.LoadGridEtapa(grdEtapa, _
                                                  btnSalvar.Tag)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadDadosPedido()

        Try

            Call oClsUsrPrjProcesso.LoadDados(btnSalvar.Tag, _
                                              cboOrdemProducao, _
                                        txtCliente, _
                                        cboTipoProjeto, _
                                        txtPO, _
                                        txtPOLinha, _
                                        txtRC, _
                                        txtCodigoCliente, _
                                        txtPartNumber, _
                                        txtNs, _
                                        txtOM, _
                                        txtAtivoFixo, _
                                        dtpDataProjeto, _
                                        cboInternoExterno, _
                                        cboProjetista, _
                                        dtpDataLiberacaoCliente, _
                                        dtpDataLiberacaoProducao, _
                                        dtpDataEntrega, _
                                        dtpDataConclusaoValidacao, _
                                        chkInovacao, _
                                        cboFase)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal iCodigo As Integer)

        Try

            Call Novo()

            btnSalvar.Tag = iCodigo

            Call LoadDadosPedido()
            Call LoadGridEtapa()

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o Usuário Deseja Excluir
            If MsgBox("Deseja excluir esta linha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                Call oClsUsrPrjProcesso.CancelaEtapa(btnSalvar.Tag, _
                                                     grdEtapa.CurrentRow.Cells("codigo").Value)

                Cursor.Current = Cursors.Default

                Call LoadGridEtapa()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete(ByVal oGrid As GridEX)

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(oGrid) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsUsrPrjProcesso.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Call LoadGrid()

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

    Private Sub AlterarLote()
        Try

            If grdListagem.GetCheckedRows.Count = 0 Then
                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Sub
            End If


            Dim oForm As New frmPrjAlterarLote
            oForm.Grid = grdListagem
            oForm.ShowDialog()

            Call LoadGrid()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub



#End Region


End Class
