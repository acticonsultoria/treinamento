Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFat000000012

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFat000000012 As New clsusrFat000000012

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFat000000012_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFat000000012_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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
            oForm.NomeFormulario = Formulario.RelatorioFAT000000012
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFAT000000012)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

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

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Visualizar Impressão
            Call VisualizarImpressao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCFOPFaturaFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCFOPFaturaFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboCFOPFaturaFiltro.SelectedIndex = -1 OrElse cboCFOPFaturaFiltro.SelectedValue = False Then
                Dim oClsCadCFOP As New clsUsrCadCFOP
                Call oClsCadCFOP.LoadTreeViewCFOPFaturamento(trvMainFiltro, False, "")
            Else
                Dim oClsCadCFOP As New clsUsrCadCFOP
                Call oClsCadCFOP.LoadTreeViewCFOPFaturamento(trvMainFiltro, True, "")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioFAT000000012)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioFAT000000012, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFat000000012_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboParceiroNegocioFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboCFOPFaturaFiltro)

            'Carrega TreeView CFOP
            Dim oClsCadCFOP As New clsUsrCadCFOP
            Call oClsCadCFOP.LoadTreeViewCFOPFaturamento(trvMainFiltro, False, "")

            'Carrega Combo - Agrupado
            cboAgrupadoPorFiltro.Items.Clear()
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO - DIA", "data_emissao_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO - SEMANA", "data_emissao_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO - MÊS", "data_emissao_mes")
            cboAgrupadoPorFiltro.Items.Add("MARCA", "marca")
            cboAgrupadoPorFiltro.Items.Add("PARCEIRO DE NEGÓCIO", "parceiro_negocio")
            cboAgrupadoPorFiltro.Items.Add("TIPO", "tipo")
            cboAgrupadoPorFiltro.Items.Add("VENDEDOR - EXTERNO", "vendedor_externo")
            cboAgrupadoPorFiltro.Items.Add("VENDEDOR - INTERNO", "vendedor_interno")

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False

            'Verifica Direito do Usuário
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioFAT000000012, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFAT000000012, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFAT000000012)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouser
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis
            Dim sCodigoCFOP As String = ""

            If VerificaSelecaoNode(trvMainFiltro) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCFOP &= IIf(sCodigoCFOP = "", "", ",") & oNode.Tag
                Next
            End If

            'Carrega Grid
            Call oClsFat000000012.LoadGrid(grdListagem, _
                                           IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text, -1), _
                                           IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                           IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                           IIf(cboParceiroNegocioFiltro.SelectedIndex = -1, -1, cboParceiroNegocioFiltro.SelectedValue), _
                                           sCodigoCFOP, _
                                           IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue))

            'Exclui Grupos
            If grdListagem.RootTable.Groups.Count > 0 Then
                grdListagem.RootTable.Groups.Remove(grdListagem.RootTable.Groups(0))
            End If

            'Agrupa Registr
            If cboAgrupadoPorFiltro.SelectedIndex > -1 Then
                grdListagem.AutomaticSort = False
                grdListagem.RootTable.Groups.Add(grdListagem.RootTable.Columns("agrupado"))
                grdListagem.RootTable.Columns("agrupado").DefaultGroupPrefix = ""
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(8)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000012.rpt"

            'Váriaveis
            Dim sCodigoCFOP As String = ""
            Dim sCFOP As String = ""

            If VerificaSelecaoNode(trvMainFiltro) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCFOP &= IIf(sCodigoCFOP = "", "", ",") & oNode.Tag
                    sCFOP &= IIf(sCFOP = "", "", ",") & oNode.Text
                Next
            End If

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(2).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(2).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(3).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Código Fornecedor
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboParceiroNegocioFiltro.SelectedIndex = -1, -1, cboParceiroNegocioFiltro.SelectedValue)
            'Seta Paramentro - Código CFOP
            goCrystalReport.sReportParameter(5).sParamenter = "@codigo_cfop"
            goCrystalReport.sReportParameter(5).sValue = sCodigoCFOP
            'Seta Paramentro - CFOP
            goCrystalReport.sReportParameter(6).sParamenter = "cfop"
            goCrystalReport.sReportParameter(6).sValue = sCFOP
            'Seta Paramentro - Nota Fiscal
            goCrystalReport.sReportParameter(7).sParamenter = "@nota_fiscal"
            goCrystalReport.sReportParameter(7).sValue = IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text, -1)
            'Seta Paramentro - Agrupado Por
            goCrystalReport.sReportParameter(8).sParamenter = "@agrupado"
            goCrystalReport.sReportParameter(8).sValue = IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue)

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


