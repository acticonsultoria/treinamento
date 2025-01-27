Imports Janus.Windows.GridEX

Public Class frmFinChequeCompensar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmFinChequeCompensar As New clsFrmFinChequeCompensar
    Private oGrid As GridEX
    Private sTipo As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return sTipo
        End Get
        Set(ByVal value As String)
            sTipo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinChequeCompensar_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnCompensar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompensar.Click

        Try

        'Cancela o Título
        CompensarCheque()

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
            txtNumeroDocumento.Text = oGrid.CurrentRow.Cells("numero_documento").Value
            txtParceiroNegocio.Text = oGrid.CurrentRow.Cells("parceiro_negocio").Value
            lblParceiroNegocio.Text = IIf(sTipo = "R", "Cliente:", "Fornecedor:")
            txtNumerCheque.Text = oGrid.CurrentRow.Cells("numero_cheque").Value
            txtContaBancaria.Text = oGrid.CurrentRow.Cells("conta_bancaria").Value
            txtDataPagamento.Text = oGrid.CurrentRow.Cells("data_pagamento").Value
            txtPreDatadoPara.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("pre_datado").Value), "", oGrid.CurrentRow.Cells("pre_datado").Value)
            dtpDataCompensacao.Value = Now.Date

            'Seta Focu
            dtpDataCompensacao.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CompensarCheque()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário Deseja Compensar o Cheque Selecionado
            If MsgBox("Deseja Compensar o Cheque Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Parâmetros
                oClsFrmFinChequeCompensar.CodigoTituloCapa = oGrid.CurrentRow.Cells("codigo_titulo_capa").Value
                oClsFrmFinChequeCompensar.NumeroParcela = oGrid.CurrentRow.Cells("numero_parcela").Value
                oClsFrmFinChequeCompensar.CodigoTituloParcelaPagamento = oGrid.CurrentRow.Cells("codigo_titulo_parcela_pagamento").Value
                oClsFrmFinChequeCompensar.DataCompensacao = dtpDataCompensacao.Value
                oClsFrmFinChequeCompensar.CodigoTituloCapaReceita = IIf(IsDBNull(oGrid.CurrentRow.Cells("codigo_titulo_capa_receita").Value), -1, oGrid.CurrentRow.Cells("codigo_titulo_capa_receita").Value)
                oClsFrmFinChequeCompensar.NumeroParcelaReceita = IIf(IsDBNull(oGrid.CurrentRow.Cells("numero_parcela_receita").Value), -1, oGrid.CurrentRow.Cells("numero_parcela_receita").Value)
                oClsFrmFinChequeCompensar.CodigoTituloParcelaPagamentoReceita = IIf(IsDBNull(oGrid.CurrentRow.Cells("codigo_titulo_parcela_pagamento_receita").Value), -1, oGrid.CurrentRow.Cells("codigo_titulo_parcela_pagamento_receita").Value)
                'Compensa Cheque
                Call oClsFrmFinChequeCompensar.CompensarCheque()

                'Preenche Controle
                oGrid.SetValue("data_compensacao", dtpDataCompensacao.Value)
                oGrid.SetValue("status_pagamento", StatusReceitaPagamento.Quitado)
                oGrid.Refresh()

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