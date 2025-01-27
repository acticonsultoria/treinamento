Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPrdApontamentoManual

#Region "::: VARIAVEIS :::"

    Private oClsPrdApontamento As New clsUsrPrdApontamento

    Private lCodigoOrdemProducao As Long
    Private iSequencia As Integer
    Private iSequenciaConcorrente As Integer
    Private sOrdemProducao As String
    Private sProduto As String
    Private sCentroTrabalho As String
    Private sOperacao As String

#End Region

#Region "::: PROPERTIES :::"

#Region "::: DADOS GERAIS :::"

    Public WriteOnly Property CodigoOrdemProducao() As Long
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

    Public WriteOnly Property Sequencia() As Integer
        Set(ByVal value As Integer)
            iSequencia = value
        End Set
    End Property

    Public WriteOnly Property SequenciaConcorrente() As Integer
        Set(ByVal value As Integer)
            iSequenciaConcorrente = value
        End Set
    End Property

    Public WriteOnly Property OrdemProducao() As String
        Set(ByVal value As String)
            sOrdemProducao = value
        End Set
    End Property

    Public WriteOnly Property Produto() As String
        Set(ByVal value As String)
            sProduto = value
        End Set
    End Property

    Public WriteOnly Property CentroTrabalho() As String
        Set(ByVal value As String)
            sCentroTrabalho = value
        End Set
    End Property

    Public WriteOnly Property Operacao() As String
        Set(ByVal value As String)
            sOperacao = value
        End Set
    End Property

#End Region

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmPrdApontamentoManual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmPrdApontamentoManual_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: APONTAMENTO - MANUAL :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdApontamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdApontamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdApontamento.GroupByBoxVisible = True
                grdApontamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdApontamento
            oForm.NomeFormulario = Formulario.ProducaoApontamentoManual
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoApontamentoManual)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFuncionario_Click(sender As Object, e As EventArgs) Handles btnCadastrarFuncionario.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadFuncionario")

            'Carrega Combo
            Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, True)

            'Seta Focu
            cboFuncionario.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFuncionario.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboFuncionario.SelectedIndex > -1 Then

                'Carrega Turno
                Dim iCodigoTurno As Integer = -1
                iCodigoTurno = CType(LoadDescricao("sp_select_cadastro_basico_funcionario_turno " & cboFuncionario.SelectedValue & ", " & goUsuario.iEmpresa), Integer)
                If iCodigoTurno > -1 Then cboTurno.SelectedValue = iCodigoTurno

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inicio de Coleta
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Váriaveis Locais
            Dim iCodigo As Integer = 0

            'Valida Dados do Apontamento
            If Validacao() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserir.Tag) Then

                    'Atualiza Registro
                    Call oClsPrdApontamento.UpdateApontamentoManual(lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    grdApontamento.CurrentRow.Cells("codigo").Value, _
                                                                    dtpData.Value, _
                                                                    ((DatePart(DateInterval.Hour, CDate(txtTempo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempo.Text)) + (DatePart(DateInterval.Second, CDate(txtTempo.Text)) / 60)), _
                                                                    cboFuncionario.SelectedValue, _
                                                                    cboTurno.SelectedValue, _
                                                                    txtQuantidadeProduzida.Value, _
                                                                    txtQuantidadeRejeito.Value)

                    iCodigo = grdApontamento.CurrentRow.Cells("codigo").Value

                Else

                    'Insere Registro
                    Call oClsPrdApontamento.InsertApontamentoManual(lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    dtpData.Value, _
                                                                    ((DatePart(DateInterval.Hour, CDate(txtTempo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempo.Text)) + (DatePart(DateInterval.Second, CDate(txtTempo.Text)) / 60)), _
                                                                    cboFuncionario.SelectedValue, _
                                                                    cboTurno.SelectedValue, _
                                                                    txtQuantidadeProduzida.Value, _
                                                                    txtQuantidadeRejeito.Value, _
                                                                    iCodigo)

                End If

                If txtQuantidadeRejeito.Value > 0 AndAlso (IsNumeric(btnInserir.Tag) = False OrElse txtQuantidadeRejeito.Value <> grdApontamento.CurrentRow.Cells("quantidade_rejeito").Value) Then

                    'Variavel - Formulário
                    Dim oForm As New frmPrdApontamentoRejeito

                    'Seta Tamanho / Posição do Formulário
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

                    'Seta Parâmetros
                    oForm.CodigoOrdemProducao = lCodigoOrdemProducao
                    oForm.Sequencia = iSequencia
                    oForm.SequenciaConcorrente = iSequenciaConcorrente
                    oForm.CodigoApontamentoFuncionario = iCodigo
                    oForm.CodigoFuncionario = cboFuncionario.SelectedValue
                    oForm.CodigoEquipamento = -1
                    oForm.OrdemProducao = txtOrdemProducao.Text
                    oForm.CodigoProduto = txtProduto.Text
                    oForm.QuantidadePlanejada = txtQuantidadeProduzida.Value + txtQuantidadeRejeito.Value
                    oForm.QuantidadeProduzida = txtQuantidadeProduzida.Value
                    oForm.QuantidadeRejeito = txtQuantidadeRejeito.Value
                    oForm.AtualizaApontamento = False

                    'Abre o Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

1:              'Carrega Grid
                Call oClsPrdApontamento.LoadGridApontamentoManual(grdApontamento, _
                                                                  lCodigoOrdemProducao, _
                                                                  iSequencia, _
                                                                  iSequenciaConcorrente)

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

            'Deleta Apontamento
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdApontamento.RowDoubleClick

        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdApontamento.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdApontamento.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "apontamento_parada" : Call ApontamentoParada()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdApontamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento.Name, _
                                     Formulario.ProducaoApontamentoManual, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdApontamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento, _
                                     Formulario.ProducaoApontamentoManual)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdApontamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdApontamento.Name, _
                                          Formulario.ProducaoApontamentoManual, _
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

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmPrdApontamentoManual_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTurno, "sp_select_combo_cadastro_basico_turno " & goUsuario.iEmpresa, False)

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.ProducaoApontamentoManual, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.ProducaoApontamentoManual, gcDelete)
            btnCadastrarFuncionario.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcInsert)

            'Carrega Controles
            txtOrdemProducao.Text = sOrdemProducao
            txtProduto.Text = sProduto
            txtCentroTrabalho.Text = sCentroTrabalho
            txtOperacao.Text = sOperacao

            'Limpa Controles
            Call Novo()

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoApontamentoManual)

            'Carrega Grid
            Call oClsPrdApontamento.LoadGridApontamentoManual(grdApontamento, _
                                                              lCodigoOrdemProducao, _
                                                              iSequencia, _
                                                              iSequenciaConcorrente)

            'Seta Focu
            dtpData.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            dtpData.Value = Now.Date
            txtTempo.Text = "00:00:00"
            cboFuncionario.SelectedIndex = -1
            cboTurno.SelectedIndex = -1
            txtQuantidadeProduzida.Value = 0
            txtQuantidadeRejeito.Value = 0
            btnInserir.Tag = ""

            'Seta Focu
            dtpData.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Carrega Controle
            dtpData.Value = grdApontamento.CurrentRow.Cells("data").Value
            txtTempo.Text = grdApontamento.CurrentRow.Cells("tempo").Value
            cboFuncionario.SelectedValue = grdApontamento.CurrentRow.Cells("codigo_funcionario").Value
            cboTurno.SelectedValue = grdApontamento.CurrentRow.Cells("codigo_turno").Value
            txtQuantidadeProduzida.Value = grdApontamento.CurrentRow.Cells("quantidade_produzida").Value
            txtQuantidadeRejeito.Value = grdApontamento.CurrentRow.Cells("quantidade_rejeito").Value
            btnInserir.Tag = grdApontamento.CurrentRow.Cells("codigo").Value

            'Seta Focu
            dtpData.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdApontamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui dados da Venda - Cliente
                    Call oClsPrdApontamento.DeleteApontamentoManual(lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente)

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

    Private Sub ApontamentoParada()

        Try

            'Váriaveis Locais
            Dim oForm As New frmPrdApontamentoParadaManual

            'Seta Parâmetros
            oForm.CodigoOrdemProducao = lCodigoOrdemProducao
            oForm.Sequencia = iSequencia
            oForm.SequenciaConcorrente = iSequenciaConcorrente
            oForm.CodigoApontamentoFuncionario = grdApontamento.CurrentRow.Cells("codigo").Value
            oForm.OrdemProducao = sOrdemProducao
            oForm.CentroTrabalho = sCentroTrabalho
            oForm.Operacao = sOperacao
            oForm.Funcionario = grdApontamento.CurrentRow.Cells("funcionario").Value

            'Abre Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Tempo
            If ValidaCampo(txtTempo, lblTempo, TipoCampo.data) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Funcionário
            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Turno
            If ValidaCampo(cboTurno, lblTurno) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade Produzida
            If ValidaCampo(txtQuantidadeProduzida, lblQuantidadeProduzida, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade Rejeito
            If ValidaCampo(txtQuantidadeRejeito, lblQuantidadeRejeito, False) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
