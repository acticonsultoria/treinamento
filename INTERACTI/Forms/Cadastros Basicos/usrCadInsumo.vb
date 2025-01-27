Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadInsumo

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadInsumo As New clsUsrCadInsumo

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadInsumo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    Select Case sender.Name
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                        Case "cboCentroCusto" : Call btnProcurarCentroCusto_Click(btnProcurarCentroCusto, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboGrupoItem" : Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                        Case "cboEspecieInsumo" : Call LoadCombo(cboEspecieInsumo, "sp_select_combo_cadastro_basico_especie_insumo " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
                        Case "cboCentroCusto" : Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboGrupoItem" : Call btnCadastrarGrupoItem_Click(btnCadastrarGrupoItem, System.EventArgs.Empty)
                        Case "cboEspecieInsumo" : Call btnCadastrarEspecieInsumo_Click(btnCadastrarEspecieInsumo, System.EventArgs.Empty)
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                        Case "cboCentroCusto" : Call btnCadastrarCentroCusto_Click(btnCadastrarCentroCusto, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadInsumo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoInsumo
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoInsumo)

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

    Private Sub btnCadastrarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItem.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoItem")

            'Carrega Combo
            LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarEspecieInsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarEspecieInsumo.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadEspecieInsumo")

            'Carrega Combo
            LoadCombo(cboEspecieInsumo, "sp_select_combo_cadastro_basico_especie_insumo " & goUsuario.iEmpresa)

            'Seta Focu
            cboEspecieInsumo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

                       'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedida.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroCusto")

            'Carrega Combo
            LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroCusto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroCusto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            If IsNumeric(btnVoltar.Tag) Then
                For Each oRow As GridEXRow In grdListagem.GetDataRows
                    If IsDBNull(oRow.Cells("codigo_item").Value) = False AndAlso oRow.Cells("codigo_item").Value = btnVoltar.Tag Then
                        grdListagem.MoveTo(oRow)
                        Exit For
                    End If
                Next
            End If

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            grdListagem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key
                Case "editar" : Call Editar()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoInsumo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoInsumo, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadInsumo_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoInsumo, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoInsumo, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoInsumo, gcPrint)

            'Carrega Combo
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboEspecieInsumo, "sp_select_combo_cadastro_basico_especie_insumo " & goUsuario.iEmpresa)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboAtivo)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoInsumo)

            'Carrega Grid
            Call oClsCadInsumo.LoadGrid(grdListagem)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            grdListagem.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem Direito de Alterar o Registro
            If VerificaDireito(Formulario.CadastroBasicoInsumo, gcUpdate) = True Then

                'Carrega Controles
                Call oClsCadInsumo.LoadDados(grdListagem.CurrentRow.Cells("codigo_item").Value, _
                                             txtCodigoInsumo, _
                                             txtDescricao, _
                                             cboAtivo, _
                                             cboGrupoItem, _
                                             cboEspecieInsumo, _
                                             cboUnidadeMedida, _
                                             cboCentroCusto, _
                                             cboContaContabil, _
                                             txtEstoqueMinimo)

                'Seta Controle
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo_item").Value

                btnVoltar.Tag = grdListagem.CurrentRow.Cells("codigo_item").Value
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtCodigoInsumo.Focus()

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

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadInsumo.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
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
            txtCodigoInsumo.Text = ""
            txtDescricao.Text = ""
            cboAtivo.SelectedValue = True
            cboGrupoItem.Text = ""
            cboEspecieInsumo.Text = ""
            cboUnidadeMedida.Text = ""
            cboCentroCusto.Text = ""
            cboContaContabil.Text = ""
            txtEstoqueMinimo.Value = 0
            btnSalvar.Tag = ""

            'Seta Focu
            txtCodigoInsumo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Passa Parâmetros
            oClsCadInsumo.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadInsumo.CodigoInsumo = txtCodigoInsumo.Text.Trim
            oClsCadInsumo.Descricao = txtDescricao.Text.Trim
            oClsCadInsumo.Ativo = cboAtivo.SelectedValue
            oClsCadInsumo.CodigoGrupoItem = IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue)
            oClsCadInsumo.CodigoEspecieInsumo = IIf(cboEspecieInsumo.SelectedIndex = -1, -1, cboEspecieInsumo.SelectedValue)
            oClsCadInsumo.CodigoUnidadeMedida = IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue)
            oClsCadInsumo.CodigoCentroCusto = IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue)
            oClsCadInsumo.ContaContabil = IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue)
            oClsCadInsumo.EstoqueMinimo = txtEstoqueMinimo.Value

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then

                'Altera Registro
                Call oClsCadInsumo.Update()
                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                'Insere Registro
                Call oClsCadInsumo.Insert()

                'Informa o Usuário sobre o Sucesso da Operação
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
            Call oClsCadInsumo.LoadGrid(grdListagem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Código da Insumo
            If ValidaCampo(txtCodigoInsumo, lblCodigoInsumo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se a Sigla preenchida é válida
            If oClsCadInsumo.ValidaCodigo(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                         txtCodigoInsumo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigoInsumo, "Este Código: " & txtCodigoInsumo.Text & " já está associado a outro Registro.")
                txtCodigoInsumo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Grupo de Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Espécie Insumo
            If ValidaCampo(cboEspecieInsumo, lblEspecieInsumo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
