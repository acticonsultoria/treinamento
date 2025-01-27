Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrCadProduto

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadProduto As New clsUsrCadProduto
    Private oFormularioCadastroBasico() As FormularioCadastroBasico
    Private MouseIsDown As Boolean = False

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    Select Case sender.Name
                        Case "cboFornecedorPadrao" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                        Case "cboClienteVenda" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                        Case "cboCentroCusto" : Call btnProcurarCentroCusto_Click(btnProcurarCentroCusto, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboGrupoItemFiltro", "cboGrupoItem"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboGrupoItemFiltro : oComboBox(1) = cboGrupoItem
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                        Case "cboCodigoNCM" : Call LoadCombo(cboCodigoNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedidaOrigem", "cboUnidadeMedidaDestino", "cboUnidadeMedidaEstoque", "cboUnidadeMedidaCompra", "cboUnidadeMedidaVenda"
                            Dim oComboBox(2) As UIComboBox
                            oComboBox(0) = cboUnidadeMedidaOrigem : oComboBox(1) = cboUnidadeMedidaEstoque : oComboBox(2) = cboUnidadeMedidaDestino : oComboBox(3) = cboUnidadeMedidaCompra : oComboBox(4) = cboUnidadeMedidaVenda
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboFornecedorPadrao" : Call LoadCombo(cboFornecedorPadrao, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboDeposito" : Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1")
                        Case "cboClienteVenda" : Call LoadCombo(cboClienteVenda, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                        Case "cboCaracteristicaInspecionarQualidade" : Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa, False)
                        Case "cboGrupoItemComissionamento" : Call LoadCombo(cboGrupoItemComissionamento, "sp_select_combo_venda_grupo_item " & goUsuario.iEmpresa)
                        Case "cboMarca" : Call LoadCombo(cboMarca, "sp_select_combo_cadastro_basico_produto_marca " & goUsuario.iEmpresa, False)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
                        Case "cboCentroCusto" : Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboGrupoItem" : Call btnCadastrarGrupoItem_Click(btnCadastrarGrupoItem, System.EventArgs.Empty)
                        Case "cboCodigoNCM" : Call btnCadastrarNCM_Click(btnCadastrarNCM, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaOrigem" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedidaOrigem, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaDestino" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedidaDestino, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaEstoque" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedidaEstoque, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaCompra" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedidaCompra, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaVenda" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedidaVenda, System.EventArgs.Empty)
                        Case "cboFornecedorPadrao" : Call btnCadastrarFornecedor_Click(btnCadastrarFornecedor, System.EventArgs.Empty)
                        Case "cboDeposito" : Call btnCadastrarDeposito_Click(btnCadastrarDeposito, System.EventArgs.Empty)
                        Case "cboClienteVenda" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboCaracteristicaInspecionarQualidade" : Call btnCadastrarCaracteristicaInspecionarQualidade_Click(btnCadastrarCaracteristicaInspecionarQualidade, System.EventArgs.Empty)
                        Case "cboGrupoItemComissionamento" : Call btnCadastrarGrupoItemComissionamento_Click(btnCadastrarGrupoItemComissionamento, System.EventArgs.Empty)
                        Case "cboMarca" : btnCadastrarMarca_Click(btnCadastrarMarca, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                        Case "cboCentroCusto" : Call btnCadastrarCentroCusto_Click(btnCadastrarCentroCusto, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadProduto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub cboTipoItemSped_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoItemSped.SelectedIndexChanged

        Try

            tabDados.TabPages.Remove(pagDimensoes)
            LimparCamposGroupBox(grpDimensoes)

            If cboTipoItemSped.SelectedIndex = -1 Then Exit Sub

            'Se for matéria prima, libera aba de dimensoes
            If cboTipoItemSped.SelectedValue = 1 Then
                tabDados.TabPages.Add(pagDimensoes)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProduto)

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

    Private Sub btnEditarGrid_Click(sender As Object, e As EventArgs) Handles btnEditarGrid.Click

        Try

            'Váriaveis Locais
            Dim sCampo(1) As String

            'Carrega Valores
            sCampo(0) = "estoque_minimo"
            sCampo(1) = "estoque_maximo"

            'Habilita Grid
            Call EditarGrid(grdListagem, _
                            sCampo, _
                            IIf(grdListagem.Tag.ToString = "E", False, True))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarGrupoItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"

            'Seta Parametros
            oComboBoxFind = cboGrupoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItem.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoItem")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboGrupoItem : oComboBox(1) = cboGrupoItemFiltro
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMarca.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProdutoMarca")

            'Carrega Combo
            Call LoadCombo(cboMarca, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
            'Seta Focu
            cboMarca.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarNCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarNCM.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadNCM")

            'Carrega Combo
            Call LoadCombo(cboCodigoNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            'Seta Focu
            cboCodigoNCM.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaOrigem.Click, _
                                                                                                                    btnCadastrarUnidadeMedidaDestino.Click, _
                                                                                                                    btnCadastrarUnidadeMedidaCompra.Click, _
                                                                                                                    btnCadastrarUnidadeMedidaVenda.Click, _
                                                                                                                    btnCadastrarUnidadeMedidaEstoque.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            Dim oComboBox(4) As UIComboBox
            oComboBox(0) = cboUnidadeMedidaOrigem : oComboBox(1) = cboUnidadeMedidaEstoque : oComboBox(2) = cboUnidadeMedidaDestino : oComboBox(3) = cboUnidadeMedidaCompra : oComboBox(4) = cboUnidadeMedidaVenda
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            Select Case sender.Name
                Case "cboUnidadeMedidaOrigem" : cboUnidadeMedidaOrigem.Focus()
                Case "cboUnidadeMedidaDestino" : cboUnidadeMedidaDestino.Focus()
                Case "cboUnidadeMedidaEstoque" : cboUnidadeMedidaEstoque.Focus()
                Case "cboUnidadeMedidaCompra" : cboUnidadeMedidaCompra.Focus()
                Case "cboUnidadeMedidaVenda" : cboUnidadeMedidaVenda.Focus()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarGrupoItemComissionamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItemComissionamento.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrVenGrupoItem"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Call LoadCombo(cboGrupoItemComissionamento, "sp_select_combo_venda_grupo_item " & goUsuario.iEmpresa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        'Deleta Registros
        Call Delete()

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

    Private Sub btnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click

        Try

            'Variaveis Locais
            Dim arqImagem As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqImagem.InitialDirectory = "c:\\dados"
            arqImagem.Filter = "(Imagens BMP;JPG;GIF;PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            arqImagem.Title = "Selecione o Arquivo"

            If arqImagem.ShowDialog() = DialogResult.OK Then
                txtFoto.Text = arqImagem.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnLimparArquivo_Click(sender As Object, e As EventArgs) Handles btnLimparArquivo.Click

        Try

            'Limpa Arquivo
            picFoto.Image = Nothing
            txtFoto.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            cboGrupoItem.Focus()

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
            tabMain.TabPages.Remove(pagHistoricoCompra)
            tabMain.TabPages.Remove(pagHistoricoOrcamento)
            tabMain.TabPages.Remove(pagHistoricoVenda)
            tabMain.TabPages.Remove(pagHistoricoProducao)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            cboGrupoItemFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboGrupoItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboGrupoItem.SelectedIndexChanged

        Try

            tabDados.TabPages.Remove(pagUsoConsumo)

            'Exclui Controles
            While grpControleDinamico.Controls.Count > 1
                For Each oControle As Control In grpControleDinamico.Controls
                    If oControle.Name <> "lblPosicao" Then
                        grpControleDinamico.Controls.Remove(oControle)
                    End If
                Next
            End While

            'Verifica se foi Selecionado Algum Registro
            If cboGrupoItem.SelectedIndex > -1 And VerificaDireito(Formulario.CadastroBasicoProdutoControlesDinamicos, gcSelect) = True Then

                'Carrega Controles
                Call CarregaControles(Me, _
                                      "tb_cad_item", _
                                      cboGrupoItem.SelectedValue, _
                                      IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1))

            End If

            'Se for uso e consumo
            If cboGrupoItem.SelectedValue = 3 Then
                If tabDados.TabPages.Contains(pagUsoConsumo) = False Then tabDados.TabPages.Add(pagUsoConsumo)
            End If

            If cboGrupoItem.Text = "HARDWARE" Then
                cboNivelInspecao.SelectedValue = 1
                cboNivelInspecao.Enabled = False
            Else
                cboNivelInspecao.SelectedIndex = -1
                cboNivelInspecao.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 3
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkItemEstoque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemEstoque.CheckedChanged

        Try

            tabDados.Visible = False
            If chkItemEstoque.Checked = True Then
                chkAtivoFixo.Checked = False
                If tabDados.TabPages.Contains(pagEstoque) = False Then tabDados.TabPages.Add(pagEstoque)
                cboMetodologiaSaidaProdutoEstoque.SelectedValue = 4
            Else
                tabDados.TabPages.Remove(pagEstoque)
            End If
            tabDados.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkItemCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemCompra.CheckedChanged

        Try

            tabDados.Visible = False
            If chkItemCompra.Checked = True Then
                'chkItemProducao.Checked = False
                If tabDados.TabPages.Contains(pagCompra) = False Then tabDados.TabPages.Add(pagCompra)
                If tabDados.TabPages.Contains(pagRecebimento) = False Then tabDados.TabPages.Add(pagRecebimento)
                If chkControlaQualidade.Checked = True Then If tabDados.TabPages.Contains(pagQualidade) = False Then tabDados.TabPages.Add(pagQualidade)
            Else
                tabDados.TabPages.Remove(pagCompra)
                tabDados.TabPages.Remove(pagRecebimento)
                tabDados.TabPages.Remove(pagQualidade)
            End If
            tabDados.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkItemVenda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemVenda.CheckedChanged

        Try

            tabDados.Visible = False
            If chkItemVenda.Checked = True Then
                If tabDados.TabPages.Contains(pagVenda) = False Then tabDados.TabPages.Add(pagVenda)
                If tabDados.TabPages.Contains(pagEmbalagem) = False Then tabDados.TabPages.Add(pagEmbalagem)
            Else
                tabDados.TabPages.Remove(pagVenda)
                tabDados.TabPages.Remove(pagEmbalagem)
            End If
            tabDados.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkItemProducao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemProducao.CheckedChanged

        Try

            tabDados.Visible = False

            If chkItemProducao.Checked = True Then
                chkItemEstoque.Checked = True
                'chkItemCompra.Checked = False
                If tabDados.TabPages.Contains(pagProducaoRoteiro) = False Then tabDados.TabPages.Add(pagProducaoRoteiro)
                If tabDados.TabPages.Contains(pagProducaoBOM) = False Then
                    tabDados.TabPages.Add(pagProducaoBOM)
                End If

                'Carrega Combo - Forma de Venda
                Call LoadCombo(cboFormaVenda, "sp_select_combo_static_forma_venda_item " & CInt(TipoItem.produto) & ", 1")
            Else
                tabDados.TabPages.Remove(pagProducaoRoteiro)
                tabDados.TabPages.Remove(pagProducaoBOM)

                'Carrega Combo - Forma de Venda
                Call LoadCombo(cboFormaVenda, "sp_select_combo_static_forma_venda_item " & CInt(TipoItem.produto) & ", 0")
            End If

            tabDados.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkAtivoFixo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAtivoFixo.CheckedChanged

        Try

            tabDados.Visible = False
            If chkAtivoFixo.Checked = True Then
                chkItemEstoque.Checked = False
                chkItemCompra.Checked = True
                If tabDados.TabPages.Contains(pagAtivoFixo) = False Then tabDados.TabPages.Add(pagAtivoFixo)
            Else
                tabDados.TabPages.Remove(pagAtivoFixo)
            End If
            tabDados.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoNCM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoNCM.SelectedIndexChanged

        Try

            If cboCodigoNCM.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricaoNCM.Text = ""
            Else
                'Carrega Dados do NCM
                Call LoadDescricao(txtDescricaoNCM, "sp_select_cadastro_basico_descricao_ncm " & cboCodigoNCM.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFormaVenda_SelectedIndexChanged() Handles cboFormaVenda.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboFormaVenda.SelectedIndex = -1 And chkItemProducao.Checked = False Then
                tabDados.TabPages.Remove(pagProducaoBOM)
            Else

                'Verifica a Forma de Venda
                If cboFormaVenda.SelectedValue = CInt(FormaVendaItem.Kit) Then
                    If tabDados.TabPages.Contains(pagProducaoBOM) = False Then
                        tabDados.TabPages.Add(pagProducaoBOM)
                    End If
                ElseIf chkItemProducao.Checked = False Then
                    tabDados.TabPages.Remove(pagProducaoBOM)
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "duplicar" : Call Duplicar()
                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo_interacti").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(ByVal sender As Object, ByVal e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Query
            Dim sQuery As String = "WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))"

            If IsNumeric(grdListagem.GetValue(e.Column.Key)) Then

                'Atualiza Registro Numérico
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, grdListagem.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")

            Else

                'Atualiza Registro AlphaNumérico
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, "'" & grdListagem.GetValue(e.Column.Key).ToString.Replace("'", "") & "'", "'NULL'") & ",'" & sQuery & "'")

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoProduto)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoProduto, _
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
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtFoto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFoto.TextChanged

        Try

            'Verifica se foi Selecionado alguma Foto
            If txtFoto.Text <> "" Then
                picFoto.Image = Image.FromFile(txtFoto.Text)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Oculta Controle
            btnInserirProducao.Visible = False
            btnExcluirProducao.Visible = False
            btnImprimirProducao.Visible = False
            btnAdicionarControle.Visible = False
            btnPosicionar.Visible = False

            Select Case e.Page.Key
                Case "pagProducaoBOM"
                    btnInserirProducao.Visible = True : btnInserirProducao.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcInsert)
                    btnExcluirProducao.Visible = True : btnExcluirProducao.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcDelete)
                    btnImprimirProducao.Visible = True : btnImprimirProducao.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcPrint)

                Case "pagProducaoRoteiro"
                    btnInserirProducao.Visible = True : btnInserirProducao.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
                    btnExcluirProducao.Visible = True : btnExcluirProducao.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcDelete)

                Case "pagControlesDinamicos"
                    btnAdicionarControle.Visible = True : btnAdicionarControle.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoControlesDinamicos, gcAdministrator)
                    btnPosicionar.Visible = True : btnPosicionar.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoControlesDinamicos, gcAdministrator)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirReferencia.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoReferencia() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirReferencia.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateReferencia(btnSalvar.Tag, _
                                                         txtReferenciaMultipla.Text, _
                                                         btnInserirReferencia.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertReferencia(btnSalvar.Tag, _
                                                          txtReferenciaMultipla.Text)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovaReferencia()

                'Carrega Grid
                Call oClsCadProduto.LoadGridReferencia(grdReferencia, _
                                                        btnSalvar.Tag)

            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirReferencia.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Embalagem
            Call DeleteReferencia()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdReferencia_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdReferencia.RowDoubleClick
        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdReferencia.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdReferencia.CurrentColumn.Key
                Case "editar" : Call EditarReferencia()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboTipoAtivoFixo_SelectedIndexChanged() Handles cboTipoAtivoFixo.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboTipoAtivoFixo.SelectedIndex = -1 Then
                txtVidaUtilBem.Value = 0

            Else

                If cboTipoAtivoFixo.SelectedIndex = 0 Then
                    txtVidaUtilBem.Value = 10
                ElseIf cboTipoAtivoFixo.SelectedIndex = 1 Then
                    txtVidaUtilBem.Value = 0
                ElseIf cboTipoAtivoFixo.SelectedIndex = 2 Then
                    txtVidaUtilBem.Value = 10
                ElseIf cboTipoAtivoFixo.SelectedIndex = 3 Then
                    txtVidaUtilBem.Value = 5
                ElseIf cboTipoAtivoFixo.SelectedIndex = 4 Then
                    txtVidaUtilBem.Value = 10
                ElseIf cboTipoAtivoFixo.SelectedIndex = 5 Then
                    txtVidaUtilBem.Value = 10
                ElseIf cboTipoAtivoFixo.SelectedIndex = 6 Then
                    txtVidaUtilBem.Value = 10
                ElseIf cboTipoAtivoFixo.SelectedIndex = 7 Then
                    txtVidaUtilBem.Value = 10
                ElseIf cboTipoAtivoFixo.SelectedIndex = 8 Then
                    txtVidaUtilBem.Value = 10
                ElseIf cboTipoAtivoFixo.SelectedIndex = 9 Then
                    txtVidaUtilBem.Value = 25
                ElseIf cboTipoAtivoFixo.SelectedIndex = 10 Then
                    txtVidaUtilBem.Value = 0
                ElseIf cboTipoAtivoFixo.SelectedIndex = 11 Then
                    txtVidaUtilBem.Value = 5
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtTaxaDepreciacaoAnual_ValueChanged() Handles txtTaxaDepreciacaoAnual.ValueChanged

        Try

            If txtTaxaDepreciacaoAnual.Value <> 0 Then
                txtTaxaDepreciacaoMensal.Value = txtTaxaDepreciacaoAnual.Value / 12.0
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorDepreciavel() Handles txtValorBem.ValueChanged, _
                                                  txtValorImpostosRecuperaveis.ValueChanged, _
                                                  txtValorResidual.ValueChanged

        Try

            If txtValorBem.Value <> 0 Then
                txtValorDepreciavel.Value = txtValorBem.Value - txtValorImpostosRecuperaveis.Value - txtValorResidual.Value
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorDepreciacaoAnual() Handles txtValorDepreciavel.ValueChanged, _
                                                       txtVidaUtilBem.ValueChanged

        Try

            If txtValorDepreciavel.Value <> 0 Then
                txtValorDepreciacaoAnual.Value = txtValorDepreciavel.Value * (txtVidaUtilBem.Value / 100)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorDepreciacaoMensal() Handles txtValorDepreciacaoAnual.ValueChanged 

        Try

            If txtValorDepreciacaoAnual.Value <> 0 Then
                txtValorDepreciacaoMensal.Value = txtValorDepreciacaoAnual.Value / 12.0
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CLIENTE :::"

    Private Sub btnAgruparGridClienteVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridClienteVenda.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdClienteVenda.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdClienteVenda.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdClienteVenda.GroupByBoxVisible = True
                grdClienteVenda.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridClienteVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridClienteVenda.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdClienteVenda
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdClienteVenda, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridClienteVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridClienteVenda.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdClienteVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo
            Call LoadCombo(cboClienteVenda, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboClienteVenda.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteVenda

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteVenda.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirClienteVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirClienteVenda.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoCliente() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirClienteVenda.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateCliente(btnSalvar.Tag, _
                                                      cboClienteVenda.SelectedValue, _
                                                      txtCodigoProdutoCliente.Text.Trim, _
                                                      txtCodigoProdutoCliente2.Text.Trim, _
                                                      -1, _
                                                      btnInserirClienteVenda.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertCliente(btnSalvar.Tag, _
                                                      cboClienteVenda.SelectedValue, _
                                                      txtCodigoProdutoCliente.Text.Trim, _
                                                      txtCodigoProdutoCliente2.Text.Trim, _
                                                      -1)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoCliente()

                'Carrega Grid
                Call oClsCadProduto.LoadGridCliente(grdClienteVenda, _
                                                    btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirClienteVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirClienteVenda.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Fornecedor
            Call DeleteCliente()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClienteVenda_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdClienteVenda.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdClienteVenda.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdClienteVenda.CurrentColumn.Key
                Case "editar" : Call EditarCliente()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClienteVenda_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdClienteVenda.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdClienteVenda, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClienteVenda_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdClienteVenda.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdClienteVenda.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClienteVenda_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdClienteVenda.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdClienteVenda.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FORNECEDOR :::"

    Private Sub btnAgruparGridFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridFornecedor.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFornecedor.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdFornecedor.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdFornecedor.GroupByBoxVisible = True
                grdFornecedor.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridFornecedor.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFornecedor
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFornecedor, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridFornecedor.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdFornecedor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFornecedor.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo
            LoadCombo(cboFornecedorPadrao, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
            'Seta Focu
            cboFornecedorPadrao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedorPadrao

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedorPadrao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirFornecedor.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoFornecedor() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirFornecedor.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateFornecedor(btnSalvar.Tag, _
                                                         cboFornecedorPadrao.SelectedValue, _
                                                         txtCodigoFornecedor.Text.Trim, _
                                                         txtQuantidadeMinimaFornecedor.Value, _
                                                         txtMultiploCompraFornecedor.Value, _
                                                         btnInserirFornecedor.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertFornecedor(btnSalvar.Tag, _
                                                         cboFornecedorPadrao.SelectedValue, _
                                                         txtCodigoFornecedor.Text.Trim, _
                                                         txtQuantidadeMinimaFornecedor.Value, _
                                                         txtMultiploCompraFornecedor.Value)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoFornecedor()

                'Carrega Grid
                Call oClsCadProduto.LoadGridFornecedor(grdFornecedor, _
                                                       btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub btnExcluirFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirFornecedor.Click

        'Limpa Erro
        frmMain.errInfo.Clear()

        'Deleta Fornecedor
        Call DeleteFornecedor()

    End Sub

    Private Sub grdFornecedor_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFornecedor.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdFornecedor.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdFornecedor.CurrentColumn.Key
                Case "editar" : Call EditarFornecedor()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFornecedor_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFornecedor.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFornecedor, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFornecedor_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFornecedor.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFornecedor.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFornecedor_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdFornecedor.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFornecedor.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub btnAgruparGridLocalizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridLocalizacao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdLocalizacao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdLocalizacao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdLocalizacao.GroupByBoxVisible = True
                grdLocalizacao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridLocalizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridLocalizacao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdLocalizacao
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdLocalizacao, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridLocalizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridLocalizacao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdLocalizacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDeposito.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDeposito")

            'Carrega Combo
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1")

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirLocalizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirLocalizacao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoLocalizacao() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirLocalizacao.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateLocalizacao(btnSalvar.Tag, _
                                                          cboDeposito.SelectedValue, _
                                                          txtLocalizacao.Text.Trim, _
                                                          btnInserirLocalizacao.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertLocalizacao(btnSalvar.Tag, _
                                                          cboDeposito.SelectedValue, _
                                                          txtLocalizacao.Text.Trim)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovaLocalizacao()

                'Carrega Grid
                Call oClsCadProduto.LoadGridLocalizacao(grdLocalizacao, _
                                                        btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirLocalizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirLocalizacao.Click

        Try

            'Deleta Localização
            Call DeleteLocalizacao()

            'Limpa Formulário
            Call NovaLocalizacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMetodologiaSaidaProdutoEstoque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMetodologiaSaidaProdutoEstoque.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum valor
            If cboMetodologiaSaidaProdutoEstoque.SelectedIndex <> -1 AndAlso cboMetodologiaSaidaProdutoEstoque.SelectedValue = CInt(MetodogoliaControleEstoque.FIFO) Then
                chkControlaLote.CheckState = CheckState.Checked
                chkControlaLote.Enabled = False
                chkControlaDataValidade.Enabled = True
            ElseIf cboMetodologiaSaidaProdutoEstoque.SelectedIndex <> -1 AndAlso cboMetodologiaSaidaProdutoEstoque.SelectedValue = CInt(MetodogoliaControleEstoque.LIFO) Then
                chkControlaLote.CheckState = CheckState.Checked
                chkControlaLote.Enabled = False
                chkControlaDataValidade.Enabled = True
            ElseIf cboMetodologiaSaidaProdutoEstoque.SelectedIndex <> -1 AndAlso cboMetodologiaSaidaProdutoEstoque.SelectedValue = CInt(MetodogoliaControleEstoque.FEFO) Then
                chkControlaLote.CheckState = CheckState.Checked
                chkControlaLote.Enabled = False
                chkControlaDataValidade.CheckState = CheckState.Checked
                chkControlaDataValidade.Enabled = False
            Else
                'chkControlaLote.Enabled = True
                'Call chkControlaLote_CheckStateChanged(chkControlaLote, System.EventArgs.Empty)
                chkControlaLote.CheckState = CheckState.Checked
                chkControlaLote.Enabled = False
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkControlaLote_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkControlaLote.CheckStateChanged

        Try

            'Verifica se foi Selecionado Algum valor
            If chkControlaLote.CheckState = CheckState.Unchecked Then
                chkGeraLoteInterno.Enabled = False : chkGeraLoteInterno.CheckState = CheckState.Unchecked
                txtCaracterLote.Enabled = False : txtCaracterLote.Text = ""
                'chkControlaQualidade.Enabled = False : chkControlaQualidade.CheckState = CheckState.Unchecked
                chkControlaDataFabricacao.Enabled = False : chkControlaDataFabricacao.CheckState = CheckState.Unchecked
                chkControlaDataValidade.Enabled = False : chkControlaDataValidade.CheckState = CheckState.Unchecked
                chkControlaTempoExposicao.Enabled = False : chkControlaTempoExposicao.CheckState = CheckState.Unchecked
                txtTempoMaximoExposicao.Enabled = False : txtTempoMaximoExposicao.Text = "00:00:00"
            Else
                chkGeraLoteInterno.Enabled = True
                'chkControlaQualidade.Enabled = True
                chkControlaDataFabricacao.Enabled = True
                chkControlaDataValidade.Enabled = True
                chkControlaTempoExposicao.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkControlaQualidade_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkControlaQualidade.CheckStateChanged

        Try

            'Verifica se foi Selecionado Algum valor
            If chkControlaQualidade.CheckState = CheckState.Checked Then
                If tabDados.TabPages.Contains(pagQualidade) = False Then tabDados.TabPages.Add(pagQualidade)
            Else
                tabDados.TabPages.Remove(pagQualidade)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkGeraLoteInterno_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkGeraLoteInterno.CheckStateChanged

        Try

            'Verifica se foi Selecionado Algum valor
            If chkGeraLoteInterno.CheckState = False Then
                txtCaracterLote.Enabled = False : txtCaracterLote.Text = ""
            Else
                txtCaracterLote.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkControlaTempoExposicao_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkControlaTempoExposicao.CheckStateChanged

        Try

            'Verifica se foi Selecionado Algum valor
            If chkControlaTempoExposicao.CheckState = False Then
                txtTempoMaximoExposicao.Enabled = False : txtTempoMaximoExposicao.Text = "00:00:00"
            Else
                txtTempoMaximoExposicao.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocalizacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdLocalizacao.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdLocalizacao.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdLocalizacao.CurrentColumn.Key
                Case "editar" : Call EditarLocalizacao()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocalizacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdLocalizacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdLocalizacao, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocalizacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdLocalizacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdLocalizacao.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocalizacao_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdLocalizacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdLocalizacao.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ROTEIRO :::"

    Private Sub btnAgruparGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRoteiro.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRoteiro.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRoteiro.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRoteiro.GroupByBoxVisible = True
                grdRoteiro.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRoteiro.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRoteiro
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRoteiro, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridRoteiro.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdRoteiro)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRoteiro.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRoteiro, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRoteiro.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRoteiro.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdRoteiro.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRoteiro.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: BOM :::"

    Private Sub btnAgruparGridBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridBOM.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdBOM.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdBOM.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdBOM.GroupByBoxVisible = True
                grdBOM.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridBOM.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdBOM
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdBOM, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridBOM.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdBOM)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdBOM.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBOM, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdBOM.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBOM.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdBOM.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdBOM.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: BOM / PRODUÇÃO :::"

    Private Sub btnInserirProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProducao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If Validacao() = True Then

                'Salva Produto
                Call Salvar()

                Select Case tabDados.SelectedTab.Key
                    Case "pagProducaoBOM" : Call NovaBOM()
                    Case "pagProducaoRoteiro" : Call NovoRoteiro()
                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProducao.Click

        Try

            Select Case tabDados.SelectedTab.Key
                Case "pagProducaoBOM" : If trvBOM.Visible = True Then DeleteBOMTreeView() Else DeleteBOMGrid()
                Case "pagProducaoRoteiro" : Call DeleteRoteiro()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirProducao.Click

        Try

            Select Case tabDados.SelectedTab.Key
                Case "pagProducaoBOM" : Call ImprimirBOM()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub btnAgruparGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridQualidade.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdQualidade.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdQualidade.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdQualidade.GroupByBoxVisible = True
                grdQualidade.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridQualidade.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdQualidade
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidade, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridQualidade.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdQualidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCaracteristicaInspecionarQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCaracteristicaInspecionarQualidade.Click

        Try
            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadQualidadeCaracteristicaInspecionar")


            'Carrega Combo
            Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa)

            'Seta Focu
            cboCaracteristicaInspecionarQualidade.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirQualidade.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoQualidade() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirQualidade.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateQualidade(btnSalvar.Tag, _
                                                        cboCaracteristicaInspecionarQualidade.SelectedValue, _
                                                        txtValorNominalQualidade.Text.Trim, _
                                                        txtValorMinimoQualidade.Value, _
                                                        txtValorMaximoQualidade.Value, _
                                                        txtObservacaoQualidade.Text.Trim, _
                                                        grdQualidade.CurrentRow.Cells("codigo").Value)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertQualidade(btnSalvar.Tag, _
                                                        cboCaracteristicaInspecionarQualidade.SelectedValue, _
                                                        txtValorNominalQualidade.Text.Trim, _
                                                        txtValorMinimoQualidade.Value, _
                                                        txtValorMaximoQualidade.Value, _
                                                        txtObservacaoQualidade.Text.Trim)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovaQualidade()

                'Carrega Grid
                Call oClsCadProduto.LoadGridQualidade(grdQualidade, _
                                                      btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirQualidade.Click

        Try

            'Deleta Qualidade
            Call DeleteQualidade()

            'Limpa Formulário
            Call NovaQualidade()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCaracteristicaInspecionarQualidade_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCaracteristicaInspecionarQualidade.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtValorNominalQualidade.Value = 0 : txtValorNominalQualidade.Enabled = False
            txtValorMinimoQualidade.Value = 0 : txtValorMinimoQualidade.Enabled = False
            txtValorMaximoQualidade.Value = 0 : txtValorMaximoQualidade.Enabled = False

            'Verifica se foi Selecionado algum Registro
            If cboCaracteristicaInspecionarQualidade.SelectedIndex > -1 Then

                'Váriaveis Locais
                Dim iCodigoTipoCaracteristicaInspecionar As Integer = CType(LoadDescricao("sp_select_cadastro_basico_qualidade_caracteristicas_inspecionar_tipo " & cboCaracteristicaInspecionarQualidade.SelectedValue & ", " & goUsuario.iEmpresa), Integer)

                'Verifica se é do Tipo Valor
                If iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor Then
                    'Habilita Controles
                    txtValorNominalQualidade.Enabled = True
                    txtValorMinimoQualidade.Enabled = True
                    txtValorMaximoQualidade.Enabled = True
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdQualidade.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdQualidade.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdQualidade.CurrentColumn.Key
                Case "editar" : Call EditarQualidade()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdQualidade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidade, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidade.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdQualidade.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdQualidade.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try
            ImportarPreCadastro()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivo.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivo.SelectedValue)
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoArquivo() = True And IsNumeric(btnSalvar.Tag) = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_cad_item", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_cad_item", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_cad_item", btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoArquivo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            'Deleta Registros
            Call DeleteArquivo()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoArquivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

        Try

            'Limpa Controle
            txtArquivo.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "editar" : Call EditarArquivo()
                Case "visualizar" : Call VisualizarDocumento(grdArquivo.CurrentRow.Cells("path").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTROLES DINÂMICOS :::"

    Private Sub btnAdicionarControle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdicionarControle.Click

        Try

            'Verifica se foi Selecionado o Campo - Grupo de Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim oForm As New frmCadControleAdicionar

            'Seta Parametros
            oForm.Formulario = Me.Name
            oForm.Controle = "grpControleDinamico"
            oForm.Codigo = cboGrupoItem.SelectedValue
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Controles
            Call cboGrupoItem_SelectedIndexChanged(cboGrupoItem, System.EventArgs.Empty)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPosicionar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPosicionar.Click

        Try

            'Verifica o Tipo de Controle
            If grpControleDinamico.Tag = "" Then

                'Permitir Controle Movimentar
                If grpControleDinamico.Controls.Count > 0 Then
                    For Each oControle As Control In grpControleDinamico.Controls
                        If Not TypeOf (oControle) Is Label Then oControle.BackColor = Color.LightYellow
                    Next
                    grpControleDinamico.Tag = "MOVE"
                End If

            Else

                'Exclui Controles
                If grpControleDinamico.Controls.Count > 0 Then
                    For Each oControle As Control In grpControleDinamico.Controls
                        If Not TypeOf (oControle) Is Label Then
                            oControle.BackColor = Color.White
                            'Atualiza Controle
                            Call UpdatePosicaoControle(Me.Name, _
                                                       oControle.Parent.Name,
                                                       oControle.Name, _
                                                       oControle.Location.X, _
                                                       oControle.Location.Y, _
                                                       oControle.Size.Width)
                        End If
                    Next
                    grpControleDinamico.Tag = ""
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE CUSTO :::"

    Private Sub btnAgruparGridCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCentroCusto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCentroCusto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCentroCusto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCentroCusto.GroupByBoxVisible = True
                grdCentroCusto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCentroCusto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCentroCusto
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCentroCusto, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCentroCusto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCentroCusto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroCusto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo
            LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroCusto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroCusto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirCentroCusto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoCentroCusto() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirCentroCusto.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateCentroCusto(btnSalvar.Tag, _
                                                          cboCentroCusto.SelectedValue, _
                                                          btnInserirCentroCusto.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertCentroCusto(btnSalvar.Tag, _
                                                          cboCentroCusto.SelectedValue)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoCentroCusto()

                'Carrega Grid
                Call oClsCadProduto.LoadGridCentroCusto(grdCentroCusto, _
                                                       btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCentroCusto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta CentroCusto
            Call DeleteCentroCusto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCentroCusto.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdCentroCusto.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdCentroCusto.CurrentColumn.Key
                Case "editar" : Call EditarCentroCusto()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCentroCusto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCentroCusto, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCentroCusto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCentroCusto.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdCentroCusto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCentroCusto.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTA CONTÁBIL :::"

    Private Sub btnAgruparGridContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContaContabil.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContaContabil.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContaContabil.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContaContabil.GroupByBoxVisible = True
                grdContaContabil.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContaContabil.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContaContabil
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContaContabil, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContaContabil.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContaContabil)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirContaContabil.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoContaContabil() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirContaContabil.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateContaContabil(btnSalvar.Tag, _
                                                          cboContaContabil.SelectedValue, _
                                                          btnInserirContaContabil.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertContaContabil(btnSalvar.Tag, _
                                                          cboContaContabil.SelectedValue)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoContaContabil()

                'Carrega Grid
                Call oClsCadProduto.LoadGridContaContabil(grdContaContabil, _
                                                       btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirContaContabil.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta ContaContabil
            Call DeleteContaContabil()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContaContabil.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdContaContabil.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdContaContabil.CurrentColumn.Key
                Case "editar" : Call EditarContaContabil()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContaContabil.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContaContabil, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContaContabil.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContaContabil.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdContaContabil.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContaContabil.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: EMBALAGEM :::"

    Private Sub btnAgruparGridEmbalagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridEmbalagem.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdEmbalagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdEmbalagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdEmbalagem.GroupByBoxVisible = True
                grdEmbalagem.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridEmbalagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridEmbalagem.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEmbalagem
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEmbalagem, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridEmbalagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridEmbalagem.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdEmbalagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarEmbalagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarEmbalagem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadEmbalagem")

            'Carrega Combo
            LoadCombo(cboEmbalagem, "sp_select_combo_cadastro_basico_embalagem " & goUsuario.iEmpresa)

            'Seta Focu
            cboEmbalagem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirEmbalagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEmbalagem.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoEmbalagem() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirEmbalagem.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateEmbalagem(btnSalvar.Tag, _
                                                        cboEmbalagem.SelectedValue, _
                                                        txtQuantidadeEmbalagem.Value, _
                                                        btnInserirEmbalagem.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertEmbalagem(btnSalvar.Tag, _
                                                        cboEmbalagem.SelectedValue, _
                                                        txtQuantidadeEmbalagem.Value)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoEmbalagem()

                'Carrega Grid
                Call oClsCadProduto.LoadGridEmbalagem(grdEmbalagem, _
                                                       btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirEmbalagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEmbalagem.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Embalagem
            Call DeleteEmbalagem()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub



    Private Sub grdEmbalagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEmbalagem.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdEmbalagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdEmbalagem.CurrentColumn.Key
                Case "editar" : Call EditarEmbalagem()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmbalagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEmbalagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEmbalagem, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmbalagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEmbalagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEmbalagem.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmbalagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdEmbalagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEmbalagem.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FATOR CONVERSÃO :::"

    Private Sub btnAgruparGridUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridUnidadeMedida.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdUnidadeMedida.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdUnidadeMedida.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdUnidadeMedida.GroupByBoxVisible = True
                grdUnidadeMedida.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridUnidadeMedida.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdUnidadeMedida
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdUnidadeMedida, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridUnidadeMedida.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdUnidadeMedida)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirUnidadeMedida.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do UnidadeMedida
            If ValidacaoUnidadeMedida() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirUnidadeMedida.Tag) Then

                    'Atualiza Registro
                    Call oClsCadProduto.UpdateFatorConversao(btnSalvar.Tag, _
                                                             cboUnidadeMedidaOrigem.SelectedValue, _
                                                             cboUnidadeMedidaDestino.SelectedValue, _
                                                             txtFatorConversao.Value, _
                                                             btnInserirUnidadeMedida.Tag)

                Else

                    'Insere Registro
                    Call oClsCadProduto.InsertFatorConversao(btnSalvar.Tag, _
                                                             cboUnidadeMedidaOrigem.SelectedValue, _
                                                             cboUnidadeMedidaDestino.SelectedValue, _
                                                             txtFatorConversao.Value)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoUnidadeMedida()

                'Carrega Grid
                Call oClsCadProduto.LoadGridFatorConversao(grdUnidadeMedida, btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirUnidadeMedida.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta UnidadeMedida
            Call DeleteUnidadeMedida()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdUnidadeMedida_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdUnidadeMedida.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdUnidadeMedida.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdUnidadeMedida.CurrentColumn.Key
                Case "editar" : Call EditarUnidadeMedida()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdUnidadeMedida_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdUnidadeMedida.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdUnidadeMedida, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdUnidadeMedida_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdUnidadeMedida.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdUnidadeMedida.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdUnidadeMedida_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdUnidadeMedida.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdUnidadeMedida.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadProduto_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Limpa Tag
            grdListagem.Tag = ""

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridBOM.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridClienteVenda.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridLocalizacao.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridRoteiro.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridEmbalagem.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnEditarGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate)

            'Verifica Direito - Botão Cadastro
            btnCadastrarFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarGrupoItem.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcInsert)
            btnCadastrarNCM.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcInsert)
            btnCadastrarUnidadeMedidaOrigem.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarUnidadeMedidaDestino.Enabled = btnCadastrarUnidadeMedidaOrigem.Enabled
            btnCadastrarUnidadeMedidaEstoque.Enabled = btnCadastrarUnidadeMedidaOrigem.Enabled
            btnCadastrarUnidadeMedidaCompra.Enabled = btnCadastrarUnidadeMedidaOrigem.Enabled
            btnCadastrarUnidadeMedidaVenda.Enabled = btnCadastrarUnidadeMedidaOrigem.Enabled
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)
            btnCadastrarCaracteristicaInspecionarQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoQualidadeCaracteristicasInspecionar, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)
            btnCadastrarMarca.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoMarca, gcInsert)
            btnCadastrarCentroCusto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
            btnCadastrarEmbalagem.Enabled = VerificaDireito(Formulario.CadastroBasicoEmbalagem, gcInsert)

            'Oculta Controle
            btnInserirProducao.Visible = False
            btnExcluirProducao.Visible = False
            btnImprimirProducao.Visible = False

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboGrupoItemFiltro : oComboBox(1) = cboGrupoItem
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            oComboBox(0) = cboMarcaFiltro : oComboBox(1) = cboMarca
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
            ReDim oComboBox(5) : oComboBox(0) = cboUnidadeMedidaOrigem : oComboBox(1) = cboUnidadeMedidaDestino : oComboBox(2) = cboUnidadeMedidaEstoque : oComboBox(3) = cboUnidadeMedidaCompra : oComboBox(4) = cboUnidadeMedidaVenda : oComboBox(5) = cboUnidadeMedidaUsoConsumo
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1")
            LoadCombo(cboCodigoNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            LoadCombo(cboFornecedorPadrao, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
            LoadCombo(cboOrigemItem, "sp_select_combo_static_origem_item")
            LoadCombo(cboTipoItemSped, "sp_select_combo_static_tipo_item_sped")
            LoadCombo(cboFormaVenda, "sp_select_combo_static_forma_venda_item " & CInt(TipoItem.produto))
            LoadCombo(cboGrupoItemComissionamento, "sp_select_combo_venda_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboClienteVenda, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa, False)
            LoadCombo(cboTipoAtivoFixo, "sp_select_combo_static_tipo_ativo_fixo " & goUsuario.iEmpresa, False)
            LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            LoadCombo(cboMetodologiaSaidaProdutoEstoque, "sp_select_combo_static_metodologia_saida_produto_estoque", False)
            LoadCombo(cboEmbalagem, "sp_select_combo_cadastro_basico_embalagem " & goUsuario.iEmpresa)
            LoadComboSimNao(cboInsumoProducaoFiltro)
            LoadComboSimNao(cboControlaQualidadeFiltro)
            LoadComboSimNao(cboInsumoProducao)
            LoadComboSimNao(cboAtivo)
            LoadComboSimNao(cboNecessitaFornecedorHomologado)
            LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            LoadCombo(cboNivelInspecao, "sp_select_combo_static_nivel_inspecao", False)
            LoadCombo(cboTipoPerfil, "sp_select_combo_cadastro_basico_tipo_perfil " & goUsuario.iEmpresa, False)
            LoadCombo(cboMaterial, "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa, False)
            LoadCombo(cboUnidadeMedidaDimensao, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Verifica o Layout do Formulário
            If CType(LoadDescricao("sp_select_static_formulario_usercontrol " & Formulario.CadastroBasicoProdutoBOM), String) = "usrCadProdutoBOM" Then
                grdBOM.Visible = True
                btnConfigurarGridBOM.Visible = True
                btnAgruparGridBOM.Visible = True
                btnExcelGridBOM.Visible = True
                trvBOM.Visible = False
            Else
                grdBOM.Visible = False
                btnConfigurarGridBOM.Visible = False
                btnAgruparGridBOM.Visible = False
                btnExcelGridBOM.Visible = False
                trvBOM.Visible = True
            End If

            'Prepara Formulário
            Novo()

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Remove(pagHistoricoCompra)
            tabMain.TabPages.Remove(pagHistoricoOrcamento)
            tabMain.TabPages.Remove(pagHistoricoVenda)
            tabMain.TabPages.Remove(pagHistoricoProducao)
            tabMain.TabPages.Remove(pagMovimentacaoEstoque)
            tabDados.TabPages.Remove(pagQualidade)

            'Configura Grid
            ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdClienteVenda, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdFornecedor, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdRoteiro, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdBOM, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdLocalizacao, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdArquivo, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdEmbalagem, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdCentroCusto, Formulario.CadastroBasicoProduto)
            ConfiguraGrid(grdContaContabil, Formulario.CadastroBasicoProduto)

            'Seta os textos
            pagDadosGerais.Text = "Dados Gerais"
            pagClassificacao.Text = "Classificação"
            pagVenda.Text = "Venda"
            pagEstoque.Text = "Estoque"
            pagCompra.Text = "Compra"

            pagArquivos.Text = "Arquivos"
            pagAtivoFixo.Text = "Ativo Fixo"
            pagCentroCusto.Text = "Centro Custo"
            pagContaContabil.Text = "Conta Contábil"
            pagControlesDinamicos.Text = "Controles Dinâmicos"

            pagEmbalagem.Text = "Embalagem"
            pagRecebimento.Text = "Recebimento"
            pagFatorConversao.Text = "Fator Conversão"
            pagHistoricoCompra.Text = "Histórico de Compra"
            pagHistoricoVenda.Text = "Histórico de Venda"
            pagHistoricoOrcamento.Text = "Histórico de Orçamento"
            pagHistoricoProducao.Text = "Histórico de Produção"
            pagMovimentacaoEstoque.Text = "Movimentação do Estoque"
            pagProducaoBOM.Text = "BOM"
            pagProducaoRoteiro.Text = "Roteiro"
            pagQualidade.Text = "Qualidade"
            pagReferenciasMultiplas.Text = "Referências Múltiplas"

            'Seta Focu
            cboGrupoItemFiltro.Focus()

            Try
                tabMain.TabPages.Remove(pagArquivos)
            Catch ex As Exception

            End Try


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadProduto.Delete()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigo As Long)

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Adiciona Aba
                tabMain.TabPages.Add(pagDados)

                'Seta Controle
                btnSalvar.Tag = lCodigo

                'Carrega Controles
                oClsCadProduto.LoadControles(lCodigo,
                                             cboGrupoItem,
                                             txtCodigo,
                                             txtCodigo2,
                                             txtCodigoEAN,
                                             txtDescricao,
                                             cboMarca,
                                             txtDescricao2,
                                             txtReferencia,
                                             cboAtivo,
                                             cboCodigoNCM,
                                             cboInsumoProducao,
                                             txtPesoLiquido,
                                             cboOrigemItem,
                                             cboTipoItemSped,
                                             txtObservacao,
                                             picFoto,
                                             cboUnidadeMedidaVenda,
                                             cboFormaVenda,
                                             cboGrupoItemComissionamento,
                                             cboUnidadeMedidaCompra,
                                             txtLeadTime,
                                             cboNecessitaFornecedorHomologado,
                                             txtQuantidadeMinima,
                                             txtMultiploCompra,
                                             txtToleranciaQuantidadeRecebimento,
                                             txtToleranciaValorRecebimento,
                                             txtToleranciaDiasRecebimento,
                                             cboUnidadeMedidaEstoque,
                                             txtEstoqueMinimo,
                                             txtEstoqueMaximo,
                                             cboMetodologiaSaidaProdutoEstoque,
                                             chkControlaLote,
                                             chkGeraLoteInterno,
                                             txtCaracterLote,
                                             chkControlaQualidade,
                                             chkControlaDataValidade,
                                             chkControlaDataFabricacao,
                                             chkControlaTempoExposicao,
                                             txtTempoMaximoExposicao,
                                             txtPercentualDesvalorizacao,
                                             txtFrequenciaDesvalorizacao,
                                             cboTipoAtivoFixo,
                                             chkItemEstoque,
                                             chkItemCompra,
                                             chkItemVenda,
                                             chkItemProducao,
                                             chkAtivoFixo,
                                             txtValor,
                                             txtCor,
                                             txtBitola,
                                             txtCodigoIntegracao,
                                             txtTipoVenda,
                                             txtVidaUtilBem,
                                             txtTaxaDepreciacaoAnual,
                                             txtTaxaDepreciacaoMensal,
                                             txtValorBem,
                                             txtValorImpostosRecuperaveis,
                                             txtValorResidual,
                                             txtValorDepreciavel,
                                             txtValorDepreciacaoAnual,
                                             txtValorDepreciacaoMensal,
                                             txtControlePatrimonial,
                                             cboNivelInspecao,
                                             txtEstoqueMinimoUsoConsumo,
                                             cboUnidadeMedidaUsoConsumo,
                                             cboTipoPerfil,
                                             cboMaterial,
                                             txtMedida1,
                                             txtMedida2,
                                             txtMedida3,
                                             txtMedida4,
                                             cboUnidadeMedidaDimensao)

                'Carrega Grid - Fornecedor
                Call oClsCadProduto.LoadGridFornecedor(grdFornecedor, btnSalvar.Tag)

                'Carrega Grid de Venda - Cliente
                Call oClsCadProduto.LoadGridCliente(grdClienteVenda, btnSalvar.Tag)

                'Carrega Grid - Localização
                Call oClsCadProduto.LoadGridLocalizacao(grdLocalizacao, btnSalvar.Tag)

                'Carrega Grid - Centro de Custo
                Call oClsCadProduto.LoadGridCentroCusto(grdCentroCusto, btnSalvar.Tag)

                'Carrega Grid - Conta Contábil
                Call oClsCadProduto.LoadGridContaContabil(grdContaContabil, btnSalvar.Tag)

                'Carrega Grid - Fator Conversao
                Call oClsCadProduto.LoadGridFatorConversao(grdUnidadeMedida, btnSalvar.Tag)

                'Carrega BOM - GRID
                Call oClsCadProduto.LoadGridBOM(grdBOM, btnSalvar.Tag)
                'Limpa TreeView
                trvBOM.Nodes.Clear()
                'Carrega BOM - TreeView
                Call oClsCadProduto.LoadTreeViewBOM(trvBOM, btnSalvar.Tag)
                'Expande os Nós
                trvBOM.ExpandAll()

                'Carrega a Grid - Roteiro
                Call oClsCadProduto.LoadGridRoteiro(grdRoteiro, btnSalvar.Tag, -1)

                'Carrega Grid - Qualidade
                Call oClsCadProduto.LoadGridQualidade(grdQualidade, btnSalvar.Tag)

                'Carrega Grid - Arquivo
                Call LoadGridArquivoBD(grdArquivo, "tb_cad_item", btnSalvar.Tag)

                'Carrega Grid - Embalagem
                Call oClsCadProduto.LoadGridEmbalagem(grdEmbalagem, btnSalvar.Tag)

                Call oClsCadProduto.LoadGridReferencia(grdReferencia,
                                                       btnSalvar.Tag)

                'Carrega Grid - Histórico de Compras
                If chkItemCompra.Checked = True Then
                    Call oClsCadProduto.LoadGridHistoricoCompra(grdCompra, btnSalvar.Tag)
                    tabMain.TabPages.Add(pagHistoricoCompra)
                End If

                'Carrega Grid - Histórico de Orçamentos / Venda
                If chkItemVenda.Checked = True Then
                    Call oClsCadProduto.LoadGridHistoricoOrcamento(grdOrcamento, btnSalvar.Tag)
                    Call oClsCadProduto.LoadGridHistoricoVenda(grdPedidoVenda, btnSalvar.Tag)
                    tabMain.TabPages.Add(pagHistoricoVenda)
                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.SelectedTab = pagDados

                'Seta Focu
                cboGrupoItem.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Duplicar()

        Try


            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert) = True Then

                'Questiona
                If MsgBox("Deseja duplicar o produto?", MsgBoxStyle.Question + vbYesNo, "Validar duplicar produto") = vbNo Then Exit Sub

                'Váriavel Local
                Dim lCodigoItem As Long

                'Duplica Registro
                Call oClsCadProduto.Duplicar(grdListagem.CurrentRow.Cells.Item("codigo").Value,
                                             lCodigoItem)

                'Edita Registro
                Call Editar(lCodigoItem)

                'Seta Focu
                cboGrupoItem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Insere Registro no Banco de Dados
            oClsCadProduto.InsertNovo()
            btnSalvar.Tag = oClsCadProduto.CodigoProduto

            'Limpa Controles
            cboUnidadeMedidaUsoConsumo.SelectedIndex = -1
            txtEstoqueMinimoUsoConsumo.Value = 0
            cboNivelInspecao.SelectedIndex = -1
            cboNivelInspecao.Enabled = True
            cboGrupoItem.SelectedIndex = -1
            txtValor.Value = 0
            txtCodigo.Text = ""
            txtCodigo2.Text = ""
            txtCodigoEAN.Text = ""
            cboAtivo.SelectedValue = True
            txtDescricao.Text = ""
            cboMarca.SelectedIndex = -1
            txtDescricao2.Text = ""
            txtReferencia.Text = ""
            chkItemEstoque.Checked = False
            chkItemCompra.Checked = False
            chkItemVenda.Checked = False
            If goUsuario.iCodigoTipoEmpresa = CInt(TipoEmpresa.Industria) Then
                chkItemProducao.Checked = False : chkItemProducao.Enabled = True
            Else
                chkItemProducao.Enabled = False
            End If
            chkAtivoFixo.Checked = False
            'Dados Gerais
            cboCodigoNCM.SelectedIndex = -1
            cboInsumoProducao.SelectedValue = False
            txtPesoLiquido.Value = 0
            cboOrigemItem.SelectedIndex = -1
            cboTipoItemSped.SelectedIndex = -1
            txtObservacao.Text = ""
            txtCor.Text = ""
            txtBitola.Text = ""
            txtCodigoIntegracao.Text = ""
            txtTipoVenda.Text = ""
            'Foto
            txtFoto.Text = ""
            txtFoto.Tag = ""
            picFoto.Image = Nothing


            'Dados de Venda
            cboUnidadeMedidaVenda.Text = ""
            cboFormaVenda.SelectedIndex = -1
            cboGrupoItemComissionamento.SelectedIndex = -1

            'Dados de Venda - Cliente
            cboClienteVenda.SelectedIndex = -1
            txtCodigoProdutoCliente.Text = ""
            txtCodigoProdutoCliente2.Text = ""
            btnInserirClienteVenda.Tag = ""
            grdClienteVenda.DataSource = Nothing


            'Referencia multipla 
            grdReferencia.DataSource = Nothing
            txtReferenciaMultipla.Text = ""

            'Dados de Compra
            cboUnidadeMedidaCompra.Text = ""
            txtLeadTime.Value = 0
            cboNecessitaFornecedorHomologado.SelectedIndex = -1
            txtQuantidadeMinima.Value = 0
            txtMultiploCompra.Value = 0
            cboFornecedorPadrao.SelectedIndex = -1
            txtCodigoFornecedor.Text = ""
            txtQuantidadeMinimaFornecedor.Value = 0
            txtMultiploCompraFornecedor.Value = 0
            btnInserirFornecedor.Tag = ""
            grdFornecedor.DataSource = Nothing

            'Recebimento
            txtToleranciaQuantidadeRecebimento.Value = 0
            txtToleranciaValorRecebimento.Value = 0
            txtToleranciaDiasRecebimento.Value = 0

            'Dados de Estoque
            cboUnidadeMedidaEstoque.SelectedIndex = -1
            chkControlaLote.CheckState = CheckState.Unchecked : Call chkControlaLote_CheckStateChanged(chkControlaLote, System.EventArgs.Empty)
            txtEstoqueMinimo.Value = 0
            txtEstoqueMaximo.Value = 0
            cboMetodologiaSaidaProdutoEstoque.Text = ""
            cboDeposito.SelectedIndex = -1
            txtLocalizacao.Text = ""
            btnInserirLocalizacao.Tag = ""
            grdLocalizacao.DataSource = Nothing

            'Dados de Produção
            grdRoteiro.DataSource = Nothing

            'Dado da Estrutura do Produto
            grdBOM.DataSource = Nothing
            trvBOM.Nodes.Clear()

            'Dados dos Arquivos
            txtDescricaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            'Dados de Ativo Fixo
            txtPercentualDesvalorizacao.Value = 0
            txtFrequenciaDesvalorizacao.Value = 0
            cboTipoAtivoFixo.SelectedIndex = -1
            txtVidaUtilBem.Value = 0
            txtTaxaDepreciacaoAnual.Value = 0
            txtTaxaDepreciacaoMensal.Value = 0
            txtValorBem.Value = 0
            txtValorImpostosRecuperaveis.Value = 0
            txtValorResidual.Value = 0
            txtValorDepreciavel.Value = 0
            txtValorDepreciacaoAnual.Value = 0
            txtValorDepreciacaoMensal.Value = 0
            txtControlePatrimonial.Text = 0

            'Dados de Qualidade
            cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
            txtValorNominalQualidade.Value = 0
            txtValorMinimoQualidade.Value = 0
            txtValorMaximoQualidade.Value = 0
            txtObservacaoQualidade.Text = ""
            btnInserirQualidade.Tag = ""
            grdQualidade.DataSource = Nothing

            'Dados de Embalagem
            cboEmbalagem.Text = ""
            txtQuantidadeEmbalagem.Value = 0
            btnInserirEmbalagem.Tag = ""
            grdEmbalagem.DataSource = Nothing

            'Dados de Fator de Conversao
            cboUnidadeMedidaOrigem.Text = ""
            cboUnidadeMedidaDestino.Text = ""
            txtFatorConversao.Value = 0
            btnInserirUnidadeMedida.Tag = ""
            grdUnidadeMedida.DataSource = Nothing

            'Limpa Controles - Classificação
            cboCentroCusto.Text = ""
            cboContaContabil.Text = ""
            grdCentroCusto.DataSource = Nothing
            grdContaContabil.DataSource = Nothing
            grdCompra.DataSource = Nothing

            LimparCamposGroupBox(grpDimensoes)

            'Oculta Abas
            tabDados.TabPages.Remove(pagEstoque)
            tabDados.TabPages.Remove(pagCompra)
            tabDados.TabPages.Remove(pagRecebimento)
            tabDados.TabPages.Remove(pagQualidade)
            tabDados.TabPages.Remove(pagVenda)
            tabDados.TabPages.Remove(pagEmbalagem)
            tabDados.TabPages.Remove(pagProducaoRoteiro)
            tabDados.TabPages.Remove(pagProducaoBOM)
            tabDados.TabPages.Remove(pagAtivoFixo)
            tabDados.TabPages.Remove(pagDimensoes)
            If VerificaDireito(Formulario.CadastroBasicoProdutoControlesDinamicos, gcSelect) = False Then tabDados.TabPages.Remove(pagControlesDinamicos)

            'Controles Dinâmicos
            If Me.Controls.Find("grpControleDinamico", True).Length > 0 Then

                'Carrega Controles
                Dim oControl As Control = Me.Controls.Find("grpControleDinamico", True)(0)

                'Limpa Controles
                For Each oControleLimpar As Control In oControl.Controls

                    'Limpa Controles
                    If TypeOf (oControleLimpar) Is MaskedEditBox Then
                        Dim oMaskedEditBox As MaskedEditBox = oControleLimpar
                        oMaskedEditBox.Text = ""
                    ElseIf TypeOf (oControleLimpar) Is UIComboBox Then
                        Dim oUiComboBox As UIComboBox = oControleLimpar
                        oUiComboBox.SelectedIndex = -1
                    ElseIf TypeOf (oControleLimpar) Is NumericEditBox Then
                        Dim oNumericEditBox As NumericEditBox = oControleLimpar
                        oNumericEditBox.Value = 0
                    End If

                    'Limpa Controle
                    If Not TypeOf (oControleLimpar) Is Label Then oControleLimpar.BackColor = Color.White
                    grpControleDinamico.Tag = ""

                Next

            End If

            'Seta Aba
            tabDados.SelectedTab = pagDadosGerais

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadProduto.CodigoProduto = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadProduto.TipoItem = CInt(TipoItem.produto)
            oClsCadProduto.GrupoItem = IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue)
            oClsCadProduto.CodigoItem = txtCodigo.Text.Trim
            oClsCadProduto.CodigoItem2 = txtCodigo2.Text.Trim
            oClsCadProduto.CodigoBarras = txtCodigoEAN.Text.Trim
            oClsCadProduto.Ativo = cboAtivo.SelectedValue
            oClsCadProduto.Descricao = txtDescricao.Text.Trim
            oClsCadProduto.Referencia = txtReferencia.Text.Trim
            oClsCadProduto.CodigoMarca = IIf(cboMarca.SelectedIndex = -1, -1, cboMarca.SelectedValue)
            oClsCadProduto.Descricao2 = txtDescricao2.Text.Trim
            oClsCadProduto.CodigoNCM = IIf(cboCodigoNCM.SelectedIndex = -1, -1, cboCodigoNCM.SelectedValue)
            oClsCadProduto.InsumoProducao = IIf(cboInsumoProducao.SelectedIndex = -1, 0, cboInsumoProducao.SelectedValue)
            oClsCadProduto.PesoLiquido = txtPesoLiquido.Value
            oClsCadProduto.CodigoOrigemItem = IIf(cboOrigemItem.SelectedIndex = -1, -1, cboOrigemItem.SelectedValue)
            oClsCadProduto.CodigoTipoItemSped = IIf(cboTipoItemSped.SelectedIndex = -1, -1, cboTipoItemSped.SelectedValue)
            oClsCadProduto.CodigoPlanoControle = -1
            oClsCadProduto.CodigoFolhaOperacao = -1
            oClsCadProduto.CodigoEspecificacaoTecnica = -1
            oClsCadProduto.QuantidadeLinhasCertificado = 0
            oClsCadProduto.Observacao = txtObservacao.Text.Trim
            oClsCadProduto.Cor = txtCor.Text.Trim
            oClsCadProduto.Bitola = txtBitola.Value
            oClsCadProduto.TipoVenda = txtTipoVenda.Text.Trim
            oClsCadProduto.CodigoIntegracao = txtCodigoIntegracao.Value
            oClsCadProduto.Foto = picFoto
            oClsCadProduto.FormaVenda = IIf(cboFormaVenda.SelectedIndex = -1, False, cboFormaVenda.SelectedValue)
            oClsCadProduto.CodigoGrupoItemVenda = IIf(cboGrupoItemComissionamento.SelectedIndex = -1, -1, cboGrupoItemComissionamento.SelectedValue)
            oClsCadProduto.LeadTime = txtLeadTime.Value
            oClsCadProduto.NecessitaFornecedorHomologado = IIf(cboNecessitaFornecedorHomologado.SelectedIndex = -1, False, cboNecessitaFornecedorHomologado.SelectedValue)
            oClsCadProduto.ToleranciaQuantidadeRecebimento = txtToleranciaQuantidadeRecebimento.Value
            oClsCadProduto.ToleranciaValorRecebimento = txtToleranciaValorRecebimento.Value
            oClsCadProduto.ToleranciaDiasRecebimento = txtToleranciaDiasRecebimento.Value
            oClsCadProduto.QuantidadeMinima = txtQuantidadeMinima.Value
            oClsCadProduto.MultiploCompra = txtMultiploCompra.Value
            oClsCadProduto.CodigoUnidadeMedidaEstoque = IIf(cboUnidadeMedidaEstoque.SelectedIndex = -1, -1, cboUnidadeMedidaEstoque.SelectedValue)
            oClsCadProduto.EstoqueMinimo = txtEstoqueMinimo.Value
            oClsCadProduto.EstoqueMaximo = txtEstoqueMaximo.Value
            oClsCadProduto.CodigoMetodologiaSaidaProdutoEstoque = IIf(cboMetodologiaSaidaProdutoEstoque.SelectedIndex = -1, -1, cboMetodologiaSaidaProdutoEstoque.SelectedValue)
            oClsCadProduto.ControlaLote = chkControlaLote.Checked
            oClsCadProduto.GeraLoteInterno = chkGeraLoteInterno.Checked
            oClsCadProduto.CaracaterLote = txtCaracterLote.Text.Trim
            oClsCadProduto.ControlaQualidade = chkControlaQualidade.Checked
            oClsCadProduto.ControlaTempoMaximoExposicao = chkControlaTempoExposicao.Checked
            oClsCadProduto.TempoMaximoExposicao = IIf(txtTempoMaximoExposicao.Enabled = False, 0, ((DatePart(DateInterval.Hour, CDate(txtTempoMaximoExposicao.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoMaximoExposicao.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoMaximoExposicao.Text)) / 60)))
            oClsCadProduto.ControlaValidade = chkControlaDataValidade.Checked
            oClsCadProduto.ControlaDataFabricacao = chkControlaDataFabricacao.Checked
            oClsCadProduto.PercentualDesvalorizacao = txtPercentualDesvalorizacao.Value
            oClsCadProduto.FrequenciaDesvalorizacaoDia = txtFrequenciaDesvalorizacao.Value
            oClsCadProduto.CodigoTipoAtivoFixo = IIf(cboTipoAtivoFixo.SelectedIndex = -1, -1, cboTipoAtivoFixo.SelectedValue)
            oClsCadProduto.Estoque = chkItemEstoque.Checked
            oClsCadProduto.Compra = chkItemCompra.Checked
            oClsCadProduto.Venda = chkItemVenda.Checked
            oClsCadProduto.Producao = chkItemProducao.Checked
            oClsCadProduto.AtivoFixo = chkAtivoFixo.Checked
            oClsCadProduto.CodigoUnidadeMedidaVenda = IIf(cboUnidadeMedidaVenda.SelectedIndex = -1, -1, cboUnidadeMedidaVenda.SelectedValue)
            oClsCadProduto.CodigoUnidadeMedidaCompra = IIf(cboUnidadeMedidaCompra.SelectedIndex = -1, -1, cboUnidadeMedidaCompra.SelectedValue)
            oClsCadProduto.Valor = txtValor.Value
            oClsCadProduto.VidaUtilBem = txtVidaUtilBem.Value
            oClsCadProduto.TaxaDepreciacaoAnual = txtTaxaDepreciacaoAnual.Value
            oClsCadProduto.TaxaDepreciacaoMensal = txtTaxaDepreciacaoMensal.Value
            oClsCadProduto.ValorBem = txtValorBem.Value
            oClsCadProduto.ValorImpostosRecuperaveis = txtValorImpostosRecuperaveis.Value
            oClsCadProduto.ValorResidual = txtValorResidual.Value
            oClsCadProduto.ValorDepreciavel = txtValorDepreciavel.Value
            oClsCadProduto.ValorDepreciacaoAnual = txtValorDepreciacaoAnual.Value
            oClsCadProduto.ValorDepreciacaoMensal = txtValorDepreciacaoMensal.Value
            oClsCadProduto.ControlePatrimonial = txtControlePatrimonial.Text
            oClsCadProduto.CodigoNivelInspecao = IIf(cboNivelInspecao.SelectedIndex = -1, -1, cboNivelInspecao.SelectedValue)
            oClsCadProduto.EstoqueMinimoUsoConsumo = txtEstoqueMinimoUsoConsumo.Value
            oClsCadProduto.CodigoUnidadeMedidaUsoConsumo = IIf(cboUnidadeMedidaUsoConsumo.SelectedIndex = -1, -1, cboUnidadeMedidaUsoConsumo.SelectedValue)
            oClsCadProduto.CodigoTipoPerfil = IIf(cboTipoPerfil.SelectedIndex = -1, -1, cboTipoPerfil.SelectedValue)
            oClsCadProduto.CodigoMaterial = IIf(cboMaterial.SelectedIndex = -1, -1, cboMaterial.SelectedValue)
            oClsCadProduto.Medida1 = txtMedida1.Value
            oClsCadProduto.Medida2 = txtMedida2.Value
            oClsCadProduto.Medida3 = txtMedida3.Value
            oClsCadProduto.Medida4 = txtMedida4.Value
            oClsCadProduto.CodigoUnidadeMedidaDimensao = IIf(cboUnidadeMedidaDimensao.SelectedIndex = -1, -1, cboUnidadeMedidaDimensao.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then

                'Atualiza Item
                oClsCadProduto.Update()

                'Exclui Dados dos Controle
                DeletaDadosControle("tb_cad_item", btnSalvar.Tag)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                'Insere Item
                oClsCadProduto.Insert()

                'Obtém Código
                btnSalvar.Tag = oClsCadProduto.CodigoProduto


                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            'Insere Dados Dinâmicos
            If Me.Controls.Find("grpControleDinamico", True).Length > 0 Then

                Dim oControl As Control = Me.Controls.Find("grpControleDinamico", True)(0)
                For Each oControleSalvar As Control In oControl.Controls

                    If TypeOf (oControleSalvar) Is MaskedEditBox Then
                        Dim oMaskedEditBox As MaskedEditBox = oControleSalvar
                        Call SalvaDadosControle("tb_cad_item", _
                                                btnSalvar.Tag, _
                                                oMaskedEditBox.Name, _
                                                oMaskedEditBox.Text.Trim)

                    ElseIf TypeOf (oControleSalvar) Is UIComboBox Then
                        Dim oUiComboBox As UIComboBox = oControleSalvar
                        If oUiComboBox.SelectedIndex > -1 Then
                            Call SalvaDadosControle("tb_cad_item", _
                                                    btnSalvar.Tag, _
                                                    oUiComboBox.Name, _
                                                    oUiComboBox.SelectedValue)
                        End If

                    ElseIf TypeOf (oControleSalvar) Is NumericEditBox Then
                        Dim oNumericEditBox As NumericEditBox = oControleSalvar
                        oNumericEditBox.Value = 0
                        Call SalvaDadosControle("tb_cad_item", _
                                                btnSalvar.Tag, _
                                                oNumericEditBox.Name, _
                                                oNumericEditBox.Value)
                    End If

                Next


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
            oClsCadProduto.LoadGrid(grdListagem, _
                                    IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                    txtCodigoFiltro.Text.Trim, _
                                    txtCodigo2Filtro.Text.Trim, _
                                    txtCodigoEANFiltro.Text.Trim, _
                                    IIf(cboInsumoProducaoFiltro.SelectedIndex = -1, -1, IIf(cboInsumoProducaoFiltro.SelectedValue = True, 1, 0)), _
                                    IIf(cboControlaQualidadeFiltro.SelectedIndex = -1, -1, IIf(cboControlaQualidadeFiltro.SelectedValue = True, 1, 0)), _
                                    txtDescricaoFiltro.Text.Trim, _
                                    IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                    txtDescricao2Filtro.Text.Trim)

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

            'Verifica se foi Selecionado o Campo - Grupo do Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                Exit Function
            End If

            'Verifica se não está selecionado o Código
            If txtCodigo.Text.Trim = "" Then

                If MsgBox("Deseja que o sistema gere o Código do Produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    'Gera Número do Part Number e Código do Item

                    txtCodigo.Text = oClsCadProduto.GeraCodigoItem(cboGrupoItem.SelectedValue)

                End If

            End If

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Código preenchido é válido
            If oClsCadProduto.ValidaCodigoProduto(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                  txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código EAN
            If txtCodigoEAN.Text.Trim <> "" Then
                If ValidaCampo(txtCodigoEAN, lblCodigoEAN, TipoCampo.texto) = False Then
                    tabMain.SelectedTab = pagDados
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o item é de venda
            If chkItemVenda.Checked = True Then
                'Verifica se foi Selecionado o Campo - NCM
                If ValidaCampo(cboCodigoNCM, lblCodigoNCM) = False Then
                    tabDados.SelectedTab = pagDadosGerais : cboCodigoNCM.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Insumo de Produção
            If ValidaCampo(cboInsumoProducao, lblInsumoProducao) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboInsumoProducao.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Origem
            If ValidaCampo(cboOrigemItem, lblOrigemItem) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboOrigemItem.Focus()
                Exit Function
            End If

            'Caso Item de Venda
            If chkItemVenda.Checked = True Then

                'Verifica se foi Selecionado o Campo - Unidade de Medida Venda
                If ValidaCampo(cboUnidadeMedidaVenda, lblUnidadeMedidaVenda) = False Then
                    tabDados.SelectedTab = pagVenda : cboUnidadeMedidaVenda.Focus()
                    Exit Function
                End If

                ''Verifica se foi Preenchido o Campo - Fator de Conversao Unidade de Medida Venda
                'If ValidaCampo(txtFatorConversaoUnidadeMedidaVenda, lblFatorConversaoUnidadeMedidaVenda, True) = False Then
                '    tabDados.SelectedTab = pagVenda : txtFatorConversaoUnidadeMedidaVenda.Focus()
                '    Exit Function
                'End If

                'Verifica se foi Selecionado o Campo - Forma de Venda
                If ValidaCampo(cboFormaVenda, lblFormaVenda) = False Then
                    tabDados.SelectedTab = pagVenda : cboFormaVenda.Focus()
                    Exit Function
                End If

            End If

            'Caso Item de Compra
            If chkItemCompra.Checked = True Then

                'Verifica se foi Selecionado o Campo - Unidade de Medida Compra
                If ValidaCampo(cboUnidadeMedidaCompra, lblUnidadeMedidaCompra) = False Then
                    tabDados.SelectedTab = pagCompra : cboUnidadeMedidaCompra.Focus()
                    Exit Function
                End If

                ''Verifica se foi Preenchido o Campo - Fator de Conversao Unidade de Medida Compra
                'If ValidaCampo(txtFatorConversaoUnidadeMedidaCompra, lblFatorConversaoUnidadeMedidaCompra, True) = False Then
                '    tabDados.SelectedTab = pagCompra : txtFatorConversaoUnidadeMedidaCompra.Focus()
                '    Exit Function
                'End If

                'Verifica se foi Preenchido o Campo - Quantidade Mínima
                'If ValidaCampo(txtQuantidadeMinima, lblQuantidadeMinima, True) = False Then
                '    tabDados.SelectedTab = pagCompra : txtQuantidadeMinima.Focus()
                '    Exit Function
                'End If

                'Verifica se foi Preenchido o Campo - Múltiplo de Compra
                'If ValidaCampo(txtMultiploCompra, lblMultiploCompra, True) = False Then
                '    tabDados.SelectedTab = pagCompra : txtMultiploCompra.Focus()
                '    Exit Function
                'End If

                ''Verifica se foi Selecionado o Campo - Necessita Fornecedor Homologado
                'If ValidaCampo(cboNecessitaFornecedorHomologado, lblNecessitaFornecedorHomologado) = False Then
                '    tabDados.SelectedTab = pagCompra : cboNecessitaFornecedorHomologado.Focus()
                '    Exit Function
                'End If

                'Verifica se foi Preenchido o Campo - Tolerância Quantidade - Recebimento
                If ValidaCampo(txtToleranciaQuantidadeRecebimento, lblToleranciaQuantidadeRecebimento, False) = False Then
                    tabDados.SelectedTab = pagRecebimento : txtToleranciaQuantidadeRecebimento.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Tolerância Quantidade - Valor
                If ValidaCampo(txtToleranciaValorRecebimento, lblToleranciaValorRecebimento, False) = False Then
                    tabDados.SelectedTab = pagRecebimento : txtToleranciaValorRecebimento.Focus()
                    Exit Function
                End If

            End If

            'Caso Item de Estoque
            If chkItemEstoque.Checked = True Then

                'Verifica se foi Selecionado o Campo - Unidade de Medida - Estoque
                If ValidaCampo(cboUnidadeMedidaEstoque, lblUnidadeMedidaEstoque) = False Then
                    tabDados.SelectedTab = pagEstoque : cboUnidadeMedidaEstoque.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Estoque Mínimo
                If ValidaCampo(txtEstoqueMinimo, lblEstoqueMinimo, False) = False Then
                    tabDados.SelectedTab = pagEstoque : txtEstoqueMinimo.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Estoque Maximo
                If ValidaCampo(txtEstoqueMaximo, lblEstoqueMaximo, False) = False Then
                    tabDados.SelectedTab = pagEstoque : txtEstoqueMaximo.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Metodologia - Saida de Produto do Estoque - Estoque
                If ValidaCampo(cboMetodologiaSaidaProdutoEstoque, lblMetodologiaSaidaProdutoEstoque) = False Then
                    tabDados.SelectedTab = pagEstoque : cboMetodologiaSaidaProdutoEstoque.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Caracter Lote
                If txtCaracterLote.Enabled = True Then
                    If ValidaCampo(txtCaracterLote, lblCaracterLote, TipoCampo.texto) = False Then
                        tabDados.SelectedTab = pagEstoque : txtCaracterLote.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Tempo Máximo de Exposição
                If txtTempoMaximoExposicao.Enabled = True Then
                    If ValidaCampo(txtTempoMaximoExposicao, lblTempoMaximoExposicao, TipoCampo.hora) = False Then
                        tabDados.SelectedTab = pagEstoque : txtTempoMaximoExposicao.Focus()
                        Exit Function
                    End If
                End If

            End If

            'Verifica se foi Preenchido o Campo - Fator de Conversão
            If chkItemCompra.Checked = True And chkItemEstoque.Checked = True Then

                'Váriavel - Query
                Dim sQuery As String = "(codigo_unidade_medida_origem = " & cboUnidadeMedidaCompra.SelectedValue & ") AND (codigo_unidade_medida_destino = " & cboUnidadeMedidaEstoque.SelectedValue & ")"

                'Verifica se existe na Grid de Fator de Conversão a Unidade de Medida de Origem x Destino
                If VerificaExisteValorGrid(grdUnidadeMedida, sQuery) = False Then

                    If cboUnidadeMedidaCompra.SelectedValue <> cboUnidadeMedidaEstoque.SelectedValue Then
                        cboUnidadeMedidaOrigem.SelectedValue = cboUnidadeMedidaCompra.SelectedValue
                        cboUnidadeMedidaDestino.SelectedValue = cboUnidadeMedidaEstoque.SelectedValue
                        frmMain.errInfo.SetError(lblFatorConversao, "Favor preencher o Fator de Conversão e inserir na Tabela.")
                        tabDados.SelectedTab = pagFatorConversao
                        txtFatorConversao.Focus()
                        Exit Function
                    End If

                End If

            End If

            'Verifica se foi Preenchido o Campo - Fator de Conversão
            If chkItemVenda.Checked = True And chkItemEstoque.Checked = True Then

                'Váriavel - Query
                Dim sQuery As String = "(codigo_unidade_medida_origem = " & cboUnidadeMedidaVenda.SelectedValue & ") AND (codigo_unidade_medida_destino = " & cboUnidadeMedidaEstoque.SelectedValue & ")"

                'Verifica se existe na Grid de Fator de Conversão a Unidade de Medida de Origem x Destino
                If VerificaExisteValorGrid(grdUnidadeMedida, sQuery) = False Then

                    If cboUnidadeMedidaVenda.SelectedValue <> cboUnidadeMedidaEstoque.SelectedValue Then
                        cboUnidadeMedidaOrigem.SelectedValue = cboUnidadeMedidaVenda.SelectedValue
                        cboUnidadeMedidaDestino.SelectedValue = cboUnidadeMedidaEstoque.SelectedValue
                        frmMain.errInfo.SetError(lblFatorConversao, "Favor preencher o Fator de Conversão e inserir na Tabela.")
                        tabDados.SelectedTab = pagFatorConversao
                        txtFatorConversao.Focus()
                        Exit Function
                    End If

                End If

            End If

            'Caso Ativo Fixo
            If chkAtivoFixo.Checked = True Then

                'Verifica se foi Preenchido o Campo - Percentual Desvalorização
                If ValidaCampo(txtPercentualDesvalorizacao, lblPercentualDesvalorizacao, True) = False Then
                    tabDados.SelectedTab = pagAtivoFixo : txtPercentualDesvalorizacao.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Frequencia Desvalorização
                If ValidaCampo(txtFrequenciaDesvalorizacao, lblFrequenciaDesvalorizacao, True) = False Then
                    tabDados.SelectedTab = pagAtivoFixo : txtFrequenciaDesvalorizacao.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Tipo de Ativo
                If ValidaCampo(cboTipoAtivoFixo, lblTipoAtivoFixo) = False Then
                    tabDados.SelectedTab = pagAtivoFixo : cboTipoAtivoFixo.Focus()
                    Exit Function
                End If

            End If

            'Se for uso e consumo
            If cboGrupoItem.SelectedValue = 3 Then

                If ValidaCampo(cboUnidadeMedidaUsoConsumo, lblUnidadeMedidaUsoConsumo) = False Then
                    tabDados.SelectedTab = pagUsoConsumo : cboUnidadeMedidaUsoConsumo.Focus()
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CLIENTE :::"

    Private Sub NovoCliente()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboClienteVenda.SelectedIndex = -1
            txtCodigoProdutoCliente.Text = ""
            txtCodigoProdutoCliente2.Text = ""
            btnInserirClienteVenda.Tag = ""

            'Seta Focu
            cboClienteVenda.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteCliente()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdClienteVenda) = True Then


                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui dados da Venda - Cliente
                    Call oClsCadProduto.DeleteCliente(btnSalvar.Tag)

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

    Private Sub EditarCliente()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdClienteVenda.CurrentRow.Cells

                    'Carrega Controles
                    cboClienteVenda.SelectedValue = .Item("codigo_cliente").Value
                    txtCodigoProdutoCliente.Text = .Item("codigo_produto").Value
                    txtCodigoProdutoCliente2.Text = .Item("codigo_produto2").Value
                    btnInserirClienteVenda.Tag = .Item("codigo_cliente").Value

                End With

                'Seta Focu
                cboClienteVenda.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCliente() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCliente = False

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboClienteVenda, lblClienteVenda) = False Then
                Exit Function
            End If

            'Verifica se já existe o Cliente Inserido
            If IsNumeric(btnInserirClienteVenda.Tag) = False Then
                If VerificaExisteValorGrid(grdClienteVenda, "codigo_cliente", cboClienteVenda.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblClienteVenda, "Este Cliente: " & cboClienteVenda.Text & " já se encontra cadastrado para este Produto.")
                    cboClienteVenda.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdClienteVenda, "codigo_cliente", cboClienteVenda.SelectedValue, grdClienteVenda.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblClienteVenda, "Este Cliente: " & cboClienteVenda.Text & " já se encontra cadastrado para este Produto.")
                    cboClienteVenda.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigoProdutoCliente, lblCodigoProdutoCliente, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCliente = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub VisualizarArquivoCliente()

        Try

            'Verifica se existe Arquivo
            If IsDBNull(grdClienteVenda.CurrentRow.Cells("arquivo").Value) = False Then

                If System.IO.File.Exists(grdClienteVenda.CurrentRow.Cells("arquivo").Value) = True Then

                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdClienteVenda.CurrentRow.Cells("arquivo").Value)

                Else
                    'Informa o Usuário que o Arquivo associado não é válido
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            Else
                'Informa o Usuário que não existe Arquivo associado ao Registro
                frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FORNECEDOR :::"

    Private Sub EditarFornecedor()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdFornecedor.CurrentRow.Cells

                    'Carrega Controles
                    cboFornecedorPadrao.SelectedValue = .Item("codigo").Value
                    txtCodigoFornecedor.Text = .Item("codigo_produto").Value
                    btnInserirFornecedor.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboFornecedorPadrao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoFornecedor()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboFornecedorPadrao.SelectedIndex = -1
            txtCodigoFornecedor.Text = ""
            txtQuantidadeMinimaFornecedor.Value = 0
            txtMultiploCompraFornecedor.Value = 0
            btnInserirFornecedor.Tag = ""

            'Seta Focu
            cboFornecedorPadrao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteFornecedor()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdFornecedor) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteFornecedor(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoFornecedor() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFornecedor = False

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedorPadrao, lblFornecedorPadrao) = False Then
                Exit Function
            End If

            'Verifica se já existe o Fornecedor Inserido
            If IsNumeric(btnInserirFornecedor.Tag) = False Then
                If VerificaExisteValorGrid(grdFornecedor, "codigo", cboFornecedorPadrao.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblFornecedorPadrao, "Este Fornecedor: " & cboFornecedorPadrao.Text & " já se encontra cadastrado para este Item.")
                    cboFornecedorPadrao.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdFornecedor, "codigo", cboFornecedorPadrao.SelectedValue, grdFornecedor.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblFornecedorPadrao, "Este Fornecedor: " & cboFornecedorPadrao.Text & " já se encontra cadastrado para este Item.")
                    cboFornecedorPadrao.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoFornecedor = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: LOCALIZAÇÃO :::"

    Private Sub EditarLocalizacao()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdLocalizacao.CurrentRow.Cells

                    'Carrega Controles
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    txtLocalizacao.Text = .Item("localizacao").Value
                    btnInserirLocalizacao.Tag = .Item("codigo_deposito").Value

                End With

                'Seta Focu
                cboDeposito.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovaLocalizacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles 
            cboDeposito.SelectedIndex = -1
            txtLocalizacao.Text = ""
            btnInserirLocalizacao.Tag = ""

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovaReferencia()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles 
            txtReferenciaMultipla.Text = ""
            btnInserirReferencia.Tag = ""

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteLocalizacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdLocalizacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Registro
                    oClsCadProduto.DeleteLocalizacao(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoLocalizacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoLocalizacao = False

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se já existe o Item Inserido
            If grdLocalizacao.GetDataRows.Count > 0 Then
                If IsNumeric(btnInserirLocalizacao.Tag) Then
                    If VerificaExisteValorGrid(grdLocalizacao, "codigo_deposito", cboDeposito.SelectedValue, grdLocalizacao.CurrentRow.RowIndex) = True Then
                        frmMain.errInfo.SetError(lblDeposito, "Este Depósito: " & cboDeposito.Text & " já se encontra cadastrado para este Produto.")
                        cboDeposito.Focus()
                        Exit Function
                    End If
                Else
                    If VerificaExisteValorGrid(grdLocalizacao, "codigo_deposito", cboDeposito.SelectedValue, -1) = True Then
                        frmMain.errInfo.SetError(lblDeposito, "Este Depósito: " & cboDeposito.Text & " já se encontra cadastrado para este Produto.")
                        cboDeposito.Focus()
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Preenchido o Campo - Localização
            If ValidaCampo(txtLocalizacao, lblLocalizacao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoLocalizacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoReferencia() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoReferencia = False

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(txtReferenciaMultipla, lblReferenciaMultipla, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se já existe o Item Inserido
            If grdReferencia.GetDataRows.Count > 0 Then
                If IsNumeric(btnInserirReferencia.Tag) Then
                    If VerificaExisteValorGrid(grdReferencia, "referencia", txtReferenciaMultipla.Text, grdReferencia.CurrentRow.RowIndex) = True Then
                        frmMain.errInfo.SetError(lblReferenciaMultipla, "Esta Referência: " & txtReferenciaMultipla.Text & " já se encontra cadastrado para este Produto.")
                        txtReferenciaMultipla.Focus()
                        Exit Function
                    End If
                Else
                    If VerificaExisteValorGrid(grdReferencia, "referencia", txtReferenciaMultipla.Text, -1) = True Then
                        frmMain.errInfo.SetError(lblReferenciaMultipla, "Esta Referência: " & txtReferenciaMultipla.Text & " já se encontra cadastrado para este Produto.")
                        txtReferenciaMultipla.Focus()
                        Exit Function
                    End If
                End If
            End If


            'Seta Retorno da Função
            ValidacaoReferencia = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ROTEIRO :::"

    Private Sub NovoRoteiro()

        Try

            ReDim oFormularioCadastroBasico(0)
            oFormularioCadastroBasico(0).oValor = btnSalvar.Tag : oFormularioCadastroBasico(0).sControle = "cboProduto"

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProdutoRoteiroProducao", oFormularioCadastroBasico)


            'Carrega a Grid - Roteiro
            Call oClsCadProduto.LoadGridRoteiro(grdRoteiro, _
                                                btnSalvar.Tag, _
                                                -1)


            'Limpa Erro
            frmMain.errInfo.Clear()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRoteiro()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRoteiro) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    'Call oClsCadProduto.DeleteRoteiro(btnSalvar.Tag)

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

#End Region

#Region "::: BOM :::"

    Private Sub NovaBOM()

        Try

            ReDim oFormularioCadastroBasico(2)
            oFormularioCadastroBasico(0).oValor = btnSalvar.Tag : oFormularioCadastroBasico(0).sControle = "cboCodigoProduto"
            oFormularioCadastroBasico(1).oValor = txtDescricao.Text : oFormularioCadastroBasico(1).sControle = "txtDescricao"
            oFormularioCadastroBasico(2).oValor = btnSalvar.Tag : oFormularioCadastroBasico(2).sControle = "btnSalvar"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            'Seta Parâmetros
            oForm.UsrControl = IIf(trvBOM.Visible = True, "usrCadProdutoBOM2", "usrCadProdutoBOM")
            oForm.Tag = btnSalvar.Tag
            oForm.Text = "Produto - BOM"
            oForm.CadastroBasico = oFormularioCadastroBasico
            'Seta Tamanho / Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            If grdBOM.Visible = True Then
                'Carrega a Grid - BOM
                Call oClsCadProduto.LoadGridBOM(grdBOM, btnSalvar.Tag)
            Else
                'Limpa TreeView
                trvBOM.Nodes.Clear()
                'Carrega a TreeView - BOM
                Call oClsCadProduto.LoadTreeViewBOM(trvBOM, btnSalvar.Tag)
                'Expande TreeView
                trvBOM.ExpandAll()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteBOMGrid()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdBOM) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteItemBOM(btnSalvar.Tag)

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

    Private Sub DeleteBOMTreeView()

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoNode(trvBOM) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoNode.Count = 1, "", "s " & gSelecaoNode.Count) & " registro" & IIf(gSelecaoNode.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadProduto.DeleteItemBOMTreeView(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ImprimirBOM()

        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = "rptProducaoFAP.rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.iEmpresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_item"
            goCrystalReport.sReportParameter(1).sValue = btnSalvar.Tag
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill
            'Abre Relatório
            frmMain.LoadPageReport("rptProducaoFAP", "Formulário de Análise de Produção", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub EditarQualidade()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdQualidade.CurrentRow.Cells

                    'Carrega Controles
                    cboCaracteristicaInspecionarQualidade.SelectedValue = .Item("codigo_caracteristica_inspecionar").Value
                    If .Item("codigo_tipo_caracteristica_inspecionar").Value = CInt(QualidadeTipoCaracteristicaInspecionar.Valor) Then
                        txtValorNominalQualidade.Value = .Item("valor_nominal").Value
                        txtValorMinimoQualidade.Value = .Item("valor_minimo").Value
                        txtValorMaximoQualidade.Value = .Item("valor_maximo").Value
                    End If
                    txtObservacaoQualidade.Text = .Item("observacao").Value
                    btnInserirQualidade.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboCaracteristicaInspecionarQualidade.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovaQualidade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles 
            cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
            txtValorNominalQualidade.Value = 0
            txtValorMinimoQualidade.Value = 0
            txtValorMaximoQualidade.Value = 0
            txtObservacaoQualidade.Text = ""
            btnInserirQualidade.Tag = ""

            'Seta Focu
            cboCaracteristicaInspecionarQualidade.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteQualidade()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdQualidade) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Registro
                    oClsCadProduto.DeleteQualidade(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoQualidade() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoQualidade = False

            'Verifica se foi Selecionado o Campo - Caracteristicas a Inspecionar
            If ValidaCampo(cboCaracteristicaInspecionarQualidade, lblCaracteristicaInspecionarQualidade) = False Then
                cboCaracteristicaInspecionarQualidade.Focus()
                Exit Function
            End If

            'Verifica se já existe o Item Inserido
            If grdQualidade.GetDataRows.Count > 0 Then
                If IsNumeric(btnInserirQualidade.Tag) Then
                    If VerificaExisteValorGrid(grdQualidade, "codigo_caracteristica_inspecionar", cboCaracteristicaInspecionarQualidade.SelectedValue, grdQualidade.CurrentRow.RowIndex) = True Then
                        frmMain.errInfo.SetError(lblCaracteristicaInspecionarQualidade, "Esta Caracteristica: " & cboCaracteristicaInspecionarQualidade.Text & " já se encontra cadastrado para este Produto.")
                        cboCaracteristicaInspecionarQualidade.Focus()
                        Exit Function
                    End If
                Else
                    If VerificaExisteValorGrid(grdQualidade, "codigo_caracteristica_inspecionar", cboCaracteristicaInspecionarQualidade.SelectedValue, -1) = True Then
                        frmMain.errInfo.SetError(lblCaracteristicaInspecionarQualidade, "Esta Caracteristica: " & cboCaracteristicaInspecionarQualidade.Text & " já se encontra cadastrado para este Produto.")
                        cboCaracteristicaInspecionarQualidade.Focus()
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Nominal
            If txtValorNominalQualidade.Enabled = True Then
                If ValidaCampo(txtValorNominalQualidade, lblValorNominalQualidade, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Mínimo
            If txtValorMinimoQualidade.Enabled = True Then
                If ValidaCampo(txtValorMinimoQualidade, lblValorMinimoQualidade, True) = False Then
                    Exit Function
                ElseIf txtValorMinimoQualidade.Value > txtValorNominalQualidade.Value Then
                    frmMain.errInfo.SetError(lblValorMinimoQualidade, "O Valor Mínimo não pode ser maior que o Valor Nominal.")
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Máximo
            If txtValorMaximoQualidade.Enabled = True Then
                If ValidaCampo(txtValorMaximoQualidade, lblValorMaximoQualidade, True) = False Then
                    Exit Function
                ElseIf txtValorMaximoQualidade.Value < txtValorNominalQualidade.Value Then
                    frmMain.errInfo.SetError(lblValorMaximoQualidade, "O Valor Máximo não pode ser menor que o Valor Nominal.")
                End If
            End If

            'Seta Retorno da Função
            ValidacaoQualidade = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ImportarPreCadastro()
        Try
            Dim oForm As New frmCadProdutoQualidadeImportar
            oForm.CodigoItem = btnSalvar.Tag
            oForm.ShowDialog()

            oClsCadProduto.LoadGridQualidade(grdQualidade, btnSalvar.Tag)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        modFunction.DeleteArquivoBD("tb_cad_item", oRow.Cells("path").Value, btnSalvar.Tag)
                        oRow.Delete()
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarArquivo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                txtRevisaoArquivo.Text = grdArquivo.CurrentRow.Cells("revisao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = ""
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.RowIndex

                'Seta Focu
                cboTipoArquivo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles            
            txtDescricaoArquivo.Text = ""
            txtRevisaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            'Seta Focu
            txtDescricaoArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoArquivo = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Revisão
            If ValidaCampo(txtRevisaoArquivo, lblRevisaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If IsNumeric(btnInserirArquivo.Tag) = False Then
                If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Produto é Válido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirArquivo.Tag) Then
                iRow = grdArquivo.CurrentRow.RowIndex
            End If

            For Each oRow As GridEXRow In grdArquivo.GetDataRows
                If oRow.Cells("descricao").Value = txtDescricaoArquivo.Text.Trim And oRow.Cells("revisao").Value = txtRevisaoArquivo.Text.Trim And oRow.RowIndex <> iRow Then
                    frmMain.errInfo.SetError(lblDescricaoArquivo, "Esta Descrição / Revisão já se encontra associada a um Registro.")
                    txtDescricaoArquivo.Focus()
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CENTRO DE CUSTO :::"

    Private Sub EditarCentroCusto()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdCentroCusto.CurrentRow.Cells

                    'Carrega Controles
                    cboCentroCusto.SelectedValue = .Item("codigo").Value
                    btnInserirCentroCusto.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboCentroCusto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoCentroCusto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboCentroCusto.Text = ""
            btnInserirCentroCusto.Tag = ""

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteCentroCusto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCentroCusto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteCentroCusto(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoCentroCusto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCentroCusto = False

            'Verifica se foi Selecionado o Campo - CentroCusto
            If ValidaCampo(cboCentroCusto, lblCentroCusto) = False Then
                Exit Function
            End If

            'Verifica se já existe o CentroCusto Inserido
            If IsNumeric(btnInserirCentroCusto.Tag) = False Then
                If VerificaExisteValorGrid(grdCentroCusto, "codigo", cboCentroCusto.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblCentroCusto, "Este Centro de Gasto: " & cboCentroCusto.Text & " já se encontra cadastrado para este Item.")
                    cboCentroCusto.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdCentroCusto, "codigo", cboCentroCusto.SelectedValue, grdCentroCusto.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblCentroCusto, "Este Centro de Gasto: " & cboCentroCusto.Text & " já se encontra cadastrado para este Item.")
                    cboCentroCusto.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoCentroCusto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CONTA CONTÁBIL :::"

    Private Sub EditarContaContabil()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdContaContabil.CurrentRow.Cells

                    'Carrega Controles
                    cboContaContabil.SelectedValue = .Item("codigo").Value
                    btnInserirContaContabil.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboContaContabil.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoContaContabil()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboContaContabil.Text = ""
            btnInserirContaContabil.Tag = ""

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteContaContabil()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdContaContabil) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteContaContabil(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoContaContabil() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoContaContabil = False

            'Verifica se foi Selecionado o Campo - ContaContabil
            If ValidaCampo(cboContaContabil, lblContaContabil) = False Then
                Exit Function
            End If

            'Verifica se já existe o ContaContabil Inserido
            If IsNumeric(btnInserirContaContabil.Tag) = False Then
                If VerificaExisteValorGrid(grdContaContabil, "codigo", cboContaContabil.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblContaContabil, "Esta Conta Contábil: " & cboContaContabil.Text & " já se encontra cadastrado para este Item.")
                    cboContaContabil.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdContaContabil, "codigo", cboContaContabil.SelectedValue, grdContaContabil.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblContaContabil, "Esta Conta Contábil: " & cboContaContabil.Text & " já se encontra cadastrado para este Item.")
                    cboContaContabil.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoContaContabil = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: EMBALAGEM :::"

    Private Sub EditarEmbalagem()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdEmbalagem.CurrentRow.Cells

                    'Carrega Controles
                    cboEmbalagem.SelectedValue = .Item("codigo").Value
                    txtQuantidadeEmbalagem.Value = .Item("quantidade").Value
                    btnInserirEmbalagem.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboEmbalagem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarReferencia()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdReferencia.CurrentRow.Cells

                    'Carrega Controles
                    txtReferenciaMultipla.Text = .Item("referencia").Value
                    btnInserirReferencia.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                txtReferenciaMultipla.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoEmbalagem()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboEmbalagem.Text = ""
            txtQuantidadeEmbalagem.Value = 0
            btnInserirEmbalagem.Tag = ""

            'Seta Focu
            cboEmbalagem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteEmbalagem()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdEmbalagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteEmbalagem(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub DeleteReferencia()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdReferencia) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteReferencia(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoEmbalagem() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEmbalagem = False

            'Verifica se foi Selecionado o Campo - Embalagem
            If ValidaCampo(cboEmbalagem, lblEmbalagem) = False Then
                Exit Function
            End If

            'Verifica se já existe o Embalagem Inserido
            If IsNumeric(btnInserirEmbalagem.Tag) = False Then
                If VerificaExisteValorGrid(grdEmbalagem, "codigo", cboEmbalagem.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblEmbalagem, "Esta Embalagem: " & cboEmbalagem.Text & " já se encontra cadastrado para este Item.")
                    cboEmbalagem.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdEmbalagem, "codigo", cboEmbalagem.SelectedValue, grdEmbalagem.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblEmbalagem, "Esta Embalagem: " & cboEmbalagem.Text & " já se encontra cadastrado para este Item.")
                    cboEmbalagem.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeEmbalagem, lblQuantidadeEmbalagem, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoEmbalagem = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: FATOR CONVERSAO :::"

    Private Sub EditarUnidadeMedida()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                With grdUnidadeMedida.CurrentRow.Cells

                    'Carrega Controles
                    cboUnidadeMedidaOrigem.SelectedValue = .Item("codigo_unidade_medida_origem").Value
                    cboUnidadeMedidaDestino.SelectedValue = .Item("codigo_unidade_medida_destino").Value
                    txtFatorConversao.Value = .Item("fator_conversao").Value
                    btnInserirUnidadeMedida.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboUnidadeMedidaOrigem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoUnidadeMedida()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboUnidadeMedidaOrigem.Text = ""
            cboUnidadeMedidaDestino.Text = ""
            txtFatorConversao.Value = 0
            btnInserirUnidadeMedida.Tag = ""

            'Seta Focu
            cboUnidadeMedidaOrigem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteUnidadeMedida()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdUnidadeMedida) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteFatorConversao(btnSalvar.Tag)

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoUnidadeMedida() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoUnidadeMedida = False

            'Verifica se foi Selecionado o Campo - Unidade Medida - Origem
            If ValidaCampo(cboUnidadeMedidaOrigem, lblUnidadeMedidaOrigem) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade Medida - Destino
            If ValidaCampo(cboUnidadeMedidaDestino, lblUnidadeMedidaDestino) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Fator de Conversão
            If ValidaCampo(txtFatorConversao, lblFatorConversao, True) = False Then
                Exit Function
            End If

            'Váriavel - Query
            Dim sQuery As String = "(codigo_unidade_medida_origem = " & cboUnidadeMedidaOrigem.SelectedValue & ") AND (codigo_unidade_medida_destino = " & cboUnidadeMedidaDestino.SelectedValue & ")"

            'Verifica se existe na Grid de Fator de Conversão a Unidade de Medida de Origem x Destino
            If VerificaExisteValorGrid(grdUnidadeMedida, sQuery) = True Then
                frmMain.errInfo.SetError(lblUnidadeMedidaOrigem, "Este registro já se encontra cadastrado.")
                cboUnidadeMedidaOrigem.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoUnidadeMedida = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class