Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFeDestinadaRecusa

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF
    Private sChaveAcesso As String
    Private sNotaFiscal As String
    Private sDataEmissao As String
    Private sEmitente As String

#End Region

#Region "::: PROPERTIE :::"
  
    Public WriteOnly Property ChaveAcesso() As String
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

    Public WriteOnly Property NotaFiscal() As String
        Set(ByVal value As String)
            sNotaFiscal = value
        End Set
    End Property

    Public WriteOnly Property DataEmissao() As String
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public WriteOnly Property Emitente() As String
        Set(ByVal value As String)
            sEmitente = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFeDestinadaRecusa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFeDestinadaRecusa_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Recusar a Nota Fiscal
                Call RecusaNotaFiscal()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEntradaNFeDestinadaRecusa_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Dados da Nota Fiscal            
            txtNotaFiscal.Text = sNotaFiscal
            txtDataEmissao.Text = sDataEmissao
            txtEmitente.Text = sEmitente
            txtChaveAcesso.Text = sChaveAcesso

            'Seta Focu
            txtJustificativa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CANCELAR NOTA FISCAL :::"

    Private Sub RecusaNotaFiscal()

        Try

            'Verifica se o Usuário deseja Recusar a Noat Fiscal
            If MsgBox("Deseja informar o Status da Nota Fiscal de Entrada?" & vbCrLf & vbCrLf & "ATENÇÃO, ESSE PROCESSO É IRREVERSÍVEL!", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                Exit Sub
            End If

            'Instanciando a classe
            Dim oClsNFeManifestacaoDestinatario As New clsNFeManifestacaoDestinatario_V4

            oClsNFeManifestacaoDestinatario.Justificativa = txtJustificativa.Text.Trim

            'Enviando a sequência "1", e o nº do lote 100
            If oClsNFeManifestacaoDestinatario.SendOperacaoNaoRealizada(sChaveAcesso, txtSequencia.Text, 100) = False Then

                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oClsNFeManifestacaoDestinatario.MensagemErro)

            Else

                'Tratamento das informações do retorno
                If oClsNFeManifestacaoDestinatario.LoadArquivoOperacaoNaoRealizada() = False Then
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oClsNFeManifestacaoDestinatario.MensagemErro)
                Else
                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
                End If

            End If

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

#End Region

End Class