Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class usrVen000000001

#Region "::: CONTROLES :::"

    Private Sub usrVen000000001_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrVen000000001_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Orçamento
            If ValidaCampo(cboNumeroOrcamento, lblNumeroOrcamento) = False Then
                Exit Sub
            End If

            'Visualizar Impressão
            Call VisualizarImpressao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Orçamento
            If ValidaCampo(cboNumeroOrcamento, lblNumeroOrcamento) = False Then
                Exit Sub
            End If

            'Imprime
            Call Email()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call LoadCombo(cboNumeroOrcamento, "sp_select_combo_venda_orcamento_report " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboNumeroOrcamento.Focus()

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
            ReDim goCrystalReport.sReportParameter(2)

            'Váriavel - Relatório
            Dim sReport As String

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE VENDA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Carrega Váriavel
            sReport &= ".rpt"

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Orçamento
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_orcamento"
            goCrystalReport.sReportParameter(2).sValue = cboNumeroOrcamento.SelectedValue


            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Arquivo = True
            oReport.Tabela = "tb_ven_orcamento"
            oReport.Codigo = cboNumeroOrcamento.SelectedValue
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Email()

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument
            Dim sArquivo As String

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Local
            Dim sReport As String

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE VENDA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Carrega Váriavel
            sReport &= ".rpt"

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_orcamento", cboNumeroOrcamento.SelectedValue)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Seta Váriavel
            sArquivo = ApplicationPath() & "File\" & cboNumeroOrcamento.Text.Trim & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

            'Verifica se o Arquivo Existe, se existir Exclui
            If File.Exists(sArquivo) Then
                File.Delete(sArquivo)
            End If

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - " & "Orçamento " & cboNumeroOrcamento.Text, _
                             "", _
                             ApplicationPath() & "File\" & cboNumeroOrcamento.Text.Trim & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf", _
                             ApplicationPath() & "File\" & cboNumeroOrcamento.Text.Trim & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf", _
                             "", _
                             -1)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
