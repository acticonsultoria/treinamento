Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine

Public Class usrPrdOrdemDespesa


#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdOrdemDespesa As New clsUsrPrdOrdemDespesa
    Public bEditar As Boolean = False

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"
    Dim oClsPrdOrdemProducao As Object

    Private Sub usrPrdOrdemProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdOrdemProducao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ORDEM DE PRODUÇÃO :::"

    Private Sub cboCodigoProdutoNova_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProdutoNova.SelectedIndexChanged

        Try

            If cboCodigoProdutoNova.SelectedIndex = -1 Then
                Exit Sub
            End If

            txtDescricaoNova.Text = LoadCodigo("sp_select_cadastro_basico_descricao_item " & cboCodigoProdutoNova.SelectedValue & ", " & goUsuario.iEmpresa)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            Excluir()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnInserirRoteiro_Click(sender As Object, e As EventArgs) Handles btnInserirRoteiro.Click
        Try
            Call InserirOperacao()
            txtSequencia.Text = 0
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            txtObservacaoRoteiro.Text = ""
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirRoteiro_Click(sender As Object, e As EventArgs) Handles btnExcluirRoteiro.Click
        Try
            Call ExcluirOperacao()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagNova)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub



    Private Sub btnImportarExcel_Click(sender As Object, e As EventArgs)
        Try
            'Váriaveis Locais
            Dim oForm As New frmPrdOrdemProducaoImportarExcel

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub cboCentroTrabalho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroTrabalho.SelectedIndexChanged
        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboCentroTrabalho.SelectedIndex = -1 Then
                'Limpa Controle
                Exit Sub
            Else
                'Carrega Combo
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarOperacao_Click(sender As Object, e As EventArgs) Handles btnCadastrarOperacao.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOperacao")

            If cboCentroTrabalho.SelectedIndex = -1 Then
                Exit Sub
            Else
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

            'Seta Focu
            cboOperacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(sender As Object, e As EventArgs) Handles btnCadastrarCentroTrabalho.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroTrabalho")

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroTrabalho.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles btnSalvarOPNova.Click
        Try
            If bEditar = False Then
                Call InserirOP()
                Call InserirApontamento()

            Else
                Call AtualizarOP()
                Call InserirApontamento()

            End If


        Catch ex As Exception
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
            oForm.NomeFormulario = Formulario.ProducaoOrdemProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

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


    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagNova)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : EditarOrdemProducao()
                Case "finalizar" : Finalizar()
                Case "cancelar" : CancelarOrdemDespesa()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ProducaoOrdemProducao)

            'Carrega Combo


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ProducaoOrdemProducao, _
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
                                          Formulario.ProducaoOrdemProducao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Verifica se a Coluna é a Data de Aceite
            If e.Column.Key = "data_necessidade" Then

                'Váriaveis - Query
                Dim sQuery As String

                sQuery = "sp_update_interacti_table_field "
                sQuery &= "'tb_prd_ordem_producao', "
                sQuery &= "'data_necessidade', "
                If IsDBNull(grdListagem.GetValue("data_necessidade")) = False AndAlso IsDate(grdListagem.GetValue("data_necessidade")) Then
                    sQuery &= "'''" & grdListagem.GetValue("data_necessidade") & "''',"
                Else
                    sQuery &= "'NULL',"
                End If
                sQuery &= "'WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))'"

                'Atualiza Registro
                Call ExecuteQuery(sQuery)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: APONTAMENTO :::"
  
    Private Sub btnGerarOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnGerarOrdemProducao.Click
        Try
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagNova)
            grpOPNova.Enabled = True
            bEditar = False
            Call Nova()



        Catch ex As Exception
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdOrdemProducao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao")
            Call LoadCombo(cboCodigoProdutoNova, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto))
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipo, "sp_select_combo_static_tipo_ordem_despesa", False)
            Call LoadCombo(cboTipoFiltro, "sp_select_combo_static_tipo_ordem_despesa", False)

            'Configura Direito
            btnImprimir.Enabled = VerificaDireito(Formulario.ProducaoOrdemDespesa, gcPrint)

            'Seta Controles
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemDespesa)

           
            'Desabilita Aba
            tabMain.TabPages.Remove(pagNova)


            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ORDEM DE PRODUÇÃO :::"

#Region "::: ORDEM DE PRODUÇÃO :::"

    Private Sub Finalizar()

        Try

            If grdListagem.GetValue("status") = 4 Then
                MsgBox("Não é possível finalizar uma OS cancelada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If grdListagem.GetValue("status") = 3 Then
                MsgBox("Essa OS já está finalizada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Cancelar a Ordem de Produção
            If MsgBox("Deseja Finalizar a Ordem de Serviço?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsPrdOrdemDespesa.FinalizarOrdemDespesa(grdListagem.CurrentRow.Cells.Item("codigo").Value, "")

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Excluir()

        Try

            If grdListagem.GetCheckedRows.Count = 0 Then

                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

                Exit Sub

            End If

            'Questiona o usuario
            If MsgBox("Deseja excluir os registros selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = vbNo Then Exit Sub

            'Exclui os itens
            oClsPrdOrdemDespesa.Delete(grdListagem)

            'Carrega novamente
            LoadGrid()

            'Informa o usuário
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InserirOP()

        Try

            If ValidacaoOP() = True Then

                If CStr(btnSalvarOPNova.Tag) = "" Then

                    oClsPrdOrdemDespesa.Insert(txtNumeroOPNova.Tag, _
                                               cboCodigoProdutoNova.SelectedValue, _
                                               dtpDataEmissao.Value, _
                                               txtQtdPlanejadaNova.Value, _
                                               cboTipo.SelectedValue, _
                                               cboCentroCusto.SelectedValue, _
                                               txtPlanta.Text, _
                                               txtRef.Text, _
                                               txtOM.Text, _
                                               txtObservacaoOPNova.Text, _
                                               btnSalvarOPNova)

                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarOP()

        Try

            If ValidacaoOP() = True Then

                If CStr(btnSalvarOPNova.Tag) <> "" Then

                    oClsPrdOrdemDespesa.Update(btnSalvarOPNova.Tag, _
                                               cboCodigoProdutoNova.SelectedValue, _
                                               dtpDataEmissao.Value, _
                                               txtQtdPlanejadaNova.Value, _
                                               cboTipo.SelectedValue, _
                                               cboCentroCusto.SelectedValue, _
                                               txtPlanta.Text, _
                                               txtRef.Text, _
                                               txtOM.Text, _
                                               txtObservacaoOPNova.Text)

                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis locais
            Dim sStatus As String = ""
            Dim sCodigoGrupoItem As String = ""
            Dim i As Integer
            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            oClsPrdOrdemDespesa.LoadGrid(grdListagem, _
                                          IIf(IsNumeric(txtOrdemProducaoFiltro.Text) = False, -1, txtOrdemProducaoFiltro.Text), _
                                          IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                          IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                          txtCodigoProdutoFiltro.Text, _
                                          sStatus, _
                                          IIf(cboTipoFiltro.SelectedIndex = -1, "", cboTipoFiltro.SelectedValue), _
                                          txtPlantaFiltro.Text, _
                                          txtREFFiltro.Text, _
                                          txtOMFiltro.Text)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

   
    Private Sub EditarOrdemProducao()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ProducaoOrdemDespesa, gcUpdate) = True Then

                If grdListagem.CurrentRow.Cells("status").Value = 4 Then
                    frmMain.Informacao("Não é possível realizar essa operação!", Color.Red)
                    Exit Sub
                End If

                bEditar = True

                'Carrega Controles
                txtNumeroOPNova.Text = grdListagem.CurrentRow.Cells("ordem_despesa").Value
                btnSalvarOPNova.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                dtpDataEmissao.Value = grdListagem.CurrentRow.Cells("data_emissao").Value
                cboCodigoProdutoNova.SelectedValue = grdListagem.CurrentRow.Cells("codigo_item").Value
                txtQtdPlanejadaNova.Value = grdListagem.CurrentRow.Cells("quantidade").Value
                cboTipo.SelectedValue = grdListagem.CurrentRow.Cells("tipo").Value
                cboCentroCusto.SelectedValue = grdListagem.CurrentRow.Cells("codigo_centro_custo").Value
                txtPlanta.Text = grdListagem.CurrentRow.Cells("planta").Value
                txtRef.Text = grdListagem.CurrentRow.Cells("ref").Value
                txtOM.Text = grdListagem.CurrentRow.Cells("om").Value
                txtObservacaoOPNova.Text = grdListagem.CurrentRow.Cells("observacao").Value

                Dim iApontamento As Integer = 0

                iApontamento = LoadCodigo("sp_validade_producao_ordem_despesa_apontamento " & btnSalvarOPNova.Tag & ", " & goUsuario.iEmpresa)

                If iApontamento > 0 Then
                    btnInserirRoteiro.Enabled = False
                    btnExcluirRoteiro.Enabled = False
                End If
                
                Call oClsPrdOrdemDespesa.LoadGridApontamento(grdRoteiro, _
                                                              grdListagem.CurrentRow.Cells("codigo").Value)

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagNova)

                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarOrdemDespesa()

        Try

            If grdListagem.GetValue("status") = 3 Then
                MsgBox("Não é possível cancelar uma OD finalizada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If grdListagem.GetValue("status") = 4 Then
                MsgBox("Essa OD já está cancelada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Cancelar a Ordem de Produção
            If MsgBox("Deseja Cancelar a Ordem de Serviço?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sHistorico As String

            sHistorico = InputBox("Digite o motivo do cancelamento", "Justificativa", "")

            If sHistorico = "" Then
                MsgBox("Digite um motivo válido!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Validação")
                Exit Sub
            End If

            oClsPrdOrdemDespesa.CancelarOrdemDespesa(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                                     sHistorico)

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
 
    Private Function ValidacaoOP() As Boolean
        Try
            ValidacaoOP = False

            If ValidaCampo(cboCodigoProdutoNova, lblCodigoProduto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtQtdPlanejadaNova, lblQtdPlanejadaNova, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            If ValidaCampo(cboCentroCusto, lblCentroCusto) = False Then
                Exit Function
            End If

            ValidacaoOP = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Nova()

        Try

            btnInserirRoteiro.Enabled = True
            btnExcluirRoteiro.Enabled = True
            txtNumeroOPNova.Text = ""
            cboCodigoProdutoNova.SelectedIndex = -1
            txtDescricaoNova.Text = ""
            txtQtdPlanejadaNova.Value = 0
            cboTipo.SelectedIndex = -1
            txtObservacaoOPNova.Text = ""
            btnSalvarOPNova.Tag = ""
            cboCentroCusto.SelectedIndex = -1
            txtPlanta.Text = ""
            txtRef.Text = ""
            txtOM.Text = ""

            txtSequencia.Text = 0
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            grdRoteiro.DataSource = Nothing

            oClsPrdOrdemDespesa.GerarNumero(txtNumeroOPNova)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: APONTAMENTO :::"
  

    Private Sub InserirApontamento()
        Try
            Dim iApontamento As Integer = 0
            If bEditar = True Then
                iApontamento = LoadCodigo("sp_validade_producao_ordem_despesa_apontamento " & btnSalvarOPNova.Tag & ", " & goUsuario.iEmpresa)
                If iApontamento > 0 Then
                    grpRoteiro.Enabled = False
                Else
                    grpRoteiro.Enabled = True
                    ExecuteQuery("DELETE FROM tb_prd_apontamento_despesa where codigo_ordem_despesa = " & btnSalvarOPNova.Tag)
                    For Each oRow In grdRoteiro.GetRows
                        oClsPrdOrdemDespesa.InsertApontamento(btnSalvarOPNova.Tag, _
                                                               oRow.Cells.Item("sequencia").Value, _
                                                               oRow.Cells.Item("codigo_centro_trabalho2").Value, _
                                                               oRow.Cells.Item("codigo_operacao2").Value, _
                                                               IIf(IsDBNull(oRow.Cells.Item("observacao").Value), "", oRow.Cells.Item("observacao").Value))
                    Next
                End If
            Else
                grpRoteiro.Enabled = True
                ExecuteQuery("DELETE FROM tb_prd_apontamento_despesa where codigo_ordem_despesa = " & btnSalvarOPNova.Tag)
                For Each oRow In grdRoteiro.GetRows
                    oClsPrdOrdemDespesa.InsertApontamento(btnSalvarOPNova.Tag, _
                                                           oRow.Cells.Item("sequencia").Value, _
                                                           oRow.Cells.Item("codigo_centro_trabalho2").Value, _
                                                           oRow.Cells.Item("codigo_operacao2").Value, _
                                                           IIf(IsDBNull(oRow.Cells.Item("observacao").Value), "", oRow.Cells.Item("observacao").Value))
                Next
            End If

            If ValidacaoOP() = True Then
                Call Nova()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

 
#End Region

#Region "::: OPERAÇÃO :::"

    Private Sub InserirOperacao()
        Try
            Dim oDataSet = New DataSet

            Try
                oDataSet = CType(grdRoteiro.DataSource.dataset, DataSet).Copy

                Dim oRow As DataRow = oDataSet.Tables(0).Rows.Add
                oRow("sequencia") = txtSequencia.Text
                oRow("descricao_centro_trabalho") = cboCentroTrabalho.Text
                oRow("codigo_centro_trabalho2") = cboCentroTrabalho.SelectedValue
                oRow("descricao_operacao") = cboOperacao.Text
                oRow("codigo_operacao2") = cboOperacao.SelectedValue
                oRow("observacao") = IIf(txtObservacaoRoteiro.Text = "", "", txtObservacaoRoteiro.Text)
            Catch ex As Exception
                Dim oDataTable As New DataTable
                Dim oDCSequencia As New DataColumn("sequencia")
                Dim oDCDescricaoCT As New DataColumn("descricao_centro_trabalho")
                Dim oDCCodCT As New DataColumn("codigo_centro_trabalho2")
                Dim oDCDescricaoOP As New DataColumn("descricao_operacao")
                Dim oDCCodigoOP As New DataColumn("codigo_operacao2")
                Dim oDCObservacao As New DataColumn("observacao")

                'Seta DataType
                oDCSequencia.DataType = 0.GetType
                oDCDescricaoCT.DataType = "".GetType
                oDCCodCT.DataType = 0.GetType
                oDCDescricaoOP.DataType = "".GetType
                oDCCodigoOP.DataType = 0.GetType
                oDCObservacao.DataType = "".GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCSequencia)
                oDataTable.Columns.Add(oDCDescricaoCT)
                oDataTable.Columns.Add(oDCCodCT)
                oDataTable.Columns.Add(oDCDescricaoOP)
                oDataTable.Columns.Add(oDCCodigoOP)
                oDataTable.Columns.Add(oDCObservacao)

                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("sequencia") = txtSequencia.Text
                oDataRow("descricao_centro_trabalho") = cboCentroTrabalho.Text
                oDataRow("codigo_centro_trabalho2") = cboCentroTrabalho.SelectedValue
                oDataRow("descricao_operacao") = cboOperacao.Text
                oDataRow("codigo_operacao2") = cboOperacao.SelectedValue
                oDataRow("observacao") = IIf(txtObservacaoRoteiro.Text = "", "", txtObservacaoRoteiro.Text)
                oDataTable.Rows.Add(oDataRow)
            End Try



            Call ConfigurarDataMemberGrid(grdRoteiro)

            grdRoteiro.DataSource = oDataSet.DefaultViewManager
            grdRoteiro.DataMember = oDataSet.Tables(0).TableName : grdRoteiro.MoveFirst()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub ExcluirOperacao()
        Try
            If MsgBox("Deseja excluir permanentemente esse(s) registro(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                For Each oRow In grdRoteiro.GetCheckedRows
                    oRow.Delete()
                Next
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#End Region

#End Region
   
End Class
