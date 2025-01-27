Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class usrFatEntradaRelatorioCFOP

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEntradaRelatorioCFOP As New clsUsrFatEntradaRelatorioCFOP
    Private iCodigoFormulario As Integer = Formulario.FaturamentoEntradaRelatorioCFOP

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrVenRegraComissaoFormula_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrVenRegraComissaoFormula_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnAgruparGridAnalitico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridAnalitico.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagemAnalitico.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagemAnalitico.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagemAnalitico.GroupByBoxVisible = True
                grdListagemAnalitico.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridAnalitico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridAnalitico.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemAnalitico
            oForm.NomeFormulario = iCodigoFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemAnalitico, iCodigoFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridSintetico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridSintetico.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagemAnalitico.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagemAnalitico.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagemAnalitico.GroupByBoxVisible = True
                grdListagemAnalitico.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridSintetico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridSintetico.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemAnalitico
            oForm.NomeFormulario = iCodigoFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemAnalitico, iCodigoFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            If tabDados.SelectedTab.Text = "Analítico" Then
                Call ExportExcel(grdListagemAnalitico)
            Else
                Call ExportExcel(grdListagemSintetico)
            End If

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

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Try

            'Imprimir
            Call Imprimir()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemAnalitico, _
                                     iCodigoFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemAnalitico.Name, _
                                     iCodigoFormulario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagemAnalitico.Name, _
                                          iCodigoFormulario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemAnalitico_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagemAnalitico.RowDoubleClick
        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdListagemAnalitico.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagemAnalitico.CurrentColumn.Key

                Case "movimentar_estoque" : Call AtualizarMovimentacao(grdListagemAnalitico.CurrentRow.Cells("codigo_entrada_capa").Value, True)
                Case "nao_movimentar_estoque" : Call AtualizarMovimentacao(grdListagemAnalitico.CurrentRow.Cells("codigo_entrada_capa").Value, False)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica Direito
            btnExcel.Enabled = VerificaDireito(iCodigoFormulario, gcPrint)


            Call LoadCombo(cboTipoDocumento, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)



            'Configura Grid
            Call ConfiguraGrid(grdListagemAnalitico, iCodigoFormulario)
            Call ConfiguraGrid(grdListagemSintetico, iCodigoFormulario)

            dtpDataInicioFiltro.Checked = False : dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Date.Now)
            dtpDataTerminoFiltro.Checked = False : dtpDataTerminoFiltro.Value = Date.Now

            'Seta Focu
            dtpDataInicioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Imprimir()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(iCodigoFormulario, gcPrint) = False Then
                'Informa o Usuário que ele não tem direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sReport As String = "VEN000000017.rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("VEN000000017", "Regra de Comissionamento", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

           


            'Seta Parametros
            Call oClsFatEntradaRelatorioCFOP.LoadGrid(grdListagemAnalitico, _
                                                      grdListagemSintetico, _
                                                      IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                                      IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                                      IIf(cboTipoDocumento.SelectedIndex = -1, -1, cboTipoDocumento.SelectedValue))


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarMovimentacao(ByVal lCodigoCapa As Long, _
                                      ByVal bMovimentarEstoque As Boolean)
        Try

            If grdListagemAnalitico.CurrentRow.Cells("cfop").Value = "1201" Or grdListagemAnalitico.CurrentRow.Cells("cfop").Value = "1410" Or grdListagemAnalitico.CurrentRow.Cells("cfop").Value = "2201" Then

                oClsFatEntradaRelatorioCFOP.AtualizarMovimentacao(lCodigoCapa, _
                                                                  bMovimentarEstoque)

                LoadGrid()

            Else

                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "É necessário ser referente a um CFOP de devolução para alterar a movimentação.")

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
