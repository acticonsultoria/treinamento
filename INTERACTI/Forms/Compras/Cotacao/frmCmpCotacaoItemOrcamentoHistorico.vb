Imports Janus.Windows.GridEX

Public Class frmCmpCotacaoItemOrcamentoHistorico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpCotacao As New clsUsrCmpCotacao
    Private lCodigo As Long
    Private sCodigoItem As String
    Private sDescricao As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

    Public Property CodigoItem() As String
        Get
            Return sCodigoItem
        End Get
        Set(ByVal value As String)
            sCodigoItem = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpCotacaoItemOrcamentoHistorico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpCotacaoItemOrcamentoHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamentoHistorico.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdOrcamentoHistorico.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdOrcamentoHistorico.GroupByBoxVisible = True
                grdOrcamentoHistorico.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdOrcamentoHistorico)

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
            oForm.Grid = grdOrcamentoHistorico
            oForm.NomeFormulario = Formulario.ComprasCotacaoOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdOrcamentoHistorico, Formulario.ComprasCotacaoOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            'Congelar Coluna
            If cboCongelarColuna.SelectedIndex = -1 Then
                grdOrcamentoHistorico.FrozenColumns = 0
            Else
                grdOrcamentoHistorico.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoHistorico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoHistorico, _
                                     Formulario.ComprasCotacaoOrcamento)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdOrcamentoHistorico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoHistorico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoHistorico.Name, _
                                     Formulario.ComprasCotacaoOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoHistorico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamentoHistorico.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamentoHistorico.Name, _
                                          Formulario.ComprasCotacaoOrcamento, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpCotacaoItemOrcamentoHistorico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdOrcamentoHistorico)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasCotacaoOrcamento, gcPrint)

            'Carrega Controles
            txtCodigoItem.Text = sCodigoItem
            txtDescricao.Text = sDescricao

            'Configura Grid
            Call ConfiguraGrid(grdOrcamentoHistorico, Formulario.ComprasCotacaoOrcamento)

            'Carrega Grid
            Call oClsCmpCotacao.LoadGridHistoricoOrcamento(grdOrcamentoHistorico, lCodigo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class