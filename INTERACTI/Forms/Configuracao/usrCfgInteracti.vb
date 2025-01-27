Imports INTERACTI.NFe.CertificadoDigital

Public Class usrCfgInteracti

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgInteracti As New clsUsrCfgInteracti

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgInteracti_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCfgInteracti_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgInteracti_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva dados do Diretórios
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSair.Click
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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            ' Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgInteracti_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoInteracti, gcUpdate)

            Call LoadComboSimNao(cboAtualizaCadastroXML)
            Call LoadComboSimNao(cboAtualizaPedidoCompraNF)
            Call LoadComboSimNao(cboAtualizaPedidoCompraRecebimento)
            Call LoadComboSimNao(cboAtualizaPrecoCompraRecebimento)
            Call LoadComboSimNao(cboAtualizaRegraImposto)
            Call LoadComboSimNao(cboBoletoBancarioDll)
            Call LoadComboSimNao(cboComboProdutoDescricao)
            Call LoadComboSimNao(cboControlaEstoque)
            Call LoadComboSimNao(cboDadosProdutoEstoque)
            Call LoadComboSimNao(cboDataOrcamentoMaiorAtual)
            Call LoadComboSimNao(cboDataPedidoVendaMaiorAtual)
            Call LoadComboSimNao(cboDuplicidadeItemVenda)
            Call LoadComboSimNao(cboExibeDescontoFaturamento)
            Call LoadComboSimNao(cboGerarNumeracaoNFE)
            Call LoadComboSimNao(cboImpostoRegraPorCliente)
            Call LoadComboSimNao(cboImpostoRegraPorProduto)
            Call LoadComboSimNao(cboInformacaoAdicionalProdutoPolygon)
            Call LoadComboSimNao(cboLoteTextoEmissao)
            Call LoadComboSimNao(cboMoverArquivoNFEPastaEntrada)
            Call LoadComboSimNao(cboMultiploVenda)
            Call LoadComboSimNao(cboOrcamentoPedidoMatricial)
            Call LoadComboSimNao(cboPdvHablitaDadosPagamentoOrcamento)
            Call LoadComboSimNao(cboPedidoCompraCheckbox)
            Call LoadComboSimNao(cboReaprovarPedidoCompra)
            Call LoadComboSimNao(cboReservarEstoquePedidoVenda)
            Call LoadComboSimNao(cboTeclaAtalho)
            Call LoadComboSimNao(cboTotalImpostoNFAliquota)
            Call LoadComboSimNao(cboUsarVendedorExternoVenda)
            Call LoadComboSimNao(cboValidaCentroCusto)
            Call LoadComboSimNao(cboValidaContaContabil)
            Call LoadComboSimNao(cboValidaEmbalagem)
            Call LoadComboSimNao(cboValidaGrupoItemOrcamento)
            Call LoadComboSimNao(cboValidaGrupoItemPedido)
            Call LoadComboSimNao(cboValidaRegraFaturamento)
            Call LoadComboSimNao(cboValidaVendaPrecoMinimo)
            Call LoadComboSimNao(cboValidaVendaPrecoVenda)
            Call LoadComboSimNao(cboValidaVendaTituloAtraso)
            Call LoadComboSimNao(cboVisualizarPreNota)
            Call LoadComboSimNao(cboArquivoPadraoModulo)


            Call LoadDados()

            'Seta Aba
            tabDados.SelectedTab = pagComercial

            'Seta Focu
            cboValidaGrupoItemPedido.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadDados()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgInteracti.LoadDados(cboAtualizaCadastroXML, _
                         cboAtualizaPedidoCompraNF, _
                         cboAtualizaPedidoCompraRecebimento, _
                         cboAtualizaPrecoCompraRecebimento, _
                         cboAtualizaRegraImposto, _
                         cboBoletoBancarioDll, _
                         cboComboProdutoDescricao, _
                         cboControlaEstoque, _
                         cboDadosProdutoEstoque, _
                         cboDataOrcamentoMaiorAtual, _
                         cboDataPedidoVendaMaiorAtual, _
                         cboDuplicidadeItemVenda, _
                         cboExibeDescontoFaturamento, _
                         cboGerarNumeracaoNFE, _
                         cboImpostoRegraPorCliente, _
                         cboImpostoRegraPorProduto, _
                         cboInformacaoAdicionalProdutoPolygon, _
                         cboLoteTextoEmissao, _
                         cboMoverArquivoNFEPastaEntrada, _
                         cboMultiploVenda, _
                         cboOrcamentoPedidoMatricial, _
                         cboPdvHablitaDadosPagamentoOrcamento, _
                         cboPedidoCompraCheckbox, _
                         cboReaprovarPedidoCompra, _
                         cboReservarEstoquePedidoVenda, _
                         cboTeclaAtalho, _
                         cboTotalImpostoNFAliquota, _
                         cboUsarVendedorExternoVenda, _
                         cboValidaCentroCusto, _
                         cboValidaContaContabil, _
                         cboValidaEmbalagem, _
                         cboValidaGrupoItemOrcamento, _
                         cboValidaGrupoItemPedido, _
                         cboValidaRegraFaturamento, _
                         cboValidaVendaPrecoMinimo, _
                         cboValidaVendaPrecoVenda, _
                         cboValidaVendaTituloAtraso, _
                         cboVisualizarPreNota, _
                         cboArquivoPadraoModulo, _
                         txtCodigoDepositoPadraoVenda, _
                         txtDeltaCustoMedioPrecoCompraTeorico, _
                         txtDescricaoComboParceiroNegocio, _
                         txtEmailBackupNFE, _
                         txtFormatoOrdemProducao, _
                         txtFormularioFindProdutoCompra, _
                         txtFormularioFindProdutoOrcamento, _
                         txtFormularioFindProdutoVenda, _
                         txtPastaArquivo, _
                         txtPastaArquivoFisico, _
                         txtStringConexaoSelma, _
                         txtTipoApontamentoConcorrente, _
                         txtTipoCodigoProdutoEmissaoNotaFiscal)

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

            'Seta Parametros
            oClsCfgInteracti.ValidaGrupoItemPedido = cboValidaGrupoItemPedido.SelectedValue
            oClsCfgInteracti.ValidaGrupoItemOrcamento = cboValidaGrupoItemOrcamento.SelectedValue
            oClsCfgInteracti.OrcamentoPedidoMatricial = cboOrcamentoPedidoMatricial.SelectedValue
            oClsCfgInteracti.PDVHablitaDadosPagamentoOrcamento = cboPdvHablitaDadosPagamentoOrcamento.SelectedValue
            oClsCfgInteracti.CodigoDepositoPadraoVenda = txtCodigoDepositoPadraoVenda.Text
            oClsCfgInteracti.DuplicidadeItemVenda = cboDuplicidadeItemVenda.SelectedValue
            oClsCfgInteracti.ValidaVendaPrecoVenda = cboValidaVendaPrecoVenda.SelectedValue
            oClsCfgInteracti.ValidaVendaPrecoMinimo = cboValidaVendaPrecoMinimo.SelectedValue
            oClsCfgInteracti.MultiploVenda = cboMultiploVenda.SelectedValue
            oClsCfgInteracti.FormularioFindProdutoOrcamento = txtFormularioFindProdutoOrcamento.Text
            oClsCfgInteracti.FormularioFindProdutoVenda = txtFormularioFindProdutoVenda.Text
            oClsCfgInteracti.ReservarEstoquePedidoVenda = cboReservarEstoquePedidoVenda.SelectedValue
            oClsCfgInteracti.DataPedidoVendaMaiorAtual = cboDataPedidoVendaMaiorAtual.SelectedValue
            oClsCfgInteracti.DataOrcamentoMaiorAtual = cboDataOrcamentoMaiorAtual.SelectedValue
            oClsCfgInteracti.UsarVendedorExternoVenda = cboUsarVendedorExternoVenda.SelectedValue
            oClsCfgInteracti.AtualizaPedidoCompraNF = cboAtualizaPedidoCompraNF.SelectedValue
            oClsCfgInteracti.AtualizaPedidoCompraRecebimento = cboAtualizaPedidoCompraRecebimento.SelectedValue
            oClsCfgInteracti.DeltaCustoMedioPrecoCompraTeorico = txtDeltaCustoMedioPrecoCompraTeorico.Text
            oClsCfgInteracti.ReaprovarPedidoCompra = cboReaprovarPedidoCompra.SelectedValue
            oClsCfgInteracti.PedidoCompraCheckbox = cboPedidoCompraCheckbox.SelectedValue
            oClsCfgInteracti.FormularioFindProdutoCompra = txtFormularioFindProdutoCompra.Text
            oClsCfgInteracti.AtualizaPrecoCompraRecebimento = cboAtualizaPrecoCompraRecebimento.SelectedValue
            oClsCfgInteracti.ControlaEstoque = cboControlaEstoque.SelectedValue
            oClsCfgInteracti.DadosProdutoEstoque = cboDadosProdutoEstoque.SelectedValue
            oClsCfgInteracti.ExibeDescontoFaturamento = cboExibeDescontoFaturamento.SelectedValue
            oClsCfgInteracti.EmailBackupNFe = txtEmailBackupNFE.Text
            oClsCfgInteracti.MoverArquivoNFePastaEntrada = cboMoverArquivoNFEPastaEntrada.SelectedValue
            oClsCfgInteracti.GerarNumeracaoNFe = cboGerarNumeracaoNFE.SelectedValue
            oClsCfgInteracti.InformacaoAdicionalProdutoPolygon = cboInformacaoAdicionalProdutoPolygon.SelectedValue
            oClsCfgInteracti.TipoCodigoProdutoEmissaoNotaFiscal = txtTipoCodigoProdutoEmissaoNotaFiscal.Text
            oClsCfgInteracti.VisualizarPreNota = cboVisualizarPreNota.SelectedValue
            oClsCfgInteracti.ValidaRegraFaturamento = cboValidaRegraFaturamento.SelectedValue
            oClsCfgInteracti.AtualizaCadastroXML = cboAtualizaCadastroXML.SelectedValue
            oClsCfgInteracti.BoletoBancarioDLL = cboBoletoBancarioDll.SelectedValue
            oClsCfgInteracti.ValidaCentroCusto = cboValidaCentroCusto.SelectedValue
            oClsCfgInteracti.ValidaContaContabil = cboValidaContaContabil.SelectedValue
            oClsCfgInteracti.ValidaVendaTituloAtraso = cboValidaVendaTituloAtraso.SelectedValue
            oClsCfgInteracti.ComboProdutoDescricao = cboComboProdutoDescricao.SelectedValue
            oClsCfgInteracti.TeclaAtalho = cboTeclaAtalho.SelectedValue
            oClsCfgInteracti.PastaArquivo = txtPastaArquivo.Text
            oClsCfgInteracti.PastaArquivoFisico = txtPastaArquivoFisico.Text
            oClsCfgInteracti.DescricaoComboParceiroNegocio = txtDescricaoComboParceiroNegocio.Text
            oClsCfgInteracti.StringConexaoSelma = txtStringConexaoSelma.Text
            oClsCfgInteracti.ValidaEmbalagem = cboValidaEmbalagem.SelectedValue
            oClsCfgInteracti.LoteTextoEmissao = cboLoteTextoEmissao.SelectedValue
            oClsCfgInteracti.AtualizaRegraImposto = cboAtualizaRegraImposto.SelectedValue
            oClsCfgInteracti.ImpostoRegraPorCliente = cboImpostoRegraPorCliente.SelectedValue
            oClsCfgInteracti.TotalImpostoNFAliquota = cboTotalImpostoNFAliquota.SelectedValue
            oClsCfgInteracti.ImpostoRegraPorProduto = cboImpostoRegraPorProduto.SelectedValue
            oClsCfgInteracti.TipoApontamentoConcorrente = txtTipoApontamentoConcorrente.Text
            oClsCfgInteracti.FormatoOrdemProducao = txtFormatoOrdemProducao.Text

            'Salva Dados
            oClsCfgInteracti.Salvar()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region




End Class
