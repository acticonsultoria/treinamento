Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadCalendario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadCalendario As New clsUsrCadCalendario
    Private iCodigoCalendario As New clsUsrCadCalendario

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadCalendario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridCapa() Else Control_Enter(sender)
                       
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadCalendario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadCalendario_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: CAPA :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoCalendario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCalendario)

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

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call DeleteCapa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridCapa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoCapa()

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
            Call NovoCapa()

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
            If ValidacaoCapa() = True Then

                'Salva Dados do Registro
                Call SalvarCapa()

                Call EditarCapa(oClsCadCalendario.CodigoCalendario)
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
            Call LoadGridCapa()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarCapa(grdListagem.CurrentRow.Cells("codigo").Value)

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
                                     Formulario.CadastroBasicoCalendario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoCalendario, _
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
                                          Formulario.CadastroBasicoCalendario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: LINHA :::"

    Private Sub btnAgruparGridData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridData.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagemData.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagemData.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagemData.GroupByBoxVisible = True
                grdListagemData.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridData.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemData
            oForm.NomeFormulario = Formulario.CadastroBasicoCalendario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemData, Formulario.CadastroBasicoCalendario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridData.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagemData)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirLinha.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados da Capa
            If ValidacaoCapa() = True Then

                'Salva Dados da Capa
                Call SalvarCapa()

                'Valida Dados da Linha
                If ValidacaoLinha() = True Then
                    'Salva Dados do Calendário - Capa
                    Call SalvarLinha()
                    'Carrega Linha
                    Call LoadGridLinha()
                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoLinha()
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirLinha.Click

        Try

            'Deleta Registros
            Call DeleteLinha()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUF.SelectedIndex = -1 Then
                cboMunicipio.DataSource = Nothing
                cboMunicipio.Text = ""
            Else
                Call LoadCombo(cboMunicipio, "sp_select_combo_static_municipio '" & cboUF.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemData_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagemData.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagemData.CurrentColumn) Then Exit Sub

            Select Case grdListagemData.CurrentColumn.Key

                Case "editar" : Call EditarLinha()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemData_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagemData.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemData, _
                                     Formulario.CadastroBasicoCalendario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemData_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagemData.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagemData.Name, _
                                     Formulario.CadastroBasicoCalendario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemData_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagemData.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagemData.Name, _
                                          Formulario.CadastroBasicoCalendario, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadCalendario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcPrint)
            btnInserirLinha.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcInsert)
            btnExcluirLinha.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcDelete)
            btnExcelGridData.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcPrint)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboAno : oComboBox(1) = cboAnoFiltro
            LoadComboAno(oComboBox, Now.Year, 10)
            Call LoadCombo(cboUF, "sp_select_combo_static_estado")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCalendario)
            Call ConfiguraGrid(grdListagemData, Formulario.CadastroBasicoCalendario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtDescricaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CAPA :::"

    Private Sub DeleteCapa()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadCalendario.DeleteCalendario()

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

    Private Sub NovoCapa()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtDescricao.Tag = ""
            txtDescricao.Text = ""
            cboAno.SelectedIndex = -1
            'Limpa Controles - Linha
            txtData.Text = ""
            txtDescricaoFeriado.Text = ""
            cboUF.SelectedIndex = -1
            cboMunicipio.SelectedIndex = -1
            btnInserirLinha.Tag = ""
            grdListagemData.DataSource = Nothing

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarCapa(lCodigoCalendario As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCalendario, gcUpdate) = True Then


                oClsCadCalendario.LoadDados(lCodigoCalendario,
                                            txtDescricao,
                                            cboAno)

                'Carrega Grid - Linha
                oClsCadCalendario.LoadGridLinha(grdListagemData)

                'Altera aba
                If tabMain.SelectedTab.Name <> pagDados.Name Then

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagLista)
                    tabMain.TabPages.Add(pagDados)
                End If

                'Seta Focu
                txtDescricao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarCapa()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCalendario.CodigoCalendario = IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0)
            oClsCadCalendario.Descricao = txtDescricao.Text.Trim
            oClsCadCalendario.Ano = cboAno.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(txtDescricao.Tag) Then
                oClsCadCalendario.UpdateCalendario()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadCalendario.InsertCalendario()
                txtDescricao.Tag = oClsCadCalendario.CodigoCalendario
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridCapa()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCalendario.LoadGridCapa(grdListagem, _
                                           txtDescricaoFiltro.Text.Trim, _
                                           IIf(cboAnoFiltro.SelectedIndex = -1, -1, cboAnoFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCapa() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCapa = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Valida se o Ano é válido
            If oClsCadCalendario.ValidaDescricao(IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0), _
                                                 txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição já está associado a outro Registro")
                txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ano
            If ValidaCampo(cboAno, lblAno) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCapa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: LINHA :::"

    Private Sub DeleteLinha()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagemData) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadCalendario.DeleteFeriado()

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

    Private Sub NovoLinha()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtData.Text = ""
            txtDescricaoFeriado.Text = ""
            cboUF.SelectedIndex = -1
            cboMunicipio.SelectedIndex = -1
            btnInserirLinha.Tag = ""

            'Seta Focu
            txtData.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarLinha()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCalendario, gcUpdate) = True Then

                'Seta Controles
                txtData.Text = grdListagemData.CurrentRow.Cells("data").Value
                txtDescricaoFeriado.Text = grdListagemData.CurrentRow.Cells("descricao").Value
                cboUF.SelectedValue = grdListagemData.CurrentRow.Cells("uf").Value
                cboMunicipio.SelectedValue = grdListagemData.CurrentRow.Cells("codigo_municipio").Value
                btnInserirLinha.Tag = grdListagemData.CurrentRow.Cells("codigo").Value

                'Seta Focu
                txtData.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarLinha()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCalendario.Dia = DatePart(DateInterval.Day, CDate(txtData.Text))
            oClsCadCalendario.Mes = DatePart(DateInterval.Month, CDate(txtData.Text))
            oClsCadCalendario.DescricaoFeriado = txtDescricaoFeriado.Text.Trim
            oClsCadCalendario.UF = IIf(cboUF.SelectedIndex = -1, "", cboUF.SelectedValue)
            oClsCadCalendario.CodigoMunicipio = IIf(cboMunicipio.SelectedIndex = -1, -1, cboMunicipio.SelectedValue)
            oClsCadCalendario.CodigoFeriado = IIf(IsNumeric(btnInserirLinha.Tag), btnInserirLinha.Tag, 0)

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirLinha.Tag) Then
                oClsCadCalendario.UpdateFeriado()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadCalendario.InsertFeriado()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridLinha()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCalendario.LoadGridLinha(grdListagemData)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoLinha() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoLinha = False

            'Verifica se foi Preenchido o Campo - Data
            If ValidaCampo(txtData, lblData, TipoCampo.data) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição Feriado
            If ValidaCampo(txtDescricaoFeriado, lblDescricaoFeriado, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoLinha = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
