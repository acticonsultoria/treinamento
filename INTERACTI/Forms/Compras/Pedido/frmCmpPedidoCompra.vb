Imports Janus.Windows.GridEX

Public Class frmCmpPedidoCompra

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido
    Private oPedidoCompra As PedidoCompra

    Private iCodigoModalidadeFrete As Integer = -1
    Private iCodigoMoeda As Integer = -1
    Private dFatorCambial As Double = 0
    Private iCodigoTransportadora As Integer = -1
    Private iCodigoCondicaoPagamento As Integer = -1
    Private iCodigoFormaPagamento As Integer = -1
    Private dValorFrete As Double = 0
    Private dValorTotal As Double = 0
    Private dValorDesconto As Double = 0
    Private dValorICMS As Double = 0
    Private dValorIPI As Double = 0
    Private dValorFinal As Double = 0

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property PedidoCompra() As PedidoCompra
        Set(ByVal value As PedidoCompra)
            oPedidoCompra = value
        End Set
    End Property

    Public ReadOnly Property CodigoModalidadeFrete() As Integer
        Get
            Return iCodigoModalidadeFrete
        End Get
    End Property

    Public ReadOnly Property CodigoMoeda() As Integer
        Get
            Return iCodigoMoeda
        End Get
    End Property

    Public ReadOnly Property FatorCambial() As Double
        Get
            Return dFatorCambial
        End Get
    End Property

    Public ReadOnly Property CodigoTransportadora() As Integer
        Get
            Return iCodigoTransportadora
        End Get
    End Property

    Public ReadOnly Property CodigoCondicaoPagamento() As Integer
        Get
            Return iCodigoCondicaoPagamento
        End Get
    End Property

    Public ReadOnly Property CodigoFormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
    End Property

    Public ReadOnly Property ValorFrete() As Double
        Get
            Return dValorFrete
        End Get
    End Property

    Public ReadOnly Property ValorTotal() As Double
        Get
            Return dValorTotal
        End Get
    End Property

    Public ReadOnly Property ValorDesconto() As Double
        Get
            Return dValorDesconto
        End Get
    End Property

    Public ReadOnly Property ValorICMS() As Double
        Get
            Return dValorICMS
        End Get
    End Property

    Public ReadOnly Property ValorIPI() As Double
        Get
            Return dValorIPI
        End Get
    End Property

    Public ReadOnly Property ValorFinal() As Double
        Get
            Return dValorFinal
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoCompra_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmCmpPedidoCompra_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Seta Váriaveis
            iCodigoMoeda = -1
            iCodigoModalidadeFrete = -1
            dFatorCambial = 0
            iCodigoTransportadora = -1
            iCodigoCondicaoPagamento = -1
            iCodigoFormaPagamento = -1
            dValorFrete = 0
            dValorTotal = 0
            dValorDesconto = 0
            dValorICMS = 0
            dValorIPI = 0
            dValorFinal = 0

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Carrega Controles
                iCodigoModalidadeFrete = cboModalidadeFrete.SelectedValue
                iCodigoMoeda = cboMoeda.SelectedValue
                dFatorCambial = txtFatorCambial.Value
                iCodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
                iCodigoCondicaoPagamento = cboCondicaoPagamento.SelectedValue
                iCodigoFormaPagamento = cboFormaPagamento.SelectedValue
                dValorFrete = txtValorFrete.Value
                dValorTotal = txtValorTotal.Value
                dValorDesconto = txtValorDesconto.Value
                dValorICMS = txtValorICMS.Value
                dValorIPI = txtValorIPI.Value
                dValorFinal = txtValorFinal.Value

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoCompra_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ComprasCotacaoOrcamento, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete", False)
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento", False)

            'Váriaveis do Formulário
            iCodigoMoeda = -1
            iCodigoModalidadeFrete = -1
            dFatorCambial = 0
            iCodigoTransportadora = -1
            iCodigoCondicaoPagamento = -1
            iCodigoFormaPagamento = -1
            dValorFrete = 0
            dValorTotal = 0
            dValorDesconto = 0
            dValorICMS = 0
            dValorIPI = 0
            dValorFinal = 0

            'Carrega Váriaveis
            For Each oRow As GridEXRow In oPedidoCompra.oRow

                If iCodigoModalidadeFrete = -1 Then
                    iCodigoModalidadeFrete = IIf(IsDBNull(oRow.Cells("codigo_modalidade_frete").Value), -1, oRow.Cells("codigo_modalidade_frete").Value)
                ElseIf iCodigoModalidadeFrete <> IIf(IsDBNull(oRow.Cells("codigo_modalidade_frete").Value), -1, oRow.Cells("codigo_modalidade_frete").Value) Then
                    iCodigoModalidadeFrete = -2
                End If

                If iCodigoMoeda = -1 Then
                    iCodigoMoeda = IIf(IsDBNull(oRow.Cells("codigo_moeda").Value), -1, oRow.Cells("codigo_moeda").Value)
                ElseIf iCodigoMoeda <> IIf(IsDBNull(oRow.Cells("codigo_moeda").Value), -1, oRow.Cells("codigo_moeda").Value) Then
                    iCodigoMoeda = -2
                End If

                If dFatorCambial = 0 Then
                    dFatorCambial = IIf(IsDBNull(oRow.Cells("fator_cambial").Value), 0, oRow.Cells("fator_cambial").Value)
                ElseIf dFatorCambial <> IIf(IsDBNull(oRow.Cells("fator_cambial").Value), 0, oRow.Cells("fator_cambial").Value) Then
                    dFatorCambial = -2
                End If

                If iCodigoTransportadora = -1 Then
                    iCodigoTransportadora = IIf(IsDBNull(oRow.Cells("codigo_transportadora").Value), -1, oRow.Cells("codigo_transportadora").Value)
                ElseIf iCodigoTransportadora <> IIf(IsDBNull(oRow.Cells("codigo_transportadora").Value), -1, oRow.Cells("codigo_transportadora").Value) Then
                    iCodigoTransportadora = -2
                End If

                If iCodigoCondicaoPagamento = -1 Then
                    iCodigoCondicaoPagamento = IIf(IsDBNull(oRow.Cells("codigo_condicao_pagamento").Value), -1, oRow.Cells("codigo_condicao_pagamento").Value)
                ElseIf iCodigoCondicaoPagamento <> IIf(IsDBNull(oRow.Cells("codigo_condicao_pagamento").Value), -1, oRow.Cells("codigo_condicao_pagamento").Value) Then
                    iCodigoCondicaoPagamento = -2
                End If

                If iCodigoFormaPagamento = -1 Then
                    iCodigoFormaPagamento = IIf(IsDBNull(oRow.Cells("codigo_forma_pagamento").Value), -1, oRow.Cells("codigo_forma_pagamento").Value)
                ElseIf iCodigoFormaPagamento <> IIf(IsDBNull(oRow.Cells("codigo_forma_pagamento").Value), -1, oRow.Cells("codigo_forma_pagamento").Value) Then
                    iCodigoFormaPagamento = -2
                End If

                dValorFrete += oRow.Cells("valor_frete").Value
                dValorTotal += oRow.Cells("valor_total").Value
                dValorDesconto += oRow.Cells("valor_desconto").Value
                dValorICMS += oRow.Cells("valor_icms").Value
                dValorIPI += oRow.Cells("valor_ipi").Value
                dValorFinal += oRow.Cells("valor_final").Value

            Next

            'Seta Controles
            txtFornecedor.Text = oPedidoCompra.oRow(0).Cells("fornecedor").Value
            If iCodigoModalidadeFrete > -1 Then cboModalidadeFrete.SelectedValue = iCodigoModalidadeFrete
            If iCodigoMoeda > -1 Then cboMoeda.SelectedValue = iCodigoMoeda
            If iCodigoTransportadora > -1 Then cboTransportadora.SelectedValue = iCodigoTransportadora
            If iCodigoCondicaoPagamento > -1 Then cboCondicaoPagamento.SelectedValue = iCodigoCondicaoPagamento
            If iCodigoFormaPagamento > -1 Then cboFormaPagamento.SelectedValue = iCodigoFormaPagamento
            If dFatorCambial > -1 Then txtFatorCambial.Value = dFatorCambial
            txtValorFrete.Value = dValorFrete
            txtValorTotal.Value = dValorTotal
            txtValorDesconto.Value = dValorDesconto
            txtValorICMS.Value = dValorICMS
            txtValorIPI.Value = dValorIPI
            txtValorFinal.Value = dValorFinal

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Modalidade do Frete
            If ValidaCampo(cboModalidadeFrete, lblModalidadeFrete) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Moeda
            If ValidaCampo(cboMoeda, lblMoeda) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fator Cambial
            If ValidaCampo(txtFatorCambial, lblFatorCambial, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Condição de Pagamento
            If ValidaCampo(cboCondicaoPagamento, lblCondicaoPagamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma de Pagamento
            If ValidaCampo(cboFormaPagamento, lblFormaPagamento) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class