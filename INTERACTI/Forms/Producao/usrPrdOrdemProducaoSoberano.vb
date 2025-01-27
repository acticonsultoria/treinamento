Imports System.Threading

Public Class usrPrdOrdemProducaoSoberano

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdPlanejamento As New clsUsrPrdPlanejamento

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrPrdOrdemProducaoManual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F3
                   

                Case Keys.F5


                Case Keys.Oemplus, Keys.Add

            
                Case Keys.Enter
                   


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrPrdOrdemProducaoManual_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub usrPrdOrdemProducaoManual_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click() Handles btnSalvar.Click

        Try

            'Valida dados da Ordem de Produção
            If Validacao() = True Then

                'Salva Formulário
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoProduto.SelectedIndexChanged, _
                                                                                                             cboBitola.SelectedIndexChanged, _
                                                                                                             cboCor.SelectedIndexChanged

        Try

            txtCodigoIntegracao.Text = ""
            txtQuantidadeRolo.Tag = ""
            txtQuantidadeBobina.Tag = ""
            txtQuantidadeCarretel.Tag = ""

            If cboTipoProduto.SelectedIndex > -1 And cboBitola.SelectedIndex > -1 And cboCor.SelectedIndex > -1 Then
                txtCodigoIntegracao.Text = LoadCodigo("sp_select_cadastro_basico_item_codigo_integracao_soberano '" & cboTipoProduto.SelectedValue & "','" & cboBitola.SelectedValue.ToString.Replace(",", ".") & "','" & cboCor.SelectedValue & "'," & goUsuario.iEmpresa)
                txtQuantidadeRolo.Tag = LoadCodigo("sp_select_cadastro_basico_item_soberano_codigo_tipo_venda  '" & cboTipoProduto.SelectedValue & "','" & cboBitola.SelectedValue.ToString.Replace(",", ".") & "','" & cboCor.SelectedValue & "','RL'," & goUsuario.iEmpresa)
                txtQuantidadeBobina.Tag = LoadCodigo("sp_select_cadastro_basico_item_soberano_codigo_tipo_venda '" & cboTipoProduto.SelectedValue & "','" & cboBitola.SelectedValue.ToString.Replace(",", ".") & "','" & cboCor.SelectedValue & "','BB'," & goUsuario.iEmpresa)
                txtQuantidadeCarretel.Tag = LoadCodigo("sp_select_cadastro_basico_item_soberano_codigo_tipo_venda '" & cboTipoProduto.SelectedValue & "','" & cboBitola.SelectedValue.ToString.Replace(",", ".") & "','" & cboCor.SelectedValue & "','CT'," & goUsuario.iEmpresa)

            End If


            If sender.name = "cboTipoProduto" Then
                cboBitola.SelectedIndex = -1
                cboCor.SelectedIndex = -1
                Call LoadCombo(cboBitola, "sp_select_combo_static_bitola_soberano '" & cboTipoProduto.SelectedValue & "'," & goUsuario.iEmpresa)
            End If
            If sender.name = "cboBitola" Then
                cboCor.SelectedIndex = -1
                Call LoadCombo(cboCor, "sp_select_combo_static_cor_soberano '" & cboTipoProduto.SelectedValue & "'," & cboBitola.SelectedValue.ToString.Replace(",", ".") & "," & goUsuario.iEmpresa)
            End If


            

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdOrdemProducaoManual_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito            
            btnSalvar.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoManual, gcInsert)

            'Verifica Direito - Cadastro
            dtpDataEmissao.Value = Now

            'Carrega Combo

            Call LoadCombo(cboTipoProduto, "sp_select_combo_static_tipo_produto_soberano")

            Call LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina_performa " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboOperador, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboTipoProduto.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

         
            Cursor.Current = Cursors.WaitCursor


            Dim sVetor(2) As String
            sVetor(0) = "Rolo"
            sVetor(1) = "Bobina"
            sVetor(2) = "Carretel"


            Dim dQuantidade As Double
            Dim lCodigo As Long

            For i As Integer = 0 To 2


                If sVetor(i) = "Rolo" Then
                    If txtQuantidadeRolo.Value = 0 Then
                        Continue For
                    Else
                        dQuantidade = txtQuantidadeRolo.Value
                        lCodigo = txtQuantidadeRolo.Tag
                    End If

                End If

                If sVetor(i) = "Bobina" Then
                    If txtQuantidadeBobina.Value = 0 Then
                        Continue For
                    Else
                        dQuantidade = txtQuantidadeBobina.Value
                        lCodigo = txtQuantidadeBobina.Tag
                    End If
                End If

                If sVetor(i) = "Carretel" Then
                    If txtQuantidadeCarretel.Value = 0 Then
                        Continue For
                    Else
                        dQuantidade = txtQuantidadeCarretel.Value
                        lCodigo = txtQuantidadeCarretel.Tag
                    End If
                End If



                'Gera Ordem de Produção
                oClsPrdPlanejamento.GerarOrdemProducaosoberano(lCodigo, _
                                                       -1, _
                                                       -1, _
                                                       1, _
                                                       1, _
                                                       -1, _
                                                       dQuantidade, _
                                                       dQuantidade, _
                                                       0, _
                                                       0, _
                                                       0, _
                                                       0, _
                                                      dQuantidade, _
                                                       -1, _
                                                      -1, _
                                                      -1, _
                                                       dtpDataEmissao.Value, _
                                                       dtpDataEmissao.Value, _
                                                        txtLote.Text, _
                                                       IIf(cboMaquina.SelectedIndex = -1, -1, cboMaquina.SelectedValue), _
                                                       IIf(cboOperador.SelectedIndex = -1, -1, cboOperador.SelectedValue), _
                                                      1) ' cliente

            Next

            'Informa o Usuário sobre o sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroInserido)

            'Limpa Controles
            txtQuantidadeRolo.Value = 0
            txtQuantidadeCarretel.Value = 0
            txtQuantidadeBobina.Value = 0


            'Tenta criar o próximo lote
            If txtLote.Text.Contains("/") Then

                Dim sVetorLote() As String = txtLote.Text.Split("/")


                txtLote.Text = CStr(CLng(sVetorLote(0)) + 1).PadLeft(4, "0") + "/" + sVetorLote(1)


            End If


            cboCor.Focus()


            Cursor.Current = Cursors.Default

            'End If

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            frmMain.errInfo.Clear()

            'Seta Retorno da Função
            Validacao = False

            If ValidaCampo(txtCodigoIntegracao, lblCodigoIntegracao, TipoCampo.numero) = False Then
                Exit Function
            End If

            If txtQuantidadeBobina.Value > 0 And txtQuantidadeBobina.Tag = "" Then
                frmMain.errInfo.SetError(lblQuantidadeBobina, "Não existe cadastro para esse tipo de venda com esses parâmetros!")
                Exit Function
            End If
            If txtQuantidadeRolo.Value > 0 And txtQuantidadeRolo.Tag = "" Then
                frmMain.errInfo.SetError(lblQuantidadeRolo, "Não existe cadastro para esse tipo de venda com esses parâmetros!")
                Exit Function
            End If
            If txtQuantidadeCarretel.Value > 0 And txtQuantidadeCarretel.Tag = "" Then
                frmMain.errInfo.SetError(lblQuantidadeCarretel, "Não existe cadastro para esse tipo de venda com esses parâmetros!")
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
