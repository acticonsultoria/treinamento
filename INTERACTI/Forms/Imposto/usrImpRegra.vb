Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrImpRegra

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsImpRegra As New clsUsrImpRegra

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrImpRegra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3
                    Select Case sender.name
                        Case "cboNCM" : Call btnHistoricoNCM_Click(btnHistoricoNCM, System.EventArgs.Empty)
                        Case "cboParceiroNegocio" : Call btnProcurarParceiro_Click(btnProcurarParceiro, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                    End Select

                Case Keys.F5
                    Select Case sender.name
                        Case "cboNCM" : Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
                        Case "cboParceiroNegocio" : Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
                        Case "cboDeposito" : Call cboTipoRegra_SelectedIndexChanged(cboTipoRegra, System.EventArgs.Empty)
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto)
                    End Select

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboParceiroNegocio" : Call btnCadastrarParceiroNegocio_Click(btnCadastrarParceiroNegocio, System.EventArgs.Empty)
                        Case "cboCFOP" : Call btnCadastrarCFOP_Click(btnCadastrarCFOP, System.EventArgs.Empty)
                        Case "cboNCM" : Call btnCadastrarNCM_Click(btnCadastrarNCM, System.EventArgs.Empty)
                        Case "cboDeposito" : Call btnCadastrarDeposito_Click(btnCadastrarDeposito, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrImpRegra_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            oForm.NomeFormulario = Formulario.ImpostoRegra
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoRegra)

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

    Private Sub btnCadastrarCFOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCFOP.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCFOP")

            'Carrega Combo
            Call cboTipoRegra_SelectedIndexChanged(cboTipoRegra, System.EventArgs.Empty)

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarParceiroNegocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarParceiroNegocio.Click

        Try

             'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboParceiroNegocio : oComboBox(1) = cboParceiroNegocioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarParceiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarParceiro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = -1
            oComboBoxFind = cboParceiroNegocio

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboParceiroNegocio.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros            
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = ""
            sItemAtivoFixoFind = ""
            sItemEstoqueFind = ""
            sItemCompraFind = ""
            sItemProducaoFind = ""
            bInserirProdutoFind = True
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarNCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarNCM.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadNCM")

            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboNCMFiltro : oComboBox(1) = cboNCM
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

            'Seta Focu
            cboNCM.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDeposito.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDeposito")

            'Carrega Combo - Depósito
            Call cboTipoRegra_SelectedIndexChanged(cboTipoRegra, System.EventArgs.Empty)

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnHistoricoNCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoricoNCM.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - NCM
            If ValidaCampo(cboNCM, lblNCM) = False Then
                Exit Sub
            End If

            'Abre Formulário
            Dim oForm As New frmImpRegraHistoricoNCM
            oForm.CodigoNCM = cboNCM.SelectedValue
            oForm.NCM = cboNCM.Text
            oForm.ComboBoxCFOP = cboCFOP
            oForm.ComboBoxCST = cboSituacaoTributariaICMS
            oForm.NumericEditBoxAliquotaICMS = txtAliquotaICMS
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

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

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Seleciona Aba
                tabDados.SelectedTab = pagDadosImposto
                'Salva Dados do Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            cboTipoRegraFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 3
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTipoRegra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoRegra.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboTipoRegra.SelectedIndex = -1 Then
                cboNCM.Enabled = True
                cboOrigemItem.Enabled = True
                grpII.Enabled = True
                cboDestinacao.Enabled = True
                Exit Sub
            End If

            'Torna Visivel Controles
            grpICMS.Visible = True
            grpIPI.Visible = True
            grpPIS.Visible = True
            grpCOFINS.Visible = True
            grpII.Visible = True

            'Verifica se foi Selecionado Algum Registro
            Select Case cboTipoRegra.SelectedValue

                Case CInt(TipoRegraImposto.DevolucaoNotaFiscalEntradaImposto)
                    cboNCM.Enabled = True
                    cboOrigemItem.Enabled = True
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    cboDestinacao.Enabled = True
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
                    Call LoadCombo(cboDestinacao, "sp_select_combo_static_destinacao_remessa")
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))
                Case CInt(TipoRegraImposto.Venda)
                    cboNCM.Enabled = True
                    cboOrigemItem.Enabled = True
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    cboDestinacao.Enabled = True
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))
                Case CInt(TipoRegraImposto.RemessaConsignado)
                    cboNCM.Enabled = True
                    cboOrigemItem.Enabled = True
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    cboDestinacao.Enabled = True
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))
                Case CInt(TipoRegraImposto.Remessa)
                    cboNCM.Enabled = True
                    cboOrigemItem.Enabled = True
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    cboDestinacao.Enabled = True
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))
                Case CInt(TipoRegraImposto.Importacao)
                    cboNCM.Enabled = True
                    cboOrigemItem.Enabled = True
                    grpII.Enabled = True
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_importacao " & goUsuario.iEmpresa)
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Entrada))
                Case CInt(TipoRegraImposto.RemessaIndustrializacao)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))
                Case CInt(TipoRegraImposto.RetornoMaterialIndustrializado)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))
                Case CInt(TipoRegraImposto.DevolucaoNotaFiscalEmitida)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'E'")
                    grpICMS.Visible = False
                    grpIPI.Visible = False
                    grpPIS.Visible = False
                    grpCOFINS.Visible = False
                    grpII.Visible = False
                Case CInt(TipoRegraImposto.DevolucaoNotaFiscalEntrada)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'S'")
                    grpICMS.Visible = False
                    grpIPI.Visible = False
                    grpPIS.Visible = False
                    grpCOFINS.Visible = False
                    grpII.Visible = False
                Case CInt(TipoRegraImposto.RetornoSimbolicoConsignado)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'E'")
                    grpICMS.Visible = False
                    grpIPI.Visible = False
                    grpPIS.Visible = False
                    grpCOFINS.Visible = False
                    grpII.Visible = False
                Case CInt(TipoRegraImposto.DevoluvaoConsignado)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'E'")
                    grpICMS.Visible = False
                    grpIPI.Visible = False
                    grpPIS.Visible = False
                    grpCOFINS.Visible = False
                    grpII.Visible = False
                Case CInt(TipoRegraImposto.RetornoDemonstracao), CInt(TipoRegraImposto.RetornoLocacao), CInt(TipoRegraImposto.RetornoComodato), CInt(TipoRegraImposto.RetornoLocacao), CInt(TipoRegraImposto.RetornoComodato), CInt(TipoRegraImposto.RetornoAmostra), CInt(TipoRegraImposto.RetornoBonificacao), CInt(TipoRegraImposto.RetornoSimplesRemessa)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'E'")
                    grpICMS.Visible = False
                    grpIPI.Visible = False
                    grpPIS.Visible = False
                    grpCOFINS.Visible = False
                    grpII.Visible = False
                Case CInt(TipoRegraImposto.RetornoConcerto)
                    cboNCM.SelectedIndex = -1 : cboNCM.Enabled = False
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    cboOrigemItem.SelectedIndex = -1 : cboOrigemItem.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'S'")
                    grpICMS.Visible = False
                    grpIPI.Visible = False
                    grpPIS.Visible = False
                    grpCOFINS.Visible = False
                    grpII.Visible = False
                Case CInt(TipoRegraImposto.RemessaComodato)
                    cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'S'")
                    Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))
                Case 20
                    'cboDestinacao.SelectedIndex = -1 : cboDestinacao.Enabled = False
                    'grpII.Enabled = False : txtAliquotaII.Value = 0
                    Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'E'")
                    ' Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi " & CInt(TipoDocumentoFiscal.Saida))

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCFOP.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim iTipoMovimentacaoEstoque As Integer

            'Verificando se foi selecionado algum registro
            If sender.SelectedIndex = -1 Then
                txtNaturezaOperacao.Text = ""
                cboDeposito.Text = ""
                cboDeposito.Enabled = False
                btnCadastrarDeposito.Enabled = False
            Else
                'Carrega Controle
                Call LoadDescricao(txtNaturezaOperacao, "sp_select_cadastro_basico_natureza_operacao_cfop " & sender.SelectedValue & ", " & goUsuario.iEmpresa)
                iTipoMovimentacaoEstoque = LoadCodigo("sp_select_cadastro_basico_cfop_tipo_movimentacao_estoque " & sender.SelectedValue & ", " & goUsuario.iEmpresa)

                'Verifica se o Tipo de Movimentação é Transferência
                If iTipoMovimentacaoEstoque = TipoMovimentacaoEstoqueCFOP.TransferenciaDeposito Then
                    cboDeposito.Enabled = True
                    Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_proprio " & goUsuario.iEmpresa)
                    btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)
                Else
                    cboDeposito.Enabled = False
                    cboDeposito.Text = ""
                    btnCadastrarDeposito.Enabled = False
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaICMS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacaoTributariaICMS.SelectedIndexChanged

        Try

            'Limpa / Desabilita Controles
            cboModalidadeBCICMS.SelectedIndex = -1 : cboModalidadeBCICMS.Enabled = False
            cboModalidadeBCICMSST.SelectedIndex = -1 : cboModalidadeBCICMSST.Enabled = False
            txtIVA.Value = 0 : txtIVA.Enabled = False
            txtIVA.Value = 0 : txtIVA.Enabled = False
            txtAliquotaICMS.Value = 0 : txtAliquotaICMS.Enabled = False
            txtAliquotaICMSST.Value = 0 : txtAliquotaICMSST.Enabled = False
            txtPercentualReducaoBCICMS.Value = 0 : txtPercentualReducaoBCICMS.Enabled = False
            txtPercentualReducaoBCICMSST.Value = 0 : txtPercentualReducaoBCICMSST.Enabled = False

            'Verifica se foi Selecionado alguma Situação Tributária do ICMS
            If cboSituacaoTributariaICMS.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaICMS.SelectedValue

                    Case "00"
                        cboModalidadeBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True

                    Case "10"
                        cboModalidadeBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        cboModalidadeBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtPercentualReducaoBCICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "20"
                        cboModalidadeBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        txtPercentualReducaoBCICMS.Enabled = True

                    Case "30"
                        cboModalidadeBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtPercentualReducaoBCICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "40", "41", "50"

                    Case "51"
                        cboModalidadeBCICMS.Enabled = True
                        txtPercentualReducaoBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True

                    Case "60"

                    Case "70"
                        cboModalidadeBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        txtPercentualReducaoBCICMS.Enabled = True
                        cboModalidadeBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtPercentualReducaoBCICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "90"
                        cboModalidadeBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        txtPercentualReducaoBCICMS.Enabled = True
                        cboModalidadeBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtPercentualReducaoBCICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "101"

                    Case "102"

                    Case "201"
                        cboModalidadeBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtPercentualReducaoBCICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "202", "203"
                        cboModalidadeBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtPercentualReducaoBCICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                    Case "500"

                    Case "900"
                        cboModalidadeBCICMS.Enabled = True
                        txtAliquotaICMS.Enabled = True
                        txtPercentualReducaoBCICMS.Enabled = True
                        cboModalidadeBCICMSST.Enabled = True
                        txtIVA.Enabled = True
                        txtPercentualReducaoBCICMSST.Enabled = True
                        txtAliquotaICMSST.Enabled = True

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaPIS_SelectedIndexChanged() Handles cboSituacaoTributariaPIS.SelectedIndexChanged

        Try

            'Desabilita / Limpa Controles            
            txtAliquotaPIS.Enabled = False : txtAliquotaPIS.Value = 0
            txtAliquotaPISValor.Enabled = False : txtAliquotaPISValor.Value = 0

            'Verifica se foi Selecionado algum Registro
            If cboSituacaoTributariaPIS.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaPIS.SelectedValue

                    Case modDeclaration.SituacaoTributariaPIS._01, _
                         modDeclaration.SituacaoTributariaPIS._02, _
                         modDeclaration.SituacaoTributariaPIS._70
                        txtAliquotaPIS.Enabled = True
                        Call LoadValor(txtAliquotaPIS, "sp_select_static_pis_aliquota '" & cboSituacaoTributariaPIS.SelectedValue & "'")

                    Case modDeclaration.SituacaoTributariaPIS._03
                        txtAliquotaPISValor.Enabled = True
                        Call LoadValor(txtAliquotaPIS, "sp_select_static_pis_aliquota '" & cboSituacaoTributariaPIS.SelectedValue & "'")

                    Case modDeclaration.SituacaoTributariaPIS._99
                        txtAliquotaPIS.Enabled = True
                        txtAliquotaPISValor.Enabled = True
                        Call LoadValor(txtAliquotaPIS, "sp_select_static_pis_aliquota '" & cboSituacaoTributariaPIS.SelectedValue & "'")

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaCOFINS_SelectedIndexChanged() Handles cboSituacaoTributariaCOFINS.SelectedIndexChanged

        Try

            'Desabilita / Limpa Controles            
            txtAliquotaCOFINS.Enabled = False : txtAliquotaCOFINS.Value = 0
            txtAliquotaCOFINSValor.Enabled = False : txtAliquotaCOFINSValor.Value = 0

            'Verifica se foi Selecionado algum Registro
            If cboSituacaoTributariaCOFINS.SelectedIndex <> -1 Then

                Select Case cboSituacaoTributariaCOFINS.SelectedValue

                    Case modDeclaration.SituacaoTributariaCOFINS._01, _
                         modDeclaration.SituacaoTributariaCOFINS._02, _
                          modDeclaration.SituacaoTributariaCOFINS._70
                        txtAliquotaCOFINS.Enabled = True
                        Call LoadValor(txtAliquotaCOFINS, "sp_select_static_cofins_aliquota '" & cboSituacaoTributariaCOFINS.SelectedValue & "'")

                    Case modDeclaration.SituacaoTributariaCOFINS._03
                        txtAliquotaCOFINSValor.Enabled = True
                        Call LoadValor(txtAliquotaCOFINS, "sp_select_static_cofins_aliquota '" & cboSituacaoTributariaCOFINS.SelectedValue & "'")

                    Case modDeclaration.SituacaoTributariaCOFINS._99
                        txtAliquotaCOFINS.Enabled = True
                        txtAliquotaCOFINSValor.Enabled = True
                        Call LoadValor(txtAliquotaCOFINS, "sp_select_static_cofins_aliquota '" & cboSituacaoTributariaCOFINS.SelectedValue & "'")

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaIPI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacaoTributariaIPI.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboSituacaoTributariaIPI.SelectedIndex = -1 Then

                'Desabilita / Limpa Controles            
                cboTipoCalculoIPI.Enabled = False : cboTipoCalculoIPI.SelectedIndex = -1
                txtAliquotaIPI.Enabled = False : txtAliquotaIPI.Value = 0


            ElseIf cboSituacaoTributariaIPI.SelectedValue = "00" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "49" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "50" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "99" Then

                'Habilita Controle
                cboTipoCalculoIPI.Enabled = True
                chkInserirIPIOutras.Checked = False : chkInserirIPIOutras.Enabled = False


            
            Else


                'Desabilita / Limpa Controles            
                cboTipoCalculoIPI.Enabled = False : cboTipoCalculoIPI.SelectedIndex = -1
                txtAliquotaIPI.Enabled = False : txtAliquotaIPI.Value = 0

                chkInserirIPIOutras.Enabled = True
            End If
            If cboSituacaoTributariaIPI.SelectedIndex = -1 Then
                Call LoadCombo(cboCodigoEnquadramento, "sp_select_combo_static_classe_enquadramento_ipi ''")
            Else
                If cboSituacaoTributariaIPI.SelectedValue = "04" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "05" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "02" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "01" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "54" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "55" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "52" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "51" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "49" Or _
                   cboSituacaoTributariaIPI.SelectedValue = "59" Then
                    Call LoadCombo(cboCodigoEnquadramento, "sp_select_combo_static_classe_enquadramento_ipi '" & cboSituacaoTributariaIPI.SelectedValue & "'")
                    cboCodigoEnquadramento.Enabled = True
                Else
                    cboCodigoEnquadramento.Enabled = False
                    cboCodigoEnquadramento.SelectedIndex = -1
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTipoCalculoIPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCalculoIPI.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboTipoCalculoIPI.SelectedIndex = -1 Then

                'Desabilida Controles
                txtAliquotaIPI.Enabled = False : txtAliquotaIPI.Value = 0 : txtAliquotaIPI.DecimalDigits = 2
                lblAliquotaIPI.Text = "Alíquota:"

            ElseIf cboTipoCalculoIPI.SelectedValue = CInt(TipoCalculoImposto.Percentual) Then

                'Habilita Controle
                txtAliquotaIPI.Enabled = True : txtAliquotaIPI.DecimalDigits = 2
                lblAliquotaIPI.Text = "Alíquota (%):"
                If cboNCM.SelectedIndex <> -1 Then
                    LoadValor(txtAliquotaIPI, "sp_select_cadastro_basico_ncm_aliquota_ipi '" & cboNCM.SelectedValue & "', " & goUsuario.iEmpresa)
                End If
                
            ElseIf cboTipoCalculoIPI.SelectedValue = CInt(TipoCalculoImposto.Valor) Then

                'Habilita Controle
                txtAliquotaIPI.Enabled = True : txtAliquotaIPI.DecimalDigits = 4
                lblAliquotaIPI.Text = "Alíquota (R$):"

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboParceiroNegocio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboParceiroNegocio.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Parceiro de Negócio
            If cboParceiroNegocio.SelectedIndex = -1 Then
                cboPersonalidade.Enabled = True
                cboUFDestino.Enabled = True
                cboOrigemItem.Enabled = True
            Else
                cboPersonalidade.Enabled = False : cboPersonalidade.SelectedIndex = -1
                cboUFDestino.Enabled = False : cboUFDestino.SelectedIndex = -1
                cboOrigemItem.Enabled = False : cboOrigemItem.SelectedIndex = -1
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Parceiro de Negócio
            If cboProduto.SelectedIndex = -1 Then
                cboOrigemItem.Enabled = True
                cboNCM.Enabled = True
            Else
                cboOrigemItem.Enabled = False : cboOrigemItem.Text = ""
                cboNCM.Enabled = False : cboNCM.Text = ""
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsDBNull(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "duplicar" : Call Duplicar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ImpostoRegra)

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
                                     Formulario.ImpostoRegra, _
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
                                          Formulario.ImpostoRegra, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrImpRegra_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ImpostoRegra, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.ImpostoRegra, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.ImpostoRegra, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ImpostoRegra, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarParceiroNegocio.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarCFOP.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcInsert)
            btnCadastrarNCM.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcInsert)
            btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)

            'Carrega ComboBox
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboTipoRegraFiltro : oComboBox(1) = cboTipoRegra
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_regra_imposto")
            oComboBox(0) = cboCFOPFiltro : oComboBox(1) = cboCFOP
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cfop_saida " & goUsuario.iEmpresa)
            Call LoadCombo(cboNCMFiltro, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            oComboBox(0) = cboPersonalidadeFiltro : oComboBox(1) = cboPersonalidade
            Call LoadCombo(oComboBox, "sp_select_combo_static_personalidade")
            oComboBox(0) = cboDestinacaoFiltro : oComboBox(1) = cboDestinacao
            Call LoadCombo(oComboBox, "sp_select_combo_static_destinacao")
            Call LoadCombo(cboUFDestinoFiltro, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFDestino, "sp_select_combo_static_estado")
            oComboBox(0) = cboOrigemItemFiltro : oComboBox(1) = cboOrigemItem
            Call LoadCombo(oComboBox, "sp_select_combo_static_origem_item")
            Call LoadCombo(cboDepositoFiltro, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            oComboBox(0) = cboParceiroNegocioFiltro : oComboBox(1) = cboParceiroNegocio
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            'Carrega Dados do Emitente
            Call LoadDadosEmitente()
            If goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroPresumido) Or goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroReal) Then
                Call LoadCombo(cboSituacaoTributariaICMS, "sp_select_combo_static_situacao_tributaria_icms")
            Else
                Call LoadCombo(cboSituacaoTributariaICMS, "sp_select_combo_static_situacao_tributaria_icms_simples")
            End If
            Call LoadCombo(cboModalidadeBCICMS, "sp_select_combo_static_modalidade_base_calculo_icms")
            Call LoadCombo(cboModalidadeBCICMSST, "sp_select_combo_static_modalidade_base_calculo_icms_st")
            Call LoadCombo(cboSituacaoTributariaPIS, "sp_select_combo_static_situacao_tributaria_pis")
            Call LoadCombo(cboSituacaoTributariaCOFINS, "sp_select_combo_static_situacao_tributaria_cofins")
            Call LoadCombo(cboSituacaoTributariaIPI, "sp_select_combo_static_situacao_tributaria_ipi_todos")
            Call LoadCombo(cboTipoCalculoIPI, "sp_select_combo_static_tipo_calculo_imposto")
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Veirifica se o Parceiro de Negócio está habilitado
            Dim bParceiroNegocioRegra As Boolean = CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'imposto_regra_por_cliente'"), Boolean)
            cboParceiroNegocioFiltro.Visible = bParceiroNegocioRegra : lblParceiroNegocioFiltro.Visible = bParceiroNegocioRegra : btnProcurarParceiro.Visible = bParceiroNegocioRegra
            cboParceiroNegocio.Visible = bParceiroNegocioRegra : lblParceiroNegocio.Visible = bParceiroNegocioRegra : btnCadastrarParceiroNegocio.Visible = bParceiroNegocioRegra
            grdListagem.RootTable.Columns("parceiro_negocio").Visible = bParceiroNegocioRegra
            grdListagem.RootTable.Columns("parceiro_negocio").Tag = IIf(bParceiroNegocioRegra = False, "N", "S")

            'Verifica se o Produto está habilidado
            Dim bProduto As Boolean = CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'imposto_regra_por_produto'"), Boolean)
            cboProduto.Visible = bProduto : lblProduto.Visible = bProduto : btnProcurarProduto.Visible = bProduto
            grdListagem.RootTable.Columns("produto").Visible = bProduto
            grdListagem.RootTable.Columns("produto").Tag = IIf(bProduto = False, "N", "S")

            'Verifica se tem o Parceiro de Negócio
            If bProduto = True And bParceiroNegocioRegra = False Then
                cboProduto.Left = cboParceiroNegocio.Left
                btnProcurarProduto.Left = cboProduto.Left + cboProduto.Width - btnProcurarProduto.Width
                lblProduto.Left = cboProduto.Left
            End If

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboTipoRegraFiltro.Focus()

            'Verifica a Tag
            If Me.Tag = "NOVO" Then
                Call btnNovo1_Click(btnNovo1, System.EventArgs.Empty)
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoRegra)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ImpostoRegra, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                Call oClsImpRegra.LoadControles(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                cboTipoRegra, _
                                                cboParceiroNegocio, _
                                                cboProduto, _
                                                cboCFOP, _
                                                cboNCM, _
                                                cboPersonalidade, _
                                                cboDestinacao, _
                                                cboUFDestino, _
                                                cboOrigemItem, _
                                                cboDeposito, _
                                                cboSituacaoTributariaICMS, _
                                                cboModalidadeBCICMS, _
                                                cboModalidadeBCICMSST, _
                                                txtIVA, _
                                                txtAliquotaICMS, _
                                                txtAliquotaICMSST, _
                                                txtPercentualReducaoBCICMS, _
                                                txtPercentualReducaoBCICMSST, _
                                                cboSituacaoTributariaPIS, _
                                                txtAliquotaPIS, _
                                                txtAliquotaPISValor, _
                                                cboSituacaoTributariaCOFINS, _
                                                txtAliquotaCOFINS, _
                                                txtAliquotaCOFINSValor, _
                                                cboSituacaoTributariaIPI, _
                                                cboTipoCalculoIPI, _
                                                txtAliquotaIPI, _
                                                txtAliquotaII, _
                                                txtDadosAdicionaisProduto, _
                                                txtDadosAdicionaisNotaFiscal, _
                                                chkInserirIPIOutras, _
                                                cboCodigoEnquadramento, _
                                                txtPercentualFCP, _
                                                txtAliquotaInterestadual)

                'Seta Código
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboTipoRegra.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Duplicar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ImpostoRegra, gcInsert) = True Then

                'Carrega Controles
                Call oClsImpRegra.LoadControles(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                cboTipoRegra, _
                                                cboParceiroNegocio, _
                                                cboProduto, _
                                                cboCFOP, _
                                                cboNCM, _
                                                cboPersonalidade, _
                                                cboDestinacao, _
                                                cboUFDestino, _
                                                cboOrigemItem, _
                                                cboDeposito, _
                                                cboSituacaoTributariaICMS, _
                                                cboModalidadeBCICMS, _
                                                cboModalidadeBCICMSST, _
                                                txtIVA, _
                                                txtAliquotaICMS, _
                                                txtAliquotaICMSST, _
                                                txtPercentualReducaoBCICMS, _
                                                txtPercentualReducaoBCICMSST, _
                                                cboSituacaoTributariaPIS, _
                                                txtAliquotaPIS, _
                                                txtAliquotaPISValor, _
                                                cboSituacaoTributariaCOFINS, _
                                                txtAliquotaCOFINS, _
                                                txtAliquotaCOFINSValor, _
                                                cboSituacaoTributariaIPI, _
                                                cboTipoCalculoIPI, _
                                                txtAliquotaIPI, _
                                                txtAliquotaII, _
                                                txtDadosAdicionaisProduto, _
                                                txtDadosAdicionaisNotaFiscal, _
                                                chkInserirIPIOutras, _
                                                cboCodigoEnquadramento, _
                                                txtPercentualFCP, _
                                                txtAliquotaInterestadual)

                'Seta Código
                btnSalvar.Tag = ""

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboTipoRegra.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se o Usuário deseja Excluir o Registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsImpRegra.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboTipoRegra.SelectedIndex = -1
            cboTipoRegra.Text = ""
            cboParceiroNegocio.SelectedIndex = -1
            cboProduto.Text = ""
            cboCFOP.SelectedIndex = -1
            cboNCM.SelectedIndex = -1
            cboPersonalidade.SelectedIndex = -1
            cboDestinacao.SelectedIndex = -1
            cboUFDestino.SelectedIndex = -1
            cboOrigemItem.SelectedIndex = -1
            cboDeposito.SelectedIndex = -1
            cboSituacaoTributariaICMS.SelectedIndex = -1
            cboModalidadeBCICMS.SelectedIndex = -1
            cboModalidadeBCICMSST.SelectedIndex = -1
            txtIVA.Value = 0
            txtAliquotaICMS.Value = 0
            txtAliquotaICMSST.Value = 0
            txtPercentualReducaoBCICMS.Value = 0
            txtPercentualReducaoBCICMSST.Value = 0
            cboSituacaoTributariaPIS.SelectedIndex = -1
            txtAliquotaPIS.Value = 0
            txtAliquotaPISValor.Value = 0
            cboSituacaoTributariaCOFINS.SelectedIndex = -1
            txtAliquotaCOFINS.Value = 0
            txtAliquotaCOFINSValor.Value = 0
            cboSituacaoTributariaIPI.SelectedIndex = -1
            txtAliquotaIPI.Value = 0
            txtAliquotaIPI.Value = 0
            txtAliquotaII.Value = 0
            txtDadosAdicionaisProduto.Text = ""
            txtDadosAdicionaisNotaFiscal.Text = ""
            btnSalvar.Tag = ""
            cboCodigoEnquadramento.SelectedIndex = -1
            txtAliquotaInterestadual.Value = 0
            txtPercentualFCP.Value = 0
            cboCodigoEnquadramento.SelectedIndex = -1

            'Seta Aba
            tabDados.SelectedTab = pagDadosImposto

            'Seta Focu
            cboTipoRegra.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsImpRegra.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsImpRegra.CodigoTipoRegra = cboTipoRegra.SelectedValue
            oClsImpRegra.CodigoParceiroNegocio = IIf(cboParceiroNegocio.SelectedIndex = -1, -1, cboParceiroNegocio.SelectedValue)
            oClsImpRegra.CodigoProduto = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oClsImpRegra.CodigoCFOP = cboCFOP.SelectedValue
            oClsImpRegra.CodigoNCM = IIf(cboNCM.SelectedIndex = -1, -1, cboNCM.SelectedValue)
            oClsImpRegra.CodigoPersonalidade = IIf(cboPersonalidade.SelectedIndex = -1, -1, cboPersonalidade.SelectedValue)
            oClsImpRegra.CodigoDestinacao = IIf(cboDestinacao.SelectedIndex = -1, -1, cboDestinacao.SelectedValue)
            oClsImpRegra.UFDestino = IIf(cboUFDestino.SelectedIndex = -1, "", cboUFDestino.SelectedValue)
            oClsImpRegra.CodigoOrigemItem = IIf(cboOrigemItem.SelectedIndex = -1, -1, cboOrigemItem.SelectedValue)
            oClsImpRegra.CodigoDeposito = IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue)
            oClsImpRegra.SituacaoTributariaICMS = IIf(grpICMS.Visible = True, cboSituacaoTributariaICMS.SelectedValue, "")
            oClsImpRegra.ModalidadeBaseCalculoICMS = IIf(grpICMS.Visible = True AndAlso cboModalidadeBCICMS.SelectedIndex <> -1, cboModalidadeBCICMS.SelectedValue, -1)
            oClsImpRegra.ModalidadeBaseCalculoICMSST = IIf(grpICMS.Visible = True AndAlso cboModalidadeBCICMSST.SelectedIndex <> -1, cboModalidadeBCICMSST.SelectedValue, -1)
            oClsImpRegra.IVA = IIf(grpICMS.Visible = True, IIf(txtIVA.Enabled = True, txtIVA.Value, -1), -1)
            oClsImpRegra.AliquotaICMS = IIf(grpICMS.Visible = True, IIf(txtAliquotaICMS.Enabled = True, txtAliquotaICMS.Value, -1), -1)
            oClsImpRegra.AliquotaICMSST = IIf(grpICMS.Visible = True, IIf(txtAliquotaICMSST.Enabled = True, txtAliquotaICMSST.Value, -1), -1)
            oClsImpRegra.PercentualReducaoBCICMS = IIf(grpICMS.Visible = True, IIf(txtPercentualReducaoBCICMS.Enabled = True, txtPercentualReducaoBCICMS.Value, -1), -1)
            oClsImpRegra.PercentualReducaoBCICMSST = IIf(grpICMS.Visible = True, IIf(txtPercentualReducaoBCICMSST.Enabled = True, txtPercentualReducaoBCICMSST.Value, -1), -1)
            oClsImpRegra.SituacaoTributariaPIS = IIf(grpPIS.Visible = True, cboSituacaoTributariaPIS.SelectedValue, "")
            oClsImpRegra.AliquotaPIS = IIf(grpPIS.Visible = True, IIf(txtAliquotaPIS.Enabled = True, txtAliquotaPIS.Value, -1), -1)
            oClsImpRegra.AliquotaValorPIS = IIf(grpPIS.Visible = True, IIf(txtAliquotaPISValor.Enabled = True, txtAliquotaPISValor.Value, -1), -1)
            oClsImpRegra.SituacaoTributariaCOFINS = IIf(grpCOFINS.Visible = True, cboSituacaoTributariaCOFINS.SelectedValue, "")
            oClsImpRegra.AliquotaCOFINS = IIf(grpCOFINS.Visible = True, IIf(txtAliquotaCOFINS.Enabled = True, txtAliquotaCOFINS.Value, -1), -1)
            oClsImpRegra.AliquotaValorCOFINS = IIf(grpCOFINS.Visible = True, IIf(txtAliquotaCOFINSValor.Enabled = True, txtAliquotaCOFINSValor.Value, -1), -1)
            oClsImpRegra.SituacaoTributariaIPI = IIf(grpIPI.Visible = True, cboSituacaoTributariaIPI.SelectedValue, "")
            oClsImpRegra.CodigoTipoCalculoIPI = IIf(grpIPI.Visible = True AndAlso cboTipoCalculoIPI.SelectedIndex <> -1, cboTipoCalculoIPI.SelectedValue, -1)
            oClsImpRegra.AliquotaIPI = IIf(grpIPI.Visible = True AndAlso oClsImpRegra.CodigoTipoCalculoIPI <> -1, IIf(oClsImpRegra.CodigoTipoCalculoIPI = CInt(TipoCalculoImposto.Percentual), txtAliquotaIPI.Value, -1), -1)
            oClsImpRegra.AliquotaValorIPI = IIf(grpIPI.Visible = True AndAlso oClsImpRegra.CodigoTipoCalculoIPI <> -1, IIf(oClsImpRegra.CodigoTipoCalculoIPI = CInt(TipoCalculoImposto.Valor), txtAliquotaIPI.Value, -1), -1)
            oClsImpRegra.AliquotaII = IIf(grpIPI.Visible = True, IIf(txtAliquotaII.Enabled = True, txtAliquotaII.Value, -1), -1)
            oClsImpRegra.MensagemDadosAdicionaisNotaFiscal = txtDadosAdicionaisNotaFiscal.Text.Trim
            oClsImpRegra.MensagemDadosAdicionaisProduto = txtDadosAdicionaisProduto.Text.Trim
            oClsImpRegra.InserirIPIOutras = chkInserirIPIOutras.Checked
            oClsImpRegra.CodigoEnquadramentoIPI = cboCodigoEnquadramento.SelectedValue
            oClsImpRegra.AliquotaInterestadual = txtAliquotaInterestadual.Value
            oClsImpRegra.PercentualFCP = txtPercentualFCP.Value

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsImpRegra.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsImpRegra.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

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
            oClsImpRegra.LoadGrid(grdListagem, _
                                  IIf(cboTipoRegraFiltro.SelectedIndex = -1, -1, cboTipoRegraFiltro.SelectedValue), _
                                  IIf(cboCFOPFiltro.SelectedIndex = -1, -1, cboCFOPFiltro.SelectedValue), _
                                  IIf(cboNCMFiltro.SelectedIndex = -1, -1, cboNCMFiltro.SelectedValue), _
                                  IIf(cboPersonalidadeFiltro.SelectedIndex = -1, -1, cboPersonalidadeFiltro.SelectedValue), _
                                  IIf(cboDestinacaoFiltro.SelectedIndex = -1, -1, cboDestinacaoFiltro.SelectedValue), _
                                  IIf(cboUFDestinoFiltro.SelectedIndex = -1, "", cboUFDestinoFiltro.SelectedValue), _
                                  IIf(cboOrigemItemFiltro.SelectedIndex = -1, -1, cboOrigemItemFiltro.SelectedValue), _
                                  IIf(cboParceiroNegocioFiltro.SelectedIndex = -1, -1, cboParceiroNegocioFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - CFOP
            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - NCM
            If cboNCM.Enabled = True Then
                If ValidaCampo(cboNCM, lblNCM) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Personalidade
            If cboPersonalidade.Enabled = True Then
                If ValidaCampo(cboPersonalidade, lblPersonalidade) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Destinação
            If cboDestinacao.Enabled = True Then
                If ValidaCampo(cboDestinacao, lblDestinacao) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - UF de Destino
            If cboUFDestino.Enabled = True Then
                If ValidaCampo(cboUFDestino, lblUFDestino) = False Then
                    Exit Function
                End If
            End If

            Dim sUF As String
            If cboParceiroNegocio.SelectedIndex = -1 Then
                sUF = cboUFDestino.SelectedValue
            Else
                sUF = LoadDescricao("sp_select_cadastro_basico_parceiro_negocio_uf " & cboParceiroNegocio.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

            'Verifica se o CFOP é Válido
            If (cboCFOP.Text.Substring(0, 1) = "5" Or cboCFOP.Text.Substring(0, 1) = "1") And sUF <> goUsuario.sUF Then
                frmMain.errInfo.SetError(lblCFOP, "Este CFOP não é válida para a UF " & sUF & ".")
                cboCFOP.Focus()
                Exit Function
            ElseIf (cboCFOP.Text.Substring(0, 1) = "6" Or cboCFOP.Text.Substring(0, 1) = "2") And sUF = goUsuario.sUF Then
                frmMain.errInfo.SetError(lblCFOP, "Este CFOP não é válida para a UF " & sUF & ".")
                cboCFOP.Focus()
                Exit Function
            ElseIf (cboCFOP.Text.Substring(0, 1) = "7" Or cboCFOP.Text.Substring(0, 1) = "3") And sUF <> "EX" Then
                frmMain.errInfo.SetError(lblCFOP, "Este CFOP não é válida para a UF " & sUF & ".")
                cboCFOP.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Origem do Produto
            If cboOrigemItem.Enabled = True Then
                If ValidaCampo(cboOrigemItem, lblOrigemItem) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Depósito
            If cboDeposito.Enabled = True Then
                If ValidaCampo(cboDeposito, lblDeposito) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Regra é Válida
            If oClsImpRegra.Validacao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                      cboTipoRegra.SelectedValue, _
                                      IIf(cboParceiroNegocio.SelectedIndex = -1, -1, cboParceiroNegocio.SelectedValue), _
                                      IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue), _
                                      cboCFOP.SelectedValue, _
                                      IIf(cboNCM.SelectedIndex = -1, -1, cboNCM.SelectedValue), _
                                      IIf(cboPersonalidade.SelectedIndex = -1, -1, cboPersonalidade.SelectedValue), _
                                      IIf(cboDestinacao.SelectedIndex = -1, -1, cboDestinacao.SelectedValue), _
                                      IIf(cboUFDestino.SelectedIndex = -1, "", cboUFDestino.SelectedValue), _
                                      IIf(cboOrigemItem.SelectedIndex = -1, -1, cboOrigemItem.SelectedValue), _
                                      IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue)) = False Then
                frmMain.errInfo.SetError(lblTipoRegra, "Esta Regra já está associado a outro Registro.")
                cboCFOP.Focus()
                Exit Function
            End If

            If grpICMS.Visible = True Then

                'Verifica se foi Selecionado o Campo - Situação Tributária ICMS
                If ValidaCampo(cboSituacaoTributariaICMS, lblSituacaoTributariaICMS) = False Then
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Modalidade Base Calculo ICMS
                If cboModalidadeBCICMS.Enabled = True Then
                    If ValidaCampo(cboModalidadeBCICMS, lblModalidadeBCICMS) = False Then
                        Exit Function
                    End If
                End If

                ''Verifica se foi Selecionado o Campo - Modalidade Base Calculo ICMS ST
                'If cboModalidadeBCICMSST.Enabled = True Then
                '    If ValidaCampo(cboModalidadeBCICMSST, lblModalidadeBCICMSST) = False Then
                '        Exit Function
                '    End If
                'End If

                ''Verifica se foi Preenchido o Campo - IVA
                'If txtIVA.Enabled = True Then
                '    If ValidaCampo(txtIVA, lblIVA, False) = False Then
                '        Exit Function
                '    End If
                'End If

                'Verifica se foi Preenchido o Campo - Alíquota ICMS
                'If txtAliquotaICMS.Enabled = True Then
                '    If ValidaCampo(txtAliquotaICMS, lblAliquotaICMS, True) = False Then
                '        Exit Function
                '    End If
                'End If

                'Verifica se foi Preenchido o Campo - Alíquota ICMS ST
                'If txtAliquotaICMSST.Enabled = True Then
                '    If ValidaCampo(txtAliquotaICMSST, lblAliquotaICMSST, True) = False Then
                '        Exit Function
                '    End If
                'End If

                ''Verifica se foi Preenchido o Campo - % Redução BC ICMS
                'If txtPercentualReducaoBCICMS.Enabled = True Then
                '    If ValidaCampo(txtPercentualReducaoBCICMS, lblPercentualReducaoBCICMS, True) = False Then
                '        Exit Function
                '    End If
                'End If

            End If


            If grpPIS.Visible = True Then

                'Verifica se foi Selecionado o Campo - Situação Tributária PIS
                If ValidaCampo(cboSituacaoTributariaPIS, lblSituacaoTributariaPIS) = False Then
                    Exit Function
                End If

            End If

            If grpCOFINS.Visible = True Then

                'Verifica se foi Selecionado o Campo - Situação Tributária COFINS
                If ValidaCampo(cboSituacaoTributariaCOFINS, lblSituacaoTributariaCOFINS) = False Then
                    Exit Function
                End If

            End If

            If grpIPI.Visible = True And goUsuario.iCodigoTipoEmpresa = CInt(TipoEmpresa.Industria) Then

                'Verifica se foi Selecionado o Campo - Situação Tributária IPI
                If ValidaCampo(cboSituacaoTributariaIPI, lblSituacaoTributariaIPI) = False Then
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Código Tipo Cálculo IPI
                If cboTipoCalculoIPI.Enabled = True Then
                    If ValidaCampo(cboTipoCalculoIPI, lblTipoCalculoIPI) = False Then
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Alíquota IPI
                If txtAliquotaIPI.Enabled = True And (cboSituacaoTributariaIPI.SelectedValue <> "99" And cboSituacaoTributariaIPI.SelectedValue <> "49") Then
                    If ValidaCampo(txtAliquotaIPI, lblAliquotaIPI, True) = False Then
                        Exit Function
                    End If
                End If

            End If
            If cboCodigoEnquadramento.Enabled = True Then
                If ValidaCampo(cboCodigoEnquadramento, lblCodigoEnquadramento) = False Then
                    Exit Function
                End If
            End If

            If txtAliquotaInterestadual.Enabled = True Then
                If ValidaCampo(txtAliquotaInterestadual, lblAliquotaInterestadualICMS, TipoCampo.numero) = False Then
                    Exit Function
                End If
            End If

            If txtPercentualFCP.Enabled = True Then
                If ValidaCampo(txtPercentualFCP, lblPercentualFCPICMS, TipoCampo.numero) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Sub btnCadastrarDestinacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDestinacao.Click
        Try
            btnCadastrarDestinacao.Enabled = VerificaDireito(Formulario.CadastroBasicoDestinacao, gcInsert)
            If btnCadastrarDestinacao.Enabled = False Then Exit Sub
            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadDestinacao")

            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboDestinacao : oComboBox(1) = cboDestinacao
            Call LoadCombo(oComboBox, "sp_select_combo_static_destinacao")


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFDestino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUFDestino.SelectedIndexChanged
        Try
            If cboUFDestino.SelectedIndex = -1 Or cboUFDestino.SelectedValue = "SP" Then
                txtAliquotaInterestadual.Enabled = False
                txtPercentualFCP.Enabled = False
            Else
                txtAliquotaInterestadual.Enabled = True
                txtPercentualFCP.Enabled = True
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
