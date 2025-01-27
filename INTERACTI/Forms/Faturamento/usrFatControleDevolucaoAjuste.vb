Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFatControleDevolucaoAjuste

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFatControleDevolucao As New clsUsrFatControleDevolucao

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFatControleDevolucao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFatControleDevolucao_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoControleDevolucao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FaturamentoControleDevolucao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoControleDevolucao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTROLE DE DEVOLUÇÃO :::"

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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells.Item("codigo_emissao_capa").Value, grdListagem.CurrentRow.Cells.Item("codigo_emissao_item").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            btnSair.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sCFOP As String = ""
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOP &= IIf(sCFOP = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            Dim sStatus As String = ""

            'Status
            For Each oRow As GridEXRow In cboStatusFiltro.DropDownList.GetCheckedRows
                sStatus &= IIf(sStatus = "", "", ",") & oRow.Cells("descricao").Value
            Next

            'Carrega Grid de Pedido de Venda
            Call oClsUsrFatControleDevolucao.LoadGrid(grdListagem, _
                                                      txtNFRemessaFiltro.Text, _
                                                      IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                      sCFOP, _
                                                      txtFornecedorFiltro.Text, _
                                                      sStatus)

            'Atualiza Grid
            grdListagem.Refresh()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboDevolucaoNF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDevolucaoNF.SelectedIndexChanged
        Try

            Call LoadCombo(cboDevolucaoProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao_produtos_ajuste " & goUsuario.iEmpresa & ", " & cboDevolucaoNF.SelectedValue, False)

            'Carrega os controles referentes a nota de devolução
            Call oClsUsrFatControleDevolucao.LoadDadosDevolucaoNF(cboDevolucaoNF.SelectedValue, _
                                                                  txtDevolucaoDataEmissao, _
                                                                  txtDevolucaoEmitente)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboDevolucaoProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDevolucaoProduto.SelectedIndexChanged
        Try

            'Carrega os controles referentes a nota de devolução
            Call oClsUsrFatControleDevolucao.LoadDadosDevolucaoItensNF(cboDevolucaoNF.SelectedValue, _
                                                                       cboDevolucaoProduto.SelectedValue, _
                                                                       txtDevolucaoDescricao, _
                                                                       txtDevolucaoQuantidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnInserirProduto_Click(sender As Object, e As EventArgs) Handles btnInserirProduto.Click
        Try

            Call Inserir()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnExcluirProduto_Click(sender As Object, e As EventArgs) Handles btnExcluirProduto.Click
        Try

            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatControleDevolucao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ", 'S'")
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_devolucao")
            'Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_faturamento_controle_devolucao")

            dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Checked = False

            Call LoadGrid()

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTROLE DE DEVOLUÇÃO :::"

    Private Sub Novo()

        Try

            'Limpa campos
            txtDevolucaoDescricao.Text = ""
            txtDevolucaoQuantidade.Value = 0
            cboDevolucaoProduto.SelectedIndex = -1
            cboDevolucaoNF.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigoEmissaoCapa As Long, ByVal iCodigoEmissaoItem As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Formulário
            Call Novo()

            'Carrega os controles referentes a nota de remessa 
            Call oClsUsrFatControleDevolucao.LoadDadosRemessaNF(lCodigoEmissaoCapa, _
                                                                iCodigoEmissaoItem, _
                                                                txtRemessaNF, _
                                                                txtRemessaDataEmissao, _
                                                                txtRemessaDestinatario, _
                                                                txtRemessaProduto, _
                                                                txtRemessaDescricao, _
                                                                txtRemessaQuantidade)

            'Carrega grid de produtos 
            Call LoadGridProduto()

            Call LoadCombo(cboDevolucaoNF, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao_ajuste " & goUsuario.iEmpresa & ", " & txtRemessaDestinatario.Tag, False)

            'Troca de página
            tabMain.TabPages.Remove(pagListagem)
            If tabMain.TabPages.Contains(pagDados) = False Then tabMain.TabPages.Add(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Validacao() As Boolean

        Validacao = False

        If ValidaCampo(cboDevolucaoNF, lblDevolucaoNF) = False Then
            Exit Function
        End If

        If ValidaCampo(cboDevolucaoProduto, lblDevolucaoProduto) = False Then
            Exit Function
        End If

        If ValidaCampo(txtDevolucaoQuantidade, lblDevolucaoQuantidade, TipoCampo.numero) = False Then
            Exit Function
        End If

        If grdProduto.RowCount > 0 Then
            If txtDevolucaoQuantidade.Value + grdProduto.GetTotalRow.Cells("quantidade").Value > txtRemessaQuantidade.Value Then
                frmMain.errInfo.SetError(lblDevolucaoQuantidade, "A quantidada retornada é maior que a quantidade de remessa.")
                Exit Function
            End If
        End If
        
        Validacao = True

    End Function

    Private Sub LoadGridProduto()

        Try

           Call oClsUsrFatControleDevolucao.LoadGridProduto(txtRemessaNF.Tag, txtRemessaProduto.Tag, grdProduto)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Inserir()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If Validacao() = False Then Exit Sub

            Call oClsUsrFatControleDevolucao.Salvar(txtRemessaNF.Tag, _
                                                    txtRemessaProduto.Tag, _
                                                    cboDevolucaoNF.SelectedValue, _
                                                    cboDevolucaoProduto.SelectedValue, _
                                                    txtDevolucaoQuantidade.Value)

            Call LoadGridProduto()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroInserido)

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro do Banco de Dados
                oClsUsrFatControleDevolucao.Delete()

                Call LoadGridProduto()

                Call Novo()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class