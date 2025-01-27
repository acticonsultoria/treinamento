Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmFatEmissaoMDFeCancelar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsFatEmissaoMDFeCancelar As New clsFrmFatEmissaoMDFeCancelar
    Private sChaveAcesso As String
    Private sProtocolo As String
    Private sModelo As String
    Private sSerie As String
    Private sNumeroDocumento As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Protocolo() As String
        Get
            Return sProtocolo
        End Get
        Set(ByVal value As String)
            sProtocolo = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return sModelo
        End Get
        Set(ByVal value As String)
            sModelo = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return sSerie
        End Get
        Set(ByVal value As String)
            sSerie = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

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

    Private Sub frmFatEmissaoMDFeCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter : Call Control_Enter(sender)

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoMDFeCancelar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                CancelarMDFe()

            End If
            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CANCELAR :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoMDFeCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            Call LoadConfiguracaoMDFe()
            'dtpDataEmissao.Value = oGrid.CurrentRow.Cells("data_emissao").Value
            dtpDataEmissao.Value = Now
            txtNumeroDocumento.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("numero_documento").Value), "", oGrid.CurrentRow.Cells("numero_documento").Value)
            txtModelo.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("codigo_modelo").Value), "", oGrid.CurrentRow.Cells("codigo_modelo").Value)
            txtProtocolo.Text = oGrid.CurrentRow.Cells("numero_protocolo").Value
            txtChaveAcesso.Text = oGrid.CurrentRow.Cells("chave_acesso").Value
            txtSerie.Text = IIf(IsDBNull(oGrid.CurrentRow.Cells("serie").Value), "", oGrid.CurrentRow.Cells("serie").Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    'Private Sub CancelarMDFeSEFAZ()

    '    Try

    '        If MsgBox("Deseja Cancelar o Manifesto Eletrônico: " & txtNumeroDocumento.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

    '            'Seta Cursor do Mouse
    '            Cursor.Current = Cursors.WaitCursor

    '            'Inutilização de Numeração
    '            Dim oNFeEventoCancelamento As New clsNFeEventoCancelamento

    '            'Seta Paramentros
    '            oNFeEventoCancelamento.Chave = txtNumeroDocumento.Text.Trim
    '            'oNFeEventoCancelamento.NumeroProtocoloAutorizacao = txtProtocolo.Text.Trim
    '            oNFeEventoCancelamento.Justificativa = txtJustificativa.Text.Trim
    '            oNFeEventoCancelamento.Sequencia = "01"
    '            oNFeEventoCancelamento.DataEmissao = dtpDataEmissao.Value

    '            'Cancela NF-e
    '            If oNFeEventoCancelamento.Send = True Then

    '                'Carrega Arquivo
    '                oNFeEventoCancelamento.LoadArquivo(oNFeEventoCancelamento.PathArquivoRetorno)

    '                'Verifica se foi homologado o cancelamento
    '                If oNFeEventoCancelamento.Status = 135 Or oNFeEventoCancelamento.Status = 136 Or oNFeEventoCancelamento.Status = 155 Then

    '                    Dim oStreamReader As System.IO.StreamReader
    '                    Dim sXMLEnvio As String
    '                    oStreamReader = System.IO.File.OpenText(oNFeEventoCancelamento.ArquivoEnvio)
    '                    sXMLEnvio = oStreamReader.ReadToEnd
    '                    oStreamReader.Close()

    '                    'Atualiza Nota Fiscal Eletrônica
    '                    oClsFatEmissaoNFeCancelar.UpdateNFeCancelamento(oNFeEventoCancelamento.Motivo, _
    '                                                                    oNFeEventoCancelamento.Chave, _
    '                                                                    txtJustificativa.Text.Trim, _
    '                                                                   sXMLEnvio, _
    '                                                                    oNFeEventoCancelamento.ArquivoRetorno)

    '                    'Integração
    '                    Call Integracao()

    '                    'Informa o Usuário sobre o Sucesso da Operação
    '                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

    '                    'Verifica se o Usuário deseja enviar para o Cliente a Notificação
    '                    If MsgBox("Deseja avisar o Cliente sobre o Cancelamento da NF-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
    '                        'Envia E-mail de Cancelamento
    '                        Call EmailCancelamentoNFe()
    '                    End If

    '                ElseIf oNFeEventoCancelamento.Status = 420 Then

    '                    Dim sProtocolo As String = ""
    '                    sProtocolo = oNFeEventoCancelamento.Motivo
    '                    sProtocolo = Mid(sProtocolo, InStr(sProtocolo, "[") - 1)
    '                    sProtocolo = Mid(sProtocolo, InStr(sProtocolo, ":") + 1)
    '                    sProtocolo = Replace(sProtocolo, "]", "")


    '                    'Atualiza Nota Fiscal Eletrônica
    '                    oClsFatEmissaoNFeCancelar.UpdateNFeCancelamento("CANCELAMENTO DA NF-E HOMOLOGADO", _
    '                                                                    oNFeEventoCancelamento.Chave, _
    '                                                                    txtJustificativa.Text.Trim, _
    '                                                                    oNFeEventoCancelamento.XMLCancelamentoEnvio, _
    '                                                                    oNFeEventoCancelamento.XMLCancelamentoRecepcao)

    '                    'Integração
    '                    Call Integracao()

    '                    'Informa o Usuário sobre o Sucesso da Operação
    '                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

    '                    'Verifica se o Usuário deseja enviar para o Cliente a Notificação
    '                    If MsgBox("Deseja avisar o Cliente sobre o Cancelamento da NF-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
    '                        'Envia E-mail de Cancelamento
    '                        Call EmailCancelamentoNFe()
    '                    End If

    '                Else
    '                    'Informa o Usuário sobre o Erro da Operação
    '                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oNFeEventoCancelamento.Motivo)
    '                End If

    '            Else
    '                'Informa o Usuário sobre o Erro Ocorrido
    '                frmMain.Informacao(Mensagem.Erro, oNFeEventoCancelamento.MensagemErro)
    '            End If

    '        End If

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.Default

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Private Sub CancelarMDFe()

        Try

            If MsgBox("Deseja Cancelar o manifesto: " & txtNumeroDocumento.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Inutilização de Numeração
                Dim oEventoCancelamento As New clsMDFeEventoCancelamento_V3

                'Seta Paramentros
                oEventoCancelamento.Chave = txtChaveAcesso.Text.Trim
                oEventoCancelamento.NumeroProtocoloAutorizacao = txtProtocolo.Text.Trim
                oEventoCancelamento.Justificativa = txtJustificativa.Text.Trim
                oEventoCancelamento.Sequencia = "01"
                oEventoCancelamento.DataEmissao = dtpDataEmissao.Value

                'Cancela NF-e
                If oEventoCancelamento.Send = True Then

                    'Carrega Arquivo
                    oEventoCancelamento.LoadArquivo(oEventoCancelamento.PathArquivoRetorno)

                    'Verifica se foi homologado o cancelamento
                    If oEventoCancelamento.Status = 135 Or oEventoCancelamento.Status = 136 Or oEventoCancelamento.Status = 155 Then

                        Dim oStreamReader As System.IO.StreamReader
                        Dim sXMLEnvio As String
                        oStreamReader = System.IO.File.OpenText(oEventoCancelamento.ArquivoEnvio)
                        sXMLEnvio = oStreamReader.ReadToEnd
                        oStreamReader.Close()

                        'Atualiza Nota Fiscal Eletrônica
                        oClsFatEmissaoMDFeCancelar.UpdateMDFeCancelamento(oEventoCancelamento.Motivo, _
                                                                        oEventoCancelamento.Chave, _
                                                                        txtJustificativa.Text.Trim, _
                                                                       sXMLEnvio, _
                                                                        oEventoCancelamento.ArquivoRetorno)



                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    ElseIf oEventoCancelamento.Status = 420 Then

                        Dim sProtocolo As String = ""
                        sProtocolo = oEventoCancelamento.Motivo
                        sProtocolo = Mid(sProtocolo, InStr(sProtocolo, "[") - 1)
                        sProtocolo = Mid(sProtocolo, InStr(sProtocolo, ":") + 1)
                        sProtocolo = Replace(sProtocolo, "]", "")


                        'Atualiza Nota Fiscal Eletrônica
                        oClsFatEmissaoMDFeCancelar.UpdateMDFeCancelamento("CANCELAMENTO DA MDF-E HOMOLOGADO", _
                                                                        oEventoCancelamento.Chave, _
                                                                        txtJustificativa.Text.Trim, _
                                                                        oEventoCancelamento.XMLCancelamentoEnvio, _
                                                                        oEventoCancelamento.XMLCancelamentoRecepcao)



                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    Else
                        'Informa o Usuário sobre o Erro da Operação
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oEventoCancelamento.Motivo)
                    End If

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, oEventoCancelamento.MensagemErro)
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtJustificativa.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EmailCancelamentoMDFe()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sArquivoEnvio As String = ""
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
            oClsFatEmissaoNFe.LoadDadosNFe(oGrid.CurrentRow.Cells("codigo").Value, _
                                           sArquivoNFe, _
                                           sArquivoProtocoloNFe, _
                                           sArquivoCancelamentoNFe, _
                                           sArquivoProtocoloCancelamentoNFe, _
                                           sChaveAcesso, _
                                           sNotaFiscal, _
                                           lCodigoParceiroNegocio, _
                                           lCodigoTituloCapa)

            'Verifica se foi possível gerar o Arquivo
            If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                              sArquivoProtocoloNFe, _ 
                                              sChaveAcesso, _
                                              sArquivoEnvio, _
                                              sMensagemErro) = True Then

                'Abre Relatório
                oRptDocument.Load(goCrystalReport.sPath & LoadDescricao("sp_select_faturamento_emissao_relatorio_danfe " & goUsuario.iEmpresa & ", " & oGrid.CurrentRow.Cells("codigo").Value), _
                                  CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                'Seta Parametros Relatório
                oRptDocument.SetParameterValue("@codigo_emissao_capa", oGrid.CurrentRow.Cells("codigo").Value)
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                'Abre Conexão com o Banco de Dados
                For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                Dim sArquivoReport As String = goConfiguracaoNFe.sPastaImpressao & sNotaFiscal & ".pdf"

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                          sArquivoReport)

                'Limpa Váriavel
                oRptDocument = Nothing

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Enviar E-mail
                Call EnviarEmail(goUsuario.sEmpresa & " - Cancelamento da NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                                 LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & oGrid.CurrentRow.Cells("codigo").Value), _
                                 sArquivoReport & "; " & sArquivoEnvio, _
                                 sArquivoReport & "; " & sArquivoEnvio, _
                                 "", _
                                 lCodigoParceiroNegocio, _
                                 "", _
                                 -1)

                'Limpa Váriavel
                oRptDocument = Nothing

            Else

                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, sMensagemErro)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: INTEGRAÇÃO :::"

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Salva Movimentação - Estoque
            oClsIntegracao.IntegracaoNFEmissaoEstoque(oGrid.CurrentRow.Cells("codigo_emissao_capa").Value)
            'Salva Financeiro - Receita
            oClsIntegracao.IntegracaoNFEmissaoFinanceiro(oGrid.CurrentRow.Cells("codigo_emissao_capa").Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region
     
End Class