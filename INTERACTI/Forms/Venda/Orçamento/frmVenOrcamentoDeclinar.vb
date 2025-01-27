Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoDeclinar

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private lCodigoOrcamento As Long

#End Region

#Region "::: PROPERTY :::"

    Public WriteOnly Property CodigoOrcamento As Long
        Set(value As Long)
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

    Private Sub btnCadastrarJustificativa_Click(sender As Object, e As EventArgs) Handles btnCadastrarJustificativa.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadJustificativaOrcamento")

            'Carrega Combo            
            LoadCombo(cboJustificativa, "sp_select_combo_cadastro_basico_justificativa_orcamento " & goUsuario.iEmpresa, True)

            cboJustificativa.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboJustificativa, lblJustificativa) = False Then Exit Sub

            If MsgBox("Deseja declinar o orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            oClsUsrVenOrcamentoLegado.UpdateStatusDeclinado(lCodigoOrcamento, _
                                                            cboJustificativa.SelectedValue)

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboJustificativa, "sp_select_combo_cadastro_basico_justificativa_orcamento " & goUsuario.iEmpresa, True)

            cboJustificativa.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


#End Region

End Class