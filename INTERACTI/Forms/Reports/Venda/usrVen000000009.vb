Public Class usrVen000000009

#Region "::: CONTROLES :::"

    Private Sub usrVen000000009_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrVen000000009_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged

        Try

            'Carrega os Dados 
            If cboCliente.SelectedIndex <> -1 Then
                'Carrega dados do Parceiro de Negócio
                Call LoadDadosParceiroNegocio(cboCliente.SelectedValue, _
                                              cboUF, _
                                              cboMunicipio)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUF.SelectedIndex = -1 Then
                cboMunicipio.DataSource = Nothing
                cboMunicipio.Text = ""
            Else
                Call LoadCombo(cboMunicipio, "sp_select_combo_static_municipio '" & cboUF.SelectedValue & "'")
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

            'Carrega ComboBox
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_venda_pedido_item")
            Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, False)
            Call LoadCombo(cboUF, "sp_select_combo_static_estado")
            Call LoadCombo(cboTipoItem, "sp_select_combo_static_tipo_item")

            'Configura DateTimePicker
            dtpDataPedidoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False
            dtpDataPrevisaoEntregaInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPrevisaoEntregaInicioFiltro.Checked = False
            dtpDataPrevisaoEntregaTerminoFiltro.Value = Now.Date : dtpDataPrevisaoEntregaTerminoFiltro.Checked = False

            'Verifica Direito
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioVEN000000009, gcPrint)

            'Seta Focu
            cboCliente.Focus()

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
            ReDim goCrystalReport.sReportParameter(19)

            'Filtro - Status
            Dim sStatus As String = ""
            Dim sStatusFiltro As String = "-"
            For Each oRow In cboStatusFiltro.DropDownList.GetCheckedRows
                sStatus &= IIf(sStatus = "", "", ",") & oRow.Cells("codigo").Value
                sStatusFiltro &= IIf(sStatusFiltro = "", "", ",") & oRow.Cells("descricao").Value
            Next
            
            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "VEN000000009.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Parceiro de Negócio
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue)
            'Seta Paramentro - Data Pedido Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_pedido_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataPedidoInicioFiltro.Checked = False, "NULL", dtpDataPedidoInicioFiltro.Value)
            'Seta Paramentro - Data Pedido Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_pedido_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataPedidoTerminoFiltro.Checked = False, "NULL", dtpDataPedidoTerminoFiltro.Value)
            'Seta Paramentro - Data Previsão Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_previsao_inicio"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "NULL", dtpDataPrevisaoEntregaInicioFiltro.Value)
            'Seta Paramentro - Data Previsão Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_previsao_termino"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "NULL", dtpDataPrevisaoEntregaTerminoFiltro.Value)
            'Seta Paramentro - Status
            goCrystalReport.sReportParameter(7).sParamenter = "@status"
            goCrystalReport.sReportParameter(7).sValue = sStatus
            'Seta Paramentro - UF
            goCrystalReport.sReportParameter(8).sParamenter = "@uf"
            goCrystalReport.sReportParameter(8).sValue = IIf(cboUF.SelectedIndex = -1, "NULL", cboUF.SelectedValue)
            'Seta Paramentro - Município
            goCrystalReport.sReportParameter(9).sParamenter = "@codigo_municipio"
            goCrystalReport.sReportParameter(9).sValue = IIf(cboMunicipio.SelectedIndex = -1, -1, cboMunicipio.SelectedValue)
            'Seta Paramentro - Tipo Item
            goCrystalReport.sReportParameter(10).sParamenter = "@codigo_tipo_item"
            goCrystalReport.sReportParameter(10).sValue = IIf(cboTipoItem.SelectedIndex = -1, -1, cboTipoItem.SelectedValue)
            'Seta Paramentro - Código Vendedor
            goCrystalReport.sReportParameter(11).sParamenter = "@codigo_vendedor"
            goCrystalReport.sReportParameter(11).sValue = IIf(cboVendedor.SelectedIndex = -1, -1, cboVendedor.SelectedValue)

            'Seta Paramentro - Filtro - Cliente
            goCrystalReport.sReportParameter(12).sParamenter = "filtro_cliente"
            goCrystalReport.sReportParameter(12).sValue = IIf(cboCliente.SelectedIndex = -1, "", cboCliente.Text)
            'Seta Paramentro - Filtro - Data Pedido
            goCrystalReport.sReportParameter(13).sParamenter = "filtro_data_pedido"
            goCrystalReport.sReportParameter(13).sValue = IIf(dtpDataPedidoInicioFiltro.Checked = True, dtpDataPedidoInicioFiltro.Value.ToString, "") & " - " & IIf(dtpDataPedidoTerminoFiltro.Checked = True, dtpDataPedidoTerminoFiltro.Value.ToString, "")
            'Seta Paramentro - Filtro - Data Previsão
            goCrystalReport.sReportParameter(14).sParamenter = "filtro_data_previsao"
            goCrystalReport.sReportParameter(14).sValue = IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = True, dtpDataPrevisaoEntregaInicioFiltro.Value.ToString, "") & " - " & IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = True, dtpDataPrevisaoEntregaTerminoFiltro.Value.ToString, "")
            'Seta Paramentro - Filtro - Município
            goCrystalReport.sReportParameter(15).sParamenter = "filtro_municipio"
            goCrystalReport.sReportParameter(15).sValue = IIf(cboMunicipio.SelectedIndex = -1, "-", cboMunicipio.Text)
            'Seta Paramentro - Filtro - Status
            goCrystalReport.sReportParameter(16).sParamenter = "filtro_status"
            goCrystalReport.sReportParameter(16).sValue = sStatusFiltro
            'Seta Paramentro - Filtro - UF
            goCrystalReport.sReportParameter(17).sParamenter = "filtro_uf"
            goCrystalReport.sReportParameter(17).sValue = IIf(cboUF.SelectedIndex = -1, "-", cboUF.Text)
            'Seta Paramentro - Filtro - Tipo Item
            goCrystalReport.sReportParameter(18).sParamenter = "filtro_tipo_item"
            goCrystalReport.sReportParameter(18).sValue = IIf(cboTipoItem.SelectedIndex = -1, "-", cboTipoItem.Text)
            'Seta Paramentro - Filtro - Vendedor
            goCrystalReport.sReportParameter(19).sParamenter = "filtro_vendedor"
            goCrystalReport.sReportParameter(19).sValue = IIf(cboVendedor.SelectedIndex = -1, "-", cboVendedor.Text)

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
