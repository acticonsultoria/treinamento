Imports Janus.Windows.GridEX

Public Class frmPrdOrdemProducaoReativar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsFrmPrdOrdemProducaoReativar As New clsFrmPrdOrdemProducaoReativar

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

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub

            ReativarOrdemProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            If IsDBNull(oGrid.CurrentRow.Cells("data_inicio").Value) = False Then txtDataInicio.Text = Format(oGrid.CurrentRow.Cells("data_inicio").Value, "dd/MM/yyyy")
            If IsDBNull(oGrid.CurrentRow.Cells("data_termino").Value) = False Then txtDataTermino.Text = Format(oGrid.CurrentRow.Cells("data_termino").Value, "dd/MM/yyyy")
            txtQuantidadePlanejada.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("quantidade_planejada").Value), "", oGrid.CurrentRow.Cells("quantidade_planejada").Value)
            txtQuantidadeRejeito.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("quantidade_rejeito").Value), "", oGrid.CurrentRow.Cells("quantidade_rejeito").Value)
            txtQuantidadeProduzida.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("quantidade_produzida").Value), "", oGrid.CurrentRow.Cells("quantidade_produzida").Value)

            'Seta Focu
            txtJustificativa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ReativarOrdemProducao()

        Try

            'Verifica se o Usuário deseja Cancelar a Ordem de Produção
            If MsgBox("Deseja Reativar a Ordem de Produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Parametros
                oClsFrmPrdOrdemProducaoReativar.CodigoOrdemProducao = oGrid.CurrentRow.Cells("codigo").Value
                oClsFrmPrdOrdemProducaoReativar.Historico = txtJustificativa.Text.Trim

                'Cancela Orçamento
                oClsFrmPrdOrdemProducaoReativar.ReativarOrdemProducao()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Function

#End Region

End Class