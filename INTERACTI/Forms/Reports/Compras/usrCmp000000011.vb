Imports Janus.Windows.GridEX

Public Class usrCmp000000011

    'Variáveis da Classe
    Private oClsCmp000000011 As New clsUsrCmp000000011

#Region "::: CONTROLES :::"

    Private Sub usrCmp000000011_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCmp000000011_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioCMP000000011
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCMP000000011)

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

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagem)

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

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

    Private Sub cboMarcaFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarcaFiltro.SelectedIndexChanged

        Try

            'Carrega TreeView
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioCMP000000011)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioCMP000000011, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_AfterCheck(sender As Object, e As TreeViewEventArgs)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmp000000011_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboConsiderarPedidoVendaFiltro) : cboConsiderarPedidoVendaFiltro.SelectedValue = True

            'Verifica Direito
            btnExcel.Enabled = VerificaDireito(Formulario.RelatorioCMP000000011, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCMP000000011)

            'Carrega TreeView
            Call LoadTreeView()

            'Seta Focu
            cboMarcaFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadTreeView()

        Try

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Váriaveis Locais
            Dim oClsCadGrupoItem As New clsUsrCadGrupoItem

            oClsCadGrupoItem.LoadTreeViewMarca(trvMain, _
                                               IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue))


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo - Considerar Pedido Venda
            If ValidaCampo(cboConsiderarPedidoVendaFiltro, lblConsiderarPedidoVendaFiltro) = False Then
                Exit Sub
            End If

            'Váriaveis Locais
            Dim sCodigoGrupoItem As String = ""

            'Verifica se foi Selecionado o Registro
            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoGrupoItem &= IIf(sCodigoGrupoItem = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmp000000011.LoadGrid(grdListagem, _
                                      IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                      sCodigoGrupoItem, _
                                      cboConsiderarPedidoVendaFiltro.SelectedValue, _
                                      txtValorFiltro.Value)

            'Seta Posição da Grid
            grdListagem.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Váriaveis Locais
            Dim sCodigoGrupoItem As String = ""

            'Verifica se foi Selecionado o Registro
            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoGrupoItem &= IIf(sCodigoGrupoItem = "", "", ",") & oNode.Tag
                Next
            End If

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(7)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000011.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Marca
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_marca"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue)
            'Seta Paramentro - Grupo de Item
            goCrystalReport.sReportParameter(3).sParamenter = "@grupo_item"
            goCrystalReport.sReportParameter(3).sValue = sCodigoGrupoItem
            'Seta Paramentro - Política
            goCrystalReport.sReportParameter(4).sParamenter = "@valor"
            goCrystalReport.sReportParameter(4).sValue = txtValorFiltro.Value
            'Seta Paramentro - Considerar Pedido de Venda
            goCrystalReport.sReportParameter(5).sParamenter = "@considerar_pedido_venda"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboConsiderarPedidoVendaFiltro.SelectedIndex = -1, "NULL", IIf(cboConsiderarPedidoVendaFiltro.SelectedValue = True, True, False))
            'Seta Paramentro - Código Usuário
            goCrystalReport.sReportParameter(6).sParamenter = "@codigo_usuario"
            goCrystalReport.sReportParameter(6).sValue = goUsuario.iUsuario
            'Seta Paramentro - Usuário
            goCrystalReport.sReportParameter(7).sParamenter = "usuario"
            goCrystalReport.sReportParameter(7).sValue = goUsuario.sUsuario

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
