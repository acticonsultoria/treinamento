Imports Janus.Windows.GridEX
Imports System.Text.RegularExpressions

Public Class frmVenOrcamentoObservacao

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private lCodigoOrcamento As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoOrcamento() As Long
        Get
            Return lCodigoOrcamento
        End Get
        Set(ByVal value As Long)
            lCodigoOrcamento = value
        End Set
    End Property



#End Region

#Region "::: CONTROLES :::"

    
    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            Salvar()

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

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            Dim sRichText As String = LoadCodigo("sp_select_venda_orcamento_observacao_rtf " & goUsuario.iEmpresa & "," & lCodigoOrcamento)

            'Seta o valor
            RchTxt.Rtf = sRichText

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Atualiza o valor
            oClsUsrVenOrcamentoLegado.UpdateObservacao(lCodigoOrcamento, _
                                                        RchTxt)

            'Finaliza o formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region
   
End Class