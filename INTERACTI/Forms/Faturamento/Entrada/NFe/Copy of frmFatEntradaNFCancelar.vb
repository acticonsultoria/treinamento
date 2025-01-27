Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFCancelar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF
    Private sNotaFiscal As String
    Private sSerie As String
    Private sDataEmissao As String
    Private sDataEntrada As String
    Private sEmitente As String
    Private lCodigoEntradaCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NotaFiscal() As String
        Set(ByVal value As String)
            sNotaFiscal = value
        End Set
    End Property

    Public WriteOnly Property Serie() As String
        Set(ByVal value As String)
            sSerie = value
        End Set
    End Property

    Public WriteOnly Property DataEmissao() As String
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public WriteOnly Property DataEntrada() As String
        Set(ByVal value As String)
            sDataEntrada = value
        End Set
    End Property

    Public WriteOnly Property Emitente() As String
        Set(ByVal value As String)
            sEmitente = value
        End Set
    End Property

    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

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

                'Cancela Nota Fiscal
                Call CancelarNotaFiscal()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEntradaNFCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Dados da Nota Fiscal            
            txtNotaFiscal.Text = sNotaFiscal
            txtSerie.Text = sSerie
            txtDataEmissao.Text = sDataEmissao
            txtDataEntrada.Text = sDataEntrada
            txtEmitente.Text = sEmitente

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

    Private Sub CancelarNotaFiscal()

        Try

            'Verifica se o usuário deseja cancelar a Nota fiscal
            If MsgBox("Deseja Cancelar a Nota Fiscal: " & vbCrLf & _
                      "NOTA FISCAL: " & Format(CLng(txtNotaFiscal.Text), "000000000") & vbCrLf & _
                      "SÉRIE: " & Format(CInt(txtSerie.Text), "000") & vbCrLf & _
                      "EMITENTE: " & txtEmitente.Text.Trim & vbCrLf & vbCrLf & _
                      "Obs.: O Cancelamento desta Nota Fiscal pode impactar no Estoque", _
                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancelar Nota Fiscal
                Call oClsFatEntradaNF.Cancelar(lCodigoEntradaCapa, _
                                               txtJustificativa.Text.Trim)

                ''Integração
                Call Integracao()

                'Fecha o Formulário
                Me.Dispose()

            End If

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

#Region " ::: INTEGRAÇÃO ::: "

    Private Sub Integracao()

        Try
            
            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Integração - Compras
            oClsIntegracao.IntegracaoNFEntradaCompras(lCodigoEntradaCapa)
            'Integração - Estoque
            oClsIntegracao.IntegracaoNFEntradaEstoque(lCodigoEntradaCapa)
            'Integração - Financeiro
            oClsIntegracao.IntegracaoNFEntradaFinanceiro(lCodigoEntradaCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class