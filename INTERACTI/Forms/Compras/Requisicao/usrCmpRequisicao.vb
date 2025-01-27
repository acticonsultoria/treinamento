Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrCmpRequisicao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpRequisicao As New clsUsrCmpRequisicao
    Private oClsPrdOrdemProducao As New clsUsrPrdProducaoManual
    Dim iFormulario As Integer = -1
    Dim bExibir As Boolean = False

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCmpRequisicao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try
            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtItemFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarItemFiltro, System.EventArgs.Empty)
                        Case "cboCentroGastoItem" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabilItem" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboUnidadeMedidaItem" : Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
                        Case "cboCentroGastoItem" : Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabilItem" : Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboUnidadeMedidaItem" : Call btnCadastrarUnidadeMedidaItem_Click(btnCadastrarUnidadeMedidaItem, System.EventArgs.Empty)
                        Case "cboCentroGastoItem" : Call btnCadastrarCentroGastoItem_Click(btnCadastrarCentroGastoItem, System.EventArgs.Empty)
                        Case "cboContaContabilItem" : Call btnCadastrarContaContabilItem_Click(btnCadastrarContaContabilItem, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCmpRequisicao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call DeleteRequisicao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = -1
            sItemCompraFind = "S"
            oMaskedEditBoxFind = txtItemFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtItemFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboRequisitante.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Novo()

            cboRequisitante.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Verifica se não foi gerado a Requisição
            If txtNumeroRequisicao.Text = "" And grdItem.GetDataRows.Count > 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

            'Imprime
            Call Imprimir(btnSalvar.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Verifica se não foi gerado a Requisição
            If txtNumeroRequisicao.Text = "" And grdItem.GetDataRows.Count > 0 Then
                'Verifica se o usuário deseja sair do Requisição
                If MsgBox("Os Dados da Requisição serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroRequisicaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboAprovador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRequisitante.SelectedIndexChanged

        Try

            'Carrega Grid
            If cboRequisitante.SelectedIndex = -1 Then
                For Each oRow As GridEXRow In grdItem.GetDataRows
                    Call UpdateRegistroGrid(grdItem, "codigo_item = " & oRow.Cells("codigo_item").Value, "status", oRow.Cells("status_original").Value)
                Next
            Else
                For Each oRow As GridEXRow In grdItem.GetDataRows
                    If oRow.Cells("status").Value = CInt(StatusRequisicaoComprasItem.AguardandoAprovacao) Or
                       oRow.Cells("status").Value = CInt(StatusRequisicaoComprasItem.Aprovado) Then
                        Call UpdateRegistroGrid(grdItem, "codigo_item = " & oRow.Cells("codigo_item").Value, "status", IIf(cboRequisitante.SelectedValue = goUsuario.iUsuario, CInt(StatusRequisicaoComprasItem.Aprovado), CInt(StatusRequisicaoComprasItem.AguardandoAprovacao)))
                    End If
                Next
            End If

            'Atualiza a grid
            grdItem.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.GetValue("codigo"))
                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "historico" : Call Historico()
                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo_interacti").Value)
                Case "arquivo" : Call ListaArquivo("tb_cmp_requisicao", grdListagem.CurrentRow.Cells("codigo").Value)
                Case "alterar" : Call Atualizar()
                Case "cancelar" : Call CancelarItem()
                Case "numero_op" : Call EditarOrdemProducao(sender)
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Verifica Página Atual
            Select Case e.Page.Key

                Case "pagArquivo" : cboCongelarColunaItem.Visible = False : lblCongelarColunaItem.Visible = False
                Case "pagItem" : cboCongelarColunaItem.Visible = True : lblCongelarColunaItem.Visible = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ITEM :::"

    Private Sub cboCentroGastoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroGastoItem.SelectedIndexChanged

        Try

            If cboCentroGastoItem.SelectedValue = 6 Then
                cboOrdemDeProducaoPai.Enabled = False
                cboOrdemDeProducaoPai.BackColor = Color.WhiteSmoke
                cboPartNumberPai.Enabled = False
                cboPartNumberPai.BackColor = Color.WhiteSmoke

            Else
                cboOrdemDeProducaoPai.Enabled = True
                cboOrdemDeProducaoPai.BackColor = Color.White
                cboPartNumberPai.Enabled = True
                cboPartNumberPai.BackColor = Color.White
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub btnQuantidadeAberto_Click(sender As Object, e As EventArgs) Handles btnQuantidadeAberto.Click

        Try

            'Verifica se foi Selecionado o Tipo do Item
            If cboItem.SelectedIndex = -1 Then Exit Sub

            'Váriavel - Formulário de Procurar Item
            Dim oForm As New frmCmpQuantidadeAberto

            'Seta Parametros
            oForm.CodigoItem = cboItem.SelectedValue

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub btnFindGrupoItem_Click(sender As Object, e As EventArgs) Handles btnFindGrupoItem.Click
        Try

            LimparCamposItem()



            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"

            cboGrupoItem.Tag = ""

            'Seta Parametros
            oComboBoxFind = cboItem
            oComboBoxFindGrupoItemProduto = cboGrupoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Se for ferramnenta
            If sGrupoItemFerramentaConcatenado <> "" Then

                txtCodigoProdutoNovo.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_concatenado_ferramenta " & goUsuario.iEmpresa & "," & "'" & sGrupoItemFerramentaConcatenado & "','CODIGO'")
                txtDescricao.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_concatenado_ferramenta " & goUsuario.iEmpresa & "," & "'" & sGrupoItemFerramentaConcatenado & "','DESCRIÇÃO'")

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboGrupoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoItem.SelectedIndexChanged
        Try

            If cboGrupoItem.SelectedIndex = -1 Then Exit Sub
            txtDescricao.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItem.SelectedValue & "," & goUsuario.iEmpresa & ",'SIGLA'")
            txtCodigoProdutoNovo.Text = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & cboGrupoItem.SelectedValue & "," & goUsuario.iEmpresa & ",'CODIGO'")

            Dim iCodigoMaterial As Integer
            Dim icodigoTipoPerfil As Integer

            'Carrega os dados baseado na estrutura de grupo de item
            LoadDadosGrupoItem(cboGrupoItem.SelectedValue,
                               iCodigoTipoPerfil:=icodigoTipoPerfil,
                               iCodigoMaterial:=iCodigoMaterial,
                               iCodigoFamilia:=-1,
                               iCodigoTipoItemSPED:=-1)

            cboGrupoItem.Tag = CStr(icodigoTipoPerfil) & "|" & CStr(iCodigoMaterial)

            LoadMaterial()

            LoadTipoPerfil()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        Try

            'Verifica se Foi Selecionado algum Registro
            If cboItem.SelectedIndex = -1 Then

                cboUnidadeMedidaItem.SelectedIndex = -1
                dtpDataNecessidadeItem.Value = Now.Date : dtpDataNecessidadeItem.Checked = False

                lblCodigoItem.Text = "Código Produto (Novo):" : txtCodigoProdutoNovo.Visible = True : cboItem.Visible = False

            Else

                'Váriaveis Locais
                Dim lCodigoRequisicao As Long = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
                Dim iCodigoRequisicaoItem As Integer
                If IsNumeric(btnInserirItem.Tag) Then iCodigoRequisicaoItem = grdItem.CurrentRow.Cells("codigo_requisicao_item").Value

                'Atualiza Múltiplo de Compra
                Call oClsCmpRequisicao.AtualizaItem(cboItem.SelectedValue)

                'Carrega Dados do Produto
                Call oClsCmpRequisicao.LoadDadosItemRequisicao(lCodigoRequisicao,
                                                               iCodigoRequisicaoItem,
                                                               cboItem,
                                                               cboUnidadeMedidaItem,
                                                               dtpDataNecessidadeItem,
                                                               txtQuantidadeAberto,
                                                               cboGrupoItem)

                'Carrega Combo
                Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboItem.SelectedValue, True)
                Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboItem.SelectedValue, True)

                lblCodigoItem.Text = "Código Produto:" : txtCodigoProdutoNovo.Visible = False : cboItem.Visible = True
                txtDescricao.Text = LoadCodigo("sp_load_cadastro_basico_produto_descricao " & cboItem.SelectedValue & "," & goUsuario.iEmpresa)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboItem.SelectedIndex = -1, -1, cboItem.SelectedValue)
            oComboBoxFind = cboCentroGastoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoItem.Focus()

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
            lCodigoItemFind = IIf(cboItem.SelectedIndex = -1, -1, cboItem.SelectedValue)
            'Seta Parametros
            oComboBoxFind = cboContaContabilItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGastoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo
            If cboItem.SelectedIndex > -1 Then
                Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboItem.SelectedValue, True)
            End If

            'Seta Focu
            cboCentroGastoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUnidadeMedidaItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadeMedidaItem.SelectedIndexChanged

        Try

            Call AtualizarMedida()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub AtualizarMedida()

        Try

            If cboUnidadeMedidaItem.SelectedValue = 2 Then

                txtQuantidadeItem.Value = txtPeso.Value
            Else

                txtQuantidadeItem.Value = txtQtdRequisicao.Value

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo
            If cboItem.SelectedIndex > -1 Then
                Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboItem.SelectedValue, True)
            End If

            'Seta Focu
            cboContaContabilItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirItem.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Item
            If ValidacaoItem() = True Then

                Dim lCodigoItem As Long

                'Se não foi selecionado o produto
                If cboItem.SelectedIndex = -1 Then

                    If txtMedida1.Value = 0 And txtMedida2.Value = 0 And txtMedida3.Value = 0 And txtMedida4.Value = 0 Then

                        lCodigoItem = -1

                    Else

                        lCodigoItem = LoadCodigo("sp_load_lista_material_codigo_item_medidas " &
                                     cboGrupoItem.SelectedValue & ", " &
                                     txtMedida1.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida2.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida3.Value.ToString().Replace(",", ".") & ", " &
                                     txtMedida4.Value.ToString().Replace(",", ".") & ", " &
                                     goUsuario.iEmpresa)

                    End If

                    

                    Dim sCodigoProduto As String = LoadCodigo("sp_load_lista_material_codigo_produto " & lCodigoItem & ", " & goUsuario.iEmpresa)

                    If lCodigoItem = -1 Then

                        'Cadastrar o item e altera o valor da variavel
                        lCodigoItem = oClsPrdOrdemProducao.InsertCadastroBasicoProdutoOP(cboGrupoItem.SelectedValue,
                                                                                         txtDescricao.Text.Trim,
                                                                                         txtCodigoProdutoNovo.Text,
                                                                                         txtMedida1.Value,
                                                                                         txtMedida2.Value,
                                                                                         txtMedida3.Value,
                                                                                         txtMedida4.Value,
                                                                                         cboUnidadeMedidaItem.SelectedValue,
                                                                                         -1,
                                                                                         "")
                        sCodigoProduto = txtCodigoProdutoNovo.Text

                    End If

                    LoadCombo(cboItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",NULL, NULL, -1")
                    cboItem.SelectedValue = lCodigoItem

                End If

                'Salva Dados do Registro
                Call InsertItem()

                'Carrega Item
                Call oClsCmpRequisicao.LoadGridItem(grdItem, btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoItem()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirItem.Click

        Try

            'Deleta Registros
            Call DeleteItem()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColunaItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColunaItem.SelectedIndexChanged

        Try

            If cboCongelarColunaItem.SelectedIndex = -1 Then
                grdItem.FrozenColumns = 2
            Else
                grdItem.FrozenColumns = cboCongelarColunaItem.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdItem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdItem.RowDoubleClick

        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdItem.CurrentColumn) Then Exit Sub

            Select Case grdItem.CurrentColumn.Key

                Case "editar" : Call EditarItem()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, grdItem.ColumnMoved, grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender,
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, grdItem.SizingColumn, grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name,
                                iFormulario,
                                e.Column.Key,
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging, grdItem.GroupsChanging, grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name,
                                     iFormulario,
                                     e.Group.Column.Key,
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Peso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdRequisicao.LostFocus,
                                                                                            txtMedida1.LostFocus,
                                                                                            txtMedida2.LostFocus,
                                                                                            txtMedida3.LostFocus,
                                                                                            txtMedida4.LostFocus,
                                                                                            cboUnidadeMedidaItem.LostFocus

        Try

            CalculaPesoTeorico()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub txtQtdRequisicao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdRequisicao.LostFocus

        Try

            AtualizarMedida()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


    Private Sub btnOcultarExibir_Click(sender As Object, e As EventArgs) Handles btnOcultarExibir.Click

        Try

            bExibir = Not bExibir

            If bExibir = True Then

                grpItem.Visible = False

                grdItem.Location = New Point(grdItem.Location.X, grpItem.Location.Y)
                grdItem.Size = New Size(grdItem.Size.Width, grdItem.Size.Height + grpItem.Size.Height + 8)

            Else

                grpItem.Visible = True

                grdItem.Location = New Point(grdItem.Location.X, grpItem.Location.Y + grpItem.Size.Height + 8)
                grdItem.Size = New Size(grdItem.Size.Width, grdItem.Size.Height - grpItem.Size.Height - 8)

            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnNovoItem_Click(sender As Object, e As EventArgs) Handles btnNovoItem.Click
        Try

            NovoItem()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub


#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoArquivo() = False Then Exit Sub

            SalvarArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            DeleteArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboTipoArquivo_SelectedIndexChanged(sender As Object, e As EventArgs)

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

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : VisualizarArquivo(grdArquivo.GetValue("caminho_arquivo"))

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name,
                                          iFormulario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpRequisicao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnInserirItem.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirItem.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnInserirArquivo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(iFormulario, gcDelete)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarUnidadeMedidaItem.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarCentroGastoItem.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabilItem.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)

            'Carrega ComboBox        
            LoadCombo(cboItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, -1", False)
            LoadCombo(cboStatusRequisicaoFiltro, "sp_select_combo_static_status_requisicao_compras")
            LoadCombo(cboRequisitanteFiltro, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboOrdemDeProducaoPai, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa, False)
            LoadCombo(cboAprovadorFiltro, "sp_select_combo_administracao_usuario_administrador " & goUsuario.iEmpresa & ", " & iFormulario, False)
            LoadCombo(cboRequisitante, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            LoadComboColunasGrid(cboCongelarColunaItem, grdItem)
            LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null, null, -1")

            Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ",null, -1")

            If Len(cboGrupoItem.Tag) > 0 Then
                cboGrupoItem.SelectedValue = cboGrupoItem.Tag
            End If

            If Len(cboItem.Tag) > 0 Then
                cboItem.SelectedValue = cboItem.Tag
            End If

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdItem, iFormulario)
            ConfiguraGrid(grdArquivo, iFormulario)

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            txtNumeroRequisicaoFiltro.Focus()

            If Me.Tag.ToString.Contains("ID:") = True Then
                Editar(Convert.ToInt64(Me.Tag.ToString.Replace("ID:", "")), True)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub Atualizar()

        Try

            Dim oForm As New frmCmpRequisicaoAlterar
            oForm.CodigoRequisicao = grdListagem.CurrentRow.Cells.Item("codigo").Value
            oForm.CodigoRequisicaoItem = grdListagem.CurrentRow.Cells.Item("codigo_requisicao_item").Value

            oForm.ShowDialog()

            'Carrega a grid novamente
            LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarItem()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Verifica se o Usuário pode ou não alterar a Requisição
                If grdListagem.CurrentRow.Cells("codigo_usuario_aprovador").Value = goUsuario.iUsuario Or
                    grdListagem.CurrentRow.Cells("codigo_usuario_requisitante").Value = goUsuario.iUsuario Or
                    VerificaDireito(iFormulario, gcAdministrator) = True Then

                    If ValidacaoCancelarItem() = True Then

                        'Abre Formulário
                        Dim oForm As New frmCmpRequisicaoItemCancelar

                        'Seta Parâmetro
                        oForm.CodigoRequisicao = grdListagem.CurrentRow.Cells("codigo").Value
                        oForm.CodigoRequisicaoItem = grdListagem.CurrentRow.Cells("codigo_requisicao_item").Value
                        oForm.OrigemCancelamento = "Cancelado pelo Comprador: " & goUsuario.sUsuario

                        'Abre Formulário
                        Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                        Call LoadGrid()

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não é o Usuário Requisitante nem o Usuário Aprovador.")
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCancelarItem() As Boolean

        Try

            If IsDBNull(grdListagem.CurrentRow.Cells("codigo_pedido").Value) = False Then
                MsgBox("Não é possível cancelar este item pois existe um pedido de compra para ele.", MsgBoxStyle.Information, "Validação")
                Return False
            End If

            Select Case grdListagem.CurrentRow.Cells("status").Value

                Case 3
                    MsgBox("Não é possível cancelar este item pois existe uma cotação para ele.", MsgBoxStyle.Information, "Validação")
                    Return False
                Case 6
                    MsgBox("Não é possível cancelar este item pois ele já está entregue.", MsgBoxStyle.Information, "Validação")
                    Return False

            End Select

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sStatus As String = ""

            'Status
            If cboStatusRequisicaoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusRequisicaoFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusRequisicaoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsCmpRequisicao.LoadGridRequisicao(grdListagem,
                                                 IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1),
                                                 sStatus,
                                                 IIf(cboRequisitanteFiltro.SelectedIndex = -1, -1, cboRequisitanteFiltro.SelectedValue),
                                                 IIf(cboAprovadorFiltro.SelectedIndex = -1, -1, cboAprovadorFiltro.SelectedValue),
                                                 txtItemFiltro.Text.Trim,
                                                 IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value),
                                                 IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigo As Long,
                       Optional ByVal bCotacao As Boolean = False)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                If bCotacao = False Then

                    'Verifica se o Usuário pode ou não alterar a Requisição
                    If goUsuario.iUsuario <> 1 And (grdListagem.CurrentRow.Cells("codigo_usuario_aprovador").Value <> goUsuario.iUsuario Or
                                                    grdListagem.CurrentRow.Cells("codigo_usuario_requisitante").Value <> goUsuario.iUsuario) Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não é o Usuário Requisitante nem o Usuário Aprovador.")
                        Exit Sub
                    End If

                End If

                Novo()

                btnSalvar.Tag = lCodigo

                oClsCmpRequisicao.LoadControlesRequisicao(btnSalvar.Tag,
                                                          txtNumeroRequisicao,
                                                          cboRequisitante)

                'Carrega Grid de Item
                oClsCmpRequisicao.LoadGridItem(grdItem,
                                               btnSalvar.Tag)

                LoadGridArquivo()

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                If cboRequisitante.Enabled = True Then cboRequisitante.Focus() Else cboGrupoItem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Insere Requisição
            oClsCmpRequisicao.Insert()

            'Limpa Controles - Dados Gerais
            txtNumeroRequisicao.Text = ""
            cboRequisitante.SelectedIndex = -1
            cboRequisitante.Enabled = True
            btnSalvar.Tag = oClsCmpRequisicao.Codigo

            'Limpa Controles - Itens
            LimparCamposItem()
            grdItem.DataSource = Nothing
            btnInserirItem.Tag = ""
            txtQuantidadeItem.Value = 0

            'Limpa Controles - Arquivos
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            VerificaComboCodigoExistente(cboRequisitante, goUsuario.iUsuario)

            'Seleciona Aba
            tabDados.SelectedTab = pagItem

            cboRequisitante.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmpRequisicao.Codigo = btnSalvar.Tag
            oClsCmpRequisicao.CodigoUsuarioAprovador = IIf(cboRequisitante.SelectedIndex = -1, -1, cboRequisitante.SelectedValue)

            'Atualiza Requisição
            oClsCmpRequisicao.Update()

            'Seta Controle
            txtNumeroRequisicao.Text = oClsCmpRequisicao.NumeroRequisicao

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCmpRequisicao.Delete()
                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Aprovador
            If ValidaCampo(cboRequisitante, lblRequisitante) = False Then
                Exit Function
            End If

            'Verifica se foi inserido algum Item
            If grdItem.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir, "Itens")
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Imprimir(ByVal lCodigoRequisicao As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_requisicao"
            goCrystalReport.sReportParameter(1).sValue = lCodigoRequisicao
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000005.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("CMP000000005", "Requisição de Compra", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            'Abre Formulário
            Dim oForm As New frmCmpRequisicaoHistorico

            'Seta Parâmetro
            oForm.NumeroRequisicao = grdListagem.CurrentRow.Cells("numero_requisicao").Value
            oForm.Requisitante = grdListagem.CurrentRow.Cells("requisitante").Value
            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo_item").Value
            oForm.Descricao = grdListagem.CurrentRow.Cells("descricao").Value
            oForm.CodigoRequisicao = grdListagem.CurrentRow.Cells("codigo").Value
            oForm.CodigoRequisicaoItem = grdListagem.CurrentRow.Cells("codigo_requisicao_item").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRequisicao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCmpRequisicao.Delete()
                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais registros!", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub EditarOrdemProducao(ByVal oGrid As GridEX)

        Try


            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(oGrid.CurrentRow.Cells.Item("codigo_ordem_producao").Value)

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ITEM :::"

    Private Sub NovoItem()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            LimparCamposItem()
            btnInserirItem.Tag = ""

            cboGrupoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LimparCamposItem()
        Try

            LimparCamposGroupBox(grpItem)
            cboGrupoItem.Tag = ""
            cboItem.Tag = ""
            txtQuantidadeItem.Value = 1
            txtQtdRequisicao.Value = 1

            LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null, null, -1")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub EditarItem()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Registro pode ser editado
            If grdItem.CurrentRow.Cells("status").Value = CInt(StatusRequisicaoComprasItem.AguardandoAprovacao) Or
                (goUsuario.iUsuario = IIf(cboRequisitante.SelectedIndex = -1, -1, cboRequisitante.SelectedValue) And
                 (grdItem.CurrentRow.Cells("status").Value = CInt(StatusRequisicaoComprasItem.Aprovado) Or
                  grdItem.CurrentRow.Cells("status").Value = CInt(StatusRequisicaoComprasItem.AguardandoAprovacao))) Then

                'Verifica se o usuário tem direito de alterar algum registro
                If VerificaDireito(iFormulario, gcUpdate) = True Then

                    'Carrega Controles
                    cboItem.SelectedValue = grdItem.CurrentRow.Cells.Item("codigo_item").Value
                    txtComplementoItem.Text = IIf(IsDBNull(grdItem.CurrentRow.Cells.Item("complemento").Value), "", grdItem.CurrentRow.Cells.Item("complemento").Value)
                    'txtMarcaItem.Text = IIf(IsDBNull(grdItem.CurrentRow.Cells.Item("marca").Value), "", grdItem.CurrentRow.Cells.Item("marca").Value)
                    txtQuantidadeItem.Value = grdItem.CurrentRow.Cells.Item("quantidade").Value
                    txtPeso.Value = grdItem.CurrentRow.Cells.Item("peso").Value
                    cboUnidadeMedidaItem.SelectedValue = grdItem.CurrentRow.Cells.Item("codigo_unidade_medida").Value
                    If IsDBNull(grdItem.CurrentRow.Cells.Item("data_necessidade").Value) Then dtpDataNecessidadeItem.Value = Now.Date : dtpDataNecessidadeItem.Checked = False Else dtpDataNecessidadeItem.Value = grdItem.CurrentRow.Cells.Item("data_necessidade").Value : dtpDataNecessidadeItem.Checked = True
                    If IsDBNull(grdItem.CurrentRow.Cells.Item("codigo_centro_custo").Value) = False Then cboCentroGastoItem.SelectedValue = grdItem.CurrentRow.Cells.Item("codigo_centro_custo").Value
                    If IsDBNull(grdItem.CurrentRow.Cells.Item("codigo_conta_contabil").Value) = False Then cboContaContabilItem.SelectedValue = grdItem.CurrentRow.Cells.Item("codigo_conta_contabil").Value
                    txtJustificativaItem.Text = IIf(IsDBNull(grdItem.CurrentRow.Cells.Item("justificativa").Value), "", grdItem.CurrentRow.Cells.Item("justificativa").Value)
                    cboPartNumberPai.SelectedValue = grdItem.CurrentRow.Cells.Item("codigo_part_number_pai").Value
                    cboOrdemDeProducaoPai.SelectedValue = grdItem.CurrentRow.Cells.Item("codigo_ordem_producao").Value
                    cboGrupoItem.SelectedValue = grdItem.CurrentRow.Cells.Item("codigo_grupo_item").Value
                    btnInserirItem.Tag = grdItem.CurrentRow.Cells.Row.RowIndex
                    txtObservacao.Text = IIf(IsDBNull(grdItem.CurrentRow.Cells.Item("observacao").Value), "", grdItem.CurrentRow.Cells.Item("observacao").Value)
                    txtObservacaoInterna.Text = IIf(IsDBNull(grdItem.CurrentRow.Cells.Item("observacao_interna").Value), "", grdItem.CurrentRow.Cells.Item("observacao_interna").Value)
                    txtQtdRequisicao.Value = grdItem.CurrentRow.Cells.Item("quantidade_requisicao").Value


                    cboGrupoItem.Focus()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAlteracao)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.RegistroNaoPodeAlterado)
            End If

            Call AtualizarMedida()

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

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirItem.Tag) Then

                'Atualiza Registro da tb_cmp_requisicao_item
                Call oClsCmpRequisicao.UpdateRequisicaoItem(btnSalvar.Tag,
                                                            grdItem.CurrentRow.Cells("codigo_requisicao_item").Value,
                                                            cboItem.SelectedValue,
                                                            txtComplementoItem.Text.Trim,
                                                            IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue),
                                                            IIf(cboContaContabilItem.SelectedIndex = -1, "", cboContaContabilItem.SelectedValue),
                                                            IIf(cboCentroGastoItem.SelectedIndex = -1, -1, cboCentroGastoItem.SelectedValue),
                                                            txtQuantidadeItem.Value,
                                                            txtPeso.Value,
                                                            cboUnidadeMedidaItem.SelectedValue,
                                                            IIf(dtpDataNecessidadeItem.Checked = False, "", dtpDataNecessidadeItem.Value),
                                                            txtJustificativaItem.Text.Trim,
                                                            IIf(cboPartNumberPai.SelectedIndex = -1, -1, cboPartNumberPai.SelectedValue),
                                                            IIf(cboOrdemDeProducaoPai.SelectedIndex = -1, -1, cboOrdemDeProducaoPai.SelectedValue),
                                                            txtObservacao.Text.Trim,
                                                            txtObservacaoInterna.Text.Trim,
                                                            txtQtdRequisicao.Value)

            Else

                'Insere Registro na tb_cmp_requisicao_item
                Call oClsCmpRequisicao.InsertRequisicaoItem(btnSalvar.Tag,
                                                            cboItem.SelectedValue,
                                                            txtComplementoItem.Text.Trim,
                                                            IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue),
                                                            IIf(cboCentroGastoItem.SelectedIndex = -1, -1, cboCentroGastoItem.SelectedValue),
                                                            IIf(cboContaContabilItem.SelectedIndex = -1, "", cboContaContabilItem.SelectedValue),
                                                            txtQuantidadeItem.Value,
                                                            txtPeso.Value,
                                                            cboUnidadeMedidaItem.SelectedValue,
                                                            IIf(dtpDataNecessidadeItem.Checked = False, "", dtpDataNecessidadeItem.Value),
                                                            txtJustificativaItem.Text.Trim,
                                                            IIf(cboPartNumberPai.SelectedIndex = -1, -1, cboPartNumberPai.SelectedValue),
                                                            IIf(cboOrdemDeProducaoPai.SelectedIndex = -1, -1, cboOrdemDeProducaoPai.SelectedValue),
                                                            txtObservacao.Text.Trim,
                                                            txtObservacaoInterna.Text.Trim,
                                                            txtQtdRequisicao.Value)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteItem()

        'Variaveis Locais
        Dim sStatus(0) As String

        Try

            'Seta Váriavel - Status
            sStatus(0) = CInt(StatusRequisicaoComprasItem.AguardandoAprovacao)
            If goUsuario.iUsuario = cboRequisitante.SelectedValue Then
                ReDim Preserve sStatus(2)
                sStatus(1) = CInt(StatusRequisicaoComprasItem.Aprovado)
                sStatus(2) = CInt(StatusRequisicaoComprasItem.Reprovado)
            End If

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdItem, "status", sStatus) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsCmpRequisicao.DeleteRequisicaoItem(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoItem()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione um ou mais Registros com Status válido.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoItem() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoItem = False

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQtdRequisicao, lblQtdRequisicao, True) = False Then Exit Function

            ''Se não foi selecionado o produto
            'If cboItem.SelectedIndex = -1 Then
            '    'Verifica se a Descrição Preenchida é Válida
            '    If oClsCmpRequisicao.ValidaItemRequisicao(cboGrupoItem.SelectedValue,
            '                                                      txtMedida1.Value,
            '                                                      txtMedida2.Value,
            '                                                      txtMedida3.Value,
            '                                                      txtMedida4.Value) = False Then
            '        frmMain.errInfo.SetError(lblDescricao, "Esta Item: " & txtDescricao.Text & " já está associado a outro item cadastrado.")
            '        txtDescricao.Focus()
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedidaItem.Enabled = True Then
                If ValidaCampo(cboUnidadeMedidaItem, lblUnidadeMedidaItem) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Data de Necessidade informada é válida
            If dtpDataNecessidadeItem.Checked = True Then
                If dtpDataNecessidadeItem.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataNecessidadeItem, "A Data de Necessidade não pode ser menor que o dia corrente.")
                    dtpDataNecessidadeItem.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoItem, lblCentroGastoItem) = False Then
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilItem, lblContaContabilItem) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoItem = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadMaterial()

        Try

            txtPesoEspecifico.Value = 0

            Dim sCodigoMaterial As String = -1
            Try
                sCodigoMaterial = cboGrupoItem.Tag.ToString.Split("|")(1)
            Catch ex As Exception

            End Try

            If sCodigoMaterial = "-1" Then Exit Sub

            txtPesoEspecifico.Value = LoadCodigo("sp_load_cadastro_basico_material_densidade " & sCodigoMaterial & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadTipoPerfil()

        Try

            txtMedida1.Enabled = False : txtMedida1.Value = 0
            txtMedida2.Enabled = False : txtMedida2.Value = 0
            txtMedida3.Enabled = False : txtMedida3.Value = 0
            txtMedida4.Enabled = False : txtMedida4.Value = 0

            CalculaPesoTeorico()

            LoadMedidas()

            CalculaPesoTeorico()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaPesoTeorico()
        Try


            If cboGrupoItem.Tag Is Nothing OrElse String.IsNullOrEmpty(cboGrupoItem.Tag.ToString()) Then
                Exit Sub
            End If

            Dim sCodigoTipoPerfil As String = cboGrupoItem.Tag.ToString().Split("|")(0)
            If sCodigoTipoPerfil = "-1" Then
                If cboItem.SelectedIndex <> -1 Then
                    txtDescricao.Text = LoadCodigo("sp_load_cadastro_basico_produto_descricao " & cboItem.SelectedValue & ", " & goUsuario.iEmpresa)
                End If
                Exit Sub
            End If

            Dim sFormula As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_formula " & sCodigoTipoPerfil & ", " & goUsuario.iEmpresa)
            Dim dQuantidade As Double = txtQtdRequisicao.Value
            Dim dMedida1 As Double = txtMedida1.Value
            Dim dMedida2 As Double = txtMedida2.Value
            Dim dMedida3 As Double = txtMedida3.Value
            Dim dMedida4 As Double = txtMedida4.Value
            Dim dPesoEspecifico As Double = txtPesoEspecifico.Value

            Dim sCalculo As String = PreparaCalculo(sFormula,
                                                    dMedida1,
                                                    dMedida2,
                                                    dMedida3,
                                                    dMedida4,
                                                    dPesoEspecifico)

            Dim dPesoCalculado As Double = EvalFormula(sCalculo) * dQuantidade


            txtPeso.Value = dPesoCalculado
            txtDescricao.Text = PreparaDescricao(dMedida1,
                                                 dMedida2,
                                                 dMedida3,
                                                 dMedida4,
                                                 dQuantidade,
                                                 dPesoCalculado,
                                                 cboGrupoItem.SelectedValue)

            Call AtualizarMedida()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function PreparaCalculo(ByVal sFormula As String,
                                    ByVal dMedida1 As Double,
                                    ByVal dMedida2 As Double,
                                    ByVal dMedida3 As Double,
                                    ByVal dMedida4 As Double,
                                    ByVal dPesoEspecifico As Double) As String

        Try

            Dim sCalculo As String = sFormula
            sCalculo = sCalculo.Replace("|MEDIDA_1|", dMedida1.ToString())
            sCalculo = sCalculo.Replace("|MEDIDA_2|", dMedida2.ToString())
            sCalculo = sCalculo.Replace("|MEDIDA_3|", dMedida3.ToString())
            sCalculo = sCalculo.Replace("|MEDIDA_4|", dMedida4.ToString())
            sCalculo = sCalculo.Replace("|PESO_ESP|", dPesoEspecifico.ToString())
            sCalculo = sCalculo.Replace(",", ".")
            Return sCalculo

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function EvalFormula(ByVal sCalculo As String) As Double

        Try

            Dim oScriptControl As New MSScriptControl.ScriptControl
            oScriptControl.Language = "VBScript"
            Return oScriptControl.Eval(sCalculo)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function PreparaDescricao(ByVal dMedida1 As Double,
                                      ByVal dMedida2 As Double,
                                      ByVal dMedida3 As Double,
                                      ByVal dMedida4 As Double,
                                      ByVal dQuantidade As Double,
                                      ByVal dPesoCalculado As Double,
                                      ByVal sGrupoItem As String) As String

        Try

            Dim descricao As String = LoadCodigo("sp_select_cadastro_basico_grupo_item_composicao " & sGrupoItem & ", " & goUsuario.iEmpresa & ", " & "SIGLA")

            'Solicitatção Chamado 6323
            If dMedida1 > 0.0 Then
                If dMedida2 = 0.0 AndAlso dMedida3 = 0.0 AndAlso dMedida4 = 0.0 Then
                    ' Se houver apenas a primeira medida, usa " X "
                    descricao &= " X " & FormatNumber(dMedida1, 2)
                Else
                    ' Se houver mais medidas, usa " - " para a primeira
                    descricao &= " - " & FormatNumber(dMedida1, 2)
                End If
            End If

            descricao &= If(dMedida2 > 0.0, " X " & FormatNumber(dMedida2, 2), "")
            descricao &= If(dMedida3 > 0.0, " X " & FormatNumber(dMedida3, 2), "")
            descricao &= If(dMedida4 > 0.0, " X " & FormatNumber(dMedida4, 2), "")

            If dQuantidade > 0 Then
                descricao &= If(dPesoCalculado > 0.0, "(" & FormatNumber(dPesoCalculado / dQuantidade, 2) & " KG )", "")
            End If
            Return descricao

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ObterGrupo(texto As String) As String

        Try

            Dim ultimaBarra As Integer = texto.LastIndexOf("/")

            If ultimaBarra >= 0 Then
                Dim ultimaParte As String = texto.Substring(ultimaBarra + 1).Trim()
                Return ultimaParte
            Else
                Return texto
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadMedidas()
        Try


            Dim sCodigoTipoPerfil As String = -1

            Dim lCodigoItem As Long
            Dim dMedida1 As Double
            Dim dMedida2 As Double
            Dim dMedida3 As Double
            Dim dMedida4 As Double
            Dim iCodigoUnidadeMedida As Integer
            Dim sGrupoItemFinal As String = ObterGrupo(cboGrupoItem.Text)

            Try
                sCodigoTipoPerfil = cboGrupoItem.Tag.ToString.Split("|")(0)
                If sCodigoTipoPerfil = "-1" Then Exit Sub
            Catch ex As Exception
                Throw ex
            End Try

            Dim iQuantidadeMedidas As Integer = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_quantidade_medidas " & sCodigoTipoPerfil & "," & goUsuario.iEmpresa)
            Dim sMedida1 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 1, " & goUsuario.iEmpresa)
            Dim sMedida2 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 2, " & goUsuario.iEmpresa)
            Dim sMedida3 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 3, " & goUsuario.iEmpresa)
            Dim sMedida4 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & sCodigoTipoPerfil & ", 4, " & goUsuario.iEmpresa)

            lCodigoItem = IIf(cboItem.SelectedIndex = -1, -1, cboItem.SelectedValue)
            'Se tiver selecionado um item, bloqueia todas as medidas 
            If lCodigoItem <> -1 Then HabilitarMedidas(False) Else HabilitarMedidas(True)

            dMedida1 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 1)
            dMedida2 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 2)
            dMedida3 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 3)
            dMedida4 = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 4)
            iCodigoUnidadeMedida = LoadCodigo("sp_load_cadastro_basico_produto_medida " & lCodigoItem & "," & goUsuario.iEmpresa & "," & 5)

            Select Case iQuantidadeMedidas

                Case 1
                    txtMedida1.Enabled = True
                    lblMedida1.Text = sMedida1 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                Case 2
                    txtMedida1.Enabled = True
                    txtMedida2.Enabled = True

                    lblMedida1.Text = sMedida1 + ":"
                    lblMedida2.Text = sMedida2 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                    If IsNumeric(dMedida2) And dMedida2 > 0 Then
                        txtMedida2.Value = dMedida2
                    End If

                Case 3
                    txtMedida1.Enabled = True
                    txtMedida2.Enabled = True
                    txtMedida3.Enabled = True

                    lblMedida1.Text = sMedida1 + ":"
                    lblMedida2.Text = sMedida2 + ":"
                    lblMedida3.Text = sMedida3 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                    If IsNumeric(dMedida2) And dMedida2 > 0 Then
                        txtMedida2.Value = dMedida2
                    End If

                    If IsNumeric(dMedida3) And dMedida3 > 0 Then
                        txtMedida3.Value = dMedida3
                    End If

                Case 4
                    txtMedida1.Enabled = True
                    txtMedida2.Enabled = True
                    txtMedida3.Enabled = True
                    txtMedida4.Enabled = True

                    lblMedida1.Text = sMedida1 + ":"
                    lblMedida2.Text = sMedida2 + ":"
                    lblMedida3.Text = sMedida3 + ":"
                    lblMedida4.Text = sMedida4 + ":"

                    If IsNumeric(dMedida1) And dMedida1 > 0 Then

                        txtMedida1.Value = dMedida1

                    ElseIf IsNumeric(sGrupoItemFinal) Then

                        txtMedida1.ReadOnly = True
                        txtMedida1.BackColor = Color.WhiteSmoke
                        txtMedida1.Text = Convert.ToDouble(sGrupoItemFinal.Replace(",", "."), CultureInfo.InvariantCulture)

                    End If

                    If IsNumeric(dMedida2) And dMedida2 > 0 Then
                        txtMedida2.Value = dMedida2
                    End If

                    If IsNumeric(dMedida3) And dMedida3 > 0 Then
                        txtMedida3.Value = dMedida3
                    End If

                    If IsNumeric(dMedida4) And dMedida4 > 0 Then
                        txtMedida4.Value = dMedida4
                    End If

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HabilitarMedidas(ByVal bHabilitar As Boolean)

        Try

            If bHabilitar = True Then

                txtMedida1.ReadOnly = False
                txtMedida1.BackColor = Color.White

                txtMedida2.ReadOnly = False
                txtMedida2.BackColor = Color.White

                txtMedida3.ReadOnly = False
                txtMedida3.BackColor = Color.White

                txtMedida4.ReadOnly = False
                txtMedida4.BackColor = Color.White

            Else

                'Bloquea os campos de medida
                txtMedida1.ReadOnly = True
                txtMedida1.BackColor = Color.WhiteSmoke

                txtMedida2.ReadOnly = True
                txtMedida2.BackColor = Color.WhiteSmoke

                txtMedida3.ReadOnly = True
                txtMedida3.BackColor = Color.WhiteSmoke

                txtMedida4.ReadOnly = True
                txtMedida4.BackColor = Color.WhiteSmoke

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Function ValidacaoArquivo() As Boolean

        Try

            If ValidaCampo(txtTituloArquivo, lblTituloArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""

            txtTituloArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridArquivo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmpRequisicao.LoadGridArquivo(grdArquivo,
                                              btnSalvar.Tag)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_compras_requisicao " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            oClsCmpRequisicao.InsertArquivo(btnSalvar.Tag,
                                            txtTituloArquivo.Text.Trim,
                                            sFile)

            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsCmpRequisicao.ExcluirArquivo(btnSalvar.Tag)

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

    Private Sub VisualizarArquivo(ByVal sArquivo As String)

        Try

            If sArquivo = "" Then MsgBox("Arquivo Inexistente.", MsgBoxStyle.Exclamation, "Validação") : Exit Sub

            Process.Start(sArquivo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#End Region


End Class


