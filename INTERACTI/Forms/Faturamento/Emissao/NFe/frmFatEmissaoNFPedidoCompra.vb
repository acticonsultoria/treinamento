Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Dundas.Charting.WinControl
Imports Janus.Windows.CalendarCombo

Public Class frmFatEmissaoNFPedidoCompra

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private lCodigoEmitente As Long

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEmissaoCapa() As Long
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public WriteOnly Property CodigoEmissaoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoEmissaoItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoEmitente() As Long
        Set(ByVal value As Long)
            lCodigoEmitente = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFHistorico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFHistorico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))
            Call LoadCombo(cboPedidoCompra, "sp_select_combo_faturamento_entrada_pedido_compra_retorno " & lCodigoEmitente & "," & goUsuario.iEmpresa)



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

    Private Sub cboPedidoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedidoCompra.SelectedIndexChanged

        Try

            cboCodigoItem.SelectedIndex = -1
            cboCodigoItem.Text = ""
            cboCodigoItem.DataSource = Nothing

            If cboPedidoCompra.SelectedIndex <> -1 Then

                Call LoadCombo(cboCodigoItem, "sp_select_combo_faturamento_entrada_pedido_compra_item_retorno " & cboPedidoCompra.SelectedValue & "," & goUsuario.iEmpresa)

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoItem.SelectedIndexChanged

        Try

            txtQuantidade.Value = 0
            txtReferencia.Text = ""

            If cboCodigoItem.SelectedIndex = -1 Then Exit Sub

            oClsFatEmissaoNFe.LoadControles(cboPedidoCompra.SelectedValue, _
                                            cboCodigoItem.SelectedValue, _
                                            txtQuantidade, _
                                            txtReferencia)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            If Validacao() = True Then

                Call Salvar()

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Public Function Validacao() As Boolean

        Try

            Validacao = False

            If ValidaCampo(cboPedidoCompra, lblPedidoCompra) = False Then
                Exit Function
            End If

            If ValidaCampo(cboCodigoItem, lblItem) = False Then
                Exit Function
            End If

            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            Call oClsFatEmissaoNFe.InsertComprasRetornoConserto(lCodigoEmissaoCapa, _
                                                               iCodigoEmissaoItem, _
                                                               cboPedidoCompra.SelectedValue, _
                                                               cboCodigoItem.SelectedValue, _
                                                               cboPedidoCompra.Text.Trim)

            'Fecha o Formulário
            Me.Dispose()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class