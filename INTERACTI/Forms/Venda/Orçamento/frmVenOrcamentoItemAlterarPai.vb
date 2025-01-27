Imports Janus.Windows.GridEX

Public Class frmVenOrcamentoItemAlterarPai

#Region "::: VARIAVEIS :::"

    Private oClsUsrVenOrcamentoLegado As New clsUsrVenOrcamentoLegado

    Private lCodigoOrcamento As Long
    Private iCodigoOrcamentoItem As Integer
    Private bOperacaoRealizada As Boolean = False
    Private sCodigoOrcamentoItem As String

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

    Public Property OperacaoRealizada() As Boolean
        Get
            Return bOperacaoRealizada
        End Get
        Set(ByVal value As Boolean)
            bOperacaoRealizada = value
        End Set
    End Property

    Public Property CodigoOrcamentoItemConcatenado() As String
        Get
            Return sCodigoOrcamentoItem
        End Get
        Set(ByVal value As String)
            sCodigoOrcamentoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboProduto, lblProduto) = False Then Exit Sub

            Salvar()

            bOperacaoRealizada = True

            'Fecha o Controle
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
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboProduto, "sp_select_combo_venda_orcamento_item_alterar_nivel " & lCodigoOrcamento & "," & IIf(IsNothing(sCodigoOrcamentoItem), iCodigoOrcamentoItem, "'" & sCodigoOrcamentoItem & "'") & "," & goUsuario.iEmpresa)

            cboProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            If MsgBox("Deseja alterar o nível do produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            If IsNothing(sCodigoOrcamentoItem) Then

                oClsUsrVenOrcamentoLegado.UpdateAlterarItemPai(lCodigoOrcamento, _
                                                               iCodigoOrcamentoItem, _
                                                               cboProduto.SelectedValue)

            Else

                Dim sCodigo() As String = sCodigoOrcamentoItem.Split(";")

                For i = 0 To sCodigo.Count - 1

                    oClsUsrVenOrcamentoLegado.UpdateAlterarItemPai(lCodigoOrcamento, _
                                                                   sCodigo(i), _
                                                                   cboProduto.SelectedValue)



                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class