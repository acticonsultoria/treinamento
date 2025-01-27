Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.Math

Public Class frmFatEmissaoNFeImportacaoNFProdutoXML

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




    Private Sub grdNF_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdNF.RowDoubleClick
        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oGridEX = grdNF

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub frmFatEmissaoNFeProdutoXML_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub



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

    Private Sub grdNF_DropDown(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNF.DropDown

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

#Region "::: FUNCTION / SUB :::"

    Private Function Validacao() As Boolean
        Try
            Validacao = False

            If ValidaCampo(cboCFOP, lblCFOP) = False Then Exit Function
            If ValidaCampo(cboNaturezaOperacao, lblNaturezaOperacao) = False Then Exit Function

            Validacao = True
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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))

            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call ConfiguraGrid(grdNF, Formulario.FaturamentoEntradaNF)


            oClsIntImportacaoNFe.LoadGrid(grdNF, lCodigoEmissaoCapa)
            LoadComboGrid(grdNF, "codigo_produto_servico", "sp_select_combo_cadastro_basico_item_importacao " & goUsuario.iEmpresa)
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop_uf " & goUsuario.iEmpresa & ", 0, 'EX', '" & goEmitente.sUF & "'")
            Call LoadCombo(cboNaturezaOperacao, "sp_select_combo_cadastro_basico_natureza_operacao_faturamento " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub SalvarXML()

        Try
            oClsIntImportacaoNFe.UpdateNFImportacao(lCodigoEmissaoCapa, _
                                                    cboCFOP.SelectedValue, _
                                                    txtNumeroDrawback.Text.Trim, _
                                                    cboNaturezaOperacao.Text)


            'Salva Dados do Item
            oClsIntImportacaoNFe.UpdateNFProduto(lCodigoEmissaoCapa, _
                                                     grdNF)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

   
End Class

