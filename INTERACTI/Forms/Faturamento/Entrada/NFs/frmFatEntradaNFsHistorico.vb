Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFsHistorico

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lNotaFiscal As Long
    Private sSerie As String
    Private sDataEmissao As String
    Private sPrestador As String
    Private sCodigoVerificacao As String
    Private lCodigoNFSCapa As Long
    Private oClsFatEntradaNFs As New clsUsrFatEntradaNFs

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NotaFiscal() As Long
        Set(ByVal value As Long)
            lNotaFiscal = value
        End Set
    End Property

    Public WriteOnly Property Serie() As String
        Set(ByVal value As String)
            sSerie = value
        End Set
    End Property

    Public WriteOnly Property DataEmissao() As String
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public WriteOnly Property Prestador() As String
        Set(ByVal value As String)
            sPrestador = value
        End Set
    End Property

    Public WriteOnly Property CodigoVerificacao() As String
        Set(ByVal value As String)
            sCodigoVerificacao = value
        End Set
    End Property

    Public WriteOnly Property CodigoNFSCapa() As Long
        Set(ByVal value As Long)
            lCodigoNFSCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFsHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFatEntradaNFsHistorico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdHistorico
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFs
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.FaturamentoEntradaNFs)

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

    Private Sub grdHistoricoItem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistorico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico, _
                                     Formulario.FaturamentoEntradaNFs)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistoricoItem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistorico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico.Name, _
                                     Formulario.FaturamentoEntradaNFs, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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

            'Carrega Dados da Nota Fiscal
            txtNotaFiscal.Text = Format(lNotaFiscal, "000000000")
            txtSerie.Text = sSerie
            txtDataEmissao.Text = sDataEmissao
            txtPrestador.Text = sPrestador
            txtCodigoVerificacao.Text = sCodigoVerificacao

            'Carrega Grid
            Call oClsFatEntradaNFs.LoadGridHistorico(grdHistorico, _
                                                     lCodigoNFSCapa)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.FaturamentoEntradaNFs)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class