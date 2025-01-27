Imports INTERACTI.modDeclaration
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrEstRequisicaoPagar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstRequisicaoPagar As New clsUsrEstRequisicaoPagar
    Private oCurrentRow As GridEXRow
    Private iFormulario As Long
    Private iFormularioGrid As Long

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrEstRequisicaoPagar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridRequisicao() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstRequisicaoPagar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            LoadGridRequisicao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub grdListagem_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged

        Try

            'Verifica se tem alguma Linha Selecionada
            If e.Row.CheckState = RowCheckState.Checked Then

                'Desmarca Linha Anterior
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriavel
                oCurrentRow = e.Row

            Else
                'Limpa Váriavel
                oCurrentRow = Nothing
            End If

            grdListagem.Refresh()

            'Prepara Formulário
            Call NovoEntrega()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                    iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ENTREGA :::"

    Private Sub btnPagarRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarRequisicao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = False Then Exit Sub

            PagarRequisicao()
            LoadGridRequisicao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboCodigoProdutoAlternativo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProdutoAlternativo.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If cboCodigoProdutoAlternativo.SelectedIndex = -1 Then

                'Habilita Controle
                cboLote.Enabled = oCurrentRow.Cells("controla_lote").Value
                txtQuantidadeRequisicao.Value = oCurrentRow.Cells("quantidade_pendente").Value

            Else
                Dim bControlaLote As Double
                Dim dFator As Double = 1

                'Carrega Controles
                Call oClsEstRequisicaoPagar.LoadDadosRequisicaoProdutoAlternativo(oCurrentRow.Cells("codigo_requisicao").Value,
                                                                                  oCurrentRow.Cells("codigo").Value,
                                                                                  IIf(oCurrentRow.Cells("codigo_tipo_requisicao_material").Value = 3, oCurrentRow.Cells("codigo_item_pai").Value, oCurrentRow.Cells("codigo_item").Value),
                                                                                  cboCodigoProdutoAlternativo.SelectedValue,
                                                                                  bControlaLote,
                                                                                  dFator)

                'Seta Controles
                txtQuantidadeRequisicao.Value = oCurrentRow.Cells("quantidade_pendente").Value * dFator
                cboLote.Enabled = bControlaLote                

            End If

            'Seleciona Depósito
            Call cboDeposito_SelectedIndexChanged(cboDeposito, System.EventArgs.Empty)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboDeposito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDeposito.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controle
            cboLote.DataSource = Nothing : cboLote.Text = ""
            txtLocalizacao.Text = ""

            'Verifica se foi Selecionado Algum Registro
            If cboDeposito.SelectedIndex <> -1 Then

                'Váriavel 
                Dim lCodigoItem As Long

                'Seta Váriavel - Código Item
                If cboCodigoProdutoAlternativo.SelectedIndex = -1 Then

                    lCodigoItem = IIf(oCurrentRow.Cells("codigo_tipo_requisicao_material").Value = 3, oCurrentRow.Cells("codigo_item_pai").Value, oCurrentRow.Cells("codigo_item").Value)

                Else

                    lCodigoItem = cboCodigoProdutoAlternativo.SelectedValue

                End If

                'Carrega Combo - Lote
                Call LoadCombo(cboLote, "sp_select_combo_estoque_pagar_lote " & lCodigoItem & ", " & goUsuario.iEmpresa & ", " & cboDeposito.SelectedValue, True)
                'Seta Localização
                txtLocalizacao.Text = LoadDescricao("sp_select_cadastro_basico_item_localizacao " & goUsuario.iEmpresa & ", " & lCodigoItem & ", " & cboDeposito.SelectedValue)
                'Seleciona Lote
                Call cboLote_SelectedIndexChanged(cboLote, System.EventArgs.Empty)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboLote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLote.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis
            Dim lCodigoItem As Long
            Dim sLote As String = ""

            'Seta Váriavel - Código Item
            If cboCodigoProdutoAlternativo.SelectedIndex = -1 Then
                lCodigoItem = IIf(oCurrentRow.Cells("codigo_tipo_requisicao_material").Value = 3, oCurrentRow.Cells("codigo_item_pai").Value, oCurrentRow.Cells("codigo_item").Value)
            Else
                lCodigoItem = cboCodigoProdutoAlternativo.SelectedValue
            End If

            'Verifica se foi Selecionado Algum Registro
            If cboLote.SelectedIndex > -1 Then
                sLote = cboLote.SelectedValue
            End If

            'Carrega Informação do Estoque
            txtQuantidadeEstoque.Value = CType(LoadDescricao("sp_select_estoque_item_saldo " & lCodigoItem & ", '" & sLote & "'," & cboDeposito.SelectedValue & ", " & goUsuario.iEmpresa), Double)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstRequisicaoPagar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnPagarRequisicao.Enabled = VerificaDireito(iFormulario, gcInsert)

            'Carrega ComboBox        
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", NULL, 1, 0", True)

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False
            dtpDataNecessidadeInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataNecessidadeInicioFiltro.Checked = False
            dtpDataNecessidadeTerminoFiltro.Value = Now.Date : dtpDataNecessidadeTerminoFiltro.Checked = False
            dtpDataRequisicaoInicioFiltro.Enabled = False
            dtpDataRequisicaoTerminoFiltro.Enabled = False

            'Desabilita Controle
            grpEntrega.Enabled = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

            'Seta Focu
            txtNumeroRequisicaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub LoadGridRequisicao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Váriavel
            oCurrentRow = Nothing

            'Carrega Controles
            oClsEstRequisicaoPagar.LoadGrid(grdListagem,
                                            IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1),
                                            IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value),
                                            IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value),
                                            txtNumeroDocumentoFiltro.Text.Trim,
                                            txtProdutoFiltro.Text.Trim,
                                            IIf(dtpDataNecessidadeInicioFiltro.Checked = False, "", dtpDataNecessidadeInicioFiltro.Value),
                                            IIf(dtpDataNecessidadeTerminoFiltro.Checked = False, "", dtpDataNecessidadeTerminoFiltro.Value))

            'Limpa Váriavel
            oCurrentRow = Nothing
            'Limpa / Desabilita Controles
            grpEntrega.Enabled = False
            cboCodigoProdutoAlternativo.DataSource = Nothing : cboCodigoProdutoAlternativo.Text = ""
            cboDeposito.SelectedIndex = -1
            txtLocalizacao.Text = ""
            txtQuantidadeRequisicao.Value = 0
            txtQuantidadeEstoque.Value = 0
            txtQuantidade.Value = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ENTREGA :::"

    Private Sub NovoEntrega()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Configura Controles
            If IsNothing(oCurrentRow) = False Then

                'Habilita Controle
                cboLote.Enabled = oCurrentRow.Cells("controla_lote").Value
                txtQuantidadeRequisicao.Value = oCurrentRow.Cells("quantidade_pendente").Value
                txtQuantidade.Value = txtQuantidadeRequisicao.Value

                'Carrega Produto Alternativo
                Call LoadCombo(cboCodigoProdutoAlternativo, "sp_select_combo_estoque_requisicao_produto_alternativo " & oCurrentRow.Cells("codigo_requisicao").Value & ", " & goUsuario.iEmpresa & ", " & oCurrentRow.Cells("codigo").Value, False)
                cboCodigoProdutoAlternativo.Enabled = IIf(cboCodigoProdutoAlternativo.Items.Count > 0, True, False)
                Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", NULL, 1, 0", True)
                Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)

                'Habilita Entrega
                grpEntrega.Enabled = True

            Else

                'Desabilita Controles
                cboLote.DataSource = Nothing : cboLote.Text = "" : cboLote.Enabled = False
                cboCodigoProdutoAlternativo.DataSource = Nothing : cboCodigoProdutoAlternativo.Text = "" : cboCodigoProdutoAlternativo.Enabled = False

                'Desabilita Entrega
                grpEntrega.Enabled = False

            End If

            'Limpa Controles            
            'cboDeposito.SelectedIndex = -1
            txtQuantidade.Value = 0

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub PagarRequisicao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário deseja Aprovar a Requisição
            If MsgBox("Deseja Pagar a Requisição de Estoque?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Paga Requisição
                oClsEstRequisicaoPagar.PagarRequisicao(oCurrentRow.Cells("codigo_requisicao").Value, _
                                                       oCurrentRow.Cells("codigo").Value, _
                                                       txtQuantidade.Value, _
                                                       IIf(cboLote.SelectedIndex = -1, "", cboLote.SelectedValue), _
                                                       cboDeposito.SelectedValue, _
                                                       oCurrentRow.Cells("quantidade_pendente").Value / txtQuantidadeRequisicao.Value, _
                                                       IIf(cboCodigoProdutoAlternativo.SelectedIndex = -1, -1, cboCodigoProdutoAlternativo.SelectedValue), _
                                                       IIf(cboFuncionario.SelectedIndex = -1, -1, cboFuncionario.SelectedValue), _
                                                       IIf(IsDBNull(oCurrentRow.Cells("codigo_pedido").Value), -1, oCurrentRow.Cells("codigo_pedido").Value), _
                                                       IIf(IsDBNull(oCurrentRow.Cells("codigo_pedido_item").Value), -1, oCurrentRow.Cells("codigo_pedido_item").Value), _
                                                       IIf(IsDBNull(oCurrentRow.Cells("codigo_pedido_item_entrega").Value), -1, oCurrentRow.Cells("codigo_pedido_item_entrega").Value))

                If txtQuantidade.Value < txtQuantidadeRequisicao.Value Then

                    'Verifica se deseja fechar a Requisição de Compra
                    If MsgBox("Deseja fechar essa Requisição de Material do Estoque?", MsgBoxStyle.Question + vbYesNo) = vbYes Then


                        'Atualiza Requisição
                        oClsEstRequisicaoPagar.FecharRequisicao(oCurrentRow.Cells("codigo_requisicao").Value, _
                                                                oCurrentRow.Cells("codigo").Value)

                    End If

                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then Return False

            'Verifica se foi Selecionado o Campo - Lote
            If cboLote.Enabled = True Then
                If ValidaCampo(cboLote, lblLote) = False Then Return False
            End If

            'Verifica se a Quantidade do Estoque é Válida
            If txtQuantidade.Value > txtQuantidadeEstoque.Value Then
                frmMain.errInfo.SetError(lblQuantidade, "Não existe Quantidade Suficiente em Estoque.")
                txtQuantidade.Focus()
                Return False
            End If

            'Verifica se a Quantidade Paga é Maior que a Quantidade Pendente
            If txtQuantidade.Value > txtQuantidadeRequisicao.Value Then
                If MsgBox("A Quantidade a ser Paga está maior que a Quantidade Pendente. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    txtQuantidade.Focus()
                    Return False
                End If
            End If

            If oClsEstRequisicaoPagar.ValidaItemNTO(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                    grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                    grdListagem.CurrentRow.Cells("codigo_pedido_item_entrega").Value) = True Then
                MsgBox("Existe uma NTO aberta para este item.", MsgBoxStyle.Information, "Validação")
                Return False
            End If

            If oClsEstRequisicaoPagar.ValidaItemInspecao(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                    grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                    grdListagem.CurrentRow.Cells("codigo_pedido_item_entrega").Value) = True Then
                MsgBox("Este item ainda não foi inspecionado!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If oClsEstRequisicaoPagar.ValidaAprovacaoRequisicao(grdListagem.CurrentRow.Cells("codigo_requisicao").Value) = True Then
                MsgBox("Essa requisição ainda não foi aprovada!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If ValidacaoDataCusteio(Today.Date) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class