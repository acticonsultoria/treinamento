Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFatAlteracaoEntrada

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFatAlteracaoEntrada As New clsUsrFatAlteracaoEntrada
    Private lCodigoEntradaCapa As Long
    Private lCodigoEntradaItem As Long
    Private lCodigoEntradaItemLote As Long

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFatAlteracaoEntrada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFatAlteracaoEntrada_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoAlteracaoEntrada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FaturamentoAlteracaoEntrada, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoAlteracaoEntrada, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTROLE DE DEVOLUÇÃO :::"

    Private Sub btnFiltrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoAlteracaoEntrada
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoAlteracaoEntrada)

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatAlteracaoEntrada_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoAlteracaoEntrada, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoAlteracaoEntrada, gcUpdate)

            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ", 'E'")
            Call LoadCombo(cboOperacao, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada -1, " & goUsuario.iEmpresa)
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto), False)


            dtpDataInicioFiltro.Value = Now : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now : dtpDataTerminoFiltro.Checked = False

            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoAlteracaoEntrada)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTROLE DE DEVOLUÇÃO :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Pedido de Venda
            Call oClsUsrFatAlteracaoEntrada.LoadGrid(grdListagem, _
                                                      txtNotaFiscalFiltro.Text, _
                                                      IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                                      IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                                      txtFornecedorFiltro.Text, _
                                                      txtProdutoFiltro.Text)

            'Atualiza Grid
            grdListagem.Refresh()

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

    Private Sub Salvar()

        Try

            'Seta Cursor do Mous
            Cursor.Current = Cursors.WaitCursor

            'Atualiza os dados
            oClsUsrFatAlteracaoEntrada.Update(grdListagem.GetValue("codigo_entrada_capa"), _
                                              grdListagem.GetValue("codigo_entrada_item"), _
                                              grdListagem.GetValue("codigo_entrada_item_lote"), _
                                              cboCFOP.SelectedValue, _
                                              cboOperacao.SelectedValue, _
                                              IIf(cboNumeroDocumento.SelectedIndex = -1, -1, cboNumeroDocumento.SelectedValue), _
                                              cboProduto.SelectedValue, _
                                              txtQuantidade.Value, _
                                              IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue), _
                                              txtLote.Text.Trim)

            'Se estiver inserindo um novo, seta na listagem
            If grdListagem.GetValue("codigo_entrada_item_lote") = -1 Then grdListagem.SetValue("codigo_entrada_item_lote", 1)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            cboOperacao.SelectedIndex = -1
            cboNumeroDocumento.SelectedIndex = -1
            cboProduto.SelectedIndex = -1
            cboDeposito.SelectedIndex = -1

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoAlteracaoEntrada, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega dados da nota
                txtNotaFiscal.Text = grdListagem.CurrentRow.Cells.Item("nota_fiscal").Value
                dtpData.Value = grdListagem.CurrentRow.Cells.Item("data").Value
                txtFornecedor.Text = grdListagem.CurrentRow.Cells.Item("fornecedor").Value
                txtProduto.Text = grdListagem.CurrentRow.Cells.Item("codigo_produto").Value
                txtDescricao.Text = grdListagem.CurrentRow.Cells.Item("descricao").Value
                txtQuantidadeNF.Value = grdListagem.CurrentRow.Cells.Item("quantidade").Value
                txtValorTotal.Value = grdListagem.CurrentRow.Cells.Item("valor_total").Value
                cboCFOP.Text = grdListagem.CurrentRow.Cells.Item("cfop").Value
                txtLote.Text = grdListagem.GetValue("lote")
                If Not IsDBNull(grdListagem.GetValue("codigo_deposito")) Then
                    cboDeposito.SelectedValue = grdListagem.GetValue("codigo_deposito")
                End If


                If IsDBNull(grdListagem.CurrentRow.Cells.Item("codigo_tipo_operacao").Value) Then
                    cboOperacao.SelectedIndex = -1
                Else
                    cboOperacao.SelectedValue = grdListagem.CurrentRow.Cells.Item("codigo_tipo_operacao").Value
                End If

                Select Case cboOperacao.SelectedValue
                    Case TipoOperacaoNotaFiscalEntrada.Compra

                        cboNumeroDocumento.SelectedValue = grdListagem.GetValue("codigo_pedido")
                        cboProduto.SelectedValue = CStr(grdListagem.GetValue("codigo_pedido_item")) & "|" & CStr(grdListagem.GetValue("codigo_pedido_item_entrega")) & "|" & CStr(grdListagem.GetValue("codigo_item"))
                        txtQuantidade.Value = grdListagem.GetValue("quantidade_operacao")
                    Case TipoOperacaoNotaFiscalEntrada.OrdemProducao

                        cboNumeroDocumento.SelectedValue = grdListagem.GetValue("codigo_ordem_producao")
                        cboProduto.SelectedValue = CStr(grdListagem.GetValue("codigo_emissao_item")) & "|" & CStr(grdListagem.GetValue("codigo_item"))
                        txtQuantidade.Value = grdListagem.GetValue("quantidade_operacao")

                    Case TipoOperacaoNotaFiscalEntrada.EntradaNFe


                    Case TipoOperacaoNotaFiscalEntrada.DevolucaoNFe

                        cboNumeroDocumento.SelectedValue = grdListagem.GetValue("codigo_emissao_capa")
                End Select

                tabMain.TabPages.Remove(pagListagem)
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

            'Limpa Erro
            frmMain.errInfo.Clear()

            txtNotaFiscal.Text = ""
            dtpData.Value = Now.Date
            txtFornecedor.Text = ""
            txtProduto.Text = ""
            txtDescricao.Text = ""
            txtQuantidadeNF.Value = 0
            txtValorTotal.Value = 0
            cboCFOP.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            cboProduto.SelectedIndex = -1
            txtQuantidade.Value = 0


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

    Private Sub cboOperacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOperacao.SelectedIndexChanged
        Try
            'Verifica o Tipo de Operação Selecionada
            Select Case cboOperacao.SelectedValue

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros)
                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False) : cboProduto.Enabled = True
                  

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento)
                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False) : cboProduto.Enabled = True
                    cboNumeroDocumento.DataSource = Nothing
                    cboNumeroDocumento.Text = ""
                    cboNumeroDocumento.Enabled = True

                Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                    'Carrega Combo de Pedido de Compra
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_pedido_compra " & goUsuario.iEmpresa & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_emitente")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_capa")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item_lote")) & ",1", False)
                    'Habilita Controle
                    cboNumeroDocumento.Enabled = True
                    'Seta Label
                    lblNumeroDocumento.Text = "Pedido de Compra:"
                    

                Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                    'Carrega Combo de Nota Fiscal Emitida
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao " & goUsuario.iEmpresa & ", " &
                                                    CStr(grdListagem.GetValue("codigo_emitente")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_capa")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item_lote")) & ",1", False)
                    'Habilita Controle
                    cboNumeroDocumento.Enabled = True
                    'Seta Label
                    lblNumeroDocumento.Text = "Nota Fiscal:"
                  

                Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                    'Carrega Combo de Nota Fiscal
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao  " & goUsuario.iEmpresa & ", " & CStr(grdListagem.GetValue("codigo_emitente")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_capa")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item_lote")) & ",1", False)
                    'Habilita Controle
                    lblNumeroDocumento.Text = "Ordem Produção:"
                    cboNumeroDocumento.Enabled = True
                

                Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                    'Carrega Combo de Nota Fiscal
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_ordem_producao  " & goUsuario.iEmpresa & ", " & CStr(grdListagem.GetValue("codigo_emitente")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_capa")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item")) & ", " & _
                                                    CStr(grdListagem.GetValue("codigo_entrada_item_lote")) & ",1", False)
                    'Habilita Controle
                    lblNumeroDocumento.Text = "Ordem Produção:"
                    cboNumeroDocumento.Enabled = True
                    
            End Select
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboNumeroDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroDocumento.SelectedIndexChanged
        Try
            lCodigoEntradaCapa = grdListagem.GetValue("codigo_entrada_capa")
            'Verifica o Tipo de Operação
            Select Case cboOperacao.SelectedValue



                Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                    'Seta Váriavel
                    Dim lCodigoPedido As Long = cboNumeroDocumento.SelectedValue
                    'Carrega Combo
                    Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_pedido_compra_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & grdListagem.GetValue("codigo_entrada_item") & ", " & grdListagem.GetValue("codigo_entrada_item_lote") & ",1", False)

                Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                    'Seta Váriavel
                    Dim lCodigoEmissaoCapa As Long = cboNumeroDocumento.SelectedValue
                    'Carrega Combo
                    Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao_produto " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & grdListagem.GetValue("codigo_entrada_item") & ", " & grdListagem.GetValue("codigo_entrada_item_lote") & ",1", False)

                Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                    Dim lCodigoEmissaoCapa As Long = cboNumeroDocumento.SelectedValue
                    'Carrega Combo
                    Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & grdListagem.GetValue("codigo_entrada_item") & ", " & grdListagem.GetValue("codigo_entrada_item_lote") & ",1", False)

                Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                    Dim lCodigoPedido As Long = cboNumeroDocumento.SelectedValue
                    'Carrega Combo
                    Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_ordem_producao_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & grdListagem.GetValue("codigo_entrada_item") & ", " & cboNumeroDocumento.SelectedValue & ",1", False)

            End Select
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

  
End Class