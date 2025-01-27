Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrVenOrcamentoAprovacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrVenOrcamentoAprovacao As New clsUsrVenOrcamentoAprovacao
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            LoadGrid()

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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "aprovar" : Aprovar()
                Case "reprovar" : Reprovar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     iFormulario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            dtpDataOrcamentoTerminoFiltro.Value = Now : dtpDataOrcamentoTerminoFiltro.Checked = False
            dtpDataOrcamentoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now) : dtpDataOrcamentoInicioFiltro.Checked = True

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

            txtNumeroOrcamentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoAprovacao.LoadGrid(grdListagem, _
                                                  IIf(IsNumeric(txtNumeroOrcamentoFiltro.Text.Trim), txtNumeroOrcamentoFiltro.Text.Trim, -1), _
                                                  IIf(dtpDataOrcamentoInicioFiltro.Checked = False, "", dtpDataOrcamentoInicioFiltro.Value), _
                                                  IIf(dtpDataOrcamentoTerminoFiltro.Checked = False, "", dtpDataOrcamentoTerminoFiltro.Value), _
                                                  IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Sub btnProcurarCliente_Click(sender As Object, e As EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboClienteFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Aprovar()

        Try

            If MsgBox("Deseja aprovar o orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoAprovacao.UpdateAprovarOrcamento(grdListagem.GetValue("codigo"))

            Cursor.Current = Cursors.Default

            frmMain.Informacao(Mensagem.RegistroAprovado)

            If MsgBox("Deseja gerar um pedido de venda para este orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Cursor.Current = Cursors.WaitCursor

                oClsUsrVenOrcamentoAprovacao.InsertPedidoVenda(grdListagem.GetValue("codigo"))

                Cursor.Current = Cursors.Default

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Reprovar()

        Try

            If MsgBox("Deseja reprovar o orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoAprovacao.UpdateReprovarOrcamento(grdListagem.GetValue("codigo"))

            Cursor.Current = Cursors.Default

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
