Imports Janus.Windows.GridEX

Public Class frmPrdOrdemProducaoManual

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdPlanejamento As New clsUsrPrdPlanejamento

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmPrdOrdemProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3
                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1, NULL, NULL, NULL")
                        Case "cboCliente" : Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                    End Select

                Case Keys.Enter
                    Select Case sender.name

                        Case "txtQuantidadePlanejada" : Call btnSalvar_Click()

                    End Select



            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmPrdOrdemProducao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmPrdOrdemProducao_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1, NULL, NULL, NULL")

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboCodigoProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtQuantidadePlanejada.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            If cboCodigoProduto.SelectedIndex = -1 Then
                txtDescricao.Text = ""
                cboModeloRoteiroProducao.DataSource = Nothing : cboModeloRoteiroProducao.Text = "" : cboRevisao.Text = ""
            Else
                'Carrega Controles
                Call LoadDescricao(txtDescricao, "sp_select_cadastro_basico_descricao_item " & cboCodigoProduto.SelectedValue & ", " & goUsuario.iEmpresa)
                Call LoadCombo(cboModeloRoteiroProducao, "sp_select_combo_cadastro_basico_item_modelo_roteiro_producao " & goUsuario.iEmpresa & ", " & cboCodigoProduto.SelectedValue, True)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboModeloRoteiroProducao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModeloRoteiroProducao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboModeloRoteiroProducao.SelectedIndex <> -1 Then
                'Carrega Combo
                Call LoadCombo(cboRevisao, "sp_select_combo_cadastro_basico_item_roteiro_revisao " & goUsuario.iEmpresa, False)
            Else
                'Limpa Controles
                cboRevisao.Text = "" : cboRevisao.DataSource = Nothing
            End If

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmPrdOrdemProducao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito            
            btnSalvar.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoManual, gcInsert)

            'Verifica Direito - Cadastro
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1, NULL, NULL, NULL")
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboCodigoProduto.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            ''Verifica se o Usuário Confirma os Dados do Apontamento
            'If MsgBox("Deseja Gerar Ordem de Produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

            'Atualiza Apontamento
            oClsPrdPlanejamento.GerarOrdemProducao(cboCodigoProduto.SelectedValue, _
                                                   cboCliente.SelectedValue, _
                                                   txtQuantidadePlanejada.Value, _
                                                   dtpDataNecessidade.Value, _
                                                   -1, _
                                                   cboModeloRoteiroProducao.SelectedValue, _
                                                   cboRevisao.SelectedValue)

            'Informa o Usuário sobre o sucesso da Operação
            MsgBox("Ordem de Produção Gerada com Sucesso!!!", MsgBoxStyle.Information)

            'Limpa Controles
            cboCodigoProduto.Text = ""
            cboCliente.Text = ""
            txtQuantidadePlanejada.Value = 0
            dtpDataNecessidade.Value = Now.Date

            'End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Código do Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadePlanejada, lblQuantidadePlanejada, True) = False Then
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
