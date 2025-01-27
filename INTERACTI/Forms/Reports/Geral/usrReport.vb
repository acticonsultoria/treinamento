Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports Janus.Windows.UI.Tab

Public Class usrReport

#Region "::: VARIAVEIS :::"

    Private bPrint As Boolean = True
    Private bArquivo As Boolean = False
    Private sTabela As String
    Private lCodigo As Long
    Private iCodigo2 As Integer = -1
    Private iCodigo3 As Integer = -1
    Private oTabPage As UITabPage


#End Region

#Region "::: PROPERTIE :::"


    Public WriteOnly Property Print() As Boolean
        Set(ByVal value As Boolean)
            bPrint = value
        End Set
    End Property

    Public WriteOnly Property Arquivo() As Boolean
        Set(ByVal value As Boolean)
            bArquivo = value
        End Set
    End Property

    Public WriteOnly Property Tabela() As String
        Set(ByVal value As String)
            sTabela = value
        End Set
    End Property

    Public WriteOnly Property Codigo() As Long
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

    Public WriteOnly Property Codigo2() As Integer
        Set(ByVal value As Integer)
            iCodigo2 = value
        End Set
    End Property

    Public WriteOnly Property Codigo3() As Integer
        Set(ByVal value As Integer)
            iCodigo3 = value
        End Set
    End Property

    Public WriteOnly Property TabPage() As UITabPage
        Set(ByVal value As UITabPage)
            oTabPage = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub crvViewer_ClickPage(sender As Object, e As CrystalDecisions.Windows.Forms.PageMouseEventArgs) Handles crvViewer.ClickPage

        'MessageBox.Show(e.ObjectInfo.Name)

    End Sub

    Private Sub usrReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrReport_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

        rptDocument.Close()
        rptDocument.Dispose()
        rptDocument = Nothing


        If Not oTabPage Is Nothing Then frmMain.tabMain.SelectedTab = oTabPage

    End Sub

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = "ARQUIVO"
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, "ARQUIVO")

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : Call VisualizarDocumentoBD(grdArquivo.CurrentRow.Cells("arquivo").Value, grdArquivo.CurrentRow.Cells("extensao").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     "ARQUIVO")

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     "ARQUIVO", _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          "ARQUIVO", _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Verifica se existe Arquivo para o Relatório
            If bArquivo = False Then

                'Desabilita Arquivo
                grdArquivo.Visible = False
                btnConfigurarGridArquivo.Visible = False
                btnAgruparGridArquivo.Visible = False
                crvViewer.Dock = DockStyle.Fill

            Else

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, sTabela, lCodigo, iCodigo2, iCodigo3)

                'Verifica se foi Encontrado algum Registro
                If grdArquivo.GetDataRows.Count = 0 Then
                    'Desabilita Arquivo
                    grdArquivo.Visible = False
                    btnConfigurarGridArquivo.Visible = False
                    btnAgruparGridArquivo.Visible = False
                    crvViewer.Dock = DockStyle.Fill
                End If

            End If

            'For Each oControl As Control In crvViewer.Controls

            '    If TypeOf (oControl) Is System.Windows.Forms.ToolStrip Then

            '        'Evento - Imprimir
            '        Dim oToolStripItem As ToolStripItem = CType(oControl, ToolStrip).Items.Add("")
            '        oToolStripItem.ToolTipText = "Clique para Imprimir"
            '        oToolStripItem.Image = My.Resources.run
            '        AddHandler oToolStripItem.Click, AddressOf X

            '    End If

            'Next
            If Not System.IO.File.Exists(goCrystalReport.sReport) Then
                MsgBox("Report não existente!", MsgBoxStyle.Information, "Relatório")
                Exit Sub
            End If
            'Abre o Relatóri
            rptDocument.Load(goCrystalReport.sReport, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'Atualiza Relatório
            rptDocument.Refresh()

            'Desabilita o Cache
            rptDocument.ReportOptions.EnableSaveDataWithReport = False

            'Envia parametros para o Relatório
            For i As Integer = 0 To UBound(goCrystalReport.sReportParameter)
                If CStr(goCrystalReport.sReportParameter(i).sValue) = "NULL" Then
                    rptDocument.SetParameterValue(goCrystalReport.sReportParameter(i).sParamenter, DBNull.Value)
                Else
                    rptDocument.SetParameterValue(goCrystalReport.sReportParameter(i).sParamenter, goCrystalReport.sReportParameter(i).sValue)
                End If
            Next

            'Abre Conexão com o Banco de Dados        
            For i = 0 To rptDocument.DataSourceConnections.Count - 1
                rptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)

            Next i


         

                crvViewer.Show()
                crvViewer.ShowPrintButton = bPrint
                crvViewer.ReportSource = rptDocument

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub X()

        MsgBox("TESTE")

    End Sub
  
#End Region

End Class
