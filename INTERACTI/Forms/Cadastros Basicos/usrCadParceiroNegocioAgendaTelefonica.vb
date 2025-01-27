Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports Microsoft.Office.Interop
Public Class usrCadParceiroNegocioAgendaTelefonica

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio
    Private iCodigoParceiroNegocio As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadParceiroNegocioAgendaTelefonica_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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




    Private Sub usrCadParceiroNegocioContato_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CONTATO :::"

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

    
    Private Sub grdContato_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContato.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCliente, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdcontato.sizingcolumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCliente.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadParceiroNegocioAgendaTelefonica_KeyDown))



            'Configura Grid
            Call ConfiguraGrid(grdCliente, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)

            dtpDataInicioFiltro.Checked = False : dtpDataInicioFiltro.Value = New Date(Year(Now), Month(Now), 1)
            dtpDataTerminoFiltro.Checked = False : dtpDataTerminoFiltro.Value = Now

            cboTipoDataFiltro.Items.Add("DATA CADASTRO", "DATA CADASTRO")
            cboTipoDataFiltro.Items.Add("DATA ASCON", "DATA ASCON")
            cboTipoDataFiltro.Items.Add("DATA ANIVERSARIO", "DATA ANIVERSARIO")
            cboTipoDataFiltro.Items.Add("DATA ADMISSÃO", "DATA ADMISSÃO")


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region


#End Region
    Private Sub EmailContato()

        Try

            'Verifica se o Contato possui E-mail
            If IsDBNull(grdContato.CurrentRow.Cells("email").Value) = False And grdContato.CurrentRow.Cells("email").Value <> "" Then

                'Envia E-mail pelo Outlook
                Call SendEmailOutlook(grdContato.CurrentRow.Cells("email").Value, _
                                      "", _
                                      "", _
                                      "", _
                                      "", _
                                      "", _
                                      False, _
                                      "")

            Else
                'Informa o Usuário que o Contato não possui E-mail
                frmMain.Informacao("Contato não possui e-mail cadastrado!", Color.Red)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub LoadGrid()
        Try
            oClsCadParceiroNegocio.LoadGridAgendaTelefonica(grdCliente,
                                                            grdContato, _
                                                            txtRazaoSocialFiltro.Text, _
                                                            txtNomeContatoFiltro.Text, _
                                                            txtTelefoneContatoFiltro.Text, _
                                                            txtCelularContatoFiltro.Text, _
                                                            txtComplementoFiltro.Text, _
                                                            IIf(cboTipoDataFiltro.SelectedIndex = -1, "", cboTipoDataFiltro.SelectedValue), _
                                                            IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                                            IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""), _
                                                            txtNumeroClienteFiltro.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            Call LoadGrid()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub



    Private Sub grdContato_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdContato.RowDoubleClick
        Try
            Try

                'Verifica se a Coluna é Válida
                If IsNothing(grdContato.CurrentColumn) Then Exit Sub

                'Verifica o Tipo de Operação
                Select Case grdContato.CurrentColumn.Key

                    Case "inserir" : Call InserirContato(grdContato.CurrentRow.Cells("codigo_parceiro_negocio").Value, _
                                                        grdContato.CurrentRow.Cells("codigo_empresa").Value)
                    Case "enviar_mail" : Call EmailContato()


                End Select

            Catch ex As Exception
                'Trata Erro
                Call TratamentoErro(ex.Message, Me.Parent.Text)
            End Try
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub InserirContato(ByVal iCodigoParceiroNegocio As Integer, ByVal iCodigoEmpresa As Integer)
        Try

            If iCodigoEmpresa <> goUsuario.iEmpresa Then
                frmMain.Informacao("Cliente não pertence a empresa do login!", Color.Gray)
                Exit Sub
            End If
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True

            oForm.UsrControl = "usrCadParceiroNegocioContato"
            oForm.Titulo = "Contato"

            'Seta Parâmetros
            Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
            oFormularioCadastroBasico(0).oValor = "CODIGO:" & iCodigoParceiroNegocio : oFormularioCadastroBasico(0).sControle = "usrCadParceiroNegocioContato"
            oForm.CadastroBasico = oFormularioCadastroBasico

            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
            'oFormularioCadastroBasico(0).sControle = "usrCadParceiroNegocioContato"
            'oFormularioCadastroBasico(0).oValor = "CODIGO:" & iCodigoParceiroNegocio
            ''Abre Formulário de Cadastro
            ''Abre o Formulário
            'Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            grdCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnEmailCadastro_Click(sender As Object, e As EventArgs) Handles btnEmailCadastro.Click
        Try
            'Váriaveis Locais
            Dim oOutlookApplication As New Outlook.Application()
            Dim oMailItem As Outlook.MailItem

            For Each oRow In grdContato.GetCheckedRows

                'Cria E-mail
                oMailItem = oOutlookApplication.CreateItem(Outlook.OlItemType.olMailItem)

                'Carrega Dados
                oMailItem.Subject = "FELIZ ANIVERSÁRIO " & oRow.Cells.Item("nome").Value
                'oMailItem.To = oRow.Cells.Item("email").Value
                oMailItem.HTMLBody = "Feliz aniversário " & oRow.Cells.Item("nome").Value & "! No dia " & Format(oRow.Cells.Item("data_aniversario").Value, "dd/MM") & " você fez aniversário!"

                oMailItem.Display()

            Next

            
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnEmailCadastroASCON_Click(sender As Object, e As EventArgs) Handles btnEmailCadastroASCON.Click
        Try
            'Call EnviarCronograma()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnEnviarEmailAniversario_Click(sender As Object, e As EventArgs) Handles btnEnviarEmailAniversario.Click
        Try

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try

            If tabDados.SelectedTab.Name = pagCliente.Name Then
                ExportExcel(grdCliente)
            Else
                ExportExcel(grdContato)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub EnviarCronograma()
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim sErro As String = ""

                Dim sCorpo As String = ""
            sCorpo &= "<html><p>teste</p>" & _
                    "<img src='\\srvfs02\Aplicativos\SGA.NET\Email\AniversarioCompleto.html" & "'>"
               



                'Envia E-mail pelo Outlook
                Call SendEmailOutlook("julia.albuquerque@acticonsultoria.com.br", _
                                      "", _
                                      "", _
                                      "teste", _
                                      sCorpo, _
                                      "", _
                                      False,
                                      "")





            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw ex
        End Try
    End Sub
End Class

