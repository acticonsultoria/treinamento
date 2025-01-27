Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo
Imports System.Math

Public Class frmCadProdutoPrecoVendaCalculadora

#Region "::: VÁRIAVEIS :::"

    Private lCodigoItem As Long
    Private dPrecoVenda As Double
    Private dPrecoMinimo As Double
    Private lCodigoAcordoComercial As Long
    Private iCodigoAcordoComercialItem As Integer
    Private iCodigoUsuarioItem As Integer
    Private sLiberacaoItem As String
    Private oClsCadProduto As New clsUsrCadProduto
    Private oDataEntrega As New Hashtable
    Private sSugestaoVenda As String
    Private oCurrentRow As GridEXRow
    Private sCodigoProduto As String
    Private dFatorConversao As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoProduto() As String
        Get
            Return sCodigoProduto
        End Get
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
    End Property

    Public Property CodigoItem() As Long
        Get
            Return lCodigoItem
        End Get
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public WriteOnly Property SugestaoVenda() As String
        Set(ByVal value As String)
            sSugestaoVenda = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmCadProdutoPrecoVendaCalculadora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter : Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadProdutoPrecoVendaCalculadora_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCliente.SelectedIndex <> -1 Then

                'Váriaveis Locais
                Dim oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio
                Dim sMunicipio As String = ""
                Dim sUF As String = ""
                Dim iCodigoDestinacao As Integer = -1

                'Carrega Dados do Parceiro de Negócio
                Call oClsCadParceiroNegocio.LoadDadosParceiroNegocioVenda(cboCliente.SelectedValue, _
                                                                          sMunicipio, _
                                                                          sUF, _
                                                                          iCodigoDestinacao)

                'Seta Controle
                txtMunicipioUF.Text = sMunicipio & " - " & sUF
                If iCodigoDestinacao <> -1 Then cboDestinacao.SelectedValue = iCodigoDestinacao

            Else

                'Seta Controle
                txtMunicipioUF.Text = ""
                cboDestinacao.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            If cboCodigoProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricao.Text = ""
                dFatorConversao = 0
                txtMarca.Text = ""
                txtQuantidadeEstoque.Value = 0
                txtEstoqueReservado.Value = 0
                txtPedidoCompraTransito.Value = 0
                lblEstoque.Text = "Estoque:"
                lblQuantidade.Text = "Quantidade:"
                lblQuantidadeUnidade.Text = "Quantidade:"
                lblPrecoVendaMedio.Text = "Preço Venda:"
                lblPrecoVendaUnidadeMedio.Text = "Preço Venda:"
                lblPrecoVendaTeorico.Text = "Preço Venda:"
                lblPrecoVendaUnidadeTeorico.Text = "Preço Venda:"
                lblCustoMedio.Text = "Preço Médio:"
                lblCustoTeorico.Text = "Custo Teórico:"
                txtCustoMedio.Value = 0
                txtCustoTeorico.Value = 0
                txtFatorConversao.Value = 0

            Else

                'Váriaveis Locais
                Dim sReferencia As String = ""
                Dim sDescricao As String = ""
                Dim dQuantidadeEstoque As Double = 0
                Dim sMarca As String = ""
                Dim sUnidadeMedidaVenda As String = ""
                Dim sUnidadeMedidaEstoque As String = ""
                Dim dCustoMedio As Double = 0
                Dim dCustoTeorico As Double = 0
                Dim sSugestaoVenda As String
                Dim dEstoqueReservado As Double = 0
                Dim dPedidoCompraTransito As Double = 0
                Dim dPrecoVendaMedio As Double = 0

                'Limpa Váriaveis
                dPrecoVenda = 0
                dPrecoMinimo = 0
                lCodigoAcordoComercial = -1
                iCodigoAcordoComercialItem = -1

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Dados do Produto
                Call oClsCadProduto.LoadDadosProduto(cboCliente.SelectedValue, _
                                                     sRevisaoGlobal, _
                                                     cboCodigoProduto.SelectedValue, _
                                                     sReferencia, _
                                                     sDescricao, _
                                                     sMarca, _
                                                     dQuantidadeEstoque, _
                                                     dCustoMedio, _
                                                     dCustoTeorico, _
                                                     dPrecoVenda, _
                                                     dPrecoMinimo, _
                                                     lCodigoAcordoComercial, _
                                                     iCodigoAcordoComercialItem, _
                                                     dFatorConversao, _
                                                     sUnidadeMedidaVenda, _
                                                     sUnidadeMedidaEstoque, _
                                                     sSugestaoVenda, _
                                                     dEstoqueReservado, _
                                                     dPedidoCompraTransito, _
                                                     dPrecoVendaMedio)

                'Carrega Controles
                txtDescricao.Text = sDescricao
                txtMarca.Text = sMarca
                txtFatorConversao.Value = dFatorConversao
                txtQuantidadeEstoque.Value = dQuantidadeEstoque / dFatorConversao
                txtEstoqueReservado.Value = dEstoqueReservado / dFatorConversao
                lblEstoque.Text = "Estoque " & sUnidadeMedidaVenda & ":"
                txtCustoMedio.Value = dPrecoVendaMedio * dFatorConversao
                txtCustoTeorico.Value = dCustoTeorico * dFatorConversao
                lblCustoMedio.Text = "Preço Médio " & sUnidadeMedidaVenda & ":"
                lblCustoTeorico.Text = "Custo Teórico " & sUnidadeMedidaVenda & ":"
                lblQuantidade.Text = "Quantidade " & sUnidadeMedidaVenda & ":"
                lblQuantidadeUnidade.Text = "Quantidade " & sUnidadeMedidaEstoque & ":"
                lblPrecoVendaMedio.Text = "Preço Venda " & sUnidadeMedidaVenda & ":"
                lblPrecoVendaUnidadeMedio.Text = "Preço Venda " & sUnidadeMedidaEstoque & ":"
                lblPrecoVendaTeorico.Text = "Preço Venda " & sUnidadeMedidaVenda & ":"
                lblPrecoVendaUnidadeTeorico.Text = "Preço Venda " & sUnidadeMedidaEstoque & ":"
                txtPedidoCompraTransito.Value = dPedidoCompraTransito

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub QuantidadeConverter(sender As Object, e As EventArgs) Handles txtQuantidade.ValueChanged, _
                                                                              txtQuantidadeUnidade.ValueChanged

        Try

            'Verifica se é para calcular o valor
            If sender.tag <> "" And IsNothing(sender.Tag) = False Then Exit Sub

            txtQuantidade.Tag = "A"
            txtQuantidadeUnidade.Tag = "A"

            Select Case sender.Name

                Case "txtQuantidade" : txtQuantidadeUnidade.Value = txtQuantidade.Value * dFatorConversao
                Case "txtQuantidadeUnidade" : txtQuantidade.Value = txtQuantidadeUnidade.Value / dFatorConversao

            End Select

            'Remove Evento
            txtQuantidade.Tag = ""
            txtQuantidadeUnidade.Tag = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalcularValorTeorico(sender As Object, e As EventArgs) Handles txtCustoTeorico.ValueChanged, _
                                                                               txtMargemTeorico.ValueChanged, _
                                                                               txtMarkupTeorico.ValueChanged, _
                                                                               txtGPTeorico.ValueChanged, _
                                                                               txtPrecoVendaTeorico.ValueChanged, _
                                                                               txtPrecoVendaUnidadeTeorico.ValueChanged

        Try

            'Verifica se é para calcular o valor
            If sender.tag <> "" And IsNothing(sender.Tag) = False Then Exit Sub

            'Váriaveis
            Dim dCustoTeorico As Double = IIf(IsNumeric(txtCustoTeorico.Value), txtCustoTeorico.Value, 0) / txtFatorConversao.Value
            Dim dMargem As Double = IIf(IsNumeric(txtMargemTeorico.Value), txtMargemTeorico.Value, 0)
            Dim dMarkup As Double = IIf(IsNumeric(txtMarkupTeorico.Value), txtMarkupTeorico.Value, 0)
            Dim dGP As Double = IIf(IsNumeric(txtGPTeorico.Value), txtGPTeorico.Value, 0)
            Dim dPrecoVenda As Double = 0
            If sender.name = "txtPrecoVendaUnidadeTeorico" Then
                dPrecoVenda = IIf(IsNumeric(txtPrecoVendaUnidadeTeorico.Value), txtPrecoVendaUnidadeTeorico.Value, 0)
            ElseIf sender.Name = "txtPrecoVendaTeorico" Then
                dPrecoVenda = Round(IIf(IsNumeric(txtPrecoVendaTeorico.Value), txtPrecoVendaTeorico.Value, 0) / dFatorConversao, 4)
            ElseIf txtPrecoVendaUnidadeTeorico.Value > 0 Then
                dPrecoVenda = IIf(IsNumeric(txtPrecoVendaUnidadeTeorico.Value), txtPrecoVendaUnidadeTeorico.Value, 0)
            Else
                dPrecoVenda = Round(IIf(IsNumeric(txtPrecoVendaTeorico.Value), txtPrecoVendaTeorico.Value, 0) / dFatorConversao, 4)
            End If

            'Remove Evento
            txtCustoTeorico.Tag = "A"
            txtMargemTeorico.Tag = "A"
            txtGPTeorico.Tag = "A"
            txtMarkupTeorico.Tag = "A"
            txtPrecoVendaTeorico.Tag = "A"
            txtPrecoVendaUnidadeTeorico.Tag = "A"

            Select Case sender.Name

                Case "txtCustoTeorico"
                    dPrecoVenda = dCustoTeorico + (dCustoTeorico * dMargem)
                    dMargem = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkup = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    txtMargemTeorico.Value = dMargem
                    txtGPTeorico.Value = dGP
                    txtMarkupTeorico.Value = dMarkup
                    txtPrecoVendaUnidadeTeorico.Value = dPrecoVenda
                    txtPrecoVendaTeorico.Value = dFatorConversao * dPrecoVenda

                Case "txtMargemTeorico"
                    dPrecoVenda = dCustoTeorico + (dCustoTeorico * dMargem)
                    dMarkup = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    txtGPTeorico.Value = dGP
                    txtMarkupTeorico.Value = dMarkup
                    txtPrecoVendaUnidadeTeorico.Value = dPrecoVenda
                    txtPrecoVendaTeorico.Value = dFatorConversao * dPrecoVenda

                Case "txtMarkupTeorico"
                    dPrecoVenda = dCustoTeorico * dMarkup
                    dMargem = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    txtMargemTeorico.Value = dMargem
                    txtGPTeorico.Value = dGP
                    txtPrecoVendaUnidadeTeorico.Value = dPrecoVenda
                    txtPrecoVendaTeorico.Value = dFatorConversao * dPrecoVenda

                Case "txtGPTeorico"
                    If dGP >= 1 Then txtGPTeorico.Value = 0.99 : dGP = 0.99
                    dPrecoVenda = dCustoTeorico / (1 - dGP)
                    dMargem = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkup = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    txtMargemTeorico.Value = dMargem
                    txtMarkupTeorico.Value = dMarkup
                    txtPrecoVendaUnidadeTeorico.Value = dPrecoVenda
                    txtPrecoVendaTeorico.Value = dFatorConversao * dPrecoVenda

                Case "txtPrecoVendaUnidadeTeorico"
                    dMargem = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkup = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    txtMargemTeorico.Value = dMargem
                    txtGPTeorico.Value = dGP
                    txtMarkupTeorico.Value = dMarkup
                    txtPrecoVendaTeorico.Value = dFatorConversao * dPrecoVenda

                Case "txtPrecoVendaTeorico"
                    dMargem = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkup = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    txtMargemTeorico.Value = dMargem
                    txtGPTeorico.Value = dGP
                    txtMarkupTeorico.Value = dMarkup
                    txtPrecoVendaUnidadeTeorico.Value = dPrecoVenda

            End Select

            'Remove Evento
            txtCustoTeorico.Tag = ""
            txtMargemTeorico.Tag = ""
            txtGPTeorico.Tag = ""
            txtMarkupTeorico.Tag = ""
            txtPrecoVendaTeorico.Tag = ""
            txtPrecoVendaUnidadeTeorico.Tag = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalcularValorMedio(sender As Object, e As EventArgs) Handles txtCustoMedio.ValueChanged, _
                                                                             txtMargemMedio.ValueChanged, _
                                                                             txtMarkupMedio.ValueChanged, _
                                                                             txtGPMedio.ValueChanged, _
                                                                             txtPrecoVendaMedio.ValueChanged, _
                                                                             txtPrecoVendaUnidadeMedio.ValueChanged

        Try

            'Verifica se é para calcular o valor
            If sender.tag <> "" And IsNothing(sender.Tag) = False Then Exit Sub

            'Váriaveis
            Dim dCustoMedio As Double = IIf(IsNumeric(txtCustoMedio.Value), txtCustoMedio.Value, 0) / txtFatorConversao.Value
            Dim dMargem As Double = IIf(IsNumeric(txtMargemMedio.Value), txtMargemMedio.Value, 0)
            Dim dMarkup As Double = IIf(IsNumeric(txtMarkupMedio.Value), txtMarkupMedio.Value, 0)
            Dim dGP As Double = IIf(IsNumeric(txtGPMedio.Value), txtGPMedio.Value, 0)
            Dim dPrecoVenda As Double = 0
            If sender.name = "txtPrecoVendaUnidadeMedio" Then
                dPrecoVenda = IIf(IsNumeric(txtPrecoVendaUnidadeMedio.Value), txtPrecoVendaUnidadeMedio.Value, 0)
            ElseIf sender.Name = "txtPrecoVendaMedio" Then
                dPrecoVenda = IIf(IsNumeric(txtPrecoVendaMedio.Value), txtPrecoVendaMedio.Value, 0) / dFatorConversao
            ElseIf txtPrecoVendaUnidadeMedio.Value > 0 Then
                dPrecoVenda = IIf(IsNumeric(txtPrecoVendaUnidadeMedio.Value), txtPrecoVendaUnidadeMedio.Value, 0)
            Else
                dPrecoVenda = IIf(IsNumeric(txtPrecoVendaMedio.Value), txtPrecoVendaMedio.Value, 0) / dFatorConversao
            End If

            'Remove Evento
            txtCustoMedio.Tag = "A"
            txtMargemMedio.Tag = "A"
            txtGPMedio.Tag = "A"
            txtMarkupMedio.Tag = "A"
            txtPrecoVendaMedio.Tag = "A"
            txtPrecoVendaUnidadeMedio.Tag = "A"

            Select Case sender.Name

                Case "txtCustoMedio"
                    dPrecoVenda = dCustoMedio + (dCustoMedio * dMargem)
                    dMargem = IIf(dCustoMedio > 0, (dPrecoVenda - dCustoMedio) / dCustoMedio, 0)
                    dMarkup = IIf(dCustoMedio > 0, (dPrecoVenda / dCustoMedio), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoMedio) / dPrecoVenda, 0)
                    txtMargemMedio.Value = dMargem
                    txtGPMedio.Value = dGP
                    txtMarkupMedio.Value = dMarkup
                    txtPrecoVendaUnidadeMedio.Value = dPrecoVenda
                    txtPrecoVendaMedio.Value = dFatorConversao * dPrecoVenda

                Case "txtMargemMedio"
                    dPrecoVenda = dCustoMedio + (dCustoMedio * dMargem)
                    dMarkup = IIf(dCustoMedio > 0, (dPrecoVenda / dCustoMedio), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoMedio) / dPrecoVenda, 0)
                    txtGPMedio.Value = dGP
                    txtMarkupMedio.Value = dMarkup
                    txtPrecoVendaUnidadeMedio.Value = dPrecoVenda
                    txtPrecoVendaMedio.Value = dFatorConversao * dPrecoVenda

                Case "txtMarkupMedio"
                    dPrecoVenda = dCustoMedio * dMarkup
                    dMargem = IIf(dCustoMedio > 0, (dPrecoVenda - dCustoMedio) / dCustoMedio, 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoMedio) / dPrecoVenda, 0)
                    txtMargemMedio.Value = dMargem
                    txtGPMedio.Value = dGP
                    txtPrecoVendaUnidadeMedio.Value = dPrecoVenda
                    txtPrecoVendaMedio.Value = dFatorConversao * dPrecoVenda

                Case "txtGPMedio"
                    If dGP >= 1 Then txtGPMedio.Value = 0.99 : dGP = 0.99
                    dPrecoVenda = dCustoMedio / (1 - dGP)
                    dMargem = IIf(dCustoMedio > 0, (dPrecoVenda - dCustoMedio) / dCustoMedio, 0)
                    dMarkup = IIf(dCustoMedio > 0, (dPrecoVenda / dCustoMedio), 0)
                    txtMargemMedio.Value = dMargem
                    txtMarkupMedio.Value = dMarkup
                    txtPrecoVendaUnidadeMedio.Value = dPrecoVenda
                    txtPrecoVendaMedio.Value = dFatorConversao * dPrecoVenda

                Case "txtPrecoVendaUnidadeMedio"
                    dMargem = IIf(dCustoMedio > 0, (dPrecoVenda - dCustoMedio) / dCustoMedio, 0)
                    dMarkup = IIf(dCustoMedio > 0, (dPrecoVenda / dCustoMedio), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoMedio) / dPrecoVenda, 0)
                    txtMargemMedio.Value = dMargem
                    txtGPMedio.Value = dGP
                    txtMarkupMedio.Value = dMarkup
                    txtPrecoVendaMedio.Value = dFatorConversao * dPrecoVenda

                Case "txtPrecoVendaMedio"
                    dMargem = IIf(dCustoMedio > 0, (dPrecoVenda - dCustoMedio) / dCustoMedio, 0)
                    dMarkup = IIf(dCustoMedio > 0, (dPrecoVenda / dCustoMedio), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoMedio) / dPrecoVenda, 0)
                    txtMargemMedio.Value = dMargem
                    txtGPMedio.Value = dGP
                    txtMarkupMedio.Value = dMarkup
                    txtPrecoVendaUnidadeMedio.Value = dPrecoVenda

            End Select

            'Remove Evento
            txtCustoMedio.Tag = ""
            txtMargemMedio.Tag = ""
            txtGPMedio.Tag = ""
            txtMarkupMedio.Tag = ""
            txtPrecoVendaMedio.Tag = ""
            txtPrecoVendaUnidadeMedio.Tag = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnEstoqueReservado_Click(sender As Object, e As EventArgs) Handles btnEstoqueReservado.Click

        Try

            'Verifica se foi Selecionado algum Produto
            If ValidaCampo(cboCodigoProduto, lblCodigo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim oForm As New frmVenPedidoItemAberto

            'Seta Parametros
            oForm.CodigoItem = cboCodigoProduto.SelectedValue
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnPedidoCompraTransito_Click(sender As Object, e As EventArgs) Handles btnPedidoCompraTransito.Click

        Try

            'Verifica se foi Selecionado algum Produto
            If ValidaCampo(cboCodigoProduto, lblCodigo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim oForm As New frmCmpQuantidadeAberto

            'Seta Parametros
            oForm.CodigoItem = cboCodigoProduto.SelectedValue
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAdicionarTeorico_Click(sender As Object, e As EventArgs) Handles btnAdicionarTeorico.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao("TEORICO") = True Then

                'Insere Registro na tb_ven_pedido_item
                Call Salvar("CUSTO TEÓRICO")

                'Fecha o Formulário
                Me.Dispose 

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAdicionarMedio_Click(sender As Object, e As EventArgs) Handles btnAdicionarMedio.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao("MEDIO") = True Then

                'Insere Registro na tb_ven_pedido_item
                Call Salvar("CUSTO MÉDIO")

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmembrarPrevisaoEntrega.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Seleciona o Campo - Produto
            If cboCodigoProduto.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(lblCodigo, "O Campo [Código] é obrigatório. Digite um valor para ele.")
                cboCodigoProduto.Focus()
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeUnidade, lblQuantidadeUnidade, True) = False Then
                Exit Sub
            End If

            'Desmembrar Entrega
            Call DesmembrarEntrega(cboCodigoProduto.Text & " - " & txtDescricao.Text, _
                                   txtQuantidadeUnidade.Value, _
                                   dtpPrevisaoEntregaProduto, _
                                   oDataEntrega)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadProdutoPrecoVendaCalculadora_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo - Produto
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            'Exibe somente as 7 primeiras Colunas
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto))
            Call LoadCombo(cboDestinacao, "sp_select_combo_static_destinacao", False)

            'Verifica Direito
            If sTelaVenda = "" Then
                btnAdicionarMedio.Visible = False
                btnAdicionarTeorico.Visible = False
            ElseIf sTelaVenda = "PEDIDO" Then
                btnAdicionarMedio.Visible = True : btnAdicionarMedio.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcInsert)
                btnAdicionarTeorico.Visible = True : btnAdicionarTeorico.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaProduto, gcInsert)
            ElseIf sTelaVenda = "ORCAMENTO" Then
                btnAdicionarMedio.Visible = True : btnAdicionarMedio.Enabled = VerificaDireito(Formulario.ComercialOrcamentoProduto, gcInsert)
                btnAdicionarTeorico.Visible = True : btnAdicionarTeorico.Enabled = VerificaDireito(Formulario.ComercialOrcamentoProduto, gcInsert)
            End If

            'Remove Evento
            txtCustoTeorico.Tag = ""
            txtMargemTeorico.Tag = ""
            txtGPTeorico.Tag = ""
            txtMarkupTeorico.Tag = ""
            txtPrecoVendaTeorico.Tag = ""
            txtPrecoVendaUnidadeTeorico.Tag = ""
            txtCustoMedio.Tag = ""
            txtMargemMedio.Tag = ""
            txtGPMedio.Tag = ""
            txtMarkupMedio.Tag = ""
            txtPrecoVendaMedio.Tag = ""
            txtPrecoVendaUnidadeMedio.Tag = ""
            txtSugestao.Text = sSugestaoVenda

            'Verifica se foi Selecionado um Cliente
            If iCodigoClienteGlobal <> -1 Then
                cboCliente.SelectedValue = iCodigoClienteGlobal
                cboCliente.Enabled = False
            End If

            'Verifica se foi Selecionado o Produto
            If lCodigoItem <> -1 Then
                cboCodigoProduto.Text = sCodigoProduto
            End If

            If cboCliente.Enabled = True Then
                cboCliente.Focus()
            Else
                cboCodigoProduto.Focus()
            End If

            'Seta Controle
            cboCliente.Text = sClienteGlobal

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar(ByVal sTipo As String)

        Try

            'Váriaveis Locais
            Dim sAuxiliar(1) As String

            'Seta Váriavel
            If dtpPrevisaoEntregaProduto.Tag <> "" And dtpPrevisaoEntregaProduto.Tag <> "|" Then
                sAuxiliar = dtpPrevisaoEntregaProduto.Tag.ToString.Split("|")
            Else
                sAuxiliar(0) = dtpPrevisaoEntregaProduto.Value
                sAuxiliar(1) = txtQuantidade.Value
            End If

            'Verifica o Tipo da Tela
            If sTelaVenda = "PEDIDO" Then

                'Váriavel - Classe
                Dim oClsVenPedido As New clsUsrVenPedido

                'Seta Váriavel
                oClsVenPedido.CodigoPedido = lCodigoVendaGlobal

                'Insere Produto
                Call oClsVenPedido.InsertProduto(lCodigoVendaGlobal, _
                                                 sRevisaoGlobal, _
                                                 iCodigoClienteGlobal, _
                                                 "", _
                                                 cboCodigoProduto.SelectedValue, _
                                                 "", _
                                                 cboDestinacao.SelectedValue, _
                                                 txtQuantidadeUnidade.Value, _
                                                 sTipo, _
                                                 txtCustoMedio.Value / txtFatorConversao.Value, _
                                                 txtCustoTeorico.Value / txtFatorConversao.Value, _
                                                 IIf(sTipo = "CUSTO MÉDIO", txtMargemMedio.Value, txtMargemTeorico.Value), _
                                                 IIf(sTipo = "CUSTO MÉDIO", txtGPMedio.Value, txtGPTeorico.Value), _
                                                 IIf(sTipo = "CUSTO MÉDIO", txtMarkupMedio.Value, txtMarkupTeorico.Value), _
                                                 IIf(sTipo = "CUSTO MÉDIO", txtPrecoVendaMedio.Value / txtFatorConversao.Value, txtPrecoVendaTeorico.Value / txtFatorConversao.Value), _
                                                 lCodigoAcordoComercial, _
                                                 iCodigoAcordoComercialItem, _
                                                 iCodigoUsuarioItem, _
                                                 oDataEntrega)

                'Verifica o Tipo da Tela
            ElseIf sTelaVenda = "ORCAMENTO" Then

                'Váriavel - Classe
                Dim oClsVenOrcamento As New clsUsrVenOrcamento

                'Seta Váriavel
                oClsVenOrcamento.CodigoOrcamento = lCodigoVendaGlobal

                'Insere Produto
                Call oClsVenOrcamento.InsertProduto(lCodigoVendaGlobal, _
                                                    sRevisaoGlobal, _
                                                    iCodigoClienteGlobal, _
                                                    "", _
                                                    cboCodigoProduto.SelectedValue, _
                                                    "", _
                                                    cboDestinacao.SelectedValue, _
                                                    txtQuantidadeUnidade.Value, _
                                                    sTipo, _
                                                    txtCustoMedio.Value / txtFatorConversao.Value, _
                                                    txtCustoTeorico.Value / txtFatorConversao.Value, _
                                                    IIf(sTipo = "CUSTO MÉDIO", txtMargemMedio.Value, txtMargemTeorico.Value), _
                                                    IIf(sTipo = "CUSTO MÉDIO", txtGPMedio.Value, txtGPTeorico.Value), _
                                                    IIf(sTipo = "CUSTO MÉDIO", txtMarkupMedio.Value, txtMarkupTeorico.Value), _
                                                    IIf(sTipo = "CUSTO MÉDIO", txtPrecoVendaMedio.Value / txtFatorConversao.Value, txtPrecoVendaTeorico.Value / txtFatorConversao.Value), _
                                                    lCodigoAcordoComercial, _
                                                    iCodigoAcordoComercialItem, _
                                                    iCodigoUsuarioItem, _
                                                    oDataEntrega)

            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao(ByVal sTipo As String) As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Function
            End If

            'Verifica se foi Seleciona o Campo - Produto
            If cboCodigoProduto.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(lblCodigo, "O Campo [Código] é obrigatório. Digite um valor para ele.")
                cboCodigoProduto.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Destinação
            If ValidaCampo(cboDestinacao, lblDestinacao) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, txtQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade em Estoque é suficiente
            If txtQuantidade.Value > txtQuantidadeEstoque.Value Then
                If MsgBox("A Quantidade em Estoque é menor que a Quantidade Orçada." & vbCrLf & vbCrLf & "Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                    txtQuantidade.Focus()
                    Exit Function
                End If
            End If

            'Verifica se a Quantidade Parcial está correta
            Dim oPrevisaoEntrega As PrevisaoEntrega
            Dim dQuantidade As Double = 0

            'Verifica se foi Preenchido da Data de Entrega
            If oDataEntrega.Count <= 1 Then

                'Seta Váriavel
                oDataEntrega.Clear()
                oPrevisaoEntrega.sPrevisaoEntrega = dtpPrevisaoEntregaProduto.Value
                oPrevisaoEntrega.iCodigoEntrega = 0
                oPrevisaoEntrega.dQuantidade = txtQuantidadeUnidade.Value
                oPrevisaoEntrega.sNotaFiscal = ""
                oDataEntrega.Add(1, oPrevisaoEntrega)

            Else

                'Carrega Váriavel - Quantidade
                For Each oPrevisaoEntrega In oDataEntrega.Values
                    dQuantidade += oPrevisaoEntrega.dQuantidade
                Next

                If dQuantidade <> txtQuantidadeUnidade.Value Then
                    'Informa o Usuário do Problema encontrado
                    frmMain.errInfo.SetError(lblPrevisaoEntregaProduto, "A Quantidade Desmembrada não corresponde a Quantidade informada do Produto.")
                    txtQuantidadeUnidade.Focus()
                    Exit Function
                End If

            End If

            'Verifica se foi Preenchido o Campo - Preço de Venda
            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_venda_preco_venda'"), Boolean) = True Then
                If dPrecoVenda = 0 Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Produto: " & cboCodigoProduto.Text & ", não possui Preço de Venda cadastrado.")
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Preço de Venda
            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_venda_preco_minimo'"), Boolean) = True Then
                If dPrecoMinimo = 0 Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Produto: " & cboCodigoProduto.Text & ", não possui Preço Mínimo cadastrado.")
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If sTipo = "TEORICO" Then
                If txtPrecoVendaUnidadeTeorico.Enabled = True Then
                    If ValidaCampo(txtPrecoVendaUnidadeTeorico, lblPrecoVendaUnidadeTeorico, True) = False Then
                        Exit Function
                    End If
                End If
            ElseIf sTipo = "MEDIO" Then
                If txtPrecoVendaUnidadeMedio.Enabled = True Then
                    If ValidaCampo(txtPrecoVendaUnidadeMedio, lblPrecoVendaUnidadeMedio, True) = False Then
                        Exit Function
                    End If
                End If
            End If

            Dim dPreco = IIf(sTipo = "TEORICO", txtPrecoVendaUnidadeTeorico.Value, txtPrecoVendaUnidadeMedio.Value)

            'Verifica se o Valor Unitário é Maior que o Preço Mínimo
            If dPreco < dPrecoMinimo Then

                'Limpa Váriavel
                iCodigoUsuarioItem = 0

                If MsgBox("O Valor Unitário está menor que o Preço Mínimo. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = False Then

                        'Formulário -Liberação
                        Dim oForm As New frmLiberacao
                        'Passa Parâmetros
                        oForm.CodigoFormulario = Formulario.ComercialPedidoVenda
                        oForm.Direito = gcAdministrator
                        'Abre Formulário
                        oForm.ShowDialog(Me)

                        'Seta Váriavel - Retorno
                        iCodigoUsuarioItem = oForm.CodigoUsuario

                        'Verifica se o Usuário é Válido
                        If iCodigoUsuarioItem <= 0 Then
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não possui direito de Administrador.")
                            sLiberacaoItem = ""
                            If sTipo = "TEORICO" Then
                                txtPrecoVendaUnidadeTeorico.Focus()
                            ElseIf sTipo = "MEDIO" Then
                                txtPrecoVendaUnidadeMedio.Focus()
                            End If
                            Exit Function
                        End If

                    Else
                        iCodigoUsuarioItem = goUsuario.iUsuario
                    End If

                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DesmembrarEntrega(ByVal sItem As String, _
                                  ByVal dQuantidade As Double, _
                                  ByVal dtpPrevisaoEntrega As CalendarCombo, _
                                  ByVal oDataEntrega As Hashtable)

        Try

            'Váriavel - Formulário
            Dim oForm As New frmVenPedidoItemDesmembrarEntrega
            'Seta Parâmetros
            oForm.Item = sItem
            oForm.Quantidade = dQuantidade
            oForm.DataEntrega = oDataEntrega
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Verifica se foi gerado a Data de Entrega
            If oDataEntrega.Count > 0 Then

                'Váriavel Local
                Dim oPrevisaoEntrega As PrevisaoEntrega = oDataEntrega.Item(0)
                'Seta Controle
                dtpPrevisaoEntrega.Value = oPrevisaoEntrega.sPrevisaoEntrega

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class