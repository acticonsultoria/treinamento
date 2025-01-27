Imports Janus.Windows.GridEX

Public Class frmCfgGrid

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCfgGrid As New clsFrmCfgGrid
    Private oGrid As GridEX
    Private sNomeFormulario As String

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Grid() As GridEX
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

    Public WriteOnly Property NomeFormulario() As String
        Set(ByVal value As String)
            sNomeFormulario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCfgGrid_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub frmCfgGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode
                Case Keys.Escape : Me.Dispose()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Salvar Dados da Grid
            SalvarGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCfgGrid_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call ConfiguraGrid(grdListagem, "CONFIGURAÇÃO")

            'Carrega Grid
            oClsCfgGrid.LoadGrid(grdListagem, oGrid, sNomeFormulario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub SalvarGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Passa Parametros
            oClsCfgGrid.NomeGrid = oGrid.Name
            oClsCfgGrid.NomeFormulario = sNomeFormulario
            'Deleta Dados
            Call oClsCfgGrid.Delete()
            'Salva Dados da Grid
            Call oClsCfgGrid.Salvar(grdListagem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class