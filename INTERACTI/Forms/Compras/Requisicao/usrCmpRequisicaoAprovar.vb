Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrCmpRequisicaoAprovar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpRequisicaoAprovar As New clsUsrCmpRequisicaoAprovar

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCmpRequisicaoAprovar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigoItem" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                        Case "cboCentroGastoItem" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabilItem" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                        Case "txtQuantidadeItem" : Call btnQuantidadeAberto_Click(btnQuantidadeAberto, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigoItem" : If cboTipoItem.SelectedIndex = -1 Then frmMain.Informacao(Mensagem.OperacaoNaoRealizada) Else Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & cboTipoItem.SelectedValue)
                        Case "cboContaContabilItem" : Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                        Case "cboCentroGastoItem" : Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedidaItem" : Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCodigoItem" : Call btnCadastrarItem_Click(btnCadastrarItem, System.EventArgs.Empty)
                        Case "cboContaContabilItem" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabilItem, System.EventArgs.Empty)
                        Case "cboCentroGastoItem" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGastoItem, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaItem" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedidaItem, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCmpRequisicaoAprovar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: APROVAR / REPROVAR :::"

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
            oForm.NomeFormulario = Formulario.ComprasRequisicaoAprovar
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasRequisicaoAprovar)

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

    Private Sub btnQuantidadeAberto_Click(sender As Object, e As EventArgs) Handles btnQuantidadeAberto.Click

        Try

            'Verifica se foi Selecionado o Tipo do Item
            If cboCodigoItem.SelectedIndex = -1 Then Exit Sub

            'Váriavel - Formulário de Procurar Item
            Dim oForm As New frmCmpQuantidadeAberto

            'Seta Parametros
            oForm.CodigoItem = cboCodigoItem.SelectedValue
            
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Verifica se foi Selecionado o Tipo de Item
            If cboTipoItem.SelectedIndex = -1 Then Exit Sub

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = cboTipoItem.SelectedValue
            sItemCompraFind = "S"
            oComboBoxFind = cboCodigoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboCodigoItem.SelectedIndex = -1, -1, cboCodigoItem.SelectedValue)
            oComboBoxFind = cboCentroGastoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboCodigoItem.SelectedIndex = -1, -1, cboCodigoItem.SelectedValue)
            'Seta Parametros
            oComboBoxFind = cboContaContabilItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarItem.Click

        Try

            'Verifica se foi Selecionado o Tipo de Item
            If cboTipoItem.SelectedIndex = -1 Then Exit Sub

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = IIf(cboTipoItem.SelectedValue = CInt(TipoItem.produto), "usrCadProduto", "usrCadServico")
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & cboTipoItem.SelectedValue)

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilItem.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")
            
            'Carrega Combo
            If cboCodigoItem.SelectedIndex > -1 Then
                Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)
            End If

            'Seta Focu
            cboContaContabilItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoItem.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")
            
            'Carrega Combo
            If cboCodigoItem.SelectedIndex > -1 Then
                Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)
            End If

            'Seta Focu
            cboCentroGastoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaItem.Click

        Try

                       'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovar.Click

        Try

            'Verifica se foi Selecionado algum valor válido
            If VerificaSelecaoRowDiferente(grdListagem, "status", CInt(StatusRequisicaoComprasItem.Aprovado)) = True Then

                'Verifica se o Usuário deseja Aprovar a Requisição
                If MsgBox("Deseja Aprovar o(s) Item(s) da(s) Requisição(ões) de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Aprova Requisição
                    oClsCmpRequisicaoAprovar.AprovarRequisicao()

                    'Carrega Grid
                    Call LoadGrid()

                End If

            Else

                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & "Registros com STATUS de:" & vbCrLf & "    - AGUARDANDO APROVAÇÃO" & vbCrLf & "    - REPROVADO", MsgBoxStyle.Exclamation, Me.Parent.Text)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnReprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprovar.Click

        Try

            'Verifica se foi Selecionado algum valor válido
            If VerificaSelecaoRowDiferente(grdListagem, "status", CInt(StatusRequisicaoComprasItem.Reprovado)) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmCmpRequisicaoReprovar

                'Seta Parâmetros
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else

                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & "Registros com STATUS de:" & vbCrLf & "    - AGUARDANDO APROVAÇÃO" & vbCrLf & "    - APROVADO", MsgBoxStyle.Exclamation, Me.Parent.Text)

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

            End If

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
            txtNumeroRequisicaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 4
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoItem.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboTipoItem.SelectedIndex = -1 Then
                'Limpa Controle
                cboCodigoItem.SelectedIndex = -1 : cboCodigoItem.DataSource = Nothing : cboCodigoItem.Text = ""
                btnCadastrarItem.Enabled = False
            Else
                'Carrega Combo            
                Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & cboTipoItem.SelectedValue)

                'Habilita o Campo Marca se Necessário
                If cboTipoItem.SelectedValue = CInt(TipoItem.servico) Then
                    txtMarcaItem.Text = ""
                    txtMarcaItem.Enabled = False
                Else
                    txtMarcaItem.Enabled = True
                End If

                'Verifica Direito
                btnCadastrarItem.Enabled = VerificaDireito(IIf(cboTipoItem.SelectedValue = CInt(TipoItem.produto), Formulario.CadastroBasicoProduto, Formulario.CadastroBasicoServico), gcInsert)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoItem.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoItem.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricaoItem.Text = ""
                txtQuantidadeMinima.Value = 0
                txtMultiploCompra.Value = 0
                cboUnidadeMedidaItem.SelectedIndex = -1
                dtpDataNecessidadeItem.Value = Now.Date : dtpDataNecessidadeItem.Checked = False

            Else

                Dim oClsCmpRequisicao As New clsUsrCmpRequisicao

                'Carrega Dados do Produto
                Call oClsCmpRequisicao.LoadDadosItem(grdListagem.CurrentRow.Cells("codigo_requisicao").Value, _
                                                     grdListagem.CurrentRow.Cells("codigo").Value, _
                                                     cboCodigoItem, _
                                                     txtDescricaoItem, _
                                                     cboUnidadeMedidaItem, _
                                                     txtMarcaItem, _
                                                     txtQuantidadeMinima, _
                                                     txtMultiploCompra, _
                                                     dtpDataNecessidadeItem, _
                                                     txtQuantidadeAberto)

                'Carrega Combo
                Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)
                Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "arquivo" : Call ListaArquivo("tb_cmp_requisicao", grdListagem.CurrentRow.Cells("codigo_requisicao").Value)
                Case "historico" : Call Historico()

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
                                     Formulario.ComprasRequisicaoAprovar)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComprasRequisicaoAprovar, _
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
                                          Formulario.ComprasRequisicaoAprovar, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpRequisicaoAprovar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnReprovar.Enabled = VerificaDireito(Formulario.ComprasRequisicaoAprovar, gcAdministrator)
            btnAprovar.Enabled = VerificaDireito(Formulario.ComprasRequisicaoAprovar, gcAdministrator)
            btnSalvar.Enabled = VerificaDireito(Formulario.ComprasRequisicaoAprovar, gcUpdate)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasRequisicaoAprovar, gcPrint)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarContaContabilItem.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
            btnCadastrarCentroGastoItem.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarUnidadeMedidaItem.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

            'Carrega ComboBox        
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_requisicao_compras_aprovar")
            Call LoadCombo(cboRequisitanteFiltro, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoItem, "sp_select_combo_static_tipo_item")
            Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasRequisicaoAprovar)

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroRequisicaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: APROVAR / REPROVAR :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sRequisitante As String = ""
            Dim sStatus As String = ""
            Dim i As Integer

            'Requisitante
            If cboRequisitanteFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboRequisitanteFiltro.CheckedValues)
                    sRequisitante &= IIf(sRequisitante = "", "", ",") & cboRequisitanteFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsCmpRequisicaoAprovar.LoadGrid(grdListagem, _
                                              IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1), _
                                              sRequisitante, _
                                              IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value), _
                                              IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value), _
                                              txtItemFiltro.Text.Trim, _
                                              sStatus)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComprasRequisicaoAprovar, gcUpdate) = True Then

                'Carrega Controles
                oClsCmpRequisicaoAprovar.LoadControles(grdListagem.CurrentRow.Cells("codigo_requisicao").Value, _
                                                       grdListagem.CurrentRow.Cells("codigo").Value, _
                                                       txtNumeroRequisicao, _
                                                       txtAprovador, _
                                                       cboTipoItem, _
                                                       cboCodigoItem, _
                                                       txtComplementoItem, _
                                                       txtMarcaItem, _
                                                       cboContaContabilItem, _
                                                       cboCentroGastoItem, _
                                                       txtQuantidadeItem, _
                                                       cboUnidadeMedidaItem, _
                                                       dtpDataNecessidadeItem, _
                                                       txtJustificativaItem)

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboTipoItem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            'Váriaveis Locais
            Dim oForm As New frmCmpRequisicaoHistorico

            'Seta Parâmetros
            oForm.NumeroRequisicao = grdListagem.CurrentRow.Cells("numero_requisicao").Value
            oForm.Requisitante = grdListagem.CurrentRow.Cells("requisitante").Value
            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo_item").Value
            oForm.Descricao = grdListagem.CurrentRow.Cells("descricao").Value
            oForm.CodigoRequisicao = grdListagem.CurrentRow.Cells("codigo_requisicao").Value
            oForm.CodigoRequisicaoItem = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmpRequisicaoAprovar.CodigoRequisicao = grdListagem.CurrentRow.Cells("codigo_requisicao").Value
            oClsCmpRequisicaoAprovar.Codigo = grdListagem.CurrentRow.Cells("codigo").Value
            oClsCmpRequisicaoAprovar.CodigoItem = cboCodigoItem.SelectedValue
            oClsCmpRequisicaoAprovar.Descricao = LoadDescricao("sp_select_cadastro_basico_descricao_item " & cboCodigoItem.SelectedValue & ", " & goUsuario.iEmpresa)
            oClsCmpRequisicaoAprovar.Complemento = txtComplementoItem.Text.Trim
            oClsCmpRequisicaoAprovar.Marca = txtMarcaItem.Text.Trim
            oClsCmpRequisicaoAprovar.CodigoContaContabil = IIf(cboContaContabilItem.SelectedIndex = -1, "", cboContaContabilItem.SelectedValue)
            oClsCmpRequisicaoAprovar.CodigoCentroGasto = IIf(cboCentroGastoItem.SelectedIndex = -1, -1, cboCentroGastoItem.SelectedValue)
            oClsCmpRequisicaoAprovar.Quantidade = txtQuantidadeItem.Value
            oClsCmpRequisicaoAprovar.CodigoUnidadeMedida = cboUnidadeMedidaItem.SelectedValue
            oClsCmpRequisicaoAprovar.DataNecessidade = IIf(dtpDataNecessidadeItem.Checked = True, dtpDataNecessidadeItem.Value, "")
            oClsCmpRequisicaoAprovar.Justificativa = txtJustificativaItem.Text.Trim

            'Insere Registro
            oClsCmpRequisicaoAprovar.Update()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroAlterado)

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

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboCodigoItem, lblCodigoItem) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeItem, lblQuantidadeItem, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedidaItem.Enabled = True Then
                If ValidaCampo(cboUnidadeMedidaItem, lblUnidadeMedidaItem) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Data de Necessidade informada é válida
            If dtpDataNecessidadeItem.Checked = True Then
                If dtpDataNecessidadeItem.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataNecessidadeItem, "A Data de Necessidade não pode ser menor que o dia corrente.")
                    dtpDataNecessidadeItem.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoItem, lblCentroGastoItem) = False Then
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilItem, lblContaContabilItem) = False Then
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

#End Region

End Class


