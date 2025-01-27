Imports Janus.Windows.Common
Imports Janus.Windows.GridEX

Public Class usrCadNCM

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadNCM As New clsUsrCadNCM

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadNCM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.name
                        Case "txtNCM" : Call btnProcurarNCM_Click(btnProcurarNCM, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadNCM_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: NCM :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoNCM
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoNCM)

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

    Private Sub btnProcurarNCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarNCM.Click

        Try

            'Váriavel - Formulário NCM
            Dim oForm As New frmFindNCMTIPI
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Parametros
            oMaskedEditBoxFind = txtNCM

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtNCM.Focus()

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
                Call Editar(oClsCadNCM.Codigo)

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
            txtNCMFiltro.Focus()

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

    Private Sub cboTipoCalculoIPI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoCalculoIPI.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtAliquotaIPI.Enabled = False : txtAliquotaIPI.Value = 0
            txtValorUnidadeIPI.Enabled = False : txtValorUnidadeIPI.Value = 0

            'Verifica Qual Tipo de Cálculo foi Selecionado
            Select Case cboTipoCalculoIPI.SelectedValue

                Case modDeclaration.TipoCalculoImposto.Percentual
                    txtAliquotaIPI.Enabled = True

                Case modDeclaration.TipoCalculoImposto.Valor
                    txtValorUnidadeIPI.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     Formulario.CadastroBasicoNCM)

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
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     Formulario.CadastroBasicoNCM,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name,
                                          Formulario.CadastroBasicoNCM,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadNCM_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcPrint)

            'Carrega Combo
            Call LoadCombo(cboTipoCalculoIPI, "sp_select_combo_static_tipo_calculo_imposto")
            Call LoadCombo(cboAliquotaICMS, "sp_select_combo_static_ecf_aliquota_icms")
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboSimNao(cboListaCAMEX)

            'Desabilita Controles
            txtAliquotaIPI.Enabled = False
            txtValorUnidadeIPI.Enabled = False

            If VerificaDireito(Formulario.ECFEmissao, gcSelect) = False Then
                grdListagem.RootTable.Columns.Remove(grdListagem.RootTable.Columns("aliquota_icms"))
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoNCM)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNCMFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: NCM :::"

    Private Sub Editar(lCodigo As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoNCM, gcUpdate) = True Then

                'Carrega Dados do NCM
                Call oClsCadNCM.LoadControles(lCodigo,
                                              txtNCM,
                                              txtDescricao,
                                              txtEXTipi,
                                              cboTipoCalculoIPI,
                                              txtAliquotaIPI,
                                              txtValorUnidadeIPI,
                                              cboAtivo,
                                              txtMensagem,
                                              cboListaCAMEX,
                                              cboAliquotaICMS)

                btnSalvar.Tag = lCodigo

                If tabMain.SelectedTab.Name <> pagDados.Name Then

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagLista)
                    tabMain.TabPages.Add(pagDados)
                End If

                'Seta Focu
                txtNCM.Focus()

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
                    oClsCadNCM.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    'Carrega Grid
                    Call LoadGrid()

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
            txtNCM.Text = ""
            btnSalvar.Tag = ""
            txtDescricao.Text = ""
            txtEXTipi.Text = ""
            cboTipoCalculoIPI.SelectedIndex = -1
            cboAtivo.SelectedValue = True
            cboListaCAMEX.SelectedValue = False
            cboAliquotaICMS.SelectedIndex = -1
            txtMensagem.Text = ""

            'Oculta / Exibe Grupo de Cupom Fiscal
            grpCupomFiscal.Visible = VerificaDireito(Formulario.ECFEmissao, gcSelect)

            'Seta Focu
            txtNCM.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadNCM.CodigoNCM = txtNCM.Text.Trim
            oClsCadNCM.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadNCM.Descricao = txtDescricao.Text.Trim
            oClsCadNCM.Mensagem = txtMensagem.Text.Trim
            oClsCadNCM.ListaCAMEX = cboListaCAMEX.SelectedValue
            oClsCadNCM.EXTIPI = txtEXTipi.Text.Trim
            oClsCadNCM.CodigoTipoCalculoImposto = IIf(cboTipoCalculoIPI.SelectedIndex = -1, -1, cboTipoCalculoIPI.SelectedValue)
            oClsCadNCM.AliquotaIPI = IIf(txtAliquotaIPI.Enabled = False, -1, txtAliquotaIPI.Value)
            oClsCadNCM.ValorUnidadeIPI = IIf(txtValorUnidadeIPI.Enabled = False, -1, txtValorUnidadeIPI.Value)
            oClsCadNCM.Ativo = cboAtivo.SelectedValue
            oClsCadNCM.AliquotaICMSECF = IIf(cboAliquotaICMS.SelectedIndex = -1, "", cboAliquotaICMS.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadNCM.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadNCM.Insert()
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
            oClsCadNCM.LoadGrid(grdListagem, _
                                txtNCMFiltro.Text.Trim, _
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

            'Verifica se foi Preenchido o Campo - NCM
            If ValidaCampo(txtNCM, lblNCM, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi o NCM Preenchido é Válido
            If ((txtNCM.Text.Trim.Length <> 8) Or IsNumeric(txtNCM.Text.Trim) = False) Then
                frmMain.errInfo.SetError(lblNCM, "O Código utilizado para o NCM não é válido. Deve possuir 8 caractéres numéricos.")
                txtNCM.Focus()
                Exit Function
            End If

            'Verifica se o NCM preenchido é válido
            If oClsCadNCM.ValidaCodigoNCM(txtNCM.Text.Trim, _
                                          txtEXTipi.Text.Trim, _
                                          IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)) = False Then
                frmMain.errInfo.SetError(lblNCM, "Este NCM: " & txtNCM.Text & " já está associado a outro Registro.")
                txtNCM.Focus()
                Exit Function
            End If

            'Verifica se o NCM preenchido é válido
            If oClsCadNCM.ValidaCodigoNCMTIPI(txtNCM.Text.Trim) = False Then
                If MsgBox("Este NCM: " & txtNCM.Text & " não está contido na TIPI. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    txtNCM.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            ''Verifica se foi Preenchido o Campo - Aliquota Total
            'If ValidaCampo(txtAliquotaTotalImposto, lblAliquotaTotalImposto, True) = False Then
            '    Exit Function
            'End If

            'Verifica se foi Selecionado o Campo - Lista CAMEX
            If ValidaCampo(cboListaCAMEX, lblListaCAMEX) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ativo
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

#End Region

End Class
