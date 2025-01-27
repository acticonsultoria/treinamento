Imports System.IO

Public Class usrNFeStatusServico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgEmail As New clsUsrCfgEmail

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrNFeStatusServico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrNFeStatusServico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConsultarStatusServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarStatusServico.Click

        Try

            'Valida Dados do Serviço
            If Validacao() = True Then

                'Consulta Status do Serviço
                Call ConsultarStatusServico()

            End If

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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call LoadConfiguracaoNFe()

            'Seta Controles
            lblValorAmbiente.Text = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "HOMOLOGAÇÃO", "PRODUÇÃO")
            lblValorUF.Text = goConfiguracaoNFe.sUF

            'Seta Focu
            btnConsultarStatusServico.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ConsultarStatusServico()

        'Váriaveis Locais
        Dim oClsNFeStatusServico As New clsNFeStatusServico_V4

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados da NFe
            Call LoadConfiguracaoNFe()

            'Seta Parâmetros
            If oClsNFeStatusServico.Send() = True Then

                'Carrega Arquivo
                oClsNFeStatusServico.LoadArquivo(oClsNFeStatusServico.ArquivoRetorno)

                'Seta Controles                
                lblValorStatus.Text = oClsNFeStatusServico.Status
                lblValorMotivo.Text = oClsNFeStatusServico.Motivo.ToUpper
                lblValorDataProcessamento.Text = oClsNFeStatusServico.DataProcessamento
                lblValorTempoMedioResposta.Text = oClsNFeStatusServico.TempoMedioResposta & " seg"
                lblValorDataPrevisaoRetorno.Text = IIf(oClsNFeStatusServico.Status = 107, "-", oClsNFeStatusServico.DataPrevistaRetorno)

                'Exclui Arquivo de Envio e Arquivo de Retorno
                File.Delete(oClsNFeStatusServico.ArquivoEnvio)
                File.Delete(oClsNFeStatusServico.ArquivoRetorno)

            Else
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsNFeStatusServico.MensagemErro)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Carrega Configuração da NFe
            If LoadConfiguracaoNFe() = False Then
                'Informa o Usuário que não existe configuração de Nota Fiscal Eletrônica cadastrada
                frmMain.Informacao(Mensagem.NaoFoiInformado, "a Configuração da NFe")
                Exit Function
            Else
                'Seta Ambiente - NFe
                lblValorAmbiente.Text = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "HOMOLOGAÇÃO", "PRODUÇÃO")
            End If

            'Verifica se a Pasta de Entrada Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaEntrada) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaEntrada)
                Exit Function
            End If

            'Verifica se a Pasta de Envio Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaEnvio) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaEnvio)
                Exit Function
            End If

            'Verifica se a Pasta de Impressão Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaImpressao) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaImpressao)
                Exit Function
            End If

            'Verifica se a Pasta de Recibo Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaRecibo) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaRecibo)
                Exit Function
            End If

            'Verifica se a Pasta de Saída Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaSaida) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaSaida)
                Exit Function
            End If

            'Verifica se a Pasta XSD Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaXSD) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaXSD)
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

#End Region

End Class
