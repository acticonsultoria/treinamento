Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrFat000000001

#Region "::: VÁRIAVEIS :::"

    'Váriaveis da Classe
    Private oClsFat000000001 As New clsUsrFat000000001

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFat000000001_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                        Call LoadGrid()
                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFat000000001_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFAT000000001
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFAT000000001)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

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
                                     Formulario.RelatorioFAT000000001)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioFAT000000001, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFat000000001_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioFAT000000001, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFAT000000001, gcPrint)
            Call LoadComboSimNao(cboCFOPFaturaFiltro)

            'Carrega TreeView CFOP
            Dim oClsCadCFOP As New clsUsrCadCFOP
            Call oClsCadCFOP.LoadTreeViewCFOPFaturamento(trvMainFiltro, False, "")

            'Carrega Combo
            Call LoadCombo(cboTipoMovimentacaoFiltro, "sp_select_combo_static_tipo_movimentacao_estoque")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFAT000000001)

            'Seta Focu
            dtpDataInicioFiltro.Focus()

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
            Dim sCodigoCFOP As String = ""

            If VerificaSelecaoNode(trvMainFiltro) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCFOP &= IIf(sCodigoCFOP = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Parametros
            Call oClsFat000000001.LoadGrid(grdListagem, _
                                           IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                           IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""), _
                                           IIf(cboTipoMovimentacaoFiltro.SelectedIndex = -1, "", cboTipoMovimentacaoFiltro.SelectedValue), _
                                           sCodigoCFOP)

            'Move para o Primeiro Registro
            grdListagem.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(5)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000001.rpt"

            'Váriaveis
            Dim sCodigoCFOP As String = ""

            If VerificaSelecaoNode(trvMainFiltro) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCFOP &= IIf(sCodigoCFOP = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Emitente
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_cfop"
            goCrystalReport.sReportParameter(2).sValue = sCodigoCFOP
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, "NULL")
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, "NULL")
            'Seta Paramentro - Status
            goCrystalReport.sReportParameter(5).sParamenter = "@codigo_tipo_movimentacao"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboTipoMovimentacaoFiltro.SelectedIndex = -1, "NULL", cboTipoMovimentacaoFiltro.SelectedValue)

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
