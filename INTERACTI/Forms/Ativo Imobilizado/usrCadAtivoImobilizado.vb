Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO
Imports Microsoft.Office.Interop
Public Class usrCadAtivoImobilizado

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadAtivoFixo As New clsUsrCadAtivoImobilizado
    Private iFormulario As Integer

    Private lCodigoEmissaoCapaAtivo As Long
    Private lCodigoEmissaoItemAtivo As Long
    Private lCodigoEntradaCapaAtivo As Long
    Private lCodigoEntradaItemAtivo As Long

    Private lCodigoEmissaoCapaCusto As Long
    Private lCodigoEmissaoItemCusto As Long
    Private lCodigoEntradaCapaCusto As Long
    Private lCodigoEntradaItemCusto As Long
    Private lCodigoEntradaNFS As Long

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Try

            If e.Button = Windows.Forms.MouseButtons.Right Then

                If CType(sender, Label).Name.ToString.ToUpper.Contains("LBL") And Not CType(sender, Label).Name.ToString.ToUpper.Contains("FILTRO") Then

                    Dim oForm As New frmCadAtivoImobilizadoHelp
                    oForm.txtCampo.Text = CType(sender, Label).Text.Replace(":", "")
                    oForm.txtCampo.Tag = CType(sender, Label).Name

                    oForm.txtFormulario.Text = "CADASTRO DE ATIVO IMOBILIZADO"
                    oForm.txtFormulario.Tag = Me.Name

                    oForm.ShowDialog()

                End If

            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ATIVO :::"

    Private Sub btnProcurarAtivoPai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarAtivoPai.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrFindAtivoImobilizado"
                oForm.Titulo = Me.Parent.Text
                oForm.Tamanho = True
                oForm.Text = "Procurar Ativo Imobilizado Pai"
                iCodigoAtivoPai = oClsUsrCadAtivoFixo.Codigo

                'Seta Parametros
                iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
                oComboBoxFind = cboAtivoPai

                oForm.ShowDialog(Me)

                'Seta Focu
                cboAtivoPai.Focus()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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
            TratamentoErro(ex.Message, Me.Parent.Text)
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
            oForm.ShowDialog(Me)

            ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Delete()

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Limpa Erro
            frmMain.errInfo.Clear()

            Novo()

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Novo()

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
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
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Grid
            LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtNumeroFichaFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar"

                    'Edita o registro
                    Editar(grdListagem.GetValue("codigo"))

                    'Seta Aba
                    tabMain.TabPages.Remove(pagLista)
                    tabMain.TabPages.Add(pagDados)

                    'Seta Focu
                    txtNumeroFicha.Focus()

                Case "historico" : Historico()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem, _
                                iFormulario)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(grdListagem.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportarNotaFiscalAtivo_Click(sender As Object, e As EventArgs) Handles btnImportarNotaFiscalAtivo.Click

        Try

            ImportarNotaFiscalAtivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub FormatarNumeroPatrimonial() Handles cboUnidade.SelectedIndexChanged, txtNumeroFicha.TextChanged, dtpDataDocumento.ValueChanged

        Try

            If txtNumeroFicha.Text = "" Or cboUnidade.SelectedIndex = -1 Or dtpDataAtivacao.Checked = False Then
                txtNumeroPatrimonial.Text = ""
                Exit Sub
            End If

            txtNumeroPatrimonial.Text = oClsUsrCadAtivoFixo.LoadAtivoNumeroPatrimonial(oClsUsrCadAtivoFixo.Codigo, _
                                                                                       cboUnidade.SelectedValue, _
                                                                                       dtpDataAtivacao.Value)



        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub cboCondicaoAquisicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondicaoAquisicao.SelectedIndexChanged

        Try

            'Deixa GroupBox invisivel
            grpDocumentoOrigem.Visible = False

            'Verifica se foi selecionado alguma condição
            If cboCondicaoAquisicao.SelectedIndex <> -1 Then

                Select Case cboCondicaoAquisicao.SelectedValue

                    'Se o tipo condição for usado sem documento origem
                    Case CondicaoAquisicao.UsadoComNotaOrigem

                        'Habilita o groupbox
                        grpDocumentoOrigem.Visible = True

                End Select

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtEstimativaVidaUtilFiscal_ValueChanged(sender As Object, e As EventArgs) Handles txtEstimativaVidaUtilFiscalGrupo.ValueChanged

        Try

            txtTaxaDepreciacaoAnualFiscal.Value = 0
            txtTaxaDepreciacaoMensalFiscal.Value = 0

            If txtEstimativaVidaUtilFiscalGrupo.Value > 0 Then

                txtTaxaDepreciacaoAnualFiscal.Value = 1 / txtEstimativaVidaUtilFiscalGrupo.Value
                txtTaxaDepreciacaoMensalFiscal.Value = txtTaxaDepreciacaoAnualFiscal.Value / 12

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTurnoDepreciacaoFiscal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTurnoDepreciacaoFiscal.SelectedIndexChanged, _
                                                                                                         txtCustoLiquidoTotalAtivoImobilizado.ValueChanged

        Try

            txtTaxaDepreciacaoTurnoFiscal.Value = 0

            If cboTurnoDepreciacaoFiscal.SelectedIndex <> -1 Then

                Select Case cboTurnoDepreciacaoFiscal.SelectedValue

                    'Verifica a quantidade de turnos
                    Case 1
                        txtTaxaDepreciacaoTurnoFiscal.Value = txtTaxaDepreciacaoMensalFiscal.Value
                    Case 2
                        txtTaxaDepreciacaoTurnoFiscal.Value = txtTaxaDepreciacaoMensalFiscal.Value * 1.5
                    Case 3
                        txtTaxaDepreciacaoTurnoFiscal.Value = txtTaxaDepreciacaoMensalFiscal.Value * 2

                End Select

            End If

            txtValorDepreciacaoMensalFiscal.Value = txtTaxaDepreciacaoTurnoFiscal.Value * txtCustoLiquidoTotalAtivoImobilizado.Value

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalcularDepreciacaoEconomica() Handles dtpDataAtivacao.ValueChanged, _
                                                        txtEstimativaValorFinalVidaUtilEconomica.ValueChanged, _
                                                        txtCustoLiquidoTotalAtivoImobilizado.ValueChanged

        Try

            txtVidaRemanescenteEconomica.Value = 0
            txtValorResidualEconomica.Value = 0
            txtValorDepreciavelEconomica.Value = 0

            If dtpDataAtivacao.Checked = True Then

                txtVidaRemanescenteEconomica.Value = (DateDiff(DateInterval.Day, dtpDataAtivacao.Value, Today.Date) / 365)

            End If

            If txtEstimativaValorFinalVidaUtilEconomica.Value > 0 Then

                txtValorResidualEconomica.Value = txtEstimativaValorFinalVidaUtilEconomica.Value * txtCustoLiquidoTotalAtivoImobilizado.Value
                txtValorDepreciavelEconomica.Value = (1 - txtEstimativaValorFinalVidaUtilEconomica.Value) * txtCustoLiquidoTotalAtivoImobilizado.Value
                txtValorDepreciacaoAnualEconomica.Value = txtValorDepreciavelEconomica.Value * txtEstimativaVidaUtilEconomica.Value
                txtValorDepreciacaoMensalEconomica.Value = txtValorDepreciacaoAnualEconomica.Value / 12

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboGrupoAtivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoAtivo.SelectedIndexChanged

        Try

            If cboGrupoAtivo.SelectedIndex <> -1 Then

                txtEstimativaVidaUtilFiscalGrupo.Value = 0
                oClsUsrCadAtivoFixo.LoadControlesGrupoAtivo(cboGrupoAtivo.SelectedValue, _
                                                            -1, _
                                                            txtEstimativaVidaUtilFiscalGrupo)


                If cboAtivoPai.SelectedIndex = -1 Then

                    txtEstimativaVidaUtilFiscalAtivo.Value = 0
                    oClsUsrCadAtivoFixo.LoadControlesGrupoAtivo(cboGrupoAtivo.SelectedValue, _
                                                                -1, _
                                                                txtEstimativaVidaUtilFiscalAtivo)

                Else

                    txtEstimativaVidaUtilFiscalAtivo.Value = 0
                    oClsUsrCadAtivoFixo.LoadControlesGrupoAtivo(cboGrupoAtivo.SelectedValue, _
                                                                cboAtivoPai.SelectedValue, _
                                                                txtEstimativaVidaUtilFiscalAtivo)

                End If

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboAtivoPai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAtivoPai.SelectedIndexChanged

        Try

            If cboAtivoPai.SelectedIndex = -1 Then

                txtEstimativaVidaUtilFiscalGrupo.Value = 0
                txtEstimativaVidaUtilFiscalAtivo.Value = 0

                oClsUsrCadAtivoFixo.LoadControlesGrupoAtivo(cboGrupoAtivo.SelectedValue, _
                                                            -1, _
                                                            txtEstimativaVidaUtilFiscalGrupo)

                oClsUsrCadAtivoFixo.LoadControlesGrupoAtivo(cboGrupoAtivo.SelectedValue, _
                                                            -1, _
                                                            txtEstimativaVidaUtilFiscalAtivo)

            Else

                txtEstimativaVidaUtilFiscalAtivo.Value = 0
                oClsUsrCadAtivoFixo.LoadControlesGrupoAtivo(cboGrupoAtivo.SelectedValue, _
                                                            cboAtivoPai.SelectedValue, _
                                                            txtEstimativaVidaUtilFiscalAtivo)

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CUSTOS :::"

    Private Sub cboTipoCusto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCusto.SelectedIndexChanged

        Try

            Dim bExibir As Boolean = False

            'Verifica se é para exibir. Somente para acessórios
            bExibir = cboTipoCusto.SelectedValue = 2 'acessórios

            'verifica a exibição
            lblNumeroPatrimonialCusto.Visible = bExibir
            txtNumeroPatrimonialCusto.Visible = bExibir
            lblChapaIdentificacaoCusto.Visible = bExibir
            txtChapaIdentificacaoCusto.Visible = bExibir

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirCusto_Click(sender As Object, e As EventArgs) Handles btnExcluirCusto.Click

        Try

            ExcluirCusto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnInserirCusto_Click(sender As Object, e As EventArgs) Handles btnInserirCusto.Click

        Try

            InserirCusto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnNovoCusto_Click(sender As Object, e As EventArgs) Handles btnNovoCusto.Click

        Try

            NovoCusto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnImportarNFCusto_Click(sender As Object, e As EventArgs) Handles btnImportarNFCusto.Click

        Try

            ImportarNFCusto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub grdCusto_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdCusto.RowDoubleClick

        Try

            If grdCusto.CurrentColumn.Key = "editar" Then

                EditarCusto()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

#End Region

#Region "::: FOTO :::"

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click

        Try

            'Variaveis Locais
            Dim arqImagem As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqImagem.InitialDirectory = "c:\\dados"
            arqImagem.Filter = "(Imagens BMP;JPG;GIF;PNG)|*.bmp;*.jpg;*.gif;*.png"
            arqImagem.Title = "Selecione o Arquivo"

            If arqImagem.ShowDialog() = DialogResult.OK Then
                txtLogo.Text = arqImagem.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtLogo_TextChanged(sender As Object, e As EventArgs) Handles txtLogo.TextChanged

        Try

            'Verifica se foi Selecionado alguma Logo
            If txtLogo.Text <> "" Then

                'Carrega Imagem
                Dim oImage As Image = Image.FromFile(txtLogo.Text)

                picFoto.Image = oImage

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirFoto_Click(sender As Object, e As EventArgs) Handles btnExcluirFoto.Click

        Try

            ExcluirFoto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnInserirFoto_Click(sender As Object, e As EventArgs) Handles btnInserirFoto.Click

        Try

            If ValidaCampo(txtLogo, lblLogo, TipoCampo.texto) = False Then
                txtLogo.Focus()
                Exit Sub
            End If

            If ValidaCampo(txtDescricaoFoto, lblDescricaoFoto, TipoCampo.texto) = False Then
                txtDescricaoFoto.Focus()
                Exit Sub
            End If

            InserirFoto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub grdFoto_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdFoto.RowDoubleClick

        Try

            VisualizarArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVOS :::"

    Private Sub btnArquivoAnexoOrigem_Click(sender As Object, e As EventArgs) Handles btnArquivoAnexoOrigem.Click

        Try

            'Variaveis Locais
            Dim arqXML As New OpenFileDialog

            'Carrega o caminho da pasta no servidor
            oClsUsrCadAtivoFixo.LoadCaminhoPasta()

            'Abre PopUp para Usuário selecionar a NFe
            arqXML.InitialDirectory = "c:\\dados"
            arqXML.Filter = "(Arquivo NFe PDF)|*.PDF"
            arqXML.Title = "Selecione o Arquivo"

            If arqXML.ShowDialog() = DialogResult.OK Then

                Dim oFileInfo As New System.IO.FileInfo(arqXML.FileName)
                Dim sFile As String = oClsUsrCadAtivoFixo.Caminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

                'Executa a cópia
                System.IO.File.Copy(arqXML.FileName, sFile)

                txtArquivoAnexoOrigem.Text = sFile

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoAnexoDocumento_Click(sender As Object, e As EventArgs) Handles btnArquivoAnexoDocumento.Click

        Try

            'Variaveis Locais
            Dim arqXML As New OpenFileDialog

            'Carrega o caminho da pasta no servidor
            oClsUsrCadAtivoFixo.LoadCaminhoPasta()

            'Abre PopUp para Usuário selecionar a NFe
            arqXML.InitialDirectory = "c:\\dados"
            arqXML.Filter = "(Arquivo NFe PDF)|*.PDF"
            arqXML.Title = "Selecione o Arquivo"

            If arqXML.ShowDialog() = DialogResult.OK Then

                Dim oFileInfo As New System.IO.FileInfo(arqXML.FileName)
                Dim sFile As String = oClsUsrCadAtivoFixo.Caminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

                'Executa a cópia
                System.IO.File.Copy(arqXML.FileName, sFile)

                txtArquivoAnexoDocumento.Text = sFile

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarArquivoAnexoOrigem_Click(sender As Object, e As EventArgs) Handles btnVisualizarArquivoAnexoOrigem.Click

        Try

            If txtArquivoAnexoOrigem.Text <> "" Then
                VisualizarDocumento(txtArquivoAnexoOrigem.Text)
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarArquivoAnexoDocumento_Click(sender As Object, e As EventArgs) Handles btnVisualizarArquivoAnexoDocumento.Click

        Try

            If txtArquivoAnexoDocumento.Text <> "" Then
                VisualizarDocumento(txtArquivoAnexoDocumento.Text)
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarArquivoAnexo_Click(sender As Object, e As EventArgs) Handles btnVisualizarArquivoAnexo.Click

        Try

            If txtArquivoAnexoCusto.Text <> "" Then
                VisualizarDocumento(txtArquivoAnexoCusto.Text)
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoAnexoCusto_Click(sender As Object, e As EventArgs) Handles btnArquivoAnexoCusto.Click

        Try

            'Variaveis Locais
            Dim arqXML As New OpenFileDialog

            'Carrega o caminho da pasta no servidor
            oClsUsrCadAtivoFixo.LoadCaminhoPasta()

            'Abre PopUp para Usuário selecionar a NFe
            arqXML.InitialDirectory = "c:\\dados"
            arqXML.Filter = "(Arquivo NFe PDF)|*.PDF"
            arqXML.Title = "Selecione o Arquivo"

            If arqXML.ShowDialog() = DialogResult.OK Then

                Dim oFileInfo As New System.IO.FileInfo(arqXML.FileName)
                Dim sFile As String = oClsUsrCadAtivoFixo.Caminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

                'Executa a cópia
                System.IO.File.Copy(arqXML.FileName, sFile)

                txtArquivoAnexoCusto.Text = sFile

            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarArquivoAnexoGarantia_Click(sender As Object, e As EventArgs) Handles btnVisualizarArquivoAnexoGarantia.Click

        Try

            If txtArquivoAnexoGarantia.Text <> "" Then
                VisualizarDocumento(txtArquivoAnexoGarantia.Text)
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoAnexoGarantia_Click(sender As Object, e As EventArgs) Handles btnArquivoAnexoGarantia.Click

        Try

            'Variaveis Locais
            Dim arqXML As New OpenFileDialog

            'Carrega o caminho da pasta no servidor
            oClsUsrCadAtivoFixo.LoadCaminhoPasta()

            'Abre PopUp para Usuário selecionar a NFe
            arqXML.InitialDirectory = "c:\\dados"
            arqXML.Filter = "(Arquivo NFe PDF)|*.PDF"
            arqXML.Title = "Selecione o Arquivo"

            If arqXML.ShowDialog() = DialogResult.OK Then

                Dim oFileInfo As New System.IO.FileInfo(arqXML.FileName)
                Dim sFile As String = oClsUsrCadAtivoFixo.Caminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

                'Executa a cópia
                System.IO.File.Copy(arqXML.FileName, sFile)

                txtArquivoAnexoGarantia.Text = sFile
            End If

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))
            AddMouseClick(Me, New DelegateMouseClick(AddressOf usr_MouseClick))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Carrega os combos
            LoadCombo(cboUnidade, "sp_select_combo_static_unidade_ativo", True)

            LoadCombo(cboTipoDocumento, "sp_select_combo_static_tipo_documento_ativo")
            LoadCombo(cboTurnoDepreciacaoFiscal, "sp_select_combo_static_turno_depreciacao")
            LoadCombo(cboCondicaoAquisicao, "sp_select_combo_static_condicao_aquisicao")
            LoadCombo(cboGrupoAtivo, "sp_select_combo_static_grupo_ativo_imobilizado")
            LoadCombo(cboGrupoAtivoFiltro, "sp_select_combo_static_grupo_ativo_imobilizado")
            LoadCombo(cboTipoCusto, "sp_select_combo_static_tipo_custo_ativo")
            LoadCombo(cboStatus, "sp_select_combo_static_status_ativo")
            LoadCombo(cboProprietario, "sp_select_combo_static_proprietario_deposito")
            LoadCombo(cboCentroCustoAtivo, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            LoadCombo(cboAtivoPai, "sp_select_combo_cadastro_basico_ativo_pai " & goUsuario.iEmpresa)
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil_ativo_imobilizado " & goUsuario.iEmpresa)

            grpDocumentoOrigem.Visible = False

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdCusto, iFormulario)
            ConfiguraGrid(grdFoto, iFormulario)

            lblValorCOFINS.Text = "(N/A) Valor COFINS:"

            'Seta Focu
            txtNumeroFichaFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ATIVO :::"

    Private Sub ImportarNotaFiscalAtivo()

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmFindNotaFiscalAtivoImobilizado

            txtNumeroDocumento.Tag = 0
            dtpDataDocumento.Tag = 0
            txtFornecedor.Tag = 0
            txtNCM.Tag = 0

            'Seta tipo documento = NOTA FISCAL
            cboTipoDocumento.SelectedValue = 1
            oForm.txtIdentificacao = txtIdentificacaoAtivo

            oForm.txtNumeroDocumento = txtNumeroDocumento
            oForm.dtpDataEntrada = dtpDataDocumento
            oForm.txtFornecedor = txtFornecedor
            oForm.txtCNPJCPFFornecedor = txtCNPJCPFFornecedor
            oForm.txtChaveAcesso = txtChaveAcesso
            oForm.txtArquivoAnexoDocumento = txtArquivoAnexoDocumento
            oForm.txtNumeroDI = txtNumeroDI
            oForm.txtNCM = txtNCM
            oForm.txtCustoBruto = txtCustoBruto
            oForm.txtValorFrete = txtValorFrete
            oForm.txtValorICMS = txtValorICMS
            oForm.txtValorIPI = txtValorIPI
            oForm.txtValorPIS = txtValorPIS
            oForm.txtValorCOFINS = txtValorCOFINS
            oForm.txtCustoLiquido = txtCustoLiquido

            'Abre Formulário
            oForm.ShowDialog(Me)

            lCodigoEmissaoCapaAtivo = txtNumeroDocumento.Tag
            lCodigoEmissaoItemAtivo = dtpDataDocumento.Tag
            lCodigoEntradaCapaAtivo = txtFornecedor.Tag
            lCodigoEntradaItemAtivo = txtNCM.Tag

            chkIdentificacaoNotaFiscal.Checked = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oForm As New frmLogAlteracao
            oForm.Tabela = "tb_cad_ativo_imobilizado"
            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo").Value

            oForm.ShowDialog()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigo As Long)

        Try

            'Limpa Formulário
            Novo()

            oClsUsrCadAtivoFixo.Codigo = lCodigo

            oClsUsrCadAtivoFixo.LoadControlesAtivo(cboUnidade, _
                                                   txtNumeroFicha, _
                                                   txtNumeroPatrimonial, _
                                                   txtNumeracaoEmpresa, _
                                                   txtChapaIdentificacao, _
                                                   txtDescricao, _
                                                   cboStatus, _
                                                   cboGrupoAtivo, _
                                                   dtpDataAtivacao, _
                                                   cboProprietario, _
                                                   txtCustoLiquidoAquisicaoTransferencia, _
                                                   txtCustoLiquidoInstalacaoAcessorios, _
                                                   txtCustoLiquidoTotalAtivoImobilizado, _
                                                   cboCondicaoAquisicao, _
                                                   txtNumeroDocumentoOrigem, _
                                                   dtpDataDocumentoOrigem, _
                                                   txtFornecedorOrigem, _
                                                   txtChaveAcessoOrigem, _
                                                   txtArquivoAnexoOrigem, _
                                                   cboTipoDocumento, _
                                                   txtNumeroDocumento, _
                                                   dtpDataDocumento, _
                                                   txtFornecedor, _
                                                   txtCNPJCPFFornecedor, _
                                                   txtChaveAcesso, _
                                                   txtNCM, _
                                                   txtNumeroDI, _
                                                   txtArquivoAnexoDocumento, _
                                                   txtCustoBruto, _
                                                   txtValorICMS, _
                                                   txtValorIPI, _
                                                   txtValorPIS, _
                                                   txtValorCOFINS, _
                                                   txtValorFrete, _
                                                   txtCustoLiquido, _
                                                   txtModeloAtivo, _
                                                   txtNumeroSerieFabricanteAtivo, _
                                                   txtIdentificacaoAtivo, _
                                                   txtOutrasCaracteristicasAtivo, _
                                                   txtResponsavelDepartamentoAtivo, _
                                                   txtResponsavelCadastroAtivo, _
                                                   cboCentroCustoAtivo, _
                                                   cboContaContabil, _
                                                   txtLocalizacaoAtivo, _
                                                   txtObservacaoAtivo, _
                                                   txtEstimativaVidaUtilFiscalGrupo, _
                                                   txtTaxaDepreciacaoAnualFiscal, _
                                                   txtTaxaDepreciacaoMensalFiscal, _
                                                   cboTurnoDepreciacaoFiscal, _
                                                   txtTaxaDepreciacaoTurnoFiscal, _
                                                   txtValorDepreciacaoMensalFiscal, _
                                                   txtValorTotalDepreciadoFiscal, _
                                                   txtSaldoDepreciacaoFiscal, _
                                                   txtEstimativaVidaUtilEconomica, _
                                                   txtEstimativaValorFinalVidaUtilEconomica, _
                                                   txtVidaRemanescenteEconomica, _
                                                   txtValorResidualEconomica, _
                                                   txtValorDepreciavelEconomica, _
                                                   txtValorDepreciacaoAnualEconomica, _
                                                   txtValorDepreciacaoMensalEconomica, _
                                                   txtValorTotalDepreciadoEconomica, _
                                                   txtSaldoDepreciacaoEconomica, _
                                                   txtJustificativaVidaUtilEconomica, _
                                                   dtpDataInicioGarantia, _
                                                   dtpDataTerminoGarantia, _
                                                   txtArquivoAnexoGarantia, _
                                                   txtTermosGarantia, _
                                                   chkIdentificacaoNotaFiscal, _
                                                   lCodigoEmissaoCapaAtivo, _
                                                   lCodigoEmissaoItemAtivo, _
                                                   lCodigoEntradaCapaAtivo, _
                                                   lCodigoEntradaItemAtivo, _
                                                   cboAtivoPai, _
                                                   txtCodigoProduto)

            'Carrega os custos
            oClsUsrCadAtivoFixo.LoadGridCusto(grdCusto)

            'Carrega as fotos
            oClsUsrCadAtivoFixo.LoadGridFoto(grdFoto)

            txtCustoLiquidoInstalacaoAcessorios.Value = grdCusto.GetTotalRow.Cells("custo_total").Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrCadAtivoFixo.Delete()

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

            'LImpa os campos
            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpDadosAquisicao)
            LimparCamposGroupBox(grpDocumentoOrigem)
            LimparCamposGroupBox(grpDadosAdicionais)
            LimparCamposGroupBox(grpDadosAcessorios)
            LimparCamposGroupBox(grpDepreciacaoFiscal)
            LimparCamposGroupBox(grpDepreciacaoEconomica)
            LimparCamposGroupBox(grpGarantia)
            LimparCamposGroupBox(grpFoto)

            'Limpa chk
            chkIdentificacaoNotaFiscal.Checked = False

            'Limpa as variáveis
            lCodigoEmissaoCapaAtivo = 0
            lCodigoEmissaoItemAtivo = 0
            lCodigoEntradaCapaAtivo = 0
            lCodigoEntradaItemAtivo = 0

            lCodigoEmissaoCapaCusto = 0
            lCodigoEmissaoItemCusto = 0
            lCodigoEntradaCapaCusto = 0
            lCodigoEntradaItemCusto = 0
            lCodigoEntradaNFS = 0

            'Zera a variavel
            oClsUsrCadAtivoFixo.Codigo = 0

            'Limpa Controles - custo
            grdCusto.DataSource = Nothing

            'Limpa Controles - foto
            grdFoto.DataSource = Nothing

            'Seta foco da Tab
            tabDados.TabPages("pagDadosAtivo").Selected = True

            'Seta Focu
            txtNumeroFicha.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Registro novo
            If oClsUsrCadAtivoFixo.Codigo = 0 Then

                'Insere o registro e armazena na variavel interna 
                oClsUsrCadAtivoFixo.Insert()

                'Carrega os dados
                txtNumeroFicha.Text = LoadCodigo("sp_select_cadastro_basico_ativo_imobilizado_numero_ficha " & CStr(oClsUsrCadAtivoFixo.Codigo) & "," & CStr(goUsuario.iEmpresa))

            End If


            Dim sNumeroFicha As String = ""
            Dim sNumeroPatrimonial As String = ""
            Dim sNumeroAtivo As String = ""

            'Agora atualiza 
            oClsUsrCadAtivoFixo.Update(sUnidade:=cboUnidade.SelectedValue, _
                                       sNumeroFicha:=sNumeroFicha, _
                                       sNumeroPatrimonial:=sNumeroPatrimonial, _
                                       sNumeroAtivo:=sNumeroAtivo, _
                                       sNumeracaoEmpresa:=txtNumeracaoEmpresa.Text, _
                                       sChapaIdentificacao:=txtChapaIdentificacao.Text, _
                                       sDescricao:=txtDescricao.Text, _
                                       iStatus:=cboStatus.SelectedValue, _
                                       iCodigoGrupoAtivo:=cboGrupoAtivo.SelectedValue, _
                                       sDataAtivacao:=IIf(dtpDataAtivacao.Checked = True, dtpDataAtivacao.Value, ""), _
                                       iCodigoProprietario:=IIf(cboProprietario.SelectedIndex = -1, 0, cboProprietario.SelectedValue), _
                                       dCustoLiquidoAquisicaoTransferencia:=txtCustoLiquidoAquisicaoTransferencia.Value, _
                                       dCustoLiquidoInstalacaoAcessorios:=txtCustoLiquidoInstalacaoAcessorios.Value, _
                                       dCustoLiquidoTotalAtivoImobilizado:=txtCustoLiquidoTotalAtivoImobilizado.Value, _
                                       iCondicaoAquisicao:=IIf(cboCondicaoAquisicao.SelectedIndex = -1, -1, cboCondicaoAquisicao.SelectedValue), _
                                       sNumeroDocumentoOrigem:=txtNumeroDocumentoOrigem.Text, _
                                       sDataDocumentoOrigem:=IIf(dtpDataDocumentoOrigem.Checked = True, dtpDataDocumentoOrigem.Value, ""), _
                                       sFornecedorOrigem:=txtFornecedorOrigem.Text, _
                                       sChaveAcessoOrigem:=txtChaveAcessoOrigem.Text, _
                                       sArquivoAnexoOrigem:=txtArquivoAnexoOrigem.Text, _
                                       iTipoDocumento:=IIf(cboTipoDocumento.SelectedIndex = -1, -1, cboTipoDocumento.SelectedValue), _
                                       sNumeroDocumento:=txtNumeroDocumento.Text, _
                                       sDataDocumento:=dtpDataDocumento.Value, _
                                       sFornecedor:=txtFornecedor.Text, _
                                       sCnpjCpfFornecedor:=txtCNPJCPFFornecedor.Text, _
                                       sChaveAcesso:=txtChaveAcesso.Text, _
                                       sNCM:=txtNCM.Text, _
                                       sNumeroDI:=txtNumeroDI.Text, _
                                       sArquivoAnexoDocumento:=txtArquivoAnexoDocumento.Text, _
                                       dCustoBruto:=txtCustoBruto.Value, _
                                       dValorICMS:=txtValorICMS.Value, _
                                       dValorIPI:=txtValorIPI.Value, _
                                       dValorPIS:=txtValorPIS.Value, _
                                       dValorCOFINS:=txtValorCOFINS.Value, _
                                       dValorFrete:=txtValorFrete.Value, _
                                       dCustoLiquido:=txtCustoLiquido.Value, _
                                       sModeloAtivo:=txtModeloAtivo.Text, _
                                       sNumeroSerieFabricanteAtivo:=txtNumeroSerieFabricanteAtivo.Text, _
                                       sIdentificacaoAtivo:=txtIdentificacaoAtivo.Text, _
                                       sOutrasCaracteristicasAtivo:=txtOutrasCaracteristicasAtivo.Text, _
                                       sResponsavelDepartamentoAtivo:=txtResponsavelDepartamentoAtivo.Text, _
                                       sResponsavelCadastroAtivo:=txtResponsavelCadastroAtivo.Text, _
                                       iCodigoCentroCustoAtivo:=cboCentroCustoAtivo.SelectedValue, _
                                       sCodigoContaContabilAtivo:=IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                       sLocalizacaoAtivo:=txtLocalizacaoAtivo.Text, _
                                       sObservacaoAtivo:=txtObservacaoAtivo.Text.Trim, _
                                       dEstimativaVidaUtilFiscal:=txtEstimativaVidaUtilFiscalGrupo.Value, _
                                       dTaxaDepreciacaoAnualFiscal:=txtTaxaDepreciacaoAnualFiscal.Value, _
                                       dTaxaDepreciacaoMensalFiscal:=txtTaxaDepreciacaoMensalFiscal.Value, _
                                       iCodigoTurnoDepreciacaoFiscal:=IIf(cboTurnoDepreciacaoFiscal.SelectedIndex = -1, -1, cboTurnoDepreciacaoFiscal.SelectedValue), _
                                       dTaxaDepreciacaoTurnoFiscal:=txtTaxaDepreciacaoTurnoFiscal.Value, _
                                       dValorDepreciacaoMensalFiscal:=txtValorDepreciacaoMensalFiscal.Value, _
                                       dValorTotalDepreciadoFiscal:=txtValorTotalDepreciadoFiscal.Value, _
                                       dSaldoDepreciacaoFiscal:=txtSaldoDepreciacaoFiscal.Value, _
                                       dEstimativaVidaUtilEconomica:=txtEstimativaVidaUtilEconomica.Value, _
                                       dEstimativaValorFinalVidaUtilEconomica:=txtEstimativaValorFinalVidaUtilEconomica.Value, _
                                       dVidaRemanescenteEconomica:=txtVidaRemanescenteEconomica.Value, _
                                       dValorResidualEconomica:=txtValorResidualEconomica.Value, _
                                       dValorDepreciavelEconomica:=txtValorDepreciavelEconomica.Value, _
                                       dValorDepreciacaoAnualEconomica:=txtValorDepreciacaoAnualEconomica.Value, _
                                       dValorDepreciacaoMensalEconomica:=txtValorDepreciacaoMensalEconomica.Value, _
                                       dValorTotalDepreciadoEconomica:=txtValorTotalDepreciadoEconomica.Value, _
                                       dSaldoDepreciacaoEconomica:=txtSaldoDepreciacaoEconomica.Value, _
                                       sJustificativaVidaUtilEconomica:=txtJustificativaVidaUtilEconomica.Text, _
                                       sDataInicioGarantia:=dtpDataInicioGarantia.Value, _
                                       sDataTerminoGarantia:=dtpDataTerminoGarantia.Value, _
                                       sArquivoAnexoGarantia:=txtArquivoAnexoGarantia.Text, _
                                       sTermosGarantia:=txtTermosGarantia.Text, _
                                       lCodigoEmissaoCapa:=lCodigoEmissaoCapaAtivo, _
                                       lCodigoEmissaoItem:=lCodigoEmissaoItemAtivo, _
                                       lCodigoEntradaCapa:=lCodigoEntradaCapaAtivo, _
                                       lCodigoEntradaItem:=lCodigoEntradaItemAtivo, _
                                       iCodigoAtivoPai:=IIf(cboAtivoPai.SelectedIndex = -1, -1, cboAtivoPai.SelectedValue), _
                                       sCodigoProduto:=txtCodigoProduto.Text.Trim)

            txtNumeroPatrimonial.Text = sNumeroPatrimonial

            frmMain.Informacao(Mensagem.RegistroAlterado)

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

            Dim sGrupoAtivo As String

            If cboGrupoAtivoFiltro.SelectionLength > 0 Then

                For i = 0 To UBound(cboGrupoAtivoFiltro.CheckedValues)
                    sGrupoAtivo &= IIf(sGrupoAtivo = "", "", ",") & cboGrupoAtivoFiltro.CheckedValues(i).ToString
                Next

            End If

            oClsUsrCadAtivoFixo.LoadGrid(grdListagem, _
                                         txtNumeroFichaFiltro.Text, _
                                         sGrupoAtivo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtChapaIdentificacao, lblChapaIdentificacao, TipoCampo.texto) = False Then Return False

            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False

            If ValidaCampo(cboStatus, lblStatus) = False Then Return False

            'Dados do ativo
            If ValidaCampo(txtLocalizacaoAtivo, lblLocalizacaoAtivo, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosAdicionaisAtivo
                Return False
            End If

            If ValidaCampo(cboGrupoAtivo, lblGrupoAtivo) = False Then Return False

            If grpDocumentoOrigem.Visible = True Then

                If ValidaCampo(txtNumeroDocumentoOrigem, lblNumeroDocumentoOrigem, TipoCampo.texto) = False Then Return False

                If ValidaCampo(dtpDataDocumentoOrigem, lblDataDocumentoOrigem) = False Then Return False

                If ValidaCampo(txtFornecedorOrigem, lblFornecedorOrigem, TipoCampo.texto) = False Then Return False

            End If

            'Dados de depreceiação
            If txtEstimativaVidaUtilFiscalGrupo.Value = 0 Then
                frmMain.errInfo.SetError(lblEstimativaVidaUtilFiscalGrupo, "O Campo deve ser maior que 0. Digite um valor válido para ele.")
                txtEstimativaVidaUtilFiscalGrupo.Focus()
                tabDados.SelectedTab = pagDadosAtivo
                Return False
            End If


            If ValidaCampo(cboCentroCustoAtivo, lblCentroCustoAtivo) = False Then
                tabDados.SelectedTab = pagDadosAdicionaisAtivo
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CUSTOS :::"

    Private Sub ExcluirCusto()

        Try

            If VerificaSelecaoRow(grdCusto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrCadAtivoFixo.DeleteCusto(grdCusto)

                    oClsUsrCadAtivoFixo.LoadGridCusto(grdCusto)

                    txtCustoLiquidoInstalacaoAcessorios.Value = grdCusto.GetTotalRow.Cells("custo_total").Value

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

    Private Sub InserirCusto()

        Try

            If oClsUsrCadAtivoFixo.Codigo = 0 Then
                'Insere o registro e armazena na variavel interna 
                oClsUsrCadAtivoFixo.Insert()
            End If

            oClsUsrCadAtivoFixo.ChangeCusto(IIf(IsNumeric(btnInserirCusto.Tag), btnInserirCusto.Tag, -1), _
                                            oClsUsrCadAtivoFixo.Codigo, _
                                            IIf(cboTipoCusto.SelectedIndex = -1, -1, cboTipoCusto.SelectedValue), _
                                            txtNumeracaoCusto.Text, _
                                            txtNumeroPatrimonialCusto.Text, _
                                            txtChapaIdentificacaoCusto.Text, _
                                            txtDescricaoCusto.Text, _
                                            txtNumeroDocumentoCusto.Text, _
                                            dtpDataDocumentoCusto.Value, _
                                            txtFornecedorCusto.Text, _
                                            txtCNPJCPFFornecedorCusto.Text, _
                                            txtChaveAcessoCusto.Text, _
                                            txtArquivoAnexoCusto.Text, _
                                            txtCustoBrutoUnitario.Value, _
                                            txtValorFreteCusto.Value, _
                                            txtValorICMSCusto.Value, _
                                            txtValorIPICusto.Value, _
                                            txtValorPISCusto.Value, _
                                            txtValorCOFINSCusto.Value, _
                                            txtCustoLiquidoUnitario.Value, _
                                            txtQuantidadeCusto.Value, _
                                            txtCustoTotal.Value)

            NovoCusto()

            oClsUsrCadAtivoFixo.LoadGridCusto(grdCusto)

            txtCustoLiquidoInstalacaoAcessorios.Value = grdCusto.GetTotalRow.Cells("custo_total").Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoCusto()

        Try

            LimparCamposGroupBox(grpDadosAcessorios)

            btnInserirCusto.Tag = ""
            dtpDataDocumentoCusto.Value = Now.Date

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarNFCusto()

        Try

            If oClsUsrCadAtivoFixo.Codigo = 0 Then
                'Insere o registro e armazena na variavel interna 
                oClsUsrCadAtivoFixo.Insert()
            End If

            'Abre Formulário de Cadastro
            Dim oForm As New frmFindNotaFiscalAtivoImobilizadoAcessorio
            oForm.CodigoAtivo = oClsUsrCadAtivoFixo.Codigo

            'Abre Formulário
            oForm.ShowDialog(Me)

            oClsUsrCadAtivoFixo.LoadGridCusto(grdCusto)
            txtCustoLiquidoInstalacaoAcessorios.Value = grdCusto.GetTotalRow.Cells("custo_total").Value

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarCusto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                With grdCusto.CurrentRow.Cells

                    btnInserirCusto.Tag = .Item("codigo").Value

                    If IsDBNull(.Item("codigo_tipo").Value) = True Then
                        cboTipoCusto.SelectedIndex = -1
                    Else
                        cboTipoCusto.SelectedValue = .Item("codigo_tipo").Value
                    End If

                    txtNumeracaoCusto.Text = .Item("numeracao").Value
                    txtNumeroPatrimonialCusto.Text = .Item("numero_patrimonial").Value
                    txtChapaIdentificacaoCusto.Text = .Item("chapa_identificacao").Value
                    txtDescricaoCusto.Text = .Item("descricao").Value
                    txtNumeroDocumentoCusto.Text = .Item("numero_documento").Value
                    dtpDataDocumentoCusto.Value = .Item("data_documento").Value
                    txtFornecedorCusto.Text = .Item("fornecedor").Value
                    txtCNPJCPFFornecedorCusto.Text = .Item("cnpj_cpf_fornecedor").Value
                    txtChaveAcessoCusto.Text = .Item("chave_acesso").Value
                    txtArquivoAnexoCusto.Text = .Item("arquivo_anexo_documento").Value
                    txtCustoBrutoUnitario.Value = .Item("custo_bruto_unitario").Value
                    txtValorFreteCusto.Value = .Item("valor_frete").Value
                    txtValorICMSCusto.Value = .Item("valor_icms").Value
                    txtValorIPICusto.Value = .Item("valor_ipi").Value
                    txtValorPISCusto.Value = .Item("valor_pis").Value
                    txtValorCOFINSCusto.Value = .Item("valor_cofins").Value
                    txtCustoLiquidoUnitario.Value = .Item("custo_liquido_unitario").Value
                    txtQuantidadeCusto.Value = .Item("quantidade").Value
                    txtCustoTotal.Value = .Item("custo_total").Value


                End With

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

    Private Sub CalculaCusto() Handles txtCustoBrutoUnitario.ValueChanged, _
                                        txtValorFreteCusto.ValueChanged, _
                                        txtValorICMSCusto.ValueChanged, _
                                        txtValorIPICusto.ValueChanged, _
                                        txtValorPISCusto.ValueChanged, _
                                        txtValorCOFINSCusto.ValueChanged, _
                                        txtCustoLiquidoUnitario.ValueChanged, _
                                        txtQuantidadeCusto.ValueChanged
        Try

            txtCustoLiquidoUnitario.Value = (txtCustoBrutoUnitario.Value + _
                                             txtValorFreteCusto.Value) - _
                                             txtValorICMSCusto.Value - _
                                             txtValorIPICusto.Value - _
                                             txtValorPISCusto.Value - _
                                             txtValorCOFINSCusto.Value

            txtCustoTotal.Value = txtCustoLiquidoUnitario.Value * txtQuantidadeCusto.Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FOTO :::"

    Private Sub ExcluirFoto()

        Try

            If VerificaSelecaoRow(grdFoto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Arquivo 
                    System.IO.File.Delete(grdFoto.CurrentRow.Cells("arquivo").Value)

                    'Exclui Registro
                    oClsUsrCadAtivoFixo.DeleteFoto(grdFoto)

                    oClsUsrCadAtivoFixo.LoadGridFoto(grdFoto)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirFoto()

        Try

            If oClsUsrCadAtivoFixo.Codigo = 0 Then
                'Insere o registro e armazena na variavel interna 
                oClsUsrCadAtivoFixo.Insert()
            End If

            Dim sFile As String = "\\192.168.200.200\ACTi\AGROACTi\IMAGENS ATIVO\A_" & Mid(txtNumeroFicha.Text, 3) & "_I" & oClsUsrCadAtivoFixo.LoadDadosFoto(txtNumeroFicha.Text).ToString.PadLeft(2, "0") & ".png"

            System.IO.File.Copy(txtLogo.Text, sFile)

            oClsUsrCadAtivoFixo.ChangeFoto(IIf(IsNumeric(btnInserirFoto.Tag), btnInserirFoto.Tag, -1), _
                                            oClsUsrCadAtivoFixo.Codigo, _
                                            txtDescricaoFoto.Text, _
                                            picFoto, _
                                            sFile)

            txtDescricaoFoto.Text = ""
            picFoto.Image = Nothing
            txtLogo.Text = ""

            oClsUsrCadAtivoFixo.LoadGridFoto(grdFoto)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarFoto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                With grdFoto.CurrentRow.Cells

                    txtDescricaoFoto.Text = .Item("descricao").Value
                    btnInserirFoto.Tag = .Item("codigo").Value

                End With

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

    Private Sub VisualizarArquivo()

        Try

            'Verifica se existe Arquivo
            If IsDBNull(grdFoto.CurrentRow.Cells("arquivo").Value) = False Then

                If System.IO.File.Exists(grdFoto.CurrentRow.Cells("arquivo").Value) = True Then

                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdFoto.CurrentRow.Cells("arquivo").Value)

                Else
                    'Informa o Usuário que o Arquivo associado não é válido
                    frmMain.Informacao("O Arquivo associado a este Registro não é válido.", gColorInformacaoErro)
                End If

            Else
                'Informa o Usuário que não existe Arquivo associado ao Registro
                frmMain.Informacao("Não há Arquivo associado a este Registro.", gColorInformacaoErro)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: CALCULOS :::"

    Private Sub CalcularCustoLiquido() Handles txtCustoBruto.ValueChanged, _
                                               txtValorICMS.ValueChanged, _
                                               txtValorIPI.ValueChanged, _
                                               txtValorPIS.ValueChanged, _
                                               txtValorCOFINS.ValueChanged, _
                                               txtValorFrete.ValueChanged


        Try

            txtCustoLiquido.Value = txtCustoBruto.Value + txtValorFrete.Value - txtValorICMS.Value
            txtCustoLiquidoAquisicaoTransferencia.Value = txtCustoLiquido.Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalcularCustoLiquidoCusto() Handles txtCustoBrutoUnitario.ValueChanged, _
                                                    txtValorICMSCusto.ValueChanged, _
                                                    txtValorIPICusto.ValueChanged, _
                                                    txtValorPISCusto.ValueChanged, _
                                                    txtValorCOFINSCusto.ValueChanged, _
                                                    txtValorFreteCusto.ValueChanged


        Try

            txtCustoLiquidoUnitario.Value = txtCustoBrutoUnitario.Value + txtValorFreteCusto.Value - txtValorICMSCusto.Value
            txtCustoTotal.Value = txtCustoLiquidoUnitario.Value * txtQuantidadeCusto.Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalcularCustoLiquidoTotalAtivoImobilizado() Handles txtCustoLiquidoAquisicaoTransferencia.ValueChanged, _
                                                                    txtCustoLiquidoInstalacaoAcessorios.ValueChanged

        Try

            txtCustoLiquidoTotalAtivoImobilizado.Value = txtCustoLiquidoAquisicaoTransferencia.Value + txtCustoLiquidoInstalacaoAcessorios.Value

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
