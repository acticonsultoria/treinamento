Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmCmpPedidoImportarExcel

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private sNumeros As String = ""

#End Region

#Region "::: PROPERTIE :::"
    Public Property Numeros() As String
        Get
            Return sNumeros
        End Get
        Set(ByVal value As String)
            sNumeros = value
        End Set
    End Property

    Public WriteOnly Property CodigoPedido() As Long
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public WriteOnly Property CodigoPedidoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoPedidoItem = value
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

            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)

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



                'Percorre Linha a Linha o Arquivo
                For i = 2 To oApplicationClass.Rows.Count

                    'Verifica se acabou os registros
                    If oApplicationClass.Range("A" & i).Value Is Nothing Then
                        Exit For
                    End If

                    'If IsNumeric(oApplicationClass.Range("A" & i).Value) = False Then
                    '    Exit For
                    'End If

                    'Adiciona(Linha)
                    oClsCmpPedido.InsertItemExcelTemp(IIf(IsNumeric(oApplicationClass.Range("A" & i).Value), oApplicationClass.Range("A" & i).Value, -1), _
                                                oApplicationClass.Range("B" & i).Value, _
                                                oApplicationClass.Range("C" & i).Value, _
                                                oApplicationClass.Range("D" & i).Value, _
                                                oApplicationClass.Range("E" & i).Value, _
                                                oApplicationClass.Range("F" & i).Value)

                Next

                oClsCmpPedido.LoadGridProdutoExcel(grdListagem)
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

            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then Exit Sub

            oClsCmpPedido.InsertItemExcel(cboFornecedor.SelectedValue, sNumeros)

            Me.Dispose()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class