Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO

Public Class usrCadItemMagma

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadItemMagma As New clsUsrCadItemMagma

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadItemMagma_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadItemMagma_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadItemMagma_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialVendaOcorrenciaMagma)
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnImportarOcorrenciaExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarItensExcel.Click
        Try

            Dim oForm As New frmCadImportarItemMagma
            oForm.ShowDialog()

            Call LoadGrid()

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComercialVendaOcorrenciaMagma)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComercialVendaOcorrenciaMagma, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.ComercialVendaOcorrenciaMagma, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call LimpaControles()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtProdutoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadItemMagma_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroItemMagma, gcInsert)
            btnImportarItensExcel.Enabled = VerificaDireito(Formulario.CadastroItemMagma, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroItemMagma, gcPrint)

            'Verifica Direito - Cadastrar
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroItemMagma, gcUpdate)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroItemMagma, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroItemMagma, gcDelete)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroItemMagma)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtProdutoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadItemMagma.Update(btnSalvar.Tag, _
                                       txtTabela.Text, _
                                       txtCategoria.Text, _
                                       txtPrecoConsultor.Text, _
                                       txtPrecoConsumidor.Text)

            frmMain.Informacao(Mensagem.RegistroAlterado)

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ComercialVendaOcorrenciaMagma, gcUpdate) = True Then

               
                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value
                txtProduto.Text = grdListagem.CurrentRow.Cells.Item("codigo_produto").Value
                txtDescricao.Text = grdListagem.CurrentRow.Cells.Item("descricao").Value
                txtTabela.Text = grdListagem.CurrentRow.Cells.Item("tabela").Value
                txtCategoria.Text = grdListagem.CurrentRow.Cells.Item("categoria").Value
                txtPrecoConsultor.Value = grdListagem.CurrentRow.Cells.Item("preco_consultor").Value
                txtPrecoConsumidor.Value = grdListagem.CurrentRow.Cells.Item("preco_consumidor").Value

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtTabela.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsUsrCadItemMagma.Delete()

                    'Carrega Grid
                    Call LoadGrid()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LimpaControles()
        Try

            txtCategoria.Text = ""
            txtTabela.Text = ""
            txtProduto.Text = ""
            txtDescricao.Text = ""
            txtPrecoConsultor.Value = 0
            txtPrecoConsumidor.Value = 0
            btnSalvar.Tag = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsUsrCadItemMagma.LoadGrid(grdListagem, _
                                         IIf(txtProdutoFiltro.Text = "", "", txtProdutoFiltro.Text), _
                                         IIf(txtDescricaoFiltro.Text = "", "", txtDescricaoFiltro.Text), _
                                         IIf(txtTabelaFiltro.Text = "", -1, txtTabelaFiltro.Text), _
                                         IIf(txtCategoriaFiltro.Text = "", "", txtCategoriaFiltro.Text))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False


            If ValidaCampo(txtTabela, lblTabela, TipoCampo.numero) = False Then
                Exit Function
            End If

           If ValidaCampo(txtCategoria, lblCategoria, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtPrecoConsultor, lblPrecoConsultor, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(txtPrecoConsumidor, lblPrecoConsumidor, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class


