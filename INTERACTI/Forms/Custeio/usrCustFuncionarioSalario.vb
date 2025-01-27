Imports Microsoft.Office.Interop
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrCustFuncionarioSalario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCustFuncionarioSalario As New clsUsrCustFuncionarioSalario

#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCustFuncionarioSalario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCustFuncionarioSalario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCustFuncionarioSalario_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: RH / SALÁRIO E ENCARGOS :::"

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Abre Formulário de Integração com Excel
            Dim oForm As New frmIntExportExcel
            oForm.Grid = grdListagem
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Salva Dados do Registro
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.CellEdited

        Try

            grdListagem.SetValue("valor_total",
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("salario").Value), grdListagem.CurrentRow.Cells("salario").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("valor_hora_extra").Value), grdListagem.CurrentRow.Cells("valor_hora_extra").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("dsr").Value), grdListagem.CurrentRow.Cells("dsr").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("inss").Value), grdListagem.CurrentRow.Cells("inss").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("irrf").Value), grdListagem.CurrentRow.Cells("irrf").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("fgts").Value), grdListagem.CurrentRow.Cells("fgts").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("vale_transporte").Value), grdListagem.CurrentRow.Cells("vale_transporte").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("vale_refeicao").Value), grdListagem.CurrentRow.Cells("vale_refeicao").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("vale_alimentacao").Value), grdListagem.CurrentRow.Cells("vale_alimentacao").Value, 0) + _
                                 IIf(IsNumeric(grdListagem.CurrentRow.Cells("assistencia_medica").Value), grdListagem.CurrentRow.Cells("assistencia_medica").Value, 0))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RHFuncionarioSalario)

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
                                     Formulario.RHFuncionarioSalario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CarregarGrid() Handles cboMes.SelectedIndexChanged, _
                                       cboAno.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado o Mês e o Ano
            If cboMes.SelectedIndex > -1 And cboAno.SelectedIndex > -1 Then
                'Carrega a Grid
                Call LoadGrid()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnArquivoExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoExcel.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Mês
            If ValidaCampo(cboMes, lblMes) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Ano
            If ValidaCampo(cboAno, lblAno) = False Then
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Planilha
            If ValidaCampo(txtPlanilha, lblPlanilha, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Prontuario
            If ValidaCampo(cboConfiguracaoColunaProntuario, lblConfiguracaoColunaProntuario) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Salário
            If ValidaCampo(cboConfiguracaoColunaSalario, lblConfiguracaoColunaSalario) = False Then
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Linha Inicio
            If ValidaCampo(txtLinhaInicio, lblLinhaInicio, True) = False Then
                Exit Sub
            End If

            'Atualiza Dados
            oClsCustFuncionarioSalario.UpdateConfiguracaoArquivoExcel(cboConfiguracaoColunaProntuario.Text, _
                                                                    cboConfiguracaoColunaSalario.Text, _
                                                                    IIf(cboConfiguracaoColunaQuantidadeHoraExtra.SelectedIndex = -1, "", cboConfiguracaoColunaQuantidadeHoraExtra.Text), _
                                                                    IIf(cboConfiguracaoColunaValorHoraExtra.SelectedIndex = -1, "", cboConfiguracaoColunaValorHoraExtra.Text), _
                                                                    IIf(cboConfiguracaoColunaDSR.SelectedIndex = -1, "", cboConfiguracaoColunaDSR.Text), _
                                                                    IIf(cboConfiguracaoColunaINSS.SelectedIndex = -1, "", cboConfiguracaoColunaINSS.Text), _
                                                                    IIf(cboConfiguracaoColunaIRRF.SelectedIndex = -1, "", cboConfiguracaoColunaIRRF.Text), _
                                                                    IIf(cboConfiguracaoColunaFGTS.SelectedIndex = -1, "", cboConfiguracaoColunaFGTS.Text), _
                                                                    IIf(cboConfiguracaoColunaValeTransporte.SelectedIndex = -1, "", cboConfiguracaoColunaValeTransporte.Text), _
                                                                    IIf(cboConfiguracaoColunaValeRefeicao.SelectedIndex = -1, "", cboConfiguracaoColunaValeRefeicao.Text), _
                                                                    IIf(cboConfiguracaoColunaValeAlimentacao.SelectedIndex = -1, "", cboConfiguracaoColunaValeAlimentacao.Text), _
                                                                    IIf(cboConfiguracaoColunaAssistenciaMedica.SelectedIndex = -1, "", cboConfiguracaoColunaAssistenciaMedica.Text), _
                                                                    txtLinhaInicio.Value)

            'Importa Arquivo Excel
            Call ImportarArquivoExcel()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCustFuncionarioSalario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Dim oComboBox(11) As UIComboBox
            Call LoadComboMes(cboMes)
            Call LoadComboAno(cboAno, Now.Year - 10, Now.Year)
            oComboBox(0) = cboConfiguracaoColunaProntuario
            oComboBox(1) = cboConfiguracaoColunaSalario
            oComboBox(2) = cboConfiguracaoColunaQuantidadeHoraExtra
            oComboBox(3) = cboConfiguracaoColunaValorHoraExtra
            oComboBox(4) = cboConfiguracaoColunaDSR
            oComboBox(5) = cboConfiguracaoColunaINSS
            oComboBox(6) = cboConfiguracaoColunaIRRF
            oComboBox(7) = cboConfiguracaoColunaFGTS
            oComboBox(8) = cboConfiguracaoColunaValeTransporte
            oComboBox(9) = cboConfiguracaoColunaValeRefeicao
            oComboBox(10) = cboConfiguracaoColunaValeAlimentacao
            oComboBox(11) = cboConfiguracaoColunaAssistenciaMedica
            Call LoadComboAZ(oComboBox)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Carrega Configuração do Arquivo
            oClsCustFuncionarioSalario.LoadConfiguracaoArquivoExcel(cboConfiguracaoColunaProntuario, _
                                                                    cboConfiguracaoColunaSalario, _
                                                                    cboConfiguracaoColunaQuantidadeHoraExtra, _
                                                                    cboConfiguracaoColunaValorHoraExtra, _
                                                                    cboConfiguracaoColunaDSR, _
                                                                    cboConfiguracaoColunaINSS, _
                                                                    cboConfiguracaoColunaIRRF, _
                                                                    cboConfiguracaoColunaFGTS, _
                                                                    cboConfiguracaoColunaValeTransporte, _
                                                                    cboConfiguracaoColunaValeRefeicao, _
                                                                    cboConfiguracaoColunaValeAlimentacao, _
                                                                    cboConfiguracaoColunaAssistenciaMedica, _
                                                                    txtLinhaInicio)

            'Seta Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.RHFuncionarioSalario, gcInsert)

            'Seta Focu
            cboMes.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: RH / SALÁRIO E ENCARGOS :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsCustFuncionarioSalario.LoadGrid(grdListagem, _
                                                     cboMes.SelectedValue, _
                                                     cboAno.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Salva Dados do Estoque
            oClsCustFuncionarioSalario.Save(grdListagem, _
                                            cboMes.SelectedValue, _
                                            cboAno.SelectedValue)

            'Informa o usuário sobre o sucesso da operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub ImportarArquivoExcel()

        Try

            'Váriaveis Locais            
            Dim oArquivoExcel As New OpenFileDialog

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
            oArquivoExcel.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Variaveis Locais
                Dim oApplication As New Excel.Application
                Dim oWorkbook As Excel.Workbook
                Dim i As Integer
                Dim oMensagem() As MensagemErro
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDataRow As DataRow
                Dim sQuery As String

                'Seta Controles
                txtArquivoExcel.Text = oArquivoExcel.FileName

                'Redimensiona Vetor
                ReDim oMensagem(0)
                oMensagem(0).Linha = ""
                oMensagem(0).Erro = ""

                'Verifica se o DataSource é Vazio
                If Not grdListagem.DataSource Is Nothing Then
                    oDataSet = grdListagem.DataSource.DataSet
                    oDataTable = oDataSet.Tables(0)
                    grdListagem.DataSource = Nothing
                End If

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Try

                    'Abre o Arquivo            
                    oWorkbook = oApplication.Workbooks.Open(txtArquivoExcel.Text)

                    Try
                        'Seleciona Planilha
                        oWorkbook.Sheets.Item(txtPlanilha.Text.Trim).Select()
                    Catch ex As Exception
                        Throw New Exception("Não foi possível encontrar a Planilha: " & txtPlanilha.Text.Trim & " no Arquivo informado.")
                    End Try

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count
                        'Verifica se acabou os registros
                        If oWorkbook.Application.Cells(i, cboConfiguracaoColunaProntuario.SelectedIndex + 1).Value Is Nothing Then
                            Exit For
                        End If
                    Next i

                    'Seta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = i
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 1
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count

                        'Verifica se acabou os registros
                        If oWorkbook.Application.Cells(i, cboConfiguracaoColunaProntuario.SelectedIndex + 1).Value Is Nothing Then
                            Exit For
                        End If

                        sQuery = "(prontuario = '" & oWorkbook.Application.Cells(i, cboConfiguracaoColunaProntuario.SelectedIndex + 1).Value & "')"

                        'Atualiza Linha do Inventário                    
                        If oDataTable.Select(sQuery).Length > 0 Then
                            oDataRow = oDataTable.Select(sQuery)(0)
                            oDataRow("salario") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaSalario.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaQuantidadeHoraExtra.SelectedIndex > -1 Then oDataRow("quantidade_hora_extra") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaQuantidadeHoraExtra.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaValorHoraExtra.SelectedIndex > -1 Then oDataRow("valor_hora_extra") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaValorHoraExtra.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaDSR.SelectedIndex > -1 Then oDataRow("dsr") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaDSR.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaINSS.SelectedIndex > -1 Then oDataRow("inss") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaINSS.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaIRRF.SelectedIndex > -1 Then oDataRow("irrf") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaIRRF.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaFGTS.SelectedIndex > -1 Then oDataRow("fgts") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaFGTS.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaValeTransporte.SelectedIndex > -1 Then oDataRow("vale_transporte") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaValeTransporte.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaValeRefeicao.SelectedIndex > -1 Then oDataRow("vale_refeicao") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaValeRefeicao.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaValeAlimentacao.SelectedIndex > -1 Then oDataRow("vale_alimentacao") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaValeAlimentacao.SelectedIndex + 1).Value
                            If cboConfiguracaoColunaAssistenciaMedica.SelectedIndex > -1 Then oDataRow("assistencia_medica") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaAssistenciaMedica.SelectedIndex + 1).Value

                            oDataRow("valor_total") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaSalario.SelectedIndex + 1).Value + _
                                                      IIf(cboConfiguracaoColunaValorHoraExtra.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaValorHoraExtra.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaDSR.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaDSR.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaINSS.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaINSS.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaIRRF.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaIRRF.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaFGTS.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaFGTS.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaValeTransporte.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaValeTransporte.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaValeRefeicao.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaValeRefeicao.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaValeAlimentacao.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaValeAlimentacao.SelectedIndex + 1).Value, 0) + _
                                                      IIf(cboConfiguracaoColunaAssistenciaMedica.SelectedIndex > -1, oWorkbook.Application.Cells(i, cboConfiguracaoColunaAssistenciaMedica.SelectedIndex + 1).Value, 0)

                        Else
                            'Adiciona Registro a Mensagem
                            If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                            oMensagem(UBound(oMensagem)).Linha = i
                            oMensagem(UBound(oMensagem)).Erro = "Não foi encontrado o Prontuário: " & oWorkbook.Application.Cells(i, cboConfiguracaoColunaProntuario.SelectedIndex + 1).Value & "."
                        End If

                        'Seta ProgressBar
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue + 1

                    Next i

                    'Configura DataMember
                    Call ConfigurarDataMemberGrid(grdListagem)

                    'Carrega Grid
                    grdListagem.DataSource = oDataSet.DefaultViewManager
                    grdListagem.DataMember = oDataSet.Tables(0).TableName

                    'Verifica se é necessário e gera Relatório
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then

                        'Gera Relatório de Erro
                        Call ReportErro("Integração - RH - Funcionário - Salários / Encargos", _
                                        "Log de Importação - RH - Funcionário - Salários / Encargos", _
                                        oMensagem)

                    End If

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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

            End If

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
        sReportHTML &= "<td width=10% vAlign=top align=center bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Linha</font></strong></td>"
        sReportHTML &= "<td width=90% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Erro</font></strong></td>"
        sReportHTML &= "</tr>"

        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oMensagem.Count
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

        For i As Integer = 0 To UBound(oMensagem)

            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Linha & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Erro & "</font></td>"
            sReportHTML &= "</tr>"
            Application.DoEvents()
        Next i

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

#End Region

#End Region

End Class
