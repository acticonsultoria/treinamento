Imports Janus.Windows.GridEX
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System.Threading.Thread
Imports WinControl = Dundas.Charting.WinControl
Imports Color = System.Drawing.Color
Imports System.Diagnostics.Eventing.Reader

Public Class usrVenOrcamentoLegado

#Region "::: VARIAVEIS :::"

    'Variáveis da Cultivar
    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Dim iFormulario As Integer = -1
    Dim iOpcao As Integer = -1
    Dim lCodigoOrcamento As Long = -1
    Dim bExibirFormacaoPreco As Boolean = False
    Dim sCaminhoArquivoObservacao As String = ""

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: CONFIGURAÇÃO DA GRID :::"

    Private Sub Grid_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Try

            If e.Button = MouseButtons.Right Then

                Dim oGrid As GridEX = sender

                oGrid.CurrentColumn = oGrid.ColumnFromPoint(e.X, e.Y)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AddMenuGrid(ByVal oControl As Control)

        Try

            If TypeOf (oControl) Is GridEX Then

                Dim oGrid As GridEX = oControl
                oGrid.DynamicFiltering = True
                oGrid.FilterMode = FilterMode.Automatic

                ConfigurarBuiltInTextsGrid(oGrid)

                Dim oUICommandManager As New Janus.Windows.UI.CommandBars.UICommandManager
                Dim oUIContextMenu As New Janus.Windows.UI.CommandBars.UIContextMenu

                If oGrid.Name = "grdOrcamentoComposicao" Then

                    Dim oUICommandCopiar As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandLimparFiltros As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandAdicionarLinha As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandAdicionarServico As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExcluirLinha As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExpandirTudo As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandRecolherExpansao As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandRemoverOrdenacao As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandConfigurarGrid As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExportarExcel As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandProcurar As New Janus.Windows.UI.CommandBars.UICommand
                    oUICommandCopiar.Text = "Copiar Conteúdo da Célula" : oUICommandCopiar.Key = "copiar"
                    oUICommandLimparFiltros.Text = "Limpar Filtros da Listagem" : oUICommandLimparFiltros.Key = "limpar_filtros"
                    oUICommandAdicionarLinha.Text = "Adicionar Produto" : oUICommandAdicionarLinha.Key = "adicionar_linha"
                    oUICommandAdicionarServico.Text = "Adicionar Serviço" : oUICommandAdicionarServico.Key = "adicionar_servico"
                    oUICommandExcluirLinha.Text = "Excluir Linha" : oUICommandExcluirLinha.Key = "excluir_linha"
                    oUICommandExpandirTudo.Text = "Expandir Tudo" : oUICommandExpandirTudo.Key = "expandir_tudo"
                    oUICommandRecolherExpansao.Text = "Recolher Expansão" : oUICommandRecolherExpansao.Key = "recolher_expansao"
                    oUICommandRemoverOrdenacao.Text = "Remover Ordenação" : oUICommandRemoverOrdenacao.Key = "remover_ordenacao"
                    oUICommandConfigurarGrid.Text = "Configurar Listagem" : oUICommandConfigurarGrid.Key = "configurar_grid"
                    oUICommandExportarExcel.Text = "Exportar para Excel" : oUICommandExportarExcel.Key = "exportar_excel"
                    oUICommandProcurar.Text = "Procurar" : oUICommandProcurar.Key = "procurar"

                    oUICommandManager.Commands.Add(oUICommandCopiar)
                    oUICommandManager.Commands.Add(oUICommandLimparFiltros)
                    oUICommandManager.Commands.Add(oUICommandAdicionarLinha)
                    oUICommandManager.Commands.Add(oUICommandAdicionarServico)
                    oUICommandManager.Commands.Add(oUICommandExcluirLinha)
                    oUICommandManager.Commands.Add(oUICommandExpandirTudo)
                    oUICommandManager.Commands.Add(oUICommandRecolherExpansao)
                    oUICommandManager.Commands.Add(oUICommandRemoverOrdenacao)
                    oUICommandManager.Commands.Add(oUICommandConfigurarGrid)
                    oUICommandManager.Commands.Add(oUICommandExportarExcel)
                    oUICommandManager.Commands.Add(oUICommandProcurar)

                    oUIContextMenu.Commands.Add(oUICommandCopiar)
                    oUIContextMenu.Commands.Add(oUICommandLimparFiltros)
                    oUIContextMenu.Commands.Add(oUICommandAdicionarLinha)
                    oUIContextMenu.Commands.Add(oUICommandAdicionarServico)
                    oUIContextMenu.Commands.Add(oUICommandExcluirLinha)
                    oUIContextMenu.Commands.Add(oUICommandExpandirTudo)
                    oUIContextMenu.Commands.Add(oUICommandRecolherExpansao)
                    oUIContextMenu.Commands.Add(oUICommandRemoverOrdenacao)
                    oUIContextMenu.Commands.Add(oUICommandConfigurarGrid)
                    oUIContextMenu.Commands.Add(oUICommandExportarExcel)
                    oUIContextMenu.Commands.Add(oUICommandProcurar)
                    oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                    AddCommandClick(oUICommandCopiar, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandLimparFiltros, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandAdicionarLinha, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandAdicionarServico, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandExcluirLinha, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandExpandirTudo, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandRecolherExpansao, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandRemoverOrdenacao, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandConfigurarGrid, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandExportarExcel, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandProcurar, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddMouseClick(oControl, New DelegateMouseClick(AddressOf Grid_MouseClick))

                ElseIf oGrid.Name = "grdOrcamentoCheckListCliente" Then

                    Dim oUICommandAdicionarCheckListCliente As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExcluirCheckListCliente As New Janus.Windows.UI.CommandBars.UICommand

                    oUICommandAdicionarCheckListCliente.Text = "Adicionar Cheklist Cliente" : oUICommandAdicionarCheckListCliente.Key = "adicionar_checklist_cliente"
                    oUICommandExcluirCheckListCliente.Text = "Excluir Cheklist Cliente" : oUICommandExcluirCheckListCliente.Key = "excluir_checklist_cliente"

                    oUICommandManager.Commands.Add(oUICommandAdicionarCheckListCliente)
                    oUICommandManager.Commands.Add(oUICommandExcluirCheckListCliente)

                    oUIContextMenu.Commands.Add(oUICommandAdicionarCheckListCliente)
                    oUIContextMenu.Commands.Add(oUICommandExcluirCheckListCliente)
                    oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                    AddCommandClick(oUICommandAdicionarCheckListCliente, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandExcluirCheckListCliente, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddMouseClick(oControl, New DelegateMouseClick(AddressOf Grid_MouseClick))

                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Button_CommandClick_Orcamento(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs)

        Try

            'Váriavel
            Dim oUICommand As Janus.Windows.UI.CommandBars.UICommand = sender

            'Verifica o Tipo de Controle
            Select Case oUICommand.Key

                Case "limpar"

                    Dim oGrid As GridEX = sender.Tag
                    oGrid.CurrentColumn.CellStyle.BackColor = Nothing

                    'Limpa Controles
                    Dim oControl As Control = oGrid.Parent
                    While Not TypeOf (oControl) Is UserControl And Not TypeOf (oControl) Is Form
                        oControl = oControl.Parent
                    End While

                    'Atualiza Registro
                    Call UpdateConfiguraGridCor(oGrid.Name, oControl.Tag.ToString.Replace("FILTRAR", ""), oGrid.CurrentColumn.Key, -1, -1, -1)

                Case "limpar_filtros"

                    Dim oGrid As GridEX = sender.tag
                    oGrid.Row = -2
                    oGrid.RootTable.RemoveFilter()
                    oGrid.Refresh()

                Case "expandir_tudo"

                    Dim oGrid As GridEX = sender.tag
                    oGrid.ExpandRecords()

                Case "recolher_expansao"

                    Dim oGrid As GridEX = sender.tag
                    oGrid.CollapseRecords()

                Case "remover_ordenacao"
                    Dim oGrid As GridEX = sender.tag
                    oGrid.RootTable.SortKeys.Clear()

                Case "adicionar_linha"

                    If ValidaCheckList() = False Then Exit Sub
                    If VerificaStatus() = False Then Exit Sub

                    oClsUsrVenOrcamentoLegado.GerarCodigoItem(lCodigoOrcamento)
                    LoadGridComposicao()

                Case "adicionar_servico"

                    If ValidaCheckList() = False Then Exit Sub
                    If VerificaStatus() = False Then Exit Sub
                    oClsUsrVenOrcamentoLegado.GerarCodigoItem(lCodigoOrcamento, sTipo:="SERVIÇO")
                    LoadGridComposicao()

                Case "excluir_linha"

                    If ValidaCheckList() = False Then Exit Sub
                    If VerificaStatus() = False Then Exit Sub
                    If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

                    oClsUsrVenOrcamentoLegado.DeleteItem(lCodigoOrcamento, grdOrcamentoComposicao.GetValue("codigo"))
                    grdOrcamentoComposicao.CurrentRow.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                Case "copiar"

                    Dim oGrid As GridEX = sender.Tag

                    If IsNothing(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key)) = False Then
                        Clipboard.SetDataObject(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key).Text)
                    End If

                Case "configurar_grid"

                    Dim oForm As New frmCfgGrid
                    Dim oGrid As GridEX = sender.Tag

                    'Seta Parametros
                    oForm.Grid = oGrid
                    oForm.NomeFormulario = iFormulario
                    oForm.ShowDialog(Me)

                    'Configura Grid
                    ConfiguraGrid(oGrid, iFormulario)

                Case "exportar_excel"

                    Dim oGrid As GridEX = sender.tag

                    'Exporta Grid para Excel
                    ExportExcel(oGrid)

                Case "procurar2"

                    Dim oGrid As GridEX = sender.tag
                    Dim sColumn As String = oGrid.CurrentColumn.Key
                    Dim sPalavra As String = InputBox("Busca na Grid", "Digite o texto a ser buscada na coluna " & oGrid.CurrentColumn.Caption)

                    'Verifica se o usuário digitou a palavra
                    If sPalavra <> "" Then

                        'Recolhe a seleção
                        oGrid.CollapseRecords()

                        oGrid.FindAll(oGrid.RootTable.Columns(sColumn), ConditionOperator.Contains, sPalavra)

                        'Busca na 1º childtable
                        Try

                            oGrid.FindAll(oGrid.RootTable.ChildTables(0).Columns(sColumn), ConditionOperator.Contains, sPalavra)
                        Catch ex As Exception

                        End Try

                        'Busca na 2º childtable
                        Try

                            oGrid.FindAll(oGrid.RootTable.ChildTables(0).ChildTables(0).Columns(sColumn), ConditionOperator.Contains, sPalavra)
                        Catch ex As Exception

                        End Try
                        'Busca na 3º childtable
                        Try

                            oGrid.FindAll(oGrid.RootTable.ChildTables(0).ChildTables(0).ChildTables(0).Columns(sColumn), ConditionOperator.Contains, sPalavra)
                        Catch ex As Exception

                        End Try
                    End If

                Case "procurar"

                    Dim oGrid As GridEX = sender.tag
                    Dim sColumn As String = oGrid.CurrentColumn.Key
                    Dim sPalavra As String = InputBox("Busca na Grid", "Digite o texto a ser buscada na coluna " & oGrid.CurrentColumn.Caption)

                    'Verifica se o usuário digitou a palavra
                    If sPalavra <> "" Then

                        sPalavra = sPalavra.ToUpper

                        'Recolhe a seleção
                        oGrid.CollapseRecords()

                        oGrid.KeepRowSettings = True

                        For Each oRow In oGrid.GetRows
                            If oRow.Cells.Item(sColumn).Value.ToString.ToUpper.Contains(sPalavra) Then
                                Dim oFormatStyle As New GridEXFormatStyle
                                oFormatStyle.BackColor = Color.Yellow
                                oRow.Cells(sColumn).FormatStyle = oFormatStyle

                            Else
                                oRow.Cells(sColumn).FormatStyle = Nothing
                            End If

                            For Each oChild1 In oRow.GetChildRows
                                If oChild1.Cells.Item(sColumn).Value.ToString.ToUpper.Contains(sPalavra) Then
                                    Dim oFormatStyle As New GridEXFormatStyle
                                    oFormatStyle.BackColor = Color.Yellow
                                    oChild1.Cells(sColumn).FormatStyle = oFormatStyle
                                    oChild1.Parent.Expanded = True
                                Else
                                    oChild1.Cells(sColumn).FormatStyle = Nothing
                                End If

                                For Each oChild2 In oChild1.GetChildRows
                                    If oChild2.Cells.Item(sColumn).Value.ToString.ToUpper.Contains(sPalavra) Then
                                        Dim oFormatStyle As New GridEXFormatStyle
                                        oFormatStyle.BackColor = Color.Yellow
                                        oChild2.Cells(sColumn).FormatStyle = oFormatStyle
                                        oChild2.Parent.Expanded = True
                                    Else
                                        oChild2.Cells(sColumn).FormatStyle = Nothing
                                    End If

                                    For Each oChild3 In oChild1.GetChildRows
                                        If oChild3.Cells.Item(sColumn).Value.ToString.ToUpper.Contains(sPalavra) Then
                                            Dim oFormatStyle As New GridEXFormatStyle
                                            oFormatStyle.BackColor = Color.Yellow
                                            oChild3.Cells(sColumn).FormatStyle = oFormatStyle
                                            oChild3.Parent.Expanded = True
                                        Else
                                            oChild3.Cells(sColumn).FormatStyle = Nothing
                                        End If
                                    Next


                                Next



                            Next

                        Next

                        'For iRow As Integer = 0 To oGrid.GetRows.Count - 1

                        '    oGrid.Row = iRow
                        '    If oGrid.CurrentRow.Cells.Item(sColumn).Value.ToString.ToUpper.Contains(sPalavra) Then
                        '        Dim oFormatStyle As New GridEXFormatStyle
                        '        oFormatStyle.BackColor = Color.Yellow
                        '        oGrid.CurrentRow.Cells(sColumn).FormatStyle = oFormatStyle
                        '    Else
                        '        oGrid.CurrentRow.Cells(sColumn).FormatStyle = Nothing
                        '    End If

                        'Next
                    End If

                Case "adicionar_checklist_cliente"

                    If ValidaCheckList() = False Then Exit Sub
                    'If VerificaStatus() = False Then Exit Sub

                    Dim oForm As New frmVenOrcamentoAdicionarChecklistCliente
                    oForm.CodigoOrcamento = lCodigoOrcamento
                    oForm.ShowDialog()

                    LoadGridChecklistCliente()

                Case "excluir_checklist_cliente"

                    If ValidaCheckList() = False Then Exit Sub
                    'If VerificaStatus() = False Then Exit Sub

                    If grdOrcamentoCheckListCliente.GetValue("tipo") = "REQUISITO DO ORÇAMENTO" Then

                        If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

                        oClsUsrVenOrcamentoLegado.DeleteChecklistCliente(lCodigoOrcamento, grdOrcamentoCheckListCliente.GetValue("codigo"))

                        grdOrcamentoCheckListCliente.CurrentRow.Delete()

                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.RegistroExcluido)

                    Else

                        frmMain.Informacao("Só é Possivel Excluir REQUISITO DO ORÇAMENTO", Color.Red)
                        LoadGridChecklistCliente()

                    End If

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub btnUltimoOrcamento_Click(sender As Object, e As EventArgs) Handles btnUltimoOrcamento.Click
        Try
            Try

                If lblSimulacao.Visible = True Then

                    If MsgBox("Deseja excluir a simulação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Simulação") = vbNo Then
                        Exit Sub
                    Else
                        'Excluir o orçamento
                        ExecuteQuery("sp_delete_venda_orcamento " & oClsUsrVenOrcamentoLegado.CodigoOrcamento & "," & goUsuario.iEmpresa)

                    End If

                End If

                If lCodigoOrcamento <= 0 Then Exit Sub

                Dim lCodigo As Long = LoadCodigo("sp_load_venda_orcamento_codigo " & lCodigoOrcamento & ", 3, " & goUsuario.iEmpresa)

                If lCodigo <= 0 Then
                    MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                Editar(lCodigo)

            Catch ex As Exception
                TratamentoErro(ex.Message, Me.Name)
            End Try
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnAtualizarPai_Click(sender As Object, e As EventArgs) Handles btnAtualizarPai.Click

        Try

            AlterarItemPaiConcatenado()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnEditarObservacao_click(sender As Object, e As EventArgs) Handles btnEditarObservacao.Click
        Try
            EditarObservacao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcluirItem_Click(sender As Object, e As EventArgs) Handles btnExcluirItem.Click

        Try

            If VerificaStatus() = False Then Exit Sub

            DeleteItem()
            LoadGridComposicao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdProducao_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdProducao.RowDoubleClick

        Try

            EditarOrdemProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub dtpDataOrcamento_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataOrcamento.ValueChanged

        Try

            CalculaDataValidade()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged

        Try

            CalculaDataValidade()

            cboNumeroContrato.DataSource = Nothing : cboNumeroContrato.SelectedIndex = -1

            If cboCliente.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboNumeroContrato, "sp_select_combo_cadastro_basico_contrato_cliente " & cboCliente.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            LimparOrcamento()
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub
            If ValidaCheckList() = False Then Exit Sub

            If lblSimulacao.Visible = True Then

                'Questiona o usuário
                If MsgBox("Deseja salvar a simulação? isso fará com que ele seja transformado em um orçamento real!", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Simulação") = vbNo Then Exit Sub

                Dim sRevisao As String = txtRevisao.Text

                If sRevisao = "" Then
                    sRevisao = "A"
                Else
                    sRevisao = LoadCodigo("sp_select_venda_orcamento_nova_revisao " & txtNumeroOrcamento.Text & "," & goUsuario.iEmpresa)
                End If

                Dim oForm As New frmVenOrcamentoSimulacaoOpcao
                oForm.optGerarRevisao.Text += " " & sRevisao
                oForm.ShowDialog()

                If oForm.Opcao = 1 Then
                    lblSimulacao.Visible = False

                    'Seta a simulação
                    ExecuteQuery("sp_update_venda_orcamento_transformar_simulacao " &
                                                oClsUsrVenOrcamentoLegado.CodigoOrcamento & "," &
                                                goUsuario.iEmpresa & "," &
                                                goUsuario.iUsuario & "," &
                                                "'" & sRevisao & "'", goDatabase.sConnection)

                    'Carrega de novo
                    Editar(oClsUsrVenOrcamentoLegado.CodigoOrcamento)

                ElseIf oForm.Opcao = 2 Then
                    lblSimulacao.Visible = False

                    'Seta a simulação
                    ExecuteQuery("sp_update_venda_orcamento_transformar_simulacao " &
                                                oClsUsrVenOrcamentoLegado.CodigoOrcamento & "," &
                                                goUsuario.iEmpresa & "," &
                                                goUsuario.iUsuario, goDatabase.sConnection)
                    'Carrega de novo
                    Editar(oClsUsrVenOrcamentoLegado.CodigoOrcamento)
                Else
                    Exit Sub
                End If


            End If

            'Salva Dados do Registro
            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            If lblSimulacao.Visible = True Then

                If MsgBox("Deseja excluir a simulação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Simulação") = vbNo Then
                    Exit Sub
                Else
                    'Excluir o orçamento
                    ExecuteQuery("sp_delete_venda_orcamento " & oClsUsrVenOrcamentoLegado.CodigoOrcamento & "," & goUsuario.iEmpresa)

                End If

            End If

            AtualizaValoresGeral()

            'Carrega Grid
            LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            txtNumeroOrcamentoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar(grdListagem.GetValue("codigo"))
                Case "duplicar" : Duplicar()
                Case "gerar_pedido" : GerarPedido(grdListagem.GetValue("codigo"))
                Case "alterar_status_negociacao" : AlterarStatusNegociacao(grdListagem.GetValue("codigo"))
                'Case "historico" : HistoricoOrcamento()
                Case "reprovar" : Reprovar()
                Case "declinar" : Declinar()
                Case "cancelar_item" : CancelarItem()
                Case "historico_item" : HistoricoItem()
                Case "gerar_revisao" : GerarRevisao()
                Case "pedido_venda" : EditarPedidoListagem()
                Case "ordem_producao" : EditarOrdemProducao2()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated
        Try

            oClsUsrVenOrcamentoLegado.UpdateOrcamentista(grdListagem.CurrentRow.Cells.Item("codigo").Value,
                                                         grdListagem.CurrentRow.Cells.Item("orcamentista").Value)

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved,
                                                                                                                       grdCheckList.ColumnMoved,
                                                                                                                       grdDetalhe.ColumnMoved,
                                                                                                                       grdOrcamentoComposicao.ColumnMoved,
                                                                                                                       grdAnalitico.ColumnMoved,
                                                                                                                       grdProducao.ColumnMoved,
                                                                                                                       grdOrcamentoCheckListCliente.ColumnMoved
        Try


            'Atualiza Grid
            UpdateConfiguraGrid(sender,
                                    iFormulario)

            AjustarChildTables(sender, e)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn,
                                                                                                                        grdCheckList.SizingColumn,
                                                                                                                        grdDetalhe.SizingColumn,
                                                                                                                        grdOrcamentoComposicao.SizingColumn,
                                                                                                                        grdAnalitico.SizingColumn,
                                                                                                                        grdProducao.SizingColumn,
                                                                                                                        grdOrcamentoCheckListCliente.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name,
                                iFormulario,
                                e.Column.Key,
                                e.ProposedWidth)

            AjustarChildTables(sender, Nothing, e)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdComposicao_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOrcamentoComposicao.RowDoubleClick

        Try

            If IsNothing(grdOrcamentoComposicao.CurrentColumn) Then Exit Sub

            Select Case grdOrcamentoComposicao.CurrentColumn.Key

                Case "composicao" : AtualizarComposicao()
                Case "adicionar_filho" : AdicionarFilho()
                Case "virar_pai" : AtualizarItemPai()
                Case "alterar_pai" : AlterarItemPai()
                Case "codigo_produto" : AlterarCodigoProduto()
                Case "duplicar" : DuplicarItem()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOrcamentoComposicao_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoComposicao.CellUpdated

        Try

            Select Case sender.name

                Case "grdOrcamentoComposicao"

                    If VerificaStatus() = False Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                        LoadGridComposicao()
                        Exit Sub
                    End If

                    oClsUsrVenOrcamentoLegado.UpdateOrcamentoComposicao(sender.CurrentRow)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(sender As Object, e As EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboCliente.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarCliente_Click(sender As Object, e As EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            cboCliente.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            btnImportarItem.Visible = False
            btnExcluirItem.Visible = False
            btnExibirFormacaoPreco.Visible = False
            btnEditarObservacao.Visible = False
            btnAtualizarPai.Visible = False

            Select Case tabDados.SelectedTab.Key
                Case pagComposicao.Key
                    btnImportarItem.Visible = True
                    btnExcluirItem.Visible = True
                    btnExibirFormacaoPreco.Visible = VerificaDireito(iFormulario, gcAdministrator)
                    btnAtualizarPai.Visible = True

                Case pagAnalitico.Key : LoadGridAnalitico()
                Case pagPreco.Key : LoadFormacaoPreco()
                Case pagHistorico.Key : LoadGridHistorico()
                Case pagProducao.Key : LoadGridProducao()
                Case pagObservacao.Key : LoadObservacao()
                Case pagChecklistCliente.Key : LoadGridChecklistCliente()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()
            ImprimirOrcamento()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOrcamentoComposicao_MouseClick(sender As Object, e As MouseEventArgs) Handles grdOrcamentoComposicao.MouseClick

        Try

            ConfigurarFormacaoPreco()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCalcularDesconto_Click(sender As Object, e As EventArgs) Handles btnCalcularDesconto.Click

        Try

            Dim oForm As New frmVenOrcamentoDesconto
            oForm.txtPrecoVendaSemIPI.Value = txtPrecoVendaSemIPI.Value
            oForm.txtPrecoVendaSemIPINovo.Value = txtPrecoVendaSemIPI.Value
            oForm.txtPorcentagemMargemLucroAtual.Value = txtPorcentagemMargemLucro.Value
            oForm.txtValorLucroAtual.Value = txtValorLucro.Value
            oForm.CodigoOrcamento = lCodigoOrcamento

            oForm.ShowDialog()

            LoadFormacaoPreco()
            LoadGridComposicao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdAnalitico_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdAnalitico.RowDoubleClick

        Try

            If VerificaStatus() = False Then Exit Sub

            Dim oForm As New frmVenOrcamentoComposicao

            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.CodigoOrcamentoItem = grdAnalitico.GetValue("codigo")
            oForm.Tipo = "PRODUTO"
            oForm.TemPai = IIf(grdAnalitico.GetValue("codigo_orcamento_item_pai") > 0, True, False)
            oForm.Formulario = iFormulario
            oForm.Grupo = grdAnalitico.GetValue("grupo")

            If Not IsDBNull(grdAnalitico.GetValue("descricao_item")) Then
                oForm.txtDescricao.Text = grdAnalitico.GetValue("descricao_item")
            End If

            If Not IsDBNull(grdAnalitico.GetValue("quantidade_item")) Then
                oForm.txtQuantidade.Text = grdAnalitico.GetValue("quantidade_item")
            End If

            oForm.ShowDialog()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnImportarItem_Click(sender As Object, e As EventArgs) Handles btnImportarItem.Click

        Try

            Dim oForm As New frmVenOrcamentoComposicaoImportarItem
            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.Formulario = iFormulario

            oForm.ShowDialog()

            LoadGridComposicao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarCondicaoPagamento_Click(sender As Object, e As EventArgs) Handles btnCadastrarCondicaoPagamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCondicaoPagamento")

            'Carrega Combo            
            LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)

            cboCondicaoPagamento.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAtualizarListagem_Click(sender As Object, e As EventArgs) Handles btnAtualizarListagem.Click

        Try

            AtualizaValoresGeral()

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged

        Try

            Dim oSetting1 As New Janus.Windows.Common.SuperTipSettings

            LiberarCampos(True)

            If cboStatus.SelectedIndex = -1 Then Exit Sub

            'Só pode editar se o status for em elaboração
            If cboStatus.SelectedValue <> 1 Then
                LiberarCampos(False)
            End If

            Select Case cboStatus.SelectedValue
                Case 1
                    btnEstornarElaboracao.Text = "Enviar p/ Negociação"

                    oSetting1.HeaderText = "Enviar p/ Negociação"
                    oSetting1.Text = "Clique para alterar status do orçamento para: EM NEGOCIAÇÃO"
                    jstTip.SetSuperTip(btnEstornarElaboracao, oSetting1)

                    btnEstornarElaboracao.Enabled = True

                Case 2
                    btnEstornarElaboracao.Text = "Estornar para Elaboração"

                    oSetting1.HeaderText = "Estornar para Elaboração"
                    oSetting1.Text = "Clique para alterar status do orçamento para: EM ELABORAÇÃO"
                    jstTip.SetSuperTip(btnEstornarElaboracao, oSetting1)

                    btnEstornarElaboracao.Enabled = True


                Case Else : btnEstornarElaboracao.Enabled = False

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExibirFormacaoPreco_Click(sender As Object, e As EventArgs) Handles btnExibirFormacaoPreco.Click

        Try

            ExibirFormacaoPreco(IIf(bExibirFormacaoPreco = True, False, True))

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnRegistroAnterior_Click(sender As Object, e As EventArgs) Handles btnRegistroAnterior.Click

        Try

            If lblSimulacao.Visible = True Then

                If MsgBox("Deseja excluir a simulação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Simulação") = vbNo Then
                    Exit Sub
                Else
                    'Excluir o orçamento
                    ExecuteQuery("sp_delete_venda_orcamento " & oClsUsrVenOrcamentoLegado.CodigoOrcamento & "," & goUsuario.iEmpresa)

                End If

            End If

            If lCodigoOrcamento <= 0 Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_venda_orcamento_codigo " & lCodigoOrcamento & ", 1, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Editar(lCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProximoRegistro_Click(sender As Object, e As EventArgs) Handles btnProximoRegistro.Click

        Try

            If lblSimulacao.Visible = True Then

                If MsgBox("Deseja excluir a simulação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Simulação") = vbNo Then
                    Exit Sub
                Else
                    'Excluir o orçamento
                    ExecuteQuery("sp_delete_venda_orcamento " & oClsUsrVenOrcamentoLegado.CodigoOrcamento & "," & goUsuario.iEmpresa)

                End If

            End If

            If lCodigoOrcamento <= 0 Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_venda_orcamento_codigo " & lCodigoOrcamento & ", 2, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Editar(lCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnEstornarEmail_Click(sender As Object, e As EventArgs) Handles btnEstornarElaboracao.Click

        Try

            Select Case cboStatus.SelectedValue
                Case 1 : AlterarStatusNegociacao()  'Enviar p/ Negociação
                Case 2 : EstornarEmail() 'Estornar para Elaboração
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnGerarSimulacao_Click(sender As Object, e As EventArgs) Handles btnGerarSimulacao.Click

        Try

            GerarSimulacao(oClsUsrVenOrcamentoLegado.CodigoOrcamento)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCalcularLucro_Click(sender As Object, e As EventArgs) Handles btnCalcularLucro.Click

        Try

            Dim oForm As New frmVenOrcamentoMargemLucro
            oForm.txtCustoTotal.Value = txtValorCustoTotal.Value
            oForm.txtDespesaVariavel.Value = txtValorDespesasVariaveis.Value
            oForm.txtDespesaFixa.Value = txtValorDespesasFixas.Value
            oForm.txtPorcentagemMargemLucro.Value = txtPorcentagemMargemLucro.Value
            oForm.txtValorLucro.Value = txtValorLucro.Value
            oForm.txtPrecoVenda.Value = txtPrecoVendaSemIPI.Value
            oForm.DespesaFixa = txtPorcentagemDespesasFixas.Value
            oForm.DespesaVariavel = txtPorcentagemDespesasVariaveis.Value
            oForm.CodigoOrcamento = lCodigoOrcamento

            oForm.ShowDialog()

            LoadFormacaoPreco()
            LoadGridComposicao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


    Private Sub grdOrcamentoCheckListCliente_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoCheckListCliente.CellUpdated
        Try

            If ValidaCheckList() = False Then Exit Sub
            'If VerificaStatus() = False Then Exit Sub

            If grdOrcamentoCheckListCliente.GetValue("tipo") = "REQUISITO DO ORÇAMENTO" Then

                oClsUsrVenOrcamentoLegado.UpdateChecklistCliente(lCodigoOrcamento:=lCodigoOrcamento,
                                                                iCodigoCheklistCliente:=grdOrcamentoCheckListCliente.GetValue("codigo"),
                                                                bImpressoProposta:=grdOrcamentoCheckListCliente.GetValue("impresso_proposta"),
                                                                bExportadoParaOP:=grdOrcamentoCheckListCliente.GetValue("exportado_ordem_producao"))

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                frmMain.Informacao("Só é Possivel Editar REQUISITO DO ORÇAMENTO", Color.Red)
                LoadGridChecklistCliente()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnInserirArquivo_Click(sender As Object, e As EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoArquivo() = False Then Exit Sub

            SalvarArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(sender As Object, e As EventArgs) Handles btnExcluirArquivo.Click

        Try

            DeleteArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(sender As Object, e As EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : VisualizarArquivo(grdArquivo.GetValue("caminho_arquivo"))

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#Region "::: TEXTO PADRÃO :::"
    Private Sub btnCadastrarObservacao_Click(sender As Object, e As EventArgs) Handles btnCadastrarObservacao.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAutotexto")

            'Seta Focu
            txtObservacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub btnProcurarObservacao_Click(sender As Object, e As EventArgs) Handles btnProcurarObservacao.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindAutotexto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Autotexto"

            'Seta Parametros
            Select Case sender.Name
                Case "btnProcurarObservacao" : iTipoAutoTextoFind = TipoAutotexto.ObservacaoVenda : oEditBoxFind = txtObservacao
            End Select

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            Select Case sender.Name
                Case "btnProcurarObservacaoCompra" : txtObservacao.Focus()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub


    Private Sub txtObservacao_LostFocus(sender As Object, e As EventArgs) Handles txtObservacao.LostFocus
        Try

            SalvarTextoObservacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub



#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS "

    Private Sub ConfigurarUserControl()

        Try

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboOrcamentista, "sp_select_combo_cadastro_basico_usuario " & goUsuario.iEmpresa & "," & goUsuario.iUsuario)
            LoadCombo(cboUsuarioAssinaturaDigital, "sp_select_combo_cadastro_basico_usuario " & goUsuario.iEmpresa & "," & goUsuario.iUsuario)
            LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
            LoadCombo(cboStatus, "sp_select_combo_static_status_venda_orcamento", False)
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_venda_orcamento", False)
            LoadComboGrid(grdCheckList, "resposta", "sp_select_combo_venda_orcamento_checklist_sim_nao")
            LoadComboGrid(grdOrcamentoComposicao, "codigo_unidade_medida", "sp_select_combo_cadastro_basico_unidade_medida_comercial " & goUsuario.iEmpresa)
            LoadComboGrid(grdListagem, "orcamentista", "sp_select_combo_cadastro_basico_usuario " & goUsuario.iEmpresa & "," & goUsuario.iUsuario)
            LoadComboGrid(grdOrcamentoComposicao, "tipo_negocio", "sp_select_combo_static_tipo_negocio")


            dtpDataOrcamentoFiltroInicio.Checked = False : dtpDataOrcamentoFiltroInicio.Value = DateAdd(DateInterval.Month, -1, Now)
            dtpDataOrcamentoFiltroTermino.Checked = False : dtpDataOrcamentoFiltroTermino.Value = Now

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdCheckList, iFormulario)
            ConfiguraGrid(grdOrcamentoCheckListCliente, iFormulario)
            ConfiguraGrid(grdDetalhe, iFormulario)
            ConfiguraGrid(grdOrcamentoComposicao, iFormulario)
            ConfiguraGrid(grdHistorico, iFormulario)
            ConfiguraGrid(grdProducao, iFormulario)

            'Composição individual do menu
            AddMenuGrid(grdOrcamentoComposicao)
            AddMenuGrid(grdOrcamentoCheckListCliente)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            txtNumeroOrcamentoFiltro.Focus()

            If Me.Tag.ToString.Contains("ID:") = True Then
                Editar(Convert.ToInt64(Me.Tag.ToString.Replace("ID:", "")))
            End If

            If goUsuario.iUsuario <> 1 Then
                grdOrcamentoComposicao.DynamicFiltering = False
            End If

            ConfiguraGridOrcamentoAdm(grdOrcamentoComposicao, VerificaDireito(iFormulario, gcAdministrator))

            grdOrcamentoComposicao.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub LoadArquivoObservacao(ByVal lCodigo As Long,
                                      ByVal bCriar As Boolean)
        Try
            'Seta o caminho
            sCaminhoArquivoObservacao = LoadConfiguracao("tb_cfg_interacti", "pasta_arquivo_observacao_orcamento") & CStr(lCodigo) & ".doc"

            If bCriar = True Then
                If System.IO.File.Exists(sCaminhoArquivoObservacao) Then
                    System.IO.File.Delete(sCaminhoArquivoObservacao)
                End If

                System.IO.File.Copy(goCrystalReport.sPath & "documento.doc", sCaminhoArquivoObservacao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarObservacao()

        Try

            sCaminhoArquivoObservacao = LoadConfiguracao("tb_cfg_interacti", "pasta_arquivo_observacao_orcamento") & CStr(lCodigoOrcamento) & ".doc"

            If Not System.IO.File.Exists(sCaminhoArquivoObservacao) Then
                'System.IO.File.Create(sCaminhoArquivoObservacao)
                System.IO.File.Copy(goCrystalReport.sPath & "documento_padrao.doc", sCaminhoArquivoObservacao)

            End If



            'Abre o arquivo para edição
            Process.Start(sCaminhoArquivoObservacao)

            PreviewContainer.Refresh()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadObservacao()

        Try

            btnEditarObservacao.Visible = True

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta o link para exibir
            PreviewContainer.CreateLink(sCaminhoArquivoObservacao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteItem()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdOrcamentoComposicao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    For Each oRow As GridEXRow In gSelecaoRow

                        Dim iItensVinculados As Integer
                        iItensVinculados = LoadCodigo("sp_validade_vendas_orcamento_item_excluir " & lCodigoOrcamento & ", " & oRow.Cells("codigo").Value & ", " & goUsuario.iEmpresa)

                        If iItensVinculados > 0 Then
                            MsgBox("Não é possível excluir o item pois existe um vínculo com o pedido.", MsgBoxStyle.Exclamation, "Validação")
                            Exit Sub
                        End If

                    Next

                    For Each oRow As GridEXRow In gSelecaoRow

                        oClsUsrVenOrcamentoLegado.DeleteItem(lCodigoOrcamento,
                                                             oRow.Cells("codigo").Value)

                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirOrcamento()

        Try

            'Verifica se o usuário tem direito de Imprimir
            If VerificaDireito(iFormulario, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            LoadArquivoObservacao(lCodigoOrcamento, False)

            If Not System.IO.File.Exists(sCaminhoArquivoObservacao) Then
                'System.IO.File.Create(sCaminhoArquivoObservacao)
                System.IO.File.Copy(goCrystalReport.sPath & "documento_padrao.doc", sCaminhoArquivoObservacao)

            End If

            'Váriaveis - Locais
            Dim sReport As String

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "ORÇAMENTO"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Seta Váriavel
            sReport &= ".rpt"

            If sReport.ToUpper.Contains("VEN000000001.RPT") Then

                If System.IO.File.Exists(goCrystalReport.sPath & "orcamento.doc") Then

                    Try
                        System.IO.File.Delete(goCrystalReport.sPath & "orcamento.doc")
                    Catch ex As Exception
                        MsgBox("Erro ao imprimir o relatório!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End Try

                End If

                System.IO.File.Copy(sCaminhoArquivoObservacao, goCrystalReport.sPath & "orcamento.doc")


            End If

            'Verifica se o Arquivo existe,
            If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                Exit Sub
            End If

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(0)
            Dim i As Integer = 0

            'Seta Parametros
            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_orcamento"
            goCrystalReport.sReportParameter(i).sValue = lCodigoOrcamento : i += 1 : ReDim Preserve goCrystalReport.sReportParameter(i)

            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(i).sValue = goUsuario.iEmpresa

            If sReport.ToUpper.Contains("DETALHE") = False Then
                i += 1 : ReDim Preserve goCrystalReport.sReportParameter(i)
                goCrystalReport.sReportParameter(i).sParamenter = "usuario"
                goCrystalReport.sReportParameter(i).sValue = goUsuario.sUsuario
            End If

            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill
            Dim sNomeArquivo As String = txtNumeroOrcamento.Text + "-" + (cboCliente.Text + "-" + txtDocumentoCliente.Text).Replace("/", "-").Replace("\", "-")

            'Abre Relatório
            frmMain.LoadPageReport("VEN000000001", "Orçamento", oReport, Nothing, sNomeArquivo)

            AlterarStatusNegociacao()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ConfigurarSizeGrid(ByVal bVisible As Boolean)

        Try

            If bVisible = False Then

                tabDetalhe.Visible = False
                grdOrcamentoComposicao.Size = New Size(pagComposicao.Size.Width - 16, grdOrcamentoComposicao.Size.Height)

            Else

                'Primeiro carrega os campos e depois faz as validações de exibição
                oClsUsrVenOrcamentoLegado.LoadDadosFormacaoPreco(lCodigoOrcamento,
                                                                 grdOrcamentoComposicao.GetValue("codigo"),
                                                                 txtCustoTotal,
                                                                 txtDespesaVariavel,
                                                                 txtDespesaFixa,
                                                                 txtLucroValor,
                                                                 txtPrecoVenda,
                                                                 txtAliquotaIPI,
                                                                 txtValorComIPI,
                                                                 txtDespesaVariavelPorcentagem,
                                                                 txtDespesaFixaPorcentagem,
                                                                 txtLucroPorcentagem,
                                                                 txtDescontoPorcentagem,
                                                                 Nothing,
                                                                 bMultiplica:=True)

                oClsUsrVenOrcamentoLegado.LoadGraficoComposicao(chrComposicao,
                                                               lCodigoOrcamento,
                                                               grdOrcamentoComposicao.GetValue("codigo"),
                                                               False)

                txtPrecoVendaPorcentagem.Value = 1
                txtCustoTotalPorcentagem.Value = txtPrecoVendaPorcentagem.Value - txtDespesaFixaPorcentagem.Value - txtDespesaVariavelPorcentagem.Value - txtLucroPorcentagem.Value
                txtValorDesconto.Value = txtPrecoVenda.Value * txtDescontoPorcentagem.Value

                grdOrcamentoComposicao.Size = New Size(pagComposicao.Size.Width - 300, pagComposicao.Size.Height - 15)
                tabDetalhe.Visible = True
                tabDetalhe.Location = New Point(grdOrcamentoComposicao.Location.X + grdOrcamentoComposicao.Size.Width + 6, grdOrcamentoComposicao.Location.Y)
                tabDetalhe.Size = New Size(pagComposicao.Size.Width - grdOrcamentoComposicao.Size.Width - 22, grdOrcamentoComposicao.Size.Height)

                'Tip do Custo
                Dim oSetting As New Janus.Windows.Common.SuperTipSettings
                Dim dCustoTotal As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_custo_total', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)

                oSetting.HeaderText = "Composição do Valor"
                oSetting.Text = "Custo Total: " + dCustoTotal.ToString("C")
                jstTip.SetSuperTip(txtCustoTotal, oSetting)

                'Tip do IPI
                Dim oSetting1 As New Janus.Windows.Common.SuperTipSettings
                Dim dValorIPI As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_ipi', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim dPrecoVenda As Double = txtPrecoVenda.Value

                oSetting1.HeaderText = "Composição do Valor"
                oSetting1.Text = "Preço de Venda: " + dPrecoVenda.ToString("C") + Environment.NewLine + "Valor de IPI: " + dValorIPI.ToString("C")
                jstTip.SetSuperTip(txtValorComIPI, oSetting1)

                'Tip da Despesa Variável
                Dim oSetting2 As New Janus.Windows.Common.SuperTipSettings
                Dim dValorICMS As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_icms', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim dValorPIS As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_pis', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim dValorCOFINS As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_cofins', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim dValorISS As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_iss', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim dValorIR As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_ir', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim dValorCSLL As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_csll', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim dValorComissao As Double = LoadCodigo("sp_load_venda_orcamento_item_coluna " & "'valor_comissao', 1, " & lCodigoOrcamento & "," & IIf(IsNothing(grdOrcamentoComposicao.GetValue("codigo")), -1, grdOrcamentoComposicao.GetValue("codigo")) & ", " & goUsuario.iEmpresa)
                Dim sAux As String

                sAux = IIf(dValorICMS <= 0, "", "Valor de ICMS: " + dValorICMS.ToString("C") + Environment.NewLine)
                sAux += IIf(dValorPIS <= 0, "", "Valor de PIS: " + dValorPIS.ToString("C") + Environment.NewLine)
                sAux += IIf(dValorCOFINS <= 0, "", "Valor de COFINS: " + dValorCOFINS.ToString("C") + Environment.NewLine)
                sAux += IIf(dValorISS <= 0, "", "Valor de ISS: " + dValorISS.ToString("C") + Environment.NewLine)
                sAux += IIf(dValorIR <= 0, "", "Valor de IR: " + dValorIR.ToString("C") + Environment.NewLine)
                sAux += IIf(dValorCSLL <= 0, "", "Valor de CSLL: " + dValorCSLL.ToString("C") + Environment.NewLine)
                sAux += IIf(dValorComissao <= 0, "", "Valor de Comissão: " + dValorComissao.ToString("C") + Environment.NewLine)

                oSetting2.HeaderText = "Composição do Valor"
                oSetting2.Text = sAux
                jstTip.SetSuperTip(txtDespesaVariavel, oSetting2)

                'Se não tiver pai, tem formação de preço e composição (grupo)
                If grdOrcamentoComposicao.GetValue("codigo_orcamento_item_pai") <= 0 Then

                    If tabDetalhe.TabPages.Contains(pagFormacaoPreco) = False Then
                        If tabDetalhe.TabPages.Contains(pagGrupo) = True Then tabDetalhe.TabPages.Remove(pagGrupo)
                        tabDetalhe.TabPages.Add(pagFormacaoPreco)
                    End If

                    If tabDetalhe.TabPages.Contains(pagGrupo) = False Then tabDetalhe.TabPages.Add(pagGrupo)

                    tabDetalhe.SelectedTab = pagFormacaoPreco

                Else 'Se tiver pai, tem só composição (grupo)
                    If tabDetalhe.TabPages.Contains(pagFormacaoPreco) = True Then tabDetalhe.TabPages.Remove(pagFormacaoPreco)
                    If tabDetalhe.TabPages.Contains(pagGrupo) = False Then tabDetalhe.TabPages.Add(pagGrupo)
                End If

            End If

            btnAtualizarListagem.Location = New Point(grdOrcamentoComposicao.Location.X + 2, grdOrcamentoComposicao.Location.Y + grdOrcamentoComposicao.Size.Height - 17)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Duplicar()

        Try

            If MsgBox("Deseja duplicar este orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.Duplicar(grdListagem.GetValue("codigo"))

            Editar(oClsUsrVenOrcamentoLegado.CodigoOrcamento)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarPedido(ByVal lCodigo As Long)

        Try

            'Se estiver em negociação
            If (grdListagem.GetValue("status") = 2 Or grdListagem.GetValue("status") = 1) Or (grdListagem.GetValue("status") = 3 And IsDBNull(grdListagem.GetValue("pedido_venda"))) Then

                If ValidacaoPedido(lCodigo) = False Then Exit Sub

                If MsgBox("Deseja aprovar e gerar um pedido de venda para esse orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

                oClsUsrVenOrcamentoLegado.InsertPedidoVenda(lCodigo)

                EditarPedido()

                frmMain.Informacao("Pedido de venda gerado com sucesso.", Drawing.Color.AliceBlue)

                LoadGrid()

            Else
                MsgBox("Não é possível gerar um pedido de venda para esse orçamento devido a seu status.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AlterarStatusNegociacao(ByVal lCodigo As Long)

        Try

            'Se estiver em negociação
            If grdListagem.GetValue("status") = 1 Then

                If MsgBox("Deseja alterar o status desse orçamento para 'Em Negociação'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

                If ValidacaoPedido(lCodigo) = False Then Exit Sub

                oClsUsrVenOrcamentoLegado.UpdateStatusNegociacao(lCodigo)

                LoadGrid()

                GerarPedido(lCodigo)

            Else
                MsgBox("Só é possível alterar o status de orçamentos que estão 'Em Elaboração'.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPedido()

        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrVenPedidoLegado")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(oClsUsrVenOrcamentoLegado.CodigoPedidoVenda)

            frmMain.LoadPage("Pedido Venda", "Pedido de Venda", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPedidoListagem()

        Try

            Dim lCodigo As Long = -1

            If IsDBNull(grdListagem.GetValue("codigo_pedido_venda")) Then
                MsgBox("Não há pedido de venda para este orçamento.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If grdListagem.GetValue("codigo_pedido_venda").ToString.Contains(",") Then

                Dim oForm As New frmVenOrcamentoEscolherPedidoVenda
                oForm.Codigos = grdListagem.GetValue("codigo_pedido_venda")

                oForm.ShowDialog()

                lCodigo = oForm.Codigo

            Else

                lCodigo = grdListagem.GetValue("codigo_pedido_venda")

            End If

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            If lCodigo <= 0 Then Exit Sub

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrVenPedidoLegado")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID2:" + CStr(lCodigo)

            frmMain.LoadPage("Pedido Venda", "Pedido de Venda", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrdemProducao()

        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(grdProducao.GetValue("codigo"))

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrdemProducao2()

        Try

            Dim lCodigo As Long = -1

            If IsDBNull(grdListagem.GetValue("codigo_ordem_producao")) Then
                MsgBox("Não há ordem de produção este orçamento.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If grdListagem.GetValue("codigo_ordem_producao").ToString.Contains(",") Then

                Dim oForm As New frmVenOrcamentoEscolherOrdemProducao
                oForm.Codigos = grdListagem.GetValue("codigo_ordem_producao")

                oForm.ShowDialog()

                lCodigo = oForm.Codigo

            Else

                lCodigo = grdListagem.GetValue("codigo_ordem_producao")

            End If

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            If lCodigo <= 0 Then Exit Sub

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(lCodigo)

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPedido(ByVal lCodigo As Long) As Boolean

        Try

            Dim sMensagem As String = ""

            oClsUsrVenOrcamentoLegado.ValidacaoPedidoVenda(lCodigo, sMensagem)

            If sMensagem <> "" Then
                MsgBox(sMensagem)
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Editar(ByVal lCodigo As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                frmMain.errInfo.Clear()
                LimparCamposGroupBox(grpDados)
                txtObservacao.Text = ""

                lblSimulacao.Visible = False

                Cursor.Current = Cursors.WaitCursor

                lCodigoOrcamento = lCodigo
                oClsUsrVenOrcamentoLegado.CodigoOrcamento = lCodigoOrcamento
                ExibirFormacaoPreco(False)

                oClsUsrVenOrcamentoLegado.LoadDados(lCodigoOrcamento,
                                                    txtNumeroOrcamento,
                                                    dtpDataOrcamento,
                                                    cboCliente,
                                                    cboOrcamentista,
                                                    dtpDataValidade,
                                                    txtDocumentoCliente,
                                                    txtContato,
                                                    txtTitulo,
                                                    cboCondicaoPagamento,
                                                    cboStatus,
                                                    txtRevisao,
                                                    txtDataEnvioEmail,
                                                    cboUsuarioAssinaturaDigital,
                                                    cboNumeroContrato,
                                                    txtObservacao)

                LoadGridComposicao()
                LoadGridArquivo()

                oClsUsrVenOrcamentoLegado.LoadGridCheckList(grdCheckList,
                                                            lCodigoOrcamento)

                LoadGridChecklistCliente()

                If tabMain.SelectedTab.Key = pagLista.Key Then
                    tabMain.TabPages.Remove(pagLista)
                    tabMain.TabPages.Add(pagDados)
                End If

                tabDados.SelectedTab = pagComposicao

                txtNumeroOrcamento.Focus()

                If VerificaDireito(iFormulario, gcAdministrator) = False Then
                    tabDados.TabPages.Remove(pagAnalitico)
                    tabDados.TabPages.Remove(pagPreco)
                End If

                btnExibirFormacaoPreco.Visible = VerificaDireito(iFormulario, gcAdministrator)

                'Carrega o arquivo
                LoadArquivoObservacao(lCodigoOrcamento, False)

                If Not System.IO.File.Exists(sCaminhoArquivoObservacao) Then
                    'System.IO.File.Create(sCaminhoArquivoObservacao)
                    System.IO.File.Copy(goCrystalReport.sPath & "documento_padrao.doc", sCaminhoArquivoObservacao)

                End If

                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridComposicao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridComposicao(grdOrcamentoComposicao,
                                                         lCodigoOrcamento)


            ConfigurarSizeGrid(bExibirFormacaoPreco)

            ConfiguraGrid(grdOrcamentoComposicao, iFormulario)

            AjustarChildTables(grdOrcamentoComposicao)

            ConfiguraGridOrcamentoAdm(grdOrcamentoComposicao, VerificaDireito(iFormulario, gcAdministrator))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridChecklistCliente()

        Try

            oClsUsrVenOrcamentoLegado.LoadGridChecklistCliente(grdOrcamentoCheckListCliente,
                                                               lCodigoOrcamento)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrVenOrcamentoLegado.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LimparOrcamento()

        Try

            lCodigoOrcamento = -1

            LimparCamposGroupBox(grpControl)
            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpFormacaoPreco)
            LimparCamposGroupBox(grpArquivo)

            btnSalvar.Tag = ""
            grdCheckList.DataSource = Nothing
            grdOrcamentoCheckListCliente.DataSource = Nothing
            grdOrcamentoComposicao.DataSource = Nothing
            grdDetalhe.DataSource = Nothing
            grdArquivo.DataSource = Nothing
            grdHistorico.DataSource = Nothing
            grdAnalitico.DataSource = Nothing
            chrComposicao.Series.Clear()
            chrComposicaoCusto.Series.Clear()
            chrComposicaoPreco.Series.Clear()

            LoadFormacaoPreco()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Dim oForm As New frmVenOrcamentoNovoOpcao
            'oForm.ShowDialog()

            'Recebe a opção
            'iOpcao = oForm.Opcao

            'Se não escolher opção
            'If iOpcao = -1 Then Exit Sub
            lblSimulacao.Visible = False
            LimparOrcamento()

            Dim lNumeroOrcamento As Long

            'Reserva numeração e gera um codigo
            oClsUsrVenOrcamentoLegado.GerarCodigo(lNumeroOrcamento, lCodigoOrcamento)
            txtNumeroOrcamento.Text = lNumeroOrcamento
            cboStatus.SelectedValue = 1

            'Forçar a preencher o dataset, mesmo sem registro
            LoadGridComposicao()

            'If iOpcao = 1 Then
            oClsUsrVenOrcamentoLegado.InsertChecklistLimpo(lCodigoOrcamento)
            oClsUsrVenOrcamentoLegado.LoadGridCheckList(grdCheckList, lCodigoOrcamento)
            tabDados.SelectedTab = pagChecklist
            'End If

            'Se a opção for importar a planilha
            'If iOpcao = 3 Then ImportarPlanilha()
            'If iOpcao = 2 Then ClonarOrcamento()

            txtNumeroOrcamento.Focus()
            cboOrcamentista.SelectedValue = goUsuario.iUsuario

            'Verifica o arquivo para excluir
            LoadArquivoObservacao(lCodigoOrcamento, False)
            System.IO.File.Delete(sCaminhoArquivoObservacao)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ClonarOrcamento()
        Try

            'Criar form para escolher orçamento e clonar

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            If VerificaStatus(False) = False Then Exit Sub

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Insere os dados da CAPA
            oClsUsrVenOrcamentoLegado.UpdateOrcamento(lCodigoOrcamento,
                                                      txtNumeroOrcamento.Text.Trim,
                                                      dtpDataOrcamento.Value,
                                                      cboCliente.SelectedValue,
                                                      cboOrcamentista.SelectedValue,
                                                      txtDocumentoCliente.Text.Trim,
                                                      txtContato.Text.Trim,
                                                      txtTitulo.Text.Trim,
                                                      IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue),
                                                      dtpDataValidade.Value,
                                                      IIf(cboUsuarioAssinaturaDigital.SelectedIndex = -1, -1, cboUsuarioAssinaturaDigital.SelectedValue),
                                                      IIf(cboNumeroContrato.SelectedIndex = -1, -1, cboNumeroContrato.SelectedValue))

            For Each oRow As GridEXRow In grdCheckList.GetRows

                oClsUsrVenOrcamentoLegado.UpdateCheckList(lCodigoOrcamento,
                                                          oRow.Cells("codigo").Value,
                                                          oRow.Cells("resposta").Value,
                                                          IIf(IsDBNull(oRow.Cells("observacao").Value), "", oRow.Cells("observacao").Value))

            Next

            AtualizaValoresGeral()
            ConfigurarFormacaoPreco()

            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsUsrVenOrcamentoLegado.LoadGrid(grdListagem,
                                               IIf(IsNumeric(txtNumeroOrcamentoFiltro.Text.Trim), txtNumeroOrcamentoFiltro.Text.Trim, -1),
                                               txtClienteFiltro.Text.Trim,
                                               IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue),
                                               IIf(dtpDataOrcamentoFiltroInicio.Checked = False, "", dtpDataOrcamentoFiltroInicio.Value),
                                               IIf(dtpDataOrcamentoFiltroTermino.Checked = False, "", dtpDataOrcamentoFiltroTermino.Value),
                                               txtNdesenho.Text.Trim,
                                               txtFiltroGeral.Text.Trim
                                               )


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboCliente, lblCliente) = False Then Return False
            If ValidaCampo(cboOrcamentista, lblOrcamentista) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub AtualizarComposicao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub

            With grdOrcamentoComposicao.CurrentRow

                If IsDBNull(grdOrcamentoComposicao.GetValue("quantidade")) Then
                    MsgBox("Informe uma quantidade válida para este item.", MsgBoxStyle.Exclamation, "Validação")
                    Exit Sub
                End If

                If IsDBNull(grdOrcamentoComposicao.GetValue("tipo_negocio")) Then
                    MsgBox("Informe um Tipo de Negócios válido para este item.", MsgBoxStyle.Exclamation, "Validação")
                    Exit Sub
                End If

                Dim oForm As New frmVenOrcamentoComposicao

                oForm.CodigoOrcamento = lCodigoOrcamento
                oForm.CodigoOrcamentoItem = .Cells.Item("codigo").Value
                oForm.Tipo = .Cells.Item("tipo_item_orcamento").Value
                oForm.TemPai = IIf(.Cells.Item("codigo_orcamento_item_pai").Value > 0, True, False)
                oForm.Formulario = iFormulario
                oForm.PermissaoEditar = IIf(cboStatus.SelectedValue <> 1, False, True)
                oForm.CodigoContrato = IIf(cboNumeroContrato.SelectedIndex = -1, -1, cboNumeroContrato.SelectedValue)

                If Not IsDBNull(.Cells.Item("descricao").Value) Then
                    oForm.txtDescricao.Text = .Cells.Item("descricao").Value
                End If

                If Not IsDBNull(.Cells.Item("quantidade").Value) Then
                    oForm.txtQuantidade.Text = .Cells.Item("quantidade").Value
                End If

                'Salva Dados do Registro
                Salvar()

                'Seta o form
                oForm.ShowDialog()


            End With

            LoadGridComposicao()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidaCheckList() As Boolean

        Try

            Dim sOpcao(2) As String
            sOpcao(0) = "NÃO"
            sOpcao(1) = "SIM"
            sOpcao(2) = "PARCIAL"

            For Each oRow As GridEXRow In grdCheckList.GetDataRows

                If IsDBNull(oRow.Cells("resposta").Value) Then
                    MsgBox("É necessário finalizar o checklist primeiro.", MsgBoxStyle.Exclamation, "Validação")
                    tabDados.SelectedTab = pagChecklist
                    Return False
                End If

                'Percorrer para saber as opções e se bloqueará
                For i As Integer = 0 To sOpcao.Count - 1

                    'Verificar o item da opção
                    Dim sAux As String = sOpcao(i)

                    If oRow.Cells.Item("resposta").Value = sAux And oRow.Cells.Item("opcao_" & sAux.Replace("Ã", "A").ToLower).Value = "BLOQUEAR" Then
                        MsgBox("Não é possível continuar o orçamento pois a resposta da análise [ " & oRow.Cells.Item("analise_critica").Value & " ] bloqueia o orçamento!", MsgBoxStyle.Exclamation, "Validação Checklist")
                        tabDados.SelectedTab = pagChecklist
                        Return False
                    End If

                    If oRow.Cells.Item("resposta").Value = sAux And oRow.Cells.Item("opcao_" & sAux.Replace("Ã", "A").ToLower).Value = "JUSTIFICAR" Then
                        If oRow.Cells("observacao").Value = "" Then

                            MsgBox("Não é possível continuar o orçamento pois a resposta da análise [ " & oRow.Cells.Item("analise_critica").Value & " ] precisa de justificativa!", MsgBoxStyle.Exclamation, "Validação Checklist")
                            tabDados.SelectedTab = pagChecklist
                            Return False

                        End If

                    End If

                Next

                If oRow.Cells.Item("resposta").Value = "PARCIAL" And oRow.Cells.Item("opcao_parcial").Value = "" Then
                    MsgBox("Não é possível continuar o orçamento pois a resposta da análise [ " & oRow.Cells.Item("analise_critica").Value & " ] não pode ser [ PARCIAL ]!", MsgBoxStyle.Exclamation, "Validação Checklist")
                    tabDados.SelectedTab = pagChecklist
                    Return False
                End If

            Next

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'Private Sub ImportarPlanilha()

    '    Try

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.WaitCursor

    '        oClsUsrVenOrcamentoLegado.CodigoOrcamento = lCodigoOrcamento

    '        oClsUsrVenOrcamentoLegado.ImportarPlanilha(grdImportacaoPlanilha, _
    '                                                   grdCheckList, _
    '                                                   txtNumeroOrcamento, _
    '                                                   dtpDataOrcamento, _
    '                                                   cboCliente, _
    '                                                   txtDocumentoCliente, _
    '                                                   txtContato)

    '        Dim sKeyPagSelecionada As String = tabDados.SelectedTab.Name
    '        tabDados.SelectedTab.Name = pagObservacao.Name

    '        'Insere os dados da CAPA
    '        oClsUsrVenOrcamentoLegado.UpdateOrcamento(lCodigoOrcamento, _
    '                                                  txtNumeroOrcamento.Text.Trim, _
    '                                                  dtpDataOrcamento.Value, _
    '                                                  cboCliente.SelectedValue, _
    '                                                  cboOrcamentista.SelectedValue, _
    '                                                  txtDocumentoCliente.Text.Trim, _
    '                                                  txtContato.Text.Trim, _
    '                                                  txtTitulo.Text.Trim, _
    '                                                  IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue), _
    '                                                  IIf(dtpDataValidade.Checked = False, "", dtpDataValidade.Value))

    '        'Insere os dados dos itens
    '        oClsUsrVenOrcamentoLegado.InsertOrcamentoItem(grdImportacaoPlanilha)

    '        'Insere o checklist
    '        oClsUsrVenOrcamentoLegado.InsertChecklist(grdCheckList)

    '        'Carrega o a composição
    '        LoadGridComposicao()

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.Default


    '    Catch ex As Exception
    '        TratamentoErro(ex.Message, Me.Parent.ToString)
    '    End Try
    'End Sub

    Private Sub LoadFormacaoPreco()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadDadosFormacaoPrecoGeral(lCodigoOrcamento, _
                                                                  txtValorCustoTotal, _
                                                                  txtPorcentagemDespesasFixas, _
                                                                  txtPorcentagemDespesasVariaveis, _
                                                                  txtPorcentagemMargemLucro, _
                                                                  txtPrecoVendaSemIPI, _
                                                                  txtValorIPI, _
                                                                  txtPrecoVendaComIPI, _
                                                                  txtValorDespesasFixas, _
                                                                  txtValorDespesasVariaveis, _
                                                                  txtValorLucro, _
                                                                  txtValorFrete)

            oClsUsrVenOrcamentoLegado.LoadDadosAnalise(lCodigoOrcamento,
                                                       txtValorPedido,
                                                       txtMateriaPrima,
                                                       txtServicoTerceiro,
                                                       txtComposicao,
                                                       txtICMS,
                                                       txtISS,
                                                       txtFrete,
                                                       txtOutrasDespesasVariaveis,
                                                       txtMargemContribuicao,
                                                       txtMaoObra,
                                                       txtDespesasFixas,
                                                       txtLucro)

            oClsUsrVenOrcamentoLegado.LoadGraficoAnalises(chrComposicaoCusto,
                                                          lCodigoOrcamento)

            CalculaGraficoFormacaoPreco()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AlterarItemPai()

        Try

            If VerificaStatus() = False Then Exit Sub

            Dim iCodigoOrcamentoItem As Integer = grdOrcamentoComposicao.GetValue("codigo_orcamento_item_pai")

            Dim oForm As New frmVenOrcamentoItemAlterarPai
            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.CodigoOrcamentoItem = grdOrcamentoComposicao.GetValue("codigo")
            oForm.ShowDialog()

            'Se o usuário tiver clicado em "Salvar", recalcula os valores
            If oForm.OperacaoRealizada = True Then

                Cursor.Current = Cursors.WaitCursor

                'Para recalcular os valores do item que era pai antes da alteração
                If iCodigoOrcamentoItem > 0 Then oClsUsrVenOrcamentoLegado.UpdateValoresPai(lCodigoOrcamento, iCodigoOrcamentoItem)

                'Para recalcular os valores do novo pai
                oClsUsrVenOrcamentoLegado.UpdateValoresPai(lCodigoOrcamento, grdOrcamentoComposicao.GetValue("codigo"))

                Cursor.Current = Cursors.Default

            End If

            LoadGridComposicao()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AlterarItemPaiConcatenado()

        Try

            Dim sCodigo As String = ""

            If grdOrcamentoComposicao.GetDataRows.Count = 1 Then
                MsgBox("Não é possível realizar essa ação pois o orçamento só tem 1 item pai.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdOrcamentoComposicao) = True Then

                For Each oRow As GridEXRow In gSelecaoRow
                    sCodigo += IIf(sCodigo = "", "", ";") & oRow.Cells("codigo").Value
                Next

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itens
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            Dim oForm As New frmVenOrcamentoItemAlterarPai
            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.CodigoOrcamentoItemConcatenado = sCodigo
            oForm.ShowDialog()

            'Se o usuário tiver clicado em "Salvar", recalcula os valores
            If oForm.OperacaoRealizada = True Then

                Cursor.Current = Cursors.WaitCursor

                For Each oRow As GridEXRow In gSelecaoRow

                    'Para recalcular os valores do item que era pai antes da alteração
                    Dim iCodigoOrcamentoItem As Integer = oRow.Cells("codigo_orcamento_item_pai").Value

                    If iCodigoOrcamentoItem > 0 Then oClsUsrVenOrcamentoLegado.UpdateValoresPai(lCodigoOrcamento, iCodigoOrcamentoItem)

                    'Para recalcular os valores do novo pai
                    oClsUsrVenOrcamentoLegado.UpdateValoresPai(lCodigoOrcamento, oRow.Cells("codigo").Value)

                Next

                Cursor.Current = Cursors.Default

                LoadGridComposicao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AlterarCodigoProduto()

        Try

            If VerificaStatus() = False Then Exit Sub

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            iCodigoTipoItemFind = 1

            'Seta Parametros
            oGridExOrcamento = grdOrcamentoComposicao

            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AdicionarFilho()

        Try

            If VerificaStatus() = False Then Exit Sub
            oClsUsrVenOrcamentoLegado.GerarCodigoItem(lCodigoOrcamento, grdOrcamentoComposicao.GetValue("codigo"))
            LoadGridComposicao()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarItemPai()

        Try

            If VerificaStatus() = False Then Exit Sub

            If IsDBNull(grdOrcamentoComposicao.GetValue("codigo_orcamento_item_pai")) Or grdOrcamentoComposicao.GetValue("codigo_orcamento_item_pai") <= 0 Then
                MsgBox("Este registro já é um item pai.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If MsgBox("Deseja transformar essa linha em um item pai?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.UpdateItemPai(grdOrcamentoComposicao.GetValue("codigo_orcamento"), _
                                                    grdOrcamentoComposicao.GetValue("codigo"))

            'Pra pegar o valor padrão de impostos do cliente
            oClsUsrVenOrcamentoLegado.UpdateItemPaiValores(grdOrcamentoComposicao.GetValue("codigo_orcamento"), _
                                                           grdOrcamentoComposicao.GetValue("codigo"))

            LoadGridComposicao()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaValoresGeral()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.UpdateValoresGeral(lCodigoOrcamento)

            LoadGridComposicao()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridAnalitico()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridAnalitico(grdAnalitico, _
                                                        lCodigoOrcamento)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridHistorico()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridHistorico(grdHistorico, _
                                                        lCodigoOrcamento)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridProducao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridProducao(grdProducao, _
                                                       lCodigoOrcamento)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LiberarCampos(ByVal bEnabled As Boolean)

        Try

            grpDados.Enabled = bEnabled
            btnCalcularDesconto.Enabled = bEnabled
            btnImportarItem.Enabled = bEnabled
            btnSalvar.Enabled = bEnabled

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function VerificaStatus(Optional ByVal bRetornarMsg As Boolean = True) As Boolean

        Try

            If cboStatus.SelectedIndex = -1 Then Return True
            If cboStatus.SelectedValue <> 1 Then

                If bRetornarMsg = True Then
                    MsgBox("Não é possível executar essa ação pois o orçamento não pode ser editado devido ao seu status.", MsgBoxStyle.Exclamation, "Validação")
                End If

                Return False

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CancelarItem()

        Try

            If grdListagem.GetValue("status") = 2 Then
                MsgBox("Não é possível cancelar um item sem quantidade pendente!", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If grdListagem.GetValue("status") = 3 Then
                MsgBox("Este item já está cancelado.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            Dim oForm As New frmVenOrcamentoCancelarItem
            oForm.CodigoOrcamento = grdListagem.GetValue("codigo_orcamento")
            oForm.CodigoOrcamentoItem = grdListagem.GetValue("codigo_orcamento_item")

            oForm.ShowDialog()

            LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoOrcamento()

        Try

            Dim oForm As New frmVenOrcamentoHistorico
            oForm.CodigoOrcamento = grdListagem.GetValue("codigo")
            oForm.txtNumeroOrcamento.Text = grdListagem.GetValue("numero_orcamento")
            oForm.txtDataOrcamento.Text = grdListagem.GetValue("data_orcamento")
            oForm.txtCliente.Text = grdListagem.GetValue("cliente")

            oForm.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoItem()

        Try

            Dim oForm As New frmVenOrcamentoHistoricoItem
            oForm.CodigoOrcamento = grdListagem.GetValue("codigo_orcamento")
            oForm.CodigoOrcamentoItem = grdListagem.GetValue("codigo_orcamento_item")

            oForm.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExibirFormacaoPreco(ByVal bExibir As Boolean)

        Try

            bExibirFormacaoPreco = bExibir

            Dim oSetting As New Janus.Windows.Common.SuperTipSettings

            oSetting.HeaderText = "Formação de Preço"
            oSetting.Text = "Clique para " & IIf(bExibirFormacaoPreco = True, "remover", "exibir") & " a formação de preço."
            jstTip.SetSuperTip(btnExibirFormacaoPreco, oSetting)

            ConfigurarFormacaoPreco()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ConfigurarFormacaoPreco()

        Try

            LimparCamposGroupBox(grpFormacaoPreco)
            grdDetalhe.DataSource = Nothing
            chrComposicao.Series.Clear()

            If bExibirFormacaoPreco = False Then
                ConfigurarSizeGrid(bExibirFormacaoPreco)
                Exit Sub
            End If

            If grdOrcamentoComposicao.GetRows.Count <= 0 Then Exit Sub

            If grdOrcamentoComposicao.CurrentRow.RowType <> RowType.Record Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridComposicaoDetalhe(grdDetalhe,
                                                                grdOrcamentoComposicao.GetValue("codigo_orcamento"),
                                                                grdOrcamentoComposicao.GetValue("codigo"),
                                                                2)

            ConfiguraGrid(grdDetalhe, iFormulario)

            If grdDetalhe.GetRows.Count > 0 Then ConfigurarSizeGrid(bExibirFormacaoPreco)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarRevisao()

        Try

            Dim lCodigo As Long = LoadCodigo("sp_load_venda_orcamento_pedido_venda_faturado_codigo " & grdListagem.GetValue("codigo") & "," & goUsuario.iEmpresa)

            If lCodigo > 0 Then
                MsgBox("Não é possível realizar o estorno pois existe um pedido de venda FATURADO ou PARCIALMENTO FATURADO para esse orçamento.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If MsgBox("Deseja gerar uma nova revisão do orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Revisão") <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.GerarRevisao(grdListagem.GetValue("codigo"))

            Editar(oClsUsrVenOrcamentoLegado.CodigoOrcamento)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AlterarStatusNegociacao()

        Try

            'Se o status for em elaboração, pergunta se quer alterar para em negociação, para casos onde o usuário só quer imprimir o orçamento
            If cboStatus.SelectedValue = 1 Then

                If MsgBox("Deseja confirmar o envio deste orçamento para o Cliente? O status do orçamento irá alterar para 'Em Negociação'.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    oClsUsrVenOrcamentoLegado.UpdateStatusNegociacao(lCodigoOrcamento)
                    cboStatus.SelectedValue = LoadCodigo("sp_load_venda_orcamento_status " & lCodigoOrcamento & "," & goUsuario.iEmpresa)
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EnviarEmailOrcamento()

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = "VEN000000001.rpt"

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_orcamento", lCodigoOrcamento)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Arquivo
            Dim sArquivo As String = System.IO.Path.GetTempPath
            sArquivo &= txtNumeroOrcamento.Text & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            EnviarEmail("Orçamento N° " & txtNumeroOrcamento.Text & IIf(txtDocumentoCliente.Text <> "", " - " & txtDocumentoCliente.Text.Trim, ""), _
                        LoadCodigo("sp_load_venda_orcamento_email_cliente " & lCodigoOrcamento & "," & goUsuario.iEmpresa), _
                        sArquivo, _
                        sArquivo, _
                        "", _
                        IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue), _
                        "", _
                        -1, _
                        -1, _
                        TipoAutotextoEmail.OrcamentoVenda)

            oClsUsrVenOrcamentoLegado.UpdateEnvioEmail(lCodigoOrcamento)
            txtDataEnvioEmail.Text = LoadCodigo("sp_load_venda_orcamento_data_envio_email " & lCodigoOrcamento & "," & goUsuario.iEmpresa)

            AlterarStatusNegociacao()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EstornarEmail()

        Try

            Dim lCodigo As Long = LoadCodigo("sp_load_venda_orcamento_pedido_venda_codigo " & lCodigoOrcamento & "," & goUsuario.iEmpresa)

            If lCodigo > 0 Then
                MsgBox("Não é possível realizar o estorno pois existe um pedido de venda para esse orçamento.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If MsgBox("Deseja realizar essa ação? O status do orçamento voltará para 'Em Elaboração'.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            oClsUsrVenOrcamentoLegado.UpdateEnvioEmailEstorno(lCodigoOrcamento)

            cboStatus.SelectedValue = LoadCodigo("sp_load_venda_orcamento_status " & lCodigoOrcamento & "," & goUsuario.iEmpresa)
            txtDataEnvioEmail.Text = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Declinar()

        Try

            If grdListagem.GetValue("status") = 1 Or grdListagem.GetValue("status") = 2 Then

                Dim oForm As New frmVenOrcamentoDeclinar
                oForm.CodigoOrcamento = grdListagem.GetValue("codigo")
                oForm.ShowDialog()

                LoadGrid()

            Else
                MsgBox("Só é possível declinar um orçamento que esteja em elaboração ou em negociação.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Reprovar()

        Try

            If grdListagem.GetValue("status") = 1 Or grdListagem.GetValue("status") = 2 Then

                Dim oForm As New frmVenOrcamentoReprovar
                oForm.CodigoOrcamento = grdListagem.GetValue("codigo")
                oForm.ShowDialog()

                LoadGrid()

            Else
                MsgBox("Só é possível declinar um orçamento que esteja em elaboração ou em negociação.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub DuplicarItem()

        Try

            If VerificaStatus() = False Then Exit Sub

            If MsgBox("Deseja duplicar este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.DuplicarItem(lCodigoOrcamento, _
                                                   grdOrcamentoComposicao.GetValue("codigo"))

            LoadGridComposicao()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarSimulacao(ByVal lCodigo As Long)

        Try

            'Questiona o usuário
            If MsgBox("Deseja criar uma versão para simulação? Se não for salvo, ela será excluída automaticamente", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Gerar simulação") = vbNo Then Exit Sub

            Dim sOrcamento As String = txtNumeroOrcamento.Text

            'Duplica o registro
            oClsUsrVenOrcamentoLegado.Duplicar(lCodigo)

            'Chama o editar
            Editar(oClsUsrVenOrcamentoLegado.CodigoOrcamento)

            'Atualiza o status
            ExecuteQuery("sp_update_venda_orcamento_status_simulacao " & oClsUsrVenOrcamentoLegado.CodigoOrcamento & ", " & goUsuario.iUsuario & "," & goUsuario.iEmpresa)

            txtNumeroOrcamento.Text = sOrcamento
            txtRevisao.Text = "0"

            'Seta o label
            lblSimulacao.Visible = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaDataValidade()

        Try

            Dim iDiasDataValidade As Integer = LoadCodigo("sp_load_venda_orcamento_data_validade " & goUsuario.iEmpresa & "," & IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue))

            If iDiasDataValidade > 0 Then
                dtpDataValidade.Value = dtpDataOrcamento.Value.AddDays(iDiasDataValidade)
                dtpDataValidade.Enabled = False

            Else
                dtpDataValidade.Value = DateAdd(DateInterval.Day, 20, dtpDataOrcamento.Value)
                dtpDataValidade.Enabled = True

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaGraficoFormacaoPreco()

        Try

            Dim oDataReader(0) As DataTableReader
            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow

            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("grupo")
            oDataSet.Tables(0).Columns.Add("valor").DataType = 0.0.GetType
            oDataSet.Tables(0).Columns.Add("descricao")

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Custo"
            oDataRow(1) = (IIf(txtValorCustoTotal.Value = 0, 1, txtValorCustoTotal.Value) / IIf(txtValorPedido.Value = 0, 1, txtValorPedido.Value)) * 100
            oDataRow(2) = "R$ " + CStr(txtValorCustoTotal.Value)

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Despesa Variável"
            oDataRow(1) = txtPorcentagemDespesasVariaveis.Value
            oDataRow(2) = "R$ " + CStr(txtValorDespesasVariaveis.Value)

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Despesa Fixa"
            oDataRow(1) = txtPorcentagemDespesasFixas.Value
            oDataRow(2) = "R$ " + CStr(txtValorDespesasFixas.Value)

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Lucro"
            oDataRow(1) = txtPorcentagemMargemLucro.Value
            oDataRow(2) = "R$ " + CStr(txtValorLucro.Value)

            chrComposicaoPreco.Titles.Clear()
            chrComposicaoPreco.Series.Clear()

            If oDataSet.Tables(0).Rows.Count = 0 Then Exit Sub

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            'Adiciona Serie
            chrComposicaoPreco.Series.Add("main")
            chrComposicaoPreco.Titles.Add("Composição do Preço")

            'Carrega Grafico
            chrComposicaoPreco.Series("main").Points.DataBind(oDataReader(0), "grupo", "valor", "Tooltip=descricao")

            For j As Integer = 0 To chrComposicaoPreco.Series.Count - 1

                chrComposicaoPreco.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Pie
                chrComposicaoPreco.Series(j).ShowInLegend = True
                chrComposicaoPreco.Series(j).SmartLabels.Enabled = True
                chrComposicaoPreco.Series(j).MarkerSize = 1
                chrComposicaoPreco.Series(j).BorderWidth = 1
                chrComposicaoPreco.Series(j).EmptyPointStyle.Color = Color.Transparent
                chrComposicaoPreco.Series(j).BorderStyle = WinControl.ChartDashStyle.Solid
                chrComposicaoPreco.Series(j).BorderColor = Color.Black
                chrComposicaoPreco.Series(j).SmartLabels.AllowOutsidePlotArea = WinControl.LabelOutsidePlotAreaStyle.Yes
                chrComposicaoPreco.Series(j).LabelFormat = "0.00%"
                chrComposicaoPreco.Series(j).BorderColor = Color.FromArgb(255, 26, 59, 105)
                chrComposicaoPreco.Series(j).ShadowOffset = 2
                chrComposicaoPreco.Series(j).ShowLabelAsValue = True

            Next

            For Each oSeries As WinControl.Series In chrComposicaoPreco.Series

                For Each oDataPoint As WinControl.DataPoint In oSeries.Points

                    Select Case oDataPoint.AxisLabel

                        Case "Custo" : oDataPoint.Color = Color.Red
                        Case "Lucro" : oDataPoint.Color = Color.LightGreen
                        Case "Despesa Fixa" : oDataPoint.Color = Color.LightSalmon
                        Case "Despesa Variável" : oDataPoint.Color = Color.LightBlue

                    End Select

                Next

            Next

            chrComposicaoPreco.Series(0)("PieLabelStyle") = "Outside"
            chrComposicaoPreco.ChartAreas(0).Area3DStyle.Enable3D = False
            chrComposicaoPreco.ChartAreas(0).BackColor = Color.White
            chrComposicaoPreco.ChartAreas(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            chrComposicaoPreco.ChartAreas(0).ShadowOffset = 2
            chrComposicaoPreco.ChartAreas(0).BorderStyle = WinControl.ChartDashStyle.Solid
            chrComposicaoPreco.ChartAreas(0).AxisY.MajorGrid.LineStyle = WinControl.ChartDashStyle.Solid
            chrComposicaoPreco.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Silver
            chrComposicaoPreco.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Silver
            chrComposicaoPreco.ChartAreas(0).AxisX.MajorGrid.LineStyle = WinControl.ChartDashStyle.Solid
            chrComposicaoPreco.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            chrComposicaoPreco.ChartAreas(0).AxisX.Interval = 1
            chrComposicaoPreco.ChartAreas(0).ReCalc()
            chrComposicaoPreco.Legends(0).Alignment = StringAlignment.Center
            chrComposicaoPreco.Legends(0).Docking = WinControl.LegendDocking.Bottom
            chrComposicaoPreco.Legends(0).LegendStyle = WinControl.LegendStyle.Table
            chrComposicaoPreco.Legends(0).AutoFitText = False
            chrComposicaoPreco.Legends(0).BackColor = Color.White
            chrComposicaoPreco.Legends(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            chrComposicaoPreco.Legends(0).BorderStyle = WinControl.ChartDashStyle.Solid
            chrComposicaoPreco.Legends(0).BorderWidth = 1
            chrComposicaoPreco.Legends(0).DockInsideChartArea = True
            chrComposicaoPreco.BackColor = Color.WhiteSmoke
            chrComposicaoPreco.BackGradientEndColor = Color.White
            chrComposicaoPreco.BackGradientType = WinControl.GradientType.DiagonalLeft
            chrComposicaoPreco.BorderLineColor = Color.FromArgb(255, 26, 59, 105)
            chrComposicaoPreco.BorderLineStyle = WinControl.ChartDashStyle.Solid
            chrComposicaoPreco.BorderSkin.SkinStyle = WinControl.BorderSkinStyle.Emboss
            chrComposicaoPreco.BorderSkin.FrameBackColor = Color.CornflowerBlue
            chrComposicaoPreco.BorderSkin.FrameBackGradientEndColor = Color.CornflowerBlue
            chrComposicaoPreco.BorderSkin.PageColor = Color.FromArgb(255, 240, 240, 240)
            chrComposicaoPreco.UI.Toolbar.BorderSkin.SkinStyle = WinControl.BorderSkinStyle.Emboss
            chrComposicaoPreco.UI.Toolbar.BorderSkin.FrameBackColor = Color.Gray
            chrComposicaoPreco.UI.Toolbar.BorderSkin.PageColor = Color.Transparent
            chrComposicaoPreco.UI.Toolbar.Enabled = False

            'Pra formatar o valor do tooltip. Ex: "10000" -> "R$ 10.000,00"
            AddHandler chrComposicaoPreco.GetToolTipText, AddressOf Chart_GetToolTipText

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Chart_GetToolTipText(ByVal sender As Object, ByVal e As Dundas.Charting.WinControl.ToolTipEventArgs)

        Try

            For Each oPoint As WinControl.DataPoint In sender.series("main").points

                Dim dAux As Double = oPoint.ToolTip

                oPoint.ToolTip = dAux.ToString("C")

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: ARQUIVO :::"

    Private Function ValidacaoArquivo() As Boolean

        Try

            If ValidaCampo(txtTituloArquivo, lblTituloArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""

            txtTituloArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridArquivo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsUsrVenOrcamentoLegado.LoadGridArquivo(grdArquivo, _
                                                      lCodigoOrcamento)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_venda_orcamento " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            oClsUsrVenOrcamentoLegado.InsertArquivo(lCodigoOrcamento, _
                                                    txtTituloArquivo.Text.Trim, _
                                                    sFile)

            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrVenOrcamentoLegado.ExcluirArquivo(lCodigoOrcamento)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarArquivo(ByVal sArquivo As String)

        Try

            If sArquivo = "" Then MsgBox("Arquivo Inexistente.", MsgBoxStyle.Exclamation, "Validação") : Exit Sub

            Process.Start(sArquivo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TEXTO PADRÃO :::"

    Private Sub SalvarTextoObservacao()
        Try

            oClsUsrVenOrcamentoLegado.UpdateTextoObservacao(lCodigoOrcamento,
                                                            txtObservacao.Text.Trim)


            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region

#End Region

End Class