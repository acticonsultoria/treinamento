Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrPrdVisaoProducao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdPlanejamentoLegado As New clsUsrPrdPlanejamentoLegado
    Dim bMaquina As Boolean = False

#End Region

#Region "::: CONTROLES :::"
    Private Sub btnRetrair_Click(sender As Object, e As EventArgs) Handles btnRetrair.Click
        Try
            grdMaquinaAtual.CollapseCards()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandir.Click
        Try
            grdMaquinaAtual.ExpandCards()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"


    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))


            Call LoadCombo(cboRecursoFiltro, "sp_select_combo_cadastro_basico_maquina -1," & goUsuario.iEmpresa)
            Call LoadCombo(cboColaboradorFiltro, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_visao_producao")
            Call LoadCombo(cboProcessoFiltro, "sp_select_combo_cadastro_basico_operacao -1," & goUsuario.iEmpresa)

            Call LoadCombo(cboTipo, "sp_select_combo_static_tipo_visao")
            cboTipo.SelectedValue = 1

            'Timer1.Interval = 10000
            'Timer1.Enabled = True

            'Configura Grid
            Call ConfiguraGrid(grdMaquinaAtual, Formulario.ProducaoPlanejamento)

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdPlanejamentoLegado.LoadGridVisao(IIf(cboProcessoFiltro.SelectedIndex = -1, -1, cboProcessoFiltro.SelectedValue), _
                                                         IIf(cboStatusFiltro.SelectedIndex = -1, "", cboStatusFiltro.SelectedValue), _
                                                         IIf(cboColaboradorFiltro.SelectedIndex = -1, -1, cboColaboradorFiltro.SelectedValue), _
                                                         IIf(cboRecursoFiltro.SelectedIndex = -1, -1, cboRecursoFiltro.SelectedValue), _
                                                         grdMaquinaAtual, _
                                                         bMaquina, _
                                                         cboTipo.SelectedValue)

            bMaquina = Not bMaquina


            ' grdMaquinaAtual.CollapseCards()
            grdMaquinaAtual.View = View.CardView
            grdMaquinaAtual.CardHeaders = True
            grdMaquinaAtual.RootTable.Columns("maquina").Visible = False
            grdMaquinaAtual.RootTable.Columns("maquina").CardIcon = False
            grdMaquinaAtual.RootTable.Columns("maquina").CardCaption = True
            grdMaquinaAtual.RootTable.Columns("maquina").CardViewCaptionVisible = True
            grdMaquinaAtual.CenterSingleCard = False
            grdMaquinaAtual.CardWidth = 140
            grdMaquinaAtual.CardSpacing = 0
            'grdMaquinaAtual.CardCaptionFormatStyle.BackColor = Color.Red

            grdMaquinaAtual.RootTable.Columns("ordem_producao").Caption = ""
            grdMaquinaAtual.RootTable.Columns("tempo_executado").Caption = ""
            grdMaquinaAtual.RootTable.Columns("data_abertura").Caption = ""
            grdMaquinaAtual.RootTable.Columns("operador").Caption = ""

            
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

 
End Class
