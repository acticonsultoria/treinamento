Imports Janus.Windows.GridEX

Public Class frmCmpPedidoHistoricoPreco

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lCodigoProduto As Long
    Private oClsCadProduto As New clsUsrCadProduto

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoProduto() As Long
        Set(ByVal value As Long)
            lCodigoProduto = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoHistoricoPreco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoHistoricoPreco_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdHistoricoPrecoCompra.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdHistoricoPrecoCompra.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdHistoricoPrecoCompra.GroupByBoxVisible = True
                grdHistoricoPrecoCompra.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdHistoricoPrecoCompra
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistoricoPrecoCompra, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdHistoricoPrecoCompra)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoPrecoCompra_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistoricoPrecoCompra, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoPrecoCompra_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistoricoPrecoCompra.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoPrecoCompra_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHistoricoPrecoCompra.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdHistoricoPrecoCompra.Name, _
                                          Formulario.CadastroBasicoProduto, _
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

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            
            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoHistoricoPreco_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            dtpDataInicio.Value = DateAdd(DateInterval.Year, -1, Now.Date) : dtpDataInicio.Checked = True
            dtpDataTermino.Value = Now.Date : dtpDataTermino.Checked = True

            'Configura Grid
            Call ConfiguraGrid(grdHistoricoPrecoCompra, Formulario.CadastroBasicoProduto)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid() Handles dtpDataInicio.ValueChanged, _
                                   dtpDataTermino.ValueChanged, _
                                   dtpDataInicio.CheckedChanged, _
                                   dtpDataTermino.CheckedChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsCadProduto.LoadGridHistoricoPrecoCompra(grdHistoricoPrecoCompra, _
                                                             lCodigoProduto, _
                                                             IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                             IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""))

            'Carrega Gráfico
            Call oClsCadProduto.LoadGraficoHistoricoPrecoCompra(chrMain, _
                                                                lCodigoProduto, _
                                                                IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                                IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
