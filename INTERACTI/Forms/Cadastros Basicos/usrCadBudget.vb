Imports Microsoft.Office.Interop
Public Class usrCadBudget

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadBudget As New clsUsrCadBudget

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadBudget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadBudget_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadBudget_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBudget)
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            txtDescricao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call TratamentoErro(ex.Message, Me.Text)
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
            cboContaContabilFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
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
                                     Formulario.CadastroBasicoBudget)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoBudget, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadContaContabil")

            'Carrega Combo            
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)

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

            'Seta Parametros
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboContaContabil_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboContaContabil.SelectedIndexChanged
        Try

            'Carrega a Descrição do Produto caso o Código do Produto tenha sido Selecionado
            If cboContaContabil.SelectedIndex = -1 Then
                txtDescricao.Text = ""
            Else
                Call LoadDescricao(txtDescricao, "sp_select_cadastro_basico_descricao_plano_contas '" & cboContaContabil.SelectedValue & "', " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarExcel.Click
        Try
            ImportarExcel()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ImportarExcel()

        Dim oApplication As New Excel.Application
        Dim oWorkbook As Excel.Workbook

        Try

            'Váriaveis Locais
            Dim oArquivoExcel As New OpenFileDialog

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
            oArquivoExcel.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog <> DialogResult.OK Then Exit Sub



            'Abre o Arquivo            
            oWorkbook = oApplication.Workbooks.Open(oArquivoExcel.FileName)

            'Percorre Linha a Linha o Arquivo
            For i = 2 To oApplication.Rows.Count
                'Verifica se acabou os registros
                If oWorkbook.Application.Cells(i, 2).Value Is Nothing Then
                    Exit For
                End If

                'Percorre as colunas
                For iCol As Integer = 3 To oApplication.Columns.Count Step 3

                    'Verifica se acabou os registros
                    If oWorkbook.Application.Cells(i, iCol).Value Is Nothing Then
                        Exit For
                    End If

                    'Verifica se acabou os registros
                    If Not IsNumeric(oWorkbook.Application.Cells(i, iCol).Value) Then
                        Exit For
                    End If

                    oClsUsrCadBudget.InsertPlanilha(CStr(oWorkbook.Application.Cells(i, 1).value), _
                                                    oWorkbook.Application.Cells(i, iCol + 1).value, _
                                                    oWorkbook.Application.Cells(i, iCol + 2).value, _
                                                    oWorkbook.Application.Cells(i, iCol).value)

                Next

            Next i

            oWorkbook.Close(False)
            oWorkbook = Nothing
            oApplication = Nothing

            frmMain.Informacao("Budget importado com sucesso!", Color.Blue)
        Catch ex As Exception
            oWorkbook.Close(False)
            oWorkbook = Nothing
            oApplication = Nothing
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadBudget_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoBudget, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoBudget, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoBudget, gcInsert)
            btnExcel.Enabled = VerificaDireito(Formulario.CadastroBasicoBudget, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil_budget " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabilFiltro, "sp_select_combo_cadastro_basico_conta_contabil_budget " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboSimNao(cboAtivoFiltro)


            dtpDataCompetencia.Value = Now.Date
            dtpDataFinanceiro.Value = Now.Date
            dtpDataInicioCompeteciaFiltro.Value = Now.Date
            dtpDataInicioCompeteciaFiltro.Checked = False
            dtpDataFinalCompetenciaFiltro.Value = Now.Date
            dtpDataFinalCompetenciaFiltro.Checked = False
            dtpDataInicioFinanceiro.Value = Now.Date
            dtpDataInicioFinanceiro.Checked = False
            dtpDataFinalFinanceiro.Value = Now.Date
            dtpDataFinalFinanceiro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBudget)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboContaContabilFiltro.Focus()

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
            If VerificaDireito(Formulario.CadastroBasicoBudget, gcUpdate) = True Then

                'Carrega Controles
                Call oClsUsrCadBudget.Editar(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                             cboContaContabil, _
                                             txtValor, _
                                             dtpDataCompetencia, _
                                             dtpDataFinanceiro, _
                                             cboAtivo)

                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value


                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

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

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsUsrCadBudget.Delete()

                    'Carrega Grid
                    oClsUsrCadBudget.LoadGrid(grdListagem, _
                                     IIf(cboContaContabilFiltro.SelectedIndex = -1, "", cboContaContabilFiltro.SelectedValue), _
                                     IIf(dtpDataInicioCompeteciaFiltro.Checked = False, "", dtpDataInicioCompeteciaFiltro.Value), _
                                     IIf(dtpDataFinalCompetenciaFiltro.Checked = False, "", dtpDataFinalCompetenciaFiltro.Value), _
                                     IIf(dtpDataInicioFinanceiro.Checked = False, "", dtpDataInicioFinanceiro.Value), _
                                     IIf(dtpDataFinalFinanceiro.Checked = False, "", dtpDataFinalFinanceiro.Value), _
                                     IIf(cboAtivoFiltro.SelectedIndex = -1, -1, cboAtivoFiltro.SelectedValue))

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
            txtDescricao.Text = ""
            cboContaContabil.SelectedIndex = -1
            dtpDataCompetencia.Value = Now.Date
            dtpDataFinanceiro.Value = Now.Date
            cboAtivo.SelectedValue = 1
            txtValor.Text = ""
            btnSalvar.Tag = ""

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsUsrCadBudget.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsUsrCadBudget.CodigoContaContabil = cboContaContabil.SelectedValue
            oClsUsrCadBudget.DataCompetencia = dtpDataCompetencia.Value
            oClsUsrCadBudget.DataFinanceiro = dtpDataFinanceiro.Value
            oClsUsrCadBudget.Ativo = cboAtivo.SelectedValue
            oClsUsrCadBudget.Valor = txtValor.Value

            ''Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsUsrCadBudget.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                'Passa Parametros
                If oClsUsrCadBudget.ValidaDataCompetencia(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                               cboContaContabil.SelectedValue, _
                                               dtpDataCompetencia.Value) = False Then

                    MsgBox("Esta conta contábil: " & cboContaContabil.Text & " com essa data de competência: " & Month(dtpDataCompetencia.Value) & "/" & Year(dtpDataCompetencia.Value) & " já está associada a outro Registro.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Parent.Text)
                    cboContaContabil.Focus()
                Else
                    oClsUsrCadBudget.Insert()
                    frmMain.Informacao(Mensagem.RegistroInserido)
                End If

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
            oClsUsrCadBudget.LoadGrid(grdListagem, _
                                     IIf(cboContaContabilFiltro.SelectedIndex = -1, "", cboContaContabilFiltro.SelectedValue), _
                                     IIf(dtpDataInicioCompeteciaFiltro.Checked = False, "", dtpDataInicioCompeteciaFiltro.Value), _
                                     IIf(dtpDataFinalCompetenciaFiltro.Checked = False, "", dtpDataFinalCompetenciaFiltro.Value), _
                                     IIf(dtpDataInicioFinanceiro.Checked = False, "", dtpDataInicioFinanceiro.Value), _
                                     IIf(dtpDataFinalFinanceiro.Checked = False, "", dtpDataFinalFinanceiro.Value), _
                                     IIf(cboAtivoFiltro.SelectedIndex = -1, -1, cboAtivoFiltro.SelectedValue))
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


            'Verifica se foi Preenchido o Campo - Tipo de Combustível
            If ValidaCampo(cboContaContabil, lblContaContabil) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(dtpDataCompetencia, lblDataCompetencia) = False Then
                Exit Function
            End If

            If ValidaCampo(dtpDataFinanceiro, lblDataFinanceiro) = False Then
                Exit Function
            End If

            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código do Produto
            If ValidaCampo(txtValor, lblValor, TipoCampo.numero) = False Then
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
