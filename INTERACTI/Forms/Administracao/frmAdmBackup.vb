Imports Janus.Windows.GridEX
Imports System.IO 
'Imports System.IO.Compression
Imports System.IO.Compression.FileSystem
Imports Ionic.Zip



Public Class frmAdmBackup

#Region "::: VARIAVES :::"

    Private oClsFrmAdmBackup As New clsFrmAdmBackup

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmAdmBackup_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasta.Click

        Try

            'Variavel Local
            Dim oFolder As New FolderBrowserDialog

            oFolder.Description = "Selecione a Pasta onde será feito o Backup"

            If oFolder.ShowDialog() = DialogResult.OK Then
                txtPasta.Text = oFolder.SelectedPath
                txtPasta.Text &= IIf(txtPasta.Text.EndsWith("\") = True, "", "\")
                btnExecutar.Enabled = VerificaDireito(Formulario.AdministracaoBackupDatabase, gcInsert)
            Else
                txtPasta.Text = ""
                btnExecutar.Enabled = False
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecutar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then
                'Executa o Backup
                Call Backup()
                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
            End If

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

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
 
    Private Sub Backup()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFrmAdmBackup.Path = txtPasta.Text

            Call oClsFrmAdmBackup.ValidaPasta()

            If (System.IO.Directory.Exists(oClsFrmAdmBackup.PastaArquivo) = False) Then

                MsgBox("Logue.", MsgBoxStyle.Information)

            Else

                If (oClsFrmAdmBackup.Mensagem = "NULL") Then

                    MsgBox("A pasta para backup precisa ser configurada.", MsgBoxStyle.Information)

                Else

                    'Executa o Backup
                    oClsFrmAdmBackup.Backup()

                    If (System.IO.File.Exists(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP") = True) Then

                        System.IO.File.Delete(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP")

                        Dim zip As New ZipFile(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP")

                        zip.AddFile(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK", "")
                        zip.Save()

                    Else

                        Dim zip As New ZipFile(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP")

                        zip.AddFile(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK", "")
                        zip.Save()

                    End If


                    If (System.IO.File.Exists(oClsFrmAdmBackup.Path + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP") = True) Then

                        System.IO.File.Delete(oClsFrmAdmBackup.Path + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP")

                        File.Copy(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP", oClsFrmAdmBackup.Path + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP")

                    Else

                        File.Copy(oClsFrmAdmBackup.PastaArquivo + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP", oClsFrmAdmBackup.Path + goDatabase.sInitialCatalog + "_" + Format(Now, "yyyyMMdd") + ".BAK.ZIP")

                    End If

                End If

            End If

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

            'Verifica se foi Preenchido o Campo - Pasta
            If ValidaCampo(txtPasta, lblPasta, TipoCampo.texto) = False Then
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