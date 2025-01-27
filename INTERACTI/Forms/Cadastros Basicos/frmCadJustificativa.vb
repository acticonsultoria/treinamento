Imports Janus.Windows.GridEX

Public Class frmCadJustificativa

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenPedido As New clsUsrVenPedido

    Private sTable As String
    Private lCodigo As Long
    Private iCodigo2 As Integer
    Private iCodigo3 As Integer
    Private sTipo As String
    Private sRetorno As String = "N"

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Table() As String
        Set(ByVal value As String)
            sTable = value
        End Set
    End Property

    Public WriteOnly Property Codigo() As Long
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

    Public WriteOnly Property Codigo2() As Integer
        Set(ByVal value As Integer)
            iCodigo2 = value
        End Set
    End Property

    Public WriteOnly Property Codigo3() As Integer
        Set(ByVal value As Integer)
            iCodigo3 = value
        End Set
    End Property

    Public WriteOnly Property Tipo() As String
        Set(ByVal value As String)
            sTipo = value
        End Set
    End Property

    Public ReadOnly Property Retorno() As String
        Get
            Return sRetorno
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadJustificativa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadJustificativa_Load(sender As Object, e As EventArgs) Handles Me.Load

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

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salvar
                Salvar()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadJustificativa_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Focu
            txtJustificativa.Focus()

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

            'Insere Justificativa
            Call InsertJustificativa(txtJustificativa.Text.Trim, _
                                     txtMotivo.Text.Trim, _
                                     sTable, _
                                     sTipo, _
                                     lCodigo, _
                                     iCodigo2, _
                                     iCodigo3)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Seta Retorno
            sRetorno = "S"

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

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
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