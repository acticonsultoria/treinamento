Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Drawing.Printing
Imports INTERACTI.NFe.CertificadoDigital

Public Class usrFatEmissaoMDFe

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEmissaoMDFe As New clsUsrFatEmissaoMDFe
    Private lCodigoEmissaoCapa As Long
    Private sMunicipio As String
    'Private iEditado As Integer

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

    Private Sub usrFatEmissaoMDFe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboDadosAdicionaisPreCadastrado" : Call LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais), False)
                        Case "cboTipoEmitente" : Call LoadCombo(cboTipoEmitente, "sp_select_combo_static_tipo_emitente_mdfe")
                        Case "cboModalidade" : Call LoadCombo(cboModalidade, "sp_select_combo_static_modalidade_mdfe")
                        Case "cboModalidadeFiltro" : Call LoadCombo(cboModalidadeFiltro, "sp_select_combo_static_modalidade_mdfe")
                        Case "cboFormaEmissao" : Call LoadCombo(cboFormaEmissao, "sp_select_combo_static_forma_emissao_nfe")
                        Case "cboUFCapa" : Call LoadCombo(cboUFCapa, "sp_select_combo_static_estado")
                        Case "cboUFCarregamento" : Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")
                        Case "cboUFDescarregamento" : Call LoadCombo(cboUFDescarregamento, "sp_select_combo_static_estado")
                        Case "cboUFDescarregamentoInformacoes" : Call LoadCombo(cboUFDescarregamentoInformacoes, "sp_select_combo_static_estado")
                        Case "cboUFDescarregamentoDocumentos" : Call LoadCombo(cboUFDescarregamentoDocumentos, "sp_select_combo_static_estado")
                        Case "cboUFDestinatario" : Call LoadCombo(cboUFDestinatario, "sp_select_combo_static_estado")
                        Case "cboUFLicenciamentoReboque" : Call LoadCombo(cboUFLicenciamentoReboque, "sp_select_combo_static_estado")
                        Case "cboUFNFReferenciada" : Call LoadCombo(cboUFNFReferenciada, "sp_select_combo_static_estado")
                        Case "cboUFPercurso" : Call LoadCombo(cboUFPercurso, "sp_select_combo_static_estado")
                        Case "cboUFProprietarioReboque" : Call LoadCombo(cboUFProprietarioReboque, "sp_select_combo_static_estado")
                        Case "cboUFProprietarioVeiculo" : Call LoadCombo(cboUFProprietarioVeiculo, "sp_select_combo_static_estado")
                        Case "cboUFVeiculo" : Call LoadCombo(cboUFVeiculo, "sp_select_combo_static_estado")
                        Case "cboUFDescarregamentoFiltro" : Call LoadCombo(cboUFDescarregamentoFiltro, "sp_select_combo_static_estado")
                        Case "cboTipoCarroceriaVeiculo" : Call LoadCombo(cboTipoCarroceriaVeiculo, "sp_select_combo_static_tipo_carroceria")
                        Case "cboTipoCarroceriaVeiculoReboque" : Call LoadCombo(cboTipoCarroceriaVeiculoReboque, "sp_select_combo_static_tipo_carroceria")
                        Case "cboTipoRodadoVeiculo" : Call LoadCombo(cboTipoRodadoVeiculo, "sp_select_combo_static_tipo_rodado")
                        Case "cboTipoRodadoReboque" : Call LoadCombo(cboTipoRodadoReboque, "sp_select_combo_static_tipo_rodado")
                        Case "cboTipoProprietarioVeiculo" : Call LoadCombo(cboTipoProprietarioVeiculo, "sp_select_combo_static_tipo_proprietario")
                        Case "cboTipoProprietarioReboque" : Call LoadCombo(cboTipoProprietarioReboque, "sp_select_combo_static_tipo_proprietario")
                        Case "cboUnidadeCargaAquaviario" : Call LoadCombo(cboUnidadeCargaAquaviario, "sp_select_combo_static_tipo_unidade_carga")
                        Case "cboUnidadeMedidaTotal" : Call LoadCombo(cboUnidadeMedidaTotal, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboDadosAdicionaisPreCadastrado" : Call LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais))
                        Case "cboStatusFiltro" : Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_mdfe")
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatEmissaoMDFe_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: MANIFESTO ELETRÔNICO :::"

#Region "::: CAPA :::"

    Private Sub btnImportarNFe_Click(sender As Object, e As EventArgs) Handles btnImportarNFe.Click
        Try
            ImportarNFe()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboModelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModelo.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum modelo
            If cboModelo.SelectedIndex = -1 Then
                'Limpa Controles
                cboSerie.DataSource = Nothing
                cboSerie.Text = ""
            Else
                'Carrega Combo - Série
                Call LoadCombo(cboSerie, "sp_select_combo_configuracao_serie_manifesto " & goUsuario.iEmpresa & ", " & cboModelo.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboSerie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSerie.SelectedIndexChanged
        Try
            If gSistema = "AGROACTI" Then

                If cboSerie.Text = "1" Then

                    lblValorInscricaoEstadualEmitente.Text = "282372709"
                ElseIf cboSerie.Text = "2" Then

                    lblValorInscricaoEstadualEmitente.Text = "285128094"
                End If



                txtNumeroDocumento.Text = oClsFatEmissaoMDFe.GeraNumeracao(cboSerie.SelectedValue)



            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoMDFe)

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

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimir.Click

        Try

            'Váriaveis Locais
            Dim sCodigoEmissaoCapa As String = ""

            For Each oRow As GridEXRow In grdListagem.GetCheckedRows
                sCodigoEmissaoCapa &= IIf(sCodigoEmissaoCapa = "", "", ",") & oRow.Cells("codigo_emissao_capa").Value
            Next

            If sCodigoEmissaoCapa = "" Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            Else
                Call ImprimirDAMFE(sCodigoEmissaoCapa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try

            'Exclui o Manifesto
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
            Call Novo1()


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
            dtpDataEmissao.Focus()

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
            txtNumeroDocumentoFiltro.Focus()

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

                'Verifica se o Número do Manifesto é gerado agora
                If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'gerar_numeracao_mdfe'"), Boolean) = True Then
                    'Gera Número do Manifesto
                    If txtNumeroDocumento.Text = "" Then
                        txtNumeroDocumento.Text = oClsFatEmissaoMDFe.GeraNumeroManifestoEletronico(cboSerie.SelectedValue)
                    End If

                End If

                'Seta Status
                If IsNumeric(txtStatusMDFe.Tag) = False Then
                    txtStatusMDFe.Tag = StatusManifestoEletronico.AguardandoTransmissao
                End If

                'Verifica o Status do MDFe
                Call VerificaStatus(txtStatusMDFe.Tag)


                btnSalvar.Tag = oClsFatEmissaoMDFe.CodigoEmissaoCapa

                'Gerar lote 
                txtLote.Text = oClsFatEmissaoMDFe.GeraNumeroLote()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboModalidade_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModalidade.SelectedIndexChanged
        Try
            'Verifica qual a modalidade selecionada
            If cboModalidade.SelectedIndex = -1 Then
                pagAquaviario.Enabled = False
                pagRodoviario.Enabled = False
            Else
                If (cboModalidade.Text = "RODOVIÁRIO") Then
                    pagAquaviario.Enabled = False
                    pagRodoviario.Enabled = True
                ElseIf (cboModalidade.Text = "AQUAVIÁRIO") Then
                    pagAquaviario.Enabled = True
                    pagRodoviario.Enabled = False
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFCarregamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUFCarregamento.SelectedIndexChanged
        Try
            If (cboUFCarregamento.SelectedIndex = -1) Then
                cboMunicipioCarregamento.SelectedIndex = -1
            Else
                Call LoadCombo(cboMunicipioCarregamento, "sp_select_combo_static_municipio " & cboUFCarregamento.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFDescarregamentoInformacoes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUFDescarregamentoInformacoes.SelectedIndexChanged
        Try
            If (cboUFDescarregamentoInformacoes.SelectedIndex = -1) Then
                cboMunicipioDescarregamentoInformacoes.SelectedIndex = -1
            Else
                Call LoadCombo(cboMunicipioDescarregamentoInformacoes, "sp_select_combo_static_municipio " & cboUFDescarregamento.SelectedValue)
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFDescarregamentoDocumentos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUFDescarregamentoDocumentos.SelectedIndexChanged
        Try
            If (cboUFDescarregamentoDocumentos.SelectedIndex = -1) Then
                cboMunicipioDescarregamentoDocumentos.SelectedIndex = -1
            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.CellUpdated
        Try

            'Verifica se a Coluna é a Data de Aceite
            If e.Column.Key = "data_aceite" Then

                'Váriaveis - Query
                Dim sQuery As String

                sQuery = "sp_update_interacti_table_field "
                sQuery &= "'tb_fat_emissao_mdfe_capa', "
                sQuery &= "'data_aceite', "
                If IsDBNull(grdListagem.GetValue("data_aceite")) = False AndAlso IsDate(grdListagem.GetValue("data_aceite")) Then
                    If DateDiff(DateInterval.Day, grdListagem.GetValue("data_aceite"), grdListagem.GetValue("data_saida")) > 0 Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Data de Aceite menor que a Data de Saída.")
                        grdListagem.SetValue("data_aceite", DBNull.Value)
                        sQuery &= "'NULL',"
                    Else
                        sQuery &= "'''" & grdListagem.GetValue("data_aceite") & "''',"
                    End If
                Else
                    sQuery &= "'NULL',"
                End If
                sQuery &= "'WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))'"

                'Atualiza Registro
                Call ExecuteQuery(sQuery)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved
        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GroupsChangingEventArgs) Handles grdListagem.GroupsChanging
        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEmissaoMDFe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarManifesto(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value)
                Case "duplicar" : Call DuplicarManifesto(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value)
                Case "imprimir" : Call ImprimirDamfe(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value)
                Case "email" : Call EmailMDFe(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value, grdListagem.CurrentRow.Cells("status").Value)
                Case "cancelar" : Call CancelarMDFe(grdListagem.CurrentRow.Cells("codigo_emissao_capa").Value, grdListagem.CurrentRow.Cells("status").Value)
                Case "finalizar" : Call Finalizar(grdListagem.CurrentRow.Cells.Item("codigo_emissao_capa").Value, grdListagem.CurrentRow.Cells.Item("status").Value)

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
                                     Formulario.FaturamentoEmissaoMDFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: CARREGAMENTO :::"

    Private Sub btnConfiguraGridCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridCarregamento.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdMunicipioCarregamento
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMunicipioCarregamento, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCarregamento.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdMunicipioCarregamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdMunicipioCarregamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdMunicipioCarregamento.GroupByBoxVisible = True
                grdMunicipioCarregamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCarregamento.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdMunicipioCarregamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvarCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarCarregamento.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoCarregamento() = True Then

                'Salva Dados do Registro
                Call SalvarCarregamento()

                'Limpa Formulário
                Call NovoCarregamento()

                'carrega a grid
                Call oClsFatEmissaoMDFe.LoadGridCarregamento(grdMunicipioCarregamento)

                If grdMunicipioCarregamento.RowCount > 0 Then
                    cboUFCarregamento.SelectedValue = grdMunicipioCarregamento.CurrentRow.Cells.Item("uf").Value
                    cboUFCarregamento.Enabled = False
                Else
                    cboUFCarregamento.Enabled = True
                    Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCarregamento.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui o carregamento
            Call ExcluirCarregamento()

            'Preapara Formulário para Inserção de um Novo Carregamento
            Call NovoCarregamento()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridCarregamento(grdMunicipioCarregamento)

            If grdMunicipioCarregamento.RowCount > 0 Then
                cboUFCarregamento.SelectedValue = grdMunicipioCarregamento.CurrentRow.Cells.Item("uf").Value
                cboUFCarregamento.Enabled = False
            Else
                cboUFCarregamento.Enabled = True
                Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdMunicipioCarregamento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdMunicipioCarregamento.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdMunicipioCarregamento.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdMunicipioCarregamento.CurrentColumn.Key

                Case "editar" : Call EditarCarregamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: PERCURSO :::"

    Private Sub btnSalvarPercurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarPercurso.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoPercurso() = True Then

                'Salva Dados do Registro
                Call SalvarPercurso()

                'Limpa Formulário
                Call NovoPercurso()

                'carrega a grid 
                Call oClsFatEmissaoMDFe.LoadGridPercurso(grdPercurso)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirPercurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirPercurso.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Percurso
            Call ExcluirPercurso()

            'Preapara Formulário para Inserção de um Novo Percurso
            Call NovoPercurso()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridPercurso(grdPercurso)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridPercurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridPercurso.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPercurso
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPercurso, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridPercurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPercurso.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdPercurso.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPercurso.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPercurso.GroupByBoxVisible = True
                grdPercurso.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridPercurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPercurso.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdPercurso)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdPercurso_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdPercurso.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdPercurso.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdPercurso.CurrentColumn.Key

                Case "editar" : Call EditarPercurso()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: DESCARREGAMENTO :::"

    Private Sub cboUFDescarregamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUFDescarregamento.SelectedIndexChanged
        Try
            cboUFDescarregamentoInformacoes.Text = cboUFDescarregamento.Text
            cboUFDescarregamentoDocumentos.Text = cboUFDescarregamento.Text

            If (cboUFDescarregamento.SelectedValue = "") Then
                cboUFDescarregamentoDocumentos.SelectedValue = ""
                cboUFDescarregamentoDocumentos.Enabled = False
                cboUFDescarregamentoInformacoes.SelectedValue = ""
                cboUFDescarregamentoInformacoes.Enabled = False
                cboMunicipioDescarregamentoDocumentos.Enabled = False
                lblMensagemDocumentos.Visible = True
                lblMensagemDescarregamento.Visible = True
            Else
                cboUFDescarregamentoDocumentos.SelectedItem = cboUFDescarregamento.SelectedItem
                cboUFDescarregamentoInformacoes.SelectedItem = cboUFDescarregamento.SelectedItem
                cboMunicipioDescarregamentoInformacoes.Enabled = True
                lblMensagemDescarregamento.Visible = False
                Call LoadCombo(cboMunicipioDescarregamentoInformacoes, "sp_select_combo_static_municipio " & cboUFDescarregamento.SelectedValue)

            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: RODOVIÁRIO :::"

#Region "::: VEÍCULO DE TRAÇÃO :::"

    Private Sub btnCadastrarRenavam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarRenavam.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadVeiculoMDFe"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo 
            Call LoadCombo(cboRenavamVeiculo, "sp_select_combo_cadastro_basico_renavam_veiculo_mdfe " & goUsuario.iEmpresa)

            'Seta Focu
            cboRenavamVeiculo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboRenavamVeiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRenavamVeiculo.SelectedIndexChanged

        Try

            oClsFatEmissaoMDFe.LoadDadosRenavam(cboRenavamVeiculo.SelectedValue, _
                                                txtPlacaVeiculo, _
                                                cboUFVeiculo, _
                                                txtRntrcVeiculo, _
                                                cboTipoCarroceriaVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNomeCondutorVeiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNomeCondutorVeiculo.SelectedIndexChanged

        Try

            oClsFatEmissaoMDFe.LoadDadosCondutor(cboNomeCondutorVeiculo.SelectedValue, _
                                                 txtCPFCondutorVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkProprietarioVeiculo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProprietarioVeiculo.CheckedChanged
        Try

            txtRntrcProprietarioVeiculo.Enabled = False
            cboTipoProprietarioVeiculo.Enabled = False
            cboUFProprietarioVeiculo.Enabled = False
            txtCNPJCPFProprietarioVeiculo.Enabled = False
            txtNomeProprietarioVeiculo.Enabled = False
            txtIEProprietarioVeiculo.Enabled = False

            If chkProprietarioVeiculo.Checked = True Then
                txtRntrcProprietarioVeiculo.Enabled = True
                cboTipoProprietarioVeiculo.Enabled = True
                cboUFProprietarioVeiculo.Enabled = True
                txtCNPJCPFProprietarioVeiculo.Enabled = True
                txtNomeProprietarioVeiculo.Enabled = True
                txtIEProprietarioVeiculo.Enabled = True
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnSalvarCondutorVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarCondutorVeiculo.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoCondutor() = True Then

                'Salva Dados do Registro
                Call SalvarCondutor()

                'Limpa Formulário
                Call NovoCondutor()

                'carrega grid 
                Call oClsFatEmissaoMDFe.LoadGridCondutor(grdCondutorVeiculo)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirCondutorVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCondutorVeiculo.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Condutor
            Call ExcluirCondutor()

            'Preapara Formulário para Inserção de um Novo Condutor
            Call NovoCondutor()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridCondutor(grdCondutorVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridCondutorVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridCondutorVeiculo.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCondutorVeiculo
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCondutorVeiculo, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridCondutorVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCondutorVeiculo.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdCondutorVeiculo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCondutorVeiculo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCondutorVeiculo.GroupByBoxVisible = True
                grdCondutorVeiculo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridCondutorVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCondutorVeiculo.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCondutorVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdCondutorVeiculo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCondutorVeiculo.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdCondutorVeiculo.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdCondutorVeiculo.CurrentColumn.Key

                Case "editar" : Call EditarCondutorVeiculo()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


#End Region

#Region "::: VEÍCULO DE REBOQUE :::"

    Private Sub chkProprietarioReboque_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProprietarioReboque.CheckedChanged
        Try

            txtRntrcProprietarioReboque.Enabled = False
            cboTipoProprietarioReboque.Enabled = False
            cboUFProprietarioReboque.Enabled = False
            txtCPFCNPJProprietarioReboque.Enabled = False
            txtNomeProprietarioReboque.Enabled = False
            txtIEProprietarioReboque.Enabled = False

            If chkProprietarioReboque.Checked = True Then
                txtRntrcProprietarioReboque.Enabled = True
                cboTipoProprietarioReboque.Enabled = True
                cboUFProprietarioReboque.Enabled = True
                txtCPFCNPJProprietarioReboque.Enabled = True
                txtNomeProprietarioReboque.Enabled = True
                txtIEProprietarioReboque.Enabled = True
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnSalvarReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarReboque.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoReboque() = True Then

                'Salva Dados do Registro
                Call SalvarReboque()

                'Limpa Formulário
                Call NovoReboque()

                'carrega a grid 
                Call oClsFatEmissaoMDFe.LoadGridReboque(grdInformacoesVeiculoReboque)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirReboque.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Reboque
            Call ExcluirReboque()

            'Preapara Formulário para Inserção de um Novo Reboque
            Call NovoReboque()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridReboque(grdInformacoesVeiculoReboque)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridVeiculoReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridVeiculoReboque.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdInformacoesVeiculoReboque
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdInformacoesVeiculoReboque, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridVeiculoReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridVeiculoReboque.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdInformacoesVeiculoReboque.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdInformacoesVeiculoReboque.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdInformacoesVeiculoReboque.GroupByBoxVisible = True
                grdInformacoesVeiculoReboque.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridVeiculoReboque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridVeiculoReboque.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdInformacoesVeiculoReboque)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdInformacoesVeiculoReboque_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdInformacoesVeiculoReboque.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdInformacoesVeiculoReboque.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdInformacoesVeiculoReboque.CurrentColumn.Key

                Case "editar" : Call EditarReboque()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: VALE PEDÁGIO :::"

    Private Sub btnSalvarValePedagio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarValePedagio.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoValePedagio() = True Then

                'Salva Dados do Registro
                Call SalvarValePedagio()

                'Limpa Formulário
                Call NovoValePedagio()

                'carrega grid 
                Call oClsFatEmissaoMDFe.LoadGridValePedagio(grdValePedagio)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirValePedagio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirValePedagio.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Vale Pedagio
            Call ExcluirValePedagio()

            'Preapara Formulário para Inserção de um Novo Vale Pedagio
            Call NovoValePedagio()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridValePedagio(grdValePedagio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGridValePedagio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridValePedagio.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdValePedagio
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdValePedagio, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgrupaGridValePedagio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrupaGridValePedagio.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdValePedagio.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdValePedagio.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdValePedagio.GroupByBoxVisible = True
                grdValePedagio.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridValePedagio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridValePedagio.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdValePedagio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdValePedagio_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdValePedagio.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdValePedagio.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdValePedagio.CurrentColumn.Key

                Case "editar" : Call EditarValePedagio()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: AQUAVIÁRIO :::"

#Region "::: CARREGAMENTO :::"

    Private Sub btnSalvarCarregamentoAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarCarregamentoAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoCarregamentoAquaviario() = True Then

                'Salva Dados do Registro
                Call SalvarCarregamentoAquaviario()

                'Limpa Formulário
                Call NovoCarregamentoAquaviario()

                'carrega a grid
                Call oClsFatEmissaoMDFe.LoadGridTerminalCarregamento(grdTerminalCarregamentoAquaviario)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirCarregamentoAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCarregamentoAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Carregamento aquaviario
            Call ExcluirCarregamentoAquaviario()

            'Preapara Formulário para Inserção de um Novo Carregamento aquaviario
            Call NovoCarregamentoAquaviario()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridTerminalCarregamento(grdTerminalCarregamentoAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigiraGridTerminalCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigiraGridTerminalCarregamento.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdTerminalCarregamentoAquaviario
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdTerminalCarregamentoAquaviario, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgrupaGridTerminalCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrupaGridTerminalCarregamento.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdTerminalCarregamentoAquaviario.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdTerminalCarregamentoAquaviario.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdTerminalCarregamentoAquaviario.GroupByBoxVisible = True
                grdTerminalCarregamentoAquaviario.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridTerminalCarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridTerminalCarregamento.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdTerminalCarregamentoAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdTerminalCarregamentoAquaviario_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdTerminalCarregamentoAquaviario.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdTerminalCarregamentoAquaviario.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdTerminalCarregamentoAquaviario.CurrentColumn.Key

                Case "editar" : Call EditarCarregamentoAquaviario()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: DESCARREGAMENTO :::"

    Private Sub btnSalvarDescarregamentoAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarDescarregamentoAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoDescarregamentoAquaviario() = True Then

                'Salva Dados do Registro
                Call SalvarDescarregamentoAquaviario()

                'Limpa Formulário
                Call NovoDescarregamentoAquaviario()

                'carrega grid
                Call oClsFatEmissaoMDFe.LoadGridTerminalDescarregamento(grdTerminalDescarregamentoAquaviario)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirDescarregamentoAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDescarregamentoAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Descarregamento Aquaviario
            Call ExcluirDescarregamentoAquaviario()

            'Preapara Formulário para Inserção de um Novo Descarregamento Aquaviario
            Call NovoDescarregamentoAquaviario()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridTerminalDescarregamento(grdTerminalDescarregamentoAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGridDescarregamentoAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDescarregamentoAquaviario.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdTerminalDescarregamentoAquaviario
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdTerminalDescarregamentoAquaviario, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridDescarregamentoAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridDescarregamentoAquaviario.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdTerminalDescarregamentoAquaviario.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdTerminalDescarregamentoAquaviario.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdTerminalDescarregamentoAquaviario.GroupByBoxVisible = True
                grdTerminalDescarregamentoAquaviario.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdTerminalDescarregamentoAquaviario_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdTerminalDescarregamentoAquaviario.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdTerminalDescarregamentoAquaviario.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdTerminalDescarregamentoAquaviario.CurrentColumn.Key

                Case "editar" : Call EditarDescarregamentoAquaviario()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridDescarregamentoAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDescarregamentoAquaviario.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdTerminalDescarregamentoAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: COMBOIO :::"

    Private Sub btnSalvarComboioAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarComboioAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoComboioAquaviario() = True Then

                'Salva Dados do Registro
                Call SalvarComboioAquaviario()

                'Limpa Formulário
                Call NovoComboioAquaviario()

                'carrega grid
                Call oClsFatEmissaoMDFe.LoadGridComboio(grdInformacaoComboioAquaviario)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirComboioAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirComboioAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Comboio Aquaviario
            Call ExcluirComboioAquaviario()

            'Preapara Formulário para Inserção de um Novo Comboio Aquaviario
            Call NovoComboioAquaviario()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridComboio(grdInformacaoComboioAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridComboioAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridComboioAquaviario.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdInformacaoComboioAquaviario
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdInformacaoComboioAquaviario, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridComboioAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridComboioAquaviario.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdInformacaoComboioAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgrupaGridComboioAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrupaGridComboioAquaviario.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdInformacaoComboioAquaviario.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdInformacaoComboioAquaviario.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdInformacaoComboioAquaviario.GroupByBoxVisible = True
                grdInformacaoComboioAquaviario.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdInformacaoComboioAquaviario_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdInformacaoComboioAquaviario.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdInformacaoComboioAquaviario.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdInformacaoComboioAquaviario.CurrentColumn.Key

                Case "editar" : Call EditarComboioAquaviario()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: UNIDADE AQUAVIÁRIO :::"

    Private Sub btnSalvarUnidadeAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarUnidadeAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoUnidadeCargaAquaviario() = True Then

                'Salva Dados do Registro
                Call SalvarUnidadeCargaAquaviario()

                'Limpa Formulário
                Call NovaUnidadeCargaAquaviario()

                'carrega grid 
                Call oClsFatEmissaoMDFe.LoadGridCargaVazia(grdInformacaoUnidadeCargaAquaviario)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirUnidadeAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirUnidadeAquaviario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Carga Aquaviario
            Call ExcluirUnidadeCargaAquaviario()

            'Preapara Formulário para Inserção de um Nova Carga Aquaviario
            Call NovaUnidadeCargaAquaviario()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridCargaVazia(grdInformacaoUnidadeCargaAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridUnidadeAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridUnidadeAquaviario.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdInformacaoUnidadeCargaAquaviario
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdInformacaoUnidadeCargaAquaviario, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridUnidadeAquaviario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridUnidadeAquaviario.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdInformacaoUnidadeCargaAquaviario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdInformacaoUnidadeCargaAquaviario_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdInformacaoUnidadeCargaAquaviario.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdInformacaoUnidadeCargaAquaviario.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdInformacaoUnidadeCargaAquaviario.CurrentColumn.Key

                Case "editar" : Call EditarUnidadeCargaAquaviario()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: INFORMAÇÕES DOS DOCUMENTOS :::"

#Region "::: MUNICÍPIOS DE DESCARREGAMENTO :::"

    Private Sub btnSalvarDocumentoDescarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarDocumentoDescarregamento.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoMunicipioDescarregamento() = True Then

                'Salva Dados do Registro
                Call SalvarMunicipioDescarregamento()

                cboUFDescarregamentoDocumentos.Enabled = True
                cboMunicipioDescarregamentoDocumentos.Enabled = True

                cboUFDescarregamentoDocumentos.Text = cboUFDescarregamentoInformacoes.Text

                sMunicipio &= IIf(sMunicipio = "", "", ",") & cboMunicipioDescarregamentoInformacoes.Text.ToString

                Call LoadCombo(cboMunicipioDescarregamentoDocumentos, "sp_select_static_municipio_mdfe " & cboUFDescarregamentoInformacoes.SelectedValue & ", " & "'" & sMunicipio & "'")

                'Limpa Formulário
                Call NovoMunicipioDescarregamento()

                'carrega grid
                Call oClsFatEmissaoMDFe.LoadGridMunicipioDescarregamento(grdMunicipioDescarregamento)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirDocumentoDescarregamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDocumentoDescarregamento.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Municipio Descarregamento
            Call ExcluirMunicipioDescarregamento()

            'Preapara Formulário para Inserção de um Novo Municipio Descarregamento
            Call NovoMunicipioDescarregamento()

            If (grdMunicipioDescarregamento.RowCount > 0) Then
                cboMunicipioDescarregamentoDocumentos.Enabled = True
                sMunicipio = IIf(sMunicipio = "", "", ",") & grdMunicipioDescarregamento.CurrentRow.Cells.Item("municipio").Value.ToString
                Call LoadCombo(cboMunicipioDescarregamentoDocumentos, "sp_select_static_municipio_mdfe " & cboUFDescarregamentoInformacoes.SelectedValue & ", " & "'" & sMunicipio & "'")
            Else
                cboMunicipioDescarregamentoDocumentos.SelectedIndex = -1
                cboMunicipioDescarregamentoDocumentos.Enabled = False
                sMunicipio = ""
            End If

          

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridMunicipioDescarregamento(grdMunicipioDescarregamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGridInformacoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridInformacoes.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdMunicipioDescarregamento
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMunicipioDescarregamento, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridInformacoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridInformacoes.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdMunicipioDescarregamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdMunicipioDescarregamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdMunicipioDescarregamento.GroupByBoxVisible = True
                grdMunicipioDescarregamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridInformacoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridInformacoes.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdMunicipioDescarregamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMunicipioDescarregamento_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMunicipioDescarregamento.RowCountChanged
        Try
            If grdMunicipioDescarregamento.RowCount > 0 Then

                cboMunicipioDescarregamentoDocumentos.Enabled = True
                lblMensagemDocumentos.Visible = False
                cboUFDescarregamentoDocumentos.Enabled = True
                cboUFDescarregamentoDocumentos.Text = cboUFDescarregamento.Text

            Else

                cboMunicipioDescarregamentoDocumentos.Enabled = False
                lblMensagemDocumentos.Visible = True
                cboUFDescarregamentoDocumentos.Enabled = False
                cboUFDescarregamentoDocumentos.Text = ""
                cboMunicipioDescarregamentoDocumentos.SelectedIndex = -1
            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdMunicipioDescarregamento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdMunicipioDescarregamento.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdMunicipioDescarregamento.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdMunicipioDescarregamento.CurrentColumn.Key

                Case "editar" : Call EditarMunicipioDescarregamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: NOTA FISCAL ELETRÔNICA :::"

    Private Sub btnExcluirNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirNotaFiscal.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Nota Fiscal
            Call ExcluirNotaFiscal()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGridNotaFiscal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridNotaFiscal.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDocumentosNotaFiscal

            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDocumentosNotaFiscal, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridNotaFiscal.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDocumentosNotaFiscal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridNotaFiscal.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdDocumentosNotaFiscal.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdDocumentosNotaFiscal.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdDocumentosNotaFiscal.GroupByBoxVisible = True
                grdDocumentosNotaFiscal.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDocumentosNotaFiscal_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDocumentosNotaFiscal.RowCountChanged
        Try

            txtTotalNFe.Value = grdDocumentosNotaFiscal.RowCount

        Catch ex As Exception
            ''Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDocumentosNotaFiscal_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDocumentosNotaFiscal.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdDocumentosNotaFiscal.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdDocumentosNotaFiscal.CurrentColumn.Key

                Case "editar" : Call EditarDocumentosNotaFiscal()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirNotaFiscal.Click
        Try

            If ValidacaoNotaFiscal() = True Then
                'Váriaveis Locais
                Dim oForm As New frmFatEmissaoMDFeDocumentos

                oForm.CodigoEmissaoCapa = oClsFatEmissaoMDFe.CodigoEmissaoCapa
                oForm.Tipo = 1
                oForm.UF = cboUFDescarregamentoDocumentos.SelectedValue
                oForm.CodigoMunicipio = cboMunicipioDescarregamentoDocumentos.SelectedValue

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid de Nota Fiscal
                oClsFatEmissaoMDFe.LoadGridNotaFiscal(grdDocumentosNotaFiscal)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: MDFe REFERENCIADO :::"

    Private Sub btnExcluirReferenciado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirReferenciado.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Referenciado
            Call ExcluirReferenciado()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGridDocumentoRefenciado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDocumentoRefenciado.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDocumentosReferenciado
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDocumentosReferenciado, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridDocumentoRefenciado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridDocumentoRefenciado.Click
        Try
            'Verifica se o Grupo está Habilita
            If grdDocumentosReferenciado.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdDocumentosReferenciado.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdDocumentosReferenciado.GroupByBoxVisible = True
                grdDocumentosReferenciado.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridDocumentoRefenciado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDocumentoRefenciado.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDocumentosReferenciado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDocumentosReferenciado_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDocumentosReferenciado.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdDocumentosReferenciado.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdDocumentosReferenciado.CurrentColumn.Key

                Case "editar" : Call EditarDocumentosReferenciado()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirReferenciado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirReferenciado.Click
        Try
            If ValidacaoReferenciado() = True Then

                'Váriaveis Locais
                Dim oForm As New frmFatEmissaoMDFeDocumentos

                oForm.CodigoEmissaoCapa = oClsFatEmissaoMDFe.CodigoEmissaoCapa
                oForm.Tipo = 2
                oForm.UF = cboUFDescarregamentoDocumentos.Text
                oForm.CodigoMunicipio = cboMunicipioDescarregamentoDocumentos.SelectedValue

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid de Referenciado
                oClsFatEmissaoMDFe.LoadGridReferenciado(grdDocumentosReferenciado)

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

#Region "::: TOTAIS :::"

    Private Sub btnSalvarLacreTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarLacreTotal.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoLacreTotal() = True Then

                'Salva Dados do Registro
                Call SalvarLacreTotal()

                'Limpa Formulário
                Call NovoLacreTotal()

                'carrega grid 
                Call oClsFatEmissaoMDFe.LoadGridLacre(grdLacreTotal)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirLacreTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirLacreTotal.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Lacre Total
            Call ExcluirLacreTotal()

            'Preapara Formulário para Inserção de um Novo Lacre Total
            Call NovoLacreTotal()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridLacre(grdLacreTotal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvarAutorizadoTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarAutorizadoTotal.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoAutorizadoTotal() = True Then

                'Salva Dados do Registro
                Call SalvarAutorizadoTotal()

                'Limpa Formulário
                Call NovoAutorizadoTotal()

                'carrega grid
                Call oClsFatEmissaoMDFe.LoadGridAutorizado(grdAutorizadoTotal)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirAutorizadoTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAutorizadoTotal.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Autorizado Total
            Call ExcluirAutorizadoTotal()

            'Preapara Formulário para Inserção de um Novo Autorizado Total
            Call NovoAutorizadoTotal()

            'carrega a grid
            Call oClsFatEmissaoMDFe.LoadGridAutorizado(grdAutorizadoTotal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridAutorizadoTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridAutorizadoTotal.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdAutorizadoTotal
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdAutorizadoTotal, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgrupaGridAutorizadoTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrupaGridAutorizadoTotal.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdAutorizadoTotal.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdAutorizadoTotal.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdAutorizadoTotal.GroupByBoxVisible = True
                grdAutorizadoTotal.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridAutorizadoTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridAutorizadoTotal.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdAutorizadoTotal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdAutorizadoTotal_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAutorizadoTotal.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdAutorizadoTotal.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdAutorizadoTotal.CurrentColumn.Key

                Case "editar" : Call EditarAutorizadoTotal()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelGridLacre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridLacre.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdLacreTotal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAgrupaGridLacre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrupaGridLacre.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdLacreTotal.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdLacreTotal.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdLacreTotal.GroupByBoxVisible = True
                grdLacreTotal.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnConfiguraGridLacre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridLacre.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdLacreTotal
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoMDFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdLacreTotal, Formulario.FaturamentoEmissaoMDFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdLacreTotal_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdLacreTotal.RowDoubleClick
        Try

            'Verifica se foi Selecionado Algum Registro
            If IsNothing(grdLacreTotal.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdLacreTotal.CurrentColumn.Key

                Case "editar" : Call EditarLacreTotal()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: INFORMAÇÕES ADICIONAIS :::"

    Private Sub btnCadastrarInformacoesAdicionais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarInformacoesAdicionais.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadAutotexto"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais))

            'Seta Focu
            cboDadosAdicionaisPreCadastrado.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarDadosAdicionais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarDadosAdicionais.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindAutotexto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Autotexto"

            iTipoAutoTextoFind = TipoAutotexto.DadosAdicionais
            oComboBoxFind = cboDadosAdicionaisPreCadastrado
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboDadosAdicionaisPreCadastrado.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: MANIFESTO ELETRÔNICO DE DOCUMENTOS FISCAIS :::"

    Private Sub btnTransmitirMDFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitirMDFe.Click
        Try

            'Valida Dados da Nota Fiscal Eletrônica
            If Validacao() = True Then

                'Salva a MDFe
                Call Salvar()

                'Transmite NFe
                Call TransmitirLote()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnRetornarMDFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornarMDFe.Click
        Try

            'Salva a MDFe
            Call Salvar()

            'Retorno do Lote
            Call RetornarLote()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImprimirDAMFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDAMFE.Click
        Try

            'Salva a MDFe
            Call Salvar()

            'Imprime DANFE
            Call ImprimirDamfe(oClsFatEmissaoMDFe.CodigoEmissaoCapa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExportarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarXML.Click
        Try


            'Exporta Arquivo XML
            Call ExportarXML(oClsFatEmissaoMDFe.CodigoEmissaoCapa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnPreVisualizarDAMFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreVisualizarDAMFE.Click
        Try

            'Salva a MDFe
            Call Salvar()

            'Pré Visualizar DANFE
            Call ImprimirDamfe(oClsFatEmissaoMDFe.CodigoEmissaoCapa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click
        Try

            'Salva a MDFe
            Call Salvar()

            'Envia E-mail
            Call EmailMDFe(oClsFatEmissaoMDFe.CodigoEmissaoCapa, _
                          IIf(IsNumeric(txtStatusMDFe.Tag), txtStatusMDFe.Tag, -1))

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEmissaoMDFe_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)

            btnCadastrarInformacoesAdicionais.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)

            btnExcluirAutorizadoTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirCarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirCarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirComboioAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirCondutorVeiculo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirDescarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirDocumentoDescarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirLacreTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirPercurso.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirReferenciado.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirUnidadeAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
            btnExcluirValePedagio.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)

            btnImprimir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcPrint)

            btnSalvarAutorizadoTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarCarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarCarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarComboioAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarCondutorVeiculo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarDescarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarDocumentoDescarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarLacreTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnInserirNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarPercurso.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnInserirReferenciado.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarUnidadeAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
            btnSalvarValePedagio.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboTipoEmitente, "sp_select_combo_static_tipo_emitente_mdfe")
            Call LoadCombo(cboModalidade, "sp_select_combo_static_modalidade_mdfe")
            Call LoadCombo(cboModalidadeFiltro, "sp_select_combo_static_modalidade_mdfe")
            Call LoadCombo(cboFormaEmissao, "sp_select_combo_static_forma_emissao_mdfe")
            Call LoadCombo(cboTipoEmissaoFiltro, "sp_select_combo_static_forma_emissao_mdfe")
            Call LoadCombo(cboUFCapa, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFDescarregamento, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFDescarregamentoInformacoes, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFDescarregamentoDocumentos, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFDestinatario, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFLicenciamentoReboque, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFNFReferenciada, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFPercurso, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFProprietarioReboque, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFProprietarioVeiculo, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFVeiculo, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFDescarregamentoFiltro, "sp_select_combo_static_estado")
            Call LoadCombo(cboTipoCarroceriaVeiculo, "sp_select_combo_static_tipo_carroceria_mdfe")
            Call LoadCombo(cboTipoCarroceriaVeiculoReboque, "sp_select_combo_static_tipo_carroceria_mdfe")
            Call LoadCombo(cboTipoRodadoVeiculo, "sp_select_combo_static_tipo_rodado_mdfe")
            Call LoadCombo(cboTipoRodadoReboque, "sp_select_combo_static_tipo_rodado_mdfe")
            Call LoadCombo(cboTipoProprietarioVeiculo, "sp_select_combo_static_tipo_proprietario_mdfe")
            Call LoadCombo(cboTipoProprietarioReboque, "sp_select_combo_static_tipo_proprietario_mdfe")
            Call LoadCombo(cboUnidadeCargaAquaviario, "sp_select_combo_static_tipo_unidade_carga_mdfe")
            Call LoadCombo(cboUnidadeMedidaTotal, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            Call LoadCombo(cboDadosAdicionaisPreCadastrado, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & CInt(TipoAutotexto.DadosAdicionais))
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_mdfe")
            Call LoadCombo(cboModelo, "sp_select_combo_static_modelo_manifesto " & CInt(TipoItem.produto))
            Call LoadCombo(cboRenavamVeiculo, "sp_select_combo_cadastro_basico_renavam_veiculo_mdfe " & goUsuario.iEmpresa)
            Call LoadCombo(cboNomeCondutorVeiculo, "sp_select_combo_cadastro_basico_parceiro_negocio_condutor_mdfe " & goUsuario.iEmpresa)

            'cboUnidadeMedidaTotal.SelectedValue = 1
            'cboModalidade.SelectedValue = 1
            'cboUFCapa.SelectedValue = "SP"
            'pagAquaviario.Enabled = False
            'pagRodoviario.Enabled = True
             
            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Configuração da MDFe
            Call LoadConfiguracaoMDFe()

            'Seta Ambiente - MDFe
            Select Case goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe
                Case TipoAmbienteMDFe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                Case TipoAmbienteMDFe.producao : lblAmbiente.Text = "** Ambiente de Produção"
            End Select

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoEstadualSTEmitente.Text = goEmitente.sInscricaoEstadualST
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
            'Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdAutorizadoTotal, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdDocumentosNotaFiscal, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdCondutorVeiculo, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdDocumentosReferenciado, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdInformacaoComboioAquaviario, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdInformacaoUnidadeCargaAquaviario, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdInformacoesVeiculoReboque, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdLacreTotal, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdMunicipioCarregamento, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdMunicipioDescarregamento, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdPercurso, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdTerminalCarregamentoAquaviario, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdTerminalDescarregamentoAquaviario, Formulario.FaturamentoEmissaoMDFe)
            Call ConfiguraGrid(grdValePedagio, Formulario.FaturamentoEmissaoMDFe)
            cboModelo.SelectedValue = CInt(ModeloManifesto.Modelo58)

            If lCodigoEmissaoCapa = 0 Then
                'Remove Aba
                tabMain.TabPages.Remove(pagDados)
                'Seta Focu
                txtNumeroDocumentoFiltro.Focus()
            Else
                Call EditarManifesto(lCodigoEmissaoCapa)
            End If

            If grdMunicipioDescarregamento.RowCount = 0 Then
                cboUFDescarregamentoDocumentos.Enabled = False
                cboMunicipioDescarregamentoDocumentos.Enabled = False
            End If

            'Seta Controles 
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataSaidaInicio.Value = Now.Date : dtpDataSaidaInicio.Checked = False
            dtpDataSaidaFinal.Value = Now.Date : dtpDataSaidaFinal.Checked = False


            cboSerie.Text = "2"
            txtNumeroDocumento.Text = oClsFatEmissaoMDFe.GeraNumeroManifestoEletronico(cboSerie.SelectedValue) 
            txtNumeroDocumento.Text = oClsFatEmissaoMDFe.NumeroMDFe

            cboModelo.Text = "58"
            lblMensagemDescarregamento.Visible = True
            chkProprietarioReboque.CheckedValue = False
            chkProprietarioVeiculo.CheckedValue = False
            btnSalvar.Tag = ""

            pagRodoviario.Enabled = False
            pagAquaviario.Enabled = False
             
            If grdMunicipioDescarregamento.RowCount > 0 Then

                cboMunicipioDescarregamentoDocumentos.Enabled = True
                lblMensagemDocumentos.Visible = False
                cboUFDescarregamentoDocumentos.Enabled = True
                cboUFDescarregamentoDocumentos.Text = cboUFDescarregamento.Text

            Else

                cboMunicipioDescarregamentoDocumentos.Enabled = False
                lblMensagemDocumentos.Visible = True
                cboUFDescarregamentoDocumentos.Enabled = False
                cboUFDescarregamentoDocumentos.Text = ""

            End If

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MANIFESTO ELETRÔNICO :::"

    Private Sub ImportarNFe()
        Try

            Dim oForm As New frmFatEmissaoMDFeImportarNFe
            oForm.CodigoEmissaoCapa = oClsFatEmissaoMDFe.CodigoEmissaoCapa

            oForm.ShowDialog()

            'Verifica se foi inserido
            If oForm.Inserido = True Then

                'Alterna Aba
                tabMain.TabPages.Remove(pagDados)
                tabMain.TabPages.Add(pagLista)

                Call EditarManifesto(oClsFatEmissaoMDFe.CodigoEmissaoCapa)

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sStatus As String = ""
            Dim i As Integer

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            oClsFatEmissaoMDFe.LoadGrid(grdListagem, _
                                       IIf(IsNumeric(txtNumeroDocumentoFiltro.Text.Trim), txtNumeroDocumentoFiltro.Text.Trim, -1), _
                                        IIf(IsNumeric(txtSerieFiltro.Text.Trim), txtSerieFiltro.Text.Trim, ""), _
                                        IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                        IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                        IIf(dtpDataSaidaInicio.Checked = False, "", dtpDataSaidaInicio.Value), _
                                        IIf(dtpDataSaidaFinal.Checked = False, "", dtpDataSaidaFinal.Value), _
                                        IIf(cboModalidadeFiltro.SelectedIndex = -1, -1, cboModalidadeFiltro.SelectedValue), _
                                        IIf(cboTipoEmissaoFiltro.SelectedIndex = -1, -1, cboTipoEmissaoFiltro.SelectedValue), _
                                        IIf(cboUFDescarregamentoFiltro.SelectedIndex = -1, "", cboUFDescarregamentoFiltro.SelectedValue), _
                                        sStatus)

            'Seta Cursor
            If grdListagem.GetDataRows.Count > 0 Then grdListagem.Row = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo() Handles Me.Disposed

        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Seta Cursor do Mouse 
            Cursor.Current = Cursors.WaitCursor

            'Oculta tabDados
            tabDados.Visible = False

            btnSalvar.Tag = ""

            '       iEditado = 0

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoEstadualSTEmitente.Text = goEmitente.sInscricaoEstadualST
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

            'Insere Capa
            oClsFatEmissaoMDFe.InsertManifesto()

            'Limpa Controles - Dados da NFe
            cboModelo.SelectedValue = CInt(ModeloManifesto.Modelo58)
            cboSerie.Tag = oClsFatEmissaoMDFe.CodigoEmissaoCapa
            txtNumeroDocumento.Text = ""
            dtpDataEmissao.Value = Now
            dtpDataSaida.Value = Now
            cboModalidade.SelectedIndex = -1
            cboUFCapa.SelectedIndex = -1
            cboTipoEmitente.SelectedIndex = -1
            cboUFDescarregamento.SelectedIndex = -1
            dtpDataSaida.Value = Now : dtpDataSaida.Checked = False
            cboFormaEmissao.SelectedValue = CInt(FormaEmissaoNFe.Normal)
            cboUFCarregamento.Enabled = True
            Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")


            'Limpa Controles - Rodoviario
            txtRntrcVeiculo.Text = ""
            txtCiotVeiculo.Text = ""
            txtCodigoAgendamentoPortoVeiculo.Text = ""
            txtCodigoInternoVeiculo.Text = ""
            cboTipoCarroceriaVeiculo.SelectedIndex = -1
            txtPlacaVeiculo.Text = ""
            txtTaraVeiculo.Text = ""
            cboRenavamVeiculo.SelectedIndex = -1
            cboUFVeiculo.SelectedIndex = -1
            cboTipoRodadoVeiculo.SelectedIndex = -1
            txtCapacidadeKGVeiculo.Text = ""
            txtCapacidadeM3Veiculo.Text = ""
            chkProprietarioVeiculo.Checked = False
            txtRntrcProprietarioVeiculo.Enabled = False
            txtRntrcProprietarioVeiculo.Text = ""
            cboTipoProprietarioVeiculo.Enabled = False
            cboTipoProprietarioVeiculo.SelectedIndex = -1
            cboUFProprietarioVeiculo.Enabled = False
            cboUFProprietarioVeiculo.SelectedIndex = -1
            txtCNPJCPFProprietarioVeiculo.Text = ""
            txtCNPJCPFProprietarioVeiculo.Enabled = False
            txtNomeProprietarioVeiculo.Text = ""
            txtNomeProprietarioVeiculo.Enabled = False
            txtIEProprietarioVeiculo.Text = ""
            txtIEProprietarioVeiculo.Enabled = False

            'limpa controles - aquaviario
            txtAgenciaAquaviario.Text = ""
            txtTipoEmbarcacaoAquaviario.Text = ""
            txtCodigoEmbarcacaoAquaviario.Text = ""
            txtNumeroViagemAquaviario.Text = ""
            txtNomeEmbarcacaoAquaviario.Text = ""
            txtPortoEmbarqueAquaviario.Text = ""
            txtPortoDestinoAquaviario.Text = ""

            'limpa controles - totais
            txtTotalCargaTransportada.Value = 0
            txtTotalCTe.Value = 0
            txtTotalNFe.Value = 0
            txtTotalNFMod.Value = 0
            txtPesoBrutoTotal.Value = 0
            cboUnidadeMedidaTotal.SelectedIndex = -1

            ' limpa controles - informacoes adicionais 
            cboDadosAdicionaisPreCadastrado.SelectedIndex = -1
            txtDadosAdicionais.Text = ""
            txtDadosAdicionaisFISCO.Text = ""

            'Limpa Grid
            grdAutorizadoTotal.DataSource = Nothing
            grdCondutorVeiculo.DataSource = Nothing
            grdDocumentosNotaFiscal.DataSource = Nothing
            grdDocumentosReferenciado.DataSource = Nothing
            grdInformacaoComboioAquaviario.DataSource = Nothing
            grdInformacaoUnidadeCargaAquaviario.DataSource = Nothing
            grdInformacoesVeiculoReboque.DataSource = Nothing
            grdLacreTotal.DataSource = Nothing
            grdMunicipioCarregamento.DataSource = Nothing
            grdMunicipioDescarregamento.DataSource = Nothing
            grdNFReferenciada.DataSource = Nothing
            grdPercurso.DataSource = Nothing
            grdTerminalCarregamentoAquaviario.DataSource = Nothing
            grdTerminalDescarregamentoAquaviario.DataSource = Nothing
            grdValePedagio.DataSource = Nothing

            'Limpa Controles - Informações Adicionais
            cboDadosAdicionaisPreCadastrado.SelectedIndex = -1
            txtDadosAdicionais.Text = ""
            txtDadosAdicionaisFISCO.Text = ""

            'Limpa Controles - Manifesto Eletrônico
            txtStatusMDFe.Text = ""
            txtStatusMDFe.Tag = StatusManifestoEletronico.AguardandoTransmissao
            txtMensagemSefaz.Text = ""
            txtChaveAcesso.Text = ""
            txtRecibo.Text = ""
            txtLote.Text = ""
            txtProtocolo.Text = ""

            'Seta Focu Aba  
            tabDados.SelectedTab = pagDadosMDFe
            tabMDFe.SelectedTab = pagDadosCapa

            'Seta Controles
            VerificaStatus(StatusManifestoEletronico.AguardandoTransmissao)

            'Oculta tabDados
            tabDados.Visible = True


            cboSerie.Text = "2"
            txtNumeroDocumento.Text = oClsFatEmissaoMDFe.GeraNumeracao(cboSerie.SelectedValue)


            'cboUnidadeMedidaTotal.SelectedValue = 1
            'cboModalidade.SelectedValue = 1
            'cboUFCapa.SelectedValue = "MS"

            'cboUFCarregamento.SelectedValue = "MS"
            ' cboMunicipioCarregamento.SelectedValue = 11674
            ' Call SalvarCarregamento() 
            Call NovoCarregamento()

            'carrega a grid
            'Call oClsFatEmissaoMDFe.LoadGridCarregamento(grdMunicipioCarregamento)

            'If grdMunicipioCarregamento.RowCount > 0 Then
            '    cboUFCarregamento.SelectedValue = grdMunicipioCarregamento.CurrentRow.Cells.Item("uf").Value
            '    cboUFCarregamento.Enabled = False
            'Else
            '    cboUFCarregamento.Enabled = True
            '    Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")
            'End If

            'Seta Focu
            cboSerie.Focus()

            pagAquaviario.Enabled = False
            pagRodoviario.Enabled = False
            pagAquaviario.Enabled = False
            pagRodoviario.Enabled = True

            txtNumeroDocumento.Text = oClsFatEmissaoMDFe.GeraNumeracao(cboSerie.SelectedValue)
            
            txtNumeroDocumento.Text = oClsFatEmissaoMDFe.NumeroMDFe

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo1() Handles Me.Disposed

        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Seta Cursor do Mouse 
            Cursor.Current = Cursors.WaitCursor

            'Oculta tabDados
            tabDados.Visible = False

            btnSalvar.Tag = ""

            ' iEditado = 0

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Dados do Emitente
            lblValorCNPJEmitente.Text = goEmitente.sCNPJ
            lblValorInscricaoEstadualEmitente.Text = goEmitente.sInscricaoEstadual
            lblValorInscricaoEstadualSTEmitente.Text = goEmitente.sInscricaoEstadualST
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

            'Insere Capa
            oClsFatEmissaoMDFe.InsertManifesto()


            'Limpa Controles - Dados da NFe
            cboModelo.SelectedValue = CInt(ModeloManifesto.Modelo58)
            cboSerie.Tag = oClsFatEmissaoMDFe.CodigoEmissaoCapa
            txtNumeroDocumento.Text = ""
            dtpDataEmissao.Value = Now
            dtpDataSaida.Value = Now
            cboModalidade.SelectedIndex = -1
            cboUFCapa.SelectedIndex = -1
            cboTipoEmitente.SelectedIndex = -1
            cboUFDescarregamento.SelectedIndex = -1
            dtpDataSaida.Value = Now : dtpDataSaida.Checked = False
            cboFormaEmissao.SelectedValue = CInt(FormaEmissaoNFe.Normal)
            cboUFCarregamento.Enabled = True
            Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")


            'Limpa Controles - Rodoviario
            txtRntrcVeiculo.Text = ""
            txtCiotVeiculo.Text = ""
            txtCodigoAgendamentoPortoVeiculo.Text = ""
            txtCodigoInternoVeiculo.Text = ""
            cboTipoCarroceriaVeiculo.SelectedIndex = -1
            txtPlacaVeiculo.Text = ""
            txtTaraVeiculo.Text = ""
            cboRenavamVeiculo.SelectedIndex = -1
            cboUFVeiculo.SelectedIndex = -1
            cboTipoRodadoVeiculo.SelectedIndex = -1
            txtCapacidadeKGVeiculo.Text = ""
            txtCapacidadeM3Veiculo.Text = ""
            chkProprietarioVeiculo.Checked = False
            txtRntrcProprietarioVeiculo.Enabled = False
            txtRntrcProprietarioVeiculo.Text = ""
            cboTipoProprietarioVeiculo.Enabled = False
            cboTipoProprietarioVeiculo.SelectedIndex = -1
            cboUFProprietarioVeiculo.Enabled = False
            cboUFProprietarioVeiculo.SelectedIndex = -1
            txtCNPJCPFProprietarioVeiculo.Text = ""
            txtCNPJCPFProprietarioVeiculo.Enabled = False
            txtNomeProprietarioVeiculo.Text = ""
            txtNomeProprietarioVeiculo.Enabled = False
            txtIEProprietarioVeiculo.Text = ""
            txtIEProprietarioVeiculo.Enabled = False

            'limpa controles - aquaviario
            txtAgenciaAquaviario.Text = ""
            txtTipoEmbarcacaoAquaviario.Text = ""
            txtCodigoEmbarcacaoAquaviario.Text = ""
            txtNumeroViagemAquaviario.Text = ""
            txtNomeEmbarcacaoAquaviario.Text = ""
            txtPortoEmbarqueAquaviario.Text = ""
            txtPortoDestinoAquaviario.Text = ""

            'limpa controles - totais
            txtTotalCargaTransportada.Value = 0
            txtTotalCTe.Value = 0
            txtTotalNFe.Value = 0
            txtTotalNFMod.Value = 0
            txtPesoBrutoTotal.Value = 0
            cboUnidadeMedidaTotal.SelectedIndex = -1

            ' limpa controles - informacoes adicionais 
            cboDadosAdicionaisPreCadastrado.SelectedIndex = -1
            txtDadosAdicionais.Text = ""
            txtDadosAdicionaisFISCO.Text = ""

            'Limpa Grid
            grdAutorizadoTotal.DataSource = Nothing
            grdCondutorVeiculo.DataSource = Nothing
            grdDocumentosNotaFiscal.DataSource = Nothing
            grdDocumentosReferenciado.DataSource = Nothing
            grdInformacaoComboioAquaviario.DataSource = Nothing
            grdInformacaoUnidadeCargaAquaviario.DataSource = Nothing
            grdInformacoesVeiculoReboque.DataSource = Nothing
            grdLacreTotal.DataSource = Nothing
            grdMunicipioCarregamento.DataSource = Nothing
            grdMunicipioDescarregamento.DataSource = Nothing
            grdNFReferenciada.DataSource = Nothing
            grdPercurso.DataSource = Nothing
            grdTerminalCarregamentoAquaviario.DataSource = Nothing
            grdTerminalDescarregamentoAquaviario.DataSource = Nothing
            grdValePedagio.DataSource = Nothing

            'Limpa Controles - Informações Adicionais
            cboDadosAdicionaisPreCadastrado.SelectedIndex = -1
            txtDadosAdicionais.Text = ""
            txtDadosAdicionaisFISCO.Text = ""

            'Limpa Controles - Manifesto Eletrônico
            txtStatusMDFe.Text = ""
            txtStatusMDFe.Tag = StatusManifestoEletronico.AguardandoTransmissao
            txtMensagemSefaz.Text = ""
            txtChaveAcesso.Text = ""
            txtRecibo.Text = ""
            txtLote.Text = ""
            txtProtocolo.Text = ""
             
            'Seta Controles
            VerificaStatus(StatusManifestoEletronico.AguardandoTransmissao)

            'Oculta tabDados
            tabDados.Visible = True
             
            cboSerie.Text = "2"

            'Gera Número do manifesto
            txtNumeroDocumento.Text = oClsFatEmissaoMDFe.GeraNumeracao(cboSerie.SelectedValue)


            'cboUnidadeMedidaTotal.SelectedValue = 1
            'cboModalidade.SelectedValue = 1
            'cboUFCapa.SelectedValue = "MS"

            'cboUFCarregamento.SelectedValue = "MS"
            'cboMunicipioCarregamento.SelectedValue = 11674
            'Call SalvarCarregamento()
            Call NovoCarregamento()

            ''carrega a grid
            'Call oClsFatEmissaoMDFe.LoadGridCarregamento(grdMunicipioCarregamento)

            'If grdMunicipioCarregamento.RowCount > 0 Then
            '    cboUFCarregamento.SelectedValue = grdMunicipioCarregamento.CurrentRow.Cells.Item("uf").Value
            '    cboUFCarregamento.Enabled = False
            'Else
            '    cboUFCarregamento.Enabled = True
            '    Call LoadCombo(cboUFCarregamento, "sp_select_combo_static_estado")
            'End If


            'Seta Focu
            cboSerie.Focus()

            pagAquaviario.Enabled = False
            pagRodoviario.Enabled = False
            pagAquaviario.Enabled = False
            pagRodoviario.Enabled = True

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

            'Seta Ambiente 
            Select Case goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe
                Case TipoAmbienteMDFe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                Case TipoAmbienteMDFe.producao : lblAmbiente.Text = "** Ambiente de Produção"
                Case Else : lblAmbiente.Text = "** Não Configurado"
            End Select

            'Salva Dados
            Call SalvarCapa()
            Call SalvarEmitente()
            Call SalvarRodoviario()
            Call SalvarAquaviario()
            Call SalvarVeiculoTracao()
            Call SalvarTotais()
            Call SalvarInformacoesAdicionais()

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
            oClsFatEmissaoMDFe.CodigoEmissaoCapa = IIf(IsNumeric(cboSerie.Tag), cboSerie.Tag, -1)
            oClsFatEmissaoMDFe.CodigoModeloManifestoEletronico = cboModelo.SelectedValue
            oClsFatEmissaoMDFe.Serie = cboSerie.SelectedValue
            oClsFatEmissaoMDFe.DataEmissao = dtpDataEmissao.Value
            oClsFatEmissaoMDFe.DataSaida = dtpDataSaida.Value
            oClsFatEmissaoMDFe.UFCapa = cboUFCapa.SelectedValue
            oClsFatEmissaoMDFe.CodigoTipoEmitente = cboTipoEmitente.SelectedValue
            oClsFatEmissaoMDFe.CodigoModalidade = cboModalidade.SelectedValue
            oClsFatEmissaoMDFe.CodigoFormaEmissaoMDFe = cboFormaEmissao.SelectedValue
            oClsFatEmissaoMDFe.UFDescarregamento = cboUFDescarregamento.SelectedValue
            oClsFatEmissaoMDFe.NumeroMDFe = txtNumeroDocumento.Text

            'Verifica o Tipo de Operação
            oClsFatEmissaoMDFe.UpdateManifesto()



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirCapa()

        Try

            'Váriaveis Locais
            Dim sStatus(1) As String
            sStatus(0) = CInt(StatusManifestoEletronico.AguardandoTransmissao).ToString
            sStatus(1) = CInt(StatusManifestoEletronico.Rejeitada).ToString

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsFatEmissaoMDFe.DeleteManifesto()

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

    Public Sub EditarManifesto(ByVal lCodigoEmissaoCapa As Long)

        Try

            ' iEditado = 1

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcUpdate) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                ''Limpa Formulário
                'Call Novo()

                'Seta Código
                oClsFatEmissaoMDFe.CodigoEmissaoCapa = lCodigoEmissaoCapa
                cboSerie.Tag = lCodigoEmissaoCapa
                btnSalvar.Tag = lCodigoEmissaoCapa

                'Carrega os dados da MDFe
                oClsFatEmissaoMDFe.LoadDadosMDF(cboModelo, _
                                              cboSerie, _
                                              txtNumeroDocumento, _
                                              dtpDataEmissao, _
                                              dtpDataSaida, _
                                              cboUFCapa, _
                                              cboTipoEmitente, _
                                              cboModalidade, _
                                              cboFormaEmissao, _
                                              cboUFDescarregamento, _
                                              txtMensagemSefaz, _
                                              txtStatusMDFe, _
                                              txtChaveAcesso, _
                                              txtRecibo, _
                                              txtLote, _
                                              txtProtocolo)

                oClsFatEmissaoMDFe.LoadDadosRodoviario(txtRntrcVeiculo, _
                                                       txtCiotVeiculo, _
                                                       txtCodigoAgendamentoPortoVeiculo)

                oClsFatEmissaoMDFe.LoadDadosAquaviario(txtAgenciaAquaviario, _
                                                       txtTipoEmbarcacaoAquaviario, _
                                                       txtCodigoEmbarcacaoAquaviario, _
                                                       txtNumeroViagemAquaviario, _
                                                       txtNomeEmbarcacaoAquaviario, _
                                                       txtPortoEmbarqueAquaviario, _
                                                       txtPortoDestinoAquaviario)

                oClsFatEmissaoMDFe.LoadDadosTotais(txtTotalCTe, _
                                                   txtTotalNFe, _
                                                   txtTotalNFMod, _
                                                   txtTotalCargaTransportada, _
                                                   cboUnidadeMedidaTotal, _
                                                   txtPesoBrutoTotal)

                oClsFatEmissaoMDFe.LoadDadosInformacoesAdicionais(txtDadosAdicionais, _
                                                                  txtDadosAdicionaisFISCO)

                oClsFatEmissaoMDFe.LoadDadosVeiculoTracao(txtCodigoInternoVeiculo, _
                                                          cboTipoCarroceriaVeiculo, _
                                                          txtPlacaVeiculo, _
                                                          txtTaraVeiculo, _
                                                          cboRenavamVeiculo, _
                                                          cboUFVeiculo, _
                                                          cboTipoRodadoVeiculo, _
                                                          txtCapacidadeKGVeiculo, _
                                                          txtCapacidadeM3Veiculo, _
                                                          chkProprietarioVeiculo, _
                                                          txtRntrcProprietarioVeiculo, _
                                                          cboTipoProprietarioVeiculo, _
                                                          cboUFProprietarioVeiculo, _
                                                          txtCNPJCPFProprietarioVeiculo, _
                                                          txtNomeProprietarioVeiculo, _
                                                          txtIEProprietarioVeiculo)

                'Carrega as Grids
                Call oClsFatEmissaoMDFe.LoadGridAutorizado(grdAutorizadoTotal)

                Call oClsFatEmissaoMDFe.LoadGridCargaVazia(grdInformacaoUnidadeCargaAquaviario)

                Call oClsFatEmissaoMDFe.LoadGridCarregamento(grdMunicipioCarregamento)

                Call oClsFatEmissaoMDFe.LoadGridComboio(grdInformacaoComboioAquaviario)

                Call oClsFatEmissaoMDFe.LoadGridCondutor(grdCondutorVeiculo)

                Call oClsFatEmissaoMDFe.LoadGridLacre(grdLacreTotal)

                Call oClsFatEmissaoMDFe.LoadGridMunicipioDescarregamento(grdMunicipioDescarregamento)

                Call oClsFatEmissaoMDFe.LoadGridPercurso(grdPercurso)

                Call oClsFatEmissaoMDFe.LoadGridReboque(grdInformacoesVeiculoReboque)

                Call oClsFatEmissaoMDFe.LoadGridTerminalCarregamento(grdTerminalCarregamentoAquaviario)

                Call oClsFatEmissaoMDFe.LoadGridTerminalDescarregamento(grdTerminalDescarregamentoAquaviario)

                Call oClsFatEmissaoMDFe.LoadGridValePedagio(grdValePedagio)

                Call oClsFatEmissaoMDFe.LoadGridNotaFiscal(grdDocumentosNotaFiscal)

                Call oClsFatEmissaoMDFe.LoadGridReferenciado(grdDocumentosReferenciado)

                'Seta Status
                Call VerificaStatus(txtStatusMDFe.Tag)

                'Seta Aba
                tabDados.SelectedTab = pagDadosMDFe

                tabDados.Visible = True

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboSerie.Focus()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DuplicarManifesto(ByVal lCodigoEmissaoCapa As Long)
        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert) = True Then

                'Verifica se o usuário deseja copiar o Manifesto Eletrônico
                If MsgBox("Deseja Duplicar o Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Carrega Manifesto Eletrônico
                    Call EditarManifesto(oClsFatEmissaoMDFe.DuplicarManifestoEletronico(lCodigoEmissaoCapa))

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

            'Verifica se foi Selecionado o Campo - Serie
            If ValidaCampo(cboSerie, lblSerie) = False Then
                tabDados.SelectedTab = pagDadosCapa
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF Capa
            If ValidaCampo(cboUFCapa, lblUFCapa) = False Then
                tabDados.SelectedTab = pagDadosCapa
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Emitente
            If ValidaCampo(cboTipoEmitente, lblTipoEmitente) = False Then
                tabDados.SelectedTab = pagDadosCapa
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma de Emissão
            If ValidaCampo(cboFormaEmissao, lblFormaEmissao) = False Then
                tabDados.SelectedTab = pagDadosCapa
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade
            If ValidaCampo(cboModalidade, lblModalidade) = False Then
                tabDados.SelectedTab = pagDadosCapa
                Exit Function
            End If

            'Verifica se foi Inserido na Grid - Municipio de Carregamento
            If grdMunicipioCarregamento.RowCount = 0 Then
                MsgBox("Insira pelo menos um municipio de carregamento", MsgBoxStyle.Information, Me.Parent.Text)
                tabDados.SelectedTab = pagDadosInformacaoPercurso
                Exit Function
            End If


            'Verifica se foi Selecionado o Campo - UF Descarregamento
            If ValidaCampo(cboUFDescarregamento, lblUFDescarregamento) = False Then
                tabDados.SelectedTab = pagDadosInformacaoPercurso
                Exit Function
            End If

            'Verifica qual Modalidade
            If cboModalidade.Text = "RODOVIÁRIO" Then

                'Verifica se foi Selecionado o Campo - Tipo de Carroceria
                If ValidaCampo(cboTipoCarroceriaVeiculo, lblTipoCarroceriaVeiculo) = False Then
                    tabDados.SelectedTab = pagRodoviario
                    'tabDados.SelectedTab = pagVeiculoTracao
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Placa
                If ValidaCampo(txtPlacaVeiculo, lblPlacaVeiculo, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagRodoviario
                    'tabDados.SelectedTab = pagVeiculoTracao
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Tara
                If ValidaCampo(txtTaraVeiculo, lblTaraVeiculo, TipoCampo.numero) = False Then
                    tabDados.SelectedTab = pagRodoviario
                    'tabDados.SelectedTab = pagVeiculoTracao
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - UF Veiculo
                If ValidaCampo(cboUFVeiculo, lblUFVeiculo) = False Then
                    tabDados.SelectedTab = pagRodoviario
                    'tabDados.SelectedTab = pagVeiculoTracao
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Tipo Rodado
                If ValidaCampo(cboTipoRodadoVeiculo, lblTipoRodadoVeiculo) = False Then
                    tabDados.SelectedTab = pagRodoviario
                    'tabDados.SelectedTab = pagVeiculoTracao
                    Exit Function
                End If

                'Verifica qual o proprietario do veiculo
                If chkProprietarioVeiculo.CheckedValue = True Then

                    'Verifica se foi Selecionado o Campo - Tipo Proprietario
                    If ValidaCampo(cboTipoProprietarioVeiculo, lblTipoProprietarioVeiculo) = False Then
                        tabDados.SelectedTab = pagRodoviario
                        'tabDados.SelectedTab = pagVeiculoTracao
                        Exit Function
                    End If

                    'Verifica se foi Selecionado o Campo - RNTRC Proprietario
                    If ValidaCampo(txtRntrcProprietarioVeiculo, lblRntrcProprietarioVeiculo, TipoCampo.numero) = False Then
                        tabDados.SelectedTab = pagRodoviario
                        'tabDados.SelectedTab = pagVeiculoTracao
                        Exit Function
                    End If

                    'Verifica se foi Selecionado o Campo - UF Proprietario
                    If ValidaCampo(cboUFProprietarioVeiculo, lblUFProprietarioVeiculo) = False Then
                        tabDados.SelectedTab = pagRodoviario
                        'tabDados.SelectedTab = pagVeiculoTracao
                        Exit Function
                    End If

                    'Verifica se foi Selecionado o Campo - Nome Proprietario
                    If ValidaCampo(txtNomeProprietarioVeiculo, lblNomeProprietarioVeiculo, TipoCampo.texto) = False Then
                        tabDados.SelectedTab = pagRodoviario
                        'tabDados.SelectedTab = pagVeiculoTracao
                        Exit Function
                    End If

                    'Verifica se foi inserido o condutor
                    If grdCondutorVeiculo.RowCount = 0 Then
                        MsgBox("Insira pelo menos um condutor.", MsgBoxStyle.Information, Me.Parent.Text)
                        tabDados.SelectedTab = pagRodoviario
                        'tabDados.SelectedTab = pagVeiculoTracao
                        Exit Function
                    End If
                End If
            End If

            'verifica a modalidade selecionada
            If cboModalidade.Text = "AQUAVIÁRIO" Then

                'Verifica se foi Selecionado o Campo - Agencia 
                If ValidaCampo(txtAgenciaAquaviario, lblCNPJAgenciaAquaviario, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagAquaviario
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Cdoigo Embarcacao
                If ValidaCampo(txtCodigoEmbarcacaoAquaviario, lblCodigoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                    tabDados.SelectedTab = pagAquaviario
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Tipo Embarcacao
                If ValidaCampo(txtTipoEmbarcacaoAquaviario, lblTipoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                    tabDados.SelectedTab = pagAquaviario
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Numero Viagem
                If ValidaCampo(txtNumeroViagemAquaviario, lblNumeroViagemAquaviario, TipoCampo.numero) = False Then
                    tabDados.SelectedTab = pagAquaviario
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Nome Embarcacao
                If ValidaCampo(txtNomeEmbarcacaoAquaviario, lblNomeEmbarcacaoAquaviario, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagAquaviario
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Porto Destino
                If ValidaCampo(txtPortoDestinoAquaviario, lblPortoDestinoAquaviario, TipoCampo.numero) = False Then
                    tabDados.SelectedTab = pagAquaviario
                    Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Porto Embarque
                If ValidaCampo(txtPortoEmbarqueAquaviario, lblPortoEmbarqueAquaviario, TipoCampo.numero) = False Then
                    tabDados.SelectedTab = pagAquaviario
                    Exit Function
                End If

                'Verifica se foi inserido um terminal de carregamento
                If grdTerminalCarregamentoAquaviario.RowCount = 0 Then
                    MsgBox("Insira pelo menos um terminal de carregamento.", MsgBoxStyle.Information, Me.Parent.Text)
                    tabDados.SelectedTab = pagTerminalCarregamentoAquaviario
                    Exit Function
                End If

                'Verifica se foi inserido um terminal de descarregamento
                If grdTerminalDescarregamentoAquaviario.RowCount = 0 Then
                    MsgBox("Insira pelo menos um terminal de descarregamento.", MsgBoxStyle.Information, Me.Parent.Text)
                    tabDados.SelectedTab = pagTerminalDescarregamentoAquaviario
                    Exit Function
                End If

                'Verifica se foi inserido uma embarcacao de comboio
                If grdInformacaoComboioAquaviario.RowCount = 0 Then
                    MsgBox("Insira pelo menos uma embarcacao de comboio", MsgBoxStyle.Information, Me.Parent.Text)
                    tabDados.SelectedTab = pagEmbarcacaoComboio
                    Exit Function
                End If

            End If

            'verifica se foi inserido o municipio de descarregamento
            If grdMunicipioDescarregamento.RowCount = 0 Then
                MsgBox("Insira pelo menos um municipio de descarregamento.", MsgBoxStyle.Information, Me.Parent.Text)
                tabDados.SelectedTab = pagMunicipioDescarregamento
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Total Carga Transportada
            If ValidaCampo(txtTotalCargaTransportada, lblTotalCargaTransportada, TipoCampo.numero) = False Then
                tabDados.SelectedTab = pagTotais
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade Medida
            If ValidaCampo(cboUnidadeMedidaTotal, lblUnidadeMedidaTotal) = False Then
                tabDados.SelectedTab = pagTotais
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Peso Bruto
            If ValidaCampo(txtPesoBrutoTotal, lblPesoBrutoTotal, TipoCampo.numero) = False Then
                tabDados.SelectedTab = pagTotais
                Exit Function
            End If

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'Carrega Configuração da MDF-e
            Call LoadConfiguracaoMDFe()

            'Verifica se foi Configurado o Manifesto
            If goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = 0 Then

                'Verifica se o Usuário Deseja Configurar o MDFe
                If MsgBox("Não foi configurado o Manifesto Eletrônico. Deseja Configurar?" & vbCrLf & vbCrLf & _
                          "A Configuração é imprescindível para Salvar o Manifesto.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then

                    Dim oForm As New frmCadBasico
                    oForm.UsrControl = "usrCfgMDFe"
                    oForm.Titulo = Me.Parent.Text
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Configuração
                    Call LoadConfiguracaoMDFe()

                    If goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = 0 Then
                        Exit Function
                    End If

                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub VerificaStatus(ByVal iStatus As Integer)

        Try

            'Desabilita Controles
            btnTransmitirMDFe.Enabled = False
            btnRetornarMDFe.Enabled = False
            btnExportarXML.Enabled = False
            'btnImprimirDAMFE.Enabled = False
            btnPreVisualizarDAMFE.Enabled = False
            btnEnviarEmail.Enabled = False
            btnImportarNFe.Enabled = False

            'Verifica qual status foi selecionado
            Select Case iStatus

                Case StatusManifestoEletronico.AguardandoTransmissao
                    txtStatusMDFe.Text = "AGUARDANDO TRANSMISSÃO"
                    btnImportarNFe.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcAdministrator)
                    btnTransmitirMDFe.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcAdministrator)
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnCadastrarInformacoesAdicionais.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    'btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirAutorizadoTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirCarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirCarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirComboioAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirCondutorVeiculo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirDescarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirDocumentoDescarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirLacreTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirPercurso.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirReferenciado.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirUnidadeAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirValePedagio.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    'btnImprimir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcPrint)
                    'btnImprimirDAMFE.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcPrint)
                    btnInserirNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnInserirReferenciado.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    'btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarAutorizadoTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarCarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarCarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarComboioAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarCondutorVeiculo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarDescarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarDocumentoDescarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarLacreTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarPercurso.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarUnidadeAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarValePedagio.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)

                Case StatusManifestoEletronico.AguardandoRetorno
                    txtStatusMDFe.Text = "AGUARDANDO RETORNO"
                    btnTransmitirMDFe.Enabled = False
                    btnRetornarMDFe.Enabled = True
                    btnSalvar.Enabled = False
                    btnCadastrarInformacoesAdicionais.Enabled = False
                    'btnExcluir.Enabled = False
                    btnExcluirAutorizadoTotal.Enabled = False
                    btnExcluirCarregamento.Enabled = False
                    btnExcluirCarregamentoAquaviario.Enabled = False
                    btnExcluirComboioAquaviario.Enabled = False
                    btnExcluirCondutorVeiculo.Enabled = False
                    btnExcluirDescarregamentoAquaviario.Enabled = False
                    btnExcluirDocumentoDescarregamento.Enabled = False
                    btnExcluirLacreTotal.Enabled = False
                    btnExcluirNotaFiscal.Enabled = False
                    btnExcluirPercurso.Enabled = False
                    btnExcluirReboque.Enabled = False
                    btnExcluirReferenciado.Enabled = False
                    btnExcluirUnidadeAquaviario.Enabled = False
                    btnExcluirValePedagio.Enabled = False
                    'btnImprimir.Enabled = False
                    'btnImprimirDAMFE.Enabled = False
                    btnInserirNotaFiscal.Enabled = False
                    btnInserirReferenciado.Enabled = False
                    btnNovo.Enabled = False
                    'btnNovo1.Enabled = False
                    btnSalvar.Enabled = False
                    btnSalvarAutorizadoTotal.Enabled = False
                    btnSalvarCarregamento.Enabled = False
                    btnSalvarCarregamentoAquaviario.Enabled = False
                    btnSalvarComboioAquaviario.Enabled = False
                    btnSalvarCondutorVeiculo.Enabled = False
                    btnSalvarDescarregamentoAquaviario.Enabled = False
                    btnSalvarDocumentoDescarregamento.Enabled = False
                    btnSalvarLacreTotal.Enabled = False
                    btnSalvarPercurso.Enabled = False
                    btnSalvarReboque.Enabled = False
                    btnSalvarUnidadeAquaviario.Enabled = False
                    btnSalvarValePedagio.Enabled = False

                Case StatusManifestoEletronico.AutorizadaUso, StatusManifestoEletronico.EnviadoDestinatario
                    txtStatusMDFe.Text = "AUTORIZADA PARA USO"
                    btnExportarXML.Enabled = True
                    'btnImprimirDAMFE.Enabled = True
                    btnEnviarEmail.Enabled = True
                    btnSalvar.Enabled = False
                    btnCadastrarInformacoesAdicionais.Enabled = False
                    'btnExcluir.Enabled = False
                    btnExcluirAutorizadoTotal.Enabled = False
                    btnExcluirCarregamento.Enabled = False
                    btnExcluirCarregamentoAquaviario.Enabled = False
                    btnExcluirComboioAquaviario.Enabled = False
                    btnExcluirCondutorVeiculo.Enabled = False
                    btnExcluirDescarregamentoAquaviario.Enabled = False
                    btnExcluirDocumentoDescarregamento.Enabled = False
                    btnExcluirLacreTotal.Enabled = False
                    btnExcluirNotaFiscal.Enabled = False
                    btnExcluirPercurso.Enabled = False
                    btnExcluirReboque.Enabled = False
                    btnExcluirReferenciado.Enabled = False
                    btnExcluirUnidadeAquaviario.Enabled = False
                    btnExcluirValePedagio.Enabled = False
                    'btnImprimir.Enabled = False
                    'btnImprimirDAMFE.Enabled = False
                    btnInserirNotaFiscal.Enabled = False
                    btnInserirReferenciado.Enabled = False
                    btnNovo.Enabled = False
                    'btnNovo1.Enabled = False
                    btnSalvar.Enabled = False
                    btnSalvarAutorizadoTotal.Enabled = False
                    btnSalvarCarregamento.Enabled = False
                    btnSalvarCarregamentoAquaviario.Enabled = False
                    btnSalvarComboioAquaviario.Enabled = False
                    btnSalvarCondutorVeiculo.Enabled = False
                    btnSalvarDescarregamentoAquaviario.Enabled = False
                    btnSalvarDocumentoDescarregamento.Enabled = False
                    btnSalvarLacreTotal.Enabled = False
                    btnSalvarPercurso.Enabled = False
                    btnSalvarReboque.Enabled = False
                    btnSalvarUnidadeAquaviario.Enabled = False
                    btnSalvarValePedagio.Enabled = False

                Case StatusManifestoEletronico.Rejeitada
                    txtStatusMDFe.Text = "REJEITADA"
                    btnTransmitirMDFe.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcAdministrator)
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnCadastrarInformacoesAdicionais.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    'btnExcluir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirAutorizadoTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirCarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirCarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirComboioAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirCondutorVeiculo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirDescarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirDocumentoDescarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirLacreTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirPercurso.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirReferenciado.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirUnidadeAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    btnExcluirValePedagio.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcDelete)
                    'btnImprimir.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcPrint)
                    'btnImprimirDAMFE.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcPrint)
                    btnInserirNotaFiscal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnInserirReferenciado.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnNovo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    'btnNovo1.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvar.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarAutorizadoTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarCarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarCarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarComboioAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarCondutorVeiculo.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarDescarregamentoAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarDocumentoDescarregamento.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarLacreTotal.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarPercurso.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarReboque.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarUnidadeAquaviario.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)
                    btnSalvarValePedagio.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcInsert)

                Case StatusManifestoEletronico.Cancelada
                    txtStatusMDFe.Text = "CANCELADA"
                    btnExportarXML.Enabled = True
                    'btnImprimirDAMFE.Enabled = True
                    btnEnviarEmail.Enabled = True
                    btnSalvar.Enabled = False
                    btnCadastrarInformacoesAdicionais.Enabled = False
                    'btnExcluir.Enabled = False
                    btnExcluirAutorizadoTotal.Enabled = False
                    btnExcluirCarregamento.Enabled = False
                    btnExcluirCarregamentoAquaviario.Enabled = False
                    btnExcluirComboioAquaviario.Enabled = False
                    btnExcluirCondutorVeiculo.Enabled = False
                    btnExcluirDescarregamentoAquaviario.Enabled = False
                    btnExcluirDocumentoDescarregamento.Enabled = False
                    btnExcluirLacreTotal.Enabled = False
                    btnExcluirNotaFiscal.Enabled = False
                    btnExcluirPercurso.Enabled = False
                    btnExcluirReboque.Enabled = False
                    btnExcluirReferenciado.Enabled = False
                    btnExcluirUnidadeAquaviario.Enabled = False
                    btnExcluirValePedagio.Enabled = False
                    'btnImprimir.Enabled = False
                    'btnImprimirDAMFE.Enabled = False
                    btnInserirNotaFiscal.Enabled = False
                    btnInserirReferenciado.Enabled = False
                    btnNovo.Enabled = False
                    'btnNovo1.Enabled = False
                    btnSalvar.Enabled = False
                    btnSalvarAutorizadoTotal.Enabled = False
                    btnSalvarCarregamento.Enabled = False
                    btnSalvarCarregamentoAquaviario.Enabled = False
                    btnSalvarComboioAquaviario.Enabled = False
                    btnSalvarCondutorVeiculo.Enabled = False
                    btnSalvarDescarregamentoAquaviario.Enabled = False
                    btnSalvarDocumentoDescarregamento.Enabled = False
                    btnSalvarLacreTotal.Enabled = False
                    btnSalvarPercurso.Enabled = False
                    btnSalvarReboque.Enabled = False
                    btnSalvarUnidadeAquaviario.Enabled = False
                    btnSalvarValePedagio.Enabled = False

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: EMITENTE :::"

    Private Sub SalvarEmitente()

        Try

            'Salva Dados do Emitente
            oClsFatEmissaoMDFe.DeleteEmitente()
            oClsFatEmissaoMDFe.InsertEmitente(IIf(gSistema = "AGROACTI", lblValorInscricaoEstadualEmitente.Text, ""))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CARREGAMENTO :::"

    Private Sub NovoCarregamento() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            ' Limpa controles
            cboUFCarregamento.SelectedIndex = -1
            cboMunicipioCarregamento.SelectedIndex = -1
            btnSalvarCarregamento.Tag = ""


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCarregamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCarregamento = False

            'Verifica se foi Selecionado o Campo - UF do carregamento
            If ValidaCampo(cboUFCarregamento, lblUFCarregamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Municipio do carregamento
            If ValidaCampo(cboMunicipioCarregamento, lblMunicipioCarregamento) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 50 municipios inseridos
            If (grdMunicipioCarregamento.RowCount = 50) = True Then
                MsgBox("O carregamento possue um limite máximo de 50 municípios", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCarregamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarCarregamento()

        Try

            'Carrega Controles
            With grdMunicipioCarregamento.CurrentRow

                cboUFCarregamento.Text = .Cells("uf").Value
                cboMunicipioCarregamento.Text = .Cells("municipio").Value
                btnSalvarCarregamento.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            cboUFCarregamento.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarCarregamento()

        Try
            oClsFatEmissaoMDFe.UFCarregamento = cboUFCarregamento.SelectedValue
            oClsFatEmissaoMDFe.CodigoMunicipioCarregamento = cboMunicipioCarregamento.SelectedValue

            'Verifica a operação
            If IsNumeric(btnSalvarCarregamento.Tag) Then
                oClsFatEmissaoMDFe.UpdateCarregamento(btnSalvarCarregamento.Tag)
            Else
                oClsFatEmissaoMDFe.InsertCarregamento()
            End If

            

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirCarregamento()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdMunicipioCarregamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteCarregamento()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: PERCURSO :::"

    Private Sub NovoPercurso() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa os controles
            cboUFPercurso.SelectedIndex = -1
            btnSalvarPercurso.Tag = ""


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPercurso() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPercurso = False

            'Verifica se foi Selecionado o Campo - UF do Percurso
            If ValidaCampo(cboUFPercurso, lblUFPercurso) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 25 percursos inseridos
            If (grdPercurso.RowCount = 25) = True Then
                MsgBox("O percurso possue um limite máximo de 25 estados", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoPercurso = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarPercurso()

        Try

            'Carrega Controles
            With grdPercurso.CurrentRow

                'Limpa Controles
                cboUFPercurso.Text = .Cells("uf").Value
                btnSalvarPercurso.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            cboUFPercurso.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPercurso()

        Try
            oClsFatEmissaoMDFe.UFPercurso = cboUFPercurso.SelectedValue

            'Verifica a Operação
            If IsNumeric(btnSalvarPercurso.Tag) Then
                oClsFatEmissaoMDFe.UpdatePercurso(btnSalvarPercurso.Tag)
            Else
                oClsFatEmissaoMDFe.InsertPercurso()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirPercurso()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdPercurso) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeletePercurso()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: RODOVIÁRIO :::"

#Region "::: CAPA :::"

    Private Sub SalvarRodoviario()
        Try

            oClsFatEmissaoMDFe.RntrcVeiculo = txtRntrcVeiculo.Text
            oClsFatEmissaoMDFe.CiotVeiculo = txtCiotVeiculo.Value
            oClsFatEmissaoMDFe.CodigoAgendamentoPortoVeiculo = txtCodigoAgendamentoPortoVeiculo.Value

            'Verifica a Operacao
            If IsNumeric(btnSalvar.Tag) Then
                oClsFatEmissaoMDFe.UpdateRodoviario()
            Else
                oClsFatEmissaoMDFe.InsertRodoviario()
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirRodoviario()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Exclui Registro
            Call oClsFatEmissaoMDFe.DeleteRodoviario()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: VEICULO DE TRAÇÃO :::"

    Private Sub SalvarVeiculoTracao()
        Try

            oClsFatEmissaoMDFe.CodigoInternoVeiculo = txtCodigoInternoVeiculo.Value
            oClsFatEmissaoMDFe.CodigoTipoCarroceriaVeiculo = IIf(cboTipoCarroceriaVeiculo.Enabled = False, -1, cboTipoCarroceriaVeiculo.SelectedValue)
            oClsFatEmissaoMDFe.PlacaVeiculo = txtPlacaVeiculo.Text
            oClsFatEmissaoMDFe.TaraKgVeiculo = txtTaraVeiculo.Value
            oClsFatEmissaoMDFe.RenavamVeiculo = cboRenavamVeiculo.SelectedValue
            oClsFatEmissaoMDFe.UFVeiculo = cboUFVeiculo.SelectedValue
            oClsFatEmissaoMDFe.CodigoTipoRodadoVeiculo = IIf(cboTipoRodadoVeiculo.Enabled = False, -1, cboTipoRodadoVeiculo.SelectedValue)
            oClsFatEmissaoMDFe.CapacidadeKgVeiculo = txtCapacidadeKGVeiculo.Value
            oClsFatEmissaoMDFe.CapacidadeM3Veiculo = txtCapacidadeM3Veiculo.Value
            oClsFatEmissaoMDFe.PropriedadeVeiculo = chkProprietarioVeiculo.Checked
            oClsFatEmissaoMDFe.RntrcProprietarioVeiculo = IIf(txtRntrcProprietarioVeiculo.Enabled = False, 0, txtRntrcProprietarioVeiculo.Text)
            oClsFatEmissaoMDFe.CodigoTipoProprietarioVeiculo = IIf(cboTipoProprietarioVeiculo.Enabled = False, -1, cboTipoProprietarioVeiculo.SelectedValue)
            oClsFatEmissaoMDFe.UFProprietarioVeiculo = IIf(cboUFProprietarioVeiculo.Enabled = False, "", cboUFProprietarioVeiculo.SelectedValue)
            oClsFatEmissaoMDFe.CPFCNPJProprietarioVeiculo = IIf(txtCNPJCPFProprietarioVeiculo.Enabled = False, "", txtCNPJCPFProprietarioVeiculo.Text)
            oClsFatEmissaoMDFe.NomeProprietarioVeiculo = IIf(txtNomeProprietarioVeiculo.Enabled = False, "", txtNomeProprietarioVeiculo.Text)
            oClsFatEmissaoMDFe.IEProprietarioVeiculo = IIf(txtIEProprietarioVeiculo.Enabled = False, "", txtIEProprietarioVeiculo.Text)

            'Verifica a Operacao
            If IsNumeric(btnSalvar.Tag) Then
                oClsFatEmissaoMDFe.UpdateVeiculoTracao()
            Else
                oClsFatEmissaoMDFe.InsertVeiculoTracao()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirVeiculoTracao()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Exclui Registro
            Call oClsFatEmissaoMDFe.DeleteVeiculoTracao()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: CONDUTOR :::"

    Private Sub NovoCondutor() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            cboNomeCondutorVeiculo.SelectedIndex = -1
            txtCPFCondutorVeiculo.Text = ""
            btnSalvarCondutorVeiculo.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCondutor() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCondutor = False

            'Verifica se foi Selecionado o Campo - Nome Condutor
            If ValidaCampo(cboNomeCondutorVeiculo, lblNomeCondutorVeiculo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CPF
            If ValidaCampo(txtCPFCondutorVeiculo, lblCPFCondutorVeiculo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 10 condutor inseridos
            If grdCondutorVeiculo.RowCount = 10 = True Then
                MsgBox("O veiculo de tracao possue um limite máximo de 10 condutores", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCondutor = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarCondutorVeiculo()

        Try

            'Carrega Controles
            With grdCondutorVeiculo.CurrentRow

                'Limpa Controles
                txtCPFCondutorVeiculo.Text = .Cells("cpf").Value
                cboNomeCondutorVeiculo.Text = .Cells("nome").Value
                btnSalvarCondutorVeiculo.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtCPFCondutorVeiculo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarCondutor()
        Try

            oClsFatEmissaoMDFe.NomeCondutorVeiculo = cboNomeCondutorVeiculo.Text
            oClsFatEmissaoMDFe.CPFCondutorVeiculo = txtCPFCondutorVeiculo.Text

            'Verifica a Opecacao
            If IsNumeric(btnSalvarCondutorVeiculo.Tag) Then
                oClsFatEmissaoMDFe.UpdateCondutor(btnSalvarCondutorVeiculo.Tag)
            Else
                oClsFatEmissaoMDFe.InsertCondutor()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirCondutor()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdCondutorVeiculo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteCondutor()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: REBOQUE :::"

    Private Sub NovoReboque() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            txtCodigoInternoVeiculoReboque.Value = 0
            cboTipoCarroceriaVeiculoReboque.SelectedIndex = -1
            txtPlacaVeiculoReboque.Text = ""
            txtTaraKGReboque.Value = 0
            txtRenavamReboque.Text = ""
            cboUFLicenciamentoReboque.SelectedIndex = -1
            cboTipoRodadoReboque.SelectedIndex = -1
            txtCapacidadeKGReboque.Value = 0
            txtCapacidadeM3Reboque.Value = 0
            chkProprietarioReboque.Checked = False
            txtRntrcProprietarioReboque.Enabled = False
            txtRntrcProprietarioReboque.Text = ""
            cboTipoProprietarioReboque.Enabled = False
            cboTipoProprietarioReboque.SelectedIndex = -1
            cboUFProprietarioReboque.Enabled = False
            cboUFProprietarioReboque.SelectedIndex = -1
            txtCPFCNPJProprietarioReboque.Enabled = False
            txtCPFCNPJProprietarioReboque.Text = ""
            txtNomeProprietarioReboque.Enabled = False
            txtNomeProprietarioReboque.Text = ""
            txtIEProprietarioReboque.Enabled = False
            txtIEProprietarioReboque.Text = ""
            btnSalvarReboque.Tag = ""


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoReboque() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoReboque = False

            'Verifica se foi Selecionado o Campo - Capacidade KG
            If ValidaCampo(txtCapacidadeKGReboque, lblCapacidadeKGReboque, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Capacidade M3
            If ValidaCampo(txtCapacidadeM3Reboque, lblCapacidadeM3Reboque, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Placa Veiculo
            If ValidaCampo(txtPlacaVeiculoReboque, lblPlacaVeiculoReboque, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tara KG
            If ValidaCampo(txtTaraKGReboque, lblTaraKGReboque, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tipo Carroceria
            If ValidaCampo(cboTipoCarroceriaVeiculoReboque, lblTipoCarroceriaVeiculoReboque) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - UF Licenciamento
            If ValidaCampo(cboUFLicenciamentoReboque, lblUFLicenciamentoReboque) = False Then
                Exit Function
            End If

            'Verifica o proprietario
            If chkProprietarioReboque.CheckedValue = True Then

                'Verifica se foi Preenchido o Campo - tipo Proprietario
                If ValidaCampo(cboTipoProprietarioReboque, lblTipoProprietarioReboque) = False Then
                    pagReboque.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - RNTRC Proprietario
                If ValidaCampo(txtRntrcProprietarioReboque, lblRntrcProprietarioReboque, TipoCampo.numero) = False Then
                    pagReboque.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - UF Proprietario
                If ValidaCampo(cboUFProprietarioReboque, lblUFProprietarioReboque) = False Then
                    pagReboque.Focus()
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Nome Proprietario
                If ValidaCampo(txtNomeProprietarioReboque, lblNomeProprietarioReboque, TipoCampo.texto) = False Then
                    pagReboque.Focus()
                    Exit Function
                End If

                'Verifica se foi inserido veiculo de Reboque
                If grdInformacoesVeiculoReboque.RowCount = 0 Then
                    MsgBox("Insira pelo menos um veiculo de reboque.", MsgBoxStyle.Information, Me.Parent.Text)
                    pagReboque.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo -  Tipo Rodado
            If ValidaCampo(cboTipoRodadoReboque, lblTipoRodadoReboque) = False Then
                pagReboque.Focus()
                Exit Function
            End If

            'Verifica se tem mais de 3 veiculos reboque inseridos
            If (grdInformacoesVeiculoReboque.RowCount = 3) = True Then
                MsgBox("O veiculo de reboque possue um limite máximo de 3 veiculos", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If


            'Seta Retorno da Função
            ValidacaoReboque = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarReboque()

        Try

            'Carrega Controles
            With grdInformacoesVeiculoReboque.CurrentRow

                txtCodigoInternoVeiculoReboque.Value = .Cells("codigo_interno").Value
                txtPlacaVeiculoReboque.Text = .Cells("placa").Value
                txtRenavamReboque.Text = .Cells("renavam").Value
                cboTipoCarroceriaVeiculoReboque.Text = .Cells("tipo_carroceria").Value
                cboUFLicenciamentoReboque.Text = .Cells("uf_veiculo").Value
                txtTaraKGReboque.Value = .Cells("tara_kg").Value
                txtCapacidadeKGReboque.Value = .Cells("capacidade_kg").Value
                txtCapacidadeM3Reboque.Value = .Cells("capacidade_m3").Value
                chkProprietarioReboque.CheckedValue = .Cells("propriedade_veiculo").Value
                txtRntrcProprietarioReboque.Text = .Cells("rntrc").Value
                txtNomeProprietarioReboque.Text = .Cells("nome_proprietario").Value
                txtCPFCNPJProprietarioReboque.Text = .Cells("cpf_cnpj_proprietario").Value
                txtIEProprietarioReboque.Value = .Cells("ie_proprietario").Value
                cboUFProprietarioReboque.Text = .Cells("uf_proprietario").Value
                cboTipoProprietarioReboque.Text = .Cells("tipo_proprietario").Value
                cboTipoRodadoReboque.Text = .Cells("tipo_rodado").Value
                btnSalvarReboque.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtCodigoInternoVeiculoReboque.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarReboque()
        Try

            oClsFatEmissaoMDFe.CodigoInternoReboque = txtCodigoInternoVeiculoReboque.Value
            oClsFatEmissaoMDFe.CodigoTipoCarroceriaReboque = cboTipoCarroceriaVeiculoReboque.SelectedValue
            oClsFatEmissaoMDFe.PlacaReboque = txtPlacaVeiculoReboque.Text
            oClsFatEmissaoMDFe.TaraKgReboque = txtTaraKGReboque.Value
            oClsFatEmissaoMDFe.RenavamReboque = txtRenavamReboque.Text
            oClsFatEmissaoMDFe.UFLicenciamentoReboque = cboUFLicenciamentoReboque.SelectedValue
            oClsFatEmissaoMDFe.CodigoTipoRodadoReboque = cboTipoRodadoReboque.SelectedValue
            oClsFatEmissaoMDFe.CapacidadeKgReboque = txtCapacidadeKGReboque.Value
            oClsFatEmissaoMDFe.CapacidadeM3Reboque = txtCapacidadeM3Reboque.Value
            oClsFatEmissaoMDFe.PropriedadeReboque = chkProprietarioReboque.CheckedValue
            oClsFatEmissaoMDFe.RntrcProprietarioReboque = IIf(txtRntrcProprietarioReboque.Enabled = False, 0, txtRntrcProprietarioReboque.Text)
            oClsFatEmissaoMDFe.CodigoTipoProprietatioReboque = IIf(cboTipoProprietarioReboque.Enabled = False, -1, cboTipoProprietarioReboque.SelectedValue)
            oClsFatEmissaoMDFe.UFProprietarioReboque = IIf(cboUFProprietarioReboque.Enabled = False, "", cboUFProprietarioReboque.SelectedValue)
            oClsFatEmissaoMDFe.CPFCNPJProprietarioReboque = IIf(txtCPFCNPJProprietarioReboque.Enabled = False, "", txtCPFCNPJProprietarioReboque.Text)
            oClsFatEmissaoMDFe.NomeProprietarioReboque = IIf(txtNomeProprietarioReboque.Enabled = False, "", txtNomeProprietarioReboque.Text)
            oClsFatEmissaoMDFe.IEProprietarioReboque = IIf(txtIEProprietarioReboque.Enabled = False, 0, txtIEProprietarioReboque.Text)

            'Verifica a Operacao
            If IsNumeric(btnSalvarReboque.Tag) Then
                oClsFatEmissaoMDFe.UpdateReboque(btnSalvarReboque.Tag)
            Else
                oClsFatEmissaoMDFe.InsertReboque()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirReboque()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdInformacoesVeiculoReboque) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteReboque()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: VALE PEDÁGIO :::"

    Private Sub NovoValePedagio() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            txtCNPJValePedagio.Text = ""
            txtNumeroComprovanteValePedagio.Value = 0
            txtCNPJResponsavelValePedagio.Text = ""
            btnSalvarValePedagio.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoValePedagio() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoValePedagio = False

            'Verifica se foi Selecionado o Campo - Tipo de Nota Fiscal
            If ValidaCampo(txtCNPJValePedagio, lblCNPJValePedagio, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Nota Fiscal
            If ValidaCampo(txtNumeroComprovanteValePedagio, lblNumeroComprovanteValePedagio, TipoCampo.numero) = False Then
                Exit Function
            End If


            'Seta Retorno da Função
            ValidacaoValePedagio = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarValePedagio()

        Try

            'Carrega Controles
            With grdValePedagio.CurrentRow

                txtCNPJValePedagio.Text = .Cells("cnpj_fornecedor").Value
                txtCNPJResponsavelValePedagio.Text = .Cells("cnpj_responsavel").Value
                txtNumeroComprovanteValePedagio.Value = .Cells("numero_comprovante").Value
                btnSalvarValePedagio.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtCNPJValePedagio.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarValePedagio()
        Try
            oClsFatEmissaoMDFe.CNPJAgenciaValePedagio = txtCNPJValePedagio.Text
            oClsFatEmissaoMDFe.NumeroComprovanteValePedagio = txtNumeroComprovanteValePedagio.Value
            oClsFatEmissaoMDFe.CNPJResponsavelValePedagio = txtCNPJResponsavelValePedagio.Text

            If IsNumeric(btnSalvarValePedagio.Tag) Then
                oClsFatEmissaoMDFe.UpdateValePedagio(btnSalvarValePedagio.Tag)
            Else
                oClsFatEmissaoMDFe.InsertValePedagio()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirValePedagio()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdValePedagio) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteValePedagio()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

#Region "::: AQUAVIÁRIO :::"

#Region "::: CAPA :::"

    Private Sub SalvarAquaviario()
        Try

            oClsFatEmissaoMDFe.CNPJAgencia = txtAgenciaAquaviario.Text
            oClsFatEmissaoMDFe.CodigoTipoEmbarcacao = txtTipoEmbarcacaoAquaviario.Value
            oClsFatEmissaoMDFe.CodigoEmbarcacao = txtCodigoEmbarcacaoAquaviario.Value
            oClsFatEmissaoMDFe.NumeroViagem = txtNumeroViagemAquaviario.Value
            oClsFatEmissaoMDFe.NomeEmbarcacao = txtNomeEmbarcacaoAquaviario.Text
            oClsFatEmissaoMDFe.CodigoPortoEmbarque = txtPortoEmbarqueAquaviario.Value
            oClsFatEmissaoMDFe.CodigoPortoDestino = txtPortoDestinoAquaviario.Value

            'Verifica a operacao
            If IsNumeric(btnSalvar.Tag) Then
                oClsFatEmissaoMDFe.UpdateAquaviario()
            Else
                oClsFatEmissaoMDFe.InsertAquaviario()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirAquaviario()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Exclui Registro
            Call oClsFatEmissaoMDFe.DeleteAquaviario()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: CARREGAMENTO :::"

    Private Sub NovoCarregamentoAquaviario() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controle
            txtCodigoTerminalCarregamentoAquaviario.Value = 0
            txtNomeTerminalCarregamentoAquaviario.Text = ""
            btnSalvarCarregamentoAquaviario.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Function ValidacaoCarregamentoAquaviario() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCarregamentoAquaviario = False

            'Verifica se foi Selecionado o Campo - CNPJ
            If ValidaCampo(txtAgenciaAquaviario, lblCNPJAgenciaAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Codigo Embarcacao
            If ValidaCampo(txtCodigoEmbarcacaoAquaviario, lblCodigoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tipo Embarcacao
            If ValidaCampo(txtTipoEmbarcacaoAquaviario, lblTipoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Numero Viagem
            If ValidaCampo(txtNumeroViagemAquaviario, lblNumeroViagemAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nome Embarcacao
            If ValidaCampo(txtNomeEmbarcacaoAquaviario, lblNomeEmbarcacaoAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Porto Embarque
            If ValidaCampo(txtPortoEmbarqueAquaviario, lblPortoEmbarqueAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Porto Destino
            If ValidaCampo(txtPortoDestinoAquaviario, lblPortoDestinoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Codigo Terminal Carregamento
            If ValidaCampo(txtCodigoTerminalCarregamentoAquaviario, lblCodigoTerminalCarrgamentoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - nome Terminal Carregamento
            If ValidaCampo(txtNomeTerminalCarregamentoAquaviario, lblNomeTerminalCarregamentoAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 5 terminais Carregamento inseridos
            If (grdTerminalCarregamentoAquaviario.RowCount = 5) = True Then
                MsgBox("A modalidade aquaviário possue um limite máximo de 5 terminais de carregamento", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCarregamentoAquaviario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarCarregamentoAquaviario()

        Try

            'Carrega Controles
            With grdTerminalCarregamentoAquaviario.CurrentRow

                txtCodigoTerminalCarregamentoAquaviario.Value = .Cells("codigo_terminal").Value
                txtNomeTerminalCarregamentoAquaviario.Text = .Cells("nome_terminal").Value
                btnSalvarCarregamentoAquaviario.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtCodigoTerminalCarregamentoAquaviario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarCarregamentoAquaviario()
        Try

            oClsFatEmissaoMDFe.CodigoTerminalCarregamento = txtCodigoTerminalCarregamentoAquaviario.Value
            oClsFatEmissaoMDFe.NomeTerminalCarregamento = txtNomeTerminalCarregamentoAquaviario.Text

            'Verifica operação
            If IsNumeric(btnSalvarCarregamentoAquaviario.Tag) Then
                oClsFatEmissaoMDFe.UpdateTerminalCarregamento(btnSalvarCarregamentoAquaviario.Tag)
            Else
                oClsFatEmissaoMDFe.InsertTerminalCarregamento()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirCarregamentoAquaviario()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdTerminalCarregamentoAquaviario) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteTerminalCarregamento()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: DESCARREGAMENTO :::"

    Private Sub NovoDescarregamentoAquaviario() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            txtCodigoTerminalDescarregamentoAquaviario.Value = 0
            txtNomeTerminalDescarregamentoAquaviario.Text = ""
            btnSalvarDescarregamentoAquaviario.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Function ValidacaoDescarregamentoAquaviario() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDescarregamentoAquaviario = False

            'Verifica se foi Selecionado o Campo - CNPJ
            If ValidaCampo(txtAgenciaAquaviario, lblCNPJAgenciaAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo -  codigo embarcacao
            If ValidaCampo(txtCodigoEmbarcacaoAquaviario, lblCodigoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - tipo embarcacao
            If ValidaCampo(txtTipoEmbarcacaoAquaviario, lblTipoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - numero viagem
            If ValidaCampo(txtNumeroViagemAquaviario, lblNumeroViagemAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - nome embarcacao
            If ValidaCampo(txtNomeEmbarcacaoAquaviario, lblNomeEmbarcacaoAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - porto embarque
            If ValidaCampo(txtPortoEmbarqueAquaviario, lblPortoEmbarqueAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - porto destino
            If ValidaCampo(txtPortoDestinoAquaviario, lblPortoDestinoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Codigo terminal descarregamento
            If ValidaCampo(txtCodigoTerminalDescarregamentoAquaviario, lblCodigoTerminalDescarregamentoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - nome terminal descarregamento
            If ValidaCampo(txtNomeTerminalDescarregamentoAquaviario, lblNomeTerminalDescarregamentoAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 5 terminais descarregamento inseridos
            If grdTerminalDescarregamentoAquaviario.RowCount = 5 = True Then
                MsgBox("A modalidade aquaviário possue um limite máximo de 5 terminais de descarregamento", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDescarregamentoAquaviario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarDescarregamentoAquaviario()

        Try

            'Carrega Controles
            With grdTerminalDescarregamentoAquaviario.CurrentRow

                txtCodigoTerminalDescarregamentoAquaviario.Value = .Cells("codigo_terminal").Value
                txtNomeTerminalDescarregamentoAquaviario.Text = .Cells("nome_terminal").Value
                btnSalvarDescarregamentoAquaviario.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtCodigoTerminalDescarregamentoAquaviario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDescarregamentoAquaviario()
        Try

            oClsFatEmissaoMDFe.CodigoTerminalDescarregamento = txtCodigoTerminalDescarregamentoAquaviario.Value
            oClsFatEmissaoMDFe.NomeTerminalDescarregamento = txtNomeTerminalDescarregamentoAquaviario.Text

            'Verifica operacao
            If IsNumeric(btnSalvarDescarregamentoAquaviario.Tag) Then
                oClsFatEmissaoMDFe.UpdateTerminalDescarregamento(btnSalvarDescarregamentoAquaviario.Tag)
            Else
                oClsFatEmissaoMDFe.InsertTerminalDescarregamento()
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirDescarregamentoAquaviario()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdTerminalDescarregamentoAquaviario) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteTerminalDescarregamento()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: COMBOIO :::"

    Private Sub NovoComboioAquaviario() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa controles
            txtCodigoComboioAquaviario.Value = 0
            btnSalvarComboioAquaviario.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoComboioAquaviario() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoComboioAquaviario = False

            'Verifica se foi Selecionado o Campo - CNPJ
            If ValidaCampo(txtAgenciaAquaviario, lblCNPJAgenciaAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - codigo embarcacao
            If ValidaCampo(txtCodigoEmbarcacaoAquaviario, lblCodigoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - tipo embarcacao
            If ValidaCampo(txtTipoEmbarcacaoAquaviario, lblTipoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - numero viagem
            If ValidaCampo(txtNumeroViagemAquaviario, lblNumeroViagemAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - nome embarcacao
            If ValidaCampo(txtNomeEmbarcacaoAquaviario, lblNomeEmbarcacaoAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - porto embarque
            If ValidaCampo(txtPortoEmbarqueAquaviario, lblPortoEmbarqueAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - porto destino
            If ValidaCampo(txtPortoDestinoAquaviario, lblPortoDestinoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - codigo comboio
            If ValidaCampo(txtCodigoComboioAquaviario, lblCodigoComboioAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 30 comboios inseridos
            If grdInformacaoComboioAquaviario.RowCount = 30 = True Then
                MsgBox("A modalidade aquaviário possue um limite máximo de 30 embarcações de comboio", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoComboioAquaviario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarComboioAquaviario()

        Try

            'Carrega Controles
            With grdInformacaoComboioAquaviario.CurrentRow

                txtCodigoComboioAquaviario.Value = .Cells("codigo_terminal").Value
                btnSalvarComboioAquaviario.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtCodigoComboioAquaviario.Focus()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub SalvarComboioAquaviario()
        Try

            oClsFatEmissaoMDFe.CodigoEmbarcacaoComboio = txtCodigoComboioAquaviario.Value

            'Verifica operacao
            If IsNumeric(btnSalvarComboioAquaviario.Tag) Then
                oClsFatEmissaoMDFe.UpdateComboio(btnSalvarComboioAquaviario.Tag)
            Else
                oClsFatEmissaoMDFe.InsertComboio()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirComboioAquaviario()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdInformacaoComboioAquaviario) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteComboio()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: UNIDADE DE CARGA :::"

    Private Sub NovaUnidadeCargaAquaviario() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'limpa controles
            txtIdentificacaoUnidadeCargaAquaviario.Text = ""
            cboUnidadeCargaAquaviario.SelectedIndex = -1
            btnSalvarUnidadeAquaviario.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Function ValidacaoUnidadeCargaAquaviario() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoUnidadeCargaAquaviario = False

            'Verifica se foi Selecionado o Campo - cnpj
            If ValidaCampo(txtAgenciaAquaviario, lblCNPJAgenciaAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - codigo embarcacao
            If ValidaCampo(txtCodigoEmbarcacaoAquaviario, lblCodigoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - tipo embarcacao
            If ValidaCampo(txtTipoEmbarcacaoAquaviario, lblTipoEmbarcacaoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - numero viagem
            If ValidaCampo(txtNumeroViagemAquaviario, lblNumeroViagemAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - nome embarcacao
            If ValidaCampo(txtNomeEmbarcacaoAquaviario, lblNomeEmbarcacaoAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - porto embarque
            If ValidaCampo(txtPortoEmbarqueAquaviario, lblPortoEmbarqueAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - porto destino
            If ValidaCampo(txtPortoDestinoAquaviario, lblPortoDestinoAquaviario, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - identificacao unidade carga
            If ValidaCampo(txtIdentificacaoUnidadeCargaAquaviario, lblIdentificacaoUnidadeCargaAquaviario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - unidade carga
            If ValidaCampo(cboUnidadeCargaAquaviario, lblIdentificacaoUnidadeCargaAquaviario) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoUnidadeCargaAquaviario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarUnidadeCargaAquaviario()

        Try

            'Carrega Controles
            With grdInformacaoUnidadeCargaAquaviario.CurrentRow

                txtIdentificacaoUnidadeCargaAquaviario.Text = .Cells("identificacao_unidade_carga").Value
                cboUnidadeCargaAquaviario.Text = .Cells("tipo_unidade_carga").Value
                btnSalvarUnidadeAquaviario.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtIdentificacaoUnidadeCargaAquaviario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarUnidadeCargaAquaviario()
        Try
            oClsFatEmissaoMDFe.IdentificacaoUnidadeCarga = txtIdentificacaoUnidadeCargaAquaviario.Text
            oClsFatEmissaoMDFe.CodigoTipoUnidade = cboUnidadeCargaAquaviario.SelectedValue
            oClsFatEmissaoMDFe.QuantidadeRateadaUnidade = 0
            oClsFatEmissaoMDFe.NumeroLacreUnidade = 0

            'Verifica operacao
            If IsNumeric(btnSalvarUnidadeAquaviario.Tag) Then
                oClsFatEmissaoMDFe.UpdateCargaVazia(btnSalvarUnidadeAquaviario.Tag)
            Else
                oClsFatEmissaoMDFe.InsertCargaVazia()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirUnidadeCargaAquaviario()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdInformacaoUnidadeCargaAquaviario) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteCargaVazia()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

#Region "::: INFORMAÇÕES DE DOCUMENTOS :::"

#Region "::: MUNICÍPIOS DE DESCARREGAMENTO :::"

    Private Sub NovoMunicipioDescarregamento() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa controles
            cboMunicipioDescarregamentoInformacoes.SelectedIndex = -1
            btnSalvarDocumentoDescarregamento.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Function ValidacaoMunicipioDescarregamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoMunicipioDescarregamento = False


            'Verifica se foi Preenchido o Campo - municipio descarregamento
            If ValidaCampo(cboMunicipioDescarregamentoInformacoes, lblMunicipioDescarregamentoInformacoes) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 100 municipios inseridos
            If grdMunicipioDescarregamento.RowCount = 100 = True Then
                MsgBox("O municipio de descarregamento possue um limite máximo de 100 municipios", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoMunicipioDescarregamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarMunicipioDescarregamento()

        Try

            'Carrega Controles
            With grdMunicipioDescarregamento.CurrentRow

                cboUFDescarregamentoInformacoes.Text = .Cells("uf").Value
                cboMunicipioDescarregamentoInformacoes.Text = .Cells("municipio").Value
                btnSalvarDocumentoDescarregamento.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            cboUFDescarregamentoInformacoes.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarMunicipioDescarregamento()
        Try

            
            oClsFatEmissaoMDFe.UFDescarregamentoDocumentos = cboUFDescarregamentoInformacoes.SelectedValue
            oClsFatEmissaoMDFe.CodigoMunicipioDocumentos = cboMunicipioDescarregamentoInformacoes.SelectedValue

            'Verifica operacao
            If IsNumeric(btnSalvarDocumentoDescarregamento.Tag) Then
                oClsFatEmissaoMDFe.UpdateMunicipioDescarregamento(btnSalvarDocumentoDescarregamento.Tag)
            Else
                oClsFatEmissaoMDFe.InsertMunicipioDescarregamento()
            End If



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirMunicipioDescarregamento()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdMunicipioDescarregamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteMunicipioDescarregamento()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: NOTA FISCAL ELETRÔNICA :::"

    Private Function ValidacaoNotaFiscal() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoNotaFiscal = False


            'Verifica se foi Preenchido o Campo - UF Descarregamento
            If ValidaCampo(cboUFDescarregamentoDocumentos, lblUFDescarregamentoDocumentos) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Municipio Descarregamento
            If ValidaCampo(cboMunicipioDescarregamentoDocumentos, lblMunicipioDescarregamentoDocumentos) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 2000 notas fiscais inseridas
            If grdMunicipioDescarregamento.RowCount = 2000 = True Then
                MsgBox("A nota fiscal eletrônica possue um limite máximo de 2000 notas", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoNotaFiscal = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarDocumentosNotaFiscal()

        Try

            'Carrega Controles
            With grdDocumentosNotaFiscal.CurrentRow

                Dim oForm As New frmFatEmissaoMDFeDocumentos

                oForm.cboChaveAcesso.SelectedValue = .Cells("chave_acesso").Value
                oForm.cboTipo.SelectedValue = .Cells("tipo").Value
                oForm.txtNumeroLacres.Value = .Cells("numero_lacres").Value
                oForm.txtQuantidadeRateada.Value = .Cells("quantidade_rateada").Value
                oForm.btnInserir.Tag = .Cells("codigo").Value
                oForm.ChaveAcesso = .Cells.Item("chave_acesso").Value
                oForm.CodigoEmissaoCapa = oClsFatEmissaoMDFe.CodigoEmissaoCapa
                oForm.Tipo = 1
                oForm.UF = cboUFDescarregamentoDocumentos.SelectedValue
                oForm.CodigoMunicipio = cboMunicipioDescarregamentoDocumentos.SelectedValue


                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            End With

            'Carrega a Grid
            oClsFatEmissaoMDFe.LoadGridNotaFiscal(grdDocumentosNotaFiscal)

            'Seta Focu
            txtCPFCondutorVeiculo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirNotaFiscal()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdDocumentosNotaFiscal) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

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
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: MDFe REFERENCIADO :::"

    Private Function ValidacaoReferenciado() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoReferenciado = False

            'Verifica se foi Preenchido o Campo - UF Descarregamento
            If ValidaCampo(cboUFDescarregamentoDocumentos, lblUFDescarregamentoDocumentos) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Municipio Descarregamento
            If ValidaCampo(cboMunicipioDescarregamentoDocumentos, lblMunicipioDescarregamentoDocumentos) = False Then
                Exit Function
            End If

            'Verifica se tem mais de 2000 documento referenciados inseridos
            If grdDocumentosReferenciado.RowCount = 2000 = True Then
                MsgBox("Os documentos referenciados possuem um limite máximo de 2000 documentos", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoReferenciado = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub InsertReferenciado(ByVal oGrid As GridEX, _
                               ByVal sChaveAcesso As String, _
                               ByVal iQuantidadeUnidadeTransporte As Integer, _
                               ByVal sTipo As String)

        Try
            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCChaveAcesso As New DataColumn("chave_acesso")
            Dim oDCQuantidadeUnidadeTransporte As New DataColumn("quantidade_unidade_transporte")
            Dim oDCCodigo As New DataColumn("codigo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
            Else
                oDataSet.Tables.Add(oDataTable)
                oDataTable.Columns.Add(oDCChaveAcesso)
                oDataTable.Columns.Add(oDCQuantidadeUnidadeTransporte)
                oDataTable.Columns.Add(oDCCodigo)
            End If

            'Verifica o Tipo de Operação
            If sTipo = "I" Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("chave_acesso") = sChaveAcesso
                oDataRow("quantidade_unidade_transporte") = iQuantidadeUnidadeTransporte
                oDataRow("codigo") = oGrid.RowCount + 1
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & btnInserirReferenciado.Tag & ")")(0)
                oDataRow("chave_acesso") = sChaveAcesso
                oDataRow("quantidade_unidade_transporte") = iQuantidadeUnidadeTransporte
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

    Private Sub ExcluirReferenciado()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdDocumentosReferenciado) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

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
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarDocumentosReferenciado()

        Try

            'Carrega Controles
            With grdDocumentosReferenciado.CurrentRow

                Dim oForm As New frmFatEmissaoMDFeDocumentos

                oForm.cboChaveAcesso.SelectedValue = .Cells("chave_acesso").Value
                oForm.cboTipo.SelectedValue = .Cells("tipo").Value
                oForm.txtNumeroLacres.Value = .Cells("numero_lacres").Value
                oForm.txtQuantidadeRateada.Value = .Cells("quantidade_rateada").Value
                oForm.btnInserir.Tag = .Cells("codigo").Value
                oForm.ChaveAcesso = .Cells.Item("chave_acesso").Value
                oForm.CodigoEmissaoCapa = oClsFatEmissaoMDFe.CodigoEmissaoCapa
                oForm.Tipo = 2
                oForm.UF = cboUFDescarregamentoDocumentos.SelectedValue
                oForm.CodigoMunicipio = cboMunicipioDescarregamentoDocumentos.SelectedValue


                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            End With

            'Carrega a Grid
            oClsFatEmissaoMDFe.LoadGridReferenciado(grdDocumentosReferenciado)

            'Seta Focu
            txtCPFCondutorVeiculo.Focus()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

#End Region

#End Region

#Region "::: TOTAIS :::"

#Region "::: CAPA :::"

    Private Sub SalvarTotais()
        Try

            oClsFatEmissaoMDFe.QuantidadeTotalCTe = txtTotalCTe.Value
            oClsFatEmissaoMDFe.QuantidadeTotalNFe = txtTotalNFe.Value
            oClsFatEmissaoMDFe.QuantidadeTotalNFMod = txtTotalNFMod.Value
            oClsFatEmissaoMDFe.TotalCargaTransportada = txtTotalCargaTransportada.Value
            oClsFatEmissaoMDFe.PesoBrutoTotalCarga = txtPesoBrutoTotal.Value
            oClsFatEmissaoMDFe.CodigoUnidadeMedida = cboUnidadeMedidaTotal.SelectedValue

            'Verifica a Operacao
            If IsNumeric(btnSalvar.Tag) Then
                oClsFatEmissaoMDFe.UpdateTotais()
            Else
                oClsFatEmissaoMDFe.InsertTotais()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirTotais()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Exclui Registro
            Call oClsFatEmissaoMDFe.DeleteTotais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: LACRE :::"

    Private Sub NovoLacreTotal() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            txtNumeroLacreTotal.Value = 0
            btnSalvarLacreTotal.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoLacreTotal() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoLacreTotal = False

            'Verifica se foi Preenchido o Campo - Lacre 
            If ValidaCampo(txtNumeroLacreTotal, lblLacreTotal, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoLacreTotal = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarLacreTotal()

        Try

            'Carrega Controles
            With grdLacreTotal.CurrentRow

                'Limpa Controles
                txtNumeroLacreTotal.Value = .Cells("numero_lacre").Value
                btnSalvarLacreTotal.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtNumeroLacreTotal.Focus()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub SalvarLacreTotal()
        Try

            oClsFatEmissaoMDFe.NumeroLacres = txtNumeroLacreTotal.Value

            'Verifica operação
            If IsNumeric(btnSalvarLacreTotal.Tag) Then
                oClsFatEmissaoMDFe.UpdateLacre(btnSalvarLacreTotal.Tag)
            Else
                oClsFatEmissaoMDFe.InsertLacre(grdLacreTotal)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirLacreTotal()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdLacreTotal) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteLacre()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: AUTORIZADO :::"

    Private Sub NovoAutorizadoTotal() Handles Me.Disposed

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa controle
            txtCNPJCPFAutorizadoTotal.Text = ""
            btnSalvarAutorizadoTotal.Tag = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoAutorizadoTotal() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoAutorizadoTotal = False

            'Verifica se foi Preenchido o Campo - CNPJ/CPF 
            If ValidaCampo(txtCNPJCPFAutorizadoTotal, lblCNPJCPFAutorizadoTotal, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoAutorizadoTotal = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarAutorizadoTotal()

        Try

            'Carrega Controles
            With grdAutorizadoTotal.CurrentRow

                txtCNPJCPFAutorizadoTotal.Text = .Cells("numero_documento").Value
                btnSalvarAutorizadoTotal.Tag = .Cells("codigo").Value

            End With

            'Seta Focu
            txtCNPJCPFAutorizadoTotal.Focus()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub SalvarAutorizadoTotal()
        Try

            oClsFatEmissaoMDFe.CNPJCPFAutorizados = txtCNPJCPFAutorizadoTotal.Text

            'Verifica operação
            If IsNumeric(btnSalvarAutorizadoTotal.Tag) Then
                oClsFatEmissaoMDFe.UpdateAutorizado(btnSalvarAutorizadoTotal.Tag)
            Else
                oClsFatEmissaoMDFe.InsertAutorizado(grdAutorizadoTotal)
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirAutorizadoTotal()
        Try
            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdAutorizadoTotal) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsFatEmissaoMDFe.DeleteAutorizado()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End If
            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

#Region "::: INFORMAÇÕES ADICIONAIS :::"

    Private Sub SalvarInformacoesAdicionais()
        Try

            oClsFatEmissaoMDFe.InformacaoAdicionalFisco = txtDadosAdicionaisFISCO.Text
            oClsFatEmissaoMDFe.InformacaoAdicionalContribuinte = txtDadosAdicionais.Text

            'Verifica operacao
            If IsNumeric(btnSalvar.Tag) Then
                oClsFatEmissaoMDFe.UpdateInformacoesAdicionais()
            Else
                oClsFatEmissaoMDFe.InsertInformacoesAdicionais()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirInformacoesAdicionais()
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Exclui Registro
            Call oClsFatEmissaoMDFe.DeleteInformacoesAdicionais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: MANIFESTO DE DOCUMENTOS ELETRÔNICO :::"

    Private Function ValidacaoMDFe() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoMDFe = False

            'Verifica a configuração
            If LoadConfiguracaoMDFe() = False Then
                frmMain.Informacao(Mensagem.NaoFoiInformado, "a Configuração do MDFe")
                Exit Function
            Else

                'Ambiente
                Select Case goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe
                    Case TipoAmbienteNFe.homologacao : lblAmbiente.Text = "** Ambiente de Homologação"
                    Case TipoAmbienteNFe.producao : lblAmbiente.Text = "** Ambiente de Produção"
                End Select

                'Verifica se existe a pasta de entrada
                If Directory.Exists(goConfiguracaoMDFe.sPastaEntrada) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoMDFe.sPastaEntrada)
                    Exit Function
                End If

                'Verifica se existe a pasta de envio
                If Directory.Exists(goConfiguracaoMDFe.sPastaEnvio) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoMDFe.sPastaEnvio)
                    Exit Function
                End If

                'Verifica se existe a pasta de impressao
                If Directory.Exists(goConfiguracaoMDFe.sPastaImpressao) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoMDFe.sPastaImpressao)
                    Exit Function
                End If

                'Verifica se existe a pasta de Recibo 
                If Directory.Exists(goConfiguracaoMDFe.sPastaRecibo) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoMDFe.sPastaRecibo)
                    Exit Function
                End If

                'Verifica se existe a pasta de Saída
                If Directory.Exists(goConfiguracaoMDFe.sPastaSaida) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoMDFe.sPastaSaida)
                    Exit Function
                End If

                'Verifica se existe a pasta de XSD
                If Directory.Exists(goConfiguracaoMDFe.sPastaXSD) = False Then
                    frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoMDFe.sPastaXSD)
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            ValidacaoMDFe = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

    Private Sub TransmitirLote()

        'Váriaveis Locais
        Dim oClsMDFeRecepcaoLote As New clsMDFe_RecepcaoLote_V3

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            ''Gera Número do manifesto
            'If txtNumeroDocumento.Text = "0" Or txtNumeroDocumento.Text = "" Then
            '    txtNumeroDocumento.Text = oClsFatEmissaoMDFe.GeraNumeroManifestoEletronico
            'End If

            ''Gera Número do Lote
            'txtLote.Text = oClsFatEmissaoMDFe.GeraNumeroLote

            'Seta Parâmetros - Lote
            oClsMDFeRecepcaoLote.Lote = CLng(txtLote.Text)
            oClsMDFeRecepcaoLote.CodigoEmissaoCapa = oClsFatEmissaoMDFe.CodigoEmissaoCapa

            'Transmite Arquivo
            If oClsMDFeRecepcaoLote.Send() = True Then

                'Carrega Arquivo
                oClsMDFeRecepcaoLote.LoadArquivo(oClsMDFeRecepcaoLote.PathArquivoRetorno)

                'Caso o Status Lote Recebido com Sucesso
                If oClsMDFeRecepcaoLote.Status = 103 Then

                    'Atualiza Dados da MDFe
                    oClsFatEmissaoMDFe.UpdateMDFeEnvio(oClsMDFeRecepcaoLote.Motivo, _
                                                     oClsMDFeRecepcaoLote.ChaveAcesso, _
                                                     oClsMDFeRecepcaoLote.Recibo, _
                                                     oClsMDFeRecepcaoLote.ArquivoEnvio, _
                                                     oClsMDFeRecepcaoLote.ArquivoRetorno, _
                                                     CLng(txtLote.Text), _
                                                     goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe)

                    'Seta Controles
                    txtStatusMDFe.Text = "AGUARDANDO RETORNO"
                    txtStatusMDFe.Tag = StatusManifestoEletronico.AguardandoRetorno
                    txtMensagemSefaz.Text = oClsMDFeRecepcaoLote.Motivo
                    txtChaveAcesso.Text = oClsMDFeRecepcaoLote.ChaveAcesso
                    txtRecibo.Text = oClsMDFeRecepcaoLote.Recibo

                    'Verifica Status
                    Call VerificaStatus(StatusManifestoEletronico.AguardandoRetorno)

                End If

            Else

                'Seta Chave de Acesso
                txtChaveAcesso.Text = oClsMDFeRecepcaoLote.ChaveAcesso
                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsMDFeRecepcaoLote.MensagemErro)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RetornarLote()

        'Váriaveis Locais
        Dim oClsMDFeConsultaRecepcao As New clsMDFe_ConsultaRecepcaoLote_V3

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmetros
            oClsMDFeConsultaRecepcao.Lote = txtLote.Text.Trim
            oClsMDFeConsultaRecepcao.Recibo = txtRecibo.Text.Trim

            'Consulta Situação
            If oClsMDFeConsultaRecepcao.Send() = True Then

                'Carrega Arquivo
                oClsMDFeConsultaRecepcao.LoadArquivo(oClsMDFeConsultaRecepcao.PathArquivoRetorno)

                'Verifica se foi o Arquivo está aceito
                If oClsMDFeConsultaRecepcao.Status = 104 Then

                    'Váriavel - Protocolo
                    Dim oProtocoloMDFe As InformacaoProtocoloMDFe

                    For i = 0 To UBound(oClsMDFeConsultaRecepcao.ProtocoloMDFe)

                        oProtocoloMDFe = oClsMDFeConsultaRecepcao.ProtocoloMDFe(i)

                        'Atualiza Nota Fiscal
                        oClsFatEmissaoMDFe.UpdateMDFeRetorno(oProtocoloMDFe.sMotivo, _
                                                           oProtocoloMDFe.sChaveAcesso, _
                                                           oProtocoloMDFe.sNumeroProtocolo, _
                                                           IIf(oProtocoloMDFe.iStatus = 100, CInt(StatusManifestoEletronico.AutorizadaUso), CInt(StatusManifestoEletronico.Rejeitada)), _
                                                           oClsMDFeConsultaRecepcao.ArquivoRetornoXML)

                        Select Case oProtocoloMDFe.iStatus

                            Case 100
                                'Seta Controles
                                txtStatusMDFe.Text = "AUTORIZADA PARA USO"
                                txtStatusMDFe.Tag = StatusManifestoEletronico.AutorizadaUso
                                'Executa Integração
                                'Call Integracao()

                            Case 539
                                'Obtém Número do Recibo
                                Dim sNumeroRecibo As String = oProtocoloMDFe.sMotivo.Substring(oProtocoloMDFe.sMotivo.IndexOf("[nRec:") + 6, 15)
                                'Obtém Chave de Acessl
                                Dim sChaveAcesso As String = oProtocoloMDFe.sMotivo.Substring(oProtocoloMDFe.sMotivo.IndexOf("[chMDFe:") + 7, 44)

                                'Atualiza tb_fat_emissao_capa
                                oClsFatEmissaoMDFe.UpdateMDFeEnvioDuplicidade(txtChaveAcesso.Text.Trim, _
                                                                            sChaveAcesso, _
                                                                            sNumeroRecibo, _
                                                                            goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe)
                                'Seta Controles
                                txtRecibo.Text = sNumeroRecibo
                                txtChaveAcesso.Text = sChaveAcesso

                            Case Else
                                'Seta Controle
                                txtStatusMDFe.Text = "REJEITADA"
                                txtStatusMDFe.Tag = StatusManifestoEletronico.Rejeitada

                        End Select



                        'Seta Controle
                        txtMensagemSefaz.Text = oProtocoloMDFe.sMotivo
                        txtProtocolo.Text = oProtocoloMDFe.sNumeroProtocolo

                        'Verifica Status
                        Call VerificaStatus(txtStatusMDFe.Tag)

                    Next

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oClsMDFeConsultaRecepcao.Motivo)
                    txtStatusMDFe.Text = oClsMDFeConsultaRecepcao.Motivo
                    txtStatusMDFe.Tag = StatusManifestoEletronico.Rejeitada

                    'Verifica Status
                    Call VerificaStatus(txtStatusMDFe.Tag)
                End If

            Else

                'Informa o Usuário sobre o Erro Ocorrido
                frmMain.Informacao(Mensagem.Erro, oClsMDFeConsultaRecepcao.MensagemErro)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirDamfe(ByVal sCodigoEmissaoCapa As String)

        Try

            'Verifica se o Usuário tem Direito de Imprimir Danfe
            If VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcPrint) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
                goCrystalReport.sReportParameter(0).sValue = sCodigoEmissaoCapa
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000003_MDFE.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                frmMain.LoadPageReport("FAT000000003", "DAMFE - Documento Auxiliar de Manifesto Eletrônico", oReport)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CancelarMDFe(ByVal lCodigoEmissaoCapa As Long, _
                             ByVal iStatus As Integer)

        Try

            'Verifica se o Usuário tem Direito de Cancelar a Nota Fiscal
            If VerificaDireito(Formulario.FaturamentoEmissaoMDFe, gcAdministrator) = True Then

                'Verifica o Status da Nota Fiscal
                If iStatus = CInt(StatusManifestoEletronico.AutorizadaUso) Or iStatus = CInt(StatusManifestoEletronico.EnviadoDestinatario) Then

                   

                        'Váriavel - Formulário
                        Dim oForm As New frmFatEmissaoMDFeCancelar

                    'Seta Paramentros
                    oForm.Grid = grdListagem
                    'oForm.ChaveAcesso = grdListagem.CurrentRow.Cells.Item("chave_acesso").Value
                    'oForm.Protocolo = grdListagem.CurrentRow.Cells.Item("numero_protocolo").Value
                    'oForm.Serie = grdListagem.CurrentRow.Cells.Item("serie").Value

                        Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                        ''Recarrega Grid
                        Call LoadGrid()



                Else
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

    Private Sub EmailMDFe(ByVal lCodigoEmissaoCapa As Long, _
                         ByVal iStatus As Integer)

        Try

            'Verifica o Status
            If iStatus = CInt(StatusManifestoEletronico.AutorizadaUso) Or _
               iStatus = CInt(StatusManifestoEletronico.EnviadoDestinatario) Or _
               iStatus = CInt(StatusManifestoEletronico.Cancelada) Then

                'Carrega Dados do Emitente
                Call LoadDadosEmitente()

                'Carrega Configurações da NFe
                Call LoadConfiguracaoMDFe()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis Locais
                Dim oClsNFeArquivoEnvio As New clsMDFeArquivoEnvio_V3
                Dim sArquivoEnvio As String = ""
                Dim sMensagemErro As String = ""
                Dim sArquivoNFe As String = ""
                Dim sArquivoProtocoloNFe As String = ""
                Dim sArquivoCancelamentoNFe As String = ""
                Dim sArquivoProtocoloCancelamentoNFe As String = ""
                Dim sNotaFiscal As String = ""
                Dim sChaveAcesso As String = ""
                Dim lCodigoParceiroNegocio As Long
                Dim lCodigoTituloCapa As Long

                ''Seta Cursor do Mouse
                'Cursor.Current = Cursors.WaitCursor

                ''Carrega Dados da Nota Fiscal
                'oClsFatEmissaoMDFe.LoadDadosMdFe(lCodigo, _
                '                              sArquivoNFe, _
                '                              sArquivoProtocoloNFe, _
                '                              sArquivoCancelamentoNFe, _
                '                              sArquivoProtocoloCancelamentoNFe, _
                '                              sChaveAcesso, _
                '                              sNotaFiscal, _
                '                              lCodigoParceiroNegocio,
                '                              lCodigoTituloCapa)

                'Dim oSaveFile As New SaveFileDialog


                'oSaveFile.FileName = IIf(sArquivoCancelamentoNFe = "", "", "canc_") & sChaveAcesso & "-nfe.xml"
                'oSaveFile.Filter = "XML|*.xml"

                ''Seta o camino padrão do sistema; caso contrario não faz nada
                'Try : oSaveFile.InitialDirectory = gcDefaultCaminhoArquivoXML : Catch ex As Exception : End Try

                'If oSaveFile.ShowDialog() = DialogResult.OK Then

                '    'Verifica se foi possível gerar o Arquivo
                '    If oClsNFeArquivoEnvio.ArquivoMDFe(sArquivoNFe, _
                '                                      sArquivoProtocoloNFe, _
                '                                      sArquivoCancelamentoNFe, _
                '                                      sArquivoProtocoloCancelamentoNFe, _
                '                                      sChaveAcesso, _
                '                                      oSaveFile.FileName, _
                '                                      sMensagemErro) = False Then

                '        'Informa o Usuário sobre o Erro Ocorrido
                '        frmMain.Informacao(Mensagem.Erro, sMensagemErro)

                '    End If




                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument
                Dim oClsMDFeArquivoEnvio As New clsMDFeArquivoEnvio_V3
                'Dim sArquivoEnvio As String = ""
                Dim sArquivoBoleto As String = ""
                'Dim sMensagemErro As String = ""
                Dim sArquivoMDFe As String = ""
                Dim sArquivoProtocoloMDFe As String = ""
                Dim sArquivoCancelamentoMDFe As String = ""
                Dim sArquivoProtocoloCancelamentoMDFe As String = ""
                Dim sNumeroDocumento As String = ""
                'Dim sChaveAcesso As String = ""
                'Dim lCodigoTituloCapa As Long

                sNumeroDocumento = "0000" & grdListagem.CurrentRow.Cells.Item("numero_documento").Value & "_MDFE"

                'Carrega Dados da Nota Fiscal
                oClsFatEmissaoMDFe.LoadDadosMdFe(lCodigoEmissaoCapa, _
                                              sArquivoMDFe, _
                                              sArquivoProtocoloMDFe, _
                                              sArquivoCancelamentoMDFe, _
                                              sArquivoProtocoloCancelamentoNFe, _
                                              sChaveAcesso, _
                                              sNotaFiscal, _
                                              lCodigoParceiroNegocio,
                                              lCodigoTituloCapa)

                ''Carrega Dados da Nota Fiscal
                'oClsFatEmissaoMDFe.LoadDadosMdFe(lCodigoEmissaoCapa, _
                '                              sArquivoNFe, _
                '                              sArquivoProtocoloNFe, _
                '                              sArquivoCancelamentoNFe, _
                '                              sArquivoProtocoloCancelamentoNFe, _
                '                              sChaveAcesso, _
                '                              sNotaFiscal, _
                '                              lCodigoParceiroNegocio,
                '                              lCodigoTituloCapa)

                'oClsFatEmissaoMDFe.LoadDadosMDF(cboModelo, _
                '                                cboSerie, _
                '                                txtNumeroDocumento, _
                '                                dtpDataEmissao, _
                '                                dtpDataSaida, _
                '                                cboUFCapa, _
                '                                cboTipoEmitente, _
                '                                cboModalidade, _
                '                                cboFormaEmissao, _
                '                                cboUFDescarregamento, _
                '                                txtMensagemSefaz, _
                '                                txtStatusMDFe, _
                '                                txtChaveAcesso, _
                '                                txtRecibo, _
                '                                txtLote, _
                '                                txtProtocolo)

                VerificaStatus(txtStatusMDFe.Tag)

                'Verifica se foi possível gerar o Arquivo
                If oClsMDFeArquivoEnvio.ArquivoMDFe(sArquivoMDFe, _
                                                  sArquivoProtocoloMDFe, _
                                                  sArquivoCancelamentoMDFe, _
                                                  sArquivoProtocoloCancelamentoMDFe, _
                                                  sChaveAcesso, _
                                                  sArquivoEnvio, _
                                                  sMensagemErro) = True Then

                    'Abre Relatório
                    oRptDocument.Load(goCrystalReport.sPath & LoadDescricao("sp_select_faturamento_emissao_relatorio_damdfe " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                    'Seta Parametros Relatório
                    oRptDocument.SetParameterValue("@codigo_emissao_capa", lCodigoEmissaoCapa)
                    oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                    'Abre Conexão com o Banco de Dados
                    For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                        oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                    Next

                    'Váriavel Relatório
                    Dim sArquivoReport As String = goConfiguracaoMDFe.sPastaImpressao & sNumeroDocumento & ".pdf"

                    'Verifica se o Arquivo Existe
                    If File.Exists(sArquivoReport) = True Then File.Delete(sArquivoReport)

                    'Exporta para Arquivo PDF
                    oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

                    'Limpa Váriavel
                    oRptDocument = Nothing

                    'Boleto Bancário
                    If lCodigoTituloCapa > 0 Then
                        'Váriavel - Boleto
                        Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
                        'Carrega Boleto
                        oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNumeroDocumento, sArquivoBoleto)
                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    'Enviar E-mail
                    Call EnviarEmail(goUsuario.sEmpresa & " - MDFe " & sNumeroDocumento & " - Chave de Acesso: " & sChaveAcesso, _
                                     LoadDescricao("sp_select_faturamento_emissao_destinatario_email " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa), _
                                     sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                     sArquivoReport & "; " & sArquivoEnvio & IIf(sArquivoBoleto = "", "", ";" & sArquivoBoleto), _
                                     "", _
                                     1, _
                                     "", _
                                     lCodigoEmissaoCapa)

                    'Carrega Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, sMensagemErro)
                End If

            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExportarXML(ByVal lCodigo As Long)

        Try

            'Váriaveis Locais
            Dim oClsNFeArquivoEnvio As New clsMDFeArquivoEnvio_V3
            Dim sArquivoEnvio As String = ""
            Dim sMensagemErro As String = ""
            Dim sArquivoNFe As String = ""
            Dim sArquivoProtocoloNFe As String = ""
            Dim sArquivoCancelamentoNFe As String = ""
            Dim sArquivoProtocoloCancelamentoNFe As String = ""
            Dim sNotaFiscal As String = ""
            Dim sChaveAcesso As String = ""
            Dim lCodigoParceiroNegocio As Long
            Dim lCodigoTituloCapa As Long

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados da Nota Fiscal
            oClsFatEmissaoMDFe.LoadDadosMDFE(lCodigo, _
                                          sArquivoNFe, _
                                          sArquivoProtocoloNFe, _
                                          sArquivoCancelamentoNFe, _
                                          sArquivoProtocoloCancelamentoNFe, _
                                          sChaveAcesso, _
                                          sNotaFiscal, _
                                          lCodigoParceiroNegocio,
                                          lCodigoTituloCapa)

            Dim oSaveFile As New SaveFileDialog


            oSaveFile.FileName = IIf(sArquivoCancelamentoNFe = "", "", "canc_") & sChaveAcesso & "-nfe.xml"
            oSaveFile.Filter = "XML|*.xml"

            'Seta o camino padrão do sistema; caso contrario não faz nada
            Try : oSaveFile.InitialDirectory = gcDefaultCaminhoArquivoXML : Catch ex As Exception : End Try

            If oSaveFile.ShowDialog() = DialogResult.OK Then

                'Verifica se foi possível gerar o Arquivo
                If oClsNFeArquivoEnvio.ArquivoMDFe(sArquivoNFe, _
                                                  sArquivoProtocoloNFe, _
                                                  sArquivoCancelamentoNFe, _
                                                  sArquivoProtocoloCancelamentoNFe, _
                                                  sChaveAcesso, _
                                                  oSaveFile.FileName, _
                                                  sMensagemErro) = False Then

                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, sMensagemErro)

                End If

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Finalizar(ByVal lCodigoEmissaoCapa As Long, ByVal iStatus As Integer)
        Try
            If iStatus <> 4 Then
                frmMain.Informacao(Mensagem.RegistroNaoPodeAlterado)
                Exit Sub
            End If

            If MsgBox("Deseja finalizar o MDFe?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Finalizar MDF-e") Then
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Inutilização de Numeração
                Dim oEvento_Encerramento As New clsMDFe_Encerramento_V3

                'Seta Paramentros
                oEvento_Encerramento.Chave = grdListagem.GetValue("chave_acesso")
                oEvento_Encerramento.NumeroProtocoloAutorizacao = grdListagem.GetValue("numero_protocolo")
                oEvento_Encerramento.Sequencia = "01"
                oEvento_Encerramento.DataEmissao = Now

                'Cancela NF-e
                If oEvento_Encerramento.Send = True Then

                    'Carrega Arquivo
                    oEvento_Encerramento.LoadArquivo(oEvento_Encerramento.PathArquivoRetorno)

                    'Verifica se foi homologado o cancelamento
                    If oEvento_Encerramento.Status = 135 Or oEvento_Encerramento.Status = 136 Or oEvento_Encerramento.Status = 155 Then

                        Dim oStreamReader As System.IO.StreamReader
                        Dim sXMLEnvio As String
                        oStreamReader = System.IO.File.OpenText(oEvento_Encerramento.ArquivoEnvio)
                        sXMLEnvio = oStreamReader.ReadToEnd
                        oStreamReader.Close()

                        'Atualiza Nota Fiscal Eletrônica
                        oClsFatEmissaoMDFe.UpdateMDFeFinalizar(oEvento_Encerramento.Motivo, _
                                                                        oEvento_Encerramento.Chave, _
                                                                       "", _
                                                                       sXMLEnvio, _
                                                                        oEvento_Encerramento.ArquivoRetorno)



                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)


                    Else
                        'Informa o Usuário sobre o Erro da Operação
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, oEvento_Encerramento.Motivo)
                    End If

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, oEvento_Encerramento.MensagemErro)
                End If

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#End Region

End Class
