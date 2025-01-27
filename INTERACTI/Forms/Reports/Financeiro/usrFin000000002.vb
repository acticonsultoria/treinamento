Imports Janus.Windows.GridEX

Public Class usrFin000000002

    'Variáveis da Classe
    Private oClsFin000000002 As New clsUsrFin000000002

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

    Private Sub usrFin000000002_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3
                    Select Case sender.Name
                        Case "cboFornecedorFiltro" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                        Case "cboCentroCustoFiltro" : Call btnProcurarCentroCusto_Click(btnProcurarCentroCusto, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFin000000002_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000002
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000002)

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

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = CInt(TipoParceiroNegocio.fornecedor)
            oComboBoxFind = cboFornecedorFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedorFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroCusto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroCustoFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroCustoFiltro.Focus()

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
                                     Formulario.RelatorioFIN000000002)

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
                                     Formulario.RelatorioFIN000000002, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000002_KeyDown))
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

            'Carrega ComboBox
            Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroCustoFiltro, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFormaPagamentoFiltro, "sp_select_combo_static_tipo_documento_pagamento")
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimePicker
            dtpDataEmissaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Carrega Combo - Agrupado
            cboAgrupadoPorFiltro.Items.Clear()
            cboAgrupadoPorFiltro.Items.Add("CENTRO DE GASTO", "centro_custo")
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
            cboAgrupadoPorFiltro.Items.Add("FORNECEDOR", "fornecedor")

            'Carrega Combo - Tipo Documento
            cboTipoDocumento.Items.Clear()
            cboTipoDocumento.Items.Add("KAST", "kast")
            cboTipoDocumento.Items.Add("SOBERANO", "nf")

            'Verifica Direito
            btnExcelListagem.Enabled = VerificaDireito(Formulario.RelatorioFIN000000002, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000002, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000002)

            'Seta Focu
            cboFornecedorFiltro.Focus()

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

            'Código Tipo de Documento Pagamento
            For Each oRow As GridEXRow In cboFormaPagamentoFiltro.DropDownList.GetCheckedRows
                sCodigoFormaPagamento &= IIf(sCodigoFormaPagamento = "", "", ",") & oRow.Cells("codigo").Value
            Next

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    'Seta Parametros
                    oClsFin000000002.LoadGridLavalpa(grdListagem, _
                                              IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                              sCodigoFormaPagamento, _
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                              IIf(cboCentroCustoFiltro.SelectedIndex = -1, -1, cboCentroCustoFiltro.SelectedValue), _
                                              IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                              IIf(chkParceiro.Checked = True, chkLavalpa.Checked, 2), _
                                              IIf(chkParceiro.Checked = True, chkLeSix.Checked, 2), _
                                              chkMovimentacao.Checked)

                Else

                    'Seta Parametros
                    oClsFin000000002.LoadGridNorsul(grdListagem, _
                                                    IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                                    IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                                    sCodigoFormaPagamento, _
                                                    IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                    IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                    IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                                    IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                                    IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                                    IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                                    IIf(cboCentroCustoFiltro.SelectedIndex = -1, -1, cboCentroCustoFiltro.SelectedValue), _
                                                    IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                                    chkMovimentacao.Checked)

                End If

            Else

                If goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD" Then

                    'Seta Parametros
                    oClsFin000000002.LoadGridSoberano(grdListagem, _
                                                      IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                                      IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                                      sCodigoFormaPagamento, _
                                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                      IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                                      IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                                      IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                                      IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                                      IIf(cboCentroCustoFiltro.SelectedIndex = -1, -1, cboCentroCustoFiltro.SelectedValue), _
                                                      IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                                      IIf(cboTipoDocumento.SelectedIndex = -1, "", cboTipoDocumento.SelectedValue))

                Else

                    'Seta Parametros
                    oClsFin000000002.LoadGrid(grdListagem, _
                                              IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                              sCodigoFormaPagamento, _
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
                                              IIf(cboCentroCustoFiltro.SelectedIndex = -1, -1, cboCentroCustoFiltro.SelectedValue), _
                                              IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue))

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

    Private Sub VisualizarImpressao()

        Try

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(17)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000002_Lavalpa.rpt"

                Else

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(15)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000002.rpt"

                End If

            Else

                If goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD" Then

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(15)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000002.rpt"

                Else

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(14)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000002.rpt"

                End If

            End If

            Dim sCodigoFormaPagamento As String = ""
            Dim sFormaPagamento As String = ""

            'Código Tipo de Documento Pagamento
            For Each oRow As GridEXRow In cboFormaPagamentoFiltro.DropDownList.GetCheckedRows
                sCodigoFormaPagamento &= IIf(sCodigoFormaPagamento = "", "", ",") & oRow.Cells("codigo").Value
                sFormaPagamento &= IIf(sFormaPagamento = "", "", ",") & oRow.Cells("descricao").Value
            Next

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Parceiro Negócio
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue)
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
            goCrystalReport.sReportParameter(12).sValue = IIf(cboCentroCustoFiltro.SelectedIndex = -1, -1, cboCentroCustoFiltro.SelectedValue)
            'Seta Paramentro - Centro de Custo
            goCrystalReport.sReportParameter(13).sParamenter = "centro_custo"
            goCrystalReport.sReportParameter(13).sValue = IIf(cboCentroCustoFiltro.SelectedIndex = -1, "-", cboCentroCustoFiltro.Text)
            'Seta Paramentro - Agrupado Por
            goCrystalReport.sReportParameter(14).sParamenter = "@agrupado_por"
            goCrystalReport.sReportParameter(14).sValue = IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue)

            If (goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD") Then

                'Seta Paramentro - Tipo Documento
                goCrystalReport.sReportParameter(15).sParamenter = "@tipo_documento"
                goCrystalReport.sReportParameter(15).sValue = IIf(cboTipoDocumento.SelectedIndex = -1, "", cboTipoDocumento.SelectedValue)

            End If

            If (goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD") Then

                'Seta Paramentro - Movimentação
                goCrystalReport.sReportParameter(15).sParamenter = "@movimentacao"
                goCrystalReport.sReportParameter(15).sValue = chkMovimentacao.Checked

            End If

            If ((goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD") And (goUsuario.iEmpresa = 4)) Then

                'Seta Paramentro - Lavalpa
                goCrystalReport.sReportParameter(16).sParamenter = "@lavalpa"
                goCrystalReport.sReportParameter(16).sValue = IIf(chkParceiro.Checked = True, chkLavalpa.Checked, "NULL")
                'Seta Paramentro - LeSix
                goCrystalReport.sReportParameter(17).sParamenter = "@le_six"
                goCrystalReport.sReportParameter(17).sValue = IIf(chkParceiro.Checked = True, chkLeSix.Checked, "NULL")

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

End Class
