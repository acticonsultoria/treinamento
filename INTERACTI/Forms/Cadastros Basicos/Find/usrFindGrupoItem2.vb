Imports Janus.Windows.GridEX

Public Class usrFindGrupoItem2

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadItemLote As New clsusrCadItemLote
    Private lCodigoOrdemProducao As Long

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFindParceiroNegocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If Not grdFind.CurrentRow Is Nothing Then
                        If IsNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text = IIf(sRetornoParceiroNegocio = "CNPJ", grdFind.CurrentRow.Cells("cnpj").Value, grdFind.CurrentRow.Cells("razao_social").Value)
                        If IsNothing(oEditBoxFind) = False Then oEditBoxFind.Text = IIf(sRetornoParceiroNegocio = "CNPJ", grdFind.CurrentRow.Cells("cnpj").Value, grdFind.CurrentRow.Cells("razao_social").Value)
                        If IsNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value
                        sRetornoParceiroNegocio = ""
                        'Fecha Formulário
                        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    End If

                Case Keys.Escape
                    'Fecha Formulário
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFindParceiroNegocio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFind
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Verifica se o Grupo está Habilita
            If grdFind.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdFind.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdFind.GroupByBoxVisible = True
                grdFind.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFind.RowDoubleClick

        Try

            If IsNothing(grdFind.CurrentRow) Then Exit Sub

            'Carrega Controles
            If IsNothing(oComboBoxFind) = False Then

                'Verifica se foi selecionado o grupo de item
                If IsNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value

                ''Recebe o grupo selecionado
                'Dim lCodigoGrupoItem As Long = LoadUltimoGrupo()

                'Seta o grupo também

                If oComboBoxFindGrupoItemProduto IsNot Nothing Then
                    oComboBoxFindGrupoItemProduto.SelectedValue = grdFind.CurrentRow.Cells("codigo_grupo_item").Value
                    oComboBoxFind.Tag = grdFind.GetValue("saldo_disponivel")
                End If

                
            End If

            'Se for na grid
            If IsNothing(oGridExOrcamento) = False Then oGridExOrcamento.SetValue("codigo_item", grdFind.GetValue("codigo"))

            oComboBoxFind = Nothing
            oGridExOrcamento = Nothing
            oComboBoxFindGrupoItemProduto = Nothing

            'Fecha Formulário
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFind.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind.Name, _
                                     Formulario.CadastroBasicoGrupoItem, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFind.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind, _
                                     Formulario.CadastroBasicoGrupoItem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFind.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFind.Name, _
                                          Formulario.CadastroBasicoGrupoItem, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo1.SelectedIndexChanged, _
                                                                                        cboGrupo2.SelectedIndexChanged, _
                                                                                        cboGrupo3.SelectedIndexChanged, _
                                                                                        cboGrupo4.SelectedIndexChanged, _
                                                                                        cboGrupo5.SelectedIndexChanged, _
                                                                                        cboGrupo6.SelectedIndexChanged, _
                                                                                        cboGrupo7.SelectedIndexChanged, _
                                                                                        cboGrupo8.SelectedIndexChanged
        Try

            Dim iGrupo As Integer = Mid(sender.name, 9)

            If cboGrupo2.SelectedValue = 1822 And iGrupo >= 4 Then Exit Sub

            'GAMBIARRA para fazer o esquema das ferramentas de usinagem, que não são dependentes
            If cboGrupo2.SelectedValue = 1822 And sender.name = "cboGrupo3" Then


                'Os demais grupos são a mesma query
                Call LoadCombo(cboGrupo4, "sp_select_combo_cadastro_basico_grupo_item_filho_ferramenta_usinagem " & goUsuario.iEmpresa)
                Call LoadCombo(cboGrupo5, "sp_select_combo_cadastro_basico_grupo_item_filho_ferramenta_usinagem " & goUsuario.iEmpresa)
                Call LoadCombo(cboGrupo6, "sp_select_combo_cadastro_basico_grupo_item_filho_ferramenta_usinagem " & goUsuario.iEmpresa)
                Call LoadCombo(cboGrupo7, "sp_select_combo_cadastro_basico_grupo_item_filho_ferramenta_usinagem " & goUsuario.iEmpresa)
                Call LoadCombo(cboGrupo8, "sp_select_combo_cadastro_basico_grupo_item_filho_ferramenta_usinagem " & goUsuario.iEmpresa)

                lblGrupo4.Visible = True
                cboGrupo4.Visible = True

                lblGrupo5.Visible = True
                cboGrupo5.Visible = True

                lblGrupo6.Visible = True
                cboGrupo6.Visible = True

                lblGrupo7.Visible = True
                cboGrupo7.Visible = True

                lblGrupo8.Visible = True
                cboGrupo8.Visible = True


            ElseIf cboGrupo2.SelectedValue = 2750 Then '2750: 99 - MATERIAL DE TERCEIRO

                'Carrega a grid
                LoadGrid(grdFind, "sp_select_cadastro_basico_grupo_item_terceiro " & CStr(CType(sender, Janus.Windows.EditControls.UIComboBox).SelectedValue) & "," & CStr(goUsuario.iEmpresa) & "," & lCodigoOrdemProducao)

            Else

                'Verifica se foi selecionado algo
                If CType(sender, Janus.Windows.EditControls.UIComboBox).SelectedIndex = -1 Then Exit Sub

                'Recebe o numero do grupo
                Dim i As Integer = sender.name.Replace("cboGrupo", "")

                'Variável auxiliar para saber o próximo componente
                Dim oControleProximo As Object

                'Para cada controle dentro dos filtros
                For Each oControl In grpFiltro.Controls

                    'Verifica se é o caso de tratativa
                    If Not oControl.name.Contains("cboGrupo") And Not oControl.name.Contains("lblGrupo") Then Continue For

                    'Se for diferente de combobox e label, sair
                    If oControl.GetType.Name <> "UIComboBox" Then Continue For

                    'Somente verificar os itens depois do grupo atual
                    If oControl.name.Replace("cboGrupo", "") > i Then

                        'Verifica se o item que encontrou é o proximo do sender (ex: mudou o grupo1 , avaliar o grupo2)
                        If CInt(oControl.name.Replace("cboGrupo", "")) = i + 1 Then
                            oControleProximo = oControl
                        End If

                        'Transforma o objeto em combo para assumir as propriedades
                        CType(oControl, Janus.Windows.EditControls.UIComboBox).SelectedIndex = -1
                        CType(oControl, Janus.Windows.EditControls.UIComboBox).Visible = False

                    End If

                Next

                'Carrega o combo do próximo
                LoadCombo(oControleProximo, "sp_select_combo_cadastro_basico_grupo_item_filho " & CType(sender, Janus.Windows.EditControls.UIComboBox).SelectedValue & "," & goUsuario.iEmpresa, True)

                'Se não houver registro, deixar oculto
                If CType(oControleProximo, Janus.Windows.EditControls.UIComboBox).Items.Count > 0 Then
                    CType(oControleProximo, Janus.Windows.EditControls.UIComboBox).Visible = True
                End If

                'Carrega a grid
                LoadGrid(grdFind, "sp_select_cadastro_basico_grupo_item_filho " & CStr(CType(sender, Janus.Windows.EditControls.UIComboBox).SelectedValue) & "," & CStr(goUsuario.iEmpresa))


            End If


            'Verifica se é para exibir o label
            VerificarLabel()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnImportarGrupo_Click(sender As Object, e As EventArgs) Handles btnImportarGrupo.Click

        Try

            'Verifica o ultimo grupo selecionado
            Dim lCodigoGrupoItem As Long = LoadUltimoGrupo()

            'Se não encontrar, sair da função
            If lCodigoGrupoItem = -1 Then Exit Sub


            'Se for ferramenta de usinagem, trazer os itens
            If cboGrupo2.SelectedValue = 1822 Then

                sGrupoItemFerramentaConcatenado = CStr(cboGrupo1.SelectedValue) + "," + _
                                                  CStr(cboGrupo2.SelectedValue) + _
                                                  IIf(cboGrupo3.SelectedIndex = -1, "", "," + CStr(cboGrupo3.SelectedValue)) + _
                                                  IIf(cboGrupo4.SelectedIndex = -1, "", "," + CStr(cboGrupo4.SelectedValue)) + _
                                                  IIf(cboGrupo5.SelectedIndex = -1, "", "," + CStr(cboGrupo5.SelectedValue)) + _
                                                  IIf(cboGrupo6.SelectedIndex = -1, "", "," + CStr(cboGrupo6.SelectedValue)) + _
                                                  IIf(cboGrupo7.SelectedIndex = -1, "", "," + CStr(cboGrupo7.SelectedValue)) + _
                                                  IIf(cboGrupo8.SelectedIndex = -1, "", "," + CStr(cboGrupo8.SelectedValue))


                oComboBoxFindGrupoItemProduto.SelectedValue = 1822
            else

            'Verifica qual controle chamou
            If IsNothing(oComboBoxFind) = False Then
                oComboBoxFindGrupoItemProduto.SelectedValue = lCodigoGrupoItem

            ElseIf IsNothing(oGridExOrcamento) = False Then
                oGridExOrcamento.SetValue("codigo_grupo_item", lCodigoGrupoItem)
                Try
                    oGridExOrcamento.SetValue("codigo_item", DBNull.Value)
                Catch ex As Exception

                End Try
                End If
            End If

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Preenche a Variavel Local e Limpa a Variavel Global
            lCodigoOrdemProducao = lGrupoItemCodigoOrdemProducao
            lGrupoItemCodigoOrdemProducao = -1
            sGrupoItemFerramentaConcatenado = ""

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFindParceiroNegocio_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboGrupo1, "sp_select_combo_cadastro_basico_grupo_item_filho -1," & goUsuario.iEmpresa)

            btnImportarGrupo.Visible = True

            Try


                If Me.Parent.Tag = "MP" Then
                    cboGrupo1.SelectedValue = 24 'Matéria Prima'
                    cboGrupo1.Enabled = False
                    'btnImportarGrupo.Visible = False
                    btnImportarGrupo.Visible = True
                End If

                If Me.Parent.Tag = "SERVIÇOS" Then
                    cboGrupo1.SelectedValue = 1 'SERVIÇO DE TERCEIROS'
                    cboGrupo1.Enabled = False
                    'btnImportarGrupo.Visible = False
                    btnImportarGrupo.Visible = True
                End If

                If oComboBoxFind.Tag = "P" Then
                    btnImportarGrupo.Visible = False
                    cboGrupo1.SelectedValue = 24
                    cboGrupo1.Enabled = False
                    btnImportarGrupo.Visible = True
                End If


                If Me.Parent.Tag = "COMPRA" Then
                    btnImportarGrupo.Visible = False
                    cboGrupo1.SelectedValue = 24
                    cboGrupo1.Enabled = False
                    btnImportarGrupo.Visible = True
                End If

                If Me.Parent.Tag = "ESTOQUE" Then
                    btnImportarGrupo.Visible = False
                    cboGrupo1.SelectedValue = 24
                    cboGrupo1.Enabled = False
                    btnImportarGrupo.Visible = True
                End If


                If Me.Parent.Tag = "CORTE" Then
                    btnImportarGrupo.Visible = False
                    cboGrupo1.SelectedValue = 24
                    cboGrupo1.Enabled = False
                    btnImportarGrupo.Visible = False
                End If


            Catch ex As Exception
            End Try


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub VerificarLabel()

        Try

            For Each oControl In grpFiltro.Controls

                If oControl.GetType.Name = "Label" Then
                    oControl.visible = FindControl(grpFiltro, oControl.name.replace("lbl", "cbo")).Visible
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function LoadUltimoGrupo() As Long
        Try

            LoadUltimoGrupo = -1

            If cboGrupo1.SelectedIndex = -1 Then
                frmMain.Informacao("Selecione ao menos um grupo!", Color.Red)
                Exit Function
            End If

            For i As Integer = 8 To 1 Step -1

                Dim oComboBox As Janus.Windows.EditControls.UIComboBox = grpFiltro.Controls.Find("cboGrupo" & CStr(i), False)(0)

                If oComboBox.SelectedIndex <> -1 Then

                    LoadUltimoGrupo = oComboBox.SelectedValue

                    Exit For

                End If

            Next

         
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
