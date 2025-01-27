Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFePedidoCompra

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFePedidoCompra As New clsFrmFatEmissaoNFePedidoCompra
    Private lCodigoEmissaoCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmFatEmissaoNFePedidoCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Verifica Contro
                    Select Case sender.Name
                        Case "cboFornecedorFiltro" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    Select Case sender.Name
                        Case "cboFornecedorFiltro" : Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_faturamento_compras_fornecedor " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto), False)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFePedidoCompra_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoCompra.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedidoCompra.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedidoCompra.GroupByBoxVisible = True
                grdPedidoCompra.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdPedidoCompra
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPedidoCompra, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid
            Call ExportExcel(grdPedidoCompra)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            sQueryFind = "sp_select_faturamento_compra_fornecedor_externo_find " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto)
            oComboBoxFind = cboFornecedorFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedorFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImportarPedidoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoCompra.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Importar Pedido de Compra
                Importar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdPedidoCompra.FrozenColumns = 2
            Else
                grdPedidoCompra.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboFornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFornecedorFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Cliente
            If cboFornecedorFiltro.SelectedIndex = -1 Then
                'Limpa Controle
                txtCNPJCPFFiltro.Text = ""
            Else
                'Carrega Controles
                Call LoadDadosParceiroNegocio(cboFornecedorFiltro.SelectedValue, _
                                              txtCNPJCPFFiltro, _
                                              lblCNPJCPFFiltro)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdPedidoCompra.CellValueChanged

        Try

            If IsNothing(e.Column) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case e.Column.Key

                Case "codigo_ncm"

                    If IsNothing(grdPedidoCompra.CurrentRow.Cells("codigo_ncm").Value) = False Then

                        'Atualiza NCM
                        ExecuteQuery("sp_update_cadastro_basico_produto_ncm " & goUsuario.iEmpresa & ", " & grdPedidoCompra.GetValue("codigo_ncm") & ", " & grdPedidoCompra.GetValue("codigo_item"))

                        'Atualiza Código NCM da Grid
                        Call UpdateRegistroGrid(grdPedidoCompra, _
                                                "(codigo_item = " & grdPedidoCompra.GetValue("codigo_item") & ")", _
                                                "codigo_ncm", _
                                                grdPedidoCompra.GetValue("codigo_ncm"))

                        'Atualiza Regra de Venda
                        For Each oRow As GridEXRow In grdPedidoCompra.GetDataRows

                            'Carrega Código da Regra
                            Dim iCodigoRegraFaturamento As Integer = LoadDescricao("sp_select_faturamento_pedido_compra_regra_faturamento " & oRow.Cells("codigo_pedido").Value & ", " & oRow.Cells("codigo_pedido_item").Value & ", " & goUsuario.iEmpresa)

                            'Atualiza o Código da Grid
                            Call UpdateRegistroGrid(grdPedidoCompra, _
                                                    "(codigo_pedido = " & oRow.Cells("codigo_pedido").Value & " AND codigo_pedido_item = " & oRow.Cells("codigo_pedido_item").Value & ")", _
                                                    "codigo_regra_faturamento", _
                                                    IIf(iCodigoRegraFaturamento = "0", "NULL", iCodigoRegraFaturamento))

                        Next

                        'Atualiza a Grid
                        grdPedidoCompra.Refresh()

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_RowCheckStateChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs) Handles grdPedidoCompra.RowCheckStateChanging

        Try

            'Verifica se foi selecionado a Linha
            If e.ChangeType = CheckStateChangeType.RowChange Then
                'Verifica se o campo possui regra de venda
                If IsDBNull(e.Row.Cells("codigo_regra_faturamento").Value) And e.CheckState = RowCheckState.Checked Then
                    'Informa o Usuário que o Item não possui a Regra de Compra
                    MsgBox("Este Item não possui Regra de Compra cadastrada." & vbCrLf & vbCrLf & "Contate o Administrador do Sistema.", MsgBoxStyle.Critical, Me.Text)
                    e.Cancel = True
                    Exit Sub
                End If
            End If

            If e.ChangeType = CheckStateChangeType.ColumnHeaderChange Then
                'Váriaveis Locais
                Dim oRow As GridEXRow
                For Each oRow In grdPedidoCompra.GetDataRows
                    If IsDBNull(oRow.Cells("codigo_regra_faturamento").Value) = True Then
                        'Informa o Usuário que o Item não possui a Regra de Compra
                        MsgBox("Algum(ns) Item(ns) não possui Regra de Compra cadastrada." & vbCrLf & vbCrLf & "Contate o Administrador do Sistema.", MsgBoxStyle.Critical, Me.Text)
                        e.Cancel = True
                        Exit Sub
                    End If
                Next
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdPedidoCompra.RowDoubleClick

        Try

            Select Case grdPedidoCompra.CurrentColumn.Key

                Case "regra_venda" : Call CadastrarRegraFaturamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoCompra.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoCompra, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoCompra.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoCompra.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoCompra.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoCompra.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
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

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFePedidoCompra_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_faturamento_compras_fornecedor " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto), False)
            'Carrega Combo - Grid
            Call LoadComboGrid(grdPedidoCompra, "codigo_ncm", "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdPedidoCompra, Formulario.FaturamentoEmissaoNFe)

            'Seta Focu
            cboFornecedorFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: IMPORTAR :::"

    Private Sub CadastrarRegraFaturamento()

        Try

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdPedidoCompra.CurrentRow.Cells("codigo_ncm").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "NCM")
                Exit Sub
            End If

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdPedidoCompra.CurrentRow.Cells("codigo_origem_item").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Origem do Item")
                Exit Sub
            End If

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(4) As FormularioCadastroBasico

            oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.Importacao) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdPedidoCompra.CurrentRow.Cells("codigo_ncm").Value : oFormularioCadastroBasico(1).sControle = "cboNCM"
            oFormularioCadastroBasico(2).oValor = grdPedidoCompra.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(2).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(3).oValor = grdPedidoCompra.CurrentRow.Cells("codigo_origem_item").Value : oFormularioCadastroBasico(3).sControle = "cboOrigemItem"
            oFormularioCadastroBasico(4).oValor = grdPedidoCompra.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(4).sControle = "cboUFDestino"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrImpRegra"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.CadastroBasico = oFormularioCadastroBasico
            oForm.Titulo = Me.Text
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Recarrega a Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado o Cliente
            If ValidaCampo(cboFornecedorFiltro, lblFornecedorFiltro) = False Then
                cboFornecedorFiltro.Focus()
                Exit Sub
            End If

            'Verifica se o Número do Pedido é Válido
            If txtNumeroPedidoFiltro.Text.Trim <> "" Then
                If ValidaCampo(txtNumeroPedidoFiltro, lblNumeroPedidoFiltro, TipoCampo.numero) = False Then
                    txtNumeroPedidoFiltro.Focus()
                    Exit Sub
                End If
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Pedido de Compra
            Call oClsFatEmissaoNFePedidoCompra.LoadGridPedidoCompra(grdPedidoCompra, _
                                                                    cboFornecedorFiltro.SelectedValue, _
                                                                    IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                                                    CInt(TipoItem.produto))

            'Atualiza Grid
            grdPedidoCompra.Refresh()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Importar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Importa Pedido de Compra
            oClsFatEmissaoNFePedidoCompra.ImportarPedidoCompra(lCodigoEmissaoCapa, _
                                                               cboFornecedorFiltro.SelectedValue, _
                                                               grdPedidoCompra)

             'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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

            'Seta Váriavel
            ReDim gSelecaoRow(0)

            'Verifica se foi Selecionado algum Pedido de Venda
            For Each oRow As GridEXRow In grdPedidoCompra.GetCheckedRows
                If oRow.Cells("quantidade").Value > 0 And IsDBNull(oRow.Cells("codigo_regra_faturamento").Value) = False And CLng(oRow.Cells("codigo_ncm").Text) <> 0 Then
                    If IsNothing(gSelecaoRow(UBound(gSelecaoRow))) = False Then ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                    gSelecaoRow(UBound(gSelecaoRow)) = oRow
                End If
            Next

            'Retorno da Função
            Return IIf(IsNothing(gSelecaoRow(UBound(gSelecaoRow))) = True, False, True)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class