Imports Janus.Windows.GridEX

Public Class usrVen000000014

    'Variáveis da Classe
    Private oClsVen000000014 As New clsUsrVen000000014

#Region "::: CONTROLES :::"

    Private Sub usrVenPedidoEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "txtProdutoFiltro" : Call btnProcurarProdutoFiltro_Click(btnProcurarProdutoFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrVen000000014_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

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
            oForm.NomeFormulario = Formulario.RelatorioVEN000000014
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioVEN000000014)

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

    Private Sub btnProcurarClienteFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oMaskedEditBoxFind = txtClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProdutoFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProdutoFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = "S"
            oMaskedEditBoxFind = txtProdutoFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtProdutoFiltro.Focus()

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioVEN000000014)

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
                                     Formulario.RelatorioVEN000000014, _
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
                                          Formulario.RelatorioVEN000000014, _
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

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVenPedidoEntrega_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioVEN000000014, gcPrint)

            'Carrega Combo
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_venda_pedido_item_entrega")
            cboEstoqueFiltro.Items.Clear()
            cboEstoqueFiltro.Items.Add("EM ESTOQUE", 1)
            cboEstoqueFiltro.Items.Add("EM TRÂNSITO", 2)
            cboEstoqueFiltro.Items.Add("EM ESTOQUE + TRÂNSITO", 3)
            cboEstoqueFiltro.Items.Add("SEM ESTOQUE E SEM TRÂNSITO", 4)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimer
            dtpDataPrevisaoEntregaInicioFiltro.Value = Now.Date : dtpDataPrevisaoEntregaInicioFiltro.Checked = False
            dtpDataPrevisaoEntregaTerminoFiltro.Value = Now.Date : dtpDataPrevisaoEntregaTerminoFiltro.Checked = False
            dtpDataEntregaInicioFiltro.Value = Now.Date : dtpDataEntregaInicioFiltro.Checked = False
            dtpDataEntregaTerminoFiltro.Value = Now.Date : dtpDataEntregaTerminoFiltro.Checked = False
            dtpDataAceiteInicioFiltro.Value = Now.Date : dtpDataAceiteInicioFiltro.Checked = False
            dtpDataAceiteTerminoFiltro.Value = Now.Date : dtpDataAceiteTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioVEN000000014)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()
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

            'Váriaveis Locais
            Dim sStatus As String = ""

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid
            Call oClsVen000000014.LoadGrid(grdListagem, _
                                           IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                           IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "", dtpDataPrevisaoEntregaInicioFiltro.Value), _
                                           IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "", dtpDataPrevisaoEntregaTerminoFiltro.Value), _
                                           txtClienteFiltro.Text.Trim, _
                                           txtProdutoFiltro.Text.Trim, _
                                           IIf(dtpDataEntregaInicioFiltro.Checked = False, "", dtpDataEntregaInicioFiltro.Value), _
                                           IIf(dtpDataEntregaTerminoFiltro.Checked = False, "", dtpDataEntregaTerminoFiltro.Value), _
                                           sStatus, _
                                           IIf(cboEstoqueFiltro.SelectedIndex = -1, -1, cboEstoqueFiltro.SelectedValue), _
                                           IIf(dtpDataAceiteInicioFiltro.Checked = False, "", dtpDataAceiteInicioFiltro.Value), _
                                           IIf(dtpDataAceiteTerminoFiltro.Checked = False, "", dtpDataAceiteTerminoFiltro.Value))


            'Carrega Gráfico
            Call oClsVen000000014.LoadGrafico(chrMain, _
                                              IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                              IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "", dtpDataPrevisaoEntregaInicioFiltro.Value), _
                                              IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "", dtpDataPrevisaoEntregaTerminoFiltro.Value), _
                                              txtClienteFiltro.Text.Trim, _
                                              txtProdutoFiltro.Text.Trim, _
                                              IIf(dtpDataEntregaInicioFiltro.Checked = False, "", dtpDataEntregaInicioFiltro.Value), _
                                              IIf(dtpDataEntregaTerminoFiltro.Checked = False, "", dtpDataEntregaTerminoFiltro.Value), _
                                              sStatus, _
                                              IIf(cboEstoqueFiltro.SelectedIndex = -1, -1, cboEstoqueFiltro.SelectedValue), _
                                              IIf(dtpDataAceiteInicioFiltro.Checked = False, "", dtpDataAceiteInicioFiltro.Value), _
                                              IIf(dtpDataAceiteTerminoFiltro.Checked = False, "", dtpDataAceiteTerminoFiltro.Value))

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
            'goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000010.rpt"

            ''Seta Paramentro - Nome
            'goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            'goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            ''Seta Paramentro - Empresa
            'goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            'goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            ''Seta Paramentro - Código Centro de Gasto
            'goCrystalReport.sReportParameter(2).sParamenter = "@codigo_centro_custo"
            'goCrystalReport.sReportParameter(2).sValue = sCodigoCentroCusto
            ''Seta Paramentro - Tipo
            ''Seta Paramentro - Data Emissão Início
            'goCrystalReport.sReportParameter(4).sParamenter = "@data_emissao_inicio"
            'goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            ''Seta Paramentro - Data Emissão Término
            'goCrystalReport.sReportParameter(5).sParamenter = "@data_emissao_termino"
            'goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            ''Seta Paramentro - Código Conta Contábil
            'goCrystalReport.sReportParameter(10).sParamenter = "centro_custo"
            'goCrystalReport.sReportParameter(10).sValue = sCentroCusto

            ''Abre Relatório
            'Dim oReport = New usrReport
            'oReport.Dock = DockStyle.Fill
            'frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
