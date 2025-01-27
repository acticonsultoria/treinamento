Imports System.IO
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo
Imports System.Math

Public Class usrCmpAprovacaoSuperiorContrato

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCmpAprovacaoContrato As New clsUsrCmpAprovacaoContrato

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

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "aprovar" : Call Aprovar()
                Case "cancelar" : Call Cancelar()

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

            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataInicioTerminoFiltro.Value = Now.Date : dtpDataInicioTerminoFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False
            dtpDataTerminoInicioFiltro.Value = Now.Date : dtpDataTerminoInicioFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoContrato)
            Call LoadComboSimNao(cboAtivoFiltro)

            'Carrega ComboBox
            cboTipoTituloFiltro.Items.Add("RECEITA", "R")
            cboTipoTituloFiltro.Items.Add("DESPESA", "D")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoAprovacaoSuperior)


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

            'Seta Parametros
            oClsUsrCmpAprovacaoContrato.LoadGridAprovacaoSuperior(grdListagem, _
                                                 IIf(IsNumeric(txtNumeroContratoFiltro.Text.Trim), txtNumeroContratoFiltro.Text.Trim, -1), _
                                                 txtParceiroNegocioFiltro.Text.Trim, _
                                                 IIf(cboTipoTituloFiltro.SelectedIndex = -1, "", cboTipoTituloFiltro.SelectedValue), _
                                                 IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                                 IIf(dtpDataInicioTerminoFiltro.Checked = False, "", dtpDataInicioTerminoFiltro.Value), _
                                                 IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                                 IIf(dtpDataTerminoInicioFiltro.Checked = False, "", dtpDataTerminoInicioFiltro.Value), _
                                                 txtDiaVencimentoFiltro.Text, _
                                                 IIf(cboAtivoFiltro.SelectedIndex = -1, -1, cboAtivoFiltro.SelectedValue), _
                                                 txtDescricaoFiltro.Text.Trim)

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

    Private Sub Cancelar()

        Try

            If grdListagem.CurrentRow.Cells.Item("alcada").Value = True Then
                MsgBox("Pedido fora da sua alçada de aprovação!", vbExclamation, "Alçada")
                Exit Sub
            End If

            If MsgBox("Deseja Cancelar o Contrato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Aprova Pedido
                Call oClsUsrCmpAprovacaoContrato.CancelarContrato(grdListagem.CurrentRow.Cells("codigo").Value)

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

            If grdListagem.CurrentRow.Cells.Item("alcada").Value = True Then
                MsgBox("Pedido fora da sua alçada de aprovação!", vbExclamation, "Alçada")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Reaprovar o Pedido de Compra
            If MsgBox("Deseja aprovar o contrato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Aprova Pedido
                Call oClsUsrCmpAprovacaoContrato.AprovarContrato(grdListagem.CurrentRow.Cells("codigo").Value)

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


