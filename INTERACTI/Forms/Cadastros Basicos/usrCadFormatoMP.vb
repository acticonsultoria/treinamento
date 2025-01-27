Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadFormatoMP


#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadFormatoMP As New clsUsrCadFormatoMP

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadArea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadArea_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadArea_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoArea
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoArea)

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
                                     Formulario.CadastroBasicoArea)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoArea, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboQuantidadeMedidas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboQuantidadeMedidas.SelectedIndexChanged
        If cboQuantidadeMedidas.SelectedValue = 1 Then
            lblMedida1.Visible = True
            txtMedida1.Visible = True
            lblMedida2.Visible = False
            txtMedida2.Visible = False
            lblMedida3.Visible = False
            txtMedida3.Visible = False
            lblMedida4.Visible = False
            txtMedida4.Visible = False
        End If
        If cboQuantidadeMedidas.SelectedValue = 2 Then
            lblMedida1.Visible = True
            txtMedida1.Visible = True
            lblMedida2.Visible = True
            txtMedida2.Visible = True
            lblMedida3.Visible = False
            txtMedida3.Visible = False
            lblMedida4.Visible = False
            txtMedida4.Visible = False
        End If
        If cboQuantidadeMedidas.SelectedValue = 3 Then
            lblMedida1.Visible = True
            txtMedida1.Visible = True
            lblMedida2.Visible = True
            txtMedida2.Visible = True
            lblMedida3.Visible = True
            txtMedida3.Visible = True
            lblMedida4.Visible = False
            txtMedida4.Visible = False
        End If
        If cboQuantidadeMedidas.SelectedValue = 4 Then
            lblMedida1.Visible = True
            txtMedida1.Visible = True
            lblMedida2.Visible = True
            txtMedida2.Visible = True
            lblMedida3.Visible = True
            txtMedida3.Visible = True
            lblMedida4.Visible = True
            txtMedida4.Visible = True
        End If

    End Sub

    Private Sub btnFormula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedida1.Click, _
                                                                                                  btnMedida2.Click, _
                                                                                                  btnMedida3.Click, _
                                                                                                  btnMedida4.Click, _
                                                                                                  btnDensidade.Click, _
                                                                                                  btnValor.Click, _
                                                                                                  btnSoma.Click, _
                                                                                                  btnSubtrai.Click, _
                                                                                                  btnMultiplica.Click, _
                                                                                                  btnDivide.Click, _
                                                                                                  btnAbreParenteses.Click, _
                                                                                                  btnFechaParenteses.Click, _
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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadArea_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcPrint)
            cboQuantidadeMedidas.Items.Add(1, 1)
            cboQuantidadeMedidas.Items.Add(2, 2)
            cboQuantidadeMedidas.Items.Add(3, 3)
            cboQuantidadeMedidas.Items.Add(4, 4)
            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoArea)

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
            If VerificaDireito(Formulario.CadastroBasicoArea, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    txtCodigo.Text = .Item("codigo_formato").Value
                    txtDescricao.Text = .Item("descricao").Value
                    btnSalvar.Tag = .Item("codigo").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    cboQuantidadeMedidas.SelectedValue = .Item("quantidade_medidas").Value
                    cboQuantidadeMedidas.Text = .Item("quantidade_medidas").Value
                    txtMedida1.Text = .Item("nome_medida1").Value
                    txtMedida2.Text = .Item("nome_medida2").Value
                    txtMedida3.Text = .Item("nome_medida3").Value
                    txtMedida4.Text = .Item("nome_medida4").Value
                    txtFormula.Text = .Item("formula").Value

                End With

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

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrCadFormatoMP.Delete()

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
            txtCodigo.Text = ""
            txtDescricao.Text = ""
            btnSalvar.Tag = ""
            cboAtivo.SelectedValue = True
            cboQuantidadeMedidas.SelectedIndex = -1
            txtMedida1.Text = ""
            txtMedida2.Text = ""
            txtMedida3.Text = ""
            txtMedida4.Text = ""
            txtFormula.Text = ""
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
            oClsUsrCadFormatoMP.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsUsrCadFormatoMP.CodigoFormatoMP = txtCodigo.Text.Trim
            oClsUsrCadFormatoMP.Descricao = txtDescricao.Text.Trim
            oClsUsrCadFormatoMP.Ativo = cboAtivo.SelectedValue
            oClsUsrCadFormatoMP.QuantidadeMedidas = cboQuantidadeMedidas.SelectedValue
            oClsUsrCadFormatoMP.NomeMedida1 = IIf(txtMedida1.Visible = True, txtMedida1.Text, "")
            oClsUsrCadFormatoMP.NomeMedida2 = IIf(txtMedida2.Visible = True, txtMedida2.Text, "")
            oClsUsrCadFormatoMP.NomeMedida3 = IIf(txtMedida3.Visible = True, txtMedida3.Text, "")
            oClsUsrCadFormatoMP.NomeMedida4 = IIf(txtMedida4.Visible = True, txtMedida4.Text, "")
            oClsUsrCadFormatoMP.Formula = IIf(tabMain.TabPages.Contains(pagDados) = False, "", txtFormula.Text.Trim)

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsUsrCadFormatoMP.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsUsrCadFormatoMP.Insert()
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
            oClsUsrCadFormatoMP.LoadGrid(grdListagem, _
                                 txtCodigoFiltro.Text.Trim, _
                                 txtDescricaoFiltro.Text.Trim,
                                 txtQuantidadeMedidas.Text)

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

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Código é Válido
            If oClsUsrCadFormatoMP.ValidaCodigo(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                        txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
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

                btnMedida1.Enabled = True
                btnMedida2.Enabled = True
                btnMedida3.Enabled = True
                btnMedida4.Enabled = True
                btnDensidade.Enabled = True
                btnValor.Enabled = True

            ElseIf Mid(txtFormula.Text, txtFormula.Text.Length, 1) = "|" Or Mid(txtFormula.Text, txtFormula.Text.Length, 1) = ")" Then

                btnSoma.Enabled = True
                btnSubtrai.Enabled = True
                btnMultiplica.Enabled = True
                btnDivide.Enabled = True
                btnAbreParenteses.Enabled = False

                btnMedida1.Enabled = False
                btnMedida2.Enabled = False
                btnMedida3.Enabled = False
                btnMedida4.Enabled = False
                btnDensidade.Enabled = False
                btnValor.Enabled = False

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

                btnMedida1.Enabled = True
                btnMedida2.Enabled = True
                btnMedida3.Enabled = True
                btnMedida4.Enabled = True
                btnDensidade.Enabled = True
                btnValor.Enabled = True

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


End Class
