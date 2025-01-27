Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo
Public Class frmFindNotaFiscalAtivoImobilizado

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadAtivoFixo As New clsUsrCadAtivoImobilizado

    Private otxtIdentificacao As MaskedEditBox
    Private otxtNumeroDocumento As MaskedEditBox
    Private odtpDataEntrada As CalendarCombo
    Private otxtFornecedor As MaskedEditBox
    Private otxtCNPJCPFFornecedor As MaskedEditBox
    Private otxtChaveAcesso As MaskedEditBox
    Private otxtArquivoAnexoDocumento As MaskedEditBox
    Private otxtNumeroDI As MaskedEditBox
    Private otxtNCM As MaskedEditBox
    Private otxtCustoBruto As NumericEditBox
    Private otxtValorFrete As NumericEditBox
    Private otxtValorICMS As NumericEditBox
    Private otxtValorIPI As NumericEditBox
    Private otxtValorPIS As NumericEditBox
    Private otxtValorCOFINS As NumericEditBox
    Private otxtCustoLiquido As NumericEditBox


#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property txtIdentificacao As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtIdentificacao = value
        End Set
    End Property
    Public WriteOnly Property txtNumeroDocumento As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtNumeroDocumento = value
        End Set
    End Property
    Public WriteOnly Property dtpDataEntrada As CalendarCombo
        Set(value As CalendarCombo)
            odtpDataEntrada = value
        End Set
    End Property
    Public WriteOnly Property txtFornecedor As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtFornecedor = value
        End Set
    End Property
    Public WriteOnly Property txtCNPJCPFFornecedor As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtCNPJCPFFornecedor = value
        End Set
    End Property
    Public WriteOnly Property txtChaveAcesso As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtChaveAcesso = value
        End Set
    End Property
    Public WriteOnly Property txtArquivoAnexoDocumento As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtArquivoAnexoDocumento = value
        End Set
    End Property

    Public WriteOnly Property txtNumeroDI As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtNumeroDI = value
        End Set
    End Property
    Public WriteOnly Property txtNCM As MaskedEditBox
        Set(value As MaskedEditBox)
            otxtNCM = value
        End Set
    End Property
    Public WriteOnly Property txtCustoBruto As NumericEditBox
        Set(value As NumericEditBox)
            otxtCustoBruto = value
        End Set
    End Property
    Public WriteOnly Property txtValorFrete As NumericEditBox
        Set(value As NumericEditBox)
            otxtValorFrete = value
        End Set
    End Property
    Public WriteOnly Property txtValorICMS As NumericEditBox
        Set(value As NumericEditBox)
            otxtValorICMS = value
        End Set
    End Property
    Public WriteOnly Property txtValorIPI As NumericEditBox
        Set(value As NumericEditBox)
            otxtValorIPI = value
        End Set
    End Property
    Public WriteOnly Property txtValorPIS As NumericEditBox
        Set(value As NumericEditBox)
            otxtValorPIS = value
        End Set
    End Property
    Public WriteOnly Property txtValorCOFINS As NumericEditBox
        Set(value As NumericEditBox)
            otxtValorCOFINS = value
        End Set
    End Property
    Public WriteOnly Property txtCustoLiquido As NumericEditBox
        Set(value As NumericEditBox)
            otxtCustoLiquido = value
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
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub grdFind_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFind.RowDoubleClick

        Try

            If grdFind.CurrentColumn.Key = "importar" Then

                With grdFind.CurrentRow.Cells

                    otxtIdentificacao.Text = .Item("descricao").Value
                    otxtNumeroDocumento.Text = .Item("numero_documento").Value
                    odtpDataEntrada.Value = .Item("data_documento").Value
                    otxtFornecedor.Text = .Item("fornecedor").Value
                    otxtCNPJCPFFornecedor.Text = .Item("cnpj_cpf_fornecedor").Value
                    otxtChaveAcesso.Text = .Item("chave_acesso").Value
                    otxtArquivoAnexoDocumento.Text = .Item("arquivo_anexo_documento").Value
                    otxtNumeroDI.Text = .Item("numero_di").Value
                    otxtNCM.Text = .Item("ncm").Value
                    otxtCustoBruto.Value = .Item("custo_bruto_unitario").Value
                    otxtValorFrete.Value = .Item("valor_frete").Value
                    otxtValorICMS.Value = .Item("valor_icms").Value
                    otxtValorIPI.Value = .Item("valor_ipi").Value
                    otxtValorPIS.Value = .Item("valor_pis").Value
                    otxtValorCOFINS.Value = .Item("valor_cofins").Value
                    otxtCustoLiquido.Value = .Item("custo_liquido_unitario").Value
                    otxtNumeroDocumento.Tag = .Item("codigo_emissao_capa").Value
                    odtpDataEntrada.Tag = .Item("codigo_emissao_item").Value
                    otxtFornecedor.Tag = .Item("codigo_entrada_capa").Value
                    otxtNCM.Tag = .Item("codigo_entrada_item").Value

                End With

                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            Dim sCFOP As String = ""

            'CFOP
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOP &= IIf(sCFOP = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            'Configura Grid
            oClsUsrCadAtivoFixo.LoadGridFindNFAtivo(grdFind, _
                                                    txtNotaFiscalFiltro.Text.Trim, _
                                                    txtEmitenteFiltro.Text.Trim, _
                                                    IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                    IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                    txtProdutoFiltro.Text.Trim, _
                                                    sCFOP)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            dtpDataEmissaoInicioFiltro.Checked = True
            dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEmissaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now)
            dtpDataEmissaoTerminoFiltro.Value = Now

            'Configura Grid
            ConfiguraGrid(grdFind, Formulario.FindCadastroBasicoAtivoImobilizado)

            LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)

            'Seta Focu
            grdFind.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class
