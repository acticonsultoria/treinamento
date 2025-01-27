Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports System.IO

Public Class usrCadAtoConcessorio

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadAtoConcessorio As New clsUsrCadAtoConcessorio

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadAtoConcessorio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadAtoConcessorio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadAtoConcessorio_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: ATO CONCESSÓRIO :::"

    Private Sub btnArquivoAtoConcessorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoAtoConcessorio.Click

        Try

            'Variaveis Locais
            Dim arqAtoConcessorio As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqAtoConcessorio.InitialDirectory = "c:\\dados"
            arqAtoConcessorio.Title = "Selecione o Arquivo do Ato Concessório"

            If arqAtoConcessorio.ShowDialog() = DialogResult.OK Then
                txtArquivoAtoConcessorio.Text = arqAtoConcessorio.FileName
            End If

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
            txtNumeroAtoConcessorioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "visualizar" : Call Visualizar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaSaldoAtoConcessorio() Handles txtValor.ValueChanged, _
                                                     txtValorImportado.ValueChanged

        Try

            'Calcula Saldo
            txtSaldoAtoConcessorio.Value = txtValor.Value - txtValorImportado.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DI :::"

    Private Sub btnInserirDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDI.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoDI() = True Then

                'Váriaveis Locais
                Dim sNumeroDIAntigo As String = ""

                If IsNumeric(btnInserirDI.Tag) Then
                    sNumeroDIAntigo = grdDI.GetValue("numero_di")
                End If

                'Salva Dados do Registro
                Call InsertDI(grdDI, _
                              txtNumeroDI.Text.Trim, _
                              cboTipoImportacaoDI.SelectedValue, _
                              cboTipoImportacaoDI.Text, _
                              txtValorDI.Value, _
                              cboMoedaDI.SelectedValue, _
                              cboMoedaDI.Text, _
                              txtFatorCambialDI.Value, _
                              txtValorMoedaCorrenteDI.Value, _
                              dtpDataRegistroDI.Value, _
                              dtpDataDesembaracoDI.Value, _
                              txtLocalDesembaracoDI.Text.Trim, _
                              txtArquivoDI.Text.Trim, _
                              sNumeroDIAntigo, _
                              IIf(IsNumeric(btnInserirDI.Tag), "U", "I"))

                'Valor Importado
                If grdDI.GetDataRows.Count > 0 Then txtValorImportado.Value = grdDI.GetTotalRow.Cells("valor_moeda_corrente").Value

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoDI()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDI.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta DI
            Call DeleteDI()

            'Valor Importado
            If grdDI.GetDataRows.Count > 0 Then txtValorImportado.Value = grdDI.GetTotalRow.Cells("valor_moeda_corrente").Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMoedaDI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoedaDI.SelectedIndexChanged

        Try

            'Limpa Controles
            txtFatorCambialDI.Value = 1
            txtFatorCambialDI.ReadOnly = True
            txtFatorCambialDI.TabStop = False
            txtFatorCambialDI.BackColor = Color.WhiteSmoke

            'Verifica se foi Selecionado algum Item
            If cboMoedaDI.SelectedIndex <> -1 Then
                If cboMoedaDI.SelectedValue <> CInt(Moeda.Real) Then
                    txtFatorCambialDI.Value = 0
                    txtFatorCambialDI.ReadOnly = False
                    txtFatorCambialDI.TabStop = True
                    txtFatorCambialDI.BackColor = Color.White
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDI_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDI.RowDoubleClick

        Try

            'Verifica o Tipo de Operação
            Select Case grdDI.CurrentColumn.Key

                Case "editar" : Call EditarDI()
                Case "visualizar" : Call VisualizarDI()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorMoedaCorrenteDI() Handles txtValorDI.ValueChanged, _
                                                      txtFatorCambialDI.ValueChanged

        Try

            'Calcula Valor Moeda Corrente
            txtValorMoedaCorrenteDI.Value = txtValorDI.Value * txtFatorCambialDI.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RE :::"

    Private Sub btnCadastrarContratoCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContratoCambio.Click

        Try

            ''Abre Formulário de Cadastro de Contrato de Cambio
            'Dim oForm As New frmCadContratoCambio
            'Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            ''Carrega Combo
            'Call LoadCombo(cboContratoCambio, "sp_select_combo_cadastro_basico_contrato_cambio " & goUsuario.iEmpresa, False)
            ''Seta Focu
            'cboContratoCambio.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirRE.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoRE() = True Then

                'Váriaveis Locais
                Dim sNumeroREAntigo As String = ""

                If IsNumeric(btnInserirRE.Tag) Then
                    sNumeroREAntigo = grdRE.GetValue("numero_re")
                End If

                'Salva Dados do Registro
                Call InsertRE(grdRE, _
                              txtNumeroRE.Text.Trim, _
                              IIf(cboContratoCambio.SelectedIndex = -1, -1, cboContratoCambio.SelectedValue), _
                              cboContratoCambio.Text, _
                              txtValorRE.Value, _
                              cboMoedaRE.SelectedValue, _
                              cboMoedaRE.Text, _
                              txtFatorCambialRE.Value, _
                              txtValorMoedaCorrenteRE.Value, _
                              dtpDataRegistroRE.Value, _
                              txtLocalEmbarqueRE.Text.Trim, _
                              txtArquivoRE.Text.Trim, _
                              sNumeroREAntigo, _
                              IIf(IsNumeric(btnInserirRE.Tag), "U", "I"))

                'Valor Exportado
                If grdRE.GetDataRows.Count > 0 Then txtValorExportado.Value = grdRE.GetTotalRow.Cells("valor_moeda_corrente").Value

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoRE()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirRE.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta RE
            Call DeleteRE()

            'Valor Exportado
            If grdRE.GetDataRows.Count > 0 Then txtValorExportado.Value = grdRE.GetTotalRow.Cells("valor_moeda_corrente").Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboContratoCambio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboContratoCambio.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboContratoCambio.SelectedIndex = -1 Then

                'Limpa / Habilita Controle
                cboMoedaRE.Enabled = True
                cboMoedaRE.SelectedIndex = -1
                txtFatorCambialRE.Enabled = True
                txtFatorCambialRE.Value = 0

            Else

                'Carrega dados do Contrato
                oClsCadAtoConcessorio.LoadContratoCambio(cboContratoCambio.SelectedValue, _
                                                         cboMoedaRE, _
                                                         txtFatorCambialRE)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMoedaRE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoedaRE.SelectedIndexChanged

        Try

            'Limpa Controles
            txtFatorCambialRE.Value = 1
            txtFatorCambialRE.ReadOnly = True
            txtFatorCambialRE.TabStop = False
            txtFatorCambialRE.BackColor = Color.WhiteSmoke

            'Verifica se foi Selecionado algum Item
            If cboMoedaRE.SelectedIndex <> -1 Then
                If cboMoedaRE.SelectedValue <> CInt(Moeda.Real) Then
                    txtFatorCambialRE.Value = 0
                    txtFatorCambialRE.ReadOnly = False
                    txtFatorCambialRE.TabStop = True
                    txtFatorCambialRE.BackColor = Color.White
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRE_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRE.RowDoubleClick

        Try

            'Verifica o Tipo de Operação
            Select Case grdRE.CurrentColumn.Key

                Case "editar" : Call EditarRE()
                Case "visualizar" : Call VisualizarRE()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorMoedaCorrenteRE() Handles txtValorRE.ValueChanged, _
                                                      txtFatorCambialRE.ValueChanged

        Try

            'Calcula Valor Moeda Corrente
            txtValorMoedaCorrenteRE.Value = txtValorRE.Value * txtFatorCambialRE.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

              'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto).ToString)
            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoProduto() = True Then

                'Váriaveis Locais
                Dim lCodigoAntigo As Long = 0

                If IsNumeric(btnInserirProduto.Tag) Then
                    lCodigoAntigo = grdProduto.GetValue("codigo")
                End If

                'Salva Dados do Registro
                Call InsertProduto(grdProduto, _
                                   cboCodigoProduto.SelectedValue, _
                                   cboCodigoProduto.Text.Trim, _
                                   txtDescricaoProduto.Text.Trim, _
                                   lCodigoAntigo, _
                                   IIf(IsNumeric(btnInserirProduto.Tag), "U", "I"))

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Produto
            Call DeleteProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboCodigoProduto.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricaoProduto.Text = ""
            Else
                'Carrega dados do Produto
                txtDescricaoProduto.Text = LoadDescricao("sp_select_cadastro_basico_descricao_item " & cboCodigoProduto.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica o Tipo de Operação
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadAtoConcessorio_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoAtoConcessorio, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoAtoConcessorio, gcInsert)

            'Verifica Direito - Cadastro
            btnCadastrarContratoCambio.Enabled = VerificaDireito(Formulario.CadastroBasicoContratoCambio, gcInsert)
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboModalidadeAtoConcessorio : oComboBox(1) = cboModalidadeAtoConcessorioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_static_modalidade_ato_concessorio")
            oComboBox(0) = cboTipoAtoConcessorio : oComboBox(1) = cboTipoAtoConcessorioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_ato_concessorio")
            oComboBox(0) = cboMoedaDI : oComboBox(1) = cboMoedaRE
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa, True)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ato_concessorio")
            Call LoadCombo(cboTipoImportacaoDI, "sp_select_combo_static_tipo_importacao")
            Call LoadCombo(cboContratoCambio, "sp_select_combo_cadastro_basico_contrato_cambio " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto).ToString)

            'Seta DateTimer
            dtpDataVigenteFiltro.Value = Now.Date : dtpDataVigenteFiltro.Checked = False

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroAtoConcessorioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ATO CONCESSÓRIO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadAtoConcessorio.Delete()

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

    Private Sub Editar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoAtoConcessorio, gcUpdate) = True Then

                'Carrega Controles
                oClsCadAtoConcessorio.LoadControles(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                                    txtNumeroAtoConcessorio, _
                                                    txtDescricao, _
                                                    dtpDataAbertura, _
                                                    dtpDataValidade, _
                                                    txtValor, _
                                                    cboTipoAtoConcessorio, _
                                                    cboModalidadeAtoConcessorio, _
                                                    txtStatusAtoConcessorio, _
                                                    txtArquivoAtoConcessorio)

                'Seta Código
                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value

                'Carrega Gráfico
                Call oClsCadAtoConcessorio.LoadGrafico(chrAtoConcessorio, _
                                                       grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Carrega Grid - DI
                Call oClsCadAtoConcessorio.LoadGridDI(grdDI, _
                                                      grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Valor Importado
                If grdDI.GetDataRows.Count > 0 Then txtValorImportado.Value = grdDI.GetTotalRow.Cells("valor_moeda_corrente").Value

                'Carrega Grid - RE
                Call oClsCadAtoConcessorio.LoadGridRE(grdRE, _
                                                      grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Valor Exportado
                If grdRE.GetDataRows.Count > 0 Then txtValorExportado.Value = grdRE.GetTotalRow.Cells("valor_moeda_corrente").Value

                'Carrega Grid - Produto
                Call oClsCadAtoConcessorio.LoadGridProduto(grdProduto, _
                                                           grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Seta Aba
                tabDados.SelectedTab = pagResumo

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtNumeroAtoConcessorio.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Gráfico
            chrAtoConcessorio.Series.Clear()

            'Limpa Controles - Dados Gerais
            txtNumeroAtoConcessorio.Text = ""
            txtDescricao.Text = ""
            dtpDataAbertura.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            txtValor.Value = 0
            txtValorImportado.Value = 0
            txtValorExportado.Value = 0
            txtSaldoAtoConcessorio.Value = 0
            cboModalidadeAtoConcessorio.SelectedIndex = -1
            cboTipoAtoConcessorio.SelectedIndex = -1
            txtStatusAtoConcessorio.Text = ""
            btnSalvar.Tag = ""

            'Limpa Controles - DI
            txtNumeroDI.Text = ""
            cboTipoImportacaoDI.SelectedIndex = -1
            txtValorDI.Value = 0
            cboMoedaDI.SelectedIndex = -1
            txtFatorCambialDI.Value = 0
            txtValorMoedaCorrenteDI.Value = 0
            dtpDataRegistroDI.Value = Now.Date
            dtpDataDesembaracoDI.Value = Now.Date
            txtLocalDesembaracoDI.Text = ""
            txtArquivoDI.Text = ""
            btnInserirDI.Tag = ""
            grdDI.DataSource = Nothing

            'Limpa Controles - RE
            txtNumeroRE.Text = ""
            cboContratoCambio.SelectedIndex = -1
            txtValorRE.Value = 0
            cboMoedaRE.SelectedIndex = -1
            txtFatorCambialRE.Value = 0
            txtValorMoedaCorrenteRE.Value = 0
            dtpDataRegistroRE.Value = Now.Date
            txtLocalEmbarqueRE.Text = ""
            txtArquivoRE.Text = ""
            btnInserirRE.Tag = ""
            grdRE.DataSource = Nothing

            'Limpa Controles - Produto
            cboCodigoProduto.SelectedIndex = -1
            txtDescricaoProduto.Text = ""
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagResumo

            'Seta Focu
            txtNumeroAtoConcessorio.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadAtoConcessorio.CodigoAtoConcessorio = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadAtoConcessorio.NumeroDocumento = txtNumeroAtoConcessorio.Text.Trim
            oClsCadAtoConcessorio.Descricao = txtDescricao.Text.Trim
            oClsCadAtoConcessorio.DataAbertura = dtpDataAbertura.Value
            oClsCadAtoConcessorio.DataValidade = dtpDataValidade.Value
            oClsCadAtoConcessorio.Valor = txtValor.Value
            oClsCadAtoConcessorio.CodigoModalidade = cboModalidadeAtoConcessorio.SelectedValue
            oClsCadAtoConcessorio.CodigoTipo = cboTipoAtoConcessorio.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                'Insere Registro - Ato Concessório
                oClsCadAtoConcessorio.Update()
                'Insere Registro - DI
                Call oClsCadAtoConcessorio.DeleteDI(btnSalvar.Tag)
                Call oClsCadAtoConcessorio.InsertDI(grdDI)
                'Insere Registro - RE
                Call oClsCadAtoConcessorio.DeleteRE(btnSalvar.Tag)
                Call oClsCadAtoConcessorio.InsertRE(grdRE)
                'Insere Registro - Produto
                Call oClsCadAtoConcessorio.DeleteProduto(btnSalvar.Tag)
                Call oClsCadAtoConcessorio.InsertProduto(grdProduto)
                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                'Insere Registro - Ato Concessório
                oClsCadAtoConcessorio.Insert()
                'Obtém Código do Ato Concessório
                btnSalvar.Tag = oClsCadAtoConcessorio.CodigoAtoConcessorio
                'Insere Registro - DI
                Call oClsCadAtoConcessorio.InsertDI(grdDI)
                'Insere Registro - RE
                Call oClsCadAtoConcessorio.DeleteRE(btnSalvar.Tag)
                Call oClsCadAtoConcessorio.InsertRE(grdRE)
                'Insere Registro - Produto
                Call oClsCadAtoConcessorio.InsertProduto(grdProduto)
                'Informa o Usuário sobre o sucesso da Operação
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
            oClsCadAtoConcessorio.LoadGrid(grdListagem, _
                                           txtNumeroAtoConcessorioFiltro.Text.Trim, _
                                           txtDescricaoFiltro.Text.Trim, _
                                           IIf(dtpDataVigenteFiltro.Checked = False, "", dtpDataVigenteFiltro.Value), _
                                           IIf(cboModalidadeAtoConcessorioFiltro.SelectedIndex = -1, -1, cboModalidadeAtoConcessorioFiltro.SelectedValue), _
                                           IIf(cboTipoAtoConcessorioFiltro.SelectedIndex = -1, -1, cboTipoAtoConcessorioFiltro.SelectedValue), _
                                           IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Visualizar()

        Try

            'Verifica se foi Informado o Arquivo
            If IsDBNull(grdListagem.CurrentRow.Cells("arquivo").Value) = False Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

                'Verifica se o Arquivo Existe
                If File.Exists(grdListagem.CurrentRow.Cells("arquivo").Value) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdListagem.CurrentRow.Cells("arquivo").Value)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Nº do Ato Concessório
            If ValidaCampo(txtNumeroAtoConcessorio, lblNumeroAtoConcessorio, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Nº do Ato Concessório é Válido
            If oClsCadAtoConcessorio.ValidaNumeroDocumento(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                           txtNumeroAtoConcessorio.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblNumeroAtoConcessorio, "Este Nº do Ato Concessório: " & txtNumeroAtoConcessorio.Text.Trim & " já esta associado a outro Registro.")
                txtNumeroAtoConcessorio.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValor, lblValor, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade do Ato Concessório
            If ValidaCampo(cboModalidadeAtoConcessorio, lblModalidadeAtoConcessorio) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo do Ato Concessório
            If ValidaCampo(cboTipoAtoConcessorio, lblTipoAtoConcessorio) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: DI :::"

    Private Sub DeleteDI()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDI) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Dim oRow As GridEXRow

                    For Each oRow In gSelecaoRow
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

    Private Sub EditarDI()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoAtoConcessorio, gcUpdate) = True Then

                With grdDI.CurrentRow

                    'Preenche Controles
                    txtNumeroDI.Text = .Cells("numero_di").Value
                    cboTipoImportacaoDI.SelectedValue = .Cells("codigo_tipo_importacao").Value
                    txtValorDI.Value = .Cells("valor").Value
                    cboMoedaDI.SelectedValue = .Cells("codigo_moeda").Value
                    txtFatorCambialDI.Value = .Cells("fator_cambial").Value
                    txtValorMoedaCorrenteDI.Value = .Cells("valor_moeda_corrente").Value
                    dtpDataRegistroDI.Value = .Cells("data_registro").Value
                    txtLocalDesembaracoDI.Text = .Cells("local_desembaraco").Value
                    dtpDataDesembaracoDI.Value = .Cells("data_desembaraco").Value
                    txtArquivoDI.Text = IIf(IsDBNull(.Cells("arquivo").Value), "", .Cells("arquivo").Value)
                    btnInserirDI.Tag = .RowIndex

                    'Seta Focu
                    txtNumeroDI.Focus()

                End With

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoDI()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - DI
            txtNumeroDI.Text = ""
            cboTipoImportacaoDI.SelectedIndex = -1
            txtValorDI.Value = 0
            cboMoedaDI.SelectedIndex = -1
            txtFatorCambialDI.Value = 0
            txtValorMoedaCorrenteDI.Value = 0
            dtpDataRegistroDI.Value = Now.Date
            dtpDataDesembaracoDI.Value = Now.Date
            txtLocalDesembaracoDI.Text = ""
            txtArquivoDI.Text = ""
            btnInserirDI.Tag = ""

            'Seta Focu
            txtNumeroDI.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertDI(ByVal oGrid As GridEX, _
                         ByVal sNumeroDI As String, _
                         ByVal iCodigoTipoImportacao As Integer, _
                         ByVal sTipoImportacao As String, _
                         ByVal dValor As Double, _
                         ByVal iCodigoMoeda As Integer, _
                         ByVal sMoeda As String, _
                         ByVal dFatorCambial As Double, _
                         ByVal dValorMoedaCorrente As Double, _
                         ByVal sDataRegistro As String, _
                         ByVal sDataDesembaraco As String, _
                         ByVal sLocalDesembaraco As String, _
                         ByVal sArquivo As String, _
                         ByVal sNumeroDIAntigo As String, _
                         ByVal sTipoOperacao As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCNumeroDI As New DataColumn("numero_di")
            Dim oDCCodigoTipoImportacao As New DataColumn("codigo_tipo_importacao")
            Dim oDCTipoImportacao As New DataColumn("tipo_importacao")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCCodigoMoeda As New DataColumn("codigo_moeda")
            Dim oDCMoeda As New DataColumn("moeda")
            Dim oDCFatorCambial As New DataColumn("fator_cambial")
            Dim oDCValorMoedaCorrente As New DataColumn("valor_moeda_corrente")
            Dim oDCDataRegistro As New DataColumn("data_registro")
            Dim oDCDataDesembaraco As New DataColumn("data_desembaraco")
            Dim oDCLocalDesembaraco As New DataColumn("local_desembaraco")
            Dim oDCArquivo As New DataColumn("arquivo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCNumeroDI)
                oDataTable.Columns.Add(oDCCodigoTipoImportacao)
                oDataTable.Columns.Add(oDCTipoImportacao)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCCodigoMoeda)
                oDataTable.Columns.Add(oDCMoeda)
                oDataTable.Columns.Add(oDCFatorCambial)
                oDataTable.Columns.Add(oDCValorMoedaCorrente)
                oDataTable.Columns.Add(oDCDataRegistro)
                oDataTable.Columns.Add(oDCDataDesembaraco)
                oDataTable.Columns.Add(oDCLocalDesembaraco)
                oDataTable.Columns.Add(oDCArquivo)
                'Seta DataType
                oDCValor.DataType = 0.0.GetType
                oDCFatorCambial.DataType = 0.0.GetType
                oDCValorMoedaCorrente.DataType = 0.0.GetType
                oDCDataRegistro.DataType = Now.Date.GetType
                oDCDataDesembaraco.DataType = Now.Date.GetType
            End If

            'Verifica o Tipo de Operação
            If sTipoOperacao = "I" Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("numero_di") = sNumeroDI
                oDataRow("codigo_tipo_importacao") = iCodigoTipoImportacao
                oDataRow("tipo_importacao") = sTipoImportacao
                oDataRow("valor") = dValor
                oDataRow("codigo_moeda") = iCodigoMoeda
                oDataRow("moeda") = sMoeda
                oDataRow("fator_cambial") = dFatorCambial
                oDataRow("valor_moeda_corrente") = dValorMoedaCorrente
                oDataRow("data_registro") = sDataRegistro
                oDataRow("data_desembaraco") = sDataDesembaraco
                oDataRow("local_desembaraco") = sLocalDesembaraco
                oDataRow("arquivo") = IIf(sArquivo = "", DBNull.Value, sArquivo)
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(numero_di = " & sNumeroDIAntigo & ")")(0)
                oDataRow("numero_di") = sNumeroDI
                oDataRow("codigo_tipo_importacao") = iCodigoTipoImportacao
                oDataRow("tipo_importacao") = sTipoImportacao
                oDataRow("valor") = dValor
                oDataRow("codigo_moeda") = iCodigoMoeda
                oDataRow("moeda") = sMoeda
                oDataRow("fator_cambial") = dFatorCambial
                oDataRow("valor_moeda_corrente") = dValorMoedaCorrente
                oDataRow("data_registro") = sDataRegistro
                oDataRow("data_desembaraco") = sDataDesembaraco
                oDataRow("local_desembaraco") = sLocalDesembaraco
                oDataRow("arquivo") = IIf(sArquivo = "", DBNull.Value, sArquivo)
            End If

            'Preenche Grid
            With oGrid

                .RootTable.Columns.Item("numero_di").DataMember = "numero_di"
                .RootTable.Columns.Item("codigo_tipo_importacao").DataMember = "codigo_tipo_importacao"
                .RootTable.Columns.Item("tipo_importacao").DataMember = "tipo_importacao"
                .RootTable.Columns.Item("valor").DataMember = "valor"
                .RootTable.Columns.Item("codigo_moeda").DataMember = "codigo_moeda"
                .RootTable.Columns.Item("moeda").DataMember = "moeda"
                .RootTable.Columns.Item("fator_cambial").DataMember = "fator_cambial"
                .RootTable.Columns.Item("valor_moeda_corrente").DataMember = "valor_moeda_corrente"
                .RootTable.Columns.Item("data_registro").DataMember = "data_registro"
                .RootTable.Columns.Item("data_desembaraco").DataMember = "data_desembaraco"
                .RootTable.Columns.Item("local_desembaraco").DataMember = "local_desembaraco"
                .RootTable.Columns.Item("arquivo").DataMember = "arquivo"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarDI()

        Try

            'Verifica se foi Informado o Arquivo
            If IsDBNull(grdDI.CurrentRow.Cells("arquivo").Value) = False Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

                'Verifica se o Arquivo Existe
                If File.Exists(grdDI.CurrentRow.Cells("arquivo").Value) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdDI.CurrentRow.Cells("arquivo").Value)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDI() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDI = False

            'Verifica se foi Preenchido o Campo - Nº da DI
            If ValidaCampo(txtNumeroDI, lblNumeroDI, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Nº da DI é Válido
            If oClsCadAtoConcessorio.ValidaNumeroDI(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                    txtNumeroDI.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblNumeroDI, "Este Nº da DI: " & txtNumeroDI.Text.Trim & " já esta associado a outro Registro.")
                Exit Function
            End If

            'Verifica se o Nº da DI é Válido
            If grdDI.GetDataRows.Count > 0 Then
                If VerificaExisteValorGrid(grdDI, "numero_di", txtNumeroDI.Text.Trim, IIf(IsNumeric(btnInserirDI.Tag), btnInserirDI.Tag, -1)) = True Then
                    frmMain.errInfo.SetError(lblNumeroDI, "Este Nº da DI: " & txtNumeroDI.Text.Trim & " já esta associado a outro Registro.")
                    txtNumeroDI.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Importação
            If ValidaCampo(cboTipoImportacaoDI, lblTipoImportacaoDI) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorDI, lblValorDI, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoedaDI, lblMoedaDI) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fator Cambial
            If ValidaCampo(txtFatorCambialDI, lblFatorCambialDI, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Local de Desembaraço
            If ValidaCampo(txtLocalDesembaracoDI, lblLocalDesembaracoDI, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDI = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RE :::"

    Private Sub DeleteRE()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRE) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Dim oRow As GridEXRow

                    For Each oRow In gSelecaoRow
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

    Private Sub EditarRE()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoAtoConcessorio, gcUpdate) = True Then

                With grdRE.CurrentRow

                    'Preenche Controles
                    txtNumeroRE.Text = .Cells("numero_re").Value
                    If IsDBNull(.Cells("codigo_contrato_cambio").Value) Then
                        cboContratoCambio.SelectedIndex = -1
                    Else
                        cboContratoCambio.SelectedValue = .Cells("codigo_contrato_cambio").Value
                    End If
                    txtValorRE.Value = .Cells("valor").Value
                    cboMoedaRE.SelectedValue = .Cells("codigo_moeda").Value
                    txtFatorCambialRE.Value = .Cells("fator_cambial").Value
                    txtValorMoedaCorrenteRE.Value = .Cells("valor_moeda_corrente").Value
                    dtpDataRegistroRE.Value = .Cells("data_registro").Value
                    txtLocalEmbarqueRE.Text = .Cells("local_embarque").Value
                    txtArquivoRE.Text = IIf(IsDBNull(.Cells("arquivo").Value), "", .Cells("arquivo").Value)
                    btnInserirRE.Tag = .RowIndex

                    'Seta Focu
                    txtNumeroRE.Focus()

                End With

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoRE()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - RE
            txtNumeroRE.Text = ""
            cboContratoCambio.SelectedIndex = -1
            txtValorRE.Value = 0
            cboMoedaRE.SelectedIndex = -1
            txtFatorCambialRE.Value = 0
            txtValorMoedaCorrenteRE.Value = 0
            dtpDataRegistroRE.Value = Now.Date
            txtLocalEmbarqueRE.Text = ""
            txtArquivoRE.Text = ""
            btnInserirRE.Tag = ""

            'Seta Focu
            txtNumeroRE.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertRE(ByVal oGrid As GridEX, _
                         ByVal sNumeroRE As String, _
                         ByVal iCodigoContratoCambio As Integer, _
                         ByVal sContratoCambio As String, _
                         ByVal dValor As Double, _
                         ByVal iCodigoMoeda As Integer, _
                         ByVal sMoeda As String, _
                         ByVal dFatorCambial As Double, _
                         ByVal dValorMoedaCorrente As Double, _
                         ByVal sDataRegistro As String, _
                         ByVal sLocalEmbarque As String, _
                         ByVal sArquivo As String, _
                         ByVal sNumeroREAntigo As String, _
                         ByVal sTipoOperacao As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCNumeroRE As New DataColumn("numero_re")
            Dim oDCCodigoContratoCambio As New DataColumn("codigo_contrato_cambio")
            Dim oDCContratoCambio As New DataColumn("contrato_cambio")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCCodigoMoeda As New DataColumn("codigo_moeda")
            Dim oDCMoeda As New DataColumn("moeda")
            Dim oDCFatorCambial As New DataColumn("fator_cambial")
            Dim oDCValorMoedaCorrente As New DataColumn("valor_moeda_corrente")
            Dim oDCDataRegistro As New DataColumn("data_registro")
            Dim oDCLocalEmbarque As New DataColumn("local_embarque")
            Dim oDCArquivo As New DataColumn("arquivo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Areciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Areciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCNumeroRE)
                oDataTable.Columns.Add(oDCCodigoContratoCambio)
                oDataTable.Columns.Add(oDCContratoCambio)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCCodigoMoeda)
                oDataTable.Columns.Add(oDCMoeda)
                oDataTable.Columns.Add(oDCFatorCambial)
                oDataTable.Columns.Add(oDCValorMoedaCorrente)
                oDataTable.Columns.Add(oDCDataRegistro)
                oDataTable.Columns.Add(oDCLocalEmbarque)
                oDataTable.Columns.Add(oDCArquivo)
                'Seta DataType
                oDCValor.DataType = 0.0.GetType
                oDCFatorCambial.DataType = 0.0.GetType
                oDCValorMoedaCorrente.DataType = 0.0.GetType
                oDCDataRegistro.DataType = Now.Date.GetType
            End If

            'Verifica o Tipo de Operação
            If sTipoOperacao = "I" Then
                'Areciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("numero_re") = sNumeroRE
                oDataRow("codigo_contrato_cambio") = IIf(iCodigoContratoCambio = -1, DBNull.Value, iCodigoContratoCambio)
                oDataRow("contrato_cambio") = sContratoCambio
                oDataRow("valor") = dValor
                oDataRow("codigo_moeda") = iCodigoMoeda
                oDataRow("moeda") = sMoeda
                oDataRow("fator_cambial") = dFatorCambial
                oDataRow("valor_moeda_corrente") = dValorMoedaCorrente
                oDataRow("data_registro") = sDataRegistro
                oDataRow("local_embarque") = sLocalEmbarque
                oDataRow("arquivo") = IIf(sArquivo = "", DBNull.Value, sArquivo)
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(numero_re = " & sNumeroREAntigo & ")")(0)
                oDataRow("numero_re") = sNumeroRE
                oDataRow("codigo_contrato_cambio") = IIf(iCodigoContratoCambio = -1, DBNull.Value, iCodigoContratoCambio)
                oDataRow("contrato_cambio") = sContratoCambio
                oDataRow("valor") = dValor
                oDataRow("codigo_moeda") = iCodigoMoeda
                oDataRow("moeda") = sMoeda
                oDataRow("fator_cambial") = dFatorCambial
                oDataRow("valor_moeda_corrente") = dValorMoedaCorrente
                oDataRow("data_registro") = sDataRegistro
                oDataRow("local_embarque") = sLocalEmbarque
                oDataRow("arquivo") = IIf(sArquivo = "", DBNull.Value, sArquivo)
            End If

            'Preenche Grid
            With oGrid

                .RootTable.Columns.Item("numero_re").DataMember = "numero_re"
                .RootTable.Columns.Item("codigo_contrato_cambio").DataMember = "codigo_contrato_cambio"
                .RootTable.Columns.Item("contrato_cambio").DataMember = "contrato_cambio"
                .RootTable.Columns.Item("valor").DataMember = "valor"
                .RootTable.Columns.Item("codigo_moeda").DataMember = "codigo_moeda"
                .RootTable.Columns.Item("moeda").DataMember = "moeda"
                .RootTable.Columns.Item("fator_cambial").DataMember = "fator_cambial"
                .RootTable.Columns.Item("valor_moeda_corrente").DataMember = "valor_moeda_corrente"
                .RootTable.Columns.Item("data_registro").DataMember = "data_registro"
                .RootTable.Columns.Item("local_embarque").DataMember = "local_embarque"
                .RootTable.Columns.Item("arquivo").DataMember = "arquivo"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarRE()

        Try

            'Verifica se foi Informado o Arquivo
            If IsDBNull(grdRE.CurrentRow.Cells("arquivo").Value) = False Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

                'Verifica se o Arquivo Existe
                If File.Exists(grdRE.CurrentRow.Cells("arquivo").Value) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdDI.CurrentRow.Cells("arquivo").Value)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRE() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRE = False

            'Verifica se foi Preenchido o Campo - Nº da RE
            If ValidaCampo(txtNumeroRE, lblNumeroRE, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Nº da RE é Válido
            If oClsCadAtoConcessorio.ValidaNumeroRE(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                    txtNumeroRE.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblNumeroRE, "Este Nº da RE: " & txtNumeroRE.Text.Trim & " já esta associado a outro Registro.")
                Exit Function
            End If

            'Verifica se o Nº da RE é Válido
            If grdRE.GetDataRows.Count > 0 Then
                If VerificaExisteValorGrid(grdRE, "numero_re", txtNumeroRE.Text.Trim, IIf(IsNumeric(btnInserirRE.Tag), btnInserirRE.Tag, -1)) = True Then
                    frmMain.errInfo.SetError(lblNumeroRE, "Este Nº da RE: " & txtNumeroRE.Text.Trim & " já esta associado a outro Registro.")
                    txtNumeroRE.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorRE, lblValorRE, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoedaRE, lblMoedaRE) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fator Cambial
            If ValidaCampo(txtFatorCambialRE, lblFatorCambialRE, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Local de Embarque
            If ValidaCampo(txtLocalEmbarqueRE, lblLocalEmbarqueRE, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRE = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO :::"

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Dim oRow As GridEXRow

                    For Each oRow In gSelecaoRow
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

    Private Sub EditarProduto()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoAtoConcessorio, gcUpdate) = True Then

                With grdProduto.CurrentRow

                    'Preenche Controles
                    cboCodigoProduto.SelectedValue = .Cells("codigo").Value
                    btnInserirProduto.Tag = .RowIndex

                    'Seta Focu
                    cboCodigoProduto.Focus()

                End With

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Produto
            cboCodigoProduto.SelectedIndex = -1
            txtDescricaoProduto.Text = ""
            btnInserirProduto.Tag = ""

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertProduto(ByVal oGrid As GridEX, _
                              ByVal lCodigo As Long, _
                              ByVal sCodigoProduto As String, _
                              ByVal sDescricao As String, _
                              ByVal lCodigoAntigo As Long, _
                              ByVal sTipoOperacao As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCCodigo As New DataColumn("codigo")
            Dim oDCCodigoProduto As New DataColumn("codigo_produto")
            Dim oDCDescricao As New DataColumn("descricao")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Areciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Areciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCodigoProduto)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCCodigo)
            End If

            'Verifica o Tipo de Operação
            If sTipoOperacao = "I" Then
                'Areciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("codigo_produto") = sCodigoProduto
                oDataRow("descricao") = sDescricao
                oDataRow("codigo") = lCodigo
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & lCodigoAntigo & ")")(0)
                oDataRow("codigo_produto") = sCodigoProduto
                oDataRow("descricao") = sDescricao
                oDataRow("codigo") = lCodigo
            End If

            'Preenche Grid
            With oGrid

                .RootTable.Columns.Item("codigo_produto").DataMember = "codigo_produto"
                .RootTable.Columns.Item("descricao").DataMember = "descricao"
                .RootTable.Columns.Item("codigo").DataMember = "codigo"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Preenchido o Campo - Código do Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If

            'Verifica se o Nº da RE é Válido
            If grdProduto.GetDataRows.Count > 0 Then
                If VerificaExisteValorGrid(grdProduto, "codigo", cboCodigoProduto.SelectedValue, IIf(IsNumeric(btnInserirProduto.Tag), btnInserirProduto.Tag, -1)) = True Then
                    frmMain.errInfo.SetError(lblCodigoProduto, "Este Código de Produto: " & cboCodigoProduto.Text.Trim & " já esta associado a outro Registro.")
                    cboCodigoProduto.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class

