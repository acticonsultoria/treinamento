Public Class usrCad000000003

#Region "::: CONTROLES :::"

    Private Sub usrCad000000003_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCad000000003_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            Call LoadCombo(cboVendedorFiltro, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboSegmentoFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)
            Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            Call LoadCombo(cboUFFiltro, "sp_select_combo_static_estado")

            'Seta Focu
            cboVendedorFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Váriaveis Locais
            Dim sVendedor As String = ""
            Dim sSegmento As String = ""
            Dim sCliente As String = ""
            Dim sUF As String = ""
            Dim i As Integer

            'Vendedor
            If cboVendedorFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboVendedorFiltro.CheckedValues)
                    sVendedor &= IIf(sVendedor = "", "", ",") & cboVendedorFiltro.CheckedValues(i).ToString
                Next
            End If

            'Segmento
            If cboSegmentoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboSegmentoFiltro.CheckedValues)
                    sSegmento &= IIf(sSegmento = "", "", ",") & cboSegmentoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Cliente
            If cboParceiroNegocio.SelectionLength > 0 Then
                For i = 0 To UBound(cboParceiroNegocio.CheckedValues)
                    sCliente &= IIf(sCliente = "", "", ",") & cboParceiroNegocio.CheckedValues(i).ToString
                Next
            End If

            'UF
            If cboUFFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboUFFiltro.CheckedValues)
                    sUF &= IIf(sUF = "", "", ",") & cboUFFiltro.CheckedValues(i).ToString
                Next
            End If

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(6)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "CAD000000003.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Vendedor
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_vendedor"
            goCrystalReport.sReportParameter(2).sValue = sVendedor
            'Seta Paramentro - Segmento
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_segmento"
            goCrystalReport.sReportParameter(3).sValue = sSegmento
            'Seta Paramentro - UF
            goCrystalReport.sReportParameter(4).sParamenter = "@uf"
            goCrystalReport.sReportParameter(4).sValue = sUF
            'Seta Paramentro - Cliente
            goCrystalReport.sReportParameter(5).sParamenter = "@codigo_cliente"
            goCrystalReport.sReportParameter(5).sValue = sCliente
            'Seta Paramentro - Município
            goCrystalReport.sReportParameter(6).sParamenter = "@municipio"
            goCrystalReport.sReportParameter(6).sValue = txtMunicipio.Text.Trim

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
