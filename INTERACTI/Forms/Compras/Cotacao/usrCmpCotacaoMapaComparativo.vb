Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class usrCmpCotacaoMapaComparativo

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpCotacao As New clsUsrCmpCotacao
   
#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCmpCotacaoMapaComparativo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCmpCotacaoMapaComparativoMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCmpCotacaoMapaComparativoMaterial_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: APROVAÇÃO :::"

    Private Sub btnConfigurarGridAprovacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridAprovacao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdAprovacao
            oForm.NomeFormulario = Formulario.ComprasCotacaoAprovarOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdAprovacao, Formulario.ComprasCotacaoAprovarOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAprovarOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovarOrcamento.Click

        Try

            'Verifica se o Usuário deseja Aprovar a Cotação
            If MsgBox("Deseja Alterar a Cotação: " & cboNumeroCotacaoAprovacao.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Aprova Cotação
                oClsCmpCotacao.AprovarCotacao(cboNumeroCotacaoAprovacao.SelectedValue, _
                                              txtDescritivoOrcamento.Text.Trim, _
                                              "", _
                                              "ALTERADA A APROVAÇÃO DA COTAÇÃO", _
                                              grdAprovacao)

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNumeroCotacaoAprovacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroCotacaoAprovacao.SelectedIndexChanged

        Try

            'Verifica se foi selecionado Algum Registro
            If cboNumeroCotacaoAprovacao.SelectedIndex = -1 Then

                'Limpa Controles
                txtDataCotacaoAprovacao.Text = ""
                cboFormaAnaliseOrcamento.SelectedIndex = -1
                grdAprovacao.DataSource = Nothing
                grdVencedores.DataSource = Nothing

            Else

                'Carrega Dados da Cotação
                Call oClsCmpCotacao.LoadDadosCotacao(cboNumeroCotacaoAprovacao.SelectedValue, _
                                                     txtDataCotacaoAprovacao, _
                                                     txtDescritivoOrcamento)

                'Carrega Grid de Aprovação
                Call oClsCmpCotacao.LoadGridCotacaoAprovacao(grdAprovacao, _
                                                             cboNumeroCotacaoAprovacao.SelectedValue)

                'Carrega Grid de Vencedor
                Call oClsCmpCotacao.LoadGridVencedorAprovacao(grdVencedores, _
                                                              grdAprovacao.GetCheckedRows)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFormaAnaliseOrcamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaAnaliseOrcamento.SelectedIndexChanged

        Try

            'Desmarca melhor Compra
            For Each oRow As GridEXRow In grdAprovacao.GetCheckedRows
                oRow.CheckState = RowCheckState.Unchecked
            Next

            'Atualiza a Grid
            grdAprovacao.Refresh()

            'Verifica se foi Selecionado alguma Forma de Análise
            If cboFormaAnaliseOrcamento.SelectedIndex <> -1 Then

                Call oClsCmpCotacao.LoadGridCotacaoAprovacao(grdAprovacao, _
                                                             cboNumeroCotacaoAprovacao.SelectedValue, _
                                                             cboFormaAnaliseOrcamento.SelectedValue)

                'Carrega Grid de Vencedor
                Call oClsCmpCotacao.LoadGridVencedorAprovacao(grdVencedores, _
                                                              grdAprovacao.GetCheckedRows)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAprovacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAprovacao, _
                                     Formulario.ComprasCotacaoAprovarOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdAprovacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAprovacao.Name, _
                                     Formulario.ComprasCotacaoAprovarOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdAprovacao.RowCheckStateChanged

        Try

            'Váriaveis Locais
            Dim lCodigoCotacao = grdAprovacao.CurrentRow.Cells("codigo_cotacao").Value
            Dim iCodigoCotacaoItem = grdAprovacao.CurrentRow.Cells("codigo_cotacao_item").Value
            Dim iCodigoCotacaoFornecedor = grdAprovacao.CurrentRow.Cells("codigo_cotacao_fornecedor").Value
            Dim oRow As GridEXRow

            'Desmarca a outra opção            
            For Each oRow In grdAprovacao.GetDataRows
                If oRow.Cells("codigo_cotacao").Value = lCodigoCotacao And _
                    oRow.Cells("codigo_cotacao_item").Value = iCodigoCotacaoItem And _
                    oRow.Cells("codigo_cotacao_fornecedor").Value <> iCodigoCotacaoFornecedor Then
                    oRow.CheckState = RowCheckState.Unchecked
                End If
            Next

            'Atualiza a Grid
            grdAprovacao.Refresh()

            'Carrega Grid de Vencedor
            Call oClsCmpCotacao.LoadGridVencedorAprovacao(grdVencedores, _
                                                          grdAprovacao.GetCheckedRows)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpCotacaoMapaComparativo_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboNumeroCotacaoAprovacao, "sp_select_combo_compras_cotacao_status_aprovacao " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)
            Call LoadCombo(cboFormaAnaliseOrcamento, "sp_select_combo_static_forma_analise_orcamento", False)

            'Configura Grid
            Call ConfiguraGrid(grdAprovacao, Formulario.ComprasCotacaoAprovarOrcamento)

            'Seta Focu
            cboNumeroCotacaoAprovacao.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

End Class
