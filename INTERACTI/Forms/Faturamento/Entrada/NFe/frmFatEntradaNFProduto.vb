Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class frmFatEntradaNFProduto

#Region "::: VARIAVEIS :::"

    'Váriaveis - Classe
    Private oClsFatEntradaNFeProduto As New clsFrmFatEntradaNFProduto

    'Váriaveis - Dados do Registro
    Private lCodigoEntradaCapa As Long
    Private iCodigoEntradaItem As Integer
    Private iCodigoEntradaItemLote As Integer
    Private iTipoDocumento As Integer
    Private sSituacaoTributariaICMS As String
    Private sSituacaoTributariaIPI As String
    Private sSituacaoTributariaPIS As String
    Private sSituacaoTributariaCOFINS As String

    'Váriaveis - Estoque
    Private bDataFabricacao As Boolean
    Private bDataValidade As Boolean
    Private bItemEstoque As Boolean
    Private bCFOPEstoque As Boolean
    Private bControlaLote As Boolean
    Private bControlaQualidade As Boolean
    Private dFatorConversao As Double
    Private dQuantidadePedido As Double
    Private dQuantidadePendente As Double
    Private dToleranciaQuantidadePercentual As Double
    Private dToleranciaValor As Double
    Private dValorUnitario As Double
    Private iCFOP As Integer
    Private lCodigoItem As Long
    Private sUnidadeMedida As String
    Private iCodigoUnidadeMedida As Integer
    Private iStatusRecebimento As Integer

    'Váriaveis - Integração
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private iCodigoPedidoItemEntrega As Integer
    Private lCodigoOrdemProducao As Long

    'Váriaveis - Emitente
    Private iCodigoParceiroNegocio As Integer
    Private iCodigoRegimeTributario As Integer
    Private sUFDestinatario As String

    'Private oGrid As GridEX

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEntradaCapa() As Long
        Get
            Return lCodigoEntradaCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public Property CodigoEntradaItem() As Integer
        Get
            Return iCodigoEntradaItem
        End Get
        Set(ByVal value As Integer)
            iCodigoEntradaItem = value
        End Set
    End Property

    Public Property TipoDocumento() As Integer
        Get
            Return iTipoDocumento
        End Get
        Set(ByVal value As Integer)
            iTipoDocumento = value
        End Set
    End Property

    Public Property UFDestinatario() As String
        Get
            Return sUFDestinatario
        End Get
        Set(ByVal value As String)
            sUFDestinatario = value
        End Set
    End Property

    Public Property CodigoParceiroNegocio() As Integer
        Get
            Return iCodigoParceiroNegocio
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiroNegocio = value
        End Set
    End Property

    Public Property CodigoRegimeTributario() As Integer
        Get
            Return iCodigoRegimeTributario
        End Get
        Set(ByVal value As Integer)
            iCodigoRegimeTributario = value
        End Set
    End Property

    Public Property CFOP() As Integer
        Get
            Return iCFOP
        End Get
        Set(ByVal value As Integer)
            iCFOP = value
        End Set
    End Property

    Public Property SituacaoTributariaICMS() As String
        Get
            Return sSituacaoTributariaICMS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaICMS = value
        End Set
    End Property

    Public Property SituacaoTributariaIPI() As String
        Get
            Return sSituacaoTributariaIPI
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaIPI = value
        End Set
    End Property

    Public Property SituacaoTributariaPIS() As String
        Get
            Return sSituacaoTributariaPIS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaPIS = value
        End Set
    End Property

    Public Property SituacaoTributariaCOFINS() As String
        Get
            Return sSituacaoTributariaCOFINS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaCOFINS = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmFatEmissaoNFeProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F2
                    Select Case sender.Name
                        Case "cboProduto" : Call DadosProduto()
                    End Select

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCFOP" : Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & iTipoDocumento & ", '" & sUFDestinatario & "', '" & goEmitente.sUF & "'")
                        Case "cboNCM" : Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
                        Case "cboDeposito" : Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboCFOP" : Call btnCadastrarCFOP_Click(btnCadastrarCFOP, System.EventArgs.Empty)
                        Case "cboNCM" : Call btnCadastrarNCM_Click(btnCadastrarNCM, System.EventArgs.Empty)
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                        Case "cboDeposito" : Call btnCadastrarDeposito_Click(btnCadastrarDeposito, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeProduto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo - Item
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", " & IIf(iTipoDocumento = TipoDocumentoFiscal.Entrada, "NULL, NULL, ", "NULL, NULL, ") & TipoItem.produto)

            'Seta Focu
            cboProduto.Focus()

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
            sItemCompraFind = "S"
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

    Private Sub btnCadastrarCFOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCFOP.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCFOP")

            'Carrega Combo
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & iTipoDocumento & ", '" & goEmitente.sUF & "', '" & sUFDestinatario & "'")
            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarNCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarNCM.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadNCM")

            'Carrega Combo
            Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            'Seta Focu
            cboNCM.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
            'Seta Focu
            cboUnidadeMedida.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDeposito.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDeposito")

            'Carrega Combo - Depósito
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarTributos.Click, _
                                                                                                    btnSalvarDados.Click, _
                                                                                                    btnSalvarLote.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva os Dados do Item
                Call SalvarProduto()

                'Insere Imposto - ICMS
                If iCodigoRegimeTributario = CInt(RegimeTributario.LucroPresumido) Or iCodigoRegimeTributario = CInt(RegimeTributario.LucroReal) Then
                    Call SaveItemImpostoICMS()
                Else
                    Call SaveItemImpostoICMSSimples()
                End If
                'Insere Imposto - IPI
                Call SaveItemImpostoIPI()
                'Insere Imposto - PIS
                Call SaveItemImpostoPIS()
                'Insere Imposto - COFINS
                Call SaveItemImpostoCOFINS()
                'Insere Imposto - II
                Call SaveItemImpostoII()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarTributos.Click, _
                                                                                                    btnVoltarDados.Click, _
                                                                                                    btnVoltarLote.Click

        'Fecha Formulário
        Me.Dispose()

    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCFOP.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado Algum CFOP
            If cboCFOP.SelectedIndex = -1 Then

                'Limpa Controle
                cboTipoOperacao.Text = ""
                cboTipoOperacao.DataSource = Nothing

                'Remove Abas
                If tabMain.TabPages.Contains(pagTributos) = True Then tabMain.TabPages.Remove(pagTributos)
                If tabMain.TabPages.Contains(pagEstoque) = True Then tabMain.TabPages.Remove(pagEstoque)

                'Seta Váriavel de Controle de Estoque
                bCFOPEstoque = False

            Else

                'Carrega Combo
                Call LoadCombo(cboTipoOperacao, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada " & cboCFOP.SelectedValue & ", " & goUsuario.iEmpresa)

                'Adiciona Abas
                If tabMain.TabPages.Contains(pagTributos) = False Then tabMain.TabPages.Add(pagTributos)
                If tabMain.TabPages.Contains(pagEstoque) = False Then tabMain.TabPages.Add(pagEstoque)

                'Adiciona / Remove Aba de Imposto de Importação
                If cboCFOP.Text.Substring(0, 1) = "3" Then
                    If tabTributo.TabPages.Contains(pagImpostoImportacao) = False Then tabTributo.TabPages.Add(pagImpostoImportacao)
                Else
                    If tabTributo.TabPages.Contains(pagImpostoImportacao) = True Then tabTributo.TabPages.Remove(pagImpostoImportacao)
                End If

                'Carrega Váriavel - Controle de Estoque
                bCFOPEstoque = LoadDescricao("sp_select_cadastro_basico_estoque_cfop_estoque " & cboCFOP.SelectedValue & ", " & goUsuario.iEmpresa)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboNCM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNCM.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verificando se foi selecionado algum registro
            If cboNCM.SelectedIndex = -1 Then
                'Limpa Controle
                txtAliquotaIPI.Value = 0
            Else
                'Carrega Controle
                Call LoadDadosNCM(cboNCM.SelectedValue, _
                                  txtAliquotaIPI)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaValorTotal() Handles txtValorUnitario.ValueChanged, _
                                            txtValorDesconto.ValueChanged, _
                                            txtQuantidade.ValueChanged

        'Seta Valor Total
        txtValorTotal.Value = ((txtQuantidade.Value * txtValorUnitario.Value) - txtValorDesconto.Value)

        'Carrega Dados do ICMS
        Call cboSituacaoTributariaICMS_SelectedIndexChanged()

    End Sub

#End Region

#Region "::: ICMS :::"

    Private Sub cboSituacaoTributariaICMS_SelectedIndexChanged() Handles cboSituacaoTributariaICMS.SelectedIndexChanged

        Try

            'Desabilita Controles - ICMS
            cboModalidadeBCICMS.Enabled = False
            txtPorcentagemReducaoBCICMS.Enabled = False : txtPorcentagemReducaoBCICMS.Value = 0
            txtBaseCalculoICMS.Enabled = False : txtBaseCalculoICMS.Value = 0
            txtAliquotaICMS.Enabled = False : txtAliquotaICMS.Value = 0
            txtValorICMS.Enabled = False : txtValorICMS.Value = 0
            'Desabilita Controles - ICMS ST
            cboModalidadeBCICMSST.Enabled = False
            txtIVA.Enabled = False : txtIVA.Value = 0
            txtPorcentagemReducaoBCICMSST.Enabled = False : txtPorcentagemReducaoBCICMSST.Value = 0
            txtBaseCalculoICMSST.Enabled = False : txtBaseCalculoICMSST.Value = 0
            txtAliquotaICMSST.Enabled = False : txtAliquotaICMSST.Value = 0

            If cboSituacaoTributariaICMS.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaICMS.SelectedValue

                    Case "00"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = True
                        txtBaseCalculoICMS.Value = txtValorTotal.Value + txtValorFrete.Value + txtValorSeguro.Value + txtOutrasDespesas.Value
                        txtAliquotaICMS.Enabled = True

                    Case "10"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = True
                        txtBaseCalculoICMS.Value = txtValorTotal.Value + txtValorFrete.Value + txtValorSeguro.Value + txtOutrasDespesas.Value
                        txtAliquotaICMS.Enabled = True
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSST.Enabled = True
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtBaseCalculoICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "20"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = True
                        txtBaseCalculoICMS.Value = txtValorTotal.Value + txtValorFrete.Value + txtValorSeguro.Value + txtOutrasDespesas.Value
                        txtAliquotaICMS.Enabled = True

                    Case "30"
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSST.Enabled = True
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True

                    Case "40", "41", "50"

                    Case "51"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True

                    Case "60"
                        'Habilita Controles - ICMS ST                    
                        txtBaseCalculoICMSSTRetido.Enabled = True
                        txtValorICMSSTRetido.Enabled = True

                    Case "70"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtBaseCalculoICMS.Value = txtValorTotal.Value + txtValorFrete.Value + txtValorSeguro.Value + txtOutrasDespesas.Value
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSST.Enabled = True
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtBaseCalculoICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "90"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = True
                        txtBaseCalculoICMS.Value = txtValorTotal.Value + txtValorFrete.Value + txtValorSeguro.Value + txtOutrasDespesas.Value
                        txtAliquotaICMS.Enabled = True
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSST.Enabled = True
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtBaseCalculoICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboModalidadeBCICMSST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModalidadeBCICMSST.SelectedIndexChanged

        Try

            'Desabilita Controle
            txtIVA.Enabled = False

            Select Case cboModalidadeBCICMSST.SelectedValue

                Case ModalidadeDeterminacaoBCICMSST.MargemValorAgregado
                    txtIVA.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaValorICMS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBaseCalculoICMS.ValueChanged, _
                                                                                                     txtAliquotaICMS.ValueChanged, _
                                                                                                     txtPorcentagemReducaoBCICMS.ValueChanged

        Select Case sender.Name

            Case "txtPorcentagemReducaoBCICMS"
                'Seta Valor ICMS
                txtBaseCalculoICMS.Value = ((txtValorTotal.Value * txtPorcentagemReducaoBCICMS.Value) / 100)

            Case "txtAliquotaICMS", "txtBaseCalculoICMS"
                'Seta Valor ICMS
                txtValorICMS.Value = ((txtBaseCalculoICMS.Value * txtAliquotaICMS.Value) / 100)

        End Select

    End Sub

#End Region

#Region "::: ICMS SIMPLES :::"

    Private Sub cboSituacaoTributariaICMSSimples_SelectedIndexChanged() Handles cboSituacaoTributariaICMSSimples.SelectedIndexChanged

        Try

            'Desabilita Controles - ST ICMS
            txtAliquotaCalculoCreditoICMSSimples.Enabled = False : txtAliquotaCalculoCreditoICMSSimples.Value = 0
            txtCreditoICMSAproveitadoSimples.Enabled = False : txtCreditoICMSAproveitadoSimples.Value = 0
            'Desabilita Controles - ICMS
            cboModalidadeBCICMSSimples.Enabled = False : cboModalidadeBCICMSSimples.SelectedIndex = -1
            txtPorcentagemReducaoBCICMSSimples.Enabled = False : txtPorcentagemReducaoBCICMSSimples.Value = 0
            txtBaseCalculoICMSSimples.Enabled = False : txtBaseCalculoICMSSimples.Value = 0
            txtAliquotaICMSSimples.Enabled = False : txtAliquotaICMSSimples.Value = 0
            txtValorICMSSimples.Enabled = False : txtValorICMSSimples.Value = 0
            'Desabilita Controles - ICMS ST
            cboModalidadeBCICMSSTSimples.Enabled = False : cboModalidadeBCICMSSTSimples.SelectedIndex = -1
            txtIVASimples.Enabled = False : txtIVASimples.Value = 0
            txtPorcentagemReducaoBCICMSSTSimples.Enabled = False : txtPorcentagemReducaoBCICMSSTSimples.Value = 0
            txtBaseCalculoICMSSTSimples.Enabled = False : txtBaseCalculoICMSSTSimples.Value = 0
            txtAliquotaICMSSTSimples.Enabled = False : txtAliquotaICMSSTSimples.Value = 0
            'Desabilita Controles - ICMS ST Anterior
            txtBaseCalculoICMSSTRetidoSimples.Enabled = False : txtBaseCalculoICMSSTRetidoSimples.Value = 0
            txtValorICMSSTRetidoSimples.Enabled = False : txtValorICMSSTRetidoSimples.Value = 0

            If cboSituacaoTributariaICMSSimples.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaICMSSimples.SelectedValue

                    Case "101"
                        'Habilita Controles - ICMS
                        txtAliquotaCalculoCreditoICMSSimples.Enabled = True
                        txtCreditoICMSAproveitadoSimples.Enabled = True

                    Case "201"
                        'Habilita Controles - ICMS
                        txtAliquotaCalculoCreditoICMSSimples.Enabled = True
                        txtCreditoICMSAproveitadoSimples.Enabled = True
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSSTSimples.Enabled = True
                        txtPorcentagemReducaoBCICMSSTSimples.Enabled = True
                        txtIVASimples.Enabled = True
                        txtBaseCalculoICMSSTSimples.Enabled = True
                        txtAliquotaICMSSTSimples.Enabled = True

                    Case "202", "203"
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSSTSimples.Enabled = True
                        txtPorcentagemReducaoBCICMSSTSimples.Enabled = True
                        txtIVASimples.Enabled = True
                        txtBaseCalculoICMSSTSimples.Enabled = True
                        txtAliquotaICMSSTSimples.Enabled = True

                    Case "500"
                        'Habilita Controles - ICMS ST Retido
                        txtBaseCalculoICMSSTRetidoSimples.Enabled = True
                        txtValorICMSSTRetidoSimples.Enabled = True

                    Case "900"
                        'Habilita Controles - ICMS
                        txtAliquotaCalculoCreditoICMSSimples.Enabled = True
                        txtCreditoICMSAproveitadoSimples.Enabled = True
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMSSimples.Enabled = True
                        txtPorcentagemReducaoBCICMSSimples.Enabled = True
                        txtBaseCalculoICMSSimples.Enabled = True
                        txtBaseCalculoICMSSimples.Value = txtValorTotal.Value
                        txtAliquotaICMSSimples.Enabled = True
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSSTSimples.Enabled = True
                        txtPorcentagemReducaoBCICMSSTSimples.Enabled = True
                        txtIVASimples.Enabled = True
                        txtBaseCalculoICMSSTSimples.Enabled = True
                        txtAliquotaICMSSTSimples.Enabled = True

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboModalidadeBCICMSSTSimples_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModalidadeBCICMSSTSimples.SelectedIndexChanged

        Try

            'Desabilita Controle
            txtIVASimples.Enabled = False

            Select Case cboModalidadeBCICMSSTSimples.SelectedValue

                Case ModalidadeDeterminacaoBCICMSST.MargemValorAgregado
                    txtIVASimples.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaValorICMSSimples(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBaseCalculoICMSSimples.ValueChanged, _
                                                                                                            txtAliquotaICMSSimples.ValueChanged, _
                                                                                                            txtPorcentagemReducaoBCICMSSimples.ValueChanged

        Select Case sender.Name

            Case "txtPorcentagemReducaoBCICMSSimples"
                'Seta Valor ICMS
                txtBaseCalculoICMSSimples.Value = ((txtValorTotal.Value * txtPorcentagemReducaoBCICMSSimples.Value) / 100)

            Case "txtAliquotaICMSSimples", "txtBaseCalculoICMSSimples"
                'Seta Valor ICMS
                txtValorICMSSimples.Value = ((txtBaseCalculoICMSSimples.Value * txtAliquotaICMSSimples.Value) / 100)

        End Select

    End Sub

#End Region

#Region "::: IPI :::"

    Private Sub cboSituacaoTributariaIPI_SelectedIndexChanged() Handles cboSituacaoTributariaIPI.SelectedIndexChanged

        Try

            'Desabilita Controles
            cboTipoCalculoIPI.Enabled = False : cboTipoCalculoIPI.SelectedIndex = -1

            If cboSituacaoTributariaIPI.SelectedIndex <> -1 Then

                'Verifica Qual Situação Tributária foi Selecionada
                Select Case cboSituacaoTributariaIPI.SelectedValue

                    Case modDeclaration.SituacaoTributariaIPI._00, _
                         modDeclaration.SituacaoTributariaIPI._49, _
                         modDeclaration.SituacaoTributariaIPI._50, _
                         modDeclaration.SituacaoTributariaIPI._99
                        'Habilita Controle
                        cboTipoCalculoIPI.Enabled = True

                    Case modDeclaration.SituacaoTributariaIPI._02, _
                         modDeclaration.SituacaoTributariaIPI._03, _
                         modDeclaration.SituacaoTributariaIPI._04, _
                         modDeclaration.SituacaoTributariaIPI._05, _
                         modDeclaration.SituacaoTributariaIPI._51, _
                         modDeclaration.SituacaoTributariaIPI._52, _
                         modDeclaration.SituacaoTributariaIPI._53, _
                         modDeclaration.SituacaoTributariaIPI._54, _
                         modDeclaration.SituacaoTributariaIPI._55

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTipoCalculoIPI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCalculoIPI.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtBaseCalculoIPI.Enabled = False : txtBaseCalculoIPI.Value = 0
            txtAliquotaIPI.Enabled = False : txtAliquotaIPI.Value = 0
            txtQuantidadeIPI.Enabled = False : txtQuantidadeIPI.Value = 0
            txtValorUnidadeIPI.Enabled = False : txtValorIPI.Value = 0

            'Verifica Qual Tipo de Cálculo foi Selecionado
            Select Case cboTipoCalculoIPI.SelectedValue

                Case modDeclaration.TipoCalculoImposto.Percentual
                    'Habilita Controles
                    txtBaseCalculoIPI.Enabled = True
                    txtBaseCalculoIPI.Value = txtValorTotal.Value
                    txtAliquotaIPI.Enabled = True

                Case modDeclaration.TipoCalculoImposto.Valor
                    'Habilita Controles
                    txtQuantidadeIPI.Enabled = True
                    txtValorUnidadeIPI.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaValorIPI(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBaseCalculoIPI.ValueChanged, _
                                                                                                    txtAliquotaIPI.ValueChanged, _
                                                                                                    txtQuantidadeIPI.ValueChanged, _
                                                                                                    txtValorUnidadeIPI.ValueChanged

        Select Case sender.Name

            Case "txtBaseCalculoIPI", "txtAliquotaIPI"
                'Seta Valor IPI
                txtValorIPI.Value = ((txtAliquotaIPI.Value * txtBaseCalculoIPI.Value) / 100)

            Case "txtQuantidadeIPI", "txtValorUnidadeIPI"
                'Seta Valor IPI
                txtValorIPI.Value = txtQuantidadeIPI.Value * txtValorUnidadeIPI.Value

        End Select

    End Sub

#End Region

#Region "::: PIS :::"

    Private Sub cboSituacaoTributariaPIS_SelectedIndexChanged() Handles cboSituacaoTributariaPIS.SelectedIndexChanged

        Try

            'Desabilita Controles            
            cboTipoCalculoPIS.Enabled = False
            txtBaseCalculoPIS.Enabled = False : txtBaseCalculoPIS.Value = 0
            txtAliquotaPercentualPIS.Enabled = False : txtAliquotaPercentualPIS.Value = 0
            txtAliquotaValorPIS.Enabled = False : txtAliquotaValorPIS.Value = 0
            txtQuantidadeVendidaPIS.Enabled = False : txtQuantidadeVendidaPIS.Value = 0

            'Verifica se foi Selecionado algum Registro
            If cboSituacaoTributariaPIS.SelectedIndex <> -1 Then

                'Carrega Dados do Emitente
                Call LoadDadosEmitente()

                Select Case cboSituacaoTributariaPIS.SelectedValue

                    Case modDeclaration.SituacaoTributariaPIS._01, _
                         modDeclaration.SituacaoTributariaPIS._02
                        'Habilita Controles
                        txtBaseCalculoPIS.Enabled = True : txtBaseCalculoPIS.Value = txtValorTotal.Value
                        txtAliquotaPercentualPIS.Enabled = True : txtAliquotaPercentualPIS.Value = goEmitente.dAliquotaPIS

                    Case modDeclaration.SituacaoTributariaPIS._03
                        'Habilita Controles
                        txtAliquotaValorPIS.Enabled = True
                        txtQuantidadeVendidaPIS.Enabled = True

                    Case modDeclaration.SituacaoTributariaPIS._04, _
                         modDeclaration.SituacaoTributariaPIS._06, _
                         modDeclaration.SituacaoTributariaPIS._07, _
                         modDeclaration.SituacaoTributariaPIS._08, _
                         modDeclaration.SituacaoTributariaPIS._09

                    Case modDeclaration.SituacaoTributariaPIS._99
                        cboTipoCalculoPIS.Enabled = True

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTipoCalculoPIS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCalculoPIS.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtBaseCalculoPIS.Enabled = False : txtBaseCalculoPIS.Value = 0
            txtAliquotaPercentualPIS.Enabled = False : txtAliquotaPercentualPIS.Value = 0
            txtAliquotaValorPIS.Enabled = False : txtAliquotaValorPIS.Value = 0
            txtQuantidadeVendidaPIS.Enabled = False : txtQuantidadeVendidaPIS.Value = 0

            'Verifica Qual Tipo de Cálculo foi Selecionado
            Select Case cboTipoCalculoPIS.SelectedValue

                Case modDeclaration.TipoCalculoImposto.Percentual
                    'Habilita Controles
                    txtBaseCalculoPIS.Enabled = True : txtBaseCalculoPIS.Value = txtValorTotal.Value
                    txtAliquotaPercentualPIS.Enabled = True : txtAliquotaPercentualPIS.Value = goEmitente.dAliquotaPIS

                Case modDeclaration.TipoCalculoImposto.Valor
                    'Habilita Controles
                    txtAliquotaValorPIS.Enabled = True
                    txtQuantidadeVendidaPIS.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaValorPIS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBaseCalculoPIS.ValueChanged, _
                                                                                                    txtAliquotaPercentualPIS.ValueChanged, _
                                                                                                    txtQuantidadeVendidaPIS.ValueChanged, _
                                                                                                    txtAliquotaValorPIS.ValueChanged

        Select Case sender.Name

            Case "txtBaseCalculoPIS", "txtAliquotaPercentualPIS"
                'Seta Valor PIS
                txtValorPIS.Value = ((txtBaseCalculoPIS.Value * txtAliquotaPercentualPIS.Value) / 100)

            Case "txtQuantidadeVendidaPIS", "txtAliquotaValorPIS"
                'Seta Valor PIS
                txtValorPIS.Value = txtQuantidadeVendidaPIS.Value * txtAliquotaValorPIS.Value

        End Select

    End Sub

#End Region

#Region "::: COFINS :::"

    Private Sub cboSituacaoTributariaCOFINS_SelectedIndexChanged() Handles cboSituacaoTributariaCOFINS.SelectedIndexChanged

        Try

            'Desabilita Controles            
            cboTipoCalculoCOFINS.Enabled = False
            txtBaseCalculoCOFINS.Enabled = False : txtBaseCalculoCOFINS.Value = 0
            txtAliquotaPercentualCOFINS.Enabled = False : txtAliquotaPercentualCOFINS.Value = 0
            txtAliquotaValorCOFINS.Enabled = False : txtAliquotaValorCOFINS.Value = 0
            txtQuantidadeVendidaCOFINS.Enabled = False : txtQuantidadeVendidaCOFINS.Value = 0

            'Verifica se foi Selecionado algum Registro
            If cboSituacaoTributariaCOFINS.SelectedIndex <> -1 Then

                'Carrega Dados do Emitente
                Call LoadDadosEmitente()

                Select Case cboSituacaoTributariaCOFINS.SelectedValue

                    Case modDeclaration.SituacaoTributariaCOFINS._01, _
                         modDeclaration.SituacaoTributariaCOFINS._02
                        'Habilita Controles
                        txtBaseCalculoCOFINS.Enabled = True : txtBaseCalculoCOFINS.Value = txtValorTotal.Value
                        txtAliquotaPercentualCOFINS.Enabled = True : txtAliquotaPercentualCOFINS.Value = goEmitente.dAliquotaCOFINS

                    Case modDeclaration.SituacaoTributariaCOFINS._03
                        'Habilita Controles
                        txtAliquotaValorCOFINS.Enabled = True
                        txtQuantidadeVendidaCOFINS.Enabled = True

                    Case modDeclaration.SituacaoTributariaCOFINS._04, _
                         modDeclaration.SituacaoTributariaCOFINS._06, _
                         modDeclaration.SituacaoTributariaCOFINS._07, _
                         modDeclaration.SituacaoTributariaCOFINS._08, _
                         modDeclaration.SituacaoTributariaCOFINS._09

                    Case modDeclaration.SituacaoTributariaCOFINS._99
                        cboTipoCalculoCOFINS.Enabled = True

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTipoCalculoCOFINS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCalculoCOFINS.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtBaseCalculoCOFINS.Enabled = False : txtBaseCalculoCOFINS.Value = 0
            txtAliquotaPercentualCOFINS.Enabled = False : txtAliquotaPercentualCOFINS.Value = 0
            txtAliquotaValorCOFINS.Enabled = False : txtAliquotaValorCOFINS.Value = 0
            txtQuantidadeVendidaCOFINS.Enabled = False : txtQuantidadeVendidaCOFINS.Value = 0

            'Verifica Qual Tipo de Cálculo foi Selecionado
            Select Case cboTipoCalculoCOFINS.SelectedValue

                Case modDeclaration.TipoCalculoImposto.Percentual
                    'Habilita Controles
                    txtBaseCalculoCOFINS.Enabled = True : txtBaseCalculoCOFINS.Value = txtValorTotal.Value
                    txtAliquotaPercentualCOFINS.Enabled = True : txtAliquotaPercentualCOFINS.Value = goEmitente.dAliquotaCOFINS

                Case modDeclaration.TipoCalculoImposto.Valor
                    'Habilita Controles
                    txtAliquotaValorCOFINS.Enabled = True
                    txtQuantidadeVendidaCOFINS.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaValorCOFINS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBaseCalculoCOFINS.ValueChanged, _
                                                                                                       txtAliquotaPercentualCOFINS.ValueChanged, _
                                                                                                       txtQuantidadeVendidaCOFINS.ValueChanged, _
                                                                                                       txtAliquotaValorCOFINS.ValueChanged

        Select Case sender.Name

            Case "txtBaseCalculoCOFINS", "txtAliquotaPercentualCOFINS"
                'Seta Valor COFINS
                txtValorCOFINS.Value = ((txtBaseCalculoCOFINS.Value * txtAliquotaPercentualCOFINS.Value) / 100)

            Case "txtQuantidadeVendidaCOFINS", "txtAliquotaValorCOFINS"
                'Seta Valor COFINS
                txtValorCOFINS.Value = txtQuantidadeVendidaCOFINS.Value * txtAliquotaValorCOFINS.Value

        End Select

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub btnConfigurarGridEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridEstoque.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEstoque
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEstoque, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaEstoque.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            Call LoadCombo(cboUnidadeMedidaEstoque, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
            'Seta Focu
            cboUnidadeMedidaEstoque.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluirEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEstoque.Click

        Try

            'Deleta Registros
            Call DeleteEstoque()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserirEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEstoque.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados dos Produtos
            If ValidacaoDadosGerais() = False Then
                Exit Sub
            End If

            'Salva Dados do Produto
            Call SalvarProduto()

            'Valida Dados do Formulário
            If ValidacaoEstoque() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirEstoque.Tag) Then

                    'Atualiza Registro na tb_fat_entrada_item_lote
                    Call oClsFatEntradaNFeProduto.UpdateEstoque(cboTipoOperacao.SelectedValue, _
                                                                cboNumeroDocumento.Text.Trim, _
                                                                lCodigoPedido, _
                                                                iCodigoPedidoItem, _
                                                                iCodigoPedidoItemEntrega, _
                                                                lCodigoEmissaoCapa, _
                                                                iCodigoEmissaoItem, _
                                                                lCodigoOrdemProducao, _
                                                                lCodigoItem, _
                                                                txtQuantidadeLote.Value, _
                                                                cboUnidadeMedidaEstoque.SelectedValue, _
                                                                txtQuantidadeEstoque.Value, _
                                                                IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue), _
                                                                txtLote.Text.Trim, _
                                                                IIf(dtpDataFabricacao.Enabled = False, "", dtpDataFabricacao.Value), _
                                                                IIf(dtpDataValidade.Enabled = False, "", dtpDataValidade.Value), _
                                                                txtOCCapa.Text.Trim, _
                                                                txtOCLinha.Text.Trim, _
                                                                bControlaQualidade, _
                                                                lCodigoEntradaCapa, _
                                                                iCodigoEntradaItem, _
                                                                iCodigoEntradaItemLote, _
                                                                iStatusRecebimento)

                Else

                    'Insere Registro na tb_fat_entrada_item_lote
                    Call oClsFatEntradaNFeProduto.InsertEstoque(cboTipoOperacao.SelectedValue, _
                                                                cboNumeroDocumento.Text.Trim, _
                                                                lCodigoPedido, _
                                                                iCodigoPedidoItem, _
                                                                iCodigoPedidoItemEntrega, _
                                                                lCodigoEmissaoCapa, _
                                                                iCodigoEmissaoItem, _
                                                                lCodigoOrdemProducao, _
                                                                lCodigoItem, _
                                                                txtQuantidadeLote.Value, _
                                                                cboUnidadeMedidaEstoque.SelectedValue, _
                                                                txtQuantidadeEstoque.Value, _
                                                                IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue), _
                                                                txtLote.Text.Trim, _
                                                                IIf(dtpDataFabricacao.Enabled = False, "", dtpDataFabricacao.Value), _
                                                                IIf(dtpDataValidade.Enabled = False, "", dtpDataValidade.Value), _
                                                                txtOCCapa.Text.Trim, _
                                                                txtOCLinha.Text.Trim, _
                                                                bControlaQualidade, _
                                                                lCodigoEntradaCapa, _
                                                                iCodigoEntradaItem, _
                                                                iStatusRecebimento)

                End If

                'Carrega Grid - Estoque
                Call oClsFatEntradaNFeProduto.LoadGridEstoque(lCodigoEntradaCapa, _
                                                              iCodigoEntradaItem, _
                                                              grdEstoque)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoEstoque()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdEstoque.FrozenColumns = 2
            Else
                grdEstoque.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

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
            txtQuantidadeLote.Value = 0
            cboUnidadeMedidaEstoque.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            txtOCCapa.Text = ""
            txtOCLinha.Text = ""

            'Desabilita / Oculta Controles
            cboNumeroDocumento.Enabled = False
            cboProduto.Enabled = False
            lblQuantidadeDocumento.Visible = False
            txtQuantidadeDocumento.Visible = False
            btnAtualizarPedidoCompra.Visible = False
            btnCadastrarProduto.Enabled = False
            btnProcurarProduto.Enabled = False
            txtQuantidadeDocumento.Enabled = False
            txtQuantidadeLote.Enabled = False
            cboUnidadeMedidaEstoque.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            txtOCCapa.Enabled = False
            txtOCLinha.Enabled = False

            'Verifica o Tipo de Operação Selecionada
            Select Case cboTipoOperacao.SelectedValue

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros)
                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False) : cboProduto.Enabled = True
                    'Verifica Direito - Cadastrar Produto
                    btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                    btnProcurarProduto.Enabled = True

                Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                    'Carrega Combo de Pedido de Compra
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_pedido_compra " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, True)
                    'Habilita Controle
                    cboNumeroDocumento.Enabled = True
                    'Seta Label
                    lblNumeroDocumento.Text = "Pedido de Compra:"
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    btnAtualizarPedidoCompra.Visible = VerificaDireito(Formulario.FaturamentoEntradaNF, gcAdministrator)
                    lblQuantidadeDocumento.Text = "Qtde. Pedido:"

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
            txtQuantidadeLote.Value = 0
            cboUnidadeMedidaEstoque.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            txtOCCapa.Text = ""
            txtOCLinha.Text = ""

            'Desabilita / Oculta Controles
            btnCadastrarProduto.Enabled = False
            btnProcurarProduto.Enabled = False
            txtQuantidadeLote.Enabled = False
            cboUnidadeMedidaEstoque.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            txtOCCapa.Enabled = False
            txtOCLinha.Enabled = False

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

            'Desabilita Layout
            grpEstoque.SuspendLayout()

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

            'Limpa Controles
            txtQuantidadeDocumento.Value = 0
            txtQuantidadeLote.Value = 0
            cboUnidadeMedidaEstoque.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            txtOCCapa.Text = ""
            txtOCLinha.Text = ""

            'Seta Propriedade dos Controles
            txtQuantidadeDocumento.Enabled = False
            txtQuantidadeLote.Enabled = False
            cboUnidadeMedidaEstoque.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            txtOCCapa.Enabled = False
            txtOCLinha.Enabled = False

            'Verifica se foi Selecionado Algum Registro
            If cboProduto.SelectedIndex > -1 Then

                'Váriaveis Locais
                Dim sOperacao As String = IIf(IsNumeric(btnInserirEstoque.Tag), "E", "I")

                Select Case cboTipoOperacao.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros)
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
                Call oClsFatEntradaNFeProduto.LoadDadosProduto(cboTipoOperacao.SelectedValue, _
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
                                                               dToleranciaValor)

                'Habilita Controle                                
                txtQuantidadeLote.Enabled = True
                txtQuantidadeDocumento.Value = dQuantidadePendente
                txtQuantidadeDocumento.FormatString = "#,#0.0000 " & sUnidadeMedida

                'Verifica se Controla Estoque do Item
                If bItemEstoque = False Or bCFOPEstoque = False Then Exit Sub

                cboUnidadeMedidaEstoque.Enabled = True : btnCadastrarUnidadeMedidaEstoque.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
                txtFatorConversao.Enabled = True
                txtQuantidadeEstoque.Enabled = True
                cboDeposito.Enabled = True : btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)

                If grdEstoque.GetDataRows.Count > 0 Then
                    txtQuantidadeLote.Value = txtQuantidade.Value - grdEstoque.GetTotalRow.Cells("quantidade").Value
                Else
                    txtQuantidadeLote.Value = txtQuantidadeDocumento.Value
                End If

                If iCodigoUnidadeMedida <> -1 Then cboUnidadeMedidaEstoque.SelectedValue = iCodigoUnidadeMedida
                txtFatorConversao.Value = IIf(dFatorConversao > 0, dFatorConversao, 1)
                txtQuantidadeEstoque.Value = txtQuantidadeLote.Value * txtFatorConversao.Value

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

                    'Verifica se é Remessa de Terceiros
                    If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros) Then
                        txtOCCapa.Enabled = True
                        txtOCLinha.Enabled = True
                    End If

                    'Carrega Combo - Depósito 
                    Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_cfop " & goUsuario.iEmpresa & ", " & cboCFOP.SelectedValue & ", " & cboTipoOperacao.SelectedValue, True)

                End If

            End If

            'Habilita Layout
            grpEstoque.ResumeLayout()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub QuantidadeEstoque(sender As Object, e As EventArgs) Handles txtFatorConversao.LostFocus, _
                                                                            txtQuantidadeEstoque.LostFocus, _
                                                                            txtQuantidadeLote.LostFocus

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Select Case sender.Name

                Case "txtQuantidadeLote" : txtQuantidadeEstoque.Value = IIf(IsNumeric(txtQuantidadeLote.Value), txtQuantidadeLote.Value, 0) * IIf(IsNumeric(txtFatorConversao.Value), txtFatorConversao.Value, 0)
                Case "txtFatorConversao" : txtQuantidadeEstoque.Value = IIf(IsNumeric(txtQuantidadeLote.Value), txtQuantidadeLote.Value, 0) * IIf(IsNumeric(txtFatorConversao.Value), txtFatorConversao.Value, 0)
                Case "txtQuantidadeEstoque" : If IsNumeric(txtQuantidadeLote.Value) Then txtFatorConversao.Value = IIf(IsNumeric(txtQuantidadeEstoque.Value), txtQuantidadeEstoque.Value, 0) / txtQuantidadeLote.Value Else txtFatorConversao.Value = 0

            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEstoque.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdEstoque.CurrentRow) Then Exit Sub

            'Verifica qual Célula foi Pressionada
            Select Case grdEstoque.CurrentColumn.Key
                Case "editar" : Call EditarEstoque()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEstoque.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEstoque.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque, _
                                     Formulario.FaturamentoEntradaNF)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdEstoque)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdEstoque.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEstoque.Name, _
                                          Formulario.FaturamentoEntradaNF, _
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

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeProduto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Verifica Direito dos Controles
            btnCadastrarCFOP.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcInsert)
            btnCadastrarNCM.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcInsert)
            btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

            'Carrega Combo - Produto
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & iTipoDocumento & ", '" & goEmitente.sUF & "', '" & sUFDestinatario & "'")
            Call LoadComboSimNao(cboIncideValorTotalNF)
            Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
            'Carrega Combo - ICMS
            Dim oComboBox(1) As UIComboBox
            Call LoadCombo(cboSituacaoTributariaICMS, "sp_select_combo_static_situacao_tributaria_icms")
            oComboBox(0) = cboModalidadeBCICMS : oComboBox(1) = cboModalidadeBCICMSSimples
            Call LoadCombo(oComboBox, "sp_select_combo_static_modalidade_base_calculo_icms")
            Call LoadCombo(cboSituacaoTributariaICMSSimples, "sp_select_combo_static_situacao_tributaria_icms_simples")
            oComboBox(0) = cboModalidadeBCICMSST : oComboBox(1) = cboModalidadeBCICMSSTSimples
            Call LoadCombo(oComboBox, "sp_select_combo_static_modalidade_base_calculo_icms_st")
            oComboBox(0) = cboOrigem : oComboBox(1) = cboOrigemSimples
            Call LoadCombo(oComboBox, "sp_select_combo_static_origem_item")
            'Carrega Combo - IPI
            Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Entrada))
            ReDim oComboBox(2) : oComboBox(0) = cboTipoCalculoIPI : oComboBox(1) = cboTipoCalculoCOFINS : oComboBox(2) = cboTipoCalculoPIS
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_calculo_imposto")
            'Carrega Combo - PIS
            Call LoadCombo(cboSituacaoTributariaPIS, "sp_select_combo_static_situacao_tributaria_pis")
            'Carrega Combo - COFINS
            Call LoadCombo(cboSituacaoTributariaCOFINS, "sp_select_combo_static_situacao_tributaria_cofins")
            'Carrega Combo - Estoque
            Call LoadCombo(cboUnidadeMedidaEstoque, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdEstoque)
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdEstoque, Formulario.FaturamentoEntradaNF)

            'Oculta Abas
            tabMain.TabPages.Remove(pagTributos)
            tabMain.TabPages.Remove(pagEstoque)

            'Verifica o Tipo de Operação
            If iCodigoEntradaItem <> -1 Then

                'Carrega Grid de Estoque
                Call EditarProduto()

            Else

                'Carrega os dados do Item Inserido Anteriormente
                If iCFOP > 0 Then cboCFOP.SelectedValue = iCFOP
                If iCodigoRegimeTributario = CInt(RegimeTributario.LucroPresumido) Or iCodigoRegimeTributario = CInt(RegimeTributario.LucroReal) Then
                    If sSituacaoTributariaICMS <> "" Then cboSituacaoTributariaICMS.SelectedValue = sSituacaoTributariaICMS
                Else
                    If sSituacaoTributariaICMS <> "" Then cboSituacaoTributariaICMSSimples.SelectedValue = sSituacaoTributariaICMS
                End If
                If sSituacaoTributariaIPI <> "" Then cboSituacaoTributariaIPI.SelectedValue = sSituacaoTributariaIPI
                If sSituacaoTributariaPIS <> "" Then cboSituacaoTributariaPIS.SelectedValue = sSituacaoTributariaPIS
                If sSituacaoTributariaCOFINS <> "" Then cboSituacaoTributariaCOFINS.SelectedValue = sSituacaoTributariaCOFINS

            End If

            If iCodigoRegimeTributario = CInt(RegimeTributario.LucroPresumido) Or iCodigoRegimeTributario = CInt(RegimeTributario.LucroReal) Then
                tabTributo.TabPages.Remove(pagICMSSimples)
            Else
                tabTributo.TabPages.Remove(pagICMS)
            End If

            'Seta Focu
            cboProduto.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

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

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Carrega Dados do Produto
            Call oClsFatEntradaNFeProduto.LoadProduto(lCodigoEntradaCapa, _
                                                      iCodigoEntradaItem, _
                                                      cboCFOP, _
                                                      txtCodigoProdutoFornecedor, _
                                                      txtDescricao, _
                                                      txtCodigoEAN, _
                                                      cboIncideValorTotalNF, _
                                                      cboNCM, _
                                                      txtQuantidade, _
                                                      cboUnidadeMedida, _
                                                      txtValorUnitario, _
                                                      txtValorFrete, _
                                                      txtValorSeguro, _
                                                      txtOutrasDespesas, _
                                                      txtValorDesconto, _
                                                      txtValorTotal, _
                                                      txtInformacoesAdicionais, _
                                                      cboSituacaoTributariaICMS, _
                                                      cboOrigem, _
                                                      cboModalidadeBCICMS, _
                                                      txtPorcentagemReducaoBCICMS, _
                                                      txtBaseCalculoICMS, _
                                                      txtAliquotaICMS, _
                                                      txtValorICMS, _
                                                      cboModalidadeBCICMSST, _
                                                      txtIVA, _
                                                      txtPorcentagemReducaoBCICMSST, _
                                                      txtBaseCalculoICMSST, _
                                                      txtAliquotaICMSST, _
                                                      txtBaseCalculoICMSSTRetido, _
                                                      txtValorICMSSTRetido, _
                                                      cboSituacaoTributariaICMSSimples, _
                                                      cboOrigemSimples, _
                                                      txtAliquotaCalculoCreditoICMSSimples, _
                                                      txtCreditoICMSAproveitadoSimples, _
                                                      cboModalidadeBCICMSSimples, _
                                                      txtPorcentagemReducaoBCICMSSimples, _
                                                      txtBaseCalculoICMSSimples, _
                                                      txtAliquotaICMSSimples, _
                                                      txtValorICMSSimples, _
                                                      cboModalidadeBCICMSSTSimples, _
                                                      txtIVASimples, _
                                                      txtPorcentagemReducaoBCICMSSTSimples, _
                                                      txtBaseCalculoICMSSTSimples, _
                                                      txtAliquotaICMSSTSimples, _
                                                      txtBaseCalculoICMSSTRetidoSimples, _
                                                      txtValorICMSSTRetidoSimples, _
                                                      cboSituacaoTributariaIPI, _
                                                      cboTipoCalculoIPI, _
                                                      txtBaseCalculoIPI, _
                                                      txtAliquotaIPI, _
                                                      txtQuantidadeIPI, _
                                                      txtValorUnidadeIPI, _
                                                      txtValorIPI, _
                                                      cboSituacaoTributariaPIS, _
                                                      cboTipoCalculoPIS, _
                                                      txtBaseCalculoPIS, _
                                                      txtAliquotaPercentualPIS, _
                                                      txtAliquotaValorPIS, _
                                                      txtQuantidadeVendidaPIS, _
                                                      txtValorPIS, _
                                                      cboSituacaoTributariaCOFINS, _
                                                      cboTipoCalculoCOFINS, _
                                                      txtBaseCalculoCOFINS, _
                                                      txtAliquotaPercentualCOFINS, _
                                                      txtAliquotaValorCOFINS, _
                                                      txtQuantidadeVendidaCOFINS, _
                                                      txtValorCOFINS, _
                                                      txtBaseCalculoII, _
                                                      txtDespesaAduaneiraII, _
                                                      txtValorIOF, _
                                                      txtValorII)

            'Carrega Grid - Estoque
            Call oClsFatEntradaNFeProduto.LoadGridEstoque(lCodigoEntradaCapa, _
                                                          iCodigoEntradaItem, _
                                                          grdEstoque)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCFOP.Text = ""
            txtCodigoProdutoFornecedor.Text = ""
            txtDescricao.Text = ""
            txtCodigoEAN.Text = ""
            cboIncideValorTotalNF.SelectedValue = False
            cboNCM.SelectedIndex = -1
            txtQuantidade.Value = 0
            cboUnidadeMedida.SelectedIndex = -1
            txtValorUnitario.Value = 0
            txtValorFrete.Value = 0
            txtValorSeguro.Value = 0
            txtOutrasDespesas.Value = 0
            txtValorDesconto.Value = 0
            txtValorTotal.Value = 0
            txtInformacoesAdicionais.Text = ""

            'Limpa Formulário - Estoque
            cboTipoOperacao.SelectedIndex = -1
            cboNumeroDocumento.SelectedIndex = -1
            cboProduto.SelectedIndex = -1
            txtQuantidadeDocumento.Value = 0
            txtQuantidadeLote.Value = 0
            cboUnidadeMedidaEstoque.SelectedIndex = -1
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.SelectedIndex = -1
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            txtOCCapa.Text = ""
            txtOCLinha.Text = ""
            btnInserirEstoque.Tag = ""
            grdEstoque.DataSource = Nothing

            'Limpa Váriavel
            iCodigoEntradaItem = -1

            'Alterna Aba
            tabMain.SelectedTab = pagDados

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub SalvarProduto()

        Try

            'Seta Valores do Item            
            oClsFatEntradaNFeProduto.CodigoEntradaCapa = lCodigoEntradaCapa
            oClsFatEntradaNFeProduto.CodigoEntradaItem = iCodigoEntradaItem
            oClsFatEntradaNFeProduto.CodigoProdutoFornecedor = txtCodigoProdutoFornecedor.Text.Trim
            oClsFatEntradaNFeProduto.CodigoEAN = txtCodigoEAN.Text.Trim
            oClsFatEntradaNFeProduto.Descricao = txtDescricao.Text.Trim
            oClsFatEntradaNFeProduto.CodigoCFOP = cboCFOP.SelectedValue
            oClsFatEntradaNFeProduto.CFOP = cboCFOP.Text.Trim
            oClsFatEntradaNFeProduto.CodigoNCM = cboNCM.SelectedValue
            oClsFatEntradaNFeProduto.NCM = cboNCM.Text.Trim
            oClsFatEntradaNFeProduto.Quantidade = txtQuantidade.Value
            oClsFatEntradaNFeProduto.CodigoUnidadeMedida = IIf(cboUnidadeMedida.Enabled = True, cboUnidadeMedida.SelectedValue, -1)
            oClsFatEntradaNFeProduto.UnidadeMedida = cboUnidadeMedida.Text.Trim
            oClsFatEntradaNFeProduto.ValorUnitario = txtValorUnitario.Value
            oClsFatEntradaNFeProduto.ValorFrete = txtValorFrete.Value
            oClsFatEntradaNFeProduto.ValorSeguro = txtValorSeguro.Value
            oClsFatEntradaNFeProduto.ValorOutrasDespesas = txtOutrasDespesas.Value
            oClsFatEntradaNFeProduto.ValorDesconto = txtValorDesconto.Value
            oClsFatEntradaNFeProduto.ValorFrete = txtValorFrete.Value
            oClsFatEntradaNFeProduto.ValorSeguro = txtValorSeguro.Value
            oClsFatEntradaNFeProduto.ValorOutrasDespesas = txtOutrasDespesas.Value
            oClsFatEntradaNFeProduto.ValorTotal = txtValorTotal.Value
            oClsFatEntradaNFeProduto.IncideValorTotalNF = cboIncideValorTotalNF.SelectedValue
            oClsFatEntradaNFeProduto.InformacoesAdicionais = txtInformacoesAdicionais.Text.Trim

            'Verifica o Tipo de Operação
            If iCodigoEntradaItem = -1 Then
                'Insere Produto
                oClsFatEntradaNFeProduto.InsertProduto()
                'Seta Váriavel
                iCodigoEntradaItem = oClsFatEntradaNFeProduto.CodigoEntradaItem
            Else
                'Atualiza Produto
                oClsFatEntradaNFeProduto.UpdateProduto()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Valida Dados - Gerais
            If ValidacaoDadosGerais() = False Then Exit Function

            'Valida Dados - ICMS
            If iCodigoRegimeTributario = CInt(RegimeTributario.LucroPresumido) Or iCodigoRegimeTributario = CInt(RegimeTributario.LucroReal) Then
                If ValidacaoTributosICMS() = False Then Exit Function
            Else
                If ValidacaoTributosICMSSimples() = False Then Exit Function
            End If

            'Valida Dados - PIS
            If cboSituacaoTributariaIPI.SelectedIndex <> -1 Then
                If ValidacaoTributosIPI() = False Then Exit Function
            End If

            'Valida Dados - PIS
            If ValidacaoTributosPIS() = False Then Exit Function

            'Valida Dados - COFINS
            If ValidacaoTributosCOFINS() = False Then Exit Function

            'Verifica se foi Preenchido o Lote
            If tabMain.TabPages.Contains(pagEstoque) Then
                Dim dQuantidade As Double = 0
                If grdEstoque.GetDataRows.Count > 0 Then dQuantidade = grdEstoque.GetTotalRow.Cells("quantidade").Value
                If txtQuantidade.Value > dQuantidade Then
                    frmMain.errInfo.SetError(lblQuantidadeLote, "Favor Informar os dados do Estoque.")
                    tabMain.SelectedTab = pagEstoque
                    txtQuantidadeLote.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoDadosGerais() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDadosGerais = False

            'Verifica se foi Selecionado o Campo - CFOP
            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                tabMain.SelectedTab = pagDados : cboCFOP.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código Produto Fornecedor
            If ValidaCampo(txtCodigoProdutoFornecedor, lblCodigoProdutoFornecedor, TipoCampo.texto) = False Then
                tabMain.SelectedTab = pagDados : txtCodigoProdutoFornecedor.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                tabMain.SelectedTab = pagDados : txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código EAN
            If txtCodigoEAN.Text.Trim <> "" Then
                If ValidaCampo(txtCodigoEAN, lblCodigoEAN, TipoCampo.texto) = False Then
                    tabMain.SelectedTab = pagDados : txtCodigoEAN.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Incide no Valor Total da Nota Fiscal
            If ValidaCampo(cboIncideValorTotalNF, lblIncideValorTotalNF) = False Then
                tabMain.SelectedTab = pagDados : cboIncideValorTotalNF.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - NCM
            If ValidaCampo(cboNCM, lblNCM) = False Then
                tabMain.SelectedTab = pagDados : cboNCM.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then
                tabMain.SelectedTab = pagDados : cboUnidadeMedida.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If ValidaCampo(txtValorUnitario, lblValorUnitario, True) = False Then
                tabMain.SelectedTab = pagDados : txtValorUnitario.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Total
            If ValidaCampo(txtValorTotal, lblValorTotal, True) = False Then
                tabMain.SelectedTab = pagDados
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDadosGerais = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ICMS :::"

    Private Sub SaveItemImpostoICMS()

        Try

            'Salva Dados do ICMS
            Call oClsFatEntradaNFeProduto.InsertImpostoICMS(lCodigoEntradaCapa, _
                                                            iCodigoEntradaItem, _
                                                            cboSituacaoTributariaICMS.SelectedValue, _
                                                            cboOrigem.SelectedValue, _
                                                            IIf(cboModalidadeBCICMS.Enabled = False, -1, cboModalidadeBCICMS.SelectedValue), _
                                                            IIf(txtPorcentagemReducaoBCICMS.Enabled = False, -1, txtPorcentagemReducaoBCICMS.Value), _
                                                            txtBaseCalculoICMS.Value, _
                                                            IIf(txtAliquotaICMS.Enabled = False, -1, txtAliquotaICMS.Value), _
                                                            txtValorICMS.Value, _
                                                            IIf(cboModalidadeBCICMSST.SelectedIndex = -1, -1, cboModalidadeBCICMSST.SelectedValue), _
                                                            IIf(txtIVA.Enabled = False, -1, txtIVA.Value), _
                                                            IIf(txtPorcentagemReducaoBCICMSST.Enabled = False, -1, txtPorcentagemReducaoBCICMSST.Value), _
                                                            IIf(txtBaseCalculoICMSST.Enabled = False, -1, txtBaseCalculoICMSST.Value), _
                                                            IIf(txtAliquotaICMSST.Enabled = False, -1, txtAliquotaICMSST.Value), _
                                                            ((txtBaseCalculoICMSST.Value * txtAliquotaICMSST.Value / 100) - txtValorICMS.Value), _
                                                            txtBaseCalculoICMSSTRetido.Value, _
                                                            txtValorICMSSTRetido.Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoTributosICMS() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoTributosICMS = False

            'Verifica se foi Selecionado o Campo - Situação Tributária do ICMS            
            If ValidaCampo(cboSituacaoTributariaICMS, lblSituacaoTributariaICMS) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                cboSituacaoTributariaICMS.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Origem do Item
            If ValidaCampo(cboOrigem, lblOrigem) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                cboOrigem.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade da Base de Calculo do ICMS
            If cboModalidadeBCICMS.Enabled = True Then
                If ValidaCampo(cboModalidadeBCICMS, lblModalidadeBCICMS) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                    cboModalidadeBCICMS.Focus()
                    Exit Function
                End If
            End If

            ''Verifica se foi Preenchido o Campo - BC ICMS ST Retido Anteriormente
            'If txtBaseCalculoICMSSTRetido.Enabled = True Then
            '    If ValidaCampo(txtBaseCalculoICMSSTRetido, lblBaseCalculoICMSSTRetido, True) = False Then
            '        tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
            '        txtBaseCalculoICMSSTRetido.Focus()
            '        Exit Function
            '    End If
            'End If

            ''Verifica se foi Preenchido o Campo - Valor ICMS ST Retido Anteriormente
            'If txtValorICMSSTRetido.Enabled = True Then
            '    If ValidaCampo(txtValorICMSSTRetido, lblValorICMSSTRetido, True) = False Then
            '        tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
            '        txtValorICMSSTRetido.Focus()
            '        Exit Function
            '    End If
            'End If

            'Seta Retorno da Função
            ValidacaoTributosICMS = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ICMS SIMPLES :::"

    Private Sub SaveItemImpostoICMSSimples()

        Try

            'Salva Dados do ICMS Simples
            Call oClsFatEntradaNFeProduto.InsertImpostoICMSSimples(lCodigoEntradaCapa, _
                                                                   iCodigoEntradaItem, _
                                                                   cboSituacaoTributariaICMSSimples.SelectedValue, _
                                                                   cboOrigemSimples.SelectedValue, _
                                                                   txtAliquotaCalculoCreditoICMSSimples.Value, _
                                                                   txtCreditoICMSAproveitadoSimples.Value, _
                                                                   IIf(cboModalidadeBCICMSSimples.Enabled = False, -1, cboModalidadeBCICMSSimples.SelectedValue), _
                                                                   IIf(txtPorcentagemReducaoBCICMSSimples.Enabled = False, -1, txtPorcentagemReducaoBCICMSSimples.Value), _
                                                                   txtBaseCalculoICMSSimples.Value, _
                                                                   IIf(txtAliquotaICMSSimples.Enabled = False, -1, txtAliquotaICMSSimples.Value), _
                                                                   txtValorICMSSimples.Value, _
                                                                   IIf(cboModalidadeBCICMSSTSimples.Enabled = False, -1, cboModalidadeBCICMSSTSimples.SelectedValue), _
                                                                   IIf(txtIVASimples.Enabled = False, -1, txtIVASimples.Value), _
                                                                   IIf(txtPorcentagemReducaoBCICMSSTSimples.Enabled = False, -1, txtPorcentagemReducaoBCICMSSTSimples.Value), _
                                                                   IIf(txtBaseCalculoICMSSTSimples.Enabled = False, -1, txtBaseCalculoICMSSTSimples.Value), _
                                                                   IIf(txtAliquotaICMSSTSimples.Enabled = False, -1, txtAliquotaICMSSTSimples.Value), _
                                                                   ((txtBaseCalculoICMSSTSimples.Value * txtAliquotaICMSSTSimples.Value / 100) - txtValorICMSSimples.Value), _
                                                                   txtBaseCalculoICMSSTRetidoSimples.Value, _
                                                                   txtValorICMSSTRetidoSimples.Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoTributosICMSSimples() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoTributosICMSSimples = False

            'Verifica se foi Selecionado o Campo - Situação Tributária do ICMS Simples          
            If ValidaCampo(cboSituacaoTributariaICMSSimples, lblSituacaoTributariaICMSSimples) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                cboSituacaoTributariaICMSSimples.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Origem
            If ValidaCampo(cboOrigemSimples, lblOrigemSimples) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                cboOrigemSimples.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade da Base de Calculo do ICMS
            If cboModalidadeBCICMSSimples.Enabled = True Then
                If ValidaCampo(cboModalidadeBCICMSSimples, lblModalidadeBCICMSSimples) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                    cboModalidadeBCICMSSimples.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Modalidade da Base de Calculo do ICMS ST
            If cboModalidadeBCICMSSTSimples.Enabled = True Then
                If ValidaCampo(cboModalidadeBCICMSSTSimples, lblModalidadeBCICMSSTSimples) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                    cboModalidadeBCICMSSTSimples.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - IVA
            If txtIVASimples.Enabled = True Then
                If ValidaCampo(txtIVASimples, lblIVASimples, True) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                    txtIVASimples.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Base Calculo ICMS ST
            If txtBaseCalculoICMSSTSimples.Enabled = True Then
                If ValidaCampo(txtBaseCalculoICMSSTSimples, lblBaseCalculoICMSSTSimples, True) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                    txtBaseCalculoICMSSTSimples.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Alíquota ICMS ST
            If txtAliquotaICMSSTSimples.Enabled = True Then
                If ValidaCampo(txtAliquotaICMSSTSimples, lblAliquotaICMSSTSimples, True) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                    txtAliquotaICMSSTSimples.Focus()
                    Exit Function
                End If
            End If

            ''Verifica se foi Preenchido o Campo - BC ICMS ST Retido Anteriormente
            'If txtBaseCalculoICMSSTRetidoSimples.Enabled = True Then
            '    If ValidaCampo(txtBaseCalculoICMSSTRetidoSimples, lblBaseCalculoICMSSTRetidoSimples, True) = False Then
            '        tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
            '        txtBaseCalculoICMSSTRetidoSimples.Focus()
            '        Exit Function
            '    End If
            'End If

            ''Verifica se foi Preenchido o Campo - Valor ICMS ST Retido Anteriormente
            'If txtValorICMSSTRetidoSimples.Enabled = True Then
            '    If ValidaCampo(txtValorICMSSTRetidoSimples, lblValorICMSSTRetidoSimples, True) = False Then
            '        tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
            '        txtValorICMSSTRetidoSimples.Focus()
            '        Exit Function
            '    End If
            'End If

            'Seta Retorno da Função
            ValidacaoTributosICMSSimples = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: IPI :::"

    Private Sub SaveItemImpostoIPI()

        Try

            'Verifica se foi Selecionada a Situação Tributária do IPI
            If cboSituacaoTributariaIPI.SelectedIndex = -1 Then Exit Sub

            'Salva Dados do IPI
            Call oClsFatEntradaNFeProduto.InsertImpostoIPI(lCodigoEntradaCapa, _
                                                           iCodigoEntradaItem, _
                                                           "", _
                                                           "", _
                                                           "", _
                                                           -1, _
                                                           "", _
                                                           cboSituacaoTributariaIPI.SelectedValue, _
                                                           IIf(cboTipoCalculoIPI.SelectedIndex = -1, -1, cboTipoCalculoIPI.SelectedValue), _
                                                           txtBaseCalculoIPI.Value, _
                                                           txtAliquotaIPI.Value, _
                                                           txtQuantidadeIPI.Value, _
                                                           txtValorUnidadeIPI.Value, _
                                                           txtValorIPI.Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoTributosIPI() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoTributosIPI = False

            'Verifica se foi Selecionado o Campo - Situação Tributária do IPI
            If ValidaCampo(cboSituacaoTributariaIPI, lblSituacaoTributariaIPI) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagIPI
                cboSituacaoTributariaIPI.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Cálculo
            If cboTipoCalculoIPI.Enabled = True Then
                If ValidaCampo(cboTipoCalculoIPI, lblTipoCalculoIPI) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagIPI
                    cboTipoCalculoIPI.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoTributosIPI = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PIS :::"

    Private Sub SaveItemImpostoPIS()

        Try

            'Salva Dados do PIS
            Call oClsFatEntradaNFeProduto.InsertImpostoPIS(lCodigoEntradaCapa, _
                                                           iCodigoEntradaItem, _
                                                           cboSituacaoTributariaPIS.SelectedValue, _
                                                           IIf(cboTipoCalculoPIS.SelectedIndex = -1, IIf(txtBaseCalculoPIS.Enabled = True, TipoCalculoImposto.Percentual, TipoCalculoImposto.Valor), cboTipoCalculoPIS.SelectedValue), _
                                                           txtBaseCalculoPIS.Value, _
                                                           txtAliquotaPercentualPIS.Value, _
                                                           txtAliquotaValorPIS.Value, _
                                                           txtQuantidadeVendidaPIS.Value, _
                                                           txtValorPIS.Value, _
                                                           -1, _
                                                           0, _
                                                           0, _
                                                           0, _
                                                           0, _
                                                           0)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoTributosPIS() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoTributosPIS = False

            'Verifica se foi Selecionado o Campo - Situação Tributária do PIS
            If ValidaCampo(cboSituacaoTributariaPIS, lblSituacaoTributariaPIS) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagPIS
                cboSituacaoTributariaPIS.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Cálculo
            If cboTipoCalculoPIS.Enabled = True Then
                If ValidaCampo(cboTipoCalculoPIS, lblTipoCalculoPIS) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagPIS
                    cboTipoCalculoPIS.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoTributosPIS = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: COFINS :::"

    Private Sub SaveItemImpostoCOFINS()

        Try

            'Salva Dados do COFINS
            Call oClsFatEntradaNFeProduto.InsertImpostoCOFINS(lCodigoEntradaCapa, _
                                                              iCodigoEntradaItem, _
                                                              cboSituacaoTributariaCOFINS.SelectedValue, _
                                                              IIf(cboTipoCalculoCOFINS.SelectedIndex = -1, IIf(txtBaseCalculoCOFINS.Enabled = True, TipoCalculoImposto.Percentual, TipoCalculoImposto.Valor), cboTipoCalculoCOFINS.SelectedValue), _
                                                              txtBaseCalculoCOFINS.Value, _
                                                              txtAliquotaPercentualCOFINS.Value, _
                                                              txtAliquotaValorCOFINS.Value, _
                                                              txtQuantidadeVendidaCOFINS.Value, _
                                                              txtValorCOFINS.Value, _
                                                              -1, _
                                                              0, _
                                                              0, _
                                                              0, _
                                                              0, _
                                                              0)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoTributosCOFINS() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoTributosCOFINS = False

            'Verifica se foi Selecionado o Campo - Situação Tributária do COFINS
            If ValidaCampo(cboSituacaoTributariaCOFINS, lblSituacaoTributariaCOFINS) = False Then
                tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagCOFINS
                cboSituacaoTributariaCOFINS.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Cálculo
            If cboTipoCalculoCOFINS.Enabled = True Then
                If ValidaCampo(cboTipoCalculoCOFINS, lblTipoCalculoCOFINS) = False Then
                    tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagCOFINS
                    cboTipoCalculoCOFINS.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoTributosCOFINS = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: II :::"

    Private Sub SaveItemImpostoII()

        Try

            'Salva Dados do II
            oClsFatEntradaNFeProduto.InsertImpostoII(lCodigoEntradaCapa, _
                                                     iCodigoEntradaItem, _
                                                     txtBaseCalculoII.Value, _
                                                     txtDespesaAduaneiraII.Value, _
                                                     txtValorIOF.Value, _
                                                     txtValorII.Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub DeleteEstoque()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdEstoque) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha da Grid
                    Call oClsFatEntradaNFeProduto.DeleteEstoque(lCodigoEntradaCapa, iCodigoEntradaItem)

                    'Limpa Formulário
                    Call NovoEstoque()

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

    Private Sub EditarEstoque()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoEstoque()

                'Carrega Controles
                btnInserirEstoque.Tag = grdEstoque.CurrentRow.RowIndex

                iCodigoEntradaItemLote = grdEstoque.CurrentRow.Cells("codigo").Value
                cboTipoOperacao.SelectedValue = grdEstoque.CurrentRow.Cells("codigo_tipo_operacao").Value
                cboNumeroDocumento.SelectedValue = grdEstoque.CurrentRow.Cells("codigo_composto_numero_documento").Value
                cboProduto.SelectedValue = grdEstoque.CurrentRow.Cells("codigo_composto_produto").Value
                txtQuantidadeLote.Value = grdEstoque.CurrentRow.Cells("quantidade").Value
                If IsDBNull(grdEstoque.CurrentRow.Cells("codigo_unidade_medida").Value) = False Then cboUnidadeMedida.SelectedValue = grdEstoque.CurrentRow.Cells("codigo_unidade_medida").Value
                txtFatorConversao.Value = IIf(IsDBNull(grdEstoque.CurrentRow.Cells("fator_conversao").Value), 0, grdEstoque.CurrentRow.Cells("fator_conversao").Value)
                txtQuantidadeEstoque.Value = IIf(IsDBNull(grdEstoque.CurrentRow.Cells("quantidade_estoque").Value), 0, grdEstoque.CurrentRow.Cells("quantidade_estoque").Value)
                If IsDBNull(grdEstoque.CurrentRow.Cells("codigo_deposito").Value) = False Then cboDeposito.SelectedValue = grdEstoque.CurrentRow.Cells("codigo_deposito").Value
                txtLote.Text = IIf(IsDBNull(grdEstoque.CurrentRow.Cells("lote").Value), "", grdEstoque.CurrentRow.Cells("lote").Value)
                If IsDBNull(grdEstoque.CurrentRow.Cells("data_fabricacao").Value) = False Then dtpDataValidade.Value = grdEstoque.CurrentRow.Cells("data_fabricacao").Value
                If IsDBNull(grdEstoque.CurrentRow.Cells("data_validade").Value) = False Then dtpDataValidade.Value = grdEstoque.CurrentRow.Cells("data_validade").Value
                txtOCCapa.Text = IIf(IsDBNull(grdEstoque.CurrentRow.Cells("oc_capa").Value), "", grdEstoque.CurrentRow.Cells("oc_capa").Value)
                txtOCLinha.Text = IIf(IsDBNull(grdEstoque.CurrentRow.Cells("oc_linha").Value), "", grdEstoque.CurrentRow.Cells("oc_linha").Value)                

                'Seta Focu
                cboTipoOperacao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoEstoque()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboTipoOperacao.SelectedIndex = -1
            btnInserirEstoque.Tag = ""

            'Limpa Váriaveis
            iCodigoEntradaItemLote = -1

            'Seta Focu
            cboTipoOperacao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoEstoque() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEstoque = False

            'Verifica se foi Selecionado o Campo - Tipo de Operação
            If ValidaCampo(cboTipoOperacao, lblTipoOperacao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Produto
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Verifica se o Produto Selecionado é Válido
            If grdEstoque.GetDataRows.Count > 0 Then
                grdEstoque.Row = 0
                If lCodigoItem <> grdEstoque.GetValue("codigo_item") Then
                    frmMain.errInfo.SetError(lblProduto, "Este Produto não é Válido, uma vez que já foi associado outro Produto ao Item da Nota Fiscal.")
                    cboProduto.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If txtQuantidadeLote.Enabled = True Then
                If ValidaCampo(txtQuantidadeLote, lblQuantidadeLote, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Quantidade é Válida
            Dim dQuantidade As Double = 0
            If grdEstoque.GetDataRows.Count > 0 Then dQuantidade = grdEstoque.GetTotalRow.Cells("quantidade").Value
            If IsNumeric(btnInserirEstoque.Tag) Then
                dQuantidade -= grdEstoque.CurrentRow.Cells("quantidade").Value
            End If
            If txtQuantidadeLote.Value + dQuantidade > txtQuantidade.Value Then
                frmMain.errInfo.SetError(lblQuantidadeLote, "A Soma das Quantidades (Estoque) não pode ser maior que a Quantidade da Nota Fiscal.")
                txtQuantidadeLote.Focus()
                Exit Function
            End If

            'Seta Status
            iStatusRecebimento = StatusFaturamentoEntradaRecebimento.Aprovado

            'Verifica se a Quantidade do Pedido é Válido
            If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra) Then

                'Verifica se a Quantidade é Maior que a Quantidade do Pedido
                If txtQuantidadeEstoque.Value > txtQuantidadeDocumento.Value Then

                    MsgBox("A quantidade estoque não pode ser maior que a quantidade do pedido de compra.", vbExclamation, "Validação")
                    Exit Function

                    ''Verifica se a Quantidade utrapassa a Quantidade Permitida
                    'If (dQuantidadePedido * dToleranciaQuantidadePercentual / 100) < (txtQuantidadeLote.Value - txtQuantidadeDocumento.Value) Then

                    '    'Abre Formulário para preencher a Justificativa
                    '    Dim oForm As New frmCadJustificativa

                    '    'Seta Parâmetros
                    '    oForm.Table = "tb_fat_entrada_tem_lote"
                    '    oForm.Tipo = "RECEBIMENTO A MAIOR"
                    '    oForm.Codigo = lCodigoEntradaCapa
                    '    oForm.Codigo2 = iCodigoEntradaItem
                    '    oForm.Codigo3 = cboNumeroDocumento.SelectedValue
                    '    oForm.txtMotivo.Text = "QUANTIDADE RECEBIDA A MAIOR QUE O PEDIDO DE COMPRA"

                    '    'Abre Formulário
                    '    oForm.ShowDialog(Me)

                    '    'Seta Status
                    '    iStatusRecebimento = StatusFaturamentoEntradaRecebimento.AguardandoAprovacao

                    '    'Verifica o Retorno
                    '    If oForm.Retorno = "N" Then
                    '        txtQuantidadeLote.Focus()
                    '        Exit Function
                    '    End If

                    'End If
                End If
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedidaEstoque.Enabled = True Then
                If ValidaCampo(cboUnidadeMedidaEstoque, lblUnidadeMedidaEstoque) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Fator de Conversão
            If txtFatorConversao.Enabled = True Then
                If ValidaCampo(txtFatorConversao, lblFatorConversao, False) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade Estoque
            If txtQuantidadeEstoque.Enabled = True Then
                If ValidaCampo(txtQuantidadeEstoque, lblQuantidadeEstoque, True) = False Then
                    Exit Function
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

            'Verifica se foi Preenchido o Campo - Data de Validade Corretamente
            If dtpDataValidade.Enabled = True Then
                If dtpDataValidade.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataValidade, " A Data de Validade não pode ser menor que a Data Corrente.")
                    dtpDataValidade.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Data de Fabricação Corretamente
            If dtpDataFabricacao.Enabled = True Then
                If dtpDataFabricacao.Value > Now.Date Then
                    frmMain.errInfo.SetError(lblDataFabricacao, " A Data de Fabricação não pode ser menor que a Data Corrente.")
                    dtpDataFabricacao.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoEstoque = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class

