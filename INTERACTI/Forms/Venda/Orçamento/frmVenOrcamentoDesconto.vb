Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmVenOrcamentoDesconto

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsVenOrcamentoLegado As New clsUsrVenOrcamentoLegado
    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer = -1
    Private dPorcentagemDesconto As Double

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


#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Control_Enter(sender)

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

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub LostFocus_desconto(sender As Object, e As System.EventArgs) Handles txtValorDesconto.LostFocus, _
                                                                                    txtPorcentagemDesconto.LostFocus, _
                                                                                    txtPrecoVendaSemIPINovo.LostFocus

        Try

            If sender.name = txtValorDesconto.Name Then

                txtPorcentagemDesconto.Value = (txtValorDesconto.Value / txtPrecoVendaSemIPI.Value) * 100.0

            ElseIf sender.name = txtPorcentagemDesconto.Name Then

                txtValorDesconto.Value = (txtPrecoVendaSemIPI.Value * txtPorcentagemDesconto.Value) / 100.0

            ElseIf sender.name = txtPrecoVendaSemIPINovo.Name Then

                txtValorDesconto.Value = txtPrecoVendaSemIPI.Value - txtPrecoVendaSemIPINovo.Value
                txtPorcentagemDesconto.Value = (txtValorDesconto.Value / txtPrecoVendaSemIPI.Value) * 100.0

            End If

            dPorcentagemDesconto = (txtValorDesconto.Value / txtPrecoVendaSemIPI.Value) * 100.0
            txtPrecoVendaSemIPINovo.Value = txtPrecoVendaSemIPI.Value - txtValorDesconto.Value

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(txtPrecoVendaSemIPINovo, lblPrecoVendaSemIPINovo, True) = False Then Exit Sub

            If MsgBox("Deseja aplicar o desconto no orçamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsVenOrcamentoLegado.UpdateDesconto(lCodigoOrcamento, _
                                                  iCodigoOrcamentoItem, _
                                                  dPorcentagemDesconto)

            frmMain.Informacao(Mensagem.RegistroSalvo)

            Cursor.Current = Cursors.Default

            Me.Dispose()

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

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

End Class