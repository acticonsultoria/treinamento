Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPrdApontamentoParada

#Region "::: VARIAVEIS :::"

    Private oClsPrdApontamento As New clsUsrPrdApontamento

    Private lCodigoOrdemProducao As Long
    Private iSequencia As Integer
    Private iSequenciaConcorrente As Integer
    Private iCodigoApontamentoFuncionario As Integer
    Private sOrdemProducao As String
    Private sCentroTrabalho As String
    Private sOperacao As String
    Private sDataInicio As String
    Private sDataTermino As String
    Private sFuncionario As String

#End Region

#Region "::: PROPERTIE :::"

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

    Public WriteOnly Property CodigoApontamentoFuncionario() As Integer
        Set(ByVal value As Integer)
            iCodigoApontamentoFuncionario = value
        End Set
    End Property

    Public WriteOnly Property OrdemProducao() As String
        Set(ByVal value As String)
            sOrdemProducao = value
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

    Public WriteOnly Property DataInicio() As String
        Set(ByVal value As String)
            sDataInicio = value
        End Set
    End Property

    Public WriteOnly Property DataTermino() As String
        Set(ByVal value As String)
            sDataTermino = value
        End Set
    End Property

    Public WriteOnly Property Funcionario() As String
        Set(ByVal value As String)
            sFuncionario = value
        End Set
    End Property

#End Region

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmPrdApontamentoParada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboMotivoParada" : Call LoadCombo(cboMotivoParada, "sp_select_combo_cadastro_basico_motivo_parada " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboMotivoParada" : Call btnCadastrarMotivoParada_Click(btnCadastrarMotivoParada, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmPrdApontamentoParada_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: APONTAMENTO - PARADA :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdApontamentoParada.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdApontamentoParada.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdApontamentoParada.GroupByBoxVisible = True
                grdApontamentoParada.HideColumnsWhenGrouped = InheritableBoolean.True
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
            oForm.Grid = grdApontamentoParada
            oForm.NomeFormulario = Formulario.ProducaoApontamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdApontamentoParada, Formulario.ProducaoApontamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMotivoParada_Click(sender As Object, e As EventArgs) Handles btnCadastrarMotivoParada.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMotivoParada")

            'Carrega Combo
            Call LoadCombo(cboMotivoParada, "sp_select_combo_cadastro_basico_motivo_parada " & goUsuario.iEmpresa, True)

            'Seta Focu
            cboMotivoParada.Focus()

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

            'Valida Dados do Apontamento
            If Validacao() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserir.Tag) Then

                    'Atualiza Registro
                    Call oClsPrdApontamento.UpdateApontamentoParada(lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    iCodigoApontamentoFuncionario, _
                                                                    btnInserir.Tag, _
                                                                    dtpDataParada.Value, _
                                                                    IIf(dtpDataReabertura.Checked = False, "", dtpDataReabertura.Value), _
                                                                    cboMotivoParada.SelectedValue)

                Else

                    'Insere Registro
                    Call oClsPrdApontamento.InsertApontamentoParada(lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    iCodigoApontamentoFuncionario, _
                                                                    dtpDataParada.Value, _
                                                                    IIf(dtpDataReabertura.Checked = False, "", dtpDataReabertura.Value), _
                                                                    cboMotivoParada.SelectedValue)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

                'Carrega Grid
                Call oClsPrdApontamento.LoadGridApontamentoParada(grdApontamentoParada, _
                                                                  lCodigoOrdemProducao, _
                                                                  iSequencia, _
                                                                  iSequenciaConcorrente, _
                                                                  iCodigoApontamentoFuncionario)

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

    Private Sub grdApontamentoParada_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdApontamentoParada.RowDoubleClick

        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdApontamentoParada.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdApontamentoParada.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamentoParada_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdApontamentoParada.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamentoParada.Name, _
                                     Formulario.ProducaoApontamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamentoParada_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdApontamentoParada.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamentoParada, _
                                     Formulario.ProducaoApontamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamentoParada_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdApontamentoParada.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdApontamentoParada.Name, _
                                          Formulario.ProducaoApontamento, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmPrdApontamentoParada_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadCombo(cboMotivoParada, "sp_select_combo_cadastro_basico_motivo_parada " & goUsuario.iEmpresa, False)

            'Carrega Controles
            txtOrdemProducao.Text = sOrdemProducao
            txtCentroTrabalho.Text = sCentroTrabalho
            txtOperacao.Text = sOperacao
            txtDataInicio.Text = sDataInicio
            txtDataTermino.Text = sDataTermino
            txtFuncionario.Text = sFuncionario

            'Seta Controle
            dtpDataParada.Value = Now
            dtpDataReabertura.Value = Now

            'Configura Grid
            Call ConfiguraGrid(grdApontamentoParada, Formulario.ProducaoApontamento)

            'Carrega Grid
            Call oClsPrdApontamento.LoadGridApontamentoParada(grdApontamentoParada, _
                                                              lCodigoOrdemProducao, _
                                                              iSequencia, _
                                                              iSequenciaConcorrente, _
                                                              iCodigoApontamentoFuncionario)

            'Seta Focu
            dtpDataParada.Focus()

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
            dtpDataParada.Value = Now
            dtpDataReabertura.Value = Now
            cboMotivoParada.SelectedIndex = -1 : cboMotivoParada.Enabled = False : btnCadastrarMotivoParada.Enabled = False
            btnInserir.Tag = ""

            'Seta Focu
            dtpDataParada.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Carrega Controle
            dtpDataParada.Value = grdApontamentoParada.CurrentRow.Cells("data_parada").Value
            If IsDBNull(grdApontamentoParada.CurrentRow.Cells("data_reabertura").Value) Then
                dtpDataReabertura.Value = Now
                dtpDataReabertura.Checked = False
            Else
                dtpDataReabertura.Value = grdApontamentoParada.CurrentRow.Cells("data_reabertura").Value
                dtpDataReabertura.Checked = True
            End If
            cboMotivoParada.SelectedValue = grdApontamentoParada.CurrentRow.Cells("codigo_motivo_parada").Value
            btnInserir.Tag = grdApontamentoParada.CurrentRow.Cells("codigo").Value

            'Seta Focu
            dtpDataParada.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdApontamentoParada) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui dados da Venda - Cliente
                    Call oClsPrdApontamento.DeleteApontamentoParada(lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    iCodigoApontamentoFuncionario)

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

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se a Data de Parada está entre a Data de Início e Término
            If dtpDataParada.Value < CDate(txtDataInicio.Text) AndAlso (IsDate(txtDataTermino.Text) = False OrElse (dtpDataParada.Value > CDate(txtDataTermino.Text))) Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Data de Parada não é Válida.")
                dtpDataParada.Focus()
                Exit Function
            End If

            'Verifica se a Data de Parada está entre a Data de Início e Término
            If dtpDataReabertura.Checked = True Then
                If dtpDataReabertura.Value < CDate(txtDataInicio.Text) AndAlso (IsDate(txtDataTermino.Text) = False OrElse (dtpDataReabertura.Value > CDate(txtDataTermino.Text))) AndAlso dtpDataReabertura.Value < dtpDataParada.Value Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Data de Parada não é Válida.")
                    dtpDataReabertura.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Motivo de Parada
            If ValidaCampo(cboMotivoParada, lblMotivoParada) = False Then
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
