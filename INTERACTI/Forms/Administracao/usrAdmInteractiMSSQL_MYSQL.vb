Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports INTERACTI.MySQLHelper
Public Class usrAdmInteractiMSSQL_MYSQL

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrAdmInteractiSQL As New clsUsrAdmInteractiSQL


#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Arquivo As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrAdmInteractiSQL_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Try

            'Configura UserControl
            Call ConfigurarUserControl()

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrAdmInteractiSQL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.Escape
                    'Deleta Aba
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    'Fecha o Controle
                    Me.Dispose()

                Case Keys.F5
                    Call btnExecutar_Click(btnExecutar, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

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
            oForm.NomeFormulario = Formulario.AdministracaoSQL
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoSQL)

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
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se foi Pressionado alguma Coluna
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual Coluna foi Pressionada
            Select Case grdListagem.CurrentColumn.Key

                ' Case "definicao" : Call CarregarDefinicao()

            End Select

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.AdministracaoSQL)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.AdministracaoSQL, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.AdministracaoSQL, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub btnMigrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMigrar.Click
        Try
            'Executa
            Executar(True)

 

           

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecutar.Click

        Try

            Executar(False)

            'Informa o usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(Mensagem.Erro, ex.Message)
        End Try

    End Sub

   
    Private Sub btnDiretorioInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiretorioInput.Click
        Try
            Dim oSaveFolder As New FolderBrowserDialog

            If oSaveFolder.ShowDialog() = DialogResult.OK Then

                txtDiretorioInput.Text = oSaveFolder.SelectedPath + "\"

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnDiretorioOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiretorioOutput.Click
        Try
            Dim oSaveFolder As New FolderBrowserDialog

            If oSaveFolder.ShowDialog() = DialogResult.OK Then

                txtDiretorioOutput.Text = oSaveFolder.SelectedPath + "\"

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnDiretorioSQLines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiretorioSQLines.Click
        Try
            Dim oSaveFolder As New FolderBrowserDialog

            If oSaveFolder.ShowDialog() = DialogResult.OK Then

                txtDiretorioSQLines.Text = oSaveFolder.SelectedPath

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnVerificarPendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificarPendente.Click
        Try
            VerificarPendente()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub Executar(ByVal bMigrar As Boolean)
        Dim iErro As Integer = 0
        Dim oMensagem() As MensagemErro
        Try
            'Monta o dataset
            'Váriavel Local

            'Redimensiona Vetor
            ReDim oMensagem(0)
            oMensagem(0).Arquivo = ""
            oMensagem(0).Erro = ""

            'Seta o valor inicial
            oPrgBar.Value = 0
            oPrgBar.Maximum = grdListagem.GetCheckedRows.Count

            For Each oRow In grdListagem.GetCheckedRows

                If oRow.Cells.Item("tipo").Value = "TABLE" Then oPrgBar.Value += 1 : Application.DoEvents() : Continue For
                If Len(oRow.Cells.Item("nome").Value) > 64 Then oPrgBar.Value += 1 : Application.DoEvents() : Continue For

                'Dim sNome As String = btnExecutar.Tag.ToString.ToLower + ".sql"
                Dim sNome As String = oRow.Cells.Item("nome").Value.ToString.ToLower + ".sql"

                'Cria o arquivo caso não exista
                If System.IO.File.Exists(txtDiretorioInput.Text + sNome) Then
                    System.IO.File.Delete(txtDiretorioInput.Text + sNome)
                End If


                Dim oStreamWriter As New StreamWriter(txtDiretorioInput.Text + sNome, True, System.Text.Encoding.Default)
                oStreamWriter.WriteLine(oClsUsrAdmInteractiSQL.Definicao(oRow.Cells.Item("object_id").Value, oRow.Cells.Item("tipo").Value, oRow.Cells.Item("nome").Value))
                oStreamWriter.Close()

                'Cria o arquivo caso não exista
                If System.IO.File.Exists(txtDiretorioOutput.Text + sNome) Then
                    System.IO.File.Delete(txtDiretorioOutput.Text + sNome)
                End If



                'Executa a migração
                Shell("cmd.exe /c " + txtDiretorioSQLines.Text + "sqlines.exe -s=sql -t=mysql -in=" + txtDiretorioInput.Text + sNome + " -out=" + txtDiretorioOutput.Text + sNome, AppWinStyle.Hide, True)

                'Se já é para migrar 
                If bMigrar = True Then

                    'Abre o arquivo para leitura
                    Dim oStreamReader As New System.IO.StreamReader(txtDiretorioOutput.Text + sNome, System.Text.Encoding.Default)

                    'Lê a query
                    Dim sQuery As String = oStreamReader.ReadToEnd
                    'Fecha o stram reader
                    oStreamReader.Close()

                    'Tirando a ultima informação
                    sQuery = Replace(sQuery, "DELIMITER ;", "")

                    'Tirando o último //
                    sQuery = Mid(sQuery, 1, InStrRev(sQuery, "//") - 1).Trim

                    'Limpa 
                    sQuery = Replace(sQuery, "DELIMITER //", "")



                    'Exclui a procedure se existir
                    ExecuteNonQuery(txtStringConnection.Text, System.Data.CommandType.Text, "DROP PROCEDURE IF EXISTS " + oRow.Cells.Item("nome").Value + ";")
                    'Exclui a FUNCTION se existir
                    ExecuteNonQuery(txtStringConnection.Text, System.Data.CommandType.Text, "DROP FUNCTION IF EXISTS " + oRow.Cells.Item("nome").Value + ";")
                    'Exclui a TRIGGER se existir
                    ExecuteNonQuery(txtStringConnection.Text, System.Data.CommandType.Text, "DROP TRIGGER IF EXISTS " + oRow.Cells.Item("nome").Value + ";")




                    Try
                        ExecuteNonQuery(txtStringConnection.Text, System.Data.CommandType.Text, sQuery)

                    Catch ex As MySql.Data.MySqlClient.MySqlException

                        ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Arquivo = oRow.Cells("nome").Value.ToString
                        oMensagem(UBound(oMensagem)).Erro = ex.Message

                    Catch ex As Exception

                        ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                        oMensagem(UBound(oMensagem)).Arquivo = oRow.Cells("nome").Value.ToString
                        oMensagem(UBound(oMensagem)).Erro = ex.Message

                    End Try



                End If

                'Events
                oPrgBar.Value += 1
                Application.DoEvents()
            Next

            If bMigrar = True Then
                Call ReportErro("Integração - MSSQL -> MySQL", _
                                        "Log de Importação - Migração", _
                                        oMensagem)
            End If
        Catch ex As Exception
            iErro += 1
            ReDim Preserve oMensagem(UBound(oMensagem) + 1)
            oMensagem(UBound(oMensagem)).Arquivo = "SQLINES"
            oMensagem(UBound(oMensagem)).Erro = ex.Message
            If iErro > 15 Then Throw ex
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
        sReportHTML &= "<td width=30% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Arquivo</font></strong></td>"
        sReportHTML &= "<td width=70% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Erro</font></strong></td>"
        sReportHTML &= "</tr>"

        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oMensagem.Count
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

        For i As Integer = 0 To UBound(oMensagem)

            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Arquivo & "</font></td>"
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

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Combo
            Call LoadCombo(cboTipo, "sp_select_combo_tipo_objeto_sql")

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrAdmInteractiSQL_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoSQL)


            txtDiretorioInput.Text = "\\srv-acti-01\Desenvolvimento\Migração MYSQL\INPUT\"
            txtDiretorioOutput.Text = "\\srv-acti-01\Desenvolvimento\Migração MYSQL\output\"
            txtDiretorioSQLines.Text = "E:\MYSQL\SQLINES\"

            txtStringConnection.Text = "Server=srv-acti-01;Port=3306;Database=INTERACTI_PADRAO_PRD;Uid=sa;Pwd=p@ssw0rd013459;"


            'Seta Focu
            cboTipo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carregando os dados
            oClsUsrAdmInteractiSQL.LoadGrid(grdListagem, _
                                            IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                            txtDefinicaoFiltro.Text)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VerificarPendente()
        Try
           
            'Seta os valores
            oPrgBar.Value = 0
            oPrgBar.Maximum = grdListagem.GetRows.Count

            'Laço para verificar todos procedimentos
            For iRow As Integer = 0 To grdListagem.GetRows.Count - 1

                With grdListagem
                    .Row = iRow

                    If .GetValue("tipo") = "TABLE" Then oPrgBar.Value += 1 : Application.DoEvents() : Continue For

                    Dim sSource As String = ""
                    Dim sNomeCampo As String = ""
                    Select Case .GetValue("tipo")
                        Case "STORED PROCEDURE" : sSource = "mysql.proc" : sNomeCampo = "name"
                        Case "TABLE FUNCTION" : sSource = "mysql.func" : sNomeCampo = "name"
                        Case "SCALAR FUNCTION" : sSource = "mysql.func" : sNomeCampo = "name"
                        Case "TRIGGER" : sSource = "information_schema.TRIGGERS" : sNomeCampo = "TRIGGER_NAME"
                        Case "VIEW" : sSource = "mysql.view" : sNomeCampo = "NAME"

                    End Select

                    'Verifica se já existe
                    Dim iCont As Integer = ExecuteScalar(txtStringConnection.Text, CommandType.Text, "SELECT COUNT(*) FROM " + sSource + " WHERE " + sNomeCampo + " = '" + .GetValue("nome") + "'")

                    If iCont > 0 Then
                        .SetValue("migrado", True)
                    Else
                        .SetValue("migrado", False)
                    End If

                    'Incrementa o contador
                    oPrgBar.Value += 1
                    Application.DoEvents()

                End With
            Next

          
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

 
   
End Class
