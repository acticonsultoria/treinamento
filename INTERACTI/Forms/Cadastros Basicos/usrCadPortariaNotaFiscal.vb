Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class usrCadPortariaNotaFiscal

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadPortariaNotaFiscal As New clsUsrCadPortariaNotaFiscal

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadPortariaNotaFiscal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadPortariaNotaFiscal_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadPortariaNotaFiscal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona o UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoPortariaNotaFiscal
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoPortariaNotaFiscal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

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
            cboEmpresaFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

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
                                     Formulario.CadastroBasicoPortariaNotaFiscal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoPortariaNotaFiscal, _
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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadPortariaNotaFiscal_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoPortariaNotaFiscal, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoPortariaNotaFiscal, gcInsert)
            btnExcel.Enabled = VerificaDireito(Formulario.CadastroBasicoPortariaNotaFiscal, gcPrint)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboParceiroNegocio : oComboBox(1) = cboParceiroNegocioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            oComboBox(0) = cboTipo : oComboBox(1) = cboTipoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_static_portaria_tipo_nota_fiscal")
            oComboBox(0) = cboEmpresa : oComboBox(1) = cboEmpresaFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_static_portaria_empresa")

            'Configura DateTimer
            dtpDataEntradaInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False


            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoPortariaNotaFiscal)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboEmpresa.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoPortariaNotaFiscal, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Dados
                cboEmpresa.Text = grdListagem.CurrentRow.Cells("empresa").Value
                txtNotaFiscal.Text = grdListagem.CurrentRow.Cells("nota_fiscal").Value
                txtSerie.Text = grdListagem.CurrentRow.Cells("serie").Value
                cboParceiroNegocio.Text = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
                txtValor.Value = grdListagem.CurrentRow.Cells("valor").Value
                cboTipo.Text = grdListagem.CurrentRow.Cells("tipo").Value
                txtMotorista.Text = grdListagem.CurrentRow.Cells("motorista").Value
                txtResponsavel.Text = grdListagem.CurrentRow.Cells("responsavel").Value
                txtObservacao.Text = grdListagem.CurrentRow.Cells("observacao").Value
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboEmpresa.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadPortariaNotaFiscal.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    'Carrega Grid
                    Call LoadGrid()

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
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
            cboEmpresa.Text = ""
            txtNotaFiscal.Text = ""
            txtSerie.Text = ""
            cboParceiroNegocio.Text = ""
            txtValor.Value = 0
            cboTipo.Text = ""
            txtMotorista.Text = ""
            txtResponsavel.Text = ""
            txtObservacao.Text = ""
            btnSalvar.Tag = ""

            'Seta Focu
            cboEmpresa.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadPortariaNotaFiscal.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadPortariaNotaFiscal.CodigoEmpresa = cboEmpresa.SelectedValue
            oClsCadPortariaNotaFiscal.NotaFiscal = txtNotaFiscal.Text
            oClsCadPortariaNotaFiscal.Serie = txtSerie.Text.Trim
            oClsCadPortariaNotaFiscal.CodigoParceiroNegocio = cboParceiroNegocio.SelectedValue
            oClsCadPortariaNotaFiscal.Valor = txtValor.Value
            oClsCadPortariaNotaFiscal.CodigoTipo = cboTipo.SelectedValue
            oClsCadPortariaNotaFiscal.Motorista = txtMotorista.Text.Trim
            oClsCadPortariaNotaFiscal.Responsavel = txtResponsavel.Text.Trim
            oClsCadPortariaNotaFiscal.Observacao = txtObservacao.Text.Trim

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadPortariaNotaFiscal.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadPortariaNotaFiscal.Insert()
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
            oClsCadPortariaNotaFiscal.LoadGrid(grdListagem, _
                                               IIf(cboEmpresaFiltro.SelectedIndex = -1, -1, cboEmpresaFiltro.SelectedValue), _
                                               IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                               txtSerieFiltro.Text.Trim, _
                                               IIf(cboParceiroNegocioFiltro.SelectedIndex = -1, -1, cboParceiroNegocioFiltro.SelectedValue), _
                                               IIf(cboTipoFiltro.SelectedIndex = -1, -1, cboTipoFiltro.SelectedValue), _
                                               txtMotoristaFiltro.Text.Trim, _
                                               txtResponsavelFiltro.Text.Trim, _
                                               IIf(dtpDataEntradaInicioFiltro.Checked = False, "", dtpDataEntradaInicioFiltro.Value), _
                                                IIf(dtpDataEntradaTerminoFiltro.Checked = False, "", dtpDataEntradaTerminoFiltro.Value))

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

            'Verifica se foi Selecionado o Campo - Empresa
            If ValidaCampo(cboEmpresa, lblEmpresa) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nota Fiscal
            If ValidaCampo(txtNotaFiscal, lblNotaFiscal, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Série
            If ValidaCampo(txtSerie, lblSerie, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Parceiro de Negócio
            If ValidaCampo(cboParceiroNegocio, lblParceiroNegocio) = False Then
                Exit Function
            End If

            'Verifica se a Nota Fiscal preenchido é válido
            If oClsCadPortariaNotaFiscal.ValidaNotaFiscal(txtNotaFiscal.Text.Trim, _
                                                          txtSerie.Text.Trim, _
                                                          cboParceiroNegocio.SelectedValue, _
                                                          IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)) = False Then
                frmMain.errInfo.SetError(lblNotaFiscal, "Esta Nota Fiscal: " & txtNotaFiscal.Text & " já está associado a outro Registro.")
                txtNotaFiscal.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValor, lblValor, False) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo
            If ValidaCampo(cboTipo, lblTipo) = False Then
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
