Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadTecido

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadTecido As New clsUsrCadTecido

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadTecido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                       
                Case Keys.F5
                    Select Case sender.name
                        Case "cboMaterial" : Call LoadCombo(cboMaterial, "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa, True)
                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.name
                        Case "cboMaterial" : Call btnCadastrarMaterial_Click(btnCadastrarMaterial, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadTecido_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadTecido_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: TECIDO :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoTecido
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTecido)

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

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtCodigo.Focus()

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

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
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
                                     Formulario.CadastroBasicoTecido)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoTecido, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MATERIAL :::"

    Private Sub btnConfigurarGridMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridMaterial.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdMaterial
            oForm.NomeFormulario = Formulario.CadastroBasicoTecido
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMaterial, Formulario.CadastroBasicoTecido)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridMaterial.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdMaterial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMaterial.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMaterial")

            'Carrega Combo
            LoadCombo(cboMaterial, "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa)

            'Seta Focu
            cboMaterial.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirMaterial.Click

        Try

            'Deleta Registros
            Call DeleteMaterial()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirMaterial.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoMaterial() = True Then

                'Salva Dados do Registro
                Call SalvarMaterial(grdMaterial)
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoMaterial()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaterial_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdMaterial.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdMaterial.CurrentColumn.Key

                Case "editar" : Call EditarMaterial()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaterial_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMaterial.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMaterial, _
                                     Formulario.CadastroBasicoTecido)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaterial_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdMaterial.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMaterial.Name, _
                                     Formulario.CadastroBasicoTecido, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadTecido_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoTecido, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoTecido, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoTecido, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoTecido, gcPrint)
            btnExcelGridMaterial.Enabled = VerificaDireito(Formulario.CadastroBasicoTecido, gcPrint)

            'Carrega Combo
            Call LoadCombo(cboMaterial, "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa, False)

            'Verifica Direito - Controles
            btnCadastrarMaterial.Enabled = VerificaDireito(Formulario.CadastroBasicoMaterial, gcInsert)

            'Configura a Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTecido)

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

#End Region

#Region "::: TECIDO :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTecido, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtCodigo.Text = .Item("codigo_tecido").Value
                    txtDescricao.Text = .Item("descricao").Value
                    txtTempoDescanso.Value = .Item("tempo_descanso").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    btnSalvar.Tag = .Item("codigo").Value

                End With

                'Carrega Grid
                Call oClsCadTecido.LoadGridMaterial(grdMaterial, btnSalvar.Tag)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtCodigo.Focus()

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

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadTecido.Delete()

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
            txtCodigo.Text = ""
            txtDescricao.Text = ""
            txtTempoDescanso.Value = 0
            txtGramaM2.Value = 0
            cboAtivo.SelectedValue = True
            btnSalvar.Tag = ""

            'Limpa Controles - Material
            cboMaterial.SelectedIndex = -1
            txtPercentual.Value = 0
            btnInserirMaterial.Tag = ""
            grdMaterial.DataSource = Nothing

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadTecido.CodigoTecido = txtCodigo.Text.Trim
            oClsCadTecido.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadTecido.Descricao = txtDescricao.Text.Trim
            oClsCadTecido.TempoDescanso = txtTempoDescanso.Value
            oClsCadTecido.GramaM2 = txtGramaM2.Value
            oClsCadTecido.Ativo = cboAtivo.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadTecido.Update()
                oClsCadTecido.DeleteMaterial(btnSalvar.Tag)
                oClsCadTecido.InsertMaterial(grdMaterial)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadTecido.Insert()
                oClsCadTecido.InsertMaterial(grdMaterial)
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
            Call oClsCadTecido.LoadGrid(grdListagem, _
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

            'Verifica se foi Preenchido o Campo - Moeda
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Moeda preenchido é válido
            If oClsCadTecido.ValidaCodigo(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                          txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tempo Descanso
            If ValidaCampo(txtTempoDescanso, lblTempoDescanso, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Grama / m²
            If ValidaCampo(txtGramaM2, lblGramaM2, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Informado o Material
            If grdMaterial.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir, "Material")
                cboMaterial.Focus()
                Exit Function
            ElseIf grdMaterial.GetTotalRow.Cells("percentual").Value <> 1 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A soma do percentual do Material tem que ser igual a 100%.")
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: MATERIAL :::"

    Private Sub EditarMaterial()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTecido, gcUpdate) = True Then

                With grdMaterial.CurrentRow.Cells

                    'Carrega Controles
                    cboMaterial.SelectedValue = .Item("codigo_material").Value
                    txtPercentual.Value = .Item("percentual").Value
                    btnInserirMaterial.Tag = .Item("codigo_material").Value

                End With

                'Seta Focu
                cboMaterial.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteMaterial()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdMaterial) = True Then

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
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoMaterial()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Material
            cboMaterial.SelectedIndex = -1
            txtPercentual.Value = 0
            btnInserirMaterial.Tag = ""

            'Seta Focu
            cboMaterial.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarMaterial(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCMaterial As New DataColumn("material")
            Dim oDCPercentual As New DataColumn("percentual")
            Dim oDCCodigoMaterial As New DataColumn("codigo_material")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCMaterial)
                oDataTable.Columns.Add(oDCPercentual)
                oDataTable.Columns.Add(oDCCodigoMaterial)
                'Seta DataType
                oDCPercentual.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirMaterial.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("material") = cboMaterial.Text
                oDataRow("percentual") = txtPercentual.Value
                oDataRow("codigo_material") = cboMaterial.SelectedValue
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("codigo_material = " & btnInserirMaterial.Tag)(0)
                oDataRow("material") = cboMaterial.Text
                oDataRow("percentual") = txtPercentual.Value
                oDataRow("codigo_material") = cboMaterial.SelectedValue
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

    Private Function ValidacaoMaterial() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoMaterial = False

            'Verifica se foi Preenchido o Campo - Material
            If ValidaCampo(cboMaterial, lblMaterial) = False Then
                Exit Function
            End If


            'Verifica se já foi inserido o Formulário
            If IsNumeric(btnSalvar.Tag) = False Then
                If VerificaExisteValorGrid(grdMaterial, "codigo_material", cboMaterial.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblMaterial, "Este Material: " & cboMaterial.Text & " já se encontra cadastrado.")
                    cboMaterial.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdMaterial, "codigo", cboMaterial.SelectedValue, grdMaterial.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblMaterial, "Este Material: " & cboMaterial.Text & " já se encontra cadastrado.")
                    cboMaterial.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoMaterial = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
