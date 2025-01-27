Imports Janus.Windows.GridEX

Public Class usrFindServico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadServico As New clsUsrCadServico
    Private oClsVenOrcamento As New clsUsrVenOrcamento

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFindServico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub frmFindServico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFind
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado algum Registro
            If VerificaSelecaoRow(grdFind) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Tabela de Preço
            If ValidaCampo(cboRevisaoTabelaPreco, lblRevisaoTabelaPreco) = False Then
                Exit Sub
            End If

            'Insere Orçamento
            Call oClsVenOrcamento.InsertOrcamentoItemEmpreitera(lCodigoOrcamentoGlobal, _
                                                                txtPercentualNotaFiscal.Value, _
                                                                txtPercentualComercial.Value, _
                                                                txtPercentualBDI.Value, _
                                                                cboRevisaoTabelaPreco.SelectedValue)

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

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

    Private Sub grdFind_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdFind.RowCheckStateChanged

        Try

            If IsDBNull(grdFind.CurrentRow.Cells("nivel").Value) = False Then

                Dim iCodigoEspecie As Integer = grdFind.CurrentRow.Cells("codigo_especie").Value

                For Each oRow As GridEXRow In grdFind.GetDataRows

                    If (IsDBNull(oRow.Cells("codigo_especie").Value) = False AndAlso oRow.Cells("codigo_especie").Value = iCodigoEspecie) OrElse
                        (IsDBNull(oRow.Cells("codigo_especie_pai").Value) = False AndAlso oRow.Cells("codigo_especie_pai").Value = iCodigoEspecie) Then
                        oRow.CheckState = e.CheckState
                    End If

                Next

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFind.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFind.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindServico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call oClsCadServico.LoadGridFindCaderno(grdFind)

            'Carrega Combo
            Call LoadCombo(cboRevisaoTabelaPreco, "sp_select_combo_cadastro_basico_produto_preco_venda_revisao " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoServico, False)

            'Seta Focu
            grdFind.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

#End Region

End Class
