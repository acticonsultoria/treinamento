Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFsCancelar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsFatEmissaoNFsCancelar As New clsFrmFatEmissaoNFsCancelar

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

    Private Sub frmFatEmissaoNFsCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub frmFatEmissaoNFsCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

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

                'Cancelar Nota Fiscal
                CancelarNFSe()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFsCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call LoadConfiguracaoNFSe()

            'Carrega Dados da Nota Fiscal
            txtNotaFiscal.Text = oGrid.CurrentRow.Cells("nota_fiscal").Value
            txtSerie.Text = oGrid.CurrentRow.Cells("serie").Value
            txtDataEmissao.Text = oGrid.CurrentRow.Cells("data_emissao").Value
            txtTomador.Text = oGrid.CurrentRow.Cells("tomador").Value
            txtCodigoVerificacao.Text = oGrid.CurrentRow.Cells("codigo_verificacao").Value

            'Seta Controle
            txtJustificativa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CancelarNFSe()

        Try

            'Verifica se o Usuário deseja Cancelar a Nota Fiscal de Serviço
            If MsgBox("Deseja Cancelar a Nota Fiscal de Serviço Eletrônica: " & vbCrLf & _
                      "NFS-E: " & txtNotaFiscal.Text.Trim & vbCrLf & _
                      "SÉRIE: " & txtSerie.Text.Trim & vbCrLf & _
                      "TOMADOR: " & txtTomador.Text.Trim, _
                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Parâmetros
                oClsFatEmissaoNFsCancelar.CodigoCancelamento = -1
                oClsFatEmissaoNFsCancelar.Justificativa = txtJustificativa.Text.Trim
                oClsFatEmissaoNFsCancelar.Codigo = oGrid.CurrentRow.Cells("codigo").Value

                'Cancela Nota Fiscal
                oClsFatEmissaoNFsCancelar.CancelarNotaFiscal()

                'Integração
                Call Integracao()

                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                Me.Dispose()

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Sub comentada por conta do chamado 6290, cancelamentos de NF irão afetar somente o Status

    'Private Sub CancelarNFSe()

    '    Try

    '        'Verifica se o Usuário deseja Cancelar a Nota Fiscal de Serviço
    '        If MsgBox("Deseja Cancelar a Nota Fiscal de Serviço Eletrônica: " & vbCrLf & _
    '                  "NFS-E: " & txtNotaFiscal.Text.Trim & vbCrLf & _
    '                  "SÉRIE: " & txtSerie.Text.Trim & vbCrLf & _
    '                  "TOMADOR: " & txtTomador.Text.Trim, _
    '                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

    '            'Seta Cursor do Mouse
    '            Cursor.Current = Cursors.WaitCursor

    '            'Inutilização de Numeração
    '            Dim oNFSECancelamento As New clsNFSE_CancelarNFSe

    '            'Seta Paramentros
    '            oNFSECancelamento.CodigoVerificacao = txtCodigoVerificacao.Text
    '            oNFSECancelamento.Numero = txtNotaFiscal.Text

    '            'Cancela NFS-e
    '            If oNFSECancelamento.Send_ABRASF() = True Then

    '                Dim oXmlDocument As New Xml.XmlDocument
    '                oXmlDocument.Load(oNFSECancelamento.ArquivoRetorno)

    '                If oXmlDocument.InnerXml.Contains("sucesso") Or oXmlDocument.InnerXml.Contains("já está cancelada") Or oXmlDocument.InnerXml.Contains("Confirmacao") Then

    '                    'Seta Parâmetros
    '                    oClsFatEmissaoNFsCancelar.CodigoCancelamento = -1
    '                    oClsFatEmissaoNFsCancelar.Justificativa = txtJustificativa.Text.Trim
    '                    oClsFatEmissaoNFsCancelar.Codigo = oGrid.CurrentRow.Cells("codigo").Value

    '                    'Cancela Nota Fiscal
    '                    oClsFatEmissaoNFsCancelar.CancelarNotaFiscal()

    '                    'Integração
    '                    Call Integracao()

    '                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

    '                    Me.Dispose()

    '                Else
    '                    'Informa o Usuário sobre o Erro Ocorrido
    '                    frmMain.Informacao(Mensagem.Erro, oNFSECancelamento.MensagemErro)
    '                End If

    '            Else
    '                'Informa o Usuário sobre o Erro Ocorrido
    '                frmMain.Informacao(Mensagem.Erro, oNFSECancelamento.MensagemErro)
    '            End If

    '        End If

    '        'Seta Cursor do Mouse
    '        Cursor.Current = Cursors.Default

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

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
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtJustificativa.Focus()
                Exit Function
            End If

            If MsgBox("Você confirma que já cancelou a NF-S no site da prefeitura? Cancelar esta NF-S pelo Interacti irá alterar somente o status", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Exit Function

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Financeiro
            oClsIntegracao.IntegracaoNFSEmissaoFinanceiro(oGrid.CurrentRow.Cells("codigo").Value)
            'Pedido de Venda - Financeiro
            oClsIntegracao.IntegracaoNFSEmissaoPedidoVendaFinanceiro(oGrid.CurrentRow.Cells("codigo").Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class