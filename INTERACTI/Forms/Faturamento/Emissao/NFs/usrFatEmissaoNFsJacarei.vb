Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Drawing.Printing

Public Class usrFatEmissaoNFsJacarei

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEmissaoNFs As New clsUsrFatEmissaoNFsJacarei
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

    Private Sub usrFatEmissaoNFs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEPTomador" : Call btnProcurarCEPTomador_Click(btnProcurarCEPTomador, System.EventArgs.Empty)
                        Case "cboTomador" : Call btnProcurarTomador_Click(btnProcurarTomador, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboTomador" : Call LoadCombo(cboTomador, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                        Case "cboPaisTomador" : Call LoadCombo(cboPaisTomador, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboServico" : Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboTomador" : Call btnCadastrarTomador_Click(btnCadastrarTomador, System.EventArgs.Empty)
                        Case "cboPaisTomador" : Call btnCadastrarPaisTomador_Click(btnCadastrarPaisTomador, System.EventArgs.Empty)
                        Case "cboServico" : Call btnCadastrarServico_Click(btnCadastrarServico, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatEmissaoNFs_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFs
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFs)

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

    Private Sub btnImportarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedido.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Váriavel - Formulário
            Dim oForm As New frmFatEmissaoNFsPedidoVenda
            oForm.usrEmissaoNFs = Me

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Controle
            If cboServico.Tag <> "" Then
                cboServico.Enabled = False
                txtValorServico.Enabled = False
            Else
                cboServico.Enabled = True
                txtValorServico.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdListagem.DoubleClick

        Try

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarNotaFiscal(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "duplicar" : Call DuplicarNotaFiscal()
                Case "cancelar" : Call CancelarNotaFiscal()
                Case "boleto_bancario" : Call ImprimirBoletoBancario()
                Case "imprimir"
                    If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusNFSe.AutorizadoUso) Then
                        Call ImprimirNFSe(grdListagem.CurrentRow.Cells("codigo_tipo_ambiente").Value, _
                                          grdListagem.CurrentRow.Cells("codigo_verificacao").Value, _
                                          grdListagem.CurrentRow.Cells("nota_fiscal").Value)
                    Else
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                    End If

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
                                     Formulario.FaturamentoEmissaoNFs, _
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
                                     Formulario.FaturamentoEmissaoNFs)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Torna Invisível Controles
            btnImportarPedido.Visible = False

            Select Case e.Page.Name

                Case "pagDadosNFs"
                    btnImportarPedido.Visible = True

                Case "pagNFSe"
                    'Carrega Configuração da NF-e
                    Call LoadConfiguracaoNFSe()

                    'Seta Ambiente - NFe
                    Select Case goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe
                        Case TipoAmbienteNFSe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                        Case TipoAmbienteNFSe.producao : lblAmbiente.Text = "** Ambiente de Produção"
                    End Select

            End Select

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

    Private Sub cboNaturezaOperacaoServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNaturezaOperacaoServico.SelectedIndexChanged

        Try

            'Verifica se foi selecionado Algum Registro
            If cboNaturezaOperacaoServico.SelectedValue = CInt(NaturezaOperacaoNFSe.TributacaoMunicipio) Then
                cboISSRetido.SelectedValue = True
                cboISSRetido.Enabled = True
                cboUFTributacao.SelectedValue = goEmitente.sUF : cboUFTributacao.Enabled = False
                cboMunicipioTributacao.Text = goEmitente.sMunicipio : cboMunicipioTributacao.Enabled = False
            ElseIf cboNaturezaOperacaoServico.SelectedValue = CInt(NaturezaOperacaoNFSe.TributacaoForaMunicipio) Then
                cboISSRetido.SelectedValue = True
                cboISSRetido.Enabled = True
                cboUFTributacao.Enabled = True
                cboMunicipioTributacao.Enabled = True
            Else
                cboISSRetido.SelectedValue = False
                cboISSRetido.Enabled = False
                cboUFTributacao.SelectedValue = goEmitente.sUF : cboUFTributacao.Enabled = False
                cboMunicipioTributacao.Text = goEmitente.sMunicipio : cboMunicipioTributacao.Enabled = False
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFTributacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFTributacao.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFTributacao.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioTributacao.DataSource = Nothing
                cboMunicipioTributacao.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioTributacao, "sp_select_combo_static_municipio " & cboUFTributacao.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TOMADOR :::"

    Private Sub btnCadastrarTomador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTomador.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboTomador, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboTomador.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPaisTomador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisTomador.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo            
            LoadCombo(cboPaisTomador, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

            'Seta Focu
            cboPaisTomador.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCEPTomador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEPTomador.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCEPTomador.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPTomador.Text.Trim, "-", "")), _
                           cboPaisTomador, _
                           cboUFTomador, _
                           cboMunicipioTomador, _
                           txtBairroTomador, _
                           txtLogradouroTomador, _
                           txtComplementoTomador)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarTomador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarTomador.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboTomador

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboTomador.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTomador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTomador.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado a Destinatário
            If cboTomador.SelectedIndex = -1 Then

                'Limpa Dados da Destinatário
                txtCNPJTomador.Enabled = False : txtCNPJTomador.Text = ""
                txtInscricaoEstadualTomador.Enabled = False : txtInscricaoEstadualTomador.Text = ""
                txtInscricaoMunicipalTomador.Enabled = False : txtInscricaoMunicipalTomador.Text = ""
                txtLogradouroTomador.Enabled = False : txtLogradouroTomador.Text = ""
                txtNumeroTomador.Enabled = False : txtNumeroTomador.Text = ""
                txtComplementoTomador.Enabled = False : txtComplementoTomador.Text = ""
                txtBairroTomador.Enabled = False : txtBairroTomador.Text = ""
                txtCEPTomador.Enabled = False : txtCEPTomador.Text = ""
                cboPaisTomador.Enabled = False : cboPaisTomador.SelectedIndex = -1
                cboUFTomador.Enabled = False : cboUFTomador.SelectedIndex = -1
                cboMunicipioTomador.Enabled = False : cboMunicipioTomador.SelectedIndex = -1
                txtTelefoneTomador.Enabled = False : txtTelefoneTomador.Text = ""
                txtEmailTomador.Enabled = False : txtEmailTomador.Text = ""
                txtCNPJTomador.Tag = ""

            Else

                'Carrega dados do Destinatário
                Call LoadDadosParceiroNegocio(cboTomador.SelectedValue, _
                                              txtCNPJTomador, _
                                              txtInscricaoEstadualTomador, _
                                              txtInscricaoMunicipalTomador, _
                                              txtLogradouroTomador, _
                                              txtNumeroTomador, _
                                              txtComplementoTomador, _
                                              txtBairroTomador, _
                                              txtCEPTomador, _
                                              cboPaisTomador, _
                                              cboUFTomador, _
                                              cboMunicipioTomador, _
                                              txtTelefoneTomador, _
                                              txtEmailTomador)

                'Verifica o Tipo de Personalidade
                If txtCNPJTomador.Tag = Personalidade.fisica Then
                    lblCNPJTomador.Text = "CPF:"
                    lblInscricaoEstadualTomador.Text = "RG:"
                Else
                    lblCNPJTomador.Text = "CNPJ:"
                    lblInscricaoEstadualTomador.Text = "IE:"
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPaisTomador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaisTomador.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisTomador.SelectedIndex = -1 Then
                'Limpa Controles
                cboUFTomador.DataSource = Nothing
                cboUFTomador.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboUFTomador, "sp_select_combo_static_estado_pais " & cboPaisTomador.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFTomador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFTomador.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFTomador.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipioTomador.DataSource = Nothing
                cboMunicipioTomador.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipioTomador, "sp_select_combo_static_municipio " & cboUFTomador.SelectedValue)
            End If

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
            Call oClsFatEmissaoNFs.GerarDuplicata(grdDuplicata, _
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
            txtValorLiquido.Value = txtValorOriginal.Value - txtValorDesconto.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

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

    Private Sub cboServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Serviço
            If cboServico.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricao.Text = ""
                txtAliquotaISS.Value = 0
            Else
                'Carrega Dados do Serviço
                oClsFatEmissaoNFs.LoadDadosServico(cboServico.SelectedValue, _
                                                   txtDescricao, _
                                                   txtAliquotaISS)
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

                'Verifica se a Base de Calculo é maior que R$ 5.000,00
                If txtBaseCalculo.Value >= 215.05 Then

                    'PIS
                    txtValorPIS.Value = txtBaseCalculo.Value * txtAliquotaPIS.Value / 100.0
                    'COFINS
                    txtValorCOFINS.Value = txtBaseCalculo.Value * txtAliquotaCOFINS.Value / 100.0
                    'INSS
                    txtValorINSS.Value = txtBaseCalculo.Value * txtAliquotaINSS.Value / 100.0
                    'CSLL
                    txtValorCSLL.Value = txtBaseCalculo.Value * txtAliquotaCSLL.Value / 100.0

                Else

                    'Zera Controles
                    txtValorPIS.Value = 0
                    txtValorCOFINS.Value = 0
                    txtValorINSS.Value = 0
                    txtValorCSLL.Value = 0

                End If

                'IR
                txtValorIR.Value = txtBaseCalculo.Value * txtAliquotaIR.Value / 100.0

                'ISS
                If cboISSRetido.SelectedValue = False Then
                    txtValorISS.Value = txtBaseCalculo.Value * txtAliquotaISS.Value / 100.0
                    txtValorISSRetido.Value = 0
                Else
                    txtValorISSRetido.Value = txtBaseCalculo.Value * txtAliquotaISS.Value / 100.0
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

                'Seta Valor Fatura
                txtValorOriginal.Value = txtValorLiquidoNFSE.Value + txtValorDescontoCondicionado.Value + txtValorDescontoIncondicionado.Value
                txtValorDesconto.Value = txtValorDescontoCondicionado.Value + txtValorDescontoIncondicionado.Value

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

#End Region

#Region "::: NFSe :::"

    Private Sub btnTransmitirNFSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitirNFSE.Click

        Try

            'Valida Nota Fiscal
            If Validacao() Then

                'Salvando a Nota Fiscal
                Call Salvar()

                'Valida Formulário
                If ValidacaoNFse() Then

                    'Transmite Nota Fiscal
                    Call TransmitirLote()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnRetornarNFSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornarNFSE.Click

        Try

            'Retorna Nota Fiscal
            Call RetornarLote()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnReenviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReenviarEmail.Click

        Try

            'Retorna Nota Fiscal
            Call EnviarEmailNFSe()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirNFSe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirNFSe.Click

        Try

            'Imprimir Nota Fiscal
            Call ImprimirNFSe(goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe, _
                              txtCodigoVerificacao.Text.Trim, _
                              txtNotaFiscal.Text)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEmissaoNFs_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFs, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFs, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFs, gcDelete)
            btnExcel.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFs, gcPrint)
            btnCadastrarTomador.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarPaisTomador.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)

            'Carrega Combo - Filtro
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nfse")
            Call LoadCombo(cboTipoRPSFiltro, "sp_select_combo_static_tipo_rps")
            Call LoadCombo(cboNaturezaOperacaoServicoFiltro, "sp_select_combo_static_natureza_operacao_servico")
            Call LoadCombo(cboUFTributacao, "sp_select_combo_static_estado_pais " & CInt(Pais.Brasil))
            'Dados Gerais
            Call LoadCombo(cboModelo, "sp_select_combo_static_modelo_nota_fiscal " & CInt(TipoItem.servico))
            Call LoadCombo(cboTipoRPS, "sp_select_combo_static_tipo_rps", False)
            Call LoadCombo(cboNaturezaOperacaoServico, "sp_select_combo_static_natureza_operacao_servico", False)
            'Carrega Combo - Tomador
            Call LoadCombo(cboTomador, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboPaisTomador, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
            'Carrega Combo - Serviço            
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico), False)
            Call LoadComboSimNao(cboISSRetido)
            'Carrega Combo - Classificação
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            'Carrega Combo - Cobrança
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFs)

            'Seta Controles
            btnImportarPedido.Visible = False
            dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Checked = False

            'Carrega Configuração da NF-e
            Call LoadConfiguracaoNFSe()

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Configuração da NF-e
            Call LoadConfiguracaoNFe()

            'Seta Ambiente - NFe

            Select Case goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe
                Case TipoAmbienteNFSe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                Case TipoAmbienteNFSe.producao : lblAmbiente.Text = "** Ambiente de Produção"
            End Select

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

            'Desabilia Controles
            cboUFTributacao.SelectedValue = goEmitente.sUF : cboUFTributacao.Enabled = False
            cboMunicipioTributacao.Text = goEmitente.sMunicipio : cboMunicipioTributacao.Enabled = False

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
            Dim sTipoRPS As String = ""
            Dim sNaturezaOperacao As String = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Tipo de RPS
            If cboTipoRPSFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboTipoRPSFiltro.CheckedValues)
                    sTipoRPS &= IIf(sTipoRPS = "", "", ",") & cboTipoRPSFiltro.CheckedValues(i).ToString
                Next
            End If

            'Natureza de Operação
            If cboNaturezaOperacaoServicoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboNaturezaOperacaoServicoFiltro.CheckedValues)
                    sNaturezaOperacao &= IIf(sNaturezaOperacao = "", "", ",") & cboNaturezaOperacaoServicoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFatEmissaoNFs.LoadGrid(grdListagem, _
                                       IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                       txtSerieFiltro.Text.Trim, _
                                       txtTomadorFiltro.Text.Trim, _
                                       IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                       IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                       sStatus, _
                                       sTipoRPS, _
                                       sNaturezaOperacao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Limpa Controles - Dados da NFs
            cboModelo.SelectedIndex = -1
            cboSerie.SelectedIndex = -1
            txtNotaFiscal.Text = ""
            txtDataEmissao.Text = ""
            cboTipoRPS.SelectedIndex = -1
            cboNaturezaOperacaoServico.SelectedIndex = -1
            cboUFTributacao.SelectedValue = goEmitente.sUF : cboUFTributacao.Enabled = False
            cboMunicipioTributacao.Text = goEmitente.sMunicipio : cboMunicipioTributacao.Enabled = False
            btnSalvar.Tag = ""

            'Limpa Controles - Tomador
            cboTomador.SelectedIndex = -1

            'Limpa Controles - Serviço
            cboServico.SelectedIndex = -1
            cboServico.Tag = ""
            txtDescricao.Text = ""
            txtValorServico.Value = 0
            txtValorDescontoCondicionado.Value = 0
            txtValorDescontoIncondicionado.Value = 0
            txtValorLiquidoNFSE.Value = 0
            txtOutrasRetencoes.Value = 0
            txtValorDeducoes.Value = 0
            txtBaseCalculo.Value = 0
            txtAliquotaISS.Value = 0
            txtValorISS.Value = 0
            cboISSRetido.SelectedIndex = -1
            txtValorISSRetido.Value = 0

            txtValorPIS.Value = 0

            txtValorCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtValorINSS.Value = 0

            txtValorCSLL.Value = 0
            txtAliquotaIR.Value = 0
            txtValorIR.Value = 0

            'Validação da alteração de NFSe
            If goEmitente.iRegimeTributario <> CInt(RegimeTributario.SimplesNacional) And goEmitente.iRegimeTributario <> CInt(RegimeTributario.SimplesNacionalExceto) Then
                txtAliquotaCOFINS.Value = 3
                txtAliquotaPIS.Value = 0.65
                txtAliquotaCSLL.Value = 1

            End If

            'Limpa Controles - Cobrança
            txtFatura.Text = ""
            txtValorOriginal.Value = 0
            txtValorDesconto.Value = 0
            txtValorLiquido.Value = 0
            cboFormaPagamento.SelectedIndex = -1
            txtNumeroParcela.Value = 0
            txtIntervaloEntreParcelas.Value = 0
            grdDuplicata.DataSource = Nothing

            'Seta Controles
            txtNumeroRPS.Text = ""
            txtStatusNFSe.Text = ""
            txtMensagemNFSe.Text = ""
            txtLote.Text = ""
            txtProtocolo.Text = ""
            txtCodigoVerificacao.Text = ""
            txtStatusNFSe.Tag = ""

            'Verifica o Status
            Call VerificaStatus(StatusNFSe.AguardandoTransmissao)

            'Seta Propriedade dos Controles
            cboServico.Enabled = True
            txtDescricao.Enabled = True
            txtValorServico.Enabled = True
            txtAliquotaISS.Enabled = True
            txtValorDescontoIncondicionado.Enabled = True

            'Seta Focu - Aba
            tabDados.SelectedTab = pagDadosNFs

            'Seta Propriedade do Controle
            btnImportarPedido.Visible = True

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
            'Insere Dados do Tomador
            Call SalvarTomador()
            'Insere Dados do Serviço
            Call SalvarServico()
            'Insere Dados da Fatura
            Call SalvarFatura()

            'Seta Status
            txtStatusNFSe.Tag = CInt(StatusNFSe.AguardandoTransmissao)
            'Verifica Status
            Call VerificaStatus(txtStatusNFSe.Tag)

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
            oClsFatEmissaoNFs.CodigoEmissaoNFSe = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsFatEmissaoNFs.ModeloNotaFiscal = cboModelo.SelectedValue
            oClsFatEmissaoNFs.Serie = cboSerie.Text
            oClsFatEmissaoNFs.CodigoTipoRPS = cboTipoRPS.SelectedValue
            oClsFatEmissaoNFs.CodigoNaturezaOperacao = cboNaturezaOperacaoServico.SelectedValue
            oClsFatEmissaoNFs.UFTributacao = IIf(cboUFTributacao.Enabled = False, goEmitente.sUF, cboUFTributacao.SelectedValue)
            oClsFatEmissaoNFs.CodigoMunicipioTributacao = IIf(cboMunicipioTributacao.Enabled = False, goEmitente.iMunicipio, cboMunicipioTributacao.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = True Then
                oClsFatEmissaoNFs.UpdateCapa()
            Else
                oClsFatEmissaoNFs.InsertCapa()
            End If

            'Seta Controle
            btnSalvar.Tag = oClsFatEmissaoNFs.CodigoEmissaoNFSe

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirCapa()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusNFSe.AguardandoTransmissao)) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoNFs.DeleteCapa()

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
            If VerificaDireito(Formulario.FaturamentoEmissaoNFs, gcAdministrator) = True Then

                'Verifica se foi selecinado algum registro
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusNFSe.AutorizadoUso) Then

                    'Váriavel - Formulário
                    Dim oForm As New frmFatEmissaoNFsCancelar

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

    Private Sub EditarNotaFiscal(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoNFs, gcUpdate) = True Then

                'Oculta Aba
                tabDados.Visible = False

                'Limpa Dados do Formulário
                Call Novo()

                'Carrega Dados da Nota Fiscal
                Call oClsFatEmissaoNFs.LoadDadosNotaFiscal(lCodigoEmissaoCapa, _
                                                           cboModelo, _
                                                           cboSerie, _
                                                           txtNotaFiscal, _
                                                           txtDataEmissao, _
                                                           cboTipoRPS, _
                                                           cboNaturezaOperacaoServico, _
                                                           cboUFTributacao, _
                                                           cboMunicipioTributacao, _
                                                           cboTomador, _
                                                           txtCNPJTomador, _
                                                           txtInscricaoEstadualTomador, _
                                                           txtInscricaoMunicipalTomador, _
                                                           txtCEPTomador, _
                                                           cboPaisTomador, _
                                                           cboUFTomador, _
                                                           cboMunicipioTomador, _
                                                           txtLogradouroTomador, _
                                                           txtNumeroTomador, _
                                                           txtBairroTomador, _
                                                           txtComplementoTomador, _
                                                           txtTelefoneTomador, _
                                                           txtEmailTomador, _
                                                           cboServico, _
                                                           txtDescricao, _
                                                           txtValorServico, _
                                                           txtValorDescontoCondicionado, _
                                                           txtValorDescontoIncondicionado, _
                                                           txtValorLiquidoNFSE, _
                                                           cboCentroGasto, _
                                                           cboContaContabil, _
                                                           txtOutrasRetencoes, _
                                                           txtValorDeducoes, _
                                                           txtBaseCalculo, _
                                                           txtAliquotaISS, _
                                                           txtValorISS, _
                                                           cboISSRetido, _
                                                           txtValorISSRetido, _
                                                           txtAliquotaPIS, _
                                                           txtValorPIS, _
                                                           txtAliquotaCOFINS, _
                                                           txtValorCOFINS, _
                                                           txtAliquotaINSS, _
                                                           txtValorINSS, _
                                                           txtAliquotaCSLL, _
                                                           txtValorCSLL, _
                                                           txtAliquotaIR, _
                                                           txtValorIR, _
                                                           txtFatura, _
                                                           txtValorOriginal, _
                                                           txtValorDesconto, _
                                                           txtValorLiquido, _
                                                           cboFormaPagamento, _
                                                           txtNumeroParcela, _
                                                           txtIntervaloEntreParcelas, _
                                                           txtNumeroRPS, _
                                                           txtStatusNFSe, _
                                                           txtMensagemNFSe, _
                                                           txtLote, _
                                                           txtProtocolo, _
                                                           txtCodigoVerificacao)

                'Verifica Status da NFSe
                Call VerificaStatus(txtStatusNFSe.Tag)

                'Seta Controle
                If cboServico.Tag <> "" Then
                    cboServico.Enabled = False
                    txtValorServico.Enabled = False
                    txtValorDescontoIncondicionado.Enabled = False
                Else
                    cboServico.Enabled = True
                    txtValorServico.Enabled = True
                    txtValorDescontoIncondicionado.Enabled = True
                End If

                'Carrega Grid de Parcela
                Call oClsFatEmissaoNFs.LoadGridFatura(grdDuplicata, _
                                                      lCodigoEmissaoCapa)

                'Seta Controle
                btnSalvar.Tag = lCodigoEmissaoCapa

                'Seta Aba
                tabDados.SelectedTab = pagDadosNFs
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
            If VerificaDireito(Formulario.FaturamentoEmissaoNFs, gcInsert) = True Then

                'Verifica se o usuário deseja copiar a Nota Fiscal
                If MsgBox("Deseja Duplicar o Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Carrega Nota Fiscal
                    Call EditarNotaFiscal(oClsFatEmissaoNFs.DuplicarNF(grdListagem.CurrentRow.Cells("codigo").Value))

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
                tabDados.SelectedTab = pagDadosNFs
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Série
            If ValidaCampo(cboSerie, lblSerie) = False Then
                tabDados.SelectedTab = pagDadosNFs
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de RPS
            If ValidaCampo(cboTipoRPS, lblTipoRPS) = False Then
                tabDados.SelectedTab = pagDadosNFs
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Natureza da Operação
            If ValidaCampo(cboNaturezaOperacaoServico, lblNaturezaOperacaoServico) = False Then
                tabDados.SelectedTab = pagDadosNFs
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
                tabDados.SelectedTab = pagDadosNFs
                Exit Function
            End If

            'Valida Dados do Tomador
            If ValidacaoTomador() = False Then
                Exit Function
            End If

            'Valida Dados do Serviço
            If ValidacaoServico() = False Then
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
            oClsFatEmissaoNFs.LoadGridFatura(grdDuplicata, oClsFatEmissaoNFs.CodigoEmissaoNFSe)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VerificaStatus(ByVal iStatus As Integer)

        Try

            'Desabilita Controles
            btnTransmitirNFSE.Enabled = False
            btnRetornarNFSE.Enabled = False
            btnReenviarEmail.Enabled = False
            btnImprimirNFSe.Enabled = False

            'Verifica qual status foi selecionado
            Select Case iStatus

                Case StatusNFSe.AguardandoTransmissao
                    txtStatusNFSe.Text = "AGUARDANDO TRANSMISSÃO"
                    btnTransmitirNFSE.Enabled = True
                    btnSalvar.Enabled = True

                Case StatusNFSe.AguardandoRetorno
                    txtStatusNFSe.Text = "AGUARDANDO RETORNO"
                    btnRetornarNFSE.Enabled = True
                    btnSalvar.Enabled = False

                Case StatusNFSe.AutorizadoUso
                    txtStatusNFSe.Text = "AUTORIZADA PARA USO"
                    btnReenviarEmail.Enabled = True
                    btnImprimirNFSe.Enabled = True
                    btnSalvar.Enabled = False

                Case StatusNFSe.Cancelada
                    txtStatusNFSe.Text = "CANCELADA"
                    btnReenviarEmail.Enabled = False
                    btnImprimirNFSe.Enabled = False
                    btnSalvar.Enabled = False

                Case StatusNFSe.Rejeitada
                    txtStatusNFSe.Text = "REJEITADA"
                    btnTransmitirNFSE.Enabled = True
                    btnSalvar.Enabled = True

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ImprimirBoletoBancario()

        Try

            'Verifica se o foi gerado receita para a NFSe
            If grdListagem.CurrentRow.Cells("valor_financeiro").Value > 0 Then

                'Variável - Formulário de Boleto Bancário
                Dim oForm As New frmFinReceitaBoletoBancarioDLL
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                'Seta Parametros
                oForm.Cliente = grdListagem.CurrentRow.Cells("tomador").Value
                oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("nota_fiscal").Value
                oForm.CodigoTituloCapa = LoadDescricao("sp_select_faturamento_emissao_nfse_boleto_bancario " & grdListagem.CurrentRow.Cells("codigo").Value & ", " & goUsuario.iEmpresa)

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário sobre o Insucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi Gerado Contas a Receber para esta Nota Fiscal.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TOMADOR :::"

    Private Sub SalvarTomador()

        Try

            'Seta Parametros
            oClsFatEmissaoNFs.CodigoTomador = cboTomador.SelectedValue
            oClsFatEmissaoNFs.CnpjCpfTomador = txtCNPJTomador.Text.Trim
            oClsFatEmissaoNFs.InscricaoEstadualTomador = txtInscricaoEstadualTomador.Text.Trim
            oClsFatEmissaoNFs.InscricaoMunicipalTomador = txtInscricaoMunicipalTomador.Text.Trim
            oClsFatEmissaoNFs.CepTomador = txtCEPTomador.Text.Trim
            oClsFatEmissaoNFs.CodigoPaisTomador = cboPaisTomador.SelectedValue
            oClsFatEmissaoNFs.UFTomador = cboUFTomador.SelectedValue
            oClsFatEmissaoNFs.CodigoMunicipioTomador = cboMunicipioTomador.SelectedValue
            oClsFatEmissaoNFs.LogradouroTomador = txtLogradouroTomador.Text.Trim
            oClsFatEmissaoNFs.NumeroTomador = txtNumeroTomador.Text.Trim
            oClsFatEmissaoNFs.BairroTomador = txtBairroTomador.Text.Trim
            oClsFatEmissaoNFs.ComplementoTomador = txtComplementoTomador.Text.Trim
            oClsFatEmissaoNFs.TelefoneTomador = txtTelefoneTomador.Text.Trim
            oClsFatEmissaoNFs.EmailTomador = txtEmailTomador.Text.Trim

            'Salva Dados do Tomador
            oClsFatEmissaoNFs.DeleteTomador()
            oClsFatEmissaoNFs.InsertTomador()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoTomador() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoTomador = False

            'Verifica se foi Selecionado o Campo - Tomador
            If ValidaCampo(cboTomador, lblTomador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboTomador.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPaisTomador, lblPaisTomador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboPaisTomador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CNPJ /  CPF
            If ValidaCampo(txtCNPJTomador, lblCNPJTomador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtCNPJTomador.Focus()
                Exit Function
            ElseIf txtCNPJTomador.Tag = CInt(Personalidade.Juridica) And cboPaisTomador.SelectedValue = CInt(Pais.Brasil) Then
                If ValidaCNPJ(txtCNPJTomador.Text) = False Then
                    frmMain.errInfo.SetError(lblCNPJTomador, "Este CNPJ: " & txtCNPJTomador.Text.Trim & " não é válido.")
                    tabDados.SelectedTab = pagDadosNFs : txtCNPJTomador.Focus()
                    Exit Function
                End If
            ElseIf txtCNPJTomador.Tag = CInt(Personalidade.Fisica) And cboPaisTomador.SelectedValue = CInt(Pais.Brasil) Then
                If ValidaCPF(txtCNPJTomador.Text) = False Then
                    frmMain.errInfo.SetError(lblCNPJTomador, "Este CPF: " & txtCNPJTomador.Text.Trim & " não é válido.")
                    tabDados.SelectedTab = pagDadosNFs : txtCNPJTomador.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - CEP
            If ValidaCampo(txtCEPTomador, lblCEPTomador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtCEPTomador.Focus()
                Exit Function
            ElseIf txtCEPTomador.Text.Length <> 9 Then
                frmMain.errInfo.SetError(lblCEPTomador, "Este CEP: " & txtCEPTomador.Text.Trim & " está incompleto.")
                tabDados.SelectedTab = pagDadosNFs : txtCEPTomador.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFTomador, lblUFTomador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboUFTomador.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If ValidaCampo(cboMunicipioTomador, lblMunicipioTomador) = False Then
                tabDados.SelectedTab = pagDadosNFs : cboMunicipioTomador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouroTomador, lblLogradouroTomador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtLogradouroTomador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumeroTomador, lblNumeroTomador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtNumeroTomador.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bairro
            If ValidaCampo(txtBairroTomador, lblBairroTomador, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosNFs : txtBairroTomador.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoTomador = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: EMITENTE :::"

    Private Sub SalvarEmitente()

        Try

            'Salva Dados do Emitente
            oClsFatEmissaoNFs.DeleteEmitente()
            oClsFatEmissaoNFs.InsertEmitente()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub SalvarFatura()

        Try

            'Deleta Dados da Fatura
            oClsFatEmissaoNFs.DeleteFatura()

            'Seta Parametros
            oClsFatEmissaoNFs.Fatura = txtFatura.Text.Trim
            oClsFatEmissaoNFs.CodigoFormaPagamentoNFe = cboFormaPagamento.SelectedValue
            oClsFatEmissaoNFs.ValorOriginal = txtValorOriginal.Value
            oClsFatEmissaoNFs.ValorDesconto = txtValorDesconto.Value
            oClsFatEmissaoNFs.ValorLiquido = txtValorLiquido.Value
            oClsFatEmissaoNFs.NumeroParcela = txtNumeroParcela.Value
            oClsFatEmissaoNFs.IntervaloParcela = txtIntervaloEntreParcelas.Value

            'Salva Dados Fatura
            oClsFatEmissaoNFs.InsertFatura()
            oClsFatEmissaoNFs.InsertFaturaDuplicata(grdDuplicata)

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

#Region "::: SERVIÇO :::"

    Private Sub SalvarServico()

        Try

            'Seta Parametros
            oClsFatEmissaoNFs.CodigoServico = cboServico.SelectedValue
            oClsFatEmissaoNFs.Descricao = txtDescricao.Text.Trim
            oClsFatEmissaoNFs.ValorServico = txtValorServico.Value
            oClsFatEmissaoNFs.DescontoCondicional = txtValorDescontoCondicionado.Value
            oClsFatEmissaoNFs.DescontoIncondicional = txtValorDescontoIncondicionado.Value
            oClsFatEmissaoNFs.ValorLiquidoServico = txtValorLiquidoNFSE.Value
            oClsFatEmissaoNFs.CodigoCentroGasto = IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue)
            oClsFatEmissaoNFs.CodigoContaContabil = IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue)
            oClsFatEmissaoNFs.OutrasReducoes = txtOutrasRetencoes.Value
            oClsFatEmissaoNFs.ValorDeducoes = txtValorDeducoes.Value
            oClsFatEmissaoNFs.BaseCalculo = txtBaseCalculo.Value
            oClsFatEmissaoNFs.AliquotaISS = txtAliquotaISS.Value
            oClsFatEmissaoNFs.ValorISS = txtValorISS.Value
            oClsFatEmissaoNFs.ISSRetido = cboISSRetido.SelectedValue
            oClsFatEmissaoNFs.ValorISSRetido = txtValorISSRetido.Value
            oClsFatEmissaoNFs.AliquotaPIS = txtAliquotaPIS.Value
            oClsFatEmissaoNFs.ValorPIS = txtValorPIS.Value
            oClsFatEmissaoNFs.AliquotaCOFINS = txtAliquotaCOFINS.Value
            oClsFatEmissaoNFs.ValorCOFINS = txtValorCOFINS.Value
            oClsFatEmissaoNFs.AliquotaINSS = txtAliquotaINSS.Value
            oClsFatEmissaoNFs.ValorINSS = txtValorINSS.Value
            oClsFatEmissaoNFs.AliquotaCSLL = txtAliquotaCSLL.Value
            oClsFatEmissaoNFs.ValorCSLL = txtValorCSLL.Value
            oClsFatEmissaoNFs.AliquotaIR = txtAliquotaIR.Value
            oClsFatEmissaoNFs.ValorIR = txtValorIR.Value

            'Verifica se é de um Pedido de Venda
            If cboServico.Tag <> "" Then
                'Obtém dados do Pedido
                Dim oPedido() As String
                oPedido = cboServico.Tag.ToString.Split("/")



                'Seta Parâmetros
                oClsFatEmissaoNFs.CodigoPedidoVenda = oPedido(0)
                oClsFatEmissaoNFs.CodigoPedidoVendaItem = oPedido(1)
                If oPedido.Count = 4 Then
                    oClsFatEmissaoNFs.CodigoPedidoVendaItemEntrega = oPedido(2)
                    oClsFatEmissaoNFs.QuantidadePedido = oPedido(3)
                Else
                    oClsFatEmissaoNFs.CodigoPedidoVendaItemEntrega = 1
                    oClsFatEmissaoNFs.QuantidadePedido = oPedido(2)
                End If

            Else
                'Seta Parâmetros
                oClsFatEmissaoNFs.CodigoPedidoVenda = -1
                oClsFatEmissaoNFs.CodigoPedidoVendaItem = -1
                oClsFatEmissaoNFs.CodigoPedidoVendaItemEntrega = -1
                oClsFatEmissaoNFs.QuantidadePedido = -1
            End If

            'Salva Dados do Serviço
            oClsFatEmissaoNFs.DeleteServico()
            oClsFatEmissaoNFs.InsertServico()

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

#End Region

#Region "::: FUNCTION / SUB (NFSe):::"

    Private Function ValidacaoNFse() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoNFse = False

            'Carrega Configuração da NFe
            If LoadConfiguracaoNFSe() = False Then
                'Informa o Usuário que não existe configuração de Nota Fiscal Eletrônica cadastrada
                frmMain.Informacao(Mensagem.NaoFoiInformado, "a Configuração da NFSe")
                Exit Function
            Else
                'Seta Ambiente - NFe
                Select Case goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe
                    Case TipoAmbienteNFSe.naoidentificado : lblAmbiente.Text = "** Ambiente Não Identificado"
                    Case TipoAmbienteNFSe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                    Case TipoAmbienteNFSe.producao : lblAmbiente.Text = "** Ambiente de Produção"
                End Select
            End If

            'Verifica se a Pasta de Entrada Existe
            If Directory.Exists(goConfiguracaoNFSe.sPastaEntrada) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFSe.sPastaEntrada)
                Exit Function
            End If

            'Verifica se a Pasta de Envio Existe
            If Directory.Exists(goConfiguracaoNFSe.sPastaEnvio) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFSe.sPastaEnvio)
                Exit Function
            End If

            'Verifica se a Pasta de Impressão Existe
            If Directory.Exists(goConfiguracaoNFSe.sPastaImpressao) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFSe.sPastaImpressao)
                Exit Function
            End If

            'Verifica se a Pasta de Recibo Existe
            If Directory.Exists(goConfiguracaoNFSe.sPastaRecibo) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFSe.sPastaRecibo)
                Exit Function
            End If

            'Verifica se a Pasta de Saída Existe
            If Directory.Exists(goConfiguracaoNFSe.sPastaSaida) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFSe.sPastaSaida)
                Exit Function
            End If

            'Verifica se a Pasta XSD Existe
            If Directory.Exists(goConfiguracaoNFSe.sPastaXSD) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFSe.sPastaXSD)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoNFse = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub TransmitirLote()

        Try

            'Variável da classe
            Dim oClsNFSE_EnvioLote As New clsNFSE_Jacarei_EnvioLote

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Gera Número RPS
            If txtNumeroRPS.Text = "" Then
                txtNumeroRPS.Text = oClsFatEmissaoNFs.GeraNumeroRPS
            End If

            'Gera Número do Lote
            If txtLote.Text = "" Then
                txtLote.Text = oClsFatEmissaoNFs.GeraNumeroLote
            End If

            'Setando o lote 
            oClsNFSE_EnvioLote.Lote = txtLote.Text

            'Enviando a NFSe
            If oClsNFSE_EnvioLote.Send = True Then

                Try

                    'Carregando o arquivo de retorno
                    oClsNFSE_EnvioLote.LoadArquivo(oClsNFSE_EnvioLote.ArquivoRetorno)

                    'Seta Controles conforme Mensagem de Erro
                    If oClsNFSE_EnvioLote.MensagemErro <> "" Then
                        txtMensagemNFSe.Text = oClsNFSE_EnvioLote.MensagemErro
                        frmMain.Informacao(Mensagem.Erro, oClsNFSE_EnvioLote.MensagemErro)
                    Else
                        'Seta Controles
                        txtProtocolo.Text = oClsNFSE_EnvioLote.Protocolo
                        txtMensagemNFSe.Text = ""

                        'Atualizando a NFSe
                        oClsFatEmissaoNFs.UpdateStatusNotaFiscal(btnSalvar.Tag, _
                                                                 StatusNFSe.AguardandoRetorno, _
                                                                 oClsNFSE_EnvioLote.Protocolo, _
                                                                 oClsNFSE_EnvioLote.DataRecebimento)

                        'Verifica Status
                        Call VerificaStatus(StatusNFSe.AguardandoRetorno)

                    End If

                Catch ex As Exception
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, ex.Message)
                End Try

            Else

                'Verifica se houve Erro
                If oClsNFSE_EnvioLote.MensagemErro <> "" Then
                    frmMain.Informacao(Mensagem.Erro, oClsNFSE_EnvioLote.MensagemErro)
                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RetornarLote()

        Try

            'Váriaveis Locais
            Dim oClsNFSeRetornoEnvioNFSe As New clsNFSE_Jacarei_ConsultaLote
            Dim oClsNFSeConsultaSituacaoNFSe As New clsNFSE_Jacarei_ConsultaSituacaoLoteRPS

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmetros
            oClsNFSeRetornoEnvioNFSe.Protocolo = txtProtocolo.Text
            oClsNFSeConsultaSituacaoNFSe.Protocolo = txtProtocolo.Text

            'Primeiro, consulta a situação do lote para ver se foi aceito
            If oClsNFSeConsultaSituacaoNFSe.Send = True Then

                Try

                    'Carregando o arquivo de retorno
                    oClsNFSeConsultaSituacaoNFSe.LoadArquivo(oClsNFSeConsultaSituacaoNFSe.ArquivoRetorno)

                    'Se a situação do lote for 4, quer dizer que foi aceito
                    If oClsNFSeConsultaSituacaoNFSe.Situacao = 4 Then

                        'Seta Controles
                        txtStatusNFSe.Tag = StatusNFSe.AutorizadoUso
                        txtMensagemNFSe.Text = "AUTORIZADO O USO DA NFS-E"

                        If oClsNFSeRetornoEnvioNFSe.Send() = True Then

                            'Carregando o arquivo de retorno, somente para receber o código de verificação
                            oClsNFSeRetornoEnvioNFSe.LoadArquivoVerificacao(oClsNFSeRetornoEnvioNFSe.ArquivoRetorno)

                            txtCodigoVerificacao.Text = oClsNFSeRetornoEnvioNFSe.CodigoVerificacao
                            txtDataEmissao.Text = Format(oClsNFSeRetornoEnvioNFSe.DataEmissao, "dd/MM/yyyy")
                            txtNotaFiscal.Text = Format(oClsNFSeRetornoEnvioNFSe.NotaFiscal, "000000000")

                            'Atualizando a NFSe
                            oClsFatEmissaoNFs.UpdateStatusNotaFiscal(btnSalvar.Tag, _
                                                                     StatusNFSe.AutorizadoUso, _
                                                                     "", _
                                                                     "", _
                                                                     "AUTORIZADO O USO DA NFS-E", _
                                                                     txtCodigoVerificacao.Text, _
                                                                     txtDataEmissao.Text, _
                                                                     txtNotaFiscal.Text)

                            'Verifica Status da Nota Fiscal
                            VerificaStatus(StatusNFSe.AutorizadoUso)

                            'Integração
                            Call Integracao()

                        End If

                    ElseIf oClsNFSeRetornoEnvioNFSe.Send() = True Then

                        'Carregando o arquivo de retorno
                        oClsNFSeRetornoEnvioNFSe.LoadArquivo(oClsNFSeRetornoEnvioNFSe.ArquivoRetorno)

                        Dim oXmlDocument As New Xml.XmlDocument
                        oXmlDocument.Load(oClsNFSeRetornoEnvioNFSe.ArquivoRetorno)

                        If oXmlDocument.InnerXml.Contains(">E4<") Then
                            'Verifica Status
                            txtMensagemNFSe.Text = "O LOTE NÃO FOI PROCESSADO AINDA"
                            'Atualiza o Status da Nota Fiscal
                            oClsFatEmissaoNFs.UpdateStatusNotaFiscal(oClsFatEmissaoNFs.CodigoEmissaoNFSe, _
                                                                     StatusNFSe.AguardandoRetorno)
                            'Verifica o Status
                            Call VerificaStatus(StatusNFSe.AguardandoRetorno)
                        Else
                            'Verifica Status
                            txtMensagemNFSe.Text = "REJEITADA: " & oClsNFSeRetornoEnvioNFSe.MensagemErro
                            Call VerificaStatus(StatusNFSe.Rejeitada)
                            'Atualiza o Status da Nota Fiscal
                            oClsFatEmissaoNFs.UpdateStatusNotaFiscal(oClsFatEmissaoNFs.CodigoEmissaoNFSe, _
                                                                     StatusNFSe.Rejeitada)
                        End If

                    End If

                Catch ex As Exception
                    frmMain.Informacao(Mensagem.Erro, ex.Message)
                End Try

            Else
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oClsNFSeRetornoEnvioNFSe.MensagemErro)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub EnviarEmailNFSe()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se possui o E-mail do Tomador
            If txtEmailTomador.Text = "" Then
                frmMain.errInfo.SetError(lblEmailTomador, "E-mail inválido para envio da Nota Fiscal de Serviço Eletrônica.")
                tabDados.SelectedTab = pagDadosNFs : txtEmailTomador.Focus()
                Exit Sub
            End If

            Dim sCorpo As String = ""
            sCorpo = "Prezado(a) , segue as informações da Nota Fiscal de Serviço Eletrônica nº " & txtNotaFiscal.Text & " da empresa " & goEmitente.sNomeFantasia & " " & vbNewLine
            sCorpo &= "Para acessá-la, acesse o link a seguir: http://visualizar.ginfes.com.br/report/consultarNota?__report=nfs_ver4&cdVerificacao=" & txtCodigoVerificacao.Text & "&numNota=" & txtNotaFiscal.Text
            sCorpo &= vbNewLine & "INTERACTI - ACTi Consultoria " & vbNewLine
            sCorpo &= "www.acticonsultoria.com.br"

            'Enviando o email  
            Call EnviarEmail("Emissão de NFS-e - " & goEmitente.sNomeFantasia, _
                             txtEmailTomador.Text, _
                             "", _
                             "", _
                             sCorpo, _
                             cboTomador.SelectedValue, _
                             "")


            'Informando ao usuário que o e-mail foi enviado 
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ImprimirNFSe(ByVal iCodigoTipoAmbiente As Integer, _
                             ByVal sCodigoVerificacao As String, _
                             ByVal lNotaFiscal As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If iCodigoTipoAmbiente = CInt(TipoAmbienteNFSe.homologacao) Then

                System.Diagnostics.Process.Start("http://sjc.ginfesh.com.br/birt/frameset/?__report=nfs_ver4.rptdesign&cdVerificacao=" & sCodigoVerificacao & "&numNota=" & lNotaFiscal)

            Else

                System.Diagnostics.Process.Start("http://sjc.ginfes.com.br/birt/frameset/?__report=nfs_ver4.rptdesign&cdVerificacao=" & sCodigoVerificacao & "&numNota=" & lNotaFiscal)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


    Private Sub btnTransmissaoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmissaoLote.Click
        Try
            TransmissaoLote()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub TransmissaoLote()
        Try

            'Validando se foi selecionado algum registro
            If grdListagem.GetCheckedRows.Count = 0 Then
                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Sub
            End If

            'Instanciando e abrindo o formulário
            Dim oForm As New frmFatEmissaoNFsAcaoEmLote
            oForm.Grid = grdListagem
            ConfigureMaskEdit(oForm) : oForm.ShowDialog()


            'Carregando a grid novamente
            LoadGrid()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
