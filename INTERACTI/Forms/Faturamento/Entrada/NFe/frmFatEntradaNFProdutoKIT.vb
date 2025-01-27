Imports Janus.Windows.GridEX

Public Class frmFatEntradaNFProdutoKIT

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFatEntradaNF As New clsUsrFatEntradaNF

    Private lCodigoItem As Long
    Private sCodigoProduto As String
    Private sDescricao As String
    Private dQuantidadeProduto As Double
    Private lCodigoEntradaCapa As Long
    Private iCodigoEntradaItem As Integer    
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoItem() As Long
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoProduto() As String
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
    End Property

    Public WriteOnly Property Descricao() As String
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public WriteOnly Property QuantidadeProduto() As Double
        Set(ByVal value As Double)
            dQuantidadeProduto = value
        End Set
    End Property

    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public WriteOnly Property CodigoEntradaItem() As Integer
        Set(ByVal value As Integer)
            iCodigoEntradaItem = value
        End Set
    End Property

    Public WriteOnly Property Codigo() As Integer
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFatEntradaNFProdutoKIT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEntradaNFProdutoKIT_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Limpa Formulário
                Call Novo()
                'Carrega Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Reboque
            Call Excluir()
            'Limpa Formulário
            Call Novo()

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

    Private Sub cboComponenteOriginal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComponenteOriginal.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboComponenteOriginal.SelectedIndex = -1 Then
                'Limpa Controles
                cboComponenteOpcional.DataSource = Nothing
                cboComponenteOpcional.Text = ""
                txtLote.Text = ""
                txtQuantidade.Value = 0
            Else
                'Carrega Combo
                Call LoadCombo(cboComponenteOpcional, "sp_select_combo_cadastro_basico_produto_kit_componente_opcional " & lCodigoItem & ", " & Replace(dQuantidadeProduto.ToString, ",", ".") & ", " & goUsuario.iEmpresa & ", " & cboComponenteOriginal.SelectedValue.ToString.Split(";")(0))
                'Verifica se foi carregado algum Registro
                    cboComponenteOpcional.Enabled = IIf(cboComponenteOpcional.Items.Count > 0, True, False)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboComponenteOpcional_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComponenteOpcional.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboComponenteOpcional.SelectedIndex = -1 Then
                'Limpa Controles
                txtLote.Text = ""
                txtLote.Enabled = False
                txtQuantidade.Value = 0
            Else
                txtLote.Enabled = CType(LoadDescricao("sp_select_cadastro_basico_dados_item_controla_lote " & cboComponenteOpcional.SelectedValue & ", " & goUsuario.iEmpresa), Boolean)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdComposicao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdComposicao.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdComposicao.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdComposicao.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdComposicao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdComposicao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdComposicao.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdComposicao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdComposicao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdComposicao, _
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdComposicao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdComposicao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdComposicao.Name, _
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

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEntradaNFProdutoKIT_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcDelete)

            'Configura Grid
            Call ConfiguraGrid(grdComposicao, Formulario.FaturamentoEntradaNF)

            'Carrega Controles
            txtCodigoProduto.Text = sCodigoProduto
            txtDescricao.Text = sDescricao
            txtQuantidadeProduto.Value = dQuantidadeProduto

            'Desabilita Controles
            txtLote.Enabled = False

            'Carrega Combo
            Call LoadCombo(cboComponenteOriginal, "sp_select_combo_cadastro_basico_produto_kit_componente " & lCodigoItem & ", " & Replace(dQuantidadeProduto.ToString, ",", ".") & ", " & goUsuario.iEmpresa)

            'Carrega Grid
            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Excluir()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdComposicao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEntradaNF.DeleteKITTmp(lCodigoEntradaCapa, _
                                                       iCodigoEntradaItem, _
                                                       iCodigo)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Limpa Formulário
                    Call Novo()

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Carrega Grid
            Call oClsFatEntradaNF.LoadGridKITTmp(grdComposicao, _
                                                 lCodigoEntradaCapa, _
                                                 iCodigoEntradaItem, _
                                                 iCodigo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboComponenteOriginal.Text = ""
            cboComponenteOpcional.Text = ""
            txtLote.Text = ""
            txtLote.Enabled = False
            txtQuantidade.Value = 0
            btnInserir.Tag = ""

            'Seta Focu
            cboComponenteOriginal.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Controles
            cboComponenteOriginal.Text  = grdComposicao.CurrentRow.Cells("componente_original").Value
            cboComponenteOpcional.SelectedValue = grdComposicao.CurrentRow.Cells("codigo_item_opcional").Value
            txtLote.Text = grdComposicao.CurrentRow.Cells("lote").Value
            txtQuantidade.Value = grdComposicao.CurrentRow.Cells("quantidade").Value
            btnInserir.Tag = grdComposicao.CurrentRow.Cells("codigo").Value

            'Seta Focu
            cboComponenteOriginal.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Váriaveis 
            Dim lCodigoItemOpcional As Long = -1

            If cboComponenteOpcional.SelectedIndex <> -1 Then
                lCodigoItemOpcional = cboComponenteOpcional.SelectedValue.ToString.Split(";")(0)
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) = False Then

                'Insere Composição - KIT
                Call oClsFatEntradaNF.InsertKITTmp(lCodigoEntradaCapa, _
                                                   iCodigoEntradaItem, _
                                                   iCodigo, _
                                                   cboComponenteOriginal.SelectedValue.ToString.Split(";")(0), _
                                                   lCodigoItemOpcional, _
                                                   txtQuantidade.Value, _
                                                   txtLote.Text.Trim)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Atualiza Composição - KIT
                Call oClsFatEntradaNF.UpdateKITTmp(lCodigoEntradaCapa, _
                                                   iCodigoEntradaItem, _
                                                   iCodigo, _
                                                   cboComponenteOriginal.SelectedValue.ToString.Split(";")(0), _
                                                   lCodigoItemOpcional, _
                                                   txtQuantidade.Value, _
                                                   txtLote.Text.Trim, _
                                                   btnInserir.Tag)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Componente Original
            If ValidaCampo(cboComponenteOriginal, lblComponenteOriginal) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Componente Opcional
            If cboComponenteOpcional.Enabled = True Then
                If ValidaCampo(cboComponenteOriginal, lblComponenteOriginal) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade Informada é Válida
            If oClsFatEntradaNF.ValidateKITTmp(lCodigoEntradaCapa, _
                                               iCodigoEntradaItem, _
                                               iCodigo, _
                                               cboComponenteOriginal.SelectedValue.ToString.Split(";")(0), _
                                               txtQuantidade.Value,
                                               IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, -1)) = False Then
                frmMain.errInfo.SetError(lblQuantidade, "Divergência na Quantidade Informada.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Lote
            If txtLote.Enabled = True Then
                If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class