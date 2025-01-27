Imports Janus.Windows.GridEX

Public Class frmPrdItensBom

#Region "::: VARIAVEIS :::"

    Private oClsPrdOrdemProducao As New clsUsrPrdOrdemProducao
    Private lCodigoOrdemProducao As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoOrdemProducao() As Long
        Get
            Return lCodigoOrdemProducao
        End Get
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmPrdItensBom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmPrdItensBom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnGerarRequisicao_Click(sender As Object, e As EventArgs) Handles btnGerarRequisicao.Click

        Try

            If grdListagem.GetDataRows.Count = 0 Then

                MsgBox("Não é possivel gerar uma requisição pois o item selecionado não possui BOM")
                Exit Sub

            End If

            If MsgBox("Deseja gerar a requisição de estoque para essa Ordem de Produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            GerarRequisicao()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroInserido)

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frmPrdItensBom_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsPrdOrdemProducao.LoadGridItensBom(grdListagem, _
                                                  lCodigoOrdemProducao)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarRequisicao()

        Try

            oClsPrdOrdemProducao.RequisicaoEstoque(lCodigoOrdemProducao)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class