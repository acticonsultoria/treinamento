Public Class usrEstIssartel

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstIssartel As New clsUsrEstIssartel

#End Region

#Region "::: CONTROLES :::"
  
    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

  
    Private Sub cboNotaFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNotaFiscal.SelectedIndexChanged
        Try
            If cboNotaFiscal.SelectedIndex = -1 Then Exit Sub

            Call LoadCombo(cboProduto, "sp_select_combo_faturamento_item_produto_issartel " & cboNotaFiscal.SelectedValue & "," & goUsuario.iEmpresa & ", '" & cboTipo.SelectedValue & "'")
            If cboTipo.SelectedValue = "EMISSÃO" Then
                txtParceiroNegocio.Text = LoadCodigo("sp_select_faturamento_emissao_destinatario " & cboNotaFiscal.SelectedValue & "," & goUsuario.iEmpresa)
            Else
                txtParceiroNegocio.Text = LoadCodigo("sp_select_faturamento_entrada_emitente " & cboNotaFiscal.SelectedValue & "," & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboProdutoEstoque

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProdutoEstoque.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub brnGerarNovoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnGerarNovoLote.Click
        Try
            GerarNovoLote(cboNotaFiscal.SelectedValue, cboProduto.SelectedValue, cboTipo.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_RowDoubleClick1(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "duplicar" : Call Duplicar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoria.SelectedIndexChanged
        Try
            If cboCategoria.SelectedIndex = -1 Then Exit Sub
            LoadCombo(cboMateriaPrima, "sp_select_combo_cadastro_basico_mp " & goUsuario.iEmpresa & ", " & cboCategoria.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboFormato_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormato.SelectedIndexChanged
        Try
            If cboFormato.SelectedIndex = -1 Then Exit Sub

            oClsEstIssartel.LoadDadosFormatoMPIssartel(cboFormato.SelectedValue, _
                                                        txtMedida1, _
                                                        txtMedida2, _
                                                        txtMedida3, _
                                                        txtMedida4, _
                                                        lblMedida1, _
                                                        lblMedida2, _
                                                        lblMedida3, _
                                                        lblMedida4)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub CalcularPeso(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMedida4.ValueChanged, _
                                                                                                 txtMedida3.ValueChanged, _
                                                                                                 txtMedida2.ValueChanged, _
                                                                                                 txtMedida1.ValueChanged, _
                                                                                                 cboFormato.SelectedIndexChanged, _
                                                                                                 cboMateriaPrima.SelectedIndexChanged

        Try
            If cboFormato.SelectedIndex = -1 Or cboMateriaPrima.SelectedIndex = 1 Then Exit Sub
            oClsEstIssartel.LoadDensidade(cboMateriaPrima.SelectedValue, txtDensidade)
            oClsEstIssartel.LoadCalculoPeso(cboFormato.SelectedValue, _
                                        cboMateriaPrima.SelectedValue, _
                                        txtMedida1.Value, _
                                        txtMedida2.Value, _
                                        txtMedida3.Value, _
                                        txtMedida4.Value, _
                                        txtPeso)
            txtQuantidadeEstoque.Value = txtPeso.Value
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged
        Try
            If cboProduto.SelectedIndex = -1 Then Exit Sub
            If cboTipo.SelectedValue = "EMISSÃO" Then
                cboProdutoEstoque.SelectedValue = LoadCodigo("sp_select_faturamento_emissao_item_codigo_item " & cboNotaFiscal.SelectedValue & "," & cboProduto.SelectedValue & "," & goUsuario.iEmpresa)
            Else
                cboProdutoEstoque.SelectedValue = LoadCodigo("sp_select_faturamento_entrada_item_codigo_item " & cboNotaFiscal.SelectedValue & "," & cboProduto.SelectedValue & "," & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call LoadCombo(cboProdutoEstoque, "sp_select_combo_cadastro_basico_produto " & goUsuario.iEmpresa)
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisOrigem, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboFormato, "sp_select_combo_cadastro_basico_tipo_mp " & goUsuario.iEmpresa)
            Call LoadCombo(cboCategoria, "sp_select_combo_cadastro_basico_categoria_mp " & goUsuario.iEmpresa)
            cboTipo.Items.Clear()
            cboTipo.Items.Add("EMISSÃO", "EMISSÃO")
            cboTipo.Items.Add("ENTRADA", "ENTRADA")


            'Configura a Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueIssartel)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)


            
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCor, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    txtLote.Enabled = False
                    cboNotaFiscal.Enabled = False
                    cboProduto.Enabled = False

                    'Carrega Controles
                    txtLote.Text = .Item("lote").Value
                    cboTipo.SelectedValue = .Item("tipo").Value
                    cboNotaFiscal.SelectedValue = .Item("codigo_capa").Value
                    cboProduto.SelectedValue = .Item("codigo_item").Value


                    txtNumeroRastreabilidade.Text = .Item("numero_rastreabilidade").Value
                    txtNumeroCertificado.Text = .Item("numero_certificado").Value
                    cboPaisOrigem.SelectedValue = .Item("codigo_pais").Value
                    btnSalvar.Tag = .Item("lote").Value
                    txtFornecedor.Text = .Item("fornecedor").Value
                    dtpDataEntrada.Value = .Item("data_entrada").Value
                    txtNorma.Text = .Item("controlado_norma").Value
                    txtValidado.Text = .Item("validado").Value
                    txtPrateleira.Text = .Item("prateleira").Value
                    cboFormato.SelectedValue = .Item("codigo_formato").Value
                    cboCategoria.SelectedValue = .Item("codigo_categoria").Value
                    cboMateriaPrima.SelectedValue = .Item("codigo_mp").Value
                    txtNumeroDin.Text = .Item("numero_din").Value
                    lblMedida1.Text = .Item("descricao_medida1").Value
                    txtMedida1.Value = .Item("medida1").Value
                    lblMedida2.Text = .Item("descricao_medida2").Value
                    txtMedida2.Value = .Item("medida2").Value
                    lblMedida3.Text = .Item("descricao_medida3").Value
                    txtMedida3.Value = .Item("medida3").Value
                    lblMedida4.Text = .Item("descricao_medida4").Value
                    txtMedida4.Value = .Item("medida4").Value

                    txtDensidade.Value = .Item("densidade").Value
                    txtPrecoKilo.Value = .Item("preco_quilo").Value
                    txtPrecoBarra.Value = .Item("preco_barra").Value
                    txtNumeroPedido.Text = .Item("numero_pedido").Value
                    txtQuantidadeEstoque.Value = .Item("quantidade_estoque").Value
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    cboProdutoEstoque.SelectedValue = .Item("codigo_item_estoque").Value
                    txtPeso.Value = .Item("peso").Value
                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                ' txtCodigoItem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsEstIssartel.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            ''Limpa Controles
            txtLote.Enabled = True
            txtLote.Text = ""
            cboNotaFiscal.SelectedIndex = -1
            cboNotaFiscal.Enabled = True
            cboProduto.SelectedIndex = -1
            cboProduto.Enabled = True

            cboProdutoEstoque.SelectedIndex = -1
            cboDeposito.SelectedIndex = -1
            txtQuantidadeEstoque.Value = 0
            txtNumeroRastreabilidade.Text = ""
            txtNumeroCertificado.Text = ""
            cboPaisOrigem.SelectedIndex = -1
            btnSalvar.Tag = ""
            txtFornecedor.Text = ""
            dtpDataEntrada.Value = Now.Date
            txtNorma.Text = ""
            txtValidado.Text = ""
            txtPrateleira.Text = ""
            cboFormato.SelectedIndex = -1
            cboCategoria.SelectedIndex = -1
            cboMateriaPrima.SelectedIndex = -1
            txtNumeroDin.Text = ""
            txtMedida1.Value = 0
            txtMedida2.Value = 0
            txtMedida3.Value = 0
            txtMedida4.Value = 0
            txtPeso.Value = 0
            txtDensidade.Value = 0
            txtPrecoKilo.Value = 0
            txtPrecoBarra.Value = 0
            txtNumeroPedido.Text = ""
            cboTipo.SelectedIndex = -1
            txtParceiroNegocio.Text = ""

            ''Seta Focu
            'txtCodigoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsEstIssartel.CodigoPais = cboPaisOrigem.SelectedValue
            oClsEstIssartel.Medida1 = txtMedida1.Value
            oClsEstIssartel.Medida2 = txtMedida2.Value
            oClsEstIssartel.DataEntrada = dtpDataEntrada.Value
            oClsEstIssartel.Densidade = txtDensidade.Value
            oClsEstIssartel.Fornecedor = txtFornecedor.Text
            oClsEstIssartel.CodigoFormato = IIf(cboFormato.SelectedIndex = -1, -1, cboFormato.SelectedValue)
            oClsEstIssartel.Medida3 = txtMedida3.Value
            oClsEstIssartel.Lote = txtLote.Text
            oClsEstIssartel.CodigoCategoria = IIf(cboCategoria.SelectedIndex = -1, -1, cboCategoria.SelectedValue)
            oClsEstIssartel.Norma = txtNorma.Text
            oClsEstIssartel.NumeroCertificado = txtNumeroCertificado.Text
            oClsEstIssartel.NumeroDin = txtNumeroDin.Text
            oClsEstIssartel.NumeroPedido = txtNumeroPedido.Text
            oClsEstIssartel.NumeroRastreabilidade = txtNumeroRastreabilidade.Text
            oClsEstIssartel.Peso = txtPeso.Value
            oClsEstIssartel.Prateleira = txtPrateleira.Text
            oClsEstIssartel.PrecoBarra = Replace(txtPrecoBarra.Value, ".", ",")
            oClsEstIssartel.PrecoKilo = Replace(txtPrecoKilo.Value, ".", ",")
            oClsEstIssartel.Medida4 = txtMedida4.Value
            oClsEstIssartel.UsuarioValidacao = txtValidado.Text
            oClsEstIssartel.CodigoMateriaPrima = IIf(cboMateriaPrima.SelectedIndex = -1, -1, cboMateriaPrima.SelectedValue)
            oClsEstIssartel.codigodeposito = cboDeposito.SelectedValue
            oClsEstIssartel.quantidadeEstoque = txtQuantidadeEstoque.Value
            oClsEstIssartel.CodigoProdutoEstoque = cboProdutoEstoque.SelectedValue
            oClsEstIssartel.CodigoCapa = cboNotaFiscal.SelectedValue
            oClsEstIssartel.CodigoItem = cboProduto.SelectedValue
            oClsEstIssartel.Tipo = cboTipo.SelectedValue

            'Verifica o Tipo de Operação
            If CStr(btnSalvar.Tag) <> "" Then
                oClsEstIssartel.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsEstIssartel.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            ''Seta Parametros
            oClsEstIssartel.LoadGrid(grdListagem, _
                                    txtLoteFiltro.Text, _
                                    txtNumeroRastreabilidadeFiltro.Text, _
                                    IIf(IsNumeric(txtNotaFiscalFiltro.Text), txtNotaFiscalFiltro.Text, -1))



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Moeda
            If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtQuantidadeEstoque, lblQuantidadeEstoque, True) = False Then
                Exit Function
            End If


            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CalculaPeso() Handles txtMedida1.ValueChanged, _
                                      txtMedida1.ValueChanged, _
                                      txtMedida2.ValueChanged, _
                                      txtMedida3.ValueChanged, _
                                      txtMedida4.ValueChanged, _
                                      txtDensidade.ValueChanged
        Try
            'txtPeso.Value = (((3.14 * txtMedida1.Value * txtMedida1.Value / 4) - (3.14 * txtTuboDento.Value * txtTuboDento.Value / 4) + (3.14 * txtMedida2.Value * txtMedida2.Value / 4 * 1.102) + txtLarg.Value * txtEspessura.Value) * 0.001 * txtDensidade.Value * txtComprimento.Value) / 1000
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculaPrecoBarra() Handles txtPrecoKilo.ValueChanged, _
                                            txtPeso.ValueChanged
        Try
            txtPrecoBarra.Value = txtPrecoKilo.Value * txtPeso.Value
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub GerarNovoLote(ByVal lCodigoCapa As Long, _
                              ByVal iCodigoItem As Integer, _
                              ByVal sTipo As String)

        Try

            txtLote.Text = LoadCodigo("sp_select_fatuaramento_emissao_classificacao_novo_lote " & lCodigoCapa & ", " & goUsuario.iEmpresa & ", " & iCodigoItem & ", '" & sTipo & "'")


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Duplicar()
        Try
            'Questiona a quantidade
            'Dim sInput As String = InputBox("Digite a quantidade de recebimentos para duplicar:", "Duplicação de Recebimento")

            'Se não digitar nada, sair da função
            'If Not IsNumeric(sInput) Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            Call Editar()

            btnSalvar.Tag = ""
            txtLote.Text = ""
            txtLote.Enabled = True
            cboNotaFiscal.Enabled = True
            cboProduto.Enabled = True
            cboProduto.SelectedIndex = -1
            'Carrega Controles

            'Faz a procedure de inserção
            'oClsEstIssartel.Duplicar(grdListagem.GetValue("lote"), _
            '                         sInput, _
            '                         grdListagem.GetValue("tipo"))

            'Informa ao usuário
            frmMain.Informacao("Recebimento duplicado com sucesso!", Color.Blue)

            'Carrega novamente
            LoadGrid()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw ex
        End Try
    End Sub

#End Region
    
    
    
   
    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        Try
            If cboTipo.SelectedIndex = -1 Then Exit Sub

            Call LoadCombo(cboNotaFiscal, "sp_select_combo_faturamento_emissao_nota_fiscal_importacao " & goUsuario.iEmpresa & ", '" & cboTipo.SelectedValue & "'")
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirAlteracoes_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
