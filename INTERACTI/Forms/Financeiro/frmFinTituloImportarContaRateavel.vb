Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmFinTituloImportarContaRateavel

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrCadContaRateavel As New clsUsrCadContaRateavel
    Private lCodigoTitulo As Long
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoTitulo() As Long
        Get
            Return lCodigoTitulo
        End Get
        Set(ByVal value As Long)
            lCodigoTitulo = value
        End Set
    End Property

    Public Property Formulario() As Integer
        Get
            Return iFormulario
        End Get
        Set(ByVal value As Integer)
            iFormulario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()
                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdImportarContaRateavel_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdImportarContaRateavel.RowDoubleClick

        Try

            Importar()

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

            ConfiguraGrid(grdImportarContaRateavel, iFormulario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadContaRateavel.LoadGridImportacao(grdImportarContaRateavel, _
                                                       txtDescricaoFiltro.Text.Trim)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Importar()

        Try

            Cursor.Current = Cursors.WaitCursor

            If MsgBox("Deseja importar essa conta rateável? A classificação anterior do título será excluída.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            oClsUsrCadContaRateavel.InsertClassificacao(lCodigoTitulo, _
                                                        grdImportarContaRateavel.GetValue("codigo"))

            Cursor.Current = Cursors.Default

            frmMain.Informacao(Mensagem.RegistroAlterado)

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class