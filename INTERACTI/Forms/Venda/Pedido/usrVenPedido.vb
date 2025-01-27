Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports Janus.Windows.UI.Tab
Imports Janus.Windows.CalendarCombo
Imports System.IO
Imports System.Math
Imports System.Reflection
Imports System.Reflection.Assembly
Imports Microsoft.Office.Interop

Public Class usrVenPedido

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsVenPedido As New clsUsrVenPedido

    Private oFormularioCadastroBasico() As FormularioCadastroBasico

    Private lCodigoPedido As Long
    Private bItemEstoque As Boolean
    Private dPrecoMinimo As Double
    Private dCustoMedio As Double
    Private dCustoTeorico As Double
    Private bItemProducao As Boolean
    Private dQuantidadeMinima As Double
    Private dMultiploVenda As Double
    Private bAcordoComercial As Boolean
    Private lCodigoAcordoComercial As Long
    Private iCodigoAcordoComercialItem As Integer
    Private lCodigoRegraFaturamento As Long
    Private iCodigoFormaVendaProduto As FormaVendaItem
    Private iCodigoFormaVendaServico As FormaVendaItem
    Private dPrecoVendaServico As Double
    Private dPercentualValorProduto As Double
    Private oPrecoVendaProduto() As PrecoVendaProduto
    Private dLimiteCredito As Double
    Private iCodigoUsuario As Integer = goUsuario.iUsuario
    Private iCodigoUsuarioItem As Integer = goUsuario.iUsuario
    Private sLiberacao As String
    Private sLiberacaoItem As String
    Private oDataEntregaProduto As New Hashtable
    Private oDataEntregaServico As New Hashtable
    Private sCodigoProdutoAnterior As String

#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoProdutoAnterior() As String
        Get
            Return sCodigoProdutoAnterior
        End Get
        Set(ByVal value As String)
            sCodigoProdutoAnterior = value
        End Set
    End Property

    Public WriteOnly Property CodigoPedido() As Long
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrVenPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridPedidoVenda() Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "cboItemFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarItemFiltro, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                        Case "cboCentroGastoProduto" : Call btnProcurarCentroGastoProduto_Click(btnProcurarCentroGastoProduto, System.EventArgs.Empty)
                        Case "cboContaContabilProduto" : Call btnProcurarContaContabilProduto_Click(btnProcurarContaContabilProduto, System.EventArgs.Empty)
                        Case "cboServico" : Call btnProcurarServico_Click(btnProcurarServico, System.EventArgs.Empty)
                        Case "cboCentroGastoServico" : Call btnProcurarCentroGastoServico_Click(btnProcurarCentroGastoServico, System.EventArgs.Empty)
                        Case "cboContaContabilServico" : Call btnProcurarContaContabilServico_Click(btnProcurarContaContabilServico, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnProcurarTransportadora_Click(btnProcurarTransportadora, System.EventArgs.Empty)
                        Case "cboTransportadoraFiltro" : Call btnProcurarTransportadoraFiltro_Click(btnProcurarTransportadoraFiltro, System.EventArgs.Empty)
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
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & TipoItem.produto)
                        Case "cboUnidadeMedidaProduto" : Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboCentroGastoProduto" : Call LoadCombo(cboCentroGastoProduto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabilProduto" : Call LoadCombo(cboContaContabilProduto, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                        Case "cboServico" : Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))
                        Case "cboUnidadeMedidaServico" : Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboCentroGastoServico" : Call LoadCombo(cboCentroGastoServico, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabilServico" : Call LoadCombo(cboContaContabilServico, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                        Case "cboTransportadora" : Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
                        Case "cboCondicaoPagamento" : Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboFormaPagamento" : Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento", True)
                        Case "cboMoeda" : Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboTipoArquivo" : Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
                        Case "cboIncoterms" : Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
                        Case "cboCampanha" : Call LoadCombo(cboCampanha, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa, False)
                        Case "cboCampanhaFiltro" : Call LoadCombo(cboCampanhaFiltro, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa)
                        Case "cboEmbalagem" : Call LoadCombo(cboEmbalagem, "sp_select_combo_cadastro_basico_embalagem " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaProduto" : Call btnCadastrarUnidadeMedidaProduto_Click(btnCadastrarUnidadeMedidaProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaServico" : Call btnCadastrarUnidadeMedidaServico_Click(btnCadastrarUnidadeMedidaServico, System.EventArgs.Empty)
                        Case "cboCentroGastoProduto" : Call btnCadastrarCentroGastoProduto_Click(btnCadastrarCentroGastoProduto, System.EventArgs.Empty)
                        Case "cboContaContabilProduto" : Call btnCadastrarContaContabilProduto_Click(btnCadastrarContaContabilProduto, System.EventArgs.Empty)
                        Case "cboServico" : Call btnCadastrarServico_Click(btnCadastrarServico, System.EventArgs.Empty)
                        Case "cboCentroGastoServico" : Call btnCadastrarCentroGastoServico_Click(btnCadastrarCentroGastoServico, System.EventArgs.Empty)
                        Case "cboContaContabilServico" : Call btnCadastrarContaContabilServico_Click(btnCadastrarContaContabilServico, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnCadastrarTransportadora_Click(btnCadastrarTransportadora, System.EventArgs.Empty)
                        Case "cboCondicaoPagamento" : Call btnCadastrarCondicaoPagamento_Click(btnCadastrarCondicaoPagamento, System.EventArgs.Empty)
                        Case "txtTermoGarantia" : Call btnCadastrarAutotexto_Click(btnCadastrarTermoGarantia, System.EventArgs.Empty)
                        Case "txtCondicaoFornecimento" : Call btnCadastrarAutotexto_Click(btnCadastrarCondicaoFornecimento, System.EventArgs.Empty)
                        Case "txtObservacao" : Call btnCadastrarAutotexto_Click(btnCadastrarObservacaoVenda, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)
                        Case "cboIncoterms" : Call btnCadastrarIncoterms_Click(btnCadastrarIncoterms, System.EventArgs.Empty)
                        Case "cboCampanha" : Call btnCadastrarCampanha_Click(btnCadastrarCampanha, System.EventArgs.Empty)
                        Case "grdVendedor" : Call btnCadastrarVendedor_Click(btnCadastrarVendedor, System.EventArgs.Empty)
                        Case "cboEmbalagem" : Call btnCadastrarEmbalagem_Click(btnCadastrarEmbalagem, System.EventArgs.Empty)
                    End Select

                Case Keys.F2
                    Select Case sender.Name
                        Case "cboProduto" : Call DadosProduto()
                    End Select

                Case Keys.F6
                    Select Case sender.Name
                        Case "cboProduto" : Call HistoricoProduto()
                        Case "cboCliente" : Call HistoricoParceiroNegocio()
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrVenPedido_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PEDIDO VENDA :::"

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
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialPedidoVenda)

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

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = LoadDescricao("sp_select_configuracao_interacti_texto " & goUsuario.iEmpresa & ",'formulario_find_produto_venda'")
            oForm.UsrControl = IIf(oForm.UsrControl = "", "usrFindItem", oForm.UsrControl)
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
            cboProduto.Focus()

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

    Private Sub btnProcurarTransportadoraFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarTransportadoraFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindTransportadora"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Transportadora"

            'Seta Váriaveis
            oComboBoxFind = cboTransportadoraFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboTransportadoraFiltro.Focus()

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

    Private Sub btnCadastrarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarVendedor.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadVendedor")

            'Carrega Grid
            Call oClsVenPedido.LoadGridVendedor(grdVendedor, IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1))

            'Seta Focu
            grdVendedor.Focus()

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

    Private Sub btnImportarOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarOrcamento.Click

        Try

            'Abre Formulário de Pedido - Pedido de Venda
            Dim oForm As New frmVenPedidoOrcamento
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Editar Pedido
            If oForm.CodigoPedido > 0 Then
                Call EditarPedidoVenda(oForm.CodigoPedido)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Cancelar Registros
            Call CancelarPedidoVenda()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call DeletePedidoVenda()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridPedidoVenda()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call NovoPedidoVenda()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Insere Registro do Pedido de Venda
            oClsVenPedido.Insert()
            btnSalvar.Tag = oClsVenPedido.CodigoPedido

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            dtpDataPedido.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Verifica se não foi gerado o Pedido de Venda
            If txtNumeroPedido.Text = "" And txtValorFinalPedido.Value > 0 Then
                'Verifica se o usuário deseja sair do Orçamento
                If MsgBox("Os Dados do Pedido de Venda serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            'Prepara o Formulário para Inserção de um Novo Registro
            Call NovoPedidoVenda()

            'Insere Registro do Pedido de Venda
            oClsVenPedido.Insert()
            btnSalvar.Tag = oClsVenPedido.CodigoPedido

            'Seta Focu        
            dtpDataPedido.Focus()

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

            'Valida Dados do Formulário
            If ValidacaoPedidoVenda() = True Then

                'Salva Dados do Registro
                Call SalvarPedidoVenda()


                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcPrint)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Pedido de Venda
            Call ImprimirPedidoVenda(oClsVenPedido.CodigoPedido, False)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Verifica se não foi gerado o Pedido de Venda
            If txtNumeroPedido.Text = "" And txtValorFinalPedido.Value > 0 Then
                'Verifica se o usuário deseja sair do Orçamento
                If MsgBox("Os Dados do Pedido de Venda serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            ElseIf txtNumeroPedido.Text <> "" And (grdProduto.GetDataRows.Count = 0 And grdServico.GetDataRows.Count = 0) Then
                'Verifica se o usuário deseja sair do Orçamento
                If MsgBox("O Pedido de Venda será excluido uma vez que o mesmo não possui Produtos ou Serviços lançados. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            'Carrega Grid
            Call LoadGridPedidoVenda()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

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

            'Limpa Controles
            'cboFormaPagamento.SelectedIndex = -1
            'cboCondicaoPagamento.SelectedIndex = -1
            'cboModalidadeFrete.SelectedIndex = -1
            'cboMoeda.SelectedIndex = -1
            cboEnderecoEntrega.DataSource = Nothing
            cboEnderecoEntrega.Text = ""
            cboDestinacaoProduto.SelectedIndex = -1
            dLimiteCredito = 0

            'Verifica se foi selecionado algum Registro
            If cboCliente.SelectedIndex > -1 Then

                'Carrega Combo
                'Call LoadCombo(cboRequerente, "sp_select_combo_cadastro_basico_parceiro_negocio_contato " & goUsuario.iEmpresa & " , " & cboCliente.SelectedValue, True)
                Call LoadCombo(cboEnderecoEntrega, "sp_select_combo_cadastro_basico_parceiro_negocio_endereco " & goUsuario.iEmpresa & " , " & cboCliente.SelectedValue & ", " & CInt(TipoEndereco.Entrega))

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

                'Carrega Embalagem
                If iCodigoEmbalagem <> -1 Then
                    cboEmbalagem.SelectedValue = iCodigoEmbalagem
                    cboEmbalagem.Enabled = False
                Else
                    cboEmbalagem.Enabled = True
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

                'Carrega Vendedor
                If iCodigoVendedor <> 0 Then
                    'Atualiza Grid
                    Call UpdateRegistroGrid(grdVendedor, "(percentual_comissao > 0)", "percentual_comissao", 0)
                    Call UpdateRegistroGrid(grdVendedor, "(codigo = " & iCodigoVendedor & ")", "percentual_comissao", 100)
                    'Move para o Primeiro Registro
                    grdVendedor.MoveFirst()
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : EditarPedidoVenda(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value)
                Case "duplicar" : DuplicarPedidoVenda()
                Case "inserir_revisao" : InserirRevisaoPedidoVenda()
                Case "imprimir" : ImprimirPedidoVenda(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value, False)
                Case "email" : EmailPedidoVenda(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value)
                Case "ativar" : AtivarItemPedidoVenda()
                Case "historico" : HistoricoItemPedidoVenda()
                Case "cancelar" : CancelarItemPedidoVenda()
                Case "comentario" : InserirHistorico()
                Case "historico_pedido" : HistoricoPedidoVenda()
                Case "imprimir_nota_fiscal" : ImprimirDanfe(grdListagem.CurrentRow.Cells.Item("codigo").Value)
                Case "atualizar_pedido" : AtualizarPedido()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComercialPedidoVenda, _
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
                                          Formulario.ComercialPedidoVenda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtDescontoGeral_LostFocus(sender As Object, e As EventArgs) Handles txtDescontoGeral.LostFocus, txtValorTotalPedido.LostFocus, txtValorDescontoPedido.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

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

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

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

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

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

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

            txtAcrescimoGeral.Value = txtAcrescimoGeralPercentual.Value * dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorFinalPedido() Handles txtValorTotalPedido.ValueChanged, _
                                                  txtValorDescontoPedido.ValueChanged, _
                                                  txtValorImpostosServicoPedido.ValueChanged, _
                                                  txtValorImpostosProdutoPedido.ValueChanged, _
                                                  txtDescontoGeral.ValueChanged, _
                                                  txtAcrescimoGeral.ValueChanged, _
                                                  txtValorFretePedido.ValueChanged, _
                                                  cboModalidadeFrete.SelectedIndexChanged

        Try

            'Váriaveis Locais
            Dim dValor As Double

            'Cálcula Valor Total
            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value
            dValor += txtValorFretePedido.Value
            dValor -= txtDescontoGeral.Value
            dValor += txtAcrescimoGeral.Value

            'Seta Valor Final
            txtValorFinalPedido.Value = dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO VENDA - EXCEL :::"

    Private Sub btnImportarPedidoExcel_Click(sender As Object, e As EventArgs)

        Try

            'Insere Registro do Pedido de Venda
            oClsVenPedido.Insert()
            btnSalvar.Tag = oClsVenPedido.CodigoPedido

            'Importa Pedido de Venda - Excel
            Call ImportarPedidoVendaExcel()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ITEM :::"

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
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
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
            sItemProducaoFind = "S"
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

    Private Sub btnProcurarCentroGastoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGastoProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboCentroGastoProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabilProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabilProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboContaContabilProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilProduto.Focus()

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

    Private Sub btnCadastrarCentroGastoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGastoProduto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGastoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabilProduto, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabilProduto.Focus()

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
            Call LoadCombo(cboEmbalagem, "sp_select_combo_cadastro_basico_embalagem " & goUsuario.iEmpresa)

            'Seta Focu
            cboEmbalagem.Focus()

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

            'Verifica se Botão Novo
            If btnInserirProduto.Tag.ToString = "NOVO" Then
                Call NovoProduto()
                Exit Sub
            End If

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

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged, _
                                                                                                                    cboDestinacaoProduto.SelectedIndexChanged, _
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
            Dim sObservacaoVenda As String = ""
            Dim dAliquotaICMSST As Double = 0
            Dim dValorICMSST As Double = 0

            'Seta Váriaveis
            dQuantidadeMinima = 0
            dMultiploVenda = 0
            bAcordoComercial = False
            lCodigoAcordoComercial = -1
            iCodigoAcordoComercialItem = -1
            lCodigoRegraFaturamento = -1

            'Limpa / Desabilita Controles
            'txtDescontoPercentualProduto.Value = 0
            'txtDescontoValorProduto.Value = 0
            'txtValorUnitarioProduto.Value = 0
            'txtDescontoPercentualProduto.Enabled = True
            txtDescontoValorProduto.Enabled = True
            txtValorUnitarioProduto.Enabled = True
            cboCentroGastoProduto.DataSource = Nothing : cboCentroGastoProduto.Text = ""
            cboContaContabilProduto.DataSource = Nothing : cboContaContabilProduto.Text = ""

            'Limpa Váriaveis
            dPrecoMinimo = 0
            dCustoTeorico = -1
            dCustoMedio = -1
            bAcordoComercial = False
            sDescricao = ""
            iCodigoUnidadeMedida = 0
            dQuantidadeEstoque = 0
            iLeadTime = 0
            bItemEstoque = False
            bItemProducao = False
            iCodigoFormaVendaProduto = FormaVendaItem.Indefinido
            iCodigoFormaVendaServico = FormaVendaItem.Indefinido

            'Verifica se Foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Dados do Produto
                Call oClsCadProduto.LoadDadosProduto(cboProduto.SelectedValue, _
                                                     IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue), _
                                                     IIf(cboDestinacaoProduto.SelectedIndex = -1, -1, cboDestinacaoProduto.SelectedValue), _
                                                     IIf(txtQuantidadeProduto.Value > 0, txtQuantidadeProduto.Value, 1), _
                                                     dtpDataPedido.Value, _
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


                'Carrega Combo
                Call LoadCombo(cboCentroGastoProduto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue), True)
                Call LoadCombo(cboContaContabilProduto, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue), True)

                'Carrega o NCM
                txtNCM.Text = LoadCodigo("sp_select_cadastro_basico_item_ncm " & CStr(cboProduto.SelectedValue) & "," & CStr(goUsuario.iEmpresa))


                'Habilita / Desabilita Controles
                chkICMSEmbutido.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                txtAliquotaICMSProduto.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                chkIPIEmbutido.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                txtAliquotaIPIProduto.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                chkPISCOFINSEmbutido.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                txtAliquotaPISCOFINSProduto.Enabled = IIf(lCodigoRegraFaturamento = -1, True, False)
                txtDescricaoProduto.Text = sDescricao

            cboUnidadeMedidaProduto.SelectedValue = iCodigoUnidadeMedida
            'txtValorUnitarioProduto.Value = dPrecoVenda - dDescontoValor
            'txtDescontoPercentualProduto.Value = dDescontoPercentual
            'txtDescontoValorProduto.Value = dDescontoValor
            chkICMSEmbutido.Checked = bICMSEmbutido
            ' txtAliquotaICMSProduto.Value = dAliquotaICMS
            chkIPIEmbutido.Checked = bIPIEmbutido
            '  txtAliquotaIPIProduto.Value = dAliquotaIPI
            chkPISCOFINSEmbutido.Checked = bPISCOFINSEmbutido
            '     txtAliquotaPISCOFINSProduto.Value = dAliquotaPISCOFINS
            If sObservacaoVenda = "" Then frmMain.errInfo.Clear() Else frmMain.errInfo.SetError(lblDescricaoProduto, sObservacaoVenda)

            If bAcordoComercial = True Then
                txtDescontoPercentualProduto.Enabled = False
                txtDescontoValorProduto.Enabled = False
                txtValorUnitarioProduto.Enabled = False
            End If

            End If

            sCodigoProdutoAnterior = cboProduto.Text

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

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
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.ComercialPedidoVenda, _
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
                                          Formulario.ComercialPedidoVenda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtQuantidadeProduto_LostFocus(sender As Object, e As EventArgs) Handles txtQuantidadeProduto.LostFocus

        Try

            'Verifica se a Quantidade informada é menor do que a Quantidade Permitida
            If txtQuantidadeProduto.Value > 0 AndAlso IsNumeric(btnInserirProduto.Tag) Then

                If txtQuantidadeProduto.Value < grdProduto.CurrentRow.Cells("quantidade_entregue").Value Then

                    'Informa o Usuário qua a Quantidade deve ser Maior ou Igual a Quantidade Entregue
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, " A Quantidade deve ser maior ou Igual a Quantidade Entregue.")
                    'Seta Focu
                    txtQuantidadeProduto.Focus()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtDescontoPercentualProduto_ValueChanged(sender As Object, e As EventArgs) Handles txtDescontoPercentualProduto.ValueChanged
        Try
            txtDescontoValorProduto.Value = txtValorUnitarioProduto.Value * ((txtDescontoPercentualProduto.Value / 100.0))
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub CalculoValorUnitarioDesconto(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    '                                                                                                      txtDescontoValorProduto.LostFocus, _
    '                                                                                                      txtDescontoPercentualProduto.LostFocus

    '    Try

    '        Select Case sender.Name

    '            Case "txtDescontoPercentualProduto"
    '                If IsNumeric(txtDescontoPercentualProduto.Tag) Then
    '                    If Round(txtDescontoPercentualProduto.Tag, 5) = txtDescontoPercentualProduto.Value Then
    '                        txtValorUnitarioProduto.Value = txtValorUnitarioTabelaProduto.Value - (txtDescontoPercentualProduto.Tag * txtValorUnitarioTabelaProduto.Value / 100.0)
    '                    Else
    '                        txtValorUnitarioProduto.Value = txtValorUnitarioTabelaProduto.Value - (txtDescontoPercentualProduto.Value * txtValorUnitarioTabelaProduto.Value / 100.0)
    '                    End If
    '                Else
    '                    txtValorUnitarioProduto.Value = txtValorUnitarioTabelaProduto.Value - (txtDescontoPercentualProduto.Value * txtValorUnitarioTabelaProduto.Value / 100.0)
    '                End If
    '                txtDescontoValorProduto.Value = txtValorUnitarioTabelaProduto.Value - txtValorUnitarioProduto.Value

    '            Case "txtDescontoValorProduto"
    '                txtValorUnitarioProduto.Value = txtValorUnitarioTabelaProduto.Value - txtDescontoValorProduto.Value
    '                txtDescontoPercentualProduto.Value = IIf(txtValorUnitarioTabelaProduto.Value = 0, 0, (1 - txtValorUnitarioProduto.Value / txtValorUnitarioTabelaProduto.Value) * 100)

    '            Case "txtValorUnitarioProduto"
    '                If txtValorUnitarioProduto.Value < 0 Then
    '                    txtValorUnitarioProduto.Value = 0
    '                End If
    '                If txtValorUnitarioProduto.Value < txtValorUnitarioTabelaProduto.Value Then
    '                    txtDescontoPercentualProduto.Value = (1 - txtValorUnitarioProduto.Value / txtValorUnitarioTabelaProduto.Value) * 100
    '                    txtDescontoPercentualProduto.Tag = (1 - txtValorUnitarioProduto.Value / txtValorUnitarioTabelaProduto.Value) * 100
    '                    txtDescontoValorProduto.Value = txtValorUnitarioTabelaProduto.Value - txtValorUnitarioProduto.Value
    '                Else
    '                    txtDescontoPercentualProduto.Value = 0
    '                    txtDescontoValorProduto.Value = 0
    '                End If

    '            Case "txtValorUnitarioTabelaProduto"
    '                If txtValorUnitarioProduto.Value = 0 Then
    '                    'txtValorUnitarioProduto.Value = txtValorUnitarioTabelaProduto.Value
    '                    txtDescontoPercentualProduto.Value = 0
    '                    txtDescontoValorProduto.Value = 0
    '                ElseIf txtDescontoPercentualProduto.Value = 0 Then
    '                    'txtValorUnitarioProduto.Value = txtValorUnitarioTabelaProduto.Value
    '                End If

    '        End Select

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub

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
            Dim dValorUnitario As Double = txtValorUnitarioProduto.Value - txtDescontoValorProduto.Value
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
            txtAliquotaICMSProduto.Tag = dValorUnitario * txtAliquotaICMSProduto.Value / 100.0
            txtAliquotaPISCOFINSProduto.Tag = dValorUnitario * txtAliquotaPISCOFINSProduto.Value / 100.0
            txtAliquotaIPIProduto.Tag = dValorUnitario * txtAliquotaIPIProduto.Value / 100.0

            txtValorICMS.Value = txtValorUnitarioDesconto.Value * txtAliquotaICMSProduto.Value / 100.0
            txtValorIPI.Value = txtValorUnitarioDesconto.Value * txtAliquotaIPIProduto.Value / 100.0

            'Seta Controle - Valor Total Imposto
            txtValorTotalImpostoProduto.Value = ((txtValorUnitarioProduto.Value - txtDescontoValorProduto.Value + IIf(chkICMSEmbutido.Checked = True, 0, txtAliquotaICMSProduto.Tag) + IIf(chkPISCOFINSEmbutido.Checked = True, 0, txtAliquotaPISCOFINSProduto.Tag) + IIf(chkIPIEmbutido.Checked = True, 0, txtAliquotaIPIProduto.Tag)) * dQuantidade)

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
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdServico, Formulario.ComercialPedidoVenda)

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

    Private Sub btnProcurarCentroGastoServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGastoServico.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)
            oComboBoxFind = cboCentroGastoServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabilServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabilServico.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)
            oComboBoxFind = cboContaContabilServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilServico.Focus()

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

    Private Sub btnCadastrarCentroGastoServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGastoServico, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGastoServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabilServico, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabilServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntregaServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmembrarPrevisaoEntregaServico.Click

        Try

            'Limpa o Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Seleciona o Campo - Serviço
            If ValidaCampo(cboServico, lblServico) = False Then
                Exit Sub
            End If

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

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboServico.SelectedIndex = -1 Then

                'Limpa Váriaveis
                txtDescricaoServico.Text = ""
                txtAliquotaINSS.Value = 0

                'Limpa Controles
                cboCentroGastoServico.DataSource = Nothing : cboCentroGastoServico.Text = ""
                cboContaContabilServico.DataSource = Nothing : cboContaContabilServico.Text = ""

            Else

                'Carrega Dados do Serviço
                oClsVenPedido.LoadDadosServico(cboServico.SelectedValue, _
                                               txtDescricaoServico, _
                                               txtAliquotaISS)

                'Carrega Combo
                Call LoadCombo(cboCentroGastoServico, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)
                Call LoadCombo(cboContaContabilServico, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)

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

    Private Sub grdServico_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdServico.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdServico.CurrentColumn) Then Exit Sub

            'Verifica qual linha foi Pressionada
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
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdServico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdServico.Name, _
                                     Formulario.ComercialPedidoVenda, _
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
                                          Formulario.ComercialPedidoVenda, _
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

#Region "::: VENDEDOR :::"

    Private Sub CalculaComissao() Handles grdVendedor.CellValueChanged, txtValorFinalPedido.ValueChanged

        Try

            'Váriaveis Locais
            Dim dPercentual As Double
            Dim iCodigoVendedor As Integer
            Dim dValorComissao As Double
            Dim dPercentualComissao As Double

            If IsNothing(grdVendedor.CurrentColumn) OrElse IsNothing(grdVendedor.CurrentRow) Then Exit Sub

            Select Case grdVendedor.CurrentColumn.Key

                Case "percentual_comissao"
                    'Seta Váriavel
                    iCodigoVendedor = grdVendedor.GetValue("codigo")
                    dPercentual = IIf(IsNumeric(grdVendedor.GetValue("percentual_comissao")), grdVendedor.GetValue("percentual_comissao"), 0)
                    dValorComissao = oClsVenPedido.LoadValorComissao(iCodigoVendedor, dPercentual, txtDescontoGeralPercentual.Value, txtValorTotalPedido.Value)
                    'Preenche Valor
                    grdVendedor.SetValue("valor_comissao", dValorComissao)
                    grdVendedor.SetValue("percentual_comissao_geral", dValorComissao / (txtValorTotalPedido.Value - txtValorDescontoPedido.Value - txtDescontoGeral.Value) * 100)

                Case "percentual_comissao_geral"
                    'Seta Váriavel
                    dPercentualComissao = IIf(IsNumeric(grdVendedor.GetValue("percentual_comissao_geral")), grdVendedor.GetValue("percentual_comissao_geral"), 0)
                    dPercentual = IIf(IsNumeric(grdVendedor.GetValue("percentual_comissao")), grdVendedor.GetValue("percentual_comissao"), 0)
                    dValorComissao = (((txtValorTotalPedido.Value - txtValorDescontoPedido.Value - txtDescontoGeral.Value) * dPercentualComissao / 100) * dPercentual / 100)
                    grdVendedor.SetValue("valor_comissao", dValorComissao)

            End Select

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
                    Call InsertArquivoBD("tb_ven_pedido", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_ven_pedido", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_ven_pedido", btnSalvar.Tag)

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

            'Carrega a grid
            Call LoadGridArquivoBD(grdArquivo, "tb_ven_pedido", btnSalvar.Tag)

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
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ComercialPedidoVenda, _
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
                                          Formulario.ComercialPedidoVenda, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVenPedido_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarTransportadora.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarCondicaoPagamento.Enabled = VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcInsert)
            btnCadastrarCondicaoFornecimento.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarTermoGarantia.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarObservacaoVenda.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarVendedor.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)
            btnCadastrarIncoterms.Enabled = VerificaDireito(Formulario.CadastroBasicoIncoterms, gcInsert)
            btnCadastrarCampanha.Enabled = VerificaDireito(Formulario.CadastroBasicoCampanhaAbrangencia, gcInsert)

            'Tipo - Combobox
            ReDim oTipoComboBox(2)
            oTipoComboBox(0).oColor = Color.Red : oTipoComboBox(0).sTipo = 1
            oTipoComboBox(1).oColor = Color.Peru : oTipoComboBox(1).sTipo = 2
            oTipoComboBox(2).oColor = Color.Black : oTipoComboBox(2).sTipo = 3

            'Carrega ComboBox  
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCliente : oComboBox(1) = cboClienteFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_venda_pedido_item")
            Call LoadCombo(cboVendedorFiltro, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete", True)
            oComboBox(0) = cboTransportadora : oComboBox(1) = cboTransportadoraFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)
            Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa, True)
            Call LoadCombo(cboDestinacaoFiltro, "sp_select_combo_static_destinacao")
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboFormaFaturamentoFiltro, "sp_select_combo_static_forma_faturamento")
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboCampanha : oComboBox(1) = cboCampanhaFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboItemFiltro, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", 1, NULL, -1")
            cboTipoItemFiltro.Items.Clear()
            cboTipoItemFiltro.Items.Add("PRODUTO", TipoItem.produto)
            cboTipoItemFiltro.Items.Add("SERVIÇO", TipoItem.servico)

            'Configura DateTimer
            dtpDataPedidoInicioFiltro.Value = DateAdd(DateInterval.Day, (DatePart(DateInterval.Day, Now.Date) - 1) * -1, Now.Date) : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False

            'Seta Controles
            cboModalidadeFrete.Enabled = False
            txtValorFretePedido.Enabled = False

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Verifica o Direito do Usuário - Item
            If VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcInsert) = True Then

                'Verifica Direito
                btnInserirProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcInsert)
                btnExcluirProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcDelete)
                btnExcelGridProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcPrint)

                'Verifica Direito - Botão de Cadastro
                btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                btnCadastrarUnidadeMedidaProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
                btnCadastrarCentroGastoProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
                btnCadastrarContaContabilProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
                btnInserirProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcInsert)
                btnExcluirProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcDelete)
                btnExcelGridProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcPrint)
                btnCadastrarEmbalagem.Enabled = VerificaDireito(Formulario.CadastroBasicoEmbalagem, gcInsert)

                'Carrega Combo
                Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto))
                Call LoadCombo(cboDestinacaoProduto, "sp_select_combo_static_destinacao")
                Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                Call LoadCombo(cboEmbalagem, "sp_select_combo_cadastro_basico_embalagem " & goUsuario.iEmpresa)

            Else
                tabDados.TabPages.Remove(pagProduto)
            End If

            'Verifica o Direito do Usuário - Serviço
            If VerificaDireito(Formulario.ComercialPedidoVendaServico, gcInsert) = True Then

                'Verifica Direito
                btnInserirServico.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaServico, gcInsert)
                btnExcluirServico.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaServico, gcDelete)
                btnExcelGridServico.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaServico, gcPrint)

                'Verifica Direito - Botão de Cadastro
                btnCadastrarServico.Enabled = VerificaDireito(Formulario.CadastroBasicoServico, gcInsert)
                btnCadastrarUnidadeMedidaServico.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
                btnCadastrarCentroGastoServico.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
                btnCadastrarContaContabilServico.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
                btnInserirServico.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaServico, gcInsert)
                btnExcluirServico.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaServico, gcDelete)
                btnExcelGridServico.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaServico, gcPrint)

                'Carrega Combo
                Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico), False)
                Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            Else
                tabDados.TabPages.Remove(pagServico)
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialPedidoVenda)
            Call ConfiguraGrid(grdProduto, Formulario.ComercialPedidoVenda)
            Call ConfiguraGrid(grdServico, Formulario.ComercialPedidoVenda)
            Call ConfiguraGrid(grdArquivo, Formulario.ComercialPedidoVenda)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

            'Verifica se é para Editar Pedido
            If lCodigoPedido <> 0 Then
                'Edita Pedido
                Call EditarPedidoVenda(lCodigoPedido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO VENDA :::"

    Private Sub AtualizarPedido()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Apenas Administrador e adm processos
            If goUsuario.iPerfil <> 1 And goUsuario.iPerfil <> 8 Then
                MsgBox("Você não tem permissão para realizar esta ação.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            oClsVenPedido.AtualizarStatusPedido(grdListagem.GetValue("codigo_pedido"))

            LoadGridPedidoVenda()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPedidoVenda()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sVendedor As String = ""
            Dim sStatus As String = ""

            'Vendedor
            For Each oRow As GridEXRow In cboVendedorFiltro.DropDownList.GetCheckedRows
                sVendedor &= IIf(sVendedor = "", "", ",") & oRow.Cells("codigo").Value
            Next

            'Status
            For Each oRow As GridEXRow In cboStatusFiltro.DropDownList.GetCheckedRows
                sStatus &= IIf(sStatus = "", "", ",") & oRow.Cells("codigo").Value
            Next

            'Carrega Controles
            oClsVenPedido.LoadGridPedido(grdListagem, _
                                         IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                         IIf(dtpDataPedidoInicioFiltro.Checked = False, "", dtpDataPedidoInicioFiltro.Value), _
                                         IIf(dtpDataPedidoTerminoFiltro.Checked = False, "", dtpDataPedidoTerminoFiltro.Value), _
                                         IIf(IsNumeric(txtRevisaoFiltro.Text.Trim), txtRevisaoFiltro.Text.Trim, -1), _
                                         IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                         IIf(cboFormaFaturamentoFiltro.SelectedIndex = -1, -1, cboFormaFaturamentoFiltro.SelectedValue), _
                                         sVendedor, _
                                         txtNumeroPedidoClienteFiltro.Text.Trim, _
                                         sStatus, _
                                         IIf(cboDestinacaoFiltro.SelectedIndex = -1, -1, cboDestinacaoFiltro.SelectedValue), _
                                         IIf(cboCampanha.SelectedIndex = -1, -1, cboCampanha.SelectedValue), _
                                         IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue), _
                                         IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                         IIf(cboTransportadoraFiltro.SelectedIndex = -1, -1, cboTransportadoraFiltro.SelectedValue), _
                                         IIf(cboItemFiltro.SelectedIndex = -1, -1, cboItemFiltro.SelectedValue), _
                                         txtReferenciaFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPedidoVenda(ByVal lCodigoPedidoCapa As Long, _
                                  Optional ByVal bAlternarAba As Boolean = True)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoPedidoVenda()

                'Seta Código
                oClsVenPedido.CodigoPedido = lCodigoPedidoCapa
                'Seta Controle
                btnSalvar.Tag = lCodigoPedidoCapa

                'Váriaveis Locais
                Dim iStatusFinanceiro As Integer

                'Carrega Controles
                Call oClsVenPedido.LoadControlesPedido(lCodigoPedidoCapa, _
                                                       txtNumeroPedido, _
                                                       dtpDataPedido, _
                                                       txtRevisao, _
                                                       cboCliente, _
                                                       txtNumeroPedidoCliente, _
                                                       cboModalidadeFrete, _
                                                       cboIncoterms, _
                                                       cboCampanha, _
                                                       cboEnderecoEntrega, _
                                                       cboTransportadora, _
                                                       txtTermoGarantia, _
                                                       txtCondicaoFornecimento, _
                                                       txtObservacao, _
                                                       txtReferencia, _
                                                       cboCondicaoPagamento, _
                                                       cboFormaPagamento, _
                                                       cboMoeda, _
                                                       txtFatorCambial, _
                                                       txtValorTotalPedido, _
                                                       txtValorDescontoPedido, _
                                                       txtValorImpostosProdutoPedido, _
                                                       txtValorImpostosServicoPedido, _
                                                       txtDescontoGeral, _
                                                       txtAcrescimoGeral, _
                                                       txtValorFretePedido, _
                                                       txtValorFinalPedido, _
                                                       txtComprador, _
                                                       iStatusFinanceiro)

                'Carrega Grid de Arquivo
                Call LoadGridArquivoBD(grdArquivo, "tb_ven_pedido", lCodigoPedidoCapa)

                'Carrega Grid de Produto
                Call LoadGridProduto()

                'Carrega Grid de Serviço
                Call LoadGridServico()

                'Carrega Grid de Vendedor
                Call oClsVenPedido.LoadGridVendedor(grdVendedor, lCodigoPedidoCapa)

                'Verifica se existe produto lançado
                If grdProduto.GetDataRows.Count > 0 Then cboModalidadeFrete.Enabled = True : txtValorFretePedido.Enabled = True

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcPrint)
                btnSalvar.Enabled = IIf(iStatusFinanceiro = CInt(StatusTitulo.Aberto), VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert), False)

                'Calcula Desconto Percentual
                Call txtDescontoGeral_LostFocus(txtDescontoGeral, System.EventArgs.Empty)
                Call txtAcrescimoGeral_LostFocus(txtAcrescimoGeral, System.EventArgs.Empty)

                'Alterna Aba
                If bAlternarAba = True Then
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)
                End If

                'Seta Focu
                dtpDataPedido.Focus()

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

    Private Sub NovoPedidoVenda()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            txtNumeroPedido.Text = ""
            txtNumeroPedido.Tag = ""
            dtpDataPedido.Value = Now.Date
            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'data_pedido_venda_maior_atual'"), Boolean) = False Then
                dtpDataPedido.MaxDate = Now.Date
            End If
            txtRevisao.Text = ""
            cboCliente.SelectedIndex = -1 : cboCliente.Enabled = True
            txtComprador.Text = ""
            txtNumeroPedidoCliente.Text = ""
            cboModalidadeFrete.SelectedIndex = -1
            cboIncoterms.SelectedIndex = -1
            cboCampanha.SelectedIndex = -1
            cboEnderecoEntrega.Text = ""
            cboTransportadora.SelectedIndex = -1
            txtTermoGarantia.Text = ""
            txtCondicaoFornecimento.Text = ""
            txtObservacao.Text = ""
            txtReferencia.Text = ""
            cboCondicaoPagamento.SelectedIndex = -1
            cboFormaPagamento.SelectedIndex = -1
            cboEnderecoEntrega.Text = ""
            cboMoeda.SelectedIndex = -1
            txtFatorCambial.Value = 0
            txtValorTotalPedido.Value = 0
            txtValorDescontoPedido.Value = 0
            txtValorImpostosProdutoPedido.Value = 0
            txtValorImpostosServicoPedido.Value = 0
            txtDescontoGeral.Value = 0
            txtDescontoGeralPercentual.Value = 0
            txtAcrescimoGeral.Value = 0
            txtAcrescimoGeralPercentual.Value = 0
            txtValorFretePedido.Value = 0
            txtValorFinalPedido.Value = 0
            btnSalvar.Tag = ""
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = False Then
                dtpDataPedido.MinDate = Now.Date
                dtpDataPedido.MaxDate = Now.Date
            Else
                dtpDataPedido.MinDate = DateAdd(DateInterval.Year, -10, Now.Date)
                dtpDataPedido.MaxDate = DateAdd(DateInterval.Year, +10, Now.Date)
            End If

            'Limpa Grid - Vendedor
            Call oClsVenPedido.LoadGridVendedor(grdVendedor, -1)

            'Limpa Controles - Produto
            txtOrdemCompraItem.Text = ""
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
            cboCentroGastoProduto.Text = ""
            cboContaContabilProduto.Text = ""
            cboEmbalagem.Text = ""
            dPrecoMinimo = 0
            iCodigoUsuarioItem = goUsuario.iUsuario
            grdProduto.DataSource = Nothing
            'Habilita Controles
            txtDescontoPercentualProduto.Enabled = True
            txtDescontoValorProduto.Enabled = True
            txtValorUnitarioProduto.Enabled = True
            btnInserirProduto.Tag = ""
            btnInserirProduto.Text = "Inserir"
            btnInserirProduto.Image = INTERACTI.My.Resources.salvar
            btnInserirProduto.ImageSize = New Size(14, 14)
            'Limpa Váriaveis
            oDataEntregaProduto.Clear()
            oDataEntregaServico.Clear()
            txtRCItem.Text = ""
            txtOMItem.Text = ""
            txtTerceirosPlanta.Text = ""
            txtTerceirosPo.Text = ""
            txtTerceirosPoLinha.Text = ""
            txtTerceirosRef.Text = ""
            txtTerceirosCemb.Text = ""
            txtTerceirosAtivoFixo.Text = ""
            txtTerceirosNs.Text = ""
            txtTerceirosEspecificador.Text = ""

            'Limpa Controles - Serviço
            txtOrdemCompraItemServico.Text = ""
            cboServico.SelectedIndex = -1
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
            cboCentroGastoServico.SelectedIndex = -1
            cboContaContabilServico.SelectedIndex = -1
            btnInserirServico.Tag = ""
            grdServico.DataSource = Nothing
            txtTerceirosAtivoFixoServico.Text = ""
            txtTerceirosCembServico.Text = ""
            txtTerceirosEspecificadorServico.Text = ""
            txtTerceirosNsServico.Text = ""
            txtTerceirosOmServico.Text = ""
            txtTerceirosPlantaServico.Text = ""
            txtTerceirosPoLinhaServico.Text = ""
            txtTerceirosPoServico.Text = ""
            txtTerceirosRcServico.Text = ""
            txtTerceirosRefServico.Text = ""

            'Limpa Controles Arquivo
            cboTipoArquivo.Text = ""
            txtDescricaoArquivo.Text = ""
            txtRevisaoArquivo.Text = ""
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcDelete)
            btnImprimir.Enabled = False

            'Seta Aba
            If tabDados.TabPages.Contains(pagProduto) Then
                tabDados.SelectedTab = pagProduto
            ElseIf tabDados.TabPages.Contains(pagServico) Then
                tabDados.SelectedTab = pagServico
            Else
                tabDados.SelectedTab = pagDadosGerais
            End If


            cboModalidadeFrete.SelectedValue = 0
            cboFormaPagamento.SelectedValue = 10
            cboMoeda.SelectedValue = 1

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPedidoVenda()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsVenPedido.CodigoPedido = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsVenPedido.DataPedido = dtpDataPedido.Value
            oClsVenPedido.CodigoCliente = cboCliente.SelectedValue
            oClsVenPedido.Comprador = txtComprador.Text.Trim
            oClsVenPedido.NumeroPedidoCliente = txtNumeroPedidoCliente.Text.Trim
            oClsVenPedido.CodigoModalidadeFrete = IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue)
            oClsVenPedido.CodigoIncoterms = IIf(cboIncoterms.SelectedIndex = -1, -1, cboIncoterms.SelectedValue)
            oClsVenPedido.CodigoCampanha = IIf(cboCampanha.SelectedIndex = -1, -1, cboCampanha.SelectedValue)
            oClsVenPedido.CodigoEnderecoEntrega = IIf(cboEnderecoEntrega.SelectedIndex = -1, -1, cboEnderecoEntrega.SelectedValue)
            oClsVenPedido.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsVenPedido.TermoGarantia = txtTermoGarantia.Text.Trim
            oClsVenPedido.CondicaoFornecimento = txtCondicaoFornecimento.Text.Trim
            oClsVenPedido.Observacao = txtObservacao.Text.Trim
            oClsVenPedido.Referencia = txtReferencia.Text.Trim
            oClsVenPedido.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)
            oClsVenPedido.CodigoFormaPagamento = IIf(cboFormaPagamento.SelectedIndex = -1, -1, cboFormaPagamento.SelectedValue)
            oClsVenPedido.CodigoMoeda = IIf(cboMoeda.SelectedIndex = -1, -1, cboMoeda.SelectedValue)
            oClsVenPedido.FatorCambial = txtFatorCambial.Value
            oClsVenPedido.ValorTotal = txtValorTotalPedido.Value
            oClsVenPedido.ValorDesconto = txtValorDescontoPedido.Value
            oClsVenPedido.ValorFrete = txtValorFretePedido.Value
            oClsVenPedido.DescontoGeral = txtDescontoGeral.Value
            oClsVenPedido.AcrescimoGeral = txtAcrescimoGeral.Value
            oClsVenPedido.ValorFinal = txtValorFinalPedido.Value
            oClsVenPedido.RO = 0
            oClsVenPedido.CodigoUsuario = iCodigoUsuario
            oClsVenPedido.Liberacao = sLiberacao

            'Atualiza Registro
            oClsVenPedido.Update()
            oClsVenPedido.DeleteVendedor()
            oClsVenPedido.InsertVendedor(grdVendedor)
            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Controle
            txtNumeroPedido.Text = oClsVenPedido.NumeroPedido

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeletePedidoVenda()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusTitulo.Aberto)) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsVenPedido.Delete()

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

    Private Sub CancelarPedidoVenda()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = True Then

                'Verifica o Pedido de Venda pode ser Cancelado
                If VerificaSelecaoRowCancelar(grdListagem) = True Then

                    'Váriaveis Locais
                    Dim oForm As New frmVenPedidoCancelar
                    'Seta Tamanho e Localização do Formulário
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                    'Carrega a Grid
                    Call LoadGridPedidoVenda()

                Else
                    'Informa o Usuário que o Pedido de Venda não pode ser Cancelado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDadosTerceiros()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsVenPedido.SalvarDadosTerceiros(btnSalvar.Tag, _
                                               txtTerceirosPlanta.Text, _
                                               txtTerceirosPo.Text, _
                                               txtTerceirosPoLinha.Text, _
                                               txtTerceirosRef.Text, _
                                               txtTerceirosCemb.Text, _
                                               txtTerceirosAtivoFixo.Text, _
                                               txtTerceirosNs.Text, _
                                               txtTerceirosEspecificador.Text, _
                                               txtRCItem.Text, _
                                               txtOMItem.Text, _
                                               btnInserirProduto.Tag)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Controle
            txtNumeroPedido.Text = oClsVenPedido.NumeroPedido

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailPedidoVenda(ByVal lCodigoPedidoVenda As Long)

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE VENDA"
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
            oRptDocument.SetParameterValue("@codigo_pedido", lCodigoPedidoVenda)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Arquivo
            Dim sArquivo As String = System.IO.Path.GetTempPath
            sArquivo &= grdListagem.CurrentRow.Cells("numero_pedido").Value.ToString.Replace("/", "-").Replace("\", "-") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Pedido de Venda " & grdListagem.CurrentRow.Cells("numero_pedido").Value, _
                             LoadContatoVenda(grdListagem.CurrentRow.Cells("codigo_pedido").Value), _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             grdListagem.CurrentRow.Cells("codigo_cliente").Value, _
                             "", _
                             -1, _
                             -1, _
                             TipoAutotextoEmail.PedidoVenda)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirPedidoVenda(ByVal lCodigoPedidoCapa As Long, _
                                    ByVal bAll As Boolean)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE VENDA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            If bAll = True Then

                sReport += "_ALL"

            End If


            'Carrega Váriavel
            sReport &= ".rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_pedido"
            goCrystalReport.sReportParameter(1).sValue = lCodigoPedidoCapa
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill
            'Seta Parametros - Report
            oReport.Tabela = "tb_ven_pedido"
            oReport.Codigo = lCodigoPedidoCapa
            oReport.Arquivo = False
            'Abre Relatório
            frmMain.LoadPageReport("VEN000000002 - P", "Pedido de Venda", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirRevisaoPedidoVenda()

        Try

            'Verifica se o Registro é Válido
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.PedidoVenda) Then

                'Verifica se foi Selecionado Algum Cliente
                If MsgBox("Deseja Gerar Nova Revisão do Pedido de Venda Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Duplica Pedido de Venda
                    oClsVenPedido.InsertRevisao(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Carrega o Pedido de Venda
                    Call EditarPedidoVenda(oClsVenPedido.CodigoPedido)

                End If

            Else

                'Informa o Usuário sobre a necessidade de selecionar um Registro Válido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione um Registro com Status = Pedido de Venda.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DuplicarPedidoVenda()

        Try

            'Verifica se foi Selecionado Algum Cliente
            If MsgBox("Deseja Duplicar o Pedido de Venda Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Duplica Pedido de Venda
                oClsVenPedido.Duplicar(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega o Pedido de Venda
                Call EditarPedidoVenda(oClsVenPedido.CodigoPedido)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirHistorico()

        Try

            'Váriaveis - Formulário
            Dim oForm As New frmVenPedidoHistoricoInserir
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

    Private Sub HistoricoPedidoVenda()

        Try

            'Váriaveis - Formulário
            Dim oForm As New frmVenPedidoHistorico
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

    Private Function VerificaSelecaoRowPedidoNaoFaturado(ByVal oGrid As GridEX) As Boolean

        Try

            'Váriaveis Locais
            Dim oRow As GridEXRow

            'Seta Retorno da Função
            VerificaSelecaoRowPedidoNaoFaturado = False

            'Verifica se foi Selecionado Algum Registro
            If oGrid.GetCheckedRows.Count = 0 Then
                Exit Function
            End If

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            For Each oRow In oGrid.GetCheckedRows

                'Verifica se o Pedido de Venda foi Faturado
                If oRow.Cells("valor").Value > oRow.Cells("valor_faturado").Value Then
                    'Redimensiona Vetor caso necessário
                    If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                        ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                    End If
                    'Seta Retorno da Função
                    VerificaSelecaoRowPedidoNaoFaturado = True
                    'Seta Valores
                    gSelecaoRow(UBound(gSelecaoRow)) = oRow
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function VerificaSelecaoRowCancelar(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowCancelar = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Varrendo os itens selecionados
                    For Each oRow In .GetCheckedRows

                        'Verifica se o Pedido é Válido
                        If ((oRow.Cells("valor_pedido").Value - oRow.Cells("valor_faturado").Value - oRow.Cells("valor_cancelado").Value) > 0) Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowCancelar = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function VerificaSelecaoRowExcluir(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowExcluir = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Varrendo os itens selecionados
                    For Each oRow In .GetCheckedRows

                        'Verifica se o Pedido é Válido
                        If oRow.Cells("valor_faturado").Value = 0 And grdListagem.CurrentRow.Cells("status_financeiro").Value = CInt(StatusTitulo.Aberto) Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowExcluir = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoPedidoVenda() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPedidoVenda = False

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                tabDados.SelectedTab = pagProduto
                cboCliente.Focus()
                Exit Function
            End If

            'Verifica se o Cliente possui titulos em Atraso
            Dim dValor As Double = LoadDescricao("sp_select_venda_pedido_dados_cliente " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
            If dValor > 0 Then
                If MsgBox("O Cliente: " & cboCliente.Text & " possui R$ " & FormatNumber(dValor, 2, Microsoft.VisualBasic.TriState.True) & " em atraso. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Function
                End If
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

            'Verifica se foi Selecionado um ou mais Vendedores
            'If grdVendedor.GetDataRows.Count > 0 Then
            '    If CDbl(grdVendedor.GetTotalRow.Cells("percentual_comissao").Value) <> 100.0 Then
            '        frmMain.errInfo.SetError(lblVendedor, "A Soma do % Comissão deve ser igual a 100,00%.")
            '        tabDados.SelectedTab = pagDadosGerais
            '        Exit Function
            '    End If
            'End If

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

            'Váriavel - Mensagem
            Dim sMensagem As String = ""
            sLiberacao = ""

            'Verifica se o Limite de Crédito é liberado
            If oClsVenPedido.ValidaVenda(cboCliente.SelectedValue, _
                                         dtpDataPedido.Value, _
                                         txtValorFinalPedido.Value, _
                                         sMensagem, _
                                         sLiberacao) = False Then

                'Informa que o Limite de Crédito não permite a operação
                If MsgBox(sMensagem & vbCrLf & vbCrLf & "Deseja Liberar a Venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Verifica se o Usuário tem Direito para Liberar a Venda
                    If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = False Then

                        'Formulário - Liberação
                        Dim oForm As New frmLiberacao

                        'Passa Parâmetros
                        oForm.CodigoFormulario = Formulario.ComercialPedidoVenda
                        oForm.Direito = gcAdministrator

                        'Abre Formulário
                        oForm.ShowDialog(Me)

                        'Seta Váriavel - Retorno
                        iCodigoUsuario = oForm.CodigoUsuario

                        'Verifica se o Usuário é Válido
                        If iCodigoUsuario <= 0 Then
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não possui direito de Administrador.")
                            sLiberacao = ""
                            Exit Function
                        End If

                    End If
                Else
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoPedidoVenda = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub HistoricoParceiroNegocio()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboCliente.SelectedIndex <> -1 Then

                'Abre Formulário
                Dim oForm As New frmVenHistoricoParceiroNegocio
                oForm.CodigoParceiroNegocio = cboCliente.SelectedValue
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que é necessário selecionar um Cliente
                frmMain.Informacao(Mensagem.ValidacaoSelecionar, "Cliente")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalcularTotais()

        Try

            'Atualiza Valor Total Pedido
            txtValorTotalPedido.Value = 0
            txtValorDescontoPedido.Value = 0

            If grdServico.GetDataRows.Count > 0 Then
                txtValorTotalPedido.Value += grdServico.GetTotalRow.Cells("valor_total_desconto").Value + grdServico.GetTotalRow.Cells("total_desconto").Value
                txtValorDescontoPedido.Value += grdServico.GetTotalRow.Cells("total_desconto").Value
                txtValorImpostosServicoPedido.Value = grdServico.GetTotalRow.Cells("valor_retido").Value
            End If
            If grdProduto.GetDataRows.Count > 0 Then
                txtValorTotalPedido.Value += grdProduto.GetTotalRow.Cells("valor_total_desconto").Value + grdProduto.GetTotalRow.Cells("total_desconto").Value
                txtValorDescontoPedido.Value += grdProduto.GetTotalRow.Cells("total_desconto").Value
                txtValorImpostosProdutoPedido.Value = grdProduto.GetTotalRow.Cells("valor_ipi").Value
                txtValorImpostosProdutoPedido.Value += grdProduto.GetTotalRow.Cells("valor_icms").Value
                txtValorImpostosProdutoPedido.Value += grdProduto.GetTotalRow.Cells("valor_pis_cofins").Value

                cboModalidadeFrete.Enabled = True
                txtValorFretePedido.Enabled = True
            Else
                cboModalidadeFrete.SelectedIndex = -1 : cboModalidadeFrete.Enabled = False
                txtValorFretePedido.Value = 0 : txtValorFretePedido.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PEDIDO VENDA - EXCEL :::"

    Private Sub ImportarPedidoVendaExcel()

        Try

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog
            Dim sArquivo As String
            Dim sPlanilha As String = LoadConfiguracao("tb_cfg_pedido_venda", "planilha")

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = "(Pedido de Venda)|*.xlsx;*.xls"
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                sArquivo = arqArquivo.FileName
            End If

            If sPlanilha = "" Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Planilha não foi informado. Contate o Administrador do Sistema.")
                Exit Sub
            End If

            'Váriaveis - Arquivo
            Dim oApplication As New Excel.Application
            Dim oWorkbook As Excel.Workbook
            Dim oMensagem() As MensagemErro
            Dim sAuxiliar() As String
            Dim bFlag As Boolean = False

            'Váriaveis - Capa
            Dim sCodigoCliente As String
            Dim sDataPedido As String
            Dim sContatoCliente As String
            Dim sNumeroPedidoCliente As String
            Dim dValorFrete As Double

            'Redimensiona Vetor
            ReDim oMensagem(0)
            oMensagem(0).Linha = ""
            oMensagem(0).Erro = ""

            Try

                'Abre o Arquivo            
                oWorkbook = oApplication.Workbooks.Open(sArquivo)

                Try
                    'Seleciona Planilha
                    oWorkbook.Sheets.Item(sPlanilha).Select()
                Catch ex As Exception
                    Throw New Exception("Não foi possível encontrar a Planilha: " & sPlanilha & " no Arquivo informado.")
                End Try

                'Data Emissão
                sAuxiliar = LoadConfiguracao("tb_cfg_pedido_venda", "data_emissao").Split("|")
                If sAuxiliar.Length = 1 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula da Data de Emissão do Pedido. Contate o Administrador do Sistema."
                ElseIf oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Data de Emissão."
                ElseIf IsDate(oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value) = False Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "A Data de Emissão informada é Inválida"
                Else
                    sDataPedido = oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value
                End If

                'Cliente
                sAuxiliar = LoadConfiguracao("tb_cfg_pedido_venda", "celula_cliente").Split("|")
                If sAuxiliar.Length = 1 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula do Cliente na Tabela de Configuração. Contate o Administrador do Sistema."
                ElseIf oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value Is Nothing Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "Não foi Informado o CNPJ do Cliente."
                Else
                    sCodigoCliente = ConsultaBancoDados("SELECT codigo FROM tb_cad_parceiro_negocio WHERE codigo_empresa = " & goUsuario.iEmpresa & " AND REPLACE(REPLACE(REPLACE(cnpj_cpf, '.', ''), '-', ''), '/', '') = REPLACE(REPLACE(REPLACE('" & oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value & "', '.', ''), '-', ''), '/', '')")
                    If sCodigoCliente = "" Then
                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                        oMensagem(UBound(oMensagem)).Erro = "Cliente: " & oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value & " não encontrado no Banco de Dados."
                    End If
                End If

                'Contato
                sAuxiliar = LoadConfiguracao("tb_cfg_pedido_venda", "contato").Split("|")
                If sAuxiliar.Length = 1 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula do Contato na Tabela de Configuração. Contate o Administrador do Sistema."
                ElseIf Not oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value Is Nothing Then
                    sContatoCliente = oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value
                End If

                'Nº Pedido Cliente
                sAuxiliar = LoadConfiguracao("tb_cfg_pedido_venda", "numero_pedido_cliente").Split("|")
                If sAuxiliar.Length = 1 Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula do Nº do Pedido do Cliente na Tabela de Configuração. Contate o Administrador do Sistema."
                ElseIf Not oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value Is Nothing Then
                    sNumeroPedidoCliente = oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value
                End If

                'Valor Frete
                sAuxiliar = LoadConfiguracao("tb_cfg_pedido_venda", "valor_frete").Split("|")
                If sAuxiliar.Length = 1 Then
                    'If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    'oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    'oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula do Valor do Frete do Pedido. Contate o Administrador do Sistema."
                ElseIf Not oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value Is Nothing AndAlso IsNumeric(oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value) = False Then
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                    oMensagem(UBound(oMensagem)).Erro = "o Valor do Frete informado é Inválido"
                Else
                    dValorFrete = oWorkbook.Application.Cells(CInt(sAuxiliar(0)), CInt(sAuxiliar(1))).Value.ToString.Replace(".", "").Replace(",", ".")
                End If

                'Verifica se foi encontrado o Cliente
                If IsNumeric(sCodigoCliente) = True Then

                    'Váriaveis - Pedido Item
                    Dim bAuxiliar As Boolean = False
                    Dim sProduto As String = ""
                    Dim sCodigoProduto As String = ""
                    Dim iNumeroPedidoItem As Integer = 0
                    Dim dQuantidade As Double = 0
                    Dim sDataEntrega As String = ""
                    Dim dPrecoVenda As Double = 0
                    Dim sCelula As String = ""
                    Dim sErro As String = ""
                    Dim i As Integer = 27

                    While bAuxiliar = False

                        'Seta Váriaveis
                        bFlag = True
                        sProduto = ""
                        sCodigoProduto = ""
                        iNumeroPedidoItem = 0
                        dQuantidade = 0
                        sDataEntrega = ""
                        dPrecoVenda = 0

                        'Produto
                        sCelula = LoadConfiguracao("tb_cfg_pedido_venda", "codigo_produto")
                        If sCelula = "" Then
                            If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                            oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                            oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula do Produto na Tabela de Configuração. Contate o Administrador do Sistema."
                        ElseIf oWorkbook.Application.Cells(i, CInt(sCelula)).Value Is Nothing Then
                            bAuxiliar = True
                        Else
                            sProduto = oWorkbook.Application.Cells(i, CInt(sCelula)).Value
                            sCodigoProduto = ConsultaBancoDados("SELECT codigo FROM tb_cad_item WHERE codigo_empresa = " & goUsuario.iEmpresa & " AND codigo_item = '" & sProduto & "' AND ativo = 1 AND item_venda = 1")
                        End If

                        'Verifica se foi encontrado o Código do Produto
                        If IsNumeric(sCodigoProduto) = False And sCodigoProduto <> "" Then
                            If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                            oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                            oMensagem(UBound(oMensagem)).Erro = "Produto: " & oWorkbook.Application.Cells(i, CInt(sCelula)).Value & " não encontrado no Banco de Dados."

                        ElseIf bAuxiliar = False Then

                            'Nº Item
                            sCelula = LoadConfiguracao("tb_cfg_pedido_venda", "numero_item")
                            If sCelula = "" Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula do Nº do Item na Tabela de Configuração. Contate o Administrador do Sistema."
                                bFlag = False
                            ElseIf oWorkbook.Application.Cells(i, CInt(sCelula)).Value Is Nothing AndAlso IsNumeric(oWorkbook.Application.Cells(i, CInt(sCelula)).Value) = False Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "O Nº do Item informado para o Produto: " & sProduto & " não é Válido."
                                bFlag = False
                            Else
                                iNumeroPedidoItem = oWorkbook.Application.Cells(i, CInt(sCelula)).Value
                            End If

                            'Quantidade
                            sCelula = LoadConfiguracao("tb_cfg_pedido_venda", "quantidade")
                            If sCelula = "" Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula da Quantidade na Tabela de Configuração. Contate o Administrador do Sistema."
                                bFlag = False
                            ElseIf oWorkbook.Application.Cells(i, CInt(sCelula)).Value Is Nothing AndAlso IsNumeric(oWorkbook.Application.Cells(i, CInt(sCelula)).Value) = False Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "A Quantidade informada para o Produto: " & sProduto & " não é Válida."
                                bFlag = False
                            Else
                                dQuantidade = oWorkbook.Application.Cells(i, CInt(sCelula)).Value
                            End If

                            'Data Entrega
                            sCelula = LoadConfiguracao("tb_cfg_pedido_venda", "data_entrega")
                            If sCelula = "" Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula da Data de Entrega na Tabela de Configuração. Contate o Administrador do Sistema."
                                bFlag = False
                            ElseIf oWorkbook.Application.Cells(i, CInt(sCelula)).Value Is Nothing AndAlso IsDate(oWorkbook.Application.Cells(i, CInt(sCelula)).Value) = False Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "A Data de Entrega informada para o Produto: " & sProduto & " não é Válida."
                                bFlag = False
                            Else
                                sDataEntrega = oWorkbook.Application.Cells(i, CInt(sCelula)).Value
                            End If

                            'Valor Unitário
                            sCelula = LoadConfiguracao("tb_cfg_pedido_venda", "valor_unitario")
                            If sCelula = "" Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "Não foi informado a Célula do Valor Unitário na Tabela de Configuração. Contate o Administrador do Sistema."
                                bFlag = False
                            ElseIf oWorkbook.Application.Cells(i, CInt(sCelula)).Value Is Nothing AndAlso IsNumeric(oWorkbook.Application.Cells(i, CInt(sCelula)).Value) = False Then
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                oMensagem(UBound(oMensagem)).Erro = "O Valor Unitário informado para o Produto: " & sProduto & " não é Válido."
                                bFlag = False
                            Else
                                dPrecoVenda = oWorkbook.Application.Cells(i, CInt(sCelula)).Value
                            End If

                            'Verifica se todos os dados foram preenchido
                            If bFlag = True Then

                                'Insere Produto
                                Call oClsVenPedido.InsertProdutoExcel(btnSalvar.Tag, _
                                                                      sCodigoCliente, _
                                                                      iNumeroPedidoItem, _
                                                                      sCodigoProduto, _
                                                                      dQuantidade, _
                                                                      sDataEntrega, _
                                                                      dPrecoVenda, _
                                                                      sErro)

                                'Verifica se foi encontrado o Erro
                                If sErro <> "" Then
                                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                    oMensagem(UBound(oMensagem)).Linha = (UBound(oMensagem) + 1).ToString
                                    oMensagem(UBound(oMensagem)).Erro = sErro
                                    bFlag = False
                                End If

                            End If

                        End If

                        i += 1

                    End While

                End If

                'Verifica se é necessário e gera Relatório
                If oMensagem(UBound(oMensagem)).Linha <> "" Then

                    'Gera Relatório de Erro
                    Call ReportErro("Integração - Pedido de Venda", _
                                    "Log de Importação - Pedido de Venda", _
                                    oMensagem)

                Else

                    'Atualiza tb_ven_pedido
                    ExecuteQuery("UPDATE tb_ven_pedido SET " & _
                                 "codigo_cliente = " & sCodigoCliente & ", " & _
                                 "data_pedido = '" & sDataPedido & "', " & _
                                 "requerente = '" & sContatoCliente & "', " & _
                                 "numero_pedido_cliente = '" & sNumeroPedidoCliente & "', " & _
                                 "valor_frete = " & dValorFrete.ToString.Replace(".", "").Replace(",", ".") & " " & _
                                 "WHERE (((codigo) = " & btnSalvar.Tag & ") " & _
                                 "AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))")

                    'Carrega Pedido
                    Call EditarPedidoVenda(btnSalvar.Tag, True)

                End If

            Catch ex As Exception
                Throw ex
            Finally
                'Limpa váriavel
                oWorkbook.Close(False)
                oWorkbook = Nothing
                oApplication = Nothing
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
            End Try

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ReportErro(ByVal sTitle As String, _
                                ByVal sSubTitle As String, _
                                ByVal oMensagem() As MensagemErro) As String

        Dim sReportHTML As String

        'add header information
        sReportHTML = "<!DOCTYPE HTML PUBLIC -//W3C//DTD HTML 4.01 Transitional//EN > "
        sReportHTML &= "<html>"
        sReportHTML &= "<head>"
        sReportHTML &= "<title>" & sTitle & "</title>"
        sReportHTML &= "<meta http-equiv=Content-Type content=text/html; charset=iso-8859-1 > "
        sReportHTML &= "</head>"
        sReportHTML &= "<body>"

        'add title text / subtitle text block
        sReportHTML &= "<p><font face=Arial, Helvetica, sans-serif><strong><font size=3>" & sSubTitle & "</font></strong><br>"
        sReportHTML &= "<font size=" & "2" & ">Relatório Gerado em: " & Now & "<br>"
        sReportHTML &= "Relatório Gerado por : " & goUsuario.sUsuario & "</font></font></p>"

        'define the start of the table
        sReportHTML &= "<table width=100% border=1 cellspacing=0 bordercolor=#CCCCCC>"

        'create the header row
        sReportHTML &= "<tr>"
        sReportHTML &= "<td width=10% vAlign=top align=center bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Linha</font></strong></td>"
        sReportHTML &= "<td width=90% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Erro</font></strong></td>"
        sReportHTML &= "</tr>"

        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oMensagem.Count
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

        For i As Integer = 0 To UBound(oMensagem)

            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Linha & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Erro & "</font></td>"
            sReportHTML &= "</tr>"
            Application.DoEvents()
        Next i

        frmMain.stbMain.Panels("pnlProgressBar").Visible = False

        'close page
        sReportHTML &= "</body>"
        sReportHTML &= "</html>"

        'Váriaveis Locais
        Dim sArquivo As String = System.IO.Path.GetTempPath
        sArquivo &= "INTERACTI_ERRO.html"

        If File.Exists(sArquivo) Then
            File.Delete(sArquivo)
        End If

        Using oFileStream As New FileStream(sArquivo, FileMode.Create)
            Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
            oStreamWriter.Write(sReportHTML.ToString())
            oStreamWriter.Close()
            oFileStream.Close()
        End Using

        Process.Start(sArquivo)

    End Function

#End Region

#Region "::: ITEM :::"

#Region "::: GERAL :::"

    Private Sub CancelarItemPedidoVenda()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = True Then

                'Verifica o status do Pedido de Venda
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.PedidoVenda) Or grdListagem.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.ParcialmenteFaturado) Then

                    'Váriaveis Locais
                    Dim oForm As New frmVenPedidoCancelarItem
                    'Seta Tamanho e Localização do Formulário
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                    'Seta Parametros
                    oForm.Grid = grdListagem
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Grid
                    Call LoadGridPedidoVenda()

                Else
                    'Informa o Usuário que o Pedido de Venda não pode ser Cancelado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtivarItemPedidoVenda()

        Try

            'Verifica o status do Pedido de Venda
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.Cancelado) Then

                'Verifica se a Linha é Válida
                If oClsVenPedido.ValidaAtivarItem(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                  grdListagem.CurrentRow.Cells("codigo_pedido_item").Value) = True Then

                    'Verifica se o usuário tem direito de Administrador
                    If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = True Then

                        'Verifica se o Usuário deseja Retornar o Status do Pedido de Venda
                        If MsgBox("Deseja tornar ativo o Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                            'Ativa Pedido de VEnda
                            Call oClsVenPedido.AtivarItem(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                          grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                          grdListagem.CurrentRow.Cells("quantidade").Value, _
                                                          "REGISTRO ATIVADO")

                            'Carrega a Grid
                            Call LoadGridPedidoVenda()

                        End If

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.DireitoAdministrador)
                    End If

                Else
                    'Informa o Usuário que o Pedido de VEnda não pode ser Cancelado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Pedido foi gerado a partir de um Orçamento.")
                End If

            Else
                'Informa o Usuário que o Pedido de VEnda não pode ser Cancelado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoItemPedidoVenda()

        Try

            'Váriaveis Locais
            Dim oForm As New frmVenPedidoHistoricoItem
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parametros
            oForm.Grid = grdListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
            Dim oForm As New frmVenPedidoItemDesmembrarEntrega
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
            txtOrdemCompraItem.Text = ""
            cboProduto.SelectedIndex = -1 : cboProduto.Text = "" : cboProduto.Tag = ""
            txtDescricaoProduto.Text = ""
            txtComplementoProduto.Text = ""
            txtQuantidadeProduto.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            txtAliquotaICMSProduto.Tag = ""
            txtAliquotaIPIProduto.Tag = ""
            txtAliquotaPISCOFINSProduto.Tag = ""
            txtDescontoPercentualProduto.Value = 0
            txtDescontoValorProduto.Value = 0
            txtValorUnitarioProduto.Value = 0
            txtValorTotalProduto.Value = 0
            dtpPrevisaoEntregaProduto.BackColor = System.Drawing.SystemColors.InactiveCaption
            cboCentroGastoProduto.Text = ""
            cboContaContabilProduto.Text = ""
            cboEmbalagem.Text = ""
            txtRCItem.Text = ""
            txtOMItem.Text = ""
            dPrecoMinimo = 0
            iCodigoUsuarioItem = goUsuario.iUsuario
            btnInserirProduto.Tag = ""
            btnInserirProduto.Text = "Inserir"
            btnInserirProduto.Image = INTERACTI.My.Resources.salvar
            btnInserirProduto.ImageSize = New Size(14, 14)
            chkICMSEmbutido.Enabled = True
            txtAliquotaICMSProduto.Enabled = True
            chkIPIEmbutido.Enabled = True
            txtAliquotaIPIProduto.Enabled = True
            chkPISCOFINSEmbutido.Enabled = True
            txtAliquotaPISCOFINSProduto.Enabled = True
            txtTerceirosPlanta.Text = ""
            txtTerceirosPo.Text = ""
            txtTerceirosPoLinha.Text = ""
            txtTerceirosRef.Text = ""
            txtTerceirosCemb.Text = ""
            txtTerceirosAtivoFixo.Text = ""
            txtTerceirosNs.Text = ""
            txtTerceirosEspecificador.Text = ""

            'Limpa Váriaveis
            oDataEntregaProduto.Clear()

            'Habilita Controles
            txtDescontoPercentualProduto.Enabled = True
            txtDescontoValorProduto.Enabled = True
            txtValorUnitarioProduto.Enabled = True

            'Configura Valor Default
            Call ConfigureValorDefault(Me)


            'Seta Focu
            txtOrdemCompraItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim iCodigoPedidoItem As Integer = -1

            'Seta Váriavel
            If IsNumeric(btnInserirProduto.Tag) Then
                iCodigoPedidoItem = btnInserirProduto.Tag
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirProduto.Tag) = False Then

                'Insere Produto no Pedido de Venda
                oClsVenPedido.InsertProduto(btnSalvar.Tag, _
                                            txtOrdemCompraItem.Text.Trim, _
                                            cboProduto.SelectedValue, _
                                            txtComplementoProduto.Text.Trim, _
                                            cboDestinacaoProduto.SelectedValue, _
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
                                            txtDescontoPercentualProduto.Value, _
                                            txtDescontoValorProduto.Value, _
                                            IIf(cboCentroGastoProduto.SelectedIndex = -1, -1, cboCentroGastoProduto.SelectedValue), _
                                            IIf(cboContaContabilProduto.SelectedIndex = -1, "", cboContaContabilProduto.SelectedValue), _
                                            IIf(cboEmbalagem.SelectedIndex = -1, -1, cboEmbalagem.SelectedValue), _
                                            lCodigoAcordoComercial, _
                                            iCodigoAcordoComercialItem, _
                                            iCodigoUsuarioItem, _
                                            oDataEntregaProduto, _
                                            txtValorUnitarioProduto.Value, _
                                            iCodigoPedidoItem)

                'Informa o Usuário do Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Exclui Dados da Entrega
                oClsVenPedido.DeleteProdutoEntrega(iCodigoPedidoItem)

                'Altera Produto no Pedido de Venda
                oClsVenPedido.UpdateProduto(btnSalvar.Tag, _
                                            txtOrdemCompraItem.Text.Trim, _
                                            cboProduto.SelectedValue, _
                                            txtComplementoProduto.Text.Trim, _
                                            cboDestinacaoProduto.SelectedValue, _
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
                                            txtDescontoPercentualProduto.Value, _
                                            txtDescontoValorProduto.Value, _
                                            IIf(cboCentroGastoProduto.SelectedIndex = -1, -1, cboCentroGastoProduto.SelectedValue), _
                                            IIf(cboContaContabilProduto.SelectedIndex = -1, "", cboContaContabilProduto.SelectedValue), _
                                            IIf(cboEmbalagem.SelectedIndex = -1, -1, cboEmbalagem.SelectedValue), _
                                            lCodigoAcordoComercial, _
                                            iCodigoAcordoComercialItem, _
                                            iCodigoUsuarioItem, _
                                            oDataEntregaProduto, _
                                            iCodigoPedidoItem, _
                                            txtValorUnitarioProduto.Value)

                'Informa o Usuário do Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

            'Agora insere os dados do terceiros
            oClsVenPedido.SalvarDadosTerceiros(btnSalvar.Tag, _
                                               txtTerceirosPlanta.Text.Trim, _
                                               txtTerceirosPo.Text.Trim, _
                                               txtTerceirosPoLinha.Text.Trim, _
                                               txtTerceirosRef.Text.Trim, _
                                               txtTerceirosCemb.Text.Trim, _
                                               txtTerceirosAtivoFixo.Text.Trim, _
                                               txtTerceirosNs.Text.Trim, _
                                               txtTerceirosEspecificador.Text.Trim, _
                                               txtRCItem.Text, _
                                               txtOMItem.Text, _
                                               iCodigoPedidoItem)




            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto, "status", CInt(StatusVendaPedidoItem.PedidoVenda), "quantidade_elaboracao", 0) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    oClsVenPedido.DeleteProduto()

                    'Calcula Totais
                    Call CalcularTotais()

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoProduto()

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

            'Verifica se o Registro pode ser Editado
            If grdProduto.CurrentRow.Cells("quantidade_elaboracao").Value > 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Existe Nota Fiscal em Elaboração para este Produto. Por isso o mesmo não pode ser editado.")
                Exit Sub
            End If

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcUpdate) = True Then

                'Carrega Controles
                oClsVenPedido.EditarProduto(grdProduto.CurrentRow.Cells("codigo_pedido_item").Value, _
                                            txtOrdemCompraItem, _
                                            cboProduto, _
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
                                            cboCentroGastoProduto, _
                                            cboContaContabilProduto, _
                                            cboEmbalagem, _
                                            txtRCItem, _
                                            txtOMItem)

                'Carrega Controles
                oClsVenPedido.EditarDadosTerceiros(grdProduto.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                   txtTerceirosAtivoFixo, _
                                                   txtTerceirosCemb, _
                                                   txtTerceirosNs, _
                                                   txtTerceirosPlanta, _
                                                   txtTerceirosPo, _
                                                   txtTerceirosPoLinha, _
                                                   txtTerceirosRef, _
                                                   txtTerceirosEspecificador)

                btnInserirProduto.Tag = grdProduto.CurrentRow.Cells("codigo_pedido_item").Value

                'Carrega Váriavel - Entrega
                Call oClsVenPedido.LoadDadosEntrega(btnSalvar.Tag, _
                                                    btnInserirProduto.Tag, _
                                                    oDataEntregaProduto)

                'Seta Cor
                dtpPrevisaoEntregaProduto.BackColor = System.Drawing.SystemColors.Window

                'Seta Focu
                txtOrdemCompraItem.Focus()

                If grdProduto.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.PedidoVenda) Or _
                    grdProduto.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.ParcialmenteFaturado) Then
                    btnInserirProduto.Text = "Salvar"
                    btnInserirProduto.Image = INTERACTI.My.Resources.salvar
                    btnInserirProduto.ImageSize = New Size(14, 14)
                Else
                    btnInserirProduto.Text = btnNovo.Text
                    btnInserirProduto.Tag = "NOVO"
                    btnInserirProduto.Image = INTERACTI.My.Resources.Novo
                    btnInserirProduto.ImageSize = New Size(13, 16)
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
            oClsVenPedido.LoadGridProduto(grdProduto, btnSalvar.Tag)

            'Calcula Totais
            Call CalcularTotais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

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

            'Verifica se o Produto já está inserido no Pedido de Venda
            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'duplicidade_item_venda'"), Boolean) = False Then
                If grdProduto.GetDataRows.Count > 0 Then
                    If IsNumeric(btnInserirProduto.Tag) Then
                        If VerificaExisteValorGrid(grdProduto, "codigo_item", cboProduto.SelectedValue, grdProduto.CurrentRow.RowIndex) = True Then
                            frmMain.errInfo.SetError(lblProduto, "Este Produto: " & cboProduto.Text & " já se encontra cadastrado para este Pedido de Venda.")
                            cboProduto.Focus()
                            Exit Function
                        End If
                    Else
                        If VerificaExisteValorGrid(grdProduto, "codigo_item", cboProduto.SelectedValue, -1) = True Then
                            frmMain.errInfo.SetError(lblProduto, "Este Produto: " & cboProduto.Text & " já se encontra cadastrado para este Pedido de Venda.")
                            cboProduto.Focus()
                            Exit Function
                        End If
                    End If
                End If
            Else
                If grdProduto.GetDataRows.Count > 0 Then
                    If IsNumeric(btnInserirProduto.Tag) Then
                        If VerificaExisteValorGrid(grdProduto, "codigo_item", cboProduto.SelectedValue, grdProduto.CurrentRow.RowIndex) = True Then
                            If MsgBox("Este Produto: " & cboProduto.Text & " já se encontra cadastrado para este Pedido de Venda. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                                cboProduto.Focus()
                                Exit Function
                            End If
                        End If
                    Else
                        If VerificaExisteValorGrid(grdProduto, "codigo_item", cboProduto.SelectedValue, -1) = True Then
                            If MsgBox("Este Produto: " & cboProduto.Text & " já se encontra cadastrado para este Pedido de Venda. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                                cboProduto.Focus()
                                Exit Function
                            End If
                        End If
                    End If
                End If
            End If

            'Verifica se a Comissão está correta
            If oClsVenPedido.ValidaProdutoComissao(oClsVenPedido.CodigoPedido, _
                                                   cboProduto.SelectedValue) = False Then
                frmMain.errInfo.SetError(lblProduto, "Este Produto não pertence a mesma categoria dos outros Itens do Pedido.")
                cboProduto.Focus()
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

            ''Verifica se tem a Quantidade em Estoque
            'If txtQuantidadeEstoqueProduto.Tag = True Then
            '    'Verifica se a Quantidade em Estoque é suficiente
            '    If txtQuantidadeProduto.Value > txtQuantidadeEstoqueProduto.Value Then
            '        If MsgBox("A Quantidade em Estoque é menor que a Quantidade do Pedido." & vbCrLf & vbCrLf & "Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
            '            txtQuantidadeProduto.Focus()
            '            Exit Function
            '        End If
            '    End If
            'End If

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

            'Verifica se foi Preenchido o Campo - Preço de Venda
            'If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_venda_preco_venda'"), Boolean) = True And tabMain.SelectedTab Is pagDados Then
            '    If ValidaCampo(txtValorUnitarioTabelaProduto, lblValorUnitarioTabelaProduto, True) = False Then
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Preenchido o Campo - Preço Mínimo
            'If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_venda_preco_minimo'"), Boolean) = True And tabMain.SelectedTab Is pagDados Then
            '    If dPrecoMinimo = 0 Then
            '        frmMain.errInfo.SetError(lblValorUnitarioTabelaProduto, "Não foi cadastrado o Preço Mínimo para este Produto.")
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If txtValorUnitarioProduto.Enabled = True Then
                If ValidaCampo(txtValorUnitarioProduto, lblValorUnitarioProduto, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Valor Unitário é Maior que o Preço Mínimo
            If txtValorUnitarioProduto.Value < dPrecoMinimo Then

                'Limpa Váriavel
                iCodigoUsuarioItem = goUsuario.iEmpresa


                If MsgBox("O Valor Unitário está menor que o Preço Mínimo. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = False Then

                        'Formulário - Liberação
                        Dim oForm As New frmLiberacao
                        'Passa Parâmetros
                        oForm.CodigoFormulario = Formulario.ComercialPedidoVenda
                        oForm.Direito = gcAdministrator
                        'Abre Formulário
                        oForm.ShowDialog(Me)

                        'Seta Váriavel - Retorno
                        iCodigoUsuarioItem = oForm.CodigoUsuario

                        'Verifica se o Usuário é Válido
                        If iCodigoUsuarioItem <= 0 Then
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não possui direito de Administrador.")
                            sLiberacaoItem = ""
                            txtValorUnitarioProduto.Focus()
                            Exit Function
                        End If
                    End If
                    '    End If
                Else
                    Exit Function
                    'End If
                End If
                'Else

                '    iCodigoUsuarioItem = goUsuario.iUsuario
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

            'Váriavel - Mensagem
            Dim sMensagem As String = ""
            sLiberacao = ""
            Dim dValorProduto As Double = 0

            dValorProduto = txtValorTotalImpostoProduto.Value
            If IsNumeric(btnInserirProduto.Tag) Then
                dValorProduto = dValorProduto - grdProduto.GetValue("valor_total_imposto")
            End If

            'Verifica se o Limite de Crédito é liberado
            If oClsVenPedido.ValidaVenda(cboCliente.SelectedValue, _
                                         dtpDataPedido.Value, _
                                         txtValorFinalPedido.Value + dValorProduto, _
                                         sMensagem, _
                                         sLiberacao) = False Then

                'Informa que o Limite de Crédito não permite a operação
                If MsgBox(sMensagem & vbCrLf & vbCrLf & "Deseja Liberar a Venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Verifica se o Usuário tem Direito para Liberar a Venda
                    If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = False Then

                        'Formulário - Liberação
                        Dim oForm As New frmLiberacao

                        'Passa Parâmetros
                        oForm.CodigoFormulario = Formulario.ComercialPedidoVenda
                        oForm.Direito = gcAdministrator

                        'Abre Formulário
                        oForm.ShowDialog(Me)

                        'Seta Váriavel - Retorno
                        iCodigoUsuario = oForm.CodigoUsuario

                        'Verifica se o Usuário é Válido
                        If iCodigoUsuario <= 0 Then
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não possui direito de Administrador.")
                            sLiberacao = ""
                            Exit Function
                        End If

                    End If
                Else
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoProduto, lblCentroGastoProduto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilProduto, lblContaContabilProduto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Embalagem
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_embalagem'") = True Then
                If ValidaCampo(cboEmbalagem, lblEmbalagem) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido a Regra de Faturamento
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_regra_faturamento'") = True AndAlso lCodigoRegraFaturamento = -1 Then
                If MsgBox("Este Produto não possui Regra de Faturamento Cadastrada. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DadosProduto()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Abre Formulário
                If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'dados_produto_estoque'"), Boolean) = True Then
                    Dim oForm As New frmVenDadosProdutoEstoque
                    oForm.CodigoProduto = cboProduto.SelectedValue
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                Else
                    Dim oForm As New frmVenDadosProduto
                    oForm.CodigoProduto = cboProduto.SelectedValue
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                End If

                'Carrega Dados do Produto
                Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar, "Produto")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoProduto()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Abre Formulário
                Dim oForm As New frmVenHistoricoProduto

                'Seta Váriaveis
                oForm.CodigoItem = cboProduto.SelectedValue
                oForm.Produto = cboProduto.Text

                'Carrega Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar, "Produto")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Private Sub NovoServico()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Serviço
            txtOrdemCompraItemServico.Text = ""
            cboServico.SelectedIndex = -1
            txtComplemento.Text = ""
            txtQuantidadeServico.Value = 0
            cboUnidadeMedidaServico.SelectedIndex = -1
            txtValorServico.Value = 0
            dtpPrevisaoEntregaProduto.BackColor = System.Drawing.SystemColors.InactiveCaption
            txtDescontoServico.Value = 0
            txtValorTotalServico.Value = 0
            chkISSRetido.Checked = False
            txtAliquotaISS.Value = 0
            txtAliquotaPIS.Value = 0
            txtAliquotaCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtAliquotaCSLL.Value = 0
            txtAliquotaIR.Value = 0
            cboCentroGastoServico.SelectedIndex = -1
            cboContaContabilServico.SelectedIndex = -1
            btnInserirServico.Tag = ""
            oDataEntregaServico.Clear()
            txtTerceirosPlantaServico.Text = ""
            txtTerceirosPoServico.Text = ""
            txtTerceirosPoLinhaServico.Text = ""
            txtTerceirosRefServico.Text = ""
            txtTerceirosCembServico.Text = ""
            txtTerceirosAtivoFixoServico.Text = ""
            txtTerceirosNsServico.Text = ""
            txtTerceirosRcServico.Text = ""
            txtTerceirosOmServico.Text = ""
            txtTerceirosEspecificadorServico.Text = ""

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            txtOrdemCompraItemServico.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sAuxiliar(1) As String
            Dim iCodigoPedidoItem As Integer = -1

            'Seta Váriavel
            If IsNumeric(btnInserirServico.Tag) Then
                iCodigoPedidoItem = grdServico.CurrentRow.Cells("codigo_pedido_item").Value
            End If

            'Seta Váriavel
            If dtpPrevisaoEntregaServico.Tag <> "" And dtpPrevisaoEntregaServico.Tag <> "|" Then
                sAuxiliar = dtpPrevisaoEntregaServico.Tag.ToString.Split("|")
            Else
                sAuxiliar(0) = dtpPrevisaoEntregaServico.Value
                sAuxiliar(1) = txtQuantidadeServico.Value
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirServico.Tag) = False Then

                'Insere Item no Pedido de Venda
                oClsVenPedido.InsertServico(txtOrdemCompraItemServico.Text.Trim, _
                                            cboServico.SelectedValue, _
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
                                            IIf(cboCentroGastoServico.SelectedIndex = -1, -1, cboCentroGastoServico.SelectedValue), _
                                            IIf(cboContaContabilServico.SelectedIndex = -1, "", cboContaContabilServico.SelectedValue), _
                                            oDataEntregaServico, _
                                            iCodigoPedidoItem)

                'Informa o Usuário do Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Exclui Dados da Entrega
                oClsVenPedido.DeleteServicoEntrega(iCodigoPedidoItem)

                'Altera Item no Pedido de Venda
                oClsVenPedido.UpdateServico(txtOrdemCompraItemServico.Text.Trim, _
                                            cboServico.SelectedValue, _
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
                                            IIf(cboCentroGastoServico.SelectedIndex = -1, -1, cboCentroGastoServico.SelectedValue), _
                                            IIf(cboContaContabilServico.SelectedIndex = -1, "", cboContaContabilServico.SelectedValue), _
                                            iCodigoPedidoItem, _
                                            oDataEntregaServico)

                'Informa o Usuário do Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

            oClsVenPedido.SalvarDadosTerceiros(btnSalvar.Tag, _
                                              txtTerceirosPlantaServico.Text.Trim, _
                                              txtTerceirosPoServico.Text.Trim, _
                                              txtTerceirosPoLinhaServico.Text.Trim, _
                                              txtTerceirosRefServico.Text.Trim, _
                                              txtTerceirosCembServico.Text.Trim, _
                                              txtTerceirosAtivoFixoServico.Text.Trim, _
                                              txtTerceirosNsServico.Text.Trim, _
                                              txtTerceirosEspecificadorServico.Text.Trim, _
                                              txtTerceirosRcServico.Text.Trim, _
                                              txtTerceirosOmServico.Text.Trim, _
                                              iCodigoPedidoItem)


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
                    Call oClsVenPedido.DeleteServico()

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

            'Verifica se o Registro pode ser Editado
            If grdServico.CurrentRow.Cells("quantidade_elaboracao").Value > 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Existe Nota Fiscal em Elaboração para este Serviço. Por isso o mesmo não pode ser editado.")
                Exit Sub
            End If

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVendaServico, gcUpdate) = True Then

                'Verifica o Status
                If grdServico.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.PedidoVenda) Then

                    'Carrega Controles
                    oClsVenPedido.EditarServico(grdServico.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                txtOrdemCompraItemServico, _
                                                cboServico, _
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
                                                cboCentroGastoServico, _
                                                cboContaContabilServico)

                    oClsVenPedido.EditarDadosTerceirosServico(grdServico.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                              txtTerceirosAtivoFixoServico, _
                                                              txtTerceirosCembServico, _
                                                              txtTerceirosNsServico, _
                                                              txtTerceirosPlantaServico, _
                                                              txtTerceirosPoServico, _
                                                              txtTerceirosPoLinhaServico, _
                                                              txtTerceirosRefServico, _
                                                              txtTerceirosEspecificadorServico, _
                                                              txtTerceirosRcServico, _
                                                              txtTerceirosOmServico)

                    btnInserirServico.Tag = grdServico.CurrentRow.Cells("codigo_pedido_item").Value

                    'Carrega Váriavel - Entrega
                    Call oClsVenPedido.LoadDadosEntrega(btnSalvar.Tag, _
                                                        btnInserirServico.Tag, _
                                                        oDataEntregaServico)

                    'Seta Cor
                    dtpPrevisaoEntregaProduto.BackColor = System.Drawing.SystemColors.Window

                    'Seta Focu
                    txtOrdemCompraItemServico.Focus()

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
            oClsVenPedido.LoadGridServico(grdServico, btnSalvar.Tag)

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
            If ValidaCampo(cboServico, lblServico) = False Then
                tabDados.SelectedTab = pagServico : cboServico.Focus()
                Exit Function
            End If

            'Verifica se a Comissão está correta
            If grdVendedor.GetDataRows.Count > 0 Then
                If oClsVenPedido.ValidaProdutoComissao(oClsVenPedido.CodigoPedido, _
                                                       cboServico.SelectedValue) = False Then
                    frmMain.errInfo.SetError(lblServico, "Este Serviço não pertence a mesma categoria dos outros Itens do Pedido.")
                    cboServico.Focus()
                    Exit Function
                End If
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

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoServico, lblCentroGastoServico) = False Then
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilServico, lblContaContabilServico) = False Then
                    Exit Function
                End If
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
                        modFunction.DeleteArquivoBD("tb_ven_pedido", oRow.Cells("path").Value, btnSalvar.Tag)
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

#Region "::: NOTA FISCAL :::"

    Private Sub ImprimirDanfe(ByVal sCodigoEmissaoCapa As String)

        Try

            'Verifica se o Usuário tem Direito de Imprimir Danfe
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Dim iTipoDocumentoFiscal As TipoDocumentoFiscal

                If IsNumeric(sCodigoEmissaoCapa) Then
                    iTipoDocumentoFiscal = CType(LoadDescricao("sp_select_faturamento_emissao_tipo_documento_fiscal " & sCodigoEmissaoCapa & ", " & goUsuario.iEmpresa), TipoDocumentoFiscal)
                Else
                    iTipoDocumentoFiscal = TipoDocumentoFiscal.Saida
                End If

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
                goCrystalReport.sReportParameter(0).sValue = sCodigoEmissaoCapa
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000003" & IIf(iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF, "PN", "") & ".rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                If iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF Then
                    frmMain.LoadPageReport("FAT000000003", "PRÉ NOTA", oReport)
                Else
                    frmMain.LoadPageReport("FAT000000003", "DANFE - Documento Auxiliar de Nota Fiscal Eletrônica", oReport)
                End If

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

End Class


