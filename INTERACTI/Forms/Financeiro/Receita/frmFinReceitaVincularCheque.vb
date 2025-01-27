Imports System.Threading
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Public Class frmFinReceitaVincularCheque

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaVincularCheque As New clsUsrFinReceitaLancamento
    Private dValorDevido As Double
    Private iCodigoTipoDocumentoPagamento As Integer
    Private iCodigoContaBancaria As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoContaBancaria() As Integer
        Get
            Return iCodigoContaBancaria
        End Get
        Set(ByVal value As Integer)
            iCodigoContaBancaria = value
        End Set
    End Property

    Public Property CodigoTipoDocumentoPagamento() As Integer
        Get
            Return iCodigoTipoDocumentoPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoDocumentoPagamento = value
        End Set
    End Property

    Public Property ValorDevido() As Double
        Get
            Return dValorDevido
        End Get
        Set(ByVal value As Double)
            dValorDevido = value
        End Set
    End Property
     
#End Region

#Region "::: CONTROLES :::"

    Private Sub grdListagem_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged
        Try
            VerificarSaldo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmFinReceitaVincularCheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

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

    Private Sub frmFinReceitaVincularCheque_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub frmFinReceitaVincularCheque_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados do Registro
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub VerificarSaldo()
        Try
            Limpar()
            txtValorDevido.Value = dValorDevido

            Dim dValor As Double = 0
            Dim dDiferenca As Double = 0
            'Percorre os registros
            For i As Integer = 0 To grdListagem.RecordCount - 1

                grdListagem.Row = i
                If grdListagem.CurrentRow.CheckState = RowCheckState.Checked Then

                    If txtSaldoDevido.Value < txtValorDevido.Value Then

                        If txtValorDevido.Value - dValor >= (grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")) Then

                            grdListagem.SetValue("valor_baixar", (grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")))
                            grdListagem.SetValue("valor_disponivel", ((grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")) - grdListagem.GetValue("valor_baixar")))

                            dValor = dValor + (grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado"))

                            txtSaldoDevido.Value = txtValorDevido.Value - dValor

                        Else

                            dDiferenca = txtValorDevido.Value - txtSaldoDevido.Value

                            grdListagem.SetValue("valor_baixar", txtValorDevido.Value - dValor)
                            grdListagem.SetValue("valor_disponivel", ((grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")) - grdListagem.GetValue("valor_baixar")))

                            dValor = dValor + (txtValorDevido.Value - dValor)

                            txtSaldoDevido.Value = txtValorDevido.Value - dValor

                        End If

                    End If
                End If

                grdListagem.Refresh()

            Next


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Limpar()
        Try

            For i As Integer = 0 To grdlistagem.recordcount - 1

                grdlistagem.row = i

                grdListagem.SetValue("valor_baixar", DBNull.Value)


            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFinReceitaVincularCheque_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            oClsFinReceitaVincularCheque.LoadGridCheque(grdListagem)

            txtValorDevido.Value = dValorDevido

            Dim dValor As Double = 0
            Dim dDiferenca As Double = 0

            ''Percorre os registros
            'For i As Integer = 0 To grdListagem.RecordCount - 1

            '    grdListagem.Row = i

            '    If txtSaldoDevido.Value < txtValorDevido.Value Then

            '        If txtValorDevido.Value - dValor >= (grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")) Then

            '            grdListagem.SetValue("valor_baixar", (grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")))
            '            grdListagem.SetValue("valor_disponivel", ((grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")) - grdListagem.GetValue("valor_baixar")))

            '            dValor = dValor + (grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado"))

            '            txtSaldoDevido.Value = txtValorDevido.Value - dValor

            '        Else

            '            dDiferenca = txtValorDevido.Value - txtSaldoDevido.Value

            '            grdListagem.SetValue("valor_baixar", txtValorDevido.Value - dValor)
            '            grdListagem.SetValue("valor_disponivel", ((grdListagem.GetValue("valor_cheque") - grdListagem.GetValue("valor_baixado")) - grdListagem.GetValue("valor_baixar")))

            '            dValor = dValor + (txtValorDevido.Value - dValor)

            '            txtSaldoDevido.Value = txtValorDevido.Value - dValor

            '        End If

            '    End If

            '    grdListagem.Refresh()

            'Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsFinReceitaVincularCheque.DeleteCheque()

            'Percorre os registros
            For i As Integer = 0 To grdListagem.RecordCount - 1

                grdListagem.Row = i

                If grdListagem.CurrentRow.CheckState = RowCheckState.Checked Then

                    If Not IsDBNull(grdListagem.GetValue("valor_baixar")) Then


                        If grdListagem.GetValue("valor_baixar") > 0 Then
                            oClsFinReceitaVincularCheque.InsertCheque(grdListagem.GetRow.Cells.Item("numero").Value, _
                                                                      grdListagem.GetRow.Cells.Item("codigo_cliente").Value, _
                                                                      grdListagem.GetRow.Cells.Item("data").Value, _
                                                                      IIf(IsDBNull(grdListagem.GetRow.Cells.Item("data_pre_datado").Value) = True, "", grdListagem.GetRow.Cells.Item("data_pre_datado").Value), _
                                                                      grdListagem.GetRow.Cells.Item("valor_cheque").Value, _
                                                                      grdListagem.GetRow.Cells.Item("valor_baixar").Value, _
                                                                      grdListagem.GetRow.Cells.Item("descricao").Value, _
                                                                      iCodigoContaBancaria)
                        End If
                    End If
                End If
            Next

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            Me.Dispose()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            ''Seta Parametros
            'Call oClsFinReceitaInclusaoCheque.LoadGrid(grdListagem, _
            '                                           IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
            '                                           txtNumeroFiltro.Text.Trim, _
            '                                           txtDescricaoFiltro.Text.Trim, _
            '                                           dtpDataFiltro.Value, _
            '                                           IIf(dtpDataPreDatadoFiltro.Checked = True, dtpDataPreDatadoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
     
#End Region

End Class