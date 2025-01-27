Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrEstLocalizacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstLocalizacao As New clsUsrEstLocalizacao
    
#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrEstLocalizacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboDepositoFiltro" : Call LoadCombo(cboDepositoFiltro, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstLocalizacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: LOCALIZAÇÃO :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.EstoqueLocalizacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueLocalizacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.EstoqueLocalizacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.EstoqueLocalizacao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnArquivoExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoExcel.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDepositoFiltro, lblDepositoFiltro) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Código do Item
            If ValidaCampo(cboConfiguracaoColunaCodigoItem, lblConfiguracaoColunaCodigoItem) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Localização
            If ValidaCampo(cboConfiguracaoColunaLocalizacao, lblConfiguracaoColunaLocalizacao) = False Then
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Linha Inicio
            If ValidaCampo(txtLinhaInicio, lblLinhaInicio, True) = False Then
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Planilha
            If ValidaCampo(txtPlanilha, lblPlanilha, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Carrega Grid
            Call LoadGrid()

            'Atualiza Dados
            oClsEstLocalizacao.UpdateConfiguracaoArquivoExcel(cboConfiguracaoColunaCodigoItem.Text, _
                                                              cboConfiguracaoColunaLocalizacao.Text, _
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

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstLocalizacao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadCombo(cboDepositoFiltro, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboConfiguracaoColunaCodigoItem : oComboBox(1) = cboConfiguracaoColunaLocalizacao
            Call LoadComboAZ(oComboBox)

            'Carrega Configuração do Arquivo
            oClsEstLocalizacao.LoadConfiguracaoArquivoExcel(cboConfiguracaoColunaCodigoItem, _
                                                            cboConfiguracaoColunaLocalizacao, _
                                                            txtLinhaInicio)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueLocalizacao)

            'Seta Focu
            cboDepositoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: LOCALIZAÇÃO :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDepositoFiltro, lblDepositoFiltro) = False Then
                cboDepositoFiltro.Focus()
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsEstLocalizacao.LoadGrid(grdListagem, _
                                        cboDepositoFiltro.SelectedValue, _
                                        IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                        txtCodigoProdutoFiltro.Text.Trim, _
                                        txtDescricaoFiltro.Text.Trim, _
                                        txtLocalizacaoFiltro.Text.Trim)

            'Limpa Arquivo
            txtArquivoExcel.Text = ""

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

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDepositoFiltro, lblDepositoFiltro) = False Then
                cboDepositoFiltro.Focus()
                Exit Sub
            End If

            'Salva Dados do Estoque
            oClsEstLocalizacao.Salvar(grdListagem, _
                                      cboDepositoFiltro.SelectedValue)

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
                        If oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoItem.SelectedIndex + 1).Value Is Nothing Then
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
                        If oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoItem.SelectedIndex + 1).Value Is Nothing Then
                            Exit For
                        End If

                        sQuery = "(codigo_produto = '" & oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoItem.SelectedIndex + 1).Value & "')"

                        'Atualiza Linha do Inventário                    
                        If oDataTable.Select(sQuery).Length > 0 Then
                            oDataRow = oDataTable.Select(sQuery)(0)
                            oDataRow("localizacao") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaLocalizacao.SelectedIndex + 1).Value
                        Else
                            'Adiciona Registro a Mensagem
                            If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                            oMensagem(UBound(oMensagem)).Linha = i
                            oMensagem(UBound(oMensagem)).Erro = "Não foi encontrado o Código do Produto: " & oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoItem.SelectedIndex + 1).Value & "."
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
                        Call ReportErro("Integração - Estoque - Localização", _
                                        "Log de Importação - Estoque - Localização", _
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
