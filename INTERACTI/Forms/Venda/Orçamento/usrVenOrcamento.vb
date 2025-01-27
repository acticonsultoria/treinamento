Imports Janus.Windows.EditControls
Imports Janus.Windows.UI.Tab
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Math

Public Class usrVenOrcamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsVenOrcamento As New clsUsrVenOrcamento

    Private bItemEstoque As Boolean
    Private bItemProducao As Boolean
    Private bAcordoComercial As Boolean
    Private lCodigoAcordoComercial As Double
    Private iCodigoAcordoComercialItem As Integer
    Private lCodigoRegraFaturamento As Long
    Private dPrecoMinimo As Double
    Private dCustoTeorico As Double
    Private dQuantidadeMinima As Double
    Private dMultiploVenda As Double
    Private iCodigoFormaVendaProduto As FormaVendaItem
    Private iCodigoFormaVendaServico As FormaVendaItem
    Private dPrecoVendaServico As Double
    Private dPercentualValorProduto As Double
    Private oPrecoVendaProduto() As PrecoVendaProduto
    Private dLimiteCredito As Double
    Private iCodigoUsuarioItem As Integer = goUsuario.iUsuario
    Private sLiberacaoItem As String = ""
    Private oDataEntregaProduto As New Hashtable
    Private oDataEntregaServico As New Hashtable


#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrVenOrcamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridOrcamento() Else Control_Enter(sender)

                Case Keys.F1

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboProduto" : Call PrecoVendaProduto()
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "txtDescricaoItemFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarItemFiltro, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                        Case "cboClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                        Case "cboItemFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarItemFiltro, System.EventArgs.Empty)
                        Case "cboServico" : Call btnProcurarServico_Click(btnProcurarServico, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnProcurarTransportadora_Click(btnProcurarTransportadora, System.EventArgs.Empty)
                        Case "txtTermoGarantia" : Call btnProcurarAutotexto_Click(btnProcurarTermoGarantia, System.EventArgs.Empty)
                        Case "txtCondicaoFornecimento" : Call btnProcurarAutotexto_Click(btnProcurarCondicaoFornecimento, System.EventArgs.Empty)
                        Case "txtObservacao" : Call btnProcurarAutotexto_Click(btnProcurarObservacaoVenda, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCliente" : Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, "sp_select_combo_cadastro_basico_cliente_negativacao " & goUsuario.iEmpresa, oTipoComboBox)
                        Case "cboClienteFiltro" : Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, "sp_select_combo_cadastro_basico_cliente_negativacao " & goUsuario.iEmpresa, oTipoComboBox)
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & TipoItem.produto)
                        Case "cboUnidadeMedidaProduto" : Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboServico" : Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))
                        Case "cboUnidadeMedidaServico" : Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboTransportadora" : Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
                        Case "cboCondicaoPagamento" : Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboFormaPagamento" : Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento")
                        Case "cboMoeda" : Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboProbabilidadeVenda" : Call LoadCombo(cboProbabilidadeVenda, "sp_select_combo_cadastro_basico_probabilidade_exito_venda " & goUsuario.iEmpresa, False)
                        Case "cboTipoArquivo" : Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
                        Case "cboIncoterms" : Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
                        Case "cboCampanha" : Call LoadCombo(cboCampanha, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaProduto" : Call btnCadastrarUnidadeMedidaProduto_Click(btnCadastrarUnidadeMedidaProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaServico" : Call btnCadastrarUnidadeMedidaServico_Click(btnCadastrarUnidadeMedidaServico, System.EventArgs.Empty)
                        Case "cboServico" : Call btnCadastrarServico_Click(btnCadastrarServico, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnCadastrarTransportadora_Click(btnCadastrarTransportadora, System.EventArgs.Empty)
                        Case "cboCondicaoPagamento" : Call btnCadastrarCondicaoPagamento_Click(btnCadastrarCondicaoPagamento, System.EventArgs.Empty)
                        Case "txtTermoGarantia" : Call btnCadastrarAutotexto_Click(btnCadastrarTermoGarantia, System.EventArgs.Empty)
                        Case "txtCondicaoFornecimento" : Call btnCadastrarAutotexto_Click(btnCadastrarCondicaoFornecimento, System.EventArgs.Empty)
                        Case "txtObservacao" : Call btnCadastrarAutotexto_Click(btnCadastrarObservacaoVenda, System.EventArgs.Empty)
                        Case "cboProbabilidadeVenda" : Call btnCadastrarProbabilidadeVenda_Click(btnCadastrarProbabilidadeVenda, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)
                        Case "cboIncoterms" : Call btnCadastrarIncoterms_Click(btnCadastrarIncoterms, System.EventArgs.Empty)
                        Case "cboCampanha" : Call btnCadastrarCampanha_Click(btnCadastrarCampanha, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrVenOrcamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            Cursor.Current = Cursors.WaitCursor

            Select Case e.Column.Key

                Case "hora_orcamento"

                    oClsVenOrcamento.UpdateHoraOrcamento(grdListagem.CurrentRow.Cells("codigo_orcamento").Value, _
                                                         grdListagem.CurrentRow.Cells("hora_orcamento").Value)

                    frmMain.Informacao(Mensagem.RegistroAlterado)

                Case "hora_aprovacao"

                    oClsVenOrcamento.UpdateHoraAprovacao(grdListagem.CurrentRow.Cells("codigo_orcamento").Value, _
                                                         grdListagem.CurrentRow.Cells("hora_aprovacao").Value)

                    frmMain.Informacao(Mensagem.RegistroAlterado)

            End Select

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialOrcamento)

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

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue)
            sItemVendaFind = "S"
            oComboBoxFind = cboItemFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboItemFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarClienteFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Verifica se o Cliente está habilitado
            If cboCliente.Enabled = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Sub
            End If

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarTransportadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarTransportadora.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindTransportadora"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Transportadora"

            'Seta Váriaveis
            oComboBoxFind = cboTransportadora

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboTransportadora.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarAutotexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarTermoGarantia.Click, _
                                                                                                               btnProcurarObservacaoVenda.Click, _
                                                                                                               btnProcurarCondicaoFornecimento.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindAutotexto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Autotexto"

            'Seta Parametros
            Select Case sender.Name
                Case "btnProcurarTermoGarantia" : iTipoAutoTextoFind = TipoAutotexto.TermoGarantia : oEditBoxFind = txtTermoGarantia
                Case "btnProcurarObservacaoVenda" : iTipoAutoTextoFind = TipoAutotexto.ObservacaoVenda : oEditBoxFind = txtObservacao
                Case "btnProcurarCondicaoFornecimento" : iTipoAutoTextoFind = TipoAutotexto.CondicaoFornecimento : oEditBoxFind = txtCondicaoFornecimento
            End Select

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            Select Case sender.Name
                Case "btnProcurarTermoGarantia" : txtTermoGarantia.Focus()
                Case "btnProcurarObservacaoVenda" : txtObservacao.Focus()
                Case "btnProcurarCondicaoFornecimento" : txtCondicaoFornecimento.Focus()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Verifica se o Cliente está habilitado
            If cboCliente.Enabled = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Sub
            End If

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, "sp_select_combo_cadastro_basico_cliente_negativacao " & goUsuario.iEmpresa, oTipoComboBox)

            'Seta Focu
            cboCliente.Focus()

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
            LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)

            'Seta Focu
            cboTransportadora.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAutotexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTermoGarantia.Click, _
                                                                                                                btnCadastrarObservacaoVenda.Click, _
                                                                                                                btnCadastrarCondicaoFornecimento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAutotexto")

            'Seta Focu
            Select Case sender.Name
                Case "btnProcurarTermoGarantia" : txtTermoGarantia.Focus()
                Case "btnProcurarObservacaoVenda" : txtObservacao.Focus()
                Case "btnProcurarCondicaoFornecimento" : txtCondicaoFornecimento.Focus()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProbabilidadeVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProbabilidadeVenda.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProbabilidadeExitoVenda")

            'Carrega Combo
            Call LoadCombo(cboProbabilidadeVenda, "sp_select_combo_cadastro_basico_probabilidade_exito_venda " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboProbabilidadeVenda.Focus()

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

    Private Sub btnCadastrarCampanha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCampanha.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCampanhaAbrangencia")

            'Carrega Combo
            Call LoadCombo(cboCampanha, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboCampanha.Focus()

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
            LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)

            'Seta Focu
            cboCondicaoPagamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call DeleteOrcamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            LoadGridOrcamento()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call NovoOrcamento()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Insere Registro no Banco de Dados
            Call oClsVenOrcamento.Insert()
            btnSalvar.Tag = oClsVenOrcamento.CodigoOrcamento

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            dtpDataOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            NovoOrcamento()

            'Configura Valor Default
            ConfigureValorDefault(Me)

            'Insere Registro no Banco de Dados
            oClsVenOrcamento.Insert()
            btnSalvar.Tag = oClsVenOrcamento.CodigoOrcamento

            'Seta Focu        
            dtpDataOrcamento.Focus()

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
            If ValidacaoOrcamento() = True Then

                SalvarOrcamento()

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcPrint)

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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Orçamento de Venda
            Call ImprimirOrcamento(oClsVenOrcamento.CodigoOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Verifica se não foi gerado o Orçamento
            If txtNumeroOrcamento.Text = "" And txtValorFinalOrcamento.Value > 0 Then
                'Verifica se o usuário deseja sair do Orçamento
                If MsgBox("Os Dados do Orçamento serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
                'Exclui Dados do Orçamento
                Call oClsVenOrcamento.Delete(btnSalvar.Tag)
            ElseIf txtNumeroOrcamento.Text <> "" And (grdProduto.GetDataRows.Count = 0 And grdServico.GetDataRows.Count = 0) Then
                'Verifica se o usuário deseja sair do Orçamento
                If MsgBox("O Orçamento será excluido uma vez que não possui Produtos ou Serviços lançados. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
                'Exclui Dados do Orçamento
                Call oClsVenOrcamento.Delete(btnSalvar.Tag)
            End If

            'Carrega Grid
            Call LoadGridOrcamento()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroOrcamentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMoeda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoeda.SelectedIndexChanged

        Try

            'Limpa Controles
            txtFatorCambial.Value = 1
            txtFatorCambial.ReadOnly = True
            txtFatorCambial.TabStop = False
            txtFatorCambial.BackColor = Color.WhiteSmoke

            'Verifica se foi Selecionado algum Item
            If cboMoeda.SelectedIndex <> -1 Then
                lblDescontoGeral.Text = "Desc. Geral " & cboMoeda.Text & ":"
                If cboMoeda.SelectedValue <> CInt(Moeda.Real) Then
                    txtFatorCambial.Value = 0
                    txtFatorCambial.ReadOnly = False
                    txtFatorCambial.TabStop = True
                    txtFatorCambial.BackColor = Color.White
                End If
            Else
                lblDescontoGeral.Text = "Desc. Geral:"
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoItemFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoItemFiltro.SelectedIndexChanged

        Try

            'Carrega Combo
            Call LoadCombo(cboItemFiltro, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", 1, NULL, " & IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboCliente.SelectedIndex = -1 Then

                'Limpa Controles
                cboFormaPagamento.SelectedIndex = -1
                cboCondicaoPagamento.SelectedIndex = -1
                cboModalidadeFrete.SelectedIndex = -1
                cboMoeda.SelectedIndex = -1
                dLimiteCredito = 0
                cboDestinacaoProduto.SelectedIndex = -1

            Else

                'Váriaveis Locais
                Dim iCodigoCondicaoPagamento As Integer = -1
                Dim iCodigoFormaPagamento As Integer = -1
                Dim iCodigoModalidadeFrete As Integer = -1
                Dim iCodigoMoeda As Integer = -1
                Dim iCodigoVendedor As Integer = -1
                Dim iCodigoDestinacao As Integer = -1
                Dim iCodigoCampanha As Integer = -1
                Dim iCodigoEmbalagem As Integer = -1
                Dim oClsParceiroNegocio As New clsUsrCadParceiroNegocio

                'Seta Váriavel
                dLimiteCredito = 0

                'Carrega Dados do Parceiro de Negócio
                oClsParceiroNegocio.LoadDadosParceiroNegocio(cboCliente.SelectedValue, _
                                                             iCodigoCondicaoPagamento, _
                                                             iCodigoFormaPagamento, _
                                                             iCodigoModalidadeFrete, _
                                                             iCodigoMoeda, _
                                                             dLimiteCredito, _
                                                             iCodigoVendedor, _
                                                             iCodigoDestinacao, _
                                                             iCodigoCampanha, _
                                                             iCodigoEmbalagem)

                'Carrega Condição de Pagamento
                If cboCondicaoPagamento.Enabled = True And iCodigoCondicaoPagamento <> -1 Then
                    cboCondicaoPagamento.SelectedValue = iCodigoCondicaoPagamento
                Else
                    cboCondicaoPagamento.SelectedIndex = -1
                End If

                'Carrega Forma de Pagamento
                If cboFormaPagamento.Enabled = True And iCodigoFormaPagamento <> -1 Then
                    cboFormaPagamento.SelectedValue = iCodigoFormaPagamento
                Else
                    cboFormaPagamento.SelectedIndex = -1
                End If

                'Carrega Campanha
                If cboCampanha.Enabled = True And iCodigoCampanha <> -1 Then
                    cboCampanha.SelectedValue = iCodigoCampanha
                Else
                    cboCampanha.SelectedIndex = -1
                End If

                'Carrega Modalidade de Frete
                If cboModalidadeFrete.Enabled = True And iCodigoModalidadeFrete <> -1 Then
                    cboModalidadeFrete.SelectedValue = iCodigoModalidadeFrete
                Else
                    cboModalidadeFrete.SelectedIndex = -1
                End If

                'Carrega Destinação
                If cboDestinacaoProduto.Enabled = True And iCodigoDestinacao <> -1 Then
                    cboDestinacaoProduto.SelectedValue = iCodigoDestinacao
                Else
                    cboDestinacaoProduto.SelectedIndex = -1
                End If

                'Carrega Moeda
                If cboMoeda.Enabled = True And iCodigoMoeda <> -1 Then
                    cboMoeda.SelectedValue = iCodigoMoeda
                Else
                    cboMoeda.SelectedIndex = -1
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a linha é válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : EditarOrcamento(grdListagem.CurrentRow.Cells.Item("codigo_orcamento").Value)
                Case "duplicar" : DuplicarOrcamento()
                Case "inserir_revisao" : InserirRevisaoOrcamento()
                Case "imprimir" : ImprimirOrcamento(grdListagem.CurrentRow.Cells.Item("codigo_orcamento").Value)
                Case "pdf" : ExportarPDF()
                Case "email" : EmailOrcamento()
                Case "comentario" : InserirHistorico()
                Case "historico_orcamento" : HistoricoOrcamento()
                Case "historico" : HistoricoItemOrcamento()
                Case "horas" : AdicionarHoras()

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
                                     Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComercialOrcamento, _
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
                                          Formulario.ComercialOrcamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtDescontoGeral_LostFocus(sender As Object, e As EventArgs) Handles txtDescontoGeral.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalOrcamento.Value
            dValor -= txtValorDescontoOrcamento.Value
            dValor += txtValorImpostosServicoOrcamento.Value
            dValor += txtValorImpostosProdutoOrcamento.Value

            txtDescontoGeralPercentual.Value = txtDescontoGeral.Value / dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtDescontoGeralPercentual_LostFocus(sender As Object, e As EventArgs) Handles txtDescontoGeralPercentual.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalOrcamento.Value
            dValor -= txtValorDescontoOrcamento.Value
            dValor += txtValorImpostosServicoOrcamento.Value
            dValor += txtValorImpostosProdutoOrcamento.Value

            txtDescontoGeral.Value = txtDescontoGeralPercentual.Value * dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtAcrescimoGeral_LostFocus(sender As Object, e As EventArgs) Handles txtAcrescimoGeral.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalOrcamento.Value
            dValor -= txtValorDescontoOrcamento.Value
            dValor += txtValorImpostosServicoOrcamento.Value
            dValor += txtValorImpostosProdutoOrcamento.Value

            txtAcrescimoGeralPercentual.Value = txtAcrescimoGeral.Value / dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtAcrescimoGeralPercentual_LostFocus(sender As Object, e As EventArgs) Handles txtAcrescimoGeralPercentual.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalOrcamento.Value
            dValor -= txtValorDescontoOrcamento.Value
            dValor += txtValorImpostosServicoOrcamento.Value
            dValor += txtValorImpostosProdutoOrcamento.Value

            txtAcrescimoGeral.Value = txtAcrescimoGeralPercentual.Value * dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorFinalOrcamento() Handles txtValorTotalOrcamento.ValueChanged, _
                                                     txtValorDescontoOrcamento.ValueChanged, _
                                                     txtValorImpostosServicoOrcamento.ValueChanged, _
                                                     txtValorImpostosProdutoOrcamento.ValueChanged, _
                                                     txtDescontoGeral.ValueChanged, _
                                                     txtAcrescimoGeral.ValueChanged, _
                                                     txtValorFreteOrcamento.ValueChanged, _
                                                     cboModalidadeFrete.SelectedIndexChanged

        Try

            'Váriaveis Locais
            Dim dValor As Double

            'Cálcula Valor Total
            dValor = txtValorTotalOrcamento.Value
            dValor -= txtValorDescontoOrcamento.Value
            dValor += txtValorImpostosServicoOrcamento.Value
            dValor += txtValorImpostosProdutoOrcamento.Value
            dValor += txtValorFreteOrcamento.Value
            dValor -= txtDescontoGeral.Value
            dValor += txtAcrescimoGeral.Value

            'Seta Valor Final
            txtValorFinalOrcamento.Value = dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Seta Focu
            Select Case e.Page.Name
                Case "pagProduto" : cboProduto.Focus()
                Case "pagServico" : cboServico.Focus()
                Case "pagArquivo" : txtDescricaoArquivo.Focus()
                Case "pagDadosGerais" : cboModalidadeFrete.Focus()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ITEM :::"

#Region "::: DADOS GERAIS :::"

    Private Sub CalcularTotais()

        Try

            'Atualiza Valor Total Orçamento
            txtValorTotalOrcamento.Value = 0
            txtValorDescontoOrcamento.Value = 0
            txtRO.Value = 0
            If grdServico.GetDataRows.Count > 0 Then
                txtValorTotalOrcamento.Value += grdServico.GetTotalRow.Cells("valor_total_desconto").Value + grdServico.GetTotalRow.Cells("total_desconto").Value
                txtValorDescontoOrcamento.Value += grdServico.GetTotalRow.Cells("total_desconto").Value
                txtValorImpostosServicoOrcamento.Value = grdServico.GetTotalRow.Cells("valor_retido").Value
            End If
            If grdProduto.GetDataRows.Count > 0 Then
                txtValorTotalOrcamento.Value += grdProduto.GetTotalRow.Cells("valor_total_desconto").Value + grdProduto.GetTotalRow.Cells("total_desconto").Value
                txtValorDescontoOrcamento.Value += grdProduto.GetTotalRow.Cells("total_desconto").Value
                txtValorImpostosProdutoOrcamento.Value = grdProduto.GetTotalRow.Cells("valor_ipi").Value
                txtValorImpostosProdutoOrcamento.Value += grdProduto.GetTotalRow.Cells("valor_icms").Value
                txtValorImpostosProdutoOrcamento.Value += grdProduto.GetTotalRow.Cells("valor_pis_cofins").Value
                txtValorImpostosProdutoOrcamento.Value += grdProduto.GetTotalRow.Cells("valor_icms_st").Value
                cboModalidadeFrete.Enabled = True
                txtValorFreteOrcamento.Enabled = True
            Else
                cboModalidadeFrete.SelectedIndex = -1 : cboModalidadeFrete.Enabled = False
                txtValorFreteOrcamento.Value = 0 : txtValorFreteOrcamento.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub txtDescontoPercentualProduto_ValueChanged(sender As Object, e As EventArgs) Handles txtDescontoPercentualProduto.ValueChanged

        Try

            txtDescontoValorProduto.Value = txtValorUnitarioProduto.Value * ((txtDescontoPercentualProduto.Value / 100.0))

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
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.ComercialOrcamento)

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
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & TipoItem.produto)

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

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                cboCliente.Focus()
                Exit Sub
            End If

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = LoadDescricao("sp_select_configuracao_interacti_texto " & goUsuario.iEmpresa & ",'formulario_find_produto_orcamento'")
            oForm.UsrControl = IIf(oForm.UsrControl = "", "usrFindItem", oForm.UsrControl)
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros            
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = "S"
            sItemAtivoFixoFind = ""
            sItemEstoqueFind = ""
            sItemCompraFind = ""
            sItemProducaoFind = ""
            bInserirProdutoFind = True
            sTipoFind = "VENDAS"
            sTelaVenda = "ORCAMENTO"
            iCodigoClienteGlobal = IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue)
            sClienteGlobal = cboCliente.Text
            lCodigoVendaGlobal = btnSalvar.Tag
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Grid
            Call LoadGridProduto()

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntregaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmembrarPrevisaoEntregaProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Seleciona o Campo - Produto
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeProduto, lblQuantidadeProduto, True) = False Then
                Exit Sub
            End If

            'Desmembrar Entrega
            Call DesmembrarEntregaItem(cboProduto.Text & " - " & txtDescricaoProduto.Text, _
                                       txtQuantidadeProduto.Value, _
                                       dtpPrevisaoEntregaProduto, _
                                       oDataEntregaProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Sub
            End If

            'Valida Dados do Item
            If ValidacaoProduto() = True Then

                'Salva Dados do Registro
                Call InsertProduto()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()
                'Carrega Grid
                Call LoadGridProduto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProduto.Click

        Try

            'Deleta Registros
            Call DeleteProduto()

            'Limpa Formulário
            Call NovoProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged, _
                                                                                                                    cboCliente.SelectedIndexChanged, _
                                                                                                                    txtQuantidadeProduto.ValueChanged

        Try

            'Váriaveis Locais
            Dim sDescricao As String = ""
            Dim iCodigoUnidadeMedida As Integer
            Dim dQuantidadeEstoque As Double
            Dim dPrecoVenda As Double = 0
            Dim dDescontoPercentual As Double = 0
            Dim dDescontoValor As Double = 0
            Dim dPrecoTabela As Double = 0
            Dim iLeadTime As Integer

            Dim bICMSEmbutido As Boolean = True
            Dim bPISCOFINSEmbutido As Boolean = True
            Dim bIPIEmbutido As Boolean = False
            Dim dAliquotaICMS As Double = 0
            Dim dAliquotaPISCOFINS As Double = 0
            Dim dAliquotaIPI As Double = 0
            Dim dAliquotaICMSST As Double = 0
            Dim dValorICMSST As Double = 0
            Dim sObservacaoVenda As String = ""

            'Limpa / Desabilita Controles
            txtDescontoPercentualProduto.Value = 0
            txtAliquotaICMSST.Value = 0
            txtValorICMSST.Value = 0
            txtDescontoValorProduto.Value = 0
            txtValorUnitarioProduto.Value = 0
            txtDescontoPercentualProduto.Enabled = True
            txtDescontoValorProduto.Enabled = True
            txtValorUnitarioProduto.Enabled = True

            'Limpa Váriaveis
            dQuantidadeMinima = 0
            dMultiploVenda = 0
            bAcordoComercial = False
            lCodigoAcordoComercial = -1
            iCodigoAcordoComercialItem = -1
            dPrecoMinimo = 0
            dCustoTeorico = -1
            bAcordoComercial = False
            sDescricao = ""
            iCodigoUnidadeMedida = 0
            dQuantidadeEstoque = 0
            iLeadTime = 0
            bItemEstoque = False
            bItemProducao = False
            iCodigoFormaVendaProduto = FormaVendaItem.Indefinido
            iCodigoFormaVendaServico = FormaVendaItem.Indefinido
            lCodigoRegraFaturamento = -1
            frmMain.errInfo.Clear()

            'Verifica se Foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Dados do Produto
                Call oClsCadProduto.LoadDadosProduto(cboProduto.SelectedValue, _
                                                     "", _
                                                     IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue), _
                                                     IIf(cboDestinacaoProduto.SelectedIndex = -1, -1, cboDestinacaoProduto.SelectedValue), _
                                                     IIf(txtQuantidadeProduto.Value > 0, txtQuantidadeProduto.Value, 1), _
                                                     dtpDataOrcamento.Value, _
                                                     sDescricao, _
                                                     iCodigoUnidadeMedida, _
                                                     dQuantidadeEstoque, _
                                                     bItemEstoque, _
                                                     bItemProducao, _
                                                     iCodigoFormaVendaProduto, _
                                                     dPrecoTabela, _
                                                     dDescontoPercentual, _
                                                     dDescontoValor, _
                                                     dPrecoVenda, _
                                                     dPrecoMinimo, _
                                                     dCustoTeorico, _
                                                     iLeadTime,
                                                     bICMSEmbutido, _
                                                     dAliquotaICMS, _
                                                     bIPIEmbutido, _
                                                     dAliquotaIPI, _
                                                     bPISCOFINSEmbutido, _
                                                     dAliquotaPISCOFINS, _
                                                     dQuantidadeMinima, _
                                                     dMultiploVenda, _
                                                     bAcordoComercial, _
                                                     lCodigoAcordoComercial, _
                                                     iCodigoAcordoComercialItem, _
                                                     sObservacaoVenda, _
                                                     lCodigoRegraFaturamento)

                'Habilita / Desabilita Controles
                chkICMSEmbutido.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                txtAliquotaICMSProduto.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                chkIPIEmbutido.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                txtAliquotaIPIProduto.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                chkPISCOFINSEmbutido.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                txtAliquotaPISCOFINSProduto.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)

                'Carrega Controles
                txtDescricaoProduto.Text = sDescricao
                txtQuantidadeEstoqueProduto.Value = dQuantidadeEstoque
                cboUnidadeMedidaProduto.SelectedValue = iCodigoUnidadeMedida
                txtValorUnitarioProduto.Value = dPrecoVenda
                txtDescontoPercentualProduto.Value = dDescontoPercentual
                txtAliquotaICMSST.Value = dAliquotaICMSST
                txtValorICMSST.Value = dValorICMSST
                txtDescontoValorProduto.Value = dDescontoValor
                chkICMSEmbutido.Checked = bICMSEmbutido
                txtAliquotaICMSProduto.Value = dAliquotaICMS
                chkIPIEmbutido.Checked = bIPIEmbutido
                txtAliquotaIPIProduto.Value = dAliquotaIPI
                chkPISCOFINSEmbutido.Checked = bPISCOFINSEmbutido
                txtAliquotaPISCOFINSProduto.Value = dAliquotaPISCOFINS
                If sObservacaoVenda = "" Then frmMain.errInfo.Clear() Else frmMain.errInfo.SetError(lblDescricaoProduto, sObservacaoVenda)

                If bAcordoComercial = True Then
                    txtDescontoPercentualProduto.Enabled = False
                    txtDescontoValorProduto.Enabled = False
                    txtValorUnitarioProduto.Enabled = False
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            'Verifica Coluna Pressionada
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
                                     Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.ComercialOrcamento, _
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
                                          Formulario.ComercialOrcamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorTotal() Handles txtQuantidadeProduto.ValueChanged, _
                                            txtValorUnitarioProduto.ValueChanged, _
                                            txtDescontoValorProduto.ValueChanged

        Try

            'Calcula Valor Total
            txtValorUnitarioDesconto.Value = txtValorUnitarioProduto.Value - txtDescontoValorProduto.Value
            txtValorTotalProduto.Value = txtQuantidadeProduto.Value * (txtValorUnitarioProduto.Value - (txtDescontoValorProduto.Value))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorTotalImpostos() Handles txtValorTotalProduto.ValueChanged, _
                                                    chkICMSEmbutido.CheckedChanged, _
                                                    txtAliquotaICMSProduto.ValueChanged, _
                                                    chkIPIEmbutido.CheckedChanged, _
                                                    txtAliquotaIPIProduto.ValueChanged, _
                                                    chkPISCOFINSEmbutido.CheckedChanged, _
                                                    txtAliquotaPISCOFINSProduto.ValueChanged

        Try

            Dim dValorUnitarioImposto As Double = 0
            Dim dQuantidade As Double = IIf(IsNumeric(txtQuantidadeProduto.Value), txtQuantidadeProduto.Value, 0)
            Dim dValorUnitario As Double = IIf(IsNumeric(txtValorUnitarioProduto.Value), txtValorUnitarioProduto.Value, 0)
            Dim dAliquotaICMS As Double = IIf(IsNumeric(txtAliquotaICMSProduto.Value), txtAliquotaICMSProduto.Value, 0) / 100.0
            Dim dAliquotaPISCOFINS As Double = IIf(IsNumeric(txtAliquotaPISCOFINSProduto.Value), txtAliquotaPISCOFINSProduto.Value, 0) / 100.0
            Dim dAliquotaIPI As Double = IIf(IsNumeric(txtAliquotaIPIProduto.Value), txtAliquotaIPIProduto.Value, 0) / 100.0

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

            'Seta Controle - Valor Total Imposto
            txtValorTotalImpostoProduto.Value = ((IIf(IsNumeric(txtValorUnitarioDesconto.Value), txtValorUnitarioDesconto.Value, 0) + IIf(chkICMSEmbutido.Checked = True, 0, txtAliquotaICMSProduto.Tag) + IIf(chkPISCOFINSEmbutido.Checked = True, 0, txtAliquotaPISCOFINSProduto.Tag) + IIf(chkIPIEmbutido.Checked = True, 0, txtAliquotaIPIProduto.Tag)) * dQuantidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Private Sub btnAgruparGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridServico.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdServico.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdServico.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdServico.GroupByBoxVisible = True
                grdServico.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridServico.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdServico
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdServico, Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridServico.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadServico")

            'Carrega Combo            
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarServico.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.servico
            oComboBoxFind = cboServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProducaoServico_Click(sender As Object, e As EventArgs)

        Try

            'Verifica se foi Selecionado - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Sub
            End If

            'Váriavel - Formulário de Procurar Item
            Dim oForm As New frmVenOrcamentoServico

            'Seta Parâmetros
            oForm.CodigoItem = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)
            oForm.CodigoParceiroNegocio = cboCliente.SelectedValue

            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & TipoItem.servico)
            If oForm.CodigoItem <> -1 Then
                cboServico.SelectedValue = oForm.CodigoItem
                Call cboServico_SelectedIndexChanged(cboServico, System.EventArgs.Empty)
            End If

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRedimensionarComplementoServico_Click(sender As Object, e As EventArgs) Handles btnRedimensionarComplementoServico.Click

        Try

            'Verifica o Tipo de Operação
            If btnRedimensionarComplementoServico.Tag = "MIN" Then

                'Oculta Controles
                lblQuantidadeServico.Visible = False
                btnCadastrarUnidadeMedidaServico.Visible = False
                lblUnidadeMedidaServico.Visible = False
                btnDesmembrarPrevisaoEntregaServico.Visible = False
                lblPrevisaoEntregaServico.Visible = False
                lblValorServico.Visible = False

                txtComplemento.ScrollBars = Windows.Forms.ScrollBars.Vertical

                btnRedimensionarComplementoServico.Tag = "MAX"

            Else

                'Oculta Controles
                lblQuantidadeServico.Visible = True
                btnCadastrarUnidadeMedidaServico.Visible = True
                lblUnidadeMedidaServico.Visible = True
                btnDesmembrarPrevisaoEntregaServico.Visible = True
                lblPrevisaoEntregaServico.Visible = True
                lblValorServico.Visible = True

                txtComplemento.Width = 382
                txtComplemento.Height = 20
                txtComplemento.ScrollBars = Windows.Forms.ScrollBars.None

                btnRedimensionarComplementoServico.Tag = "MIN"

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntregaServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmembrarPrevisaoEntregaServico.Click

        Try

            'Limpa o Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeServico, lblQuantidadeServico, True) = False Then
                Exit Sub
            End If

            'Desmembrar Entrega
            Call DesmembrarEntregaItem(cboServico.Text & " - " & txtDescricaoServico.Text, _
                                       txtQuantidadeServico.Value, _
                                       dtpPrevisaoEntregaServico, _
                                       oDataEntregaServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirServico.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Sub
            End If

            'Valida Dados do Serviço
            If ValidacaoServico() = True Then

                'Salva Dados do Registro
                Call InsertServico()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoServico()
                'Carrega Grid
                Call LoadGridServico()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirServico.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados do Registro
            Call DeleteServico()

            'Prepara Formulário
            Call NovoServico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Váriaveis Locais
            Dim sDescricao As String = ""

            'Verifica se Foi Selecionado algum Registro
            If cboServico.SelectedIndex = -1 Then

                'Limpa Váriaveis
                txtDescricaoServico.Text = ""
                txtAliquotaINSS.Value = 0

            Else

                'Carrega Dados do Serviço
                oClsVenOrcamento.LoadDadosServico(cboServico.SelectedValue, _
                                               txtDescricaoServico, _
                                               txtAliquotaISS)


            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorLiquido() Handles txtDescontoServico.LostFocus, _
                                              txtValorServico.LostFocus, _
                                              txtQuantidadeServico.LostFocus

        Try

            'Calcula Valor Total
            txtValorTotalServico.Value = (txtQuantidadeServico.Value * (txtValorServico.Value - txtDescontoServico.Value))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaAliquotaICMSST() Handles txtAliquotaICMSST.LostFocus

        Try

            Dim dAliquotaICMSST As Double = IIf(IsNumeric(txtAliquotaICMSST.Value), txtAliquotaICMSST.Value, 0) / 100.0
            txtValorICMSST.Value = dAliquotaICMSST * txtValorUnitarioProduto.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorICMSST() Handles txtValorICMSST.LostFocus

        Try

            'Calcula Valor Unitário
            txtValorUnitarioProduto.Value = (txtValorUnitarioProduto.Value + txtValorICMSST.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdServico.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdServico.CurrentColumn) Then Exit Sub

            'Verifica Coluna Pressionada
            Select Case grdServico.CurrentColumn.Key

                Case "editar" : Call EditarServico()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdServico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdServico, _
                                     Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdServico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdServico.Name, _
                                     Formulario.ComercialOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdServico.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdServico.Name, _
                                          Formulario.ComercialOrcamento, _
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
            oForm.NomeFormulario = Formulario.ComprasRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.ComprasRequisicao)

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
                    Call InsertArquivoBD("tb_ven_orcamento", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_ven_orcamento", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_ven_orcamento", btnSalvar.Tag)

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
            If IsNothing(grdArquivo.CurrentRow) Then Exit Sub

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
                                     Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ComprasRequisicao, _
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
                                          Formulario.ComprasRequisicao, _
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
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVenOrcamento_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcPrint)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarTransportadora.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarCondicaoPagamento.Enabled = VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcInsert)
            btnCadastrarProbabilidadeVenda.Enabled = VerificaDireito(Formulario.CadastroBasicoProbabilidadeExitoVenda, gcInsert)
            btnCadastrarCondicaoFornecimento.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarTermoGarantia.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarObservacaoVenda.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)
            btnCadastrarIncoterms.Enabled = VerificaDireito(Formulario.CadastroBasicoIncoterms, gcInsert)
            btnCadastrarCampanha.Enabled = VerificaDireito(Formulario.CadastroBasicoCampanhaAbrangencia, gcInsert)

            'Tipo - Combobox
            ReDim oTipoComboBox(2)
            oTipoComboBox(0).oColor = Color.Red : oTipoComboBox(0).sTipo = 1
            oTipoComboBox(1).oColor = Color.Peru : oTipoComboBox(1).sTipo = 2
            oTipoComboBox(2).oColor = Color.Black : oTipoComboBox(2).sTipo = 3

            'Carrega ComboBox            
            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, "sp_select_combo_cadastro_basico_cliente_negativacao " & goUsuario.iEmpresa, oTipoComboBox)
            LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, "sp_select_combo_cadastro_basico_cliente_negativacao " & goUsuario.iEmpresa, oTipoComboBox)
            LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete")
            LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)
            LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
            LoadCombo(cboDestinacaoFiltro, "sp_select_combo_static_destinacao")
            LoadCombo(cboTipoItemFiltro, "sp_select_combo_static_tipo_item")
            LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboProbabilidadeVenda, "sp_select_combo_cadastro_basico_probabilidade_exito_venda " & goUsuario.iEmpresa, False)
            LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
            LoadCombo(cboCampanha, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa, False)
            LoadCombo(cboItemFiltro, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", 1, NULL, -1")
            LoadCombo(cboStatus, "sp_select_combo_static_status_orcamento", False)
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_orcamento")
            LoadCombo(cboModalidade, "sp_select_static_modalidade_orcamento")

            'Configura DateTimer
            dtpDataOrcamentoInicioFiltro.Value = DateAdd(DateInterval.Day, (DatePart(DateInterval.Day, Now.Date) - 1) * -1, Now.Date) : dtpDataOrcamentoInicioFiltro.Checked = True
            dtpDataOrcamentoTerminoFiltro.Value = Now.Date : dtpDataOrcamentoTerminoFiltro.Checked = False

            'Seta Controles
            cboModalidadeFrete.Enabled = False
            txtValorFreteOrcamento.Enabled = False

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Verifica o Direito do Usuário - Item
            If VerificaDireito(Formulario.ComercialOrcamentoDadosProduto, gcInsert) = True Then

                'Verifica Direito
                btnInserirProduto.Enabled = VerificaDireito(Formulario.ComercialOrcamentoDadosProduto, gcInsert)
                btnExcluirProduto.Enabled = VerificaDireito(Formulario.ComercialOrcamentoDadosProduto, gcDelete)
                btnExcelGridProduto.Enabled = VerificaDireito(Formulario.ComercialOrcamentoDadosProduto, gcPrint)

                'Verifica Direito - Botão de Cadastro
                btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                btnCadastrarUnidadeMedidaProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

                'Carrega Combo
                Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto))
                Call LoadCombo(cboDestinacaoProduto, "sp_select_combo_static_destinacao")
                Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            Else
                tabDados.TabPages.Remove(pagProduto)
            End If

            'Verifica o Direito do Usuário - Serviço
            If VerificaDireito(Formulario.ComercialOrcamentoDadosServico, gcInsert) = True Then

                'Verifica Direito
                btnInserirServico.Enabled = VerificaDireito(Formulario.ComercialOrcamentoDadosServico, gcInsert)
                btnExcluirServico.Enabled = VerificaDireito(Formulario.ComercialOrcamentoDadosServico, gcDelete)
                btnExcelGridServico.Enabled = VerificaDireito(Formulario.ComercialOrcamentoDadosServico, gcPrint)

                'Verifica Direito - Botão de Cadastro
                btnCadastrarServico.Enabled = VerificaDireito(Formulario.CadastroBasicoServico, gcInsert)
                btnCadastrarUnidadeMedidaServico.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

                'Carrega Combo
                Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico), False)
                Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            Else
                tabDados.TabPages.Remove(pagServico)
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialOrcamento)
            Call ConfiguraGrid(grdProduto, Formulario.ComercialOrcamento)
            Call ConfiguraGrid(grdServico, Formulario.ComercialOrcamento)
            Call ConfiguraGrid(grdArquivo, Formulario.ComercialOrcamento)

            'Seta Focu
            txtNumeroOrcamentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub AdicionarHoras()

        Try

            Dim oForm As New frmVenOrcamentoAdicionarHoras
            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo_orcamento").Value
            oForm.ShowDialog()

            LoadGridOrcamento()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridOrcamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sStatus As String = ""

            'Status
            For Each oRow As GridEXRow In cboStatusFiltro.DropDownList.GetCheckedRows
                sStatus &= IIf(sStatus = "", "", ",") & oRow.Cells("codigo").Value
            Next

            'Carrega Controles
            oClsVenOrcamento.LoadGridOrcamento(grdListagem, _
                                               IIf(IsNumeric(txtNumeroOrcamentoFiltro.Text.Trim), txtNumeroOrcamentoFiltro.Text.Trim, -1), _
                                               IIf(dtpDataOrcamentoInicioFiltro.Checked = False, "", dtpDataOrcamentoInicioFiltro.Value), _
                                               IIf(dtpDataOrcamentoTerminoFiltro.Checked = False, "", dtpDataOrcamentoTerminoFiltro.Value), _
                                               IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                               sStatus, _
                                               IIf(cboDestinacaoFiltro.SelectedIndex = -1, -1, cboDestinacaoFiltro.SelectedValue), _
                                               IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue), _
                                               IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                               cboItemFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrcamento(ByVal lCodigoOrcamento As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialOrcamento, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoOrcamento()

                'Seta Código
                oClsVenOrcamento.CodigoOrcamento = lCodigoOrcamento
                'Seta Controle
                btnSalvar.Tag = lCodigoOrcamento

                'Carrega Controles
                oClsVenOrcamento.LoadControlesOrcamento(lCodigoOrcamento, _
                                                        txtNumeroOrcamento, _
                                                        dtpDataOrcamento, _
                                                        cboCliente, _
                                                        cboModalidadeFrete, _
                                                        cboIncoterms, _
                                                        cboCampanha, _
                                                        cboTransportadora, _
                                                        cboProbabilidadeVenda, _
                                                        dtpPrevisaoVenda, _
                                                        txtTermoGarantia, _
                                                        txtCondicaoFornecimento, _
                                                        txtObservacao, _
                                                        txtReferencia, _
                                                        txtOrcamentista, _
                                                        dtpDataSolicitacaoOrcamento, _
                                                        cboCondicaoPagamento, _
                                                        cboFormaPagamento, _
                                                        cboMoeda, _
                                                        txtFatorCambial, _
                                                        txtValorTotalOrcamento, _
                                                        txtValorDescontoOrcamento, _
                                                        txtValorImpostosProdutoOrcamento, _
                                                        txtValorImpostosServicoOrcamento, _
                                                        txtDescontoGeral, _
                                                        txtAcrescimoGeral, _
                                                        txtValorFreteOrcamento, _
                                                        txtValorFinalOrcamento, _
                                                        cboStatus, _
                                                        dtpPrazoResposta, _
                                                        cboModalidade)

                'Carrega Grid de Arquivo
                Call LoadGridArquivoBD(grdArquivo, "tb_ven_orcamento", lCodigoOrcamento)

                'Carrega Grid de Produto
                Call LoadGridProduto()

                'Carrega Grid de Serviço
                Call LoadGridServico()

                'Verifica se existe produto lançado
                If grdProduto.GetDataRows.Count > 0 Then cboModalidadeFrete.Enabled = True : txtValorFreteOrcamento.Enabled = True

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcPrint)

                'Calcula Desconto / Acréscimo Percentual
                Call txtDescontoGeral_LostFocus(txtDescontoGeral, System.EventArgs.Empty)
                Call txtAcrescimoGeral_LostFocus(txtAcrescimoGeral, System.EventArgs.Empty)

                'Seta Aba
                If tabDados.TabPages.Contains(pagProduto) Then
                    tabDados.SelectedTab = pagProduto
                ElseIf tabDados.TabPages.Contains(pagServico) Then
                    tabDados.SelectedTab = pagServico
                Else
                    tabDados.SelectedTab = pagDadosGerais
                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                If tabMain.TabPages.Contains(pagDados) = False Then tabMain.TabPages.Add(pagDados)

                'Seta Focu
                dtpDataOrcamento.Focus()

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

    Private Sub NovoOrcamento()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            LimparCamposGroupBox(grpDadosTerceiros)
            LimparCamposGroupBox(grpDadosTerceirosServico)

            'Limpa Controles - Dados Gerais
            cboModalidade.SelectedIndex = -1
            dtpPrazoResposta.Value = Now.Date
            cboStatus.SelectedIndex = -1
            txtNumeroOrcamento.Text = ""
            dtpDataOrcamento.Value = Now.Date
            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'data_orcamento_maior_atual'"), Boolean) = False Then
                dtpDataOrcamento.MaxDate = Now.Date
            End If
            cboStatus.SelectedIndex = -1
            cboCliente.SelectedIndex = -1 : cboCliente.Enabled = True
            cboModalidadeFrete.SelectedIndex = -1
            cboTransportadora.SelectedIndex = -1
            cboIncoterms.SelectedIndex = -1
            cboCampanha.SelectedIndex = -1
            cboProbabilidadeVenda.SelectedIndex = -1
            dtpPrevisaoVenda.Value = Now.Date : dtpPrevisaoVenda.Checked = False
            txtTermoGarantia.Text = ""
            txtCondicaoFornecimento.Text = ""
            txtObservacao.Text = ""
            txtReferencia.Text = ""
            txtOrcamentista.Text = ""
            dtpDataSolicitacaoOrcamento.Value = Now.Date : dtpDataSolicitacaoOrcamento.Checked = False
            cboCondicaoPagamento.SelectedIndex = -1
            cboFormaPagamento.SelectedIndex = -1
            cboMoeda.SelectedIndex = -1
            txtFatorCambial.Value = 0
            txtValorTotalOrcamento.Value = 0
            txtValorDescontoOrcamento.Value = 0
            txtValorImpostosProdutoOrcamento.Value = 0
            txtValorImpostosServicoOrcamento.Value = 0
            txtDescontoGeral.Value = 0
            txtDescontoGeralPercentual.Value = 0
            txtAcrescimoGeral.Value = 0
            txtAcrescimoGeralPercentual.Value = 0
            txtValorFreteOrcamento.Value = 0
            txtValorFinalOrcamento.Value = 0
            btnSalvar.Tag = ""
            If VerificaDireito(Formulario.ComercialOrcamento, gcAdministrator) = False Then
                dtpDataOrcamento.MinDate = Now.Date
                dtpDataOrcamento.MaxDate = Now.Date
            Else
                dtpDataOrcamento.MinDate = DateAdd(DateInterval.Year, -10, Now.Date)
                dtpDataOrcamento.MaxDate = DateAdd(DateInterval.Year, +10, Now.Date)
            End If

            'Limpa Váriaveis
            oDataEntregaProduto.Clear()
            oDataEntregaServico.Clear()

            'Limpa Controles - Produto
            cboProduto.SelectedIndex = -1 : cboProduto.Text = "" : cboProduto.Tag = ""
            txtDescricaoProduto.Text = ""
            txtComplementoProduto.Text = ""
            cboDestinacaoProduto.SelectedIndex = -1
            txtQuantidadeProduto.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            chkIPIEmbutido.Checked = False
            txtAliquotaIPIProduto.Value = 0
            txtAliquotaIPIProduto.Tag = ""
            chkICMSEmbutido.Checked = True
            txtAliquotaICMSProduto.Value = 0
            txtAliquotaICMSProduto.Tag = ""
            chkPISCOFINSEmbutido.Checked = True
            txtAliquotaPISCOFINSProduto.Value = 0
            txtAliquotaPISCOFINSProduto.Tag = ""
            txtDescontoPercentualProduto.Value = 0
            txtDescontoValorProduto.Value = 0
            txtValorUnitarioProduto.Value = 0
            txtValorTotalProduto.Value = 0
            dtpPrevisaoEntregaProduto.Value = Now.Date : dtpPrevisaoEntregaProduto.Tag = ""
            dtpPrevisaoEntregaProduto.BackColor = System.Drawing.SystemColors.Window
            btnInserirProduto.Tag = ""
            dPrecoMinimo = 0
            iCodigoUsuarioItem = goUsuario.iUsuario
            sLiberacaoItem = ""
            grdProduto.DataSource = Nothing

            'Limpa Controles - Serviço
            cboServico.SelectedIndex = -1
            txtDescricaoServico.Text = ""
            txtComplemento.Text = ""
            txtQuantidadeServico.Value = 0
            cboUnidadeMedidaServico.SelectedIndex = -1
            txtValorServico.Value = 0
            dtpPrevisaoEntregaServico.Tag = ""
            dtpPrevisaoEntregaServico.Value = Now.Date
            dtpPrevisaoEntregaServico.BackColor = System.Drawing.SystemColors.Window
            txtDescontoServico.Value = 0
            txtValorTotalServico.Value = 0
            chkISSRetido.Checked = False
            txtAliquotaISS.Value = 0
            txtAliquotaPIS.Value = 0
            txtAliquotaCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtAliquotaCSLL.Value = 0
            txtAliquotaIR.Value = 0
            btnInserirServico.Tag = ""
            grdServico.DataSource = Nothing
            btnRedimensionarComplementoServico.Tag = "MAX" : Call btnRedimensionarComplementoServico_Click(btnRedimensionarComplementoServico, System.EventArgs.Empty)

            'Limpa Controles - Arquivo
            txtDescricaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcInsert)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcDelete)
            btnImprimir.Enabled = False

            'Seta Aba
            If tabDados.TabPages.Contains(pagProduto) Then
                tabDados.SelectedTab = pagProduto
            ElseIf tabDados.TabPages.Contains(pagServico) Then
                tabDados.SelectedTab = pagServico
            Else
                tabDados.SelectedTab = pagDadosGerais
            End If

            'Seta Valor Default
            Call ConfigureValorDefault(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarOrcamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsVenOrcamento.CodigoOrcamento = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsVenOrcamento.DataOrcamento = dtpDataOrcamento.Value
            oClsVenOrcamento.CodigoCliente = cboCliente.SelectedValue
            oClsVenOrcamento.CodigoModalidadeFrete = IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue)
            oClsVenOrcamento.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsVenOrcamento.CodigoProbabilidadeExitoVenda = IIf(cboProbabilidadeVenda.SelectedIndex = -1, -1, cboProbabilidadeVenda.SelectedValue)
            oClsVenOrcamento.DataPrevisaoVenda = IIf(dtpPrevisaoVenda.Checked = True, dtpPrevisaoVenda.Value, "")
            oClsVenOrcamento.TermoGarantia = txtTermoGarantia.Text.Trim
            oClsVenOrcamento.SolicitacaoOrcamento = txtOrcamentista.Text.Trim
            oClsVenOrcamento.DataSolicitacaoOrcamento = IIf(dtpDataSolicitacaoOrcamento.Checked = False, "", dtpDataSolicitacaoOrcamento.Value)
            oClsVenOrcamento.CondicaoFornecimento = txtCondicaoFornecimento.Text.Trim
            oClsVenOrcamento.Observacao = txtObservacao.Text.Trim
            oClsVenOrcamento.Referencia = txtReferencia.Text.Trim
            oClsVenOrcamento.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)
            oClsVenOrcamento.CodigoFormaPagamento = IIf(cboFormaPagamento.SelectedIndex = -1, -1, cboFormaPagamento.SelectedValue)
            oClsVenOrcamento.CodigoMoeda = IIf(cboMoeda.SelectedIndex = -1, -1, cboMoeda.SelectedValue)
            oClsVenOrcamento.CodigoIncoterms = IIf(cboIncoterms.SelectedIndex = -1, -1, cboIncoterms.SelectedValue)
            oClsVenOrcamento.CodigoCampanha = IIf(cboCampanha.SelectedIndex = -1, -1, cboCampanha.SelectedValue)
            oClsVenOrcamento.FatorCambial = txtFatorCambial.Value
            oClsVenOrcamento.ValorTotal = txtValorTotalOrcamento.Value
            oClsVenOrcamento.ValorDesconto = txtValorDescontoOrcamento.Value
            oClsVenOrcamento.DescontoGeral = txtDescontoGeral.Value
            oClsVenOrcamento.AcrescimoGeral = txtAcrescimoGeral.Value
            oClsVenOrcamento.ValorFrete = txtValorFreteOrcamento.Value
            oClsVenOrcamento.ValorFinal = txtValorFinalOrcamento.Value
            oClsVenOrcamento.Tipo = Me.Tag
            oClsVenOrcamento.Status = IIf(cboStatus.SelectedIndex = -1, -1, cboStatus.SelectedValue)
            oClsVenOrcamento.PrazoResposta = dtpPrazoResposta.Value
            oClsVenOrcamento.Modalidade = IIf(cboModalidade.SelectedIndex = -1, -1, cboModalidade.SelectedValue)

            oClsVenOrcamento.Update()

            'Seta Controle
            txtNumeroOrcamento.Text = oClsVenOrcamento.NumeroOrcamento

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            If cboStatus.SelectedValue = 1 Then
                oClsVenOrcamento.EnviarEmail(btnSalvar.Tag, _
                                         cboCliente.SelectedValue)
            End If
            

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarOrcamentoTotal()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Atualiza Registro
            Call oClsVenOrcamento.UpdateTotais(dtpDataOrcamento.Value, _
                                               txtValorTotalOrcamento.Value, _
                                               txtValorDescontoOrcamento.Value, _
                                               txtDescontoGeral.Value, _
                                               txtAcrescimoGeral.Value, _
                                               txtValorFreteOrcamento.Value, _
                                               txtValorFinalOrcamento.Value, _
                                               IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteOrcamento()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsVenOrcamento.Delete()
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

    Private Sub EmailOrcamento()

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "ORÇAMENTO"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Carrega Váriavel
            sReport &= ".rpt"

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_orcamento", grdListagem.CurrentRow.Cells("codigo_orcamento").Value)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Arquivo
            Dim sArquivo As String = System.IO.Path.GetTempPath
            sArquivo &= grdListagem.CurrentRow.Cells("numero_orcamento").Value.ToString.Replace("/", "-").Replace("\", "-") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Orçamento " & grdListagem.CurrentRow.Cells("numero_orcamento").Value, _
                             LoadContatoOrcamento(grdListagem.CurrentRow.Cells("codigo_orcamento").Value), _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             grdListagem.CurrentRow.Cells("codigo_cliente").Value, _
                             "", _
                             -1, _
                             -1, _
                             TipoAutotextoEmail.OrcamentoVenda)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExportarPDF()

        Try

            'Váriaveis Locais
            'Váriaveis Locais
            Dim oFolder As New FolderBrowserDialog

            'Abre Pasta
            oFolder.ShowDialog()

            'Caso selecionado alguma Pasta
            If oFolder.SelectedPath <> "" Then

                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriavel - Relatório
                Dim sReport As String

                'Váriavel - Formulário
                Dim oForm As New frmRptSelecionar
                oForm.Tipo = "ORÇAMENTO"
                oForm.ShowDialog(Me)
                sReport = oForm.Relatorio

                'Verifica o Relatório
                If sReport = "" Then Exit Sub

                'Carrega Váriavel
                sReport &= ".rpt"

                'Abre Relatório
                oRptDocument.Load(goCrystalReport.sPath & sReport, _
                                  CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                'Seta Parametros Relatório
                oRptDocument.SetParameterValue("@codigo_orcamento", grdListagem.CurrentRow.Cells("codigo_orcamento").Value)
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
                oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

                'Abre Conexão com o Banco de Dados
                For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                'Arquivo
                Dim sArquivo As String = oFolder.SelectedPath
                sArquivo &= grdListagem.CurrentRow.Cells("numero_orcamento").Value.ToString.Replace("/", "-").Replace("\", "-") & ".pdf"

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                          sArquivo)

                'Limpa Váriavel
                oRptDocument = Nothing

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirOrcamento(ByVal lCodigoOrcamento As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "ORÇAMENTO"
            oForm.ShowDialog(Me)
            sReport = "VEN000000001 - P"

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Carrega Váriavel
            sReport &= ".rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_orcamento"
            goCrystalReport.sReportParameter(1).sValue = lCodigoOrcamento
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Arquivo = True
            oReport.Tabela = "tb_ven_orcamento"
            oReport.Codigo = lCodigoOrcamento
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("VEN000000001 - P", "Orçamento", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DuplicarOrcamento()

        Try

            'Verifica se foi Selecionado Algum Cliente
            If MsgBox("Deseja Duplicar o Orçamento Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Duplica Orçamento
                oClsVenOrcamento.Duplicar(grdListagem.CurrentRow.Cells("codigo_orcamento").Value, _
                                          Me.Tag)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega o Orçamento
                Call EditarOrcamento(oClsVenOrcamento.CodigoOrcamento)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirRevisaoOrcamento()

        Try

            'Verifica se o Registro é Válido
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusOrcamentoItem.Orcamento) Then

                'Verifica se foi Selecionado Algum Cliente
                If MsgBox("Deseja Gerar Nova Revisão do Orçamento Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Duplica Pedido de Venda
                    oClsVenOrcamento.InsertRevisao(grdListagem.CurrentRow.Cells("codigo_orcamento").Value)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Carrega o Pedido de Venda
                    Call EditarOrcamento(oClsVenOrcamento.CodigoOrcamento)

                End If

            Else

                'Informa o Usuário sobre a necessidade de selecionar um Registro Válido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione um Registro com Status = Pedido de Venda.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirHistorico()

        Try

            'Váriaveis - Formulário
            Dim oForm As New frmVenOrcamentoHistoricoInserir
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Controle
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoOrcamento()

        Try


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoOrcamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoOrcamento = False

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                tabDados.SelectedTab = pagProduto
                cboCliente.Focus()
                Exit Function
            End If

            'Verifica se foi inserido algum Item
            If grdProduto.GetDataRows.Count = 0 And grdServico.GetDataRows.Count = 0 Then
                tabDados.SelectedTab = pagProduto
                frmMain.Informacao(Mensagem.ValidacaoInserir)
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade de Frete
            If grdProduto.GetDataRows.Count > 0 Then
                If ValidaCampo(cboModalidadeFrete, lblModalidadeFrete) = False Then
                    tabDados.SelectedTab = pagDadosGerais
                    cboModalidadeFrete.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Condição de Pagamento
            If ValidaCampo(cboCondicaoPagamento, lblCondicaoPagamento) = False Then
                tabDados.SelectedTab = pagDadosGerais
                cboCondicaoPagamento.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoeda, lblMoeda) = False Then
                tabDados.SelectedTab = pagDadosGerais
                cboMoeda.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoOrcamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ITEM :::"

#Region "::: GERAL :::"

    Private Sub HistoricoItemOrcamento()

        Try



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DesmembrarEntregaItem(ByVal sItem As String, _
                                      ByVal dQuantidade As Double, _
                                      ByVal dtpPrevisaoEntrega As CalendarCombo, _
                                      ByVal oDataEntrega As Hashtable)

        Try

            'Váriavel - Formulário
            Dim oForm As New frmVenOrcamentoItemDesmembrarEntrega
            'Seta Parâmetros
            oForm.Item = sItem
            oForm.Quantidade = dQuantidade
            oForm.DataEntrega = oDataEntrega
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Verifica se foi gerado a Data de Entrega
            If oDataEntrega.Count > 0 Then

                'Váriavel Local
                Dim oPrevisaoEntrega As PrevisaoEntrega = oDataEntrega.Item(0)
                'Seta Controle
                dtpPrevisaoEntrega.Value = oPrevisaoEntrega.sPrevisaoEntrega

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Produtos
            cboProduto.SelectedIndex = -1 : cboProduto.Text = "" : cboProduto.Tag = ""
            txtDescricaoProduto.Text = ""
            txtComplementoProduto.Text = ""
            txtQuantidadeProduto.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            chkIPIEmbutido.Checked = False
            txtAliquotaIPIProduto.Value = 0
            txtAliquotaIPIProduto.Tag = ""
            chkICMSEmbutido.Checked = True
            txtAliquotaICMSProduto.Value = 0
            txtAliquotaICMSProduto.Tag = ""
            chkPISCOFINSEmbutido.Checked = True
            txtAliquotaPISCOFINSProduto.Value = 0
            txtAliquotaPISCOFINSProduto.Tag = ""
            txtDescontoPercentualProduto.Value = 0
            txtDescontoValorProduto.Value = 0
            txtValorUnitarioProduto.Value = 0
            txtValorTotalProduto.Value = 0
            dtpPrevisaoEntregaProduto.BackColor = System.Drawing.SystemColors.InactiveCaption
            dPrecoMinimo = 0
            iCodigoUsuarioItem = goUsuario.iUsuario
            sLiberacaoItem = ""
            btnInserirProduto.Tag = ""
            chkICMSEmbutido.Enabled = True
            txtAliquotaICMSProduto.Enabled = True
            chkIPIEmbutido.Enabled = True
            txtAliquotaIPIProduto.Enabled = True
            chkPISCOFINSEmbutido.Enabled = True
            txtAliquotaPISCOFINSProduto.Enabled = True
            cboDestinacaoProduto.SelectedIndex = -1

            'Limpa Váriaveis
            oDataEntregaProduto.Clear()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            Dim sPlanta As String = txtTerceirosPlanta.Text
            Dim sPO As String = txtTerceirosPo.Text
            Dim sREF As String = txtTerceirosRef.Text
            Dim sRC As String = txtRCItem.Text

            'Limpa os campos
            LimparCamposGroupBox(grpDadosTerceiros)

            'Seta os valores
            txtTerceirosPlanta.Text = sPlanta
            txtTerceirosPo.Text = sPO
            txtTerceirosRef.Text = sREF
            txtRCItem.Text = sRC

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sAuxiliar(1) As String
            Dim iCodigoOrcamentoItem As Integer = -1

            If IsNumeric(btnInserirProduto.Tag) Then
                iCodigoOrcamentoItem = btnInserirProduto.Tag
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirProduto.Tag) = False Then

                'Insere Produto no Orçamento de Venda
                oClsVenOrcamento.InsertProduto(cboProduto.Text.Trim, _
                                               txtDescricaoProduto.Text, _
                                               txtComplementoProduto.Text.Trim, _
                                               cboDestinacaoProduto.SelectedValue, _
                                               txtValorUnitarioProduto.Value, _
                                               dPrecoMinimo, _
                                               dCustoTeorico, _
                                               txtQuantidadeProduto.Value, _
                                               IIf(cboUnidadeMedidaProduto.Enabled = True, cboUnidadeMedidaProduto.SelectedValue, -1), _
                                               chkIPIEmbutido.Checked, _
                                               txtAliquotaIPIProduto.Value, _
                                               IIf(IsNumeric(txtAliquotaIPIProduto.Tag), txtAliquotaIPIProduto.Tag, 0), _
                                               chkICMSEmbutido.Checked, _
                                               txtAliquotaICMSProduto.Value, _
                                               IIf(IsNumeric(txtAliquotaICMSProduto.Tag), txtAliquotaICMSProduto.Tag, 0), _
                                               chkPISCOFINSEmbutido.Checked, _
                                               txtAliquotaPISCOFINSProduto.Value, _
                                               IIf(IsNumeric(txtAliquotaPISCOFINSProduto.Tag), txtAliquotaPISCOFINSProduto.Tag, 0), _
                                               txtValorUnitarioProduto.Value, _
                                               txtDescontoPercentualProduto.Value, _
                                               txtDescontoValorProduto.Value, _
                                               lCodigoAcordoComercial, _
                                               iCodigoAcordoComercialItem, _
                                               iCodigoUsuarioItem, _
                                               oDataEntregaProduto, _
                                               txtTerceirosPlanta.Text.Trim, _
                                               txtTerceirosPo.Text.Trim, _
                                               txtTerceirosPoLinha.Text.Trim, _
                                               txtTerceirosRef.Text.Trim, _
                                               txtTerceirosCemb.Text.Trim, _
                                               txtTerceirosAtivoFixo.Text.Trim, _
                                               txtTerceirosNs.Text.Trim, _
                                               txtRCItem.Text.Trim, _
                                               txtOMItem.Text.Trim, _
                                               txtTerceirosEspecificador.Text.Trim)

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Exclui Dados da Entrega
                oClsVenOrcamento.DeleteProdutoEntrega(iCodigoOrcamentoItem)

                'Altera Produto no Orçamento
                oClsVenOrcamento.UpdateProduto(cboProduto.Text.Trim, _
                                               txtDescricaoProduto.Text, _
                                               txtComplementoProduto.Text.Trim, _
                                               cboDestinacaoProduto.SelectedValue, _
                                               txtValorUnitarioProduto.Value, _
                                               dPrecoMinimo, _
                                               dCustoTeorico, _
                                               txtQuantidadeProduto.Value, _
                                               IIf(cboUnidadeMedidaProduto.Enabled = True, cboUnidadeMedidaProduto.SelectedValue, -1), _
                                               chkIPIEmbutido.Checked, _
                                               txtAliquotaIPIProduto.Value, _
                                               IIf(IsNumeric(txtAliquotaIPIProduto.Tag), txtAliquotaIPIProduto.Tag, 0), _
                                               chkICMSEmbutido.Checked, _
                                               txtAliquotaICMSProduto.Value, _
                                               IIf(IsNumeric(txtAliquotaICMSProduto.Tag), txtAliquotaICMSProduto.Tag, 0), _
                                               chkPISCOFINSEmbutido.Checked, _
                                               txtAliquotaPISCOFINSProduto.Value, _
                                               IIf(IsNumeric(txtAliquotaPISCOFINSProduto.Tag), txtAliquotaPISCOFINSProduto.Tag, 0), _
                                               txtValorUnitarioProduto.Value, _
                                               txtDescontoPercentualProduto.Value, _
                                               txtDescontoValorProduto.Value, _
                                               lCodigoAcordoComercial, _
                                               iCodigoAcordoComercialItem, _
                                               iCodigoUsuarioItem, _
                                               oDataEntregaProduto, _
                                               iCodigoOrcamentoItem, _
                                               txtAliquotaICMSST.Value, _
                                               txtValorICMSST.Value, _
                                               txtTerceirosPlanta.Text.Trim, _
                                               txtTerceirosPo.Text.Trim, _
                                               txtTerceirosPoLinha.Text.Trim, _
                                               txtTerceirosRef.Text.Trim, _
                                               txtTerceirosCemb.Text.Trim, _
                                               txtTerceirosAtivoFixo.Text.Trim, _
                                               txtTerceirosNs.Text.Trim, _
                                               txtRCItem.Text.Trim, _
                                               txtOMItem.Text.Trim, _
                                               txtTerceirosEspecificador.Text.Trim)

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto, "status", CInt(StatusOrcamentoItem.Orcamento)) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    Call oClsVenOrcamento.DeleteItem()

                    'Calcula Totais
                    Call CalcularTotais()

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

    Private Sub EditarProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialOrcamentoDadosProduto, gcUpdate) = True Then

                If grdProduto.CurrentRow.Cells("status").Value = CInt(StatusOrcamentoItem.Orcamento) Then

                    LimparCamposGroupBox(grpProduto)

                    'Carrega Controles
                    oClsVenOrcamento.EditarProduto(grdProduto.CurrentRow.Cells("codigo_orcamento_item").Value, _
                                                   cboProduto, _
                                                   txtDescricaoProduto, _
                                                   txtComplementoProduto, _
                                                   cboDestinacaoProduto, _
                                                   txtQuantidadeProduto, _
                                                   cboUnidadeMedidaProduto, _
                                                   txtDescontoPercentualProduto, _
                                                   txtDescontoValorProduto, _
                                                   txtValorUnitarioProduto, _
                                                   chkICMSEmbutido, _
                                                   txtAliquotaICMSProduto, _
                                                   chkIPIEmbutido, _
                                                   txtAliquotaIPIProduto, _
                                                   chkPISCOFINSEmbutido, _
                                                   txtAliquotaPISCOFINSProduto, _
                                                   dtpPrevisaoEntregaProduto, _
                                                   txtAliquotaICMSST, _
                                                   txtValorICMSST, _
                                                   txtTerceirosAtivoFixo, _
                                                   txtTerceirosCemb, _
                                                   txtTerceirosNs, _
                                                   txtTerceirosPlanta, _
                                                   txtTerceirosPo, _
                                                   txtTerceirosPoLinha, _
                                                   txtTerceirosRef, _
                                                   txtRCItem, _
                                                   txtOMItem, _
                                                   txtTerceirosEspecificador)

                    btnInserirProduto.Tag = grdProduto.CurrentRow.Cells("codigo_orcamento_item").Value

                    'Carrega Váriavel - Entrega
                    Call oClsVenOrcamento.LoadDadosEntrega(btnSalvar.Tag, _
                                                           btnInserirProduto.Tag, _
                                                           oDataEntregaProduto)

                    'Seta Cor
                    dtpPrevisaoEntregaProduto.BackColor = System.Drawing.SystemColors.Window

                    'Seta Focu
                    cboProduto.Focus()

                Else
                    'Informa o Usuário que este Serviço não pode ser alterado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

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

    Private Sub LoadGridProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Produto
            oClsVenOrcamento.LoadGridProduto(grdProduto, btnSalvar.Tag)

            'Calcula Totais
            Call CalcularTotais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub PrecoVendaProduto()

        Try

            'Verifica se foi Selecionado o Produto
            If cboProduto.SelectedIndex > -1 Then

                Dim oForm As New frmVenProdutoPrecoVenda
                oForm.CodigoItem = cboProduto.SelectedValue
                oForm.CodigoCliente = IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue)
                oForm.ShowDialog(Me)

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
            If cboProduto.Text = "" Then
                frmMain.errInfo.SetError(lblProduto, "O Produto é um campo obrigatório. Selecione um valor para ele.")
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Destinação
            If ValidaCampo(cboDestinacaoProduto, lblDestinacaoProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeProduto, lblQuantidadeProduto, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade Parcial está correta
            Dim oPrevisaoEntrega As PrevisaoEntrega
            Dim dQuantidade As Double = 0

            'Verifica se foi Preenchido da Data de Entrega
            If oDataEntregaProduto.Count <= 1 Then

                'Seta Váriavel
                oDataEntregaProduto.Clear()
                oPrevisaoEntrega.sPrevisaoEntrega = dtpPrevisaoEntregaProduto.Value
                oPrevisaoEntrega.iCodigoEntrega = 0
                oPrevisaoEntrega.dQuantidade = txtQuantidadeProduto.Value
                oPrevisaoEntrega.sNotaFiscal = ""
                oDataEntregaProduto.Add(1, oPrevisaoEntrega)

            Else

                'Carrega Váriavel - Quantidade
                For Each oPrevisaoEntrega In oDataEntregaProduto.Values
                    dQuantidade += oPrevisaoEntrega.dQuantidade
                Next

                If dQuantidade <> txtQuantidadeProduto.Value Then
                    'Informa o Usuário do Problema encontrado
                    frmMain.errInfo.SetError(lblPrevisaoEntregaProduto, "A Quantidade Desmembrada não corresponde a Quantidade informada do Produto.")
                    txtQuantidadeProduto.Focus()
                    Exit Function
                End If

            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedidaProduto.Enabled = True Then
                If ValidaCampo(cboUnidadeMedidaProduto, lblUnidadeMedidaProduto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Desconto %
            If txtDescontoPercentualProduto.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoPercentualProduto, "O Campo [DESCONTO (%)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoPercentualProduto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Desconto Valor
            If txtDescontoValorProduto.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoValorProduto, "O Campo [DESCONTO (VALOR)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoValorProduto.Focus()
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Desconto %
            If txtAliquotaICMSST.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoPercentualProduto, "O Campo [ICMS ST (%)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtAliquotaICMSST.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Desconto Valor
            If txtValorICMSST.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoValorProduto, "O Campo [ICMS ST (VALOR)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtValorICMSST.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Desconto Valor
            If txtDescontoValorProduto.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoValorProduto, "O Campo [DESCONTO (VALOR)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoValorProduto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If txtValorUnitarioProduto.Enabled = True Then
                If ValidaCampo(txtValorUnitarioProduto, lblPrecoVendaProduto, True) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: SERVIÇO :::"

    Private Sub NovoServico()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Serviço
            cboServico.SelectedIndex = -1
            txtDescricaoServico.Text = ""
            cboServico.Text = ""
            txtComplemento.Text = ""
            txtQuantidadeServico.Value = 0
            cboUnidadeMedidaServico.SelectedIndex = -1
            dtpPrevisaoEntregaServico.BackColor = System.Drawing.SystemColors.InactiveCaption
            txtValorServico.Value = 0
            txtDescontoServico.Value = 0
            txtValorTotalServico.Value = 0
            chkISSRetido.Checked = False
            txtAliquotaISS.Value = 0
            txtAliquotaPIS.Value = 0
            txtAliquotaCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtAliquotaCSLL.Value = 0
            txtAliquotaIR.Value = 0
            btnInserirServico.Tag = ""
            btnRedimensionarComplementoServico.Tag = "MAX" : Call btnRedimensionarComplementoServico_Click(btnRedimensionarComplementoServico, System.EventArgs.Empty)

            'Limpa Váriaveis
            oDataEntregaServico.Clear()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            Dim sPlanta As String = txtTerceirosPlantaServico.Text
            Dim sPO As String = txtTerceirosPoServico.Text
            Dim sREF As String = txtTerceirosRefServico.Text
            Dim sRC As String = txtTerceirosRcServico.Text

            'Limpa os campos
            LimparCamposGroupBox(grpDadosTerceirosServico)

            'Seta os valores
            txtTerceirosPlantaServico.Text = sPlanta
            txtTerceirosPoServico.Text = sPO
            txtTerceirosRefServico.Text = sREF
            txtTerceirosRcServico.Text = sRC

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim iCodigoOrcamentoItem As Integer = -1
            Dim sAuxiliar(1) As String

            'Seta Váriavel
            If IsNumeric(btnInserirServico.Tag) Then
                iCodigoOrcamentoItem = btnInserirServico.Tag
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirServico.Tag) = False Then

                'Insere Item no Orçamento
                Call oClsVenOrcamento.InsertServico(cboServico.Text.Trim, _
                                                    txtDescricaoServico.Text, _
                                                    txtComplemento.Text.Trim, _
                                                    txtQuantidadeServico.Value, _
                                                    cboUnidadeMedidaServico.SelectedValue, _
                                                    txtValorServico.Value, _
                                                    txtDescontoServico.Value, _
                                                    txtValorTotalServico.Value, _
                                                    dtpPrevisaoEntregaServico.Value, _
                                                    chkISSRetido.Checked, _
                                                    txtAliquotaISS.Value, _
                                                    txtAliquotaPIS.Value, _
                                                    txtAliquotaCOFINS.Value, _
                                                    txtAliquotaINSS.Value, _
                                                    txtAliquotaCSLL.Value, _
                                                    txtAliquotaIR.Value, _
                                                    oDataEntregaServico, _
                                                    txtTerceirosPlantaServico.Text.Trim, _
                                                    txtTerceirosPoServico.Text.Trim, _
                                                    txtTerceirosPoLinhaServico.Text.Trim, _
                                                    txtTerceirosRefServico.Text.Trim, _
                                                    txtTerceirosCembServico.Text.Trim, _
                                                    txtTerceirosAtivoFixoServico.Text.Trim, _
                                                    txtTerceirosNsServico.Text.Trim, _
                                                    txtTerceirosRcServico.Text.Trim, _
                                                    txtTerceirosOmServico.Text.Trim, _
                                                    txtTerceirosEspecificadorServico.Text.Trim)

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Exclui Dados da Entrega
                Call oClsVenOrcamento.DeleteServicoEntrega(iCodigoOrcamentoItem)

                'Altera Item no Orçamento
                Call oClsVenOrcamento.UpdateServico(cboServico.Text.Trim, _
                                                    txtDescricaoServico.Text, _
                                                    txtComplemento.Text.Trim, _
                                                    txtQuantidadeServico.Value, _
                                                    cboUnidadeMedidaServico.SelectedValue, _
                                                    txtValorServico.Value, _
                                                    txtDescontoServico.Value, _
                                                    txtValorTotalServico.Value, _
                                                    dtpPrevisaoEntregaServico.Value, _
                                                    chkISSRetido.Checked, _
                                                    txtAliquotaISS.Value, _
                                                    txtAliquotaPIS.Value, _
                                                    txtAliquotaCOFINS.Value, _
                                                    txtAliquotaINSS.Value, _
                                                    txtAliquotaCSLL.Value, _
                                                    txtAliquotaIR.Value, _
                                                    iCodigoOrcamentoItem, _
                                                    oDataEntregaServico, _
                                                    txtTerceirosPlantaServico.Text.Trim, _
                                                    txtTerceirosPoServico.Text.Trim, _
                                                    txtTerceirosPoLinhaServico.Text.Trim, _
                                                    txtTerceirosRefServico.Text.Trim, _
                                                    txtTerceirosCembServico.Text.Trim, _
                                                    txtTerceirosAtivoFixoServico.Text.Trim, _
                                                    txtTerceirosNsServico.Text.Trim, _
                                                    txtTerceirosRcServico.Text.Trim, _
                                                    txtTerceirosOmServico.Text.Trim, _
                                                    txtTerceirosEspecificadorServico.Text.Trim)

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteServico()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdServico) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Serviço
                    Call oClsVenOrcamento.DeleteItem()

                    'Calcula Totais
                    Call CalcularTotais()

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

    Private Sub EditarServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialOrcamentoDadosServico, gcUpdate) = True Then

                LimparCamposGroupBox(grpServico)

                If grdServico.CurrentRow.Cells("status").Value = CInt(StatusOrcamentoItem.Orcamento) Then

                    'Carrega Controles
                    oClsVenOrcamento.EditarServico(grdServico.CurrentRow.Cells("codigo_orcamento_item").Value, _
                                                   cboServico, _
                                                   txtDescricaoServico, _
                                                   txtComplemento, _
                                                   txtValorServico, _
                                                   txtQuantidadeServico, _
                                                   cboUnidadeMedidaServico, _
                                                   txtDescontoServico, _
                                                   txtValorTotalServico, _
                                                   dtpPrevisaoEntregaServico, _
                                                   chkISSRetido, _
                                                   txtAliquotaISS, _
                                                   txtAliquotaPIS, _
                                                   txtAliquotaCOFINS, _
                                                   txtAliquotaINSS, _
                                                   txtAliquotaCSLL, _
                                                   txtAliquotaIR, _
                                                   txtTerceirosAtivoFixoServico, _
                                                   txtTerceirosCembServico, _
                                                   txtTerceirosNsServico, _
                                                   txtTerceirosPlantaServico, _
                                                   txtTerceirosPoServico, _
                                                   txtTerceirosPoLinhaServico, _
                                                   txtTerceirosRefServico, _
                                                   txtTerceirosRcServico, _
                                                   txtTerceirosOmServico, _
                                                   txtTerceirosEspecificadorServico)

                    btnInserirServico.Tag = grdServico.CurrentRow.Cells("codigo_orcamento_item").Value

                    'Carrega Váriavel - Entrega
                    Call oClsVenOrcamento.LoadDadosEntrega(btnSalvar.Tag, _
                                                           btnInserirServico.Tag, _
                                                           oDataEntregaServico)

                    'Seta Cor
                    dtpPrevisaoEntregaServico.BackColor = System.Drawing.SystemColors.Window

                    'Seta Focu
                    cboServico.Focus()

                Else
                    'Informa o Usuário que este Serviço não pode ser alterado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

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

    Private Sub LoadGridServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Serviço
            oClsVenOrcamento.LoadGridServico(grdServico, btnSalvar.Tag)

            'Calcula Totais
            Call CalcularTotais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoServico() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoServico = False

            'Verifica se foi Selecionado o Campo - Serviço
            If cboServico.Text = "" Then
                tabDados.SelectedTab = pagServico : cboServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeServico, lblQuantidadeServico, True) = False Then
                tabDados.SelectedTab = pagServico : txtQuantidadeServico.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedidaServico, lblUnidadeMedidaServico) = False Then
                tabDados.SelectedTab = pagServico : cboUnidadeMedidaServico.Focus()
                Exit Function
            End If

            'Verifica se a Quantidade Parcial está correta
            Dim oPrevisaoEntrega As PrevisaoEntrega
            Dim dQuantidade As Double = 0

            'Verifica se foi Preenchido da Data de Entrega
            If oDataEntregaServico.Count <= 1 Then

                'Seta Váriavel
                oDataEntregaServico.Clear()
                oPrevisaoEntrega.sPrevisaoEntrega = dtpPrevisaoEntregaServico.Value
                oPrevisaoEntrega.iCodigoEntrega = 0
                oPrevisaoEntrega.dQuantidade = txtQuantidadeServico.Value
                oPrevisaoEntrega.sNotaFiscal = ""
                oDataEntregaServico.Add(1, oPrevisaoEntrega)

            Else

                'Carrega Váriavel - Quantidade
                For Each oPrevisaoEntrega In oDataEntregaServico.Values
                    dQuantidade += oPrevisaoEntrega.dQuantidade
                Next

                If dQuantidade <> txtQuantidadeServico.Value Then
                    'Informa o Usuário do Problema encontrado
                    frmMain.errInfo.SetError(lblPrevisaoEntregaServico, "A Quantidade Desmembrada não corresponde a Quantidade informada do Serviço.")
                    txtQuantidadeServico.Focus()
                    Exit Function
                End If

            End If

            'Verifica se foi Preenchido o Campo - Valor do Serviço
            If ValidaCampo(txtValorServico, lblValorServico, True) = False Then
                tabDados.SelectedTab = pagServico : txtValorServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Líquido do Serviço
            If ValidaCampo(txtValorTotalServico, lblValorTotalServico, True) = False Then
                tabDados.SelectedTab = pagServico : txtValorTotalServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Alíquota ISS
            If ValidaCampo(txtAliquotaISS, chkISSRetido, True) = False Then
                tabDados.SelectedTab = pagServico : txtAliquotaISS.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoServico = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

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
                        'Exclui Registro do Banco de Dados
                        modFunction.DeleteArquivoBD("tb_ven_orcamento", oRow.Cells("path").Value, btnSalvar.Tag)
                        'Exclui Registro da Grid
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
            If VerificaDireito(Formulario.ComprasRequisicao, gcUpdate) = True Then

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


