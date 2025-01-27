Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.UI.Tab
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrQARNC

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrQARNC As New clsUsrQARNC
    Private iFormulario As Integer
    Private lCodigoRNC As Long
    Private lCodigoOP As Long
#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub btnNovoRNC_Click(sender As Object, e As EventArgs) Handles btnNovoRNC.Click
        Try
            NovoRegistroNaoConformidade()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnNovoRNCDados_Click(sender As Object, e As EventArgs) Handles btnNovoRNCDados.Click
        Try
            NovoRegistroNaoConformidade()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try
            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focus
            txtNumeroRNCFiltro.Focus()

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

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Valida Formulário
            If Validacao() = True Then

                'Verifica se o usuário deseja reprovar
                If MsgBox("Deseja Salvar o Registro de Não Conformidade?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Salva Dados de Qualidade
                    Call Salvar()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.GetValue("codigo"))

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirRNC_Click(sender As Object, e As EventArgs) Handles btnExcluirRNC.Click
        Try

            'Deleta Registros
            Call DeleteRNC()

            'Prepara Formulário para Inserção de um Novo Registro
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnGerarSAC_Click(sender As Object, e As EventArgs) Handles btnGerarSAC.Click
        Try

            Call GerarSAC()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnRegistroAnterior_Click(sender As Object, e As EventArgs) Handles btnRegistroAnterior.Click
        Try
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_rnc_codigo " & btnSalvar.Tag & ", 1, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Editar(lCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnProximoRegistro_Click(sender As Object, e As EventArgs) Handles btnProximoRegistro.Click
        Try
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_rnc_codigo " & btnSalvar.Tag & ", 2, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Editar(lCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnUltimoRegistro_Click(sender As Object, e As EventArgs) Handles btnUltimoRegistro.Click
        Try
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_rnc_codigo " & btnSalvar.Tag & ", 3, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Call Editar(lCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdListagem_SizingColumn(sender As Object, e As SizingColumnEventArgs) Handles grdListagem.SizingColumn
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_ColumnMoved(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.ColumnMoved
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboGrupoNC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoNC.SelectedIndexChanged
        Try

            cboNaoConformidadeDetectada.SelectedIndex = -1

            If cboGrupoNC.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboNaoConformidadeDetectada, "sp_select_combo_familia_analise_rnc " & goUsuario.iEmpresa & " , " & cboGrupoNC.SelectedValue, False)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub txtOrdemProducao_TextChanged(sender As Object, e As EventArgs) Handles txtOrdemProducao.TextChanged
        Try

            Select Case txtOrdemProducao.Text
                Case "" : btnProsseguirProducao.Visible = False
                Case Else : btnProsseguirProducao.Visible = True
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnProsseguirProducao_Click(sender As Object, e As EventArgs) Handles btnProsseguirProducao.Click
        Try

            ProsseguirProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()



            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"

            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário


            If ValidacaoArquivo() = True Then

                Call SalvarArquivo(sDescricao:=txtDescricaoArquivo.Text,
                                   sArquivo:=txtArquivo.Text)

                'Carrega Grid
                Call oClsUsrQARNC.LoadGridArquivos(grdArquivo,
                                               btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoArquivo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            'Deleta Registros
            Call DeleteArquivo()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "editar" : Call EditarArquivo()
                Case "visualizar" : Call VisualizarDocumento(grdArquivo.CurrentRow.Cells("arquivo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: HISTORICO :::"

    Private Sub btnInserirHistorico_Click(sender As Object, e As EventArgs) Handles btnInserirHistorico.Click
        Try

            NovoHistorico()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario


            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnInserirArquivo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnProsseguirProducao.Enabled = VerificaDireito(9006, gcUpdate) 'QUALIDADE - REGISTRO DE NÃO CONFORMIDADE - PROSSEGUIR PRODUÇÃO

            'Carrega Combos
            LoadCombo(cboDisposicao, "sp_select_combo_static_disposicao_rnc")
            LoadCombo(cboFonte, "sp_select_combo_static_fonte_rnc")
            LoadCombo(cboResponsavel, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboAtendidoPorAcaoImediata, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboAnalisadoPorAnaliseCausa, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboResponsavelAcaoCorretiva, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboAutorizadoPorAcaoCorretiva, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboDisposicaoFiltro, "sp_select_combo_static_disposicao_rnc ", False)
            LoadCombo(cboStatus, "sp_select_combo_static_status_rnc")
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_rnc")
            LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina -1," & goUsuario.iEmpresa)
            LoadCombo(cboAbertoPor, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
            LoadCombo(cboOperacaoOrigemNC, "sp_select_combo_processo_rnc " & goUsuario.iEmpresa, False)
            LoadCombo(cboOperacao, "sp_select_combo_processo_rnc " & goUsuario.iEmpresa, False)
            LoadCombo(cboGrupoNC, "sp_select_combo_familia_rnc " & goUsuario.iEmpresa, False)
            LoadCombo(cboCausaRNC, "sp_select_combo_causa_rnc " & goUsuario.iEmpresa, False)
            LoadCombo(cboImpacto, "sp_select_combo_static_impacto_rnc")

            'Configura Datas
            dtpDataAcaoCorretiva.Value = Date.Now : dtpDataAcaoCorretiva.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)
            Call ConfiguraGrid(grdArquivo, iFormulario)

            'Remove Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroRNCFiltro.Focus()

            If Me.Tag.ToString.Contains("ID:") = True Then
                lCodigoRNC = Convert.ToInt64(Me.Tag.ToString.Replace("ID:", ""))
                Editar(lCodigoRNC)

                cboDisposicao.Focus()
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub NovoRegistroNaoConformidade()
        Try
            lCodigoOP = 0

            Dim oForm As New frmQAFindOPRNC
            oForm.ShowDialog()
            lCodigoOP = oForm.Codigo

            If lCodigoOP = 0 Then Exit Sub

            'Recebe o código criado
            lCodigoRNC = oClsUsrQARNC.InsertRegistroNaoConformidade(lCodigoOP)

            'Carrega o os controles
            Call Editar(lCodigoRNC)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsUsrQARNC.LoadGridRNC(oGrid:=grdListagem,
                                          sDataInicio:=IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""),
                                          sDataTermino:=IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""),
                                          sNumeroRNC:=txtNumeroRNCFiltro.Text.Trim,
                                          sOrdemProducao:=txtOrdemProducaoFiltro.Text.Trim,
                                          sItem:=txtItemFiltro.Text.Trim,
                                          iCodigoDisposicao:=cboDisposicaoFiltro.SelectedValue,
                                          iCodigoStatus:=cboStatusFiltro.SelectedValue)

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigoRNC As Long)

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Novo
                Call Novo()

                'Recebe o código do RNC editavel
                btnSalvar.Tag = lCodigoRNC

                Call oClsUsrQARNC.LoadControles(lCodigo:=btnSalvar.Tag,
                                                txtNumeroRNC:=txtNumeroRNC,
                                                dtpData:=dtpData,
                                                cboResponsavel:=cboResponsavel,
                                                cboFonte:=cboFonte,
                                                txtOrdemProducao:=txtOrdemProducao,
                                                txtItemNC:=txtItemNC,
                                                txtQtdNC:=txtQtdNC,
                                                cboImpacto:=cboImpacto,
                                                cboDisposicao:=cboDisposicao,
                                                txtDescricaoNC:=txtDescricaoNC,
                                                txtAnalise:=txtAnalise,
                                                txtQtdOP:=txtQtdOP,
                                                cboProcessoProdutivo:=cboOperacaoOrigemNC,
                                                cboProcessoProdutivoOrigem:=cboOperacao,
                                                cboFamiliaCausa:=cboGrupoNC,
                                                cboCausaRNC:=cboCausaRNC,
                                                cboAnaliseRNC:=cboNaoConformidadeDetectada,
                                                txtNumeroRI:=txtNumeroRI,
                                                txtCaracteristica:=txtCaracteristica,
                                                txtClasseTolerancia:=txtClasseTolerancia,
                                                txtEquipamento:=txtEquipamento,
                                                txtValorNominal:=txtValorNominal,
                                                txtToleranciaMin:=txtToleranciaMin,
                                                txtToleranciaMax:=txtToleranciaMax,
                                                txtValorMinimo:=txtValorMinimo,
                                                txtValorMaximo:=txtValorMaximo,
                                                txtValorEncontrado:=txtValorEncontrado,
                                                txtObservacaoCaracteristica:=txtObservacaoCaracteristica,
                                                txtSequenciaCaracteristica:=txtSequenciaCaracteristica,
                                                cboStatus:=cboStatus,
                                                cboMaquina:=cboMaquina,
                                                cboFuncionario:=cboAbertoPor,
                                                txtAcaoImediata:=txtAcaoImediata,
                                                cboAtendidoPorAcaoImediata:=cboAtendidoPorAcaoImediata,
                                                txtAnaliseCausa:=txtAnaliseCausa,
                                                cboAnalisadoPorAnaliseCausa:=cboAnalisadoPorAnaliseCausa,
                                                txtAcaoCorretiva:=txtAcaoCorretiva,
                                                cboResponsavelAcaoCorretiva:=cboResponsavelAcaoCorretiva,
                                                dtpDataAcaoCorretiva:=dtpDataAcaoCorretiva,
                                                cboAutorizadoPorAcaoCorretiva:=cboAutorizadoPorAcaoCorretiva,
                                                txtObservacaoConclusao:=txtObservacaoConclusao)

                Call oClsUsrQARNC.LoadGridArquivos(grdArquivo, btnSalvar.Tag)
                Call oClsUsrQARNC.LoadGridHistorico(grdHistorico, btnSalvar.Tag)


                If tabMain.SelectedTab.Name <> pagDados.Name Then
                    'Foca Aba
                    tabDados.SelectedTab = pagDescricaoRNC

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)
                End If

                cboFonte.Focus()
            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Valida os campos
            If Validacao() = False Then Exit Sub

            Call oClsUsrQARNC.UpdateRNC(lCodigo:=btnSalvar.Tag,
                                        iCodigoUsuarioResponsavel:=cboResponsavel.SelectedValue,
                                        iCodigoFonteRnc:=cboFonte.SelectedValue,
                                        dQuantidadeRnc:=txtQtdNC.Value,
                                        sDescricaoRnc:=txtDescricaoNC.Text.Trim,
                                        iCodigoDisposicaoRnc:=cboDisposicao.SelectedValue,
                                        iCodigoImpacto:=cboImpacto.SelectedValue,
                                        sAnaliseRnc:=txtAnalise.Text.Trim,
                                        iCodigoCentroCusto:=cboOperacaoOrigemNC.SelectedValue,
                                        iCodigoCentroCustoOrigem:=cboOperacao.SelectedValue,
                                        iCodigoCausa:=cboCausaRNC.SelectedValue,
                                        iCodigoAnalise:=cboNaoConformidadeDetectada.SelectedValue,
                                        iCodigoFamilia:=cboGrupoNC.SelectedValue,
                                        iCodigoStatus:=cboStatus.SelectedValue,
                                        iCodigoMaquina:=IIf(cboMaquina.SelectedIndex = -1, -1, cboMaquina.SelectedValue),
                                        iCodigoFuncionario:=IIf(cboAbertoPor.SelectedIndex = -1, -1, cboAbertoPor.SelectedValue),
                                        sAcaoImediata:=txtAcaoImediata.Text.Trim,
                                        iCodigoAtendidoPorAcaoImediata:=IIf(cboAtendidoPorAcaoImediata.SelectedIndex = -1, -1, cboAtendidoPorAcaoImediata.SelectedValue),
                                        sAnaliseCausa:=txtAnaliseCausa.Text.Trim,
                                        iCodigoAnalisadoPorAnaliseCausa:=IIf(cboAnalisadoPorAnaliseCausa.SelectedIndex = -1, -1, cboAnalisadoPorAnaliseCausa.SelectedValue),
                                        sAcaoCorretiva:=txtAcaoCorretiva.Text.Trim,
                                        iCodigoResponsavelAcaoCorretiva:=IIf(cboResponsavelAcaoCorretiva.SelectedIndex = -1, -1, cboResponsavelAcaoCorretiva.SelectedValue),
                                        sDataAcaoCorretiva:=IIf(dtpDataAcaoCorretiva.Checked = False, "", dtpDataAcaoCorretiva.Value),
                                        iCodigoAutorizadoPorAcaoCorretiva:=IIf(cboAutorizadoPorAcaoCorretiva.SelectedIndex = -1, -1, cboAutorizadoPorAcaoCorretiva.SelectedValue),
                                        sObservacaoConclusao:=txtObservacaoConclusao.Text.Trim)

            'Informa o usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            frmMain.errInfo.Clear()

            If ValidaCampo(cboResponsavel, lblResponsavel) = False Then Exit Function
            If ValidaCampo(cboFonte, lblFonte) = False Then Exit Function
            If ValidaCampo(txtQtdNC, lblQtdNC, True) = False Then Exit Function

            If txtQtdNC.Value > txtQtdOP.Value Then
                frmMain.errInfo.SetError(lblQtdNC, "A quantidade de itens NC é maior do que a quantidade da Ordem de Produção. Digite um valor válido para ele.")
                txtQtdNC.Focus()
                Exit Function
            End If

            If ValidaCampo(cboDisposicao, lblDisposicao) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function
            If ValidaCampo(cboImpacto, lblImpacto) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function
            If ValidaCampo(cboOperacaoOrigemNC, lblOperacaoOrigemNC) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function
            If ValidaCampo(cboOperacao, lblOperacao) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function
            If ValidaCampo(cboGrupoNC, lblGrupoNC) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function
            If ValidaCampo(cboCausaRNC, lblCausaNC) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function
            If ValidaCampo(cboNaoConformidadeDetectada, lblNaoConformidadeDetectada) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function
            If ValidaCampo(txtDescricaoNC, lblDescricaoNC, 2) = False Then tabDados.SelectedTab = pagDescricaoRNC : Exit Function


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Novo()

        Try

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnSalvar.Tag = ""

            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpCombosRNC)
            LimparCamposGroupBox(grpDescricaoRNC)
            LimparCamposGroupBox(grpAcaoImediata)
            LimparCamposGroupBox(grpAnaliseCausa)
            LimparCamposGroupBox(grpAcaoCorretiva)
            LimparCamposGroupBox(grpObservacaoConclusao)
            LimparCamposGroupBox(grpCaracteristicas)

            txtOrdemProducao.Tag = ""

            'Limpa Arquivo
            Call NovoArquivo()

            'Limpa Grid
            grdArquivo.DataSource = Nothing
            grdHistorico.DataSource = Nothing

            'Seta Focus
            cboFonte.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRNC()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrQARNC.DeleteRNC()

                    LoadGrid()

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

    Private Sub GerarSAC()

        Try

            Dim lCodigoSAC As Long

            If MsgBox("Deseja gerar SAC para esse RNC?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            'Gera um SAC e salva o codigo do mesmo, usando o codigo da RNC
            lCodigoSAC = oClsUsrQARNC.InsertSAC(btnSalvar.Tag)

            EditarSAC(lCodigoSAC)

            frmMain.Informacao("Registro de SAC gerado com sucesso.", Drawing.Color.AliceBlue)

            LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarSAC(lCodigoSAC As Long)
        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrQASAC")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(lCodigoSAC)

            frmMain.LoadPage("Qualidade - SAC", "Qualidade - Solicitação de Ação Corretiva", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ProsseguirProducao()

        Try

            Cursor.Current = Cursors.WaitCursor

            If MsgBox("Deseja Prosseguir Produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            oClsUsrQARNC.UpdateProsseguirProducao(txtOrdemProducao.Tag,
                                                  btnSalvar.Tag)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"
    Private Sub SalvarArquivo(ByVal sDescricao As String,
                              ByVal sArquivo As String)

        Try

            Dim sArquivoServidor As String
            Dim nomeArquivo As String = Path.GetFileName(sArquivo)
            Dim dataHoraAtual As String = Now.ToString("dd-MM-yyyy_HH-mm-ss")

            'Carrega Pasta de Arquivo
            sArquivoServidor = LoadCodigo("sp_load_pasta_arquivo_qualidade " & goUsuario.iEmpresa)

            'Faz a copia do arquivo para o servidor e obtem o caminho
            If sArquivoServidor = "" Then
                Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            ElseIf Directory.Exists(sArquivoServidor) = False Then
                Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
            Else
                sArquivoServidor = Path.Combine(sArquivoServidor, "RNC_" & btnSalvar.Tag & "_" & dataHoraAtual & "_" & nomeArquivo)
                File.Copy(sArquivo, sArquivoServidor)
            End If


            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirArquivo.Tag) Then

                'Atualiza Registro
                Call oClsUsrQARNC.UpdateArquivo(lCodigoRNC:=btnSalvar.Tag,
                                                sDescricao:=sDescricao,
                                                sArquivo:=sArquivoServidor,
                                                iCodigoArquivo:=btnInserirArquivo.Tag)
            Else

                'Insere Registro
                Call oClsUsrQARNC.InsertArquivo(lCodigoRNC:=btnSalvar.Tag,
                                                sArquivo:=sArquivoServidor,
                                                sDescricao:=sDescricao)
            End If


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

                    'Exclui Registro
                    Call oClsUsrQARNC.DeleteArquivo(btnSalvar.Tag)

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

    Private Sub EditarArquivo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles

                txtArquivo.Text = grdArquivo.CurrentRow.Cells("arquivo").Value
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.Cells("codigo").Value

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles          
            txtDescricaoArquivo.Text = ""
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            txtDescricaoArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoArquivo = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If


            'Verifica se o Produto é Válido
            If IsNumeric(btnInserirArquivo.Tag) Then
                If VerificaExisteValorGrid(grdArquivo, "arquivo", txtArquivo.Text.Trim, grdArquivo.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblArquivo, "Este Arquivo: " & txtArquivo.Text & " já está associado ao Registro: " & txtNumeroRNC.Text.Trim & ".")
                    btnProcurarArquivo.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdArquivo, "arquivo", txtArquivo.Text.Trim, -1) Then
                    frmMain.errInfo.SetError(lblArquivo, "Este Arquivo: " & txtArquivo.Text & " já está associado ao Registro: " & txtNumeroRNC.Text.Trim & ".")
                    btnProcurarArquivo.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoArquivo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub VisualizarDocumento(ByVal sArquivo As String)

        Try

            'Verifica se foi Informado o Arquivo
            If sArquivo = "" Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

            Else

                'Verifica se o Arquivo Existe
                If File.Exists(sArquivo) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(sArquivo)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub




#End Region

#Region "::: HISTORICO :::"

    Private Sub NovoHistorico()
        Try

            Dim sInputBox As String = InputBox("Digite o histórico:", "Histórico")

            If sInputBox = "" Then Exit Sub

            oClsUsrQARNC.InsertHistorico(btnSalvar.Tag, sInputBox)

            frmMain.Informacao("Histórico inserido com sucesso!", Color.Blue)

            oClsUsrQARNC.LoadGridHistorico(grdHistorico, btnSalvar.Tag)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub



#End Region

#End Region


End Class
