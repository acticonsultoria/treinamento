Imports Janus.Windows.GridEX

Public Class frmCadProdutoBOMPesquisar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmCadProdutoBOM As New clsFrmCadProdutoBOM
    Private lCodigoItem As Long
    Private sCodigoProduto As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoItem() As Long
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
        Get
            Return lCodigoItem
        End Get
    End Property

    Public Property CodigoProduto() As String
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
        Get
            Return sCodigoProduto
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadEspecieInsumoEncargosSociais_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub frmCadEspecieInsumoEncargosSociais_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagemEspecie_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagemPesquisar.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                Formulario.CadastroBasicoEncargos)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagemEspecie_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagemPesquisar.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.name, _
                                Formulario.CadastroBasicoProdutoBOM, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagemEspecie_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagemPesquisar.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     Formulario.CadastroBasicoEncargos, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelListagemRequisicao_Click(sender As Object, e As EventArgs) Handles btnExcelListagemRequisicao.Click

        Try

            ExportExcel(grdListagemPesquisar)

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
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadEspecieInsumoEncargosSociais_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Atualiza Grid
            ConfiguraGrid(grdListagemPesquisar, Formulario.CadastroBasicoProdutoBOM)

            oClsFrmCadProdutoBOM.LoadGridPesquisa(grdListagemPesquisar, _
                                                  lCodigoItem)

            txtCodigoItem.Text = sCodigoProduto

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

End Class