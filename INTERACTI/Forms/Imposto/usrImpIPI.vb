Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls

Public Class usrImpIPI

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsImpIPI As New clsUsrImpIPI

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrImpIPI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrImpIPI_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrImpIPI_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ImpostoRegraIPI
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoRegraIPI)

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
                                     Formulario.ImpostoRegraIPI)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ImpostoRegraIPI, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrImpIPI_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ImpostoRegraIPI, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.ImpostoRegraIPI, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ImpostoRegraIPI, gcPrint)
            btnCadastrarCFOP.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcInsert)

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCFOPFiltro : oComboBox(1) = cboCFOP
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            oComboBox(0) = cboSituacaoTributariaIPIFiltro : oComboBox(1) = cboSituacaoTributariaIPI
            Call LoadCombo(oComboBox, "sp_select_combo_static_situacao_tributaria_ipi_todos")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ImpostoRegraIPI)

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
                    oClsImpIPI.Delete()

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
            cboSituacaoTributariaIPI.SelectedIndex = -1
            txtFormula.Text = ""
            txtValor.Value = 0
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
            oClsImpIPI.CFOP = cboCFOP.SelectedValue
            oClsImpIPI.CST = cboSituacaoTributariaIPI.SelectedValue
            oClsImpIPI.FormulaIPI = txtFormula.Text.Trim
            oClsImpIPI.Codigo = IIf(IsNumeric(cboCFOP.Tag), cboCFOP.Tag, 0)

            'Verifica o Tipo de Operação
            If Len(cboCFOP.Tag) > 0 Then
                oClsImpIPI.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsImpIPI.Insert()
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
            If VerificaDireito(Formulario.ImpostoRegraIPI, gcUpdate) = True Then

                'Limpa Grid
                Call Novo()

                'Carrega Formulário
                Call oClsImpIPI.LoadControles(grdListagem.CurrentRow.Cells("codigo").Value, _
                                              cboCFOP, _
                                              cboSituacaoTributariaIPI, _
                                              txtFormula)

                'Verifica Formula
                Call VerificaFormula()

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
            Call oClsImpIPI.LoadGrid(grdListagem, _
                                     IIf(cboCFOPFiltro.SelectedIndex = -1, -1, cboCFOPFiltro.SelectedValue), _
                                     IIf(cboSituacaoTributariaIPIFiltro.SelectedIndex = -1, "", cboSituacaoTributariaIPIFiltro.SelectedValue))

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
            If ValidaCampo(cboSituacaoTributariaIPI, lblSituacaoTributariaIPI) = False Then
                Exit Function
            End If

            'Valida Dados
            If oClsImpIPI.ValidaCFOPCST(cboCFOP.SelectedValue, _
                                         cboSituacaoTributariaIPI.SelectedValue, _
                                         IIf(IsNumeric(cboCFOP.Tag), cboCFOP.Tag, 0)) = False Then
                frmMain.errInfo.SetError(lblSituacaoTributariaIPI, "Este CFOP: " & cboCFOP.Text & " e CST: " & cboSituacaoTributariaIPI.Text & " já está associado a outro Registro.")
                cboSituacaoTributariaIPI.Focus()
                Exit Function
            End If

            'Caso tenha Aba ICMS
            If tabIPI.Contains(pagICMS) Then

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

#End Region

End Class
