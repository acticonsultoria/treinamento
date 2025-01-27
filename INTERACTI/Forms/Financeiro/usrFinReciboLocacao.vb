Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Drawing.Printing

Public Class usrFinReciboLocacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReciboLocacao As New clsUsrFinReciboLocacao

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinReciboLocacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridListagem() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEPCliente" : Call btnProcurarCEPCliente_Click(btnProcurarCEPCliente, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCliente" : Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                        Case "cboPaisCliente" : Call LoadCombo(cboPaisCliente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboOutrasCobrancas" : Call LoadCombo(cboOutrasCobrancas, "sp_select_combo_cadastro_basico_outras_cobrancas")
                        Case "cboDescontos" : Call LoadCombo(cboDescontos, "sp_select_combo_cadastro_basico_descontos")
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboPaisCliente" : Call btnCadastrarPaisCliente_Click(btnCadastrarPaisCliente, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinReciboLocacao_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: RECIBO :::"

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Try

            'Carrega Dados da Grid
            Call LoadGridListagem()

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
            oForm.NomeFormulario = Formulario.FinanceiroReciboLocacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReciboLocacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
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

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click
        Try

            'Limpa Controles
            Call Novo()


            'Alterna Aba                
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try

            'Exclui 
            Call Excluir()

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

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadParceiroNegocio"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarCEPCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEPCliente.Click
        Try

            'Verifica se foi preenchido o CEP
            If txtCEPCliente.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPCliente.Text.Trim, "-", "")), _
                           cboPaisCliente, _
                           cboUFCliente, _
                           cboMunicipioCliente, _
                           txtBairroCliente, _
                           txtLogradouroCliente, _
                           txtComplementoCliente)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarPaisCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisCliente.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadPais"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            LoadCombo(cboPaisCliente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

            'Seta Focu
            cboPaisCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try

            'Limpa Controles
            Call Novo()

            'Carrega Dados da Tabela de Leitura Agua e Esgoto
           
            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Gera Numero Documento
            If txtNumeroRecibo.Text = "" Then

                txtNumeroRecibo.Text = oClsFinReciboLocacao.GeraNumeroDocumento()

            End If

            'Valida Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Calcula o Valor Total
                Call CalculoValorSubTotal1(txtTotalDevidoEnergiaEletrica, System.EventArgs.Empty)
                Call CalculoValorTotal(txtCalculoValorSubtotal1, System.EventArgs.Empty)

                'Integração - Financeiro
                Call oClsFinReciboLocacao.IntegracaoReciboLocacaoFinanceiro(btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnVoltar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Try
            'Carrega Grid
            Call LoadGridListagem()

            'Limpa Controles
            Novo()

            'Alterna Abam
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtNumeroReciboFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica a Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo_recibo_capa").Value) : tabMain.TabPages.Remove(pagLista) : tabMain.TabPages.Add(pagDados)
                Case "duplicar" : Call Duplicar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReciboLocacao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroReciboLocacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FinanceiroReciboLocacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                Call ImprimirRecibo(btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImprimirFatura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirFatura.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                Call ImprimirFatura(btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImprimirReciboCapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirReciboCapa.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If VerificaSelecaoRow(grdListagem) = True Then
                If (grdListagem.GetCheckedRows.Length = 1) Then

                    For Each oRow As GridEXRow In gSelecaoRow
                        Call ImprimirRecibo(oRow.Cells.Item("codigo_recibo_capa").Value)
                    Next
                Else
                    MsgBox("Selecione um registro de cada vez para realizar a impressão.", MsgBoxStyle.Exclamation, Me.Parent.Text)
                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirFaturaCapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirFaturaCapa.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If VerificaSelecaoRow(grdListagem) = True Then
                If (grdListagem.GetCheckedRows.Length = 1) Then

                    For Each oRow As GridEXRow In gSelecaoRow
                        Call ImprimirFatura(oRow.Cells.Item("codigo_recibo_capa").Value)
                    Next
                Else
                    MsgBox("Selecione um registro de cada vez para realizar a impressão.", MsgBoxStyle.Exclamation, Me.Parent.Text)
                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoValorTotal(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCalculoValorSubtotal1.ValueChanged, _
                                                                                               txtCalculoDescontos.ValueChanged


        Try

            'Valor Descontos
            If grdDesconto.GetDataRows.Count > 0 Then
                txtCalculoDescontos.Value = grdDesconto.GetTotalRow.Cells("valor_desconto").Value
            End If

            'Seta Valor
            txtCalculoValorTotal.Value = (txtCalculoValorSubtotal1.Value - txtCalculoDescontos.Value)



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoValorSubTotal1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalDevidoEnergiaEletrica.ValueChanged, _
                                                                                                   txtTotalDevidoAgua.ValueChanged, _
                                                                                                   txtTotalDevidoEsgoto.ValueChanged


        Try

            'Seta Valor
            txtCalculoValorRateio.Value = txtRateioAgua.Value

            'Valor Aluguel
            'If grdGalpao.GetDataRows.Count > 0 Or grdSalaComercial.GetDataRows.Count > 0 Or grdBox.GetDataRows.Count > 0 Or grdCasa.GetDataRows.Count > 0 Then
            txtCalculoValorAluguel.Value = IIf(grdGalpao.GetDataRows.Count > 0, grdGalpao.GetTotalRow.Cells("valor_aluguel").Value, 0) + _
                                           IIf(grdCasa.GetDataRows.Count > 0, grdCasa.GetTotalRow.Cells("valor_aluguel").Value, 0) + _
                                            IIf(grdBox.GetDataRows.Count > 0, grdBox.GetTotalRow.Cells("valor_aluguel").Value, 0) + _
                                            IIf(grdSalaComercial.GetDataRows.Count > 0, grdSalaComercial.GetTotalRow.Cells("valor_aluguel").Value, 0)

            'End If

            'Valor Total Energia
            'If grdGalpaoEnergia.GetDataRows.Count > 0 Or grdCasaEnergia.GetDataRows.Count > 0 Then
            txtCalculoValorEnergia.Value = IIf(grdGalpaoEnergia.GetDataRows.Count > 0, grdGalpaoEnergia.GetTotalRow.Cells("total_devido_energia").Value, 0) + _
                                            IIf(grdCasaEnergia.GetDataRows.Count > 0, grdCasaEnergia.GetTotalRow.Cells("total_devido_energia").Value, 0)
            'End If

            'Valor Total Agua
            'If grdAguaGalpao.GetDataRows.Count > 0 Or grdAguaCasa.GetDataRows.Count > 0 Then
            txtCalculoValorAgua.Value = IIf(grdAguaGalpao.GetDataRows.Count > 0, grdAguaGalpao.GetTotalRow.Cells("total_devido_agua").Value, 0) + _
                                        IIf(grdAguaCasa.GetDataRows.Count > 0, grdAguaCasa.GetTotalRow.Cells("total_devido_agua").Value, 0)
            'End If

            'Valor Total Esgoto
            'If grdEsgotoGalpao.GetDataRows.Count > 0 Or grdEsgotoGalpao.GetDataRows.Count > 0 Then
            txtCalculoValorEsgoto.Value = IIf(grdEsgotoGalpao.GetDataRows.Count > 0, grdEsgotoGalpao.GetTotalRow.Cells("total_devido_esgoto").Value, 0) + _
                                          IIf(grdEsgotoGalpao.GetDataRows.Count > 0, grdEsgotoCasa.GetTotalRow.Cells("total_devido_esgoto").Value, 0)
            'End If

            'Valor Outras Cobranças
            If grdOutrasCobrancas.GetDataRows.Count > 0 Then
                txtCalculoValorOutrasCobrancas.Value = grdOutrasCobrancas.GetTotalRow.Cells("valor_outras_cobrancas").Value
            End If

            'Soma Valor SubTotal1
            txtCalculoValorSubtotal1.Value = txtCalculoValorAluguel.Value +
                                             txtCalculoValorEnergia.Value +
                                             txtCalculoValorAgua.Value +
                                             txtCalculoValorRateio.Value +
                                             txtCalculoValorEsgoto.Value +
                                             txtCalculoValorOutrasCobrancas.Value

            'Seta Valor
            txtCalculoValorTotal.Value = (txtCalculoValorSubtotal1.Value - txtCalculoDescontos.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTabelaLeitura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTabelaLeitura.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadTabelaLeitura"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Dados da Tabela de Leitura Agua e Esgoto
            oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10Agua, _
                                                   txtAte20Agua, _
                                                   txtAte50Agua, _
                                                   txtAcima50Agua, _
                                                   txtRateioAgua, _
                                                   txtTaxaAnaliseAgua, _
                                                   txtAte10Esgoto, _
                                                   txtAte20Esgoto, _
                                                   txtAte50Esgoto, _
                                                   txtAcima50Esgoto)

            'Seta Focu
            dtpDataInicioVigenciaContratoGalpao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub tabDados_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try


            Select Case e.Page.Name

                Case "tabCalculo"
                    'Calcula Valor Total
                    Call CalculoValorSubTotal1(txtTotalDevidoEnergiaEletrica, System.EventArgs.Empty)
                    Call CalculoValorTotal(txtCalculoValorSubtotal1, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#Region "::: CLIENTE :::"

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Destinatário
            If cboCliente.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                txtCNPJCliente.Enabled = False : txtCNPJCliente.Text = ""
                txtInscricaoEstadualCliente.Enabled = False : txtInscricaoEstadualCliente.Text = ""
                txtInscricaoMunicipalCliente.Enabled = False : txtInscricaoMunicipalCliente.Text = ""
                txtLogradouroCliente.Enabled = False : txtLogradouroCliente.Text = ""
                txtNumeroCliente.Enabled = False : txtNumeroCliente.Text = ""
                txtComplementoCliente.Enabled = False : txtComplementoCliente.Text = ""
                txtBairroCliente.Enabled = False : txtBairroCliente.Text = ""
                txtCEPCliente.Enabled = False : txtCEPCliente.Text = ""
                cboPaisCliente.Enabled = False : cboPaisCliente.SelectedIndex = -1
                cboUFCliente.Enabled = False : cboUFCliente.SelectedIndex = -1
                cboMunicipioCliente.Enabled = False : cboMunicipioCliente.SelectedIndex = -1
                txtTelefoneCliente.Enabled = False : txtTelefoneCliente.Text = ""
                txtEmailCliente.Enabled = False : txtEmailCliente.Text = ""
                txtCNPJCliente.Tag = ""
                cboDadosAreaGalpao.SelectedIndex = -1
                cboDadosEnergiaGalpao.SelectedIndex = -1
                cboDadosAguaGalpao.SelectedIndex = -1
                cboDadosEsgotoGalpao.SelectedIndex = -1

            Else

                'Carrega dados do Destinatário
                Call LoadDadosParceiroNegocio(cboCliente.SelectedValue, _
                                            txtCNPJCliente, _
                                            txtInscricaoEstadualCliente, _
                                            txtInscricaoMunicipalCliente, _
                                            txtLogradouroCliente, _
                                            txtNumeroCliente, _
                                            txtComplementoCliente, _
                                            txtBairroCliente, _
                                            txtCEPCliente, _
                                            cboPaisCliente, _
                                            cboUFCliente, _
                                            cboMunicipioCliente, _
                                            txtTelefoneCliente, _
                                            txtEmailCliente)




                'Carrega Combo - Galpão
                Dim oComboBox(3) As UIComboBox
                oComboBox(0) = cboDadosAreaGalpao : oComboBox(1) = cboDadosEnergiaGalpao : oComboBox(2) = cboDadosAguaGalpao : oComboBox(3) = cboDadosEsgotoGalpao
                Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cliente_galpao " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)
                Call LoadCombo(cboCasa, "sp_select_combo_cadastro_basico_cliente_casa " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
                Call LoadCombo(cboDadosEsgotoCasa, "sp_select_combo_cadastro_basico_cliente_casa " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
                Call LoadCombo(cboDadosEnergiaCasa, "sp_select_combo_cadastro_basico_cliente_casa " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
                Call LoadCombo(cboDadosAguaCasa, "sp_select_combo_cadastro_basico_cliente_casa " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
                Call LoadCombo(cboBox, "sp_select_combo_cadastro_basico_cliente_box " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
                Call LoadCombo(cboSala, "sp_select_combo_cadastro_basico_cliente_sala " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
                'Carrega Títulos Previstos
                Call LoadCombo(cboFinanceiroTituloPrevisto, "sp_select_combo_financeiro_titulo_previsao_recibo_locacao " & goUsuario.iEmpresa & ", " & cboCliente.SelectedValue)



                'Verifica o Tipo de Personalidade
                If txtCNPJCliente.Tag = Personalidade.Fisica Then
                    lblCNPJCliente.Text = "CPF:"
                    lblInscricaoEstadualCliente.Text = "RG:"
                Else
                    lblCNPJCliente.Text = "CNPJ:"
                    lblInscricaoEstadualCliente.Text = "IE:"
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPaisCliente_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPaisCliente.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisCliente.SelectedIndex = -1 Then
                'Limpa Controles
                cboUFCliente.DataSource = Nothing
                cboUFCliente.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboUFCliente, "sp_select_combo_static_estado_pais " & cboPaisCliente.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFCliente_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUFCliente.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboUFCliente.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioCliente.DataSource = Nothing
                cboMunicipioCliente.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioCliente, "sp_select_combo_static_municipio " & cboUFCliente.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


#End Region

#Region "::: DADOS AREA :::"

    Private Sub btnDadosAreaCadastrarGalpao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                                                                                                      btnDadosEnergiaCadastrarGalpao.Click, _
                                                                                                                      btnDadosAguaCadastrarGalpao.Click, _
                                                                                                                      btnDadosEsgotoCadastrarGalpao.Click, _
                                                                                                                      btnDadosAreaCadastrarGalpao.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadGalpao"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo - Galpão
            Dim oComboBox(3) As UIComboBox
            oComboBox(0) = cboDadosAreaGalpao : oComboBox(1) = cboDadosEnergiaGalpao : oComboBox(2) = cboDadosAguaGalpao : oComboBox(3) = cboDadosEsgotoGalpao
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cliente_galpao " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)

            'Seta Focu
            Select Case sender.Name
                Case "btnDadosAreaCadastrarGalpao" : cboDadosAreaGalpao.Focus()
                Case "btnDadosEnergiaCadastrarGalpao" : cboDadosEnergiaGalpao.Focus()
                Case "btnDadosAguaCadastrarGalpao" : cboDadosAguaGalpao.Focus()
                Case "btnDadosEsgotoCadastrarGalpao" : cboDadosEsgotoGalpao.Focus()
            End Select


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnDadosAreaInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            'Exclui 
            Call InserirDadosArea()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDadosAreaExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            'Exclui 
            Call ExcluirDadosArea()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDadosArea_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs)
        Try

            'Editar
            Call EditarDadosArea()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


#End Region

#Region "::: DADOS ENERGIA :::"

    Private Sub btnDadosEnergiaInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEnergiaGalpao.Click, btnDadosEnergiaInserir.Click
        Try

            'Exclui 
            Call InserirDadosEnergiaGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDadosEnergiaExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEnergiaGalpao.Click
        Try

            'Exclui 
            Call ExcluirDadosEnergiaGalpao()
            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEnergiaGalpao(grdGalpaoEnergia, _
                                                      btnSalvar.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDadosEnergia_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdGalpaoEnergia.RowDoubleClick, grdDadosEnergia.RowDoubleClick
        Try

            'Editar
            Call EditarDadosEnergiaGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosEnergiaGalpao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosEnergiaGalpao.SelectedIndexChanged
        Try
            If cboDadosEnergiaGalpao.SelectedIndex = -1 Then

                'Limpa Controles
                dtpDataLeituraAtualEnergiaEletrica.Value = Now.Date
                txtMarcacaoAtualEnergiaEletrica.Value = 0
                dtpDataLeituraPrecedenteEnergiaEletrica.Value = Now.Date
                txtMarcacaoPrecedenteEnergiaEletrica.Value = 0
                txtConsumoEnergiaEletrica.Value = 0
                txtPrecoMedioEnergiaEletrica.Value = 0
                txtTotalDevidoEnergiaEletrica.Value = 0
                txtReferenciaContaEnergiaEletrica.Text = ""
                btnInserirEnergiaGalpao.Tag = ""
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculoTotalEnergia(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarcacaoAtualEnergiaEletrica.ValueChanged, _
                                                                                                    txtMarcacaoPrecedenteEnergiaEletrica.ValueChanged, _
                                                                                                    txtPrecoMedioEnergiaEletrica.ValueChanged
        Try

            'Seta Valor Total
            txtConsumoEnergiaEletrica.Value = txtMarcacaoAtualEnergiaEletrica.Value - txtMarcacaoPrecedenteEnergiaEletrica.Value
            txtTotalDevidoEnergiaEletrica.Value = txtConsumoEnergiaEletrica.Value * txtPrecoMedioEnergiaEletrica.Value


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub CalculoTotalEnergiaCasa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarcacaoAtualEnergiaCasa.ValueChanged, _
                                                                                                   txtMarcacaoPrecedenteEnergiaEletricaCasa.ValueChanged, _
                                                                                                   txtPrecoMedioEnergiaEletricaCasa.ValueChanged
        Try

            'Seta Valor Total
            txtConsumoEnergiaEletricaCasa.Value = txtMarcacaoAtualEnergiaCasa.Value - txtMarcacaoPrecedenteEnergiaEletricaCasa.Value
            txtTotalDevidoEnergiaEletricaCasa.Value = txtConsumoEnergiaEletricaCasa.Value * txtPrecoMedioEnergiaEletricaCasa.Value


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

#End Region

#Region "::: DADOS AGUA :::"

    Private Sub btnDadosAguaInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAguaGalpao.Click
        Try

            'Exclui 
            Call InserirDadosAguaGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDadosAguaExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAguaGalpao.Click
        Try

            'Exclui 
            Call ExcluirDadosAguaGalpao()
            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosAguaGalpao(grdAguaGalpao, _
                                                   btnSalvar.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDadosAgua_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAguaGalpao.RowDoubleClick
        Try

            'Editar
            Call EditarDadosAguaGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosAguaGalpao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosAguaGalpao.SelectedIndexChanged

        Try
            If cboDadosAguaGalpao.SelectedIndex = -1 Then

                'Limpa Controles
                dtpDataLeituraAtualAgua.Value = Now.Date
                txtMarcacaoAtualAgua.Value = 0
                dtpDataLeituraPrecedenteAgua.Value = Now.Date
                txtMarcacaoPrecedenteAgua.Value = 0
                txtConsumoAgua.Value = 0
                txtTotalDevidoAgua.Value = 0
                txtAte10Agua.Value = 0
                txtAte20Agua.Value = 0
                txtAte50Agua.Value = 0
                txtAcima50Agua.Value = 0
                btnInserirAguaGalpao.Tag = ""


            Else

                'Carrega Dados Rateio Consumo Agua
                oClsFinReciboLocacao.LoadDadosGalpao(IIf(cboDadosAguaGalpao.SelectedIndex = -1, -1, cboDadosAguaGalpao.SelectedValue), _
                                                     btnExcluirAguaGalpao.Tag)

                'Carrega Dados da Tabela de Leitura Agua e Esgoto
                oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10Agua, _
                                                       txtAte20Agua, _
                                                       txtAte50Agua, _
                                                       txtAcima50Agua, _
                                                       txtRateioAgua, _
                                                       txtTaxaAnaliseAgua, _
                                                       txtAte10Esgoto, _
                                                       txtAte20Esgoto, _
                                                       txtAte50Esgoto, _
                                                       txtAcima50Esgoto)
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculaTotalAgua(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarcacaoAtualAgua.ValueChanged, _
                                                                                                 txtMarcacaoPrecedenteAgua.ValueChanged
        Try

            'Seta Valor Total
            txtConsumoAgua.Value = txtMarcacaoAtualAgua.Value - txtMarcacaoPrecedenteAgua.Value
            txtTotalDevidoAgua.Value = 0

            'Calcula Valor Total
            If txtConsumoAgua.Value <= 10 Then

                txtTotalDevidoAgua.Value = txtAte10Agua.Value

            ElseIf txtConsumoAgua.Value > 10 And txtConsumoAgua.Value <= 20 Then

                txtTotalDevidoAgua.Value = txtConsumoAgua.Value * txtAte20Agua.Value

            ElseIf txtConsumoAgua.Value > 20 And txtConsumoAgua.Value <= 50 Then

                txtTotalDevidoAgua.Value = txtConsumoAgua.Value * txtAte50Agua.Value

            ElseIf txtConsumoAgua.Value > 50 Then

                txtTotalDevidoAgua.Value = txtConsumoAgua.Value * txtAcima50Agua.Value

            End If

            'Verifica se Existe Rateio do Consumo de Agua
            If btnExcluirAguaGalpao.Tag > 0 Then

                txtTotalDevidoAgua.Value = (txtTotalDevidoAgua.Value / CType(btnExcluirAguaGalpao.Tag, Double))

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub CalculaTotalAguaCasa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarcacaoAtualAguaCasa.ValueChanged, _
                                                                                                txtMarcacaoPrecedenteAguaCasa.ValueChanged
        Try

            'Seta Valor Total
            txtConsumoAguaCasa.Value = txtMarcacaoAtualAguaCasa.Value - txtMarcacaoPrecedenteAguaCasa.Value
            txtTotalDevidoAguaCasa.Value = 0

            'Calcula Valor Total
            If txtConsumoAguaCasa.Value <= 10 Then

                txtTotalDevidoAguaCasa.Value = txtAte10AguaCasa.Value

            ElseIf txtConsumoAguaCasa.Value > 10 And txtConsumoAguaCasa.Value <= 20 Then

                txtTotalDevidoAguaCasa.Value = txtConsumoAguaCasa.Value * txtAte20AguaCasa.Value

            ElseIf txtConsumoAguaCasa.Value > 20 And txtConsumoAguaCasa.Value <= 50 Then

                txtTotalDevidoAguaCasa.Value = txtConsumoAguaCasa.Value * txtAte50AguaCasa.Value

            ElseIf txtConsumoAguaCasa.Value > 50 Then

                txtTotalDevidoAguaCasa.Value = txtConsumoAguaCasa.Value * txtAcima50AguaCasa.Value

            End If

            'Verifica se Existe Rateio do Consumo de Agua
            If btnExcluirAguaCasa.Tag > 0 Then

                txtTotalDevidoAguaCasa.Value = (txtTotalDevidoAguaCasa.Value / CType(btnExcluirAguaCasa.Tag, Double))

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: DADOS ESGOTO :::"

    Private Sub btnDadosEsgotoInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEsgotoGalpao.Click
        Try

            'Exclui 
            Call InserirDadosEsgotoGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDadosEsgotoExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEsgotoGalpao.Click
        Try

            'Exclui 
            Call ExcluirDadosEsgotoGalpao()
            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEsgotoGalpao(grdEsgotoGalpao, _
                                                     btnSalvar.Tag)
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDadosEsgoto_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEsgotoGalpao.RowDoubleClick
        Try

            'Editar
            Call EditarDadosEsgotoGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosEsgotoGalpao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosEsgotoGalpao.SelectedIndexChanged
        Try
            If cboDadosEsgotoGalpao.SelectedIndex = -1 Then

                'Limpa Controles
                txtConsumoEsgoto.Value = 0
                txtTotalDevidoEsgoto.Value = 0
                txtAte10Esgoto.Value = 0
                txtAte20Esgoto.Value = 0
                txtAte50Esgoto.Value = 0
                txtAcima50Esgoto.Value = 0
                btnInserirEsgotoGalpao.Tag = ""


            Else


                'Carrega Dados da Tabela de Leitura Agua e Esgoto
                oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10Agua, _
                                                       txtAte20Agua, _
                                                       txtAte50Agua, _
                                                       txtAcima50Agua, _
                                                       txtRateioAgua, _
                                                       txtTaxaAnaliseAgua, _
                                                       txtAte10Esgoto, _
                                                       txtAte20Esgoto, _
                                                       txtAte50Esgoto, _
                                                       txtAcima50Esgoto)
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculaTotalEsgoto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsumoEsgoto.ValueChanged
        Try

            'Seta Valor Total
            txtTotalDevidoEsgoto.Value = 0

            'Calcula Valor Total
            If txtConsumoEsgoto.Value <= 10 Then

                txtTotalDevidoEsgoto.Value = txtAte10Esgoto.Value

            ElseIf txtConsumoEsgoto.Value > 10 And txtConsumoEsgoto.Value <= 20 Then

                txtTotalDevidoEsgoto.Value = txtConsumoEsgoto.Value * txtAte20Esgoto.Value

            ElseIf txtConsumoEsgoto.Value > 20 And txtConsumoEsgoto.Value <= 50 Then

                txtTotalDevidoEsgoto.Value = txtConsumoEsgoto.Value * txtAte50Esgoto.Value

            ElseIf txtConsumoEsgoto.Value > 50 Then

                txtTotalDevidoEsgoto.Value = txtConsumoEsgoto.Value * txtAcima50Esgoto.Value

            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub CalculaTotalEsgotoCasa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsumoEsgotoCasa.ValueChanged
        Try

            'Seta Valor Total
            txtTotalDevidoEsgotoCasa.Value = 0

            'Calcula Valor Total
            If txtConsumoEsgotoCasa.Value <= 10 Then

                txtTotalDevidoEsgotoCasa.Value = txtAte10EsgotoCasa.Value

            ElseIf txtConsumoEsgotoCasa.Value > 10 And txtConsumoEsgotoCasa.Value <= 20 Then

                txtTotalDevidoEsgotoCasa.Value = txtConsumoEsgotoCasa.Value * txtAte20EsgotoCasa.Value

            ElseIf txtConsumoEsgotoCasa.Value > 20 And txtConsumoEsgotoCasa.Value <= 50 Then

                txtTotalDevidoEsgotoCasa.Value = txtConsumoEsgotoCasa.Value * txtAte50EsgotoCasa.Value

            ElseIf txtConsumoEsgotoCasa.Value > 50 Then

                txtTotalDevidoEsgotoCasa.Value = txtConsumoEsgotoCasa.Value * txtAcima50EsgotoCasa.Value

            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: CONTAS :::"

    Private Sub CalculoValorEnergiaEletrica(ByVal sender As Object, ByVal e As System.EventArgs)


        Try

            Select Case sender.Name

                Case "txtMarcacaoAtualEnergiaEletrica"
                    txtConsumoEnergiaEletrica.Value = txtMarcacaoAtualEnergiaEletrica.Value - txtMarcacaoPrecedenteEnergiaEletrica.Value

                Case "txtMarcacaoPrecedenteEnergiaEletrica"
                    txtConsumoEnergiaEletrica.Value = txtMarcacaoAtualEnergiaEletrica.Value - txtMarcacaoPrecedenteEnergiaEletrica.Value

                Case "txtConsumoEnergiaEletrica"
                    txtTotalDevidoEnergiaEletrica.Value = txtConsumoEnergiaEletrica.Value * txtPrecoMedioEnergiaEletrica.Value

                Case "txtPrecoMedioEnergiaEletrica"
                    txtTotalDevidoEnergiaEletrica.Value = txtConsumoEnergiaEletrica.Value * txtPrecoMedioEnergiaEletrica.Value

                Case "txtMarcacaoAtualEnergiaCasa"
                    txtConsumoEnergiaEletricaCasa.Value = txtMarcacaoAtualEnergiaCasa.Value - txtMarcacaoPrecedenteEnergiaEletricaCasa.Value

                Case "txtMarcacaoPrecedenteEnergiaEletricaCasa"
                    txtConsumoEnergiaEletricaCasa.Value = txtMarcacaoAtualEnergiaCasa.Value - txtMarcacaoPrecedenteEnergiaEletricaCasa.Value

                Case "txtConsumoEnergiaEletricaCasa"
                    txtTotalDevidoEnergiaEletricaCasa.Value = txtConsumoEnergiaEletricaCasa.Value * txtPrecoMedioEnergiaEletricaCasa.Value

                Case "txtPrecoMedioEnergiaEletricaCasa"
                    txtTotalDevidoEnergiaEletricaCasa.Value = txtConsumoEnergiaEletricaCasa.Value * txtPrecoMedioEnergiaEletricaCasa.Value

            End Select



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoValorAgua(ByVal sender As Object, ByVal e As System.EventArgs)


        Try

            Select Case sender.Name

                Case "txtMarcacaoAtualAgua"
                    txtConsumoAgua.Value = txtMarcacaoAtualAgua.Value - txtMarcacaoPrecedenteAgua.Value

                Case "txtMarcacaoPrecedenteAgua"
                    txtConsumoAgua.Value = txtMarcacaoAtualAgua.Value - txtMarcacaoPrecedenteAgua.Value

                Case "txtConsumoAgua"

                    If txtConsumoAgua.Value <= 10 Then

                        txtTotalDevidoAgua.Value = txtAte10Agua.Value

                    ElseIf txtConsumoAgua.Value > 10 And txtConsumoAgua.Value <= 20 Then

                        txtTotalDevidoAgua.Value = (txtConsumoAgua.Value * txtAte20Agua.Value)

                    ElseIf txtConsumoAgua.Value > 20 And txtConsumoAgua.Value <= 50 Then

                        txtTotalDevidoAgua.Value = (txtConsumoAgua.Value * txtAte50Agua.Value)

                    ElseIf txtConsumoAgua.Value > 50 Then

                        txtTotalDevidoAgua.Value = (txtConsumoAgua.Value * txtAcima50Agua.Value)

                    End If


            End Select



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoValorEsgoto(ByVal sender As Object, ByVal e As System.EventArgs)


        Try
            Select Case sender.Name

                Case "txtConsumoEsgoto"

                    If txtConsumoEsgoto.Value <= 10 Then

                        txtTotalDevidoEsgoto.Value = txtAte10Esgoto.Value

                    ElseIf txtConsumoEsgoto.Value > 10 And txtConsumoEsgoto.Value <= 20 Then

                        txtTotalDevidoEsgoto.Value = txtConsumoEsgoto.Value * txtAte20Esgoto.Value

                    ElseIf txtConsumoEsgoto.Value > 20 And txtConsumoEsgoto.Value <= 50 Then

                        txtTotalDevidoEsgoto.Value = txtConsumoEsgoto.Value * txtAte50Esgoto.Value

                    ElseIf txtConsumoEsgoto.Value > 50 Then

                        txtTotalDevidoEsgoto.Value = txtConsumoEsgoto.Value * txtAcima50Esgoto.Value

                    End If


            End Select



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DESCONTO :::"

    Private Sub btnInserirDescontos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDesconto.Click
        Try

            'Inserir
            Call InserirDadosDescontos()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDescontoExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDesconto.Click
        Try

            'Exclui 
            Call ExcluirDadosDescontos()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDesconto_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDesconto.RowDoubleClick
        Try

            'Editar
            Call EditarDadosDescontos()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarDesconto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDescontos.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadDesconto"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            LoadCombo(cboDescontos, "sp_select_combo_cadastro_basico_descontos " & goUsuario.iEmpresa)

            'Seta Focu
            cboDescontos.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: OUTRAS COBRANÇAS :::"

    Private Sub btnInserirOutrasCobrancas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirCobranca.Click
        Try

            'Inserir
            Call InserirDadosOutrasCobrancas()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnOutrasCobrancasExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCobranca.Click
        Try

            'Exclui 
            Call ExcluirDadosOutrasCobrancas()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdOutrasCobrancas_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOutrasCobrancas.RowDoubleClick
        Try

            'Editar
            Call EditarDadosOutrasCobrancas()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarOutrasCobrancas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarOutrasCobrancas.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadOutrasCobrancas"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            LoadCombo(cboOutrasCobrancas, "sp_select_combo_cadastro_basico_outras_cobrancas " & goUsuario.iEmpresa)

            'Seta Focu
            cboOutrasCobrancas.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub




#End Region

#Region "::: VENCIMENTO :::"

    Private Sub btnVencimentoInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVencimentoInserir.Click
        Try

            'Inserir
            Call InserirDadosVencimento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVencimentoExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVencimentoExcluir.Click
        Try

            'Exclui 
            Call ExcluirDadosVencimento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdVencimento_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdVencimento.RowDoubleClick
        Try

            'Editar
            Call EditarDadosVencimento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboVencimentoFormula_CheckedValuesChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVencimentoFormula.CheckedValuesChanged, _
                                                                                                                              txtVencimentoDesconto.LostFocus
        Try

            Dim sFormula() As String
            Dim dVencimentoValorTotal As Double = 0

            sFormula = cboVencimentoFormula.Text.Split(",")

            'Calcula o Valor Total
            If cboVencimentoFormula.SelectionLength > 0 Then

                For i = 0 To UBound(sFormula)


                    'Verifica as Opções Selecionadas
                    If LTrim(RTrim(sFormula(i).ToString())) = "VALOR ALUGUEL" Then

                        dVencimentoValorTotal += txtCalculoValorAluguel.Value

                    ElseIf LTrim(RTrim(sFormula(i).ToString())) = "VALOR ENERGIA" Then

                        dVencimentoValorTotal += txtCalculoValorEnergia.Value

                    ElseIf LTrim(RTrim(sFormula(i).ToString())) = "VALOR ÁGUA" Then

                        dVencimentoValorTotal += txtCalculoValorAgua.Value

                    ElseIf LTrim(RTrim(sFormula(i).ToString())) = "VALOR RATEIO" Then

                        dVencimentoValorTotal += txtCalculoValorRateio.Value

                    ElseIf LTrim(RTrim(sFormula(i).ToString())) = "VALOR ESGOTO" Then

                        dVencimentoValorTotal += txtCalculoValorEsgoto.Value

                    ElseIf LTrim(RTrim(sFormula(i).ToString())) = "OUTRAS COBRANÇAS" Then

                        dVencimentoValorTotal += txtCalculoValorOutrasCobrancas.Value

                    ElseIf LTrim(RTrim(sFormula(i).ToString())) = "SUBTOTAL(1)" Then

                        dVencimentoValorTotal += txtCalculoValorSubtotal1.Value

                    ElseIf LTrim(RTrim(sFormula(i).ToString())) = "VALOR TOTAL" Then

                        dVencimentoValorTotal += txtCalculoValorTotal.Value

                    End If

                Next
            End If

            'Seta Valor Total
            txtVencimentoValor.Value = (dVencimentoValorTotal - txtVencimentoDesconto.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: VINCULAR FINANCEIRO :::"

    Private Sub btnVincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceiroVincular.Click
        Try

            'Verifica se foi selecionado algum título previsto
            If ValidaCampo(cboFinanceiroTituloPrevisto, lblFinanceiroTituloPrevisto) = False Then Exit Sub

            If CStr(btnSalvar.Tag) = "" Then
                MsgBox("Primeiramente, salve o lançamento.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, Me.Parent.Text)
                Exit Sub
            End If

            If txtFinanceiroValorReal.Value > 0 Then

                'Atualiza Dados do Vinculo
                oClsFinReciboLocacao.UpdateVinculoTituloPrevisao(btnSalvar.Tag, _
                                                                 cboFinanceiroTituloPrevisto.SelectedValue.ToString.Substring(0, 10), _
                                                                 txtFinanceiroNumeroDocumento.Text, _
                                                                 cboFinanceiroTituloPrevisto.SelectedValue.ToString.Substring(11, 9), _
                                                                 txtFinanceiroValorPrevisto.Value, _
                                                                 dtpFinanceiroDataVencimentoPrevisto.Value, _
                                                                 txtFinanceiroValorReal.Value, _
                                                                 dtpFinanceiroDataVencimentoReal.Value)


                'Desabilita Controles
                cboFinanceiroTituloPrevisto.Enabled = False
                txtFinanceiroValorReal.Enabled = False
                dtpFinanceiroDataVencimentoReal.Enabled = False
                btnFinanceiroVincular.Enabled = False

                'Mensagem
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else

                MsgBox("Valor Real da Parcela não informado, informe um valor para ele.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, Me.Parent.Text)
                txtFinanceiroValorReal.Focus()
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnFinanceiroDesvincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceiroDesvincular.Click
        Try

            'Verifica se foi selecionado algum título previsto
            If ValidaCampo(cboFinanceiroTituloPrevisto, lblFinanceiroTituloPrevisto) = False Then Exit Sub

            If btnFinanceiroVincular.Enabled = True Then
                MsgBox("Primeiramente, víncule um título.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, Me.Parent.Text)
                Exit Sub
            End If


            'Atualiza Dados do Vinculo
            oClsFinReciboLocacao.UpdateDesvincularTituloPrevisao(btnSalvar.Tag, _
                                                             cboFinanceiroTituloPrevisto.SelectedValue.ToString.Substring(0, 10), _
                                                             cboFinanceiroTituloPrevisto.SelectedValue.ToString.Substring(11, 9))

            'Desabilita Controles
            cboFinanceiroTituloPrevisto.Enabled = True : cboFinanceiroTituloPrevisto.SelectedIndex = -1
            txtFinanceiroValorReal.Enabled = True : txtFinanceiroValorReal.Value = 0
            dtpFinanceiroDataVencimentoReal.Enabled = True : dtpFinanceiroDataVencimentoReal.Value = Now.Date
            txtFinanceiroNumeroDocumento.Text = ""
            txtFinanceiroParcela.Text = ""
            txtFinanceiroValorPrevisto.Value = 0
            dtpFinanceiroDataVencimentoPrevisto.Value = Now.Date
            btnFinanceiroVincular.Enabled = True

            'Mensagem
            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboFinanceiroTituloPrevisto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFinanceiroTituloPrevisto.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum título previsto
            If cboFinanceiroTituloPrevisto.SelectedIndex <> -1 Then

                'Carrega Dados do Título Previsto
                oClsFinReciboLocacao.LoadControlesTituloPrevisao(cboFinanceiroTituloPrevisto.SelectedValue.ToString.Substring(0, 10), _
                                                                 cboFinanceiroTituloPrevisto.SelectedValue.ToString.Substring(11, 9), _
                                                                 txtFinanceiroNumeroDocumento, _
                                                                 txtFinanceiroParcela, _
                                                                 txtFinanceiroValorPrevisto, _
                                                                 dtpFinanceiroDataVencimentoPrevisto)

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReciboLocacao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FinanceiroReciboLocacao, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FinanceiroReciboLocacao, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FinanceiroReciboLocacao, gcDelete)

            'Verifica Direito - Cadastro
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarPaisCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)

            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboPaisCliente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboDescontos, "sp_select_combo_cadastro_basico_descontos " & goUsuario.iEmpresa)
            Call LoadCombo(cboOutrasCobrancas, "sp_select_combo_cadastro_basico_outras_cobrancas " & goUsuario.iEmpresa)
            Call LoadCombo(cboVencimentoFormula, "sp_select_combo_static_formula_vencimento_recibo_locacao " & goUsuario.iEmpresa)


            'Seta Controles
            dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Checked = False

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados da Tabela de Leitura Agua e Esgoto
            oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10Agua, _
                                                   txtAte20Agua, _
                                                   txtAte50Agua, _
                                                   txtAcima50Agua, _
                                                   txtRateioAgua, _
                                                   txtTaxaAnaliseAgua, _
                                                   txtAte10Esgoto, _
                                                   txtAte20Esgoto, _
                                                   txtAte50Esgoto, _
                                                   txtAcima50Esgoto)

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoMunicipalEmitente.Text = goEmitente.sInscricaoMunicipal
            lblValorRegimeTributarioEmitente.Text = goEmitente.sRegimeTributario
            lblValorRazaoSocialEmitente.Text = goEmitente.sRazaoSocial
            lblValorNomeFantasiaEmitente.Text = goEmitente.sNomeFantasia
            lblValorLogradouroEmitente.Text = goEmitente.sLogradouro
            lblValorNumeroEmitente.Text = goEmitente.sNumero
            lblValorComplementoEmitente.Text = goEmitente.sComplemento
            lblValorBairroEmitente.Text = goEmitente.sBairro
            lblValorMunicipioEmitente.Text = goEmitente.sMunicipio
            lblValorUFEmitente.Text = goEmitente.sUF
            lblValorCEPEmiente.Text = goEmitente.sCEP
            lblValorPaisEmitente.Text = goEmitente.sPais

            'Configura Grid

            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReciboLocacao)
            'Call ConfiguraGrid(grdDadosArea, Formulario.FinanceiroReciboLocacao)
            Call ConfiguraGrid(grdGalpaoEnergia, Formulario.FinanceiroReciboLocacao)
            Call ConfiguraGrid(grdAguaGalpao, Formulario.FinanceiroReciboLocacao)
            Call ConfiguraGrid(grdEsgotoGalpao, Formulario.FinanceiroReciboLocacao)
            Call ConfiguraGrid(grdOutrasCobrancas, Formulario.FinanceiroReciboLocacao)
            Call ConfiguraGrid(grdDesconto, Formulario.FinanceiroReciboLocacao)
            Call ConfiguraGrid(grdVencimento, Formulario.FinanceiroReciboLocacao)


            'Oculta Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroReciboFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RECIBO :::"

    Private Sub LoadGridListagem()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsFinReciboLocacao.LoadGridListagem(grdListagem, _
                                                       txtNumeroReciboFiltro.Text, _
                                                       txtClienteFiltro.Text, _
                                                       IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                       IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Limpa Controles
            'Dados Emitente/Cliente           
            cboCliente.SelectedIndex = -1
            cboMunicipioCliente.SelectedIndex = -1
            cboUFCliente.SelectedIndex = -1
            cboPaisCliente.SelectedIndex = -1
            txtBairroCliente.Text = ""
            txtCEPCliente.Text = ""
            txtCNPJCliente.Text = ""
            txtEmailCliente.Text = ""
            txtInscricaoEstadualCliente.Text = ""
            txtInscricaoMunicipalCliente.Text = ""
            txtComplementoCliente.Text = ""
            txtLogradouroCliente.Text = ""
            txtNumeroCliente.Text = ""
            txtNumeroRecibo.Text = ""

            'Dados Area
            cboDadosAreaGalpao.SelectedIndex = -1
            txtAreaConstruidaLocadaGalpao.Value = 0
            txtAreaPatioLocadaGalpao.Value = 0
            txtValorAluguelGalpao.Value = 0
            dtpDataInicioVigenciaContratoGalpao.Value = Now.Date
            dtpDataTerminoVigenciaContratoGalpao.Value = Now.Date

            grdGalpao.DataSource = Nothing
            grdBox.DataSource = Nothing
            grdCasa.DataSource = Nothing
            grdSalaComercial.DataSource = Nothing


            'Contas - Energia Eletrica
            cboDadosEnergiaGalpao.SelectedIndex = -1
            dtpDataLeituraAtualEnergiaEletrica.Value = Now.Date
            dtpDataLeituraPrecedenteEnergiaEletrica.Value = Now.Date
            txtMarcacaoAtualEnergiaEletrica.Value = 0 : txtMarcacaoAtualEnergiaEletrica.Enabled = True
            txtMarcacaoPrecedenteEnergiaEletrica.Value = 0 : txtMarcacaoPrecedenteEnergiaEletrica.Enabled = True
            txtConsumoEnergiaEletrica.Value = 0
            txtPrecoMedioEnergiaEletrica.Value = 0 : txtPrecoMedioEnergiaEletrica.Enabled = True
            txtTotalDevidoEnergiaEletrica.Value = 0
            txtReferenciaContaEnergiaEletrica.Text = ""
            btnInserirEnergiaGalpao.Tag = ""
            grdGalpaoEnergia.DataSource = Nothing

            cboDadosEnergiaCasa.SelectedIndex = -1
            dtpDataLeituraAtualEnergiaEletricaCasa.Value = Now.Date
            dtpDataLeituraPrecedenteEnergiaEletricaCasa.Value = Now.Date
            txtMarcacaoAtualEnergiaCasa.Value = 0 : txtMarcacaoAtualEnergiaCasa.Enabled = True
            txtMarcacaoPrecedenteEnergiaEletricaCasa.Value = 0 : txtMarcacaoPrecedenteEnergiaEletricaCasa.Enabled = True
            txtConsumoEnergiaEletricaCasa.Value = 0
            txtPrecoMedioEnergiaEletricaCasa.Value = 0 : txtPrecoMedioEnergiaEletricaCasa.Enabled = True
            txtTotalDevidoEnergiaEletricaCasa.Value = 0
            txtReferenciaContaEnergiaEletricaCasa.Text = ""
            btnInserirEnergiaCasa.Tag = ""
            grdCasaEnergia.DataSource = Nothing


            'Contas -  Agua
            cboDadosAguaGalpao.SelectedIndex = -1
            dtpDataLeituraAtualAgua.Value = Now.Date
            dtpDataLeituraPrecedenteAgua.Value = Now.Date
            txtMarcacaoAtualAgua.Value = 0 : txtMarcacaoAtualAgua.Enabled = True
            txtMarcacaoPrecedenteAgua.Value = 0 : txtMarcacaoPrecedenteAgua.Enabled = True
            txtConsumoAgua.Value = 0 : txtConsumoAgua.Enabled = True
            txtTotalDevidoAgua.Value = 0
            btnInserirAguaGalpao.Tag = ""
            grdAguaGalpao.DataSource = Nothing

            cboDadosAguaCasa.SelectedIndex = -1
            dtpDataLeituraAtualAguaCasa.Value = Now.Date
            dtpDataLeituraPrecedenteAguaCasa.Value = Now.Date
            txtMarcacaoAtualAguaCasa.Value = 0 : txtMarcacaoAtualAguaCasa.Enabled = True
            txtMarcacaoPrecedenteAguaCasa.Value = 0 : txtMarcacaoPrecedenteAguaCasa.Enabled = True
            txtConsumoAguaCasa.Value = 0 : txtConsumoAguaCasa.Enabled = True
            txtTotalDevidoAguaCasa.Value = 0
            btnInserirAguaCasa.Tag = ""
            grdAguaCasa.DataSource = Nothing

            'Contas - Esgoto
            cboDadosEsgotoGalpao.SelectedIndex = -1
            txtConsumoEsgoto.Value = 0 : txtConsumoEsgoto.Enabled = True
            txtTotalDevidoEsgoto.Value = 0
            btnInserirEsgotoGalpao.Tag = ""
            grdEsgotoGalpao.DataSource = Nothing

            cboDadosEsgotoCasa.SelectedIndex = -1
            txtConsumoEsgotoCasa.Value = 0 : txtConsumoEsgotoCasa.Enabled = True
            txtTotalDevidoEsgotoCasa.Value = 0
            btnInserirEsgotoCasa.Tag = ""
            grdEsgotoCasa.DataSource = Nothing

            'Outras Cobranças
            cboOutrasCobrancas.SelectedIndex = -1
            txtValorOutrasCobrancas.Value = 0
            btnInserirCobranca.Tag = ""
            grdOutrasCobrancas.DataSource = Nothing


            'Descontos
            cboDescontos.SelectedIndex = -1
            txtValorDesconto.Value = 0
            btnInserirDesconto.Tag = ""
            grdDesconto.DataSource = Nothing

            'Vencimento
            txtVencimentoDescricao.Text = "A PAGAR ATÉ: "
            dtpVencimentoDataVencimento.Value = Now.Date
            cboVencimentoFormula.Text = ""
            txtVencimentoDesconto.Value = 0
            txtVencimentoValor.Value = 0
            btnVencimentoInserir.Tag = ""

            'Financeiro VIncular
            cboFinanceiroTituloPrevisto.SelectedIndex = -1 : cboFinanceiroTituloPrevisto.Enabled = True
            txtFinanceiroNumeroDocumento.Text = ""
            txtFinanceiroParcela.Text = ""
            txtFinanceiroValorPrevisto.Value = 0
            dtpFinanceiroDataVencimentoPrevisto.Value = Now.Date
            txtFinanceiroValorReal.Value = 0
            dtpFinanceiroDataVencimentoReal.Value = Now.Date
            btnFinanceiroVincular.Enabled = True : btnFinanceiroVincular.Tag = ""
            btnFinanceiroDesvincular.Enabled = True : btnFinanceiroDesvincular.Tag = ""

            'Seta Focu - Aba
            tabDados.SelectedTab = tabDadosRecibo
            btnSalvar.Tag = ""

            'Seta Focu
            txtNumeroRecibo.Text = oClsFinReciboLocacao.GeraNumeroDocumento()
            txtNumeroRecibo.Focus()
            oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10Agua, _
                                                  txtAte20Agua, _
                                                  txtAte50Agua, _
                                                  txtAcima50Agua, _
                                                  txtRateioAgua, _
                                                  txtTaxaAnaliseAgua, _
                                                  txtAte10Esgoto, _
                                                  txtAte20Esgoto, _
                                                  txtAte50Esgoto, _
                                                  txtAcima50Esgoto)
            oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10AguaCasa, _
                                                       txtAte20AguaCasa, _
                                                       txtAte50AguaCasa, _
                                                       txtAcima50AguaCasa, _
                                                       txtRateioAguaCasa, _
                                                       txtTaxaAnaliseAguaCasa, _
                                                       txtAte10EsgotoCasa, _
                                                       txtAte20EsgotoCasa, _
                                                       txtAte50EsgotoCasa, _
                                                       txtAcima50EsgotoCasa)
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            'Recibo
            oClsFinReciboLocacao.DataEmissao = Now.Date
            oClsFinReciboLocacao.CodigoCliente = cboCliente.SelectedValue
            oClsFinReciboLocacao.NumeroRecibo = txtNumeroRecibo.Text.Trim
            oClsFinReciboLocacao.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsFinReciboLocacao.ValorEnergiaEletrica = txtCalculoValorEnergia.Value
            oClsFinReciboLocacao.ValorAgua = txtCalculoValorAgua.Value
            oClsFinReciboLocacao.ValorRateio = txtCalculoValorRateio.Value
            oClsFinReciboLocacao.ValorEsgoto = txtCalculoValorEsgoto.Value
            oClsFinReciboLocacao.ValorOutrasCobrancas = txtCalculoValorOutrasCobrancas.Value
            oClsFinReciboLocacao.ValorDescontos = txtCalculoDescontos.Value
            oClsFinReciboLocacao.ValorTotal = txtCalculoValorTotal.Value

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then

                oClsFinReciboLocacao.Codigo = btnSalvar.Tag

                'Atualiza Recibo
                oClsFinReciboLocacao.UpdateRecibo(btnSalvar.Tag)

                'Mensagem
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                'Insere Recibo
                oClsFinReciboLocacao.InsertRecibo(btnSalvar)

                'Mensagem
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigo As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then


                'Limpa Dados do Formulário
                ' Call Novo()

                'Carrega Dados Recibo
                Call oClsFinReciboLocacao.LoadDadosRecibo(lCodigo,
                                                          txtNumeroRecibo,
                                                          dtpDataEmissao,
                                                          txtCalculoValorEnergia,
                                                          txtCalculoValorAgua,
                                                          txtCalculoValorEsgoto,
                                                          txtCalculoValorOutrasCobrancas,
                                                          txtCalculoDescontos,
                                                          txtCalculoValorTotal,
                                                          cboCliente)
                'Carrega Dados Area
                Call oClsFinReciboLocacao.LoadGridGalpao(grdGalpao, lCodigo)
                Call oClsFinReciboLocacao.LoadGridSalaComercial(grdSalaComercial, lCodigo)
                Call oClsFinReciboLocacao.LoadGridCasa(grdCasa, lCodigo)
                Call oClsFinReciboLocacao.LoadGridBox(grdBox, lCodigo)

                'Carrega Dados Energia
                Call oClsFinReciboLocacao.LoadGridDadosEnergiaGalpao(grdGalpaoEnergia, _
                                                               lCodigo)

                Call oClsFinReciboLocacao.LoadGridDadosEnergiaCasa(grdCasaEnergia, _
                                                               lCodigo)

                'Carrega Dados Agua
                Call oClsFinReciboLocacao.LoadGridDadosAguaGalpao(grdAguaGalpao, _
                                                            lCodigo)

                Call oClsFinReciboLocacao.LoadGridDadosAguaCasa(grdAguaCasa, _
                                                            lCodigo)

                'Carrega Dados Esgoto
                Call oClsFinReciboLocacao.LoadGridDadosEsgotoGalpao(grdEsgotoGalpao, _
                                                              lCodigo)

                Call oClsFinReciboLocacao.LoadGridDadosEsgotoCasa(grdEsgotoCasa, _
                                                              lCodigo)

                'Carrega Outras Cobranças
                Call oClsFinReciboLocacao.LoadDadosOutrasCobrancas(grdOutrasCobrancas, _
                                                                   lCodigo)
                'Carrega Descontos
                Call oClsFinReciboLocacao.LoadDadosDescontos(grdDesconto, _
                                                             lCodigo)

                'Carrega Vencimento
                Call oClsFinReciboLocacao.LoadGridVencimento(grdVencimento, _
                                                             lCodigo)

                'Carre Titulo Vinculado
                Call oClsFinReciboLocacao.LoadDadosTituloVinculado(lCodigo, _
                                                                   cboFinanceiroTituloPrevisto, _
                                                                   txtFinanceiroNumeroDocumento, _
                                                                   txtFinanceiroParcela, _
                                                                   txtFinanceiroValorPrevisto, _
                                                                   dtpFinanceiroDataVencimentoPrevisto, _
                                                                   txtFinanceiroValorReal, _
                                                                   dtpFinanceiroDataVencimentoReal)

                'Desabilita Controles
                If cboFinanceiroTituloPrevisto.SelectedIndex <> -1 Then

                    cboFinanceiroTituloPrevisto.Enabled = False
                    txtFinanceiroNumeroDocumento.Enabled = False
                    txtFinanceiroParcela.Enabled = False
                    txtFinanceiroValorPrevisto.Enabled = False
                    btnFinanceiroVincular.Enabled = False
                    dtpFinanceiroDataVencimentoPrevisto.Enabled = False
                    txtFinanceiroValorReal.Enabled = False
                    dtpFinanceiroDataVencimentoReal.Enabled = False

                Else
                    cboFinanceiroTituloPrevisto.Enabled = True
                    txtFinanceiroValorReal.Enabled = True
                    dtpFinanceiroDataVencimentoReal.Enabled = True

                End If

                'Seta Controle
                btnSalvar.Tag = lCodigo

                'Alterna Aba


                'Calcula SubTotal
                Call CalculoValorSubTotal1(txtValorAluguelGalpao, System.EventArgs.Empty)


                'Seta Focu
                txtNumeroRecibo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Duplicar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcInsert) = True Then

                'Verifica se o usuário deseja copiar a Nota Fiscal
                If MsgBox("Deseja Duplicar o Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Váriavel Local
                    Dim iCodigoNovo As Integer

                    'Duplica Nota Fiscal
                    Call oClsFinReciboLocacao.DuplicarRecibo(grdListagem.CurrentRow.Cells("codigo_locacao_capa").Value, _
                                                             iCodigoNovo)

                    'Carrega Nota Fiscal
                    Call Editar(iCodigoNovo)

                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Modelo
            If ValidaCampo(cboCliente, lblCliente) = False Then
                tabDados.SelectedTab = tabDadosRecibo
                Exit Function
            End If

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoMunicipalEmitente.Text = goEmitente.sInscricaoMunicipal
            lblValorRegimeTributarioEmitente.Text = goEmitente.sRegimeTributario
            lblValorRazaoSocialEmitente.Text = goEmitente.sRazaoSocial
            lblValorNomeFantasiaEmitente.Text = goEmitente.sNomeFantasia
            lblValorLogradouroEmitente.Text = goEmitente.sLogradouro
            lblValorNumeroEmitente.Text = goEmitente.sNumero
            lblValorComplementoEmitente.Text = goEmitente.sComplemento
            lblValorBairroEmitente.Text = goEmitente.sBairro
            lblValorMunicipioEmitente.Text = goEmitente.sMunicipio
            lblValorUFEmitente.Text = goEmitente.sUF
            lblValorCEPEmiente.Text = goEmitente.sCEP
            lblValorPaisEmitente.Text = goEmitente.sPais


            If ValidaCampo(txtCNPJCliente, lblCNPJCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = tabDadosRecibo
                Exit Function
            End If


            If ValidaCampo(txtNumeroRecibo, lblNumeroRecibo, TipoCampo.texto) = False Then
                tabDados.SelectedTab = tabDadosRecibo
                Exit Function
            End If


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ImprimirRecibo(ByVal iCodigo As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_recibo_capa"
            goCrystalReport.sReportParameter(0).sValue = iCodigo
            'Seta Parametros
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000021.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("FAT000000021", "Recibo de Locação", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirFatura(ByVal iCodigo As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_recibo_capa"
            goCrystalReport.sReportParameter(0).sValue = iCodigo
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000022.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("FAT000000022", "Recibo de Locação", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRecibo()

        Try
            'Salva Dados do Emitente
            oClsFinReciboLocacao.DeleteRecibo()
            oClsFinReciboLocacao.InsertRecibo(btnSalvar)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Excluir()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteRecibo()

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


#End Region


#Region "::: GALPÃO :::"

    Private Sub InserirGalpao()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If


            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDadosAreaGalpao, lblDadosAreaGalpao) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirGalpao.Tag) = False Then

                'Insere Dados
                oClsFinReciboLocacao.InsertGalpao(btnSalvar.Tag, _
                                                  cboDadosAreaGalpao.SelectedValue, _
                                                  txtAreaConstruidaLocadaGalpao.Value, _
                                                  txtAreaPatioLocadaGalpao.Value, _
                                                  txtValorAluguelGalpao.Value, _
                                                  dtpDataInicioVigenciaContratoGalpao.Value, _
                                                  dtpDataTerminoVigenciaContratoGalpao.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateGalpao(btnInserirGalpao.Tag, _
                                                  btnSalvar.Tag, _
                                                  cboDadosAreaGalpao.SelectedValue, _
                                                  txtAreaConstruidaLocadaGalpao.Value,
                                                  txtAreaPatioLocadaGalpao.Value, _
                                                  txtValorAluguelGalpao.Value, _
                                                  dtpDataInicioVigenciaContratoGalpao.Value, _
                                                  dtpDataTerminoVigenciaContratoGalpao.Value)
            End If

            ''Carrega Grid
            oClsFinReciboLocacao.LoadGridGalpao(grdGalpao, btnSalvar.Tag)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarGalpao()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosAreaGalpao.SelectedIndex = -1

                'Carrega Controles
                With grdGalpao.CurrentRow

                    cboDadosAreaGalpao.SelectedValue = .Cells("codigo_galpao").Value
                    txtAreaConstruidaLocadaGalpao.Value = .Cells("area_construida_locada").Value
                    txtAreaPatioLocadaGalpao.Value = .Cells("area_patio_locada").Value
                    txtValorAluguelGalpao.Value = .Cells("valor_aluguel").Value
                    dtpDataInicioVigenciaContratoGalpao.Value = .Cells("inicio_vigencia_contrato").Value
                    dtpDataTerminoVigenciaContratoGalpao.Value = .Cells("termino_vigencia_contrato").Value

                    btnInserirGalpao.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDadosAreaGalpao.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirGalpao()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdGalpao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteGalpao()

                    'Carrega Grid
                    oClsFinReciboLocacao.LoadGridGalpao(grdGalpao, btnSalvar.Tag)

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

    Private Sub LimpaDadosGalpao()
        Try
            'Limpa Controles
            cboDadosAreaGalpao.SelectedIndex = -1
            txtAreaConstruidaLocadaGalpao.Value = 0
            txtAreaPatioLocadaGalpao.Value = 0
            txtValorAluguelGalpao.Value = 0
            dtpDataInicioVigenciaContratoGalpao.Value = Now.Date
            dtpDataTerminoVigenciaContratoGalpao.Value = Now.Date
            btnInserirGalpao.Tag = ""

            'Seta Focu
            cboDadosAreaGalpao.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: SALA :::"

    Private Sub InserirSala()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If


            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboSala, lblDadosAreaSala) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirSala.Tag) = False Then

                'Insere Dados
                oClsFinReciboLocacao.InsertSalaComercial(btnSalvar.Tag, _
                                                         cboSala.SelectedValue, _
                                                         txtAreaConstruidaLocadaSala.Value, _
                                                         txtAreaTerrenoLocadaSala.Value, _
                                                         txtValorAluguelSala.Value, _
                                                         dtpDataInicioVigenciaContratoSala.Value, _
                                                         dtpDataTerminoVigenciaContratoSala.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateSalaComercial(btnInserirSala.Tag, _
                                                         btnSalvar.Tag, _
                                                         cboSala.SelectedValue, _
                                                         txtAreaConstruidaLocadaSala.Value, _
                                                         txtAreaTerrenoLocadaSala.Value, _
                                                         txtValorAluguelSala.Value, _
                                                         dtpDataInicioVigenciaContratoSala.Value, _
                                                         dtpDataTerminoVigenciaContratoSala.Value)

            End If

            ''Carrega Grid
            oClsFinReciboLocacao.LoadGridSalaComercial(grdSalaComercial, btnSalvar.Tag)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarSala()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboSala.SelectedIndex = -1

                'Carrega Controles
                With grdSalaComercial.CurrentRow

                    cboSala.SelectedValue = .Cells("codigo_sala").Value
                    txtAreaConstruidaLocadaSala.Value = .Cells("area_construida_locada").Value
                    txtAreaTerrenoLocadaSala.Value = .Cells("area_patio_locada").Value
                    txtValorAluguelSala.Value = .Cells("valor_aluguel").Value
                    dtpDataInicioVigenciaContratoSala.Value = .Cells("inicio_vigencia_contrato").Value
                    dtpDataTerminoVigenciaContratoSala.Value = .Cells("termino_vigencia_contrato").Value
                    btnInserirSala.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboSala.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirSala()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdSalaComercial) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteSalaComercial()

                    'Carrega Grid
                    oClsFinReciboLocacao.LoadGridSalaComercial(grdSalaComercial, btnSalvar.Tag)

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

    Private Sub LimpaDadosSala()
        Try
            'Limpa Controles
            cboSala.SelectedIndex = -1
            txtAreaConstruidaLocadaSala.Value = 0
            txtAreaTerrenoLocadaSala.Value = 0
            txtValorAluguelSala.Value = 0
            dtpDataInicioVigenciaContratoSala.Value = Now.Date
            dtpDataTerminoVigenciaContratoSala.Value = Now.Date
            btnInserirSala.Tag = ""

            'Seta Focu
            cboSala.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: CASA :::"

    Private Sub InserirCasa()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If


            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboCasa, lblDadosAreaCasa) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirCasa.Tag) = False Then

                'Insere Dados
                oClsFinReciboLocacao.InsertCasa(btnSalvar.Tag, _
                                                cboCasa.SelectedValue, _
                                                txtAreaConstruidaLocadaCasa.Value, _
                                                txtAreaTerrenoLocadaCasa.Value, _
                                                txtValorAluguelCasa.Value, _
                                                dtpDataInicioVigenciaContratoCasa.Value, _
                                                dtpDataTerminoVigenciaContratoCasa.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateCasa(btnInserirCasa.Tag, _
                                                btnSalvar.Tag, _
                                                cboCasa.SelectedValue, _
                                                txtAreaConstruidaLocadaCasa.Value, _
                                                txtAreaTerrenoLocadaCasa.Value, _
                                                txtValorAluguelCasa.Value, _
                                                dtpDataInicioVigenciaContratoCasa.Value, _
                                                dtpDataTerminoVigenciaContratoCasa.Value)
            End If

            ''Carrega Grid
            oClsFinReciboLocacao.LoadGridCasa(grdCasa, btnSalvar.Tag)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarCasa()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboCasa.SelectedIndex = -1

                'Carrega Controles
                With grdCasa.CurrentRow

                    cboCasa.SelectedValue = .Cells("codigo_Casa").Value
                    txtAreaConstruidaLocadaCasa.Value = .Cells("area_construida_locada").Value
                    txtAreaTerrenoLocadaCasa.Value = .Cells("area_patio_locada").Value
                    txtValorAluguelCasa.Value = .Cells("valor_aluguel").Value
                    dtpDataInicioVigenciaContratoCasa.Value = .Cells("inicio_vigencia_contrato").Value
                    dtpDataTerminoVigenciaContratoCasa.Value = .Cells("termino_vigencia_contrato").Value
                    'cboIPTUCasa.SelectedValue = .Cells("codigo_iptu").Value
                    'txtValorM2IPTUCasa.Value = .Cells("valor_m2").Value
                    'txtValorTotalIPTUCasa.Value = .Cells("valor_total").Value
                    'txtValorDescontoIPTUCasa.Value = .Cells("valor_desconto").Value
                    'txtValorReembolsoIPTUCasa.Value = .Cells("valor_reembolso").Value
                    'txtNumeroParcelaIPTUCasa.Value = .Cells("numero_parcelas").Value
                    btnInserirCasa.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboCasa.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirCasa()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdCasa) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteCasa()

                    'Carrega Grid
                    oClsFinReciboLocacao.LoadGridCasa(grdCasa, btnSalvar.Tag)

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

    Private Sub LimpaDadosCasa()
        Try
            'Limpa Controles
            cboCasa.SelectedIndex = -1
            txtAreaConstruidaLocadaCasa.Value = 0
            txtAreaTerrenoLocadaCasa.Value = 0
            txtValorAluguelCasa.Value = 0
            dtpDataInicioVigenciaContratoCasa.Value = Now.Date
            dtpDataTerminoVigenciaContratoCasa.Value = Now.Date
            btnInserirCasa.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: BOX :::"

    Private Sub InserirBox()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If


            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboBox, lblDadosAreaBox) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirBox.Tag) = False Then

                'Insere Dados
                oClsFinReciboLocacao.InsertBox(btnSalvar.Tag, _
                                               cboBox.SelectedValue, _
                                               txtAreaConstruidaLocadaBox.Value, _
                                               txtAreaTerrenoLocadaBox.Value, _
                                               txtValorAluguelCasa.Value, _
                                               dtpDataInicioVigenciaContratoBox.Value, _
                                               dtpDataTerminoVigenciaContratoBox.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateBox(btnInserirBox.Tag, _
                                               btnSalvar.Tag, _
                                               cboBox.SelectedValue, _
                                               txtAreaConstruidaLocadaBox.Value, _
                                               txtAreaTerrenoLocadaBox.Value, _
                                               txtValorAluguelCasa.Value, _
                                               dtpDataInicioVigenciaContratoBox.Value, _
                                               dtpDataTerminoVigenciaContratoBox.Value)
            End If

            ''Carrega Grid
            oClsFinReciboLocacao.LoadGridBox(grdBox, btnSalvar.Tag)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarBox()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboBox.SelectedIndex = -1

                'Carrega Controles
                With grdBox.CurrentRow

                    cboBox.SelectedValue = .Cells("codigo_box").Value
                    txtAreaConstruidaLocadaBox.Value = .Cells("area_construida_locada").Value
                    txtAreaTerrenoLocadaBox.Value = .Cells("area_patio_locada").Value
                    txtValorAluguelBox.Value = .Cells("valor_aluguel").Value
                    dtpDataInicioVigenciaContratoBox.Value = .Cells("inicio_vigencia_contrato").Value
                    dtpDataTerminoVigenciaContratoBox.Value = .Cells("termino_vigencia_contrato").Value
                    btnInserirBox.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboBox.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirBox()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdBox) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteBox()

                    'Carrega Grid
                    oClsFinReciboLocacao.LoadGridCasa(grdBox, btnSalvar.Tag)

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

    Private Sub LimpaDadosBox()
        Try
            'Limpa Controles
            cboBox.SelectedIndex = -1
            txtAreaConstruidaLocadaBox.Value = 0
            txtAreaTerrenoLocadaBox.Value = 0
            txtValorAluguelBox.Value = 0
            dtpDataInicioVigenciaContratoBox.Value = Now.Date
            dtpDataTerminoVigenciaContratoBox.Value = Now.Date
            btnInserirBox.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region



#Region "::: DADOS AREA :::"

    Private Sub ExcluirDadosArea()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdGalpao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboDadosArea()

                    'Carrega Grid
                    'oClsFinReciboLocacao.LoadGridDadosArea(grdDadosArea, _
                    '                                       btnSalvar.Tag)

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

    Private Sub InserirDadosArea()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Gera Numero Documento
                If txtNumeroRecibo.Text = "" Then

                    txtNumeroRecibo.Text = oClsFinReciboLocacao.GeraNumeroDocumento()

                End If

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If


            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDadosAreaGalpao, lblDadosAreaGalpao) = False Then
                Exit Sub
            End If

            'If IsNumeric(btnDadosAreaInserir.Tag) = False Then

            '    'Insere Dados
            '    oClsFinReciboLocacao.InsertReciboDadosArea(btnSalvar.Tag, _
            '                                               IIf(cboDadosAreaGalpao.SelectedIndex = -1, -1, cboDadosAreaGalpao.SelectedValue), _
            '                                               txtDadosAreaNumeroRecibo.Text.Trim, _
            '                                               txtDadosAreaAreaConstruidaLocada.Value, _
            '                                               txtDadosAreaAreaPatioLocada.Value, _
            '                                               txtDadosAreaValorAluguel.Value, _
            '                                               txtDadosAreaReferenciaInterna.Text.ToString, _
            '                                               IIf(IsDBNull(dtpDadosAreaDataInicioVigenciaContrato.Value), Now.Date, dtpDadosAreaDataInicioVigenciaContrato.Value), _
            '                                               IIf(IsDBNull(dtpDadosAreaDataTerminoVigenciaContrato.Value), Now.Date, dtpDadosAreaDataTerminoVigenciaContrato.Value), _
            '                                               txtDadosAreaPeriodoReferencia.Text.ToString, _
            '                                               IIf(IsDBNull(dtpDadosAreaDadosAreaDataVencimento.Value), Now.Date, dtpDadosAreaDadosAreaDataVencimento.Value))

            'Else
            '    'Atualiza Dados
            '    oClsFinReciboLocacao.UpdateReciboDadosArea(btnDadosAreaInserir.Tag, _
            '                                               btnSalvar.Tag, _
            '                                               IIf(cboDadosAreaGalpao.SelectedIndex = -1, -1, cboDadosAreaGalpao.SelectedValue), _
            '                                               txtDadosAreaNumeroRecibo.Text.Trim, _
            '                                               txtDadosAreaAreaConstruidaLocada.Value, _
            '                                               txtDadosAreaAreaPatioLocada.Value, _
            '                                               txtDadosAreaValorAluguel.Value, _
            '                                               txtDadosAreaReferenciaInterna.Text.ToString, _
            '                                               IIf(IsDBNull(dtpDadosAreaDataInicioVigenciaContrato.Value), Now.Date, dtpDadosAreaDataInicioVigenciaContrato.Value), _
            '                                               IIf(IsDBNull(dtpDadosAreaDataTerminoVigenciaContrato.Value), Now.Date, dtpDadosAreaDataTerminoVigenciaContrato.Value), _
            '                                               txtDadosAreaPeriodoReferencia.Text.ToString, _
            '                                               IIf(IsDBNull(dtpDadosAreaDadosAreaDataVencimento.Value), Now.Date, dtpDadosAreaDadosAreaDataVencimento.Value))
            'End If

            ''Carrega Grid
            'oClsFinReciboLocacao.LoadGridDadosArea(grdDadosArea, _
            '                                       btnSalvar.Tag)
            'Limpa Controle
            LimpaDadosArea()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarDadosArea()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosAreaGalpao.SelectedIndex = -1

                'Carrega Controles
                'With grdDadosArea.CurrentRow

                '    cboDadosAreaGalpao.SelectedValue = .Cells("codigo_galpao").Value
                '    txtDadosAreaPeriodoReferencia.Text = .Cells("periodo_referencia").Value
                '    btnDadosAreaInserir.Tag = .Cells("codigo").Value

                'End With

                'Seta Focu
                cboDadosAreaGalpao.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpaDadosArea()
        Try
            'Limpa Controles
            txtAreaConstruidaLocadaGalpao.Value = 0
            txtAreaPatioLocadaGalpao.Value = 0
            txtValorAluguelGalpao.Value = 0
            cboDadosAreaGalpao.SelectedIndex = -1

            'Seta Focu
            cboDadosAreaGalpao.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region

#Region "::: DADOS ENERGIA :::"

    Private Sub ExcluirDadosEnergiaGalpao()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdGalpaoEnergia) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboDadosEnergia()



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

    Private Sub ExcluirDadosEnergiaCasa()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdCasaEnergia) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboDadosEnergia()



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

    Private Sub InserirDadosEnergiaGalpao()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDadosEnergiaGalpao, lblDadosEnergiaGalpao) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirEnergiaGalpao.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertReciboDadosEnergiaGalpao(btnSalvar.Tag, _
                                                              IIf(cboDadosEnergiaGalpao.SelectedIndex = -1, -1, cboDadosEnergiaGalpao.SelectedValue), _
                                                              IIf(IsDBNull(dtpDataLeituraAtualEnergiaEletrica.Value), Now.Date, dtpDataLeituraAtualEnergiaEletrica.Value), _
                                                              txtMarcacaoAtualEnergiaEletrica.Value, _
                                                              IIf(IsDBNull(dtpDataLeituraPrecedenteEnergiaEletrica.Value), Now.Date, dtpDataLeituraPrecedenteEnergiaEletrica.Value), _
                                                              txtMarcacaoPrecedenteEnergiaEletrica.Value, _
                                                              txtConsumoEnergiaEletrica.Value, _
                                                              txtPrecoMedioEnergiaEletrica.Value, _
                                                              txtTotalDevidoEnergiaEletrica.Value, _
                                                              txtReferenciaContaEnergiaEletrica.Text)

            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateReciboDadosEnergiaGalpao(btnInserirEnergiaGalpao.Tag, _
                                                              btnSalvar.Tag, _
                                                              IIf(cboDadosEnergiaGalpao.SelectedIndex = -1, -1, cboDadosEnergiaGalpao.SelectedValue), _
                                                              IIf(IsDBNull(dtpDataLeituraAtualEnergiaEletrica.Value), Now.Date, dtpDataLeituraAtualEnergiaEletrica.Value), _
                                                              txtMarcacaoAtualEnergiaEletrica.Value, _
                                                              IIf(IsDBNull(dtpDataLeituraPrecedenteEnergiaEletrica.Value), Now.Date, dtpDataLeituraPrecedenteEnergiaEletrica.Value), _
                                                              txtMarcacaoPrecedenteEnergiaEletrica.Value, _
                                                              txtConsumoEnergiaEletrica.Value, _
                                                              txtPrecoMedioEnergiaEletrica.Value, _
                                                              txtTotalDevidoEnergiaEletrica.Value, _
                                                              txtReferenciaContaEnergiaEletrica.Text)
            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEnergiaGalpao(grdGalpaoEnergia, _
                                                      btnSalvar.Tag)
            'Limpa Controle
            LimpaDadosEnergiaGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub InserirDadosEnergiaCasa()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDadosEnergiaCasa, lblDadosEnergiaCasa) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirEnergiaCasa.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertReciboDadosEnergiaCasa(btnSalvar.Tag, _
                                                              IIf(cboDadosEnergiaCasa.SelectedIndex = -1, -1, cboDadosEnergiaCasa.SelectedValue), _
                                                              IIf(IsDBNull(dtpDataLeituraAtualEnergiaEletricaCasa.Value), Now.Date, dtpDataLeituraAtualEnergiaEletricaCasa.Value), _
                                                              txtMarcacaoAtualEnergiaCasa.Value, _
                                                              IIf(IsDBNull(dtpDataLeituraPrecedenteEnergiaEletricaCasa.Value), Now.Date, dtpDataLeituraPrecedenteEnergiaEletricaCasa.Value), _
                                                              txtMarcacaoPrecedenteEnergiaEletricaCasa.Value, _
                                                              txtConsumoEnergiaEletricaCasa.Value, _
                                                              txtPrecoMedioEnergiaEletricaCasa.Value, _
                                                              txtTotalDevidoEnergiaEletricaCasa.Value, _
                                                              txtReferenciaContaEnergiaEletricaCasa.Text)

            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateReciboDadosEnergiaCasa(btnInserirEnergiaCasa.Tag, _
                                                              btnSalvar.Tag, _
                                                              IIf(cboDadosEnergiaCasa.SelectedIndex = -1, -1, cboDadosEnergiaGalpao.SelectedValue), _
                                                              IIf(IsDBNull(dtpDataLeituraAtualEnergiaEletricaCasa.Value), Now.Date, dtpDataLeituraAtualEnergiaEletricaCasa.Value), _
                                                              txtMarcacaoAtualEnergiaCasa.Value, _
                                                              IIf(IsDBNull(dtpDataLeituraPrecedenteEnergiaEletricaCasa.Value), Now.Date, dtpDataLeituraPrecedenteEnergiaEletricaCasa.Value), _
                                                              txtMarcacaoPrecedenteEnergiaEletricaCasa.Value, _
                                                              txtConsumoEnergiaEletricaCasa.Value, _
                                                              txtPrecoMedioEnergiaEletricaCasa.Value, _
                                                              txtTotalDevidoEnergiaEletricaCasa.Value, _
                                                              txtReferenciaContaEnergiaEletricaCasa.Text)
            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEnergiaCasa(grdCasaEnergia, _
                                                      btnSalvar.Tag)
            'Limpa Controle
            LimpaDadosEnergiaCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarDadosEnergiaGalpao()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosEnergiaGalpao.SelectedIndex = -1

                'Carrega Controles
                With grdGalpaoEnergia.CurrentRow

                    cboDadosEnergiaGalpao.SelectedValue = .Cells("codigo_galpao").Value
                    dtpDataLeituraAtualEnergiaEletrica.Value = IIf(IsDBNull(.Cells("data_leitura_atual").Value), Now, .Cells("data_leitura_atual").Value)
                    txtMarcacaoAtualEnergiaEletrica.Value = IIf(IsDBNull(.Cells("marcacao_atual").Value), 0, .Cells("marcacao_atual").Value)
                    dtpDataLeituraPrecedenteEnergiaEletrica.Value = IIf(IsDBNull(.Cells("data_leitura_precedente").Value), Now, .Cells("data_leitura_precedente").Value)
                    txtMarcacaoPrecedenteEnergiaEletrica.Value = IIf(IsDBNull(.Cells("marcacao_precedente").Value), 0, .Cells("marcacao_precedente").Value)
                    txtPrecoMedioEnergiaEletrica.Value = IIf(IsDBNull(.Cells("preco_medio_energia").Value), 0, .Cells("preco_medio_energia").Value)
                    txtReferenciaContaEnergiaEletrica.Text = IIf(IsDBNull(.Cells("referencia_conta_energia").Value), 0, .Cells("referencia_conta_energia").Value)
                    btnInserirEnergiaGalpao.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDadosEnergiaGalpao.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarDadosEnergiaCasa()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosEnergiaCasa.SelectedIndex = -1

                'Carrega Controles
                With grdCasaEnergia.CurrentRow

                    cboDadosEnergiaCasa.SelectedValue = .Cells("codigo_casa").Value
                    dtpDataLeituraAtualEnergiaEletricaCasa.Value = IIf(IsDBNull(.Cells("data_leitura_atual").Value), Now, .Cells("data_leitura_atual").Value)
                    txtMarcacaoAtualEnergiaCasa.Value = IIf(IsDBNull(.Cells("marcacao_atual").Value), 0, .Cells("marcacao_atual").Value)
                    dtpDataLeituraPrecedenteEnergiaEletricaCasa.Value = IIf(IsDBNull(.Cells("data_leitura_precedente").Value), Now, .Cells("data_leitura_precedente").Value)
                    txtMarcacaoPrecedenteEnergiaEletricaCasa.Value = IIf(IsDBNull(.Cells("marcacao_precedente").Value), 0, .Cells("marcacao_precedente").Value)
                    txtPrecoMedioEnergiaEletricaCasa.Value = IIf(IsDBNull(.Cells("preco_medio_energia").Value), 0, .Cells("preco_medio_energia").Value)
                    txtReferenciaContaEnergiaEletricaCasa.Text = IIf(IsDBNull(.Cells("referencia_conta_energia").Value), 0, .Cells("referencia_conta_energia").Value)
                    btnInserirEnergiaCasa.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDadosEnergiaCasa.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpaDadosEnergiaGalpao()
        Try
            'Limpa Controles
            txtMarcacaoAtualEnergiaEletrica.Value = 0
            txtMarcacaoPrecedenteEnergiaEletrica.Value = 0
            txtPrecoMedioEnergiaEletrica.Value = 0
            txtReferenciaContaEnergiaEletrica.Text = ""
            btnInserirEnergiaGalpao.Tag = ""
            cboDadosEnergiaGalpao.SelectedIndex = -1

            'Seta Focu
            cboDadosEnergiaGalpao.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpaDadosEnergiaCasa()
        Try
            'Limpa Controles
            txtMarcacaoAtualEnergiaCasa.Value = 0
            txtMarcacaoPrecedenteEnergiaEletricaCasa.Value = 0
            txtPrecoMedioEnergiaEletricaCasa.Value = 0
            txtReferenciaContaEnergiaEletricaCasa.Text = ""
            btnInserirEnergiaCasa.Tag = ""
            cboDadosEnergiaCasa.SelectedIndex = -1

            'Seta Focu
            cboDadosEnergiaCasa.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: DADOS AGUA :::"

    Private Sub ExcluirDadosAguaGalpao()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdAguaGalpao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboDadosAgua()



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

    Private Sub ExcluirDadosAguaCasa()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdAguaCasa) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboDadosAgua()



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

    Private Sub InserirDadosAguaGalpao()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDadosAguaGalpao, lblDadosAguaGalpao) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirAguaGalpao.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertReciboDadosAguaGalpao(btnSalvar.Tag, _
                                                           IIf(cboDadosAguaGalpao.SelectedIndex = -1, -1, cboDadosAguaGalpao.SelectedValue), _
                                                           IIf(IsDBNull(dtpDataLeituraAtualAgua.Value), Now.Date, dtpDataLeituraAtualAgua.Value), _
                                                            txtMarcacaoAtualAgua.Value, _
                                                            IIf(IsDBNull(dtpDataLeituraPrecedenteAgua.Value), Now.Date, dtpDataLeituraPrecedenteAgua.Value), _
                                                            txtMarcacaoPrecedenteAgua.Value, _
                                                            txtConsumoAgua.Value, _
                                                            txtTotalDevidoAgua.Value, _
                                                            txtAte10Agua.Value, _
                                                            txtAte20Agua.Value, _
                                                            txtAte50Agua.Value, _
                                                            txtAcima50Agua.Value, _
                                                            txtRateioAgua.Value, _
                                                            txtTaxaAnaliseAgua.Value)

            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateReciboDadosAguaGalpao(btnInserirAguaGalpao.Tag, _
                                                           btnSalvar.Tag, _
                                                           IIf(cboDadosAguaGalpao.SelectedIndex = -1, -1, cboDadosAguaGalpao.SelectedValue), _
                                                           IIf(IsDBNull(dtpDataLeituraAtualAgua.Value), Now.Date, dtpDataLeituraAtualAgua.Value), _
                                                            txtMarcacaoAtualAgua.Value, _
                                                            IIf(IsDBNull(dtpDataLeituraPrecedenteAgua.Value), Now.Date, dtpDataLeituraPrecedenteAgua.Value), _
                                                            txtMarcacaoPrecedenteAgua.Value, _
                                                            txtConsumoAgua.Value, _
                                                            txtTotalDevidoAgua.Value, _
                                                            txtAte10Agua.Value, _
                                                            txtAte20Agua.Value, _
                                                            txtAte50Agua.Value, _
                                                            txtAcima50Agua.Value, _
                                                            txtRateioAgua.Value, _
                                                            txtTaxaAnaliseAgua.Value)
            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosAguaGalpao(grdAguaGalpao, _
                                                   btnSalvar.Tag)
            'Limpa Controle
            LimpaDadosAguaGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub InserirDadosAguaCasa()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDadosAguaCasa, lblDadosAguaCasa) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirAguaCasa.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertReciboDadosAguaCasa(btnSalvar.Tag, _
                                                           IIf(cboDadosAguaCasa.SelectedIndex = -1, -1, cboDadosAguaCasa.SelectedValue), _
                                                           IIf(IsDBNull(dtpDataLeituraAtualAguaCasa.Value), Now.Date, dtpDataLeituraAtualAguaCasa.Value), _
                                                            txtMarcacaoAtualAguaCasa.Value, _
                                                            IIf(IsDBNull(dtpDataLeituraPrecedenteAguaCasa.Value), Now.Date, dtpDataLeituraPrecedenteAguaCasa.Value), _
                                                            txtMarcacaoPrecedenteAguaCasa.Value, _
                                                            txtConsumoAguaCasa.Value, _
                                                            txtTotalDevidoAguaCasa.Value, _
                                                            txtAte10AguaCasa.Value, _
                                                            txtAte20AguaCasa.Value, _
                                                            txtAte50AguaCasa.Value, _
                                                            txtAcima50AguaCasa.Value, _
                                                            txtRateioAguaCasa.Value, _
                                                            txtTaxaAnaliseAguaCasa.Value)

            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateReciboDadosAguaCasa(btnInserirAguaCasa.Tag, _
                                                           btnSalvar.Tag, _
                                                           IIf(cboDadosAguaCasa.SelectedIndex = -1, -1, cboDadosAguaCasa.SelectedValue), _
                                                           IIf(IsDBNull(dtpDataLeituraAtualAguaCasa.Value), Now.Date, dtpDataLeituraAtualAguaCasa.Value), _
                                                            txtMarcacaoAtualAguaCasa.Value, _
                                                            IIf(IsDBNull(dtpDataLeituraPrecedenteAguaCasa.Value), Now.Date, dtpDataLeituraPrecedenteAguaCasa.Value), _
                                                            txtMarcacaoPrecedenteAguaCasa.Value, _
                                                            txtConsumoAguaCasa.Value, _
                                                            txtTotalDevidoAguaCasa.Value, _
                                                            txtAte10AguaCasa.Value, _
                                                            txtAte20AguaCasa.Value, _
                                                            txtAte50AguaCasa.Value, _
                                                            txtAcima50AguaCasa.Value, _
                                                            txtRateioAguaCasa.Value, _
                                                            txtTaxaAnaliseAguaCasa.Value)
            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosAguaCasa(grdAguaCasa, _
                                                   btnSalvar.Tag)
            'Limpa Controle
            LimpaDadosAguaCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarDadosAguaGalpao()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosAguaGalpao.SelectedIndex = -1

                'Carrega Controles
                With grdAguaGalpao.CurrentRow
                    oClsFinReciboLocacao.LoadDadosGalpao(IIf(cboDadosAguaGalpao.SelectedIndex = -1, -1, cboDadosAguaGalpao.SelectedValue), _
                                                     btnExcluirAguaGalpao.Tag)

                    'Carrega Dados da Tabela de Leitura Agua e Esgoto
                    oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10Agua, _
                                                           txtAte20Agua, _
                                                           txtAte50Agua, _
                                                           txtAcima50Agua, _
                                                           txtRateioAgua, _
                                                           txtTaxaAnaliseAgua, _
                                                           txtAte10Esgoto, _
                                                           txtAte20Esgoto, _
                                                           txtAte50Esgoto, _
                                                           txtAcima50Esgoto)

                    cboDadosAguaGalpao.SelectedValue = .Cells("codigo_galpao").Value
                    dtpDataLeituraAtualAgua.Value = IIf(IsDBNull(.Cells("data_leitura_atual").Value), Now, .Cells("data_leitura_atual").Value)
                    txtMarcacaoAtualAgua.Value = IIf(IsDBNull(.Cells("marcacao_atual").Value), 0, .Cells("marcacao_atual").Value)
                    dtpDataLeituraPrecedenteAgua.Value = IIf(IsDBNull(.Cells("data_leitura_precedente").Value), Now, .Cells("data_leitura_precedente").Value)
                    txtMarcacaoPrecedenteAgua.Value = IIf(IsDBNull(.Cells("marcacao_precedente").Value), 0, .Cells("marcacao_precedente").Value)
                    txtAte10Agua.Value = IIf(IsDBNull(.Cells("valor_ate_10").Value), txtAte10Agua.Value, .Cells("valor_ate_10").Value)
                    txtAte20Agua.Value = IIf(IsDBNull(.Cells("valor_ate_20").Value), txtAte20Agua.Value, .Cells("valor_ate_20").Value)
                    txtAte50Agua.Value = IIf(IsDBNull(.Cells("valor_ate_50").Value), txtAte50Agua.Value, .Cells("valor_ate_50").Value)
                    txtAcima50Agua.Value = IIf(IsDBNull(.Cells("valor_acima_50").Value), txtAcima50Agua.Value, .Cells("valor_acima_50").Value)
                    txtRateioAgua.Value = IIf(IsDBNull(.Cells("rateio_agua").Value), txtRateioAgua.Value, .Cells("rateio_agua").Value)
                    txtTaxaAnaliseAgua.Value = IIf(IsDBNull(.Cells("taxa_analise_agua").Value), txtTaxaAnaliseAgua.Value, .Cells("taxa_analise_agua").Value)
                    btnInserirAguaGalpao.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDadosAguaGalpao.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarDadosAguaCasa()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosAguaCasa.SelectedIndex = -1

                'Carrega Controles
                With grdAguaCasa.CurrentRow
                    oClsFinReciboLocacao.LoadDadosCasa(IIf(cboDadosAguaCasa.SelectedIndex = -1, -1, cboDadosAguaCasa.SelectedValue), _
                                                     btnExcluirAguaCasa.Tag)

                    'Carrega Dados da Tabela de Leitura Agua e Esgoto
                    oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10AguaCasa, _
                                                           txtAte20AguaCasa, _
                                                           txtAte50AguaCasa, _
                                                           txtAcima50AguaCasa, _
                                                           txtRateioAguaCasa, _
                                                           txtTaxaAnaliseAguaCasa, _
                                                           txtAte10EsgotoCasa, _
                                                           txtAte20EsgotoCasa, _
                                                           txtAte50EsgotoCasa, _
                                                           txtAcima50EsgotoCasa)
                    cboDadosAguaCasa.SelectedValue = .Cells("codigo_casa").Value
                    dtpDataLeituraAtualAguaCasa.Value = IIf(IsDBNull(.Cells("data_leitura_atual").Value), Now, .Cells("data_leitura_atual").Value)
                    txtMarcacaoAtualAguaCasa.Value = IIf(IsDBNull(.Cells("marcacao_atual").Value), 0, .Cells("marcacao_atual").Value)
                    dtpDataLeituraPrecedenteAguaCasa.Value = IIf(IsDBNull(.Cells("data_leitura_precedente").Value), Now, .Cells("data_leitura_precedente").Value)
                    txtMarcacaoPrecedenteAguaCasa.Value = IIf(IsDBNull(.Cells("marcacao_precedente").Value), 0, .Cells("marcacao_precedente").Value)
                    txtAte10AguaCasa.Value = IIf(IsDBNull(.Cells("valor_ate_10").Value), txtAte10AguaCasa.Value, .Cells("valor_ate_10").Value)
                    txtAte20AguaCasa.Value = IIf(IsDBNull(.Cells("valor_ate_20").Value), txtAte20AguaCasa.Value, .Cells("valor_ate_20").Value)
                    txtAte50AguaCasa.Value = IIf(IsDBNull(.Cells("valor_ate_50").Value), txtAte50AguaCasa.Value, .Cells("valor_ate_50").Value)
                    txtAcima50AguaCasa.Value = IIf(IsDBNull(.Cells("valor_acima_50").Value), txtAcima50AguaCasa.Value, .Cells("valor_acima_50").Value)
                    txtRateioAguaCasa.Value = IIf(IsDBNull(.Cells("rateio_agua").Value), txtRateioAguaCasa.Value, .Cells("rateio_agua").Value)
                    txtTaxaAnaliseAguaCasa.Value = IIf(IsDBNull(.Cells("taxa_analise_Agua").Value), txtTaxaAnaliseAguaCasa.Value, .Cells("taxa_analise_Agua").Value)
                    btnInserirAguaCasa.Tag = .Cells("codigo").Value
                    
                End With

                'Seta Focu
                cboDadosAguaCasa.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpaDadosAguaGalpao()
        Try
            'Limpa Controles
            txtMarcacaoAtualAgua.Value = 0
            txtMarcacaoPrecedenteAgua.Value = 0
            btnInserirAguaGalpao.Tag = ""
            cboDadosAguaGalpao.SelectedIndex = -1

            'Seta Focu
            cboDadosAguaGalpao.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpaDadosAguaCasa()
        Try
            'Limpa Controles
            txtMarcacaoAtualAguaCasa.Value = 0
            txtMarcacaoPrecedenteAguaCasa.Value = 0
            btnInserirAguaCasa.Tag = ""
            cboDadosAguaCasa.SelectedIndex = -1

            'Seta Focu
            cboDadosAguaCasa.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "::: DADOS ESGOTO :::"

    Private Sub ExcluirDadosEsgotoGalpao()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdEsgotoGalpao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboDadosEsgoto()



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

    Private Sub ExcluirDadosEsgotoCasa()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdEsgotoCasa) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboDadosEsgoto()



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

    Private Sub InserirDadosEsgotoGalpao()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - GalpãoCasa
            If ValidaCampo(cboDadosEsgotoGalpao, lblDadosEsgotoGalpao) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirEsgotoGalpao.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertReciboDadosEsgotoGalpao(btnSalvar.Tag, _
                                                            IIf(cboDadosEsgotoGalpao.SelectedIndex = -1, -1, cboDadosEsgotoGalpao.SelectedValue), _
                                                            txtConsumoEsgoto.Value, _
                                                            txtTotalDevidoEsgoto.Value, _
                                                            txtAte10Esgoto.Value, _
                                                            txtAte20Esgoto.Value, _
                                                            txtAte50Esgoto.Value, _
                                                            txtAcima50Esgoto.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateReciboDadosEsgotoGalpao(btnInserirEsgotoGalpao.Tag, _
                                                             btnSalvar.Tag, _
                                                             IIf(cboDadosEsgotoGalpao.SelectedIndex = -1, -1, cboDadosEsgotoGalpao.SelectedValue), _
                                                             txtConsumoEsgoto.Value, _
                                                             txtTotalDevidoEsgoto.Value, _
                                                             txtAte10Esgoto.Value, _
                                                             txtAte20Esgoto.Value, _
                                                             txtAte50Esgoto.Value, _
                                                             txtAcima50Esgoto.Value)

            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEsgotoGalpao(grdEsgotoGalpao, _
                                                     btnSalvar.Tag)
            'Limpa Controle
            LimpaDadosEsgotoGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub InserirDadosEsgotoCasa()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDadosEsgotoCasa, lblDadosEsgotoCasa) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirEsgotoCasa.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertReciboDadosEsgotoCasa(btnSalvar.Tag, _
                                                            IIf(cboDadosEsgotoCasa.SelectedIndex = -1, -1, cboDadosEsgotoCasa.SelectedValue), _
                                                            txtConsumoEsgotoCasa.Value, _
                                                            txtTotalDevidoEsgotoCasa.Value, _
                                                            txtAte10EsgotoCasa.Value, _
                                                            txtAte20EsgotoCasa.Value, _
                                                            txtAte50EsgotoCasa.Value, _
                                                            txtAcima50EsgotoCasa.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateReciboDadosEsgotoCasa(btnInserirEsgotoCasa.Tag, _
                                                             btnSalvar.Tag, _
                                                             IIf(cboDadosEsgotoCasa.SelectedIndex = -1, -1, cboDadosEsgotoCasa.SelectedValue), _
                                                             txtConsumoEsgotoCasa.Value, _
                                                             txtTotalDevidoEsgotoCasa.Value, _
                                                             txtAte10EsgotoCasa.Value, _
                                                             txtAte20EsgotoCasa.Value, _
                                                             txtAte50EsgotoCasa.Value, _
                                                             txtAcima50EsgotoCasa.Value)

            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEsgotoCasa(grdEsgotoCasa, _
                                                     btnSalvar.Tag)
            'Limpa Controle
            LimpaDadosEsgotoCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarDadosEsgotoGalpao()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosEsgotoGalpao.SelectedIndex = -1

                'Carrega Controles
                With grdEsgotoGalpao.CurrentRow
                    oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10AguaCasa, _
                                                       txtAte20AguaCasa, _
                                                       txtAte50AguaCasa, _
                                                       txtAcima50AguaCasa, _
                                                       txtRateioAguaCasa, _
                                                       txtTaxaAnaliseAguaCasa, _
                                                       txtAte10EsgotoCasa, _
                                                       txtAte20EsgotoCasa, _
                                                       txtAte50EsgotoCasa, _
                                                       txtAcima50EsgotoCasa)
                    cboDadosEsgotoGalpao.SelectedValue = .Cells("codigo_galpao").Value
                    txtConsumoEsgoto.Value = IIf(IsDBNull(.Cells("consumo_esgoto").Value), 0, .Cells("consumo_esgoto").Value)
                    txtTotalDevidoEsgoto.Value = IIf(IsDBNull(.Cells("total_devido_esgoto").Value), 0, .Cells("total_devido_esgoto").Value)
                    txtAte10Esgoto.Value = IIf(IsDBNull(.Cells("valor_ate_10").Value), txtAte10Esgoto.Value, .Cells("valor_ate_10").Value)
                    txtAte20Esgoto.Value = IIf(IsDBNull(.Cells("valor_ate_20").Value), txtAte20Esgoto.Value, .Cells("valor_ate_20").Value)
                    txtAte50Esgoto.Value = IIf(IsDBNull(.Cells("valor_ate_50").Value), txtAte50Esgoto.Value, .Cells("valor_ate_50").Value)
                    txtAcima50Esgoto.Value = IIf(IsDBNull(.Cells("valor_acima_50").Value), txtAcima50Esgoto.Value, .Cells("valor_acima_50").Value)
                    btnInserirEsgotoGalpao.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDadosEsgotoGalpao.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarDadosEsgotoCasa()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDadosEsgotoCasa.SelectedIndex = -1

                'Carrega Controles
                With grdEsgotoCasa.CurrentRow
                    oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10AguaCasa, _
                                                       txtAte20AguaCasa, _
                                                       txtAte50AguaCasa, _
                                                       txtAcima50AguaCasa, _
                                                       txtRateioAguaCasa, _
                                                       txtTaxaAnaliseAguaCasa, _
                                                       txtAte10EsgotoCasa, _
                                                       txtAte20EsgotoCasa, _
                                                       txtAte50EsgotoCasa, _
                                                       txtAcima50EsgotoCasa)
                    cboDadosEsgotoCasa.SelectedValue = .Cells("codigo_casa").Value
                    txtConsumoEsgotoCasa.Value = IIf(IsDBNull(.Cells("consumo_esgoto").Value), 0, .Cells("consumo_esgoto").Value)
                    txtTotalDevidoEsgotoCasa.Value = IIf(IsDBNull(.Cells("total_devido_esgoto").Value), 0, .Cells("total_devido_esgoto").Value)
                    txtAte10EsgotoCasa.Value = IIf(IsDBNull(.Cells("valor_ate_10").Value), txtAte10EsgotoCasa.Value, .Cells("valor_ate_10").Value)
                    txtAte20EsgotoCasa.Value = IIf(IsDBNull(.Cells("valor_ate_20").Value), txtAte20EsgotoCasa.Value, .Cells("valor_ate_20").Value)
                    txtAte50EsgotoCasa.Value = IIf(IsDBNull(.Cells("valor_ate_50").Value), txtAte50EsgotoCasa.Value, .Cells("valor_ate_50").Value)
                    txtAcima50EsgotoCasa.Value = IIf(IsDBNull(.Cells("valor_acima_50").Value), txtAcima50EsgotoCasa.Value, .Cells("valor_acima_50").Value)
                    btnInserirEsgotoCasa.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDadosEsgotoGalpao.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpaDadosEsgotoGalpao()
        Try
            'Limpa Controles
            txtConsumoEsgoto.Value = 0
            btnInserirEsgotoGalpao.Tag = ""
            cboDadosEsgotoGalpao.SelectedIndex = -1

            'Seta Focu
            cboDadosEsgotoGalpao.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpaDadosEsgotoCasa()
        Try
            'Limpa Controles
            txtConsumoEsgotoCasa.Value = 0
            btnInserirEsgotoCasa.Tag = ""
            cboDadosEsgotoCasa.SelectedIndex = -1

            'Seta Focu
            cboDadosEsgotoCasa.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: OUTRAS COBRANÇAS :::"

    Private Sub ExcluirDadosOutrasCobrancas()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdOutrasCobrancas) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteOutrasCobrancas()

                    'Carrega Grid
                    oClsFinReciboLocacao.LoadDadosOutrasCobrancas(grdOutrasCobrancas, _
                                                                  btnSalvar.Tag)

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

    Private Sub InserirDadosOutrasCobrancas()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboOutrasCobrancas, lblDescricaoOutrasCobrancas) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirCobranca.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertOutrasCobrancas(btnSalvar.Tag, _
                                                           cboOutrasCobrancas.SelectedValue, _
                                                           cboOutrasCobrancas.Text.ToString, _
                                                           txtValorOutrasCobrancas.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateOutrasCobrancas(btnInserirCobranca.Tag, _
                                                           btnSalvar.Tag, _
                                                           cboOutrasCobrancas.SelectedValue, _
                                                           cboOutrasCobrancas.Text.ToString, _
                                                           txtValorOutrasCobrancas.Value)

            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadDadosOutrasCobrancas(grdOutrasCobrancas, _
                                                          btnSalvar.Tag)

            'Limpa Controles
            btnInserirCobranca.Tag = ""
            cboOutrasCobrancas.SelectedIndex = -1
            txtValorOutrasCobrancas.Value = 0
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarDadosOutrasCobrancas()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboOutrasCobrancas.SelectedIndex = -1

                'Carrega Controles
                With grdOutrasCobrancas.CurrentRow

                    cboOutrasCobrancas.SelectedValue = .Cells("codigo_outras_cobrancas").Value
                    txtValorOutrasCobrancas.Value = .Cells("valor_outras_cobrancas").Value
                    btnInserirCobranca.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboOutrasCobrancas.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region

#Region "::: DESCONTO :::"

    Private Sub ExcluirDadosDescontos()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdDesconto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteDescontos()

                    'Carrega Grid
                    oClsFinReciboLocacao.LoadDadosDescontos(grdDesconto, _
                                                            btnSalvar.Tag)

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

    Private Sub InserirDadosDescontos()
        Try

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(cboDescontos, lblDescricaoDesconto) = False Then
                Exit Sub
            End If

            If IsNumeric(btnInserirDesconto.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertDescontos(btnSalvar.Tag, _
                                                     cboDescontos.SelectedValue, _
                                                     cboDescontos.Text.ToString, _
                                                     txtValorDesconto.Value)


            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateDescontos(btnInserirDesconto.Tag, _
                                                     btnSalvar.Tag, _
                                                     cboDescontos.SelectedValue, _
                                                     cboDescontos.Text.ToString, _
                                                     txtValorDesconto.Value)

            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadDadosDescontos(grdDesconto, _
                                                    btnSalvar.Tag)

            'Limpa Controles
            btnInserirDesconto.Tag = ""
            cboDescontos.SelectedIndex = -1
            txtValorDesconto.Value = 0

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarDadosDescontos()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                cboDescontos.SelectedIndex = -1

                'Carrega Controles
                With grdDesconto.CurrentRow

                    cboDescontos.SelectedValue = .Cells("codigo_desconto").Value
                    txtValorDesconto.Value = .Cells("valor_desconto").Value
                    btnInserirDesconto.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDescontos.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: DADOS VENCIMENTO :::"

    Private Sub ExcluirDadosVencimento()
        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdVencimento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFinReciboLocacao.DeleteReciboVencimento()

                    'Carrega Grid
                    oClsFinReciboLocacao.LoadGridVencimento(grdVencimento, _
                                                             btnSalvar.Tag)

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

    Private Sub InserirDadosVencimento()
        Try

            Dim sFormula As String = ""
            'Formula
            If cboVencimentoFormula.SelectionLength > 0 Then
                For i = 0 To UBound(cboVencimentoFormula.CheckedValues)
                    sFormula &= IIf(sFormula = "", "", ",") & cboVencimentoFormula.CheckedValues(i).ToString
                Next
            End If

            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida Formulário
                If Validacao() = True Then

                    'Salva Dados do Registro
                    Call Salvar()

                End If
            End If

            'Verifica se foi Preenchido o Campo - Galpão
            If ValidaCampo(txtVencimentoValor, lblVencimentoValor, TipoCampo.numero) = False Then
                Exit Sub
            End If

            If IsNumeric(btnVencimentoInserir.Tag) = False Then
                'Insere Dados
                oClsFinReciboLocacao.InsertReciboVencimento(btnSalvar.Tag, _
                                                            txtVencimentoDescricao.Text.ToString, _
                                                            IIf(dtpVencimentoDataVencimento.Checked = False, Now.Date, dtpVencimentoDataVencimento.Value), _
                                                            sFormula, _
                                                            txtValorDesconto.Value, _
                                                            txtVencimentoValor.Value)




            Else
                'Atualiza Dados
                oClsFinReciboLocacao.UpdateReciboVencimento(btnVencimentoInserir.Tag, _
                                                            btnSalvar.Tag, _
                                                            txtVencimentoDescricao.Text.ToString, _
                                                            IIf(dtpVencimentoDataVencimento.Checked = False, Now.Date, dtpVencimentoDataVencimento.Value), _
                                                            sFormula, _
                                                            txtValorDesconto.Value, _
                                                            txtVencimentoValor.Value)
            End If

            'Carrega Grid
            oClsFinReciboLocacao.LoadGridVencimento(grdVencimento, _
                                                     btnSalvar.Tag)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub EditarDadosVencimento()
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReciboLocacao, gcUpdate) = True Then

                'Limpa Controles
                txtVencimentoDescricao.Text = "A PAGAR ATÉ:"
                dtpVencimentoDataVencimento.Value = Now.Date
                cboVencimentoFormula.UncheckAll()
                txtVencimentoDesconto.Value = 0
                txtVencimentoValor.Value = 0


                'Carrega Controles
                With grdVencimento.CurrentRow


                    txtVencimentoDescricao.Text = .Cells("descricao").Value
                    dtpVencimentoDataVencimento.Value = .Cells("data_vencimento").Value
                    txtVencimentoDesconto.Value = .Cells("desconto").Value
                    txtVencimentoValor.Value = .Cells("valor").Value
                    btnVencimentoInserir.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                txtVencimentoDescricao.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

    Private Sub grpTituloPrevisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpTituloPrevisto.Click

    End Sub

    Private Sub btnInserirGalpao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirGalpao.Click
        Try
            Call InserirGalpao()
            Call LimpaDadosGalpao()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub UiButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton5.Click
        Try
            Call ExcluirCasa()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarAcordo.Click
        Try
            ''Váriaveis Locais
            'Dim oForm As New frmFinImportarAcordoComercial

            ''Seta Parâmetros
            'oForm.Dock = DockStyle.Fill

            ''Abre Formulário
            'Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Call Editar(oForm.CodigoRecibo)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirGalpao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirGalpao.Click
        Try
            Call ExcluirGalpao()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirSala.Click
        Try
            Call InserirSala()
            Call LimpaDadosSala()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirSala.Click
        Try
            Call ExcluirSala()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirBox.Click
        Try
            Call InserirBox()
            Call LimpaDadosBox()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirBox.Click
        Try
            Call ExcluirBox()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirCasa.Click
        Try
            Call InserirCasa()
            Call LimpaDadosCasa()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdGalpao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdGalpao.RowDoubleClick
        Try
            'Verifica a Linha
            If IsNothing(grdGalpao.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdGalpao.CurrentColumn.Key

                Case "editar" : Call EditarGalpao()

            End Select
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdBox_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdBox.RowDoubleClick
        Try
            'Verifica a Linha
            If IsNothing(grdBox.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdBox.CurrentColumn.Key

                Case "editar" : Call EditarBox()

            End Select
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdSalaComercial_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdSalaComercial.RowDoubleClick
        Try
            'Verifica a Linha
            If IsNothing(grdSalaComercial.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdSalaComercial.CurrentColumn.Key

                Case "editar" : Call EditarSala()

            End Select
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdCasa_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCasa.RowDoubleClick
        Try
            'Verifica a Linha
            If IsNothing(grdCasa.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdCasa.CurrentColumn.Key

                Case "editar" : Call EditarCasa()

            End Select
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosAreaGalpao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDadosAreaGalpao.SelectedIndexChanged
        Try
            If cboDadosAreaGalpao.SelectedIndex = -1 Then Exit Sub

            oClsFinReciboLocacao.LoadDadosGalpao(cboDadosAreaGalpao.SelectedValue, _
                                                 txtAreaConstruidaLocadaGalpao, _
                                                 txtAreaPatioLocadaGalpao, _
                                                 txtValorAluguelGalpao, _
                                                 dtpDataInicioVigenciaContratoGalpao, _
                                                 dtpDataTerminoVigenciaContratoGalpao)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboCasa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCasa.SelectedIndexChanged
        Try
            If cboCasa.SelectedIndex = -1 Then Exit Sub

            oClsFinReciboLocacao.LoadDadosCasa(cboCasa.SelectedValue, _
                                               txtAreaConstruidaLocadaCasa, _
                                               txtAreaTerrenoLocadaCasa, _
                                               txtValorAluguelCasa, _
                                               dtpDataInicioVigenciaContratoCasa, _
                                               dtpDataTerminoVigenciaContratoCasa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboSala_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSala.SelectedIndexChanged
        Try
            If cboSala.SelectedIndex = -1 Then Exit Sub

            oClsFinReciboLocacao.LoadDadosSala(cboSala.SelectedValue, _
                                               txtAreaConstruidaLocadaSala, _
                                               txtAreaTerrenoLocadaSala, _
                                               txtValorAluguelSala, _
                                               dtpDataInicioVigenciaContratoSala, _
                                               dtpDataTerminoVigenciaContratoSala)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBox.SelectedIndexChanged
        Try
            If cboBox.SelectedIndex = -1 Then Exit Sub

            oClsFinReciboLocacao.LoadDadosBox(cboBox.SelectedValue, _
                                              txtAreaConstruidaLocadaBox, _
                                              txtAreaTerrenoLocadaBox, _
                                              txtValorAluguelBox, _
                                              dtpDataInicioVigenciaContratoBox, _
                                              dtpDataTerminoVigenciaContratoBox)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirEnergiaCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEnergiaCasa.Click
        Try

            'Exclui 
            Call InserirDadosEnergiaCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirEnergiaCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEnergiaCasa.Click
        Try

            'Exclui 
            Call ExcluirDadosEnergiaCasa()
            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEnergiaCasa(grdCasaEnergia, _
                                                      btnSalvar.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdCasaEnergia_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCasaEnergia.RowDoubleClick
        Try

            'Editar
            Call EditarDadosEnergiaCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosAguaCasa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDadosAguaCasa.SelectedIndexChanged
        Try
            If cboDadosAguaCasa.SelectedIndex = -1 Then

                'Limpa Controles
                dtpDataLeituraAtualAguaCasa.Value = Now.Date
                txtMarcacaoAtualAguaCasa.Value = 0
                dtpDataLeituraPrecedenteAguaCasa.Value = Now.Date
                txtMarcacaoPrecedenteAguaCasa.Value = 0
                txtConsumoAguaCasa.Value = 0
                txtTotalDevidoAguaCasa.Value = 0
                txtAte10AguaCasa.Value = 0
                txtAte20AguaCasa.Value = 0
                txtAte50AguaCasa.Value = 0
                txtAcima50AguaCasa.Value = 0
                btnInserirAguaCasa.Tag = ""


            Else

                'Carrega Dados Rateio Consumo Agua
                oClsFinReciboLocacao.LoadDadosCasa(IIf(cboDadosAguaCasa.SelectedIndex = -1, -1, cboDadosAguaCasa.SelectedValue), _
                                                     btnExcluirAguaCasa.Tag)

                'Carrega Dados da Tabela de Leitura Agua e Esgoto
                oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10AguaCasa, _
                                                       txtAte20AguaCasa, _
                                                       txtAte50AguaCasa, _
                                                       txtAcima50AguaCasa, _
                                                       txtRateioAguaCasa, _
                                                       txtTaxaAnaliseAguaCasa, _
                                                       txtAte10EsgotoCasa, _
                                                       txtAte20EsgotoCasa, _
                                                       txtAte50EsgotoCasa, _
                                                       txtAcima50EsgotoCasa)
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdAguaCasa_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAguaCasa.RowDoubleClick
        Try

            'Editar
            Call EditarDadosAguaCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdEsgotoCasa_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEsgotoCasa.RowDoubleClick
        Try

            'Editar
            Call EditarDadosEsgotoCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirAguaCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAguaCasa.Click
        Try

            'Exclui 
            Call InserirDadosAguaCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirAguaCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAguaCasa.Click
        Try

            'Exclui 
            Call ExcluirDadosAguaCasa()
            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosAguaCasa(grdAguaCasa, _
                                                   btnSalvar.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirEsgotoCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEsgotoCasa.Click
        Try

            'Exclui 
            Call InserirDadosEsgotoCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirEsgotoCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEsgotoCasa.Click
        Try

            'Exclui 
            Call ExcluirDadosEsgotoCasa()
            'Carrega Grid
            oClsFinReciboLocacao.LoadGridDadosEsgotoCasa(grdEsgotoCasa, _
                                                     btnSalvar.Tag)
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosEnergiaCasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosEnergiaCasa.SelectedIndexChanged
        Try
            If cboDadosEnergiaCasa.SelectedIndex = -1 Then

                'Limpa Controles
                dtpDataLeituraAtualEnergiaEletricaCasa.Value = Now.Date
                txtMarcacaoAtualEnergiaCasa.Value = 0
                dtpDataLeituraPrecedenteEnergiaEletricaCasa.Value = Now.Date
                txtMarcacaoPrecedenteEnergiaEletricaCasa.Value = 0
                txtConsumoEnergiaEletricaCasa.Value = 0
                txtPrecoMedioEnergiaEletricaCasa.Value = 0
                txtTotalDevidoEnergiaEletricaCasa.Value = 0
                txtReferenciaContaEnergiaEletricaCasa.Text = ""
                btnInserirEnergiaCasa.Tag = ""
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosEsgotoCasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosEsgotoCasa.SelectedIndexChanged
        Try
            If cboDadosEsgotoCasa.SelectedIndex = -1 Then

                'Limpa Controles
                txtConsumoEsgotoCasa.Value = 0
                txtTotalDevidoEsgotoCasa.Value = 0
                txtAte10EsgotoCasa.Value = 0
                txtAte20EsgotoCasa.Value = 0
                txtAte50EsgotoCasa.Value = 0
                txtAcima50EsgotoCasa.Value = 0
                btnInserirEsgotoCasa.Tag = ""


            Else


                'Carrega Dados da Tabela de Leitura Agua e Esgoto
                oClsFinReciboLocacao.LoadTabelaLeitura(txtAte10AguaCasa, _
                                                       txtAte20AguaCasa, _
                                                       txtAte50AguaCasa, _
                                                       txtAcima50AguaCasa, _
                                                       txtRateioAguaCasa, _
                                                       txtTaxaAnaliseAguaCasa, _
                                                       txtAte10EsgotoCasa, _
                                                       txtAte20EsgotoCasa, _
                                                       txtAte50EsgotoCasa, _
                                                       txtAcima50EsgotoCasa)
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnDadosAreaCadastrarSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDadosAreaCadastrarSala.Click
        Try

            If ValidaCampo(cboCliente, lblCliente) = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrCadSala"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                oForm.Titulo = Me.Parent.Text
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Combo - Galpão
                Call LoadCombo(cboSala, "sp_select_combo_cadastro_basico_cliente_sala " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)


                'Seta Focu
                cboSala.Focus()

            Else

                Exit Sub

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnDadosAreaCadastrarBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDadosAreaCadastrarBox.Click
        Try

            If ValidaCampo(cboCliente, lblCliente) = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrCadBox"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                oForm.Titulo = Me.Parent.Text
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Combo - Galpão
                Call LoadCombo(cboBox, "sp_select_combo_cadastro_basico_cliente_box " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)


                'Seta Focu
                cboBox.Focus()

            Else

                Exit Sub

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnDadosAreaCadastrarCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDadosAreaCadastrarCasa.Click, _
                                                                                                                    btnDadosEnergiaCadastrarCasa.Click, _
                                                                                                                    btnDadosAguaCadastrarCasa.Click, _
                                                                                                                    btnDadosEsgotoCadastrarCasa.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadCasa"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo - Galpão
            Dim oComboBox(3) As UIComboBox
            oComboBox(0) = cboCasa : oComboBox(1) = cboDadosEnergiaCasa : oComboBox(2) = cboDadosAguaCasa : oComboBox(3) = cboDadosEsgotoCasa
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cliente_casa " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)

            'Seta Focu
            Select Case sender.Name
                Case "btnDadosAreaCadastrarCasa" : cboCasa.Focus()
                Case "btnDadosEnergiaCadastrarCasa" : cboDadosEnergiaCasa.Focus()
                Case "btnDadosAguaCadastrarCasa" : cboDadosAguaCasa.Focus()
                Case "btnDadosEsgotoCadastrarCasa" : cboDadosEsgotoCasa.Focus()
            End Select


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
