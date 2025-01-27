Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFeRetornoConsignado

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFeRetornoConsignado As New clsFrmFatEmissaoNFeRetornoConsignado
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

    Private Sub frmFatEmissaoNFeRetornoConsignado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

                Case Keys.F5

                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call LoadCombo(cboClienteFiltro, "sp_select_combo_faturamento_devolucao_propria " & goUsuario.iEmpresa, False)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeRetornoConsignado_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNotaFiscalRetornoConsignado.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNotaFiscalRetornoConsignado.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNotaFiscalRetornoConsignado.GroupByBoxVisible = True
                grdNotaFiscalRetornoConsignado.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdNotaFiscalRetornoConsignado
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalRetornoConsignado, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdNotaFiscalRetornoConsignado)

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
            sQueryFind = "sp_select_faturamento_devolucao_propria_cliente_find " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto)
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
                'Importar
                Importar()
            Else
                'Informa o Usuário sobre a Necessidade de Selecionar um ou mais Registros
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
                grdNotaFiscalRetornoConsignado.FrozenColumns = 2
            Else
                grdNotaFiscalRetornoConsignado.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalRetornoConsignado_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdNotaFiscalRetornoConsignado.CellValueChanged

        Try

            'Atualiza Grid
            grdNotaFiscalRetornoConsignado.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalDevolucao_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdNotaFiscalRetornoConsignado.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdNotaFiscalRetornoConsignado.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalDevolucao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdNotaFiscalRetornoConsignado.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdNotaFiscalRetornoConsignado.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdNotaFiscalRetornoConsignado.CurrentColumn.Key

                Case "regra_faturamento" : Call CadastrarRegraFaturamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalDevolucao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNotaFiscalRetornoConsignado.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalRetornoConsignado, _
                                     Formulario.FaturamentoEmissaoNFe)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalRetornoConsignado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalDevolucao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNotaFiscalRetornoConsignado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalRetornoConsignado.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalRetornoConsignado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalDevolucao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdNotaFiscalRetornoConsignado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNotaFiscalRetornoConsignado.Name, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeRetornoConsignado_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_faturamento_retorno_consignado " & goUsuario.iEmpresa & ", -1", False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalRetornoConsignado)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalRetornoConsignado, Formulario.FaturamentoEmissaoNFe)

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

#Region "::: IMPORTAR NFE EMITIDA :::"

    Private Sub CadastrarRegraFaturamento()

        Try

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(2) As FormularioCadastroBasico

            'Verifica se a Regra de Faturamento está cadastrada
            If (grdNotaFiscalRetornoConsignado.CurrentRow.Cells("quantidade_vendida").Value > 0 And (grdNotaFiscalRetornoConsignado.CurrentRow.Cells("valor_unitario").Value = grdNotaFiscalRetornoConsignado.CurrentRow.Cells("valor_unitario_venda").Value) And IsDBNull(grdNotaFiscalRetornoConsignado.CurrentRow.Cells("codigo_regra_faturamento_venda").Value) = True) Then
                oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.RetornoSimbolicoConsignado) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            ElseIf ((grdNotaFiscalRetornoConsignado.CurrentRow.Cells("quantidade_devolvida").Value > 0 Or (grdNotaFiscalRetornoConsignado.CurrentRow.Cells("quantidade_vendida").Value > 0 And grdNotaFiscalRetornoConsignado.CurrentRow.Cells("valor_unitario").Value <> grdNotaFiscalRetornoConsignado.CurrentRow.Cells("valor_unitario_venda").Value)) And IsDBNull(grdNotaFiscalRetornoConsignado.CurrentRow.Cells("codigo_regra_faturamento_devolucao").Value) = True) Then
                oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.DevoluvaoConsignado) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            End If
            oFormularioCadastroBasico(1).oValor = grdNotaFiscalRetornoConsignado.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(1).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(2).oValor = grdNotaFiscalRetornoConsignado.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(2).sControle = "cboUFDestino"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrImpRegra"
            oForm.Tamanho = True
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

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Nota Fiscal
            Call oClsFatEmissaoNFeRetornoConsignado.LoadGrid(grdNotaFiscalRetornoConsignado, _
                                                             IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                                             IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1))

            'Atualiza Grid
            grdNotaFiscalRetornoConsignado.Refresh()

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
            Call oClsFatEmissaoNFeRetornoConsignado.Importar(lCodigoEmissaoCapa, _
                                                             gSelecaoRow(0).Cells("codigo_cliente").Value)

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
            For Each oRow As GridEXRow In grdNotaFiscalRetornoConsignado.GetCheckedRows

                'Verifica se foi preenchida a Quantidade
                If (oRow.Cells("quantidade_vendida").Value > 0 Or oRow.Cells("quantidade_retorno").Value > 0) AndAlso
                   ((oRow.Cells("quantidade_vendida").Value + oRow.Cells("quantidade_retorno").Value) <= oRow.Cells("quantidade_nota_fiscal").Value) Then

                    'Verifica se a Regra de Faturamento está cadastrada
                    If (oRow.Cells("quantidade_vendida").Value > 0 And (oRow.Cells("valor_unitario").Value = oRow.Cells("valor_unitario_venda").Value) And IsDBNull(oRow.Cells("codigo_regra_faturamento_venda").Value) = False) Or _
                       ((oRow.Cells("quantidade_retorno").Value > 0 Or (oRow.Cells("quantidade_vendida").Value > 0 And oRow.Cells("valor_unitario").Value <> oRow.Cells("valor_unitario_venda").Value)) And IsDBNull(oRow.Cells("codigo_regra_faturamento_devolucao").Value) = False) Then
                        If IsNothing(gSelecaoRow(UBound(gSelecaoRow))) = False Then ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                        gSelecaoRow(UBound(gSelecaoRow)) = oRow
                    End If

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