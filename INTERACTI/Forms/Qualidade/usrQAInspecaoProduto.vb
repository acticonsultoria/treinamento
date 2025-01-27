Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO

Public Class usrQAInspecaoProduto

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsQAInspecaoProduto As New clsUsrQAInspecaoProduto
    Private lCodigoMovimentacao As Long

#End Region

#Region "::: ENUM :::"

    'Status de QualidadeEntradaNF
    Private Enum StatusQualidadeEntradaNF
        Aprovado = 1
        Reprovado = 2
    End Enum

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrQAInspecaoProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrQAInspecaoProduto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

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
            oForm.NomeFormulario = Formulario.QualidadeInspecaoRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.QualidadeInspecaoRecebimento)

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
            oForm.NomeFormulario = Formulario.QualidadeInspecaoRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidadeSimNao, Formulario.QualidadeInspecaoRecebimento)

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
            oForm.NomeFormulario = Formulario.QualidadeInspecaoRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidadeValor, Formulario.QualidadeInspecaoRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

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
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub btnAtualizaLoteInterno_Click(sender As Object, e As EventArgs) Handles btnAtualizaLoteInterno.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Preenchido o Lote Atual
            If ValidaCampo(txtLoteAtual, lblLoteAtual, True) = False Then
                Exit Sub
            End If

            'Verifica se o Usuário deseja Alterar o Lote Atual
            If MsgBox("Deseja Atualiar o Lote Atual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'Atualia Lote
                Call oClsQAInspecaoProduto.UpdateLoteAtual(grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                                           txtLoteAtual.Value, _
                                                           txtLoteInterno)

                'Limpa Controle
                txtLoteAtual.Value = 0

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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
                                     Formulario.QualidadeInspecaoRecebimento, _
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
                                     Formulario.QualidadeInspecaoRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidadeValor_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidadeValor.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidadeValor.Name, _
                                     Formulario.QualidadeInspecaoRecebimento, _
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
                                     Formulario.QualidadeInspecaoRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidadeSimNao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidadeSimNao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidadeSimNao.Name, _
                                     Formulario.QualidadeInspecaoRecebimento, _
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
                                     Formulario.QualidadeInspecaoRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.ComprasRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.ComprasRequisicao)

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

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
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

            If Validacao() = True Then

                'Salva Dados da Máquina
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoArquivo() = True Then

                    If IsNumeric(btnInserirArquivo.Tag) = False Then

                        'Insere Arquivo
                        Call InsertArquivoBD("tb_cmp_requisicao", _
                                             txtDescricaoArquivo.Text.Trim, _
                                             txtRevisaoArquivo.Text.Trim, _
                                             txtArquivo.Text.Trim, _
                                             cboTipoArquivo.SelectedValue, _
                                             btnSalvar.Tag)

                    Else

                        'Atualiza Arquivo
                        Call UpdateArquivoBD("tb_cmp_requisicao", _
                                             txtDescricaoArquivo.Text.Trim, _
                                             txtRevisaoArquivo.Text.Trim, _
                                             IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                             cboTipoArquivo.SelectedValue, _
                                             grdArquivo.CurrentRow.Cells("path").Value, _
                                             btnSalvar.Tag)

                    End If

                    'Carrega Grid
                    Call LoadGridArquivoBD(grdArquivo, "tb_cmp_requisicao", btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoArquivo()

                End If

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
                Case "visualizar" : Call VisualizarDocumentoBD(grdArquivo.CurrentRow.Cells("arquivo").Value, grdArquivo.CurrentRow.Cells("extensao").Value)

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
                                     Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ComprasRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.ComprasRequisicao, _
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

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrQAInspecaoProduto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcPrint)
            btnInserirArquivo.Enabled = VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcDelete)

            'Verifica Direito - Cadastrar
            btnCadastrarDepositoEstoque.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Oculta Controle
            lblStatus.Visible = False

            'Carrega ComboBox
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoDocumentoFiltro, "sp_select_combo_estoque_tipo_documento " & goUsuario.iEmpresa)

            'Seta Controles DateTime
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False

            'Remove Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.QualidadeInspecaoRecebimento)
            Call ConfiguraGrid(grdQualidadeSimNao, Formulario.QualidadeInspecaoRecebimento)
            Call ConfiguraGrid(grdQualidadeValor, Formulario.QualidadeInspecaoRecebimento)
            Call ConfiguraGrid(grdArquivo, Formulario.QualidadeInspecaoRecebimento)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call oClsQAInspecaoProduto.LoadGridNotaFiscal(grdListagem, _
                                                          txtNumeroDocumentoFiltro.Text.Trim, _
                                                          txtSerieFiltro.Text.Trim, _
                                                          txtEmitenteFiltro.Text.Trim, _
                                                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                                          txtProdutoFiltro.Text.Trim, _
                                                          IIf(cboTipoDocumentoFiltro.SelectedIndex = -1, "", cboTipoDocumentoFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcInsert) = True Then

                'Novo
                Call Novo()

                'Carrega Controles
                txtNumeroDocumento.Text = grdListagem.CurrentRow.Cells("numero_documento").Value
                txtSerie.Text = grdListagem.CurrentRow.Cells("serie").Value
                txtEmitente.Text = grdListagem.CurrentRow.Cells("emitente").Value
                txtDataEmissao.Text = grdListagem.CurrentRow.Cells("data_emissao").Value
                txtDataEntrada.Text = grdListagem.CurrentRow.Cells("data_entrada").Value
                txtProduto.Text = grdListagem.CurrentRow.Cells("codigo_produto").Value + " - " + grdListagem.CurrentRow.Cells("descricao").Value
                txtQuantidade.Value = grdListagem.CurrentRow.Cells("quantidade").Value - (grdListagem.CurrentRow.Cells("quantidade_aprovada").Value + grdListagem.CurrentRow.Cells("quantidade_reprovada").Value)
                dtpDataFabricacaoEstoque.Enabled = grdListagem.CurrentRow.Cells("controla_data_fabricacao").Value
                dtpDataValidadeEstoque.Enabled = grdListagem.CurrentRow.Cells("controla_validade").Value
                txtLoteInterno.Text = grdListagem.CurrentRow.Cells("lote_interno").Value
                If grdListagem.CurrentRow.Cells("gera_lote_interno").Value = False Then
                    txtLoteAtual.Enabled = False
                    btnAtualizaLoteInterno.Enabled = False
                Else
                    txtLoteAtual.Enabled = True
                    btnAtualizaLoteInterno.Enabled = VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcAdministrator)
                End If

                'Configura Controles
                dtpDataFabricacaoEstoque.Value = CDate(txtDataEmissao.Text) : dtpDataFabricacaoEstoque.MaxDate = CDate(txtDataEmissao.Text)
                dtpDataFabricacaoEstoque.Value = Now.Date : dtpDataValidadeEstoque.MinDate = CDate(txtDataEmissao.Text)

                'Carrega ComboBox 
                Call LoadCombo(cboDepositoEstoque, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", " & grdListagem.CurrentRow.Cells("codigo_proprietario_deposito").Value & ", NULL, 0", False)

                'Carrega Grid de QualidadeEntradaNF - Inspeção (Valor)
                Call oClsQAInspecaoProduto.LoadGridQualidadeInspecao(grdQualidadeValor, _
                                                                        grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                                                        QualidadeTipoCaracteristicaInspecionar.Valor)

                'Carrega Grid de QualidadeEntradaNF - Inspeção (Sim / Não)
                Call oClsQAInspecaoProduto.LoadGridQualidadeInspecao(grdQualidadeSimNao, _
                                                                        grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                                                        QualidadeTipoCaracteristicaInspecionar.SimNao)

                'Seta Váriavel
                lCodigoMovimentacao = grdListagem.CurrentRow.Cells("codigo_movimentacao").Value

                'Foca Aba
                tabDados.SelectedTab = pagEstoque

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboDepositoEstoque.Focus()

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
            Dim iStatus As StatusQualidadeEntradaNF = StatusQualidadeEntradaNF.Aprovado
            Dim iCodigoInspecao As Integer

            'Sim / Não
            For Each oRow As GridEXRow In grdQualidadeSimNao.GetDataRows
                If oRow.Cells("sim_nao").Value = False Then
                    iStatus = StatusQualidadeEntradaNF.Reprovado
                    Exit For
                End If
            Next

            'Sim / Não
            If iStatus <> StatusQualidadeEntradaNF.Reprovado Then
                For Each oRow As GridEXRow In grdQualidadeValor.GetDataRows
                    If oRow.Cells("valor").Value > oRow.Cells("valor_maximo").Value Or oRow.Cells("valor").Value < oRow.Cells("valor_minimo").Value Then
                        iStatus = StatusQualidadeEntradaNF.Reprovado
                        Exit For
                    End If
                Next
            End If

            'Seta Controle
            lblStatus.Text = IIf(iStatus = StatusQualidadeEntradaNF.Aprovado, "PRODUTO APROVADO", "PRODUTO REPROVADO")
            lblStatus.Visible = True

            'Insere Registro na tb_qa_recebimento_produto
            Call oClsQAInspecaoProduto.InsertInspecaoProduto(lCodigoMovimentacao, _
                                                             cboDepositoEstoque.SelectedValue, _
                                                             txtLoteEstoque.Text.Trim, _
                                                             txtLoteInterno.Text.Trim, _
                                                             txtQuantidadeQualidade.Value, _
                                                             iStatus, _
                                                             IIf(dtpDataFabricacaoEstoque.Enabled = True, dtpDataFabricacaoEstoque.Value, ""), _
                                                             IIf(dtpDataValidadeEstoque.Enabled = True, dtpDataValidadeEstoque.Value, ""), _
                                                             txtObservacao.Text.Trim, _
                                                             iCodigoInspecao)

            'Insere Registro na tb_qa_recebimento_produto_inspecao (valor)
            Call oClsQAInspecaoProduto.InsertInspecaoProdutoInspecaoValor(lCodigoMovimentacao, _
                                                                          iCodigoInspecao, _
                                                                          grdQualidadeValor)

            'Insere Registro na tb_qa_recebimento_produto_inspecao (sim/não)
            Call oClsQAInspecaoProduto.InsertInspecaoProdutoInspecaoSimNao(lCodigoMovimentacao, _
                                                                           iCodigoInspecao, _
                                                                           grdQualidadeSimNao)

            'Integração
            Call Integracao(iCodigoInspecao, _
                            lCodigoMovimentacao)

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

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDepositoEstoque, lblDepositoEstoque) = False Then
                tabDados.SelectedTab = pagEstoque
                cboDepositoEstoque.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Lote
            If txtLoteEstoque.Enabled = True Then
                If ValidaCampo(txtLoteEstoque, lblLoteEstoque, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagEstoque
                    txtLoteEstoque.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi preenchido o campo - Quantidade
            If ValidaCampo(txtQuantidadeQualidade, lblQuantidadeQualidade, True) = False Then
                Exit Function
            ElseIf txtQuantidadeQualidade.Value > txtQuantidade.Value Then
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

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Novo()

        Try

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcInsert)

            'Limpa Controles
            cboDepositoEstoque.SelectedIndex = -1
            txtLoteEstoque.Text = ""
            txtLoteInterno.Text = ""
            txtQuantidadeQualidade.Value = 0
            dtpDataFabricacaoEstoque.Value = Now.Date
            dtpDataValidadeEstoque.Value = Now.Date

            'Limpa Grids
            grdQualidadeSimNao.DataSource = Nothing
            grdQualidadeValor.DataSource = Nothing

            'Desabilita Controle
            lblStatus.Visible = False

            'Limpa Arquivo
            Call NovoArquivo()

            'Limpa Váriavel
            lCodigoMovimentacao = -1

            'Limpa Observação
            txtObservacao.Text = ""

            'Limpa Grid
            grdArquivo.DataSource = Nothing

            'Seta Focu
            cboDepositoEstoque.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        'Exclui Registro do Banco de Dados
                        modFunction.DeleteArquivoBD("tb_cmp_requisicao", oRow.Cells("path").Value, btnSalvar.Tag)
                        'Exclui Registro da Grid
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
            If VerificaDireito(Formulario.ComprasRequisicao, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                txtRevisaoArquivo.Text = grdArquivo.CurrentRow.Cells("revisao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = ""
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.RowIndex

                'Seta Focu
                cboTipoArquivo.Focus()

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
            txtRevisaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            'Seta Focu
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

            'Verifica se foi Preenchido o Campo - Revisão
            If ValidaCampo(txtRevisaoArquivo, lblRevisaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If IsNumeric(btnInserirArquivo.Tag) = False Then
                If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Produto é Válido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirArquivo.Tag) Then
                iRow = grdArquivo.CurrentRow.RowIndex
            End If

            For Each oRow As GridEXRow In grdArquivo.GetDataRows
                If oRow.Cells("descricao").Value = txtDescricaoArquivo.Text.Trim And oRow.Cells("revisao").Value = txtRevisaoArquivo.Text.Trim And oRow.RowIndex <> iRow Then
                    frmMain.errInfo.SetError(lblDescricaoArquivo, "Esta Descrição / Revisão já se encontra associada a um Registro.")
                    txtDescricaoArquivo.Focus()
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: INTEGRAÇÃO :::"

    Private Sub Integracao(ByVal iCodigoInspecaoProduto As Integer, _
                           ByVal lCodigoMovimentacao As Long)

        Try

            'Váriavel Local
            Dim oClsIntegracao As New clsIntegracao

            'Integração - Estoque
            oClsIntegracao.IntegracaoQualidadeEstoque(lCodigoMovimentacao, _
                                                      iCodigoInspecaoProduto)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
