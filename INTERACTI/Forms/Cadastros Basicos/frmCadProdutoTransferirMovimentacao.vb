Imports Janus.Windows.GridEX

Public Class frmCadProdutoTransferirMovimentacao


#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProduto As New clsUsrCadProduto

    Private lCodigoItem As Long
    Private sDataCorte As String
   
#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoItem As Long
        Get
            Return lcodigoitem
        End Get
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public Property DataCorte As String
        Get
            Return sdatacorte
        End Get
        Set(ByVal value As String)
            sdatacorte = value
        End Set
    End Property
#End Region

#Region "::: CONTROLES :::"
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            Salvar()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnProcurarItemEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemEstoque.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = "Procurar Produto"
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboCodigoProdutoEstoque


            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoProdutoEstoque.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub frmCadParceiroNegocioCRMComentario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadParceiroNegocioCRMComentario_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoParceiroNegocio, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged
        Try
            calcular()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboCodigoProdutoEstoque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProdutoEstoque.SelectedIndexChanged
        Try
            txtEstoqueProdutoDestino.Text = LoadCodigo("sp_select_cadastro_basico_produto_estoque_destino " & cboCodigoProdutoEstoque.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub Calcular()
        Try

            Dim dSaldo As Double = 0

            For Each oRow In grdListagem.GetCheckedRows

                dSaldo += oRow.Cells.Item("quantidade").Value

            Next

            txtQuantidadeReal.Text = dSaldo
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadParceiroNegocioCRMComentario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            Call oClsCadProduto.LoadGridMovimentacaoEstoque(grdListagem, _
                                                            lCodigoItem, _
                                                            sDataCorte)

            Call LoadCombo(cboCodigoProdutoEstoque, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, null, NULL", False)

            'Configura Grid
            'Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoParceiroNegocio)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()
        Try

            If ValidaCampo(cboCodigoProdutoEstoque, lblCodigoProdutoDestino) = False Then Exit Sub
            If MsgBox("Deseja transferir os itens selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Transferência de estoque") = vbNo Then Exit Sub

            'Percorre os itens
            For Each oRow In grdListagem.GetCheckedRows
                oClsCadProduto.AlterarCodigoEstoqueIndividual(lCodigoItem, cboCodigoProdutoEstoque.SelectedValue, oRow.Cells.Item("tipo").Value, oRow.Cells.Item("codigo_capa").Value, oRow.Cells.Item("codigo_linha").Value)
            Next

            'Informa ao usuário
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            Me.Dispose()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

 

    
  
End Class