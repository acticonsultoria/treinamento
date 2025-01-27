Public Class usrFat0000000024_maria

#Region "::: CONTROLES :::"



    Private Sub usrFat000000002_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFat000000002_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Visualizar Impressão
            Call VisualizarImpressao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)

            'Configura DateTimePicker
            cboDataInicio.Value = DateAdd(DateInterval.Month, -1, Now.Date) : cboDataInicio.Checked = False
            cboDataTermino.Value = Now.Date : cboDataTermino.Checked = False

            'Seta Focu
            txtProduto.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Dim i As Integer = 0
        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(5)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000024_maria.rpt"

            'Seta Paramentro - Usuario
            goCrystalReport.sReportParameter(i).sParamenter = "usuario"
            goCrystalReport.sReportParameter(i).sValue = goUsuario.sUsuario : i += 1
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(i).sValue = goUsuario.iEmpresa : i += 1
            'Seta Paramentro - Codigo Grupo Item
            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_grupo_item"
            goCrystalReport.sReportParameter(i).sValue = IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue) : i += 1
            'Seta Paramentro - Código Item
            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_item"
            goCrystalReport.sReportParameter(i).sValue = txtProduto.Text : i += 1
            'Seta Paramentro - Data Início
            goCrystalReport.sReportParameter(i).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(i).sValue = IIf(cboDataInicio.Checked = False, "NULL", cboDataInicio.Value) : i += 1
            'Seta Paramentro - Data Término
            goCrystalReport.sReportParameter(i).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(i).sValue = IIf(cboDataTermino.Checked = False, "NULL", cboDataTermino.Value)


            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

End Class
