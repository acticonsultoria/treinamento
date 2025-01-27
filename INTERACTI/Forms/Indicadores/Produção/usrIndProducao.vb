Imports Janus.Windows.GridEX

Public Class usrIndProducao

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsIndProducao As New clsUsrIndProducao

#End Region

#Region "::: CONTROLES :::"
    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        Try
            If grdAnalitico.Visible = True Then


                grdAnalitico.Visible = False
                grdListagem.Visible = False
                btnExcelAnalitico.Visible = False
                btnExcelGrid.Visible = False

                chrMain.Width += grdAnalitico.Width + (grdAnalitico.Location.X - (chrMain.Location.X + chrMain.Width))


                btnOcultar.Text = "Exibir Tabela"


            Else

                grdAnalitico.Visible = True
                grdListagem.Visible = True
                btnExcelAnalitico.Visible = True
                btnExcelGrid.Visible = True

                chrMain.Width = (grdAnalitico.Location.X - chrMain.Location.X - 5)

                btnOcultar.Text = "Ocultar Tabela"

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnExcelAnalitico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelAnalitico.Click

        Try

            'Exporta Planilha Excel
            Call ExportExcel(grdanalitico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If ValidaCampo(cboTipoFiltro, lblTipoFiltro) = False Then
                Exit Sub
            End If


            'Limpa o titulo
            chrMain.Titles.Clear()

            'Adiciona Título
            Dim oFont As New System.Drawing.Font("Arial", 14, FontStyle.Bold)
            chrMain.Titles.Add(cboTipoFiltro.Text, Dundas.Charting.WinControl.Docking.Top, oFont, Color.Black)


            'Carrega Dados da Grid
            Call LoadGrid()

            ''Carrega Gráficl
            'Call LoadGrafico()

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

    Private Sub chrMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrMain.MouseMove

        Try

            If chrMain.Series.Count = 0 Then Exit Sub

            'Call Hit Test Method
            Dim oResult As Dundas.Charting.WinControl.HitTestResult = chrMain.HitTest(e.X, e.Y)

            'Reset Data Point Attributes
            Dim oPoint As Dundas.Charting.WinControl.DataPoint

            For Each oPoint In chrMain.Series(0).Points
                oPoint.BackGradientEndColor = Color.Black
                oPoint.BackHatchStyle = Dundas.Charting.WinControl.ChartHatchStyle.None
                oPoint.BorderWidth = 1
                oPoint.Font = New Font("Arial", 8, FontStyle.Regular)
                oPoint.FontColor = Color.Black
            Next oPoint

            'Se for selecionado o DataPoint ou a Legenda
            If oResult.ChartElementType = Dundas.Charting.WinControl.ChartElementType.DataPoint Or oResult.ChartElementType = Dundas.Charting.WinControl.ChartElementType.LegendItem Then
                chrMain.Cursor = Cursors.Hand
                oPoint = chrMain.Series(0).Points(oResult.PointIndex)
                oPoint.BackGradientEndColor = Color.White
                oPoint.BackHatchStyle = Dundas.Charting.WinControl.ChartHatchStyle.Percent25
                oPoint.Font = New Font("Arial", 8, FontStyle.Bold)
                oPoint.FontColor = Color.Red
                oPoint.BorderWidth = 3
            Else
                'Seta o Cursor do Mouse
                chrMain.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            ''Trata Erro
            'Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Dim sDescricao As String = LoadCodigo("sp_select_static_indicador_help " & cboTipoFiltro.SelectedValue)
            MsgBox(sDescricao, MsgBoxStyle.OkOnly, "Help")
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura DateTimePicker
            dtpDataInicioFiltro.Value = New Date(Year(Now), 1, 1) : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            Call LoadCombo(cboTipoFiltro, "sp_select_combo_static_indicador 'PRODUÇÃO'")
            Call LoadCombo(cboOperador, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)

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
            Call oClsIndProducao.LoadGrid(grdListagem, _
                                          grdAnalitico, _
                                              chrMain, _
                                              cboTipoFiltro.SelectedValue, _
                                              IIf(cboOperador.SelectedIndex = -1, -1, cboOperador.SelectedValue), _
                                              IIf(cboOperador.SelectedIndex = -1, -1, cboOperador.SelectedValue), _
                                              IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
                                              IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""), _
                                              txtMeta.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Private Sub LoadGrafico()

    '    Try

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.WaitCursor

    '        'Carrega Grid
    '        Call oClsIndCmp000000001.LoadGrafico(chrMain, _
    '                                             IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
    '                                             IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""))

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.Default

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

#End Region


End Class
