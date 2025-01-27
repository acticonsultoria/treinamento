Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFsCancelar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lNotaFiscal As Long
    Private sSerie As String
    Private sDataEmissao As String
    Private sPrestador As String
    Private sCodigoVerificacao As String
    Private lCodigoNFSCapa As Long
    Private oClsFatEntradaNFs As New clsUsrFatEntradaNFs

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NotaFiscal() As Long
        Set(ByVal value As Long)
            lNotaFiscal = value
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

    Public WriteOnly Property Prestador() As String
        Set(ByVal value As String)
            sPrestador = value
        End Set
    End Property

    Public WriteOnly Property CodigoVerificacao() As String
        Set(ByVal value As String)
            sCodigoVerificacao = value
        End Set
    End Property

    Public WriteOnly Property CodigoNFSCapa() As Long
        Set(ByVal value As Long)
            lCodigoNFSCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFsCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFatEntradaNFsCancelar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancelar Nota Fiscal
                CancelarNFSe()

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

            'Carrega Dados da Nota Fiscal
            txtNotaFiscal.Text = Format(lNotaFiscal, "000000000")
            txtSerie.Text = sSerie
            txtDataEmissao.Text = sDataEmissao
            txtPrestador.Text = sPrestador
            txtCodigoVerificacao.Text = sCodigoVerificacao

            'Seta Controle
            txtJustificativa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CancelarNFSe()

        Try

            If MsgBox("Deseja Cancelar a Nota Fiscal de Serviço: " & vbCrLf & _
                      "NFS: " & txtNotaFiscal.Text.Trim & vbCrLf & _
                      "SÉRIE: " & txtSerie.Text.Trim & vbCrLf & _
                      "PRESTADOR: " & txtPrestador.Text.Trim, _
                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancela Nota Fiscal
                Call oClsFatEntradaNFs.Cancelar(lCodigoNFSCapa, _
                                                txtJustificativa.Text.Trim)

                'Integração
                Call Integracao()

                'Fecha Formulário
                Me.Dispose()

            End If

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
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtJustificativa.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Financeiro
            oClsIntegracao.IntegracaoNFSEntradaFinanceiro(lCodigoNFSCapa)
            'Compras
            oClsIntegracao.IntegracaoNFSEntradaPedidoCompraFinanceiro(lCodigoNFSCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class