Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO
Imports System.IO.File
Imports SHDocVw

Public Class usrFatEntradaNFeDestinada

#Region "::: VARIAVEIS :::"

    Private sArquivoNF As StreamWriter
    Private oClsFatEntradaNFeDestinada As New clsUsrFatEntradaNFeDestinada

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFatEntradaNFeDestinada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatEntradaNFeDestinada_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfiguraUserControl()

    End Sub

#End Region

#Region "::: NF-E :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFDestinada
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNFDestinada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAtualizarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizarConsulta.Click

        Try

            AtualizarConsultaINTERACTI()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnManifestarRecebimento_Click(sender As Object, e As EventArgs) Handles btnManifestarRecebimento.Click

        Try

            'Baixar Arquivos para a Pasta de Entrada
            Call ManifestacaoDestinatario()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarArquivoXML_Click(sender As Object, e As EventArgs) Handles btnSalvarArquivoXML.Click

        Try

            Dim oFileDialog As New FolderBrowserDialog
            If oFileDialog.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub


            For Each oRow In grdListagem.GetCheckedRows


                Call DownloadXML(False, _
                                oRow.Cells.Item("chave_acesso").Value, _
                                oRow.Cells.Item("cte").Value, _
                                oFileDialog.SelectedPath, _
                                oRow.Cells.Item("nota_fiscal").Value)

            Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdListagem.CurrentRow) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case grdListagem.CurrentColumn.Key
                Case "confirmar_recebimento" : ManifestacaoDestinatarioIndividual()
                Case "recusar_nota_fiscal" : RecusarNotaFical()
                Case "desconhecimento_operacao" : DesconhecimentoOperacao()
                Case "download_xml"


                    Dim oFileDialog As New FolderBrowserDialog
                    If oFileDialog.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub

                    Call DownloadXML(False, _
                                    grdListagem.GetValue("chave_acesso"), _
                                    grdListagem.GetValue("cte"), _
                                    oFileDialog.SelectedPath, _
                                    grdListagem.GetValue("nota_fiscal"))

                Case "web" : ConsultarNFeWeb(grdListagem.CurrentRow.Cells("chave_acesso").Value)
                Case "conferencia" : Conferencia()
                Case "atualizar_cte" : AtualizarCTe()
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FaturamentoEntradaNFDestinada, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoEntradaNFDestinada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEntradaNFDestinada, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportarCTe_Click(sender As Object, e As EventArgs) Handles btnImportarCTe.Click
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário deseja Importar as NFes destinadas
            If MsgBox("Deseja Importar a(s) CT-e(s) Destinada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                ''Primeiro, irá pesquisar para ver se existe uma nota NF
                Call LoadNotaDestinadaCTe()

                'Carrega Grid
                Call LoadGrid()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CC-e :::"

    Private Sub btnConfigurarGridCCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCCe.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCCe
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFDestinada
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCCe, Formulario.FaturamentoEntradaNFDestinada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridCCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCCe.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCCe.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCCe.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCCe.GroupByBoxVisible = True
                grdCCe.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCCe_Click(sender As Object, e As EventArgs) Handles btnExcelGridCCe.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdCCe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSairCCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairCCe.Click

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

    Private Sub btnFiltrarCCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarCCe.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridCCe()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCCe_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCCe.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCCe.Name, _
                                     Formulario.FaturamentoEntradaNFDestinada, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCCe_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCCe.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCCe, _
                                     Formulario.FaturamentoEntradaNFDestinada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCCe_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdCCe.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCCe.Name, _
                                          Formulario.FaturamentoEntradaNFDestinada, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: NF-e Cancelada :::"

    Private Sub btnConfigurarGridNFeCancelada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridNFeCancelada.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNFeCancelada
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFDestinada
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNFeCancelada, Formulario.FaturamentoEntradaNFDestinada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridNFeCancelada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridNFeCancelada.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNFeCancelada.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNFeCancelada.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNFeCancelada.GroupByBoxVisible = True
                grdNFeCancelada.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridNFeCancelada_Click(sender As Object, e As EventArgs) Handles btnExcelGridNFeCancelada.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdNFeCancelada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSairNFeCancelada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairNFeCancelada.Click

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

    Private Sub btnFiltrarNFeCancelada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarNFeCancelada.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridNFeCancelada()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNFeCancelada_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNFeCancelada.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNFeCancelada.Name, _
                                     Formulario.FaturamentoEntradaNFDestinada, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNFeCancelada_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNFeCancelada.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNFeCancelada, _
                                     Formulario.FaturamentoEntradaNFDestinada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNFeCancelada_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdNFeCancelada.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNFeCancelada.Name, _
                                          Formulario.FaturamentoEntradaNFDestinada, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"
    Private Sub AtualizarConsultaINTERACTI()
        Try

            Cursor = Cursors.WaitCursor

            Dim oDFE As New DFE
            oDFE.AtualizarImportacao()

            'Informa o usuário
            frmMain.Informacao("NF-e destinada atualizada com sucesso!", Color.Blue)

            'Carrega a grid
            LoadGrid()

            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ConfiguraUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEntradaNFeDestinada_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Controles
            dtpDataEmissaoInicioFiltro.Value = DateAdd(DateInterval.Day, (Now.Day - 1) * -1, Now.Date) : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEmissaoInicioCCeFiltro.Value = DateAdd(DateInterval.Day, (Now.Day - 1) * -1, Now.Date) : dtpDataEmissaoInicioCCeFiltro.Checked = False
            dtpDataEmissaoTerminoCCeFiltro.Value = Now.Date : dtpDataEmissaoTerminoCCeFiltro.Checked = False
            dtpDataEmissaoInicioNFeCanceladaFiltro.Value = DateAdd(DateInterval.Day, (Now.Day - 1) * -1, Now.Date) : dtpDataEmissaoInicioNFeCanceladaFiltro.Checked = False
            dtpDataEmissaoTerminoNFeCanceladaFiltro.Value = Now.Date : dtpDataEmissaoTerminoNFeCanceladaFiltro.Checked = False

            'Verifica Direito
            btnAtualizarConsulta.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFDestinada, gcInsert)

            'Carrega Combo
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nfe_destinada")
            LoadCombo(cboTipoDocumentoFiscalFiltro, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)

            'Carrega Dados do Emitente
            LoadDadosEmitente()

            'Carrega Configuração da NFe
            LoadConfiguracaoNFe()

            'Configura Grid
            ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNFDestinada)
            ConfiguraGrid(grdNFeCancelada, Formulario.FaturamentoEntradaNFDestinada)
            ConfiguraGrid(grdCCe, Formulario.FaturamentoEntradaNFDestinada)

            chkListarCTeCancelado.Checked = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: NF-e :::"

    Private Sub Conferencia()

        Try

            Cursor.Current = Cursors.WaitCursor

            If grdListagem.CurrentRow.Cells("usuario_conferencia").Value <> "" Then
                MsgBox("Esta nota já foi conferida!", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            'Abre Formulário
            Dim oForm As New frmFatEntradaNFeDestinadaConferencia

            'Seta Parâmetros
            oForm.ChaveAcesso = grdListagem.CurrentRow.Cells("chave_acesso").Value

            'Abre Formulário
            oForm.ShowDialog()

            Call LoadGrid()

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

            'Váriaveis Locais
            Dim sStatus As String = ""

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega NFe Autorizada
            oClsFatEntradaNFeDestinada.LoadGridNFeAutorizada(grdListagem, _
                                                             IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim) = False, -1, txtNotaFiscalFiltro.Text.Trim), _
                                                             IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                             IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                             txtEmitenteFiltro.Text.Trim, _
                                                             sStatus, _
                                                             IIf(cboTipoDocumentoFiscalFiltro.SelectedIndex = -1, -1, cboTipoDocumentoFiscalFiltro.SelectedValue), _
                                                             chkSomentePendencia.Checked, _
                                                             chkListarCTeCancelado.Checked)

            'Muda para primeira Linha
            grdListagem.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadNotaDestinadaCTe()
        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oClsNFeConsultaDFe_v2 As New clsNFeConsultaDFe_V4
            Dim sUltimoNSU As String = LoadUltimoNSUCTe()
            Dim sNSU As String = ""

            'Carregando os dados do emitente
            Call LoadDadosEmitente()

            'Setando o último NSU gravado de acordo com as NF´s já importadas
            oClsNFeConsultaDFe_v2.UltimoNSU = sUltimoNSU


            'Se não encontrar, procurar novamente pelo último criado
            If oClsNFeConsultaDFe_v2.SendCTE((oClsNFeConsultaDFe_v2.UltimoNSU)) = False Then


                'Se ocorrer um erro no consumo do serviço
                MsgBox(oClsNFeConsultaDFe_v2.MensagemErro)

            Else

                'Carregando o novo arquivo, porém ainda não parar enquanto não encontrar até o final
                oClsNFeConsultaDFe_v2.LoadArquivoCTE(oClsNFeConsultaDFe_v2.UltimoNSU)

                If oClsNFeConsultaDFe_v2.MensagemErro <> "" Then
                    MsgBox(oClsNFeConsultaDFe_v2.MensagemErro, MsgBoxStyle.Exclamation, "ERRO NF-E destinada")
                    Exit Sub
                End If


                sNSU = oClsNFeConsultaDFe_v2.UltimoNSU

            End If



            'Informando ao usuário
            frmMain.Informacao("Informações atualizadas com sucesso!", Color.Blue)

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw ex
        End Try
    End Sub

    Private Sub LoadNotaDestinadaDFe()
        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oClsNFeConsultaDFe_v2 As New clsNFeConsultaDFe_V4
            Dim sUltimoNSU As String = LoadUltimoNSU()
            Dim sNSU As String = ""

            'Carregando os dados do emitente
            Call LoadDadosEmitente()

            'Setando o último NSU gravado de acordo com as NF´s já importadas
            oClsNFeConsultaDFe_v2.UltimoNSU = sUltimoNSU


            'Se não encontrar, procurar novamente pelo último criado
            If oClsNFeConsultaDFe_v2.Send((oClsNFeConsultaDFe_v2.UltimoNSU)) = False Then


                'Se ocorrer um erro no consumo do serviço
                MsgBox(oClsNFeConsultaDFe_v2.MensagemErro)

            Else

                'Carregando o novo arquivo, porém ainda não parar enquanto não encontrar até o final
                oClsNFeConsultaDFe_v2.LoadArquivo(oClsNFeConsultaDFe_v2.UltimoNSU)

                If oClsNFeConsultaDFe_v2.MensagemErro <> "" Then
                    MsgBox(oClsNFeConsultaDFe_v2.MensagemErro, MsgBoxStyle.Exclamation, "ERRO NF-E destinada")
                    Exit Sub
                End If


                sNSU = oClsNFeConsultaDFe_v2.UltimoNSU

            End If



            'Informando ao usuário
            frmMain.Informacao("Informações atualizadas com sucesso!", Color.Blue)

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw ex
        End Try
    End Sub

    'Private Sub LoadNFeDestinada()

    '    Try

    '        'Váriaveis Locais
    '        Dim oClsNFeConsultaNFDestinada As New clsNFeConsultaNFDestinada
    '        Dim sUltimoNSU As String = LoadUltimoNSU()
    '        Dim indCont As Integer = 1
    '        Dim iContNSUIgual As Integer = 0
    '        Dim sNSU As String = ""

    '        'Carregando os dados do emitente
    '        Call LoadDadosEmitente()

    '        'Setando o último NSU gravado de acordo com as NF´s já importadas
    '        oClsNFeConsultaNFDestinada.UltimoNSU = sUltimoNSU

    '        'Enquanto não encontrar o valor, continuar procurando
    '        While indCont <> 0

    '            'Se não encontrar, procurar novamente pelo último criado
    '            If oClsNFeConsultaNFDestinada.Send(CLng(oClsNFeConsultaNFDestinada.UltimoNSU)) = False Then
    '                'Se ocorrer um erro no consumo do serviço
    '                frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaNFDestinada.MensagemErro)
    '                indCont = 0
    '            Else

    '                'Carregando o novo arquivo, porém ainda não parar enquanto não encontrar até o final
    '                oClsNFeConsultaNFDestinada.LoadArquivo()

    '                If oClsNFeConsultaNFDestinada.MensagemErro <> "" Then
    '                    frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaNFDestinada.MensagemErro)
    '                    Exit Sub
    '                End If

    '                'Retornando o valor
    '                indCont = oClsNFeConsultaNFDestinada.indCont

    '                'Verificando a quantidade de vezes que foi consultado o último NSU.
    '                'Incrementa um contador
    '                If sNSU = oClsNFeConsultaNFDestinada.UltimoNSU Then
    '                    iContNSUIgual += 1
    '                Else
    '                    sNSU = oClsNFeConsultaNFDestinada.UltimoNSU
    '                    iContNSUIgual = 0
    '                End If
    '                'Se consultar mais de 6 vezes, cancelar a operação
    '                If iContNSUIgual > 5 Then
    '                    indCont = 0
    '                End If

    '            End If

    '        End While

    '        'Informando ao usuário
    '        frmMain.Informacao(Mensagem.RegistroSalvo)

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Private Sub ManifestacaoDestinatarioIndividual()

        Try

            'Verifica o Status da NFe
            If grdListagem.CurrentRow.Cells("status").Value <> CInt(StatusNotaFiscalDestinada.NFeEntrada) Then
                'Informa o Usuário que a Operação não pode ser Realizada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oClsNFeManifestacaoDestinatario As New clsNFeManifestacaoDestinatario_V4

            If oClsNFeManifestacaoDestinatario.Send(grdListagem.CurrentRow.Cells("chave_acesso").Value, "1", 100) = True Then

                'Tratamento das informações do retorno
                If oClsNFeManifestacaoDestinatario.LoadArquivo() = True Then
                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, oClsNFeManifestacaoDestinatario.MensagemErro)
                End If

            Else
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsNFeManifestacaoDestinatario.MensagemErro)
            End If

            'Carrega Grid
            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            'Seta Cursor do Mouse
            Cursor = Cursors.Default
            Throw ex
        End Try

    End Sub

    Private Sub ManifestacaoDestinatario()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusNotaFiscalDestinada.NFeEntrada)) Then

                'Váriaveis Locais
                Dim oClsNFeManifestacaoDestinatario As New clsNFeManifestacaoDestinatario_V4

                'Seta Cursor do Mouse
                Cursor = Cursors.WaitCursor

                For Each oRow As GridEXRow In gSelecaoRow

                    If oClsNFeManifestacaoDestinatario.Send(oRow.Cells("chave_acesso").Value, "1", 100) = True Then

                        'Tratamento das informações do retorno
                        If oClsNFeManifestacaoDestinatario.LoadArquivo() = True Then
                            'Informa o Usuário sobre o Sucesso da Operação
                            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)


                        Else
                            'Informa o Usuário sobre o Erro Ocorrido
                            frmMain.Informacao(Mensagem.Erro, oClsNFeManifestacaoDestinatario.MensagemErro)
                        End If

                    Else
                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.Erro, oClsNFeManifestacaoDestinatario.MensagemErro)
                    End If




                Next





                'Seta Cursor do Mouse
                Cursor = Cursors.Default

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário a Necessidade de Selecionar Registros Válidos
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            'Seta Cursor do Mouse
            Cursor = Cursors.Default
            Throw ex
        End Try

    End Sub

    Private Sub RecusarNotaFical()

        Try

            ''Verifica Status da Nota Fiscal
            'If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusNotaFiscalDestinada.NFeEntrada) Then

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNFDestinada, gcAdministrator) = True Then

                'Váriavel - Formulário de Cancelamento
                Dim oForm As New frmFatEntradaNFeDestinadaRecusa

                'Seta Paramentros
                oForm.NotaFiscal = grdListagem.CurrentRow.Cells("nota_fiscal").Value
                oForm.DataEmissao = grdListagem.CurrentRow.Cells("data_emissao").Value
                oForm.Emitente = grdListagem.CurrentRow.Cells("emitente").Value
                oForm.ChaveAcesso = grdListagem.CurrentRow.Cells("chave_acesso").Value
                oForm.txtTipoEvento.Text = "210240"
                oForm.Text = "Recusar Nota Fiscal"

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

            'Else
            ''Informa o Usuário que a Nota Fiscal está cancelada
            'frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            'End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DesconhecimentoOperacao()

        Try

            ''Verifica Status da Nota Fiscal
            'If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusNotaFiscalDestinada.NFeEntrada) Then

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNFDestinada, gcAdministrator) = True Then

                'Váriavel - Formulário de Cancelamento
                Dim oForm As New frmFatEntradaNFeDestinadaRecusa

                'Seta Paramentros
                oForm.NotaFiscal = grdListagem.CurrentRow.Cells("nota_fiscal").Value
                oForm.DataEmissao = grdListagem.CurrentRow.Cells("data_emissao").Value
                oForm.Emitente = grdListagem.CurrentRow.Cells("emitente").Value
                oForm.ChaveAcesso = grdListagem.CurrentRow.Cells("chave_acesso").Value
                oForm.txtTipoEvento.Text = "210220"
                oForm.Text = "Informar desconhecimento da operação"

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

            'Else
            ''Informa o Usuário que a Nota Fiscal está cancelada
            'frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            'End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DownloadXML(ByVal bImportar As Boolean, _
                            ByVal sChaveAcesso As String, _
                            ByVal bCTE As Boolean, _
                            ByVal sDiretorio As String, _
                            ByVal sNotaFiscal As String)

        Try


            'Váriaveis Locais
            Dim oClsNFeConsultaDFe_V2 As New clsNFeConsultaDFe_V4


            'Se for NF normal
            If bCTE = False Then


                'Verifica se o Arquivo pode ser baixado
                If oClsNFeConsultaDFe_V2.SendDownload(sChaveAcesso) = True Then


                    'Seta Arquivo
                    Dim sArquivo As String = sDiretorio & IIf(sDiretorio.Substring(sDiretorio.Length - 1) = "\", "", "\") & "NF_" & _
                                                    sNotaFiscal & "_ChaveAcesso_" & sChaveAcesso & ".xml"


                    'Carrega Arquivo
                    oClsNFeConsultaDFe_V2.LoadArquivoDownload(sArquivo, sChaveAcesso)

                    'Verifica se Ocorreu Algum Erro
                    If oClsNFeConsultaDFe_V2.MensagemErro <> "" Then
                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
                    Else
                        'Atualiza Registro
                        ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_nfe_destinada_autorizada', 'download', 1, ' WHERE (((chave_acesso) = ''" & sChaveAcesso & "'') AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                        If bImportar = True Then

                            'Carrega Arquivo XML
                            Dim oStreamReader As StreamReader = New StreamReader(sArquivo, System.Text.Encoding.Default)
                            Dim sArquivoXML As String = oStreamReader.ReadToEnd
                            oStreamReader.Close()

                            'Executa a importação
                            Dim oClsUsrIntImportacaoNFe As New clsUsrIntImportacaoNFe
                            Dim sMensagem As String = ""
                            oClsUsrIntImportacaoNFe.ImportarXMLEntrada(sArquivoXML, sArquivo, sMensagem, False)


                            If sMensagem <> "" Then
                                MsgBox(sMensagem, vbExclamation, "Importação")
                                Exit Sub
                            End If
                        End If

                    End If

                Else
                    'Informa o Usuário que o Arquivo não pode ser baixado
                    frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
                End If



            Else ' CTE


                'Verifica se o Arquivo pode ser baixado
                If oClsNFeConsultaDFe_V2.SendDownloadCTE(sChaveAcesso) = True Then

                    'Seta Arquivo
                    Dim sArquivo As String = sDiretorio & IIf(sDiretorio.Substring(sDiretorio.Length - 1) = "\", "", "\") & "CTE_" & sNotaFiscal & "_ChaveAcesso_" & sChaveAcesso & ".xml"

                    'Carrega Arquivo
                    oClsNFeConsultaDFe_V2.LoadArquivoDownloadCTE(sArquivo)

                    'Verifica se Ocorreu Algum Erro
                    If oClsNFeConsultaDFe_V2.MensagemErro <> "" Then
                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
                    Else
                        'Atualiza Registro
                        ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_nfe_destinada_autorizada', 'download', 1, ' WHERE (((chave_acesso) = ''" & sChaveAcesso & "'') AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    End If

                Else
                    'Informa o Usuário que o Arquivo não pode ser baixado
                    frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
                End If

            End If


            'Seta Cursor do Mousr
            Cursor = Cursors.Default

            'Carrega Grid
            Call LoadGrid()



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Private Sub DownloadXML(ByVal bImportar As Boolean)

    '    Try

    '        'Verifica se foi Selecionado algum Registro
    '        If VerificaSelecaoRowDiferente(grdListagem, "status", CInt(StatusNotaFiscalDestinada.NFeEntrada)) = True Then

    '            'Váriaveis Locais
    '            Dim oClsNFeConsultaDFe_V2 As New clsNFeConsultaDFe_V4


    '            Dim oFileDialog As New FolderBrowserDialog


    '            If oFileDialog.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub

    '            'Seta Cursor do Mousr
    '            Cursor = Cursors.WaitCursor
    '            For Each oRow As GridEXRow In gSelecaoRow


    '                Dim bCTE As Boolean = False

    '                If IsDBNull(grdListagem.GetValue("cte")) = False Then

    '                    bCTE = grdListagem.GetValue("cte")

    '                End If

    '                If bCTE = False Then


    '                    'Verifica se o Arquivo pode ser baixado
    '                    If oClsNFeConsultaDFe_V2.SendDownload(oRow.Cells("chave_acesso").Value) = True Then



    '                        'Seta Arquivo
    '                        Dim sArquivo As String = oFileDialog.SelectedPath & IIf(oFileDialog.SelectedPath.Substring(oFileDialog.SelectedPath.Length - 1) = "\", "", "\") & "NF_" & oRow.Cells("nota_fiscal").Value & "_ChaveAcesso_" & oRow.Cells("chave_acesso").Value & ".xml"

    '                        'Carrega Arquivo
    '                        oClsNFeConsultaDFe_V2.LoadArquivoDownload(sArquivo)

    '                        'Verifica se Ocorreu Algum Erro
    '                        If oClsNFeConsultaDFe_V2.MensagemErro <> "" Then
    '                            'Informa o Usuário sobre o Erro Ocorrido
    '                            frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
    '                        Else
    '                            'Atualiza Registro
    '                            ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_nfe_destinada_autorizada', 'download', 1, ' WHERE (((chave_acesso) = ''" & oRow.Cells("chave_acesso").Value & "'') AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
    '                            'Informa o Usuário sobre o Sucesso da Operação
    '                            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

    '                            If bImportar = True Then

    '                                'Carrega Arquivo XML
    '                                Dim oStreamReader As StreamReader = New StreamReader(sArquivo, System.Text.Encoding.Default)
    '                                Dim sArquivoXML As String = oStreamReader.ReadToEnd
    '                                oStreamReader.Close()

    '                                'Executa a importação
    '                                Dim oClsUsrIntImportacaoNFe As New clsUsrIntImportacaoNFe
    '                                Dim sMensagem As String = ""
    '                                oClsUsrIntImportacaoNFe.ImportarXMLEntrada(sArquivoXML, sArquivo, sMensagem, False)


    '                                If sMensagem <> "" Then
    '                                    MsgBox(sMensagem, vbExclamation, "Importação")
    '                                    Exit Sub

    '                                End If
    '                            End If

    '                        End If

    '                    Else
    '                        'Informa o Usuário que o Arquivo não pode ser baixado
    '                        frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
    '                    End If



    '                Else ' CTE


    '                    'Verifica se o Arquivo pode ser baixado
    '                    If oClsNFeConsultaDFe_V2.SendDownloadCTE(oRow.Cells("chave_acesso").Value) = True Then

    '                        'Seta Arquivo
    '                        Dim sArquivo As String = oFileDialog.SelectedPath & IIf(oFileDialog.SelectedPath.Substring(oFileDialog.SelectedPath.Length - 1) = "\", "", "\") & "CTE_" & oRow.Cells("nota_fiscal").Value & "_ChaveAcesso_" & oRow.Cells("chave_acesso").Value & ".xml"

    '                        'Carrega Arquivo
    '                        oClsNFeConsultaDFe_V2.LoadArquivoDownloadCTE(sArquivo)

    '                        'Verifica se Ocorreu Algum Erro
    '                        If oClsNFeConsultaDFe_V2.MensagemErro <> "" Then
    '                            'Informa o Usuário sobre o Erro Ocorrido
    '                            frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
    '                        Else
    '                            'Atualiza Registro
    '                            ExecuteQuery("sp_update_interacti_table_field 'tb_fat_entrada_nfe_destinada_autorizada', 'download', 1, ' WHERE (((chave_acesso) = ''" & oRow.Cells("chave_acesso").Value & "'') AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
    '                            'Informa o Usuário sobre o Sucesso da Operação
    '                            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

    '                        End If

    '                    Else
    '                        'Informa o Usuário que o Arquivo não pode ser baixado
    '                        frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaDFe_V2.MensagemErro)
    '                    End If

    '                End If




    '            Next

    '            'Seta Cursor do Mousr
    '            Cursor = Cursors.Default

    '            'Carrega Grid
    '            Call LoadGrid()





    '        Else
    '            'Informa o Usuário sobre a Necessidade de Selecionar Registros Válidos
    '            frmMain.Informacao(Mensagem.ValidacaoSelecionar)
    '        End If

    '    Catch ex As Exception
    '        Cursor = Cursors.Default
    '        Throw ex
    '    End Try

    'End Sub

    Private Sub ConsultarNFeWeb(ByVal sChaveAcesso As String)

        Try

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Instancio um objeto
            Dim oInternetExplorer As New InternetExplorer

            oInternetExplorer.Navigate("http://www.nfe.fazenda.gov.br/portal/consulta.aspx?tipoConsulta=completa&tipoConteudo=XbSeqxE8pl8=")

            'Aguardo até que a página esteja totalmente carregada
            Do While oInternetExplorer.Busy : Loop

            'Delay
            Threading.Thread.Sleep(1000)

            'Abre Página
            oInternetExplorer.Visible = True

            'Preencho o formulário
            oInternetExplorer.Document.all("ContentPlaceHolder1_txtChaveAcessoCompleta").Value = sChaveAcesso

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CC-e :::"

    Private Sub LoadGridCCe()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega NFe Autorizada
            Call oClsFatEntradaNFeDestinada.LoadGridNFeCCe(grdCCe, _
                                                           IIf(dtpDataEmissaoInicioCCeFiltro.Checked = True, dtpDataEmissaoInicioCCeFiltro.Value, ""), _
                                                           IIf(dtpDataEmissaoTerminoCCeFiltro.Checked = True, dtpDataEmissaoTerminoCCeFiltro.Value, ""), _
                                                           txtEmitenteCCeFiltro.Text.Trim)

            'Muda para primeira Linha
            grdCCe.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: NF-e Cancelada :::"

    Private Sub AtualizarCTe()

        Try

            Cursor.Current = Cursors.WaitCursor

            If grdListagem.CurrentRow.Cells("cte").Value = True Then

                If MsgBox("Este CT-e encontra-se cancelado? Ele não irá mais aparecer na listagem.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    oClsFatEntradaNFeDestinada.AtualizarCTeCancelado(grdListagem.GetValue("chave_acesso"))
                    LoadGrid()
                End If

            Else
                MsgBox("Este registro não é um CT-e.", MsgBoxStyle.Exclamation, "Validação")
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridNFeCancelada()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega NFe Autorizada
            Call oClsFatEntradaNFeDestinada.LoadGridNFeCancelada(grdNFeCancelada, _
                                                                 IIf(dtpDataEmissaoInicioNFeCanceladaFiltro.Checked = True, dtpDataEmissaoInicioNFeCanceladaFiltro.Value, ""), _
                                                                 IIf(dtpDataEmissaoTerminoNFeCanceladaFiltro.Checked = True, dtpDataEmissaoTerminoNFeCanceladaFiltro.Value, ""), _
                                                                 txtEmitenteNFeCanceladaFiltro.Text.Trim)

            'Muda para primeira Linha
            grdNFeCancelada.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class