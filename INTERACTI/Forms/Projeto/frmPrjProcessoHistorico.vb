Imports Janus.Windows.GridEX

Public Class frmPrjProcessoHistorico

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsVenPedido As New clsUsrVenPedido
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

    Public Property CodigoPedido() As Long
        Get
            Return lCodigoPedido
        End Get
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public Property CodigoPedidoItem() As Integer
        Get
            Return iCodigoPedidoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenPedidoHistoricoItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenPedidoHistoricoItem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdHistoricoItem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdHistoricoItem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdHistoricoItem.GroupByBoxVisible = True
                grdHistoricoItem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdHistoricoItem
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistoricoItem, Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdHistoricoItem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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

    Private Sub grdHistoricoItem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistoricoItem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistoricoItem, _
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoItem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistoricoItem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistoricoItem.Name, _
                                     Formulario.ComercialPedidoVenda, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoItem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHistoricoItem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdHistoricoItem.Name, _
                                          Formulario.ComercialPedidoVenda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click

        Try

            If txtObservacao.Text.Length >= 10 = True Then


                Call oClsVenPedido.AtualizarHistoricoProjeto(CodigoPedido, _
                                                             CodigoPedidoItem, _
                                                             txtObservacao.Text.Trim)

                Call oClsVenPedido.LoadGridItemHistorico(grdHistoricoItem, _
                                                         CodigoPedido, _
                                                         CodigoPedidoItem)
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                frmMain.errInfo.SetError(lblHistorico, "O Campo Observação é obrigatório. Digite uma informação acima de 15 caracteres para ele.")
                txtObservacao.Focus()

            End If

        Catch ex As Exception
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
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenPedidoHistoricoItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcPrint)

            'Carrega Controles
            Call oClsVenPedido.LoadDadosItemProjeto(oGrid.CurrentRow.Cells("codigo_pedido").Value, _
                                             oGrid.CurrentRow.Cells("codigo_pedido_item").Value, _
                                             txtNumeroPedido, _
                                             txtDataPedido, _
                                             txtCliente, _
                                             txtItem, _
                                             txtQuantidade, _
                                             txtUnidadeMedida)

            'Carrega Grid
            Call oClsVenPedido.LoadGridItemHistorico(grdHistoricoItem, _
                                                     oGrid.CurrentRow.Cells("codigo_pedido").Value, _
                                                     oGrid.CurrentRow.Cells("codigo_pedido_item").Value)

            'Configura Grid
            Call ConfiguraGrid(grdHistoricoItem, Formulario.ComercialPedidoVenda)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class