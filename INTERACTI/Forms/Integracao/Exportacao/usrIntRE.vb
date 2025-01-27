Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO
Imports INTERACTI.clsUsrIntImportacaoItem
Imports INTERACTI.NFe.ValidaXML

Public Class usrIntRE

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsIntImportacaoNFe As New clsUsrIntImportacaoNFe
    Private oLayout As New Hashtable
    Private oImportacao As Importacao

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrIntImportacaoNFe_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrIntImportacaoNFe_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Redimensiona Usercontrol
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnPasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasta.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado Campo - Integracao
            If ValidaCampo(cboIntegracao, lblIntegracao) = False Then
                Exit Sub
            End If

            'Limpa Controle
            txtPasta.Text = ""
            'Carrega Arquivo
            Call LoadArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        'Prepara o Formulário para Inserção de um Novo Registro
        Call Novo()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

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
            btnPasta.Enabled = VerificaDireito(Formulario.IntegracaoImportarNFe, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.IntegracaoImportarNFe, gcInsert)

            'Carrega Combo
            Call LoadComboSimNao(cboIntegracao)

            'Seta Focu
            btnPasta.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Arquivo
            If txtPasta.Text = "" Then
                'Váriaveis Locais
                Dim oFolder As New FolderBrowserDialog
                'Verifica se foi Selecionado algum Arquivo
                If oFolder.ShowDialog = DialogResult.OK Then
                    txtPasta.Text = oFolder.SelectedPath
                End If
                'Desabilita FolderDialog
                oFolder.Dispose()
            End If

            'Verifica se foi selecionado alguma Pasta
            If txtPasta.Text <> "" Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Limpa Grid
                grdArquivo.DataSource = Nothing

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCArquivo As New DataColumn("arquivo")

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCArquivo)

                Dim sFile As String

                For Each sFile In Directory.GetFiles(txtPasta.Text)
                    If sFile.Contains(".txt") Then
                        Dim oDataRow As DataRow = oDataTable.NewRow
                        oDataRow("arquivo") = sFile
                        oDataTable.Rows.Add(oDataRow)
                    End If
                Next

                'Preenche Grid
                With grdArquivo

                    .RootTable.Columns.Item("arquivo").DataMember = "arquivo"

                    .DataSource = oDataSet.DefaultViewManager
                    .DataMember = oDataSet.Tables(0).TableName

                End With

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtPasta.Text = ""
            grdArquivo.DataSource = Nothing

            'Seta Focu
            btnPasta.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Importar()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Váriaveis
                Dim oRow As GridEXRow
                Dim oTexto As StreamReader
                Dim sTexto As String
                Dim sArquivosNaoImportados As String = ""
                Dim sDDE As String
                Dim sRE As String
                Dim sNotaFiscal As String
                Dim sCNPJ As String
                Dim sDataEmissao As String

                For Each oRow In gSelecaoRow

                    'Verifica se o Arquivo Existe
                    If System.IO.File.Exists(oRow.Cells("arquivo").Value) Then

                        Try

                            sDDE = ""
                            sRE = ""
                            sNotaFiscal = ""
                            sCNPJ = ""
                            sDataEmissao = ""

                            oTexto = New StreamReader(oRow.Cells("arquivo").Value.ToString)
                            sTexto = oTexto.ReadToEnd

                            sDDE = sTexto.Substring(sTexto.IndexOf("DECLARACAO DE DESPACHO NRO.: ") + Len("DECLARACAO DE DESPACHO NRO.: "), 12)
                            sRE = sTexto.Substring(sTexto.IndexOf("RELACAO DE R.E. DO DESPACHO:") + Len("RELACAO DE R.E. DO DESPACHO:"), sTexto.IndexOf("RELACAO DE NOTA") - sTexto.IndexOf("RELACAO DE R.E. DO DESPACHO:") - Len("RELACAO DE R.E. DO DESPACHO:")).Trim
                            sDataEmissao = sTexto.Substring(sTexto.IndexOf("SISCOMEX - EXPORTACAO                                        ") + Len("SISCOMEX - EXPORTACAO                                        "), 10).Trim
                            sNotaFiscal = sTexto.Substring(sTexto.IndexOf("RELACAO DE NOTAS FISCAIS POR ESTABELECIMENTO:") + Len("RELACAO DE NOTAS FISCAIS POR ESTABELECIMENTO:"), sTexto.IndexOf("VOLUMES POR ESPECIE") - sTexto.IndexOf("RELACAO DE NOTAS FISCAIS POR ESTABELECIMENTO:") - Len("RELACAO DE NOTAS FISCAIS POR ESTABELECIMENTO:")).Trim
                            sCNPJ = sNotaFiscal.Substring(sNotaFiscal.IndexOf("ESTABELECIMENTO: ") + Len("ESTABELECIMENTO: "), 18)
                            sNotaFiscal = sNotaFiscal.Replace("ESTABELECIMENTO: " & sCNPJ, "").Trim
                            ExecuteQuery("UPDATE tb_exportacao SET data = '" & sDataEmissao & "' WHERE dde = '" & sDDE & "';")
                            'ExecuteQuery("INSERT INTO tb_exportacao(dde, re, nota_fiscal, cnpj, arquivo) VALUES ('" & sDDE & "', '" & sRE & "', '" & sNotaFiscal & "', '" & sCNPJ & "', '" & oRow.Cells("arquivo").Value & "')")

                        Catch ex As Exception
                            sArquivosNaoImportados &= IIf(sArquivosNaoImportados = "", "", vbCrLf) & oRow.Cells("arquivo").Value.ToString.Replace(txtPasta.Text.Trim & "\", "")
                        Finally
                            oTexto.Close()
                        End Try

                    End If

                Next

                'Informa o Usuário sobre o Sucesso da Operação
                MsgBox(IIf(sArquivosNaoImportados = "", "Notas Fiscais Importadas com Sucesso!", "Notas Fiscais não importadas:" & vbCrLf & vbCrLf & sArquivosNaoImportados), MsgBoxStyle.Information, Me.Parent.Text)

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Integracao(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Verifica se vai efetuar a Integração - Financeiro / Estoque
            If cboIntegracao.SelectedValue = True Then
                'Salva Movimentação - Estoque
                oClsIntegracao.IntegracaoNFEmissaoEstoque(lCodigoEmissaoCapa)
                'Salva Financeiro - Financeiro
                oClsIntegracao.IntegracaoNFEmissaoFinanceiro(lCodigoEmissaoCapa)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

