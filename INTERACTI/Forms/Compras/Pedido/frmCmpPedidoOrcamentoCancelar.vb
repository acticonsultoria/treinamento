Imports Janus.Windows.GridEX

Public Class frmCmpPedidoOrcamentoCancelar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido
    Private sTipo As String

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Tipo() As String
        Set(ByVal value As String)
            sTipo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoOrcamentoCancelar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoOrcamentoCancelar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnReprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprovar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Verifica o Tipo
                Select Case sTipo

                    Case "ORÇAMENTO" : Call ReprovarOrcamento()
                    Case "COMPRA" : Call ReprovarCompra()

                End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoOrcamentoCancelar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Focu
            txtJustificativa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ReprovarOrcamento()

        Try

            'Verifica se o Usuário deseja Cancelar o Pedido
            If MsgBox("Deseja Reprovar o(s) Orçamento(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis Locais
                Dim oClsCmpCotacao As New clsUsrCmpCotacao
                Dim sEmails As String = ""
                Dim sTexto As String = ""

                'Cancela Orçamento
                For Each oRow As GridEXRow In gSelecaoRow

                    'Atualiza Cotação
                    Call oClsCmpCotacao.UpdateCotacaoFornecedorItem(oRow.Cells("codigo_cotacao").Value, _
                                                                    oRow.Cells("codigo_cotacao_fornecedor").Value, _
                                                                    oRow.Cells("codigo_cotacao_item").Value, _
                                                                    False, _
                                                                    txtJustificativa.Text.Trim)

                    'Váriavel - E-mail
                    Dim sEmail As String = CType(LoadDescricao("sp_select_email_compras_cotacao " & oRow.Cells("codigo_cotacao").Value & ", " & goUsuario.iEmpresa), String)

                    If sEmail <> "" Then
                        If sEmails.Contains(sEmail) = False Then
                            sEmails &= IIf(sEmails = "", "", "; ") & sEmail
                        End If
                    End If

                    sTexto &= IIf(sTexto = "", "", vbCrLf & vbCrLf) & "Cotação: " & oRow.Parent.Cells("numero_cotacao").Value & " - Requisição: " & oRow.Cells("numero_requisicao").Value & " - Produto: " & oRow.Cells("codigo_item").Value & " - " & oRow.Cells("descricao").Value & vbCrLf & txtJustificativa.Text.Trim

                Next

                'Envia e-mail
                Call EnviarEmail("Reprovação da Cotação", _
                                 sEmails, _
                                 "", _
                                 "", _
                                 sTexto, _
                                 -1)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ReprovarCompra()

        Try

            'Verifica se o Usuário deseja Cancelar o Pedido
            If MsgBox("Deseja Reprovar as(s) Compras(s) Selecionada(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis Locais
                Dim oClsCmpCotacao As New clsUsrCmpCotacao
                Dim sEmails As String = ""
                Dim sTexto As String = ""

                'Cancela Orçamento
                For Each oRow As GridEXRow In gSelecaoRow

                    'Verifica se é um Filho
                    If oRow.Table.Key = "item" Then

                        'Atualiza Cotação
                        Call oClsCmpCotacao.ReprovarCompra(oRow.Cells("codigo_cotacao").Value, _
                                                           oRow.Cells("codigo_cotacao_fornecedor").Value, _
                                                           oRow.Cells("codigo_cotacao_item").Value, _
                                                           oRow.Cells("codigo_requisicao").Value, _
                                                           oRow.Cells("codigo_requisicao_item").Value, _
                                                           txtJustificativa.Text.Trim)

                        'Váriavel - E-mail
                        Dim sEmail As String = CType(LoadDescricao("sp_select_email_compras_requisicao " & oRow.Cells("codigo_requisicao").Value & ", " & goUsuario.iEmpresa), String)

                        If sEmail <> "" Then
                            If sEmails.Contains(sEmail) = False Then
                                sEmails &= IIf(sEmails = "", "", "; ") & sEmail
                            End If
                        End If

                        sTexto &= IIf(sTexto = "", "", vbCrLf & vbCrLf) & "Requisição: " & oRow.Cells("numero_requisicao").Value & " - Produto: " & oRow.Cells("codigo_item").Value & " - " & oRow.Cells("descricao").Value & vbCrLf & txtJustificativa.Text.Trim

                    End If

                Next

                'Envia e-mail
                Call EnviarEmail("Reprovação de Compra", _
                                 sEmails, _
                                 "", _
                                 "", _
                                 sTexto, _
                                 -1)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, pagJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.errInfo.SetError(pagJustificativa, "A Justificativa deve possuir ao menos 15 Caracteres.")
                txtJustificativa.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class