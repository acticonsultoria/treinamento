Imports Janus.Windows.GridEX

Public Class usrIndFin000000005

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsIndFin000000005 As New clsUsrIndFin000000005

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrIndFin000000005_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrIndFin000000005_Load(sender As Object, e As EventArgs) Handles Me.Load

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

            'Valida Campo - Tipo de Data
            If ValidaCampo(cboTipoDataFiltro, lblTipoDataFiltro) = False Then
                Exit Sub
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

    Private Sub cboTipoDataFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDataFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboTipoDataFiltro.SelectedIndex = -1 Then
                dtpDataInicioFiltro.Enabled = False
                dtpDataTerminoFiltro.Enabled = False
            Else
                dtpDataInicioFiltro.Enabled = True
                dtpDataTerminoFiltro.Enabled = True
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIndFin000000005_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))


            'Carrega Combo - Tipo
            cboTipoDataFiltro.Items.Clear()
            cboTipoDataFiltro.Items.Add("DATA EMISSÃO", "1")
            cboTipoDataFiltro.Items.Add("DATA PAGAMENTO", "3")
            cboTipoDataFiltro.Items.Add("DATA VENCIMENTO", "2")

            'Configura DateTimePicker
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = False : dtpDataInicioFiltro.Enabled = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False : dtpDataTerminoFiltro.Enabled = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.IndicadorFIN000000005)

            Dim oFont As New System.Drawing.Font("Arial", 14, FontStyle.Bold)

            'Adiciona Título
            chrMain.Titles.Add("Receita por Período", Dundas.Charting.WinControl.Docking.Top, oFont, Color.Black)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.IndicadorFIN000000005, gcPrint)

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
            Call oClsIndFin000000005.LoadGrid(grdListagem, _
                                              IIf(cboTipoDataFiltro.SelectedIndex = -1, -1, cboTipoDataFiltro.SelectedValue), _
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
            Call oClsIndFin000000005.LoadGrafico(chrMain, _
                                                 IIf(cboTipoDataFiltro.SelectedIndex = -1, -1, cboTipoDataFiltro.SelectedValue), _
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
