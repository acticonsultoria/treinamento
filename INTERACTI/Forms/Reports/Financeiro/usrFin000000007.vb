Imports Janus.Windows.GridEX

Public Class usrFin000000007

    'Variáveis da Classe
    Private oClsFin000000007 As New clsUsrFin000000007

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

    Private Sub usrFin000000007_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3
                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

                Case Keys.F5
                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
                        Case "cboSegmentoFiltro" : Call LoadCombo(cboSegmentoFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa, False)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFin000000007_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000007
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000007)

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

            'Valida Campo - Tipo de Data
            If ValidaCampo(cboTipoDataFiltro, lblTipoDataFiltro) = False Then
                Exit Sub
            End If

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

    Private Sub cboTipoDataFiltro_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTipoDataFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboTipoDataFiltro.SelectedIndex = -1 Then
                dtpDataInicioFiltro.Enabled = False
                dtpDataTerminoFiltro.Enabled = False
            Else
                dtpDataInicioFiltro.Enabled = True
                dtpDataTerminoFiltro.Enabled = True
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
                                     Formulario.RelatorioFIN000000007)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioFIN000000007, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000007_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadCombo(cboSegmentoFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    grpParceiro.Visible = True
                    chkLavalpa.Visible = True
                    chkLeSix.Visible = True

                    'grdListagem.RootTable.Columns.Add("parceiro")

                Else

                    grpParceiro.Visible = False
                    chkLavalpa.Visible = False
                    chkLeSix.Visible = False

                    grdListagem.RootTable.Columns.Remove("parceiro")

                End If

            Else

                grpParceiro.Visible = False
                chkLavalpa.Visible = False
                chkLeSix.Visible = False

                grdListagem.RootTable.Columns.Remove("parceiro")

            End If

            'Carrega Combo - Agrupado
            cboAgrupadoPorFiltro.Items.Clear()
            cboAgrupadoPorFiltro.Items.Add("SEGMENTO", "segmento")
            cboAgrupadoPorFiltro.Items.Add("DATA", "data")

            'Carrega Combo - Tipo
            cboTipoDataFiltro.Items.Clear()
            cboTipoDataFiltro.Items.Add("DATA EMISSÃO", "1")
            cboTipoDataFiltro.Items.Add("DATA PAGAMENTO", "3")
            cboTipoDataFiltro.Items.Add("DATA VENCIMENTO", "2")

            'Configura DateTimePicker
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = False : dtpDataInicioFiltro.Enabled = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False : dtpDataTerminoFiltro.Enabled = False

            'Verifica Direito
            btnExcelListagem.Enabled = VerificaDireito(Formulario.RelatorioFIN000000007, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000007, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000007)

            'Seta Focu
            cboSegmentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo - Tipo de Data
            If ValidaCampo(cboTipoDataFiltro, lblTipoDataFiltro) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then

                If goUsuario.iEmpresa = 4 Then

                    'Seta Parametros
                    oClsFin000000007.LoadGridLavalpa(grdListagem, _
                                              IIf(cboSegmentoFiltro.SelectedIndex = -1, -1, cboSegmentoFiltro.SelectedValue), _
                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                              IIf(cboTipoDataFiltro.SelectedIndex = -1, -1, cboTipoDataFiltro.SelectedValue), _
                                              IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
                                              IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""), _
                                              IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                               IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue), _
                                              IIf(chkParceiro.Checked = True, chkLavalpa.Checked, 2), _
                                              IIf(chkParceiro.Checked = True, chkLeSix.Checked, 2))

                Else

                    'Seta Parametros
                    oClsFin000000007.LoadGrid(grdListagem, _
                                              IIf(cboSegmentoFiltro.SelectedIndex = -1, -1, cboSegmentoFiltro.SelectedValue), _
                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                              IIf(cboTipoDataFiltro.SelectedIndex = -1, -1, cboTipoDataFiltro.SelectedValue), _
                                              IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
                                              IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""), _
                                              IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                               IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue))

                End If


            Else

                'Seta Parametros
                oClsFin000000007.LoadGrid(grdListagem, _
                                          IIf(cboSegmentoFiltro.SelectedIndex = -1, -1, cboSegmentoFiltro.SelectedValue), _
                                          IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                          IIf(cboTipoDataFiltro.SelectedIndex = -1, -1, cboTipoDataFiltro.SelectedValue), _
                                          IIf(dtpDataInicioFiltro.Enabled = True, dtpDataInicioFiltro.Value, ""), _
                                          IIf(dtpDataTerminoFiltro.Enabled = True, dtpDataTerminoFiltro.Value, ""), _
                                          IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue), _
                                           IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue))

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
                    ReDim goCrystalReport.sReportParameter(10)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000007_Lavalpa.rpt"

                Else

                    'Redimensiona Vetor
                    ReDim goCrystalReport.sReportParameter(8)
                    'Relatório
                    goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000007.rpt"

                End If

            Else

                'Redimensiona Vetor
                ReDim goCrystalReport.sReportParameter(8)
                'Relatório
                goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000007.rpt"

            End If

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Segmento
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_segmento"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboSegmentoFiltro.SelectedIndex = -1, -1, cboSegmentoFiltro.SelectedValue)
            'Seta Paramentro - Código Cliente
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_cliente"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue)
            'Seta Paramentro - Código Tipo
            goCrystalReport.sReportParameter(4).sParamenter = "@tipo"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboTipoDataFiltro.SelectedIndex = -1, -1, cboTipoDataFiltro.SelectedValue)
            'Seta Paramentro - Data Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(5).sValue = dtpDataInicioFiltro.Value
            'Seta Paramentro - Data Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(6).sValue = dtpDataTerminoFiltro.Value
            'Seta Paramentro - Agrupado Por
            goCrystalReport.sReportParameter(7).sParamenter = "@agrupado_por"
            goCrystalReport.sReportParameter(7).sValue = IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue)

            goCrystalReport.sReportParameter(8).sParamenter = "@codigo_centro_custo"
            goCrystalReport.sReportParameter(8).sValue = IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue)

            If ((goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD") And (goUsuario.iEmpresa = 4)) Then

                'Seta Paramentro - Lavalpa
                goCrystalReport.sReportParameter(9).sParamenter = "@lavalpa"
                goCrystalReport.sReportParameter(9).sValue = IIf(chkParceiro.Checked = True, chkLavalpa.Checked, "NULL")
                'Seta Paramentro - LeSix
                goCrystalReport.sReportParameter(10).sParamenter = "@le_six"
                goCrystalReport.sReportParameter(10).sValue = IIf(chkParceiro.Checked = True, chkLeSix.Checked, "NULL")

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
