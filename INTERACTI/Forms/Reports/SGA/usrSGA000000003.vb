Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class usrSGA000000003

    'Variáveis da Classe
    Private oClsSGA000000003 As New clsUsrSGA000000003
#Region "::: CONTROLES :::"

    Private Sub usr_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp, _
                                                                                                                    cboEmpresa.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.F3



            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadCor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
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
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub txtCodigoCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.LostFocus
        Try

            If IsNumeric(txtCodigoCliente.Text) Then
                Dim iCodigo As Integer = LoadCodigo("sp_select_codigo_parceiro_negocio_sga " & txtCodigoCliente.Text)
                cboCliente.SelectedValue = iCodigo
            Else
                cboCliente.SelectedIndex = -1
                Exit Sub
            End If



            Dim iCodigoEmpresa As Integer = LoadCodigo("sp_select_codigo_empresa_parceiro_negocio " & txtCodigoCliente.Text)

            If iCodigoEmpresa = 0 Then
                cboEmpresa.SelectedIndex = -1
            Else
                cboEmpresa.SelectedValue = iCodigoEmpresa
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboCliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedValueChanged
        Try

            If cboCliente.SelectedIndex <> -1 Then
                Dim iCodigo As Integer = LoadCodigo("sp_select_codigo_integracao_parceiro_negocio_sga " & cboCliente.SelectedValue)
                txtCodigoCliente.Text = iCodigo
            Else
                txtCodigoCliente.Text = ""
                Exit Sub
            End If


            Dim iCodigoEmpresa As Integer = LoadCodigo("sp_select_codigo_empresa_parceiro_negocio " & cboCliente.SelectedValue)

            If iCodigoEmpresa = 0 Then
                cboEmpresa.SelectedIndex = -1
            Else
                cboEmpresa.SelectedValue = iCodigoEmpresa
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmpresa.SelectedIndexChanged, optImprimirSomenteEntregaFisica.CheckedChanged, optImprimirTodos.CheckedChanged, cboAtivo.SelectedIndexChanged
        Try
            If cboEmpresa.SelectedIndex = -1 Then Exit Sub


            LoadGridCliente(grdListagem, cboEmpresa.SelectedValue, optImprimirTodos.Checked, _
                            IIf(cboAtivo.SelectedIndex = -1, -1, IIf(cboAtivo.SelectedValue = True, 1, 0)))

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox

            Call LoadCombo(cboEmpresa, "sp_select_combo_cadastro_basico_empresa")
            Call LoadCombo(cboCliente, "sp_select_combo_sga_cadastro_basico_cliente")
            Call LoadComboSimNao(cboAtivo)

            'Seta a data de competência
            cboDataInicial.Value = Now.Date
            cboDataTermino.Value = Now.Date

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try
            Dim sCodigo As String = ""
            'Seta Paramentro - Código Cliente
            If txtCodigoCliente.Text <> "" Then
                sCodigo = cboCliente.SelectedValue
            Else

                For Each oRow In grdListagem.GetCheckedRows

                    sCodigo += CStr(oRow.Cells.Item("codigo").Value) + ","

                Next

                If Len(sCodigo) > 0 Then
                    sCodigo = Mid(sCodigo, 1, Len(sCodigo) - 1)
                End If

            End If

            oClsSGA000000003.Insert(cboDataInicial.Value.Month, _
                                    cboDataInicial.Value.Year, _
                                    cboDataTermino.Value.Month, _
                                    cboDataTermino.Value.Year, _
                                    sCodigo, _
                                    IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue))

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(8)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "SGA000000003.rpt"


            'Seta Paramentro - Mes Inicial
            goCrystalReport.sReportParameter(0).sParamenter = "@mes_inicial"
            goCrystalReport.sReportParameter(0).sValue = cboDataInicial.Value.Month

            'Seta Paramentro - Ano Inicial
            goCrystalReport.sReportParameter(1).sParamenter = "@ano_inicial"
            goCrystalReport.sReportParameter(1).sValue = cboDataInicial.Value.Year

            'Seta Paramentro - Mes Termino
            goCrystalReport.sReportParameter(2).sParamenter = "@mes_termino"
            goCrystalReport.sReportParameter(2).sValue = cboDataTermino.Value.Month

            'Seta Paramentro - Ano Termino
            goCrystalReport.sReportParameter(3).sParamenter = "@ano_termino"
            goCrystalReport.sReportParameter(3).sValue = cboDataTermino.Value.Year

            'Seta Paramentro - Codigo Empresa
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue)



            goCrystalReport.sReportParameter(5).sParamenter = "@codigos"
            goCrystalReport.sReportParameter(5).sValue = sCodigo

            goCrystalReport.sReportParameter(6).sParamenter = "mensagem"
            goCrystalReport.sReportParameter(6).sValue = txtMensagem.Text

            goCrystalReport.sReportParameter(7).sParamenter = "@imprimir_todos"
            goCrystalReport.sReportParameter(7).sValue = optImprimirTodos.Checked

            goCrystalReport.sReportParameter(8).sParamenter = "imprimir_protocolo"
            goCrystalReport.sReportParameter(8).sValue = chkImprimirProtocolo.Checked

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            oReport.Print = False
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub VisualizarImpressaoSeparado()

        Try
            Dim sPastaImpressao As String = "\\srvfs02\Aplicativos\SGA.NET\Arquivos Fatura\"

            Dim sCodigo As String = ""
            'Seta Paramentro - Código Cliente
            If txtCodigoCliente.Text <> "" Then
                sCodigo = cboCliente.SelectedValue
            Else

                For Each oRow In grdListagem.GetCheckedRows

                    sCodigo += CStr(oRow.Cells.Item("codigo").Value) + ","

                Next

                If Len(sCodigo) > 0 Then
                    sCodigo = Mid(sCodigo, 1, Len(sCodigo) - 1)
                End If

            End If

            oClsSGA000000003.Insert(cboDataInicial.Value.Month, _
                                    cboDataInicial.Value.Year, _
                                    cboDataTermino.Value.Month, _
                                    cboDataTermino.Value.Year, _
                                    sCodigo, _
                                    IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue))

            Dim oArquivo() As String
            ReDim oArquivo(1)
            'Dim sReport As String = "SGA000000003_FATURA.rpt"
            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "SGA000000003_FATURA.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@mes_inicial", cboDataInicial.Value.Month)
            oRptDocument.SetParameterValue("@ano_inicial", cboDataInicial.Value.Year)
            oRptDocument.SetParameterValue("@mes_termino", cboDataTermino.Value.Month)
            oRptDocument.SetParameterValue("@ano_termino", cboDataTermino.Value.Year)
            oRptDocument.SetParameterValue("@codigo_empresa", IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue))
            oRptDocument.SetParameterValue("@codigos", sCodigo)
            oRptDocument.SetParameterValue("mensagem", txtMensagem.Text)
            oRptDocument.SetParameterValue("@imprimir_todos", optImprimirTodos.Checked)
            oRptDocument.SetParameterValue("imprimir_protocolo", optImprimirTodos.Checked)

            'Abre Conexão com o Banco de Dados
            For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            oArquivo(0) = sPastaImpressao & "FATURAS_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      oArquivo(0))

            'Limpa Váriavel


            '***************************************************************************************************************
            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "SGA000000003_PROTOCOLO.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@mes_inicial", cboDataInicial.Value.Month)
            oRptDocument.SetParameterValue("@ano_inicial", cboDataInicial.Value.Year)
            oRptDocument.SetParameterValue("@mes_termino", cboDataTermino.Value.Month)
            oRptDocument.SetParameterValue("@ano_termino", cboDataTermino.Value.Year)
            oRptDocument.SetParameterValue("@codigo_empresa", IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue))
            oRptDocument.SetParameterValue("@codigos", sCodigo)
            oRptDocument.SetParameterValue("mensagem", txtMensagem.Text)
            oRptDocument.SetParameterValue("@imprimir_todos", optImprimirTodos.Checked)
            oRptDocument.SetParameterValue("imprimir_protocolo", optImprimirTodos.Checked)

            'Abre Conexão com o Banco de Dados
            For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            oArquivo(1) = sPastaImpressao & "PROTOCOLOS_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      oArquivo(1))

            'Limpa Váriavel
            oRptDocument = Nothing

            Dim sArquivoImpressao As String = GerarPDF(sPastaImpressao + "FATURAS_PROTOCOLOS_" + Format(Now, "yyyyMMdd_hhmm") + "_.pdf", oArquivo)
            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = sArquivoImpressao
            Process.Start(psi)
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default


            ''Redimensiona Vetor
            'ReDim goCrystalReport.sReportParameter(8)

            ''Relatório
            'goCrystalReport.sReport = goCrystalReport.sPath & "SGA000000003.rpt"


            ''Seta Paramentro - Mes Inicial
            'goCrystalReport.sReportParameter(0).sParamenter = "@mes_inicial"
            'goCrystalReport.sReportParameter(0).sValue = cboDataInicial.Value.Month

            ''Seta Paramentro - Ano Inicial
            'goCrystalReport.sReportParameter(1).sParamenter = "@ano_inicial"
            'goCrystalReport.sReportParameter(1).sValue = cboDataInicial.Value.Year

            ''Seta Paramentro - Mes Termino
            'goCrystalReport.sReportParameter(2).sParamenter = "@mes_termino"
            'goCrystalReport.sReportParameter(2).sValue = cboDataTermino.Value.Month

            ''Seta Paramentro - Ano Termino
            'goCrystalReport.sReportParameter(3).sParamenter = "@ano_termino"
            'goCrystalReport.sReportParameter(3).sValue = cboDataTermino.Value.Year

            ''Seta Paramentro - Codigo Empresa
            'goCrystalReport.sReportParameter(4).sParamenter = "@codigo_empresa"
            'goCrystalReport.sReportParameter(4).sValue = IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue)

            'goCrystalReport.sReportParameter(5).sParamenter = "@codigos"
            'goCrystalReport.sReportParameter(5).sValue = sCodigo

            'goCrystalReport.sReportParameter(6).sParamenter = "mensagem"
            'goCrystalReport.sReportParameter(6).sValue = txtMensagem.Text

            'goCrystalReport.sReportParameter(7).sParamenter = "@imprimir_todos"
            'goCrystalReport.sReportParameter(7).sValue = optImprimirTodos.Checked

            'goCrystalReport.sReportParameter(8).sParamenter = "imprimir_protocolo"
            'goCrystalReport.sReportParameter(8).sValue = chkImprimirProtocolo.Checked

            ''Abre Relatório
            'Dim oReport = New usrReport
            'oReport.Dock = DockStyle.Fill
            'oReport.Print = False
            'frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
#End Region



    Private Sub btnVisualizarImpressaoSeparado_Click(sender As Object, e As EventArgs) Handles btnVisualizarImpressaoSeparado.Click
        Try

            'Visualizar Impressão
            Call VisualizarImpressaoSeparado()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
End Class
