Imports Janus.Windows.GridEX

Public Class frmVenPedidoCancelarItem

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsVenPedido As New clsUsrVenPedido

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

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenPedidoCancelarItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboJustificativaCancelamento" : Call LoadCombo(cboJustificativaCancelamento, "sp_select_combo_venda_justificativa_cancelamento " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboJustificativaCancelamento" : Call btnCadastrarJustificativaCancelamento_Click(btnCadastrarJustificativaCancelamento, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenPedidoCancelarItem_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnCadastrarJustificativaCancelamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarJustificativaCancelamento.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrVenJustificativaCancelamento"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location: oForm.Tamanho = True
            oForm.Titulo = Me.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            Call LoadCombo(cboJustificativaCancelamento, "sp_select_combo_venda_justificativa_cancelamento " & goUsuario.iEmpresa)

            'Seta Focu
            cboJustificativaCancelamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancelar Produto do Orçamento
                Cancelar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboJustificativaCancelamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJustificativaCancelamento.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum E-mail
            If cboJustificativaCancelamento.SelectedIndex > -1 Then
                'Preenche Controle
                LoadDescricao(txtJustificativa, "sp_select_venda_justificativa_cancelamento_texto " & cboJustificativaCancelamento.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenPedidoCancelarItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo            
            Call LoadCombo(cboJustificativaCancelamento, "sp_select_combo_venda_justificativa_cancelamento " & goUsuario.iEmpresa)

            'Verifica Direito
            ' btnCadastrarJustificativaCancelamento.Enabled = VerificaDireito(Formulario.ComercialJustificativaCancelamento, gcInsert)

            'Carrega Controles
            Call oClsVenPedido.LoadDadosItem(oGrid.CurrentRow.Cells("codigo_pedido").Value, _
                                             oGrid.CurrentRow.Cells("codigo_pedido_item").Value, _
                                             txtNumeroPedido, _
                                             txtDataPedido, _
                                             txtCliente, _
                                             txtItem, _
                                             txtQuantidade, _
                                             txtUnidadeMedida, _
                                             txtValorUnitario, _
                                             txtValorTotal)

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
            If MsgBox("Deseja Cancelar o Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancela Orçamento
                Call oClsVenPedido.CancelarItem(oGrid.CurrentRow.Cells("codigo_pedido").Value, _
                                                oGrid.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                txtQuantidadeCancelar.Value, _
                                                IIf(cboJustificativaCancelamento.SelectedIndex = -1, -1, cboJustificativaCancelamento.SelectedValue), _
                                                txtJustificativa.Text.Trim)

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

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Informado a Quantidade
            If ValidaCampo(txtQuantidadeCancelar, lblQuantidadeCancelar, True) = False Then
                Exit Function
            ElseIf txtQuantidadeCancelar.Value > txtQuantidade.Value Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Quantidade Cancelada não pode ser maior que a Quantidade.")
                txtQuantidadeCancelar.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtJustificativa.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class