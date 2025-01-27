Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Drawing.Printing
Imports INTERACTI.NFe.CertificadoDigital

Public Class usrFatEmissaoNFe

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe
    Private lCodigoEmissaoCapa As Long

#End Region

#Region "::: STRUCTURE :::"

    Private Structure VetorItem
        Dim indice As Object
        Dim numeroItem As Object
        Dim codigoProduto As Object
        Dim descricao As Object
        Dim cfop As Object
        Dim ncm As Object
        Dim quantidade As Object
        Dim unidadeMedida As Object
        Dim valorUnitario As Object
        Dim valorTotal As Object
        Dim valorDesconto As Object
        Dim valorFrete As Object
        Dim valorSeguro As Object
        Dim valorDespesa As Object
        Dim origem As Object
        Dim tributacaoICMS As Object
        Dim Campo16 As Object
        Dim Campo17 As Object
        Dim Campo18 As Object
        Dim Campo19 As Object
        Dim Campo20 As Object
        Dim Campo21 As Object
        Dim Campo22 As Object
        Dim Campo23 As Object
        Dim Campo24 As Object
        Dim Campo25 As Object
        Dim Campo26 As Object
        Dim Campo27 As Object
        Dim Campo28 As Object
        Dim Campo29 As Object
        Dim Campo30 As Object
        Dim Campo31 As Object
        Dim Campo32 As Object
        Dim Campo33 As Object
    End Structure

    Private Structure VetorParcela
        Dim NumeroDuplicata As Object
        Dim DataVencimento As Object
        Dim Valor As Object
    End Structure

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFatEmissaoNFe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEPDestinatario" : Call btnProcurarCEPDestinatario_Click(btnProcurarCEPDestinatario, System.EventArgs.Empty)
                        Case "cboDestinatario" : Call btnProcurarDestinatario_Click(btnProcurarDestinatario, System.EventArgs.Empty)
                        Case "cboDadosAdicionaisPreCadastrado" : Call btnProcurarDadosAdicionais_Click(btnProcurarDadosAdicionais, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboNaturezaOperacao" : Call LoadCombo(cboNaturezaOperacao, "sp_select_combo_cadastro_basico_natureza_operacao " & goUsuario.iEmpresa)
                        Case "cboPaisDestinatario" : Call LoadCombo(cboPaisDestinatario, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboTransportadora" : Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
                        Case "cboDestinatario" : Call LoadCombo(cboDestinatario, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
                        Case "cboDadosAdicionaisPreCadastrado" : Call LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais), False)
                        Case "cboNCMAdicao" : Call LoadCombo(cboNCMAdicao, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboNaturezaOperacao" : Call btnCadastrarNaturezaOperacao_Click(btnCadastrarNaturezaOperacao, System.EventArgs.Empty)
                        Case "cboDestinatario" : Call btnCadastrarDestinatario_Click(btnCadastrarDestinatario, System.EventArgs.Empty)
                        Case "cboPaisDestinatario" : Call btnCadastrarPaisDestinatario_Click(btnCadastrarPaisDestinatario, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnCadastrarTransportadora_Click(btnCadastrarTransportadora, System.EventArgs.Empty)
                        Case "cboDadosAdicionaisPreCadastrado" : Call btnCadastrarDadosAdicionais_Click(btnCadastrarDadosAdicionais, System.EventArgs.Empty)
                        Case "cboNCMAdicao" : Call btnCadastrarNCM_Click(btnCadastrarNCM, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatEmissaoNFe_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

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
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFe)

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

    Private Sub btnCadastrarNaturezaOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarNaturezaOperacao.Click

        Try

                       'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadNaturezaOperacao")

            'Carrega Combo            
            LoadCombo(cboNaturezaOperacao, "sp_select_combo_cadastro_basico_natureza_operacao " & goUsuario.iEmpresa)

            'Seta Focu
            cboNaturezaOperacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportarPedidoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoVenda.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFePedidoVenda

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemessa.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeRemessa

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRemessaComodato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeRemessaComodato

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDevolucaoNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucaoNotaFiscal.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeDevolucao

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRetornoConsignado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeRetornoConsignado

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportarPedidoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoCompra.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFePedidoCompra

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

            

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDevolucaoNotaFiscalEmitida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucaoNotaFiscalEmitida.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa


            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)


            'Carrega as despesas acessórios
            txtOutrasDespesas.Value = LoadCodigo("sp_select_faturamento_emissao_total_despesa_acessoria " & oClsFatEmissaoNFe.CodigoEmissaoCapa & "," & goUsuario.iEmpresa)


            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRetornoMercadoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeRetornoMaterialTerceiro

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRemessaIndustrializacao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemessaIndustrializacao.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeOrdemIndustrializacao

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.Dock = DockStyle.Fill

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            Call LoadDadosNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click

        Try

            'Váriaveis Locais
            Dim sCodigoEmissaoCapa As String = ""

            For Each oRow As GridEXRow In grdListagem.GetCheckedRows
                sCodigoEmissaoCapa &= IIf(sCodigoEmissaoCapa = "", "", ",") & oRow.Cells("codigo").Value
            Next

            If sCodigoEmissaoCapa = "" Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            Else
                Call ImprimirDanfe(sCodigoEmissaoCapa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnTransmitirLote_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTransmitirLote.Click

        Try

            ''Verifica se foi Selecionado Algum Registro
            'If VerificaSelecaoRow(grdListagem, "status", CInt(StatusNotaFiscalEletronica.AguardandoTransmissao)) = True Then

            'Abre Formulário
            'Dim oForm As New frmFatEmissaoNFeAcaoEmLote
            'oForm.Grid = grdListagem
            ''Abre Formulário
            'oForm.ShowDialog()


            If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then
                Dim oForm As New frmFatEmissaoNFeAcaoEmLote2
                oForm.Grid = grdListagem
                'Abre Formulário
                oForm.ShowDialog()
            Else
                'Abre Formulário
                Dim oForm As New frmFatEmissaoNFeAcaoEmLote
                oForm.Grid = grdListagem
                'Abre Formulário
                oForm.ShowDialog()
            End If


            'Else

            ''Informa o Usuário da Necessidade de Selecionar um ou mais Registro
            'frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            'End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Nota Fiscal
            Call ExcluirCapa()

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

            'Limpa Controles
            Call Novo()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboModelo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Limpa Controles
            Call Novo()

            'Alterna Aba                
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboModelo.Focus()

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

            'Limpa Registro
            'Call Novo()

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

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

                'Calcula Totais
                Call oClsFatEmissaoNFe.LoadDadosTotal(txtBaseCalculoICMS, _
                                                      txtTotalICMS, _
                                                      txtBaseCalculoICMSST, _
                                                      txtTotalICMSST, _
                                                      txtTotalProdutoServico, _
                                                      txtTotalII, _
                                                      txtTotalIPI, _
                                                      txtTotalPIS, _
                                                      txtTotalCOFINS, _
                                                      txtTotalDesconto, _
                                                      txtTotalSeguro, _
                                                      txtTotalFrete, _
                                                      txtOutrasDespesas, _
                                                      txtTotalFrete.Value, _
                                                      txtTotalSeguro.Value, _
                                                      txtOutrasDespesas.Value, _
                                                      txtTotalFCP, _
                                                      txtTotalICMSRemetente, _
                                                      txtTotalICMSDestino)

                'Salva Dados do Registro
                Call Salvar()

                'Verifica se o Número da Nota Fiscal é gerado agora
                If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'gerar_numeracao_nfe'"), Boolean) = True Or _
                   cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or _
                   cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking) Then

                    'Gera Número da Nota Fiscal
                    If txtNotaFiscal.Text = "" Then
                        txtNotaFiscal.Text = oClsFatEmissaoNFe.GeraNumeroNotaFiscal
                    End If

                End If

                'Seta Status
                If cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or _
                   cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking) Then
                    txtStatusNFe.Tag = StatusNotaFiscalEletronica.AutorizadaUso
                ElseIf IsNumeric(txtStatusNFe.Tag) = False Then
                    txtStatusNFe.Tag = StatusNotaFiscalEletronica.AguardandoTransmissao
                End If

                'Verifica o Status da NFe
                Call VerificaStatus(txtStatusNFe.Tag)

                'Adiciona e Seta Focu - pagNFe
                If cboTipoDocumento.SelectedValue <> CInt(TipoDocumentoFiscal.SaidaSemNF) And _
                   cboTipoDocumento.SelectedValue <> CInt(TipoDocumentoFiscal.Picking) Then
                    tabDados.TabPages.Remove(pagNFe)
                    tabDados.TabPages.Add(pagNFe)
                    tabDados.SelectedTab = pagNFe
                Else
                    Call Integracao()
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.SelectedIndexChanged

        Try

            'Oculta Abas            
            tabDados.TabPages.Remove(pagDestinatario)
            tabDados.TabPages.Remove(pagDIAdicao)
            tabDados.TabPages.Remove(pagProduto)
            tabDados.TabPages.Remove(pagFCI)
            tabDados.TabPages.Remove(pagTransporte)
            tabDados.TabPages.Remove(pagTotais)
            tabDados.TabPages.Remove(pagCobranca)
            tabDados.TabPages.Remove(pagInformacoesAdicionais)
            tabDados.TabPages.Remove(pagExportacaoCompras)
            tabDados.TabPages.Remove(pagNFe)
            'Seta Controle
            btnImportarPedidoVenda.Enabled = False
            btnRemessa.Enabled = False
            btnImportarPedidoCompra.Enabled = False
            btnDevolucaoNotaFiscal.Enabled = False

            If goUsuario.sCNPJEmpresa = "07.146.092/0001-61" Then
                If cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Saida) Then
                    cboSerie.SelectedValue = 1
                ElseIf cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Entrada) Then
                    cboSerie.SelectedValue = 2
                End If
            End If

            If cboTipoDocumento.SelectedIndex <> -1 AndAlso cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Entrada) Then

                'Exibe Abas
                tabDados.TabPages.Add(pagDestinatario)
                tabDados.TabPages.Add(pagDIAdicao)
                tabDados.TabPages.Add(pagProduto)
                tabDados.TabPages.Add(pagTransporte)
                tabDados.TabPages.Add(pagTotais)
                tabDados.TabPages.Add(pagCobranca)
                tabDados.TabPages.Add(pagInformacoesAdicionais)
                tabDados.TabPages.Add(pagExportacaoCompras)

                'Seta Controle
                Call cboFinalidadeEmissao_SelectedIndexChanged(cboFinalidadeEmissao, System.EventArgs.Empty)

            ElseIf cboTipoDocumento.SelectedIndex <> -1 AndAlso cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Saida) Then

                'Exibe Abas
                tabDados.TabPages.Add(pagDestinatario)
                tabDados.TabPages.Add(pagProduto)
                tabDados.TabPages.Add(pagFCI)
                tabDados.TabPages.Add(pagTransporte)
                tabDados.TabPages.Add(pagTotais)
                tabDados.TabPages.Add(pagCobranca)
                tabDados.TabPages.Add(pagInformacoesAdicionais)
                tabDados.TabPages.Add(pagExportacaoCompras)

                'Seta Controle
                Call cboFinalidadeEmissao_SelectedIndexChanged(cboFinalidadeEmissao, System.EventArgs.Empty)

            ElseIf cboTipoDocumento.SelectedIndex <> -1 AndAlso (cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking)) Then

                'Exibe Abas
                tabDados.TabPages.Add(pagDestinatario)
                tabDados.TabPages.Add(pagProduto)
                tabDados.TabPages.Add(pagTransporte)
                tabDados.TabPages.Add(pagTotais)
                tabDados.TabPages.Add(pagCobranca)
                tabDados.TabPages.Add(pagInformacoesAdicionais)
                tabDados.TabPages.Add(pagExportacaoCompras)

                'Seta Controle
                Call cboFinalidadeEmissao_SelectedIndexChanged(cboFinalidadeEmissao, System.EventArgs.Empty)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModelo.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum modelo
            If cboModelo.SelectedIndex = -1 Then
                'Limpa Controles
                cboSerie.DataSource = Nothing
                cboSerie.Text = ""
                txtNotaFiscal.Text = ""
            Else
                'Carrega Combo - Série
                Call LoadCombo(cboSerie, "sp_select_combo_configuracao_serie_nota_fiscal " & goUsuario.iEmpresa & ", " & cboModelo.SelectedValue, True)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFinalidadeEmissao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFinalidadeEmissao.SelectedIndexChanged

        Try

            'Desabilita Controles
            btnDevolucaoNotaFiscal.Enabled = False
            btnRemessa.Enabled = False
            btnImportarPedidoCompra.Enabled = False
            btnImportarPedidoVenda.Enabled = False
            btnRemessaIndustrializacao.Enabled = False

            'Verifica a Finalidade
            If cboFinalidadeEmissao.SelectedIndex <> -1 Then

                Select Case cboFinalidadeEmissao.SelectedValue

                    Case FinalidadeEmissaoNFe.NFeDevolucao
                        btnDevolucaoNotaFiscal.Enabled = True
                        If tabNFe.TabPages.Contains(pagNFReferenciada) = False Then
                            tabNFe.TabPages.Add(pagNFReferenciada)
                        End If

                    Case FinalidadeEmissaoNFe.NFeNormal
                        If cboTipoDocumento.SelectedIndex <> -1 AndAlso cboTipoDocumento.SelectedValue = TipoDocumentoFiscal.Entrada Then
                            btnImportarPedidoCompra.Enabled = True
                            btnDevolucaoNotaFiscal.Enabled = True
                        ElseIf cboTipoDocumento.SelectedIndex <> -1 Then
                            btnImportarPedidoVenda.Enabled = True
                            btnDevolucaoNotaFiscal.Enabled = True
                            btnRemessa.Enabled = True
                            btnRemessaIndustrializacao.Enabled = True
                        End If
                        If tabNFe.TabPages.Contains(pagNFReferenciada) = True Then
                            tabNFe.TabPages.Remove(pagNFReferenciada)
                        End If

                    Case FinalidadeEmissaoNFe.NFeComplementar, FinalidadeEmissaoNFe.NFeAjuste
                        If tabNFe.TabPages.Contains(pagNFReferenciada) = False Then
                            tabNFe.TabPages.Add(pagNFReferenciada)
                        End If

                End Select

            End If
            VerificaStatus(txtStatusNFe.Tag)
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(ByVal sender As Object, ByVal e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Verifica se a Coluna é a Data de Aceite
            If e.Column.Key = "data_aceite" Then

                'Váriaveis - Query
                Dim sQuery As String

                sQuery = "sp_update_interacti_table_field "
                sQuery &= "'tb_fat_emissao_capa', "
                sQuery &= "'data_aceite', "
                If IsDBNull(grdListagem.GetValue("data_aceite")) = False AndAlso IsDate(grdListagem.GetValue("data_aceite")) Then
                    If DateDiff(DateInterval.Day, grdListagem.GetValue("data_aceite"), grdListagem.GetValue("data_saida")) > 0 Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Data de Aceite menor que a Data de Saída.")
                        grdListagem.SetValue("data_aceite", DBNull.Value)
                        sQuery &= "'NULL',"
                    Else
                        sQuery &= "'''" & grdListagem.GetValue("data_aceite") & "''',"
                    End If
                Else
                    sQuery &= "'NULL',"
                End If
                sQuery &= "'WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))'"

                'Atualiza Registro
                Call ExecuteQuery(sQuery)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarNotaFiscal(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "duplicar" : Call DuplicarNotaFiscal(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "imprimir" : Call ImprimirDanfe(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "email" : Call EmailNFe1(grdListagem.CurrentRow.Cells("codigo").Value, grdListagem.CurrentRow.Cells("status").Value)
                Case "cancelar" : Call CancelarNFe(grdListagem.CurrentRow.Cells("codigo").Value, grdListagem.CurrentRow.Cells("status").Value)
                Case "historico" : Call HistoricoNFe()
                Case "relatorio_entrega" : Call RelatorioEntrega(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "integracao_vendas" : Call IntegracaoVenda()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Torna Invisível Controles
            btnInserirItem.Visible = False
            btnExcluirItem.Visible = False
            btnGerarFCI.Visible = False
            btnImportarArquivoRetornoFCI.Visible = False

            Select Case e.Page.Name

                Case "pagDadosNFe"
                    Call cboFinalidadeEmissao_SelectedIndexChanged(cboFinalidadeEmissao, System.EventArgs.Empty)

                Case "pagProduto"
                    btnInserirItem.Visible = True
                    btnExcluirItem.Visible = True

                    'Verifica se o Botão esta Habilitado
                    If btnSalvar.Enabled = True Then

                        'Atualiza Dados do Item
                        If cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                            Call oClsFatEmissaoNFe.AtualizaDadosProduto(txtTotalFrete.Value, _
                                                                        txtTotalSeguro.Value, _
                                                                        txtOutrasDespesas.Value)
                        End If

                        'Carrega Grid de Produto
                        Call LoadGridProduto()

                    End If

                Case "pagTotais"
                    'Verifica se o Botão esta Habilitado
                    If btnSalvar.Enabled = True Then
                        'Carrega Totais
                        Call oClsFatEmissaoNFe.LoadDadosTotal(txtBaseCalculoICMS, _
                                                              txtTotalICMS, _
                                                              txtBaseCalculoICMSST, _
                                                              txtTotalICMSST, _
                                                              txtTotalProdutoServico, _
                                                              txtTotalII, _
                                                              txtTotalIPI, _
                                                              txtTotalPIS, _
                                                              txtTotalCOFINS, _
                                                              txtTotalDesconto, _
                                                              txtTotalSeguro, _
                                                              txtTotalFrete, _
                                                              txtOutrasDespesas, _
                                                              txtTotalFrete.Value, _
                                                              txtTotalSeguro.Value, _
                                                              txtOutrasDespesas.Value, _
                                                              txtTotalFCP, _
                                                              txtTotalICMSRemetente, _
                                                              txtTotalICMSDestino)
                    End If

                Case "pagCobranca"
                    If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then

                        'Verifica se o Botão esta Habilitado
                        If btnSalvar.Enabled = True Then
                            'Carrega Dados da Fatura
                            Call oClsFatEmissaoNFe.LoadDadosFatura(txtValorOriginal, _
                                                                   txtValorDesconto, _
                                                                   txtValorPago, _
                                                                   cboCondicaoPagamento, _
                                                                   txtTotalFrete.Value, _
                                                                   txtTotalSeguro.Value, _
                                                                   txtOutrasDespesas.Value)
                        End If


                        'Verifica se está configurado para o Financeiro
                        If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'faturamento_financeiro_manual'"), Boolean) = True Then

                            'Verifica se pode apresentar o Financeiro
                            grpDadosFinanceiro.Enabled = True
                            grpDadosFinanceiro.Visible = True
                            grdFinanceiro.Enabled = True
                            grdFinanceiro.Visible = True

                        Else
                            'Verifica se pode apresentar o Financeiro
                            grpDadosFinanceiro.Enabled = False
                            grpDadosFinanceiro.Visible = False
                            grdFinanceiro.Enabled = False
                            grdFinanceiro.Visible = False

                        End If

                    End If
                Case "pagTransporte"
                    'Verifica se o Botão esta Habilitado
                    If btnSalvar.Enabled = True And cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                        'Carrega Peso Líquido
                        Call oClsFatEmissaoNFe.LoadDadosPeso(txtPesoLiquidoTransportadora)
                    End If

                Case "pagFCI"
                    'Verifica se o Botão esta Habilitado
                    If btnSalvar.Enabled = True And cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                        btnGerarFCI.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFeFCI, gcInsert)
                        btnImportarArquivoRetornoFCI.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFeFCI, gcInsert)
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArrumarCancelamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrumarCancelamento.Click
        Try
            Dim sPastaEnvio As String = "C:\Users\tharcius.pivetta\Desktop\NF-E\NF-E\Pasta Envio\"
            Dim oDataReader As Data.SqlClient.SqlDataReader
            Dim lCodigo As Long
            oDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.Text, "SELECT codigo, chave_acesso FROM tb_fat_emissao_capa WHERE status = 5 AND xml_cancelamento_envio IS NULL")
            While oDataReader.Read


                Try
                    Dim sDadosEnvio As String = ""
                    Dim sDadosRetorno As String = ""
                    lCodigo = oDataReader("codigo")
                    'Abre o arquivo
                    Dim oStreamReader As New System.IO.StreamReader(CStr(sPastaEnvio + "ID110111" + oDataReader("chave_acesso") + "01-ped-cancelamento-ass.xml"), System.Text.Encoding.Default)
                    sDadosEnvio = oStreamReader.ReadToEnd
                    oStreamReader.Close()

                    oStreamReader = New System.IO.StreamReader(CStr(sPastaEnvio + "ID110111" + oDataReader("chave_acesso") + "01-ret-ped-cancelamento.xml"), System.Text.Encoding.Default)
                    sDadosRetorno = oStreamReader.ReadToEnd
                    oStreamReader.Close()

                    Dim oSqlParameter(2) As SqlClient.SqlParameter
                    'Seta Parametros - Mensagem Sefaz
                    oSqlParameter(0) = New SqlClient.SqlParameter
                    oSqlParameter(0).ParameterName = "codigo"
                    oSqlParameter(0).Direction = ParameterDirection.Input
                    oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(0).Value = lCodigo

                    'Seta Parametros - Mensagem Sefaz
                    oSqlParameter(1) = New SqlClient.SqlParameter
                    oSqlParameter(1).ParameterName = "xml_envio"
                    oSqlParameter(1).Direction = ParameterDirection.Input
                    oSqlParameter(1).SqlDbType = SqlDbType.Text
                    oSqlParameter(1).Value = sDadosEnvio

                    'Seta Parametros - Mensagem Sefaz
                    oSqlParameter(2) = New SqlClient.SqlParameter
                    oSqlParameter(2).ParameterName = "xml_retorno"
                    oSqlParameter(2).Direction = ParameterDirection.Input
                    oSqlParameter(2).SqlDbType = SqlDbType.Text
                    oSqlParameter(2).Value = sDadosRetorno


                    SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "teste_insert", oSqlParameter)

                Catch ex As Exception

                End Try
            End While
            oDataReader.Close()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: NF REFERENCIADA :::"

    Private Sub btnAgruparGridNFReferenciada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridNFReferenciada.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNFReferenciada.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNFReferenciada.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNFReferenciada.GroupByBoxVisible = True
                grdNFReferenciada.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridNFReferenciada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridNFReferenciada.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNFReferenciada
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNFReferenciada, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridNFReferenciada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridNFReferenciada.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdNFReferenciada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirNFReferenciada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirNFReferenciada.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida NF Referenciada
            If ValidacaoNFReferenciada() = True Then

                'Insere / Atualiza Registro
                Call SalvarNFReferenciada()

                'Carrega Grid
                Call oClsFatEmissaoNFe.LoadGridNFReferenciada(grdNFReferenciada)

                'Limpa Controles
                Call NovoNFReferenciada()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirNFReferenciada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirNFReferenciada.Click

        Try

            'Exclui NF Referenciada
            Call ExcluirNFReferenciada()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoNotaFiscalReferenciada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoNotaFiscalReferenciada.SelectedIndexChanged

        Try

            'Limpa Controles - Nota Fiscal Eletrônica
            lblNotaFiscalChaveAcessoNFReferenciada.Visible = False : cboNotaFiscalChaveAcessoNFReferenciada.Visible = False
            'Limpa Controles - Nota Fiscal
            lblUFNFReferenciada.Visible = False : cboUFNFReferenciada.Visible = False
            lblDataEmissaoNFReferenciada.Visible = False : dtpDataEmissaoNFReferenciada.Visible = False
            lblCNPJNFReferenciada.Visible = False : txtCNPJNFReferenciada.Visible = False
            lblSerieNFReferenciada.Visible = False : txtSerieNFReferenciada.Visible = False
            lblNotaFiscalNFReferenciada.Visible = False : txtNotaFiscalNFReferenciada.Visible = False

            'Verifica o Tipo de Nota Fiscal
            If cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                lblNotaFiscalChaveAcessoNFReferenciada.Visible = True : cboNotaFiscalChaveAcessoNFReferenciada.Visible = True
                'Carrega Combo
                Call LoadCombo(cboNotaFiscalChaveAcessoNFReferenciada, "sp_select_combo_faturamento_nota_fiscal_referenciada " & goUsuario.iEmpresa, False)
            ElseIf cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal) Then
                lblUFNFReferenciada.Visible = True : cboUFNFReferenciada.Visible = True
                lblDataEmissaoNFReferenciada.Visible = True : dtpDataEmissaoNFReferenciada.Visible = True
                lblCNPJNFReferenciada.Visible = True : txtCNPJNFReferenciada.Visible = True
                lblSerieNFReferenciada.Visible = True : txtSerieNFReferenciada.Visible = True
                lblNotaFiscalNFReferenciada.Visible = True : txtNotaFiscalNFReferenciada.Visible = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNotaFiscalChaveAcessoNFReferenciada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNotaFiscalChaveAcessoNFReferenciada.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboNotaFiscalChaveAcessoNFReferenciada.SelectedIndex = -1 Then
                cboNotaFiscalChaveAcessoNFReferenciada.Tag = ""
            Else
                cboNotaFiscalChaveAcessoNFReferenciada.Tag = LoadDescricao("sp_select_faturamento_emissao_nota_fiscal_referenciada_destinatario '" & cboNotaFiscalChaveAcessoNFReferenciada.SelectedValue & "', " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNFReferenciada_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdNFReferenciada.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdNFReferenciada.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdNFReferenciada.CurrentColumn.Key
                Case "editar" : Call EditarNFReferenciada()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNFReferenciada_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNFReferenciada.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNFReferenciada.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNFReferenciada_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNFReferenciada.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNFReferenciada, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNFReferenciada_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdNFReferenciada.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNFReferenciada.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DESTINATÁRIO :::"

    Private Sub btnCadastrarDestinatario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDestinatario.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            Dim sProcedure As String

            If cboTipoDocumento.SelectedValue = TipoDocumentoFiscal.Entrada Then
                sProcedure = "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa
            Else
                sProcedure = "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa
            End If

            'Carrega Combo            
            LoadCombo(cboDestinatario, sProcedure)

            'Seta Focu
            cboDestinatario.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPaisDestinatario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisDestinatario.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo            
            LoadCombo(cboPaisDestinatario, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

            'Seta Focu
            cboPaisDestinatario.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCEPDestinatario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEPDestinatario.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCEPDestinatario.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPDestinatario.Text.Trim, "-", "")), _
                           cboPaisDestinatario, _
                           cboUFDestinatario, _
                           cboMunicipioDestinatario, _
                           txtBairroDestinatario, _
                           txtLogradouroDestinatario, _
                           txtComplementoDestinatario)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarDestinatario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarDestinatario.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = IIf(cboTipoDocumento.SelectedValue = TipoDocumentoFiscal.Entrada, TipoParceiroNegocio.fornecedor, TipoParceiroNegocio.cliente)
            oComboBoxFind = cboDestinatario

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboDestinatario.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnderecoLocalRetirada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnderecoLocalRetirada.Click

        'Abre Formulário de Local de Retirada
        Call LocalRetirada()

    End Sub

    Private Sub btnEnderecoLocalEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnderecoLocalEntrega.Click

        'Abre Formulário de Local de Entrega
        Call LocalEntrega()

    End Sub

    Private Sub cboDestinatario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestinatario.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Destinatário
            If cboDestinatario.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                txtCNPJDestinatario.Enabled = False : txtCNPJDestinatario.Text = ""
                txtInscricaoEstadualDestinatario.Enabled = False : txtInscricaoEstadualDestinatario.Text = ""
                txtInscricaoSuframaDestinatario.Enabled = False : txtInscricaoSuframaDestinatario.Text = ""
                txtLogradouroDestinatario.Enabled = False : txtLogradouroDestinatario.Text = ""
                txtNumeroDestinatario.Enabled = False : txtNumeroDestinatario.Text = ""
                txtComplementoDestinatario.Enabled = False : txtComplementoDestinatario.Text = ""
                txtBairroDestinatario.Enabled = False : txtBairroDestinatario.Text = ""
                txtCEPDestinatario.Enabled = False : txtCEPDestinatario.Text = ""
                cboPaisDestinatario.Enabled = False : cboPaisDestinatario.SelectedIndex = -1
                cboUFDestinatario.Enabled = False : cboUFDestinatario.SelectedIndex = -1
                cboMunicipioDestinatario.Enabled = False : cboMunicipioDestinatario.SelectedIndex = -1
                txtTelefoneDestinatario.Enabled = False : txtTelefoneDestinatario.Text = ""
                txtEmailDestinatario.Enabled = False : txtEmailDestinatario.Text = ""
                txtIdentificacao.Enabled = False : txtIdentificacao.Text = ""
                txtCNPJDestinatario.Tag = ""
                'Remove Aba DI
                tabDados.TabPages.Remove(pagDIAdicao)

            Else
                txtIdentificacao.Enabled = True : txtIdentificacao.Text = ""

                'Carrega dados do Destinatário
                Call LoadDadosParceiroNegocioFaturamento(cboDestinatario.SelectedValue, _
                                                         txtCNPJDestinatario, _
                                                         txtInscricaoEstadualDestinatario, _
                                                         txtInscricaoSuframaDestinatario, _
                                                         txtLogradouroDestinatario, _
                                                         txtNumeroDestinatario, _
                                                         txtComplementoDestinatario, _
                                                         txtBairroDestinatario, _
                                                         txtCEPDestinatario, _
                                                         cboPaisDestinatario, _
                                                         cboUFDestinatario, _
                                                         cboMunicipioDestinatario, _
                                                         txtTelefoneDestinatario, _
                                                         txtEmailDestinatario, _
                                                         cboModalidadeFrete)

                'Verifica a Finalidade de Emissão da NFe
                If cboFinalidadeEmissao.SelectedValue <> CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                    'Desabilita Controles
                    txtCNPJDestinatario.Enabled = False
                    txtInscricaoEstadualDestinatario.Enabled = False
                    txtInscricaoSuframaDestinatario.Enabled = False
                    txtLogradouroDestinatario.Enabled = False
                    txtNumeroDestinatario.Enabled = False
                    txtComplementoDestinatario.Enabled = False
                    txtBairroDestinatario.Enabled = False
                    txtCEPDestinatario.Enabled = False
                    cboPaisDestinatario.Enabled = False
                    cboUFDestinatario.Enabled = False
                    cboMunicipioDestinatario.Enabled = False
                    txtTelefoneDestinatario.Enabled = False
                    txtEmailDestinatario.Enabled = False
                End If

                'Verifica o Tipo de Personalidade
                If txtCNPJDestinatario.Tag = Personalidade.Fisica Then
                    lblCNPJDestinatario.Text = "CPF:"
                    txtCNPJDestinatario.Mask = "000,000,000-00"
                    lblInscricaoEstadualDestinatario.Text = "RG:"
                Else
                    lblCNPJDestinatario.Text = "CNPJ:"
                    txtCNPJDestinatario.Mask = "00,000,000/0000-00"
                    lblInscricaoEstadualDestinatario.Text = "IE:"
                End If

                'Adiciona Aba - DI
                If cboPaisDestinatario.SelectedValue <> CInt(Pais.Brasil) And cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Entrada) Then
                    If tabDados.TabPages.Contains(pagDIAdicao) = False Then
                        tabDados.TabPages.Remove(pagProduto)
                        tabDados.TabPages.Remove(pagFCI)
                        tabDados.TabPages.Remove(pagTotais)
                        tabDados.TabPages.Remove(pagTransporte)
                        tabDados.TabPages.Remove(pagCobranca)
                        tabDados.TabPages.Remove(pagInformacoesAdicionais)
                        tabDados.TabPages.Remove(pagExportacaoCompras)
                        tabDados.TabPages.Remove(pagNFe)
                        tabDados.TabPages.Add(pagDIAdicao)
                        tabDados.TabPages.Add(pagProduto)
                        tabDados.TabPages.Add(pagFCI)
                        tabDados.TabPages.Add(pagTotais)
                        tabDados.TabPages.Add(pagTransporte)
                        tabDados.TabPages.Add(pagCobranca)
                        tabDados.TabPages.Add(pagInformacoesAdicionais)
                        tabDados.TabPages.Add(pagExportacaoCompras)
                        If txtStatusNFe.Tag.ToString <> "" Then
                            tabDados.TabPages.Add(pagNFe)
                        End If
                    End If
                Else
                    tabDados.TabPages.Remove(pagDIAdicao)
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPaisDestinatario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaisDestinatario.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisDestinatario.SelectedIndex = -1 Then
                'Limpa Controles
                cboUFDestinatario.DataSource = Nothing
                cboUFDestinatario.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboUFDestinatario, "sp_select_combo_static_estado_pais " & cboPaisDestinatario.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFDestinatario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFDestinatario.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFDestinatario.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioDestinatario.DataSource = Nothing
                cboMunicipioDestinatario.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioDestinatario, "sp_select_combo_static_municipio '" & cboUFDestinatario.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkLocalRetirada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocalRetirada.CheckedChanged

        'Seta Enable
        btnEnderecoLocalRetirada.Visible = chkLocalRetirada.Checked

    End Sub

    Private Sub chkLocalEntrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocalEntrega.CheckedChanged

        'Seta Enable
        btnEnderecoLocalEntrega.Visible = chkLocalEntrega.Checked

    End Sub

#End Region

#Region "::: TOTAL :::"

    Private Sub CalculaTotalNF_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalFrete.ValueChanged, _
                                                                                                         txtTotalSeguro.ValueChanged, _
                                                                                                         txtOutrasDespesas.ValueChanged, _
 _
                                                                                                         txtTotalProdutoServico.ValueChanged, _
                                                                                                         txtTotalIPI.ValueChanged, _
                                                                                                         txtTotalDesconto.ValueChanged, _
                                                                                                         txtTotalICMSST.ValueChanged

        Try

            'Seta Valor
            txtTotalNotaFiscal.Value = txtTotalProdutoServico.Value + _
                                       txtTotalFrete.Value + _
                                       txtTotalSeguro.Value - _
                                       txtTotalDesconto.Value + _
                                       txtOutrasDespesas.Value + _
                                       txtTotalIPI.Value + _
                                       txtTotalICMSST.Value

            If cboNumeroDIAdicao.Items.Count > 0 Then

                If LoadCodigo("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'somar_ii_importacao'") = True Then

                    txtTotalNotaFiscal.Value += txtTotalII.Value

                End If

                If LoadCodigo("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'somar_pis_cofins_importacao'") = True Then

                    txtTotalNotaFiscal.Value += txtTotalCOFINS.Value + txtTotalPIS.Value

                End If

                txtTotalNotaFiscal.Value += txtTotalICMS.Value

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaTotalNF_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalFrete.LostFocus, _
                                                                                                      txtTotalSeguro.LostFocus, _
                                                                                                      txtOutrasDespesas.LostFocus, _
                                                                                                      txtTotalProdutoServico.LostFocus, _
                                                                                                      txtTotalIPI.LostFocus, _
                                                                                                      txtTotalDesconto.LostFocus

        Try

            'Verifica a Finalidade de Emissão da Nota Fiscal
            If cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal) Then

                'Calcula Valor
                Call oClsFatEmissaoNFe.LoadDadosTotal(txtBaseCalculoICMS, _
                                                      txtTotalICMS, _
                                                      txtBaseCalculoICMSST, _
                                                      txtTotalICMSST, _
                                                      txtTotalProdutoServico, _
                                                      txtTotalII, _
                                                      txtTotalIPI, _
                                                      txtTotalPIS, _
                                                      txtTotalCOFINS, _
                                                      txtTotalDesconto, _
                                                      txtTotalSeguro, _
                                                      txtTotalFrete, _
                                                      txtOutrasDespesas, _
                                                      txtTotalFrete.Value, _
                                                      txtTotalSeguro.Value, _
                                                      txtOutrasDespesas.Value, _
                                                      txtTotalFCP, _
                                                      txtTotalICMSRemetente, _
                                                      txtTotalICMSDestino)

                'Seta Valor
                txtTotalNotaFiscal.Value = txtTotalProdutoServico.Value + _
                                           txtTotalFrete.Value + _
                                           txtTotalSeguro.Value + _
                                           txtOutrasDespesas.Value - _
                                           txtTotalDesconto.Value + _
                                           txtTotalIPI.Value + _
                                           txtTotalICMSST.Value

                If cboNumeroDIAdicao.Items.Count > 0 Then

                    If LoadCodigo("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'somar_ii_importacao'") = True Then

                        txtTotalNotaFiscal.Value += txtTotalII.Value

                    End If

                    If LoadCodigo("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'somar_pis_cofins_importacao'") = True Then

                        txtTotalNotaFiscal.Value += txtTotalCOFINS.Value + txtTotalPIS.Value

                    End If

                    txtTotalNotaFiscal.Value += txtTotalICMS.Value

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: INFORMAÇÕES ADICIONAIS :::"

    Private Sub btnCadastrarDadosAdicionais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDadosAdicionais.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAutotexto")

            'Carrega Combo            
            LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais))

            'Seta Focu
            cboDadosAdicionaisPreCadastrado.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarDadosAdicionais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarDadosAdicionais.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindAutotexto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Autotexto"

            iTipoAutoTextoFind = TipoAutotexto.DadosAdicionais
            oComboBoxFind = cboDadosAdicionaisPreCadastrado
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboDadosAdicionaisPreCadastrado.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboDadosAdicionaisPreCadastrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosAdicionaisPreCadastrado.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Dado Adicional 
            If cboDadosAdicionaisPreCadastrado.SelectedIndex > -1 Then
                'Preenche Controle
                LoadDescricao(txtDadosAdicionais, "sp_select_faturamento_emissao_dados_adicionais " & cboDadosAdicionaisPreCadastrado.SelectedValue & ", " & oClsFatEmissaoNFe.CodigoEmissaoCapa & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub btnCalcularDuplicata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDuplicata.Click

        Try

            'Verifica se foi Selecionado a Condição de Pagamento
            If cboCondicaoPagamento.SelectedIndex = -1 Then

                'Gera Parcela
                Call oClsFatEmissaoNFe.GerarDuplicata2(grdDuplicata, _
                                                       txtValorLiquido.Value, _
                                                       txtNumeroParcela.Value, _
                                                       txtIntervaloEntreParcelas.Value, _
                                                       txtTotalICMSST.Value)

            Else

                'Gera Parcela
                Call oClsFatEmissaoNFe.GerarDuplicata(grdDuplicata, _
                                                      cboCondicaoPagamento.SelectedValue, _
                                                      txtValorLiquido.Value, _
                                                      dtpDataEmissao.Value, _
                                                      txtTotalICMSST.Value)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFormaPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaPagamento.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado alguma Forma de Pagamento
            If cboFormaPagamento.SelectedIndex = -1 Then
                'Limpa Controles
                grdDuplicata.DataSource = Nothing
                txtNumeroParcela.Enabled = False
                txtIntervaloEntreParcelas.Enabled = False
            ElseIf cboFormaPagamento.SelectedValue = FormaPagamentoNFe.PagamentoAVista Then
                'Desabilita Controles
                txtNumeroParcela.Value = 1 : txtNumeroParcela.Enabled = False
                txtIntervaloEntreParcelas.Value = 0 : txtIntervaloEntreParcelas.Enabled = False
            ElseIf cboFormaPagamento.SelectedValue = FormaPagamentoNFe.PagamentoAPrazo Then
                'Habilita Controles
                txtNumeroParcela.Enabled = True
                txtIntervaloEntreParcelas.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaCobranca_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorOriginal.ValueChanged, _
                                                                                                          txtValorDesconto.ValueChanged, _
                                                                                                          txtValorPago.ValueChanged

        Try



            'Calcula Valor Líquido
            txtValorLiquido.Value = txtValorOriginal.Value - txtValorDesconto.Value - txtValorPago.Value



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDuplicata_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDuplicata.CellValueChanged

        Try

            Select Case e.Column.Key

                Case "pago"
                    Dim j As Integer = grdDuplicata.CurrentRow.RowIndex

                    If grdDuplicata.GetValue("valor_pago") > 0 Then
                        grdDuplicata.SetValue("pago", True)
                    End If

                    If grdDuplicata.GetValue(e.Column) = True Then
                        Dim oRow() As GridEXRow
                        oRow = grdDuplicata.GetDataRows
                        For i = 0 To UBound(oRow)
                            If j = oRow(i).RowIndex Then
                                Exit For
                            End If
                            grdDuplicata.Row = oRow(i).RowIndex
                            grdDuplicata.SetValue(e.Column, True)
                        Next
                    ElseIf grdDuplicata.GetValue(e.Column) = False Then
                        Dim oRow() As GridEXRow
                        oRow = grdDuplicata.GetDataRows
                        For i = UBound(oRow) To 0 Step -1
                            If j = oRow(i).RowIndex Then
                                Exit For
                            End If
                            grdDuplicata.Row = oRow(i).RowIndex
                            grdDuplicata.SetValue(e.Column, False)
                        Next
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FINANCEIRO MANUAL ::: "

    Private Sub CalculaFinanceiroValorParcela_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinanceiroPercentualParcela.LostFocus, _
                                                                                                                        txtFinanceiroValorParcela.LostFocus


        Try

            Select Case sender.Name

                Case "txtFinanceiroPercentualParcela"
                    txtFinanceiroValorParcela.Value = Math.Round((txtFinanceiroPercentualParcela.Value / 100) * txtValorLiquido.Value, 2)

                Case "txtFinanceiroValorParcela"
                    txtFinanceiroPercentualParcela.Value = Math.Round((txtFinanceiroValorParcela.Value / txtValorLiquido.Value) * 100, 2)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFinanceiro_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdFinanceiro.RowDoubleClick

        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdFinanceiro.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdFinanceiro.CurrentColumn.Key

                Case "editar" : Call EditarFinanceiro()


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFinanceiroInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceiroInserir.Click
        Try
            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se Existe Valor Parcela
            If txtFinanceiroValorParcela.Value > 0 Then

                'Verifica o Tipo de Operação
                Call oClsFatEmissaoNFe.InsertFinanceiroGrid(grdFinanceiro, _
                                                           DateAdd(DateInterval.Day, txtFinanceiroIntervaloParcelas.Value, Now.Date), _
                                                           txtFinanceiroNumeroParcela.Value, _
                                                           txtFinanceiroIntervaloParcelas.Value, _
                                                           txtFinanceiroPercentualParcela.Value, _
                                                           txtFinanceiroValorParcela.Value, _
                                                           IIf(IsNumeric(btnFinanceitoExcluir.Tag), btnFinanceitoExcluir.Tag, IIf(grdFinanceiro.RowCount = 0, 1, grdFinanceiro.RowCount + 1)), _
                                                           IIf(IsNumeric(btnFinanceiroInserir.Tag), "U", "I"))
                'Limpa Controles
                NovoFinanceiro()
            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, " O valor da parcela deve maior que zero.")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)

        End Try
    End Sub

    Private Sub btnFinanceitoExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceitoExcluir.Click
        Try

            'Deleta Registros
            Call DeleteFinanceiro()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


#End Region

#Region "::: DI / ADIÇÃO :::"

#Region "::: DI :::"

    Private Sub btnAgruparGridDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridDI.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdDI.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdDI.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdDI.GroupByBoxVisible = True
                grdDI.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDI.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDI
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDI, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDI.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDI)

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
            LoadCombo(cboNCMAdicao, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboNCMAdicao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDI.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoDI() = True Then

                'Salva Dados do Registro
                Call SalvarDI()
                'Limpa Formulário
                Call NovoDI()
                'Carrega Grid
                Call LoadGridDI()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDI.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Registro
            Call ExcluirDI()
            'Limpa Formulário
            Call NovoDI()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDI_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDI.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdDI.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdDI.CurrentColumn.Key

                Case "editar"
                    txtNumeroDI.Text = grdDI.CurrentRow.Cells("numero_di").Value
                    dtpDataRegistroDI.Value = grdDI.CurrentRow.Cells("data_registro").Value
                    cboUFDI.SelectedValue = grdDI.CurrentRow.Cells("uf_local_desembaraco").Value
                    txtLocalDI.Text = grdDI.CurrentRow.Cells("local_desembaraco").Value
                    dtpDataDesembaracoDI.Value = grdDI.CurrentRow.Cells("data_desembaraco").Value
                    btnInserirDI.Tag = grdDI.CurrentRow.Cells("codigo_di").Value
                    txtNumeroDI.Focus()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDI_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDI.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDI.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDI_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDI.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDI, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDI_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdDI.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdDI.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ADIÇÃO :::"

    Private Sub btnConfigurarGridAdicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridAdicao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdAdicao
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdAdicao, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridAdicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridAdicao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdAdicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNumeroDIAdicao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroDIAdicao.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboNumeroDIAdicao.SelectedIndex = -1 Then
                'Limpa Grid
                grdAdicao.DataSource = Nothing
            Else
                'Carrega Grid
                Call LoadGridDIAdicao()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirAdicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAdicao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoDIAdicao() = True Then

                'Salva Dados do Registro
                Call SalvarDIAdicao()
                'Limpa Formulário
                Call NovoDIAdicao()
                'Carrega Grid
                Call LoadGridDIAdicao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirAdicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAdicao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Registro
            Call ExcluirDIAdicao()
            'Limpa Formulário
            Call NovoDIAdicao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAdicao_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdAdicao.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdAdicao.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdAdicao.CurrentColumn.Key

                Case "editar"
                    txtNumeroAdicao.Text = grdAdicao.CurrentRow.Cells("numero_adicao").Value
                    cboNCMAdicao.SelectedValue = grdAdicao.CurrentRow.Cells("codigo_ncm").Value
                    txtValorFreteAdicao.Value = grdAdicao.CurrentRow.Cells("valor_frete").Value
                    txtValorSeguroAdicao.Value = grdAdicao.CurrentRow.Cells("valor_seguro").Value
                    txtValorDescontoAdicao.Value = grdAdicao.CurrentRow.Cells("valor_desconto").Value
                    txtValorOutrasDespesasAdicao.Value = grdAdicao.CurrentRow.Cells("valor_outras_despesas").Value
                    txtNumeroDrawbackAdicao.Text = grdAdicao.CurrentRow.Cells("numero_drawback").Value

                    btnInserirAdicao.Tag = grdAdicao.CurrentRow.Cells("sequencia").Value

                    txtNumeroAdicao.Focus()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAdicao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdAdicao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAdicao.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAdicao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAdicao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAdicao, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

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
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.FaturamentoEmissaoNFe)

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

    Private Sub btnEditarGridProduto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditarGridProduto.Click

        Try

            'Váriaveis Locais
            Dim sCampo(2) As String

            'Carrega Valores
            sCampo(0) = "despesa_aduaneira"
            sCampo(1) = "codigo_emissao_di"
            sCampo(2) = "codigo_fabricante"

            'Habilita Grid
            Call EditarGrid(grdProduto, _
                            sCampo, _
                            IIf(grdProduto.Tag.ToString = "E", False, True))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirItem.Click

        Try

            'Abre Formulário de Input de Item
            Call InsertProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirItem.Click

        Try

            'Exclui Item
            Call ExcluirProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()
                Case "estoque" : Call EstoqueProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_CellUpdated(ByVal sender As Object, ByVal e As ColumnActionEventArgs) Handles grdProduto.CellUpdated

        Try

            'Query
            Dim sQuery As String = ""
            Dim sTabela As String = ""

            Select Case e.Column.Key
                Case "codigo_emissao_di", "codigo_fabricante"
                    sTabela = "tb_fat_emissao_item"
                    sQuery = "WHERE (((codigo_emissao_capa) = " & oClsFatEmissaoNFe.CodigoEmissaoCapa & ") "
                    sQuery = sQuery & "AND ((codigo_empresa) = " & goUsuario.iEmpresa & ") "
                    sQuery = sQuery & "AND ((codigo) = " & grdProduto.GetValue("codigo_emissao_item") & "))"
                Case "despesa_aduaneira"
                    sTabela = "tb_fat_emissao_item_ii"
                    sQuery = "WHERE (((codigo_emissao_capa) = " & oClsFatEmissaoNFe.CodigoEmissaoCapa & ") "
                    sQuery = sQuery & "AND ((codigo_empresa) = " & goUsuario.iEmpresa & ") "
                    sQuery = sQuery & "AND ((codigo_emissao_item) = " & grdProduto.GetValue("codigo_emissao_item") & "))"
            End Select

            If IsNumeric(grdProduto.GetValue(e.Column.Key)) Then

                'Atualiza Registro Numérico
                Call ExecuteQuery("sp_update_interacti_table_field '" & sTabela & "', '" & e.Column.Key & "', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, grdProduto.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")

            Else

                'Atualiza Registro AlphaNumérico
                Call ExecuteQuery("sp_update_interacti_table_field '" & sTabela & "', '" & e.Column.Key & "', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, "'''" & grdProduto.GetValue(e.Column.Key).ToString.Replace("'", "") & "'''", "'NULL'") & ",'" & sQuery & "'")

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FCI :::"

    Private Sub btnAgruparGridFCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridFCI.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFCI.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdFCI.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdFCI.GroupByBoxVisible = True
                grdFCI.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridFCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridFCI.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFCI
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFCI, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridFCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridFCI.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdFCI)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarFCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarFCI.Click

        Try

            'Gerar FCI
            GerarFCI()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportarArquivoRetornoFCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarArquivoRetornoFCI.Click

        Try

            'Importar Arquivo de Retorno - FCI
            ImportarArquivoRetorno()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFCI_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFCI.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFCI.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFCI_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFCI.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFCI, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFCI_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdFCI.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFCI.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TRANSPORTE :::"

#Region "::: TRANSPORTADORA :::"

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

            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Foco
            cboTransportadora.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTransportadora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTransportadora.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Transportadora
            If cboTransportadora.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                cboVeiculo.DataSource = Nothing : cboVeiculo.SelectedIndex = -1 : cboVeiculo.Text = ""
                txtCNPJTransportadora.Enabled = False : txtCNPJTransportadora.Text = ""
                txtInscricaoEstadualTransportadora.Enabled = False : txtInscricaoEstadualTransportadora.Text = ""
                cboUFTransportadora.Enabled = False : cboUFTransportadora.SelectedIndex = -1
                cboMunicipioTransportadora.Enabled = False : cboMunicipioTransportadora.SelectedIndex = -1 : cboMunicipioTransportadora.Text = ""
                txtEnderecoTransportadora.Enabled = False : txtEnderecoTransportadora.Text = ""
                txtCNPJTransportadora.Tag = ""

            Else

                'Carrega Combo - Veículo
                Call LoadCombo(cboVeiculo, "sp_select_combo_cadastro_basico_transportadora_veiculo " & goUsuario.iEmpresa & ", " & cboTransportadora.SelectedValue, False)

                ''Carrega dados da Transportadora
                Call LoadDadosTransportadora(cboTransportadora.SelectedValue, _
                                             txtCNPJTransportadora, _
                                             txtInscricaoEstadualTransportadora, _
                                             cboUFTransportadora, _
                                             cboMunicipioTransportadora, _
                                             txtEnderecoTransportadora)

                'Verifica o Tipo de Personalidade
                If txtCNPJTransportadora.Tag = Personalidade.Fisica Then
                    lblCNPJTransportadora.Text = "CPF:"
                    lblInscricaoEstadualTransportadora.Text = "RG:"
                Else
                    lblCNPJTransportadora.Text = "CNPJ:"
                    lblInscricaoEstadualTransportadora.Text = "IE:"
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFTransportadora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFTransportadora.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFTransportadora.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioTransportadora.DataSource = Nothing
                cboMunicipioTransportadora.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioTransportadora, "sp_select_combo_static_municipio " & cboUFTransportadora.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: VEÍCULO :::"

    Private Sub cboTipoVeiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVeiculo.SelectedIndexChanged

        Try

            'Desabilita Controles - Veículo
            grpVeiculo.Enabled = False
            txtPlacaVeiculo.Text = ""
            cboUFVeiculo.SelectedIndex = -1
            txtRNTCVeiculo.Text = ""
            'Desabilita Controles - Reboque
            grpReboque.Enabled = False
            txtPlacaReboque.Text = ""
            cboUFReboque.SelectedIndex = -1
            txtRNTCReboque.Text = ""
            btnInserirItem.Tag = ""
            grdReboque.DataSource = Nothing
            'Desabilita Controles - Balsa / Vagão
            grpBalsaoVagao.Enabled = False
            txtBalsa.Enabled = False
            txtBalsa.Text = ""
            txtVagao.Enabled = False
            txtVagao.Text = ""

            Select Case cboTipoVeiculo.SelectedValue

                Case CInt(TipoVeiculo.VeiculoReboque)
                    grpVeiculo.Enabled = True
                    grpReboque.Enabled = True

                Case CInt(TipoVeiculo.Balsa)
                    grpBalsaoVagao.Enabled = True
                    txtBalsa.Enabled = True

                Case CInt(TipoVeiculo.Vagao)
                    grpBalsaoVagao.Enabled = True
                    txtVagao.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboVeiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVeiculo.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Veículo
            If cboVeiculo.SelectedIndex <> -1 Then

                Dim sDadosVeiculo() As String = cboVeiculo.SelectedValue.ToString.Split("|")

                'Carrega Controles
                txtPlacaVeiculo.Text = sDadosVeiculo(0)
                cboUFVeiculo.SelectedValue = sDadosVeiculo(1)
                txtRNTCVeiculo.Text = sDadosVeiculo(2)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REBOQUE :::"

    Private Sub btnConfigurarGridReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridReboque.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdReboque, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridReboque.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdReboque)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirReboque.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoReboque() = True Then

                'Salva Dados do Registro
                Call SalvarReboque()
                'Limpa Formulário
                Call NovoReboque()
                'Carrega Grid
                Call LoadGridReboque()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirReboque.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Reboque
            Call ExcluirReboque()
            'Limpa Formulário
            Call NovoReboque()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdReboque_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdReboque.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdReboque.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdReboque.CurrentColumn.Key

                Case "editar" : Call EditarReboque()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdReboque_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdReboque.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdReboque.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdReboque_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdReboque.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdReboque, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RETENÇÃO DE IMPOSTO :::"

    Private Sub CalculoICMSRetidoTransporte() Handles txtBaseCalculoTransporte.ValueChanged, _
                                                      txtAliquotaTransporte.ValueChanged

        Try

            'Váriavel - Valor
            Dim dValor As Double

            'Calcula Valor
            dValor = IIf(IsNumeric(txtBaseCalculoTransporte.Value), txtBaseCalculoTransporte.Value, 0)
            dValor = IIf(IsNumeric(txtAliquotaTransporte.Value), dValor * txtAliquotaTransporte.Value / 100, 0)

            'Seta Controle
            txtICMSRetidoTransporte.Value = dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFICMSTransporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFICMSTransporte.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFICMSTransporte.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioICMSTransporte.DataSource = Nothing
                cboMunicipioICMSTransporte.Text = ""
                cboCFOPICMSTransporte.DataSource = Nothing
                cboCFOPICMSTransporte.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioICMSTransporte, "sp_select_combo_static_municipio " & cboUFICMSTransporte.SelectedValue)
                Call LoadCombo(cboCFOPICMSTransporte, "sp_select_combo_static_cfop_transporte_retencao_icms '" & cboUFICMSTransporte.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: VOLUME :::"

    Private Sub btnAgruparGridVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridVolume.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdVolume.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdVolume.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdVolume.GroupByBoxVisible = True
                grdVolume.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridVolume.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdVolume, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridVolume.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdVolume)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirVolume.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados do Registro
            Call SalvarVolume()
            'Limpa Formulário
            Call NovoVolume()
            'Carrega Grid
            Call LoadGridVolume()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirVolume.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Reboque
            Call ExcluirVolume()
            'Limpa Formulário
            Call NovoVolume()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVolume_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdVolume.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdVolume.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdVolume.CurrentColumn.Key
                Case "editar" : Call EditarVolume()
                Case "lacre" : Call LacreVolume()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVolume_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdVolume.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVolume.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVolume_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdVolume.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVolume, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVolume_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdVolume.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdVolume.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
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

#Region "::: NOTA FISCAL ELETRÔNICA :::"

    Private Sub btnTransmitirNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitirNFe.Click

        Try

            'Valida Dados da Nota Fiscal Eletrônica
            If ValidacaoNFe() = True Then

                'Transmite NFe
                Call TransmitirLote()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSimularTransmissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimularTransmissao.Click

        Try

            'Valida Dados da Nota Fiscal Eletrônica
            If ValidacaoNFe("S") = True Then

                'Simular Transmissão
                Call SimularTransmissao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRetornarNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornarNFe.Click

        Try

            'Retorno do Lote
            Call RetornarLote()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirDANFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDANFE.Click

        Try

            'Imprime DANFE
            Call ImprimirDanfe(oClsFatEmissaoNFe.CodigoEmissaoCapa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirBoletoBancario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirBoletoBancario.Click

        Try


            'Abre Formulário de Impressão de Boleto Bancário
            Call ImprimirBoletoBancario(oClsFatEmissaoNFe.CodigoTituloFinanceiro, _
                                        cboDestinatario.Text.Trim, _
                                        txtNotaFiscal.Text.Trim)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPreVisualizarDANFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreVisualizarDANFE.Click

        Try

            'Pré Visualizar DANFE
            Call ImprimirDanfe(oClsFatEmissaoNFe.CodigoEmissaoCapa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click

        Try

            'Envia E-mail
            Call EmailNFe(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                          IIf(IsNumeric(txtStatusNFe.Tag), txtStatusNFe.Tag, -1))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExportarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXML.Click

        Try

            'Exporta Arquivo XML
            Call ExportarXML(oClsFatEmissaoNFe.CodigoEmissaoCapa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCartaCorrecao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCartaCorrecao.Click

        Try

            'Carta de Correção
            Call CartaCorrecao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabNFe_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabNFe.SelectedTabChanged

        Select Case tabNFe.SelectedTab.Name

            Case "pagNFReferenciada"
                cboTipoNotaFiscalReferenciada.SelectedIndex = 0 : cboTipoNotaFiscalReferenciada.Focus()
            Case Else
                cboModelo.Focus()

        End Select

    End Sub

#End Region

#Region ":: ARQUIVO TXT :::"

    Private Sub btnImportarTXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarTxt.Click

        Try

            'Importa Arquivo txt
            Call ImportarTXT()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub ImportarTXT()

        Try

            Dim oSaveFileDialog As New OpenFileDialog

            Dim sLinha As String
            Dim oVetor() As Object
            Dim oVetorItem() As VetorItem
            Dim oVetorParcela() As VetorParcela

            Dim iLinha01_indice As Integer
            Dim iLinha01_notaFiscal As Integer
            Dim iLinha01_serie As Integer
            Dim dLinha01_dataEmissao As Date
            Dim dLinha01_dataSaida As Date
            Dim sLinha01_naturezaOperacao As String
            Dim sLinha01_informacoesAdicionais As String
            Dim sLinha01_campo07 As String
            Dim sLinha01_tipoDocumento As String
            Dim iLinha02_indice As Integer
            Dim sLinha02_campo01 As String
            Dim sLinha02_campo02 As String
            Dim sLinha02_campo03 As String
            Dim sLinha02_campo04 As String
            Dim sLinha02_campo05 As String
            Dim sLinha02_campo06 As String
            Dim sLinha02_campo07 As String
            Dim sLinha02_campo08 As String
            Dim iLinha03_indice As Integer
            Dim sLinha03_cnpjDestinatario As String
            Dim sLinha03_nomeFantasia As String
            Dim sLinha03_razaoSocial As String
            Dim sLinha03_logradouro As String
            Dim sLinha03_numero As String
            Dim sLinha03_complemento As String
            Dim sLinha03_bairro As String
            Dim iLinha03_ibgeMunicipio As Integer
            Dim sLinha03_uf As String
            Dim sLinha03_cep As String
            Dim iLinha03_ibgePais As Integer
            Dim sLinha03_ie As String
            Dim sLinha03_campo013 As String
            Dim sLinha03_email As String
            Dim sLinha03_campo015 As String
            Dim iLinha04_indice As Integer
            Dim sLinha04_cnpjEmitente As String
            Dim sLinha04_razaoSocial As String
            Dim sLinha04_campo03 As String
            Dim sLinha04_logradouro As String
            Dim sLinha04_numero As String
            Dim sLinha04_complemento As String
            Dim sLinha04_bairro As String
            Dim sLinha04_ibgeMunicipio As String
            Dim sLinha04_uf As String
            Dim sLinha04_cep As String
            Dim iLinha04_ibgePais As Integer
            Dim sLinha04_ie As String
            Dim sLinha04_campo013 As String
            Dim iLinha04_im As Integer
            Dim iLinha04_campo015 As Integer
            Dim sLinha04_telefone As String
            Dim iLinha05_indice As Integer
            Dim sLinha05_fatura As String
            Dim fLinha05_valorBruto As Double
            Dim fLinha05_desconto As Double
            Dim fLinha05_valorLiquido As Double
            Dim iLinha05_quantidadeParcelas As Integer

            Dim iLinha07_indice As Integer
            Dim fLinha07_campo01 As Double
            Dim fLinha07_campo02 As Double
            Dim fLinha07_campo03 As Double
            Dim fLinha07_campo04 As Double
            Dim fLinha07_valorTotalProduto As Double
            Dim fLinha07_campo06 As Double
            Dim fLinha07_campo07 As Double
            Dim fLinha07_campo08 As Double
            Dim fLinha07_valorTotalNota As Double
            'Dim fLinha07_valorTotalNota As Double
            Dim iLinha08_indice As Integer
            Dim iLinha08_tipoTransporte As Integer
            Dim sLinha08_campo02 As String
            Dim sLinha08_campo03 As String
            Dim sLinha08_campo04 As String
            Dim sLinha08_campo05 As String
            Dim sLinha08_campo06 As String
            Dim sLinha08_campo07 As String
            Dim sLinha08_campo08 As String
            Dim sLinha08_campo09 As String
            Dim sLinha08_campo010 As String
            Dim sLinha08_campo011 As String
            Dim sLinha08_campo012 As String
            Dim sLinha08_campo013 As String
            Dim fLinha08_campo014 As Double
            Dim sLinha08_campo015 As String
            Dim sLinha08_campo016 As String
            Dim sLinha08_campo017 As String
            Dim fLinha08_campo018 As Double
            Dim fLinha08_campo019 As Double

            If oSaveFileDialog.ShowDialog = DialogResult.OK Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Dim oStreamReader As New System.IO.StreamReader(oSaveFileDialog.FileName)

                While oStreamReader.EndOfStream = False
                    sLinha = oStreamReader.ReadLine
                    oVetor = sLinha.Split(";")
                    If oVetor(0) = "01" Then
                        iLinha01_indice = oVetor(0)
                        iLinha01_notaFiscal = oVetor(1)
                        iLinha01_serie = oVetor(2)
                        dLinha01_dataEmissao = oVetor(3)
                        dLinha01_dataSaida = oVetor(4)
                        sLinha01_naturezaOperacao = oVetor(5)
                        sLinha01_informacoesAdicionais = oVetor(6)
                        sLinha01_campo07 = oVetor(7)
                        sLinha01_tipoDocumento = oVetor(8)
                    End If

                    If oVetor(0) = "02" Then
                        iLinha02_indice = oVetor(0)
                        sLinha02_campo01 = oVetor(1)
                        sLinha02_campo02 = oVetor(2)
                        sLinha02_campo03 = oVetor(3)
                        sLinha02_campo04 = oVetor(4)
                        sLinha02_campo05 = oVetor(5)
                        sLinha02_campo06 = oVetor(6)
                        sLinha02_campo07 = oVetor(7)
                        sLinha02_campo08 = oVetor(8)

                    End If

                    If oVetor(0) = "03" Then
                        iLinha03_indice = oVetor(0)
                        sLinha03_cnpjDestinatario = oVetor(1)
                        sLinha03_nomeFantasia = oVetor(2)
                        sLinha03_razaoSocial = oVetor(3)
                        sLinha03_logradouro = oVetor(4)
                        sLinha03_numero = oVetor(5)
                        sLinha03_complemento = oVetor(6)
                        sLinha03_bairro = oVetor(7)
                        iLinha03_ibgeMunicipio = oVetor(8)
                        sLinha03_uf = oVetor(9)
                        sLinha03_cep = oVetor(10)
                        iLinha03_ibgePais = oVetor(11)
                        sLinha03_ie = oVetor(12)
                        sLinha03_campo013 = oVetor(13)
                        sLinha03_email = oVetor(14)
                        sLinha03_campo015 = oVetor(15)
                    End If

                    If oVetor(0) = "04" Then
                        iLinha04_indice = oVetor(0)
                        sLinha04_cnpjEmitente = oVetor(1)
                        sLinha04_razaoSocial = oVetor(2)
                        sLinha04_campo03 = oVetor(3)
                        sLinha04_logradouro = oVetor(4)
                        sLinha04_numero = oVetor(5)
                        sLinha04_complemento = oVetor(6)
                        sLinha04_bairro = oVetor(7)
                        sLinha04_ibgeMunicipio = oVetor(8)
                        sLinha04_uf = oVetor(9)
                        sLinha04_cep = oVetor(10)
                        iLinha04_ibgePais = oVetor(11)
                        sLinha04_ie = oVetor(12)
                        sLinha04_campo013 = oVetor(13)
                        iLinha04_im = oVetor(14)
                        iLinha04_campo015 = oVetor(15)
                        sLinha04_telefone = oVetor(16)
                    End If

                    If oVetor(0) = "05" Then
                        iLinha05_indice = oVetor(0)
                        sLinha05_fatura = oVetor(1)
                        fLinha05_valorBruto = oVetor(2)
                        fLinha05_desconto = oVetor(3)
                        fLinha05_valorLiquido = oVetor(4)
                        iLinha05_quantidadeParcelas = oVetor(5)

                        'Parcelas 
                        For iParcela As Integer = 0 To iLinha05_quantidadeParcelas - 1

                            If oVetorParcela Is Nothing Then
                                ReDim oVetorParcela(0)
                            Else
                                ReDim Preserve oVetorParcela(oVetorParcela.Count)
                            End If

                            oVetorParcela(iParcela).NumeroDuplicata = oVetor(6 + (iParcela * 3))
                            oVetorParcela(iParcela).DataVencimento = oVetor(7 + (iParcela * 3))
                            oVetorParcela(iParcela).Valor = oVetor(8 + (iParcela * 3))

                        Next

                    End If

                    If oVetor(0) = "06" Then
                        If oVetorItem Is Nothing Then
                            ReDim oVetorItem(0)
                        Else
                            ReDim Preserve oVetorItem(oVetorItem.Count)
                        End If

                        oVetorItem(oVetorItem.Count - 1).indice = oVetor(0)
                        oVetorItem(oVetorItem.Count - 1).numeroItem = oVetor(1)
                        oVetorItem(oVetorItem.Count - 1).codigoProduto = oVetor(2).ToString.Trim
                        oVetorItem(oVetorItem.Count - 1).descricao = oVetor(3).ToString.Trim
                        oVetorItem(oVetorItem.Count - 1).cfop = oVetor(4)
                        oVetorItem(oVetorItem.Count - 1).ncm = oVetor(5)
                        oVetorItem(oVetorItem.Count - 1).quantidade = oVetor(6)
                        oVetorItem(oVetorItem.Count - 1).unidadeMedida = oVetor(7)
                        oVetorItem(oVetorItem.Count - 1).valorUnitario = oVetor(8)
                        oVetorItem(oVetorItem.Count - 1).valorTotal = oVetor(9)
                        oVetorItem(oVetorItem.Count - 1).valorDesconto = oVetor(10)
                        oVetorItem(oVetorItem.Count - 1).valorFrete = oVetor(11)
                        oVetorItem(oVetorItem.Count - 1).valorSeguro = oVetor(12)
                        oVetorItem(oVetorItem.Count - 1).valorDespesa = oVetor(13)
                        oVetorItem(oVetorItem.Count - 1).origem = 0
                        oVetorItem(oVetorItem.Count - 1).tributacaoICMS = oVetor(14)
                        oVetorItem(oVetorItem.Count - 1).Campo16 = oVetor(16)
                        oVetorItem(oVetorItem.Count - 1).Campo17 = oVetor(17)
                        oVetorItem(oVetorItem.Count - 1).Campo18 = oVetor(18)
                        oVetorItem(oVetorItem.Count - 1).Campo19 = oVetor(19)
                        oVetorItem(oVetorItem.Count - 1).Campo20 = oVetor(20)
                        oVetorItem(oVetorItem.Count - 1).Campo21 = oVetor(21)
                        oVetorItem(oVetorItem.Count - 1).Campo22 = oVetor(22)
                        oVetorItem(oVetorItem.Count - 1).Campo23 = oVetor(23)
                        oVetorItem(oVetorItem.Count - 1).Campo24 = oVetor(24)
                        oVetorItem(oVetorItem.Count - 1).Campo25 = oVetor(25)
                        oVetorItem(oVetorItem.Count - 1).Campo26 = oVetor(26)
                        oVetorItem(oVetorItem.Count - 1).Campo27 = oVetor(27)
                        oVetorItem(oVetorItem.Count - 1).Campo28 = oVetor(28)
                        oVetorItem(oVetorItem.Count - 1).Campo29 = oVetor(29)
                        oVetorItem(oVetorItem.Count - 1).Campo30 = oVetor(30)
                        oVetorItem(oVetorItem.Count - 1).Campo31 = oVetor(31)
                        oVetorItem(oVetorItem.Count - 1).Campo32 = oVetor(32)
                        oVetorItem(oVetorItem.Count - 1).Campo33 = oVetor(33)
                    End If

                    If oVetor(0) = "07" Then
                        iLinha07_indice = oVetor(1)
                        fLinha07_campo01 = oVetor(2)
                        fLinha07_campo02 = oVetor(3)
                        fLinha07_campo03 = oVetor(4)
                        fLinha07_campo04 = oVetor(5)
                        fLinha07_valorTotalProduto = oVetor(6)
                        fLinha07_campo06 = oVetor(7)
                        fLinha07_campo07 = oVetor(8)
                        fLinha07_campo08 = oVetor(9)
                        fLinha07_valorTotalNota = oVetor(10)

                    End If

                    If oVetor(0) = "08" Then
                        iLinha08_indice = oVetor(0)
                        iLinha08_tipoTransporte = oVetor(1)
                        sLinha08_campo02 = oVetor(2)
                        sLinha08_campo03 = oVetor(3)
                        sLinha08_campo04 = oVetor(4)
                        sLinha08_campo05 = oVetor(5)
                        sLinha08_campo06 = oVetor(6)
                        sLinha08_campo07 = oVetor(7)
                        sLinha08_campo08 = oVetor(8)
                        sLinha08_campo09 = oVetor(9)
                        sLinha08_campo010 = oVetor(10)
                        sLinha08_campo011 = oVetor(11)
                        sLinha08_campo012 = oVetor(12)
                        sLinha08_campo013 = oVetor(13)
                        fLinha08_campo014 = oVetor(14)
                        sLinha08_campo015 = oVetor(15)
                        sLinha08_campo016 = oVetor(16)
                        sLinha08_campo017 = oVetor(17)
                        fLinha08_campo018 = oVetor(18)
                        fLinha08_campo019 = oVetor(19)

                    End If

                End While
                oStreamReader.Close()

                'Agora insere os dados

                'Dados da Capa
                oClsFatEmissaoNFe.InsertLinha1(iLinha01_notaFiscal, _
                                               iLinha01_serie, _
                                               dLinha01_dataEmissao, _
                                               dLinha01_dataSaida, _
                                               sLinha01_naturezaOperacao, _
                                               sLinha01_informacoesAdicionais, _
                                               sLinha01_campo07, _
                                               sLinha01_tipoDocumento)

                'NF Referenciada - Não utilizar
                'oClsFatEmissaoNFe.InsertLinha2(sLinha)

                'Destinatário
                oClsFatEmissaoNFe.InsertLinha3(sLinha03_cnpjDestinatario, _
                                               sLinha03_razaoSocial, _
                                               sLinha03_razaoSocial, _
                                               sLinha03_logradouro, _
                                               sLinha03_numero, _
                                               sLinha03_complemento, _
                                               sLinha03_bairro, _
                                               iLinha03_ibgeMunicipio, _
                                               sLinha03_uf, _
                                               sLinha03_cep, _
                                               "1058", _
                                               sLinha03_ie, _
                                               sLinha03_campo013, _
                                               sLinha03_email, _
                                               sLinha03_campo015)

                'Dados do emitente
                oClsFatEmissaoNFe.InsertLinha4()

                'Dados da fatura
                oClsFatEmissaoNFe.InsertLinha5(sLinha05_fatura, _
                                               fLinha05_valorBruto, _
                                               fLinha05_desconto, _
                                               fLinha05_valorLiquido, _
                                               iLinha05_quantidadeParcelas)

                'Duplicatas
                If IsNothing(oVetorParcela) = False Then
                    For iParcela As Integer = 0 To oVetorParcela.Count - 1
                        oClsFatEmissaoNFe.InsertLinha5_Duplicata(oVetorParcela(iParcela).NumeroDuplicata, _
                                                                 oVetorParcela(iParcela).DataVencimento, _
                                                                 oVetorParcela(iParcela).Valor)
                    Next
                End If

                'insere os produtos
                For iProduto As Integer = 0 To oVetorItem.Count - 1

                    With oVetorItem(iProduto)

                        oClsFatEmissaoNFe.InsertLinha6(.codigoProduto, _
                                                       .descricao, _
                                                       .cfop, _
                                                       .ncm, _
                                                       .quantidade, _
                                                       .unidadeMedida, _
                                                       .valorUnitario, _
                                                       .valorTotal, _
                                                       .valorDesconto, _
                                                       .valorFrete, _
                                                       .valorSeguro, _
                                                       .valorDespesa, _
                                                       .origem, _
                                                       .tributacaoICMS)

                    End With

                Next

                oClsFatEmissaoNFe.InsertLinha7()

                oClsFatEmissaoNFe.InsertLinha8(iLinha08_tipoTransporte)

                'Carrega Combo  - Destinatário
                Call LoadCombo(cboDestinatario, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)

                'Carrega Dados da NFe
                EditarNotaFiscal(oClsFatEmissaoNFe.CodigoEmissaoCapa)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO XML :::"

    Private Sub ImportarArquivoXML()

        Try

            'Variaveis Locais
            Dim oArquivoXML As New OpenFileDialog
            Dim sReturn As String

            'Abre PopUp para Usuário selecionar a NFe
            'oArquivoXML.InitialDirectory = "c:\\dados"
            oArquivoXML.Filter = "(Arquivo NFe XML)|*.XML"
            oArquivoXML.Title = "Selecione o Arquivo"

            ' Verifica se foi encontrado o Arquivo
            If oArquivoXML.ShowDialog() = DialogResult.OK Then

                'Insere Registo
                oClsFatEmissaoNFe.InsertNotaFiscal()


                'Carrega Arquivo XML
                Dim sArquivoXML As String = File.ReadAllText(oArquivoXML.FileName)

                'Importa Arquivo XML
                oClsFatEmissaoNFe.ImportarXMLEmissao(sArquivoXML, _
                                                       oArquivoXML.FileName, _
                                                       sReturn)


                'Verifica se ocorreu um Erro na Importação do Arquivo XML
                If sReturn <> "" Then
                    frmMain.Informacao(Mensagem.Erro, sReturn)
                Else

                    'Carrega Dados da Empresa
                    Call LoadDadosEmitente()

                    ' Abre Formulário de Correlação de Item
                    Dim oForm As New frmFatEmissaoNFeImportacaoNFProdutoXML

                    'Seta Parâmetros
                    oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa

                    'Abre o Formuláriio
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    ' Exclui Xml
                    'oClsFatEntradaNF.DeleteXML()

                    If oForm.Resultado = "S" Then

                        'Executa a Integração
                        Call Integracao()

                        'Carrega ComboBox
                        Call LoadCombo(cboDestinatario, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
                        Call LoadCombo(cboPaisDestinatario, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
                        Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)



                        'Edita Nota Fiscal
                        Call EditarNotaFiscal(oClsFatEmissaoNFe.CodigoEmissaoCapa)



                        'Seta Aba
                        tabDados.SelectedTab = pagDadosNFe




                    End If

                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            oClsFatEmissaoNFe.LoadGridExportar(grdListagem, _
                                               grdExportar)

            ExportExcel(grdExportar)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub
    Private Sub btnImportarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarXML.Click
        Try
            Call ImportarArquivoXML()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImportarBoleta_Click(sender As Object, e As EventArgs) Handles btnImportarBoleta.Click
        Try
            Call ImportarBoleta()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub ImportarBoleta()
        Try
            Dim AbrirComo As OpenFileDialog = New OpenFileDialog()
            Dim Caminho As DialogResult
            Dim FluxoTexto As IO.StreamReader
            Dim sArquivo As String = ""
            Dim LinhaTexto As String
            Dim Texto As String
            Dim NomeArquivo As String = ""
            Dim oArquivoExcel As New OpenFileDialog
            Dim iCodigo As Integer = 0

            Dim sCliente As String = ""
            Dim sNumeroTicket As String = ""
            Dim sProduto As String = ""
            Dim sQuantidade As String = ""
            Dim sUnidadeMedida As String = ""
            Dim sValorUnitario As String = ""
            Dim sValorTotal As String = ""

            AbrirComo.Title = "Abrir como"
            AbrirComo.FileName = "Nome Arquivo"
            AbrirComo.Filter = "Arquivos Textos (*.txt)|*.txt"
            Caminho = AbrirComo.ShowDialog
            sArquivo = AbrirComo.FileName

            If sArquivo = "" Or sArquivo Is Nothing Then
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            Else

                'cria um novo objeto StreamReader
                Dim objReader As New StreamReader(sArquivo, System.Text.Encoding.Default)

                Dim iLinha As Integer = 0
                Dim bFlag As Boolean = False

                'percorre o arquivo
                Do While objReader.Peek() <> -1
                    LinhaTexto = objReader.ReadLine()
                    iLinha += 1

                    If iLinha = 1 Or iLinha = 2 Then Continue Do

                    If ((LinhaTexto.Substring(3, 3).Trim).Contains("---")) Then
                        If iLinha <> 6 Then
                            Exit Do
                        Else

                            Continue Do
                        End If

                    End If



                    If iLinha = 3 Then
                        Try
                            sCliente = LinhaTexto.Substring(11, 21)
                        Catch ex As Exception

                        End Try
                    End If

                    If iLinha = 4 Then

                        sNumeroTicket = LinhaTexto.Substring(50, 8)

                        oClsFatEmissaoNFe.InsertBoleta(sCliente, sNumeroTicket)
                    End If

                    If iLinha >= 7 Then

                        sProduto = LinhaTexto.Substring(2, 19)
                        sQuantidade = LinhaTexto.Substring(25, 9)
                        sUnidadeMedida = LinhaTexto.Substring(35, 2)
                        sValorUnitario = LinhaTexto.Substring(37, 12)
                        sValorTotal = LinhaTexto.Substring(48, 10)

                        oClsFatEmissaoNFe.InsertBoletaItem(oClsFatEmissaoNFe.CodigoBoleta, _
                                                            sProduto, _
                                                            sQuantidade, _
                                                            sUnidadeMedida, _
                                                            sValorUnitario, _
                                                            sValorTotal)
                    End If

                Loop
            End If



            'Carrega Dados da Empresa
            Call LoadDadosEmitente()

            ' Abre Formulário de Correlação de Item
            Dim oForm As New frmFatEmissaoNFeImportacaoBoleta

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.lCodigoBoleta = oClsFatEmissaoNFe.CodigoBoleta
            oForm.iCodigoCliente = IIf(cboDestinatario.SelectedIndex = -1, -1, cboDestinatario.SelectedValue)
            oForm.sNumeroTicket = sNumeroTicket

            'Abre o Formuláriio
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'oClsFatEmissaoNFe.CodigoEmissaoCapa = IIf(IsNumeric(cboSerie.Tag), cboSerie.Tag, -1)
            oClsFatEmissaoNFe.ModeloNotaFiscal = 55
            oClsFatEmissaoNFe.SequenciaNotaFiscal = 1
            oClsFatEmissaoNFe.Serie = 1
            oClsFatEmissaoNFe.DataEmissao = Now.Date
            oClsFatEmissaoNFe.NaturezaOperacao = "COMPRA"
            oClsFatEmissaoNFe.DataSaida = Now.Date
            oClsFatEmissaoNFe.TipoItem = TipoItem.produto
            oClsFatEmissaoNFe.CodigoFormaEmissaoNFe = 1
            oClsFatEmissaoNFe.CodigoTipoOperacaoNFe = 1
            oClsFatEmissaoNFe.CodigoTipoConsumidor = 1
            oClsFatEmissaoNFe.CodigoFinalidadeEmissaoNFe = 1
            oClsFatEmissaoNFe.CodigoTipoDocumentoFiscal = 0
            oClsFatEmissaoNFe.CodigoFormaPagamento = 1
            oClsFatEmissaoNFe.NotaFiscal = -1

            'Verifica o Tipo de Operação
            oClsFatEmissaoNFe.UpdateNotaFiscal()

            'Carrega dados da Nota Fiscal
            Call EditarNotaFiscal(oClsFatEmissaoNFe.CodigoEmissaoCapa)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnImportarExcelRemessa_Click(sender As Object, e As EventArgs) Handles btnImportarExcelRemessa.Click

        Try

            ImportarExcelRemessa()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEmissaoNFe_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
            btnInserirItem.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
            btnExcluirItem.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
            btnImprimir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint)
            btnExcelGridFCI.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFeFCI, gcPrint)
            btnExcelGridProduto.Enabled = btnExcelGrid.Enabled
            btnExcelGridDI.Enabled = btnExcelGrid.Enabled
            btnExcelGridAdicao.Enabled = btnExcelGrid.Enabled
            btnExcelGridNFReferenciada.Enabled = btnExcelGrid.Enabled
            btnEditarGridProduto.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcUpdate)

            'Verifica Direito - Cadastros Básicos
            btnCadastrarNaturezaOperacao.Enabled = VerificaDireito(Formulario.CadastroBasicoNaturezaOperacao, gcInsert)
            btnCadastrarDestinatario.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarPaisDestinatario.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarTransportadora.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarDadosAdicionais.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)

            'Carrega Combo - Filtro
            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nota_fiscal " & CInt(TipoNotaFiscal.NotaFiscalEletronica))
            Call LoadCombo(cboTipoDocumentoFiltro, "sp_select_combo_static_tipo_documento_faturado")
            Call LoadCombo(cboNaturezaOperacaoFiltro, "sp_select_combo_cadastro_basico_natureza_operacao_faturamento " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoDocumenoFiscalFiltro, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)
            Call LoadCombo(cboDestinatario, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)

            'Carrega Combo - Dados NFe
            Call LoadCombo(cboModelo, "sp_select_combo_static_modelo_nota_fiscal " & CInt(TipoItem.produto))
            Call LoadCombo(cboNaturezaOperacao, "sp_select_combo_cadastro_basico_natureza_operacao " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoDocumento, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)
            Call LoadCombo(cboFormaEmissao, "sp_select_combo_static_forma_emissao_nfe")
            Call LoadCombo(cboFinalidadeEmissao, "sp_select_combo_static_finalidade_emissao_nfe")
            Call LoadCombo(cboTipoOperacao, "sp_select_combo_static_tipo_operacao_nfe")
            Call LoadCombo(cboTipoConsumidor, "sp_select_combo_static_tipo_consumidor")

            'Carrega Combo - Nota Fiscal Referenciadas
            Call LoadCombo(cboTipoNotaFiscalReferenciada, "sp_select_combo_static_tipo_nota_fiscal")
            Call LoadCombo(cboUFNFReferenciada, "sp_select_combo_static_estado")

            'Carrega Combo - Destinatário
            Call LoadCombo(cboPaisDestinatario, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)

            'Carrega Combo - DI
            Call LoadCombo(cboUFDI, "sp_select_combo_static_estado", False)
            Call LoadCombo(cboNCMAdicao, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa, False)

            'Carrega Combo - Transporte
            Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete", False)
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Dim oComboBox(3) As UIComboBox
            oComboBox(0) = cboUFTransportadora : oComboBox(1) = cboUFVeiculo : oComboBox(2) = cboUFReboque : oComboBox(3) = cboUFICMSTransporte
            Call LoadCombo(oComboBox, "sp_select_combo_static_estado", False)
            Call LoadCombo(cboTipoVeiculo, "sp_select_combo_static_tipo_veiculo", False)

            'Carrega Combo - Cobrança
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento_nfe", False)
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)

            'Carrega Combo - Dados Adicionais
            LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais))

            'Carrega Combo - Exportação e Compras
            Call LoadCombo(cboUFEmbarque, "sp_select_combo_static_estado", False)

            'Seta Controles
            cboModelo.SelectedValue = CInt(ModeloNotaFiscal.Modelo55)
            cboFormaEmissao.SelectedValue = CInt(FormaEmissaoNFe.Normal)
            cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal)
            btnImportarPedidoVenda.Enabled = False
            btnDevolucaoNotaFiscalEmitida.Enabled = False
            btnDevolucaoNotaFiscal.Enabled = False
            btnRemessa.Enabled = False
            btnImportarPedidoCompra.Enabled = False
            btnDevolucaoNotaFiscal.Enabled = False
            dtpDataEmissao.Value = Now
            dtpDataSaida.Value = Now : dtpDataSaida.Checked = False

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Configuração da NF-e
            Call LoadConfiguracaoNFe()

            'Seta Ambiente - NFe
            Select Case goConfiguracaoNFe.iCodigoTipoAmbienteNFe
                Case TipoAmbienteNFe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                Case TipoAmbienteNFe.producao : lblAmbiente.Text = "** Ambiente de Produção"
            End Select

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoEstadualSTEmitente.Text = goEmitente.sInscricaoEstadualST
            lblValorRegimeTributarioEmitente.Text = goEmitente.sRegimeTributario
            lblValorRazaoSocialEmitente.Text = goEmitente.sRazaoSocial
            lblValorNomeFantasiaEmitente.Text = goEmitente.sNomeFantasia
            lblValorLogradouroEmitente.Text = goEmitente.sLogradouro
            lblValorNumeroEmitente.Text = goEmitente.sNumero
            lblValorComplementoEmitente.Text = goEmitente.sComplemento
            lblValorBairroEmitente.Text = goEmitente.sBairro
            lblValorMunicipioEmitente.Text = goEmitente.sMunicipio
            lblValorUFEmitente.Text = goEmitente.sUF
            lblValorCEPEmiente.Text = goEmitente.sCEP
            lblValorPaisEmitente.Text = goEmitente.sPais

            If lCodigoEmissaoCapa = 0 Then
                'Remove Aba
                tabMain.TabPages.Remove(pagDados)
                'Seta Focu
                txtNotaFiscalFiltro.Focus()
            Else
                Call EditarNotaFiscal(lCodigoEmissaoCapa)
            End If

            'Seta Controles
            dtpDataEmissaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataEmissaoInicioFiltro.Checked = True
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False

            'Habilita Controle
            btnSimularTransmissao.Visible = IIf(goUsuario.sUsuario = "ACTI", True, False)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            btnImportarExcelRemessa.Visible = True

            btnExportar.Visible = False

            'ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFe)
            'ConfiguraGrid(grdNFReferenciada, Formulario.FaturamentoEmissaoNFe)
            'ConfiguraGrid(grdProduto, Formulario.FaturamentoEmissaoNFe)
            'ConfiguraGrid(grdDI, Formulario.FaturamentoEmissaoNFe)
            'ConfiguraGrid(grdAdicao, Formulario.FaturamentoEmissaoNFe)
            'ConfiguraGrid(grdVolume, Formulario.FaturamentoEmissaoNFe)
            'ConfiguraGrid(grdReboque, Formulario.FaturamentoEmissaoNFe)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

    Private Sub RelatorioEntrega(ByVal lCodigoEmissaoCapa As Long)
        Try
            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)

            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
            goCrystalReport.sReportParameter(0).sValue = lCodigoEmissaoCapa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000003_ENTREGA.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill


            frmMain.LoadPageReport("FAT000000003_Entrega", "Relatório de Entrega", oReport)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sCFOP As String = ""
            Dim sStatus As String = ""
            Dim sTipoDocumentoFaturado As String = ""
            Dim sNaturezaOperacao As String = ""
            Dim i As Integer

            'CFOP
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOP &= IIf(sCFOP = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Tipo de Documento
            If cboTipoDocumentoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboTipoDocumentoFiltro.CheckedValues)
                    sTipoDocumentoFaturado &= IIf(sTipoDocumentoFaturado = "", "", ",") & cboTipoDocumentoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Natureza da Operação
            If cboNaturezaOperacaoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboNaturezaOperacaoFiltro.CheckedValues)
                    sNaturezaOperacao &= IIf(sNaturezaOperacao = "", "", ",") & cboNaturezaOperacaoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            oClsFatEmissaoNFe.LoadGrid(grdListagem, _
                                       IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                       IIf(IsNumeric(txtSerieFiltro.Text.Trim), txtSerieFiltro.Text.Trim, ""), _
                                       txtDestinatarioFiltro.Text.Trim, _
                                       IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                       IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                       txtProdutoFiltro.Text.Trim, _
                                       txtLoteFiltro.Text.Trim, _
                                       IIf(cboTipoDocumenoFiscalFiltro.SelectedIndex = -1, -1, cboTipoDocumenoFiscalFiltro.SelectedValue), _
                                       sCFOP, _
                                       sStatus, _
                                       sTipoDocumentoFaturado, _
                                       sNaturezaOperacao, _
                                       txtNumeroDocumentoFiltro.Text.Trim, _
                                       IIf(IsNumeric(txtNFReferenciadaFiltro.Text.Trim), txtNFReferenciadaFiltro.Text, -1))

            'Seta Cursor
            If grdListagem.GetDataRows.Count > 0 Then grdListagem.Row = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Oculta tabDados
            tabDados.Visible = False

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoEstadualSTEmitente.Text = goEmitente.sInscricaoEstadualST
            lblValorRegimeTributarioEmitente.Text = goEmitente.sRegimeTributario
            lblValorRazaoSocialEmitente.Text = goEmitente.sRazaoSocial
            lblValorNomeFantasiaEmitente.Text = goEmitente.sNomeFantasia
            lblValorLogradouroEmitente.Text = goEmitente.sLogradouro
            lblValorNumeroEmitente.Text = goEmitente.sNumero
            lblValorComplementoEmitente.Text = goEmitente.sComplemento
            lblValorBairroEmitente.Text = goEmitente.sBairro
            lblValorMunicipioEmitente.Text = goEmitente.sMunicipio
            lblValorUFEmitente.Text = goEmitente.sUF
            lblValorCEPEmiente.Text = goEmitente.sCEP
            lblValorPaisEmitente.Text = goEmitente.sPais

            'Insere Capa
            oClsFatEmissaoNFe.InsertNotaFiscal()

            'Limpa Controles - Dados da NFe
            cboModelo.SelectedValue = CInt(ModeloNotaFiscal.Modelo55)
            'cboSerie.SelectedIndex = -1
            cboSerie.Tag = oClsFatEmissaoNFe.CodigoEmissaoCapa
            txtNotaFiscal.Text = ""
            dtpDataEmissao.Value = Now
            cboNaturezaOperacao.SelectedIndex = -1
            cboTipoDocumento.SelectedIndex = -1
            dtpDataSaida.Value = Now : dtpDataSaida.Checked = False
            cboFormaEmissao.SelectedValue = CInt(FormaEmissaoNFe.Normal)
            cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal)
            cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNFe.OperacaoPresencial)
            If goEmitente.sNomeFantasia = "CAR CARE AUTOSHOP" Then
                cboTipoConsumidor.SelectedValue = CInt(TipoConsumidor.ConsumidorFinal)
            Else
                cboTipoConsumidor.SelectedValue = CInt(TipoConsumidor.Normal)
            End If


            'Limpa Controles - Item
            grdProduto.DataSource = Nothing

            'Limpa Grid - NF Referenciada
            cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal)
            cboUFNFReferenciada.SelectedIndex = -1
            txtCNPJNFReferenciada.Text = ""
            txtSerieNFReferenciada.Text = ""
            txtNotaFiscalNFReferenciada.Text = ""
            dtpDataEmissaoNFReferenciada.Value = Now.Date
            cboNotaFiscalChaveAcessoNFReferenciada.SelectedIndex = -1
            btnInserirNFReferenciada.Tag = ""
            grdNFReferenciada.DataSource = Nothing

            'Limpa Controles - Destinatário
            cboDestinatario.SelectedIndex = -1
            chkLocalRetirada.Checked = False
            chkLocalEntrega.Checked = False
            btnEnderecoLocalRetirada.Visible = False
            btnEnderecoLocalEntrega.Visible = False
            txtIdentificacao.Text = ""

            'Limpa Controles - DI
            txtNumeroDI.Text = ""
            dtpDataRegistroDI.Value = Now.Date
            txtCodigoExportador.Text = ""
            cboUFDI.SelectedIndex = -1
            txtLocalDI.Text = ""
            dtpDataDesembaracoDI.Value = Now.Date
            btnInserirDI.Tag = ""
            grdDI.DataSource = Nothing

            'Limpa Controles - DI Adição
            cboNumeroDIAdicao.DataSource = Nothing
            cboNumeroDIAdicao.Text = ""
            txtNumeroAdicao.Text = ""
            cboNCMAdicao.SelectedIndex = -1
            txtValorSeguroAdicao.Value = 0
            txtValorFreteAdicao.Value = 0
            txtValorDescontoAdicao.Value = 0
            txtValorOutrasDespesasAdicao.Value = 0

            btnInserirAdicao.Tag = ""
            txtNumeroDrawbackAdicao.Text = ""
            grdAdicao.DataSource = Nothing

            'Limpa Controles - Transportador
            cboModalidadeFrete.SelectedIndex = -1
            cboTransportadora.SelectedIndex = -1
            txtCNPJTransportadora.Text = ""
            txtInscricaoEstadualTransportadora.Text = ""
            cboUFTransportadora.SelectedIndex = -1
            cboMunicipioTransportadora.SelectedIndex = -1
            txtEnderecoTransportadora.Text = ""
            tabTransporte.SelectedTab = pagTransportador

            'Limpa Controles - Transporte - Retenção do ICMS
            txtBaseCalculoTransporte.Value = 0
            txtAliquotaTransporte.Value = 0
            txtValorServicoTransporte.Value = 0
            cboUFICMSTransporte.SelectedIndex = -1
            cboMunicipioTransportadora.SelectedIndex = -1
            cboCFOPICMSTransporte.SelectedIndex = -1
            txtICMSRetidoTransporte.Value = 0

            'Limpa Controles - Transporte - Veículo / Reboque / Balsa / Vagão
            cboTipoVeiculo.SelectedIndex = -1
            txtPlacaVeiculo.Text = ""
            cboUFVeiculo.SelectedIndex = -1
            txtRNTCVeiculo.Text = ""
            txtPlacaReboque.Text = ""
            cboUFReboque.SelectedIndex = -1
            txtRNTCReboque.Text = ""
            btnInserirReboque.Tag = ""
            grdReboque.DataSource = Nothing
            txtBalsa.Text = ""
            txtVagao.Text = ""
            Call cboTipoVeiculo_SelectedIndexChanged(cboTipoVeiculo, System.EventArgs.Empty)

            'Limpa Controles - Transporte - Volume
            txtQuantidadeEmbalagemTransportadora.Value = 0
            txtEspecieTransportadora.Text = ""
            txtMarcaTransportadora.Text = ""
            txtNumeroTransportadora.Text = ""
            txtPesoLiquidoTransportadora.Value = 0
            txtPesoBrutoTransportadora.Value = 0
            btnInserirVolume.Tag = ""
            grdVolume.DataSource = Nothing

            'Limpa Controles - Totais - ICMS
            txtBaseCalculoICMS.Value = 0
            txtTotalICMS.Value = 0
            txtBaseCalculoICMSST.Value = 0
            txtTotalICMSST.Value = 0
            txtTotalProdutoServico.Value = 0
            txtTotalFrete.Value = 0
            txtTotalSeguro.Value = 0
            txtTotalDesconto.Value = 0
            txtTotalII.Value = 0
            txtTotalIPI.Value = 0
            txtTotalPIS.Value = 0
            txtTotalCOFINS.Value = 0
            txtOutrasDespesas.Value = 0

            txtTotalNotaFiscal.Value = 0
            txtTotalFCP.Value = 0
            txtTotalICMSDestino.Value = 0
            txtTotalICMSRemetente.Value = 0

            'Limpa Controles - Cobrança
            txtFatura.Text = ""
            txtValorOriginal.Value = 0
            txtValorDesconto.Value = 0
            txtValorLiquido.Value = 0
            cboFormaPagamento.SelectedIndex = -1
            txtNumeroParcela.Value = 0
            txtIntervaloEntreParcelas.Value = 0
            cboCondicaoPagamento.Text = ""
            Call ClearUnboundGrid(grdDuplicata)

            'Limpa Controles - Informações Adicionais
            cboDadosAdicionaisPreCadastrado.SelectedIndex = -1
            txtDadosAdicionais.Text = ""
            txtDadosAdicionaisFISCO.Text = ""

            'Limpa Controles - Exportação / Compras
            cboUFEmbarque.SelectedIndex = -1
            txtLocalEmbarque.Text = ""
            txtNotaEmpenho.Text = ""
            txtInformacaoContrato.Text = ""
            txtInformacaoPedido.Text = ""
            txtNumeroDrawbackExportacao.Text = ""
            txtQuantidadeExportacao.Value = 0
            txtChaveAcessoExportacao.Text = ""
            txtNumeroRE.Text = ""

            'Limpa Controles - Nota Fiscal Eletrônica
            txtStatusNFe.Text = ""
            txtStatusNFe.Tag = StatusNotaFiscalEletronica.AguardandoTransmissao
            txtMensagemSefaz.Text = ""
            txtChaveAcesso.Text = ""
            txtRecibo.Text = ""
            txtLote.Text = ""
            txtProtocolo.Text = ""

            'Seta Focu Aba  
            tabDados.SelectedTab = pagDadosNFe
            tabNFe.SelectedTab = pagDadosCapa
            'Oculta Abas
            tabDados.TabPages.Remove(pagDestinatario)
            tabDados.TabPages.Remove(pagDIAdicao)
            tabDados.TabPages.Remove(pagProduto)
            tabDados.TabPages.Remove(pagFCI)
            tabDados.TabPages.Remove(pagTransporte)
            tabDados.TabPages.Remove(pagTotais)
            tabDados.TabPages.Remove(pagCobranca)
            tabDados.TabPages.Remove(pagInformacoesAdicionais)
            tabDados.TabPages.Remove(pagExportacaoCompras)
            tabDados.TabPages.Remove(pagNFe)

            'Seta Controles
            VerificaStatus(StatusNotaFiscalEletronica.AguardandoTransmissao)

            'Carrega Combo
            Call LoadCombo(cboDestinatario, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            Call LoadCombo(cboNaturezaOperacao, "sp_select_combo_cadastro_basico_natureza_operacao " & goUsuario.iEmpresa)
            Call LoadCombo(cboNCMAdicao, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Dim oComboBox(3) As UIComboBox
            oComboBox(0) = cboUFTransportadora : oComboBox(1) = cboUFVeiculo : oComboBox(2) = cboUFReboque : oComboBox(3) = cboUFICMSTransporte
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais))

            'Desabilita Controles
            btnInserirItem.Visible = False
            btnExcluirItem.Visible = False

            'Oculta tabDados
            tabDados.Visible = True

            'Seta Focu
            cboModelo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ambiente - NFe
            Select Case goConfiguracaoNFe.iCodigoTipoAmbienteNFe
                Case TipoAmbienteNFe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                Case TipoAmbienteNFe.producao : lblAmbiente.Text = "** Ambiente de Produção"
                Case Else : lblAmbiente.Text = "** Não Configurado"
            End Select

            'Atualiza Dados do Item
            If cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                Call oClsFatEmissaoNFe.AtualizaDadosProduto(txtTotalFrete.Value, _
                                                            txtTotalSeguro.Value, _
                                                            txtOutrasDespesas.Value)
            End If

            'Insere Dados da Capa
            Call SalvarCapa()
            'Insere Dados do Emitente
            Call SalvarEmitente()
            'Insere Dados do Destinatário
            Call SalvarDestinatario()
            'Insere Dados do Transporte
            Call SalvarTransporte()
            'Insere Dados do Total
            Call SalvarTotal()
            'Insere Dados da Informações Adicionais
            Call SalvarInformacoesAdicionais()
            'Insere Dados da Fatura
            Call SalvarFatura()
            If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then
                'Insere Dados Financeiro
                Call SalvarFinanceiro()
                'Insere Dados da Exportação
                Call SalvarExportacao()
                'Insere Dados de Compras
                Call SalvarCompras()
            End If

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarCapa()

        Try

            'Seta Parametros - Capa
            oClsFatEmissaoNFe.CodigoEmissaoCapa = IIf(IsNumeric(cboSerie.Tag), cboSerie.Tag, -1)
            oClsFatEmissaoNFe.ModeloNotaFiscal = cboModelo.SelectedValue
            oClsFatEmissaoNFe.SequenciaNotaFiscal = cboSerie.SelectedValue
            oClsFatEmissaoNFe.Serie = cboSerie.Text
            oClsFatEmissaoNFe.DataEmissao = dtpDataEmissao.Value
            oClsFatEmissaoNFe.NaturezaOperacao = cboNaturezaOperacao.Text
            oClsFatEmissaoNFe.DataSaida = IIf(dtpDataSaida.Checked = True, dtpDataSaida.Value, "")
            oClsFatEmissaoNFe.TipoItem = TipoItem.produto
            oClsFatEmissaoNFe.CodigoFormaEmissaoNFe = cboFormaEmissao.SelectedValue
            oClsFatEmissaoNFe.CodigoTipoOperacaoNFe = cboTipoOperacao.SelectedValue
            oClsFatEmissaoNFe.CodigoTipoConsumidor = cboTipoConsumidor.SelectedValue
            oClsFatEmissaoNFe.CodigoFinalidadeEmissaoNFe = cboFinalidadeEmissao.SelectedValue
            oClsFatEmissaoNFe.CodigoTipoDocumentoFiscal = cboTipoDocumento.SelectedValue
            oClsFatEmissaoNFe.CodigoFormaPagamento = cboFormaPagamento.SelectedValue
            oClsFatEmissaoNFe.NotaFiscal = -1

            'Verifica o Tipo de Operação
            oClsFatEmissaoNFe.UpdateNotaFiscal()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirCapa()

        Try

            'Váriaveis Locais
            Dim sStatus(1) As String
            sStatus(0) = CInt(StatusNotaFiscalEletronica.AguardandoTransmissao).ToString
            sStatus(1) = CInt(StatusNotaFiscalEletronica.Rejeitada).ToString

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem, "status", sStatus, "codigo_tipo_documento_fiscal", CInt(TipoDocumentoFiscal.Picking), "recibo", "") = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoNFe.DeleteNotaFiscal()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & "Registros com STATUS de AGUARDANDO TRANSMISSÃO.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub EditarNotaFiscal(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcUpdate) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Limpa Formulário
                Call Novo()

                'Seta Código
                oClsFatEmissaoNFe.CodigoEmissaoCapa = lCodigoEmissaoCapa

                'Carrega dados da Nota Fiscal
                oClsFatEmissaoNFe.LoadDadosNF(cboModelo, _
                                              cboSerie, _
                                              txtNotaFiscal, _
                                              dtpDataEmissao, _
                                              cboNaturezaOperacao, _
                                              cboTipoDocumento, _
                                              dtpDataSaida, _
                                              cboFormaEmissao, _
                                              cboFinalidadeEmissao, _
                                              cboTipoOperacao, _
                                              cboTipoConsumidor, _
                                              cboDestinatario, _
                                              chkLocalRetirada, _
                                              chkLocalEntrega, _
                                              cboModalidadeFrete, _
                                              cboTransportadora, _
                                              txtBaseCalculoTransporte, _
                                              txtAliquotaTransporte, _
                                              txtValorServicoTransporte, _
                                              cboUFICMSTransporte, _
                                              cboMunicipioICMSTransporte, _
                                              cboCFOPICMSTransporte, _
                                              txtICMSRetidoTransporte, _
                                              cboTipoVeiculo, _
                                              txtPlacaVeiculo, _
                                              cboUFVeiculo, _
                                              txtRNTCVeiculo, _
                                              txtBalsa, _
                                              txtVagao, _
                                              txtBaseCalculoICMS, _
                                              txtTotalICMS, _
                                              txtBaseCalculoICMSST, _
                                              txtTotalICMSST, _
                                              txtTotalProdutoServico, _
                                              txtTotalFrete, _
                                              txtTotalSeguro, _
                                              txtTotalDesconto, _
                                              txtTotalII, _
                                              txtTotalIPI, _
                                              txtTotalPIS, _
                                              txtTotalCOFINS, _
                                              txtOutrasDespesas, _
                                              txtTotalNotaFiscal, _
                                              txtFatura, _
                                              txtValorOriginal, _
                                              txtValorDesconto, _
                                              txtValorLiquido, _
                                              cboCondicaoPagamento, _
                                              cboFormaPagamento, _
                                              txtNumeroParcela, _
                                              txtIntervaloEntreParcelas, _
                                              cboUFEmbarque, _
                                              txtLocalEmbarque, _
                                              txtNumeroDrawbackExportacao, _
                                              txtNumeroRE, _
                                              txtChaveAcessoExportacao, _
                                              txtQuantidadeExportacao, _
                                              txtDadosAdicionais, _
                                              txtDadosAdicionaisFISCO, _
                                              txtStatusNFe, _
                                              txtMensagemSefaz, _
                                              txtChaveAcesso, _
                                              txtRecibo, _
                                              txtLote, _
                                              txtProtocolo, _
                                              txtIdentificacao)

                'Carrega Grid NF Referenciada
                Call oClsFatEmissaoNFe.LoadGridNFReferenciada(grdNFReferenciada)

                'Carrega Grid DI
                Call LoadGridDI()

                'Carrega Grid de Produto
                Call LoadGridProduto()

                'Carrega Grid de Parcela
                Call oClsFatEmissaoNFe.LoadGridFatura(grdDuplicata, _
                                                       oClsFatEmissaoNFe.CodigoEmissaoCapa)

                'Carrega Grid de Reboque
                Call oClsFatEmissaoNFe.LoadGridReboque(grdReboque)

                'Carrega Grid de Volume
                Call oClsFatEmissaoNFe.LoadGridVolume(grdVolume)

                If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then

                    'Carrega Grid do Financeiro
                    Call oClsFatEmissaoNFe.LoadGridFinanceiro(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                                                             grdFinanceiro)

                End If

                'Verifica o Tipo de Documento Fiscal
                If cboTipoDocumento.SelectedValue <> CInt(TipoDocumentoFiscal.SaidaSemNF) Then
                    'Adiciona Aba NFe
                    tabDados.TabPages.Remove(pagNFe)
                    tabDados.TabPages.Add(pagNFe)
                End If

                'Seta Status
                Call VerificaStatus(txtStatusNFe.Tag)

                'Seta Aba
                tabDados.SelectedTab = pagDadosNFe
                tabNFe.SelectedTab = pagDadosCapa

                tabDados.Visible = True
                tabNFe.Visible = True

                'Alterna Aba
                If tabMain.TabPages.Contains(pagLista) Then tabMain.TabPages.Remove(pagLista)
                If tabMain.TabPages.Contains(pagDados) = False Then tabMain.TabPages.Add(pagDados)

                If cboTipoDocumento.SelectedValue <> TipoDocumentoFiscal.Entrada And cboTipoDocumento.SelectedValue <> TipoDocumentoFiscal.Saida Then

                    btnSalvar.Enabled = True

                End If


                'Seta Focu
                cboModelo.Focus()

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

    Private Sub DuplicarNotaFiscal(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert) = True Then

                'Verifica se o usuário deseja copiar a Nota Fiscal
                If MsgBox("Deseja Duplicar o Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Carrega Nota Fiscal
                    Call EditarNotaFiscal(oClsFatEmissaoNFe.DuplicarNotaFiscal(lCodigoEmissaoCapa))

                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Modelo
            If ValidaCampo(cboModelo, lblModelo) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Série
            If ValidaCampo(cboSerie, lblSerie) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Natureza da Operação
            If ValidaCampo(cboNaturezaOperacao, lblNaturezaOperacao) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo do Documento
            If ValidaCampo(cboTipoDocumento, lblTipoDocumento) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            If goDatabase.sInitialCatalog <> "INTERACTI_LUMAVALE_PRD_V2" Then
                'Verifica se foi Prenchido o Campo - Data de Saída
                If dtpDataSaida.Checked = False Then
                    If MsgBox("A Data de Saída não foi preenchida. Deseja que a Data de Saída assuma o valor da Data Atual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                        tabDados.SelectedTab = pagDadosNFe
                        dtpDataSaida.Focus()
                        Exit Function
                    Else
                        dtpDataSaida.Value = Now() : dtpDataSaida.Checked = True
                    End If
                End If
            End If


            'Verifica se foi Selecionado o Campo - Forma de Emissão
            If ValidaCampo(cboFormaEmissao, lblFormaEmissao) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma de Emissão
            If ValidaCampo(cboTipoOperacao, lblTipoOperacao) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma de Emissão
            If ValidaCampo(cboTipoConsumidor, lblTipoConsumidor) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Finalidade Emissão
            If ValidaCampo(cboFinalidadeEmissao, lblFinalidadeEmissao) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Function
            End If

            'Valida Dados do Destinatário
            If ValidacaoDestinatario() = False Then
                Exit Function
            End If

            'Valida Dados do Produto
            If ValidacaoProduto() = False Then
                Exit Function
            End If

            'Valida Dados da Exportação
            If ValidacaoExportacao() = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade Frete
            If ValidaCampo(cboModalidadeFrete, lblModalidadeFrete) = False Then
                tabDados.SelectedTab = pagTransporte
                tabTransporte.SelectedTab = pagTransportador
                cboModalidadeFrete.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido a Placa
            If txtPlacaVeiculo.Text.Trim <> "" Then
                If ValidaCampo(cboUFVeiculo, lblUFVeiculo) = False Then
                    tabDados.SelectedTab = pagTransporte
                    tabTransporte.SelectedTab = pagVeiculo
                    cboUFVeiculo.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Forma de Pagamento
            If ValidaCampo(cboFormaPagamento, lblFormaPagamento) = False Then
                tabDados.SelectedTab = pagCobranca
                cboFormaPagamento.Focus()
                Exit Function
            End If

            'Verifica e o Valor das Faturas é igual ao Valor Líquido
            If grdDuplicata.GetDataRows.Count > 0 Then
                If Math.Abs(txtValorLiquido.Value - grdDuplicata.GetTotalRow.Cells("valor").Value) <> 0 Then
                    tabDados.SelectedTab = pagCobranca
                    frmMain.errInfo.SetError(lblValorLiquido, "O Valor Líquido não corresponde ao Soma do Valor das Duplicatas.")
                    tabDados.SelectedTab = pagCobranca
                    txtValorLiquido.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi gerado Duplicata
            If txtValorLiquido.Value > 0 AndAlso grdDuplicata.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi gerado Duplicatas para a Nota Fiscal.")
                tabDados.SelectedTab = pagCobranca
                btnCalcularDuplicata.Focus()
                Exit Function
            End If

            'Verifica se é Exportação
            If cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Saida) And cboUFDestinatario.SelectedValue = "EX" Then

                'Verifica se foi Selecionado o Campo - UF Embarque
                If ValidaCampo(cboUFEmbarque, lblUFEmbarque) = False Then
                    tabDados.SelectedTab = pagExportacaoCompras
                    cboUFEmbarque.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Local Embarque
                If ValidaCampo(txtLocalEmbarque, lblLocalEmbarque, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagExportacaoCompras
                    txtLocalEmbarque.Focus()
                    Exit Function
                End If

            End If

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Configuração da NF-e
            Call LoadConfiguracaoNFe()

            'Verifica se foi Configurado a Nota Fiscal
            If goConfiguracaoNFe.iCodigoTipoAmbienteNFe = 0 Then

                'Verifica se o Usuário Deseja Configurar a NFe
                If MsgBox("Não foi configurado a Nota Fiscal Eletrônica. Deseja Configurar?" & vbCrLf & vbCrLf & _
                          "A Configuração é imprescindível para Salvar a Nota Fiscal.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then

                    Dim oForm As New frmCadBasico
                    oForm.UsrControl = "usrCfgNFe"
                    oForm.Titulo = Me.Parent.Text
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Configuração
                    Call LoadConfiguracaoNFe()

                    If goConfiguracaoNFe.iCodigoTipoAmbienteNFe = 0 Then
                        Exit Function
                    End If

                End If

            End If

            'Valida Dados do Estoque (Se não for emitir Nota Fiscal)
            If cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Then
                'Valida Produto
                Dim sMensagem As String = ""
                If oClsFatEmissaoNFe.ValidaProduto(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                                                   sMensagem) = False Then
                    'Informa o Usuário sobre o problema do Estoque
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, sMensagem)
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub VerificaStatus(ByVal iStatus As Integer)

        Try

            'Desabilita Controles
            btnDevolucaoNotaFiscalEmitida.Enabled = False
            btnDevolucaoNotaFiscal.Enabled = False
            btnTransmitirNFe.Enabled = False
            btnSimularTransmissao.Enabled = False
            btnRetornarNFe.Enabled = False
            btnExportarXML.Enabled = False
            btnImprimirDANFE.Enabled = False
            btnImprimirBoletoBancario.Enabled = False
            btnPreVisualizarDANFE.Enabled = False
            btnEnviarEmail.Enabled = False
            btnCartaCorrecao.Enabled = False
            btnImportarPedidoVenda.Enabled = False

            'Verifica qual status foi selecionado
            Select Case iStatus

                Case StatusNotaFiscalEletronica.AguardandoTransmissao
                    txtStatusNFe.Text = "AGUARDANDO TRANSMISSÃO"
                    btnTransmitirNFe.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcAdministrator)
                    btnSimularTransmissao.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcAdministrator)
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnInserirItem.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnInserirNFReferenciada.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirNFReferenciada.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnInserirVolume.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirVolume.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    cboTipoVeiculo.Enabled = True
                    btnInserirReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnExcluirItem.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnPreVisualizarDANFE.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint)
                    btnInserirDI.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirDI.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnInserirAdicao.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirAdicao.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnDevolucaoNotaFiscalEmitida.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnDevolucaoNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnImportarPedidoVenda.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                Case StatusNotaFiscalEletronica.AguardandoRetorno
                    txtStatusNFe.Text = "AGUARDANDO RETORNO"
                    btnRetornarNFe.Enabled = True
                    btnSalvar.Enabled = False
                    btnInserirItem.Enabled = False
                    btnInserirNFReferenciada.Enabled = False
                    btnExcluirNFReferenciada.Enabled = False
                    btnInserirVolume.Enabled = False
                    btnExcluirVolume.Enabled = False
                    cboTipoVeiculo.Enabled = False
                    btnInserirReboque.Enabled = False
                    btnExcluirReboque.Enabled = False
                    btnExcluirItem.Enabled = False
                    btnPreVisualizarDANFE.Enabled = True
                    btnInserirDI.Enabled = False
                    btnExcluirDI.Enabled = False
                    btnInserirAdicao.Enabled = False
                    btnExcluirAdicao.Enabled = False

                Case StatusNotaFiscalEletronica.AutorizadaUso, StatusNotaFiscalEletronica.EnviadoDestinatario
                    txtStatusNFe.Text = "AUTORIZADA PARA USO"
                    btnExportarXML.Enabled = True
                    btnImprimirDANFE.Enabled = True
                    btnImprimirBoletoBancario.Enabled = True
                    btnEnviarEmail.Enabled = True
                    btnCartaCorrecao.Enabled = True
                    btnSalvar.Enabled = IIf(cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking), VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert), False)
                    btnInserirItem.Enabled = IIf(cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking), VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert), False)
                    btnInserirNFReferenciada.Enabled = False
                    btnExcluirNFReferenciada.Enabled = False
                    cboTipoVeiculo.Enabled = False
                    btnInserirReboque.Enabled = False
                    btnExcluirReboque.Enabled = IIf(cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking), VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert), False)
                    btnInserirVolume.Enabled = False
                    btnExcluirVolume.Enabled = False
                    btnExcluirItem.Enabled = IIf(cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking), VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert), False)
                    btnInserirDI.Enabled = False
                    btnExcluirDI.Enabled = False
                    btnInserirAdicao.Enabled = False
                    btnExcluirAdicao.Enabled = False

                Case StatusNotaFiscalEletronica.Rejeitada
                    txtStatusNFe.Text = "REJEITADA"
                    btnTransmitirNFe.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcAdministrator)
                    btnSimularTransmissao.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcAdministrator)
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnInserirItem.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnInserirNFReferenciada.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirNFReferenciada.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    cboTipoVeiculo.Enabled = True
                    btnInserirReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnInserirVolume.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirVolume.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnExcluirItem.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnPreVisualizarDANFE.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint)
                    btnInserirDI.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirDI.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnInserirAdicao.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnExcluirAdicao.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcDelete)
                    btnDevolucaoNotaFiscalEmitida.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                    btnDevolucaoNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert)
                Case StatusNotaFiscalEletronica.Cancelada
                    txtStatusNFe.Text = "CANCELADA"
                    btnExportarXML.Enabled = True
                    btnImprimirDANFE.Enabled = True
                    btnImprimirBoletoBancario.Enabled = True
                    btnEnviarEmail.Enabled = True
                    btnCartaCorrecao.Enabled = True
                    btnSalvar.Enabled = False
                    btnInserirItem.Enabled = False
                    btnInserirNFReferenciada.Enabled = False
                    btnExcluirNFReferenciada.Enabled = False
                    cboTipoVeiculo.Enabled = False
                    btnInserirReboque.Enabled = False
                    btnExcluirReboque.Enabled = False
                    btnInserirVolume.Enabled = False
                    btnExcluirVolume.Enabled = False
                    btnExcluirItem.Enabled = False
                    btnInserirDI.Enabled = False
                    btnExcluirDI.Enabled = False
                    btnInserirAdicao.Enabled = False
                    btnExcluirAdicao.Enabled = False

                Case StatusNotaFiscalEletronica.Simulacao
                    txtStatusNFe.Text = "SIMULAÇÃO"
                    btnExportarXML.Enabled = True
                    btnImprimirDANFE.Enabled = True
                    btnImprimirBoletoBancario.Enabled = True
                    btnEnviarEmail.Enabled = True
                    btnCartaCorrecao.Enabled = True
                    btnSalvar.Enabled = IIf(cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.SaidaSemNF) Or cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Picking), VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcInsert), False)
                    btnInserirItem.Enabled = False
                    btnInserirNFReferenciada.Enabled = False
                    btnExcluirNFReferenciada.Enabled = False
                    cboTipoVeiculo.Enabled = False
                    btnInserirReboque.Enabled = False
                    btnExcluirReboque.Enabled = False
                    btnInserirVolume.Enabled = False
                    btnExcluirVolume.Enabled = False
                    btnExcluirItem.Enabled = False
                    btnInserirDI.Enabled = False
                    btnExcluirDI.Enabled = False
                    btnInserirAdicao.Enabled = False
                    btnExcluirAdicao.Enabled = False
                    btnTransmitirNFe.Enabled = False
                    btnSimularTransmissao.Enabled = False

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadDadosNotaFiscal()

        Try

            'Carrega Combo - Destinatário
            Call LoadCombo(cboDestinatario, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa, False)

            'Carrega Dados da Nota Fiscal
            Call oClsFatEmissaoNFe.LoadDadosNFePedidoVenda(cboDestinatario, _
                                                           txtFatura, _
                                                           txtValorOriginal, _
                                                           txtValorDesconto, _
                                                           txtValorLiquido, _
                                                           cboFormaPagamento, _
                                                           txtNumeroParcela, _
                                                           txtIntervaloEntreParcelas, _
                                                           cboModalidadeFrete, _
                                                           txtTotalFrete, _
                                                           cboTransportadora, _
                                                           chkLocalRetirada, _
                                                           chkLocalEntrega, _
                                                           txtDadosAdicionais, _
                                                           cboNaturezaOperacao)

            'Carrega Dados da Fatura
            Call oClsFatEmissaoNFe.LoadDadosFatura(txtValorOriginal, _
                                                   txtValorDesconto, _
                                                   txtValorPago, _
                                                   cboCondicaoPagamento, _
                                                   txtTotalFrete.Value, _
                                                   txtTotalSeguro.Value, _
                                                   txtOutrasDespesas.Value)

            'Carrega Grid de Produto
            Call LoadGridProduto()

            Call oClsFatEmissaoNFe.LoadGridVolume(grdVolume)

            'Carrega Grid - Fatura
            Call oClsFatEmissaoNFe.LoadGridFatura(grdDuplicata, _
                                                  oClsFatEmissaoNFe.CodigoEmissaoCapa)

            'Carrega Grid - NF Relacionada
            Call oClsFatEmissaoNFe.LoadGridNFReferenciada(grdNFReferenciada)

            'Carrega Grid - Volume
            Call oClsFatEmissaoNFe.LoadGridVolume(grdVolume)

            'Verifica se foi Selecionado a Condição de Pagamento
            If cboCondicaoPagamento.SelectedIndex = -1 Then

                'Gera Parcela
                Call oClsFatEmissaoNFe.GerarDuplicata2(grdDuplicata, _
                                                       txtValorLiquido.Value, _
                                                       txtNumeroParcela.Value, _
                                                       txtIntervaloEntreParcelas.Value, _
                                                       txtTotalICMSST.Value)

            Else

                'Gera Parcela
                Call oClsFatEmissaoNFe.GerarDuplicata(grdDuplicata, _
                                                      cboCondicaoPagamento.SelectedValue, _
                                                      txtValorLiquido.Value, _
                                                      dtpDataEmissao.Value, _
                                                      txtTotalICMSST.Value)
            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirBoletoBancario(ByVal lCodigoTituloCapa As Long, _
                                       ByVal sCliente As String, _
                                       ByVal sNumeroDocumento As String)

        Try

            'Variável - Formulário de Boleto Bancário
            Dim oForm As New frmFinReceitaBoletoBancarioDLL
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parametros
            oForm.Cliente = sCliente
            oForm.NumeroDocumento = sNumeroDocumento
            oForm.CodigoTituloCapa = lCodigoTituloCapa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoNFe()

        Try

            'Váriavel - Formulário de Emissão NFe Histórico
            Dim oForm As New frmFatEmissaoNFeHistorico
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Paramentros
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarExcelRemessa()

        Try
            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoImportarExcelRemessa
            oForm.ShowDialog(Me)

            If oForm.CodigoEmissaoCapa = -1 Then Exit Sub
            EditarNotaFiscal(oForm.CodigoEmissaoCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub IntegracaoVenda()

        Try

            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcAdministrator) = True Then

                'Váriavel - Formulário para vincular pedido de venda
                Dim oForm As New frmFatEmissaoNFPedidoVenda

                'Seta Paramentros
                oForm.CodigoEntradaCapa = grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value
                oForm.CodigoEntradaItem = grdListagem.CurrentRow.Cells("codigo").Value
                oForm.CodigoEmitente = grdListagem.CurrentRow.Cells("codigo_emitente").Value

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                Call LoadGrid()

            End If

            Cursor.Current = Cursors.WaitCursor

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: NF REFERENCIADA :::"

    Private Function ValidacaoNFReferenciada() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoNFReferenciada = False

            'Verifica se foi Selecionado o Campo - Tipo de Nota Fiscal
            If ValidaCampo(cboTipoNotaFiscalReferenciada, lblTipoNotaFiscalReferenciada) = False Then
                Exit Function
            End If

            'Verifica o Tipo de Nota Fiscal
            If cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal) Then

                'Verifica se foi Selecionado o Campo - UF
                If ValidaCampo(cboUFNFReferenciada, lblUFNFReferenciada) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - CNPJ
                If ValidaCampo(txtCNPJNFReferenciada, lblCNPJNFReferenciada, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Série
                If ValidaCampo(txtSerieNFReferenciada, lblSerieNFReferenciada, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Nota Fiscal
                If ValidaCampo(txtNotaFiscalNFReferenciada, lblNotaFiscalNFReferenciada, TipoCampo.numero) = False Then
                    Exit Function
                End If

            ElseIf cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Then

                'Verifica se foi Preenchido o Campo - Chave de Acesso
                If ValidaCampo(cboNotaFiscalChaveAcessoNFReferenciada, lblNotaFiscalChaveAcessoNFReferenciada) = False Then
                    Exit Function
                End If

                'Verifica se já foi Inserido este Registro
                Dim iRow As Integer
                iRow = IIf(IsNumeric(btnInserirNFReferenciada.Tag), btnInserirNFReferenciada.Tag, -1)
                If VerificaExisteValorGrid(grdNFReferenciada, "chave_acesso", cboNotaFiscalChaveAcessoNFReferenciada.SelectedValue, iRow) = True Then
                    frmMain.errInfo.SetError(lblNotaFiscalChaveAcessoNFReferenciada, "Esta Chave de Acesso já está relacionada na Nota Fiscal.")
                    cboNotaFiscalChaveAcessoNFReferenciada.Focus()
                    Exit Function
                End If

                'Verifica se o Destinatário da Nota Fiscal é Válido
                If grdNFReferenciada.GetDataRows.Count > 0 Then
                    If grdNFReferenciada.GetDataRows(0).Cells("codigo_destinatario").Value = cboNotaFiscalChaveAcessoNFReferenciada.Tag Then
                        frmMain.errInfo.SetError(lblNotaFiscalChaveAcessoNFReferenciada, "O Destinatário dessa Nota Fiscal difere do(s) Destinatário(s) da(s) Nota(s) Fiscal(is) inserida.")
                        cboNotaFiscalChaveAcessoNFReferenciada.Focus()
                        Exit Function
                    End If
                End If

            End If

            'Seta Retorno da Função
            ValidacaoNFReferenciada = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarNFReferenciada()

        Try

            If IsNumeric(btnInserirNFReferenciada.Tag) Then

                'Atualiza Registro na tb_fat_emissao_nf_referencia
                oClsFatEmissaoNFe.UpdateNFReferenciada(cboTipoNotaFiscalReferenciada.SelectedValue, _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), cboUFNFReferenciada.SelectedValue, ""), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), dtpDataEmissaoNFReferenciada.Value, ""), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), txtCNPJNFReferenciada.Text, ""), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), txtSerieNFReferenciada.Text, -1), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), txtNotaFiscalNFReferenciada.Text, -1), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica), cboNotaFiscalChaveAcessoNFReferenciada.SelectedValue, ""), _
                                                       grdNFReferenciada.CurrentRow.Cells("item").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                'Insere Registro na tb_fat_emissao_nf_referencia
                oClsFatEmissaoNFe.InsertNFReferenciada(cboTipoNotaFiscalReferenciada.SelectedValue, _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), cboUFNFReferenciada.SelectedValue, ""), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), dtpDataEmissaoNFReferenciada.Value, ""), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), txtCNPJNFReferenciada.Text, ""), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), txtSerieNFReferenciada.Text, -1), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscal), txtNotaFiscalNFReferenciada.Text, -1), _
                                                       IIf(cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica), cboNotaFiscalChaveAcessoNFReferenciada.SelectedValue, ""))

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            ''Seta Destinatário
            'If cboTipoNotaFiscalReferenciada.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
            '    cboDestinatario.SelectedValue = cboNotaFiscalChaveAcessoNFReferenciada.Tag
            '    cboDestinatario.Enabled = False
            'End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirNFReferenciada()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdNFReferenciada) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoNFe.DeleteNFReferenciada()

                    'Veirifica se existe um Registro
                    If grdNFReferenciada.GetDataRows.Count = 0 Then
                        cboDestinatario.Enabled = True
                    End If

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

    Private Sub EditarNFReferenciada()

        Try

            'Seta Controles
            cboTipoNotaFiscalReferenciada.SelectedValue = grdNFReferenciada.CurrentRow.Cells("codigo_tipo_nota_fiscal").Value
            btnInserirNFReferenciada.Tag = grdNFReferenciada.CurrentRow.RowIndex

            If cboTipoNotaFiscalReferenciada.SelectedValue = TipoNotaFiscal.NotaFiscal Then
                cboUFNFReferenciada.SelectedValue = grdNFReferenciada.CurrentRow.Cells("uf").Value
                txtCNPJNFReferenciada.Text = grdNFReferenciada.CurrentRow.Cells("cnpj").Value
                dtpDataEmissaoNFReferenciada.Value = grdNFReferenciada.CurrentRow.Cells("data_emissao").Value
                txtSerieNFReferenciada.Text = grdNFReferenciada.CurrentRow.Cells("serie").Value
                txtNotaFiscalNFReferenciada.Text = grdNFReferenciada.CurrentRow.Cells("nota_fiscal").Value
            ElseIf cboTipoNotaFiscalReferenciada.SelectedValue = TipoNotaFiscal.NotaFiscalEletronica Then
                cboNotaFiscalChaveAcessoNFReferenciada.SelectedValue = grdNFReferenciada.CurrentRow.Cells("chave_acesso").Value
            End If

            'SetaFocu
            cboTipoNotaFiscalReferenciada.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoNFReferenciada()

        Try

            'Limpa Controles - Nota Fiscal
            cboUFNFReferenciada.SelectedIndex = -1
            txtCNPJNFReferenciada.Text = ""
            txtSerieNFReferenciada.Text = ""
            txtNotaFiscalNFReferenciada.Text = ""
            dtpDataEmissaoNFReferenciada.Value = Now.Date
            'Limpa Controles - Nota Fiscal Eletrônica
            cboNotaFiscalChaveAcessoNFReferenciada.SelectedIndex = -1
            btnInserirNFReferenciada.Tag = ""

            'Seta Focu
            cboTipoNotaFiscalReferenciada.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DESTINATÁRIO :::"

    Private Sub SalvarDestinatario()

        Try

            'Seta Parametros
            oClsFatEmissaoNFe.CodigoDestinatario = cboDestinatario.SelectedValue
            oClsFatEmissaoNFe.CnpjCpfDestinatario = txtCNPJDestinatario.Text.Trim
            oClsFatEmissaoNFe.LogradouroDestinatario = txtLogradouroDestinatario.Text.Trim
            oClsFatEmissaoNFe.NumeroDestinatario = txtNumeroDestinatario.Text.Trim
            oClsFatEmissaoNFe.ComplementoDestinatario = txtComplementoDestinatario.Text.Trim
            oClsFatEmissaoNFe.BairroDestinatario = txtBairroDestinatario.Text.Trim
            oClsFatEmissaoNFe.CodigoMunicipioDestinatario = IIf(cboMunicipioDestinatario.SelectedIndex = -1, -1, cboMunicipioDestinatario.SelectedValue)
            oClsFatEmissaoNFe.UFDestinatario = IIf(cboUFDestinatario.SelectedIndex = -1, "", cboUFDestinatario.SelectedValue)
            oClsFatEmissaoNFe.CepDestinatario = txtCEPDestinatario.Text.Trim
            oClsFatEmissaoNFe.CodigoPaisDestinatario = cboPaisDestinatario.SelectedValue
            oClsFatEmissaoNFe.TelefoneDestinatario = txtTelefoneDestinatario.Text.Trim
            oClsFatEmissaoNFe.InscricaoEstadualDestinatario = IIf(txtCNPJDestinatario.Tag = Personalidade.Juridica, txtInscricaoEstadualDestinatario.Text.Trim, "")
            oClsFatEmissaoNFe.InscricaoSuframaDestinatario = txtInscricaoSuframaDestinatario.Text.Trim
            oClsFatEmissaoNFe.EmailDestinatario = txtEmailDestinatario.Text.Trim
            oClsFatEmissaoNFe.OutroLugarEntrega = chkLocalEntrega.Checked
            oClsFatEmissaoNFe.OutroLugarRetirada = chkLocalRetirada.Checked
            oClsFatEmissaoNFe.Identificacao = txtIdentificacao.Text.Trim
            oClsFatEmissaoNFe.RazaoSocialDestinatario = cboDestinatario.Text


            'Salva Dados do Destinatário
            oClsFatEmissaoNFe.DeleteDestinatario()
            oClsFatEmissaoNFe.InsertDestinatario()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LocalRetirada()

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeLocalRetirada
            'Seta Parametros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.btnSalvar.Enabled = btnSalvar.Enabled
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LocalEntrega()

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeLocalEntrega
            'Seta Parametros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.CNPJ = txtCNPJDestinatario.Text.Trim
            oForm.btnSalvar.Enabled = btnSalvar.Enabled
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDestinatario() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDestinatario = False

            'Verifica se foi Selecionado o Campo - Destinatário
            If ValidaCampo(cboDestinatario, lblDestinatario) = False Then
                tabDados.SelectedTab = pagDestinatario
                cboDestinatario.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPaisDestinatario, lblPaisDestinatario) = False Then
                tabDados.SelectedTab = pagDestinatario
                cboPaisDestinatario.Focus()
                Exit Function
            End If

            'Verifica se o Parceiro de Negócio é interno
            If cboPaisDestinatario.SelectedValue = CInt(Pais.Brasil) And cboTipoDocumento.SelectedValue <> CInt(TipoDocumentoFiscal.SaidaSemNF) Then

                'Verifica se foi Preenchido o Campo - CNPJ /  CPF
                If ValidaCampo(txtCNPJDestinatario, lblCNPJDestinatario, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDestinatario
                    txtCNPJDestinatario.Focus()
                    Exit Function
                ElseIf txtCNPJDestinatario.Tag = CInt(Personalidade.Juridica) Then
                    If ValidaCNPJ(txtCNPJDestinatario.Text) = False Then
                        frmMain.errInfo.SetError(lblCNPJDestinatario, "Este CNPJ: " & txtCNPJDestinatario.Text.Trim & " não é válido.")
                        tabDados.SelectedTab = pagDestinatario
                        txtCNPJDestinatario.Focus()
                        Exit Function
                    End If
                ElseIf txtCNPJDestinatario.Tag = CInt(Personalidade.Fisica) Then
                    If ValidaCPF(txtCNPJDestinatario.Text) = False Then
                        frmMain.errInfo.SetError(lblCNPJDestinatario, "Este CPF: " & txtCNPJDestinatario.Text.Trim & " não é válido.")
                        tabDados.SelectedTab = pagDestinatario
                        txtCNPJDestinatario.Focus()
                        Exit Function
                    End If
                End If

            End If

            'Verifica se foi Preenchido o Campo - Inscrição Estadual
            If txtCNPJDestinatario.Tag = CInt(Personalidade.Juridica) And cboPaisDestinatario.SelectedValue = CInt(Pais.Brasil) Then
                If ValidaCampo(txtInscricaoEstadualDestinatario, lblInscricaoEstadualDestinatario, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDestinatario
                    txtInscricaoEstadualDestinatario.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - CEP
            If ValidaCampo(txtCEPDestinatario, lblCEPDestinatario, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDestinatario
                txtCEPDestinatario.Focus()
                Exit Function
            ElseIf txtCEPDestinatario.Text.Length <> 9 Then
                frmMain.errInfo.SetError(lblCEPDestinatario, "Este CEP: " & txtCEPDestinatario.Text.Trim & " está incompleto.")
                tabDados.SelectedTab = pagDestinatario
                txtCEPDestinatario.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPaisDestinatario, lblPaisDestinatario) = False Then
                tabDados.SelectedTab = pagDestinatario
                cboPaisDestinatario.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFDestinatario, lblUFDestinatario) = False Then
                tabDados.SelectedTab = pagDestinatario
                cboUFDestinatario.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - IE Corretamente
            If txtCNPJDestinatario.Tag = CInt(Personalidade.Juridica) And cboPaisDestinatario.SelectedValue = CInt(Pais.Brasil) Then
                If ValidaIE(cboUFDestinatario.SelectedValue, txtInscricaoEstadualDestinatario.Text) = False Then
                    frmMain.errInfo.SetError(lblInscricaoEstadualDestinatario, "Esta Inscrição Estadual: " & txtInscricaoEstadualDestinatario.Text.Trim & " não é válida.")
                    tabDados.SelectedTab = pagDestinatario
                    txtInscricaoEstadualDestinatario.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Município
            If ValidaCampo(cboMunicipioDestinatario, lblMunicipioDestinatario) = False Then
                tabDados.SelectedTab = pagDestinatario
                cboMunicipioDestinatario.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouroDestinatario, lblLogradouroDestinatario, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDestinatario
                txtLogradouroDestinatario.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumeroDestinatario, lblNumeroDestinatario, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDestinatario
                txtNumeroDestinatario.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bairro
            If ValidaCampo(txtBairroDestinatario, lblBairroDestinatario, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDestinatario
                txtBairroDestinatario.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDestinatario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: EMITENTE :::"

    Private Sub SalvarEmitente()

        Try

            'Salva Dados do Emitente
            oClsFatEmissaoNFe.DeleteEmitente()
            oClsFatEmissaoNFe.InsertEmitente()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TOTAL :::"

    Private Sub SalvarTotal()

        Try

            'Seta Parametros
            oClsFatEmissaoNFe.BaseCalculoICMS = txtBaseCalculoICMS.Value
            oClsFatEmissaoNFe.TotalICMS = txtTotalICMS.Value
            oClsFatEmissaoNFe.BaseCalculoICMSST = txtBaseCalculoICMSST.Value
            oClsFatEmissaoNFe.TotalICMSST = txtTotalICMSST.Value
            oClsFatEmissaoNFe.TotalProdutoServico = txtTotalProdutoServico.Value
            oClsFatEmissaoNFe.TotalFrete = txtTotalFrete.Value
            oClsFatEmissaoNFe.TotalSeguro = txtTotalSeguro.Value
            oClsFatEmissaoNFe.TotalDesconto = txtTotalDesconto.Value
            oClsFatEmissaoNFe.TotalII = txtTotalII.Value
            oClsFatEmissaoNFe.TotalIPI = txtTotalIPI.Value
            oClsFatEmissaoNFe.PIS = txtTotalPIS.Value
            oClsFatEmissaoNFe.COFINS = txtTotalCOFINS.Value
            oClsFatEmissaoNFe.OutrasDespesas = txtOutrasDespesas.Value
            oClsFatEmissaoNFe.TotalNotaFiscal = txtTotalNotaFiscal.Value
            oClsFatEmissaoNFe.ValorRetidoPIS = 0
            oClsFatEmissaoNFe.ValorRetidoCOFINS = 0
            oClsFatEmissaoNFe.ValorRetidoCSLL = 0
            oClsFatEmissaoNFe.BaseCalculoIRRF = 0
            oClsFatEmissaoNFe.ValorRetidoIRRF = 0
            oClsFatEmissaoNFe.BaseCalculoRetencaoPrevidenciaSocial = 0
            oClsFatEmissaoNFe.RetencaoPrevidenciaSocial = 0
            oClsFatEmissaoNFe.BaseCalculoISS = 0
            oClsFatEmissaoNFe.TotalISS = 0
            oClsFatEmissaoNFe.PISSobreServico = 0
            oClsFatEmissaoNFe.COFINSSobreServico = 0
            oClsFatEmissaoNFe.TotalServicoNaoTributadoICMS = 0
            oClsFatEmissaoNFe.ValorDestinoICMSPartilha = txtTotalICMSDestino.Value
            oClsFatEmissaoNFe.ValorFCPICMSPartilha = txtTotalFCP.Value
            oClsFatEmissaoNFe.ValorRemetenteICMSPartilha = txtTotalICMSRemetente.Value

            'Salva Dados Total
            oClsFatEmissaoNFe.DeleteTotal()
            oClsFatEmissaoNFe.InsertTotal()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: INFORMAÇÕES ADICIONAIS :::"

    Private Sub SalvarInformacoesAdicionais()

        Try

            'Seta Parametros
            oClsFatEmissaoNFe.InformacaoAdicionalFisco = txtDadosAdicionaisFISCO.Text.Trim
            oClsFatEmissaoNFe.InformacaoAdicionalContribuinte = txtDadosAdicionais.Text.Trim

            'Salva Dados Informaççoes Adicionais
            oClsFatEmissaoNFe.DeleteInformacaoAdicional()
            oClsFatEmissaoNFe.InsertInformacaoAdicional()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub SalvarFatura()

        Try

            'Deleta Dados da Fatura
            oClsFatEmissaoNFe.DeleteFatura()

            'Seta texto da Fatura
            If txtFatura.Text <> "" And txtValorLiquido.Value > 0 Then
                txtFatura.Text = cboFormaPagamento.Text
            End If

            'Seta Parametros
            oClsFatEmissaoNFe.Fatura = txtFatura.Text.Trim
            oClsFatEmissaoNFe.ValorOriginal = txtValorOriginal.Value
            oClsFatEmissaoNFe.ValorDesconto = txtValorDesconto.Value
            oClsFatEmissaoNFe.ValorLiquido = txtValorLiquido.Value
            oClsFatEmissaoNFe.NumeroParcela = txtNumeroParcela.Value
            oClsFatEmissaoNFe.IntervaloParcela = txtIntervaloEntreParcelas.Value
            oClsFatEmissaoNFe.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)

            'Salva Dados Fatura
            oClsFatEmissaoNFe.InsertFatura()
            oClsFatEmissaoNFe.InsertFaturaDuplicata(grdDuplicata)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoFatura() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFatura = False

            'Verifica se existe Duplicatas
            If grdDuplicata.GetDataRows.Count > 0 Then

                'Verifica se foi Preenchido o Campo - Fatura
                If ValidaCampo(txtFatura, lblFatura, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagCobranca
                    txtFatura.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor Original
                If ValidaCampo(txtValorOriginal, lblValorOriginal, True) = False Then
                    tabDados.SelectedTab = pagCobranca
                    txtValorOriginal.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Valor Original
                If ValidaCampo(cboFormaPagamento, lblFormaPagamento) = False Then
                    tabDados.SelectedTab = pagCobranca
                    cboFormaPagamento.Focus()
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            ValidacaoFatura = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region " ::: FINANCEIRO ::: "

    Private Sub SalvarFinanceiro()

        Try


            'Deleta Dados da Fatura
            oClsFatEmissaoNFe.DeleteFinanceiro()

            'Salva Dados Fatura - Financeiro
            oClsFatEmissaoNFe.InsertFinanceiro(grdFinanceiro)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteFinanceiro()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdFinanceiro) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    Dim oRow As GridEXRow

                    For Each oRow In grdFinanceiro.GetCheckedRows
                        'Exclui Registro da Grid
                        oRow.Delete()
                    Next


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

    Private Sub EditarFinanceiro()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcUpdate) = True Then

                'Carrega Controles
                txtFinanceiroNumeroParcela.Value = grdFinanceiro.CurrentRow.Cells("numero_parcela").Value
                txtFinanceiroIntervaloParcelas.Value = grdFinanceiro.CurrentRow.Cells("intervalo_parcela").Value
                txtFinanceiroPercentualParcela.Value = grdFinanceiro.CurrentRow.Cells("percentual_parcela").Value
                txtFinanceiroValorParcela.Value = grdFinanceiro.CurrentRow.Cells("valor_parcela").Value
                btnFinanceiroInserir.Tag = grdFinanceiro.CurrentRow.RowIndex
                btnFinanceitoExcluir.Tag = grdFinanceiro.CurrentRow.Cells("codigo").Value

                'Seta Focu
                txtFinanceiroNumeroParcela.Focus()

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

    Private Sub NovoFinanceiro()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            txtFinanceiroNumeroParcela.Value = 0
            txtFinanceiroIntervaloParcelas.Value = 0
            txtFinanceiroPercentualParcela.Value = 0
            txtFinanceiroValorParcela.Value = 0


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: EXPORTAÇÃO :::"

    Private Sub SalvarExportacao()

        Try

            'Deleta Dados da Exportacao
            oClsFatEmissaoNFe.DeleteExportacao()

            'Verifica a Necessidade de Salvar Dados de Exportação
            If cboUFEmbarque.SelectedIndex <> -1 Then

                'Seta Parametros
                oClsFatEmissaoNFe.UFEmbarque = cboUFEmbarque.SelectedValue
                oClsFatEmissaoNFe.LocalEmbarque = txtLocalEmbarque.Text.Trim
                oClsFatEmissaoNFe.NumeroDrawbackExportacao = txtNumeroDrawbackExportacao.Text.Trim
                oClsFatEmissaoNFe.NumeroRE = txtNumeroRE.Text.Trim
                oClsFatEmissaoNFe.ChaveAcessoExportacao = txtChaveAcessoExportacao.Text.Trim
                oClsFatEmissaoNFe.QuantidadeExportacao = txtQuantidadeExportacao.Value

                'Salva Dados Exportação
                oClsFatEmissaoNFe.InsertExportacao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoExportacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoExportacao = False

            'Verifica se foi Selecionado o Local de Embarque
            If txtLocalEmbarque.Text.Trim <> "" Then
                'Verifica se foi Selecionado o Campo - UF de Embarque
                If ValidaCampo(cboUFEmbarque, lblUFEmbarque) = False Then
                    tabDados.SelectedTab = pagExportacaoCompras
                    cboUFEmbarque.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado a UF de Embarque
            If cboUFEmbarque.SelectedIndex <> -1 Then
                'Verifica se foi Preenchido o Campo - Local de Embarque
                If ValidaCampo(txtLocalEmbarque, lblLocalEmbarque, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagExportacaoCompras
                    txtLocalEmbarque.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoExportacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: COMPRAS :::"

    Private Sub SalvarCompras()

        Try

            'Deleta Dados da Compras
            oClsFatEmissaoNFe.DeleteCompras()

            'Verifica se tem Informações para ser salvo
            If txtNotaEmpenho.Text.Trim <> "" Or _
               txtInformacaoPedido.Text.Trim <> "" Or _
               txtInformacaoContrato.Text.Trim <> "" Then

                'Seta Parametros
                oClsFatEmissaoNFe.NotaEmpenho = txtNotaEmpenho.Text.Trim
                oClsFatEmissaoNFe.InformacaoPedido = txtInformacaoPedido.Text.Trim
                oClsFatEmissaoNFe.InformacaoContrato = txtInformacaoContrato.Text.Trim

                'Salva Dados Compras
                oClsFatEmissaoNFe.InsertCompras()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DI / ADIÇÃO :::"

    Private Sub ExcluirDI()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdDI) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoNFe.DeleteDI()

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

    Private Sub LoadGridDI()

        Try

            'Carrega Grid
            oClsFatEmissaoNFe.LoadGridDI(grdDI)

            'Carrega Combo de DI
            Call LoadCombo(cboNumeroDIAdicao, "sp_select_combo_faturamento_emissao_di " & oClsFatEmissaoNFe.CodigoEmissaoCapa & ", " & goUsuario.iEmpresa, False)
            Call LoadComboGrid(grdProduto, "codigo_emissao_di", "sp_select_combo_faturamento_emissao_di " & oClsFatEmissaoNFe.CodigoEmissaoCapa & ", " & goUsuario.iEmpresa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoDI()

        Try

            'Limpa Controles
            txtNumeroDI.Text = ""
            dtpDataRegistroDI.Value = Now.Date
            txtCodigoExportador.Text = ""
            cboUFDI.SelectedIndex = -1
            txtLocalDI.Text = ""
            dtpDataDesembaracoDI.Value = Now.Date
            btnInserirDI.Tag = ""

            'Seta Focu
            txtNumeroDI.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDI()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirDI.Tag) = False Then

                'Insere Reboque
                oClsFatEmissaoNFe.InsertDI(txtNumeroDI.Text.Trim, _
                                           dtpDataRegistroDI.Value, _
                                           txtCodigoExportador.Text.Trim, _
                                           cboUFDI.SelectedValue, _
                                           txtLocalDI.Text.Trim, _
                                           dtpDataDesembaracoDI.Value)


            Else

                'Atualiza Reboque
                oClsFatEmissaoNFe.UpdateDI(txtNumeroDI.Text.Trim, _
                                           dtpDataRegistroDI.Value, _
                                           txtCodigoExportador.Text.Trim, _
                                           cboUFDI.SelectedValue, _
                                           txtLocalDI.Text.Trim, _
                                           dtpDataDesembaracoDI.Value, _
                                           btnInserirDI.Tag)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDI() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDI = False

            'Verifica se foi Preenchido o Campo - DI
            If ValidaCampo(txtNumeroDI, lblNumeroDI, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDIAdicao
                txtNumeroDI.Focus()
                Exit Function
            End If

            'Verifica se foi o Número da DI Informado é Válido
            If oClsFatEmissaoNFe.ValidaDI(txtNumeroDI.Text, _
                                          IIf(IsNumeric(btnInserirDI.Tag), btnInserirDI.Tag, -1)) = False Then
                'Informa essa DI já está informada
                frmMain.errInfo.SetError(lblNumeroDI, "Esta DI: " & txtNumeroDI.Text & " já está associada a um outro Registro.")
                tabDados.SelectedTab = pagDIAdicao
                txtNumeroDI.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código Exportador
            If ValidaCampo(txtCodigoExportador, lblCodigoExportador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDIAdicao
                txtCodigoExportador.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFDI, lblUFDI) = False Then
                tabDados.SelectedTab = pagDIAdicao
                cboUFDI.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Local do Desembaraco
            If ValidaCampo(txtLocalDI, lblLocalDI, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDIAdicao
                txtLocalDI.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDI = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Private Sub ExcluirDIAdicao()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdAdicao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoNFe.DeleteDIAdicao()

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

    Private Sub LoadGridDIAdicao()

        Try

            'Carrega Grid
            oClsFatEmissaoNFe.LoadGridDIAdicao(grdAdicao, _
                                               cboNumeroDIAdicao.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoDIAdicao()

        Try

            'Limpa Controles
            txtNumeroAdicao.Text = ""
            cboNCMAdicao.SelectedIndex = -1
            txtValorSeguroAdicao.Value = 0
            txtValorFreteAdicao.Value = 0
            txtValorDescontoAdicao.Value = 0
            txtValorOutrasDespesasAdicao.Value = 0
            btnInserirAdicao.Tag = ""

            'Seta Focu
            txtNumeroAdicao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDIAdicao()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirAdicao.Tag) = False Then

                'Insere Reboque
                oClsFatEmissaoNFe.InsertDIAdicao(cboNumeroDIAdicao.SelectedValue, _
                                                 txtNumeroAdicao.Text.Trim, _
                                                 cboNCMAdicao.SelectedValue, _
                                                 txtValorFreteAdicao.Value, _
                                                 txtValorSeguroAdicao.Value, _
                                                 txtValorDescontoAdicao.Value, _
                                                 txtValorOutrasDespesasAdicao.Value, _
                                                 txtNumeroDrawbackAdicao.Text.Trim)

            Else

                'Atualiza Reboque
                oClsFatEmissaoNFe.UpdateDIAdicao(cboNumeroDIAdicao.SelectedValue, _
                                                 txtNumeroAdicao.Text.Trim, _
                                                 cboNCMAdicao.SelectedValue, _
                                                 txtValorFreteAdicao.Value, _
                                                 txtValorSeguroAdicao.Value, _
                                                 txtValorDescontoAdicao.Value, _
                                                 txtValorOutrasDespesasAdicao.Value, _
                                                 txtNumeroDrawbackAdicao.Text.Trim, _
                                                 btnInserirAdicao.Tag)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDIAdicao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDIAdicao = False

            'Verifica se foi Selecionado o Campo - Número da DI
            If ValidaCampo(cboNumeroDIAdicao, lblNumeroDIAdicao) = False Then
                tabDados.SelectedTab = pagDIAdicao
                cboNumeroDIAdicao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número da Adição
            If ValidaCampo(txtNumeroAdicao, lblNumeroAdicao, TipoCampo.numero) = False Then
                tabDados.SelectedTab = pagDIAdicao
                txtNumeroAdicao.Focus()
                Exit Function
            End If

            'Verifica se foi o Número da DI Informado é Válido
            If oClsFatEmissaoNFe.ValidaDIAdicao(cboNumeroDIAdicao.SelectedValue, _
                                                txtNumeroAdicao.Text.Trim, _
                                                IIf(IsNumeric(btnInserirAdicao.Tag), btnInserirAdicao.Tag, -1)) = False Then
                'Informa esse Número de Adição já está informada
                frmMain.errInfo.SetError(lblNumeroAdicao, "Este Número de Adição: " & txtNumeroAdicao.Text & " já está associada a um outro Registro.")
                tabDados.SelectedTab = pagDIAdicao
                txtNumeroAdicao.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Código NCM
            If ValidaCampo(cboNCMAdicao, lblNCMAdicao) = False Then
                tabDados.SelectedTab = pagDIAdicao
                cboNCMAdicao.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDIAdicao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO :::"

    Private Sub LoadGridProduto()

        Try

            'Carrega Dados do Produto
            Call oClsFatEmissaoNFe.LoadGridProduto(oClsFatEmissaoNFe.CodigoEmissaoCapa, grdProduto)

            'Carrega Dados da FCI
            Call oClsFatEmissaoNFe.LoadGridProdutoFCI(oClsFatEmissaoNFe.CodigoEmissaoCapa, grdFCI)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirProduto()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoNFe.DeleteProduto()

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

    Private Sub InsertProduto()

        Try

            'Verifica se foi Selecionado o Campo - Tipo do Documento
            If ValidaCampo(cboTipoDocumento, lblTipoDocumento) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Finalidade de Emissão
            If ValidaCampo(cboFinalidadeEmissao, lblFinalidadeEmissao) = False Then
                tabDados.SelectedTab = pagDadosNFe
                Exit Sub
            End If

            'Verifica se foi Preenchido as Notas Fiscais Referênciadas
            If cboFinalidadeEmissao.SelectedValue <> CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                If grdNFReferenciada.GetDataRows.Count = 0 Then
                    frmMain.Informacao(Mensagem.ValidacaoInserir)
                    tabNFe.SelectedTab = pagNFReferenciada
                    tabDados.SelectedTab = pagDadosNFe
                    Exit Sub
                End If
            End If

            'Verifica se foi Selecionado o Campo - Destinatário
            If ValidaCampo(cboDestinatario, lblDestinatario) = False Then
                tabDados.SelectedTab = pagDestinatario
                Exit Sub
            End If

            'Verifica se foi Informado alguma DI
            If cboUFDestinatario.SelectedValue = "EX" And cboTipoDocumento.SelectedValue = CInt(TipoDocumentoFiscal.Entrada) Then

                'Verifica se foi Informado alguma DI
                If grdDI.GetDataRows.Count = 0 Then
                    frmMain.Informacao(Mensagem.ValidacaoInserir)
                    tabDados.SelectedTab = pagDIAdicao
                    Exit Sub
                End If

            End If

            'Váriavel - Formulário de Cadastro de Produto
            Dim oForm As New frmFatEmissaoNFeProduto

            'Seta Parametros
            oForm.CodigoTipoDocumentoFiscal = cboTipoDocumento.SelectedValue
            oForm.CodigoFinalidadeEmissaoNFe = cboFinalidadeEmissao.SelectedValue
            oForm.RowNFReferenciada = grdNFReferenciada.GetDataRows
            oForm.CodigoParceiroNegocio = cboDestinatario.SelectedValue
            oForm.UFDestinatario = cboUFDestinatario.Text
            oForm.CodigoEmissaoItem = -1
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.CodigoRegimeTributario = goEmitente.iRegimeTributario
            oForm.AllowSave = btnSalvar.Enabled

            'Verifica se ja foi Incluido algum Item
            If grdProduto.GetDataRows.Count > 0 Then
                'Seta Parametros
                Dim oRow() As GridEXRow = grdProduto.GetDataRows
                oForm.CFOP = oRow(UBound(oRow)).Cells("codigo_cfop").Value
                oForm.SituacaoTributariaICMS = oRow(UBound(oRow)).Cells("situacao_tributaria_icms").Value
                oForm.SituacaoTributariaIPI = oRow(UBound(oRow)).Cells("situacao_tributaria_ipi").Value
                oForm.SituacaoTributariaPIS = oRow(UBound(oRow)).Cells("situacao_tributaria_pis").Value
                oForm.SituacaoTributariaCOFINS = oRow(UBound(oRow)).Cells("situacao_tributaria_cofins").Value
            End If

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Atualiza Dados do Item
            If cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                Call oClsFatEmissaoNFe.AtualizaDadosProduto(txtTotalFrete.Value, _
                                                            txtTotalSeguro.Value, _
                                                            txtOutrasDespesas.Value)
            End If

            'Carrega Grid de Produto
            Call LoadGridProduto()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEmissaoNFeProduto

            'Seta Parâmetros
            oForm.CodigoTipoDocumentoFiscal = cboTipoDocumento.SelectedValue
            oForm.CodigoFinalidadeEmissaoNFe = cboFinalidadeEmissao.SelectedValue
            oForm.CodigoEmissaoItem = grdProduto.CurrentRow.Cells("codigo_emissao_item").Value
            oForm.RowNFReferenciada = grdNFReferenciada.GetDataRows
            oForm.CodigoParceiroNegocio = cboDestinatario.SelectedValue
            oForm.UFDestinatario = cboUFDestinatario.Text
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.CodigoRegimeTributario = goEmitente.iRegimeTributario
            oForm.AllowSave = btnSalvar.Enabled
            oForm.CodigoTipoOperacao = grdProduto.CurrentRow.Cells("codigo_tipo_operacao").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Atualiza Dados do Item
            If cboFinalidadeEmissao.SelectedValue = CInt(FinalidadeEmissaoNFe.NFeNormal) Then
                Call oClsFatEmissaoNFe.AtualizaDadosProduto(txtTotalFrete.Value, _
                                                            txtTotalSeguro.Value, _
                                                            txtOutrasDespesas.Value)
            End If

            'Carrega Grid de Produto
            Call LoadGridProduto()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EstoqueProduto()

        Try

            'Verifica se foi Selecionado o Tipo de Documento
            If ValidaCampo(cboTipoDocumento, lblTipoDocumento) = False Then
                tabDados.SelectedTab = pagDadosNFe
                tabNFe.SelectedTab = pagDadosCapa
                cboTipoDocumento.Focus()
                Exit Sub
            End If

            'Verifica se o Item Controla Lote
            If grdProduto.CurrentRow.Cells("item_estoque").Value = True Then

                'Váriaveis Locais
                Dim oForm As New frmFatEmissaoNFeProdutoEstoque

                'Seta Parâmetros
                oForm.CodigoTipoDocumentoFiscal = cboTipoDocumento.SelectedValue
                oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
                oForm.CodigoEmissaoItem = grdProduto.CurrentRow.Cells("codigo_emissao_item").Value
                oForm.Produto = grdProduto.CurrentRow.Cells("codigo_produto").Value & " - " & grdProduto.CurrentRow.Cells("descricao").Value
                oForm.CodigoItem = grdProduto.CurrentRow.Cells("codigo_item").Value
                oForm.CodigoEmitente = IIf(cboDestinatario.SelectedIndex = -1, -1, cboDestinatario.SelectedValue)
                oForm.Quantidade = grdProduto.CurrentRow.Cells("quantidade").Value
                oForm.ControlaLote = grdProduto.CurrentRow.Cells("controla_lote").Value
                oForm.CodigoCFOP = grdProduto.CurrentRow.Cells("codigo_cfop").Value
                oForm.UnidadeMedidaNF = grdProduto.CurrentRow.Cells("unidade_medida").Value
                oForm.UnidadeMedidaEstoque = grdProduto.CurrentRow.Cells("unidade_medida_estoque").Value
                oForm.Importacao = IIf((grdProduto.GetValue("cfop").ToString.Substring(0, 1)) = "3", True, False)
                oForm.AllowSave = btnSalvar.Enabled
                oForm.ShowDialog(Me)

                'Carrega Grid de Produto
                LoadGridProduto()

            Else
                'Informa o Usuário que o Item não Controla Estoque
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Inserido algum Item
            If grdProduto.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir)
                tabDados.SelectedTab = pagProduto
                btnInserirItem.Focus()
                Exit Function
            End If

            'Valida Dados do Produto
            For Each oRow As GridEXRow In grdProduto.GetDataRows

                'Valida Dados do ICMS
                Select Case oRow.Cells("situacao_tributaria_icms").Value

                    'Case "00"
                    '    'Valida a Modalidade da Base de Calculo do ICMS
                    '    If IsDBNull(oRow.Cells("modalidade_base_calculo_icms").Value) Then
                    '        frmMain.Informacao("O Campo [Modalidade de Determinação da Base de Cálculo do ICMS] é obrigatório. Selecione um valor para ele.", gColorInformacaoErro)
                    '        tabDados.SelectedTab = pagProduto
                    '        Exit Function
                    '    End If

                    '    'Valida o Valor da Base de Cálculo do ICMS
                    '    If IsDBNull(oRow.Cells("base_calculo_icms").Value) Then
                    '        frmMain.Informacao("O Campo [Valor da Base de Cálculo do ICMS] é obrigatório. Preencha um valor para ele e Verifique a Regra de Imposto Cadastrado em ""Imposto / Regra do ICMS"".", gColorInformacaoErro)
                    '        tabDados.SelectedTab = pagProduto
                    '        Exit Function
                    '    End If

                    '    'Valida o Valor da Base de Cálculo do ICMS
                    '    If IsDBNull(oRow.Cells("aliquota_icms").Value) Then
                    '        frmMain.Informacao("O Campo [Alíquota do ICMS] é obrigatório. Preencha um valor para ele e Verifique a Regra de Imposto Cadastrado em ""Imposto / Regra do ICMS"".", gColorInformacaoErro)
                    '        tabDados.SelectedTab = pagProduto
                    '        Exit Function
                    '    End If

                End Select

            Next

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: FCI :::"

    Private Sub GerarFCI()

        Try

            'Verificando se foi selecionado algum registro
            If VerificaSelecaoRow(grdFCI, "pendente", "0") = False Then
                'Informa o Usuário sobre a Necessidade de Selecionar Registros Válidos
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

            'Instanciando o componente para abrir o arquivo
            Dim oSaveFileDialog As New SaveFileDialog

            oSaveFileDialog.Filter = "(Arquivo txt)|*.txt"
            oSaveFileDialog.Title = "Selecione o Arquivo"

            'Verificnado se foi selecionado o "OK"
            If oSaveFileDialog.ShowDialog <> DialogResult.OK Then Exit Sub

            Dim sCodigoEmissaoItem As String = ""

            For Each oRow As GridEXRow In gSelecaoRow
                sCodigoEmissaoItem &= IIf(sCodigoEmissaoItem = "", "", ",") & oRow.Cells("codigo_emissao_item").Value
            Next

            'Gerando o Arquivo
            Call oClsFatEmissaoNFe.GerarFCI(btnSalvar.Tag, sCodigoEmissaoItem, oSaveFileDialog.FileName)

            'Informando ao usuário
            frmMain.Informacao(modDeclaration.Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarArquivoRetorno()

        Try


            'Instanciando o componente para abrir o arquivo
            Dim oOpenFileDialog As New OpenFileDialog

            oOpenFileDialog.Filter = "(Arquivo TXT)|*.TXT"
            oOpenFileDialog.Title = "Selecione o Arquivo para Importar"

            'Verificnado se foi selecionado o "OK"
            If oOpenFileDialog.ShowDialog <> DialogResult.OK Then Exit Sub

            'Instancia um dataset
            Dim oDataSet As New DataSet

            'Gerando o Arquivo
            Call oClsFatEmissaoNFe.LoadDadosFCI(oDataSet, oOpenFileDialog.FileName)

            'Salva o arquivo
            Call oClsFatEmissaoNFe.InsertFCI(btnSalvar.Tag, oDataSet)

            'Informa ao usuário
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Carrega novamente a grid
            oClsFatEmissaoNFe.LoadGridProdutoFCI(btnSalvar.Tag, grdFCI)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TRANSPORTE :::"

#Region "::: TRANSPORTADORA :::"

    Private Sub SalvarTransporte()

        Try

            'Seta Parametros            
            oClsFatEmissaoNFe.CodigoModalidadeFrete = cboModalidadeFrete.SelectedValue
            oClsFatEmissaoNFe.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsFatEmissaoNFe.RazaoSocialTransportadora = IIf(cboTransportadora.SelectedIndex = -1, "", cboTransportadora.Text)
            oClsFatEmissaoNFe.CnpjCpfTransportadora = txtCNPJTransportadora.Text.Trim
            oClsFatEmissaoNFe.InscricaoEstadualTransportadora = txtInscricaoEstadualTransportadora.Text.Trim
            oClsFatEmissaoNFe.UFTransportadora = cboUFTransportadora.SelectedValue
            oClsFatEmissaoNFe.MunicipioTransportadora = cboMunicipioTransportadora.Text
            oClsFatEmissaoNFe.EnderecoTransportadora = txtEnderecoTransportadora.Text.Trim
            oClsFatEmissaoNFe.BaseCalculoTransporte = txtBaseCalculoTransporte.Value
            oClsFatEmissaoNFe.AliquotaICMSTransporte = txtAliquotaTransporte.Value
            oClsFatEmissaoNFe.ValorServicoTransporte = txtValorServicoTransporte.Value
            oClsFatEmissaoNFe.ValorICMSRetidoTransporte = txtICMSRetidoTransporte.Text.Trim
            oClsFatEmissaoNFe.TipoVeiculo = IIf(cboTipoVeiculo.SelectedIndex = -1, -1, cboTipoVeiculo.SelectedValue)
            oClsFatEmissaoNFe.UFICMSTransporte = IIf(cboUFICMSTransporte.SelectedIndex = -1, "", cboUFICMSTransporte.SelectedValue)
            oClsFatEmissaoNFe.CodigoMunicipioICMSTransporte = IIf(cboMunicipioICMSTransporte.SelectedIndex = -1, -1, cboMunicipioICMSTransporte.SelectedValue)
            oClsFatEmissaoNFe.CodigoCFOPTransporte = IIf(cboCFOPICMSTransporte.SelectedIndex = -1, -1, cboCFOPICMSTransporte.Text)
            oClsFatEmissaoNFe.UFPlacaVeiculo = IIf(cboUFVeiculo.SelectedIndex = -1, "", cboUFVeiculo.SelectedValue)
            oClsFatEmissaoNFe.PlacaVeiculo = txtPlacaVeiculo.Text.Trim
            oClsFatEmissaoNFe.RNTCVeiculo = txtRNTCVeiculo.Text.Trim
            oClsFatEmissaoNFe.Vagao = txtVagao.Text.Trim
            oClsFatEmissaoNFe.Balsa = txtBalsa.Text.Trim

            'Salva Dados Transporte
            oClsFatEmissaoNFe.DeleteTransporte()
            oClsFatEmissaoNFe.InsertTransporte()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: REBOQUE :::"

    Private Sub EditarReboque()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcUpdate) = True Then

                'Carrega Controles
                txtPlacaReboque.Text = grdReboque.CurrentRow.Cells("placa").Value
                cboUFReboque.SelectedValue = grdReboque.CurrentRow.Cells("uf").Value
                txtRNTCReboque.Text = grdReboque.CurrentRow.Cells("rntc").Value
                btnInserirReboque.Tag = grdReboque.CurrentRow.Cells("placa").Value

                'Seta Valor
                txtPlacaReboque.Focus()

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirReboque()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdReboque) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoNFe.DeleteReboque()

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

    Private Sub LoadGridReboque()

        Try

            'Carrega Grid
            oClsFatEmissaoNFe.LoadGridReboque(grdReboque)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoReboque()

        Try

            'Limpa Controles
            txtPlacaReboque.Text = ""
            cboUFReboque.SelectedIndex = -1
            txtRNTCReboque.Text = ""
            btnInserirReboque.Tag = ""

            'Seta Focu
            txtPlacaReboque.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarReboque()

        Try

            'Verifica o Tipo de Operação
            If btnInserirReboque.Tag = "" Then

                'Insere Reboque
                oClsFatEmissaoNFe.InsertReboque(txtPlacaReboque.Text.Trim, _
                                                cboUFReboque.SelectedValue, _
                                                txtRNTCReboque.Text.Trim)


            Else

                'Atualiza Reboque
                oClsFatEmissaoNFe.UpdateReboque(txtPlacaReboque.Text.Trim, _
                                               cboUFReboque.SelectedValue, _
                                               txtRNTCReboque.Text.Trim, _
                                               btnInserirReboque.Tag)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoReboque() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoReboque = False

            'Verifica se foi Preenchido o Campo - Placa
            If ValidaCampo(txtPlacaReboque, lblPlacaReboque, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagTransporte
                tabTransporte.SelectedTab = pagVeiculo
                txtPlacaReboque.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFReboque, lblUFReboque) = False Then
                tabDados.SelectedTab = pagTransporte
                tabTransporte.SelectedTab = pagVeiculo
                cboUFReboque.Focus()
                Exit Function
            End If

            'Verifica se foi a Nota Fiscal é Válida
            If oClsFatEmissaoNFe.ValidaReboque(txtPlacaReboque.Text, _
                                              IIf(btnInserirReboque.Tag = "", "", btnInserirReboque.Tag)) = False Then
                'Informa essa Placa já está associada a um outro Cliente
                frmMain.errInfo.SetError(lblPlacaReboque, "Esta Placa: " & txtPlacaReboque.Text & " já está associada a um outro Registro.")
                tabDados.SelectedTab = pagTransporte
                tabTransporte.SelectedTab = pagVeiculo
                txtPlacaReboque.Focus()
                Exit Function
            End If

            'Verifica se já possui mais de 5 registros
            If btnInserirReboque.Tag = "" Then
                If grdReboque.GetDataRows.Count = 5 Then
                    'Informa essa Placa já está associada a um outro Cliente
                    frmMain.errInfo.SetError(lblPlacaReboque, "Já foi inserido o número máximo de Registros.")
                    tabDados.SelectedTab = pagTransporte
                    tabTransporte.SelectedTab = pagVeiculo
                    txtPlacaReboque.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoReboque = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: VOLUME :::"

    Private Sub EditarVolume()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcUpdate) = True Then

                'Carrega Controles
                txtQuantidadeEmbalagemTransportadora.Value = grdVolume.CurrentRow.Cells("quantidade_embalagem").Value
                txtEspecieTransportadora.Text = grdVolume.CurrentRow.Cells("especie").Value
                txtMarcaTransportadora.Text = grdVolume.CurrentRow.Cells("marca").Value
                txtNumeroTransportadora.Text = grdVolume.CurrentRow.Cells("numero").Value
                txtPesoLiquidoTransportadora.Value = grdVolume.CurrentRow.Cells("peso_liquido").Value
                txtPesoBrutoTransportadora.Value = grdVolume.CurrentRow.Cells("peso_bruto").Value
                btnInserirVolume.Tag = grdVolume.CurrentRow.Cells("codigo").Value

                'Seta Focu
                txtQuantidadeEmbalagemTransportadora.Focus()

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LacreVolume()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmFatEmissaoNFeVolumeLacre

            'Seta Parâmetros
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.CodigoEmissaoTransporteVolume = grdVolume.CurrentRow.Cells("codigo").Value
            oForm.AllowSave = btnSalvar.Enabled

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirVolume()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdVolume) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoNFe.DeleteVolume()

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

    Private Sub LoadGridVolume()

        Try

            'Carrega Grid
            oClsFatEmissaoNFe.LoadGridVolume(grdVolume)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoVolume()

        Try

            'Limpa Controles
            txtQuantidadeEmbalagemTransportadora.Value = 0
            txtEspecieTransportadora.Text = ""
            txtMarcaTransportadora.Text = ""
            txtNumeroTransportadora.Text = ""
            txtPesoLiquidoTransportadora.Value = 0
            txtPesoBrutoTransportadora.Value = 0
            btnInserirVolume.Tag = ""

            'Seta Focu
            txtQuantidadeEmbalagemTransportadora.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarVolume()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirVolume.Tag) = False Then

                'Insere Reboque
                oClsFatEmissaoNFe.InsertVolume(txtQuantidadeEmbalagemTransportadora.Value, _
                                               txtEspecieTransportadora.Text.Trim, _
                                               txtMarcaTransportadora.Text.Trim, _
                                               txtNumeroTransportadora.Text.Trim, _
                                               txtPesoLiquidoTransportadora.Value, _
                                               txtPesoBrutoTransportadora.Value)


            Else

                'Atualiza Reboque
                oClsFatEmissaoNFe.UpdateVolume(txtQuantidadeEmbalagemTransportadora.Value, _
                                              txtEspecieTransportadora.Text.Trim, _
                                              txtMarcaTransportadora.Text.Trim, _
                                              txtNumeroTransportadora.Text.Trim, _
                                              txtPesoLiquidoTransportadora.Value, _
                                              txtPesoBrutoTransportadora.Value, _
                                              btnInserirVolume.Tag)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: NOTA FISCAL ELETRÔNICA :::"
    Private Sub btnDANFEConferencia_Click(sender As Object, e As EventArgs) Handles btnDANFEConferencia.Click
        Try
            ImprimirDanfeConferencia(oClsFatEmissaoNFe.CodigoEmissaoCapa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Function ValidacaoNFe(Optional ByVal sTipo As String = "P") As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoNFe = False

            'Carrega Configuração da NFe
            If LoadConfiguracaoNFe() = False Then
                'Informa o Usuário que não existe configuração de Nota Fiscal Eletrônica cadastrada
                frmMain.Informacao(Mensagem.NaoFoiInformado, "a Configuração da NFe")
                Exit Function
            Else
                'Seta Ambiente - NFe
                Select Case goConfiguracaoNFe.iCodigoTipoAmbienteNFe
                    Case TipoAmbienteNFe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                    Case TipoAmbienteNFe.producao : lblAmbiente.Text = "** Ambiente de Produção"
                End Select
            End If

            'Verifica se o Serviço está ativo
            If sTipo <> "S" Then

                'Verifica se a Pasta de Entrada Existe
                If Directory.Exists(goConfiguracaoNFe.sPastaEntrada) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaEntrada)
                    Exit Function
                End If

                'Verifica se a Pasta de Envio Existe
                If Directory.Exists(goConfiguracaoNFe.sPastaEnvio) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaEnvio)
                    Exit Function
                End If

                'Verifica se a Pasta de Impressão Existe
                If Directory.Exists(goConfiguracaoNFe.sPastaImpressao) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaImpressao)
                    Exit Function
                End If

                'Verifica se a Pasta de Recibo Existe
                If Directory.Exists(goConfiguracaoNFe.sPastaRecibo) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaRecibo)
                    Exit Function
                End If

                'Verifica se a Pasta de Saída Existe
                If Directory.Exists(goConfiguracaoNFe.sPastaSaida) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaSaida)
                    Exit Function
                End If

                'Verifica se a Pasta XSD Existe
                If Directory.Exists(goConfiguracaoNFe.sPastaXSD) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaXSD)
                    Exit Function
                End If

            End If

            'Valida Produto
            Dim sMensagem As String = ""
            If oClsFatEmissaoNFe.ValidaProduto(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                                               sMensagem) = False Then
                'Informa o Usuário sobre o problema do Estoque
                MsgBox(sMensagem, MsgBoxStyle.Exclamation, "Validação")
                Exit Function
            End If

            ''Verifica se o Serviço está ativo
            'If sTipo <> "S" Then
            '    If ValidaServico() = False Then
            '        Exit Function
            '    End If
            'End If

            'Valida Parceiro de Negócio
            Dim dValor As Double = CType(LoadDescricao("sp_validate_faturamento_emissao_destinatario " & cboDestinatario.SelectedValue & ", " & goUsuario.iEmpresa), Double)
            If dValor > 0 Then
                If MsgBox("O Cliente: " & cboDestinatario.Text & " possui Títulos em Atraso no valor de R$ " & FormatNumber(dValor, 2, Microsoft.VisualBasic.TriState.True) & ". Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoNFe = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

    Private Sub TransmitirLote()

        'Váriaveis Locais
        Dim oClsNFeRecepcaoLote As New clsNFeRecepcaoLote_V4

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Gera Número da Nota Fiscal
            If txtNotaFiscal.Text = "" Then
                txtNotaFiscal.Text = oClsFatEmissaoNFe.GeraNumeroNotaFiscal
            End If

            'Gera Número do Lote
            txtLote.Text = oClsFatEmissaoNFe.GeraNumeroLote

            'Seta Parâmetros - Lote
            oClsNFeRecepcaoLote.Lote = CLng(txtLote.Text)

            System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12
            'Transmite Arquivo
            If oClsNFeRecepcaoLote.Send() = True Then

                'Carrega Arquivo
                oClsNFeRecepcaoLote.LoadArquivo(oClsNFeRecepcaoLote.PathArquivoRetorno)

                'Caso o Status Lote Recebido com Sucesso
                If oClsNFeRecepcaoLote.Status = 103 Then

                    'Atualiza Dados da NFe
                    oClsFatEmissaoNFe.UpdateNFeEnvio(oClsNFeRecepcaoLote.Motivo, _
                                                     oClsNFeRecepcaoLote.ChaveAcesso, _
                                                     oClsNFeRecepcaoLote.Recibo, _
                                                     oClsNFeRecepcaoLote.ArquivoEnvio, _
                                                     oClsNFeRecepcaoLote.ArquivoRetorno, _
                                                     CLng(txtLote.Text), _
                                                     goConfiguracaoNFe.iCodigoTipoAmbienteNFe)

                    'Seta Controles
                    txtStatusNFe.Text = "AGUARDANDO RETORNO"
                    txtStatusNFe.Tag = StatusNotaFiscalEletronica.AguardandoRetorno
                    txtMensagemSefaz.Text = oClsNFeRecepcaoLote.Motivo
                    txtChaveAcesso.Text = oClsNFeRecepcaoLote.ChaveAcesso
                    txtRecibo.Text = oClsNFeRecepcaoLote.Recibo

                    'Verifica Status
                    Call VerificaStatus(StatusNotaFiscalEletronica.AguardandoRetorno)

                End If

            Else

                'Seta Chave de Acesso
                txtChaveAcesso.Text = oClsNFeRecepcaoLote.ChaveAcesso
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsNFeRecepcaoLote.MensagemErro)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RetornarLote()

        'Váriaveis Locais
        Dim oClsNFeConsultaRecepcaoNFe As New clsNFeConsultaRecepcaoNFe_V4

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmetros
            oClsNFeConsultaRecepcaoNFe.Recibo = txtRecibo.Text.Trim
            oClsNFeConsultaRecepcaoNFe.Lote = txtLote.Text.Trim

            'Consulta Situação
            If oClsNFeConsultaRecepcaoNFe.Send() = True Then

                'Carrega Arquivo
                oClsNFeConsultaRecepcaoNFe.LoadArquivo(oClsNFeConsultaRecepcaoNFe.PathArquivoRetorno)

                'Verifica se foi o Arquivo está aceito
                If oClsNFeConsultaRecepcaoNFe.Status = 104 Then

                    'Váriavel - Protocolo
                    Dim oProtocoloNFe As InformacaoProtocoloNFe

                    For i = 0 To UBound(oClsNFeConsultaRecepcaoNFe.ProtocoloNFe)

                        oProtocoloNFe = oClsNFeConsultaRecepcaoNFe.ProtocoloNFe(i)

                        'Atualiza Nota Fiscal
                        oClsFatEmissaoNFe.UpdateNFeRetorno(oProtocoloNFe.sMotivo, _
                                                           oProtocoloNFe.sChaveAcesso, _
                                                           oProtocoloNFe.sNumeroProtocolo, _
                                                           IIf(oProtocoloNFe.iStatus = 100, CInt(StatusNotaFiscalEletronica.AutorizadaUso), CInt(StatusNotaFiscalEletronica.Rejeitada)), _
                                                           oClsNFeConsultaRecepcaoNFe.ArquivoRetornoXML)

                        Select Case oProtocoloNFe.iStatus

                            Case 100
                                'Seta Controles
                                txtStatusNFe.Text = "AUTORIZADA PARA USO"
                                txtStatusNFe.Tag = StatusNotaFiscalEletronica.AutorizadaUso
                                'Executa Integração
                                Call Integracao()

                               

                                Try

                                    If goDatabase.sInitialCatalog <> "INTERACTI_MAGMA_PRD" Then

                                        Dim sCaminho As String

                                        Select Case goDatabase.sInitialCatalog
                                            Case "INTERACTI_SOBERANO_PRD" : sCaminho = "\\192.168.0.150\interacti\soberano\SCI\EMISSAO"
                                            Case "INTERACTI_ISSARTEL_PRD" : sCaminho = "\\servidor01\INTERACTI\SCI\EMISSAO"
                                            Case "INTERACTI_EMG_PRD" : sCaminho = "0"
                                            Case "INTERACTI_KUARUPNAUTICA_PRD" : sCaminho = "0"
                                            Case Else : sCaminho = "0"
                                        End Select

                                        Call ExportarXML(oClsFatEmissaoNFe.CodigoEmissaoCapa, sCaminho)

                                    End If

                                Catch ex As Exception

                                End Try

                            Case 539
                                'Obtém Número do Recibo
                                Dim sNumeroRecibo As String = oProtocoloNFe.sMotivo.Substring(oProtocoloNFe.sMotivo.IndexOf("[nRec:") + 6, 15)
                                'Obtém Chave de Acessl
                                Dim sChaveAcesso As String = oProtocoloNFe.sMotivo.Substring(oProtocoloNFe.sMotivo.IndexOf("[chNFe:") + 7, 44)

                                'Atualiza tb_fat_emissao_capa
                                oClsFatEmissaoNFe.UpdateNFeEnvioDuplicidade(txtChaveAcesso.Text.Trim, _
                                                                            sChaveAcesso, _
                                                                            sNumeroRecibo, _
                                                                            goConfiguracaoNFe.iCodigoTipoAmbienteNFe)
                                'Seta Controles
                                txtRecibo.Text = sNumeroRecibo
                                txtChaveAcesso.Text = sChaveAcesso

                            Case Else
                                'Seta Controle
                                txtStatusNFe.Text = "REJEITADA"
                                txtStatusNFe.Tag = StatusNotaFiscalEletronica.Rejeitada

                        End Select

                        'Seta Controle
                        txtMensagemSefaz.Text = oProtocoloNFe.sMotivo
                        txtProtocolo.Text = oProtocoloNFe.sNumeroProtocolo

                        'Verifica Status
                        Call VerificaStatus(txtStatusNFe.Tag)

                    Next

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oClsNFeConsultaRecepcaoNFe.Motivo)
                    txtStatusNFe.Text = oClsNFeConsultaRecepcaoNFe.Motivo
                    txtStatusNFe.Tag = StatusNotaFiscalEletronica.Rejeitada

                    'Verifica Status
                    Call VerificaStatus(txtStatusNFe.Tag)
                End If

            Else

                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaRecepcaoNFe.MensagemErro)

            End If

            oClsFatEmissaoNFe.EnviarEmailEmissaoNF(txtChaveAcesso.Text.Trim)
            oClsFatEmissaoNFe.EnviarEmailEmissaoNFLogistica(txtChaveAcesso.Text.Trim)
            oClsFatEmissaoNFe.AtualizarStatusOp(txtChaveAcesso.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

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

    Private Sub ImprimirDanfeConferencia(ByVal sCodigoEmissaoCapa As String)

        Try

            'Verifica se o Usuário tem Direito de Imprimir Danfe
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Dim iTipoDocumentoFiscal As TipoDocumentoFiscal


                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
                goCrystalReport.sReportParameter(0).sValue = sCodigoEmissaoCapa
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000003_conferencia.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill


                frmMain.LoadPageReport("FAT000000003", "DANFE (Conferencia) - Documento Auxiliar de Nota Fiscal Eletrônica", oReport)


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

    Private Sub CancelarNFe(ByVal lCodigoEmissaoCapa As Long, _
                            ByVal iStatus As Integer)

        Try

            'Verifica se o Usuário tem Direito de Cancelar a Nota Fiscal
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcAdministrator) = True Then

                'Verifica o Status da Nota Fiscal
                If iStatus = CInt(StatusNotaFiscalEletronica.AutorizadaUso) Or iStatus = CInt(StatusNotaFiscalEletronica.EnviadoDestinatario) Then

                    'Verifica se está com tempo Hábil
                    'If ((grdListagem.CurrentRow.Cells("codigo_tipo_documento_fiscal").Value = TipoDocumentoFiscal.Saida Or _
                    '     grdListagem.CurrentRow.Cells("codigo_tipo_documento_fiscal").Value = TipoDocumentoFiscal.Entrada) And DateDiff(DateInterval.Hour, grdListagem.CurrentRow.Cells("data_emissao").Value, Now.Date) >= QuantidadeMaximaHorasCancelamentoNFe) Then

                    'Informa que a Operação não pode ser realizada
                    'frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O tempo limite para esse tipo de operação se esgotou.")

                    'Else

                    'Váriavel - Formulário
                    Dim oForm As New frmFatEmissaoNFeCancelar

                    'Seta Paramentros
                    oForm.Grid = grdListagem
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Recarrega Grid
                    Call LoadGrid()

                    'End If

                Else
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

    Private Sub CartaCorrecao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Formulário - Carta de Correção
            Dim oForm As New frmFatEmissaoNFeCartaCorrecao

            'Seta Paramentros
            oForm.ChaveAcesso = txtChaveAcesso.Text.Trim
            oForm.Protocolo = txtProtocolo.Text.Trim
            oForm.NotaFiscal = txtNotaFiscal.Text.Trim
            oForm.Serie = cboSerie.Text
            oForm.DataEmissao = dtpDataEmissao.Value
            oForm.CodigoEmissaoCapa = oClsFatEmissaoNFe.CodigoEmissaoCapa
            oForm.CodigoParceiroNegocio = cboDestinatario.SelectedValue

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailNFe(ByVal lCodigoEmissaoCapa As Long, _
                         ByVal iStatus As Integer)

        Try

            'Verifica o Status
            If iStatus = CInt(StatusNotaFiscalEletronica.AutorizadaUso) Or _
               iStatus = CInt(StatusNotaFiscalEletronica.EnviadoDestinatario) Or _
               iStatus = CInt(StatusNotaFiscalEletronica.Cancelada) Then

                'Carrega Dados do Emitente
                Call LoadDadosEmitente()

                'Carrega Configurações da NFe
                Call LoadConfiguracaoNFe()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument
                Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
                Dim sArquivoEnvio As String = ""
                Dim sArquivoBoleto As String = ""
                Dim sMensagemErro As String = ""
                Dim sArquivoNFe As String = ""
                Dim sArquivoProtocoloNFe As String = ""
                Dim sArquivoCancelamentoNFe As String = ""
                Dim sArquivoProtocoloCancelamentoNFe As String = ""
                Dim sNotaFiscal As String = ""
                Dim sChaveAcesso As String = ""
                Dim lCodigoParceiroNegocio As Long
                Dim lCodigoTituloCapa As Long

                'Carrega Dados da NF-e
                oClsFatEmissaoNFe.LoadDadosNFe(lCodigoEmissaoCapa, _
                                              sArquivoNFe, _
                                              sArquivoProtocoloNFe, _
                                              sArquivoCancelamentoNFe, _
                                              sArquivoProtocoloCancelamentoNFe, _
                                              sChaveAcesso, _
                                              sNotaFiscal, _
                                              lCodigoParceiroNegocio, _
                                              lCodigoTituloCapa)

                'Verifica se foi possível gerar o Arquivo
                If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                  sArquivoProtocoloNFe, _
                                                  sChaveAcesso, _
                                                  sArquivoEnvio, _
                                                  sMensagemErro) = True Then

                    'Abre Relatório
                    oRptDocument.Load(goCrystalReport.sPath & LoadDescricao("sp_select_faturamento_emissao_relatorio_danfe " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                    'Seta Parametros Relatório
                    oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
                    oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                    'Abre Conexão com o Banco de Dados
                    For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                        oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                    Next

                    'Váriavel Relatório
                    Dim sArquivoReport As String = goConfiguracaoNFe.sPastaImpressao & sNotaFiscal & ".pdf"

                    'Verifica se o Arquivo Existe
                    If File.Exists(sArquivoReport) = True Then File.Delete(sArquivoReport)

                    'Exporta para Arquivo PDF
                    oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

                    'Limpa Váriavel
                    oRptDocument = Nothing

                    'Boleto Bancário
                    If lCodigoTituloCapa > 0 Then
                        'Váriavel - Boleto
                        Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
                        'Carrega Boleto
                        oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNotaFiscal, sArquivoBoleto)
                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    If goUsuario.sEmpresa = "LH COLUS TECNOLOGIA LTDA EPP" Then

                        Dim sCorpo As String = ""
                        sCorpo = "Prezado cliente, " & vbNewLine
                        sCorpo &= vbNewLine & "Você está recebendo a Nota Fiscal Eletrônica número " & txtNotaFiscal.Text & ", série " & cboSerie.Text & " de " & goUsuario.sEmpresa & ", " & vbNewLine
                        sCorpo &= "no valor de R$ " & txtTotalNotaFiscal.Value & ". Além disso, junto com a mercadoria seguirá o DANFE (Documento Auxiliar da Nota Fiscal Eletrônica), impresso em papel que acompanha o transporte das mesmas." & vbNewLine
                        sCorpo &= "Anexo à este e-mail você está recebendo também o arquivo XML da Nota Fiscal Eletrônica. Este arquivo deve ser armazenado eletronicamente por sua empresa pelo prazo de 05 (cinco) anos, conforme previsto na legislação tributária (Art. 173 do Código Tributário Nacional e § 4º da Lei 5.172 de 25/10/1966)." & vbNewLine
                        sCorpo &= "O DANFE em papel pode ser arquivado para apresentação ao fisco quando solicitado. Todavia, se sua empresa também for emitente de NF-e, o arquivamento eletrônico do XML de seus fornecedores é obrigatório, sendo passível de fiscalização. O código chave de sua Nota Fiscal Eletrônica é " & txtChaveAcesso.Text & " e você pode consultar a autenticidade deste documento juntamente com o Fisco através do site www.nfe.fazenda.gov.br, informando o número do código chave." & vbNewLine
                        sCorpo &= vbNewLine & "INTERACTI - ACTi Consultoria " & vbNewLine
                        sCorpo &= "www.acticonsultoria.com.br"

                        'Enviar E-mail
                        Call EnviarEmail(goUsuario.sEmpresa & " - NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                                         LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         sCorpo, _
                                         lCodigoParceiroNegocio, _
                                         "", _
                                         lCodigoEmissaoCapa)
                    Else

                        'Enviar E-mail
                        Call EnviarEmail(goUsuario.sEmpresa & " - NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                                         LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         "", _
                                         lCodigoParceiroNegocio, _
                                         "", _
                                         lCodigoEmissaoCapa)


                    End If

                    'Carrega Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                End If

            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailAutomatico(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sPara As String
            Dim sBCC As String
            Dim sTexto As String
            Dim oRptDocument As New ReportDocument
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sArquivoEnvio As String = ""
            Dim sArquivoBoleto As String = ""
            Dim sMensagemErro As String = ""
            Dim sArquivoNFe As String = ""
            Dim sArquivoProtocoloNFe As String = ""
            Dim sArquivoCancelamentoNFe As String = ""
            Dim sArquivoProtocoloCancelamentoNFe As String = ""
            Dim sNotaFiscal As String = ""
            Dim sChaveAcesso As String = ""
            Dim lCodigoParceiroNegocio As Long
            Dim lCodigoTituloCapa As Long

            'Seta Váriavel
            sPara = LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa)
            sBCC = LoadDescricao("sp_select_cadastro_basico_autotexto_email_bcc " & goUsuario.iEmpresa)

            If sPara = "" Then

                'Informa o usuário que não é possível enviar o E-mail automaticamente
                MsgBox("Não foi possível enviar e-mail de forma automática. Não existe e-mail cadastrado para o Destinatário.", MsgBoxStyle.Information, Me.Parent.Text)

            Else

                'Carrega Dados da NF-e
                Call oClsFatEmissaoNFe.LoadDadosNFe(lCodigoEmissaoCapa, _
                                                    sArquivoNFe, _
                                                    sArquivoProtocoloNFe, _
                                                    sArquivoCancelamentoNFe, _
                                                    sArquivoProtocoloCancelamentoNFe, _
                                                    sChaveAcesso, _
                                                    sNotaFiscal, _
                                                    lCodigoParceiroNegocio, _
                                                    lCodigoTituloCapa, _
                                                    sTexto)

                'Verifica se foi possível gerar o Arquivo
                If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                  sArquivoProtocoloNFe, _
                                                  sChaveAcesso, _
                                                  sArquivoEnvio, _
                                                  sMensagemErro) = True Or sArquivoNFe = "" Then

                    'Abre Relatório
                    oRptDocument.Load(goCrystalReport.sPath & LoadDescricao("sp_select_faturamento_emissao_relatorio_danfe " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                    'Seta Parametros Relatório
                    oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
                    oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                    'Abre Conexão com o Banco de Dados
                    For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                        oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                    Next

                    'Váriavel Relatório
                    Dim sArquivoReport As String = System.IO.Path.GetTempPath & sNotaFiscal & ".pdf"

                    'Verifica se o Arquivo Existe
                    If File.Exists(sArquivoReport) = True Then File.Delete(sArquivoReport)

                    'Exporta para Arquivo PDF
                    oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

                    'Limpa Váriavel
                    oRptDocument = Nothing

                    'Boleto Bancário
                    If lCodigoTituloCapa > 0 Then
                        'Váriavel - Boleto
                        Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
                        'Carrega Boleto
                        oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNotaFiscal, sArquivoBoleto)
                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    'Enviar E-mail
                    Call SendEmail(sPara, _
                                   "", _
                                   sBCC, _
                                   goUsuario.sEmpresa & " - NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                                   sTexto, _
                                   sArquivoReport & IIf(sArquivoEnvio = "", "", ";" & sArquivoEnvio) & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto))

                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExportarXML(ByVal lCodigo As Long, _
                            Optional ByVal sCaminho As String = "")

        Try

            'Váriaveis Locais
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sArquivoEnvio As String = ""
            Dim sMensagemErro As String = ""
            Dim sArquivoNFe As String = ""
            Dim sArquivoProtocoloNFe As String = ""
            Dim sArquivoCancelamentoNFe As String = ""
            Dim sArquivoProtocoloCancelamentoNFe As String = ""
            Dim sNotaFiscal As String = ""
            Dim sChaveAcesso As String = ""
            Dim lCodigoParceiroNegocio As Long
            Dim lCodigoTituloCapa As Long

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados da Nota Fiscal
            oClsFatEmissaoNFe.LoadDadosNFe(lCodigo, _
                                          sArquivoNFe, _
                                          sArquivoProtocoloNFe, _
                                          sArquivoCancelamentoNFe, _
                                          sArquivoProtocoloCancelamentoNFe, _
                                          sChaveAcesso, _
                                          sNotaFiscal, _
                                          lCodigoParceiroNegocio,
                                          lCodigoTituloCapa)

            Dim oSaveFile As New SaveFileDialog

            oSaveFile.FileName = sChaveAcesso & "-nfe.xml"
            oSaveFile.Filter = "XML|*.xml"

            If sCaminho = "" Then

                If oSaveFile.ShowDialog() = DialogResult.OK Then

                    'Verifica se foi possível gerar o Arquivo
                    If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                      sArquivoProtocoloNFe, _
                                                      sChaveAcesso, _
                                                      oSaveFile.FileName, _
                                                      sMensagemErro) = False Then

                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.Erro, sMensagemErro)

                    End If

                End If

            ElseIf sCaminho <> "0" Then

                'Verifica se foi possível gerar o Arquivo
                If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                  sArquivoProtocoloNFe, _
                                                  sChaveAcesso, _
                                                  sCaminho + "\" + oSaveFile.FileName, _
                                                  sMensagemErro) = False Then

                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, sMensagemErro)

                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Private Function ValidaServico() As Boolean

    '    Try

    '        'Váriaveis Locais
    '        Dim oClsNFeStatusServico As New clsNFeStatusServico_V3

    '        'Envia Arquivo
    '        If oClsNFeStatusServico.Send() = True Then

    '            'Carrega Arquivo
    '            oClsNFeStatusServico.LoadArquivo(oClsNFeStatusServico.ArquivoRetorno)

    '            'Exclui Arquivo de Envio e Arquivo de Retorno
    '            File.Delete(oClsNFeStatusServico.ArquivoEnvio)
    '            File.Delete(oClsNFeStatusServico.ArquivoRetorno)

    '            If oClsNFeStatusServico.Status <> 107 Then
    '                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
    '                Return False
    '            End If

    '        Else
    '            frmMain.Informacao(Mensagem.Erro, oClsNFeStatusServico.MensagemErro)
    '            Return False
    '        End If

    '        'Seta Retorno da Função
    '        Return True

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function

    Private Sub SimularTransmissao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Gera Número da Nota Fiscal
            If txtNotaFiscal.Text = "" Then
                txtNotaFiscal.Text = oClsFatEmissaoNFe.GeraNumeroNotaFiscal
            End If

            'Gera Número do Lote
            txtLote.Text = oClsFatEmissaoNFe.GeraNumeroLote

            'Verifica Status
            Call VerificaStatus(txtStatusNFe.Tag)

            'Simula Emissão da Nota Fiscal
            Call oClsFatEmissaoNFe.UpdateNFeSimulacao(oClsFatEmissaoNFe.CodigoEmissaoCapa)

            'Simula Integração
            Call Integracao()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailNFe1(ByVal lCodigoEmissaoCapa As Long, _
                         ByVal iStatus As Integer)

        Try

            'Verifica o Status
            If iStatus = CInt(StatusNotaFiscalEletronica.AutorizadaUso) Or _
               iStatus = CInt(StatusNotaFiscalEletronica.EnviadoDestinatario) Or _
               iStatus = CInt(StatusNotaFiscalEletronica.Cancelada) Then

                'Carrega Dados do Emitente
                Call LoadDadosEmitente()

                'Carrega Configurações da NFe
                Call LoadConfiguracaoNFe()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument
                Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
                Dim sArquivoEnvio As String = ""
                Dim sArquivoBoleto As String = ""
                Dim sMensagemErro As String = ""
                Dim sArquivoNFe As String = ""
                Dim sArquivoProtocoloNFe As String = ""
                Dim sArquivoCancelamentoNFe As String = ""
                Dim sArquivoProtocoloCancelamentoNFe As String = ""
                Dim sNotaFiscal As String = ""
                Dim sChaveAcesso As String = ""
                Dim lCodigoParceiroNegocio As Long
                Dim lCodigoTituloCapa As Long

                'Carrega Dados da NF-e
                oClsFatEmissaoNFe.LoadDadosNFe(lCodigoEmissaoCapa, _
                                              sArquivoNFe, _
                                              sArquivoProtocoloNFe, _
                                              sArquivoCancelamentoNFe, _
                                              sArquivoProtocoloCancelamentoNFe, _
                                              sChaveAcesso, _
                                              sNotaFiscal, _
                                              lCodigoParceiroNegocio, _
                                              lCodigoTituloCapa)

                'Verifica se foi possível gerar o Arquivo
                If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                  sArquivoProtocoloNFe, _
                                                  sChaveAcesso, _
                                                  sArquivoEnvio, _
                                                  sMensagemErro) = True Then

                    'Abre Relatório
                    oRptDocument.Load(goCrystalReport.sPath & LoadDescricao("sp_select_faturamento_emissao_relatorio_danfe " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                    'Seta Parametros Relatório
                    oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
                    oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                    'Abre Conexão com o Banco de Dados
                    For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                        oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                    Next

                    'Váriavel Relatório
                    Dim sArquivoReport As String = goConfiguracaoNFe.sPastaImpressao & sNotaFiscal & ".pdf"

                    'Verifica se o Arquivo Existe
                    If File.Exists(sArquivoReport) = True Then File.Delete(sArquivoReport)

                    'Exporta para Arquivo PDF
                    oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

                    'Limpa Váriavel
                    oRptDocument = Nothing

                    'Boleto Bancário
                    If lCodigoTituloCapa > 0 Then
                        'Váriavel - Boleto
                        Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
                        'Carrega Boleto
                        oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNotaFiscal, sArquivoBoleto)
                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    If goUsuario.sEmpresa = "LH COLUS TECNOLOGIA LTDA EPP" Then

                        Dim sCorpo As String = ""
                        sCorpo = "Prezado cliente, " & vbNewLine
                        sCorpo &= vbNewLine & "Você está recebendo a Nota Fiscal Eletrônica número " & sNotaFiscal & ", série " & grdListagem.CurrentRow.Cells.Item("serie").Value & " de " & goUsuario.sEmpresa & ", " & vbNewLine
                        sCorpo &= "no valor de R$ " & grdListagem.CurrentRow.Cells.Item("valor_nota_fiscal").Value & ". Além disso, junto com a mercadoria seguirá o DANFE (Documento Auxiliar da Nota Fiscal Eletrônica), impresso em papel que acompanha o transporte das mesmas." & vbNewLine
                        sCorpo &= "Anexo à este e-mail você está recebendo também o arquivo XML da Nota Fiscal Eletrônica. Este arquivo deve ser armazenado eletronicamente por sua empresa pelo prazo de 05 (cinco) anos, conforme previsto na legislação tributária (Art. 173 do Código Tributário Nacional e § 4º da Lei 5.172 de 25/10/1966)." & vbNewLine
                        sCorpo &= "O DANFE em papel pode ser arquivado para apresentação ao fisco quando solicitado. Todavia, se sua empresa também for emitente de NF-e, o arquivamento eletrônico do XML de seus fornecedores é obrigatório, sendo passível de fiscalização. O código chave de sua Nota Fiscal Eletrônica é " & grdListagem.CurrentRow.Cells.Item("chave_acesso").Value & " e você pode consultar a autenticidade deste documento juntamente com o Fisco através do site www.nfe.fazenda.gov.br, informando o número do código chave." & vbNewLine
                        sCorpo &= vbNewLine & "INTERACTI - ACTi Consultoria " & vbNewLine
                        sCorpo &= "www.acticonsultoria.com.br"

                        'Enviar E-mail
                        Call EnviarEmail(goUsuario.sEmpresa & " - NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                                         LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         sCorpo, _
                                         lCodigoParceiroNegocio, _
                                         "", _
                                         lCodigoEmissaoCapa)
                    Else

                        'Enviar E-mail
                        Call EnviarEmail(goUsuario.sEmpresa & " - NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                                         LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                         "", _
                                         lCodigoParceiroNegocio, _
                                         "", _
                                         lCodigoEmissaoCapa)


                    End If

                    'Carrega Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                End If

            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: INTEGRAÇÃO :::"

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then
                oClsIntegracao.IntegracaoNFOcorrencia(lCodigoEmissaoCapa)
            End If


            'Salva Movimentação - Estoque
            oClsIntegracao.IntegracaoNFEmissaoEstoque(oClsFatEmissaoNFe.CodigoEmissaoCapa)

            If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then
                'Salva Financeiro - Receita
                oClsIntegracao.IntegracaoNFEmissaoFinanceiro(oClsFatEmissaoNFe.CodigoEmissaoCapa, _
                                                             IIf(grdFinanceiro.RowCount > 0, True, False))
            End If

            'Pagamento
            Call Pagamento()

            'Verifica se envia E-mail Automaticamente
            If goConfiguracaoNFe.bEnviarEmailAutomaticamente = True Then

                Call EmailAutomatico(oClsFatEmissaoNFe.CodigoEmissaoCapa)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Pagamento()

        Try

            'Caso Título Quitado
            If VerificaSelecaoRowCheckedDiferente(grdDuplicata, _
                                                  "pago", _
                                                  "valor_pago", _
                                                  "0") = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True

                oForm.UsrControl = IIf(cboTipoDocumento.SelectedValue = TipoDocumentoFiscal.Entrada, "usrFinDespesaPagamento", "usrFinReceitaPagamento")
                oForm.Titulo = "Financeiro - " & IIf(cboTipoDocumento.SelectedValue = TipoDocumentoFiscal.Entrada, "Despesa", "Receita") & " - Conciliação Bancária"

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCNumeroDocumento As New DataColumn("numero_documento")
                Dim oDCParcela As New DataColumn("parcela")
                Dim oDCDescritivo As New DataColumn("descritivo")
                Dim oDCDataVencimento As New DataColumn("data_vencimento")
                Dim oDCValorTotal As New DataColumn("valor_total")
                Dim oDCValorPago As New DataColumn("valor_pago")
                Dim oDCJuros As New DataColumn("juros")
                Dim oDCDesconto As New DataColumn("desconto")
                Dim oDCValorDevido As New DataColumn("valor_devido")
                Dim oDCCodigoTituloCapa As New DataColumn("codigo_titulo_capa")
                Dim oDCNumeroParcela As New DataColumn("numero_parcela")

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCNumeroDocumento)
                oDataTable.Columns.Add(oDCParcela)
                oDataTable.Columns.Add(oDCDescritivo)
                oDataTable.Columns.Add(oDCDataVencimento)
                oDataTable.Columns.Add(oDCValorTotal)
                oDataTable.Columns.Add(oDCValorPago)
                oDataTable.Columns.Add(oDCJuros)
                oDataTable.Columns.Add(oDCDesconto)
                oDataTable.Columns.Add(oDCValorDevido)
                oDataTable.Columns.Add(oDCCodigoTituloCapa)
                oDataTable.Columns.Add(oDCNumeroParcela)
                'Seta DataType
                oDCDataVencimento.DataType = Now.Date.GetType
                oDCValorTotal.DataType = 0.0.GetType
                oDCValorPago.DataType = 0.0.GetType
                oDCJuros.DataType = 0.0.GetType
                oDCDesconto.DataType = 0.0.GetType
                oDCValorDevido.DataType = 0.0.GetType

                For Each oRow As GridEXRow In gSelecaoRow

                    'Adiciona Linhas ao DataTable
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("numero_documento") = Format(txtNotaFiscal.Text.Trim, "000000000")
                    oDataRow("parcela") = oRow.RowIndex + 1 & " DE " & grdDuplicata.GetDataRows.Count
                    oDataRow("descritivo") = "NOTA FISCAL: " & Format(txtNotaFiscal.Text.Trim, "000000000")
                    oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                    oDataRow("valor_total") = oRow.Cells("valor").Value
                    oDataRow("valor_pago") = 0
                    oDataRow("juros") = 0
                    oDataRow("desconto") = 0
                    oDataRow("valor_devido") = oRow.Cells("valor").Value
                    oDataRow("codigo_titulo_capa") = oClsFatEmissaoNFe.CodigoTituloFinanceiro
                    oDataRow("numero_parcela") = oRow.RowIndex + 1
                    oDataTable.Rows.Add(oDataRow)

                Next

                'Seta Parâmetros
                Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
                oFormularioCadastroBasico(0).oValor = oDataSet : oFormularioCadastroBasico(0).sControle = "grdParcela"
                oForm.CadastroBasico = oFormularioCadastroBasico

                'Abre o Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region
    
   
End Class
