Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class usrCadVeiculoKmHora

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadVeiculoKmHora As New clsUsrCadVeiculoKmHora
    Private oRow As New Hashtable

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadVeiculoKmHora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5
                    Select Case sender.name
                        Case "cboTipoVeiculoFiltro" : Call LoadCombo(cboTipoVeiculoFiltro, "sp_select_combo_cadastro_basico_tipo_veiculo " & goUsuario.iEmpresa)
                        Case "cboCentroGastoFiltro" : Call LoadCombo(cboCentroGastoFiltro, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)        
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadVeiculoKmHora_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadVeiculoKmHora_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Salva Dados do Registro
            Call Salvar()

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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.CellEdited

        Try

            'Seta Linha        
            If oRow.ContainsKey(grdListagem.CurrentRow.RowIndex) = False Then
                oRow.Add(grdListagem.CurrentRow.RowIndex, grdListagem.CurrentRow)
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

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoVeiculoKmHora, gcUpdate)

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadVeiculoKmHora_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboTipoVeiculoFiltro, "sp_select_combo_cadastro_basico_tipo_veiculo " & goUsuario.iEmpresa)
            Call LoadCombo(cboCentroGastoFiltro, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadComboAno(cboAnoFiltro, DatePart(DateInterval.Year, DateAdd(DateInterval.Year, -20, Now.Date)), Now.Date.Year)

            'Seta Focu
            cboTipoVeiculoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Salva Dados de Venda
            oClsCadVeiculoKmHora.Save(oRow)

            'Informa o usuário sobre o sucesso da operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Limpa oRow
            oRow.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadVeiculoKmHora.LoadGrid(grdListagem, _
                                          IIf(cboTipoVeiculoFiltro.SelectedIndex = -1, -1, cboTipoVeiculoFiltro.SelectedValue), _
                                          txtDescricaoFiltro.Text.Trim, _
                                          IIf(cboCentroGastoFiltro.SelectedIndex = -1, -1, cboCentroGastoFiltro.SelectedValue), _
                                          IIf(cboAnoFiltro.SelectedIndex = -1, -1, cboAnoFiltro.SelectedValue), _
                                          txtNumeroSerieFiltro.Text.Trim, _
                                          txtPlacaFiltro.Text.Trim, _
                                          txtRenavanFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

