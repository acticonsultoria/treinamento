Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFatEmissaoNFeDevolucaoMagma

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFatEmissaoNFeDevolucaoMagma As New clsUsrFatEmissaoNFeDevolucaoMagma
    Private oClsUsrFatEmissaoNFe As New clsUsrFatEmissaoNFe
    Private oClsFatEmissaoNFeItem As New clsFrmFatEmissaoNFeProduto

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFatEmissaoNFeDevolucaoMagma_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFatEmissaoNFeDevolucaoMagma_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: DEVOLUÇÃO :::"

    Private Sub btnConfiguracaoGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracaoGrid.Click
        Try
            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFeDevolucaoMagma
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFeDevolucaoMagma)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 2
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnGerarNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarNFe.Click
        Try

            If MsgBox("Deseja inserir as NF-e´s dos itens selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Gerar NF-e") = MsgBoxResult.No Then Exit Sub

            Dim sDestinatario As String = ""

            'Percorrendo todos os registros "ticados"
            For Each oRow In grdListagem.GetCheckedRows

                If oRow.Cells.Item("destinatario").Value <> "" Then

                    If oRow.Cells.Item("destinatario").Value <> sDestinatario Then

                        oClsUsrFatEmissaoNFe.InsertNotaFiscal()

                        btnGerarNFe.Tag = oClsUsrFatEmissaoNFe.CodigoEmissaoCapa

                        'Carrega Dados do Emitente
                        Call LoadDadosEmitente()

                        'Carrega Configuração da NF-e
                        Call LoadConfiguracaoNFe()

                        'Seta Parametros - Capa
                        oClsUsrFatEmissaoNFe.CodigoEmissaoCapa = IIf(IsNumeric(btnGerarNFe.Tag), btnGerarNFe.Tag, -1)
                        oClsUsrFatEmissaoNFe.ModeloNotaFiscal = 55
                        oClsUsrFatEmissaoNFe.SequenciaNotaFiscal = 1
                        oClsUsrFatEmissaoNFe.Serie = 1
                        oClsUsrFatEmissaoNFe.DataEmissao = Now.Date
                        oClsUsrFatEmissaoNFe.NaturezaOperacao = cboNaturezaOperacao.Text
                        oClsUsrFatEmissaoNFe.DataSaida = Now.Date
                        oClsUsrFatEmissaoNFe.TipoItem = TipoItem.produto
                        oClsUsrFatEmissaoNFe.CodigoFormaEmissaoNFe = 1
                        oClsUsrFatEmissaoNFe.CodigoTipoOperacaoNFe = 1
                        oClsUsrFatEmissaoNFe.CodigoTipoConsumidor = 0
                        oClsUsrFatEmissaoNFe.CodigoFinalidadeEmissaoNFe = 1
                        oClsUsrFatEmissaoNFe.CodigoTipoDocumentoFiscal = 1
                        oClsUsrFatEmissaoNFe.CodigoFormaEmissaoNFe = 1
                        oClsUsrFatEmissaoNFe.CodigoFormaPagamento = 0
                        oClsUsrFatEmissaoNFe.NotaFiscal = -1

                        oClsUsrFatEmissaoNFe.UpdateNotaFiscal()

                        'Declara as variaveis do destinatario
                        Dim sCnpjCpfDestinatario As String = ""
                        Dim sLogradouro As String = ""
                        Dim sNumero As String = ""
                        Dim sComplemento As String = ""
                        Dim sBairro As String = ""
                        Dim iCodigoMunicipio As Integer = -1
                        Dim sUF As String = ""
                        Dim sCEP As String = ""
                        Dim iCodigoPais As Integer = -1
                        Dim sTelefone As String = ""
                        Dim sInscricaoEstadual As String = ""
                        Dim sInscricaoSuframa As String = ""
                        Dim sEmail As String = ""

                        'Carrega os dados do destinatario
                        oClsUsrFatEmissaoNFeDevolucaoMagma.LoadDadosDestinatario(grdListagem.CurrentRow.Cells.Item("destinatario").Value, _
                                                                                 sCnpjCpfDestinatario, _
                                                                                 sLogradouro, _
                                                                                 sNumero, _
                                                                                 sComplemento, _
                                                                                 sBairro, _
                                                                                 iCodigoMunicipio, _
                                                                                 sUF, _
                                                                                 sCEP, _
                                                                                 iCodigoPais, _
                                                                                 sTelefone, _
                                                                                 sInscricaoEstadual, _
                                                                                 sInscricaoSuframa, _
                                                                                 sEmail)
                        'Seta Parametros Destinatário
                        oClsUsrFatEmissaoNFe.CodigoDestinatario = grdListagem.CurrentRow.Cells.Item("destinatario").Value
                        oClsUsrFatEmissaoNFe.CnpjCpfDestinatario = sCnpjCpfDestinatario
                        oClsUsrFatEmissaoNFe.LogradouroDestinatario = sLogradouro
                        oClsUsrFatEmissaoNFe.NumeroDestinatario = sNumero
                        oClsUsrFatEmissaoNFe.ComplementoDestinatario = sComplemento
                        oClsUsrFatEmissaoNFe.BairroDestinatario = sBairro
                        oClsUsrFatEmissaoNFe.CodigoMunicipioDestinatario = iCodigoMunicipio
                        oClsUsrFatEmissaoNFe.UFDestinatario = sUF
                        oClsUsrFatEmissaoNFe.CepDestinatario = sCEP
                        oClsUsrFatEmissaoNFe.CodigoPaisDestinatario = iCodigoPais
                        oClsUsrFatEmissaoNFe.TelefoneDestinatario = sTelefone
                        oClsUsrFatEmissaoNFe.InscricaoEstadualDestinatario = sInscricaoEstadual
                        oClsUsrFatEmissaoNFe.InscricaoSuframaDestinatario = sInscricaoSuframa
                        oClsUsrFatEmissaoNFe.EmailDestinatario = sEmail
                        oClsUsrFatEmissaoNFe.OutroLugarEntrega = False
                        oClsUsrFatEmissaoNFe.OutroLugarRetirada = False
                        oClsUsrFatEmissaoNFe.Identificacao = ""
                        oClsUsrFatEmissaoNFe.RazaoSocialDestinatario = grdListagem.CurrentRow.Cells.Item("destinatario").Text

                        oClsUsrFatEmissaoNFe.InsertDestinatario()
                        oClsUsrFatEmissaoNFe.InsertEmitente()
                        oClsUsrFatEmissaoNFe.InsertTotal()

                        Dim dValor As Double = 0
                        dValor = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value

                        oClsUsrFatEmissaoNFe.Fatura = "A VISTA"
                        oClsUsrFatEmissaoNFe.ValorOriginal = dValor
                        oClsUsrFatEmissaoNFe.ValorDesconto = 0
                        oClsUsrFatEmissaoNFe.ValorLiquido = dValor
                        oClsUsrFatEmissaoNFe.NumeroParcela = 1
                        oClsUsrFatEmissaoNFe.IntervaloParcela = 0
                        oClsUsrFatEmissaoNFe.CodigoCondicaoPagamento = 1

                        oClsUsrFatEmissaoNFe.InsertFatura()

                        oClsUsrFatEmissaoNFe.CodigoModalidadeFrete = 0
                        oClsUsrFatEmissaoNFe.CodigoTransportadora = -1
                        oClsUsrFatEmissaoNFe.RazaoSocialTransportadora = -1
                        oClsUsrFatEmissaoNFe.CnpjCpfTransportadora = ""
                        oClsUsrFatEmissaoNFe.InscricaoEstadualTransportadora = ""
                        oClsUsrFatEmissaoNFe.UFTransportadora = ""
                        oClsUsrFatEmissaoNFe.MunicipioTransportadora = ""
                        oClsUsrFatEmissaoNFe.EnderecoTransportadora = ""
                        oClsUsrFatEmissaoNFe.BaseCalculoTransporte = 0
                        oClsUsrFatEmissaoNFe.AliquotaICMSTransporte = 0
                        oClsUsrFatEmissaoNFe.ValorServicoTransporte = 0
                        oClsUsrFatEmissaoNFe.ValorICMSRetidoTransporte = 0
                        oClsUsrFatEmissaoNFe.TipoVeiculo = -1
                        oClsUsrFatEmissaoNFe.UFICMSTransporte = ""
                        oClsUsrFatEmissaoNFe.CodigoMunicipioICMSTransporte = -1
                        oClsUsrFatEmissaoNFe.CodigoCFOPTransporte = -1
                        oClsUsrFatEmissaoNFe.UFPlacaVeiculo = ""
                        oClsUsrFatEmissaoNFe.PlacaVeiculo = ""
                        oClsUsrFatEmissaoNFe.RNTCVeiculo = ""
                        oClsUsrFatEmissaoNFe.Vagao = ""
                        oClsUsrFatEmissaoNFe.Balsa = ""

                        oClsUsrFatEmissaoNFe.InsertTransporte()

                        oClsFatEmissaoNFeItem.CodigoEmissaoCapa = btnGerarNFe.Tag
                        oClsFatEmissaoNFeItem.CodigoItem = grdListagem.CurrentRow.Cells.Item("codigo_produto").Value
                        oClsFatEmissaoNFeItem.CodigoEmissaoItem = -1
                        oClsFatEmissaoNFeItem.CodigoProdutoServico = grdListagem.CurrentRow.Cells.Item("codigo_produto").Value
                        oClsFatEmissaoNFeItem.CodigoEAN = ""
                        oClsFatEmissaoNFeItem.Descricao = grdListagem.CurrentRow.Cells.Item("produto").Value
                        oClsFatEmissaoNFeItem.CodigoCFOP = cboCFOP.SelectedValue
                        oClsFatEmissaoNFeItem.CFOP = cboCFOP.Text.Trim
                        oClsFatEmissaoNFeItem.CodigoNCM = grdListagem.CurrentRow.Cells.Item("codigo_ncm").Value
                        oClsFatEmissaoNFeItem.NCM = grdListagem.CurrentRow.Cells.Item("ncm").Value
                        oClsFatEmissaoNFeItem.Quantidade = grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.ValorFrete = 0
                        oClsFatEmissaoNFeItem.ValorSeguro = 0
                        oClsFatEmissaoNFeItem.ValorOutrasDespesas = 0
                        oClsFatEmissaoNFeItem.CodigoUnidadeMedida = 1
                        oClsFatEmissaoNFeItem.UnidadeMedida = "UN"
                        oClsFatEmissaoNFeItem.ValorUnitario = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value
                        oClsFatEmissaoNFeItem.ValorDesconto = 0
                        oClsFatEmissaoNFeItem.ValorTotal = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.IncideValorTotalNF = False
                        oClsFatEmissaoNFeItem.PedidoCompra = 0
                        oClsFatEmissaoNFeItem.NumeroItemPedidoCompra = 0
                        oClsFatEmissaoNFeItem.InformacoesAdicionais = ""
                        oClsFatEmissaoNFeItem.CodigoEmissaoDI = -1
                        oClsFatEmissaoNFeItem.CodigoFabricante = ""
                        oClsFatEmissaoNFeItem.CalculoAutomatico = True

                        oClsFatEmissaoNFeItem.InsertProduto()

                        oClsFatEmissaoNFeItem.SituacaoTributariaIPI = "SAÍDA ISENTA"
                        oClsFatEmissaoNFeItem.TipoCalculoIPI = 1
                        oClsFatEmissaoNFeItem.BaseCalculoIPI = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaIPI = 0
                        oClsFatEmissaoNFeItem.QuantidadeTotalUnidadePadraoIPI = 0
                        oClsFatEmissaoNFeItem.ValorUnidadeIPI = 0
                        oClsFatEmissaoNFeItem.ValorIPI = 0
                        oClsFatEmissaoNFeItem.CodigoEnquadramentoIPI = 340

                        oClsFatEmissaoNFeItem.InsertImpostoIPI()

                        oClsFatEmissaoNFeItem.CodigoSituacaoTributariaPIS = 10
                        oClsFatEmissaoNFeItem.SituacaoTributariaPIS = "OUTRAS OPERAÇÕES DE SAÍDA"
                        oClsFatEmissaoNFeItem.TipoCalculoPIS = 1
                        oClsFatEmissaoNFeItem.BaseCalculoPIS = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemPIS = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaPIS = 0
                        oClsFatEmissaoNFeItem.AliquotaValorPIS = 0
                        oClsFatEmissaoNFeItem.ValorPIS = 0
                        oClsFatEmissaoNFeItem.TipoCalculoPISST = -1
                        oClsFatEmissaoNFeItem.BaseCalculoPISST = 0
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemPISST = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaPISST = 0
                        oClsFatEmissaoNFeItem.AliquotaValorPISST = 0
                        oClsFatEmissaoNFeItem.ValorPISST = 0

                        oClsFatEmissaoNFeItem.InsertImpostoPIS()

                        oClsFatEmissaoNFeItem.CodigoSituacaoTributariaCOFINS = 10
                        oClsFatEmissaoNFeItem.SituacaoTributariaCOFINS = "OUTRAS OPERAÇÕES DE SAÍDA"
                        oClsFatEmissaoNFeItem.TipoCalculoCOFINS = 1
                        oClsFatEmissaoNFeItem.BaseCalculoCOFINS = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINS = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINS = 0
                        oClsFatEmissaoNFeItem.AliquotaValorCOFINS = 0
                        oClsFatEmissaoNFeItem.ValorCOFINS = 0
                        oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                        oClsFatEmissaoNFeItem.BaseCalculoCOFINSST = 0
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINSST = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINSST = 0
                        oClsFatEmissaoNFeItem.AliquotaValorCOFINSST = 0
                        oClsFatEmissaoNFeItem.ValorCOFINSST = 0

                        oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                        oClsFatEmissaoNFeItem.BaseCalculoII = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.DespesaAduaneira = 0
                        oClsFatEmissaoNFeItem.AliquotaIOF = 0
                        oClsFatEmissaoNFeItem.AliquotaII = 0

                        oClsFatEmissaoNFeItem.InsertImpostoII()

                        oClsFatEmissaoNFeItem.CodigoOrigemItem = 0
                        oClsFatEmissaoNFeItem.CodigoSituacaoTributariaICMS = 41
                        oClsFatEmissaoNFeItem.SituacaoTributariaICMS = "NÃO TRIBUTADA"
                        oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = -1
                        oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = -1
                        oClsFatEmissaoNFeItem.BaseCalculoICMS = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaICMS = -1
                        oClsFatEmissaoNFeItem.ValorICMS = 0
                        oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = -1
                        oClsFatEmissaoNFeItem.IVA = -1
                        oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = -1
                        oClsFatEmissaoNFeItem.BaseCalculoICMSST = -1
                        oClsFatEmissaoNFeItem.AliquotaICMSST = -1
                        oClsFatEmissaoNFeItem.ValorICMSST = 0

                        oClsFatEmissaoNFeItem.InsertImpostoICMS()

                        sDestinatario = oRow.Cells.Item("destinatario").Value

                        frmMain.Informacao("Registro(s) inseridos com Sucesso.", gColorInformacaoOK)
                    Else

                        oClsFatEmissaoNFeItem.CodigoEmissaoCapa = btnGerarNFe.Tag
                        oClsFatEmissaoNFeItem.CodigoItem = grdListagem.CurrentRow.Cells.Item("codigo_produto").Value
                        oClsFatEmissaoNFeItem.CodigoEmissaoItem = -1
                        oClsFatEmissaoNFeItem.CodigoProdutoServico = grdListagem.CurrentRow.Cells.Item("codigo_produto").Value
                        oClsFatEmissaoNFeItem.CodigoEAN = ""
                        oClsFatEmissaoNFeItem.Descricao = grdListagem.CurrentRow.Cells.Item("produto").Value
                        oClsFatEmissaoNFeItem.CodigoCFOP = cboCFOP.SelectedValue
                        oClsFatEmissaoNFeItem.CFOP = cboCFOP.Text.Trim
                        oClsFatEmissaoNFeItem.CodigoNCM = grdListagem.CurrentRow.Cells.Item("codigo_ncm").Value
                        oClsFatEmissaoNFeItem.NCM = grdListagem.CurrentRow.Cells.Item("ncm").Value
                        oClsFatEmissaoNFeItem.Quantidade = grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.ValorFrete = 0
                        oClsFatEmissaoNFeItem.ValorSeguro = 0
                        oClsFatEmissaoNFeItem.ValorOutrasDespesas = 0
                        oClsFatEmissaoNFeItem.CodigoUnidadeMedida = 1
                        oClsFatEmissaoNFeItem.UnidadeMedida = "UN"
                        oClsFatEmissaoNFeItem.ValorUnitario = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value
                        oClsFatEmissaoNFeItem.ValorDesconto = 0
                        oClsFatEmissaoNFeItem.ValorTotal = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.IncideValorTotalNF = False
                        oClsFatEmissaoNFeItem.PedidoCompra = 0
                        oClsFatEmissaoNFeItem.NumeroItemPedidoCompra = 0
                        oClsFatEmissaoNFeItem.InformacoesAdicionais = ""
                        oClsFatEmissaoNFeItem.CodigoEmissaoDI = -1
                        oClsFatEmissaoNFeItem.CodigoFabricante = ""
                        oClsFatEmissaoNFeItem.CalculoAutomatico = True

                        oClsFatEmissaoNFeItem.InsertProduto()

                        oClsFatEmissaoNFeItem.SituacaoTributariaIPI = 52
                        oClsFatEmissaoNFeItem.TipoCalculoIPI = 1
                        oClsFatEmissaoNFeItem.BaseCalculoIPI = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaIPI = 0
                        oClsFatEmissaoNFeItem.QuantidadeTotalUnidadePadraoIPI = 0
                        oClsFatEmissaoNFeItem.ValorUnidadeIPI = 0
                        oClsFatEmissaoNFeItem.ValorIPI = 0
                        oClsFatEmissaoNFeItem.CodigoEnquadramentoIPI = 340

                        oClsFatEmissaoNFeItem.InsertImpostoIPI()

                        oClsFatEmissaoNFeItem.CodigoSituacaoTributariaPIS = 10
                        oClsFatEmissaoNFeItem.SituacaoTributariaPIS = "OUTRAS OPERAÇÕES DE SAÍDA"
                        oClsFatEmissaoNFeItem.TipoCalculoPIS = 1
                        oClsFatEmissaoNFeItem.BaseCalculoPIS = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemPIS = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaPIS = 0
                        oClsFatEmissaoNFeItem.AliquotaValorPIS = 0
                        oClsFatEmissaoNFeItem.ValorPIS = 0
                        oClsFatEmissaoNFeItem.TipoCalculoPISST = -1
                        oClsFatEmissaoNFeItem.BaseCalculoPISST = 0
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemPISST = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaPISST = 0
                        oClsFatEmissaoNFeItem.AliquotaValorPISST = 0
                        oClsFatEmissaoNFeItem.ValorPISST = 0

                        oClsFatEmissaoNFeItem.InsertImpostoPIS()

                        oClsFatEmissaoNFeItem.CodigoSituacaoTributariaCOFINS = 10
                        oClsFatEmissaoNFeItem.SituacaoTributariaCOFINS = "OUTRAS OPERAÇÕES DE SAÍDA"
                        oClsFatEmissaoNFeItem.TipoCalculoCOFINS = 1
                        oClsFatEmissaoNFeItem.BaseCalculoCOFINS = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINS = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINS = 0
                        oClsFatEmissaoNFeItem.AliquotaValorCOFINS = 0
                        oClsFatEmissaoNFeItem.ValorCOFINS = 0
                        oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
                        oClsFatEmissaoNFeItem.BaseCalculoCOFINSST = 0
                        oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINSST = 0
                        oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINSST = 0
                        oClsFatEmissaoNFeItem.AliquotaValorCOFINSST = 0
                        oClsFatEmissaoNFeItem.ValorCOFINSST = 0

                        oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

                        oClsFatEmissaoNFeItem.BaseCalculoII = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.DespesaAduaneira = 0
                        oClsFatEmissaoNFeItem.AliquotaIOF = 0
                        oClsFatEmissaoNFeItem.AliquotaII = 0

                        oClsFatEmissaoNFeItem.InsertImpostoII()

                        oClsFatEmissaoNFeItem.CodigoOrigemItem = 0
                        oClsFatEmissaoNFeItem.CodigoSituacaoTributariaICMS = 41
                        oClsFatEmissaoNFeItem.SituacaoTributariaICMS = "NÃO TRIBUTADA"
                        oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = -1
                        oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = -1
                        oClsFatEmissaoNFeItem.BaseCalculoICMS = grdListagem.CurrentRow.Cells.Item("valor_unitario").Value * grdListagem.CurrentRow.Cells.Item("quantidade_devolver").Value
                        oClsFatEmissaoNFeItem.AliquotaICMS = -1
                        oClsFatEmissaoNFeItem.ValorICMS = 0
                        oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = -1
                        oClsFatEmissaoNFeItem.IVA = -1
                        oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = -1
                        oClsFatEmissaoNFeItem.BaseCalculoICMSST = -1
                        oClsFatEmissaoNFeItem.AliquotaICMSST = -1
                        oClsFatEmissaoNFeItem.ValorICMSST = 0

                        oClsFatEmissaoNFeItem.InsertImpostoICMS()

                        frmMain.Informacao("Registro(s) inseridos com Sucesso.", gColorInformacaoOK)
                    End If
                Else
                    MsgBox("Primeiro, selecione um destinatário válido", MsgBoxStyle.Exclamation, "Gerar NF-e")
                End If

            Next



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEmissaoNFeDevolucaoMagma_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            btnGerarNFe.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFeDevolucaoMagma, gcInsert)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdListagem, "destinatario", "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            Call LoadCombo(cboNaturezaOperacao, "sp_select_combo_cadastro_basico_natureza_operacao " & goUsuario.iEmpresa)

            dtpDataEntradaInicioFiltro.Value = Now : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now : dtpDataEntradaTerminoFiltro.Checked = False

            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFeDevolucaoMagma)

            'Seta Focu
            txtProdutoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: IMPORTAR :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sCFOP As String = ""
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOP &= IIf(sCFOP = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid de Pedido de Venda
            Call oClsUsrFatEmissaoNFeDevolucaoMagma.LoadGrid(grdListagem, _
                                                             IIf(txtNumeroDocumentoFiltro.Text = "", 0, txtNumeroDocumentoFiltro.Text), _
                                                             IIf(dtpDataEntradaInicioFiltro.Checked = False, "", dtpDataEntradaInicioFiltro.Value), _
                                                             IIf(dtpDataEntradaTerminoFiltro.Checked = False, "", dtpDataEntradaTerminoFiltro.Value), _
                                                             sCFOP, _
                                                             txtProdutoFiltro.Text.Trim)

            'Atualiza Grid
            grdListagem.Refresh()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarNF()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Importa Pedido de Venda
            'Call oClsFatEmissaoImportar.ImportarPedidoVenda(lCodigoEmissaoCapa, _
            '                                                gSelecaoRow(0).Cells("codigo_cliente").Value, _
            '                                                grdListagem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            ''Seta Retorno da Função
            'Validacao = False

            ''Seta Váriavel
            'ReDim gSelecaoRow(0)

            ''Verifica se foi Selecionado algum Pedido de Venda
            'For Each oRow As GridEXRow In grdListagem.GetCheckedRows
            '    If oRow.Cells("quantidade").Value > 0 And IsDBNull(oRow.Cells("codigo_regra_faturamento").Value) = False And CLng(oRow.Cells("codigo_ncm").Text) <> 0 Then
            '        If IsNothing(gSelecaoRow(UBound(gSelecaoRow))) = False Then ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
            '        gSelecaoRow(UBound(gSelecaoRow)) = oRow
            '    End If
            'Next

            'If gSelecaoRow.Count > 0 Then

            '    'Verifica se o Cliente possui Município
            '    If IsDBNull(gSelecaoRow(0).Cells("codigo_pais").Value) Then
            '        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Cliente não está com o País preenchido. Favor corrigir o cadastro.")
            '        Exit Function
            '    End If

            '    'Verifica se o Cliente possui Município
            '    If IsDBNull(gSelecaoRow(0).Cells("codigo_municipio").Value) Then
            '        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Cliente não está com o Município preenchido. Favor corrigir o cadastro.")
            '        Exit Function
            '    End If

            '    'Verifica se o Cliente possui UF
            '    If IsDBNull(gSelecaoRow(0).Cells("uf").Value) Then
            '        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Cliente não está com a UF preenchido. Favor corrigir o cadastro.")
            '        Exit Function
            '    End If


            'Else

            '    'Informa o Usuário que ele precisa informar a Quantidade
            '    frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            'End If

            ''Retorno da Função
            'Return IIf(IsNothing(gSelecaoRow(UBound(gSelecaoRow))) = True, False, True)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region


    

    
    
End Class