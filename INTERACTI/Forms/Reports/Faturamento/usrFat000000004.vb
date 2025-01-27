Public Class usrFat000000004

#Region "::: CONTROLES :::"

    Private Sub usrFat000000004_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                    cboParceiroNegocio.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    Select Case sender.Name
                        Case "cboParceiroNegocio" : Call btnProcurarParceiroNegocio_Click(btnProcurarParceiroNegocio, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFat000000004_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFat000000004_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnProcurarParceiroNegocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarParceiroNegocio.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = -1
            oComboBoxFind = cboParceiroNegocio

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboParceiroNegocio.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

            'Carrega ComboBox
            Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoDocumentoFiscal, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)

            'Configura DateTimePicker
            dtpDataInicio.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicio.Checked = False
            dtpDataTermino.Value = Now.Date : dtpDataTermino.Checked = False

            'Seta Focu
            cboParceiroNegocio.Focus()

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
            ReDim goCrystalReport.sReportParameter(5)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000004.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Parceiro Negócio
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboParceiroNegocio.SelectedIndex = -1, -1, cboParceiroNegocio.SelectedValue)
            'Seta Paramentro - Código Tipo de Documento Fiscal
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_tipo_documento_fiscal"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboTipoDocumentoFiscal.SelectedIndex = -1, -1, cboTipoDocumentoFiscal.SelectedValue)
            'Seta Paramentro - Data Início
            goCrystalReport.sReportParameter(4).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataInicio.Checked = False, "NULL", dtpDataInicio.Value)
            'Seta Paramentro - Data Término
            goCrystalReport.sReportParameter(5).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataTermino.Checked = False, "NULL", dtpDataTermino.Value)


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
