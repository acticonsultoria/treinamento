Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class frmCmpPedidoNovoServico

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

    Private Sub btnCadastrarUnidadeMedidaProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            cboUnidadeMedida.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntregaProduto_Click(sender As Object, e As EventArgs) Handles btnDesmembrarPrevisaoEntrega.Click

        Try

            'Limpa o Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then Exit Sub

            If IsNothing(dtpPrevisaoEntrega.Tag) Then dtpPrevisaoEntrega.Tag = ""

            'Desmembrar Entrega
            DesmembrarEntregaItem(dtpPrevisaoEntrega, _
                                  cboServico.Text, _
                                  txtQuantidade.Value)

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

    Private Sub btnCadastrarCentroGastoProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            If cboServico.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)

            cboCentroGasto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarCentroGastoProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = "Procurar Centro de Gasto"
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboCentroGasto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            If cboServico.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)

            cboContaContabil.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarContaContabilProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = "Procurar Conta Contábil"
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)

            'Seta Parametros
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboContaContabil.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculoValorUnitarioDesconto(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescontoValor.LostFocus, _
                                                                                                          txtDescontoPercentual.LostFocus, _
                                                                                                          txtValorUnitario.LostFocus

        Try

            If txtValorUnitario.Value <= 0 Then
                txtDescontoPercentual.Value = 0
                txtDescontoValor.Value = 0
                txtValorUnitarioDesconto.Value = 0
                Exit Sub
            End If

            Select Case sender.Name

                Case txtDescontoPercentual.Name

                    txtValorUnitarioDesconto.Value = txtValorUnitario.Value - (txtDescontoPercentual.Value * txtValorUnitario.Value) / 100.0
                    txtDescontoValor.Value = txtValorUnitario.Value - txtValorUnitarioDesconto.Value

                Case txtDescontoValor.Name

                    txtValorUnitarioDesconto.Value = txtValorUnitario.Value - txtDescontoValor.Value
                    txtDescontoPercentual.Value = (txtDescontoValor.Value / txtValorUnitario.Value) * 100.0

                Case txtValorUnitario.Name

                    If txtValorUnitario.Value > 0 Then
                        txtDescontoValor.Value = (txtValorUnitario.Value * txtDescontoPercentual.Value) / 100.0
                        txtValorUnitarioDesconto.Value = txtValorUnitario.Value - ((txtValorUnitario.Value * txtDescontoPercentual.Value) / 100.0)
                    End If

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaValorTotal() Handles txtQuantidade.ValueChanged, _
                                            txtValorUnitarioDesconto.ValueChanged

        Try

            txtValorTotal.Value = txtQuantidade.Value * txtValorUnitarioDesconto.Value

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaValorTotalImpostos() Handles txtValorTotal.ValueChanged, _
                                                    txtAliquotaISS.ValueChanged, _
                                                    txtAliquotaPISCOFINS.ValueChanged, _
                                                    txtAliquotaIR.ValueChanged, _
                                                    txtAliquotaINSS.ValueChanged, _
                                                    txtAliquotaCSLL.ValueChanged

        Try

            txtValorTotalImposto.Value = txtValorTotal.Value

            txtAliquotaISS.Tag = (txtValorUnitarioDesconto.Value * txtAliquotaISS.Value) / 100.0
            txtAliquotaPISCOFINS.Tag = (txtValorUnitarioDesconto.Value * txtAliquotaPISCOFINS.Value) / 100.0
            txtAliquotaCSLL.Tag = (txtValorUnitarioDesconto.Value * txtAliquotaCSLL.Value) / 100.0
            txtAliquotaINSS.Tag = (txtValorUnitarioDesconto.Value * txtAliquotaINSS.Value) / 100.0
            txtAliquotaIR.Tag = (txtValorUnitarioDesconto.Value * txtAliquotaIR.Value) / 100.0

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

    Private Sub btnCadastrarServico_Click(sender As Object, e As EventArgs)

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadServico")

            'Carrega Combo            
            LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))

            cboServico.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarServico_Click(sender As Object, e As EventArgs) Handles btnProcurarServico.Click

        Try

            ''Abre Formulário de Cadastro
            'Dim oForm As New frmCadBasico
            'oForm.UsrControl = "usrFindItem"
            'oForm.Titulo = "Procurar Serviço"
            'oForm.Tamanho = True
            'oForm.Text = "Procurar Serviço"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"

            'Seta Parametros
            oComboBoxFind = cboServico
            oComboBoxFindGrupoItemProduto = cboGrupoItemCompras

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboServico.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboServico.SelectedIndex = -1 Then
                'Limpa Controle
                txtDescricao.Text = ""
            Else
                'Carrega Controle
                txtDescricao.Text = LoadDescricao("sp_select_cadastro_basico_descricao_item " & cboServico.SelectedValue & ", " & goUsuario.iEmpresa)

                'Carrega Combo
                Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)
                Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null, null, -1")
            LoadCombo(cboGrupoItemCompras, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            dtpPrevisaoEntrega.Value = Now

            cboServico.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboServico, lblServico) = False Then Return False
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then Return False

            'Verifica se a Quantidade Parcial está correta
            Dim sAuxiliar(1) As String
            Dim sDataPrevisaoEntrega() As String
            Dim sQuantidade() As String
            If dtpPrevisaoEntrega.Tag <> "" Then
                sAuxiliar = dtpPrevisaoEntrega.Tag.ToString.Split("|")
                sDataPrevisaoEntrega = sAuxiliar(0).Split(";")
                sQuantidade = sAuxiliar(1).Split(";")
                If sDataPrevisaoEntrega.Length = 1 Then
                    dtpPrevisaoEntrega.Tag = dtpPrevisaoEntrega.Value & "|" & txtQuantidade.Value
                Else
                    Dim dSomaQuantidade As Double = 0
                    Dim i As Integer
                    For i = 0 To UBound(sQuantidade)
                        dSomaQuantidade += sQuantidade(i)
                    Next i
                    If dSomaQuantidade <> txtQuantidade.Value Then
                        frmMain.errInfo.SetError(lblPrevisaoEntrega, "A Quantidade do Produto é diferente da Quantidade Desmembrada.")
                        Return False
                    End If
                End If
            End If

            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then Return False
            If ValidaCampo(txtValorUnitario, lblValorUnitario, True) = False Then Return False

            If txtDescontoPercentual.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoPercentual, "O Campo [DESCONTO (%)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoPercentual.Focus()
                Return False
            End If

            'Verifica se foi Preenchido o Campo - Desconto Valor
            If txtDescontoValor.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoValor, "O Campo [DESCONTO (VALOR)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoValor.Focus()
                Return False
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGasto, lblCentroGasto) = False Then
                    Return False
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabil, lblContaContabil) = False Then
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
            If dtpPrevisaoEntrega.Tag <> "" And dtpPrevisaoEntrega.Tag <> "|" Then
                sAuxiliar = dtpPrevisaoEntrega.Tag.ToString.Split("|")
            Else
                sAuxiliar(0) = dtpPrevisaoEntrega.Value
                sAuxiliar(1) = txtQuantidade.Value
            End If

            oClsUsrCmpPedido.CodigoPedido = lCodigoPedido

            oClsUsrCmpPedido.InsertServico(cboServico.SelectedValue, _
                                           txtComplemento.Text.Trim, _
                                           txtQuantidade.Value, _
                                           cboUnidadeMedida.SelectedValue, _
                                           txtValorUnitario.Value, _
                                           txtDescontoValor.Value, _
                                           txtValorTotal.Value, _
                                           dtpPrevisaoEntrega.Value, _
                                           False, _
                                           txtAliquotaISS.Value, _
                                           txtAliquotaPISCOFINS.Value, _
                                           txtAliquotaINSS.Value, _
                                           txtAliquotaCSLL.Value, _
                                           txtAliquotaIR.Value, _
                                           IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                           IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                           sAuxiliar(0).Split(";"), _
                                           sAuxiliar(1).Split(";"), _
                                           "")

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