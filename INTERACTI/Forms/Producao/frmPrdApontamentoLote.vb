Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPrdApontamentoLote

#Region "::: VARIAVEIS :::"

    Private oClsPrdApontamentoIssartel As New clsUsrPrdApontamentoIssartel

#End Region

#Region "::: CONTROLES :::"



    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub


    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdApontamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdApontamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdApontamento.GroupByBoxVisible = True
                grdApontamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdApontamento
            oForm.NomeFormulario = Formulario.ProducaoApontamentoManual
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoApontamentoManual)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            Call LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Call Salvar()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

  
    Private Sub grdApontamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdApontamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento.Name, _
                                     Formulario.ProducaoApontamentoManual, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdApontamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento, _
                                     Formulario.ProducaoApontamentoManual)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdApontamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdApontamento.Name, _
                                          Formulario.ProducaoApontamentoManual, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao -1," & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoApontamentoManual)

            'Seta Focu
            dtpDataInicio.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


    Private Sub Salvar()
        Try
            'Validação
            If Validacao() = False Then Exit Sub


            'Remove os filtros
            grdApontamento.RemoveFilters()


            Dim iSegundos As Integer = DateDiff(DateInterval.Second, dtpDataInicio.Value, dtpDataTermino.Value)
            Dim dRateio As Double = iSegundos / CDbl(grdApontamento.GetCheckedRows.Count)
            Dim dData As Date = dtpDataInicio.Value

            Dim bPrimeira As Boolean = True

            'Laço para inserir
            For Each oRow In grdApontamento.GetCheckedRows

                Dim OPAnterior As String
                Dim OP As String
                Dim sLocalizacao As String = ""

                OPAnterior = OP
                OP = oRow.Cells.Item("ordem_producao").Value

                If OPAnterior <> OP Then
                    bPrimeira = True
                End If

                If ((OPAnterior <> OP) Or (bPrimeira = True)) Then
                    sLocalizacao = InputBox("Informe a localização da " + oRow.Cells.Item("ordem_producao").Value + ":", "Localização")
                    bPrimeira = False
                End If

                'Atualiza
                Call oClsPrdApontamentoIssartel.UpdateApontamento(1, _
                                                         oRow.Cells.Item("codigo").Value, _
                                                         oRow.Cells.Item("sequencia").Value, _
                                                         0, _
                                                         0, _
                                                         0, _
                                                         cboFuncionario.SelectedValue, _
                                                         -1, _
                                                         -1, _
                                                         -1, _
                                                         oRow.Cells.Item("quantidade").Value, _
                                                         oRow.Cells.Item("quantidade").Value, _
                                                         0, _
                                                         dData, _
                                                         DateAdd(DateInterval.Second, dRateio, dData), _
                                                         sLocalizacao, _
                                                         oRow.Cells.Item("quantidade").Value, _
                                                         chkNaoAplicavel.Checked)

                'Incrementa
                dData = DateAdd(DateInterval.Second, dRateio, dData)

            Next

            'Informa ao usuário
            frmMain.Informacao("Apontamentos inseridos com sucesso!", Color.Blue)

            'Fecha a tela
            Me.Dispose()

        Catch ex As Exception
            tratamentoerro(ex.message, Me.parent.tostring)
        End Try
    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

         

            'Verifica se foi Selecionado o Campo - Funcionário
            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Turno
            If ValidaCampo(cboOperacao, lblOperacao) = False Then
                Exit Function
            End If

            If grdApontamento.GetCheckedRows.Count = 0 Then
                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Function
            End If


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGrid()
        Try

            frmmain.errinfo.clear()


            If ValidaCampo(cboOperacao, lblOperacao) = False Then Exit Sub


            oClsPrdApontamentoIssartel.LoadGridApontamentoLote(grdApontamento, _
                                                               cboOperacao.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

   
End Class
