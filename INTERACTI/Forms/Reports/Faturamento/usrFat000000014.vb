Imports Janus.Windows.GridEX

Public Class usrFat000000014

    'Variáveis da Classe
    Private oClsFat000000014 As New clsUsrFat000000014

#Region "::: CONTROLES :::"

    Private Sub usrFat000000014_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

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

            'Configura DateTimePicker
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFAT000000014)

            'Carrega TreeView
            Call LoadTreeView()

            'Seta Focu
            dtpDataEmissaoInicioFiltro.Focus()

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
            Dim sCodigoGrupoItem As String = ""

            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoGrupoItem &= IIf(sCodigoGrupoItem = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Parametros
            oClsFat000000014.LoadGrid(grdListagem, _
                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                      sCodigoGrupoItem)

            'Seta Parametros
            oClsFat000000014.LoadGrafico(chrMain, _
                                         IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                         IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                         sCodigoGrupoItem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(10)

            'Váriaveis
            Dim sCodigoCentroCusto As String = ""
            Dim sCentroCusto As String = ""

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000010.rpt"

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
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(4).sParamenter = "@data_emissao_inicio"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(5).sParamenter = "@data_emissao_termino"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Código Conta Contábil
            goCrystalReport.sReportParameter(10).sParamenter = "centro_custo"
            goCrystalReport.sReportParameter(10).sValue = sCentroCusto

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

            Dim oClsCadGrupoItem As New clsUsrCadGrupoItem

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            oClsCadGrupoItem.LoadTreeViewChecked(trvMain, txtGrupoItemTreeFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
