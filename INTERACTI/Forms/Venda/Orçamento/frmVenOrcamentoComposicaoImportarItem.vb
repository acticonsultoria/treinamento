Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmVenOrcamentoComposicaoImportarItem

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private oCurrentRow As GridEXRow
    Private lCodigoOrcamento As Long
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

                Case Keys.Escape : Me.Dispose()
                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            If MsgBox("Deseja confirmar a operação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            ImportarItem()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub chkMarcarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarcarTodos.CheckedChanged

        Try

            If chkMarcarTodos.Text = "Desmarcar Todos" Then
                chkAtualizarAliquotaImpostos.Checked = False
                chkAtualizarDespesaFixa.Checked = False
                chkAtualizarMargemLucro.Checked = False
                chkAtualizarValorCustoHoras.Checked = False

                chkMarcarTodos.Text = "Marcar Todos"

            Else

                chkAtualizarAliquotaImpostos.Checked = True
                chkAtualizarDespesaFixa.Checked = True
                chkAtualizarMargemLucro.Checked = True
                chkAtualizarValorCustoHoras.Checked = True

                chkMarcarTodos.Text = "Desmarcar Todos"

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

            LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            dtpDataOrcamentoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now) : dtpDataOrcamentoInicioFiltro.Checked = True
            dtpDataOrcamentoTerminoFiltro.Value = Now : dtpDataOrcamentoTerminoFiltro.Checked = False

            chkAtualizarAliquotaImpostos.Checked = True
            chkAtualizarDespesaFixa.Checked = True
            chkAtualizarValorCustoHoras.Checked = True
            chkAtualizarMargemLucro.Checked = True

            ConfiguraGrid(grdOrcamentoComposicaoImportarItem, iFormulario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridImportarItem(grdOrcamentoComposicaoImportarItem,
                                                           lCodigoOrcamento,
                                                           IIf(IsNumeric(txtNumeroOrcamentoFiltro.Text.Trim), txtNumeroOrcamentoFiltro.Text.Trim, -1),
                                                           IIf(dtpDataOrcamentoInicioFiltro.Checked = False, "", dtpDataOrcamentoInicioFiltro.Value),
                                                           IIf(dtpDataOrcamentoTerminoFiltro.Checked = False, "", dtpDataOrcamentoTerminoFiltro.Value),
                                                           IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue),
                                                           txtNumeroOrdemProducao.text.trim)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Importar()

        Try



            frmMain.Informacao(Mensagem.RegistroAlterado)

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarItem()

        Try

            Cursor.Current = Cursors.WaitCursor

            For Each oRow As GridEXRow In grdOrcamentoComposicaoImportarItem.GetCheckedRows

                oClsUsrVenOrcamentoLegado.ImportarItemOrcamento(lCodigoOrcamento, _
                                                                oRow.Cells("codigo_orcamento").Value, _
                                                                oRow.Cells("codigo_orcamento_item").Value, _
                                                                chkAtualizarDespesaFixa.Checked, _
                                                                chkAtualizarAliquotaImpostos.Checked, _
                                                                chkAtualizarMargemLucro.Checked)

                Dim iCodigoOrcamentoItem As Integer = LoadCodigo("sp_load_venda_orcamento_item_codigo_novo_pai " & lCodigoOrcamento & "," & goUsuario.iEmpresa)

                oClsUsrVenOrcamentoLegado.UpdateValoresPai(lCodigoOrcamento, _
                                                           iCodigoOrcamentoItem)

            Next

            Me.Dispose()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

End Class