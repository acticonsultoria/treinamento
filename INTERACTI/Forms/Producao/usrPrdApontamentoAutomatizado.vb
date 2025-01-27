Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class usrPrdApontamentoAutomatizado

#Region "::: VARIAVEIS :::"

    Private oClsUsrPrdApontamentoAutomatizado As New clsUsrPrdApontamentoAutomatizado

    Private iPasso As Integer
    Private iSequencia As Integer
    Private iSequenciaConcorrente As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub cboOperacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperacao.SelectedIndexChanged

        Try

            iSequencia = -1

            If cboOperacao.SelectedIndex = -1 Then Exit Sub
            If IsNothing(cboOperacao.SelectedValue) Then Exit Sub

            iSequencia = cboOperacao.SelectedValue.ToString.Substring(5, 5)

            If cboTipo.SelectedValue = 1 Then 'Se for Tipo Ordem de Produção
                iSequenciaConcorrente = LoadCodigo("sp_select_producao_apontamento_automatizado_sequencia_concorrente " & cboOrdem.SelectedValue & "," & iSequencia & "," & goUsuario.iEmpresa)
            End If
            
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged

        Try

            Cursor.Current = Cursors.WaitCursor

            cboOrdem.SelectedIndex = -1
            cboOrdem.DataSource = Nothing
            lblOrdem.Text = ""

            If cboTipo.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboOrdem, "sp_select_combo_producao_apontamento_automatizado " & cboTipo.SelectedValue & ", " & goUsuario.iEmpresa)

            Select Case cboTipo.SelectedValue

                Case TipoApontamentoAutomatizado.OrdemProducao
                    lblOrdem.Text = "Ordem de Produção:"
                Case TipoApontamentoAutomatizado.OrdemServico
                    lblOrdem.Text = "Ordem de Serviço:"
                Case TipoApontamentoAutomatizado.OrdemDespesa
                    lblOrdem.Text = "Ordem de Despesa:"

            End Select

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_ColumnMoved(sender As Object, e As ColumnActionEventArgs) Handles grdApontamento.ColumnMoved

        Try

            Call UpdateConfiguraGrid(grdApontamento, _
                                     Formulario.ProducaoApontamentoAutomatizado)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdApontamento.GroupsChanging

        Try

            Call UpdateConfiguraGridGrupo(grdApontamento.Name, _
                                         Formulario.ProducaoApontamentoAutomatizado, _
                                         e.Group.Column.Key, _
                                         IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                         e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_SizingColumn(sender As Object, e As SizingColumnEventArgs) Handles grdApontamento.SizingColumn

        Try

            Call UpdateConfiguraGrid(grdApontamento.Name, _
                                     Formulario.ProducaoApontamentoAutomatizado, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTurno.SelectedIndexChanged

        Try

            cboPeriodo.SelectedIndex = -1
            cboPeriodo.DataSource = Nothing

            If cboTurno.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboPeriodo, "sp_select_combo_static_turno_periodo " & cboTurno.SelectedValue)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrPrdApontamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            'Select Case e.KeyCode

            '    Case Keys.Enter
            '        Select Case sender.name
            '            Case "cboTipoApontamento" : Call Passo1()
            '            Case "cboOPOperacao" : Call Passo2()
            '            Case "cboFuncionario" : If bOperacaoExterna = False Then Call Passo3() Else Call Passo4()
            '            Case "cboEquipamento" : Call Passo5()
            '            Case "txtQuantidadeProduzida" : Call Passo7()
            '            Case "txtQuantidadeAbertura" : Call Passo6()
            '            Case "cboMotivoParada" : Call Passo8()
            '        End Select

            'End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdApontamento_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try

            'Select Case e.KeyCode

            '    Case Keys.Enter
            '        Select Case sender.name
            '            Case "cboTipoApontamento" : Call Passo1()
            '            Case "cboOPOperacao" : Call Passo2()
            '            Case "cboFuncionario" : If bOperacaoExterna = False Then Call Passo3() Else Call Passo4()
            '            Case "cboEquipamento" : Call Passo5()
            '            Case "txtQuantidadeProduzida" : Call Passo7()
            '            Case "txtQuantidadeAbertura" : Call Passo6()
            '            Case "cboMotivoParada" : Call Passo8()
            '        End Select

            'End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub usrPrdApontamento_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboOrdemProducao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOrdem.SelectedIndexChanged

        Try

            cboOperacao.SelectedIndex = -1
            cboOperacao.DataSource = Nothing
            grdApontamento.DataSource = Nothing

            If cboOrdem.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboOperacao, "sp_select_combo_producao_apontamento_operacao_automatico " & cboOrdem.SelectedValue & ", " & cboTipo.SelectedValue & ", " & goUsuario.iEmpresa, True)

            oClsUsrPrdApontamentoAutomatizado.LoadGridApontamento(grdApontamento, _
                                                                  cboOrdem.SelectedValue, _
                                                                  cboTipo.SelectedValue)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdApontamento.RowDoubleClick
        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdApontamento.CurrentColumn) Then Exit Sub

            Select Case grdApontamento.CurrentColumn.Key

                Case "excluir" : Excluir()

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdApontamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            LoadCombo(cboTipo, "sp_select_static_tipo_apontamento_automatizado")
            LoadCombo(cboTurno, "sp_select_combo_static_turno")
            'Verifica o Tipo de Operação
            Call LoadCombo(cboFuncionario, "sp_select_combo_producao_funcionario " & goUsuario.iEmpresa)
            'Seta funcionário
            Dim sCodigoFuncionario As String
            sCodigoFuncionario = LoadCodigo("sp_select_cadastro_basico_funcionario_codigo " & goUsuario.iEmpresa & ", '" & goUsuario.sNome & "'")
            cboFuncionario.SelectedValue = sCodigoFuncionario

            dtpDataInicio.Value = Today.Date

            ConfiguraGrid(grdApontamento, Formulario.ProducaoApontamentoAutomatizado)

            'Seta Focu
            cboTurno.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            LimparCamposGroupBox(grpApontamento)
            grdApontamento.DataSource = Nothing

            'Seta Focu
            cboTurno.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Excluir()

        Try

            'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registros
                oClsUsrPrdApontamentoAutomatizado.ExcluirApontamento(cboOrdem.SelectedValue, _
                                                                     cboTipo.SelectedValue, _
                                                                     grdApontamento.CurrentRow.Cells("sequencia").Value, _
                                                                     grdApontamento.CurrentRow.Cells("codigo").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                oClsUsrPrdApontamentoAutomatizado.LoadGridApontamento(grdApontamento, _
                                                                      cboOrdem.SelectedValue, _
                                                                      cboTipo.SelectedValue)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            If MsgBox("Confirma os Dados do Apontamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                oClsUsrPrdApontamentoAutomatizado.UpdateApontamento(cboOrdem.SelectedValue, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    cboFuncionario.SelectedValue, _
                                                                    dtpDataInicio.Value, _
                                                                    cboTurno.SelectedValue, _
                                                                    cboPeriodo.SelectedValue, _
                                                                    cboTipo.SelectedValue)

                frmMain.Informacao(Mensagem.RegistroInserido)

                oClsUsrPrdApontamentoAutomatizado.LoadGridApontamento(grdApontamento, _
                                                                      cboOrdem.SelectedValue, _
                                                                      cboTipo.SelectedValue)

                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboTurno, lblTurno) = False Then
                Return False
            End If

            If ValidaCampo(cboPeriodo, lblPeriodo) = False Then
                Return False
            End If

            If ValidaCampo(cboTipo, lblTipo) = False Then
                Return False
            End If

            If ValidaCampo(cboOrdem, lblOrdem) = False Then
                Return False
            End If

            If ValidaCampo(cboOperacao, lblOPOperacao) = False Then
                Return False
            End If

            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Return False
            End If

            If ValidacaoDataCusteio(dtpDataInicio.Value) = False Then
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
