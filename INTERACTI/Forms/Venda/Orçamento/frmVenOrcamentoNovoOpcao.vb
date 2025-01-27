Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoNovoOpcao

#Region "::: VARIAVEIS :::"

    Private iOpcao As Integer = -1

#End Region

#Region "::: PROPERTY :::"

    Public ReadOnly Property Opcao As Integer
        Get
            Return iOpcao
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"



    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

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


    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click

        Try

            If optOrcamentoLimpo.Checked = True Then
                iOpcao = 1
            ElseIf optClonarOrcamento.Checked = True Then
                iOpcao = 2
            ElseIf optImportarPlanilha.Checked = True Then
                iOpcao = 3
            End If

            'Fecha o Controle
            Me.Dispose()

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

            'Adiciona KeyUP
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


#End Region

End Class