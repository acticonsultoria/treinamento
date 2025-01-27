Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO

Public Class usrVenEmbraer

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsVenEmbraer As New clsUsrVenEmbraer
    Private sStringConexaoSELMA As String = LoadDescricao("sp_select_configuracao_interacti_texto " & goUsuario.iEmpresa & ", 'string_conexao_selma'")

#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrVenEmbraer_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PEDIDO VENDA :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdEmbraer.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdEmbraer.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdEmbraer.GroupByBoxVisible = True
                grdEmbraer.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEmbraer
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEmbraer, Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdEmbraer)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoExcel.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Atualiza Dados - Configuração Arquivo Excel
                oClsVenEmbraer.UpdateConfiguracaoArquivoExcel(cboTipoPlanilha.SelectedValue, _
                                                              IIf(cboColunaPO.SelectedIndex = -1, "", cboColunaPO.SelectedValue), _
                                                              IIf(cboColunaPOLinha.SelectedIndex = -1, "", cboColunaPOLinha.SelectedValue), _
                                                              IIf(cboColunaStatus.SelectedIndex = -1, "", cboColunaStatus.SelectedValue), _
                                                              IIf(cboColunaQuantidade.SelectedIndex = -1, "", cboColunaQuantidade.SelectedValue), _
                                                              IIf(cboColunaPrevisaoEntrega.SelectedIndex = -1, "", cboColunaPrevisaoEntrega.SelectedValue), _
                                                              IIf(cboColunaTipoPO.SelectedIndex = -1, "", cboColunaTipoPO.SelectedValue), _
                                                              IIf(cboColunaPrioridade.SelectedIndex = -1, "", cboColunaPrioridade.SelectedValue), _
                                                              IIf(cboColunaCodigoItem.SelectedIndex = -1, "", cboColunaCodigoItem.SelectedValue), _
                                                              IIf(cboColunaRevisaoPartNumber.SelectedIndex = -1, "", cboColunaRevisaoPartNumber.SelectedValue), _
                                                              IIf(cboColunaCodigoEmbraer.SelectedIndex = -1, "", cboColunaCodigoEmbraer.SelectedValue), _
                                                              IIf(cboColunaValorUnitario.SelectedIndex = -1, "", cboColunaValorUnitario.SelectedValue), _
                                                              IIf(cboColunaCentro.SelectedIndex = -1, "", cboColunaCentro.SelectedValue), _
                                                              IIf(cboColunaRequerente.SelectedIndex = -1, "", cboColunaRequerente.SelectedValue), _
                                                              IIf(cboColunaCiclo.SelectedIndex = -1, "", cboColunaCiclo.SelectedValue), _
                                                              IIf(cboColunaUnidadeMedida.SelectedIndex = -1, "", cboColunaUnidadeMedida.SelectedValue), _
                                                              IIf(cboColunaDepositoArmazenamento.SelectedIndex = -1, "", cboColunaDepositoArmazenamento.SelectedValue), _
                                                              IIf(cboColunaAcaoDias.SelectedIndex = -1, "", cboColunaAcaoDias.SelectedValue), _
                                                              txtLinhaInicio.Value, _
                                                              txtPlanilha.Text, _
                                                              txtPlanilhaDesenho.Text)

                'Importa Arquivo Excel
                Call ImportarArquivoExcel()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Limpa / Carrega Controles
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarLinha.Click

        Try


            'Valida Formulário
            If ValidacaoPedidoVenda() = True Then

                'Verifica se o Usuário deseja Salvar o Pedido de Venda (1 por Linha)
                If MsgBox("Deseja Gerar um Pedido de Venda para cada Linha da PO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Salva Pedido
                    Call Salvar("LINHA")

                    'Limpa Formulário
                    Call Novo()

                End If
            End If



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarPO.Click

        Try

            'Call IntegracaoSELMA()

            'Valida Formulário
            If ValidacaoPedidoVenda() = True Then

                'Verifica se o Usuário deseja Salvar o Pedido de Venda (1 por PO)
                If MsgBox("Deseja Gerar um Pedido de Venda para cada PO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Salva Pedido
                    Call Salvar("CAPA")

                    'Limpa Formulário
                    Call Novo()

                End If

            End If

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

    Private Sub cboTipoPlanilha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPlanilha.SelectedIndexChanged

        Try

            'Carrega Controles
            Call oClsVenEmbraer.LoadControles(cboTipoPlanilha.SelectedValue, _
                                              cboColunaPO, _
                                              cboColunaPOLinha, _
                                              cboColunaStatus, _
                                              cboColunaQuantidade, _
                                              cboColunaPrevisaoEntrega, _
                                              cboColunaTipoPO, _
                                              cboColunaPrioridade, _
                                              cboColunaCodigoItem, _
                                              cboColunaRevisaoPartNumber, _
                                              cboColunaCodigoEmbraer, _
                                              cboColunaValorUnitario, _
                                              cboColunaCentro, _
                                              cboColunaRequerente, _
                                              cboColunaCiclo, _
                                              cboColunaUnidadeMedida, _
                                              cboColunaDepositoArmazenamento, _
                                              cboColunaAcaoDias, _
                                              txtLinhaInicio, _
                                              txtPlanilha, _
                                              txtPlanilhaDesenho)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmbraer_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEmbraer.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEmbraer, _
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmbraer_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEmbraer.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEmbraer.Name, _
                                     Formulario.ComercialPedidoVenda, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEmbraer_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdEmbraer.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEmbraer.Name, _
                                          Formulario.ComercialIntegracaoEmbraer, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: PEDIDO VENDA :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox            
            Dim oComboBox(16) As UIComboBox
            oComboBox(0) = cboColunaPO : oComboBox(1) = cboColunaPOLinha
            oComboBox(2) = cboColunaStatus : oComboBox(3) = cboColunaQuantidade
            oComboBox(4) = cboColunaPrevisaoEntrega : oComboBox(5) = cboColunaTipoPO
            oComboBox(6) = cboColunaPrioridade : oComboBox(7) = cboColunaCodigoItem
            oComboBox(8) = cboColunaRevisaoPartNumber : oComboBox(9) = cboColunaCodigoEmbraer
            oComboBox(10) = cboColunaValorUnitario : oComboBox(11) = cboColunaCentro
            oComboBox(12) = cboColunaRequerente : oComboBox(13) = cboColunaCiclo
            oComboBox(14) = cboColunaUnidadeMedida : oComboBox(15) = cboColunaDepositoArmazenamento
            oComboBox(16) = cboColunaAcaoDias
            Call LoadComboAZ(oComboBox)

            'Verifica Direito
            btnSalvarLinha.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnSalvarPO.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcPrint)

            'Adiciona Planilha
            cboTipoPlanilha.Items.Clear()
            cboTipoPlanilha.Items.Add("EMBRAER", 1)
            cboTipoPlanilha.Items.Add("ELEB", 1)

            'Configura Grid
            Call ConfiguraGrid(grdEmbraer, Formulario.ComercialIntegracaoEmbraer)

            'Seta Focu
            btnArquivoExcel.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Carrega Controles
            Call oClsVenEmbraer.LoadControles(IIf(cboTipoPlanilha.SelectedIndex = -1, -1, cboTipoPlanilha.SelectedValue), _
                                              cboColunaPO, _
                                              cboColunaPOLinha, _
                                              cboColunaStatus, _
                                              cboColunaQuantidade, _
                                              cboColunaPrevisaoEntrega, _
                                              cboColunaTipoPO, _
                                              cboColunaPrioridade, _
                                              cboColunaCodigoItem, _
                                              cboColunaRevisaoPartNumber, _
                                              cboColunaCodigoEmbraer, _
                                              cboColunaValorUnitario, _
                                              cboColunaCentro, _
                                              cboColunaRequerente, _
                                              cboColunaCiclo, _
                                              cboColunaUnidadeMedida, _
                                              cboColunaDepositoArmazenamento, _
                                              cboColunaAcaoDias, _
                                              txtLinhaInicio, _
                                              txtPlanilha, _
                                              txtPlanilhaDesenho)

            'Limpa Controles
            txtArquivoExcel.Text = ""
            grdEmbraer.DataSource = Nothing

            'Seta Focu
            btnArquivoExcel.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar(ByVal sFormaCadastro As String)

        Try

            ''Verifica se foi encontrado a String de Conexão - SELMA
            'If sStringConexaoSELMA <> "" Then

            '    'Integra com o SELMA
            '    Call IntegracaoSELMA()

            'End If

            'Salva Pedido
            Call oClsVenEmbraer.Salvar(grdEmbraer, sFormaCadastro)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ReportErro(ByVal sTitle As String, _
                                ByVal sSubTitle As String, _
                                ByVal oMensagem() As MensagemErro) As String

        Dim sReportHTML As String

        'add header information
        sReportHTML = "<!DOCTYPE HTML PUBLIC -//W3C//DTD HTML 4.01 Transitional//EN > "
        sReportHTML &= "<html>"
        sReportHTML &= "<head>"
        sReportHTML &= "<title>" & sTitle & "</title>"
        sReportHTML &= "<meta http-equiv=Content-Type content=text/html; charset=iso-8859-1 > "
        sReportHTML &= "</head>"
        sReportHTML &= "<body>"

        'add title text / subtitle text block
        sReportHTML &= "<p><font face=Arial, Helvetica, sans-serif><strong><font size=3>" & sSubTitle & "</font></strong><br>"
        sReportHTML &= "<font size=" & "2" & ">Relatório Gerado em: " & Now & "<br>"
        sReportHTML &= "Relatório Gerado por : " & goUsuario.sUsuario & "</font></font></p>"

        'define the start of the table
        sReportHTML &= "<table width=100% border=1 cellspacing=0 bordercolor=#CCCCCC>"

        'create the header row
        sReportHTML &= "<tr>"
        sReportHTML &= "<td width=8% vAlign=top align=center bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Linha</font></strong></td>"
        sReportHTML &= "<td width=92% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Erro</font></strong></td>"
        sReportHTML &= "</tr>"

        'ProgressBar
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oMensagem.Count
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

        For i As Integer = 0 To UBound(oMensagem)

            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=center><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Linha & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Erro & "</font></td>"
            sReportHTML &= "</tr>"

            'Seta Valor
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

            Application.DoEvents()

        Next i

        'Limpa ProgressBar
        frmMain.stbMain.Panels("pnlProgressBar").Visible = False

        'close page
        sReportHTML &= "</body>"
        sReportHTML &= "</html>"

        'Váriaveis Locais
        Dim sArquivo As String = System.IO.Path.GetTempPath
        sArquivo &= "INTERACTI_ERRO.html"

        If File.Exists(sArquivo) Then
            File.Delete(sArquivo)
        End If

        Using oFileStream As New FileStream(sArquivo, FileMode.Create)
            Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
            oStreamWriter.Write(sReportHTML.ToString())
            oStreamWriter.Close()
            oFileStream.Close()
        End Using

        Process.Start(sArquivo)

    End Function

    Private Sub ImportarArquivoExcel()

        Try

            'Váriaveis Locais
            Dim oMensagem() As MensagemErro
            Dim oApplication As New Excel.Application
            Dim oWorkbook As Excel.Workbook
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
            oArquivoExcel.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Redimensiona Vetor
                ReDim oMensagem(0)
                oMensagem(0).Linha = ""
                oMensagem(0).Erro = ""

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDataRow As DataRow
                Dim oDCPO As New DataColumn("po")
                Dim oDCPOLinha As New DataColumn("po_linha")
                Dim oDCStatus As New DataColumn("status")
                Dim oDCQuantidade As New DataColumn("quantidade")
                Dim oDCDataPrevisaoEntrega As New DataColumn("data_previsao_entrega")
                Dim oDCTipoPO As New DataColumn("tipo_po")
                Dim oDCPrioridade As New DataColumn("prioridade")
                Dim oDCCodigoItem As New DataColumn("codigo_item")
                Dim oDCRevisaoPartNumber As New DataColumn("revisao_part_number")
                Dim oDCCodigoEmbraer As New DataColumn("codigo_embraer")
                Dim oDCValorUnitario As New DataColumn("valor_unitario")
                Dim oDCRequerente As New DataColumn("requerente")
                Dim oDCCentro As New DataColumn("centro")
                Dim oDCValorTotal As New DataColumn("valor_total")
                Dim oDCCiclo As New DataColumn("ciclo")
                Dim oDCUnidadeMedida As New DataColumn("unidade_medida")
                Dim oDCDepositoArmazenamento As New DataColumn("deposito_armazenamento")
                Dim oDCAcaoDias As New DataColumn("acao_dias")
                Dim oDCCodigoCliente As New DataColumn("codigo_cliente")
                Dim oDCCodigoPedido As New DataColumn("codigo_pedido")
                Dim oDCCodigoPedidoItem As New DataColumn("codigo_pedido_item")
                Dim iCodigoCliente As Integer
                Dim sRazaoSocial As String = ""
                Dim lCodigoPedido As Long
                Dim iCodigoPedidoItem As Integer
                Dim sMensagem As String = ""

                'Verifica se o DataSource é Vazio
                If Not grdEmbraer.DataSource Is Nothing Then
                    grdEmbraer.DataSource = Nothing
                End If

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCPO)
                oDataTable.Columns.Add(oDCPOLinha)
                oDataTable.Columns.Add(oDCStatus)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCDataPrevisaoEntrega)
                oDataTable.Columns.Add(oDCTipoPO)
                oDataTable.Columns.Add(oDCPrioridade)
                oDataTable.Columns.Add(oDCCodigoItem)
                oDataTable.Columns.Add(oDCRevisaoPartNumber)
                oDataTable.Columns.Add(oDCCodigoEmbraer)
                oDataTable.Columns.Add(oDCValorUnitario)
                oDataTable.Columns.Add(oDCValorTotal)
                oDataTable.Columns.Add(oDCRequerente)
                oDataTable.Columns.Add(oDCCentro)
                oDataTable.Columns.Add(oDCCiclo)
                oDataTable.Columns.Add(oDCUnidadeMedida)
                oDataTable.Columns.Add(oDCDepositoArmazenamento)
                oDataTable.Columns.Add(oDCAcaoDias)
                oDataTable.Columns.Add(oDCCodigoCliente)
                oDataTable.Columns.Add(oDCCodigoPedido)
                oDataTable.Columns.Add(oDCCodigoPedidoItem)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
                oDCDataPrevisaoEntrega.DataType = Now.Date.GetType
                oDCValorUnitario.DataType = 0.0.GetType
                oDCValorTotal.DataType = 0.0.GetType

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Try

                    'Seta Controles
                    txtArquivoExcel.Text = oArquivoExcel.FileName

                    'Abre o Arquivo
                    oWorkbook = oApplication.Workbooks.Open(oArquivoExcel.FileName)

                    Try
                        'Seleciona Planilha
                        oWorkbook.Sheets.Item(txtPlanilha.Text.Trim).Select()
                    Catch ex As Exception
                        Throw New Exception("Não foi possível encontrar a Planilha: " & txtPlanilha.Text.Trim & " no Arquivo informado.")
                    End Try

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count
                        'Verifica se achou a linha
                        If IsNothing(oWorkbook.Application.Cells(i, cboColunaPO.SelectedIndex + 1).Value) Then
                            Exit For
                        End If
                    Next

                    'ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = i - txtLinhaInicio.Value + 1
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count

                        'Seta ProgressBar
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

                        'Verifica se acabou os registros
                        If oWorkbook.Application.Cells(i, cboColunaPO.SelectedIndex + 1).Value Is Nothing Then
                            Exit For
                        End If

                        'Carrega Dados do Cliente
                        oClsVenEmbraer.LoadDadosCliente(oWorkbook.Application.Cells(i, cboColunaCentro.SelectedIndex + 1).Value, _
                                                        iCodigoCliente, _
                                                        sRazaoSocial)

                        'Carrega Dados do Pedido
                        oClsVenEmbraer.LoadDadosPedido(oWorkbook.Application.Cells(i, cboColunaPO.SelectedIndex + 1).Value, _
                                                       oWorkbook.Application.Cells(i, cboColunaPOLinha.SelectedIndex + 1).Value, _
                                                       lCodigoPedido, _
                                                       iCodigoPedidoItem)

                        'Verifica se foi encontrado o Cliente
                        If iCodigoCliente = -1 Then
                            'Carrega Mensagem de Erro
                            If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                            oMensagem(UBound(oMensagem)).Linha = i
                            oMensagem(UBound(oMensagem)).Erro = "Não foi encontrado Cliente para a PO: " & oWorkbook.Application.Cells(i, cboColunaPO.SelectedIndex + 1).Value & "/" & oWorkbook.Application.Cells(i, cboColunaPOLinha.SelectedIndex + 1).Value & "."
                        Else

                            'Verifica o Status
                            If oWorkbook.Application.Cells(i, cboColunaStatus.SelectedIndex + 1).Value.ToString.Contains("AB") Then

                                'Adiciona Linha
                                oDataRow = oDataTable.NewRow
                                'Preenche Dados da Linha
                                If cboColunaPO.SelectedIndex = -1 Then oDataRow("po") = DBNull.Value Else oDataRow("po") = oWorkbook.Application.Cells(i, cboColunaPO.SelectedIndex + 1).Value
                                If cboColunaPOLinha.SelectedIndex = -1 Then oDataRow("po_linha") = DBNull.Value Else oDataRow("po_linha") = oWorkbook.Application.Cells(i, cboColunaPOLinha.SelectedIndex + 1).Value
                                If cboColunaStatus.SelectedIndex = -1 Then oDataRow("status") = DBNull.Value Else oDataRow("status") = oWorkbook.Application.Cells(i, cboColunaStatus.SelectedIndex + 1).Value
                                If cboColunaQuantidade.SelectedIndex = -1 Then oDataRow("quantidade") = DBNull.Value Else oDataRow("quantidade") = oWorkbook.Application.Cells(i, cboColunaQuantidade.SelectedIndex + 1).Value
                                If cboColunaPrevisaoEntrega.SelectedIndex = -1 Then oDataRow("data_previsao_entrega") = DBNull.Value Else oDataRow("data_previsao_entrega") = oWorkbook.Application.Cells(i, cboColunaPrevisaoEntrega.SelectedIndex + 1).Value
                                If cboColunaTipoPO.SelectedIndex = -1 Then oDataRow("tipo_po") = DBNull.Value Else oDataRow("tipo_po") = oWorkbook.Application.Cells(i, cboColunaTipoPO.SelectedIndex + 1).Value
                                If cboColunaRevisaoPartNumber.SelectedIndex = -1 Or txtPlanilhaDesenho.Text.Trim = "" Then oDataRow("revisao_part_number") = DBNull.Value Else oDataRow("revisao_part_number") = oWorkbook.Application.Cells(i, cboColunaRevisaoPartNumber.SelectedIndex + 1).Value
                                If cboColunaPrioridade.SelectedIndex = -1 Then oDataRow("prioridade") = DBNull.Value Else oDataRow("prioridade") = oWorkbook.Application.Cells(i, cboColunaPrioridade.SelectedIndex + 1).Value
                                If cboColunaCodigoItem.SelectedIndex = -1 Then oDataRow("codigo_item") = DBNull.Value Else oDataRow("codigo_item") = oWorkbook.Application.Cells(i, cboColunaCodigoItem.SelectedIndex + 1).Value
                                If cboColunaCodigoEmbraer.SelectedIndex = -1 Then oDataRow("codigo_embraer") = DBNull.Value Else oDataRow("codigo_embraer") = oWorkbook.Application.Cells(i, cboColunaCodigoEmbraer.SelectedIndex + 1).Value
                                If cboColunaValorUnitario.SelectedIndex = -1 Then oDataRow("valor_unitario") = DBNull.Value Else oDataRow("valor_unitario") = oWorkbook.Application.Cells(i, cboColunaValorUnitario.SelectedIndex + 1).Value
                                If cboColunaValorUnitario.SelectedIndex <> -1 And cboColunaQuantidade.SelectedIndex <> -1 Then oDataRow("valor_total") = oWorkbook.Application.Cells(i, cboColunaValorUnitario.SelectedIndex + 1).Value * oWorkbook.Application.Cells(i, cboColunaQuantidade.SelectedIndex + 1).Value
                                If cboColunaRequerente.SelectedIndex = -1 Then oDataRow("requerente") = DBNull.Value Else oDataRow("requerente") = oWorkbook.Application.Cells(i, cboColunaRequerente.SelectedIndex + 1).Value
                                If cboColunaCiclo.SelectedIndex = -1 Then oDataRow("ciclo") = DBNull.Value Else oDataRow("ciclo") = oWorkbook.Application.Cells(i, cboColunaCiclo.SelectedIndex + 1).Value
                                If cboColunaUnidadeMedida.SelectedIndex = -1 Then oDataRow("unidade_medida") = DBNull.Value Else oDataRow("unidade_medida") = oWorkbook.Application.Cells(i, cboColunaUnidadeMedida.SelectedIndex + 1).Value
                                If cboColunaDepositoArmazenamento.SelectedIndex = -1 Then oDataRow("deposito_armazenamento") = DBNull.Value Else oDataRow("deposito_armazenamento") = oWorkbook.Application.Cells(i, cboColunaDepositoArmazenamento.SelectedIndex + 1).Value
                                If cboColunaAcaoDias.SelectedIndex = -1 Then oDataRow("acao_dias") = DBNull.Value Else oDataRow("acao_dias") = oWorkbook.Application.Cells(i, cboColunaAcaoDias.SelectedIndex + 1).Value
                                oDataRow("centro") = sRazaoSocial
                                oDataRow("codigo_cliente") = iCodigoCliente
                                oDataRow("codigo_pedido") = IIf(lCodigoPedido = -1, DBNull.Value, lCodigoPedido)
                                oDataRow("codigo_pedido_item") = IIf(iCodigoPedidoItem = -1, DBNull.Value, iCodigoPedidoItem)
                                oDataTable.Rows.Add(oDataRow)

                            End If

                        End If

                    Next i

                    'Configura DataMember
                    Call ConfigurarDataMemberGrid(grdEmbraer)

                    'Carrega Grid
                    grdEmbraer.DataSource = oDataSet.DefaultViewManager
                    grdEmbraer.DataMember = oDataSet.Tables(0).TableName

                    'Seta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False

                    'Verifica se é necessário e gera Relatório
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then
                        'Seta Texto
                        pagDados.Text = "Integração - Importar Produtos (Gerando Relatório ...)"
                        Call ReportErro("Integração Embraer", _
                                        "Log de Importação - POACK", _
                                        oMensagem)

                    End If

                Catch ex As Exception
                    Throw ex
                Finally
                    'Oculta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False
                    'Limpa váriavel
                    oWorkbook.Close(False)
                    oWorkbook = Nothing
                    oApplication = Nothing
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End Try

                'DESENHO
                Try

                    If txtPlanilhaDesenho.Text.Trim = "" Then
                        Exit Try
                    End If

                    oApplication = New Excel.Application

                    'Abre o Arquivo
                    oWorkbook = oApplication.Workbooks.Open(oArquivoExcel.FileName)

                    Try
                        'Seleciona Planilha
                        oWorkbook.Sheets.Item(txtPlanilhaDesenho.Text.Trim).Select()
                    Catch ex As Exception
                        Throw New Exception("Não foi possível encontrar a Planilha de Desenho: " & txtPlanilhaDesenho.Text.Trim & " no Arquivo informado.")
                    End Try

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count
                        'Verifica se achou a linha
                        If IsNothing(oWorkbook.Application.Cells(i, cboColunaRevisaoPartNumber.SelectedIndex + 1).Value) Then
                            Exit For
                        End If
                    Next

                    'ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = i - txtLinhaInicio.Value + 1
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count

                        'Seta ProgressBar
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

                        'Verifica se acabou os registros
                        If oWorkbook.Application.Cells(i, cboColunaRevisaoPartNumber.SelectedIndex + 1).Value Is Nothing Then
                            Exit For
                        End If

                        If IsNothing(oWorkbook.Application.Cells(i, 1).Value) = False Then

                            Dim oDataRowDesenho() As DataRow

                            'Adiciona Linha
                            oDataRowDesenho = oDataTable.Select("(codigo_item = '" & oWorkbook.Application.Cells(i, 1).Value & "')")
                            'Preenche Dados da Linha
                            For Each oDataRow In oDataRowDesenho
                                oDataRow("revisao_part_number") = oWorkbook.Application.Cells(i, cboColunaRevisaoPartNumber.SelectedIndex + 1).Value
                            Next

                        End If

                    Next i

                    'Configura DataMember
                    Call ConfigurarDataMemberGrid(grdEmbraer)

                    'Carrega Grid
                    grdEmbraer.DataSource = oDataSet.DefaultViewManager
                    grdEmbraer.DataMember = oDataSet.Tables(0).TableName

                    'Seta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False

                    'Verifica se é necessário e gera Relatório
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then
                        'Seta Texto
                        pagDados.Text = "Integração - Importar Produtos (Gerando Relatório ...)"
                        Call ReportErro("Integração Embraer", _
                                        "Log de Importação - POACK", _
                                        oMensagem)

                    End If

                Catch ex As Exception
                    Throw ex
                Finally
                    'Oculta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False
                    'Limpa váriavel
                    oWorkbook.Close(False)
                    oWorkbook = Nothing
                    oApplication = Nothing
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End Try

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Tipo de Planilha
            If ValidaCampo(cboTipoPlanilha, lblTipoPlanilha) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - PO
            If ValidaCampo(cboColunaPO, lblColunaPO) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - PO Linha
            If ValidaCampo(cboColunaPOLinha, lblColunaPOLinha) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Status
            If ValidaCampo(cboColunaStatus, lblColunaStatus) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Quantidade
            If ValidaCampo(cboColunaQuantidade, lblColunaQuantidade) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Previsão de Entrega
            If ValidaCampo(cboColunaPrevisaoEntrega, lblColunaPrevisaoEntrega) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Código Item
            If ValidaCampo(cboColunaCodigoItem, lblColunaCodigoItem) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Revisão Part Number
            If ValidaCampo(cboColunaRevisaoPartNumber, lblColunaRevisaoPartNumber) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Valor Unitário
            If ValidaCampo(cboColunaValorUnitario, lblColunaValorUnitario) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Centro
            If ValidaCampo(cboColunaCentro, lblColunaCentro) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Linha de Início
            If ValidaCampo(txtLinhaInicio, lblLinhaInicio, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Planilha
            If ValidaCampo(txtPlanilha, lblPlanilha, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoPedidoVenda() As Boolean

        Try

            'Verifica se alguma Linha é Válida
            For Each oRow As GridEXRow In grdEmbraer.GetDataRows
                If IsDBNull(oRow.Cells("codigo_pedido").Value) Then
                    'Seta Retorno da Função
                    Return True
                End If
            Next

            'Informa o Usuário que a Operação não pode ser Realizada
            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Primeiramente Importe a Planilha do POACK.")

            'Seta Retorno da Função
            Return False

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: INTEGRAÇÃO :::"

#Region "::: SELMA :::"

    Private Sub IntegracaoSELMA()

        Try

            'Váriaveis Locais
            Dim sPartNumberRevisaoDesenho As String = ""

            For Each oRow As GridEXRow In grdEmbraer.GetDataRows

                'Verifica se a Revisão do Desenho é igual a Revisão Atual
                If oClsVenEmbraer.SELMAValidaDesenho(sStringConexaoSELMA, _
                                                     oRow.Cells("codigo_item").Value, _
                                                     oRow.Cells("revisao_part_number").Value) = False Then

                    'Carrega Váriavel
                    sPartNumberRevisaoDesenho &= IIf(sPartNumberRevisaoDesenho = "", "", vbCrLf) & oRow.Cells("codigo_item").Value



                End If

            Next

            If sPartNumberRevisaoDesenho <> "" Then

                SendEmail("cleyton.santos@acticonsultoria.com.br", _
                          "", _
                          "", _
                          "INTEGRAÇÃO - POACK", _
                          "SEGUE ABAIXO LISTA DE PART NUMBER COM ALTERAÇÃO NA REVISÃO DO DESENHO: " & vbCrLf & sPartNumberRevisaoDesenho, _
                          "")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#End Region

End Class


