Imports System.IO

Public Class usrNFeConsultarSituacaoParceiroNegocio

#Region "::: VÁRIAVEIS :::"

    Private oFormularioCadastroBasico() As FormularioCadastroBasico

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrNFeConsultarSituacaoParceiroNegocio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrNFeConsultarSituacaoParceiroNegocio_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona o Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Try

            'Valida Dados do Formulário
            If ValidacaoConsulta() = True Then

                'Consulta Situação da NF
                Call Consultar()

            End If

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click

        Try

            'Valida 
            If ValidacaoCadastrar() = True Then

                'Salva o Fornecedor 
                Call Salvar()

            End If

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Configuração Nota Fiscal
            Call LoadConfiguracaoNFe()

            'Carrega Combo
            Call LoadCombo(cboUFContribuinte, "sp_select_combo_static_estado_consulta_contribuinte " & goConfiguracaoNFe.iCodigoTipoAmbienteNFe)

            'Seta Focu
            txtCNPJContribuinte.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub Consultar()

        'Váriaveis Locais
        Dim oClsNFeConsultaCadastro As New clsNFeConsultaCadastro_V4

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            lblValorBairro.Text = "-"
            lblValorCEP.Text = "-"
            lblValorCNAE.Text = "-"
            lblValorDataInicioAtividade.Text = "-"
            lblValorLogradouro.Text = "-"
            lblValorComplemento.Text = "-"
            lblValorMunicipio.Text = "-"
            lblValorNumero.Text = "-"
            lblValorRazaoSocial.Text = "-"
            lblValorSituacao.Text = "-"
            lblValorSituacaoContribuinte.Text = "-"
            lblValorUF.Text = "-"
            lblValorInscricaoEstadual.Text = "-"
            lblValorNomeFantasia.Text = "-"

            'Seta Parâmetros
            oClsNFeConsultaCadastro.CNPJConsulta = txtCNPJContribuinte.Text.Trim
            oClsNFeConsultaCadastro.UFConsulta = cboUFContribuinte.Text
            oClsNFeConsultaCadastro.CodigoIBGEUFConsulta = cboUFContribuinte.SelectedValue
            oClsNFeConsultaCadastro.TipoConsulta = 0

            'Consulta Situação
            If oClsNFeConsultaCadastro.Send() = True Then

                'Carrega Arquivo
                If oClsNFeConsultaCadastro.LoadArquivo(oClsNFeConsultaCadastro.ArquivoRetorno) = True Then

                    'Seta Controles    
                    If Not oClsNFeConsultaCadastro.Bairro Is Nothing Then lblValorBairro.Text = oClsNFeConsultaCadastro.Bairro.ToUpper
                    If Not oClsNFeConsultaCadastro.CEP Is Nothing Then lblValorCEP.Text = oClsNFeConsultaCadastro.CEP.ToUpper
                    If Not oClsNFeConsultaCadastro.CNAE Is Nothing Then lblValorCNAE.Text = oClsNFeConsultaCadastro.CNAE.ToUpper
                    If Not oClsNFeConsultaCadastro.DataInicioAtividade Is Nothing Then lblValorDataInicioAtividade.Text = oClsNFeConsultaCadastro.DataInicioAtividade.ToUpper
                    If Not oClsNFeConsultaCadastro.Logradouro Is Nothing Then lblValorLogradouro.Text = oClsNFeConsultaCadastro.Logradouro.ToUpper
                    If Not oClsNFeConsultaCadastro.Complemento Is Nothing Then lblValorComplemento.Text = oClsNFeConsultaCadastro.Complemento.ToUpper
                    If Not oClsNFeConsultaCadastro.Municipio Is Nothing Then lblValorMunicipio.Text = oClsNFeConsultaCadastro.Municipio.ToUpper
                    If Not oClsNFeConsultaCadastro.Numero Is Nothing Then lblValorNumero.Text = oClsNFeConsultaCadastro.Numero.ToUpper
                    If Not oClsNFeConsultaCadastro.RazaoSocial Is Nothing Then lblValorRazaoSocial.Text = oClsNFeConsultaCadastro.RazaoSocial.ToUpper
                    If Not oClsNFeConsultaCadastro.Situacao Is Nothing Then lblValorSituacao.Text = oClsNFeConsultaCadastro.Situacao.ToUpper
                    If Not oClsNFeConsultaCadastro.SituacaoNFe Is Nothing Then lblValorSituacaoContribuinte.Text = oClsNFeConsultaCadastro.SituacaoNFe.ToUpper
                    If Not oClsNFeConsultaCadastro.UF Is Nothing Then lblValorUF.Text = oClsNFeConsultaCadastro.UF.ToUpper
                    If Not oClsNFeConsultaCadastro.IE Is Nothing Then lblValorInscricaoEstadual.Text = oClsNFeConsultaCadastro.IE.ToUpper
                    If Not oClsNFeConsultaCadastro.NomeFantasia Is Nothing Then lblValorNomeFantasia.Text = oClsNFeConsultaCadastro.NomeFantasia.ToUpper

                Else

                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaCadastro.MensagemErro)
                    'Exclui Arquivo de Envio e Arquivo de Retorno
                    File.Delete(oClsNFeConsultaCadastro.ArquivoRetorno)

                End If

                'Exclui Arquivo de Envio e Arquivo de Envio
                File.Delete(oClsNFeConsultaCadastro.ArquivoEnvio)

            Else
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsNFeConsultaCadastro.MensagemErro)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Carrega Váriaveis
            ReDim oFormularioCadastroBasico(13)
            oFormularioCadastroBasico(0).oValor = lblValorBairro.Text : oFormularioCadastroBasico(0).sControle = "txtBairro"
            oFormularioCadastroBasico(1).oValor = lblValorCEP.Text : oFormularioCadastroBasico(1).sControle = "txtCEP"
            oFormularioCadastroBasico(2).oValor = lblValorCNAE.Text : oFormularioCadastroBasico(2).sControle = "txtCNAE"
            oFormularioCadastroBasico(3).oValor = CInt(Pais.Brasil) : oFormularioCadastroBasico(3).sControle = "cboPais"
            oFormularioCadastroBasico(4).oValor = cboUFContribuinte.Text : oFormularioCadastroBasico(4).sControle = "cboUF"
            oFormularioCadastroBasico(5).oValor = lblValorLogradouro.Text : oFormularioCadastroBasico(5).sControle = "txtLogradouro"
            oFormularioCadastroBasico(6).oValor = lblValorComplemento.Text : oFormularioCadastroBasico(6).sControle = "txtComplemento"
            oFormularioCadastroBasico(7).oValor = LoadDescricao("sp_select_static_codigo_municipio '" & cboUFContribuinte.Text & "', '" & lblValorMunicipio.Text.Replace("'", "´") & "'") : oFormularioCadastroBasico(7).sControle = "cboMunicipio"
            oFormularioCadastroBasico(8).oValor = lblValorNumero.Text : oFormularioCadastroBasico(8).sControle = "txtNumero"
            oFormularioCadastroBasico(9).oValor = lblValorRazaoSocial.Text : oFormularioCadastroBasico(9).sControle = "txtRazaoSocial"
            oFormularioCadastroBasico(10).oValor = CInt(Personalidade.Juridica) : oFormularioCadastroBasico(10).sControle = "cboPersonalidade"
            oFormularioCadastroBasico(11).oValor = lblValorInscricaoEstadual.Text : oFormularioCadastroBasico(11).sControle = "txtInscricaoEstadual"
            oFormularioCadastroBasico(12).oValor = lblValorNomeFantasia.Text : oFormularioCadastroBasico(12).sControle = "txtNomeFantasia"
            oFormularioCadastroBasico(13).oValor = txtCNPJContribuinte.Text.Trim : oFormularioCadastroBasico(13).sControle = "txtCnpjCpf"

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio", oFormularioCadastroBasico)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoConsulta() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoConsulta = False

            'Verifica se foi Preenchido o Campo - CNPJ /  CPF
            If ValidaCampo(txtCNPJContribuinte, lblCNPJContribuinte, TipoCampo.texto) = False Then
                Exit Function
            ElseIf ValidaCNPJ(txtCNPJContribuinte.Text) = False Then
                frmMain.errInfo.SetError(lblCNPJContribuinte, "Este CNPJ: " & txtCNPJContribuinte.Text.Trim & " não é válido.")
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFContribuinte, lblUFContribuinte) = False Then
                Exit Function
            End If

            'Valida Dados da Transmissão
            If ValidacaoTransmissao() = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoConsulta = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoCadastrar() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCadastrar = False

            'Valida Formulário
            If lblRazaoSocial.Text = "-" Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCadastrar = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoTransmissao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoTransmissao = False

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Configuração da NFe
            If LoadConfiguracaoNFe() = False Then
                'Informa o Usuário que não existe configuração de Nota Fiscal Eletrônica cadastrada
                frmMain.Informacao(Mensagem.NaoFoiInformado, "a Configuração da NFe")
                Exit Function
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

            'Verifica se o Serviço está ativo
            If ValidaServico() = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoTransmissao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidaServico() As Boolean

        Try

            'Váriaveis Locais
            Dim oClsNFeStatusServico As New clsNFeStatusServico_V4

            'Envia Arquivo
            If oClsNFeStatusServico.Send() = True Then

                'Carrega Arquivo
                oClsNFeStatusServico.LoadArquivo(oClsNFeStatusServico.ArquivoRetorno)

                'Exclui Arquivo de Envio e Arquivo de Retorno
                File.Delete(oClsNFeStatusServico.ArquivoEnvio)
                File.Delete(oClsNFeStatusServico.ArquivoRetorno)

                If oClsNFeStatusServico.Status <> 107 Then
                    frmMain.Informacao(Mensagem.Erro, oClsNFeStatusServico.Motivo)
                    Return False
                End If

            Else
                frmMain.Informacao(Mensagem.Erro, oClsNFeStatusServico.MensagemErro)
                Return False
            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
