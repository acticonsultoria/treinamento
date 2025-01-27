Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinReceitaFaturamentoDevolucao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaFaturamentoDevolucao As New clsUsrFinReceitaFaturamentoDevolucao

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinReceitaFaturamentoDevolucao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)
                   
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFinReceitaFaturamentoDevolucao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

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
            oForm.NomeFormulario = Formulario.FinanceiroReceitaFaturamentoDevolucao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaFaturamentoDevolucao)

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

    Private Sub btnProcurarClienteFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oMaskedEditBoxFind = txtParceiroNegocioFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtParceiroNegocioFiltro.Focus()

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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 3
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

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

                Case "cancelar_titulo" : Call CancelarTitulo()
                Case "gerar_credito" : Call GerarCreditoTitulo()
                Case "atualizar_saldo" : Call AtualizarTitulo()

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
                                     Formulario.FinanceiroReceitaFaturamentoDevolucao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReceitaFaturamentoDevolucao, _
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
                                          Formulario.FinanceiroReceitaFaturamentoDevolucao, _
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

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaFaturamentoDevolucao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaFaturamentoDevolucao, gcPrint)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataDevolucaoInicioFiltro.Value = Now.Date : dtpDataDevolucaoInicioFiltro.Checked = False
            dtpDataDevolucaoTerminoFiltro.Value = Now.Date : dtpDataDevolucaoTerminoFiltro.Checked = False

            'Carrega Combo - Colunas
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaFaturamentoDevolucao)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            Call oClsFinReceitaFaturamentoDevolucao.LoadGrid(grdListagem, _
                                                             IIf(IsNumeric(txtNotaFiscalFiltro.Text), txtNotaFiscalFiltro.Text, -1), _
                                                             txtSerieFiltro.Text.Trim, _
                                                             IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                             IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                             txtParceiroNegocioFiltro.Text.Trim, _
                                                             IIf(IsNumeric(txtNotaFiscalDevolucaoFiltro.Text), txtNotaFiscalDevolucaoFiltro.Text, -1), _
                                                             IIf(dtpDataDevolucaoInicioFiltro.Checked = False, "", dtpDataDevolucaoInicioFiltro.Value), _
                                                             IIf(dtpDataDevolucaoTerminoFiltro.Checked = False, "", dtpDataDevolucaoTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarTitulo()

        Try

            'Verifica se o Usuário tem Direito de Cancelar o Título
            If VerificaDireito(Formulario.FinanceiroReceitaFaturamentoDevolucao, gcInsert) = False Then
                frmMain.Informacao(Mensagem.DireitoInserir)
                Exit Sub
            End If

            'Verifica se o Valor Pago é igual a 0
            If grdListagem.CurrentRow.Cells("valor_pago").Value <> 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Título possui parcelas já quitadas.")
                Exit Sub
            End If

            'Verifica se o Valor Devolvido é igual o Valor Emitido
            If grdListagem.CurrentRow.Cells("saldo").Value <> 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Valor Devolvido é diferente do Valor Faturado.")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Cancelar o Título
            If MsgBox("Deseja Cancelar o Título Financeiro referente a Nota Fiscal: " & grdListagem.CurrentRow.Cells("nota_fiscal").Value & "/" & grdListagem.CurrentRow.Cells("serie").Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'Cancela o Título
                Call oClsFinReceitaFaturamentoDevolucao.CancelaTitulo(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value, _
                                                                      "TÍTULO CANCELADO DEVIDO DEVOLUÇÃO DA MERCADORIA MEDIANTE NOTA FISCAL: " & grdListagem.CurrentRow.Cells("nota_fiscal_devolucao").Value & " NA DATA: " & grdListagem.CurrentRow.Cells("data_emissao_devolucao").Value & ".")


                'Carrega Grid
                Call LoadGrid()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarTitulo()

        Try

            'Verifica se o Usuário tem Direito de Cancelar o Título
            If VerificaDireito(Formulario.FinanceiroReceitaFaturamentoDevolucao, gcInsert) = False Then
                frmMain.Informacao(Mensagem.DireitoInserir)
                Exit Sub
            End If

            'Verifica se o Valor Pago é < que o Saldo
            If grdListagem.CurrentRow.Cells("valor_devolvido").Value > (grdListagem.CurrentRow.Cells("valor").Value - grdListagem.CurrentRow.Cells("valor_pago").Value) Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Título possui Saldo a Receber menor que o Valor Recebido.")
                Exit Sub
            End If

            'Verifica se o Valor Devolvido < Valor Faturado
            If grdListagem.CurrentRow.Cells("valor_devolvido").Value > grdListagem.CurrentRow.Cells("valor").Value Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Valor Devolvido é maior que o Valor Faturado.")
                Exit Sub
            End If

            'Váriavel - Formulário
            Dim oForm As New frmFinEditarDuplicatas
            'Seta Váriaveis
            oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
            oForm.Valor = grdListagem.CurrentRow.Cells("valor_devolvido").Value
            'Abre Formulário
            oForm.ShowDialog()

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarCreditoTitulo()

        Try

            'Verifica se o Usuário tem Direito de Cancelar o Título
            If VerificaDireito(Formulario.FinanceiroReceitaFaturamentoDevolucao, gcInsert) = False Then
                frmMain.Informacao(Mensagem.DireitoInserir)
                Exit Sub
            End If

            'Verifica o Status
            If grdListagem.CurrentRow.Cells("saldo_corrigir").Value <= 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Saldo a Corrigir precisa ser maior que ""0"" Zero.")
                Exit Sub
            End If

            'Váriavies - Formulário
            Dim oForm As New frmFinReceitaFaturamentoDevolucaoParcela
            oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("nota_fiscal_devolucao").Value
            oForm.DataEmissao = grdListagem.CurrentRow.Cells("data_emissao_devolucao").Value
            oForm.Descritivo = "CRÉDITO REFERENTE A NOTA FISCAL DE DEVOLUÇÃO: " & grdListagem.CurrentRow.Cells("nota_fiscal_devolucao").Value & "."
            oForm.Valor = System.Math.Abs(grdListagem.CurrentRow.Cells("saldo_corrigir").Value)
            oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class

