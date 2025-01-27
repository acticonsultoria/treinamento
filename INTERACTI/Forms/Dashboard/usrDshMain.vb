Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrDshMain

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsDshWorkflow As New clsUsrDshWorkflow

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrDshMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3

                Case Keys.F5

                Case Keys.Oemplus, Keys.Add

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrDshMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrDshMain_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Dim oClsCadEmpresa As New clsUsrCadEmpresa
            oClsCadEmpresa.LoadLogo(picLogo)
            lblData.Text = Now.Date
            lblEmpresa.Text = goUsuario.sEmpresa

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

    Private Sub btnProdutosMaisVendidos_Click(sender As Object, e As Janus.Windows.Ribbon.CommandEventArgs)

        grdProdutosMaisVendidos.Visible = True

    End Sub

    Private Sub btbMain_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles btbMain.ItemClick

        If e.Item.Key.ToString.Substring(0, 3) = "usr" Then

            'Váriaveis Locais
            Dim oUsrControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            For Each oControl As Control In pagMenu.Controls
                pnlMain.Controls.Remove(oControl)
            Next

            'Seta UserControl
            oUsrControl = oAssembly.CreateInstance("INTERACTI." & e.Item.Key)
            lblRelatorio.Text = e.Item.Text
            oUsrControl.Tag = "FILTRAR" & e.Item.Key.ToString
            oUsrControl.Dock = DockStyle.Fill

            'Configura Mascara
            Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)

            pnlMain.SuspendLayout()
            pnlMain.Controls.Add(oUsrControl)
            pnlMain.ResumeLayout()

            'ElseIf e.Item.Key.ToString = "frmCadProdutoPrecoVendaCalculadora" Then

            '    'Váriaveis Locais
            '    Dim oForm As New frmCadProdutoPrecoVendaCalculadora
            '    'Configura Mascara
            '    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm)
            '    oForm.ShowDialog()

        End If

        'Executa Tarefas Pendentes do Sistema
        Application.DoEvents()

    End Sub

End Class


