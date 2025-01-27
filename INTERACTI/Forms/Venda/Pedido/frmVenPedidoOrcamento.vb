Imports Janus.Windows.GridEX

Public Class frmVenPedidoOrcamento

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenPedidoOrcamento As New clsFrmVenPedidoOrcamento
    Private lCodigoPedido As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoPedido() As Long
        Get
            Return lCodigoPedido
        End Get
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmVenPedidoOrcamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridOrcamento() Else Control_Enter(sender)
                    
                Case Keys.Escape : Me.Dispose()

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenPedidoOrcamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR ORÇAMENTO :::"
 
    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoOrcamento.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdPedidoOrcamento.RootTable.Groups
                    grdPedidoOrcamento.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdPedidoOrcamento.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdPedidoOrcamento.GroupByBoxVisible = True
                grdPedidoOrcamento.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoOrcamento
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPedidoOrcamento, Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdPedidoOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            'oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            sQueryFind = "sp_select_cadastro_basico_fin_parceiro_negocio_orcamento_aberto " & goUsuario.iEmpresa
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            If ValidacaoFiltro() = False Then Exit Sub

            LoadGridOrcamento()

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

    Private Sub btnImportarOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarOrcamento.Click

        Try

            If Validacao() = False Then Exit Sub

            ImportarOrcamento()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboClienteFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClienteFiltro.SelectedIndexChanged

        Try

            If cboClienteFiltro.SelectedIndex <> -1 Then

                'Carrega Dados do Parceiro de Negócio
                Call LoadDadosParceiroNegocio(cboClienteFiltro.SelectedValue, _
                                              txtCNPJCPFFiltro, _
                                              lblCNPJCPFFiltro, _
                                              txtMunicipioUFFiltro)
                'Carrega Combo
                Call LoadCombo(cboOrcamentoFiltro, "sp_select_combo_venda_orcamento " & goUsuario.iEmpresa & ", " & cboClienteFiltro.SelectedValue, False)

            Else

                'Limpa Controles
                txtCNPJCPFFiltro.Text = ""
                txtMunicipioUFFiltro.Text = ""

                'Carrega Combo
                Call LoadCombo(cboOrcamentoFiltro, "sp_select_combo_venda_orcamento " & goUsuario.iEmpresa, False)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoOrcamento_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdPedidoOrcamento.CellValueChanged

        Try

            'Verifica se é Válido a Coluna
            If IsNothing(e.Column) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case e.Column.Key

                Case "quantidade_pedido"

                    'Verifica se o Registro é Válido
                    If IsNumeric(grdPedidoOrcamento.GetValue("quantidade_pedido")) AndAlso grdPedidoOrcamento.GetValue("quantidade_pedido") > grdPedidoOrcamento.GetValue("quantidade") Then

                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Quantidade do Pedido de Venda informada não pode ser maior que a Quantidade do Orçamento.")
                        grdPedidoOrcamento.SetValue("quantidade_pedido", 0)

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoOrcamento_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdPedidoOrcamento.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdPedidoOrcamento.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoOrcamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoOrcamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoOrcamento, _
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoOrcamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoOrcamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoOrcamento.Name, _
                                     Formulario.ComercialPedidoVenda, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoOrcamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoOrcamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoOrcamento.Name, _
                                          Formulario.ComercialPedidoVenda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenPedidoOrcamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcPrint)
            btnImportarOrcamento.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)

            'Carrega Combo de Cliente
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_venda_orcamento_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboOrcamentoFiltro, "sp_select_combo_venda_orcamento " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdPedidoOrcamento, Formulario.ComercialPedidoVenda)

            'Seta Focu
            cboClienteFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: IMPORTAR ORÇAMENTO :::"

    Private Sub ImportarOrcamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsVenPedidoOrcamento.InsertPedido(cboOrcamentoFiltro.SelectedValue)

            'Percorre Linhas da Grid
            For Each oRow As GridEXRow In grdPedidoOrcamento.GetCheckedRows

                'Insere Item
                oClsVenPedidoOrcamento.InsertPedidoItem(oClsVenPedidoOrcamento.CodigoPedido, _
                                                        oRow.Cells("codigo_orcamento").Value, _
                                                        oRow.Cells("codigo_orcamento_item").Value, _
                                                        oRow.Cells("quantidade_pedido").Value)

            Next

            oClsVenPedidoOrcamento.IntegracaoFinanceiro(oClsVenPedidoOrcamento.CodigoPedido)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            lCodigoPedido = oClsVenPedidoOrcamento.CodigoPedido

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridOrcamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Orçamento
            oClsVenPedidoOrcamento.LoadGridOrcamento(grdPedidoOrcamento, _
                                                     cboOrcamentoFiltro.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            Dim sItem As String = ""

            For Each oRow In grdPedidoOrcamento.GetCheckedRows

                If oRow.Cells("quantidade_pedido").Value <= 0 Then
                    MsgBox("Insira uma quantidade válida na coluna Quantidade Pedido.", MsgBoxStyle.Exclamation, "Validação")
                    Return False
                End If

                If oRow.Cells("quantidade_pedido").Value > oRow.Cells("quantidade_pendente").Value Then
                    MsgBox("A Quantidade Pedido não pode ser maior do que a quantidade pendente.", MsgBoxStyle.Exclamation, "Validação")
                    Return False
                End If

                If IsDBNull(oRow.Cells("codigo_item").Value) Then
                    sItem += oRow.Cells("codigo_produto").Value + vbNewLine
                End If

            Next

            If sItem <> "" Then
                MsgBox("Os seguintes itens não possuem cadastro no sistema: " + vbNewLine + sItem, vbExclamation, "Validação")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoFiltro() As Boolean

        Try

            If ValidaCampo(cboOrcamentoFiltro, lblOrcamentoFiltro) = False Then
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region
  
End Class