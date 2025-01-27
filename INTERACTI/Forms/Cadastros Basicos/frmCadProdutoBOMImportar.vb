Imports Janus.Windows.GridEX

Public Class frmCadProdutoBOMImportar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProduto As New clsUsrCadProduto

    'Váriaveis
    Private sCodigoProduto As String
    Private lCodigoProdutoPai As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoProdutoPai() As Long
        Get
            Return lCodigoProdutoPai
        End Get
        Set(ByVal value As Long)
            lCodigoProdutoPai = value
        End Set
    End Property

    Public Property NomeProdutoPai() As String
        Get
            Return sCodigoProduto
        End Get
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmCadProdutoPrecoVendaHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

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


#End Region

#Region "::: BOM :::"

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = ""
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboCodigoProduto


            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Atualiza Registro na tb_cad_item_bom
            Call oClsCadProduto.ImportarBOM(txtProdutoPai.Tag,
                                            cboCodigoProduto.SelectedValue)

            'Carrega TreeView
            Call LoadTreeView()

            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricao.Text = ""
                btnInserir.Tag = ""
                trvMain.Nodes.Clear()

            Else

                'Carrega Dados do Produto
                oClsCadProduto.LoadDadosProduto(cboCodigoProduto.SelectedValue, _
                                                txtDescricao)

                'Carrega TreeView
                Call LoadTreeView()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvMain.NodeMouseClick

        Try

            'Verifica se o Nó é válido
            If IsNothing(e.Node) = True Then Exit Sub

            If IsNothing(e.Node.Parent) = True Then Exit Sub


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

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
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoBOM, gcInsert)

            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, 1, NULL", False)

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            txtProdutoPai.Text = sCodigoProduto
            txtProdutoPai.Tag = lCodigoProdutoPai

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#Region "::: BOM :::"

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            Call oClsCadProduto.LoadTreeViewBOM(trvMain, cboCodigoProduto.SelectedValue)

            'Expand Nós
            trvMain.ExpandAll()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region
#End Region


End Class