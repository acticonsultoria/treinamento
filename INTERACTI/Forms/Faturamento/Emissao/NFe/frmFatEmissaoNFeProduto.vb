Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class frmFatEmissaoNFeProduto

#Region "::: VARIAVEIS :::"

    Private oClsFatEmissaoNFeItem As New clsFrmFatEmissaoNFeProduto
    Private bItemEstoque As Boolean
    Private bItemProducao As Boolean

    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private iCodigoTipoDocumentoFiscal As TipoDocumentoFiscal
    Private iCodigoFinalidadeEmissaoNFe As FinalidadeEmissaoNFe
    Private oRowNFReferenciada() As GridEXRow
    Private sUFDestinatario As String
    Private lCodigoParceiroNegocio As Long
    Private iCodigoRegimeTributario As Integer
    Private iCodigoTipoOperacao As Integer

    Private bAllowSave As Boolean
    Private iCFOP As Integer
    Private sSituacaoTributariaICMS As String
    Private sSituacaoTributariaIPI As String
    Private sSituacaoTributariaPIS As String
    Private sSituacaoTributariaCOFINS As String

    Private oGrid As GridEX

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

    Public Property CodigoEmissaoItem() As Integer
        Get
            Return iCodigoEmissaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoEmissaoItem = value
        End Set
    End Property

    Public Property CodigoTipoDocumentoFiscal() As Integer
        Get
            Return iCodigoTipoDocumentoFiscal
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoDocumentoFiscal = value
        End Set
    End Property

    Public Property CodigoFinalidadeEmissaoNFe() As Integer
        Get
            Return iCodigoFinalidadeEmissaoNFe
        End Get
        Set(ByVal value As Integer)
            iCodigoFinalidadeEmissaoNFe = value
        End Set
    End Property

    Public Property CodigoTipoOperacao() As Integer
        Get
            Return iCodigoTipoOperacao
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoOperacao = value
        End Set
    End Property

    Public Property RowNFReferenciada() As GridEXRow()
        Get
            Return oRowNFReferenciada
        End Get
        Set(ByVal value() As GridEXRow)
            oRowNFReferenciada = value
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

    Public Property CodigoParceiroNegocio() As Long
        Get
            Return lCodigoParceiroNegocio
        End Get
        Set(ByVal value As Long)
            lCodigoParceiroNegocio = value
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

    Public Property AllowSave() As Boolean
        Get
            Return bAllowSave
        End Get
        Set(ByVal value As Boolean)
            bAllowSave = value
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

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmFatEmissaoNFeProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigo" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCFOP" : Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & iCodigoTipoDocumentoFiscal & ", '" & sUFDestinatario & "', '" & goEmitente.sUF & "'")
                        Case "cboNCM" : Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCodigo" : Call btnCadastrarItem_Click(btnCadastrarItem, System.EventArgs.Empty)
                        Case "cboCFOP" : Call btnCadastrarCFOP_Click(btnCadastrarCFOP, System.EventArgs.Empty)
                        Case "cboNCM" : Call btnCadastrarNCM_Click(btnCadastrarNCM, System.EventArgs.Empty)
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
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

    Private Sub btnCadastrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarItem.Click

        Try

             'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo - Item
            Call LoadCombo(cboCodigo, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", " & lCodigoParceiroNegocio, False)

            'Seta Focu
            cboCodigo.Focus()

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
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & iCodigoTipoDocumentoFiscal & ", '" & goEmitente.sUF & "', '" & sUFDestinatario & "'")
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

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboCodigo

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirTributos.Click, _
                                                                                                     btnInserirDados.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True And ValidacaoPartilha() = True Then

                'Salva os Dados do Item
                Call SaveProduto()
                'Insere Imposto - IPI
                If cboSituacaoTributariaIPI.SelectedIndex <> -1 Then Call SaveItemImpostoIPI()
                'Insere Imposto - PIS
                Call SaveItemImpostoPIS()
                'Insere Imposto - COFINS
                Call SaveItemImpostoCOFINS()
                'Insere Imposto - II
                Call SaveItemImpostoII()
                'Insere Imposto - ICMS
                If goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroReal) Or goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroPresumido) Then
                    Call SaveItemImpostoICMS()
                Else
                    Call SaveItemImpostoICMSSimples()
                End If

                If sUFDestinatario <> "SP" Then
                    Call SaveItemImpostoICMSPartilha()
                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()
                Call NovoICMSPartilha()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarTributos.Click, _
                                                                                                    btnVoltarDados.Click

        Try

            'Fecha Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigo.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado algum Produto
            If cboCodigo.SelectedIndex > -1 Then

                'Carrega Dados do Produto
                Call oClsFatEmissaoNFeItem.LoadDadosItem(cboCodigo.SelectedValue, _
                                                         txtDescricao, _
                                                         cboNCM, _
                                                         cboUnidadeMedida, _
                                                         txtAliquotaIPI, _
                                                         txtValorUnitario, _
                                                         bItemEstoque, _
                                                         bItemProducao)

            Else

                'Limpa Controles
                txtDescricao.Text = ""
                txtCodigoEAN.Text = ""
                cboNCM.SelectedIndex = -1

            End If

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

            'Oculta Abas
            tabProduto.TabPages.Remove(pagTributos)
            tabTributo.TabPages.Remove(pagICMS)
            tabTributo.TabPages.Remove(pagICMSSimples)
            tabTributo.TabPages.Remove(pagICMSPartilha)
            tabTributo.TabPages.Remove(pagIPI)
            tabTributo.TabPages.Remove(pagPIS)
            tabTributo.TabPages.Remove(pagCOFINS)
            tabTributo.TabPages.Remove(pagImpostoImportacao)

            'Verifica se foi Selecionado um CFOP
            If cboCFOP.SelectedIndex <> -1 Then

                'Adiciona Aba de Tributo
                tabProduto.TabPages.Add(pagTributos)
                If goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroReal) Or goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroPresumido) Then
                    tabTributo.TabPages.Add(pagICMS)
                Else
                    tabTributo.TabPages.Add(pagICMSSimples)
                End If
                tabTributo.TabPages.Add(pagIPI)
                tabTributo.TabPages.Add(pagPIS)
                tabTributo.TabPages.Add(pagCOFINS)
                If sUFDestinatario = "EX" Then tabTributo.TabPages.Add(pagImpostoImportacao)
                If sUFDestinatario <> "SP" Then tabTributo.TabPages.Add(pagICMSPartilha)

                'Seta Aba Selecionada
                tabProduto.SelectedTab = pagDados : tabTributo.SelectedTab = IIf((iCodigoRegimeTributario = CInt(RegimeTributario.LucroReal) Or iCodigoRegimeTributario = CInt(RegimeTributario.LucroPresumido)), pagICMS, pagICMSSimples)

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

        'Seta Base de Cálculo (IPI, PIS e COFINS)
        txtBaseCalculoIPI.Value = txtValorTotal.Value
        txtBaseCalculoPIS.Value = txtValorTotal.Value
        txtBaseCalculoCOFINS.Value = txtValorTotal.Value

    End Sub

    Private Sub chkCalculoAutomatico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCalculoAutomatico.CheckedChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If chkCalculoAutomatico.Checked = True Then
                txtValorFrete.Enabled = False : txtValorFrete.Value = 0
                txtValorSeguro.Enabled = False : txtValorSeguro.Value = 0
                txtOutrasDespesas.Enabled = False : txtOutrasDespesas.Value = 0
                txtBaseCalculoICMS.Enabled = True
            Else
                txtValorFrete.Enabled = True
                txtValorSeguro.Enabled = True
                txtOutrasDespesas.Enabled = True
                Call cboSituacaoTributariaICMS_SelectedIndexChanged()
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: ICMS :::"

    Private Sub cboSituacaoTributariaICMS_SelectedIndexChanged() Handles cboSituacaoTributariaICMS.SelectedIndexChanged

        Try

            'Desabilita Controles - ICMS
            txtBaseCalculoICMS.Enabled = False
            cboModalidadeBCICMS.Enabled = False
            txtPorcentagemReducaoBCICMS.Enabled = False
            txtAliquotaICMS.Enabled = False
            'Desabilita Controles - ICMS ST
            cboModalidadeBCICMSST.Enabled = False
            txtIVA.Enabled = False
            txtPorcentagemReducaoBCICMSST.Enabled = False
            txtBaseCalculoICMSST.Enabled = False
            txtAliquotaICMSST.Enabled = False

            If cboSituacaoTributariaICMS.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaICMS.SelectedValue

                    Case "00"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = IIf(chkCalculoAutomatico.Checked = True, False, True)
                        txtAliquotaICMS.Enabled = True

                    Case "10"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = IIf(chkCalculoAutomatico.Checked = True, False, True)
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
                        txtBaseCalculoICMS.Enabled = IIf(chkCalculoAutomatico.Checked = True, False, True)
                        txtAliquotaICMS.Enabled = True

                    Case "30"
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSST.Enabled = True
                        txtPorcentagemReducaoBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtBaseCalculoICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "40", "41", "50"

                    Case "51"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = IIf(chkCalculoAutomatico.Checked = True, False, True)
                        txtAliquotaICMS.Enabled = True

                    Case "60"
                        'Habilita Controles - ICMS ST                    
                        'txtBaseCalculoICMSSTRetido.Enabled = True
                        'txtValorICMSSTRetido.Enabled = True

                    Case "70"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMS.Enabled = True
                        txtPorcentagemReducaoBCICMS.Enabled = True
                        txtBaseCalculoICMS.Enabled = IIf(chkCalculoAutomatico.Checked = True, False, True)
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
                        txtBaseCalculoICMS.Enabled = IIf(chkCalculoAutomatico.Checked = True, False, True)
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

        'Calcula Valor do ICMS
        txtValorICMS.Value = (txtBaseCalculoICMS.Value * txtAliquotaICMS.Value) / 100

    End Sub

#End Region

#Region "::: ICMS SIMPLES :::"

    Private Sub cboSituacaoTributariaICMSSimples_SelectedIndexChanged() Handles cboSituacaoTributariaICMSSimples.SelectedIndexChanged

        Try

            'Desabilita Controles - ICMS
            cboModalidadeBCICMSSimples.Enabled = False : cboModalidadeBCICMSSimples.SelectedIndex = -1
            txtPorcentagemReducaoBCICMSSimples.Enabled = False : txtPorcentagemReducaoBCICMSSimples.Value = 0
            txtAliquotaICMSSimples.Enabled = False : txtAliquotaICMSSimples.Value = 0
            'Desabilita Controles - ICMS ST
            cboModalidadeBCICMSSTSimples.Enabled = False : cboModalidadeBCICMSSTSimples.SelectedIndex = -1
            txtIVASimples.Enabled = False : txtIVASimples.Value = 0
            txtPorcentagemReducaoBCICMSSTSimples.Enabled = False : txtPorcentagemReducaoBCICMSSTSimples.Value = 0
            txtBaseCalculoICMSSTSimples.Enabled = False : txtBaseCalculoICMSSTSimples.Value = 0
            txtAliquotaICMSSTSimples.Enabled = False : txtAliquotaICMSSTSimples.Value = 0

            If cboSituacaoTributariaICMSSimples.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaICMSSimples.SelectedValue

                    Case "101"

                    Case "201"
                        'Habilita Controles - ICMS ST
                        cboModalidadeBCICMSSTSimples.Enabled = True
                        txtPorcentagemReducaoBCICMSSTSimples.Enabled = True
                        txtIVASimples.Enabled = True
                        txtBaseCalculoICMSSTSimples.Enabled = True
                        txtAliquotaICMSSTSimples.Enabled = True

                    Case "500"

                    Case "202", "203", "900"
                        'Habilita Controles - ICMS
                        cboModalidadeBCICMSSimples.Enabled = True
                        txtPorcentagemReducaoBCICMSSimples.Enabled = True
                        'txtBaseCalculoICMSSimples.Enabled = True
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

#End Region

#Region "::: ICMS PARTILHA :::"

    Private Sub CalculaValorTotaisPartilha(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBaseCalculoICMSPartilha.LostFocus, _
                                                                                                               txtPercentualFCPICMSPartilha.LostFocus, _
                                                                                                               txtPercentualICMSInterestadual.LostFocus, _
                                                                                                               txtPercentualICMSPartilha.LostFocus, _
                                                                                                               txtPercentualICMSDestino.LostFocus

        Try
            If chkCalculoAutomatico.Checked = True Then
                Call oClsFatEmissaoNFeItem.CalcularICMSPartilha(txtBaseCalculoICMSPartilha, _
                                                                txtPercentualICMSPartilha, _
                                                                txtPercentualFCPICMSPartilha, _
                                                                txtPercentualICMSDestino, _
                                                                txtPercentualICMSInterestadual, _
                                                                txtValorFCP, _
                                                                txtValorICMSDestino, _
                                                                txtValorICMSRemetente, _
                                                                txtAliquotaICMS)
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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

                    Case "00", "49", "50", "99"
                        'Habilita Controle
                        cboTipoCalculoIPI.Enabled = True



                End Select

            End If
            If cboSituacaoTributariaIPI.SelectedIndex = -1 Then
                Call LoadCombo(cboCodigoEnquadramento, "sp_select_combo_static_classe_enquadramento_ipi ''")
            Else
                If cboSituacaoTributariaIPI.SelectedValue = "04" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "05" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "02" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "01" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "54" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "55" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "52" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "51" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "49" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "59" Then
                    Call LoadCombo(cboCodigoEnquadramento, "sp_select_combo_static_classe_enquadramento_ipi '" & cboSituacaoTributariaIPI.SelectedValue & "'")
                    cboCodigoEnquadramento.Enabled = True
                Else
                    cboCodigoEnquadramento.Enabled = False
                    cboCodigoEnquadramento.SelectedIndex = -1
                End If
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

            'Carrega Combo
            If oRowNFReferenciada.Count > 0 Then
                Call LoadCombo(cboCodigo, "sp_select_combo_faturamento_item_nf_referenciada " & lCodigoEmissaoCapa & ", " & goUsuario.iEmpresa, False)
            Else
                Call LoadCombo(cboCodigo, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", " & lCodigoParceiroNegocio, False)
            End If
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", " & iCodigoTipoDocumentoFiscal & ", '" & sUFDestinatario & "', '" & goEmitente.sUF & "'", False)
            Call LoadComboSimNao(cboIncideValorTotalNF)
            Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboNumeroDI, "sp_select_combo_faturamento_emissao_di " & lCodigoEmissaoCapa & ", " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboModalidadeBCICMS, "sp_select_combo_static_modalidade_base_calculo_icms", False)
            Call LoadCombo(cboModalidadeBCICMSST, "sp_select_combo_static_modalidade_base_calculo_icms_st", False)
            Call LoadCombo(cboModalidadeBCICMSSimples, "sp_select_combo_static_modalidade_base_calculo_icms", False)
            Call LoadCombo(cboModalidadeBCICMSSTSimples, "sp_select_combo_static_modalidade_base_calculo_icms_st", False)
            Call LoadCombo(cboOrigemItem, "sp_select_combo_static_origem_item", False)
            Call LoadCombo(cboSituacaoTributariaICMS, "sp_select_combo_static_situacao_tributaria_icms", False)
            Call LoadCombo(cboOrigemItemSimples, "sp_select_combo_static_origem_item", False)
            Call LoadCombo(cboSituacaoTributariaICMSSimples, "sp_select_combo_static_situacao_tributaria_icms_simples", False)
            Call LoadCombo(cboSituacaoTributariaPIS, "sp_select_combo_static_situacao_tributaria_pis", False)
            Call LoadCombo(cboSituacaoTributariaCOFINS, "sp_select_combo_static_situacao_tributaria_cofins", False)
            Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & iCodigoTipoDocumentoFiscal, False)
            Dim oComboBox(2) As UIComboBox
            oComboBox(0) = cboTipoCalculoIPI : oComboBox(1) = cboTipoCalculoCOFINS : oComboBox(2) = cboTipoCalculoPIS
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_calculo_imposto", False)

            'Verifica a Finalidade de Emissão da Nota Fiscal Eletrônica
            If iCodigoFinalidadeEmissaoNFe = FinalidadeEmissaoNFe.NFeNormal Then
                txtValorFrete.Enabled = False : txtValorFrete.Value = 0
                txtValorSeguro.Enabled = False : txtValorSeguro.Value = 0
                txtOutrasDespesas.Enabled = False : txtOutrasDespesas.Value = 0
                txtBaseCalculoICMS.Enabled = False
                'txtValorICMS.Enabled = False
            End If

            'Seta Controle
            chkCalculoAutomatico.Checked = True

            'Oculta Aba de Tributo
            tabProduto.TabPages.Remove(pagTributos)

            'Verifica se é operação de Update
            If iCodigoEmissaoItem <> -1 Then
                Call LoadProduto()
                If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then
                    Call LoadICMSPartilha()
                End If
            End If

            'If iCodigoTipoOperacao = 1 Then
            '    txtQuantidade.Enabled = False
            'Else
            '    txtQuantidade.Enabled = True
            'End If

            If goUsuario.sCNPJEmpresa = "07.146.092/0001-61" Then
                cboIncideValorTotalNF.SelectedValue = 1
            End If

            'Seta Propriedade do Controle
            'btnInserirDados.Enabled = bAllowSave
            btnInserirTributos.Enabled = bAllowSave

            'Seta Formulário
            Me.Size = frmMain.tlpMain.Size
            Me.Location = New Point(0, 23)
            Application.DoEvents()

            'Seta Focu
            cboCodigo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCodigo.SelectedIndex = -1
            txtDescricao.Text = ""
            txtCodigoEAN.Text = ""
            cboIncideValorTotalNF.SelectedIndex = -1
            cboNCM.SelectedIndex = -1
            txtQuantidade.Value = 0
            cboUnidadeMedida.SelectedIndex = -1
            txtValorUnitario.Value = 0
            txtValorDesconto.Value = 0
            txtInformacoesAdicionais.Text = ""
            txtNumeroItemPedidoCompra.Value = 0
            cboNumeroDI.SelectedIndex = -1
            txtCodigoFabricante.Text = ""
            chkCalculoAutomatico.Checked = True
            txtQuantidade.Enabled = True

            'Limpa Váriavel
            iCodigoEmissaoItem = -1

            'Alterna Aba
            tabProduto.SelectedTab = pagDados

            'Seta Focu
            cboCodigo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub SaveProduto()

        Try

            'Seta Valores do Item            
            oClsFatEmissaoNFeItem.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oClsFatEmissaoNFeItem.CodigoItem = cboCodigo.SelectedValue
            oClsFatEmissaoNFeItem.CodigoEmissaoItem = iCodigoEmissaoItem
            oClsFatEmissaoNFeItem.CodigoProdutoServico = cboCodigo.Text.Trim
            oClsFatEmissaoNFeItem.CodigoEAN = txtCodigoEAN.Text.Trim
            oClsFatEmissaoNFeItem.Descricao = txtDescricao.Text.Trim
            oClsFatEmissaoNFeItem.CodigoCFOP = cboCFOP.SelectedValue
            oClsFatEmissaoNFeItem.CFOP = cboCFOP.Text.Trim
            oClsFatEmissaoNFeItem.CodigoNCM = cboNCM.SelectedValue
            oClsFatEmissaoNFeItem.NCM = cboNCM.Text.Trim
            oClsFatEmissaoNFeItem.Quantidade = txtQuantidade.Value
            oClsFatEmissaoNFeItem.ValorFrete = txtValorFrete.Value
            oClsFatEmissaoNFeItem.ValorSeguro = txtValorSeguro.Value
            oClsFatEmissaoNFeItem.ValorOutrasDespesas = txtOutrasDespesas.Value
            oClsFatEmissaoNFeItem.CodigoUnidadeMedida = IIf(cboUnidadeMedida.Enabled = True, cboUnidadeMedida.SelectedValue, -1)
            oClsFatEmissaoNFeItem.UnidadeMedida = cboUnidadeMedida.Text.Trim
            oClsFatEmissaoNFeItem.ValorUnitario = txtValorUnitario.Value
            oClsFatEmissaoNFeItem.ValorDesconto = txtValorDesconto.Value
            oClsFatEmissaoNFeItem.ValorTotal = txtValorTotal.Value
            oClsFatEmissaoNFeItem.IncideValorTotalNF = cboIncideValorTotalNF.SelectedValue
            oClsFatEmissaoNFeItem.PedidoCompra = txtPedidoCompra.Text.Trim
            oClsFatEmissaoNFeItem.NumeroItemPedidoCompra = txtNumeroItemPedidoCompra.Value
            oClsFatEmissaoNFeItem.InformacoesAdicionais = txtInformacoesAdicionais.Text.Trim
            oClsFatEmissaoNFeItem.CodigoEmissaoDI = IIf(cboNumeroDI.SelectedIndex = -1, -1, cboNumeroDI.SelectedValue)
            oClsFatEmissaoNFeItem.CodigoFabricante = txtCodigoFabricante.Text.Trim
            oClsFatEmissaoNFeItem.CalculoAutomatico = chkCalculoAutomatico.Checked

            'Verifica o Tipo de Operação
            oClsFatEmissaoNFeItem.InsertProduto()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadProduto()

        Try

            'Seta Valor
            oClsFatEmissaoNFeItem.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oClsFatEmissaoNFeItem.CodigoEmissaoItem = iCodigoEmissaoItem

            'Carrega Formulário
            Call oClsFatEmissaoNFeItem.LoadProduto(iCodigoEmissaoItem, _
                                                   lCodigoEmissaoCapa, _
                                                   cboCodigo, _
                                                   txtDescricao, _
                                                   txtCodigoEAN, _
                                                   cboCFOP, _
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
                                                   txtPedidoCompra, _
                                                   txtNumeroItemPedidoCompra, _
                                                   cboNumeroDI, _
                                                   txtCodigoFabricante, _
                                                   chkCalculoAutomatico, _
                                                   cboOrigemItem, _
                                                   cboSituacaoTributariaICMS, _
                                                   cboModalidadeBCICMS, _
                                                   txtPorcentagemReducaoBCICMS, _
                                                   txtBaseCalculoICMS, _
                                                   txtAliquotaICMS, _
                                                   cboModalidadeBCICMSST, _
                                                   txtIVA, _
                                                   txtPorcentagemReducaoBCICMSST, _
                                                   txtBaseCalculoICMSST, _
                                                   txtAliquotaICMSST, _
                                                   txtValorICMS, _
                                                   cboOrigemItemSimples, _
                                                   cboSituacaoTributariaICMSSimples, _
                                                   cboModalidadeBCICMSSimples, _
                                                   txtPorcentagemReducaoBCICMSSimples, _
                                                   txtAliquotaICMSSimples, _
                                                   cboModalidadeBCICMSSTSimples, _
                                                   txtIVASimples, _
                                                   txtPorcentagemReducaoBCICMSSTSimples, _
                                                   txtBaseCalculoICMSSTSimples, _
                                                   txtAliquotaICMSSTSimples, _
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
                                                   txtAliquotaIOF, _
                                                   txtAliquotaII, _
                                                   cboCodigoEnquadramento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboCodigo, lblCodigo) = False Then
                tabProduto.SelectedTab = pagDados
                cboCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código EAN
            If txtCodigoEAN.Text.Trim <> "" Then
                If ValidaCampo(txtCodigoEAN, lblCodigoEAN, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagDados
                    txtCodigoEAN.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - CFOP
            If cboCFOP.Enabled = True Then
                If ValidaCampo(cboCFOP, lblCFOP) = False Then
                    tabProduto.SelectedTab = pagDados
                    cboCFOP.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Incide no Valor Total da Nota Fiscal
            If cboIncideValorTotalNF.Enabled = True Then
                If ValidaCampo(cboIncideValorTotalNF, lblIncideValorTotalNF) = False Then
                    tabProduto.SelectedTab = pagDados
                    cboIncideValorTotalNF.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - NCM
            If cboNCM.Enabled = True Then
                If ValidaCampo(cboNCM, lblNCM) = False Then
                    tabProduto.SelectedTab = pagDados
                    cboNCM.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            'If oRowNFReferenciada.Count = 0 Then
            '    If txtQuantidade.Value <= 0 Then
            '        frmMain.errInfo.SetError(lblQuantidade, "A Quantidade deve ser Maior que 0 (Zero).")
            '        tabMain.SelectedTab = pagDados
            '        txtQuantidade.Focus()
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedida.Enabled = True Then
                If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then
                    tabProduto.SelectedTab = pagDados
                    cboUnidadeMedida.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            'If oRowNFReferenciada.Count = 0 Then
            '    If txtValorUnitario.Value <= 0 Then
            '        frmMain.errInfo.SetError(lblValorUnitario, "O Valor Unitário deve ser Maior que 0 (Zero).")
            '        tabMain.SelectedTab = pagDados
            '        txtValorUnitario.Focus()
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Selecionado o Campo DI
            If sUFDestinatario = "EX" And iCodigoTipoDocumentoFiscal = CInt(TipoDocumentoFiscal.Entrada) Then
                If ValidaCampo(cboNumeroDI, lblNumeroDI) = False Then
                    tabProduto.SelectedTab = pagDados
                    cboNumeroDI.Focus()
                    Exit Function
                End If

                'Valida NCM
                If oClsFatEmissaoNFeItem.ValidaNCM(lCodigoEmissaoCapa, _
                                                   cboNCM.SelectedValue, _
                                                   cboNumeroDI.SelectedValue) = False Then
                    frmMain.errInfo.SetError(lblNCM, "O NCM informado não está presente na Adição desta DI. Informe o NCM correto ou cadastre uma Adição para este NCM.")
                    tabProduto.SelectedTab = pagDados
                    cboNCM.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Código Exportador
                If ValidaCampo(txtCodigoFabricante, lblCodigoFabricante, TipoCampo.texto) = False Then
                    tabProduto.SelectedTab = pagDados
                    txtCodigoFabricante.Focus()
                    Exit Function
                End If

            End If

            'Caso Empresa do Regime Normal
            If goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroReal) Or goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroPresumido) Then

                'Verifica se foi Selecionado o Campo - Origem do Item
                If ValidaCampo(cboOrigemItem, lblOrigemItem) = False Then
                    tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                    cboOrigemItem.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado a Situação Tributária do ICMS            
                If ValidaCampo(cboSituacaoTributariaICMS, lblSituacaoTributariaICMS) = False Then
                    tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                    cboSituacaoTributariaICMS.Focus()
                    Exit Function
                End If

                'Verifica se o Item possui Fórmula de BC ICMS
                Dim sMensagem As String
                sMensagem = oClsFatEmissaoNFeItem.ValidaItem(cboSituacaoTributariaICMS.SelectedValue, _
                                                             cboCFOP.SelectedValue)
                If sMensagem.Trim <> "" Then
                    frmMain.errInfo.SetError(lblCFOP, sMensagem)
                    tabProduto.SelectedTab = pagDados
                    cboCFOP.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado a Modalidade da Base de Calculo do ICMS
                If cboModalidadeBCICMS.Enabled = True Then
                    If ValidaCampo(cboModalidadeBCICMS, lblModalidadeBCICMS) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                        cboModalidadeBCICMS.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - % Red. BC ICMS
                If txtPorcentagemReducaoBCICMS.Enabled = True Then
                    If ValidaCampo(txtPorcentagemReducaoBCICMS, lblPorcentagemReducaoBCICMS, False) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                        txtPorcentagemReducaoBCICMS.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Alíquota do ICMS
                If txtAliquotaICMS.Enabled = True Then
                    If ValidaCampo(txtAliquotaICMS, lblAliquotaICMS, False) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMS
                        txtAliquotaICMS.Focus()
                        Exit Function
                    End If
                End If

            Else

                'Verifica se foi Selecionado o Campo - Origem do Item
                If ValidaCampo(cboOrigemItemSimples, lblOrigemItemSimples) = False Then
                    tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                    cboOrigemItemSimples.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado a Situação Tributária do ICMS SIMPLES
                If ValidaCampo(cboSituacaoTributariaICMSSimples, lblSituacaoTributariaICMSSimples) = False Then
                    tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                    cboSituacaoTributariaICMSSimples.Focus()
                    Exit Function
                End If

                'Verifica se o Item possui Fórmula de BC ICMS
                Dim sMensagem As String
                sMensagem = oClsFatEmissaoNFeItem.ValidaItem(cboSituacaoTributariaICMSSimples.SelectedValue, _
                                                             cboCFOP.SelectedValue)
                If sMensagem.Trim <> "" Then
                    frmMain.errInfo.SetError(lblCFOP, sMensagem)
                    tabProduto.SelectedTab = pagDados
                    cboCFOP.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado a Modalidade da Base de Calculo do ICMS SIMPLES
                'If cboModalidadeBCICMSSimples.Enabled = True Then
                '    If ValidaCampo(cboModalidadeBCICMSSimples, lblModalidadeBCICMSSimples) = False Then
                '        tabMain.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                '        cboModalidadeBCICMSSimples.Focus()
                '        Exit Function
                '    End If
                'End If

                'Verifica se foi Preenchido o Campo - % Red. BC ICMS Simples
                If txtPorcentagemReducaoBCICMSSimples.Enabled = True Then
                    If ValidaCampo(txtPorcentagemReducaoBCICMSSimples, lblPorcentagemReducaoBCICMSSimples, False) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                        txtPorcentagemReducaoBCICMSSimples.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Alíquota do ICMS Simples
                If txtAliquotaICMSSimples.Enabled = True Then
                    If ValidaCampo(txtAliquotaICMSSimples, lblAliquotaICMSSimples, False) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagICMSSimples
                        txtAliquotaICMSSimples.Focus()
                        Exit Function
                    End If
                End If

            End If

            'Valida Dados do IPI
            If bItemProducao = True Or cboSituacaoTributariaIPI.SelectedIndex > -1 Or sUFDestinatario = "EX" Then

                'Verifica se foi Selecionado o Campo - Situação Tributária do IPI
                If ValidaCampo(cboSituacaoTributariaIPI, lblSituacaoTributariaIPI) = False Then
                    tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagIPI
                    cboSituacaoTributariaIPI.Focus()
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Tipo de Calculo IPI
                If cboTipoCalculoIPI.Enabled = True Then
                    If ValidaCampo(cboTipoCalculoIPI, lblTipoCalculoIPI) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagIPI
                        cboTipoCalculoIPI.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Base de Cálculo do IPI
                If txtBaseCalculoIPI.Enabled = True Then
                    If ValidaCampo(txtBaseCalculoIPI, lblBaseCalculoIPI, False) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagIPI
                        txtBaseCalculoIPI.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Alíquota
                If txtAliquotaIPI.Enabled = True Then
                    If ValidaCampo(txtAliquotaIPI, lblAliquotaIPI, False) = False Then
                        tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagIPI
                        txtAliquotaIPI.Focus()
                        Exit Function
                    End If
                End If

            End If

            'Verifica se foi Selecionado a Situação Tributária do PIS
            If ValidaCampo(cboSituacaoTributariaPIS, lblSituacaoTributariaPIS) = False Then
                tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagPIS
                cboSituacaoTributariaPIS.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Base de Cálculo do PIS
            If txtBaseCalculoPIS.Enabled = True Then
                If ValidaCampo(txtBaseCalculoPIS, lblBaseCalculoPIS, False) = False Then
                    tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagPIS
                    txtBaseCalculoPIS.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado a Situação Tributária do COFINS
            If ValidaCampo(cboSituacaoTributariaCOFINS, lblSituacaoTributariaCOFINS) = False Then
                tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagCOFINS
                cboSituacaoTributariaCOFINS.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Base de Cálculo do COFINS
            If txtBaseCalculoCOFINS.Enabled = True Then
                If ValidaCampo(txtBaseCalculoCOFINS, lblBaseCalculoCOFINS, False) = False Then
                    tabProduto.SelectedTab = pagTributos : tabTributo.SelectedTab = pagCOFINS
                    txtBaseCalculoCOFINS.Focus()
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

#Region "::: ICMS :::"

    Private Sub SaveItemImpostoICMS()

        Try

            'Seta Valores do Item
            oClsFatEmissaoNFeItem.CodigoOrigemItem = cboOrigemItem.SelectedValue
            oClsFatEmissaoNFeItem.CodigoSituacaoTributariaICMS = IIf(cboSituacaoTributariaICMS.SelectedIndex = -1, -1, cboSituacaoTributariaICMS.SelectedValue)
            oClsFatEmissaoNFeItem.SituacaoTributariaICMS = cboSituacaoTributariaICMS.SelectedValue
            oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMS = IIf(cboModalidadeBCICMS.Enabled = False, -1, cboModalidadeBCICMS.SelectedValue)
            oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMS = IIf(txtPorcentagemReducaoBCICMS.Enabled = False, -1, txtPorcentagemReducaoBCICMS.Value)
            oClsFatEmissaoNFeItem.BaseCalculoICMS = txtBaseCalculoICMS.Value
            oClsFatEmissaoNFeItem.AliquotaICMS = IIf(txtAliquotaICMS.Enabled = False, -1, txtAliquotaICMS.Value)
            oClsFatEmissaoNFeItem.ValorICMS = txtValorICMS.Value
            oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSST = IIf(cboModalidadeBCICMSST.Enabled = False, -1, cboModalidadeBCICMSST.SelectedValue)
            oClsFatEmissaoNFeItem.IVA = IIf(txtIVA.Enabled = False, -1, txtIVA.Value)
            oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSST = IIf(txtPorcentagemReducaoBCICMSST.Enabled = False, -1, txtPorcentagemReducaoBCICMSST.Value)
            oClsFatEmissaoNFeItem.BaseCalculoICMSST = IIf(txtBaseCalculoICMSST.Enabled = False, -1, txtBaseCalculoICMSST.Value)
            oClsFatEmissaoNFeItem.AliquotaICMSST = IIf(txtAliquotaICMSST.Enabled = False, -1, txtAliquotaICMSST.Value)
            oClsFatEmissaoNFeItem.ValorICMSST = 0

            'Adiciona Item
            oClsFatEmissaoNFeItem.InsertImpostoICMS()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

#End Region

#Region "::: ICMS SIMPLES :::"

    Private Sub SaveItemImpostoICMSSimples()

        Try

            'Seta Valores do Item
            oClsFatEmissaoNFeItem.CodigoOrigemItemSimples = cboOrigemItemSimples.SelectedValue
            oClsFatEmissaoNFeItem.CodigoSituacaoTributariaICMSSimples = IIf(cboSituacaoTributariaICMSSimples.SelectedIndex = -1, -1, cboSituacaoTributariaICMSSimples.SelectedValue)
            oClsFatEmissaoNFeItem.SituacaoTributariaICMSSimples = cboSituacaoTributariaICMSSimples.Text.Trim
            oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSSimples = IIf(cboModalidadeBCICMSSimples.Enabled = False, -1, cboModalidadeBCICMSSimples.SelectedValue)
            oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSSimples = IIf(txtPorcentagemReducaoBCICMSSimples.Enabled = False, -1, txtPorcentagemReducaoBCICMSSimples.Value)
            oClsFatEmissaoNFeItem.BaseCalculoICMSSimples = 0
            oClsFatEmissaoNFeItem.AliquotaICMSSimples = IIf(txtAliquotaICMSSimples.Enabled = False, -1, txtAliquotaICMSSimples.Value)
            oClsFatEmissaoNFeItem.ValorICMSSimples = 0
            oClsFatEmissaoNFeItem.ModalidadeBaseCalculoICMSSTSimples = IIf(cboModalidadeBCICMSSTSimples.Enabled = False, -1, IIf(cboModalidadeBCICMSSTSimples.SelectedIndex = -1, -1, cboModalidadeBCICMSSTSimples.SelectedValue))
            oClsFatEmissaoNFeItem.IVASimples = IIf(txtIVASimples.Enabled = False, -1, txtIVASimples.Value)
            oClsFatEmissaoNFeItem.ReducaoBaseCalculoICMSSTSimples = IIf(txtPorcentagemReducaoBCICMSSTSimples.Enabled = False, -1, txtPorcentagemReducaoBCICMSSTSimples.Value)
            oClsFatEmissaoNFeItem.BaseCalculoICMSSTSimples = IIf(txtBaseCalculoICMSSTSimples.Enabled = False, -1, txtBaseCalculoICMSSTSimples.Value)
            oClsFatEmissaoNFeItem.AliquotaICMSSTSimples = IIf(txtAliquotaICMSSTSimples.Enabled = False, -1, txtAliquotaICMSSTSimples.Value)
            oClsFatEmissaoNFeItem.ValorICMSSTSimples = 0

            'Adiciona Item
            oClsFatEmissaoNFeItem.InsertImpostoICMSSimples()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ICMS PARTILHA :::"

    Private Sub SaveItemImpostoICMSPartilha()

        Try

            'Seta Valores do Item
            oClsFatEmissaoNFeItem.BaseCalculoICMSPartilha = txtBaseCalculoICMSPartilha.Value
            oClsFatEmissaoNFeItem.PercentualDestinoICMSPartilha = txtPercentualICMSDestino.Value
            oClsFatEmissaoNFeItem.PercentualFCPICMSPartilha = txtPercentualFCPICMSPartilha.Value
            oClsFatEmissaoNFeItem.PercentualInterestadualICMSPartilha = txtPercentualICMSInterestadual.Value
            oClsFatEmissaoNFeItem.PercentualPartilhaICMSPartilha = txtPercentualICMSPartilha.Value
            oClsFatEmissaoNFeItem.ValorDestinoICMSPartilha = txtValorICMSDestino.Value
            oClsFatEmissaoNFeItem.ValorFCPICMSPartilha = txtValorFCP.Value
            oClsFatEmissaoNFeItem.ValorRemetenteICMSPartilha = txtValorICMSRemetente.Value

            'Adiciona Item
            oClsFatEmissaoNFeItem.InsertImpostoICMSPartilha()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoICMSPartilha()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtBaseCalculoICMSPartilha.Value = 0
            txtPercentualFCPICMSPartilha.Value = 0
            txtPercentualICMSDestino.Value = 0
            txtPercentualICMSInterestadual.Value = 0
            txtPercentualICMSPartilha.Value = 0
            txtValorFCP.Value = 0
            txtValorICMSDestino.Value = 0
            txtValorICMSRemetente.Value = 0


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadICMSPartilha()

        Try

            'Seta Valor
            oClsFatEmissaoNFeItem.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oClsFatEmissaoNFeItem.CodigoEmissaoItem = iCodigoEmissaoItem

            'Carrega Formulário
            Call oClsFatEmissaoNFeItem.LoadDadosICMSPartilha(txtBaseCalculoICMSPartilha, _
                                                             txtPercentualFCPICMSPartilha, _
                                                             txtPercentualICMSDestino, _
                                                             txtPercentualICMSInterestadual, _
                                                             txtPercentualICMSPartilha, _
                                                             txtValorFCP, _
                                                             txtValorICMSDestino, _
                                                             txtValorICMSRemetente)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function ValidacaoPartilha() As Boolean
        Try

            'Seta Retorno da Função
            ValidacaoPartilha = False

            'valida os camposdo icms partilha
            If sUFDestinatario <> "SP" Then
                If ValidaCampo(txtBaseCalculoICMSPartilha, lblBaseCalculoICMSPartilha, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtBaseCalculoICMSPartilha.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtPercentualFCPICMSPartilha, lblPercentualFCPICMSPartilha, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtPercentualFCPICMSPartilha.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtPercentualICMSDestino, lblPercentualICMSDestino, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtPercentualICMSDestino.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtPercentualICMSInterestadual, lblPercentualICMSInterestadual, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtPercentualICMSInterestadual.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtPercentualICMSPartilha, lblPercentualICMSPartilha, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtPercentualICMSPartilha.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtValorFCP, lblValorFCP, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtValorFCP.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtValorICMSDestino, lblValorICMSDestino, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtValorICMSDestino.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtValorICMSRemetente, lblValorICMSRemetente, TipoCampo.numero) = False Then
                    tabProduto.SelectedTab = pagICMSPartilha : tabTributo.SelectedTab = pagICMSPartilha
                    txtValorICMSRemetente.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoPartilha = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: IPI :::"

    Private Sub SaveItemImpostoIPI()

        Try

            'Seta Valores do Item
            oClsFatEmissaoNFeItem.SituacaoTributariaIPI = cboSituacaoTributariaIPI.SelectedValue
            oClsFatEmissaoNFeItem.TipoCalculoIPI = IIf(cboTipoCalculoIPI.SelectedIndex = -1, -1, cboTipoCalculoIPI.SelectedValue)
            oClsFatEmissaoNFeItem.BaseCalculoIPI = txtBaseCalculoIPI.Value
            oClsFatEmissaoNFeItem.AliquotaIPI = txtAliquotaIPI.Value
            oClsFatEmissaoNFeItem.QuantidadeTotalUnidadePadraoIPI = txtQuantidadeIPI.Value
            oClsFatEmissaoNFeItem.ValorUnidadeIPI = txtValorUnidadeIPI.Value
            oClsFatEmissaoNFeItem.ValorIPI = txtValorIPI.Value
            oClsFatEmissaoNFeItem.CodigoEnquadramentoIPI = cboCodigoEnquadramento.SelectedValue

            'Adiciona Item
            oClsFatEmissaoNFeItem.InsertImpostoIPI()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

#End Region

#Region "::: PIS :::"

    Private Sub SaveItemImpostoPIS()

        Try

            'Seta Valores do Item
            oClsFatEmissaoNFeItem.CodigoSituacaoTributariaPIS = cboSituacaoTributariaPIS.SelectedValue
            oClsFatEmissaoNFeItem.SituacaoTributariaPIS = cboSituacaoTributariaPIS.Text.Trim
            oClsFatEmissaoNFeItem.TipoCalculoPIS = IIf(cboTipoCalculoPIS.SelectedIndex = -1, IIf(txtBaseCalculoPIS.Enabled = True, TipoCalculoImposto.Percentual, TipoCalculoImposto.Valor), cboTipoCalculoPIS.SelectedValue)
            oClsFatEmissaoNFeItem.BaseCalculoPIS = txtBaseCalculoPIS.Value
            oClsFatEmissaoNFeItem.AliquotaPorcentagemPIS = txtAliquotaPercentualPIS.Value
            oClsFatEmissaoNFeItem.QuantidadeVendidaPIS = txtQuantidadeVendidaPIS.Value
            oClsFatEmissaoNFeItem.AliquotaValorPIS = txtAliquotaValorPIS.Value
            oClsFatEmissaoNFeItem.ValorPIS = txtValorPIS.Value
            oClsFatEmissaoNFeItem.TipoCalculoPISST = -1
            oClsFatEmissaoNFeItem.BaseCalculoPISST = 0
            oClsFatEmissaoNFeItem.AliquotaPorcentagemPISST = 0
            oClsFatEmissaoNFeItem.QuantidadeVendidaPISST = 0
            oClsFatEmissaoNFeItem.AliquotaValorPISST = 0
            oClsFatEmissaoNFeItem.ValorPISST = 0

            'Adiciona Item
            oClsFatEmissaoNFeItem.InsertImpostoPIS()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: COFINS :::"

    Private Sub SaveItemImpostoCOFINS()

        Try

            'Seta Valores do Item
            oClsFatEmissaoNFeItem.CodigoSituacaoTributariaCOFINS = cboSituacaoTributariaCOFINS.SelectedValue
            oClsFatEmissaoNFeItem.SituacaoTributariaCOFINS = cboSituacaoTributariaCOFINS.Text.Trim
            oClsFatEmissaoNFeItem.TipoCalculoCOFINS = IIf(cboTipoCalculoCOFINS.SelectedIndex = -1, IIf(txtBaseCalculoCOFINS.Enabled = True, TipoCalculoImposto.Percentual, TipoCalculoImposto.Valor), cboTipoCalculoCOFINS.SelectedValue)
            oClsFatEmissaoNFeItem.BaseCalculoCOFINS = txtBaseCalculoCOFINS.Value
            oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINS = txtAliquotaPercentualCOFINS.Value
            oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINS = txtQuantidadeVendidaCOFINS.Value
            oClsFatEmissaoNFeItem.AliquotaValorCOFINS = txtAliquotaValorCOFINS.Value
            oClsFatEmissaoNFeItem.ValorCOFINS = txtValorCOFINS.Value
            oClsFatEmissaoNFeItem.TipoCalculoCOFINSST = -1
            oClsFatEmissaoNFeItem.BaseCalculoCOFINSST = 0
            oClsFatEmissaoNFeItem.AliquotaPorcentagemCOFINSST = 0
            oClsFatEmissaoNFeItem.QuantidadeVendidaCOFINSST = 0
            oClsFatEmissaoNFeItem.AliquotaValorCOFINSST = 0
            oClsFatEmissaoNFeItem.ValorCOFINSST = 0

            'Adiciona Item
            oClsFatEmissaoNFeItem.InsertImpostoCOFINS()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: II :::"

    Private Sub SaveItemImpostoII()

        Try

            'Seta Valores do Item
            oClsFatEmissaoNFeItem.BaseCalculoII = txtBaseCalculoII.Value
            oClsFatEmissaoNFeItem.DespesaAduaneira = txtDespesaAduaneiraII.Value
            oClsFatEmissaoNFeItem.AliquotaIOF = txtAliquotaIOF.Value
            oClsFatEmissaoNFeItem.AliquotaII = txtAliquotaII.Value

            'Adiciona Item
            oClsFatEmissaoNFeItem.InsertImpostoII()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class

