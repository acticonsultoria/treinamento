Imports Janus.Windows.GridEX

Public Class frmCmpCotacaoItemCancelar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpCotacaoItemCancelar As New clsFrmCmpCotacaoItemCancelar
    Private sNumeroCotacao As String
    Private sNumeroRequisicao As String
    Private sDataCotacao As String
    Private sDataNecessidade As String
    Private sItem As String
    Private lCodigoCotacao As Long
    Private iCodigoCotacaoItem As Integer

#End Region

#Region "::: PROPERTIES :::"

    Public WriteOnly Property NumeroCotacao() As String
        Set(ByVal value As String)
            sNumeroCotacao = value
        End Set
    End Property

    Public WriteOnly Property NumeroRequisicao() As String
        Set(ByVal value As String)
            sNumeroRequisicao = value
        End Set
    End Property

    Public WriteOnly Property DataCotacao() As String
        Set(ByVal value As String)
            sDataCotacao = value
        End Set
    End Property

    Public WriteOnly Property DataNecessidade() As String
        Set(ByVal value As String)
            sDataNecessidade = value
        End Set
    End Property

    Public WriteOnly Property Item() As String
        Set(ByVal value As String)
            sItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoCotacao() As Long
        Set(ByVal value As Long)
            lCodigoCotacao = value
        End Set
    End Property

    Public WriteOnly Property CodigoCotacaoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoCotacaoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpCotacaoItemCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpCotacaoItemCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Fecha Formulário
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpCotacaoItemCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Verifica Direito
            btnCancelar.Enabled = VerificaDireito(Formulario.ComprasCotacaoCancelar, gcInsert)

            'Carrega Controles
            txtNumeroCotacao.Text = sNumerocotacao
            txtNumeroRequisicao.Text = sNumeroRequisicao
            txtDataCotacao.Text = IIf(IsDate(sDataCotacao), Format(CDate(sDataCotacao), "dd/MM/yyyy"), "")
            If IsDate(sDataNecessidade) Then txtDataNecessidade.Text = Format(CDate(sDataNecessidade), "dd/MM/yyyy") Else txtDataNecessidade.Text = ""
            txtItem.Text = sItem

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

            'Cancela Item da Cotação
            oClsCmpCotacaoItemCancelar.CancelarCotacaoItem(lCodigoCotacao, _
                                                           iCodigoCotacaoItem, _
                                                           txtJustificativa.Text.Trim)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.errInfo.SetError(lblJustificativa, "A Justificativa do Cancelamento do Item da Cotação deve possuir ao menos 15 Caracteres.")
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