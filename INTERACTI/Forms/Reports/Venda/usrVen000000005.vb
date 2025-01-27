Public Class usrVen000000005

#Region "::: CONTROLES :::"

    Private Sub usrVen000000005_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrVen000000005_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            Call LoadCombo(cboSegmento, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa, False)

            'Configura DateTimePicker
            dtpDataPedidoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False

            'Seta Focu
            cboSegmento.Focus()

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
            ReDim goCrystalReport.sReportParameter(4)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "VEN000000005.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Parceiro de Negócio Segmento
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio_segmento"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboSegmento.SelectedIndex = -1, -1, cboSegmento.SelectedValue)
            'Seta Paramentro - Data Pedido Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_pedido_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataPedidoInicioFiltro.Checked = False, "NULL", dtpDataPedidoInicioFiltro.Value)
            'Seta Paramentro - Data Pedido Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_pedido_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataPedidoTerminoFiltro.Checked = False, "NULL", dtpDataPedidoTerminoFiltro.Value)

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
