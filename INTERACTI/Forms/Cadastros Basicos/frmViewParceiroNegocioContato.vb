Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class frmViewParceiroNegocioContato

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio
    Private iCodigoParceiroNegocio As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoParceiroNegocio() As Integer
        Set(ByVal value As Integer)
            iCodigoParceiroNegocio = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmViewParceiroNegocioContato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    'Deleta Aba
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmViewParceiroNegocioContato_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContato
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContato.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContato.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContato.GroupByBoxVisible = True
                grdContato.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdContato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContato_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContato.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdContato.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdContato.CurrentColumn.Key

                Case "email" : Call EmailContato()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContato_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContato.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContato.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContato_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContato.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContato.Name, _
                                          Formulario.CadastroBasicoParceiroNegocio, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmViewParceiroNegocioContato_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Contato
            Call oClsCadParceiroNegocio.LoadGridContato(grdContato, iCodigoParceiroNegocio)

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)

            If (goDatabase.sInitialCatalog <> "INTERACTI_ASCON_PRD") Then

                grdContato.RootTable.Columns("cronograma").Visible = False
                grdContato.RootTable.Columns("financeiro").Visible = False
                grdContato.RootTable.Columns("faturamento").Visible = False
                grdContato.RootTable.Columns("marketing").Visible = False
                grdContato.RootTable.Columns("circular").Visible = False
                grdContato.RootTable.Columns("outros").Visible = False

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub EmailContato()

        Try

            'Verifica se o Contato possui E-mail
            If IsDBNull(grdContato.CurrentRow.Cells("email").Value) = False Then

                'Enviar E-mail
                Call EnviarEmail("", _
                                 grdContato.CurrentRow.Cells("email").Value, _
                                 "", _
                                 "", _
                                 "", _
                                 -1)

            Else
                'Informa o Usuário que o Contato não possui E-mail
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
