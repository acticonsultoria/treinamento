Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmFatEmissaoNFeCartaCorrecao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEmissaoNFeCartaCorrecao As New clsFrmFatEmissaoNFeCartaCorrecao

    Private sChaveAcesso As String
    Private sProtocolo As String
    Private sNotaFiscal As String
    Private sSerie As String
    Private sDataEmissao As String
    Private lCodigoEmissaoCapa As Long
    Private lCodigoParceiroNegocio As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

    Public Property Protocolo() As String
        Get
            Return sProtocolo
        End Get
        Set(ByVal value As String)
            sProtocolo = value
        End Set
    End Property

    Public Property NotaFiscal() As String
        Get
            Return sNotaFiscal
        End Get
        Set(ByVal value As String)
            sNotaFiscal = value
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

    Public Property DataEmissao() As String
        Get
            Return sDataEmissao
        End Get
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property CodigoParceiroNegocio() As Long
        Get
            Return lCodigoParceiroNegocio
        End Get
        Set(ByVal value As Long)
            lCodigoParceiroNegocio = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFeCartaCorrecao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub frmFatEmissaoNFeCartaCorrecao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnTransmitirCartaCorrecao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitirCartaCorrecao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Enviar Carta de Correção
                If EnviarCartaCorrecao() = True Then
                    'Fecha o Formulário
                    Me.Dispose()
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnTransmitirCartaCorrecaoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitirCartaCorrecaoEmail.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoEmail() = True Then

                'Enviar Carta de Correção
                If EnviarCartaCorrecao() = True Then
                    Call EmailCartaCorrecao()
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeCartaCorrecao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Dados da Emiss-ão de Nota Fiscal Eletrônica
            Call LoadConfiguracaoNFe()

            'Carrega Dados da Nota Fiscal
            txtChaveAcesso.Text = sChaveAcesso
            txtProtocolo.Text = sProtocolo
            txtNotaFiscal.Text = sNotaFiscal
            txtSerie.Text = sSerie
            txtDataEmissao.Text = sDataEmissao

            'Seta Controles
            txtNumeroSequencia.Value = oClsFatEmissaoNFeCartaCorrecao.LoadSequencia(lCodigoEmissaoCapa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function EnviarCartaCorrecao() As Boolean

        Try

            'Seta Retorno da Função
            EnviarCartaCorrecao = False

            'Verifica se o Usuário Deseja Emitir a Carta de Correção
            If MsgBox("Deseja Emitir Carta de Correção para a Nota Fiscal: " & txtNotaFiscal.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Inutilização de Numeração
                Dim oNFeRecepcaoEvento As New clsNFeRecepcaoEvento_V4

                Dim bHorarioVerao As Boolean
                Dim dData As Date
                bHorarioVerao = LoadCodigoTexto("select horario_verao from tb_cfg_nfe where codigo_empresa = " & goUsuario.iEmpresa)

                If bHorarioVerao = True Then
                    dData = DateAdd(DateInterval.Hour, -1, Now)
                Else
                    dData = Now
                End If

                'Seta Paramentros
                oNFeRecepcaoEvento.ChaveAcesso = txtChaveAcesso.Text.Trim
                oNFeRecepcaoEvento.CondicaoUso = txtCartaCorrecao.Text.Trim
                oNFeRecepcaoEvento.DataEvento = dData
                oNFeRecepcaoEvento.Sequencia = txtNumeroSequencia.Value

                'Cancela NF-e
                If oNFeRecepcaoEvento.Send = True Then

                    'Carrega Arquivo
                    oNFeRecepcaoEvento.LoadArquivo(oNFeRecepcaoEvento.PathArquivoRetorno)

                    'Verifica se foi Homologado a Carta de Correção
                    If oNFeRecepcaoEvento.Status = 128 Then

                        If oNFeRecepcaoEvento.StatusCCe = 135 Then

                            'Seta Parâmetros
                            oClsFatEmissaoNFeCartaCorrecao.CodigoEmissaoCapa = lCodigoEmissaoCapa
                            oClsFatEmissaoNFeCartaCorrecao.CartaCorrecao = txtCartaCorrecao.Text.Trim
                            oClsFatEmissaoNFeCartaCorrecao.DataEvento = oNFeRecepcaoEvento.DataRegistroEvento
                            oClsFatEmissaoNFeCartaCorrecao.Sequencia = txtNumeroSequencia.Value
                            oClsFatEmissaoNFeCartaCorrecao.NumeroProtocolo = oNFeRecepcaoEvento.NumeroProtocolo
                            oClsFatEmissaoNFeCartaCorrecao.XMLEvento = oNFeRecepcaoEvento.ArquivoEnvio
                            oClsFatEmissaoNFeCartaCorrecao.XMLRetorno = oNFeRecepcaoEvento.ArquivoRetorno

                            'Insere Registro no Banco de Dados
                            oClsFatEmissaoNFeCartaCorrecao.Insert()

                            'Informa o Usuário sobre o Sucesso da Operação
                            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                            Return True

                        Else
                            'Informa o Usuário sobre o não Sucesso da Operação
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oNFeRecepcaoEvento.MotivoCCe)
                        End If

                    Else
                        'Informa o Usuário sobre o não Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oNFeRecepcaoEvento.MotivoCCe)
                    End If

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, oNFeRecepcaoEvento.MensagemErro)
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtCartaCorrecao, lblCartaCorrecao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtCartaCorrecao.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtCartaCorrecao.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoEmail() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEmail = False

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtCartaCorrecao, lblCartaCorrecao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtCartaCorrecao.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtCartaCorrecao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - E-mail
            If ValidaCampo(txtEmail, lblEmail, TipoCampo.email) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoEmail = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EmailCartaCorrecao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "FAT000000005.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
            oRptDocument.SetParameterValue("@sequencia", txtNumeroSequencia.Value)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      goConfiguracaoNFe.sPastaImpressao & "CCe_" & sNotaFiscal & ".pdf")

            'Limpa Váriavel
            oRptDocument = Nothing

            'XML
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sMensagemErro As String = ""
            Dim sArquivoXML As String = ""

            'Carrega Arquivo XML
            If oClsNFeArquivoEnvio.XMLCartaCorrecao(lCodigoEmissaoCapa, _
                                                    txtNumeroSequencia.Value, _
                                                    txtChaveAcesso.Text, _
                                                    sArquivoXML, _
                                                    sMensagemErro) = False Then

                'Informa o Usuário o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                Exit Sub

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Carta de Correção da NFe " & sNotaFiscal & " - Chave de Acesso: " & sChaveAcesso, _
                             txtEmail.Text.Trim, _
                             goConfiguracaoNFe.sPastaImpressao & "CCe_" & sNotaFiscal & ".pdf;" & IIf(sArquivoXML = "", "", ";" & sArquivoXML), _
                             goConfiguracaoNFe.sPastaImpressao & "CCe_" & sNotaFiscal & ".pdf;" & IIf(sArquivoXML = "", "", ";" & sArquivoXML), _
                             "", _
                             lCodigoParceiroNegocio)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class