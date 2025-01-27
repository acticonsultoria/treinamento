Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoEscolherPedidoVenda

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado

    Private sCodigo As String
    Private lCodigo As Long = -1

#End Region

#Region "::: PROPERTY :::"

    Public ReadOnly Property Codigo As Integer
        Get
            Return lCodigo
        End Get
    End Property

    Public WriteOnly Property Codigos As String
        Set(value As String)
            sCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub grdPedidoVenda_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdPedidoVenda.RowDoubleClick

        Try

            lCodigo = grdPedidoVenda.GetValue("codigo")

            Me.Dispose()

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
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            oClsUsrVenOrcamentoLegado.LoadGridPedidoVenda(grdPedidoVenda, _
                                                          sCodigo)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


#End Region

End Class