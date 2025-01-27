Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class usrImpICMS

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsImpICMS As New clsUsrImpICMS

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrImpICMS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboCFOPFiltro", "cboCFOP"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboCFOPFiltro : oComboBox(1) = cboCFOP
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCFOP" : Call btnCadastrarCFOP_Click(btnCadastrarCFOP, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrImpICMS_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrImpICMS_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ImpostoRegraICMS
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoRegraICMS)

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

    Private Sub btnCadastrarCFOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCFOP.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCFOP")

            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCFOPFiltro : oComboBox(1) = cboCFOP
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)

            'Seta Focu
            cboCFOP.Focus()

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
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)
            'Seta Focu
            cboCFOP.Focus()

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
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            cboCFOPFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFormula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduto.Click, _
                                                                                                     btnAliquotaICMS.Click, _
                                                                                                     btnIPI.Click, _
                                                                                                     btnPIS.Click, _
                                                                                                     btnCOFINS.Click, _
                                                                                                     btnFrete.Click, _
                                                                                                     btnSeguro.Click, _
                                                                                                     btnDesconto.Click, _
                                                                                                     btnOutrasDespesas.Click, _
                                                                                                     btnValor.Click, _
                                                                                                     btnAliquotaII.Click, _
                                                                                                     btnRedICMS.Click, _
                                                                                                     btnSoma.Click, _
                                                                                                     btnSubtrai.Click, _
                                                                                                     btnMultiplica.Click, _
                                                                                                     btnDivide.Click, _
                                                                                                     btnAbreParenteses.Click, _
                                                                                                     btnFechaParenteses.Click, _
                                                                                                     btnII.Click, _
                                                                                                     btnC.Click, _
                                                                                                     btnCE.Click

        Try

            Select Case sender.Name

                Case "btnC"
                    txtFormula.Text = ""

                Case "btnCE"
                    txtFormula.Text = Mid(txtFormula.Text, 1, InStrRev(txtFormula.Text, " ")).Trim

                Case "btnValor"
                    txtFormula.Text = IIf(txtFormula.Text = "", "", txtFormula.Text & " ") & "|" & Replace(txtValor.Value, ",", ".") & "|"

                Case Else
                    txtFormula.Text = IIf(txtFormula.Text = "", "", txtFormula.Text & " ") & sender.tag

            End Select

            'Verifica Formula
            Call VerificaFormula()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFormulaST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProdutoST.Click, _
                                                                                                       btnAliquotaICMSST.Click, _
                                                                                                       btnIPIST.Click, _
                                                                                                       btnPISST.Click, _
                                                                                                       btnCOFINSST.Click, _
                                                                                                       btnFreteST.Click, _
                                                                                                       btnSeguroST.Click, _
                                                                                                       btnOutrasDespesasST.Click, _
                                                                                                       btnDescontoST.Click, _
                                                                                                       btnValorST.Click, _
                                                                                                       btnSomaST.Click, _
                                                                                                       btnSubtraiST.Click, _
                                                                                                       btnMultiplicaST.Click, _
                                                                                                       btnDivideST.Click, _
                                                                                                       btnAbreParentesesST.Click, _
                                                                                                       btnFechaParentesesST.Click, _
                                                                                                       btnCST.Click, _
                                                                                                       btnCEST.Click, _
                                                                                                       btnPautaST.Click, _
                                                                                                       btnIIST.Click, _
                                                                                                       btnIVAST.Click

        Try

            Select Case sender.Name

                Case "btnCST"
                    txtFormulaST.Text = ""

                Case "btnCEST"
                    txtFormulaST.Text = Mid(txtFormulaST.Text, 1, InStrRev(txtFormulaST.Text, " ")).Trim

                Case "btnValorST"
                    txtFormulaST.Text = IIf(txtFormulaST.Text = "", "", txtFormulaST.Text & " ") & "|" & Replace(txtValorST.Value, ",", ".") & "|"

                Case Else
                    txtFormulaST.Text = IIf(txtFormulaST.Text = "", "", txtFormulaST.Text & " ") & sender.tag

            End Select

            'Verifica Formula
            Call VerificaFormulaST()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCFOP.SelectedIndexChanged, _
                                                                                                                 cboCFOPFiltro.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verificando se foi selecionado algum registro
            If sender.SelectedIndex = -1 Then
                'Limpa Controle
                If sender.name = "cboCFOP" Then
                    txtNaturezaOperacao.Text = ""
                Else
                    txtNaturezaOperacaoFiltro.Text = ""
                End If
            Else
                If sender.name = "cboCFOP" Then
                    'Carrega Controle
                    Call LoadDescricao(txtNaturezaOperacao, _
                                       "sp_select_cadastro_basico_natureza_operacao_cfop " & sender.SelectedValue & ", " & goUsuario.iEmpresa)
                Else
                    'Carrega Controle
                    Call LoadDescricao(txtNaturezaOperacaoFiltro, _
                                       "sp_select_cadastro_basico_natureza_operacao_cfop " & sender.SelectedValue & ", " & goUsuario.iEmpresa)
                End If
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboSituacaoTributariaICMS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSituacaoTributariaICMS.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Desabilita Controles
            tabICMS.Visible = False
            tabICMS.TabPages.Remove(pagICMS)
            tabICMS.TabPages.Remove(pagICMSST)

            Select Case cboSituacaoTributariaICMS.SelectedValue

                Case "00"
                    'Habilita Controles - ICMS
                    tabICMS.TabPages.Add(pagICMS)
                    tabICMS.SelectedTab = pagICMS
                    tabICMS.Visible = True

                Case "10"
                    'Habilita Controles - ICMS
                    tabICMS.TabPages.Add(pagICMS)
                    'Habilita Controles - ICMS ST
                    tabICMS.TabPages.Add(pagICMSST)
                    tabICMS.SelectedTab = pagICMS
                    tabICMS.Visible = True

                Case "20"
                    'Habilita Controles - ICMS                    
                    tabICMS.TabPages.Add(pagICMS)
                    tabICMS.SelectedTab = pagICMS
                    tabICMS.Visible = True

                Case "30"
                    'Habilita Controles - ICMS ST
                    tabICMS.TabPages.Add(pagICMSST)
                    tabICMS.SelectedTab = pagICMSST
                    tabICMS.Visible = True

                Case "40", "41", "50"

                Case "51"
                    'Habilita Controles - ICMS
                    tabICMS.TabPages.Add(pagICMS)
                    tabICMS.SelectedTab = pagICMS
                    tabICMS.Visible = True

                Case "60"
                    'Habilita Controles - ICMS ST                    
                    tabICMS.TabPages.Add(pagICMSST)
                    tabICMS.SelectedTab = pagICMSST
                    tabICMS.Visible = True

                Case "70"
                    'Habilita Controles - ICMS
                    tabICMS.TabPages.Add(pagICMS)
                    'Habilita Controles - ICMS ST
                    tabICMS.TabPages.Add(pagICMSST)
                    tabICMS.SelectedTab = pagICMS
                    tabICMS.Visible = True

                Case "90", "900"
                    'Habilita Controles - ICMS
                    tabICMS.TabPages.Add(pagICMS)
                    'Habilita Controles - ICMS ST
                    tabICMS.TabPages.Add(pagICMSST)
                    tabICMS.SelectedTab = pagICMS
                    tabICMS.Visible = True

                Case "101", "102", "103", "300", "400"

                Case "201", "202", "203", "500"
                    'Habilita Controles - ICMS ST
                    tabICMS.TabPages.Add(pagICMSST)
                    tabICMS.SelectedTab = pagICMSST
                    tabICMS.Visible = True

            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

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
                                     Formulario.ImpostoRegraICMS)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ImpostoRegraICMS, _
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
                                          Formulario.ImpostoRegraICMS, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrImpICMS_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ImpostoRegraICMS, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.ImpostoRegraICMS, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ImpostoRegraICMS, gcPrint)
            btnCadastrarCFOP.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcInsert)

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCFOPFiltro : oComboBox(1) = cboCFOP
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            oComboBox(0) = cboSituacaoTributariaICMSFiltro : oComboBox(1) = cboSituacaoTributariaICMS
            If goEmitente.iRegimeTributario = RegimeTributario.SimplesNacional Or
                goEmitente.iRegimeTributario = RegimeTributario.SimplesNacionalExceto Then
                Call LoadCombo(oComboBox, "sp_select_combo_static_situacao_tributaria_icms_simples")
            Else
                Call LoadCombo(oComboBox, "sp_select_combo_static_situacao_tributaria_icms")
            End If
            
            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoRegraICMS)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboCFOPFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
                    oClsImpICMS.Delete()

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
            cboCFOP.SelectedIndex = -1
            cboSituacaoTributariaICMS.SelectedIndex = -1
            txtFormula.Text = ""
            txtFormulaST.Text = ""
            txtValor.Value = 0
            txtValorST.Value = 0
            cboCFOP.Tag = ""

            'Verifica Formula
            Call VerificaFormula()

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsImpICMS.CFOP = cboCFOP.SelectedValue
            oClsImpICMS.CST = cboSituacaoTributariaICMS.SelectedValue
            oClsImpICMS.FormulaICMS = IIf(tabICMS.TabPages.Contains(pagICMS) = False, "", txtFormula.Text.Trim)
            oClsImpICMS.FormulaICMSST = IIf(tabICMS.TabPages.Contains(pagICMSST) = False, "", txtFormulaST.Text.Trim)
            oClsImpICMS.Codigo = IIf(IsNumeric(cboCFOP.Tag), cboCFOP.Tag, 0)

            'Verifica o Tipo de Operação
            If Len(cboCFOP.Tag) > 0 Then
                oClsImpICMS.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsImpICMS.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ImpostoRegraICMS, gcUpdate) = True Then

                'Limpa Grid
                Call Novo()

                'Carrega Formulário
                Call oClsImpICMS.LoadControles(grdListagem.CurrentRow.Cells("codigo").Value, _
                                               cboCFOP, _
                                               cboSituacaoTributariaICMS, _
                                               txtFormula, _
                                               txtFormulaST)

                'Verifica Formula
                Call VerificaFormula()
                Call VerificaFormulaST()

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboCFOP.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

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
            oClsImpICMS.LoadGrid(grdListagem, _
                                 IIf(cboCFOPFiltro.SelectedIndex = -1, -1, cboCFOPFiltro.SelectedValue), _
                                 IIf(cboSituacaoTributariaICMSFiltro.SelectedIndex = -1, "", cboSituacaoTributariaICMSFiltro.SelectedValue))

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

            'Verifica se foi Selecionado o Campo - CFOP
            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - CST
            If ValidaCampo(cboSituacaoTributariaICMS, lblSituacaoTributariaICMS) = False Then
                Exit Function
            End If

            'Valida Dados
            If oClsImpICMS.ValidaCFOPCST(cboCFOP.SelectedValue, _
                                         cboSituacaoTributariaICMS.Text, _
                                         IIf(IsNumeric(cboCFOP.Tag), cboCFOP.Tag, 0)) = False Then
                frmMain.errInfo.SetError(lblSituacaoTributariaICMS, "Este CFOP: " & cboCFOP.Text & " e CST: " & cboSituacaoTributariaICMS.Text & " já está associado a outro Registro.")
                cboSituacaoTributariaICMS.Focus()
                Exit Function
            End If

            'Caso tenha Aba ICMS
            If tabICMS.Contains(pagICMS) Then

                'Verifica se foi Preenchido o Campo - Formula                        
                If ValidaCampo(txtFormula, lblFormula, TipoCampo.texto) = False Then
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub VerificaFormula()

        Try

            If txtFormula.Text = "" Then

                btnSoma.Enabled = False
                btnSubtrai.Enabled = False
                btnMultiplica.Enabled = False
                btnDivide.Enabled = False
                btnAbreParenteses.Enabled = True
                btnFechaParenteses.Enabled = False

                btnProduto.Enabled = True
                btnAliquotaICMS.Enabled = True
                btnIPI.Enabled = True
                btnPIS.Enabled = True
                btnCOFINS.Enabled = True
                btnFrete.Enabled = True
                btnSeguro.Enabled = True
                btnOutrasDespesas.Enabled = True
                btnValor.Enabled = True
                btnAliquotaII.Enabled = True
                btnRedICMS.Enabled = True
                btnDesconto.Enabled = True
                btnII.Enabled = True

            ElseIf Mid(txtFormula.Text, txtFormula.Text.Length, 1) = "|" Or Mid(txtFormula.Text, txtFormula.Text.Length, 1) = ")" Then

                btnSoma.Enabled = True
                btnSubtrai.Enabled = True
                btnMultiplica.Enabled = True
                btnDivide.Enabled = True
                btnAbreParenteses.Enabled = False

                btnProduto.Enabled = False
                btnAliquotaICMS.Enabled = False
                btnIPI.Enabled = False
                btnPIS.Enabled = False
                btnCOFINS.Enabled = False
                btnFrete.Enabled = False
                btnSeguro.Enabled = False
                btnOutrasDespesas.Enabled = False
                btnValor.Enabled = False
                btnAliquotaII.Enabled = False
                btnRedICMS.Enabled = False
                btnDesconto.Enabled = False
                btnII.Enabled = False

                Dim iAbreParentese As Integer = 0
                For i = 1 To txtFormula.Text.Length
                    If Mid(txtFormula.Text, i, 1) = "(" Then
                        iAbreParentese += 1
                    ElseIf Mid(txtFormula.Text, i, 1) = ")" Then
                        iAbreParentese -= 1
                    End If
                Next

                If iAbreParentese > 0 Then
                    btnFechaParenteses.Enabled = True
                Else
                    btnFechaParenteses.Enabled = False
                End If

            Else

                btnSoma.Enabled = False
                btnSubtrai.Enabled = False
                btnMultiplica.Enabled = False
                btnDivide.Enabled = False
                btnAbreParenteses.Enabled = True

                btnProduto.Enabled = True
                btnAliquotaICMS.Enabled = True
                btnIPI.Enabled = True
                btnPIS.Enabled = True
                btnCOFINS.Enabled = True
                btnFrete.Enabled = True
                btnSeguro.Enabled = True
                btnOutrasDespesas.Enabled = True
                btnValor.Enabled = True
                btnDesconto.Enabled = True
                btnAliquotaII.Enabled = True
                btnRedICMS.Enabled = True
                btnII.Enabled = True

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VerificaFormulaST()

        Try

            If txtFormulaST.Text = "" Then

                btnSomaST.Enabled = False
                btnSubtraiST.Enabled = False
                btnMultiplicaST.Enabled = False
                btnDivideST.Enabled = False
                btnAbreParentesesST.Enabled = True
                btnFechaParentesesST.Enabled = False

                btnProdutoST.Enabled = True
                btnAliquotaICMSST.Enabled = True
                btnIPIST.Enabled = True
                btnPISST.Enabled = True
                btnCOFINSST.Enabled = True
                btnFreteST.Enabled = True
                btnSeguroST.Enabled = True
                btnOutrasDespesasST.Enabled = True
                btnValorST.Enabled = True
                btnIVAST.Enabled = True
                btnPautaST.Enabled = True
                btnDescontoST.Enabled = True
                btnIIST.Enabled = True

            ElseIf Mid(txtFormulaST.Text, txtFormulaST.Text.Length, 1) = "|" Or Mid(txtFormulaST.Text, txtFormulaST.Text.Length, 1) = ")" Then

                btnSomaST.Enabled = True
                btnSubtraiST.Enabled = True
                btnMultiplicaST.Enabled = True
                btnDivideST.Enabled = True
                btnAbreParentesesST.Enabled = False

                btnProdutoST.Enabled = False
                btnAliquotaICMSST.Enabled = False
                btnIPIST.Enabled = False
                btnPISST.Enabled = False
                btnCOFINSST.Enabled = False
                btnFreteST.Enabled = False
                btnSeguroST.Enabled = False
                btnOutrasDespesasST.Enabled = False
                btnValorST.Enabled = False
                btnIVAST.Enabled = False
                btnPautaST.Enabled = False
                btnDescontoST.Enabled = False
                btnIIST.Enabled = False

                Dim iAbreParentese As Integer = 0
                For i = 1 To txtFormulaST.Text.Length
                    If Mid(txtFormulaST.Text, i, 1) = "(" Then
                        iAbreParentese += 1
                    ElseIf Mid(txtFormulaST.Text, i, 1) = ")" Then
                        iAbreParentese -= 1
                    End If
                Next

                If iAbreParentese > 0 Then
                    btnFechaParentesesST.Enabled = True
                Else
                    btnFechaParentesesST.Enabled = False
                End If

            Else

                btnSomaST.Enabled = False
                btnSubtraiST.Enabled = False
                btnMultiplicaST.Enabled = False
                btnDivideST.Enabled = False
                btnAbreParentesesST.Enabled = True

                btnProdutoST.Enabled = True
                btnAliquotaICMSST.Enabled = True
                btnIPIST.Enabled = True
                btnPISST.Enabled = True
                btnCOFINSST.Enabled = True
                btnFreteST.Enabled = True
                btnSeguroST.Enabled = True
                btnOutrasDespesasST.Enabled = True
                btnValorST.Enabled = True
                btnIVAST.Enabled = True
                btnPautaST.Enabled = True
                btnDescontoST.Enabled = True
                btnIIST.Enabled = True

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
