Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadItemLote

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadItemLote As New clsusrCadItemLote

#End Region

#Region "::: CONTROLES :::"
    Private Sub TXTNumeroDesenho_LostFocus(sender As Object, e As EventArgs) Handles txtNumeroDesenho.LostFocus
        Try
            If txtNumeroDesenho.Text <> "" Then

                oClsCadItemLote.LoadGridItem(grdItens, txtNumeroDesenho.Text)

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub txtComplemento_ValueChanged() Handles txtComplemento.TextChanged

        Try

            txtDescricaoFinal.Text = txtDescricao.Text + IIf(cboTipo.SelectedValue = 1, "-", " ") + txtComplemento.Text

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtComplemento2_ValueChanged() Handles txtComplemento2.TextChanged

        Try

            txtDescricaoFinal2.Text = txtDescricao2.Text + IIf(cboTipo.SelectedValue = 1, "-", " ") + txtComplemento2.Text

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipo_SelectedIndexChanged() Handles cboTipo.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboTipo.SelectedIndex <> -1 Then

                'Limpa Erro
                frmMain.errInfo.Clear()

                cboClasse.SelectedIndex = -1
                cboClasse.DataSource = Nothing
                Call LoadCombo(cboClasse, "sp_select_combo_cadastro_basico_classe_seng " & goUsuario.iEmpresa & "," & cboTipo.SelectedValue)

                lblClasse.Text = "Descrição (tipo):"
                txtSC.Text = 0
                txtDET.Text = 0
                chkDireito.Checked = False
                chkEsquerdo.Checked = False
                lblNumeroDesenho.Text = "Nº Desenho:"
                lblPartNumberFinal.Visible = True
                txtPartNumberFinal.Visible = True

                Select Case cboTipo.SelectedValue
                    Case 1 ' TOPO

                        lblClasse.Text = "Classe:"

                        txtSC.Visible = False
                        lblSC.Visible = False
                        txtDET.Visible = False
                        lblDET.Visible = False
                        chkDireito.Visible = False
                        chkEsquerdo.Visible = False
                        lblNumeroDesenho.Text = "Part Number:"
                        lblPartNumberFinal.Visible = False
                        txtPartNumberFinal.Visible = False


                    Case 2 ' SC

                        txtSC.Visible = True
                        lblSC.Visible = True
                        txtSC.ReadOnly = False
                        txtSC.BackColor = Color.White

                        txtDET.Visible = True
                        lblDET.Visible = True
                        txtDET.ReadOnly = True
                        txtDET.BackColor = Color.WhiteSmoke

                        chkDireito.Visible = True
                        chkEsquerdo.Visible = True


                    Case 3 ' det
                        txtSC.Visible = True
                        lblSC.Visible = True
                        txtSC.ReadOnly = False
                        txtSC.BackColor = Color.White

                        txtDET.Visible = True
                        lblDET.Visible = True
                        txtDET.ReadOnly = False
                        txtDET.BackColor = Color.White

                        chkDireito.Visible = True
                        chkEsquerdo.Visible = True


                End Select


            End If





        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboClasse_SelectedIndexChanged() Handles cboClasse.SelectedIndexChanged

        Try

            oClsCadItemLote.LoadDadosClasse(cboClasse.SelectedValue, _
                                            txtDescricao, _
                                            txtDescricao2, _
                                            cboNCM)


            txtDescricaoFinal.Text = txtDescricao.Text
            txtDescricaoFinal2.Text = txtDescricao2.Text


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadItemLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Try

            Select Case e.KeyCode


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadItemLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadItemLote_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdItens
            oForm.NomeFormulario = Formulario.CadastroBasicoItemLote
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdItens, Formulario.CadastroBasicoItemLote)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdItens)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

            Call NovoInsert()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Alterna Aba
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call NovoInsert()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoInsert()

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

    Private Sub grdItens_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdItens.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdItens, _
                                     Formulario.CadastroBasicoItemLote)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdItens_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdItens.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdItens.Name, _
                                     Formulario.CadastroBasicoItemLote, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtChanged() Handles txtNumeroDesenho.TextChanged, _
                                   txtSC.TextChanged, _
                                   txtDET.TextChanged, _
                                   chkDireito.CheckedChanged, _
                                   chkEsquerdo.CheckedChanged


        Try

            If cboTipo.SelectedValue = 1 Then 'Topo

                txtPartNumberFinal.Text = txtNumeroDesenho.Text


            Else


                'Concatena inicialmente o número do desenho
                txtPartNumberFinal.Text = txtNumeroDesenho.Text + "-"

                'Concatena o SC
                txtPartNumberFinal.Text += txtSC.Text + "-"

                'Concatena o Det
                txtPartNumberFinal.Text += txtDET.Text


                'Concatena o direito esquerdo para os subconjuntos
                If chkDireito.Checked = True And chkEsquerdo.Checked = True Then

                    txtPartNumberFinal.Text += "D+E"

                ElseIf chkDireito.Checked = True Then

                    txtPartNumberFinal.Text += "D"

                ElseIf chkEsquerdo.Checked = True Then

                    txtPartNumberFinal.Text += "E"

                End If

            End If




        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try



    End Sub

    Private Sub btnProcurarClasse_Click(sender As Object, e As EventArgs) Handles btnProcurarClasse.Click

        Try

            If ValidaCampo(cboTipo, lblTipo) = False Then Exit Sub

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindClasseSeng"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Classe"

            iCodigoTipoClasse = cboTipo.SelectedValue
            oComboBoxFind = cboClasse

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClasse.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged

    End Sub

    Private Sub btnNovo1_Click_1(sender As Object, e As EventArgs) Handles btnNovo1.Click
        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdItens_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdItens.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdItens.CurrentColumn) Then Exit Sub

            Select Case grdItens.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadItemLote_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito

            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoItemLote, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdItens, Formulario.CadastroBasicoItemLote)


            Call LoadCombo(cboTipo, "sp_select_combo_static_tipo_pn")
            Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

            'carrega inicialmente os dados
            oClsCadItemLote.LoadGridItem(grdItens, txtNumeroDesenho.Text)
            chkItemCompra.Checked = True

            'Seta Focu
            cboTipo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdItens) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadItemLote.Delete()

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

    Private Sub NovoInsert()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            Dim iTipo As Integer = cboTipo.SelectedValue
            Dim sNumeroDesenho As String = txtNumeroDesenho.Text
            Dim sSC As String = txtSC.Text
            Dim bDireito As Boolean = chkDireito.Checked
            Dim bEsquerdo As Boolean = chkEsquerdo.Checked

            'Limpa os campos
            LimparCamposGroupBox(grpDados)

            'Carrega os campos
            cboTipo.SelectedValue = iTipo
            txtNumeroDesenho.Text = sNumeroDesenho
            txtSC.Text = sSC
            chkDireito.Checked = bDireito : chkDireito.Enabled = True
            chkEsquerdo.Checked = bEsquerdo : chkEsquerdo.Enabled = True

            btnInserir.Tag = "" : btnInserir.Text = "Inserir"

            'Seta Focu
            cboClasse.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim iCodigo As Integer

            'Se tiver valor, update. Caso contrário insert
            If IsNumeric(btnInserir.Tag) Then

                oClsCadItemLote.Update(btnInserir.Tag, _
                                       cboTipo.SelectedValue, _
                                       cboClasse.SelectedValue, _
                                       txtDescricaoFinal.Text.Trim, _
                                       txtDescricaoFinal2.Text.Trim, _
                                       cboNCM.SelectedValue, _
                                       txtNumeroDesenho.Text.Trim, _
                                       txtSC.Text.Trim, _
                                       txtDET.Text.Trim, _
                                       txtPartNumberFinal.Text.Trim, _
                                       chkDireito.Checked, _
                                       chkEsquerdo.Checked, _
                                       chkItemCompra.Checked)

            Else

                'Se ambos checkebox, esquerdo e direito, estiverem selecionados, serão dois inserts
                'Pois serão gerados dois itens diferentes
                If chkDireito.Checked = True And chkEsquerdo.Checked = True Then
                    oClsCadItemLote.Insert(cboTipo.SelectedValue, _
                                            cboClasse.SelectedValue, _
                                            txtDescricaoFinal.Text.Trim, _
                                            txtDescricaoFinal2.Text.Trim, _
                                            cboNCM.SelectedValue, _
                                            txtNumeroDesenho.Text.Trim, _
                                            txtSC.Text.Trim, _
                                            txtDET.Text.Trim, _
                                            txtPartNumberFinal.Text.Trim.Replace("D+E", "D"), _
                                            iCodigo, _
                                            True, _
                                            False, _
                                            chkItemCompra.Checked)

                    oClsCadItemLote.Insert(cboTipo.SelectedValue, _
                                            cboClasse.SelectedValue, _
                                            txtDescricaoFinal.Text.Trim, _
                                            txtDescricaoFinal2.Text.Trim, _
                                            cboNCM.SelectedValue, _
                                            txtNumeroDesenho.Text.Trim, _
                                            txtSC.Text.Trim, _
                                            txtDET.Text.Trim, _
                                            txtPartNumberFinal.Text.Trim.Replace("D+E", "E"), _
                                            iCodigo, _
                                            False, _
                                            True, _
                                            chkItemCompra.Checked)


                Else
                    'Caso contrário apenas um normalmente
                    oClsCadItemLote.Insert(cboTipo.SelectedValue, _
                                            cboClasse.SelectedValue, _
                                            txtDescricaoFinal.Text.Trim, _
                                            txtDescricaoFinal2.Text.Trim, _
                                            cboNCM.SelectedValue, _
                                            txtNumeroDesenho.Text.Trim, _
                                            txtSC.Text.Trim, _
                                            txtDET.Text.Trim, _
                                            txtPartNumberFinal.Text.Trim, _
                                            iCodigo, _
                                            chkDireito.Checked, _
                                            chkEsquerdo.Checked, _
                                            chkItemCompra.Checked)

                End If

            End If

            'Carrega os dados
            oClsCadItemLote.LoadGridItem(grdItens, txtNumeroDesenho.Text)

            'Informa ao usuário
            frmMain.Informacao(Mensagem.RegistroInserido)

            btnExcluir.Enabled = True

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

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboClasse, lblClasse) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboNCM, lblNCM) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtDescricaoFinal, lblDescricaoFinal, TipoCampo.texto) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtNumeroDesenho, lblNumeroDesenho, TipoCampo.texto) = False Then
                Exit Function
            End If


            If cboTipo.SelectedValue = 2 Then ' sc

                If chkDireito.Checked = False And chkEsquerdo.Checked = False Then

                    MsgBox("Para SC, é necessário escolher ao menos [DIREITO] ou [ESQUERDO]!", MsgBoxStyle.Exclamation)
                    Exit Function

                End If

            End If




            'Verifica se o Código é Válido
            If oClsCadItemLote.ValidaCodigo(IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, 0), _
                                            txtPartNumberFinal.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblPartNumberFinal, "Este Código: " & txtPartNumberFinal.Text & " já está associado a outro Registro.")
                txtPartNumberFinal.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            btnInserir.Tag = "" : btnInserir.Text = "Inserir"
            cboClasse.SelectedIndex = -1 : cboClasse.DataSource = Nothing
            cboNCM.SelectedIndex = -1
            cboTipo.SelectedIndex = -1
            chkItemCompra.Checked = True
            txtComplemento.Text = ""
            txtComplemento2.Text = ""
            txtDescricao.Text = ""
            txtDescricao2.Text = ""
            txtDescricaoFinal.Text = ""
            txtDescricaoFinal2.Text = ""
            txtDET.Text = ""
            txtNumeroDesenho.Text = ""
            txtPartNumberFinal.Text = ""
            txtSC.Text = ""
            chkDireito.Checked = False : chkDireito.Enabled = True
            chkEsquerdo.Checked = False : chkEsquerdo.Enabled = True
            grdItens.DataSource = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoItemLote, gcUpdate) = True Then

                'Carrega Controles
                oClsCadItemLote.EditarProduto(grdItens.CurrentRow.Cells("codigo").Value, _
                                              cboTipo, _
                                              cboClasse, _
                                              cboNCM, _
                                              txtNumeroDesenho, _
                                              txtSC, _
                                              txtDET, _
                                              chkEsquerdo, _
                                              chkDireito, _
                                              txtPartNumberFinal, _
                                              chkItemCompra)

                btnInserir.Tag = grdItens.CurrentRow.Cells("codigo").Value : btnInserir.Text = "Atualizar"

                chkEsquerdo.Enabled = False
                chkDireito.Enabled = False

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

#End Region


    Private Sub txtChanged(sender As Object, e As EventArgs) Handles txtSC.TextChanged, txtNumeroDesenho.TextChanged, txtDET.TextChanged, chkEsquerdo.CheckedChanged, chkDireito.CheckedChanged

    End Sub
End Class
