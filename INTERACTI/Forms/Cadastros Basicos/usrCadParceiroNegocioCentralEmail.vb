Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common

Public Class usrCadParceiroNegocioCentralEmail

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocioCentralEmail As New clsUsrCadParceiroNegocioCentralEmail
    Private iCodigoParceiroNegocioCentralEmail As Integer
    Private sVetor() As String

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadParceiroNegocioCentralEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        
        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadParceiroNegocioCentralEmail_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CONTATO :::"

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        'Váriaveis Locais
        Dim oArquivoExcel As New OpenFileDialog

        oArquivoExcel.Multiselect = True

        'Seta Dados do OpenFileDialog
        oArquivoExcel.InitialDirectory = "c:\\DADOS"

        'Verifica se foi Selecionado algum Arquivo
        If oArquivoExcel.ShowDialog = DialogResult.OK Then

            For Each arquivo As String In oArquivoExcel.FileNames

                txtArquivo.Text += arquivo & ";" & vbNewLine

            Next

        End If

    End Sub

    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click

        Try

            Call Email()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
     
    Private Sub btnAgruparGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContato.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContato.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContato.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContato.GroupByBoxVisible = True
                grdContato.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContato.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContato
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocioCentralEmail
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocioCentralEmail)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContato.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContato)

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
     
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadParceiroNegocioCentralEmail_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvarContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioCentralEmail, gcInsert)
            btnExcluirContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioCentralEmail, gcDelete)
            btnExcelGridContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioCentralEmail, gcPrint)

            'Verifica Direito - Botão de Cadastrar
            btnCadastrarTipoContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoContato, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboTipoEmail, "sp_select_combo_static_email")
            Call LoadCombo(cboEmpresa, "sp_select_combo_cadastro_basico_empresa")

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)

            'Seta Focu
            cboTipoContato.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTATO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
             
            'Seta Parametros
            oClsCadParceiroNegocioCentralEmail.LoadGrid(grdListagem, _
                                                        IIf(cboTipoEmail.SelectedIndex = -1, -1, cboTipoEmail.SelectedValue), _
                                                        IIf(cboEmpresa.SelectedIndex = -1, -1, cboEmpresa.SelectedValue), _
                                                        txtCliente.Text.Trim, _
                                                        txtContato.Text.Trim)
             
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
     
    Private Sub Email()

        Try

            'Verifica se o Contato possui E-mail
            If IsDBNull(grdListagem.CurrentRow.Cells("email").Value) = False Then

                Dim sVetorLinha() As String
                Dim i As Integer = -1
                Dim sAnexo As String = ""
                Dim sEmail As String = ""

                For Each oRow In grdListagem.GetCheckedRows  
                    sEmail += CStr(oRow.Cells.Item("email").Value) + ";"
                Next

                sVetorLinha = txtArquivo.Text.Split(";")

                For iLinha As Integer = 0 To sVetorLinha.Count - 1
                    i = i + 1
                    sAnexo = sAnexo + sVetorLinha(i) + ";"
                Next

                sAnexo = Mid(sAnexo, 1, Len(sAnexo) - 3) 

                'Enviar E-mail
                Call EnviarEmail("Assunto", _
                                 sEmail, _
                                 "", _
                                 sAnexo, _
                                 "Mensagem", _
                                 -1)

            Else
                'Informa o Usuário que o Contato não possui E-mail
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
     
#End Region

#End Region
     
End Class

