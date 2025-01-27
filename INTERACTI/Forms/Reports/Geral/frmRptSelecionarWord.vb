Imports Janus.Windows.GridEX

Public Class frmRptSelecionarWord

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsReportSelecionarWord As New clsFrmRptSelecionarWord
    Private iCodigoTipoDocumento As TipoDocumentoWord
    Private iCodigo As Integer
    Private sExtensao As String
    Private oArquivo As Byte()

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoTipoDocumento() As TipoDocumentoWord
        Set(ByVal value As TipoDocumentoWord)
            iCodigoTipoDocumento = value
        End Set
    End Property

    Public ReadOnly Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
    End Property

    Public ReadOnly Property Extensao() As String
        Get
            Return sExtensao
        End Get
    End Property

    Public ReadOnly Property Arquivo() As Byte()
        Get
            Return oArquivo
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmRptSelecionarWord_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Seta Váriavel
            iCodigo = 0

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRelatorio_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDocumento.RowDoubleClick

        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdDocumento.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdDocumento.CurrentColumn.Key

                Case "visualizar"
                    iCodigo = grdDocumento.CurrentRow.Cells("codigo").Value
                    sExtensao = grdDocumento.CurrentRow.Cells("extensao").Value
                    oArquivo = grdDocumento.CurrentRow.Cells("arquivo").Value
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Carrega Grid
            Call oClsReportSelecionarWord.LoadGrid(grdDocumento, iCodigoTipoDocumento)

            'Verifica se foi Carregado a Grid
            If grdDocumento.GetDataRows.Count = 0 Then
                iCodigo = -1
                Me.Dispose()
            End If

            'Configura Grid
            Call ConfiguraGrid(grdDocumento, Formulario.CadastroBasicoDocumentoWord)

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Focu
            grdDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class