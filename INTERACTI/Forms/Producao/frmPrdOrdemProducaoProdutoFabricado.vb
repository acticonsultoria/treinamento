Imports Janus.Windows.GridEX

Public Class frmPrdOrdemProducaoProdutoFabricado

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsPrdOrdemProducao As New clsUsrPrdProducaoManual

    Private lCodigoOrdemProducao As Long
    Private lCodigoRequisicao As Long
    Private lCodigoNovaOrdemProducao As Long
    Private bNovo As Boolean

#End Region

#Region "::: PROPERTIE :::"

    Public ReadOnly Property CodigoNovaOrdemProducao As Long
        Get
            Return lCodigoNovaOrdemProducao
        End Get
    End Property
    Public WriteOnly Property CodigoRequsicao As Long
        Set(value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public WriteOnly Property CodigoOrdemProducao() As Long

        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set

    End Property
    Public WriteOnly Property Novo As Boolean
        Set(value As Boolean)
            bNovo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"
    
    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

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

    Private Sub btnProcurarProdutoRequisicao_Click(sender As Object, e As EventArgs) Handles btnProcurarProdutoRequisicao.Click

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
            'oComboBoxFind = txtCodigoProdutoRequisicao
            oForm.ShowDialog(Me)

            cboCodigoProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarProdutoRequisicao_Click_1(sender As Object, e As EventArgs) Handles btnProcurarProdutoRequisicao.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboCodigoProduto
            oForm.ShowDialog(Me)

            cboCodigoProduto.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub cboCodigoProdutoRequisicao_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCodigoProduto.SelectedValueChanged
        Try

            If cboCodigoProduto.SelectedIndex = -1 Then Exit Sub
            txtDescricaoRequisicaoOrdemProducao.ReadOnly = True
            txtDescricaoRequisicaoOrdemProducao.Text = LoadCodigo("sp_load_cadastro_basico_produto_descricao " & cboCodigoProduto.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub btnSalvarRequisicao_Click(sender As Object, e As EventArgs) Handles btnSalvarRequisicao.Click

        Try
            'Limpa os erros
            frmMain.errInfo.Clear()

            'Valida os campos
            If ValidacaoRequisicao() = False Then Exit Sub

            'Salva a requisição
            SalvarRequisicao()

            If bNovo = True Then


                'Se for OP, insere o registro de ordem de produção também
                lCodigoNovaOrdemProducao = oClsPrdOrdemProducao.InsertOrdemProducaoRequisicao(lCodigoOrdemProducaoPai:=lCodigoOrdemProducao, _
                                                                       lCodigoRequisicaoPai:=lCodigoRequisicao, _
                                                                       iCodigoRequisicaoItemPai:=btnSalvarRequisicao.Tag, _
                                                                       sCodigoProdutoCliente:=txtCodigoProdutoClienteRequisicaoOrdemProducao.Text, _
                                                                        sNumeroDesenho:=txtNumeroDesenhoRequisicaoOrdemProducao.Text, _
                                                                         sSubconjunto:=txtSubconjuntoRequisicaoOrdemProducao.Text, _
                                                                         sDetalhe:=txtDetalheRequisicaoOrdemProducao.Text, _
                                                                         lCodigoItem:=cboCodigoProduto.SelectedValue, _
                                                                         sReferenciaEstrutura:="")



            End If

            'finaliza o formulário
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Function ValidacaoRequisicao() As Boolean

        Try

            If ValidaCampo(txtDescricaoRequisicaoOrdemProducao, lblDescricaoRequisicaoOrdemProducao, TipoCampo.texto) = False Then Exit Function
            'If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then Exit Function
            If ValidaCampo(txtQuantidadeRequisicaoOrdemProducao, lblQuantidadeRequisicaoOrdemProducao, True) = False Then Exit Function


            If ValidaCampo(txtNumeroDesenhoRequisicaoOrdemProducao, lblNumeroDesenhoRequisicaoOrdemProducao, TipoCampo.texto) = False Then Exit Function


            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_produto_producao " & goUsuario.iEmpresa, False)

            If Len(cboCodigoProduto.Tag) > 0 Then
                cboCodigoProduto.SelectedValue = cboCodigoProduto.Tag
            End If

            If txtCodigoProdutoRequisicaoOrdemProducao.Text = "" Then
                txtCodigoProdutoRequisicaoOrdemProducao.Text = LoadCodigo("sp_select_producao_ordem_producao_novo_codigo_produto " & IIf(lCodigoOrdemProducao = -1, "null", lCodigoOrdemProducao) & "," & goUsuario.iEmpresa)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub SalvarRequisicao()

        Try
            'Limpa os erros
            frmMain.errInfo.Clear()


            'Se não foi selecionado o produto
            If cboCodigoProduto.SelectedIndex = -1 Then



                'Cadastrar o item
                Dim lCodigoItem As Long = oClsPrdOrdemProducao.InsertCadastroBasicoProdutoOP(
                                                                                -1, _
                                                                                  txtDescricaoRequisicaoOrdemProducao.Text, _
                                                                                  txtCodigoProdutoRequisicaoOrdemProducao.Text, _
                                                                                 0, _
                                                                                 0, _
                                                                                 0, _
                                                                                  0, _
                                                                                  5, _
                                                                                  -1, _
                                                                                  "") ' 5 - pc


                'Carrega a combo de produto novamente
                Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ",null,null")

                'Seta o código do combo
                cboCodigoProduto.SelectedValue = lCodigoItem

            End If

            'Verifica se é uma edição
            If Not IsNumeric(btnSalvarRequisicao.Tag) And lCodigoRequisicao <> -1 Then


                'Insere 
                btnSalvarRequisicao.Tag = oClsPrdOrdemProducao.InsertRequisicaoItem(lCodigoRequisicao)


            End If


            If lCodigoRequisicao <> -1 Then

                'Atualiza os dados de requisição
                oClsPrdOrdemProducao.UpdateRequisicaoEstoque(iCodigoRequisicao:=lCodigoRequisicao,
                                                                 iCodigoRequisicaoItem:=btnSalvarRequisicao.Tag,
                                                                 iCodigoGrupoItem:=-1, _
                                                                 iCodigoItem:=cboCodigoProduto.SelectedValue, _
                                                                 dQuantidade:=txtQuantidadeRequisicaoOrdemProducao.Value,
                                                                 dMedida1:=0,
                                                                 dMedida2:=0,
                                                                 dMedida3:=0,
                                                                 dMedida4:=0,
                                                                 dPeso:=0,
                                                                 iCodigoUnidadeMedida:=5, _
                                                                 sCodigoProduto:=txtCodigoProdutoRequisicaoOrdemProducao.Text, _
                                                                 sDescricao:=txtDescricaoRequisicaoOrdemProducao.Text, _
                                                                 iCodigoTipoItemRequisicao:=1, _
                                                                 bItemCompra:=False, _
                                                                 sDataNecessidade:="", _
                                                                 sObservacao:=txtObservacao.Text, _
                                                                 sObservacaoInterna:="", _
                                                                 sReferenciaEstrutura:="")

            End If

            'Informa o usuário
            frmMain.Informacao(Mensagem.RegistroAlterado)




        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region


End Class