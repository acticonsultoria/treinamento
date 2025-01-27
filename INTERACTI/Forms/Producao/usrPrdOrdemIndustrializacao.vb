Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrPrdOrdemIndustrializacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdOrdemIndustrializacao As New clsUsrPrdOrdemIndustrializacao

#End Region

#Region "::: CONTROLES :::"

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
                ' Call Novo()

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
            btnGerarPedidoCompra.Enabled = True
            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtNumeroFiltro.Focus()

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

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadArea_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcPrint)

            Call LoadCombo(cboOrdemProducao, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa)
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa & ", null, null")
            Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete")
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa)
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoArea)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroFiltro.Focus()

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
            If VerificaDireito(Formulario.CadastroBasicoArea, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    btnSalvar.Tag = .Item("codigo").Value
                    LoadGridItem()
                    txtNumeroOrdem.Text = .Item("numero").Value
                    txtLocalEntrega.Text = .Item("local_entrega").Value
                    cboModalidadeFrete.SelectedValue = .Item("codigo_modalidade_frete").Value
                    cboTransportadora.SelectedValue = .Item("codigo_transportadora").Value
                    cboModalidadeTransporte.SelectedValue = .Item("codigo_modalidade_transporte").Value
                    txtValorFretePedido.Value = .Item("valor_frete").Value
                    cboCondicaoPagamento.SelectedValue = .Item("codigo_condicao_pagamento").Value
                    cboFormaPagamento.SelectedValue = .Item("codigo_forma_pagamento").Value
                    txtValorDesonto.Value = .Item("valor_desconto").Value
                    txtValorFinalPedido.Value = .Item("valor_total").Value
                    cboFornecedor.SelectedValue = .Item("codigo_fornecedor").Value
                    txtObservacao.Text = .Item("observacao").Value
                    dtpData.Value = .Item("data").Value
                    cboCentroTrabalho.SelectedValue = .Item("codigo_centro_trabalho").Value

                    If .Item("status").Value = "PEDIDO DE COMPRA" Then
                        btnGerarPedidoCompra.Enabled = False
                    Else
                        btnGerarPedidoCompra.Enabled = True
                    End If

                End With

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtNumeroOrdem.Focus()

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
                    oClsPrdOrdemIndustrializacao.Delete()

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
            If VerificaSelecaoRow(grdItem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsPrdOrdemIndustrializacao.DeleteItem()

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
            txtNumeroOrdem.Text = ""
            dtpData.Value = Now.Date
            cboFornecedor.SelectedIndex = -1
            txtObservacao.Text = ""
            cboCentroTrabalho.SelectedIndex = -1
            cboModalidadeFrete.SelectedIndex = -1
            cboModalidadeTransporte.SelectedIndex = -1
            cboCondicaoPagamento.SelectedIndex = -1
            cboFormaPagamento.SelectedIndex = -1
            cboTransportadora.SelectedIndex = -1
            txtValorDesonto.Value = 0
            txtValorFinalPedido.Value = 0
            txtValorFretePedido.Value = 0
            txtObservacao.Text = ""
            oClsPrdOrdemIndustrializacao.Insert(btnSalvar, txtNumeroOrdem)
            'Seta Focu
            txtNumeroOrdem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoItem()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()
            oClsPrdOrdemIndustrializacao.LoadGridItem(grdItem, 0)

            cboOrdemProducao.SelectedIndex = -1
            cboMateriaPrima.SelectedIndex = -1
            txtQuantidade.Value = 0
            txtLote.Text = ""
            txtArquivo.Text = ""
            btnInserirItem.Tag = ""


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

           
            oClsPrdOrdemIndustrializacao.Salvar(btnSalvar.Tag, dtpData.Value, cboFornecedor.SelectedValue, txtObservacao.Text, _
                                                txtValorFinalPedido.Value, _
                                                txtValorDesonto.Value, _
                                                cboFormaPagamento.SelectedValue, _
                                                cboCondicaoPagamento.SelectedValue, _
                                                txtValorFretePedido.Value, _
                                                txtLocalEntrega.Text, _
                                                cboModalidadeTransporte.SelectedValue, _
                                                cboTransportadora.SelectedValue, _
                                                cboModalidadeFrete.SelectedValue, _
                                                dtpDataEntrega.Value, _
                                                cboCentroTrabalho.SelectedValue)
               
                frmMain.Informacao(Mensagem.RegistroInserido)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub InsertItem()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If CStr(btnInserirItem.Tag) = "" Then
                oClsPrdOrdemIndustrializacao.InsertItem(cboOrdemProducao.SelectedValue, _
                                                        cboMateriaPrima.SelectedValue, _
                                                        txtQuantidade.Value, _
                                                        txtLote.Text, _
                                                        txtArquivo.Text, _
                                                        btnSalvar.Tag, _
                                                        txtValorUnitario.Value, _
                                                        txtValorTotal.Value)
            Else
                oClsPrdOrdemIndustrializacao.UpdateItem(cboOrdemProducao.SelectedValue, _
                                                        cboMateriaPrima.SelectedValue, _
                                                        txtQuantidade.Value, _
                                                        txtLote.Text, _
                                                        txtArquivo.Text, _
                                                        btnSalvar.Tag, _
                                                        btnInserirItem.Tag, _
                                                        txtValorUnitario.Value, _
                                                        txtValorTotal.Value)
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
            oClsPrdOrdemIndustrializacao.LoadGrid(grdListagem, _
                                 txtNumeroFiltro.Text, txtFornecedorFiltro.Text, _
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
            oClsPrdOrdemIndustrializacao.LoadGridItem(grdItem, _
                                 btnSalvar.Tag)
            txtValorFinalPedido.Value = grdItem.GetTotalRow.Cells.Item("valor_total").Value
            txtValorFinalPedido.Value = (txtValorFinalPedido.Value + txtValorFretePedido.Value) - txtValorDesonto.Value
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

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtNumeroOrdem, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Sub cboOrdemProducao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOrdemProducao.SelectedIndexChanged
        Try
            If cboOrdemProducao.SelectedIndex = -1 Then Exit Sub

            Call LoadCombo(cboMateriaPrima, "sp_select_combo_producao_ordem_producao_materia_prima " & goUsuario.iEmpresa & ", " & cboOrdemProducao.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboMateriaPrima_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMateriaPrima.SelectedIndexChanged
        Try
            If cboMateriaPrima.SelectedIndex = -1 Then Exit Sub

            oClsPrdOrdemIndustrializacao.LoadDadosItem(cboMateriaPrima.SelectedValue, _
                                                       cboOrdemProducao.SelectedValue, _
                                                       txtQuantidade, _
                                                       txtLote, _
                                                       txtValorUnitario)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

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

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

           

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            'arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivo.SelectedValue)
            arqArquivo.Title = "Selecione o Arquivo"


            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub EditarItem()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComprasRequisicao, gcUpdate) = True Then

                'Limpa Formulário
                'Call NovoArquivo()

                'Carrega Controles
                cboOrdemProducao.SelectedValue = grdItem.CurrentRow.Cells("codigo_ordem_producao").Value
                cboMateriaPrima.SelectedValue = grdItem.CurrentRow.Cells("codigo_materia_prima").Value
                txtQuantidade.Value = grdItem.CurrentRow.Cells("quantidade").Value
                txtArquivo.Text = grdItem.CurrentRow.Cells("arquivo").Value
                btnInserirItem.Tag = grdItem.CurrentRow.Cells("codigo").Value
                txtLote.Text = grdItem.CurrentRow.Cells("lote").Value
                txtValorUnitario.Value = grdItem.CurrentRow.Cells("valor_unitario").Value
                txtValorTotal.Value = grdItem.CurrentRow.Cells("valor_total").Value
               

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarArquivo()

        Try

            'Verifica se existe Arquivo
            If IsDBNull(grdItem.CurrentRow.Cells("arquivo").Value) = False Then

                If System.IO.File.Exists(grdItem.CurrentRow.Cells("arquivo").Value) = True Then

                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdItem.CurrentRow.Cells("arquivo").Value)

                Else
                    'Informa o Usuário que o Arquivo associado não é válido
                    frmMain.Informacao("Arquivo não encontrado!", Color.Red)
                End If

            Else
                'Informa o Usuário que não existe Arquivo associado ao Registro
                frmMain.Informacao("Arquivo não informado!", Color.Red)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub grdItem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdItem.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdItem.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdItem.CurrentColumn.Key

                Case "editar" : Call EditarItem()
                Case "arquivo" : Call VisualizarArquivo()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub txtValorUnitario_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorUnitario.ValueChanged
        Try
            txtValorTotal.Value = txtValorUnitario.Value * txtQuantidade.Value
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub txtValorDesonto_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorDesonto.ValueChanged, _
                                                                                                            txtValorFretePedido.ValueChanged
        Try
            txtValorFinalPedido.Value = grdItem.GetTotalRow.Cells.Item("valor_total").Value
            txtValorFinalPedido.Value = (txtValorFinalPedido.Value + txtValorFretePedido.Value) - txtValorDesonto.Value
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnGerarPedidoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarPedidoCompra.Click
        Try
            Cursor.Current = Cursors.WaitCursor

            If Validacao() = True Then
                oClsPrdOrdemIndustrializacao.InsertPedidoCompra(btnSalvar.Tag)
                btnGerarPedidoCompra.Enabled = False
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            Cursor.Current = Cursors.WaitCursor
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarModalidadeTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarModalidadeTransporte.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadModalidadeTransporte")

            'Carrega Combo            
            LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa)

            'Seta Focu
            cboModalidadeTransporte.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
