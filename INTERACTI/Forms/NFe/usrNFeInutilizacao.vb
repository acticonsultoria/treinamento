Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrNFeInutilizacao

#Region "::: VÁRIAVEIS :::"

    'Váriaveis da Classe
    Private oClsFatEmissaoNFeInutilizacao As New clsUsrFatEmissaoNFeInutilizacao

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrNFeInutilizacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnInutilizarNumeracao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInutilizarNumeracao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Inutiliza Nota Fiscal
                Call InutilizarNumeracaoNFe()

            End If

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFeInutilizarNumeracao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFeInutilizarNumeracao)

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

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Visualizar Impressão
            Call VisualizarImpressao()

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

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboAno.Focus()

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
                Call LoadCombo(cboSerie, "sp_select_combo_configuracao_serie_nota_fiscal " & goUsuario.iEmpresa & ", " & cboModelo.SelectedValue)
            End If

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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoEmissaoNFeInutilizarNumeracao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FaturamentoEmissaoNFeInutilizarNumeracao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEmissaoNFeInutilizarNumeracao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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

            'Carrega Dados da Emissão de Nota Fiscal Eletrônica
            Call LoadConfiguracaoNFe()

            'Verifica Direito
            btnInutilizarNumeracao.Enabled = VerificaDireito(Formulario.FaturamentoEmissaoNFeInutilizarNumeracao, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboModelo, "sp_select_combo_static_modelo_nota_fiscal " & CInt(TipoItem.produto))
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Seta Máximo, Mínimo e Valor do Ano
            Call LoadComboAno(cboAno, 2006, ((DatePart(DateInterval.Year, Now.Date) - 2006) + 10))

            'Desabilita Aba
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

    Private Sub InutilizarNumeracaoNFe()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If MsgBox("Deseja Inutilizaar a Numeração da NFe: " & Format(CInt(txtNotaFiscalInicial.Text), "000000000") & " a " & Format(CInt(txtNotaFiscalFinal.Text), "000000000") & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Inutilização de Numeração
                Dim oNFeInutilizacaoNumeracao As New clsNFeInutilizacaoNumeracao_V4

                'Seta Paramentros
                oNFeInutilizacaoNumeracao.Ano = cboAno.SelectedValue
                oNFeInutilizacaoNumeracao.Modelo = cboModelo.SelectedValue
                oNFeInutilizacaoNumeracao.Serie = cboSerie.Text.Trim
                oNFeInutilizacaoNumeracao.NFeInicial = txtNotaFiscalInicial.Value
                oNFeInutilizacaoNumeracao.NFeFinal = txtNotaFiscalFinal.Value
                oNFeInutilizacaoNumeracao.Justificativa = txtJustificativa.Text.Trim

                'Inutiliza Nota
                If oNFeInutilizacaoNumeracao.Send = True Then

                    'Carrega Arquivo
                    oNFeInutilizacaoNumeracao.LoadArquivo(oNFeInutilizacaoNumeracao.ArquivoRetorno)

                    'Seta Paramentro
                    oClsFatEmissaoNFeInutilizacao.Versao = oNFeInutilizacaoNumeracao.Versao
                    oClsFatEmissaoNFeInutilizacao.ID = oNFeInutilizacaoNumeracao.ID
                    oClsFatEmissaoNFeInutilizacao.CodigoTipoAmbiente = oNFeInutilizacaoNumeracao.CodigoTipoAmbiente
                    oClsFatEmissaoNFeInutilizacao.VersaoAplicativo = oNFeInutilizacaoNumeracao.VersaoAplicativo
                    oClsFatEmissaoNFeInutilizacao.Status = oNFeInutilizacaoNumeracao.Status
                    oClsFatEmissaoNFeInutilizacao.Motivo = oNFeInutilizacaoNumeracao.Justificativa
                    oClsFatEmissaoNFeInutilizacao.UF = goEmitente.sUF
                    oClsFatEmissaoNFeInutilizacao.Ano = oNFeInutilizacaoNumeracao.Ano
                    oClsFatEmissaoNFeInutilizacao.CNPJ = goEmitente.sCNPJ
                    oClsFatEmissaoNFeInutilizacao.Modelo = oNFeInutilizacaoNumeracao.Modelo
                    oClsFatEmissaoNFeInutilizacao.Serie = oNFeInutilizacaoNumeracao.Serie
                    oClsFatEmissaoNFeInutilizacao.NFeInicial = oNFeInutilizacaoNumeracao.NFeInicial
                    oClsFatEmissaoNFeInutilizacao.NFeFinal = oNFeInutilizacaoNumeracao.NFeFinal
                    oClsFatEmissaoNFeInutilizacao.DataProcessamento = oNFeInutilizacaoNumeracao.DataProcessamento
                    oClsFatEmissaoNFeInutilizacao.NumeroProtocolo = oNFeInutilizacaoNumeracao.NumeroProtocolo
                    oClsFatEmissaoNFeInutilizacao.ArquivoEnvio = oNFeInutilizacaoNumeracao.ArquivoEnvio
                    oClsFatEmissaoNFeInutilizacao.ArquivoRetorno = oNFeInutilizacaoNumeracao.ArquivoRetorno
                    oClsFatEmissaoNFeInutilizacao.ArquivoEnvioXML = oNFeInutilizacaoNumeracao.ArquivoEnvioXML
                    oClsFatEmissaoNFeInutilizacao.ArquivoRetornoXML = oNFeInutilizacaoNumeracao.ArquivoRetornoXML

                    If oNFeInutilizacaoNumeracao.Status = 102 Then
                        'Insere Log
                        oClsFatEmissaoNFeInutilizacao.Insert()
                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)
                        'Limpa Controles
                        txtNotaFiscalInicial.Value = 0
                        txtNotaFiscalFinal.Value = 0
                        txtJustificativa.Text = ""
                    Else
                        'Informa o Usuário sobre o Erro Ocorrido
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                    End If

                Else
                    'Informa o Usuário sobre o Erro Ocorrido
                    frmMain.Informacao(Mensagem.Erro, oNFeInutilizacaoNumeracao.MensagemErro)
                End If

            End If

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

            'Limpa Controles
            cboAno.SelectedValue = Now.Year
            cboModelo.SelectedIndex = -1
            cboSerie.SelectedIndex = -1
            txtNotaFiscalInicial.Value = 0
            txtNotaFiscalFinal.Value = 0

            'Seta Focu
            cboAno.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsFatEmissaoNFeInutilizacao.LoadGrid(grdListagem, _
                                                        IIf(IsNumeric(txtNotaFiscalFiltro.Text), txtNotaFiscalFiltro.Text, -1), _
                                                        IIf(IsNumeric(txtSerieFiltro.Text), txtSerieFiltro.Text, -1), _
                                                        IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                                        IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

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

            'Carrega os dados do Emitente
            Call LoadDadosEmitente()

            'Verifica se foi Selecionado o Campo - Ano
            If ValidaCampo(cboAno, lblAno) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modelo
            If ValidaCampo(cboModelo, lblModelo) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Série
            If ValidaCampo(cboSerie, lblSerie) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - N° Nota Fiscal Inicial
            If ValidaCampo(txtNotaFiscalInicial, lblNotaFiscalInicial, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - N° Nota Fiscal Final
            If ValidaCampo(txtNotaFiscalFinal, lblNotaFiscalFinal, True) = False Then
                Exit Function
            End If

            'Verifica se o N° da Nota Fiscal Incial é menor ou Igual ao N° da Nota Fiscal Final
            If txtNotaFiscalInicial.Value > txtNotaFiscalFinal.Value Then
                txtNotaFiscalInicial.Focus()
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Function
            End If

            'Verifica se a Faixa de Inutlização é maior que 1000
            If (CLng(txtNotaFiscalFinal.Value) - CLng(txtNotaFiscalInicial.Value)) > 1000 Then
                txtNotaFiscalInicial.Focus()
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Function
            End If

            'Verifica se existe Nota Fiscal Lançada entre a Nota Fiscal Inial e a Nota Fiscal Final
            oClsFatEmissaoNFeInutilizacao.Ano = cboAno.SelectedValue
            oClsFatEmissaoNFeInutilizacao.Modelo = cboModelo.SelectedValue
            oClsFatEmissaoNFeInutilizacao.Serie = cboSerie.Text
            oClsFatEmissaoNFeInutilizacao.NFeInicial = txtNotaFiscalInicial.Value
            oClsFatEmissaoNFeInutilizacao.NFeFinal = txtNotaFiscalFinal.Value

            Select Case oClsFatEmissaoNFeInutilizacao.ValidaFaixaNumeracao
                Case 1
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Numeração de Nota Fiscal já Inutilizado dentro da Faixa Informada.")
                    txtNotaFiscalInicial.Focus()
                    Exit Function
                Case 2
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Numeração de Nota Fiscal já Utilizado dentro da Faixa Informada.")
                    txtNotaFiscalInicial.Focus()
                    Exit Function
            End Select

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtJustificativa.Focus()
                Exit Function
            End If

            'Carrega Configuração da NFe
            If LoadConfiguracaoNFe() = False Then
                'Informa o Usuário que não existe configuração de Nota Fiscal Eletrônica cadastrada
                frmMain.Informacao(Mensagem.NaoFoiInformado, "a Configuração da NFe")
                Exit Function
            End If

            'Verifica se a Pasta de Entrada Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaEntrada) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaEntrada)
                Exit Function
            End If

            'Verifica se a Pasta de Envio Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaEnvio) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaEnvio)
                Exit Function
            End If

            'Verifica se a Pasta de Impressão Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaImpressao) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaImpressao)
                Exit Function
            End If

            'Verifica se a Pasta de Recibo Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaRecibo) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaRecibo)
                Exit Function
            End If

            'Verifica se a Pasta de Saída Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaSaida) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaSaida)
                Exit Function
            End If

            'Verifica se a Pasta XSD Existe
            If Directory.Exists(goConfiguracaoNFe.sPastaXSD) = False Then
                frmMain.Informacao(Mensagem.DiretorioNaoEncontrado, goConfiguracaoNFe.sPastaXSD)
                Exit Function
            End If

            'Verifica se o Serviço está ativo
            If ValidaServico() = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidaServico() As Boolean

        Try

            'Váriaveis Locais
            Dim oClsNFeStatusServico As New clsNFeStatusServico_V4

            'Envia Arquivo
            If oClsNFeStatusServico.Send() = True Then

                'Carrega Arquivo
                oClsNFeStatusServico.LoadArquivo(oClsNFeStatusServico.ArquivoRetorno)

                'Exclui Arquivo de Envio e Arquivo de Retorno
                File.Delete(oClsNFeStatusServico.ArquivoEnvio)
                File.Delete(oClsNFeStatusServico.ArquivoRetorno)

                If oClsNFeStatusServico.Status <> 107 Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                    Return False
                End If

            Else
                frmMain.Informacao(Mensagem.Erro, oClsNFeStatusServico.MensagemErro)
                Return False
            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(5)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000016.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Nota Fiscal
            goCrystalReport.sReportParameter(2).sParamenter = "@nota_fiscal"
            goCrystalReport.sReportParameter(2).sValue = IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1)
            'Seta Paramentro - Série
            goCrystalReport.sReportParameter(3).sParamenter = "@serie"
            goCrystalReport.sReportParameter(3).sValue = IIf(IsNumeric(txtSerieFiltro.Text.Trim), txtSerieFiltro.Text.Trim, -1)
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(4).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, "NULL")
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(5).sParamenter = "@data_termino"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, "NULL")

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
