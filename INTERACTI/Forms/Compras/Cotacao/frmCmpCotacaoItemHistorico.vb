Imports Janus.Windows.GridEX

Public Class frmCmpCotacaoItemHistorico

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpCotacaoItemHistorico As New clsFrmCmpCotacaoItemHistorico
    Private sNumeroCotacao As String
    Private sNumeroRequisicao As String
    Private sDataCotacao As String
    Private sDataNecessidade As String
    Private sItem As String
    Private lCodigoCotacao As Long
    Private iCodigoCotacaoItem As Integer

#End Region

#Region "::: PROPERTIES :::"

    Public WriteOnly Property NumeroCotacao() As String
        Set(ByVal value As String)
            sNumeroCotacao = value
        End Set
    End Property

    Public WriteOnly Property NumeroRequisicao() As String
        Set(ByVal value As String)
            sNumeroRequisicao = value
        End Set
    End Property

    Public WriteOnly Property DataCotacao() As String
        Set(ByVal value As String)
            sDataCotacao = value
        End Set
    End Property

    Public WriteOnly Property DataNecessidade() As String
        Set(ByVal value As String)
            sDataNecessidade = value
        End Set
    End Property

    Public WriteOnly Property Item() As String
        Set(ByVal value As String)
            sItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoCotacao() As Long
        Set(ByVal value As Long)
            lCodigoCotacao = value
        End Set
    End Property

    Public WriteOnly Property CodigoCotacaoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoCotacaoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpCotacaoItemHistorico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpCotacaoItemHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdHistoricoItem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdHistoricoItem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdHistoricoItem.GroupByBoxVisible = True
                grdHistoricoItem.HideColumnsWhenGrouped = InheritableBoolean.True

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
            oForm.Grid = grdHistoricoItem
            oForm.NomeFormulario = Formulario.ComprasCotacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistoricoItem, Formulario.ComprasCotacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdHistoricoItem)

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

    Private Sub grdHistoricoitem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistoricoItem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistoricoitem, _
                                     Formulario.ComprasCotacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoitem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistoricoItem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistoricoitem.Name, _
                                     Formulario.ComprasCotacao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoitem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHistoricoItem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdHistoricoitem.Name, _
                                          Formulario.ComprasCotacao, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpCotacaoItemHistorico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasCotacao, gcPrint)

            'Carrega Controles
            txtNumeroCotacao.Text = sNumeroCotacao
            txtNumeroRequisicao.Text = sNumeroRequisicao
            txtDataCotacao.Text = IIf(IsDate(sDataCotacao), Format(CDate(sDataCotacao), "dd/MM/yyyy"), "")
            If IsDate(sDataNecessidade) Then txtDataNecessidade.Text = Format(CDate(sDataNecessidade), "dd/MM/yyyy") Else txtDataNecessidade.Text = ""
            txtItem.Text = sItem

            'Configura Grid
            Call ConfiguraGrid(grdHistoricoItem, Formulario.ComprasCotacao)

            'Carrega Grid
            oClsCmpCotacaoItemHistorico.LoadGrid(grdHistoricoItem, _
                                                 lCodigoCotacao, _
                                                 iCodigoCotacaoItem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class