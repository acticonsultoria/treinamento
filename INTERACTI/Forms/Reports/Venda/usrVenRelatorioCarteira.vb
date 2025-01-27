Imports Janus.Windows.GridEX

Public Class usrVenRelatorioCarteira

    'Variáveis da Classe
    Private oClsUsrVenRelatorioCarteira As New clsUsrVenRelatorioCarteira

#Region "::: CONTROLES :::"

    Private Sub usrVen000000017_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrVen000000017_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioVenCarteira
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioVenCarteira)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

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

            'Carrega Grid
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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioVenCarteira)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioVenCarteira, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(sender As Object, e As EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteFiltro.Focus()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVen000000017_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            LoadCombo(cboProdutoFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
            LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboProdutoFiltro, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, -1")

            'Configura DateTimePicker
            dtpDataPedidoInicioFiltro.Value = Now.Date : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioVenCarteira, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioVenCarteira)

            'Seta Focu
            dtpDataPedidoInicioFiltro.Focus()

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

            'Seta Parametros
            Call oClsUsrVenRelatorioCarteira.LoadGrid(grdListagem, _
                                           IIf(dtpDataPedidoInicioFiltro.Checked = True, dtpDataPedidoInicioFiltro.Value, ""), _
                                           IIf(dtpDataPedidoTerminoFiltro.Checked = True, dtpDataPedidoTerminoFiltro.Value, ""), _
                                           IIf(cboProdutoFiltro.SelectedIndex = -1, -1, cboProdutoFiltro.SelectedValue), _
                                           IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue))

            grdListagem.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    

End Class
