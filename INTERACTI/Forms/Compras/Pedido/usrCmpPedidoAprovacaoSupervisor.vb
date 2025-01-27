Imports System.IO
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo
Imports System.Math

Public Class usrCmpPedidoAprovacaoSupervisor

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCmpPedidoReaprovar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrCmpPedidoReaprovar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PEDIDO COMPRA :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ComprasPedidoAprovacaoSuperior
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoAprovacaoSuperior)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtItemFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

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

            LoadGrid()

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

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "aprovar" : Call Aprovar()
                Case "reprovar" : Call Reprovar()
                Case "historico" : Call LoadHistorico()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComprasPedidoAprovacaoSuperior)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComprasPedidoAprovacaoSuperior, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.ComprasPedidoAprovacaoSuperior, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpPedidoReaprovar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox            
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboRequisitanteFiltro, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)

            'Configura DateTimer
            dtpDataPedidoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoAprovacaoSuperior)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO COMPRA :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sDestinacaoFiltro As String = ""
            Dim sRequerente As String = ""
            Dim sStatus As String = ""
            Dim sGrupoItem As String = ""
            Dim i As Integer

            'Requerente
            If cboRequisitanteFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboRequisitanteFiltro.CheckedValues)
                    sRequerente &= IIf(sRequerente = "", "", ",") & cboRequisitanteFiltro.CheckedValues(i).ToString
                Next
            End If

            'Grupo de Item
            If cboGrupoItemFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboGrupoItemFiltro.CheckedValues)
                    sGrupoItem &= IIf(sGrupoItem = "", "", ",") & cboGrupoItemFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsCmpPedido.LoadGridPedidoAprovacaoSupervisor(grdListagem, _
                                                  IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                                  IIf(dtpDataPedidoInicioFiltro.Checked = False, "", dtpDataPedidoInicioFiltro.Value), _
                                                  IIf(dtpDataPedidoTerminoFiltro.Checked = False, "", dtpDataPedidoTerminoFiltro.Value), _
                                                  txtFornecedorFiltro.Text.Trim, _
                                                  IIf(cboFollowUpFitro.SelectedIndex = -1, -1, IIf(cboFollowUpFitro.SelectedValue = True, 1, 0)), _
                                                  sRequerente, _
                                                  txtReferenciaFiltro.Text.Trim, _
                                                  txtNumeroCotacaoFiltro.Text.Trim, _
                                                  txtItemFiltro.Text.Trim, _
                                                  sGrupoItem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadHistorico()

        Try

            'Variável - Formulário
            Dim oForm As New frmCmpPedidoHistoricoAlteracao

            'Seta Tamanho e Posição do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Parâmetros
            oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
            oForm.DataPedido = grdListagem.CurrentRow.Cells("data_pedido").Value
            oForm.Fornecedor = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
            oForm.CodigoPedido = grdListagem.CurrentRow.Cells("codigo_pedido").Value

            'Abre o Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Reprovar()

        Try

            If MsgBox("Deseja Reprovar o Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Aprova Pedido
                Call oClsCmpPedido.ReprovacaoSupervisor(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega Grid
                Call LoadGrid()

            End If

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Aprovar()

        Try

            'Verifica se o Usuário deseja Reaprovar o Pedido de Compra
            If MsgBox("Deseja Reaprovar o Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then


                Call oClsCmpPedido.AprovarSuperior(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


