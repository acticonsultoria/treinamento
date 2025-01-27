Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class frmCadProdutoPrecoVenda

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProdutoPrecoVenda As New clsUsrCadProdutoPrecoVenda

    'Váriaveis
    Private sRevisao As String
    Private sCodigoProduto As String
    Private sCodigoProduto2 As String
    Private sDescricao As String
    Private sMarca As String
    Private dCustoTeorico As Double
    Private dPrecoCompra As Double
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

    Public WriteOnly Property CustoTeorico() As Double
        Set(ByVal value As Double)
            dCustoTeorico = value
        End Set
    End Property

    Public WriteOnly Property PrecoCompra() As Double
        Set(ByVal value As Double)
            dPrecoCompra = value
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

    Public WriteOnly Property Codigo() As Long
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadProdutoPrecoVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadProdutoPrecoVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            'Salva Dados
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalcularValor(sender As Object, e As EventArgs)

        Try

            If sender.tag <> "" Then Exit Sub

            'Váriaveis Locais
            Dim dCustoTeoricoMinimo As Double = IIf(IsNumeric(txtCustoTeoricoMinimo.Value), txtCustoTeoricoMinimo.Value, 0)
            Dim dMargemMinimo As Double = IIf(IsNumeric(txtMargemMinimo.Value), txtMargemMinimo.Value, 0)
            Dim dMarkupMinimo As Double = IIf(IsNumeric(txtMarkupMinimo.Value), txtMarkupMinimo.Value, 0)
            Dim dGPMinimo As Double = IIf(IsNumeric(txtGPMinimo.Value), txtGPMinimo.Value, 0)
            Dim dPrecoVendaMinimo As Double = IIf(IsNumeric(txtPrecoVendaMinimo.Value), txtPrecoVendaMinimo.Value, 0)

            Dim dCustoTeoricoIdeal As Double = IIf(IsNumeric(txtCustoTeoricoIdeal.Value), txtCustoTeoricoIdeal.Value, 0)
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

                Case "txtCustoTeoricoMinimo"
                    dPrecoVendaMinimo = dCustoTeoricoMinimo + (dCustoTeoricoMinimo * dMargemMinimo)
                    dMargemMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dCustoTeoricoMinimo, 0)
                    dMarkupMinimo = IIf(dCustoTeoricoMinimo > 0, (dPrecoVendaMinimo / dCustoTeoricoMinimo), 0)
                    dGPMinimo = IIf(dPrecoVendaMinimo > 0, (dPrecoVendaMinimo - dCustoTeoricoMinimo) / dPrecoVendaMinimo, 0)
                    txtMargemMinimo.Value = dMargemMinimo
                    txtGPMinimo.Value = dGPMinimo
                    txtMarkupMinimo.Value = dMarkupMinimo
                    txtPrecoVendaMinimo.Value = dPrecoVendaMinimo
                    txtCustoTeoricoIdeal.Value = dCustoTeoricoMinimo

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

                Case "txtCustoTeoricoIdeal"
                    dPrecoVendaIdeal = dCustoTeoricoIdeal + (dCustoTeoricoIdeal * dMargemIdeal)
                    dMargemIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dCustoTeoricoIdeal, 0)
                    dMarkupIdeal = IIf(dCustoTeoricoIdeal > 0, (dPrecoVendaIdeal / dCustoTeoricoIdeal), 0)
                    dGPIdeal = IIf(dPrecoVendaIdeal > 0, (dPrecoVendaIdeal - dCustoTeoricoIdeal) / dPrecoVendaIdeal, 0)
                    txtMargemIdeal.Value = dMargemIdeal
                    txtGPIdeal.Value = dGPIdeal
                    txtMarkupIdeal.Value = dMarkupIdeal
                    txtPrecoVendaIdeal.Value = dPrecoVendaIdeal
                    txtCustoTeoricoMinimo.Value = dCustoTeoricoIdeal

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadProdutoPrecoVenda_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Controles
            txtCodigo.Text = sCodigoProduto
            txtDescricao.Text = sDescricao
            txtMarca.Text = sMarca
            txtValorCompra.Value = dPrecoCompra
            txtCustoTeoricoMinimo.Value = dCustoTeorico
            txtCustoTeoricoIdeal.Value = dCustoTeorico
            txtMargemMinimo.Value = dMargemMinimo
            txtMarkupMinimo.Value = dMarkupMinimo
            txtGPMinimo.Value = dGPMinimo
            txtPrecoVendaMinimo.Value = dPrecoVendaMinimo
            txtMargemIdeal.Value = dMargemIdeal
            txtMarkupIdeal.Value = dMarkupIdeal
            txtGPIdeal.Value = dGPIdeal
            txtPrecoVendaIdeal.Value = dPrecoVendaIdeal

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
                                          1, _
                                          txtCustoTeoricoIdeal.Value, _
                                          txtValorCompra.Value, _
                                          txtMargemMinimo.Value, _
                                          txtMarkupMinimo.Value, _
                                          txtGPMinimo.Value, _
                                          txtPrecoVendaMinimo.Value, _
                                          txtMargemIdeal.Value, _
                                          txtMarkupIdeal.Value, _
                                          txtGPIdeal.Value, _
                                          txtPrecoVendaIdeal.Value)

            'Atualiza Grid
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "custo_teorico", txtCustoTeoricoIdeal.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "preco_compra", txtValorCompra.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "margem_preco_minimo", txtMargemMinimo.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "markup_preco_minimo", txtMarkupMinimo.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "gp_preco_minimo", txtGPMinimo.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "preco_minimo", txtPrecoVendaMinimo.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "preco_compra", txtCustoTeoricoIdeal.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "margem_preco_venda", txtMargemIdeal.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "markup_preco_venda", txtMarkupIdeal.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "gp_preco_venda", txtGPIdeal.Value)
            Call UpdateRegistroGrid(oGrid, "(codigo = " & lCodigo & ")", "preco_venda", txtPrecoVendaIdeal.Value)

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

End Class