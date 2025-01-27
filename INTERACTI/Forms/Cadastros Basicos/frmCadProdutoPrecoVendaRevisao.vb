Imports Janus.Windows.GridEX

Public Class frmCadProdutoPrecoVendaRevisao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProdutoPrecoVenda As New clsUsrCadProdutoPrecoVenda

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadProdutoPrecoVendaRevisao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadProdutoPrecoVendaRevisao_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Adiciona Controle
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub trvMain_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles trvMain.AfterCheck

        Try

            For Each oNode As TreeNode In e.Node.Nodes
                oNode.Checked = e.Node.Checked
            Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAjusteCustoTeorico_Click(sender As Object, e As EventArgs) Handles btnAjusteCustoTeorico.Click

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Atualiza Custo Teórico
            For Each oRow As GridEXRow In grdListagem.GetDataRows
                grdListagem.Row = oRow.RowIndex
                Call UpdateRegistroGrid(grdListagem, "codigo = " & oRow.Cells("codigo").Value, "custo_teorico", oRow.Cells("custo_teorico").Value * (1 + txtAjusteCustoTeorico.Value))
            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAjustePrecoCompra_Click(sender As Object, e As EventArgs) Handles btnAjustePrecoCompra.Click

        Try
            
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Atualiza Custo Teórico
            For Each oRow As GridEXRow In grdListagem.GetDataRows
                Call UpdateRegistroGrid(grdListagem, "codigo = " & oRow.Cells("codigo").Value, "preco_compra", oRow.Cells("preco_compra").Value * (1 + txtAjustePrecoCompra.Value))
            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAjustePrecoIdeal_Click(sender As Object, e As EventArgs) Handles btnAjustePrecoIdeal.Click

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Atualiza Custo Teórico
            For Each oRow As GridEXRow In grdListagem.GetDataRows
                grdListagem.Row = oRow.RowIndex
                Call UpdateRegistroGrid(grdListagem, "codigo = " & oRow.Cells("codigo").Value, "preco_venda", oRow.Cells("preco_venda").Value * (1 + txtAjustePrecoIdeal.Value))
            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAjustePrecoMinimo_Click(sender As Object, e As EventArgs) Handles btnAjustePrecoMinimo.Click

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Atualiza Custo Teórico
            For Each oRow As GridEXRow In grdListagem.GetDataRows
                grdListagem.Row = oRow.RowIndex
                Call UpdateRegistroGrid(grdListagem, "codigo = " & oRow.Cells("codigo").Value, "preco_minimo", oRow.Cells("preco_minimo").Value * (1 + txtAjustePrecoMinimo.Value))
            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadProdutoPrecoVendaRevisao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            
            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Controles
            dtpDataInicio.Value = Now.Date

            'Carrega TreeView
            Call LoadTreeView()

            'Carrega Combo
            Call LoadCombo(cboRevisaoBase, "sp_select_combo_cadastro_basico_produto_preco_venda_revisao " & goUsuario.iEmpresa)
            Call LoadCombo(cboRevisao, "sp_select_combo_cadastro_basico_produto_preco_venda_revisao " & goUsuario.iEmpresa)
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)

            'Carrega Combo
            grpFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadTreeView()

        Try

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Váriaveis Locais
            Dim oClsCadGrupoItem As New clsUsrCadGrupoItem

            oClsCadGrupoItem.LoadTreeViewCheckedVenda(trvMain, "")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona Controle
            Call oClsCadProdutoPrecoVenda.InsertRevisao(grdListagem, _
                                                        cboRevisao.Text.Trim, _
                                                        cboRevisaoBase.SelectedValue, _
                                                        dtpDataInicio.Value, _
                                                        "")

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Revisão
            If ValidaCampo(cboRevisao, lblRevisao) = False AndAlso cboRevisao.Text.Trim = "" Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Revisão Base
            'If ValidaCampo(cboRevisaoBase, lblRevisaoBase) = False Then
            '    Exit Function
            'End If

            'Verifica se foi Preenchido o Campo - Data Início
            If dtpDataInicio.Value < Now.Date Then
                If MsgBox("A Data de Início da Nova revisão é menor que a Data Corrente. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    dtpDataInicio.Focus()
                    Exit Function
                End If               
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Váriaveis Locais
            Dim sCodigoGrupoItem As String

            If VerificaSelecaoNode(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoGrupoItem &= IIf(sCodigoGrupoItem = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Parametros
            Call oClsCadProdutoPrecoVenda.LoadGridRevisao(grdListagem, _
                                                          IIf(cboRevisaoBase.SelectedIndex = -1, "", cboRevisaoBase.SelectedValue), _
                                                          sCodigoGrupoItem, _
                                                          0, _
                                                          IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class