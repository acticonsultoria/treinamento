Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrEstRequisicaoEstorno

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstRequisicaoEstorno As New clsUsrEstRequisicaoEstorno

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrEstRequisicaoEstorno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrEstRequisicaoEstorno_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ESTORNO :::"

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
            oForm.NomeFormulario = Formulario.EstoqueRequisicaoEstornar
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueRequisicaoEstornar)

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

    Private Sub btnEstornarRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstornarRequisicao.Click

        Try

            'Valida Formulário
            If Validacao() = True Then

                'Estornar Requisição
                Call EstornarRequisicao(False)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEstornarRequisicaoCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstornarRequisicaoCancelar.Click

        Try
            
            'Valida Formulário
            If Validacao() = True Then

                'Estornar Requisição
                Call EstornarRequisicao(True)

            End If

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.EstoqueRequisicaoEstornar)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.EstoqueRequisicaoEstornar, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.EstoqueRequisicaoEstornar, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstRequisicaoEstorno_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnEstornarRequisicao.Enabled = VerificaDireito(Formulario.EstoqueRequisicaoEstornar, gcInsert)

            'Carrega ComboBox        
            Call LoadCombo(cboTipoRequisicaoFiltro, "sp_select_combo_static_tipo_requisicao_estoque")
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueRequisicaoEstornar)

            'Seta Focu
            txtNumeroRequisicaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ESTORNO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsEstRequisicaoEstorno.LoadGrid(grdListagem, _
                                              IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1), _
                                              IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value), _
                                              IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value), _
                                              IIf(cboTipoRequisicaoFiltro.SelectedIndex = -1, -1, cboTipoRequisicaoFiltro.SelectedValue), _
                                              txtNumeroDocumentoFiltro.Text.Trim, _
                                              txtProdutoFiltro.Text.Trim, _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = False, "", dtpDataPagamentoInicioFiltro.Value), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "", dtpDataPagamentoTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EstornarRequisicao(ByVal bCancelar As Boolean)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Informado a Quantidade - Estorno
            If grdListagem.GetDataRows.Count > 0 AndAlso grdListagem.GetTotalRow.Cells("quantidade_estorno").Value > 0 Then

                'Verifica se o Usuário deseja Aprovar a Requisição
                If MsgBox("Deseja Estornar para o Estoque o(s) Produto(s) Informado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Aprova Requisição
                    Call oClsEstRequisicaoEstorno.EstornarRequisicao(grdListagem, bCancelar)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Carrega Grid
                    Call LoadGrid()

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            For Each oRow As GridEXRow In grdListagem.GetDataRows
                If oRow.Cells("quantidade_estorno").Value > 0 AndAlso _
                   oRow.Cells("quantidade_estorno").Value <= oRow.Cells("quantidade_paga").Value Then
                    Return True
                    Exit Function
                End If
            Next
            
            'Informa o Usuário que não possui Registro Válido
            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi encontrado Registro com Quantidade de Estorno menor ou igual a Quantidade Paga.")
            'Seta Focu
            grdListagem.Focus()

            'Retorno da Função
            Return False

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

#End Region

End Class


