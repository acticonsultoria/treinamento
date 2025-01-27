Imports Janus.Windows.GridEX

Public Class usrFin000000004

    'Variáveis da Classe
    Private oClsFin000000004 As New clsUsrFin000000004

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

    Private Sub usrFin000000004_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3
                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFin000000004_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000004
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000004)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridListagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            iCodigoTipoParceiroNegocioFind = CInt(TipoParceiroNegocio.cliente)
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteFiltro.Focus()

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioFIN000000004)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioFIN000000004, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000004_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

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

            If goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD" Then
                lblTipoDocumento.Visible = True
                cboTipoDocumento.Visible = True
            Else
                lblTipoDocumento.Visible = False
                cboTipoDocumento.Visible = False
            End If

            'Carrega Combo - Tipo Documento
            cboTipoDocumento.Items.Clear()
            cboTipoDocumento.Items.Add("KAST", "kast")
            cboTipoDocumento.Items.Add("SOBERANO", "nf")

            'Carrega ComboBox
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFormaPagamentoFiltro, "sp_select_combo_static_tipo_documento_pagamento")
            Call LoadCombo(cboCampanhaFiltro, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa, False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadComboSimNao(cboTransferenciaBancariaFiltro)

            'Carrega Combo - Tipo de Documento Fiscal
            cboTipoDocumentoFiscalFiltro.Items.Clear()
            cboTipoDocumentoFiscalFiltro.Items.Add("NOTA FISCAL", 1)
            cboTipoDocumentoFiscalFiltro.Items.Add("NOTA FISCAL - COM PEDIDO VENDA", 3)
            cboTipoDocumentoFiscalFiltro.Items.Add("NOTA FISCAL - SEM PEDIDO VENDA", 4)
            cboTipoDocumentoFiscalFiltro.Items.Add("PRÉ - NOTA FISCAL", 2)


            'Configura DateTimePicker
            dtpDataEmissaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Carrega Combo - Agrupado
            cboAgrupadoPorFiltro.Items.Clear()
            cboAgrupadoPorFiltro.Items.Add("CONTA BANCÁRIA", "conta_bancaria")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO - DIA", "data_emissao_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO - SEMANA", "data_emissao_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO - MÊS", "data_emissao_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA VENCIMENTO - DIA", "data_vencimento_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA VENCIMENTO - SEMANA", "data_vencimento_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA VENCIMENTO - MÊS", "data_vencimento_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA PAGAMENTO - DIA", "data_pagamento_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA PAGAMENTO - SEMANA", "data_pagamento_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA PAGAMENTO - MÊS", "data_pagamento_mes")
            cboAgrupadoPorFiltro.Items.Add("FORMA DE PAGAMENTO", "forma_pagamento")
            cboAgrupadoPorFiltro.Items.Add("CLIENTE", "cliente")

            'Carrega TreeView
            Call LoadTreeView()

            'Verifica Direito
            btnExcelListagem.Enabled = VerificaDireito(Formulario.RelatorioFIN000000004, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000004, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000004)

            'Seta Focu
            cboClienteFiltro.Focus()

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

            Dim sCodigoFormaPagamento As String = ""
            Dim sCodigoCentroCusto As String = ""

            'Código Tipo de Documento Pagamento
            For Each oRow As GridEXRow In cboFormaPagamentoFiltro.DropDownList.GetCheckedRows
                sCodigoFormaPagamento &= IIf(sCodigoFormaPagamento = "", "", ",") & oRow.Cells("codigo").Value
            Next

            'Código Centro de Custo
            If VerificaSelecaoNode(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCentroCusto &= IIf(sCodigoCentroCusto = "", "", ",") & oNode.Tag
                Next
            End If

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    'Seta Parametros
                    oClsFin000000004.LoadGridLavalpa(grdListagem, _
                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                              IIf(cboTransferenciaBancariaFiltro.SelectedIndex = -1, -1, IIf(cboTransferenciaBancariaFiltro.SelectedValue = True, 1, 0)), _
                                              sCodigoFormaPagamento, _
                                              IIf(cboTipoDocumentoFiscalFiltro.SelectedIndex = -1, -1, cboTipoDocumentoFiscalFiltro.SelectedValue), _
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                              sCodigoCentroCusto, _
                                              IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                              IIf(cboCampanhaFiltro.SelectedIndex = -1, -1, cboCampanhaFiltro.SelectedValue), _
                                              IIf(chkParceiro.Checked = True, chkLavalpa.Checked, 2), _
                                              IIf(chkParceiro.Checked = True, chkLeSix.Checked, 2), _
                                              chkMovimentacao.Checked)

                Else

                    'Seta Parametros
                    oClsFin000000004.LoadGridNorsul(grdListagem, _
                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                              IIf(cboTransferenciaBancariaFiltro.SelectedIndex = -1, -1, IIf(cboTransferenciaBancariaFiltro.SelectedValue = True, 1, 0)), _
                                              sCodigoFormaPagamento, _
                                              IIf(cboTipoDocumentoFiscalFiltro.SelectedIndex = -1, -1, cboTipoDocumentoFiscalFiltro.SelectedValue), _
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                              sCodigoCentroCusto, _
                                              IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                              IIf(cboCampanhaFiltro.SelectedIndex = -1, -1, cboCampanhaFiltro.SelectedValue), _
                                              chkMovimentacao.Checked)

                End If


            Else

                If goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD" Then

                    'Seta Parametros
                    oClsFin000000004.LoadGridSoberano(grdListagem, _
                                                      IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                                      IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                                      IIf(cboTransferenciaBancariaFiltro.SelectedIndex = -1, -1, IIf(cboTransferenciaBancariaFiltro.SelectedValue = True, 1, 0)), _
                                                      sCodigoFormaPagamento, _
                                                      IIf(cboTipoDocumentoFiscalFiltro.SelectedIndex = -1, -1, cboTipoDocumentoFiscalFiltro.SelectedValue), _
                                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                      IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                                      IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                                      IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                                      IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                                      sCodigoCentroCusto, _
                                                      IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                                      IIf(cboCampanhaFiltro.SelectedIndex = -1, -1, cboCampanhaFiltro.SelectedValue), _
                                                      IIf(cboTipoDocumento.SelectedIndex = -1, "", cboTipoDocumento.SelectedValue))

                Else

                    'Seta Parametros
                    oClsFin000000004.LoadGrid(grdListagem, _
                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                              IIf(cboTransferenciaBancariaFiltro.SelectedIndex = -1, -1, IIf(cboTransferenciaBancariaFiltro.SelectedValue = True, 1, 0)), _
                                              sCodigoFormaPagamento, _
                                              IIf(cboTipoDocumentoFiscalFiltro.SelectedIndex = -1, -1, cboTipoDocumentoFiscalFiltro.SelectedValue), _
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                              sCodigoCentroCusto, _
                                              IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                              IIf(cboCampanhaFiltro.SelectedIndex = -1, -1, cboCampanhaFiltro.SelectedValue))
                End If

            End If

            'Exclui Grupos
            If grdListagem.RootTable.Groups.Count > 0 Then
                grdListagem.RootTable.Groups.Remove(grdListagem.RootTable.Groups(0))
            End If

            'Agrupa Registr
            If cboAgrupadoPorFiltro.SelectedIndex > -1 Then
                grdListagem.RootTable.Groups.Add(grdListagem.RootTable.Columns("agrupado"), SortOrder.Ascending)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

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
            oClsCadCentroGasto.LoadTreeViewSelecionado(trvMain, "")

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
                    ReDim goCrystalReport.sReportParameter(20)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000004_Lavalpa.rpt"

                Else

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(18)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000004.rpt"

                End If

            Else

                If goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD" Then

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(18)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000004.rpt"

                Else

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(17)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000004.rpt"

                End If

            End If

            Dim sCodigoFormaPagamento As String = ""
            Dim sFormaPagamento As String = ""
            Dim sCentroCusto As String = ""
            Dim sCodigoCentroCusto As String = ""

            'Código Tipo de Documento Pagamento
            For Each oRow As GridEXRow In cboFormaPagamentoFiltro.DropDownList.GetCheckedRows
                sCodigoFormaPagamento &= IIf(sCodigoFormaPagamento = "", "", ",") & oRow.Cells("codigo").Value
                sFormaPagamento &= IIf(sFormaPagamento = "", "", ",") & oRow.Cells("descricao").Value
            Next

            'Código Centro de Custo
            If VerificaSelecaoNode(trvMain) = True Then
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
            'Seta Paramentro - Código Parceiro Negócio
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue)
            'Seta Paramentro - Código Banco Conta
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_banco_conta"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue)
            'Seta Paramentro - Código Tipo de Documento de Pagamento
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_forma_pagamento"
            goCrystalReport.sReportParameter(4).sValue = sCodigoFormaPagamento
            'Seta Paramentro - Forma de Pagamento
            goCrystalReport.sReportParameter(5).sParamenter = "forma_pagamento"
            goCrystalReport.sReportParameter(5).sValue = IIf(sFormaPagamento = "", "-", sFormaPagamento)
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(6).sParamenter = "@data_emissao_inicio"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(7).sParamenter = "@data_emissao_termino"
            goCrystalReport.sReportParameter(7).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Data Vencimento Início
            goCrystalReport.sReportParameter(8).sParamenter = "@data_vencimento_inicio"
            goCrystalReport.sReportParameter(8).sValue = IIf(dtpDataVencimentoInicioFiltro.Checked = False, "NULL", dtpDataVencimentoInicioFiltro.Value)
            'Seta Paramentro - Data Vencimento Término
            goCrystalReport.sReportParameter(9).sParamenter = "@data_vencimento_termino"
            goCrystalReport.sReportParameter(9).sValue = IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "NULL", dtpDataVencimentoTerminoFiltro.Value)
            'Seta Paramentro - Data Pagamento Início
            goCrystalReport.sReportParameter(10).sParamenter = "@data_pagamento_inicio"
            goCrystalReport.sReportParameter(10).sValue = IIf(dtpDataPagamentoInicioFiltro.Checked = False, "NULL", dtpDataPagamentoInicioFiltro.Value)
            'Seta Paramentro - Data Pagamento Término
            goCrystalReport.sReportParameter(11).sParamenter = "@data_pagamento_termino"
            goCrystalReport.sReportParameter(11).sValue = IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "NULL", dtpDataPagamentoTerminoFiltro.Value)
            'Seta Paramentro - Centro de Custo
            goCrystalReport.sReportParameter(12).sParamenter = "@codigo_centro_custo"
            goCrystalReport.sReportParameter(12).sValue = sCodigoCentroCusto
            'Seta Paramentro - Agrupado Por
            goCrystalReport.sReportParameter(13).sParamenter = "@agrupado_por"
            goCrystalReport.sReportParameter(13).sValue = IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue)
            'Seta Paramentro - Código Tipo de Documento Fiscal
            goCrystalReport.sReportParameter(14).sParamenter = "@codigo_tipo_documento_fiscal"
            goCrystalReport.sReportParameter(14).sValue = IIf(cboTipoDocumentoFiscalFiltro.SelectedIndex = -1, -1, (cboTipoDocumentoFiscalFiltro.SelectedValue))
            'Seta Paramentro - Transferência Bancária
            goCrystalReport.sReportParameter(15).sParamenter = "@transferencia_bancaria"
            goCrystalReport.sReportParameter(15).sValue = IIf(cboTransferenciaBancariaFiltro.SelectedIndex = -1, "NULL", IIf(cboTransferenciaBancariaFiltro.SelectedValue = True, 1, 0))
            'Seta Paramentro - Centro de Custo
            goCrystalReport.sReportParameter(16).sParamenter = "centro_gasto"
            goCrystalReport.sReportParameter(16).sValue = sCentroCusto
            'Seta Paramentro - Código Campanha
            goCrystalReport.sReportParameter(17).sParamenter = "@codigo_campanha"
            goCrystalReport.sReportParameter(17).sValue = IIf(cboCampanhaFiltro.SelectedIndex = -1, -1, (cboCampanhaFiltro.SelectedValue))

            If (goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD") Then

                'Seta Paramentro - Tipo Documento
                goCrystalReport.sReportParameter(18).sParamenter = "@tipo_documento"
                goCrystalReport.sReportParameter(18).sValue = IIf(cboTipoDocumento.SelectedIndex = -1, "", cboTipoDocumento.SelectedValue)

            End If

            If (goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD") Then

                'Seta Paramentro - Movimentação
                goCrystalReport.sReportParameter(18).sParamenter = "@movimentacao"
                goCrystalReport.sReportParameter(18).sValue = chkMovimentacao.Checked

            End If

            If ((goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD") And (goUsuario.iEmpresa = 4)) Then

                'Seta Paramentro - Lavalpa
                goCrystalReport.sReportParameter(19).sParamenter = "@lavalpa"
                goCrystalReport.sReportParameter(19).sValue = IIf(chkParceiro.Checked = True, chkLavalpa.Checked, "NULL")
                'Seta Paramentro - LeSix
                goCrystalReport.sReportParameter(20).sParamenter = "@le_six"
                goCrystalReport.sReportParameter(20).sValue = IIf(chkParceiro.Checked = True, chkLeSix.Checked, "NULL")

            End If

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Private Sub grdListagem_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)

    End Sub
End Class
