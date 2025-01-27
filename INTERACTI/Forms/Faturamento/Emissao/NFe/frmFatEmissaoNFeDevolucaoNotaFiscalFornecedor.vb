Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFeDevolucaoNotaFiscalFornecedor As New clsFrmFatEmissaoNFeDevolucaoNotaFiscalFornecedor
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

    Private Sub frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                        
                Case Keys.F3

                    'Verifica Contro
                    Select Case sender.Name
                        Case "cboFornecedorFiltro" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR :::"
    Private Sub chkDefinirImposto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefinirImposto.CheckedChanged
        Try
            If chkDefinirImposto.Checked = False Then
                cboDestinacao.SelectedIndex = -1
                cboDestinacao.Enabled = False
            Else
                cboDestinacao.Enabled = True
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNotaFiscalRecebida.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNotaFiscalRecebida.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNotaFiscalRecebida.GroupByBoxVisible = True
                grdNotaFiscalRecebida.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdNotaFiscalRecebida
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalRecebida, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdNotaFiscalRecebida)

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
            sQueryFind = "sp_select_faturamento_devolucao_fornecedor_find " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto)
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

    Private Sub btnImportarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarDados.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Importar
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
                grdNotaFiscalRecebida.FrozenColumns = 2
            Else
                grdNotaFiscalRecebida.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboFornecedorFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFornecedorFiltro.LostFocus

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

    Private Sub grdNotaFiscalRecebida_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdNotaFiscalRecebida.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdNotaFiscalRecebida.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalRecebida_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdNotaFiscalRecebida.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdNotaFiscalRecebida.CurrentColumn) Then Exit Sub

            frmMain.errInfo.Clear()

            If chkDefinirImposto.Checked = True Then
                If ValidaCampo(cboDestinacao, lblDestinacao) = False Then Exit Sub
            End If

            'Verifica o Tipo de Operação
            Select Case grdNotaFiscalRecebida.CurrentColumn.Key
                Case "regra_venda" : Call CadastrarRegraFaturamento()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalRecebida_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNotaFiscalRecebida.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalRecebida, _
                                     Formulario.FaturamentoEmissaoNFe)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalRecebida)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalRecebida_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNotaFiscalRecebida.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalRecebida.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalRecebida)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalRecebida_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdNotaFiscalRecebida.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNotaFiscalRecebida.Name, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_faturamento_devolucao_fornecedor " & goUsuario.iEmpresa & ", -1", False)
            Call LoadCombo(cboDestinacao, "sp_select_combo_static_destinacao_remessa")
            Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalRecebida)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalRecebida, Formulario.FaturamentoEmissaoNFe)

            If goEmitente.sRazaoSocial.Contains("LMTERM") Then
                chkDefinirImposto.Checked = True
            End If

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

#Region "::: IMPORTAR NFE RECEBIDA :::"

    Private Sub CadastrarRegraFaturamento()

        Try

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(2) As FormularioCadastroBasico

            'Abre Formulário
            oFormularioCadastroBasico(0).oValor = IIf(chkDefinirImposto.Checked = True, CInt(TipoRegraImposto.DevolucaoNotaFiscalEntradaImposto), CInt(TipoRegraImposto.DevolucaoNotaFiscalEntrada)) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdNotaFiscalRecebida.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(1).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(2).oValor = grdNotaFiscalRecebida.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(2).sControle = "cboUFDestino"

            If chkDefinirImposto.Checked = True Then
                ReDim Preserve oFormularioCadastroBasico(5)

                oFormularioCadastroBasico(3).oValor = grdNotaFiscalRecebida.CurrentRow.Cells("codigo_origem_item").Value : oFormularioCadastroBasico(3).sControle = "cboOrigemItem"
                oFormularioCadastroBasico(4).oValor = grdNotaFiscalRecebida.CurrentRow.Cells("codigo_ncm2").Value : oFormularioCadastroBasico(4).sControle = "cboNCM"
                oFormularioCadastroBasico(5).oValor = cboDestinacao.SelectedValue : oFormularioCadastroBasico(5).sControle = "cboDestinacao"
            End If

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

            If chkDefinirImposto.Checked = True Then
                If ValidaCampo(cboDestinacao, lblDestinacao) = False Then Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Nota Fiscal
            Call oClsFatEmissaoNFeDevolucaoNotaFiscalFornecedor.LoadGrid(grdNotaFiscalRecebida, _
                                                                         IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                                                         IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                                                         IIf(cboDestinacao.SelectedIndex = -1, -1, cboDestinacao.SelectedValue), _
                                                                         txtOrdemProducaoFiltro.Text)

            'Atualiza Grid
            grdNotaFiscalRecebida.Refresh()

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
            Call oClsFatEmissaoNFeDevolucaoNotaFiscalFornecedor.Importar(lCodigoEmissaoCapa, _
                                                                         gSelecaoRow(0).Cells("codigo_fornecedor").Value, _
                                                                         IIf(cboDestinacao.SelectedIndex = -1, -1, cboDestinacao.SelectedValue))

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
            For Each oRow As GridEXRow In grdNotaFiscalRecebida.GetCheckedRows
                If oRow.Cells("quantidade").Value > 0 And IsDBNull(oRow.Cells("codigo_regra_faturamento").Value) = False Then
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