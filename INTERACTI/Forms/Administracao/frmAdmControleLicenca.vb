Imports Janus.Windows.GridEX
Imports System.IO

Public Class frmAdmControleLicenca

#Region "::: VARIAVES :::"

    Private oClsFrmAdmLicenca As New clsFrmAdmControleLicenca

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmAdmControleLicenca_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Variavel Local
            Dim arqImagem As New OpenFileDialog

            arqImagem.InitialDirectory = "c:\\dados"
            arqImagem.Filter = "(Interacti - Arquivo de Lincença)|*.ACTi"
            arqImagem.Title = "Selecione o Arquivo de Lincença"

            If arqImagem.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqImagem.FileName
            End If

            'Carrega Licença
            Call OpenLicenca(txtArquivo.Text)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Atualiza Licença
            Call AtualizaLicenca()

            Dim oDirectoryInfo As New DirectoryInfo(ApplicationPath() & "Temp\")
            Dim oFileInfo As FileInfo
            Dim oFileInfoOld As FileInfo

            For Each oFileInfo In oDirectoryInfo.GetFiles
                If oFileInfo.Name <> "licença.acti" Then
                    If File.Exists(ApplicationPath() & "XmlConfig\" & oFileInfo.Name) Then
                        oFileInfoOld = New FileInfo(ApplicationPath() & "XmlConfig\" & oFileInfo.Name)
                        oFileInfoOld.Delete()
                    End If
                    oFileInfo.CopyTo(ApplicationPath() & "XmlConfig\" & oFileInfo.Name)
                    oFileInfo.Delete()
                End If
            Next

            'Atualiza Pagina
            frmMain.picImage.Image = New Bitmap(ApplicationPath() & "XMLConfig\logo.bmp")

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Controles
            txtDataExpiracao.Text = goUsuario.sDataValidade
            txtNumeroLicenca.Text = IIf(goUsuario.iNumeroLicenca = 0, "ILIMITADO", goUsuario.iNumeroLicenca)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub OpenLicenca(ByVal sFilename As String)

        Try

            Dim oStreamReader As StreamReader
            Dim sLinha() As String

            If File.Exists(sFilename) Then
                oStreamReader = New StreamReader(sFilename)
                sLinha = oStreamReader.ReadLine.Split("|")

                txtDataExpiracaoNovo.Tag = Descriptografar16(sLinha(FormatoArquivoLicenca.DataValidacao), gcKey & goUsuario.sCNPJEmpresa)
                txtDataExpiracaoNovo.Text = Descriptografar16(sLinha(FormatoArquivoLicenca.DataValidade), gcKey & goUsuario.sCNPJEmpresa)
                txtNumeroLicencaNovo.Tag = Descriptografar16(sLinha(FormatoArquivoLicenca.NumeroLicenca), gcKey & goUsuario.sCNPJEmpresa)
                txtNumeroLicencaNovo.Text = IIf(txtNumeroLicencaNovo.Tag = "0", "ILIMITADO", txtNumeroLicencaNovo.Tag)

                'Informa o Usuário sobre o Erro
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Habilita Controle
                btnConfirmar.Enabled = True

                'Fecha StreamReader
                oStreamReader.Close()

            Else
                'Informa o Usuário sobre o Erro
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub AtualizaLicenca()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsFrmAdmLicenca.DataValidacao = Criptografar16(Now.Date, gcKey & goUsuario.sCNPJEmpresa)
            oClsFrmAdmLicenca.DataValidade = Criptografar16(txtDataExpiracaoNovo.Text, gcKey & goUsuario.sCNPJEmpresa)
            oClsFrmAdmLicenca.NumeroLicenca = Criptografar16(txtNumeroLicencaNovo.Tag, gcKey & goUsuario.sCNPJEmpresa)
            oClsFrmAdmLicenca.Tipo = TipoControleLicenca.Interacti
            oClsFrmAdmLicenca.Update()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            goUsuario.sDataValidacao = Now.Date
            goUsuario.sDataValidade = txtDataExpiracaoNovo.Text
            goUsuario.sDataUltimoAcesso = Now.Date
            goUsuario.iNumeroLicenca = txtNumeroLicencaNovo.Tag

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class