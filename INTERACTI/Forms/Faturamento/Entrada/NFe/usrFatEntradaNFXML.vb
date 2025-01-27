Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO 
Imports System.Math
'Imports INTERACTI.NFe.ProcNFe_V2

Public Class usrFatEntradaNFXML

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEntradaNFXML As New clsUsrFatEntradaNFXML
    Private bInspecao As Boolean
    Private lCodigoTituloCapa As Long
    Private lCodigoEntradaCapa As Long
    Private sUFEmitente As String
    Private sResultado As String
    Private oCurrentRow As GridEXRow

    Private lCodigoItem As Long
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private iCodigoPedidoItemEntrega As Integer
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private iCodigoEntradaItem As Integer
    Private iCodigoEntradaItemLote As Integer
    Private iCodigoParceiroNegocio As Integer
    Private sInformacoesAdicionais As String
    Private dQuantidadeXML As Double

    Private iCodigoUnidadeMedida As Integer
    Private bCFOPEstoque As Boolean
    Private bItemEstoque As Boolean
    Private bControlaQualidade As Boolean
    Private bControlaLote As Boolean
    Private bDataFabricacao As Boolean
    Private bDataValidade As Boolean
    Private dQuantidadePedido As Double
    Private dQuantidadePendente As Double
    Private dValorUnitario As Double
    Private dFatorConversao As Double
    Private sUnidadeMedida As String
    Private dToleranciaQuantidadePercentual As Double
    Private dToleranciaValor As Double
    Private iCodigoCentroGasto As Integer
    Private sContaContabil As String

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public WriteOnly Property UFEmitente() As String
        Set(ByVal value As String)
            sUFEmitente = value
        End Set
    End Property

    Public ReadOnly Property Resultado() As String
        Get
            Return sResultado
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region " ::: DADOS GERAIS ::: "

    Private Sub usrFatEntradaNFXML_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrFatEntradaNFXML_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region " ::: NOTA FISCAL ::: "

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Nota Fiscal
            Call ExcluirNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarXML.Click
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
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFXML
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

            'Abre Rotina para Importar Arquivo XML
            Call ImportarArquivoXML()

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
            oClsFatEntradaNFXML.InsertNotaFiscal()

            'Seta Controle
            btnSalvar.Tag = oClsFatEntradaNFXML.CodigoEntradaCapa

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

            'Limpa Controle
            cboNumeroDocumento.Text = ""
            cboUnidadeMedida.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""
            cboCFOP.Text = ""
            cboTipoOperacao.Text = ""
            cboProduto.Text = ""
            txtQuantidade.Text = ""
            txtQuantidadeEstoque.Text = ""
            cboDeposito.Text = ""

            'Limpa Grid
            grdRecebimento.DataSource = Nothing

            'Limpa Grid
            grdXML.DataSource = Nothing

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
            'If Validacao() = True Then

            'Salva Dados do Registro
            Call Salvar()

            'End If

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

                Case CInt(TipoNotaFiscal.NotaFiscalEletronica)
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

                Case CInt(TipoNotaFiscal.DACTE)
                    txtEspecie.Text = "DACTE"
                    grpDadosNFe.Enabled = False
                    grpDadosNF.Enabled = True
                    grpDadosDACTE.Enabled = True
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

                Case CInt(TipoNotaFiscal.CTE)
                    txtEspecie.Text = "CTE"
                    grpDadosNFe.Enabled = False
                    grpDadosNF.Enabled = True
                    grpDadosDACTE.Enabled = True
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

                Case CInt(TipoNotaFiscal.CTRC)
                    txtEspecie.Text = "CTRC"
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

                    'grdListagem.CurrentRow.Cells("aprovado_qualidade").Value)
                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "cancelar" : Call CancelarNotaFiscal()
                Case "historico" : Call VisualizarHistorico()

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
                                     Formulario.FaturamentoEntradaNFXML, _
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
                                     Formulario.FaturamentoEntradaNFXML)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEntradaNFXML, _
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

            End Select

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
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFXML
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.FaturamentoEntradaNFXML)

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

    Private Sub btnEditarGridProduto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditarGridProduto.Click

        Try

            'Váriaveis Locais
            Dim sCampo(3) As String

            'Carrega Valores
            sCampo(0) = "codigo_produto_interno"
            sCampo(1) = "codigo_cfop"
            sCampo(2) = "lote"
            sCampo(3) = "codigo_deposito"

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
                                     Formulario.FaturamentoEntradaNFXML, _
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
                                     Formulario.FaturamentoEntradaNFXML)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.FaturamentoEntradaNFXML, _
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
            Dim sQuery As String
            Dim sQueryLote As String

            sQuery = "WHERE (((codigo_entrada_capa) = " & btnSalvar.Tag & ") "
            sQuery = sQuery & "AND ((codigo_empresa) = " & goUsuario.iEmpresa & ") "
            sQuery = sQuery & "AND ((codigo) = " & grdProduto.GetValue("codigo_entrada_item") & "))"

            sQueryLote = "WHERE (((codigo_entrada_capa) = " & btnSalvar.Tag & ") "
            sQueryLote = sQueryLote & "AND ((codigo_empresa) = " & goUsuario.iEmpresa & ") "
            sQueryLote = sQueryLote & "AND ((codigo_entrada_item) = " & grdProduto.GetValue("codigo_entrada_item") & ") "
            sQueryLote = sQueryLote & "AND ((codigo) = " & grdProduto.GetValue("codigo_entrada_item_lote") & "))"

            Select Case e.Column.Key

                Case "codigo_produto_interno"
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item', 'codigo_item', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, grdProduto.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item', 'codigo_produto_servico', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, "'" & grdProduto.CurrentRow.Cells(e.Column.Key).Text.ToString.Replace("'", "") & "'", "'NULL'") & ",'" & sQuery & "'")

                Case "lote"
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item_lote', 'lote', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, "'" & grdProduto.CurrentRow.Cells(e.Column.Key).Text.ToString.Replace("'", "") & "'", "'NULL'") & ",'" & sQueryLote & "'")

                Case "codigo_deposito"
                    Call ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_item_lote', 'codigo_deposito', " & IIf(IsDBNull(grdProduto.GetValue(e.Column.Key)) = False, grdProduto.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQueryLote & "'")

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
            oClsFatEntradaNFXML.GerarDuplicata(grdDuplicata, _
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
            oClsFatEntradaNFXML.LoadControlesTituloPrevisao(cboTituloPrevisto.SelectedValue, _
                                                         txtNumDocumentoPrevisto, _
                                                         txtValorPrevisto, _
                                                         cboCentroGasto, _
                                                         txtTituloDescritivo)

            'Verifica se Existe Código do Titulo Capa
            If lCodigoTituloCapa <= 0 Then

                'Seta Código Título
                lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

            End If

            'Verifica se Existe Código do Titulo Capa
            If lCodigoTituloCapa > 0 Then

                'Atualiza Título
                oClsFatEntradaNFXML.UpdateVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue, _
                                                             lCodigoTituloCapa, _
                                                             IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                             txtTituloDescritivo.Text.ToString, _
                                                             txtNumDocumentoPrevisto.Text.ToString, _
                                                             txtValorPrevisto.Text.ToString)

                'Deleta Títuo Vinculado
                oClsFatEntradaNFXML.DeleteVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue)

                'Desabilita Controles
                cboTituloPrevisto.Enabled = False
                txtNumDocumentoPrevisto.Enabled = False
                txtValorPrevisto.Enabled = False
                cboCentroGasto.Enabled = False
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
            oClsFatEntradaNFXML.LoadDadosNotaFiscal(btnSalvar.Tag, _
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
                                                 txtInformacaoContrato)

            'Carrega Grid de Item
            Call oClsFatEntradaNFXML.LoadGridProduto(btnSalvar.Tag, _
                                                  grdProduto)

            'Carrega Grid de Parcela
            Call oClsFatEntradaNFXML.LoadGridDuplicata(btnSalvar.Tag, _
                                                    grdDuplicata)

            'Carrega Grid de Reboque
            Call oClsFatEntradaNFXML.LoadGridReboque(btnSalvar.Tag, _
                                                  grdReboque)

            'Carrega Grid de Volume
            Call oClsFatEntradaNFXML.LoadGridVolume(btnSalvar.Tag, _
                                                 grdVolume)

            Call LoadTotais()

            Call LoadNFFatura()

            cboFormaPagamento.SelectedValue = 0

            oClsFatEntradaNFXML.GerarDuplicata(grdDuplicata, _
                                            txtValorLiquido.Value - txtValorPago.Value, _
                                            txtNumeroParcela.Value, _
                                            txtIntervaloEntreParcelas.Value)
        Catch ex As Exception
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

    Private Sub cboTituloPrevisto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTituloPrevisto.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum título previsto
            If cboTituloPrevisto.SelectedIndex <> -1 Then

                'Carrega Dados do Título Previsto
                oClsFatEntradaNFXML.LoadControlesTituloPrevisao(cboTituloPrevisto.SelectedValue, _
                                                             txtNumDocumentoPrevisto, _
                                                             txtValorPrevisto, _
                                                             cboCentroGasto, _
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
                    oForm.CodigoEntradaCapa = oClsFatEntradaNFXML.CodigoEntradaCapa
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
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFXML
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.FaturamentoEntradaNFXML)

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
                                     Formulario.FaturamentoEntradaNFXML)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.FaturamentoEntradaNFXML, _
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
                                          Formulario.FaturamentoEntradaNFXML, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: XML :::"

    Private Sub btnExcluirXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirXML.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Entrega
            Call DeleteRecebimento()

            'Carrega Grid - Entrega
            Call LoadGridXML()

            'Limpa Controle
            cboNumeroDocumento.Text = ""
            cboUnidadeMedida.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""
            cboCFOP.Text = ""
            cboTipoOperacao.Text = ""
            cboProduto.Text = ""
            txtQuantidade.Text = ""
            txtQuantidadeEstoque.Text = ""
            cboDeposito.Text = ""
             
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdXML.RowCheckStateChanged

        Try



            'Verifica o Status da Linha
            If e.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = e.Row
                iCodigoParceiroNegocio = oCurrentRow.Cells("codigo_parceiro_negocio").Value
                iCodigoEntradaItem = oCurrentRow.Cells("codigo_entrada_item").Value
                sInformacoesAdicionais = oCurrentRow.Cells("informacoes_adicionais").Value
                dQuantidadeXML = oCurrentRow.Cells("quantidade").Value
                 
                    'Carrega Grid - Recebimento
                Call oClsFatEntradaNFXML.LoadGridRecebimento(grdRecebimento, _
                                                                    grdXML.CurrentRow.Cells("codigo_entrada_capa").Value, _
                                                                    iCodigoEntradaItem)

                'Habilita Controle
                cboCFOP.Enabled = True

            Else

                'Limpa Váriavel
                oCurrentRow = Nothing
                iCodigoParceiroNegocio = -1
                iCodigoEntradaItem = -1
                sInformacoesAdicionais = ""
                dQuantidadeXML = 0

                'Limpa Grid
                grdRecebimento.DataSource = Nothing

                'Desabilita Controle
                cboCFOP.Enabled = False

            End If
            
            Try

                'Limpa Controles
                If Not oCurrentRow Is Nothing Then
                    'Seta Controles
                    cboCFOP.SelectedValue = CType(LoadDescricao("sp_select_cadastro_basico_cfop_relacionado " & goUsuario.iEmpresa & ", " & oCurrentRow.Cells("cfop").Value), String)
                    'Váriavel - Quantidade
                    Dim dQuantidade As Double = 0
                    If grdRecebimento.GetDataRows.Count > 0 Then
                        dQuantidade = grdRecebimento.GetTotalRow.Cells("quantidade").Value
                    End If
                    txtQuantidade.Value = oCurrentRow.Cells("quantidade").Value - dQuantidade
                    txtFatorConversao.Value = 1
                    txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value
                Else
                    cboCFOP.Text = ""
                    txtQuantidade.Value = 0
                    txtFatorConversao.Value = 0
                    txtQuantidadeEstoque.Value = 0
                End If

                'Limpa Controle
                cboNumeroDocumento.Text = ""
                cboUnidadeMedida.Text = ""
                txtLote.Text = ""
                dtpDataFabricacao.Value = Now.Date
                dtpDataValidade.Value = Now.Date
                cboCentroGasto.Text = ""
                cboContaContabil.Text = ""
                btnInserir.Tag = ""

                'Limpa Váriaveis
                bItemEstoque = False
                bControlaQualidade = False
                bControlaLote = False
                bDataFabricacao = False
                bDataValidade = False
                dQuantidadePendente = 0
                dValorUnitario = 0
                dFatorConversao = 0
                iCodigoEntradaItemLote = -1

                'Executa Rotina CFOP
                Call cboCFOP_SelectedIndexChanged(cboCFOP, System.EventArgs.Empty)

                'Seta Focu
                cboCFOP.Focus()

            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Valida Dados do Formulário
            If ValidacaoXML() = True Then

                lCodigoEntradaCapa = grdXML.CurrentRow.Cells("codigo_entrada_capa").Value


                'Salva Dados do Item
                oClsFatEntradaNFXML.SalvarXML(grdXML.CurrentRow.Cells("codigo_entrada_capa").Value)

                'Carrega Grid de Item
                Call oClsFatEntradaNFXML.LoadGridProduto(lCodigoEntradaCapa, _
                                                      grdProduto)

                If tabDados.TabPages.Contains(pagProdutoXML) = True Then tabDados.TabPages.Remove(pagProdutoXML)

                oClsFatEntradaNFXML.UpdateStatus(grdXML.CurrentRow.Cells("codigo_entrada_capa").Value)

                'Seta Aba
                tabDados.SelectedTab = pagDadosNF

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Verifica se o usuário deseja cancelar a importação da Nota Fiscal Eletrônica
            If MsgBox("Deseja Cancelar a Importação da Nota Fiscal Eletrônica?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                oClsFatEntradaNFXML.Cancelar(grdXML.CurrentRow.Cells("codigo_entrada_capa").Value)

                'Limpa Controle
                cboNumeroDocumento.Text = ""
                cboUnidadeMedida.Text = ""
                txtLote.Text = ""
                dtpDataFabricacao.Value = Now.Date
                dtpDataValidade.Value = Now.Date
                cboCentroGasto.Text = ""
                cboContaContabil.Text = ""
                cboCFOP.Text = ""
                cboTipoOperacao.Text = ""
                cboProduto.Text = ""
                txtQuantidade.Text = ""
                txtQuantidadeEstoque.Text = ""
                cboDeposito.Text = ""

                'Limpa Grid
                grdRecebimento.DataSource = Nothing

                Call oClsFatEntradaNFXML.LoadGridXML(grdXML, grdXML.CurrentRow.Cells("codigo_entrada_capa").Value, Nothing)

                'Alterna Aba
                tabMain.TabPages.Remove(pagDados)
                If tabMain.TabPages.Contains(pagLista) = False Then tabMain.TabPages.Add(pagLista)

                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
     
    Private Sub grdXML_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdXML.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdXML.Name, _
                                     Formulario.FaturamentoEntradaNFXML, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdXML.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdXML, _
                                     Formulario.FaturamentoEntradaNFXML)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdXML.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdXML.Name, _
                                          Formulario.FaturamentoEntradaNFXML, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function ValidacaoXML() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoXML = False

            'Verifica se foi Selecionado algum Registro
            For Each oRow As GridEXRow In grdXML.GetDataRows
                If oRow.Cells("quantidade").Value > oRow.Cells("quantidade_entregue").Value Then
                    frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Qtde. Entregue")
                    Exit Function
                End If
            Next

            'Seta Retorno da Função
            ValidacaoXML = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoXMLEditar() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoXMLEditar = False

            'Verifica se foi Selecionado algum Registro
            For Each oRow As GridEXRow In grdXML.GetDataRows
                If oRow.Cells("quantidade").Value > oRow.Cells("quantidade_entregue").Value Then

                    Exit Function
                End If
            Next

            'Seta Retorno da Função
            ValidacaoXMLEditar = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function
     
    Private Sub btnCadastrarCFOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCFOP.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCFOP")

            'Carrega Combo
            Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa, False)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo - Item
            If cboNumeroDocumento.Enabled = False Then Call cboTipoOperacao_SelectedIndexChanged(cboTipoOperacao, System.EventArgs.Empty) Else Call cboNumeroDocumento_SelectedIndexChanged(cboNumeroDocumento, System.EventArgs.Empty)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDeposito.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDeposito")

            'Chama Evento
            Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFindCFOPDestinacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindCFOPDestinacao.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCFOPDestinacao"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar CFOP - Destinação"

            oComboBoxFind = cboCFOP
            oComboBoxFind.Tag = sUFEmitente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAtualizarPedidoCompra_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAtualizarPedidoCompra.Click

        Try

            'Abre Formulário para Alteração de Unidade de Medida
            Dim oForm As New frmFatEntradaNFPedidoCompraUnidadeMedida

            'Seta Parâmetros
            oForm.CodigoPedido = lCodigoPedido
            oForm.CodigoPedidoItem = iCodigoPedidoItem
            oForm.Quantidade = txtQuantidadeDocumento.Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Atualiza Registro
            Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoRecebimento() = True Then

                'Váriaveis Locais
                Dim sKit As String = ""
                Dim sNumeroDocumento As String = ""

                If cboTipoOperacao.SelectedValue = TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento Then
                    sNumeroDocumento = cboNumeroDocumento.Text.Trim
                Else
                    sNumeroDocumento = IIf(cboNumeroDocumento.SelectedIndex = -1, "", cboNumeroDocumento.Text)
                End If

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserir.Tag) Then

                    'Insere Registro na tb_fat_entrada_item_pedido_tmp
                    Call oClsFatEntradaNFXML.UpdateRecebimento(IIf(oClsFatEntradaNFXML.CodigoEntradaCapa = 0, txtTeste.Text, oClsFatEntradaNFXML.CodigoEntradaCapa), _
                                                                      oCurrentRow.Cells("codigo_entrada_item").Value, _
                                                                      grdRecebimento.CurrentRow.Cells("codigo").Value, _
                                                                      cboCFOP.SelectedValue, _
                                                                      cboTipoOperacao.SelectedValue, _
                                                                      sNumeroDocumento, _
                                                                      lCodigoItem, _
                                                                      bControlaQualidade, _
                                                                      txtQuantidade.Value, _
                                                                      IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue), _
                                                                      IIf(txtQuantidadeEstoque.Enabled = True, txtQuantidadeEstoque.Value, 0), _
                                                                      IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue), _
                                                                      txtLote.Text.Trim, _
                                                                      IIf(dtpDataValidade.Enabled = False, "", dtpDataValidade.Value), _
                                                                      IIf(dtpDataFabricacao.Enabled = False, "", dtpDataFabricacao.Value), _
                                                                      DateDiff(DateInterval.Month, dtpDataFabricacao.Value, dtpDataValidade.Value), _
                                                                      IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                                      IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), lCodigoPedido, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItem, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItemEntrega, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), lCodigoEmissaoCapa, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), iCodigoEmissaoItem, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), cboNumeroDocumento.SelectedValue, -1), _
                                                                      sKit)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroAlterado)

                Else

                    'Insere Registro na tb_fat_entrada_item_pedido_tmp
                    Call oClsFatEntradaNFXML.InsertRecebimento(IIf(oClsFatEntradaNFXML.CodigoEntradaCapa = 0, txtTeste.Text, oClsFatEntradaNFXML.CodigoEntradaCapa), _
                                                                      iCodigoEntradaItem, _
                                                                      cboCFOP.SelectedValue, _
                                                                      cboTipoOperacao.SelectedValue, _
                                                                      sNumeroDocumento, _
                                                                      lCodigoItem, _
                                                                      bControlaQualidade, _
                                                                      txtQuantidade.Value, _
                                                                      IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue), _
                                                                      txtQuantidadeEstoque.Value, _
                                                                      IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue), _
                                                                      txtLote.Text.Trim, _
                                                                      IIf(dtpDataValidade.Enabled = False, "", dtpDataValidade.Value), _
                                                                      IIf(dtpDataFabricacao.Enabled = False, "", dtpDataFabricacao.Value), _
                                                                      DateDiff(DateInterval.Month, dtpDataFabricacao.Value, dtpDataValidade.Value), _
                                                                      IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                                      IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), lCodigoPedido, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItem, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItemEntrega, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), lCodigoEmissaoCapa, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), iCodigoEmissaoItem, -1), _
                                                                      IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao), cboNumeroDocumento.SelectedValue, -1), _
                                                                      sKit)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroInserido)

                End If


                'Verifica se alguma Linha está selecionada
                If IsNothing(oCurrentRow) Then
                    'Carrega Grid
                    Call oClsFatEntradaNFXML.LoadGridXML(grdXML, IIf(oClsFatEntradaNFXML.CodigoEntradaCapa = 0, txtTeste.Text, oClsFatEntradaNFXML.CodigoEntradaCapa), Nothing)
                Else
                    'Carrega Grid
                    Call oClsFatEntradaNFXML.LoadGridXML(grdXML, IIf(oClsFatEntradaNFXML.CodigoEntradaCapa = 0, txtTeste.Text, oClsFatEntradaNFXML.CodigoEntradaCapa), oCurrentRow)
                    'Seleciona Linha
                    oCurrentRow.CheckState = RowCheckState.Checked

                    'Carrega Grid - Recebimento
                    Call oClsFatEntradaNFXML.LoadGridRecebimento(grdRecebimento, _
                                                                        IIf(oClsFatEntradaNFXML.CodigoEntradaCapa = 0, txtTeste.Text, oClsFatEntradaNFXML.CodigoEntradaCapa), _
                                                                        iCodigoEntradaItem)

                End If
                 
                'Executa Rotina CFOP
                Call cboCFOP_SelectedIndexChanged(cboCFOP, System.EventArgs.Empty)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
     
    Private Sub QuantidadeEstoque(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantidade.LostFocus, _
                                                                            txtFatorConversao.LostFocus, _
                                                                            txtQuantidadeEstoque.LostFocus

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Select Case sender.Name

                Case "txtFatorConversao" : txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value
                Case "txtQuantidadeEstoque" : txtFatorConversao.Value = IIf(txtQuantidade.Value = 0, 0, txtQuantidadeEstoque.Value / txtQuantidade.Value)
                Case "txtQuantidade" : txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value

            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCFOP.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado Algum CFOP
            If cboCFOP.SelectedIndex = -1 Then

                'Limpa Controle
                cboTipoOperacao.Text = ""
                bCFOPEstoque = False
                cboTipoOperacao.DataSource = Nothing

                'Desabilita Controle
                cboTipoOperacao.Enabled = False

            Else

                'Carrega Combo
                Call LoadCombo(cboTipoOperacao, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada " & cboCFOP.SelectedValue & ", " & goUsuario.iEmpresa)

                'Carrega Váriavel - Controle de Estoque
                bCFOPEstoque = LoadDescricao("sp_select_cadastro_basico_estoque_cfop_estoque " & cboCFOP.SelectedValue & ", " & goUsuario.iEmpresa)

                'Habilita Controle
                cboTipoOperacao.Enabled = True

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTipoOperacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoOperacao.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            cboNumeroDocumento.Text = ""
            lblNumeroDocumento.Text = "Nº Documento:"
            cboProduto.Text = ""
            txtQuantidadeDocumento.Value = 0
            txtQuantidade.Value = 0
            cboUnidadeMedida.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""

            'Desabilita / Oculta Controles
            cboNumeroDocumento.Enabled = False
            cboProduto.Enabled = False
            lblQuantidadeDocumento.Visible = False
            txtQuantidadeDocumento.Visible = False
            btnAtualizarPedidoCompra.Visible = False
            btnCadastrarProduto.Enabled = False
            btnProcurarProduto.Enabled = False
            txtQuantidadeDocumento.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            cboCentroGasto.Enabled = False
            cboContaContabil.Enabled = False
            lblValorUnitarioPedido.Visible = False
            txtValorUnitarioPedido.Visible = False
            lblAliquotaICMSPedido.Visible = False
            txtAliquotaICMSPedido.Visible = False
            lblAliquotaIPIPedido.Visible = False
            txtAliquotaIPIPedido.Visible = False
            lblAliquotaPISCOFINSPedido.Visible = False
            txtAliquotaPISCOFINSPedido.Visible = False
            lblAliquotaICMSUltimaNF.Visible = False
            txtAliquotaICMSUltimaNF.Visible = False

            'Verifica o Tipo de Operação Selecionada
            Select Case cboTipoOperacao.SelectedValue

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros)
                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False) : cboProduto.Enabled = True
                    'Verifica Direito - Cadastrar Produto
                    btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                    btnProcurarProduto.Enabled = True

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento)
                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False) : cboProduto.Enabled = True
                    cboNumeroDocumento.DataSource = Nothing
                    cboNumeroDocumento.Text = ""
                    cboNumeroDocumento.Enabled = True
                    'Verifica Direito - Cadastrar Produto
                    btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                    btnProcurarProduto.Enabled = True

                Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                    'Carrega Combo de Pedido de Compra
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_pedido_compra " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    cboNumeroDocumento.Enabled = True
                    'Seta Label
                    lblNumeroDocumento.Text = "Pedido de Compra:"
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    btnAtualizarPedidoCompra.Visible = VerificaDireito(Formulario.FaturamentoEntradaNF, gcAdministrator)
                    lblQuantidadeDocumento.Text = "Qtde. Pedido:"

                    lblValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Value = 0
                    lblAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Value = 0
                    lblAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Value = 0
                    lblAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Value = 0
                    lblAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Value = 0

                Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                    'Carrega Combo de Nota Fiscal Emitida
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    cboNumeroDocumento.Enabled = True
                    'Seta Label
                    lblNumeroDocumento.Text = "Nota Fiscal:"
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Text = "Qtde. Nota Fiscal:"

                    lblValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Value = 0
                    lblAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Value = 0
                    lblAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Value = 0
                    lblAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Value = 0
                    lblAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Value = 0

                Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                    'Carrega Combo de Nota Fiscal
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao  " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    lblNumeroDocumento.Text = "Ordem Produção:"
                    cboNumeroDocumento.Enabled = True
                    'Exibe Controles
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Text = "Qtde. Nota Fiscal:"

                Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                    'Carrega Combo de Nota Fiscal
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_ordem_producao  " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    lblNumeroDocumento.Text = "Ordem Produção:"
                    cboNumeroDocumento.Enabled = True
                    'Exibe Controles
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Text = "Quantidade:"
            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboNumeroDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroDocumento.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            cboProduto.Text = ""
            txtQuantidadeDocumento.Value = 0
            txtQuantidade.Value = 0
            cboUnidadeMedida.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""

            'Desabilita / Oculta Controles
            btnCadastrarProduto.Enabled = False
            btnProcurarProduto.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            cboCentroGasto.Enabled = False
            cboContaContabil.Enabled = False

            'Verifica se foi Selecionado algum Registro
            If cboNumeroDocumento.SelectedIndex <> -1 Then

                'Verifica o Tipo de Operação
                Select Case cboTipoOperacao.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                        'Seta Váriavel
                        lCodigoPedido = cboNumeroDocumento.SelectedValue
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_pedido_compra_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                        'Seta Váriavel
                        lCodigoEmissaoCapa = cboNumeroDocumento.SelectedValue
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao_produto " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_ordem_producao_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & cboNumeroDocumento.SelectedValue, False)

                End Select

                'Habilita Controle
                cboProduto.Enabled = True

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim dAliquotaICMS As Double = 0
            Dim dAliquotaIPI As Double = 0
            Dim dAliquotaPISCOFINS As Double = 0
            Dim dAliquotaICMSUltimaNF As Double = 0

            'Limpa Váriaveis
            bItemEstoque = False
            bControlaQualidade = False
            bControlaLote = False
            bDataFabricacao = False
            bDataValidade = False
            dQuantidadePedido = 0
            dQuantidadePendente = 0
            dValorUnitario = 0
            dFatorConversao = 0
            lCodigoItem = 0
            lCodigoPedido = 0
            iCodigoPedidoItem = 0
            iCodigoPedidoItemEntrega = 0
            lCodigoEmissaoCapa = 0
            iCodigoEmissaoItem = 0
            sUnidadeMedida = ""
            iCodigoCentroGasto = 0
            sContaContabil = ""

            'Limpa Controles
            txtQuantidadeDocumento.Value = 0
            txtQuantidade.Value = 0
            cboUnidadeMedida.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""

            'Seta Propriedade dos Controles
            txtQuantidadeDocumento.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            cboCentroGasto.Enabled = True
            cboContaContabil.Enabled = True

            'Verifica se foi Selecionado Algum Registro
            If cboProduto.SelectedIndex > -1 Then

                'Váriaveis Locais
                Dim sOperacao As String = IIf(IsNumeric(btnInserir.Tag), "E", "I")

                Select Case cboTipoOperacao.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros), CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                        lCodigoItem = cboProduto.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                        Dim sAux() As String = cboProduto.SelectedValue.ToString.Split("|")
                        lCodigoPedido = cboNumeroDocumento.SelectedValue
                        iCodigoPedidoItem = sAux(0)
                        iCodigoPedidoItemEntrega = sAux(1)
                        lCodigoItem = sAux(2)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                        Dim sAux() As String = cboProduto.SelectedValue.ToString.Split("|")
                        lCodigoEmissaoCapa = cboNumeroDocumento.SelectedValue
                        iCodigoEmissaoItem = sAux(0)
                        lCodigoItem = sAux(1)

                End Select

                'Carrega Dados do Produto
                Call oClsFatEntradaNFXML.LoadDadosProduto(cboTipoOperacao.SelectedValue, _
                                                                 cboNumeroDocumento.SelectedValue, _
                                                                 lCodigoItem, _
                                                                 lCodigoEntradaCapa, _
                                                                 iCodigoEntradaItem, _
                                                                 iCodigoEntradaItemLote, _
                                                                 sOperacao, _
                                                                 lCodigoPedido, _
                                                                 iCodigoPedidoItem, _
                                                                 iCodigoPedidoItemEntrega, _
                                                                 lCodigoEmissaoCapa, _
                                                                 iCodigoEmissaoItem, _
                                                                 iCodigoUnidadeMedida, _
                                                                 bItemEstoque, _
                                                                 bControlaQualidade,
                                                                 bControlaLote, _
                                                                 bDataFabricacao, _
                                                                 bDataValidade, _
                                                                 dQuantidadePedido, _
                                                                 dQuantidadePendente, _
                                                                 dValorUnitario, _
                                                                 dFatorConversao, _
                                                                 sUnidadeMedida, _
                                                                 dToleranciaQuantidadePercentual, _
                                                                 dToleranciaValor, _
                                                                 iCodigoCentroGasto, _
                                                                 sContaContabil, _
                                                                 dAliquotaICMS, _
                                                                 dAliquotaIPI, _
                                                                 dAliquotaPISCOFINS, _
                                                                 dAliquotaICMSUltimaNF)

                'Carrega Combo
                Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & lCodigoItem, True)
                Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & lCodigoItem, True)

                'Habilita Controle                                
                txtQuantidade.Enabled = True
                txtQuantidadeDocumento.Value = dQuantidadePendente
                txtQuantidadeDocumento.FormatString = "#,#0.0000 " & sUnidadeMedida
                txtValorUnitarioPedido.Value = dValorUnitario
                txtAliquotaICMSPedido.Value = dAliquotaICMS
                txtAliquotaIPIPedido.Value = dAliquotaIPI
                txtAliquotaPISCOFINSPedido.Value = dAliquotaPISCOFINS
                txtAliquotaICMSUltimaNF.Value = dAliquotaICMSUltimaNF

                'Controles de Pedido
                txtValorUnitarioPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblValorUnitarioPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaICMSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaICMSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaIPIPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaIPIPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaPISCOFINSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaPISCOFINSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaICMSUltimaNF.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaICMSUltimaNF.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)

                'Verifica se foi Selecionado algum Registro
                lblValorUnitarioPedido.ForeColor = IIf(grdXML.CurrentRow.Cells("valor_unitario").Value <> dValorUnitario, Color.Red, Color.Black)
                lblAliquotaICMSPedido.ForeColor = IIf(grdXML.CurrentRow.Cells("aliquota_icms").Value <> (dAliquotaICMS * 100.0), Color.Red, Color.Black)
                lblAliquotaIPIPedido.ForeColor = IIf(grdXML.CurrentRow.Cells("aliquota_ipi").Value <> (dAliquotaIPI * 100.0), Color.Red, Color.Black)
                lblAliquotaPISCOFINSPedido.ForeColor = IIf((grdXML.CurrentRow.Cells("aliquota_pis").Value + grdXML.CurrentRow.Cells("aliquota_cofins").Value) <> (dAliquotaPISCOFINS * 100.0), Color.Red, Color.Black)
                lblAliquotaICMSUltimaNF.ForeColor = IIf(grdXML.CurrentRow.Cells("aliquota_icms").Value <> (dAliquotaICMSUltimaNF * 100.0), Color.Red, Color.Black)

                'Verifica se Controla Estoque do Item
                If bItemEstoque = False Or bCFOPEstoque = False Then Exit Sub

                cboUnidadeMedida.Enabled = True : btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
                txtFatorConversao.Enabled = True
                txtQuantidadeEstoque.Enabled = True
                txtQuantidade.Value = dQuantidadePedido
                cboDeposito.Enabled = True : btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)

                'Seta Controles
                If grdRecebimento.GetDataRows.Count > 0 Then txtQuantidade.Value = txtQuantidade.Value - grdRecebimento.GetTotalRow.Cells("quantidade").Value Else txtQuantidade.Value = txtQuantidade.Value
                If iCodigoUnidadeMedida <> -1 Then cboUnidadeMedida.SelectedValue = iCodigoUnidadeMedida
                txtFatorConversao.Value = IIf(dFatorConversao > 0, dFatorConversao, 1)
                If grdRecebimento.GetDataRows.Count > 0 Then txtQuantidade.Value = dQuantidadeXML - grdRecebimento.GetTotalRow.Cells("quantidade").Value Else txtQuantidade.Value = dQuantidadeXML
                If txtQuantidade.Value > dQuantidadePendente Then txtQuantidade.Value = dQuantidadePendente
                If iCodigoCentroGasto <> 0 Then cboCentroGasto.SelectedValue = iCodigoCentroGasto
                If sContaContabil = "" Then cboContaContabil.SelectedValue = sContaContabil

                'Verifica se o Item Controla Qualidade
                If bControlaQualidade = True Then

                    'Desabilita Controles (Serão preenchidos posteriormente na usrQAEntradaNF)
                    txtLote.Enabled = False
                    dtpDataFabricacao.Enabled = False
                    dtpDataValidade.Enabled = False

                    'Carrega Combo - Depósito (Somente os liberados em Qualidade)
                    Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_cfop_qualidade " & goUsuario.iEmpresa & ", " & cboCFOP.SelectedValue & ", " & cboTipoOperacao.SelectedValue, True)

                Else

                    'Habilita Controles
                    txtLote.Enabled = bControlaLote
                    dtpDataFabricacao.Enabled = bDataFabricacao
                    dtpDataValidade.Enabled = bDataValidade

                    If sInformacoesAdicionais <> "" Then

                        Dim sDados() As String = sInformacoesAdicionais.Split(" ")

                        For i = 0 To UBound(sDados)
                            If sDados(i).ToUpper.Contains("LOTE") Then
                                txtLote.Text = sDados(i + 1)
                            ElseIf sDados(i).ToUpper.Contains("VALIDADE") Or sDados(i).ToUpper.Contains("VAL") AndAlso IsDate(sDados(i + 1).Trim) = True Then
                                dtpDataValidade.Value = CDate(sDados(i + 1).Trim)
                            ElseIf sDados(i).ToUpper.Contains("FABRICAÇÃO") Or sDados(i).ToUpper.Contains("FAB") Or sDados(i).ToUpper.Contains("FABRICACAO") AndAlso IsDate(sDados(i + 1).Trim) = True Then
                                dtpDataFabricacao.Value = CDate(sDados(i + 1).Trim)
                            End If
                        Next

                    End If

                    'Carrega Combo - Depósito 
                    Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_cfop " & goUsuario.iEmpresa & ", " & cboCFOP.SelectedValue & ", " & cboTipoOperacao.SelectedValue, True)

                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRecebimento.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdRecebimento.CurrentColumn) Then Exit Sub

            'Verifica qual Coluna foi Pressionada
            Select Case grdRecebimento.CurrentColumn.Key

                Case "editar" : Call EditarRecebimento()
                Case "kit" : Call Kit()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRecebimento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRecebimento.Name, _
                                     Formulario.FaturamentoEntradaNFXML, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRecebimento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRecebimento, _
                                     Formulario.FaturamentoEntradaNFXML)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdRecebimento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRecebimento.Name, _
                                          Formulario.FaturamentoEntradaNFXML, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEntradaNFXML_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcPrint)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcDelete)
            btnEditarGridProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcUpdate)

            'Verifica Direito - Cadastros Básicos
            btnCadastrarEmitente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarPaisEmitente.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarTransportadora.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            Call ConfiguraGrid(grdXML, Formulario.FaturamentoEntradaNFXML)
            Call ConfiguraGrid(grdRecebimento, Formulario.FaturamentoEntradaNFXML)

            'Verifica Direito dos Controles
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarCFOP.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcInsert)
            btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa, False)

            tabDados.TabPages.Remove(pagProdutoXML)

            'Desabilita Controles
            cboCFOP.Enabled = False
            cboTipoOperacao.Enabled = False
            cboNumeroDocumento.Enabled = False
            cboProduto.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False : dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Enabled = False : dtpDataValidade.Value = Now.Date

            'Seta Váriavel
            sResultado = "N"

            'Oculta Controles
            txtQuantidadeDocumento.Visible = False
            lblQuantidadeDocumento.Visible = False
            btnAtualizarPedidoCompra.Visible = False
            lblValorUnitarioPedido.Visible = False
            txtValorUnitarioPedido.Visible = False
            lblAliquotaICMSPedido.Visible = False
            txtAliquotaICMSPedido.Visible = False
            lblAliquotaIPIPedido.Visible = False
            txtAliquotaIPIPedido.Visible = False
            lblAliquotaPISCOFINSPedido.Visible = False
            txtAliquotaPISCOFINSPedido.Visible = False
            lblAliquotaICMSUltimaNF.Visible = False
            txtAliquotaICMSUltimaNF.Visible = False

            'Carrega Combo - Filtro
            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ", 'E'")
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nota_fiscal_entrada")
            Call LoadCombo(cboTipoOperacaoFiltro, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada -1, " & goUsuario.iEmpresa)

            'Carrega Combo - Dados da Nota Fiscal
            Call LoadCombo(cboTipoNotaFiscal, "sp_select_combo_static_tipo_nota_fiscal")

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
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)


            'Carrega Combo - Exportação e Compras
            Call LoadCombo(cboUFEmbarque, "sp_select_combo_static_estado")

            'Carrega Combo - Grid
            Call LoadComboGrid(grdProduto, "codigo_produto_interno", "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto), False)
            Call LoadComboGrid(grdProduto, "codigo_deposito", "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", null,  null, null")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNFXML)
            Call ConfiguraGrid(grdProduto, Formulario.FaturamentoEntradaNFXML)
            Call ConfiguraGrid(grdDuplicata, Formulario.FaturamentoEntradaNFXML)
            Call ConfiguraGrid(grdReboque, Formulario.FaturamentoEntradaNFXML)
            Call ConfiguraGrid(grdVolume, Formulario.FaturamentoEntradaNFXML)
            Call ConfiguraGrid(grdArquivo, Formulario.FaturamentoEntradaNFXML)

            'Seta CalendarCombo
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEntradaInicioFiltro.Value = Now.Date : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False

            'Limpa Tag
            grdProduto.Tag = ""

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

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
            Call oClsFatEntradaNFXML.LoadGridNotaFiscal(grdListagem, _
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
            oArquivoXML.Filter = "(Arquivo NFe XML)|*.XML"
            oArquivoXML.Title = "Selecione o Arquivo"

            'Verifica se foi encontrado o Arquivo
            If oArquivoXML.ShowDialog() = DialogResult.OK Then
                 
                'Seta Controle - Arquivo
                txtArquivoNFe.Text = oArquivoXML.FileName

                'Carrega Arquivo XML
                Dim sArquivoXML As String = File.ReadAllText(oArquivoXML.FileName)

                'Importa Arquivo XML
                sReturn = oClsFatEntradaNFXML.ImportarXML(sArquivoXML, _
                                                       oArquivoXML.FileName)

                lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & oClsFatEntradaNFXML.CodigoEntradaCapa & ", " & goUsuario.iEmpresa)
                If lCodigoTituloCapa = 0 Then
                    grpTituloPrevisto.Visible = False
                Else
                    grpTituloPrevisto.Visible = True
                End If

                'Verifica se ocorreu um Erro na Importação do Arquivo XML
                If sReturn <> "" Then
                    frmMain.Informacao(Mensagem.Erro, sReturn)
                Else

                    'Carrega Dados da Empresa
                    Call LoadDadosEmitente()
                     
                    'Executa a Integração
                    Call Integracao(oClsFatEntradaNFXML.CodigoEntradaCapa)

                    'Carrega ComboBox
                    Call LoadCombo(cboEmitente, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
                    Call LoadCombo(cboPaisEmitente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
                    Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)

                    'Move arquivo para a Pasta de Entrada                        
                    If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'mover_arquivo_nfe_pasta_entrada'"), Boolean) = True Then
                        'Carrega Configuração da NFe
                        Call LoadConfiguracaoNFe() 
                    End If

                    'oClsFatEntradaNFXML.LoadDadosConfirmar(grdListagem, _
                    '                                       oClsFatEntradaNFXML.CodigoEntradaCapa)

                    If (oClsFatEntradaNFXML.Confirmar > 0) Then

                        'Edita Nota Fiscal
                        Call EditarNotaFiscal(oClsFatEntradaNFXML.CodigoEntradaCapa, _
                                              CInt(StatusNotaFiscalEntrada.EntradaEfetuadaSucesso), _
                                              False)

                    Else

                        'Edita Nota Fiscal
                        Call EditarNotaFiscal(oClsFatEntradaNFXML.CodigoEntradaCapa, _
                                              CInt(StatusNotaFiscalEntrada.EmDigitacao), _
                                              False)

                    End If


                    Select Case cboTipoNotaFiscal.SelectedValue
                        Case CInt(TipoNotaFiscal.NotaFiscal) : txtEspecie.Text = "NF"
                        Case CInt(TipoNotaFiscal.NotaFiscalEletronica) : txtEspecie.Text = "NF-E"
                        Case CInt(TipoNotaFiscal.DACTE) : txtEspecie.Text = "DACTE"
                        Case CInt(TipoNotaFiscal.CTRC) : txtEspecie.Text = "CTRC"
                        Case CInt(TipoNotaFiscal.NFST) : txtEspecie.Text = "NFST"
                        Case CInt(TipoNotaFiscal.NFE) : txtEspecie.Text = "NFE"
                        Case CInt(TipoNotaFiscal.CTE) : txtEspecie.Text = "CTE"
                    End Select

                    'Seta Focu
                    cboTipoNotaFiscal.Focus()

                    Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & oClsFatEntradaNFXML.CodigoEntradaCapa)

                    Dim Index As Integer

                    Call oClsFatEntradaNFXML.LoadGridXML(grdXML, oClsFatEntradaNFXML.CodigoEntradaCapa, Nothing)

                End If

                If tabDados.TabPages.Contains(pagProdutoXML) = False Then tabDados.TabPages.Add(pagProdutoXML)

                'Seta Aba
                tabDados.SelectedTab = pagProdutoXML

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
            oClsFatEntradaNFXML.InsertNotaFiscal()

            'Seta Controle
            btnSalvar.Tag = oClsFatEntradaNFXML.CodigoEntradaCapa

            'Limpa Controles - Identificação
            cboTipoNotaFiscal.SelectedIndex = -1

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

            'Limpa Controles - Exportação / Compras
            cboUFEmbarque.SelectedIndex = -1
            txtLocalEmbarque.Text = ""
            txtNotaEmpenho.Text = ""
            txtInformacaoContrato.Text = ""
            txtInformacaoPedido.Text = ""

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcDelete)
            btnCalcularDuplicata.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
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

    Private Sub Novo1()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()
              
            'Limpa Controles - Identificação
            cboTipoNotaFiscal.SelectedIndex = -1

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

            'Limpa Controles - Exportação / Compras
            cboUFEmbarque.SelectedIndex = -1
            txtLocalEmbarque.Text = ""
            txtNotaEmpenho.Text = ""
            txtInformacaoContrato.Text = ""
            txtInformacaoPedido.Text = ""

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcDelete)
            btnCalcularDuplicata.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
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
            'Integração
            Call Integracao(btnSalvar.Tag)

            'Seta Código Título
            lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

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
            oClsFatEntradaNFXML.Especie = txtEspecie.Text
            oClsFatEntradaNFXML.TipoNotaFiscal = cboTipoNotaFiscal.SelectedValue
            oClsFatEntradaNFXML.NotaFiscal = IIf(IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica), txtNumeroNF.Text.Trim, txtNumeroNFe.Text.Trim) = "", 0, IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica), txtNumeroNF.Text.Trim, txtNumeroNFe.Text.Trim))
            oClsFatEntradaNFXML.Serie = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica), txtSerieNF.Text.Trim, txtSerieNFe.Text.Trim)
            oClsFatEntradaNFXML.DataEmissao = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica), dtpDataEmissaoNF.Value, txtDataEmissaoNFe.Text.Trim)
            oClsFatEntradaNFXML.DataEntrada = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica), dtpDataEntradaNF.Value, dtpDataEntradaNFe.Value)
            oClsFatEntradaNFXML.FormaPagamento = cboFormaPagamento.SelectedValue
            oClsFatEntradaNFXML.Inspecao = bInspecao
            oClsFatEntradaNFXML.ChaveAcessoDACTE = IIf(cboTipoNotaFiscal.SelectedValue <> CInt(TipoNotaFiscal.NotaFiscalEletronica), "", txtChaveAcessoDACTE.Text.Trim)
            If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                oClsFatEntradaNFXML.ChaveAcesso = txtChaveAcessoNFe.Text.Trim
                oClsFatEntradaNFXML.NumeroProtocolo = txtNumeroProtocoloNFe.Text.Trim
                oClsFatEntradaNFXML.ArquivoNFe = txtArquivoNFe.Text.Trim
                oClsFatEntradaNFXML.StatusNFe = txtStatusNFe.Text.Trim
            End If
            oClsFatEntradaNFXML.CodigoEntradaCapa = btnSalvar.Tag

            'Verifica o Tipo de Operação
            oClsFatEntradaNFXML.UpdateNotaFiscal()

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
                    Call oClsFatEntradaNFXML.DeleteNotaFiscal()

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

    Private Sub EditarNotaFiscal(ByVal lCodigoEntradaCapa As Long, _
                                 ByVal iStatus As StatusNotaFiscalEntrada, _
                                 ByVal bAprovadoQualidade As Boolean)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcUpdate) = True Then

                'oClsFatEntradaNFXML.LoadDadosConfirmar(grdListagem, _
                '                                       grdListagem.CurrentRow.Cells("codigo").Value)

                oClsFatEntradaNFXML.LoadDadosConfirmar(lCodigoEntradaCapa)

                If ((ValidacaoXMLEditar() = False) Or (oClsFatEntradaNFXML.Confirmar = 0)) Then

                    If tabDados.TabPages.Contains(pagProdutoXML) = False Then tabDados.TabPages.Add(pagProdutoXML)

                    If tabDados.TabPages.Contains(pagProdutoXML) = True Then txtTeste.Text = lCodigoEntradaCapa

                    Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa)

                    oClsFatEntradaNFXML.LoadGridItemXML(grdXML, _
                                                        lCodigoEntradaCapa)

                    'Limpa Formulário
                    Call Novo1()

                    'Seta Controle
                    btnSalvar.Tag = lCodigoEntradaCapa

                    'Carrega dados da Nota Fiscal
                    oClsFatEntradaNFXML.LoadDadosNotaFiscal(lCodigoEntradaCapa, _
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
                                                         txtInformacaoContrato)

                    'Carrega Grid de Item
                    Call oClsFatEntradaNFXML.LoadGridProduto(lCodigoEntradaCapa, _
                                                          grdProduto)

                    'Carrega Grid de Parcela
                    Call oClsFatEntradaNFXML.LoadGridDuplicata(lCodigoEntradaCapa, _
                                                            grdDuplicata)

                    'Carrega Grid de Reboque
                    Call oClsFatEntradaNFXML.LoadGridReboque(lCodigoEntradaCapa, _
                                                          grdReboque)

                    'Carrega Grid de Volume
                    Call oClsFatEntradaNFXML.LoadGridVolume(lCodigoEntradaCapa, _
                                                         grdVolume)

                    'Carrega Grid de Volume
                    Call oClsFatEntradaNFXML.LoadGridVolume(lCodigoEntradaCapa, _
                                                         grdVolume)

                    'Carrega Grid
                    Call LoadGridArquivoBD(grdArquivo, _
                                           "tb_fat_entrada_capa", _
                                           lCodigoEntradaCapa)

                    lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

                    'Carrega Combo Titulo Previsto
                    'Call LoadCombo(cboTituloPrevisto, "sp_select_combo_faturamento_titulo_previsao " & goUsuario.iEmpresa & ", " & cboEmitente.SelectedValue)
                    Call LoadCombo(cboTituloPrevisto, "sp_select_combo_faturamento_titulo_previsao " & goUsuario.iEmpresa & ", 1")

                    oClsFatEntradaNFXML.LoadDadosVinculoTituloPrevisto(lCodigoTituloCapa, _
                                                                    cboTituloPrevisto, _
                                                                    txtNumDocumentoPrevisto, _
                                                                    txtValorPrevisto, _
                                                                    txtTituloDescritivo, _
                                                                    cboCentroGasto)

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
                        btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
                        btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
                        btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcDelete)
                        btnCalcularDuplicata.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
                        grdDuplicata.AllowEdit = InheritableBoolean.True
                        grdProduto.AllowEdit = InheritableBoolean.True
                    End If

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagLista)
                    If tabMain.TabPages.Contains(pagDados) = False Then tabMain.TabPages.Add(pagDados)

                    'Informa o usuário que a Nota Fiscal não pode ser editada.
                    If bAprovadoQualidade = True Then
                        MsgBox("Está nota Fiscal não pode ser Editada porque ela foi Aprovada pela Qualidade.", MsgBoxStyle.Information, Me.Parent.Text)
                    End If

                    'Seta Focu
                    cboTipoNotaFiscal.Focus()

                    'Seta Aba
                    tabDados.SelectedTab = pagProdutoXML

                Else

                    If tabDados.TabPages.Contains(pagProdutoXML) = True Then tabDados.TabPages.Remove(pagProdutoXML)

                    Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa)

                    oClsFatEntradaNFXML.LoadGridItemXML(grdXML, _
                                                        lCodigoEntradaCapa)

                    'Limpa Formulário
                    Call Novo1()

                    'Seta Controle
                    btnSalvar.Tag = lCodigoEntradaCapa

                    'Carrega dados da Nota Fiscal
                    oClsFatEntradaNFXML.LoadDadosNotaFiscal(lCodigoEntradaCapa, _
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
                                                         txtInformacaoContrato)

                    'Carrega Grid de Item
                    Call oClsFatEntradaNFXML.LoadGridProduto(lCodigoEntradaCapa, _
                                                          grdProduto)

                    'Carrega Grid de Parcela
                    Call oClsFatEntradaNFXML.LoadGridDuplicata(lCodigoEntradaCapa, _
                                                            grdDuplicata)

                    'Carrega Grid de Reboque
                    Call oClsFatEntradaNFXML.LoadGridReboque(lCodigoEntradaCapa, _
                                                          grdReboque)

                    'Carrega Grid de Volume
                    Call oClsFatEntradaNFXML.LoadGridVolume(lCodigoEntradaCapa, _
                                                         grdVolume)

                    'Carrega Grid de Volume
                    Call oClsFatEntradaNFXML.LoadGridVolume(lCodigoEntradaCapa, _
                                                         grdVolume)

                    'Carrega Grid
                    Call LoadGridArquivoBD(grdArquivo, _
                                           "tb_fat_entrada_capa", _
                                           lCodigoEntradaCapa)

                    lCodigoTituloCapa = LoadCodigo("sp_select_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

                    'Carrega Combo Titulo Previsto
                    'Call LoadCombo(cboTituloPrevisto, "sp_select_combo_faturamento_titulo_previsao " & goUsuario.iEmpresa & ", " & cboEmitente.SelectedValue)
                    Call LoadCombo(cboTituloPrevisto, "sp_select_combo_faturamento_titulo_previsao " & goUsuario.iEmpresa & ", 1")

                    oClsFatEntradaNFXML.LoadDadosVinculoTituloPrevisto(lCodigoTituloCapa, _
                                                                    cboTituloPrevisto, _
                                                                    txtNumDocumentoPrevisto, _
                                                                    txtValorPrevisto, _
                                                                    txtTituloDescritivo, _
                                                                    cboCentroGasto)

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
                        btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
                        btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
                        btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcDelete)
                        btnCalcularDuplicata.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcInsert)
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

                    'Seta Focu
                    cboTipoNotaFiscal.Focus()

                End If

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
                            Call oClsFatEntradaNFXML.Cancelar(grdListagem.CurrentRow.Cells("codigo").Value, sMotivo)

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
                        If VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcAdministrator) = True Then

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

                Case CInt(TipoNotaFiscal.NotaFiscalEletronica)

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
                    If oClsFatEntradaNFXML.ValidaDocumento(btnSalvar.Tag, _
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
                    If oClsFatEntradaNFXML.ValidaDocumento(btnSalvar.Tag, _
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

#End Region

#Region " ::: DESTINATÁRIO ::: "

    Private Sub SalvarDestinatario()

        Try

            'Salva Dados do Emitente
            oClsFatEntradaNFXML.DeleteDestinatario()
            oClsFatEntradaNFXML.InsertDestinatario()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: EMITENTE ::: "

    Private Sub SalvarEmitente()

        Try

            'Seta Parametros
            oClsFatEntradaNFXML.CodigoEmitente = cboEmitente.SelectedValue
            oClsFatEntradaNFXML.RazaoSocialEmitente = cboEmitente.Text
            oClsFatEntradaNFXML.CnpjCpfEmitente = txtCNPJEmitente.Text.Trim
            oClsFatEntradaNFXML.InscricaoEstadualEmitente = txtInscricaoEstadualEmitente.Text.Trim
            oClsFatEntradaNFXML.InscricaoEstadualSubstitutoTributarioEmitente = txtInscricaoEstadualSubstitutoTributarioEmitente.Text.Trim
            oClsFatEntradaNFXML.CodigoRegimeTributario = IIf(cboRegimeTributarioEmitente.SelectedIndex = -1, -1, cboRegimeTributarioEmitente.SelectedValue)
            oClsFatEntradaNFXML.LogradouroEmitente = txtLogradouroEmitente.Text.Trim
            oClsFatEntradaNFXML.NumeroEmitente = txtNumeroEmitente.Text.Trim
            oClsFatEntradaNFXML.ComplementoEmitente = txtComplementoEmitente.Text.Trim
            oClsFatEntradaNFXML.BairroEmitente = txtBairroEmitente.Text.Trim
            oClsFatEntradaNFXML.CodigoMunicipioEmitente = cboMunicipioEmitente.SelectedValue
            oClsFatEntradaNFXML.UFEmitente = cboUFEmitente.SelectedValue
            oClsFatEntradaNFXML.CepEmitente = txtCEPEmitente.Text.Trim
            oClsFatEntradaNFXML.CodigoPaisEmitente = cboPaisEmitente.SelectedValue
            oClsFatEntradaNFXML.TelefoneEmitente = txtTelefoneEmitente.Text.Trim
            oClsFatEntradaNFXML.EmailEmitente = txtEmailEmitente.Text.Trim
            oClsFatEntradaNFXML.OutroLugarRetiradaEmitente = chkLocalRetirada.Checked
            oClsFatEntradaNFXML.OutroLugarEntregaEmitente = chkLocalEntrega.Checked

            'Salva Dados do Destinatário
            oClsFatEntradaNFXML.DeleteEmitente()
            oClsFatEntradaNFXML.InsertEmitente()

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
            oForm.CodigoEntradaCapa = oClsFatEntradaNFXML.CodigoEntradaCapa
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
            oForm.CodigoEntradaCapa = oClsFatEntradaNFXML.CodigoEntradaCapa
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
            oClsFatEntradaNFXML.BaseCalculoICMS = txtBaseCalculoICMS.Value
            oClsFatEntradaNFXML.TotalICMS = txtTotalICMS.Value
            oClsFatEntradaNFXML.BaseCalculoICMSST = txtBaseCalculoICMSST.Value
            oClsFatEntradaNFXML.TotalICMSST = txtTotalICMSST.Value
            oClsFatEntradaNFXML.TotalProdutoServico = txtTotalProdutoServico.Value
            oClsFatEntradaNFXML.TotalFrete = txtTotalFrete.Value
            oClsFatEntradaNFXML.TotalSeguro = txtTotalSeguro.Value
            oClsFatEntradaNFXML.TotalDesconto = txtTotalDesconto.Value
            oClsFatEntradaNFXML.TotalII = txtTotalII.Value
            oClsFatEntradaNFXML.TotalIPI = txtTotalIPI.Value
            oClsFatEntradaNFXML.PIS = txtTotalPIS.Value
            oClsFatEntradaNFXML.COFINS = txtTotalCOFINS.Value
            oClsFatEntradaNFXML.OutrasDespesas = txtOutrasDespesas.Value
            oClsFatEntradaNFXML.TotalNotaFiscal = txtTotalNotaFiscal.Value
            oClsFatEntradaNFXML.ValorRetidoPIS = 0
            oClsFatEntradaNFXML.ValorRetidoCOFINS = 0
            oClsFatEntradaNFXML.ValorRetidoCSLL = 0
            oClsFatEntradaNFXML.BaseCalculoIRRF = 0
            oClsFatEntradaNFXML.ValorRetidoIRRF = 0
            oClsFatEntradaNFXML.BaseCalculoRetencaoPrevidenciaSocial = 0
            oClsFatEntradaNFXML.RetencaoPrevidenciaSocial = 0
            oClsFatEntradaNFXML.BaseCalculoISS = 0
            oClsFatEntradaNFXML.TotalISS = 0
            oClsFatEntradaNFXML.PISSobreServico = 0
            oClsFatEntradaNFXML.COFINSSobreServico = 0
            oClsFatEntradaNFXML.TotalServicoNaoTributadoICMS = 0
            oClsFatEntradaNFXML.ValorDestinoICMSPartilha = txtTotalICMSDestino.Value
            oClsFatEntradaNFXML.ValorFCPICMSPartilha = txtTotalFCP.Value
            oClsFatEntradaNFXML.ValorRemetenteICMSPartilha = txtTotalICMSRemetente.Value

            'Salva Dados Total
            oClsFatEntradaNFXML.DeleteTotal()
            oClsFatEntradaNFXML.InsertTotal()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTotais()

        Try
            Call oClsFatEntradaNFXML.LoadDadosTotal(txtBaseCalculoICMS, _
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
            oClsFatEntradaNFXML.InformacaoAdicionalContribuinte = txtInformacaoAdicionalContribuinte.Text.Trim

            'Salva Dados Informaççoes Adicionais
            oClsFatEntradaNFXML.DeleteInformacaoAdicional()
            oClsFatEntradaNFXML.InsertInformacaoAdicional()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: FATURA ::: "

    Private Sub SalvarFatura()

        Try

            'Deleta Dados da Fatura
            oClsFatEntradaNFXML.DeleteFatura()

            'Seta Parametros
            oClsFatEntradaNFXML.Fatura = txtFatura.Text.Trim
            oClsFatEntradaNFXML.ValorOriginal = txtValorOriginal.Value
            oClsFatEntradaNFXML.ValorDesconto = txtValorDesconto.Value
            oClsFatEntradaNFXML.ValorLiquido = txtValorLiquido.Value
            oClsFatEntradaNFXML.NumeroParcela = txtNumeroParcela.Value
            oClsFatEntradaNFXML.IntervaloParcela = txtIntervaloEntreParcelas.Value

            'Salva Dados Fatura
            oClsFatEntradaNFXML.InsertFatura()
            oClsFatEntradaNFXML.InsertFaturaDuplicata(grdDuplicata)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadFatura()

        Try

            Call oClsFatEntradaNFXML.LoadDadosFatura(txtValorOriginal, _
                                                  txtValorDesconto, _
                                                  txtValorAcrescimo, _
                                                  IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadNFFatura()

        Try

            Call oClsFatEntradaNFXML.LoadDadosNFFatura(txtValorOriginal, _
                                                  txtValorDesconto, _
                                                  txtValorAcrescimo, _
                                                  IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: COMPRAS ::: "

    Private Sub SalvarCompras()

        Try

            'Deleta Dados da Compras
            oClsFatEntradaNFXML.DeleteCompras()

            'Seta Parametros
            oClsFatEntradaNFXML.NotaEmpenho = txtNotaEmpenho.Text.Trim
            oClsFatEntradaNFXML.InformacaoPedido = txtInformacaoPedido.Text.Trim
            oClsFatEntradaNFXML.InformacaoContrato = txtInformacaoContrato.Text.Trim

            'Salva Dados Compras
            oClsFatEntradaNFXML.InsertCompras()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: EXPORTAÇÃO ::: "

    Private Sub SalvarExportacao()

        Try

            'Deleta Dados da Exportação
            oClsFatEntradaNFXML.DeleteExportacao()

            If cboUFEmbarque.SelectedIndex <> -1 Then

                'Seta Parametros
                oClsFatEntradaNFXML.UFEmbarque = cboUFEmbarque.SelectedValue
                oClsFatEntradaNFXML.LocalEmbarque = txtLocalEmbarque.Text.Trim

                'Salva Dados Exportação
                oClsFatEntradaNFXML.InsertExportacao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: PRODUTO ::: "

    Private Sub ExcluirProduto()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEntradaNFXML.DeleteProduto()

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
            Call oClsFatEntradaNFXML.LoadGridProduto(btnSalvar.Tag, _
                                                  grdProduto)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Verifica se o Tipo de Nota Fiscal é NFe
            If cboTipoNotaFiscal.SelectedValue = TipoNotaFiscal.NotaFiscalEletronica Then

                'Informa o Usuário que Nota Fiscal não pode ser editada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)

            ElseIf btnSalvar.Enabled = False Then

                'Informa o Usuário que Nota Fiscal não pode ser editada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)

            Else

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
                Call oClsFatEntradaNFXML.LoadGridProduto(btnSalvar.Tag, _
                                                      grdProduto)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: TRANSPORTE ::: "

    Private Sub SalvarTransporte()

        Try

            'Seta Parametros            
            oClsFatEntradaNFXML.CodigoModalidadeFrete = cboModalidadeFrete.SelectedValue
            oClsFatEntradaNFXML.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsFatEntradaNFXML.CnpjCpfTransportadora = txtCNPJTransportadora.Text.Trim
            oClsFatEntradaNFXML.InscricaoEstadualTransportadora = txtInscricaoEstadualTransportadora.Text.Trim
            oClsFatEntradaNFXML.UFTransportadora = cboUFTransportadora.SelectedValue
            oClsFatEntradaNFXML.MunicipioTransportadora = cboMunicipioTransportadora.Text
            oClsFatEntradaNFXML.EnderecoTransportadora = txtEnderecoTransportadora.Text.Trim
            oClsFatEntradaNFXML.BaseCalculoTransporte = txtBaseCalculoTransporte.Value
            oClsFatEntradaNFXML.AliquotaICMSTransporte = txtAliquotaTransporte.Value
            oClsFatEntradaNFXML.ValorServicoTransporte = txtValorServicoTransporte.Value
            oClsFatEntradaNFXML.ValorICMSRetidoTransporte = txtICMSRetidoTransporte.Text.Trim
            oClsFatEntradaNFXML.UFICMSTransporte = cboUFICMSTransporte.SelectedValue
            oClsFatEntradaNFXML.CodigoMunicipioICMSTransporte = IIf(cboMunicipioICMSTransporte.SelectedIndex = -1, -1, cboMunicipioICMSTransporte.SelectedValue)
            oClsFatEntradaNFXML.TipoVeiculo = IIf(cboTipoVeiculo.SelectedIndex = -1, -1, cboTipoVeiculo.SelectedValue)
            oClsFatEntradaNFXML.CodigoCFOPTransporte = IIf(cboCFOPICMSTransporte.SelectedIndex = -1, -1, cboCFOPICMSTransporte.Text)
            oClsFatEntradaNFXML.UFPlacaVeiculo = cboUFVeiculo.SelectedValue
            oClsFatEntradaNFXML.PlacaVeiculo = txtPlacaVeiculo.Text.Trim
            oClsFatEntradaNFXML.RNTCVeiculo = txtRNTCVeiculo.Text.Trim
            oClsFatEntradaNFXML.Vagao = txtVagao.Text.Trim
            oClsFatEntradaNFXML.Balsa = txtBalsa.Text.Trim

            'Salva Dados Transporte
            oClsFatEntradaNFXML.DeleteTransporte()
            oClsFatEntradaNFXML.InsertTransporte()

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
                    Call oClsFatEntradaNFXML.DeleteReboque()

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
            oClsFatEntradaNFXML.LoadGridReboque(btnSalvar.Tag, _
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
                oClsFatEntradaNFXML.InsertReboque(txtPlacaReboque.Text.Trim, _
                                               cboUFReboque.SelectedValue, _
                                               txtRNTCReboque.Text.Trim)


            Else

                'Atualiza Reboque
                oClsFatEntradaNFXML.UpdateReboque(txtPlacaReboque.Text.Trim, _
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
            If oClsFatEntradaNFXML.ValidaReboque(txtPlacaReboque.Text, _
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
                    Call oClsFatEntradaNFXML.DeleteVolume()

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
            oClsFatEntradaNFXML.LoadGridVolume(btnSalvar.Tag, _
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
                oClsFatEntradaNFXML.InsertVolume(txtQuantidadeEmbalagemTransportadora.Value, _
                                              txtEspecieTransportadora.Text.Trim, _
                                              txtMarcaTransportadora.Text.Trim, _
                                              txtNumeroTransportadora.Text.Trim, _
                                              txtPesoLiquidoTransportadora.Value, _
                                              txtPesoBrutoTransportadora.Value)


            Else

                'Atualiza Reboque
                oClsFatEntradaNFXML.UpdateVolume(txtQuantidadeEmbalagemTransportadora.Value, _
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
            oClsIntegracao.IntegracaoNFEntradaFinanceiro(lCodigoEntradaCapa)

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
                    oDataRow("codigo_titulo_capa") = oClsFatEntradaNFXML.CodigoTituloFinanceiro
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
            If VerificaDireito(Formulario.FaturamentoEntradaNFXML, gcUpdate) = True Then

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

#Region "::: XML :::"

    Private Function ValidacaoRecebimento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRecebimento = False

            'Verifica se foi Selecionado a Linha
            If oCurrentRow Is Nothing Then
                frmMain.Informacao(Mensagem.Erro, "Primeiramente Selecione um Produto para Entrada de Nota Fiscal.")
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - CFOP
            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                Exit Function
                'Else
                '    Dim oRow() As GridEXRow = grdRecebimento.GetDataRows
                '    If grdRecebimento.GetDataRows.Count > 0 Then
                '        If IsNumeric(btnInserir.Tag) = True Then
                '            If grdRecebimento.GetDataRows.Count > 1 Then
                '                If oRow(IIf(oRow(0).RowIndex <> grdRecebimento.CurrentRow.RowIndex, 0, 1)).Cells("codigo_cfop").Value <> cboCFOP.SelectedValue Then
                '                    frmMain.errInfo.SetError(lblCFOP, "Este CFOP não é válido, uma vez que já foi informado outro CFOP.")
                '                    cboCFOP.Focus()
                '                    Exit Function
                '                End If
                '            End If
                '        ElseIf oRow(0).Cells("codigo_cfop").Value <> cboCFOP.SelectedValue Then
                '            frmMain.errInfo.SetError(lblCFOP, "Este CFOP não é válido, uma vez que já foi informado outro CFOP.")
                '            cboCFOP.Focus()
                '            Exit Function
                '        End If
                '    End If
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Operação
            If ValidaCampo(cboTipoOperacao, lblTipoOperacao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Nº Documento
            If cboNumeroDocumento.Enabled = True And cboTipoOperacao.SelectedValue <> TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento Then
                If ValidaCampo(cboNumeroDocumento, lblNumeroDocumento) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Verifica se o Fornecedor é Homologado para o Produto
            If oClsFatEntradaNFXML.ValidaFornecedorHomologado(lCodigoItem, _
                                                                     lCodigoEntradaCapa) = False Then
                frmMain.errInfo.SetError(lblProduto, "Este Produto necessita que o Fornecedor seja Homologado, e o Fornecedor Informado não é.")
                cboProduto.Focus()
                Exit Function
            End If

            'Verifica se o Produto Selecionado é Válido
            If IsNumeric(btnInserir.Tag) = False Then
                If grdRecebimento.GetDataRows.Count > 0 Then
                    If lCodigoItem <> grdRecebimento.GetDataRows(0).Cells("codigo_item").Value Then
                        frmMain.errInfo.SetError(lblProduto, "O Produto Selecionado não é válido, porque se difere do Produto já inserido.")
                        cboProduto.Focus()
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, IIf(grdXML.CurrentRow.Cells("quantidade").Value = 0, False, True)) = False Then
                Exit Function
            End If

            'Váriavel Local
            Dim dQuantidade As Double = 0

            'Seta Váriavel
            If grdRecebimento.GetDataRows.Count > 0 Then
                dQuantidade = grdRecebimento.GetTotalRow.Cells("quantidade").Value
                If IsNumeric(btnInserir.Tag) Then
                    dQuantidade -= grdRecebimento.CurrentRow.Cells("quantidade").Value
                End If
            End If

            'Verifica se a Quantidade é Válida
            If dQuantidade + txtQuantidade.Value > oCurrentRow.Cells("quantidade").Value Then
                frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada NÃO pode ser maior que a Quantidade da Nota Fiscal.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Verifica se a Quantidade é Válida
            If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Then
                If txtQuantidade.Value > dQuantidadePendente Then
                    frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada é inválida, por ser maior que a quantidade da Nota Fiscal Emitida para esta empresa.")
                    txtQuantidade.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedida.Enabled = True Then
                If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Fator de Conversão
            If txtFatorConversao.Enabled = True Then
                If ValidaCampo(txtFatorConversao, lblFatorConversao, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Valor Unitário é igual o do Pedido
            If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra) Then

                'Verifica se a Quantidade é condizente com o Pedido
                If txtQuantidade.Value > (dQuantidadePendente + (dQuantidadePedido * dToleranciaQuantidadePercentual / 100)) Then
                    MsgBox("A Quantidade informada é de: " & FormatNumber(txtQuantidade.Value, 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                           "A Quantidade Pendente de Recebimento é de: " & FormatNumber(dQuantidadePendente, 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                           "A Tolerância para o Item é de: " & FormatNumber(dToleranciaQuantidadePercentual, 2, Microsoft.VisualBasic.TriState.True) & ". Totalizando: " & FormatNumber((dQuantidadePendente + (dQuantidadePedido * dToleranciaQuantidadePercentual / 100)), 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & vbCrLf & _
                           "Caso Deseje Receber a Mercadoria, efetue com o Tipo de Operação: COMPRA - PEDIDO EXCEDENTE.", MsgBoxStyle.Exclamation, Me.Text)
                    cboTipoOperacao.Focus()
                    Exit Function
                End If

                'Verifica se o Valor Unitário bate com o Valor do Pedido
                If (Round((grdXML.CurrentRow.Cells("valor_unitario").Value / IIf(txtFatorConversao.Value = 0, 1, txtFatorConversao.Value)), 4) <> Round(dValorUnitario, 4)) Then
                    If MsgBox("O Valor do Produto na Nota Fiscal é de R$ " & FormatNumber((grdXML.CurrentRow.Cells("valor_unitario").Value) / IIf(txtFatorConversao.Value = 0, 1, txtFatorConversao.Value), 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                              "O Valor do Produto no Pedido de Compra é de R$ " & FormatNumber((dValorUnitario / IIf(txtFatorConversao.Value = 0, 1, txtFatorConversao.Value)), 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                              "Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                        Exit Function
                    End If
                End If

            End If

            'Verifica se foi Selecionado o Campo - Depósito
            If cboDeposito.Enabled = True Then
                If ValidaCampo(cboDeposito, lblDeposito) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Lote
            If txtLote.Enabled = True Then
                If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Data de Fabricação é correta
            If dtpDataFabricacao.Enabled = True Then
                If dtpDataFabricacao.Value > Now.Date Then
                    frmMain.errInfo.SetError(lblDataFabricacao, "A Data de Fabricação NÃO pode ser maior que a Data Corrente.")
                    dtpDataFabricacao.Focus()
                End If
            End If

            'Verifica se a Data de Validade é correta
            If dtpDataValidade.Enabled = True Then
                If dtpDataValidade.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataValidade, "A Data de Validade NÃO pode ser menor que a Data Corrente.")
                    dtpDataValidade.Focus()
                End If
            End If

            'Seta Retorno da Função
            ValidacaoRecebimento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGridRecebimento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid - Recebimento
            Call oClsFatEntradaNFXML.LoadGridRecebimento(grdRecebimento, _
                                                                lCodigoEntradaCapa, _
                                                                iCodigoEntradaItem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridXML()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            Dim Index As Integer
             
            Call oClsFatEntradaNFXML.LoadGridXML(grdXML, grdXML.CurrentRow.Cells("codigo_entrada_capa").Value, Nothing)
            
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoRecebimento()

        Try

            'Limpa Controles
            If Not oCurrentRow Is Nothing Then
                'Seta Controles
                cboCFOP.SelectedValue = CType(LoadDescricao("sp_select_cadastro_basico_cfop_relacionado " & goUsuario.iEmpresa & ", " & oCurrentRow.Cells("cfop").Value), String)
                'Váriavel - Quantidade
                Dim dQuantidade As Double = 0
                If grdRecebimento.GetDataRows.Count > 0 Then
                    dQuantidade = grdRecebimento.GetTotalRow.Cells("quantidade").Value
                End If
                txtQuantidade.Value = oCurrentRow.Cells("quantidade").Value - dQuantidade
                txtFatorConversao.Value = 1
                txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value
            Else
                cboCFOP.Text = ""
                txtQuantidade.Value = 0
                txtFatorConversao.Value = 0
                txtQuantidadeEstoque.Value = 0
            End If

            'Limpa Controle
            cboNumeroDocumento.Text = ""
            cboUnidadeMedida.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""
            btnInserir.Tag = ""

            'Limpa Váriaveis
            bItemEstoque = False
            bControlaQualidade = False
            bControlaLote = False
            bDataFabricacao = False
            bDataValidade = False
            dQuantidadePendente = 0
            dValorUnitario = 0
            dFatorConversao = 0
            iCodigoEntradaItemLote = -1

            'Executa Rotina CFOP
            Call cboCFOP_SelectedIndexChanged(cboCFOP, System.EventArgs.Empty)

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRecebimento()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRecebimento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFatEntradaNFXML.DeleteRecebimento()

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub KIT()

        Try

            'Verifica a Forma de Venda do Produto
            If grdRecebimento.CurrentRow.Cells("codigo_forma_venda_item").Value = CInt(FormaVendaItem.Kit) Then

                'Váriaveis Locais
                Dim oForm As New frmFatEntradaNFProdutoKIT

                'Seta Parâmetros
                oForm.CodigoItem = grdRecebimento.CurrentRow.Cells("codigo_item").Value
                oForm.CodigoProduto = grdRecebimento.CurrentRow.Cells("codigo_produto").Value
                oForm.Descricao = grdRecebimento.CurrentRow.Cells("descricao").Value
                oForm.QuantidadeProduto = grdRecebimento.CurrentRow.Cells("quantidade_estoque").Value
                oForm.CodigoEntradaCapa = grdRecebimento.CurrentRow.Cells("codigo_entrada_capa").Value
                oForm.CodigoEntradaItem = grdRecebimento.CurrentRow.Cells("codigo_entrada_item").Value
                oForm.Codigo = grdRecebimento.CurrentRow.Cells("codigo").Value

                'Abre o Formulário
                oForm.ShowDialog(Me)
                
                'Carrega Grid - Recebimento
                Call oClsFatEntradaNFXML.LoadGridRecebimento(grdRecebimento, _
                                                                    lCodigoEntradaCapa, _
                                                                    iCodigoEntradaItem)

            Else

                'Informa o Usuário que a Operação não pode ser realizada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Produto Selecionado não é um KIT.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarRecebimento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            With grdRecebimento.CurrentRow.Cells


                'Limpa Controles
                If Not oCurrentRow Is Nothing Then
                    'Seta Controles
                    cboCFOP.SelectedValue = CType(LoadDescricao("sp_select_cadastro_basico_cfop_relacionado " & goUsuario.iEmpresa & ", " & oCurrentRow.Cells("cfop").Value), String)
                    'Váriavel - Quantidade
                    Dim dQuantidade As Double = 0
                    If grdRecebimento.GetDataRows.Count > 0 Then
                        dQuantidade = grdRecebimento.GetTotalRow.Cells("quantidade").Value
                    End If
                    txtQuantidade.Value = oCurrentRow.Cells("quantidade").Value - dQuantidade
                    txtFatorConversao.Value = 1
                    txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value
                Else
                    cboCFOP.Text = ""
                    txtQuantidade.Value = 0
                    txtFatorConversao.Value = 0
                    txtQuantidadeEstoque.Value = 0
                End If

                'Limpa Controle
                cboNumeroDocumento.Text = ""
                cboUnidadeMedida.Text = ""
                txtLote.Text = ""
                dtpDataFabricacao.Value = Now.Date
                dtpDataValidade.Value = Now.Date
                cboCentroGasto.Text = ""
                cboContaContabil.Text = ""
                btnInserir.Tag = ""

                'Limpa Váriaveis
                bItemEstoque = False
                bControlaQualidade = False
                bControlaLote = False
                bDataFabricacao = False
                bDataValidade = False
                dQuantidadePendente = 0
                dValorUnitario = 0
                dFatorConversao = 0
                iCodigoEntradaItemLote = -1

                'Executa Rotina CFOP
                Call cboCFOP_SelectedIndexChanged(cboCFOP, System.EventArgs.Empty)


                'Carrega Controles
                btnInserir.Tag = grdRecebimento.CurrentRow.Cells("codigo").Value
                cboCFOP.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_cfop").Value
                cboTipoOperacao.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_tipo_operacao").Value
                cboNumeroDocumento.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_composto_numero_documento").Value
                If cboTipoOperacao.SelectedValue = TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento Then
                    cboNumeroDocumento.Text = grdRecebimento.CurrentRow.Cells("numero_documento").Value
                End If
                cboProduto.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_composto_produto").Value
                txtQuantidade.Value = grdRecebimento.CurrentRow.Cells("quantidade").Value
                If IsDBNull(grdRecebimento.CurrentRow.Cells("codigo_unidade_medida").Value) = False Then cboUnidadeMedida.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_unidade_medida").Value
                txtFatorConversao.Value = IIf(IsDBNull(grdRecebimento.CurrentRow.Cells("fator_conversao").Value), 0, grdRecebimento.CurrentRow.Cells("fator_conversao").Value)
                txtQuantidadeEstoque.Value = IIf(IsDBNull(grdRecebimento.CurrentRow.Cells("quantidade_estoque").Value), 0, grdRecebimento.CurrentRow.Cells("quantidade_estoque").Value)
                If IsDBNull(grdRecebimento.CurrentRow.Cells("codigo_deposito").Value) = False Then cboDeposito.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_deposito").Value
                txtLote.Text = IIf(IsDBNull(grdRecebimento.CurrentRow.Cells("lote").Value), "", grdRecebimento.CurrentRow.Cells("lote").Value)
                If IsDBNull(grdRecebimento.CurrentRow.Cells("data_fabricacao").Value) = False Then dtpDataValidade.Value = grdRecebimento.CurrentRow.Cells("data_fabricacao").Value
                If IsDBNull(grdRecebimento.CurrentRow.Cells("data_validade").Value) = False Then dtpDataValidade.Value = grdRecebimento.CurrentRow.Cells("data_validade").Value
                cboCentroGasto.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_centro_gasto").Value
                cboContaContabil.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_conta_contabil").Value

                'Seta Focu
                cboCFOP.Focus()

            End With

            'Seta Cursor do Mousr
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class