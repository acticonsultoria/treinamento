Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrQARelatorioInspecao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrQARelatorioInspecao As New clsUsrQARelatorioInspecao
    Private iFormulario As Integer
    Private lCodigoRelatorioInspecao As Long
#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: QUALIDADE :::"
    Private Sub txtTolerancia_LostFocus(sender As Object, e As EventArgs) Handles txtToleranciaMaxima.LostFocus, txtToleranciaMinima.LostFocus, txtValorNominal.LostFocus
        Try


            If cboClasseTolerancia.SelectedIndex = -1 And IsNumeric(txtValorNominal.Text) Then

                txtValorMinimo.Value = CDbl(txtValorNominal.Text) + txtToleranciaMinima.Value
                txtValorMaximo.Value = CDbl(txtValorNominal.Text) + txtToleranciaMaxima.Value

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Imprimir(txtOrdemProducao.Text.Trim)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub cboEquipamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEquipamento.SelectedIndexChanged
        Try
            Dim iCodigoEquipamento As Integer = IIf(cboEquipamento.SelectedIndex = -1, -1, cboEquipamento.SelectedValue)

            txtCapacidade.Text = LoadCodigo("sp_select_cadastro_basico_equipamento_capacidade " & iCodigoEquipamento & "," & goUsuario.iEmpresa)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnUltimoRegistro_Click(sender As Object, e As EventArgs) Handles btnUltimoRegistro.Click
        Try
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_relatorio_inspecao_codigo " & lCodigoRelatorioInspecao & ", 3, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            lCodigoRelatorioInspecao = lCodigo

            Call Editar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnProximoRegistro_Click(sender As Object, e As EventArgs) Handles btnProximoRegistro.Click
        Try
            Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_relatorio_inspecao_codigo " & lCodigoRelatorioInspecao & ", 2, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            lCodigoRelatorioInspecao = lCodigo

            Editar()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnRegistroAnterior_Click(sender As Object, e As EventArgs) Handles btnRegistroAnterior.Click

        Dim lCodigo As Long = LoadCodigo("sp_load_qualidade_relatorio_inspecao_codigo " & lCodigoRelatorioInspecao & ", 1, " & goUsuario.iEmpresa)

        If lCodigo <= 0 Then
            MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        lCodigoRelatorioInspecao = lCodigo

        Editar()
    End Sub

    Private Sub btnNovaInspecao_Click(sender As Object, e As EventArgs) Handles btnNovaInspecao.Click
        Try
            NovaInspecao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnNovaInspecaoDados_Click(sender As Object, e As EventArgs) Handles btnNovaInspecaoDados.Click
        Try
            NovaInspecao()
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
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

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
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroRIFiltro.Focus()

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

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Valida Formulário
            If Validacao() = True Then

                'Verifica se o usuário deseja reprovar
                If MsgBox("Deseja Salvar a Inspeção de Qualidade?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Salva Dados de Qualidade
                    Call Salvar()



                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 1
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdQualidade.CellUpdated
        Try
            AtualizarLinhaCaracteristica()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key


                Case "editar"
                    lCodigoRelatorioInspecao = grdListagem.GetValue("codigo")
                    Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCaracteristica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCaracteristica.SelectedIndexChanged
        Try

            cboClasseTolerancia.SelectedIndex = -1

            If cboCaracteristica.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboClasseTolerancia, "sp_select_combo_static_classe_tolerancia " & cboCaracteristica.SelectedValue)
            LoadCombo(cboTipo, "sp_select_combo_qualidade_relatorio_inspecao_tipo_caracteristica  " & goUsuario.iEmpresa & ", " & cboCaracteristica.SelectedValue, True)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub CalcularTolerancia() Handles cboClasseTolerancia.SelectedIndexChanged, txtValorNominal.LostFocus


        Try

            If cboClasseTolerancia.SelectedIndex = -1 Or Not IsNumeric(txtValorNominal.Text) Then

                txtToleranciaMinima.Value = 0
                txtToleranciaMaxima.Value = 0
                txtValorMinimo.Value = 0
                txtValorMaximo.Value = 0

                txtToleranciaMaxima.Enabled = True
                txtToleranciaMinima.Enabled = True

            Else

                oClsUsrQARelatorioInspecao.LoadControlesTolerancia(cboCaracteristica.SelectedValue, _
                                                                   cboClasseTolerancia.SelectedValue, _
                                                                   txtValorNominal.Text, _
                                                                   txtToleranciaMinima, _
                                                                   txtToleranciaMaxima, _
                                                                   txtValorMinimo, _
                                                                   txtValorMaximo)

                txtToleranciaMaxima.Enabled = False
                txtToleranciaMinima.Enabled = False
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnInserirCaracteristica_Click(sender As Object, e As EventArgs) Handles btnInserirCaracteristica.Click
        Try
            InserirCaracteristica()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcluirCaracteristica_Click(sender As Object, e As EventArgs) Handles btnExcluirCaracteristica.Click
        Try
            ExcluirCaracteristica()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdQualidade_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdQualidade.RowDoubleClick
        Try
            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdQualidade.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdQualidade.CurrentColumn.Key
                Case "gerar_rnc" : GerarRNC(iCodigoCaracteristica:=grdQualidade.GetValue("codigo"),
                                            sValor:=grdQualidade.GetValue("valor"),
                                            dValorMinimo:=grdQualidade.GetValue("valor_minimo"),
                                            dValorMaximo:=grdQualidade.GetValue("valor_maximo"))
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub cboCaracteristica_TextChanged(sender As Object, e As EventArgs) Handles cboCaracteristica.TextChanged
        Try
            LoadCombo(cboTipo, "sp_select_combo_static_qualidade_tipo_caracteristica_inspecionar", False)
            cboClasseTolerancia.DataSource = Nothing
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub


#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnInserirArquivo_Click(sender As Object, e As EventArgs) Handles btnInserirArquivo.Click

        Try

            frmMain.errInfo.Clear()

            If ValidacaoArquivo() = False Then Exit Sub

            SalvarArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnArquivo_Click(sender As Object, e As EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()


            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(sender As Object, e As EventArgs) Handles btnExcluirArquivo.Click

        Try

            DeleteArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : VisualizarArquivo()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = iFormulario
            oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdArquivo, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario


            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcel.Enabled = VerificaDireito(iFormulario, gcPrint)
            btnInserirArquivo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(iFormulario, gcDelete)

            LoadCombo(cboEquipamento, "sp_select_combo_cadastro_basico_equipamento " & goUsuario.iEmpresa)
            LoadCombo(cboMascaraInspecao, "sp_select_combo_static_mascara_relatorio_inspecao")
            LoadCombo(cboCaracteristica, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa)
            LoadCombo(cboStatus, "sp_select_combo_static_status_relatorio_inspecao")
            LoadCombo(cboNormaInspecao, "sp_select_combo_static_norma_inspecao")
            LoadCombo(cboTipo, "sp_select_combo_static_qualidade_tipo_caracteristica_inspecionar", False)


            'Carrega ComboBox
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)
            Call ConfiguraGrid(grdQualidade, iFormulario)
            Call ConfiguraGrid(grdArquivo, iFormulario)

            'Remove Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroRIFiltro.Focus()


            If Me.Tag.ToString.Contains("ID:") = True Then
                lCodigoRelatorioInspecao = Convert.ToInt64(Me.Tag.ToString.Replace("ID:", ""))
                Editar()
            End If


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub Imprimir(sNumeroOS As String)
        Try

            Dim oFormImprimir As New frmQAImprimir


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "RELATÓRIO INSPEÇÃO"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Carrega Váriavel
            sReport &= ".rpt"

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            If sReport = "QA000000007.rpt" Then

                oFormImprimir.NumeroOS = sNumeroOS
                oFormImprimir.Report = sReport
                oFormImprimir.ShowDialog()

            Else

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_relatorio_inspecao"
                goCrystalReport.sReportParameter(0).sValue = lCodigoRelatorioInspecao
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & sReport

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("QA000000001", "Relatório de Inspeção", oReport)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AtualizarLinhaCaracteristica()
        Try

            oClsUsrQARelatorioInspecao.UpdateLinhaCaracteristica(lCodigoRelatorioInspecao, _
                                                                 grdQualidade.CurrentRow)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub NovaInspecao()
        Try

            Dim lCodigoOP As Long = 0

            Dim oForm As New frmQAFindOP
            oForm.ShowDialog()
            lCodigoOP = oForm.Codigo

            If lCodigoOP = 0 Then Exit Sub

            'Recebe o código criado
            lCodigoRelatorioInspecao = oClsUsrQARelatorioInspecao.InsertRelatorioInspecaoNovo(lCodigoOP)

            'Carrega o os controles
            Call Editar()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsUsrQARelatorioInspecao.LoadGridRelatorioInspecao(grdListagem, _
                                                                      txtNumeroRIFiltro.Text.Trim, _
                                                                      IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                                                      IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""), _
                                                                      txtOrdemProducaoFiltro.Text.Trim, _
                                                                      txtItemFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Novo
                Call Novo()

                Call oClsUsrQARelatorioInspecao.LoadControles(lCodigo:=lCodigoRelatorioInspecao,
                                                              txtNumeroRI:=txtNumeroRI,
                                                              txtOrdemProducao:=txtOrdemProducao,
                                                              txtProduto:=txtProduto,
                                                              txtData:=txtData,
                                                              txtNumeroDesenho:=txtNumeroDesenho,
                                                              txtCliente:=txtCliente,
                                                              txtQuantidadeOP:=txtQuantidadeOP,
                                                              txtQuantidadeInspecao:=txtQuantidadeInspecao,
                                                              txtRevisao:=txtRevisao,
                                                              txtVeiculo:=txtVeiculo,
                                                              txtEstagio:=txtEstagio,
                                                              txtNorma:=txtNorma,
                                                              cboMascaraInspecao:=cboMascaraInspecao,
                                                              chkProdutoSeriado:=chkProdutoSeriado,
                                                              txtNumeroSerieInicial:=txtNumeroSerieInicial,
                                                              txtNumeroSerieTermino:=txtNumeroSerieTermino,
                                                              cboStatusInspecao:=cboStatus,
                                                              cboNormaInspecao:=cboNormaInspecao,
                                                              txtObservacao:=txtObservacao,
                                                              txtInspecaoDimensional:=txtInspecaoDimensional,
                                                              txtNivelInspecao:=txtNivelInspecao,
                                                              txtNivelamento:=txtNivelamento,
                                                              txtAlinhamento:=txtAlinhamento,
                                                              txtOrigem:=txtOrigem,
                                                              txtIdentificacao:=txtIdentificacao,
                                                              txtPintura:=txtPintura,
                                                              txtFornecedor:=txtFornecedor,
                                                              txtAmbiente:=txtAmbiente,
                                                              txtOutros:=txtOutros,
                                                              txtCoordenacao:=txtCoordenacao,
                                                              txtInspecaoVisual:=txtInspecaoVisual)

                oClsUsrQARelatorioInspecao.LoadGridRelatorioInspecaoCaracteristica(grdQualidade, lCodigoRelatorioInspecao)
                oClsUsrQARelatorioInspecao.LoadGridArquivo(grdArquivo, lCodigoRelatorioInspecao)

                If tabMain.SelectedTab.Name <> pagDados.Name Then
                    'Foca Aba
                    tabDados.SelectedTab = UiTabPage1

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)
                End If

                'Seta Focu
                txtQuantidadeInspecao.Focus()

            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Valida os campos
            If Validacao() = False Then Exit Sub

            oClsUsrQARelatorioInspecao.UpdateRelatorioInspecao(lCodigoRelatorioInspecao,
                                                               txtQuantidadeInspecao.Value,
                                                               txtRevisao.Text,
                                                               txtVeiculo.Text,
                                                               txtEstagio.Text,
                                                               txtNorma.Text,
                                                               cboMascaraInspecao.SelectedValue,
                                                               chkProdutoSeriado.Checked,
                                                               txtNumeroSerieInicial.Value,
                                                               txtNumeroSerieTermino.Value,
                                                               cboStatus.SelectedValue,
                                                               IIf(cboNormaInspecao.SelectedIndex = -1, -1, cboNormaInspecao.SelectedValue),
                                                               txtObservacao.Text.Trim,
                                                               txtInspecaoDimensional.Text.Trim,
                                                               txtNivelInspecao.Text.Trim,
                                                               txtNivelamento.Text.Trim,
                                                               txtAlinhamento.Text.Trim,
                                                               txtOrigem.Text.Trim,
                                                               txtIdentificacao.Text.Trim,
                                                               txtPintura.Text.Trim,
                                                               txtFornecedor.Text.Trim,
                                                               txtAmbiente.Text.Trim,
                                                               txtOutros.Text.Trim,
                                                               txtCoordenacao.Text.Trim,
                                                               txtInspecaoVisual.Text.Trim)


            'Informa o usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            frmMain.errInfo.Clear()


            If ValidaCampo(cboMascaraInspecao, lblMascaraInspecao) = False Then Exit Function
            If ValidaCampo(txtQuantidadeInspecao, lblQuantidadeInspecao, True) = False Then Exit Function
            If ValidaCampo(cboStatus, lblStatusInspecao) = False Then Exit Function


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Novo()

        Try

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)

            LimparCamposGroupBox(grpCaracteristicas)
            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpDadosGerais)

            'Limpa Controles
            txtQuantidadeInspecao.Value = 0
            grdQualidade.DataSource = Nothing

            'Limpa Arquivo
            Call NovoArquivo()

            'Limpa Grid
            grdArquivo.DataSource = Nothing

            'Seta Focu
            txtQuantidadeInspecao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirCaracteristica()
        Try
            frmMain.errInfo.Clear()

            If ValidacaoCaracteristica() = False Then Exit Sub

            oClsUsrQARelatorioInspecao.InsertCaracteristica(lCodigoRelatorioInspecao,
                                                            cboCaracteristica.Text.Trim,
                                                            IIf(cboEquipamento.SelectedIndex = -1, -1, cboEquipamento.SelectedValue),
                                                            cboClasseTolerancia.SelectedValue,
                                                            txtToleranciaMinima.Value,
                                                            txtToleranciaMaxima.Value,
                                                            txtValorNominal.Text,
                                                            txtValorMinimo.Value,
                                                            txtValorMaximo.Value,
                                                            txtValorEncontrado.Text,
                                                            txtObservacaoCaracteristica.Text.Trim,
                                                            cboTipo.SelectedValue)

            oClsUsrQARelatorioInspecao.LoadGridRelatorioInspecaoCaracteristica(grdQualidade, _
                                                                               lCodigoRelatorioInspecao)

            Dim sCaracteristica As String = cboCaracteristica.Text
            Dim sClasse As String = cboClasseTolerancia.SelectedValue

            Call LimparCamposGroupBox(grpCaracteristicas)

            cboCaracteristica.Text = sCaracteristica
            cboClasseTolerancia.SelectedValue = sClasse
            frmMain.Informacao("Característica inserida com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirCaracteristica()
        Try
            If grdQualidade.GetCheckedRows.Count = 0 Then

                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Sub
            End If

            If MsgBox("Deseja excluir os itens selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Caracteristica") = vbNo Then Exit Sub

            For Each oRow In grdQualidade.GetCheckedRows

                oClsUsrQARelatorioInspecao.DeleteCaracteristica(lCodigoRelatorioInspecao,
                                                                oRow.Cells.Item("codigo").Value)

            Next

            oClsUsrQARelatorioInspecao.LoadGridRelatorioInspecaoCaracteristica(grdQualidade, lCodigoRelatorioInspecao)

            frmMain.Informacao("Características excluídas com sucesso!", Color.Blue)



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GerarRNC(iCodigoCaracteristica As Integer,
                         sValor As String,
                         dValorMinimo As Double,
                         dValorMaximo As Double)

        Try
            Dim lCodigoRNC As Long

            If IsNumeric(sValor) Then

                If (sValor >= dValorMinimo And sValor <= dValorMaximo) Or (sValor <= dValorMinimo And sValor >= dValorMaximo) Then
                    MsgBox("O registro selecionado foi aprovado, a geração de RNC não é possível.")
                    Exit Sub
                End If
            End If
            If MsgBox("Deseja gerar um Registro de Não Coformidade para essa Ordem de Pordução?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

            'Gera um RNC e salva o codigo do mesmo, usando o codigo da RI
            lCodigoRNC = oClsUsrQARelatorioInspecao.InsertRegistroNaoConformidade(lCodigoRelatorioInspecao, iCodigoCaracteristica)

            EditarRNC(lCodigoRNC)

            frmMain.Informacao("Registro de Não Coformidade gerado com sucesso.", Drawing.Color.AliceBlue)

            LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarRNC(lCodigoRNC As Long)
        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrQARNC")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(lCodigoRNC)

            frmMain.LoadPage("Qualidade - RNC", "Qualidade - Registro de Não Conformidades", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCaracteristica() As Boolean
        Try
            'Seta Retorno da Funcao
            ValidacaoCaracteristica = False
            frmMain.errInfo.Clear()
            If cboCaracteristica.Text = "" Then
                frmMain.errInfo.SetError(lblCaracteristica, "O Campo [" & lblCaracteristica.Text & "] ? obrigat?rio. Digite um valor para ele.")
                cboCaracteristica.Focus()
                Exit Function
            End If
            If ValidaCampo(cboTipo, lblTipo) = False Then Exit Function
            If ValidaCampo(txtValorNominal, lblValorNominal, True) = False Then Exit Function
            'If ValidaCampo(txtValorEncontrado, lblValorEncontrado, True) = False Then Exit Sub
            'Seta Retorno da Funcao
            ValidacaoCaracteristica = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Private Function ValidacaoArquivo() As Boolean

        Try

            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_ordem_producao_manual " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            oClsUsrQARelatorioInspecao.InsertArquivo(lCodigoRelatorioInspecao,
                                                     txtDescricaoArquivo.Text.Trim,
                                                     sFile)

            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrQARelatorioInspecao.LoadGridArquivo(grdArquivo,
                                                       lCodigoRelatorioInspecao)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""

            txtDescricaoArquivo.Focus()

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

                    oClsUsrQARelatorioInspecao.DeleteArquivo(lCodigoRelatorioInspecao)

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

    Private Sub VisualizarArquivo()

        Try

            Process.Start(grdArquivo.GetValue("arquivo"))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

  


#End Region

#End Region

  
   
End Class
