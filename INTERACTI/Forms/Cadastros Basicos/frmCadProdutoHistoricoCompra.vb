Imports Janus.Windows.GridEX

Public Class frmCadProdutoHistoricoCompra

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lCodigoItem As Long
    Private oClsUsrCadProduto As New clsUsrCadProduto

#End Region

#Region "::: PROPERTIE :::"
    Public Property CodigoItem() As Long
        Get
            Return lCodigoItem
        End Get
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property
    
#End Region

#Region "::: CONTROLES :::"

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

    
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Formulário
            'Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Ícone
            Me.Icon = frmMain.Icon

            oClsUsrCadProduto.LoadDadosHistorico(lCodigoItem:=lCodigoItem, _
                                                 txtCodigoItem:=txtCodigoCompras, _
                                                 txtCodigoItem2:=txtCodigo2Compras, _
                                                 txtDescricao:=txtDescricaoCompras, _
                                                 txtMarca:=txtMarcaCompras)

            oClsUsrCadProduto.LoadGridHistoricoCompra(grdOrcamentoGrupo, _
                                                      lCodigoItem)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

   

End Class