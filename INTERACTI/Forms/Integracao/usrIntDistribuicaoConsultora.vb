Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Data.OleDb

Public Class usrIntDistibuicaoConsultora

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsIntDistribuicaoConsultora As New clsUsrIntDistibuicaoConsultora

#End Region

#Region "::: CONTROLES :::"
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Cursor.Current = Cursors.WaitCursor



            oClsIntDistribuicaoConsultora.Salvar(btnSalvar.Tag)
            btnRelatorioEntrega2.Enabled = True
            'Call Novo()

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnArquivo_Click(sender As Object, e As EventArgs) Handles btnArquivo.Click
        Try
            Call ImportarArquivoExcel()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnNovo2_Click(sender As Object, e As EventArgs) Handles btnNovo2.Click
        Try
            If IsNumeric(btnSalvar.Tag) Then
                ExecuteQuery("delete from tb_int_importacao_distibuicao_consultora_capa where codigo = " & btnSalvar.Tag)
                Call Novo()
            Else

                Call Novo()
            End If


        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnRelatorioEntrega_Click(sender As Object, e As EventArgs) Handles btnRelatorioEntrega.Click
        Try

            Dim sCodigo As String = ""
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then
                For Each oRow In grdListagem.GetCheckedRows
                    sCodigo &= IIf(sCodigo = "", "", ",") & oRow.Cells.Item("codigo_importacao_capa").Value
                Next

                Call ImprimirRelatorio(sCodigo)
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnRelatorioEntrega2_Click(sender As Object, e As EventArgs) Handles btnRelatorioEntrega2.Click
        Try

            Call ImprimirRelatorio(btnSalvar.Tag)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub usrIntImportacaoBoleto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try


    End Sub

    Private Sub usrIntImportacaoBoleto_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDespesa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdImportacao.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdImportacao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdImportacao.GroupByBoxVisible = True
                grdImportacao.HideColumnsWhenGrouped = InheritableBoolean.True

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
            oForm.Grid = grdImportacao
            oForm.NomeFormulario = Formulario.FinanceiroImportarExtrato
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdImportacao, Formulario.FinanceiroImportarExtrato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdImportacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click
        ExportExcel(grdImportacao)
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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try
            'Carrega Grid
            Call LoadGrid()

            If IsNumeric(btnSalvar.Tag) Then
                ExecuteQuery("delete from tb_int_importacao_distibuicao_consultora_capa where codigo = " & btnSalvar.Tag)
            Else

            End If

            'Alterna Aba
            tabMain.TabPages.Remove(pagDespesa)
            tabMain.TabPages.Add(pagListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

   
    Private Sub usrCadCor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub
   

  

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIntImportacaoBoleto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito 
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroImportarExtrato, gcPrint)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.FinanceiroImportarExtrato, gcPrint)

            Call LoadCombo(cboNFEntrada, "sp_select_combo_nota_fiscal_entrada " & goUsuario.iEmpresa)

            dtpDataInicio.Checked = False
            dtpDataTermino.Checked = False



            'Seta Aba
            tabMain.TabPages.Remove(pagDespesa)

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

            'Carrega Controles
            oClsIntDistribuicaoConsultora.LoadGrid(grdListagem, _
                                             txtNotaFiscalFiltro.Text, _
                                             IIf(dtpDataInicio.Checked = False, "", dtpDataInicio.Value), _
                                             IIf(dtpDataTermino.Checked = False, "", dtpDataTermino.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            txtArquivo.Text = ""
            cboNFEntrada.SelectedIndex = -1
            grdImportacao.DataSource = Nothing
            btnSalvar.Tag = ""
            btnRelatorioEntrega2.Enabled = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub ImportarArquivoExcel()

        Try
            frmMain.errInfo.Clear()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oApplicationClass As New Excel.ApplicationClass
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"
            oArquivoExcel.InitialDirectory = "c:\\"

            If ValidaCampo(cboNFEntrada, lblCNAB) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Seta Controles
                txtArquivo.Text = oArquivoExcel.FileName

                'Abre o Arquivo
                oApplicationClass.Workbooks.Open(oArquivoExcel.FileName)

                oClsIntDistribuicaoConsultora.ImportarExcelCapa(cboNFEntrada.SelectedValue, txtArquivo.Text)
                btnSalvar.Tag = oClsIntDistribuicaoConsultora.Codigo

                'Percorre Linha a Linha o Arquivo
                For i = 2 To oApplicationClass.Rows.Count

                    'Verifica se acabou os registros
                    If oApplicationClass.Range("A" & i).Value Is Nothing Then
                        Exit For
                    End If

                    'If IsNumeric(oApplicationClass.Range("A" & i).Value) = False Then
                    '    Exit For
                    'End If

                    'Adiciona(Linha)
                    oClsIntDistribuicaoConsultora.ImportarExcelLinha(btnSalvar.Tag, _
                                                                     cboNFEntrada.SelectedValue, _
                                                                     oApplicationClass.Range("A" & i).Value, _
                                                                     oApplicationClass.Range("B" & i).Value, _
                                                                     oApplicationClass.Range("C" & i).Value)

                Next

                oClsIntDistribuicaoConsultora.LoadGridImportacao(grdImportacao, btnSalvar.Tag)
                oApplicationClass.Workbooks.Close()
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirRelatorio(ByVal sCodigo As String)

        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

           

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja gerar o Relatório de Entrega desse" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)

                    'Seta Parametros
                    goCrystalReport.sReportParameter(0).sParamenter = "@codigo_importacao_capa"
                    goCrystalReport.sReportParameter(0).sValue = sCodigo
                    goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                    goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                    goCrystalReport.sReport = goCrystalReport.sPath & "rptRelatorioEntregaDistribuicaoConsultora.rpt"

                    Dim oReport As New usrReport
                    oReport.Dock = DockStyle.Fill

                    'Abre Relatório
                    frmMain.LoadPageReport("Relatório de Entrega", "Relatório de Entrega", oReport)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region


    
End Class

