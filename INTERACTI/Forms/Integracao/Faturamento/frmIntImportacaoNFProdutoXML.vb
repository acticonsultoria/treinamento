Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.Math

Public Class frmIntImportacaoNFProdutoXML

#Region "::: VARIAVEIS :::"

    'Váriaveis
    Private oClsIntImportacaoNFe As New clsUsrIntImportacaoNFe
    Public lCodigoEmissaoCapa As Long
    Public sResultado As String
   

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property Resultado() As String
        Get
            Return sResultado
        End Get
        Set(ByVal value As String)
            sResultado = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmFatEmissaoNFeProdutoXML_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F2
                    Select Case sender.Name
                        Case "cboProduto" : Call DadosProduto()
                    End Select

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor


                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeProdutoXML_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: NOTA FISCAL ENTRADA XML :::"

    Private Sub btnConfigurarGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridXML.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNF
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNF, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridXML.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNF.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNF.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNF.GroupByBoxVisible = True
                grdNF.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridXML.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Item
                Call SalvarXML()

                'Seta Váriavel 
                sResultado = "S"

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Verifica se o usuário deseja cancelar a importação da Nota Fiscal Eletrônica
            If MsgBox("Deseja Cancelar a Importação da Nota Fiscal Eletrônica?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Váriavel 
                sResultado = "N"

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNF.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNF.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNF.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNF, _
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdNF.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNF.Name, _
                                          Formulario.FaturamentoEntradaNF, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: RECEBIMENTO :::"

    Private Sub btnConfigurarGridRecebimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRecebimento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRecebimento
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRecebimento, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridRecebimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRecebimento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRecebimento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRecebimento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRecebimento.GroupByBoxVisible = True
                grdRecebimento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRecebimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridRecebimento.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            'If ValidacaoRecebimento() = True Then

            'Insere Registro
            Call InserirProduto()

            'Carrega Grid - Entrega
            oClsIntImportacaoNFe.LoadGridItemTemp(grdRecebimento, lCodigoEmissaoCapa)
            oClsIntImportacaoNFe.LoadGrid(grdNF, lCodigoEmissaoCapa)

            'Limpa Formulário - Recebimento
            cboProduto.SelectedIndex = -1

            'End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            ''Exclui Entrega
            Call DeleteProduto()

            ''Carrega Grid - Entrega
            oClsIntImportacaoNFe.LoadGridItemTemp(grdRecebimento, lCodigoEmissaoCapa)

            ''Limpa Formulário
            cboProduto.SelectedIndex = -1

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
    Private Sub grdRecebimento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRecebimento.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdRecebimento.CurrentColumn) Then Exit Sub

            'Verifica qual Coluna foi Pressionada
            Select Case grdRecebimento.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRecebimento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRecebimento.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRecebimento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRecebimento, _
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdRecebimento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRecebimento.Name, _
                                          Formulario.FaturamentoEntradaNF, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeProdutoXML_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call ConfiguraGrid(grdNF, Formulario.FaturamentoEntradaNF)
            Call ConfiguraGrid(grdRecebimento, Formulario.FaturamentoEntradaNF)

            'Carrega Combo
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_produto " & goUsuario.iEmpresa)

            oClsIntImportacaoNFe.LoadGrid(grdNF, lCodigoEmissaoCapa)


           
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL ENTRADA XML :::"

    Private Sub SalvarXML()

        Try

            'Salva Dados do Item
            oClsIntImportacaoNFe.UpdateItemNFTemp(lCodigoEmissaoCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirProduto()

        Try

            'Salva Dados do Item
            If CStr(btnInserir.Tag) = "" Then
                For Each oRow In grdNF.GetCheckedRows
                    oClsIntImportacaoNFe.InsertItemTemp(lCodigoEmissaoCapa, oRow.Cells.Item("codigo_emissao_item").Value, _
                                                        cboProduto.SelectedValue, cboProduto.Text)
                Next
            Else
                oClsIntImportacaoNFe.UpdateItemTemp(lCodigoEmissaoCapa, btnInserir.Tag, cboProduto.SelectedValue, cboProduto.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            If MsgBox("Deseja realmente excluir este produto?", MsgBoxStyle.YesNo, "Excluir") = vbYes Then
                For Each oRow In grdRecebimento.GetCheckedRows
                    oClsIntImportacaoNFe.DeleteItemTemp(lCodigoEmissaoCapa, oRow.Cells.Item("codigo_emissao_item").Value)
                Next
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcInsert) = True Then

               

                'Carrega Controles
                cboProduto.SelectedValue = grdRecebimento.CurrentRow.Cells.Item("codigo_item").Value
                btnInserir.Tag = grdRecebimento.CurrentRow.Cells.Item("codigo_emissao_item").Value

         
                'Seta Focu
                'cboDepositoEstoque.Focus()

            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
  
    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado algum Registro
            'For Each oRow As GridEXRow In grdNF.GetDataRows
            '    If oRow.Cells("quantidade").Value > oRow.Cells("quantidade_entregue").Value Then
            '        frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Qtde. Entregue")
            '        Exit Function
            '    End If
            'Next

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RECEBIMENTO :::"

    Private Sub DadosProduto()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Abre Formulário
                If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'dados_produto_estoque'"), Boolean) = True Then
                    Dim oForm As New frmVenDadosProdutoEstoque
                    oForm.CodigoProduto = cboProduto.SelectedValue
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                Else
                    Dim oForm As New frmVenDadosProduto
                    oForm.CodigoProduto = cboProduto.SelectedValue
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                End If

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region


    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged
        Try
            If cboProduto.SelectedIndex = -1 Then Exit Sub

            txtDescricao.Text = LoadCodigo("sp_select_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class

