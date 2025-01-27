Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoCopiarRoteiroOP

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
    Private oCurrentRow As GridEXRow
    Private lCodigo As Long
    Private bExisteRegistro As Boolean
    Private bOperacaoRealizada As Boolean

#End Region

#Region "::: PROPERTY :::"

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

    Public Property ExisteRegistro() As Boolean
        Get
            Return bExisteRegistro
        End Get
        Set(ByVal value As Boolean)
            bExisteRegistro = value
        End Set
    End Property

    Public Property OperacaoRealizada() As Boolean
        Get
            Return bOperacaoRealizada
        End Get
        Set(ByVal value As Boolean)
            bOperacaoRealizada = value
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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            'If bExisteRegistro = True Then
            '    If MsgBox("Deseja sobrescrever o roteiro existente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then
            '        oClsUsrPrdProducaoManual.DeleteRoteiroAll(lCodigo)
            '    End If
            'End If

            ImportarRoteiro()

            bOperacaoRealizada = True

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged

        Try
            'Verifica o Status da Linha
            If e.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = e.Row

            Else
                oCurrentRow = Nothing
            End If

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

           
            dtpDataEmissaoInicioFiltro.Value = "01/" & Month(Now) & "/" & Year(Now) : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, dtpDataEmissaoInicioFiltro.Value)) : dtpDataEmissaoTerminoFiltro.Checked = False

            ConfigurarBuiltInTextsGrid(grdListagem)

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ImportarRoteiro()

        Try

            If grdListagem.GetCheckedRows.Count <= 0 Then
                MsgBox("Selecione alguma linha.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            For Each oRow As GridEXRow In grdListagem.GetCheckedRows

                oClsUsrPrdProducaoManual.ImportarRoteiroOP(lCodigo, _
                                                           oRow.Cells("codigo").Value)

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridImportarRoteiroOP(grdListagem,
                                                               lCodigo,
                                                               txtOrdemProducao.Text.Trim,
                                                               txtDescricaoProduto.Text.Trim,
                                                               IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value),
                                                               IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class