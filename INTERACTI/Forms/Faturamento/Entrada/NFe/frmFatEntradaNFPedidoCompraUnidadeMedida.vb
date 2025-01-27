Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFPedidoCompraUnidadeMedida

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private dQuantidade As Double
    Private oClsCmpPedido As New clsUsrCmpPedido

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoPedido() As Long
        Get
            Return lCodigoPedido
        End Get
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public Property CodigoPedidoItem() As Integer
        Get
            Return iCodigoPedidoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoItem = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFPedidoCompraUnidadeMedida_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboUnidadeMedidaNova" : Call LoadCombo(cboUnidadeMedidaNova, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboUnidadeMedidaNova" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFPedidoCompraUnidadeMedida_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

             'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            Call LoadCombo(cboUnidadeMedidaNova, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
            'Seta Focu
            cboUnidadeMedidaNova.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Fecha o Formulário
                Me.Dispose()

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

    Private Sub AtualizaQuantidade(sender As Object, e As EventArgs) Handles txtFatorConversao.LostFocus, _
                                                                             txtQuantidadeNova.LostFocus

        Try

            'Seta Valores
            Select Case sender.name
                Case "txtFatorConversao" : txtQuantidadeNova.Value = txtQuantidade.Value * txtFatorConversao.Value
                Case "txtQuantidadeNova" : txtFatorConversao.Value = txtQuantidadeNova.Value / txtQuantidade.Value
            End Select

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

            'Verifica Direito
            btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

            'Carrega Combo - Unidade de Medida
            Call LoadCombo(cboUnidadeMedidaNova, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)

            'Obtém Quantidade
            txtQuantidade.Value = dQuantidade

            'Carrega Dados do Pedido
            Call oClsCmpPedido.LoadDadosProdutoRecebimento(lCodigoPedido, _
                                                           iCodigoPedidoItem, _
                                                           txtNumeroPedidoCompra, _
                                                           txtItem, _
                                                           txtUnidadeMedida)

            'Seta Focu
            cboUnidadeMedidaNova.Focus()
            
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Altera Dados do Pedido
            Call oClsCmpPedido.UpdatePedidoCompraRecebimento(lCodigoPedido, _
                                                             iCodigoPedidoItem, _
                                                             txtQuantidadeNova.Value / txtQuantidade.Value, _
                                                             cboUnidadeMedidaNova.SelectedValue, _
                                                             cboUnidadeMedidaNova.Text.Trim)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedidaNova, lblUnidadeMedidaNova) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fator de Conversão
            If ValidaCampo(txtFatorConversao, lblFatorConversao, True) = False Then
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