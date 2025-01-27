Public Class usrCmpContrato

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCmpContrato As New clsUsrCmpContrato

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFinTituloRecorrente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrFinTituloRecorrente_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFinTituloRecorrente_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ComprasPedidoContrato
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoContrato)

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

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True
            End If

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
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboParceiroNegocio.Focus()

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
            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComprasPedidoContrato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "cancelar" : Call Cancelar()
                Case "historico" : HistoricoContrato()

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
                                     Formulario.ComprasPedidoContrato, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinTituloRecorrente_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ComprasPedidoContrato, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.ComprasPedidoContrato, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.ComprasPedidoContrato, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasPedidoContrato, gcPrint)

            'Seta Controle
            dtpDataInicio.Value = Now.Date : dtpDataInicio.Checked = False
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataInicioTerminoFiltro.Value = Now.Date : dtpDataInicioTerminoFiltro.Checked = False
            dtpDataTermino.Value = Now.Date : dtpDataTermino.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False
            dtpDataTerminoInicioFiltro.Value = Now.Date : dtpDataTerminoInicioFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoContrato)
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboSimNao(cboAtivoFiltro)
            Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa & DBNull.Value & DBNull.Value)
            Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoContrato, "sp_select_combo_compras_pedido_tipo_contrato", False)
            Call LoadCombo(cboTipoContratoFiltro, "sp_select_combo_compras_pedido_tipo_contrato", False)

            btnExcluir.Visible = False

            'Carrega ComboBox
            cboTipoTituloFiltro.Items.Add("RECEITA", "R")
            cboTipoTituloFiltro.Items.Add("DESPESA", "D")

            cboTipoTitulo.Items.Add("RECEITA", "R")
            cboTipoTitulo.Items.Add("DESPESA", "D")

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtParceiroNegocioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub HistoricoContrato()

        Try

            'Váriaveis Locais
            Dim oForm As New frmCmpContratoHistorico

            'Seta Tamanho / Posição do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Parametros
            oForm.Codigo = grdListagem.GetValue("codigo_pedido")

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ComprasPedidoContrato, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtDescritivo.Text = .Item("descritivo").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    cboParceiroNegocio.SelectedValue = .Item("codigo_parceiro_negocio").Value
                    cboTipoTitulo.SelectedValue = .Item("tipo_titulo_contrato").Value
                    dtpDataInicio.Value = .Item("data_inicio").Value
                    txtDiaVencimento.Value = .Item("dia_vencimento").Value
                    txtValorMensal.Value = .Item("valor").Value
                    btnSalvar.Tag = .Item("codigo_pedido").Value
                    txtNumeroContrato.Text = .Item("numero_contrato").Value
                    txtTolerancia.Value = .Item("tolerancia").Value

                    If IsDBNull(.Item("codigo_tipo_contrato").Value) Then
                        cboTipoContrato.SelectedIndex = -1
                    Else
                        cboTipoContrato.SelectedValue = .Item("codigo_tipo_contrato").Value
                    End If

                    If IsDBNull(.Item("codigo_centro_custo").Value) Then
                        cboCentroCusto.SelectedIndex = -1
                    Else
                        cboCentroCusto.SelectedValue = .Item("codigo_centro_custo").Value
                    End If

                    If IsDBNull(.Item("data_termino").Value) Then

                        dtpDataTermino.Checked = False
                        dtpDataTermino.Value = Now.Date

                    Else

                        dtpDataTermino.Checked = True
                        dtpDataTermino.Value = .Item("data_termino").Value

                    End If

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtDescritivo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            If MsgBox("Deseja Cancelar o Contrato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Aprova Pedido
                Call oClsUsrCmpContrato.CancelarContrato(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega Grid
                Call LoadGrid()

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

                    'Exclui Registro
                    'oClsUsrFinTituloRecorrente.Delete()

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
            txtDescritivo.Text = ""
            txtNumeroContrato.Text = ""
            cboAtivo.SelectedValue = True
            cboParceiroNegocio.SelectedIndex = -1
            cboCentroCusto.SelectedIndex = -1
            dtpDataInicio.Value = Now.Date
            dtpDataTermino.Value = Now.Date
            dtpDataTermino.Checked = False
            txtDiaVencimento.Value = 0
            txtValorMensal.Value = 0
            txtTolerancia.Value = 0
            cboTipoTitulo.SelectedIndex = -1
            cboTipoContrato.SelectedIndex = -1
            btnSalvar.Tag = ""

            'Seta Focu
            cboParceiroNegocio.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then

                oClsUsrCmpContrato.Update(btnSalvar.Tag, _
                                          cboParceiroNegocio.SelectedValue, _
                                          dtpDataInicio.Value, _
                                          IIf(dtpDataTermino.Checked = False, "", dtpDataTermino.Value), _
                                          txtDiaVencimento.Value, _
                                          txtValorMensal.Value, _
                                          txtTolerancia.Value, _
                                          IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue), _
                                          cboTipoTitulo.SelectedValue, _
                                          cboAtivo.SelectedValue, _
                                          txtDescritivo.Text.Trim, _
                                          cboTipoContrato.SelectedValue)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCmpContrato.Insert(cboParceiroNegocio.SelectedValue, _
                                          dtpDataInicio.Value, _
                                          IIf(dtpDataTermino.Checked = False, "", dtpDataTermino.Value), _
                                          txtDiaVencimento.Value, _
                                          txtValorMensal.Value, _
                                          txtTolerancia.Value, _
                                          IIf(cboCentroCusto.SelectedIndex = -1, -1, cboCentroCusto.SelectedValue), _
                                          cboTipoTitulo.SelectedValue, _
                                          cboAtivo.SelectedValue, _
                                          txtDescritivo.Text.Trim, _
                                          cboTipoContrato.SelectedValue)

                txtNumeroContrato.Text = oClsUsrCmpContrato.NumeroContrato
                btnSalvar.Tag = oClsUsrCmpContrato.Codigo

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
            oClsUsrCmpContrato.LoadGrid(grdListagem, _
                                        IIf(IsNumeric(txtNumeroContratoFiltro.Text.Trim), txtNumeroContratoFiltro.Text.Trim, -1), _
                                        txtParceiroNegocioFiltro.Text.Trim, _
                                        IIf(cboTipoTituloFiltro.SelectedIndex = -1, "", cboTipoTituloFiltro.SelectedValue), _
                                        IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                        IIf(dtpDataInicioTerminoFiltro.Checked = False, "", dtpDataInicioTerminoFiltro.Value), _
                                        IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                        IIf(dtpDataTerminoInicioFiltro.Checked = False, "", dtpDataTerminoInicioFiltro.Value), _
                                        txtDiaVencimentoFiltro.Text, _
                                        IIf(cboAtivoFiltro.SelectedIndex = -1, -1, cboAtivoFiltro.SelectedValue), _
                                        txtDescricaoFiltro.Text.Trim, _
                                        IIf(cboTipoContratoFiltro.SelectedIndex = -1, -1, cboTipoContratoFiltro.SelectedValue))

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

            If ValidaCampo(txtDescritivo, lblDescritivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboParceiroNegocio, lblParceiroNegocio) = False Then
                Exit Function
            End If

            If ValidaCampo(cboTipoTitulo, lblTipoTituloFinanceiro) = False Then
                Exit Function
            End If

            If ValidaCampo(cboTipoContrato, lblTipoContrato) = False Then
                Exit Function
            End If

            If ValidaCampo(txtDiaVencimento, lblDiaVencimento, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(txtValorMensal, lblValor, TipoCampo.numero) = False Then
                Exit Function
            End If

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


End Class
