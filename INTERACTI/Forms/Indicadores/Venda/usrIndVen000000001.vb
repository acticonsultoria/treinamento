Imports Janus.Windows.GridEX

Public Class usrIndVen000000001

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsIndVen000000001 As New clsUsrIndVen000000001

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrIndVen000000001_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call btnFiltrar_Click(btnFiltrar, System.EventArgs.Empty) Else Control_Enter(sender)

                Case Keys.Escape : Call btnSair_Click(btnSair, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrIndVen000000001_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Planilha Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo - Visualizar Por
            If ValidaCampo(cboVisualizarPorFiltro, lblVisualizarPorFiltro) = False Then
                Exit Sub
            End If

            'Valida Campo - Tipo de Data
            If ValidaCampo(cboVendedorFiltro, lblVendedorFiltro) = False Then
                Exit Sub
            End If

            'Valida Campo - Comparativo
            If cboTipoComparativoFiltro.SelectedIndex <> -1 Then
                If ValidaCampo(cboComparativoFiltro, lblComparativoFiltro) = False Then
                    Exit Sub
                End If
            End If

            'Carrega Dados da Grid
            Call LoadGrid()

            'Carrega Gráficl
            Call LoadGrafico()

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

    Private Sub cboTipoComparativoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoComparativoFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboTipoComparativoFiltro.SelectedIndex = -1 Then
                cboComparativoFiltro.Enabled = False
            Else
                cboComparativoFiltro.Enabled = True

                Select Case cboTipoComparativoFiltro.SelectedValue

                    Case "segmento" : Call LoadCombo(cboComparativoFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)
                    Case "vendedor" : Call LoadCombo(cboComparativoFiltro, "sp_Select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa)
                    Case "marca" : Call LoadCombo(cboComparativoFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
                    Case "grupo_item" : Call LoadCombo(cboComparativoFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    Case "estado" : Call LoadCombo(cboComparativoFiltro, "sp_select_combo_static_estado")

                End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIndVen000000001_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboVendedorFiltro, "sp_Select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa)
            cboTipoComparativoFiltro.Items.Clear()
            cboTipoComparativoFiltro.Items.Add("ESTADO", "estado")
            cboTipoComparativoFiltro.Items.Add("GRUPO DE ITEM", "grupo_item")
            cboTipoComparativoFiltro.Items.Add("MARCA", "marca")
            cboTipoComparativoFiltro.Items.Add("SEGMENTO", "segmento")
            cboTipoComparativoFiltro.Items.Add("VENDEDOR", "vendedor")
            cboVisualizarPorFiltro.Items.Clear()
            cboVisualizarPorFiltro.Items.Add("DIA", 1)
            cboVisualizarPorFiltro.Items.Add("MÊS", 3)

            'Configura DateTimePicker
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.IndicadorVEN000000001)

            Dim oFont As New System.Drawing.Font("Arial", 14, FontStyle.Bold)

            'Adiciona Título
            chrMain.Titles.Add("Vendedor", Dundas.Charting.WinControl.Docking.Top, oFont, Color.Black)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.IndicadorVEN000000001, gcPrint)

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

            'Carrega Grid
            Call oClsIndVen000000001.LoadGrid(grdListagem, _
                                              cboVisualizarPorFiltro.SelectedValue, _
                                              cboVendedorFiltro.SelectedValue, _
                                              IIf(cboTipoComparativoFiltro.SelectedIndex = -1, "", cboTipoComparativoFiltro.SelectedValue), _
                                              IIf(cboComparativoFiltro.SelectedIndex = -1, "-1", cboComparativoFiltro.SelectedValue), _
                                              IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
                                              IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrafico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsIndVen000000001.LoadGrafico(chrMain, _
                                                 cboVisualizarPorFiltro.SelectedValue, _
                                                 cboVendedorFiltro.SelectedValue, _
                                                 IIf(cboTipoComparativoFiltro.SelectedIndex = -1, "", cboTipoComparativoFiltro.SelectedValue), _
                                                 IIf(cboComparativoFiltro.SelectedIndex = -1, "-1", cboComparativoFiltro.SelectedValue), _
                                                 IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
                                                 IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
