Imports Janus.Windows.GridEX

Public Class usrEstMovimentacaoManual

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstTransferenciaDeposito As New clsUsrEstTransferenciaDeposito

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEstMovimentacaoManual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name


                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboDepositoDestino" : Call btnCadastrarDeposito_Click(btnCadastrarDeposito, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstMovimentacaoManual_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnCadastrarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDeposito.Click

        Try

             'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDeposito")

            'Carrega Combo
            LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemEstoqueFind = "S"
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

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoProduto() = True Then

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()

                'Seta Focu
                cboCodigoProduto.Focus()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa dados da Capa
            Call Novo()
            
            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erros
            frmMain.errInfo.Clear()

            'Valida dados
            If ValidacaoCapa() = True Then

                'Salva Dados
                Call Salvar()

                'Desabilita Controles
                btnInserir.Enabled = False
                btnExcluir.Enabled = False
                btnSalvar.Enabled = False

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboCodigoProduto.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricao.Text = ""
            Else
                txtDescricao.Text = LoadDescricao("sp_select_cadastro_basico_descricao_item " & cboCodigoProduto.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual operação foi Selecionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, NULL, 1, NULL, NULL", False)
            Call LoadCombo(cboTipoMovimentacao, "sp_select_combo_static_tipo_movimentacao_estoque ")

            'Seta Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueMovimentacaoManual, gcInsert)
            btnInserir.Enabled = VerificaDireito(Formulario.EstoqueMovimentacaoManual, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.EstoqueMovimentacaoManual, gcDelete)

            'Seta Focu
            txtNumeroDocumento.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MOVIMENTAÇÃO :::"

    Private Sub Salvar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Obtem Número do Documento
            txtNumeroDocumento.Text = oClsEstTransferenciaDeposito.LoadNumeroDocumento

            'Salva Dados

            'Informa o Usuário sobre o sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroInserido)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        'Variaveis Locais
        Dim i As Integer

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    For i = 0 To UBound(gSelecaoRow)
                        'Deleta Linha
                        gSelecaoRow(i).Delete()
                    Next

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

            'Limpa Controles
            txtNumeroDocumento.Text = ""
            txtDescritivo.Text = ""
            cboTipoMovimentacao.Text = ""
            dtpDataMovimentacao.Value = Now.Date

            'Limpa Controles - Produto
            cboCodigoProduto.Text = ""
            txtDescricao.Text = ""
            txtLote.Text = ""
            cboDeposito.Text = ""
            txtQuantidade.Value = 0
            btnInserir.Tag = ""
            grdListagem.DataSource = Nothing

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Public Sub SalvarProduto()

        Try


        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Sai do Formulário
            If btnSalvar.Enabled = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Sub
            End If

            'Verifica se o Usuário tem direito
            If VerificaDireito(Formulario.EstoqueMovimentacaoManual, gcUpdate) = True Then

                'Limpa Erro
                frmMain.errInfo.Clear()

                With grdListagem.CurrentRow.Cells

                    cboCodigoProduto.SelectedValue = .Item("codigo").Value
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    txtQuantidade.Value = .Item("quantidade").Value
                    btnInserir.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboCodigoProduto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoProduto()

        Try

            'Limpa Controles
            cboCodigoProduto.Text = ""
            txtDescricao.Text = ""
            txtLote.Text = ""
            cboDeposito.Text = ""
            txtQuantidade.Value = 0
            btnInserir.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Selecionado o Campo - Código de Referência
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Depósito Destino
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade é Válida
            Dim iRow As Integer = -1
            If IsNumeric(btnInserir.Tag) Then
                iRow = grdListagem.CurrentRow.RowIndex
            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Function ValidacaoCapa() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCapa = False

            'Verifica se foi inserido alguma Linha
            If grdListagem.GetDataRows.Count <= 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir)
                Exit Function
            End If

            'Variaveis Locais
            Dim i As Integer
            Dim oRow() As GridEXRow

            'Obtem Linhas
            oRow = grdListagem.GetDataRows

            'For i = 0 To UBound(oRow)
            '    'Verifica se a Quantidade é Válida
            '    If oClsEstTransferenciaDeposito.LoadQuantidadeEstoque(oRow(i).Cells("codigo").Value, _
            '                                                          oRow(i).Cells("lote").Value, _
            '                                                          cboDepositoOrigem.SelectedValue) - _
            '                                                          (QuantidadeTotalLancado(oRow(i).Cells("codigo").Value, _
            '                                                                                  oRow(i).Cells("lote").Value, _
            '                                                                                  oRow(i).RowIndex) + oRow(i).Cells("quantidade").Value) < 0 Then
            '        frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            '        Exit Function
            '    End If
            'Next

            'Seta Retorno da Função
            ValidacaoCapa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function QuantidadeTotalLancado(ByVal lCodigoItem As Long, _
                                            ByVal sLote As String, _
                                            ByVal iRow As Integer) As Double

        Try

            'Váriaveis Locais
            Dim i As Integer
            Dim dReturn As Double
            Dim oRow() As GridEXRow

            'Obtem Linhas
            oRow = grdListagem.GetDataRows

            For i = 0 To UBound(oRow)

                'Verifica se o Item ja foi Lançado
                If oRow(i).Cells("codigo").Value = lCodigoItem And oRow(i).Cells("lote").Value = sLote Then

                    If iRow <> oRow(i).RowIndex Then
                        dReturn += oRow(i).Cells("quantidade").Value
                    End If

                End If

            Next

            Return dReturn

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class

