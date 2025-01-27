Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrPrdPlanejamentoSequenciamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdPlanejamentoLegado As New clsUsrPrdPlanejamentoLegado
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"
    Private Sub grd_ColumnMoved(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProcesso.ColumnMoved

        Try

            UpdateConfiguraGrid(sender,
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(sender As Object, e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProcesso.SizingColumn

        Try

            UpdateConfiguraGrid(sender.Name,
                                iFormulario,
                                e.Column.Key,
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

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

    Private Sub grdProcesso_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdProcesso.RowDoubleClick

        Try

            Select Case grdProcesso.CurrentColumn.Key
                Case "subir", "descer", "priorizar", "limpar_prioridade"


                    Acao(grdProcesso.CurrentColumn.Key)


            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub cboCentroTrabalhoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroTrabalhoFiltro.SelectedIndexChanged
        Try

            Dim i As Integer = IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue)
            Dim iFuncionario As Integer = IIf(cboFuncionarioFiltro.SelectedIndex = -1, -1, cboFuncionarioFiltro.SelectedValue)

            'LoadCombo(cboFuncionarioFiltro, "sp_select_combo_cadastro_basico_funcionario_centro_trabalho " & goUsuario.iEmpresa & "," & i, True)
            LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina_centro_trabalho_funcionario " & goUsuario.iEmpresa & "," & iFuncionario & "," & IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue), True)

            LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboFuncionarioFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFuncionarioFiltro.SelectedValueChanged
        Try

            Dim iFuncionario As Integer = IIf(cboFuncionarioFiltro.SelectedIndex = -1, -1, cboFuncionarioFiltro.SelectedValue)

            LoadCombo(cboCentroTrabalhoFiltro, "sp_select_combo_cadastro_basico_centro_trabalho_funcionario " & goUsuario.iEmpresa & "," & iFuncionario, True)
            LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina_centro_trabalho_funcionario " & goUsuario.iEmpresa & "," & iFuncionario & "," & IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue), True)

            LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboMaquina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaquina.SelectedIndexChanged
        Try
            LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"


    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario

            Call LoadCombo(cboFuncionarioFiltro, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)

            Dim i As Integer = LoadCodigo("sp_select_cadastro_basico_usuario_codigo_funcionario " & goUsuario.iEmpresa & "," & goUsuario.iUsuario)
            If i <> -1 Then
                cboFuncionarioFiltro.SelectedValue = i
                cboFuncionarioFiltro.Enabled = False
            End If

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Timer1.Interval = 60000
            Timer1.Enabled = True

            'Configura Grid
            Call ConfiguraGrid(grdProcesso, iFormulario)

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()

            If cboFuncionarioFiltro.SelectedIndex = -1 Then Exit Sub

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdPlanejamentoLegado.LoadGridSequenciamento(IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue), _
                                                                  cboFuncionarioFiltro.SelectedValue, _
                                                                  IIf(cboMaquina.SelectedIndex = -1, -1, cboMaquina.SelectedValue), _
                                                                  grdProcesso)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Acao(ByVal sAcao As String)
        Try


            
       

            Dim iRowIndex As Integer = grdProcesso.CurrentRow.RowIndex


            If sAcao = "priorizar" Then
                oClsPrdPlanejamentoLegado.Priorizar(grdProcesso.GetValue("codigo_ordem_producao"), _
                                                    grdProcesso.GetValue("sequencia"))

            ElseIf sAcao = "limpar_prioridade" Then
                oClsPrdPlanejamentoLegado.Limpar(grdProcesso.GetValue("codigo_ordem_producao"), _
                                                    grdProcesso.GetValue("sequencia"))

            End If
            'Carrega a grid
            LoadGrid()

            Try

                grdProcesso.Row = 0

            Catch ex As Exception

            End Try


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region



End Class
