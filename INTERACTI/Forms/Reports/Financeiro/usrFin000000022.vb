Public Class usrFin000000022

#Region "::: CONTROLES :::"

    Private Sub usrFin000000022_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown



    End Sub

    Private Sub usrFin000000022_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFin000000022_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoTituloFinanceiro, "sp_select_combo_static_tipo_titulo_financeiro", False)

            'Carrga CombBox - Agrupado Por
            cboAgrupadoPor.Items.Clear()
            cboAgrupadoPor.Items.Add("DIA", "_01")
            cboAgrupadoPor.Items.Add("SEMANA", "_02")
            cboAgrupadoPor.Items.Add("MÊS", "_03")




            'Configura DateTimePicker
            dtpPeriodoInicio.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpPeriodoInicio.Checked = False
            dtpPeriodoTermino.Value = Now.Date : dtpPeriodoTermino.Checked = False

            'Seta Focu
            cboContaBancaria.Focus()

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
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000022" + IIf(cboAgrupadoPor.SelectedIndex = -1, "", cboAgrupadoPor.SelectedValue) + ".rpt"



            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Banco Conta
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_banco_conta"
            goCrystalReport.sReportParameter(1).sValue = IIf(cboContaBancaria.SelectedIndex = -1, -1, cboContaBancaria.SelectedValue)
            'Seta Paramentro - Código Tipo de Documento de Pagamento
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_tipo_titulo_financeiro"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboTipoTituloFinanceiro.SelectedIndex = -1, -1, cboTipoTituloFinanceiro.SelectedValue)
            'Seta Paramentro - Data Vencimento Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(3).sValue = dtpPeriodoInicio.Value
            'Seta Paramentro - Data Vencimento Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpPeriodoTermino.Checked = False, "NULL", dtpPeriodoTermino.Value)



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