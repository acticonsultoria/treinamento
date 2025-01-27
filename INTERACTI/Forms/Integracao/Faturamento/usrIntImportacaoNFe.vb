Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO
Imports INTERACTI.clsUsrIntImportacaoItem
Imports INTERACTI.NFe.ValidaXML

Public Class usrIntImportacaoNFe

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Arquivo As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsIntImportacaoNFe As New clsUsrIntImportacaoNFe
    Private oLayout As New Hashtable
    Private oImportacao As Importacao

#End Region

#Region "::: CONTROLES :::"
    Private Sub btnTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferir.Click
        Try
            Transferir()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub usrIntImportacaoNFe_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.IntegracaoImportarNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.IntegracaoImportarNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasta.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controle
            txtPasta.Text = ""
            'Carrega Arquivo
            Call LoadArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado Campo - Integracao Financeiro
            If ValidaCampo(cboIntegracaoFinanceiro, lblIntegracaoFinanceiro) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado Campo - Integracao Estoque
            If ValidaCampo(cboIntegracaoEstoque, lblIntegracaoEstoque) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado Campo - Tipo de Nota Fiscal
            If ValidaCampo(cboTipoNotaFiscal, lblTipoNotaFiscal) = False Then
                Exit Sub
            End If

            'Importa Itens
            Call Importar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoNotaFiscal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoNotaFiscal.SelectedIndexChanged

        Try

            'Desabilita Controles
            cboIntegracaoFinanceiro.SelectedIndex = -1 : cboIntegracaoFinanceiro.Enabled = False
            cboIntegracaoEstoque.SelectedIndex = -1 : cboIntegracaoEstoque.Enabled = False
            chkUsoConsumo.Checked = False
            If cboTipoNotaFiscal.SelectedValue.ToString.Substring(0, 1) = "P" Then
                cboIntegracaoFinanceiro.SelectedIndex = -1 : cboIntegracaoFinanceiro.Enabled = True
                cboIntegracaoEstoque.SelectedIndex = -1 : cboIntegracaoEstoque.Enabled = True
                chkUsoConsumo.Checked = False
            Else
                cboIntegracaoFinanceiro.SelectedValue = False
                cboIntegracaoEstoque.SelectedValue = False
                chkUsoConsumo.Checked = False
            End If
            
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo").Value)

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
                                     Formulario.IntegracaoImportarNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.IntegracaoImportarNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"
    Private Sub Transferir()
        Try
            Dim sPasta As String = ""

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Arquivo

            'Váriaveis Locais
            Dim oFolder As New FolderBrowserDialog
            'Verifica se foi Selecionado algum Arquivo
            If oFolder.ShowDialog = DialogResult.OK Then
                sPasta = oFolder.SelectedPath
            End If
            'Desabilita FolderDialog
            oFolder.Dispose()


            'Verifica se foi selecionado alguma Pasta
            If sPasta <> "" Then

                For Each oRow In grdListagem.GetCheckedRows

                    Dim oSystemFile As New System.IO.FileInfo(oRow.Cells.Item("arquivo").Value)
                    System.IO.File.Move(oSystemFile.FullName, oSystemFile.FullName.Replace(oSystemFile.DirectoryName, sPasta))

                Next

            End If

            MsgBox("Arquivos transferidos com sucesso", vbExclamation)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica Direito
            btnPasta.Enabled = VerificaDireito(Formulario.IntegracaoImportarNFe, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.IntegracaoImportarNFe, gcInsert)

            'Carrega Combo
            Call LoadComboSimNao(cboIntegracaoFinanceiro)
            Call LoadComboSimNao(cboIntegracaoEstoque)
            cboTipoNotaFiscal.Items.Clear()
            cboTipoNotaFiscal.Items.Add("EMITIDA POR OUTROS - PRODUTO", "P" & CInt(TipoDocumentoFiscal.Entrada))
            cboTipoNotaFiscal.Items.Add("EMISSÃO PRÓPRIA - PRODUTO - XML", "P" & CInt(TipoDocumentoFiscal.Saida))
            cboTipoNotaFiscal.Items.Add("EMISSÃO PRÓPRIA - NFS JOSEENSE", "S" & CInt(TipoDocumentoFiscal.Saida))

            'Desabilita Controles
            cboIntegracaoFinanceiro.Enabled = False
            cboIntegracaoEstoque.Enabled = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.IntegracaoImportarNFe)

            'Seta Focu
            cboTipoNotaFiscal.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Arquivo
            If txtPasta.Text = "" Then
                'Váriaveis Locais
                Dim oFolder As New FolderBrowserDialog
                'Verifica se foi Selecionado algum Arquivo
                If oFolder.ShowDialog = DialogResult.OK Then
                    txtPasta.Text = oFolder.SelectedPath
                End If
                'Desabilita FolderDialog
                oFolder.Dispose()
            End If

            'Verifica se foi selecionado alguma Pasta
            If txtPasta.Text <> "" Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Limpa Grid
                grdListagem.DataSource = Nothing

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCArquivo As New DataColumn("arquivo")
                Dim oDCImportado As New DataColumn("importado")

                oDCImportado.DataType = False.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCArquivo)
                oDataTable.Columns.Add(oDCImportado)

                'Carrega Arquivos
                Call LoadArquivo(txtPasta.Text, oDataTable)

                'Preenche Grid
                Call ConfigurarDataMemberGrid(grdListagem)

                'Carrega Grid
                grdListagem.DataSource = oDataSet.DefaultViewManager
                grdListagem.DataMember = oDataSet.Tables(0).TableName

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadArquivo(ByVal sFolder As String, _
                            ByRef oDataTable As DataTable)

        Try

            Dim sFile As String = ""
            Dim sFolderChildren As String = ""

            For Each sFile In Directory.GetFiles(sFolder)
                If sFile.ToLower.Contains(".xml") = True Then
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("arquivo") = sFile
                    oDataRow("importado") = oClsIntImportacaoNFe.ArquivoImportado(sFile)
                    oDataTable.Rows.Add(oDataRow)
                End If                
            Next

            For Each sFolderChildren In Directory.GetDirectories(sFolder)
                Call LoadArquivo(sFolderChildren, oDataTable)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtPasta.Text = ""
            grdListagem.DataSource = Nothing

            'Seta Focu
            btnPasta.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Importar()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Carrega Dados da NFe
                Call LoadConfiguracaoNFe()

                'Váriavel Local
                Dim oMensagem() As MensagemErro
                Dim sMensagem As String

                'Redimensiona Vetor
                ReDim oMensagem(0)
                oMensagem(0).Arquivo = ""
                oMensagem(0).Erro = ""

                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = gSelecaoRow.Count
                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                For Each oRow As GridEXRow In gSelecaoRow

                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

                    sMensagem = ""

                    'Verifica se o Arquivo Existe
                    If System.IO.File.Exists(oRow.Cells("arquivo").Value) Then

                        'Carrega Arquivo XML
                        Dim oStreamReader As StreamReader = New StreamReader(oRow.Cells("arquivo").Value.ToString)
                        Dim sArquivoXML As String = oStreamReader.ReadToEnd

                        Try

                            'Verifica o Tipo de Nota Fiscal
                            Select Case cboTipoNotaFiscal.SelectedValue

                                Case "P" & CInt(TipoDocumentoFiscal.Entrada)
                                    oClsIntImportacaoNFe.ImportarXMLEntrada(sArquivoXML, oRow.Cells("arquivo").Value, sMensagem, chkUsoConsumo.Checked)
                                    If sMensagem = "" Then Call IntegracaoEntrada(oClsIntImportacaoNFe.CodigoEmissaoCapa)

                                Case "P" & CInt(TipoDocumentoFiscal.Saida)
                                    oClsIntImportacaoNFe.ImportarXMLEmissao(sArquivoXML, oRow.Cells("arquivo").Value, sMensagem)
                                    If sMensagem = "" Then Call Integracao(oClsIntImportacaoNFe.CodigoEmissaoCapa)

                                Case "S" & CInt(TipoDocumentoFiscal.Saida)
                                    'If (goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD") Then
                                    '    oClsIntImportacaoNFe.ImportarXMLEmissaoServicoAscon(sArquivoXML, oRow.Cells("arquivo").Value, sMensagem)
                                    'Else
                                    oClsIntImportacaoNFe.ImportarXMLEmissaoServico(sArquivoXML, oRow.Cells("arquivo").Value, sMensagem)
                                    'End If

                                    If sMensagem = "" Then Call IntegracaoServico(oClsIntImportacaoNFe.CodigoNFSeCapa)

                            End Select

                            If sMensagem = "" Then
                                ''Atualiza Lista
                                'Call UpdateRegistroGrid(grdListagem, _
                                '                        "(arquivo = '" & oRow.Cells("arquivo").Value & "')", _
                                '                        "importado", _
                                '                        "True")
                                'grdListagem.Refresh()
                            Else
                                If oMensagem(UBound(oMensagem)).Arquivo <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Arquivo = oRow.Cells("arquivo").Value.ToString.Replace(txtPasta.Text.Trim & "\", "")
                                oMensagem(UBound(oMensagem)).Erro = sMensagem
                            End If

                        Catch ex As Exception
                            If oMensagem(UBound(oMensagem)).Arquivo <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                            oMensagem(UBound(oMensagem)).Arquivo = oRow.Cells("arquivo").Value.ToString.Replace(txtPasta.Text.Trim & "\", "")
                            oMensagem(UBound(oMensagem)).Erro = ex.Message
                        End Try

                    End If

                Next

                frmMain.stbMain.Panels("pnlProgressBar").Visible = False

                'Informa o Usuário sobre o Sucesso da Operação
                If oMensagem(0).Arquivo = "" Then
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
                Else
                    Call ReportErro("Integração - Importar NFe", _
                                    "Log de Importação - Integração NFe", _
                                    oMensagem)
                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Integracao(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Verifica se vai efetuar a Integração - Financeiro 
            If cboIntegracaoFinanceiro.SelectedValue = True Then
                oClsIntegracao.IntegracaoNFEmissaoFinanceiro(lCodigoEmissaoCapa)
            End If

            'Verifica se vai efetuar a Integração - Estoque
            If cboIntegracaoEstoque.SelectedValue = True Then
                oClsIntegracao.IntegracaoNFEmissaoEstoque(lCodigoEmissaoCapa)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub IntegracaoServico(ByVal lCodigoNFSeCapa As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Verifica se vai efetuar a Integração - Financeiro 
            If cboIntegracaoFinanceiro.SelectedValue = True Then
                oClsIntegracao.IntegracaoNFSEmissaoFinanceiro(lCodigoNFSeCapa)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub IntegracaoEntrada(ByVal lCodigoEntradaCapa As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Verifica se vai efetuar a Integração - Estoque
            If cboIntegracaoEstoque.SelectedValue = True Then
                oClsIntegracao.IntegracaoNFEntradaEstoque(lCodigoEntradaCapa)
            End If

            'Verifica se vai efetuar a Integração - Financeiro 
            If cboIntegracaoFinanceiro.SelectedValue = True Then
                oClsIntegracao.IntegracaoNFEntradaFinanceiro(lCodigoEntradaCapa)
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

#End Region

 
    Private Sub btnArrumarXML_Click(sender As Object, e As EventArgs) Handles btnArrumarXML.Click
        Try

            Dim oFolder As New FolderBrowserDialog

            If oFolder.ShowDialog = DialogResult.Cancel Then Exit Sub

            Dim oDirectory As New DirectoryInfo(oFolder.SelectedPath)

            For Each oFileInfo As FileInfo In oDirectory.GetFiles



                'Recebe o xml
                Dim sChaveAcesso As String = oFileInfo.Name.ToUpper.Replace(".XML", "")

                'Abre o xml
                Dim oXML As New Xml.XmlDocument
                oXML.Load(oFileInfo.FullName)

                Dim oXMLEnvio As String = "<?xml version=""1.0"" encoding=""UTF-8""?><enviNFe versao=""3.10"" xmlns=""http://www.portalfiscal.inf.br/nfe""><idLote>000001</idLote><indSinc>0</indSinc>"

                'Acrescenta os dados
                oXMLEnvio += oXML.GetElementsByTagName("nfeProc")(0).InnerXml

                'Tira o protocolo
                oXMLEnvio = Mid(oXMLEnvio, 1, InStr(oXMLEnvio, "<protNFe") - 1)

                'Acrescenta o envio
                oXMLEnvio += "</enviNFe>"

                oClsIntImportacaoNFe.ArrumarXML(sChaveAcesso, oXMLEnvio)


            Next

            MsgBox("Atualização concluída!", MsgBoxStyle.Information)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
End Class

