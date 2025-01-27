Imports Janus.Windows.GridEX

Public Class frmPrdOrdemProducaoCancelar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsPrdOrdemProducaoCancelar As New clsFrmPrdOrdemProducaoCancelar

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

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmPrdOrdemProducaoCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancelar Ordem de Produção
                CancelarOrdemProducao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            txtOrdemFabricacao.Text = oGrid.CurrentRow.Cells("ordem_producao").Value
            txtCodigoProduto.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("codigo_produto").Value), "", oGrid.CurrentRow.Cells("codigo_produto").Value)
            txtDescricao.Text = oGrid.CurrentRow.Cells("descricao").Value
            Try
                If IsDBNull(oGrid.CurrentRow.Cells("data_inicio").Value) = False Then txtDataInicio.Text = Format(oGrid.CurrentRow.Cells("data_inicio").Value, "dd/MM/yyyy")
            Catch ex As Exception : End Try
            Try
                If IsDBNull(oGrid.CurrentRow.Cells("data_termino").Value) = False Then txtDataTermino.Text = Format(oGrid.CurrentRow.Cells("data_termino").Value, "dd/MM/yyyy")
            Catch ex As Exception : End Try
            Try
                txtQuantidadePlanejada.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("quantidade_planejada").Value), "", oGrid.CurrentRow.Cells("quantidade_planejada").Value)

            Catch ex As Exception : End Try
            Try
                txtQuantidadeRejeito.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("quantidade_rejeito").Value), "", oGrid.CurrentRow.Cells("quantidade_rejeito").Value)
            Catch ex As Exception : End Try

            Try
                txtQuantidadeProduzida.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("quantidade_produzida").Value), "", oGrid.CurrentRow.Cells("quantidade_produzida").Value)

            Catch ex As Exception : End Try

            'Seta Focu
            txtJustificativa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CancelarOrdemProducao()

        Try

            'Verifica se o Usuário deseja Cancelar a Ordem de Produção
            If MsgBox("Deseja Cancelar a Ordem de Produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Parametros
                
                oClsPrdOrdemProducaoCancelar.CodigoOrdemProducao = oGrid.CurrentRow.Cells("codigo").Value
                oClsPrdOrdemProducaoCancelar.Historico = txtJustificativa.Text.Trim

                'Cancela Orçamento
                oClsPrdOrdemProducaoCancelar.CancelarOrdemProducao()

                'Cancelar Movimentação de Estoque
                oClsPrdOrdemProducaoCancelar.CancelarMovimentacaoEstoque()

                'ENVIAR EMAIL AVISANDO O COMERCIAL
                oClsPrdOrdemProducaoCancelar.EnviarEmailCancelamentoOrdemProducao()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

#End Region

End Class