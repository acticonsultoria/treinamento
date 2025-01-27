Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdCenarioManutencao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdCenario As New clsUsrPrdCenario
    Private iCodigoCenario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoCenario() As Integer
        Get
            Return iCodigoCenario
        End Get
        Set(ByVal value As Integer)
            iCodigoCenario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If MsgBox("Deseja inserir essa manutenção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdCenario.InsertManutencao(iCodigoCenario, _
                                               cboMaquina.SelectedValue, _
                                               dtpData.Value, _
                                               txtDuracao.Value, _
                                               txtObservacao.Text.Trim)

            frmMain.Informacao(Mensagem.RegistroSalvo)

            Cursor.Current = Cursors.Default

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
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina 1, " & goUsuario.iUsuario, False)
            dtpData.Value = Now

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboMaquina, lblMaquina) = False Then Return False
            If ValidaCampo(txtDuracao, lblDuracao, True) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class