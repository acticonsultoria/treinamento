Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl

Public Class usrEstModelo7

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstModelo7 As New clsUsrEstModelo7

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEstListagem_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp, _
 _
 _
                                                                                                                   txtCodigoProdutoFiltro.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                       
                            Call LoadGrid()

                    End If

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                 

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstListagem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    

    Private Sub usrEstListagem_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfiguracaoGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Me.Name
            'Abre Formulário
            ConfigureMaskEdit(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Me.Name)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Abre Formulário de Integração com Excel
            Dim oForm As New frmIntExportExcel
            oForm.Grid = IIf(tabDados.SelectedTab.Key = pagAnalitico.Key, grdListagem, grdSintetico)
            ConfigureMaskEdit(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

        
            'Configura Grid
            Call ConfiguraGrid(grdListagem, Me.Name)

            'Seleciona Aba
            tabMain.SelectedTab = pagListagem

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            Dim dData As Date = DateAdd(DateInterval.Day, -1, New Date(Year(dtpDataReferenciaFiltro.Value), Month(dtpDataReferenciaFiltro.Value), 1))
            dData = DateAdd(DateInterval.Month, 1, dData)
            'Carrega Grid 
            oClsEstModelo7.LoadGrid(grdListagem, _
                                    grdSintetico, _
                                    txtCodigoProdutoFiltro.Text.Trim, _
                                     dData)




            If chkGerarBlocoK.Checked = True Then

                Dim oFolderDialog As New FolderBrowserDialog



                If oFolderDialog.ShowDialog = vbOK Then

                    GerarBlocoK(oFolderDialog.SelectedPath & "/" & "BLOCOK_" & Format(dtpDataReferenciaFiltro.Value, "yyyy_MM_dd") & ".txt", CType(grdListagem.DataSource, DataSet).Tables(1))

                End If

            End If


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GerarBlocoK(ByVal sArquivo As String, _
                            ByVal oDataTable As DataTable)


        'Instancia o arquivo para escrita
        Dim oFile As New System.IO.StreamWriter(sArquivo, False, System.Text.Encoding.Default)
        Try


            For Each oDataRow As DataRow In oDataTable.Rows

                oFile.WriteLine(oDataRow(0))

            Next


            'Fecha o arquivo
            oFile.Close()


        Catch ex As Exception
            oFile.Close()
            Throw ex
        End Try
    End Sub
    

#End Region



End Class
