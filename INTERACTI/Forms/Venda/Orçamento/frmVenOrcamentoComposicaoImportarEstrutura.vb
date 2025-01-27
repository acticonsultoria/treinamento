Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmVenOrcamentoComposicaoImportarEstrutura

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private oCurrentRow As GridEXRow
    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoOrcamento() As Long
        Get
            Return lCodigoOrcamento
        End Get
        Set(ByVal value As Long)
            lCodigoOrcamento = value
        End Set
    End Property

    Public Property CodigoOrcamentoItem() As Integer
        Get
            Return iCodigoOrcamentoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoOrcamentoItem = value
        End Set
    End Property

    Public Property Formulario() As Integer
        Get
            Return iFormulario
        End Get
        Set(ByVal value As Integer)
            iFormulario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                ' Case Keys.Escape : ConfigurarSizeGrid(False) : ConfigurarSizeGridMascara(False)
                Case Keys.Enter

                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then

                        If tabMain.SelectedTab.Key = pagOrcamento.Key Then
                            LoadGrid()
                        Else
                            LoadGridMascara()
                        End If

                    Else
                        Control_Enter(sender)
                    End If

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

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            If tabMain.SelectedTab.Key = pagOrcamento.Key Then
                ImportarComposicao()
            Else
                ImportarMascara()
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged, _
                                                                                                                                       grdMascara.RowCheckStateChanged

        Try

            'Verifica o Status da Linha
            If e.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = e.Row

            Else
                oCurrentRow = Nothing
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_SelectionChanged(sender As Object, e As EventArgs) Handles grdListagem.SelectionChanged

        Try

            'ConfigurarSizeGrid(False)

            If grdListagem.GetRows.Count <= 0 Then Exit Sub

            If grdListagem.CurrentRow.RowType <> RowType.Record Then Exit Sub

            Dim bExiste As Boolean

            Try

                If IsDBNull(grdListagem.GetValue("codigo_orcamento_item_grupo")) = False Then bExiste = True

            Catch ex As Exception
                bExiste = False
            End Try

            If bExiste = False Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            'ConfigurarSizeGrid(True)

            oClsVenOrcamentoLegado.LoadGridGrupoDetalhe(grdGrupo, _
                                                        grdListagem.GetValue("codigo_orcamento"), _
                                                        grdListagem.GetValue("codigo_orcamento_item"), _
                                                        grdListagem.GetValue("codigo_orcamento_item_grupo"))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdGrupo.ColumnMoved, _
                                                                                                                       grdMascara.ColumnMoved, _
                                                                                                                       grdMascaraGrupo.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdGrupo.SizingColumn, _
                                                                                                                        grdMascara.SizingColumn, _
                                                                                                                        grdMascaraGrupo.SizingColumn

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

    Private Sub grdMascara_SelectionChanged(sender As Object, e As EventArgs) Handles grdMascara.SelectionChanged

        Try

            'ConfigurarSizeGridMascara(False)

            If grdMascara.GetRows.Count <= 0 Then Exit Sub

            If grdMascara.CurrentRow.RowType <> RowType.Record Then Exit Sub

            Dim bExiste As Boolean

            Try

                If IsDBNull(grdMascara.GetValue("codigo_mascara_grupo")) = False Then bExiste = True

            Catch ex As Exception
                bExiste = False
            End Try

            If bExiste = False Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            'ConfigurarSizeGridMascara(True)

            oClsVenOrcamentoLegado.LoadGridGrupoDetalheMascara(grdMascaraGrupo, _
                                                               grdMascara.GetValue("codigo_mascara"), _
                                                               grdMascara.GetValue("codigo_mascara_grupo"))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrarMascara_Click(sender As Object, e As EventArgs) Handles btnFiltrarMascara.Click

        Try

            LoadGridMascara()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadMascaraOrcamento")

            LoadGridMascara()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub tabMain_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabMain.SelectedTabChanged

        Try

            If tabMain.SelectedTab.Key = pagMascaraOrcamento.Key Then
                btnNovo.Visible = True
                txtDescricaoFiltro.Focus()
            Else
                txtNumeroOrcamentoFiltro.Focus()
                btnNovo.Visible = False
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            LoadCombo(cboCodigoProdutoFiltro, "sp_select_combo_cadastro_basico_produto_producao " & goUsuario.iEmpresa, False)

            dtpDataOrcamentoInicioFiltro.Value = "01/" & Month(Now) & "/" & Year(Now) : dtpDataOrcamentoInicioFiltro.Checked = False
            dtpDataOrcamentoTerminoFiltro.Value = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, dtpDataOrcamentoInicioFiltro.Value)) : dtpDataOrcamentoTerminoFiltro.Checked = False

            ConfiguraGrid(grdListagem, -1)
            ConfiguraGrid(grdGrupo, iFormulario)
            ConfiguraGrid(grdMascara, iFormulario)
            ConfiguraGrid(grdMascaraGrupo, iFormulario)

            LoadGrid()
            LoadGridMascara()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ImportarComposicao()

        Try

            If grdListagem.GetCheckedRows.Count <= 0 Then
                MsgBox("Selecione alguma linha.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If MsgBox("Deseja Importar essa composição? Isso irá sobrescrever os dados existentes no orçamento.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            oClsVenOrcamentoLegado.ImportarComposicao(lCodigoOrcamento, _
                                                      iCodigoOrcamentoItem, _
                                                      oCurrentRow.Cells("codigo_orcamento").Value, _
                                                      oCurrentRow.Cells("codigo_orcamento_item").Value)

            'For Each oRow As GridEXRow In grdListagem.GetCheckedRows

            '    oClsVenOrcamentoLegado.ImportarComposicao(lCodigoOrcamento, _
            '                                              iCodigoOrcamentoItem, _
            '                                              oRow.Cells("codigo_orcamento").Value, _
            '                                              oRow.Cells("codigo_orcamento_item").Value)

            'Next

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Private Sub ConfigurarSizeGrid(ByVal bVisible As Boolean)

    '    Try

    '        If bVisible = False Then
    '            grdGrupo.Visible = False
    '            grdListagem.Size = New Size(pagOrcamento.Size.Width - 16, pagOrcamento.Size.Height - 16 - grpFiltro.Size.Height)
    '        Else
    '            grdGrupo.Visible = True
    '            grdListagem.Size = New Size(grdGrupo.Size.Width, grdGrupo.Location.Y - 83)
    '        End If

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Private Sub ConfigurarSizeGridMascara(ByVal bVisible As Boolean)

    '    Try

    '        If bVisible = False Then
    '            grdMascaraGrupo.Visible = False
    '            grdMascara.Size = New Size(pagMascaraOrcamento.Size.Width - 16, pagMascaraOrcamento.Size.Height - 16 - grpFiltroMascara.Size.Height)
    '        Else
    '            grdMascaraGrupo.Visible = True
    '            grdMascara.Size = New Size(grdMascaraGrupo.Size.Width, grdMascaraGrupo.Location.Y - 83)
    '        End If

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.LoadGridImportarComposicao(grdListagem, _
                                                              lCodigoOrcamento, _
                                                              iCodigoOrcamentoItem, _
                                                              IIf(IsNumeric(txtNumeroOrcamentoFiltro.Text), txtNumeroOrcamentoFiltro.Text, -1), _
                                                              IIf(cboCodigoProdutoFiltro.SelectedIndex = -1, -1, cboCodigoProdutoFiltro.SelectedValue), _
                                                              IIf(dtpDataOrcamentoInicioFiltro.Checked = False, "", dtpDataOrcamentoInicioFiltro.Value), _
                                                              IIf(dtpDataOrcamentoTerminoFiltro.Checked = False, "", dtpDataOrcamentoTerminoFiltro.Value))

            'ConfigurarSizeGrid(False)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarMascara()

        Try

            If grdMascara.GetCheckedRows.Count <= 0 Then
                MsgBox("Selecione alguma linha.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If MsgBox("Deseja Importar essa máscara? Isso irá sobrescrever os dados existentes no orçamento.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            oClsVenOrcamentoLegado.ImportarMascara(lCodigoOrcamento, _
                                                   iCodigoOrcamentoItem, _
                                                   oCurrentRow.Cells("codigo").Value)

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridMascara()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.LoadGridImportarMascara(grdMascara, _
                                                           txtDescricaoFiltro.Text.Trim)

            'ConfigurarSizeGridMascara(False)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class