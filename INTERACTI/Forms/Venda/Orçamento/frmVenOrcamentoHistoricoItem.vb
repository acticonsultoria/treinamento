Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoHistoricoItem

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer
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

    Public Property CodigoOrcamentoItem() As Integer
        Get
            Return iCodigoOrcamentoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoOrcamentoItem = value
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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdHistoricoItem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistoricoItem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdHistoricoItem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistoricoItem.SizingColumn

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

    Private Sub grdHistoricoItem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHistoricoItem.GroupsChanging

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

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormularioGrid = iFormulario

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            oClsUsrVenOrcamentoLegado.LoadDadosItem(lCodigoOrcamento, _
                                                    iCodigoOrcamentoItem, _
                                                    txtNumeroOrcamento, _
                                                    txtDataOrcamento, _
                                                    txtCliente, _
                                                    txtItem, _
                                                    txtQuantidade, _
                                                    txtQuantidadePedido, _
                                                    txtQuantidadeCancelada)

            oClsUsrVenOrcamentoLegado.LoadGridHistoricoItem(grdHistoricoItem, _
                                                            lCodigoOrcamento, _
                                                            iCodigoOrcamentoItem)

            'Configura Grid
            ConfiguraGrid(grdHistoricoItem, iFormulario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class