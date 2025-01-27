Imports Janus.Windows.GridEX

Public Class frmFinReceitaVincularNF

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFinReceitaLancamento As New clsUsrFinReceitaLancamento
    Private iCodigoTituloCapa As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTituloCapa() As Integer
        Get
            Return iCodigoTituloCapa
        End Get
        Set(ByVal value As Integer)
            iCodigoTituloCapa = value
        End Set
    End Property


#End Region

#Region "::: CONTROLES :::"
    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        Try

            Call Inserir()
            Me.Dispose()


        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub frmVenPedidoCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Execute : Me.Dispose()

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor


                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add



            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenPedidoCancelar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenPedidoCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadCombo(cboNotaFiscal, "sp_select_combo_faturamento_nfse " & goUsuario.iEmpresa)

            'Seta Tamanho / Posição do Formulário
            'Me.Location = New Point(0, 23)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Inserir()

        Try
            If ValidaCampo(cboNotaFiscal, lblNotaFiscal) = False Then
                Exit Sub
            End If

            oClsFinReceitaLancamento.UpdateVinculoNF(iCodigoTituloCapa, cboNotaFiscal.SelectedValue)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


#End Region






    Private Sub cboNotaFiscal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNotaFiscal.SelectedIndexChanged
        Try
            If cboNotaFiscal.SelectedIndex = -1 Then Exit Sub

            txtClienteFiltro.Text = LoadCodigo("sp_select_dados_faturamento_nfse_cliente " & goUsuario.iEmpresa & ", " & cboNotaFiscal.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class