Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmFatEmissaoNFsAcaoEmLote

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmFatEmissaoNFsTransmissaoLote As New clsFrmFatEmissaoNFsTransmissaoLote
    Private oGrid As GridEX
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
    Private Sub btnImprimirNFSe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirNFSe.Click
        Try
            ImprimirNFSe()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + 80)
        Me.Left = (frmMain.tabMain.Left + ((frmMain.tabMain.Width - Me.Width) / 2))

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub grdHistorico_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica Linha Pressionada
            If IsNothing(e.Row) Then Exit Sub



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnTransmitirNFSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitirNFSE.Click
        Try
            Call TransmitirLote()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnRetornarNFSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornarNFSE.Click
        Try
            Call RetornarLote()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnReenviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReenviarEmail.Click
        Try
            EmailNFSe()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExportarBoletoBancario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarBoletoBancario.Click
        Try
            ExportarBoletoBancario()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPDF.Click
        Try
            ExportarPDF()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"
    Private Sub ExportarPDF()
        Try

            Dim oFolder As New FolderBrowserDialog

            'Verifica se selecionou a pasta
            If oFolder.ShowDialog <> vbOK Then Exit Sub

            'For Each oRow In grdListagem.GetRows

            '    WebBrowserNavegacao.Navigate("http://sjc.ginfes.com.br/birt/frameset/?__report=nfs_ver4.rptdesign&cdVerificacao=" & oRow.Cells.Item("codigo_verificacao").Value & "&numNota=" & oRow.Cells.Item("numero_documento").Value)
            '    'WebBrowserNavegacao.Document.Forms(0).InvokeMember("pdf")
            '    'If oRow.Cells.Item("status").Value = StatusNFSe.AutorizadoUso Then
            '    '    ImprimirNFSePDF(oFolder.SelectedPath, "http://sjc.ginfes.com.br/birt/frameset/?__report=nfs_ver4.rptdesign&cdVerificacao=" & oRow.Cells.Item("codigo_verificacao").Value & "&numNota=" & oRow.Cells.Item("numero_documento").Value)

            '    'End If
            '    'WebBrowserNavegacao.Document.InvokeScript("{javascript: submitForm('pdf')}")
            '    'WebBrowserNavegacao.Document.Forms(0).RaiseEvent("EventClick") '  ("{javascript: submitForm('pdf')}")
            '    WebBrowserNavegacao.Document.Links(0).RaiseEvent("EventClick")
            'Next
            frmMain.Informacao("NFS-e(s) exportada(s) com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

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

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call oClsFrmFatEmissaoNFsTransmissaoLote.LoadGrid(sCodigo, _
                                                              grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNF)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub TransmitirLote()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            'Percorrendo as linhas
            For i As Integer = 0 To grdListagem.RecordCount - 1


                'Setando a linha
                grdListagem.Row = i

                If grdListagem.GetValue("status") = StatusNFSe.AguardandoTransmissao Or grdListagem.GetValue("status") = StatusNFSe.Rejeitada Then

                    'Instanciando a classe
                    Dim oClsFatEmissaoNFs As New clsUsrFatEmissaoNFs

                    'Setando o código
                    oClsFatEmissaoNFs.CodigoEmissaoNFSe = grdListagem.GetValue("codigo")

                    'Variável da classe
                    Dim oClsNFSE_EnvioLote As New clsNFSE_EnvioLote


                    'Gera Número RPS
                    If IsDBNull(grdListagem.GetValue("numero_rps")) Then
                        grdListagem.SetValue("numero_rps", oClsFatEmissaoNFs.GeraNumeroRPS)
                    End If

                    'Gera Número do Lote
                    If IsDBNull(grdListagem.GetValue("lote")) Then
                        grdListagem.SetValue("lote", oClsFatEmissaoNFs.GeraNumeroLote)
                    End If

                    'Setando o lote 
                    oClsNFSE_EnvioLote.Lote = grdListagem.GetValue("lote")

                    'Enviando a NFSe
                    If oClsNFSE_EnvioLote.Send = True Then

                        Try

                            'Carregando o arquivo de retorno
                            oClsNFSE_EnvioLote.LoadArquivo(oClsNFSE_EnvioLote.ArquivoRetorno)

                            'Seta Controles conforme Mensagem de Erro
                            If oClsNFSE_EnvioLote.MensagemErro <> "" Then
                                'Setando a mensagem na grid
                                grdListagem.SetValue("mensagem", oClsNFSE_EnvioLote.MensagemErro)


                                'frmMain.Informacao(oClsNFSE_EnvioLote.MensagemErro, gColorInformacaoErro)
                            Else
                                'Seta Controles
                                grdListagem.SetValue("protocolo", oClsNFSE_EnvioLote.Protocolo)
                                grdListagem.SetValue("mensagem", "AGUARDANDO RETORNO")

                                'Atualizando a NFSe
                                oClsFatEmissaoNFs.UpdateStatusNotaFiscal(grdListagem.GetValue("codigo"), _
                                                                         StatusNFSe.AguardandoRetorno, _
                                                                         oClsNFSE_EnvioLote.Protocolo, _
                                                                         oClsNFSE_EnvioLote.DataRecebimento)

                                'Seta o status
                                grdListagem.SetValue("status", StatusNFSe.AguardandoRetorno)
                                grdListagem.SetValue("status2", "AGUARDANDO RETORNO")

                            End If


                        Catch ex As Exception

                            'Não fazer nada no catch, pois irá fazer todas as notas independente dos erros
                        End Try

                    Else

                        'Verifica se houve Erro
                        If oClsNFSE_EnvioLote.MensagemErro <> "" Then

                            'frmMain.Informacao(oClsNFSE_EnvioLote.MensagemErro, gColorInformacaoErro)


                            grdListagem.SetValue("mensagem", oClsNFSE_EnvioLote.MensagemErro)
                        End If

                    End If

                    'Fazendo o garbage da classe
                    oClsFatEmissaoNFs = Nothing

                End If

            Next


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            frmMain.Informacao("Lote(s) transmitido(s) com sucesso!", Color.Blue)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RetornarLote()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Percorrendo os registros
            For i As Integer = 0 To grdListagem.RecordCount - 1

                'Setando a linha
                grdListagem.Row = i

                'Verificando se é para fazer o retorno
                If grdListagem.GetValue("status") = StatusNFSe.AguardandoRetorno Then

                    'Váriaveis Locais
                    Dim oClsNFSeRetornoEnvioNFSe As New clsNFSE_ConsultaLote
                    Dim oClsNFSeConsultaSituacaoNFSe As New clsNFSE_ConsultaSituacaoLoteRPS
                    'Instanciando a classe
                    Dim oClsFatEmissaoNFs As New clsUsrFatEmissaoNFs

                    'Setando o código
                    oClsFatEmissaoNFs.CodigoEmissaoNFSe = grdListagem.GetValue("codigo")

                    'Seta Parâmetros
                    oClsNFSeRetornoEnvioNFSe.Protocolo = grdListagem.GetValue("protocolo")
                    oClsNFSeConsultaSituacaoNFSe.Protocolo = grdListagem.GetValue("protocolo")

                    'Primeiro, consulta a situação do lote para ver se foi aceito
                    If oClsNFSeConsultaSituacaoNFSe.Send = True Then

                        Try

                            'Carregando o arquivo de retorno
                            oClsNFSeConsultaSituacaoNFSe.LoadArquivo(oClsNFSeConsultaSituacaoNFSe.ArquivoRetorno)

                            'Se a situação do lote for 4, quer dizer que foi aceito
                            If oClsNFSeConsultaSituacaoNFSe.Situacao = 4 Then

                                'Seta Controles
                                grdListagem.SetValue("status", StatusNFSe.AutorizadoUso)
                                grdListagem.SetValue("status2", "AUTORIZADO PARA USO")
                                grdListagem.SetValue("mensagem", "AUTORIZADO O USO DA NFS-E")

                                'Verificando o protocolo
                                If oClsNFSeRetornoEnvioNFSe.Send() = True Then

                                    'Carregando o arquivo de retorno, somente para receber o código de verificação
                                    oClsNFSeRetornoEnvioNFSe.LoadArquivoVerificacao(oClsNFSeRetornoEnvioNFSe.ArquivoRetorno)

                                    grdListagem.SetValue("codigo_verificacao", oClsNFSeRetornoEnvioNFSe.CodigoVerificacao)
                                    grdListagem.SetValue("data_emissao", Format(oClsNFSeRetornoEnvioNFSe.DataEmissao, "dd/MM/yyyy"))
                                    grdListagem.SetValue("numero_documento", Format(oClsNFSeRetornoEnvioNFSe.NotaFiscal, "000000000"))


                                    'Atualizando a NFSe
                                    oClsFatEmissaoNFs.UpdateStatusNotaFiscal(grdListagem.GetValue("codigo"), _
                                                                             StatusNFSe.AutorizadoUso, _
                                                                             "", _
                                                                             "", _
                                                                             "AUTORIZADO O USO DA NFS-E", _
                                                                             grdListagem.GetValue("codigo_verificacao"), _
                                                                             oClsNFSeRetornoEnvioNFSe.DataEmissao, _
                                                                             grdListagem.GetValue("numero_documento"))



                                    'Integração
                                    Call Integracao(grdListagem.GetValue("codigo"))

                                    'Seta o valor
                                    ''grdListagem.SetValue("codigo_titulo_capa", LoadCodigoTituloNFSe(grdListagem.GetValue("codigo")))

                                End If

                            ElseIf oClsNFSeRetornoEnvioNFSe.Send() = True Then

                                'Carregando o arquivo de retorno
                                oClsNFSeRetornoEnvioNFSe.LoadArquivo(oClsNFSeRetornoEnvioNFSe.ArquivoRetorno)

                                Dim oXmlDocument As New Xml.XmlDocument
                                oXmlDocument.Load(oClsNFSeRetornoEnvioNFSe.ArquivoRetorno)

                                If oXmlDocument.InnerXml.Contains(">E4<") Then
                                    'Verifica Status
                                    grdListagem.SetValue("mensagem", "O LOTE NÃO FOI PROCESSADO AINDA")
                                    'Atualiza o Status da Nota Fiscal
                                    oClsFatEmissaoNFs.UpdateStatusNotaFiscal(oClsFatEmissaoNFs.CodigoEmissaoNFSe, _
                                                                             StatusNFSe.AguardandoRetorno)

                                Else
                                    'Verifica Status
                                    grdListagem.SetValue("mensagem", "REJEITADA: " & oClsNFSeRetornoEnvioNFSe.MensagemErro)
                                    grdListagem.SetValue("status2", "REJEITADA")
                                    grdListagem.SetValue("status", StatusNFSe.Rejeitada)

                                    'Atualiza o Status da Nota Fiscal
                                    oClsFatEmissaoNFs.UpdateStatusNotaFiscal(oClsFatEmissaoNFs.CodigoEmissaoNFSe, _
                                                                             StatusNFSe.Rejeitada)
                                End If

                            End If

                        Catch ex As Exception
                            'Não fazer nada no catch, pois irá fazer todas as notas independente dos erros
                        End Try

                    Else

                        'Informa o Usuário sobre o Erro Ocorrido
                        'frmMain.Informacao(oClsNFSeRetornoEnvioNFSe.MensagemErro, Color.Red)
                        grdListagem.SetValue("mensagem", oClsNFSeRetornoEnvioNFSe.MensagemErro)
                    End If
                End If

            Next
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            frmMain.Informacao("Lote(s) retornado(s) com sucesso!", Color.Blue)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EmailNFSe()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor



            Dim bAnexarBoleto As Boolean = False

            If MsgBox("Deseja anexar o boleto bancário no e-mail?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Enviar e-mail com boleto bancário") = MsgBoxResult.Yes Then
                bAnexarBoleto = True
            End If
            Dim i As Integer = 0
            For Each oRow In grdListagem.GetRows

                grdListagem.Row = i
                i += 1
                'Verifica o status
                If grdListagem.GetValue("status") <> StatusNFSe.AutorizadoUso Then

                    'Se não estiver autorizada, não enviar o e-mail
                    Continue For
                End If

                'Verifica se possui o E-mail do Tomador
                If grdListagem.GetValue("email_tomador") = "" Then
                    grdListagem.SetValue("mensagem", "E-mail inválido para envio da Nota Fiscal de Serviço Eletrônica.")

                    'Segue para o próximo registro do for
                    Continue For
                End If

                Dim sCaminhoBoleto As String = ""
                Dim sCorpo As String = ""
                sCorpo &= "Prezado(a) , segue as informações da Nota Fiscal de Serviço Eletrônica nº " & CStr(grdListagem.GetValue("numero_documento")) & " da empresa " & goEmitente.sNomeFantasia & "<br>"
                sCorpo &= "Para acessá-la, acesse o link a seguir: http://visualizar.ginfes.com.br/report/consultarNota?__report=nfs_ver4&cdVerificacao=" & grdListagem.GetValue("codigo_verificacao") & "&numNota=" & CStr(grdListagem.GetValue("numero_documento"))
                If bAnexarBoleto = True Then
                    sCorpo &= "<p>Você está recebendo também em anexo o Boleto Bancário referente ao pagamento da NFS-e, no formato PDF.</p>"
                End If
                sCorpo &= "<p>INTERACTI - ACTi Consultoria</p><br>"
                sCorpo &= "www.acticonsultoria.com.br"

                ''Verificando se deseja anexar boleto
                'If oRow.Cells.Item("codigo_titulo_capa").Value <> 0 And bAnexarBoleto = True Then

                '    Dim sArquivo As String = ""
                '    Dim sNumeroDocumento As String = ""
                '    Dim sSerie As String = ""
                '    sArquivo = ImprimirBoletoBancarioPadrao(grdListagem.GetValue("codigo_titulo_capa"), "1", grdListagem.GetValue("numero_documento"), True)
                '    'sCaminhoBoleto = ExportarBoletoPDF(sArquivo, sSerie, sNumeroDocumento)
                '    sCaminhoBoleto = ExportarBoletoPDF(sArquivo, "1", grdListagem.GetValue("numero_documento"))

                '    If sCaminhoBoleto = "" Then
                '        grdListagem.SetValue("mensagem", "ERRO NO ENVIO DO EMAIL")
                '        Continue For
                '    End If
                'End If


                ''Enviando o email  
                'Call EnviarEmailDireto("Emissão de NFS-e - " & goEmitente.sNomeFantasia, _
                '                 grdListagem.GetValue("email_tomador"), _
                '                 sCaminhoBoleto, _
                '                 sCaminhoBoleto, _
                '                 sCorpo, _
                '                 grdListagem.GetValue("codigo_tomador"))



                grdListagem.SetValue("mensagem", "E-MAIL ENVIADO COM SUCESSO!")
            Next

            Cursor.Current = Cursors.Default

            'Informando ao usuário que o e-mail foi enviado 
            frmMain.Informacao("E-mail(s) enviado(s) com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExportarBoletoBancario()
        Try

            Dim oFolder As New FolderBrowserDialog

            'Verifica se selecionou a pasta
            If oFolder.ShowDialog <> vbOK Then Exit Sub

            'Percorrendo os registros
            For i As Integer = 0 To grdListagem.RecordCount - 1

                'Setando o cursor
                grdListagem.Row = i

                'Se não estiver autorizada, não imprimir o boleto
                If grdListagem.GetValue("status") <> StatusNFSe.AutorizadoUso Then
                    Continue For
                End If

                Dim sArquivo As String = ""
                Dim sNumeroDocumento As String = ""
                Dim sSerie As String = ""
                ''sArquivo = ImprimirBoletoBancarioPadrao(grdListagem.GetValue("codigo_titulo_capa"), sSerie, sNumeroDocumento, True)

                'Exportando 
                ''ExportarBoletoPDF(sArquivo, sSerie, sNumeroDocumento, oFolder.SelectedPath)



            Next
            frmMain.Informacao("Boleto(s) exportado(s) com sucesso!", Color.Blue)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImprimirNFSe()
        Try

            For Each oRow In grdListagem.GetRows

                If oRow.Cells.Item("status").Value = StatusNFSe.AutorizadoUso Then
                    System.Diagnostics.Process.Start("http://sjc.ginfes.com.br/birt/frameset/?__report=nfs_ver4.rptdesign&cdVerificacao=" & oRow.Cells.Item("codigo_verificacao").Value & "&numNota=" & oRow.Cells.Item("numero_documento").Value)

                End If

            Next

            frmMain.Informacao("NFS-e(s) impressa(s) com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region


#Region " ::: INTEGRAÇÃO ::: "

    Private Sub Integracao(ByVal lCodigo As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Financeiro
            oClsIntegracao.IntegracaoNFSEmissaoFinanceiro(lCodigo)
            'Pedido de Venda - Financeiro
            oClsIntegracao.IntegracaoNFSEmissaoPedidoVendaFinanceiro(lCodigo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region




End Class