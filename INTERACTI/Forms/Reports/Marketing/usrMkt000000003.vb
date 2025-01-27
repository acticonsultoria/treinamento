Public Class usrMkt000000003

#Region "::: CONTROLES :::"

    Private Sub usrMkt000000003_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrMkt000000003_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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

            'Verifica Direito
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioMKT000000003, gcInsert)

            'Carrega ComboBox
            Call LoadCombo(cboSegmento, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, False)

            'Configura DateTimePicker
            dtpDataInicio.Value = Now.Date : dtpDataInicio.Checked = False
            dtpDataTermino.Value = Now.Date : dtpDataTermino.Checked = False
            dtpDataInicioPedido.Value = Now.Date : dtpDataInicioPedido.Checked = False
            dtpDataTerminoPedido.Value = Now.Date : dtpDataTerminoPedido.Checked = False

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
            ReDim goCrystalReport.sReportParameter(12)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "MKT000000003.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Segmento
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_segmento"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboSegmento.SelectedIndex = -1, -1, cboSegmento.SelectedValue)
            'Seta Paramentro - Segmento
            goCrystalReport.sReportParameter(3).sParamenter = "segmento"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboSegmento.SelectedIndex = -1, "", cboSegmento.Text)
            'Seta Paramentro - Código Cliente
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_cliente"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue)
            'Seta Paramentro - Cliente
            goCrystalReport.sReportParameter(5).sParamenter = "cliente"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboCliente.SelectedIndex = -1, "", cboCliente.Text)
            'Seta Paramentro - Código Vendedor
            goCrystalReport.sReportParameter(6).sParamenter = "@codigo_vendedor"
            goCrystalReport.sReportParameter(6).sValue = IIf(cboVendedor.SelectedIndex = -1, -1, cboVendedor.SelectedValue)
            'Seta Paramentro - Vendedor
            goCrystalReport.sReportParameter(7).sParamenter = "vendedor"
            goCrystalReport.sReportParameter(7).sValue = IIf(cboVendedor.SelectedIndex = -1, "", cboVendedor.Text)
            'Seta Paramentro - Data Pedido Início
            goCrystalReport.sReportParameter(8).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(8).sValue = IIf(dtpDataInicio.Checked = False, "NULL", dtpDataInicio.Value)
            'Seta Paramentro - Data Pedido Término
            goCrystalReport.sReportParameter(9).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(9).sValue = IIf(dtpDataTermino.Checked = False, "NULL", dtpDataTermino.Value)
            'Seta Paramentro - Data Pedido Pedido Início
            goCrystalReport.sReportParameter(10).sParamenter = "@data_pedido_inicio"
            goCrystalReport.sReportParameter(10).sValue = IIf(dtpDataInicioPedido.Checked = False, "NULL", dtpDataInicioPedido.Value)
            'Seta Paramentro - Data Pedido Pedido Término
            goCrystalReport.sReportParameter(11).sParamenter = "@data_pedido_termino"
            goCrystalReport.sReportParameter(11).sValue = IIf(dtpDataTerminoPedido.Checked = False, "NULL", dtpDataTerminoPedido.Value)
            'Seta Paramentro - Código Usuário
            goCrystalReport.sReportParameter(12).sParamenter = "@codigo_usuario"
            goCrystalReport.sReportParameter(12).sValue = goUsuario.iUsuario

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
