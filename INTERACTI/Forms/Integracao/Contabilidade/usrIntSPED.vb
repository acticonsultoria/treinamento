Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO
Imports Dundas.Charting.WinControl


Public Class usrIntSPED

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstSPED As New clsUsrIntSPED

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrEstSPED_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrEstSPED_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: SPED :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoBanco
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBanco)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

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

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna Selecionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                'Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     Formulario.CadastroBasicoBanco)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     Formulario.CadastroBasicoBanco,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name,
                                          Formulario.CadastroBasicoBanco,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarTXT_Click(sender As Object, e As EventArgs) Handles btnGerarTXT.Click

        Try

            LoadGrid()

            Dim oFolderDialog As New FolderBrowserDialog
            If oFolderDialog.ShowDialog = vbOK Then

                GerarTXT(oFolderDialog.SelectedPath & "/" & "SPED_" & Format(dtpDataReferenciaFiltro.Value, "yyyy_MM_dd") & ".txt", CType(grdListagem.DataSource, DataViewManager).DataSet.Tables(0))

            End If

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstSPED_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoBanco, gcPrint)

            'Configura DateTimer
            'dtpDataFiltro.Value = DateAdd(DateInterval.Day, (DatePart(DateInterval.Day, Now.Date) - 1) * -1, Now.Date) : dtpDataFiltro.Checked = True


            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBanco)

            'Seta Focu
            dtpDataReferenciaFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    'Private Sub Editar()

    '    Try

    '        'Verifica se o Usuário tem direito de Alterar Dados
    '        If VerificaDireito(Formulario.CadastroBasicoBanco, gcUpdate) = True Then

    '            'Limpa Controles
    '            Call Novo()

    '            'Seta Controles
    '            txtCodigoBanco.Text = grdListagem.CurrentRow.Cells("codigo_banco").Value
    '            txtDescricao.Text = grdListagem.CurrentRow.Cells("descricao").Value
    '            cboAtivo.SelectedValue = grdListagem.CurrentRow.Cells("ativo").Value
    '            btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

    '            'Alterna Aba
    '            tabMain.TabPages.Remove(pagLista)
    '            tabMain.TabPages.Add(pagDados)

    '            'Seta Focu
    '            txtCodigoBanco.Focus()

    '        Else
    '            'Informa o Usuário que ele não tem Direito
    '            frmMain.Informacao(Mensagem.DireitoAlteracao)
    '        End If

    '    Catch ex As Exception
    '        'Trata Erro
    '        Throw ex
    '    End Try

    'End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim dData As Date = DateAdd(DateInterval.Day, -1, New Date(Year(dtpDataReferenciaFiltro.Value), Month(dtpDataReferenciaFiltro.Value), 1))
            dData = DateAdd(DateInterval.Month, 1, dData)

            'Seta Parametros
            oClsEstSPED.LoadGrid(grdListagem,
                                 dData)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub GerarTXT(ByVal sArquivo As String,
                         ByVal oDataTable As DataTable)


        'Instancia o arquivo para escrita
        Dim oFile As New System.IO.StreamWriter(sArquivo, False, System.Text.Encoding.Default)
        Try

            For Each oDataRow As DataRow In oDataTable.Rows

                oFile.WriteLine(oDataRow(0))

            Next

            'Fecha o arquivo
            oFile.Close()

        Catch ex As Exception
            oFile.Close()
            Throw ex
        End Try

    End Sub

#End Region

End Class
