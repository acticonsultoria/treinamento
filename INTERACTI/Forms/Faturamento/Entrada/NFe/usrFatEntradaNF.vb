Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO
Imports INTERACTI.NFe.ProcNFe_V2

Public Class usrFatEntradaNF

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF
    Private bInspecao As Boolean
    Private lCodigoTituloCapa As Long
#End Region

#Region "::: CONTROLES :::"

#Region " ::: DADOS GERAIS ::: "

    Private Sub usrFatEntradaNF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEPEmitente" : Call btnProcurarCEPEmitente_Click(btnProcurarCEPEmitente, System.EventArgs.Empty)
                        Case "cboEmitente" : Call btnProcurarEmitente_Click(btnProcurarEmitente, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboEmitente" : Call LoadCombo(cboEmitente, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboTransportadora" : Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
                        Case "cboPaisEmitente" : Call LoadCombo(cboPaisEmitente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboTipoArquivo" : Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboEmitente" : Call btnCadastrarEmitente_Click(btnCadastrarEmitente, System.EventArgs.Empty)
                        Case "cboPaisEmitente" : Call btnCadastrarPaisEmitente_Click(btnCadastrarPaisEmitente, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnCadastrarTransportadora_Click(btnCadastrarTransportadora, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatEntradaNF_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region " ::: NOTA FISCAL ::: "
    Private Sub btnTransmitirLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            ''Verifica se foi Selecionado Algum Registro
            'If VerificaSelecaoRow(grdListagem, "status", CInt(StatusNotaFiscalEletronica.AguardandoTransmissao)) = True Then

            'Abre Formulário
            Dim oForm As New frmFatEntradaNFeAcaoEmLote
            oForm.Grid = grdListagem
            'Abre Formulário
            oForm.ShowDialog()

            'Else

            ''Informa o Usuário da Necessidade de Selecionar um ou mais Registro
            'frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            'End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs)
        Try
            oClsFatEntradaNF.LoadGridExportar(grdListagem, _
                                              grdExportar)

            ExportExcel(grdExportar)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnVincularPedidoCompra_Click(sender As Object, e As EventArgs) Handles btnVincularPedidoCompra.Click

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEntradaNFVincularPedido

            'Seta Parametros
            oForm.CodigoEntradaCapa = oClsFatEntradaNF.CodigoEntradaCapa
            oForm.CodigoParceiroNegocio = cboEmitente.SelectedValue
            oForm.TotalNota = txtTotalNotaFiscal.Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Call LoadPedidoCompra(oClsFatEntradaNF.CodigoEntradaCapa)
            Call Integracao(oClsFatEntradaNF.CodigoEntradaCapa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            GerarXML()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNF)

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

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoNFe.Click

        Try

            If ValidaCampo(cboTipoEntrada, lblTipoEntrada) = False Then
                cboTipoEntrada.Focus()
                Exit Sub
            End If

            'Abre Rotina para Importar Arquivo XML
            Call ImportarArquivoXML()

            grpDadosPedido.Enabled = True
            btnVincularPedidoCompra.Enabled = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

          
            'Exclui Nota Fiscal
            Call ExcluirNotaFiscal()

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

            'Insere Capa
            oClsFatEntradaNF.InsertNotaFiscal()

            'Seta Controle
            btnSalvar.Tag = oClsFatEntradaNF.CodigoEntradaCapa

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboTipoNotaFiscal.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Limpa Controles
            Call Novo()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Alterna Aba                
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboTipoNotaFiscal.Focus()

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

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

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

                'Salva Dados do Registro
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoNotaFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoNotaFiscal.SelectedIndexChanged

        Try

            Select Case cboTipoNotaFiscal.SelectedValue

                Case CInt(TipoNotaFiscal.NotaFiscal)
                    txtEspecie.Text = "NF"
                    grpDadosNFe.Enabled = False
                    grpDadosNF.Enabled = True
                    grpDadosDACTE.Enabled = False
                    grpEmitente.Enabled = True
                    grpICMS.Enabled = True
                    grpTransportador.Enabled = True
                    grpRetencaoICMSTransporte.Enabled = True
                    grpTipoVeiculo.Enabled = True
                    grpVeiculo.Enabled = True
                    grpBalsaoVagao.Enabled = True
                    grpReboque.Enabled = True
                    grpVolume.Enabled = True
                    grpInformacaoAdicional.Enabled = True
                    grpExportacao.Enabled = True
                    grpCompra.Enabled = True

                Case CInt(TipoNotaFiscal.NotaFiscalEletronica), CInt(TipoNotaFiscal.CTRC)
                    txtEspecie.Text = "NF-E"
                    grpDadosNFe.Enabled = True
                    grpDadosNF.Enabled = False
                    grpDadosDACTE.Enabled = False
                    grpEmitente.Enabled = False
                    grpICMS.Enabled = False
                    grpTransportador.Enabled = False
                    grpRetencaoICMSTransporte.Enabled = False
                    grpTipoVeiculo.Enabled = False
                    grpVeiculo.Enabled = False
                    grpBalsaoVagao.Enabled = False
                    grpReboque.Enabled = False
                    grpVolume.Enabled = False
                    grpInformacaoAdicional.Enabled = False
                    grpExportacao.Enabled = False
                    grpCompra.Enabled = False

                    'Case CInt(TipoNotaFiscal.DACTE)
                    '    txtEspecie.Text = "DACTE"
                    '    grpDadosNFe.Enabled = False
                    '    grpDadosNF.Enabled = True
                    '    grpDadosDACTE.Enabled = True
                    '    grpEmitente.Enabled = True
                    '    grpICMS.Enabled = True
                    '    grpTransportador.Enabled = True
                    '    grpRetencaoICMSTransporte.Enabled = True
                    '    grpTipoVeiculo.Enabled = True
                    '    grpVeiculo.Enabled = True
                    '    grpBalsaoVagao.Enabled = True
                    '    grpReboque.Enabled = True
                    '    grpVolume.Enabled = True
                    '    grpInformacaoAdicional.Enabled = True
                    '    grpExportacao.Enabled = True
                    '    grpCompra.Enabled = True

                    'Case CInt(TipoNotaFiscal.CTE)
                    '    txtEspecie.Text = "CTE"
                    '    grpDadosNFe.Enabled = False
                    '    grpDadosNF.Enabled = True
                    '    grpDadosDACTE.Enabled = True
                    '    grpEmitente.Enabled = True
                    '    grpICMS.Enabled = True
                    '    grpTransportador.Enabled = True
                    '    grpRetencaoICMSTransporte.Enabled = True
                    '    grpTipoVeiculo.Enabled = True
                    '    grpVeiculo.Enabled = True
                    '    grpBalsaoVagao.Enabled = True
                    '    grpReboque.Enabled = True
                    '    grpVolume.Enabled = True
                    '    grpInformacaoAdicional.Enabled = True
                    '    grpExportacao.Enabled = True
                    '    grpCompra.Enabled = True

                    'Case CInt(TipoNotaFiscal.CTRC)
                    '    txtEspecie.Text = "CTRC"
                    '    grpDadosNFe.Enabled = False
                    '    grpDadosDACTE.Enabled = False
                    '    grpDadosNF.Enabled = True
                    '    grpEmitente.Enabled = True
                    '    grpICMS.Enabled = True
                    '    grpTransportador.Enabled = True
                    '    grpRetencaoICMSTransporte.Enabled = True
                    '    grpTipoVeiculo.Enabled = True
                    '    grpVeiculo.Enabled = True
                    '    grpBalsaoVagao.Enabled = True
                    '    grpReboque.Enabled = True
                    '    grpVolume.Enabled = True
                    '    grpInformacaoAdicional.Enabled = True
                    '    grpExportacao.Enabled = True
                    '    grpCompra.Enabled = True

                Case CInt(TipoNotaFiscal.NFST)
                    txtEspecie.Text = "NFST"
                    grpDadosNFe.Enabled = False
                    grpDadosDACTE.Enabled = False
                    grpDadosNF.Enabled = True
                    grpEmitente.Enabled = True
                    grpICMS.Enabled = True
                    grpTransportador.Enabled = True
                    grpRetencaoICMSTransporte.Enabled = True
                    grpTipoVeiculo.Enabled = True
                    grpVeiculo.Enabled = True
                    grpBalsaoVagao.Enabled = True
                    grpReboque.Enabled = True
                    grpVolume.Enabled = True
                    grpInformacaoAdicional.Enabled = True
                    grpExportacao.Enabled = True
                    grpCompra.Enabled = True

                Case CInt(TipoNotaFiscal.NFE)
                    txtEspecie.Text = "NFE"
                    grpDadosNFe.Enabled = False
                    grpDadosDACTE.Enabled = False
                    grpDadosNF.Enabled = True
                    grpEmitente.Enabled = True
                    grpICMS.Enabled = True
                    grpTransportador.Enabled = True
                    grpRetencaoICMSTransporte.Enabled = True
                    grpTipoVeiculo.Enabled = True
                    grpVeiculo.Enabled = True
                    grpBalsaoVagao.Enabled = True
                    grpReboque.Enabled = True
                    grpVolume.Enabled = True
                    grpInformacaoAdicional.Enabled = True
                    grpExportacao.Enabled = True
                    grpCompra.Enabled = True

                Case Else
                    txtEspecie.Text = ""
                    grpDadosNFe.Enabled = False
                    grpDadosNF.Enabled = False
                    grpDadosDACTE.Enabled = False
                    grpEmitente.Enabled = False
                    grpICMS.Enabled = False
                    grpTransportador.Enabled = False
                    grpRetencaoICMSTransporte.Enabled = False
                    grpTipoVeiculo.Enabled = False
                    grpVeiculo.Enabled = False
                    grpBalsaoVagao.Enabled = False
                    grpReboque.Enabled = False
                    grpVolume.Enabled = False
                    grpInformacaoAdicional.Enabled = False
                    grpExportacao.Enabled = False
                    grpCompra.Enabled = False

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarNotaFiscal(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                      grdListagem.CurrentRow.Cells("status").Value, _
                                                      grdListagem.CurrentRow.Cells("aprovado_qualidade").Value)
                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "cancelar" : Call CancelarNotaFiscal()
                Case "historico" : Call VisualizarHistorico()
                Case "integracao_compras" : Call IntegracaoComprasRetornoConserto()
                Case "etiqueta" : Call ImprimirEtiqueta()

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
                                     Formulario.FaturamentoEntradaNF, _
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
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEntradaNF, _
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
            btnInserirProduto.Visible = False
            btnExcluirProduto.Visible = False

            Select Case e.Page.Name

                Case "pagProduto"
                    If cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                        btnInserirProduto.Visible = True
                        btnExcluirProduto.Visible = True
                    End If

                Case "pagTotais"
                    If cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                        Call LoadTotais()
                    End If

                Case "pagCobranca"
                    Call LoadFatura()


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

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarPedido_Click(sender As Object, e As EventArgs) Handles btnGerarPedido.Click

        Try

            GerarPedidoNotaFiscal()

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFindPlanoContas_Click(sender As Object, e As EventArgs)
        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"
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

#End Region

#Region " ::: EMITENTE ::: "

#Region " ::: DADOS DO EMITENTE ::: "

    Private Sub btnCadastrarEmitente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarEmitente.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboEmitente, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboEmitente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarEmitente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarEmitente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboEmitente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboEmitente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPaisEmitente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisEmitente.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo            
            LoadCombo(cboPaisEmitente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

            'Seta Focu
            cboPaisEmitente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCEPEmitente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEPEmitente.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCEPEmitente.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPEmitente.Text.Trim, "-", "")), _
                           cboPaisEmitente, _
                           cboUFEmitente, _
                           cboMunicipioEmitente, _
                           txtBairroEmitente, _
                           txtLogradouroEmitente, _
                           txtComplementoEmitente)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboEmitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmitente.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Destinatário
            If cboEmitente.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                txtCNPJEmitente.Enabled = False : txtCNPJEmitente.Text = ""
                txtInscricaoEstadualEmitente.Enabled = False : txtInscricaoEstadualEmitente.Text = ""
                txtInscricaoEstadualSubstitutoTributarioEmitente.Enabled = False : txtInscricaoEstadualSubstitutoTributarioEmitente.Text = ""
                cboRegimeTributarioEmitente.Enabled = False : cboRegimeTributarioEmitente.SelectedIndex = -1
                txtInscricaoMunicipalEmitente.Enabled = False : txtInscricaoMunicipalEmitente.Text = ""
                txtCNAEEmitente.Enabled = False : txtCNAEEmitente.Text = ""
                txtLogradouroEmitente.Enabled = False : txtLogradouroEmitente.Text = ""
                txtNumeroEmitente.Enabled = False : txtNumeroEmitente.Text = ""
                txtComplementoEmitente.Enabled = False : txtComplementoEmitente.Text = ""
                txtBairroEmitente.Enabled = False : txtBairroEmitente.Text = ""
                txtCEPEmitente.Enabled = False : txtCEPEmitente.Text = ""
                cboPaisEmitente.Enabled = False : cboPaisEmitente.SelectedIndex = -1
                cboUFEmitente.Enabled = False : cboUFEmitente.SelectedIndex = -1
                cboMunicipioEmitente.Enabled = False : cboMunicipioEmitente.SelectedIndex = -1
                txtTelefoneEmitente.Enabled = False : txtTelefoneEmitente.Text = ""
                txtEmailEmitente.Enabled = False : txtEmailEmitente.Text = ""
                txtCNPJEmitente.Tag = ""
                grpLocalRetiradaEntrega.Enabled = False
                chkLocalEntrega.Checked = False
                chkLocalRetirada.Checked = False

            Else

                'Carrega dados do Destinatário
                Call LoadDadosParceiroNegocio(cboEmitente.SelectedValue, _
                                              txtCNPJEmitente, _
                                              txtInscricaoEstadualEmitente, _
                                              txtInscricaoEstadualSubstitutoTributarioEmitente, _
                                              cboRegimeTributarioEmitente, _
                                              txtLogradouroEmitente, _
                                              txtNumeroEmitente, _
                                              txtComplementoEmitente, _
                                              txtBairroEmitente, _
                                              txtCEPEmitente, _
                                              cboPaisEmitente, _
                                              cboUFEmitente, _
                                              cboMunicipioEmitente, _
                                              txtTelefoneEmitente, _
                                              txtEmailEmitente)

                'Verifica o Tipo de Personalidade
                If txtCNPJEmitente.Tag = Personalidade.fisica Then
                    lblCNPJEmitente.Text = "CPF:"
                    lblInscricaoEstadualEmitente.Text = "RG:"
                Else
                    lblCNPJEmitente.Text = "CNPJ:"
                    lblInscricaoEstadualEmitente.Text = "IE:"
                End If

                'Carrega Controles
                Call LoadComboGrid(grdProduto, "codigo_cfop", "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & TipoDocumentoFiscal.Entrada & ", '" & cboUFEmitente.SelectedValue & "', '" & goEmitente.sUF & "'")
                Call LoadCombo(cboTituloPrevisto, "sp_select_combo_faturamento_titulo_previsao " & goUsuario.iEmpresa & ", " & cboEmitente.SelectedValue)

                'Habilita Controles
                grpLocalRetiradaEntrega.Enabled = True
                chkLocalEntrega.Checked = False
                chkLocalRetirada.Checked = False
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPaisEmitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaisEmitente.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisEmitente.SelectedIndex = -1 Then
                'Limpa Controles
                cboUFEmitente.DataSource = Nothing : cboUFEmitente.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboUFEmitente, "sp_select_combo_static_estado_pais " & cboPaisEmitente.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFEmitente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFEmitente.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFEmitente.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioEmitente.DataSource = Nothing : cboMunicipioEmitente.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioEmitente, "sp_select_combo_static_municipio " & cboUFEmitente.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region " ::: LOCAL RETIRADA ::: "

    Private Sub chkLocalRetirada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocalRetirada.CheckedChanged

        Try

            'Seta Enable
            btnEnderecoLocalRetirada.Visible = chkLocalRetirada.Checked

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnderecoLocalRetirada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnderecoLocalRetirada.Click

        Try

            'Abre Formulário de Local de Retirada
            Call LocalRetirada()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region " ::: LOCAL ENTREGA ::: "

    Private Sub chkLocalEntrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocalEntrega.CheckedChanged

        Try

            'Seta Enable
            btnEnderecoLocalEntrega.Visible = chkLocalEntrega.Checked

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnderecoLocalEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnderecoLocalEntrega.Click

        Try

            'Abre Formulário de Local de Entrega
            Call LocalEntrega()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region " ::: PRODUTO ::: "

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
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

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEditarGridProduto_Click(sender As Object, e As EventArgs) Handles btnEditarGridProduto.Click

        Try

            'Váriaveis Locais
            Dim sCampo(4) As String

            'Carrega Valores
            sCampo(0) = "codigo_produto_interno"
            sCampo(1) = "codigo_cfop"
            sCampo(2) = "lote"
            sCampo(3) = "codigo_deposito"
            sCampo(4) = "plano_contas"


            'Habilita Grid
            Call EditarGrid(grdProduto, _
                            sCampo, _
                            IIf(grdProduto.Tag.ToString = "E", False, True))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Abre Formulário de Input de Item
            Call InsertProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProduto.Click

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

            'Verifica e a Coluna Pressionada é Válida
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

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
                                     Formulario.FaturamentoEntradaNF, _
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
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.FaturamentoEntradaNF, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdProduto.CellUpdated

        Try

            'Query
            Dim sQuery As String
            Dim sQueryLote As String

            sQuery = "WHERE codigo_entrada_capa = " & btnSalvar.Tag & " "
            sQuery = sQuery & "AND codigo_empresa = " & goUsuario.iEmpresa & " "
            sQuery = sQuery & "AND codigo = " & grdProduto.GetValue("codigo_entrada_item") & ""

            sQueryLote = "WHERE codigo_entrada_capa = " & btnSalvar.Tag & " "
            sQueryLote = sQueryLote & "AND codigo_empresa = " & goUsuario.iEmpresa & " "
            sQueryLote = sQueryLote & "AND codigo_entrada_item = " & grdProduto.GetValue("codigo_entrada_item") & " "
            sQueryLote = sQueryLote & "AND codigo = " & grdProduto.GetValue("codigo_entrada_item_lote") & ""

            Select Case e.Column.Key

                Case "codigo_produto_interno"
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item', 'codigo_item', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, grdProduto.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item', 'codigo_produto_servico', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, "'" & grdProduto.CurrentRow.Cells(e.Column.Key).Text.ToString.Replace("'", "") & "'", "'NULL'") & ",'" & sQuery & "'")

                Case "lote"
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item_lote', 'lote', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, "'" & grdProduto.CurrentRow.Cells(e.Column.Key).Text.ToString.Replace("'", "") & "'", "'NULL'") & ",'" & sQueryLote & "'")

                Case "codigo_deposito"
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item_lote', 'codigo_deposito', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, grdProduto.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQueryLote & "'")

                Case "plano_contas"
     

                    Dim iCodigoEntradaItem As Integer = grdProduto.GetValue("codigo_entrada_item")

                    If MsgBox("Deseja alterar o plano para os demais itens da nota fiscal?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atualização em masssa") = MsgBoxResult.Yes Then
                        iCodigoEntradaItem = -1
                    End If

                    Dim sPlanoContas As String = ""
                    If Not IsDBNull(grdProduto.GetValue("plano_contas")) Then
                        sPlanoContas = grdProduto.GetValue("plano_contas")
                    End If

                    'Atualiza
                    ExecuteQuery("sp_update_faturamento_entrada_item_plano_contas " & btnSalvar.Tag & "," & _
                                                                                     iCodigoEntradaItem & "," & _
                                                                                     goUsuario.iEmpresa & _
                                                                                     IIf(sPlanoContas = "", "", ",'" & sPlanoContas & "'"))

                    'Carrega novamente
                    oClsFatEntradaNF.LoadGridProduto(btnSalvar.Tag, grdProduto)

                Case "codigo_cfop"
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item', 'codigo_cfop', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, grdProduto.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item', 'cfop', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, "'" & grdProduto.CurrentRow.Cells(e.Column.Key).Text.ToString.Replace("'", "") & "'", "'NULL'") & ",'" & sQuery & "'")

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region " ::: COBRANÇA ::: "

    Private Sub cboFormaPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaPagamento.SelectedIndexChanged

        Try

            If cboFormaPagamento.SelectedIndex = -1 Then
                Call ClearUnboundGrid(grdDuplicata)
                txtNumeroParcela.Enabled = False
                txtIntervaloEntreParcelas.Enabled = False
            ElseIf cboFormaPagamento.SelectedValue = FormaPagamentoNFe.PagamentoAVista Then
                txtNumeroParcela.Value = 1 : txtNumeroParcela.Enabled = False
                txtIntervaloEntreParcelas.Value = 0 : txtIntervaloEntreParcelas.Enabled = False
            Else
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
                                                                                                          txtValorAcrescimo.ValueChanged

        Try

            'Calcula Valor Líquido
            txtValorLiquido.Value = txtValorOriginal.Value - txtValorDesconto.Value + txtValorAcrescimo.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCalcularDuplicata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDuplicata.Click

        Try

            'Gera Duplicata
            oClsFatEntradaNF.GerarDuplicata(grdDuplicata, _
                                            txtValorLiquido.Value - txtValorPago.Value, _
                                            txtNumeroParcela.Value, _
                                            txtIntervaloEntreParcelas.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVincular.Click


        Try
            'Validação
            If ValidaCampo(cboTituloPrevisto, lblTituloPrevisto) = False Then
                Exit Sub
            End If

            'Verifica se já foi salvo
            If CStr(btnSalvar.Tag) = "" Then
                MsgBox("Primeiramente, salve a NFs.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, Me.Parent.Text)
                Exit Sub
            End If



            'Carrega Dados
            oClsFatEntradaNF.LoadControlesTituloPrevisao(cboTituloPrevisto.SelectedValue, _
                                                         txtNumDocumentoPrevisto, _
                                                         txtValorPrevisto, _
                                                         cboCentroGastoVinculo, _
                                                         txtTituloDescritivo)

            'Verifica se Existe Código do Titulo Capa
            If lCodigoTituloCapa <= 0 Then

                'Seta Código Título
                lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

            End If

            'Verifica se Existe Código do Titulo Capa
            If lCodigoTituloCapa > 0 Then

                'Atualiza Título
                oClsFatEntradaNF.UpdateVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue, _
                                                             lCodigoTituloCapa, _
                                                             IIf(cboCentroGastoVinculo.SelectedIndex = -1, -1, cboCentroGastoVinculo.SelectedValue), _
                                                             txtTituloDescritivo.Text.ToString, _
                                                             txtNumDocumentoPrevisto.Text.ToString, _
                                                             txtValorPrevisto.Text.ToString)

                'Deleta Títuo Vinculado
                oClsFatEntradaNF.DeleteVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue)

                'Desabilita Controles
                cboTituloPrevisto.Enabled = False
                txtNumDocumentoPrevisto.Enabled = False
                txtValorPrevisto.Enabled = False
                cboCentroGastoVinculo.Enabled = False
                txtTituloDescritivo.Enabled = False
                btnVincular.Enabled = False

            Else

                'Mensagem
                MsgBox("Primeiramente, salve a NFs.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, Me.Parent.Text)
                Exit Sub

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try




    End Sub

    Private Sub btnInserirNFFatura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirNFFatura.Click
        Try
            'Váriavel - Formulário de Cadastro de Produto
            Dim oForm As New frmFatEntradaNFFatura

            'Seta Parametros            
            oForm.CodigoEntradaCapa = btnSalvar.Tag

            'Seta Tamanho / Posição do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega dados da Nota Fiscal
            oClsFatEntradaNF.LoadDadosNotaFiscal(btnSalvar.Tag, _
                                                 cboTipoEntrada, _
                                                 cboTipoNotaFiscal, _
                                                 txtNumeroNF, _
                                                 txtEspecie, _
                                                 txtSerieNF, _
                                                 dtpDataEmissaoNF, _
                                                 dtpDataEntradaNF, _
                                                 txtArquivoNFe, _
                                                 txtNumeroNFe, _
                                                 txtSerieNFe, _
                                                 txtDataEmissaoNFe, _
                                                 dtpDataEntradaNFe, _
                                                 txtChaveAcessoNFe, _
                                                 txtChaveAcessoDACTE, _
                                                 txtNumeroProtocoloNFe, _
                                                 txtStatusNFe, _
                                                 cboEmitente, _
                                                 chkLocalRetirada, _
                                                 chkLocalEntrega, _
                                                 cboModalidadeFrete, _
                                                 cboTransportadora, _
                                                 txtBaseCalculoTransporte, _
                                                 txtAliquotaTransporte, _
                                                 txtValorServicoTransporte, _
                                                 cboUFICMSTransporte, _
                                                 cboMunicipioICMSTransporte, _
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
                                                 cboFormaPagamento, _
                                                 txtNumeroParcela, _
                                                 txtIntervaloEntreParcelas, _
                                                 txtInformacaoAdicionalContribuinte, _
                                                 txtInformacaoAdicionalFisco, _
                                                 cboUFEmbarque, _
                                                 txtLocalEmbarque, _
                                                 txtNotaEmpenho, _
                                                 txtInformacaoPedido, _
                                                 txtInformacaoContrato, _
                                                 cboTipoDocumentoPagamento, _
                                                 txtDescritivo, _
                                                 txtCCeSequencia, _
                                                 dtpCCeDataEvento, _
                                                 txtCCeNumeroProtocolo, _
                                                 txtCCeCorrecao)

            'Carrega Grid de Item
            Call oClsFatEntradaNF.LoadGridProduto(btnSalvar.Tag, _
                                                  grdProduto)

            'Carrega Grid de Parcela
            Call oClsFatEntradaNF.LoadGridDuplicata(btnSalvar.Tag, _
                                                    grdDuplicata)

            'Carrega Grid de Reboque
            Call oClsFatEntradaNF.LoadGridReboque(btnSalvar.Tag, _
                                                  grdReboque)

            'Carrega Grid de Volume
            Call oClsFatEntradaNF.LoadGridVolume(btnSalvar.Tag, _
                                                 grdVolume)

            Call LoadTotais()

            Call LoadNFFatura()

            cboFormaPagamento.SelectedValue = 0

            oClsFatEntradaNF.GerarDuplicata(grdDuplicata, _
                                            txtValorLiquido.Value - txtValorPago.Value, _
                                            txtNumeroParcela.Value, _
                                            txtIntervaloEntreParcelas.Value)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoVinculo.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGastoVinculo, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGastoVinculo.Focus()

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
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroCustoVinculo.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGastoVinculo

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoVinculo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboTituloPrevisto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTituloPrevisto.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum título previsto
            If cboTituloPrevisto.SelectedIndex <> -1 Then

                'Carrega Dados do Título Previsto
                oClsFatEntradaNF.LoadControlesTituloPrevisao(cboTituloPrevisto.SelectedValue, _
                                                             txtNumDocumentoPrevisto, _
                                                             txtValorPrevisto, _
                                                             cboCentroGastoVinculo, _
                                                             txtTituloDescritivo)

            End If

        Catch ex As Exception
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
                Call oClsFatEntradaNF.InsertFinanceiroGrid(grdFinanceiro, _
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

#Region "::: DADOS DA DESPESA :::"
    Private Sub btnCadastrarContaContabil_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarCentroGasto_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirClassificao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirClassificao.Click

        Try

            'Insere Classificação
            Call InserirClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirClassificacao.Click

        Try

            'Exclui Classificação
            Call DeleteClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdClassificacao.RowDoubleClick

        Try

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdClassificacao) Then Exit Sub

            Select Case grdClassificacao.CurrentColumn.Key

                Case "editar" : Call EditarClassificacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#Region " ::: TOTAL ::: "

    Private Sub CalculaTotalNF_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Try

            'Verifica a Necessidade de Calcular o Total
            If sender.Name = "txtTotalFrete" Or _
               sender.Name = "txtTotalSeguro" Or _
               sender.Name = "txtOutrasDespesas" Or _
               sender.Name = "txtTotalDesconto" Then

                'Carrega Total
                Call LoadTotais()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region " ::: TRANSPORTE ::: "

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

    Private Sub cboTransportadora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTransportadora.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Transportadora
            If cboTransportadora.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                txtCNPJTransportadora.Enabled = False : txtCNPJTransportadora.Text = ""
                txtInscricaoEstadualTransportadora.Enabled = False : txtInscricaoEstadualTransportadora.Text = ""
                cboUFTransportadora.Enabled = False : cboUFTransportadora.SelectedIndex = -1
                cboMunicipioTransportadora.Enabled = False : cboMunicipioTransportadora.SelectedIndex = -1
                txtEnderecoTransportadora.Enabled = False : txtEnderecoTransportadora.Text = ""
                txtCNPJTransportadora.Tag = ""

            Else

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

    Private Sub cboUFTransportadora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            btnInserirProduto.Tag = ""
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

    Private Sub grdReboque_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdReboque.DoubleClick

        Try

            'Verifica qual coluna foi pressionada
            Select Case grdReboque.CurrentColumn.Key

                Case "editar"
                    txtPlacaReboque.Text = grdReboque.CurrentRow.Cells("placa").Value
                    cboUFReboque.SelectedValue = grdReboque.CurrentRow.Cells("uf").Value
                    txtRNTCReboque.Text = grdReboque.CurrentRow.Cells("rntc").Value
                    btnInserirReboque.Tag = grdReboque.CurrentRow.Cells("placa").Value
                    txtPlacaReboque.Focus()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub txtImpostoRetencao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBaseCalculoTransporte.ValueChanged, _
                                                                                                      txtAliquotaTransporte.ValueChanged

        Try

            'Calcula Imposto Retido
            txtICMSRetidoTransporte.Value = txtBaseCalculoICMS.Value * txtAliquotaTransporte.Value / 100.0

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

    Private Sub grdVolume_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdVolume.DoubleClick

        Try

            'Verifica qual coluna foi pressionada
            Select Case grdVolume.CurrentColumn.Key

                Case "editar"
                    txtQuantidadeEmbalagemTransportadora.Value = grdVolume.CurrentRow.Cells("quantidade_embalagem").Value
                    txtEspecieTransportadora.Text = grdVolume.CurrentRow.Cells("especie").Value
                    txtMarcaTransportadora.Text = grdVolume.CurrentRow.Cells("marca").Value
                    txtNumeroTransportadora.Text = grdVolume.CurrentRow.Cells("numero").Value
                    txtPesoLiquidoTransportadora.Value = grdVolume.CurrentRow.Cells("peso_liquido").Value
                    txtPesoBrutoTransportadora.Value = grdVolume.CurrentRow.Cells("peso_bruto").Value
                    btnInserirVolume.Tag = grdVolume.CurrentRow.Cells("codigo").Value
                    txtQuantidadeEmbalagemTransportadora.Focus()

                Case "lacre"
                    Dim oForm As New frmFatEntradaNFVolumeLacre
                    oForm.CodigoEntradaCapa = oClsFatEntradaNF.CodigoEntradaCapa
                    oForm.CodigoEntradaTransporteVolume = grdVolume.CurrentRow.Cells("codigo").Value
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.FaturamentoEntradaNF)

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
                    Call InsertArquivoBD("tb_fat_entrada_capa", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_fat_entrada_capa", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_fat_entrada_capa", btnSalvar.Tag)

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
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.FaturamentoEntradaNF, _
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
            Call UpdateConfiguraGridGrupo(grdArquivo.Name,
                                          Formulario.FaturamentoEntradaNF,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"
    Private Sub grdQualidade_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdQualidade.RowDoubleClick
        Try

            If grdQualidade.CurrentColumn.Key = "opcao" Then

                Dim oForm As New frmFatEntradaNFCriterioAvaliacao
                oForm.CodigoEntradaCapa = oClsFatEntradaNF.CodigoEntradaCapa
                oForm.CodigoCriterioAvaliacao = grdQualidade.GetValue("codigo_criterio_avaliacao")
                oForm.txtEmitente.Text = cboEmitente.Text
                oForm.txtCriterio.Text = grdQualidade.GetValue("criterio_avaliacao")
                oForm.txtObservacao.Text = grdQualidade.GetValue("observacao")

                oForm.ShowDialog()

                oClsFatEntradaNF.LoadGridCriterioAvaliacao(grdQualidade, oClsFatEntradaNF.CodigoEntradaCapa)

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdQualidade_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdQualidade.CellUpdated

        If grdQualidade.GetValue("codigo_criterio_avaliacao_nf") Is Nothing = True Then

            MsgBox("Primeiramente, selecione um modelo de critério", MsgBoxStyle.Exclamation, "Validação")
            Exit Sub

        End If

        Select Case e.Column.Key


            Case "nota"

                If grdQualidade.GetValue("nota") < 0 Or grdQualidade.GetValue("nota") > 10 Then
                    MsgBox("A nota do questionário deve ser entre 0 e 10.", MsgBoxStyle.Exclamation, "Validação")
                    Exit Sub
                End If

                Call ExecuteQuery("sp_update_faturamento_entrada_item_qualidade_nota " & btnSalvar.Tag & "," & goUsuario.iEmpresa & "," & grdQualidade.GetValue("codigo_criterio_avaliacao_nf") & "," & grdQualidade.GetValue("nota"))
                frmMain.Informacao(Mensagem.RegistroSalvo)

            Case "observacao"

                Call ExecuteQuery("sp_update_faturamento_entrada_item_qualidade_observacao " & btnSalvar.Tag & "," & goUsuario.iEmpresa & "," & grdQualidade.GetValue("codigo_criterio_avaliacao_nf") & ", '" & grdQualidade.GetValue("observacao") & "'")
                frmMain.Informacao(Mensagem.RegistroSalvo)

        End Select
    End Sub


#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region " ::: DADOS GERAIS ::: "

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEntradaNF_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcPrint)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcDelete)
            btnEditarGridProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcUpdate)

            'Verifica Direito - Cadastros Básicos
            btnCadastrarEmitente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarPaisEmitente.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarTransportadora.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Carrega Combo - Filtro
            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ", 'E'")
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nota_fiscal_entrada")
            Call LoadCombo(cboTipoOperacaoFiltro, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada -1, " & goUsuario.iEmpresa)

            'Carrega Combo - Dados da Nota Fiscal
            Call LoadCombo(cboTipoNotaFiscal, "sp_select_combo_static_tipo_nota_fiscal")
            Call LoadCombo(cboTipoEntrada, "sp_select_combo_cadastro_basico_faturamento_tipo_entrada " & goUsuario.iEmpresa, False)


            'Carrega Combo - Emitente
            Call LoadCombo(cboEmitente, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
            Call LoadCombo(cboRegimeTributarioEmitente, "sp_select_combo_static_regime_tributario")
            Call LoadCombo(cboPaisEmitente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

            'Carrega Combo - Transporte
            Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete")
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
            Dim oComboBox(2) As UIComboBox
            oComboBox(0) = cboUFTransportadora : oComboBox(1) = cboUFVeiculo : oComboBox(2) = cboUFReboque
            Call LoadCombo(oComboBox, "sp_select_combo_static_estado")
            Call LoadCombo(cboTipoVeiculo, "sp_select_combo_static_tipo_veiculo")

            'Carrega Combo - Cobrança
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento_nfe")
            Call LoadCombo(cboCentroGastoVinculo, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)

            'Carrega Combo - Dados de despesa
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoDocumentoPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)

            'Carrega Combo - Exportação e Compras
            Call LoadCombo(cboUFEmbarque, "sp_select_combo_static_estado")

            'Carrega Combo - Grid
            Call LoadComboGrid(grdProduto, "codigo_produto_interno", "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto), False)
            Call LoadComboGrid(grdProduto, "codigo_deposito", "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", null,  null, null")
            Call LoadComboGrid(grdProduto, "plano_contas", "sp_select_combo_cadastro_basico_plano_contas " & goUsuario.iEmpresa)


            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then
                grpDadosPedido.Enabled = False
            Else
                grpDadosPedido.Enabled = True
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNF)
            Call ConfiguraGrid(grdProduto, Formulario.FaturamentoEntradaNF)
            Call ConfiguraGrid(grdDuplicata, Formulario.FaturamentoEntradaNF)
            Call ConfiguraGrid(grdReboque, Formulario.FaturamentoEntradaNF)
            Call ConfiguraGrid(grdVolume, Formulario.FaturamentoEntradaNF)
            Call ConfiguraGrid(grdArquivo, Formulario.FaturamentoEntradaNF)

            'Seta CalendarCombo
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEntradaInicioFiltro.Value = Now.Date : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False
            dtpCCeDataEvento.Value = Now.Date

            'Limpa Tag
            grdProduto.Tag = ""

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)


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

         

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region " ::: NOTA FISCAL ::: "

    Private Sub LoadPedidoCompra(ByVal lCodigoEntradaCapa As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega dados da Nota Fiscal
            oClsFatEntradaNF.LoadDadosPedidoCompra(lCodigoEntradaCapa, _
                                                   txtPedidoCompra)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarXML()
        Try
            Dim oSaveFolder As New FolderBrowserDialog

            If oSaveFolder.ShowDialog() = DialogResult.OK Then

                For Each oRow In grdListagem.GetCheckedRows

                    Dim sTXT As String = LoadCodigo("sp_select_faturamento_entrada_gerar_xml " & oRow.Cells.Item("codigo").Value & "," & goUsuario.iEmpresa)

                    If sTXT = "" Then Continue For

                    Dim oXMLDocument As New Xml.XmlDocument
                    oXMLDocument.LoadXml(sTXT)

                    oXMLDocument.Save(oSaveFolder.SelectedPath + "\" + oRow.Cells.Item("chave_acesso").Value & ".xml")

                Next

            End If

            frmMain.Informacao("Documentos exportados com sucesso!", Color.Blue)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sCFOP As String = ""
            Dim sStatus As String = ""
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

            'Seta Parametros
            Call oClsFatEntradaNF.LoadGridNotaFiscal(grdListagem, _
                                                     IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                                     IIf(IsNumeric(txtSerieFiltro.Text.Trim), txtSerieFiltro.Text.Trim, ""), _
                                                     txtEmitenteFiltro.Text.Trim, _
                                                     IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                     IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                     txtProdutoFiltro.Text.Trim, _
                                                     txtLoteFiltro.Text.Trim, _
                                                     IIf(dtpDataEntradaInicioFiltro.Checked = False, "", dtpDataEntradaInicioFiltro.Value), _
                                                     IIf(dtpDataEntradaTerminoFiltro.Checked = False, "", dtpDataEntradaTerminoFiltro.Value), _
                                                     sCFOP, _
                                                     IIf(cboTipoOperacaoFiltro.SelectedIndex = -1, -1, cboTipoOperacaoFiltro.SelectedValue), _
                                                     txtNumeroDocumentoFiltro.Text.Trim, _
                                                     sStatus)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarArquivoXML()

        Try

            'Variaveis Locais
            Dim oArquivoXML As New OpenFileDialog
            Dim sReturn As String

            'Abre PopUp para Usuário selecionar a NFe
            'oArquivoXML.InitialDirectory = "c:\\dados"
            oArquivoXML.Filter = "(Arquivo NFe XML)|*.XML"
            oArquivoXML.Title = "Selecione o Arquivo"

            'Verifica se foi encontrado o Arquivo
            If oArquivoXML.ShowDialog() = DialogResult.OK Then

                'Insere Registo
                oClsFatEntradaNF.InsertNotaFiscal()

                'Seta Controle - Arquivo
                txtArquivoNFe.Text = oArquivoXML.FileName

                'Carrega Arquivo XML
                Dim sArquivoXML As String = File.ReadAllText(oArquivoXML.FileName)

                'Importa Arquivo XML
                sReturn = oClsFatEntradaNF.ImportarXML(sArquivoXML, _
                                                       oArquivoXML.FileName, _
                                                       cboTipoEntrada.SelectedValue)

                lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & oClsFatEntradaNF.CodigoEntradaCapa & ", " & goUsuario.iEmpresa)
                If lCodigoTituloCapa = 0 Then
                    grpTituloPrevisto.Visible = False
                Else
                    grpTituloPrevisto.Visible = True
                End If
                'Verifica se ocorreu um Erro na Importação do Arquivo XML
                If sReturn <> "" Then
                    frmMain.Informacao(Mensagem.Erro, sReturn)
                Else

                    'Se for diferente de NORMAL
                    If cboTipoEntrada.SelectedValue <> 1 Then

                        'Executa a Integração
                        Call Integracao(oClsFatEntradaNF.CodigoEntradaCapa)

                        'Carrega ComboBox
                        Call LoadCombo(cboEmitente, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
                        Call LoadCombo(cboPaisEmitente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
                        Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)

                        'Edita Nota Fiscal
                        Call EditarNotaFiscal(oClsFatEntradaNF.CodigoEntradaCapa, _
                                              CInt(StatusNotaFiscalEntrada.EntradaEfetuadaSucesso), _
                                              False)

                        txtEspecie.Text = "NF-E"


                        ''Valida a fatura
                        'ValidarFatura()

                    Else
                        'Carrega Dados da Empresa
                        Call LoadDadosEmitente()

                        'Abre Formulário de Correlação de Item
                        Dim oForm As New frmFatEntradaNFProdutoXML

                        'Seta Parâmetros
                        oForm.CodigoEntradaCapa = oClsFatEntradaNF.CodigoEntradaCapa
                        oForm.UFEmitente = oClsFatEntradaNF.UFEmitente

                        'Abre o Formuláriio
                        Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                        'Exclui XML
                        oClsFatEntradaNF.DeleteXML()

                        If oForm.Resultado = "S" Then

                            'Executa a Integração
                            Call Integracao(oClsFatEntradaNF.CodigoEntradaCapa)

                            'Carrega ComboBox
                            Call LoadCombo(cboEmitente, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
                            Call LoadCombo(cboPaisEmitente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
                            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)

                            'Move arquivo para a Pasta de Entrada                        
                            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'mover_arquivo_nfe_pasta_entrada'"), Boolean) = True Then
                                'Carrega Configuração da NFe
                                Call LoadConfiguracaoNFe()
                                'Move Arquivo
                                File.Copy(txtArquivoNFe.Text, goConfiguracaoNFe.sPastaEntrada & "\" & txtArquivoNFe.Text.Substring(txtArquivoNFe.Text.LastIndexOf("\") + 1))
                                'Exclui Arquivo Antigo
                                File.Delete(txtArquivoNFe.Text)
                            End If

                            'Edita Nota Fiscal
                            Call EditarNotaFiscal(oClsFatEntradaNF.CodigoEntradaCapa, _
                                                  CInt(StatusNotaFiscalEntrada.EntradaEfetuadaSucesso), _
                                                  False)

                            Select Case cboTipoNotaFiscal.SelectedValue
                                Case CInt(TipoNotaFiscal.NotaFiscal) : txtEspecie.Text = "NF"
                                Case CInt(TipoNotaFiscal.NotaFiscalEletronica) : txtEspecie.Text = "NF-E"
                                Case CInt(TipoNotaFiscal.DACTE) : txtEspecie.Text = "DACTE"
                                Case CInt(TipoNotaFiscal.CTRC) : txtEspecie.Text = "CTRC"
                                Case CInt(TipoNotaFiscal.NFST) : txtEspecie.Text = "NFST"
                                Case CInt(TipoNotaFiscal.NFE) : txtEspecie.Text = "NFE"
                                Case CInt(TipoNotaFiscal.CTE) : txtEspecie.Text = "CTE"
                            End Select

                            'Seta Aba
                            tabDados.SelectedTab = pagDadosNF
                            'Seta Focu
                            cboTipoNotaFiscal.Focus()


                        Else
                            'Limpa Váriavel
                            txtArquivoNFe.Text = ""
                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Insere Capa
            oClsFatEntradaNF.InsertNotaFiscal()

            'Seta Controle
            btnSalvar.Tag = oClsFatEntradaNF.CodigoEntradaCapa

            'Limpa Controles - Identificação
            cboTipoNotaFiscal.SelectedIndex = -1
            cboTipoEntrada.SelectedIndex = -1

            'Limpa Controles - Nota Fiscal
            txtEspecie.Text = ""
            txtNumeroNF.Text = ""
            txtSerieNF.Text = ""
            dtpDataEmissaoNF.Value = Now.Date
            dtpDataEntradaNF.Value = Now

            'Limpa Controles - Nota Fiscal Eletrônica
            txtArquivoNFe.Text = ""
            txtNumeroNFe.Text = ""
            txtSerieNFe.Text = ""
            txtDataEmissaoNFe.Text = ""
            dtpDataEntradaNFe.Value = Now
            txtChaveAcessoNFe.Text = ""
            txtNumeroProtocoloNFe.Text = ""
            txtStatusNFe.Text = ""

            'Limpa Controles
            txtChaveAcessoDACTE.Text = ""

            'Limpa controles dados da despesa
            Dim oClsUsrFinDespesaLancamento As New clsUsrFinDespesaLancamento
            oClsUsrFinDespesaLancamento.LoadGridClassificacao(grdClassificacao, 0)
            Call NovoClassificacao()

            'Limpa Controles - Emitente
            cboEmitente.SelectedIndex = -1
            txtCNPJEmitente.Text = ""
            txtInscricaoEstadualEmitente.Text = ""
            txtInscricaoEstadualSubstitutoTributarioEmitente.Text = ""
            txtCEPEmitente.Text = ""
            cboPaisEmitente.SelectedIndex = -1
            cboUFEmitente.SelectedIndex = -1
            cboMunicipioEmitente.SelectedIndex = -1
            txtLogradouroEmitente.Text = ""
            txtNumeroEmitente.Text = ""
            txtBairroEmitente.Text = ""
            txtComplementoEmitente.Text = ""
            txtTelefoneEmitente.Text = ""
            txtEmailEmitente.Text = ""
            chkLocalEntrega.Checked = False
            chkLocalRetirada.Checked = False

            'Limpa Controles - Item
            grdProduto.DataSource = Nothing
            btnInserirProduto.Visible = False
            btnExcluirProduto.Visible = False

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

            'Limpa Controles - Cobrança
            txtFatura.Text = ""
            txtValorOriginal.Value = 0
            txtValorDesconto.Value = 0
            txtValorLiquido.Value = 0
            cboFormaPagamento.SelectedIndex = -1
            txtNumeroParcela.Value = 0
            txtIntervaloEntreParcelas.Value = 0
            Call ClearUnboundGrid(grdDuplicata)

            'Limpa Controles - Informações Adicionais
            txtInformacaoAdicionalContribuinte.Text = ""
            txtInformacaoAdicionalFisco.Text = ""

            'Limpa Controles - CCe
            txtCCeSequencia.Text = ""
            txtCCeNumeroProtocolo.Text = ""
            txtCCeCorrecao.Text = ""
            dtpCCeDataEvento.Value = Now.Date

            'Limpa Controles - Exportação / Compras
            cboUFEmbarque.SelectedIndex = -1
            txtLocalEmbarque.Text = ""
            txtNotaEmpenho.Text = ""
            txtInformacaoContrato.Text = ""
            txtInformacaoPedido.Text = ""

            oClsFatEntradaNF.LoadGridCriterioAvaliacao(grdQualidade, 0)


            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcDelete)
            btnCalcularDuplicata.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            grdDuplicata.AllowEdit = InheritableBoolean.True
            grdProduto.AllowEdit = InheritableBoolean.True

            'Seta Focu Aba  
            tabDados.SelectedTab = pagDadosNF

            'Seta Focu
            cboTipoNotaFiscal.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mous
            Cursor.Current = Cursors.WaitCursor

            'Insere Dados da Capa
            Call SalvarNotaFiscal()
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

            'Insere Dados da Exportação
            Call SalvarExportacao()
            'Insere Dados da Compras
            Call SalvarCompras()
            'Insere Dados Financeito
            Call SalvarFinanceiro()
            'Insere dados da CCe
            Call SalvarCCe()
            'Integração
            Call Integracao(btnSalvar.Tag)

            'Seta Código Título
            lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

            'Atualiza os dados da despesa
            Call SalvarDadosDespesa()

            'Paga automaticamente 
            PagarEstoque()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarNotaFiscal()

        Try

            'Seta Parametros - Capa
            oClsFatEntradaNF.CodigoTipoEntrada = cboTipoEntrada.SelectedValue
            oClsFatEntradaNF.Especie = txtEspecie.Text
            oClsFatEntradaNF.TipoNotaFiscal = cboTipoNotaFiscal.SelectedValue
            oClsFatEntradaNF.NotaFiscal = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) And cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.CTRC), txtNumeroNF.Text.Trim, txtNumeroNFe.Text.Trim)
            oClsFatEntradaNF.Serie = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) And cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.CTRC), txtSerieNF.Text.Trim, txtSerieNFe.Text.Trim)
            oClsFatEntradaNF.DataEmissao = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) And cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.CTRC), dtpDataEmissaoNF.Value, txtDataEmissaoNFe.Text.Trim)
            oClsFatEntradaNF.DataEntrada = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) And cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.CTRC), dtpDataEntradaNF.Value, dtpDataEntradaNFe.Value)
            oClsFatEntradaNF.FormaPagamento = cboFormaPagamento.SelectedValue
            oClsFatEntradaNF.Inspecao = bInspecao
            oClsFatEntradaNF.ChaveAcessoDACTE = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) And cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.CTRC), "", txtChaveAcessoDACTE.Text.Trim)
            If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Or cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscal.CTRC) Then
                oClsFatEntradaNF.ChaveAcesso = txtChaveAcessoNFe.Text.Trim
                oClsFatEntradaNF.NumeroProtocolo = txtNumeroProtocoloNFe.Text.Trim
                oClsFatEntradaNF.ArquivoNFe = txtArquivoNFe.Text.Trim
                oClsFatEntradaNF.StatusNFe = txtStatusNFe.Text.Trim
            End If
           
            oClsFatEntradaNF.CodigoEntradaCapa = btnSalvar.Tag

            'Verifica o Tipo de Operação
            oClsFatEntradaNF.UpdateNotaFiscal()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirNotaFiscal()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then




                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEntradaNF.DeleteNotaFiscal()

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

    Private Sub GerarPedidoNotaFiscal()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                If MsgBox("Deseja gerar pedido de compra para este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsFatEntradaNF.GerarPedidoNotaFiscal()

                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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

    Private Sub EditarNotaFiscal(ByVal lCodigoEntradaCapa As Long, _
                                 ByVal iStatus As StatusNotaFiscalEntrada, _
                                 ByVal bAprovadoQualidade As Boolean)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Seta Controle
                btnSalvar.Tag = lCodigoEntradaCapa

                oClsFatEntradaNF.CodigoEntradaCapa = lCodigoEntradaCapa

                'Carrega dados da Nota Fiscal
                oClsFatEntradaNF.LoadDadosNotaFiscal(lCodigoEntradaCapa, _
                                                     cboTipoEntrada, _
                                                     cboTipoNotaFiscal, _
                                                     txtNumeroNF, _
                                                     txtEspecie, _
                                                     txtSerieNF, _
                                                     dtpDataEmissaoNF, _
                                                     dtpDataEntradaNF, _
                                                     txtArquivoNFe, _
                                                     txtNumeroNFe, _
                                                     txtSerieNFe, _
                                                     txtDataEmissaoNFe, _
                                                     dtpDataEntradaNFe, _
                                                     txtChaveAcessoNFe, _
                                                     txtChaveAcessoDACTE, _
                                                     txtNumeroProtocoloNFe, _
                                                     txtStatusNFe, _
                                                     cboEmitente, _
                                                     chkLocalRetirada, _
                                                     chkLocalEntrega, _
                                                     cboModalidadeFrete, _
                                                     cboTransportadora, _
                                                     txtBaseCalculoTransporte, _
                                                     txtAliquotaTransporte, _
                                                     txtValorServicoTransporte, _
                                                     cboUFICMSTransporte, _
                                                     cboMunicipioICMSTransporte, _
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
                                                     cboFormaPagamento, _
                                                     txtNumeroParcela, _
                                                     txtIntervaloEntreParcelas, _
                                                     txtInformacaoAdicionalContribuinte, _
                                                     txtInformacaoAdicionalFisco, _
                                                     cboUFEmbarque, _
                                                     txtLocalEmbarque, _
                                                     txtNotaEmpenho, _
                                                     txtInformacaoPedido, _
                                                     txtInformacaoContrato, _
                                                     cboTipoDocumentoPagamento, _
                                                     txtDescritivo, _
                                                     txtCCeSequencia, _
                                                     dtpCCeDataEvento, _
                                                     txtCCeNumeroProtocolo, _
                                                     txtCCeCorrecao)

                'Carrega Grid de Item
                Call oClsFatEntradaNF.LoadGridProduto(lCodigoEntradaCapa, _
                                                      grdProduto)

                'Carrega Grid de Parcela
                Call oClsFatEntradaNF.LoadGridDuplicata(lCodigoEntradaCapa, _
                                                        grdDuplicata)

                'Carrega Grid do Financeiro
                Call oClsFatEntradaNF.LoadGridFinanceiro(lCodigoEntradaCapa, _
                                                         grdFinanceiro)

                'Carrega Grid de Reboque
                Call oClsFatEntradaNF.LoadGridReboque(lCodigoEntradaCapa, _
                                                      grdReboque)

                'Carrega Grid de Volume
                Call oClsFatEntradaNF.LoadGridVolume(lCodigoEntradaCapa, _
                                                     grdVolume)

                'Carrega Grid de Volume
                Call oClsFatEntradaNF.LoadGridVolume(lCodigoEntradaCapa, _
                                                     grdVolume)

                oClsFatEntradaNF.LoadGridCriterioAvaliacao(grdQualidade, lCodigoEntradaCapa)


                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, _
                                       "tb_fat_entrada_capa", _
                                       lCodigoEntradaCapa)

                lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

                'Carrega a classificação
                Dim oClsUsrFinDespesaLancamento As New clsUsrFinDespesaLancamento
                oClsUsrFinDespesaLancamento.LoadGridClassificacao(grdClassificacao, lCodigoTituloCapa)


                'Carrega Combo Titulo Previsto
                Call LoadCombo(cboTituloPrevisto, "sp_select_combo_faturamento_titulo_previsao " & goUsuario.iEmpresa & ", " & IIf(cboEmitente.SelectedIndex = -1, -1, IIf(IsNothing(cboEmitente.SelectedValue), -1, cboEmitente.SelectedValue)))

                oClsFatEntradaNF.LoadDadosVinculoTituloPrevisto(lCodigoTituloCapa, _
                                                                cboTituloPrevisto, _
                                                                txtNumDocumentoPrevisto, _
                                                                txtValorPrevisto, _
                                                                txtTituloDescritivo, _
                                                                cboCentroGastoVinculo)

                If lCodigoTituloCapa = 0 Then
                    grpTituloPrevisto.Visible = False
                Else
                    grpTituloPrevisto.Visible = True
                End If

                'Verifica o Status
                If iStatus = StatusNotaFiscalEntrada.Cancelada Or bAprovadoQualidade = True Then
                    'Desabilita Controles
                    btnSalvar.Enabled = False
                    btnInserirProduto.Enabled = False
                    btnExcluirProduto.Enabled = False
                    btnCalcularDuplicata.Enabled = False
                    grdDuplicata.AllowEdit = InheritableBoolean.False
                    grdProduto.AllowEdit = InheritableBoolean.False
                Else
                    'Habilita Controles
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
                    btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
                    btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcDelete)
                    btnCalcularDuplicata.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
                    grdDuplicata.AllowEdit = InheritableBoolean.True
                    grdProduto.AllowEdit = InheritableBoolean.True
                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                If tabMain.TabPages.Contains(pagDados) = False Then tabMain.TabPages.Add(pagDados)

                'Seta Aba
                tabDados.SelectedTab = pagDadosNF

                'Informa o usuário que a Nota Fiscal não pode ser editada.
                If bAprovadoQualidade = True Then
                    MsgBox("Está nota Fiscal não pode ser Editada porque ela foi Aprovada pela Qualidade.", MsgBoxStyle.Information, Me.Parent.Text)
                End If

                If txtPedidoCompra.Text = "" Then

                    btnVincularPedidoCompra.Enabled = True

                Else

                    btnVincularPedidoCompra.Enabled = False

                End If

                'Seta Focu
                cboTipoNotaFiscal.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarNotaFiscal()

        Try

            'Verifica Status da Nota Fiscal
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusNotaFiscalEntrada.EntradaEfetuadaSucesso) Then

                'Verifica o Tipo de Nota Fiscal
                Select Case grdListagem.CurrentRow.Cells("codigo_tipo_nota_fiscal").Value

                    Case TipoNotaFiscal.NotaFiscalEletronica

                        'Váriaveis Locais
                        Dim sMotivo As String = ""
                        Dim iStatus As Integer = ConsultarSituacaoNF(LoadDescricao("sp_select_faturamento_emissao_entrada_chave_acesso " & grdListagem.CurrentRow.Cells("codigo").Value & ", " & goUsuario.iEmpresa), _
                                                                     sMotivo)

                        'Consulta Situação da Nota Fiscal Eletrônica
                        If iStatus = 101 Or iStatus = 151 Then

                            'Cancela Nota Fiscal de Entrada
                            Call oClsFatEntradaNF.Cancelar(grdListagem.CurrentRow.Cells("codigo").Value, sMotivo)

                            'Integração
                            Call Integracao(grdListagem.CurrentRow.Cells("codigo").Value)

                            'Carrega Grid
                            Call LoadGrid()

                        Else
                            'Informa o Usuário
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                        End If

                    Case Else

                        'Verifica se o Usuário tem direito para Alterar os Dados
                        If VerificaDireito(Formulario.FaturamentoEntradaNF, gcAdministrator) = True Then

                            'Váriavel - Formulário de Cancelamento
                            Dim oForm As New frmFatEntradaNFCancelar

                            'Seta Paramentros
                            oForm.NotaFiscal = grdListagem.CurrentRow.Cells("nota_fiscal").Value
                            oForm.Serie = grdListagem.CurrentRow.Cells("serie").Value
                            oForm.DataEmissao = grdListagem.CurrentRow.Cells("data_emissao").Value
                            oForm.DataEntrada = grdListagem.CurrentRow.Cells("data_entrada").Value
                            oForm.Emitente = grdListagem.CurrentRow.Cells("emitente").Value
                            oForm.CodigoEntradaCapa = grdListagem.CurrentRow.Cells("codigo").Value

                            'Abre Formulário
                            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                            'Carrega Grid
                            Call LoadGrid()

                        Else
                            'Informa o Usuário que ele não tem Direito
                            frmMain.Informacao(Mensagem.DireitoAdministrador)
                        End If

                End Select

            Else
                'Informa o Usuário que a Nota Fiscal está cancelada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarHistorico()

        Try

            'Váriavel - Formulário de Cancelamento
            Dim oForm As New frmFatEntradaNFHistorico

            'Seta Paramentros
            oForm.NotaFiscal = grdListagem.CurrentRow.Cells("nota_fiscal").Value
            oForm.Serie = grdListagem.CurrentRow.Cells("serie").Value
            oForm.DataEmissao = grdListagem.CurrentRow.Cells("data_emissao").Value
            oForm.DataEntrada = grdListagem.CurrentRow.Cells("data_entrada").Value
            oForm.Emitente = grdListagem.CurrentRow.Cells("emitente").Value
            oForm.CodigoEntradaCapa = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Seta Váriavel
            bInspecao = False

            'Verifica se foi Selecionado o Campo - Tipo de Nota Fiscal
            If ValidaCampo(cboTipoNotaFiscal, lblTipoNotaFiscal) = False Then
                tabDados.SelectedTab = pagDadosNF
                cboTipoNotaFiscal.Focus()
                Exit Function
            End If

            'Valida Dados do Emitente
            If ValidacaoEmitente() = False Then
                Exit Function
            End If

            Select Case cboTipoNotaFiscal.SelectedValue

                Case CInt(TipoNotaFiscal.NotaFiscalEletronica), CInt(TipoNotaFiscal.CTRC)

                    'Verifica se foi Preenchido o Campo - Arquivo
                    If ValidaCampo(txtArquivoNFe, lblArquivoNFe, TipoCampo.texto) = False Then
                        tabDados.SelectedTab = pagDadosNF
                        Exit Function
                    End If

                    'Verifica se a Data de Entrada é menor que a Data de Emissão
                    If dtpDataEntradaNFe.Value < txtDataEmissaoNFe.Text Then
                        frmMain.errInfo.SetError(lblDataEntradaNFe, "A Data de Entrada não pode ser menor que a Data de Emissão.")
                        dtpDataEntradaNFe.Focus()
                        Exit Function
                    End If

                    'Verifica se foi a Nota Fiscal é Válida
                    If oClsFatEntradaNF.ValidaDocumento(btnSalvar.Tag, _
                                                        cboTipoNotaFiscal.SelectedValue, _
                                                        txtNumeroNFe.Text, _
                                                        txtSerieNFe.Text, _
                                                        cboEmitente.SelectedValue) = False Then
                        'Informa o Usuário que nf é inválida
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Nota Fiscal já inserida no sistema.")
                        txtNumeroNF.Focus()
                        Exit Function
                    End If

                Case Else

                    'Verifica se foi Preenchido o Campo - Nota Fiscal
                    If ValidaCampo(txtNumeroNF, lblNumeroNF, TipoCampo.numero) = False Then
                        tabDados.SelectedTab = pagDadosNF
                        txtNumeroNF.Focus()
                        Exit Function
                    End If

                    'Verifica se foi Preenchido o Campo - Série
                    'If ValidaCampo(txtSerieNF, lblSerieNF, TipoCampo.texto) = False Then
                    '    tabDados.SelectedTab = pagDadosNF
                    '    txtSerieNF.Focus()
                    '    Exit Function
                    'End If

                    'Verifica se foi a Nota Fiscal é Válida
                    If oClsFatEntradaNF.ValidaDocumento(btnSalvar.Tag, _
                                                        cboTipoNotaFiscal.SelectedValue, _
                                                        txtNumeroNF.Text, _
                                                        txtSerieNF.Text, _
                                                        cboEmitente.SelectedValue) = False Then
                        'Informa o Usuário que nf é inválida
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Nota Fiscal já inserida no sistema.")
                        txtNumeroNF.Focus()
                        Exit Function
                    End If

                    'Verifica se a Data de Entrada é menor que a Data de Emissão
                    If dtpDataEntradaNF.Value < dtpDataEmissaoNF.Value Then
                        frmMain.errInfo.SetError(lblDataEntradaNF, "A Data de Entrada não pode ser menor que a Data de Emissão.")
                        dtpDataEntradaNF.Focus()
                        Exit Function
                    End If

                    'Verifica se foi Selecionado o Campo - Modalidade Frete
                    If ValidaCampo(cboModalidadeFrete, lblModalidadeFrete) = False Then
                        tabDados.SelectedTab = pagTransporte
                        Exit Function
                    End If

                    'Verifica se foi Selecionado o Campo - Forma de Pagamento
                    If ValidaCampo(cboFormaPagamento, lblFormaPagamento) = False Then
                        tabDados.SelectedTab = pagCobranca
                        Exit Function
                    End If

                    'Verifica se foi Preenchido o Campo - Chave de Acesso DACTE
                    If grpDadosDACTE.Enabled = True Then
                        If ValidaCampo(txtChaveAcessoDACTE, lblChaveAcessoDACTE, TipoCampo.numero) = False Then
                            tabDados.SelectedTab = pagDadosNF
                            txtChaveAcessoDACTE.Focus()
                            Exit Function
                        End If
                    End If

                    'Carrega Totais
                    Call LoadTotais()

                    'Carrega Fatura
                    Call LoadFatura()

                    'Valida dados da Fatura
                    If txtValorLiquido.Value > 0 Then
                        If grdDuplicata.GetDataRows.Count = 0 Then
                            frmMain.Informacao(Mensagem.ValidacaoInserir)
                            tabDados.SelectedTab = pagCobranca
                            btnCalcularDuplicata.Focus()
                            Exit Function
                        ElseIf grdDuplicata.GetTotalRow.Cells("valor").Value <> txtValorLiquido.Value Then
                            frmMain.errInfo.SetError(lblValorLiquido, "O Soma do Valor das Duplicatas é diferente do Valor Líquido.")
                            tabDados.SelectedTab = pagCobranca
                            btnCalcularDuplicata.Focus()
                            Exit Function
                        End If
                    End If

            End Select

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Imprimir(ByVal lCodigoEntradaCapa As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_entrada_capa"
            goCrystalReport.sReportParameter(0).sValue = lCodigoEntradaCapa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000006.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("FAT000000006", "Romaneio", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub PagarEstoque()

        Try

            'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            If MsgBox("Deseja pagar estoque", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                oClsFatEntradaNF.UpadatePagarEstoqueRequisicao()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region " ::: DESTINATÁRIO ::: "

    Private Sub SalvarDestinatario()

        Try

            'Salva Dados do Emitente
            oClsFatEntradaNF.DeleteDestinatario()
            oClsFatEntradaNF.InsertDestinatario()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: EMITENTE ::: "

    Private Sub SalvarEmitente()

        Try

            'Seta Parametros
            oClsFatEntradaNF.CodigoEmitente = cboEmitente.SelectedValue
            oClsFatEntradaNF.RazaoSocialEmitente = cboEmitente.Text
            oClsFatEntradaNF.CnpjCpfEmitente = txtCNPJEmitente.Text.Trim
            oClsFatEntradaNF.InscricaoEstadualEmitente = txtInscricaoEstadualEmitente.Text.Trim
            oClsFatEntradaNF.InscricaoEstadualSubstitutoTributarioEmitente = txtInscricaoEstadualSubstitutoTributarioEmitente.Text.Trim
            oClsFatEntradaNF.CodigoRegimeTributario = IIf(cboRegimeTributarioEmitente.SelectedIndex = -1, -1, cboRegimeTributarioEmitente.SelectedValue)
            oClsFatEntradaNF.LogradouroEmitente = txtLogradouroEmitente.Text.Trim
            oClsFatEntradaNF.NumeroEmitente = txtNumeroEmitente.Text.Trim
            oClsFatEntradaNF.ComplementoEmitente = txtComplementoEmitente.Text.Trim
            oClsFatEntradaNF.BairroEmitente = txtBairroEmitente.Text.Trim
            oClsFatEntradaNF.CodigoMunicipioEmitente = cboMunicipioEmitente.SelectedValue
            oClsFatEntradaNF.UFEmitente = cboUFEmitente.SelectedValue
            oClsFatEntradaNF.CepEmitente = txtCEPEmitente.Text.Trim
            oClsFatEntradaNF.CodigoPaisEmitente = cboPaisEmitente.SelectedValue
            oClsFatEntradaNF.TelefoneEmitente = txtTelefoneEmitente.Text.Trim
            oClsFatEntradaNF.EmailEmitente = txtEmailEmitente.Text.Trim
            oClsFatEntradaNF.OutroLugarRetiradaEmitente = chkLocalRetirada.Checked
            oClsFatEntradaNF.OutroLugarEntregaEmitente = chkLocalEntrega.Checked

            'Salva Dados do Destinatário
            oClsFatEntradaNF.DeleteEmitente()
            oClsFatEntradaNF.InsertEmitente()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoEmitente() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEmitente = False

            'Verifica se foi Selecionado o Campo - Emitente
            If ValidaCampo(cboEmitente, lblEmitente) = False Then
                tabDados.SelectedTab = pagEmitente : cboEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CNPJ
            If cboUFEmitente.Text <> "EX" Then
                If ValidaCampo(txtCNPJEmitente, lblCNPJEmitente, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagEmitente : txtCNPJEmitente.Focus()
                    Exit Function
                ElseIf ValidaCNPJ(txtCNPJEmitente.Text) = False Then
                    frmMain.errInfo.SetError(lblCNPJEmitente, "Este CNPJ: " & txtCNPJEmitente.Text.Trim & " não é válido.")
                    tabDados.SelectedTab = pagEmitente : txtCNPJEmitente.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Inscrição Estadual
            If ValidaCampo(txtInscricaoEstadualEmitente, lblInscricaoEstadualEmitente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagEmitente : txtInscricaoEstadualEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Regime Tributário
            If ValidaCampo(cboRegimeTributarioEmitente, lblRegimeTributarioEmitente) = False Then
                tabDados.SelectedTab = pagEmitente : cboRegimeTributarioEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Inscrição Municipal
            If txtCNAEEmitente.Text.Trim <> "" Then
                If ValidaCampo(txtInscricaoMunicipalEmitente, lblInscricaoMunicipalEmitente, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagEmitente : txtInscricaoMunicipalEmitente.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - CNAE
            If txtInscricaoMunicipalEmitente.Text.Trim <> "" Then
                If ValidaCampo(txtCNAEEmitente, lblCNAEEmitente, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagEmitente : txtCNAEEmitente.Focus()
                    Exit Function
                ElseIf txtCNAEEmitente.Text.Length <> 9 Then
                    frmMain.errInfo.SetError(lblCNAEEmitente, "Este CNAE: " & txtCNAEEmitente.Text.Trim & " está incompleto.")
                    tabDados.SelectedTab = pagEmitente : txtCNAEEmitente.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - CEP
            If ValidaCampo(txtCEPEmitente, lblCEPEmitente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagEmitente : txtCEPEmitente.Focus()
                Exit Function
            ElseIf txtCEPEmitente.Text.Length <> 9 Then
                frmMain.errInfo.SetError(lblCEPEmitente, "Este CEP: " & txtCEPEmitente.Text.Trim & " está incompleto.")
                tabDados.SelectedTab = pagEmitente : txtCEPEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPaisEmitente, lblPaisEmitente) = False Then
                tabDados.SelectedTab = pagEmitente : cboPaisEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFEmitente, lblUFEmitente) = False Then
                tabDados.SelectedTab = pagEmitente : cboUFEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - IE Corretamente
            If ValidaIE(cboUFEmitente.SelectedValue, txtInscricaoEstadualEmitente.Text) = False Then
                frmMain.errInfo.SetError(lblCNPJEmitente, "Esta Inscrição Estadual: " & txtInscricaoEstadualEmitente.Text.Trim & " não é válida.")
                tabDados.SelectedTab = pagEmitente : txtInscricaoEstadualEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If ValidaCampo(cboMunicipioEmitente, lblMunicipioEmitente) = False Then
                tabDados.SelectedTab = pagEmitente : cboMunicipioEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouroEmitente, lblLogradouroEmitente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagEmitente : txtLogradouroEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumeroEmitente, lblNumeroEmitente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagEmitente : txtNumeroEmitente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bairro
            If ValidaCampo(txtBairroEmitente, lblBairroEmitente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagEmitente : txtBairroEmitente.Focus()
                Exit Function
            End If

            If txtTelefoneEmitente.Text.Trim.Length > 0 And txtTelefoneEmitente.Text.Trim.Length < 14 Then
                frmMain.errInfo.SetError(lblTelefoneEmitente, "Este Telefone: " & txtTelefoneEmitente.Text.Trim & " está incompleto.")
                tabDados.SelectedTab = pagEmitente : txtTelefoneEmitente.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoEmitente = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LocalRetirada()

        Try

            'Váriaveis Locais
            Dim oForm As New frmFatEntradaNFLocalRetirada
            'Seta Parametros
            oForm.CodigoEntradaCapa = oClsFatEntradaNF.CodigoEntradaCapa
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
            Dim oForm As New frmFatEntradaNFLocalEntrega
            'Seta Parametros
            oForm.CodigoEntradaCapa = oClsFatEntradaNF.CodigoEntradaCapa
            oForm.btnSalvar.Enabled = btnSalvar.Enabled
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: TOTAL ::: "

    Private Sub SalvarTotal()

        Try

            'Seta Parametros
            oClsFatEntradaNF.BaseCalculoICMS = txtBaseCalculoICMS.Value
            oClsFatEntradaNF.TotalICMS = txtTotalICMS.Value
            oClsFatEntradaNF.BaseCalculoICMSST = txtBaseCalculoICMSST.Value
            oClsFatEntradaNF.TotalICMSST = txtTotalICMSST.Value
            oClsFatEntradaNF.TotalProdutoServico = txtTotalProdutoServico.Value
            oClsFatEntradaNF.TotalFrete = txtTotalFrete.Value
            oClsFatEntradaNF.TotalSeguro = txtTotalSeguro.Value
            oClsFatEntradaNF.TotalDesconto = txtTotalDesconto.Value
            oClsFatEntradaNF.TotalII = txtTotalII.Value
            oClsFatEntradaNF.TotalIPI = txtTotalIPI.Value
            oClsFatEntradaNF.PIS = txtTotalPIS.Value
            oClsFatEntradaNF.COFINS = txtTotalCOFINS.Value
            oClsFatEntradaNF.OutrasDespesas = txtOutrasDespesas.Value
            oClsFatEntradaNF.TotalNotaFiscal = txtTotalNotaFiscal.Value
            oClsFatEntradaNF.ValorRetidoPIS = 0
            oClsFatEntradaNF.ValorRetidoCOFINS = 0
            oClsFatEntradaNF.ValorRetidoCSLL = 0
            oClsFatEntradaNF.BaseCalculoIRRF = 0
            oClsFatEntradaNF.ValorRetidoIRRF = 0
            oClsFatEntradaNF.BaseCalculoRetencaoPrevidenciaSocial = 0
            oClsFatEntradaNF.RetencaoPrevidenciaSocial = 0
            oClsFatEntradaNF.BaseCalculoISS = 0
            oClsFatEntradaNF.TotalISS = 0
            oClsFatEntradaNF.PISSobreServico = 0
            oClsFatEntradaNF.COFINSSobreServico = 0
            oClsFatEntradaNF.TotalServicoNaoTributadoICMS = 0
            oClsFatEntradaNF.ValorDestinoICMSPartilha = txtTotalICMSDestino.Value
            oClsFatEntradaNF.ValorFCPICMSPartilha = txtTotalFCP.Value
            oClsFatEntradaNF.ValorRemetenteICMSPartilha = txtTotalICMSRemetente.Value

            'Salva Dados Total
            oClsFatEntradaNF.DeleteTotal()
            oClsFatEntradaNF.InsertTotal()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTotais()

        Try
            Call oClsFatEntradaNF.LoadDadosTotal(txtBaseCalculoICMS, _
                                                 txtTotalICMS, _
                                                 txtBaseCalculoICMSST, _
                                                 txtTotalICMSST, _
                                                 txtTotalProdutoServico, _
                                                 txtTotalIPI, _
                                                 txtTotalII, _
                                                 txtTotalPIS, _
                                                 txtTotalCOFINS, _
                                                 txtTotalFrete, _
                                                 txtTotalSeguro, _
                                                 txtTotalDesconto, _
                                                 txtOutrasDespesas, _
                                                 txtTotalFCP, _
                                                 txtTotalICMSRemetente, _
                                                 txtTotalICMSDestino)

            txtTotalNotaFiscal.Value = txtTotalProdutoServico.Value + txtOutrasDespesas.Value + txtTotalFrete.Value + txtTotalSeguro.Value + txtTotalIPI.Value  'txtTotalICMS.Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: INFORMAÇÕES ADICIONAIS ::: "

    Private Sub SalvarInformacoesAdicionais()

        Try

            'Seta Parametros
            oClsFatEntradaNF.InformacaoAdicionalContribuinte = txtInformacaoAdicionalContribuinte.Text.Trim

            'Salva Dados Informaççoes Adicionais
            oClsFatEntradaNF.DeleteInformacaoAdicional()
            oClsFatEntradaNF.InsertInformacaoAdicional()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: CC-E ::: "

    Private Sub SalvarCCe()

        Try

            Cursor.Current = Cursors.WaitCursor

            'Salva Dados Total
            oClsFatEntradaNF.DeleteCCe()

            If txtCCeNumeroProtocolo.Text <> "" Then

                oClsFatEntradaNF.InsertCCe(txtCCeSequencia.Text.Trim, _
                                           dtpCCeDataEvento.Value, _
                                           txtCCeNumeroProtocolo.Text.Trim, _
                                           txtCCeCorrecao.Text.Trim)

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: FATURA ::: "

    Private Sub SalvarFatura()

        Try

            'Deleta Dados da Fatura
            oClsFatEntradaNF.DeleteFatura()

            'Seta Parametros
            oClsFatEntradaNF.Fatura = txtFatura.Text.Trim
            oClsFatEntradaNF.ValorOriginal = txtValorOriginal.Value
            oClsFatEntradaNF.ValorDesconto = txtValorDesconto.Value
            oClsFatEntradaNF.ValorLiquido = txtValorLiquido.Value
            oClsFatEntradaNF.NumeroParcela = txtNumeroParcela.Value
            oClsFatEntradaNF.IntervaloParcela = txtIntervaloEntreParcelas.Value

            'Salva Dados Fatura
            oClsFatEntradaNF.InsertFatura()
            oClsFatEntradaNF.InsertFaturaDuplicata(grdDuplicata)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDadosDespesa()

        Try

            'Para não influenciar os outros clientes
            If goDatabase.sInitialCatalog <> "INTERACTI_NORSUL_PRD" Then Exit Sub

            'Exclui a classificação inicialmente
            Dim oClsUsrFinDespesaLancamento As New clsUsrFinDespesaLancamento
            oClsUsrFinDespesaLancamento.DeleteClassificacao(lCodigoTituloCapa)

            'Lança a classificaçao
            oClsUsrFinDespesaLancamento.CodigoDespesaCapa = lCodigoTituloCapa
            oClsUsrFinDespesaLancamento.InsertClassificacao(grdClassificacao)

            'Altera outros dados
            oClsFatEntradaNF.UpdateDadosDespesa(lCodigoTituloCapa, _
                                                IIf(cboTipoDocumentoPagamento.SelectedIndex = -1, -1, cboTipoDocumentoPagamento.SelectedValue), _
                                                txtDescritivo.Text)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadFatura()

        Try

            Call oClsFatEntradaNF.LoadDadosFatura(txtValorOriginal, _
                                                  txtValorDesconto, _
                                                  txtValorAcrescimo, _
                                                  IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadNFFatura()

        Try

            Call oClsFatEntradaNF.LoadDadosNFFatura(txtValorOriginal, _
                                                  txtValorDesconto, _
                                                  txtValorAcrescimo, _
                                                  IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: FINANCEIRO ::: "

    Private Sub SalvarFinanceiro()

        Try

            'Deleta Dados da Fatura
            oClsFatEntradaNF.DeleteFinanceiro()

            'Salva Dados Fatura - Financeiro
            oClsFatEntradaNF.InsertFinanceiro(grdFinanceiro)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDadosFinanceiro()

        Try

            'Para não influenciar os outros clientes
            If goDatabase.sInitialCatalog <> "INTERACTI_NORSUL_PRD" Then Exit Sub

            'Exclui a classificação inicialmente
            Dim oClsUsrFinDespesaLancamento As New clsUsrFinDespesaLancamento
            oClsUsrFinDespesaLancamento.DeleteClassificacao(lCodigoTituloCapa)

            'Lança a classificaçao
            oClsUsrFinDespesaLancamento.CodigoDespesaCapa = lCodigoTituloCapa
            oClsUsrFinDespesaLancamento.InsertClassificacao(grdClassificacao)

            'Altera outros dados
            oClsFatEntradaNF.UpdateDadosDespesa(lCodigoTituloCapa, _
                                                IIf(cboTipoDocumentoPagamento.SelectedIndex = -1, -1, cboTipoDocumentoPagamento.SelectedValue), _
                                                txtDescritivo.Text)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadFinanceiro()

        Try

            Call oClsFatEntradaNF.LoadDadosFatura(txtValorOriginal, _
                                                  txtValorDesconto, _
                                                  txtValorAcrescimo, _
                                                  IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadNFFinanceiro()

        Try

            Call oClsFatEntradaNF.LoadDadosNFFatura(txtValorOriginal, _
                                                  txtValorDesconto, _
                                                  txtValorAcrescimo, _
                                                  IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue))

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

#Region "::: DADOS DA DESPESA :::"

#Region "::: CLASSIFICAÇÃO :::"

    Private Sub InserirClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoClassificacao() = True Then

                'Váriaveis - Update
                Dim iCodigoCentroGastoAntigo As Integer = -1
                Dim sCodigoContaContabilAntigo As String = ""

                'Carrega Váriaveis
                If IsNumeric(btnInserirClassificao.Tag) Then
                    iCodigoCentroGastoAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value), -1, grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value)
                    sCodigoContaContabilAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value), "", grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value)
                End If

                'Insere Registro na Grid
                Dim oClsFinDespesaLancamento As New clsUsrFinDespesaLancamento
                oClsFinDespesaLancamento.InsertClassificacaoGrid(grdClassificacao, _
                                                                 IIf(cboCentroGasto.SelectedIndex = -1, "", cboCentroGasto.Text), _
                                                                 IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.Text), _
                                                                 txtValorClassificacao.Value, _
                                                                 IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                                 IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                                 IIf(IsNumeric(btnInserirClassificao.Tag), "U", "I"), _
                                                                 iCodigoCentroGastoAntigo, _
                                                                 sCodigoContaContabilAntigo)

                'Limpa Formulário
                Call NovoClassificacao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarClassificacao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = True Then

                'Carrega Controles
                cboCentroGasto.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value
                cboContaContabil.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value
                txtValorClassificacao.Value = grdClassificacao.CurrentRow.Cells("valor").Value
                btnInserirClassificao.Tag = grdClassificacao.CurrentRow.RowIndex

                'Seta Focu
                cboCentroGasto.Focus()

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

    Private Sub DeleteClassificacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdClassificacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Dim i As Integer

                    For i = 0 To UBound(gSelecaoRow)
                        gSelecaoRow(i).Delete()
                    Next

                    'Limpa Formulário
                    Call NovoClassificacao()

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

    Private Sub NovoClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtValorClassificacao.Value = 0
            btnInserirClassificao.Tag = ""

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoClassificacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoClassificacao = False

            'Verifica se foi Selecionado o Campo - Centro de Gasto ou Conta Contábil
            If cboCentroGasto.SelectedIndex = -1 And cboContaContabil.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(lblCentroGasto, "Primeiramente Selecione um Centro de Gasto ou uma Conta Contábil.")
                cboCentroGasto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorClassificacao, lblValorClassificacao, True) = False Then
                Exit Function
            End If

            'Valida se a Soma do Valor Classificação é maior que o Valor Total
            Dim dValor, dValorTotal As Double

            If IsNumeric(btnInserirClassificao.Tag) Then
                dValor = grdClassificacao.CurrentRow.Cells("valor").Value
            End If
            If grdClassificacao.GetDataRows.Count > 0 Then
                dValorTotal = grdClassificacao.GetTotalRow.Cells("valor").Value
            End If
            'If (txtValorLiquido.Value < FormatNumber((dValorTotal - dValor + txtValorClassificacao.Value), 2)) Then
            '    frmMain.errInfo.SetError(lblValorClassificacao, "A Soma dos Valores (Classificação) não pode ser maior que o Valor Total.")
            '    Exit Function
            'End If

            'Seta Retorno da Função
            ValidacaoClassificacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

#Region " ::: COMPRAS ::: "

    Private Sub SalvarCompras()

        Try

            'Deleta Dados da Compras
            oClsFatEntradaNF.DeleteCompras()

            'Seta Parametros
            oClsFatEntradaNF.NotaEmpenho = txtNotaEmpenho.Text.Trim
            oClsFatEntradaNF.InformacaoPedido = txtInformacaoPedido.Text.Trim
            oClsFatEntradaNF.InformacaoContrato = txtInformacaoContrato.Text.Trim

            'Salva Dados Compras
            oClsFatEntradaNF.InsertCompras()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub IntegracaoComprasRetornoConserto()

        Try

            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcAdministrator) = True Then

                If grdListagem.CurrentRow.Cells("tipo_operacao").Value = "DEVOLUÇÃO DE NOTA FISCAL" Then

                    'Váriavel - Formulário de Cancelamento
                    Dim oForm As New frmFatEntradaNFPedidoCompra

                    'Seta Paramentros
                    oForm.CodigoEntradaCapa = grdListagem.CurrentRow.Cells("codigo_entrada_capa").Value
                    oForm.CodigoEntradaItem = grdListagem.CurrentRow.Cells("codigo_entrada_item").Value
                    oForm.CodigoEmitente = grdListagem.CurrentRow.Cells("codigo_emitente").Value

                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    Call LoadGrid()

                Else
                    MsgBox("A operação não é Devolução de Nota Fiscal", MsgBoxStyle.Information, "Validação")
                End If

            End If

            Cursor.Current = Cursors.WaitCursor

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: EXPORTAÇÃO ::: "

    Private Sub SalvarExportacao()

        Try

            'Deleta Dados da Exportação
            oClsFatEntradaNF.DeleteExportacao()

            If cboUFEmbarque.SelectedIndex <> -1 Then

                'Seta Parametros
                oClsFatEntradaNF.UFEmbarque = cboUFEmbarque.SelectedValue
                oClsFatEntradaNF.LocalEmbarque = txtLocalEmbarque.Text.Trim

                'Salva Dados Exportação
                oClsFatEntradaNF.InsertExportacao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: PRODUTO ::: "

    Private Sub ImprimirEtiqueta()

        Try

            Dim oForm As New frmQAInspecaoEtiqueta
            oForm.CodigoEntradaItem = grdListagem.GetValue("codigo_entrada_item")
            oForm.CodigoEntradaCapa = grdListagem.GetValue("codigo_entrada_capa")

            If Not IsDBNull(grdListagem.GetValue("codigo_item_entrada_vinculo")) Then
                oForm.CodigoEntradaVinculo = grdListagem.GetValue("codigo_item_entrada_vinculo")
            Else
                oForm.CodigoEntradaVinculo = -1
            End If

            oForm.ShowDialog()

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
                    Call oClsFatEntradaNF.DeleteProduto()

                    'Integração
                    Call Integracao(grdListagem.CurrentRow.Cells("codigo").Value)

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

            'Verifica se foi Selecionado o Campo - Tipo de Nota Fiscal
            If ValidaCampo(cboTipoNotaFiscal, lblTipoNotaFiscal) = False Then
                tabDados.SelectedTab = pagDadosNF
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Emitente
            If cboTipoNotaFiscal.SelectedValue <> TipoNotaFiscal.NotaFiscalEletronica Then
                If ValidaCampo(cboEmitente, lblEmitente) = False Then
                    tabDados.SelectedTab = pagEmitente
                    cboEmitente.Focus()
                    Exit Sub
                End If
            End If

            'Verifica se foi Selecionado o Campo - Regime Tributário
            If cboTipoNotaFiscal.SelectedValue <> TipoNotaFiscal.NotaFiscalEletronica Then
                If ValidaCampo(cboRegimeTributarioEmitente, lblRegimeTributarioEmitente) = False Then
                    tabDados.SelectedTab = pagEmitente
                    cboRegimeTributarioEmitente.Focus()
                    Exit Sub
                End If
            End If

            'Váriavel - Formulário de Cadastro de Produto
            Dim oForm As New frmFatEntradaNFProduto

            'Seta Parametros
            oForm.TipoDocumento = TipoDocumentoFiscal.Entrada
            oForm.CodigoParceiroNegocio = cboEmitente.SelectedValue
            oForm.UFDestinatario = cboUFEmitente.SelectedValue
            oForm.CodigoEntradaItem = -1
            oForm.CodigoEntradaCapa = btnSalvar.Tag
            oForm.CodigoRegimeTributario = cboRegimeTributarioEmitente.SelectedValue

            'Verifica se ja foi Incluido algum Item
            If grdProduto.GetDataRows.Count > 0 Then
                'Seta Parametros
                Dim oRow() As GridEXRow = grdProduto.GetDataRows
                oForm.CFOP = oRow(UBound(oRow)).Cells("codigo_cfop").Value
                oForm.SituacaoTributariaICMS = oRow(UBound(oRow)).Cells("situacao_tributaria_icms").Value
                oForm.SituacaoTributariaIPI = IIf(IsDBNull(oRow(UBound(oRow)).Cells("situacao_tributaria_ipi").Value), "", oRow(UBound(oRow)).Cells("situacao_tributaria_ipi").Value)
                oForm.SituacaoTributariaPIS = oRow(UBound(oRow)).Cells("situacao_tributaria_pis").Value
                oForm.SituacaoTributariaCOFINS = oRow(UBound(oRow)).Cells("situacao_tributaria_cofins").Value
            End If

            'Seta Tamanho / Posição do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Grid de Item
            Call oClsFatEntradaNF.LoadGridProduto(btnSalvar.Tag, _
                                                  grdProduto)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Verifica se o Tipo de Nota Fiscal é NFe
            'If cboTipoNotaFiscal.SelectedValue = TipoNotaFiscal.NotaFiscalEletronica Then

            '    'Informa o Usuário que Nota Fiscal não pode ser editada
            '    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)

            'ElseIf btnSalvar.Enabled = False Then

            '    'Informa o Usuário que Nota Fiscal não pode ser editada
            '    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)

            'Else

            'Verifica se foi Selecionado o Campo - Tipo de Nota Fiscal
            If ValidaCampo(cboTipoNotaFiscal, lblTipoNotaFiscal) = False Then
                tabDados.SelectedTab = pagDadosNF
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Emitente
            If cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                If ValidaCampo(cboEmitente, lblEmitente) = False Then
                    tabDados.SelectedTab = pagEmitente
                    cboEmitente.Focus()
                    Exit Sub
                End If
            End If

            'Verifica se foi Selecionado o Campo - Regime Tributário
            If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                If ValidaCampo(cboRegimeTributarioEmitente, lblRegimeTributarioEmitente) = False Then
                    tabDados.SelectedTab = pagEmitente
                    cboRegimeTributarioEmitente.Focus()
                    Exit Sub
                End If
            End If

            'Váriavel - Formulário de Cadastro de Produto
            Dim oForm As New frmFatEntradaNFProduto

            'Configura Tamanho / Posição
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Parametros
            oForm.TipoDocumento = TipoDocumentoFiscal.Entrada
            oForm.CodigoParceiroNegocio = cboEmitente.SelectedValue
            oForm.UFDestinatario = cboUFEmitente.SelectedValue
            oForm.CodigoEntradaItem = grdProduto.CurrentRow.Cells("codigo_entrada_item").Value
            oForm.CodigoEntradaCapa = btnSalvar.Tag
            oForm.CodigoRegimeTributario = cboRegimeTributarioEmitente.SelectedValue

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Integração
            Call Integracao(grdListagem.CurrentRow.Cells("codigo").Value)

            'Carrega Grid de Item
            Call oClsFatEntradaNF.LoadGridProduto(btnSalvar.Tag, _
                                                  grdProduto)

            'End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: TRANSPORTE ::: "

    Private Sub SalvarTransporte()

        Try

            'Seta Parametros            
            oClsFatEntradaNF.CodigoModalidadeFrete = cboModalidadeFrete.SelectedValue
            oClsFatEntradaNF.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsFatEntradaNF.CnpjCpfTransportadora = txtCNPJTransportadora.Text.Trim
            oClsFatEntradaNF.InscricaoEstadualTransportadora = txtInscricaoEstadualTransportadora.Text.Trim
            oClsFatEntradaNF.UFTransportadora = cboUFTransportadora.SelectedValue
            oClsFatEntradaNF.MunicipioTransportadora = cboMunicipioTransportadora.Text
            oClsFatEntradaNF.EnderecoTransportadora = txtEnderecoTransportadora.Text.Trim
            oClsFatEntradaNF.BaseCalculoTransporte = txtBaseCalculoTransporte.Value
            oClsFatEntradaNF.AliquotaICMSTransporte = txtAliquotaTransporte.Value
            oClsFatEntradaNF.ValorServicoTransporte = txtValorServicoTransporte.Value
            oClsFatEntradaNF.ValorICMSRetidoTransporte = txtICMSRetidoTransporte.Text.Trim
            oClsFatEntradaNF.UFICMSTransporte = cboUFICMSTransporte.SelectedValue
            oClsFatEntradaNF.CodigoMunicipioICMSTransporte = IIf(cboMunicipioICMSTransporte.SelectedIndex = -1, -1, cboMunicipioICMSTransporte.SelectedValue)
            oClsFatEntradaNF.TipoVeiculo = IIf(cboTipoVeiculo.SelectedIndex = -1, -1, cboTipoVeiculo.SelectedValue)
            oClsFatEntradaNF.CodigoCFOPTransporte = IIf(cboCFOPICMSTransporte.SelectedIndex = -1, -1, cboCFOPICMSTransporte.Text)
            oClsFatEntradaNF.UFPlacaVeiculo = cboUFVeiculo.SelectedValue
            oClsFatEntradaNF.PlacaVeiculo = txtPlacaVeiculo.Text.Trim
            oClsFatEntradaNF.RNTCVeiculo = txtRNTCVeiculo.Text.Trim
            oClsFatEntradaNF.Vagao = txtVagao.Text.Trim
            oClsFatEntradaNF.Balsa = txtBalsa.Text.Trim

            'Salva Dados Transporte
            oClsFatEntradaNF.DeleteTransporte()
            oClsFatEntradaNF.InsertTransporte()

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
                    Call oClsFatEntradaNF.DeleteReboque()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGridReboque()

        Try

            'Carrega Grid
            oClsFatEntradaNF.LoadGridReboque(btnSalvar.Tag, _
                                             grdReboque)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
                oClsFatEntradaNF.InsertReboque(txtPlacaReboque.Text.Trim, _
                                               cboUFReboque.SelectedValue, _
                                               txtRNTCReboque.Text.Trim)


            Else

                'Atualiza Reboque
                oClsFatEntradaNF.UpdateReboque(txtPlacaReboque.Text.Trim, _
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
            If oClsFatEntradaNF.ValidaReboque(txtPlacaReboque.Text, _
                                              IIf(btnInserirReboque.Tag = "", "", btnInserirReboque.Tag)) = False Then
                'Informa essa Placa já está associada a um outro Cliente
                frmMain.errInfo.SetError(lblPlacaReboque, "Esta Placa: " & txtPlacaReboque.Text & " já está associada a um outro Registro.")
                tabDados.SelectedTab = pagTransporte
                tabTransporte.SelectedTab = pagVeiculo
                txtPlacaReboque.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoReboque = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Private Sub ExcluirVolume()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdVolume) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEntradaNF.DeleteVolume()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGridVolume()

        Try

            'Carrega Grid
            oClsFatEntradaNF.LoadGridVolume(btnSalvar.Tag, _
                                            grdVolume)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
                oClsFatEntradaNF.InsertVolume(txtQuantidadeEmbalagemTransportadora.Value, _
                                              txtEspecieTransportadora.Text.Trim, _
                                              txtMarcaTransportadora.Text.Trim, _
                                              txtNumeroTransportadora.Text.Trim, _
                                              txtPesoLiquidoTransportadora.Value, _
                                              txtPesoBrutoTransportadora.Value)


            Else

                'Atualiza Reboque
                oClsFatEntradaNF.UpdateVolume(txtQuantidadeEmbalagemTransportadora.Value, _
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

#Region " ::: INTEGRAÇÃO ::: "

    Private Sub Integracao(ByVal lCodigoEntradaCapa As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Integração - Compras
            oClsIntegracao.IntegracaoNFEntradaCompras(lCodigoEntradaCapa)
            'Integração - Estoque
            oClsIntegracao.IntegracaoNFEntradaEstoque(lCodigoEntradaCapa)
            'Integração - Financeiro
            oClsIntegracao.IntegracaoNFEntradaFinanceiro(lCodigoEntradaCapa, _
                                                         IIf(grdFinanceiro.RowCount > 0, True, False))

            'Pagamento
            Call Pagamento()


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

                oForm.UsrControl = "usrFinDespesaPagamento"
                oForm.Titulo = "Financeiro - Despesa - Conciliação Bancária"

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
                    oDataRow("numero_documento") = txtNumeroNF.Text.Trim
                    oDataRow("parcela") = oRow.RowIndex + 1 & " DE " & grdDuplicata.GetDataRows.Count
                    oDataRow("descritivo") = "NOTA FISCAL: " & txtNumeroNF.Text.Trim
                    oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                    oDataRow("valor_total") = oRow.Cells("valor").Value
                    oDataRow("valor_pago") = 0
                    oDataRow("juros") = 0
                    oDataRow("desconto") = 0
                    oDataRow("valor_devido") = oRow.Cells("valor").Value
                    oDataRow("codigo_titulo_capa") = oClsFatEntradaNF.CodigoTituloFinanceiro
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

#Region " ::: NOTA FISCAL ELETRÔNICA ::: "

    Private Function ConsultarSituacaoNF(ByVal sChaveAcesso As String, _
                                         Optional ByRef sMotivo As String = "") As Integer

        'Váriaveis Locais
        Dim oClsNFeConsultaSituacao As New clsNFeConsultaSituacao_V4

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmetros
            oClsNFeConsultaSituacao.ChaveAcesso = sChaveAcesso

            'Carrega Configurações da NFe
            Call LoadConfiguracaoNFe()

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Consulta Situação
            If oClsNFeConsultaSituacao.Send() = True Then

                'Carrega Arquivo
                oClsNFeConsultaSituacao.LoadArquivo(oClsNFeConsultaSituacao.PathArquivoRetorno)

                'Exclui Arquivo de Envio e Arquivo de Retorno
                File.Delete(oClsNFeConsultaSituacao.PathArquivoEnvio)
                File.Delete(oClsNFeConsultaSituacao.PathArquivoRetorno)

                'Verifica Retorno do Status da NF
                If oClsNFeConsultaSituacao.Status = 100 Then
                    Return oClsNFeConsultaSituacao.Status
                Else
                    sMotivo = oClsNFeConsultaSituacao.Motivo
                    frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaSituacao.Motivo)
                    Return oClsNFeConsultaSituacao.Status
                End If

            Else

                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaSituacao.MensagemErro)
                Return -1

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Retorno da Função
            Return -1
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

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
                        modFunction.DeleteArquivoBD("tb_fat_entrada_capa", oRow.Cells("path").Value, btnSalvar.Tag)
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
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcUpdate) = True Then

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