Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFeOrdemIndustrializacao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFeOrdemIndustrializacao As New clsFrmFatEmissaoNFeOrdemIndustrializacao
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

#Region "::: GERAL :::"

    Private Sub frmFatEmissaoNFeRemessaIndustrializacao_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

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

    Private Sub frmFatEmissaoNFeRemessaIndustrializacao_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: MATÉRIA PRIMA :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRemessaIndustrializacao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRemessaIndustrializacao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRemessaIndustrializacao.GroupByBoxVisible = True
                grdRemessaIndustrializacao.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdRemessaIndustrializacao
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRemessaIndustrializacao, Formulario.FaturamentoEmissaoNFe)

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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnRemessaMercadoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemessaMercadoria.Click

        Try

            If Validacao() = True Then

                'Importar
                Call Importar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdRemessaIndustrializacao.FrozenColumns = 2
            Else
                grdRemessaIndustrializacao.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    'Private Sub CarregarOrdemProducao(sender As Object, e As EventArgs) Handles cboFornecedorFiltro.LostFocus, _
    '                                                                            cboOrdemProducaoFiltro.LostFocus

    '    Try

    '        'Verifica qual Controle foi Selecionado
    '        Select Case sender.Name

    '            Case "cboFornecedorFiltro"
    '                If (cboFornecedorFiltro.SelectedIndex = -1 Or cboFornecedorFiltro.SelectedIndex = -1) Then
    '                    Call LoadCombo(cboOrdemProducaoFiltro, "sp_select_combo_faturamento_remessa_industrializacao_ordem_producao " & goUsuario.iEmpresa)
    '                End If
    '            Case "cboOrdemProducaoFiltro" : If cboOrdemProducaoFiltro.SelectedIndex <> -1 Then cboFornecedorFiltro.SelectedValue = LoadDescricao("sp_select_producao_apontamento_remessa_industrializacao_fornecedor " & cboOrdemProducaoFiltro.SelectedValue & ", " & goUsuario.iEmpresa)

    '        End Select

    '        'Verifica se foi Selecionado o Cliente
    '        If cboFornecedorFiltro.SelectedIndex = -1 Then
    '            'Limpa Controle
    '            txtCNPJCPFFiltro.Text = ""
    '        Else
    '            'Carrega Controles
    '            Call LoadDadosParceiroNegocio(cboFornecedorFiltro.SelectedValue, _
    '                                          txtCNPJCPFFiltro, _
    '                                          lblCNPJCPFFiltro)
    '        End If

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Text)
    '    End Try

    'End Sub

    Private Sub grdRemessaIndustrializacao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles grdRemessaIndustrializacao.Click

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdRemessaIndustrializacao.CurrentColumn) Then Exit Sub
            If IsNothing(grdRemessaIndustrializacao.CurrentRow) Then Exit Sub

            'Váriavel
            Dim sQuery As String
            Dim dQuantidade As Double = 0

            If IsDBNull(grdRemessaIndustrializacao.GetValue("codigo_regra_imposto")) Then Exit Sub

            sQuery = "(codigo_ordem_producao = " & grdRemessaIndustrializacao.GetValue("codigo_ordem_producao") & ") "
            sQuery &= "AND (codigo_centro_trabalho = " & grdRemessaIndustrializacao.GetValue("codigo_centro_trabalho") & ") "
            sQuery &= "AND (codigo_operacao = " & grdRemessaIndustrializacao.GetValue("codigo_operacao") & ") "
            sQuery &= "AND (codigo_item_materia_prima = " & grdRemessaIndustrializacao.GetValue("codigo_item_materia_prima") & ")"

            'Verifica o Tipo de Operação
            Select Case grdRemessaIndustrializacao.CurrentColumn.Key

                Case "adicionar_faturamento" : dQuantidade = grdRemessaIndustrializacao.GetValue("quantidade") : Call UpdateRegistroGrid(grdRemessaIndustrializacao, sQuery, "quantidade_remessa", dQuantidade)
                Case "remover_faturamento" : dQuantidade = 0 : Call UpdateRegistroGrid(grdRemessaIndustrializacao, sQuery, "quantidade_remessa", dQuantidade)

            End Select

            'Executa Tarefas Pendentes do Sistema
            Application.DoEvents()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRemessaIndustrializacao_CellValueChanged(ByVal sender As Object, ByVal e As ColumnActionEventArgs) Handles grdRemessaIndustrializacao.CellValueChanged

        Try

            Select Case e.Column.Key

                Case "valor_unitario"

                    'Váriaveis Locais
                    Dim dValorUnitario As Double = 0
                    Dim dQuantidade As Double = 0

                    'Verifica se o Valor Unitário é Numérico
                    If IsNumeric(grdRemessaIndustrializacao.GetValue("valor_unitario")) Then
                        dQuantidade = grdRemessaIndustrializacao.GetValue("quantidade")
                        dValorUnitario = grdRemessaIndustrializacao.GetValue("valor_unitario")
                    End If

                    'Seta Valor
                    grdRemessaIndustrializacao.SetValue("valor_total", dQuantidade * dValorUnitario)

                Case "quantidade_remessa"

                    'Verifica se o Valor Unitário é Numérico
                    If IsDBNull(grdRemessaIndustrializacao.GetValue("codigo_regra_imposto")) Then
                        grdRemessaIndustrializacao.SetValue("quantidade_remessa", 0)
                        grdRemessaIndustrializacao.SetValue("valor_total", 0)
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRemessaIndustrializacao_RowCheckStateChanged(ByVal sender As Object, ByVal e As RowCheckStateChangeEventArgs) Handles grdRemessaIndustrializacao.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdRemessaIndustrializacao.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRemessaIndustrializacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRemessaIndustrializacao.RowDoubleClick

        Try

            'Verifica se a Célula Pressionada é Válida
            If IsNothing(grdRemessaIndustrializacao.CurrentColumn) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case grdRemessaIndustrializacao.CurrentColumn.Key

                Case "regra_venda" : Call CadastrarRegraRemessaIndustrializacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRemessaIndustrializacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRemessaIndustrializacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessaIndustrializacao, _
                                     Formulario.FaturamentoEmissaoNFe)

            Call LoadComboColunasGrid(cboCongelarColuna, grdRemessaIndustrializacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRemessaIndustrializacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRemessaIndustrializacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessaIndustrializacao.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRemessaIndustrializacao_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdRemessaIndustrializacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRemessaIndustrializacao.Name, _
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

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon
            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeRemessaIndustrializacao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_faturamento_remessa_industrializacao_fornecedor " & goUsuario.iEmpresa)
            Call LoadCombo(cboOrdemIndustrializacaoFiltro, "sp_select_combo_faturamento_remessa_industrializacao_ordem_industrializacao " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdRemessaIndustrializacao)

            'Configura Grid
            Call ConfiguraGrid(grdRemessaIndustrializacao, Formulario.FaturamentoEmissaoNFe)

            'Seta Focu
            cboFornecedorFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CadastrarRegraRemessaIndustrializacao()

        Try

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(2) As FormularioCadastroBasico

            oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.RemessaIndustrializacao) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdRemessaIndustrializacao.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(1).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(2).oValor = grdRemessaIndustrializacao.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(2).sControle = "cboUFDestino"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrImpRegra"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.CadastroBasico = oFormularioCadastroBasico
            oForm.Titulo = Me.Text

            'Abre Formulário
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

            'Verifica se foi Selecionado o Campo 
            If ValidaCampo(cboFornecedorFiltro, lblFornecedorFiltro) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsFatEmissaoNFeOrdemIndustrializacao.LoadGrid(grdRemessaIndustrializacao, _
                                                                   IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                                                   IIf(cboOrdemIndustrializacaoFiltro.SelectedIndex = -1, -1, cboOrdemIndustrializacaoFiltro.SelectedValue))

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

            'Importa Remessa para Industrialização
            Call oClsFatEmissaoNFeOrdemIndustrializacao.Iportar(lCodigoEmissaoCapa, _
                                                                  cboFornecedorFiltro.SelectedValue, _
                                                                  grdRemessaIndustrializacao)

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

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdRemessaIndustrializacao) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Verifica se o Campo QUantidade e Valor Unitário é Válido
            For Each oRow As GridEXRow In gSelecaoRow

                'Verifica se foi Preenchido a Quantidade de Remessa Válida
                If IsNumeric(oRow.Cells("quantidade_remessa").Value) = False Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor preencher a Quantidade de Remessa.")
                    Exit Function
                ElseIf oRow.Cells("quantidade_remessa").Value > oRow.Cells("quantidade").Value Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Quantidade de Remessa deve ser menor ou Igual a Quantidade.")
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo Valor Unitário
                If IsNumeric(oRow.Cells("valor_unitario").Value) = False Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor preencher o Valor Unitário.")
                    Exit Function
                End If

            Next

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region


End Class