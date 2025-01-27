Imports Janus.Windows.GridEX

Public Class frmFinDespesaCartaoCreditoEditarFatura

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFinDespesaCartaoCredito As New clsUsrFinDespesaCartaoCredito
    Private sNumeroDocumento As String
    Private sParceiroNegocio As String
    Private dValor As Double
    Private sDataVencimentoOriginal As String

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NumeroDocumento() As String
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public WriteOnly Property ParceiroNegocio() As String
        Set(ByVal value As String)
            sParceiroNegocio = value
        End Set
    End Property

    Public WriteOnly Property Valor() As Double
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

    Public WriteOnly Property DataVencimentoOriginal() As String
        Set(ByVal value As String)
            sDataVencimentoOriginal = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinDespesaCartaoCreditoEditarFatura_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub ConfigurarFormulario_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

            'Pagar Fatura
            Salvar()

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

            'Seta Controles
            txtNumeroDocumento.Text = sNumeroDocumento
            txtParceiroNegocio.Text = sParceiroNegocio
            txtValorParcela.Value = dValor
            txtDataVencimento.Text = sDataVencimentoOriginal
            dtpDataVencimento.Value = Now.Date

            'Seta Focu
            dtpDataVencimento.Focus()

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

            'Verifica se o Usuário Deseja Pagar a Fatura Selecionada
            If MsgBox("Deseja Alterar a Data de Vencimento da Fatura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Fecha o Formulário
                Me.Dispose()

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

#End Region

End Class