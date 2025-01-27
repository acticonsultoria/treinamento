Imports Janus.Windows.GridEX

Public Class frmPrdOrdemProducaoPedidoVenda

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdOrdemProducao As New clsUsrPrdOrdemProducao
    Private lCodigoOrdemProducao As Long

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoOrdemProducao() As Long
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
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
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub cboPedidoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedidoVenda.SelectedIndexChanged

        Try

            cboCodigoItem.SelectedIndex = -1
            cboCodigoItem.Text = ""
            cboCodigoItem.DataSource = Nothing

            If cboPedidoVenda.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboCodigoItem, "sp_select_combo_producao_pedido_venda_item " & cboPedidoVenda.SelectedValue & "," & goUsuario.iEmpresa, True)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            If Validacao() = False Then Exit Sub

            Salvar()

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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboPedidoVenda, "sp_select_combo_producao_pedido_venda " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Public Function Validacao() As Boolean

        Try

            If ValidaCampo(cboPedidoVenda, lblPedidoCompra) = False Then Return False

            If ValidaCampo(cboCodigoItem, lblItem) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdOrdemProducao.AtualizarPedidoVenda(lCodigoOrdemProducao, _
                                                         cboPedidoVenda.SelectedValue, _
                                                         cboCodigoItem.SelectedValue)

            'Fecha o Formulário
            Me.Dispose()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class