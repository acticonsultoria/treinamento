Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrEstRequisicaoIssartel

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstRequisicao As New clsUsrEstRequisicao

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrEstRequisicao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                    End Select

                Case Keys.F5
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto))
                        Case "cboMotivoRequisicao" : Call LoadCombo(cboMotivoRequisicao, "sp_select_combo_cadastro_basico_motivo_requisicao_estoque " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboMotivoRequisicao" : Call btnCadastrarMotivo_Click(btnCadastrarMotivo, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstRequisicao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub btnAgruparGridRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRequisicao.Click

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

    Private Sub btnConfigurarGridRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRequisicao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.EstoqueRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

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

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Requisição
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Add(pagDados)
            tabMain.TabPages.Remove(pagListagem)

            'Seta Focu
            dtpDataRequisicao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Seta Focu        
            dtpDataRequisicao.Focus()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            grdProduto.RootTable.RemoveFilter()
            grdProduto.Refresh()

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

            'Verifica se não foi gerado a Requisição
            If txtNumeroRequisicao.Text = "" And grdProduto.GetDataRows.Count > 0 Then
                'Verifica se o usuário deseja sair do Orçamento
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

    Private Sub cboTipoRequisicao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoRequisicao.SelectedIndexChanged

        Try

            'Desabilita Controle
            lblNumeroDocumento.Visible = False
            cboNumeroDocumento.Visible = False
            txtReferencia.Visible = False

            Select Case cboTipoRequisicao.SelectedValue

                Case CInt(TipoRequisicaoEstoque.OrdemServico)
                    lblNumeroDocumento.Text = "Nº Documento:"
                    cboNumeroDocumento.Visible = True
                    lblNumeroDocumento.Visible = True
                    txtReferencia.Visible = False
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_servico_ordem_servico " & goUsuario.iEmpresa)
                Case CInt(TipoRequisicaoEstoque.OrdemProducao)
                    lblNumeroDocumento.Text = "Nº Documento:"
                    cboNumeroDocumento.Visible = True
                    lblNumeroDocumento.Visible = True
                    txtReferencia.Visible = False
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa)
                Case CInt(TipoRequisicaoEstoque.Outros)
                    lblNumeroDocumento.Text = "Referência:"
                    lblNumeroDocumento.Visible = True
                    cboNumeroDocumento.Visible = False
                    txtReferencia.Visible = True
                Case CInt(TipoRequisicaoEstoque.OrdemServicoManutencao)
                    lblNumeroDocumento.Text = "Nº Documento:"
                    cboNumeroDocumento.Visible = True
                    lblNumeroDocumento.Visible = True
                    txtReferencia.Visible = False
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_manutencao_ordem_servico " & goUsuario.iEmpresa & ", " & StatusOrdemServicoManutencao.EmAndamento)
                Case CInt(TipoRequisicaoEstoque.Perda)

                    lblNumeroDocumento.Text = "Motivo:"
                    lblNumeroDocumento.Visible = True
                    cboNumeroDocumento.Visible = False
                    txtReferencia.Visible = True


            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
        'Trata Erro

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "historico" : Call Historico()
                Case "ativar" : Call Ativar()
                Case "cancelar" : Call Cancelar()

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
                                     Formulario.EstoqueRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.EstoqueRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub cboTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoItem.SelectedIndexChanged,
                                                                                           cboTipoItem.SelectedValueChanged
        Try
            If cboTipoItem.SelectedValue = 1 Then

                lblAltura.Visible = True
                txtAltura.Visible = True
                lblComprimento.Visible = True
                txtComprimento.Visible = True
                lblLargura.Visible = True
                txtLargura.Visible = True
                lblUnidadeMedidaDimensao.Visible = True
                cboUnidadeMedidaDimensao.Visible = True
                lblDimensao.Visible = True
                txtDimensao.Visible = True
            Else

                lblAltura.Visible = False
                txtAltura.Visible = False
                txtAltura.Text = 0

                lblComprimento.Visible = False
                txtComprimento.Visible = False
                txtComprimento.Text = 0

                lblLargura.Visible = False
                txtLargura.Visible = False
                txtLargura.Text = 0

                lblUnidadeMedidaDimensao.Visible = False
                cboUnidadeMedidaDimensao.Visible = False
                cboUnidadeMedidaDimensao.SelectedIndex = -1

                lblDimensao.Visible = False
                txtDimensao.Visible = False
                txtDimensao.Text = ""

            End If


        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdProduto.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdProduto.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdProduto.GroupByBoxVisible = True
                grdProduto.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.EstoqueRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.EstoqueRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdProduto)

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
            sItemEstoqueFind = "S"
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, NULL, 1", False)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMotivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMotivo.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMotivoRequisicaoEstoque")

            'Carrega Combo            
            Call LoadCombo(cboMotivoRequisicao, "sp_select_combo_cadastro_basico_motivo_requisicao_estoque " & goUsuario.iEmpresa)

            'Seta Focu
            cboMotivoRequisicao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex = -1 Then
                txtDescricaoProduto.Text = ""
            Else
                Call LoadDescricao(txtDescricaoProduto, "sp_select_cadastro_basico_descricao_item " & cboProduto.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If ValidacaoProduto() = True Then

                'Salva Dados do Registro
                Call InsertProduto()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Dimensao_Changed() Handles txtComprimento.TextChanged, txtLargura.TextChanged, txtAltura.TextChanged

        Try
            txtDimensao.Text = ""

            If txtComprimento.Value > 0 Then

                txtDimensao.Text = txtComprimento.Text

            End If

            If txtLargura.Value > 0 Then

                txtDimensao.Text = txtDimensao.Text + IIf(txtDimensao.Text <> "", " x ", "") + CStr(txtLargura.Text)

            End If


            If txtAltura.Value > 0 Then

                txtDimensao.Text = txtDimensao.Text + IIf(txtDimensao.Text <> "", " x ", "") + CStr(txtAltura.Text)

            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProduto.Click

        Try

            'Deleta Registros
            Call DeleteProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            'Verifica a Coluna Pressionada
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.EstoqueRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.EstoqueRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstRequisicao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.EstoqueRequisicao, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.EstoqueRequisicao, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.EstoqueRequisicao, gcDelete)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.EstoqueRequisicao, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.EstoqueRequisicao, gcDelete)
            btnExcel.Enabled = VerificaDireito(Formulario.EstoqueRequisicao, gcPrint)

            btnExcluir.Visible = False

            'Verifica Direito - Botão de Cadastro
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarMotivo.Enabled = VerificaDireito(Formulario.CadastroBasicoMotivoRequisicaoEstoque, gcInsert)

            'Carrega ComboBox        
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, NULL, 1", False)
            Call LoadCombo(cboMotivoRequisicao, "sp_select_combo_cadastro_basico_motivo_requisicao_estoque " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoRequisicao, "sp_select_combo_static_tipo_requisicao_estoque")
            Call LoadCombo(cboTipoRequisicaoFiltro, "sp_select_combo_static_tipo_requisicao_estoque")
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_requisicao_estoque")
            Call LoadCombo(cboTipoItem, "sp_select_combo_static_tipo_item_bom")
            Call LoadCombo(cboUnidadeMedidaDimensao, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False
            dtpDataRequisicao.Value = Now.Date
            dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Checked = False

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueRequisicao)
            Call ConfiguraGrid(grdProduto, Formulario.EstoqueRequisicao)

            'Seta Focu
            txtNumeroRequisicaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sTipoRequisicao As String = ""
            Dim sStatus As String = ""
            Dim i As Integer

            'Vendedor
            If cboTipoRequisicaoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboTipoRequisicaoFiltro.CheckedValues)
                    sTipoRequisicao &= IIf(sTipoRequisicao = "", "", ",") & cboTipoRequisicaoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            Call oClsEstRequisicao.LoadGrid(grdListagem, _
                                            IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1), _
                                            IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value), _
                                            IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value), _
                                            sTipoRequisicao, _
                                            txtNumeroDocumentoFiltro.Text.Trim, _
                                            txtProdutoFiltro.Text.Trim, _
                                            sStatus)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.EstoqueRequisicao, gcUpdate) = True Then

                If grdListagem.CurrentRow.Cells("status").Value = 3 Then
                    MsgBox("Essa requisição já está finalizada.", MsgBoxStyle.Exclamation, "Validação")
                    Exit Sub
                End If

                'Limpa Formulário
                Call Novo()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Carrega Controles
                Call oClsEstRequisicao.Editar(grdListagem.CurrentRow.Cells("codigo").Value, _
                                              txtNumeroRequisicao, _
                                              dtpDataRequisicao, _
                                              cboTipoRequisicao, _
                                              cboNumeroDocumento, _
                                              txtReferencia)

                'Carrega Grid de Produto
                oClsEstRequisicao.LoadGridProduto(grdProduto, _
                                                  grdListagem.CurrentRow.Cells("codigo").Value)

                'Seta Controle
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                dtpDataRequisicao.Focus()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

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

            'Limpa Controles - Dados Gerais
            txtNumeroRequisicao.Text = ""
            dtpDataRequisicao.Value = Now.Date
            cboTipoRequisicao.SelectedIndex = -1
            lblNumeroDocumento.Visible = False
            cboNumeroDocumento.Visible = False
            cboNumeroDocumento.SelectedIndex = -1
            txtReferencia.Visible = False
            txtReferencia.Text = ""
            btnSalvar.Tag = ""

            'Limpa Controles - Itens
            cboProduto.SelectedIndex = -1
            dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Checked = False
            txtQuantidade.Value = 0
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsEstRequisicao.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsEstRequisicao.DataRequisicao = dtpDataRequisicao.Value
            oClsEstRequisicao.CodigoTipoRequisicao = cboTipoRequisicao.SelectedValue
            oClsEstRequisicao.NumeroDocumento = IIf(cboNumeroDocumento.Visible = False, "", cboNumeroDocumento.Text)
            oClsEstRequisicao.CodigoOrdemProducao = IIf(cboTipoRequisicao.SelectedValue = CInt(TipoRequisicaoEstoque.OrdemProducao), cboNumeroDocumento.SelectedValue, -1)
            oClsEstRequisicao.CodigoOrdemServico = IIf(cboTipoRequisicao.SelectedValue = CInt(TipoRequisicaoEstoque.OrdemServico), cboNumeroDocumento.SelectedValue, -1)
            oClsEstRequisicao.CodigoOrdemServicoManutencao = IIf(cboTipoRequisicao.SelectedValue = CInt(TipoRequisicaoEstoque.OrdemServicoManutencao), cboNumeroDocumento.SelectedValue, -1)
            oClsEstRequisicao.CodigoOrdemPlantio = -1
            oClsEstRequisicao.Referencia = txtReferencia.Text.Trim

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = False Then

                'Insere Registro
                oClsEstRequisicao.Insert()
                oClsEstRequisicao.InsertProdutoIssartel(grdProduto)

                'Seta Número da Requisição
                txtNumeroRequisicao.Text = oClsEstRequisicao.NumeroRequisicao
                btnSalvar.Tag = oClsEstRequisicao.Codigo

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Atualiza Registro
                oClsEstRequisicao.Update()
                'Exclui Produtos da Requisição
                oClsEstRequisicao.DeleteProduto()
                'Insere Produtos na Requisição
                oClsEstRequisicao.InsertProdutoIssartel(grdProduto)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se foi selecionado algum registro
            If (grdListagem.CurrentRow.Cells("quantidade").Value - grdListagem.CurrentRow.Cells("quantidade_paga").Value - grdListagem.CurrentRow.Cells("quantidade_cancelada").Value) > 0 Then

                'Váriavel - Formulário
                Dim oForm As New frmEstRequisicaoCancelar

                'Seta Parâmetros
                oForm.NumeroRequisicao = grdListagem.CurrentRow.Parent.Cells("numero_requisicao").Value
                oForm.DataRequisicao = grdListagem.CurrentRow.Parent.Cells("data").Value
                oForm.TipoRequisicao = grdListagem.CurrentRow.Parent.Cells("tipo_requisicao").Value
                oForm.NumeroDocumento = grdListagem.CurrentRow.Parent.Cells("numero_documento").Value
                oForm.Produto = grdListagem.CurrentRow.Cells("codigo_produto").Value & " - " & grdListagem.CurrentRow.Cells("descricao").Value
                oForm.Quantidade = grdListagem.CurrentRow.Cells("quantidade").Value - grdListagem.CurrentRow.Cells("quantidade_paga").Value - grdListagem.CurrentRow.Cells("quantidade_cancelada").Value
                oForm.CodigoRequisicao = grdListagem.CurrentRow.Parent.Cells("codigo").Value
                oForm.CodigoRequisicaoItem = grdListagem.CurrentRow.Cells("codigo").Value

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Recarrega a Grid
                Call LoadGrid()

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar, "Status da Requisição = Não Atendida")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Ativar()

        Try

            'Verifica o status do Orçamento
            If grdListagem.CurrentRow.Cells("quantidade_cancelada").Value > 0 Then

                'Verifica se o usuário tem direito de Administrador
                If VerificaDireito(Formulario.EstoqueRequisicao, gcAdministrator) = True Then

                    'Verifica se o Usuário deseja Retornar o Status do Orçamento
                    If MsgBox("Deseja tornar Ativo o Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Ativa Orçamento
                        Call oClsEstRequisicao.Ativar(grdListagem.CurrentRow.Parent.Cells("codigo").Value, _
                                                      grdListagem.CurrentRow.Cells("codigo").Value, _
                                                      "REQUISIÇÃO ATIVADA.")

                        'Carrega a Grid
                        Call LoadGrid()

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

            Else
                'Informa o Usuário que o Orçamento não pode ser Cancelado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmEstRequisicaoHistorico

            'Seta Parâmetros
            oForm.NumeroRequisicao = grdListagem.CurrentRow.Parent.Cells("numero_requisicao").Value
            oForm.DataRequisicao = grdListagem.CurrentRow.Parent.Cells("data").Value
            oForm.TipoRequisicao = grdListagem.CurrentRow.Parent.Cells("tipo_requisicao").Value
            oForm.NumeroDocumento = grdListagem.CurrentRow.Parent.Cells("numero_documento").Value
            oForm.Produto = grdListagem.CurrentRow.Cells("codigo_produto").Value & " - " & grdListagem.CurrentRow.Cells("descricao").Value
            oForm.Quantidade = grdListagem.CurrentRow.Cells("quantidade").Value
            oForm.CodigoRequisicao = grdListagem.CurrentRow.Parent.Cells("codigo").Value
            oForm.CodigoRequisicaoItem = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
                    oClsEstRequisicao.Delete()
                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar, "Status da Requisição = Não Atendida")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Tipo de Requisição
            If ValidaCampo(cboTipoRequisicao, lblTipoRequisicao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Nº Documento
            If cboNumeroDocumento.Visible = True Then
                If ValidaCampo(cboNumeroDocumento, lblNumeroDocumento) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi inserido algum Produto
            If grdProduto.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir, "Produtos")
                cboProduto.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO :::"

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Itens
            cboProduto.SelectedIndex = -1
            cboMotivoRequisicao.SelectedIndex = -1
            dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Checked = False
            txtQuantidade.Value = 0
            btnInserirProduto.Tag = ""
            cboTipoItem.SelectedIndex = -1
            txtObservacaoBOM.Text = ""
            txtSC.Value = 0
            txtDET.Value = 0

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.EstoqueRequisicao, gcUpdate) = True Then

                'Verifica o Status
                'If grdProduto.CurrentRow.Cells("status").Value = CInt(StatusRequisicaoEstoque.NaoAtendida) Then 'AndAlso grdProduto.CurrentRow.Cells("codigo_motivo").Value <> 1 Then

                With grdProduto.CurrentRow.Cells

                    'Carrega Controles
                    cboProduto.SelectedValue = .Item("codigo_item").Value
                    If IsDBNull(.Item("data_necessidade").Value) Then
                        dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Checked = False
                    Else
                        dtpDataNecessidade.Value = .Item("data_necessidade").Value : dtpDataNecessidade.Checked = True
                    End If
                    txtQuantidade.Value = .Item("quantidade").Value
                    cboMotivoRequisicao.SelectedValue = .Item("codigo_motivo").Value
                    cboTipoItem.SelectedValue = .Item("codigo_tipo_item").Value
                    txtAltura.Value = .Item("altura").Value
                    txtLargura.Value = .Item("largura").Value
                    txtComprimento.Value = .Item("comprimento").Value
                    'IIf(IsDBNull(.Item("comprimento").Value), txtDimensao.Text = "", txtDimensao.Text = .Item("comprimento").Value)
                    cboUnidadeMedidaDimensao.SelectedValue = .Item("codigo_unidade_medida_dimensao").Value

                    btnInserirProduto.Tag = .Item("codigo_item").Value

                End With

                'Seta Focu
                cboProduto.Focus()

                ' Else
                '    'Informa o Usuário que essa Requisição não pode ser Alterada
                '    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Status da Requisição ou Motivo não permite Alteração.")
                'End If

            Else
                'Informa o Usuário que essa Requisição não pode ser Alterada
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim lCodigoItemAntigo As Long = -1

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirProduto.Tag) Then
                lCodigoItemAntigo = grdProduto.CurrentRow.Cells("codigo_item").Value
            End If

            'Insere Produto no Orçamento
            oClsEstRequisicao.InsertProdutoGridIssartel(grdProduto, _
                                                cboProduto.Text, _
                                                txtDescricaoProduto.Text.Trim, _
                                                cboMotivoRequisicao.Text, _
                                                IIf(dtpDataNecessidade.Checked = True, dtpDataNecessidade.Value, ""), _
                                                txtQuantidade.Value, _
                                                cboProduto.SelectedValue, _
                                                cboMotivoRequisicao.SelectedValue, _
                                                IIf(IsNumeric(btnInserirProduto.Tag), "U", "I"), _
                                                lCodigoItemAntigo, _
                                                cboTipoItem.Text, _
                                                cboTipoItem.SelectedValue, _
                                                txtLargura.Value, _
                                                txtAltura.Value, _
                                                txtComprimento.Value, _
                                                txtDimensao.Text.Trim, _
                                                cboUnidadeMedidaDimensao.Text.Trim, _
                                                cboUnidadeMedidaDimensao.SelectedValue, _
                                                txtObservacaoBOM.Text.Trim, _
                                                txtSC.Value, _
                                                txtDET.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Limpa Formulário
                    Call NovoProduto()

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

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Selecionado o Campo - Produto
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Verifica se o Produto ja existe na Grid
            Dim iLinha As Integer = -1
            If IsNumeric(btnInserirProduto.Tag) Then
                iLinha = grdProduto.CurrentRow.RowIndex
            End If

            'If ValidaCampo(cboRastreabilidade, lblRastreabilidade, True) = False Then
            '    Exit Function
            'End If

            'For Each oRow As GridEXRow In grdProduto.GetDataRows
            '    If oRow.Cells("codigo_item").Value = cboProduto.SelectedValue AndAlso _
            '       oRow.RowIndex <> iLinha Then
            '        'Informa o Usuário que já foi inserido o Valor na Grid
            '        frmMain.errInfo.SetError(lblProduto, "Este Produto ja está incluso na Requisição.")
            '        cboProduto.Focus()
            '        Exit Function
            '    End If
            'Next

            'Verifica se foi Selecionado o Campo - Motivo
            If ValidaCampo(cboMotivoRequisicao, lblMotivoRequisicao) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Dim sRetorno As String = ""
            'sRetorno = LoadCodigo("sp_validade_estoque_requisicao_pagamento " & cboProduto.SelectedValue & _
            '                                                                ", '" & cboRastreabilidade.Text & _
            '                                                                "', " & txtQuantidade.Value.ToString.Replace(",", ".") & _
            '                                                                ", 1")

            'If sRetorno <> "" Then
            '    MsgBox("Quantidade não disponível em estoque!", MsgBoxStyle.OkOnly)
            '    Exit Function
            'End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

    

End Class

