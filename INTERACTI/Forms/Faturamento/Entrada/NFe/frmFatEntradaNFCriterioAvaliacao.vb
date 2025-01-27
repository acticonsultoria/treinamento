Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFCriterioAvaliacao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF
    Private lCodigoEntradaCapa As Long
    Private iCodigoCriterioAvaliacao As Integer

#End Region

#Region "::: PROPERTIE :::"



    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public WriteOnly Property CodigoCriterioAvaliacao As Integer
        Set(value As Integer)
            iCodigoCriterioAvaliacao = value
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
        Call ConfigurarFormulario()

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


    Private Sub grdOpcao_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOpcao.RowDoubleClick
        Try

            If grdOpcao.CurrentColumn.Key = "inserir" Then

                oClsFatEntradaNF.InsertOpcaoCriterioAvaliacao(lCodigoEntradaCapa, _
                                                              iCodigoCriterioAvaliacao, _
                                                              grdOpcao.GetValue("codigo"), _
                                                              txtObservacao.Text)

                Me.Dispose()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)


            'Carrega Grid
            oClsFatEntradaNF.LoadGridCriterioAvaliacaoOpcao(grdOpcao, lCodigoEntradaCapa, iCodigoCriterioAvaliacao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class