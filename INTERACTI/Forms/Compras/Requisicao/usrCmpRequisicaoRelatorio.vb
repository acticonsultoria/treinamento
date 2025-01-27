Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrCmpRequisicaoRelatorio

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpRequisicaoRelatorio As New clsUsrCmpRequisicaoRelatorio
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtItemFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarItemFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

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
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            ExportExcel(grdListagem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = -1
            sItemCompraFind = "S"
            oMaskedEditBoxFind = txtItemFiltro
            oForm.ShowDialog(Me)

            'Seta Focu
            txtItemFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

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

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub
     
    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control " & Me.Name)

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox        
            LoadCombo(cboStatusRequisicaoFiltro, "sp_select_combo_static_status_requisicao_compras")
            LoadCombo(cboRequisitanteFiltro, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadCombo(cboAprovadorFiltro, "sp_select_combo_administracao_usuario_administrador " & goUsuario.iEmpresa & ", " & Formulario.ComprasRequisicaoAprovar, False)

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

            'Seta Focu
            txtNumeroRequisicaoFiltro.Focus()

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

            'Váriaveis Locais
            Dim sStatus As String = ""

            'Status
            If cboStatusRequisicaoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusRequisicaoFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusRequisicaoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsCmpRequisicaoRelatorio.LoadGridRequisicao(grdListagem, _
                                                 IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1), _
                                                 sStatus, _
                                                 IIf(cboRequisitanteFiltro.SelectedIndex = -1, -1, cboRequisitanteFiltro.SelectedValue), _
                                                 IIf(cboAprovadorFiltro.SelectedIndex = -1, -1, cboAprovadorFiltro.SelectedValue), _
                                                 txtItemFiltro.Text.Trim, _
                                                 IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value), _
                                                 IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region
     
End Class


