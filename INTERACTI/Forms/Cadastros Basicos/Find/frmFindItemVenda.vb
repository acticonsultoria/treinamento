Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX

Public Class frmFindItemVenda

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadProduto As New clsUsrCadProduto
    Private iCodigoTipoItem As Integer
    Private sItemVenda As String = ""
    Private sItemCompra As String = ""
    Private sItemProducao As String = ""
    Private sItemEstoque As String = ""
    Private sItemAtivoFixo As String = ""
    Private sInsumoProducao As String = ""
    Private oComboBox As UIComboBox
    Private oMaskedEditBox As MaskedEditBox

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoTipoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoTipoItem = value
        End Set
    End Property

    Public WriteOnly Property ItemVenda() As String
        Set(ByVal value As String)
            sItemVenda = value
        End Set
    End Property

    Public WriteOnly Property ItemCompra() As String
        Set(ByVal value As String)
            sItemCompra = value
        End Set
    End Property

    Public WriteOnly Property ItemProducao() As String
        Set(ByVal value As String)
            sItemProducao = value
        End Set
    End Property

    Public WriteOnly Property ItemEstoque() As String
        Set(ByVal value As String)
            sItemEstoque = value
        End Set
    End Property

    Public WriteOnly Property ItemAtivoFixo() As String
        Set(ByVal value As String)
            sItemAtivoFixo = value
        End Set
    End Property

    Public WriteOnly Property InsumoProducao() As String
        Set(ByVal value As String)
            sInsumoProducao = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmFindItemVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If Not grdFind.CurrentRow Is Nothing Then
                        If Not oComboBox Is Nothing Then
                            oComboBox.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value
                            oComboBox.Focus()
                        ElseIf Not oMaskedEditBox Is Nothing Then
                            oMaskedEditBox.Text = grdFind.CurrentRow.Cells("descricao").Value
                            oMaskedEditBox.Focus()
                        End If
                        Me.Dispose()
                    End If

                Case Keys.Escape
                    If Not oComboBox Is Nothing Then
                        oComboBox.Focus()
                    ElseIf Not oMaskedEditBox Is Nothing Then
                        oMaskedEditBox.Focus()
                    End If
                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFindItemVenda_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFind
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFind.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdFind.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdFind.GroupByBoxVisible = True
                grdFind.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_KeyDown(sender As Object, e As KeyEventArgs) Handles grdFind.KeyDown

        Try

            'Verifica o Tipo da Linha
            If grdFind.CurrentRow.RowType = RowType.Record Then

                Select Case e.KeyCode
                    Case Keys.Left
                        e.SuppressKeyPress = True
                        tabDados.SelectedTab = pagOrcamento
                        'Carrega Grid - Histórico de Orçamento
                        Call oClsCadProduto.LoadGridHistoricoOrcamento(grdOrcamento, grdFind.CurrentRow.Cells("codigo").Value)
                        grdOrcamento.Focus()
                    Case Keys.Right
                        e.SuppressKeyPress = True
                        tabDados.SelectedTab = pagVenda
                        'Carrega Grid - Histórico de Venda
                        Call oClsCadProduto.LoadGridHistoricoVenda(grdPedidoVenda, grdFind.CurrentRow.Cells("codigo").Value)
                        grdItensSimilares.Focus()
                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFind.RowDoubleClick

        Try

            If Not oComboBox Is Nothing Then
                oComboBox.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value
            ElseIf Not oMaskedEditBox Is Nothing Then
                oMaskedEditBox.Text = grdFind.CurrentRow.Cells("descricao").Value
            End If

            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFind.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFind.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFind.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFind.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_SelectionChanged(sender As Object, e As EventArgs) Handles grdFind.SelectionChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdFind.CurrentRow) = False Then

                'Carrega Grid - Produtos Similares
                'Call oClsCadProduto.LoadGridSimilar(grdItensSimilares, _
                '                                    iCodigoTipoItem, _
                '                                    sItemVenda, _
                '                                    sItemCompra, _
                '                                    sItemProducao, _
                '                                    sItemEstoque, _
                '                                    sItemAtivoFixo, _
                '                                    sInsumoProducao, _
                '                                    grdFind.CurrentRow.Cells("codigo").Value, _
                '                                    grdFind.CurrentRow.Cells("codigo_grupo_item").Value)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO SIMILAR :::"

    Private Sub btnConfigurarGridItensSimilares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridItensSimilares.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdItensSimilares
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdItensSimilares, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridItensSimilares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridItensSimilares.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdItensSimilares.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdItensSimilares.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdItensSimilares.GroupByBoxVisible = True
                grdItensSimilares.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridItensSimilares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridItensSimilares.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdItensSimilares)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdItensSimilares_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdItensSimilares.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdItensSimilares.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdItensSimilares_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdItensSimilares.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdItensSimilares, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdItensSimilares_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdItensSimilares.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdItensSimilares.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdItensSimilares_KeyDown(sender As Object, e As KeyEventArgs) Handles grdItensSimilares.KeyDown

        Try

            Select Case e.KeyCode
                Case Keys.Left
                    e.SuppressKeyPress = True
                    tabDados.SelectedTab = pagProduto
                    grdFind.Focus()
                Case Keys.Right
                    e.SuppressKeyPress = True
                    tabDados.SelectedTab = pagVenda
                    grdPedidoVenda.Focus()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub btnConfigurarGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridOrcamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrcamento
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdOrcamento, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridOrcamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdOrcamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdOrcamento.GroupByBoxVisible = True
                grdOrcamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridOrcamento.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamento.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamento, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamento.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_KeyDown(sender As Object, e As KeyEventArgs) Handles grdOrcamento.KeyDown

        Try

            'Verifica o Tipo da Linha
            If grdOrcamento.CurrentRow.RowType = RowType.Record Then

                Select Case e.KeyCode
                    Case Keys.Left
                        e.SuppressKeyPress = True
                        tabDados.SelectedTab = pagVenda
                        grdPedidoVenda.Focus()
                    Case Keys.Right
                        e.SuppressKeyPress = True
                        tabDados.SelectedTab = pagProduto
                        grdFind.Focus()
                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO DE VENDA :::"

    Private Sub btnConfigurarGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPedido.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoVenda
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPedidoVenda, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPedido.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoVenda.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedidoVenda.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedidoVenda.GroupByBoxVisible = True
                grdPedidoVenda.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPedido.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoVenda.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoVenda.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoVenda.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoVenda.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_KeyDown(sender As Object, e As KeyEventArgs) Handles grdPedidoVenda.KeyDown

        Try

            'Verifica o Tipo da Linha
            If grdPedidoVenda.CurrentRow.RowType = RowType.Record Then

                Select Case e.KeyCode
                    Case Keys.Left
                        e.SuppressKeyPress = True
                        tabDados.SelectedTab = pagProduto
                        grdItensSimilares.Focus()
                    Case Keys.Right
                        e.SuppressKeyPress = True
                        tabDados.SelectedTab = pagOrcamento
                        grdOrcamento.Focus()
                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindItemVenda_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo - Grid
            Call LoadComboGrid(grdFind, "codigo_classe", "sp_select_combo_cadastro_basico_classe " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdFind, "codigo_cultivar", "sp_select_combo_cadastro_basico_cultivar " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdFind, "codigo_peneira", "sp_select_combo_cadastro_basico_peneira " & goUsuario.iEmpresa)

            'Carrega Grid
            Call oClsCadProduto.LoadGridFind(grdFind, _
                                             iCodigoTipoItem, _
                                             sItemVenda, _
                                             sItemCompra, _
                                             sItemProducao, _
                                             sItemEstoque, _
                                             sItemAtivoFixo, _
                                             sInsumoProducao, _
                                             -1)

            If iCodigoTipoItem = CInt(TipoItem.produto) Then
                Me.Text = "Procurar Produto"
            ElseIf iCodigoTipoItem = CInt(TipoItem.servico) Then
                Me.Text = "Procurar Serviço"
            End If

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoProduto)
            Call ConfiguraGrid(grdItensSimilares, Formulario.CadastroBasicoProduto)
            Call ConfiguraGrid(grdOrcamento, Formulario.CadastroBasicoProduto)
            Call ConfiguraGrid(grdPedidoVenda, Formulario.CadastroBasicoProduto)

            'Seta Aba
            tabDados.SelectedTab = pagProduto

            'Seta Focu
            grdFind.Focus()
            grdFind.CurrentColumn = grdFind.RootTable.Columns.Item("descricao")
            System.Windows.Forms.SendKeys.Send("{UP 1}")

            'Seta Focu
            grdFind.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
