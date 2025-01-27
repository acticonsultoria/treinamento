Imports Janus.Windows.GridEX

Public Class frmCadParceiroNegocioAdicionarChecklistCliente

#Region "::: VARIAVEIS :::"

    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio
    Private lCodigoParceiroNegocio As Long

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoParceiroNegocio() As Long
        Get
            Return lCodigoParceiroNegocio
        End Get
        Set(ByVal value As Long)
            lCodigoParceiroNegocio = value
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

            LoadComboSimNao(cboImpressoProposta) : cboImpressoProposta.SelectedValue = 0
            LoadComboSimNao(cboExportadoOP) : cboExportadoOP.SelectedValue = 1

            txtDescricao.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            oClsCadParceiroNegocio.InsertChecklistCliente(lCodigoParceiroNegocio:=lCodigoParceiroNegocio,
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