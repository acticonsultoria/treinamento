Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFProdutoXMLLote

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNFProdutoXML As New clsFrmFatEntradaNFProdutoXML

    Private lCodigoEntradaCapa As Long
    Private iCodigoEntradaItem As Integer
    Private lCodigoFornecedor As Long
    Private dQuantidadeNF As Double

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEntradaCapa As Long
        Set(value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property
    Public WriteOnly Property CodigoEntradaItem As Integer
        Set(value As Integer)
            iCodigoEntradaItem = value
        End Set
    End Property
    Public WriteOnly Property CodigoFornecedor As Long
        Set(value As Long)
            lCodigoFornecedor = value
        End Set
    End Property
    Public WriteOnly Property QuantidadeNF As Double
        Set(value As Double)
            dQuantidadeNF = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa)

            'Carrega Grid
            oClsFatEntradaNFProdutoXML.LoadGridImportarLote(grdListagem, lCodigoFornecedor)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
    Private Sub btnBaixar_Click(sender As Object, e As EventArgs) Handles btnBaixar.Click
        Try
            frmMain.errInfo.Clear()

            If ValidaCampo(cboCFOP, lblCFOP) = False Then Exit Sub

            If grdListagem.GetCheckedRows.Count = 0 Then

                MsgBox("Selecione ao menos um registro!", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub

            End If

            Dim dQuantidadeTotal As Double = 0

            For Each oRow In grdListagem.GetCheckedRows

                dQuantidadeTotal += oRow.Cells.Item("quantidade").Value

            Next


            For Each oRow In grdListagem.GetCheckedRows

                'Insere Registro na tb_fat_entrada_item_pedido_tmp
                Call oClsFatEntradaNFProdutoXML.InsertRecebimento(lCodigoEntradaCapa, _
                                                                  iCodigoEntradaItem, _
                                                                  cboCFOP.SelectedValue, _
                                                                  2, _
                                                                  oRow.Cells.Item("pedido_compra").Value, _
                                                                  oRow.Cells.Item("codigo_item").Value, _
                                                                  False, _
                                                                  (dQuantidadeNF / dQuantidadeTotal) * oRow.Cells.Item("quantidade").Value, _
                                                                  oRow.Cells.Item("codigo_unidade_medida").Value, _
                                                                  0, _
                                                                  -1, _
                                                                  "", _
                                                                  "", _
                                                                  "", _
                                                                  0, _
                                                                  -1, _
                                                                  "", _
                                                                  oRow.Cells.Item("codigo_pedido").Value, _
                                                                  oRow.Cells.Item("codigo_pedido_item").Value, _
                                                                  oRow.Cells.Item("codigo_pedido_item_entrega").Value, _
                                                                  -1, _
                                                                  -1, _
                                                                  -1, _
                                                                  "", _
                                                                  oRow.Cells.Item("quantidade").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Next

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

   
End Class