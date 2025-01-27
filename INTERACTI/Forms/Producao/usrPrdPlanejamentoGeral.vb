Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrPrdPlanejamentoGeral

    '#Region "::: VARIAVEIS :::"

    '    'Variáveis da Classe
    '    Private oClsPrdPlanejamento As New clsUsrPrdPlanejamento
    '    Private oCurrentRow As GridEXRow

    '#End Region

    '#Region "::: CONTROLES :::"

    '#Region "::: DADOS GERAIS :::"

    '    Private Sub usrPrdPlanejamentoGeral_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '        Try

    '            Select Case e.KeyCode

    '                Case Keys.Enter
    '                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

    '                Case Keys.F3
    '                    Select Case sender.Name
    '                        Case "txtClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
    '                        Case "txtProdutoFiltro" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
    '                    End Select

    '                Case Keys.F5
    '                    Select Case sender.Name
    '                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
    '                        Case "cboNumeroPedidoVendaCliente" : Call LoadCombo(cboPedidoVendaFiltro, "sp_select_combo_venda_pedido_producao " & goUsuario.iEmpresa)
    '                    End Select

    '            End Select

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Text)
    '        End Try

    '    End Sub

    '    Private Sub usrPrdPlanejamentoGeral_Load(sender As Object, e As EventArgs) Handles Me.Load

    '        'Configura UserControl
    '        Call ConfigurarUserControl()

    '    End Sub

    '#End Region

    '#Region "::: PLANEJAMENTO :::"

    '    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

    '        Try

    '            'Verifica se o Grupo está Habilita
    '            If grdListagem.GroupByBoxVisible = True Then
    '                'Oculta Grupo
    '                grdListagem.GroupByBoxVisible = False
    '            Else
    '                'Exibe Grupo
    '                grdListagem.GroupByBoxVisible = True
    '                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True
    '            End If

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

    '        Try

    '            'Variaveis Locais
    '            Dim oForm As New frmCfgGrid

    '            'Seta Parametros
    '            oForm.Grid = grdListagem
    '            oForm.NomeFormulario = Formulario.ProducaoPlanejamento
    '            'Abre Formulário
    '            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

    '            'Configura Grid
    '            Call ConfiguraGrid(grdListagem, Formulario.ProducaoPlanejamento)

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

    '        Try

    '            'Exporta Grid para Excel
    '            Call ExportExcel(grdListagem)

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

    '        Try

    '            'Abre Formulário de Cadastro
    '            Dim oForm As New frmCadBasico
    '            oForm.UsrControl = "usrFindItem"
    '            oForm.Titulo = Me.Parent.Text
    '            oForm.Tamanho = True
    '            oForm.Text = "Procurar Produto"

    '            'Seta Parametros
    '            iCodigoTipoItemFind = TipoItem.produto
    '            sItemProducaoFind = "S"
    '            oMaskedEditBoxFind = txtProdutoFiltro

    '            'Abre Formulário
    '            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

    '            'Seta Focu
    '            txtProdutoFiltro.Focus()

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

    '        Try

    '            'Abre Formulário de Cadastro
    '            Dim oForm As New frmCadBasico
    '            oForm.UsrControl = "usrFindParceiroNegocio"
    '            oForm.Titulo = Me.Parent.Text
    '            oForm.Tamanho = True
    '            oForm.Text = "Procurar Parceiro de Negócio"

    '            'Seta Parametros
    '            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
    '            oMaskedEditBoxFind = txtClienteFiltro

    '            'Abre Formulário
    '            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

    '            'Seta Focu
    '            txtProdutoFiltro.Focus()

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

    '        Try

    '            'Limpa Erro
    '            frmMain.errInfo.Clear()

    '            'Carrega Dados da Grid
    '            Call LoadGrid()

    '            'Limpa Controles
    '            cboModeloRoteiroProducao.DataSource = Nothing : cboModeloRoteiroProducao.Text = ""
    '            cboRevisao.DataSource = Nothing : cboRevisao.Text = ""
    '            txtQuantidade.Value = 0

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub btnOrdemProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdemProducao.Click

    '        Try

    '            'Limpa Erro
    '            frmMain.errInfo.Clear()

    '            'Valida Dados do Formulário
    '            If Validacao() Then

    '                'Gera Ordem de Produção
    '                Call GerarOrdemProducao()

    '            End If

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

    '        Try

    '            'Deleta Aba
    '            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
    '            'Fecha o Controle
    '            Me.Dispose()

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub chkConfiguracaoPlanejamento_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgruparPedidoVenda.CheckedChanged, _
    '                                                                                                     chkConsiderarPedidoVenda.CheckedChanged, _
    '                                                                                                     chkConsiderarEstoqueMinimo.CheckedChanged, _
    '                                                                                                     chkConsiderarEstoqueQualidade.CheckStateChanged, _
    '                                                                                                     chkForecast.CheckedChanged

    '        Try

    '            Select Case sender.Name

    '                Case "chkForecast" : txtForecastMes.Enabled = chkForecast.CheckState : txtForecastMes.Value = IIf(txtForecastMes.Enabled = False, 0, txtForecastMes.Value)
    '                Case "chkAgruparPedidoVenda" : chkConsiderarPedidoVenda.CheckState = IIf(chkAgruparPedidoVenda.CheckState = CheckState.Unchecked, chkConsiderarPedidoVenda.CheckState, CheckState.Checked)
    '                Case "chkConsiderarPedidoVenda" : chkAgruparPedidoVenda.CheckState = IIf(chkConsiderarPedidoVenda.CheckState = CheckState.Unchecked, CheckState.Unchecked, chkAgruparPedidoVenda.CheckState)

    '            End Select

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub grdListagem_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged

    '        Try

    '            'Verifica se tem alguma Linha Selecionada
    '            If e.Row.CheckState = RowCheckState.Checked Then

    '                'Desmarca Linha Anterior
    '                If IsNothing(oCurrentRow) = False Then
    '                    oCurrentRow.CheckState = RowCheckState.Unchecked
    '                End If

    '                'Seta Váriavel
    '                oCurrentRow = e.Row

    '                'Carrega Controles
    '                Call LoadCombo(cboModeloRoteiroProducao, "sp_select_combo_cadastro_basico_item_modelo_roteiro_producao " & goUsuario.iEmpresa & ", " & oCurrentRow.Cells("codigo_item").Value, True)
    '                txtQuantidade.Value = oCurrentRow.Cells("quantidade_produzir").Value
    '                If IsNumeric(txtQuantidadeAmostra.Value) Then
    '                    txtQuantidade.Value += IIf(txtQuantidadeAmostra.Value > 0, txtQuantidadeAmostra.Value, 0)
    '                End If
    '                If IsDBNull(oCurrentRow.Cells("data_necessidade").Value) Then
    '                    dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Enabled = True
    '                Else
    '                    dtpDataNecessidade.Value = oCurrentRow.Cells("data_necessidade").Value : dtpDataNecessidade.Enabled = False
    '                End If

    '            Else

    '                'Limpa Váriavel
    '                oCurrentRow = Nothing

    '                'Limpa Controles
    '                cboModeloRoteiroProducao.DataSource = Nothing : cboModeloRoteiroProducao.Text = ""
    '                cboRevisao.DataSource = Nothing : cboRevisao.Text = ""
    '                txtQuantidade.Value = 0
    '                txtQuantidadeAmostra.Value = 0
    '                dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Enabled = True

    '            End If

    '            grdListagem.Refresh()

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Text)
    '        End Try

    '    End Sub

    '    Private Sub grdListagem_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellValueChanged

    '        Try

    '            'Verifica qual Coluna teve uma Célula com valor Alterado
    '            If e.Column.Key = "quantidade_produzir" Then

    '                'Verifica se é Numérico a Quantidade Produzir
    '                If IsNumeric(grdListagem.GetValue("quantidade_produzir")) = False Then Exit Sub

    '                'Váriaveis
    '                Dim dQuantidadeProduzir As Double = grdListagem.GetValue("quantidade_produzir")
    '                Dim lCodigo As Long = grdListagem.GetValue("codigo")
    '                Dim sQuery As String

    '                For Each oRow As GridEXRow In grdListagem.CurrentRow.GetChildRecords

    '                    'Atualiza Grid
    '                    sQuery = "(codigo = " & oRow.Cells("codigo").Value & ") AND (codigo_item = " & oRow.Cells("codigo_item").Value & ")"
    '                    Call UpdateRegistroGrid(grdListagem, sQuery, "quantidade_necessaria", dQuantidadeProduzir * oRow.Cells("quantidade_bom").Value, 1)

    '                Next

    '            End If

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

    '        Try

    '            'Atualiza Grid
    '            Call UpdateConfiguraGrid(grdListagem, _
    '                                     Formulario.ProducaoPlanejamento)

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

    '        Try

    '            'Atualiza Grid
    '            Call UpdateConfiguraGrid(grdListagem.Name, _
    '                                     Formulario.ProducaoPlanejamento, _
    '                                     e.Column.Key, _
    '                                     e.ProposedWidth)

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

    '        Try

    '            'Atualiza Grid
    '            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
    '                                          Formulario.ProducaoPlanejamento, _
    '                                          e.Group.Column.Key, _
    '                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
    '                                          e.ProposedPosition)

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '    Private Sub txtQuantidadeAmostra_ValueChanged(sender As Object, e As EventArgs)

    '        Try

    '            'Verifica se foi Selecionado Algum Registro
    '            If IsNothing(oCurrentRow) = False Then

    '                If IsNumeric(txtQuantidadeAmostra.Value) Then
    '                    txtQuantidade.Value = oCurrentRow.Cells("quantidade_produzir").Value + IIf(txtQuantidadeAmostra.Value > 0, txtQuantidadeAmostra.Value, 0)
    '                End If

    '            End If

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Text)
    '        End Try

    '    End Sub

    '#End Region

    '#End Region

    '#Region "::: FUNCTION / SUB :::"

    '#Region "::: DADOS GERAIS :::"

    '    Private Sub ConfigurarUserControl()

    '        Try

    '            'Seta Cursor do Mouse
    '            Cursor.Current = Cursors.WaitCursor

    '            'Adiciona KeyUP
    '            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
    '            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdPlanejamentoGeral_KeyDown))
    '            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

    '            'Verifica Direito
    '            btnOrdemProducao.Enabled = VerificaDireito(Formulario.ProducaoPlanejamento, gcInsert)
    '            btnExcelGrid.Enabled = VerificaDireito(Formulario.ProducaoPlanejamento, gcPrint)

    '            'Carrega Combo
    '            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
    '            Call LoadCombo(cboPedidoVendaFiltro, "sp_select_combo_venda_pedido_producao " & goUsuario.iEmpresa)

    '            'Seta Controle
    '            dtpDataNecessidadeInicioFiltro.Value = Now.Date : dtpDataNecessidadeInicioFiltro.Checked = False
    '            dtpDataNecessidadeTerminoFiltro.Value = Now.Date : dtpDataNecessidadeTerminoFiltro.Checked = False

    '            'Configura Grid
    '            Call ConfiguraGrid(grdListagem, Formulario.ProducaoPlanejamento)

    '            'Desabilita Controles
    '            txtForecastMes.Enabled = False : txtForecastMes.Value = 0

    '            'Configura Valor Default
    '            Call ConfigureValorDefault(Me)

    '            'Seta Focu
    '            cboGrupoItemFiltro.Focus()

    '            'Seta Cursor do Mouse
    '            Cursor.Current = Cursors.Default

    '        Catch ex As Exception
    '            'Trata Erro
    '            Call TratamentoErro(ex.Message, Me.Parent.Text)
    '        End Try

    '    End Sub

    '#End Region

    '#Region "::: PLANEJAMENTO :::"

    '    Private Sub LoadGrid()

    '        Try

    '            'Limpa erro
    '            frmMain.errInfo.Clear()


    '            'Seta Cursor do Mouse
    '            Cursor.Current = Cursors.WaitCursor

    '            'Carrega Grid
    '            Call oClsPrdPlanejamento.LoadGrid(grdListagem, _
    '                                              IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
    '                                              IIf(dtpDataNecessidadeInicioFiltro.Checked = False, "", dtpDataNecessidadeInicioFiltro.Value), _
    '                                              IIf(dtpDataNecessidadeTerminoFiltro.Checked = False, "", dtpDataNecessidadeTerminoFiltro.Value), _
    '                                              txtProdutoFiltro.Text.Trim, _
    '                                              txtMateriaPrimaFiltro.Text.Trim, _
    '                                              IIf(cboPedidoVendaFiltro.SelectedIndex = -1, -1, cboPedidoVendaFiltro.SelectedValue), _
    '                                              txtClienteFiltro.Text.Trim, _
    '                                              chkAgruparPedidoVenda.CheckState, _
    '                                              chkConsiderarPedidoVenda.CheckState, _
    '                                              chkConsiderarEstoque.CheckState, _
    '                                              chkConsiderarEstoqueMinimo.CheckState, _
    '                                              chkConsiderarEstoqueQualidade.CheckState, _
    '                                              chkForecast.CheckState, _
    '                                              txtForecastMes.Value)

    '            'Limpa Controles
    '            oCurrentRow = Nothing
    '            cboModeloRoteiroProducao.DataSource = Nothing : cboModeloRoteiroProducao.Text = ""
    '            cboRevisao.DataSource = Nothing : cboRevisao.Text = ""
    '            txtQuantidadeAmostra.Value = 0
    '            txtQuantidade.Value = 0

    '            'Seta Cursor do Mouse
    '            Cursor.Current = Cursors.Default

    '        Catch ex As Exception
    '            Throw ex
    '        End Try

    '    End Sub

    '    Private Function Validacao() As Boolean

    '        Try

    '            'Seta Retorno da Função
    '            Validacao = False

    '            'Verifica se foi selecionado algum Registro
    '            If VerificaSelecaoRow(grdListagem) = False Then
    '                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
    '                Exit Function
    '            End If

    '            'Verifica se foi Selecionado o Campo - Modelo Roteiro de Produção
    '            If ValidaCampo(cboModeloRoteiroProducao, lblModeloRoteiroProducao) = False Then
    '                Exit Function
    '            End If

    '            'Verifica se foi Selecionado o Campo - Revisão
    '            If ValidaCampo(cboRevisao, lblRevisao) = False Then
    '                Exit Function
    '            End If

    '            'Verifica se foi Preenchido o Campo - Quantidade
    '            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
    '                Exit Function
    '            End If

    '            'Seta Retorno da Função
    '            Validacao = True

    '        Catch ex As Exception
    '            Throw ex
    '        End Try

    '    End Function

    '    Private Sub GerarOrdemProducao()

    '        Try

    '            'Verifica se o Usuário Deseja Gerar a Ordem de Produção
    '            If MsgBox("Deseja Gerar Ordem de Produção para o(s) Item(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

    '                'Gera Ordem de Produção
    '                oClsPrdPlanejamento.GerarOrdemProducao(oCurrentRow.Cells("codigo_item").Value, _
    '                                                       -1, _
    '                                                       cboModeloRoteiroProducao.SelectedValue, _
    '                                                       cboRevisao.SelectedValue, _
    '                                                       -1, _
    '                                                       oCurrentRow.Cells("quantidade_pedido").Value, _
    '                                                       oCurrentRow.Cells("quantidade_forecast").Value, _
    '                                                       oCurrentRow.Cells("estoque_minimo").Value, _
    '                                                       oCurrentRow.Cells("quantidade_estoque").Value, _
    '                                                       oCurrentRow.Cells("quantidade_producao").Value, _
    '                                                       txtQuantidadeAmostra.Value, _
    '                                                       txtQuantidade.Value, _
    '                                                       IIf(IsDBNull(oCurrentRow.Cells("codigo_pedido").Value), -1, oCurrentRow.Cells("codigo_pedido").Value), _
    '                                                       IIf(IsDBNull(oCurrentRow.Cells("codigo_pedido_item").Value), -1, oCurrentRow.Cells("codigo_pedido_item").Value), _
    '                                                       IIf(IsDBNull(oCurrentRow.Cells("codigo_pedido_item_entrega").Value), -1, oCurrentRow.Cells("codigo_pedido_item_entrega").Value), _
    '                                                       dtpDataNecessidade.Value, _
    '                                                       txtForecastMes.Value)

    '                'Informa o Usuário sobre o Sucesso da Operação
    '                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

    '                'Recarrega a Grid
    '                Call LoadGrid()

    '            End If

    '        Catch ex As Exception
    '            Throw ex
    '        End Try

    '    End Sub

    '#End Region

    '#End Region

    Private Sub btnOrdemProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdemProducao.Click

    End Sub
End Class
