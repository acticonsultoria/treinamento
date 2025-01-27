Imports Janus.Windows.GridEX

Public Class frmCadProdutoPrecoVendaObservacao

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProdutoPrecoVenda As New clsUsrCadProdutoPrecoVenda

    'Váriaveis
    Private lCodigoProduto As Long
    Private sCodigoProduto As String
    Private sReferencia As String
    Private sDescricao As String
    Private sMarca As String
    Private dQuantidadeEstoque As Double
    Private dCustoMedio As Double
    Private dCustoTeorico As Double
    Private dPrecoVendaMedio As Double
    Private sSugestaoVenda As String

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Codigo() As Long
        Set(ByVal value As Long)
            lCodigoProduto = value
        End Set
    End Property

    Public WriteOnly Property CodigoProduto() As String
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
    End Property

    Public WriteOnly Property SugestaoVenda() As String
        Set(ByVal value As String)
            sSugestaoVenda = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCadProdutoPrecoVendaObservacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    Select Case sender.Name
                        Case "txtObservacao", "cboSugestaoVenda" : Call CalculoPrecoVenda()
                    End Select

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCadProdutoPrecoVendaObservacao_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salvar Histórico
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCusto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCusto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Tipo de Custo
            If cboCusto.SelectedIndex <> -1 Then
                If cboCusto.SelectedValue = 1 Then
                    txtCusto.Value = dCustoMedio
                ElseIf cboCusto.SelectedValue = 2 Then
                    txtCusto.Value = dCustoTeorico
                ElseIf cboCusto.SelectedValue = 3 Then
                    txtCusto.Value = dPrecoVendaMedio
                End If
            Else
                txtCusto.Value = 0
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboSugestaoVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSugestaoVenda.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum E-mail
            If cboSugestaoVenda.SelectedIndex > -1 Then

                'Váriaveis
                Dim sObservacao As String = txtObservacao.Text & LoadDescricao("sp_select_cadastro_basico_autotexto_texto " & cboSugestaoVenda.SelectedValue & ", " & goUsuario.iEmpresa)

                'Preenche Controle
                txtObservacao.Tag = sObservacao
                txtObservacao.Text = sObservacao.Replace("<CUSTO>", txtCusto.Value).Replace("<MARGEM>", txtMargem.Value * 100 & "%").Replace("<GP>", txtGP.Value * 100 & "%").Replace("<MARKUP>", txtMarkup.Value).Replace("<PREÇO VENDA>", txtPrecoVenda.Value)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalcularValor(sender As Object, e As EventArgs)

        Try

            If sender.tag <> "" Then Exit Sub

            'Váriaveis Locais
            Dim dCusto As Double = IIf(IsNumeric(txtCusto.Value), txtCusto.Value, 0)
            Dim dMargem As Double = IIf(IsNumeric(txtMargem.Value), txtMargem.Value, 0)
            Dim dMarkup As Double = IIf(IsNumeric(txtMarkup.Value), txtMarkup.Value, 0)
            Dim dGP As Double = IIf(IsNumeric(txtGP.Value), txtGP.Value, 0)
            Dim dPrecoVenda As Double = IIf(IsNumeric(txtPrecoVenda.Value), txtPrecoVenda.Value, 0)

            'Remove Evento
            txtCusto.Tag = "A"
            txtMargem.Tag = "A"
            txtGP.Tag = "A"
            txtMarkup.Tag = "A"
            txtPrecoVenda.Tag = "A"

            Select Case sender.Name

                Case "txtCusto"
                    dPrecoVenda = dCusto + (dCusto * dMargem)
                    dMargem = IIf(dCusto > 0, (dPrecoVenda - dCusto) / dCusto, 0)
                    dMarkup = IIf(dCusto > 0, (dPrecoVenda / dCusto), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCusto) / dPrecoVenda, 0)
                    txtMargem.Value = dMargem
                    txtGP.Value = dGP
                    txtMarkup.Value = dMarkup
                    txtPrecoVenda.Value = dPrecoVenda
                    txtCusto.Value = dCusto

                Case "txtMargem"
                    dPrecoVenda = dCusto + (dCusto * dMargem)
                    dMarkup = IIf(dCusto > 0, (dPrecoVenda / dCusto), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCusto) / dPrecoVenda, 0)
                    txtGP.Value = dGP
                    txtMarkup.Value = dMarkup
                    txtPrecoVenda.Value = dPrecoVenda

                Case "txtMarkup"
                    dPrecoVenda = dCusto * dMarkup
                    dMargem = IIf(dCusto > 0, (dPrecoVenda - dCusto) / dCusto, 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCusto) / dPrecoVenda, 0)
                    txtMargem.Value = dMargem
                    txtGP.Value = dGP
                    txtPrecoVenda.Value = dPrecoVenda

                Case "txtGP"
                    If dGP >= 1 Then txtGP.Value = 0.99 : dGP = 0.99
                    dPrecoVenda = dCusto / (1 - dGP)
                    dMargem = IIf(dCusto > 0, (dPrecoVenda - dCusto) / dCusto, 0)
                    dMarkup = IIf(dCusto > 0, (dPrecoVenda / dCusto), 0)
                    txtMargem.Value = dMargem
                    txtMarkup.Value = dMarkup
                    txtPrecoVenda.Value = dPrecoVenda

                Case "txtPrecoVenda"
                    dMargem = IIf(dCusto > 0, (dPrecoVenda - dCusto) / dCusto, 0)
                    dMarkup = IIf(dCusto > 0, (dPrecoVenda / dCusto), 0)
                    dGP = IIf(dPrecoVenda > 0, (dPrecoVenda - dCusto) / dPrecoVenda, 0)
                    txtMargem.Value = dMargem
                    txtGP.Value = dGP
                    txtMarkup.Value = dMarkup

            End Select

            'Remove Evento
            txtCusto.Tag = ""
            txtMargem.Tag = ""
            txtGP.Tag = ""
            txtMarkup.Tag = ""
            txtPrecoVenda.Tag = ""
            txtObservacao.Text = txtObservacao.Tag.Replace("<CUSTO>", txtCusto.Value).Replace("<MARGEM>", txtMargem.Value * 100 & "%").Replace("<GP>", txtGP.Value * 100 & "%").Replace("<MARKUP>", txtMarkup.Value).Replace("<PREÇO VENDA>", txtPrecoVenda.Value)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCadProdutoPrecoVendaObservacao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoPrecoVenda, gcAdministrator)

            Dim oClsCadProduto As New clsUsrCadProduto

            'Carrega Váriaveis
            Call oClsCadProduto.LoadDadosProduto(lCodigoProduto, _
                                                 sReferencia, _
                                                 sDescricao, _
                                                 sMarca, _
                                                 dQuantidadeEstoque, _
                                                 dCustoMedio, _
                                                 dCustoTeorico, _
                                                 dPrecoVendaMedio)

            'Carrega Combo - Dados Adicionais
            cboCusto.Items.Clear()
            cboCusto.Items.Add("CUSTO MÉDIO", 1)
            cboCusto.Items.Add("CUSTO TEÓRICO", 2)
            cboCusto.Items.Add("C.M. BASE VENDA", 3)
            cboCusto.SelectedValue = 2

            'Carrega Controles
            txtCodigo.Text = sCodigoProduto
            txtDescricao.Text = sDescricao
            txtReferencia.Text = sReferencia
            txtMarca.Text = sMarca
            txtQuantidadeEstoque.Value = dQuantidadeEstoque
            dtpDataValidade.Value = Now.Date : dtpDataValidade.Checked = False
            txtObservacao.Text = sSugestaoVenda

            'Carrega Combo
            LoadCombo(cboSugestaoVenda, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.SugestaoVenda), True)

            'Adiciona ValueChanged
            Call AddValueChanged(Me, New DelegateValueChanged(AddressOf CalcularValor))

            'Seta Focu
            cboSugestaoVenda.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Cancela Orçamento
            Call oClsCadProdutoPrecoVenda.InsertObservacao(lCodigoProduto, _
                                                           IIf(cboCusto.SelectedIndex = -1, -1, cboCusto.SelectedValue), _
                                                           txtCusto.Value, _
                                                           txtPrecoVenda.Value, _
                                                           txtQuantidadeEstoque.Value, _
                                                           IIf(dtpDataValidade.Checked = True, dtpDataValidade.Value, ""), _
                                                           txtObservacao.Text.Trim)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Fecha o Formulário
            Me.Dispose()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculoPrecoVenda()

        Try

            'Carrega Texto Original
            Call cboCombo_SelectedIndexChanged(cboSugestaoVenda, System.EventArgs.Empty)

            ''Abre Formulário
            'Dim oForm As New frmCadProdutoPrecoVenda
            'oForm.TextBox = txtObservacao
            'oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Histórico
            If ValidaCampo(txtObservacao, lblObservacao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtObservacao.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtObservacao.Focus()
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