Imports Janus.Windows.GridEX

Public Class usrCadEspecieInsumo

#Region "::: VARIAVEIS :::"

    'Variáveis da Tipo de Alça
    Private oClsCadEspecieInsumo As New clsUsrCadEspecieInsumo
    Private oHashTable As New Hashtable

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadEspecieInsumo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5
                    Select Case sender.name
                        Case "cboGrupoItem" : Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
                    End Select

                Case Keys.F3
                    Select Case sender.name
                        Case "cboGrupoItem" : Call btnProcurarGrupoItem_Click(btnProcurarGrupoItem, System.EventArgs.Empty)
                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.name
                        Case "cboGrupoItem" : Call btnCadastrarGrupoItem_Click(btnCadastrarGrupoItem, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadEspecieInsumo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadEspecieInsumo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoEspecieInsumo
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoEspecieInsumo)

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

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarGrupoItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"

            'Seta Parametros
            oComboBoxFind = cboGrupoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboGrupoItem.Focus()

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

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

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

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCodigoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnListaEncargosSociais_Click(sender As Object, e As EventArgs) Handles btnListaEncargosSociais.Click

        Try

            'Váriavies Locais
            Dim oForm As New frmCadEspecieInsumoEncargosSociais

            oForm.CodigoEspecieInsumo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oForm.Estrutura = oHashTable
            oForm.ShowDialog(Me)

            'Carrega Dados
            oHashTable = oForm.Estrutura

            'Váriaveis Locais
            Dim dPercentual As Double = 0

            For Each oEstrutura As EncargosSociais In oHashTable.Values
                dPercentual += oEstrutura.dPercentual
            Next

            'Seta Controle
            txtEncargosSociais.Value = dPercentual

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboInsideEncargosSociais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIncideEncargosSociais.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboIncideEncargosSociais.SelectedIndex <> -1 AndAlso cboIncideEncargosSociais.SelectedValue = True Then
                btnListaEncargosSociais.Enabled = True
                If oHashTable.Count = 0 Then
                    Dim oClsCadEncargosSociais As New clsUsrCadEncargosSociais
                    Call oClsCadEncargosSociais.LoadHashTable(oHashTable, -1)
                End If

                'Váriaveis Locais
                Dim dPercentual As Double = 0

                For Each oEstrutura As EncargosSociais In oHashTable.Values
                    dPercentual += oEstrutura.dPercentual
                Next

                'Seta Controle
                txtEncargosSociais.Value = dPercentual

            Else
                btnListaEncargosSociais.Enabled = False
                txtEncargosSociais.Value = 0
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
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
                                     Formulario.CadastroBasicoEspecieInsumo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoEspecieInsumo, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoEspecieInsumo, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadEspecieInsumo_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoEspecieInsumo, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoEspecieInsumo, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoEspecieInsumo, gcPrint)
            'Verifica Direito - Cadastrar
            btnCadastrarGrupoItem.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcInsert)

            'Carrega Combo
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboSimNao(cboIncideEncargosSociais)
            Call LoadComboSimNao(cboPossuiHI)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoEspecieInsumo)

            'Carrega Combo
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtCodigoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoEspecieInsumo, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                cboGrupoItem.SelectedValue = grdListagem.CurrentRow.Cells.Item("codigo_grupo_item").Value
                txtCodigo.Text = grdListagem.CurrentRow.Cells.Item("codigo_especie").Value
                txtDescricao.Text = grdListagem.CurrentRow.Cells.Item("descricao").Value
                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value
                cboAtivo.SelectedValue = grdListagem.CurrentRow.Cells.Item("ativo").Value
                cboIncideEncargosSociais.SelectedValue = grdListagem.CurrentRow.Cells.Item("incide_encargos_sociais").Value
                txtEncargosSociais.Value = grdListagem.CurrentRow.Cells.Item("encargos_sociais").Value
                cboPossuiHI.SelectedValue = grdListagem.CurrentRow.Cells.Item("possui_hi").Value

                'Carrega HashTable
                Dim oClsCadEncargosSociais As New clsUsrCadEncargosSociais
                Call oClsCadEncargosSociais.LoadHashTable(oHashTable, grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboGrupoItem.Focus()

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
                    oClsCadEspecieInsumo.Delete()

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
            cboGrupoItem.Text = ""
            txtCodigo.Text = ""
            txtDescricao.Text = ""
            btnSalvar.Tag = ""
            cboAtivo.SelectedValue = True
            cboIncideEncargosSociais.SelectedValue = False
            txtEncargosSociais.Value = 0
            btnListaEncargosSociais.Enabled = False
            cboEspeciePai.Text = ""
            cboPossuiHI.SelectedValue = False
            oHashTable.Clear()

            'Carrega Combo - Espécie
            Call LoadCombo(cboEspeciePai, "sp_select_combo_cadastro_basico_especie_insumo " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros            
            oClsCadEspecieInsumo.CodigoGrupoItem = cboGrupoItem.SelectedValue
            oClsCadEspecieInsumo.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadEspecieInsumo.CodigoEspecie = txtCodigo.Text.Trim
            oClsCadEspecieInsumo.Descricao = txtDescricao.Text.Trim
            oClsCadEspecieInsumo.Ativo = cboAtivo.SelectedValue
            oClsCadEspecieInsumo.IncideEncargosSociais = cboIncideEncargosSociais.SelectedValue
            oClsCadEspecieInsumo.PercentualEncargos = txtEncargosSociais.Value
            oClsCadEspecieInsumo.CodigoEspeciePai = IIf(cboEspeciePai.SelectedIndex = -1, -1, cboEspeciePai.SelectedValue)
            oClsCadEspecieInsumo.PossuiHI = cboPossuiHI.SelectedValue

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsCadEspecieInsumo.Update()
                oClsCadEspecieInsumo.DeleteEncargos(oClsCadEspecieInsumo.Codigo)
                oClsCadEspecieInsumo.InsertEncargos(oClsCadEspecieInsumo.Codigo, oHashTable)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadEspecieInsumo.Insert()
                oClsCadEspecieInsumo.InsertEncargos(oClsCadEspecieInsumo.Codigo, oHashTable)
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
            oClsCadEspecieInsumo.LoadGrid(grdListagem, _
                                          txtCodigoFiltro.Text.Trim, _
                                          txtDescricaoFiltro.Text.Trim)

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

            'Verifica se foi Selecionado o Campo - Grupo de Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Código é Válido
            If oClsCadEspecieInsumo.ValidaCodigo(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                          txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                cboGrupoItem.Focus()
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

            'Verifica se foi Preenchido o Campo - Incide Encargos Sociais
            If ValidaCampo(cboIncideEncargosSociais, lblIncideEncargosSociais) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado Corretamente o Campo - Espécie Pai
            If cboEspeciePai.SelectedIndex = -1 And IsNumeric(btnSalvar.Tag) Then
                If btnSalvar.Tag = cboEspeciePai.SelectedValue Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Uma Espécie não pode ser associada a ela mesma.")
                    cboEspeciePai.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Possui H.I.
            If ValidaCampo(cboPossuiHI, lblPossuiHI) = False Then
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
