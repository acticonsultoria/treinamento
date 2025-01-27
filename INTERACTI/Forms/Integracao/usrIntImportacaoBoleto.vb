Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Data.OleDb

Public Class usrIntImportacaoBoleto

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsIntImportacaoBoleto As New clsUsrIntImportacaoBoleto 

#End Region
     
#Region "::: CONTROLES :::"
    Private Sub btnEnviarEmail_Click(sender As Object, e As EventArgs) Handles btnEnviarEmail.Click
        Try
            For Each oRow In grdImportacao.GetRows
                Call EnviarEmailDireto(oRow.Cells.Item("nosso_numero").Value)
            Next
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub



    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        Try

            For Each oRow In grdListagem.GetCheckedRows
                Call EnviarEmailDireto(oRow.Cells.Item("nosso_numero").Value)
            Next
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If ValidaCampo(cboCNAB, lblCNAB) = False Then
                Exit Sub
            End If


            'Carrega Arquivo
            Call ImportarBoleto400_2()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub btnImprimirHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirHTML.Click
        Try
            ImprimirBoleto(True)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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

            'Alterna Aba
            tabMain.TabPages.Remove(pagDespesa)
            tabMain.TabPages.Add(pagListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If ValidaCampo(cboCNAB, lblCNAB) = False Then
                Exit Sub
            End If


            'Carrega Arquivo
            Call ImportarBoleto400()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirBoleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirBoleto.Click
        Try
            'ImprimirBoleto(False)


            ExportarBoletoBancarioCrystal()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub EnviarEmailDireto(ByVal sNossoNumero As String)
        Try


            'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
            Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmmss") + "\"
            Dim oRptDocument As New ReportDocument
            Dim sArquivoBoleto As String = ""
            Dim lCodigoTituloCapa As Long
            Dim lCodigoParceiroNegocio As Long
            Dim sEmail As String

            lCodigoTituloCapa = LoadCodigo("sp_select_financeiro_titulo_codigo_noss_numero '" & sNossoNumero & "', " & goUsuario.iEmpresa)

            oClsIntImportacaoBoleto.LoadDadosParceiro(lCodigoTituloCapa, lCodigoParceiroNegocio, sEmail)

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



            'Boleto Bancário
            If lCodigoTituloCapa > 0 Then
                Dim iCodigoBanco As Integer = LoadCodigo("sp_select_financeiro_banco_titulo " & CStr(lCodigoTituloCapa) & "," & CStr(goUsuario.iEmpresa))

                'Váriavel - Boleto
                Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
                'Carrega Boleto
                'oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNotaFiscal.Replace("NF", ""), sArquivoBoleto, -1, False)
                oClsFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystal(lCodigoTituloCapa, sDiretorio, sArquivoBoleto, iCodigoBanco)

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

                'sAnexos = goConfiguracaoNFe.sPastaImpressao & "\logo_magma.png;" & sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto) & sAnexoBoleto
                Dim sBody As String = LoadBodyEmail(grdImportacao.GetValue("data_emissao_titulo"))
                Dim sAssunto As String = "Compra Tupperware - Distribuição Magma - BOLETO"

                'Enviar E-mail
                Call EnviarEmail(sAssunto, _
                                 sEmail, _
                                 sArquivoBoleto, _
                                 sArquivoBoleto, _
                                 sBody, _
                                 lCodigoParceiroNegocio, _
                                 "", _
                                 0, _
                                 bDireto:=True, sFrom:="atendimento@twmagma.com.br")
                'sFrom:="atendimento@twmagma.com.br")

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

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

            Call LoadCombo(cboCNAB, "sp_select_combo_static_cnab ", False)
            'Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)

            dtpDataInicio.Checked = False
            dtpDataTermino.Checked = False

            If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then
                If goUsuario.iUsuario = 1 Or goUsuario.iUsuario = 2 Then
                    btnExcluir.Enabled = True
                Else
                    btnExcluir.Enabled = False
                End If
            End If

            'Seta Aba
            tabMain.TabPages.Remove(pagDespesa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ExportarBoletoBancarioCrystal()
        Dim sErro As String = ""
        Try
            Dim sCodigoTituloCapa As String = ""
            Dim iCodigoBanco As Integer = -1
            Dim sArquivoBoleto As String = ""

            'Percorrendo os codigos ativos
            For Each oRow In grdListagem.GetCheckedRows

                'Se já tiver algum código, adiciona o delimitador
                If sCodigoTituloCapa <> "" Then
                    sCodigoTituloCapa += ","
                End If


                'Concatenando o código
                sCodigoTituloCapa += CStr(oRow.Cells.Item("codigo_titulo_capa").Value)

                If iCodigoBanco = -1 Then
                    iCodigoBanco = oRow.Cells.Item("codigo_banco").Value
                End If
                If oRow.Cells.Item("codigo_banco").Value <> iCodigoBanco Then
                    MsgBox("Favor selecionar boletos de somente um banco!", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

            Next
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
            'Para um dos boleto, gerar um pdf
            For i As Integer = 0 To oVetor.Count - 1
                'Gera Arquivo
                oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystal(oVetor(i), sDiretorio, sArquivoBoleto, iCodigoBanco)

            Next



            Dim sArquivo As String
            Dim sReport As String = ""
            If iCodigoBanco = 237 Then sReport = "rptBoletoBradesco.rpt"
            If iCodigoBanco = 33 Then sReport = "rptBoletoSantander.rpt"
            If iCodigoBanco = 341 Then sReport = "rptBoletoItau.rpt"
            'Váriaveis - Relatório

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Arquivo existe
            If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                Exit Sub
            End If

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(1)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            'Seta Parametros Relatório
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_titulo_capa"
            goCrystalReport.sReportParameter(0).sValue = sCodigoTituloCapa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            'oReport.TabPage = Me.Parent
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)





            If sErro <> "" Then
                MsgBox("Erros:" + sErro, vbExclamation)
            End If

            Cursor.Current = Cursors.Default



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarBoleto400()

        Try


            Dim dt As New DataTable
            Dim AbrirComo As OpenFileDialog = New OpenFileDialog()
            Dim caminho As DialogResult
            Dim Arquivo As String
            Dim linhaTexto As String
            Dim nomeArquivo As String = ""
            Dim oArquivoExcel As New OpenFileDialog
            Dim iCodigo As Integer = 0


            AbrirComo.Title = "Abrir como"
            AbrirComo.FileName = "Nome Arquivo"
            AbrirComo.Multiselect = True
            AbrirComo.Filter = "Arquivos Textos (*.rem, *.SAP)|*.rem;*.SAP"
            caminho = AbrirComo.ShowDialog
            Arquivo = AbrirComo.FileName
            'txtArquivo.Text = AbrirComo.FileName

            '



            'If txtArquivo.Text = Nothing Then
            '    MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            '    Exit Sub
            'End If

            'cria um novo objeto StreamReader


            Dim iLinha As Integer = 0
            Dim bFlag As Boolean = False
            Dim sMensagem As String
            Dim bUnico

            'Lendo os arquivos selecionados
            For Each sFileName As String In AbrirComo.FileNames

                Dim objReader As New StreamReader(sFileName, System.Text.Encoding.Default)
                Dim oFile As New System.IO.FileInfo(sFileName)
                txtArquivo.Text = "Arquivo: " & sFileName.Replace(oFile.Directory.FullName & "\", "")
                'percorre o arquivo
                Do While objReader.Peek() <> -1
                    linhaTexto = objReader.ReadLine()
                    iLinha += 1

                    If iLinha < 0 Then

                        Continue Do

                    End If



                    'If (linhaTexto.Substring(241, 6).Trim <> "") Then

                    If ((linhaTexto.Substring(0, 1).Trim).Contains("1")) Then

                        bFlag = True




                        'row = dt.Rows.Add 
                        oClsIntImportacaoBoleto.RegistroTitulo = linhaTexto.Substring(0, 1)
                        oClsIntImportacaoBoleto.AgenciaDebito = linhaTexto.Substring(1, 5)
                        oClsIntImportacaoBoleto.DigitoAgenciaDebito = linhaTexto.Substring(6, 1).Trim
                        oClsIntImportacaoBoleto.RazaoContaCorrente = linhaTexto.Substring(7, 5)
                        oClsIntImportacaoBoleto.ContaCorrente = linhaTexto.Substring(12, 7)
                        oClsIntImportacaoBoleto.DigitoContaCorrente = linhaTexto.Substring(19, 1).Trim
                        oClsIntImportacaoBoleto.EmpresaBeneficiario = linhaTexto.Substring(20, 17).Trim
                        oClsIntImportacaoBoleto.NumeroControleParticipante = linhaTexto.Substring(37, 25).Trim
                        oClsIntImportacaoBoleto.CodigoBanco = linhaTexto.Substring(62, 3).Trim

                        If oClsIntImportacaoBoleto.CodigoBanco = "000" Then
                            oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(62, 8)
                        Else

                            oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(70, 12)
                        End If


                        oClsIntImportacaoBoleto.Multa = linhaTexto.Substring(65, 1)
                        oClsIntImportacaoBoleto.PercentualMulta = linhaTexto.Substring(66, 4)
                        Try
                            oClsIntImportacaoBoleto.Titulo = IIf(oClsIntImportacaoBoleto.CodigoBanco = "000", linhaTexto.Substring(37, 25).Trim, linhaTexto.Substring(70, 11))
                        Catch ex As Exception
                            oClsIntImportacaoBoleto.Titulo = 0
                        End Try

                        oClsIntImportacaoBoleto.DigitoAutoConfNumBancario = linhaTexto.Substring(81, 1).Trim
                        oClsIntImportacaoBoleto.DescontoBonificacaoDia = linhaTexto.Substring(82, 10)
                        oClsIntImportacaoBoleto.CondEmissaoPapeletaCobranca = linhaTexto.Substring(92, 1)
                        oClsIntImportacaoBoleto.BoletoDebitoAutomatico = linhaTexto.Substring(93, 1).Trim
                        oClsIntImportacaoBoleto.OperacaoBanco = linhaTexto.Substring(94, 10).Trim
                        oClsIntImportacaoBoleto.RateioCredito = linhaTexto.Substring(104, 1).Trim
                        oClsIntImportacaoBoleto.EndAvisoDebAutomaticoCC = linhaTexto.Substring(105, 1)
                        oClsIntImportacaoBoleto.Ocorrencia = linhaTexto.Substring(108, 2)
                        oClsIntImportacaoBoleto.NumeroDoc = linhaTexto.Substring(110, 10).Trim

                        If (linhaTexto.Substring(120, 2).Trim) = "00" Then
                        Else
                            oClsIntImportacaoBoleto.DataVencimentoTitulo = linhaTexto.Substring(120, 2) + "/" + linhaTexto.Substring(122, 2) + "/20" + linhaTexto.Substring(124, 2)
                        End If
                        oClsIntImportacaoBoleto.ValorTitulo = linhaTexto.Substring(126, 13) / 100.0
                        oClsIntImportacaoBoleto.BancoEncarregadoCobranca = linhaTexto.Substring(139, 3)
                        oClsIntImportacaoBoleto.AgenciaDepositaria = linhaTexto.Substring(142, 5)
                        oClsIntImportacaoBoleto.EspecieTitulo = linhaTexto.Substring(147, 2)
                        oClsIntImportacaoBoleto.Identificacao = linhaTexto.Substring(149, 1).Trim
                        If (linhaTexto.Substring(150, 2).Trim) = "00" Then
                        Else
                            oClsIntImportacaoBoleto.DataEmissaoTitulo = linhaTexto.Substring(150, 2) + "/" + linhaTexto.Substring(152, 2) + "/20" + linhaTexto.Substring(154, 2)
                        End If
                        oClsIntImportacaoBoleto.Instrucao1 = linhaTexto.Substring(156, 2)
                        oClsIntImportacaoBoleto.Instrucao2 = linhaTexto.Substring(158, 2)
                        oClsIntImportacaoBoleto.ValorAtrasoDia = CDbl(linhaTexto.Substring(160, 13)) / 100.0

                        If (linhaTexto.Substring(173, 2).Trim) = "00" Then
                        Else
                            oClsIntImportacaoBoleto.DataLimiteConDesconto = linhaTexto.Substring(173, 2) + "/" + linhaTexto.Substring(175, 2) + "/20" + linhaTexto.Substring(177, 2)
                        End If
                        oClsIntImportacaoBoleto.ValorDesconto = linhaTexto.Substring(179, 13) / 100.0
                        oClsIntImportacaoBoleto.ValorIOF = linhaTexto.Substring(192, 13) / 100.0
                        oClsIntImportacaoBoleto.ValorAbatimento = linhaTexto.Substring(205, 13) / 100.0
                        oClsIntImportacaoBoleto.TipoInscricaoPagador = linhaTexto.Substring(218, 2)
                        If ((linhaTexto.Substring(218, 2).Trim) = "01") Then
                            oClsIntImportacaoBoleto.NumeroInscricaoPagador = linhaTexto.Substring(223, 11).Trim
                        Else
                            oClsIntImportacaoBoleto.NumeroInscricaoPagador = linhaTexto.Substring(220, 14).Trim
                        End If
                        oClsIntImportacaoBoleto.NomePagador = linhaTexto.Substring(234, 40).Trim
                        oClsIntImportacaoBoleto.EnderecoPagador = linhaTexto.Substring(274, 40).Trim
                        oClsIntImportacaoBoleto.Mensagem1 = linhaTexto.Substring(314, 12).Trim
                        oClsIntImportacaoBoleto.CEP = linhaTexto.Substring(326, 5)
                        oClsIntImportacaoBoleto.SufixoCEP = linhaTexto.Substring(331, 3)
                        oClsIntImportacaoBoleto.Mensagem2 = linhaTexto.Substring(334, 60).Trim
                        oClsIntImportacaoBoleto.NumeroRegistroTitulo = linhaTexto.Substring(394, 6)

                        If oClsIntImportacaoBoleto.CodigoBanco = "000" Then
                            oClsIntImportacaoBoleto.Mensagem4 = linhaTexto.Substring(351, 30).Trim

                        End If

                    ElseIf ((linhaTexto.Substring(0, 1).Trim).Contains("2")) Then

                        bFlag = True



                        'oClsIntImportacaoBoleto.RazaoSocial = sRazaoSocial
                        oClsIntImportacaoBoleto.TipoRegistro = linhaTexto.Substring(0, 1)

                        If oClsIntImportacaoBoleto.BancoEncarregadoCobranca = "341" Then
                            oClsIntImportacaoBoleto.PercentualMulta = (CDbl(linhaTexto.Substring(10, 13)) / 100.0)
                            oClsIntImportacaoBoleto.Multa = oClsIntImportacaoBoleto.PercentualMulta * oClsIntImportacaoBoleto.ValorTitulo / 100.0
                        End If

                        If oClsIntImportacaoBoleto.CodigoBanco = "000" Then

                            oClsIntImportacaoBoleto.Mensagem1InsTitulo = linhaTexto.Substring(49, 50).Trim
                            oClsIntImportacaoBoleto.Mensagem2InsTitulo = ""

                        Else
                            oClsIntImportacaoBoleto.Mensagem1InsTitulo = linhaTexto.Substring(1, 80).Trim
                            oClsIntImportacaoBoleto.Mensagem2InsTitulo = linhaTexto.Substring(81, 80).Trim
                            oClsIntImportacaoBoleto.Mensagem3 = linhaTexto.Substring(161, 80).Trim

                            'Somente importar se for BRADESCO, caso contrario está no item 1)
                            If oClsIntImportacaoBoleto.CodigoBanco <> "000" Then
                                oClsIntImportacaoBoleto.Mensagem4 = linhaTexto.Substring(241, 80).Trim
                            End If

                            If (((linhaTexto.Substring(321, 2).Trim) = "00") Or ((linhaTexto.Substring(321, 2).Trim) = "")) Then
                            Else
                                oClsIntImportacaoBoleto.DataLimiteDesconto2 = linhaTexto.Substring(321, 2) + "/" + linhaTexto.Substring(323, 2) + "/" + linhaTexto.Substring(325, 2)
                            End If
                            If (((linhaTexto.Substring(340, 2).Trim) = "00") Or ((linhaTexto.Substring(340, 2).Trim) = "")) Then
                            Else
                                oClsIntImportacaoBoleto.DataLimiteDesconto3 = linhaTexto.Substring(340, 2) + "/" + linhaTexto.Substring(342, 2) + "/" + linhaTexto.Substring(344, 2)
                            End If
                            If (linhaTexto.Substring(327, 13).Trim) = "" Then
                                oClsIntImportacaoBoleto.ValorDesconto2 = 0.0
                            Else
                                oClsIntImportacaoBoleto.ValorDesconto2 = linhaTexto.Substring(327, 13) / 100.0
                            End If
                            If (linhaTexto.Substring(346, 13).Trim) = "" Then
                                oClsIntImportacaoBoleto.ValorDesconto3 = 0.0
                            Else
                                oClsIntImportacaoBoleto.ValorDesconto3 = linhaTexto.Substring(346, 13) / 100.0
                            End If
                            oClsIntImportacaoBoleto.Reserva = linhaTexto.Substring(359, 7).Trim
                            If ((linhaTexto.Substring(366, 2)).Trim = "00") Then
                                oClsIntImportacaoBoleto.Carteira = linhaTexto.Substring(367, 2).Trim
                            Else
                                oClsIntImportacaoBoleto.Carteira = linhaTexto.Substring(366, 3).Trim
                            End If
                            If IsNumeric(linhaTexto.Substring(369, 5).Trim) Then
                                oClsIntImportacaoBoleto.Agencia = linhaTexto.Substring(369, 5)
                                oClsIntImportacaoBoleto.ContaCorrenteInsTitulo = linhaTexto.Substring(374, 7).Trim
                                oClsIntImportacaoBoleto.DigitoContaCorrenteInsTitulo = linhaTexto.Substring(381, 1).Trim
                            End If
                            'If oClsIntImportacaoBoleto.CodigoBanco = "000" Then
                            '    oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(62, 8).Trim
                            'Else
                            '    oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(382, 11).Trim
                            'End If

                            oClsIntImportacaoBoleto.DACNossoNumero = linhaTexto.Substring(393, 1).Trim
                            oClsIntImportacaoBoleto.NumeroRegistroInsTitulo = linhaTexto.Substring(394, 6)

                        End If

                        'Insere o boleto
                        Call oClsIntImportacaoBoleto.SalvarBoleto()

                        'BRADESCO
                        If oClsIntImportacaoBoleto.CodigoBanco <> "000" Then
                            'Ciclo de até 10 notas
                            For i = 0 To 10

                                'Verifica as notas concatenadas
                                If (linhaTexto.Substring(241 + (i * 6), 6).Trim <> "") Then

                                    'Insere o vínculo
                                    oClsIntImportacaoBoleto.SalvarBoletoNF(linhaTexto.Substring(241 + (i * 6), 6).Trim, oClsIntImportacaoBoleto.NumeroDoc, oClsIntImportacaoBoleto.NossoNumero)

                                Else ' Se tiver vazio, já sai do for
                                    Exit For
                                End If

                            Next

                            'SANTANDER
                        Else

                            sMensagem = oClsIntImportacaoBoleto.Mensagem4.PadRight(30, " ")
                            'Ciclo de até 5 notas
                            For i = 0 To 5

                                'Verifica as notas concatenadas
                                If (sMensagem.Substring(i * 6, 6).Trim <> "") Then

                                    'Insere o vínculo
                                    oClsIntImportacaoBoleto.SalvarBoletoNF(sMensagem.Substring(i * 6, 6).Trim, oClsIntImportacaoBoleto.NumeroDoc, oClsIntImportacaoBoleto.NossoNumero)

                                Else ' Se tiver vazio, já sai do for
                                    Exit For
                                End If

                            Next
                        End If
                        'oClsIntImportacaoBoleto.UpdateRazaoSocial(oClsIntImportacaoBoleto.NumeroInscricaoPagador)

                    ElseIf linhaTexto.Substring(0, 1).Trim.Contains("6") Then

                        'Insere o boleto (ITAU)
                        Call oClsIntImportacaoBoleto.SalvarBoleto()

                        'Quebra a informação de NF
                        sMensagem = linhaTexto.Substring(71, 140)

                        'Ciclo de até 5 notas
                        For i = 0 To 5

                            'Verifica as notas concatenadas
                            If (sMensagem.Substring(i * 6, 6).Trim <> "") Then

                                'Insere o vínculo
                                oClsIntImportacaoBoleto.SalvarBoletoNF(sMensagem.Substring(i * 6, 6).Trim, oClsIntImportacaoBoleto.NumeroDoc, oClsIntImportacaoBoleto.NossoNumero)

                            Else ' Se tiver vazio, já sai do for
                                Exit For
                            End If

                        Next


                    Else
                        'Registro trailer, sai do for
                        If bFlag = True Then
                            Continue Do
                        End If
                    End If

                Loop
            Next


            'Carrega a grid do boleto
            Call oClsIntImportacaoBoleto.LoadGridBoleto(grdImportacao)

            'Salva os dados no financeiro
            Call oClsIntImportacaoBoleto.Salvar()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarBoleto400_2()

        Try


            Dim dt As New DataTable
            Dim AbrirComo As OpenFileDialog = New OpenFileDialog()
            Dim caminho As DialogResult
            Dim Arquivo As String
            Dim linhaTexto As String
            Dim nomeArquivo As String = ""
            Dim oArquivoExcel As New OpenFileDialog
            Dim iCodigo As Integer = 0


            AbrirComo.Title = "Abrir como"
            AbrirComo.FileName = "Nome Arquivo"
            AbrirComo.Multiselect = True
            AbrirComo.Filter = "Arquivos Textos (*.rem, *.SAP)|*.rem;*.SAP"
            caminho = AbrirComo.ShowDialog
            Arquivo = AbrirComo.FileName
            'txtArquivo.Text = AbrirComo.FileName

            '



            'If txtArquivo.Text = Nothing Then
            '    MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
            '    Exit Sub
            'End If

            'cria um novo objeto StreamReader


            Dim iLinha As Integer = 0
            Dim bFlag As Boolean = False
            Dim sMensagem As String
            Dim bUnico

            'Lendo os arquivos selecionados
            For Each sFileName As String In AbrirComo.FileNames

                Dim objReader As New StreamReader(sFileName, System.Text.Encoding.Default)
                Dim oFile As New System.IO.FileInfo(sFileName)
                txtArquivo.Text = "Arquivo: " & sFileName.Replace(oFile.Directory.FullName & "\", "")
                'percorre o arquivo
                Do While objReader.Peek() <> -1
                    linhaTexto = objReader.ReadLine()
                    iLinha += 1

                    If iLinha < 0 Then

                        Continue Do

                    End If



                    'If (linhaTexto.Substring(241, 6).Trim <> "") Then

                    If ((linhaTexto.Substring(0, 1).Trim).Contains("1")) Then

                        bFlag = True




                        'row = dt.Rows.Add 
                        oClsIntImportacaoBoleto.RegistroTitulo = linhaTexto.Substring(0, 1)
                        oClsIntImportacaoBoleto.AgenciaDebito = linhaTexto.Substring(1, 5)
                        oClsIntImportacaoBoleto.DigitoAgenciaDebito = linhaTexto.Substring(6, 1).Trim
                        oClsIntImportacaoBoleto.RazaoContaCorrente = linhaTexto.Substring(7, 5)
                        oClsIntImportacaoBoleto.ContaCorrente = linhaTexto.Substring(12, 7)
                        oClsIntImportacaoBoleto.DigitoContaCorrente = linhaTexto.Substring(19, 1).Trim
                        oClsIntImportacaoBoleto.EmpresaBeneficiario = linhaTexto.Substring(20, 17).Trim
                        oClsIntImportacaoBoleto.NumeroControleParticipante = linhaTexto.Substring(37, 25).Trim
                        oClsIntImportacaoBoleto.CodigoBanco = linhaTexto.Substring(62, 3).Trim

                        If oClsIntImportacaoBoleto.CodigoBanco = "000" Then
                            oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(62, 8)
                        Else

                            oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(70, 12)
                        End If


                        oClsIntImportacaoBoleto.Multa = linhaTexto.Substring(65, 1)
                        oClsIntImportacaoBoleto.PercentualMulta = linhaTexto.Substring(66, 4)
                        Try
                            oClsIntImportacaoBoleto.Titulo = IIf(oClsIntImportacaoBoleto.CodigoBanco = "000", linhaTexto.Substring(37, 25).Trim, linhaTexto.Substring(70, 11))
                        Catch ex As Exception
                            oClsIntImportacaoBoleto.Titulo = 0
                        End Try

                        oClsIntImportacaoBoleto.DigitoAutoConfNumBancario = linhaTexto.Substring(81, 1).Trim
                        oClsIntImportacaoBoleto.DescontoBonificacaoDia = linhaTexto.Substring(82, 10)
                        oClsIntImportacaoBoleto.CondEmissaoPapeletaCobranca = linhaTexto.Substring(92, 1)
                        oClsIntImportacaoBoleto.BoletoDebitoAutomatico = linhaTexto.Substring(93, 1).Trim
                        oClsIntImportacaoBoleto.OperacaoBanco = linhaTexto.Substring(94, 10).Trim
                        oClsIntImportacaoBoleto.RateioCredito = linhaTexto.Substring(104, 1).Trim
                        oClsIntImportacaoBoleto.EndAvisoDebAutomaticoCC = linhaTexto.Substring(105, 1)
                        oClsIntImportacaoBoleto.Ocorrencia = linhaTexto.Substring(108, 2)
                        oClsIntImportacaoBoleto.NumeroDoc = linhaTexto.Substring(110, 10).Trim

                        If (linhaTexto.Substring(120, 2).Trim) = "00" Then
                        Else
                            oClsIntImportacaoBoleto.DataVencimentoTitulo = linhaTexto.Substring(120, 2) + "/" + linhaTexto.Substring(122, 2) + "/20" + linhaTexto.Substring(124, 2)
                        End If
                        oClsIntImportacaoBoleto.ValorTitulo = linhaTexto.Substring(126, 13) / 100.0
                        oClsIntImportacaoBoleto.BancoEncarregadoCobranca = linhaTexto.Substring(139, 3)
                        oClsIntImportacaoBoleto.AgenciaDepositaria = linhaTexto.Substring(142, 5)
                        oClsIntImportacaoBoleto.EspecieTitulo = linhaTexto.Substring(147, 2)
                        oClsIntImportacaoBoleto.Identificacao = linhaTexto.Substring(149, 1).Trim
                        If (linhaTexto.Substring(150, 2).Trim) = "00" Then
                        Else
                            oClsIntImportacaoBoleto.DataEmissaoTitulo = linhaTexto.Substring(150, 2) + "/" + linhaTexto.Substring(152, 2) + "/20" + linhaTexto.Substring(154, 2)
                        End If
                        oClsIntImportacaoBoleto.Instrucao1 = linhaTexto.Substring(156, 2)
                        oClsIntImportacaoBoleto.Instrucao2 = linhaTexto.Substring(158, 2)
                        oClsIntImportacaoBoleto.ValorAtrasoDia = CDbl(linhaTexto.Substring(160, 13)) / 100.0

                        If (linhaTexto.Substring(173, 2).Trim) = "00" Then
                        Else
                            oClsIntImportacaoBoleto.DataLimiteConDesconto = linhaTexto.Substring(173, 2) + "/" + linhaTexto.Substring(175, 2) + "/20" + linhaTexto.Substring(177, 2)
                        End If
                        oClsIntImportacaoBoleto.ValorDesconto = linhaTexto.Substring(179, 13) / 100.0
                        oClsIntImportacaoBoleto.ValorIOF = linhaTexto.Substring(192, 13) / 100.0
                        oClsIntImportacaoBoleto.ValorAbatimento = linhaTexto.Substring(205, 13) / 100.0
                        oClsIntImportacaoBoleto.TipoInscricaoPagador = linhaTexto.Substring(218, 2)
                        If ((linhaTexto.Substring(218, 2).Trim) = "01") Then
                            oClsIntImportacaoBoleto.NumeroInscricaoPagador = linhaTexto.Substring(223, 11).Trim
                        Else
                            oClsIntImportacaoBoleto.NumeroInscricaoPagador = linhaTexto.Substring(220, 14).Trim
                        End If
                        oClsIntImportacaoBoleto.NomePagador = linhaTexto.Substring(234, 40).Trim
                        oClsIntImportacaoBoleto.EnderecoPagador = linhaTexto.Substring(274, 40).Trim
                        oClsIntImportacaoBoleto.Mensagem1 = linhaTexto.Substring(314, 12).Trim
                        oClsIntImportacaoBoleto.CEP = linhaTexto.Substring(326, 5)
                        oClsIntImportacaoBoleto.SufixoCEP = linhaTexto.Substring(331, 3)
                        oClsIntImportacaoBoleto.Mensagem2 = linhaTexto.Substring(334, 60).Trim
                        oClsIntImportacaoBoleto.NumeroRegistroTitulo = linhaTexto.Substring(394, 6)

                        If oClsIntImportacaoBoleto.CodigoBanco = "000" Then
                            oClsIntImportacaoBoleto.Mensagem4 = linhaTexto.Substring(351, 30).Trim

                        End If

                    ElseIf ((linhaTexto.Substring(0, 1).Trim).Contains("2")) Then

                        bFlag = True



                        'oClsIntImportacaoBoleto.RazaoSocial = sRazaoSocial
                        oClsIntImportacaoBoleto.TipoRegistro = linhaTexto.Substring(0, 1)

                        If oClsIntImportacaoBoleto.BancoEncarregadoCobranca = "341" Then
                            oClsIntImportacaoBoleto.PercentualMulta = (CDbl(linhaTexto.Substring(10, 13)) / 100.0)
                            oClsIntImportacaoBoleto.Multa = oClsIntImportacaoBoleto.PercentualMulta * oClsIntImportacaoBoleto.ValorTitulo / 100.0
                        End If

                        If oClsIntImportacaoBoleto.CodigoBanco = "000" Then

                            oClsIntImportacaoBoleto.Mensagem1InsTitulo = linhaTexto.Substring(49, 50).Trim
                            oClsIntImportacaoBoleto.Mensagem2InsTitulo = ""

                        Else
                            oClsIntImportacaoBoleto.Mensagem1InsTitulo = linhaTexto.Substring(1, 80).Trim
                            oClsIntImportacaoBoleto.Mensagem2InsTitulo = linhaTexto.Substring(81, 80).Trim
                            oClsIntImportacaoBoleto.Mensagem3 = linhaTexto.Substring(161, 80).Trim

                            'Somente importar se for BRADESCO, caso contrario está no item 1)
                            If oClsIntImportacaoBoleto.CodigoBanco <> "000" Then
                                oClsIntImportacaoBoleto.Mensagem4 = linhaTexto.Substring(241, 80).Trim
                            End If

                            If (((linhaTexto.Substring(321, 2).Trim) = "00") Or ((linhaTexto.Substring(321, 2).Trim) = "")) Then
                            Else
                                oClsIntImportacaoBoleto.DataLimiteDesconto2 = linhaTexto.Substring(321, 2) + "/" + linhaTexto.Substring(323, 2) + "/" + linhaTexto.Substring(325, 2)
                            End If
                            If (((linhaTexto.Substring(340, 2).Trim) = "00") Or ((linhaTexto.Substring(340, 2).Trim) = "")) Then
                            Else
                                oClsIntImportacaoBoleto.DataLimiteDesconto3 = linhaTexto.Substring(340, 2) + "/" + linhaTexto.Substring(342, 2) + "/" + linhaTexto.Substring(344, 2)
                            End If
                            If (linhaTexto.Substring(327, 13).Trim) = "" Then
                                oClsIntImportacaoBoleto.ValorDesconto2 = 0.0
                            Else
                                oClsIntImportacaoBoleto.ValorDesconto2 = linhaTexto.Substring(327, 13) / 100.0
                            End If
                            If (linhaTexto.Substring(346, 13).Trim) = "" Then
                                oClsIntImportacaoBoleto.ValorDesconto3 = 0.0
                            Else
                                oClsIntImportacaoBoleto.ValorDesconto3 = linhaTexto.Substring(346, 13) / 100.0
                            End If
                            oClsIntImportacaoBoleto.Reserva = linhaTexto.Substring(359, 7).Trim
                            If ((linhaTexto.Substring(366, 2)).Trim = "00") Then
                                oClsIntImportacaoBoleto.Carteira = linhaTexto.Substring(367, 2).Trim
                            Else
                                oClsIntImportacaoBoleto.Carteira = linhaTexto.Substring(366, 3).Trim
                            End If
                            If IsNumeric(linhaTexto.Substring(369, 5).Trim) Then
                                oClsIntImportacaoBoleto.Agencia = linhaTexto.Substring(369, 5)
                                oClsIntImportacaoBoleto.ContaCorrenteInsTitulo = linhaTexto.Substring(374, 7).Trim
                                oClsIntImportacaoBoleto.DigitoContaCorrenteInsTitulo = linhaTexto.Substring(381, 1).Trim
                            End If
                            'If oClsIntImportacaoBoleto.CodigoBanco = "000" Then
                            '    oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(62, 8).Trim
                            'Else
                            '    oClsIntImportacaoBoleto.NossoNumero = linhaTexto.Substring(382, 11).Trim
                            'End If

                            oClsIntImportacaoBoleto.DACNossoNumero = linhaTexto.Substring(393, 1).Trim
                            oClsIntImportacaoBoleto.NumeroRegistroInsTitulo = linhaTexto.Substring(394, 6)

                        End If

                        'Insere o boleto
                        Call oClsIntImportacaoBoleto.SalvarBoleto()

                        'BRADESCO
                        If oClsIntImportacaoBoleto.CodigoBanco <> "000" Then
                            'Ciclo de até 10 notas
                            For i = 0 To 10

                                'Verifica as notas concatenadas
                                If (linhaTexto.Substring(241 + (i * 6), 6).Trim <> "") Then

                                    'Insere o vínculo
                                    oClsIntImportacaoBoleto.SalvarBoletoNF(linhaTexto.Substring(241 + (i * 6), 6).Trim, oClsIntImportacaoBoleto.NumeroDoc, oClsIntImportacaoBoleto.NossoNumero)

                                Else ' Se tiver vazio, já sai do for
                                    Exit For
                                End If

                            Next

                            'SANTANDER
                        Else

                            sMensagem = oClsIntImportacaoBoleto.Mensagem4.PadRight(30, " ")
                            'Ciclo de até 5 notas
                            For i = 0 To 5

                                'Verifica as notas concatenadas
                                If (sMensagem.Substring(i * 6, 6).Trim <> "") Then

                                    'Insere o vínculo
                                    oClsIntImportacaoBoleto.SalvarBoletoNF(sMensagem.Substring(i * 6, 6).Trim, oClsIntImportacaoBoleto.NumeroDoc, oClsIntImportacaoBoleto.NossoNumero)

                                Else ' Se tiver vazio, já sai do for
                                    Exit For
                                End If

                            Next
                        End If
                        'oClsIntImportacaoBoleto.UpdateRazaoSocial(oClsIntImportacaoBoleto.NumeroInscricaoPagador)

                    ElseIf linhaTexto.Substring(0, 1).Trim.Contains("6") Then

                        'Insere o boleto (ITAU)
                        Call oClsIntImportacaoBoleto.SalvarBoleto()

                        'Quebra a informação de NF
                        sMensagem = linhaTexto.Substring(71, 140)

                        'Ciclo de até 5 notas
                        For i = 0 To 5

                            'Verifica as notas concatenadas
                            If (sMensagem.Substring(i * 6, 6).Trim <> "") Then

                                'Insere o vínculo
                                oClsIntImportacaoBoleto.SalvarBoletoNF(sMensagem.Substring(i * 6, 6).Trim, oClsIntImportacaoBoleto.NumeroDoc, oClsIntImportacaoBoleto.NossoNumero)

                            Else ' Se tiver vazio, já sai do for
                                Exit For
                            End If

                        Next


                    Else
                        'Registro trailer, sai do for
                        If bFlag = True Then
                            Continue Do
                        End If
                    End If

                Loop
            Next


            'Carrega a grid do boleto
            Call oClsIntImportacaoBoleto.LoadGridBoleto(grdImportacao)

            'Salva os dados no financeiro
            Call oClsIntImportacaoBoleto.Salvar_2()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsIntImportacaoBoleto.LoadGrid(grdListagem, _
                                             txtNossoNum.Text, _
                                             txtNumeroDoc.Text, _
                                             IIf(txtValor.Text = "", 0.0, txtValor.Text), _
                                             IIf(dtpDataInicio.Checked = False, "", dtpDataInicio.Value), _
                                             IIf(dtpDataTermino.Checked = False, "", dtpDataTermino.Value), _
                                             txtRazaoSocial.Text, _
                                             txtCpfCnpj.Text)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            txtArquivo.Text = ""
            grdImportacao.DataSource = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoBoleto() As Boolean

        'Try

        '    'Seta Retorno da Função
        '    ValidacaoBoleto = False


        '    'Verifica se foi a Nota Fiscal é Válida
        '    If oClsIntImportacaoBoleto.ValidaBoleto() = False Then

        '    End If

        '    'Seta Retorno da Função
        '    ValidacaoBoleto = True

        'Catch ex As Exception
        '    Throw ex
        'End Try

    End Function

    Private Sub ImprimirBoleto(ByVal bHTML As Boolean)
        Try
            Call LoadConfiguracaoNFe()
            Dim sERRO As String = ""

            Dim sCodigoTituloCapa As String = ""

            For Each oRow In grdListagem.GetCheckedRows
                If sCodigoTituloCapa <> "" Then sCodigoTituloCapa += ","

                sCodigoTituloCapa += CStr(oRow.Cells.Item("codigo_titulo_capa").Value)
            Next

            'Váriaveis Locais
            Dim sArquivoBoleto As String = ""

            'Instancia para gerar os boletos
            Dim oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario

            'Vetor para verificar todos os boletos
            Dim oVetor() As String = sCodigoTituloCapa.Split(",")



            If bHTML = True Then
                oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLote(sCodigoTituloCapa, goConfiguracaoNFe.sPastaImpressao + "boleto\", sArquivoBoleto, True)
            Else

                'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
                Dim sDiretorio As String = goConfiguracaoNFe.sPastaImpressao + "boleto\" + Format(Now, "yyMMdd_HHmmss") + "\"

                'Exclui o diretório se existir
                If System.IO.Directory.Exists(sDiretorio) Then
                    System.IO.Directory.Delete(sDiretorio)
                Else

                    'Cria  a pasta
                    System.IO.Directory.CreateDirectory(sDiretorio)

                    'Cria a psta nfe
                    System.IO.Directory.CreateDirectory(sDiretorio + "NFe")

                End If

                'Instancia 
                Dim oClsPDFCreator As New clsPDFCreator

                'Seta o arquivo final
                Dim sFilePDF As String = sDiretorio + Format(Now, "ddMMyyyy_HHmmss") + ".pdf"


                'Para um dos boleto, gerar um pdf
                For i As Integer = 0 To oVetor.Count - 1
                    'Gera Arquivo
                    oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLote(oVetor(i), sDiretorio, sArquivoBoleto, False)

                Next


                Cursor.Current = Cursors.WaitCursor


                'Variavel para receber os dados
                Dim oPDFFiles() As String

                'Agora pega todos os arquivos e faz um "merge"
                For Each sFile As String In System.IO.Directory.GetFiles(sDiretorio)

                    'Instancia para verificar
                    Dim oFileInfo As New DirectoryInfo(sFile)

                    If oFileInfo.Extension = ".bmp" Or oFileInfo.Extension = ".html" Then
                        System.IO.File.Delete(oFileInfo.FullName)
                    Else



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

                Next


                If oPDFFiles Is Nothing Then
                    MsgBox("Não foram gerados nenhum boleto!", vbExclamation)

                Else


                    'Por fim, gera o pdf
                    GerarPDF(sFilePDF, oPDFFiles)

                    'Abre o arquivo
                    Process.Start(sFilePDF)
                End If

                If sERRO <> "" Then
                    MsgBox("Erros:" + sERRO, vbExclamation)
                End If

                Cursor.Current = Cursors.Default

            End If
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

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsIntImportacaoBoleto.DeleteBoleto()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function LoadBodyEmail(ByVal dDataEmissao As Date) As String
        Try
            'Verificação para verificar o dia correto de entrega (quinta-feira)

            Dim dPrimeiraEntrega As Date = dDataEmissao

            While Weekday(dPrimeiraEntrega, FirstDayOfWeek.Monday) <> DayOfWeek.Thursday
                dPrimeiraEntrega = DateAdd(DateInterval.Day, 1, dPrimeiraEntrega)

            End While

            Dim dSegundaEntrega As Date = DateAdd(DateInterval.Day, 7, dPrimeiraEntrega)

            Dim sBody As String = "<html>Prezado(a) consultor(a) Tupperware, segue em anexo o boleto referente sua compra."
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
#End Region

   
End Class

