Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.Data.SqlClient
Imports System.IO

Public Class usrQASAC

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrQASAC As New clsUsrQASAC
    Private iFormulario As Integer
    Private lCodigoSAC As Long
    Private lCodigoRNC As Long
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

    Private Sub btnNovoSAC_Click(sender As Object, e As EventArgs) Handles btnNovoSAC.Click
        Try
            NovoSAC()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub


    Private Sub btnNovoSACDados_Click(sender As Object, e As EventArgs) Handles btnNovoSACDados.Click
        Try
            NovoSAC()

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
            txtNumeroSACFiltro.Focus()

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
                If MsgBox("Deseja Salvar a Solicitação de Ação Corretiva?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

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

    Private Sub btnExcluirSAC_Click(sender As Object, e As EventArgs) Handles btnExcluirSAC.Click
        Try

            'Deleta Registros
            Call DeleteSAC()

            'Prepara Formulário para Inserção de um Novo Registro
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved,
                                                                                                                   grdRiscosOportunidades.ColumnMoved,
                                                                                                                   grdReacoes.ColumnMoved,
                                                                                                                   grdAcoesCorretivas.ColumnMoved,
                                                                                                                   grdHistorico.ColumnMoved,
                                                                                                                   grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn,
                                                                                                                    grdRiscosOportunidades.SizingColumn,
                                                                                                                    grdReacoes.SizingColumn,
                                                                                                                    grdHistorico.SizingColumn,
                                                                                                                    grdAcoesCorretivas.SizingColumn,
                                                                                                                    grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub btnRegistroAnterior_Click(sender As Object, e As EventArgs) Handles btnRegistroAnterior.Click
        Try
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_sac_codigo " & btnSalvar.Tag & ", 1, " & goUsuario.iEmpresa)

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
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_sac_codigo " & btnSalvar.Tag & ", 2, " & goUsuario.iEmpresa)

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
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_sac_codigo " & btnSalvar.Tag & ", 3, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Call Editar(lCodigo)

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
                Call oClsUsrQASAC.LoadGridArquivos(grdArquivo, btnSalvar.Tag)

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


#End Region

#Region "::: REAÇÕES À NÃO CONFORMIDADE :::"

    Private Sub btnInserirReacoes_Click(sender As Object, e As EventArgs) Handles btnInserirReacoes.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário


            If ValidacaoReacoes() = True Then

                Call SalvarReacao()

                'Carrega Grid
                Call oClsUsrQASAC.LoadGridReacao(grdReacoes, btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovaReacao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirReacoes_Click(sender As Object, e As EventArgs) Handles btnExcluirReacoes.Click
        Try

            'Deleta Registros
            Call DeleteReacao()

            'Prepara Formulário para Inserção de um Novo Registro
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdReacoes_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdReacoes.RowDoubleClick
        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdReacoes.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdReacoes.CurrentColumn.Key

                Case "editar" : Call EditarReacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#Region "::: AÇÕES CORRETIVAS :::"

    Private Sub btnInserirAcoesCorretivas_Click(sender As Object, e As EventArgs) Handles btnInserirAcoesCorretivas.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário


            If ValidacaoAcaoCorretiva() = True Then

                Call SalvarAcaoCorretiva()

                'Carrega Grid
                Call oClsUsrQASAC.LoadGridAcoesCorretivas(grdAcoesCorretivas, btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovaAcaoCorretiva()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirAcoesCorretivas_Click(sender As Object, e As EventArgs) Handles btnExcluirAcoesCorretivas.Click
        Try

            'Deleta Registros
            Call DeleteAcaoCorretiva()

            'Prepara Formulário para Inserção de um Novo Registro
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdAcoesCorretivas_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdAcoesCorretivas.RowDoubleClick
        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdAcoesCorretivas.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdAcoesCorretivas.CurrentColumn.Key

                Case "editar" : Call EditarAcaoCorretiva()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#Region "::: RISCOS E/OU OPORTUNIDADES :::"
    Private Sub btnInserirRiscosOportunidades_Click(sender As Object, e As EventArgs) Handles btnInserirRiscosOportunidades.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário


            If ValidacaoRiscoOportunidade() = True Then

                Call SalvarRiscoOportunidade()

                'Carrega Grid
                Call oClsUsrQASAC.LoadGridRiscosOportunidades(grdRiscosOportunidades, btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoRiscoOportunidade()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirRiscosOportunidades_Click(sender As Object, e As EventArgs) Handles btnExcluirRiscosOportunidades.Click
        Try

            'Deleta Registros
            Call DeleteRiscoOportunidade()

            'Prepara Formulário para Inserção de um Novo Registro
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdRiscosOportunidades_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdRiscosOportunidades.RowDoubleClick
        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdRiscosOportunidades.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdRiscosOportunidades.CurrentColumn.Key

                Case "editar" : Call EditarRiscoOportunidade()

            End Select

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
            btnInserirReacoes.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirReacoes.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnInserirAcoesCorretivas.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirAcoesCorretivas.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnInserirRiscosOportunidades.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirRiscosOportunidades.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnInserirHistorico.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadCombo(cboEmissor, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboTipoNC, "sp_select_combo_qa_sac_tipos_nc", False)
            LoadCombo(cboSituacao, "sp_select_combo_qa_sac_situacao", False)
            LoadCombo(cboResponsavelDescricao, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboResponsavelReacoes, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboResponsavelExtencao, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboSituacaoReacoes, "sp_select_combo_qa_sac_situacao", False)
            LoadCombo(cboResponsavelAnaliseCausa, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboResponsavelAnaliseCausa, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboSituacaoAcoesCorretivas, "sp_select_combo_qa_sac_situacao", False)
            LoadCombo(cboResponsavelResultados, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboResponsavelAnaliseCritica, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadComboSimNao(cboSatisfatoriaAnaliseCritica)
            LoadCombo(cboResponsavelRiscosOportunidades, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)
            Call ConfiguraGrid(grdArquivo, iFormulario)
            Call ConfiguraGrid(grdReacoes, iFormulario)
            Call ConfiguraGrid(grdAcoesCorretivas, iFormulario)
            Call ConfiguraGrid(grdRiscosOportunidades, iFormulario)
            Call ConfiguraGrid(grdHistorico, iFormulario)

            'Configura datas
            dtpDataInicioFiltro.Value = Now.Date
            dtpDataTerminoFiltro.Value = Now.Date
            dtpPrazoReacoes.Value = Now.Date
            dtpDataExtensao.Value = Now.Date
            dtpDataAnaliseCausa.Value = Now.Date
            dtpPrazoAcoesCorretivas.Value = Now.Date
            dtpDataResultados.Value = Now.Date
            dtpDataAnaliseCritica.Value = Now.Date
            dtpDataRiscosOportunidades.Value = Now.Date

            'Remove Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroSACFiltro.Focus()

            If Me.Tag.ToString.Contains("ID:") = True Then
                lCodigoSAC = Convert.ToInt64(Me.Tag.ToString.Replace("ID:", ""))
                Editar(lCodigoSAC)

                cboTipoNC.Focus()
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

    Private Sub NovoSAC()
        Try
            lCodigoRNC = 0

            Dim oForm As New frmQAFindOPSAC
            oForm.ShowDialog()
            lCodigoRNC = oForm.Codigo

            If lCodigoRNC = 0 Then Exit Sub

            'Abre o SAC usando o Codigo da RNC
            lCodigoSAC = oClsUsrQASAC.InsertSAC(lCodigoRNC)

            'Carrega o os controles
            Call Editar(lCodigoSAC)

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
            Call oClsUsrQASAC.LoadGridSAC(oGrid:=grdListagem,
                                          sDataInicio:=IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""),
                                          sDataTermino:=IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""),
                                          sNumeroSAC:=txtNumeroSACFiltro.Text.Trim,
                                          sOrdemProducao:=txtOrdemProducaoFiltro.Text.Trim,
                                          sItem:=txtItemFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigoSAC As Long)

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Novo
                Call Novo()

                'Recebe o código do RNC editavel
                btnSalvar.Tag = lCodigoSAC

                Call oClsUsrQASAC.LoadControles(lCodigo:=btnSalvar.Tag,
                                                txtNumeroSAC:=txtNumeroSAC,
                                                txtOrdemProducao:=txtOrdemProducao,
                                                txtNumeroRNC:=txtNumeroRNC,
                                                txtItem:=txtItem,
                                                txtQtdNC:=txtQtdNC,
                                                dtpData:=dtpData,
                                                cboEmissor:=cboEmissor,
                                                cboTipoNC:=cboTipoNC,
                                                txtOrigem:=txtOrigem,
                                                txtQtdSAC:=txtQtdSAC,
                                                cboSituacao:=cboSituacao,
                                                cboResponsavelDescricao:=cboResponsavelDescricao,
                                                dtpDataDescricao:=dtpDataDescricao,
                                                txtRequisitoDescricao:=txtRequisitoDescricao,
                                                txtDesvioDescricao:=txtDesvioDescricao,
                                                txtEvidenciaDescricao:=txtEvidenciaDescricao,
                                                cboResponsavelExtencao:=cboResponsavelExtencao,
                                                dtpDataExtensao:=dtpDataExtensao,
                                                txtExtencaoNC:=txtExtencaoNC,
                                                cboResponsavelAnaliseCausa:=cboResponsavelAnaliseCausa,
                                                dtpDataAnaliseCausa:=dtpDataAnaliseCausa,
                                                txtAnaliseCausa:=txtAnaliseCausa,
                                                cboResponsavelResultados:=cboResponsavelResultados,
                                                dtpDataResultados:=dtpDataResultados,
                                                txtResultados:=txtResultados,
                                                cboResponsavelAnaliseCritica:=cboResponsavelAnaliseCritica,
                                                dtpDataAnaliseCritica:=dtpDataAnaliseCritica,
                                                cboSatisfatoriaAnaliseCritica:=cboSatisfatoriaAnaliseCritica,
                                                txtAnaliseCritica:=txtAnaliseCritica)


                Call oClsUsrQASAC.LoadGridArquivos(grdArquivo, btnSalvar.Tag)
                Call oClsUsrQASAC.LoadGridReacao(grdReacoes, btnSalvar.Tag)
                Call oClsUsrQASAC.LoadGridAcoesCorretivas(grdAcoesCorretivas, btnSalvar.Tag)
                Call oClsUsrQASAC.LoadGridRiscosOportunidades(grdRiscosOportunidades, btnSalvar.Tag)
                Call oClsUsrQASAC.LoadGridHistorico(grdHistorico, btnSalvar.Tag)

                If tabMain.SelectedTab.Name <> pagDados.Name Then
                    'Foca Aba
                    tabDados.SelectedTab = pagDescricaoSAC
                    cboTipoNC.Focus()

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)
                End If

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
            'Atualiza 
            Call oClsUsrQASAC.UpdateSAC(lCodigo:=btnSalvar.Tag,
                                        sData:=dtpData.Value,
                                        iEmissor:=cboEmissor.SelectedValue,
                                        iTipoNC:=cboTipoNC.SelectedValue,
                                        sOrigem:=txtOrigem.Text.Trim,
                                        dQtdSAC:=txtQtdSAC.Value,
                                        iSituacao:=cboSituacao.SelectedValue,
                                        iResponsavelDescricao:=cboResponsavelDescricao.SelectedValue,
                                        sDataDescricao:=IIf(dtpDataDescricao.Checked = True, dtpDataDescricao.Value, ""),
                                        sRequisitoDescricao:=txtRequisitoDescricao.Text.Trim,
                                        sDesvioDescricao:=txtDesvioDescricao.Text.Trim,
                                        sEvidenciaDescricao:=txtEvidenciaDescricao.Text.Trim,
                                        iResponsavelExtencao:=IIf(cboResponsavelExtencao.SelectedValue = 0, -1, cboResponsavelExtencao.SelectedValue),
                                        sDataExtensao:=IIf(dtpDataExtensao.Checked = True, dtpDataExtensao.Value, ""),
                                        sExtencaoNC:=txtExtencaoNC.Text.Trim,
                                        iResponsavelAnaliseCausa:=IIf(cboResponsavelAnaliseCausa.SelectedValue = 0, -1, cboResponsavelAnaliseCausa.SelectedValue),
                                        sDataAnaliseCausa:=IIf(dtpDataAnaliseCausa.Checked = True, dtpDataAnaliseCausa.Value, ""),
                                        sAnaliseCausa:=txtAnaliseCausa.Text.Trim,
                                        iResponsavelResultados:=IIf(cboResponsavelResultados.SelectedValue = 0, -1, cboResponsavelResultados.SelectedValue),
                                        sDataResultados:=IIf(dtpDataResultados.Checked = True, dtpDataResultados.Value, ""),
                                        sResultados:=txtResultados.Text.Trim,
                                        iResponsavelAnaliseCritica:=IIf(cboResponsavelAnaliseCritica.SelectedValue = 0, -1, cboResponsavelAnaliseCritica.SelectedValue),
                                        sDataAnaliseCritica:=IIf(dtpDataAnaliseCritica.Checked = True, dtpDataAnaliseCritica.Value, ""),
                                        bSatisfatoriaAnaliseCritica:=IIf(cboSatisfatoriaAnaliseCritica.SelectedValue = 0, -1, cboSatisfatoriaAnaliseCritica.SelectedValue),
                                        sAnaliseCritica:=txtAnaliseCritica.Text.Trim)

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

            If ValidaCampo(cboEmissor, lblEmissor) = False Then Exit Function
            If ValidaCampo(cboTipoNC, lblTipoNC) = False Then Exit Function
            If ValidaCampo(txtOrigem, lblOrigem, 2) = False Then Exit Function
            If ValidaCampo(txtQtdSAC, lblQtdSAC, True) = False Then Exit Function
            If txtQtdSAC.Value > txtQtdNC.Value Then
                frmMain.errInfo.SetError(lblQtdSAC, "A quantidade de itens SAC é maior do que a quantidade da RNC. Digite um valor válido para ele.")
                txtQtdSAC.Focus()
                Exit Function
            End If
            If ValidaCampo(cboSituacao, lblSituacao) = False Then Exit Function
            If ValidaCampo(cboResponsavelDescricao, lblResponsavelDescricao) = False Then tabDados.SelectedTab = pagDescricaoSAC : Exit Function
            If ValidaCampo(txtRequisitoDescricao, lblRequisitoDescricao, 2) = False Then tabDados.SelectedTab = pagDescricaoSAC : Exit Function
            If ValidaCampo(txtDesvioDescricao, lblDesvioDescricao, 2) = False Then tabDados.SelectedTab = pagDescricaoSAC : Exit Function
            If ValidaCampo(txtEvidenciaDescricao, lblEvidenciaDescricao, 2) = False Then tabDados.SelectedTab = pagDescricaoSAC : Exit Function

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

            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpDescricaoSAC)
            LimparCamposGroupBox(grpExtensao)
            LimparCamposGroupBox(grpAnaliseCausa)
            LimparCamposGroupBox(grpResultados)
            LimparCamposGroupBox(grpAnaliseCritica)

            Call NovoArquivo()
            Call NovaReacao()
            Call NovaAcaoCorretiva()
            Call NovoRiscoOportunidade()

            'Limpa Grids
            grdHistorico.DataSource = Nothing
            grdArquivo.DataSource = Nothing
            grdReacoes.DataSource = Nothing
            grdAcoesCorretivas.DataSource = Nothing
            grdRiscosOportunidades.DataSource = Nothing
            grdHistorico.DataSource = Nothing

            'Seta Focus
            cboTipoNC.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteSAC()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrQASAC.DeleteSAC()

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
                sArquivoServidor = Path.Combine(sArquivoServidor, "SAC_" & btnSalvar.Tag & "_" & dataHoraAtual & "_" & nomeArquivo)
                File.Copy(sArquivo, sArquivoServidor)
            End If


            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirArquivo.Tag) Then

                'Atualiza Registro
                Call oClsUsrQASAC.UpdateArquivo(lCodigoSAC:=btnSalvar.Tag,
                                                sDescricao:=sDescricao,
                                                sArquivo:=sArquivoServidor,
                                                iCodigoArquivo:=btnInserirArquivo.Tag)
            Else

                'Insere Registro
                Call oClsUsrQASAC.InsertArquivo(lCodigoSAC:=btnSalvar.Tag,
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
                    Call oClsUsrQASAC.DeleteArquivo(btnSalvar.Tag)

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
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""


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

            If IsNumeric(btnInserirArquivo.Tag) Then
                If VerificaExisteValorGrid(grdArquivo, "arquivo", txtArquivo.Text.Trim, grdArquivo.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblArquivo, "Este Arquivo: " & txtArquivo.Text & " já está associado ao Registro: " & txtNumeroSAC.Text.Trim & ".")
                    btnProcurarArquivo.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdArquivo, "arquivo", txtArquivo.Text.Trim, -1) Then
                    frmMain.errInfo.SetError(lblArquivo, "Este Arquivo: " & txtArquivo.Text & " já está associado ao Registro: " & txtNumeroSAC.Text.Trim & ".")
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

#Region "::: REAÇÕES À NÃO CONFORMIDADE :::"
    Private Sub NovaReacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpReacao)
            btnInserirReacoes.Tag = ""


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoReacoes() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoReacoes = False

            If ValidaCampo(cboResponsavelReacoes, lblResponsavelReacoes) = False Then Exit Function
            If ValidaCampo(cboSituacaoReacoes, lblSituacaoReacao) = False Then Exit Function
            If ValidaCampo(txtAcaoContencaoReacoes, lblAcaoCorrecaoReacoes, 2) = False Then Exit Function

            'Seta Retorno da Função
            ValidacaoReacoes = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarReacao()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirReacoes.Tag) Then

                'Atualiza Registro
                Call oClsUsrQASAC.UpdateReacao(lCodigoSAC:=btnSalvar.Tag,
                                               iResponsavel:=cboResponsavelReacoes.SelectedValue,
                                               sPrazo:=dtpPrazoReacoes.Value,
                                               iSituacao:=cboSituacaoReacoes.SelectedValue,
                                               sAcaoContencaoReacoes:=txtAcaoContencaoReacoes.Text.Trim,
                                               iCodigoReaco:=btnInserirReacoes.Tag)
            Else

                'Insere Registro
                Call oClsUsrQASAC.InsertReacao(lCodigoSAC:=btnSalvar.Tag,
                                               iResponsavel:=cboResponsavelReacoes.SelectedValue,
                                               sPrazo:=dtpPrazoReacoes.Value,
                                               iSituacao:=cboSituacaoReacoes.SelectedValue,
                                               sAcaoContencaoReacoes:=txtAcaoContencaoReacoes.Text.Trim)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteReacao()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdReacoes) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrQASAC.DeleteReacao(btnSalvar.Tag)

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

    Private Sub EditarReacao()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                Call NovaReacao()

                'Carrega Controles
                cboResponsavelReacoes.SelectedValue = grdReacoes.CurrentRow.Cells("codigo_usuario").Value
                dtpPrazoReacoes.Value = grdReacoes.CurrentRow.Cells("prazo").Value
                cboSituacaoReacoes.SelectedValue = grdReacoes.CurrentRow.Cells("codigo_situacao").Value
                txtAcaoContencaoReacoes.Text = grdReacoes.CurrentRow.Cells("descricao").Value
                btnInserirReacoes.Tag = grdReacoes.CurrentRow.Cells("codigo").Value

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: AÇÕES CORRETIVAS :::"
    Private Sub NovaAcaoCorretiva()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpAcaoCorretiva)
            txtAcoesCorretivas.Text = ""


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoAcaoCorretiva() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoAcaoCorretiva = False

            If ValidaCampo(txtResponsaveis, lblResponsavelAcoesCorretivas, 2) = False Then Exit Function
            If ValidaCampo(cboSituacaoAcoesCorretivas, lblSituacaoAcoesCorretivas) = False Then Exit Function
            If ValidaCampo(txtAcoesCorretivas, lblAcoesCorretivas, 2) = False Then Exit Function

            'Seta Retorno da Função
            ValidacaoAcaoCorretiva = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarAcaoCorretiva()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirAcoesCorretivas.Tag) Then

                'Atualiza Registro
                Call oClsUsrQASAC.UpdateAcoesCorretivas(lCodigoSAC:=btnSalvar.Tag,
                                                         sResponsavel:=txtResponsaveis.Text.Trim,
                                                         sPrazo:=dtpPrazoAcoesCorretivas.Value,
                                                         iSituacao:=cboSituacaoAcoesCorretivas.SelectedValue,
                                                         sAcoesCorretivas:=txtAcoesCorretivas.Text.Trim,
                                                         iCodigoAcao:=btnInserirAcoesCorretivas.Tag)
            Else

                'Insere Registro
                Call oClsUsrQASAC.InsertAcoesCorretivas(lCodigoSAC:=btnSalvar.Tag,
                                                         sResponsavel:=txtResponsaveis.Text.Trim,
                                                         sPrazo:=dtpPrazoAcoesCorretivas.Value,
                                                         iSituacao:=cboSituacaoAcoesCorretivas.SelectedValue,
                                                         sAcoesCorretivas:=txtAcoesCorretivas.Text.Trim)


            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteAcaoCorretiva()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdAcoesCorretivas) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrQASAC.DeleteAcaoCorretiva(btnSalvar.Tag)

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

    Private Sub EditarAcaoCorretiva()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                Call NovaAcaoCorretiva()

                'Carrega Controles
                txtResponsaveis.Text = grdAcoesCorretivas.CurrentRow.Cells("responsavel").Value
                dtpPrazoAcoesCorretivas.Value = grdAcoesCorretivas.CurrentRow.Cells("prazo").Value
                cboSituacaoAcoesCorretivas.SelectedValue = grdAcoesCorretivas.CurrentRow.Cells("codigo_situacao").Value
                txtAcoesCorretivas.Text = grdAcoesCorretivas.CurrentRow.Cells("descricao").Value
                btnInserirAcoesCorretivas.Tag = grdAcoesCorretivas.CurrentRow.Cells("codigo").Value

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: RISCOS E/OU OPORTUNIDADES :::"
    Private Sub NovoRiscoOportunidade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles

            LimparCamposGroupBox(grpRiscos)
            btnInserirRiscosOportunidades.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRiscoOportunidade() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRiscoOportunidade = False

            If ValidaCampo(cboResponsavelRiscosOportunidades, lblResponsavelRiscosOportunidades) = False Then Exit Function
            If ValidaCampo(txtRiscosOportunidades, lblRiscosOportunidades, 2) = False Then Exit Function

            'Seta Retorno da Função
            ValidacaoRiscoOportunidade = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarRiscoOportunidade()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirRiscosOportunidades.Tag) Then

                'Atualiza Registro
                Call oClsUsrQASAC.UpdateRiscosOportunidades(lCodigoSAC:=btnSalvar.Tag,
                                                            sResponsavel:=cboResponsavelRiscosOportunidades.SelectedValue,
                                                            sData:=dtpDataRiscosOportunidades.Value,
                                                            sRiscosOportunidades:=txtRiscosOportunidades.Text.Trim,
                                                            iCodigoRiscoOportunidade:=btnInserirRiscosOportunidades.Tag)
            Else

                'Insere Registro
                Call oClsUsrQASAC.InsertRiscosOportunidades(lCodigoSAC:=btnSalvar.Tag,
                                                            sResponsavel:=cboResponsavelRiscosOportunidades.SelectedValue,
                                                            sData:=dtpDataRiscosOportunidades.Value,
                                                            sRiscosOportunidades:=txtRiscosOportunidades.Text.Trim)


            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRiscoOportunidade()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdRiscosOportunidades) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrQASAC.DeleteRiscoOportunidade(btnSalvar.Tag)

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

    Private Sub EditarRiscoOportunidade()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoRiscoOportunidade()

                'Carrega Controles
                cboResponsavelRiscosOportunidades.SelectedValue = grdRiscosOportunidades.CurrentRow.Cells("codigo_usuario").Value
                dtpDataRiscosOportunidades.Value = grdRiscosOportunidades.CurrentRow.Cells("data").Value
                txtRiscosOportunidades.Text = grdRiscosOportunidades.CurrentRow.Cells("descricao").Value
                btnInserirRiscosOportunidades.Tag = grdRiscosOportunidades.CurrentRow.Cells("codigo").Value

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
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

            oClsUsrQASAC.InsertHistorico(btnSalvar.Tag, sInputBox)

            frmMain.Informacao("Histórico inserido com sucesso!", Color.Blue)

            oClsUsrQASAC.LoadGridHistorico(grdHistorico, btnSalvar.Tag)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

End Class
