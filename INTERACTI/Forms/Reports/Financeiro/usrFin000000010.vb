Imports Janus.Windows.GridEX

Public Class usrFin000000010

    'Variáveis da Classe
    Private oClsFin000000010 As New clsUsrFin000000010

#Region "::: CONTROLES :::"

    Private Sub btnConfiguraGridListagem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridListagem.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000001
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000001)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelListagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelListagem.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkParceiro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkParceiro.CheckedChanged

        Try

            If chkParceiro.Checked = True Then

                chkLavalpa.Enabled = True
                chkLeSix.Enabled = True

            Else

                chkLavalpa.Enabled = False
                chkLeSix.Enabled = False
                chkLavalpa.Checked = False
                chkLeSix.Checked = False

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFin000000010_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFin000000010_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000010
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000010)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub trvMain_AfterCheck(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles trvMain.AfterCheck

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000010_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            cboTipo.Items.Clear()
            cboTipo.Items.Add("DESPESA", "D")
            cboTipo.Items.Add("RECEITA", "R")

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    grpParceiro.Visible = True
                    chkLavalpa.Visible = True
                    chkLeSix.Visible = True
                    chkMovimentacao.Visible = True

                    'grdListagem.RootTable.Columns.Add("parceiro")

                Else

                    grpParceiro.Visible = False
                    chkLavalpa.Visible = False
                    chkLeSix.Visible = False
                    chkMovimentacao.Visible = True

                    grdListagem.RootTable.Columns.Remove("parceiro")

                End If

            Else

                grpParceiro.Visible = False
                chkLavalpa.Visible = False
                chkLeSix.Visible = False
                chkMovimentacao.Visible = False

                grdListagem.RootTable.Columns.Remove("parceiro")

            End If

            'Configura DateTimePicker
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = Now.Date : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000010)

            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000010, gcPrint)
            btnExcelListagem.Enabled = VerificaDireito(Formulario.RelatorioFIN000000010, gcPrint)

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
            Dim sCodigoCentroCusto As String = ""

            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCentroCusto &= IIf(sCodigoCentroCusto = "", "", ",") & oNode.Tag
                Next
            End If

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    'Seta Parametros
                    oClsFin000000010.LoadGridLavalpa(grdListagem, _
                                              IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                              sCodigoCentroCusto, _
                                              IIf(chkParceiro.Checked = True, chkLavalpa.Checked, 2), _
                                              IIf(chkParceiro.Checked = True, chkLeSix.Checked, 2), _
                                              chkMovimentacao.Checked)

                Else

                    'Seta Parametros
                    oClsFin000000010.LoadGridNorsul(grdListagem, _
                                                    IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                                    IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                    IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                    IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                                    IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                                    IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                                    IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                                    sCodigoCentroCusto, _
                                                    chkMovimentacao.Checked)

                End If

            Else

                'Seta Parametros
                oClsFin000000010.LoadGrid(grdListagem, _
                                          IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                          sCodigoCentroCusto)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(13)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000010_Lavalpa.rpt"

                Else

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(11)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000010.rpt"

                End If

            Else

                'Redimensiona Vetor
                ReDim goCrystalReport.sReportParameter(10)
                'Relatório
                goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000010.rpt"

            End If

            'Váriaveis
            Dim sCodigoCentroCusto As String = ""
            Dim sCentroCusto As String = ""

            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCentroCusto &= IIf(sCodigoCentroCusto = "", "", ",") & oNode.Tag
                    sCentroCusto &= IIf(sCentroCusto = "", "", ",") & oNode.Text
                Next
            End If

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Centro de Gasto
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_centro_custo"
            goCrystalReport.sReportParameter(2).sValue = sCodigoCentroCusto
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
            'Seta Paramentro - Código Conta Contábil
            goCrystalReport.sReportParameter(10).sParamenter = "centro_custo"
            goCrystalReport.sReportParameter(10).sValue = sCentroCusto

            If (goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD") Then

                'Seta Paramentro - Movimentação
                goCrystalReport.sReportParameter(11).sParamenter = "@movimentacao"
                goCrystalReport.sReportParameter(11).sValue = chkMovimentacao.Checked

            End If

            If ((goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD") And (goUsuario.iEmpresa = 4)) Then

                'Seta Paramentro - Lavalpa
                goCrystalReport.sReportParameter(12).sParamenter = "@lavalpa"
                goCrystalReport.sReportParameter(12).sValue = IIf(chkParceiro.Checked = True, chkLavalpa.Checked, "NULL")
                'Seta Paramentro - LeSix
                goCrystalReport.sReportParameter(13).sParamenter = "@le_six"
                goCrystalReport.sReportParameter(13).sValue = IIf(chkParceiro.Checked = True, chkLeSix.Checked, "NULL")

            End If

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

            Dim oClsCadCentroGasto As New clsUsrCadCentroGasto

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            oClsCadCentroGasto.LoadTreeViewSelecionado(trvMain, txtCentroCustroFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Private Sub btnExportarRelatorio_Click(sender As Object, e As EventArgs) Handles btnExportarRelatorio.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            'Váriaveis
            Dim sCodigoCentroCusto As String = ""

            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCentroCusto &= IIf(sCodigoCentroCusto = "", "", ",") & oNode.Tag
                Next
            End If

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    oClsFin000000010.GerarPlanilha(IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                                          sCodigoCentroCusto, _
                                                          IIf(chkParceiro.Checked = True, chkLavalpa.Checked, 2), _
                                                          IIf(chkParceiro.Checked = True, chkLeSix.Checked, 2), _
                                                          chkMovimentacao.Checked)

                Else

                    oClsFin000000010.GerarPlanilha(IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                   IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                   IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                                   IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                                   IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                                   IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                                   sCodigoCentroCusto, _
                                                   "", _
                                                   "", _
                                                   chkMovimentacao.Checked)
                End If

            Else

                oClsFin000000010.GerarPlanilha(IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                               IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                               IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                               IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                               IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                               IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                               sCodigoCentroCusto, _
                                               "", _
                                               "", _
                                               "")

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
