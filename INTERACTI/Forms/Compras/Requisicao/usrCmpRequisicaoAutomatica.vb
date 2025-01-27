Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCmpRequisicaoAutomatica

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpRequisicaoAutomatica As New clsUsrCmpRequisicaoAutomatica

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCmpRequisicaoAutomatica_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                        
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtProduto" '
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCmpRequisicaoAutomatica_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

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
            oForm.NomeFormulario = Formulario.ComprasRequisicaoAutomatico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasRequisicaoAutomatico)

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

            'Limpa erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado a Forma de Análise
            If ValidaCampo(cboFormaAnaliseFiltro, lblFormaAnaliseFiltro) = False Then Exit Sub

            'Carrega Dados da Grid
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub btnGerarRequisicaoUnitaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarRequisicaoUnitaria.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call SalvarRequisicaoUnitaria()

                'Recarrega a Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarRequisicaoGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarRequisicaoGlobal.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call SalvarRequisicaoGlobal()

                'Recarrega a Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComprasRequisicaoAutomatico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComprasRequisicaoAutomatico, _
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
                                          Formulario.ComprasRequisicaoAutomatico, _
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

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpRequisicaoAutomatica_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnGerarRequisicaoUnitaria.Enabled = VerificaDireito(Formulario.ComprasRequisicaoAutomatico, gcInsert)
            btnGerarRequisicaoGlobal.Enabled = VerificaDireito(Formulario.ComprasRequisicaoAutomatico, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasRequisicaoAutomatico, gcPrint)

            'Carrega ComboBox        
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            cboFormaAnaliseFiltro.Items.Clear()
            cboFormaAnaliseFiltro.Items.Add("CONSIDERAR ESTOQUE MÍNIMO", 1)
            cboFormaAnaliseFiltro.SelectedValue = 1
            'cboFormaAnaliseFiltro.Items.Add("DESCONSIDERAR ESTOQUE MÍNIMO", 2)
            Call LoadCombo(cboAprovador, "sp_select_combo_administracao_usuario_administrador " & goUsuario.iEmpresa & ", " & Formulario.ComprasRequisicaoAprovar)
            chkConsiderarItemCompra.Checked = True
            chkSomentePendentes.Checked = True

            'Carrega ComboBox - Grid
            Call LoadComboGrid(grdListagem, "centro_custo", "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdListagem, "conta_contabil", "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasRequisicaoAutomatico)

            'Seta Focu
            cboGrupoItemFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsCmpRequisicaoAutomatica.LoadGrid(grdListagem, _
                                                 IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                                 IIf(cboFormaAnaliseFiltro.SelectedIndex = -1, -1, cboFormaAnaliseFiltro.SelectedValue), _
                                                 txtCodigoProdutoFiltro.Text.Trim, _
                                                 txtDescricaoFiltro.Text.Trim, _
                                                 chkConsiderarItemCompra.CheckState, _
                                                 chkSomentePendentes.CheckState, _
                                                 IIf(IsNumeric(txtNumeroPedidoVendaFiltro.Text.Trim), txtNumeroPedidoVendaFiltro.Text.Trim, -1), _
                                                 txtPnTopoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRequisicaoUnitaria()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim lCodigoRequisicao As Long

            For Each oRow As GridEXRow In gSelecaoRow

                'Insere Requisição - Capa
                Call oClsCmpRequisicaoAutomatica.InsertRequisicao(cboAprovador.SelectedValue, _
                                                                  lCodigoRequisicao)

                'Insere Requisição - Produto
                Call oClsCmpRequisicaoAutomatica.InsertProduto(grdListagem, _
                                                               lCodigoRequisicao, _
                                                               oRow.Cells("codigo_item").Value, _
                                                               IIf(IsDBNull(oRow.Cells("descricao").Value), "", oRow.Cells("descricao").Value), _
                                                               IIf(IsDBNull(oRow.Cells("complemento").Value), "", oRow.Cells("complemento").Value), _
                                                               IIf(IsDBNull(oRow.Cells("marca").Value), "", oRow.Cells("marca").Value), _
                                                               IIf(IsDBNull(oRow.Cells("centro_custo").Value), -1, oRow.Cells("centro_custo").Value), _
                                                               IIf(IsDBNull(oRow.Cells("conta_contabil").Value), "", oRow.Cells("conta_contabil").Value), _
                                                               oRow.Cells("quantidade_requisicao").Value, _
                                                               oRow.Cells("codigo_unidade_medida").Value, _
                                                               IIf(IsDBNull(oRow.Cells("data_necessidade").Value), "", oRow.Cells("data_necessidade").Value), _
                                                               IIf(IsDBNull(oRow.Cells("justificativa").Value), "", oRow.Cells("justificativa").Value), _
                                                               oRow.Cells("dimensao").Value, _
                                                               IIf(IsDBNull(oRow.Cells("codigo_unidade_medida_dimensao").Value), -1, oRow.Cells("codigo_unidade_medida_dimensao").Value), _
                                                               oRow.Cells("codigo_op").Value, _
                                                               IIf(IsDBNull(oRow.Cells("sc").Value), -1, oRow.Cells("sc").Value), _
                                                               IIf(IsDBNull(oRow.Cells("det").Value), -1, oRow.Cells("det").Value), _
                                                               IIf(IsDBNull(oRow.Cells("mp").Value), "", oRow.Cells("mp").Value), _
                                                               IIf(IsDBNull(oRow.Cells("observacao_bom").Value), "", oRow.Cells("observacao_bom").Value), _
                                                               IIf(IsDBNull(oRow.Cells("codigo_requisicao_estoque").Value), -1, oRow.Cells("codigo_requisicao_estoque").Value), _
                                                               IIf(IsDBNull(oRow.Cells("codigo_requisicao_estoque_item").Value), -1, oRow.Cells("codigo_requisicao_estoque_item").Value))

            Next

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRequisicaoGlobal()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim lCodigoRequisicao As Long

            'Insere Requisição - Capa
            Call oClsCmpRequisicaoAutomatica.InsertRequisicao(cboAprovador.SelectedValue, _
                                                              lCodigoRequisicao)

            'Insere Requisição - Produto
            Call oClsCmpRequisicaoAutomatica.InsertProduto(grdListagem, _
                                                           lCodigoRequisicao)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

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

            'Verifica se foi inserido algum Item
            If VerificaSelecaoRow(grdListagem) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Aprovador
            If ValidaCampo(cboAprovador, lblAprovador) = False Then
                Exit Function
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


