Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrPrdAndom

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdPlanejamentoLegado As New clsUsrPrdPlanejamentoLegado
    Private iTabIndex As Integer = 0
    Private sCentroTrabalho As String = ""

#End Region

#Region "::: CONTROLES :::"
    Private Sub btnRetrair_Click(sender As Object, e As EventArgs)
        Try
            grdMaquinaAtual.CollapseCards()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnExpandir_Click(sender As Object, e As EventArgs)
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
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridAndom() Else Control_Enter(sender)


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
            AlteraAba()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged
        Try
            LoadDadosAba()
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

            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa & ",'TODOS'")

            Timer1.Interval = 30000
            Timer1.Enabled = True

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

    Private Sub AlteraAba()
        Try

            ' Incrementa o índice da aba atual e faz a rotação das abas
            iTabIndex += 1
            If iTabIndex >= tabDados.TabPages.Count Then
                iTabIndex = 0  ' Reseta para a primeira aba se passou da última
            End If

            ' Define a aba ativa baseada no índice
            tabDados.SelectedTab = tabDados.TabPages(iTabIndex)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadDadosAba()
        Try

            sCentroTrabalho = ""

            If IsNothing(cboCentroTrabalho.CheckedValues) = False Then
                For Each oItem In cboCentroTrabalho.CheckedValues
                    sCentroTrabalho += IIf(sCentroTrabalho = "", "", ",") + CStr(oItem.ToString)
                Next
            End If

            If tabDados.SelectedTab IsNot Nothing Then

                Select Case tabDados.SelectedTab.Name
                    Case pagVisao.Name : LoadGridAndom()
                    Case pagFatosRelevantes.Name : LoadGridFatosRelevantes()
                End Select

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridAndom()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdPlanejamentoLegado.LoadGridAndom(sCentroTrabalho,
                                                         grdMaquinaAtual)

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

    Private Sub LoadGridFatosRelevantes()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdPlanejamentoLegado.LoadFatosRelevantes(sCentroTrabalho,
                                                                grdFatosRelevantes)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


End Class
