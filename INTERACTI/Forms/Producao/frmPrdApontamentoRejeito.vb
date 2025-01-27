Imports Janus.Windows.GridEX

Public Class frmPrdApontamentoRejeito

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdApontamento As New clsUsrPrdApontamento
    Private lCodigoOrdemProducao As Long
    Private iSequencia As Integer
    Private iSequenciaConcorrente As Integer
    Private iCodigoApontamentoFuncionario As Integer
    Private iCodigoFuncionario As String
    Private iCodigoEquipamento As Integer
    Private sOrdemProducao As String
    Private sOperacao As String
    Private sCodigoProduto As String
    Private dQuantidadePlanejada As Double
    Private dQuantidadeProduzida As Double
    Private dQuantidadeRejeito As Double
    Private bAtualizaApontamento As Boolean = True
    Private bFlag As Boolean = False

#End Region

#Region "::: ENUM :::"

    Private Enum TipoApontamento
        Abertura = 1
        Parada = 2
        Reabertura = 3
        Fechamento = 4
    End Enum

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoOrdemProducao() As Long
        Get
            Return lCodigoOrdemProducao
        End Get
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

    Public Property Sequencia() As Integer
        Get
            Return iSequencia
        End Get
        Set(ByVal value As Integer)
            iSequencia = value
        End Set
    End Property

    Public Property SequenciaConcorrente() As Integer
        Get
            Return iSequenciaConcorrente
        End Get
        Set(ByVal value As Integer)
            iSequenciaConcorrente = value
        End Set
    End Property

    Public Property CodigoApontamentoFuncionario() As Integer
        Get
            Return iCodigoApontamentoFuncionario
        End Get
        Set(ByVal value As Integer)
            iCodigoApontamentoFuncionario = value
        End Set
    End Property

    Public Property CodigoFuncionario() As Integer
        Get
            Return iCodigoFuncionario
        End Get
        Set(ByVal value As Integer)
            iCodigoFuncionario = value
        End Set
    End Property

    Public Property CodigoEquipamento() As Integer
        Get
            Return iCodigoEquipamento
        End Get
        Set(ByVal value As Integer)
            iCodigoEquipamento = value
        End Set
    End Property

    Public Property OrdemProducao() As String
        Get
            Return sOrdemProducao
        End Get
        Set(ByVal value As String)
            sOrdemProducao = value
        End Set
    End Property

    Public Property Operacao() As String
        Get
            Return sOperacao
        End Get
        Set(ByVal value As String)
            sOperacao = value
        End Set
    End Property

    Public Property CodigoProduto() As String
        Get
            Return sCodigoProduto
        End Get
        Set(ByVal value As String)
            sCodigoProduto = value
        End Set
    End Property

    Public Property QuantidadePlanejada() As Double
        Get
            Return dQuantidadePlanejada
        End Get
        Set(ByVal value As Double)
            dQuantidadePlanejada = value
        End Set
    End Property

    Public Property QuantidadeProduzida() As Double
        Get
            Return dQuantidadeProduzida
        End Get
        Set(ByVal value As Double)
            dQuantidadeProduzida = value
        End Set
    End Property

    Public Property QuantidadeRejeito() As Double
        Get
            Return dQuantidadeRejeito
        End Get
        Set(ByVal value As Double)
            dQuantidadeRejeito = value
        End Set
    End Property

    Public Property AtualizaApontamento() As Boolean
        Get
            Return bAtualizaApontamento
        End Get
        Set(ByVal value As Boolean)
            bAtualizaApontamento = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmPrdApontamentoRejeito_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try

            If bFlag = False Then

                'Verifica se o Usuário Deseja Cancelar o Apontamento
                If MsgBox("Deseja perder os Dados do Apontamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Exclui Apontamento
                    Call oClsPrdApontamento.DeleteApontamentoManual(lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    iCodigoApontamentoFuncionario)

                Else

                    'Cancela o Fechamento
                    e.Cancel = True

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmPrdApontamentoRejeito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                             cboCodigoRejeito.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigoRejeito" : Call LoadCombo(cboCodigoRejeito, "sp_select_combo_cadastro_basico_rejeito " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCodigoRejeito" : Call btnCadastrarRejeito_Click(btnCadastrarRejeito, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmPrdApontamentoRejeito_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnCadastrarRejeito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarRejeito.Click

        Try

           'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadRejeito")

            'Carrega Combo
            Call LoadCombo(cboCodigoRejeito, "sp_select_combo_cadastro_basico_rejeito " & goUsuario.iEmpresa)
            'Seta Focu
            cboCodigoRejeito.Focus()

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
            If Validacao() = True Then

                'Insere Registro
                Call InsertRejeito(grdListagem, _
                                   cboCodigoRejeito.Text, _
                                   txtDescricao.Text.Trim, _
                                   txtQuantidade.Value, _
                                   txtObservacao.Text.Trim, _
                                   cboCodigoRejeito.SelectedValue)

                'Limpa Formulário
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registro
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try
            'Salva Formulário
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Close()

    End Sub

    Private Sub cboCodigoRejeito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoRejeito.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboCodigoRejeito.SelectedIndex = -1 Then
                txtDescricao.Text = ""
            Else
                LoadDescricao(txtDescricao, "sp_select_cadastro_basico_descricao_rejeito " & cboCodigoRejeito.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

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

            'Verifica Direito            
            btnInserir.Enabled = VerificaDireito(Formulario.ProducaoApontamento, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.ProducaoApontamento, gcDelete)
            'Verifica Direito - Cadastro
            btnCadastrarRejeito.Enabled = VerificaDireito(Formulario.CadastroBasicoRejeito, gcInsert)

            'Desabilita Controle
            btnSalvar.Enabled = False

            'Carrega Combo de Rejeito
            Call LoadCombo(cboCodigoRejeito, "sp_select_combo_cadastro_basico_rejeito " & goUsuario.iEmpresa)

            'Carrega Controles
            txtOrdemProducao.Text = sOrdemProducao
            txtOperacao.Text = sOperacao
            txtCodigoProduto.Text = sCodigoProduto
            txtQuantidadePlanejada.Value = dQuantidadePlanejada
            txtQuantidadeProduzida.Value = dQuantidadeProduzida
            txtQuantidadeRejeito.Value = dQuantidadeRejeito

            'Seta Focu
            cboCodigoRejeito.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ProducaoApontamento, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    cboCodigoRejeito.SelectedValue = .Item("codigo").Value
                    txtQuantidade.Value = .Item("quantidade").Value
                    txtObservacao.Text = .Item("observacao").Value
                    btnInserir.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboCodigoRejeito.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Dim i As Integer

                    For i = 0 To UBound(gSelecaoRow)
                        gSelecaoRow(i).Delete()
                    Next

                    'Limpa Controles
                    Call Novo()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCodigoRejeito.SelectedIndex = -1
            If grdListagem.GetTotalRow.Cells("quantidade").Value Is Nothing Then
                txtQuantidade.Value = txtQuantidadeRejeito.Value
            Else
                txtQuantidade.Value = txtQuantidadeRejeito.Value - grdListagem.GetTotalRow.Cells("quantidade").Value
                If txtQuantidade.Value = 0 Then
                    btnSalvar.Enabled = VerificaDireito(Formulario.ProducaoApontamento, gcInsert)
                Else
                    btnSalvar.Enabled = False
                End If
            End If
            txtObservacao.Text = ""
            btnInserir.Tag = ""

            'Seta Focu
            cboCodigoRejeito.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Verifica se o Usuário Confirma os Dados do Apontamento
            If MsgBox("Confirma os Dados do Apontamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                If bAtualizaApontamento = True Then

                    If goDatabase.sInitialCatalog = "INTERACTI_ISSARTEL_PRD" Then
                        'Atualiza Apontamento
                        Call oClsPrdApontamento.UpdateApontamento(5, _
                                                                  lCodigoOrdemProducao, _
                                                                  iSequencia, _
                                                                  iSequenciaConcorrente, _
                                                                  iCodigoApontamentoFuncionario, _
                                                                  -1, _
                                                                  iCodigoFuncionario, _
                                                                  -1, _
                                                                  iCodigoEquipamento, _
                                                                  -1, _
                                                                  dQuantidadePlanejada, _
                                                                  dQuantidadeProduzida, _
                                                                  dQuantidadeRejeito, _
                                                                  "")

                    Else
                        'Atualiza Apontamento
                        Call oClsPrdApontamento.UpdateApontamento(CInt(TipoApontamento.Fechamento), _
                                                                  lCodigoOrdemProducao, _
                                                                  iSequencia, _
                                                                  iSequenciaConcorrente, _
                                                                  iCodigoApontamentoFuncionario, _
                                                                  -1, _
                                                                  iCodigoFuncionario, _
                                                                  -1, _
                                                                  iCodigoEquipamento, _
                                                                  -1, _
                                                                  dQuantidadePlanejada, _
                                                                  dQuantidadeProduzida, _
                                                                  dQuantidadeRejeito,
                                                                  "")
                    End If

                    

                End If

                'Insere Registro de Rejeito
                Call oClsPrdApontamento.InsertApontamentoRejeito(lCodigoOrdemProducao, _
                                                                 iSequencia, _
                                                                 iSequenciaConcorrente, _
                                                                 grdListagem)

                'Seta Flag
                bFlag = True

                'Fecha o Formulário
                Me.Close()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Código do Rejeito
            If ValidaCampo(cboCodigoRejeito, lblCodigoRejeito) = False Then
                Exit Function
            End If

            'Verifica se o Código do Rejeito já existe na Grid
            If IsNumeric(btnInserir.Tag) Then
                If VerificaExisteValorGrid(grdListagem, "codigo", cboCodigoRejeito.SelectedValue, grdListagem.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblCodigoRejeito, "Este Rejeito já está incluso.")
                    cboCodigoRejeito.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdListagem, "codigo", cboCodigoRejeito.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblCodigoRejeito, "Este Rejeito já está incluso.")
                    cboCodigoRejeito.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            Else
                If IsNumeric(btnInserir.Tag) Then
                    If (grdListagem.GetTotalRow.Cells("quantidade").Value - _
                        grdListagem.CurrentRow.Cells("quantidade").Value + _
                        txtQuantidade.Value) > txtQuantidadeRejeito.Value Then
                        frmMain.errInfo.SetError(lblQuantidade, "A Soma dos Rejeitos é superior a Quantidade de Itens Rejeitados.")
                        txtQuantidade.Focus()
                        Exit Function
                    End If
                Else
                    If grdListagem.GetDataRows.Count = 0 Then
                        If txtQuantidade.Value > txtQuantidadeRejeito.Value Then
                            frmMain.errInfo.SetError(lblQuantidade, "A Soma dos Rejeitos é superior a Quantidade de Itens Rejeitados.")
                            txtQuantidade.Focus()
                            Exit Function
                        End If
                    Else
                        If (grdListagem.GetTotalRow.Cells("quantidade").Value + _
                            txtQuantidade.Value) > txtQuantidadeRejeito.Value Then
                            frmMain.errInfo.SetError(lblQuantidade, "A Soma dos Rejeitos é superior a Quantidade de Itens Rejeitados.")
                            txtQuantidade.Focus()
                            Exit Function
                        End If
                    End If
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub InsertRejeito(ByVal oGrid As GridEX, _
                              ByVal sCodigoRejeito As String, _
                              ByVal sDescricao As String, _
                              ByVal dQuantidade As Double, _
                              ByVal sObservacao As String, _
                              ByVal iCodigoRejeito As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCCodigoRejeito As New DataColumn("codigo_rejeito")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCObservacao As New DataColumn("observacao")
            Dim oDCCodigo As New DataColumn("codigo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCodigoRejeito)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCObservacao)
                oDataTable.Columns.Add(oDCCodigo)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("codigo_rejeito") = sCodigoRejeito
                oDataRow("descricao") = sDescricao
                oDataRow("quantidade") = dQuantidade
                oDataRow("observacao") = sObservacao
                oDataRow("codigo") = iCodigoRejeito
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & btnInserir.Tag & ")")(0)
                oDataRow("codigo_rejeito") = sCodigoRejeito
                oDataRow("descricao") = sDescricao
                oDataRow("quantidade") = dQuantidade
                oDataRow("observacao") = sObservacao
                oDataRow("codigo") = iCodigoRejeito
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
