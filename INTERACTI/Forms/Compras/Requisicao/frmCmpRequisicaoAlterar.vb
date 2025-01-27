Imports Janus.Windows.GridEX

Public Class frmCmpRequisicaoAlterar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpRequisicao As New clsUsrCmpRequisicao
    Private lCodigoRequisicao As Long
    Private iCodigoRequisicaoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoRequisicao() As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public Property CodigoRequisicaoItem() As Integer
        Get
            Return iCodigoRequisicaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoRequisicaoItem = value
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

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub chkQuantidade_CheckedChanged(sender As Object, e As EventArgs) Handles chkQuantidade.CheckedChanged
        If chkQuantidade.Checked = True Then


            txtQuantidade.BackColor = Color.White
            txtQuantidade.ReadOnly = False

        Else
            txtQuantidade.Value = 0
            txtQuantidade.BackColor = Color.WhiteSmoke
            txtQuantidade.ReadOnly = True

        End If
    End Sub

    Private Sub chkCodigoProduto_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigoProduto.CheckedChanged
        If chkCodigoProduto.Checked = True Then


            cboCodigoProduto.BackColor = Color.White
            cboCodigoProduto.ReadOnly = False

        Else
            cboCodigoProduto.SelectedIndex = -1
            cboCodigoProduto.BackColor = Color.WhiteSmoke
            cboCodigoProduto.ReadOnly = True

        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub


    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            Call Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)


            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1,1")

            'load alterar
            oClsCmpRequisicao.LoadDadosAlterar(txtNumeroRequisicao, _
                                               txtRequisitante, _
                                               txtCodigo, _
                                               txtDescricao, _
                                               txtNumeroCotacao, _
                                               txtNumeroPedido, _
                                               txtQuantidadeAntiga, _
                                               txtUnidadeMedidaDimensao, _
                                               txtDimensao, _
                                               lCodigoRequisicao, _
                                               iCodigoRequisicaoItem)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()
        Try
            'Limpa os erros
            frmMain.errInfo.Clear()

            If chkCodigoProduto.Checked = True Then

                If ValidaCampo(cboCodigoProduto, chkCodigoProduto) = False Then Exit Sub

            End If

            If chkQuantidade.Checked = True Then

                If txtQuantidade.Value = 0 Then
                    frmMain.errInfo.SetError(chkQuantidade, "É necessário inserir um valor maior que zero!")
                    Exit Sub
                End If

            End If

            If chkComprimento.Checked = True Then

                If txtComprimento.Value = 0 Then
                    frmMain.errInfo.SetError(chkComprimento, "É necessário inserir um valor maior que zero!")
                    Exit Sub
                End If

            End If

            If chkAltura.Checked = True Then

                If txtAltura.Value = 0 Then
                    frmMain.errInfo.SetError(chkAltura, "É necessário inserir um valor maior que zero!")
                    Exit Sub
                End If

            End If

            If chkLargura.Checked = True Then

                If txtLargura.Value = 0 Then
                    frmMain.errInfo.SetError(chkLargura, "É necessário inserir um valor maior que zero!")
                    Exit Sub
                End If

            End If

            'Atualiza os dados
            oClsCmpRequisicao.UpdateRequisicaoItemAlterar(lCodigoRequisicao, _
                                                          iCodigoRequisicaoItem, _
                                                          IIf(chkCodigoProduto.Checked = False, -1, cboCodigoProduto.SelectedValue), _
                                                          IIf(chkQuantidade.Checked = False, -1, txtQuantidade.Value), _
                                                          IIf(chkComprimento.Checked = False, "", txtComprimento.Text), _
                                                          IIf(chkAltura.Checked = False, "", txtAltura.Text), _
                                                          IIf(chkLargura.Checked = False, "", txtLargura.Text), _
                                                          IIf(chkUnidadeMedida.Checked = False, -1, cboNewUnidadeMedidaDimensao.SelectedValue), _
                                                          IIf(chkDimensao.Checked = False, "", txtDimensao.Text))
            'Finaliza
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
  
    Private Sub chkComprimento_CheckedChanged(sender As Object, e As EventArgs) Handles chkComprimento.CheckedChanged

        If chkComprimento.Checked = True Then


            txtComprimento.BackColor = Color.White
            txtComprimento.ReadOnly = False

        Else
            txtComprimento.Value = 0
            txtComprimento.BackColor = Color.WhiteSmoke
            txtComprimento.ReadOnly = True

        End If

    End Sub

    Private Sub chkLargura_CheckedChanged(sender As Object, e As EventArgs) Handles chkLargura.CheckedChanged

        If chkLargura.Checked = True Then


            txtLargura.BackColor = Color.White
            txtLargura.ReadOnly = False

        Else
            txtLargura.Value = 0
            txtLargura.BackColor = Color.WhiteSmoke
            txtLargura.ReadOnly = True

        End If

    End Sub

    Private Sub chkAltura_CheckedChanged(sender As Object, e As EventArgs) Handles chkAltura.CheckedChanged

        If chkAltura.Checked = True Then


            txtAltura.BackColor = Color.White
            txtAltura.ReadOnly = False

        Else
            txtAltura.Value = 0
            txtAltura.BackColor = Color.WhiteSmoke
            txtAltura.ReadOnly = True

        End If

    End Sub
End Class