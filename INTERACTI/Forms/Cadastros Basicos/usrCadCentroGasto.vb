Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadCentroGasto

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadCentroGasto As New clsUsrCadCentroGasto

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadCentroGasto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadTreeView() Else Control_Enter(sender)
                       
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadCentroGasto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CENTRO DE GASTO :::"

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
            Call LoadTreeView()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                Call Editar(oClsCadCentroGasto.CodigoCentroGasto)

                'Carrega a TreeView
                Call LoadTreeView()

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

    Private Sub cboTipoCentroGasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCentroGasto.SelectedIndexChanged

        Try

            If cboTipoCentroGasto.SelectedIndex = -1 Then
                'Desabilita Controles
                cboFormaRateioCentroGasto.Enabled = False : cboFormaRateioCentroGasto.SelectedIndex = -1
            Else
                If cboTipoCentroGasto.SelectedValue = CInt(TipoCentroGasto.CentroGastoAuxiliar) Then
                    'Habilita Controles
                    cboFormaRateioCentroGasto.Enabled = True
                Else
                    'Desabilita Controles
                    cboFormaRateioCentroGasto.Enabled = False : cboFormaRateioCentroGasto.SelectedIndex = -1
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvMain.NodeMouseDoubleClick

        Try

            'Verifica se o Nó é válido
            If IsNothing(e.Node) = True Then Exit Sub

            'Editar Grupo de Item
            Call Editar(e.Node.Tag)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadCentroGasto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcDelete)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboCentroGastoPai, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoCentroGasto, "sp_select_combo_static_tipo_centro_custo", False)
            Call LoadCombo(cboFormaRateioCentroGasto, "sp_select_combo_static_forma_rateio_centro_custo", False)
            Call LoadCombo(cboClassificacaoCentroGasto, "sp_select_combo_static_classificacao_centro_gasto")

            'Carrega TreeView
            Call LoadTreeView()

            'Seta Focu
            cboCentroGastoPai.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE GASTO :::"

    Private Sub Editar(ByVal iCodigoCentroGasto As Integer)

        Try

            'Verifica se o Usuário tem direito de Alterar
            If VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcUpdate) = True Then


                'Carrega Controles
                Call oClsCadCentroGasto.LoadControles(iCodigoCentroGasto, _
                                                      cboCentroGastoPai, _
                                                      cboTipoCentroGasto, _
                                                      txtCodigo, _
                                                      txtDescricao, _
                                                      cboFormaRateioCentroGasto, _
                                                      cboClassificacaoCentroGasto, _
                                                      cboAtivo)

                'Seta Controle
                btnSalvar.Tag = iCodigoCentroGasto

                'Seta Focu
                cboCentroGastoPai.Focus()

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

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoNode(trvMain) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoNode.Count = 1, " ", "s ") & gSelecaoNode.Count & " registro" & IIf(gSelecaoNode.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadCentroGasto.Delete()

                    'Limpa Formulário
                    Call Novo()

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
            cboCentroGastoPai.SelectedIndex = -1
            cboTipoCentroGasto.SelectedIndex = -1
            cboFormaRateioCentroGasto.SelectedIndex = -1
            txtCodigo.Text = ""
            btnSalvar.Tag = ""
            txtDescricao.Text = ""
            cboClassificacaoCentroGasto.SelectedIndex = -1
            cboAtivo.SelectedValue = True

            'Carrega Combo
            Call LoadCombo(cboCentroGastoPai, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboCentroGastoPai.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCentroGasto.CodigoCentroGasto = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadCentroGasto.CodigoCentroGastoPai = IIf(cboCentroGastoPai.SelectedIndex = -1, -1, cboCentroGastoPai.SelectedValue)
            oClsCadCentroGasto.CentroGasto = txtCodigo.Text.Trim
            oClsCadCentroGasto.Descricao = txtDescricao.Text.Trim
            oClsCadCentroGasto.CodigoTipoCentroGasto = cboTipoCentroGasto.SelectedValue
            oClsCadCentroGasto.CodigoFormaRateioCentroGasto = IIf(cboFormaRateioCentroGasto.SelectedIndex = -1, -1, cboFormaRateioCentroGasto.SelectedValue)
            oClsCadCentroGasto.CodigoClassificacaoCentroGasto = IIf(cboClassificacaoCentroGasto.SelectedIndex = -1, -1, cboClassificacaoCentroGasto.SelectedValue)
            oClsCadCentroGasto.Ativo = cboAtivo.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadCentroGasto.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadCentroGasto.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            oClsCadCentroGasto.LoadTreeView(trvMain, _
                                            txtCentroCustroFiltro.Text.Trim)

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

            'Verifica se foi Selecionado o Campo - Tipo de Centro de Gasto
            If ValidaCampo(cboTipoCentroGasto, lblTipoCentroGasto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma de Rateio do Centro de Gasto
            If cboFormaRateioCentroGasto.Enabled = True Then
                If ValidaCampo(cboFormaRateioCentroGasto, lblFormaRateioCentroGasto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se a Código preenchida é válida
            If oClsCadCentroGasto.ValidaCentroGasto(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                    txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Centro de Gasto: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Classificação Centro de Gasto
            If ValidaCampo(cboClassificacaoCentroGasto, lblClassificacaoCentroGasto) = False Then
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
