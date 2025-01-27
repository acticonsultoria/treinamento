Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFeRemessaComodato

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFeImportar As New clsFrmFatEmissaoNFeImportar
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

    Private Sub frmFatEmissaoNFeRemessaComodato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
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

    Private Sub frmFatEmissaoNFeRemessaComodato_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContratoComodato.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContratoComodato.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContratoComodato.GroupByBoxVisible = True
                grdContratoComodato.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdContratoComodato
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContratoComodato, Formulario.FaturamentoEmissaoNFe)

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
            sQueryFind = "sp_select_faturamento_remessa_comodato_cliente_find " & goUsuario.iEmpresa
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

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoVenda.Click

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
                grdContratoComodato.FrozenColumns = 2
            Else
                grdContratoComodato.FrozenColumns = cboCongelarColuna.SelectedValue
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

    Private Sub grdContratoComodato_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdContratoComodato.CellValueChanged

        Try

            'Verifica se é Válido a Coluna
            If IsNothing(e.Column) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case e.Column.Key

                Case "valor_unitario"

                    'Váriaveis Locais
                    Dim dValorUnitario As Double = 0
                    Dim dQuantidade As Double = 0

                    'Verifica se o Valor Unitário é Numérico
                    If IsNumeric(grdContratoComodato.GetValue("valor_unitario")) Then
                        dQuantidade = grdContratoComodato.GetValue("quantidade")
                        dValorUnitario = grdContratoComodato.GetValue("valor_unitario")
                    End If

                    'Seta Valor
                    grdContratoComodato.SetValue("valor_total", dQuantidade * dValorUnitario)

                Case "quantidade"

                    'Verifica se o Valor Unitário é Numérico
                    If IsDBNull(grdContratoComodato.GetValue("codigo_regra_faturamento")) Then
                        grdContratoComodato.SetValue("quantidade", 0)
                        grdContratoComodato.SetValue("valor_total", 0)
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContratoComodato_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdContratoComodato.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdContratoComodato.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContratoComodato_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContratoComodato.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdContratoComodato.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdContratoComodato.CurrentColumn.Key

                Case "regra_faturamento" : Call CadastrarRegraFaturamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContratoComodato_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContratoComodato.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContratoComodato, _
                                     Formulario.FaturamentoEmissaoNFe)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdContratoComodato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContratoComodato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContratoComodato.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContratoComodato.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdContratoComodato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdContratoComodato_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContratoComodato.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContratoComodato.Name, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeRemessaComodato_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_faturamento_remessa_comodato_cliente " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto), False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdContratoComodato)

            'Carrega Combo - Grid
            Call LoadComboGrid(grdContratoComodato, "codigo_ncm", "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdContratoComodato, Formulario.FaturamentoEmissaoNFe)

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
            If IsDBNull(grdContratoComodato.CurrentRow.Cells("codigo_ncm").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "NCM")
                Exit Sub
            End If

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdContratoComodato.CurrentRow.Cells("codigo_origem_item").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Origem do Item")
                Exit Sub
            End If

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(4) As FormularioCadastroBasico

            oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.RemessaComodato) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdContratoComodato.CurrentRow.Cells("codigo_ncm").Value : oFormularioCadastroBasico(1).sControle = "cboNCM"
            oFormularioCadastroBasico(2).oValor = grdContratoComodato.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(2).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(3).oValor = grdContratoComodato.CurrentRow.Cells("codigo_origem_item").Value : oFormularioCadastroBasico(3).sControle = "cboOrigemItem"
            oFormularioCadastroBasico(4).oValor = grdContratoComodato.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(4).sControle = "cboUFDestino"

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

            'Carrega Grid 
            Call oClsFatEmissaoNFeImportar.LoadGridRemessaComodato(grdContratoComodato, _
                                                                   IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                                                   txtNumeroContratoFiltro.Text.Trim, _
                                                                   CInt(TipoItem.produto))

            'Atualiza Grid
            grdContratoComodato.Refresh()

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

            'Importa Remessa de Comodato
            Call oClsFatEmissaoNFeImportar.ImportarRemessaComodato(lCodigoEmissaoCapa, _
                                                                   gSelecaoRow(0).Cells("codigo_cliente").Value, _
                                                                   grdContratoComodato)

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

            'Verifica se foi Selecionado algum Remessa de Comodato
            For Each oRow As GridEXRow In grdContratoComodato.GetCheckedRows
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