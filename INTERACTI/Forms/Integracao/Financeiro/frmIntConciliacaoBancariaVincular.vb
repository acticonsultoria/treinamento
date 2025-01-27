Imports Janus.Windows.GridEX

Public Class frmIntConciliacaoBancariaVincular

#Region "::: VARIAVEIS :::"

    Private oGrid As gridex
    Private iCodigoBancoConta As Integer
    Private sArquivo As String

    Private oClsUsrIntConciliacaoBancaria As New clsUsrIntConciliacaoBancaria


#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Arquivo As String
        Set(value As String)
            sarquivo = value
        End Set
    End Property


    Public WriteOnly Property Grid() As gridex
        Set(ByVal value As gridex)
            ogrid = value
        End Set
    End Property

    Public WriteOnly Property CodigoBancoConta As Integer
        Set(value As Integer)
            icodigobancoconta = value
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

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

   
    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            If grdlistagem.currentcolumn.key = "vincular" Then

                Call Salvar()

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub Salvar()
        Try

            'Questiona o usuário
            If MsgBox("Deseja fazer o vínculo da NF?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Vínculo NF e Boleto") = vbNo Then Exit Sub


            'Vincular
            oClsUsrIntConciliacaoBancaria.VincularNF(iCodigoBancoConta, oGrid, grdListagem)

            ''Informa que foi atualizado
            'oGrid.SetValue("sistema", True)
            'oGrid.SetValue("sacado", grdListagem.GetValue("cliente"))
            'oGrid.SetValue("numero_documento", oGrid.GetValue("numero_documento_original"))

            Dim oDataSet As New DataSet


            oGrid.DataSource = Nothing

            'Carrega novamente
            Call oClsUsrIntConciliacaoBancaria.LoadArquivoRetornoCNAB400(iCodigoBancoConta, oGrid, sArquivo)

            'Informa sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Fecha o Formulário
            Me.Dispose()

        
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

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

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoVisaoPlanta)

            'Carrega Grid
            Call oClsUsrIntConciliacaoBancaria.LoadGridVinculo(grdListagem, oGrid)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

 
End Class