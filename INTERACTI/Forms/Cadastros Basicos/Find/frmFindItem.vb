Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX

Public Class frmFindItem

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

    Private Sub frmFindItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If Not grdFind.CurrentRow Is Nothing Then
                        if isNothing(oMaskedEditBoxFind) = false then oMaskedEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
                        if isNothing(oEditBoxFind) = false then oEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
                        if isNothing(oComboBoxFind) = false then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value
                        Me.Dispose()
                    End If

                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFindItem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

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

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFind.RowDoubleClick

        Try

            'Seta Controles
            if isNothing(oMaskedEditBoxFind) = false then oMaskedEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
            if isNothing(oEditBoxFind) = false then oEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
            if isNothing(oComboBoxFind) = false then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call oClsCadProduto.LoadGridFind(grdFind, _
                                             iCodigoTipoItem, _
                                             sItemVenda, _
                                             sItemCompra, _
                                             sItemProducao, _
                                             sItemEstoque, _
                                             sItemAtivoFixo, _
                                             sInsumoProducao)

            If iCodigoTipoItem = CInt(TipoItem.produto) Then
                Me.Text = "Procurar Produto"
            ElseIf iCodigoTipoItem = CInt(TipoItem.servico) Then
                Me.Text = "Procurar Serviço"
            End If

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoProduto)

            'Seta Focu
            grdFind.Focus()
            grdFind.CurrentColumn = grdFind.RootTable.Columns.Item("descricao")
            System.Windows.Forms.SendKeys.Send("{UP 1}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
