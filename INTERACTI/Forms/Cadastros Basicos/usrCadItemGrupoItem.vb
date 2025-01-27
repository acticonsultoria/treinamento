Imports Janus.Windows.EditControls

Public Class usrCadItemGrupoItem

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadGrupoItem As New clsUsrCadGrupoItem

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadItemGrupoItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    Select Case sender.Name
                        Case "txtItemOrigem" : Call btnProcurarItemOrigem_Click(btnProcurarItemOrigem, System.EventArgs.Empty)
                        Case "txtItemDestino" : Call btnProcurarItemDestino_Click(btnProcurarItemDestino, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboGrupoItemOrigem", "cboGrupoItemDestino"
                            'Carrega Combo
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboGrupoItemOrigem : oComboBox(1) = cboGrupoItemDestino
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboGrupoItemOrigem" : btnCadastrarGrupoItemOrigem_Click(btnCadastrarGrupoItemOrigem, System.EventArgs.Empty)
                        Case "cboGrupoItemDestino" : btnCadastrarGrupoItemDestino_Click(btnCadastrarGrupoItemDestino, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadItemGrupoItem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadItemGrupoItem_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

#End Region

#Region "::: ORIGEM :::"

    Private Sub btnCadastrarGrupoItemOrigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItemOrigem.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoItem")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboGrupoItemOrigem : oComboBox(1) = cboGrupoItemDestino
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboGrupoItemOrigem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridOrigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridOrigem.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrigem
            oForm.NomeFormulario = Formulario.CadastroBasicoItemGrupoItem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdOrigem, Formulario.CadastroBasicoItemGrupoItem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemOrigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemOrigem.Click

        Try


            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = -1
            oMaskedEditBoxFind = txtItemOrigem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtItemOrigem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridOrigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridOrigem.Click

        Try

            'Exportar Grid - Origem
            Call ExportExcel(grdOrigem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrigem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrigem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrigem.Name, _
                                     Formulario.CadastroBasicoItemGrupoItem, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrigem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrigem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrigem, _
                                     Formulario.CadastroBasicoItemGrupoItem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGridOrigem() Handles cboGrupoItemOrigem.SelectedIndexChanged, _
                                       txtItemOrigem.TextChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadGrupoItem.LoadGridAlterar(grdOrigem, _
                                             IIf(cboGrupoItemOrigem.SelectedIndex = -1, -1, cboGrupoItemOrigem.SelectedValue), _
                                             txtItemOrigem.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDestino_Click(sender As Object, e As EventArgs) Handles btnDestino.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Grupo de Item - Destino
            If ValidaCampo(cboGrupoItemDestino, lblGrupoItemDestino) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado algum Registro da grid
            If VerificaSelecaoRow(grdOrigem) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            'Executa a Alteração
            Call oClsCadGrupoItem.AlterarGrupoItem(cboGrupoItemDestino.SelectedValue)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Carrega a Grid de Origem
            Call LoadGridOrigem()

            'Carrega a Grid de Destino
            Call LoadGridDestino()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DESTINO :::"

    Private Sub btnCadastrarGrupoItemDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItemDestino.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoItem")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboGrupoItemOrigem : oComboBox(1) = cboGrupoItemDestino
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboGrupoItemDestino.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDestino.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDestino
            oForm.NomeFormulario = Formulario.CadastroBasicoItemGrupoItem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDestino, Formulario.CadastroBasicoItemGrupoItem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemDestino.Click

        Try


            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = -1
            oMaskedEditBoxFind = txtItemDestino

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtItemDestino.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDestino.Click

        Try

            'Exportar Grid - Origem
            Call ExportExcel(grdDestino)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDestino_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDestino.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDestino.Name, _
                                     Formulario.CadastroBasicoItemGrupoItem, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDestino_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDestino.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDestino, _
                                     Formulario.CadastroBasicoItemGrupoItem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGridDestino() Handles cboGrupoItemDestino.SelectedIndexChanged, _
                                       txtItemDestino.TextChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadGrupoItem.LoadGridAlterar(grdDestino, _
                                             IIf(cboGrupoItemDestino.SelectedIndex = -1, -1, cboGrupoItemDestino.SelectedValue), _
                                             txtItemDestino.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnOrigem_Click(sender As Object, e As EventArgs) Handles btnOrigem.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Grupo de Item - Origem
            If ValidaCampo(cboGrupoItemOrigem, lblGrupoItemOrigem) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado algum Registro da grid
            If VerificaSelecaoRow(grdDestino) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            'Executa a Alteração
            Call oClsCadGrupoItem.AlterarGrupoItem(cboGrupoItemOrigem.SelectedValue)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Carrega a Grid de Origem
            Call LoadGridOrigem()

            'Carrega a Grid de Destino
            Call LoadGridDestino()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadItemGrupoItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnOrigem.Enabled = VerificaDireito(Formulario.CadastroBasicoItemGrupoItem, gcUpdate)
            btnDestino.Enabled = VerificaDireito(Formulario.CadastroBasicoItemGrupoItem, gcUpdate)
            btnExcelGridOrigem.Enabled = VerificaDireito(Formulario.CadastroBasicoItemGrupoItem, gcPrint)
            btnExcelGridDestino.Enabled = VerificaDireito(Formulario.CadastroBasicoItemGrupoItem, gcPrint)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboGrupoItemOrigem : oComboBox(1) = cboGrupoItemDestino
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdOrigem, Formulario.CadastroBasicoItemGrupoItem)
            Call ConfiguraGrid(grdDestino, Formulario.CadastroBasicoItemGrupoItem)

            'Seta Focu
            cboGrupoItemOrigem.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
