Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoImportarOrdemProducao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
    Private lCodigoOrdemProducao As Long
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public WriteOnly Property CodigoOrdemProducao As Long
        Set(value As Long)
            lCodigoOrdemProducao = value
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


    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            ImportarOP()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "importar" : ImportarEstrutura()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub chkMarcarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarcarTodos.CheckedChanged

        Try

            If chkMarcarTodos.Text = "Desmarcar Todos" Then
                chkImportarEstruturaProduto.Checked = False
                chkImportarListaMaterial.Checked = False
                chkImportarProcessoProdutivo.Checked = False
                chkImportarServicoExterno.Checked = False

                chkMarcarTodos.Text = "Marcar Todos"

            Else

                chkImportarEstruturaProduto.Checked = True
                chkImportarListaMaterial.Checked = True
                chkImportarProcessoProdutivo.Checked = True
                chkImportarServicoExterno.Checked = True

                chkMarcarTodos.Text = "Desmarcar Todos"

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboImportarEstrutura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImportarEstrutura.SelectedIndexChanged

        Try

            If cboImportarEstrutura.SelectedValue = True Then

                btnImportar.Visible = False

                For Each oColumn As GridEXColumn In grdListagem.RootTable.Columns

                    If oColumn.Key = "importar" Then
                        oColumn.Visible = True
                    End If

                    If oColumn.Key = "x" Then
                        oColumn.Visible = False
                    End If

                Next

            Else

                btnImportar.Visible = True

                For Each oColumn As GridEXColumn In grdListagem.RootTable.Columns

                    If oColumn.Key = "importar" Then
                        oColumn.Visible = False
                    End If

                    If oColumn.Key = "x" Then
                        oColumn.Visible = True
                    End If

                Next

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
            LoadComboSimNao(cboImportarEstrutura)
            cboImportarEstrutura.SelectedValue = 1

            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now) : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now : dtpDataTerminoFiltro.Checked = False

            chkImportarEstruturaProduto.Checked = True
            chkImportarListaMaterial.Checked = True
            chkImportarProcessoProdutivo.Checked = True
            chkImportarServicoExterno.Checked = True

            ConfiguraGrid(grdListagem, iFormulario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridImportarOrdemProducao(grdListagem,
                                                                   lCodigoOrdemProducao, _
                                                                   txtOrdemProducaoFiltro.Text.Trim, _
                                                                   IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                                                   IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                                                   IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarOP()

        Try

            Cursor.Current = Cursors.WaitCursor

            If MsgBox("Deseja importar as ordens selecionadas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            For Each oRow In grdListagem.GetCheckedRows

                oClsUsrPrdProducaoManual.InsertOrdemProducaoImportacao(lCodigoOrdemProducao,
                                                                       oRow.Cells.Item("codigo").Value,
                                                                       chkImportarProcessoProdutivo.Checked,
                                                                       chkImportarEstruturaProduto.Checked,
                                                                       chkImportarListaMaterial.Checked,
                                                                       chkImportarServicoExterno.Checked)
            Next

            Me.Dispose()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ImportarEstrutura()

        Try

            Cursor.Current = Cursors.WaitCursor

            If MsgBox("Deseja importar a Estrutura de OPs selecionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            oClsUsrPrdProducaoManual.InsertOrdemProducaoImportacaoEstrutura(lCodigoOrdemProducao,
                                                                            grdListagem.GetValue("codigo"),
                                                                            chkImportarProcessoProdutivo.Checked,
                                                                            chkImportarEstruturaProduto.Checked,
                                                                            chkImportarListaMaterial.Checked,
                                                                            chkImportarServicoExterno.Checked)

            Me.Dispose()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region


End Class