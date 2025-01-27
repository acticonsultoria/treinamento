Imports CrystalDecisions.CrystalReports.Engine
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop
Imports BoletoNet
Imports System.Text
Imports System.IO
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Threading
Imports System.Net.Mail
Imports System.Net.Mime
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports ImagePDF
Imports Microsoft.Office.Interop.Excel

Public Class usrFinReceitaCobranca

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaCobranca As New clsUsrFinReceitaCobranca
    Private oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
    Private sArquivo As String

#End Region

#Region "::: CONTROLES :::"

#Region "::: COBRANÇA :::"

    Private Sub btnEnviarEmail_Click(sender As Object, e As EventArgs) Handles btnEnviarEmail.Click
        Try
            'Váriaveis Locais
            Dim oForm As New frmFinReceitaCobrancaTipo

            'Verifica o Direito do Usuário
            If VerificaDireito(Formulario.FinanceiroReceitaCobranca, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Verifica se foi Selecionado algum Relatório
            If goCrystalReport.sReport <> "" Then
                For i As Integer = 0 To grdListagem.RecordCount - 1

                    grdListagem.Row = i

                    If Not grdListagem.CurrentRow.CheckState = RowCheckState.Checked Then Continue For

                    Call Email(oForm.DataLimite)
                Next
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub usrFinReceitaCobranca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        Case "txtClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinReceitaCobranca_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnAgrupaGrid_Click(sender As Object, e As EventArgs) Handles btnAgrupaGrid.Click
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

    Private Sub btnConfiguraGrid_Click(sender As Object, e As EventArgs) Handles btnConfiguraGrid.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FinanceiroReceitaCobranca
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaCobranca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try


            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oMaskedEditBoxFind = txtClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtClienteFiltro.Focus()

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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Relatório
            'Call ImprimirRelatorio()

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

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Query
            Dim sQuery As String = "WHERE (((codigo) = " & grdListagem.GetValue("codigo_parceiro_negocio") & "))"

            Select Case e.Column.Key

                Case "observacao" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_parceiro_negocio', 'observacao', " & IIf(IsDBNull(grdListagem.GetValue("observacao")), "'NULL'", "'''" & grdListagem.GetValue("observacao") & "'''") & ",'" & sQuery & "'")

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroReceitaCobranca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FinanceiroReceitaCobranca, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReceitaCobranca, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnviarProtesto_Click(sender As Object, e As EventArgs) Handles btnEnviarProtesto.Click
        Try

            Call Protestar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnEnviarSMS_Click(sender As Object, e As EventArgs) Handles btnEnviarSMS.Click
        Try
            For i As Integer = 0 To grdListagem.RecordCount - 1

                grdListagem.Row = i

                If Not grdListagem.CurrentRow.CheckState = RowCheckState.Checked Then Continue For

                EnviarSMS_Telefone(grdListagem.GetValue("telefone1"))
                EnviarSMS_Telefone(grdListagem.GetValue("telefone2"))
            Next
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnRelatorioEntrega_Click(sender As Object, e As EventArgs) Handles btnRelatorioEntrega.Click
        Try

            'Imprime Pedido de Venda
            Call ImprimirRelatorio()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCartaBoleto_Click(sender As Object, e As EventArgs) Handles btnCartaBoleto.Click
        Try
            'Abre Formulário
            Dim oForm As New frmFinReceitaCobrancaCartaBoleto
            oForm.Grid = grdListagem
            'Abre Formulário
            oForm.ShowDialog()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
   
    
    End Sub

#End Region

#Region "::: PROTESTO :::"

    Private Sub btnFiltrarProtesto_Click(sender As Object, e As EventArgs) Handles btnFiltrarProtesto.Click
        Try

            'Carrega Dados da Grid
            Call LoadGridProtesto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridProtesto_Click(sender As Object, e As EventArgs) Handles btnConfiguraGridProtesto.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProtesto
            oForm.NomeFormulario = Formulario.FinanceiroReceitaCobranca
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProtesto, Formulario.FinanceiroReceitaCobranca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgrupaGridProtesto_Click(sender As Object, e As EventArgs) Handles btnAgrupaGridProtesto.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdProtesto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdProtesto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdProtesto.GroupByBoxVisible = True
                grdProtesto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSairProtesto_Click(sender As Object, e As EventArgs) Handles btnSairProtesto.Click
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

    Private Sub grdProtesto_CellUpdated(sender As Object, e As ColumnActionEventArgs)
        Try

            'Query
            Dim sQuery As String = "WHERE (((codigo) = " & grdProtesto.GetValue("codigo_parceiro_negocio") & "))"

            Select Case e.Column.Key

                Case "observacao" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_parceiro_negocio', 'observacao', " & IIf(IsDBNull(grdProtesto.GetValue("observacao")), "'NULL'", "'''" & grdProtesto.GetValue("observacao") & "'''") & ",'" & sQuery & "'")

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdProtesto_ColumnMoved(sender As Object, e As ColumnActionEventArgs)
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProtesto, _
                                     Formulario.FinanceiroReceitaCobranca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdProtesto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)
        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProtesto.Name, _
                                          Formulario.FinanceiroReceitaCobranca, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnDesfazerProtesto_Click(sender As Object, e As EventArgs) Handles btnDesfazerProtesto.Click
        Try
            Call DesfazerProtesto()
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdProtesto_SizingColumn(sender As Object, e As SizingColumnEventArgs)
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProtesto.Name, _
                                     Formulario.FinanceiroReceitaCobranca, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnPlanilhaProtesto_Click(sender As Object, e As EventArgs) Handles btnPlanilhaProtesto.Click
        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProtesto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja gerar a planilha de envio para protesto desse" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exporta Grid para Excel
                    'Call ExportExcel(grdProtesto)
                    Call PlanilhaProtesto(grdProtesto)

                    oClsFinReceitaCobranca.UpdateEnvio()

                    Call LoadGridProtesto()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroAlterado)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: COBRANÇA :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaCobranca_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioProtesto.Value = Now.Date : dtpDataVencimentoInicioProtesto.Checked = False
            dtpDataVencimentoTerminoProtesto.Value = Now.Date : dtpDataVencimentoTerminoProtesto.Checked = False

            'Verifica Direito - Controles
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaCobranca, gcPrint)
            
            Call LoadCombo(cboTextoSMS, "sp_select_combo_cadastro_basico_texto_sms " & goUsuario.iEmpresa & ", 2")
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_status_protesto")

            Call LoadGridProtesto()

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaCobranca)
            Call ConfiguraGrid(grdProtesto, Formulario.FinanceiroReceitaCobranca)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub InserirComentario()

        Try

            'Verifica o Direito do Usuário
            If VerificaDireito(Formulario.FinanceiroReceitaCobranca, gcInsert) = False Then
                frmMain.Informacao(Mensagem.DireitoInserir)
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oForm As New frmFinReceitaCobrancaComentario
            'Seta Parâmetros
            oForm.Grid = grdListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarHistorico()

        Try

            'Verifica o Direito do Usuário
            If VerificaDireito(Formulario.FinanceiroReceitaCobranca, gcSelect) = False Then
                frmMain.Informacao(Mensagem.DireitoVisualizar)
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oForm As New frmFinReceitaCobrancaHistorico
            'Seta Parâmetros
            oForm.Grid = grdListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir()

        Try

            'Verifica o Direito do Usuário
            If VerificaDireito(Formulario.FinanceiroReceitaCobranca, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oForm As New frmFinReceitaCobrancaTipo

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Verifica se foi Selecionado algum Relatório
            If goCrystalReport.sReport <> "" Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(4)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
                goCrystalReport.sReportParameter(2).sValue = grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value
                goCrystalReport.sReportParameter(3).sParamenter = "@tipo"
                goCrystalReport.sReportParameter(3).sValue = "R"
                goCrystalReport.sReportParameter(4).sParamenter = "@data_limite"
                goCrystalReport.sReportParameter(4).sValue = oForm.DataLimite

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport(goCrystalReport.sReport, goCrystalReport.sManual, oReport)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Email(ByVal sDataLimite As String)

        Try

            'Variaveis Locais
            Dim oRptDocument As New ReportDocument
            Dim sAnexo As String

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abre o Relatório
            oRptDocument.Load(goCrystalReport.sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Envia parametros para o Relatório
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)
            oRptDocument.SetParameterValue("@codigo_parceiro_negocio", grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("@tipo", "R")
            oRptDocument.SetParameterValue("@data_limite", sDataLimite)

            'Abre Conexão com o Banco de Dados        
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next i

            'sAnexo = ApplicationPath() & "File\" & goCrystalReport.sManual & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"
            'sAnexo = "C:\ACTI\ARQUIVOS TESTE\" & goCrystalReport.sManual & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"
            sAnexo = "\\srv-acti-01\Desenvolvimento\MAGMA\ARQUIVOS\" & goCrystalReport.sManual & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"
            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sAnexo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            ''LoadContato(grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value, TipoContato.Financeiro), _
            Call EnviarEmail(goUsuario.sEmpresa & " - " & goCrystalReport.sManual, _
                            LoadContato(grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value, TipoContato.Financeiro), _
                             sAnexo, _
                             sAnexo, _
                             "", _
                             grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value)

            'Salva Histórico
            Dim oClsFinReceitaCobrancaComentario As New clsFrmFinReceitaCobrancaComentario
            Dim oRow As GridEXRow


            'Seta Parâmetros
            For Each oRow In grdListagem.CurrentRow.GetChildRows

                'Seta Parâmetros
                oClsFinReceitaCobrancaComentario.CodigoTituloCapa = oRow.Cells("codigo_titulo_capa").Value
                oClsFinReceitaCobrancaComentario.NumeroParcela = oRow.Cells("numero_parcela").Value
                oClsFinReceitaCobrancaComentario.Historico = "ENVIO DE E-MAIL DE: " & goCrystalReport.sManual

                'Salva Histórico
                oClsFinReceitaCobrancaComentario.Salvar()

            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFinReceitaCobranca.LoadGrid(grdListagem, _
                                            txtNumeroDocumentoFiltro.Text.Trim, _
                                            IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                            IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                            txtClienteFiltro.Text.Trim, _
                                            IIf(dtpDataVencimentoInicioFiltro.Checked = False, "", dtpDataVencimentoInicioFiltro.Value), _
                                            IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "", dtpDataVencimentoTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub BloquearCliente()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRowDiferente(grdListagem, "tipo_negativacao", "BLOQUEAR CLIENTE") = True Then

                'Verifica se o Usuário Deseja Bloquear o Cliente
                If MsgBox("Deseja Bloquear o(s) Cliente(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Váriaveis Locais
                    Dim sTexto As String = "CLIENTE BLOQUEADO DEVIDO AO NÃO PAGAMENTO DOS TÍTULOS:" & vbCrLf

                    'Atualiza Registro
                    For Each oRow As GridEXRow In gSelecaoRow

                        For Each oRowChildren As GridEXRow In oRow.GetChildRows
                            If oRowChildren.RowType = RowType.Record Then sTexto &= vbCrLf & "TÍTULO: " & oRowChildren.Cells("numero_documento").Value & " PARCELA: " & oRowChildren.Cells("parcela").Value & " VENCIDA DESDE: " & oRowChildren.Cells("data_vencimento").Value & " NO VALOR DE R$ " & oRowChildren.Cells("valor_corrigido").Value & "."
                        Next

                        Call oClsFinReceitaCobranca.UpdateTipoNegativacaoCliente(oRow.Cells("codigo_parceiro_negocio").Value, _
                                                                                 TipoNegativacaoCliente.BloquearCliente, _
                                                                                 sTexto)

                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Carrega Grid
                    Call LoadGrid()

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AlertarVendedor()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRowDiferente(grdListagem, "tipo_negativacao", "ALERTAR VENDEDOR") = True Then

                'Verifica se o Usuário Deseja Bloquear o Cliente
                If MsgBox("Deseja Alertar o Vendedor a Respeito do(s) Título(s) em Atraso do(s) Cliente(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Váriaveis Locais
                    Dim sTexto As String = "ALERTAR VENDEDOR DEVIDO AO NÃO PAGAMENTO DOS TÍTULOS:" & vbCrLf

                    'Atualiza Registro
                    For Each oRow As GridEXRow In gSelecaoRow

                        For Each oRowChildren As GridEXRow In oRow.GetChildRows
                            If oRowChildren.RowType = RowType.Record Then sTexto &= vbCrLf & "TÍTULO: " & oRowChildren.Cells("numero_documento").Value & " PARCELA: " & oRowChildren.Cells("parcela").Value & " VENCIDA DESDE: " & oRowChildren.Cells("data_vencimento").Value & " NO VALOR DE R$ " & oRowChildren.Cells("valor_corrigido").Value & "."
                        Next

                        Call oClsFinReceitaCobranca.UpdateTipoNegativacaoCliente(oRow.Cells("codigo_parceiro_negocio").Value, _
                                                                                 TipoNegativacaoCliente.AlertarVendedor, _
                                                                                 sTexto)

                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Carrega Grid
                    Call LoadGrid()

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub BoletoBancario()

        Try

            'Verifica o Direito do Usuário
            If VerificaDireito(Formulario.FinanceiroReceitaBoletoBancario, gcUpdate) = False Then
                frmMain.Informacao(Mensagem.DireitoAlteracao)
                Exit Sub
            End If

            'Abre Formulário de Boleto Bancário
            Dim oForm As New frmFinReceitaBoletoBancarioDLL
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            oForm.Cliente = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
            oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("numero_documento").Value
            oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarDuplicata()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaLancamento, gcUpdate) = True Then

                'Váriavel - Formulário
                Dim oForm As New frmFinEditarDuplicata

                'Seta Parâmetros
                oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value
                oForm.NumeroParcela = grdListagem.CurrentRow.Cells.Item("numero_parcela").Text

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Atualiza Grid
                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Protestar()
        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja protestar este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinReceitaCobranca.UpdateProtesto()

                    Call LoadGrid()

                    Call LoadGridProtesto()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroAlterado)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PlanilhaProtesto(ByVal oGrid As GridEX)
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

            oWorksheet.Range("A1").Value = "Nome do Devedor"
            oWorksheet.Range("B1").Value = "Endereço"
            oWorksheet.Range("C1").Value = "Bairro"
            oWorksheet.Range("D1").Value = "CEP"
            oWorksheet.Range("E1").Value = "Município"
            oWorksheet.Range("F1").Value = "UF"
            oWorksheet.Range("G1").Value = "CNPJ/CPF"
            oWorksheet.Range("H1").Value = "Fatura/Nº Título"
            oWorksheet.Range("I1").Value = "Parcela"
            oWorksheet.Range("J1").Value = "Valor do Título"
            oWorksheet.Range("K1").Value = "Valor a Protestar"
            oWorksheet.Range("L1").Value = "Data de Emissão"
            oWorksheet.Range("M1").Value = "Data de Vencimento"
            oWorksheet.Range("N1").Value = "Falimentar"
            oWorksheet.Range("O1").Value = "Nº Matrícula/Cliente"
            oWorksheet.Range("P1").Value = "Espécie"
            oWorksheet.Range("Q1").Value = "Email"
            oWorksheet.Range("R1").Value = "Telefone"

            For Each oRow As GridEXRow In oGrid.GetCheckedRows
                oWorksheet.Range("A" & CStr(i)).Value = oRow.Cells.Item("nome").Value
                oWorksheet.Range("B" & CStr(i)).Value = oRow.Cells.Item("endereco").Value.ToString.Replace("R    ", "R ")
                oWorksheet.Range("C" & CStr(i)).Value = oRow.Cells.Item("bairro").Value
                oWorksheet.Range("D" & CStr(i)).Value = oRow.Cells.Item("cep").Value
                oWorksheet.Range("E" & CStr(i)).Value = oRow.Cells.Item("municipio").Value
                oWorksheet.Range("F" & CStr(i)).Value = oRow.Cells.Item("uf").Value
                oWorksheet.Range("G" & CStr(i)).Value = oRow.Cells.Item("cnpj_cpf").Value
                oWorksheet.Range("H" & CStr(i)).Value = oRow.Cells.Item("numero_documento").Value
                oWorksheet.Range("I" & CStr(i)).Value = oRow.Cells.Item("parcela").Value
                oWorksheet.Range("J" & CStr(i)).NumberFormat = "@"
                oWorksheet.Range("J" & CStr(i)).Value = CStr(oRow.Cells.Item("valor_parcela").Value)
                oWorksheet.Range("J" & CStr(i)).HorizontalAlignment = Excel.Constants.xlRight
                oWorksheet.Range("K" & CStr(i)).NumberFormat = "@"
                oWorksheet.Range("K" & CStr(i)).Value = CStr(oRow.Cells.Item("valor_protestar").Value)
                oWorksheet.Range("K" & CStr(i)).HorizontalAlignment = Excel.Constants.xlRight
                oWorksheet.Range("L" & CStr(i)).Value = oRow.Cells.Item("data_emissao").Value
                oWorksheet.Range("M" & CStr(i)).Value = oRow.Cells.Item("data_vencimento").Value
                oWorksheet.Range("N" & CStr(i)).Value = oRow.Cells.Item("falimentar").Value
                oWorksheet.Range("O" & CStr(i)).Value = oRow.Cells.Item("matricula_cliente").Value
                oWorksheet.Range("P" & CStr(i)).Value = oRow.Cells.Item("especie").Value
                oWorksheet.Range("Q" & CStr(i)).Value = oRow.Cells.Item("email").Value
                oWorksheet.Range("R" & CStr(i)).Value = oRow.Cells.Item("telefone").Value

                i = i + 1
            Next

            oWorksheet.Range("A:R").Font.Size = 8.5
            oWorksheet.Range("A:R").Font.Name = "Arial"

            oWorksheet.Columns.AutoFit()
            oApplicationClass.Visible = True

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EnviarSMS_Telefone(ByVal sTelefone As String)
        Try

            If sTelefone <> "" Then

                'Verifica o nome do destinatário para trocar depois
                Dim sNome As String = Mid(grdListagem.GetValue("razao_social"), 1, InStr(grdListagem.GetValue("razao_social"), " "))

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
                                    grdListagem.GetValue("nota_fiscal"), _
                                    grdListagem.GetValue("razao_social"), _
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

    Private Sub ImprimirRelatorio()

        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja gerar o Relatório de Entrega desse" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Dim sCodigo As String = ""
                    Dim sCodigoParcela As String = ""

                    For Each oRow In grdListagem.GetCheckedRows
                        sCodigo &= IIf(sCodigo = "", "", ",") & oRow.Cells.Item("codigo").Value
                    Next

                    For Each oRow In grdListagem.GetCheckedRows
                        sCodigoParcela &= IIf(sCodigoParcela = "", "", ",") & oRow.Cells.Item("codigo_parcela").Value
                    Next

                    'Redimenciona Vetor
                    ReDim goCrystalReport.sReportParameter(2)

                    'Seta Parametros
                    goCrystalReport.sReportParameter(0).sParamenter = "@codigo"
                    goCrystalReport.sReportParameter(0).sValue = sCodigo
                    goCrystalReport.sReportParameter(1).sParamenter = "@codigo_parcela"
                    goCrystalReport.sReportParameter(1).sValue = sCodigoParcela
                    goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                    goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                    goCrystalReport.sReport = goCrystalReport.sPath & "rptRelatorioEntregaCobranca.rpt"

                    Dim oReport As New usrReport
                    oReport.Dock = DockStyle.Fill

                    'Abre Relatório
                    frmMain.LoadPageReport("Relatório de Entrega de Cobrança", "Relatório de Entrega de Cobrança", oReport)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PROTESTO :::"

    Private Sub LoadGridProtesto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sStatus As String = ""

            'CFOP
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsFinReceitaCobranca.LoadGridProtesto(grdProtesto, _
                                                    txtClienteProtesto.Text, _
                                                    IIf(dtpDataVencimentoInicioProtesto.Checked = False, "", dtpDataVencimentoInicioProtesto.Value), _
                                                    IIf(dtpDataVencimentoTerminoProtesto.Checked = False, "", dtpDataVencimentoTerminoProtesto.Value), _
                                                   sStatus)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DesfazerProtesto()
        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProtesto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja desfazer o protesto desse" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinReceitaCobranca.UpdateCobranca()

                    Call LoadGrid()

                    Call LoadGridProtesto()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroAlterado)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

End Class
