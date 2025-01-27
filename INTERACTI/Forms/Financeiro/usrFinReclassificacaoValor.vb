Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinReclassificacaoValor

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReclassificacaoValor As New clsUsrFinReclassificacaoValor
    Private lCodigoTituloCapa As Long

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinReclassificacaoValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrFinReclassificacaoValor_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CAPA :::"

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
            oForm.NomeFormulario = Formulario.FinanceiroReclassificacaoValor
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReclassificacaoValor)

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
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

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
                                     Formulario.FinanceiroReclassificacaoValor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReclassificacaoValor, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FinanceiroReclassificacaoValor, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PAGO :::"

    Private Sub grdPago_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdPago.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdPago.CurrentColumn) Then Exit Sub

            Select Case grdPago.CurrentColumn.Key

                Case "cancelar_pagamento" : Call CancelarPagamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPago.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPago
            oForm.NomeFormulario = Formulario.FinanceiroReclassificacaoValor
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPago, Formulario.FinanceiroReclassificacaoValor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPago.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdPago.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdPago.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdPago.GroupByBoxVisible = True
                grdPago.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridPago_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcelGridPago.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdPago)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: DEVE :::"

    Private Sub btnConfiguraGridDeve_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfiguraGridDeve.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDeve
            oForm.NomeFormulario = Formulario.FinanceiroReclassificacaoValor
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDeve, Formulario.FinanceiroReclassificacaoValor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgrupaGridDeve_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgrupaGridDeve.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdDeve.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdDeve.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdDeve.GroupByBoxVisible = True
                grdDeve.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridDeve_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcelGridDeve.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDeve)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDeve_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDeve.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdDeve.CurrentColumn) Then Exit Sub

            Select Case grdDeve.CurrentColumn.Key

                Case "editar" : Call EditarParcela()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAdicionarParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarParcela.Click
        Try
            Call InserirParcela()
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirParcela.Click
        Try
            Call DeletaParcela()
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: BOLETO :::"

    Private Sub btnConfigurarGridBoleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridBoleto.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdBoleto
            oForm.NomeFormulario = Formulario.FinanceiroReclassificacaoValor
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdBoleto, Formulario.FinanceiroReclassificacaoValor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridBoleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridBoleto.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdBoleto.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdBoleto.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdBoleto.GroupByBoxVisible = True
                grdBoleto.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridBoleto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcelGridBoleto.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdBoleto)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReclassificacaoValor_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluirParcela.Enabled = VerificaDireito(Formulario.FinanceiroReclassificacaoValor, gcDelete)
            btnAdicionarParcela.Enabled = VerificaDireito(Formulario.FinanceiroReclassificacaoValor, gcInsert)

            
            'Carrega Combo - Tipo de Item
            cboTipoTituloFiltro.Items.Add("RECEITA", "R")
            cboTipoTituloFiltro.Items.Add("DESPESA", "D")

            Call LoadCombo(cboTipoDocumentoFiltro, "sp_select_combo_cadastro_basico_tipo_documento " & goUsuario.iEmpresa, False)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReclassificacaoValor)
            Call ConfiguraGrid(grdPago, Formulario.FinanceiroReclassificacaoValor)
            Call ConfiguraGrid(grdDeve, Formulario.FinanceiroReclassificacaoValor)

            If glCodigoEditar <> -1 Then

                Call Editar(glCodigoEditar)

            Else

                'Seta Aba
                tabMain.TabPages.Remove(pagDados)

            End If



            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CAPA :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFinReclassificacaoValor.LoadGrid(grdListagem, _
                                            txtNumeroDocumentoFiltro.Text.Trim, _
                                            txtSerieFiltro.Text.Trim, _
                                            txtParceiroNegocioFiltro.Text.Trim, _
                                            IIf(cboTipoTituloFiltro.SelectedIndex = -1, "", cboTipoTituloFiltro.SelectedValue), _
                                            IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                            IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                            IIf(cboTipoDocumentoFiltro.SelectedIndex = -1, -1, cboTipoDocumentoFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigo As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            lCodigoTituloCapa = lCodigo

            'Verifica se o usuário tem direito de alterar algum registo
            If VerificaDireito(Formulario.FinanceiroReclassificacao, gcUpdate) = True Then

                If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then
                    If goUsuario.iUsuario <> 1 Or goUsuario.iUsuario <> 2 Then
                        frmMain.Informacao(Mensagem.DireitoAlteracao)
                    End If
                End If


                oClsFinReclassificacaoValor.LoadControles(lCodigo, _
                                                          txtNumeroDocumento, _
                                                          txtSerie, _
                                                          txtDataEmissao, _
                                                          txtParceiroNegocio, _
                                                          txtTipoDocumento, _
                                                          txtTipoTitulo)

                If glCodigoEditar = -1 Then

                    oClsFinReclassificacaoValor.LoadGridPago(grdPago, _
                                                             grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                    oClsFinReclassificacaoValor.LoadGridDeve(grdDeve, _
                                                             grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                    oClsFinReclassificacaoValor.LoadGridBoleto(grdBoleto, _
                                                               grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                Else

                    oClsFinReclassificacaoValor.LoadGridPago(grdPago, _
                                                             lCodigo)

                    oClsFinReclassificacaoValor.LoadGridDeve(grdDeve, _
                                                             lCodigo)

                    oClsFinReclassificacaoValor.LoadGridBoleto(grdBoleto, _
                                                               lCodigo)

                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)

                If glCodigoEditar = -1 Then

                    tabMain.TabPages.Add(pagDados)

                End If

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

#Region "::: DEVE :::"

    Private Sub InserirParcela()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnAdicionarParcela.Tag) Then

                    'Altera Registro
                    oClsFinReclassificacaoValor.UpdateParcela(lCodigoTituloCapa, _
                                                              dtpDataVencimento.Value, _
                                                              txtValor.Value, _
                                                              grdDeve.CurrentRow.Cells.Item("numero_parcela").Value)

                Else

                    'Insere Registro
                    oClsFinReclassificacaoValor.InsertParcela(lCodigoTituloCapa, _
                                                              dtpDataVencimento.Value, _
                                                              txtValor.Value)

                End If

                'Carrega Grid
                Call oClsFinReclassificacaoValor.LoadGridDeve(grdDeve, _
                                                              lCodigoTituloCapa)

                Call oClsFinReclassificacaoValor.LoadGridBoleto(grdBoleto, _
                                                                 lCodigoTituloCapa)

               'Altera Registro
                oClsFinReclassificacaoValor.UpdateCapa(lCodigoTituloCapa)

                'Limpa Formulário
                Call NovaParcela()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarParcela()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReclassificacaoValor, gcUpdate) = True Then

                'Carrega Controles
                dtpDataVencimento.Value = grdDeve.CurrentRow.Cells.Item("data").Value
                txtValor.Value = grdDeve.CurrentRow.Cells("valor").Value
                btnAdicionarParcela.Tag = grdDeve.CurrentRow.RowIndex

                'Seta Focu
                dtpDataVencimento.Focus()

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

    Private Sub DeletaParcela()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDeve) = True Then

                If (oClsFinReclassificacaoValor.Validacao(grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value, _
                                                          grdDeve.CurrentRow.Cells.Item("numero_parcela").Value, _
                                                          "") = "E") Then

                    'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                    If MsgBox("Existe um boleto para essa parcela! Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.WaitCursor

                        'Exclui Registro
                        Dim i As Integer

                        For i = 0 To UBound(gSelecaoRow)

                            'Deleta Classificação
                            Call oClsFinReclassificacaoValor.DeleteParcela(grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value, _
                                                                           gSelecaoRow(i).Cells("numero_parcela").Value)
                        Next

                        'Carrega Grid
                        Call oClsFinReclassificacaoValor.LoadGridDeve(grdDeve, _
                                                                      grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.RegistroExcluido)

                        ''Altera Registro
                        'oClsFinReclassificacaoValor.UpdateCapa(grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.Default

                    End If

                ElseIf (oClsFinReclassificacaoValor.Validacao(grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value, _
                                                      grdDeve.CurrentRow.Cells.Item("numero_parcela").Value, _
                                                      "") <> "E") Then

                    'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                    If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.WaitCursor

                        'Exclui Registro
                        Dim i As Integer

                        For i = 0 To UBound(gSelecaoRow)

                            'Deleta Classificação
                            Call oClsFinReclassificacaoValor.DeleteParcela(grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value, _
                                                                           gSelecaoRow(i).Cells("numero_parcela").Value)
                        Next

                        'Carrega Grid
                        Call oClsFinReclassificacaoValor.LoadGridDeve(grdDeve, _
                                                                      grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.RegistroExcluido)

                        ''Altera Registro
                        'oClsFinReclassificacaoValor.UpdateCapa(grdDeve.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.Default

                    End If

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovaParcela()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            dtpDataVencimento.Value = Now.Date
            txtValor.Value = 0
            btnAdicionarParcela.Tag = ""

            'Seta Focu
            dtpDataVencimento.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValor, lblValor, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(dtpDataVencimento, lblDataVencimento) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PAGO :::"
    
    Private Sub CancelarPagamento()

        Try

            'Verifica se a Parcela já está paga
            If grdPago.CurrentRow.Cells("valor_pago").Value > 0 Then

                'Verifica se o usuário tem direito de alterar algum registro
                If VerificaDireito(Formulario.FinanceiroReclassificacaoValor, gcAdministrator) = True Then

                    'Verifica se o Usuário deseja Cancelar o Pagamento
                    If MsgBox("Deseja realmente Cancelar o Pagamento dessa Parcela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Váriavel - Classe
                        Dim oClsFinDespesaCancelarPagamento As New clsUsrFinDespesaCancelarPagamento

                        'Cancela o Pagamento
                        oClsFinDespesaCancelarPagamento.CancelarPagamentoIndividual(grdPago.CurrentRow.Cells("codigo_titulo_capa").Value, _
                                                                                    grdPago.CurrentRow.Cells("numero_parcela").Value)
                        
                        If glCodigoEditar = -1 Then

                            oClsFinReclassificacaoValor.LoadGridPago(grdPago, _
                                                                     grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                            oClsFinReclassificacaoValor.LoadGridDeve(grdDeve, _
                                                                     grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                            oClsFinReclassificacaoValor.LoadGridBoleto(grdBoleto, _
                                                                       grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                        Else

                            oClsFinReclassificacaoValor.LoadGridPago(grdPago, _
                                                                     glCodigoEditar)

                            oClsFinReclassificacaoValor.LoadGridDeve(grdDeve, _
                                                                     glCodigoEditar)

                            oClsFinReclassificacaoValor.LoadGridBoleto(grdBoleto, _
                                                                       glCodigoEditar)

                        End If

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

            Else
                'Informa o Usuário que o Título não foi quitado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region
 
#End Region




    

    

    


End Class

