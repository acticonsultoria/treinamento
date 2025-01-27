Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPrdApontamentoParadaManual

#Region "::: VARIAVEIS :::"

    Private oClsPrdApontamento As New clsUsrPrdApontamento

    Private lCodigoOrdemProducao As Long
    Private iSequencia As Integer
    Private iSequenciaConcorrente As Integer
    Private iCodigoApontamentoFuncionario As Integer
    Private sOrdemProducao As String
    Private sCentroTrabalho As String
    Private sOperacao As String
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

    Public WriteOnly Property Funcionario() As String
        Set(ByVal value As String)
            sFuncionario = value
        End Set
    End Property

#End Region

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmPrdApontamentoParadaManual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboMotivoParada" : Call LoadCombo(cboMotivoParada, "sp_select_combo_cadastro_basico_motivo_parada " & goUsuario.iEmpresa, False)
                        Case "cboGrupoMotivoParada" : Call LoadCombo(cboGrupoMotivoParada, "sp_select_combo_cadastro_basico_grupo_motivo_parada " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboGrupoMotivoParada" : Call btnCadastrarGrupoMotivoParada_Click(btnCadastrarGrupoMotivoParada, System.EventArgs.Empty)
                        Case "cboMotivoParada" : Call btnCadastrarMotivoParada_Click(btnCadastrarMotivoParada, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmPrdApontamentoParadaManual_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnCadastrarGrupoMotivoParada_Click(sender As Object, e As EventArgs) Handles btnCadastrarGrupoMotivoParada.Click

        Try

           'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoMotivoParada")

            'Carrega Combo
            Call LoadCombo(cboGrupoMotivoParada, "sp_select_combo_cadastro_basico_grupo_motivo_parada " & goUsuario.iEmpresa, True)

            'Seta Focu
            cboGrupoMotivoParada.Focus()

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
                    Call oClsPrdApontamento.UpdateApontamentoParadaManual(lCodigoOrdemProducao, _
                                                                          iSequencia, _
                                                                          iSequenciaConcorrente, _
                                                                          iCodigoApontamentoFuncionario, _
                                                                          btnInserir.Tag, _
                                                                          ((DatePart(DateInterval.Hour, CDate(txtTempoParada.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoParada.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoParada.Text)) / 60)), _
                                                                          cboMotivoParada.SelectedValue)

                Else

                    'Insere Registro
                    Call oClsPrdApontamento.InsertApontamentoParadaManual(lCodigoOrdemProducao, _
                                                                          iSequencia, _
                                                                          iSequenciaConcorrente, _
                                                                          iCodigoApontamentoFuncionario, _
                                                                          ((DatePart(DateInterval.Hour, CDate(txtTempoParada.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoParada.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoParada.Text)) / 60)), _
                                                                          cboMotivoParada.SelectedValue)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

                'Carrega Grid
                Call oClsPrdApontamento.LoadGridApontamentoParadaManual(grdApontamentoParada, _
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

    Private Sub cboGrupoMotivoParada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoMotivoParada.SelectedIndexChanged

        Try

            'Limpa Combo
            cboMotivoParada.DataSource = Nothing : cboMotivoParada.Text = ""

            'Verifica se foi Selecionado Algum Registro
            If cboGrupoMotivoParada.SelectedIndex > -1 Then
                'Carrega Combo
                Call LoadCombo(cboMotivoParada, "sp_select_combo_cadastro_basico_motivo_parada " & goUsuario.iEmpresa & ", " & cboGrupoMotivoParada.SelectedValue, False)
            End If

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmPrdApontamentoParadaManual_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboGrupoMotivoParada, "sp_select_combo_cadastro_basico_grupo_motivo_parada " & goUsuario.iEmpresa, False)
            cboMotivoParada.DataSource = Nothing

            'Carrega Controles
            txtOrdemProducao.Text = sOrdemProducao
            txtCentroTrabalho.Text = sCentroTrabalho
            txtOperacao.Text = sOperacao
            txtFuncionario.Text = sFuncionario

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.ProducaoApontamentoManual, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.ProducaoApontamentoManual, gcDelete)

            'Verifica Direito - Controles
            btnCadastrarGrupoMotivoParada.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoMotivoParada, gcInsert)
            btnCadastrarMotivoParada.Enabled = VerificaDireito(Formulario.CadastroBasicoMotivoParada, gcInsert)

            'Configura Grid
            Call ConfiguraGrid(grdApontamentoParada, Formulario.ProducaoApontamento)

            'Carrega Grid
            Call oClsPrdApontamento.LoadGridApontamentoParadaManual(grdApontamentoParada, _
                                                                    lCodigoOrdemProducao, _
                                                                    iSequencia, _
                                                                    iSequenciaConcorrente, _
                                                                    iCodigoApontamentoFuncionario)

            'Seta Focu
            txtTempoParada.Focus()

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
            txtTempoParada.Text = "00:00:00"
            cboGrupoMotivoParada.SelectedIndex = -1 : cboGrupoMotivoParada.Text = ""
            cboMotivoParada.SelectedIndex = -1 : cboMotivoParada.Text = ""
            btnInserir.Tag = ""

            'Seta Focu
            txtTempoParada.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Carrega Controle
            txtTempoParada.Text = grdApontamentoParada.CurrentRow.Cells("tempo_parada").Value
            cboGrupoMotivoParada.SelectedValue = grdApontamentoParada.CurrentRow.Cells("codigo_grupo_motivo_parada").Value
            cboMotivoParada.SelectedValue = grdApontamentoParada.CurrentRow.Cells("codigo_motivo_parada").Value
            btnInserir.Tag = grdApontamentoParada.CurrentRow.Cells("codigo").Value

            'Seta Focu
            txtTempoParada.Focus()

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
                    Call oClsPrdApontamento.DeleteApontamentoParadaManual(lCodigoOrdemProducao, _
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
            If ValidaCampo(txtTempoParada, lblTempoParada, TipoCampo.data) = False Then
                txtTempoParada.Focus()
                Exit Function
            ElseIf Second(txtTempoParada.Text) > 0 Or Minute(txtTempoParada.Text) > 0 Or Hour(txtTempoParada.Text) > 0 Then
                frmMain.errInfo.SetError(lblTempoParada, "O Campo [Tempo Parada] deve ser preenchido com algum Tempo. Digite um Tempo válido para ele.")
                txtTempoParada.Focus()
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
