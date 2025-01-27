Imports Janus.Windows.EditControls

Public Class frmVenHistoricoParceiroNegocio

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio
    Private iCodigoParceiroNegocio As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoParceiroNegocio() As Integer
        Get
            Return iCodigoParceiroNegocio
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiroNegocio = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenHistoricoParceiroNegocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    'Fecha o Controle
                    Me.Dispose()

                Case Keys.Down
                    If Not grdVendas.CurrentRow Is Nothing Then
                        If grdVendas.CurrentRow.RowType = Janus.Windows.GridEX.RowType.FilterRow Then
                            grdVendas.Row = 1
                        End If
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenHistoricoParceiroNegocio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Carrega Grid - Vendas
            oClsCadParceiroNegocio.LoadGridPedidoVenda(grdVendas, _
                                                       iCodigoParceiroNegocio)

            'Carrega Grid - Compras
            oClsCadParceiroNegocio.LoadGridPedidoCompra(grdCompras, _
                                                        iCodigoParceiroNegocio)

            'Carrega Dados do Parceiro de Negócio
            oClsCadParceiroNegocio.LoadControles(iCodigoParceiroNegocio, _
                                                 txtCNPJ, _
                                                 txtParceiroNegocio, _
                                                 txtUF, _
                                                 txtMunicipio)

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenHistoricoParceiroNegocio_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Focu
            grdVendas.Focus()
            System.Windows.Forms.SendKeys.Send("{UP}")
            System.Windows.Forms.SendKeys.Send("{RIGHT 3}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class