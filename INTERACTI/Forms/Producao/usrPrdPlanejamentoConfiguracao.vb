Imports INTERACTI.modDeclaration
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Org.BouncyCastle.Math

Public Class usrPrdPlanejamentoConfiguracao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdPlanejamentoConfiguracao As New clsUsrPrdPlanejamentoConfiguracao
    Dim iFormulario As Integer = -1

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    'If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub ColumnMoved(sender As Object, e As ColumnActionEventArgs) Handles grdConfiguracaoOP.ColumnMoved, grdCentroTrabalho.ColumnMoved
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub SizingColumn(sender As Object, e As SizingColumnEventArgs) Handles grdConfiguracaoOP.SizingColumn, grdCentroTrabalho.SizingColumn
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click, btnSair2.Click, btnSair1.Click, btnSair3.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click, btnAtualizar2.Click, btnAtualizar1.Click, btnAtualizar3.Click
        Try

            LoadGridConfigOP()
            LoadGridManutencao()
            LoadGridCentroTrabalho()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub tabMain_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabMain.SelectedTabChanged
        Try

            LoadDadosAba()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub grd_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdConfiguracaoOP.CellUpdated


        Try

            oClsPrdPlanejamentoConfiguracao.UpdateConfiguracaoOP(sender.CurrentRow)

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


    Private Sub LostFocusConfiguracaoGeral(sender As Object, e As EventArgs) Handles cboPriorizacao.LostFocus,
                                                                                     txtLeadTimeEstoque.LostFocus,
                                                                                     txtLeadTimeProducao.LostFocus,
                                                                                     txtLeadTimeMetrologia.LostFocus,
                                                                                     txtTempoSetupUltrapassado.LostFocus,
                                                                                     txtTempoMotivoParadaGrande.LostFocus,
                                                                                     txtTempoOperacaoUltrapassado.LostFocus,
                                                                                     txtDataProducaoFilhos.LostFocus,
                                                                                     txtDataProducaoNetos.LostFocus


        Try

            UpdateConfiguracaoGeral()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnRecalcularFila_Click(sender As Object, e As EventArgs) Handles btnRecalcularFila.Click
        Try
            RecalcularFila()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"


    Private Sub ConfigurarUserControl()

        Try

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            LoadCombo(cboPriorizacao, "sp_select_combo_static_planejamento_configuracao_priorizacao", False)

            'Configura Grid
            ConfiguraGrid(grdConfiguracaoOP, iFormulario)
            ConfiguraGrid(grdManutencao, iFormulario)
            ConfiguraGrid(grdCentroTrabalho, iFormulario)

            LoadControles()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadDadosAba()
        Try
            If tabMain.SelectedTab IsNot Nothing Then

                Select Case tabMain.SelectedTab.Name
                    Case pagConfiguracaoOP.Name : LoadGridConfigOP()
                    Case pagManutencao.Name : LoadGridManutencao()
                    Case pagCentroTrabalho.Name : LoadGridCentroTrabalho()
                End Select

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadControles()

        Try

            oClsPrdPlanejamentoConfiguracao.LoadControles(cboPriorizacao,
                                                          txtLeadTimeProducao,
                                                          txtLeadTimeEstoque,
                                                          txtLeadTimeMetrologia,
                                                          txtTempoSetupUltrapassado,
                                                          txtTempoMotivoParadaGrande,
                                                          txtTempoOperacaoUltrapassado,
                                                          txtDataProducaoFilhos,
                                                          txtDataProducaoNetos)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridConfigOP()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsPrdPlanejamentoConfiguracao.LoadGridConfigOP(grdConfiguracaoOP)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridManutencao()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsPrdPlanejamentoConfiguracao.LoadGridManutencao(grdManutencao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridCentroTrabalho()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsPrdPlanejamentoConfiguracao.LoadGridCentroTrabalho(grdCentroTrabalho)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub UpdateConfiguracaoGeral()
        Try

            oClsPrdPlanejamentoConfiguracao.UpdateConfiguracaoGeral(IIf(cboPriorizacao.SelectedIndex = -1, -1, cboPriorizacao.SelectedValue),
                                                                    txtLeadTimeProducao.Value,
                                                                    txtLeadTimeEstoque.Value,
                                                                    txtLeadTimeMetrologia.Value,
                                                                    txtTempoSetupUltrapassado.Value,
                                                                    txtTempoMotivoParadaGrande.Value,
                                                                    txtTempoOperacaoUltrapassado.Value,
                                                                    txtDataProducaoFilhos.Value,
                                                                    txtDataProducaoNetos.Value)

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecalcularFila()
        Try

            If MsgBox("Gostaria de recalcular a fila? Este procedimento sobrescreverá a priorização realizada no aplicativo e não é reversível.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) <> MsgBoxResult.Yes Then Exit Sub

            oClsPrdPlanejamentoConfiguracao.UpdateRecalcularFila()

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region



End Class
