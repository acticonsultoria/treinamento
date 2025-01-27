Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrCadCadernoServico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadServico As New clsUsrCadServico
    Private lCodigoServico As Long
    Private lCodigoServicoCopy As Long = -1

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadCadernoServico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        Case "cboItemComposicao" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Váriaveis Locais
                    Dim oComboBox(1) As UIComboBox

                    Select Case sender.name
                        Case "cboGrupoItem" : Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
                        Case "cboEspecie" : Call LoadCombo(cboEspecie, "sp_select_combo_cadastro_basico_especie_insumo " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboGrupoItem" : Call btnCadastrarGrupoItem_Click(btnCadastrarGrupoItem, System.EventArgs.Empty)
                        Case "cboEspecie" : Call btnCadastrarEspecie_Click(btnCadastrarEspecie, System.EventArgs.Empty)
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadCadernoServico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoCadernoServico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCadernoServico)

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

    Private Sub btnCadastrarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItem.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoItem")

            'Carrega Combo
            LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarEspecie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarEspecie.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadEspecieInsumo")

            'Carrega Combo
            LoadCombo(cboEspecie, "sp_select_combo_cadastro_basico_especie_insumo " & goUsuario.iEmpresa)

            'Seta Focu
            cboEspecie.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboUnidadeMedida : oComboBox(1) = cboUnidadeMedidaComposicao
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedida.Focus()

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
            tabMain.TabPages.Remove(pagLista)
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

            If IsNumeric(btnVoltar.Tag) Then
                For Each oRow As GridEXRow In grdListagem.GetDataRows
                    If IsDBNull(oRow.Cells("codigo_item").Value) = False AndAlso oRow.Cells("codigo_item").Value = btnVoltar.Tag Then
                        grdListagem.MoveTo(oRow)
                        Exit For
                    End If
                Next
            End If

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            grdListagem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecie.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado a Espécie
            If cboEspecie.SelectedIndex = -1 Then

                'Desabilita Controles
                txtPercentualHIServico.Visible = False
                txtPercentualHPServico.Visible = False
                lblPercentualHIServico.Visible = False
                lblPercentualHPServico.Visible = False

            Else

                Dim bPossuiHI As Boolean = CType(LoadDescricao("sp_select_cadastro_basico_especie_possui_hi " & goUsuario.iEmpresa & ", " & cboEspecie.SelectedValue), Boolean)
                txtPercentualHIServico.Visible = bPossuiHI
                txtPercentualHPServico.Visible = bPossuiHI
                lblPercentualHIServico.Visible = bPossuiHI
                lblPercentualHPServico.Visible = bPossuiHI

            End If
            
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SelectionChanged(sender As Object, e As EventArgs) Handles grdListagem.SelectionChanged

        Try

            Me.Select()

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdListagem.CurrentRow) = False AndAlso grdListagem.CurrentRow.RowType = RowType.Record AndAlso IsDBNull(grdListagem.CurrentRow.Cells("codigo_item").Value) = False Then

                'Limpa Grid
                grdComposicao.DataSource = Nothing

                'Carrega Grid - Produtos Similares
                Call oClsCadServico.LoadGridComposicao(grdComposicao, _
                                                       grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                                       TipoItem.nao_definido)

            Else

                'Limpa Controle
                grdComposicao.DataSource = Nothing

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoCadernoServico, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoCadernoServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: COMPOSIÇÃO :::"

    Private Sub btnAgruparGridComposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridComposicao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdComposicao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdComposicao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdComposicao.GroupByBoxVisible = True
                grdComposicao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridComposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridComposicao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdComposicao
            oForm.NomeFormulario = Formulario.CadastroBasicoCadernoServico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdComposicao, Formulario.CadastroBasicoCadernoServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridComposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridComposicao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdComposicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Sub
            End If

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar " & cboTipo.Text

            'Seta Parametros
            iCodigoTipoItemFind = cboTipo.SelectedValue
            oComboBoxFind = cboItemComposicao

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboItemComposicao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaComposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaComposicao.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Váriaveis Locais
            Dim sUnidadeMedida As String = IIf(cboUnidadeMedida.SelectedIndex = -1, "", cboUnidadeMedida.Text)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboUnidadeMedida : oComboBox(1) = cboUnidadeMedidaComposicao
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            cboUnidadeMedida.Text = sUnidadeMedida

            'Seta Focu
            cboUnidadeMedidaComposicao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirComposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirComposicao.Click

        Try

            'Valida Dados do Formulário
            If ValidacaoComposicao() = True Then

                If IsNumeric(btnInserirComposicao.Tag) = False Then

                    'Insere Composicao
                    Call oClsCadServico.InsertComposicao(grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                                         cboItemComposicao.SelectedValue, _
                                                         txtCoeficiente.Value, _
                                                         txtPercentualHP.Value, _
                                                         txtPercentualHI.Value, _
                                                         cboUnidadeMedidaComposicao.SelectedValue)

                Else

                    'Atualiza Composicao
                    Call oClsCadServico.UpdateComposicao(grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                                         cboItemComposicao.SelectedValue, _
                                                         txtCoeficiente.Value, _
                                                         txtPercentualHP.Value, _
                                                         txtPercentualHI.Value, _
                                                         cboUnidadeMedidaComposicao.SelectedValue, _
                                                         grdComposicao.CurrentRow.Cells("codigo_item").Value)

                End If

                'Carrega Grid
                Call oClsCadServico.LoadGridComposicao(grdComposicao, _
                                                       grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                                       TipoItem.nao_definido)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoComposicao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirComposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirComposicao.Click

        Try

            'Deleta Registros
            Call DeleteComposicao()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoComposicao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboTipo.SelectedIndex = -1 Then
                'Limpa Combo
                cboTipo.DataSource = Nothing
                txtPercentualHI.Visible = False
                txtPercentualHP.Visible = False
                lblPercentualHI.Visible = False
                lblPercentualHP.Visible = False
            Else

                If cboTipo.SelectedValue = CInt(TipoItem.insumo) Then
                    lblItemComposicao.Text = "Insumo:"
                    txtPercentualHI.Visible = False
                    txtPercentualHP.Visible = False
                    lblPercentualHI.Visible = False
                    lblPercentualHP.Visible = False
                Else
                    lblItemComposicao.Text = "Serviço:"
                End If

                'Carrega Combo - Composição
                Call LoadCombo(cboItemComposicao, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & cboTipo.SelectedValue, False)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboItemComposicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemComposicao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboItemComposicao.SelectedIndex = -1 Then

                'Seta Controles
                cboUnidadeMedidaComposicao.Text = ""
                txtPercentualHI.Visible = False
                txtPercentualHP.Visible = False
                lblPercentualHI.Visible = False
                lblPercentualHP.Visible = False

            Else

                'Seta Controles
                cboUnidadeMedidaComposicao.SelectedValue = LoadDescricao("sp_select_cadastro_basico_item_unidade_medida " & cboItemComposicao.SelectedValue & ", " & goUsuario.iEmpresa)

                Dim bPossuiHI As Boolean = IIf(cboTipo.SelectedValue = TipoItem.insumo, False, CType(LoadDescricao("sp_select_cadastro_basico_item_possui_hi " & goUsuario.iEmpresa & ", " & grdListagem.CurrentRow.Cells("codigo_item").Value), Boolean))
                txtPercentualHI.Visible = bPossuiHI
                txtPercentualHP.Visible = bPossuiHI
                lblPercentualHI.Visible = bPossuiHI
                lblPercentualHP.Visible = bPossuiHI

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdComposicao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdComposicao.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdComposicao.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdComposicao.CurrentColumn.Key

                Case "editar" : Call EditarComposicao()
                Case "codigo"
                    If grdComposicao.CurrentRow.Cells("tipo").Value = "SERVIÇO" Then
                        For Each oRow As GridEXRow In grdListagem.GetDataRows
                            If IsDBNull(oRow.Cells("codigo_item").Value) = False AndAlso oRow.Cells("codigo_item").Value = grdComposicao.CurrentRow.Cells("codigo_item").Value Then
                                grdListagem.MoveTo(oRow)
                                Exit For
                            End If
                        Next
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdComposicao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdComposicao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdComposicao, _
                                     Formulario.CadastroBasicoCadernoServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdComposicao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdComposicao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdComposicao.Name, _
                                     Formulario.CadastroBasicoCadernoServico, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdComposicao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdComposicao.GroupsChanging

        Try

            'Atualiza Grid

            Call UpdateConfiguraGridGrupo(grdComposicao.Name, _
                                          Formulario.CadastroBasicoCadernoServico, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCopiarComposicao_Click(sender As Object, e As EventArgs) Handles btnCopiarComposicao.Click

        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdListagem.CurrentRow) = False Then
                lCodigoServicoCopy = grdListagem.CurrentRow.Cells("codigo_item").Value
                btnColarComposicao.Enabled = True
                UpdateRegistroGrid(grdListagem, "codigo_item = " & lCodigoServicoCopy, "copiar", True)
                grdListagem.Refresh()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnColarComposicao_Click(sender As Object, e As EventArgs) Handles btnColarComposicao.Click

        Try

            'Verifica se foi Copiado
            If lCodigoServicoCopy = -1 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor Copiar alguma Composição.")
                Exit Sub
            End If

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            For Each oRow As GridEXRow In gSelecaoRow
                Call ExecuteQuery("sp_insert_cadastro_basico_item_composicao_copy " & goUsuario.iEmpresa & ", " & lCodigoServicoCopy & ", " & oRow.Cells("codigo_item").Value)
            Next

            'Atualiza Grid
            UpdateRegistroGrid(grdListagem, "codigo_item = " & lCodigoServicoCopy, "copiar", False)

            'Carrega Grid
            Call grdListagem_SelectionChanged(grdListagem, System.EventArgs.Empty)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadCadernoServico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito            
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoCadernoServico, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoCadernoServico, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoCadernoServico, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoCadernoServico, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarGrupoItem.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcInsert)
            btnCadastrarEspecie.Enabled = VerificaDireito(Formulario.CadastroBasicoEspecieInsumo, gcInsert)
            btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarUnidadeMedidaComposicao.Enabled = btnCadastrarUnidadeMedida.Enabled

            'Carrega Combo
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboEspecie, "sp_select_combo_cadastro_basico_especie_insumo " & goUsuario.iEmpresa)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboAtivo)
            'Carrega Combo - Tipo de Arquivo
            'Carrega Combo - Composição
            cboTipo.Items.Clear()
            cboTipo.Items.Add("SERVIÇO", TipoItem.servico)
            cboTipo.Items.Add("INSUMO", TipoItem.insumo)
            'Carrega Combo - Unidade de Medida
            Call LoadCombo(cboUnidadeMedidaComposicao, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCadernoServico)
            Call ConfiguraGrid(grdComposicao, Formulario.CadastroBasicoCadernoServico)

            'Desabiliata Botão
            btnColarComposicao.Enabled = False

            'Carrega Caderno de Serviço
            Call LoadGrid()

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            grdListagem.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇOS :::"

    Private Sub Editar()

        Try

            'Limpa Formulário
            Call Novo()

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCadernoServico, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Seta Controle                    
                    btnSalvar.Tag = .Item("codigo_item").Value
                    btnVoltar.Tag = .Item("codigo_item").Value
                    cboGrupoItem.SelectedValue = .Item("codigo_grupo_item").Value
                    cboEspecie.SelectedValue = .Item("codigo_especie").Value
                    txtCodigoServico.Text = .Item("etapa").Value
                    cboUnidadeMedida.SelectedValue = .Item("codigo_unidade_medida").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    txtDescricaoServico.Text = .Item("descricao").Value
                    txtCoeficienteServico.Value = .Item("coeficiente").Value
                    txtPercentualHIServico.Value = .Item("percentual_hi").Value
                    txtPercentualHPServico.Value = .Item("percentual_hp").Value

                End With

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboGrupoItem.Focus()

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

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadServico.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
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
            txtCodigoServico.Text = ""
            cboGrupoItem.Text = ""
            cboEspecie.Text = ""
            txtDescricaoServico.Text = ""
            cboAtivo.SelectedValue = True
            txtCoeficienteServico.Value = 0
            cboUnidadeMedida.Text = ""
            txtPercentualHPServico.Value = 0
            txtPercentualHIServico.Value = 0
            btnSalvar.Tag = ""

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros            
            oClsCadServico.CodigoEspecie = cboEspecie.SelectedValue
            oClsCadServico.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadServico.CodigoGrupoItem = cboGrupoItem.SelectedValue
            oClsCadServico.AliquotaTotalImposto = 0
            oClsCadServico.CodigoServico = txtCodigoServico.Text.Trim
            oClsCadServico.Descricao = txtDescricaoServico.Text.Trim
            oClsCadServico.Ativo = cboAtivo.SelectedValue
            oClsCadServico.CodigoUnidadeMedida = IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue)
            oClsCadServico.Coeficiente = txtCoeficienteServico.Value
            oClsCadServico.PercentualHI = IIf(txtPercentualHIServico.Visible = False, 0, txtPercentualHIServico.Value)
            oClsCadServico.PercentualHP = IIf(txtPercentualHPServico.Visible = False, 0, txtPercentualHPServico.Value)

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsCadServico.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadServico.Insert()
                btnSalvar.Tag = oClsCadServico.Codigo
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

            'Configura Grid
            Call oClsCadServico.LoadGridFindCaderno(grdListagem)

            If lCodigoServicoCopy <> -1 Then
                If IsNumeric(btnVoltar.Tag) Then
                    For Each oRow As GridEXRow In grdListagem.GetDataRows
                        If IsDBNull(oRow.Cells("codigo_item").Value) = False AndAlso oRow.Cells("codigo_item").Value = lCodigoServicoCopy Then
                            grdListagem.MoveTo(oRow)
                            Exit For
                        End If
                    Next
                End If
            End If

            lCodigoServicoCopy = -1
            btnColarComposicao.Enabled = False

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

            'Verifica se foi Preenchido o Campo - Código do Serviço
            If ValidaCampo(txtCodigoServico, lblCodigoServico, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Grupo de Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se não está selecionado o Código
            If txtCodigoServico.Text.Trim = "" Then

                If MsgBox("Deseja que o sistema gere o Código do Serviço?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    'Gera Número do Part Number e Código do Item
                    txtCodigoServico.Text = oClsCadServico.GeraCodigoServico(cboGrupoItem.SelectedValue)
                End If

            End If

            'Passa Parametros
            If oClsCadServico.ValidaCodigo(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                           txtCodigoServico.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricaoServico, "Este Código: " & txtCodigoServico.Text & " já está associado a outro Registro.")
                txtCodigoServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Coeficiente
            If ValidaCampo(txtCoeficienteServico, lblCoeficienteServico, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade Medida
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - % H.P.
            If ValidaCampo(txtPercentualHPServico, lblPercentualHPServico, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - % H.I.
            If ValidaCampo(txtPercentualHIServico, lblPercentualHIServico, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoServico, lblDescricaoServico, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: COMPOSIÇÃO :::"

    Private Sub DeleteComposicao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdComposicao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        oClsCadServico.DeleteComposicao(grdListagem.CurrentRow.Cells("codigo_item").Value)
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarComposicao()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoCadernoServico, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoComposicao()

                'Carrega Controles
                cboTipo.Text = grdComposicao.CurrentRow.Cells("tipo").Value
                cboItemComposicao.SelectedValue = grdComposicao.CurrentRow.Cells("codigo_item").Value
                txtCoeficiente.Value = grdComposicao.CurrentRow.Cells("coeficiente").Value
                txtPercentualHP.Value = grdComposicao.CurrentRow.Cells("percentual_hp").Value
                txtPercentualHI.Value = grdComposicao.CurrentRow.Cells("percentual_hi").Value
                cboUnidadeMedidaComposicao.SelectedValue = grdComposicao.CurrentRow.Cells("codigo_unidade_medida").Value
                btnInserirComposicao.Tag = grdComposicao.CurrentRow.Cells("codigo_item").Value

                'Seta Focu
                cboTipo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoComposicao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles            
            cboTipo.Text = ""
            cboItemComposicao.Text = ""
            txtCoeficiente.Value = 0
            txtPercentualHP.Value = 0
            txtPercentualHI.Value = 0

            cboUnidadeMedidaComposicao.Text = ""
            btnInserirComposicao.Tag = ""

            'Seta Focu
            cboTipo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoComposicao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoComposicao = False

            'Verifica se foi Selecionado o Campo - Tipo
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Codigo Composição
            If ValidaCampo(cboItemComposicao, lblItemComposicao) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Referência
            If ValidaCampo(txtCoeficiente, lblCoeficiente, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtPercentualHP, lblPercentualHP, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtPercentualHI, lblPercentualHI, False) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedidaComposicao, lblUnidadeMedidaComposicao) = False Then
                Exit Function
            End If

            'Verifica se o Produto é Válido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirComposicao.Tag) Then
                iRow = grdComposicao.CurrentRow.RowIndex
            End If

            For Each oRow As GridEXRow In grdComposicao.GetDataRows
                If oRow.Cells("codigo_item").Value = cboItemComposicao.SelectedValue And oRow.RowIndex <> iRow Then
                    frmMain.errInfo.SetError(lblItemComposicao, "Este Serviço já se encontra associado a este Registro.")
                    cboItemComposicao.Focus()
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
