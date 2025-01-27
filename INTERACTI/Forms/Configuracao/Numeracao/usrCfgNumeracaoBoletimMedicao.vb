Public Class usrCfgNumeracaoBoletimMedicao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgNumeracaoDocumento As New clsUsrCfgNumeracaoDocumento

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgNumeracaoBoletimMedicao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgNumeracaoBoletimMedicao_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFormato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormato.SelectedIndexChanged, _
                                                                                          txtSigla.TextChanged, _
                                                                                          txtNumeroBoletimMedicao.ValueChanged, _
                                                                                          txtNumeroCaracter.ValueChanged, _
                                                                                          cboFormato.SelectedIndexChanged

        Try

            'Limpa Controles
            txtExemplo.Text = ""

            'Verifica se foi selecionado algum modelo
            If cboFormato.SelectedIndex <> -1 Then

                'Carrega Controles
                LoadDescricaoQuery(txtExemplo, "SELECT dbo.fn_formato_numero_documento_exemplo(" & txtNumeroBoletimMedicao.Value & ",'" & txtSigla.Text.Trim & "', GETDATE(), " & txtNumeroCaracter.Value & ", " & cboFormato.SelectedValue & ")")

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

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoNumeracaoOrdemServico, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboFormato, "sp_select_combo_static_formato_numero", False)

            'Carrega Controles
            oClsCfgNumeracaoDocumento.LoadControles("BOLETIM MEDIÇÃO", _
                                                    "", _
                                                    txtSigla, _
                                                    txtNumeroCaracter, _
                                                    txtNumeroBoletimMedicao, _
                                                    cboFormato)

            'Seta Focu
            txtSigla.Focus()

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
            oClsCfgNumeracaoDocumento.Tipo = "BOLETIM MEDIÇÃO"
            oClsCfgNumeracaoDocumento.Tag = ""
            oClsCfgNumeracaoDocumento.Sigla = txtSigla.Text.Trim
            oClsCfgNumeracaoDocumento.NumeroCaracteres = txtNumeroCaracter.Value
            oClsCfgNumeracaoDocumento.NumeroDocumento = txtNumeroBoletimMedicao.Value
            oClsCfgNumeracaoDocumento.Formato = cboFormato.SelectedValue

            'Salva Dados
            oClsCfgNumeracaoDocumento.Save()

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

            'Verifica se foi Preenchido o Campo - Nº de Caracteres
            If ValidaCampo(txtNumeroCaracter, lblNumeroCaracter, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nº do Documento
            If ValidaCampo(txtNumeroBoletimMedicao, lblNumeroBoletimMedicao, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Formato
            If ValidaCampo(cboFormato, lblFormato) = False Then
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
