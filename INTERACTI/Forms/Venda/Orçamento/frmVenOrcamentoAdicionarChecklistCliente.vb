Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoAdicionarChecklistCliente

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private lCodigoOrcamento As Long

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoOrcamento() As Long
        Get
            Return lCodigoOrcamento
        End Get
        Set(ByVal value As Long)
            lCodigoOrcamento = value
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

            LoadComboSimNao(cboImpressoProposta) : cboImpressoProposta.SelectedValue = 1
            LoadComboSimNao(cboExportadoOP) : cboExportadoOP.SelectedValue = 1

            txtDescricao.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            oClsUsrVenOrcamentoLegado.InsertChecklistCliente(lCodigoOrcamento:=lCodigoOrcamento,
                                                             sDescricao:=txtDescricao.Text.Trim,
                                                             bImpressoProposta:=cboImpressoProposta.SelectedValue,
                                                             bExportadoParaOP:=cboExportadoOP.SelectedValue)

            frmMain.Informacao(Mensagem.RegistroInserido)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class