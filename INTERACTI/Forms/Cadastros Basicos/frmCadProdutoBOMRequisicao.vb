Imports Janus.Windows.GridEX

Public Class frmCadProdutoBOMRequisicao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmCadProdutoBOM As New clsFrmCadProdutoBOM

    Private lCodigoItem As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoItem() As Long
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
        Get
            Return lCodigoItem
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadEspecieInsumoEncargosSociais_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadEspecieInsumoEncargosSociais_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Verifica se o Grupo está Habilita
            If grdListagemRequisicao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagemRequisicao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagemRequisicao.GroupByBoxVisible = True
                grdListagemRequisicao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemRequisicao
            oForm.NomeFormulario = Formulario.CadastroBasicoEncargos
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemRequisicao, Formulario.CadastroBasicoEncargos)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagemRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            grdListagemBOM.RootTable.RemoveFilter()
            grdListagemBOM.Refresh()

            Cursor.Current = Cursors.WaitCursor

            For Each oRow As GridEXRow In grdListagemBOM.GetCheckedRows

                oClsFrmCadProdutoBOM.UpdateRequisicao(cboRequisicaoEstoque.SelectedValue, _
                                                      oRow.Cells("codigo").Value, _
                                                      oRow.Cells("quantidade").Value)

            Next

            frmMain.Informacao(Mensagem.RegistroAlterado)

            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagemEspecie_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagemRequisicao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemRequisicao, _
                                     Formulario.CadastroBasicoEncargos)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemEspecie_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagemRequisicao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemRequisicao.Name, _
                                     Formulario.CadastroBasicoEncargos, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemEspecie_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagemRequisicao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagemRequisicao.Name, _
                                          Formulario.CadastroBasicoEncargos, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboRequisicaoEstoque_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRequisicaoEstoque.SelectedIndexChanged

        Try

            If cboRequisicaoEstoque.SelectedIndex <> -1 Then

                oClsFrmCadProdutoBOM.LoadDados(cboRequisicaoEstoque.SelectedValue, _
                                               txtOrdemProducao, _
                                               txtCodigoItem)

                oClsFrmCadProdutoBOM.LoadGrid(grdListagemRequisicao, _
                                              grdListagemBOM, _
                                              cboRequisicaoEstoque.SelectedValue)

                For Each oRow As GridEXRow In grdListagemBOM.GetDataRows

                    If oRow.Cells("status").Value = "ADICIONAR" Then

                        oRow.IsChecked = True

                    End If

                Next

            Else

                grdListagemBOM.DataSource = Nothing
                grdListagemRequisicao.DataSource = Nothing
                txtOrdemProducao.Text = ""
                txtCodigoItem.Text = ""

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelListagem_Click(sender As Object, e As EventArgs) Handles btnExcelListagemBOM.Click

        Try

            Call ExportExcel(grdListagemBOM)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelListagemRequisicao_Click(sender As Object, e As EventArgs) Handles btnExcelListagemRequisicao.Click

        Try

            Call ExportExcel(grdListagemRequisicao)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadEspecieInsumoEncargosSociais_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            Call LoadCombo(cboRequisicaoEstoque, "sp_select_combo_cadastro_basico_produto_bom_requisicao " & lCodigoItem & "," & goUsuario.iEmpresa, True)

            'Atualiza Grid
            Call ConfiguraGrid(grdListagemRequisicao, Formulario.CadastroBasicoProdutoBOM)
            Call ConfiguraGrid(grdListagemBOM, Formulario.CadastroBasicoProdutoBOM)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class