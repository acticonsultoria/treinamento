Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class frmCadProdutoPrecoVendaQuantidadeMinima

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProdutoPrecoVenda As New clsUsrCadProdutoPrecoVenda

    'Váriaveis
    Private sRevisao As String
    Private sCodigoProduto As String
    Private sCodigoProduto2 As String
    Private sDescricao As String
    Private sMarca As String
    Private dPrecoCompra As Double
    Private dCustoTeorico As Double
    Private dMargemMinimo As Double
    Private dMarkupMinimo As Double
    Private dGPMinimo As Double
    Private dPrecoVendaMinimo As Double
    Private dMargemIdeal As Double
    Private dMarkupIdeal As Double
    Private dGPIdeal As Double
    Private dPrecoVendaIdeal As Double
    Private oGrid As GridEX
    Private lCodigo As Long
    Private dMultiploVenda As Double
    Private dCotacao As Double
    Private dPrecoCompraReais As Double
    Private iCodigoMoeda As Integer
    Private dPorcentagemCustos As Double
    Private dPorcentagemImpostos As Double

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Revisao() As String
        Set(ByVal value As String)
            sRevisao = value
        End Set
    End Property

    Public WriteOnly Property CodigoProduto() As String
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
    End Property

    Public WriteOnly Property CodigoProduto2() As String
        Set(ByVal value As String)
            sCodigoProduto2 = value
        End Set
    End Property

    Public WriteOnly Property Descricao() As String
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public WriteOnly Property Marca() As String
        Set(ByVal value As String)
            sMarca = value
        End Set
    End Property

    Public WriteOnly Property PrecoCompra() As Double
        Set(ByVal value As Double)
            dPrecoCompra = value
        End Set
    End Property

    Public WriteOnly Property CustoTeorico() As Double
        Set(ByVal value As Double)
            dCustoTeorico = value
        End Set
    End Property

    Public WriteOnly Property Grid() As GridEX
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

    Public Property MargemMinimo() As Double
        Get
            Return dMargemMinimo
        End Get
        Set(ByVal value As Double)
            dMargemMinimo = value
        End Set
    End Property

    Public Property PorcentagemImpostos() As Double
        Get
            Return dPorcentagemImpostos
        End Get
        Set(ByVal value As Double)
            dPorcentagemImpostos = value
        End Set
    End Property

    Public Property PorcentagemCustos() As Double
        Get
            Return dPorcentagemCustos
        End Get
        Set(ByVal value As Double)
            dPorcentagemCustos = value
        End Set
    End Property
    Public Property PrecoCompraReais() As Double
        Get
            Return dPrecoCompraReais
        End Get
        Set(ByVal value As Double)
            dPrecoCompraReais = value
        End Set
    End Property
    Public Property Cotacao() As Double
        Get
            Return dCotacao
        End Get
        Set(ByVal value As Double)
            dCotacao = value
        End Set
    End Property
    Public Property CodigoMoeda() As Integer
        Get
            Return iCodigoMoeda
        End Get
        Set(ByVal value As Integer)
            iCodigoMoeda = value
        End Set
    End Property
    Public Property MarkupMinimo() As Double
        Get
            Return dMarkupMinimo
        End Get
        Set(ByVal value As Double)
            dMarkupMinimo = value
        End Set
    End Property

    Public Property GPMinimo() As Double
        Get
            Return dGPMinimo
        End Get
        Set(ByVal value As Double)
            dGPMinimo = value
        End Set
    End Property

    Public Property PrecoVendaMinimo() As Double
        Get
            Return dPrecoVendaMinimo
        End Get
        Set(ByVal value As Double)
            dPrecoVendaMinimo = value
        End Set
    End Property

    Public Property MargemIdeal() As Double
        Get
            Return dMargemIdeal
        End Get
        Set(ByVal value As Double)
            dMargemIdeal = value
        End Set
    End Property

    Public Property MarkupIdeal() As Double
        Get
            Return dMarkupIdeal
        End Get
        Set(ByVal value As Double)
            dMarkupIdeal = value
        End Set
    End Property

    Public Property GPIdeal() As Double
        Get
            Return dGPIdeal
        End Get
        Set(ByVal value As Double)
            dGPIdeal = value
        End Set
    End Property

    Public Property PrecoVendaIdeal() As Double
        Get
            Return dPrecoVendaIdeal
        End Get
        Set(ByVal value As Double)
            dPrecoVendaIdeal = value
        End Set
    End Property

    Public Property MultiploVenda() As Double
        Get
            Return dMultiploVenda
        End Get
        Set(ByVal value As Double)
            dMultiploVenda = value
        End Set
    End Property

    Public WriteOnly Property Codigo() As Long
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadProdutoPrecoVendaQuantidadeMinima_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadProdutoPrecoVendaQuantidadeMinima_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura Formulário
        Call ConfigurarFormulario()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo - Múltiplo de Venda
            If ValidaCampo(txtMultiploVenda, lblMultiploVenda, True) = False Then
                Exit Sub
            End If

            'Salva Dados
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalcularValor(ByVal sender As Object, ByVal e As EventArgs)

        Try

            If sender.tag <> "" Then Exit Sub

            'Váriaveis Locais
            Dim dCustoTeoricoMinimo As Double = IIf(IsNumeric(txtCustoTeorico.Value), txtCustoTeorico.Value, 0)
            Dim dMargemMinimo As Double = IIf(IsNumeric(txtMargemMinimo.Value), txtMargemMinimo.Value, 0)
            Dim dMarkupMinimo As Double = IIf(IsNumeric(txtMarkupMinimo.Value), txtMarkupMinimo.Value, 0)
            Dim dGPMinimo As Double = IIf(IsNumeric(txtGPMinimo.Value), txtGPMinimo.Value, 0)
            Dim dPrecoVendaMinimo As Double = IIf(IsNumeric(txtPrecoVendaMinimo.Value), txtPrecoVendaMinimo.Value, 0)

            Dim dCustoTeoricoIdeal As Double = IIf(IsNumeric(txtCustoTeorico.Value), txtCustoTeorico.Value, 0)
            Dim dMargemIdeal As Double = IIf(IsNumeric(txtMargemIdeal.Value), txtMargemIdeal.Value, 0)
            Dim dMarkupIdeal As Double = IIf(IsNumeric(txtMarkupIdeal.Value), txtMarkupIdeal.Value, 0)
            Dim dGPIdeal As Double = IIf(IsNumeric(txtGPIdeal.Value), txtGPIdeal.Value, 0)
            Dim dPrecoVendaIdeal As Double = IIf(IsNumeric(txtPrecoVendaIdeal.Value), txtPrecoVendaIdeal.Value, 0)

            'Remove Evento
            txtMargemMinimo.Tag = "A"
            txtGPMinimo.Tag = "A"
            txtMarkupMinimo.Tag = "A"
            txtPrecoVendaMinimo.Tag = "A"
            txtMargemIdeal.Tag = "A"
            txtGPIdeal.Tag = "A"
            txtMarkupIdeal.Tag = "A"
            txtPrecoVendaIdeal.Tag = "A"

            Select Case sender.Name

                Case "txtCustoTeorico"
                    dPrecoVendaMinimo = dCustoTeoricoMinimo + (dCustoTeoricoMinimo * dMargemMinimo)
                    dMargemMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dCustoTeoricoMinimo, 0)
                    dMarkupMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo / dCustoTeoricoMinimo), 0)
                    dGPMinimo = IIf(dPrecoVendaMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dPrecoVendaMinimo, 0)
                    txtMargemMinimo.Value = dMargemMinimo
                    txtGPMinimo.Value = dGPMinimo
                    txtMarkupMinimo.Value = dMarkupMinimo
                    txtPrecoVendaMinimo.Value = dPrecoVendaMinimo

                    dPrecoVendaIdeal = dCustoTeoricoIdeal + (dCustoTeoricoIdeal * dMargemIdeal)
                    dMargemIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dCustoTeoricoIdeal, 0)
                    dMarkupIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal / dCustoTeoricoIdeal), 0)
                    dGPIdeal = IIf(dPrecoVendaIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dPrecoVendaIdeal, 0)
                    txtMargemIdeal.Value = dMargemIdeal
                    txtGPIdeal.Value = dGPIdeal
                    txtMarkupIdeal.Value = dMarkupIdeal
                    txtPrecoVendaIdeal.Value = dPrecoVendaIdeal


                Case "txtMargemMinimo"
                    dPrecoVendaMinimo = dCustoTeoricoMinimo + (dCustoTeoricoMinimo * dMargemMinimo)
                    dMarkupMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo / dCustoTeoricoMinimo), 0)
                    dGPMinimo = IIf(dPrecoVendaMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dPrecoVendaMinimo, 0)
                    txtGPMinimo.Value = dGPMinimo
                    txtMarkupMinimo.Value = dMarkupMinimo
                    txtPrecoVendaMinimo.Value = dPrecoVendaMinimo

                Case "txtMarkupMinimo"
                    dPrecoVendaMinimo = dCustoTeoricoMinimo * dMarkupMinimo
                    dMargemMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dCustoTeoricoMinimo, 0)
                    dGPMinimo = IIf(dPrecoVendaMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dPrecoVendaMinimo, 0)
                    txtMargemMinimo.Value = dMargemMinimo
                    txtGPMinimo.Value = dGPMinimo
                    txtPrecoVendaMinimo.Value = dPrecoVendaMinimo

                Case "txtGPMinimo"
                    If dGPMinimo >= 1 Then txtGPMinimo.Value = 0.99 : dGPMinimo = 0.99
                    dPrecoVendaMinimo = dCustoTeoricoMinimo / (1 - dGPMinimo)
                    dMargemMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dCustoTeoricoMinimo, 0)
                    dMarkupMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo / dCustoTeoricoMinimo), 0)
                    txtMargemMinimo.Value = dMargemMinimo
                    txtMarkupMinimo.Value = dMarkupMinimo
                    txtPrecoVendaMinimo.Value = dPrecoVendaMinimo

                Case "txtPrecoVendaMinimo"
                    dMargemMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dCustoTeoricoMinimo, 0)
                    dMarkupMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo / dCustoTeoricoMinimo), 0)
                    dGPMinimo = IIf(dPrecoVendaMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dPrecoVendaMinimo, 0)
                    txtMargemMinimo.Value = dMargemMinimo
                    txtGPMinimo.Value = dGPMinimo
                    txtMarkupMinimo.Value = dMarkupMinimo

                    'Case "txtCustoTeorico"
                    '    dPrecoVendaIdeal = dCustoTeoricoIdeal + (dCustoTeoricoIdeal * dMargemIdeal)
                    '    dMargemIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dCustoTeoricoIdeal, 0)
                    '    dMarkupIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal / dCustoTeoricoIdeal), 0)
                    '    dGPIdeal = IIf(dPrecoVendaIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dPrecoVendaIdeal, 0)
                    '    txtMargemIdeal.Value = dMargemIdeal
                    '    txtGPIdeal.Value = dGPIdeal
                    '    txtMarkupIdeal.Value = dMarkupIdeal
                    '    txtPrecoVendaIdeal.Value = dPrecoVendaIdeal
                    '    txtCustoTeorico.Value = dCustoTeoricoIdeal

                Case "txtMargemIdeal"
                    dPrecoVendaIdeal = dCustoTeoricoIdeal + (dCustoTeoricoIdeal * dMargemIdeal)
                    dMarkupIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal / dCustoTeoricoIdeal), 0)
                    dGPIdeal = IIf(dPrecoVendaIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dPrecoVendaIdeal, 0)
                    txtGPIdeal.Value = dGPIdeal
                    txtMarkupIdeal.Value = dMarkupIdeal
                    txtPrecoVendaIdeal.Value = dPrecoVendaIdeal

                Case "txtMarkupIdeal"
                    dPrecoVendaIdeal = dCustoTeoricoIdeal * dMarkupIdeal
                    dMargemIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dCustoTeoricoIdeal, 0)
                    dGPIdeal = IIf(dPrecoVendaIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dPrecoVendaIdeal, 0)
                    txtMargemIdeal.Value = dMargemIdeal
                    txtGPIdeal.Value = dGPIdeal
                    txtPrecoVendaIdeal.Value = dPrecoVendaIdeal

                Case "txtGPIdeal"
                    If dGPIdeal >= 1 Then txtGPIdeal.Value = 0.99 : dGPIdeal = 0.99
                    dPrecoVendaIdeal = dCustoTeoricoIdeal / (1 - dGPIdeal)
                    dMargemIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dCustoTeoricoIdeal, 0)
                    dMarkupIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal / dCustoTeoricoIdeal), 0)
                    txtMargemIdeal.Value = dMargemIdeal
                    txtMarkupIdeal.Value = dMarkupIdeal
                    txtPrecoVendaIdeal.Value = dPrecoVendaIdeal

                Case "txtPrecoVendaIdeal"
                    dMargemIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dCustoTeoricoIdeal, 0)
                    dMarkupIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal / dCustoTeoricoIdeal), 0)
                    dGPIdeal = IIf(dPrecoVendaIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dPrecoVendaIdeal, 0)
                    txtMargemIdeal.Value = dMargemIdeal
                    txtGPIdeal.Value = dGPIdeal
                    txtMarkupIdeal.Value = dMarkupIdeal

            End Select

            'Remove Evento
            txtMargemMinimo.Tag = ""
            txtGPMinimo.Tag = ""
            txtMarkupMinimo.Tag = ""
            txtPrecoVendaMinimo.Tag = ""
            txtMargemIdeal.Tag = ""
            txtGPIdeal.Tag = ""
            txtMarkupIdeal.Tag = ""
            txtPrecoVendaIdeal.Tag = ""

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadProdutoPrecoVendaQuantidadeMinima_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))
            Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
            'Carrega Controles
            txtCodigo.Text = sCodigoProduto
            txtDescricao.Text = sDescricao
            txtMarca.Text = sMarca
            txtPrecoCompra.Value = dPrecoCompra
            txtCustoTeorico.Value = dCustoTeorico
            txtCustoTeorico.Value = dCustoTeorico
            txtMargemMinimo.Value = dMargemMinimo
            txtMarkupMinimo.Value = dMarkupMinimo
            txtGPMinimo.Value = dGPMinimo
            txtPrecoVendaMinimo.Value = dPrecoVendaMinimo
            txtMargemIdeal.Value = dMargemIdeal
            txtMarkupIdeal.Value = dMarkupIdeal
            txtGPIdeal.Value = dGPIdeal
            txtPrecoVendaIdeal.Value = dPrecoVendaIdeal
            txtMultiploVenda.Value = dMultiploVenda
            cboMoeda.SelectedValue = iCodigoMoeda
            txtCotacao.Value = dCotacao
            txtPrecoCompraReais.Value = dPrecoCompraReais
            txtPorcentagemCustos.Value = dPorcentagemCustos
            txtPorcentagemImposto.Value = dPorcentagemImpostos

            'Adiciona ValueChanged
            Call AddValueChanged(Me, New DelegateValueChanged(AddressOf CalcularValor))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoPrecoVenda, gcInsert)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Salva Dados de Venda
            oClsCadProdutoPrecoVenda.Save(sRevisao, _
                                          lCodigo, _
                                          txtMultiploVenda.Value, _
                                          txtCustoTeorico.Value, _
                                          txtPrecoCompra.Value, _
                                          txtMargemMinimo.Value, _
                                          txtMarkupMinimo.Value, _
                                          txtGPMinimo.Value, _
                                          txtPrecoVendaMinimo.Value, _
                                          txtMargemIdeal.Value, _
                                          txtMarkupIdeal.Value, _
                                          txtGPIdeal.Value, _
                                          txtPrecoVendaIdeal.Value, _
                                          cboMoeda.SelectedValue, _
                                          txtCotacao.Value, _
                                          txtPrecoCompraReais.Value, _
                                          txtPorcentagemImposto.Value, _
                                          txtPorcentagemCustos.Value)

            dMultiploVenda = txtMultiploVenda.Value

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    
    Private Sub txtCotacao_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCotacao.ValueChanged, _
                                                                                                     txtPrecoCompra.ValueChanged

        Try
            txtPrecoCompraReais.Value = txtCotacao.Value * txtPrecoCompra.Value
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub CalculoCustoTeorico() Handles txtCotacao.ValueChanged, _
                                              txtPrecoCompra.ValueChanged, _
                                              txtPrecoCompraReais.ValueChanged, _
                                              txtPorcentagemImposto.ValueChanged, _
                                              txtPorcentagemCustos.ValueChanged
        Try
            txtCustoTeorico.Value = txtPrecoCompraReais.Value * (1 + (txtPorcentagemCustos.Value + txtPorcentagemImposto.Value))
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    
    
    'Private Sub Calculos() Handles txtCustoTeorico.ValueChanged
    '    Try
    '        Dim dCustoTeoricoMinimo As Double = IIf(IsNumeric(txtCustoTeorico.Value), txtCustoTeorico.Value, 0)
    '        Dim dMargemMinimo As Double = IIf(IsNumeric(txtMargemMinimo.Value), txtMargemMinimo.Value, 0)
    '        Dim dMarkupMinimo As Double = IIf(IsNumeric(txtMarkupMinimo.Value), txtMarkupMinimo.Value, 0)
    '        Dim dGPMinimo As Double = IIf(IsNumeric(txtGPMinimo.Value), txtGPMinimo.Value, 0)
    '        Dim dPrecoVendaMinimo As Double = IIf(IsNumeric(txtPrecoVendaMinimo.Value), txtPrecoVendaMinimo.Value, 0)

    '        Dim dCustoTeoricoIdeal As Double = IIf(IsNumeric(txtCustoTeorico.Value), txtCustoTeorico.Value, 0)
    '        Dim dMargemIdeal As Double = IIf(IsNumeric(txtMargemIdeal.Value), txtMargemIdeal.Value, 0)
    '        Dim dMarkupIdeal As Double = IIf(IsNumeric(txtMarkupIdeal.Value), txtMarkupIdeal.Value, 0)
    '        Dim dGPIdeal As Double = IIf(IsNumeric(txtGPIdeal.Value), txtGPIdeal.Value, 0)
    '        Dim dPrecoVendaIdeal As Double = IIf(IsNumeric(txtPrecoVendaIdeal.Value), txtPrecoVendaIdeal.Value, 0)

    '        dPrecoVendaMinimo = dCustoTeoricoMinimo + (dCustoTeoricoMinimo * dMargemMinimo)
    '        dMargemMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dCustoTeoricoMinimo, 0)
    '        dMarkupMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo / dCustoTeoricoMinimo), 0)
    '        dGPMinimo = IIf(dPrecoVendaMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dPrecoVendaMinimo, 0)
    '        txtMargemMinimo.Value = dMargemMinimo
    '        txtGPMinimo.Value = dGPMinimo
    '        txtMarkupMinimo.Value = dMarkupMinimo
    '        txtPrecoVendaMinimo.Value = dPrecoVendaMinimo

    '        dPrecoVendaIdeal = dCustoTeoricoIdeal + (dCustoTeoricoIdeal * dMargemIdeal)
    '        dMargemIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dCustoTeoricoIdeal, 0)
    '        dMarkupIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal / dCustoTeoricoIdeal), 0)
    '        dGPIdeal = IIf(dPrecoVendaIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dPrecoVendaIdeal, 0)
    '        txtMargemIdeal.Value = dMargemIdeal
    '        txtGPIdeal.Value = dGPIdeal
    '        txtMarkupIdeal.Value = dMarkupIdeal
    '        txtPrecoVendaIdeal.Value = dPrecoVendaIdeal

    '    Catch ex As Exception
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try
    'End Sub
End Class