Imports Janus.Windows.GridEX

Public Class frmCadParceiroNegocioCRMComentarioInserir

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio

    'Váriaveis
    Private sCliente As String
    Private sAssunto As String
    Private iCodigo As Integer
    Private iCodigoCRM As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Cliente() As String
        Get
            Return sCliente
        End Get
        Set(ByVal value As String)
            sCliente = value
        End Set
    End Property

    Public Property Assunto() As String
        Get
            Return sAssunto
        End Get
        Set(ByVal value As String)
            sAssunto = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property CodigoCRM() As Integer
        Get
            Return iCodigoCRM
        End Get
        Set(ByVal value As Integer)
            iCodigoCRM = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadParceiroNegocioCRMComentarioInserir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadParceiroNegocioCRMComentarioInserir_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salvar Histórico
                Call Salvar()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadParceiroNegocioCRMComentarioInserir_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)

            'Carrega Controles
            txtAssunto.Text = sAssunto
            txtCliente.Text = sCliente

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Cancela Orçamento
            Call oClsCadParceiroNegocio.InsertCRMComentario(iCodigo, _
                                                            iCodigoCRM, _
                                                            txtHistorico.Text.Trim)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Fecha o Formulário
            Me.Dispose()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Histórico
            If ValidaCampo(txtHistorico, lblHistorico, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtHistorico.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtHistorico.Focus()
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