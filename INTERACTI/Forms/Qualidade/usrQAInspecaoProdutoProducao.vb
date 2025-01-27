Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO

Public Class usrQAInspecaoProdutoProducao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsQAInspecaoProdutoProducao As New clsUsrQAInspecaoProdutoProducao

#End Region

#Region "::: ENUM :::"

    'Status de Qualidade
    Private Enum StatusQualidade
        Aprovado = 1
        Reprovado = 2
    End Enum

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrQAInspecaoProdutoProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
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

    Private Sub usrQAInspecaoProdutoProducao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrQAEntradaNotaFiscal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: QUALIDADE :::"

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.QualidadeInspecaoProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.QualidadeInspecaoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridQualidadeSimNao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridQualidadeSimNao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdQualidadeSimNao
            oForm.NomeFormulario = Formulario.QualidadeInspecaoProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidadeSimNao, Formulario.QualidadeInspecaoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridQualidadeValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridQualidadeValor.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdQualidadeValor
            oForm.NomeFormulario = Formulario.QualidadeInspecaoProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidadeValor, Formulario.QualidadeInspecaoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

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
                If MsgBox("Deseja Salvar a Inspeção de Qualidade?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Salva Dados de Qualidade
                    Call Salvar()

                    'Desabilita Controles
                    btnSalvar.Enabled = False

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 1
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
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

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.QualidadeInspecaoProducao, _
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
                                     Formulario.QualidadeInspecaoProducao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.QualidadeInspecaoProducao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidadeValor_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidadeValor.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidadeValor.Name, _
                                     Formulario.QualidadeInspecaoProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidadeValor_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdQualidadeValor.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidadeValor, _
                                     Formulario.QualidadeInspecaoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidadeSimNao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidadeSimNao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidadeSimNao.Name, _
                                     Formulario.QualidadeInspecaoProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidadeSimNao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdQualidadeSimNao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidadeSimNao, _
                                     Formulario.QualidadeInspecaoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.QualidadeInspecaoProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.QualidadeInspecaoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivo.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo Máquina
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivo.SelectedValue)
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

                'Váriaveis
                Dim sDescricaoAntigo As String = ""

                'Seta Váriavel
                If IsNumeric(btnInserirArquivo.Tag) Then
                    sDescricaoAntigo = grdArquivo.CurrentRow.Cells("descricao").Value
                End If

                'Insere Arquivo
                Call InsertArquivo(grdArquivo, _
                                   cboTipoArquivo.Text, _
                                   IIf(cboCaracteristicasInspecionar.SelectedIndex = -1, "", cboCaracteristicasInspecionar.Text), _
                                   txtDescricaoArquivo.Text.Trim, _
                                   txtArquivo.Text.Trim, _
                                   cboTipoArquivo.SelectedValue, _
                                   IIf(cboCaracteristicasInspecionar.SelectedIndex = -1, -1, cboCaracteristicasInspecionar.SelectedValue), _
                                   sDescricaoAntigo)

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

    Private Sub cboTipoArquivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

        Try

            'Limpa Controle
            txtArquivo.Text = ""

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
                Case "visualizar" : Call VisualizarDocumento(grdArquivo.CurrentRow.Cells("arquivo_interacti").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.QualidadeInspecaoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.QualidadeInspecaoProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrQAInspecaoProdutoProducao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.QualidadeInspecaoProducao, gcInsert)
            btnExcel.Enabled = VerificaDireito(Formulario.QualidadeInspecaoProducao, gcPrint)
            btnInserirArquivo.Enabled = VerificaDireito(Formulario.QualidadeInspecaoProducao, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(Formulario.QualidadeInspecaoProducao, gcDelete)

            'Verifica Direito - Cadastrar
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Oculta Controle
            lblStatus.Visible = False

            'Carrega ComboBox
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroTrabalhoFiltro, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
            Call LoadCombo(cboOperacaoFiltro, "sp_select_combo_cadastro_basico_operacao " & goUsuario.iEmpresa & ", -1")
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Carrega Combo Status
            cboStatus.Items.Add("APROVADO", StatusQualidade.Aprovado)
            cboStatus.Items.Add("REPROVADO", StatusQualidade.Reprovado)

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.QualidadeInspecaoProducao)
            Call ConfiguraGrid(grdQualidadeSimNao, Formulario.QualidadeInspecaoProducao)
            Call ConfiguraGrid(grdQualidadeValor, Formulario.QualidadeInspecaoProducao)
            Call ConfiguraGrid(grdArquivo, Formulario.QualidadeInspecaoProducao)

            'Remove Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsQAInspecaoProdutoProducao.LoadGridOrdemProducao(grdListagem, _
                                                                     txtNumeroDocumentoFiltro.Text.Trim, _
                                                                     IIf(IsNumeric(txtSequenciaFiltro.Text.Trim), txtSequenciaFiltro.Text.Trim, -1), _
                                                                     IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue), _
                                                                     IIf(cboOperacaoFiltro.SelectedIndex = -1, -1, cboOperacaoFiltro.SelectedValue), _
                                                                     txtProdutoFiltro.Text.Trim, _
                                                                     IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                                                     IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.QualidadeInspecaoProducao, gcInsert) = True Then

                'Novo
                Call Novo()

                'Carrega Controles
                txtOrdemProducao.Text = grdListagem.CurrentRow.Cells("ordem_producao").Value
                txtSequencia.Text = grdListagem.CurrentRow.Cells("sequencia").Value
                txtCentroTrabalho.Text = grdListagem.CurrentRow.Cells("centro_trabalho").Value & " - " & grdListagem.CurrentRow.Cells("descricao_centro_trabalho").Value
                txtOperacao.Text = grdListagem.CurrentRow.Cells("operacao").Value & " - " & grdListagem.CurrentRow.Cells("descricao_operacao").Value
                txtProduto.Text = grdListagem.CurrentRow.Cells("codigo_produto").Value + " - " + grdListagem.CurrentRow.Cells("descricao").Value
                txtData.Text = grdListagem.CurrentRow.Cells("data").Value
                txtQuantidade.Value = grdListagem.CurrentRow.Cells("quantidade").Value - (grdListagem.CurrentRow.Cells("quantidade_aprovada").Value + grdListagem.CurrentRow.Cells("quantidade_reprovada").Value)

                'Carrega ComboBox 
                Call LoadCombo(cboCaracteristicasInspecionar, "sp_select_combo_qualidade_inspecao_producao_caracteristicas_inspecionar " & grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value & ", " & grdListagem.CurrentRow.Cells("sequencia").Value & ", " & goUsuario.iEmpresa, False)

                'Carrega Grid de QualidadeEntradaNF - Inspeção (Valor)
                Call oClsQAInspecaoProdutoProducao.LoadGridQualidadeInspecao(grdQualidadeValor, _
                                                                             grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                             grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                             QualidadeTipoCaracteristicaInspecionar.Valor)

                'Carrega Grid de QualidadeEntradaNF - Inspeção (Sim / Não)
                Call oClsQAInspecaoProdutoProducao.LoadGridQualidadeInspecao(grdQualidadeSimNao, _
                                                                             grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                             grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                             QualidadeTipoCaracteristicaInspecionar.SimNao)

                'Verifica se será necessário selecionar o Status
                If grdQualidadeValor.GetDataRows.Count = 0 And grdQualidadeSimNao.GetDataRows.Count = 0 Then
                    cboStatus.Visible = True
                    lblStatus.Visible = True
                Else
                    cboStatus.Visible = False
                    lblStatus.Visible = False
                End If

                'Foca Aba
                tabDados.SelectedTab = pagEstoque

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtQuantidadeQualidade.Focus()

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

            'Verifica Status
            Dim iStatus As StatusQualidade = StatusQualidade.Aprovado
            Dim iCodigoInspecao As Integer

            'Sim / Não
            For Each oRow As GridEXRow In grdQualidadeSimNao.GetDataRows
                If oRow.Cells("sim_nao").Value = False Then
                    iStatus = StatusQualidade.Reprovado
                    Exit For
                End If
            Next

            'Sim / Não
            If iStatus <> StatusQualidade.Reprovado Then
                For Each oRow As GridEXRow In grdQualidadeValor.GetDataRows
                    If oRow.Cells("valor").Value > oRow.Cells("valor_maximo").Value Or oRow.Cells("valor").Value < oRow.Cells("valor_minimo").Value Then
                        iStatus = StatusQualidade.Reprovado
                        Exit For
                    End If
                Next
            End If

            If cboStatus.Visible = True Then
                iStatus = cboStatus.SelectedValue
            Else
                'Seta Controle
                lblStatus.Text = IIf(iStatus = StatusQualidade.Aprovado, "PRODUTO APROVADO", "PRODUTO REPROVADO")
                lblStatus.Visible = True
            End If

            'Insere Registro na tb_qa_inspecao_produdo_producao
            Call oClsQAInspecaoProdutoProducao.InsertInspecaoProduto(grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                     grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                     txtQuantidadeQualidade.Value, _
                                                                     iStatus, _
                                                                     txtObservacao.Text.Trim, _
                                                                     iCodigoInspecao)

            'Insere Registro na tb_qa_inspecao_produdo_producao_inspecao (valor)
            Call oClsQAInspecaoProdutoProducao.InsertInspecaoProdutoInspecaoValor(grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                                  grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                                  iCodigoInspecao, _
                                                                                  grdQualidadeValor)

            'Insere Registro na tb_qa_inspecao_produdo_producao_inspecao (sim/não)
            Call oClsQAInspecaoProdutoProducao.InsertInspecaoProdutoInspecaoSimNao(grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                                   grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                                   iCodigoInspecao, _
                                                                                   grdQualidadeSimNao)


            'Verifica se é Necessário Informar o Rejeito
            If iStatus = StatusQualidade.Reprovado Then

                'Insere Registro de Rejeito
                Call oClsQAInspecaoProdutoProducao.InsertApontamentoRejeito(grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                            grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                            grdListagem.CurrentRow.Cells("sequencia_concorrente").Value, _
                                                                            0, _
                                                                            txtQuantidadeQualidade.Value, _
                                                                            txtObservacao.Text.Trim)

            End If

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
            
            'Verifica se foi preenchido o campo - Quantidade
            If ValidaCampo(txtQuantidadeQualidade, lblQuantidadeQualidade, True) = False Then
                Exit Function
            ElseIf txtQuantidadeQualidade.Value > txtQuantidade.Value Then
                frmMain.errInfo.SetError(lblQuantidadeQualidade, "A Quantidade Informada deve ser menor ou igual a Quantidade da Nota Fiscal.")
                tabDados.SelectedTab = pagEstoque
                txtQuantidadeQualidade.Focus()
                Exit Function
            End If

            'Verifica se a Quantidade é > que a Quantidade da Nota Fiscal
            If txtQuantidadeQualidade.Value > txtQuantidade.Value Then
                frmMain.errInfo.SetError(lblQuantidadeQualidade, "A Quantidade Informada deve ser menor ou igual a Quantidade da Nota Fiscal.")
                tabDados.SelectedTab = pagEstoque
                txtQuantidadeQualidade.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido os Dados de QualidadeEntradaNF - Valores
            For Each oRow As GridEXRow In grdQualidadeValor.GetDataRows
                If IsDBNull(oRow.Cells("valor").Value) Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor preencher todos os dados de Qualidade.")
                    tabDados.SelectedTab = pagEstoque
                    grdQualidadeValor.Focus()
                    Exit Function
                End If
            Next

            If cboStatus.Visible = True Then

                'Verifica se foi Selecionado o Campo - Observação
                If ValidaCampo(cboStatus, cboStatus) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Observação
                If ValidaCampo(txtObservacao, pagObservacao, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagObservacao
                    txtObservacao.Focus()
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Novo()

        Try

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.QualidadeInspecaoProducao, gcInsert)

            'Limpa Controles
            txtQuantidadeQualidade.Value = 0

            'Limpa Grids
            grdQualidadeSimNao.DataSource = Nothing
            grdQualidadeValor.DataSource = Nothing


            'Desabilita Controle
            lblStatus.Visible = False
            cboStatus.SelectedIndex = -1
            cboStatus.Visible = False

                'Limpa Arquivo
                Call NovoArquivo()

                'Limpa Observação
                txtObservacao.Text = ""

                'Limpa Grid
                grdArquivo.DataSource = Nothing

                'Seta Focu
                txtQuantidadeQualidade.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub InsertArquivo(ByVal oGrid As GridEX, _
                              ByVal sTipoArquivo As String, _
                              ByVal sCaracteristicasInspecionar As String, _
                              ByVal sDescricao As String, _
                              ByVal sArquivo As String, _
                              ByVal iCodigoTipoArquivo As Integer, _
                              ByVal iCodigoCaracteristicasInspecionar As Integer, _
                              ByVal sDescricaoAntigo As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCTipoArquivo As New DataColumn("tipo_arquivo")
            Dim oDCCaracteristicasInspecionar As New DataColumn("caracteristicas_inspecionar")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCArquivo As New DataColumn("arquivo")
            Dim oDCArquivoInteracti As New DataColumn("arquivo_interacti")
            Dim oDCCodigoTipoArquivo As New DataColumn("codigo_tipo_arquivo")
            Dim oDCCodigoCaracteristicasInspecionar As New DataColumn("codigo_caracteristicas_inspecionar")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCTipoArquivo)
                oDataTable.Columns.Add(oDCCaracteristicasInspecionar)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCArquivo)
                oDataTable.Columns.Add(oDCArquivoInteracti)
                oDataTable.Columns.Add(oDCCodigoTipoArquivo)
                oDataTable.Columns.Add(oDCCodigoCaracteristicasInspecionar)
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirArquivo.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("tipo_arquivo") = sTipoArquivo
                oDataRow("caracteristicas_inspecionar") = sCaracteristicasInspecionar
                oDataRow("descricao") = sDescricao
                oDataRow("arquivo") = sArquivo
                oDataRow("arquivo_interacti") = sArquivo
                oDataRow("codigo_tipo_arquivo") = iCodigoTipoArquivo
                oDataRow("codigo_caracteristicas_inspecionar") = iCodigoCaracteristicasInspecionar
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(descricao = '" & sDescricaoAntigo.Replace("'", "''") & "')")(0)
                oDataRow("tipo_arquivo") = sTipoArquivo
                oDataRow("caracteristicas_inspecionar") = sCaracteristicasInspecionar
                oDataRow("descricao") = sDescricao
                oDataRow("arquivo") = sArquivo
                oDataRow("arquivo_interacti") = sArquivo
                oDataRow("codigo_tipo_arquivo") = iCodigoTipoArquivo
                oDataRow("codigo_caracteristicas_inspecionar") = iCodigoCaracteristicasInspecionar
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
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

    Private Sub EditarArquivo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.QualidadeInspecaoProducao, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                If IsDBNull(grdArquivo.CurrentRow.Cells("codigo_caracteristicas_inspecionar").Value) Then
                    cboCaracteristicasInspecionar.SelectedIndex = -1
                Else
                    cboCaracteristicasInspecionar.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_caracteristicas_inspecionar").Value
                End If
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = grdArquivo.CurrentRow.Cells("arquivo_interacti").Value
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.RowIndex

                'Seta Focu
                cboCaracteristicasInspecionar.Focus()

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
            cboCaracteristicasInspecionar.SelectedIndex = -1
            txtDescricaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            'Seta Focu
            cboCaracteristicasInspecionar.Focus()

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

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se o Produto é Válido
            If IsNumeric(btnInserirArquivo.Tag) Then
                If VerificaExisteValorGrid(grdArquivo, "arquivo", txtArquivo.Text.Trim, grdArquivo.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblArquivo, "Este Arquivo: " & txtArquivo.Text & " já está associado ao Registro: " & txtProduto.Text.Trim & ".")
                    btnProcurarArquivo.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdArquivo, "arquivo", txtArquivo.Text.Trim, -1) Then
                    frmMain.errInfo.SetError(lblArquivo, "Este Arquivo: " & txtArquivo.Text & " já está associado ao Registro: " & txtProduto.Text.Trim & ".")
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

#End Region

End Class
