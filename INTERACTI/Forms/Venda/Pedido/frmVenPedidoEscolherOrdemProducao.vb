Imports Janus.Windows.GridEX

Public Class frmVenPedidoEscolherOrdemProducao

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenPedidoLegado As New clsUsrVenPedidoLegado

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

    Private Sub grdOrdemProducaoVisualizar_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOrdemProducaoVisualizar.RowDoubleClick

        Try

            lCodigo = grdOrdemProducaoVisualizar.GetValue("codigo")

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

            oClsUsrVenPedidoLegado.LoadGridProducaoVisualizar(grdOrdemProducaoVisualizar, _
                                                                 sCodigo)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


#End Region

End Class