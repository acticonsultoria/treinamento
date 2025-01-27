Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class usrCadProdutoRoteiroProducao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadProduto As New clsUsrCadProduto

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadProdutoRoteiroProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", False)
                        Case "cboModeloRoteiroProducao" : Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)
                        Case "cboCentroTrabalho" : Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
                        Case "cboOperacao" : Call cboCentroTrabalho_SelectedIndexChanged(cboCentroTrabalho, System.EventArgs.Empty)
                        Case "cboProdutoImportar" : Call LoadCombo(cboProdutoImportar, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F3

                    Select Case sender.Name
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                    End Select

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboModeloRoteiroProducao" : Call btnCadastrarModeloRoteiroProducao_Click(btnCadastrarModeloRoteiroProducao, System.EventArgs.Empty)
                        Case "cboCentroTrabalho" : Call btnCadastrarCentroTrabalho_Click(btnCadastrarCentroTrabalho, System.EventArgs.Empty)
                        Case "cboOperacao" : Call btnCadastrarOperacao_Click(btnCadastrarOperacao, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadProdutoRoteiroProducao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REVISÃO :::"

    Private Sub btnCadastrarProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarProduto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", False)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProdutoImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProdutoImportar.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboProdutoImportar

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProdutoImportar.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarModeloRoteiroProducao_Click(sender As Object, e As EventArgs) Handles btnCadastrarModeloRoteiroProducao.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProdutoModeloRoteiroProducao")

            'Carrega Combo
            Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

            'Seta Focu
            cboModeloRoteiroProducao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        Try

            'Limpa Formulário
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida o Campo
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Sub
            End If

            Call NovoRevisao()

            'Desabilita Controles
            cboProduto.Enabled = False
            cboModeloRoteiroProducao.Enabled = False
            cboRevisao.SelectedIndex = -1
            dtpDataInicioNovo.Value = Now.Date
            cboRevisao.Enabled = False

            'Habilita Dados
            tabDados.Enabled = True
            tabDados.SelectedTab = pagRevisao

            'Desabilita Controles
            btnAprovar.Enabled = False

            'Habilita Controle
            grpNovo.Enabled = True
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
            cboProdutoImportar.SelectedValue = cboProduto.SelectedValue
            If cboModeloRoteiroImportar.Items.Count = 1 Then
                cboModeloRoteiroImportar.SelectedIndex = 0
            End If
            'Seta Focu
            txtRevisaoNovo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoRevisao() Then

                'Insere Revisao
                Call oClsCadProduto.InsertRoteiroRevisao(cboProduto.SelectedValue, _
                                                         cboModeloRoteiroProducao.SelectedValue, _
                                                         txtRevisaoNovo.Text.Trim, _
                                                         dtpDataInicioNovo.Value, _
                                                         "", _
                                                         IIf(cboProdutoImportar.SelectedIndex = -1, -1, cboProdutoImportar.SelectedValue), _
                                                         IIf(cboModeloRoteiroImportar.SelectedIndex = -1, -1, cboModeloRoteiroImportar.SelectedValue), _
                                                         IIf(cboRevisaoImportar.SelectedIndex = -1, -1, cboRevisaoImportar.SelectedValue))

                'Carrega Combo - Revisão
                Call LoadCombo(cboRevisao, "sp_select_combo_cadastro_basico_item_roteiro_revisao " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue & ", " & cboModeloRoteiroProducao.SelectedValue, False)

                'Seta Combo
                cboRevisao.SelectedValue = txtRevisaoNovo.Text.Trim
                cboRevisao.Enabled = True : cboRevisao.Focus()

                'Desabilida Controles
                grpNovo.Enabled = False
                txtRevisaoNovo.Text = ""
                dtpDataInicioNovo.Value = Now.Date
                btnSalvar.Enabled = False

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAprovar_Click(sender As Object, e As EventArgs) Handles btnAprovar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Informado algum Roteiro
            If grdRoteiro.GetDataRows.Count = 0 Then
                If MsgBox("Não foi informado nenhuma Operação para o Roteiro. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    tabDados.SelectedTab = pagRoteiro
                    txtSequencia.Focus()
                    Exit Sub
                End If
            End If

            'Verifica se o Usuário deseja Aprovar a Revisão
            If MsgBox("Confirma a Aprovação da Revisão: " & cboRevisao.Text & " para o Roteiro de Produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Aprova Revisão
                Call oClsCadProduto.AprovarRoteiroRevisao(cboProduto.SelectedValue, _
                                                          cboModeloRoteiroProducao.SelectedValue, _
                                                          cboRevisao.SelectedValue)

                'Recarrega Controles
                Call cboRevisao_SelectedIndexChanged(cboRevisao, System.EventArgs.Empty)

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

    Private Sub cboProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Váriavel - Classe
                Dim oClsCadProduto As New clsUsrCadProduto
                'Carrega Dados do Controle
                Call oClsCadProduto.LoadDadosProduto(cboProduto.SelectedValue, txtDescricao)
                'Carrega Combo
                Call LoadCombo(cboModeloRoteiroProducao, "sp_select_combo_cadastro_basico_item_modelo_roteiro_producao " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, False)
                'Habilita Controle
                cboModeloRoteiroProducao.Enabled = True
                If cboModeloRoteiroProducao.Items.Count = 1 Then
                    cboModeloRoteiroProducao.SelectedIndex = 0
                End If

            Else

                'Limpa Controles
                txtDescricao.Text = ""
                cboModeloRoteiroProducao.Text = ""
                cboModeloRoteiroProducao.Enabled = False
                'Limpa Dados da Revisão
                Call NovoRevisao()
                'Desabilita Controles
                btnNovo.Enabled = False
                btnSalvar.Enabled = False

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboModeloRoteiroProducao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModeloRoteiroProducao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboModeloRoteiroProducao.SelectedIndex <> -1 Then

                'Carrega Combo
                Call LoadCombo(cboRevisao, "sp_select_combo_cadastro_basico_item_roteiro_revisao " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue & ", " & cboModeloRoteiroProducao.SelectedValue, False)
                'Habilita Controle
                cboRevisao.Enabled = True
                btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)

                If cboRevisao.Items.Count = 1 Then
                    cboRevisao.SelectedIndex = 0
                End If

            Else

                'Limpa Controles
                cboRevisao.SelectedIndex = -1
                cboRevisao.Text = ""
                cboRevisao.Enabled = False
                'Desabilita Controles
                btnNovo.Enabled = False
                btnSalvar.Enabled = False

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboRevisao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRevisao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboRevisao.SelectedIndex = -1 Then

                'Limpa Controles - Revisão
                grdRoteiro.DataSource = Nothing
                txtRevisaoNovo.Text = ""
                dtpDataInicioNovo.Value = Now.Date
                lblRevisaoInfo.Text = "-"
                lblDataInicioRevisaoInfo.Text = "-"
                lblDataValidadeRevisaoInfo.Text = "-"
                lblStatusRevisaoInfo.Text = "-" : lblStatusRevisaoInfo.BackColor = Color.Transparent
                lblElaboradoPorRevisaoInfo.Text = "-"
                lblAprovadoPorRevisaoInfo.Text = "-"
                lblQuantidadeOrdemProducaoTryoutRevisaoInfo.Text = "-"
                lblQuantidadeOrdemProducaoRevisaoInfo.Text = "-"
                lblQuantidadeRejeitoRevisaoInfo.Text = "-"
                lblTempoEstimadoMaoObraRevisaoInfo.Text = "-"
                lblTempoMedioProducaoRevisaoInfo.Text = "-"

                'Limpa Controles - Roteiro
                txtSequencia.Value = 1
                cboCentroTrabalho.SelectedIndex = -1
                cboOperacao.SelectedIndex = -1
                cboSequenciaPredecessora.SelectedIndex = -1
                txtObservacao.Text = ""
                cboAponta.SelectedIndex = -1 : cboAponta.Enabled = True
                cboApontaEquipamento.SelectedIndex = -1 : cboApontaEquipamento.Enabled = True
                cboApontamentoConcorrente.SelectedIndex = -1 : cboApontamentoConcorrente.Enabled = True
                cboControlaQualidade.SelectedIndex = -1
                txtTempoSetupMaquina.Text = "00:00:00"
                txtTempoMaquina.Text = "00:00:00"
                txtTempoMaoObra.Text = "00:00:00"
                txtReferencia.Value = 0
                btnInserir.Tag = ""
                grdRoteiro.DataSource = Nothing

                'Limpa Controles - Qualidade
                cboRoteiro.SelectedIndex = -1
                cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
                cboApontaQualidade.SelectedIndex = -1
                txtValorNominalQualidade.Value = 0
                txtValorMinimoQualidade.Value = 0
                txtValorMaximoQualidade.Value = 0
                txtFrequenciaQualidade.Value = 0
                txtObservacaoQualidade.Text = ""
                btnInserirQualidade.Tag = ""
                grdQualidade.DataSource = Nothing

                'Limpa Controles - BOM
                grdBOM.DataSource = Nothing

                'Remove Páginas
                If tabDados.TabPages.Contains(pagRoteiro) Then tabDados.TabPages.Remove(pagRoteiro)
                If tabDados.TabPages.Contains(pagQualidade) Then tabDados.TabPages.Remove(pagQualidade)
                If tabDados.TabPages.Contains(pagRequisicaoEstoque) Then tabDados.TabPages.Remove(pagRequisicaoEstoque)

            Else

                'Carrega Controles - Dados da Revisao
                Call oClsCadProduto.LoadDadosRoteiroRevisao(cboProduto.SelectedValue, _
                                                            cboModeloRoteiroProducao.SelectedValue, _
                                                            cboRevisao.SelectedValue, _
                                                            lblRevisaoInfo, _
                                                            lblDataInicioRevisaoInfo, _
                                                            lblDataValidadeRevisaoInfo, _
                                                            lblStatusRevisaoInfo, _
                                                            lblElaboradoPorRevisaoInfo, _
                                                            lblAprovadoPorRevisaoInfo, _
                                                            lblQuantidadeOrdemProducaoTryoutRevisaoInfo, _
                                                            lblQuantidadeOrdemProducaoRevisaoInfo, _
                                                            lblQuantidadeRejeitoRevisaoInfo, _
                                                            lblTempoEstimadoMaoObraRevisaoInfo, _
                                                            lblTempoEstimadoSetupRevisaoInfo, _
                                                            lblTempoEstimadoMaquinaRevisaoInfo, _
                                                            lblTempoMedioProducaoRevisaoInfo)

                'Carrega Grid - Roteiro
                Call oClsCadProduto.LoadGridRoteiro(grdRoteiro, _
                                                    cboProduto.SelectedValue, _
                                                    cboModeloRoteiroProducao.SelectedValue, _
                                                    cboRevisao.SelectedValue)

                'Carrega Grid - Qualidade
                Call oClsCadProduto.LoadGridQualidadeRoteiro(grdQualidade, _
                                                             cboProduto.SelectedValue, _
                                                             cboModeloRoteiroProducao.SelectedValue, _
                                                             cboRevisao.SelectedValue)

                'Carrega Grid - BOM
                Call oClsCadProduto.LoadGridBOMRoteiro(grdBOM, _
                                                       cboProduto.SelectedValue, _
                                                       cboModeloRoteiroProducao.SelectedValue, _
                                                       cboRevisao.SelectedValue)

                'Carrega Combo
                Call LoadCombo(cboSequenciaPredecessora, "sp_select_combo_cadastro_basico_item_roteiro_sequencia " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue & ", " & cboModeloRoteiroProducao.SelectedValue & ", '" & cboRevisao.SelectedValue & "', NULL")

                'Verifica Status
                Select Case lblStatusRevisaoInfo.Tag
                    Case CInt(StatusRevisaoRoteiro.EmElaboracao)
                        lblStatusRevisaoInfo.BackColor = Color.Yellow
                        btnAprovar.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcAdministrator)
                        btnInserir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
                        btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcDelete)
                        btnInserirQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
                        btnExcluirQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcDelete)
                    Case CInt(StatusRevisaoRoteiro.EmProducao)
                        lblStatusRevisaoInfo.BackColor = Color.ForestGreen
                        btnAprovar.Enabled = False
                        btnInserir.Enabled = False
                        btnExcluir.Enabled = False
                        btnInserirQualidade.Enabled = False
                        btnExcluirQualidade.Enabled = False
                    Case CInt(StatusRevisaoRoteiro.Revisado)
                        lblStatusRevisaoInfo.BackColor = Color.Firebrick
                        btnAprovar.Enabled = False
                        btnInserir.Enabled = False
                        btnExcluir.Enabled = False
                        btnInserirQualidade.Enabled = False
                        btnExcluirQualidade.Enabled = False
                    Case CInt(StatusRevisaoRoteiro.Futuro)
                        lblStatusRevisaoInfo.BackColor = Color.SteelBlue
                        btnAprovar.Enabled = False
                        btnInserir.Enabled = False
                        btnExcluir.Enabled = False
                        btnInserirQualidade.Enabled = False
                        btnExcluirQualidade.Enabled = False
                End Select

                'Desabilita Controle
                grpNovo.Enabled = False

                'Habilita Abas
                tabDados.Enabled = True
                tabDados.SelectedTab = pagRevisao

                'Adiciona Páginas
                If tabDados.TabPages.Contains(pagRoteiro) = False Then tabDados.TabPages.Add(pagRoteiro)
                If tabDados.TabPages.Contains(pagQualidade) = False Then tabDados.TabPages.Add(pagQualidade)
                If tabDados.TabPages.Contains(pagRequisicaoEstoque) = False Then tabDados.TabPages.Add(pagRequisicaoEstoque)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProdutoImportar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProdutoImportar.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboProdutoImportar.SelectedIndex <> -1 Then

                'Váriavel - Classe
                Dim oClsCadProduto As New clsUsrCadProduto
                'Carrega Dados do Controle
                Call oClsCadProduto.LoadDadosProduto(cboProdutoImportar.SelectedValue, txtDescricaoImportar)
                'Carrega Combo
                Call LoadCombo(cboModeloRoteiroImportar, "sp_select_combo_cadastro_basico_item_modelo_roteiro_producao " & goUsuario.iEmpresa & ", " & cboProdutoImportar.SelectedValue, False)
                'Habilita Controle
                cboModeloRoteiroImportar.Enabled = True

            Else

                'Limpa Controles
                txtDescricaoImportar.Text = ""
                cboModeloRoteiroImportar.Text = ""
                cboModeloRoteiroImportar.Enabled = False

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboModeloRoteiroImportar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModeloRoteiroImportar.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboModeloRoteiroImportar.SelectedIndex <> -1 Then

                'Carrega Combo
                Call LoadCombo(cboRevisaoImportar, "sp_select_combo_cadastro_basico_item_roteiro_revisao " & goUsuario.iEmpresa & ", " & cboProdutoImportar.SelectedValue & ", " & cboModeloRoteiroImportar.SelectedValue, False)
                'Habilita Controle
                cboRevisaoImportar.Enabled = True

            Else

                'Limpa Controles
                cboRevisaoImportar.SelectedIndex = -1
                cboRevisaoImportar.Text = ""
                cboRevisaoImportar.Enabled = False

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grpDadosQualidade_Resize(sender As Object, e As EventArgs) Handles grpDadosQualidade.Resize

        Try

            'Váriavel
            Dim dProporcao As Double = CDbl(grpDadosQualidade.Size.Height) / CDbl(grpDadosQualidade.Tag)

            'Centraliza Controles
            For Each oControl As Control In grpDadosQualidade.Controls
                oControl.Top = (oControl.Top * dProporcao)
            Next

            grpDadosQualidade.Tag = grpDadosQualidade.Size.Height

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Verifica a Aba Selecionada
            Select Case e.Page.Key

                Case "pagRoteiro"
                    'Limpa Controles - Contato
                    txtSequencia.Value = 0
                    For Each oRow As GridEXRow In grdRoteiro.GetDataRows
                        txtSequencia.Value = IIf(oRow.Cells("sequencia").Value > txtSequencia.Value, oRow.Cells("sequencia").Value, txtSequencia.Value)
                    Next
                    txtSequencia.Value = txtSequencia.Value + 1
                    txtSequencia.Focus()

                Case "pagQualidade"
                    If cboRevisao.SelectedIndex > -1 Then
                        Call LoadCombo(cboRoteiro, "sp_select_combo_cadastro_basico_item_roteiro_sequencia " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue & ", " & cboModeloRoteiroProducao.SelectedValue & ", '" & cboRevisao.SelectedValue & "', 1")
                        cboRoteiro.Focus()
                    End If

                Case "pagRequisicaoEstoque"
                    If cboRevisao.SelectedIndex > -1 Then
                        Call LoadComboGrid(grdBOM, "sequencia", "sp_select_combo_cadastro_basico_item_roteiro_sequencia " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue & ", " & cboModeloRoteiroProducao.SelectedValue & ", '" & cboRevisao.SelectedValue & "', NULL")
                        grdBOM.Focus()
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ROTEIRO :::"

    Private Sub btnAgruparGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRoteiro.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRoteiro.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRoteiro.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRoteiro.GroupByBoxVisible = True
                grdRoteiro.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRoteiro.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRoteiro
            oForm.NomeFormulario = Formulario.CadastroBasicoProdutoRoteiroProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRoteiro, Formulario.CadastroBasicoProdutoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridRoteiro.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdRoteiro)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroTrabalho.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroTrabalho")

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroTrabalho.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarOperacao.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOperacao")

            If cboCentroTrabalho.SelectedIndex = -1 Then
                cboOperacao.DataSource = Nothing
                cboOperacao.Text = ""
            Else
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

            'Seta Focu
            cboOperacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Roteiro
            If ValidacaoRoteiro() = True Then

                'Salva Roteiro
                Call SalvarRoteiro()

                'Carrega Grid
                Call oClsCadProduto.LoadGridRoteiro(grdRoteiro, _
                                                    cboProduto.SelectedValue, _
                                                    cboModeloRoteiroProducao.SelectedValue, _
                                                    cboRevisao.SelectedValue)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoRoteiro()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Roteiro
            Call DeleteRoteiro()

            'Limpa Formulário
            Call NovoRoteiro()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCentroTrabalho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroTrabalho.SelectedItemChanged

        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboCentroTrabalho.SelectedIndex = -1 Then
                'Limpa Controle
                cboOperacao.DataSource = Nothing : cboOperacao.Text = ""
            Else
                cboAponta.Enabled = CType(LoadDescricao("sp_select_cadastro_basico_centro_trabalho_local_processamento " & goUsuario.iEmpresa & ", " & cboCentroTrabalho.SelectedValue), Boolean)
                If cboAponta.Enabled = False Then cboAponta.SelectedValue = False
                'Carrega Combo
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboAponta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAponta.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboAponta.SelectedIndex = -1 Then
                cboApontaEquipamento.Enabled = False : cboApontaEquipamento.SelectedIndex = -1
                cboApontamentoConcorrente.Enabled = False : cboApontamentoConcorrente.SelectedIndex = -1
            Else
                If cboAponta.SelectedValue = False Then
                    cboApontaEquipamento.Enabled = False : cboApontaEquipamento.SelectedIndex = -1
                    cboApontamentoConcorrente.Enabled = False : cboApontamentoConcorrente.SelectedIndex = -1
                Else
                    cboApontaEquipamento.Enabled = True
                    cboApontamentoConcorrente.Enabled = True
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRoteiro.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdRoteiro.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdRoteiro.CurrentColumn.Key

                Case "editar" : Call EditarRoteiro()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRoteiro.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRoteiro, _
                                     Formulario.CadastroBasicoProdutoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRoteiro.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRoteiro.Name, _
                                     Formulario.CadastroBasicoProdutoRoteiroProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdRoteiro.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRoteiro.Name, _
                                          Formulario.CadastroBasicoProdutoRoteiroProducao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub btnAgruparGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridQualidade.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdQualidade.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdQualidade.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdQualidade.GroupByBoxVisible = True
                grdQualidade.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridQualidade.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdQualidade
            oForm.NomeFormulario = Formulario.CadastroBasicoProdutoRoteiroProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidade, Formulario.CadastroBasicoProdutoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridQualidade.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdQualidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCaracteristicaInspecionarQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCaracteristicaInspecionarQualidade.Click

        Try

              'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadQualidadeCaracteristicaInspecionar")

            'Carrega Combo
            Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa)

            'Seta Focu
            cboCaracteristicaInspecionarQualidade.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirQualidade.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoQualidade() = True Then

                'Salva Qualidade
                Call SalvarQualidade()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoQualidade()

                'Carrega Grid
                Call oClsCadProduto.LoadGridQualidadeRoteiro(grdQualidade, _
                                                             cboProduto.SelectedValue, _
                                                             cboModeloRoteiroProducao.SelectedValue, _
                                                             cboRevisao.SelectedValue)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirQualidade.Click

        Try

            'Deleta Qualidade
            Call DeleteQualidade()

            'Limpa Formulário
            Call NovoQualidade()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCaracteristicaInspecionarQualidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCaracteristicaInspecionarQualidade.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtValorNominalQualidade.Value = 0 : txtValorNominalQualidade.Enabled = False
            txtValorMinimoQualidade.Value = 0 : txtValorMinimoQualidade.Enabled = False
            txtValorMaximoQualidade.Value = 0 : txtValorMaximoQualidade.Enabled = False

            'Verifica se foi Selecionado algum Registro
            If cboCaracteristicaInspecionarQualidade.SelectedIndex > -1 Then

                'Váriaveis Locais
                Dim iCodigoTipoCaracteristicaInspecionar As Integer = CType(LoadDescricao("sp_select_cadastro_basico_qualidade_caracteristicas_inspecionar_tipo " & cboCaracteristicaInspecionarQualidade.SelectedValue & ", " & goUsuario.iEmpresa), Integer)

                'Verifica se é do Tipo Valor
                If iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor Then
                    'Habilita Controles
                    txtValorNominalQualidade.Enabled = True
                    txtValorMinimoQualidade.Enabled = True
                    txtValorMaximoQualidade.Enabled = True
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdQualidade.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdQualidade.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdQualidade.CurrentColumn.Key
                Case "editar" : Call EditarQualidade()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdQualidade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidade, _
                                     Formulario.CadastroBasicoProdutoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidade.Name, _
                                     Formulario.CadastroBasicoProdutoRoteiroProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdQualidade.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdQualidade.Name, _
                                          Formulario.CadastroBasicoProdutoRoteiroProducao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub btnAgruparGridBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridBOM.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdBOM.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdBOM.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdBOM.GroupByBoxVisible = True
                grdBOM.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridBOM.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdBOM
            oForm.NomeFormulario = Formulario.CadastroBasicoProdutoRoteiroProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdBOM, Formulario.CadastroBasicoProdutoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridBOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridBOM.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdBOM)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdBOM.CellValueChanged

        Try

            Dim iSequencia As Integer = -1

            If e.Column.Key = "sequencia" AndAlso grdBOM.CurrentRow.RowType = RowType.Record Then

                If IsNumeric(grdBOM.GetValue("sequencia")) Then
                    iSequencia = grdBOM.GetValue("sequencia")
                End If

                'Insere Registro
                Call oClsCadProduto.InsertBOMRoteiro(cboProduto.SelectedValue, _
                                                     cboModeloRoteiroProducao.SelectedValue, _
                                                     cboRevisao.SelectedValue, _
                                                     iSequencia, _
                                                     grdBOM.GetValue("codigo_item"))

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdBOM.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBOM, _
                                     Formulario.CadastroBasicoProdutoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdBOM.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBOM.Name, _
                                     Formulario.CadastroBasicoProdutoRoteiroProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBOM_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdBOM.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdBOM.Name, _
                                          Formulario.CadastroBasicoProdutoRoteiroProducao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadProdutoRoteiroProducao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcDelete)
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
            btnInserirQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcDelete)
            btnExcluirQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
            'Verifica Direito - Botão Cadastro            
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcInsert)
            btnCadastrarCentroTrabalho.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarOperacao.Enabled = VerificaDireito(Formulario.CadastroBasicoOperacao, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", False)
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboProdutoImportar, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", False)
            Call LoadComboSimNao(cboAponta)
            Call LoadComboSimNao(cboApontaEquipamento)
            Call LoadComboSimNao(cboApontamentoConcorrente)
            Call LoadComboSimNao(cboControlaQualidade)
            Call LoadComboSimNao(cboApontaQualidade)

            'Configura Grid
            Call ConfiguraGrid(grdRoteiro, Formulario.CadastroBasicoProdutoRoteiroProducao)
            Call ConfiguraGrid(grdQualidade, Formulario.CadastroBasicoProdutoRoteiroProducao)
            Call ConfiguraGrid(grdBOM, Formulario.CadastroBasicoProdutoRoteiroProducao)

            'Remove Páginas
            tabDados.TabPages.Remove(pagRoteiro)
            tabDados.TabPages.Remove(pagQualidade)
            tabDados.TabPages.Remove(pagRequisicaoEstoque)

            'Desabilita Controles
            btnSalvar.Enabled = False
            btnNovo.Enabled = False
            btnAprovar.Enabled = False

            'Limpa Controles
            Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

            cboAponta.SelectedValue = True
            cboApontaEquipamento.SelectedValue = False
            cboApontamentoConcorrente.SelectedValue = True
            cboControlaQualidade.SelectedValue = True
            txtReferencia.Value = 1

            'Seta Focu
            cboProduto.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REVISÃO :::"

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controle
            cboProduto.Enabled = True : cboProduto.Text = ""
            txtDescricao.Text = ""
            txtRevisaoNovo.Text = ""
            dtpDataInicioNovo.Value = Now.Date

            'Desabilita Controle
            btnSalvar.Enabled = False
            btnAprovar.Enabled = False

            'Limpa Revisao
            Call NovoRevisao()

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoRevisao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles            
            cboRevisao.Text = "" : cboRevisao.DataSource = Nothing : cboRevisao.Enabled = False

            'Limpa Controles - Dados Gerais
            lblRevisaoInfo.Text = "-"
            lblDataInicioRevisaoInfo.Text = "-"
            lblDataValidadeRevisaoInfo.Text = "-"
            lblStatusRevisaoInfo.Text = "-" : lblStatusRevisaoInfo.BackColor = Color.Transparent
            lblElaboradoPorRevisaoInfo.Text = "-"
            lblAprovadoPorRevisaoInfo.Text = "-"
            lblQuantidadeOrdemProducaoTryoutRevisaoInfo.Text = "-"
            lblQuantidadeOrdemProducaoRevisaoInfo.Text = "-"
            lblQuantidadeRejeitoRevisaoInfo.Text = "-"
            lblTempoEstimadoMaoObraRevisaoInfo.Text = "-"
            lblTempoMedioProducaoRevisaoInfo.Text = "-"

            'Limpa Gráfico
            chrMain.Series.Clear()

            'Limpa Controles - Roteiro
            txtSequencia.Value = grdRoteiro.GetDataRows.Count + 1
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            txtObservacao.Text = ""
            cboAponta.SelectedIndex = -1 : cboAponta.Enabled = True
            cboApontaEquipamento.SelectedIndex = -1 : cboApontaEquipamento.Enabled = True
            cboControlaQualidade.SelectedIndex = -1
            txtTempoSetupMaquina.Text = "00:00:00"
            txtTempoMaquina.Text = "00:00:00"
            txtTempoMaoObra.Text = "00:00:00"
            txtReferencia.Value = 0
            btnInserir.Tag = ""
            grdRoteiro.DataSource = Nothing

            'Limpa Controles - Qualidade
            cboRoteiro.SelectedIndex = -1
            cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
            txtValorNominalQualidade.Value = 0
            txtValorMinimoQualidade.Value = 0
            txtValorMaximoQualidade.Value = 0
            txtFrequenciaQualidade.Value = 0
            txtObservacaoQualidade.Text = ""
            btnInserirQualidade.Tag = ""
            grdQualidade.DataSource = Nothing

            'Desabilita Controle
            tabDados.Enabled = False
            tabDados.SelectedTab = pagRevisao

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRevisao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRevisao = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtRevisaoNovo, lblRevisaoNovo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Passa Parametros
            If oClsCadProduto.ValidaRoteiroRevisao(cboProduto.SelectedValue, _
                                                   cboModeloRoteiroProducao.SelectedValue, _
                                                   txtRevisaoNovo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblRevisaoNovo, "Esta Revisão: " & txtRevisaoNovo.Text & " já está associado ao Produto: " & cboProduto.Text & ".")
                txtRevisaoNovo.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRevisao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ROTEIRO :::"

    Private Sub NovoRoteiro()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            txtSequencia.Value = 0
            For Each oRow As GridEXRow In grdRoteiro.GetDataRows
                txtSequencia.Value = IIf(oRow.Cells("sequencia").Value > txtSequencia.Value, oRow.Cells("sequencia").Value, txtSequencia.Value)
            Next
            txtSequencia.Value = txtSequencia.Value + 1
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            cboSequenciaPredecessora.SelectedIndex = -1
            txtObservacao.Text = ""
            cboAponta.SelectedIndex = -1 : cboAponta.Enabled = True
            cboApontaEquipamento.SelectedIndex = -1 : cboApontaEquipamento.Enabled = True
            cboApontamentoConcorrente.SelectedIndex = -1 : cboApontamentoConcorrente.Enabled = True
            cboControlaQualidade.SelectedIndex = -1
            txtTempoSetupMaquina.Text = "00:00:00"
            txtTempoMaquina.Text = "00:00:00"
            txtTempoMaoObra.Text = "00:00:00"
            txtReferencia.Value = 0
            btnInserir.Tag = ""

            'Carrega Combo
            If cboRevisao.SelectedIndex > -1 Then
                Call LoadCombo(cboSequenciaPredecessora, "sp_select_combo_cadastro_basico_item_roteiro_sequencia " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue & ", " & cboModeloRoteiroProducao.SelectedValue & ", '" & cboRevisao.SelectedValue & "', NULL")
            Else
                cboSequenciaPredecessora.DataSource = Nothing : cboSequenciaPredecessora.Text = ""
            End If

            'Habilita Controle
            cboProduto.Enabled = True

            'Seta Focu
            txtSequencia.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRoteiro()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRoteiro) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadProduto.DeleteRoteiro(cboProduto.SelectedValue, _
                                                      cboModeloRoteiroProducao.SelectedValue, _
                                                      cboRevisao.SelectedValue)

                    'Prepara Formulário
                    Call NovoRoteiro()

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

    Private Sub EditarRoteiro()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcUpdate) = True Then

                With grdRoteiro.CurrentRow.Cells

                    'Carrega Controles
                    txtSequencia.Value = .Item("sequencia").Value
                    cboCentroTrabalho.SelectedValue = .Item("codigo_centro_trabalho").Value
                    cboOperacao.SelectedValue = .Item("codigo_operacao").Value
                    txtObservacao.Text = IIf(IsDBNull(.Item("observacao").Value), "", .Item("observacao").Value)
                    txtTempoSetupMaquina.Text = .Item("tempo_setup_maquina").Value
                    txtTempoMaoObra.Text = .Item("tempo_mao_obra").Value
                    txtTempoMaquina.Text = .Item("tempo_maquina").Value
                    txtReferencia.Value = .Item("referencia").Value
                    cboAponta.SelectedValue = .Item("aponta").Value
                    cboApontaEquipamento.SelectedValue = .Item("aponta_equipamento").Value
                    cboApontamentoConcorrente.SelectedValue = .Item("apontamento_concorrente").Value
                    cboControlaQualidade.SelectedValue = .Item("controla_qualidade").Value
                    btnInserir.Tag = .Item("sequencia").Value

                    'Desabilita Controle
                    cboProduto.Enabled = False

                End With

                'Seta Focu
                txtSequencia.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRoteiro()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) Then

                'Altera Registro
                Call oClsCadProduto.UpdateRoteiro(cboProduto.SelectedValue, _
                                                  cboModeloRoteiroProducao.SelectedValue, _
                                                  cboRevisao.Text, _
                                                  txtSequencia.Value, _
                                                  cboCentroTrabalho.SelectedValue, _
                                                  cboOperacao.SelectedValue, _
                                                  IIf(cboSequenciaPredecessora.SelectedIndex = -1, -1, cboSequenciaPredecessora.Text), _
                                                  ((txtTempoSetupMaquina.Text.Split(":")(0) * 60) + txtTempoSetupMaquina.Text.Split(":")(1) + (txtTempoSetupMaquina.Text.Split(":")(2) / 60)), _
                                                  IIf(txtReferencia.Value = 0, 0, ((txtTempoMaoObra.Text.Split(":")(0) * 60) + txtTempoMaoObra.Text.Split(":")(1) + (txtTempoMaoObra.Text.Split(":")(2) / 60)) / txtReferencia.Value), _
                                                  IIf(txtReferencia.Value = 0, 0, ((txtTempoMaquina.Text.Split(":")(0) * 60) + txtTempoMaquina.Text.Split(":")(1) + (txtTempoMaquina.Text.Split(":")(2) / 60)) / txtReferencia.Value), _
                                                  txtReferencia.Value, _
                                                  IIf(cboAponta.Enabled = True, cboAponta.SelectedValue, False), _
                                                  IIf(cboApontaEquipamento.Enabled = True, cboApontaEquipamento.SelectedValue, False), _
                                                  IIf(cboApontamentoConcorrente.Enabled = True, cboApontamentoConcorrente.SelectedValue, False), _
                                                  IIf(cboControlaQualidade.Enabled = True, cboControlaQualidade.SelectedValue, False), _
                                                  txtObservacao.Text.Trim, _
                                                  grdRoteiro.CurrentRow.Cells("sequencia").Value)

            Else

                'Insere Registro
                Call oClsCadProduto.InsertRoteiro(cboProduto.SelectedValue, _
                                                  cboModeloRoteiroProducao.SelectedValue, _
                                                  cboRevisao.Text, _
                                                  txtSequencia.Value, _
                                                  cboCentroTrabalho.SelectedValue, _
                                                  cboOperacao.SelectedValue, _
                                                  IIf(cboSequenciaPredecessora.SelectedIndex = -1, -1, cboSequenciaPredecessora.Text), _
                                                  ((txtTempoSetupMaquina.Text.Split(":")(0) * 60) + txtTempoSetupMaquina.Text.Split(":")(1) + (txtTempoSetupMaquina.Text.Split(":")(2) / 60)), _
                                                  IIf(txtReferencia.Value = 0, 0, ((txtTempoMaoObra.Text.Split(":")(0) * 60) + txtTempoMaoObra.Text.Split(":")(1) + (txtTempoMaoObra.Text.Split(":")(2) / 60)) / txtReferencia.Value), _
                                                  IIf(txtReferencia.Value = 0, 0, ((txtTempoMaquina.Text.Split(":")(0) * 60) + txtTempoMaquina.Text.Split(":")(1) + (txtTempoMaquina.Text.Split(":")(2) / 60)) / txtReferencia.Value), _
                                                  txtReferencia.Value, _
                                                  IIf(cboAponta.Enabled = True, cboAponta.SelectedValue, False), _
                                                  IIf(cboApontaEquipamento.Enabled = True, cboApontaEquipamento.SelectedValue, False), _
                                                  IIf(cboApontamentoConcorrente.Enabled = True, cboApontamentoConcorrente.SelectedValue, False), _
                                                  IIf(cboControlaQualidade.Enabled = True, cboControlaQualidade.SelectedValue, False), _
                                                  txtObservacao.Text.Trim)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRoteiro() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRoteiro = False

            'Verifica se foi Selecionado o Campo - Revisão
            If ValidaCampo(cboRevisao, lblRevisao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(txtSequencia, lblSequencia, True) = False Then
                Exit Function
            End If

            'Verifica se já existe o Item Inserido
            If grdRoteiro.GetDataRows.Count > 0 Then
                If IsNumeric(btnInserir.Tag) Then
                    If VerificaExisteValorGrid(grdRoteiro, "sequencia", txtSequencia.Value, IIf(IsNumeric(btnInserir.Tag), grdRoteiro.CurrentRow.RowIndex, grdRoteiro.CurrentRow.Cells("sequencia").Value)) = True Then
                        frmMain.errInfo.SetError(lblSequencia, "Esta Sequência: " & txtSequencia.Value & " já se encontra cadastrado para este Roteiro.")
                        txtSequencia.Focus()
                        Exit Function
                    End If
                Else
                    If VerificaExisteValorGrid(grdRoteiro, "sequencia", txtSequencia.Value, IIf(IsNumeric(btnInserir.Tag), grdRoteiro.CurrentRow.RowIndex, -1)) = True Then
                        frmMain.errInfo.SetError(lblSequencia, "Esta Sequência: " & txtSequencia.Value & " já se encontra cadastrado para este Roteiro.")
                        txtSequencia.Focus()
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Selecionado o Campo - Centro de Trabalho
            If ValidaCampo(cboCentroTrabalho, lblCentroTrabalho) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Operação
            If ValidaCampo(cboOperacao, lblOperacao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Aponta
            If cboAponta.Enabled = True Then
                If ValidaCampo(cboAponta, lblAponta) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Aponta Equipamento
            If cboApontaEquipamento.Enabled = True Then
                If ValidaCampo(cboApontaEquipamento, lblApontaEquipamento) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Aponta Concorrente
            If cboApontamentoConcorrente.Enabled = True Then
                If ValidaCampo(cboApontamentoConcorrente, lblApontamentoConcorrente) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Tempo de Setup
            If ValidaCampo(txtTempoSetupMaquina, lblTempoSetupMaquina, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tempo de M.O.
            If ValidaCampo(txtTempoMaoObra, lblTempoMaoObra, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tempo de Máquina
            If ValidaCampo(txtTempoMaquina, lblTempoMaquina, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Referência
            If ValidaCampo(txtReferencia, lblReferencia, False) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRoteiro = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: QUALIDADE :::"

    Private Sub SalvarQualidade()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirQualidade.Tag) Then

                'Atualiza Registro
                Call oClsCadProduto.UpdateQualidadeRoteiro(cboProduto.SelectedValue, _
                                                           cboModeloRoteiroProducao.SelectedValue, _
                                                           cboRevisao.SelectedValue, _
                                                           cboRoteiro.Text,
                                                           cboCaracteristicaInspecionarQualidade.SelectedValue, _
                                                           cboApontaQualidade.SelectedValue, _
                                                           txtValorNominalQualidade.Text.Trim, _
                                                           txtValorMinimoQualidade.Value, _
                                                           txtValorMaximoQualidade.Value, _
                                                           txtFrequenciaQualidade.Value, _
                                                           txtObservacaoQualidade.Text.Trim, _
                                                           grdQualidade.CurrentRow.Cells("codigo").Value)

            Else

                'Insere Registro
                Call oClsCadProduto.InsertQualidadeRoteiro(cboProduto.SelectedValue, _
                                                           cboModeloRoteiroProducao.SelectedValue, _
                                                           cboRevisao.SelectedValue, _
                                                           cboRoteiro.Text,
                                                           cboCaracteristicaInspecionarQualidade.SelectedValue, _
                                                           cboApontaQualidade.SelectedValue, _
                                                           txtValorNominalQualidade.Text.Trim, _
                                                           txtValorMinimoQualidade.Value, _
                                                           txtValorMaximoQualidade.Value, _
                                                           txtFrequenciaQualidade.Value, _
                                                           txtObservacaoQualidade.Text.Trim)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarQualidade()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProdutoRoteiroProducao, gcUpdate) = True Then

                With grdQualidade.CurrentRow.Cells

                    'Carrega Controles
                    cboRoteiro.SelectedValue = .Item("sequencia").Value
                    cboCaracteristicaInspecionarQualidade.SelectedValue = .Item("codigo_caracteristica_inspecionar").Value
                    cboApontaQualidade.SelectedValue = .Item("aponta").Value
                    If .Item("codigo_tipo_caracteristica_inspecionar").Value = CInt(QualidadeTipoCaracteristicaInspecionar.Valor) Then
                        txtValorNominalQualidade.Value = .Item("valor_nominal").Value
                        txtValorMinimoQualidade.Value = .Item("valor_minimo").Value
                        txtValorMaximoQualidade.Value = .Item("valor_maximo").Value
                    End If
                    txtObservacaoQualidade.Text = .Item("observacao").Value
                    btnInserirQualidade.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboCaracteristicaInspecionarQualidade.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoQualidade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles 
            cboRoteiro.SelectedIndex = -1
            cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
            cboApontaQualidade.SelectedIndex = -1
            txtValorNominalQualidade.Value = 0
            txtValorMinimoQualidade.Value = 0
            txtValorMaximoQualidade.Value = 0
            txtFrequenciaQualidade.Value = 0
            txtObservacaoQualidade.Text = ""
            btnInserirQualidade.Tag = ""

            'Seta Focu
            cboRoteiro.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteQualidade()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdQualidade) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Registro
                    Call oClsCadProduto.DeleteQualidadeRoteiro(cboProduto.SelectedValue, _
                                                               cboModeloRoteiroProducao.SelectedValue, _
                                                               cboRevisao.SelectedValue)

                    'Limpa Formulário
                    Call NovoQualidade()

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

    Private Function ValidacaoQualidade() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoQualidade = False

            'Verifica se foi Selecionado o Campo - Centro de Trabalho / Operação
            If ValidaCampo(cboRoteiro, lblRoteiro) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Caracteristicas a Inspecionar
            If ValidaCampo(cboCaracteristicaInspecionarQualidade, lblCaracteristicaInspecionarQualidade) = False Then
                Exit Function
            End If

            'Verifica se a Característica é Válida
            Dim iCurrentRow As Integer = -1
            If IsNumeric(btnInserirQualidade.Tag) Then iCurrentRow = grdQualidade.CurrentRow.RowIndex
            'Percorre Grid
            For Each oRow As GridEXRow In grdQualidade.GetDataRows
                If oRow.Cells("codigo_caracteristica_inspecionar").Value = cboCaracteristicaInspecionarQualidade.SelectedValue AndAlso _
                   oRow.Cells("codigo_roteiro").Value = cboRoteiro.SelectedValue AndAlso _
                   oRow.RowIndex <> iCurrentRow Then
                    frmMain.errInfo.SetError(lblCaracteristicaInspecionarQualidade, "Esta Caracteristica: " & cboCaracteristicaInspecionarQualidade.Text & " já se encontra cadastrado para este Produto.")
                    cboCaracteristicaInspecionarQualidade.Focus()
                    Exit Function
                End If
            Next

            'Verifica se foi Selecionado o Campo - Aponta
            If ValidaCampo(cboApontaQualidade, lblApontaQualidade) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Nominal
            If txtValorNominalQualidade.Enabled = True Then
                If ValidaCampo(txtValorNominalQualidade, lblValorNominalQualidade, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Mínimo
            If txtValorMinimoQualidade.Enabled = True Then
                If ValidaCampo(txtValorMinimoQualidade, lblValorMinimoQualidade, True) = False Then
                    Exit Function
                ElseIf txtValorMinimoQualidade.Value > txtValorNominalQualidade.Value Then
                    frmMain.errInfo.SetError(lblValorMinimoQualidade, "O Valor Mínimo não pode ser maior que o Valor Nominal.")
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Máximo
            If txtValorMaximoQualidade.Enabled = True Then
                If ValidaCampo(txtValorMaximoQualidade, lblValorMaximoQualidade, True) = False Then
                    Exit Function
                ElseIf txtValorMaximoQualidade.Value < txtValorNominalQualidade.Value Then
                    frmMain.errInfo.SetError(lblValorMaximoQualidade, "O Valor Máximo não pode ser menor que o Valor Nominal.")
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Frequencia
            If ValidaCampo(txtFrequenciaQualidade, lblFrequenciaQualidade, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoQualidade = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

    Private Sub txtRevisaoNovo_LostFocus(sender As Object, e As EventArgs) Handles txtRevisaoNovo.LostFocus
        Try
            cboRevisaoImportar.Text = txtRevisaoNovo.Text
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

End Class