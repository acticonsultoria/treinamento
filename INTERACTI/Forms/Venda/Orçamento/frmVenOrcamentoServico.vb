Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.Math

Public Class frmVenOrcamentoServico

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private lCodigoItem As Long = -1
    Private iCodigoParceiroNegocio As Integer
    Private oClsCadProduto As New clsUsrCadProduto

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoItem() As Long
        Get
            Return lCodigoItem
        End Get
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public Property CodigoParceiroNegocio() As Integer
        Get
            Return iCodigoParceiroNegocio
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiroNegocio = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub frmVenOrcamentoServico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboGrupoItem" : Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboGrupoItem" : Call btnCadastrarGrupoItem_Click(btnCadastrarGrupoItem, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenOrcamentoServico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: CADASTRO DE PRODUTO :::"

    Private Sub btnCadastrarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItem.Click

        Try

           'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoItem")

            'Carrega Combo
            LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Produto
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnArquivoDesenho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoDesenho.Click

        Try

            'Variaveis Locais
            Dim arqDesenho As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqDesenho.InitialDirectory = "c:\\dados"
            arqDesenho.Title = "Selecione o Arquivo"

            If arqDesenho.ShowDialog() = DialogResult.OK Then
                txtDesenho.Text = arqDesenho.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUÇÃO :::"

    Private Sub btnAgruparGridProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProducao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdProducao.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdProducao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdProducao.GroupByBoxVisible = True
                grdProducao.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProducao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProducao
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProducao, Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProducao.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdProducao_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdProducao.CellUpdated

        Try

            'Váriaveis Locais
            Dim dValorHoras As Double = 0
            Dim dQuantidadeHoras As Double = 0
            Dim sQuery As String = "((codigo_centro_trabalho = " & grdProducao.GetValue("codigo_centro_trabalho") & "))"

            'Verifica qual a Célula Informada
            Select Case e.Column.Key

                Case "valor_hora", "quantidade_horas"
                    If IsNumeric(grdProducao.GetValue("valor_hora")) Then dValorHoras = grdProducao.GetValue("valor_hora")
                    If IsDate(grdProducao.GetValue("quantidade_horas")) Then
                        dQuantidadeHoras = Hour(grdProducao.GetValue("quantidade_horas"))
                        dQuantidadeHoras += Minute(grdProducao.GetValue("quantidade_horas")) / 60.0
                        dQuantidadeHoras += Second(grdProducao.GetValue("quantidade_horas")) / 360.0
                    End If

                    'Atualiza Grid
                    If dQuantidadeHoras = 0 And dValorHoras > 0 Then Call UpdateRegistroGrid(grdProducao, sQuery, "quantidade_horas", "NULL")
                    Call UpdateRegistroGrid(grdProducao, sQuery, "valor_total", (dValorHoras * dQuantidadeHoras))
                    grdProducao.Refresh()

                    'Calcula Preço de Venda
                    Call CalcularPrecoVenda()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdProducao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProducao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProducao, _
                                     Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdProducao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProducao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProducao.Name, _
                                     Formulario.ComercialOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdProducao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProducao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProducao.Name, _
                                          Formulario.ComercialOrcamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CUSTO :::"

    Private Sub btnAgruparGridCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCusto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCusto.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdCusto.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdCusto.GroupByBoxVisible = True
                grdCusto.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCusto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCusto
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCusto, Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCusto.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdCusto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserirCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirCusto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados da Matéria Prima
            If ValidacaoCusto() = True Then

                'Váriaveis Locais
                Dim iCodigoTipoCustoAntigo As Integer = -1
                Dim sDescricaoAntigo As String = ""

                If IsNumeric(btnInserirCusto.Tag) Then
                    iCodigoTipoCustoAntigo = grdCusto.CurrentRow.Cells("codigo_tipo_custo").Value
                    sDescricaoAntigo = grdCusto.CurrentRow.Cells("descricao").Value
                End If

                'Deleta Registros
                Call SaveCustoGrid(grdCusto, _
                                   cboTipoCusto.Text, _
                                   cboTipoCusto.SelectedValue, _
                                   txtDescricaoCusto.Text, _
                                   txtValorCusto.Value, _
                                   iCodigoTipoCustoAntigo, _
                                   sDescricaoAntigo)

                'Calcula Preço de Venda
                Call CalcularPrecoVenda()

                'Limpa Formulário
                Call NovoCusto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluirCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCusto.Click

        Try

            'Deleta Registros
            Call DeleteCusto()

            'Calcula Preço de Venda
            Call CalcularPrecoVenda()

            'Limpa Formulário
            Call NovoCusto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdCusto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCusto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCusto, _
                                     Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdCusto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCusto.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdCusto.CurrentColumn) Then Exit Sub

            'Verifica Coluna Pressionada
            Select Case grdCusto.CurrentColumn.Key

                Case "editar" : Call EditarCusto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdCusto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCusto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCusto.Name, _
                                     Formulario.ComercialOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CALCULO :::"

    Private Sub CalculoSubtotal1() Handles txtValorMaoObra.ValueChanged, _
                                           txtValorPintura.ValueChanged, _
                                           txtValorTratamentoSuperficial.ValueChanged, _
                                           txtValorTratamentoTermico.ValueChanged, _
                                           txtValorEmbalagem.ValueChanged, _
                                           txtValorPadronizados.ValueChanged, _
                                           txtValorFerramentas.ValueChanged, _
                                           txtValorTransportadora.ValueChanged, _
                                           txtValorSubcontrato.ValueChanged

        Try

            'Seta Controle
            txtValorSubtotal1.Value = txtValorMaoObra.Value + _
                                      txtValorPintura.Value + _
                                      txtValorTratamentoSuperficial.Value + _
                                      txtValorTratamentoTermico.Value + _
                                      txtValorEmbalagem.Value + _
                                      txtValorPadronizados.Value + _
                                      txtValorFerramentas.Value + _
                                      txtValorTransportadora.Value + _
                                      txtValorSubcontrato.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculoSubtotal2(sender As Object, e As EventArgs) Handles txtValorSubtotal1.ValueChanged, _
                                                                           txtMargem.LostFocus, _
                                                                           txtValorMargem.LostFocus

        Try

            'Váriaveis Locais
            Dim dMargem As Double = 0
            Dim dValorMargem As Double = 0

            If sender.name = "txtMargem" Or sender.Name = "txtValorSubtotal1" Then
                dValorMargem = txtValorSubtotal1.Value * IIf(IsNumeric(txtMargem.Value), txtMargem.Value, 0)
                dMargem = txtMargem.Value
            ElseIf sender.Name = "txtValorMargem" Then
                dMargem = IIf(IsNumeric(txtValorMargem.Value), txtValorMargem.Value, 0) / txtValorSubtotal1.Value
                dValorMargem = txtValorMargem.Value
            End If

            'Seta Controle
            txtMargem.Value = dMargem
            txtValorMargem.Value = dValorMargem
            txtValorSubtotal2.Value = txtValorSubtotal1.Value + txtValorMargem.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculoSubtotal3(sender As Object, e As EventArgs) Handles txtValorSubtotal2.ValueChanged, _
                                                                           txtTaxaFinanceira.LostFocus, _
                                                                           txtValorTaxaFinanceira.ValueChanged

        Try

            'Váriaveis Locais
            Dim dTaxaFinanceira As Double = 0
            Dim dValorTaxaFinanceira As Double = 0

            If sender.name = "txtTaxaFinanceira" Or sender.Name = "txtValorSubtotal2" Then
                dValorTaxaFinanceira = txtValorSubtotal2.Value * IIf(IsNumeric(txtTaxaFinanceira.Value), txtTaxaFinanceira.Value, 0)
                dTaxaFinanceira = txtTaxaFinanceira.Value
            ElseIf sender.Name = "txtValorTaxaFinanceira" Then
                dTaxaFinanceira = IIf(IsNumeric(txtValorTaxaFinanceira.Value), txtValorTaxaFinanceira.Value, 0) / txtValorSubtotal2.Value
                dValorTaxaFinanceira = txtValorTaxaFinanceira.Value
            End If

            'Seta Controle
            txtTaxaFinanceira.Value = dTaxaFinanceira
            txtValorTaxaFinanceira.Value = dValorTaxaFinanceira
            txtValorSubtotal3.Value = txtValorSubtotal2.Value + txtValorTaxaFinanceira.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculoTotal(sender As Object, e As EventArgs) Handles txtValorSubtotal3.ValueChanged, _
                                                                       txtAliquotaPIS.LostFocus, _
                                                                       txtAliquotaCOFINS.LostFocus, _
                                                                       txtAliquotaCSLL.LostFocus, _
                                                                       txtAliquotaINSS.LostFocus, _
                                                                       txtAliquotaIR.LostFocus, _
                                                                       txtAliquotaISS.LostFocus

        Try

            'Seta Controles
            txtValorISS.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaISS.Value), txtAliquotaISS.Value, 0)
            txtValorPIS.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaPIS.Value), txtAliquotaPIS.Value, 0)
            txtValorCOFINS.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaCOFINS.Value), txtAliquotaCOFINS.Value, 0)
            txtValorINSS.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaINSS.Value), txtAliquotaINSS.Value, 0)
            txtValorCSLL.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaCSLL.Value), txtAliquotaCSLL.Value, 0)
            txtValorIR.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaIR.Value), txtAliquotaIR.Value, 0)

            'Seta Controle
            txtValorTotal.Value = txtValorSubtotal3.Value + txtValorISS.Value + txtValorPIS.Value + txtValorCOFINS.Value + +txtValorINSS.Value + txtValorCSLL.Value + txtValorIR.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenOrcamentoServico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo - Dados de Produção
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            'Carrega Combo - Custo
            Call LoadCombo(cboTipoCusto, "sp_select_combo_static_tipo_custo_orcamento_item", False)

            'Carrega Grid
            Call oClsCadProduto.LoadGridOrcamentoItemMateriaPrima(grdMateriaPrima, lCodigoItem)
            Call oClsCadProduto.LoadGridOrcamentoItemCentroTrabalho(grdProducao, lCodigoItem)
            Call oClsCadProduto.LoadGridOrcamentoItemCusto(grdCusto, lCodigoItem)

            'Calcula Preço de Venda
            Call CalcularPrecoVenda()

            'Váriaveis Locais
            Dim iCodigoGrupoItem As Integer = -1
            Dim sCodigoItem As String = ""
            Dim sDescricao As String = ""
            Dim sDesenho As String = ""
            Dim sArquivo As String = ""
            Dim sRevisao As String = ""
            Dim iCodigoUnidadeMedida As Integer = -1
            Dim iCodigoNCM As Integer = -1
            Dim dMargem As Double = 0
            Dim dTaxaFinanceira As Double = 0
            Dim bISSRetido As Boolean = False
            Dim dAliquotaISS As Double = 0
            Dim dAliquotaPIS As Double = 0
            Dim dAliquotaCOFINS As Double = 0
            Dim dAliquotaINSS As Double = 0
            Dim dAliquotaCSLL As Double = 0
            Dim dAliquotaIR As Double = 0

            'Carrega Váriaveis
            Call oClsCadProduto.LoadDadosServicoOrcamento(lCodigoItem, _
                                                          iCodigoGrupoItem, _
                                                          sCodigoItem, _
                                                          sDesenho, _
                                                          sRevisao, _
                                                          sArquivo, _
                                                          sDescricao, _
                                                          dMargem, _
                                                          dTaxaFinanceira, _
                                                          bISSRetido, _
                                                          dAliquotaISS, _
                                                          dAliquotaPIS, _
                                                          dAliquotaCOFINS, _
                                                          dAliquotaINSS, _
                                                          dAliquotaCSLL, _
                                                          dAliquotaIR)

            'Seta Controles
            If iCodigoGrupoItem <> -1 Then cboGrupoItem.SelectedValue = iCodigoGrupoItem
            txtCodigo.Text = sCodigoItem
            txtDescricao.Text = sDescricao
            txtDesenho.Text = sDesenho
            txtArquivoDesenho.Text = sArquivo
            txtRevisaoDesenho.Text = sRevisao
            txtMargem.Value = dMargem
            txtTaxaFinanceira.Value = dTaxaFinanceira
            chkAliquotaISS.CheckState = bISSRetido
            txtAliquotaISS.Value = dAliquotaISS
            txtAliquotaPIS.Value = dAliquotaPIS
            txtAliquotaCOFINS.Value = dAliquotaCOFINS
            txtAliquotaINSS.Value = dAliquotaINSS
            txtAliquotaCSLL.Value = dAliquotaCSLL
            txtAliquotaIR.Value = dAliquotaIR

            'Calcula Subtotal
            Call CalculoSubtotal2(txtMargem, System.EventArgs.Empty)

            'Configura Grid
            Call ConfiguraGrid(grdProducao, Formulario.ComercialOrcamento)
            Call ConfiguraGrid(grdCusto, Formulario.ComercialOrcamento)

            'Seta Focu
            txtCodigo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CADASTRO DE PRODUTO :::"

    Private Sub Salvar()

        Try

            'Váriaveis Locais
            Dim oClsCadProduto As New clsUsrCadProduto

            'Verifica o Tipo de Operação
            If lCodigoItem = -1 Then

                'Insere Registro na tb_cad_item
                Call oClsCadProduto.InsertServicoOrcamento(TipoItem.servico, _
                                                           cboGrupoItem.SelectedValue, _
                                                           txtCodigo.Text.Trim, _
                                                           txtDesenho.Text.Trim, _
                                                           txtRevisaoDesenho.Text.Trim, _
                                                           txtArquivoDesenho.Text.Trim, _
                                                           txtDescricao.Text.Trim, _
                                                           txtMargem.Value, _
                                                           txtTaxaFinanceira.Value, _
                                                           txtValorTotal.Value, _
                                                           chkAliquotaISS.CheckState, _
                                                           txtAliquotaISS.VAlue, _
                                                           txtAliquotaPIS.Value, _
                                                           txtAliquotaCOFINS.Value, _
                                                           txtAliquotaINSS.Value, _
                                                           txtAliquotaCSLL.Value, _
                                                           txtAliquotaIR.Value)

                'Carrega Váriavel
                lCodigoItem = oClsCadProduto.CodigoProduto

            Else

                'Insere Registro na tb_cad_item
                Call oClsCadProduto.UpdateServicoOrcamento(TipoItem.servico, _
                                                           cboGrupoItem.SelectedValue, _
                                                           txtCodigo.Text.Trim, _
                                                           txtDesenho.Text.Trim, _
                                                           txtRevisaoDesenho.Text.Trim, _
                                                           txtArquivoDesenho.Text.Trim, _
                                                           txtArquivoDesenho.Tag, _
                                                           txtDescricao.Text.Trim, _
                                                           txtMargem.Value, _
                                                           txtTaxaFinanceira.Value, _
                                                           txtValorTotal.Value, _
                                                           chkAliquotaISS.CheckState, _
                                                           txtAliquotaISS.Value, _
                                                           txtAliquotaPIS.Value, _
                                                           txtAliquotaCOFINS.Value, _
                                                           txtAliquotaINSS.Value, _
                                                           txtAliquotaCSLL.Value, _
                                                           txtAliquotaIR.Value, _
                                                           lCodigoItem)

                Call oClsCadProduto.DeleteOrcamentoItemCentroTrabalho(lCodigoItem)
                Call oClsCadProduto.DeleteOrcamentoItemMateriaPrima(lCodigoItem)
                Call oClsCadProduto.DeleteOrcamentoItemCusto(lCodigoItem)

            End If

            'Insere Registros - Grid
            Call oClsCadProduto.InsertOrcamentoItemCentroTrabalho(lCodigoItem, grdProducao)
            Call oClsCadProduto.InsertOrcamentoItemCusto(lCodigoItem, grdCusto)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Váriavel - Classe
            Dim oClsCadProduto As New clsUsrCadProduto

            'Verifica se foi Selecionado o Campo - Grupo de Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                tabDados.SelectedTab = pagProducao
                cboGrupoItem.Focus()
                Exit Function
            End If

            'Verifica se não está selecionado o Código
            If txtCodigo.Text.Trim = "" Then

                If MsgBox("Deseja que o sistema gere o Código do Produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    'Gera Número do Part Number e Código do Item
                    txtCodigo.Text = oClsCadProduto.GeraCodigoItem(cboGrupoItem.SelectedValue)
                End If

            End If

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagProducao
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se o Código Preenchido é Válido
            If oClsCadProduto.ValidaCodigoProduto(lCodigoItem, txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                tabDados.SelectedTab = pagProducao
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagProducao
                txtDescricao.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CUSTO :::"

    Private Sub NovoCusto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Produtos
            cboTipoCusto.Text = ""
            txtDescricaoCusto.Text = ""
            txtValorCusto.Value = 0
            btnInserirCusto.Tag = ""

            'Seta Focu
            cboTipoCusto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteCusto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCusto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarCusto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialOrcamento, gcUpdate) = True Then

                'Carrega Controles
                cboTipoCusto.SelectedValue = grdCusto.CurrentRow.Cells("codigo_tipo_custo").Value
                txtDescricaoCusto.Text = grdCusto.CurrentRow.Cells("descricao").Value
                txtValorCusto.Value = grdCusto.CurrentRow.Cells("valor").Value
                btnInserirCusto.Tag = grdCusto.CurrentRow.RowIndex

                'Seta Focu
                cboTipoCusto.Focus()

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

    Private Sub SaveCustoGrid(ByVal oGrid As GridEX, _
                              ByVal sTipoCusto As String, _
                              ByVal iCodigoTipoCusto As Integer, _
                              ByVal sDescricao As String, _
                              ByVal dValor As Double, _
                              ByVal iCodigoTipoCustoAntigo As Integer, _
                              ByVal sDescricaoAntigo As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCTipoCusto As New DataColumn("tipo_custo")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCCodigoTipoCusto As New DataColumn("codigo_tipo_custo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCTipoCusto)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCCodigoTipoCusto)
                'Seta DataType
                oDCValor.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If iCodigoTipoCustoAntigo = -1 Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("tipo_custo") = sTipoCusto
                oDataRow("codigo_tipo_custo") = iCodigoTipoCusto
                oDataRow("descricao") = sDescricao
                oDataRow("valor") = dValor
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo_tipo_custo = " & iCodigoTipoCustoAntigo & ") AND (descricao = '" & sDescricaoAntigo & "')")(0)
                oDataRow("tipo_custo") = sTipoCusto
                oDataRow("codigo_tipo_custo") = iCodigoTipoCusto
                oDataRow("descricao") = sDescricao
                oDataRow("valor") = dValor
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCusto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCusto = False

            'Verifica se foi Selecionado o Campo - Tipo Custo
            If ValidaCampo(cboTipoCusto, lblTipoCusto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoCusto, lblDescricaoCusto, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Tipo Custo + Descrição já foram cadastrados
            For Each oRow As GridEXRow In grdCusto.GetDataRows
                If oRow.Cells("codigo_tipo_custo").Value = cboTipoCusto.SelectedValue And oRow.Cells("descricao").Value = txtDescricaoCusto.Text.Trim Then
                    frmMain.errInfo.SetError(lblDescricao, "Este Tipo / Descrição: " & cboTipoCusto.Text & " / " & txtDescricaoCusto.Text.Trim & " já se encontra cadastrado.")
                End If
            Next

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorCusto, lblValorCusto, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCusto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CALCULO :::"

    Private Sub CalcularPrecoVenda()

        Try

            'Mão de Obra
            If grdProducao.GetDataRows.Count > 0 Then
                txtValorMaoObra.Value = grdProducao.GetTotalRow.Cells("valor_total").Value
            End If

            'Outros
            txtValorPintura.Value = 0
            txtValorTratamentoSuperficial.Value = 0
            txtValorTratamentoTermico.Value = 0
            txtValorEmbalagem.Value = 0
            txtValorPadronizados.Value = 0
            txtValorFerramentas.Value = 0
            txtValorTransportadora.Value = 0
            txtValorSubcontrato.Value = 0

            For Each oRow As GridEXRow In grdCusto.GetDataRows
                Select Case oRow.Cells("codigo_tipo_custo").Value
                    Case 1 : txtValorPintura.Value = txtValorPintura.Value + oRow.Cells("valor").Value
                    Case 2 : txtValorTratamentoSuperficial.Value = txtValorTratamentoSuperficial.Value + oRow.Cells("valor").Value
                    Case 3 : txtValorTratamentoTermico.Value = txtValorTratamentoTermico.Value + oRow.Cells("valor").Value
                    Case 4 : txtValorEmbalagem.Value = txtValorEmbalagem.Value + oRow.Cells("valor").Value
                    Case 5 : txtValorPadronizados.Value = txtValorPadronizados.Value + oRow.Cells("valor").Value
                    Case 6 : txtValorFerramentas.Value = txtValorFerramentas.Value + oRow.Cells("valor").Value
                    Case 7 : txtValorTransportadora.Value = txtValorTransportadora.Value + oRow.Cells("valor").Value
                    Case 8 : txtValorSubcontrato.Value = txtValorSubcontrato.Value + oRow.Cells("valor").Value
                End Select
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class