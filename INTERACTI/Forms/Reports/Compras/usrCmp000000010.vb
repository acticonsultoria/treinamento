Imports Janus.Windows.GridEX

Public Class usrCmp000000010

#Region "::: VÁRIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmp000000010 As New clsUsrCmp000000010

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCmp000000010_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCmp000000010_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        Case "txtDescricaoFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarProdutoFiltro, System.EventArgs.Empty)
                        Case "cboBitolaFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarBitolaFiltro, System.EventArgs.Empty)
                        Case "cboCorFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarCorFiltro, System.EventArgs.Empty)
                        Case "cboDiametroFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarDiametroFiltro, System.EventArgs.Empty)
                        Case "cboEspecialidadeFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarEspecialidadeFiltro, System.EventArgs.Empty)
                        Case "cboFormatoAgulhaFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarFormatoAgulhaFiltro, System.EventArgs.Empty)
                        Case "cboMarcaFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarMarcaFiltro, System.EventArgs.Empty)
                        Case "cboMaterialFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarMaterialFiltro, System.EventArgs.Empty)
                        Case "cboTamanhoAgulhaFiltro" : Call btnProcurarTabelaFiltro_Click(btnProcurarTamanhoAgulhaFiltro, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                        Case "cboMaterialFiltro" : Call LoadCombo(cboMaterialFiltro, "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa)
                        Case "cboDiametroFiltro" : Call LoadCombo(cboDiametroFiltro, "sp_select_combo_cadastro_basico_diametro_fio " & goUsuario.iEmpresa)
                        Case "cboTamanhoAgulhaFiltro" : Call LoadCombo(cboTamanhoAgulhaFiltro, "sp_select_combo_cadastro_basico_tamanho_agulha " & goUsuario.iEmpresa)
                        Case "cboFormatoAgulhaFiltro" : Call LoadCombo(cboFormatoAgulhaFiltro, "sp_select_combo_cadastro_basico_formato_agulha " & goUsuario.iEmpresa)
                        Case "cboBitolaFiltro" : Call LoadCombo(cboBitolaFiltro, "sp_select_combo_cadastro_basico_bitola " & goUsuario.iEmpresa)
                        Case "cboEspecialidadeFiltro" : Call LoadCombo(cboEspecialidadeFiltro, "sp_select_combo_cadastro_basico_especialidade " & goUsuario.iEmpresa)
                        Case "cboMarcaFiltro" : Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
                        Case "cboCorFiltro" : Call LoadCombo(cboCorFiltro, "sp_select_combo_cadastro_basico_cor_fio " & goUsuario.iEmpresa)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: RELATÓRIOS :::"

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProdutoFiltro.Click

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

    Private Sub btnProcurarTabelaFiltro_Click(sender As Object, e As EventArgs) Handles btnProcurarBitolaFiltro.Click, _
                                                                                        btnProcurarCorFiltro.Click, _
                                                                                        btnProcurarDiametroFiltro.Click, _
                                                                                        btnProcurarEspecialidadeFiltro.Click, _
                                                                                        btnProcurarFormatoAgulhaFiltro.Click, _
                                                                                        btnProcurarMarcaFiltro.Click, _
                                                                                        btnProcurarMaterialFiltro.Click, _
                                                                                        btnProcurarTamanhoAgulhaFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindTabela"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Registro"

            'Seta Parametros
            sFormularioFind = sender.Tag.ToString.Split("|")(1)
            sTabelaFind = sender.Tag.ToString.Split("|")(0)

            Select Case sender.name
                Case "btnProcurarBitolaFiltro" : oComboBoxFind = cboBitolaFiltro
                Case "btnProcurarCorFiltro" : oComboBoxFind = cboCorFiltro
                Case "btnProcurarDiametroFiltro" : oComboBoxFind = cboDiametroFiltro
                Case "btnProcurarEspecialidadeFiltro" : oComboBoxFind = cboEspecialidadeFiltro
                Case "btnProcurarFormatoAgulhaFiltro" : oComboBoxFind = cboFormatoAgulhaFiltro
                Case "btnProcurarMarcaFiltro" : oComboBoxFind = cboMarcaFiltro
                Case "btnProcurarMaterialFiltro" : oComboBoxFind = cboMaterialFiltro
                Case "btnProcurarTamanhoAgulhaFiltro" : oComboBoxFind = cboTamanhoAgulhaFiltro
            End Select

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Select Case sender.name
                Case "btnProcurarBitolaFiltro" : cboBitolaFiltro.Focus()
                Case "btnProcurarCorFiltro" : cboCorFiltro.Focus()
                Case "btnProcurarDiametroFiltro" : cboDiametroFiltro.Focus()
                Case "btnProcurarEspecialidadeFiltro" : cboEspecialidadeFiltro.Focus()
                Case "btnProcurarFormatoAgulhaFiltro" : cboFormatoAgulhaFiltro.Focus()
                Case "btnProcurarMarcaFiltro" : cboMarcaFiltro.Focus()
                Case "btnProcurarMaterialFiltro" : cboMaterialFiltro.Focus()
                Case "btnProcurarTamanhoAgulhaFiltro" : cboTamanhoAgulhaFiltro.Focus()
            End Select

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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioCMP000000010)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioCMP000000010, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO DE COMPRA :::"

    Private Sub btnPedidoCompra_Click(sender As Object, e As EventArgs) Handles btnPedidoCompra.Click

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            'Abre o Formulário
            Dim oForm As New frmCmp000000010Pedido
            oForm.ShowDialog(Me)

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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmp000000010_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            'Carrega Combo
            Call LoadCombo(cboRevisaoFiltro, "sp_select_combo_cadastro_basico_produto_preco_venda_revisao " & goUsuario.iEmpresa)
            If cboRevisaoFiltro.Items.Count > 0 Then cboRevisaoFiltro.SelectedIndex = 0
            Call LoadComboSimNao(cboConsiderarPedidoVendaFiltro)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboMaterialFiltro, "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa)
            Call LoadCombo(cboDiametroFiltro, "sp_select_combo_cadastro_basico_diametro_fio " & goUsuario.iEmpresa)
            Call LoadCombo(cboTamanhoAgulhaFiltro, "sp_select_combo_cadastro_basico_tamanho_agulha " & goUsuario.iEmpresa)
            Call LoadCombo(cboFormatoAgulhaFiltro, "sp_select_combo_cadastro_basico_formato_agulha " & goUsuario.iEmpresa)
            Call LoadCombo(cboBitolaFiltro, "sp_select_combo_cadastro_basico_bitola " & goUsuario.iEmpresa)
            Call LoadCombo(cboEspecialidadeFiltro, "sp_select_combo_cadastro_basico_especialidade " & goUsuario.iEmpresa)
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
            Call LoadCombo(cboCorFiltro, "sp_select_combo_cadastro_basico_cor_fio " & goUsuario.iEmpresa)
            Call LoadCombo(cboUnidadeMedidaFiltro, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioCMP000000010, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCMP000000010)

            'Seta Focu
            cboRevisaoFiltro.Focus()

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

            'Valida Campo - Revisão
            If ValidaCampo(cboRevisaoFiltro, lblRevisaoFiltro) = False Then
                Exit Sub
            End If

            'Valida Campo - x Estoque Mínimo
            If ValidaCampo(txtEstoqueMinimoFiltro, lblEstoqueMinimoFiltro, True) = False Then
                Exit Sub
            End If

            'Valida Campo - Considerar Pedido Venda
            If ValidaCampo(cboConsiderarPedidoVendaFiltro, lblConsiderarPedidoVendaFiltro) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmp000000010.LoadGrid(grdListagem, _
                                      txtEstoqueMinimoFiltro.Value, _
                                      cboConsiderarPedidoVendaFiltro.SelectedValue, _
                                      cboRevisaoFiltro.SelectedValue, _
                                      txtProdutoFiltro.Text.Trim, _
                                      IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                      IIf(cboMaterialFiltro.SelectedIndex = -1, -1, cboMaterialFiltro.SelectedValue), _
                                      IIf(cboDiametroFiltro.SelectedIndex = -1, -1, cboDiametroFiltro.SelectedValue), _
                                      IIf(cboTamanhoAgulhaFiltro.SelectedIndex = -1, -1, cboTamanhoAgulhaFiltro.SelectedValue), _
                                      IIf(cboFormatoAgulhaFiltro.SelectedIndex = -1, -1, cboFormatoAgulhaFiltro.SelectedValue), _
                                      IIf(cboBitolaFiltro.SelectedIndex = -1, -1, cboBitolaFiltro.SelectedValue), _
                                      IIf(cboEspecialidadeFiltro.SelectedIndex = -1, -1, cboEspecialidadeFiltro.SelectedValue), _
                                      IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                      IIf(cboCorFiltro.SelectedIndex = -1, -1, cboCorFiltro.SelectedValue), _
                                      IIf(cboUnidadeMedidaFiltro.SelectedIndex = -1, -1, cboUnidadeMedidaFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(25)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000010.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Política
            goCrystalReport.sReportParameter(1).sParamenter = "@politica"
            goCrystalReport.sReportParameter(1).sValue = txtEstoqueMinimoFiltro.Value
            'Seta Paramentro - Considerar Pedido de Venda
            goCrystalReport.sReportParameter(2).sParamenter = "@considerar_pedido_venda"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboConsiderarPedidoVendaFiltro.SelectedIndex = -1, "NULL", IIf(cboConsiderarPedidoVendaFiltro.SelectedValue = True, True, False))
            'Seta Paramentro - Revisão
            goCrystalReport.sReportParameter(3).sParamenter = "@revisao"
            goCrystalReport.sReportParameter(3).sValue = cboRevisaoFiltro.SelectedValue
            'Seta Paramentro - Produto
            goCrystalReport.sReportParameter(4).sParamenter = "@produto"
            goCrystalReport.sReportParameter(4).sValue = txtProdutoFiltro.Text.Trim
            'Seta Paramentro - Código Grupo de Item
            goCrystalReport.sReportParameter(5).sParamenter = "@codigo_grupo_item"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue)
            'Seta Paramentro - Código Material
            goCrystalReport.sReportParameter(6).sParamenter = "@codigo_material"
            goCrystalReport.sReportParameter(6).sValue = IIf(cboMaterialFiltro.SelectedIndex = -1, -1, cboMaterialFiltro.SelectedValue)
            'Seta Paramentro - Código Diâmetro
            goCrystalReport.sReportParameter(7).sParamenter = "@codigo_diametro"
            goCrystalReport.sReportParameter(7).sValue = IIf(cboDiametroFiltro.SelectedIndex = -1, -1, cboDiametroFiltro.SelectedValue)
            'Seta Paramentro - Código Tamanho da Agulha
            goCrystalReport.sReportParameter(8).sParamenter = "@codigo_tamanho_agulha"
            goCrystalReport.sReportParameter(8).sValue = IIf(cboTamanhoAgulhaFiltro.SelectedIndex = -1, -1, cboTamanhoAgulhaFiltro.SelectedValue)
            'Seta Paramentro - Código Formato Agulha
            goCrystalReport.sReportParameter(9).sParamenter = "@codigo_formato_agulha"
            goCrystalReport.sReportParameter(9).sValue = IIf(cboFormatoAgulhaFiltro.SelectedIndex = -1, -1, cboFormatoAgulhaFiltro.SelectedValue)
            'Seta Paramentro - Código Bitola
            goCrystalReport.sReportParameter(10).sParamenter = "@codigo_bitola"
            goCrystalReport.sReportParameter(10).sValue = IIf(cboBitolaFiltro.SelectedIndex = -1, -1, cboBitolaFiltro.SelectedValue)
            'Seta Paramentro - Código Especialidade
            goCrystalReport.sReportParameter(11).sParamenter = "@codigo_especialidade"
            goCrystalReport.sReportParameter(11).sValue = IIf(cboEspecialidadeFiltro.SelectedIndex = -1, -1, cboEspecialidadeFiltro.SelectedValue)
            'Seta Paramentro - Código Marca
            goCrystalReport.sReportParameter(12).sParamenter = "@codigo_marca"
            goCrystalReport.sReportParameter(12).sValue = IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue)
            'Seta Paramentro - Código Cor
            goCrystalReport.sReportParameter(13).sParamenter = "@codigo_cor"
            goCrystalReport.sReportParameter(13).sValue = IIf(cboCorFiltro.SelectedIndex = -1, -1, cboCorFiltro.SelectedValue)
            'Seta Paramentro - Código Empresa
            goCrystalReport.sReportParameter(14).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(14).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Usuário
            goCrystalReport.sReportParameter(15).sParamenter = "@codigo_usuario"
            goCrystalReport.sReportParameter(15).sValue = goUsuario.iUsuario
            'Seta Paramentro - Grupo de Item
            goCrystalReport.sReportParameter(16).sParamenter = "grupo_item"
            goCrystalReport.sReportParameter(16).sValue = IIf(cboGrupoItemFiltro.SelectedIndex = -1, "", cboGrupoItemFiltro.Text)
            'Seta Paramentro - Material
            goCrystalReport.sReportParameter(17).sParamenter = "material"
            goCrystalReport.sReportParameter(17).sValue = IIf(cboMaterialFiltro.SelectedIndex = -1, "", cboMaterialFiltro.Text)
            'Seta Paramentro - Diâmetro
            goCrystalReport.sReportParameter(18).sParamenter = "diametro"
            goCrystalReport.sReportParameter(18).sValue = IIf(cboDiametroFiltro.SelectedIndex = -1, "", cboDiametroFiltro.Text)
            'Seta Paramentro - Tamanho da Agulha
            goCrystalReport.sReportParameter(19).sParamenter = "tamanho_agulha"
            goCrystalReport.sReportParameter(19).sValue = IIf(cboTamanhoAgulhaFiltro.SelectedIndex = -1, "", cboTamanhoAgulhaFiltro.Text)
            'Seta Paramentro - Formato Agulha
            goCrystalReport.sReportParameter(20).sParamenter = "formato_agulha"
            goCrystalReport.sReportParameter(20).sValue = IIf(cboFormatoAgulhaFiltro.SelectedIndex = -1, "", cboFormatoAgulhaFiltro.Text)
            'Seta Paramentro - Bitola
            goCrystalReport.sReportParameter(21).sParamenter = "bitola"
            goCrystalReport.sReportParameter(21).sValue = IIf(cboBitolaFiltro.SelectedIndex = -1, "", cboBitolaFiltro.Text)
            'Seta Paramentro - Especialidade
            goCrystalReport.sReportParameter(22).sParamenter = "especialidade"
            goCrystalReport.sReportParameter(22).sValue = IIf(cboEspecialidadeFiltro.SelectedIndex = -1, "", cboEspecialidadeFiltro.Text)
            'Seta Paramentro - Marca
            goCrystalReport.sReportParameter(23).sParamenter = "marca"
            goCrystalReport.sReportParameter(23).sValue = IIf(cboMarcaFiltro.SelectedIndex = -1, "", cboMarcaFiltro.Text)
            'Seta Paramentro - Cor
            goCrystalReport.sReportParameter(24).sParamenter = "cor"
            goCrystalReport.sReportParameter(24).sValue = IIf(cboCorFiltro.SelectedIndex = -1, "", cboCorFiltro.Text)
            'Seta Paramentro - Considerar Pedido de Venda
            goCrystalReport.sReportParameter(25).sParamenter = "@codigo_unidade_medida"
            goCrystalReport.sReportParameter(25).sValue = IIf(cboUnidadeMedidaFiltro.SelectedIndex = -1, -1, cboUnidadeMedidaFiltro.SelectedValue)

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
