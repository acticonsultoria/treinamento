Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl

Public Class usrEst000000006

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEst000000006 As New clsUsrEst000000006

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEst000000006_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                        Call LoadGrid()
                    End If

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                        Case "cboMarcaFiltro" : Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEst000000006_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioEST000000006
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioEST000000006)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Abre Formulário de Integração com Excel
            Dim oForm As New frmIntExportExcel
            oForm.Grid = grdListagem
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellValueChanged(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.CellValueChanged

        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "estoque_minimo" : Call ExecuteQuery("sp_update_cadastro_basico_produto_estoque_minimo " & goUsuario.iEmpresa & ", " & grdListagem.GetValue("codigo_item") & ", " & grdListagem.GetValue("estoque_minimo").ToString.Replace(".", "").Replace(",", "."))
                Case "lead_time" : Call ExecuteQuery("sp_update_cadastro_basico_produto_lead_time " & goUsuario.iEmpresa & ", " & grdListagem.GetValue("codigo_item") & ", " & grdListagem.GetValue("lead_time").ToString.Replace(".", "").Replace(",", "."))

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioEST000000006)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioEST000000006, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtAFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtAFiltro.LostFocus

        Try

            'Atualiza Banco de Dados
            If IsNumeric(txtAFiltro.Value) Then
                Call ExecuteQuery("sp_update_static_valor_default_controle 'usrEst000000006', '" & sender.name & "', " & sender.Value.ToString.Replace(".", "").Replace(",", ".") & ", 'NumericEditBox', " & goUsuario.iUsuario & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtBFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtBFiltro.LostFocus

        Try

            'Atualiza Banco de Dados
            If IsNumeric(txtBFiltro.Value) Then
                Call ExecuteQuery("sp_update_static_valor_default_controle 'usrEst000000006', '" & sender.name & "', " & sender.Value.ToString.Replace(".", "").Replace(",", ".") & ", 'NumericEditBox', " & goUsuario.iUsuario & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtCFiltro_LostFocus(sender As Object, e As EventArgs) Handles txtCFiltro.LostFocus

        Try

            'Atualiza Banco de Dados
            If IsNumeric(txtCFiltro.Value) Then
                Call ExecuteQuery("sp_update_static_valor_default_controle 'usrEst000000006', '" & sender.name & "', " & sender.Value.ToString.Replace(".", "").Replace(",", ".") & ", 'NumericEditBox', " & goUsuario.iUsuario & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEst000000006_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioEST000000006, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioEST000000006)

            'Carrega Valores Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            dtpDataInicioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo - A
            If ValidaCampo(txtAFiltro, btnFiltrar, True) = False Then
                Exit Sub
            End If

            'Valida Campo - B
            If ValidaCampo(txtBFiltro, btnFiltrar, True) = False Then
                Exit Sub
            End If

            'Valida Campo - C
            If ValidaCampo(txtCFiltro, btnFiltrar, True) = False Then
                Exit Sub
            End If

            'Verifica o Total
            If txtAFiltro.Value + txtBFiltro.Value + txtCFiltro.Value <> 100 Then
                frmMain.errInfo.SetError(btnFiltrar, "A Soma do Percentual de A, B e C tem que ser igual a 100%")
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsEst000000006.LoadGrid(grdListagem, _
                                     IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                     IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""), _
                                     IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                     IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                     txtAFiltro.Value, _
                                     txtBFiltro.Value, _
                                     txtCFiltro.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
