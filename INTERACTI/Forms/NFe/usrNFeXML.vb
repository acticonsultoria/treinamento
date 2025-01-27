Imports Janus.Windows.GridEX
Imports Ionic.Zip
Imports System.IO

Public Class usrNFeXML

#Region "::: VÁRIAVEIS :::"

    'Váriaveis da Classe
    Private oClsUsrFatEmissaoNFeXML As New clsUsrFatEmissaoNFeXML

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrNFeXML_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnGerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarXML.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Gera Arquivo XML
                Call ExportarArquivo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEmailXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailXML.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Váriaveis Locais
                Dim sFileZip As String = ExportarArquivoEmail()

                If sFileZip <> "" Then

                    'Enviar E-mail
                    Call EnviarEmail("Arquivo XML NF-e", _
                                     "", _
                                     sFileZip, _
                                     sFileZip, _
                                     "", _
                                     -1)

                End If

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

            'Verifica se foi selecionado algum modelo
            If cboModelo.SelectedIndex = -1 Then
                'Limpa Controles
                cboSerie.DataSource = Nothing
                cboSerie.Text = ""
            Else
                'Carrega Combo - Série
                Call LoadCombo(cboSerie, "sp_select_combo_configuracao_serie_nota_fiscal " & goUsuario.iEmpresa & ", " & cboModelo.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid() Handles cboSerie.SelectedIndexChanged, _
                                   cboModelo.SelectedIndexChanged, _
                                   dtpDataEmissaoInicioFiltro.ValueChanged, _
                                   dtpDataEmissaoInicioFiltro.CheckedChanged, _
                                   dtpDataEmissaoTerminoFiltro.ValueChanged, _
                                   dtpDataEmissaoTerminoFiltro.CheckedChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboModelo.SelectedIndex > -1 Then

                'Carrega Grid
                oClsUsrFatEmissaoNFeXML.LoadGrid(grdListagem, _
                                                 cboModelo.SelectedValue, _
                                                 IIf(cboSerie.SelectedIndex = -1, -1, cboSerie.Text), _
                                                 IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                                 IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""))

            Else

                'Limpa Grid
                grdListagem.DataSource = Nothing

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

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call LoadConfiguracaoNFe()

            'Verifica Direito
            btnGerarXML.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFeGerarXML, gcInsert)
            btnEmailXML.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFeGerarXML, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboModelo, "sp_select_combo_static_modelo_nota_fiscal " & CInt(TipoItem.produto))

            'Configura a Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFeGerarXML)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False

            'Seta Focu
            cboModelo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ExportarArquivo()

        Try

            'Váriaveis Locais 
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sArquivoEnvio As String = ""
            Dim sMensagemErro As String = ""
            Dim sArquivoNFe As String = ""
            Dim sArquivoProtocoloNFe As String = ""
            Dim sArquivoCancelamentoNFe As String = ""
            Dim sArquivoProtocoloCancelamentoNFe As String = ""
            Dim sNotaFiscal As String = ""
            Dim sChaveAcesso As String = ""
            Dim i As Integer
            Dim bErro As Boolean = False
            Dim sPath As String = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oSaveFolder As New FolderBrowserDialog

            If oSaveFolder.ShowDialog() = DialogResult.OK Then

                sPath = oSaveFolder.SelectedPath

                For i = 0 To UBound(gSelecaoRow)

                    'Carrega Dados da Nota Fiscal
                    oClsUsrFatEmissaoNFeXML.LoadDadosNFe(gSelecaoRow(i).Cells("codigo").Value, _
                                                         sArquivoNFe, _
                                                         sArquivoProtocoloNFe, _
                                                         sArquivoCancelamentoNFe, _
                                                         sArquivoProtocoloCancelamentoNFe, _
                                                         sChaveAcesso, _
                                                         sNotaFiscal)

                    'Verifica se foi possível gerar o Arquivo
                    If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                      sArquivoProtocoloNFe, _ 
                                                      sChaveAcesso, _
                                                      sPath & "\" & sChaveAcesso & "-nfe.xml", _
                                                      sMensagemErro) = False Then

                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                        bErro = True
                        Exit For

                    End If

                Next

                'Informa o usuário sobre o Sucesso da Operação
                If bErro = False Then
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ExportarArquivoEmail() As String

        Try

            'Váriaveis Locais
            Dim oClsNFeArquivoEnvio As New clsNFeArquivoEnvio_V4
            Dim sArquivoEnvio As String = ""
            Dim sMensagemErro As String = ""
            Dim sArquivoNFe As String = ""
            Dim sArquivoProtocoloNFe As String = ""
            Dim sArquivoCancelamentoNFe As String = ""
            Dim sArquivoProtocoloCancelamentoNFe As String = ""
            Dim sNotaFiscal As String = ""
            Dim sChaveAcesso As String = ""
            Dim i As Integer
            Dim bErro As Boolean = False
            Dim sPath As String = ""
            Dim sFileZip As String = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            sPath = ApplicationPath() & "Temp\XML"

            If Directory.Exists(sPath) Then
                Dim sFile() As String
                sFile = Directory.GetFiles(sPath)
                For i = 0 To UBound(sFile)
                    File.Delete(sFile(i))
                Next
                Directory.Delete(sPath)
            End If

            Directory.CreateDirectory(sPath)

            For i = 0 To UBound(gSelecaoRow)

                'Carrega Dados da Nota Fiscal
                oClsUsrFatEmissaoNFeXML.LoadDadosNFe(gSelecaoRow(i).Cells("codigo").Value, _
                                                     sArquivoNFe, _
                                                     sArquivoProtocoloNFe, _
                                                     sArquivoCancelamentoNFe, _
                                                     sArquivoProtocoloCancelamentoNFe, _
                                                     sChaveAcesso, _
                                                     sNotaFiscal)

                'Verifica se foi possível gerar o Arquivo
                If oClsNFeArquivoEnvio.ArquivoNFe(sArquivoNFe, _
                                                  sArquivoProtocoloNFe, _ 
                                                  sChaveAcesso, _
                                                  sPath & "\" & sChaveAcesso & "-nfe.xml", _
                                                  sMensagemErro) = False Then

                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                    bErro = True
                    Exit For

                End If

            Next

            'Informa o usuário sobre o Sucesso da Operação
            If bErro = False Then
                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
                sFileZip = ApplicationPath() & "\Temp\nfe.zip"
                If File.Exists(sFileZip) Then
                    File.Delete(sFileZip)
                End If
                Using oZip As New ZipFile(sFileZip)
                    oZip.AddDirectory(sPath)
                    oZip.Save()
                End Using
            Else
                'Informa o Usuário sobre o Insucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Retorno da Função
            Return sFileZip

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
            Return ""
        End Try

    End Function

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Modelo
            If ValidaCampo(cboModelo, lblModelo) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado algum Registro
            If VerificaSelecaoRow(grdListagem) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
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
