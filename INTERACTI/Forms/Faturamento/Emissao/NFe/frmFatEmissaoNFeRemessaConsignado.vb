Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class frmFatEmissaoNFeRemessaConsignado

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFeRemessaConsignado As New clsFrmFatEmissaoNFeRemessaConsignado
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

    Private Sub frmFatEmissaoNFeRemessaConsignado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Verifica Contro
                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeRemessaConsignado_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRemessaConsignado.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRemessaConsignado.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRemessaConsignado.GroupByBoxVisible = True
                grdRemessaConsignado.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdRemessaConsignado
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRemessaConsignado, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdRemessaConsignado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            sQueryFind = "sp_select_faturamento_venda_cliente_find " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto)
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

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Importa Registros
                Call Importar()

            Else
                'Informa o Usuário que ele precisa informar a Quantidade
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
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
                grdRemessaConsignado.FrozenColumns = 2
            Else
                grdRemessaConsignado.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboClienteFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClienteFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Cliente
            If cboClienteFiltro.SelectedIndex = -1 Then
                'Limpa Controle
                txtCNPJCPFFiltro.Text = ""
            Else
                'Carrega Controles
                Call LoadDadosParceiroNegocio(cboClienteFiltro.SelectedValue, _
                                              txtCNPJCPFFiltro, _
                                              lblCNPJCPFFiltro)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdRemessaConsignado.CellValueChanged

        Try

            'Verifica se é Válido a Coluna
            If IsNothing(e.Column) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case e.Column.Key

                Case "codigo_ncm"

                    'Verifica se foi Selecionado um Registro
                    If IsNothing(grdRemessaConsignado.CurrentRow.Cells("codigo_ncm").Value) = False Then

                        'Atualiza NCM
                        ExecuteQuery("sp_update_cadastro_basico_produto_ncm " & goUsuario.iEmpresa & ", " & grdRemessaConsignado.GetValue("codigo_ncm") & ", " & grdRemessaConsignado.GetValue("codigo_item"))

                        'Atualiza NCM - Item
                        Call UpdateRegistroGrid(grdRemessaConsignado, _
                                                "(codigo_item = " & grdRemessaConsignado.GetValue("codigo_item") & ")", _
                                                "codigo_ncm", _
                                                grdRemessaConsignado.GetValue("codigo_ncm"))

                        'Atualiza Regra de Venda
                        For Each oRow As GridEXRow In grdRemessaConsignado.GetDataRows

                            'Carrega Regra de Venda
                            Dim sRegra As String = LoadDescricao("sp_select_faturamento_venda_pedido_cliente_regra_imposto " & oRow.Cells("codigo_pedido").Value & ", " & oRow.Cells("codigo_pedido_item").Value & ", " & goUsuario.iEmpresa)

                            'Atualiza Regra
                            Call UpdateRegistroGrid(grdRemessaConsignado, _
                                                    "(codigo_pedido = " & oRow.Cells("codigo_pedido").Value & " AND codigo_pedido_item = " & oRow.Cells("codigo_pedido_item").Value & ")", _
                                                    "codigo_regra_faturamento", _
                                                    IIf(sRegra = "0", "NULL", sRegra))

                        Next

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdRemessaConsignado.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdRemessaConsignado.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRemessaConsignado.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdRemessaConsignado.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdRemessaConsignado.CurrentColumn.Key

                Case "regra_faturamento" : Call CadastrarRegraFaturamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRemessaConsignado.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessaConsignado, _
                                     Formulario.FaturamentoEmissaoNFe)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdRemessaConsignado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRemessaConsignado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessaConsignado.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdRemessaConsignado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdRemessaConsignado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRemessaConsignado.Name, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeRemessaConsignado_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_faturamento_remessa_consignado " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto), False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdRemessaConsignado)

            'Carrega Combo - Grid
            Call LoadComboGrid(grdRemessaConsignado, "codigo_ncm", "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdRemessaConsignado, Formulario.FaturamentoEmissaoNFe)

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

#Region "::: IMPORTAR :::"

    Private Sub CadastrarRegraFaturamento()

        Try

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdRemessaConsignado.CurrentRow.Cells("codigo_ncm").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "NCM")
                Exit Sub
            End If

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdRemessaConsignado.CurrentRow.Cells("codigo_origem_item").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Origem do Item")
                Exit Sub
            End If

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(5) As FormularioCadastroBasico

            oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.RemessaConsignado) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdRemessaConsignado.CurrentRow.Cells("codigo_ncm").Value : oFormularioCadastroBasico(1).sControle = "cboNCM"
            oFormularioCadastroBasico(2).oValor = grdRemessaConsignado.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(2).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(3).oValor = grdRemessaConsignado.CurrentRow.Cells("codigo_origem_item").Value : oFormularioCadastroBasico(3).sControle = "cboOrigemItem"
            oFormularioCadastroBasico(4).oValor = grdRemessaConsignado.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(4).sControle = "cboUFDestino"
            oFormularioCadastroBasico(5).oValor = grdRemessaConsignado.CurrentRow.Cells("codigo_destinacao").Value : oFormularioCadastroBasico(5).sControle = "cboDestinacao"

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

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Cliente
            If ValidaCampo(cboClienteFiltro, lblClienteFiltro) = False Then
                cboClienteFiltro.Focus()
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Pedido de Venda
            Call oClsFatEmissaoNFeRemessaConsignado.LoadGridRemessaConsignado(grdRemessaConsignado, _
                                                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                                                              txtNumeroPedidoFiltro.Text.Trim, _
                                                                              CInt(TipoItem.produto))

            'Atualiza Grid
            grdRemessaConsignado.Refresh()

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

            'Importa Pedido de Venda
            Call oClsFatEmissaoNFeRemessaConsignado.ImportarRemessaConsignado(lCodigoEmissaoCapa, _
                                                                              gSelecaoRow(0).Cells("codigo_cliente").Value, _
                                                                              grdRemessaConsignado)

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
            For Each oRow As GridEXRow In grdRemessaConsignado.GetCheckedRows
                If oRow.Cells("quantidade").Value > 0 And IsDBNull(oRow.Cells("codigo_regra_faturamento").Value) = False And oRow.Cells("codigo_ncm").Text <> "00000000" And oRow.Cells("codigo_ncm").Text <> "99999999" Then
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