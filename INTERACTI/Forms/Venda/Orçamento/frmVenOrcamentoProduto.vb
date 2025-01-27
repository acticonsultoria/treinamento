Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.Math

Public Class frmVenOrcamentoProduto

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

    Private Sub frmVenOrcamentoProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboMateriaPrima" : Call btnProcurarMateriaPrima_Click(btnProcurarMateriaPrima, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
                        Case "cboGrupoItem" : Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedidaMateriaPrima" : Call LoadCombo(cboUnidadeMedidaMateriaPrima, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
                        Case "cboMateriaPrima":Call LoadCombo(cboMateriaPrima, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, 1, NULL, NULL, NULL, NULL, 1", False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                        Case "cboGrupoItem" : Call btnCadastrarGrupoItem_Click(btnCadastrarGrupoItem, System.EventArgs.Empty)
                        Case "cboMateriaPrima" : Call btnCadastrarMateriaPrima_Click(btnCadastrarMateriaPrima, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaMateriaPrima" : Call btnCadastrarUnidadeMedidaMateriaPrima_Click(btnCadastrarUnidadeMedidaMateriaPrima, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenOrcamentoProduto_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarNCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarNCM.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadNCM")

            'Carrega Combo
            Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)

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

#Region "::: MATÉRIA PRIMA :::"

    Private Sub btnAgruparGridMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridMateriaPrima.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdMateriaPrima.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdMateriaPrima.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdMateriaPrima.GroupByBoxVisible = True
                grdMateriaPrima.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridMateriaPrima.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdMateriaPrima
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMateriaPrima, Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridMateriaPrima.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdMateriaPrima)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMateriaPrima.Click

        Try

              'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboMateriaPrima, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)

            'Seta Focu
            cboMateriaPrima.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarMateriaPrima.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemCompraFind = "S"
            oComboBoxFind = cboMateriaPrima

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboMateriaPrima.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaMateriaPrima.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaMateriaPrima, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboUnidadeMedidaMateriaPrima.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserirMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirMateriaPrima.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados da Matéria Prima
            If ValidacaoMateriaPrima() = True Then

                'Deleta Registros
                Call SaveMateriaPrimaGrid(grdMateriaPrima, _
                                          cboMateriaPrima.SelectedValue, _
                                          cboMateriaPrima.Text, _
                                          txtDescricaoMateriaPrima.Text.Trim, _
                                          txtQuantidadeMateriaPrima.Value, _
                                          cboUnidadeMedidaMateriaPrima.SelectedValue, _
                                          cboUnidadeMedidaMateriaPrima.Text, _
                                          txtCustoMedioMateriaPrima.Value, _
                                          txtMargemLucroMateriaPrima.Value, _
                                          txtValorUnitarioDescontoMateriaPrima.Value, _
                                          txtValorTotalMateriaPrima.Value, _
                                          IIf(IsNumeric(btnInserirMateriaPrima.Tag), btnInserirMateriaPrima.Tag, -1))

                'Calcula Preço de Venda
                Call CalcularPrecoVenda()

                'Limpa Formulário
                Call NovoMateriaPrima()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluirMateriaPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirMateriaPrima.Click

        Try

            'Deleta Registros
            Call DeleteMateriaPrima()

            'Calcula Preço de Venda
            Call CalcularPrecoVenda()

            'Limpa Formulário
            Call NovoMateriaPrima()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboMateriaPrima_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMateriaPrima.SelectedIndexChanged

        Try

            'Limpa Controles
            txtDescricaoMateriaPrima.Text = ""
            txtCustoMedioMateriaPrima.Value = 0
            txtMargemLucroMateriaPrima.Value = 0

            If cboMateriaPrima.SelectedIndex > -1 Then

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Dados do Produto
                Call oClsCadProduto.LoadDadosProduto(cboMateriaPrima.SelectedValue, _
                                                     txtDescricaoMateriaPrima, _
                                                     txtCustoMedioMateriaPrima, _
                                                     txtMargemLucroMateriaPrima)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculoValorUnitarioMateriaPrima(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustoMedioMateriaPrima.ValueChanged, _
                                                                                                              txtMargemLucroMateriaPrima.LostFocus, _
                                                                                                              txtValorUnitarioDescontoMateriaPrima.LostFocus

        Try

            Select Case sender.Name

                Case "txtValorUnitarioDescontoMateriaPrima"
                    If txtValorUnitarioDescontoMateriaPrima.Value <= 0 OrElse txtCustoMedioMateriaPrima.Value = 0 Then
                        txtMargemLucroMateriaPrima.Value = 0
                    Else
                        txtMargemLucroMateriaPrima.Value = (txtValorUnitarioDescontoMateriaPrima.Value - txtCustoMedioMateriaPrima.Value) / txtCustoMedioMateriaPrima.Value * 100
                    End If

                Case "txtCustoMedioMateriaPrima"
                    If txtCustoMedioMateriaPrima.Value = 0 Then
                        txtMargemLucroMateriaPrima.Value = 0
                    Else
                        txtValorUnitarioDescontoMateriaPrima.Value = txtCustoMedioMateriaPrima.Value + (txtCustoMedioMateriaPrima.Value * txtMargemLucroMateriaPrima.Value / 100)
                    End If

                Case "txtMargemLucroMateriaPrima"
                    If txtMargemLucroMateriaPrima.Value = 0 Then
                        txtValorUnitarioDescontoMateriaPrima.Value = txtCustoMedioMateriaPrima.Value
                    Else
                        txtValorUnitarioDescontoMateriaPrima.Value = txtCustoMedioMateriaPrima.Value + (txtCustoMedioMateriaPrima.Value * txtMargemLucroMateriaPrima.Value / 100)
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaValorTotalMateriaPrima() Handles txtQuantidadeMateriaPrima.ValueChanged, _
                                                        txtValorUnitarioDescontoMateriaPrima.ValueChanged

        Try

            'Calcula Valor Total
            txtValorTotalMateriaPrima.Value = txtQuantidadeMateriaPrima.Value * txtValorUnitarioDescontoMateriaPrima.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdMateriaPrima_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMateriaPrima.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMateriaPrima, _
                                     Formulario.ComercialOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdMateriaPrima_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdMateriaPrima.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdMateriaPrima.CurrentColumn) Then Exit Sub

            'Verifica Coluna Pressionada
            Select Case grdMateriaPrima.CurrentColumn.Key

                Case "editar" : Call EditarMateriaPrima()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdMateriaPrima_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdMateriaPrima.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMateriaPrima.Name, _
                                     Formulario.ComercialOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
                                                                           txtValorMargem.LostFocus, _
                                                                           txtValorMateriaPrima.ValueChanged

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
            txtValorSubtotal2.Value = txtValorSubtotal1.Value + txtValorMargem.Value + txtValorMateriaPrima.Value

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
                                                                       txtAliquotaICMS.LostFocus, _
                                                                       txtAliquotaPIS.LostFocus, _
                                                                       txtAliquotaCOFINS.LostFocus, _
                                                                       txtAliquotaIR.LostFocus

        Try

            'Seta Controles
            txtValorICMS.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaICMS.Value), txtAliquotaICMS.Value, 0)
            txtValorPIS.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaPIS.Value), txtAliquotaPIS.Value, 0)
            txtValorCOFINS.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaCOFINS.Value), txtAliquotaCOFINS.Value, 0)
            txtValorIR.Value = txtValorSubtotal3.Value * IIf(IsNumeric(txtAliquotaIR.Value), txtAliquotaIR.Value, 0)

            'Seta Controle
            txtValorTotal.Value = txtValorSubtotal3.Value + txtValorICMS.Value + txtValorPIS.Value + txtValorCOFINS.Value + txtValorIR.Value

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenOrcamentoProduto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo - Dados de Produção
            Call LoadCombo(cboGrupoItem, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa, False)
            'Carrega Combo - Matéria Prima
            Call LoadCombo(cboMateriaPrima, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, 1, NULL, NULL, NULL, NULL, 1", False)
            Call LoadCombo(cboUnidadeMedidaMateriaPrima, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
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
            Dim dAliquotaICMS As Double = 0
            Dim dAliquotaPIS As Double = 0
            Dim dAliquotaCOFINS As Double = 0
            Dim dAliquotaIR As Double = 0
            
            'Carrega Váriaveis
            Call oClsCadProduto.LoadDadosProdutoOrcamento(lCodigoItem, _
                                                          iCodigoGrupoItem, _
                                                          sCodigoItem, _
                                                          sDesenho, _
                                                          sRevisao, _
                                                          sArquivo, _
                                                          sDescricao, _
                                                          iCodigoUnidadeMedida, _
                                                          iCodigoNCM, _
                                                          dMargem, _
                                                          dTaxaFinanceira, _
                                                          dAliquotaICMS, _
                                                          dAliquotaPIS, _
                                                          dAliquotaCOFINS, _
                                                          dAliquotaIR)

            'Seta Controles
            If iCodigoGrupoItem <> -1 Then cboGrupoItem.SelectedValue = iCodigoGrupoItem
            txtCodigo.Text = sCodigoItem
            txtDescricao.Text = sDescricao
            txtDesenho.Text = sDesenho
            txtArquivoDesenho.Text = sArquivo
            txtRevisaoDesenho.Text = sRevisao
            If iCodigoUnidadeMedida <> -1 Then cboUnidadeMedida.SelectedValue = iCodigoUnidadeMedida
            If iCodigoNCM <> -1 Then cboNCM.SelectedValue = iCodigoNCM
            txtMargem.Value = dMargem
            txtTaxaFinanceira.Value = dTaxaFinanceira
            txtAliquotaICMS.Value = dAliquotaICMS
            txtAliquotaPIS.Value = dAliquotaPIS
            txtAliquotaCOFINS.Value = dAliquotaCOFINS
            txtAliquotaIR.Value = dAliquotaIR

            'Calcula Subtotal
            Call CalculoSubtotal2(txtMargem, System.EventArgs.Empty)

            'Configura Grid
            Call ConfiguraGrid(grdProducao, Formulario.ComercialOrcamento)
            Call ConfiguraGrid(grdMateriaPrima, Formulario.ComercialOrcamento)
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
                Call oClsCadProduto.InsertProdutoOrcamento(TipoItem.produto, _
                                                           cboGrupoItem.SelectedValue, _
                                                           txtCodigo.Text.Trim, _
                                                           txtDesenho.Text.Trim, _
                                                           txtRevisaoDesenho.Text.Trim, _
                                                           txtArquivoDesenho.Text.Trim, _
                                                           txtDescricao.Text.Trim, _
                                                           cboUnidadeMedida.SelectedValue, _
                                                           IIf(cboNCM.SelectedIndex = -1, -1, cboNCM.SelectedValue), _
                                                           txtMargem.Value, _
                                                           txtTaxaFinanceira.Value, _
                                                           txtValorTotal.Value, _
                                                           txtAliquotaICMS.Value, _
                                                           txtAliquotaPIS.Value, _
                                                           txtAliquotaCOFINS.Value, _
                                                           txtAliquotaIR.Value)

                'Carrega Váriavel
                lCodigoItem = oClsCadProduto.CodigoProduto

            Else

                'Insere Registro na tb_cad_item
                Call oClsCadProduto.UpdateProdutoOrcamento(TipoItem.produto, _
                                                           cboGrupoItem.SelectedValue, _
                                                           txtCodigo.Text.Trim, _
                                                           txtDesenho.Text.Trim, _
                                                           txtRevisaoDesenho.Text.Trim, _
                                                           txtArquivoDesenho.Text.Trim, _
                                                           txtArquivoDesenho.Tag, _
                                                           txtDescricao.Text.Trim, _
                                                           cboUnidadeMedida.SelectedValue, _
                                                           IIf(cboNCM.SelectedIndex = -1, -1, cboNCM.SelectedValue), _
                                                           txtMargem.Value, _
                                                           txtTaxaFinanceira.Value, _
                                                           txtValorTotal.Value, _
                                                           txtAliquotaICMS.Value, _
                                                           txtAliquotaPIS.Value, _
                                                           txtAliquotaCOFINS.Value, _
                                                           txtAliquotaIR.Value, _
                                                           lCodigoItem)

                Call oClsCadProduto.DeleteOrcamentoItemCentroTrabalho(lCodigoItem)
                Call oClsCadProduto.DeleteOrcamentoItemMateriaPrima(lCodigoItem)
                Call oClsCadProduto.DeleteOrcamentoItemCusto(lCodigoItem)

            End If

            'Insere Registros - Grid
            Call oClsCadProduto.InsertOrcamentoItemCentroTrabalho(lCodigoItem, grdProducao)
            Call oClsCadProduto.InsertOrcamentoItemMateriaPrima(lCodigoItem, grdMateriaPrima)
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

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then
                tabDados.SelectedTab = pagProducao
                cboUnidadeMedida.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: MATÉRIA PRIMA :::"

    Private Sub NovoMateriaPrima()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Produtos
            cboMateriaPrima.SelectedIndex = -1 : cboMateriaPrima.Text = "" : cboMateriaPrima.Tag = ""
            txtDescricaoMateriaPrima.Text = ""
            txtQuantidadeMateriaPrima.Value = 0
            txtCustoMedioMateriaPrima.Value = 0
            cboUnidadeMedidaMateriaPrima.SelectedIndex = -1
            txtMargemLucroMateriaPrima.Value = 0
            txtValorUnitarioDescontoMateriaPrima.Value = 0
            btnInserirMateriaPrima.Tag = ""

            'Seta Focu
            cboMateriaPrima.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteMateriaPrima()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdMateriaPrima) = True Then

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

    Private Sub EditarMateriaPrima()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialOrcamento, gcUpdate) = True Then

                'Carrega Controles
                cboMateriaPrima.SelectedValue = grdMateriaPrima.CurrentRow.Cells("codigo_item").Value
                txtDescricaoMateriaPrima.Text = grdMateriaPrima.CurrentRow.Cells("descricao").Value
                txtQuantidadeMateriaPrima.Value = grdMateriaPrima.CurrentRow.Cells("quantidade").Value
                cboUnidadeMedidaMateriaPrima.SelectedValue = grdMateriaPrima.CurrentRow.Cells("codigo_unidade_medida").Value
                txtCustoMedioMateriaPrima.Value = grdMateriaPrima.CurrentRow.Cells("custo_medio").Value
                txtMargemLucroMateriaPrima.Value = grdMateriaPrima.CurrentRow.Cells("margem_lucro").Value
                txtValorUnitarioDescontoMateriaPrima.Value = grdMateriaPrima.CurrentRow.Cells("preco_venda").Value
                txtValorTotalMateriaPrima.Value = grdMateriaPrima.CurrentRow.Cells("valor_total").Value
                btnInserirMateriaPrima.Tag = grdMateriaPrima.CurrentRow.Cells("codigo_item").Value

                'Seta Focu
                cboMateriaPrima.Focus()

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

    Private Sub SaveMateriaPrimaGrid(ByVal oGrid As GridEX, _
                                     ByVal lCodigoProduto As Long, _
                                     ByVal sCodigoProduto As String, _
                                     ByVal sDescricao As String, _
                                     ByVal dQuantidade As Double, _
                                     ByVal iCodigoUnidadeMedida As Integer, _
                                     ByVal sUnidadeMedida As String, _
                                     ByVal dCustoMedio As Double, _
                                     ByVal dMargemLucro As Double, _
                                     ByVal dPrecoVenda As Double, _
                                     ByVal dValorTotal As Double, _
                                     ByVal lCodigoProdutoAntigo As Long)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCCodigoProduto As New DataColumn("codigo_produto")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCUnidadeMedida As New DataColumn("unidade_medida")
            Dim oDCPrecoVenda As New DataColumn("preco_venda")
            Dim oDCCustoMedio As New DataColumn("custo_medio")
            Dim oDCMargemLucro As New DataColumn("margem_lucro")
            Dim oDCValorTotal As New DataColumn("valor_total")
            Dim oDCCodigoUnidadeMedida As New DataColumn("codigo_unidade_medida")
            Dim oDCCodigoItem As New DataColumn("codigo_item")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCodigoProduto)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCUnidadeMedida)
                oDataTable.Columns.Add(oDCPrecoVenda)
                oDataTable.Columns.Add(oDCMargemLucro)
                oDataTable.Columns.Add(oDCCustoMedio)
                oDataTable.Columns.Add(oDCValorTotal)
                oDataTable.Columns.Add(oDCCodigoUnidadeMedida)
                oDataTable.Columns.Add(oDCCodigoItem)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
                oDCPrecoVenda.DataType = 0.0.GetType
                oDCCustoMedio.DataType = 0.0.GetType
                oDCMargemLucro.DataType = 0.0.GetType
                oDCValorTotal.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If lCodigoProdutoAntigo = -1 Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("codigo_produto") = sCodigoProduto
                oDataRow("descricao") = sDescricao
                oDataRow("quantidade") = dQuantidade
                oDataRow("unidade_medida") = sUnidadeMedida
                oDataRow("preco_venda") = dPrecoVenda
                oDataRow("custo_medio") = dCustoMedio
                oDataRow("margem_lucro") = dMargemLucro
                oDataRow("valor_total") = dValorTotal
                oDataRow("codigo_unidade_medida") = iCodigoUnidadeMedida
                oDataRow("codigo_item") = lCodigoProduto
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo_item = " & lCodigoProdutoAntigo & ")")(0)
                oDataRow("codigo_produto") = sCodigoProduto
                oDataRow("descricao") = sDescricao
                oDataRow("quantidade") = dQuantidade
                oDataRow("unidade_medida") = sUnidadeMedida
                oDataRow("preco_venda") = dPrecoVenda
                oDataRow("preco_venda") = dPrecoVenda
                oDataRow("custo_medio") = dCustoMedio
                oDataRow("margem_lucro") = dMargemLucro
                oDataRow("valor_total") = dValorTotal
                oDataRow("codigo_unidade_medida") = iCodigoUnidadeMedida
                oDataRow("codigo_item") = lCodigoProduto
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

    Private Function ValidacaoMateriaPrima() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoMateriaPrima = False

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboMateriaPrima, lblMateriaPrima) = False Then
                Exit Function
            End If

            'Verifica se o Produto já está inserido no Pedido de Venda
            If grdMateriaPrima.GetDataRows.Count > 0 Then
                If IsNumeric(btnInserirMateriaPrima.Tag) Then
                    If VerificaExisteValorGrid(grdMateriaPrima, "codigo_item", cboMateriaPrima.SelectedValue, grdMateriaPrima.CurrentRow.RowIndex) = True Then
                        frmMain.errInfo.SetError(lblMateriaPrima, "Este Produto: " & cboMateriaPrima.Text & " já se encontra cadastrado.")
                        cboMateriaPrima.Focus()
                        Exit Function
                    End If
                Else
                    If VerificaExisteValorGrid(grdMateriaPrima, "codigo_item", cboMateriaPrima.SelectedValue, -1) = True Then
                        frmMain.errInfo.SetError(lblMateriaPrima, "Este Produto: " & cboMateriaPrima.Text & " já se encontra cadastrado.")
                        cboMateriaPrima.Focus()
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeMateriaPrima, lblQuantidadeMateriaPrima, True) = False Then
                Exit Function
            End If

            If cboUnidadeMedidaMateriaPrima.Enabled = True Then
                'Verifica se foi Selecionado o Campo - Unidade de Medida
                If ValidaCampo(cboUnidadeMedidaMateriaPrima, lblUnidadeMedidaMateriaPrima) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If txtValorUnitarioDescontoMateriaPrima.Enabled = True Then
                If ValidaCampo(txtValorUnitarioDescontoMateriaPrima, lblValorUnitarioDescontoMateriaPrima, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Desconto %
            If txtMargemLucroMateriaPrima.Value < 0 Then
                frmMain.errInfo.SetError(lblMargemLucroMateriaPrima, "O Campo [MARGEM (%)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtMargemLucroMateriaPrima.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoMateriaPrima = True

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

            'Matéria Prima
            If grdMateriaPrima.GetDataRows.Count > 0 Then
                txtValorMateriaPrima.Value = grdMateriaPrima.GetTotalRow.Cells("valor_total").Value
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