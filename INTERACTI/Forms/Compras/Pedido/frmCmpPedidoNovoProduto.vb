Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class frmCmpPedidoNovoProduto

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrCmpPedido As New clsUsrCmpPedido
    Private lCodigoPedido As Long
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoPedido() As Long
        Get
            Return lCodigoPedido
        End Get
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public Property Formulario() As Integer
        Get
            Return iFormulario
        End Get
        Set(ByVal value As Integer)
            iFormulario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()
                Case Keys.Enter : Control_Enter(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(sender As Object, e As EventArgs)

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)

            cboProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(sender As Object, e As EventArgs)

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = LoadDescricao("sp_select_configuracao_interacti_texto " & goUsuario.iEmpresa & ",'formulario_find_produto_compra'")
            oForm.UsrControl = IIf(oForm.UsrControl = "", "usrFindItem", oForm.UsrControl)
            oForm.Titulo = "Procurar Produto"
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros            
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = ""
            sItemAtivoFixoFind = ""
            sItemEstoqueFind = ""
            sItemCompraFind = "S"
            sItemProducaoFind = ""
            bInserirProdutoFind = True
            sTipoFind = "COMPRAS"
            oComboBoxFind = cboProduto

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboProduto.SelectedIndex = -1 Then

                'Limpa Controles
                cboUnidadeMedidaProduto.SelectedIndex = -1

            Else

                'Carrega Dados do Item
                oClsUsrCmpPedido.LoadDadosProduto(cboProduto, _
                                                  cboUnidadeMedidaProduto, _
                                                  txtValorUnitarioProduto)


                txtDescricao.Text = LoadDescricao("sp_select_cadastro_basico_descricao_item " & cboProduto.SelectedValue & ", " & goUsuario.iEmpresa)

                'Carrega Combo
                LoadCombo(cboCentroGastoProduto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)
                LoadCombo(cboContaContabilProduto, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)

                'Calcula Valor Total
                CalculaValorTotal()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarUnidadeMedidaProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            cboUnidadeMedidaProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntregaProduto_Click(sender As Object, e As EventArgs) Handles btnDesmembrarPrevisaoEntregaProduto.Click

        Try

            'Limpa o Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeProduto, lblQuantidadeProduto, True) = False Then Exit Sub

            If IsNothing(dtpPrevisaoEntregaProduto.Tag) Then dtpPrevisaoEntregaProduto.Tag = ""

            'Desmembrar Entrega
            DesmembrarEntregaItem(dtpPrevisaoEntregaProduto, _
                                  cboProduto.Text, _
                                  txtQuantidadeProduto.Value)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub DesmembrarEntregaItem(ByVal dtpPrazoEntrega As CalendarCombo, _
                                      ByVal sItem As String, _
                                      ByVal dQuantidade As Double)

        Try

            'Váriavel - Formulário
            Dim oForm As New frmCmpPedidoItemDesmembrarEntrega

            'Seta Parâmetros
            oForm.Item = sItem
            oForm.dtpDataEntrega = dtpPrazoEntrega
            oForm.Quantidade = dQuantidade

            'Abre o Formulário
            oForm.ShowDialog(Me)

            'Verifica se NÃO foi Preenchido a Data de Entrega
            If dtpPrazoEntrega.Tag.ToString <> "" Then

                'Váriaveis Locais
                Dim sAuxiliar(1) As String
                Dim sDataPrevisaoEntrega() As String

                'Carrega Váriaveis
                sAuxiliar = dtpPrazoEntrega.Tag.ToString.Split("|")
                sDataPrevisaoEntrega = sAuxiliar(0).Split(";")

                'Seta Controle
                dtpPrazoEntrega.Value = sDataPrevisaoEntrega(0)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnCadastrarCentroGastoProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarCentroGastoProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            If cboProduto.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboCentroGastoProduto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)

            cboCentroGastoProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarCentroGastoProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarCentroGastoProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = "Procurar Centro de Gasto"
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboCentroGastoProduto

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboCentroGastoProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarContaContabilProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            If cboProduto.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboContaContabilProduto, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)

            cboContaContabilProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarContaContabilProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarContaContabilProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = "Procurar Conta Contábil"
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            'Seta Parametros
            oComboBoxFind = cboContaContabilProduto

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboContaContabilProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculoValorUnitarioDesconto(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescontoValorProduto.LostFocus, _
                                                                                                          txtDescontoPercentualProduto.LostFocus, _
                                                                                                          txtValorUnitarioProduto.LostFocus

        Try

            If txtValorUnitarioProduto.Value <= 0 Then
                txtDescontoPercentualProduto.Value = 0
                txtDescontoValorProduto.Value = 0
                txtValorUnitarioDesconto.Value = 0
                Exit Sub
            End If

            Select Case sender.Name

                Case txtDescontoPercentualProduto.Name

                    txtValorUnitarioDesconto.Value = txtValorUnitarioProduto.Value - (txtDescontoPercentualProduto.Value * txtValorUnitarioProduto.Value) / 100.0
                    txtDescontoValorProduto.Value = txtValorUnitarioProduto.Value - txtValorUnitarioDesconto.Value

                Case txtDescontoValorProduto.Name

                    txtValorUnitarioDesconto.Value = txtValorUnitarioProduto.Value - txtDescontoValorProduto.Value
                    txtDescontoPercentualProduto.Value = (txtDescontoValorProduto.Value / txtValorUnitarioProduto.Value) * 100.0

                Case txtValorUnitarioProduto.Name

                    If txtValorUnitarioProduto.Value > 0 Then
                        txtDescontoValorProduto.Value = (txtValorUnitarioProduto.Value * txtDescontoPercentualProduto.Value) / 100.0
                        txtValorUnitarioDesconto.Value = txtValorUnitarioProduto.Value - ((txtValorUnitarioProduto.Value * txtDescontoPercentualProduto.Value) / 100.0)
                    End If

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaValorTotal() Handles txtQuantidadeProduto.ValueChanged, _
                                            txtValorUnitarioDesconto.ValueChanged, _
                                            txtAliquotaICMSProduto.ValueChanged, _
                                            txtAliquotaPISCOFINSProduto.ValueChanged


        Try

            txtValorTotalProduto.Value = txtQuantidadeProduto.Value * txtValorUnitarioDesconto.Value

            txtAliquotaICMSProduto.Tag = (txtValorUnitarioDesconto.Value * txtAliquotaICMSProduto.Value) / 100.0
            txtAliquotaPISCOFINSProduto.Tag = (txtValorUnitarioDesconto.Value * txtAliquotaPISCOFINSProduto.Value) / 100.0

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaIPI() Handles txtValorTotalProduto.ValueChanged, _
                                     txtAliquotaIPIProduto.ValueChanged

        Try

            If txtAliquotaIPIProduto.Value > 0 Then
                txtValorTotalIPI.Value = txtValorTotalProduto.Value + (txtAliquotaIPIProduto.Value * txtValorTotalProduto.Value) / 100.0
                txtAliquotaIPIProduto.Tag = (txtAliquotaIPIProduto.Value * txtValorUnitarioDesconto.Value) / 100.0
            Else
                txtValorTotalIPI.Value = txtValorTotalProduto.Value
                txtAliquotaIPIProduto.Tag = 0
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(sender As Object, e As EventArgs) Handles btnInserirProduto.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFindGrupoItem_Click(sender As Object, e As EventArgs) Handles btnFindGrupoItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"

            'Seta Parametros
            oComboBoxFind = cboProduto
            oComboBoxFindGrupoItemProduto = cboGrupoItemCompras

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboGrupoItemCompras.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox            
            LoadCombo(cboOrdemProducao, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa)
            LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null, null, -1")
            LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            LoadCombo(cboGrupoItemCompras, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

            dtpPrevisaoEntregaProduto.Value = Now

            cboGrupoItemCompras.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboGrupoItemCompras, lblGrupoItem) = False Then Return False
            If ValidaCampo(cboProduto, lblProduto) = False Then Return False
            If ValidaCampo(txtQuantidadeProduto, lblQuantidadeProduto, True) = False Then Return False

            'Verifica se a Quantidade Parcial está correta
            Dim sAuxiliar(1) As String
            Dim sDataPrevisaoEntrega() As String
            Dim sQuantidade() As String
            If dtpPrevisaoEntregaProduto.Tag <> "" Then
                sAuxiliar = dtpPrevisaoEntregaProduto.Tag.ToString.Split("|")
                sDataPrevisaoEntrega = sAuxiliar(0).Split(";")
                sQuantidade = sAuxiliar(1).Split(";")
                If sDataPrevisaoEntrega.Length = 1 Then
                    dtpPrevisaoEntregaProduto.Tag = dtpPrevisaoEntregaProduto.Value & "|" & txtQuantidadeProduto.Value
                Else
                    Dim dSomaQuantidade As Double = 0
                    Dim i As Integer
                    For i = 0 To UBound(sQuantidade)
                        dSomaQuantidade += sQuantidade(i)
                    Next i
                    If dSomaQuantidade <> txtQuantidadeProduto.Value Then
                        frmMain.errInfo.SetError(lblPrevisaoEntregaProduto, "A Quantidade do Produto é diferente da Quantidade Desmembrada.")
                        Return False
                    End If
                End If
            End If

            If ValidaCampo(cboUnidadeMedidaProduto, lblUnidadeMedidaProduto) = False Then Return False
            If ValidaCampo(txtValorUnitarioProduto, lblValorUnitarioProduto, True) = False Then Return False

            If txtDescontoPercentualProduto.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoPercentualProduto, "O Campo [DESCONTO (%)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoPercentualProduto.Focus()
                Return False
            End If

            'Verifica se foi Preenchido o Campo - Desconto Valor
            If txtDescontoValorProduto.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoValorProduto, "O Campo [DESCONTO (VALOR)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoValorProduto.Focus()
                Return False
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoProduto, lblCentroGastoProduto) = False Then
                    Return False
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilProduto, lblContaContabilProduto) = False Then
                    Return False
                End If
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sAuxiliar(1) As String
            Dim iCodigoPedidoItem As Integer = -1

            'Seta Váriavel
            If dtpPrevisaoEntregaProduto.Tag <> "" And dtpPrevisaoEntregaProduto.Tag <> "|" Then
                sAuxiliar = dtpPrevisaoEntregaProduto.Tag.ToString.Split("|")
            Else
                sAuxiliar(0) = dtpPrevisaoEntregaProduto.Value
                sAuxiliar(1) = txtQuantidadeProduto.Value
            End If

            oClsUsrCmpPedido.CodigoPedido = lCodigoPedido

            oClsUsrCmpPedido.InsertProduto(cboProduto.SelectedValue, _
                                           txtComplementoProdutos.Text.Trim, _
                                           0, _
                                           txtQuantidadeProduto.Value, _
                                           cboUnidadeMedidaProduto.SelectedValue, _
                                           False, _
                                           txtAliquotaIPIProduto.Value, _
                                           txtAliquotaIPIProduto.Tag, _
                                           True, _
                                           txtAliquotaICMSProduto.Value, _
                                           txtAliquotaICMSProduto.Tag, _
                                           True, _
                                           txtAliquotaPISCOFINSProduto.Value, _
                                           txtAliquotaPISCOFINSProduto.Tag, _
                                           txtValorUnitarioProduto.Value, _
                                           txtDescontoPercentualProduto.Value, _
                                           txtDescontoValorProduto.Value, _
                                           IIf(cboCentroGastoProduto.SelectedIndex = -1, -1, cboCentroGastoProduto.SelectedValue), _
                                           IIf(cboContaContabilProduto.SelectedIndex = -1, "", cboContaContabilProduto.SelectedValue), _
                                           txtRCItem.Text, _
                                           txtOMItem.Text, _
                                           sAuxiliar(0).Split(";"), _
                                           sAuxiliar(1).Split(";"), _
                                           txtEspecificacoes.Text, _
                                           cboOrdemProducao.Text, _
                                           cboOrdemProducao.SelectedValue, _
                                           "", _
                                           cboGrupoItemCompras.SelectedValue)

            'Informa o Usuário sobre o sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroInserido)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class