Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Dundas.Charting.WinControl.ChartTypes

Public Class frmVenOrcamentoComposicao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenOrcamentoLegado As New clsUsrVenOrcamentoLegado

    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer
    Private iCodigoOrcamentoItemGrupo As Integer
    Private iFormulario As Integer
    Private oCurrentRow As GridEXRow
    Private sTipo As String
    Private bTemPai As Boolean
    Private sGrupo As String
    Private sObservacao As String = ""
    Private bPermissaoEditar As Boolean
    Private bAdmOrcamento As Boolean
    Private iCodigoContrato As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoOrcamento As Long
        Set(value As Long)
            lCodigoOrcamento = value
        End Set
    End Property

    Public WriteOnly Property CodigoOrcamentoItem As Integer
        Set(value As Integer)
            iCodigoOrcamentoItem = value
        End Set
    End Property

    Public WriteOnly Property Formulario As Integer
        Set(value As Integer)
            iFormulario = value
        End Set
    End Property

    Public WriteOnly Property Tipo As String
        Set(value As String)
            sTipo = value
        End Set
    End Property

    Public WriteOnly Property TemPai As Boolean
        Set(value As Boolean)
            bTemPai = value
        End Set
    End Property

    Public WriteOnly Property Grupo As String
        Set(value As String)
            sGrupo = value
        End Set
    End Property

    Public Property PermissaoEditar() As Boolean
        Get
            Return bPermissaoEditar
        End Get
        Set(ByVal value As Boolean)
            bPermissaoEditar = value
        End Set
    End Property

    Public Property CodigoContrato() As Integer
        Get
            Return iCodigoContrato
        End Get
        Set(ByVal value As Integer)
            iCodigoContrato = value
        End Set
    End Property

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

                If oGrid.Name = "grdOrcamentoCheckListCliente" Then

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

                Else

                    Dim oUICommandCopiar As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandAdicionarLinha As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExcluirLinha As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandRemoverOrdenacao As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandConfigurarGrid As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandExportarExcel As New Janus.Windows.UI.CommandBars.UICommand
                    Dim oUICommandAgruparListagem As New Janus.Windows.UI.CommandBars.UICommand
                    oUICommandCopiar.Text = "Copiar Conteúdo da Célula" : oUICommandCopiar.Key = "copiar"
                    oUICommandAdicionarLinha.Text = "Adicionar Linha" : oUICommandAdicionarLinha.Key = "adicionar_linha"
                    oUICommandExcluirLinha.Text = "Excluir Linha" : oUICommandExcluirLinha.Key = "excluir_linha"
                    oUICommandRemoverOrdenacao.Text = "Remover Ordenação" : oUICommandRemoverOrdenacao.Key = "remover_ordenacao"
                    oUICommandConfigurarGrid.Text = "Configurar Listagem" : oUICommandConfigurarGrid.Key = "configurar_grid"
                    oUICommandExportarExcel.Text = "Exportar para Excel" : oUICommandExportarExcel.Key = "exportar_excel"
                    oUICommandAgruparListagem.Text = "Agrupar Listagem" : oUICommandAgruparListagem.Key = "agrupar_grid"

                    oUICommandManager.Commands.Add(oUICommandCopiar)
                    oUICommandManager.Commands.Add(oUICommandAdicionarLinha)
                    oUICommandManager.Commands.Add(oUICommandExcluirLinha)
                    oUICommandManager.Commands.Add(oUICommandRemoverOrdenacao)
                    oUICommandManager.Commands.Add(oUICommandConfigurarGrid)
                    oUICommandManager.Commands.Add(oUICommandExportarExcel)
                    oUICommandManager.Commands.Add(oUICommandAgruparListagem)
                    oUIContextMenu.Commands.Add(oUICommandCopiar)

                    oUIContextMenu.Commands.Add(oUICommandAdicionarLinha)
                    oUIContextMenu.Commands.Add(oUICommandExcluirLinha)
                    oUIContextMenu.Commands.Add(oUICommandRemoverOrdenacao)
                    oUIContextMenu.Commands.Add(oUICommandConfigurarGrid)
                    oUIContextMenu.Commands.Add(oUICommandExportarExcel)
                    oUIContextMenu.Commands.Add(oUICommandAgruparListagem)
                    oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                    AddCommandClick(oUICommandCopiar, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandAdicionarLinha, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandExcluirLinha, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandRemoverOrdenacao, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandConfigurarGrid, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandExportarExcel, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                    AddCommandClick(oUICommandAgruparListagem, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
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
            Dim oGridEx As GridEX = sender.tag

            'Verifica o Tipo de Controle
            Select Case oUICommand.Key

                Case "adicionar_linha"

                    If bPermissaoEditar = False Then Exit Sub

                    If oGridEx.Name = grdOrcamentoListaMaterial.Name Then
                        GerarListaMaterial()
                    End If

                    If oGridEx.Name = grdOrcamentoProcessoProdutivo.Name Then
                        GerarProcessoProdutivo()
                    End If

                    If oGridEx.Name = grdOrcamentoServicoTerceiros.Name Then
                        GerarServicoTerceiros()
                    End If

                Case "excluir_linha"

                    If bPermissaoEditar = False Then Exit Sub

                    If oGridEx.Name = grdOrcamentoGrupo.Name Then

                        oClsVenOrcamentoLegado.DeleteComposicaoGrupo(grdOrcamentoGrupo.CurrentRow)

                        oCurrentRow = Nothing

                        tabDados.TabPages.Clear()

                        oClsVenOrcamentoLegado.LoadGridComposicaoGrupo(grdOrcamentoGrupo, lCodigoOrcamento, iCodigoOrcamentoItem)

                    End If

                    If oGridEx.Name = grdOrcamentoListaMaterial.Name Then
                        oClsVenOrcamentoLegado.DeleteComposicaoListaMaterial(grdOrcamentoListaMaterial.CurrentRow)
                        oClsVenOrcamentoLegado.LoadGridComposicaoListaMaterial(grdOrcamentoListaMaterial, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    If oGridEx.Name = grdOrcamentoProcessoProdutivo.Name Then
                        oClsVenOrcamentoLegado.DeleteComposicaoProcessoProdutivo(grdOrcamentoProcessoProdutivo.CurrentRow)
                        oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(grdOrcamentoProcessoProdutivo, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    If oGridEx.Name = grdOrcamentoServicoTerceiros.Name Then
                        oClsVenOrcamentoLegado.DeleteComposicaoServicoTerceiros(grdOrcamentoServicoTerceiros.CurrentRow)
                        oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(grdOrcamentoServicoTerceiros, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    LoadChartComposicao()
                    LoadGridGrupo()

                Case "copiar"

                    Dim oGrid As GridEX = sender.Tag

                    If oGrid.GetDataRows.Count > 0 Then
                        If IsNothing(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key)) = False Then
                            Clipboard.SetDataObject(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key).Text)
                        End If
                    End If

                Case "adicionar_lista_material"

                    If bPermissaoEditar = False Then Exit Sub

                    'Limpa todas as paginas
                    tabDados.TabPages.Clear()

                    oClsVenOrcamentoLegado.GerarCodigoGrupo(lCodigoOrcamento, iCodigoOrcamentoItem, 2)
                    oClsVenOrcamentoLegado.LoadGridComposicaoGrupo(grdOrcamentoGrupo, lCodigoOrcamento, iCodigoOrcamentoItem)

                    If oClsVenOrcamentoLegado.CodigoOrcamentoItemGrupo > 0 Then

                        For i As Integer = 0 To grdOrcamentoGrupo.GetRows.Count - 1

                            grdOrcamentoGrupo.Row = i

                            If grdOrcamentoGrupo.GetValue("codigo") = oClsVenOrcamentoLegado.CodigoOrcamentoItemGrupo Then
                                grdOrcamentoGrupo.CurrentRow.CheckState = RowCheckState.Checked
                                oCurrentRow = grdOrcamentoGrupo.CurrentRow
                                Exit For
                            End If

                        Next

                        AlterarAbaComposicao()

                    End If

                Case "adicionar_processo_produtivo"

                    If bPermissaoEditar = False Then Exit Sub

                    'Limpa todas as paginas
                    tabDados.TabPages.Clear()

                    oClsVenOrcamentoLegado.GerarCodigoGrupo(lCodigoOrcamento, iCodigoOrcamentoItem, 3)
                    oClsVenOrcamentoLegado.LoadGridComposicaoGrupo(grdOrcamentoGrupo, lCodigoOrcamento, iCodigoOrcamentoItem)

                    If oClsVenOrcamentoLegado.CodigoOrcamentoItemGrupo > 0 Then

                        For i As Integer = 0 To grdOrcamentoGrupo.GetRows.Count - 1

                            grdOrcamentoGrupo.Row = i

                            If grdOrcamentoGrupo.GetValue("codigo") = oClsVenOrcamentoLegado.CodigoOrcamentoItemGrupo Then
                                grdOrcamentoGrupo.CurrentRow.CheckState = RowCheckState.Checked
                                oCurrentRow = grdOrcamentoGrupo.CurrentRow
                                Exit For
                            End If

                        Next

                        AlterarAbaComposicao()

                    End If

                Case "adicionar_servico_terceiros"

                    If bPermissaoEditar = False Then Exit Sub

                    'Limpa todas as paginas
                    tabDados.TabPages.Clear()

                    oClsVenOrcamentoLegado.GerarCodigoGrupo(lCodigoOrcamento, iCodigoOrcamentoItem, 4)
                    oClsVenOrcamentoLegado.LoadGridComposicaoGrupo(grdOrcamentoGrupo, lCodigoOrcamento, iCodigoOrcamentoItem)

                    If oClsVenOrcamentoLegado.CodigoOrcamentoItemGrupo > 0 Then

                        For i As Integer = 0 To grdOrcamentoGrupo.GetRows.Count - 1

                            grdOrcamentoGrupo.Row = i

                            If grdOrcamentoGrupo.GetValue("codigo") = oClsVenOrcamentoLegado.CodigoOrcamentoItemGrupo Then
                                grdOrcamentoGrupo.CurrentRow.CheckState = RowCheckState.Checked
                                oCurrentRow = grdOrcamentoGrupo.CurrentRow
                                Exit For
                            End If

                        Next

                        AlterarAbaComposicao()

                    End If

                Case "remover_ordenacao"
                    Dim oGrid As GridEX = sender.tag
                    oGrid.RootTable.SortKeys.Clear()

                Case "configurar_grid"

                    Dim oForm As New frmCfgGrid
                    Dim oGrid As GridEX = sender.Tag

                    'Seta Parametros
                    oForm.Grid = oGrid
                    oForm.NomeFormulario = iFormulario
                    oForm.ShowDialog()

                    'Configura Grid
                    ConfiguraGrid(oGrid, iFormulario)

                Case "exportar_excel"

                    If VerificaDireito(iFormulario, gcPrint) = False Then Exit Sub

                    Dim oGrid As GridEX = sender.tag

                    'Exporta Grid para Excel
                    ExportExcel(oGrid)

                Case "agrupar_grid"

                    Dim oGrid As GridEX = sender.tag

                    If oGrid.GroupByBoxVisible = True Then

                        'Oculta Grupo
                        oGrid.GroupByBoxVisible = False

                    Else

                        'Exibe Grupo
                        oGrid.GroupByBoxVisible = True
                        oGrid.HideColumnsWhenGrouped = InheritableBoolean.True

                    End If

                Case "adicionar_checklist_cliente"

                    'If bPermissaoEditar = False Then Exit Sub

                    Dim oForm As New frmVenOrcamentoItemAdicionarChecklistCliente
                    oForm.CodigoOrcamento = lCodigoOrcamento
                    oForm.CodigoOrcamentoItem = iCodigoOrcamentoItem
                    oForm.ShowDialog()

                    LoadGridChecklistCliente()


                Case "excluir_checklist_cliente"

                    'If bPermissaoEditar = False Then Exit Sub

                    If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

                    oClsVenOrcamentoLegado.DeleteChecklistClienteItem(lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoCheckListCliente.GetValue("codigo"))
                    grdOrcamentoCheckListCliente.CurrentRow.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub AddMenuGridGrupo(ByVal oControl As Control)

        Try

            If TypeOf (oControl) Is GridEX Then

                Dim oGrid As GridEX = oControl
                oGrid.DynamicFiltering = True
                oGrid.FilterMode = FilterMode.Automatic

                ConfigurarBuiltInTextsGrid(oGrid)

                Dim oUICommandManager As New Janus.Windows.UI.CommandBars.UICommandManager
                Dim oUIContextMenu As New Janus.Windows.UI.CommandBars.UIContextMenu
                Dim oUICommandCopiar As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandAdicionarListaMaterial As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandAdicionarProcessoProdutivo As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandAdicionarServicoTerceiros As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandExcluirLinha As New Janus.Windows.UI.CommandBars.UICommand
                oUICommandCopiar.Text = "Copiar Conteúdo da Célula" : oUICommandCopiar.Key = "copiar"
                oUICommandAdicionarListaMaterial.Text = "Adicionar Lista Material" : oUICommandAdicionarListaMaterial.Key = "adicionar_lista_material"
                oUICommandAdicionarProcessoProdutivo.Text = "Adicionar Processo Produtivo" : oUICommandAdicionarProcessoProdutivo.Key = "adicionar_processo_produtivo"
                oUICommandAdicionarServicoTerceiros.Text = "Adicionar Serviço de Terceiros" : oUICommandAdicionarServicoTerceiros.Key = "adicionar_servico_terceiros"
                oUICommandExcluirLinha.Text = "Excluir Linha" : oUICommandExcluirLinha.Key = "excluir_linha"

                oUICommandManager.Commands.Add(oUICommandCopiar)
                oUICommandManager.Commands.Add(oUICommandAdicionarListaMaterial)
                oUICommandManager.Commands.Add(oUICommandAdicionarProcessoProdutivo)
                oUICommandManager.Commands.Add(oUICommandAdicionarServicoTerceiros)
                oUICommandManager.Commands.Add(oUICommandExcluirLinha)
                oUIContextMenu.Commands.Add(oUICommandCopiar)

                oUIContextMenu.Commands.Add(oUICommandAdicionarListaMaterial)
                oUIContextMenu.Commands.Add(oUICommandAdicionarProcessoProdutivo)
                oUIContextMenu.Commands.Add(oUICommandAdicionarServicoTerceiros)
                oUIContextMenu.Commands.Add(oUICommandExcluirLinha)
                oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                AddCommandClick(oUICommandCopiar, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandAdicionarListaMaterial, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandAdicionarProcessoProdutivo, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandAdicionarServicoTerceiros, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandExcluirLinha, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddMouseClick(oControl, New DelegateMouseClick(AddressOf Grid_MouseClick))

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoRegistro(ByVal oControl As Control)

        Try

            If bPermissaoEditar = False Then Exit Sub

            Select Case oControl.Name

                Case grdOrcamentoListaMaterial.Name
                    oClsVenOrcamentoLegado.GerarCodigoListaMaterial(lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    oClsVenOrcamentoLegado.LoadGridComposicaoListaMaterial(grdOrcamentoListaMaterial, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))

                Case grdOrcamentoProcessoProdutivo.Name
                    oClsVenOrcamentoLegado.GerarCodigoProcessoProdutivo(lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(grdOrcamentoProcessoProdutivo, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CONTROLES :::"

#Region "GERAL"

    Private Sub frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            If bPermissaoEditar = False Then Exit Sub

            If MsgBox("Deseja salvar essa composição?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then

                If Validacao() = False Then
                    e.Cancel = True 'Cancela o fechamento da tela
                    Exit Sub 'Sai da sub pra não salvar
                End If

                Salvar()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Try

            oClsVenOrcamentoLegado.DeleteComposicaoTemporaria(lCodigoOrcamento,
                                                              iCodigoOrcamentoItem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If bPermissaoEditar = False Then Exit Sub
                    If sender.GetType.Name = "GridEX" Then NovoRegistro(sender)
                Case Keys.F5
                    If bPermissaoEditar = False Then Exit Sub
                    AtualizarValores()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Close()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoListaMaterial.CellUpdated,
                                                                                      grdOrcamentoProcessoProdutivo.CellUpdated,
                                                                                      grdOrcamentoServicoTerceiros.CellUpdated

        Try

            If bPermissaoEditar = False Then
                MsgBox("Não é possível executar essa ação pois o orçamento não pode ser editado devido ao seu status.", MsgBoxStyle.Exclamation, "Validação")

                Select Case sender.name
                    Case "grdOrcamentoListaMaterial"
                        oClsVenOrcamentoLegado.LoadGridComposicaoListaMaterial(sender,
                                                                           sender.CurrentRow.Cells("codigo_orcamento").Value,
                                                                           sender.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                           sender.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)
                    Case "grdOrcamentoProcessoProdutivo"
                        oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(sender,
                                                                               sender.CurrentRow.Cells("codigo_orcamento").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)
                    Case "grdOrcamentoServicoTerceiros"
                        oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(sender,
                                                                               sender.CurrentRow.Cells("codigo_orcamento").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)
                End Select

                Exit Sub

            End If

            Select Case sender.name

                Case "grdOrcamentoListaMaterial"

                    'Limpa as colunas caso o codigo do item tenha sido preenchido
                    AtualizaListaMaterialCodigoItem()

                    AtualizaListaMaterialSped()

                    'Atualiza o registro na grid
                    AtualizaListaMaterial()

                    'Atualiza o registro no banco
                    oClsVenOrcamentoLegado.UpdateComposicaoListaMaterial(sender.CurrentRow)

                    oClsVenOrcamentoLegado.LoadGridComposicaoListaMaterial(sender,
                                                                           sender.CurrentRow.Cells("codigo_orcamento").Value,
                                                                           sender.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                           sender.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)

                Case "grdOrcamentoProcessoProdutivo"

                    If sender.CurrentRow.Cells("contrato").Value = True Then

                        MsgBox("Não é permitido editar um processo produtivo de contrato.", MsgBoxStyle.Exclamation)

                        oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(sender,
                                                                               sender.CurrentRow.Cells("codigo_orcamento").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)

                        Exit Sub

                    End If

                    'Atualiza o registro na grid
                    AtualizaProcessoProdutivo()

                    'Atualiza o registro no banco
                    oClsVenOrcamentoLegado.UpdateComposicaoProcessoProdutivo(sender.CurrentRow)

                    oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(sender,
                                                                               sender.CurrentRow.Cells("codigo_orcamento").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                               sender.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)

                Case "grdOrcamentoServicoTerceiros"

                    'Atualiza o registro na grid
                    AtualizaServicoTerceiros()

                    'Atualiza o registro no banco
                    oClsVenOrcamentoLegado.UpdateComposicaoServicoTerceiros(sender.CurrentRow)

                    oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(sender,
                                                                              sender.CurrentRow.Cells("codigo_orcamento").Value,
                                                                              sender.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                              sender.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)

            End Select

            LoadChartComposicao()

            LoadGridGrupo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub tabMain_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabMain.SelectedTabChanged

        Try

            If tabMain.SelectedTab.Key = pagFormacaoPreco.Key Then

                Dim iContrato As Integer = LoadCodigo("sp_load_venda_orcamento_item_contrato " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)

                If iContrato > 0 Then
                    lblPrecoVenda.Text = "Preço Venda MP:"
                    lblValorComIPI.Text = "MP + Contrato + IPI:"
                Else
                    lblPrecoVenda.Text = "Preço Venda:"
                    lblValorComIPI.Text = "Valor Com IPI:"
                End If

                CalcularFormacaoPreco()

                txtCustoTotalPorcentagem.Focus()

                CalculaGraficoFormacaoPreco()

                grpDespesaVariavel.Visible = True

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: GRUPO :::"

    Private Sub btnImportarEstrutura_Click(sender As Object, e As EventArgs) Handles btnImportarEstrutura.Click

        Try

            If bPermissaoEditar = False Then Exit Sub

            Dim oForm As New frmVenOrcamentoComposicaoImportarEstrutura
            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.CodigoOrcamentoItem = iCodigoOrcamentoItem
            oForm.Formulario = iFormulario
            oForm.ShowDialog()

            LoadGridGrupo()
            LoadChartComposicao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOrcamentoGrupo_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoGrupo.CellUpdated

        Try

            If bPermissaoEditar = False Then Exit Sub

            'Atualiza os dados
            oClsVenOrcamentoLegado.UpdateComposicaoGrupo(lCodigoOrcamento,
                                                         iCodigoOrcamentoItem,
                                                         grdOrcamentoGrupo.CurrentRow)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOrcamentoGrupo_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdOrcamentoGrupo.RowCheckStateChanged

        Try

            'Verifica o Status da Linha
            If e.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = e.Row

                AlterarAbaComposicao()

            Else

                oCurrentRow = Nothing

                'Limpa todas as paginas
                tabDados.TabPages.Clear()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOrcamentoServicoTerceiros_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOrcamentoServicoTerceiros.RowDoubleClick

        Try

            If IsNothing(grdOrcamentoServicoTerceiros.CurrentColumn) Then Exit Sub

            If bPermissaoEditar = False Then Exit Sub

            Select Case grdOrcamentoServicoTerceiros.CurrentColumn.Key

                Case "editar" : EditarServicoTerceiros()
                Case "subir_sequencia" : SubirSequenciaServicoTerceiros()
                Case "descer_sequencia" : DescerSequenciaServicoTerceiros()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoGrupo.ColumnMoved,
                                                                                                           grdOrcamentoListaMaterial.ColumnMoved,
                                                                                                           grdOrcamentoProcessoProdutivo.ColumnMoved,
                                                                                                           grdOrcamentoServicoTerceiros.ColumnMoved

        Try

            UpdateConfiguraGrid(sender,
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(sender As Object, e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoGrupo.SizingColumn,
                                                                                                            grdOrcamentoListaMaterial.SizingColumn,
                                                                                                            grdOrcamentoProcessoProdutivo.SizingColumn,
                                                                                                            grdOrcamentoServicoTerceiros.SizingColumn

        Try

            UpdateConfiguraGrid(sender.Name,
                                iFormulario,
                                e.Column.Key,
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As Janus.Windows.GridEX.GroupsChangingEventArgs) Handles grdOrcamentoGrupo.GroupsChanging,
                                                                                                                grdOrcamentoListaMaterial.GroupsChanging,
                                                                                                                grdOrcamentoProcessoProdutivo.GroupsChanging,
                                                                                                                grdOrcamentoServicoTerceiros.GroupsChanging

        Try

            UpdateConfiguraGridGrupo(sender.Name,
                                     iFormulario,
                                     e.Group.Column.Key,
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnInserirServico_Click(sender As Object, e As EventArgs) Handles btnInserirServico.Click

        Try

            frmMain.errInfo.Clear()

            If bPermissaoEditar = False Then Exit Sub

            If ValidacaoServicoTerceiros() = False Then Exit Sub

            SalvarServicoTerceiros()
            LoadGridServicoTerceiros()
            LoadGridGrupo()
            LoadChartComposicao()
            NovoServicoTerceiros()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo.SelectedIndexChanged

        Try

            cboServicoTerceiros.SelectedIndex = -1
            cboServicoTerceiros.DataSource = Nothing

            If cboGrupo.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboServicoTerceiros, "sp_select_combo_cadastro_basico_operacao_grupo " & cboGrupo.SelectedValue & ", " & goUsuario.iEmpresa, True)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Servico_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorUnitario.LostFocus,
                                                                                               txtQuantidadeServico.LostFocus

        Try

            txtValorTotal.Value = txtValorUnitario.Value * txtQuantidadeServico.Value

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOrcamentoListaMaterial_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOrcamentoListaMaterial.RowDoubleClick

        Try

            If IsNothing(grdOrcamentoListaMaterial.CurrentColumn) Then Exit Sub

            Select Case grdOrcamentoListaMaterial.CurrentColumn.Key

                Case "medida1" : InformarMedida()
                Case "find_item" : FindItem()
                Case "ultimo_preco_compra" : HistoricoCompra()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboOperacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicoTerceiros.SelectedIndexChanged

        Try

            txtValorUnitario.Value = 0
            txtValorTotal.Value = 0
            cboFornecedor.SelectedIndex = -1 : cboFornecedor.DataSource = Nothing

            If cboServicoTerceiros.SelectedIndex = -1 Then Exit Sub

            txtValorUnitario.Value = LoadCodigo("sp_load_cadastro_basico_operacao_valor_hora " & goUsuario.iEmpresa & "," & cboServicoTerceiros.SelectedValue)

            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_parceiro_negocio_fornecedor_operacao " & cboServicoTerceiros.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOrcamentoProcessoProdutivo_MouseClick(sender As Object, e As MouseEventArgs) Handles grdOrcamentoProcessoProdutivo.MouseClick

        Try

            If grdOrcamentoProcessoProdutivo.GetRows.Count <= 0 Then Exit Sub
            If grdOrcamentoProcessoProdutivo.CurrentRow.RowType <> RowType.Record Then Exit Sub
            If IsNothing(grdOrcamentoProcessoProdutivo.CurrentColumn) Then Exit Sub

            If bPermissaoEditar = False Then Exit Sub

            Select Case grdOrcamentoProcessoProdutivo.CurrentColumn.Key

                Case "subir_sequencia" : SubirSequenciaProcessoProdutivo()
                Case "descer_sequencia" : DescerSequenciaProcessoProdutivo()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FORMAÇÃO DE PREÇO :::"

    Private Sub btnDespesaVariavel_Click(sender As Object, e As EventArgs) Handles btnDespesaVariavel.Click

        Try

            If grpDespesaVariavel.Visible = False Then

                oClsVenOrcamentoLegado.LoadDadosDespesaVariavel(lCodigoOrcamento,
                                                                iCodigoOrcamentoItem,
                                                                txtPorcentagemReducaoBCICMS,
                                                                txtAliquotaICMSPorcentagem,
                                                                txtAliquotaPISPorcentagem,
                                                                txtAliquotaCOFINSPorcentagem,
                                                                txtAliquotaIR,
                                                                txtAliquotaCSLL,
                                                                txtAliquotaISSPorcentagem,
                                                                txtComissaoPorcentagem)

                ConfiguraDespesaVariavel()
                CalculaICMSReduzido()

                grpDespesaVariavel.Visible = True

                If sTipo = "PRODUTO" Then
                    txtPorcentagemReducaoBCICMS.Focus()
                Else
                    txtAliquotaISSPorcentagem.Focus()
                End If

            Else

                grpDespesaVariavel.Visible = False

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LostFocus_DespesasVariaveis(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentagemReducaoBCICMS.LostFocus,
                                                                                                         txtAliquotaICMSPorcentagem.LostFocus,
                                                                                                         txtAliquotaICMSReduzida.LostFocus,
                                                                                                         txtAliquotaPISPorcentagem.LostFocus,
                                                                                                         txtAliquotaCOFINSPorcentagem.LostFocus,
                                                                                                         txtAliquotaISSPorcentagem.LostFocus,
                                                                                                         txtAliquotaIR.LostFocus,
                                                                                                         txtAliquotaCSLL.LostFocus,
                                                                                                         txtComissaoPorcentagem.LostFocus

        Try

            SalvarDespesasVariaveis()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LostFocus_Lucro(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLucroPorcentagem.LostFocus,
                                                                                             txtDespesaFixaPorcentagem.LostFocus,
                                                                                             txtDespesaVariavelPorcentagem.LostFocus,
                                                                                             txtAliquotaIPI.LostFocus,
                                                                                             txtCustoTotalPorcentagem.LostFocus

        Try

            CalculaValores()
            CalculaGraficoFormacaoPreco()

            If sender.name = txtDespesaFixaPorcentagem.Name Then

                oClsVenOrcamentoLegado.UpdateDespesaFixa(lCodigoOrcamento,
                                                         iCodigoOrcamentoItem,
                                                         txtDespesaFixaPorcentagem.Value)

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnDespesaFixa_Click(sender As Object, e As EventArgs) Handles btnDespesaFixa.Click

        Try

            LoadUsrControlForm(Me, "usrCfgOrcamento")

            If MsgBox("Deseja atualizar os valores de despesa fixa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then
                txtDespesaFixaPorcentagem.Value = LoadCodigo("sp_load_configuracao_orcamento_despesa_fixa " & goUsuario.iEmpresa)
                txtDespesaFixa.Value = txtPrecoVenda.Value * txtDespesaFixaPorcentagem.Value
                txtDespesaFixaPorcentagem.Focus()
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCalcularDesconto_Click(sender As Object, e As EventArgs) Handles btnCalcularDesconto.Click

        Try

            'Atualiza os valores de preço para utilizar depois no calculo de desconto
            oClsVenOrcamentoLegado.UpdateFormacaoPrecoTemporario(lCodigoOrcamento,
                                                                 iCodigoOrcamentoItem,
                                                                 txtCustoTotal.Value,
                                                                 txtDespesaVariavel.Value,
                                                                 txtDespesaFixa.Value,
                                                                 txtLucro.Value,
                                                                 txtPrecoVenda.Value,
                                                                 txtAliquotaIPI.Value,
                                                                 txtValorComIPI.Value,
                                                                 txtDespesaVariavelPorcentagem.Value,
                                                                 txtDespesaFixaPorcentagem.Value,
                                                                 txtLucroPorcentagem.Value,
                                                                 txtFrete.Value,
                                                                 txtValorContrato.Value)

            Dim oForm As New frmVenOrcamentoDesconto
            oForm.txtPrecoVendaSemIPI.Value = txtPrecoVenda.Value
            oForm.txtPrecoVendaSemIPINovo.Value = txtPrecoVenda.Value
            oForm.txtPorcentagemMargemLucroAtual.Value = txtLucroPorcentagem.Value * 100.0
            oForm.txtValorLucroAtual.Value = txtLucro.Value
            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.CodigoOrcamentoItem = iCodigoOrcamentoItem

            oForm.ShowDialog()

            oClsVenOrcamentoLegado.LoadDadosFormacaoPreco(lCodigoOrcamento,
                                                          iCodigoOrcamentoItem,
                                                          txtCustoTotal,
                                                          txtDespesaVariavel,
                                                          txtDespesaFixa,
                                                          txtLucro,
                                                          txtPrecoVenda,
                                                          txtAliquotaIPI,
                                                          txtValorComIPI,
                                                          txtDespesaVariavelPorcentagem,
                                                          txtDespesaFixaPorcentagem,
                                                          txtLucroPorcentagem,
                                                          txtDescontoPorcentagem,
                                                          txtValorContrato,
                                                          bTemporario:=True)

            CalculaValores()
            CalculaGraficoFormacaoPreco()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ICMS_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentagemReducaoBCICMS.LostFocus,
                                                                                            txtAliquotaICMSPorcentagem.LostFocus

        Try

            CalculaICMSReduzido()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnImportarRegra_Click(sender As Object, e As EventArgs) Handles btnImportarRegra.Click

        Try

            If bPermissaoEditar = False Then Exit Sub

            Dim oForm As New frmVenOrcamentoComposicaoImportarRegra
            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.CodigoOrcamentoItem = iCodigoOrcamentoItem
            oForm.Formulario = iFormulario

            oForm.ShowDialog()

            btnImportarRegra.Tag = oForm.CodigoRegraOrcamento

            oClsVenOrcamentoLegado.LoadDadosDespesaVariavel(lCodigoOrcamento,
                                                            iCodigoOrcamentoItem,
                                                            txtPorcentagemReducaoBCICMS,
                                                            txtAliquotaICMSPorcentagem,
                                                            txtAliquotaPISPorcentagem,
                                                            txtAliquotaCOFINSPorcentagem,
                                                            txtAliquotaIR,
                                                            txtAliquotaCSLL,
                                                            txtAliquotaISSPorcentagem,
                                                            txtComissaoPorcentagem)

            'txtAliquotaISSPorcentagem.Value = IIf(txtAliquotaISSPorcentagem.ReadOnly = True, 0, txtAliquotaISSPorcentagem.Value)

            SalvarDespesasVariaveis()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CHECKLIST CLIENTE :::"
    Private Sub grdOrcamentoCheckListCliente_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoCheckListCliente.CellUpdated
        Try

            UpdateChecklistCliente()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub HistoricoCompra()
        Try

            If IsDBNull(grdOrcamentoListaMaterial.GetValue("codigo_item")) Then
                MsgBox("Não é possível abrir o histórico porque nenhum item foi selecionado!", MsgBoxStyle.Exclamation, "Histórico de Compras")
                Exit Sub
            End If
            If IsDBNull(grdOrcamentoListaMaterial.GetValue("ultimo_preco_compra")) Then
                MsgBox("Não é possível abrir o histórico porque não existe histórico de compras deste produto!", MsgBoxStyle.Exclamation, "Histórico de Compras")
                Exit Sub
            End If

            Dim oForm As New frmCadProdutoHistoricoCompra
            oForm.CodigoItem = grdOrcamentoListaMaterial.GetValue("codigo_item")
            oForm.ShowDialog()


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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Adiciona os eventos de click
            AddMenuGridGrupo(grdOrcamentoGrupo)
            AddMenuGrid(grdOrcamentoListaMaterial)
            AddMenuGrid(grdOrcamentoProcessoProdutivo)
            AddMenuGrid(grdOrcamentoServicoTerceiros)
            AddMenuGrid(grdOrcamentoCheckListCliente)

            oClsVenOrcamentoLegado.InsertComposicaoTemporaria(lCodigoOrcamento,
                                                              iCodigoOrcamentoItem)

            oClsVenOrcamentoLegado.LoadGridComposicaoGrupo(grdOrcamentoGrupo,
                                                           lCodigoOrcamento,
                                                           iCodigoOrcamentoItem)

            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_grupo_item", "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_item", "sp_select_combo_cadastro_basico_item_orcamento_composicao_lista_material " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "tipo_item_sped", "sp_select_combo_static_tipo_item_sped_orcamento")
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_familia", "sp_select_combo_cadastro_basico_familia " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_tipo_perfil", "sp_select_combo_cadastro_basico_tipo_perfil " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_material", "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_unidade_medida", "sp_select_combo_cadastro_basico_unidade_medida_orcamento " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoProcessoProdutivo, "codigo_operacao", "sp_select_combo_cadastro_basico_operacao_orcamento_processo_produtivo " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoProcessoProdutivo, "codigo_maquina_travar", "sp_select_combo_cadastro_basico_maquina_orcamento " & goUsuario.iEmpresa)

            ConfiguraGrid(grdOrcamentoListaMaterial, iFormulario)
            ConfiguraGrid(grdOrcamentoProcessoProdutivo, iFormulario)
            ConfiguraGrid(grdOrcamentoServicoTerceiros, iFormulario)

            grdOrcamentoGrupo.FilterMode = FilterMode.None
            grdOrcamentoListaMaterial.FilterMode = FilterMode.None
            grdOrcamentoProcessoProdutivo.FilterMode = FilterMode.None
            grdOrcamentoServicoTerceiros.FilterMode = FilterMode.None

            Application.DoEvents()

            'Remove todas as páginas
            tabDados.TabPages.Clear()

            LoadChartComposicao()

            If bTemPai = False Then

                If grdOrcamentoGrupo.GetRows.Count <= 0 Then

                    oClsVenOrcamentoLegado.UpdateDespesasVariaveisCliente(lCodigoOrcamento, iCodigoOrcamentoItem)

                    oClsVenOrcamentoLegado.LoadDadosFormacaoPreco(lCodigoOrcamento,
                                                              iCodigoOrcamentoItem,
                                                              txtCustoTotal,
                                                              txtDespesaVariavel,
                                                              txtDespesaFixa,
                                                              txtLucro,
                                                              txtPrecoVenda,
                                                              txtAliquotaIPI,
                                                              txtValorComIPI,
                                                              txtDespesaVariavelPorcentagem,
                                                              txtDespesaFixaPorcentagem,
                                                              txtLucroPorcentagem,
                                                              txtDescontoPorcentagem,
                                                              txtValorContrato,
                                                              bTemporario:=True)

                Else

                    oClsVenOrcamentoLegado.LoadDadosFormacaoPreco(lCodigoOrcamento,
                                                              iCodigoOrcamentoItem,
                                                              txtCustoTotal,
                                                              txtDespesaVariavel,
                                                              txtDespesaFixa,
                                                              txtLucro,
                                                              txtPrecoVenda,
                                                              txtAliquotaIPI,
                                                              txtValorComIPI,
                                                              txtDespesaVariavelPorcentagem,
                                                              txtDespesaFixaPorcentagem,
                                                              txtLucroPorcentagem,
                                                              txtDescontoPorcentagem,
                                                              txtValorContrato)

                End If

                txtLucroPorcentagem.Value = IIf(txtLucroPorcentagem.Value = 0, 0.25, txtLucroPorcentagem.Value)
                txtPrecoVendaPorcentagem.Value = 1

                txtFrete.Value = LoadCodigo("sp_load_venda_orcamento_item_frete " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)
                txtCustoTotal.Value = LoadCodigo("sp_load_venda_orcamento_item_custo_total " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)

                CalculaValores()

            Else

                txtFrete.Value = 0
                txtFrete.Enabled = False
                tabMain.TabPages.Remove(pagFormacaoPreco)

            End If

            LoadGridChecklistCliente()

            If sGrupo <> "" Then

                For i As Integer = 0 To grdOrcamentoGrupo.GetRows.Count - 1

                    grdOrcamentoGrupo.Row = i

                    If grdOrcamentoGrupo.GetValue("grupo") = sGrupo Then
                        grdOrcamentoGrupo.CurrentRow.CheckState = RowCheckState.Checked
                        oCurrentRow = grdOrcamentoGrupo.CurrentRow
                        Exit For
                    End If

                Next

                AlterarAbaComposicao()

            End If

            If iCodigoContrato = -1 Then btnImportarContrato.Visible = False

            'Bloqueia Campos
            HabilitaCampos()

            If VerificaDireito(iFormulario, gcAdministrator) = False Then
                tabMain.TabPages.Remove(pagFormacaoPreco)
            End If

            ConfiguraGridOrcamentoAdm(grdOrcamentoGrupo, VerificaDireito(iFormulario, gcAdministrator))
            ConfiguraGridOrcamentoAdm(grdOrcamentoListaMaterial, VerificaDireito(iFormulario, gcAdministrator))
            ConfiguraGridOrcamentoAdm(grdOrcamentoProcessoProdutivo, VerificaDireito(iFormulario, gcAdministrator))
            ConfiguraGridOrcamentoAdm(grdOrcamentoServicoTerceiros, VerificaDireito(iFormulario, gcAdministrator))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGridGrupo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim iCodigo As Integer

            For Each oRow As GridEXRow In grdOrcamentoGrupo.GetCheckedRows
                iCodigo = oRow.Cells("codigo").Value
            Next

            oClsVenOrcamentoLegado.LoadGridComposicaoGrupo(grdOrcamentoGrupo,
                                                           lCodigoOrcamento,
                                                           iCodigoOrcamentoItem)

            For i As Integer = 0 To grdOrcamentoGrupo.GetRows.Count - 1

                grdOrcamentoGrupo.Row = i

                If grdOrcamentoGrupo.GetValue("codigo") = iCodigo Then
                    grdOrcamentoGrupo.CurrentRow.CheckState = RowCheckState.Checked
                    oCurrentRow = grdOrcamentoGrupo.CurrentRow
                    Exit For
                End If

            Next

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadChartComposicao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.LoadGraficoComposicao(chrComposicao,
                                                         lCodigoOrcamento,
                                                         iCodigoOrcamentoItem,
                                                         True)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AlterarAbaComposicao()

        Try

            'If grdOrcamentoGrupo.Col = -1 Then Exit Sub
            If grdOrcamentoGrupo.CurrentRow.RowType <> RowType.Record Then Exit Sub

            Dim sTipo As String = IIf(IsDBNull(grdOrcamentoGrupo.GetValue("tipo")), "", grdOrcamentoGrupo.GetValue("tipo"))

            If sTipo = "" Then Exit Sub

            'Limpa todas as paginas
            tabDados.TabPages.Clear()

            Select Case sTipo

                Case "2"
                    oClsVenOrcamentoLegado.LoadGridComposicaoListaMaterial(grdOrcamentoListaMaterial, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    tabDados.TabPages.Add(pagListaMaterialGrupo)

                Case "3"
                    oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(grdOrcamentoProcessoProdutivo, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    tabDados.TabPages.Add(pagProcessoProdutivo)

                Case "4"
                    NovoServicoTerceiros()
                    iCodigoOrcamentoItemGrupo = grdOrcamentoGrupo.GetValue("codigo")
                    oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(grdOrcamentoServicoTerceiros, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
                    tabDados.TabPages.Add(pagServicoTerceiro)

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            If bPermissaoEditar = False Then Exit Sub

            If tabMain.SelectedTab.Key = pagTabela.Key And bTemPai = False Then
                CalcularFormacaoPreco()
            End If

            oClsVenOrcamentoLegado.InsertComposicao(lCodigoOrcamento,
                                                    iCodigoOrcamentoItem)

            Dim iCodigoRegraOrcamento As Integer = IIf(IsNumeric(btnImportarRegra.Tag), btnImportarRegra.Tag, -1)

            oClsVenOrcamentoLegado.UpdateFormacaoPreco(lCodigoOrcamento,
                                                       iCodigoOrcamentoItem,
                                                       txtCustoTotal.Value,
                                                       txtDespesaVariavel.Value,
                                                       txtDespesaFixa.Value,
                                                       txtLucro.Value,
                                                       txtPrecoVenda.Value,
                                                       txtAliquotaIPI.Value,
                                                       txtValorComIPI.Value,
                                                       txtDespesaVariavelPorcentagem.Value,
                                                       txtDespesaFixaPorcentagem.Value,
                                                       txtLucroPorcentagem.Value,
                                                       txtFrete.Value,
                                                       iCodigoRegraOrcamento)

            If bTemPai = True Then

                oClsVenOrcamentoLegado.UpdateValoresPai(lCodigoOrcamento,
                                                        iCodigoOrcamentoItem)

            End If

            frmMain.Informacao(Mensagem.RegistroSalvo)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FindFornecedor()

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oGridEX = grdOrcamentoServicoTerceiros

            'Abre Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FindOperacao()

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindOperacao"
            oForm.Tamanho = True
            oForm.Text = "Procurar Operação"

            'Seta Parametros
            oGridEX = grdOrcamentoServicoTerceiros

            'Abre Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaPesoTeorico()

        Try

            Dim oScriptControl As New MSScriptControl.ScriptControl
            Dim oScriptControlPesoConsiderado As New MSScriptControl.ScriptControl
            Dim sCalculo As String
            Dim sCalculoPesoConsiderado As String
            Dim dQuantidade As Double = IIf(IsNumeric(grdOrcamentoListaMaterial.GetValue("quantidade")), grdOrcamentoListaMaterial.GetValue("quantidade"), 0)
            Dim dMedida1 As Double = IIf(IsNumeric(grdOrcamentoListaMaterial.GetValue("medida1")), grdOrcamentoListaMaterial.GetValue("medida1"), 0)
            Dim dMedida2 As Double = IIf(IsNumeric(grdOrcamentoListaMaterial.GetValue("medida2")), grdOrcamentoListaMaterial.GetValue("medida2"), 0)
            Dim dMedida3 As Double = IIf(IsNumeric(grdOrcamentoListaMaterial.GetValue("medida3")), grdOrcamentoListaMaterial.GetValue("medida3"), 0)
            Dim dMedida4 As Double = IIf(IsNumeric(grdOrcamentoListaMaterial.GetValue("medida4")), grdOrcamentoListaMaterial.GetValue("medida4"), 0)
            Dim dPesoEspecifico As Double = IIf(IsNumeric(grdOrcamentoListaMaterial.GetValue("peso_especifico")), grdOrcamentoListaMaterial.GetValue("peso_especifico"), 0)

            oScriptControl.Language = "VBScript"
            oScriptControlPesoConsiderado.Language = "VBScript"

            'Altera Valores Da Fórmula
            sCalculo = Replace(grdOrcamentoListaMaterial.GetValue("formula"), "|MEDIDA_1|", dMedida1)
            sCalculo = Replace(sCalculo, "|MEDIDA_2|", dMedida2)
            sCalculo = Replace(sCalculo, "|MEDIDA_3|", dMedida3)
            sCalculo = Replace(sCalculo, "|MEDIDA_4|", dMedida4)
            sCalculo = Replace(sCalculo, "|PESO_ESP|", dPesoEspecifico)
            sCalculo = Replace(sCalculo, ",", ".")

            'Efetua Cálculo
            grdOrcamentoListaMaterial.SetValue("peso", oScriptControl.Eval(sCalculo))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarServicoTerceiros()

        Try

            If grdOrcamentoServicoTerceiros.GetValue("contrato") = True Then
                MsgBox("Não é permitido editar um serviço de contrato.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            NovoServicoTerceiros()

            If IsDBNull(grdOrcamentoServicoTerceiros.GetValue("codigo_grupo_item")) Then
                cboGrupo.SelectedIndex = -1
            Else
                cboGrupo.SelectedValue = grdOrcamentoServicoTerceiros.GetValue("codigo_grupo_item")
            End If

            If IsDBNull(grdOrcamentoServicoTerceiros.GetValue("codigo_operacao")) Then
                cboServicoTerceiros.SelectedIndex = -1
            Else
                cboServicoTerceiros.SelectedValue = grdOrcamentoServicoTerceiros.GetValue("codigo_operacao")
            End If

            txtQuantidadeServico.Value = grdOrcamentoServicoTerceiros.GetValue("quantidade")
            txtValorUnitario.Value = grdOrcamentoServicoTerceiros.GetValue("valor_unitario")
            txtValorTotal.Value = grdOrcamentoServicoTerceiros.GetValue("valor_total")

            If IsDBNull(grdOrcamentoServicoTerceiros.GetValue("codigo_fornecedor")) Then
                cboFornecedor.SelectedIndex = -1
            Else
                cboFornecedor.SelectedValue = grdOrcamentoServicoTerceiros.GetValue("codigo_fornecedor")
            End If

            sObservacao = IIf(IsDBNull(grdOrcamentoServicoTerceiros.GetValue("observacao")), "", grdOrcamentoServicoTerceiros.GetValue("observacao"))

            iCodigoOrcamentoItemGrupo = grdOrcamentoServicoTerceiros.GetValue("codigo_orcamento_item_grupo")
            btnInserirServico.Tag = grdOrcamentoServicoTerceiros.GetValue("codigo")

            cboGrupo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoServicoTerceiros()

        Try

            LimparCamposGroupBox(grpServicoTerceiros)

            LoadCombo(cboGrupo, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa, False)

            btnInserirServico.Tag = ""

            cboGrupo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaListaMaterial()

        Try

            'Pra puxar o peso específico do material
            Dim iCodigoMaterial As Integer = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("codigo_material")), -1, grdOrcamentoListaMaterial.GetValue("codigo_material"))
            Dim dPesoEspecifico As Double = LoadCodigo("sp_load_cadastro_basico_material_densidade " & iCodigoMaterial & "," & goUsuario.iEmpresa)
            grdOrcamentoListaMaterial.SetValue("peso_especifico", dPesoEspecifico)

            'Pra puxar a quantidade de medidias
            Dim iCodigoTipoPerfil As Integer = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil")), -1, grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil"))
            Dim iQuantidadeMedidas As Integer = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_quantidade_medidas " & iCodigoTipoPerfil & "," & goUsuario.iEmpresa)
            grdOrcamentoListaMaterial.SetValue("quantidade_medidas", iQuantidadeMedidas)

            'Pra puxar a formula
            Dim sFormula As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_formula " & iCodigoTipoPerfil & "," & goUsuario.iEmpresa)
            grdOrcamentoListaMaterial.SetValue("formula", sFormula)

            'Calcula o peso através da formula e tipo material
            CalculaPesoTeorico()

            If IsNumeric(grdOrcamentoListaMaterial.GetValue("medida1")) Then
                grdOrcamentoListaMaterial.SetValue("codigo_unidade_medida", 2) 'KG
            End If

            'Pra calcular o custo total. Se for KG, é quantidade * peso, se for peça, é quantidade * custo unitario
            Dim iCodigoUnidadeMedida As Integer = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("codigo_unidade_medida")), -1, grdOrcamentoListaMaterial.GetValue("codigo_unidade_medida"))
            Dim dQuantidade As Double = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("quantidade")), 0, grdOrcamentoListaMaterial.GetValue("quantidade"))
            Dim dCustoUnitario As Double = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("custo_unitario")), 0, grdOrcamentoListaMaterial.GetValue("custo_unitario"))
            Dim dPeso As Double = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("peso")), 0, grdOrcamentoListaMaterial.GetValue("peso"))
            Dim dCustoTotal As Double

            'Se for KG
            If iCodigoUnidadeMedida = 2 Then
                dCustoTotal = dPeso * dCustoUnitario * dQuantidade
            ElseIf iCodigoUnidadeMedida = 5 Then 'Se for Peça
                dCustoTotal = dQuantidade * dCustoUnitario
            End If

            grdOrcamentoListaMaterial.SetValue("custo_total", dCustoTotal)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaListaMaterialCodigoItem()

        Try

            If IsNumeric(grdOrcamentoListaMaterial.GetValue("codigo_item")) = False Then Exit Sub

            Dim sDescricao As String = LoadCodigo("sp_load_cadastro_basico_item_descricao " & grdOrcamentoListaMaterial.GetValue("codigo_item") & ", " & goUsuario.iEmpresa)
            Dim dUltimoPrecoCompra As Double = LoadCodigo("sp_load_cadastro_basico_item_ultimo_preco_compra " & grdOrcamentoListaMaterial.GetValue("codigo_item") & ", " & goUsuario.iEmpresa)
            Dim iTipoItemSped As Integer = LoadCodigo("sp_load_cadastro_basico_item_tipo_sped " & grdOrcamentoListaMaterial.GetValue("codigo_item") & ", " & goUsuario.iEmpresa)
            Dim iCodigoUnidadeMedida As Integer = LoadCodigo("sp_load_cadastro_basico_item_unidade_medida_estoque " & grdOrcamentoListaMaterial.GetValue("codigo_item") & ", " & goUsuario.iEmpresa)

            grdOrcamentoListaMaterial.SetValue("nome_produto", sDescricao)
            grdOrcamentoListaMaterial.SetValue("ultimo_preco_compra", dUltimoPrecoCompra)

            If iTipoItemSped > 0 Then
                grdOrcamentoListaMaterial.SetValue("tipo_item_sped", iTipoItemSped)
            End If

            If iCodigoUnidadeMedida > 0 Then
                grdOrcamentoListaMaterial.SetValue("codigo_unidade_medida", iCodigoUnidadeMedida)
            End If

            grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_familia").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_tipo_perfil").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("quantidade_medidas").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("formula").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_material").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("descricao").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida1").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida2").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida3").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida4").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("peso_especifico").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("peso").Value = DBNull.Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaListaMaterialSped()

        Try

            Dim iTipoItemSped As Integer = IIf(IsNumeric(grdOrcamentoListaMaterial.GetValue("tipo_item_sped")), grdOrcamentoListaMaterial.GetValue("tipo_item_sped"), 1)

            If iTipoItemSped = 1 Then Exit Sub 'Materia prima

            'Se não for matéria prima, não deixa editar os campos familia, perfil, material, medidas
            grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_familia").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_tipo_perfil").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("quantidade_medidas").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("formula").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_material").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida1").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida2").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida3").Value = DBNull.Value
            grdOrcamentoListaMaterial.CurrentRow.Cells("medida4").Value = DBNull.Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaProcessoProdutivo()

        Try

            Dim dValorHora As Double = 0
            Dim dHorasDecimais As Double = 0
            Dim iHorasInteiras As Integer = 0
            Dim iMinutos As Integer = 0
            Dim iSegundos As Integer = 0
            Dim sTempoFormatado As String = ""

            'Case pra transformar hora decimal digitada em horas HH:MM:SS, e vice-versa e pra puxar o valor de taxa hora da operação
            Select Case grdOrcamentoProcessoProdutivo.CurrentColumn.Key


                Case "codigo_operacao"
                    dValorHora = LoadCodigo("sp_load_cadastro_basico_operacao_valor_hora " & goUsuario.iEmpresa & "," & IIf(IsNumeric(grdOrcamentoProcessoProdutivo.GetValue("codigo_operacao")), grdOrcamentoProcessoProdutivo.GetValue("codigo_operacao"), -1))
                    grdOrcamentoProcessoProdutivo.SetValue("custo_hora", dValorHora)

                Case "tempo_setup_decimal"

                    If IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("tempo_setup_decimal")) = False Then

                        dHorasDecimais = grdOrcamentoProcessoProdutivo.GetValue("tempo_setup_decimal")
                        iHorasInteiras = Math.Floor(dHorasDecimais)
                        iMinutos = Math.Floor((dHorasDecimais - iHorasInteiras) * 60)
                        iSegundos = Math.Floor(((dHorasDecimais - iHorasInteiras) * 60 - iMinutos) * 60)

                        sTempoFormatado = IIf(Len(CStr(iHorasInteiras)) = 1, "0" + CStr(iHorasInteiras), CStr(iHorasInteiras)) + ":"
                        sTempoFormatado += IIf(Len(CStr(iMinutos)) = 1, "0" + CStr(iMinutos), CStr(iMinutos)) + ":"
                        sTempoFormatado += IIf(Len(CStr(iSegundos)) = 1, "0" + CStr(iSegundos), CStr(iSegundos))

                        grdOrcamentoProcessoProdutivo.SetValue("tempo_setup", sTempoFormatado)
                    Else
                        grdOrcamentoProcessoProdutivo.SetValue("tempo_setup", "00:00:00")
                    End If

                Case "tempo_setup"

                    If IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("tempo_setup")) = False Then
                        Dim sHora1() As String = grdOrcamentoProcessoProdutivo.GetValue("tempo_setup").ToString.Split(":")
                        Dim dHoraDecimal As Double = sHora1(0) + (sHora1(1) / 60) + (sHora1(2) / 3600)
                        grdOrcamentoProcessoProdutivo.SetValue("tempo_setup_decimal", dHoraDecimal)
                    Else
                        grdOrcamentoProcessoProdutivo.SetValue("tempo_setup_decimal", 0)
                    End If

                Case "tempo_maquina_decimal"

                    If IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("tempo_maquina_decimal")) = False Then

                        dHorasDecimais = grdOrcamentoProcessoProdutivo.GetValue("tempo_maquina_decimal")
                        iHorasInteiras = Math.Floor(dHorasDecimais)
                        iMinutos = Math.Floor((dHorasDecimais - iHorasInteiras) * 60)
                        iSegundos = Math.Floor(((dHorasDecimais - iHorasInteiras) * 60 - iMinutos) * 60)

                        sTempoFormatado = IIf(Len(CStr(iHorasInteiras)) = 1, "0" + CStr(iHorasInteiras), CStr(iHorasInteiras)) + ":"
                        sTempoFormatado += IIf(Len(CStr(iMinutos)) = 1, "0" + CStr(iMinutos), CStr(iMinutos)) + ":"
                        sTempoFormatado += IIf(Len(CStr(iSegundos)) = 1, "0" + CStr(iSegundos), CStr(iSegundos))

                        grdOrcamentoProcessoProdutivo.SetValue("tempo_maquina", sTempoFormatado)
                    Else
                        grdOrcamentoProcessoProdutivo.SetValue("tempo_maquina", "00:00:00")
                    End If

                Case "tempo_maquina"

                    If IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("tempo_maquina")) = False Then
                        Dim sHora1() As String = grdOrcamentoProcessoProdutivo.GetValue("tempo_maquina").ToString.Split(":")
                        Dim dHoraDecimal As Double = sHora1(0) + (sHora1(1) / 60) + (sHora1(2) / 3600)
                        grdOrcamentoProcessoProdutivo.SetValue("tempo_maquina_decimal", dHoraDecimal)
                    Else
                        grdOrcamentoProcessoProdutivo.SetValue("tempo_maquina_decimal", 0)
                    End If

            End Select

            Dim dHoras As Double = IIf(IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("tempo_setup_decimal")), 0, grdOrcamentoProcessoProdutivo.GetValue("tempo_setup_decimal")) +
                                   IIf(IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("tempo_maquina_decimal")), 0, grdOrcamentoProcessoProdutivo.GetValue("tempo_maquina_decimal"))

            dHorasDecimais = dHoras
            iHorasInteiras = Math.Floor(dHorasDecimais)
            iMinutos = Math.Floor((dHorasDecimais - iHorasInteiras) * 60)
            iSegundos = Math.Floor(((dHorasDecimais - iHorasInteiras) * 60 - iMinutos) * 60)

            sTempoFormatado = IIf(Len(CStr(iHorasInteiras)) = 1, "0" + CStr(iHorasInteiras), CStr(iHorasInteiras)) + ":"
            sTempoFormatado += IIf(Len(CStr(iMinutos)) = 1, "0" + CStr(iMinutos), CStr(iMinutos)) + ":"
            sTempoFormatado += IIf(Len(CStr(iSegundos)) = 1, "0" + CStr(iSegundos), CStr(iSegundos))

            grdOrcamentoProcessoProdutivo.SetValue("tempo_total", sTempoFormatado)

            Dim dCustoUnitario As Double = IIf(IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("custo_hora")), 0, grdOrcamentoProcessoProdutivo.GetValue("custo_hora"))
            grdOrcamentoProcessoProdutivo.SetValue("custo_total", dHoras * dCustoUnitario)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaServicoTerceiros()

        Try

            Dim dQuantidade As Double = IIf(IsDBNull(grdOrcamentoServicoTerceiros.GetValue("quantidade")), 0, grdOrcamentoServicoTerceiros.GetValue("quantidade"))
            Dim dValorUnitario As Double = IIf(IsDBNull(grdOrcamentoServicoTerceiros.GetValue("valor_unitario")), 0, grdOrcamentoServicoTerceiros.GetValue("valor_unitario"))

            grdOrcamentoServicoTerceiros.SetValue("valor_total", dQuantidade * dValorUnitario)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InformarMedida()

        Try

            If bPermissaoEditar = False Then Exit Sub

            If IsDBNull(grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil")) Then Exit Sub
            If IsNothing(grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil")) Then Exit Sub

            Dim iQuantidadeMedidas As Integer = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_quantidade_medidas " & grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil") & "," & goUsuario.iEmpresa)
            Dim sMedida1 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil") & ", 1, " & goUsuario.iEmpresa)
            Dim sMedida2 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil") & ", 2, " & goUsuario.iEmpresa)
            Dim sMedida3 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil") & ", 3, " & goUsuario.iEmpresa)
            Dim sMedida4 As String = LoadCodigo("sp_load_cadastro_basico_tipo_perfil_descricao_medida " & grdOrcamentoListaMaterial.GetValue("codigo_tipo_perfil") & ", 4, " & goUsuario.iEmpresa)
            Dim sMensagem As String

            sMensagem = IIf(sMedida1 = "", "", "Medida 1: " + sMedida1 + Environment.NewLine)
            sMensagem += IIf(sMedida2 = "", "", "Medida 2: " + sMedida2 + Environment.NewLine)
            sMensagem += IIf(sMedida3 = "", "", "Medida 3: " + sMedida3 + Environment.NewLine)
            sMensagem += IIf(sMedida4 = "", "", "Medida 4: " + sMedida4 + Environment.NewLine)

            MsgBox(sMensagem, MsgBoxStyle.OkOnly)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FindItem()

        Try

            If bPermissaoEditar = False Then Exit Sub

            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = "Procurar Grupo de Item - MP"
            oForm.Tamanho = True
            oForm.Tag = "MP"
            oForm.Text = "Procurar Grupo de Item - MP"

            oGridExOrcamento = grdOrcamentoListaMaterial

            'Abre Formulário
            oForm.ShowDialog(Me)

            If Not IsDBNull(grdOrcamentoListaMaterial.GetValue("codigo_grupo_item")) Then

                Dim iCodigoFamilia As Integer
                Dim iCodigoTipoItemSPED As Integer
                Dim iCodigoTipoPerfil As Integer
                Dim iCodigoMaterial As Integer

                'Carrega os dados baseado na estrutura de grupo de item
                LoadDadosGrupoItem(iCodigoGrupoItem:=grdOrcamentoListaMaterial.GetValue("codigo_grupo_item"),
                                   iCodigoMaterial:=iCodigoMaterial,
                                   iCodigoTipoPerfil:=iCodigoTipoPerfil,
                                   iCodigoFamilia:=iCodigoFamilia,
                                   iCodigoTipoItemSPED:=iCodigoTipoItemSPED)


                With grdOrcamentoListaMaterial
                    .SetValue("codigo_material", IIf(iCodigoMaterial = -1, DBNull.Value, iCodigoMaterial))
                    .SetValue("codigo_tipo_perfil", IIf(iCodigoTipoPerfil = -1, DBNull.Value, iCodigoTipoPerfil))
                    .SetValue("tipo_item_sped", IIf(iCodigoTipoItemSPED = -1, DBNull.Value, iCodigoTipoItemSPED))
                    .SetValue("codigo_familia", IIf(iCodigoFamilia = -1, DBNull.Value, iCodigoFamilia))
                End With

            End If


            'Limpa as colunas caso o codigo do item tenha sido preenchido
            AtualizaListaMaterialCodigoItem()

            oClsVenOrcamentoLegado.UpdateComposicaoListaMaterial(grdOrcamentoListaMaterial.CurrentRow)

            oClsVenOrcamentoLegado.LoadGridComposicaoListaMaterial(grdOrcamentoListaMaterial,
                                                                   grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_orcamento").Value,
                                                                   grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_orcamento_item").Value,
                                                                   grdOrcamentoListaMaterial.CurrentRow.Cells("codigo_orcamento_item_grupo").Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean


        Try

            Dim iCodigo As Integer
            Dim sCampo As String

            oClsVenOrcamentoLegado.ValidacaoComposicao(lCodigoOrcamento,
                                                       iCodigoOrcamentoItem,
                                                       iCodigo,
                                                       sCampo)

            If iCodigo > 0 And sCampo <> "" Then

                For i As Integer = 0 To grdOrcamentoGrupo.GetRows.Count - 1

                    grdOrcamentoGrupo.Row = i

                    If grdOrcamentoGrupo.GetValue("codigo") = iCodigo Then

                        oCurrentRow = Nothing
                        grdOrcamentoGrupo.UnCheckAllRecords()
                        grdOrcamentoGrupo.CurrentRow.CheckState = RowCheckState.Checked
                        oCurrentRow = grdOrcamentoGrupo.CurrentRow

                        Exit For

                    End If

                Next

                AlterarAbaComposicao()

                If tabMain.SelectedTab.Key <> pagTabela.Key Then
                    tabMain.SelectedTab = pagTabela
                End If

                MsgBox("Existem campos obrigatórios a serem preenchidos. Campo: " & sCampo, MsgBoxStyle.Exclamation, "Validação")

                Return False

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub GerarListaMaterial()

        Try

            oClsVenOrcamentoLegado.GerarCodigoListaMaterial(lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
            oClsVenOrcamentoLegado.LoadGridComposicaoListaMaterial(grdOrcamentoListaMaterial, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarProcessoProdutivo()

        Try

            oClsVenOrcamentoLegado.GerarCodigoProcessoProdutivo(lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
            oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(grdOrcamentoProcessoProdutivo, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarServicoTerceiros()

        Try

            oClsVenOrcamentoLegado.GerarCodigoServicoTerceiros(lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))
            oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(grdOrcamentoServicoTerceiros, lCodigoOrcamento, iCodigoOrcamentoItem, grdOrcamentoGrupo.GetValue("codigo"))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarServicoTerceiros()

        Try

            If IsNumeric(btnInserirServico.Tag) Then

                oClsVenOrcamentoLegado.UpdateComposicaoServicoTerceiros2(lCodigoOrcamento,
                                                                         iCodigoOrcamentoItem,
                                                                         iCodigoOrcamentoItemGrupo,
                                                                         btnInserirServico.Tag,
                                                                         IIf(cboServicoTerceiros.SelectedIndex = -1, -1, cboServicoTerceiros.SelectedValue),
                                                                         txtQuantidadeServico.Value,
                                                                         txtValorUnitario.Value,
                                                                         IIf(cboFornecedor.SelectedIndex = -1, -1, cboFornecedor.SelectedValue),
                                                                         sObservacao)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsVenOrcamentoLegado.InsertComposicaoServicoTerceiros(lCodigoOrcamento,
                                                                        iCodigoOrcamentoItem,
                                                                        iCodigoOrcamentoItemGrupo,
                                                                        IIf(cboServicoTerceiros.SelectedIndex = -1, -1, cboServicoTerceiros.SelectedValue),
                                                                        txtQuantidadeServico.Value,
                                                                        txtValorUnitario.Value,
                                                                        IIf(cboFornecedor.SelectedIndex = -1, -1, cboFornecedor.SelectedValue))

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridServicoTerceiros()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(grdOrcamentoServicoTerceiros,
                                                                      lCodigoOrcamento,
                                                                      iCodigoOrcamentoItem,
                                                                      iCodigoOrcamentoItemGrupo)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SubirSequenciaProcessoProdutivo()

        Try

            If grdOrcamentoProcessoProdutivo.GetValue("sequencia") = 10 Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.UpdateProcessoProdutivoSubirSequencia(lCodigoOrcamento,
                                                                         iCodigoOrcamentoItem,
                                                                         grdOrcamentoGrupo.GetValue("codigo"),
                                                                         grdOrcamentoProcessoProdutivo.GetValue("codigo"),
                                                                         grdOrcamentoProcessoProdutivo.GetValue("sequencia"))

            oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(grdOrcamentoProcessoProdutivo,
                                                                       lCodigoOrcamento,
                                                                       iCodigoOrcamentoItem,
                                                                       grdOrcamentoGrupo.GetValue("codigo"))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DescerSequenciaProcessoProdutivo()

        Try



            Dim iProximaSequencia As Integer = LoadCodigo("sp_load_venda_orcamento_item_grupo_processo_produtivo_proxima_sequencia " & goUsuario.iEmpresa &
                                                          ", " & lCodigoOrcamento &
                                                          ", " & iCodigoOrcamentoItem &
                                                          ", " & grdOrcamentoGrupo.GetValue("codigo") &
                                                          ", " & grdOrcamentoProcessoProdutivo.GetValue("sequencia"))

            If iProximaSequencia = 0 Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.UpdateProcessoProdutivoDescerSequencia(lCodigoOrcamento,
                                                                          iCodigoOrcamentoItem,
                                                                          grdOrcamentoGrupo.GetValue("codigo"),
                                                                          grdOrcamentoProcessoProdutivo.GetValue("codigo"),
                                                                          grdOrcamentoProcessoProdutivo.GetValue("sequencia"))

            oClsVenOrcamentoLegado.LoadGridComposicaoProcessoProdutivo(grdOrcamentoProcessoProdutivo,
                                                                       lCodigoOrcamento,
                                                                       iCodigoOrcamentoItem,
                                                                       grdOrcamentoGrupo.GetValue("codigo"))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SubirSequenciaServicoTerceiros()

        Try

            Dim iProximaSequencia As Integer = LoadCodigo("sp_load_venda_orcamento_item_grupo_servico_terceiros_proxima_sequencia " & goUsuario.iEmpresa &
                                                          ", " & lCodigoOrcamento &
                                                          ", " & iCodigoOrcamentoItem &
                                                          ", " & grdOrcamentoGrupo.GetValue("codigo") &
                                                          ", " & grdOrcamentoServicoTerceiros.GetValue("sequencia"))

            If iProximaSequencia = 0 Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.UpdateServicoTerceirosSubirSequencia(lCodigoOrcamento,
                                                                        iCodigoOrcamentoItem,
                                                                        grdOrcamentoGrupo.GetValue("codigo"),
                                                                        grdOrcamentoServicoTerceiros.GetValue("codigo"),
                                                                        grdOrcamentoServicoTerceiros.GetValue("sequencia"))

            oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(grdOrcamentoServicoTerceiros,
                                                                      lCodigoOrcamento,
                                                                      iCodigoOrcamentoItem,
                                                                      grdOrcamentoGrupo.GetValue("codigo"))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DescerSequenciaServicoTerceiros()

        Try

            If grdOrcamentoServicoTerceiros.GetValue("sequencia") = 10 Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.UpdateServicoTerceirosDescerSequencia(lCodigoOrcamento,
                                                                         iCodigoOrcamentoItem,
                                                                         grdOrcamentoGrupo.GetValue("codigo"),
                                                                         grdOrcamentoServicoTerceiros.GetValue("codigo"),
                                                                         grdOrcamentoServicoTerceiros.GetValue("sequencia"))

            oClsVenOrcamentoLegado.LoadGridComposicaoServicoTerceiros(grdOrcamentoServicoTerceiros,
                                                                      lCodigoOrcamento,
                                                                      iCodigoOrcamentoItem,
                                                                      grdOrcamentoGrupo.GetValue("codigo"))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub HabilitaCampos()

        Try

            grpMotivo.Enabled = bPermissaoEditar
            grpFormacaoPreco.Enabled = bPermissaoEditar
            grpDespesaVariavel.Enabled = bPermissaoEditar
            btnSalvar.Enabled = bPermissaoEditar
            btnImportarEstrutura.Enabled = bPermissaoEditar
            btnImportarRegra.Enabled = bPermissaoEditar
            btnInserirServico.Enabled = bPermissaoEditar
            btnImportarContrato.Enabled = bPermissaoEditar

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FORMAÇÃO DE PREÇO :::"

    Private Sub SalvarDespesasVariaveis()

        Try

            If bPermissaoEditar = False Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            CalculaICMSReduzido()

            ConfiguraDespesaVariavel()

            oClsVenOrcamentoLegado.UpdateDespesasVariaveis(lCodigoOrcamento,
                                                           iCodigoOrcamentoItem,
                                                           txtPorcentagemReducaoBCICMS.Value,
                                                           txtAliquotaICMSPorcentagem.Value,
                                                           txtAliquotaPISPorcentagem.Value,
                                                           txtAliquotaCOFINSPorcentagem.Value,
                                                           txtAliquotaISSPorcentagem.Value,
                                                           txtAliquotaIR.Value,
                                                           txtAliquotaCSLL.Value,
                                                           txtComissaoPorcentagem.Value)

            txtDespesaVariavelPorcentagem.Value = txtAliquotaPISPorcentagem.Value +
                                                  txtAliquotaCOFINSPorcentagem.Value +
                                                  txtAliquotaISSPorcentagem.Value +
                                                  txtComissaoPorcentagem.Value +
                                                  txtAliquotaIR.Value +
                                                  txtAliquotaCSLL.Value +
                                                  txtAliquotaICMSReduzida.Value

            CalculaValores()
            CalculaGraficoFormacaoPreco()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarValores()

        Try

            If tabMain.SelectedTab.Key <> pagFormacaoPreco.Key Then Exit Sub
            If bPermissaoEditar = False Then Exit Sub

            If MsgBox("Deseja atualizar os valores da Despesa Variável de acordo com o cadastro do cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then

                oClsVenOrcamentoLegado.UpdateDespesasVariaveisCliente(lCodigoOrcamento,
                                                                      iCodigoOrcamentoItem)

                txtDespesaVariavel.Value = LoadCodigo("sp_load_venda_orcamento_item_despesa_variavel " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)
                txtDespesaVariavelPorcentagem.Value = LoadCodigo("sp_load_venda_orcamento_item_despesa_variavel_porcentagem " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)

            End If

            If MsgBox("Deseja atualizar os valores de despesa fixa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then
                txtDespesaFixa.Value = LoadCodigo("sp_load_configuracao_orcamento_despesa_fixa " & goUsuario.iEmpresa)
                txtDespesaFixaPorcentagem.Value = (txtDespesaFixa.Value / IIf(txtCustoTotal.Value <= 0, 1, txtCustoTotal.Value))
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ConfiguraDespesaVariavel()

        Try

            If sTipo = "SERVIÇO" Then 'Se for serviço, desabilita icms e ipi

                ConfiguraCampo(txtPorcentagemReducaoBCICMS, False)
                ConfiguraCampo(txtAliquotaICMSPorcentagem, False)
                ConfiguraCampo(txtAliquotaPISPorcentagem, False)
                ConfiguraCampo(txtAliquotaCOFINSPorcentagem, True)
                ConfiguraCampo(txtAliquotaISSPorcentagem, True)
                ConfiguraCampo(txtAliquotaICMSReduzida, False)
                ConfiguraCampo(txtAliquotaIR, True)
                ConfiguraCampo(txtAliquotaCSLL, True)

            Else 'Se não for serviço, calcula icms/pis/cofins e desabilita o iss

                ConfiguraCampo(txtPorcentagemReducaoBCICMS, True)
                ConfiguraCampo(txtAliquotaICMSPorcentagem, True)
                ConfiguraCampo(txtAliquotaPISPorcentagem, True)
                ConfiguraCampo(txtAliquotaCOFINSPorcentagem, True)
                ConfiguraCampo(txtAliquotaISSPorcentagem, False)
                ConfiguraCampo(txtAliquotaIR, True)
                ConfiguraCampo(txtAliquotaCSLL, True)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ConfiguraCampo(ByVal oMaskedEditBox As Janus.Windows.GridEX.EditControls.NumericEditBox, _
                               ByVal bUtilizavel As Boolean)

        Try

            'Chamado 6298 - Importar a "Regra de imposto do orçamento", não permitindo a edição manual dos impostos.
            'If bUtilizavel = True Then
            '    oMaskedEditBox.ReadOnly = False
            '    oMaskedEditBox.BackColor = Color.White
            '    oMaskedEditBox.TabStop = True
            'Else
            '    oMaskedEditBox.Value = 0
            '    oMaskedEditBox.ReadOnly = True
            '    oMaskedEditBox.BackColor = Color.WhiteSmoke
            '    oMaskedEditBox.TabStop = False
            'End If

            If bUtilizavel = False Then oMaskedEditBox.Value = 0
            oMaskedEditBox.ReadOnly = True
            oMaskedEditBox.BackColor = Color.WhiteSmoke
            oMaskedEditBox.TabStop = False

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalcularFormacaoPreco()

        Try

            txtCustoTotal.Value = LoadCodigo("sp_load_venda_orcamento_item_custo_total " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)
            txtCustoTotal.Value += txtFrete.Value / IIf(txtQuantidade.Value > 0, txtQuantidade.Value, 1)
            txtValorContrato.Value = LoadCodigo("sp_load_venda_orcamento_item_custo_total_contrato " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)

            oClsVenOrcamentoLegado.LoadDadosDespesaVariavel(lCodigoOrcamento,
                                                            iCodigoOrcamentoItem,
                                                            txtPorcentagemReducaoBCICMS,
                                                            txtAliquotaICMSPorcentagem,
                                                            txtAliquotaPISPorcentagem,
                                                            txtAliquotaCOFINSPorcentagem,
                                                            txtAliquotaIR,
                                                            txtAliquotaCSLL,
                                                            txtAliquotaISSPorcentagem,
                                                            txtComissaoPorcentagem)

            SalvarDespesasVariaveis()

            ConfiguraDespesaVariavel()
            CalculaICMSReduzido()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaValores()

        Try

            txtCustoTotalPorcentagem.Value = txtPrecoVendaPorcentagem.Value - txtLucroPorcentagem.Value - txtDespesaFixaPorcentagem.Value - txtDespesaVariavelPorcentagem.Value

            txtPrecoVenda.Value = (txtCustoTotal.Value * txtPrecoVendaPorcentagem.Value) / IIf(txtCustoTotalPorcentagem.Value <= 0, 1, txtCustoTotalPorcentagem.Value)
            txtLucro.Value = txtPrecoVenda.Value * txtLucroPorcentagem.Value
            txtDespesaVariavel.Value = txtPrecoVenda.Value * txtDespesaVariavelPorcentagem.Value
            txtDespesaFixa.Value = txtPrecoVenda.Value * txtDespesaFixaPorcentagem.Value
            txtValorComIPI.Value = (txtPrecoVenda.Value * IIf(txtAliquotaIPI.Value = 0, 1, 1 + txtAliquotaIPI.Value)) + txtValorContrato.Value
            txtValorDesconto.Value = IIf(txtDescontoPorcentagem.Value > 0, (txtPrecoVenda.Value / (1 - txtDescontoPorcentagem.Value)) - txtPrecoVenda.Value, 0)

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
            oDataSet.Tables(0).Columns.Add("tipo")
            oDataSet.Tables(0).Columns.Add("valor").DataType = 0.0.GetType
            oDataSet.Tables(0).Columns.Add("descricao")

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Custo"
            oDataRow(1) = txtCustoTotalPorcentagem.Value * 100.0
            oDataRow(2) = "R$ " + CStr(txtCustoTotal.Value)

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Despesa Variável"
            oDataRow(1) = txtDespesaVariavelPorcentagem.Value * 100.0
            oDataRow(2) = "R$ " + CStr(txtDespesaVariavel.Value)

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Despesa Fixa"
            oDataRow(1) = txtDespesaFixaPorcentagem.Value * 100.0
            oDataRow(2) = "R$ " + CStr(txtDespesaFixa.Value)

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = "Lucro"
            oDataRow(1) = txtLucroPorcentagem.Value * 100.0
            oDataRow(2) = "R$ " + CStr(txtLucro.Value)

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            chrFormacaoPreco.Titles.Clear()
            chrFormacaoPreco.Series.Clear()

            'Adiciona Serie
            chrFormacaoPreco.Series.Add("main")

            'Carrega Grafico
            chrFormacaoPreco.Series("main").Points.DataBind(oDataReader(0), "tipo", "valor", "Tooltip=descricao")

            For j As Integer = 0 To chrFormacaoPreco.Series.Count - 1

                chrFormacaoPreco.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Pie
                chrFormacaoPreco.Series(j).ShowInLegend = True
                chrFormacaoPreco.Series(j).SmartLabels.Enabled = True
                chrFormacaoPreco.Series(j).MarkerSize = 1
                chrFormacaoPreco.Series(j).BorderWidth = 1
                chrFormacaoPreco.Series(j).EmptyPointStyle.Color = Color.Transparent
                chrFormacaoPreco.Series(j).BorderStyle = ChartDashStyle.Solid
                chrFormacaoPreco.Series(j).BorderColor = Color.Black
                chrFormacaoPreco.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                chrFormacaoPreco.Series(j).LabelFormat = "0.00#%"
                chrFormacaoPreco.Series(j).BorderColor = Color.FromArgb(255, 26, 59, 105)
                chrFormacaoPreco.Series(j).ShadowOffset = 2
                chrFormacaoPreco.Series(j).ShowLabelAsValue = True

            Next

            For Each oSeries As Series In chrFormacaoPreco.Series

                For Each oDataPoint As DataPoint In oSeries.Points

                    Select Case oDataPoint.AxisLabel

                        Case "Custo" : oDataPoint.Color = Color.Red
                        Case "Lucro" : oDataPoint.Color = Color.LightGreen
                        Case "Despesa Fixa" : oDataPoint.Color = Color.LightSalmon
                        Case "Despesa Variável" : oDataPoint.Color = Color.LightBlue

                    End Select

                Next

            Next

            chrFormacaoPreco.Series(0)("PieLabelStyle") = "Outside"
            chrFormacaoPreco.ChartAreas(0).Area3DStyle.Enable3D = False
            chrFormacaoPreco.ChartAreas(0).BackColor = Color.White
            chrFormacaoPreco.ChartAreas(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            chrFormacaoPreco.ChartAreas(0).ShadowOffset = 2
            chrFormacaoPreco.ChartAreas(0).BorderStyle = ChartDashStyle.Solid
            chrFormacaoPreco.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Solid
            chrFormacaoPreco.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Silver
            chrFormacaoPreco.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Silver
            chrFormacaoPreco.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Solid
            chrFormacaoPreco.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            chrFormacaoPreco.ChartAreas(0).AxisX.Interval = 1
            chrFormacaoPreco.ChartAreas(0).ReCalc()
            chrFormacaoPreco.Legends(0).Alignment = StringAlignment.Center
            chrFormacaoPreco.Legends(0).Docking = LegendDocking.Right
            chrFormacaoPreco.Legends(0).LegendStyle = LegendStyle.Column
            chrFormacaoPreco.Legends(0).AutoFitText = False
            chrFormacaoPreco.Legends(0).BackColor = Color.White
            chrFormacaoPreco.Legends(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            chrFormacaoPreco.Legends(0).BorderStyle = ChartDashStyle.Solid
            chrFormacaoPreco.Legends(0).BorderWidth = 1
            chrFormacaoPreco.Legends(0).DockInsideChartArea = True
            chrFormacaoPreco.BackColor = Color.WhiteSmoke
            chrFormacaoPreco.BackGradientEndColor = Color.White
            chrFormacaoPreco.BackGradientType = GradientType.DiagonalLeft
            chrFormacaoPreco.BorderLineColor = Color.FromArgb(255, 26, 59, 105)
            chrFormacaoPreco.BorderLineStyle = ChartDashStyle.Solid
            chrFormacaoPreco.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            chrFormacaoPreco.BorderSkin.FrameBackColor = Color.CornflowerBlue
            chrFormacaoPreco.BorderSkin.FrameBackGradientEndColor = Color.CornflowerBlue
            chrFormacaoPreco.BorderSkin.PageColor = Color.FromArgb(255, 240, 240, 240)
            chrFormacaoPreco.UI.Toolbar.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            chrFormacaoPreco.UI.Toolbar.BorderSkin.FrameBackColor = Color.Gray
            chrFormacaoPreco.UI.Toolbar.BorderSkin.PageColor = Color.Transparent

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaICMSReduzido()

        Try

            Dim dAliquotaICMS As Double = 0

            If txtPorcentagemReducaoBCICMS.Value <= 0 Then
                dAliquotaICMS = txtAliquotaICMSPorcentagem.Value
            Else
                dAliquotaICMS = Math.Round((1 - txtPorcentagemReducaoBCICMS.Value) / (0.01 / IIf(txtAliquotaICMSPorcentagem.Value <= 0, 1, txtAliquotaICMSPorcentagem.Value)) / 100.0, 3)
            End If

            txtAliquotaICMSReduzida.Value = dAliquotaICMS

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoServicoTerceiros() As Boolean

        Try

            If ValidaCampo(cboGrupo, lblGrupo) = False Then Return False
            If ValidaCampo(cboServicoTerceiros, lblServicoTerceiros) = False Then Return False
            If ValidaCampo(txtQuantidadeServico, lblQuantidadeServico, True) = False Then Return False
            If ValidaCampo(txtValorUnitario, lblValorUnitario, True) = False Then Return False
            If ValidaCampo(txtValorTotal, lblValorTotal, True) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CHECKLIST CLIENTE :::"

    Private Sub LoadGridChecklistCliente()
        Try

            oClsVenOrcamentoLegado.LoadGridChecklistClienteItem(grdOrcamentoCheckListCliente, lCodigoOrcamento, iCodigoOrcamentoItem)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub UpdateChecklistCliente()
        Try

            oClsVenOrcamentoLegado.UpdateChecklistClienteItem(lCodigoOrcamento:=lCodigoOrcamento,
                                                              iCodigoOrcamentoItem:=iCodigoOrcamentoItem,
                                                              iCodigoCheklistCliente:=grdOrcamentoCheckListCliente.GetValue("codigo"),
                                                              bImpressoProposta:=grdOrcamentoCheckListCliente.GetValue("impresso_proposta"),
                                                              bExportadoParaOP:=grdOrcamentoCheckListCliente.GetValue("exportado_ordem_producao"))

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

    Private Sub btnImportarContrato_Click(sender As Object, e As EventArgs) Handles btnImportarContrato.Click

        Try

            If bPermissaoEditar = False Then Exit Sub

            Dim oForm As New frmVenOrcamentoImportarContrato
            oForm.CodigoOrcamento = lCodigoOrcamento
            oForm.CodigoOrcamentoItem = iCodigoOrcamentoItem
            oForm.Formulario = iFormulario
            oForm.CodigoContrato = iCodigoContrato
            oForm.ShowDialog()

            If oForm.Sucesso = True Then

                LoadGridGrupo()
                LoadChartComposicao()

                If MsgBox("Deseja atualizar os dados de despesa variável e despesa fixa de acordo com o orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    oClsVenOrcamentoLegado.UpdateDespesasContrato(lCodigoOrcamento, _
                                                                  iCodigoOrcamentoItem, _
                                                                  iCodigoContrato)

                    txtDespesaFixaPorcentagem.Value = LoadCodigo("sp_load_venda_orcamento_item_contrato_despesa_fixa " & lCodigoOrcamento & "," & iCodigoOrcamentoItem & "," & goUsuario.iEmpresa)

                    CalcularFormacaoPreco()

                End If

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

End Class