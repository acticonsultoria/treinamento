Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO

Public Class usrEstInventario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstInventario As New clsUsrEstInventario

#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrEstInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                        
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboUsuario", "cboUsuarioFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboUsuario : oComboBox(1) = cboUsuarioFiltro
                            Call LoadCombo(oComboBox, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)
                        Case "cboMarcaFiltro" : Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboUsuario" : Call btnCadastrarUsuario_Click(btnCadastrarUsuario, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstInventario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: INVENTÁRIO :::"

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
            oForm.NomeFormulario = Formulario.EstoqueInventario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueInventario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUsuario.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrAdmCadUsuario"
            oForm.Titulo = Me.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega ComboBox
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboUsuario : oComboBox(1) = cboUsuarioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)

            'Seta Focu
            cboUsuario.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados
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

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboPrimeiraContagem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

            'Seta Focu
            cboPrimeiraContagem.Focus()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Desabilita Controles
                grpDadosInventario.Enabled = False
                grpDadosArquivo.Enabled = False

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
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            cboNumeroInventarioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Sub
            End If

            'Imprime Inventário
            Call ImprimirInventario(cboDeposito.SelectedValue, _
                                    dtpDataInventario.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPrimeiraContagem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPrimeiraContagem.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboPrimeiraContagem.SelectedIndex = -1 Then
                cboNumeroInventario.Enabled = False
                cboNumeroInventario.SelectedIndex = -1
            ElseIf cboPrimeiraContagem.SelectedValue = True Then
                cboNumeroInventario.Enabled = False
                cboNumeroInventario.SelectedIndex = -1 : cboNumeroInventario.Text = ""
            ElseIf cboPrimeiraContagem.SelectedValue = False Then
                cboNumeroInventario.Enabled = True
                LoadCombo(cboNumeroInventario, "sp_select_combo_estoque_inventario " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGridInventario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDeposito.SelectedIndexChanged, _
                                                                                                       cboMarcaFiltro.SelectedIndexChanged, _
                                                                                                       cboStatus.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboDeposito.SelectedIndex = -1 Then

                'Limpa Grid
                grdInventario.DataSource = Nothing

            Else

                'Carrega Grid
                Call oClsEstInventario.LoadGridInventario(grdInventario, _
                                                          cboDeposito.SelectedValue, _
                                                          IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                                          IIf(cboStatus.SelectedIndex = -1, -1, cboStatus.SelectedValue), _
                                                          -1)

                'Limpa Controle
                txtArquivoExcel.Text = ""

                'Carrega Configuração do Arquivo
                oClsEstInventario.LoadConfiguracaoArquivoExcel(cboConfiguracaoColunaCodigoProduto, _
                                                               cboConfiguracaoColunaLote, _
                                                               cboConfiguracaoColunaLocalizacao, _
                                                               cboConfiguracaoColunaQuantidade, _
                                                               cboConfiguracaoColunaCustoMedio, _
                                                               cboConfiguracaoColunaDataValidade, _
                                                               cboConfiguracaoColunaDataFabricacao, _
                                                               txtLinhaInicio)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha pressionada
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação Selecionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarInventario()
                Case "aprovar" : Call AprovarInventario()
                Case "reprovar" : Call ReprovarInventario()
                Case "historico" : Call HistoricoInventario()

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
                                     Formulario.EstoqueInventario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.EstoqueInventario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnAgruparGridInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridInventario.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdInventario.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdInventario.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdInventario.GroupByBoxVisible = True
                grdInventario.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridInventario.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdInventario
            oForm.NomeFormulario = Formulario.EstoqueInventario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdInventario, Formulario.EstoqueInventario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridInventario.Click

        Try

            'Exporta Excel
            Call ExportExcel(grdInventario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdInventario_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdInventario.RowDoubleClick

        Try

            'Verifica o Tipo de Linha pressionada
            If IsNothing(grdInventario.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação Selecionada
            Select Case grdInventario.CurrentColumn.Key

                Case "lote" : Call AdicionarLote()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdInventario_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdInventario.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdInventario, _
                                     Formulario.EstoqueInventario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdInventario_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdInventario.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdInventario.Name, _
                                     Formulario.EstoqueInventario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnArquivoExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoExcel.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Código do Item
            If ValidaCampo(cboConfiguracaoColunaCodigoProduto, lblConfiguracaoColunaCodigoProduto) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Localização
            If ValidaCampo(cboConfiguracaoColunaLocalizacao, lblConfiguracaoColunaLocalizacao) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Quantidade
            If ValidaCampo(cboConfiguracaoColunaQuantidade, lblConfiguracaoColunaQuantidade) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Custo Médio
            If ValidaCampo(cboConfiguracaoColunaCustoMedio, lblConfiguracaoColunaCustoMedio) = False Then
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Linha Inicio
            If ValidaCampo(txtLinhaInicio, lblLinhaInicio, True) = False Then
                Exit Sub
            End If

            'Verifica se foi Preenchido o Campo - Planilha
            If ValidaCampo(txtPlanilha, lblPlanilha, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Atualiza Dados
            oClsEstInventario.UpdateConfiguracaoArquivoExcel(cboConfiguracaoColunaCodigoProduto.Text, _
                                                             IIf(cboConfiguracaoColunaLote.SelectedIndex = -1, "", cboConfiguracaoColunaLote.Text), _
                                                             IIf(cboConfiguracaoColunaLocalizacao.SelectedIndex = -1, "", cboConfiguracaoColunaLocalizacao.Text), _
                                                             cboConfiguracaoColunaQuantidade.Text, _
                                                             IIf(cboConfiguracaoColunaCustoMedio.SelectedIndex = -1, "", cboConfiguracaoColunaCustoMedio.Text), _
                                                             IIf(cboConfiguracaoColunaDataValidade.SelectedIndex = -1, "", cboConfiguracaoColunaDataValidade.Text), _
                                                             IIf(cboConfiguracaoColunaDataFabricacao.SelectedIndex = -1, "", cboConfiguracaoColunaDataFabricacao.Text), _
                                                             txtLinhaInicio.Value)


            'Importa Arquivo Excel
            Call ImportarArquivoExcel()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstInventario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo1.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcPrint)
            btnExcelGridInventario.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcPrint)
            btnImprimir.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcPrint)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboNumeroInventario : oComboBox(1) = cboNumeroInventarioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_estoque_inventario " & goUsuario.iEmpresa)
            oComboBox(0) = cboUsuario : oComboBox(1) = cboUsuarioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)
            oComboBox(0) = cboDepositoFiltro : oComboBox(1) = cboDeposito
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_inventario")
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboUnidadeMedidaFiltro, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboPrimeiraContagem)

            'Carrega Combo - Arquivo
            ReDim oComboBox(6)
            oComboBox(0) = cboConfiguracaoColunaCodigoProduto
            oComboBox(1) = cboConfiguracaoColunaLote
            oComboBox(2) = cboConfiguracaoColunaLocalizacao
            oComboBox(3) = cboConfiguracaoColunaQuantidade
            oComboBox(4) = cboConfiguracaoColunaCustoMedio
            oComboBox(5) = cboConfiguracaoColunaDataValidade
            oComboBox(6) = cboConfiguracaoColunaDataFabricacao
            Call LoadComboAZ(oComboBox)

            'Carrega Combo - Status
            cboStatus.Items.Clear()
            cboStatus.Items.Add("ABAIXO DO PONTO REPOSIÇÃO", 1)
            cboStatus.Items.Add("ACIMA DO PONTO REPOSIÇÃO", 2)
            cboStatus.Items.Add("SALDO IGUAL A ZERO", 3)
            cboStatus.Items.Add("SALDO NEGATIVO", 4)
            cboStatus.Items.Add("SALDO POSITIVO", 5)
            cboStatus.Items.Add("PRODUTO VENCIDO", 6)

            'Seta Controles
            dtpDataInventarioInicioFiltro.Value = Now.Date : dtpDataInventarioInicioFiltro.Checked = False
            dtpDataInventarioTerminoFiltro.Value = Now.Date : dtpDataInventarioTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueInventario)
            Call ConfiguraGrid(grdInventario, Formulario.EstoqueInventario)

            'Seta Focu
            cboNumeroInventarioFiltro.Focus()

            'Remove Page
            tabMain.TabPages.Remove(pagDados)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: INVENTÁRIO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sStatus As String = ""
            Dim i As Integer

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid
            oClsEstInventario.LoadGrid(grdListagem, _
                                       IIf(cboNumeroInventarioFiltro.SelectedIndex = -1, "", cboNumeroInventarioFiltro.SelectedValue), _
                                       IIf(cboUsuarioFiltro.SelectedIndex = -1, -1, cboUsuarioFiltro.SelectedValue), _
                                       IIf(dtpDataInventarioInicioFiltro.Checked = False, "", dtpDataInventarioInicioFiltro.Value), _
                                       IIf(dtpDataInventarioTerminoFiltro.Checked = False, "", dtpDataInventarioTerminoFiltro.Value), _
                                       IIf(cboDepositoFiltro.SelectedIndex = -1, -1, cboDepositoFiltro.SelectedValue), _
                                       sStatus)

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

            'Habilita Controles
            grpDadosInventario.Enabled = True
            grpDadosArquivo.Enabled = True
            cboPrimeiraContagem.Enabled = True
            cboNumeroInventario.Enabled = False
            cboUsuario.Enabled = True
            cboDeposito.SelectedIndex = -1
            dtpDataInventario.Enabled = True
            grdInventario.DataSource = Nothing
            grdInventario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcInsert)
            btnSalvar.Tag = ""
            txtArquivoExcel.Text = ""
            txtPlanilha.Text = ""

            'Carrega Configuração do Arquivo
            oClsEstInventario.LoadConfiguracaoArquivoExcel(cboConfiguracaoColunaCodigoProduto, _
                                                             cboConfiguracaoColunaLote, _
                                                             cboConfiguracaoColunaLocalizacao, _
                                                             cboConfiguracaoColunaQuantidade, _
                                                             cboConfiguracaoColunaCustoMedio, _
                                                             cboConfiguracaoColunaDataValidade, _
                                                             cboConfiguracaoColunaDataFabricacao, _
                                                             txtLinhaInicio)

            'Limpa Controles
            cboPrimeiraContagem.SelectedValue = True
            cboNumeroInventario.SelectedIndex = -1
            cboUsuario.SelectedIndex = -1
            dtpDataInventario.Value = Now.Date

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnSalvar.Tag) = False Then

                'Seta Parametros
                oClsEstInventario.PrimeiraContagem = cboPrimeiraContagem.SelectedValue
                oClsEstInventario.NumeroInventario = IIf(cboPrimeiraContagem.SelectedValue = True, oClsEstInventario.LoadNumeroInventario(), cboNumeroInventario.SelectedValue)
                oClsEstInventario.CodigoDeposito = cboDeposito.SelectedValue
                oClsEstInventario.Usuario = cboUsuario.SelectedValue
                oClsEstInventario.DataInventario = dtpDataInventario.Value
                oClsEstInventario.CodigoUnidadeMedida = IIf(cboUnidadeMedidaFiltro.SelectedIndex = -1, -1, cboUnidadeMedidaFiltro.SelectedValue)

                'Insere Dados da Capa
                oClsEstInventario.SalvarCapa()
                btnSalvar.Tag = oClsEstInventario.Codigo

            Else
                oClsEstInventario.Codigo = btnSalvar.Tag
                oClsEstInventario.NumeroInventario = cboNumeroInventario.Text
            End If

            'Remove Filtro
            Dim oFilter As New GridEXFilterCondition
            oFilter = grdInventario.RootTable.FilterCondition
            grdInventario.RootTable.RemoveFilter()

            'Insere Dados da Linha
            oClsEstInventario.DeleteInventarioLinha(btnSalvar.Tag)
            oClsEstInventario.SalvarLinha(grdInventario, _
                                          btnSalvar.Tag)

            'Aplica Filtro
            grdInventario.RootTable.ApplyFilter(oFilter)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboNumeroInventario : oComboBox(1) = cboNumeroInventarioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_estoque_inventario " & goUsuario.iEmpresa)
            cboNumeroInventario.Text = oClsEstInventario.NumeroInventario
            cboNumeroInventario.Tag = ""

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarInventario()

        Try

            'Verifica se o usuário tem direito
            If VerificaDireito(Formulario.EstoqueInventario, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    cboPrimeiraContagem.SelectedValue = IIf(.Item("contagem").Value = 1, True, False)
                    cboNumeroInventario.SelectedValue = .Item("numero_inventario").Value
                    cboUsuario.Text = .Item("usuario").Value
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    dtpDataInventario.Value = .Item("data_inventario").Value
                    cboUnidadeMedidaFiltro.SelectedValue = .Item("codigo_unidade_medida").Value
                    btnSalvar.Tag = .Item("codigo").Value

                    'Carrega Grid de Item
                    Call oClsEstInventario.LoadGridInventario(grdInventario, _
                                                              .Item("codigo_deposito").Value, _
                                                              -1, _
                                                              -1, _
                                                              .Item("codigo").Value)

                    'Desabilita Controles
                    If .Item("status").Value = CInt(StatusInventario.AguardandoAprovacao) Then
                        btnSalvar.Enabled = VerificaDireito(Formulario.EstoqueInventario, gcUpdate)
                        grdInventario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
                    Else
                        btnSalvar.Enabled = False
                        grdInventario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                    End If
                    grpDadosInventario.Enabled = False
                    grpDadosArquivo.Enabled = False

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                btnVoltar.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AprovarInventario()

        Try

            'Verifica se o Usuário tem direito de Aprovar o Inventário
            If VerificaDireito(Formulario.EstoqueInventario, gcAdministrator) = True Then

                'Verifica se o Status do Inventário é Aguardando Aprovação
                If grdListagem.CurrentRow.Cells("status").Value = StatusInventario.AguardandoAprovacao Then

                    'Verifica se o Usuário Aprovar
                    If MsgBox("Deseja Aprovar o Inventário Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.WaitCursor

                        'Exclui Registro
                        oClsEstInventario.AprovarInventario(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                            "INVENTÁRIO APROVADO.")

                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                        'Carrega Grid
                        Call LoadGrid()

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.Default

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
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

    Private Sub ReprovarInventario()

        Try

            'Verifica se o Usuário tem direito de Reprovar o Inventário
            If VerificaDireito(Formulario.EstoqueInventario, gcAdministrator) = True Then

                'Verifica se o Status do Inventário é Aguardando Aprovação
                If grdListagem.CurrentRow.Cells("status").Value = StatusInventario.AguardandoAprovacao Then

                    'Váriavel - Formulário de Reprovar Inventario
                    Dim oForm As New frmEstInventarioReprovar

                    'Seta Parâmetros
                    oForm.txtNumeroInventario.Text = grdListagem.CurrentRow.Cells("numero_inventario").Value
                    oForm.txtNumeroInventario.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                    oForm.txtDataInventario.Text = grdListagem.CurrentRow.Cells("data_inventario").Value
                    oForm.txtUsuario.Text = grdListagem.CurrentRow.Cells("usuario").Value
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Recarrega a Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário que ele não tem Direito
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

    Private Sub HistoricoInventario()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmEstInventarioHistorico

            'Seta Parametros
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Primeira Contagem
            If ValidaCampo(cboPrimeiraContagem, lblPrimeiraContagem) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Primeira Contagem
            If cboPrimeiraContagem.SelectedValue = False Then
                If ValidaCampo(cboNumeroInventario, lblNumeroInventario) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Usuário
            If ValidaCampo(cboUsuario, lblUsuario) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se Alguma Linha é Válida
            For Each oRow As GridEXRow In grdInventario.GetDataRows
                If IsDBNull(oRow.Cells("quantidade_inventario").Value) = False AndAlso oRow.Cells("custo_medio").Value AndAlso _
                    IsNumeric(oRow.Cells("quantidade_inventario").Value) And IsNumeric(oRow.Cells("custo_medio").Value) Then
                    Validacao = True
                    Exit For
                End If
            Next

            If Validacao = False Then
                'Informa o Usuário que não possui Registro Válido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi encontrado Registro com informação preenchida de forma adequada.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ImprimirInventario(ByVal iCodigoDeposito As Integer, _
                                   ByVal sData As String)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(7)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_inventario_capa"
            goCrystalReport.sReportParameter(0).sValue = IIf(cboNumeroInventarioFiltro.SelectedIndex = -1, -1, cboNumeroInventarioFiltro.SelectedValue)
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_deposito"
            goCrystalReport.sReportParameter(1).sValue = cboDeposito.SelectedValue
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_marca"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue)
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_usuario"
            goCrystalReport.sReportParameter(3).sValue = goUsuario.iUsuario
            goCrystalReport.sReportParameter(4).sParamenter = "@status"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboStatus.SelectedIndex = -1, -1, cboStatus.SelectedValue)
            goCrystalReport.sReportParameter(5).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(5).sValue = goUsuario.iEmpresa
            goCrystalReport.sReportParameter(6).sParamenter = "usuario"
            goCrystalReport.sReportParameter(6).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(7).sParamenter = "@codigo_unidade_medida"
            goCrystalReport.sReportParameter(7).sValue = IIf(cboUnidadeMedidaFiltro.SelectedIndex = -1, -1, cboUnidadeMedidaFiltro.SelectedValue)
            goCrystalReport.sReport = goCrystalReport.sPath & "EST000000008.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("EST000000008", "EST000000008 - Inventário do Estoque", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub AdicionarLote()

        Try

            'Váriaveis Locais
            Dim sLote As String = ""

            'Obtém Lote
            sLote = InputBox("Favor informar o número do Lote", "Dados do Lote").ToUpper

            'Verifica se o Lote foi Informado
            If sLote.Trim <> "" Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDataRow As DataRow

                'Verifica se o DataSource é Vazio
                oDataSet = grdInventario.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)

                'Verifica se este Lote Existe
                If oDataTable.Select("(lote = '" & sLote.Trim & "') AND (codigo = " & grdInventario.CurrentRow.Cells("codigo").Value & ")").Count > 0 Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Lote já existe.")
                    Exit Sub
                End If

                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("codigo_produto") = grdInventario.CurrentRow.Cells("codigo_produto").Value
                oDataRow("lote") = sLote.Trim
                oDataRow("descricao") = grdInventario.CurrentRow.Cells("descricao").Value
                oDataRow("localizacao") = grdInventario.CurrentRow.Cells("localizacao").Value
                oDataRow("quantidade_inventario") = DBNull.Value
                oDataRow("custo_medio") = grdInventario.CurrentRow.Cells("custo_medio").Value
                oDataRow("codigo") = grdInventario.CurrentRow.Cells("codigo").Value
                oDataTable.Rows.Add(oDataRow)

                'Configura DataMember
                Call ConfigurarDataMemberGrid(grdInventario)

                'Carrega Grid
                grdInventario.DataSource = oDataSet.DefaultViewManager
                grdInventario.DataMember = oDataSet.Tables(0).TableName

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub ImportarArquivoExcel()

        Try

            'Váriaveis Locais
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx"
            oArquivoExcel.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Variaveis Locais
                Dim oApplication As New Excel.Application
                Dim oWorkbook As Excel.Workbook
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDataRow As DataRow
                Dim sQuery As String
                Dim oMensagem() As MensagemErro
                Dim sLote As String = ""

                'Seta Controles
                txtArquivoExcel.Text = oArquivoExcel.FileName

                'Redimensiona Vetor
                ReDim oMensagem(0)
                oMensagem(0).Linha = ""
                oMensagem(0).Erro = ""

                'Verifica se o DataSource é Vazio
                oDataSet = grdInventario.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Try
                    
                    'Abre o Arquivo            
                    oWorkbook = oApplication.Workbooks.Open(txtArquivoExcel.Text)

                    Try
                        'Seleciona Planilha
                        oWorkbook.Sheets.Item(txtPlanilha.Text.Trim).Select()
                    Catch ex As Exception
                        Throw New Exception("Não foi possível encontrar a Planilha: " & txtPlanilha.Text.Trim & " no Arquivo informado.")
                    End Try

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count
                        'Verifica se acabou os registros
                        If oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoProduto.SelectedIndex + 1).Value Is Nothing Then
                            Exit For
                        End If
                    Next i

                    'Seta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = i
                    frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 1
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = True

                    'Percorre Linha a Linha o Arquivo
                    For i = txtLinhaInicio.Value To oApplication.Rows.Count

                        'Verifica se acabou os registros
                        If oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoProduto.SelectedIndex + 1).Value Is Nothing Then
                            Exit For
                        End If

                        If cboConfiguracaoColunaLote.SelectedIndex <> -1 Then
                            sLote = oWorkbook.Application.Cells(i, cboConfiguracaoColunaLote.SelectedIndex + 1).Value
                        End If

                        'Query
                        sQuery = "(codigo_produto = '" & oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoProduto.SelectedIndex + 1).Value & "')"
                        sQuery &= " AND (lote = '" & sLote & "')"

                        'Atualiza Linha do Inventário                    
                        If oDataTable.Select(sQuery).Length = 0 Then

                            If oDataTable.Select("(codigo_produto = '" & oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoProduto.SelectedIndex + 1).Value & "')").Length > 0 Then

                                'Seleciona Linha
                                oDataRow = oDataTable.Select("(codigo_produto = '" & oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoProduto.SelectedIndex + 1).Value & "')")(0)

                                Dim oDataRowInsert As DataRow

                                'Quantidade
                                If IsNumeric(oWorkbook.Application.Cells(i, cboConfiguracaoColunaQuantidade.SelectedIndex + 1).Value) = False Then
                                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                    oMensagem(UBound(oMensagem)).Linha = i
                                    oMensagem(UBound(oMensagem)).Erro = "A Quantidade informada não é Numérica."
                                End If

                                'Custo Médio
                                If cboConfiguracaoColunaCustoMedio.SelectedIndex > -1 Then
                                    If IsNumeric(oWorkbook.Application.Cells(i, cboConfiguracaoColunaCustoMedio.SelectedIndex + 1).Value) = False Then
                                        If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                        oMensagem(UBound(oMensagem)).Linha = i
                                        oMensagem(UBound(oMensagem)).Erro = "O Custo Médio informado não é Numérico."
                                    End If
                                End If

                                'Adiciona Linhas ao DataTable
                                oDataRowInsert = oDataTable.NewRow
                                oDataRowInsert("marca") = oDataRow("marca").ToString
                                oDataRowInsert("grupo_item") = oDataRow("grupo_item").ToString
                                oDataRowInsert("codigo_produto") = oDataRow("codigo_produto").ToString
                                oDataRowInsert("lote") = sLote
                                oDataRowInsert("descricao") = oDataRow("descricao").ToString
                                oDataRowInsert("localizacao") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaLocalizacao.SelectedIndex + 1).Value
                                oDataRowInsert("quantidade_inventario") = IIf(IsNumeric(oWorkbook.Application.Cells(i, cboConfiguracaoColunaQuantidade.SelectedIndex + 1).Value) = False, DBNull.Value, oWorkbook.Application.Cells(i, cboConfiguracaoColunaQuantidade.SelectedIndex + 1).Value)
                                oDataRowInsert("custo_medio") = IIf(IsNumeric(oWorkbook.Application.Cells(i, cboConfiguracaoColunaCustoMedio.SelectedIndex + 1).Value) = False, DBNull.Value, oWorkbook.Application.Cells(i, cboConfiguracaoColunaCustoMedio.SelectedIndex + 1).Value)
                                oDataRowInsert("data_fabricacao") = IIf(IsDate(oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataFabricacao.SelectedIndex + 1).Value) = False, DBNull.Value, oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataFabricacao.SelectedIndex + 1).Value)
                                oDataRowInsert("data_validade") = IIf(IsDate(oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataValidade.SelectedIndex + 1).Value) = False, DBNull.Value, oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataValidade.SelectedIndex + 1).Value)
                                oDataRowInsert("codigo") = oDataRow("codigo").ToString
                                oDataTable.Rows.Add(oDataRowInsert)

                            End If

                        End If

                        'Atualiza Linha do Inventário                    
                        If oDataTable.Select(sQuery).Length > 0 Then

                            'Seleciona Linha
                            oDataRow = oDataTable.Select(sQuery)(0)

                            'Quantidade
                            If IsNumeric(oWorkbook.Application.Cells(i, cboConfiguracaoColunaQuantidade.SelectedIndex + 1).Value) Then
                                oDataRow("quantidade_inventario") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaQuantidade.SelectedIndex + 1).Value
                            Else
                                If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                oMensagem(UBound(oMensagem)).Linha = i
                                oMensagem(UBound(oMensagem)).Erro = "A Quantidade informada não é Numérica."
                            End If

                            'Custo Médio
                            If cboConfiguracaoColunaCustoMedio.SelectedIndex > -1 Then
                                If IsNumeric(oWorkbook.Application.Cells(i, cboConfiguracaoColunaCustoMedio.SelectedIndex + 1).Value) Then
                                    oDataRow("custo_medio") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaCustoMedio.SelectedIndex + 1).Value
                                Else
                                    If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                                    oMensagem(UBound(oMensagem)).Linha = i
                                    oMensagem(UBound(oMensagem)).Erro = "O Custo Médio informado não é Numérico."
                                End If
                            End If

                            oDataRow("localizacao") = oWorkbook.Application.Cells(i, cboConfiguracaoColunaLocalizacao.SelectedIndex + 1).Value
                            oDataRow("data_fabricacao") = IIf(IsDate(oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataFabricacao.SelectedIndex + 1).Value) = False, DBNull.Value, oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataFabricacao.SelectedIndex + 1).Value)
                            oDataRow("data_validade") = IIf(IsDate(oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataValidade.SelectedIndex + 1).Value) = False, DBNull.Value, oWorkbook.Application.Cells(i, cboConfiguracaoColunaDataValidade.SelectedIndex + 1).Value)


                        Else

                            'Carrega Mensagem de que o Produto não foi encontrado
                            If oMensagem(UBound(oMensagem)).Linha <> "" Then ReDim Preserve oMensagem(UBound(oMensagem) + 1)
                            oMensagem(UBound(oMensagem)).Linha = i
                            oMensagem(UBound(oMensagem)).Erro = oWorkbook.Application.Cells(i, cboConfiguracaoColunaCodigoProduto.SelectedIndex + 1).Value & " - Não foi encontrado no Cadastro de Produtos."

                        End If

                        'Seta ProgressBar
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue + 1

                    Next i

                    'Configura DataMember
                    Call ConfigurarDataMemberGrid(grdInventario)

                    'Carrega a Grid
                    grdInventario.DataSource = oDataSet.DefaultViewManager
                    grdInventario.DataMember = oDataSet.Tables(0).TableName

                    'Verifica se é necessário e gera Relatório
                    If oMensagem(UBound(oMensagem)).Linha <> "" Then

                        'Gera Relatório de Erro
                        Call ReportErro("Integração - Estoque - Inventário", _
                                        "Log de Importação - Integração Inventário", _
                                        oMensagem)

                    End If

                Catch ex As Exception
                    Throw ex
                Finally
                    'Oculta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False
                    'Limpa váriavel
                    oWorkbook.Close(False)
                    oWorkbook = Nothing
                    oApplication = Nothing
                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default
                End Try

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ReportErro(ByVal sTitle As String, _
                                ByVal sSubTitle As String, _
                                ByVal oMensagem() As MensagemErro) As String

        Dim sReportHTML As String

        'add header information
        sReportHTML = "<!DOCTYPE HTML PUBLIC -//W3C//DTD HTML 4.01 Transitional//EN > "
        sReportHTML &= "<html>"
        sReportHTML &= "<head>"
        sReportHTML &= "<title>" & sTitle & "</title>"
        sReportHTML &= "<meta http-equiv=Content-Type content=text/html; charset=iso-8859-1 > "
        sReportHTML &= "</head>"
        sReportHTML &= "<body>"

        'add title text / subtitle text block
        sReportHTML &= "<p><font face=Arial, Helvetica, sans-serif><strong><font size=3>" & sSubTitle & "</font></strong><br>"
        sReportHTML &= "<font size=" & "2" & ">Relatório Gerado em: " & Now & "<br>"
        sReportHTML &= "Relatório Gerado por : " & goUsuario.sUsuario & "</font></font></p>"

        'define the start of the table
        sReportHTML &= "<table width=100% border=1 cellspacing=0 bordercolor=#CCCCCC>"

        'create the header row
        sReportHTML &= "<tr>"
        sReportHTML &= "<td width=10% vAlign=top align=center bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Linha</font></strong></td>"
        sReportHTML &= "<td width=90% vAlign=top align=left bgcolor=#99CCFF><strong><font size=2 face=Arial, Helvetica, sans-serif>Erro</font></strong></td>"
        sReportHTML &= "</tr>"

        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oMensagem.Count
        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
        frmMain.stbMain.Panels("pnlProgressBar").Visible = True

        For i As Integer = 0 To UBound(oMensagem)

            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

            sReportHTML &= "<tr>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Linha & "</font></td>"
            sReportHTML &= "<td vAlign=top align=left><font size=2 face=Arial, Helvetica, sans-serif>" & oMensagem(i).Erro & "</font></td>"
            sReportHTML &= "</tr>"
            Application.DoEvents()
        Next i

        frmMain.stbMain.Panels("pnlProgressBar").Visible = False

        'close page
        sReportHTML &= "</body>"
        sReportHTML &= "</html>"

        'Váriaveis Locais
        Dim sArquivo As String = System.IO.Path.GetTempPath
        sArquivo &= "INTERACTI_ERRO.html"

        If File.Exists(sArquivo) Then
            File.Delete(sArquivo)
        End If

        Using oFileStream As New FileStream(sArquivo, FileMode.Create)
            Dim oStreamWriter As New StreamWriter(oFileStream, System.Text.Encoding.Default)
            oStreamWriter.Write(sReportHTML.ToString())
            oStreamWriter.Close()
            oFileStream.Close()
        End Using

        Process.Start(sArquivo)

    End Function

#End Region

#End Region

End Class
