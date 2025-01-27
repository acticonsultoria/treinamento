Imports Janus.Windows.GridEX

Public Class frmFinDespesaCartaoCreditoPagarFatura

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFinDespesaCartaoCredito As New clsUsrFinDespesaCartaoCredito
    Private sBandeira As String
    Private sCartaoCredito As String
    Private sDataVencimento As String
    Private dValor As Double
    Private iCodigoCartaoCredito As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Bandeira() As String
        Set(ByVal value As String)
            sBandeira = value
        End Set
    End Property

    Public WriteOnly Property CartaoCredito() As String
        Set(ByVal value As String)
            sCartaoCredito = value
        End Set
    End Property

    Public WriteOnly Property DataVencimento() As String
        Set(ByVal value As String)
            sDataVencimento = value
        End Set
    End Property

    Public WriteOnly Property CodigoCartaoCredito() As Integer
        Set(ByVal value As Integer)
            iCodigoCartaoCredito = value
        End Set
    End Property

    Public WriteOnly Property Valor() As Double
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinDespesaCartaoCreditoPagarFatura_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        Try

            'Verifica se foi Selecionado o Valor
            If ValidaCampo(txtValor, lblValor, True) = False Then
                Exit Sub
            End If

            'Pagar Fatura
            PagarFatura()

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
            txtBandeira.Text = sBandeira
            txtCartaoCredito.Text = sCartaoCredito
            txtDataVencimento.Text = sDataVencimento
            dtpDataPagamento.Value = Now.Date

            'Seta Focu
            dtpDataPagamento.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub PagarFatura()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário Deseja Pagar a Fatura Selecionada
            If MsgBox("Deseja Pagar a Fatura Selecionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Váriavel Local
                Dim dPercentual As Double

                dPercentual = txtValor.Value / dValor

                'Compensa Cheque
                Call oClsUsrFinDespesaCartaoCredito.UpdateStatusFatura(iCodigoCartaoCredito, _
                                                                       txtDataVencimento.Text.Trim, _
                                                                       dtpDataPagamento.Value, _
                                                                       dPercentual)

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