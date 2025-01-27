Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoCancelarItem

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer

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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Cancelar()

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

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            oClsUsrVenOrcamentoLegado.LoadDadosItem(lCodigoOrcamento, _
                                                    iCodigoOrcamentoItem, _
                                                    txtNumeroOrcamento, _
                                                    txtDataOrcamento, _
                                                    txtCliente, _
                                                    txtItem, _
                                                    txtQuantidade, _
                                                    txtQuantidadePedido, _
                                                    txtQuantidadeCancelada)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o Usuário deseja Cancelar o Registro
            If MsgBox("Deseja cancelar o item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancela Orçamento
                oClsUsrVenOrcamentoLegado.UpdateCancelarItem(lCodigoOrcamento, _
                                                             iCodigoOrcamentoItem, _
                                                             txtQuantidadeCancelar.Value, _
                                                             txtJustificativa.Text.Trim)

                frmMain.Informacao(Mensagem.RegistroAlterado)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(txtQuantidadeCancelar, lblQuantidadeCancelar, True) = False Then Return False

            If txtQuantidadeCancelar.Value > txtQuantidade.Value Then
                MsgBox("A quantidade a cancelar não pode ser maior que a quantidade do item!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If txtQuantidadeCancelar.Value > txtQuantidade.Value - txtQuantidadePedido.Value - txtQuantidadeCancelada.Value Then
                MsgBox("A quantidade a cancelar não pode ser maior que a quantidade restante do item!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class