Imports Janus.Windows.GridEX

Public Class frmLogAlteracao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sTabela As String
    Private sCodigo As String
    Private sCodigoLinha As String = ""
    Private oClsFrmLogAlteracao As New clsFrmLogAlteracao

#End Region

#Region "::: PROPERTIE :::"

    Public Property Tabela() As String
        Get
            Return sTabela
        End Get
        Set(ByVal value As String)
            sTabela = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return sCodigo
        End Get
        Set(ByVal value As String)
            sCodigo = value
        End Set
    End Property

    Public Property CodigoLinha() As String
        Get
            Return sCodigoLinha
        End Get
        Set(ByVal value As String)
            sCodigoLinha = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdHistorico.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdHistorico.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdHistorico.GroupByBoxVisible = True
                grdHistorico.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdHistorico
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.LogAlteracao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            ExportExcel(grdHistorico)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistorico.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdHistorico, _
                                Formulario.LogAlteracao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistorico.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdHistorico.Name, _
                                Formulario.LogAlteracao, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdHistorico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHistorico.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(grdHistorico.Name, _
                                     Formulario.LogAlteracao, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            ConfiguraGrid(grdHistorico, Formulario.LogAlteracao)

            oClsFrmLogAlteracao.LoadGrid(oGrid:=grdHistorico, _
                                         sTabela:=sTabela, _
                                         sCodigo:=sCodigo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
             TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

End Class