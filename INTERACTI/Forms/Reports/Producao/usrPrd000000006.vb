Imports Janus.Windows.GridEX

Public Class usrPrd000000006

    'Variáveis da Classe
    Private oClsPrd000000006 As New clsUsrPrd000000006

#Region "::: CONTROLES :::"

    Private Sub usrVen000000015_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrVen000000015_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelListagem.Click

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

            'Carrega Grid
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


    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioPRD000000006)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioPRD000000006, _
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
                                          Formulario.RelatorioPRD000000006, _
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

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVen000000015_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadCombo(cboFuncionarioFiltro, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao_apontamento")

            'Verifica Direito
            btnExcelListagem.Enabled = VerificaDireito(Formulario.RelatorioPRD000000006, gcPrint)

            'Configura DateTimer
            dtpDataAberturaInicioFiltro.Value = DateAdd(DateInterval.Day, (DatePart(DateInterval.Day, Now.Date) - 1) * -1, Now.Date) : dtpDataAberturaInicioFiltro.Checked = False
            dtpDataAberturaTerminoFiltro.Value = Now.Date : dtpDataFechamentoInicioFiltro.Checked = False
            dtpDataFechamentoInicioFiltro.Value = DateAdd(DateInterval.Day, (DatePart(DateInterval.Day, Now.Date) - 1) * -1, Now.Date) : dtpDataFechamentoInicioFiltro.Checked = False
            dtpDataFechamentoTerminoFiltro.Value = Now.Date : dtpDataFechamentoInicioFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioPRD000000006)

            'Seta Focu

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sStatus As String = ""
            'Vendedor
            For Each oRow As GridEXRow In cboStatusFiltro.DropDownList.GetCheckedRows
                sStatus &= IIf(sStatus = "", "", ",") & oRow.Cells("codigo").Value
            Next

            'Seta Parametros
            oClsPrd000000006.LoadGrid(grdListagem, _
                                      IIf(dtpDataAberturaInicioFiltro.Checked = True, dtpDataAberturaInicioFiltro.Value, ""), _
                                      IIf(dtpDataAberturaTerminoFiltro.Checked = True, dtpDataAberturaTerminoFiltro.Value, ""), _
                                      IIf(dtpDataFechamentoInicioFiltro.Checked = True, dtpDataFechamentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataFechamentoTerminoFiltro.Checked = True, dtpDataFechamentoTerminoFiltro.Value, ""), _
                                      sStatus, _
                                      IIf(cboFuncionarioFiltro.SelectedIndex = -1, -1, cboFuncionarioFiltro.SelectedValue))

            'Seta Pposição
            grdListagem.MoveFirst()

            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class
