Imports Janus.Windows.GridEX

Public Class frmFatEmissaoNFeDI

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEmissaoNFePedidoVenda As New clsFrmFatEmissaoNFePedidoVenda
    Private lCodigoEmissaoCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEmissaoNFePedidoVenda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarForm()

    End Sub

    Private Sub frmFatEmissaoNFePedidoVenda_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + gcFormAjust)
        Me.Left = (frmMain.tabMain.Left + ((frmMain.tabMain.Width - Me.Width) / 2))

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnImportarPedidoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoVenda.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Importar Pedido de Venda
                ImportarPedidoVenda()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboPedidoVenda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Carrega Grid
        Call LoadGridPedidoVenda()

    End Sub

    Private Sub grdListagem_RowCheckStateChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs)

        Try

            'Verifica se foi selecionado a Linha
            If e.ChangeType = CheckStateChangeType.RowChange Then
                'Verifica se o campo possui regra de venda
                If IsDBNull(e.Row.Cells("codigo_regra_venda").Value) And e.CheckState = RowCheckState.Checked Then
                    'Informa o Usuário que o Item não possui a Regra de Venda
                    MsgBox("Este Item não possui Regra de Venda cadastrada." & vbCrLf & vbCrLf & "Contate o Administrador do Sistema.", MsgBoxStyle.Critical, Me.Text)
                    e.Cancel = True
                    Exit Sub
                End If
            End If

            If e.ChangeType = CheckStateChangeType.ColumnHeaderChange Then
                'Váriaveis Locais
                Dim oRow As GridEXRow
                For Each oRow In grdListagem.GetDataRows
                    If IsDBNull(oRow.Cells("codigo_regra_venda").Value) = True Then
                        'Informa o Usuário que o Item não possui a Regra de Venda
                        MsgBox("Algum(ns) Item(ns) não possui Regra de Venda cadastrada." & vbCrLf & vbCrLf & "Contate o Administrador do Sistema.", MsgBoxStyle.Critical, Me.Text)
                        e.Cancel = True
                        Exit Sub
                    End If
                Next
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs)

        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "regra_venda" : Call CadastrarRegraVenda()

            End Select

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

            'Carrega Combo de Cliente
            Call LoadCombo(cboPedidoVenda, "sp_select_combo_venda_pedido " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CadastrarRegraVenda()

        Try

            'Váriavel - Formulário de Cadastro de Regra de Venda
            Dim oForm As New frmImpRegraVenda

            'Carrega Controles
            oForm.ConfigurarUserControl()
            'Seta Parâmetros
            oForm.cboOrigemItem.SelectedValue = grdListagem.CurrentRow.Cells("codigo_origem_item").Value
            oForm.cboNCM.SelectedValue = grdListagem.CurrentRow.Cells("codigo_ncm").Value
            oForm.cboPersonalidade.SelectedValue = grdListagem.CurrentRow.Cells("codigo_personalidade").Value
            oForm.cboDestinacao.SelectedValue = grdListagem.CurrentRow.Cells("codigo_destinacao").Value
            oForm.cboUFDestino.SelectedValue = grdListagem.CurrentRow.Cells("uf_destino").Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Recarrega a Grid
            Call LoadGridPedidoVenda()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarPedidoVenda()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Importa Pedido de Venda
            oClsFatEmissaoNFePedidoVenda.ImportarPedidoVenda(lCodigoEmissaoCapa, _
                                                             txtCliente.Tag, _
                                                             cboPedidoVenda.SelectedValue, _
                                                             grdListagem.GetCheckedRows)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao("Pedido de Venda Importado com Sucesso!!!", gColorInformacaoOK)

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPedidoVenda()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado algum Cliente
            If cboPedidoVenda.SelectedIndex = -1 Then
                'Limpa Grid
                grdListagem.DataSource = Nothing
                txtCliente.Text = ""
                txtCNPJCPF.Text = ""
                lblCNPJCPF.Text = "CNPJ:"
            Else
                'Carrega Grid de Pedido de Venda
                oClsFatEmissaoNFePedidoVenda.LoadGridPedidoVenda(grdListagem, _
                                                                 cboPedidoVenda.SelectedValue)
                'Carrega Dados do Parceiro de Negócio
                Call LoadDadosParceiroNegocioVenda(cboPedidoVenda.SelectedValue, _
                                                   txtCliente, _
                                                   txtCNPJCPF, _
                                                   lblCNPJCPF)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(cboPedidoVenda, lblNumeroDI) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado algum Orçamento
            If VerificaSelecaoRow(grdListagem) = False Then
                frmMain.Informacao("Primeiramente Selecione um ou mais Pedidos de Venda.", gColorInformacaoErro)
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