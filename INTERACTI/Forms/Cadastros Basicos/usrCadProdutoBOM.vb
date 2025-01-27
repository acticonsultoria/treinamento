Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class usrCadProdutoBOM

#Region "::: VARIAVEIS :::"

    'Variáveis - Classe
    Private oClsCadProduto As New clsUsrCadProduto
    Private oRow As New Hashtable

    'Váriaveis - Controle
    Private bItemCompra As Boolean
    Private bItemProducao As Boolean
    Private bItemAtivoFixo As Boolean
    Private bItemAlternativo As Boolean

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"
    
    Private Sub usrCadProdutoBOM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor
                    Select Case sender.Name
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
                    End Select
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F3

                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnProcurarProduto_Click(btnProcurarItem, System.EventArgs.Empty)
                        Case "cboCodigoItem" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                    End Select

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCodigoItem" : Call btnCadastrarItem_Click(btnCadastrarItem, System.EventArgs.Empty)
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadProdutoBOM_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: BOM :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridBOM.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdBOM.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdBOM.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdBOM.GroupByBoxVisible = True
                grdBOM.HideColumnsWhenGrouped = InheritableBoolean.True

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
            oForm.Grid = grdBOM
            oForm.NomeFormulario = Formulario.CadastroBasicoProdutoBOM
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdBOM, Formulario.CadastroBasicoProdutoBOM)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdBOM)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarItem.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo
            Call cboTipoItem_SelectedIndexChanged(cboTipoItem, System.EventArgs.Empty)

            'Seta Focu
            cboCodigoItem.Focus()

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
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboUnidadeMedida.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboCodigoItem


            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemOriginal.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
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

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemCompraFind = IIf(bItemCompra = True, "S", "")
            sItemProducaoFind = IIf(bItemProducao = True, "S", "")
            sItemAtivoFixoFind = IIf(bItemAtivoFixo = True, "S", "")
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprimir
            Call Imprimir()

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

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoBOM() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserir.Tag) Then

                    ''Atualiza Registro da BOM
                    'Call oClsCadProduto.UpdateBOM(cboCodigoProduto.SelectedValue, _
                    '                              cboTipoItem.SelectedValue, _
                    '                              cboCodigoItem.SelectedValue, _
                    '                              IIf(cboCodigoItemOriginal.SelectedIndex = -1, -1, cboCodigoItemOriginal.SelectedValue), _
                    '                              cboUnidadeMedida.SelectedValue, _
                    '                              txtQuantidade.Value, _
                    '                              1, _
                    '                              grdBOM.CurrentRow.Cells("codigo_item").Value, _
                    '                              txtValorUnitario.Value, _
                    '                              txtValorUnitarioDesconto.Value)

                Else

                    ''Insere Registro da BOM
                    'Call oClsCadProduto.InsertBOM(cboCodigoProduto.SelectedValue, _
                    '                              cboTipoItem.SelectedValue, _
                    '                              cboCodigoItem.SelectedValue, _
                    '                              IIf(cboCodigoItemOriginal.SelectedIndex = -1, -1, cboCodigoItemOriginal.SelectedValue), _
                    '                              cboUnidadeMedida.SelectedValue, _
                    '                              txtQuantidade.Value, _
                    '                              1, _
                    '                              txtValorUnitario.Value, _
                    '                              txtValorUnitarioDesconto.Value)

                End If

                'Carrega Grid
                Call LoadGrid()

                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricao.Text = ""
                cboTipoItem.Text = ""
                cboCodigoItemOriginal.Text = ""
                txtDescricaoItemOriginal.Text = ""
                cboCodigoItem.Text = ""
                txtDescricaoItem.Text = ""
                cboUnidadeMedida.Text = ""
                txtQuantidade.Value = 0
                btnInserir.Tag = ""
                grdBOM.DataSource = Nothing

                'Limpa Controles - Totais
                txtTotalTransporte.Value = 0
                txtTotalEmbalagem.Value = 0
                txtTotalMaoObra.Value = 0
                txtDescontoPercentualMaoObra.Value = 0

                'Desabilia Controle
                grpBOM.Enabled = False
                grpOutros.Enabled = False

            Else

                'Carrega Grid
                Call LoadGrid()

                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoProduto.SelectedValue, _
                                                txtDescricao, _
                                                txtTotalTransporte, _
                                                txtTotalEmbalagem, _
                                                txtTotalMaoObra, _
                                                txtDescontoPercentualMaoObra)


                'Habilita Controle
                grpBOM.Enabled = True
                grpOutros.Enabled = True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoItem.SelectedIndexChanged

        Try

            'Verifica o Tipo de Item - BOM
            If cboTipoItem.SelectedIndex = -1 Then

                'Limpa Controles
                cboCodigoItem.DataSource = Nothing : cboCodigoItem.Text = "" : txtDescricaoItem.Text = ""
                cboCodigoItemOriginal.DataSource = Nothing : cboCodigoItemOriginal.Text = "" : txtDescricaoItemOriginal.Text = "" : cboCodigoItemOriginal.Enabled = False

            Else

                'Carrega Controles
                Call oClsCadProduto.LoadDadosTipoItemBOM(cboTipoItem.SelectedValue, _
                                                         bItemCompra, _
                                                         bItemProducao, _
                                                         bItemAtivoFixo, _
                                                         bItemAlternativo)

                'Verifica se é Alternativo
                If bItemAlternativo = False Then

                    'Desabilita Controle
                    cboCodigoItemOriginal.DataSource = Nothing : cboCodigoItemOriginal.Text = "" : txtDescricaoItemOriginal.Text = "" : cboCodigoItemOriginal.Enabled = False
                    If btnInserir.Tag = "" Then
                        'Carrega Combo
                        Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, " & IIf(bItemCompra = True, "1", "0") & ", " & TipoItem.produto & ", NULL, " & IIf(bItemProducao = True, "1", "0") & ", NULL, " & IIf(bItemAtivoFixo = True, "1", "0"), False)
                    End If
                Else

                    'Desabilita Controle
                    cboCodigoItemOriginal.Enabled = True
                    'Carrega Combo
                    Call LoadCombo(cboCodigoItemOriginal, "sp_select_combo_cadastro_basico_item_bom " & goUsuario.iEmpresa & ", " & cboCodigoProduto.SelectedValue, False)
                    Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, " & IIf(bItemCompra = True, "1", "0") & ", " & TipoItem.produto & ", NULL, " & IIf(bItemProducao = True, "1", "0") & ", NULL, " & IIf(bItemAtivoFixo = True, "1", "0"), False)

                End If

                End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItemOriginal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoItemOriginal.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoItemOriginal.SelectedIndex = -1 Then
                'Limpa Controle
                txtDescricaoItemOriginal.Text = ""
            Else
                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoItemOriginal.SelectedValue, _
                                                txtDescricaoItemOriginal)
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
                'Limpa Controle
                txtDescricaoItem.Text = ""
                txtValorUnitario.Value = 0
            Else
                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoItem.SelectedValue, txtDescricaoItem)
                oClsCadProduto.LoadDadosProduto(cboCodigoItem.SelectedValue, txtValorUnitario)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdBOM.CellUpdated

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdBOM.CurrentColumn) Then Exit Sub

            'Váriaveis Locais
            Dim dQuantidade As Double = grdBOM.GetValue("quantidade")
            Dim dValorUnitario As Double = grdBOM.GetValue("valor_unitario")
            Dim dDescontoPercentual As Double = 0
            Dim dDescontoUnitario As Double = 0
            Dim lCodigoItem As Long = grdBOM.GetValue("codigo_item")

            Select Case grdBOM.CurrentColumn.Key

                Case "desconto_percentual"
                    If IsNumeric(grdBOM.GetValue("desconto_percentual")) Then dDescontoPercentual = grdBOM.GetValue("desconto_percentual")
                    dDescontoUnitario = dValorUnitario * dDescontoPercentual / 100

                Case "desconto_valor"
                    If IsNumeric(grdBOM.GetValue("desconto_valor")) Then dDescontoUnitario = grdBOM.GetValue("desconto_valor")
                    dDescontoPercentual = dDescontoUnitario / dValorUnitario * 100

                Case Else
                    Exit Sub

            End Select

            'Atualiza Grid
            UpdateRegistroGrid(grdBOM, "codigo_item = " & lCodigoItem, "desconto_percentual", dDescontoPercentual)
            UpdateRegistroGrid(grdBOM, "codigo_item = " & lCodigoItem, "desconto_valor", dDescontoUnitario)
            UpdateRegistroGrid(grdBOM, "codigo_item = " & lCodigoItem, "valor_unitario_desconto", dValorUnitario - dDescontoUnitario)
            UpdateRegistroGrid(grdBOM, "codigo_item = " & lCodigoItem, "valor_total", dQuantidade * (dValorUnitario - dDescontoUnitario))

            'Atualiza Banco de Dados
            Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item_bom', 'desconto_valor', " & dDescontoUnitario.ToString.Replace(",", ".") & ", 'WHERE (((codigo_item_pai) = " & cboCodigoProduto.SelectedValue & ") AND ((codigo_empresa) = " & goUsuario.iEmpresa & ") AND ((codigo_item_filho) = " & lCodigoItem & "))'")

            'Atualiza Total
            Call CalculoTotal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdBOM.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdBOM.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdBOM.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdBOM.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBOM, _
                                     Formulario.CadastroBasicoProdutoBOM)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdBOM.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBOM.Name, _
                                     Formulario.CadastroBasicoProdutoBOM, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdBOM.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdBOM.Name, _
                                          Formulario.CadastroBasicoProdutoBOM, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoValorProduto(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorUnitario.ValueChanged, _
                                                                                                 txtQuantidade.ValueChanged, _
                                                                                                 txtDescontoValor.LostFocus, _
                                                                                                 txtDescontoPercentual.LostFocus, _
                                                                                                 txtValorUnitarioDesconto.LostFocus

        Try

            'Váriaveis Locais
            Dim dQuantidade As Double = 0
            Dim dValorUnitario As Double = 0
            Dim dDescontoValor As Double = 0
            Dim dDescontoPercentual As Double = 0
            Dim dValorUnitarioDesconto As Double = 0

            dQuantidade = IIf(IsNumeric(txtQuantidade.Value), txtQuantidade.Value, 0)

            Select Case sender.Name

                Case "txtDescontoValor"
                    dValorUnitario = IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0)
                    If dValorUnitario = 0 Then
                        dValorUnitarioDesconto = IIf(IsNumeric(txtValorUnitarioDesconto.Value), txtValorUnitarioDesconto.Value, 0)
                        dDescontoPercentual = 0
                        dDescontoValor = 0
                    Else
                        dDescontoValor = IIf(IsNumeric(txtDescontoValor.Value), txtDescontoValor.Value, 0)
                        dDescontoPercentual = IIf(dDescontoValor = 0, 0, dDescontoValor / dValorUnitario * 100)
                        dValorUnitarioDesconto = dValorUnitario - dDescontoValor
                    End If

                Case "txtDescontoPercentual"
                    dValorUnitario = IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0)
                    If dValorUnitario = 0 Then
                        dValorUnitarioDesconto = IIf(IsNumeric(txtValorUnitarioDesconto.Value), txtValorUnitarioDesconto.Value, 0)
                        dDescontoPercentual = 0
                        dDescontoValor = 0
                    Else
                        dDescontoPercentual = IIf(IsNumeric(txtDescontoPercentual.Value), txtDescontoPercentual.Value, 0)
                        dDescontoValor = dValorUnitario * dDescontoPercentual / 100
                        dValorUnitarioDesconto = dValorUnitario - dDescontoValor
                    End If

                Case "txtValorUnitario"
                    dValorUnitario = IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0)
                    If dValorUnitario = 0 Then
                        dValorUnitarioDesconto = IIf(IsNumeric(txtValorUnitarioDesconto.Value), txtValorUnitarioDesconto.Value, 0)
                        dDescontoPercentual = 0
                        dDescontoValor = 0
                    Else
                        dDescontoValor = IIf(IsNumeric(txtDescontoValor.Value), txtDescontoValor.Value, 0)
                        dDescontoPercentual = IIf(dDescontoValor = 0, 0, dDescontoValor / dValorUnitario * 100)
                        dValorUnitarioDesconto = dValorUnitario - dDescontoValor
                    End If

                Case "txtValorUnitarioDesconto", "txtQuantidade"
                    If IIf(IsNumeric(txtValorUnitarioDesconto.Value), txtValorUnitarioDesconto.Value, 0) > IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0) Then
                        dValorUnitario = IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0)
                        dDescontoPercentual = 0
                        dDescontoValor = 0
                        dValorUnitarioDesconto = IIf(IsNumeric(txtValorUnitarioDesconto.Value), txtValorUnitarioDesconto.Value, 0)
                    Else
                        dValorUnitario = IIf(IsNumeric(txtValorUnitario.Value), txtValorUnitario.Value, 0)
                        dValorUnitarioDesconto = IIf(IsNumeric(txtValorUnitarioDesconto.Value), txtValorUnitarioDesconto.Value, 0)
                        dDescontoValor = dValorUnitario - dValorUnitarioDesconto
                        dDescontoPercentual = IIf(dDescontoValor = 0, 0, dDescontoValor / dValorUnitario * 100)
                    End If

            End Select

            'Seta Controles
            txtValorUnitario.Value = dValorUnitario
            txtDescontoValor.Value = dDescontoValor
            txtDescontoPercentual.Value = dDescontoPercentual
            txtValorUnitarioDesconto.Value = dValorUnitarioDesconto
            txtValorTotal.Value = dValorUnitarioDesconto * dQuantidade

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoTotalOutros(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalTransporte.ValueChanged, _
                                                                                                txtTotalEmbalagem.ValueChanged, _
                                                                                                txtTotalMaoObra.ValueChanged, _
                                                                                                txtDescontoPercentualMaoObra.ValueChanged

        Try

            'Váriaveis Locais
            Dim dTotalTransporte As Double = IIf(IsNumeric(txtTotalTransporte.Value), txtTotalTransporte.Value, 0)
            Dim dTotalEmbalagem As Double = IIf(IsNumeric(txtTotalEmbalagem.Value), txtTotalEmbalagem.Value, 0)
            Dim dTotalMaoObra As Double = IIf(IsNumeric(txtTotalMaoObra.Value), txtTotalMaoObra.Value, 0)
            Dim dDescontoPercentualMaoObra = IIf(IsNumeric(txtDescontoPercentualMaoObra.Value), txtDescontoPercentualMaoObra.Value, 0)

            'Seta Controles
            txtTotalOutros.Value = dTotalTransporte + dTotalEmbalagem + (dTotalMaoObra - (dTotalMaoObra * dDescontoPercentualMaoObra / 100))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub AtualizaTotalOutros(sender As Object, e As EventArgs) Handles txtTotalTransporte.LostFocus, _
                                                                              txtTotalEmbalagem.LostFocus, _
                                                                              txtTotalMaoObra.LostFocus, _
                                                                              txtDescontoPercentualMaoObra.LostFocus

        Try

            If cboCodigoProduto.SelectedIndex <> -1 Then

                'Váriaveis Locais
                Dim dTotalTransporte As Double = IIf(IsNumeric(txtTotalTransporte.Value), txtTotalTransporte.Value, 0)
                Dim dTotalEmbalagem As Double = IIf(IsNumeric(txtTotalEmbalagem.Value), txtTotalEmbalagem.Value, 0)
                Dim dTotalMaoObra As Double = IIf(IsNumeric(txtTotalMaoObra.Value), txtTotalMaoObra.Value, 0)
                Dim dDescontoPercentualMaoObra = IIf(IsNumeric(txtDescontoPercentualMaoObra.Value), txtDescontoPercentualMaoObra.Value, 0)

                'Atualiza Banco de Dados
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', 'valor_transporte', " & dTotalTransporte.ToString.Replace(",", ".") & ", 'WHERE (((codigo) = " & cboCodigoProduto.SelectedValue & ") AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', 'valor_embalagem', " & dTotalEmbalagem.ToString.Replace(",", ".") & ", 'WHERE (((codigo) = " & cboCodigoProduto.SelectedValue & ") AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', 'valor_mao_obra', " & dTotalMaoObra.ToString.Replace(",", ".") & ", 'WHERE (((codigo) = " & cboCodigoProduto.SelectedValue & ") AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', 'desconto_percentual_mao_obra', " & dDescontoPercentualMaoObra.ToString.Replace(",", ".") & ", 'WHERE (((codigo) = " & cboCodigoProduto.SelectedValue & ") AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoTotal() Handles txtTotalOutros.ValueChanged

        Try

            'Váriaveis Locais
            Dim dTotalTransporte As Double = IIf(IsNumeric(txtTotalTransporte.Value), txtTotalTransporte.Value, 0)
            Dim dTotalEmbalagem As Double = IIf(IsNumeric(txtTotalEmbalagem.Value), txtTotalEmbalagem.Value, 0)
            Dim dTotalMaoObra As Double = IIf(IsNumeric(txtTotalMaoObra.Value), txtTotalMaoObra.Value, 0)
            Dim dDescontoPercentualMaoObra As Double = IIf(IsNumeric(txtDescontoPercentualMaoObra.Value), txtDescontoPercentualMaoObra.Value, 0)

            Dim dValorTotalDesconto As Double = 0
            Dim dTotalDesconto As Double = 0

            If grdBOM.GetDataRows.Count > 0 Then
                dValorTotalDesconto = grdBOM.GetTotalRow.Cells("valor_total").Value
                dTotalDesconto = grdBOM.GetTotalRow.Cells("total_desconto").Value
            End If

            'Seta Controles
            txtTotal.Value = dTotalTransporte + dTotalEmbalagem + dTotalMaoObra + dValorTotalDesconto + dTotalDesconto
            txtTotalDesconto.Value = dTotalTransporte + dTotalEmbalagem + dTotalMaoObra + dValorTotalDesconto - (dTotalMaoObra * dDescontoPercentualMaoObra / 100)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtTotalDesconto_ValueChanged(sender As Object, e As EventArgs) Handles txtTotalDesconto.ValueChanged

        Try

            If IsNumeric(txtTotalDesconto.Value) And cboCodigoProduto.SelectedIndex <> -1 Then

                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', 'preco_venda', " & txtTotalDesconto.Value.ToString.Replace(",", ".") & ", 'WHERE (((codigo) = " & cboCodigoProduto.SelectedValue & ") AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")

            End If

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadProdutoBOM_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcPrint)
            btnImprimir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcPrint)
            'Verifica Direito - Botão Cadastro
            btnCadastrarItem.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcInsert)
            btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, 1, NULL", False)
            Call LoadCombo(cboTipoItem, "sp_select_combo_static_tipo_item_bom")
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Prepara Formulário
            Call Novo()

            'Configura Grid
            Call ConfiguraGrid(grdBOM, Formulario.CadastroBasicoProdutoBOM)

            'Seta Focu
            cboCodigoProduto.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: BOM :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdBOM) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteItemBOM(cboCodigoProduto.SelectedValue)

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

    Private Sub Editar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                cboTipoItem.SelectedValue = grdBOM.CurrentRow.Cells("codigo_tipo_item").Value
                cboCodigoItemOriginal.SelectedValue = grdBOM.CurrentRow.Cells("codigo_item_original").Value
                cboCodigoItem.SelectedValue = grdBOM.CurrentRow.Cells("codigo_item").Value
                txtQuantidade.Value = grdBOM.CurrentRow.Cells("quantidade").Value
                cboUnidadeMedida.SelectedValue = grdBOM.CurrentRow.Cells("codigo_unidade_medida").Value
                txtValorUnitario.Value = grdBOM.CurrentRow.Cells("valor_unitario").Value
                txtDescontoPercentual.Value = grdBOM.CurrentRow.Cells("desconto_percentual").Value
                txtDescontoValor.Value = grdBOM.CurrentRow.Cells("desconto_valor").Value
                txtValorUnitarioDesconto.Value = grdBOM.CurrentRow.Cells("valor_unitario_desconto").Value
                txtValorTotal.Value = grdBOM.CurrentRow.Cells("valor_total").Value
                btnInserir.Tag = grdBOM.CurrentRow.Cells.Item("codigo_item").Value

                'Seta Focu
                cboCodigoItem.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

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
            cboTipoItem.SelectedIndex = -1
            cboCodigoItemOriginal.SelectedIndex = -1
            txtDescricaoItemOriginal.Text = ""
            cboCodigoItem.SelectedIndex = -1
            txtDescricaoItem.Text = ""
            cboUnidadeMedida.SelectedIndex = -1
            txtQuantidade.Value = 0            
            txtValorUnitario.Value = 0
            txtDescontoPercentual.Value = 0
            txtDescontoValor.Value = 0
            txtValorUnitarioDesconto.Value = 0
            txtValorTotal.Value = 0
            btnInserir.Tag = ""

            'Calcula Total
            Call CalculoTotal()

            'Seta Focu
            cboTipoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadProduto.LoadGridBOM(grdBOM, cboCodigoProduto.SelectedValue)

            'Calcula Total
            CalculoTotal()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_item"
            goCrystalReport.sReportParameter(0).sValue = cboCodigoProduto.SelectedValue
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "CAD000000005.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("CAD000000005", "Cadastro Básico - BOM", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoBOM() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoBOM = False

            'Verifica se foi Preenchido o Campo - Produto
            If ValidaCampo(cboCodigoItem, lblCodigoItem) = False Then
                Exit Function
            End If

            ''Verifica se o Produto é Válido
            'If IsNumeric(btnInserir.Tag) Then
            '    If VerificaExisteValorGrid(grdBOM2, "codigo_item", cboProduto.SelectedValue, grdBOM2.CurrentRow.RowIndex) Then
            '        frmMain.errInfo.SetError(lblCodigoProduto, "Este Item: " & cboProduto.Text & " já está associado ao Produto: " & txtCodigo.Text.Trim & ".")
            '        cboProduto.Focus()
            '        Exit Function
            '    End If
            'Else
            '    If VerificaExisteValorGrid(grdBOM2, "codigo_item", cboProduto.SelectedValue, -1) Then
            '        frmMain.errInfo.SetError(lblCodigoProduto, "Este Item: " & cboProduto.Text & " já está associado ao Produto: " & txtCodigo.Text.Trim & ".")
            '        cboProduto.Focus()
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário Desconto
            If ValidaCampo(txtValorUnitarioDesconto, lblValorUnitarioDesconto, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoBOM = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

    Private Sub btnCadastrarItemLote_Click(sender As Object, e As EventArgs) Handles btnCadastrarItemLote.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadItemLote")

            'Carrega Combo
            Call cboCodigoProduto_SelectedIndexChanged(cboCodigoProduto, System.EventArgs.Empty)

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

End Class