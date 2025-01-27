Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrDshWorkflow

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsDshWorkflow As New clsUsrDshWorkflow

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrDshWorkflow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3

                Case Keys.F5

                Case Keys.Oemplus, Keys.Add

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrDshWorkflow_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CAIXA DE ENTRADA :::"

    Private Sub btnConfigurarGridCaixaEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCaixaEntrada.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCaixaEntrada
            oForm.NomeFormulario = Formulario.ComprasRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCaixaEntrada, Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCaixaEntrada_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCaixaEntrada.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdCaixaEntrada.CurrentRow) Then Exit Sub

            'Carrega Mensagem
            txtMensagemCaixaEntrada.Text = grdCaixaEntrada.CurrentRow.Cells("mensagem").Value

            'Atualiza Status na Tabela
            ExecuteQuery("sp_update_interacti_table_field 'tb_stc_workflow', 'status', 2, 'WHERE (((codigo) = " & grdCaixaEntrada.CurrentRow.Cells("codigo").Value & "))'")
            grdCaixaEntrada.SetValue("status", 2)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCaixaEntrada_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCaixaEntrada.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCaixaEntrada, _
                                     Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCaixaEntrada_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCaixaEntrada.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCaixaEntrada.Name, _
                                     Formulario.ComprasRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrDshWorkflow_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Grid - Caixa de Entrada
            Call oClsDshWorkflow.LoadGridCaixaEntrada(grdCaixaEntrada)

            'Configura Grid
            Call ConfiguraGrid(grdCaixaEntrada, Formulario.ComprasRequisicao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

End Class


