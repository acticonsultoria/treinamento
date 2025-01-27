Public Class usrCfgNumeracaoNF

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgNumeracaoNF As New clsUsrCfgNumeracaoNF

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgNumeracaoNF_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCfgNumeracaoNF_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgNumeracaoNF_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub cboModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModelo.SelectedIndexChanged

        Try

            'Limpa Controles
            cboSerie.DataSource = Nothing
            cboSerie.Text = ""
            txtDescricao.Text = ""
            txtNotaFiscal.Text = ""

            'Verifica se foi selecionado algum modelo
            If cboModelo.SelectedIndex <> -1 Then
                'Carrega Combo - Série
                Call LoadCombo(cboSerie, "sp_select_combo_configuracao_serie_nota_fiscal " & goUsuario.iEmpresa & ", '" & cboModelo.SelectedValue & "'")
                'Carrega Descrição - Modelo
                Call LoadDescricao(txtDescricao, "sp_select_static_descricao_modelo_nota_fiscal '" & cboModelo.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboSerie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSerie.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum modelo
            If cboSerie.SelectedIndex = -1 Then
                'Limpa Controles
                txtNotaFiscal.Text = ""
            Else
                'Carrega Descrição - Número da Nota Fiscal
                Call LoadDescricao(txtNotaFiscal, "sp_select_configuracao_numero_nota_fiscal " & cboSerie.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgNumeracaoNF_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoNumeracaoNotaFiscal, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboModelo, "sp_select_combo_static_modelo_nota_fiscal -1")

            'Seta Focu
            cboModelo.Focus()

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

            'Seta Parametros
            oClsCfgNumeracaoNF.CodigoModelo = cboModelo.SelectedValue
            oClsCfgNumeracaoNF.NotaFiscal = txtNotaFiscal.Text.Trim
            oClsCfgNumeracaoNF.Serie = IIf(cboSerie.SelectedIndex = -1, cboSerie.Text, -1)
            oClsCfgNumeracaoNF.Codigo = IIf(cboSerie.SelectedIndex = -1, -1, cboSerie.SelectedValue)
            'Salva Dados
            oClsCfgNumeracaoNF.Save()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

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

            'Verifica se foi Selecionado o Campo - Moedlo
            If ValidaCampo(cboModelo, lblModelo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Série
            If ValidaCampo(cboSerie, lblSerie, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nota Fiscal
            If ValidaCampo(txtNotaFiscal, lblNotaFiscal, TipoCampo.numero) = False Then
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
