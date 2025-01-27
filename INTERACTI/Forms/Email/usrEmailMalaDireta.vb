Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrEmailMalaDireta

#Region "::: CONTROLES :::"

    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEmailMalaDireta_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTextoEmail.Click

        Try

             'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTextoEmail")

            'Carrega Combo
            Call LoadCombo(cboEmail, "follow " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboEmail.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click

        Try

            'Valida Dados do E-mail
            If Validacao() = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis Locais
                Dim oRow As GridEXRow
                Dim sAnexo() As String

                'Obtem Parâmetros
                If txtAnexo.Tag <> "" Then
                    sAnexo = txtAnexo.Tag.Replace(";", ",").Split(",")
                Else
                    ReDim sAnexo(0)
                    sAnexo(0) = ""
                End If

                'Configura Progressbar
                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = grdListagem.GetCheckedRows.Count
                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                'Envia E-mail
                For Each oRow In grdListagem.GetCheckedRows

                    Try

                        'Envia E-mail
                        Call SendEmail(oRow.Cells("email").Value, _
                                       "", _
                                       "", _
                                       txtAssunto.Text, _
                                       txtBody.Text, _
                                       sAnexo)

                        'Seta Valor Progressbar
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 0

                    Catch ex As Exception
                    End Try

                    'Executa Tarefas pendentes do Sistema
                    Application.DoEvents()

                Next

                'Oculta Progressbar
                frmMain.stbMain.Panels("pnlProgressBar").Visible = False

                'Informa o Usuário do sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Limpa Controles
                txtAnexo.Text = "" : txtAnexo.Tag = ""
                txtAssunto.Text = ""
                cboEmail.SelectedIndex = -1
                txtBody.Text = ""

                'Carrega Lista de Parceiro de Negócio
                oClsCadParceiroNegocio.LoadGridEmail(grdListagem)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnexo.Click

        Try

            'Variaveis Locais
            Dim oFile As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            oFile.InitialDirectory = "c:\\dados"
            oFile.Title = "Selecione o Arquivo"

            If oFile.ShowDialog() = DialogResult.OK Then
                txtAnexo.Text = txtAnexo.Text & IIf(txtAnexo.Text = "", "", "; ") & oFile.FileName
                txtAnexo.Tag = txtAnexo.Tag & IIf(txtAnexo.Tag = "", "", "; ") & oFile.FileName
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

    Private Sub cboEmail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmail.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum E-mail
            If cboEmail.SelectedIndex > -1 Then
                'Preenche Controle
                LoadDescricao(txtBody, "sp_select_cadastro_basico_texto_email_texto " & cboEmail.SelectedValue & ", " & goUsuario.iEmpresa & ",'" & goUsuario.sNome & "'")
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
            btnEnviar.Enabled = VerificaDireito(Formulario.InteraciMalaDireta, gcInsert)

            'Carrega Lista de Parceiro de Negócio
            oClsCadParceiroNegocio.LoadGridEmail(grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoMalaDireta)

            'Carrega Combo
            Call LoadCombo(cboEmail, "sp_select_combo_cadastro_basico_texto_email " & goUsuario.iEmpresa & ", " & TipoEmailDestino.MalaDireta, False)

            'Seta Controle
            txtAnexo.Tag = ""

            'Seta Focu
            txtAssunto.Focus()

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

            'Carrega Configuração do E-mail
            Call LoadConfiguracaoEmail()

            'Verifica se foi Selecionado Algum Registro
            If grdListagem.GetCheckedRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Verifica se o E-mail foi configurado
            If goEmail.sEmail = "" Then
                MsgBox("Você não possui E-mail configurado. Contate o Administrador do sistema.", vbInformation, Me.Parent.Text)
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Assunto
            If ValidaCampo(txtAssunto, lblAssunto, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Texto
            If txtBody.Text.Trim = "" Then
                If MsgBox("Confirma o envio do e-mail sem texto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class


