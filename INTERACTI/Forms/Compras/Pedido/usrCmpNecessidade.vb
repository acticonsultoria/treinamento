Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrCmpNecessidade

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpNecessidade As New clsUsrCmpNecessidade

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCmpNecessidade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCmpNecessidade_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCmpNecessidade_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        'Exporta Grid para Excel
        Call ExportExcel(grdListagem)

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        'Carrega Dados da Grid
        Call LoadGrid()

    End Sub

    Private Sub btnPedidoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidoCompra.Click

        Try

            'Valida Dados do Formulário
            If Validacao() Then

                'Gera Pedido de Compra
                'Call GerarPedidoCompra()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpNecessidade_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnPedidoCompra.Enabled = VerificaDireito(Formulario.ComprasPedido, gcInsert)
            btnRequisicaoCompra.Enabled = VerificaDireito(Formulario.ComprasRequisicao, gcInsert)

            'Seta Focu
            txtCodigoProdutoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsCmpNecessidade.LoadGrid(grdListagem, _
                                        txtCodigoProdutoFiltro.Text.Trim, _
                                        txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi selecionado algum Registro
            If VerificaSelecaoRow(grdListagem) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Private Sub GerarPedidoCompra()

    '    Try

    '        'Váriavel - Formulário
    '        Dim oUsrCmpPedidoSimples As New usrCmpPedidoSimples
    '        Dim i As Integer

    '        'Abre Formulário
    '        Call frmMain.LoadPage("itmCmpPedidoSimples", "Compras - Pedido - Simples", oUsrCmpPedidoSimples)

    '        'Prepara Formulário
    '        oUsrCmpPedidoSimples.Novo()

    '        'Alterna Aba        
    '        oUsrCmpPedidoSimples.tabMain.TabPages.Remove(oUsrCmpPedidoSimples.pagListagem)
    '        oUsrCmpPedidoSimples.tabMain.TabPages.Add(oUsrCmpPedidoSimples.pagDados)

    '        'Insere Item na Grid
    '        For i = 0 To UBound(gSelecaoRow)

    '            'oUsrCmpPedidoSimples.InsertProduto(gSelecaoRow(i).Cells("descricao").Value, _
    '            '                                   gSelecaoRow(i).Cells("codigo_item").Value, _
    '            '                                   "", _
    '            '                                   gSelecaoRow(i).Cells("quantidade_necessidade").Value, _
    '            '                                   gSelecaoRow(i).Cells("unidade_medida").Value, _
    '            '                                   gSelecaoRow(i).Cells("codigo_unidade_medida").Value, _
    '            '                                   False, _
    '            '                                   False, _
    '            '                                   0, _
    '            '                                   0, _
    '            '                                   0, _
    '            '                                   0, _
    '            '                                   "", _
    '            '                                   "I", _
    '            '                                   i)

    '        Next

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

#End Region

End Class


