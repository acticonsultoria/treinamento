Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports Janus.Windows.GridEX

Public Class usrCadNCMListaCAMEX

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadNCMListaCAMEX As New clsUsrCadNCMListaCAMEX
    Private oRow As New Hashtable

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadNCMListaCAMEX_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadNCMListaCAMEX_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: LISTA CAMEX :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoListaCAMEX
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoListaCAMEX)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Salva Dados do Registro
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoListaCAMEX)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoListaCAMEX, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnArquivoExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoExcel.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Código NCM
            If ValidaCampo(cboConfiguracaoColunaCodigoNCM, lblConfiguracaoColunaCodigoNCM) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Descrição
            If ValidaCampo(cboConfiguracaoColunaDescricao, lblConfiguracaoColunaDescricao) = False Then
                Exit Sub
            End If

            'Atualiza Dados
            oClsCadNCMListaCAMEX.UpdateConfiguracaoArquivoExcel(cboConfiguracaoColunaCodigoNCM.Text, _
                                                                cboConfiguracaoColunaDescricao.Text)

            'Importa Arquivo Excel
            Call ImportarArquivoExcel()

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

            'Verifica Direito
            btnArquivoExcel.Enabled = VerificaDireito(Formulario.CadastroBasicoListaCAMEX, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoListaCAMEX, gcInsert)

            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboConfiguracaoColunaCodigoNCM : oComboBox(1) = cboConfiguracaoColunaDescricao
            Call LoadComboAZ(oComboBox)

            'Carrega Configuração do Arquivo
            oClsCadNCMListaCAMEX.LoadConfiguracaoArquivoExcel(cboConfiguracaoColunaCodigoNCM, _
                                                              cboConfiguracaoColunaDescricao)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueLocalizacao)

            'Seta Focu
            cboConfiguracaoColunaCodigoNCM.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: LISTA CAMEX :::"

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Exclui Lista da CAMEX
            oClsCadNCMListaCAMEX.Delete()

            'Salva Dados da Lista do CAMEX
            oClsCadNCMListaCAMEX.Save(grdListagem)

            'Limpa Registros
            txtArquivoExcel.Text = ""
            grdListagem.DataSource = Nothing

            'Informa o usuário sobre o sucesso da operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub ImportarArquivoExcel()

        Try

            'Váriaveis Locais
            Dim oApplicationClass As New Excel.Application
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
            oArquivoExcel.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Limpa Grid
                grdListagem.DataSource = Nothing

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDataRow As DataRow
                Dim oDCCodigoNCM As New DataColumn("codigo_ncm")
                Dim oDCDescricao As New DataColumn("descricao")
                Dim iContador As Integer = 0

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCodigoNCM)
                oDataTable.Columns.Add(oDCDescricao)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Try

                    'Seta Controles
                    txtArquivoExcel.Text = oArquivoExcel.FileName

                    'Abre o Arquivo
                    oApplicationClass.Workbooks.Open(oArquivoExcel.FileName)

                    'Percorre Linha a Linha o Arquivo
                    For i = 1 To oApplicationClass.Rows.Count

                        'Verifica se acabou os registros
                        If Not oApplicationClass.Range(cboConfiguracaoColunaCodigoNCM.Text & i).Value Is Nothing Then

                            'Verifica o Código NCM
                            If IsNumeric(oApplicationClass.Range(cboConfiguracaoColunaCodigoNCM.Text & i).Value.ToString.Replace(".", "")) Then

                                'Adiciona Linhas ao DataTable
                                oDataRow = oDataTable.NewRow
                                oDataRow("codigo_ncm") = oApplicationClass.Range(cboConfiguracaoColunaCodigoNCM.Text & i).Value
                                oDataRow("descricao") = oApplicationClass.Range(cboConfiguracaoColunaDescricao.Text & i).Value.ToString.Trim.ToUpper
                                oDataTable.Rows.Add(oDataRow)

                            End If

                        Else

                            'Seta Contador
                            iContador += 1

                            'Verifica quantidade de Registros
                            If iContador > 20 Then
                                Exit For
                            End If

                        End If

                    Next i

                    'Preenche Grid
                    With grdListagem

                        .RootTable.Columns.Item("codigo_ncm").DataMember = "codigo_ncm"
                        .RootTable.Columns.Item("descricao").DataMember = "descricao"

                        .DataSource = oDataSet.DefaultViewManager
                        .DataMember = oDataSet.Tables(0).TableName

                    End With

                Catch ex As Exception
                    Throw ex
                Finally
                    'Limpa váriavel
                    oApplicationClass.Workbooks.Close()
                    oApplicationClass = Nothing
                End Try

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
