Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class frmVenHistoricoProduto

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProduto As New clsUsrCadProduto
    Private lCodigoItem As Long
    Private sProduto As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoItem() As Long
        Get
            Return lCodigoItem
        End Get
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public Property Produto() As String
        Get
            Return sProduto
        End Get
        Set(ByVal value As String)
            sProduto = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenHistoricoProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    'Fecha o Controle
                    Me.Dispose()

                Case Keys.Down
                    If Not grdVendas.CurrentRow Is Nothing Then
                        If grdVendas.CurrentRow.RowType = Janus.Windows.GridEX.RowType.FilterRow Then
                            grdVendas.Row = 1
                        End If
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenHistoricoProduto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGridCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCompra.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCompras.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCompras.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCompras.GroupByBoxVisible = True
                grdCompras.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCompra.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCompras
            oForm.NomeFormulario = Formulario.ComercialPDV
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCompras, Formulario.ComercialPDV)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCompras.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCompras)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridVenda.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdVendas.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdVendas.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdVendas.GroupByBoxVisible = True
                grdVendas.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridVenda.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdVendas
            oForm.NomeFormulario = Formulario.ComercialPDV
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdVendas, Formulario.ComercialPDV)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridVendas.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdVendas)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdCompras_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCompras.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCompras.Name, _
                                     Formulario.ComercialPDV, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCompras_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCompras.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCompras, _
                                     Formulario.ComercialPDV)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCompras_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdCompras.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCompras.Name, _
                                          Formulario.ComercialPDV, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdVendas_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdVendas.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVendas.Name, _
                                     Formulario.ComercialPDV, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVendas_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdVendas.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVendas, _
                                     Formulario.ComercialPDV)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVendas_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdVendas.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdVendas.Name, _
                                          Formulario.ComercialPDV, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenHistoricoProduto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call ConfiguraGrid(grdVendas, Formulario.ComercialPDV)
            Call ConfiguraGrid(grdCompras, Formulario.ComercialPDV)

            'Carrega Grid - Vendas
            oClsCadProduto.LoadGridHistoricoVenda(grdVendas, _
                                                  lCodigoItem)

            'Carrega Grid - Compras
            oClsCadProduto.LoadGridHistoricoCompra(grdCompras, _
                                                   lCodigoItem)

            'Carrega Dados do Produto
            oClsCadProduto.LoadDadosProduto(lCodigoItem, _
                                            txtGrupoItem, _
                                            txtCodigo, _
                                            txtCodigoEAN, _
                                            txtCodigoNCM, _
                                            txtDescricao2)

            Me.Text &= sProduto

            'Seta Focu
            grdVendas.Focus()
            System.Windows.Forms.SendKeys.Send("{UP}")
            System.Windows.Forms.SendKeys.Send("{RIGHT 3}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class