Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports iTextSharp.text.pdf

Public Class frmFinReceitaCobrancaCartaBoleto

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrFinReceitaCobranca As New clsUsrFinReceitaCobranca
    Private oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
    Private oClsIntegracaoBoleto As New clsUsrIntConciliacaoBancaria
    Private oGrid As GridEX
    Private sArquivoScript As StreamWriter
    Private sDiretorio As String

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

    Private Sub frmFinReceitaCobrancaCartaBoleto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub frmFinReceitaCobrancaCartaBoleto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: CARTA BOLETO :::"
    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Try
            For i As Integer = 0 To grdListagem.GetRows.Count - 1
                grdListagem.Row = i
                grdListagem.SetValue("percentual", txtPorcentagemCorrecao.Value * 100)
                grdListagem.SetValue("valor_devido_corrigido", grdListagem.CurrentRow.Cells.Item("valor_devido").Value + (grdListagem.CurrentRow.Cells.Item("valor_devido").Value * grdListagem.CurrentRow.Cells.Item("percentual").Value / 100))
                grdListagem.SetValue("data_vencimento_corrigida", dtpDataVencimento.Value)
            Next
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnEnviarEmail_Click(sender As Object, e As EventArgs) Handles btnEnviarEmail.Click
        Try



            Call UpdateTituloCartaBoleto()

            Call EmailCarta()

            Call CartaBoleto()

            Call GerarArquivoRemessa()

            Call GerarArquivoScript()


        Catch ex As Exception
            Throw ex
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FinanceiroReceitaCobranca
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaCobranca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnGerarCarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarCarta.Click

        Try

            Call UpdateTituloCartaBoleto()

            Call CartaBoleto()

            Call GerarArquivoRemessa()

            Call GerarArquivoScript()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated
        Try
            If grdListagem.CurrentRow.Cells.Item("percentual").Value = 0 Then
                grdListagem.CurrentRow.Cells.Item("valor_devido_corrigido").Value = grdListagem.CurrentRow.Cells.Item("valor_devido").Value
            Else
                grdListagem.CurrentRow.Cells.Item("valor_devido_corrigido").Value = grdListagem.CurrentRow.Cells.Item("valor_devido").Value + (grdListagem.CurrentRow.Cells.Item("valor_devido").Value * grdListagem.CurrentRow.Cells.Item("percentual").Value / 100)
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroReceitaCobranca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReceitaCobranca, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FinanceiroReceitaCobranca, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFinReceitaCobrancaCartaBoleto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Variável auxiliar
            Dim sCodigo As String = ""
            Dim sCodigoParcela As String = ""

            'Percorrendo os codigos ativos
            For Each oRow In oGrid.GetCheckedRows

                'Se já tiver algum código, adiciona o delimitador
                If sCodigo <> "" Then
                    sCodigo += ","
                End If

                'Concatenando o código
                sCodigo += CStr(oRow.Cells.Item("codigo").Value)
            Next

            'Percorrendo os codigos ativos
            For Each oRow In oGrid.GetCheckedRows

                'Se já tiver algum código, adiciona o delimitador
                If sCodigoParcela <> "" Then
                    sCodigoParcela += ","
                End If

                'Concatenando o código
                sCodigoParcela += CStr(oRow.Cells.Item("codigo_parcela").Value)
            Next

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call oClsUsrFinReceitaCobranca.LoadGridCartaBoleto(grdListagem, _
                                                               sCodigo, _
                                                               sCodigoParcela)

            txtPorcentagemCorrecao.Value = 9.5 / 100
            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaCobranca)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
    Private Sub UpdateTituloCartaBoleto()
        Try
            Cursor.Current = Cursors.WaitCursor

            Dim iCarta As Integer


            For Each oRow In grdListagem.GetRows

                iCarta = LoadCodigo("sp_validate_financeiro_cobranca_carta_boleto " & oRow.Cells.Item("codigo").Value & ", " & goUsuario.iEmpresa)

                If iCarta > 0 Then
                    Continue For
                End If

                oClsUsrFinReceitaCobranca.InsertBoletoBancario(oRow.Cells.Item("codigo").Value, _
                                                                oRow.Cells.Item("codigo_parcela").Value, _
                                                                oRow.Cells.Item("data_vencimento_corrigida").Value, _
                                                                oRow.Cells.Item("valor_devido_corrigido").Value, _
                                                                False, _
                                                                0,
                                                                0, _
                                                                oRow.Cells.Item("valor_devido").Value, _
                                                                oRow.Cells.Item("data_vencimento").Value)
                'oClsUsrFinReceitaCobranca.UpdateTituloCartaBoleta(oRow.Cells.Item("codigo").Value, _
                '                                                  oRow.Cells.Item("codigo_parcela").Value, _
                '                                                  oRow.Cells.Item("valor_devido_corrigido").Value, _
                '                                                  oRow.Cells.Item("data_vencimento_corrigida").Value, _
                '                                                  oRow.Cells.Item("percentual").Value)

            Next
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CartaBoleto()
        Dim sErro As String = ""
        Try
            Dim lCodigoTituloCapa As Long

            Dim sArquivoBoleto As String = ""
            Dim iCodigoBanco As Integer = 0
            Dim sCodigo As String = ""

            'Percorrendo os codigos ativos
            For Each oRow In grdListagem.GetRows

                'Se já tiver algum código, adiciona o delimitador
                If sCodigo <> "" Then
                    sCodigo += ","
                End If

                'Concatenando o código
                sCodigo += CStr(oRow.Cells.Item("codigo").Value)
            Next
            'Instancia para gerar os boletos
            Dim oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
            Dim oClsFrmFatEmissaoNFeTransmissaoLote As New clsFrmFatEmissaoNFeTransmissaoLote

            'Verifica os títulos distintos para gerar os boletos
            ' Dim sCodigoTituloCapa As String = oClsFrmFatEmissaoNFeTransmissaoLote.GerarBoleto(sCodigo)

            'Vetor para verificar todos os boletos
            Dim oVetor() As String = sCodigo.Split(",")

            'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
            'sDiretorio = "\\srv-magma16\ACTi\INTEGRAÇÃO\COBRANÇA\CARTA BOLETO\"
            sDiretorio = "\\SRVFS\ACTi\INTEGRAÇÃO\COBRANÇA\CARTA BOLETO\"
            'sDiretorio = "\\srv-acti-01\Desenvolvimento\MAGMA\CARTA BOLETO\"

            'Exclui o diretório se existir
            'If System.IO.Directory.Exists(sDiretorio) Then
            '    System.IO.Directory.Delete(sDiretorio)
            'End If
            'Cria  a pasta
            'System.IO.Directory.CreateDirectory(sDiretorio)

            'Seta o arquivo final
            Dim sFilePDF As String = sDiretorio + Format(Now, "ddMMyyyy_HHmmss") + ".pdf"

            For i As Integer = 0 To oVetor.Count - 1
                'Gera Arquivo
                oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystal(oVetor(i), sDiretorio, sArquivoBoleto, iCodigoBanco)
            Next

            Cursor.Current = Cursors.WaitCursor


            'Dim sPastaImpressao As String = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            'If sPastaImpressao = "" Then
            '    Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            'Else
            '    If Directory.Exists(sPastaImpressao) = False Then
            '        Throw New Exception("Você não possui permissão para enxergar a pasta (" & sPastaImpressao & ").")
            '    End If
            'End If

            Dim sArquivo As String
            Dim sReport As String = "rptCartaBoleto.rpt"

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
            oRptDocument.SetParameterValue("@codigo_titulo_capa", sCodigo)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            'Abre Conexão com o Banco de Dados
            For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            sArquivo = sDiretorio & "\CARTA_BOLETO" & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

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
    Private Sub EmailCarta()

        Try
            Cursor.Current = Cursors.WaitCursor

            Dim lCodigoTituloCapa As Long

            Dim sArquivoBoleto As String = ""
            Dim iCodigoBanco As Integer = 0
            Dim sCodigo As String = ""

            'Percorrendo os codigos ativos
            For Each oRow As GridEXRow In grdListagem.GetRows

                If oRow.Cells.Item("email").Value = "" Or IsDBNull(oRow.Cells.Item("email").Value) Then
                    Continue For
                End If

                Dim sCorpo As String = ""
                sCorpo &= "<HTML><font face=""TupperPRO  Light"" size=""3"">"
                sCorpo &= "Segue em anexo importante comunicado para seu acompanhamento." & "<br><br>"
                sCorpo &= "Obrigado pela atenção," & "<br>"
                sCorpo &= "Departamento Financeiro | Distribuição Magma | Vale do Paraíba | Litoral Norte | Serra da Mantiqueira | Rua Riachuelo 236, Jardim Paulista - CEP 12216-040 – São José dos Campos - SP | Tel: 12 3923-6183 / 3941-7978  | www.twmagma.com.br"


                'Instancia para gerar os boletos
                Dim oClsFrmFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
                Dim oClsFrmFatEmissaoNFeTransmissaoLote As New clsFrmFatEmissaoNFeTransmissaoLote

                'Serão gerados vários arquivos pdf e depois vão fazer o merge em apenas um arquivo
                'sDiretorio = "\\srv-magma16\ACTi\INTEGRAÇÃO\COBRANÇA\CARTA BOLETO\"
                sDiretorio = "\\SRVFS\ACTi\INTEGRAÇÃO\COBRANÇA\CARTA BOLETO\"
                'sDiretorio = "\\srv-acti-01\Desenvolvimento\MAGMA\ARQUIVOS\"

                'Seta o arquivo final
                Dim sFilePDF As String = sDiretorio + "CARTABOLETO_" + oRow.Cells.Item("numero_documento").Value + ".pdf"


                oClsFrmFinReceitaBoletoBancario.LoadArquivoBoletoLoteCrystal(oRow.Cells.Item("codigo").Value, sDiretorio, sArquivoBoleto, iCodigoBanco)

                Dim sArquivo As String
                Dim sReport As String = "rptCartaBoleto.rpt"

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
                oRptDocument.SetParameterValue("@codigo_titulo_capa", oRow.Cells.Item("codigo").Value)
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                'Abre Conexão com o Banco de Dados
                For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                sArquivo = sDiretorio + oRow.Cells.Item("numero_documento").Value + Format(Now, "ddMMyyyy_HHmmss") + ".pdf"

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                          sFilePDF)

                'Limpa Váriavel
                oRptDocument = Nothing

                'If oRow.Cells.Item("email").Value = "" Then
                '    Continue For
                'End If

                'Enviar E-mail
                ''LoadContato(grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value, TipoContato.Financeiro), _
                Call EnviarEmail("Comunicado Tupperware", _
                                 oRow.Cells.Item("email").Value, _
                                 sFilePDF, _
                                 sFilePDF, _
                                 sCorpo, _
                                 oRow.Cells.Item("codigo_parceiro_negocio").Value, "", -1, -1, TipoAutotextoEmail.Outros, True, sFrom:="atendimento@twmagma.com.br")

            Next
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub GerarArquivoScript()
        Try

            grdListagem.CheckAllRecords()

            'Setando o cursor
            Cursor.Current = Cursors.WaitCursor

            'Váriavel Local
            Dim sPath As String = sDiretorio
            Dim oFolder As New FolderBrowserDialog
            Dim sCodigo As String = ""

            For Each oRow In grdListagem.GetRows

                'Se já tiver algum código, adiciona o delimitador
                If sCodigo <> "" Then
                    sCodigo += ","
                End If

                'Concatenando o código
                sCodigo += CStr(oRow.Cells.Item("codigo").Value)
            Next

            sPath = sPath & "SCRIPT" & Format(Now, "ddMMyyyy_HHmmss") + ".txt"

            'ARQUIVO - CAPA
            sArquivoScript = New StreamWriter(sPath)

            oClsUsrFinReceitaCobranca.ArquivoScript = sArquivoScript
            oClsUsrFinReceitaCobranca.GerarArquivoScript(sCodigo)

            sArquivoScript.Close()

            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = sPath
            Process.Start(psi)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default



        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub GerarArquivoRemessa()

        Try

            grdListagem.CheckAllRecords()

            'Setando o cursor
            Cursor.Current = Cursors.WaitCursor

            'Váriavel Local
            Dim sPath As String = sDiretorio
            Dim oFolder As New FolderBrowserDialog

            Dim iNumeroArquivo As Integer = LoadCodigoTexto("select count(*) from tb_int_conciliacao_bancaria_arquivo_remessa where cast(data_processamento as date) = cast('" & Now.Date & "' as date)")
            If iNumeroArquivo = 0 Then
                iNumeroArquivo = 1
            End If
            sPath = sPath & "CB" & Format(Now, "dd") & Format(Now, "MM") & "A" & CStr(iNumeroArquivo) & ".REM"

            'Gerando o arquivo
            Call oClsIntegracaoBoleto.GerarArquivoRemessa(grdListagem, 7, sPath)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

   

End Class