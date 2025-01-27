Imports Janus.Windows.GridEX

Public Class frmEstMovimentacaoDeposito

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrEstMovimentacao As New clsUsrEstMovimentacao
    Private sCodigoMovimentacao As String
    Private bFinalizado As Boolean

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoMovimentacao() As String
        Get
            Return sCodigoMovimentacao
        End Get
        Set(ByVal value As String)
            sCodigoMovimentacao = value
        End Set
    End Property

    Public Property Finalizado() As Boolean
        Get
            Return bFinalizado
        End Get
        Set(ByVal value As Boolean)
            bFinalizado = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFHistorico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub frmFatEntradaNFHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEntradaNFHistorico_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)

            cboDeposito.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Public Function Validacao() As Boolean

        Try

            If ValidaCampo(cboDeposito, lblDeposito) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrEstMovimentacao.AtualizaDeposito(sCodigoMovimentacao, _
                                                    cboDeposito.SelectedValue)

            bFinalizado = True

            'Fecha o Formulário
            Me.Dispose()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class