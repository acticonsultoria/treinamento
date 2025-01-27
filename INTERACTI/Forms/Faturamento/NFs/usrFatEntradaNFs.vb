Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO

Public Class usrFatEntradaNFs

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEntradaNFs As New clsUsrFatEntradaNFs
    Private lCodigoEmissaoCapa As Long
    Private lCodigoTituloCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFatEntradaNFs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEPPrestador" : Call btnProcurarCEPPrestador_Click(btnProcurarCEPPrestador, System.EventArgs.Empty)
                        Case "cboPrestador" : Call btnProcurarPrestador_Click(btnProcurarPrestador, System.EventArgs.Empty)
                        Case "cboServico" : Call btnProcurarServico_Click(btnProcurarServico, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboPrestador" : Call LoadCombo(cboPrestador, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboPaisPrestador" : Call LoadCombo(cboPaisPrestador, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboServico" : Call cboPedidoCompra_SelectedIndexChanged(cboPedidoCompra, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboPrestador" : Call btnCadastrarPrestador_Click(btnCadastrarPrestador, System.EventArgs.Empty)
                        Case "cboPaisPrestador" : Call btnCadastrarPaisPrestador_Click(btnCadastrarPaisPrestador, System.EventArgs.Empty)
                        Case "cboServico" : Call btnCadastrarServico_Click(btnCadastrarServico, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFatEntradaNFs_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFatEntradaNFs_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFs
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNFs)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

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

            'Exclui Nota Fiscal
            Call ExcluirCapa()

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

            'Limpa Controles
            Call Novo()

            'Configura Valor Default
            'Call ConfigureValorDefault(Me)

            'Seta Focu
            cboTipoNotaFiscal.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Limpa Controles
            Call Novo()

            'Alterna Aba                
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboTipoNotaFiscal.Focus()

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
            txtNotaFiscalFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConsultarNFSe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarNFSe.Click

        Try

            'Verifica se for Preenchido o Código de Verificação
            If ValidaCampo(txtCodigoVerificacaoNFSe, lblCodigoVerificacaoNFSe, TipoCampo.texto) = False Then
                txtCodigoVerificacaoNFSe.Focus()
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados
            Dim oClsFatEntradaNFSeSJC As New clsFatEntradaNFSeSJC(txtCodigoVerificacaoNFSe.Text.Trim)



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Verifica se foi encontrada a Nota Fiscal
            'If oClsFatEntradaNFSeSJC.CNPJTomador = "" Then
            '    MsgBox("Nota Fiscal não foi encontrada. Favor verificar o Código de Verificação", MsgBoxStyle.Information, Me.Parent.Text)
            '    Exit Sub
            'End If
            ''Verifica se a Nota Fiscal foi Emitida para a Empresa
            'If oClsFatEntradaNFSeSJC.CNPJTomador.Trim.Replace(".", "").Replace("/", "").Replace("-", "") <> goEmitente.sCNPJ.Replace(".", "").Replace("/", "").Replace("-", "") Then
            '    MsgBox("Esta Nota Fiscal não foi Emitida para a Empresa: " & vbCrLf & goEmitente.sRazaoSocial & ".", MsgBoxStyle.Information, Me.Parent.Text)
            '    Exit Sub
            'End If

            'Verifica se o Cliente está cadastrado se não cadastra
            oClsFatEntradaNFs.VerificaPrestador(cboPrestador, _
                                                oClsFatEntradaNFSeSJC.CNPJPrestador.Trim, _
                                                oClsFatEntradaNFSeSJC.RazaoSocialPrestador.Trim, _
                                                "", _
                                                oClsFatEntradaNFSeSJC.InscricaoMunicipalPrestador.Trim, _
                                                oClsFatEntradaNFSeSJC.CEPPrestador.Trim, _
                                                oClsFatEntradaNFSeSJC.EnderecoPrestador.Trim, _
                                                "", _
                                                "", _
                                                oClsFatEntradaNFSeSJC.ComplementoPrestador.Trim, _
                                                oClsFatEntradaNFSeSJC.TelefonePrestador.Trim, _
                                                oClsFatEntradaNFSeSJC.EmailPrestador.Trim)

            'Carrega Dados da NFs
            txtNotaFiscal.Text = oClsFatEntradaNFSeSJC.NotaFiscal
            txtSerie.Text = "1"
            dtpDataEmissao.Value = oClsFatEntradaNFSeSJC.Data
            dtpDataEntrada.Value = oClsFatEntradaNFSeSJC.Data
            cboServico.SelectedValue = LoadDescricao("sp_select_cadastro_basico_codigo_item_servico '" & oClsFatEntradaNFSeSJC.CodigoServico & "', '" & oClsFatEntradaNFSeSJC.CodigoTributacaoServico & "', " & goUsuario.iEmpresa)
            txtQuantidade.Value = 1
            txtValorServicoUnitario.Value = oClsFatEntradaNFSeSJC.ValorServico
            txtValorServico.Value = oClsFatEntradaNFSeSJC.ValorServico
            txtValorDescontoCondicionado.Value = oClsFatEntradaNFSeSJC.ValorDescontoCondicionado
            txtValorDescontoIncondicionado.Value = oClsFatEntradaNFSeSJC.ValorDescontoIncondicionado
            txtValorLiquido.Value = oClsFatEntradaNFSeSJC.ValorLiquido
            txtOutrasRetencoes.Value = oClsFatEntradaNFSeSJC.OutrasRetencoes
            txtValorDeducoes.Value = oClsFatEntradaNFSeSJC.DeducoesEmLei
            txtBaseCalculo.Value = oClsFatEntradaNFSeSJC.ValorBaseCalculo
            cboISSRetido.SelectedValue = oClsFatEntradaNFSeSJC.ReterISS
            txtAliquotaISS.Value = oClsFatEntradaNFSeSJC.AliquotaISS
            txtDescricao.Text = oClsFatEntradaNFSeSJC.Servico

            'Verifica se foi selecionado algum Registro
            If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscalServico.NotaFiscal) Then

                'Impostos
                txtAliquotaPIS.Value = oClsFatEntradaNFSeSJC.ValorPIS
                txtAliquotaCOFINS.Value = oClsFatEntradaNFSeSJC.ValorCOFINS
                txtAliquotaINSS.Value = oClsFatEntradaNFSeSJC.ValorINSS
                txtAliquotaCSLL.Value = oClsFatEntradaNFSeSJC.ValorCSLL
                txtAliquotaIR.Value = oClsFatEntradaNFSeSJC.ValorIR

            Else

                'Impostos
                txtAliquotaPIS.Value = Math.Round((oClsFatEntradaNFSeSJC.ValorPIS / oClsFatEntradaNFSeSJC.ValorBaseCalculo) * 100.0, 2)
                txtAliquotaCOFINS.Value = Math.Round((oClsFatEntradaNFSeSJC.ValorCOFINS / oClsFatEntradaNFSeSJC.ValorBaseCalculo) * 100.0, 2)
                txtAliquotaINSS.Value = Math.Round((oClsFatEntradaNFSeSJC.ValorINSS / oClsFatEntradaNFSeSJC.ValorBaseCalculo) * 100.0, 2)
                txtAliquotaCSLL.Value = Math.Round((oClsFatEntradaNFSeSJC.ValorCSLL / oClsFatEntradaNFSeSJC.ValorBaseCalculo) * 100.0, 2)
                txtAliquotaIR.Value = Math.Round((oClsFatEntradaNFSeSJC.ValorIR / oClsFatEntradaNFSeSJC.ValorBaseCalculo) * 100.0, 2)

            End If
            


            'Procura CEP
            Call btnProcurarCEPPrestador_Click(btnProcurarCEPPrestador, System.EventArgs.Empty)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoNotaFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoNotaFiscal.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtNotaFiscal.Enabled = False
            txtSerie.Enabled = False
            dtpDataEmissao.Enabled = False
            txtCodigoVerificacaoNFSe.Enabled = False
            btnConsultarNFSe.Enabled = False

            'Limpa Controles
            txtNotaFiscal.Text = ""
            txtSerie.Text = ""
            dtpDataEmissao.Value = Now.Date
            dtpDataEntrada.Value = Now.Date
            txtCodigoVerificacaoNFSe.Text = ""

            'Verifica se foi selecionado algum Registro
            If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscalServico.NotaFiscal) Then
                txtNotaFiscal.Enabled = True
                txtSerie.Enabled = True
                dtpDataEmissao.Enabled = True
            ElseIf cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscalServico.NotaFiscalJoseense) Then
                txtCodigoVerificacaoNFSe.Enabled = True
                btnConsultarNFSe.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "arquivo" : Call ListaArquivo("tb_fat_entrada_nfs_servico", grdListagem.CurrentRow.Cells("codigo").Value)
                Case "editar" : Call EditarNotaFiscal(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "historico" : Call HistoricoNotaFiscal()
                Case "cancelar" : Call CancelarNotaFiscal()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FaturamentoEntradaNFs, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoEntradaNFs)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEntradaNFs, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Torna Invisível Controles
            chkCalculoImpostoManual.Visible = False

            Select Case e.Page.Name

                Case "pagServico"
                    'Torna Visivel Controles
                    chkCalculoImpostoManual.Visible = True

                Case "pagDadosNFs"
                    'Torna Invisível Controles
                    chkCalculoImpostoManual.Visible = False

                Case "pagCobranca"
                    'Torna Invisível Controles
                    chkCalculoImpostoManual.Visible = False

                Case "pagArquivo"
                    'Torna Invisível Controles
                    chkCalculoImpostoManual.Visible = False

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGastoDespesa_Click(sender As Object, e As EventArgs) Handles btnProcurarCentroGastoDespesa.Click
        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGastoDespesa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: PRESTADOR :::"

    Private Sub btnCadastrarPrestador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPrestador.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboPrestador, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboPrestador.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPaisPrestador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisPrestador.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo            
            LoadCombo(cboPaisPrestador, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

            'Seta Focu
            cboPaisPrestador.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCEPPrestador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEPPrestador.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCEPPrestador.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPPrestador.Text.Trim, "-", "")), _
                           cboPaisPrestador, _
                           cboUFPrestador, _
                           cboMunicipioPrestador, _
                           txtBairroPrestador, _
                           txtLogradouroPrestador, _
                           txtComplementoPrestador)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarPrestador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarPrestador.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboPrestador

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboPrestador.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboPrestador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPrestador.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Destinatário
            If cboPrestador.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                txtCNPJPrestador.Enabled = False : txtCNPJPrestador.Text = ""
                txtInscricaoEstadualPrestador.Enabled = False : txtInscricaoEstadualPrestador.Text = ""
                txtInscricaoMunicipalPrestador.Enabled = False : txtInscricaoMunicipalPrestador.Text = ""
                txtLogradouroPrestador.Enabled = False : txtLogradouroPrestador.Text = ""
                txtNumeroPrestador.Enabled = False : txtNumeroPrestador.Text = ""
                txtComplementoPrestador.Enabled = False : txtComplementoPrestador.Text = ""
                txtBairroPrestador.Enabled = False : txtBairroPrestador.Text = ""
                txtCEPPrestador.Enabled = False : txtCEPPrestador.Text = ""
                cboPaisPrestador.Enabled = False : cboPaisPrestador.SelectedIndex = -1
                cboUFPrestador.Enabled = False : cboUFPrestador.SelectedIndex = -1
                cboMunicipioPrestador.Enabled = False : cboMunicipioPrestador.SelectedIndex = -1
                txtTelefonePrestador.Enabled = False : txtTelefonePrestador.Text = ""
                txtEmailPrestador.Enabled = False : txtEmailPrestador.Text = ""
                txtCNPJPrestador.Tag = ""
                cboPedidoCompra.DataSource = Nothing : cboPedidoCompra.Text = ""

            Else

                'Carrega Combo
                Call LoadCombo(cboPedidoCompra, "sp_select_combo_compras_faturamento_servico_pedido " & goUsuario.iEmpresa & ", " & cboPrestador.SelectedValue & ", " & IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, "NULL"), False)

                'Carrega dados do Destinatário
                Call LoadDadosParceiroNegocio(cboPrestador.SelectedValue, _
                                              txtCNPJPrestador, _
                                              txtInscricaoEstadualPrestador, _
                                              txtInscricaoMunicipalPrestador, _
                                              txtLogradouroPrestador, _
                                              txtNumeroPrestador, _
                                              txtComplementoPrestador, _
                                              txtBairroPrestador, _
                                              txtCEPPrestador, _
                                              cboPaisPrestador, _
                                              cboUFPrestador, _
                                              cboMunicipioPrestador, _
                                              txtTelefonePrestador, _
                                              txtEmailPrestador)

                Call LoadCombo(cboTituloPrevisto, "sp_select_combo_financeiro_titulo_previsao " & goUsuario.iEmpresa & ", " & cboPrestador.SelectedValue)

                'Verifica o Tipo de Personalidade
                If txtCNPJPrestador.Tag = Personalidade.Fisica Then
                    lblCNPJPrestador.Text = "CPF:"
                    lblInscricaoEstadualPrestador.Text = "RG:"
                Else
                    lblCNPJPrestador.Text = "CNPJ:"
                    lblInscricaoEstadualPrestador.Text = "IE:"
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPaisPrestador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaisPrestador.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisPrestador.SelectedIndex = -1 Then
                'Limpa Controles
                cboUFPrestador.DataSource = Nothing
                cboUFPrestador.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboUFPrestador, "sp_select_combo_static_estado_pais " & cboPaisPrestador.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFPrestador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFPrestador.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFPrestador.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioPrestador.DataSource = Nothing
                cboMunicipioPrestador.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioPrestador, "sp_select_combo_static_municipio '" & cboUFPrestador.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub btnCalcularDuplicata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDuplicata.Click

        Try

            'Gera Parcela
            Call oClsFatEntradaNFs.GerarDuplicata(grdDuplicata, _
                                                  txtValorLiquido.Value, _
                                                  txtNumeroParcela.Value, _
                                                  txtIntervaloEntreParcelas.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaCobranca_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorOriginal.ValueChanged, _
                                                                                                          txtValorDesconto.ValueChanged

        Try

            'Calcula Valor Líquido
            txtValorLiquido.Value = grdServico.GetTotalRow.Cells("valor_liquido").Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVincular.Click

        Try
            'Validação
            If ValidaCampo(cboTituloPrevisto, lblTituloPrevisto) = False Then
                Exit Sub
            End If

            'Verifica se já foi salvo
            If CStr(btnSalvar.Tag) = "" Then
                MsgBox("Primeiramente, salve a NFs.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, Me.Parent.Text)
                Exit Sub
            End If



            'Carrega Dados
            oClsFatEntradaNFs.LoadControlesTituloPrevisao(cboTituloPrevisto.SelectedValue.ToString.Substring(0, 10), _
                                                          cboTituloPrevisto.SelectedValue.ToString.Substring(11, 9), _
                                                          txtNumDocumentoPrevisto, _
                                                          txtNumeroParcelaTituloPrevisto, _
                                                          txtValorPrevisto, _
                                                          dtpDataVencimentoPrevisto)

            'Atualiza Título
            oClsFatEntradaNFs.UpdateVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue.ToString.Substring(0, 10), _
                                                          cboTituloPrevisto.SelectedValue.ToString.Substring(11, 9), _
                                                          lCodigoTituloCapa)

            'Deleta Títuo Vinculado
            oClsFatEntradaNFs.DeleteVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue.ToString.Substring(0, 10), _
                                                          cboTituloPrevisto.SelectedValue.ToString.Substring(11, 9))

            'Desabilita Controles
            cboTituloPrevisto.Enabled = False
            cboTituloPrevisto.SelectedIndex = -1

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Private Sub btnProcurarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarServico.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.servico
            oComboBoxFind = cboServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)
            'Seta Parametros
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarServico.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadServico")

            'Carrega Combo            
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPedidoCompra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPedidoCompra.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Pedido de Compra
            If cboPedidoCompra.SelectedIndex = -1 Then
                'Carrega Combo - Serviço
                Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico), False)
                'Limpa Controles
                txtDescricao.Text = ""
                txtAliquotaISS.Value = 0
            Else
                'Carrega Combo - Serviço
                Call LoadCombo(cboServico, "sp_select_combo_compras_faturamento_servico_item " & goUsuario.iEmpresa & ", " & cboPedidoCompra.SelectedValue & ", " & IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, "NULL"), False)
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub cboServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Serviço
            If cboServico.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricao.Text = ""
                txtAliquotaISS.Value = 0
            Else
                'Verifica se foi Selecionado o Pedido de Compra
                If cboPedidoCompra.SelectedIndex = -1 Then

                    'Carrega Dados do Serviço
                    oClsFatEntradaNFs.LoadDadosServico(cboServico.SelectedValue, _
                                                       txtDescricao, _
                                                       txtAliquotaISS)

                Else

                    Dim sDados() As String
                    sDados = cboServico.SelectedValue.ToString.Split(";")

                    'Carrega Dados do Pedido de Compra
                    oClsFatEntradaNFs.LoadDadosServicoPedidoCompra(cboPedidoCompra.SelectedValue, _
                                                                   sDados(0), _
                                                                   sDados(1), _
                                                                   txtQuantidadePendente, _
                                                                   txtValorServicoUnitario, _
                                                                   txtDescricao, _
                                                                   txtValorDescontoIncondicionado, _
                                                                   cboCentroGasto, _
                                                                   cboContaContabil, _
                                                                   txtAliquotaISS, _
                                                                   cboISSRetido, _
                                                                   txtAliquotaPIS, _
                                                                   txtAliquotaCOFINS, _
                                                                   txtAliquotaCSLL, _
                                                                   txtAliquotaINSS, _
                                                                   txtAliquotaIR, _
                                                                   cboFormaPagamento, _
                                                                   IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                   txtNumeroParcela, _
                                                                   txtIntervaloEntreParcelas)

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub CalculaImpostos() Handles txtValorServico.ValueChanged, _
                                          txtValorDeducoes.ValueChanged, _
                                          txtValorDescontoCondicionado.ValueChanged, _
                                          txtValorDescontoIncondicionado.ValueChanged, _
                                          cboISSRetido.SelectedIndexChanged, _
                                          txtAliquotaPIS.ValueChanged, _
                                          txtAliquotaCOFINS.ValueChanged, _
                                          txtAliquotaINSS.ValueChanged, _
                                          txtAliquotaCSLL.ValueChanged, _
                                          txtAliquotaIR.ValueChanged, _
                                          txtAliquotaISS.ValueChanged

        Try

            'Verifica se a Nota Fiscal pode ser editada
            If btnSalvar.Enabled = True Then

                'Executa Eventos Pendentes do Sistema
                Application.DoEvents()

                'Seta Base de Calculo
                txtBaseCalculo.Value = txtValorServico.Value - txtValorDeducoes.Value - txtValorDescontoIncondicionado.Value

                'Verifica se a Base de Calculo é maior que R$ 215.05
                If txtBaseCalculo.Value >= 215.05 Then

                    'Verifica se foi seleiconado - Cálculo Imposto Manual
                    If chkCalculoImpostoManual.Checked = False Then

                        'Verifica se foi selecionado algum Registro
                        If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscalServico.NotaFiscal) Then
                            'PIS
                            txtValorPIS.Value = TruncarValor(txtBaseCalculo.Value * txtAliquotaPIS.Value / 100.0, 2)
                            'COFINS
                            txtValorCOFINS.Value = TruncarValor(txtBaseCalculo.Value * txtAliquotaCOFINS.Value / 100.0, 2)
                            'INSS
                            txtValorINSS.Value = TruncarValor(txtBaseCalculo.Value * txtAliquotaINSS.Value / 100.0, 2)
                            'CSLL
                            txtValorCSLL.Value = TruncarValor(txtBaseCalculo.Value * txtAliquotaCSLL.Value / 100.0, 2)

                        ElseIf cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscalServico.NotaFiscalJoseense) Then

                            'Carrega Dados
                            Dim oClsFatEntradaNFSeSJC As New clsFatEntradaNFSeSJC(txtCodigoVerificacaoNFSe.Text.Trim)

                            'PIS
                            txtValorPIS.Value = oClsFatEntradaNFSeSJC.ValorPIS
                            'COFINS
                            txtValorCOFINS.Value = oClsFatEntradaNFSeSJC.ValorCOFINS
                            'INSS
                            txtValorINSS.Value = oClsFatEntradaNFSeSJC.ValorINSS
                            'CSLL
                            txtValorCSLL.Value = oClsFatEntradaNFSeSJC.ValorCSLL
                            'IR
                            txtValorIR.Value = oClsFatEntradaNFSeSJC.ValorIR

                        End If

                    End If



                Else

                    'Zera Controles
                    txtValorPIS.Value = 0
                    txtValorCOFINS.Value = 0
                    txtValorINSS.Value = 0
                    txtValorCSLL.Value = 0

                End If

                'Verifica se foi seleiconado - Cálculo Imposto Manual
                If chkCalculoImpostoManual.Checked = False Then

                    'Verifica se foi selecionado algum Registro
                    If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscalServico.NotaFiscal) Then
                        'IR
                        txtValorIR.Value = TruncarValor(txtBaseCalculo.Value * txtAliquotaIR.Value / 100.0, 2)
                    End If

                End If


                'ISS
                If cboISSRetido.SelectedValue = False Then
                    txtValorISS.Value = TruncarValor(txtBaseCalculo.Value * txtAliquotaISS.Value / 100.0, 2)
                    txtValorISSRetido.Value = 0
                Else
                    txtValorISSRetido.Value = TruncarValor(txtBaseCalculo.Value * txtAliquotaISS.Value / 100.0, 2)
                    txtValorISS.Value = 0
                End If

                'Calcula Valor Líquido
                txtValorLiquidoNFSE.Value = txtValorServico.Value - _
                                            txtValorPIS.Value - _
                                            txtValorCOFINS.Value - _
                                            txtValorINSS.Value - _
                                            txtValorIR.Value - _
                                            txtValorCSLL.Value - _
                                            txtValorISSRetido.Value - _
                                            txtValorDescontoCondicionado.Value - _
                                            txtValorDescontoIncondicionado.Value

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub CalculaImpostosManual() Handles chkCalculoImpostoManual.CheckedChanged, _
                                                cboISSRetido.SelectedIndexChanged, _
                                                txtValorPIS.ValueChanged, _
                                                txtValorCOFINS.ValueChanged, _
                                                txtValorINSS.ValueChanged, _
                                                txtValorCSLL.ValueChanged, _
                                                txtValorIR.ValueChanged, _
                                                txtValorISS.ValueChanged

        Try

            'Verifica se a Nota Fiscal pode ser editada
            If btnSalvar.Enabled = True Then

                'Executa Eventos Pendentes do Sistema
                Application.DoEvents()

                'Verifica se foi seleiconado - Cálculo Imposto Manual
                If chkCalculoImpostoManual.Checked = True Then


                    'Calcula Valor Líquido
                    txtValorLiquidoNFSE.Value = txtValorServico.Value - _
                                                txtValorPIS.Value - _
                                                txtValorCOFINS.Value - _
                                                txtValorINSS.Value - _
                                                txtValorIR.Value - _
                                                txtValorCSLL.Value - _
                                                txtValorISSRetido.Value - _
                                                txtValorDescontoCondicionado.Value - _
                                                txtValorDescontoIncondicionado.Value

                    'Seta Valor Fatura
                    txtValorOriginal.Value = txtValorLiquidoNFSE.Value + txtValorDescontoCondicionado.Value + txtValorDescontoIncondicionado.Value
                    txtValorDesconto.Value = txtValorDescontoCondicionado.Value + txtValorDescontoIncondicionado.Value

                End If
            End If


        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularPIS.Click, _
                                                                                                      btnCalcularCOFINS.Click, _
                                                                                                      btnCalcularINSS.Click, _
                                                                                                      btnCalcularCSLL.Click
        Try

            Select Case sender.name
                Case "btnCalcularPIS" : txtValorPIS.Value = txtBaseCalculo.Value * txtAliquotaPIS.Value / 100.0
                Case "btnCalcularCOFINS" : txtValorCOFINS.Value = txtBaseCalculo.Value * txtAliquotaCOFINS.Value / 100.0
                Case "btnCalcularINSS" : txtValorINSS.Value = txtBaseCalculo.Value * txtAliquotaINSS.Value / 100.0
                Case "btnCalcularCSLL" : txtValorCSLL.Value = txtBaseCalculo.Value * txtAliquotaCSLL.Value / 100.0
            End Select

            'Calcula Valor Líquido
            txtValorLiquidoNFSE.Value = txtValorServico.Value - _
                                        txtValorPIS.Value - _
                                        txtValorCOFINS.Value - _
                                        txtValorINSS.Value - _
                                        txtValorIR.Value - _
                                        txtValorCSLL.Value - _
                                        txtValorISSRetido.Value - _
                                        txtValorDescontoCondicionado.Value - _
                                        txtValorDescontoIncondicionado.Value

            'Seta Valor Fatura
            txtValorOriginal.Value = txtValorLiquidoNFSE.Value + txtValorDescontoCondicionado.Value + txtValorDescontoIncondicionado.Value
            txtValorDesconto.Value = txtValorDescontoCondicionado.Value + txtValorDescontoIncondicionado.Value

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub CalculaValorServico(ByVal sender As Object, ByVal e As EventArgs) Handles txtValorServicoUnitario.ValueChanged, _
                                                                              txtQuantidade.ValueChanged

        Try

            'Seta Valor
            txtValorServico.Value = txtValorServicoUnitario.Value * txtQuantidade.Value

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub chkCalculoImpostoManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCalculoImpostoManual.CheckedChanged
        Try


            'Verifica se foi seleiconado
            If chkCalculoImpostoManual.Checked = True Then

                'Libera Edição dos Controles
                txtValorPIS.ReadOnly = False
                txtValorCOFINS.ReadOnly = False
                txtValorINSS.ReadOnly = False
                txtValorCSLL.ReadOnly = False
                txtValorIR.ReadOnly = False
                txtValorISSRetido.ReadOnly = False
            Else
                'Bloqueia Edição dos Controles
                txtValorPIS.ReadOnly = True
                txtValorCOFINS.ReadOnly = True
                txtValorINSS.ReadOnly = True
                txtValorCSLL.ReadOnly = True
                txtValorIR.ReadOnly = True
                txtValorISSRetido.ReadOnly = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboTituloPrevisto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTituloPrevisto.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum título previsto
            If cboTituloPrevisto.SelectedIndex <> -1 Then

                'Carrega Dados do Título Previsto
                oClsFatEntradaNFs.LoadControlesTituloPrevisao(cboTituloPrevisto.SelectedValue.ToString.Substring(0, 10), _
                                                                 cboTituloPrevisto.SelectedValue.ToString.Substring(11, 9), _
                                                                 txtNumDocumentoPrevisto, _
                                                                 txtNumeroParcelaTituloPrevisto, _
                                                                 txtValorPrevisto, _
                                                                 dtpDataVencimentoPrevisto)

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub btnInserirServico_Click(sender As Object, e As EventArgs) Handles btnInserirServico.Click

        Try

            'Caso a capa não tenha sido salva
            If IsNumeric(btnSalvar.Tag) = False Then

                'Valida os campos
                If ValidacaoCapa() = False Then Exit Sub

                'Salva Capa
                Call SalvarCapa()

            End If

            'Insere Dados do Serviço
            Call SalvarServico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNFs
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.FaturamentoEntradaNFs)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivo.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivo.SelectedValue)
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If IsNumeric(btnSalvar.Tag) = False AndAlso Validacao() = True Then
                'Salva Produto
                Call Salvar()
            End If

            'Valida Dados do Formulário
            If ValidacaoArquivo() = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_fat_entrada_nfs_servico", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_fat_entrada_nfs_servico", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_fat_entrada_nfs_servico", btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoArquivo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            'Deleta Registros
            Call DeleteArquivo()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoArquivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

        Try

            'Limpa Controle
            txtArquivo.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "editar" : Call EditarArquivo()
                Case "visualizar" : Call VisualizarDocumento(grdArquivo.CurrentRow.Cells("path").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.FaturamentoEntradaNFs)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.FaturamentoEntradaNFs, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.FaturamentoEntradaNFs, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DADOS DA DESPESA :::"
    Private Sub btnCadastrarContaContabil_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilDespesa.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabilDespesa, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabilDespesa.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarCentroGasto_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoDespesa.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGastodespesa, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGastodespesa.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirClassificao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirClassificao.Click

        Try

            'Insere Classificação
            Call InserirClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirClassificacao.Click

        Try

            'Exclui Classificação
            Call DeleteClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdClassificacao.RowDoubleClick

        Try

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdClassificacao) Then Exit Sub

            Select Case grdClassificacao.CurrentColumn.Key

                Case "editar" : Call EditarClassificacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEntradaNFs_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFs, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFs, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFs, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFs, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNFs, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarPrestador.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarPaisPrestador.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Carrega Combo - Filtro
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nfs_entrada")
            Call LoadCombo(cboTipoNotaFiscalFiltro, "sp_select_combo_static_tipo_nota_fiscal_servico")
            'Carrega Combo - Dados da NFs
            Call LoadCombo(cboTipoNotaFiscal, "sp_select_combo_static_tipo_nota_fiscal_servico")
            'Carrega Combo - Prestador
            Call LoadCombo(cboPrestador, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboPaisPrestador, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
            'Carrega Combo - Serviço     
            Call LoadCombo(cboPedidoCompra, "sp_select_combo_faturamento_entrada_nfs_pedido_compra " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico), False)
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboISSRetido)
            'Carrega Combo - Cobrança
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Carrega Combo - Dados de despesa
            Call LoadCombo(cboCentroGastoDespesa, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabilDespesa, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoDocumentoPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)
            'Seta Controles
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEntradaInicioFiltro.Value = Now.Date : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False

            'Carrega Configuração da NF-e
            Call LoadConfiguracaoNFSe()

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados do Emitente
            lblValorCNPJTomador.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualTomador.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoMunicipalTomador.Text = goEmitente.sInscricaoMunicipal
            lblValorRegimeTributarioTomador.Text = goEmitente.sRegimeTributario
            lblValorRazaoSocialTomador.Text = goEmitente.sRazaoSocial
            lblValorNomeFantasiaTomador.Text = goEmitente.sNomeFantasia
            lblValorLogradouroTomador.Text = goEmitente.sLogradouro
            lblValorNumeroTomador.Text = goEmitente.sNumero
            lblValorComplementoTomador.Text = goEmitente.sComplemento
            lblValorBairroTomador.Text = goEmitente.sBairro
            lblValorMunicipioTomador.Text = goEmitente.sMunicipio
            lblValorUFTomador.Text = goEmitente.sUF
            lblValorCEPEmiente.Text = goEmitente.sCEP
            lblValorPaisTomador.Text = goEmitente.sPais

            'Configurar Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaNFs)

            'Oculta Aba
            tabMain.TabPages.Remove(pagDados)
            chkCalculoImpostoManual.Visible = False

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

    Private Sub LoadGrid()

        Try

            'Váriaveis Locais
            Dim sTipoNotaFiscal As String = ""
            Dim sStatus As String = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Tipo de Nota Fiscal
            If cboTipoNotaFiscalFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboTipoNotaFiscalFiltro.CheckedValues)
                    sTipoNotaFiscal &= IIf(sTipoNotaFiscal = "", "", ",") & cboTipoNotaFiscalFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            oClsFatEntradaNFs.LoadGrid(grdListagem, _
                                       IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                       txtSerieFiltro.Text.Trim, _
                                       txtPedidoCompraFiltro.Text.Trim, _
                                       txtPrestadorFiltro.Text.Trim, _
                                       IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                       IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                       IIf(dtpDataEntradaInicioFiltro.Checked = False, "", dtpDataEntradaInicioFiltro.Value), _
                                       IIf(dtpDataEntradaTerminoFiltro.Checked = False, "", dtpDataEntradaTerminoFiltro.Value), _
                                       sTipoNotaFiscal, _
                                       sStatus)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Limpa Controles - NF
            cboTipoNotaFiscal.SelectedIndex = -1

            'Desabilita Controles
            txtNotaFiscal.Enabled = False
            txtSerie.Enabled = False
            dtpDataEmissao.Enabled = False
            txtCodigoVerificacaoNFSe.Enabled = False

            'Limpa Controles - Dados da NFs
            txtNotaFiscal.Text = ""
            txtSerie.Text = ""
            dtpDataEmissao.Value = Now.Date
            dtpDataEntrada.Value = Now.Date
            btnSalvar.Tag = ""

            'Limpa Controles - Dados da NFse
            txtCodigoVerificacaoNFSe.Text = ""

            'Limpa Controles - Tomador
            cboPrestador.SelectedIndex = -1

            'Limpa Controles - Serviço
            cboPedidoCompra.Enabled = True
            cboServico.Enabled = True
            cboPedidoCompra.SelectedIndex = -1 : cboPedidoCompra.Text = ""
            cboServico.SelectedIndex = -1 : cboServico.Tag = ""
            txtQuantidadePendente.Value = 0
            txtQuantidade.Value = 0
            txtDescricao.Text = ""
            txtValorServico.Value = 0
            txtValorServicoUnitario.Value = 0
            txtValorDescontoCondicionado.Value = 0
            txtValorDescontoIncondicionado.Value = 0
            txtValorLiquidoNFSE.Value = 0
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtOutrasRetencoes.Value = 0
            txtValorDeducoes.Value = 0
            txtBaseCalculo.Value = 0
            txtAliquotaISS.Value = 0
            cboISSRetido.SelectedValue = False
            txtAliquotaPIS.Value = 0
            txtAliquotaCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtAliquotaCSLL.Value = 0
            txtAliquotaIR.Value = 0
            txtValorISS.Value = 0
            txtValorISSRetido.Value = 0
            txtValorPIS.Value = 0
            txtValorCOFINS.Value = 0
            txtValorINSS.Value = 0
            txtValorCSLL.Value = 0
            txtValorIR.Value = 0
            chkCalculoImpostoManual.Checked = False
            grdServico.DataSource = Nothing

            'Limpa Controles - Cobrança
            txtFatura.Text = ""
            txtValorOriginal.Value = 0
            txtValorDesconto.Value = 0
            txtValorLiquido.Value = 0
            cboFormaPagamento.SelectedIndex = -1
            txtNumeroParcela.Value = 0
            txtIntervaloEntreParcelas.Value = 0
            grdDuplicata.DataSource = Nothing
            grpTituloPrevisto.Visible = False
            'Seta Focu - Aba
            tabDados.SelectedTab = pagDadosNFs

            'Seta Focu
            cboTipoNotaFiscal.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Insere Dados da Capa
            Call SalvarCapa()
            'Insere Dados do Tomador
            Call SalvarTomador()
            'Insere Dados do Prestador
            Call SalvarPrestador()
            'Insere Dados da Fatura
            Call SalvarFatura()
            'Integração
            Call Integracao()

            'Seta Código Titulo Capa
            lCodigoTituloCapa = LoadCodigo("sp_select_faturamento_servico_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

            'Atualiza os dados da despesa
            Call SalvarDadosDespesa()

            grpTituloPrevisto.Visible = True
            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarCapa()

        Try

            'Seta Parametros - Capa
            oClsFatEntradaNFs.CodigoTipoNotaFiscal = cboTipoNotaFiscal.SelectedValue
            oClsFatEntradaNFs.CodigoNFSCapa = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsFatEntradaNFs.NotaFiscal = txtNotaFiscal.Text.Trim
            oClsFatEntradaNFs.Serie = txtSerie.Text.Trim
            oClsFatEntradaNFs.DataEmissao = dtpDataEmissao.Value
            oClsFatEntradaNFs.DataEntrada = dtpDataEntrada.Value
            oClsFatEntradaNFs.CodigoVerificacao = txtCodigoVerificacaoNFSe.Text.Trim

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = True Then
                oClsFatEntradaNFs.UpdateCapa()
            Else
                oClsFatEntradaNFs.InsertCapa()
            End If

            'Seta Controle
            btnSalvar.Tag = oClsFatEntradaNFs.CodigoNFSCapa

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirCapa()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEntradaNFs.DeleteCapa()

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

    Private Sub CancelarNotaFiscal()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNFs, gcAdministrator) = True Then

                'Verifica se foi selecinado algum registro
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusNFsEntrada.AutorizadoUso) Then

                    'Váriavel - Formulário
                    Dim oForm As New frmFatEntradaNFsCancelar

                    'Seta Parâmetro
                    oForm.NotaFiscal = grdListagem.CurrentRow.Cells("nota_fiscal").Value
                    oForm.Serie = grdListagem.CurrentRow.Cells("serie").Value
                    oForm.DataEmissao = grdListagem.CurrentRow.Cells("data_emissao").Value
                    oForm.Prestador = grdListagem.CurrentRow.Cells("prestador").Value
                    oForm.CodigoVerificacao = grdListagem.CurrentRow.Cells("codigo_verificacao").Value
                    oForm.CodigoNFSCapa = grdListagem.CurrentRow.Cells("codigo").Value

                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Integração
                    Call Integracao()

                    'Carrega Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário a Nota Fiscal não pode ser Cancelada
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoNotaFiscal()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmFatEntradaNFsHistorico

            'Seta Parâmetro
            oForm.NotaFiscal = grdListagem.CurrentRow.Cells("nota_fiscal").Value
            oForm.Serie = grdListagem.CurrentRow.Cells("serie").Value
            oForm.DataEmissao = grdListagem.CurrentRow.Cells("data_emissao").Value
            oForm.Prestador = grdListagem.CurrentRow.Cells("prestador").Value
            oForm.CodigoVerificacao = grdListagem.CurrentRow.Cells("codigo_verificacao").Value
            oForm.CodigoNFSCapa = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarNotaFiscal(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNFs, gcUpdate) = True Then

                'Oculta Aba
                tabDados.Visible = False

                'Limpa Dados do Formulário
                Call Novo()

                'Seta Controle
                btnSalvar.Tag = lCodigoEmissaoCapa

                oClsFatEntradaNFs.CodigoNFSCapa = lCodigoEmissaoCapa

                'Carrega Dados da Nota Fiscal
                Call oClsFatEntradaNFs.LoadDadosNotaFiscal(lCodigoEmissaoCapa, _
                                                           cboTipoNotaFiscal, _
                                                           txtNotaFiscal, _
                                                           txtSerie, _
                                                           dtpDataEmissao, _
                                                           dtpDataEntrada, _
                                                           txtCodigoVerificacaoNFSe, _
                                                           cboPrestador, _
                                                           txtCNPJPrestador, _
                                                           txtInscricaoEstadualPrestador, _
                                                           txtInscricaoMunicipalPrestador, _
                                                           txtCEPPrestador, _
                                                           cboPaisPrestador, _
                                                           cboUFPrestador, _
                                                           cboMunicipioPrestador, _
                                                           txtLogradouroPrestador, _
                                                           txtNumeroPrestador, _
                                                           txtBairroPrestador, _
                                                           txtComplementoPrestador, _
                                                           txtTelefonePrestador, _
                                                           txtEmailPrestador, _
                                                           txtFatura, _
                                                           txtValorOriginal, _
                                                           txtValorDesconto, _
                                                           txtValorLiquido, _
                                                           cboFormaPagamento, _
                                                           txtNumeroParcela, _
                                                           txtIntervaloEntreParcelas, _
                                                           cboTipoDocumentoPagamento, _
                                                           txtDescritivoDespesa)
                'Carrega Grid de Serviços
                Call LoadGridServico()

                'Carrega Grid de Fatura - Duplicata
                Call oClsFatEntradaNFs.LoadGridFatura(grdDuplicata, _
                                                      lCodigoEmissaoCapa)

                'Carrega Grid - Arquivo
                Call LoadGridArquivoBD(grdArquivo, "tb_fat_entrada_nfs_servico", lCodigoEmissaoCapa)
                lCodigoTituloCapa = LoadCodigo("sp_select_faturamento_servico_codigo_titulo_capa " & btnSalvar.Tag & ", " & goUsuario.iEmpresa)

                Try
                    'Carrega a classificação
                    Dim oClsUsrFinDespesaLancamento As New clsUsrFinDespesaLancamento
                    oClsUsrFinDespesaLancamento.LoadGridClassificacao(grdClassificacao, lCodigoTituloCapa)

                Catch ex As Exception

                End Try


                'Carrega Dados do Titulo Vinculado
                oClsFatEntradaNFs.LoadDadosVinculoTituloPrevisto(lCodigoTituloCapa, _
                                                                 cboTituloPrevisto, _
                                                                 txtNumDocumentoPrevisto, _
                                                                 txtNumeroParcelaTituloPrevisto, _
                                                                 txtValorPrevisto, _
                                                                 dtpDataVencimentoPrevisto)

                grpTituloPrevisto.Visible = True
                'Seta Aba
                tabDados.SelectedTab = pagDadosNFs
                tabDados.Visible = True

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboTipoNotaFiscal.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Tipo de Nota Fiscal
            If ValidaCampo(cboTipoNotaFiscal, lblTipoNotaFiscal) = False Then
                tabDados.SelectedTab = pagDadosNFs
                cboTipoNotaFiscal.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nota Fiscal
            If ValidaCampo(txtNotaFiscal, lblNotaFiscal, TipoCampo.numero) = False Then
                tabDados.SelectedTab = pagDadosNFs
                txtNotaFiscal.Focus()
                Exit Function
            End If

            ''Verifica se foi Preenchido o Campo - Série
            'If ValidaCampo(txtSerie, lblSerie, TipoCampo.texto) = False Then
            '    tabDados.SelectedTab = pagDadosNFs
            '    txtSerie.Focus()
            '    Exit Function
            'End If

            'Verifica se a Data de Entrada é menor que a Data de Emissão
            If dtpDataEmissao.Value > dtpDataEntrada.Value Then
                frmMain.errInfo.SetError(lblDataEntrada, "A Data de Entrada não pode ser menor que a Data de Emissão da Nota Fiscal.")
                tabDados.SelectedTab = pagDadosNFs
                dtpDataEntrada.Focus()
                Exit Function
            End If

            'Verifica o Tipo de Nota Fiscal
            If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                'Verifica se foi Preenchido o Campo - Código de Verificação
                If ValidaCampo(txtCodigoVerificacaoNFSe, lblCodigoVerificacaoNFSe, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDadosNFs
                    txtCodigoVerificacaoNFSe.Focus()
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Serviço
            'If ValidaCampo(cboServico, lblServico) = False Then
            '    tabDados.SelectedTab = pagServico
            '    cboServico.Focus()
            '    Exit Function
            'End If

            ''Verifica se foi Preenchido o Campo - Quantidade
            'If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
            '    tabDados.SelectedTab = pagServico
            '    txtQuantidade.Focus()
            '    Exit Function
            'End If

            ''Verifica se a Quantidade é Válida
            'If txtQuantidadePendente.Value > 0 AndAlso _
            '   txtQuantidadePendente.Value < txtQuantidade.Value Then
            '    tabDados.SelectedTab = pagServico
            '    frmMain.errInfo.SetError(lblQuantidade, "A Quantidade não pode ser Maior que a Quantidade Pendente.")
            '    txtQuantidade.Focus()
            '    Exit Function
            'End If

            ''Verifica se foi Preenchido o Campo - Valor Unitário Serviço
            'If ValidaCampo(txtValorServicoUnitario, lblValorServicoUnitario, True) = False Then
            '    tabDados.SelectedTab = pagServico
            '    txtValorServicoUnitario.Focus()
            '    Exit Function
            'End If

            'Valida Dados do Prestador
            If ValidacaoPrestador() = False Then
                Exit Function
            End If

            'Valida Dados da Fatura
            If ValidacaoFatura() = False Then
                Exit Function
            End If

            If IsNumeric(btnSalvar.Tag) = False Then

                'Verifica se foi a Nota Fiscal é Válida
                If oClsFatEntradaNFs.ValidaDocumentoNFs(IIf(IsNumeric(btnSalvar.Tag) = False, 0, btnSalvar.Tag), _
                                                    txtNotaFiscal.Text, _
                                                    txtSerie.Text, _
                                                    cboPrestador.SelectedValue) = False Then
                    'Informa o Usuário que nf é inválida
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Nota Fiscal de Serviço já inserida no sistema.")
                    txtNotaFiscal.Focus()

                    Exit Function
                End If
            ElseIf oClsFatEntradaNFs.ValidaDocumentoNFs(btnSalvar.Tag, _
                                                    txtNotaFiscal.Text, _
                                                    txtSerie.Text, _
                                                    cboPrestador.SelectedValue) = False Then
                'Informa o Usuário que nf é inválida
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Nota Fiscal de Serviço já inserida no sistema.")
                txtNotaFiscal.Focus()

                Exit Function

            End If

            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoCapa() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCapa = False

            'Verifica se foi Preenchido o Campo - Tipo de Nota Fiscal
            If ValidaCampo(cboTipoNotaFiscal, lblTipoNotaFiscal) = False Then
                tabDados.SelectedTab = pagDadosNFs
                cboTipoNotaFiscal.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nota Fiscal
            If ValidaCampo(txtNotaFiscal, lblNotaFiscal, TipoCampo.numero) = False Then
                tabDados.SelectedTab = pagDadosNFs
                txtNotaFiscal.Focus()
                Exit Function
            End If

            'Verifica se a Data de Entrada é menor que a Data de Emissão
            If dtpDataEmissao.Value > dtpDataEntrada.Value Then
                frmMain.errInfo.SetError(lblDataEntrada, "A Data de Entrada não pode ser menor que a Data de Emissão da Nota Fiscal.")
                tabDados.SelectedTab = pagDadosNFs
                dtpDataEntrada.Focus()
                Exit Function
            End If

            'Verifica o Tipo de Nota Fiscal
            If cboTipoNotaFiscal.SelectedValue = CInt(TipoNotaFiscal.NotaFiscalEletronica) Then
                'Verifica se foi Preenchido o Campo - Código de Verificação
                If ValidaCampo(txtCodigoVerificacaoNFSe, lblCodigoVerificacaoNFSe, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDadosNFs
                    txtCodigoVerificacaoNFSe.Focus()
                    Exit Function
                End If
            End If

            If IsNumeric(btnSalvar.Tag) = False Then

                'Verifica se foi a Nota Fiscal é Válida
                If oClsFatEntradaNFs.ValidaDocumentoNFs(IIf(IsNumeric(btnSalvar.Tag) = False, 0, btnSalvar.Tag), _
                                                    txtNotaFiscal.Text, _
                                                    txtSerie.Text, _
                                                    cboPrestador.SelectedValue) = False Then
                    'Informa o Usuário que nf é inválida
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Nota Fiscal de Serviço já inserida no sistema.")
                    txtNotaFiscal.Focus()

                    Exit Function
                End If
            ElseIf oClsFatEntradaNFs.ValidaDocumentoNFs(btnSalvar.Tag, _
                                                    txtNotaFiscal.Text, _
                                                    txtSerie.Text, _
                                                    cboPrestador.SelectedValue) = False Then
                'Informa o Usuário que nf é inválida
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Nota Fiscal de Serviço já inserida no sistema.")
                txtNotaFiscal.Focus()

                Exit Function

            End If

            ValidacaoCapa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function



#End Region

#Region "::: PRESTADOR :::"

    Private Sub SalvarPrestador()

        Try

            'Seta Parametros
            oClsFatEntradaNFs.CodigoPrestador = cboPrestador.SelectedValue
            oClsFatEntradaNFs.CnpjCpfPrestador = txtCNPJPrestador.Text.Trim
            oClsFatEntradaNFs.InscricaoEstadualPrestador = txtInscricaoEstadualPrestador.Text.Trim
            oClsFatEntradaNFs.InscricaoMunicipalPrestador = txtInscricaoMunicipalPrestador.Text.Trim
            oClsFatEntradaNFs.CepPrestador = txtCEPPrestador.Text.Trim
            oClsFatEntradaNFs.CodigoPaisPrestador = cboPaisPrestador.SelectedValue
            oClsFatEntradaNFs.UFPrestador = cboUFPrestador.SelectedValue
            oClsFatEntradaNFs.CodigoMunicipioPrestador = cboMunicipioPrestador.SelectedValue
            oClsFatEntradaNFs.LogradouroPrestador = txtLogradouroPrestador.Text.Trim
            oClsFatEntradaNFs.NumeroPrestador = txtNumeroPrestador.Text.Trim
            oClsFatEntradaNFs.BairroPrestador = txtBairroPrestador.Text.Trim
            oClsFatEntradaNFs.ComplementoPrestador = txtComplementoPrestador.Text.Trim
            oClsFatEntradaNFs.TelefonePrestador = txtTelefonePrestador.Text.Trim
            oClsFatEntradaNFs.EmailPrestador = txtEmailPrestador.Text.Trim

            'Salva Dados do Prestador
            oClsFatEntradaNFs.DeletePrestador()
            oClsFatEntradaNFs.InsertPrestador()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPrestador() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPrestador = False

            'Verifica se foi Selecionado o Campo - Prestador
            If ValidaCampo(cboPrestador, lblPrestador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboPrestador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CNPJ /  CPF
            If ValidaCampo(txtCNPJPrestador, lblCNPJPrestador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtCNPJPrestador.Focus()
                Exit Function
            ElseIf txtCNPJPrestador.Tag = CInt(Personalidade.Juridica) Then
                If ValidaCNPJ(txtCNPJPrestador.Text) = False Then
                    frmMain.errInfo.SetError(lblCNPJPrestador, "Este CNPJ: " & txtCNPJPrestador.Text.Trim & " não é válido.")
                    tabDados.SelectedTab = pagDadosNFs : txtCNPJPrestador.Focus()
                    Exit Function
                End If
                'Verifica se foi Preenchido o Campo - Inscrição Municipal
                If ValidaCampo(txtInscricaoMunicipalPrestador, lblInscricaoMunicipalPrestador, TipoCampo.numero) = False Then
                    tabDados.SelectedTab = pagDadosNFs : txtInscricaoMunicipalPrestador.Focus()
                    Exit Function
                End If
            ElseIf txtCNPJPrestador.Tag = CInt(Personalidade.Fisica) Then
                If ValidaCPF(txtCNPJPrestador.Text) = False Then
                    frmMain.errInfo.SetError(lblCNPJPrestador, "Este CPF: " & txtCNPJPrestador.Text.Trim & " não é válido.")
                    tabDados.SelectedTab = pagDadosNFs : txtCNPJPrestador.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - CEP
            If ValidaCampo(txtCEPPrestador, lblCEPPrestador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtCEPPrestador.Focus()
                Exit Function
            ElseIf txtCEPPrestador.Text.Length <> 9 Then
                frmMain.errInfo.SetError(lblCEPPrestador, "Este CEP: " & txtCEPPrestador.Text.Trim & " está incompleto.")
                tabDados.SelectedTab = pagDadosNFs : txtCEPPrestador.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPaisPrestador, lblPaisPrestador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboPaisPrestador.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFPrestador, lblUFPrestador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboUFPrestador.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If ValidaCampo(cboMunicipioPrestador, lblMunicipioPrestador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboMunicipioPrestador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouroPrestador, lblLogradouroPrestador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtLogradouroPrestador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumeroPrestador, lblNumeroPrestador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtNumeroPrestador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bairro
            If ValidaCampo(txtBairroPrestador, lblBairroPrestador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtBairroPrestador.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoPrestador = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: TOMADOR :::"

    Private Sub SalvarTomador()

        Try

            'Salva Dados do Emitente
            oClsFatEntradaNFs.DeleteTomador()
            oClsFatEntradaNFs.InsertTomador()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub SalvarFatura()

        Try

            'Deleta Dados da Fatura
            oClsFatEntradaNFs.DeleteFatura()

            'Seta Parametros
            oClsFatEntradaNFs.Fatura = txtFatura.Text.Trim
            oClsFatEntradaNFs.ValorOriginal = txtValorOriginal.Value
            oClsFatEntradaNFs.ValorDesconto = txtValorDesconto.Value
            oClsFatEntradaNFs.ValorLiquido = txtValorLiquido.Value
            oClsFatEntradaNFs.NumeroParcela = txtNumeroParcela.Value
            oClsFatEntradaNFs.IntervaloParcela = txtIntervaloEntreParcelas.Value
            oClsFatEntradaNFs.CodigoFormaPagamentoNFe = cboFormaPagamento.SelectedValue

            'Salva Dados Fatura
            oClsFatEntradaNFs.InsertFatura()
            oClsFatEntradaNFs.InsertFaturaDuplicata(grdDuplicata)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoFatura() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFatura = False

            'Verifica se foi Selecionado o Campo - Forma de Pagamento
            If ValidaCampo(cboFormaPagamento, lblFormaPagamento) = False Then
                tabDados.SelectedTab = pagCobranca : cboFormaPagamento.Focus()
                Exit Function
            End If

            'Verifica se foi Gerado Parcelas
            If grdDuplicata.GetDataRows.Count > 0 Then
                If txtValorLiquido.Value <> grdDuplicata.GetTotalRow.Cells("valor").Value Then
                    frmMain.errInfo.SetError(lblValorLiquido, "A Soma dos Valores da Duplicata é diferente do Valor Líquido.")
                    tabDados.SelectedTab = pagCobranca : btnCalcularDuplicata.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoFatura = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Public Sub ListaArquivo(ByVal sTabela As String, _
                            ByVal lCodigo As Long, _
                            Optional ByVal iCodigo2 As Integer = -1)


        Try

            'Váriavel - Formulário
            Dim oForm As New frmArqListagem

            'Seta Parâmetros
            oForm.Table = sTabela
            oForm.Codigo = lCodigo
            oForm.Codigo2 = iCodigo2

            'Seta Tamanho / Posição do Controle
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Abre Formulário
            oForm.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        modFunction.DeleteArquivoBD("tb_fat_entrada_nfs_servico", oRow.Cells("path").Value, btnSalvar.Tag)
                        oRow.Delete()
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarArquivo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FaturamentoEntradaNFs, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                txtRevisaoArquivo.Text = grdArquivo.CurrentRow.Cells("revisao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = ""
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.RowIndex

                'Seta Focu
                cboTipoArquivo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles            
            txtDescricaoArquivo.Text = ""
            txtRevisaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            'Seta Focu
            txtDescricaoArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoArquivo = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Revisão
            If ValidaCampo(txtRevisaoArquivo, lblRevisaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If IsNumeric(btnInserirArquivo.Tag) = False Then
                If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Produto é Válido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirArquivo.Tag) Then
                iRow = grdArquivo.CurrentRow.RowIndex
            End If

            For Each oRow As GridEXRow In grdArquivo.GetDataRows
                If oRow.Cells("descricao").Value = txtDescricaoArquivo.Text.Trim And oRow.Cells("revisao").Value = txtRevisaoArquivo.Text.Trim And oRow.RowIndex <> iRow Then
                    frmMain.errInfo.SetError(lblDescricaoArquivo, "Esta Descrição / Revisão já se encontra associada a um Registro.")
                    txtDescricaoArquivo.Focus()
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: SERVIÇO :::"

    Public Function TruncarValor(ByVal dValor As Double, ByVal iCasasDecimais As Integer) As Double
        Try

            dValor = dValor * Math.Pow(10, iCasasDecimais)
            dValor = Math.Truncate(dValor)
            Return dValor / 100


        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarServico()

        Try

            If cboPedidoCompra.SelectedIndex <> -1 Then

                'Obtém dados do Pedido
                Dim oPedido() As String
                oPedido = cboServico.SelectedValue.ToString.Split(";")
                'Seta Parâmetros
                oClsFatEntradaNFs.CodigoPedidoVenda = cboPedidoCompra.SelectedValue
                oClsFatEntradaNFs.CodigoPedidoVendaItem = oPedido(0)
                oClsFatEntradaNFs.CodigoPedidoVendaItemEntrega = oPedido(1)
                oClsFatEntradaNFs.CodigoServico = oPedido(2)

            End If

            'If IsNumeric(cboServico.Tag) Then
            '    If cboServico.Tag <> oClsFatEntradaNFs.CodigoServico Then
            '        frmMain.errInfo.SetError(lblServico, "Não é possível inserir serviços diferentes.")
            '        Exit Sub
            '    End If
            'End If
           

            'Seta Parametros            
            oClsFatEntradaNFs.PedidoCompra = cboPedidoCompra.Text
            oClsFatEntradaNFs.Descricao = txtDescricao.Text.Trim
            oClsFatEntradaNFs.QuantidadePedido = txtQuantidade.Value
            oClsFatEntradaNFs.ValorServico = txtValorServico.Value
            oClsFatEntradaNFs.DescontoCondicional = txtValorDescontoCondicionado.Value
            oClsFatEntradaNFs.DescontoIncondicional = txtValorDescontoIncondicionado.Value
            oClsFatEntradaNFs.ValorLiquidoServico = txtValorLiquidoNFSE.Value
            oClsFatEntradaNFs.CodigoCentroGasto = IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue)
            oClsFatEntradaNFs.CodigoContaContabil = IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue)
            oClsFatEntradaNFs.OutrasReducoes = txtOutrasRetencoes.Value
            oClsFatEntradaNFs.ValorDeducoes = txtValorDeducoes.Value
            oClsFatEntradaNFs.BaseCalculo = txtBaseCalculo.Value
            oClsFatEntradaNFs.AliquotaISS = txtAliquotaISS.Value
            oClsFatEntradaNFs.ValorISS = txtValorISS.Value
            oClsFatEntradaNFs.ISSRetido = cboISSRetido.SelectedValue
            oClsFatEntradaNFs.ValorISSRetido = txtValorISSRetido.Value
            oClsFatEntradaNFs.AliquotaPIS = txtAliquotaPIS.Value
            oClsFatEntradaNFs.ValorPIS = txtValorPIS.Value
            oClsFatEntradaNFs.AliquotaCOFINS = txtAliquotaCOFINS.Value
            oClsFatEntradaNFs.ValorCOFINS = txtValorCOFINS.Value
            oClsFatEntradaNFs.AliquotaINSS = txtAliquotaINSS.Value
            oClsFatEntradaNFs.ValorINSS = txtValorINSS.Value
            oClsFatEntradaNFs.AliquotaCSLL = txtAliquotaCSLL.Value
            oClsFatEntradaNFs.ValorCSLL = txtValorCSLL.Value
            oClsFatEntradaNFs.AliquotaIR = txtAliquotaIR.Value
            oClsFatEntradaNFs.ValorIR = txtValorIR.Value
            oClsFatEntradaNFs.QuantidadePedido = txtQuantidade.Value
            oClsFatEntradaNFs.CalculoImpostoManual = IIf(chkCalculoImpostoManual.Checked = True, True, False)

            'Verifica se é de um Pedido de Venda
            If cboPedidoCompra.SelectedIndex <> -1 Then

                'Valida item
                For Each oRow As GridEXRow In grdServico.GetDataRows

                    If IsNumeric(btnInserirServico.Tag) = False And oRow.Cells("codigo_pedido_compra_item").Value = oClsFatEntradaNFs.CodigoPedidoVendaItem And oRow.Cells("codigo_pedido_compra").Value = cboPedidoCompra.SelectedValue Then
                        frmMain.errInfo.SetError(lblServico, "O item desse pedido já foi inserido!.")
                        Exit Sub
                    End If

                Next

            Else
                'Seta Parâmetros
                oClsFatEntradaNFs.CodigoPedidoVenda = -1
                oClsFatEntradaNFs.CodigoPedidoVendaItem = -1
                oClsFatEntradaNFs.CodigoPedidoVendaItemEntrega = -1
                oClsFatEntradaNFs.CodigoServico = cboServico.SelectedValue
            End If

            If IsNumeric(btnInserirServico.Tag) Then
                oClsFatEntradaNFs.UpdateServico(btnInserirServico.Tag)
            Else
                oClsFatEntradaNFs.InsertServico()
            End If

            Call NovoServico()
            Call LoadGridServico()

            'Seta Valor Fatura
            txtValorOriginal.Value = grdServico.GetTotalRow.Cells("valor_servico").Value
            txtValorDesconto.Value = grdServico.GetTotalRow.Cells("desconto_condicional").Value + grdServico.GetTotalRow.Cells("desconto_incondicional").Value
            txtValorLiquido.Value = grdServico.GetTotalRow.Cells("valor_liquido").Value

            'Gera Parcela
            Call oClsFatEntradaNFs.GerarDuplicata(grdDuplicata, _
                                                  txtValorLiquido.Value, _
                                                  txtNumeroParcela.Value, _
                                                  txtIntervaloEntreParcelas.Value)

            'Guarda o código do serviço para validação
            cboServico.Tag = oClsFatEntradaNFs.CodigoServico

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoServico() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoServico = False

            'Verifica se foi Selecionado o Campo - Serviço
            If ValidaCampo(cboServico, lblServico) = False Then
                tabDados.SelectedTab = pagServico : cboServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Discriminação
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagServico : txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor do Serviço
            If ValidaCampo(txtValorServico, lblValorServico, True) = False Then
                tabDados.SelectedTab = pagServico : txtValorServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Alíquota ISS
            If goEmitente.iRegimeTributario = goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroReal) Or goEmitente.iRegimeTributario = CInt(RegimeTributario.LucroPresumido) Then
                If ValidaCampo(txtAliquotaISS, lblAliquotaISS, True) = False Then
                    tabDados.SelectedTab = pagServico : txtAliquotaISS.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - ISS Retido
            If ValidaCampo(cboISSRetido, lblISSRetido) = False Then
                tabDados.SelectedTab = pagServico : cboISSRetido.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoServico = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGridServico()

        Try

            'Carrega grid serviço
            oClsFatEntradaNFs.LoadGridServico(grdServico, _
                                              btnSalvar.Tag)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoServico()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            cboPedidoCompra.SelectedIndex = -1
            txtDescricao.Text = ""
            txtQuantidade.Value = 0
            txtValorServico.Value = 0
            txtValorDescontoCondicionado.Value = 0
            txtValorDescontoIncondicionado.Value = 0
            txtValorLiquidoNFSE.Value = 0
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtOutrasRetencoes.Value = 0
            txtValorDeducoes.Value = 0
            txtBaseCalculo.Value = 0
            txtAliquotaISS.Value = 0
            txtValorISS.Value = 0
            cboISSRetido.SelectedIndex = -1
            txtValorISSRetido.Value = 0
            txtAliquotaPIS.Value = 0
            txtValorPIS.Value = 0
            txtAliquotaCOFINS.Value = 0
            txtValorCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtValorINSS.Value = 0
            txtAliquotaCSLL.Value = 0
            txtValorCSLL.Value = 0
            txtAliquotaIR.Value = 0
            txtValorIR.Value = 0
            txtQuantidade.Value = 0
            chkCalculoImpostoManual.Checked = False
            btnInserirServico.Tag = ""
            cboPedidoCompra.Enabled = True
            cboServico.Enabled = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteServicos()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdServico) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    oClsFatEntradaNFs.DeleteServicos()

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoServico()

                    'Seta Valor Fatura
                    txtValorOriginal.Value = grdServico.GetTotalRow.Cells("valor_servico").Value
                    txtValorDesconto.Value = grdServico.GetTotalRow.Cells("desconto_condicional").Value + grdServico.GetTotalRow.Cells("desconto_incondicional").Value
                    txtValorLiquido.Value = grdServico.GetTotalRow.Cells("valor_liquido").Value

                    'Gera Parcela
                    Call oClsFatEntradaNFs.GerarDuplicata(grdDuplicata, _
                                                          txtValorLiquido.Value, _
                                                          txtNumeroParcela.Value, _
                                                          txtIntervaloEntreParcelas.Value)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFatEntradaNFs.EditarServico(grdServico.CurrentRow.Cells("codigo").Value, _
                                            cboPedidoCompra, _
                                            cboServico, _
                                            txtQuantidadePendente, _
                                            txtQuantidade, _
                                            txtValorServicoUnitario, _
                                            txtValorServico, _
                                            txtValorDescontoCondicionado, _
                                            txtValorDescontoIncondicionado, _
                                            txtValorLiquidoNFSE, _
                                            txtDescricao, _
                                            cboCentroGasto, _
                                            cboContaContabil, _
                                            txtOutrasRetencoes, _
                                            txtValorDeducoes, _
                                            txtBaseCalculo, _
                                            txtAliquotaISS, _
                                            cboISSRetido, _
                                            txtAliquotaPIS, _
                                            txtAliquotaCOFINS, _
                                            txtAliquotaINSS, _
                                            txtAliquotaCSLL, _
                                            txtAliquotaIR, _
                                            txtValorISS, _
                                            txtValorISSRetido, _
                                            txtValorPIS, _
                                            txtValorCOFINS, _
                                            txtValorINSS, _
                                            txtValorCSLL, _
                                            txtValorIR)

            btnInserirServico.Tag = grdServico.CurrentRow.Cells("codigo").Value

            cboPedidoCompra.Enabled = False
            cboServico.Enabled = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnExcluirServico_Click(sender As Object, e As EventArgs) Handles btnExcluirServico.Click
        Try

            'Deleta Registros
            Call DeleteServicos()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdServico_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdServico.RowDoubleClick

        Try

            If grdServico.CurrentColumn.Key = "editar" Then Call EditarServico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: INTEGRAÇÃO :::"

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Financeiro
            oClsIntegracao.IntegracaoNFSEntradaFinanceiro(oClsFatEntradaNFs.CodigoNFSCapa)
            'Compras
            oClsIntegracao.IntegracaoNFSEntradaPedidoCompraFinanceiro(oClsFatEntradaNFs.CodigoNFSCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DADOS DA DESPESA :::"

#Region "::: CLASSIFICAÇÃO :::"

    Private Sub InserirClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoClassificacao() = True Then

                'Váriaveis - Update
                Dim iCodigoCentroGastoAntigo As Integer = -1
                Dim sCodigoContaContabilAntigo As String = ""

                'Carrega Váriaveis
                If IsNumeric(btnInserirClassificao.Tag) Then
                    iCodigoCentroGastoAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value), -1, grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value)
                    sCodigoContaContabilAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value), "", grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value)
                End If

                'Insere Registro na Grid
                Dim oClsFinDespesaLancamento As New clsUsrFinDespesaLancamento
                oClsFinDespesaLancamento.InsertClassificacaoGrid(grdClassificacao, _
                                                                 IIf(cboCentroGastoDespesa.SelectedIndex = -1, "", cboCentroGastoDespesa.Text), _
                                                                 IIf(cboContaContabilDespesa.SelectedIndex = -1, "", cboContaContabilDespesa.Text), _
                                                                 txtValorClassificacao.Value, _
                                                                 IIf(cboCentroGastoDespesa.SelectedIndex = -1, -1, cboCentroGastoDespesa.SelectedValue), _
                                                                 IIf(cboContaContabilDespesa.SelectedIndex = -1, "", cboContaContabilDespesa.SelectedValue), _
                                                                 IIf(IsNumeric(btnInserirClassificao.Tag), "U", "I"), _
                                                                 iCodigoCentroGastoAntigo, _
                                                                 sCodigoContaContabilAntigo)

                'Limpa Formulário
                Call NovoClassificacao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarClassificacao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = True Then

                'Carrega Controles
                cboCentroGastoDespesa.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value
                cboContaContabilDespesa.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value
                txtValorClassificacao.Value = grdClassificacao.CurrentRow.Cells("valor").Value
                btnInserirClassificao.Tag = grdClassificacao.CurrentRow.RowIndex

                'Seta Focu
                cboCentroGastoDespesa.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteClassificacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdClassificacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Dim i As Integer

                    For i = 0 To UBound(gSelecaoRow)
                        gSelecaoRow(i).Delete()
                    Next

                    'Limpa Formulário
                    Call NovoClassificacao()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCentroGastoDespesa.SelectedIndex = -1
            cboContaContabilDespesa.SelectedIndex = -1
            txtValorClassificacao.Value = 0
            btnInserirClassificao.Tag = ""

            'Seta Focu
            cboCentroGastoDespesa.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoClassificacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoClassificacao = False

            'Verifica se foi Selecionado o Campo - Centro de Gasto ou Conta Contábil
            If cboCentroGastoDespesa.SelectedIndex = -1 And cboContaContabilDespesa.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(lblCentroGastoDespesa, "Primeiramente Selecione um Centro de Gasto ou uma Conta Contábil.")
                cboCentroGastoDespesa.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorClassificacao, lblValorClassificacao, True) = False Then
                Exit Function
            End If

            'Valida se a Soma do Valor Classificação é maior que o Valor Total
            Dim dValor, dValorTotal As Double

            If IsNumeric(btnInserirClassificao.Tag) Then
                dValor = grdClassificacao.CurrentRow.Cells("valor").Value
            End If
            If grdClassificacao.GetDataRows.Count > 0 Then
                dValorTotal = grdClassificacao.GetTotalRow.Cells("valor").Value
            End If
            'If (txtValorLiquido.Value < FormatNumber((dValorTotal - dValor + txtValorClassificacao.Value), 2)) Then
            '    frmMain.errInfo.SetError(lblValorClassificacao, "A Soma dos Valores (Classificação) não pode ser maior que o Valor Total.")
            '    Exit Function
            'End If

            'Seta Retorno da Função
            ValidacaoClassificacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    Private Sub SalvarDadosDespesa()

        Try

            'Para não influenciar os outros clientes
            If goDatabase.sInitialCatalog <> "INTERACTI_NORSUL_PRD" Then Exit Sub

            'Exclui a classificação inicialmente
            Dim oClsUsrFinDespesaLancamento As New clsUsrFinDespesaLancamento
            oClsUsrFinDespesaLancamento.DeleteClassificacao(lCodigoTituloCapa)

            'Lança a classificaçao
            oClsUsrFinDespesaLancamento.CodigoDespesaCapa = lCodigoTituloCapa
            oClsUsrFinDespesaLancamento.InsertClassificacao(grdClassificacao)

            'Altera outros dados
            oClsFatEntradaNFs.UpdateDadosDespesa(lCodigoTituloCapa, _
                                                IIf(cboTipoDocumentoPagamento.SelectedIndex = -1, -1, cboTipoDocumentoPagamento.SelectedValue), _
                                                txtDescritivoDespesa.Text)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class