Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFVincularPedido

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF 
    Private lCodigoEntradaCapa As Long
    Private lCodigoParceiroNegocio As Long
    Private dTotalNota As Double

#End Region

#Region "::: PROPERTIE :::"
     
    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public WriteOnly Property CodigoParceiroNegocio() As Long
        Set(ByVal value As Long)
            lCodigoParceiroNegocio = value
        End Set
    End Property

    Public WriteOnly Property TotalNota() As Double
        Set(ByVal value As Double)
            dTotalNota = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFVincularPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFVincularPedido_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVincular.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancela Nota Fiscal
                Call VincularPedido()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEntradaNFVincularPedido_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            'Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)
                        
            Call LoadCombo(cboPedidoCompra, "sp_select_combo_compras_entrada_pedido 1, " & lCodigoParceiroNegocio & ", " & dTotalNota)

            'Seta Focu
            cboPedidoCompra.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: VINCULAR PEDIDO :::"

    Private Sub VincularPedido()

        Try
             
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancelar Nota Fiscal
            Call oClsFatEntradaNF.VincularPedido(lCodigoEntradaCapa, _
                                                 cboPedidoCompra.SelectedValue)

                ' ''Integração
                'Call Integracao()

                'Fecha o Formulário
                Me.Dispose()
                 
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(cboPedidoCompra, lblPedido) = False Then
                Exit Function
            End If
             
            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    '#Region " ::: INTEGRAÇÃO ::: "

    '    Private Sub Integracao()

    '        Try

    '            'Váriavel - Integração
    '            Dim oClsIntegracao As New clsIntegracao

    '            'Integração - Compras
    '            oClsIntegracao.IntegracaoNFEntradaCompras(lCodigoEntradaCapa)
    '            'Integração - Estoque
    '            oClsIntegracao.IntegracaoNFEntradaEstoque(lCodigoEntradaCapa)
    '            'Integração - Financeiro
    '            oClsIntegracao.IntegracaoNFEntradaFinanceiro(lCodigoEntradaCapa)

    '        Catch ex As Exception
    '            Throw ex
    '        End Try

    '    End Sub

    '#End Region

#End Region

End Class