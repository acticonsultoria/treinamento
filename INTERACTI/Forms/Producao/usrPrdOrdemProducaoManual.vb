Imports System.Threading
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.Drawing.Printing
Imports Janus.Windows.Common
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System.util.collections
'Imports ATN.Catia.R24.COM.CatiaApplication
'Imports netDxf
Public Class usrPrdOrdemProducaoManual

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
    Private oClsUsrPrjProcesso As New clsUsrPrjProcesso
    Private iFormulario As Integer
    Private lCodigoOrdemProducao As Long
    Private lCodigoRequisicao As Long
    Private bLiberarEdicao As Boolean

    'Verifica Direito por ABA
    Private iFormularioAbaDadosGerais As Integer
    Private iFormularioAbaAcompanhamento As Integer
    Private iFormularioAbaProcessoProdutivo As Integer
    Private iFormularioAbaListaMaterial As Integer
    Private iFormularioAbaServicoExterno As Integer
    Private iFormularioAbaCompras As Integer
    Private iFormularioAbaProjeto As Integer
    Private iFormularioAbaApontamentos As Integer
    Private iFormularioAbaQualidade As Integer
    Private iFormularioAbaPlanejamento As Integer
    Private iFormularioAbaArquivo As Integer
    Private iFormularioAbaLog As Integer
    Private iFormularioAbaEstimativaHoras As Integer
    Private iFormularioBtnFinalizarOP As Integer
    Private sExibirDataFaturar As String = ""

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

                Case "adicionar_checklist_cliente"


                    Dim oForm As New frmPrdOrdemProducaoManualAdicionarChecklistCliente
                    oForm.CodigoOrdemProducao = lCodigoOrdemProducao
                    oForm.ShowDialog()

                    LoadGridChecklistCliente()


                Case "excluir_checklist_cliente"

                    If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

                    oClsUsrPrdProducaoManual.DeleteChecklistCliente(lCodigoOrdemProducao, grdOrcamentoCheckListOrdemProducao.GetValue("codigo"))
                    grdOrcamentoCheckListOrdemProducao.CurrentRow.Delete()

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

#End Region

#Region "::: CONTROLES :::"

#Region ":: ORDEM DE PRODUÇÃO :::"

    Private Sub dtpDataNecessidade_LostFocus(sender As Object, e As EventArgs) Handles dtpDataNecessidade.LostFocus
        Try

            If dtpDataNecessidade.Value > dtpDataEntrega.Value Then

                MsgBox("Não é possível colocar essa data de necessidade pois ela é posterior à data de entrega. Entrar em contato com o setor comercial para alterar a data de entrega!", MsgBoxStyle.Exclamation, "Validação")
                dtpDataNecessidade.Value = dtpDataEntrega.Value

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.ToString)
        End Try
    End Sub

    Private Sub dtpDataEntrega_LostFocus(sender As Object, e As EventArgs) Handles dtpDataEntrega.LostFocus
        Try

            If dtpDataNecessidade.Value > dtpDataEntrega.Value Then

                MsgBox("Não é possível colocar essa data de entrega pois ela é inferior à data de necessidade. Entrar em contato com o setor comercial para alterar a data de entrega!", MsgBoxStyle.Exclamation, "Validação")
                dtpDataEntrega.Value = dtpDataNecessidade.Value

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.ToString)
        End Try
    End Sub

    Private Sub UiContextMenuAlterarStatus_CommandClick(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenuAlterarStatus.CommandClick
        Try

            'Verifica Permissao por STATUS (+20000 para bater com o ID da tb_stc_formulario)
            Dim iCodigoPermissao As Integer = e.Command.Tag + 20000
            If VerificaDireito(iCodigoPermissao, gcSelect) = False Then
                frmMain.Informacao("Usuário sem permissão necessária para [ " + e.Command.Text + " ]", Color.Red)
                Exit Sub
            End If

            Dim sCodigoOrdemProducao As String = ""

            'Concatena os codigos
            For Each oRow In grdListagem.GetCheckedRows

                sCodigoOrdemProducao += IIf(sCodigoOrdemProducao = "", "", ",") + CStr(oRow.Cells.Item("codigo").Value)

            Next

            'Altera o status
            AlterarStatus(sCodigoOrdemProducao, e.Command)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnFindOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnFindOrdemProducao.Click
        Try

            Dim sInputbox As String = InputBox("Digite o numero da OP: ", "Buscar OP")

            If sInputbox = "" Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_select_producao_ordem_producao_codigo_numero_os '" & sInputbox & "'," & goUsuario.iEmpresa)


            If lCodigoOrdemProducao = -1 Then
                MsgBox("Ordem de produção não encontrada!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Call Editar(lCodigo)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnimagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagem.Click

        Try

            'Variaveis Locais
            Dim arqImagem As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqImagem.InitialDirectory = "c:\\dados"
            arqImagem.Filter = "(Imagens BMP;JPG;GIF;PNG)|*.bmp;*.jpg;*.gif;*.png"
            arqImagem.Title = "Selecione o Arquivo"

            If arqImagem.ShowDialog() = DialogResult.OK Then
                txtImagem.Text = arqImagem.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnLimparImagem_Click(sender As Object, e As EventArgs) Handles btnLimparImagem.Click

        Try

            'Limpa Logo
            picImagem.Image = Nothing
            txtImagem.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub txtImagem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagem.TextChanged

        Try

            'Verifica se foi Selecionado alguma Logo
            If txtImagem.Text <> "" Then

                'Carrega Imagem
                Dim oImage As Image = Image.FromFile(txtImagem.Text)

                ''Obtém tamanho da Imagem
                'Dim iWidth As Integer = oImage.Size.Width
                'Dim iHeight As Integer = oImage.Size.Height
                'Dim oNewSize As Size

                'If (214 / iWidth) < (134 / iHeight) Then
                '    oNewSize = New Size(214, 214 * iHeight / iWidth)
                'Else
                '    oNewSize = New Size(134 * iWidth / iHeight, 134)
                'End If

                ''Carrega Imagem da Váriavel
                'Dim oNewImagem As Image = New Bitmap(oImage)

                ''Descarrega Imagem do Arquivo da Memória
                'oImage.Dispose()

                'oNewImagem = New Bitmap(oNewImagem, oNewSize)

                picImagem.Image = oImage
                picImagem.SizeMode = PictureBoxSizeMode.StretchImage

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAbrirPedidoVenda_Click(sender As Object, e As EventArgs) Handles btnAbrirPedidoVenda.Click
        Try

            If IsNumeric(txtNumeroPedidoVenda.Tag) Then

                Dim sUsuarioPedidoVenda As String = LoadCodigo("sp_load_producao_ordem_producao_usuario_orcamento " & txtNumeroPedidoVenda.Tag & "," & goUsuario.iEmpresa & "," & 2)
                If sUsuarioPedidoVenda <> goUsuario.sUsuario Then
                    frmMain.Informacao("Não é possível Visualizar Pedidos de Vendas de outros Usuários.", Color.Red)
                    Exit Sub
                End If


                Dim oUserControl As UserControl
                Dim oAssembly As System.Reflection.Assembly = GetExecutingAssembly()

                oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrVenPedidoLegado")
                oUserControl.Dock = DockStyle.Fill
                oUserControl.Tag = "ID:" + CStr(txtNumeroPedidoVenda.Tag)

                frmMain.LoadPage("Pedido", "Pedido", oUserControl, True)

                Application.DoEvents()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnAbrirOrcamento_Click(sender As Object, e As EventArgs) Handles btnAbrirOrcamento.Click
        Try

            If IsNumeric(txtNumeroPedidoVenda.Tag) Then

                Dim sUsuarioOrcamento As String = LoadCodigo("sp_load_producao_ordem_producao_usuario_orcamento " & txtNumeroOrcamento.Tag & "," & goUsuario.iEmpresa & "," & 1)
                If sUsuarioOrcamento <> goUsuario.sUsuario Then
                    frmMain.Informacao("Não é possível Visualizar Orçamento de outros Usuários.", Color.Red)
                    Exit Sub
                End If


                Dim oUserControl As UserControl
                Dim oAssembly As Assembly = GetExecutingAssembly()

                oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrVenOrcamentoLegado")
                oUserControl.Dock = DockStyle.Fill
                oUserControl.Tag = "ID:" + CStr(txtNumeroOrcamento.Tag)

                frmMain.LoadPage("Orçamento", "Orçamento", oUserControl, True)

                Application.DoEvents()

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            Dim sCodigo As String = ""

            If grdListagem.GetCheckedRows.Count = 0 Then Exit Sub

            For Each oRow In grdListagem.GetCheckedRows

                sCodigo += IIf(sCodigo = "", "", ",") & CStr(oRow.Cells.Item("codigo").Value)

            Next

            Call Imprimir(sCodigo)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnImprimir2_Click(sender As Object, e As EventArgs) Handles btnImprimir2.Click
        Try


            Call Imprimir(lCodigoOrdemProducao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarFormulario()

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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListaMaterial_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListaMaterial.CellUpdated
        Try

            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)

                oClsUsrPrdProducaoManual.LoadGridRequisicaoEstoque(grdListaMaterial,
                                                                   lCodigoOrdemProducao,
                                                                   2)
                Exit Sub
            End If

            With grdListaMaterial

                'Verifica a coluna editada
                If .CurrentColumn.Key = "item_compra" Then

                    'Não permitirar tirar de compra, se já existir uma requisição de compra
                    If .GetValue("item_compra") = False And Not IsDBNull(.GetValue("requisicao_compra")) Then

                        'Informa o usuário
                        MsgBox("Não é possível tirar o item de compra pois já existe uma requisiçao de compra para ele!", MsgBoxStyle.Exclamation, "Validação")

                        'Volta o status anterior
                        .SetValue("item_compra", 1)

                    ElseIf .GetValue("item_compra") = True And IsDBNull(.GetValue("grupo_item")) Then

                        'Informa o usuário
                        MsgBox("Não é possível tirar o item de compra pois não foi definido o grupo de item!", MsgBoxStyle.Exclamation, "Validação")

                        'Volta o status anterior
                        .SetValue("item_compra", 0)



                    Else

                        'Atualiza o campo
                        ExecuteQuery("sp_update_estoque_requisicao_item_item_compra " &
                                                                    .GetValue("codigo_requisicao") & "," &
                                                                    .GetValue("codigo_requisicao_item") & "," &
                                                                    goUsuario.iEmpresa & "," &
                                                                    .GetValue("item_compra"))


                    End If
                End If
            End With
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grd_ColumnMoved(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved,
                                                                                                            grdArquivo.ColumnMoved,
                                                                                                            grdRoteiro.ColumnMoved,
 _
                                                                                                            grdQualidade.ColumnMoved,
                                                                                                            grdAcompanhamento.ColumnMoved,
                                                                                                            grdListaMaterial.ColumnMoved, _
                                                                                                            grdEstimativaAnalitico.ColumnMoved

        Try

            UpdateConfiguraGrid(sender,
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(sender As Object, e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn,
                                                                                                            grdArquivo.SizingColumn,
                                                                                                            grdRoteiro.SizingColumn,
 _
                                                                                                            grdQualidade.SizingColumn,
                                                                                                            grdAcompanhamento.SizingColumn,
                                                                                                            grdListaMaterial.SizingColumn, _
                                                                                                            grdEstimativaAnalitico.SizingColumn

        Try

            UpdateConfiguraGrid(sender.Name,
                                iFormulario,
                                e.Column.Key,
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As Janus.Windows.GridEX.GroupsChangingEventArgs) Handles grdListagem.GroupsChanging,
        grdArquivo.GroupsChanging,
        grdRoteiro.GroupsChanging,
        grdAcompanhamento.GroupsChanging

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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar(grdListagem.CurrentRow.Cells.Item("codigo").Value) ' : tabDados.SelectedTab = pagDadosGerais
                Case "excluir" : Excluir(grdListagem)
                Case "cancelar" : Cancelar(grdListagem, -1)
                Case "historico" : HistoricoOrdemProducao()
                Case "reativar" : Reativar()
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(sender As Object, e As EventArgs)

        Try

            Novo()

            'Alterna Aba                
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnImportarBOM_Click(sender As Object, e As EventArgs) Handles btnImportarBom.Click

        Try

            'ImportarPlanilha()
            'oClsUsrPrdProducaoManual.LoadGridAcompanhamento(grdAcompanhamento,
            '                                                lCodigoOrdemProducao)

            ImportarCATIA()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProximaOP_Click(sender As Object, e As EventArgs) Handles btnProximaOP.Click

        Try

            If IsNumeric(lCodigoOrdemProducao) = False Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_producao_ordem_producao_codigo 0,1, " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)

            If lCodigo >= 0 Then
                Editar(lCodigo, True)
            Else
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAnteriorOP_Click(sender As Object, e As EventArgs) Handles btnAnteriorOP.Click

        Try

            If IsNumeric(lCodigoOrdemProducao) = False Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_producao_ordem_producao_codigo 0,2, " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)


            If lCodigo >= 0 Then
                Editar(lCodigo, True)
            Else
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProximaOPTopo_Click(sender As Object, e As EventArgs) Handles btnProximaOPTopo.Click

        Try

            If IsNumeric(lCodigoOrdemProducao) = False Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_producao_ordem_producao_codigo 1,1, " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)


            If lCodigo >= 0 Then
                Editar(lCodigo, True)
            Else
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAnteriorOPTopo_Click(sender As Object, e As EventArgs) Handles btnAnteriorOPTopo.Click

        Try

            If IsNumeric(lCodigoOrdemProducao) = False Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_producao_ordem_producao_codigo 1,2, " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)


            If lCodigo >= 0 Then
                Editar(lCodigo, True)
            Else
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnOPTopo_Click(sender As Object, e As EventArgs) Handles btnOPTopo.Click

        Try

            If IsNumeric(lCodigoOrdemProducao) = False Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_producao_ordem_producao_codigo 1,0, " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)

            If lCodigo >= 0 Then
                Editar(lCodigo, True)
            Else
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnOPUltimoTopo_Click(sender As Object, e As EventArgs) Handles btnOPUltimoTopo.Click
        Try

            If IsNumeric(lCodigoOrdemProducao) = False Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_producao_ordem_producao_codigo 1,3, " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)

            If lCodigo >= 0 Then
                Editar(lCodigo, True)
            Else
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub btnProcurarClienteFiltro_Click(sender As Object, e As EventArgs) Handles btnProcurarClienteFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro
            oForm.ShowDialog(Me)

            cboClienteFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFindAutoTextoObservacaoServicoExterno_Click(sender As Object, e As EventArgs) Handles btnFindAutoTextoObservacaoServicoExterno.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindAutotextoOperacao"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar texto operação"

            oEditBoxFind = txtObservacaoServicoTerceiro
            oForm.ShowDialog(Me)

            txtObservacaoServicoTerceiro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFindAutoTextoObservacaoRoteiro_Click(sender As Object, e As EventArgs) Handles btnFindAutoTextoObservacaoRoteiro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindAutotextoOperacao"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar texto operação"

            oEditBoxFind = txtObservacaoRoteiro
            oForm.ShowDialog(Me)

            txtObservacaoRoteiro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnGerarRequisicaoCompra_Click(sender As Object, e As EventArgs) Handles btnGerarRequisicaoCompra.Click

        Try

            For Each oRow In grdCompras.GetCheckedRows
                If IsDBNull(oRow.Cells.Item("requisicao_compra").Value) = False Then

                    If oRow.Cells("status_requisicao_compra").Value <> "REPROVADO" Then

                        MsgBox("Não é possível gerar a requisição de compra pois já existe uma requisição para o item selecionado!", MsgBoxStyle.Exclamation, "Gerando RC")
                        Exit Sub

                    End If


                End If
            Next


            If MsgBox("Deseja gerar a requsição de compra para essa Ordem de produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) <> MsgBoxResult.Yes Then Exit Sub

            GerarRequisicaoCompra()

            oClsUsrPrdProducaoManual.LoadGridCompras(grdCompras,
                                                     lCodigoOrdemProducao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListaMaterial_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListaMaterial.RowDoubleClick
        Try
            Select Case grdListaMaterial.CurrentColumn.Key

                Case "grupo_item" : EditarGrupoItemListaMaterial()

            End Select
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnInserirNovaOP_Click(sender As Object, e As EventArgs) Handles btnInserirNovaOP.Click
        Try

            'Instancia o form
            Dim oForm As New frmPrdOrdemProducaoProdutoFabricado
            oForm.CodigoRequsicao = -1
            oForm.CodigoOrdemProducao = -1
            oForm.txtOrdemProducao.Text = ""
            oForm.txtProduto.Text = ""
            oForm.txtQuantidadePlanejada.Text = ""
            oForm.Novo = True
            oForm.ShowDialog()

            If oForm.CodigoNovaOrdemProducao <> -1 Then

                'Carrega a grid novamente
                Editar(oForm.CodigoNovaOrdemProducao)
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnImportarOrdemProducao2_Click(sender As Object, e As EventArgs) Handles btnImportarOrdemProducao2.Click
        Try
            'Instancia o formulário
            Dim oForm As New frmPrdOrdemProducaoImportarOrdemProducao
            oForm.CodigoOrdemProducao = -1
            oForm.ShowDialog()

            'Carrega os dados novamente
            Editar(lCodigoOrdemProducao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnLiberarProducao_Click(sender As Object, e As EventArgs)
        Try

            Dim sCodigo As String = ""

            If grdListagem.GetCheckedRows.Count = 0 Then Exit Sub

            For Each oRow In grdListagem.GetCheckedRows

                sCodigo += IIf(sCodigo = "", "", ",") & CStr(oRow.Cells.Item("codigo").Value)

            Next

            Call LiberarProducao(sCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnConfirmarOP_Click(sender As Object, e As EventArgs)
        Try

            Dim sCodigo As String = ""

            If grdListagem.GetCheckedRows.Count = 0 Then Exit Sub

            For Each oRow In grdListagem.GetCheckedRows

                sCodigo += IIf(sCodigo = "", "", ",") & CStr(oRow.Cells.Item("codigo").Value)

            Next

            Call FinalizacaoOP(sCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: ROTEIRO :::"

    Private Sub btnEstimativaHoras_Click(sender As Object, e As EventArgs) Handles btnEstimativaHoras.Click
        Try
            Dim oForm As New frmPrdOrdemProducaoEstimativaHoras
            oForm.CodigoOrdemProducao = lCodigoOrdemProducao
            oForm.ShowDialog()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnOcultarExibirProcesso_Click(sender As Object, e As EventArgs) Handles btnOcultarExibirProcesso.Click
        Try
            Dim oPointLocation As New Point(grdRoteiro.Location.X, grdRoteiro.Location.Y)
            Dim oSize As New Size(grdRoteiro.Size.Width, grdRoteiro.Size.Height)

            If oPointLocation.Y = 17 Then
                oPointLocation.Y = 190
                oSize.Height = btnOcultarExibirProcesso.Top - txtObservacaoRoteiro.Bottom + 8

            Else
                oPointLocation.Y = 17
                oSize.Height = btnOcultarExibirProcesso.Bottom - 17

            End If

            grdRoteiro.Location = oPointLocation
            grdRoteiro.Size = oSize
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnFindGrupoItemProcessoProdutivo_Click(sender As Object, e As EventArgs) Handles btnFindGrupoItemProcessoProdutivo.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Tag = "SERVIÇOS"
            oForm.Text = "Procurar Grupo de Item"

            'Seta Parametros
            oComboBoxFind = cboCentroTrabalho

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroTrabalho.Focus()


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub txtTempoRoteiro_LostFocus(sender As Object, e As EventArgs) Handles txtTempoSetup.LostFocus,
                                                                                  txtTempoSetupDecimal.LostFocus,
                                                                                   txtTempoMaquinaDecimal.LostFocus,
                                                                                   txtTempoMaquina.LostFocus
        Try

            If sender.name = txtTempoSetup.Name Then

                CalcularHora(txtTempoSetup, txtTempoSetupDecimal)

            ElseIf sender.name = txtTempoSetupDecimal.Name Then

                CalcularHora(txtTempoSetupDecimal, txtTempoSetup)

            ElseIf sender.name = txtTempoMaquina.Name Then

                CalcularHora(txtTempoMaquina, txtTempoMaquinaDecimal)

            ElseIf sender.name = txtTempoMaquinaDecimal.Name Then

                CalcularHora(txtTempoMaquinaDecimal, txtTempoMaquina)

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub
    Private Sub txtTempoMaquina_LostFocus(sender As Object, e As EventArgs) Handles txtTempoMaquina.LostFocus,
                                                                               txtTempoMaquinaDecimal.LostFocus
        Try

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub
    Private Sub btnImportarOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnImportarOrdemProducao.Click

        Try

            ImportarOrdemProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(sender As Object, e As EventArgs) Handles btnCadastrarCentroTrabalho.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroTrabalho")

            'Carrega Combo
            If cboOperacaoExterna.SelectedIndex = -1 Then Exit Sub
            If cboOperacaoExterna.SelectedValue = True Then
                '   lblTempoMaoObra.Text = "Lead Time:"
                Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa)

            Else
                '     lblTempoMaoObra.Text = "Tempo M.O.:"
                Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
            End If


            cboCentroTrabalho.Focus()


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarOperacao_Click(sender As Object, e As EventArgs) Handles btnCadastrarOperacao.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOperacao")

            LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa, True)


            If cboCentroTrabalho.SelectedIndex = -1 Then
                cboOperacao.DataSource = Nothing
                cboOperacao.SelectedIndex = -1
            Else
                LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa, True)
            End If

            cboOperacao.Focus()


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


    Private Sub grdHierarquico_SizingColumn(sender As Object, e As SizingColumnEventArgs) Handles grdAcompanhamento.SizingColumn
        Try

            Dim oGrid As GridEX = sender

            For Each oTable As GridEXTable In oGrid.Tables
                For Each oColumn As GridEXColumn In oTable.Columns
                    If oColumn.Key = e.Column.Key Then
                        oColumn.Width = e.ProposedWidth
                    End If
                Next
            Next

            UpdateConfiguraGrid(sender.Name,
                                iFormulario,
                                e.Column.Key,
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboOperacaoExterna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperacaoExterna.SelectedIndexChanged
        Try
            Dim bExibirDadosInterno As Boolean = False


            If cboOperacaoExterna.SelectedIndex = -1 Then Exit Sub
            If cboOperacaoExterna.SelectedValue = True Then

                btnFindGrupoItemProcessoProdutivo.Visible = True

                lblCentroTrabalho.Text = "Grupo Operação:"
                Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa)

                bExibirDadosInterno = False
                cboMaquina.SelectedIndex = -1


                txtTempoSetupDecimal.Value = 0

            Else
                btnFindGrupoItemProcessoProdutivo.Visible = False

                lblCentroTrabalho.Text = "Centro de Trabalho:"
                '     lblTempoMaoObra.Text = "Tempo M.O.:"
                Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
                bExibirDadosInterno = True
            End If

            lblMaquina.Visible = bExibirDadosInterno
            cboMaquina.Visible = bExibirDadosInterno

            lblTempoSetupDecimal.Visible = bExibirDadosInterno
            txtTempoSetupDecimal.Visible = bExibirDadosInterno
            lblTempoSetup.Visible = bExibirDadosInterno
            txtTempoSetup.Visible = bExibirDadosInterno

            lblTipoDispositivoRoteiro.Visible = bExibirDadosInterno
            cboTipoDispositivoRoteiro.Visible = bExibirDadosInterno
            lblNumeroProcessoRoteiro.Visible = bExibirDadosInterno
            txtNumeroProcessoRoteiro.Visible = bExibirDadosInterno
            lblRevisaoRoteiro.Visible = bExibirDadosInterno
            txtRevisaoRoteiro.Visible = bExibirDadosInterno



        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdRoteiro_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdRoteiro.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdRoteiro.CurrentColumn) Then Exit Sub

            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)
                Exit Sub
            End If

            'Verifica se o Registro foi Cancelado
            If grdRoteiro.GetValue("status") = 6 Then
                MsgBox("O registro encontra-se cancelado; consequentemente, sua edição não é possível.", MsgBoxStyle.Exclamation, "Validação")
            End If

            'Verifica o Tipo de Operação
            Select Case grdRoteiro.CurrentColumn.Key

                Case "subir_ordem"
                    oClsUsrPrdProducaoManual.UpdateSubirOrdem(lCodigoOrdemProducao,
                                              grdRoteiro.GetValue("ordem"))
                    oClsUsrPrdProducaoManual.LoadGridRoteiro(grdRoteiro, lCodigoOrdemProducao)


                Case "descer_ordem"
                    oClsUsrPrdProducaoManual.UpdateDescerOrdem(lCodigoOrdemProducao,
                                              grdRoteiro.GetValue("ordem"))
                    oClsUsrPrdProducaoManual.LoadGridRoteiro(grdRoteiro, lCodigoOrdemProducao)


                Case "editar" : LoadItemRoteiro(lCodigoOrdemProducao,
                                            grdRoteiro.GetValue("sequencia"),
                                            bRetrabalho:=False)
                Case "abrir_retrabalho"
                    LoadItemRoteiro(lCodigoOrdemProducao,
                                grdRoteiro.GetValue("sequencia"),
                                bRetrabalho:=True)
                    cboRetrabalho.SelectedValue = True
                    btnInserirRoteiro.Tag = ""

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirRoteiro_Click(sender As Object, e As EventArgs) Handles btnExcluirRoteiro.Click

        Try

            DeleteRoteiro()
            LoadGridRoteiro()
            NovoRoteiro()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboCentroTrabalho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroTrabalho.SelectedIndexChanged

        Try

            cboOperacao.SelectedIndex = -1
            cboOperacao.DataSource = Nothing

            cboOperador.SelectedIndex = -1
            cboOperador.DataSource = Nothing



            If cboCentroTrabalho.SelectedIndex = -1 Then Exit Sub

            If cboOperacaoExterna.SelectedValue = True Then
                LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao_grupo " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa, True)
            Else
                LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa, True)

            End If



            LoadCombo(cboMaquina, "sp_combo_roteiro_maquinas_centro_trabalho " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa, True)
            LoadCombo(cboOperador, "sp_select_combo_cadastro_basico_funcionario_centro_trabalho " & goUsuario.iEmpresa & "," & cboCentroTrabalho.SelectedValue, True)



        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnInserirRoteiro_Click(sender As Object, e As EventArgs) Handles btnInserirRoteiro.Click

        Try

            frmMain.errInfo.Clear()

            'Dim iApontamento As Integer = 0

            'iApontamento = LoadCodigo("sp_validade_producao_ordem_producao_apontamento " & lCodigoOrdemProducao & ", " & goUsuario.iEmpresa)

            'If iApontamento > 0 Then
            '    MsgBox("Não é possível salvar a operação pois já foi feito algum apontamento para essa Ordem de Produção.", MsgBoxStyle.Exclamation, "Validação")
            '    Exit Sub
            'End If

            If Validacao() = False Then Exit Sub
            If ValidacaoRoteiro() = False Then Exit Sub

            'Edição
            If IsNumeric(btnInserirRoteiro.Tag) Then
                'Verifica se tem rnc em aberto
                If oClsUsrPrdProducaoManual.ValidaRNCAberto(lCodigoOrdemProducao, _
                                                       btnInserirRoteiro.Tag) = False Then

                    If MsgBox("Existe um apontamento com status de [RNC EM ABERTO] nesta operação. Se continuar, ele será encerrado. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbNo Then Exit Sub


                    'Atualiza
                    oClsUsrPrdProducaoManual.UpdateRNCAberto(lCodigoOrdemProducao, _
                                                             btnInserirRoteiro.Tag)

                End If
            End If

            SalvarRoteiro()
            LoadGridRoteiro()
            NovoRoteiro()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarAutoTextoRoteiro_Click(sender As Object, e As EventArgs) Handles btnCadastrarAutoTextoRoteiro.Click,
                                                                                                   btnCadastrarAutoTextoServicoExterno.Click
        Try
            'Abre Formul�rio de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadAutotextoOperacao"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Cadastro Texto Operação"
            oForm.ShowDialog(Me)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub btnNovoProcesso_Click(sender As Object, e As EventArgs) Handles btnNovoRoteiro.Click
        Try

            NovoRoteiro()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub




    Private Sub grdApontamento_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles grdApontamento.CellEdited
        Try

            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)
                LoadGridApontamento()
                Exit Sub
            End If

            Dim oGrid As GridEX = CType(sender, GridEX)
            Dim oRow As GridEXRow = oGrid.CurrentRow
            If IsDBNull(oRow.Cells("data_inicio").Value) = False Then
                If IsDBNull(oRow.Cells("data_termino").Value) = False Then
                    If IsDBNull(oRow.Cells("quantidade_produzida").Value) = False Then
                        If IsDBNull(oRow.Cells("quantidade_rejeito").Value) = False Then
                            If IsDBNull(oRow.Cells("maquina").Value) = False Then
                                If IsDBNull(oRow.Cells("funcionario").Value) = False Then
                                    If IsDBNull(oRow.Cells("codigo_apontamento_funcionario").Value) Then
                                        oClsUsrPrdProducaoManual.InsertApontamento(oRow.Cells("codigo_ordem_producao").Value,
                                                                                   oRow.Cells("sequencia").Value,
                                                                                   oRow.Cells("funcionario").Value,
                                                                                   oRow.Cells("maquina").Value,
                                                                                   oRow.Cells("data_inicio").Value,
                                                                                   oRow.Cells("data_termino").Value,
                                                                                   oRow.Cells("quantidade_rejeito").Value,
                                                                                   oRow.Cells("quantidade_fechamento").Value)
                                    Else
                                        oClsUsrPrdProducaoManual.UpdateApontamento(oRow.Cells("codigo_ordem_producao").Value,
                                                                               oRow.Cells("sequencia").Value,
                                                                               oRow.Cells("codigo_apontamento_funcionario").Value,
                                                                               oRow.Cells("codigo_funcionario").Value,
                                                                               oRow.Cells("maquina").Value,
                                                                               oRow.Cells("data_inicio").Value,
                                                                               oRow.Cells("data_termino").Value,
                                                                               oRow.Cells("quantidade_rejeito").Value,
                                                                               oRow.Cells("quantidade_produzida").Value)
                                    End If
                                Else
                                    TratamentoErro("Preencha o funcionário", Me.Parent.Text)
                                End If
                            Else
                                TratamentoErro("Preencha a maquina", Me.Parent.Text)
                            End If
                        Else
                            TratamentoErro("Preencha a quantidade rejeito", Me.Parent.Text)
                            Exit Sub
                        End If
                    Else
                        TratamentoErro("Preencha a quantidade produzida", Me.Parent.Text)
                        Exit Sub
                    End If
                Else
                    TratamentoErro("Preencha a data de término", Me.Parent.Text)
                    Exit Sub
                End If
            Else
                TratamentoErro("Preencha a data de inicio", Me.Parent.Text)
                Exit Sub
            End If


            LoadGridApontamento()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAtualizarApontamento_Click(sender As Object, e As EventArgs) Handles btnAtualizarApontamento.Click
        Try

            LoadGridApontamento()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdApontamento_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdApontamento.RowDoubleClick
        Try
            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdApontamento.CurrentColumn) Then Exit Sub

            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)
                Exit Sub
            End If

            'Verifica o Tipo de Operação
            Select Case grdApontamento.CurrentColumn.Key
                Case "finalizar_apontamento" : FinalizarApontamento() : LoadGridApontamento()
                Case "excluir" : ExcluirApontamento()
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAtualizarSequenciaAtual_Click(sender As Object, e As EventArgs) Handles btnAtualizarSequenciaAtual.Click
        Try

            'Atualiza a seq.
            ExecuteQuery("sp_update_producao_ordem_producao_sequencia_atual " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)

            Editar(lCodigoOrdemProducao, True)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: EDIÇÃO :::"

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
            oForm.ShowDialog(Me)

            cboCliente.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSumirGroupDadosRoteiro_Click(sender As Object, e As EventArgs) Handles btnSumirGroupDadosRoteiro.Click

        Try

            RedimensionarCampos(IIf(btnInserirRoteiro.Visible = True, False, True))

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvarOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnSalvarOrdemProducao.Click

        Try

            If Validacao() = False Then Exit Sub

            SalvarOrdemProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvarDataFaturar_Click(sender As Object, e As EventArgs) Handles btnSalvarDataFaturar.Click

        Try

            SalvarDataFaturar()
            NotificarFaturamentoPendente()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Try

            LoadGrid()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            txtOrdemProducaoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCopiarRoteiro_Click(sender As Object, e As EventArgs) Handles btnCopiarRoteiro.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub
            SalvarOrdemProducao()

            Dim oForm As New frmPrdOrdemProducaoEstimativaHoras
            oForm.CodigoOrdemProducao = lCodigoOrdemProducao
            oForm.ShowDialog()

            LoadGridRoteiro()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCopiarRoteiroProduto_Click(sender As Object, e As EventArgs) Handles btnCopiarRoteiroOrdemProducao.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub
            SalvarOrdemProducao()

            Dim oForm As New frmPrdOrdemProducaoCopiarRoteiroOP
            oForm.Codigo = lCodigoOrdemProducao
            oForm.ExisteRegistro = IIf(grdRoteiro.GetDataRows.Count > 0, True, False)
            oForm.ShowDialog()

            If oForm.OperacaoRealizada = True Then frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            LoadGridRoteiro()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnInserirArquivo_Click(sender As Object, e As EventArgs) Handles btnInserirArquivo.Click

        Try

            frmMain.errInfo.Clear()

            If ValidacaoArquivo() = False Then Exit Sub

            SalvarArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub btnExcluirArquivo_Click(sender As Object, e As EventArgs) Handles btnExcluirArquivo.Click

        Try

            DeleteArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : VisualizarArquivo()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdArquivo, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGridArquivo_Click(sender As Object, e As EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(sender As Object, e As EventArgs) Handles btnExcelGridArquivo.Click

        Try

            ExportExcel(grdArquivo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO DE ESTOQUE :::"

    Private Sub btnInserirListaMaterial_Click(sender As Object, e As EventArgs) Handles btnInserirListaMaterial.Click
        Try
            'Instancia o form
            Dim oForm As New frmPrdOrdemProducaoListaMaterial
            oForm.CodigoRequsicao = lCodigoRequisicao
            oForm.CodigoOrdemProducao = lCodigoOrdemProducao
            oForm.txtOrdemProducao.Text = txtOrdemProducao.Text
            oForm.txtProduto.Text = txtCodigoProduto.Text
            oForm.txtQuantidadePlanejada.Text = txtQuantidadePlanejada.Text
            'oForm.Tipo = 1

            oForm.ShowDialog()

            'Carrega a grid novamente

            oClsUsrPrdProducaoManual.LoadGridRequisicaoEstoque(grdListaMaterial,
                                                                          lCodigoOrdemProducao,
                                                                          2)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnInserirOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnInserirOrdemProducao.Click
        Try

            'Instancia o form
            Dim oForm As New frmPrdOrdemProducaoProdutoFabricado
            oForm.CodigoRequsicao = lCodigoRequisicao
            oForm.CodigoOrdemProducao = lCodigoOrdemProducao
            oForm.txtOrdemProducao.Text = txtOrdemProducao.Text
            oForm.txtProduto.Text = txtCodigoProduto.Text
            oForm.txtQuantidadePlanejada.Text = txtQuantidadePlanejada.Text
            oForm.Novo = True
            oForm.ShowDialog()

            'Carrega a grid novamente
            oClsUsrPrdProducaoManual.LoadGridAcompanhamento(grdAcompanhamento,
                                                            lCodigoOrdemProducao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnCadastrarProdutoRequisicao_Click(sender As Object, e As EventArgs)

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo
            'LoadCombo(txtCodigoProdutoRequisicao, "sp_select_combo_cadastro_basico_produto_producao " & goUsuario.iEmpresa, False)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdAcompanhamento_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdAcompanhamento.RowDoubleClick

        Try

            If IsNothing(grdAcompanhamento.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdAcompanhamento.CurrentColumn.Key

                Case "visualizar" : Editar(grdAcompanhamento.CurrentRow.Cells.Item("codigo_ordem_producao").Value, True)
                Case "editar" : EditarEstruturaProduto()
                Case "cancelar" : Call Cancelar(grdAcompanhamento,
                                                lCodigoOrdemProducao)
                Case "excluir" : Call Excluir(grdAcompanhamento) : oClsUsrPrdProducaoManual.LoadGridAcompanhamento(grdAcompanhamento,
                                                                                                                   lCodigoOrdemProducao)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirListaMaterial_Click(sender As Object, e As EventArgs) Handles btnExcluirListaMaterial.Click

        Try

            DeleteRequisicaoItem(grdListaMaterial)

            oClsUsrPrdProducaoManual.LoadGridRequisicaoEstoque(grdListaMaterial,
                                                                          lCodigoOrdemProducao,
                                                                          2)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged
        Try

            LoadDadosAba()


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO EXTERNO :::"
    Private Sub btnFindGrupoItem_Click(sender As Object, e As EventArgs) Handles btnFindGrupoItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem2"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Tag = "SERVIÇOS"
            oForm.Text = "Procurar Grupo de Item"

            'Seta Parametros
            oComboBoxFind = cboGrupoOperacao

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboGrupoOperacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub txtLeadTimeServicoExterno_ValueChanged(sender As Object, e As EventArgs) Handles txtLeadTimeServicoExterno.ValueChanged
        Try
            dtpPrazoEntregaServicoExterno.Value = DateAdd(DateInterval.Day, txtLeadTimeServicoExterno.Value, Now)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnSalvarServicoExterno_Click(sender As Object, e As EventArgs) Handles btnSalvarServicoExterno.Click
        Try
            frmMain.errInfo.Clear()


            If Validacao() = False Then Exit Sub
            If ValidacaoServicoExterno() = False Then Exit Sub

            SalvarServicoExterno()
            LoadGridServicoExterno()
            NovoServicoExterno()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcluirServicoExterno_Click(sender As Object, e As EventArgs) Handles btnExcluirServicoExterno.Click
        Try


            DeleteServicoExterno()
            LoadGridServicoExterno()
            NovoServicoExterno()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboGrupoOperacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoOperacao.SelectedIndexChanged
        Try
            If cboGrupoOperacao.SelectedIndex = -1 Then Exit Sub
            LoadCombo(cboOperacaoServicoExterno, "sp_select_combo_cadastro_basico_operacao_grupo " & cboGrupoOperacao.SelectedValue & ", " & goUsuario.iEmpresa)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnCadastrarFornecedorOperacao_Click(sender As Object, e As EventArgs) Handles btnCadastrarFornecedorOperacao.Click
        Try
            'Abre Formul�rio de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadFornecedorOperacao"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Fornecedor por Operação"
            oForm.ShowDialog(Me)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboOperacaoServicoExterno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperacaoServicoExterno.SelectedIndexChanged
        Try
            If cboOperacaoServicoExterno.SelectedIndex = -1 Then Exit Sub
            LoadCombo(cboFornecedorServicoExterno, "sp_select_combo_fornecedores_atribuidos_operacao " & goUsuario.iEmpresa & "," & cboOperacaoServicoExterno.SelectedValue)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdServicoExterno_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdServicoExterno.RowDoubleClick
        Try
            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdServicoExterno.CurrentColumn) Then Exit Sub

            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)
                Exit Sub
            End If

            'Verifica o Tipo de Operação
            Select Case grdServicoExterno.CurrentColumn.Key
                Case "editar" : LoadItemServicoExterno(lCodigoOrdemProducao, grdServicoExterno.GetValue("sequencia"))


                Case "gerar_pedido_compra"

                    If Not IsDBNull(grdServicoExterno.GetValue("numero_requisicao")) Then
                        frmMain.Informacao("Não é possível gerar o pedido de compra, pois já existe uma requsição para o item!", Color.Red)
                        Exit Sub
                    End If

                    If IsDBNull(grdServicoExterno.GetValue("fornecedor")) Then
                        frmMain.Informacao("Não é possível gerar o pedido de compra, pois não foi informado o fornecedor!", Color.Red)
                        Exit Sub
                    End If

                    If IsDBNull(grdServicoExterno.GetValue("codigo_tipo_operacao_subcontrato")) Then

                        frmMain.Informacao("É necessário escolher o tipo de operação de subcontrato para gerar o pedido de compra!", Color.Red)
                        Exit Sub
                    End If


                    If MsgBox("Deseja gerar o pedido de compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Gerar Pedido de Compra") = vbNo Then Exit Sub


                    'Insere os itens
                    oClsUsrPrdProducaoManual.InsertPedidoCompra(grdServicoExterno, lCodigoOrdemProducao)

                    'Informa o usuário
                    frmMain.Informacao("Pedido gerado com sucesso!", Color.Blue)

                    'Carrega novamente
                    oClsUsrPrdProducaoManual.LoadGridServicoExterno(grdServicoExterno, lCodigoOrdemProducao)

            End Select
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboTipoOperacaoSubcontrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoOperacaoSubcontrato.SelectedIndexChanged
        Try
            If cboTipoOperacaoSubcontrato.SelectedIndex = -1 Then Exit Sub

            If cboTipoOperacaoSubcontrato.SelectedValue = 1 Then
                LoadCombo(cboMaterialEnvioSubcontrato, "sp_select_combo_producao_ordem_producao_lista_material " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa, True)

            Else
                LoadCombo(cboMaterialEnvioSubcontrato, "sp_select_combo_producao_ordem_producao_produto_processo " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa & "," & cboOperacaoServicoExterno.SelectedValue, True)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnNovoServicoExterno_Click(sender As Object, e As EventArgs) Handles btnNovoServicoExterno.Click
        Try

            NovoServicoExterno()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: COMPRAS :::"

    Private Sub grdCompras_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdCompras.CellValueChanged
        Try


            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)
                oClsUsrPrdProducaoManual.LoadGridCompras(grdCompras, lCodigoOrdemProducao)
                Exit Sub
            End If


            If grdCompras.CurrentColumn.Key = "conta_contabil" Then

                If Not IsDBNull(grdCompras.GetValue("requisicao_compra")) Then

                    If grdCompras.GetValue("status_requisicao_compra") <> "REPROVADO" And grdCompras.GetValue("status_requisicao_compra") <> "CANCELADO" Then
                        frmMain.Informacao("Não é possível alterar a [CONTA CONTÁBIL], pois já existe uma requisição de compra! Cancele ela antes de continuar a operação", Color.Red)
                        'grdCompras.SetValue("conta_contabil", DBNull.Value)

                        Exit Sub
                    End If

                Else

                    'Liberar edição
                    oClsUsrPrdProducaoManual.UpdatePlanoContasCompras(lCodigoOrdemProducao, grdCompras)



                End If

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdCompras_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdCompras.RowDoubleClick
        Try

            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)
                Exit Sub
            End If

            If grdCompras.CurrentColumn.Key = "cancelar_requisicao" Then


                If Not IsDBNull(grdCompras.GetValue("numero_cotacao")) Then
                    frmMain.Informacao("Não é possível cancelar a requisição pois já existe uma cotação para ela!", vbExclamation)
                    Exit Sub
                End If

                Dim oForm As New frmCmpRequisicaoItemCancelar
                oForm.CodigoRequisicao = grdCompras.GetValue("codigo_requisicao_compra")
                oForm.CodigoRequisicaoItem = grdCompras.GetValue("codigo_requisicao_compra_item")
                oForm.OrigemCancelamento = "Cancelado pelo Requisitante: " & goUsuario.sUsuario
                oForm.ShowDialog()

                oClsUsrPrdProducaoManual.LoadGridCompras(grdCompras, lCodigoOrdemProducao)

            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: QUALIDADE :::"
    Private Sub grdQualidade_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdQualidade.RowDoubleClick
        Try
            If grdQualidade.CurrentColumn.Key = "visualizar" Then

                Dim oUserControl As UserControl
                Dim oAssembly As Assembly = GetExecutingAssembly()

                If grdQualidade.GetValue("tipo") = "RELATÓRIO DE INSPEÇÃO" Then
                    oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrQARelatorioInspecao")
                Else
                    oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrQARNC")
                End If
                oUserControl.Dock = DockStyle.Fill
                oUserControl.Tag = "ID:" + CStr(grdQualidade.CurrentRow.Cells("codigo").Value)

                frmMain.LoadPage("Qualidade", "Qualidade", oUserControl, True)

                Application.DoEvents()

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: ORDEM DE PRODUÇÃO :::"

    Private Sub AlterarStatus(ByVal sCodigoOrdemProducao As String, ByVal uiCommand As Janus.Windows.UI.CommandBars.UICommand)
        Try


            Dim sCodigo As String = ""
            For Each oRow In grdListagem.GetCheckedRows

                sCodigo += IIf(sCodigo = "", "", ",") & oRow.Cells.Item("codigo").Value

            Next


            Dim oForm As New frmPrdOrdemProducaoAlterarStatus
            oForm.CommandBar = uiCommand
            oForm.Codigo = sCodigo

            oForm.ShowDialog()


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub LoadDadosAba()
        Try
            If tabDados.SelectedTab IsNot Nothing Then

                btnGerarRequisicaoCompra.Visible = False

                Select Case tabDados.SelectedTab.Name
                    Case pagAcompanhamento.Name : oClsUsrPrdProducaoManual.LoadGridAcompanhamento(grdAcompanhamento,
                                                                                               lCodigoOrdemProducao)
                    Case pagRoteiro.Name : LoadGridRoteiro()
                    Case pagComprasAnalitico.Name : oClsUsrPrdProducaoManual.LoadGridCompras(grdCompras,
                                                                                          lCodigoOrdemProducao) : btnGerarRequisicaoCompra.Visible = True

                    Case pagServicoExterno.Name : LoadGridServicoExterno()
                    Case pagProjeto.Name : LoadGridProcessoEtapa()
                    Case pagApontamento.Name : LoadGridApontamento()
                    Case pagArquivo.Name : oClsUsrPrdProducaoManual.LoadGridArquivo(grdArquivo, lCodigoOrdemProducao)
                    Case pagQualidade.Name : oClsUsrPrdProducaoManual.LoadGridQualidade(grdQualidade, lCodigoOrdemProducao)
                    Case pagLog.Name : oClsUsrPrdProducaoManual.LoadGridLog(grdLog, lCodigoOrdemProducao)
                    Case pagListaMaterial.Name : oClsUsrPrdProducaoManual.LoadGridRequisicaoEstoque(grdListaMaterial,
                                                                          lCodigoOrdemProducao, 2)
                    Case pagEstimativaHoras.Name
                        oClsUsrPrdProducaoManual.LoadGridEstimativaHoras(grdEstimativaAnalitico, _
                                                                            grdEstimativaSintetico, _
                                                                            lCodigoOrdemProducao)

                        oClsUsrPrdProducaoManual.LoadGridEstimativaMaterial(grdEstimativaMaterial, _
                                                                       lCodigoOrdemProducao)

                        oClsUsrPrdProducaoManual.LoadGridEstimativaServicoTerceiros(grdEstimativaServicoTerceiros,
                                                                       lCodigoOrdemProducao)

                    Case pagChecklistCliente.Name : LoadGridChecklistCliente()

                End Select

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarCATIA()
        Try

            Dim oForm As New frmPrdImportarBOMCATIA
            oForm.CodigoOrdemProducao = lCodigoOrdemProducao
            oForm.CodigoRequisicao = lCodigoRequisicao
            oForm.txtDescricaoProduto.Text = txtDescricaoProduto.Text


            oForm.ShowDialog()


            oClsUsrPrdProducaoManual.LoadGridRequisicaoEstoque(grdListaMaterial,
                                                                          lCodigoOrdemProducao,
                                                                          2)

            oClsUsrPrdProducaoManual.LoadGridAcompanhamento(grdAcompanhamento, lCodigoOrdemProducao)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarOrdemProducao()

        Try



            'Instancia o formulário
            Dim oForm As New frmPrdOrdemProducaoImportarOrdemProducao
            oForm.CodigoOrdemProducao = lCodigoOrdemProducao
            oForm.ShowDialog()

            'Carrega os dados novamente
            Editar(lCodigoOrdemProducao)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir(ByVal sCodigo As String)
        Try
            Dim oForm As New frmPrdOrdemProducaoImprimir
            oForm.Codigo = sCodigo
            oForm.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
            LoadCombo(cboTipoOperacaoSubcontrato, "sp_select_combo_static_tipo_operacao_subcontrato")
            LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

            LoadCombo(cboTipoDispositivoRoteiro, "sp_select_combo_cadastro_basico_tipo_dispositivo " & goUsuario.iEmpresa)
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao")

            cboTipoVisao.Items.Clear()
            cboTipoVisao.Items.Add("AGRUPADO", 1)
            cboTipoVisao.Items.Add("DETALHADO", 2)
            cboTipoVisao.SelectedValue = 1


            LoadComboSimNao(cboRetrabalho)
            LoadComboSimNao(cboOperacaoExterna)
            LoadCombo(cboGrupoOperacao, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa)

            dtpDataEmissaoInicioFiltro.Value = "01/" & Month(Now) & "/" & Year(Now) : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, dtpDataEmissaoInicioFiltro.Value)) : dtpDataEmissaoTerminoFiltro.Checked = False

            dtpDataNecessidadeInicioFiltro.Value = "01/" & Month(Now) & "/" & Year(Now) : dtpDataNecessidadeInicioFiltro.Checked = False
            dtpDataNecessidadeTerminoFiltro.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, dtpDataNecessidadeInicioFiltro.Value)) : dtpDataNecessidadeTerminoFiltro.Checked = False

            dtpDataInicioInicioFiltro.Value = "01/" & Month(Now) & "/" & Year(Now) : dtpDataInicioInicioFiltro.Checked = False
            dtpDataInicioTerminoFiltro.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, dtpDataInicioInicioFiltro.Value)) : dtpDataInicioTerminoFiltro.Checked = False

            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdArquivo, iFormulario)
            ConfiguraGrid(grdRoteiro, iFormulario)
            ConfiguraGrid(grdAcompanhamento, iFormulario)
            ConfiguraGrid(grdQualidade, iFormulario)
            ConfiguraGrid(grdEstimativaAnalitico, iFormulario)
            ConfiguraGrid(grdEstimativaSintetico, iFormulario)
            ConfiguraGrid(grdEstimativaServicoTerceiros, iFormulario)
            ConfiguraGrid(grdEstimativaMaterial, iFormulario)

            ConfiguraGrid(grdCheckListCliente, iFormulario)
            ConfiguraGrid(grdCheckListClienteOrcamento, iFormulario)
            ConfiguraGrid(grdCheckListClienteOrcamentoItem, iFormulario)
            ConfiguraGrid(grdOrcamentoCheckListOrdemProducao, iFormulario)

            AddMenuGrid(grdOrcamentoCheckListOrdemProducao)

            LoadComboGrid(grdApontamento, "funcionario", "sp_select_apontamento_funcionario_centro_trabalho " & goUsuario.iEmpresa)
            LoadComboGrid(grdApontamento, "maquina", "sp_select_apontamento_maquina_centro_trabalho " & goUsuario.iEmpresa)
            LoadComboGrid(grdCompras, "conta_contabil", "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)


            txtOrdemProducaoFiltro.Focus()

            tabMain.TabPages.Remove(pagDados)

            btnAbrirOrcamento.Enabled = VerificaDireito(Formulario.ComercialOrcamento, gcSelect)
            btnAbrirOrcamento.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcSelect)


            'Verifica Direito por ABA

            'DADOS GERAIS
            iFormularioAbaDadosGerais = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - DADOS GERAIS'")
            If VerificaDireito(iFormularioAbaDadosGerais, gcSelect) = 0 Then tabDados.TabPages.Remove(pagDadosGerais)

            'ACOMPANHAMENTO/ ESTRUTURA DO PRODUTO
            iFormularioAbaAcompanhamento = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - ESTRUTURA DO PRODUTO'")
            If VerificaDireito(iFormularioAbaAcompanhamento, gcSelect) = 0 Then tabDados.TabPages.Remove(pagAcompanhamento)

            'PROCESSO PRODUTIVO
            iFormularioAbaProcessoProdutivo = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - PROCESSO PRODUTIVO'")
            If VerificaDireito(iFormularioAbaProcessoProdutivo, gcSelect) = 0 Then tabDados.TabPages.Remove(pagRoteiro)

            'LISTA DE MATERIAL
            iFormularioAbaListaMaterial = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - LISTA DE MATERIAL'")
            If VerificaDireito(iFormularioAbaListaMaterial, gcSelect) = 0 Then tabDados.TabPages.Remove(pagListaMaterial)

            'SERVIÇO EXTERNO
            iFormularioAbaServicoExterno = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - SERVIÇO EXTERNO'")
            If VerificaDireito(iFormularioAbaServicoExterno, gcSelect) = 0 Then tabDados.TabPages.Remove(pagServicoExterno)

            'COMPRAS
            iFormularioAbaCompras = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - COMPRAS'")
            If VerificaDireito(iFormularioAbaCompras, gcSelect) = 0 Then tabDados.TabPages.Remove(pagComprasAnalitico)

            ' PROJETO
            iFormularioAbaProjeto = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - PROJETO'")
            If VerificaDireito(iFormularioAbaProjeto, gcSelect) = 0 Then tabDados.TabPages.Remove(pagProjeto)

            'APONTAMENTOS
            iFormularioAbaApontamentos = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - APONTAMENTOS'")
            If VerificaDireito(iFormularioAbaApontamentos, gcSelect) = 0 Then tabDados.TabPages.Remove(pagApontamento)

            'QUALIDADE
            iFormularioAbaQualidade = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - QUALIDADE'")
            If VerificaDireito(iFormularioAbaQualidade, gcSelect) = 0 Then tabDados.TabPages.Remove(pagQualidade)

            'PLANEJAMENTO
            iFormularioAbaPlanejamento = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - PLANEJAMENTO'")
            If VerificaDireito(iFormularioAbaPlanejamento, gcSelect) = 0 Then tabDados.TabPages.Remove(pagPlanejamento)

            'ARQUIVO
            iFormularioAbaArquivo = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - ARQUIVO'")
            If VerificaDireito(iFormularioAbaArquivo, gcSelect) = 0 Then tabDados.TabPages.Remove(pagArquivo)

            'LOG
            iFormularioAbaLog = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - LOG'")
            If VerificaDireito(iFormularioAbaLog, gcSelect) = 0 Then tabDados.TabPages.Remove(pagLog)

            'ESTIMATIVA HORAS
            iFormularioAbaEstimativaHoras = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - ESTIMATIVA DE HORAS'")
            If VerificaDireito(iFormularioAbaEstimativaHoras, gcSelect) = 0 Then tabDados.TabPages.Remove(pagEstimativaHoras)

            ''BTN ENCERRAR P/ FATURAMENTO
            'iFormularioBtnFinalizarOP = LoadCodigo("sp_select_static_formulario_codigo_descricao 'PRODUÇÃO - ORDEM DE PRODUÇÃO - ENCERRAR P/ FATURAMENTO'")
            'If VerificaDireito(iFormularioBtnFinalizarOP, gcUpdate) = 0 Then btnConfirmarOP.Visible = False


            'Arruma a cor dos formatcondition da grdlistagem 
            For iFormat As Integer = 0 To grdListagem.RootTable.FormatConditions.Count - 1

                With grdListagem.RootTable.FormatConditions(iFormat)

                    Try
                        Dim oObject As Object = FindControl(grpLegenda, .Key)


                        If IsNothing(oObject) = False Then
                            .FormatStyle = New GridEXFormatStyle
                            .FormatStyle.ForeColor = oObject.backcolor
                        End If


                    Catch ex As Exception

                    End Try


                End With

            Next

            If Me.Tag.ToString.Contains("ID") = True Then
                Dim lCodigo As Long
                lCodigo = Convert.ToInt64(Me.Tag.ToString.Replace("ID:", ""))
                Editar(lCodigo)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            frmMain.errInfo.Clear()

            If ValidaCampo(cboTipoVisao, lblTipoVisao) = False Then Exit Sub

            oClsUsrPrdProducaoManual.LoadGrid(grdListagem,
                                              txtOrdemProducaoFiltro.Text,
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value),
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value),
                                              txtCodigoProdutoFiltro.Text.Trim,
                                              IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue),
                                              IIf(dtpDataNecessidadeInicioFiltro.Checked = False, "", dtpDataNecessidadeInicioFiltro.Value),
                                              IIf(dtpDataNecessidadeTerminoFiltro.Checked = False, "", dtpDataNecessidadeTerminoFiltro.Value),
                                              IIf(dtpDataInicioInicioFiltro.Checked = False, "", dtpDataInicioInicioFiltro.Value),
                                              IIf(dtpDataInicioTerminoFiltro.Checked = False, "", dtpDataInicioTerminoFiltro.Value),
                                              cboTipoVisao.SelectedValue,
                                              IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigo As Long,
                       Optional ByVal bProximaOP As Boolean = False)

        Try

            Cursor.Current = Cursors.WaitCursor

            Novo()
            Dim lCodigoProjeto As Long = -1

            oClsUsrPrdProducaoManual.LoadDadosOrdemProducao(lCodigo:=lCodigo,
                                                            txtDescricao:=txtDescricaoProduto,
                                                            txtOrdemProducao:=txtOrdemProducao,
                                                            dtpDataNecessidade:=dtpDataNecessidade,
                                                            txtCodigoProduto:=txtCodigoProduto,
                                                            txtQuantidadePlanejada:=txtQuantidadePlanejada,
                                                            txtObservacao:=txtObservacao,
                                                            cboCodigoCliente:=cboCliente,
                                                            txtNumeroPO:=txtNumeroPOCliente,
                                                            txtNumeroPOLinha:=txtNumeroPOLinha,
                                                            txtCodigoProdutoCliente:=txtCodigoProdutoCliente,
                                                            txtNumeroDesenho:=txtNumeroDesenho,
                                                            txtNumeroOrcamento:=txtNumeroOrcamento,
                                                            txtNumeroPedido:=txtNumeroPedidoVenda,
                                                            lCodigoProjeto:=lCodigoProjeto,
                                                            txtResponsavelEmpresa:=txtResponsavelEmpresa,
                                                            txtOrdemManufatura:=txtOrdemManufatura,
                                                            txtSubconjunto:=txtSubConjunto,
                                                            txtDetalhe:=txtDetalhe,
                                                            lCodigoRequisicao:=lCodigoRequisicao,
                                                            picImagem:=picImagem,
                                                            txtDataAbertura:=txtDataAbertura,
                                                            txtPorcentagemFaturamento:=txtPorcentagemFaturamento,
                                                            txtPrioridade:=txtPrioridade,
                                                            txtRevisao:=txtRevisao,
                                                            txtDataLiberacao:=txtDataLiberacao,
                                                            txtUsuarioLiberacao:=txtUsuarioLiberacao,
                                                            cboNCM:=cboNCM,
                                                            lblStatus:=lblStatus,
                                                            lblCentroTrabalhoAtual:=lblCentroTrabalhoAtual,
                                                            dtpDataEntrega:=dtpDataEntrega,
                                                            txtQuantidadeBOM:=txtQuantidadeBOM,
                                                            lblOperadorMaquinaAtual:=lblOperadorMaquinaAtual,
                                                            txtOrdemVenda:=txtOrdemVenda,
                                                            txtRequisicaoCompra:=txtRequisicaoCompra,
                                                            txtTipoNegocio:=txtTipoNegocio,
                                                            txtOrdemProducaoOrigem:=txtOrdemProducaoOrigem,
                                                            txtRegraImposto:=txtRegraImposto,
                                                            sExibirDataFaturar:=sExibirDataFaturar,
                                                            dtpDataFaturar:=dtpDataFaturar)
            lCodigoOrdemProducao = lCodigo
            sExibirDataFaturar = sExibirDataFaturar

            'Seta o código
            grdProcessoEtapa.Tag = lCodigoProjeto

            'Limpar os dados
            NovoRoteiro()

            Select Case sExibirDataFaturar

                Case "FINALIZADO"

                    dtpDataFaturar.Enabled = True
                    dtpDataFaturar.Visible = True
                    lblDataFaturar.Visible = True
                    btnSalvarDataFaturar.Visible = True
                    btnSalvarDataFaturar.Enabled = True

                Case "FATURAMENTO"

                    dtpDataFaturar.Enabled = False
                    dtpDataFaturar.Visible = True
                    lblDataFaturar.Visible = True
                    btnSalvarDataFaturar.Visible = True
                    btnSalvarDataFaturar.Enabled = False

                Case "ANDAMENTO"

                    dtpDataFaturar.Visible = False
                    lblDataFaturar.Visible = False
                    btnSalvarDataFaturar.Visible = False
                    btnSalvarDataFaturar.Enabled = False

            End Select

            'Trava txtPorcentagemFaturamento se a OP NÃO seja OP PAI
            Dim CodigoOPTOPO = LoadCodigo("sp_load_producao_ordem_producao_codigo 1,0, " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)

            If CodigoOPTOPO <> lCodigo Then
                txtPorcentagemFaturamento.ReadOnly = True
                txtPorcentagemFaturamento.BackColor = Color.WhiteSmoke
            Else
                txtPorcentagemFaturamento.ReadOnly = False
                txtPorcentagemFaturamento.BackColor = Color.White
            End If

            'Trava Campos se tiver com status = 7(ENTREGUE) | 3(CONCLUIDO)
            Dim iStatus = LoadCodigo("sp_load_producao_ordem_producao_status " & lCodigoOrdemProducao & ", " & goUsuario.iEmpresa)

            If iStatus = 7 Or iStatus = 3 Then
                Call LiberarEdicao(False)
            Else
                Call LiberarEdicao(True)
            End If

            'Carrega a aba de acordo com o que estiver selecionado
            Call LoadDadosAba()

            If tabMain.TabPages(0).Name = "pagListagem" Then
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)
            End If

            'Seta o cursor
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LiberarEdicao(bLiberar As Boolean)
        Try

            'Preenche a variavel para validação nas açoes dos Girds
            bLiberarEdicao = bLiberar

            grpDadosGerais.Enabled = bLiberar
            btnImportarOrdemProducao.Enabled = bLiberar
            btnInserirOrdemProducao.Enabled = bLiberar
            btnImportarBom.Enabled = bLiberar
            btnNovoRoteiro.Enabled = bLiberar
            btnInserirRoteiro.Enabled = bLiberar
            btnExcluirRoteiro.Enabled = bLiberar
            btnCopiarRoteiro.Enabled = bLiberar
            btnCopiarRoteiroOrdemProducao.Enabled = bLiberar
            btnEstimativaHoras.Enabled = bLiberar
            btnInserirListaMaterial.Enabled = bLiberar
            btnExcluirListaMaterial.Enabled = bLiberar
            btnNovoServicoExterno.Enabled = bLiberar
            btnSalvarServicoExterno.Enabled = bLiberar
            btnExcluirServicoExterno.Enabled = bLiberar
            btnGerarRequisicaoCompra.Enabled = bLiberar
            btnInserirArquivo.Enabled = bLiberar
            btnExcluirArquivo.Enabled = bLiberar

            grpPlanejamento.Enabled = bLiberar

            btnSalvarOrdemProducao.Enabled = bLiberar


        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub HoverOnItemMenu(sender As Object, e As EventArgs)
        Try

            Cursor.Current = Cursors.Hand

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LeaveOnItemMenu(sender As Object, e As EventArgs)
        Try

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Novo()

        Try

            frmMain.errInfo.Clear()


            LimparCamposGroupBox(grpArquivo)
            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpRoteiro)
            LimparCamposGroupBox(grpAcompanhamento)
            LimparCamposGroupBox(grpServicoExterno)

            picImagem.Image = Nothing
            txtImagem.Text = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            btnInserirRoteiro.Tag = ""
            grdRoteiro.DataSource = Nothing

            'grdAcompanhamento.DataSource = Nothing

            txtTempoSetup.Text = "000000"
            txtTempoMaquina.Text = "000000"
            txtObservacao.Text = ""
            txtOrdem.Value = 10


            lCodigoOrdemProducao = -1

            RedimensionarCampos(True)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Excluir(ByVal oGrid As GridEX)
        Try

            Dim iApontamento As Integer = 0
            Dim iQuantidadeOPFilhas As Integer = 0

            iApontamento = LoadCodigo("sp_validade_producao_ordem_producao_apontamento " & oGrid.GetValue("codigo") & ", " & goUsuario.iEmpresa)
            If iApontamento > 0 Then
                MsgBox("Não é possível excluir pois já foi feito algum apontamento para essa Ordem de Produção.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            iQuantidadeOPFilhas = LoadCodigo("sp_validade_producao_ordem_producao_filhos " & oGrid.GetValue("codigo") & ", " & goUsuario.iEmpresa)
            If iQuantidadeOPFilhas > 0 Then
                MsgBox("Não é possível excluir pois existe filhos para essa OP, para excluir é necessário excluir os filhos primeiro.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If oGrid.GetValue("status") = 1 Then

                If MsgBox("Deseja excluir permanentemente essa ordem de produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then Exit Sub

                Cursor.Current = Cursors.WaitCursor

                oClsUsrPrdProducaoManual.DeleteOrdemProducao(oGrid.GetValue("codigo"))

                LoadGrid()

                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                Cursor.Current = Cursors.Default

            Else
                MsgBox("Só é possível excluir Ordem de Produção que esteja EM PRODUÇÃO.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar(ByVal oGrid As GridEX,
                         ByVal lCodigoOrdemProducao As Long)

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(20004, gcSelect) = True Then

                'Váriaveis Locais
                Dim oForm As New frmPrdOrdemProducaoCancelar

                'Seta Parametros
                oForm.Grid = oGrid
                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega a Grid
                If oGrid.Name = "grdListagem" Then
                    Call LoadGrid()
                Else
                    oClsUsrPrdProducaoManual.LoadGridAcompanhamento(grdAcompanhamento,
                                                                    lCodigoOrdemProducao)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao("Sem Permissão: PRODUÇÃO - ORDEM DE PRODUÇÃO - CANCELAR ORDEM DE PRODUÇÃO", Color.Red)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarPlanilha()

        Try

            'Váriaveis Locais
            Dim oApplicationClass As New Excel.ApplicationClass
            Dim oArquivoExcel As New OpenFileDialog
            Dim sArquivo As String
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"
            oArquivoExcel.InitialDirectory = "c:\\"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog <> DialogResult.OK Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            sArquivo = oArquivoExcel.FileName

            ExecuteQuery("TRUNCATE TABLE tb_temp_ordem_producao")
            ExecuteQuery("TRUNCATE TABLE tb_temp_ordem_producao_operacao")

            oClsUsrPrdProducaoManual.ImportarExcelProducao(sArquivo)
            oClsUsrPrdProducaoManual.ImportarExcelOperacao(sArquivo)

            oClsUsrPrdProducaoManual.FinalizarImportacao(lCodigoOrdemProducao)

            LoadGrid()

            oApplicationClass.Workbooks.Close()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarApontamento()

        Try

            Dim iApontamento As Integer = 0

            iApontamento = LoadCodigo("sp_validade_producao_ordem_producao_apontamento " & lCodigoOrdemProducao & ", " & goUsuario.iEmpresa)

            If iApontamento > 0 Then
                MsgBox("Não é possível salvar as operações pois já foi feito algum apontamento para essa Ordem de Produção.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            oClsUsrPrdProducaoManual.InsertOrdemProducaoApontamento(lCodigoOrdemProducao)

            frmMain.Informacao(Mensagem.RegistroSalvo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarRequisicaoCompra()

        Try

            Cursor.Current = Cursors.WaitCursor

            If oClsUsrPrdProducaoManual.ValidaRequisicaoEstoque(lCodigoOrdemProducao) = False Then
                MsgBox("Não existe requisição de estoque para essa ordem de produção.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If


            oClsUsrPrdProducaoManual.InsertRequisicaoCompra(grdCompras)

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoOrdemProducao()

        Try

            'Váriaveis Locais
            Dim oForm As New frmPrdOrdemProducaoHistorico

            'Seta Parametros
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Reativar()

        Try

            If grdListagem.GetValue("status") = 4 Then 'Cancelada

                'Váriaveis Locais
                Dim oForm As New frmPrdOrdemProducaoReativar

                'Seta Parametros
                oForm.Grid = grdListagem
                oForm.ShowDialog()

                'Carrega a Grid
                LoadGrid()



            Else

                frmMain.Informacao("Não é possível cancelar pois a OP não está cancelada!", Color.Red)

            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FinalizarApontamento()
        Try

            oClsUsrPrdProducaoManual.FinalizarApontamento(grdApontamento.CurrentRow.Cells("codigo_ordem_producao").Value,
                                                        grdApontamento.CurrentRow.Cells("sequencia").Value,
                                                        IIf(IsDBNull(grdApontamento.CurrentRow.Cells("codigo_apontamento_funcionario").Value), Nothing, grdApontamento.CurrentRow.Cells("codigo_apontamento_funcionario").Value),
                                                        IIf(IsDBNull(grdApontamento.CurrentRow.Cells("codigo_funcionario").Value), Nothing, grdApontamento.CurrentRow.Cells("codigo_funcionario").Value),
                                                        0,
                                                        0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirApontamento()
        Try

            If VerificaDireito(iFormularioAbaApontamentos, gcDelete) = False Then
                frmMain.Informacao("Você não possui permissão para excluir.", Color.Red)
                Exit Sub
            End If

            If IsDBNull(grdApontamento.GetValue("codigo_apontamento_funcionario")) Then

                MsgBox("Não é possível excluir o apontamento da Operação: " & grdApontamento.CurrentRow.Cells("operacao").Value & " pois não foi realizado nenhum apontamento!", MsgBoxStyle.Exclamation, "Erro!")
                Exit Sub

            End If



            If MsgBox("Deseja excluir permanentemente este Apontamento da Operação: " & grdApontamento.CurrentRow.Cells("operacao").Value, MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Dim iApontamento As Integer = 0

                'iApontamento = LoadCodigo("sp_validade_producao_ordem_producao_apontamento_editar " & grdApontamento.CurrentRow.Cells("codigo_ordem_producao").Value & ", " &
                '                                                                                      grdApontamento.CurrentRow.Cells("sequencia").Value &
                '                                                                                      ", " & goUsuario.iEmpresa)

                'If iApontamento > 0 Then
                '    MsgBox("Não é possível excluir a operação ordem: " + (grdApontamento.CurrentRow.Cells("ordem").Value).ToString() + " pois já foi realizado algum apontamento.", MsgBoxStyle.Exclamation, "Validação")
                '    Exit Sub
                'End If



                oClsUsrPrdProducaoManual.ExcluirApontamento(grdApontamento.CurrentRow.Cells("codigo_ordem_producao").Value,
                                                            grdApontamento.CurrentRow.Cells("sequencia").Value,
                                                            grdApontamento.CurrentRow.Cells("codigo_apontamento_funcionario").Value)


                oClsUsrPrdProducaoManual.LoadGridApontamento(grdApontamento,
                                                             lCodigoOrdemProducao)

                frmMain.Informacao(Mensagem.RegistroExcluido)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridApontamento()
        Try

            oClsUsrPrdProducaoManual.LoadGridApontamento(grdApontamento,
                                                         lCodigoOrdemProducao)



        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub LoadGridProcessoEtapa()
        Try

            oClsUsrPrjProcesso.LoadGridEtapa(grdProcessoEtapa,
                                            lCodigoOrdemProducao)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LiberarProducao(sCodigo As String)

        Try
            Dim oForm As New frmPrdOrdemProducaoLiberarProducao
            oForm.Codigo = sCodigo
            oForm.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FinalizacaoOP(sCodigo As String)

        Try
            Dim oForm As New frmPrdOrdemProducaoFinalizarOP
            oForm.Codigo = sCodigo
            oForm.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ROTEIRO :::"

    Private Sub CalcularHora(ByRef txtOrigem As Object,
                             ByVal txtDestino As Object)

        Try

            If txtOrigem.GetType.Name = "NumericEditBox" Then
                'Se a origem é NumericEditBox, quer dizer que é o controle numérico.. então deve converter para HH:MM:SS

                Dim dHorasDecimais As Double = txtOrigem.text
                Dim iHorasInteiras As Integer = Math.Floor(dHorasDecimais)
                Dim iMinutos As Integer = Math.Floor((dHorasDecimais - iHorasInteiras) * 60)
                Dim iSegundos As Integer = Math.Floor(((dHorasDecimais - iHorasInteiras) * 60 - iMinutos) * 60)

                Dim sTempoFormatado As String
                sTempoFormatado = IIf(Len(CStr(iHorasInteiras)) = 1, "0" + CStr(iHorasInteiras), CStr(iHorasInteiras)) + ":"
                sTempoFormatado += IIf(Len(CStr(iMinutos)) = 1, "0" + CStr(iMinutos), CStr(iMinutos)) + ":"
                sTempoFormatado += IIf(Len(CStr(iSegundos)) = 1, "0" + CStr(iSegundos), CStr(iSegundos))

                txtDestino.text = sTempoFormatado

            ElseIf txtOrigem.GetType.Name = "MaskedEditBox" Then


                Dim sHora1() As String = txtOrigem.text.ToString.Split(":")
                If sHora1(0) = "" Then sHora1(0) = 0
                If sHora1(1) = "" Then sHora1(1) = 0
                If sHora1(2) = "" Then sHora1(2) = 0

                Dim dHoraDecimal As Double = sHora1(0) + (sHora1(1) / 60) + (sHora1(2) / 3600)
                txtDestino.value = dHoraDecimal

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadItemRoteiro(ByVal lCodigoOrdemProducao As Long,
                                ByVal iSequencia As Integer,
                                ByVal bRetrabalho As Boolean)

        Try

            Cursor.Current = Cursors.WaitCursor
            Dim sOrdem As String = ""
            Dim iOperacaoExterna As Integer = 0
            Dim iCodigoCentroTrabalho As Integer = 0
            Dim iCodigoOperacao As Integer = 0
            Dim sTempoSetup As String = ""
            Dim sTempoMaoObra As String = ""
            Dim sTempoMaquina As String = ""
            Dim iAponta As Integer = 0
            Dim iControlaQuallidade As Integer = 0
            Dim sObservacao As String = ""
            Dim sNivel As String = ""
            Dim sProdutoPai As String = ""
            Dim iCodigoMaquina As Integer = 0


            If bRetrabalho = False Then

                Dim iApontamento As Integer = 0

                iApontamento = LoadCodigo("sp_validade_producao_ordem_producao_apontamento_editar " & lCodigoOrdemProducao & ", " & iSequencia & ", " & goUsuario.iEmpresa)

                If iApontamento > 0 Then
                    MsgBox("Não é possível editar a operação pois já foi realizado algum apontamento.", MsgBoxStyle.Exclamation, "Validação")
                    Exit Sub
                End If

            End If


            oClsUsrPrdProducaoManual.LoadDadosRoteiro(lCodigoOrdemProducao,
                                                                iSequencia,
                                                                txtOrdem,
                                                                cboOperacaoExterna,
                                                                cboCentroTrabalho,
                                                                cboOperacao,
                                                                txtTempoSetup,
                                                                txtTempoMaquina,
                                                                cboRetrabalho,
                                                                txtObservacaoRoteiro,
                                                                btnInserirRoteiro,
                                                                cboMaquina,
                                                                cboTipoDispositivoRoteiro,
                                                                txtNumeroProcessoRoteiro,
                                                                txtRevisaoRoteiro,
                                                                txtServicoGRV, _
                                                                cboOperador)

            CalcularHora(txtTempoMaquina, txtTempoMaquinaDecimal)
            CalcularHora(txtTempoSetup, txtTempoSetupDecimal)

            'If cboOperacaoExterna.SelectedValue = True Then
            '    lblTempoMaoObra.Text = "Lead Time:"
            'Else
            '    lblTempoMaoObra.Text = "Tempo M.O.:"
            'End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRoteiro() As Boolean

        Try

            If ValidaCampo(txtOrdem, lblOrdem, True) = False Then Return False
            If ValidaCampo(cboCentroTrabalho, lblCentroTrabalho) = False Then Return False
            If ValidaCampo(cboOperacao, lblOperacao) = False Then Return False
            If ValidaCampo(txtTempoSetup, lblTempoSetup, TipoCampo.hora) = False Then Return False
            If ValidaCampo(txtTempoMaquina, lblTempoMaquina, TipoCampo.hora) = False Then Return False
            If ValidaCampo(cboRetrabalho, lblRetrabalho) = False Then Return False
            If ValidaCampo(txtTempoMaquinaDecimal, lblTempoMaquinaDecimal, True) = False Then Return False


            'CNC tem que bloquear 
            If cboCentroTrabalho.SelectedValue = 7 Or _
                cboCentroTrabalho.SelectedValue = 8 Or _
                cboCentroTrabalho.SelectedValue = 9 Then


                If cboMaquina.SelectedIndex = -1 Then

                    frmMain.errInfo.SetError(lblMaquina, "Para essas operações, é obrigatório escolher a Máquina!")
                    Return False
                End If


            End If


            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarRoteiro()

        Try

            Cursor.Current = Cursors.WaitCursor

            If Not IsNumeric(btnInserirRoteiro.Tag) Then
                oClsUsrPrdProducaoManual.InsertRoteiro(lCodigoOrdemProducao,
                                                   txtOrdem.Value,
                                                   cboCentroTrabalho.SelectedValue,
                                                   cboOperacao.SelectedValue,
                                                   ((txtTempoSetup.Text.Split(":")(0) * 60) + txtTempoSetup.Text.Split(":")(1) + (txtTempoSetup.Text.Split(":")(2) / 60)),
                                                   ((txtTempoMaquina.Text.Split(":")(0) * 60) + txtTempoMaquina.Text.Split(":")(1) + (txtTempoMaquina.Text.Split(":")(2) / 60)),
                                                   True,
                                                   False,
                                                   cboRetrabalho.SelectedValue,
                                                   txtObservacaoRoteiro.Text.Trim,
                                                   cboOperacaoExterna.SelectedValue,
                                                   IIf(cboMaquina.SelectedIndex = -1, -1, cboMaquina.SelectedValue),
                                                   1,
                                                   -1,
                                                   "",
                                                   0,
                                                   -1,
                                                   -1,
                                                   IIf(cboTipoDispositivoRoteiro.SelectedIndex = -1, -1, cboTipoDispositivoRoteiro.SelectedValue),
                                                   txtNumeroProcessoRoteiro.Text.Trim,
                                                   txtRevisaoRoteiro.Text.Trim,
                                                   txtServicoGRV.Text.Trim, _
                                                   IIf(cboOperador.SelectedIndex = -1, -1, cboOperador.SelectedValue))
            Else
                oClsUsrPrdProducaoManual.UpdateRoteiro(lCodigoOrdemProducao,
                                                   btnInserirRoteiro.Tag,
                                                   txtOrdem.Value,
                                                   cboCentroTrabalho.SelectedValue,
                                                   cboOperacao.SelectedValue,
                                                   ((txtTempoSetup.Text.Split(":")(0) * 60) + txtTempoSetup.Text.Split(":")(1) + (txtTempoSetup.Text.Split(":")(2) / 60)),
                                                   ((txtTempoMaquina.Text.Split(":")(0) * 60) + txtTempoMaquina.Text.Split(":")(1) + (txtTempoMaquina.Text.Split(":")(2) / 60)),
                                                   True,
                                                   False,
                                                   cboRetrabalho.SelectedValue,
                                                   txtObservacaoRoteiro.Text.Trim,
                                                   cboOperacaoExterna.SelectedValue,
                                                   IIf(cboMaquina.SelectedIndex = -1, -1, cboMaquina.SelectedValue),
                                                   1,
                                                   -1,
                                                   "",
                                                   0,
                                                   -1,
                                                   -1,
                                                   IIf(cboTipoDispositivoRoteiro.SelectedIndex = -1, -1, cboTipoDispositivoRoteiro.SelectedValue),
                                                   txtNumeroProcessoRoteiro.Text.Trim,
                                                   txtRevisaoRoteiro.Text.Trim,
                                                   txtServicoGRV.Text.Trim, _
                                                   IIf(cboOperador.SelectedIndex = -1, -1, cboOperador.SelectedValue))
            End If


            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoRoteiro()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpRoteiro)
            txtTempoSetup.Text = "0000000"

            txtTempoMaquina.Text = "0000000"

            cboRetrabalho.SelectedValue = False
            btnInserirRoteiro.Tag = Nothing
            cboOperacaoExterna.SelectedValue = False
            txtOrdem.Value = LoadCodigo("sp_load_cadastro_basico_produto_roteiro_ordem " & lCodigoOrdemProducao & "," & goUsuario.iEmpresa)

            txtOrdem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRoteiro()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRoteiro) = True Then


                'Exclui Registro
                For Each oRow As GridEXRow In gSelecaoRow

                    Dim iApontamento As Integer = 0

                    iApontamento = LoadCodigo("sp_validade_producao_ordem_producao_apontamento_editar " & lCodigoOrdemProducao & ", " & oRow.Cells("sequencia").Value & ", " & goUsuario.iEmpresa)

                    If iApontamento > 0 Then
                        MsgBox("Não é possível excluir a operação ordem: " + (oRow.Cells("ordem").Value).ToString() + " pois já foi realizado algum apontamento.", MsgBoxStyle.Exclamation, "Validação")
                        Exit Sub
                    End If

                Next

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrPrdProducaoManual.DeleteRoteiro(lCodigoOrdemProducao)

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

    Private Sub LoadGridRoteiro()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridRoteiro(grdRoteiro,
                                                           lCodigoOrdemProducao)
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: EDIÇÃO :::"

    Private Sub RedimensionarCampos(ByVal bVisible As Boolean)

        Try

            For Each oControl As Object In grpRoteiro.Controls

                If oControl.GetType.Name <> "Button" Then
                    oControl.Visible = bVisible
                ElseIf oControl.Tag <> "N" Then
                    oControl.Visible = bVisible
                End If

            Next

            grdRoteiro.Visible = True

            If bVisible = False Then
                grdRoteiro.Location = New Point(9, 17)
                grdRoteiro.Size = New Size(grpRoteiro.Size.Width - 15, grpRoteiro.Size.Height - 26)
            Else
                Dim y As Integer = txtObservacaoRoteiro.Location.Y + txtObservacaoRoteiro.Size.Height + 6
                grdRoteiro.Location = New Point(9, y)
                grdRoteiro.Size = New Size(grpRoteiro.Size.Width - 15, grpRoteiro.Size.Height - grdRoteiro.Location.Y - 9)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            frmMain.errInfo.Clear()


            If ValidaCampo(cboCliente, lblCliente) = False Then
                tabDados.SelectedTab = pagDadosGerais

                Exit Function
            End If
            'If ValidaCampo(cboNCM, lblNCM) = False Then

            '    tabDados.SelectedTab = pagDadosGerais

            '    Exit Function
            'End If
            If ValidaCampo(txtNumeroDesenho, lblNumeroDesenho, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosGerais

                Exit Function
            End If
            If ValidaCampo(txtNumeroPOCliente, lblNumeroPOCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosGerais
                Exit Function
            End If

            If ValidaCampo(txtQuantidadePlanejada, lblQuantidadePlanejada, True) = False Then
                tabDados.SelectedTab = pagDadosGerais
                Return False

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarOrdemProducao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.UpdateOrdemProducao(lCodigoOrdemProducao,
                                                         dtpDataNecessidade.Value,
                                                         txtQuantidadePlanejada.Value,
                                                         txtObservacao.Text,
                                                         IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue),
                                                         txtNumeroPOCliente.Text.Trim,
                                                         txtNumeroPOLinha.Text.Trim,
                                                         txtCodigoProdutoCliente.Text.Trim,
                                                         txtDescricaoProduto.Text,
                                                         txtNumeroDesenho.Text,
                                                         txtResponsavelEmpresa.Text,
                                                         txtOrdemManufatura.Text,
                                                         txtSubConjunto.Text,
                                                         txtDetalhe.Text,
                                                         picImagem,
                                                         txtPorcentagemFaturamento.Value,
                                                         txtPrioridade.Value,
                                                         txtRevisao.Text.Trim,
                                                         IIf(cboNCM.SelectedIndex = -1, -1, cboNCM.SelectedValue),
                                                         txtOrdemVenda.Text,
                                                         txtRequisicaoCompra.Text,
                                                         dtpDataEntrega.Value,
                                                         dtpDataFaturar.Value)

            frmMain.Informacao("Ordem de produção atualizada com sucesso!", Color.Blue)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDataFaturar()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.UpdateDataFaturar(lCodigoOrdemProducao,
                                                       IIf(sExibirDataFaturar = "FINALIZADO", dtpDataFaturar.Value, "")
                                                       )

            frmMain.Informacao("Data a faturar atualizada com sucesso!", Color.Blue)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NotificarFaturamentoPendente()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.EnviarEmailFaturamentoPendente(lCodigoOrdemProducao)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Function ValidacaoArquivo() As Boolean

        Try

            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_ordem_producao_manual " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            oClsUsrPrdProducaoManual.InsertArquivo(lCodigoOrdemProducao,
                                                   txtDescricaoArquivo.Text.Trim,
                                                   sFile)

            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridArquivo(grdArquivo,
                                                     lCodigoOrdemProducao)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = Nothing

            txtDescricaoArquivo.Focus()

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

                    oClsUsrPrdProducaoManual.DeleteArquivo(lCodigoOrdemProducao)

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

    Private Sub VisualizarArquivo()

        Try

            Process.Start(grdArquivo.GetValue("arquivo"))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

#Region "::: REQUISIÇÃO DE ESTOQUE :::"

    Private Sub DeleteRequisicaoItem(ByVal oGrid As GridEX)

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(oGrid) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrPrdProducaoManual.DeleteRequisicaoItem()

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

    Private Sub EditarEstruturaProduto()
        Try

            With grdAcompanhamento
                Dim oForm As New frmPrdOrdemProducaoProdutoFabricado

                'Dados da capa
                oForm.txtOrdemProducao.Text = txtOrdemProducao.Text
                oForm.txtProduto.Text = txtDescricaoProduto.Text
                oForm.txtQuantidadePlanejada.Text = txtQuantidadePlanejada.Text

                oForm.Novo = False

                oForm.CodigoRequsicao = lCodigoRequisicao
                oForm.btnSalvarRequisicao.Tag = .GetValue("codigo_requisicao_item")

                oForm.cboCodigoProduto.Tag = .GetValue("codigo_item")
                oForm.txtCodigoProdutoRequisicaoOrdemProducao.Text = .GetValue("codigo_produto")
                oForm.txtDescricaoRequisicaoOrdemProducao.Text = .GetValue("descricao")
                oForm.txtQuantidadeRequisicaoOrdemProducao.Text = .GetValue("quantidade")
                oForm.txtNumeroDesenhoRequisicaoOrdemProducao.Text = .GetValue("numero_desenho")
                oForm.txtSubconjuntoRequisicaoOrdemProducao.Text = .GetValue("subconjunto")
                oForm.txtDetalheRequisicaoOrdemProducao.Text = .GetValue("detalhe")
                oForm.txtCodigoProdutoClienteRequisicaoOrdemProducao.Text = .GetValue("codigo_produto_cliente")
                oForm.txtObservacao.Text = .GetValue("observacao")



                oForm.ShowDialog()

                'Carrega os dados da requisição
                oClsUsrPrdProducaoManual.LoadGridAcompanhamento(grdAcompanhamento,
                                                                lCodigoOrdemProducao)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarGrupoItemListaMaterial()
        Try

            If bLiberarEdicao = False Then
                frmMain.Informacao("Não é possível Editar devido ao status da OP.", Color.Red)
                Exit Sub
            End If

            With grdListaMaterial

                If .GetValue("codigo_grupo_item") <> -1 Then
                    frmMain.Informacao("É possível editar apenas itens que não possuem grupos de itens selecionados.", Color.Red)
                    Exit Sub
                End If

                Dim oForm As New frmPrdOrdemProducaoListaMaterial

                'Dados da capa
                oForm.CodigoRequsicao = lCodigoRequisicao
                oForm.CodigoRequsicaoItem = .GetValue("codigo_requisicao_item")
                oForm.CodigoOrdemProducao = lCodigoOrdemProducao
                oForm.txtOrdemProducao.Text = txtOrdemProducao.Text
                oForm.txtProduto.Text = txtCodigoProduto.Text
                oForm.txtQuantidadePlanejada.Text = txtQuantidadePlanejada.Text
                oForm.txtNumeroDesenho.Text = .GetValue("numero_desenho")

                oForm.ShowDialog()


                'Carrega os dados da requisição
                oClsUsrPrdProducaoManual.LoadGridRequisicaoEstoque(grdListaMaterial,
                                                                   lCodigoOrdemProducao,
                                                                   2)


            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "::: SERVIÇO EXTERNO :::"

    Private Sub LoadGridServicoExterno()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridServicoExterno(grdServicoExterno,
                                                            lCodigoOrdemProducao)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadItemServicoExterno(ByVal lCodigoOrdemProducao As Long,
                                       ByVal iSequencia As Integer)

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadDadosServicoExterno(lCodigoOrdemProducao,
                                                                       iSequencia,
                                                                       cboGrupoOperacao,
                                                                       cboOperacaoServicoExterno,
                                                                       cboFornecedorServicoExterno,
                                                                       txtLeadTimeServicoExterno,
                                                                       txtQuantidadeServicoExterno,
                                                                       txtObservacaoServicoTerceiro,
                                                                       btnSalvarServicoExterno,
                                                                       txtValorUnitarioServicoExterno,
                                                                        dtpPrazoEntregaServicoExterno,
                                                                        cboTipoOperacaoSubcontrato,
                                                                        cboMaterialEnvioSubcontrato)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoServicoExterno() As Boolean

        Try

            'If ValidaCampo(cboGrupoOperacao, lblGrupoOperacao) = False Then Return False
            If ValidaCampo(cboOperacaoServicoExterno, lblOperacaoServicoExterno) = False Then Return False
            If ValidaCampo(txtLeadTimeServicoExterno, lblLeadTimeServicoExterno, TipoCampo.numero) = False Then Return False
            If ValidaCampo(txtQuantidadeServicoExterno, lblQuantidadeServicoExterno, True) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub NovoServicoExterno()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpServicoExterno)
            txtQuantidadeServicoExterno.Value = 1
            btnSalvarServicoExterno.Tag = Nothing


            cboGrupoOperacao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarServicoExterno()
        Try

            Try

                Cursor.Current = Cursors.WaitCursor

                If btnSalvarServicoExterno.Tag Is Nothing Then
                    oClsUsrPrdProducaoManual.InsertRoteiro(lCodigoOrdemProducao,
                                                       999,
                                                       -1,
                                                       cboOperacaoServicoExterno.SelectedValue,
                                                       0,
                                                       txtLeadTimeServicoExterno.Value,
                                                       True,
                                                       False,
                                                       cboRetrabalho.SelectedValue,
                                                       txtObservacaoServicoTerceiro.Text.Trim,
                                                       True,
                                                       -1,
                                                       txtQuantidadeServicoExterno.Value,
                                                       IIf(cboFornecedorServicoExterno.SelectedIndex = -1, -1, cboFornecedorServicoExterno.SelectedValue),
                                                       IIf(dtpPrazoEntregaServicoExterno.Checked = True, dtpPrazoEntregaServicoExterno.Value, ""),
                                                       txtValorUnitarioServicoExterno.Value,
                                                       IIf(cboTipoOperacaoSubcontrato.SelectedIndex = -1, -1, cboTipoOperacaoSubcontrato.SelectedValue),
                                                       IIf(cboMaterialEnvioSubcontrato.SelectedIndex = -1, -1, cboMaterialEnvioSubcontrato.SelectedValue),
                                                       IIf(cboTipoDispositivoRoteiro.SelectedIndex = -1, -1, cboTipoDispositivoRoteiro.SelectedValue),
                                                       txtNumeroProcessoRoteiro.Text.Trim,
                                                       txtRevisaoRoteiro.Text.Trim,
                                                       txtServicoGRV.Text.Trim, _
                                                       -1)
                Else
                    oClsUsrPrdProducaoManual.UpdateRoteiro(lCodigoOrdemProducao,
                                                       btnSalvarServicoExterno.Tag,
                                                       999,
                                                       -1,
                                                       cboOperacaoServicoExterno.SelectedValue,
                                                       0,
                                                       txtLeadTimeServicoExterno.Value,
                                                       True,
                                                       False,
                                                       cboRetrabalho.SelectedValue,
                                                       txtObservacaoServicoTerceiro.Text.Trim,
                                                       True,
                                                       cboMaquina.SelectedValue,
                                                       txtQuantidadeServicoExterno.Value,
                                                       IIf(cboFornecedorServicoExterno.SelectedIndex = -1, -1, cboFornecedorServicoExterno.SelectedValue),
                                                       IIf(dtpPrazoEntregaServicoExterno.Checked = True, dtpPrazoEntregaServicoExterno.Value, ""),
                                                       txtValorUnitarioServicoExterno.Value,
                                                       IIf(cboTipoOperacaoSubcontrato.SelectedIndex = -1, -1, cboTipoOperacaoSubcontrato.SelectedValue),
                                                       IIf(cboMaterialEnvioSubcontrato.SelectedIndex = -1, -1, cboMaterialEnvioSubcontrato.SelectedValue),
                                                       IIf(cboTipoDispositivoRoteiro.SelectedIndex = -1, -1, cboTipoDispositivoRoteiro.SelectedValue),
                                                       txtNumeroProcessoRoteiro.Text.Trim,
                                                       txtRevisaoRoteiro.Text.Trim,
                                                       txtServicoGRV.Text.Trim, _
                                                       -1)
                End If

                LimparCamposGroupBox(grpServicoExterno)
                btnSalvarServicoExterno.Tag = Nothing

                frmMain.Informacao(Mensagem.RegistroInserido)

                Cursor.Current = Cursors.Default

            Catch ex As Exception
                Throw ex
            End Try


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DeleteServicoExterno()
        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdServicoExterno) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrPrdProducaoManual.DeleteRoteiro(lCodigoOrdemProducao)

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


#End Region

#Region "::: CHECKLIST CLIENTE :::"

    Private Sub LoadGridChecklistCliente()
        Try

            oClsUsrPrdProducaoManual.LoadGridChecklistCliente(lCodigoOrdemProducao,
                                                              grdCheckListCliente,
                                                              grdCheckListClienteOrcamento,
                                                              grdCheckListClienteOrcamentoItem,
                                                              grdOrcamentoCheckListOrdemProducao)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region




End Class
