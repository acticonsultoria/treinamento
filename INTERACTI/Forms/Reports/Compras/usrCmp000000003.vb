Public Class usrCmp000000003

#Region "::: CONTROLES :::"

    Private Sub usrCmp000000003_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCmp000000003_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, -1")
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_compras_pedido_item")
            Call LoadCombo(cboUFFiltro, "sp_select_combo_static_estado")

            'Configura DateTimePicker
            dtpDataPedidoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False
            dtpDataPrevisaoEntregaInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPrevisaoEntregaInicioFiltro.Checked = False
            dtpDataPrevisaoEntregaTerminoFiltro.Value = Now.Date : dtpDataPrevisaoEntregaTerminoFiltro.Checked = False

            'Seta Focu
            cboFornecedor.Focus()

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
            ReDim goCrystalReport.sReportParameter(10)

            'Filtro - Status
            Dim sStatus As String = ""
            Dim sUF As String = ""
            Dim sPais As String = ""

            Dim i As Integer

            'Obtém Filtro - Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Obtém Filtro - UF
            If cboUFFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboUFFiltro.CheckedValues)
                    sUF &= IIf(sUF = "", "", ",") & cboUFFiltro.CheckedValues(i).ToString
                Next
            End If

            'Obtém Filtro - Pais
            If cboPais.SelectionLength > 0 Then
                For i = 0 To UBound(cboPais.CheckedValues)
                    sPais &= IIf(sPais = "", "", ",") & cboPais.CheckedValues(i).ToString
                Next
            End If

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000003.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Parceiro de Negócio
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboFornecedor.SelectedIndex = -1, -1, cboFornecedor.SelectedValue)
            'Seta Paramentro - Data Pedido Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_pedido_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataPedidoInicioFiltro.Checked = False, "NULL", dtpDataPedidoInicioFiltro.Value)
            'Seta Paramentro - Data Pedido Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_pedido_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataPedidoTerminoFiltro.Checked = False, "NULL", dtpDataPedidoTerminoFiltro.Value)
            'Seta Paramentro - Data Previsão Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_previsao_inicio"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataPedidoInicioFiltro.Checked = False, "NULL", dtpDataPedidoInicioFiltro.Value)
            'Seta Paramentro - Data Previsão Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_previsao_termino"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataPedidoTerminoFiltro.Checked = False, "NULL", dtpDataPedidoTerminoFiltro.Value)
            'Seta Paramentro - Status
            goCrystalReport.sReportParameter(7).sParamenter = "@status"
            goCrystalReport.sReportParameter(7).sValue = sStatus
            'Seta Paramentro - UF
            goCrystalReport.sReportParameter(8).sParamenter = "@uf"
            goCrystalReport.sReportParameter(8).sValue = sUF
            'Seta Paramentro - Pais
            goCrystalReport.sReportParameter(9).sParamenter = "@pais"
            goCrystalReport.sReportParameter(9).sValue = sPais
            'Seta Paramentro - Item
            goCrystalReport.sReportParameter(10).sParamenter = "@codigo_item"
            goCrystalReport.sReportParameter(10).sValue = IIf(cboItem.SelectedIndex = -1, -1, cboItem.SelectedValue)

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedor

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemCompraFind = "S"
            oComboBoxFind = cboItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub
End Class
