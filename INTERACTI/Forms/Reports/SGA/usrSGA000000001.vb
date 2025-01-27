Imports System.IO
Imports System

Public Class usrSGA000000001

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
            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
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
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Abre Formulário
            ConfigureMaskEdit(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"
    'Private Sub PDF()
    '    Try
    '        Dim oFileStream As FileStream
    '        Dim oClient As New pdfcrowd.Client("tharcius", "a39741d9daff37cd9fb8b0c3e71569a3")
    '        oFileStream = New FileStream("e:\teste.pdf", FileMode.CreateNew)

    '        oClient.convertURI("http://www.google.com", oFileStream)
    '        oFileStream.Close()

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
    Private Sub ConfigurarUserControl()

        Try
            'PDF()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox
            Call LoadCombo(cboCliente, "sp_select_combo_sga_cadastro_basico_cliente")
            Call LoadCombo(cboEmpresa, "sp_select_combo_cadastro_basico_empresa")
            'Seta a data de competência
            cboCompetencia.Value = Now

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
            ReDim goCrystalReport.sReportParameter(3)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "SGA000000001.rpt"


            'Seta Paramentro - Mês
            goCrystalReport.sReportParameter(0).sParamenter = "@mes"
            goCrystalReport.sReportParameter(0).sValue = Month(cboCompetencia.Value)
            'Seta Paramentro - Ano
            goCrystalReport.sReportParameter(1).sParamenter = "@ano"
            goCrystalReport.sReportParameter(1).sValue = Year(cboCompetencia.Value)
            'Seta Paramentro - Código Cliente
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_cliente"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue)
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue)




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
