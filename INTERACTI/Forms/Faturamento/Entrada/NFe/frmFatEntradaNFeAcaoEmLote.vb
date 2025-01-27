Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports iTextSharp.text.pdf
Public Class frmFatEntradaNFeAcaoEmLote

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmFatEntradaNFeTransmissaoLote As New clsFrmFatEntradaNFeTransmissaoLote
    Private oGrid As GridEX

    Private Structure MensagemErro
        Dim Produto As String
        Dim Tipo As String
        Dim QuantidadeEntrada As String
        Dim SaldoInicial As String
        Dim QuantidadeSaida As String
        Dim SaldoFinal As String
    End Structure
#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmFatEmissaoNFeAcaoEmLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

                Case Keys.Enter
                    Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeAcaoEmLote_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: NFE :::"
    Private Sub btnValidarInutilizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ValidarInutilizacao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    'Private Sub btnValidarEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        ValidarEstoque()
    '    Catch ex As Exception
    '        TratamentoErro(ex.Message, Me.Parent.ToString)
    '    End Try
    'End Sub

   
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnSair2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair2.Click
        'Fecha o Controle
        Me.Dispose()
    End Sub
    Private Sub btnSalvar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar2.Click
        Try
            SalvarDadosEstoque()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnAlterarLocalizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterarLocalizacao.Click
        Try
            AlterarLocalizacao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnAlterarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterarDeposito.Click
        Try
            AlterarDeposito()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"
    Private Sub ValidarInutilizacao()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub ValidarEstoque()
    '    Try
    '        'Seta o retorno
    '        Dim sRetorno As String = oClsFrmFatEmissaoNFeTransmissaoLote.ValidarEstoque(btnValidarEstoque.Tag)


    '        'Quebra a mensagem para informar 
    '        If sRetorno = "" Then
    '            MsgBox("Produtos validados com sucesso!", MsgBoxStyle.Information, "Validando o estoque")
    '            Exit Sub
    '        End If

    '        'Seta o vetor para quebrar a mensagem
    '        Dim oVetorRetorno() As String
    '        Dim oVetorMensagem() As String
    '        oVetorRetorno = sRetorno.Split("%")

    '        'Seta a mnesagem de erro
    '        Dim oMensagemErro(oVetorRetorno.Count - 1) As MensagemErro


    '        'Percorre todos os elementos do vetor
    '        For i As Integer = 0 To oVetorRetorno.Count - 1

    '            oVetorMensagem = oVetorRetorno(i).Split("|")

    '            oMensagemErro(i).Produto = oVetorMensagem(0)
    '            oMensagemErro(i).Tipo = oVetorMensagem(1)
    '            oMensagemErro(i).QuantidadeEntrada = oVetorMensagem(2)
    '            oMensagemErro(i).SaldoInicial = oVetorMensagem(3)
    '            oMensagemErro(i).QuantidadeSaida = oVetorMensagem(4)
    '            oMensagemErro(i).SaldoFinal = oVetorMensagem(5)

    '        Next

    '        'Seta o relatório de erros
    '        Call ReportErro("Faturamento - Validação de Estoque", _
    '                               "Validação do Estoque", _
    '                               oMensagemErro)

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

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
        sReportHTML &= "<td width=30% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>PRODUTO</font></strong></td>"
        sReportHTML &= "<td width=30% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>STATUS</font></strong></td>"
        sReportHTML &= "<td width=10% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>QTD ENTRADA</font></strong></td>"
        sReportHTML &= "<td width=10% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>SALDO INICIAL</font></strong></td>"
        sReportHTML &= "<td width=10% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>QTD SAIDA</font></strong></td>"
        sReportHTML &= "<td width=10% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>SALDO FINAL</font></strong></td>"
        sReportHTML &= "</tr>"

        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oMensagem.Count
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

        For i As Integer = 0 To UBound(oMensagem)

            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Produto & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Tipo & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif color=" & IIf(oMensagem(i).QuantidadeEntrada = 0, "red", "blue") & ">" & oMensagem(i).QuantidadeEntrada & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif color=" & IIf(oMensagem(i).SaldoInicial < 0, "red", "green") & ">" & oMensagem(i).SaldoInicial & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).QuantidadeSaida & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif color=" & IIf(oMensagem(i).SaldoFinal < 0, "red", "green") & ">" & oMensagem(i).SaldoFinal & "</font></td>"
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

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeAcaoEmLote_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Variável auxiliar
            Dim sCodigo As String = ""

            'Percorrendo os codigos ativos
            For Each oRow In oGrid.GetCheckedRows

                'Se já tiver algum código, adiciona o delimitador
                If sCodigo <> "" Then
                    sCodigo += ","
                End If

                'Concatenando o código
                sCodigo += CStr(oRow.Cells.Item("codigo").Value)
            Next

           

            Call LoadComboGrid(grdDeposito, "deposito", "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdDeposito, "localizacao", "sp_select_combo_cadastro_basico_localizacao " & goUsuario.iEmpresa)
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboLocalizacao, "sp_select_combo_cadastro_basico_localizacao " & goUsuario.iEmpresa)

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call oClsFrmFatEntradaNFeTransmissaoLote.LoadGridProduto(sCodigo, grdDeposito)

           


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Integracao(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao
            Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

            'Salva Movimentação - Estoque
            oClsIntegracao.IntegracaoNFEmissaoEstoque(lCodigoEmissaoCapa)
            'Salva Financeiro - Receita
            oClsIntegracao.IntegracaoNFEmissaoFinanceiro(lCodigoEmissaoCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function GerarPDF(ByVal sArquivoSaida As String, ByVal oArquivos() As String) As String

        Dim oPdfWriter As iTextSharp.text.pdf.PdfWriter
        Dim oPdfDoc As iTextSharp.text.Document
        Try



            'Verifica se existe, para excluir
            If System.IO.File.Exists(sArquivoSaida) Then
                System.IO.File.Delete(sArquivoSaida)
            End If

            'Instancia um novo document para adicionar
            oPdfDoc = New iTextSharp.text.Document

            'Cria uma instancia para escrita em pdf
            oPdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(oPdfDoc, New FileStream(sArquivoSaida, FileMode.Create))

            'Abre o document
            oPdfDoc.Open()

            'Percorre o vetor
            For Each sArquivo As String In oArquivos
                If sArquivo = "" Then Continue For
                If New System.IO.FileInfo(sArquivo).Extension.ToUpper = ".PDF" Then
                    AddPdf(sArquivo, oPdfDoc, oPdfWriter)
                End If
            Next

            'Fecha o document
            oPdfDoc.Close()
            oPdfWriter.Close()

            'Retorna o caminho do arquivo criado
            Return sArquivoSaida

        Catch ex As Exception
            oPdfDoc.Close()
            oPdfWriter.Close()
            Throw ex
        End Try
    End Function

    Sub AddPdf(ByVal sInFilePath As String, ByRef oPdfDoc As iTextSharp.text.Document, ByRef oPdfWriter As iTextSharp.text.pdf.PdfWriter)



        Dim oDirectContent As iTextSharp.text.pdf.PdfContentByte = oPdfWriter.DirectContent
        Dim oPdfReader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(sInFilePath)
        Dim iNumberOfPages As Integer = oPdfReader.NumberOfPages
        Dim iPage As Integer = 0

        Do While (iPage < iNumberOfPages)
            iPage += 1

            Dim iRotation As Integer = oPdfReader.GetPageRotation(iPage)
            Dim oPdfImportedPage As iTextSharp.text.pdf.PdfImportedPage = oPdfWriter.GetImportedPage(oPdfReader, iPage)


            oPdfDoc.SetPageSize(oPdfReader.GetPageSizeWithRotation(iPage))
            oPdfDoc.NewPage()

            If (iRotation = 90) Or (iRotation = 270) Then
                oDirectContent.AddTemplate(oPdfImportedPage, 0, -1.0F, 1.0F, 0, 0, oPdfReader.GetPageSizeWithRotation(iPage).Height)
            Else
                oDirectContent.AddTemplate(oPdfImportedPage, 1.0F, 0, 0, 1.0F, 0, 0)
            End If

        Loop

    End Sub

    Private Sub AlterarDeposito()
        Try
            frmMain.errInfo.Clear()

            If ValidaCampo(cboDeposito, lblDeposito) = False Then Exit Sub

            For i As Integer = 0 To grdDeposito.RecordCount - 1
                grdDeposito.Row = i

                If grdDeposito.CurrentRow.CheckState = RowCheckState.Unchecked Then Continue For


                grdDeposito.SetValue("deposito", cboDeposito.SelectedValue)

            Next
            grdDeposito.Row = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AlterarLocalizacao()
        Try
            frmMain.errInfo.Clear()

            If ValidaCampo(cboLocalizacao, lblLocalizacao) = False Then Exit Sub


            For i As Integer = 0 To grdDeposito.RecordCount - 1
                grdDeposito.Row = i

                If grdDeposito.CurrentRow.CheckState = RowCheckState.Unchecked Then Continue For


                grdDeposito.SetValue("localizacao", cboLocalizacao.SelectedValue)

            Next
            grdDeposito.Row = 0
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDadosEstoque()
        Try

            'Atualiza os dados do estoque
            For Each oRow In grdDeposito.GetRows
                If oRow.Cells.Item("deposito").Value = 3 Or oRow.Cells.Item("deposito").Value = 2 Then
                    If oRow.Cells.Item("localizacao").Value = "" Or IsDBNull(oRow.Cells.Item("localizacao").Value) Then
                        MsgBox("É necessário informar a localização para o ESTOQUE BASE/BRINDES!", MsgBoxStyle.OkOnly, "Localização")
                        Exit Sub
                    End If
                End If
                oClsFrmFatEntradaNFeTransmissaoLote.UpdateDadosEstoque(oRow.Cells.Item("codigo").Value, _
                                                                       oRow.Cells.Item("codigo_entrada_item").Value, _
                                                                       IIf(IsDBNull(oRow.Cells.Item("localizacao").Value), "", oRow.Cells.Item("localizacao").Value), _
                                                                       oRow.Cells.Item("deposito").Value)


            Next

            'Roda a integração
            For Each oRow In grdDeposito.GetRows
                Dim oClsIntegracao As New clsIntegracao


                oClsIntegracao.IntegracaoNFEntradaEstoque(oRow.Cells.Item("codigo").Value)
            Next

            'Informa ao usuário
            frmMain.Informacao("Dados salvos com sucesso!", Color.Blue)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region






End Class