Imports Janus.Windows.GridEX

Public Class frmLnkVendaFaturamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsLnk As New clsFrmLnk

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmLnkVendaFaturamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                           cboNumeroPedidoVenda.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboNumeroPedidoVenda" : Call LoadCombo(cboNumeroPedidoVenda, "sp_select_combo_venda_pedido_faturamento " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmLnkVendaFaturamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Valida dados da Ordem de Produção
            If Validacao() = True Then

                'Salva Formulário
                Call Salvar()

            End If

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

    Private Sub cboNumeroPedidoVenda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroPedidoVenda.SelectedIndexChanged

        Try

            'Carrega Combo
            If cboNumeroPedidoVenda.SelectedIndex = -1 Then
                txtCliente.Text = ""
                cboNotaFiscal.DataSource = Nothing : cboNotaFiscal.Text = ""
            Else
                Call LoadDescricao(txtCliente, "sp_select_venda_pedido_cliente " & cboNumeroPedidoVenda.SelectedValue & ", " & goUsuario.iEmpresa)
                Call LoadCombo(cboNotaFiscal, "sp_select_combo_faturamento_nota_fiscal_pedido " & LoadDescricao("sp_select_venda_pedido_codigo_cliente " & cboNumeroPedidoVenda.SelectedValue & ", " & goUsuario.iEmpresa) & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
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

            'Verifica Direito            
            btnSalvar.Enabled = VerificaDireito(Formulario.LinkVendaProducao, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboNumeroPedidoVenda, "sp_select_combo_venda_pedido_faturamento " & goUsuario.iEmpresa)

            'Seta Focu
            cboNumeroPedidoVenda.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Verifica se o Usuário Confirma os Dados do Apontamento
            If MsgBox("Deseja estabelecer um Link entre o Pedido de Venda: " & cboNumeroPedidoVenda.Text & " e a Nota Fiscal: " & cboNotaFiscal.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Atualiza Apontamento
                oClsLnk.LinkVendaFaturamento(cboNumeroPedidoVenda.SelectedValue, _
                                             cboNotaFiscal.SelectedValue)

                'Limpa Formulário
                Call LoadCombo(cboNumeroPedidoVenda, "sp_select_combo_venda_pedido_faturamento " & goUsuario.iEmpresa)


                'Informa o Usuário sobre o sucesso da Operação
                MsgBox("Link estabelecido com sucesso!!!", MsgBoxStyle.Information)

                'Limpa Controles
                cboNumeroPedidoVenda.SelectedIndex = -1
                cboNotaFiscal.SelectedIndex = -1

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Pedido de Venda
            If ValidaCampo(cboNumeroPedidoVenda, lblNumerPedidoVenda) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ordem de Produção
            If ValidaCampo(cboNotaFiscal, lblNotaFiscal) = False Then
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
