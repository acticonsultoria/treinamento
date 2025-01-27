Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO

Public Class usrEstBaixaPerda

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstBaixaPerda As New clsUsrEstBaixa

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrEstBaixaPerda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                         Case "cboMarcaFiltro" : Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstBaixaPerda_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: BAIXA PARA PERDA :::"

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
            oForm.NomeFormulario = Formulario.EstoqueBaixaPerda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueBaixaPerda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados
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

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

            'Seta Focu
            cboDeposito.Focus()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Desabilita Controles
                grpDadosInventario.Enabled = False

            End If

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
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Sub
            End If

            'Imprime Inventário
            'Call ImprimirInventario(cboDeposito.SelectedValue, _
            '                        dtpDataInventario.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGridProduto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged, _
                                                                                                    cboDeposito.SelectedIndexChanged, _
                                                                                                    cboMarcaFiltro.SelectedIndexChanged, _
                                                                                                    cboStatus.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboDeposito.SelectedIndex = -1 Then

                'Limpa Grid
                grdProduto.DataSource = Nothing

            Else

                'Carrega Grid
                Call oClsEstBaixaPerda.LoadGridProduto(grdProduto, _
                                                       dtpData.Value, _
                                                       cboDeposito.SelectedValue, _
                                                       IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                                       IIf(cboStatus.SelectedIndex = -1, -1, cboStatus.SelectedValue), _
                                                       -1)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha pressionada
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação Selecionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "aprovar" : Call Aprovar()
                Case "cancelar" : Call Cancelar()
                Case "historico" : Call Historico()
                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo").Value)

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
                                     Formulario.EstoqueBaixaPerda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.EstoqueBaixaPerda, _
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
                                          Formulario.EstoqueBaixaPerda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdProduto.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdProduto.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdProduto.GroupByBoxVisible = True
                grdProduto.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.EstoqueBaixaPerda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.EstoqueBaixaPerda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.EstoqueBaixaPerda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.EstoqueBaixaPerda, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.EstoqueBaixaPerda, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstBaixaPerda_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo1.Enabled = VerificaDireito(Formulario.EstoqueBaixaPerda, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.EstoqueBaixaPerda, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueBaixaPerda, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.EstoqueBaixaPerda, gcPrint)
            btnExcelGridProduto.Enabled = VerificaDireito(Formulario.EstoqueBaixaPerda, gcPrint)

            'Carrega ComboBox
            Call LoadCombo(cboDepositoFiltro, "sp_select_combo_cadastro_basico_deposito_proprio " & goUsuario.iEmpresa)
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_proprio " & goUsuario.iEmpresa)
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)
            'Carrega Combo - Status
            cboStatus.Items.Clear()
            cboStatus.Items.Add("ABAIXO DO PONTO REPOSIÇÃO", 1)
            cboStatus.Items.Add("ACIMA DO PONTO REPOSIÇÃO", 2)
            cboStatus.Items.Add("SALDO IGUAL A ZERO", 3)
            cboStatus.Items.Add("SALDO NEGATIVO", 4)
            cboStatus.Items.Add("SALDO POSITIVO", 5)
            cboStatus.Items.Add("PRODUTO VENCIDO", 6)

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueBaixaPerda)
            Call ConfiguraGrid(grdProduto, Formulario.EstoqueBaixaPerda)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Remove Page
            tabMain.TabPages.Remove(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: BAIXA PARA PERDA :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sStatus As String = ""
            Dim i As Integer

            'Carrega Grid
            Call oClsEstBaixaPerda.LoadGrid(grdListagem, _
                                            txtNumeroDocumentoFiltro.Text.Trim, _
                                            IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                            IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                            IIf(cboDepositoFiltro.SelectedIndex = -1, -1, cboDepositoFiltro.SelectedValue), _
                                            sStatus)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Habilita Controles
            txtNumeroDocumento.Text = ""
            cboDeposito.Text = ""
            cboMarcaFiltro.Text = ""
            cboStatus.Text = ""
            txtObservacao.Text = ""
            grpDadosInventario.Enabled = True
            grdProduto.DataSource = Nothing
            grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueBaixaPerda, gcInsert)
            btnSalvar.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnSalvar.Tag) = False Then

                'Seta Parametros
                oClsEstBaixaPerda.Data = dtpData.Value
                oClsEstBaixaPerda.CodigoDeposito = cboDeposito.SelectedValue
                oClsEstBaixaPerda.Observacao = txtObservacao.Text.Trim

                'Insere Dados da Capa
                oClsEstBaixaPerda.Salvar()
                btnSalvar.Tag = oClsEstBaixaPerda.Codigo
                txtNumeroDocumento.Text = oClsEstBaixaPerda.NumeroDocumento

            Else
                oClsEstBaixaPerda.Codigo = btnSalvar.Tag
            End If

            'Remove Filtro
            Dim oFilter As New GridEXFilterCondition
            oFilter = grdProduto.RootTable.FilterCondition
            grdProduto.RootTable.RemoveFilter()

            'Insere Dados da Linha
            oClsEstBaixaPerda.DeleteProduto(btnSalvar.Tag)
            oClsEstBaixaPerda.SalvarProduto(grdProduto)

            'Aplica Filtro
            grdProduto.RootTable.ApplyFilter(oFilter)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o usuário tem direito
            If VerificaDireito(Formulario.EstoqueBaixaPerda, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtNumeroDocumento.Text = .Item("numero_documento").Value
                    dtpData.Value = .Item("data").Value
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    txtObservacao.Text = .Item("observacao").Value
                    btnSalvar.Tag = .Item("codigo").Value

                    'Carrega Grid de Item
                    Call oClsEstBaixaPerda.LoadGridProduto(grdProduto, _
                                                           dtpData.Value, _
                                                           cboDeposito.SelectedValue, _
                                                           -1, _
                                                           -1, _
                                                           btnSalvar.Tag)

                    'Desabilita Controles
                    If .Item("status").Value = CInt(StatusBaixaPerda.AguardandoAprovacao) Then
                        btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueBaixaPerda, gcUpdate)
                        grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
                    Else
                        btnSalvar.Enabled = False
                        grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                    End If
                    grpDadosInventario.Enabled = False

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                btnVoltar.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir(ByVal lCodigoBaixaPerda As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "BAIXA PERDA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Carrega Váriavel
            sReport &= ".rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_baixa_perda"
            goCrystalReport.sReportParameter(1).sValue = lCodigoBaixaPerda
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill
            'Abre Relatório
            frmMain.LoadPageReport("EST000000009", "Baixa de Estoque para Perda", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Aprovar()

        Try

            'Verifica se o Usuário tem direito de Aprovar o Inventário
            If VerificaDireito(Formulario.EstoqueBaixaPerda, gcAdministrator) = True Then

                'Verifica se o Status da Baixa é Aguardando Aprovação
                If grdListagem.CurrentRow.Cells("status").Value <> StatusBaixaPerda.Aprovado Then

                    'Verifica se o Usuário Aprovar
                    If MsgBox("Deseja Confirmar a Baixa para Perda dos Produtos Selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.WaitCursor

                        'Aprova Baixa
                        Call oClsEstBaixaPerda.Status(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                       "AUTORIZADO BAIXA PARA PERDA.", _
                                                       StatusBaixaPerda.Aprovado)

                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                        'Carrega Grid
                        Call LoadGrid()

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.Default

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o Usuário tem direito de Reprovar o Inventário
            If VerificaDireito(Formulario.EstoqueBaixaPerda, gcAdministrator) = True Then

                'Verifica se o Status do Inventário é Aguardando Aprovação
                If grdListagem.CurrentRow.Cells("status").Value <> StatusBaixaPerda.Cancelado Then

                    'Váriavel - Formulário de Reprovar Inventario
                    Dim oForm As New frmEstBaixaPerdaCancelar

                    'Seta Parâmetros
                    oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("numero_documento").Value
                    oForm.Data = grdListagem.CurrentRow.Cells("data").Value
                    oForm.Deposito = grdListagem.CurrentRow.Cells("deposito").Value
                    oForm.CodigoBaixaPerda = grdListagem.CurrentRow.Cells("codigo").Value

                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Recarrega a Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmEstBaixaPerdaHistorico
            
            'Seta Parâmetros
            oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("numero_documento").Value
            oForm.Data = grdListagem.CurrentRow.Cells("data").Value
            oForm.Deposito = grdListagem.CurrentRow.Cells("deposito").Value
            oForm.CodigoBaixaPerda = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se Alguma Linha é Válida
            For Each oRow As GridEXRow In grdProduto.GetDataRows
                If IsNumeric(oRow.Cells("quantidade").Value) = True AndAlso oRow.Cells("quantidade").Value <= oRow.Cells("quantidade_estoque").Value Then
                    Validacao = True
                End If
            Next

            If Validacao = False Then
                'Informa o Usuário que não possui Registro Válido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi encontrado Registro com informação preenchida de forma adequada.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
