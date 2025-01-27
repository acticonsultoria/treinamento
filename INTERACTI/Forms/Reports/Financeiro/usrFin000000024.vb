Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class usrFin000000024

    'Variáveis da Classe
    Private oClsFin000000024 As New clsUsrFin000000024

#Region "::: CONTROLES :::"

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            Salvar()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnCadastrarSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarSMS.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadTextoSMS"
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Call LoadCombo(cboTextoSMS, "sp_select_combo_cadastro_basico_texto_sms " & goUsuario.iEmpresa & ", 2")

            'Seta Focu
            cboTextoSMS.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnviarSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarSMS.Click
        Try
            For i As Integer = 0 To grdListagem.RecordCount - 1

                grdListagem.Row = i

                If Not grdListagem.CurrentRow.CheckState = RowCheckState.Checked Then Continue For
                If IsDBNull(grdListagem.GetValue("telefone")) Then Continue For

                EnviarSMS_Telefone(grdListagem.GetValue("telefone"))
                EnviarSMS_Telefone(grdListagem.GetValue("telefone2"))
                EnviarSMS_Telefone(grdListagem.GetValue("telefone_recado"))
            Next
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usrFin000000024_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid()

                Case Keys.F3
                    Select Case sender.Name
                        Case "cboFornecedorFiltro" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFin000000024_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000024
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000024)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

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

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try

            ''Abre Formulário de Cadastro
            'Dim oForm As New frmCadBasico
            'oForm.UsrControl = "usrFindParceiroNegocio"
            'oForm.Titulo = Me.Parent.Text
            'oForm.Text = "Procurar Parceiro de Negócio"

            ''Seta Parametros
            'iCodigoTipoParceiroNegocioFind = CInt(TipoParceiroNegocio.cliente)
            'oComboBoxFind = cboClienteFiltro

            ''Abre Formulário
            'Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Dim oForm As New frmFindParceiroNegocio
            'oForm.ComboBox = cboClienteFiltro
            'oForm.CodigoTipoParceiroNegocio = TipoParceiroNegocio.cliente
            'oForm.ShowDialog()

            'Seta Focu
            cboClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000024
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000024)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(sender As Object, e As EventArgs) Handles btnAgruparGrid.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Visualizar Impressão
            Call VisualizarImpressao()

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioFIN000000024)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioFIN000000024, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"
    Private Sub Salvar()
        Try

            'Pega as linhas que foram alteradas
            Dim oDataSet As New DataSet
            oDataSet = CType(grdListagem.DataSource.dataset, DataSet).GetChanges

            'Laço para peroccrrer cada um dos registros
            For Each oRow In oDataSet.Tables(0).Rows

                'Validação
                If Not IsDBNull(oRow("valor_pago")) Then
                    Continue For

                End If

                oClsFin000000024.Update(oRow("codigo_titulo_capa"), _
                                        oRow("valor"), _
                                        oRow("data_vencimento"))
            Next

            'Informa ao usuár
            frmMain.Informacao("Registros alterados com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            Me.Dock = DockStyle.Fill
            ''Adiciona KeyUP
            'Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000024_KeyDown))
            'Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))
            'pagValores.TabVisible = False
            'Carrega ComboBox
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            'Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimePicker
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = Now.Date : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioFIN000000024, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000024, gcPrint)


            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000024)

            'Configuração do SMS
            'txtMensagemSMS.Text = "Prezado(a) Consultor(a) |NOME|  (|CODIGO|), Magma informa: DANFE e boleto referente a sua compra da semana |SEMANA| foram enviados para seu e-mail."

            If goDatabase.sInitialCatalog.ToUpper <> "INTERACTI_MAGMA_PRD" Then
                grdListagem.RootTable.Columns("telefone2").Visible = False
                grdListagem.RootTable.Columns("telefone_recado").Visible = False
                btnSalvar.Visible = False
                grpSMS.Visible = False
                grpLegenda.Visible = False
            Else
                Call LoadCombo(cboTextoSMS, "sp_select_combo_cadastro_basico_texto_sms " & goUsuario.iEmpresa & ", 2")
                grpLegenda.Visible = True
            End If

            If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then
                grdListagem.RootTable.Columns("telefone2").Visible = False
                grdListagem.RootTable.Columns("telefone_recado").Visible = False
                grdListagem.RootTable.Columns("semana").Visible = False
                grdListagem.RootTable.Columns("nota_fiscal").Visible = False
                grdListagem.RootTable.Columns("nfse").Visible = False
                grdListagem.RootTable.Columns("setor").Visible = False
                grdListagem.RootTable.Columns("codigo_consultora").Visible = False
                btnSalvar.Visible = False
                grpSMS.Visible = False
            End If
            'Seta Focu
            cboClienteFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim dInadimplencia As Double = 0

            'Seta Parametros
            oClsFin000000024.LoadGrid(grdListagem, _
                                      IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""))
            oClsFin000000024.LoadGridValores(grdValoresAberto, _
                                      IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""))
            oClsFin000000024.LoadGridPercentuais(grdPercentuais, _
                                      IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""))
            'Exclui Grupos
            If grdListagem.RootTable.Groups.Count > 0 Then
                grdListagem.RootTable.Groups.Remove(grdListagem.RootTable.Groups(0))
            End If



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(9)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000024.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Parceiro de Negócio
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue)
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_emissao_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_emissao_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Data Vencimento Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_vencimento_inicio"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataVencimentoInicioFiltro.Checked = False, "NULL", dtpDataVencimentoInicioFiltro.Value)
            'Seta Paramentro - Data Vencimento Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_vencimento_termino"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "NULL", dtpDataVencimentoTerminoFiltro.Value)
            'Seta Paramentro - Data pagamento Início
            goCrystalReport.sReportParameter(7).sParamenter = "@data_pagamento_inicio"
            goCrystalReport.sReportParameter(7).sValue = IIf(dtpDataPagamentoInicioFiltro.Checked = False, "NULL", dtpDataPagamentoInicioFiltro.Value)
            'Seta Paramentro - Data pagamento Término
            goCrystalReport.sReportParameter(8).sParamenter = "@data_pagamento_termino"
            goCrystalReport.sReportParameter(8).sValue = IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "NULL", dtpDataPagamentoTerminoFiltro.Value)
            'Seta Paramentro - Status
            goCrystalReport.sReportParameter(9).sParamenter = "@codigo_status"
            goCrystalReport.sReportParameter(9).sValue = -1


            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            'oReport.TabPage = Me.Parent
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Private Sub EnviarSMS()
    '    Try

    '        For Each oRow In grdListagem.GetCheckedRows

    '            If oRow.Cells.Item("telefone").Value <> "" Then

    '                'Verifica o nome do destinatário para trocar depois
    '                Dim sNome As String = Mid(oRow.Cells.Item("parceiro_negocio").Value, 1, InStr(oRow.Cells.Item("parceiro_negocio").Value, " "))

    '                'Recebe a mensagem pré formatada
    '                Dim sMensagem As String = cboTextoSMS.Text

    '                'Troca os dados
    '                sMensagem = Replace(sMensagem, "|NOME|", sNome.Trim)
    '                sMensagem = Replace(sMensagem, "|CODIGO|", oRow.Cells.Item("codigo_consultora").Value)
    '                sMensagem = Replace(sMensagem, "|SEMANA|", CStr(oRow.Cells.Item("semana").Value) & "/" & CStr(Year(Now)))

    '                'API para enviar o SMS
    '                Dim oWebSMS As New WebSMSSend.ReluzCapWebService

    '                'Gera um novo numero de controle
    '                Dim iNumeroControle As Integer = LoadCodigo("sp_select_faturamento_emissao_sms_ultimo_numero " & CStr(goUsuario.iEmpresa))

    '                'Formata o telefone
    '                Dim sTelefone As String = oRow.Cells.Item("telefone").Value
    '                sTelefone = Replace(sTelefone, "(", "")
    '                sTelefone = Replace(sTelefone, ")", "")
    '                sTelefone = RTrim(LTrim(sTelefone))
    '                If sTelefone.Length = 8 Or sTelefone.Length = 9 Then
    '                    sTelefone = "5512" + sTelefone
    '                End If
    '                If sTelefone.Length = 10 Or sTelefone.Length = 11 Then
    '                    sTelefone = "55" + sTelefone
    '                End If

    '                'Envia e recebe o retorno
    '                Dim sRetorno As String = oWebSMS.EnviaSMS("twmagma", _
    '                                        "serv56", _
    '                                         "A" + CStr(iNumeroControle).PadLeft(9, "0"), _
    '                                        sTelefone, _
    '                                        sMensagem)



    '                'Insere no controle
    '                InsertControleSMS(-1, _
    '                                  oRow.Cells.Item("numero_documento").Value, _
    '                                  oRow.Cells.Item("parceiro_negocio").Value, _
    '                                  oRow.Cells.Item("data_emissao").Value, _
    '                                                                      sTelefone, _
    '                                                                      sMensagem, _
    '                                                                      sRetorno, _
    '                                                                       iNumeroControle)

    '            End If
    '        Next
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub EnviarSMS_Telefone(ByVal sTelefone As String)
        Try

            If sTelefone <> "" Then

                'Verifica o nome do destinatário para trocar depois
                Dim sNome As String = Mid(grdListagem.GetValue("parceiro_negocio"), 1, InStr(grdListagem.GetValue("parceiro_negocio"), " "))

                'Recebe a mensagem pré formatada
                Dim sMensagem As String = cboTextoSMS.Text

                'Troca os dados
                sMensagem = Replace(sMensagem, "|NOME|", sNome.Trim)
                sMensagem = Replace(sMensagem, "|CODIGO|", grdListagem.GetValue("codigo_consultora"))
                sMensagem = Replace(sMensagem, "|SEMANA|", grdListagem.GetValue("semana"))

                'API para enviar o SMS
                Dim oWebSMS As New WebSMSSend.ReluzCapWebService

                'Gera um novo numero de controle
                Dim iNumeroControle As Integer = LoadCodigo("sp_select_faturamento_emissao_sms_ultimo_numero " & CStr(goUsuario.iEmpresa))

                'Formata o telefone
                sTelefone = Replace(sTelefone, "(", "")
                sTelefone = Replace(sTelefone, ")", "")
                sTelefone = RTrim(LTrim(sTelefone))
                If sTelefone.Length = 8 Or sTelefone.Length = 9 Then
                    sTelefone = "5512" + sTelefone
                End If
                If sTelefone.Length = 10 Or sTelefone.Length = 11 Then
                    sTelefone = "55" + sTelefone
                End If

                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12
                'Envia e recebe o retorno
                Dim sRetorno As String = oWebSMS.EnviaSMS("twmagma", _
                                        "serv56", _
                                         "A" + CStr(iNumeroControle).PadLeft(9, "0"), _
                                        sTelefone, _
                                        sMensagem)

                'Insere no controle
                InsertControleSMS(-1, _
                                    grdListagem.GetValue("numero_documento"), _
                                    grdListagem.GetValue("parceiro_negocio"), _
                                    grdListagem.GetValue("data_emissao"), _
                                    sTelefone, _
                                    sMensagem, _
                                    sRetorno, _
                                    iNumeroControle)



            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class
