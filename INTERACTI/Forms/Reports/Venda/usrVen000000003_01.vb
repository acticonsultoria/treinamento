Public Class usrVen000000003_01

#Region "::: CONTROLES :::"

    Private Sub usrVen000000003_01_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrVen000000003_01_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, False)
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboSegmento, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboProbabilidadeVendaFiltro, "sp_select_combo_cadastro_basico_probabilidade_exito_venda " & goUsuario.iEmpresa, False)

            'Configura DateTimePicker
            dtpDataPrevisaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPrevisaoInicioFiltro.Checked = False
            dtpDataPrevisaoTerminoFiltro.Value = Now.Date : dtpDataPrevisaoTerminoFiltro.Checked = False

            'Seta Focu
            cboVendedor.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(8)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "VEN000000003_01.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Vendedor
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_vendedor"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboVendedor.SelectedIndex = -1, -1, cboVendedor.SelectedValue)
            'Seta Paramentro - Data Previsão Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_previsao_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataPrevisaoInicioFiltro.Checked = False, "NULL", dtpDataPrevisaoInicioFiltro.Value)
            'Seta Paramentro - Data Previsão Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_previsao_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataPrevisaoTerminoFiltro.Checked = False, "NULL", dtpDataPrevisaoTerminoFiltro.Value)
            'Seta Paramentro - Probabilidade de Venda
            goCrystalReport.sReportParameter(5).sParamenter = "@codigo_probabilidade_venda"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboProbabilidadeVendaFiltro.SelectedIndex = -1, -1, cboProbabilidadeVendaFiltro.SelectedValue)
            'Seta Paramentro - Grupo de Item
            goCrystalReport.sReportParameter(6).sParamenter = "@codigo_grupo_item"
            goCrystalReport.sReportParameter(6).sValue = IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue)
            'Seta Paramentro - Segmento
            goCrystalReport.sReportParameter(7).sParamenter = "@codigo_parceiro_negocio_segmento"
            goCrystalReport.sReportParameter(7).sValue = IIf(cboSegmento.SelectedIndex = -1, -1, cboSegmento.SelectedValue)
            'Seta Paramentro - Vendedor
            goCrystalReport.sReportParameter(8).sParamenter = "vendedor"
            goCrystalReport.sReportParameter(8).sValue = IIf(cboVendedor.SelectedIndex = -1, "", cboVendedor.Text)
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
