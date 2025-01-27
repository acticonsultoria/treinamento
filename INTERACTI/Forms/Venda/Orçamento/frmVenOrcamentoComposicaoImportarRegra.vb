Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmVenOrcamentoComposicaoImportarRegra

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private oCurrentRow As GridEXRow
    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer
    Private iFormulario As Integer
    Private iCodigoRegraOrcamento As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoOrcamento() As Long
        Get
            Return lCodigoOrcamento
        End Get
        Set(ByVal value As Long)
            lCodigoOrcamento = value
        End Set
    End Property

    Public Property CodigoOrcamentoItem() As Integer
        Get
            Return iCodigoOrcamentoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoOrcamentoItem = value
        End Set
    End Property

    Public Property Formulario() As Integer
        Get
            Return iFormulario
        End Get
        Set(ByVal value As Integer)
            iFormulario = value
        End Set
    End Property

    Public Property CodigoRegraOrcamento() As Integer
        Get
            Return iCodigoRegraOrcamento
        End Get
        Set(ByVal value As Integer)
            iCodigoRegraOrcamento = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            Importar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdRegraOrcamento.RowCheckStateChanged

        Try
            'Verifica o Status da Linha
            If e.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = e.Row

            Else
                oCurrentRow = Nothing
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadRegraOrcamento")

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            ConfiguraGrid(grdRegraOrcamento, iFormulario)

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrVenOrcamentoLegado.LoadGridImportarRegra(grdRegraOrcamento)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Importar()

        Try

            If grdRegraOrcamento.GetCheckedRows.Count <= 0 Then
                MsgBox("Selecione alguma linha.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            oClsUsrVenOrcamentoLegado.UpdateDespesasVariaveis(lCodigoOrcamento, _
                                                              iCodigoOrcamentoItem, _
                                                              grdRegraOrcamento.GetValue("aliquota_reducao_base_calculo_icms"), _
                                                              grdRegraOrcamento.GetValue("aliquota_icms"), _
                                                              grdRegraOrcamento.GetValue("aliquota_pis"), _
                                                              grdRegraOrcamento.GetValue("aliquota_cofins"), _
                                                              grdRegraOrcamento.GetValue("aliquota_iss"), _
                                                              grdRegraOrcamento.GetValue("aliquota_ir"), _
                                                              grdRegraOrcamento.GetValue("aliquota_csll"), _
                                                              0)

            iCodigoRegraOrcamento = grdRegraOrcamento.GetValue("codigo")

            frmMain.Informacao(Mensagem.RegistroAlterado)

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class