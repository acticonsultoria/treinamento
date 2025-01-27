Imports System.IO
Imports System.IO.File
Imports BoletoNet
Imports Janus.Windows.GridEX
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop


Public Class usrIntConciliacaoBancariaASCON

#Region "::: VARIAVEIS :::"

    Private sArquivoNF As StreamWriter
    Private oClsIntegracaoBoletoASCON As New clsUsrIntConciliacaoBancariaASCON

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        Try

            'Gera Arquivo
            GerarArquivoRemessa(True)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub _KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                'Case Keys.Enter
                '    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oApplicationClass As New ApplicationClass
            Dim oWorkbook As Workbook
            Dim oWorksheet As Worksheet

            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.Sheets.Add()
            oWorksheet.Name = "Relatório"

            oWorksheet.Range("A1", "G1").Merge()
            oWorksheet.Range("A1", "G1").Value = "Arquivo de Retorno - " & goUsuario.sEmpresa
            oWorksheet.Range("A1", "G1").Font.Size = 16
            oWorksheet.Range("A1", "G1").HorizontalAlignment = Excel.Constants.xlCenter

            oWorksheet.Range("A2").Value = "Nota Fiscal"
            oWorksheet.Range("B2").Value = "Nº Documento"
            oWorksheet.Range("C2").Value = "Tomador"
            oWorksheet.Range("D2").Value = "Valor Título"
            oWorksheet.Range("E2").Value = "Valor Tarifas"
            oWorksheet.Range("F2").Value = "Valor Pago"
            oWorksheet.Range("G2").Value = "Data Pagamento"

            Dim i As Integer = 3
            For Each oRow As GridEXRow In grdRetorno.GetRows
                If oRow.Cells.Item("valor_pago").Value = 0 Or IsDBNull(oRow.Cells.Item("valor_pago").Value) Then
                    Continue For
                End If
                oWorksheet.Range("A" & CStr(i)).Value = oRow.Cells.Item("nota_fiscal").Value
                oWorksheet.Range("B" & CStr(i)).Value = oRow.Cells.Item("numero_documento").Value
                oWorksheet.Range("C" & CStr(i)).Value = oRow.Cells.Item("sacado").Value
                oWorksheet.Range("D" & CStr(i)).Value = oRow.Cells.Item("valor_titulo").Value
                oWorksheet.Range("D" & CStr(i)).Cells.Style = "Currency"
                oWorksheet.Range("E" & CStr(i)).Value = oRow.Cells.Item("valor_tarifas").Value
                oWorksheet.Range("E" & CStr(i)).Cells.Style = "Currency"
                oWorksheet.Range("F" & CStr(i)).Value = oRow.Cells.Item("valor_pago").Value
                oWorksheet.Range("F" & CStr(i)).Cells.Style = "Currency"
                oWorksheet.Range("G" & CStr(i)).Value = oRow.Cells.Item("data_quitacao").Value

                i = i + 1
            Next

            oWorksheet.Range("D" & CStr(i)).FormulaLocal = "=SOMA(D3" & ":D" & CStr(i - 1) & ")"
            oWorksheet.Range("D" & CStr(i)).Font.Bold = True
            oWorksheet.Range("D" & CStr(i)).HorizontalAlignment = Excel.Constants.xlRight
            oWorksheet.Range("E" & CStr(i)).FormulaLocal = "=SOMA(E3" & ":E" & CStr(i - 1) & ")"
            oWorksheet.Range("E" & CStr(i)).Font.Bold = True
            oWorksheet.Range("E" & CStr(i)).HorizontalAlignment = Excel.Constants.xlRight
            oWorksheet.Range("F" & CStr(i)).FormulaLocal = "=SOMA(F3" & ":F" & CStr(i - 1) & ")"
            oWorksheet.Range("F" & CStr(i)).Font.Bold = True
            oWorksheet.Range("F" & CStr(i)).HorizontalAlignment = Excel.Constants.xlRight

            oWorksheet.Columns.AutoFit()
            oWorksheet.Range("A:A").ColumnWidth = 11
            oWorksheet.Range("B:B").ColumnWidth = 14
            oWorksheet.Range("D:D").ColumnWidth = 12
            oWorksheet.Range("E:E").ColumnWidth = 12
            oWorksheet.Range("F:F").ColumnWidth = 12
            oWorksheet.Range("G:G").ColumnWidth = 15

            oWorksheet.Range("A:B").HorizontalAlignment = Excel.Constants.xlCenter
            oWorksheet.Range("D:G").HorizontalAlignment = Excel.Constants.xlCenter
            oWorksheet.Range("A2", "G2").Font.Bold = True

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            oApplicationClass.Visible = True



        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGrid_Click(sender As Object, e As EventArgs)
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRetorno
            oForm.NomeFormulario = Formulario.IntegracaoBoletoBancario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRetorno, Formulario.IntegracaoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub usrIntConciliacaoBancariaASCON_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call btnFiltrarRemessa_Click(btnFiltrarRemessa, System.EventArgs.Empty) Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrIntConciliacaoBancariaASCON_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REMESSA :::"

    Private Sub btnAgruparGridRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRemessa.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRemessa.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdRemessa.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdRemessa.GroupByBoxVisible = True
                grdRemessa.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRemessa.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRemessa
            oForm.NomeFormulario = Formulario.IntegracaoBoletoBancario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRemessa, Formulario.IntegracaoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRemessa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcelGridRemessa.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdRemessa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarRemessa.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Grid
            Call LoadGridRemessa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarArquivoRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArquivoRemessa.Click

        Try

            'Gera Arquivo
            GerarArquivoRemessa(False)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSairRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairRemessa.Click

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

    Private Sub dtpDataEmissaoRemessaInicioFiltro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataEmissaoRemessaInicioFiltro.ValueChanged, dtpDataEmissaoRemessaInicioFiltro.ValueChanged

        Try

            'Seta MinDate
            dtpDataEmissaoRemessaTerminoFiltro.MinDate = dtpDataEmissaoRemessaInicioFiltro.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRemessa.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessa, _
                                     Formulario.IntegracaoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRemessa.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessa.Name, _
                                     Formulario.IntegracaoBoletoBancario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdRemessa.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRemessa.Name, _
                                          Formulario.IntegracaoBoletoBancario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_RowCheckStateChanged(ByVal sender As Object, ByVal e As RowCheckStateChangeEventArgs) Handles grdRemessa.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdRemessa.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RETORNO :::"

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Call Imprimir(oClsIntegracaoBoletoASCON.CodigoArquivoRetorno, goUsuario.iEmpresa)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnGerarNFSe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarNFSe.Click

        Try

            'Importa Arquivo
            Call GerarNFSe()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
     
    Private Sub btnImportarRetorno_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportarRetorno.Click

        Try

            'Importa Arquivo
            Call ImportarArquivoRetorno()
            If goUsuario.iUsuario <> 1 Then
                btnGerarNFSe.Enabled = False
                btnImprimir.Enabled = False
                btnSalvarRetorno.Enabled = True
            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovoRetorno_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNovoRetorno.Click

        Try

            'Limpa Formulário
            Call NovoRetorno()
            btnSalvarRetorno.Enabled = True
            btnGerarNFSe.Enabled = True
            btnImprimir.Enabled = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRetorno_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcelGridRetorno.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdRetorno)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSairRetorno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairRetorno.Click

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

    Private Sub btnSalvarRetorno_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalvarRetorno.Click

        Try

            'Salva Retorno
            Call SalvarPagamentoRetorno()
            btnGerarNFSe.Enabled = True
            btnImprimir.Enabled = True
            btnSalvarRetorno.Enabled = False

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRetorno_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRetorno.RowDoubleClick
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrFindFinTituloVincularASCON")
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: HISTÓRICO :::"
    Private Sub btnFiltrarHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarHistorico.Click
        Try
            LoadGridHistorico()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcluirHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirHistorico.Click
        Try
            ExcluirHistorico()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdHistorico_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdHistorico.RowDoubleClick
        Try
            If grdHistorico.CurrentColumn.Key = "imprimir" Then
                Imprimir(grdHistorico.GetValue("codigo"), grdHistorico.GetValue("codigo_empresa"))
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

   
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try


            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf _KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Data
            dtpDataEmissaoRemessaInicioFiltro.Value = Now.Date : dtpDataEmissaoRemessaInicioFiltro.Checked = False
            dtpDataEmissaoRemessaTerminoFiltro.Value = Now.Date : dtpDataEmissaoRemessaTerminoFiltro.Checked = False
            dtpDataHistoricoInicio.Value = Now.Date : dtpDataHistoricoInicio.Checked = False
            dtpDataHistoricoTermino.Value = Now.Date : dtpDataHistoricoTermino.Checked = False


            Call LoadCombo(cboEmpresaHistorico, "sp_select_combo_cadastro_basico_empresa")

            'Configura Grid
            Call ConfiguraGrid(grdRemessa, Formulario.IntegracaoBoletoBancario)
            Call ConfiguraGrid(grdRetorno, Formulario.IntegracaoBoletoBancario)

            'Verifica Direito
            btnGerarArquivoRemessa.Enabled = VerificaDireito(Formulario.IntegracaoBoletoBancario, gcInsert)
            btnImportarRetorno.Enabled = VerificaDireito(Formulario.IntegracaoBoletoBancario, gcInsert)

            'Carrega Combo - Tipo de Operacao
            Call LoadCombo(cboBancoContaRemessa, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, True)
            Call LoadCombo(cboBancoContaRetorno, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, True)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REMESSA :::"

    Private Sub LoadGridRemessa()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboBancoContaRemessa, lblBancoContaRemessa) = False Then
                Exit Sub
            End If '

            'Carrega Grid
            Call oClsIntegracaoBoletoASCON.LoadGridRemessa(grdRemessa, _
                                                      IIf(dtpDataEmissaoRemessaInicioFiltro.Checked = True, dtpDataEmissaoRemessaInicioFiltro.Value, ""), _
                                                      IIf(dtpDataEmissaoRemessaTerminoFiltro.Checked = True, dtpDataEmissaoRemessaTerminoFiltro.Value, ""), _
                                                      cboBancoContaRemessa.SelectedValue)

            grdRemessa.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub GerarArquivoRemessa(ByVal bCancelameto As Boolean)

        Try

            'Valida Dados do Formulário
            If ValidacaoRemessa() = True Then

                'Setando o cursor
                Cursor.Current = Cursors.WaitCursor

                'Váriavel Local
                Dim sPath As String = ""
                Dim oFolder As New FolderBrowserDialog

                'Verifica se foi Selecionado algum Arquivo
                If oFolder.ShowDialog = DialogResult.OK Then
                    sPath = oFolder.SelectedPath & "\R" & Format(Now, "MMddHHmm") & "0.rem"
                End If

                'Desabilita FolderDialog
                oFolder.Dispose()

                'Gerando o arquivo
                Call oClsIntegracaoBoletoASCON.GerarArquivoRemessa(grdRemessa, cboBancoContaRemessa.SelectedValue, sPath, bCancelameto)

                'Informando ao usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRemessa() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRemessa = False

            'Verifica se foi Selecionado o Campo - Banco Conta
            If ValidaCampo(cboBancoContaRemessa, lblBancoContaRemessa) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado alguma Nota Fiscal
            If VerificaSelecaoRow(grdRemessa) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRemessa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RETORNO :::"

    Private Sub GerarNFSe()

        Try
            
            'Laço de repetição para verificar os itens
            For i = 0 To grdRetorno.RecordCount - 1
                grdRetorno.Row = i

                'Se não tiver ticado, pular a linha
                If grdRetorno.CurrentRow.CheckState <> RowCheckState.Checked Then Continue For

                If CStr(grdRetorno.CurrentRow.Cells.Item("tipo_movimento").Value.ToString.ToUpper()) = "ENTRADA CONFIRMADA" Then Continue For

                With grdRetorno.CurrentRow.Cells

                    'Somente gerar se não encontrar nenhuma nota
                    If ((IsDBNull(.Item("nota_fiscal").Value())) Or ((.Item("nota_fiscal").Value()) = "")) Then


                        'Gera a NFS-e
                        oClsIntegracaoBoletoASCON.GerarNFSe(.Item("codigo_titulo_capa").Value(), "01/" + .Item("competencia").Value())


                        'Insere a informação no registro
                        grdRetorno.SetValue("nota_fiscal", "A.T.")
                    Else

                        'Informa ao usuário que já existe a NFS-e
                        MsgBox("O nosso número: " & (.Item("nosso_numero").Value()) & "já possui uma nota fiscal / ordem de serviço!")

                        'Sai da função
                        Exit Sub

                    End If

                End With

            Next

            'Seta o registro para a primeira linha
            grdRetorno.Row = 0
            'Informa ao usuário
            frmMain.Informacao("NFS-e(s) gerada(s) com sucesso!", Color.Blue)

            'Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarArquivoRetorno()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboBancoContaRetorno, lblContaBancariaRetorno) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abrindo o dialog para inserir o arquivo
            Dim oFileDialog As New OpenFileDialog
            oFileDialog.Multiselect = True
            ' oFileDialog.Filter = "(Arquivo de Retorno)(*.txt)|*.txt|(*.ret)|*.ret|"
            oFileDialog.Title = "Selecione o arquivo"
            oFileDialog.InitialDirectory = "c:\\dados"
            If oFileDialog.ShowDialog <> DialogResult.OK Then Exit Sub

            'Seta ProgressBar
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oFileDialog.FileNames.Count
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
            frmMain.stbMain.Panels("pnlProgressBar").Visible = True

            oClsIntegracaoBoletoASCON.CodigoEmpresa = goUsuario.iEmpresa

            'Insere na tab main
            Call oClsIntegracaoBoletoASCON.InsertArquivoRetornoCapa(oFileDialog.FileNames(0).ToString)

            'Lendo os arquivos selecionados
            For Each sFileName As String In oFileDialog.FileNames

                'Instanciando
                Dim oFile As New System.IO.FileInfo(sFileName)

                'Informa Arquivo que está sendo lido
                txtArquivoRetorno.Text = "Arquivo:" & sFileName.Replace(oFile.Directory.FullName & "\", "")

                'Carrega Arquivo
                Call oClsIntegracaoBoletoASCON.LoadArquivoRetorno(cboBancoContaRetorno.SelectedValue, grdRetorno, sFileName)

                'Seta Progressbar
                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

                'Verificando eventos pendentes

                System.Windows.Forms.Application.DoEvents()
                'Application.DoEvents()

            Next

            'Oculta Progressbar
            frmMain.stbMain.Panels("pnlProgressBar").Visible = False

            ''Informando ao usuário
            'frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Desabilita Controles
            cboBancoContaRetorno.Enabled = False
            btnImportarRetorno.Enabled = False

        Catch ex As Exception
            frmMain.stbMain.Panels("pnlProgressBar").Visible = False
            frmMain.Informacao(Mensagem.Erro, "Problema encontrado ao tentar importar arquivo.")
            grdRetorno.DataSource = Nothing
        Finally
            txtArquivoRetorno.Text = ""
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub NovoRetorno()

        Try

            'Limpa Registros
            cboBancoContaRetorno.SelectedIndex = -1 : cboBancoContaRetorno.Enabled = True
            txtArquivoRetorno.Text = ""
            grdRetorno.DataSource = Nothing
            btnImportarRetorno.Enabled = True

            Call LoadCombo(cboBancoContaRetorno, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, True)

            'Seta Focu
            cboBancoContaRetorno.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPagamentoRetorno()

        Try

            'Verifica se o Usuário Deseja Salvar os Dados dos Pagamentos
            If MsgBox("Deseja Salvar os Dados do Arquivo de Retorno?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Atualiza Registros
                Call oClsIntegracaoBoletoASCON.SalvarRetorno(grdRetorno, cboBancoContaRetorno.SelectedValue)

                For i As Integer = 0 To grdRetorno.RecordCount - 1
                    grdRetorno.Row = i

                    grdRetorno.SetValue("pago", True)
                Next
                grdRetorno.Row = 0


                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroSalvo)

                ''Limpa Formulário
                'Call NovoRetorno()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir(ByVal lCodigoArquivoRetorno As Long, _
                         ByVal iCodigoEmpresa As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor



            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_arquivo_retorno"
            goCrystalReport.sReportParameter(1).sValue = lCodigoArquivoRetorno
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = iCodigoEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "rptIntArquivoRetorno.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPage("rptIntArquivoRetorno", "Arquivo de Retorno", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: HISTÓRICO :::"

    Private Sub LoadGridHistorico()
        Try
            oClsIntegracaoBoletoASCON.LoadGridHistorico(grdHistorico, _
                                                      IIf(dtpDataHistoricoInicio.Checked = True, dtpDataHistoricoInicio.Value, ""), _
                                                      IIf(dtpDataHistoricoTermino.Checked = True, dtpDataHistoricoTermino.Value, ""), _
                                                      IIf(cboEmpresaHistorico.SelectedIndex = -1, -1, cboEmpresaHistorico.SelectedValue))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirHistorico()
        Try

            If grdHistorico.GetCheckedRows.Count = 0 Then
                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Sub
            End If

            If MsgBox("Deseja excluir os registros selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir histórico de retorno") = vbNo Then Exit Sub

            'Percorre a grid
            For Each oRow In grdHistorico.GetCheckedRows
                oClsIntegracaoBoletoASCON.DeleteHistorico(oRow.Cells.Item("codigo").Value, oRow.Cells.Item("codigo_empresa").Value)

            Next
            'Carrega a grid novamente
            LoadGridHistorico()

            'Informa ao usuário
            frmMain.Informacao("Registos excluídos com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    
#End Region

#End Region

   
End Class