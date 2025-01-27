Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoGerarPedido

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrVenOrcamento As New clsUsrVenOrcamento
    Private lCodigoOrcamento As Long
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoOrcamento() As Long
        Get
            Return lCodigoOrcamento
        End Get
        Set(ByVal value As Long)
            lCodigoOrcamento = value
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

#Region "::: GERAL :::"

    Private Sub frmVenPedidoOrcamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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
        ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR ORÇAMENTO :::"

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImportarOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarPedido.Click

        Try

            If Validacao() = False Then Exit Sub

            GerarPedido()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdPedidoOrcamento_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdPedidoVendaOrcamento.CellValueChanged

        Try

            'Verifica se é Válido a Coluna
            If IsNothing(e.Column) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case e.Column.Key

                Case "quantidade_pedido"

                    'Verifica se o Registro é Válido
                    If IsNumeric(grdPedidoVendaOrcamento.GetValue("quantidade_pedido")) AndAlso grdPedidoVendaOrcamento.GetValue("quantidade_pedido") > grdPedidoVendaOrcamento.GetValue("quantidade") Then

                        'Informa o Usuário sobre o Sucesso da Operação
                        MsgBox("A Quantidade do Pedido de Venda informada não pode ser maior que a Quantidade do Orçamento.", MsgBoxStyle.Exclamation, "Validação")
                        grdPedidoVendaOrcamento.SetValue("quantidade_pedido", 0)

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoOrcamento_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdPedidoVendaOrcamento.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdPedidoVendaOrcamento.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoVendaOrcamento.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoVendaOrcamento.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoVendaOrcamento.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

            iFormularioGrid = iFormulario

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenPedidoOrcamento_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            ConfiguraGrid(grdPedidoVendaOrcamento, iFormulario)
            btnGerarPedido.Enabled = VerificaDireito(iFormulario, gcAdministrator)

            oClsUsrVenOrcamento.LoadGridGerarPedido(grdPedidoVendaOrcamento, _
                                                    lCodigoOrcamento)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If grdPedidoVendaOrcamento.GetCheckedRows.Count <= 0 Then
                MsgBox("Selecione alguma linha.", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            For Each oRow As GridEXRow In grdPedidoVendaOrcamento.GetCheckedRows

                If oRow.Cells("quantidade").Value <= 0 Then
                    MsgBox("Quantidade inválida para o produto: " & oRow.Cells("codigo_produto").Value, MsgBoxStyle.Exclamation, "Validação")
                    Return False
                End If

            Next

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub GerarPedido()

        Try

            If MsgBox("Deseja gerar um pedido de venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            Dim lCodigoPedidoVenda As Long = oClsUsrVenOrcamento.InsertPedidoVenda(lCodigoOrcamento)

            For Each oRow As GridEXRow In grdPedidoVendaOrcamento.GetCheckedRows

                oClsUsrVenOrcamento.InsertPedidoVendaItem(lCodigoOrcamento, _
                                                          lCodigoPedidoVenda, _
                                                          oRow.Cells("codigo_orcamento_item").Value)

            Next

            'Atualiza status do orçamento
            ExecuteQuery("sp_status_venda_orcamento " & lCodigoOrcamento & "," & goUsuario.iEmpresa)

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            Me.Dispose()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class