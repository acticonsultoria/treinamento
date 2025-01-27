Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadMascaraOrcamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadMascaraOrcamento As New clsUsrCadMascaraOrcamento
    Private iFormulario As Integer
    Private iCodigoMascara As Integer = -1
    Private iCodigoServicoTerceiros As Integer = -1
    Private iSequencia As Integer = -1
    Private oCurrentRow As GridEXRow

#End Region

#Region "::: CONTROLES :::"

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
                Dim oUICommandCopiar As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandAdicionarLinha As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandExcluirLinha As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandConfigurarGrid As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandExportarExcel As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandAgruparListagem As New Janus.Windows.UI.CommandBars.UICommand
                oUICommandCopiar.Text = "Copiar Conteúdo da Célula" : oUICommandCopiar.Key = "copiar"
                oUICommandAdicionarLinha.Text = "Adicionar Linha" : oUICommandAdicionarLinha.Key = "adicionar_linha"
                oUICommandExcluirLinha.Text = "Excluir Linha" : oUICommandExcluirLinha.Key = "excluir_linha"
                oUICommandConfigurarGrid.Text = "Configurar Listagem" : oUICommandConfigurarGrid.Key = "configurar_grid"
                oUICommandExportarExcel.Text = "Exportar para Excel" : oUICommandExportarExcel.Key = "exportar_excel"
                oUICommandAgruparListagem.Text = "Agrupar Listagem" : oUICommandAgruparListagem.Key = "agrupar_grid"

                oUICommandManager.Commands.Add(oUICommandCopiar)
                oUICommandManager.Commands.Add(oUICommandAdicionarLinha)
                oUICommandManager.Commands.Add(oUICommandExcluirLinha)
                oUICommandManager.Commands.Add(oUICommandConfigurarGrid)
                oUICommandManager.Commands.Add(oUICommandExportarExcel)
                oUICommandManager.Commands.Add(oUICommandAgruparListagem)
                oUIContextMenu.Commands.Add(oUICommandCopiar)

                oUIContextMenu.Commands.Add(oUICommandAdicionarLinha)
                oUIContextMenu.Commands.Add(oUICommandExcluirLinha)
                oUIContextMenu.Commands.Add(oUICommandConfigurarGrid)
                oUIContextMenu.Commands.Add(oUICommandExportarExcel)
                oUIContextMenu.Commands.Add(oUICommandAgruparListagem)
                oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                AddCommandClick(oUICommandCopiar, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandAdicionarLinha, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandExcluirLinha, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandConfigurarGrid, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandExportarExcel, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandAgruparListagem, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
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

                Case "adicionar_linha"

                    If oGridEx.Name = grdOrcamentoListaMaterial.Name Then
                        oClsUsrCadMascaraOrcamento.GerarCodigoListaMaterial(iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                        oClsUsrCadMascaraOrcamento.LoadGridListaMaterial(grdOrcamentoListaMaterial, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    If oGridEx.Name = grdOrcamentoProcessoProdutivo.Name Then
                        oClsUsrCadMascaraOrcamento.GerarCodigoProcessoProdutivo(iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                        oClsUsrCadMascaraOrcamento.LoadGridProcessoProdutivo(grdOrcamentoProcessoProdutivo, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    If oGridEx.Name = grdOrcamentoServicoTerceiros.Name Then
                        oClsUsrCadMascaraOrcamento.GerarCodigoServicoTerceiros(iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                        oClsUsrCadMascaraOrcamento.LoadGridServicoTerceiros(grdOrcamentoServicoTerceiros, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                Case "excluir_linha"

                    If oGridEx.Name = grdOrcamentoGrupo.Name Then
                        oClsUsrCadMascaraOrcamento.DeleteGrupo(iCodigoMascara, grdOrcamentoGrupo.CurrentRow)
                        oClsUsrCadMascaraOrcamento.LoadGridGrupo(grdOrcamentoGrupo, iCodigoMascara)
                    End If

                    If oGridEx.Name = grdOrcamentoListaMaterial.Name Then
                        oClsUsrCadMascaraOrcamento.DeleteListaMaterial(grdOrcamentoListaMaterial.CurrentRow)
                        oClsUsrCadMascaraOrcamento.LoadGridListaMaterial(grdOrcamentoListaMaterial, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    If oGridEx.Name = grdOrcamentoProcessoProdutivo.Name Then
                        oClsUsrCadMascaraOrcamento.DeleteProcessoProdutivo(grdOrcamentoProcessoProdutivo.CurrentRow)
                        oClsUsrCadMascaraOrcamento.LoadGridProcessoProdutivo(grdOrcamentoProcessoProdutivo, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    If oGridEx.Name = grdOrcamentoServicoTerceiros.Name Then
                        oClsUsrCadMascaraOrcamento.DeleteServicoTerceiros(grdOrcamentoServicoTerceiros.CurrentRow)
                        oClsUsrCadMascaraOrcamento.LoadGridServicoTerceiros(grdOrcamentoServicoTerceiros, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))
                    End If

                    LoadChartGrupo()

                Case "copiar"

                    Dim oGrid As GridEX = sender.Tag

                    If oGrid.GetDataRows.Count > 0 Then
                        If IsNothing(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key)) = False Then
                            Clipboard.SetDataObject(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key).Text)
                        End If
                    End If

                Case "adicionar_lista_material"

                    'Limpa todas as paginas
                    tabDados.TabPages.Clear()

                    If Validacao() = False Then Exit Sub
                    Salvar()

                    oClsUsrCadMascaraOrcamento.GerarCodigoGrupo(iCodigoMascara, 2)
                    oClsUsrCadMascaraOrcamento.LoadGridGrupo(grdOrcamentoGrupo, iCodigoMascara)

                Case "adicionar_processo_produtivo"

                    'Limpa todas as paginas
                    tabDados.TabPages.Clear()

                    If Validacao() = False Then Exit Sub
                    Salvar()

                    oClsUsrCadMascaraOrcamento.GerarCodigoGrupo(iCodigoMascara, 3)
                    oClsUsrCadMascaraOrcamento.LoadGridGrupo(grdOrcamentoGrupo, iCodigoMascara)

                Case "adicionar_servico_terceiros"

                    'Limpa todas as paginas
                    tabDados.TabPages.Clear()

                    If Validacao() = False Then Exit Sub
                    Salvar()

                    oClsUsrCadMascaraOrcamento.GerarCodigoGrupo(iCodigoMascara, 4)
                    oClsUsrCadMascaraOrcamento.LoadGridGrupo(grdOrcamentoGrupo, iCodigoMascara)

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

#Region "::: GRUPO :::"

    Private Sub grdOrcamentoGrupo_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoGrupo.CellUpdated

        Try

            'Atualiza os dados
            oClsUsrCadMascaraOrcamento.UpdateGrupo(iCodigoMascara, _
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

#End Region

#Region "::: COMPOSIÇÃO :::"

#Region "::: GERAL :::"

    Private Sub grd_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoListaMaterial.CellUpdated, _
                                                                                      grdOrcamentoProcessoProdutivo.CellUpdated, _
                                                                                      grdOrcamentoServicoTerceiros.CellUpdated

        Try

            Select Case sender.name

                Case "grdOrcamentoListaMaterial"

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

                    'Pra calcular o custo total. Se for KG, é quantidade * peso, se for peça, é quantidade * custo unitario
                    Dim iCodigoUnidadeMedida As Integer = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("codigo_unidade_medida")), -1, grdOrcamentoListaMaterial.GetValue("codigo_unidade_medida"))
                    Dim dQuantidade As Double = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("quantidade")), 0, grdOrcamentoListaMaterial.GetValue("quantidade"))
                    Dim dCustoUnitario As Double = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("custo_unitario")), 0, grdOrcamentoListaMaterial.GetValue("custo_unitario"))
                    Dim dPeso As Double = IIf(IsDBNull(grdOrcamentoListaMaterial.GetValue("peso")), 0, grdOrcamentoListaMaterial.GetValue("peso"))
                    Dim dCustoTotal As Double

                    'Se for KG
                    If iCodigoUnidadeMedida = 2 Then
                        dCustoTotal = dPeso * dCustoUnitario
                    ElseIf iCodigoUnidadeMedida = 5 Then 'Se for Peça
                        dCustoTotal = dQuantidade * dCustoUnitario
                    End If

                    grdOrcamentoListaMaterial.SetValue("custo_total", dCustoTotal)

                    oClsUsrCadMascaraOrcamento.UpdateListaMaterial(sender.CurrentRow)

                    oClsUsrCadMascaraOrcamento.LoadGridListaMaterial(sender, _
                                                                     sender.CurrentRow.Cells("codigo_mascara").Value, _
                                                                     sender.CurrentRow.Cells("codigo_mascara_grupo").Value)

                Case "grdOrcamentoProcessoProdutivo"

                    Select Case grdOrcamentoProcessoProdutivo.CurrentColumn.Key

                        Case "tempo_setup_decimal"

                            If IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("tempo_setup_decimal")) = False Then
                                Dim sHoraFormatada As String = TimeSpan.FromHours(Replace(grdOrcamentoProcessoProdutivo.GetValue("tempo_setup_decimal"), ".", ",")).ToString("hh\:mm\:ss")
                                grdOrcamentoProcessoProdutivo.SetValue("tempo_setup", sHoraFormatada)
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
                                Dim sHoraFormatada As String = TimeSpan.FromHours(Replace(grdOrcamentoProcessoProdutivo.GetValue("tempo_maquina_decimal"), ".", ",")).ToString("hh\:mm\:ss")
                                grdOrcamentoProcessoProdutivo.SetValue("tempo_maquina", sHoraFormatada)
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

                    Dim sTempoTotal As String = TimeSpan.FromHours(Replace(dHoras, ".", ",")).ToString("hh\:mm\:ss")
                    grdOrcamentoProcessoProdutivo.SetValue("tempo_total", sTempoTotal)

                    Dim dCustoUnitario As Double = IIf(IsDBNull(grdOrcamentoProcessoProdutivo.GetValue("custo_hora")), 0, grdOrcamentoProcessoProdutivo.GetValue("custo_hora"))
                    grdOrcamentoProcessoProdutivo.SetValue("custo_total", dHoras * dCustoUnitario)

                    oClsUsrCadMascaraOrcamento.UpdateProcessoProdutivo(sender.CurrentRow)

                    oClsUsrCadMascaraOrcamento.LoadGridProcessoProdutivo(sender, _
                                                                         sender.CurrentRow.Cells("codigo_mascara").Value, _
                                                                         sender.CurrentRow.Cells("codigo_mascara_grupo").Value)

                Case "grdOrcamentoServicoTerceiros"

                    Dim dQuantidade As Double = IIf(IsDBNull(grdOrcamentoServicoTerceiros.GetValue("quantidade")), 0, grdOrcamentoServicoTerceiros.GetValue("quantidade"))
                    Dim dValorUnitario As Double = IIf(IsDBNull(grdOrcamentoServicoTerceiros.GetValue("valor_unitario")), 0, grdOrcamentoServicoTerceiros.GetValue("valor_unitario"))
                    grdOrcamentoServicoTerceiros.SetValue("valor_total", dQuantidade * dValorUnitario)

                    oClsUsrCadMascaraOrcamento.UpdateServicoTerceiros(sender.CurrentRow)

                    oClsUsrCadMascaraOrcamento.LoadGridServicoTerceiros(sender, _
                                                                        sender.CurrentRow.Cells("codigo_mascara").Value, _
                                                                        sender.CurrentRow.Cells("codigo_mascara_grupo").Value)

            End Select

            LoadChartGrupo()

            LoadGridGrupo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


#End Region

#Region "::: SERVIÇO DE TERCEIROS :::"

    Private Sub grdOrcamentoServicoTerceiros_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOrcamentoServicoTerceiros.RowDoubleClick

        Try

            If IsNothing(grdOrcamentoServicoTerceiros.CurrentColumn) Then Exit Sub

            Select Case grdOrcamentoServicoTerceiros.CurrentColumn.Key

                Case "editar" : EditarServicoTerceiros()
                Case "fornecedor" : FindFornecedor()
                Case "codigo_operacao" : FindOperacao()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarFornecedor_Click(sender As Object, e As EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedor

            'Abre Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvarServico_Click(sender As Object, e As EventArgs) Handles btnSalvarServico.Click

        Try

            oClsUsrCadMascaraOrcamento.UpdateComposicaoServicoTerceiros2(iCodigoMascara, _
                                                                         grdOrcamentoGrupo.GetValue("codigo"), _
                                                                         iCodigoServicoTerceiros, _
                                                                         iSequencia, _
                                                                         IIf(cboOperacao.SelectedIndex = -1, -1, cboOperacao.SelectedValue), _
                                                                         txtQuantidadeServico.Value, _
                                                                         txtValorUnitario.Value, _
                                                                         IIf(cboFornecedor.SelectedIndex = -1, -1, cboFornecedor.SelectedValue))

            frmMain.Informacao(Mensagem.RegistroAlterado)

            oClsUsrCadMascaraOrcamento.LoadGridServicoTerceiros(grdOrcamentoServicoTerceiros, _
                                                                iCodigoMascara, _
                                                                grdOrcamentoGrupo.GetValue("codigo"))

            grpServicoTerceiros.Visible = False
            grdOrcamentoServicoTerceiros.Location = New Point(11, 9)
            grdOrcamentoServicoTerceiros.Size = New Size(pagServicoTerceiro.Size.Width - 19, pagServicoTerceiro.Size.Height - 17)

            LoadGridGrupo()
            LoadChartGrupo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo.SelectedIndexChanged

        Try

            cboOperacao.SelectedIndex = -1
            cboOperacao.DataSource = Nothing

            If cboGrupo.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao_grupo " & goUsuario.iEmpresa & "," & cboGrupo.SelectedValue, True)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Servico_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorUnitario.LostFocus, _
                                                                                              txtQuantidadeServico.LostFocus

        Try

            txtValorTotal.Value = txtValorUnitario.Value * txtQuantidadeServico.Value

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#End Region

#Region "::: GERAL :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

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

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            txtDescricao.Focus()

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
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, _
                                                                                                                       grdOrcamentoGrupo.ColumnMoved, _
                                                                                                                       grdOrcamentoListaMaterial.ColumnMoved, _
                                                                                                                       grdOrcamentoProcessoProdutivo.ColumnMoved, _
                                                                                                                       grdOrcamentoServicoTerceiros.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, _
                                                                                                                        grdOrcamentoGrupo.SizingColumn, _
                                                                                                                        grdOrcamentoListaMaterial.SizingColumn, _
                                                                                                                        grdOrcamentoProcessoProdutivo.SizingColumn, _
                                                                                                                        grdOrcamentoServicoTerceiros.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region
    
#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GRUPO :::"

    Private Sub LoadGridGrupo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim iCodigo As Integer

            For Each oRow As GridEXRow In grdOrcamentoGrupo.GetCheckedRows
                iCodigo = oRow.Cells("codigo").Value
            Next

            oClsUsrCadMascaraOrcamento.LoadGridGrupo(grdOrcamentoGrupo, _
                                                     iCodigoMascara)

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

    Private Sub LoadChartGrupo()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadMascaraOrcamento.LoadGraficoComposicao(chrComposicao, _
                                                             iCodigoMascara)

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
                    tabDados.TabPages.Add(pagListaMaterialGrupo)
                    oClsUsrCadMascaraOrcamento.LoadGridListaMaterial(grdOrcamentoListaMaterial, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))

                Case "3"
                    tabDados.TabPages.Add(pagProcessoProdutivo)
                    oClsUsrCadMascaraOrcamento.LoadGridProcessoProdutivo(grdOrcamentoProcessoProdutivo, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))

                Case "4"
                    tabDados.TabPages.Add(pagServicoTerceiro)
                    oClsUsrCadMascaraOrcamento.LoadGridServicoTerceiros(grdOrcamentoServicoTerceiros, iCodigoMascara, grdOrcamentoGrupo.GetValue("codigo"))

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: COMPOSIÇÃO :::"

#Region "::: LISTA MATERIAL :::"

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
            grdOrcamentoListaMaterial.SetValue("peso", oScriptControl.Eval(sCalculo) * dQuantidade)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO DE TERCEIROS :::"

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

    Private Sub EditarServicoTerceiros()

        Try

            Dim bAux As Boolean = grpServicoTerceiros.Visible
            Dim x As Integer = grdOrcamentoServicoTerceiros.Size.Width
            Dim y As Integer = grdOrcamentoServicoTerceiros.Size.Height

            grpServicoTerceiros.Visible = True
            grdOrcamentoServicoTerceiros.Location = New Point(11, 76)

            If bAux = True Then
                grdOrcamentoServicoTerceiros.Size = New Size(x, y)
            Else
                grdOrcamentoServicoTerceiros.Size = New Size(x, y - 2 - grpServicoTerceiros.Size.Height)
            End If

            NovoServicoTerceiros()

            If IsDBNull(grdOrcamentoServicoTerceiros.GetValue("codigo_grupo_operacao")) Then
                cboGrupo.SelectedIndex = -1
                LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao_orcamento_servico_terceiros " & goUsuario.iEmpresa)
            Else
                cboGrupo.SelectedValue = grdOrcamentoServicoTerceiros.GetValue("codigo_grupo_operacao")
            End If

            cboOperacao.SelectedValue = grdOrcamentoServicoTerceiros.GetValue("codigo_operacao")
            txtQuantidadeServico.Value = grdOrcamentoServicoTerceiros.GetValue("quantidade")
            txtValorUnitario.Value = grdOrcamentoServicoTerceiros.GetValue("valor_unitario")
            txtValorTotal.Value = grdOrcamentoServicoTerceiros.GetValue("valor_total")
            cboFornecedor.SelectedValue = grdOrcamentoServicoTerceiros.GetValue("fornecedor")

            iCodigoServicoTerceiros = grdOrcamentoServicoTerceiros.GetValue("codigo")
            iSequencia = grdOrcamentoServicoTerceiros.GetValue("sequencia")

            cboGrupo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoServicoTerceiros()

        Try

            LimparCamposGroupBox(grpServicoTerceiros)

            LoadCombo(cboGrupo, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa, False)
            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_parceiro_negocio_fornecedor " & goUsuario.iEmpresa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            AddMenuGridGrupo(grdOrcamentoGrupo)
            AddMenuGrid(grdOrcamentoListaMaterial)
            AddMenuGrid(grdOrcamentoProcessoProdutivo)
            AddMenuGrid(grdOrcamentoServicoTerceiros)

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_item", "sp_select_combo_cadastro_basico_item_materia_prima " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "tipo_item_sped", "sp_select_combo_static_tipo_item_sped_orcamento")
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_familia", "sp_select_combo_cadastro_basico_familia " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_tipo_perfil", "sp_select_combo_cadastro_basico_tipo_perfil " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_material", "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoListaMaterial, "codigo_unidade_medida", "sp_select_combo_cadastro_basico_unidade_medida_orcamento " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoProcessoProdutivo, "codigo_operacao", "sp_select_combo_cadastro_basico_operacao_orcamento " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoProcessoProdutivo, "codigo_maquina", "sp_select_combo_cadastro_basico_maquina_orcamento " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoServicoTerceiros, "codigo_operacao", "sp_select_combo_cadastro_basico_operacao_orcamento_servico_terceiros " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoServicoTerceiros, "fornecedor", "sp_select_combo_cadastro_basico_parceiro_negocio_fornecedor " & goUsuario.iEmpresa)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdOrcamentoGrupo, iFormulario)
            ConfiguraGrid(grdOrcamentoListaMaterial, iFormulario)
            ConfiguraGrid(grdOrcamentoProcessoProdutivo, iFormulario)
            ConfiguraGrid(grdOrcamentoServicoTerceiros, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            txtDescricaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Novo()

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtDescricao.Text = .Item("descricao").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    iCodigoMascara = .Item("codigo").Value

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                txtDescricao.Focus()

                oClsUsrCadMascaraOrcamento.LoadGridGrupo(grdOrcamentoGrupo, _
                                                         iCodigoMascara)

                LoadChartGrupo()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

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
                    oClsUsrCadMascaraOrcamento.Delete()

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpDados)
            grdOrcamentoGrupo.DataSource = Nothing
            grdOrcamentoListaMaterial.DataSource = Nothing
            grdOrcamentoProcessoProdutivo.DataSource = Nothing
            grdOrcamentoServicoTerceiros.DataSource = Nothing

            iCodigoMascara = -1
            btnSalvar.Tag = ""
            cboAtivo.SelectedValue = True

            LoadChartGrupo()

            txtDescricao.Focus()

            tabDados.TabPages.Clear()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If iCodigoMascara > 0 Then


                oClsUsrCadMascaraOrcamento.Update(iCodigoMascara, _
                                                  txtDescricao.Text.Trim, _
                                                  cboAtivo.SelectedValue)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadMascaraOrcamento.Insert(txtDescricao.Text.Trim, _
                                                  cboAtivo.SelectedValue, _
                                                  btnSalvar)

                iCodigoMascara = btnSalvar.Tag

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

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
            oClsUsrCadMascaraOrcamento.LoadGrid(grdListagem, _
                                                txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False

            'Passa Parametros
            If oClsUsrCadMascaraOrcamento.ValidaDescricao(iCodigoMascara, _
                                                          txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição: " & txtDescricao.Text & " já está associado a outro Registro.")
                txtDescricao.Focus()
                Return False
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    

#End Region

#End Region

End Class
