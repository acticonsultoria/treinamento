Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports iTextSharp.text.pdf

Public Class frmFatEmissaoNFeAcaoEmLote

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmFatEmissaoNFeTransmissaoLote As New clsFrmFatEmissaoNFeTransmissaoLote
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

    Private Sub frmFatEmissaoNFeAcaoEmLote_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: NFE :::"

    Private Sub btnCadastrarSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarSMS.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadTextoSMS" 
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Call LoadCombo(cboTextoSMS, "sp_select_combo_cadastro_basico_texto_sms " & goUsuario.iEmpresa & ", 1")

            'Seta Focu
            cboTextoSMS.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnBoletoHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoletoHTML.Click
        Try
            ExportarHTML()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnEnviarSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarSMS.Click
        Try
            For i As Integer = 0 To grdNotaFiscalLote.RecordCount - 1
                grdNotaFiscalLote.Row = i

                EnviarSMS_Telefone(grdNotaFiscalLote.GetValue("telefone"))
                EnviarSMS_Telefone(grdNotaFiscalLote.GetValue("telefone2"))
                EnviarSMS_Telefone(grdNotaFiscalLote.GetValue("telefone_recado"))
            Next

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnValidarInutilizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidarInutilizacao.Click
        Try
            ValidarInutilizacao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnValidarEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidarEstoque.Click
        Try

            ValidarEstoque(False)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNotaFiscalLote.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNotaFiscalLote.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNotaFiscalLote.GroupByBoxVisible = True
                grdNotaFiscalLote.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNotaFiscalLote
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalLote, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdNotaFiscalLote)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImprimirNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirNFe.Click

        Try

            'Váriaveis Locais
            Dim sCodigoEmissaoCapa As String = ""

            For Each oRow As GridEXRow In grdNotaFiscalLote.GetDataRows
                sCodigoEmissaoCapa &= IIf(sCodigoEmissaoCapa = "", "", ",") & oRow.Cells("codigo").Value
            Next

            If sCodigoEmissaoCapa = "" Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            Else


                If (txtNotaFiscalInicial.Text = "") And (txtNotaFiscalFinal.Text = "") Then
                    If MsgBox("Os campos de nota fiscal inicial e nota fiscal final estão vazios. Deseja Continuar?", MsgBoxStyle.YesNo, "Emissão em Lote") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If

                Call ImprimirDanfe(sCodigoEmissaoCapa)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnTransmitirNFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitirNFE.Click

        Try
            Dim bValidacao As Boolean
            'Valida Estoque
            Call ValidarEstoque(True, bValidacao)

            If bValidacao = True Then
                'Transmitir Lote
                Call TransmitirLote()
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelarNFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarNFe.Click

        Try

            'Transmitir Lote
            Call CancelarLote()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnRetornarNFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornarNFE.Click

        Try

            'Retornar Lote
            Call RetornarLote()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click

        Try

            EnviarEmailLote(True)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnEmailOutlook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailOutlook.Click
        Try
            EnviarEmailLote(False)

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
            Throw ex
        End Try
    End Sub

    Private Sub btnExportarBoletoBancario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarBoletoBancario.Click

        Try

            'Exporta Boleto Bancário
            'ExportarBoletoBancario(False)
            ExportarBoletoBancarioCrystal(False)

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub btnExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPDF.Click

        Try

            'Verifica se o Usuário tem Direito de Imprimir Danfe
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = True Then

                'Carrega Dados do Emitente
                Call LoadDadosEmitente()

                'Carrega Configurações da NFe
                Call LoadConfiguracaoNFe()

                'Váriaveis Locais
                Dim oFolderDialog As New FolderBrowserDialog
                Dim sFolder As String

                If txtQuantidadeAguardandoTransmissao.Value > 0 Then
                    If MsgBox("Existem notas que ainda não foram transmitidas. Elas não serão impressas, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Impressão de DANFE") = vbNo Then Exit Sub
                ElseIf txtQuantidadeAguardandoRetorno.Value > 0 Then
                    If MsgBox("Existem notas que ainda não foram retornaram. Elas não serão impressas, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Impressão de DANFE") = vbNo Then Exit Sub
                ElseIf txtQuantidadeRejeitada.Value > 0 Then
                    If MsgBox("Existem notas que foram rejeitadas. Elas não serão impressas, deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Impressão de DANFE") = vbNo Then Exit Sub
                End If

                'Verifica se foi selecionado alguma Pasta
                If oFolderDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                    'Seta Váriavel
                    sFolder = oFolderDialog.SelectedPath & "\"

                    'E-mail com NFe
                    For Each oRow As GridEXRow In grdNotaFiscalLote.GetDataRows
                        If oRow.Cells.Item("status").Value = StatusNotaFiscalEletronica.AutorizadaUso Or oRow.Cells.Item("status").Value = StatusNotaFiscalEletronica.EnviadoDestinatario Then
                            Call ExportarPDF(oRow.Cells("codigo").Value, sFolder, "NF" & Format(oRow.Cells("nota_fiscal").Value, "000000000"))
                        End If
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalLote_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNotaFiscalLote.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalLote, _
                                     Formulario.FaturamentoEmissaoNFe)

            ''Carrega Combo
            'Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalLote)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalLote_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNotaFiscalLote.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalLote.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

            ''Carrega Combo
            'Call LoadComboColunasGrid(cboCongelarColuna, grdNotaFiscalLote)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalLote_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdNotaFiscalLote.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNotaFiscalLote.Name, _
                                          Formulario.FaturamentoEmissaoNFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExportarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXML.Click
        Try
            ExportarXML()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnBoletoNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoletoNFe.Click
        Try
            ExportarBoletoBancario(True)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
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

    Private Sub ExportarHTML()
        Try
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


            'Verifica os títulos distintos para gerar os boletos
            Dim sCodigoTituloCapa As String = oClsFrmFatEmissaoNFeTransmissaoLote.GerarBoleto(sCodigo)

            'Váriaveis Locais
            Dim sArquivoBoleto As String = ""

            'Instancia para gerar os boletos
            Dim oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario


            'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
            Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmmss") + "\"

            'Exclui o diretório se existir
            If System.IO.Directory.Exists(sDiretorio) Then
                System.IO.Directory.Delete(sDiretorio)
            Else
                'Cria  a pasta
                System.IO.Directory.CreateDirectory(sDiretorio)
            End If

            

            'Instancia 
            Dim oClsPDFCreator As New clsPDFCreator

        
          
            'Gera Arquivo
            oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLote(sCodigoTituloCapa, sDiretorio, sArquivoBoleto, True)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub EnviarEmailLote(ByVal bEnvioDireto As Boolean)
        Try
            'Verifica se o Usuário tem Direito de Imprimir Danfe
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = True Then

                'Carrega Dados do Emitente
                Call LoadDadosEmitente()

                'Carrega Configurações da NFe
                Call LoadConfiguracaoNFe()

                'E-mail com NFe
                For iRow As Integer = 0 To grdNotaFiscalLote.RecordCount - 1

                    'Seta o numero da linha
                    grdNotaFiscalLote.Row = iRow

                    'Se não existir email, pular
                    If grdNotaFiscalLote.GetValue("email_destinatario") <> "" Then


                        Dim bSomenteBoleto As Boolean = False

                        If IsDBNull(grdNotaFiscalLote.GetValue("numero_protocolo")) = True Then

                            bSomenteBoleto = True

                        ElseIf CStr(grdNotaFiscalLote.GetValue("numero_protocolo")) = "" Then

                            bSomenteBoleto = True

                        End If

                        'Rotina para enviar o email
                        Call EmailNFe(grdNotaFiscalLote.GetValue("codigo"), grdNotaFiscalLote.GetValue("email_destinatario"), grdNotaFiscalLote.GetValue("status"), bEnvioDireto, bSomenteBoleto)

                    End If


                    ''Não enviará SMS caso o pagamento não for a vista
                    'If IsDBNull(grdNotaFiscalLote.GetValue("pagamento_vista")) Then Continue For
                    'If grdNotaFiscalLote.GetValue("pagamento_vista") = False Then Continue For

                    'Envia o SMS


                    If bSistemaPerforma = False Then
                        EnviarSMS_Telefone(grdNotaFiscalLote.GetValue("telefone"))
                        EnviarSMS_Telefone(grdNotaFiscalLote.GetValue("telefone2"))
                        EnviarSMS_Telefone(grdNotaFiscalLote.GetValue("telefone_recado"))
                    End If

                Next

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Private Sub EnviarSMS_Telefone(ByVal sTelefone As String)
        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboTextoSMS, lblMensagemSMS) = False Then Exit Sub

            If sTelefone <> "" Then

                'Verifica o nome do destinatário para trocar depois
                Dim sNome As String = Mid(grdNotaFiscalLote.GetValue("destinatario"), 1, InStr(grdNotaFiscalLote.GetValue("destinatario"), " "))

                'Recebe a mensagem pré formatada
                Dim sMensagem As String = cboTextoSMS.Text

                'Troca os dados
                sMensagem = Replace(sMensagem, "|NOME|", sNome.Trim)
                sMensagem = Replace(sMensagem, "|CODIGO|", grdNotaFiscalLote.GetValue("codigo_consultora"))
                sMensagem = Replace(sMensagem, "|SEMANA|", grdNotaFiscalLote.GetValue("semana"))




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

                'Envia e recebe o retorno
                Dim sRetorno As String = oWebSMS.EnviaSMS("twmagma", _
                                        "serv56", _
                                         "A" + CStr(iNumeroControle).PadLeft(9, "0"), _
                                        sTelefone, _
                                        sMensagem)

                'Seta os dados 
                grdNotaFiscalLote.SetValue("mensagem", grdNotaFiscalLote.GetValue("mensagem") + " - " + Replace(sRetorno, "OK", "SMS enviado!"))


                'Insere no controle
                InsertControleSMS(grdNotaFiscalLote.GetValue("codigo"), _
                                  "", _
                                  "", _
                                  "", _
                                sTelefone, _
                                sMensagem, _
                                sRetorno, _
                                iNumeroControle)



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try
    End Sub

    Private Sub ValidarInutilizacao()
        Try


            'Dim oWebSMS As New WebSMSSend.ReluzCapWebService

            'MsgBox(oWebSMS.EnviaSMS("twmagma", "serv56", "ACTI000001", "5512991783142", "TESTE DE ENVIO DO INTERACTI"))


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ValidarEstoque(ByVal bTransmissao As Boolean, _
                              Optional ByRef bValidacao As Boolean = False)
        Try


            'Seta o retorno
            Dim sRetorno As String = oClsFrmFatEmissaoNFeTransmissaoLote.ValidarEstoque(btnValidarEstoque.Tag, bTransmissao)

            If sRetorno = "" Then
                bValidacao = True
                If bTransmissao = False Then
                    MsgBox("Produtos validados com sucesso!", MsgBoxStyle.Information, "Validando o estoque")
                End If
                Exit Sub
            End If

            'Seta o vetor para quebrar a mensagem
            Dim oVetorRetorno() As String
            Dim oVetorMensagem() As String
            oVetorRetorno = sRetorno.Split("%")

            'Seta a mnesagem de erro
            Dim oMensagemErro(oVetorRetorno.Count - 1) As MensagemErro


            'Percorre todos os elementos do vetor
            For i As Integer = 0 To oVetorRetorno.Count - 1

                oVetorMensagem = oVetorRetorno(i).Split("|")

                oMensagemErro(i).Produto = oVetorMensagem(0)
                oMensagemErro(i).Tipo = oVetorMensagem(1)
                oMensagemErro(i).QuantidadeEntrada = oVetorMensagem(2)
                oMensagemErro(i).SaldoInicial = oVetorMensagem(3)
                oMensagemErro(i).QuantidadeSaida = oVetorMensagem(4)
                oMensagemErro(i).SaldoFinal = oVetorMensagem(5)

            Next

            'Seta o relatório de erros
            Call ReportErro("Faturamento - Validação de Estoque", _
                                   "Validação do Estoque", _
                                   oMensagemErro)
            bValidacao = False

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

            'Seta o codigo
            btnValidarEstoque.Tag = sCodigo

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalLote, Formulario.FaturamentoEmissaoNFe)

            Call LoadComboGrid(grdDeposito, "deposito", "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdDeposito, "localizacao", "sp_select_combo_cadastro_basico_localizacao " & goUsuario.iEmpresa)
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboLocalizacao, "sp_select_combo_cadastro_basico_localizacao " & goUsuario.iEmpresa)
            Call LoadCombo(cboTextoSMS, "sp_select_combo_cadastro_basico_texto_sms " & goUsuario.iEmpresa & ", 1")

            ' cboTextoSMS.SelectedValue = 1

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call oClsFrmFatEmissaoNFeTransmissaoLote.LoadGrid(sCodigo, grdNotaFiscalLote)
            Call oClsFrmFatEmissaoNFeTransmissaoLote.LoadGridProduto(sCodigo, grdDeposito)

            'Verifica a quantidade por Status
            Call VerificarQuantidade()

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalLote, Formulario.FaturamentoEntradaNF)

            'Configuração do SMS
            'txtMensagemSMS.Text = "Prezado(a) Consultor(a) |NOME|  (|CODIGO|), Magma informa: DANFE e boleto referente a sua compra da semana |SEMANA| foram enviados para seu e-mail."

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ExportarPDF(ByVal lCodigoEmissaoCapa As Long, _
                            ByVal sFolder As String, _
                            ByVal sNotaFiscal As String)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "FAT000000003.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Váriavel Relatório
            Dim sArquivoReport As String = sFolder & sNotaFiscal & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

            'Fecha o rpt
            oRptDocument.Close()
            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TransmitirLote()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Percorrendo as linhas
            For i As Integer = 0 To grdNotaFiscalLote.RecordCount - 1

                'Setando a linha
                grdNotaFiscalLote.Row = i

                If grdNotaFiscalLote.GetValue("status") = StatusNotaFiscalEletronica.AguardandoTransmissao Or grdNotaFiscalLote.GetValue("status") = StatusNotaFiscalEletronica.Rejeitada Then

                    'Váriaveis Locais
                    Dim oClsNFeRecepcaoLote As New clsNFeRecepcaoLote_V4
                    Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

                    'Seta o codigo da emissao capa
                    oClsFatEmissaoNFe.CodigoEmissaoCapa = grdNotaFiscalLote.GetValue("codigo")

                    'Se for para Magma, atualizar para a data atual
                    If goEmitente.sRazaoSocial.Contains("MAGMA") Then
                        oClsFatEmissaoNFe.UpdateDataEmissao(grdNotaFiscalLote.GetValue("codigo"))
                    End If


                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Gera Número da Nota Fiscal
                    If IsDBNull(grdNotaFiscalLote.GetValue("nota_fiscal")) Then
                        grdNotaFiscalLote.SetValue("nota_fiscal", oClsFatEmissaoNFe.GeraNumeroNotaFiscal)
                    End If

                    'Gera Número do Lote
                    grdNotaFiscalLote.SetValue("lote", oClsFatEmissaoNFe.GeraNumeroLote)

                    'Seta Parâmetros - Lote
                    oClsNFeRecepcaoLote.Lote = grdNotaFiscalLote.GetValue("lote")

                    'Transmite Arquivo
                    If oClsNFeRecepcaoLote.Send() = True Then

                        'Carrega Arquivo
                        oClsNFeRecepcaoLote.LoadArquivo(oClsNFeRecepcaoLote.PathArquivoRetorno)

                        'Caso o Status Lote Recebido com Sucesso
                        If oClsNFeRecepcaoLote.Status = 103 Then

                            'Atualiza Dados da NFe
                            oClsFatEmissaoNFe.UpdateNFeEnvio(oClsNFeRecepcaoLote.Motivo, _
                                                             oClsNFeRecepcaoLote.ChaveAcesso, _
                                                             oClsNFeRecepcaoLote.Recibo, _
                                                             oClsNFeRecepcaoLote.ArquivoEnvio, _
                                                             oClsNFeRecepcaoLote.ArquivoRetorno, _
                                                             grdNotaFiscalLote.GetValue("lote"), _
                                                             goConfiguracaoNFe.iCodigoTipoAmbienteNFe)

                            'Seta Controles
                            grdNotaFiscalLote.SetValue("status2", "AGUARDANDO RETORNO")
                            grdNotaFiscalLote.SetValue("status", StatusNotaFiscalEletronica.AguardandoRetorno)
                            grdNotaFiscalLote.SetValue("mensagem", oClsNFeRecepcaoLote.Motivo)
                            grdNotaFiscalLote.SetValue("chave_acesso", oClsNFeRecepcaoLote.ChaveAcesso)
                            grdNotaFiscalLote.SetValue("numero_recibo", oClsNFeRecepcaoLote.Recibo)




                        End If

                    Else

                        'Seta Chave de Acesso
                        grdNotaFiscalLote.SetValue("chave_acesso", oClsNFeRecepcaoLote.ChaveAcesso)
                        'Informa o Usuário sobre o Erro Ocorrido
                        grdNotaFiscalLote.SetValue("mensagem", oClsNFeRecepcaoLote.MensagemErro)

                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

                'Contabiliza as quatidades
                Call VerificarQuantidade()
                Application.DoEvents()

            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarLote()

        Try

            Dim sNotaFiscal As String = ""

            'Percorre somente para identificar as notas que serão canceladas
            For Each oRow In grdNotaFiscalLote.GetRows

                If oRow.Cells.Item("status").Value = StatusNotaFiscalEletronica.AutorizadaUso Or oRow.Cells.Item("status").Value = StatusNotaFiscalEletronica.EnviadoDestinatario Then
                    sNotaFiscal += IIf(sNotaFiscal = "", "", " , ") + CStr(oRow.Cells.Item("nota_fiscal").Value)
                End If

            Next

            'Abre o formulário apenas para trazer a justificativa
            Dim oForm As New frmFatEmissaoNFeCancelarLote
            oForm.txtNotaFiscal.Text = sNotaFiscal
            oForm.ShowDialog()

            'Verifica 
            Dim sJustificativa As String = oForm.txtJustificativa.Text

            'Se não foi digitada a justificativa, sai da sub
            If sJustificativa = "" Then Exit Sub


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Instancia a variável
            Dim oClsFatEmissaoNFeCancelar As New clsFrmFatEmissaoNFeCancelar

            'Percorrendo os registros
            For i As Integer = 0 To grdNotaFiscalLote.RecordCount - 1

                'Setando a linha
                grdNotaFiscalLote.Row = i

                'Verificando se é para fazer o retorno
                If grdNotaFiscalLote.GetValue("status") = StatusNotaFiscalEletronica.AutorizadaUso Or grdNotaFiscalLote.GetValue("status") = StatusNotaFiscalEletronica.EnviadoDestinatario Then


                    'Instancia a variável
                    Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

                    'Seta o codigo da emissao capa
                    oClsFatEmissaoNFe.CodigoEmissaoCapa = grdNotaFiscalLote.GetValue("codigo")

                    'Inutilização de Numeração
                    Dim oNFeEventoCancelamento As New clsNFeEventoCancelamento_V4

                    'Seta Paramentros
                    oNFeEventoCancelamento.Chave = grdNotaFiscalLote.GetValue("chave_acesso")
                    oNFeEventoCancelamento.NumeroProtocoloAutorizacao = grdNotaFiscalLote.GetValue("numero_protocolo")
                    oNFeEventoCancelamento.Justificativa = sJustificativa
                    oNFeEventoCancelamento.DataEmissao = Now
                    oNFeEventoCancelamento.Sequencia = "01"

                    'Cancela NF-e
                    If oNFeEventoCancelamento.Send = True Then

                        'Carrega Arquivo
                        oNFeEventoCancelamento.LoadArquivo(oNFeEventoCancelamento.PathArquivoRetorno)

                        'Verifica se foi homologado o cancelamento
                        If oNFeEventoCancelamento.Status = 135 Or oNFeEventoCancelamento.Status = 136 Or oNFeEventoCancelamento.Status = 155 Then

                            'Atualiza Nota Fiscal Eletrônica
                            oClsFatEmissaoNFeCancelar.UpdateNFeCancelamento(oNFeEventoCancelamento.Motivo, _
                                                                            oNFeEventoCancelamento.Chave, _
                                                                            sJustificativa, _
                                                                            oNFeEventoCancelamento.XMLCancelamentoEnvio, _
                                                                            oNFeEventoCancelamento.XMLCancelamentoRecepcao)


                            'Aplica a integração
                            Call Integracao(grdNotaFiscalLote.GetValue("codigo"))


                            'Informa
                            grdNotaFiscalLote.SetValue("status2", "Nota Fiscal Cancelada com sucesso!")
                            grdNotaFiscalLote.SetValue("status", StatusNotaFiscalEletronica.Cancelada)
                            grdNotaFiscalLote.SetValue("mensagem", "Nota Fiscal Cancelada com sucesso!")


                        ElseIf oNFeEventoCancelamento.Status = 420 Then

                            Dim sProtocolo As String = ""
                            sProtocolo = oNFeEventoCancelamento.Motivo
                            sProtocolo = Mid(sProtocolo, InStr(sProtocolo, "[") - 1)
                            sProtocolo = Mid(sProtocolo, InStr(sProtocolo, ":") + 1)
                            sProtocolo = Replace(sProtocolo, "]", "")


                            'Atualiza Nota Fiscal Eletrônica
                            oClsFatEmissaoNFeCancelar.UpdateNFeCancelamento("CANCELAMENTO DA NF-E HOMOLOGADO", _
                                                                            oNFeEventoCancelamento.Chave, _
                                                                            sJustificativa, _
                                                                            oNFeEventoCancelamento.XMLCancelamentoEnvio, _
                                                                            oNFeEventoCancelamento.XMLCancelamentoRecepcao)

                            'Aplica a integração
                            Call Integracao(grdNotaFiscalLote.GetValue("codigo"))


                            'Informa
                            grdNotaFiscalLote.SetValue("status2", "Nota Fiscal Cancelada com sucesso!")
                            grdNotaFiscalLote.SetValue("status", StatusNotaFiscalEletronica.Cancelada)
                            grdNotaFiscalLote.SetValue("mensagem", "Nota Fiscal Cancelada com sucesso!")

                        Else
                            'Informa o Usuário sobre o Erro da Operação
                            grdNotaFiscalLote.SetValue("mensagem", oNFeEventoCancelamento.Motivo)
                        End If

                    Else
                        'Informa o Usuário sobre o Erro Ocorrido
                        grdNotaFiscalLote.SetValue("mensagem", oNFeEventoCancelamento.MensagemErro)
                    End If



                End If

                'Contabiliza as quatidades
                Call VerificarQuantidade()
                Application.DoEvents()
            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o usuário sobre o Sucesso da Operação
            MsgBox("Notas fiscais canceladas com sucesso!")

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RetornarLote()

        Try

            'Váriaveis Locais
            Dim oClsNFeConsultaRecepcaoNFe As New clsNFeConsultaRecepcaoNFe_V4

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Percorrendo os registros
            For i As Integer = 0 To grdNotaFiscalLote.RecordCount - 1

                'Setando a linha
                grdNotaFiscalLote.Row = i

                'Verificando se é para fazer o retorno
                If grdNotaFiscalLote.GetValue("status") = StatusNotaFiscalEletronica.AguardandoRetorno Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

                    'Seta o codigo da emissao capa
                    oClsFatEmissaoNFe.CodigoEmissaoCapa = grdNotaFiscalLote.GetValue("codigo")


                    'Seta Parâmetros
                    oClsNFeConsultaRecepcaoNFe.Recibo = grdNotaFiscalLote.GetValue("numero_recibo")
                    oClsNFeConsultaRecepcaoNFe.Lote = grdNotaFiscalLote.GetValue("lote")

                    'Consulta Situação
                    If oClsNFeConsultaRecepcaoNFe.Send() = True Then

                        'Carrega Arquivo
                        oClsNFeConsultaRecepcaoNFe.LoadArquivo(oClsNFeConsultaRecepcaoNFe.PathArquivoRetorno)

                        'Verifica se foi o Arquivo está aceito
                        If oClsNFeConsultaRecepcaoNFe.Status = 104 Then

                            'Váriavel - Protocolo
                            Dim oProtocoloNFe As InformacaoProtocoloNFe

                            For j = 0 To UBound(oClsNFeConsultaRecepcaoNFe.ProtocoloNFe)

                                oProtocoloNFe = oClsNFeConsultaRecepcaoNFe.ProtocoloNFe(j)

                                'Atualiza Nota Fiscal
                                oClsFatEmissaoNFe.UpdateNFeRetorno(oProtocoloNFe.sMotivo, _
                                                                   oProtocoloNFe.sChaveAcesso, _
                                                                   oProtocoloNFe.sNumeroProtocolo, _
                                                                   IIf(oProtocoloNFe.iStatus = 100, CInt(StatusNotaFiscalEletronica.AutorizadaUso), CInt(StatusNotaFiscalEletronica.Rejeitada)), _
                                                                   oClsNFeConsultaRecepcaoNFe.ArquivoRetornoXML)

                                Select Case oProtocoloNFe.iStatus



                                    Case 100
                                        'Seta Controles
                                        grdNotaFiscalLote.SetValue("status2", "AUTORIZADA PARA USO")
                                        grdNotaFiscalLote.SetValue("status", StatusNotaFiscalEletronica.AutorizadaUso)
                                        'Executa Integração
                                        Call Integracao(grdNotaFiscalLote.GetValue("codigo"))



                                        Dim lCodigo As Long = grdNotaFiscalLote.GetValue("codigo")
                                        Dim sChaveAcesso As String = grdNotaFiscalLote.GetValue("chave_acesso")
                                        Dim sNotaFiscal As String = grdNotaFiscalLote.GetValue("nota_fiscal")
                                        Dim lCodigoParceiroNegocio As Long = grdNotaFiscalLote.GetValue("codigo_destinatario")
                                        Dim lCodigoTituloCapa As Long = -1


                                        Dim sArquivoNFe As String = ""
                                        Dim sArquivoProtocoloNFe As String = ""
                                        Dim sArquivoCancelamentoNFe As String = ""
                                        Dim sArquivoProtocoloCancelamentoNFe As String = ""
                                        Dim sMensagemErro As String = ""


                                        Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4


                                        'Carrega Dados da Nota Fiscal
                                        oClsFatEmissaoNFe.LoadDadosNFe(lCodigo, _
                                                                      sArquivoNFe, _
                                                                      sArquivoProtocoloNFe, _
                                                                      sArquivoCancelamentoNFe, _
                                                                      sArquivoProtocoloCancelamentoNFe, _
                                                                      sChaveAcesso, _
                                                                      sNotaFiscal, _
                                                                      lCodigoParceiroNegocio,
                                                                      lCodigoTituloCapa)


                                        'Verifica se foi possível gerar o Arquivo
                                        If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                                            sArquivoProtocoloNFe, _
                                                                            sChaveAcesso, _
                                                                            "", _
                                                                            sMensagemErro) = False Then

                                            ''Informa o Usuário sobre o Erro Ocorrido
                                            'frmMain.Informacao(Mensagem.Erro, sMensagemErro)

                                        End If




                                    Case 539
                                        'Obtém Número do Recibo
                                        Dim sNumeroRecibo As String = oProtocoloNFe.sMotivo.Substring(oProtocoloNFe.sMotivo.IndexOf("[nRec:") + 6, 15)
                                        'Obtém Chave de Acessl
                                        Dim sChaveAcesso As String = oProtocoloNFe.sMotivo.Substring(oProtocoloNFe.sMotivo.IndexOf("[chNFe:") + 7, 44)

                                        'Atualiza tb_fat_emissao_capa
                                        oClsFatEmissaoNFe.UpdateNFeEnvioDuplicidade(grdNotaFiscalLote.GetValue("chave_acesso"), _
                                                                                    sChaveAcesso, _
                                                                                    sNumeroRecibo, _
                                                                                    goConfiguracaoNFe.iCodigoTipoAmbienteNFe)
                                        'Seta Controles
                                        grdNotaFiscalLote.SetValue("numero_recibo", sNumeroRecibo)
                                        grdNotaFiscalLote.SetValue("chave_acesso", sChaveAcesso)

                                    Case Else
                                        'Seta Controle
                                        grdNotaFiscalLote.SetValue("status2", "REJEITADA")
                                        grdNotaFiscalLote.SetValue("status", StatusNotaFiscalEletronica.Rejeitada)

                                End Select

                                'Seta Controle
                                grdNotaFiscalLote.SetValue("mensagem", oProtocoloNFe.sMotivo)
                                grdNotaFiscalLote.SetValue("numero_protocolo", oProtocoloNFe.sNumeroProtocolo)

                            Next

                        Else
                            'Informa o Usuário sobre o Erro Ocorrido
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oClsNFeConsultaRecepcaoNFe.Motivo)
                            grdNotaFiscalLote.SetValue("status2", oClsNFeConsultaRecepcaoNFe.Motivo)
                            grdNotaFiscalLote.SetValue("status", StatusNotaFiscalEletronica.Rejeitada)
                        End If

                    Else

                        'Informa o Usuário sobre o Erro Ocorrido
                        grdNotaFiscalLote.SetValue("mensagem", oClsNFeConsultaRecepcaoNFe.MensagemErro)

                    End If



                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If

                'Contabiliza as quatidades
                Call VerificarQuantidade()
                Application.DoEvents()
            Next
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Integracao(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao
            Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

            If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then
                oClsIntegracao.IntegracaoNFOcorrencia(lCodigoEmissaoCapa)
            End If

            'Salva Movimentação - Estoque
            oClsIntegracao.IntegracaoNFEmissaoEstoque(lCodigoEmissaoCapa)
            'Salva Financeiro - Receita
            oClsIntegracao.IntegracaoNFEmissaoFinanceiro(lCodigoEmissaoCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailNFe(ByVal lCodigoEmissaoCapa As Long, _
                         ByVal sEmail As String, _
                         ByVal iStatus As Integer, _
                         ByVal bEnvioDireto As Boolean, _
                         Optional ByVal bSomenteBoleto As Boolean = False)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Status
            If iStatus = CInt(StatusNotaFiscalEletronica.AutorizadaUso) Or _
               iStatus = CInt(StatusNotaFiscalEletronica.EnviadoDestinatario) Or _
               iStatus = CInt(StatusNotaFiscalEletronica.Cancelada) Then

                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument
                Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
                Dim sArquivoEnvio As String = ""
                Dim sArquivoBoleto As String = ""
                Dim sMensagemErro As String = ""
                Dim sArquivoNFe As String = ""
                Dim sArquivoProtocoloNFe As String = ""
                Dim sArquivoCancelamentoNFe As String = ""
                Dim sArquivoProtocoloCancelamentoNFe As String = ""
                Dim sNotaFiscal As String = ""
                Dim sChaveAcesso As String = ""
                Dim lCodigoParceiroNegocio As Long
                Dim lCodigoTituloCapa As Long
                Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

                'Carrega Dados da NF-e
                oClsFatEmissaoNFe.LoadDadosNFe(lCodigoEmissaoCapa, _
                                              sArquivoNFe, _
                                              sArquivoProtocoloNFe, _
                                              sArquivoCancelamentoNFe, _
                                              sArquivoProtocoloCancelamentoNFe, _
                                              sChaveAcesso, _
                                              sNotaFiscal, _
                                              lCodigoParceiroNegocio, _
                                              lCodigoTituloCapa)


                'Váriavel Relatório
                Dim sArquivoReport As String = goConfiguracaoNFe.sPastaImpressao & sNotaFiscal & ".pdf"



                If bSomenteBoleto = False Then

                    'Verifica se foi possível gerar o Arquivo
                    If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                      sArquivoProtocoloNFe, _
                                                      sChaveAcesso, _
                                                      sArquivoEnvio, _
                                                      sMensagemErro) = True Then

                        'Abre Relatório
                        If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then
                            oRptDocument.Load(goCrystalReport.sPath & "FAT000000003_Magma.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)
                        Else
                            oRptDocument.Load(goCrystalReport.sPath & "FAT000000003.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)
                        End If


                        'Seta Parametros Relatório
                        oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
                        oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
                        oRptDocument.SetParameterValue("numero_semana", "")
                        oRptDocument.SetParameterValue("nota_fiscal_inicial", IIf(IsNumeric(txtNotaFiscalInicial.Text), txtNotaFiscalInicial.Text, -1))
                        oRptDocument.SetParameterValue("nota_fiscal_final", IIf(IsNumeric(txtNotaFiscalFinal.Text), txtNotaFiscalFinal.Text, -1))

                        'Abre Conexão com o Banco de Dados
                        For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                            oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                        Next


                        Try
                            'Verifica se o Arquivo Existe
                            If System.IO.File.Exists(sArquivoReport) = True Then System.IO.File.Delete(sArquivoReport)
                        Catch ex As Exception

                        End Try


                        'Exporta para Arquivo PDF
                        oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

                        'Fecha o rpt
                        oRptDocument.Close()

                        'Limpa Váriavel
                        oRptDocument = Nothing

                    Else
                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                    End If

                End If

                'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
                Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmmss") + "\"

                'Exclui o diretório se existir
                If System.IO.Directory.Exists(sDiretorio) Then
                    System.IO.Directory.Delete(sDiretorio)
                End If
                'Cria  a pasta
                System.IO.Directory.CreateDirectory(sDiretorio)

                'Cria a psta nfe
                System.IO.Directory.CreateDirectory(sDiretorio + "NFe")

                'Seta o arquivo final
                Dim sFilePDF As String = sDiretorio + Format(Now, "ddMMyyyy_HHmmss") + ".pdf"



                If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Or bSistemaPerforma = True Then
                    'Boleto Bancário
                    If lCodigoTituloCapa > 0 Then
                        Dim iCodigoBanco As Integer = LoadCodigo("sp_select_financeiro_banco_titulo " & CStr(lCodigoTituloCapa) & "," & CStr(goUsuario.iEmpresa))

                        If bSistemaPerforma = False Then
                            'Váriavel - Boleto
                            Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
                            'Carrega Boleto
                            'oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNotaFiscal.Replace("NF", ""), sArquivoBoleto, -1, False)
                            oClsFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystal(lCodigoTituloCapa, sDiretorio, sArquivoBoleto, iCodigoBanco)
                        End If

                        Dim sPastaImpressao As String = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

                        If sPastaImpressao = "" Then
                            Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
                        Else
                            If Directory.Exists(sPastaImpressao) = False Then
                                Throw New Exception("Você não possui permissão para enxergar a pasta (" & sPastaImpressao & ").")
                            End If
                        End If

                        Dim sReport As String = ""
                        If iCodigoBanco = 237 Then sReport = "rptBoletoBradesco.rpt"
                        If iCodigoBanco = 33 Then sReport = "rptBoletoSantander.rpt"
                        If iCodigoBanco = 341 Then sReport = "rptBoletoItau.rpt"
                        'Váriaveis - Relatório



                        'Váriaveis Locais
                        oRptDocument = New ReportDocument

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.WaitCursor

                        'Verifica se o Arquivo existe
                        If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                            Exit Sub
                        End If

                        'Abre Relatório
                        oRptDocument.Load(goCrystalReport.sPath & sReport, _
                                          CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                        'Seta Parametros Relatório
                        oRptDocument.SetParameterValue("@codigo_titulo_capa", lCodigoTituloCapa)
                        oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                        'Abre Conexão com o Banco de Dados
                        For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                            oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                        Next

                        sArquivoBoleto = sPastaImpressao & "BOLETOS_" & "_" & Format(Now, "yyyyMMdd_hhmmss") & ".pdf"

                        'Exporta para Arquivo PDF
                        oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                                  sArquivoBoleto)

                        'Limpa Váriavel
                        oRptDocument = Nothing




                    End If

                End If

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
                Dim sAnexoBoleto As String = ""
                ''Anexa o boleto e a imagem
                'If sArquivoBoleto.ToUpper.Contains("HTML") Then
                '    Dim oStreamReader As New System.IO.StreamReader(sArquivoBoleto, System.Text.Encoding.Default)


                '    Dim sHTML As String = oStreamReader.ReadToEnd
                '    Dim sHTMLOriginal As String = sHTML

                '    'Fecha o arquivo
                '    oStreamReader.Close()


                '    Dim iIndex As Integer = InStr(sHTML, "<img src=")
                '    Dim iIndex2 As Integer = InStr(sHTML, ".jpg")
                '    Dim sImagem1 As String = Mid(sHTML, iIndex + 10, (iIndex2 - iIndex) - 6)
                '    Dim sNomeImagem1 As String = Mid(sImagem1, InStrRev(sImagem1, "\") + 1)

                '    sHTML = Mid(sHTML, iIndex2)
                '    iIndex = InStr(sHTML, "<img src=")
                '    iIndex2 = InStr(sHTML, ".gif")
                '    Dim sImagem2 As String = Mid(sHTML, iIndex + 10, (iIndex2 - iIndex) - 6)
                '    Dim sNomeImagem2 As String = Mid(sImagem2, InStrRev(sImagem2, "\") + 1)

                '    sHTML = Replace(sHTML, "<img src=""" & sImagem1, sNomeImagem1)
                '    sHTML = Replace(sHTML, "<img src=""" & sImagem2, sNomeImagem2)


                '    iIndex = InStr(sHTML, "<img src=")
                '    iIndex2 = InStr(sHTML, ".tmp")
                '    Dim sImagem3 As String = Mid(sHTML, iIndex + 10, (iIndex2 - iIndex) - 6)
                '    Dim sNomeImagem3 As String = Mid(sImagem3, InStrRev(sImagem3, "\") + 1)









                '    'Agora substitui 
                '    Try
                '        System.IO.File.Delete(sArquivoBoleto)
                '    Catch ex As Exception

                '    End Try


                '    System.IO.File.Copy(sImagem3, sImagem3.Replace(".tmp", ".png"))


                '    sHTMLOriginal = Replace(sHTMLOriginal, sImagem1, sNomeImagem1)
                '    sHTMLOriginal = Replace(sHTMLOriginal, sImagem2, sNomeImagem2)
                '    sHTMLOriginal = Replace(sHTMLOriginal, sImagem3, sNomeImagem3.Replace(".tmp", ".png"))



                '    Dim oStreamWriter As New StreamWriter(sArquivoBoleto, True, System.Text.Encoding.Default)
                '    oStreamWriter.WriteLine(sHTMLOriginal)
                '    oStreamWriter.Close()

                '    sAnexoBoleto = ";" & sImagem1 & ";" & sImagem2 & ";" & sImagem3.Replace(".tmp", ".png")
                'End If

                Dim sBody As String = ""


                Dim sAnexos As String = ""


                If goDatabase.sInitialCatalog.ToUpper = "INTERACTI_MAGMA_PRD" Then
                    sBody = LoadBodyEmail(grdNotaFiscalLote.GetValue("semana") + "/" + CStr(Year(Now)), grdNotaFiscalLote.GetValue("data_emissao"))
                    If bSomenteBoleto = False Then
                        sAnexos = goConfiguracaoNFe.sPastaImpressao & "\logo_magma.png;" & sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto) & sAnexoBoleto
                    Else
                        sAnexos = goConfiguracaoNFe.sPastaImpressao & "\logo_magma.png;" & sArquivoBoleto & ";" & sAnexoBoleto
                    End If


                    'Enviar E-mail
                    Call EnviarEmail("Compra Tupperware - Distribuição Magma S" + grdNotaFiscalLote.GetValue("semana") + " - DANFE e BOLETO", _
                                     sEmail, _
                                    sAnexos, _
                                    sAnexos, _
                                     sBody, _
                                     lCodigoParceiroNegocio, _
                                     "", _
                                     lCodigoEmissaoCapa, _
                                     bDireto:=bEnvioDireto, _
                    sFrom:="atendimento@twmagma.com.br")


                Else
                    sBody = LoadCodigo("sp_select_body_email " & CStr(lCodigoTituloCapa))
                    sAnexos = sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto) & sAnexoBoleto


                    'Enviar E-mail
                    Call EnviarEmail("NFe PERFORMA CABOS", _
                                     sEmail, _
                                    sAnexos, _
                                    sAnexos, _
                                     sBody, _
                                     lCodigoParceiroNegocio, _
                                     "", _
                                     lCodigoEmissaoCapa, _
                                     bDireto:=bEnvioDireto)



                End If
                'sAnexos = goConfiguracaoNFe.sPastaImpressao & "\logo_magma.png;" & sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto) & sAnexoBoleto






            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Private Sub EmailNFeOldBKP(ByVal lCodigoEmissaoCapa As Long, _
    '                     ByVal sEmail As String, _
    '                     ByVal iStatus As Integer, _
    '                     ByVal bEnvioDireto As Boolean, _
    '                     Optional ByVal bSomenteBoleto As Boolean = False)

    '    Try

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.WaitCursor

    '        'Verifica o Status
    '        If iStatus = CInt(StatusNotaFiscalEletronica.AutorizadaUso) Or _
    '           iStatus = CInt(StatusNotaFiscalEletronica.EnviadoDestinatario) Or _
    '           iStatus = CInt(StatusNotaFiscalEletronica.Cancelada) Then

    '            'Váriaveis Locais
    '            Dim oRptDocument As New ReportDocument
    '            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V3
    '            Dim sArquivoEnvio As String = ""
    '            Dim sArquivoBoleto As String = ""
    '            Dim sMensagemErro As String = ""
    '            Dim sArquivoNFe As String = ""
    '            Dim sArquivoProtocoloNFe As String = ""
    '            Dim sArquivoCancelamentoNFe As String = ""
    '            Dim sArquivoProtocoloCancelamentoNFe As String = ""
    '            Dim sNotaFiscal As String = ""
    '            Dim sChaveAcesso As String = ""
    '            Dim lCodigoParceiroNegocio As Long
    '            Dim lCodigoTituloCapa As Long
    '            Dim oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe

    '            'Carrega Dados da NF-e
    '            oClsFatEmissaoNFe.LoadDadosNFe(lCodigoEmissaoCapa, _
    '                                          sArquivoNFe, _
    '                                          sArquivoProtocoloNFe, _
    '                                          sArquivoCancelamentoNFe, _
    '                                          sArquivoProtocoloCancelamentoNFe, _
    '                                          sChaveAcesso, _
    '                                          sNotaFiscal, _
    '                                          lCodigoParceiroNegocio, _
    '                                          lCodigoTituloCapa)

    '            'Verifica se foi possível gerar o Arquivo
    '            If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
    '                                              sArquivoProtocoloNFe, _
    '                                              sArquivoCancelamentoNFe, _
    '                                              sArquivoProtocoloCancelamentoNFe, _
    '                                              sChaveAcesso, _
    '                                              sArquivoEnvio, _
    '                                              sMensagemErro) = True Then

    '                'Abre Relatório
    '                oRptDocument.Load(goCrystalReport.sPath & "FAT000000003_Magma.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

    '                'Seta Parametros Relatório
    '                oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
    '                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
    '                oRptDocument.SetParameterValue("numero_semana", "")
    '                oRptDocument.SetParameterValue("nota_fiscal_inicial", IIf(IsNumeric(txtNotaFiscalInicial.Text), txtNotaFiscalInicial.Text, -1))
    '                oRptDocument.SetParameterValue("nota_fiscal_final", IIf(IsNumeric(txtNotaFiscalFinal.Text), txtNotaFiscalFinal.Text, -1))

    '                'Abre Conexão com o Banco de Dados
    '                For i = 0 To oRptDocument.DataSourceConnections.Count - 1
    '                    oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
    '                Next

    '                'Váriavel Relatório
    '                Dim sArquivoReport As String = goConfiguracaoNFe.sPastaImpressao & sNotaFiscal & ".pdf"

    '                Try
    '                    'Verifica se o Arquivo Existe
    '                    If System.IO.File.Exists(sArquivoReport) = True Then System.IO.File.Delete(sArquivoReport)
    '                Catch ex As Exception

    '                End Try


    '                'Exporta para Arquivo PDF
    '                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

    '                'Fecha o rpt
    '                oRptDocument.Close()

    '                'Limpa Váriavel
    '                oRptDocument = Nothing

    '                'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
    '                Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmmss") + "\"

    '                'Exclui o diretório se existir
    '                If System.IO.Directory.Exists(sDiretorio) Then
    '                    System.IO.Directory.Delete(sDiretorio)
    '                End If
    '                'Cria  a pasta
    '                System.IO.Directory.CreateDirectory(sDiretorio)

    '                'Cria a psta nfe
    '                System.IO.Directory.CreateDirectory(sDiretorio + "NFe")

    '                'Seta o arquivo final
    '                Dim sFilePDF As String = sDiretorio + Format(Now, "ddMMyyyy_HHmmss") + ".pdf"



    '                'Boleto Bancário
    '                If lCodigoTituloCapa > 0 Then
    '                    Dim iCodigoBanco As Integer = LoadCodigo("sp_select_financeiro_banco_titulo " & CStr(lCodigoTituloCapa) & "," & CStr(goUsuario.iEmpresa))

    '                    'Váriavel - Boleto
    '                    Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
    '                    'Carrega Boleto
    '                    'oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNotaFiscal.Replace("NF", ""), sArquivoBoleto, -1, False)
    '                    oClsFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystal(lCodigoTituloCapa, sDiretorio, sArquivoBoleto, iCodigoBanco)

    '                    Dim sPastaImpressao As String = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

    '                    If sPastaImpressao = "" Then
    '                        Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
    '                    Else
    '                        If Directory.Exists(sPastaImpressao) = False Then
    '                            Throw New Exception("Você não possui permissão para enxergar a pasta (" & sPastaImpressao & ").")
    '                        End If
    '                    End If

    '                    Dim sReport As String = ""
    '                    If iCodigoBanco = 237 Then sReport = "rptBoletoBradesco.rpt"
    '                    If iCodigoBanco = 33 Then sReport = "rptBoletoSantander.rpt"
    '                    If iCodigoBanco = 341 Then sReport = "rptBoletoItau.rpt"
    '                    'Váriaveis - Relatório



    '                    'Váriaveis Locais
    '                    oRptDocument = New ReportDocument

    '                    'Seta Cursor do Mouse
    '                    Cursor.Current = Cursors.WaitCursor

    '                    'Verifica se o Arquivo existe
    '                    If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
    '                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
    '                        Exit Sub
    '                    End If

    '                    'Abre Relatório
    '                    oRptDocument.Load(goCrystalReport.sPath & sReport, _
    '                                      CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

    '                    'Seta Parametros Relatório
    '                    oRptDocument.SetParameterValue("@codigo_titulo_capa", lCodigoTituloCapa)
    '                    oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

    '                    'Abre Conexão com o Banco de Dados
    '                    For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
    '                        oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
    '                    Next

    '                    sArquivoBoleto = sPastaImpressao & "BOLETOS_" & "_" & Format(Now, "yyyyMMdd_hhmmss") & ".pdf"

    '                    'Exporta para Arquivo PDF
    '                    oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
    '                                              sArquivoBoleto)

    '                    'Limpa Váriavel
    '                    oRptDocument = Nothing




    '                End If

    '                'Seta Cursor do Mouse
    '                Cursor.Current = Cursors.Default
    '                Dim sAnexoBoleto As String = ""
    '                ''Anexa o boleto e a imagem
    '                'If sArquivoBoleto.ToUpper.Contains("HTML") Then
    '                '    Dim oStreamReader As New System.IO.StreamReader(sArquivoBoleto, System.Text.Encoding.Default)


    '                '    Dim sHTML As String = oStreamReader.ReadToEnd
    '                '    Dim sHTMLOriginal As String = sHTML

    '                '    'Fecha o arquivo
    '                '    oStreamReader.Close()


    '                '    Dim iIndex As Integer = InStr(sHTML, "<img src=")
    '                '    Dim iIndex2 As Integer = InStr(sHTML, ".jpg")
    '                '    Dim sImagem1 As String = Mid(sHTML, iIndex + 10, (iIndex2 - iIndex) - 6)
    '                '    Dim sNomeImagem1 As String = Mid(sImagem1, InStrRev(sImagem1, "\") + 1)

    '                '    sHTML = Mid(sHTML, iIndex2)
    '                '    iIndex = InStr(sHTML, "<img src=")
    '                '    iIndex2 = InStr(sHTML, ".gif")
    '                '    Dim sImagem2 As String = Mid(sHTML, iIndex + 10, (iIndex2 - iIndex) - 6)
    '                '    Dim sNomeImagem2 As String = Mid(sImagem2, InStrRev(sImagem2, "\") + 1)

    '                '    sHTML = Replace(sHTML, "<img src=""" & sImagem1, sNomeImagem1)
    '                '    sHTML = Replace(sHTML, "<img src=""" & sImagem2, sNomeImagem2)


    '                '    iIndex = InStr(sHTML, "<img src=")
    '                '    iIndex2 = InStr(sHTML, ".tmp")
    '                '    Dim sImagem3 As String = Mid(sHTML, iIndex + 10, (iIndex2 - iIndex) - 6)
    '                '    Dim sNomeImagem3 As String = Mid(sImagem3, InStrRev(sImagem3, "\") + 1)









    '                '    'Agora substitui 
    '                '    Try
    '                '        System.IO.File.Delete(sArquivoBoleto)
    '                '    Catch ex As Exception

    '                '    End Try


    '                '    System.IO.File.Copy(sImagem3, sImagem3.Replace(".tmp", ".png"))


    '                '    sHTMLOriginal = Replace(sHTMLOriginal, sImagem1, sNomeImagem1)
    '                '    sHTMLOriginal = Replace(sHTMLOriginal, sImagem2, sNomeImagem2)
    '                '    sHTMLOriginal = Replace(sHTMLOriginal, sImagem3, sNomeImagem3.Replace(".tmp", ".png"))



    '                '    Dim oStreamWriter As New StreamWriter(sArquivoBoleto, True, System.Text.Encoding.Default)
    '                '    oStreamWriter.WriteLine(sHTMLOriginal)
    '                '    oStreamWriter.Close()

    '                '    sAnexoBoleto = ";" & sImagem1 & ";" & sImagem2 & ";" & sImagem3.Replace(".tmp", ".png")
    '                'End If

    '                Dim sBody As String = LoadBodyEmail(grdNotaFiscalLote.GetValue("semana") + "/" + CStr(Year(Now)), grdNotaFiscalLote.GetValue("data_emissao"))

    '                'Enviar E-mail
    '                Call EnviarEmail("Compra Tupperware - Distribuição Magma S" + grdNotaFiscalLote.GetValue("semana") + " - DANFE e BOLETO", _
    '                                 sEmail, _
    '                                goConfiguracaoNFe.sPastaImpressao & "\logo_magma.png;" & sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto) & sAnexoBoleto, _
    '                                goConfiguracaoNFe.sPastaImpressao & "\logo_magma.png;" & sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto) & sAnexoBoleto, _
    '                                 sBody, _
    '                                 lCodigoParceiroNegocio, _
    '                                 "", _
    '                                 lCodigoEmissaoCapa, _
    '                                 bDireto:=bEnvioDireto, _
    '                sFrom:="atendimento@twmagma.com.br")



    '            Else
    '                'Informa o Usuário sobre o Erro Ocorrido
    '                frmMain.Informacao(Mensagem.Erro, sMensagemErro)
    '            End If

    '        Else
    '            frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
    '        End If

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Private Function LoadBodyEmail(ByVal sSemana As String, ByVal dDataEmissao As Date) As String
        Try
            'Verificação para verificar o dia correto de entrega (quinta-feira)

            Dim dPrimeiraEntrega As Date = dDataEmissao

            While Weekday(dPrimeiraEntrega, FirstDayOfWeek.Monday) <> DayOfWeek.Thursday
                dPrimeiraEntrega = DateAdd(DateInterval.Day, 1, dPrimeiraEntrega)

            End While

            Dim dSegundaEntrega As Date = DateAdd(DateInterval.Day, 7, dPrimeiraEntrega)

            Dim sBody As String = "<html>Prezado(a) consultor(a) Tupperware, segue em anexo DANFE e boleto referente sua compra da semana " & sSemana & " ."
            sBody += "<p class=MsoNormal><span style='font-size:11.0pt'></span></p>Conforme seu cadastro em nosso sistema, seu pedido deve ser quitado antes da entrega, nossos dias de entrega são: "
            sBody += "<p class=MsoNormal><p class=MsoNormal>"
            sBody += "<b>1ª Entrega: " & Format(dPrimeiraEntrega, "dd/MM/yyyy") & "</b><p class=MsoNormal>"
            sBody += "<b>2ª Entrega: " & Format(dSegundaEntrega, "dd/MM/yyyy") & "</b></p>"
            sBody += "<p class=MsoNormal>Após o vencimento do boleto seu pedido não estará mais disponível para entrega e prosseguiremos com o processo de devolução.<o:p></o:p></p>"
            sBody += "<p class=MsoNormal>Qualquer dúvida entre em contato conosco.<o:p></o:p></p><p class=MsoNormal></p><p class=MsoNormal><b>"
            sBody += "<span style='font-size:10.0pt;font-family:""Arial"",sans-serif;color:red'>Distribuição Magma</span></b><b><span style='font-size:10.0pt;font-family:""Arial"",sans-serif;color:#F932FF'> </span></b>"
            sBody += "<span style='font-size:10.0pt;font-family:""Arial"",sans-serif;color:#1E1A46'>| </span><b><span style='font-size:10.0pt;font-family:""Arial"",sans-serif;color:#0A05AE'>Vale do Paraíba | Litoral Norte | Serra da Mantiqueira</span></b>"
            sBody += "<span style='font-size:10.0pt;font-family:""Arial"",sans-serif;color:#1E1A46'> | Rua Riachuelo 236, Jardim Paulista - CEP 12216-040 &#8211; São José dos Campos - SP | Tel: 12 3923-6183 / 3914-7978&nbsp; | "
            sBody += "<a href=""http://www.twmagma.com.br/"" target=""_blank""><span style='color:blue'>www.twmagma.com.br</span></a>"
            sBody += "</p></div>"
            sBody += "<img border=0 width=284 height=99 style='width:2.9583in;height:1.0312in' id=""Imagem_x0020_1"" src=""logo_magma.png"" alt=""logo magma"">"
            sBody += "</body></html>"

            Return sBody
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ExportarBoletoBancario(ByVal bExportarNFe As Boolean)
        Dim sErro As String = ""
        Try
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


            'Verifica os títulos distintos para gerar os boletos
            Dim sCodigoTituloCapa As String = oClsFrmFatEmissaoNFeTransmissaoLote.GerarBoleto(sCodigo)

            'Váriaveis Locais
            Dim sArquivoBoleto As String = ""

            'Instancia para gerar os boletos
            Dim oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario

            'Vetor para verificar todos os boletos
            Dim oVetor() As String = sCodigoTituloCapa.Split(",")

            'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
            Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmm") + "\"

            'Exclui o diretório se existir
            If System.IO.Directory.Exists(sDiretorio) Then
                System.IO.Directory.Delete(sDiretorio)
            End If

            'Cria  a pasta
            System.IO.Directory.CreateDirectory(sDiretorio)

            'Cria a psta nfe
            System.IO.Directory.CreateDirectory(sDiretorio + "NFe")

            'Instancia 
            Dim oClsPDFCreator As New clsPDFCreator

            'Seta o arquivo final
            Dim sFilePDF As String = sDiretorio + Format(Now, "ddMMyyyy_HHmm") + ".pdf"

            'Confiugra
            oProgressBar.Value = 0
            oProgressBar.Maximum = oVetor.Count

            'Para um dos boleto, gerar um pdf
            For i As Integer = 0 To oVetor.Count - 1
                'Gera Arquivo
                oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLote(oVetor(i), sDiretorio, sArquivoBoleto, False)

                '
                'Exibe ao usuario o andamento
                oProgressBar.Value += 1
                Application.DoEvents()
            Next


            Cursor.Current = Cursors.WaitCursor


            'Variavel para receber os dados
            Dim oPDFFiles() As String

            'Confiugra
            oProgressBar.Value = 0
            oProgressBar.Maximum = System.IO.Directory.GetFiles(sDiretorio).Count

            'Agora pega todos os arquivos e faz um "merge"
            For Each sFile As String In System.IO.Directory.GetFiles(sDiretorio)

                'Instancia para verificar
                Dim oFileInfo As New DirectoryInfo(sFile)

                If oFileInfo.Extension = ".bmp" Or oFileInfo.Extension = ".html" Then
                    System.IO.File.Delete(oFileInfo.FullName)
                Else

                    If bExportarNFe = True Then
                        'Recebe o código concatenado
                        Dim sNotaFiscal As String = oClsFrmFatEmissaoNFeTransmissaoLote.GerarNFe(oFileInfo.Name.Replace(".pdf", ""))

                        'Verifica se teve retorno
                        If sNotaFiscal <> "" Then
                            Try


                                'vetor para receber as notas
                                Dim oVetorNota() As String = sNotaFiscal.Split(",")

                                For i As Integer = 0 To oVetorNota.Count - 1

                                    'Exportar para o pdf
                                    'Posição 0 - Nota Fiscal
                                    'Posição 1 - Codigo
                                    ExportarPDF(oVetorNota(i).Split("|")(1), sDiretorio + "NFe\", oVetorNota(i).Split("|")(0))

                                    'Verifica se já existe alguma posição
                                    If oPDFFiles Is Nothing Then
                                        ReDim oPDFFiles(0)
                                    Else
                                        'Redimensiona o vetor
                                        ReDim Preserve oPDFFiles(oPDFFiles.Count)
                                    End If

                                    'Seta o pdf da nfe
                                    oPDFFiles(oPDFFiles.Count - 1) = sDiretorio + "NFe\" + oVetorNota(i).Split("|")(0) + ".pdf"
                                Next
                            Catch ex As Exception
                                sErro += vbNewLine + oFileInfo.Name + " : " + ex.Message
                            End Try
                        End If
                    End If

                    'Verifica se já existe alguma posição
                    If oPDFFiles Is Nothing Then
                        ReDim oPDFFiles(0)
                    Else
                        'Redimensiona o vetor
                        ReDim Preserve oPDFFiles(oPDFFiles.Count)
                    End If

                    'Adiciona o arquivo
                    oPDFFiles(oPDFFiles.Count - 1) = oFileInfo.FullName


                End If
                '
                'Exibe ao usuario o andamento
                oProgressBar.Value += 1
                Application.DoEvents()
            Next


            If oPDFFiles Is Nothing Then
                MsgBox("Não foram gerados nenhum boleto!", vbExclamation)

            Else


                'Por fim, gera o pdf
                GerarPDF(sFilePDF, oPDFFiles)

                'Abre o arquivo
                Process.Start(sFilePDF)
            End If

            If sErro <> "" Then
                MsgBox("Erros:" + sErro, vbExclamation)
            End If

            Cursor.Current = Cursors.Default



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExportarBoletoBancarioCrystal(ByVal bExportarNFe As Boolean)
        Dim sErro As String = ""
        Try
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


            'Verifica os títulos distintos para gerar os boletos
            Dim sCodigoTituloCapa As String = oClsFrmFatEmissaoNFeTransmissaoLote.GerarBoleto(sCodigo)

            'Váriaveis Locais
            Dim sArquivoBoleto As String = ""
            Dim iCodigoBanco As Integer = 0

            'Instancia para gerar os boletos
            Dim oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario

            'Vetor para verificar todos os boletos
            Dim oVetor() As String = sCodigoTituloCapa.Split(",")

            'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
            Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmmss") + "\"

            'Exclui o diretório se existir
            If System.IO.Directory.Exists(sDiretorio) Then
                System.IO.Directory.Delete(sDiretorio)
            End If
            'Cria  a pasta
            System.IO.Directory.CreateDirectory(sDiretorio)

            'Cria a psta nfe
            System.IO.Directory.CreateDirectory(sDiretorio + "NFe")

            'Seta o arquivo final
            Dim sFilePDF As String = sDiretorio + Format(Now, "ddMMyyyy_HHmmss") + ".pdf"

            'Confiugra
            oProgressBar.Value = 0
            oProgressBar.Maximum = oVetor.Count

            'Para um dos boleto, gerar um pdf
            For i As Integer = 0 To oVetor.Count - 1
                'Gera Arquivo
                oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystal(oVetor(i), sDiretorio, sArquivoBoleto, iCodigoBanco)

                '
                'Exibe ao usuario o andamento
                oProgressBar.Value += 1
                Application.DoEvents()
            Next


            Cursor.Current = Cursors.WaitCursor


            Dim sPastaImpressao As String = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            If sPastaImpressao = "" Then
                Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            Else
                If Directory.Exists(sPastaImpressao) = False Then
                    Throw New Exception("Você não possui permissão para enxergar a pasta (" & sPastaImpressao & ").")
                End If
            End If

            Dim sArquivo As String


            'Váriaveis - Relatório
            Dim sReport As String = ""
            If iCodigoBanco = 237 Then sReport = "rptBoletoBradesco.rpt"
            If iCodigoBanco = 33 Then sReport = "rptBoletoSantander.rpt"
            If iCodigoBanco = 341 Then sReport = "rptBoletoItau.rpt"

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Arquivo existe
            If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                Exit Sub
            End If

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_titulo_capa", sCodigoTituloCapa)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            'Abre Conexão com o Banco de Dados
            For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            sArquivo = sPastaImpressao & "BOLETOS_" & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing



            'Dim sArquivoImpressao As String = GerarPDF(sPastaImpressao + "PEDIDOS_" + Format(Now, "yyyyMMdd_hhmm") + "_.pdf", oArquivo)
            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = sArquivo
            Process.Start(psi)
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default



            If sErro <> "" Then
                MsgBox("Erros:" + sErro, vbExclamation)
            End If

            Cursor.Current = Cursors.Default



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImprimirDanfe(ByVal sCodigoEmissaoCapa As String)

        Try

            'Verifica se o Usuário tem Direito de Imprimir Danfe
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Dim iTipoDocumentoFiscal As TipoDocumentoFiscal

                If IsNumeric(Replace(sCodigoEmissaoCapa, ",", "|")) Then
                    iTipoDocumentoFiscal = CType(LoadDescricao("sp_select_faturamento_emissao_tipo_documento_fiscal " & sCodigoEmissaoCapa & ", " & goUsuario.iEmpresa), TipoDocumentoFiscal)
                Else
                    iTipoDocumentoFiscal = TipoDocumentoFiscal.Saida
                End If

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(4)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
                goCrystalReport.sReportParameter(0).sValue = sCodigoEmissaoCapa
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReportParameter(2).sParamenter = "numero_semana"
                goCrystalReport.sReportParameter(2).sValue = ""
                goCrystalReport.sReportParameter(3).sParamenter = "nota_fiscal_inicial"
                goCrystalReport.sReportParameter(3).sValue = IIf(IsNumeric(txtNotaFiscalInicial.Text), txtNotaFiscalInicial.Text, -1)
                goCrystalReport.sReportParameter(4).sParamenter = "nota_fiscal_final"
                goCrystalReport.sReportParameter(4).sValue = IIf(IsNumeric(txtNotaFiscalFinal.Text), txtNotaFiscalFinal.Text, -1)
                goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000003_Magma" & IIf(iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF, "PN", "") & ".rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                If iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF Then
                    frmMain.LoadPageReport("FAT000000003", "PRÉ NOTA", oReport, Me.tabMain)
                Else
                    frmMain.LoadPageReport("FAT000000003", "DANFE - Documento Auxiliar de Nota Fiscal Eletrônica", oReport, frmMain.tabMain)
                End If

                Me.Dispose()
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ExportarXML()

        Try

            'Váriaveis da Classe
            Dim oClsUsrFatEmissaoNFeXML As New clsUsrFatEmissaoNFeXML

            'Váriaveis Locais
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sArquivoEnvio As String = ""
            Dim sMensagemErro As String = ""
            Dim sArquivoNFe As String = ""
            Dim sArquivoProtocoloNFe As String = ""
            Dim sArquivoCancelamentoNFe As String = ""
            Dim sArquivoProtocoloCancelamentoNFe As String = ""
            Dim sNotaFiscal As String = ""
            Dim sChaveAcesso As String = ""
            Dim i As Integer
            Dim bErro As Boolean = False
            Dim sPath As String = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oSaveFolder As New FolderBrowserDialog

            If oSaveFolder.ShowDialog() = DialogResult.OK Then

                sPath = oSaveFolder.SelectedPath

                For Each oRow In grdNotaFiscalLote.GetRows

                    'Carrega Dados da Nota Fiscal
                    oClsUsrFatEmissaoNFeXML.LoadDadosNFe(oRow.Cells("codigo").Value, _
                                                         sArquivoNFe, _
                                                         sArquivoProtocoloNFe, _
                                                         sArquivoCancelamentoNFe, _
                                                         sArquivoProtocoloCancelamentoNFe, _
                                                         sChaveAcesso, _
                                                         sNotaFiscal)

                    'Verifica se foi possível gerar o Arquivo
                    If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                      sArquivoProtocoloNFe, _ 
                                                      sChaveAcesso, _
                                                      sPath & "\" & sChaveAcesso & "-nfe.xml", _
                                                      sMensagemErro) = False Then

                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                        bErro = True
                        Exit For

                    End If

                Next

                'Informa o usuário sobre o Sucesso da Operação
                If bErro = False Then
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub VerificarQuantidade()

        Try
            'Instancia um data set para fazer as verificações
            Dim oDataSet As New DataSet
            oDataSet = CType(grdNotaFiscalLote.DataSource.dataset, DataSet).Copy

            'Seta os controles
            txtQuantidadeAguardandoTransmissao.Text = oDataSet.Tables(0).Select("status = 1").Count
            txtQuantidadeAguardandoRetorno.Text = oDataSet.Tables(0).Select("status = 2").Count
            txtQuantidadeRejeitada.Text = oDataSet.Tables(0).Select("status = 3").Count
            txtQuantidadeAutorizada.Text = oDataSet.Tables(0).Select("status = 4").Count
            txtQuantidadeCancelada.Text = oDataSet.Tables(0).Select("status = 5").Count
            txtQuantidadeEnviadaEmail.Text = oDataSet.Tables(0).Select("status = 6").Count

        Catch ex As Exception

        End Try




    End Sub

    'Private Sub ImprimirDanfeLote(ByVal sCodigoEmissaoCapa As String)

    '    Try

    '        'Verifica se o Usuário tem Direito de Imprimir Danfe
    '        If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = True Then

    '            'Seta Cursor do Mouse
    '            Cursor.Current = Cursors.WaitCursor

    '            'Seta Parametros

    '                Dim iTipoDocumentoFiscal As TipoDocumentoFiscal

    '                If IsNumeric(sCodigoEmissaoCapa) Then
    '                    iTipoDocumentoFiscal = CType(LoadDescricao("sp_select_faturamento_emissao_tipo_documento_fiscal " & sCodigoEmissaoCapa & ", " & goUsuario.iEmpresa), TipoDocumentoFiscal)
    '                Else
    '                    iTipoDocumentoFiscal = TipoDocumentoFiscal.Saida
    '                End If

    '                'Redimenciona Vetor
    '                ReDim goCrystalReport.sReportParameter(2)
    '                'Seta Parametros
    '                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
    '                goCrystalReport.sReportParameter(0).sValue = sCodigoEmissaoCapa
    '                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
    '                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
    '                goCrystalReport.sReportParameter(2).sParamenter = "semana"
    '                goCrystalReport.sReportParameter(2).sValue = txtSemana.Text
    '                goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000003_Magma" & IIf(iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF, "PN", "") & ".rpt"

    '                Dim oReport As New usrReport
    '                oReport.Dock = DockStyle.Fill

    '                'Abre Relatório
    '                If iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF Then
    '                    frmMain.LoadPageReport("FAT000000003", "PRÉ NOTA", oReport, Me.tabMain)
    '                Else
    '                    frmMain.LoadPageReport("FAT000000003", "DANFE - Documento Auxiliar de Nota Fiscal Eletrônica", oReport, Me.tabMain)
    '                End If

    '                'Seta Cursor do Mouse
    '                Cursor.Current = Cursors.Default
    '        Else
    '            'Informa o Usuário que ele não tem Direito
    '            frmMain.Informacao(Mensagem.DireitoImprimir)
    '        End If

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub


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

                If oRow.Cells.Item("quantidade_estoque").Value > oRow.Cells.Item("quantidade").Value Then
                    MsgBox("A quantidade deve ser maior ou igual a quantidade em estoque", MsgBoxStyle.OkOnly, "Quantidade em Estoque")
                    Exit Sub
                End If

                oClsFrmFatEmissaoNFeTransmissaoLote.UpdateDadosEstoque(oRow.Cells.Item("codigo").Value, _
                                                                       oRow.Cells.Item("codigo_emissao_item").Value, _
                                                                       IIf(IsDBNull(oRow.Cells.Item("localizacao").Value), "", oRow.Cells.Item("localizacao").Value), _
                                                                       oRow.Cells.Item("deposito").Value)


            Next

            'Roda a integração
            For Each oRow In grdNotaFiscalLote.GetRows
                Dim oClsIntegracao As New clsIntegracao


                oClsIntegracao.IntegracaoNFEmissaoEstoque(oRow.Cells.Item("codigo").Value)
            Next

            'Informa ao usuário
            frmMain.Informacao("Dados salvos com sucesso!", Color.Blue)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

  
   
    Private Sub btnImprimirConferencia_Click(sender As Object, e As EventArgs) Handles btnImprimirConferencia.Click
        Try
            'Váriaveis Locais
            Dim sCodigoEmissaoCapa As String = ""

            For Each oRow As GridEXRow In grdNotaFiscalLote.GetDataRows
                sCodigoEmissaoCapa &= IIf(sCodigoEmissaoCapa = "", "", ",") & oRow.Cells("codigo").Value
            Next

            If sCodigoEmissaoCapa = "" Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            Else

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigos"
                goCrystalReport.sReportParameter(0).sValue = sCodigoEmissaoCapa
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "rptRelatorioNFConferir.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill
               
                frmMain.LoadPageReport("rptRelatorioNFConferir", "Conferência de Caixas", oReport, frmMain.tabMain)
               
                Me.Dispose()
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If


        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class