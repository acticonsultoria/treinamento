Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadTurno

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadTurno As New clsUsrCadTurno

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadTurno_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadTurno_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoTurno
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTurno)

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
            Call UpdateConfiguraGrid(grdListagem,
                                     Formulario.CadastroBasicoTurno)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     Formulario.CadastroBasicoTurno,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoHoraExtra_Click(sender As Object, e As EventArgs) Handles btnCadastrarTipoHoraExtra.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoHoraExtra")

            'Carrega Combo
            Dim oComboBox(13) As UIComboBox
            oComboBox(0) = cboHoraExtraSegundaPagamento : oComboBox(1) = cboHoraExtraTercaPagamento
            oComboBox(2) = cboHoraExtraQuartaPagamento : oComboBox(3) = cboHoraExtraQuintaPagamento
            oComboBox(4) = cboHoraExtraSextaPagamento : oComboBox(5) = cboHoraExtraSabadoPagamento : oComboBox(6) = cboHoraExtraDomingoPagamento
            oComboBox(7) = cboHoraExtraAposSegundaPagamento : oComboBox(8) = cboHoraExtraAposTercaPagamento
            oComboBox(9) = cboHoraExtraAposQuartaPagamento : oComboBox(10) = cboHoraExtraAposQuintaPagamento
            oComboBox(11) = cboHoraExtraAposSextaPagamento : oComboBox(12) = cboHoraExtraAposSabadoPagamento : oComboBox(13) = cboHoraExtraAposDomingoPagamento
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_tipo_hora_extra " & goUsuario.iEmpresa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try


            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoTurno, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoTurno, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoTurno, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoTurno, gcPrint)
            btnCadastrarTipoHoraExtra.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoHoraExtra, gcInsert)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Carrega Combo 
            Dim oComboBox(13) As UIComboBox
            oComboBox(0) = cboHoraExtraSegundaPagamento : oComboBox(1) = cboHoraExtraTercaPagamento
            oComboBox(2) = cboHoraExtraQuartaPagamento : oComboBox(3) = cboHoraExtraQuintaPagamento
            oComboBox(4) = cboHoraExtraSextaPagamento : oComboBox(5) = cboHoraExtraSabadoPagamento : oComboBox(6) = cboHoraExtraDomingoPagamento
            oComboBox(7) = cboHoraExtraAposSegundaPagamento : oComboBox(8) = cboHoraExtraAposTercaPagamento
            oComboBox(9) = cboHoraExtraAposQuartaPagamento : oComboBox(10) = cboHoraExtraAposQuintaPagamento
            oComboBox(11) = cboHoraExtraAposSextaPagamento : oComboBox(12) = cboHoraExtraAposSabadoPagamento : oComboBox(13) = cboHoraExtraAposDomingoPagamento
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_tipo_hora_extra " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTurno)

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadTurno.Delete()

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
            txtHoraEntradaSegunda.Text = "00:00:00"
            txtHoraEntradaTerca.Text = "00:00:00"
            txtHoraEntradaQuarta.Text = "00:00:00"
            txtHoraEntradaQuinta.Text = "00:00:00"
            txtHoraEntradaSexta.Text = "00:00:00"
            txtHoraEntradaSabado.Text = "00:00:00"
            txtHoraEntradaDomingo.Text = "00:00:00"
            txtHoraSaidaSegunda.Text = "00:00:00"
            txtHoraSaidaTerca.Text = "00:00:00"
            txtHoraSaidaQuarta.Text = "00:00:00"
            txtHoraSaidaQuinta.Text = "00:00:00"
            txtHoraSaidaSexta.Text = "00:00:00"
            txtHoraSaidaSabado.Text = "00:00:00"
            txtHoraSaidaDomingo.Text = "00:00:00"
            txtHoraAlmocoSegundaInicio.Text = "00:00:00"
            txtHoraAlmocoTercaInicio.Text = "00:00:00"
            txtHoraAlmocoQuartaInicio.Text = "00:00:00"
            txtHoraAlmocoQuintaInicio.Text = "00:00:00"
            txtHoraAlmocoSextaInicio.Text = "00:00:00"
            txtHoraAlmocoSabadoInicio.Text = "00:00:00"
            txtHoraAlmocoDomingoInicio.Text = "00:00:00"
            txtHoraAlmocoSegundaTermino.Text = "00:00:00"
            txtHoraAlmocoTercaTermino.Text = "00:00:00"
            txtHoraAlmocoQuartaTermino.Text = "00:00:00"
            txtHoraAlmocoQuintaTermino.Text = "00:00:00"
            txtHoraAlmocoSextaTermino.Text = "00:00:00"
            txtHoraAlmocoSabadoTermino.Text = "00:00:00"
            txtHoraAlmocoDomingoTermino.Text = "00:00:00"
            txtHoraIntervaloSegundaInicio.Text = "00:00:00"
            txtHoraIntervaloTercaInicio.Text = "00:00:00"
            txtHoraIntervaloQuartaInicio.Text = "00:00:00"
            txtHoraIntervaloQuintaInicio.Text = "00:00:00"
            txtHoraIntervaloSextaInicio.Text = "00:00:00"
            txtHoraIntervaloSabadoInicio.Text = "00:00:00"
            txtHoraIntervaloDomingoInicio.Text = "00:00:00"
            txtHoraIntervaloSegundaTermino.Text = "00:00:00"
            txtHoraIntervaloTercaTermino.Text = "00:00:00"
            txtHoraIntervaloQuartaTermino.Text = "00:00:00"
            txtHoraIntervaloQuintaTermino.Text = "00:00:00"
            txtHoraIntervaloSextaTermino.Text = "00:00:00"
            txtHoraIntervaloSabadoTermino.Text = "00:00:00"
            txtHoraIntervaloDomingoTermino.Text = "00:00:00"
            txtHoraAdicionaNoturnoInicio.Text = "00:00:00"
            txtHoraAdicionaNoturnoTermino.Text = "00:00:00"
            cboHoraExtraSegundaPagamento.SelectedIndex = -1
            txtHoraExtraAposSegundaPagamento.Value = 0
            cboHoraExtraAposSegundaPagamento.SelectedIndex = -1
            cboHoraExtraTercaPagamento.SelectedIndex = -1
            txtHoraExtraAposTercaPagamento.Value = 0
            cboHoraExtraAposTercaPagamento.SelectedIndex = -1
            cboHoraExtraQuartaPagamento.SelectedIndex = -1
            txtHoraExtraAposQuartaPagamento.Value = 0
            cboHoraExtraAposQuartaPagamento.SelectedIndex = -1
            cboHoraExtraQuintaPagamento.SelectedIndex = -1
            txtHoraExtraAposQuintaPagamento.Value = 0
            cboHoraExtraAposQuintaPagamento.SelectedIndex = -1
            cboHoraExtraSextaPagamento.SelectedIndex = -1
            txtHoraExtraAposSextaPagamento.Value = 0
            cboHoraExtraAposSextaPagamento.SelectedIndex = -1
            cboHoraExtraSabadoPagamento.SelectedIndex = -1
            txtHoraExtraAposSabadoPagamento.Value = 0
            cboHoraExtraAposSabadoPagamento.SelectedIndex = -1
            cboHoraExtraDomingoPagamento.SelectedIndex = -1
            txtHoraExtraAposDomingoPagamento.Value = 0
            cboHoraExtraAposDomingoPagamento.SelectedIndex = -1

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTurno, gcUpdate) = True Then

                oClsCadTurno.LoadDados(grdListagem.CurrentRow.Cells("codigo").Value,
                                       txtDescricao,
                                       chkSegunda,
                                       chkTerca,
                                       chkQuarta,
                                       chkQuinta,
                                       chkSexta,
                                       chkSabado,
                                       chkDomingo,
                                       txtHoraEntradaSegunda,
                                       txtHoraEntradaTerca,
                                       txtHoraEntradaQuarta,
                                       txtHoraEntradaQuinta,
                                       txtHoraEntradaSexta,
                                       txtHoraEntradaSabado,
                                       txtHoraEntradaDomingo,
                                       txtHoraSaidaSegunda,
                                       txtHoraSaidaTerca,
                                       txtHoraSaidaQuarta,
                                       txtHoraSaidaQuinta,
                                       txtHoraSaidaSexta,
                                       txtHoraSaidaSabado,
                                       txtHoraSaidaDomingo,
                                       txtHoraAlmocoSegundaInicio,
                                       txtHoraAlmocoTercaInicio,
                                       txtHoraAlmocoQuartaInicio,
                                       txtHoraAlmocoQuintaInicio,
                                       txtHoraAlmocoSextaInicio,
                                       txtHoraAlmocoSabadoInicio,
                                       txtHoraAlmocoDomingoInicio,
                                       txtHoraAlmocoSegundaTermino,
                                       txtHoraAlmocoTercaTermino,
                                       txtHoraAlmocoQuartaTermino,
                                       txtHoraAlmocoQuintaTermino,
                                       txtHoraAlmocoSextaTermino,
                                       txtHoraAlmocoSabadoTermino,
                                       txtHoraAlmocoDomingoTermino,
                                       txtHoraIntervaloSegundaInicio,
                                       txtHoraIntervaloTercaInicio,
                                       txtHoraIntervaloQuartaInicio,
                                       txtHoraIntervaloQuintaInicio,
                                       txtHoraIntervaloSextaInicio,
                                       txtHoraIntervaloSabadoInicio,
                                       txtHoraIntervaloDomingoInicio,
                                       txtHoraIntervaloSegundaTermino,
                                       txtHoraIntervaloTercaTermino,
                                       txtHoraIntervaloQuartaTermino,
                                       txtHoraIntervaloQuintaTermino,
                                       txtHoraIntervaloSextaTermino,
                                       txtHoraIntervaloSabadoTermino,
                                       txtHoraIntervaloDomingoTermino,
                                       txtHoraAdicionaNoturnoInicio,
                                       txtHoraAdicionaNoturnoTermino,
                                       cboHoraExtraSegundaPagamento,
                                       txtHoraExtraAposSegundaPagamento,
                                       cboHoraExtraAposSegundaPagamento,
                                       cboHoraExtraTercaPagamento,
                                       txtHoraExtraAposTercaPagamento,
                                       cboHoraExtraAposTercaPagamento,
                                       cboHoraExtraQuartaPagamento,
                                       txtHoraExtraAposQuartaPagamento,
                                       cboHoraExtraAposQuartaPagamento,
                                       cboHoraExtraQuintaPagamento,
                                       txtHoraExtraAposQuintaPagamento,
                                       cboHoraExtraAposQuintaPagamento,
                                       cboHoraExtraSextaPagamento,
                                       txtHoraExtraAposSextaPagamento,
                                       cboHoraExtraAposSextaPagamento,
                                       cboHoraExtraSabadoPagamento,
                                       txtHoraExtraAposSabadoPagamento,
                                       cboHoraExtraAposSabadoPagamento,
                                       cboHoraExtraDomingoPagamento,
                                       txtHoraExtraAposDomingoPagamento,
                                       cboHoraExtraAposDomingoPagamento)

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
            If VerificaDireito(Formulario.CadastroBasicoTurno, gcInsert) = True Then

                oClsCadTurno.LoadDados(grdListagem.CurrentRow.Cells("codigo").Value,
                                       txtDescricao,
                                       chkSegunda,
                                       chkTerca,
                                       chkQuarta,
                                       chkQuinta,
                                       chkSexta,
                                       chkSabado,
                                       chkDomingo,
                                       txtHoraEntradaSegunda,
                                       txtHoraEntradaTerca,
                                       txtHoraEntradaQuarta,
                                       txtHoraEntradaQuinta,
                                       txtHoraEntradaSexta,
                                       txtHoraEntradaSabado,
                                       txtHoraEntradaDomingo,
                                       txtHoraSaidaSegunda,
                                       txtHoraSaidaTerca,
                                       txtHoraSaidaQuarta,
                                       txtHoraSaidaQuinta,
                                       txtHoraSaidaSexta,
                                       txtHoraSaidaSabado,
                                       txtHoraSaidaDomingo,
                                       txtHoraAlmocoSegundaInicio,
                                       txtHoraAlmocoTercaInicio,
                                       txtHoraAlmocoQuartaInicio,
                                       txtHoraAlmocoQuintaInicio,
                                       txtHoraAlmocoSextaInicio,
                                       txtHoraAlmocoSabadoInicio,
                                       txtHoraAlmocoDomingoInicio,
                                       txtHoraAlmocoSegundaTermino,
                                       txtHoraAlmocoTercaTermino,
                                       txtHoraAlmocoQuartaTermino,
                                       txtHoraAlmocoQuintaTermino,
                                       txtHoraAlmocoSextaTermino,
                                       txtHoraAlmocoSabadoTermino,
                                       txtHoraAlmocoDomingoTermino,
                                       txtHoraIntervaloSegundaInicio,
                                       txtHoraIntervaloTercaInicio,
                                       txtHoraIntervaloQuartaInicio,
                                       txtHoraIntervaloQuintaInicio,
                                       txtHoraIntervaloSextaInicio,
                                       txtHoraIntervaloSabadoInicio,
                                       txtHoraIntervaloDomingoInicio,
                                       txtHoraIntervaloSegundaTermino,
                                       txtHoraIntervaloTercaTermino,
                                       txtHoraIntervaloQuartaTermino,
                                       txtHoraIntervaloQuintaTermino,
                                       txtHoraIntervaloSextaTermino,
                                       txtHoraIntervaloSabadoTermino,
                                       txtHoraIntervaloDomingoTermino,
                                       txtHoraAdicionaNoturnoInicio,
                                       txtHoraAdicionaNoturnoTermino,
                                       cboHoraExtraSegundaPagamento,
                                       txtHoraExtraAposSegundaPagamento,
                                       cboHoraExtraAposSegundaPagamento,
                                       cboHoraExtraTercaPagamento,
                                       txtHoraExtraAposTercaPagamento,
                                       cboHoraExtraAposTercaPagamento,
                                       cboHoraExtraQuartaPagamento,
                                       txtHoraExtraAposQuartaPagamento,
                                       cboHoraExtraAposQuartaPagamento,
                                       cboHoraExtraQuintaPagamento,
                                       txtHoraExtraAposQuintaPagamento,
                                       cboHoraExtraAposQuintaPagamento,
                                       cboHoraExtraSextaPagamento,
                                       txtHoraExtraAposSextaPagamento,
                                       cboHoraExtraAposSextaPagamento,
                                       cboHoraExtraSabadoPagamento,
                                       txtHoraExtraAposSabadoPagamento,
                                       cboHoraExtraAposSabadoPagamento,
                                       cboHoraExtraDomingoPagamento,
                                       txtHoraExtraAposDomingoPagamento,
                                       cboHoraExtraAposDomingoPagamento)

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
            oClsCadTurno.Codigo = IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0)
            oClsCadTurno.Descricao = txtDescricao.Text.Trim
            oClsCadTurno.Segunda = chkSegunda.Checked
            oClsCadTurno.Terca = chkTerca.Checked
            oClsCadTurno.Quarta = chkQuarta.Checked
            oClsCadTurno.Quinta = chkQuinta.Checked
            oClsCadTurno.Sexta = chkSexta.Checked
            oClsCadTurno.Sabado = chkSabado.Checked
            oClsCadTurno.Domingo = chkDomingo.Checked
            oClsCadTurno.HoraEntradaSegunda = FormataHora(txtHoraEntradaSegunda)
            oClsCadTurno.HoraEntradaTerca = FormataHora(txtHoraEntradaTerca)
            oClsCadTurno.HoraEntradaQuarta = FormataHora(txtHoraEntradaQuarta)
            oClsCadTurno.HoraEntradaQuinta = FormataHora(txtHoraEntradaQuinta)
            oClsCadTurno.HoraEntradaSexta = FormataHora(txtHoraEntradaSexta)
            oClsCadTurno.HoraEntradaSabado = FormataHora(txtHoraEntradaSabado)
            oClsCadTurno.HoraEntradaDomingo = FormataHora(txtHoraEntradaDomingo)
            oClsCadTurno.HoraSaidaSegunda = FormataHora(txtHoraSaidaSegunda)
            oClsCadTurno.HoraSaidaTerca = FormataHora(txtHoraSaidaTerca)
            oClsCadTurno.HoraSaidaQuarta = FormataHora(txtHoraSaidaQuarta)
            oClsCadTurno.HoraSaidaQuinta = FormataHora(txtHoraSaidaQuinta)
            oClsCadTurno.HoraSaidaSexta = FormataHora(txtHoraSaidaSexta)
            oClsCadTurno.HoraSaidaSabado = FormataHora(txtHoraSaidaSabado)
            oClsCadTurno.HoraSaidaDomingo = FormataHora(txtHoraSaidaDomingo)
            oClsCadTurno.HoraAlmocoSegundaInicio = FormataHora(txtHoraAlmocoSegundaInicio)
            oClsCadTurno.HoraAlmocoTercaInicio = FormataHora(txtHoraAlmocoTercaInicio)
            oClsCadTurno.HoraAlmocoQuartaInicio = FormataHora(txtHoraAlmocoQuartaInicio)
            oClsCadTurno.HoraAlmocoQuintaInicio = FormataHora(txtHoraAlmocoQuintaInicio)
            oClsCadTurno.HoraAlmocoSextaInicio = FormataHora(txtHoraAlmocoSextaInicio)
            oClsCadTurno.HoraAlmocoSabadoInicio = FormataHora(txtHoraAlmocoSabadoInicio)
            oClsCadTurno.HoraAlmocoDomingoInicio = FormataHora(txtHoraAlmocoDomingoInicio)
            oClsCadTurno.HoraAlmocoSegundaTermino = FormataHora(txtHoraAlmocoSegundaTermino)
            oClsCadTurno.HoraAlmocoTercaTermino = FormataHora(txtHoraAlmocoTercaTermino)
            oClsCadTurno.HoraAlmocoQuartaTermino = FormataHora(txtHoraAlmocoQuartaTermino)
            oClsCadTurno.HoraAlmocoQuintaTermino = FormataHora(txtHoraAlmocoQuintaTermino)
            oClsCadTurno.HoraAlmocoSextaTermino = FormataHora(txtHoraAlmocoSextaTermino)
            oClsCadTurno.HoraAlmocoSabadoTermino = FormataHora(txtHoraAlmocoSabadoTermino)
            oClsCadTurno.HoraAlmocoDomingoTermino = FormataHora(txtHoraAlmocoDomingoTermino)
            oClsCadTurno.HoraIntervaloSegundaInicio = FormataHora(txtHoraIntervaloSegundaInicio)
            oClsCadTurno.HoraIntervaloTercaInicio = FormataHora(txtHoraIntervaloTercaInicio)
            oClsCadTurno.HoraIntervaloQuartaInicio = FormataHora(txtHoraIntervaloQuartaInicio)
            oClsCadTurno.HoraIntervaloQuintaInicio = FormataHora(txtHoraIntervaloQuintaInicio)
            oClsCadTurno.HoraIntervaloSextaInicio = FormataHora(txtHoraIntervaloSextaInicio)
            oClsCadTurno.HoraIntervaloSabadoInicio = FormataHora(txtHoraIntervaloSabadoInicio)
            oClsCadTurno.HoraIntervaloDomingoInicio = FormataHora(txtHoraIntervaloDomingoInicio)
            oClsCadTurno.HoraIntervaloSegundaTermino = FormataHora(txtHoraIntervaloSegundaTermino)
            oClsCadTurno.HoraIntervaloTercaTermino = FormataHora(txtHoraIntervaloTercaTermino)
            oClsCadTurno.HoraIntervaloQuartaTermino = FormataHora(txtHoraIntervaloQuartaTermino)
            oClsCadTurno.HoraIntervaloQuintaTermino = FormataHora(txtHoraIntervaloQuintaTermino)
            oClsCadTurno.HoraIntervaloSextaTermino = FormataHora(txtHoraIntervaloSextaTermino)
            oClsCadTurno.HoraIntervaloSabadoTermino = FormataHora(txtHoraIntervaloSabadoTermino)
            oClsCadTurno.HoraIntervaloDomingoTermino = FormataHora(txtHoraIntervaloDomingoTermino)
            oClsCadTurno.HoraAdicionalNoturnoInicio = FormataHora(txtHoraAdicionaNoturnoInicio)
            oClsCadTurno.HoraAdicionalNoturnoTermino = FormataHora(txtHoraAdicionaNoturnoTermino)
            oClsCadTurno.CodigoHoraExtraSegunda = IIf(cboHoraExtraSegundaPagamento.SelectedIndex = -1, -1, cboHoraExtraSegundaPagamento.SelectedValue)
            oClsCadTurno.HoraExtraAposSegunda = txtHoraExtraAposSegundaPagamento.Value
            oClsCadTurno.CodigoHoraExtraAposSegunda = IIf(cboHoraExtraAposSegundaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposSegundaPagamento.SelectedValue)
            oClsCadTurno.CodigoHoraExtraTerca = IIf(cboHoraExtraTercaPagamento.SelectedIndex = -1, -1, cboHoraExtraTercaPagamento.SelectedValue)
            oClsCadTurno.HoraExtraAposTerca = txtHoraExtraAposTercaPagamento.Value
            oClsCadTurno.CodigoHoraExtraAposTerca = IIf(cboHoraExtraAposTercaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposTercaPagamento.SelectedValue)
            oClsCadTurno.CodigoHoraExtraQuarta = IIf(cboHoraExtraQuartaPagamento.SelectedIndex = -1, -1, cboHoraExtraQuartaPagamento.SelectedValue)
            oClsCadTurno.HoraExtraAposQuarta = txtHoraExtraAposQuartaPagamento.Value
            oClsCadTurno.CodigoHoraExtraAposQuarta = IIf(cboHoraExtraAposQuartaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposQuartaPagamento.SelectedValue)
            oClsCadTurno.CodigoHoraExtraQuinta = IIf(cboHoraExtraQuintaPagamento.SelectedIndex = -1, -1, cboHoraExtraQuintaPagamento.SelectedValue)
            oClsCadTurno.HoraExtraAposQuinta = txtHoraExtraAposQuintaPagamento.Value
            oClsCadTurno.CodigoHoraExtraAposQuinta = IIf(cboHoraExtraAposQuintaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposQuintaPagamento.SelectedValue)
            oClsCadTurno.CodigoHoraExtraSexta = IIf(cboHoraExtraSextaPagamento.SelectedIndex = -1, -1, cboHoraExtraSextaPagamento.SelectedValue)
            oClsCadTurno.HoraExtraAposSexta = txtHoraExtraAposSextaPagamento.Value
            oClsCadTurno.CodigoHoraExtraAposSexta = IIf(cboHoraExtraAposSextaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposSextaPagamento.SelectedValue)
            oClsCadTurno.CodigoHoraExtraSabado = IIf(cboHoraExtraSabadoPagamento.SelectedIndex = -1, -1, cboHoraExtraSabadoPagamento.SelectedValue)
            oClsCadTurno.HoraExtraAposSabado = txtHoraExtraAposSabadoPagamento.Value
            oClsCadTurno.CodigoHoraExtraAposSabado = IIf(cboHoraExtraAposSabadoPagamento.SelectedIndex = -1, -1, cboHoraExtraAposSabadoPagamento.SelectedValue)
            oClsCadTurno.CodigoHoraExtraDomingo = IIf(cboHoraExtraDomingoPagamento.SelectedIndex = -1, -1, cboHoraExtraDomingoPagamento.SelectedValue)
            oClsCadTurno.HoraExtraAposDomingo = txtHoraExtraAposDomingoPagamento.Value
            oClsCadTurno.CodigoHoraExtraAposDomingo = IIf(cboHoraExtraAposDomingoPagamento.SelectedIndex = -1, -1, cboHoraExtraAposDomingoPagamento.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(txtDescricao.Tag) Then
                oClsCadTurno.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadTurno.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
                txtDescricao.Tag = oClsCadTurno.Codigo
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function FormataHora(campo As MaskedEditBox) As Double
        Try

            Dim dHoraFormatada As Double

            dHoraFormatada = ((DatePart(DateInterval.Hour, CDate(campo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(campo.Text)) + (DatePart(DateInterval.Second, CDate(campo.Text)) / 60))

            Return dHoraFormatada

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadTurno.LoadGrid(grdListagem,
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
            If oClsCadTurno.ValidaDescricao(IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0),
                                            txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição já está associado a outro Registro")
                txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Segunda
            If (chkSegunda.Checked = True) Then
                If ValidaCampo(txtHoraEntradaSegunda, lblHoraEntrada, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Terça
            If (chkTerca.Checked = True) Then
                If ValidaCampo(txtHoraEntradaTerca, lblHoraEntrada, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Quarta
            If (chkQuarta.Checked = True) Then
                If ValidaCampo(txtHoraEntradaQuarta, lblHoraEntrada, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Quinta
            If (chkQuinta.Checked = True) Then
                If ValidaCampo(txtHoraEntradaQuinta, lblHoraEntrada, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Sexta
            If (chkSexta.Checked = True) Then
                If ValidaCampo(txtHoraEntradaSexta, lblHoraEntrada, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Sabado
            If (chkSabado.Checked = True) Then
                If ValidaCampo(txtHoraEntradaSabado, lblHoraEntrada, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Entrada Domingo
            If (chkDomingo.Checked = True) Then
                If ValidaCampo(txtHoraEntradaDomingo, lblHoraEntrada, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Saída Segunda
            If (chkSegunda.Checked = True) Then
                If ValidaCampo(txtHoraSaidaSegunda, lblHoraSaida, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Terça
            If (chkTerca.Checked = True) Then
                If ValidaCampo(txtHoraSaidaTerca, lblHoraSaida, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Quarta
            If (chkQuarta.Checked = True) Then
                If ValidaCampo(txtHoraSaidaQuarta, lblHoraSaida, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Quinta
            If (chkQuinta.Checked = True) Then
                If ValidaCampo(txtHoraSaidaQuinta, lblHoraSaida, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Sexta
            If (chkSexta.Checked = True) Then
                If ValidaCampo(txtHoraSaidaSexta, lblHoraSaida, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Sabado
            If (chkSabado.Checked = True) Then
                If ValidaCampo(txtHoraSaidaSabado, lblHoraSaida, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Saida Domingo
            If (chkDomingo.Checked = True) Then
                If ValidaCampo(txtHoraSaidaDomingo, lblHoraSaida, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Início Segunda
            If (chkSegunda.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoSegundaInicio, lblHoraAlmocoInicio, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Início Terça
            If (chkTerca.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoTercaInicio, lblHoraAlmocoInicio, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Início Quarta
            If (chkQuarta.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoQuartaInicio, lblHoraAlmocoInicio, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Início Quinta
            If (chkQuinta.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoQuintaInicio, lblHoraAlmocoInicio, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Início Sexta
            If (chkSexta.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoSextaInicio, lblHoraAlmocoInicio, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Início Sabado
            If (chkSabado.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoSabadoInicio, lblHoraAlmocoInicio, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Início Domingo
            If (chkDomingo.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoDomingoInicio, lblHoraAlmocoInicio, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If


            'Verifica se foi Preenchido o Campo - Hora Almoço Termino Segunda
            If (chkSegunda.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoSegundaTermino, lblHoraAlmocoTermino, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Termino Terça
            If (chkTerca.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoTercaTermino, lblHoraAlmocoTermino, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Termino Quarta
            If (chkQuarta.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoQuartaTermino, lblHoraAlmocoTermino, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Termino Quinta
            If (chkQuinta.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoQuintaTermino, lblHoraAlmocoTermino, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Termino Sexta
            If (chkSexta.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoSextaTermino, lblHoraAlmocoTermino, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Termino Sabado
            If (chkSabado.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoSabadoTermino, lblHoraAlmocoTermino, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Almoço Termino Domingo
            If (chkDomingo.Checked = True) Then
                If ValidaCampo(txtHoraAlmocoDomingoTermino, lblHoraAlmocoTermino, TipoCampo.hora) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Segunda
            If ValidaCampo(txtHoraAdicionaNoturnoInicio, lblHoraAdicionalNoturnoInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Inicio Adicional Noturno Terça
            If ValidaCampo(txtHoraAdicionaNoturnoTermino, lblHoraAdicionalNoturnoTermino, TipoCampo.hora) = False Then
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
