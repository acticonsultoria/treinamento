Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFePicking

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFePicking As New clsFrmFatEmissaoNFePicking
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

    Private Sub frmFatEmissaoNFePicking_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridPicking() Else Control_Enter(sender)
                       
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

    Private Sub frmFatEmissaoNFePicking_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFatEmissaoNFePicking_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: IMPORTAR PICKING :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPicking.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPicking.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPicking.GroupByBoxVisible = True
                grdPicking.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdPicking
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPicking, Formulario.FaturamentoEmissaoNFe)

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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGridPicking()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImportarPicking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPicking.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Importar Picking
                ImportarPicking()

            End If

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

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClienteFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Cliente
            If cboClienteFiltro.SelectedIndex = -1 Then

                'Carrega Combo
                Call LoadCombo(cboNumeroPickingFiltro, "sp_select_combo_faturamento_venda_pedido " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto) & ", -1")

                'Limpa Controles
                cboNumeroPickingFiltro.Text = ""
                txtCNPJCPFFiltro.Text = ""

            Else

                'Carrega Combo
                Call LoadCombo(cboNumeroPickingFiltro, "sp_select_combo_faturamento_venda_pedido " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto) & ", " & cboClienteFiltro.SelectedValue)

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

    Private Sub cboNumeroPickingFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroPickingFiltro.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboNumeroPickingFiltro.SelectedIndex > -1 Then

                'Carrega Dados do Parceiro de Negócio
                Call LoadDadosParceiroNegocioVenda(cboNumeroPickingFiltro.SelectedValue, _
                                                   cboClienteFiltro, _
                                                   txtCNPJCPFFiltro, _
                                                   lblCNPJCPFFiltro)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPicking_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdPicking.CellValueChanged

        Try

            'Verifica se é Válido a Coluna
            If IsNothing(e.Column) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case e.Column.Key

                Case "codigo_ncm"

                    'Verifica se foi Selecionado um Registro
                    If IsNothing(grdPicking.CurrentRow.Cells("codigo_ncm").Value) = False Then

                        'Atualiza NCM
                        ExecuteQuery("sp_update_cadastro_basico_produto_ncm " & goUsuario.iEmpresa & ", " & grdPicking.GetValue("codigo_ncm") & ", " & grdPicking.GetValue("codigo_item"))

                        'Atualiza NCM - Item
                        Call UpdateRegistroGrid(grdPicking, _
                                                "(codigo_item = " & grdPicking.GetValue("codigo_item") & ")", _
                                                "codigo_ncm", _
                                                grdPicking.GetValue("codigo_ncm"))

                        'Atualiza Regra de Venda
                        For Each oRow As GridEXRow In grdPicking.GetDataRows

                            'Carrega Regra de Venda
                            Dim sRegra As String = LoadDescricao("sp_select_faturamento_venda_pedido_cliente_regra_imposto " & oRow.Cells("codigo_pedido").Value & ", " & oRow.Cells("codigo_pedido_item").Value & ", " & goUsuario.iEmpresa)

                            'Atualiza Regra
                            Call UpdateRegistroGrid(grdPicking, _
                                                    "(codigo_pedido = " & oRow.Cells("codigo_pedido").Value & " AND codigo_pedido_item = " & oRow.Cells("codigo_pedido_item").Value & ")", _
                                                    "codigo_regra_venda", _
                                                    IIf(sRegra = "0", "NULL", sRegra))

                        Next

                        'Atualiza a Grid
                        grdPicking.Refresh()

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPicking_RowCheckStateChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs) Handles grdPicking.RowCheckStateChanging

        Try

            'Verifica se foi selecionado a Linha
            If e.ChangeType = CheckStateChangeType.RowChange Then

                'Verifica se o campo possui regra de venda
                If IsDBNull(e.Row.Cells("codigo_regra_venda").Value) And e.CheckState = RowCheckState.Checked Then
                    'Informa o Usuário que o Item não possui a Regra de Venda
                    MsgBox("Este Item não possui Regra de Venda cadastrada." & vbCrLf & vbCrLf & "Contate o Administrador do Sistema.", MsgBoxStyle.Critical, Me.Text)
                    e.Cancel = True
                    Exit Sub
                End If

            End If

            If e.ChangeType = CheckStateChangeType.ColumnHeaderChange Then
                For Each oRow As GridEXRow In grdPicking.GetDataRows
                    If IsDBNull(oRow.Cells("codigo_regra_venda").Value) = True Then
                        'Informa o Usuário que o Item não possui a Regra de Venda
                        MsgBox("Algum(ns) Item(ns) não possui Regra de Venda cadastrada." & vbCrLf & vbCrLf & "Contate o Administrador do Sistema.", MsgBoxStyle.Critical, Me.Text)
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

    Private Sub grdPicking_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdPicking.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdPicking.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdPicking.CurrentColumn.Key

                Case "regra_venda" : Call CadastrarRegraVenda()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPicking_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPicking.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPicking, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPicking_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPicking.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPicking.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFePicking_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo de Cliente
            Call LoadCombo(cboNumeroPickingFiltro, "sp_select_combo_faturamento_venda_pedido " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto) & ", -1", False)
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_faturamento_venda_cliente " & goUsuario.iEmpresa & ", " & CInt(TipoItem.produto), False)
            'Carrega Combo - Grid
            Call LoadComboGrid(grdPicking, "codigo_ncm", "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdPicking, Formulario.FaturamentoEmissaoNFe)

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

#Region "::: IMPORTAR PICKING :::"

    Private Sub CadastrarRegraVenda()

        Try

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdPicking.CurrentRow.Cells("codigo_ncm").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "NCM")
                Exit Sub
            End If

            'Verifica se existe NCM cadastrado para o Produto
            If IsDBNull(grdPicking.CurrentRow.Cells("codigo_origem_item").Value) Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Origem do Item")
                Exit Sub
            End If

            'Carrega Váriaveis
            Dim oFormularioCadastroBasico(5) As FormularioCadastroBasico

            oFormularioCadastroBasico(0).oValor = CInt(TipoRegraImposto.Venda) : oFormularioCadastroBasico(0).sControle = "cboTipoRegra"
            oFormularioCadastroBasico(1).oValor = grdPicking.CurrentRow.Cells("codigo_ncm").Value : oFormularioCadastroBasico(1).sControle = "cboNCM"
            oFormularioCadastroBasico(2).oValor = grdPicking.CurrentRow.Cells("codigo_personalidade").Value : oFormularioCadastroBasico(2).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(3).oValor = grdPicking.CurrentRow.Cells("codigo_origem_item").Value : oFormularioCadastroBasico(3).sControle = "cboOrigemItem"
            oFormularioCadastroBasico(4).oValor = grdPicking.CurrentRow.Cells("uf_destino").Value : oFormularioCadastroBasico(4).sControle = "cboUFDestino"
            oFormularioCadastroBasico(5).oValor = grdPicking.CurrentRow.Cells("codigo_destinacao").Value : oFormularioCadastroBasico(5).sControle = "cboDestinacao"

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrImpRegra"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location: oForm.Tamanho = True
            oForm.CadastroBasico = oFormularioCadastroBasico
            oForm.Titulo = Me.Text
            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Recarrega a Grid
            Call LoadGridPicking()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPicking()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboClienteFiltro, lblClienteFiltro) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Pedido de Venda
            Call oClsFatEmissaoNFePicking.LoadGridPicking(grdPicking, _
                                                          IIf(cboNumeroPickingFiltro.SelectedIndex = -1, -1, cboNumeroPickingFiltro.SelectedValue), _
                                                          cboClienteFiltro.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarPicking()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Importa Pedido de Venda
            oClsFatEmissaoNFePicking.ImportarPicking(lCodigoEmissaoCapa, _
                                                     cboClienteFiltro.SelectedValue, _
                                                     IIf(cboNumeroPickingFiltro.SelectedIndex = -1, -1, cboNumeroPickingFiltro.SelectedValue), _
                                                     grdPicking)

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

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(cboClienteFiltro, lblClienteFiltro) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado algum Pedido de Venda
            For Each oRow As GridEXRow In grdPicking.GetDataRows
                If oRow.Cells("quantidade").Value > 0 Then
                    'Informa o Usuário que ele precisa informar a Quantidade
                    frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                    Return True
                End If
            Next

            'Retorno da Função
            Return False

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class