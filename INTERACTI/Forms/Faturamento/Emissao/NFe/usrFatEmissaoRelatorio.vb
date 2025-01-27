Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFatEmissaoRelatorio

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoRelatorio As New clsUsrFatEmissaoRelatorio
    Private lCodigoEmissaoCapa As Long

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFatEmissaoRelatorio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrFatEmissaoRelatorio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoVenda.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedidoVenda.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedidoVenda.GroupByBoxVisible = True
                grdPedidoVenda.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoVenda
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoRelatorio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPedidoVenda, Formulario.FaturamentoEmissaoRelatorio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
        
    Private Sub grdPedidoVenda_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoVenda.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda, _
                                     Formulario.FaturamentoEmissaoRelatorio)
             
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoVenda.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda.Name, _
                                     Formulario.FaturamentoEmissaoRelatorio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)
             
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoVenda.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoVenda.Name, _
                                          Formulario.FaturamentoEmissaoRelatorio, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"
     
    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEmissaoRelatorio_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nota_fiscal " & CInt(TipoNotaFiscal.NotaFiscalEletronica))
            Call LoadCombo(cboTipoDocumenoFiscalFiltro, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)
            Call LoadCombo(cboDestinatarioFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
              
            'Configura Grid
            Call ConfiguraGrid(grdPedidoVenda, Formulario.FaturamentoEmissaoRelatorio)

            dtpDataEmissaoInicioFiltro.Value = Now.Date
            dtpDataEmissaoTerminoFiltro.Value = Now.Date

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
     
    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()
             
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sCFOP As String = ""
            Dim sStatus As String = ""

            'CFOP
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOP &= IIf(sCFOP = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid de Pedido de Venda
            Call oClsFatEmissaoRelatorio.LoadGrid(grdPedidoVenda, _
                                                  IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                                  IIf(cboDestinatarioFiltro.SelectedIndex = -1, -1, cboDestinatarioFiltro.SelectedValue), _
                                                  IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                  IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                  txtProdutoFiltro.Text.Trim, _
                                                  IIf(cboTipoDocumenoFiscalFiltro.SelectedIndex = -1, -1, cboTipoDocumenoFiscalFiltro.SelectedValue), _
                                                  sCFOP, _
                                                  sStatus)

            'Atualiza Grid
            grdPedidoVenda.Refresh()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
     
#End Region

End Class