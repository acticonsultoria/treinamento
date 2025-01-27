Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class frmFinEditarDuplicata

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFrmFinEditarDuplicata As New clsFrmFinEditarDuplicata
    Private lCodigoTituloCapa As Long
    Private iNumeroParcela As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinEditarDuplicata_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Salva Parcela
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorCorrigido() Handles txtValorParcela.ValueChanged

        Try

            'Calcula o Valor do Documento Corrigido
            txtValorDocumentoCorrigido.Value = txtValorDocumento.Value - txtValorParcela.Tag + txtValorParcela.Value

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

            'Seta Parametros
            oClsFrmFinEditarDuplicata.CodigoTituloCapa = lCodigoTituloCapa
            oClsFrmFinEditarDuplicata.NumeroParcela = iNumeroParcela

            'Carrega Dados da Duplicata
            Call LoadDadosDuplicata()

            'Seta Focu
            dtpDataVencimento.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadDadosDuplicata()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFrmFinEditarDuplicata.LoadDados(txtNumeroDocumento, _
                                                txtSerieDocumento, _
                                                txtValorDocumento, _
                                                dtpDataVencimento, _
                                                txtValorParcela)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFrmFinEditarDuplicata.DataVencimentoParcela = dtpDataVencimento.Value
            oClsFrmFinEditarDuplicata.ValorParcela = txtValorParcela.Value
            oClsFrmFinEditarDuplicata.ValorCorrigidoDocumento = txtValorDocumentoCorrigido.Value

            'Atualiza Registro
            oClsFrmFinEditarDuplicata.Update()

            'Informa o Usuário sobre o sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroAlterado)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
