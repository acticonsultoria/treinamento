Imports Janus.Windows.GridEX

Public Class usrCadContrato

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadContrato As New clsUsrCadContrato
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: CONTRATO :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Dim oStackFrame As New System.Diagnostics.StackFrame(1) : Call TratamentoErro(ex.Message, Me.Name.ToString())
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnProcurarCliente_Click(sender As Object, e As EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboCliente.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarCliente_Click(sender As Object, e As EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            cboCliente.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProcurarClienteFiltro_Click(sender As Object, e As EventArgs) Handles btnProcurarClienteFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            oForm.ShowDialog(Me)

            cboClienteFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            Novo()

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            dtpDataContrato.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            Dim oStackFrame As New System.Diagnostics.StackFrame(1) : Call TratamentoErro(ex.Message, Me.Name.ToString())
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            LoadGrid()

            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            txtNumeroContratoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved,
                                                                                                                       grdOperacao.ColumnMoved, _
                                                                                                                       grdServicoTerceiros.ColumnMoved


        Try

            UpdateConfiguraGrid(sender, _
                                iFormulario)

            AjustarChildTables(sender, e)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn,
                                                                                                                        grdOperacao.SizingColumn, _
                                                                                                                        grdServicoTerceiros.SizingColumn

        Try

            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub txtDespesaVariavel_ValueChanged(sender As Object, e As EventArgs) Handles txtDespesaVariavel.ValueChanged

        Try

            If ValidacaoPorcentagens() = False Then
                txtDespesaVariavel.Value = 0
                Exit Sub
            End If

            CalcularValorFinal()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: OPERAÇÃO :::"

    Private Sub btnInserirOperacao_Click(sender As Object, e As EventArgs) Handles btnInserirOperacao.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Or ValidacaoOperacao() = False Then Exit Sub

            Salvar()
            SalvarOperacao()
            LoadGridOperacao()
            NovoOperacao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirUsuario_Click(sender As Object, e As EventArgs) Handles btnExcluirOperacao.Click

        Try

            DeleteOperacao()
            LoadGridOperacao()
            NovoOperacao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOperacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOperacao.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdOperacao.CurrentColumn) Then Exit Sub

            Select Case grdOperacao.CurrentColumn.Key

                Case "editar" : EditarOperacao()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboOperacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperacao.SelectedIndexChanged

        Try

            txtCustoHora.Value = 0
            txtValorFinal.Value = 0

            If cboOperacao.SelectedIndex = -1 Then Exit Sub

            txtCustoHora.Value = LoadCodigo("sp_load_cadastro_basico_operacao_valor_hora " & goUsuario.iEmpresa & "," & cboOperacao.SelectedValue)

            CalcularValorFinal()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaDespesaVariavel(sender As Object, e As EventArgs) Handles txtAliquotaCOFINS.LostFocus, _
                                                                                 txtAliquotaCSLL.LostFocus, _
                                                                                 txtAliquotaICMS.LostFocus, _
                                                                                 txtAliquotaICMSReduzida.LostFocus, _
                                                                                 txtAliquotaIR.LostFocus, _
                                                                                 txtAliquotaISS.LostFocus, _
                                                                                 txtAliquotaPIS.LostFocus, _
                                                                                 txtPorcentagemReducaoBCICMS.LostFocus
        Try

            CalculaICMSReduzido()

            txtDespesaVariavel.Value = txtAliquotaPIS.Value + _
                                       txtAliquotaCOFINS.Value + _
                                       txtAliquotaISS.Value + _
                                       txtAliquotaIR.Value + _
                                       txtAliquotaCSLL.Value + _
                                       txtAliquotaICMSReduzida.Value

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO DE TERCEIROS :::"

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo.SelectedIndexChanged

        Try

            cboServicoTerceiros.SelectedIndex = -1
            cboServicoTerceiros.DataSource = Nothing

            If cboGrupo.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboServicoTerceiros, "sp_select_combo_cadastro_basico_operacao_grupo " & cboGrupo.SelectedValue & ", " & goUsuario.iEmpresa, True)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboServicoTerceiros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicoTerceiros.SelectedIndexChanged

        Try

            txtValorServico.Value = 0
            txtValorFinalServicoTerceiros.Value = 0

            If cboServicoTerceiros.SelectedIndex = -1 Then Exit Sub

            txtValorServico.Value = LoadCodigo("sp_load_cadastro_basico_operacao_valor_hora " & goUsuario.iEmpresa & "," & cboServicoTerceiros.SelectedValue)

            CalcularValorFinal()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnInserirServicoTerceiros_Click(sender As Object, e As EventArgs) Handles btnInserirServicoTerceiros.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Or ValidacaoServicoTerceiros() = False Then Exit Sub

            Salvar()
            SalvarServicoTerceiros()
            LoadGridServicoTerceiros()
            NovoServicoTerceiros()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirServicoTerceiros_Click(sender As Object, e As EventArgs) Handles btnExcluirServicoTerceiros.Click

        Try

            DeleteServicoTerceiros()
            LoadGridServicoTerceiros()
            NovoServicoTerceiros()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdServicoTerceiros_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdServicoTerceiros.RowDoubleClick

        Try

            If IsNothing(grdServicoTerceiros.CurrentColumn) Then Exit Sub

            Select Case grdServicoTerceiros.CurrentColumn.Key

                Case "editar" : EditarServicoTerceiros()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CONTRATO :::"

    Private Sub ConfigurarUserControl()

        Try

            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao_orcamento_processo_produtivo " & goUsuario.iEmpresa)
            LoadCombo(cboGrupo, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa, False)

            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now) : dtpDataInicioFiltro.Checked = True
            dtpDataTerminoFiltro.Value = Now : dtpDataTerminoFiltro.Checked = False

            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdOperacao, iFormulario)
            ConfiguraGrid(grdServicoTerceiros, iFormulario)

            tabMain.TabPages.Remove(pagDados)

            txtNumeroContratoFiltro.Focus()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub Editar()

        Try

            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Novo()

                btnSalvar.Tag = grdListagem.GetValue("codigo")

                oClsUsrCadContrato.LoadDados(btnSalvar.Tag, _
                                             txtNumeroContrato, _
                                             dtpDataContrato, _
                                             cboCliente, _
                                             txtDescricao, _
                                             txtPorcentagemReducaoBCICMS, _
                                             txtAliquotaICMS, _
                                             txtAliquotaPIS, _
                                             txtAliquotaCOFINS, _
                                             txtAliquotaISS, _
                                             txtAliquotaIR, _
                                             txtAliquotaCSLL, _
                                             txtDespesaVariavel, _
                                             txtDespesaFixa)

                LoadGridOperacao()
                LoadGridServicoTerceiros()

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                dtpDataContrato.Focus()

            Else
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    Cursor.Current = Cursors.WaitCursor

                    For Each oRow As GridEXRow In grdListagem.GetCheckedRows

                        If oRow.Cells("numero_orcamento").Value > 0 Then
                            MsgBox("Não é possível deletar o contrato n° " & oRow.Cells("numero_contrato").Value & " pois ele está vinculado ao orçamento n° " & oRow.Cells("numero_orcamento").Value, MsgBoxStyle.Exclamation, "Validação")
                            Exit Sub
                        End If

                    Next

                    oClsUsrCadContrato.Delete()

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            frmMain.errInfo.Clear()

            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpProcessoProdutivo)
            LimparCamposGroupBox(grpServicoTerceiros)
            btnSalvar.Tag = ""
            btnInserirOperacao.Tag = ""
            btnInserirServicoTerceiros.Tag = ""

            grdOperacao.DataSource = Nothing
            grdServicoTerceiros.DataSource = Nothing

            LiberarCampos()

            dtpDataContrato.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadContrato.Update(btnSalvar.Tag, _
                                          dtpDataContrato.Value, _
                                          cboCliente.SelectedValue, _
                                          txtDescricao.Text.Trim, _
                                          txtPorcentagemReducaoBCICMS.Value, _
                                          txtAliquotaICMS.Value, _
                                          txtAliquotaPIS.Value, _
                                          txtAliquotaCOFINS.Value, _
                                          txtAliquotaISS.Value, _
                                          txtAliquotaIR.Value, _
                                          txtAliquotaCSLL.Value, _
                                          txtDespesaFixa.Value, _
                                          txtDespesaVariavel.Value)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadContrato.Insert(dtpDataContrato.Value, _
                                          cboCliente.SelectedValue, _
                                          txtDescricao.Text.Trim, _
                                          btnSalvar, _
                                          txtNumeroContrato, _
                                          txtPorcentagemReducaoBCICMS.Value, _
                                          txtAliquotaICMS.Value, _
                                          txtAliquotaPIS.Value, _
                                          txtAliquotaCOFINS.Value, _
                                          txtAliquotaISS.Value, _
                                          txtAliquotaIR.Value, _
                                          txtAliquotaCSLL.Value, _
                                          txtDespesaFixa.Value, _
                                          txtDespesaVariavel.Value)

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadContrato.LoadGrid(grdListagem, _
                                        IIf(IsNumeric(txtNumeroContratoFiltro.Text), txtNumeroContratoFiltro.Text, -1), _
                                        IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                        IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                        IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue))

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboCliente, lblCliente) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CalculaICMSReduzido()

        Try

            Dim dAliquotaICMS As Double = 0
            Dim dReducaoBCICMS As Double = 0

            If txtPorcentagemReducaoBCICMS.Value <= 0 Or txtAliquotaICMS.Value <= 0 Then
                dAliquotaICMS = txtAliquotaICMS.Value

            Else
                dReducaoBCICMS = txtPorcentagemReducaoBCICMS.Value / 100
                dAliquotaICMS = Math.Round(txtAliquotaICMS.Value * (1 - dReducaoBCICMS), 2)
            End If

            txtAliquotaICMSReduzida.Value = dAliquotaICMS

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LiberarCampos()

        Try

            Dim bEnabled As Boolean = True

            If grdOperacao.GetDataRows.Count > 0 Or grdServicoTerceiros.GetDataRows.Count > 0 Then
                bEnabled = False
            End If

            txtPorcentagemReducaoBCICMS.Enabled = bEnabled
            txtAliquotaICMS.Enabled = bEnabled
            txtAliquotaICMSReduzida.Enabled = bEnabled
            txtAliquotaPIS.Enabled = bEnabled
            txtAliquotaCOFINS.Enabled = bEnabled
            txtAliquotaISS.Enabled = bEnabled
            txtAliquotaIR.Enabled = bEnabled
            txtAliquotaCSLL.Enabled = bEnabled
            txtDespesaVariavel.Enabled = bEnabled
            txtDespesaFixa.Enabled = bEnabled

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: OPERAÇÃO :::"

    Private Sub NovoOperacao()

        Try

            LimparCamposGroupBox(grpProcessoProdutivo)
            btnInserirOperacao.Tag = ""

            cboOperacao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarOperacao()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnInserirOperacao.Tag) Then

                oClsUsrCadContrato.UpdateOperacao(btnSalvar.Tag, _
                                                  btnInserirOperacao.Tag, _
                                                  cboOperacao.SelectedValue, _
                                                  txtQuantidadeHoras.Value, _
                                                  txtCustoHora.Value, _
                                                  txtPorcentagemLucro.Value, _
                                                  txtValorFinal.Value)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadContrato.InsertOperacao(btnSalvar.Tag, _
                                                  cboOperacao.SelectedValue, _
                                                  txtQuantidadeHoras.Value, _
                                                  txtCustoHora.Value, _
                                                  txtPorcentagemLucro.Value, _
                                                  txtValorFinal.Value)

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridOperacao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadContrato.LoadGridOperacao(grdOperacao,
                                                btnSalvar.Tag)

            LiberarCampos()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DeleteOperacao()

        Try

            If VerificaSelecaoRow(grdOperacao) = True Then

                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    For Each oRow As GridEXRow In grdOperacao.GetCheckedRows

                        If oRow.Cells("numero_orcamento").Value > 0 Then
                            MsgBox("Não é possível deletar essa operação pois ela está vinculada ao orçamento n° " & grdOperacao.GetValue("numero_orcamento"), MsgBoxStyle.Exclamation, "Validação")
                            Exit Sub
                        End If

                    Next

                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrCadContrato.DeleteOperacao(btnSalvar.Tag)

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoOperacao() As Boolean

        Try

            If ValidaCampo(cboOperacao, lblOperacao) = False Then Return False
            If ValidaCampo(txtQuantidadeHoras, lblQuantidadeHoras, True) = False Then Return False

            If oClsUsrCadContrato.ValidacaoOperacao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                    IIf(IsNumeric(btnInserirOperacao.Tag), btnInserirOperacao.Tag, -1), _
                                                    cboOperacao.SelectedValue) = False Then
                MsgBox("Essa operação já existe para este contrato!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If ValidaCampo(txtPorcentagemLucro, lblPorcentagemLucro, True) = False Then Return False

            If ValidacaoPorcentagens() = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarOperacao()

        Try

            If VerificaDireito(iFormulario, gcUpdate) = True Then

                If grdOperacao.GetValue("numero_orcamento") > 0 Then
                    MsgBox("Não é possível editar essa operação pois ela está vinculada ao orçamento n° " & grdOperacao.GetValue("numero_orcamento"), MsgBoxStyle.Exclamation, "Validação")
                    Exit Sub
                End If

                NovoOperacao()

                cboOperacao.SelectedValue = grdOperacao.GetValue("codigo_operacao")
                txtQuantidadeHoras.Value = grdOperacao.GetValue("quantidade_horas")
                txtCustoHora.Value = grdOperacao.GetValue("custo_hora")
                txtCustoTotal.Value = grdOperacao.GetValue("custo_total")
                txtPorcentagemLucro.Value = grdOperacao.GetValue("porcentagem_lucro")
                txtValorFinal.Value = grdOperacao.GetValue("valor_final")
                btnInserirOperacao.Tag = grdOperacao.GetValue("codigo")

                cboOperacao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalcularValorFinal() Handles txtPorcentagemLucro.LostFocus, _
                                             txtPorcentagemLucroServicoTerceiros.LostFocus, _
                                             txtDespesaVariavel.LostFocus, _
                                             txtDespesaFixa.LostFocus, _
                                             txtValorServico.LostFocus, _
                                             txtQuantidadeHoras.LostFocus, _
                                             txtCustoHora.LostFocus

        Try

            txtCustoTotal.Value = txtCustoHora.Value * txtQuantidadeHoras.Value

            If ValidacaoPorcentagens() = False Then Exit Sub

            Dim dPorcentagemCusto As Double = 0

            If txtCustoHora.Value > 0 Then
                dPorcentagemCusto = 100 - txtDespesaFixa.Value - txtDespesaVariavel.Value - txtPorcentagemLucro.Value
                txtValorFinal.Value = txtCustoTotal.Value / (dPorcentagemCusto / 100.0)
            End If

            If txtValorServico.Value > 0 Then
                dPorcentagemCusto = 100 - txtDespesaFixa.Value - txtDespesaVariavel.Value - txtPorcentagemLucroServicoTerceiros.Value
                txtValorFinalServicoTerceiros.Value = txtValorServico.Value / (dPorcentagemCusto / 100.0)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function ValidacaoPorcentagens() As Boolean

        Try

            If txtDespesaFixa.Value + txtDespesaVariavel.Value + txtPorcentagemLucro.Value + txtPorcentagemLucroServicoTerceiros.Value >= 100 Then
                MsgBox("A soma das porcentagens de Despesa Fixa, Despesa Variável e Margem de Lucro não pode ser igual ou superior a 100%.")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: SERVIÇO DE TERCEIROS :::"

    Private Sub NovoServicoTerceiros()

        Try

            LimparCamposGroupBox(grpServicoTerceiros)
            btnInserirServicoTerceiros.Tag = ""

            cboGrupo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarServicoTerceiros()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnInserirServicoTerceiros.Tag) Then

                oClsUsrCadContrato.UpdateServicoTerceiros(btnSalvar.Tag, _
                                                          btnInserirServicoTerceiros.Tag, _
                                                          cboServicoTerceiros.SelectedValue, _
                                                          txtValorServico.Value, _
                                                          txtPorcentagemLucroServicoTerceiros.Value, _
                                                          txtValorFinalServicoTerceiros.Value)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadContrato.InsertServicoTerceiros(btnSalvar.Tag, _
                                                          cboServicoTerceiros.SelectedValue, _
                                                          txtValorServico.Value, _
                                                          txtPorcentagemLucroServicoTerceiros.Value, _
                                                          txtValorFinalServicoTerceiros.Value)

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridServicoTerceiros()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadContrato.LoadGridServicoTerceiros(grdServicoTerceiros,
                                                        btnSalvar.Tag)

            LiberarCampos()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteServicoTerceiros()

        Try

            If VerificaSelecaoRow(grdServicoTerceiros) = True Then

                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    For Each oRow As GridEXRow In grdServicoTerceiros.GetCheckedRows

                        If oRow.Cells("numero_orcamento").Value > 0 Then
                            MsgBox("Não é possível deletar esse serviço pois ele está vinculada ao orçamento n° " & grdServicoTerceiros.GetValue("numero_orcamento"), MsgBoxStyle.Exclamation, "Validação")
                            Exit Sub
                        End If

                    Next

                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrCadContrato.DeleteServicoTerceiros(btnSalvar.Tag)

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoServicoTerceiros() As Boolean

        Try

            If ValidaCampo(cboGrupo, lblGrupo) = False Then Return False
            If ValidaCampo(cboServicoTerceiros, lblServicoTerceiros) = False Then Return False

            If oClsUsrCadContrato.ValidacaoServicoTerceiros(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                            IIf(IsNumeric(btnInserirServicoTerceiros.Tag), btnInserirServicoTerceiros.Tag, -1), _
                                                            cboServicoTerceiros.SelectedValue) = False Then
                MsgBox("Esse serviço já existe para este contrato!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If ValidaCampo(txtValorServico, lblValorServico, True) = False Then Return False
            If ValidaCampo(txtPorcentagemLucroServicoTerceiros, lblPorcentagemLucroServicoTerceiros, True) = False Then Return False

            If ValidacaoPorcentagens() = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarServicoTerceiros()

        Try

            If VerificaDireito(iFormulario, gcUpdate) = True Then

                If grdServicoTerceiros.GetValue("numero_orcamento") > 0 Then
                    MsgBox("Não é possível editar esse serviço pois ele está vinculado ao orçamento n° " & grdOperacao.GetValue("numero_orcamento"), MsgBoxStyle.Exclamation, "Validação")
                    Exit Sub
                End If

                NovoServicoTerceiros()

                cboGrupo.SelectedValue = grdServicoTerceiros.GetValue("codigo_grupo")
                cboServicoTerceiros.SelectedValue = grdServicoTerceiros.GetValue("codigo_operacao")
                txtValorServico.Value = grdServicoTerceiros.GetValue("valor_servico")
                txtPorcentagemLucroServicoTerceiros.Value = grdServicoTerceiros.GetValue("porcentagem_lucro")
                txtValorFinalServicoTerceiros.Value = grdServicoTerceiros.GetValue("valor_final")
                btnInserirServicoTerceiros.Tag = grdServicoTerceiros.GetValue("codigo")

                cboGrupo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
