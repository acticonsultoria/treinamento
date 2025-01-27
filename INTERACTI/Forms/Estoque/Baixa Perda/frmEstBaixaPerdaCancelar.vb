Imports Janus.Windows.GridEX

Public Class frmEstBaixaPerdaCancelar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstBaixaPerda As New clsUsrEstBaixa

    Private sNumeroDocumento As String
    Private sData As String
    Private sDeposito As String
    Private lCodigoBaixaPerda As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public Property Data() As String
        Get
            Return sData
        End Get
        Set(ByVal value As String)
            sData = value
        End Set
    End Property

    Public Property Deposito() As String
        Get
            Return sDeposito
        End Get
        Set(ByVal value As String)
            sDeposito = value
        End Set
    End Property

    Public Property CodigoBaixaPerda() As Long
        Get
            Return lCodigoBaixaPerda
        End Get
        Set(ByVal value As Long)
            lCodigoBaixaPerda = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmEstBaixaPerdaCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmEstBaixaPerdaCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Cancelar Baixa para Perda
            Call Cancelar()

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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmEstBaixaPerdaCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Controles
            txtNumeroDocumento.Text = sNumeroDocumento
            txtData.Text = sData
            txtDeposito.Text = sDeposito

            'Seta Focu
            txtJustificativa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o Usuário Cancelar
            If MsgBox("Deseja Cancelar a Baixa para Perda Efetuada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                Call oClsEstBaixaPerda.Status(lCodigoBaixaPerda, _
                                              txtJustificativa.Text.Trim, _
                                              StatusBaixaPerda.Cancelado)


                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Fecha Formulário
                Me.Dispose()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class