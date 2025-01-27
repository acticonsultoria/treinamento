Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinFluxoCaixaVertical

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinFluxoVertical As New clsUsrFinFluxoVertical

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFinFluxoCaixaVertical_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinFluxoCaixaVertical_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFinFluxoCaixaVertical_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Setando a datainicial
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -6, Now)

            'Carrega ComboBox
            Call LoadCombo(cboParceiroNegocioFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            cboTipoTituloFinanceiroFiltro.Items.Add("RECEITA", "R")
            cboTipoTituloFinanceiroFiltro.Items.Add("DESPESA", "D")
            cboTipoTituloFinanceiroFiltro.SelectedIndex = 0

            'Seta Focu
            dtpDataInicioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFinFluxoVertical.LoadGrid(grdListagem, _
                                          IIf(cboParceiroNegocioFiltro.SelectedIndex = -1, -1, cboParceiroNegocioFiltro.SelectedValue), _
                                          IIf(cboTipoTituloFinanceiroFiltro.SelectedIndex = -1, "", cboTipoTituloFinanceiroFiltro.SelectedValue), _
                                          dtpDataInicioFiltro.Value, _
                                          dtpDataTerminoFiltro.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
