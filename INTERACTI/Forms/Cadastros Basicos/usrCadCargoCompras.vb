Imports Janus.Windows.GridEX

Public Class usrCadCargoCompras

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadCargoCompras As New clsUsrCadCargoCompras
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Dim oStackFrame As New System.Diagnostics.StackFrame(1) : Call TratamentoErro(ex.Message, Me.Name.ToString())
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            'Trata Erro
            Dim oStackFrame As New System.Diagnostics.StackFrame(1) : Call TratamentoErro(ex.Message, Me.Name.ToString())
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Dim oStackFrame As New System.Diagnostics.StackFrame(1) : Call TratamentoErro(ex.Message, Me.Name.ToString())
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            Novo()

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            txtDescricao.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()
            'Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            Dim oStackFrame As New System.Diagnostics.StackFrame(1) : Call TratamentoErro(ex.Message, Me.Name.ToString())
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            LoadGrid()

            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved,
                                                                                                                       grdUsuario.ColumnMoved


        Try

            UpdateConfiguraGrid(sender, _
                                iFormulario)

            AjustarChildTables(sender, e)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn,
                                                                                                                        grdUsuario.SizingColumn

        Try

            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

            AjustarChildTables(sender, Nothing, e)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdUsuario_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdUsuario.CellUpdated
        Try

            oClsUsrCadCargoCompras.UpdateUsuario(grdUsuario.CurrentRow.Cells.Item("codigo").Value,
                                                grdUsuario.CurrentRow.Cells.Item("aprovador").Value,
                                                grdUsuario.CurrentRow.Cells.Item("requisicao_compras").Value)

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub btnInserirUsuario_Click(sender As Object, e As EventArgs) Handles btnInserirUsuario.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Or ValidacaoUsuario() = False Then Exit Sub

            Salvar()
            SalvarUsuario()
            LoadGridUsuario()
            NovoUsuario()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirUsuario_Click(sender As Object, e As EventArgs) Handles btnExcluirUsuario.Click

        Try

            ExcluirUsuario()
            LoadGridUsuario()
            NovoUsuario()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(iFormulario, gcPrint)

            LoadCombo(cboUsuario, "sp_select_combo_cadastro_basico_usuario " & goUsuario.iEmpresa & ", 1")

            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdUsuario, iFormulario)

            tabMain.TabPages.Remove(pagDados)

            txtDescricaoFiltro.Focus()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#Region "::: CARGOS :::"

    Private Sub Editar()

        Try

            Novo()

            If VerificaDireito(iFormulario, gcUpdate) = True Then

                txtDescricao.Text = grdListagem.GetValue("descricao")
                txtValorAlcada.Value = grdListagem.GetValue("valor_alcada")
                btnSalvar.Tag = grdListagem.GetValue("codigo")

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                LoadGridUsuario()

                txtDescricao.Focus()

            Else
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrCadCargoCompras.Delete()

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            frmMain.errInfo.Clear()

            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpUsuario)
            btnSalvar.Tag = ""

            grdUsuario.DataSource = Nothing

            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadCargoCompras.Update(txtDescricao.Text.Trim, _
                                              txtValorAlcada.Value, _
                                              btnSalvar.Tag)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadCargoCompras.Insert(txtDescricao.Text.Trim, _
                                              txtValorAlcada.Value, _
                                              btnSalvar)

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadCargoCompras.LoadGrid(grdListagem, _
                                            txtDescricaoFiltro.Text.Trim)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False

            If oClsUsrCadCargoCompras.ValidaCargo(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                       txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Este cargo: " & txtDescricao.Text & " já está associado a outro Registro.")
                txtDescricao.Focus()
                Exit Function
            End If

            If ValidaCampo(txtValorAlcada, lblValorAlcada, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: USUARIOS :::"

    Private Sub NovoUsuario()

        Try

            LimparCamposGroupBox(grpUsuario)
            btnInserirUsuario.Tag = ""

            cboUsuario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarUsuario()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadCargoCompras.InsertUsuario(btnSalvar.Tag,
                                                 cboUsuario.SelectedValue)

            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridUsuario()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadCargoCompras.LoadGridUsuario(grdUsuario,
                                                   IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirUsuario()

        Try

            If grdUsuario.GetCheckedRows.Count = 0 Then
                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Sub
            End If

            If MsgBox("Deseja excluir os itens selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Usuario") <> MsgBoxResult.Yes Then Exit Sub

            For Each oRow As GridEXRow In grdUsuario.GetCheckedRows

                oClsUsrCadCargoCompras.DeleteUsuario(btnSalvar.Tag,
                                                oRow.Cells.Item("codigo").Value)

            Next

            frmMain.Informacao("Características excluídas com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidacaoUsuario() As Boolean

        Try

            If ValidaCampo(cboUsuario, lblUsuario, TipoCampo.texto) = False Then Return False

            If oClsUsrCadCargoCompras.ValidaCampoUsuario(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                         cboUsuario.SelectedValue
                                                         ) = False Then
                frmMain.errInfo.SetError(lblUsuario, "O usuário: " & cboUsuario.Text & " já está associado a outro Registro.")
                cboUsuario.Focus()
                Exit Function

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
