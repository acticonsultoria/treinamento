Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Drawing.Printing

Public Class usrFatEmissaoLocacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEmissaoLocacao As New clsUsrFatEmissaoLocacao
    Private lCodigoEmissaoCapa As Long

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

#Region "::: GERAL :::"

    Private Sub usrFatEmissaoLocacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEPCliente" : Call btnProcurarCEPCliente_Click(btnProcurarCEPCliente, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCliente" : Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                        Case "cboPaisCliente" : Call LoadCombo(cboPaisCliente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboCodigoProduto" : Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item_ativo_fixo " & goUsuario.iEmpresa)
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboPaisCliente" : Call btnCadastrarPaisCliente_Click(btnCadastrarPaisCliente, System.EventArgs.Empty)
                        Case "cboCodigoProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatEmissaoLocacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoLocacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoLocacao)

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
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboModelo.Focus()

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

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboModelo.Focus()

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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                Call ImprimirNotaFiscal(btnSalvar.Tag, _
                                        CInt(StatusNFLocacao.Elaboracao), _
                                        cboModelo.SelectedValue, _
                                        cboSerie.Text)

            End If

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

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Nota Fiscal
            Call ExcluirCapa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica a Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarNotaFiscal(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "duplicar" : Call DuplicarNotaFiscal()
                Case "cancelar" : Call CancelarNotaFiscal()
                Case "historico" : Call HistoricoNotaFiscal()
                Case "boleto_bancario" : Call ImprimirBoletoBancario()
                Case "imprimir" : Call ImprimirNotaFiscal(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                          grdListagem.CurrentRow.Cells("status").Value, _
                                                          "", _
                                                          grdListagem.CurrentRow.Cells("serie").Value)

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
                                     Formulario.FaturamentoEmissaoLocacao, _
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
                                     Formulario.FaturamentoEmissaoLocacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEmissaoLocacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DADOS GERAIS :::"

    Private Sub cboModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModelo.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboModelo.SelectedIndex = -1 Then
                'Limpa Controles
                cboSerie.DataSource = Nothing : cboSerie.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboSerie, "sp_select_combo_configuracao_serie_nota_fiscal " & goUsuario.iEmpresa & ", " & cboModelo.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CLIENTE :::"

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPaisCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisCliente.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo            
            LoadCombo(cboPaisCliente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

            'Seta Focu
            cboPaisCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCEPCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEPCliente.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCEPCliente.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPCliente.Text.Trim, "-", "")), _
                           cboPaisCliente, _
                           cboUFCliente, _
                           cboMunicipioCliente, _
                           txtBairroCliente, _
                           txtLogradouroCliente, _
                           txtComplementoCliente)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

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
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Destinatário
            If cboCliente.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                txtCNPJCliente.Enabled = False : txtCNPJCliente.Text = ""
                txtInscricaoEstadualCliente.Enabled = False : txtInscricaoEstadualCliente.Text = ""
                txtInscricaoMunicipalCliente.Enabled = False : txtInscricaoMunicipalCliente.Text = ""
                txtLogradouroCliente.Enabled = False : txtLogradouroCliente.Text = ""
                txtNumeroCliente.Enabled = False : txtNumeroCliente.Text = ""
                txtComplementoCliente.Enabled = False : txtComplementoCliente.Text = ""
                txtBairroCliente.Enabled = False : txtBairroCliente.Text = ""
                txtCEPCliente.Enabled = False : txtCEPCliente.Text = ""
                cboPaisCliente.Enabled = False : cboPaisCliente.SelectedIndex = -1
                cboUFCliente.Enabled = False : cboUFCliente.SelectedIndex = -1
                cboMunicipioCliente.Enabled = False : cboMunicipioCliente.SelectedIndex = -1
                txtTelefoneCliente.Enabled = False : txtTelefoneCliente.Text = ""
                txtEmailCliente.Enabled = False : txtEmailCliente.Text = ""
                txtCNPJCliente.Tag = ""
                cboPedidoVenda.DataSource = Nothing : cboPedidoVenda.Text = ""

            Else

                'Carrega dados do Destinatário
                Call LoadDadosParceiroNegocio(cboCliente.SelectedValue, _
                                              txtCNPJCliente, _
                                              txtInscricaoEstadualCliente, _
                                              txtInscricaoMunicipalCliente, _
                                              txtLogradouroCliente, _
                                              txtNumeroCliente, _
                                              txtComplementoCliente, _
                                              txtBairroCliente, _
                                              txtCEPCliente, _
                                              cboPaisCliente, _
                                              cboUFCliente, _
                                              cboMunicipioCliente, _
                                              txtTelefoneCliente, _
                                              txtEmailCliente)

                'Verifica o Tipo de Personalidade
                If txtCNPJCliente.Tag = Personalidade.Fisica Then
                    lblCNPJCliente.Text = "CPF:"
                    lblInscricaoEstadualCliente.Text = "RG:"
                Else
                    lblCNPJCliente.Text = "CNPJ:"
                    lblInscricaoEstadualCliente.Text = "IE:"
                End If

                'Carrega Combo - Pedido de Venda
                Call LoadCombo(cboPedidoVenda, "sp_select_combo_faturamento_locacao_pedido_venda " & goUsuario.iEmpresa & ", " & cboCliente.SelectedValue, False)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPaisCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaisCliente.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisCliente.SelectedIndex = -1 Then
                'Limpa Controles
                cboUFCliente.DataSource = Nothing
                cboUFCliente.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboUFCliente, "sp_select_combo_static_estado_pais " & cboPaisCliente.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFCliente.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFCliente.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioCliente.DataSource = Nothing
                cboMunicipioCliente.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioCliente, "sp_select_combo_static_municipio " & cboUFCliente.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnAgruparProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdProduto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdProduto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdProduto.GroupByBoxVisible = True
                grdProduto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoLocacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.FaturamentoEmissaoLocacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item_ativo_fixo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCodigoProduto.Focus()

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

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If ValidacaoProduto() = True Then

                'Váriaveis Locais
                Dim lCodigoPedidoAntigo As Long = -1
                Dim iCodigoPedidoItemAntigo As Integer = -1
                Dim iCodigoPedidoItemEntregaAntigo As Integer = -1
                Dim lCodigoItemAntigo As Long = -1
                Dim lCodigoItem As Long

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirProduto.Tag) Then
                    lCodigoPedidoAntigo = grdProduto.CurrentRow.Cells("codigo_pedido").Value
                    iCodigoPedidoItemAntigo = grdProduto.CurrentRow.Cells("codigo_pedido_item").Value
                    iCodigoPedidoItemEntregaAntigo = grdProduto.CurrentRow.Cells("codigo_pedido_item_entrega").Value
                    lCodigoItemAntigo = grdProduto.CurrentRow.Cells("codigo_item").Value
                End If

                If cboPedidoVenda.SelectedIndex = -1 Then
                    lCodigoItem = cboCodigoProduto.SelectedValue
                Else
                    lCodigoItem = CType(LoadDescricao("sp_select_venda_pedido_item_codigo_item " & goUsuario.iEmpresa & ", " & cboPedidoVenda.SelectedValue & ", " & cboCodigoProduto.SelectedValue.ToString.Split(";")(0)), Integer)
                End If

                'Insere Registro na Grid
                Call InsertProduto(grdProduto, _
                                   IIf(cboPedidoVenda.SelectedIndex = -1, "", cboPedidoVenda.Text), _
                                   cboCodigoProduto.Text, _
                                   txtDescricao.Text.Trim, _
                                   txtQuantidade.Value, _
                                   txtValorUnitario.Value, _
                                   txtValorTotal.Value, _
                                   IIf(cboCentroGasto.SelectedIndex = -1, "", cboCentroGasto.Text), _
                                   IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.Text), _
                                   IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                   IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                   IIf(cboPedidoVenda.SelectedIndex = -1, -1, cboPedidoVenda.SelectedValue), _
                                   IIf(cboPedidoVenda.SelectedIndex = -1, -1, cboCodigoProduto.SelectedValue.ToString.Split(";")(0)), _
                                   IIf(cboPedidoVenda.SelectedIndex = -1, -1, cboCodigoProduto.SelectedValue.ToString.Split(";")(1)), _
                                   IIf(cboPedidoVenda.SelectedIndex = -1, -1, cboCodigoProduto.SelectedValue.ToString.Split(";")(2)), _
                                   lCodigoItem,
                                   lCodigoItemAntigo, _
                                   lCodigoPedidoAntigo, _
                                   iCodigoPedidoItemAntigo, _
                                   iCodigoPedidoItemEntregaAntigo)

                'Prepara Formulário para Inserir novo Produto
                Call NovoProduto()

                'Seta Valor Original
                If grdProduto.GetDataRows.Count > 0 Then
                    txtValorOriginal.Value = grdProduto.GetTotalRow.Cells("valor_total").Value
                Else
                    txtValorTotal.Value = 0
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Produto
            Call ExcluirProduto()

            'Preapara Formulário para Inserção de um Novo Produto
            Call NovoProduto()

            'Seta Valor Original
            If grdProduto.GetDataRows.Count > 0 Then
                txtValorOriginal.Value = grdProduto.GetTotalRow.Cells("valor_total").Value
            Else
                txtValorTotal.Value = 0
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPedidoVenda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPedidoVenda.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Produto
            If cboPedidoVenda.SelectedIndex = -1 Then

                'Carrega Combo - Produto
                Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item_ativo_fixo " & goUsuario.iEmpresa, False)

            Else

                'Carrega Combo - Produto
                Call LoadCombo(cboCodigoProduto, "sp_select_combo_faturamento_locacao_pedido_venda_produto " & goUsuario.iEmpresa & ", " & cboPedidoVenda.SelectedValue, False)

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Habilita Controles
            txtValorUnitario.Enabled = True
            txtQuantidade.Enabled = True

            'Verifica se foi Selecionado Algum Produto
            If cboCodigoProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricao.Text = ""
                txtValorUnitario.Value = 0
                txtQuantidade.Value = 0

            Else

                If cboPedidoVenda.SelectedIndex = -1 Then

                    'Carrega Dados do Produto
                    Dim oClsUsrCadProduto As New clsUsrCadProduto
                    Call oClsUsrCadProduto.LoadDadosProduto(cboCodigoProduto.SelectedValue.ToString.Split(";")(0), _
                                                            txtDescricao, _
                                                            txtValorUnitario)

                Else

                    txtDescricao.Text = cboCodigoProduto.SelectedValue.ToString.Split(";")(4)
                    txtValorUnitario.Value = cboCodigoProduto.SelectedValue.ToString.Split(";")(3) : txtValorUnitario.Enabled = False
                    txtQuantidade.Value = cboCodigoProduto.SelectedValue.ToString.Split(";")(2) : txtQuantidade.Enabled = False

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub CalculaValorTotal() Handles txtQuantidade.ValueChanged, _
                                            txtValorUnitario.ValueChanged

        Try

            'Seta Valor Total
            txtValorTotal.Value = txtQuantidade.Value * txtValorUnitario.Value

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.FaturamentoEmissaoLocacao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.FaturamentoEmissaoLocacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.FaturamentoEmissaoLocacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Public Sub btnCalcularDuplicata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDuplicata.Click

        Try

            'Gera Parcela
            Call oClsFatEmissaoLocacao.GerarDuplicata(grdDuplicata, _
                                                  txtValorLiquido.Value, _
                                                  txtNumeroParcela.Value, _
                                                  txtIntervaloEntreParcelas.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFormaPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCondicaoPagamento.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado alguma Forma de Pagamento
            If cboCondicaoPagamento.SelectedIndex = -1 Then
                'Limpa Controles
                grdDuplicata.DataSource = Nothing
                txtNumeroParcela.Enabled = False
                txtIntervaloEntreParcelas.Enabled = False
            ElseIf cboCondicaoPagamento.SelectedValue = FormaPagamentoNFe.PagamentoAVista Then
                'Desabilita Controles
                txtNumeroParcela.Value = 1 : txtNumeroParcela.Enabled = False
                txtIntervaloEntreParcelas.Value = 0 : txtIntervaloEntreParcelas.Enabled = False
            ElseIf cboCondicaoPagamento.SelectedValue = FormaPagamentoNFe.PagamentoAPrazo Then
                'Habilita Controles
                txtNumeroParcela.Enabled = True
                txtIntervaloEntreParcelas.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaCobranca_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorOriginal.ValueChanged, _
 _
                                                                                                          txtValorRetido.ValueChanged

        Try

            'Calcula Valor Líquido
            txtValorLiquido.Value = txtValorOriginal.Value - txtValorRetido.Value - txtValorDesconto.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: IMPOSTO :::"

    Private Sub CalculaValorRetido() Handles txtValorOriginal.ValueChanged, _
                                             txtValorDesconto.ValueChanged, _
                                             chkLei10833.CheckStateChanged, _
                                             txtLei10833.ValueChanged, _
                                             chkINSS.CheckStateChanged, _
                                             txtINSS.ValueChanged, _
                                             chkISS.CheckStateChanged, _
                                             txtISS.ValueChanged, _
                                             chkIR.CheckStateChanged, _
                                             txtIR.ValueChanged

        Try

            'Váriaveis Locais
            Dim dBaseCalculo As Double

            dBaseCalculo = txtValorOriginal.Value - txtValorDesconto.Value

            txtValorRetido.Value = IIf(chkLei10833.Checked = True, dBaseCalculo * txtLei10833.Value / 100, 0)
            txtValorRetido.Value += IIf(chkINSS.Checked = True, dBaseCalculo * txtINSS.Value / 100, 0)
            txtValorRetido.Value += IIf(chkISS.Checked = True, dBaseCalculo * txtISS.Value / 100, 0)
            txtValorRetido.Value += IIf(chkIR.Checked = True, dBaseCalculo * txtIR.Value / 100, 0)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: INFORMAÇÕES ADICIONAIS :::"

    Private Sub btnCadastrarDadosAdicionais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDadosAdicionais.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAutotexto")

            'Carrega Combo            
            LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais), False)

            'Seta Focu
            cboDadosAdicionaisPreCadastrado.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboDadosAdicionaisPreCadastrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosAdicionaisPreCadastrado.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Dado Adicional 
            If cboDadosAdicionaisPreCadastrado.SelectedIndex > -1 Then
                'Preenche Controle
                LoadDescricao(txtDadosAdicionais, "sp_select_faturamento_emissao_dados_adicionais " & cboDadosAdicionaisPreCadastrado.SelectedValue & ", " & IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1) & ", " & goUsuario.iEmpresa)
            End If

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
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoLocacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.FaturamentoEmissaoLocacao)

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

            'Verifica se foi Selecionado o Campo - Modelo
            If ValidaCampo(cboModelo, lblModelo) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Série
            If ValidaCampo(cboSerie, lblSerie) = False Then
                Exit Sub
            End If

            'Salva Registro
            Call SalvarCapa()

            'Valida Dados do Formulário
            If ValidacaoArquivo() = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_fat_emissao_locacao_capa", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_fat_emissao_locacao_capa", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_fat_emissao_locacao_capa", btnSalvar.Tag)

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

    Private Sub cboTipoArquivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

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
                Case "visualizar" : Call VisualizarDocumentoBD(grdArquivo.CurrentRow.Cells("arquivo").Value, grdArquivo.CurrentRow.Cells("extensao").Value)

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
                                     Formulario.FaturamentoEmissaoLocacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.FaturamentoEmissaoLocacao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.FaturamentoEmissaoLocacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEmissaoLocacao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcPrint)
            btnExcelGridProduto.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcPrint)
            'Verifica Direito - Cadastro
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarPaisCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarDadosAdicionais.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Carrega Combo - Filtro
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nota_fiscal_locacao")
            'Dados Gerais
            Call LoadCombo(cboModelo, "sp_select_combo_static_modelo_nota_fiscal " & CInt(TipoItem.ativo))
            'Carrega Combo - Cliente
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboPaisCliente, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
            'Carrega Combo - Produto
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            'Carrega Combo - Cobrança
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_static_forma_pagamento_nfe", False)
            'Carrega Combo - Dados Adicionais
            Call LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais), False)
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)

            'Seta Controles
            dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Checked = False

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoMunicipalEmitente.Text = goEmitente.sInscricaoMunicipal
            lblValorRegimeTributarioEmitente.Text = goEmitente.sRegimeTributario
            lblValorRazaoSocialEmitente.Text = goEmitente.sRazaoSocial
            lblValorNomeFantasiaEmitente.Text = goEmitente.sNomeFantasia
            lblValorLogradouroEmitente.Text = goEmitente.sLogradouro
            lblValorNumeroEmitente.Text = goEmitente.sNumero
            lblValorComplementoEmitente.Text = goEmitente.sComplemento
            lblValorBairroEmitente.Text = goEmitente.sBairro
            lblValorMunicipioEmitente.Text = goEmitente.sMunicipio
            lblValorUFEmitente.Text = goEmitente.sUF
            lblValorCEPEmiente.Text = goEmitente.sCEP
            lblValorPaisEmitente.Text = goEmitente.sPais

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoLocacao)
            Call ConfiguraGrid(grdProduto, Formulario.FaturamentoEmissaoLocacao)
            Call ConfiguraGrid(grdArquivo, Formulario.FaturamentoEmissaoLocacao)

            'Oculta Aba
            tabMain.TabPages.Remove(pagDados)

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
            Dim sStatus As String = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsFatEmissaoLocacao.LoadGrid(grdListagem, _
                                                IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                                IIf(IsNumeric(txtSerieFiltro.Text.Trim), txtSerieFiltro.Text.Trim, -1), _
                                                txtClienteFiltro.Text.Trim, _
                                                IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
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

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Limpa Controles - Dados da NFs
            cboModelo.SelectedIndex = -1
            cboSerie.SelectedIndex = -1
            txtNotaFiscal.Text = ""
            txtDataEmissao.Text = ""
            btnSalvar.Tag = ""

            'Limpa Controles - Cliente
            cboCliente.SelectedIndex = -1

            'Limpa Controles - Serviço
            cboPedidoVenda.SelectedIndex = -1
            cboCodigoProduto.SelectedIndex = -1
            txtDescricao.Text = ""
            txtQuantidade.Value = 0
            txtValorUnitario.Value = 0
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

            'Limpa Controles - Cobrança
            txtFatura.Text = ""
            txtValorOriginal.Value = 0
            txtValorRetido.Value = 0
            txtValorDesconto.Value = 0
            txtValorLiquido.Value = 0
            cboCondicaoPagamento.SelectedIndex = -1
            txtNumeroParcela.Value = 0
            txtIntervaloEntreParcelas.Value = 0
            grdDuplicata.DataSource = Nothing

            'Limpa Controles - Imposto
            chkLei10833.Checked = False
            chkINSS.Checked = False
            chkISS.Checked = False
            chkIR.Checked = False
            txtLei10833.Value = 0
            txtINSS.Value = 0
            txtISS.Value = 0
            txtIR.Value = 0

            'Limpa Controles - Dados Adicionais
            cboDadosAdicionaisPreCadastrado.SelectedIndex = -1
            txtDadosAdicionais.Text = ""

            'Seta Focu - Aba
            tabDados.SelectedTab = pagDadosNotaFiscal

            'Verifica Status
            Call VerificaStatus(StatusNFLocacao.Elaboracao)

            'Seta Focu
            cboModelo.Focus()

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
            'Insere Dados do Emitente
            Call SalvarEmitente()
            'Insere Dados do Cliente
            Call SalvarCliente()
            'Insere Dados do Produto
            Call SalvarProduto()
            'Insere Dados da Fatura
            Call SalvarFatura()

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
            oClsFatEmissaoLocacao.CodigoEmissaoNFLocacao = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsFatEmissaoLocacao.ModeloNotaFiscal = cboModelo.SelectedValue
            oClsFatEmissaoLocacao.Serie = cboSerie.SelectedValue
            oClsFatEmissaoLocacao.DadosAdicionais = txtDadosAdicionais.Text.Trim
            oClsFatEmissaoLocacao.Lei10833 = chkLei10833.Checked
            oClsFatEmissaoLocacao.AliquotaLei10833 = txtLei10833.Value
            oClsFatEmissaoLocacao.INSS = chkINSS.Checked
            oClsFatEmissaoLocacao.AliquotaINSS = txtINSS.Value
            oClsFatEmissaoLocacao.ISS = chkISS.Checked
            oClsFatEmissaoLocacao.AliquotaISS = txtISS.Value
            oClsFatEmissaoLocacao.IR = chkIR.Checked
            oClsFatEmissaoLocacao.AliquotaIR = txtIR.Value

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = True Then
                oClsFatEmissaoLocacao.UpdateCapa()
            Else
                oClsFatEmissaoLocacao.InsertCapa()
            End If

            'Seta Controle
            btnSalvar.Tag = oClsFatEmissaoLocacao.CodigoEmissaoNFLocacao

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirCapa()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusNFLocacao.Elaboracao)) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoLocacao.DeleteCapa()

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
            If VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcAdministrator) = True Then

                'Verifica se foi selecinado algum registro
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusNFLocacao.Impressa) Then

                    'Váriavel - Formulário
                    Dim oForm As New frmFatEmissaoLocacaoCancelar

                    'Seta Parâmetro
                    oForm.Grid = grdListagem

                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcSelect) = True Then

                'Váriavel - Formulário
                Dim oForm As New frmFatEmissaoLocacaoHistorico
                oForm.Grid = grdListagem

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoVisualizar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarNotaFiscal(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcUpdate) = True Then

                'Oculta Aba
                tabDados.Visible = False

                'Limpa Dados do Formulário
                Call Novo()

                'Carrega Dados da Nota Fiscal
                Call oClsFatEmissaoLocacao.LoadDadosNotaFiscal(lCodigoEmissaoCapa, _
                                                               cboModelo, _
                                                               cboSerie, _
                                                               txtNotaFiscal, _
                                                               txtDataEmissao, _
                                                               cboCliente, _
                                                               txtCNPJCliente, _
                                                               txtInscricaoEstadualCliente, _
                                                               txtInscricaoMunicipalCliente, _
                                                               txtCEPCliente, _
                                                               cboPaisCliente, _
                                                               cboUFCliente, _
                                                               cboMunicipioCliente, _
                                                               txtLogradouroCliente, _
                                                               txtNumeroCliente, _
                                                               txtBairroCliente, _
                                                               txtComplementoCliente, _
                                                               txtTelefoneCliente, _
                                                               txtEmailCliente, _
                                                               chkLei10833, _
                                                               txtLei10833, _
                                                               chkINSS, _
                                                               txtINSS, _
                                                               chkISS, _
                                                               txtISS, _
                                                               chkIR, _
                                                               txtIR, _
                                                               txtDadosAdicionais, _
                                                               txtFatura, _
                                                               txtValorOriginal, _
                                                               txtValorRetido, _
                                                               txtValorDesconto, _
                                                               txtValorLiquido, _
                                                               cboCondicaoPagamento, _
                                                               txtNumeroParcela, _
                                                               txtIntervaloEntreParcelas)

                'Carrega Grid de Produto
                Call oClsFatEmissaoLocacao.LoadGridProduto(grdProduto, _
                                                          lCodigoEmissaoCapa)

                'Carrega Grid de Parcela
                Call oClsFatEmissaoLocacao.LoadGridFatura(grdDuplicata, _
                                                          lCodigoEmissaoCapa)


                'Carrega Grid de Arquivo
                Call LoadGridArquivoBD(grdArquivo, "tb_fat_emissao_locacao_capa", btnSalvar.Tag)

                'Verifica Status
                Call VerificaStatus(grdListagem.CurrentRow.Cells("status").Value)

                'Seta Controle
                btnSalvar.Tag = lCodigoEmissaoCapa

                'Seta Aba
                tabDados.SelectedTab = pagDadosNotaFiscal
                tabDados.Visible = True

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboModelo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DuplicarNotaFiscal()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcInsert) = True Then

                'Verifica se o usuário deseja copiar a Nota Fiscal
                If MsgBox("Deseja Duplicar o Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Váriavel Local
                    Dim lCodigoEmissaoLocacao As Long

                    'Duplica Nota Fiscal
                    Call oClsFatEmissaoLocacao.DuplicarNF(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                          lCodigoEmissaoLocacao)

                    'Carrega Nota Fiscal
                    Call EditarNotaFiscal(lCodigoEmissaoLocacao)

                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Modelo
            If ValidaCampo(cboModelo, lblModelo) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Série
            If ValidaCampo(cboSerie, lblSerie) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal
                Exit Function
            End If

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoMunicipalEmitente.Text = goEmitente.sInscricaoMunicipal
            lblValorRegimeTributarioEmitente.Text = goEmitente.sRegimeTributario
            lblValorRazaoSocialEmitente.Text = goEmitente.sRazaoSocial
            lblValorNomeFantasiaEmitente.Text = goEmitente.sNomeFantasia
            lblValorLogradouroEmitente.Text = goEmitente.sLogradouro
            lblValorNumeroEmitente.Text = goEmitente.sNumero
            lblValorComplementoEmitente.Text = goEmitente.sComplemento
            lblValorBairroEmitente.Text = goEmitente.sBairro
            lblValorMunicipioEmitente.Text = goEmitente.sMunicipio
            lblValorUFEmitente.Text = goEmitente.sUF
            lblValorCEPEmiente.Text = goEmitente.sCEP
            lblValorPaisEmitente.Text = goEmitente.sPais

            'Verifica se foi Preenchido o Campo - Inscrição Municipal
            If goEmitente.sInscricaoMunicipal = "" Then
                frmMain.errInfo.SetError(lblInscricaoMunicipalEmitente, "O Emitente não possui Inscrição Estadual. Favor corrigir no Cadastro de Empresa.")
                tabDados.SelectedTab = pagDadosNotaFiscal
                Exit Function
            End If

            'Valida Dados do Cliente
            If ValidacaoCliente() = False Then
                Exit Function
            End If

            'Valida se Foi Inserido algum Produto
            If grdProduto.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir)
                tabDados.SelectedTab = pagProduto : cboPedidoVenda.Focus()
                Exit Function
            End If

            'Valida Dados da Fatura
            If ValidacaoFatura() = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadDadosNotaFiscal()

        Try

            'Carrega Grid de Fatura
            oClsFatEmissaoLocacao.LoadGridFatura(grdDuplicata, oClsFatEmissaoLocacao.CodigoEmissaoNFLocacao)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VerificaStatus(ByVal iStatus As Integer)

        Try

            'Desabilita Controles
            btnSalvar.Enabled = False
            btnImprimir.Enabled = False
            btnInserirProduto.Enabled = False
            btnExcluirProduto.Enabled = False

            'Verifica qual status foi selecionado
            Select Case iStatus

                Case StatusNFLocacao.Elaboracao
                    btnImprimir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcPrint)
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcInsert)
                    btnInserirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcInsert)
                    btnExcluirProduto.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcDelete)

                Case StatusNFLocacao.Impressa

                Case StatusNFLocacao.Cancelada

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ImprimirNotaFiscal(ByVal lCodigo As Long, _
                                   ByVal iStatus As Integer, _
                                   ByVal sModelo As String, _
                                   ByVal iSerie As Integer)

        Try

            'Verifica o Status
            If iStatus = CInt(StatusNFLocacao.Elaboracao) Then

                'Altera Status
                Call oClsFatEmissaoLocacao.UpdateStatusNotaFiscal(lCodigo, _
                                                                  StatusNFLocacao.Impressa,
                                                                  Now.Date, _
                                                                  LoadDescricao("sp_select_faturamento_emissao_locacao_numero_documento " & goUsuario.iEmpresa & ",'" & sModelo & "'," & iSerie))

                'Carrega a Grid
                Call LoadGrid()

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo"
            goCrystalReport.sReportParameter(0).sValue = lCodigo
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000011.rpt"

            Dim oReport As New usrReport
            oReport.Print = IIf(iStatus = CInt(StatusNFLocacao.Elaboracao), True, False)
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("FAT000000011", "Nota Fiscal de Locação", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirBoletoBancario()

        Try

            'Variável - Formulário de Boleto Bancário
            Dim oForm As New frmFinReceitaBoletoBancarioDLL
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parametros
            oForm.Cliente = grdListagem.CurrentRow.Cells("cliente").Value
            oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("nota_fiscal").Value
            oForm.CodigoTituloCapa = LoadDescricao("sp_select_faturamento_emissao_locacao_boleto_bancario " & grdListagem.CurrentRow.Cells("codigo").Value & ", " & goUsuario.iEmpresa)

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CLIENTE :::"

    Private Sub SalvarCliente()

        Try

            'Seta Parametros
            oClsFatEmissaoLocacao.CodigoCliente = cboCliente.SelectedValue
            oClsFatEmissaoLocacao.CnpjCpfCliente = txtCNPJCliente.Text.Trim
            oClsFatEmissaoLocacao.InscricaoEstadualCliente = txtInscricaoEstadualCliente.Text.Trim
            oClsFatEmissaoLocacao.InscricaoMunicipalCliente = txtInscricaoMunicipalCliente.Text.Trim
            oClsFatEmissaoLocacao.CepCliente = txtCEPCliente.Text.Trim
            oClsFatEmissaoLocacao.CodigoPaisCliente = cboPaisCliente.SelectedValue
            oClsFatEmissaoLocacao.UFCliente = cboUFCliente.SelectedValue
            oClsFatEmissaoLocacao.CodigoMunicipioCliente = cboMunicipioCliente.SelectedValue
            oClsFatEmissaoLocacao.LogradouroCliente = txtLogradouroCliente.Text.Trim
            oClsFatEmissaoLocacao.NumeroCliente = txtNumeroCliente.Text.Trim
            oClsFatEmissaoLocacao.BairroCliente = txtBairroCliente.Text.Trim
            oClsFatEmissaoLocacao.ComplementoCliente = txtComplementoCliente.Text.Trim
            oClsFatEmissaoLocacao.TelefoneCliente = txtTelefoneCliente.Text.Trim
            oClsFatEmissaoLocacao.EmailCliente = txtEmailCliente.Text.Trim

            'Salva Dados do Cliente
            oClsFatEmissaoLocacao.DeleteCliente()
            oClsFatEmissaoLocacao.InsertCliente()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCliente() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCliente = False

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : cboCliente.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPaisCliente, lblPaisCliente) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : cboPaisCliente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CNPJ /  CPF
            If ValidaCampo(txtCNPJCliente, lblCNPJCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : txtCNPJCliente.Focus()
                Exit Function
            ElseIf txtCNPJCliente.Tag = CInt(Personalidade.Juridica) And cboPaisCliente.SelectedValue = CInt(Pais.Brasil) Then
                If ValidaCNPJ(txtCNPJCliente.Text) = False Then
                    frmMain.errInfo.SetError(lblCNPJCliente, "Este CNPJ: " & txtCNPJCliente.Text.Trim & " não é válido.")
                    tabDados.SelectedTab = pagDadosNotaFiscal : txtCNPJCliente.Focus()
                    Exit Function
                End If
            ElseIf txtCNPJCliente.Tag = CInt(Personalidade.Fisica) And cboPaisCliente.SelectedValue = CInt(Pais.Brasil) Then
                If ValidaCPF(txtCNPJCliente.Text) = False Then
                    frmMain.errInfo.SetError(lblCNPJCliente, "Este CPF: " & txtCNPJCliente.Text.Trim & " não é válido.")
                    tabDados.SelectedTab = pagDadosNotaFiscal : txtCNPJCliente.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - CEP
            If ValidaCampo(txtCEPCliente, lblCEPCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : txtCEPCliente.Focus()
                Exit Function
            ElseIf txtCEPCliente.Text.Length <> 9 Then
                frmMain.errInfo.SetError(lblCEPCliente, "Este CEP: " & txtCEPCliente.Text.Trim & " está incompleto.")
                tabDados.SelectedTab = pagDadosNotaFiscal : txtCEPCliente.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFCliente, lblUFCliente) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : cboUFCliente.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If ValidaCampo(cboMunicipioCliente, lblMunicipioCliente) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : cboMunicipioCliente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouroCliente, lblLogradouroCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : txtLogradouroCliente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumeroCliente, lblNumeroCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : txtNumeroCliente.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bairro
            If ValidaCampo(txtBairroCliente, lblBairroCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNotaFiscal : txtBairroCliente.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCliente = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: EMITENTE :::"

    Private Sub SalvarEmitente()

        Try

            'Salva Dados do Emitente
            oClsFatEmissaoLocacao.DeleteEmitente()
            oClsFatEmissaoLocacao.InsertEmitente()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub SalvarFatura()

        Try

            'Deleta Dados da Fatura
            oClsFatEmissaoLocacao.DeleteFatura()

            'Seta Parametros
            oClsFatEmissaoLocacao.Fatura = txtFatura.Text.Trim
            oClsFatEmissaoLocacao.ValorOriginal = txtValorOriginal.Value
            oClsFatEmissaoLocacao.ValorRetido = txtValorRetido.Value
            oClsFatEmissaoLocacao.ValorDesconto = txtValorDesconto.Value
            oClsFatEmissaoLocacao.ValorLiquido = txtValorLiquido.Value
            oClsFatEmissaoLocacao.NumeroParcela = txtNumeroParcela.Value
            oClsFatEmissaoLocacao.IntervaloParcela = txtIntervaloEntreParcelas.Value

            'Salva Dados Fatura
            oClsFatEmissaoLocacao.InsertFatura()
            oClsFatEmissaoLocacao.InsertFaturaDuplicata(grdDuplicata)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoFatura() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFatura = False

            'Verifica se foi Selecionado o Campo - Forma de Pagamento
            If ValidaCampo(cboCondicaoPagamento, lblCodigoCondicaoPagamento) = False Then
                tabDados.SelectedTab = pagCobranca : cboCondicaoPagamento.Focus()
                Exit Function
            End If

            'Verifica se foi Informado os dados da Fatura
            If grdDuplicata.GetDataRows.Count = 0 And txtValorLiquido.Value > 0 Then
                frmMain.errInfo.SetError(lblValorLiquido, "A Soma dos Valores da Duplicata é diferente do Valor Líquido.")
                tabDados.SelectedTab = pagCobranca : btnCalcularDuplicata.Focus()
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

#Region "::: PRODUTO :::"

    Private Sub InsertProduto(ByVal oGrid As GridEX, _
                              ByVal sNumeroPedido As String, _
                              ByVal sCodigoProduto As String, _
                              ByVal sDescricao As String, _
                              ByVal dQuantidade As Double, _
                              ByVal dValorUnitario As Double, _
                              ByVal dValorTotal As Double, _
                              ByVal sCentroGasto As String, _
                              ByVal sContaContabil As String, _
                              ByVal iCodigoCentroGasto As Integer, _
                              ByVal sCodigoContaContabil As String, _
                              ByVal lCodigoPedido As Long, _
                              ByVal iCodigoPedidoItem As Integer, _
                              ByVal iCodigoPedidoItemEntrega As Integer, _
                              ByVal sQuantidadePedido As String, _
                              ByVal lCodigoItem As Long, _
                              ByVal lCodigoItemAntigo As Long, _
                              ByVal lCodigoPedidoAntigo As Long, _
                              ByVal iCodigoPedidoItemAntigo As Integer, _
                              ByVal iCodigoPedidoItemEntregaAntigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCNumeroPedido As New DataColumn("numero_pedido")
            Dim oDCCodigoProduto As New DataColumn("codigo_produto")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCValorUnitario As New DataColumn("valor_unitario")
            Dim oDCValorTotal As New DataColumn("valor_total")
            Dim oDCCentroGasto As New DataColumn("centro_custo")
            Dim oDCContaContabil As New DataColumn("conta_contabil")
            Dim oDCCodigoCentroGasto As New DataColumn("codigo_centro_custo")
            Dim oDCCodigoContaContabil As New DataColumn("codigo_conta_contabil")
            Dim oDCCodigoItem As New DataColumn("codigo_item")
            Dim oDCCodigoPedido As New DataColumn("codigo_pedido")
            Dim oDCCodigoPedidoItem As New DataColumn("codigo_pedido_item")
            Dim oDCCodigoPedidoItemEntrega As New DataColumn("codigo_pedido_item_entrega")
            Dim oDCQuantidadePedido As New DataColumn("quantidade_pedido")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCNumeroPedido)
                oDataTable.Columns.Add(oDCCodigoProduto)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCValorUnitario)
                oDataTable.Columns.Add(oDCValorTotal)
                oDataTable.Columns.Add(oDCCentroGasto)
                oDataTable.Columns.Add(oDCContaContabil)
                oDataTable.Columns.Add(oDCCodigoCentroGasto)
                oDataTable.Columns.Add(oDCCodigoContaContabil)
                oDataTable.Columns.Add(oDCCodigoItem)
                oDataTable.Columns.Add(oDCCodigoPedido)
                oDataTable.Columns.Add(oDCCodigoPedidoItem)
                oDataTable.Columns.Add(oDCCodigoPedidoItemEntrega)
                oDataTable.Columns.Add(oDCQuantidadePedido)
                'Seta Tipo
                oDCQuantidade.DataType = 0.0.GetType
                oDCValorUnitario.DataType = 0.0.GetType
                oDCValorTotal.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirProduto.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("numero_pedido") = sNumeroPedido
                oDataRow("codigo_produto") = sCodigoProduto
                oDataRow("descricao") = sDescricao
                oDataRow("quantidade") = dQuantidade
                oDataRow("valor_unitario") = dValorUnitario
                oDataRow("valor_total") = dValorTotal
                oDataRow("centro_custo") = sCentroGasto
                oDataRow("conta_contabil") = sContaContabil
                oDataRow("codigo_centro_custo") = iCodigoCentroGasto
                oDataRow("codigo_conta_contabil") = sCodigoContaContabil
                oDataRow("codigo_item") = lCodigoItem
                oDataRow("codigo_pedido") = lCodigoPedido
                oDataRow("codigo_pedido_item") = iCodigoPedidoItem
                oDataRow("codigo_pedido_item_entrega") = iCodigoPedidoItemEntrega
                oDataRow("quantidade_pedido") = sQuantidadePedido
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("((codigo_item = " & lCodigoItemAntigo & ") AND (codigo_pedido = " & lCodigoPedidoAntigo & ") AND (codigo_pedido_item = " & iCodigoPedidoItemAntigo & ") AND (codigo_pedido_item_entrega = " & iCodigoPedidoItemEntrega & "))")(0)
                oDataRow("numero_pedido") = sNumeroPedido
                oDataRow("codigo_produto") = sCodigoProduto
                oDataRow("descricao") = sDescricao
                oDataRow("quantidade") = dQuantidade
                oDataRow("valor_unitario") = dValorUnitario
                oDataRow("valor_total") = dValorTotal
                oDataRow("centro_custo") = sCentroGasto
                oDataRow("conta_contabil") = sContaContabil
                oDataRow("codigo_centro_custo") = iCodigoCentroGasto
                oDataRow("codigo_conta_contabil") = sCodigoContaContabil
                oDataRow("codigo_item") = lCodigoItem
                oDataRow("codigo_pedido") = lCodigoPedido
                oDataRow("codigo_pedido_item") = iCodigoPedidoItem
                oDataRow("codigo_pedido_item_entrega") = iCodigoPedidoItemEntrega
                oDataRow("quantidade_pedido") = sQuantidadePedido
            End If

            'Configura Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName
            oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Carrega Controles
            With grdProduto.CurrentRow

                If .Cells("codigo_pedido").Value <> -1 Then
                    cboPedidoVenda.SelectedValue = .Cells("codigo_pedido").Value
                    Call cboPedidoVenda_SelectedIndexChanged(cboPedidoVenda, System.EventArgs.Empty)
                    cboCodigoProduto.SelectedValue = .Cells("codigo_pedido_item").Value & ";" & .Cells("codigo_pedido_item_entrega").Value & ";" & .Cells("quantidade_pedido").Value
                Else
                    cboCodigoProduto.SelectedValue = .Cells("codigo_item").Value
                End If
                txtDescricao.Text = .Cells("descricao").Value
                txtQuantidade.Value = .Cells("quantidade").Value
                txtValorUnitario.Value = .Cells("valor_unitario").Value
                cboCentroGasto.Text = .Cells("centro_custo").Value
                cboContaContabil.Text = .Cells("conta_contabil").Value
                btnInserirProduto.Tag = .RowIndex

            End With

            'Seta Focu
            cboPedidoVenda.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoProduto()

        Try

            'Limpa Controles
            cboPedidoVenda.SelectedIndex = -1
            cboCodigoProduto.SelectedIndex = -1
            txtDescricao.Text = ""
            txtQuantidade.Value = 0
            txtValorUnitario.Value = 0
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            btnInserirProduto.Tag = ""

            'Seta Focu
            cboPedidoVenda.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirProduto()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & "Registros com STATUS de AGUARDANDO TRANSMISSÃO.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarProduto()

        Try

            'Salva Dados do Serviço
            oClsFatEmissaoLocacao.DeleteProduto()
            oClsFatEmissaoLocacao.InsertProduto(grdProduto)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Selecionado o Campo - Código do Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                tabDados.SelectedTab = pagProduto : cboCodigoProduto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrilçai
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagProduto : txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                tabDados.SelectedTab = pagProduto : txtQuantidade.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Pedido de Venda
            If cboPedidoVenda.SelectedIndex > -1 Then
                If txtQuantidade.Value > CType(cboCodigoProduto.SelectedValue.ToString.Split(";")(2), Double) Then
                    frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada é maior do que a Quantidade Pendente do Pedido de Venda.")
                    txtQuantidade.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If ValidaCampo(txtValorUnitario, lblValorUnitario, True) = False Then
                tabDados.SelectedTab = pagProduto : txtValorUnitario.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region " ::: INTEGRAÇÃO ::: "

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Financeiro
            oClsIntegracao.IntegracaoNFSEmissaoFinanceiro(btnSalvar.Tag)
            'Pedido de Venda - Financeiro
            oClsIntegracao.IntegracaoNFSEmissaoPedidoVendaFinanceiro(btnSalvar.Tag)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

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
                        'Exclui Registro do Banco de Dados
                        modFunction.DeleteArquivoBD("tb_fat_emissao_locacao_capa", oRow.Cells("path").Value, btnSalvar.Tag)
                        'Exclui Registro da Grid
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
            If VerificaDireito(Formulario.FaturamentoEmissaoLocacao, gcUpdate) = True Then

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

#End Region

End Class
