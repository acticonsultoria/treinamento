Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop


Public Class usrFatAnaliseCadastroConsultora

    '    'Variáveis da Classe
    Private oClsUsrCadParceiroNegocio As New clsUsrCadParceiroNegocio

    Private bAlteracao As Boolean

#Region "::: CONTROLES :::"

    Private Sub usrFatAnaliseCadastro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    'If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        'Case "cboClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

               
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatReportMagma_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioAnaliseCadastro
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioAnaliseCadastro)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta para Excel
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

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        Try
            Call PlanilhaEnvio(grdListagem)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try
            If bAlteracao = True Then
                If MsgBox("Deseja salvar as alterações", MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then
                    Call Salvar()
                End If
            End If
            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated
        Try
            Dim sMotivo As String = ""
            Dim sSolucao As String = ""
            bAlteracao = True

            With grdListagem.CurrentRow





                If .Cells.Item("codigo_motivo_pendencia").Text <> "OUTROS" Then
                    .Cells.Item("motivo_pendencia").Value = ""

                    If .Cells.Item("codigo_motivo_pendencia").Text <> "" Then
                        sSolucao = LoadCodigo("sp_select_cadastro_basico_motivo_pendencia_solucao " & .Cells.Item("codigo_motivo_pendencia").Value)

                        .Cells.Item("solucao").Value = sSolucao
                    End If
                End If

                If .Cells.Item("status_analise").Text <> "PENDENTE" Then
                    .Cells.Item("motivo_pendencia").Value = ""
                    .Cells.Item("codigo_motivo_pendencia").Value = DBNull.Value
                End If

                If .Cells.Item("codigo_motivo_pendencia").Text = "OUTROS" And .Cells.Item("motivo_pendencia").Text = "" Then
                    sMotivo = InputBox("Digite o motivo da pendência:", "Pendência")

                    If sMotivo <> "" Then
                        .Cells.Item("motivo_pendencia").Value = sMotivo.ToUpper()
                    Else
                        If IsDBNull(.Cells.Item("motivo_pendencia").Value) Or .Cells.Item("motivo_pendencia").Text = "" Then
                            MsgBox("Favor digitar com motivo válido!", MsgBoxStyle.OkOnly, "Validação")
                            Call grdListagem_CellUpdated(Me, e)
                        End If

                    End If
                End If


                .Cells.Item("hostname").Value = System.Net.Dns.GetHostName.ToString()


            End With

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImportarPlanilha_Click(sender As Object, e As EventArgs) Handles btnImportarPlanilha.Click
        Try
            Call ImportarPlanilha(grdListagem)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelListagem_Click(sender As Object, e As EventArgs) Handles btnExcelListagem.Click
        Try
            ExportExcel(grdListagem)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnAtualizarSite_Click(sender As Object, e As EventArgs) Handles btnAtualizarSite.Click
        Try
            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadParceiroNegocio.AtualizarSite()

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Salvar()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioAnaliseCadastro)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

  

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key




            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioAnaliseCadastro, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatAnaliseCadastro_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadComboGrid(grdListagem, "codigo_conferido_por", "sp_select_combo_administracao_usuario_analise " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadComboGrid(grdListagem, "codigo_motivo_pendencia", "sp_select_combo_static_motivo_pendencia_analise")
            Call LoadComboGrid(grdListagem, "status_analise", "sp_select_combo_static_status_analise")

            bAlteracao = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
  
    Private Sub LoadGrid()

        Try

            If bAlteracao = True Then
                If MsgBox("Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then
                    Call Salvar()
                End If
            End If

            'Limpa Erro
            frmMain.errInfo.Clear()

            ''Valida Campo - Tipo de Data
            'If ValidaCampo(cboTipoDataFiltro, lblTipoDataFiltro) = False Then
            '    Exit Sub
            'End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If ValidaCampo(txtSemanaFiltro, lblSemanaFiltro, TipoCampo.texto) = False Then
                Exit Sub
            End If

            oClsUsrCadParceiroNegocio.LoadGridAnalise(grdListagem, _
                                                    txtSemanaFiltro.Text, _
                                                    txtNomeFiltro.Text, _
                                                    txtCodigoConsultoraFiltro.Text, _
                                                    txtSetorFiltro.Text)

            ' grdlistagem.refresh()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub PlanilhaEnvio(ByVal oGrid As GridEX)
        Try
            'Variaveis Local
            Dim oApplicationClass As New Application
            Dim oWorkbook As Workbook
            Dim oWorksheet As Worksheet
            Dim oRowExcel As GridEXRow
            Dim x As GridEXFormatStyle
            Dim teste As String
            Dim i As Integer = 2

            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.ActiveSheet()

            oWorksheet.Range("A1").Value = "CGRUPO"
            oWorksheet.Range("B1").Value = "CODCONSULTORA"
            oWorksheet.Range("C1").Value = "NOME"
            oWorksheet.Range("D1").Value = "SEMANA"
            oWorksheet.Range("E1").Value = "STATUS"
            oWorksheet.Range("F1").Value = "MOTIVO PENDÊNCIA"
            oWorksheet.Range("G1").Value = "COMPLEMENTO"

            For Each oRow As GridEXRow In oGrid.GetRows
                oWorksheet.Range("A" & CStr(i)).Value = oRow.Cells.Item("grupo").Value
                oWorksheet.Range("B" & CStr(i)).Value = oRow.Cells.Item("codigo_consultora").Value
                oWorksheet.Range("C" & CStr(i)).Value = oRow.Cells.Item("razao_social").Value
                oWorksheet.Range("D" & CStr(i)).Value = oRow.Cells.Item("semana").Value
                oWorksheet.Range("E" & CStr(i)).Value = oRow.Cells.Item("status_analise").Value
                oWorksheet.Range("F" & CStr(i)).Value = oRow.Cells.Item("codigo_motivo_pendencia").Value
                oWorksheet.Range("G" & CStr(i)).Value = oRow.Cells.Item("motivo_pendencia").Value

                i = i + 1
            Next

            oWorksheet.Columns.AutoFit()
            oApplicationClass.Visible = True

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarPlanilha(ByVal oGrid As GridEX)
        Try
            'Váriaveis Locais
            Dim oApplicationClass As New Excel.ApplicationClass
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"
            oArquivoExcel.InitialDirectory = "c:\\"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Abre o Arquivo
                oApplicationClass.Workbooks.Open(oArquivoExcel.FileName)

                For i = 1 To oApplicationClass.Rows.Count
                    If oApplicationClass.Range("F" & i).Value = "" Then
                        Exit For
                    End If

                    grdListagem.Find(grdListagem.Tables(0).Columns("codigo_consultora"), ConditionOperator.Equal, CStr(oApplicationClass.Range("E" & i).Value), -1, 1)

                    If CInt(oApplicationClass.Range("S" & i).Value.ToString.TrimStart()) = 0 Then
                        grdListagem.SetValue("primeiro_pedido", "1º PEDIDO")
                    End If

                    If CInt(oApplicationClass.Range("S" & i).Value.ToString.TrimStart()) > 0 Then
                        grdListagem.SetValue("primeiro_pedido", "RL")
                    End If

                Next

                'For Each oRow In grdListagem.GetRows
                '    If IsDBNull(oRow.Cells.Item("primeiro_pedido").Value) Then
                '        grdListagem.SetValue("primeiro_pedido", "SEM PEDIDO")
                '    End If
                'Next

            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Salvar()
        Try
            Cursor.Current = Cursors.WaitCursor

            For Each oRow As GridEXRow In grdListagem.GetRows
                If oRow.Cells.Item("codigo_conferido_por").Text = "" Or IsDBNull(oRow.Cells.Item("codigo_conferido_por").Text) Then
                    Continue For
                End If

                If oRow.Cells.Item("hostname").Value.ToString() = "" Or IsDBNull(oRow.Cells.Item("hostname").Value) = True Then
                    Continue For
                End If

                If (oRow.Cells.Item("motivo_pendencia").Text = "" And IsDBNull(oRow.Cells.Item("codigo_motivo_pendencia").Value)) And _
                    oRow.Cells.Item("status_analise").Text = "PENDENTE" Then
                    MsgBox("Favor escolher o motivo da pendência para a consultora de Código " & oRow.Cells.Item("codigo_consultora").Text & "!", MsgBoxStyle.OkOnly, "Validação")
                    Exit Sub
                End If



                oClsUsrCadParceiroNegocio.InsertAnalise(oRow.Cells.Item("codigo_parceiro_negocio").Value, _
                                                        IIf(IsDBNull(oRow.Cells.Item("codigo_conferido_por").Value), -1, oRow.Cells.Item("codigo_conferido_por").Value), _
                                                        IIf(IsDBNull(oRow.Cells.Item("codigo_conferido_por").Text), "", oRow.Cells.Item("codigo_conferido_por").Text), _
                                                        IIf(IsDBNull(oRow.Cells.Item("status_analise").Value), -1, oRow.Cells.Item("status_analise").Value), _
                                                        IIf(IsDBNull(oRow.Cells.Item("motivo_pendencia").Text), "", oRow.Cells.Item("motivo_pendencia").Text), _
                                                        IIf(IsDBNull(oRow.Cells.Item("codigo_motivo_pendencia").Value), -1, oRow.Cells.Item("codigo_motivo_pendencia").Value), _
                                                        IIf(IsDBNull(oRow.Cells.Item("primeiro_pedido").Value), "", oRow.Cells.Item("primeiro_pedido").Value), _
                                                        IIf(IsDBNull(oRow.Cells.Item("solucao").Value), "", oRow.Cells.Item("solucao").Value), txtSemanaFiltro.Text)
            Next

            frmMain.Informacao("Registro(s) salvo(s) com sucesso!", Color.Gray)

            bAlteracao = False
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region


End Class
