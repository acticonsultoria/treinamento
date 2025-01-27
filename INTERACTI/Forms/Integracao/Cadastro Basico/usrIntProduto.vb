Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrIntProduto

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsIntProduto As New clsUsrIntProduto

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrIntProduto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrIntProduto_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Redimensiona Usercontrol
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnExcelExemplo_Click(sender As Object, e As EventArgs) Handles btnExcelExemplo.Click

        Try

            Process.Start(ApplicationPath() & "\Integracao\produto.xlsx")

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controle
            txtArquivo.Text = ""
            'Carrega Arquivo
            Call LoadArquivo()

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

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Preenchido o Campo - Arquivo
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Verifica se o Arquivo Existe
            If File.Exists(txtArquivo.Text) = False Then
                frmMain.errInfo.SetError(lblArquivo, "O Arquivo informado não está acessivel ou não existe.")
                btnArquivo.Focus()
            End If

            'Importa Itens
            Call Importar()

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
            btnArquivo.Enabled = VerificaDireito(Formulario.IntegracaoImportarProduto, gcInsert)
            btnImportar.Enabled = VerificaDireito(Formulario.IntegracaoImportarProduto, gcInsert)

            'Seta Focu
            btnArquivo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadArquivo()

        Try

            'Váriaveis Locais
            Dim oArquivoExcel As New OpenFileDialog

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
            oArquivoExcel.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Seta Arquivo
                txtArquivo.Text = oArquivoExcel.FileName

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Importar()

        Try

            'Importar o Produto
            Call oClsIntProduto.ImportarProduto(pagDados, _
                                                txtArquivo.Text.Trim, _
                                                pgbImportacao, _
                                                chkCadastrarGrupoItem.Checked, _
                                                chkCadastrarUnidadeMedida.Checked, _
                                                chkCadastrarNCM.Checked, _
                                                chkAtualizarRegistro.Checked)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

