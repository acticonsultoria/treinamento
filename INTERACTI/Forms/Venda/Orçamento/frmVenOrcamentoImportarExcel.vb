Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmVenOrcamentoImportarExcel

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenOrcamento As New clsUsrVenOrcamento
    Private lCodigoOrcamento As Long
    Private iCodigoCliente As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoOrcamento() As Long
        Set(ByVal value As Long)
            lCodigoOrcamento = value
        End Set
    End Property

    Public WriteOnly Property CodigoCliente() As Integer
        Set(ByVal value As Integer)
            iCodigoCliente = value
        End Set
    End Property


#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoCancelarItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoCancelarItem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try
            ExecuteQuery("delete from tb_cmp_pedido_item_temp")

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoCancelarItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            ' Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

           
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub





#End Region
    Private Sub ImportarArquivoExcelTemp()

        Try
            frmMain.errInfo.Clear()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oApplicationClass As New Excel.ApplicationClass
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"
            oArquivoExcel.InitialDirectory = "c:\\"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Seta Controles
                txtArquivoExcel.Text = oArquivoExcel.FileName

                'Abre o Arquivo
                oApplicationClass.Workbooks.Open(oArquivoExcel.FileName.ToString())

                'Exclui os registros da tabela temporaria
                ExecuteQuery("sp_delete_integracao_estrutura_catia_temp " & goUsuario.iEmpresa)

                'Percorre Linha a Linha o Arquivo
                For i = 13 To oApplicationClass.Rows.Count

                    'Verifica se acabou os registros
                    If oApplicationClass.Range("B" & i).Value Is Nothing Then
                        Exit For
                    End If

                    If oApplicationClass.Range("B" & i).Value.ToString.Contains("Condições Gerais") Then
                        Exit For
                    End If

                    'If IsNumeric(oApplicationClass.Range("A" & i).Value) = False Then
                    '    Exit For
                    'End If

                    'Adiciona(Linha)
                    If oApplicationClass.Range("G" & i).Value > 0 And IsDBNull(oApplicationClass.Range("G" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("G" & i).Value, _
                                                             oApplicationClass.Range("G12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                    If oApplicationClass.Range("H" & i).Value > 0 And IsDBNull(oApplicationClass.Range("H" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("H" & i).Value, _
                                                             oApplicationClass.Range("H12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                    If oApplicationClass.Range("I" & i).Value > 0 And IsDBNull(oApplicationClass.Range("I" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("I" & i).Value, _
                                                             oApplicationClass.Range("I12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                    If oApplicationClass.Range("J" & i).Value > 0 And IsDBNull(oApplicationClass.Range("J" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("J" & i).Value, _
                                                             oApplicationClass.Range("J12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                    If oApplicationClass.Range("K" & i).Value > 0 And IsDBNull(oApplicationClass.Range("K" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("K" & i).Value, _
                                                             oApplicationClass.Range("K12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                    If oApplicationClass.Range("L" & i).Value > 0 And IsDBNull(oApplicationClass.Range("L" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("L" & i).Value, _
                                                             oApplicationClass.Range("L12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                    If oApplicationClass.Range("M" & i).Value > 0 And IsDBNull(oApplicationClass.Range("M" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("M" & i).Value, _
                                                             oApplicationClass.Range("M12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                    If oApplicationClass.Range("N" & i).Value > 0 And IsDBNull(oApplicationClass.Range("N" & i).Value) = False Then
                        oClsVenOrcamento.InsertItemExcelTemp(oApplicationClass.Range("B" & i).Value, _
                                                             oApplicationClass.Range("F" & i).Value.ToString.Replace("ROLO", "RL"), _
                                                             oApplicationClass.Range("N" & i).Value, _
                                                             oApplicationClass.Range("N12").Value, _
                                                             oApplicationClass.Range("O" & i).Value, _
                                                             dtpPrevisaoEntregaProduto.Value)

                    End If

                Next

                oClsVenOrcamento.LoadGridProdutoExcel(grdListagem)
                oApplicationClass.Workbooks.Close()
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnArquivoExcel_Click(sender As Object, e As EventArgs) Handles btnArquivoExcel.Click
        Try
            Call ImportarArquivoExcelTemp()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            ImportarArquivoExcel()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub ImportarArquivoExcel()

        Try
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            oClsVenOrcamento.InsertItemExcel(lCodigoOrcamento, iCodigoCliente, chkComNF.Checked, dtpPrevisaoEntregaProduto.Value)

            Me.Dispose()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    
End Class