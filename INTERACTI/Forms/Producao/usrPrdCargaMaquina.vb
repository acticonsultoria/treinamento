Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrPrdCargaMaquina


#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrdCargaMaquina As New clsUsrPrdCargaMaquina
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try


            ExportExcel(grdNecessidade)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try

            Call LoadGrid()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.name, _
                                     iFormulario)



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.Name, _
                                     iFormulario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirOrcamento_Click(sender As Object, e As EventArgs) Handles btnInserirOrcamento.Click
        Try
            InserirOrcamento()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub cboOrcamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrcamento.SelectedIndexChanged
        Try

            If cboOrcamento.SelectedIndex = -1 Then Exit Sub

            dtpDataEntregaOrcamento.Value = LoadCodigo("sp_select_venda_orcamento_data_entrega " & cboOrcamento.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub grdOrcamento_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOrcamento.RowDoubleClick
        Try
            ExcluirOrcamento()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub


    Private Sub grdCargaMaquina_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdCargaMaquina.CellValueChanged
        Try

            grdCargaMaquina.SetValue("disponibilidade_diaria", _
                                     grdCargaMaquina.GetValue("horas_turno1") +
                                     grdCargaMaquina.GetValue("horas_turno2") +
                                     grdCargaMaquina.GetValue("horas_turno3"))

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            ConfiguraGrid(grdNecessidade, iFormulario)
            ConfiguraGrid(grdCargaMaquina, iFormulario)
            ConfiguraGrid(grdDisponibilidade, iFormulario)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao 1")
            Call LoadCombo(cboOrcamento, "sp_select_combo_venda_orcamento_orcamento_cenario_planejamento " & goUsuario.iEmpresa)


            dtpDataInicioFiltro.Value = Now
            dtpDataTerminoFiltro.Value = Now
            dtpDataEntregaInicio.Value = Now
            dtpDataEntregaTermino.Value = Now

            Dim oClasse As New clsUsrPrdCenario
            oClasse.LoadGridOrcamento(grdOrcamento, -2)

            oClsUsrPrdCargaMaquina.LoadGridMaquina(grdDisponibilidade)

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

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


            Dim sOrcamento As String = ""

            For Each oRow In grdOrcamento.GetRows

                sOrcamento += IIf(sOrcamento = "", "", ",") + CStr(oRow.Cells.Item("codigo").Value)

            Next

            Dim sStatus As String = ""

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid de Insumo
            oClsUsrPrdCargaMaquina.LoadGrid(grdNecessidade, _
                                            grdDisponibilidade, _
                                            grdCargaMaquina, _
                                            sStatus, _
                                            chkIncluirSabado.Checked, _
                                            chkIncluirDomingo.Checked, _
                                            sOrcamento, _
                                            IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                            IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""), _
                                            IIf(dtpDataEntregaInicio.Checked = True, dtpDataEntregaInicio.Value, ""), _
                                            IIf(dtpDataEntregaTermino.Checked = True, dtpDataEntregaTermino.Value, ""), _
                                            txtOrdemProducaoDesconsiderar.Text)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirOrcamento()
        Try

            'Excluir
            grdOrcamento.CurrentRow.Delete()


            'Carrega a grid
            LoadGridOrcamentoOperacao()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridOrcamentoOperacao()
        Try

            Dim sOrcamento As String = ""

            For Each oRow In grdOrcamento.GetRows

                sOrcamento += IIf(sOrcamento = "", "", ",") + CStr(oRow.Cells.Item("codigo").Value)

            Next

            oClsUsrPrdCargaMaquina.LoadGridOrcamentoOperacao(grdOrcamentoOperacao, sOrcamento)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub InserirOrcamento()
        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboOrcamento, lblOrcamento) = False Then Exit Sub


            Dim oDataSet As New DataSet
            oDataSet = CType(grdOrcamento.DataSource.dataset, DataSet).Copy
            Dim oDataRow As DataRow = oDataSet.Tables(0).Rows.Add


            Dim sNumeroOrcamento As String
            Dim sRevisao As String
            Dim sCliente As String
            Dim dDataEntrega As Date

            oClsUsrPrdCargaMaquina.LoadDadosOrcamento(cboOrcamento.SelectedValue, _
                                                      sNumeroOrcamento, _
                                                      sRevisao, _
                                                      dDataEntrega, _
                                                      sCliente)

            oDataRow("numero_orcamento") = sNumeroOrcamento
            oDataRow("codigo") = cboOrcamento.SelectedValue
            oDataRow("cliente") = sCliente
            oDataRow("data_entrega_orcamento") = dDataEntrega
            oDataRow("revisao") = sRevisao



            'Carrega Grid
            grdOrcamento.DataSource = oDataSet.DefaultViewManager
            grdOrcamento.DataMember = oDataSet.Tables(0).TableName


            'Limpa o registro
            cboOrcamento.SelectedIndex = -1

            'Carrega os dados
            LoadGridOrcamentoOperacao

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region


  
End Class
