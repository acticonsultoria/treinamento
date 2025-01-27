Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo
Public Class frmFindNotaFiscalAtivoImobilizadoAcessorio

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadAtivoFixo As New clsUsrCadAtivoImobilizado

    Private lCodigoAtivo As Long


#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoAtivo() As Long
        Get
            Return lCodigoAtivo
        End Get
        Set(ByVal value As Long)
            lCodigoAtivo = value
        End Set
    End Property


#End Region

#Region "::: CONTROLES :::"

    Private Sub frmKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If Not grdFind.CurrentRow Is Nothing Then
                        Me.Dispose()
                    End If

                Case Keys.Escape
                    'Deleta Aba
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFind
            oForm.NomeFormulario = Formulario.FindCadastroBasicoAtivoImobilizado
            'Abre Formulário
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdFind, Formulario.FindCadastroBasicoAtivoImobilizado)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

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
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            Dim sCFOP As String = ""

            'CFOP
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOP &= IIf(sCFOP = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            oClsUsrCadAtivoFixo.LoadGridFindNFAtivoAcessorio(grdFind, _
                                                             txtNotaFiscalFiltro.Text.Trim, _
                                                             txtEmitenteFiltro.Text.Trim, _
                                                             IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                             IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                             txtProdutoFiltro.Text.Trim, _
                                                             sCFOP)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            For Each oRow As GridEXRow In grdFind.GetCheckedRows

                oClsUsrCadAtivoFixo.ChangeCusto(-1, _
                                                lCodigoAtivo, _
                                                oRow.Cells.Item("tipo").Value, _
                                                oRow.Cells.Item("numeracao").Value, _
                                                oRow.Cells.Item("numero_patrimonial").Value, _
                                                oRow.Cells.Item("chapa_identificacao").Value, _
                                                oRow.Cells.Item("descricao").Value, _
                                                oRow.Cells.Item("numero_documento").Value, _
                                                oRow.Cells.Item("data_documento").Value, _
                                                oRow.Cells.Item("fornecedor").Value, _
                                                oRow.Cells.Item("cnpj_cpf_fornecedor").Value, _
                                                oRow.Cells.Item("chave_acesso").Value, _
                                                oRow.Cells.Item("arquivo_anexo_documento").Value, _
                                                oRow.Cells.Item("custo_bruto_unitario").Value, _
                                                oRow.Cells.Item("valor_frete").Value, _
                                                oRow.Cells.Item("valor_icms").Value, _
                                                oRow.Cells.Item("valor_ipi").Value, _
                                                oRow.Cells.Item("valor_pis").Value, _
                                                oRow.Cells.Item("valor_cofins").Value, _
                                                oRow.Cells.Item("custo_liquido_unitario").Value, _
                                                oRow.Cells.Item("quantidade").Value, _
                                                oRow.Cells.Item("custo_total").Value, _
                                                oRow.Cells.Item("codigo_entrada_capa").Value, _
                                                oRow.Cells.Item("codigo_emissao_capa").Value, _
                                                oRow.Cells.Item("codigo_entrada_item").Value, _
                                                oRow.Cells.Item("codigo_emissao_item").Value, _
                                                oRow.Cells.Item("codigo_nfs_capa").Value)
            Next

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

  
    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFind.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdFind.Name, _
                                Formulario.FindCadastroBasicoAtivoImobilizado, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFind.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdFind, _
                                Formulario.FindCadastroBasicoAtivoImobilizado)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdFind_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFind.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(grdFind.Name, _
                                     Formulario.FindCadastroBasicoAtivoImobilizado, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Configura Grid
            ConfiguraGrid(grdFind, Formulario.FindCadastroBasicoAtivoImobilizado)

            dtpDataEmissaoInicioFiltro.Checked = True
            dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEmissaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now)
            dtpDataEmissaoTerminoFiltro.Value = Now

            LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            LoadComboGrid(grdFind, "tipo", "sp_select_combo_static_tipo_custo_ativo")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region
    
End Class
