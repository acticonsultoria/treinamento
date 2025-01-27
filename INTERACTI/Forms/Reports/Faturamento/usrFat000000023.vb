Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrFat000000023

#Region "::: VÁRIAVEIS :::"

    'Váriaveis da Classe
    Private oClsFat000000023 As New clsUsrFat000000023

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFat000000023_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

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
            oForm.NomeFormulario = Formulario.RelatorioFAT000000023
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFAT000000023)

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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioFAT000000023)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioFAT000000023, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.RelatorioFAT000000023, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Controles
            dtpDataInicio.Value = Now.Date : dtpDataInicio.Checked = False
            dtpDataTermino.Value = Now.Date : dtpDataTermino.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFAT000000023)

            Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa, False)
            'Call LoadCombo(cboTipoDocumentoFiscal, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)

            'Verifica Direito 
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioFAT000000023, gcPrint)

            'Seta Focu
            txtNotaFiscal.Focus()

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
             
            'Seta Parametros
            Call oClsFat000000023.LoadGrid(grdListagem, _
                                           txtNotaFiscal.Text, _
                                           IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                           IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""), _
                                           IIf(cboParceiroNegocio.SelectedIndex = -1, -1, cboParceiroNegocio.SelectedValue), _
                                           txtCodigoItem.Text, _
                                           IIf(cboTipoDocumentoFiscal.SelectedIndex = -1, -1, cboTipoDocumentoFiscal.SelectedIndex), _
                                           chkExibirCancelada.Checked, _
                                           chkSomenteFatura.Checked)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try
             
            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(6)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000023.rpt"
             
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Parceiro Negócio
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(1).sValue = IIf(cboParceiroNegocio.SelectedIndex = -1, -1, cboParceiroNegocio.SelectedValue)
            'Seta Paramentro - Data Início
            goCrystalReport.sReportParameter(2).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(2).sValue = IIf(dtpDataInicio.Checked = False, "NULL", dtpDataInicio.Value)
            'Seta Paramentro - Data Término
            goCrystalReport.sReportParameter(3).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataTermino.Checked = False, "NULL", dtpDataTermino.Value)
            'Seta Paramentro - Código Tipo de Documento Fiscal
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_tipo_documento_fiscal"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboTipoDocumentoFiscal.SelectedIndex = -1, -1, cboTipoDocumentoFiscal.SelectedIndex)
            'Seta Paramentro - Nota Fiscal
            goCrystalReport.sReportParameter(5).sParamenter = "@nota_fiscal"
            goCrystalReport.sReportParameter(5).sValue = txtNotaFiscal.Text
            'Seta Paramentro - Nota Fiscal
            goCrystalReport.sReportParameter(6).sParamenter = "@codigo_item"
            goCrystalReport.sReportParameter(6).sValue = txtCodigoItem.Text
             
            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill

            frmMain.LoadPageReport(goCrystalReport.sReport, "Relatório de Faturamento", oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
