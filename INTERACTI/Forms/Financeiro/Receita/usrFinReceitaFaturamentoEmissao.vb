Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinReceitaFaturamentoEmissao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaFaturamentoEmissao As New clsUsrFinReceitaFaturamentoEmissao

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinReceitaFaturamentoEmissao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
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

    Private Sub usrFinReceitaFaturamentoEmissao_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            oForm.NomeFormulario = Formulario.FinanceiroReceitaNotaFiscalEmissao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaNotaFiscalEmissao)

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDespesa)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 1
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

                Case "integrar_financeiro" : Call IntregrarNotaFiscal()

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
                                     Formulario.FinanceiroReceitaNotaFiscalEmissao)

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
                                     Formulario.FinanceiroReceitaNotaFiscalEmissao, _
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
                                          Formulario.FinanceiroReceitaNotaFiscalEmissao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Valida Fatura
            If ValidacaoFatura() = True Then

                'Váriaveis Locais
                Dim oClsIntegracao As New clsIntegracao

                'Verifica o Tipo de Nota Fiscal
                If grdListagem.CurrentRow.Cells("codigo_tipo_nota_fiscal").Value = 3 Then

                    'Salva Nota Fiscal - Fatura (Serviço)
                    Call SalvarFaturaNotaFiscalServico()

                    'Integração
                    Call oClsIntegracao.IntegracaoNFSEmissaoFinanceiro(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value)

                Else

                    'Salva Nota Fiscal - Fatura (Produto)
                    Call SalvarFaturaNotaFiscal()

                    'Integração
                    Call oClsIntegracao.IntegracaoNFEmissaoFinanceiro(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value)

                End If

            End If

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaCobranca_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorOriginal.ValueChanged, _
                                                                                                          txtValorDesconto.ValueChanged

        Try

            'Calcula Valor Líquido
            txtValorLiquido.Value = txtValorOriginal.Value - txtValorDesconto.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCalcularDuplicata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDuplicata.Click

        Try

            'Gera Duplicata
            Call oClsFinReceitaFaturamentoEmissao.GerarDuplicata(grdDuplicata, _
                                                                 txtValorLiquido.Value, _
                                                                 txtNumeroParcela.Value, _
                                                                 txtIntervaloEntreParcelas.Value, _
                                                                 CDate(txtDataEmissao.Text))

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaFaturamentoEmissao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaNotaFiscalEmissao, gcPrint)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataSaidaInicioFiltro.Value = Now.Date : dtpDataSaidaInicioFiltro.Checked = False
            dtpDataSaidaTerminoFiltro.Value = Now.Date : dtpDataSaidaTerminoFiltro.Checked = False

            'Carrega Combo - Tipo de Nota Fiscal
            cboTipoNotaFiscalFiltro.Items.Clear()
            cboTipoNotaFiscalFiltro.Items.Add("NOTA FISCAL", 1)
            cboTipoNotaFiscalFiltro.Items.Add("NOTA FISCAL ELTRÔNICA", 2)
            cboTipoNotaFiscalFiltro.Items.Add("NOTA FISCAL DE SERVIÇO", 3)
            'Carrega Combo - Status
            cboStatusFiltro.Items.Clear()
            cboStatusFiltro.Items.Add("NOTA FISCAL INTEGRADA", 1)
            cboStatusFiltro.Items.Add("NOTA FISCAL NÃO INTEGRADA", 2)
            'Carrega Combo - CFOP
            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            'Carrega Combo - Colunas
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaNotaFiscalEmissao)

            'Seta Aba
            tabMain.TabPages.Remove(pagDespesa)

            'Seta Focu
            cboTipoNotaFiscalFiltro.Focus()

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

            'Váriaveis
            Dim sCodigoCFOP As String = ""

            'CFOP
            For Each oRow As GridEXRow In cboCFOPFiltro.DropDownList.GetCheckedRows
                sCodigoCFOP &= IIf(sCodigoCFOP = "", "", ",") & oRow.Cells("codigo").Value
            Next


            'Carrega Controles
            Call oClsFinReceitaFaturamentoEmissao.LoadGrid(grdListagem, _
                                                           IIf(IsNumeric(txtNotaFiscalFiltro.Text), txtNotaFiscalFiltro.Text, -1), _
                                                           txtSerieFiltro.Text.Trim, _
                                                           txtParceiroNegocioFiltro.Text.Trim, _
                                                           IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                                           IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                           IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                           IIf(dtpDataSaidaInicioFiltro.Checked = False, "", dtpDataSaidaInicioFiltro.Value), _
                                                           IIf(dtpDataSaidaTerminoFiltro.Checked = False, "", dtpDataSaidaTerminoFiltro.Value), _
                                                           IIf(cboTipoNotaFiscalFiltro.SelectedIndex = -1, -1, cboTipoNotaFiscalFiltro.SelectedValue), _
                                                           sCodigoCFOP)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub IntregrarNotaFiscal()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaNotaFiscalEmissao, gcInsert) = True Then

                'Verifica o Status e Desejo do Usuário
                If grdListagem.CurrentRow.Cells("status").Value = 1 AndAlso MsgBox("Esta Nota Fiscal já está associada a uma Despesa. Deseja Continuar?" & vbCrLf & vbCrLf & "Obs.: A Integração se feita novamente irá reabrir possíveis parcelas baixadas.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If

                'Carrega Controles
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value
                txtTipoNotaFiscal.Text = grdListagem.CurrentRow.Cells("tipo_nota_fiscal").Value
                txtNotaFiscal.Text = grdListagem.CurrentRow.Cells("nota_fiscal").Value
                txtSerie.Text = grdListagem.CurrentRow.Cells("serie").Value
                txtDataEmissao.Text = grdListagem.CurrentRow.Cells("data_emissao").Value
                txtDataEntrada.Text = grdListagem.CurrentRow.Cells("data_saida").Value
                txtCliente.Text = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
                txtFatura.Text = ""
                txtValorOriginal.Value = grdListagem.CurrentRow.Cells("valor").Value
                txtValorDesconto.Value = 0
                txtNumeroParcela.Value = 0
                txtIntervaloEntreParcelas.Value = 0
                grdDuplicata.DataSource = Nothing

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDespesa)

                'Seta Focu
                txtFatura.Focus()

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

#Region "::: FATURA :::"

    Private Sub SalvarFaturaNotaFiscal()

        Try

            'Váriavel Local
            Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

            oClsFatEmissaoNFe.CodigoEmissaoCapa = btnSalvar.Tag

            'Deleta Dados da Fatura
            oClsFatEmissaoNFe.DeleteFatura()

            'Seta Parametros
            oClsFatEmissaoNFe.Fatura = txtFatura.Text.Trim
            oClsFatEmissaoNFe.ValorOriginal = txtValorOriginal.Value
            oClsFatEmissaoNFe.ValorDesconto = txtValorDesconto.Value
            oClsFatEmissaoNFe.ValorLiquido = txtValorLiquido.Value
            oClsFatEmissaoNFe.NumeroParcela = txtNumeroParcela.Value
            oClsFatEmissaoNFe.IntervaloParcela = txtIntervaloEntreParcelas.Value

            'Salva Dados Fatura
            oClsFatEmissaoNFe.InsertFatura()
            oClsFatEmissaoNFe.InsertFaturaDuplicata(grdDuplicata)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarFaturaNotaFiscalServico()

        Try

            Dim oClsFatEmissaoNFs As New clsUsrFatEmissaoNFs

            'Seta Váriavel
            oClsFatEmissaoNFs.CodigoEmissaoNFSe = btnSalvar.Tag

            'Deleta Dados da Fatura
            oClsFatEmissaoNFs.DeleteFatura()

            'Seta Parametros
            oClsFatEmissaoNFs.Fatura = txtFatura.Text.Trim
            oClsFatEmissaoNFs.ValorOriginal = txtValorOriginal.Value
            oClsFatEmissaoNFs.ValorDesconto = txtValorDesconto.Value
            oClsFatEmissaoNFs.ValorLiquido = txtValorLiquido.Value
            oClsFatEmissaoNFs.NumeroParcela = txtNumeroParcela.Value
            oClsFatEmissaoNFs.IntervaloParcela = txtIntervaloEntreParcelas.Value

            'Salva Dados Fatura
            oClsFatEmissaoNFs.InsertFatura()
            oClsFatEmissaoNFs.InsertFaturaDuplicata(grdDuplicata)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoFatura() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFatura = False

            'Verifica se foi Gerado Parcelas
            If grdDuplicata.GetDataRows.Count > 0 Then
                If txtValorLiquido.Value <> grdDuplicata.GetTotalRow.Cells("valor").Value Then
                    frmMain.errInfo.SetError(lblValorLiquido, "A Soma dos Valores da Duplicata é diferente do Valor Líquido.")
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoFatura = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class

