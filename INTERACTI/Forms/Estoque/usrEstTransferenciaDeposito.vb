Imports Janus.Windows.GridEX

Public Class usrEstTransferenciaDeposito

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstTransferenciaDeposito As New clsUsrEstTransferenciaDeposito

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEstTransferenciaDeposito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                                cboDepositoOrigem.KeyUp, _
                                                                                                                                cboDepositoDestino.KeyUp, _
                                                                                                                                cboCodigoProduto.KeyUp

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

                        Case "cboDespositoOrigem" : Call LoadCombo(cboDepositoOrigem, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                        Case "cboCodigoProduto"
                            If cboDepositoOrigem.SelectedIndex > -1 Then
                                Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item_estoque_deposito " & cboDepositoOrigem.SelectedValue & ", " & goUsuario.iEmpresa)
                            End If                            
                        Case "cboDespositoDestino"
                            If cboDepositoOrigem.SelectedIndex > -1 Then
                                Call LoadCombo(cboDepositoDestino, "sp_select_combo_cadastro_basico_deposito_diferente " & cboDepositoOrigem.SelectedValue & ", " & goUsuario.iEmpresa)
                            End If

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboDepositoOrigem" : Call btnCadastrarDeposito_Click(btnCadastrarDepositoOrigem, System.EventArgs.Empty)
                        Case "cboDepositoDestino" : Call btnCadastrarDeposito_Click(btnCadastrarDepositoDestino, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstTransferenciaDeposito_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrEstTransferenciaDeposito_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnCadastrarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDepositoOrigem.Click, _
                                                                                                               btnCadastrarDepositoDestino.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDeposito")

            'Seta Focu
            Select Case sender.Name

                Case "btnCadastrarDepositoOrigem"
                    LoadCombo(cboDepositoOrigem, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                    cboDepositoOrigem.Focus()

                Case "btnCadastrarDepositoDestino"
                    If cboDepositoOrigem.SelectedIndex > -1 Then
                        Call LoadCombo(cboDepositoDestino, "sp_select_combo_cadastro_basico_deposito_diferente " & cboDepositoOrigem.SelectedValue & ", " & goUsuario.iEmpresa)
                    End If
                    cboDepositoDestino.Focus()

            End Select

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
            If ValidacaoLinha() = True Then

                'Salva Dados do Registro
                Call InsertItem(grdListagem, _
                                cboCodigoProduto.Text, _
                                txtDescricao.Text.Trim, _
                                cboLote.Text, _
                                cboDepositoDestino.Text, _
                                txtQuantidade.Value, _
                                cboCodigoProduto.SelectedValue, _
                                cboDepositoDestino.SelectedValue, _
                                txtLocalizacao.Text, _
                                IIf(IsNumeric(btnInserir.Tag), "U", "I"), _
                                IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, 0), _
                                IIf(IsNumeric(btnInserir.Tag), cboLote.Tag, 0))

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoLinha()

                'Seta Focu
                cboCodigoProduto.Focus()

                'Trava Controles
                cboDepositoOrigem.Enabled = False

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
            Call NovoCapa()
            'Limpa dados da Linha
            Call NovoLinha()

            'Seta Focu
            cboDepositoOrigem.Focus()

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

    Private Sub cboDepositoOrigem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepositoOrigem.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboDepositoOrigem.SelectedIndex = -1 Then
                cboCodigoProduto.DataSource = Nothing
                cboDepositoDestino.DataSource = Nothing
            Else
                'Carrega Combo de Depósito
                Call LoadCombo(cboDepositoDestino, "sp_select_combo_cadastro_basico_deposito_diferente " & cboDepositoOrigem.SelectedValue & ", " & goUsuario.iEmpresa)
                'Carrega Combo de Item
                Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item_estoque_deposito " & cboDepositoOrigem.SelectedValue & ", " & goUsuario.iEmpresa)
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
                cboLote.DataSource = Nothing : cboLote.Text = "" : cboLote.Enabled = False
            Else
                oClsEstTransferenciaDeposito.LoadControles(cboCodigoProduto.SelectedValue, _
                                                           cboDepositoOrigem.SelectedValue, _
                                                           cboDepositoDestino.SelectedValue, _
                                                           txtSaldoOrigem, _
                                                           txtSaldoDestino, _
                                                           txtLocalizacao)

                txtDescricao.Text = LoadDescricao("sp_select_cadastro_basico_descricao_item " & cboCodigoProduto.SelectedValue & ", " & goUsuario.iEmpresa)
                cboLote.Enabled = ControlaLote(cboCodigoProduto.SelectedValue)
                If cboLote.Enabled = True Then
                    Call LoadCombo(cboLote, "sp_select_combo_cadastro_basico_item_lote " & cboDepositoOrigem.SelectedValue & ", " & cboCodigoProduto.SelectedValue & ", " & goUsuario.iEmpresa)
                Else
                    cboLote.SelectedIndex = -1
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica qual operação foi Selecionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega ComboBox
            Call LoadCombo(cboDepositoOrigem, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)

            'Seta Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueTransferenciaDeposito, gcInsert)
            btnInserir.Enabled = VerificaDireito(Formulario.EstoqueTransferenciaDeposito, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.EstoqueTransferenciaDeposito, gcDelete)

            'Seta Focu
            cboDepositoOrigem.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Obtem Número do Documento
            txtNumeroDocumento.Text = oClsEstTransferenciaDeposito.LoadNumeroDocumento

            'Salva Dados
            oClsEstTransferenciaDeposito.Salvar(grdListagem, _
                                                txtNumeroDocumento.Text, _
                                                cboDepositoOrigem.SelectedValue, _
                                                txtObservacao.Text.Trim)

            'Informa o Usuário sobre o sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroInserido)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertItem(ByVal oGrid As GridEX, _
                          ByVal sCodigoItem As String, _
                          ByVal sDescricao As String, _
                          ByVal sLote As String, _
                          ByVal sDeposito As String, _
                          ByVal dQuantidade As Double, _
                          ByVal lCodigoItem As Long, _
                          ByVal iCodigoDeposito As Integer, _
                          ByVal sLocalizacao As String, _
                          ByVal sTipoOperacao As String, _
                          ByVal lCodigoItemAntigo As Long, _
                          ByVal sLoteAntigo As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCCodigoItem As New DataColumn("codigo_item")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCLote As New DataColumn("lote")
            Dim oDCLocalizacao As New DataColumn("localizacao")
            Dim oDCDeposito As New DataColumn("deposito")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCCodigo As New DataColumn("codigo")
            Dim oDCCodigoDeposito As New DataColumn("codigo_deposito")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCodigoItem)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCLote)
                oDataTable.Columns.Add(oDCLocalizacao)
                oDataTable.Columns.Add(oDCDeposito)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCCodigo)
                oDataTable.Columns.Add(oDCCodigoDeposito)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If sTipoOperacao = "I" Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("codigo_item") = sCodigoItem
                oDataRow("descricao") = sDescricao
                oDataRow("lote") = sLote
                oDataRow("localizacao") = sLocalizacao
                oDataRow("deposito") = sDeposito
                oDataRow("quantidade") = dQuantidade
                oDataRow("codigo") = lCodigoItem
                oDataRow("codigo_deposito") = iCodigoDeposito
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & lCodigoItemAntigo & ") AND (lote = '" & sLoteAntigo & "')")(0)
                oDataRow("codigo_item") = sCodigoItem
                oDataRow("descricao") = sDescricao
                oDataRow("lote") = sLote
                oDataRow("localizacao") = sLocalizacao
                oDataRow("deposito") = sDeposito
                oDataRow("quantidade") = dQuantidade
                oDataRow("codigo") = lCodigoItem
                oDataRow("codigo_deposito") = iCodigoDeposito
            End If

            'Preenche Grid
            With oGrid

                .RootTable.Columns.Item("codigo_item").DataMember = "codigo_item"
                .RootTable.Columns.Item("descricao").DataMember = "descricao"
                .RootTable.Columns.Item("lote").DataMember = "lote"
                .RootTable.Columns.Item("localizacao").DataMember = "localizacao"
                .RootTable.Columns.Item("deposito").DataMember = "deposito"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("codigo").DataMember = "codigo"
                .RootTable.Columns.Item("codigo_deposito").DataMember = "codigo_deposito"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch ex As Exception
            'Trata Erro
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

    Private Sub Editar()

        Try

            'Sai do Formulário
            If btnSalvar.Enabled = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Sub
            End If

            'Verifica se o Usuário tem direito
            If VerificaDireito(Formulario.EstoqueTransferenciaDeposito, gcUpdate) = True Then

                'Limpa Erro
                frmMain.errInfo.Clear()

                With grdListagem.CurrentRow.Cells

                    cboCodigoProduto.SelectedValue = .Item("codigo").Value
                    cboLote.SelectedValue = .Item("lote").Value
                    txtLocalizacao.Text = .Item("localizacao").Value
                    cboLote.Tag = .Item("lote").Value
                    cboDepositoDestino.SelectedValue = .Item("codigo_deposito").Value
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

    Private Sub NovoCapa()

        Try

            'Limpa Controles
            cboDepositoOrigem.SelectedIndex = -1
            txtObservacao.Text = ""
            cboDepositoOrigem.Enabled = True
            'Limpa Grid
            grdListagem.DataSource = Nothing

            'Abilita Controles
            btnInserir.Enabled = True
            btnExcluir.Enabled = True
            btnSalvar.Enabled = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoLinha()

        Try

            'Limpa Controles
            cboCodigoProduto.SelectedIndex = -1
            cboCodigoProduto.Text = ""
            cboLote.Text = ""
            cboLote.Tag = ""
            txtSaldoDestino.Value =
                txtLocalizacao.Text = ""
            txtSaldoOrigem.Value = 0
            txtQuantidade.Value = 0
            btnInserir.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCapa() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCapa = False

            'Verifica se foi Selecionado o Campo - Depósito de Origem
            If ValidaCampo(cboDepositoOrigem, lblDepositoOrigem) = False Then
                Exit Function
            End If

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

            For i = 0 To UBound(oRow)
                'Verifica se a Quantidade é Válida
                If oClsEstTransferenciaDeposito.LoadQuantidadeEstoque(oRow(i).Cells("codigo").Value, _
                                                                      oRow(i).Cells("lote").Value, _
                                                                      cboDepositoOrigem.SelectedValue) - _
                                                                      (QuantidadeTotalLancado(oRow(i).Cells("codigo").Value, _
                                                                                              oRow(i).Cells("lote").Value, _
                                                                                              oRow(i).RowIndex) + oRow(i).Cells("quantidade").Value) < 0 Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                    Exit Function
                End If
            Next

            'Seta Retorno da Função
            ValidacaoCapa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoLinha() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoLinha = False

            'Verifica se foi Selecionado o Campo - Código de Referência
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Lote
            If cboLote.Enabled = True Then
                If ValidaCampo(cboLote, lblLote) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Depósito Destino
            If ValidaCampo(cboDepositoDestino, lblDepositoDestino) = False Then
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

            If oClsEstTransferenciaDeposito.LoadQuantidadeEstoque(cboCodigoProduto.SelectedValue, _
                                                                  IIf(cboLote.Enabled = False, "", cboLote.SelectedValue), _
                                                                  cboDepositoOrigem.SelectedValue) - _
                                                                  (QuantidadeTotalLancado(cboCodigoProduto.SelectedValue, _
                                                                                          IIf(cboLote.Enabled = False, "", cboLote.SelectedValue), _
                                                                                          iRow) + _
                                                                                          txtQuantidade.Value) < 0 Then
                frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada é maior que a Quantidade em Estoque. Preencha um valor válido para ela.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoLinha = True

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

