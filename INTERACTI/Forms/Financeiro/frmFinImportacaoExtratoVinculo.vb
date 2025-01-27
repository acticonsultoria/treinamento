Imports Janus.Windows.GridEX

Public Class frmFinImportacaoExtratoVinculo

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsFinImportacaoExtratoVinculo As New clsFrmFinImportacaoExtratoVinculo
    Private iCodigoImportacaoExtrato As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

    Public Property CodigoImportacaoExtrato() As Integer
        Get
            Return iCodigoImportacaoExtrato
        End Get
        Set(ByVal value As Integer)
            iCodigoImportacaoExtrato = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"
 
    Private Sub btnVincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVincular.Click

        Try
            If VerificaSelecaoRow(grdVinculo) = True Then

                'Carrega Dados da Grid
                Call Inserir()

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, "")
            End If
            
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboVinculado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVinculado.SelectedIndexChanged

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDocumento.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados do Registro
            Call CadastrarDocumento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub frmFinImportacaoExtratoVinculo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdVinculo.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdVinculo.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdVinculo.GroupByBoxVisible = True
                grdVinculo.HideColumnsWhenGrouped = InheritableBoolean.True

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
            oForm.Grid = grdVinculo
            oForm.NomeFormulario = Formulario.FinanceiroImportarExtratoVinculo
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdVinculo, Formulario.FinanceiroImportarExtratoVinculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdVinculo)

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

    Private Sub grdVinculo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdVinculo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVinculo, _
                                     Formulario.FinanceiroImportarExtratoVinculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdVinculo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdVinculo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVinculo.Name, _
                                     Formulario.FinanceiroImportarExtratoVinculo, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdVinculo_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdVinculo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdVinculo.Name, _
                                          Formulario.FinanceiroImportarExtratoVinculo, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub chkData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkData.CheckedChanged

        If chkData.Checked = True Then
            txtDataCriterio.Enabled = True
        Else
            txtDataCriterio.Enabled = False
        End If

    End Sub

    Private Sub chkValor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkValor.CheckedChanged

        If chkValor.Checked = True Then
            txtValorCriterio.Enabled = True
        Else
            txtValorCriterio.Enabled = False
        End If

    End Sub

    Private Sub grdVinculo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdVinculo.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdVinculo.CurrentColumn) Then Exit Sub

            Select Case grdVinculo.CurrentColumn.Key

                Case "ok" : Call Inserir()
                Case "editar_parcela" : Call EditarParcela()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub EditarParcela()

        Try

            glCodigoEditar = grdVinculo.CurrentRow.Cells.Item("codigo_titulo_capa").Value

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrFinReclassificacaoValor")

            glCodigoEditar = -1

            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CadastrarDocumento()

        Try

            Dim oForm As New frmFinImportacaoExtratoCadastrarDocumento

            oForm.txtNumeroDocumento.Text = txtNumeroDocumento.Text
            oForm.txtDescricao.Text = txtDescricao.Text
            oForm.txtDataEmissao.Text = txtDataEmissao.Text
            oForm.txtValor.Text = txtValor.Text
            oForm.txtTipo.Text = txtTipo.Text
            oForm.Grid = oGrid
            oForm.txtDescritivo.Text = txtDescricao.Text
            oForm.CodigoImportacaoExtrato = iCodigoImportacaoExtrato

            Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
            If (oForm.Cadastro = True) Then

                Me.Dispose()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Ícone
            Me.Icon = frmMain.Icon

            chkData.Checked = False
            txtDataCriterio.Enabled = False
            txtValorCriterio.Enabled = False
            txtDataCriterio.Text = 1

            Call LoadCombo(cboTituloFinanceiro, "sp_select_combo_static_tipo_titulo_financeiro ")
            Call LoadCombo(cboBancoContaTransferencia, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadComboSimNao(cboVinculado)

            'Configura a grid
            ConfiguraGrid(grdVinculo, Me.ToString)

            cboVinculado.SelectedIndex = 1

            'Seta o valor padrão
            cboTituloFinanceiro.SelectedValue = TipoTituloFinanceiro.Real
            'cboVinculado.SelectedValue = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            grdVinculo.DataSource = Nothing

            'Carrega Controles
            oClsFinImportacaoExtratoVinculo.LoadGrid(grdVinculo, _
                                                     txtTipo.Text, _
                                                     txtValor.Text, _
                                                     txtValorCriterio.Text, _
                                                     txtDataEmissao.Text, _
                                                     txtDataCriterio.Text, _
                                                     cboTituloFinanceiro.SelectedValue, _
                                                     chkData.Checked, _
                                                     chkValor.Checked, _
                                                     IIf(cboVinculado.SelectedIndex = -1, -1, IIf(cboVinculado.SelectedIndex = 1, 0, IIf(cboVinculado.SelectedIndex = 0, 1, -1))), _
                                                     IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                     IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""))


            'Carrega Combo da Grid
            Call LoadComboGrid(grdVinculo, "centro_custo", "sp_select_combo_cadastro_basico_centro_custo_extrato " & goUsuario.iEmpresa & ", -1, -1")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Inserir()

        Try
            If cboVinculado.SelectedValue = 0 Then

                Dim sTexto As String = ""
                Dim sCodigo As String = ""
                Dim sCodigoCentroCusto As String = ""

                For Each oRow In grdVinculo.GetCheckedRows

                    sTexto += IIf(sTexto = "", "", vbCrLf) + CStr(oRow.Cells.Item("numero_documento").Value) + "|" + CStr(oRow.Cells.Item("numero_parcela").Value) + "-" + oRow.Cells.Item("parceiro_negocio").Value
                    sCodigo += IIf(sCodigo = "", "", ";") + CStr(oRow.Cells.Item("codigo_titulo_capa").Value) + "|" + CStr(oRow.Cells.Item("numero_parcela").Value)
                    sCodigoCentroCusto += IIf(sCodigoCentroCusto = "", "", ";") + CStr(IIf(IsDBNull(oRow.Cells.Item("centro_custo").Value), "", oRow.Cells.Item("centro_custo").Value))

                Next

                oGrid.SetValue("documento_referencia_texto", sTexto)
                oGrid.SetValue("documento_referencia", IIf(sCodigo = "", DBNull.Value, sCodigo))
                oGrid.SetValue("centro_custo", IIf(sCodigoCentroCusto = "", DBNull.Value, sCodigoCentroCusto))

                If cboBancoContaTransferencia.SelectedIndex <> -1 Then
                    oGrid.SetValue("codigo_banco_conta_transferencia", cboBancoContaTransferencia.SelectedValue)
                    oGrid.SetValue("banco_conta_transferencia", cboBancoContaTransferencia.Text)
                Else
                    oGrid.SetValue("codigo_banco_conta_transferencia", DBNull.Value)
                    oGrid.SetValue("banco_conta_transferencia", DBNull.Value)
                End If
                oGrid.Refresh()
                Me.Dispose()

            Else

                Call TratamentoErro("Este registro já foi vinculado.", "")

            End If
        Catch ex As Exception
            Throw ex
        End Try
    
    End Sub

#End Region

    Private Sub grdVinculo_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdVinculo.RowCheckStateChanged

        'Try
        '    'Seta Cursor do Mouse
        '    Cursor.Current = Cursors.WaitCursor

        '    'Verifica se Foi Selecionado Registro
        '    If VerificaSelecaoRow(grdVinculo) = True Then

        '        'Verifica se Existe Código Título
        '        If IIf(IsDBNull(grdVinculo.CurrentRow.Cells("codigo_titulo_capa").Value), 0, grdVinculo.CurrentRow.Cells("codigo_titulo_capa").Value) > 0 Then

        '            'Percorre cada Linha Selecionada
        '            For Each oRow In grdVinculo.GetCheckedRows

        '                'Carrega Combo da Grid
        '                Call LoadComboGrid(grdVinculo, "centro_custo", "sp_select_combo_cadastro_basico_centro_custo_extrato " & goUsuario.iEmpresa & ", -1, " & oRow.Cells.Item("codigo_titulo_capa").Value)

        '            Next

        '        End If
        '    End If

        '    'Seta Cursor do Mouse
        '    Cursor.Current = Cursors.Default


        'Catch ex As Exception
        '    'Trata Erro
        '    Call TratamentoErro(ex.Message, Me.Text)
        'End Try
    End Sub

End Class