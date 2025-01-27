Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadAutoTextoEmail

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadTextoEmail As New clsUsrCadTextoEmail

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadAutoTextoEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrCadAutoTextoEmail_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: TEXTO PARA E-MAIL :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoTextoEmail
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTextoEmail)

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
            cboTipoEmailFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 2
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoEmail.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboTipoEmail.SelectedIndex = -1 Then
                'Limpa a Grid
                grdTag.DataSource = Nothing
            Else
                'Carrega Grid - Tag
                Call oClsCadTextoEmail.LoadGridTag(grdTag, _
                                                   cboTipoEmail.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo da Célula
            If IsNothing(e.Row) Then Exit Sub

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
                                     Formulario.CadastroBasicoTextoEmail)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoTextoEmail, _
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
                                          Formulario.CadastroBasicoTextoEmail, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: E-MAIL (CÓPIA) :::"

    Private Sub btnConfigurarGridEmailCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridEmailCopia.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEmailCopia
            oForm.NomeFormulario = Formulario.CadastroBasicoTextoEmail
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEmailCopia, Formulario.CadastroBasicoTextoEmail)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridEmail.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdEmailCopia)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirEmailCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEmailCopia.Click

        Try

            'Deleta Registros
            Call DeleteEmail()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirEmailCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEmailCopia.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoEmail() = True Then

                'Váriaveis Locais
                Dim sEmailAntigo As String = ""

                If IsNumeric(btnInserirEmailCopia.Tag) Then
                    sEmailAntigo = grdEmailCopia.CurrentRow.Cells("email").Value
                End If

                'Salva Dados do Registro
                Call InsertEmail(grdEmailCopia, _
                                 txtEmailCopia.Text.Trim, _
                                 sEmailAntigo)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoEmail()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmailCopia_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEmailCopia.RowDoubleClick

        Try

            'Verifica o Tipo da Célula
            If IsNothing(e.Row) Then Exit Sub

            Select Case grdEmailCopia.CurrentColumn.Key

                Case "editar" : Call EditarEmail()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmailCopia_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEmailCopia.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEmailCopia, _
                                     Formulario.CadastroBasicoTextoEmail)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmailCopia_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEmailCopia.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEmailCopia.Name, _
                                     Formulario.CadastroBasicoTextoEmail, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TAG :::"

    Private Sub grdTag_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdTag.RowDoubleClick

        Try

            'Verifica o Tipo da Célula
            If IsNothing(e.Row) Then Exit Sub

            Select Case grdTag.CurrentColumn.Key

                Case "adicionar" : txtTextoEmail.Text &= grdTag.CurrentRow.Cells("tag").Value : txtTextoEmail.Focus() : System.Windows.Forms.SendKeys.Send("{RIGHT}")

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadAutoTextoEmail_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoTextoEmail, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoTextoEmail, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoTextoEmail, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoTextoEmail, gcPrint)
            btnExcelGridEmail.Enabled = VerificaDireito(Formulario.CadastroBasicoTextoEmail, gcPrint)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboTipoEmailFiltro : oComboBox(1) = cboTipoEmail
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_email")
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTextoEmail)
            Call ConfiguraGrid(grdEmailCopia, Formulario.CadastroBasicoTextoEmail)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboTipoEmailFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TEXTO PARA E-MAIL :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTextoEmail, gcUpdate) = True Then

                'Carrega Controles
                cboTipoEmail.SelectedValue = grdListagem.CurrentRow.Cells("codigo_tipo_email").Value
                txtTextoEmail.Text = grdListagem.CurrentRow.Cells("texto").Value
                txtDescricao.Text = grdListagem.CurrentRow.Cells("descricao").Value
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                cboAtivo.SelectedValue = grdListagem.CurrentRow.Cells("ativo").Value

                'Carrega grid
                Call oClsCadTextoEmail.LoadGridEmailCopia(grdEmailCopia, _
                                                          grdListagem.CurrentRow.Cells("codigo").Value)

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboTipoEmail.Focus()

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadTextoEmail.Delete()

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
            cboTipoEmail.SelectedIndex = -1
            txtTextoEmail.Text = ""
            txtDescricao.Text = ""
            btnSalvar.Tag = ""
            cboAtivo.SelectedValue = True

            'Limpa Controles - Cópia
            txtEmailCopia.Text = ""
            grdEmailCopia.DataSource = Nothing
            btnInserirEmailCopia.Tag = ""

            'Seta Focu
            cboTipoEmail.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadTextoEmail.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadTextoEmail.CodigoTipoEmail = cboTipoEmail.SelectedValue
            oClsCadTextoEmail.Descricao = txtDescricao.Text.Trim
            oClsCadTextoEmail.TextoEmail = txtTextoEmail.Text.Trim
            oClsCadTextoEmail.Ativo = cboAtivo.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = True Then
                oClsCadTextoEmail.Update()
                oClsCadTextoEmail.DeleteEmailCopia()
                oClsCadTextoEmail.InsertEmailCopia(grdEmailCopia)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadTextoEmail.Insert()
                oClsCadTextoEmail.InsertEmailCopia(grdEmailCopia)
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
            Call oClsCadTextoEmail.LoadGrid(grdListagem, _
                                            IIf(cboTipoEmailFiltro.SelectedIndex = -1, -1, cboTipoEmailFiltro.SelectedValue), _
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

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Passa Parametros
            If oClsCadTextoEmail.ValidaDescricao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                 txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição: " & txtDescricao.Text & " já está associado a outro Registro.")
                txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Texto para E-mail
            If ValidaCampo(txtTextoEmail, lblTextoEmail, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: E-MAIL (CÓPIA) :::"

    Private Sub InsertEmail(ByVal oGrid As GridEX, _
                            ByVal sEmail As String, _
                            ByVal sEmailAntigo As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCEmail As New DataColumn("email")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCEmail)
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirEmailCopia.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("email") = sEmail
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(email = '" & sEmailAntigo & "')")(0)
                oDataRow("email") = sEmail
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

    Private Sub EditarEmail()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTextoEmail, gcUpdate) = True Then

                'Seta Controles
                txtEmailCopia.Text = grdEmailCopia.CurrentRow.Cells("email").Value
                btnInserirEmailCopia.Tag = grdEmailCopia.CurrentRow.RowIndex

                'Seta Focu
                txtEmailCopia.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteEmail()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdEmailCopia) = True Then

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
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoEmail()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtEmailCopia.Text = ""
            btnInserirEmailCopia.Tag = ""

            'Seta Focu
            txtEmailCopia.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoEmail() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEmail = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtEmailCopia, lblEmailCopia, TipoCampo.email) = False Then
                Exit Function
            End If

            'Verifica se o E-mail já se encontra cadastrado
            Dim iRow As Integer = -1
            If IsNumeric(btnInserirEmailCopia.Tag) Then iRow = grdListagem.CurrentRow.RowIndex
            If VerificaExisteValorGrid(grdEmailCopia, "email", txtEmailCopia.Text.Trim, iRow) = True Then
                frmMain.errInfo.SetError(lblEmailCopia, "O E-mail informado já se encontra associado a outro Registro.")
                txtEmailCopia.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoEmail = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
