Public Class usrCadTurnoProducao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadTurnoProducao As New clsUsrCadTurnoProducao

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadTurnoProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadTurnoProducao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadTurnoProducao_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoTurnoProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTurnoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifiva se a Columa pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "duplicar" : Call Duplicar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoTurnoProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoTurnoProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoTurnoProducao, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoTurnoProducao, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoTurnoProducao, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoTurnoProducao, gcPrint)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTurnoProducao)

            'Seta Focu
            txtDescricaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadTurnoProducao.Delete()

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
            txtDescricao.Text = ""
            txtDescricao.Tag = ""
            chkSegunda.Checked = False
            chkTerca.Checked = False
            chkQuarta.Checked = False
            chkQuinta.Checked = False
            chkSexta.Checked = False
            chkSabado.Checked = False
            chkDomingo.Checked = False
            txtHoraEntradaSegunda.Value = 0
            txtHoraEntradaTerca.Value = 0
            txtHoraEntradaQuarta.Value = 0
            txtHoraEntradaQuinta.Value = 0
            txtHoraEntradaSexta.Value = 0
            txtHoraEntradaSabado.Value = 0
            txtHoraEntradaDomingo.Value = 0
            txtMinutoEntradaSegunda.Value = 0
            txtMinutoEntradaTerca.Value = 0
            txtMinutoEntradaQuarta.Value = 0
            txtMinutoEntradaQuinta.Value = 0
            txtMinutoEntradaSexta.Value = 0
            txtMinutoEntradaSabado.Value = 0
            txtMinutoEntradaDomingo.Value = 0
            txtHoraSaidaSegunda.Value = 0
            txtHoraSaidaTerca.Value = 0
            txtHoraSaidaQuarta.Value = 0
            txtHoraSaidaQuinta.Value = 0
            txtHoraSaidaSexta.Value = 0
            txtHoraSaidaSabado.Value = 0
            txtHoraSaidaDomingo.Value = 0
            txtMinutoSaidaSegunda.Value = 0
            txtMinutoSaidaTerca.Value = 0
            txtMinutoSaidaQuarta.Value = 0
            txtMinutoSaidaQuinta.Value = 0
            txtMinutoSaidaSexta.Value = 0
            txtMinutoSaidaSabado.Value = 0
            txtMinutoSaidaDomingo.Value = 0
            txtHoraAlmocoSegunda.Text = "00:00:00"
            txtHoraAlmocoTerca.Text = "00:00:00"
            txtHoraAlmocoQuarta.Text = "00:00:00"
            txtHoraAlmocoQuinta.Text = "00:00:00"
            txtHoraAlmocoSexta.Text = "00:00:00"
            txtHoraAlmocoSabado.Text = "00:00:00"
            txtHoraAlmocoDomingo.Text = "00:00:00"
            txtHoraAdicionalNoturnoInicioSegunda.Value = 0
            txtHoraAdicionalNoturnoInicioTerca.Value = 0
            txtHoraAdicionalNoturnoInicioQuarta.Value = 0
            txtHoraAdicionalNoturnoInicioQuinta.Value = 0
            txtHoraAdicionalNoturnoInicioSexta.Value = 0
            txtHoraAdicionalNoturnoInicioSabado.Value = 0
            txtHoraAdicionalNoturnoInicioDomingo.Value = 0
            txtMinutoAdicionalNoturnoInicioSegunda.Value = 0
            txtMinutoAdicionalNoturnoInicioTerca.Value = 0
            txtMinutoAdicionalNoturnoInicioQuarta.Value = 0
            txtMinutoAdicionalNoturnoInicioQuinta.Value = 0
            txtMinutoAdicionalNoturnoInicioSexta.Value = 0
            txtMinutoAdicionalNoturnoInicioSabado.Value = 0
            txtMinutoAdicionalNoturnoInicioDomingo.Value = 0
            txtHoraAdicionalNoturnoTerminoSegunda.Value = 0
            txtHoraAdicionalNoturnoTerminoTerca.Value = 0
            txtHoraAdicionalNoturnoTerminoQuarta.Value = 0
            txtHoraAdicionalNoturnoTerminoQuinta.Value = 0
            txtHoraAdicionalNoturnoTerminoSexta.Value = 0
            txtHoraAdicionalNoturnoTerminoSabado.Value = 0
            txtHoraAdicionalNoturnoTerminoDomingo.Value = 0
            txtMinutoAdicionalNoturnoTerminoSegunda.Value = 0
            txtMinutoAdicionalNoturnoTerminoTerca.Value = 0
            txtMinutoAdicionalNoturnoTerminoQuarta.Value = 0
            txtMinutoAdicionalNoturnoTerminoQuinta.Value = 0
            txtMinutoAdicionalNoturnoTerminoSexta.Value = 0
            txtMinutoAdicionalNoturnoTerminoSabado.Value = 0
            txtMinutoAdicionalNoturnoTerminoDomingo.Value = 0
            txtHoraExtraPreTurnoSegunda.Text = "00:00:00"
            txtHoraExtraPreTurnoTerca.Text = "00:00:00"
            txtHoraExtraPreTurnoQuarta.Text = "00:00:00"
            txtHoraExtraPreTurnoQuinta.Text = "00:00:00"
            txtHoraExtraPreTurnoSexta.Text = "00:00:00"
            txtHoraExtraPreTurnoSabado.Text = "00:00:00"
            txtHoraExtraPreTurnoDomingo.Text = "00:00:00"
            txtHoraExtraPosTurnoSegunda.Text = "00:00:00"
            txtHoraExtraPosTurnoTerca.Text = "00:00:00"
            txtHoraExtraPosTurnoQuarta.Text = "00:00:00"
            txtHoraExtraPosTurnoQuinta.Text = "00:00:00"
            txtHoraExtraPosTurnoSexta.Text = "00:00:00"
            txtHoraExtraPosTurnoSabado.Text = "00:00:00"
            txtHoraExtraPosTurnoDomingo.Text = "00:00:00"

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTurnoProducao, gcUpdate) = True Then

                oClsCadTurnoProducao.LoadDados(grdListagem.CurrentRow.Cells("codigo").Value, _
                                               txtDescricao, _
                                               chkSegunda, _
                                               chkTerca, _
                                               chkQuarta, _
                                               chkQuinta, _
                                               chkSexta, _
                                               chkSabado, _
                                               chkDomingo, _
                                               txtHoraEntradaSegunda, _
                                               txtHoraEntradaTerca, _
                                               txtHoraEntradaQuarta, _
                                               txtHoraEntradaQuinta, _
                                               txtHoraEntradaSexta, _
                                               txtHoraEntradaSabado, _
                                               txtHoraEntradaDomingo, _
                                               txtMinutoEntradaSegunda, _
                                               txtMinutoEntradaTerca, _
                                               txtMinutoEntradaQuarta, _
                                               txtMinutoEntradaQuinta, _
                                               txtMinutoEntradaSexta, _
                                               txtMinutoEntradaSabado, _
                                               txtMinutoEntradaDomingo, _
                                               txtHoraSaidaSegunda, _
                                               txtHoraSaidaTerca, _
                                               txtHoraSaidaQuarta, _
                                               txtHoraSaidaQuinta, _
                                               txtHoraSaidaSexta, _
                                               txtHoraSaidaSabado, _
                                               txtHoraSaidaDomingo, _
                                               txtMinutoSaidaSegunda, _
                                               txtMinutoSaidaTerca, _
                                               txtMinutoSaidaQuarta, _
                                               txtMinutoSaidaQuinta, _
                                               txtMinutoSaidaSexta, _
                                               txtMinutoSaidaSabado, _
                                               txtMinutoSaidaDomingo, _
                                               txtHoraAlmocoSegunda, _
                                               txtHoraAlmocoTerca, _
                                               txtHoraAlmocoQuarta, _
                                               txtHoraAlmocoQuinta, _
                                               txtHoraAlmocoSexta, _
                                               txtHoraAlmocoSabado, _
                                               txtHoraAlmocoDomingo, _
                                               txtHoraAdicionalNoturnoInicioSegunda, _
                                               txtHoraAdicionalNoturnoInicioTerca, _
                                               txtHoraAdicionalNoturnoInicioQuarta, _
                                               txtHoraAdicionalNoturnoInicioQuinta, _
                                               txtHoraAdicionalNoturnoInicioSexta, _
                                               txtHoraAdicionalNoturnoInicioSabado, _
                                               txtHoraAdicionalNoturnoInicioDomingo, _
                                               txtMinutoAdicionalNoturnoInicioSegunda, _
                                               txtMinutoAdicionalNoturnoInicioTerca, _
                                               txtMinutoAdicionalNoturnoInicioQuarta, _
                                               txtMinutoAdicionalNoturnoInicioQuinta, _
                                               txtMinutoAdicionalNoturnoInicioSexta, _
                                               txtMinutoAdicionalNoturnoInicioSabado, _
                                               txtMinutoAdicionalNoturnoInicioDomingo, _
                                               txtHoraAdicionalNoturnoTerminoSegunda, _
                                               txtHoraAdicionalNoturnoTerminoTerca, _
                                               txtHoraAdicionalNoturnoTerminoQuarta, _
                                               txtHoraAdicionalNoturnoTerminoQuinta, _
                                               txtHoraAdicionalNoturnoTerminoSexta, _
                                               txtHoraAdicionalNoturnoTerminoSabado, _
                                               txtHoraAdicionalNoturnoTerminoDomingo, _
                                               txtMinutoAdicionalNoturnoTerminoSegunda, _
                                               txtMinutoAdicionalNoturnoTerminoTerca, _
                                               txtMinutoAdicionalNoturnoTerminoQuarta, _
                                               txtMinutoAdicionalNoturnoTerminoQuinta, _
                                               txtMinutoAdicionalNoturnoTerminoSexta, _
                                               txtMinutoAdicionalNoturnoTerminoSabado, _
                                               txtMinutoAdicionalNoturnoTerminoDomingo, _
                                               txtHoraExtraPreTurnoSegunda, _
                                               txtHoraExtraPreTurnoTerca, _
                                               txtHoraExtraPreTurnoQuarta, _
                                               txtHoraExtraPreTurnoQuinta, _
                                               txtHoraExtraPreTurnoSexta, _
                                               txtHoraExtraPreTurnoSabado, _
                                               txtHoraExtraPreTurnoDomingo, _
                                               txtHoraExtraPosTurnoSegunda, _
                                               txtHoraExtraPosTurnoTerca, _
                                               txtHoraExtraPosTurnoQuarta, _
                                               txtHoraExtraPosTurnoQuinta, _
                                               txtHoraExtraPosTurnoSexta, _
                                               txtHoraExtraPosTurnoSabado, _
                                               txtHoraExtraPosTurnoDomingo)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtDescricao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Duplicar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTurnoProducao, gcInsert) = True Then

                oClsCadTurnoProducao.LoadDados(grdListagem.CurrentRow.Cells("codigo").Value, _
                                               txtDescricao, _
                                               chkSegunda, _
                                               chkTerca, _
                                               chkQuarta, _
                                               chkQuinta, _
                                               chkSexta, _
                                               chkSabado, _
                                               chkDomingo, _
                                               txtHoraEntradaSegunda, _
                                               txtHoraEntradaTerca, _
                                               txtHoraEntradaQuarta, _
                                               txtHoraEntradaQuinta, _
                                               txtHoraEntradaSexta, _
                                               txtHoraEntradaSabado, _
                                               txtHoraEntradaDomingo, _
                                               txtMinutoEntradaSegunda, _
                                               txtMinutoEntradaTerca, _
                                               txtMinutoEntradaQuarta, _
                                               txtMinutoEntradaQuinta, _
                                               txtMinutoEntradaSexta, _
                                               txtMinutoEntradaSabado, _
                                               txtMinutoEntradaDomingo, _
                                               txtHoraSaidaSegunda, _
                                               txtHoraSaidaTerca, _
                                               txtHoraSaidaQuarta, _
                                               txtHoraSaidaQuinta, _
                                               txtHoraSaidaSexta, _
                                               txtHoraSaidaSabado, _
                                               txtHoraSaidaDomingo, _
                                               txtMinutoSaidaSegunda, _
                                               txtMinutoSaidaTerca, _
                                               txtMinutoSaidaQuarta, _
                                               txtMinutoSaidaQuinta, _
                                               txtMinutoSaidaSexta, _
                                               txtMinutoSaidaSabado, _
                                               txtMinutoSaidaDomingo, _
                                               txtHoraAlmocoSegunda, _
                                               txtHoraAlmocoTerca, _
                                               txtHoraAlmocoQuarta, _
                                               txtHoraAlmocoQuinta, _
                                               txtHoraAlmocoSexta, _
                                               txtHoraAlmocoSabado, _
                                               txtHoraAlmocoDomingo, _
                                               txtHoraAdicionalNoturnoInicioSegunda, _
                                               txtHoraAdicionalNoturnoInicioTerca, _
                                               txtHoraAdicionalNoturnoInicioQuarta, _
                                               txtHoraAdicionalNoturnoInicioQuinta, _
                                               txtHoraAdicionalNoturnoInicioSexta, _
                                               txtHoraAdicionalNoturnoInicioSabado, _
                                               txtHoraAdicionalNoturnoInicioDomingo, _
                                               txtMinutoAdicionalNoturnoInicioSegunda, _
                                               txtMinutoAdicionalNoturnoInicioTerca, _
                                               txtMinutoAdicionalNoturnoInicioQuarta, _
                                               txtMinutoAdicionalNoturnoInicioQuinta, _
                                               txtMinutoAdicionalNoturnoInicioSexta, _
                                               txtMinutoAdicionalNoturnoInicioSabado, _
                                               txtMinutoAdicionalNoturnoInicioDomingo, _
                                               txtHoraAdicionalNoturnoTerminoSegunda, _
                                               txtHoraAdicionalNoturnoTerminoTerca, _
                                               txtHoraAdicionalNoturnoTerminoQuarta, _
                                               txtHoraAdicionalNoturnoTerminoQuinta, _
                                               txtHoraAdicionalNoturnoTerminoSexta, _
                                               txtHoraAdicionalNoturnoTerminoSabado, _
                                               txtHoraAdicionalNoturnoTerminoDomingo, _
                                               txtMinutoAdicionalNoturnoTerminoSegunda, _
                                               txtMinutoAdicionalNoturnoTerminoTerca, _
                                               txtMinutoAdicionalNoturnoTerminoQuarta, _
                                               txtMinutoAdicionalNoturnoTerminoQuinta, _
                                               txtMinutoAdicionalNoturnoTerminoSexta, _
                                               txtMinutoAdicionalNoturnoTerminoSabado, _
                                               txtMinutoAdicionalNoturnoTerminoDomingo, _
                                               txtHoraExtraPreTurnoSegunda, _
                                               txtHoraExtraPreTurnoTerca, _
                                               txtHoraExtraPreTurnoQuarta, _
                                               txtHoraExtraPreTurnoQuinta, _
                                               txtHoraExtraPreTurnoSexta, _
                                               txtHoraExtraPreTurnoSabado, _
                                               txtHoraExtraPreTurnoDomingo, _
                                               txtHoraExtraPosTurnoSegunda, _
                                               txtHoraExtraPosTurnoTerca, _
                                               txtHoraExtraPosTurnoQuarta, _
                                               txtHoraExtraPosTurnoQuinta, _
                                               txtHoraExtraPosTurnoSexta, _
                                               txtHoraExtraPosTurnoSabado, _
                                               txtHoraExtraPosTurnoDomingo)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Controle
                txtDescricao.Tag = ""

                'Seta Focu
                txtDescricao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadTurnoProducao.Codigo = IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0)
            oClsCadTurnoProducao.Descricao = txtDescricao.Text.Trim
            oClsCadTurnoProducao.Segunda = chkSegunda.Checked
            oClsCadTurnoProducao.Terca = chkTerca.Checked
            oClsCadTurnoProducao.Quarta = chkQuarta.Checked
            oClsCadTurnoProducao.Quinta = chkQuinta.Checked
            oClsCadTurnoProducao.Sexta = chkSexta.Checked
            oClsCadTurnoProducao.Sabado = chkSabado.Checked
            oClsCadTurnoProducao.Domingo = chkDomingo.Checked
            oClsCadTurnoProducao.HoraEntradaSegunda = txtHoraEntradaSegunda.Value
            oClsCadTurnoProducao.HoraEntradaTerca = txtHoraEntradaTerca.Value
            oClsCadTurnoProducao.HoraEntradaQuarta = txtHoraEntradaQuarta.Value
            oClsCadTurnoProducao.HoraEntradaQuinta = txtHoraEntradaQuinta.Value
            oClsCadTurnoProducao.HoraEntradaSexta = txtHoraEntradaSexta.Value
            oClsCadTurnoProducao.HoraEntradaSabado = txtHoraEntradaSabado.Value
            oClsCadTurnoProducao.HoraEntradaDomingo = txtHoraEntradaDomingo.Value
            oClsCadTurnoProducao.MinutoEntradaSegunda = txtMinutoEntradaSegunda.Value
            oClsCadTurnoProducao.MinutoEntradaTerca = txtMinutoEntradaTerca.Value
            oClsCadTurnoProducao.MinutoEntradaQuarta = txtMinutoEntradaQuarta.Value
            oClsCadTurnoProducao.MinutoEntradaQuinta = txtMinutoEntradaQuinta.Value
            oClsCadTurnoProducao.MinutoEntradaSexta = txtMinutoEntradaSexta.Value
            oClsCadTurnoProducao.MinutoEntradaSabado = txtMinutoEntradaSabado.Value
            oClsCadTurnoProducao.MinutoEntradaDomingo = txtMinutoEntradaDomingo.Value
            oClsCadTurnoProducao.HoraSaidaSegunda = txtHoraSaidaSegunda.Value
            oClsCadTurnoProducao.HoraSaidaTerca = txtHoraSaidaTerca.Value
            oClsCadTurnoProducao.HoraSaidaQuarta = txtHoraSaidaQuarta.Value
            oClsCadTurnoProducao.HoraSaidaQuinta = txtHoraSaidaQuinta.Value
            oClsCadTurnoProducao.HoraSaidaSexta = txtHoraSaidaSexta.Value
            oClsCadTurnoProducao.HoraSaidaSabado = txtHoraSaidaSabado.Value
            oClsCadTurnoProducao.HoraSaidaDomingo = txtHoraSaidaDomingo.Value
            oClsCadTurnoProducao.MinutoSaidaSegunda = txtMinutoSaidaSegunda.Value
            oClsCadTurnoProducao.MinutoSaidaTerca = txtMinutoSaidaTerca.Value
            oClsCadTurnoProducao.MinutoSaidaQuarta = txtMinutoSaidaQuarta.Value
            oClsCadTurnoProducao.MinutoSaidaQuinta = txtMinutoSaidaQuinta.Value
            oClsCadTurnoProducao.MinutoSaidaSexta = txtMinutoSaidaSexta.Value
            oClsCadTurnoProducao.MinutoSaidaSabado = txtMinutoSaidaSabado.Value
            oClsCadTurnoProducao.MinutoSaidaDomingo = txtMinutoSaidaDomingo.Value
            oClsCadTurnoProducao.HoraAlmocoSegunda = ((DatePart(DateInterval.Hour, CDate(txtHoraAlmocoSegunda.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraAlmocoSegunda.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraAlmocoSegunda.Text)) / 60))
            oClsCadTurnoProducao.HoraAlmocoTerca = ((DatePart(DateInterval.Hour, CDate(txtHoraAlmocoTerca.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraAlmocoTerca.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraAlmocoTerca.Text)) / 60))
            oClsCadTurnoProducao.HoraAlmocoQuarta = ((DatePart(DateInterval.Hour, CDate(txtHoraAlmocoQuarta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraAlmocoQuarta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraAlmocoQuarta.Text)) / 60))
            oClsCadTurnoProducao.HoraAlmocoQuinta = ((DatePart(DateInterval.Hour, CDate(txtHoraAlmocoQuinta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraAlmocoQuinta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraAlmocoQuinta.Text)) / 60))
            oClsCadTurnoProducao.HoraAlmocoSexta = ((DatePart(DateInterval.Hour, CDate(txtHoraAlmocoSexta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraAlmocoSexta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraAlmocoSexta.Text)) / 60))
            oClsCadTurnoProducao.HoraAlmocoSabado = ((DatePart(DateInterval.Hour, CDate(txtHoraAlmocoSabado.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraAlmocoSabado.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraAlmocoSabado.Text)) / 60))
            oClsCadTurnoProducao.HoraAlmocoDomingo = ((DatePart(DateInterval.Hour, CDate(txtHoraAlmocoDomingo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraAlmocoDomingo.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraAlmocoDomingo.Text)) / 60))
            oClsCadTurnoProducao.HoraAdicionalNoturnoInicioSegunda = txtHoraAdicionalNoturnoInicioSegunda.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoInicioTerca = txtHoraAdicionalNoturnoInicioTerca.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoInicioQuarta = txtHoraAdicionalNoturnoInicioQuarta.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoInicioQuinta = txtHoraAdicionalNoturnoInicioQuinta.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoInicioSexta = txtHoraAdicionalNoturnoInicioSexta.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoInicioSabado = txtHoraAdicionalNoturnoInicioSabado.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoInicioDomingo = txtHoraAdicionalNoturnoInicioDomingo.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoInicioSegunda = txtMinutoAdicionalNoturnoInicioSegunda.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoInicioTerca = txtMinutoAdicionalNoturnoInicioTerca.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoInicioQuarta = txtMinutoAdicionalNoturnoInicioQuarta.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoInicioQuinta = txtMinutoAdicionalNoturnoInicioQuinta.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoInicioSexta = txtMinutoAdicionalNoturnoInicioSexta.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoInicioSabado = txtMinutoAdicionalNoturnoInicioSabado.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoInicioDomingo = txtMinutoAdicionalNoturnoInicioDomingo.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoTerminoSegunda = txtHoraAdicionalNoturnoTerminoSegunda.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoTerminoTerca = txtHoraAdicionalNoturnoTerminoTerca.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoTerminoQuarta = txtHoraAdicionalNoturnoTerminoQuarta.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoTerminoQuinta = txtHoraAdicionalNoturnoTerminoQuinta.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoTerminoSexta = txtHoraAdicionalNoturnoTerminoSexta.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoTerminoSabado = txtHoraAdicionalNoturnoTerminoSabado.Value
            oClsCadTurnoProducao.HoraAdicionalNoturnoTerminoDomingo = txtHoraAdicionalNoturnoTerminoDomingo.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoTerminoSegunda = txtMinutoAdicionalNoturnoTerminoSegunda.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoTerminoTerca = txtMinutoAdicionalNoturnoTerminoTerca.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoTerminoQuarta = txtMinutoAdicionalNoturnoTerminoQuarta.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoTerminoQuinta = txtMinutoAdicionalNoturnoTerminoQuinta.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoTerminoSexta = txtMinutoAdicionalNoturnoTerminoSexta.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoTerminoSabado = txtMinutoAdicionalNoturnoTerminoSabado.Value
            oClsCadTurnoProducao.MinutoAdicionalNoturnoTerminoDomingo = txtMinutoAdicionalNoturnoTerminoDomingo.Value
            oClsCadTurnoProducao.HoraExtraPreTurnoSegunda = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPreTurnoSegunda.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPreTurnoSegunda.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPreTurnoSegunda.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPreTurnoTerca = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPreTurnoTerca.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPreTurnoTerca.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPreTurnoTerca.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPreTurnoQuarta = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPreTurnoQuarta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPreTurnoQuarta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPreTurnoQuarta.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPreTurnoQuinta = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPreTurnoQuinta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPreTurnoQuinta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPreTurnoQuinta.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPreTurnoSexta = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPreTurnoSexta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPreTurnoSexta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPreTurnoSexta.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPreTurnoSabado = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPreTurnoSabado.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPreTurnoSabado.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPreTurnoSabado.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPreTurnoDomingo = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPreTurnoDomingo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPreTurnoDomingo.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPreTurnoDomingo.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPosTurnoSegunda = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPosTurnoSegunda.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPosTurnoSegunda.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPosTurnoSegunda.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPosTurnoTerca = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPosTurnoTerca.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPosTurnoTerca.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPosTurnoTerca.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPosTurnoQuarta = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPosTurnoQuarta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPosTurnoQuarta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPosTurnoQuarta.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPosTurnoQuinta = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPosTurnoQuinta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPosTurnoQuinta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPosTurnoQuinta.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPosTurnoSexta = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPosTurnoSexta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPosTurnoSexta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPosTurnoSexta.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPosTurnoSabado = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPosTurnoSabado.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPosTurnoSabado.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPosTurnoSabado.Text)) / 60))
            oClsCadTurnoProducao.HoraExtraPosTurnoDomingo = ((DatePart(DateInterval.Hour, CDate(txtHoraExtraPosTurnoDomingo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraExtraPosTurnoDomingo.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraExtraPosTurnoDomingo.Text)) / 60))

            'Verifica o Tipo de Operação
            If IsNumeric(txtDescricao.Tag) Then
                oClsCadTurnoProducao.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadTurnoProducao.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadTurnoProducao.LoadGrid(grdListagem, _
                                  txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Valida se o Centro de Trabalho é válido
            If oClsCadTurnoProducao.ValidaDescricao(IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0), _
                                            txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição já está associado a outro Registro")
                txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Segunda
            If ValidaCampo(txtHoraEntradaSegunda, lblHoraEntrada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Terça
            If ValidaCampo(txtHoraEntradaTerca, lblHoraEntrada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Quarta
            If ValidaCampo(txtHoraEntradaQuarta, lblHoraEntrada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Quinta
            If ValidaCampo(txtHoraEntradaQuinta, lblHoraEntrada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Sexta
            If ValidaCampo(txtHoraEntradaSexta, lblHoraEntrada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Sabado
            If ValidaCampo(txtHoraEntradaSabado, lblHoraEntrada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Domingo
            If ValidaCampo(txtHoraEntradaDomingo, lblHoraEntrada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Segunda
            If ValidaCampo(txtMinutoEntradaSegunda, lblHoraEntrada, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Terça
            If ValidaCampo(txtMinutoEntradaTerca, lblHoraEntrada, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Quarta
            If ValidaCampo(txtMinutoEntradaQuarta, lblHoraEntrada, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Quinta
            If ValidaCampo(txtMinutoEntradaQuinta, lblHoraEntrada, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Sexta
            If ValidaCampo(txtMinutoEntradaSexta, lblHoraEntrada, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Sabado
            If ValidaCampo(txtMinutoEntradaSabado, lblHoraEntrada, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Domingo
            If ValidaCampo(txtMinutoEntradaDomingo, lblHoraEntrada, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saída Segunda
            If ValidaCampo(txtHoraSaidaSegunda, lblHoraSaida, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Terça
            If ValidaCampo(txtHoraSaidaTerca, lblHoraSaida, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Quarta
            If ValidaCampo(txtHoraSaidaQuarta, lblHoraSaida, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Quinta
            If ValidaCampo(txtHoraSaidaQuinta, lblHoraSaida, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Sexta
            If ValidaCampo(txtHoraSaidaSexta, lblHoraSaida, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Sabado
            If ValidaCampo(txtHoraSaidaSabado, lblHoraSaida, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Domingo
            If ValidaCampo(txtHoraSaidaDomingo, lblHoraSaida, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Segunda
            If ValidaCampo(txtMinutoSaidaSegunda, lblHoraSaida, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Terça
            If ValidaCampo(txtMinutoSaidaTerca, lblHoraSaida, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Quarta
            If ValidaCampo(txtMinutoSaidaQuarta, lblHoraSaida, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Quinta
            If ValidaCampo(txtMinutoSaidaQuinta, lblHoraSaida, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Sexta
            If ValidaCampo(txtMinutoSaidaSexta, lblHoraSaida, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Sabado
            If ValidaCampo(txtMinutoSaidaSabado, lblHoraSaida, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Domingo
            If ValidaCampo(txtMinutoSaidaDomingo, lblHoraSaida, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Segunda
            If ValidaCampo(txtHoraAlmocoSegunda, lblHoraAlmoco, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Terça
            If ValidaCampo(txtHoraAlmocoTerca, lblHoraAlmoco, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Quarta
            If ValidaCampo(txtHoraAlmocoQuarta, lblHoraAlmoco, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Quinta
            If ValidaCampo(txtHoraAlmocoQuinta, lblHoraAlmoco, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Sexta
            If ValidaCampo(txtHoraAlmocoSexta, lblHoraAlmoco, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Sabado
            If ValidaCampo(txtHoraAlmocoSabado, lblHoraAlmoco, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Domingo
            If ValidaCampo(txtHoraAlmocoDomingo, lblHoraAlmoco, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Segunda
            If ValidaCampo(txtHoraAdicionalNoturnoInicioSegunda, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Terça
            If ValidaCampo(txtHoraAdicionalNoturnoInicioTerca, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Quarta
            If ValidaCampo(txtHoraAdicionalNoturnoInicioQuarta, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Quinta
            If ValidaCampo(txtHoraAdicionalNoturnoInicioQuinta, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Sexta
            If ValidaCampo(txtHoraAdicionalNoturnoInicioSexta, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Sabado
            If ValidaCampo(txtHoraAdicionalNoturnoInicioSabado, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Domingo
            If ValidaCampo(txtHoraAdicionalNoturnoInicioDomingo, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Segunda
            If ValidaCampo(txtMinutoAdicionalNoturnoInicioSegunda, lblHoraAdicionalNoturnoInicio, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Terça
            If ValidaCampo(txtMinutoAdicionalNoturnoInicioTerca, lblHoraAdicionalNoturnoInicio, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Quarta
            If ValidaCampo(txtMinutoAdicionalNoturnoInicioQuarta, lblHoraAdicionalNoturnoInicio, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Quinta
            If ValidaCampo(txtMinutoAdicionalNoturnoInicioQuinta, lblHoraAdicionalNoturnoInicio, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Sexta
            If ValidaCampo(txtMinutoAdicionalNoturnoInicioSexta, lblHoraAdicionalNoturnoInicio, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Sabado
            If ValidaCampo(txtMinutoAdicionalNoturnoInicioSabado, lblHoraAdicionalNoturnoInicio, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Entrada Domingo
            If ValidaCampo(txtMinutoAdicionalNoturnoInicioDomingo, lblHoraAdicionalNoturnoInicio, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Termino Adicional Noturno Segunda
            If ValidaCampo(txtHoraAdicionalNoturnoTerminoSegunda, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Terça
            If ValidaCampo(txtHoraAdicionalNoturnoTerminoTerca, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Quarta
            If ValidaCampo(txtHoraAdicionalNoturnoTerminoQuarta, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Quinta
            If ValidaCampo(txtHoraAdicionalNoturnoTerminoQuinta, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Sexta
            If ValidaCampo(txtHoraAdicionalNoturnoTerminoSexta, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Sabado
            If ValidaCampo(txtHoraAdicionalNoturnoTerminoSabado, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Domingo
            If ValidaCampo(txtHoraAdicionalNoturnoTerminoDomingo, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Segunda
            If ValidaCampo(txtMinutoAdicionalNoturnoTerminoSegunda, lblHoraAdicionalNoturnoTermino, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Terça
            If ValidaCampo(txtMinutoAdicionalNoturnoTerminoTerca, lblHoraAdicionalNoturnoTermino, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Quarta
            If ValidaCampo(txtMinutoAdicionalNoturnoTerminoQuarta, lblHoraAdicionalNoturnoTermino, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Quinta
            If ValidaCampo(txtMinutoAdicionalNoturnoTerminoQuinta, lblHoraAdicionalNoturnoTermino, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Sexta
            If ValidaCampo(txtMinutoAdicionalNoturnoTerminoSexta, lblHoraAdicionalNoturnoTermino, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Sabado
            If ValidaCampo(txtMinutoAdicionalNoturnoTerminoSabado, lblHoraAdicionalNoturnoTermino, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Minuto Saida Domingo
            If ValidaCampo(txtMinutoAdicionalNoturnoTerminoDomingo, lblHoraAdicionalNoturnoTermino, TipoCampo.minuto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Extra Pré Turno Segunda
            If ValidaCampo(txtHoraExtraPreTurnoSegunda, lblHoraExtraPreTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Extra Pré Turno Terça
            If ValidaCampo(txtHoraExtraPreTurnoTerca, lblHoraExtraPreTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Extra Pré Turno Quarta
            If ValidaCampo(txtHoraExtraPreTurnoQuarta, lblHoraExtraPreTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Extra Pré Turno Quinta
            If ValidaCampo(txtHoraExtraPreTurnoQuinta, lblHoraExtraPreTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Extra Pré Turno Sexta
            If ValidaCampo(txtHoraExtraPreTurnoSexta, lblHoraExtraPreTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Extra Pré Turno Sabado
            If ValidaCampo(txtHoraExtraPreTurnoSabado, lblHoraExtraPreTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Extra Pré Turno Domingo
            If ValidaCampo(txtHoraExtraPreTurnoDomingo, lblHoraExtraPreTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Posenchido o Campo - Hora Extra Pós Turno Segunda
            If ValidaCampo(txtHoraExtraPosTurnoSegunda, lblHoraExtraPosTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Posenchido o Campo - Hora Extra Pós Turno Terça
            If ValidaCampo(txtHoraExtraPosTurnoTerca, lblHoraExtraPosTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Posenchido o Campo - Hora Extra Pós Turno Quarta
            If ValidaCampo(txtHoraExtraPosTurnoQuarta, lblHoraExtraPosTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Posenchido o Campo - Hora Extra Pós Turno Quinta
            If ValidaCampo(txtHoraExtraPosTurnoQuinta, lblHoraExtraPosTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Posenchido o Campo - Hora Extra Pós Turno Sexta
            If ValidaCampo(txtHoraExtraPosTurnoSexta, lblHoraExtraPosTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Posenchido o Campo - Hora Extra Pós Turno Sabado
            If ValidaCampo(txtHoraExtraPosTurnoSabado, lblHoraExtraPosTurno, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Posenchido o Campo - Hora Extra Pós Turno Domingo
            If ValidaCampo(txtHoraExtraPosTurnoDomingo, lblHoraExtraPosTurno, TipoCampo.hora) = False Then
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
