Imports Janus.Windows.GridEX

Public Class frmCadControleAdicionar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenPedido As New clsUsrVenPedido

    Private sFormulario As String
    Private sControle As String
    Private lCodigo As Long = -1

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Formulario() As String
        Set(ByVal value As String)
            sFormulario = value
        End Set
    End Property

    Public WriteOnly Property Controle() As String
        Set(ByVal value As String)
            sControle = value
        End Set
    End Property

    Public WriteOnly Property Codigo() As Long
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadControleAdicionar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadControleAdicionar_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Adiciona Controle
                Call Adicionar()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadControleAdicionar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboControle, "sp_select_combo_cadastro_basico_controle " & goUsuario.iEmpresa, False)
            cboControle.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Adicionar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona Controle
            Call AdicionarControles(sFormulario, _
                                    sControle, _
                                    cboControle.SelectedValue, _
                                    txtPosicaoX.Value, _
                                    txtPosicaoY.Value, _
                                    txtLargura.Value, _
                                    lCodigo)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Controle
            If ValidaCampo(cboControle, lblControle) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Posição X
            If ValidaCampo(txtPosicaoX, lblPosicaoX, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Posição Y
            If ValidaCampo(txtPosicaoY, lblPosicaoY, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tamanho
            If ValidaCampo(txtLargura, lblLargura, True) = False Then
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