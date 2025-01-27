Imports Janus.Windows.GridEX

Public Class frmCmpRequisicaoHistorico
#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpRequisicao As New clsUsrCmpRequisicao
    Private sNumeroRequisicao As String
    Private sRequisitante As String
    Private sCodigo As String
    Private sDescricao As String
    Private lCodigoRequisicao As Long
    Private iCodigoRequisicaoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroRequisicao() As String
        Get
            Return sNumeroRequisicao
        End Get
        Set(ByVal value As String)
            sNumeroRequisicao = value
        End Set
    End Property

    Public Property Requisitante() As String
        Get
            Return sRequisitante
        End Get
        Set(ByVal value As String)
            sRequisitante = value
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

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property CodigoRequisicao() As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public Property CodigoRequisicaoItem() As Integer
        Get
            Return iCodigoRequisicaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoRequisicaoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpRequisicaoHistorico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpRequisicaoHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdHistorico
            oForm.NomeFormulario = Formulario.ComprasRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdHistorico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico, _
                                     Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico.Name, _
                                     Formulario.ComprasRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdHistorico.Name, _
                                          Formulario.ComprasRequisicao, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpRequisicaoHistorico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Dados da Nota Fiscal
            txtNumeroRequisicao.Text = sNumeroRequisicao
            txtRequisitante.Text = sRequisitante
            txtCodigo.Text = sCodigo
            txtDescricao.Text = sDescricao

            'Carrega Grid
            Call oClsCmpRequisicao.LoadGridHistorico(grdHistorico, lCodigoRequisicao, iCodigoRequisicaoItem)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.ComprasRequisicao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region
End Class