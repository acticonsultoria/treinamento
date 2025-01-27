Imports Janus.Windows.GridEX

Public Class frmCadParceiroNegocioCRMComentario

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio

    'Váriaveis
    Private sCliente As String
    Private sAssunto As String
    Private iCodigo As Integer
    Private iCodigoCRM As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Cliente() As String
        Get
            Return sCliente
        End Get
        Set(ByVal value As String)
            sCliente = value
        End Set
    End Property

    Public Property Assunto() As String
        Get
            Return sAssunto
        End Get
        Set(ByVal value As String)
            sAssunto = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property CodigoCRM() As Integer
        Get
            Return iCodigoCRM
        End Get
        Set(ByVal value As Integer)
            iCodigoCRM = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadParceiroNegocioCRMComentario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadParceiroNegocioCRMComentario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdHistorico
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdHistorico)

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

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistorico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistorico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdHistorico.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdHistorico.Name, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadParceiroNegocioCRMComentario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            Call oClsCadParceiroNegocio.LoadGridCRMComentario(grdHistorico, _
                                                              iCodigo, _
                                                              iCodigoCRM)

            'Carrega Controles
            txtCliente.Text = sCliente
            txtAssunto.Text = sAssunto

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.CadastroBasicoParceiroNegocio)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class