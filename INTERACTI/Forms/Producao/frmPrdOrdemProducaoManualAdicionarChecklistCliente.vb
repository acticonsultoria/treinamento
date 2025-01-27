Imports Janus.Windows.GridEX

Public Class frmPrdOrdemProducaoManualAdicionarChecklistCliente

#Region "::: VARIAVEIS :::"

    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
    Private lCodigoOrdemProducao As Long

#End Region

#Region "::: PROPERTY :::"

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

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Exit Sub

            Salvar()

            'Fecha o Controle
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
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            txtDescricao.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            oClsUsrPrdProducaoManual.InsertChecklistCliente(lCodigoOrdemProducao:=lCodigoOrdemProducao,
                                                             sDescricao:=txtDescricao.Text.Trim)

            frmMain.Informacao(Mensagem.RegistroInserido)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class