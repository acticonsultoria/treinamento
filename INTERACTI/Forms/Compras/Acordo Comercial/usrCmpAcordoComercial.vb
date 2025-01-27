Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Math

Public Class usrCmpAcordoComercial

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpAcordoComercial As New clsUsrCmpAcordoComercial

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCmpAcordoComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                        
                Case Keys.F3

                    Select Case sender.Name
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                        Case "cboFornecedor" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                        Case "cboFornecedorFiltro" : Call btnProcurarFornecedorFiltro_Click(btnProcurarFornecedorFiltro, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFornecedorFiltro" : Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboMoedaFiltro" : Call LoadCombo(cboMoedaFiltro, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboFornecedor" : Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboMoeda" : Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)
                        Case "cboUnidadeMedidaProduto" : Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboCondicaoPagamento" : Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboTipoArquivo" : Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
                        Case "cboFormaPagamento" : Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento")
                        Case "cboCondicaoPagamento" : Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboModalidadeFrete" : Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete")
                        Case "cboTransportadora" : Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
                        Case "cboModalidadeTransporte" : Call LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa, False)
                        Case "cboIncoterms" : Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
                        Case "cboAgenteLogistico" : Call LoadCombo(cboAgenteLogistico, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa, False)
                        Case "cboInstrucaoEmbarque" : Call LoadCombo(cboInstrucaoEmbarque, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnCadastrarFornecedor_Click(btnCadastrarFornecedor, System.EventArgs.Empty)
                        Case "cboMoeda" : Call btnCadastrarMoeda_Click(btnCadastrarMoeda, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaProduto" : Call btnCadastrarUnidadeMedidaProduto_click(btnCadastrarUnidadeMedidaProduto, System.EventArgs.Empty)
                        Case "cboCondicaoPagamento" : Call btnCadastrarCondicaoPagamento_Click(btnCadastrarCondicaoPagamento, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnCadastrarTransportadora_Click(btnCadastrarTransportadora, System.EventArgs.Empty)
                        Case "cboModalidadeTransporte" : Call btnCadastrarModalidadeTransporte_Click(btnCadastrarModalidadeTransporte, System.EventArgs.Empty)
                        Case "cboIncoterms" : Call btnCadastrarIncoterms_Click(btnCadastrarIncoterms, System.EventArgs.Empty)
                        Case "cboAgenteLogistico" : Call btnCadastrarAgenteLogistico_Click(btnCadastrarAgenteLogistico, System.EventArgs.Empty)
                        Case "cboInstrucaoEmbarque" : Call btnCadastrarInstrucaoEmbarque_Click(btnCadastrarInstrucaoEmbarque, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCmpAcordoComercial_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CONTRATO :::"

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
            oForm.NomeFormulario = Formulario.ComprasAcordoComercial
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedorFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedorFiltro.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedorFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedorFiltro.Focus()

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
            oComboBoxFind = cboFornecedor

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedor.Focus()

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
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMoeda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMoeda.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMoeda")

            'Carrega Combo            
            Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)

            'Seta Focu
            cboMoeda.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCondicaoPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCondicaoPagamento.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCondicaoPagamento")

            'Carrega Combo            
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)

            'Seta Focu
            cboCondicaoPagamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTransportadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTransportadora.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTransportadora")

            'Carrega Combo            
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)

            'Seta Focu
            cboTransportadora.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarModalidadeTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarModalidadeTransporte.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadModalidadeTransporte")

            'Carrega Combo            
            Call LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa)

            'Seta Focu
            cboModalidadeTransporte.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarIncoterms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarIncoterms.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadIncoterms")

            'Carrega Combo            
            Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa)

            'Seta Focu
            cboIncoterms.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarInstrucaoEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarInstrucaoEmbarque.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadInstrucaoEmbarque")

            'Carrega Combo            
            Call LoadCombo(cboInstrucaoEmbarque, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa)

            'Seta Focu
            cboInstrucaoEmbarque.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAgenteLogistico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarAgenteLogistico.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboAgenteLogistico, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa)

            'Seta Focu
            cboAgenteLogistico.Focus()

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

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara Formulário para Cadastro 
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtNumeroAcordoComercial.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida dados do Formulário
            If Validacao() = True Then

                'Salva Registro
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

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroAcordoComercialFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Registros
            Call Delete()

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

    Private Sub cboMoeda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoeda.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboMoeda.SelectedIndex = -1 Then
                txtFatorCambial.Value = 0 : txtFatorCambial.Enabled = False
            ElseIf cboMoeda.SelectedValue = CInt(Moeda.Real) Then
                txtFatorCambial.Value = 1 : txtFatorCambial.Enabled = False
            Else
                txtFatorCambial.Value = 0 : txtFatorCambial.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFornecedor.SelectedIndexChanged

        Try

            'Verifica a UF do Fornecedor
            If LoadUFParceiroNegocio(cboFornecedor.SelectedValue) = gcUFExterior Then

                'Habilita Controles
                cboModalidadeTransporte.Enabled = True
                cboIncoterms.Enabled = True
                cboAgenteLogistico.Enabled = True
                cboInstrucaoEmbarque.Enabled = True

            Else

                'Desabilita Controles
                cboModalidadeTransporte.Enabled = False : cboModalidadeTransporte.Text = ""
                cboIncoterms.Enabled = False : cboIncoterms.Text = ""
                cboAgenteLogistico.Enabled = False : cboAgenteLogistico.Text = ""
                cboInstrucaoEmbarque.Enabled = False : cboInstrucaoEmbarque.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "inserir_revisao" : Call Revisao()

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
                                     Formulario.ComprasAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComprasAcordoComercial, _
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
                                          Formulario.ComprasAcordoComercial, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

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
            oForm.NomeFormulario = Formulario.ComprasAcordoComercial
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadItem")

            'Carrega Combo            
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaProduto.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaProduto.Focus()

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
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(sender As Object, e As EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Item
            If ValidacaoProduto() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirProduto.Tag) = False Then

                    'Insere Registro
                    Call oClsCmpAcordoComercial.InsertProduto(btnSalvar.Tag, _
                                                              cboProduto.SelectedValue, _
                                                              txtLeadTime.Value, _
                                                              txtQuantidadeMinimaProduto.Value, _
                                                              cboUnidadeMedidaProduto.SelectedValue, _
                                                              txtValorUnitario.Value, _
                                                              txtDescontoValorProduto.Value, _
                                                              chkICMSEmbutido.CheckState, _
                                                              txtAliquotaICMSProduto.Value, _
                                                              txtAliquotaICMSProduto.Tag, _
                                                              chkIPIEmbutido.CheckState, _
                                                              txtAliquotaIPIProduto.Value, _
                                                              txtAliquotaIPIProduto.Tag, _
                                                              chkPISCOFINSEmbutido.CheckState, _
                                                              txtAliquotaPISCOFINSProduto.Value, _
                                                              txtAliquotaPISCOFINSProduto.Tag, _
                                                              txtPrecoCompra.Value)

                    'Informa o Usuário sobre o sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroInserido)

                Else

                    'Atualiza Registro
                    Call oClsCmpAcordoComercial.UpdateProduto(btnSalvar.Tag, _
                                                              cboProduto.SelectedValue, _
                                                              txtLeadTime.Value, _
                                                              txtQuantidadeMinimaProduto.Value, _
                                                              cboUnidadeMedidaProduto.SelectedValue, _
                                                              txtValorUnitario.Value, _
                                                              txtDescontoValorProduto.Value, _
                                                              chkICMSEmbutido.CheckState, _
                                                              txtAliquotaICMSProduto.Value, _
                                                              txtAliquotaICMSProduto.Tag, _
                                                              chkIPIEmbutido.CheckState, _
                                                              txtAliquotaIPIProduto.Value, _
                                                              txtAliquotaIPIProduto.Tag, _
                                                              chkPISCOFINSEmbutido.CheckState, _
                                                              txtAliquotaPISCOFINSProduto.Value, _
                                                              txtAliquotaPISCOFINSProduto.Tag, _
                                                              txtPrecoCompra.Value, _
                                                              grdProduto.CurrentRow.Cells("codigo").Value)

                    'Informa o Usuário sobre o sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroAlterado)

                End If

                'Carrega Grid
                Call oClsCmpAcordoComercial.LoadGridProduto(grdProduto, btnSalvar.Tag)

                'Limpa Formulário
                Call NovoProduto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(sender As Object, e As EventArgs) Handles btnExcluirProduto.Click

        Try

            'Exclui Produto
            Call DeleteProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricaoProduto.Text = ""
            Else

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Controles
                Call oClsCadProduto.LoadDadosProduto(cboProduto.SelectedValue, _
                                                     txtDescricaoProduto)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.ComprasAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.ComprasAcordoComercial, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.ComprasAcordoComercial, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaDesconto(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorUnitario.ValueChanged, _
                                                                                             txtDescontoValorProduto.LostFocus, _
                                                                                             txtDescontoPercentualProduto.LostFocus

        Try

            Dim dValorUnitario As Double = IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0)
            Dim dDescontoValor As Double = IIf(IsNumeric(txtDescontoValorProduto.Value), txtDescontoValorProduto.Value, 0)
            Dim dDescontoPercentual As Double = IIf(IsNumeric(txtDescontoPercentualProduto.Value), txtDescontoPercentualProduto.Value, 0) / 100

            Select Case sender.Name

                Case "txtDescontoPercentualProduto" : txtDescontoValorProduto.Value = dValorUnitario * dDescontoPercentual
                Case "txtDescontoValorProduto" : txtDescontoPercentualProduto.Value = dDescontoValor / dValorUnitario * 100
                Case "txtValorUnitario" : txtDescontoValorProduto.Value = 0 : txtDescontoPercentualProduto.Value = 0
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaPrecoCompra() Handles txtValorUnitario.ValueChanged, _
                                             txtDescontoValorProduto.ValueChanged, _
                                             chkICMSEmbutido.CheckedChanged, _
                                             txtAliquotaICMSProduto.ValueChanged, _
                                             chkIPIEmbutido.CheckedChanged, _
                                             txtAliquotaIPIProduto.ValueChanged, _
                                             chkPISCOFINSEmbutido.CheckedChanged, _
                                             txtAliquotaPISCOFINSProduto.ValueChanged

        Try

            Dim dPrecoCompra As Double = 0
            Dim dValorUnitario As Double = IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0)
            Dim dAliquotaICMS As Double = IIf(IsNumeric(txtAliquotaICMSProduto.Value), txtAliquotaICMSProduto.Value, 0) / 100.0
            Dim dAliquotaPISCOFINS As Double = IIf(IsNumeric(txtAliquotaPISCOFINSProduto.Value), txtAliquotaPISCOFINSProduto.Value, 0) / 100.0
            Dim dAliquotaIPI As Double = IIf(IsNumeric(txtAliquotaIPIProduto.Value), txtAliquotaIPIProduto.Value, 0) / 100.0
            Dim dDesconto As Double = IIf(IsNumeric(txtDescontoValorProduto.Value), txtDescontoValorProduto.Value, 0)

            dValorUnitario -= dDesconto

            'Calcula IPI
            If chkIPIEmbutido.Checked = True Then
                dValorUnitario = (dValorUnitario / (1 + dAliquotaIPI))
            End If

            'Calcula ICMS / PIS / COFINS
            If chkICMSEmbutido.Checked = True And chkPISCOFINSEmbutido.Checked = True Then
                dValorUnitario = dValorUnitario
            ElseIf chkICMSEmbutido.Checked = True And chkPISCOFINSEmbutido.Checked = False Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaPISCOFINS)))
            ElseIf chkICMSEmbutido.Checked = False And chkPISCOFINSEmbutido.Checked = True Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaICMS)))
            ElseIf chkICMSEmbutido.Checked = False And chkPISCOFINSEmbutido.Checked = False Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaICMS + dAliquotaPISCOFINS)))
            End If

            'Seta Controles
            txtAliquotaICMSProduto.Tag = dValorUnitario * txtAliquotaICMSProduto.Value / 100
            txtAliquotaPISCOFINSProduto.Tag = dValorUnitario * txtAliquotaPISCOFINSProduto.Value / 100
            txtAliquotaIPIProduto.Tag = dValorUnitario * txtAliquotaIPIProduto.Value / 100

            'Seta Controle - Preço de Compra
            txtPrecoCompra.Value = ((dValorUnitario + IIf(chkICMSEmbutido.Checked = True, 0, txtAliquotaICMSProduto.Tag) + IIf(chkPISCOFINSEmbutido.Checked = True, 0, txtAliquotaPISCOFINSProduto.Tag) + IIf(chkIPIEmbutido.Checked = True, 0, txtAliquotaIPIProduto.Tag)))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.ComercialPedidoVenda)

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

            'Valida Dados do Formulário
            If ValidacaoArquivo() = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_cmp_acordo_comercial", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_cmp_acordo_comercial", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_cmp_acordo_comercial", btnSalvar.Tag)

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

    Private Sub cboTipoArquivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

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
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "editar" : Call EditarArquivo()
                Case "visualizar" : Call VisualizarDocumentoBD(grdArquivo.CurrentRow.Cells("arquivo").Value, grdArquivo.CurrentRow.Cells("extensao").Value)

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
                                     Formulario.ComprasAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ComprasAcordoComercial, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.ComprasAcordoComercial, _
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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpAcordoComercial_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasAcordoComercial, gcPrint)
            btnExcluir.Enabled = VerificaDireito(Formulario.ComprasAcordoComercial, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.ComprasAcordoComercial, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.ComprasAcordoComercial, gcInsert)

            'Verifica Direito - Botão Cadastrar
            btnCadastrarFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarMoeda.Enabled = VerificaDireito(Formulario.CadastroBasicoMoeda, gcInsert)
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarUnidadeMedidaProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Carrega ComboBox
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboFornecedorFiltro : oComboBox(1) = cboFornecedor
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
            oComboBox(0) = cboMoedaFiltro : oComboBox(1) = cboMoeda
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento")
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
            Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete")
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboAgenteLogistico, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboInstrucaoEmbarque, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa, False)

            'Carrega ComboBox - Produto
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)
            Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Carrega ComboBox - Arquivo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)

            'Limpa Controles
            dtpDataInicioInicioFiltro.Value = Now.Date : dtpDataInicioInicioFiltro.Checked = False
            dtpDataInicioTerminoFiltro.Value = Now.Date : dtpDataInicioTerminoFiltro.Checked = False
            dtpDataValidadeInicioFiltro.Value = Now.Date : dtpDataValidadeInicioFiltro.Checked = False
            dtpDataValidadeTerminoFiltro.Value = Now.Date : dtpDataValidadeTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasAcordoComercial)
            Call ConfiguraGrid(grdProduto, Formulario.ComprasAcordoComercial)
            Call ConfiguraGrid(grdArquivo, Formulario.ComprasAcordoComercial)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroAcordoComercialFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ACORDO COMERCIAL :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsCmpAcordoComercial.LoadGrid(grdListagem, _
                                                 txtNumeroAcordoComercialFiltro.Text.Trim, _
                                                 IIf(IsNumeric(txtRevisaoFiltro.Text.Trim), txtRevisaoFiltro.Text.Trim, -1), _
                                                 IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                                 IIf(cboMoedaFiltro.SelectedIndex = -1, -1, cboMoedaFiltro.SelectedValue), _
                                                 IIf(dtpDataInicioInicioFiltro.Checked = False, "", dtpDataInicioInicioFiltro.Value), _
                                                 IIf(dtpDataInicioTerminoFiltro.Checked = False, "", dtpDataInicioTerminoFiltro.Value), _
                                                 IIf(dtpDataValidadeInicioFiltro.Checked = False, "", dtpDataValidadeInicioFiltro.Value), _
                                                 IIf(dtpDataValidadeTerminoFiltro.Checked = False, "", dtpDataValidadeTerminoFiltro.Value), _
                                                 txtDescritivoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigoAcordoComercial As Long)

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComprasAcordoComercial, gcUpdate) = True Then

                'Prepara Formulário
                Call Novo()

                'Carrega Controles
                Call oClsCmpAcordoComercial.Editar(lCodigoAcordoComercial, _
                                                   txtNumeroAcordoComercial, _
                                                   txtRevisao, _
                                                   cboFornecedor, _
                                                   cboMoeda, _
                                                   txtFatorCambial, _
                                                   dtpDataInicio, _
                                                   dtpDataValidade, _
                                                   txtDescritivo, _
                                                   txtAdministradorAcordoComercialFornecedor, _
                                                   cboCondicaoPagamento, _
                                                   cboFormaPagamento, _
                                                   cboModalidadeFrete, _
                                                   cboTransportadora, _
                                                   cboModalidadeTransporte, _
                                                   cboIncoterms, _
                                                   cboAgenteLogistico, _
                                                   cboInstrucaoEmbarque, _
                                                   txtObservacaoOrcamento)

                btnSalvar.Tag = lCodigoAcordoComercial

                'Carrega Grid - Item
                Call oClsCmpAcordoComercial.LoadGridProduto(grdProduto, lCodigoAcordoComercial)

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtNumeroAcordoComercial.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmetros
            oClsCmpAcordoComercial.Codigo = btnSalvar.Tag
            oClsCmpAcordoComercial.NumeroAcordoComercial = txtNumeroAcordoComercial.Text.Trim
            oClsCmpAcordoComercial.CodigoFornecedor = cboFornecedor.SelectedValue
            oClsCmpAcordoComercial.CodigoMoeda = cboMoeda.SelectedValue
            oClsCmpAcordoComercial.FatorCambial = txtFatorCambial.Value
            oClsCmpAcordoComercial.DataInicio = dtpDataInicio.Value
            oClsCmpAcordoComercial.DataValidade = IIf(dtpDataValidade.Checked = False, "", dtpDataValidade.Value)
            oClsCmpAcordoComercial.Descritivo = txtDescritivo.Text.Trim
            oClsCmpAcordoComercial.AdministradorAcordoComercial = txtAdministradorAcordoComercialFornecedor.Text.Trim
            oClsCmpAcordoComercial.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)
            oClsCmpAcordoComercial.CodigoFormaPagamento = IIf(cboFormaPagamento.SelectedIndex = -1, -1, cboFormaPagamento.SelectedValue)
            oClsCmpAcordoComercial.CodigoModalidadeFrete = IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue)
            oClsCmpAcordoComercial.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsCmpAcordoComercial.CodigoModalidadeTransporte = IIf(cboModalidadeTransporte.SelectedIndex = -1, -1, cboModalidadeTransporte.SelectedValue)
            oClsCmpAcordoComercial.CodigoIncoterms = IIf(cboIncoterms.SelectedIndex = -1, -1, cboIncoterms.SelectedValue)
            oClsCmpAcordoComercial.CodigoAgenteLogistico = IIf(cboAgenteLogistico.SelectedIndex = -1, -1, cboAgenteLogistico.SelectedValue)
            oClsCmpAcordoComercial.CodigoInstrucaoEmbarque = IIf(cboInstrucaoEmbarque.SelectedIndex = -1, -1, cboInstrucaoEmbarque.SelectedValue)
            oClsCmpAcordoComercial.Observacao = txtObservacaoOrcamento.Text.Trim

            'Verifica o Tipo de Operação
            Call oClsCmpAcordoComercial.Update()

            'Informa o usuário sobre o sucesso da operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Revisao()

        Try

            'Verifica se foi Selecionado Algum Cliente
            If MsgBox("Deseja Gerar Nova Revisão para o Acordo Comercial Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Insere Revisão
                Call oClsCmpAcordoComercial.InsertRevisao(grdListagem.CurrentRow.Cells("codigo").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega o Acordo Comercial
                Call Editar(oClsCmpAcordoComercial.Codigo)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCmpAcordoComercial.Delete()

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

    Private Sub Novo()

        Try

            'Insere Registro
            Call oClsCmpAcordoComercial.Insert()

            'Limpa Formulário - Cadastro
            txtNumeroAcordoComercial.Text = ""
            cboFornecedor.SelectedIndex = -1
            txtRevisao.Text = ""
            cboMoeda.SelectedIndex = -1
            dtpDataInicio.Value = Now.Date
            dtpDataValidade.Value = Now.Date : dtpDataValidade.Checked = False
            txtDescritivo.Text = ""
            txtAdministradorAcordoComercialFornecedor.Text = ""
            cboCondicaoPagamento.SelectedIndex = -1
            cboFormaPagamento.SelectedIndex = -1
            cboModalidadeFrete.SelectedIndex = -1
            cboTransportadora.SelectedIndex = -1
            cboModalidadeTransporte.SelectedIndex = -1 : cboModalidadeTransporte.Enabled = False
            cboIncoterms.SelectedIndex = -1 : cboIncoterms.Enabled = False
            cboAgenteLogistico.SelectedIndex = -1 : cboAgenteLogistico.Enabled = False
            cboInstrucaoEmbarque.SelectedIndex = -1 : cboInstrucaoEmbarque.Enabled = False
            txtObservacaoOrcamento.Text = ""
            btnSalvar.Tag = oClsCmpAcordoComercial.Codigo

            'Limpa Formulário - Produto
            cboProduto.SelectedIndex = -1
            txtDescricaoProduto.Text = ""
            txtLeadTime.Value = 0
            txtQuantidadeMinimaProduto.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            txtValorUnitario.Value = 0
            chkICMSEmbutido.CheckState = CheckState.Checked
            txtAliquotaICMSProduto.Value = 0
            txtAliquotaICMSProduto.Tag = 0
            chkIPIEmbutido.CheckState = CheckState.Checked
            txtAliquotaIPIProduto.Value = 0
            txtAliquotaIPIProduto.Tag = 0
            chkPISCOFINSEmbutido.CheckState = CheckState.Checked
            txtAliquotaPISCOFINSProduto.Value = 0
            txtAliquotaPISCOFINSProduto.Tag = 0
            txtPrecoCompra.Value = 0
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagProduto

            'Seta Focu
            txtNumeroAcordoComercial.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função 
            Validacao = False

            'Verifica se foi Preenchido o Campo - Nº AcordoComercial
            If ValidaCampo(txtNumeroAcordoComercial, lblNumeroAcordoComercial, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Valida se o Período não interfere em outra Lista de Preço
            If oClsCmpAcordoComercial.ValidaAcordoComercial(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                            txtNumeroAcordoComercial.Text.Trim, _
                                                            IIf(IsNumeric(txtRevisao.Text.Trim), txtRevisao.Text.Trim, -1), _
                                                            cboFornecedor.SelectedValue) = False Then
                frmMain.errInfo.SetError(lblNumeroAcordoComercial, "Este Acordo Comercial: " & txtNumeroAcordoComercial.Text.Trim & " já está associado a outro registro.")
                txtNumeroAcordoComercial.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoeda, lblMoeda) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fator Cambial
            If ValidaCampo(txtFatorCambial, lblMoeda, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Data de Válidade
            If dtpDataValidade.Checked = True Then
                If dtpDataInicio.Value > dtpDataValidade.Value Then
                    frmMain.errInfo.SetError(lblDataValidade, "A Data de Validade não pode ser menor que a Data de Início.")
                    dtpDataValidade.Focus()
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

#Region "::: PRODUTO :::"

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Cadastro - Item
            cboProduto.SelectedIndex = -1
            txtDescricaoProduto.Text = ""
            txtLeadTime.Value = 0
            txtQuantidadeMinimaProduto.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            txtValorUnitario.Value = 0
            chkICMSEmbutido.CheckState = CheckState.Checked
            txtAliquotaICMSProduto.Value = 0
            txtAliquotaICMSProduto.Tag = 0
            chkIPIEmbutido.CheckState = CheckState.Checked
            txtAliquotaIPIProduto.Value = 0
            txtAliquotaIPIProduto.Tag = 0
            chkPISCOFINSEmbutido.CheckState = CheckState.Checked
            txtAliquotaPISCOFINSProduto.Value = 0
            txtAliquotaPISCOFINSProduto.Tag = 0
            txtPrecoCompra.Value = 0
            btnInserirProduto.Tag = ""

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCmpAcordoComercial.DeleteProduto(btnSalvar.Tag)

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

    Private Sub EditarProduto()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComprasAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdProduto.CurrentRow.Cells

                    cboProduto.SelectedValue = .Item("codigo_item").Value
                    txtDescricaoProduto.Text = .Item("descricao").Value
                    txtLeadTime.Value = .Item("lead_time").Value
                    txtQuantidadeMinimaProduto.Value = .Item("quantidade_minima").Value
                    cboUnidadeMedidaProduto.SelectedValue = .Item("codigo_unidade_medida").Value
                    txtValorUnitario.Value = .Item("valor_unitario").Value
                    txtDescontoValorProduto.Value = .Item("desconto_unitario_valor").Value
                    txtDescontoPercentualProduto.Value = .Item("desconto_unitario_percentual").Value
                    chkICMSEmbutido.CheckState = .Item("icms_embutido").Value
                    txtAliquotaICMSProduto.Value = .Item("aliquota_icms").Value
                    txtAliquotaICMSProduto.Tag = .Item("valor_icms").Value
                    chkIPIEmbutido.CheckState = .Item("ipi_embutido").Value
                    txtAliquotaIPIProduto.Value = .Item("aliquota_ipi").Value
                    txtAliquotaIPIProduto.Tag = .Item("valor_ipi").Value
                    chkPISCOFINSEmbutido.CheckState = .Item("pis_cofins_embutido").Value
                    txtAliquotaPISCOFINSProduto.Value = .Item("aliquota_pis_cofins").Value
                    txtAliquotaPISCOFINSProduto.Tag = .Item("valor_pis_cofins").Value
                    txtPrecoCompra.Value = .Item("preco_compra").Value
                    btnInserirProduto.Tag = .Item("codigo").Value

                    'Seta Focu
                    cboProduto.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoProduto = False

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Verifica se o Item já está inserido na Grid
            If IsNumeric(btnInserirProduto.Tag) = False Then
                If VerificaExisteValorGrid(grdProduto, "codigo_item", cboProduto.SelectedValue) = True Then
                    frmMain.errInfo.SetError(lblProduto, "Este Registro: " & cboProduto.Text & " já se encontra cadastrado.")
                    cboProduto.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdProduto, "codigo_item", cboProduto.SelectedValue, grdProduto.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblProduto, "Este Registro: " & cboProduto.Text & " já se encontra cadastrado.")
                    cboProduto.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Lead Time
            If ValidaCampo(txtLeadTime, lblLeadTime, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade Mínima
            If ValidaCampo(txtQuantidadeMinimaProduto, lblQuantidadeMinimaProduto, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedidaProduto, lblUnidadeMedidaProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Preço de Venda
            If ValidaCampo(txtValorUnitario, lblValorUnitario, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        modFunction.DeleteArquivoBD("tb_cmp_acordo_comercial", oRow.Cells("path").Value, btnSalvar.Tag)
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
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcUpdate) = True Then

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

#End Region

End Class
