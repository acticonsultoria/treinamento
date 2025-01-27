Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFatEmissaoRemessaIndustrializacao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oclsUsrFatEmissaoRemessaIndustrializacao As New clsUsrFatEmissaoRemessaIndustrializacao
    Private iFormulario As Integer
#End Region

#Region "::: CONTROLES :::"

    Private Sub btnGerarNotaFiscal_Click(sender As Object, e As EventArgs) Handles btnGerarNotaFiscal.Click
        Try
            If Validacao = False Then Exit Sub

            GerarNotaFiscal()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            Call LoadGrid()
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


            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario


            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)


            'Carrega Combo
            Call LoadCombo(cboDestinatarioFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            'Carrega Grid de Pedido de Venda
            Call oclsUsrFatEmissaoRemessaIndustrializacao.LoadGrid(grdListagem, _
                                                                   txtOrdemProducaoFiltro.Text, _
                                                                   IIf(cboDestinatarioFiltro.SelectedIndex = -1, -1, cboDestinatarioFiltro.SelectedValue), _
                                                                   txtProdutoFiltro.Text)

            'Atualiza Grid
            grdListagem.Refresh()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean
        Try

            Validacao = False

            If grdListagem.GetCheckedRows.Count = 0 Then
                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Function
            End If

            For Each oRow In grdListagem.GetCheckedRows

                If Not IsDBNull(oRow.Cells.Item("nota_fiscal").Value) Then

                    frmMain.Informacao("a OP [" & oRow.Cells.Item("ordem_producao").Value & " ] já possui uma nota fiscal de remessa!", Color.Red)
                    Exit Function

                End If

            Next

            Validacao = True


        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub GerarNotaFiscal()

        Try

            If MsgBox("Deseja gerar as notas fiscais de remessa para industrialização?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Gerar Nota Fiscal de Remessa") = vbNo Then Exit Sub

            'Gera as notas fiscais
            oclsUsrFatEmissaoRemessaIndustrializacao.GerarNotaFiscal(grdListagem)

            'Carrega a listagem novamente
            LoadGrid()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


  
End Class