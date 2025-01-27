Imports Janus.Windows.GridEX

Public Class frmFindEmpresa

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private iCodigoEmpresaNova As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmpresaNova As Integer
        Get
            Return iCodigoEmpresaNova
        End Get
        Set(value As Integer)
            iCodigoEmpresaNova = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadJustificativa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadJustificativa_Load(sender As Object, e As EventArgs) Handles Me.Load

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

  
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadJustificativa_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            ' Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Focu
            Call LoadCombo(cboEmpresaNova, "sp_select_combo_cadastro_basico_empresa")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs)
        Try
            'If ValidaCampo(lblEmpresa, cboAtivoFiltro) = False Then
            '    Exit Sub
            'End If

            CodigoEmpresaNova = cboEmpresaNova.SelectedValue

            Me.Dispose()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvar_Click_1(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            'If ValidaCampo(lblEmpresa, cboAtivoFiltro) = False Then
            '    Exit Sub
            'End If

            CodigoEmpresaNova = cboEmpresaNova.SelectedValue

            Me.Dispose()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class