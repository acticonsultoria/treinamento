Imports System.IO

Public Class usrNFeConsultaSituacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEmissaoNFe As New clsUsrFatEmissaoNFe
    Private sXMLProtocolo As String

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrNFeConsultaSituacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrNFeConsultaSituacao_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConsultarSituacaoNF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarSituacaoNF.Click

        'Valida Dados do Formulário
        If Validacao = True Then

            'Consulta Situação da NF
            Call ConsultarSituacaoNF()

        End If

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Focu
            txtChaveAcesso.Focus()

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call LoadConfiguracaoNFe()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ConsultarSituacaoNF()

        'Váriaveis Locais
        Dim oClsNFeConsultaSituacao As New clsNFeConsultaSituacao_V4

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmetros
            oClsNFeConsultaSituacao.ChaveAcesso = txtChaveAcesso.Text.Trim

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Consulta Situação
            If oClsNFeConsultaSituacao.Send() = True Then

                'Carrega Arquivo
                oClsNFeConsultaSituacao.LoadArquivo(oClsNFeConsultaSituacao.PathArquivoRetorno)

                'Seta Controles                
                lblValorAmbiente.Text = oClsNFeConsultaSituacao.Ambiente
                lblValorUF.Text = oClsNFeConsultaSituacao.UF
                lblValorStatus.Text = oClsNFeConsultaSituacao.Status
                lblValorMotivo.Text = oClsNFeConsultaSituacao.Motivo.ToUpper
                lblValorProtocolo.Text = oClsNFeConsultaSituacao.Protocolo
                lblValorDataRecibo.Text = oClsNFeConsultaSituacao.DataRecibo
                sXMLProtocolo = oClsNFeConsultaSituacao.XMLRetorno

                'Exclui Arquivo de Envio e Arquivo de Retorno
                File.Delete(oClsNFeConsultaSituacao.PathArquivoEnvio)
                File.Delete(oClsNFeConsultaSituacao.PathArquivoRetorno)

            Else
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaSituacao.MensagemErro)
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

            'Verifica se foi Preenchido o Campo - Chave de Acesso
            If ValidaCampo(txtChaveAcesso, lblChaveAcesso, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Chave de Acesso com 44 caracteres
            If Len(txtChaveAcesso.Text.Trim) <> 44 Then
                frmMain.errInfo.SetError(lblChaveAcesso, "A Chave de Acesso Preenchida é Inválida.")
                txtChaveAcesso.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

#End Region

End Class
