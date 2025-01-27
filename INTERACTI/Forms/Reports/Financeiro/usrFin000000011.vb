Imports Janus.Windows.GridEX

Public Class usrFin000000011

    'Variáveis da Classe
    Private oClsFin000000011 As New clsUsrFin000000011

#Region "::: CONTROLES :::"

    Private Sub usrFin000000011_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFin000000011_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000011
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000011)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarGrid.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Visualizar Impressão
            Call VisualizarImpressao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles trvMain.AfterCheck

        Try

            For Each oNode As TreeNode In e.Node.Nodes
                oNode.Checked = e.Node.Checked
            Next

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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000011_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            cboTipo.Items.Clear()
            cboTipo.Items.Add("DESPESA", "D")
            cboTipo.Items.Add("RECEITA", "R")

            'Configura DateTimePicker
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = Now.Date : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000011)

            'Carrega TreeView
            Call LoadTreeView()

            'Seta Focu
            cboTipo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis
            Dim sCodigoContaContabil As String = ""

            If VerificaSelecaoNode(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoContaContabil &= IIf(sCodigoContaContabil = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Parametros
            oClsFin000000011.LoadGrid(grdListagem, _
                                      IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                      sCodigoContaContabil)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(9)

            'Váriaveis
            Dim sCodigoContaContabil As String = ""
            Dim sContaContabil As String = ""

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000011.rpt"

            If VerificaSelecaoNode(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoContaContabil &= IIf(sCodigoContaContabil = "", "", ",") & oNode.Tag
                    sContaContabil &= IIf(sContaContabil = "", "", ",") & oNode.Text
                Next
            End If

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Centro de Gasto
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_conta_contabil"
            goCrystalReport.sReportParameter(2).sValue = sCodigoContaContabil
            'Seta Paramentro - Tipo
            goCrystalReport.sReportParameter(3).sParamenter = "@tipo"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue)
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(4).sParamenter = "@data_emissao_inicio"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(5).sParamenter = "@data_emissao_termino"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Data Vencimento Início
            goCrystalReport.sReportParameter(6).sParamenter = "@data_vencimento_inicio"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataVencimentoInicioFiltro.Checked = False, "NULL", dtpDataVencimentoInicioFiltro.Value)
            'Seta Paramentro - Data Vencimento Término
            goCrystalReport.sReportParameter(7).sParamenter = "@data_vencimento_termino"
            goCrystalReport.sReportParameter(7).sValue = IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "NULL", dtpDataVencimentoTerminoFiltro.Value)
            'Seta Paramentro - Data Pagamento Início
            goCrystalReport.sReportParameter(8).sParamenter = "@data_pagamento_inicio"
            goCrystalReport.sReportParameter(8).sValue = IIf(dtpDataPagamentoInicioFiltro.Checked = False, "NULL", dtpDataPagamentoInicioFiltro.Value)
            'Seta Paramentro - Data Pagamento Término
            goCrystalReport.sReportParameter(9).sParamenter = "@data_pagamento_termino"
            goCrystalReport.sReportParameter(9).sValue = IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "NULL", dtpDataPagamentoTerminoFiltro.Value)
           

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oClsCadContaContabil As New clsUsrCadPlanoContas

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            oClsCadContaContabil.LoadTreeViewSelecionado(trvMain, txtContaContabilFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
