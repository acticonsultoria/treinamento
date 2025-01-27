Imports Janus.Windows.GridEX
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Public Class usrIndComercial

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsIndComercial As New clsUsrIndComercial

#End Region

#Region "::: CONTROLES :::"

    Private Sub ChkChanged(sender As Object, e As EventArgs) Handles chkSerie1.CheckedChanged, chkSerie2.CheckedChanged, chkSerie3.CheckedChanged, chkSerie4.CheckStateChanged, chkSerie5.CheckStateChanged
        Try


            If chrMain.Series.Count = 0 Then Exit Sub

            Dim oUiCheckBox As Janus.Windows.EditControls.UICheckBox = CType(sender, Janus.Windows.EditControls.UICheckBox)

            Try
                chrMain.Series(CInt(oUiCheckBox.Tag)).Enabled = oUiCheckBox.Checked
            Catch ex As Exception

            End Try


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub cboTipoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoFiltro.SelectedIndexChanged

        Try

            Cursor.Current = Cursors.WaitCursor

            'Se não for seleciado nenhum item
            If cboTipoFiltro.SelectedIndex = -1 Then Exit Sub


            'Carrega os dados dos filtros
            oClsIndComercial.VerificaCamposGrafico(cboTipoFiltro.SelectedValue, _
                                                    txtDescricao, _
                                                    txtSerie1, _
                                                    txtSerie2, _
                                                    txtSerie3, _
                                                    txtSerie4, _
                                                    txtSerie5, _
                                                    dtpDataInicioFiltro, _
                                                    dtpDataTerminoFiltro)


            'Com os campos visiveis ou não, faz os demais campos visiveis ou não
            chkSerie1.Visible = txtSerie1.Visible : btnAlterarCorSerie1.Visible = txtSerie1.Visible
            chkSerie2.Visible = txtSerie2.Visible : btnAlterarCorSerie2.Visible = txtSerie2.Visible
            chkSerie3.Visible = txtSerie3.Visible : btnAlterarCorSerie3.Visible = txtSerie3.Visible
            chkSerie4.Visible = txtSerie4.Visible : btnAlterarCorSerie4.Visible = txtSerie4.Visible
            chkSerie5.Visible = txtSerie5.Visible : btnAlterarCorSerie5.Visible = txtSerie5.Visible

            lblDataInicioFiltro.Visible = dtpDataInicioFiltro.Visible
            lblDataTermino.Visible = dtpDataTerminoFiltro.Visible


            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAlterarCorSerie_Click(sender As Object, e As EventArgs) Handles btnAlterarCorSerie1.Click, _
                                                                                 btnAlterarCorSerie2.Click, _
                                                                                 btnAlterarCorSerie3.Click, _
                                                                                 btnAlterarCorSerie4.Click, _
                                                                                 btnAlterarCorSerie5.Click
        Try
            Dim sSerie As String
            Dim oTextSerie As EditControls.MaskedEditBox

            Select Case sender.NAME
                Case btnAlterarCorSerie1.Name : oTextSerie = txtSerie1 : sSerie = "serie1"
                Case btnAlterarCorSerie2.Name : oTextSerie = txtSerie2 : sSerie = "serie2"
                Case btnAlterarCorSerie3.Name : oTextSerie = txtSerie3 : sSerie = "serie3"
                Case btnAlterarCorSerie4.Name : oTextSerie = txtSerie4 : sSerie = "serie4"
                Case btnAlterarCorSerie5.Name : oTextSerie = txtSerie5 : sSerie = "serie5"
            End Select

            'Verifica o tipo de gráfico
            Dim sTipoGrafico As String = LoadCodigo("sp_select_static_indicador_campo " & CStr(cboTipoFiltro.SelectedValue) & ",'tipo_grafico_" + sSerie + "'")

            'Seta os itens
            Dim oForm As New frmIndComercialCor
            oForm.Series = sSerie.Replace("serie", "")
            oForm.Codigo = cboTipoFiltro.SelectedValue
            oForm.TipoGrafico = sTipoGrafico
            oForm.txtSerie.Text = oTextSerie.Text

            'Seta a cor
            oForm.Cor = oTextSerie.BackColor

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta o item
            oTextSerie.BackColor = oForm.Cor


            'tenta colocar o tipo de grafico
            Try
                chrMain.Series(oTextSerie.Text).Color = oTextSerie.BackColor
                Select Case oForm.TipoGrafico
                    Case "LINE" : chrMain.Series(oTextSerie.Text).Type = Dundas.Charting.WinControl.SeriesChartType.Line
                    Case "COLUMN" : chrMain.Series(oTextSerie.Text).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                End Select

            Catch ex As Exception : End Try


        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        Try
            If grdAnalitico.Visible = True Then


                grdAnalitico.Visible = False
                grdSintetico.Visible = False
                btnExcelAnalitico.Visible = False
                btnExcelGrid.Visible = False

                chrMain.Width += grdAnalitico.Width + (grdAnalitico.Location.X - (chrMain.Location.X + chrMain.Width))


                btnOcultar.Text = "Exibir Tabela"
                chrMain.ChartAreas(0).ReCalc()

            Else

                grdAnalitico.Visible = True
                grdSintetico.Visible = True
                btnExcelAnalitico.Visible = True
                btnExcelGrid.Visible = True

                chrMain.Width = (grdAnalitico.Location.X - chrMain.Location.X - 5)

                btnOcultar.Text = "Ocultar Tabela"
                chrMain.ChartAreas(0).ReCalc()
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnOcultarFiltro_Click(sender As Object, e As EventArgs) Handles btnOcultarFiltro.Click
        Try
            If grpFiltro.Visible = True Then


                chrMain.Location = New Point(chrMain.Location.X, grpFiltro.Location.Y)
                chrMain.Height = pagListagem.Height - grpControl.Height - 10


                grpFiltro.Visible = False
                btnOcultarFiltro.Text = "Exibir Filtro"
                chrMain.ChartAreas(0).ReCalc()

            Else
                chrMain.Location = New Point(chrMain.Location.X, 161)
                chrMain.Height = pagListagem.Height - grpControl.Height - grpFiltro.Height - 20
                grpFiltro.Visible = True
                'chrMain.Width = (grdAnalitico.Location.X - chrMain.Location.X - 5)

                btnOcultarFiltro.Text = "Ocultar Filtro"
                chrMain.ChartAreas(0).ReCalc()
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then Call btnFiltrar_Click(btnFiltrar, System.EventArgs.Empty) Else Control_Enter(sender)

                Case Keys.Escape : Call btnSair_Click(btnSair, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Planilha Excel
            Call ExportExcel(grdSintetico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If Validacao() = True Then

                'Carrega Dados da Grid
                Call LoadGrid()

            End If

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

    'Private Sub grdSintetico_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdSintetico.RowDoubleClick
    '    Try
    '        If grdSintetico.CurrentColumn.Key = "adicionar" Or grdSintetico.CurrentColumn.Key = "excluir" Then

    '            AlterarGrafico(grdSintetico.CurrentColumn.Key)

    '        End If

    '    Catch ex As Exception
    '        TratamentoErro(ex.Message, Me.Parent.ToString)
    '    End Try
    'End Sub
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


            Call LoadCombo(cboTipoFiltro, "sp_select_combo_static_indicador 'COMERCIAL'")
            Call LoadCombo(cboTipoFiltroIndicador, "sp_select_static_tipo_filtro_indicador 'COMERCIAL'")

            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            chkSerie1.Visible = False
            btnAlterarCorSerie1.Visible = False
            txtSerie1.Visible = False

            chkSerie2.Visible = False
            btnAlterarCorSerie2.Visible = False
            txtSerie2.Visible = False

            chkSerie3.Visible = False
            btnAlterarCorSerie3.Visible = False
            txtSerie3.Visible = False

            chkSerie4.Visible = False
            btnAlterarCorSerie4.Visible = False
            txtSerie4.Visible = False

            chkSerie5.Visible = False
            btnAlterarCorSerie5.Visible = False
            txtSerie5.Visible = False


            dtpDataInicioFiltro.Visible = False
            lblDataInicioFiltro.Visible = False

            dtpDataTerminoFiltro.Visible = False
            lblDataTermino.Visible = False


            chkSerie1.Checked = True
            chkSerie2.Checked = True
            chkSerie3.Checked = True
            chkSerie4.Checked = True
            chkSerie5.Checked = True

            cboTipoValor.Items.Clear()
            cboTipoValor.Items.Add("VALOR", "VALOR")
            cboTipoValor.Items.Add("QUANTIDADE", "QUANTIDADE")
            cboTipoValor.SelectedIndex = 0

            FormatDundas(chrMain)

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
            Call oClsIndComercial.LoadGrid(grdSintetico, _
                                            grdAnalitico, _
                                            chrMain, _
                                            cboTipoFiltro.SelectedValue, _
                                            txtMeta.Value, _
                                            IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                            IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                             IIf(cboTipoFiltroIndicador.SelectedIndex = -1, "", cboTipoFiltroIndicador.SelectedValue), _
                                            txtFiltro.Text.Trim, _
                                            cboTipoValor.SelectedValue)


            'Limpa o titulo
            chrMain.Titles.Clear()

            'Adiciona Título
            Dim oFont As New System.Drawing.Font("Arial", 14, FontStyle.Bold)
            Dim sTitulo As String = cboTipoFiltro.Text

            chrMain.Titles.Add(sTitulo, Dundas.Charting.WinControl.Docking.Top, oFont, Color.Black)


            chrMain.Series(0).Enabled = chkSerie1.Checked
            If chrMain.Series.Count > 1 Then chrMain.Series(1).Enabled = chkSerie2.Checked
            If chrMain.Series.Count > 2 Then chrMain.Series(2).Enabled = chkSerie3.Checked
            If chrMain.Series.Count > 3 Then chrMain.Series(3).Enabled = chkSerie4.Checked
            If chrMain.Series.Count > 4 Then chrMain.Series(4).Enabled = chkSerie5.Checked

             'If grdSintetico.GetRows.Count > 0 Then



            '    For iRow As Integer = 0 To grdSintetico.GetRows.Count - 1

            '        grdSintetico.Row = iRow


            '        If grdSintetico.GetValue("desconsiderar") = True Then

            '            grdSintetico.CurrentRow.CheckState = RowCheckState.Unchecked


            '        End If

            '    Next


            '    grdSintetico.Row = 0


            'End If

        
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FormatDundas(ByVal oChart As Dundas.Charting.WinControl.Chart)
        Try
            oChart.ChartAreas(0).Area3DStyle.Enable3D = False
            oChart.ChartAreas(0).BackColor = Color.White
            oChart.ChartAreas(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.ChartAreas(0).ShadowOffset = 2
            oChart.ChartAreas(0).BorderStyle = ChartDashStyle.Solid
            oChart.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Solid
            oChart.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Silver
            oChart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Silver
            oChart.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Solid
            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()
            oChart.Legends(0).Alignment = StringAlignment.Center
            oChart.Legends(0).Docking = LegendDocking.Bottom
            oChart.Legends(0).LegendStyle = LegendStyle.Row
            oChart.Legends(0).AutoFitText = False
            oChart.Legends(0).BackColor = Color.White
            oChart.Legends(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.Legends(0).BorderStyle = ChartDashStyle.Solid
            oChart.Legends(0).BorderWidth = 1
            oChart.Legends(0).DockInsideChartArea = True
            oChart.BackColor = Color.WhiteSmoke
            oChart.BackGradientEndColor = Color.White
            oChart.BackGradientType = GradientType.DiagonalLeft
            oChart.BorderLineColor = Color.FromArgb(255, 26, 59, 105)
            oChart.BorderLineStyle = ChartDashStyle.Solid
            oChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            oChart.BorderSkin.FrameBackColor = Color.CornflowerBlue
            oChart.BorderSkin.FrameBackGradientEndColor = Color.CornflowerBlue
            oChart.BorderSkin.PageColor = Color.FromArgb(255, 240, 240, 240)
            oChart.UI.Toolbar.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            oChart.UI.Toolbar.BorderSkin.FrameBackColor = Color.Gray
            oChart.UI.Toolbar.BorderSkin.PageColor = Color.Transparent

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Validacao()

        Try

            Validacao = False

            If ValidaCampo(cboTipoFiltro, lblTipoFiltro) = False Then
                Exit Function
            End If




            'Os demais campos não precisam de validação
            Validacao = True


        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub AlterarGrafico(ByVal sAcao As String)

        Try


            ExecuteQuery("EXECUTE sp_indicador_atualizar_acao " & cboTipoFiltro.SelectedValue & "," & goUsuario.iUsuario & ",'" & grdSintetico.GetValue("descricao") & "','" & sAcao & "'")


            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

    
End Class
